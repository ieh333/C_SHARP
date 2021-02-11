
namespace Delio_voivoda
{
    partial class Deliveries
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
            this.components = new System.ComponentModel.Container();
            this.lblDeliveryDate = new MetroFramework.Controls.MetroLabel();
            this.lblMaterialID = new MetroFramework.Controls.MetroLabel();
            this.lblProviderID = new MetroFramework.Controls.MetroLabel();
            this.cmbMaterialID = new MetroFramework.Controls.MetroComboBox();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.delio_voivodaDataSet = new Delio_voivoda.delio_voivodaDataSet();
            this.cmbProviderID = new MetroFramework.Controls.MetroComboBox();
            this.providersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.materialsTableAdapter = new Delio_voivoda.delio_voivodaDataSetTableAdapters.MaterialsTableAdapter();
            this.providersTableAdapter = new Delio_voivoda.delio_voivodaDataSetTableAdapters.ProvidersTableAdapter();
            this.dateDelivery = new MetroFramework.Controls.MetroDateTime();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delio_voivodaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Location = new System.Drawing.Point(23, 102);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(125, 19);
            this.lblDeliveryDate.TabIndex = 0;
            this.lblDeliveryDate.Text = "Дата на доставката";
            // 
            // lblMaterialID
            // 
            this.lblMaterialID.AutoSize = true;
            this.lblMaterialID.Location = new System.Drawing.Point(406, 102);
            this.lblMaterialID.Name = "lblMaterialID";
            this.lblMaterialID.Size = new System.Drawing.Size(124, 19);
            this.lblMaterialID.TabIndex = 1;
            this.lblMaterialID.Text = "Код на суровината";
            // 
            // lblProviderID
            // 
            this.lblProviderID.AutoSize = true;
            this.lblProviderID.Location = new System.Drawing.Point(23, 180);
            this.lblProviderID.Name = "lblProviderID";
            this.lblProviderID.Size = new System.Drawing.Size(122, 19);
            this.lblProviderID.TabIndex = 2;
            this.lblProviderID.Text = "Код на доставчика";
            // 
            // cmbMaterialID
            // 
            this.cmbMaterialID.DataSource = this.materialsBindingSource;
            this.cmbMaterialID.DisplayMember = "MaterialID";
            this.cmbMaterialID.FormattingEnabled = true;
            this.cmbMaterialID.ItemHeight = 23;
            this.cmbMaterialID.Location = new System.Drawing.Point(536, 92);
            this.cmbMaterialID.Name = "cmbMaterialID";
            this.cmbMaterialID.Size = new System.Drawing.Size(121, 29);
            this.cmbMaterialID.TabIndex = 3;
            this.cmbMaterialID.UseSelectable = true;
            // 
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "Materials";
            this.materialsBindingSource.DataSource = this.delio_voivodaDataSet;
            // 
            // delio_voivodaDataSet
            // 
            this.delio_voivodaDataSet.DataSetName = "delio_voivodaDataSet";
            this.delio_voivodaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbProviderID
            // 
            this.cmbProviderID.DataSource = this.providersBindingSource;
            this.cmbProviderID.DisplayMember = "ProviderID";
            this.cmbProviderID.FormattingEnabled = true;
            this.cmbProviderID.ItemHeight = 23;
            this.cmbProviderID.Location = new System.Drawing.Point(151, 170);
            this.cmbProviderID.Name = "cmbProviderID";
            this.cmbProviderID.Size = new System.Drawing.Size(121, 29);
            this.cmbProviderID.TabIndex = 4;
            this.cmbProviderID.UseSelectable = true;
            // 
            // providersBindingSource
            // 
            this.providersBindingSource.DataMember = "Providers";
            this.providersBindingSource.DataSource = this.delio_voivodaDataSet;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(154, 270);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добави";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(536, 270);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 30);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Изчисти";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // providersTableAdapter
            // 
            this.providersTableAdapter.ClearBeforeFill = true;
            // 
            // dateDelivery
            // 
            this.dateDelivery.Location = new System.Drawing.Point(154, 92);
            this.dateDelivery.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateDelivery.Name = "dateDelivery";
            this.dateDelivery.Size = new System.Drawing.Size(200, 29);
            this.dateDelivery.TabIndex = 8;
            // 
            // Deliveries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateDelivery);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbProviderID);
            this.Controls.Add(this.cmbMaterialID);
            this.Controls.Add(this.lblProviderID);
            this.Controls.Add(this.lblMaterialID);
            this.Controls.Add(this.lblDeliveryDate);
            this.Name = "Deliveries";
            this.Text = "Доставки";
            this.Load += new System.EventHandler(this.Deliveries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delio_voivodaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblDeliveryDate;
        private MetroFramework.Controls.MetroLabel lblMaterialID;
        private MetroFramework.Controls.MetroLabel lblProviderID;
        private MetroFramework.Controls.MetroComboBox cmbMaterialID;
        private MetroFramework.Controls.MetroComboBox cmbProviderID;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnClear;
        private delio_voivodaDataSet delio_voivodaDataSet;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private delio_voivodaDataSetTableAdapters.MaterialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.BindingSource providersBindingSource;
        private delio_voivodaDataSetTableAdapters.ProvidersTableAdapter providersTableAdapter;
        private MetroFramework.Controls.MetroDateTime dateDelivery;
    }
}