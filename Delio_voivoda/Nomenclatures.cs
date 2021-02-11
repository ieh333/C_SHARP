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
    public partial class Nomenclatures : MetroFramework.Forms.MetroForm
    {
        public Nomenclatures()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String type_product, number_product, product_id;
            int iType_product, iProduct_id;

            String connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=DESKTOP-PAF3ORT\\SQLEXPRESS;Initial Catalog=delio_voivoda;Integrated Security=True";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "INSERT INTO Nomenclatures VALUES (@TypeProduct, @NumberProduct, @ProductID)";
            type_product = tbxType.Text;
            type_product = type_product.Trim();

            try
            {
                iType_product = int.Parse(type_product);
            }
            catch (Exception ex)
            {
                iType_product = 0;
                MessageBox.Show("Въведеният низ не може да бъде преобразуван в число!!!", ex.Message);
            }

            number_product = tbxNumber.Text;
            number_product = number_product.Trim();

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

            cmd.Parameters.AddWithValue("@TypeProduct", iType_product);
            cmd.Parameters.AddWithValue("@NumberProduct", number_product);
            cmd.Parameters.AddWithValue("@ProductID", iProduct_id);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данните са въведени успешно!!!");
                tbxType.Text = null;
                tbxNumber.Text = null;
                cmbProductID.SelectedIndex = -1;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Базата данни не се отваря!", ex.Message);
            }
        }

        private void Nomenclatures_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'delio_voivodaDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.delio_voivodaDataSet.Products);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxType.Text = null;
            tbxNumber.Text = null;
            cmbProductID.SelectedIndex = -1;
        }
    }
}
