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
    public partial class Providers : MetroFramework.Forms.MetroForm
    {
        public Providers()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String name, city, address, phone, email, material_id;
            int iMaterial_id;
       
            String connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=DESKTOP-PAF3ORT\\SQLEXPRESS;Initial Catalog=delio_voivoda;Integrated Security=True";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "INSERT INTO Providers VALUES (@Name, @City, @Address, @Phone, @Email, @MaterialID)";
            name = tbxName.Text;
            name = name.Trim();

            city = tbxCity.Text;
            city = city.Trim();

            address = tbxAddress.Text;
            address = address.Trim();

            phone = tbxPhone.Text;
            phone = phone.Trim();

            email = tbxEmail.Text;
            email = email.Trim();

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
            cmd.Parameters.AddWithValue("@City", city);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@MaterialID", iMaterial_id);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данните са въведени успешно!!!");
                tbxName.Text = null;
                tbxCity.Text = null;
                tbxAddress.Text = null;
                tbxPhone.Text = null;
                tbxEmail.Text = null;
                cmbMaterialID.SelectedIndex = -1;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Базата данни не се отваря!", ex.Message);
            }
            
        }

        private void Providers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'delio_voivodaDataSet.Materials' table. You can move, or remove it, as needed.
            this.materialsTableAdapter.Fill(this.delio_voivodaDataSet.Materials);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxName.Text = null;
            tbxCity.Text = null;
            tbxAddress.Text = null;
            tbxPhone.Text = null;
            tbxEmail.Text = null;
            cmbMaterialID.SelectedIndex = -1;
        }
    }
}
