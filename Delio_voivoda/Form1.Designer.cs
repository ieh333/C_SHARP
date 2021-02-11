
namespace Delio_voivoda
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.Reference = new MetroFramework.Controls.MetroButton();
            this.Nomenclatures = new MetroFramework.Controls.MetroButton();
            this.Deliveries = new MetroFramework.Controls.MetroButton();
            this.Products = new MetroFramework.Controls.MetroButton();
            this.Objects = new MetroFramework.Controls.MetroButton();
            this.Providers = new MetroFramework.Controls.MetroButton();
            this.Materials = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.Reference);
            this.metroPanel1.Controls.Add(this.Nomenclatures);
            this.metroPanel1.Controls.Add(this.Deliveries);
            this.metroPanel1.Controls.Add(this.Products);
            this.metroPanel1.Controls.Add(this.Objects);
            this.metroPanel1.Controls.Add(this.Providers);
            this.metroPanel1.Controls.Add(this.Materials);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.metroPanel1, "metroPanel1");
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // Reference
            // 
            resources.ApplyResources(this.Reference, "Reference");
            this.Reference.Name = "Reference";
            this.Reference.UseSelectable = true;
            this.Reference.Click += new System.EventHandler(this.Reference_Click);
            // 
            // Nomenclatures
            // 
            resources.ApplyResources(this.Nomenclatures, "Nomenclatures");
            this.Nomenclatures.Name = "Nomenclatures";
            this.Nomenclatures.UseSelectable = true;
            this.Nomenclatures.Click += new System.EventHandler(this.Nomenclatures_Click);
            // 
            // Deliveries
            // 
            resources.ApplyResources(this.Deliveries, "Deliveries");
            this.Deliveries.Name = "Deliveries";
            this.Deliveries.UseSelectable = true;
            this.Deliveries.Click += new System.EventHandler(this.Deliveries_Click);
            // 
            // Products
            // 
            resources.ApplyResources(this.Products, "Products");
            this.Products.Name = "Products";
            this.Products.UseSelectable = true;
            this.Products.Click += new System.EventHandler(this.products_Click);
            // 
            // Objects
            // 
            resources.ApplyResources(this.Objects, "Objects");
            this.Objects.Name = "Objects";
            this.Objects.UseSelectable = true;
            this.Objects.Click += new System.EventHandler(this.objects_Click);
            // 
            // Providers
            // 
            resources.ApplyResources(this.Providers, "Providers");
            this.Providers.Name = "Providers";
            this.Providers.UseSelectable = true;
            this.Providers.Click += new System.EventHandler(this.providers_Click);
            // 
            // Materials
            // 
            resources.ApplyResources(this.Materials, "Materials");
            this.Materials.Name = "Materials";
            this.Materials.UseSelectable = true;
            this.Materials.Click += new System.EventHandler(this.materials_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "MainForm";
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton Materials;
        private MetroFramework.Controls.MetroButton Products;
        private MetroFramework.Controls.MetroButton Objects;
        private MetroFramework.Controls.MetroButton Providers;
        private MetroFramework.Controls.MetroButton Deliveries;
        private MetroFramework.Controls.MetroButton Nomenclatures;
        private MetroFramework.Controls.MetroButton Reference;
    }
}

