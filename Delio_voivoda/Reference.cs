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
    public partial class Reference : MetroFramework.Forms.MetroForm
    {
        public Reference()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            bool bChecked_quantity, bChecked_price;
            bChecked_quantity = rbtnReference_quantity.Checked;
            bChecked_price = rbtnReference_price.Checked;

            String connectionString = null;
            SqlConnection conn;
            connectionString = "Data Source=DESKTOP-PAF3ORT\\SQLEXPRESS;Initial Catalog=delio_voivoda;Integrated Security=True";
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            SqlDataAdapter adapter;
            DataTable dt;
            if(bChecked_quantity==true)
            {
                cmd.CommandText = "SELECT Deliveries.DeliveryDate, Products.Name, Products.Quantity FROM Deliveries INNER JOIN Products ON Deliveries.MaterialID=Products.MaterialID";
            }
            if(bChecked_price==true)
            {
                cmd.CommandText = "SELECT Deliveries.DeliveryDate, Products.Name, Products.Price FROM Deliveries INNER JOIN Products ON Deliveries.MaterialID=Products.MaterialID";
            }
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dgridReference.DataSource = dt;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rbtnReference_quantity.Checked = false;
            rbtnReference_price.Checked = false;
            dgridReference.DataSource = null;
            dgridReference.Refresh();
        }
    }
}
