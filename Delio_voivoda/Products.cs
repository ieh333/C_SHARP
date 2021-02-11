using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delio_voivoda
{
    public partial class Products : MetroFramework.Forms.MetroForm
    {
        public Products()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String name, price, quantity, material_id;
            decimal decPrice;
            int iQuantity, iMaterial_id;

            String connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=DESKTOP-PAF3ORT\\SQLEXPRESS;Initial Catalog=delio_voivoda;Integrated Security=True";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "INSERT INTO Products VALUES (@Name, @Price, @Quantity, @MaterialID)";
            name = tbxName.Text;
            name = name.Trim();

            price = tbxPrice.Text;
            price = price.Trim();

            try
            {
                price = price.Replace(",", ".");
                decPrice = decimal.Parse(price, new CultureInfo("en-US"));

            }
            catch (Exception ex)
            {
                decPrice = 0.00m;
                MessageBox.Show("Въведеният низ не може да бъде преобразуван в число!!!", ex.Message);
            }

            quantity = tbxQuantity.Text;
            quantity = quantity.Trim();

            try
            {
                iQuantity = int.Parse(quantity);
            }
            catch (Exception ex)
            {
                iQuantity = 0;
                MessageBox.Show("Въведеният низ не може да бъде преобразуван в число!!!", ex.Message);
            }

            if(cmbMaterialID.SelectedIndex!=-1)
            {
                material_id = cmbMaterialID.Text;
                material_id = material_id.Trim();
            }
            else
            {
                material_id = "";
            }

            try
            {
                iMaterial_id = int.Parse(material_id);
            }
            catch (Exception ex)
            {
                iMaterial_id = 0;
                MessageBox.Show("Въведеният низ не може да бъде преобразуван в число!!!", ex.Message);
            }

            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Price", decPrice);
            cmd.Parameters.AddWithValue("@Quantity", iQuantity);
            cmd.Parameters.AddWithValue("@MaterialID", iMaterial_id);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данните са въведени успешно!!!");
                tbxName.Text = null;
                tbxPrice.Text = null;
                tbxQuantity.Text = null;
                cmbMaterialID.SelectedIndex = -1;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Базата данни не се отваря!", ex.Message);
            }

        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'delio_voivodaDataSet.Materials' table. You can move, or remove it, as needed.
            this.materialsTableAdapter.Fill(this.delio_voivodaDataSet.Materials);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxName.Text = null;
            tbxPrice.Text = null;
            tbxQuantity.Text = null;
            cmbMaterialID.SelectedIndex = -1;
        }
    }
}
