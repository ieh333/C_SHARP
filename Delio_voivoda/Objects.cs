using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delio_voivoda
{
    public partial class Objects : MetroFramework.Forms.MetroForm
    {
        public Objects()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String name, city, address, type, product_id;
            int iProduct_id;

            String connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=DESKTOP-PAF3ORT\\SQLEXPRESS;Initial Catalog=delio_voivoda;Integrated Security=True";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "INSERT INTO Objects VALUES (@Name, @City, @Address, @Type, @ProductID)";
            name = tbxName.Text;
            name = name.Trim();

            city = tbxCity.Text;
            city = city.Trim();

            address = tbxAddress.Text;
            address = address.Trim();

            type = tbxType.Text;
            type = type.Trim();

            if (cmbProductID.SelectedIndex != -1)
            {
                product_id = cmbProductID.Text;
                product_id = product_id.Trim();
            }
            else
            {
                product_id = "";
            }

            try
            {
                iProduct_id = int.Parse(product_id);
            }
            catch (Exception ex)
            {
                iProduct_id = 0;
                MessageBox.Show("Въведеният низ не може да бъде преобразуван в число!!!", ex.Message);
            }

            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@City", city);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.Parameters.AddWithValue("@Type", type);
            cmd.Parameters.AddWithValue("@ProductID", iProduct_id);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данните са въведени успешно!!!");
                tbxName.Text = null;
                tbxCity.Text = null;
                tbxAddress.Text = null;
                tbxType.Text = null;
                cmbProductID.SelectedIndex = -1;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Базата данни не се отваря!", ex.Message);
            }
        }

        private void Objects_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'delio_voivodaDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.delio_voivodaDataSet.Products);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxName.Text = null;
            tbxCity.Text = null;
            tbxAddress.Text = null;
            tbxType.Text = null;
            cmbProductID.SelectedIndex = -1;
        }
    }
}
