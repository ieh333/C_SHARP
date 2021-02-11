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
    public partial class Materials : MetroFramework.Forms.MetroForm
    {
        public Materials()
        {
            InitializeComponent();
        }

        private void tbxAdd_Click(object sender, EventArgs e)
        {
            String name, price, quantity;
            decimal decPrice;
            int iQuantity;

            String connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=DESKTOP-PAF3ORT\\SQLEXPRESS;Initial Catalog=delio_voivoda;Integrated Security=True";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "INSERT INTO Materials VALUES (@Name, @Price, @Quantity)";
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

            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Price", decPrice);
            cmd.Parameters.AddWithValue("@Quantity", iQuantity);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данните са въведени успешно!!!");
                tbxName.Text = null;
                tbxPrice.Text = null;
                tbxQuantity.Text = null;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Базата данни не се отваря!", ex.Message);
            }
        }

        private void tbxClear_Click(object sender, EventArgs e)
        {
            tbxName.Text = null;
            tbxPrice.Text = null;
            tbxQuantity.Text = null;
        }
    }
}
