using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delio_voivoda
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void providers_Click(object sender, EventArgs e)
        {
            Providers providers = new Providers();
            providers.Show();
        }

        private void materials_Click(object sender, EventArgs e)
        {
            Materials materials = new Materials();
            materials.Show();
        }

        private void objects_Click(object sender, EventArgs e)
        {
            Objects objects = new Objects();
            objects.Show();
        }

        private void products_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
        }

        private void Nomenclatures_Click(object sender, EventArgs e)
        {
            Nomenclatures nomenclatures = new Nomenclatures();
            nomenclatures.Show();
        }

        private void Deliveries_Click(object sender, EventArgs e)
        {
            Deliveries deliveries = new Deliveries();
            deliveries.Show();
        }

        private void Reference_Click(object sender, EventArgs e)
        {
            Reference report = new Reference();
            report.Show();
        }
    }
}
