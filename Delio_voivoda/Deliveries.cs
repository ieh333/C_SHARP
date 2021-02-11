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
    public partial class Deliveries : MetroFramework.Forms.MetroForm
    {
        public Deliveries()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String material_id, provider_id;
            String dateString;
            int iMaterial_id, iProvider_id;
            CultureInfo culture = new CultureInfo("bg-BG");

            String connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=DESKTOP-PAF3ORT\\SQLEXPRESS;Initial Catalog=delio_voivoda;Integrated Security=True";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "INSERT INTO Deliveries VALUES (@DeliveryDate, @MaterialID, @ProviderID)";
            dateString = dateDelivery.Value.ToShortDateString();
            DateTime date_delivery = DateTime.Parse(dateString, culture);
            


            if (cmbMaterialID.SelectedIndex != -1)
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

            if (cmbProviderID.SelectedIndex != -1)
            {
                provider_id = cmbProviderID.Text;
                provider_id = provider_id.Trim();
            }
            else
            {
                provider_id = "";
            }

            try
            {
                iProvider_id = int.Parse(provider_id);
            }
            catch (Exception ex)
            {
                iProvider_id = 0;
                MessageBox.Show("Въведеният низ не може да бъде преобразуван в число!!!", ex.Message);
            }

            cmd.Parameters.AddWithValue("@DeliveryDate", date_delivery);
            cmd.Parameters.AddWithValue("@MaterialID", iMaterial_id);
            cmd.Parameters.AddWithValue("@ProviderID", iProvider_id);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данните са въведени успешно!!!");

                dateDelivery.Value = DateTime.Now;
                cmbMaterialID.SelectedIndex = -1;
                cmbProviderID.SelectedIndex = -1;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Базата данни не се отваря!", ex.Message);
            }
        }

        private void Deliveries_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'delio_voivodaDataSet.Providers' table. You can move, or remove it, as needed.
            this.providersTableAdapter.Fill(this.delio_voivodaDataSet.Providers);
            // TODO: This line of code loads data into the 'delio_voivodaDataSet.Materials' table. You can move, or remove it, as needed.
            this.materialsTableAdapter.Fill(this.delio_voivodaDataSet.Materials);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            dateDelivery.Value = DateTime.Now;
            cmbMaterialID.SelectedIndex = -1;
            cmbProviderID.SelectedIndex = -1;
        }
    }
}
