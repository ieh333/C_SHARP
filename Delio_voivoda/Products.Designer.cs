
namespace Delio_voivoda
{
    partial class Products
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
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.lblPrice = new MetroFramework.Controls.MetroLabel();
            this.lblQuantity = new MetroFramework.Controls.MetroLabel();
            this.lblMaterialID = new MetroFramework.Controls.MetroLabel();
            this.tbxName = new MetroFramework.Controls.MetroTextBox();
            this.tbxPrice = new MetroFramework.Controls.MetroTextBox();
            this.tbxQuantity = new MetroFramework.Controls.MetroTextBox();
            this.cmbMaterialID = new MetroFramework.Controls.MetroComboBox();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.delio_voivodaDataSet = new Delio_voivoda.delio_voivodaDataSet();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.materialsTableAdapter = new Delio_voivoda.delio_voivodaDataSetTableAdapters.MaterialsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delio_voivodaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 88);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Наименование";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(484, 88);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 19);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Цена";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(23, 135);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(79, 19);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Количество";
            // 
            // lblMaterialID
            // 
            this.lblMaterialID.AutoSize = true;
            this.lblMaterialID.Location = new System.Drawing.Point(484, 135);
            this.lblMaterialID.Name = "lblMaterialID";
            this.lblMaterialID.Size = new System.Drawing.Size(124, 19);
            this.lblMaterialID.TabIndex = 3;
            this.lblMaterialID.Text = "Код на суровината";
            // 
            // tbxName
            // 
            // 
            // 
            // 
            this.tbxName.CustomButton.Image = null;
            this.tbxName.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.tbxName.CustomButton.Name = "";
            this.tbxName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxName.CustomButton.TabIndex = 1;
            this.tbxName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxName.CustomButton.UseSelectable = true;
            this.tbxName.CustomButton.Visible = false;
            this.tbxName.Lines = new string[0];
            this.tbxName.Location = new System.Drawing.Point(131, 84);
            this.tbxName.MaxLength = 32767;
            this.tbxName.Name = "tbxName";
            this.tbxName.PasswordChar = '\0';
            this.tbxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxName.SelectedText = "";
            this.tbxName.SelectionLength = 0;
            this.tbxName.SelectionStart = 0;
            this.tbxName.ShortcutsEnabled = true;
            this.tbxName.Size = new System.Drawing.Size(75, 23);
            this.tbxName.TabIndex = 4;
            this.tbxName.UseSelectable = true;
            this.tbxName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxPrice
            // 
            // 
            // 
            // 
            this.tbxPrice.CustomButton.Image = null;
            this.tbxPrice.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.tbxPrice.CustomButton.Name = "";
            this.tbxPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxPrice.CustomButton.TabIndex = 1;
            this.tbxPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxPrice.CustomButton.UseSelectable = true;
            this.tbxPrice.CustomButton.Visible = false;
            this.tbxPrice.Lines = new string[0];
            this.tbxPrice.Location = new System.Drawing.Point(531, 84);
            this.tbxPrice.MaxLength = 32767;
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.PasswordChar = '\0';
            this.tbxPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxPrice.SelectedText = "";
            this.tbxPrice.SelectionLength = 0;
            this.tbxPrice.SelectionStart = 0;
            this.tbxPrice.ShortcutsEnabled = true;
            this.tbxPrice.Size = new System.Drawing.Size(75, 23);
            this.tbxPrice.TabIndex = 5;
            this.tbxPrice.UseSelectable = true;
            this.tbxPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxQuantity
            // 
            // 
            // 
            // 
            this.tbxQuantity.CustomButton.Image = null;
            this.tbxQuantity.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.tbxQuantity.CustomButton.Name = "";
            this.tbxQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxQuantity.CustomButton.TabIndex = 1;
            this.tbxQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxQuantity.CustomButton.UseSelectable = true;
            this.tbxQuantity.CustomButton.Visible = false;
            this.tbxQuantity.Lines = new string[0];
            this.tbxQuantity.Location = new System.Drawing.Point(108, 131);
            this.tbxQuantity.MaxLength = 32767;
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.PasswordChar = '\0';
            this.tbxQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxQuantity.SelectedText = "";
            this.tbxQuantity.SelectionLength = 0;
            this.tbxQuantity.SelectionStart = 0;
            this.tbxQuantity.ShortcutsEnabled = true;
            this.tbxQuantity.Size = new System.Drawing.Size(75, 23);
            this.tbxQuantity.TabIndex = 6;
            this.tbxQuantity.UseSelectable = true;
            this.tbxQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbMaterialID
            // 
            this.cmbMaterialID.DataSource = this.materialsBindingSource;
            this.cmbMaterialID.DisplayMember = "MaterialID";
            this.cmbMaterialID.FormattingEnabled = true;
            this.cmbMaterialID.ItemHeight = 23;
            this.cmbMaterialID.Location = new System.Drawing.Point(614, 125);
            this.cmbMaterialID.Name = "cmbMaterialID";
            this.cmbMaterialID.Size = new System.Drawing.Size(121, 29);
            this.cmbMaterialID.TabIndex = 7;
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(131, 243);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 30);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Добави";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(531, 243);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 30);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Изчисти";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbMaterialID);
            this.Controls.Add(this.tbxQuantity);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblMaterialID);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Name = "Products";
            this.Text = "Продукти";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delio_voivodaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblPrice;
        private MetroFramework.Controls.MetroLabel lblQuantity;
        private MetroFramework.Controls.MetroLabel lblMaterialID;
        private MetroFramework.Controls.MetroTextBox tbxName;
        private MetroFramework.Controls.MetroTextBox tbxPrice;
        private MetroFramework.Controls.MetroTextBox tbxQuantity;
        private MetroFramework.Controls.MetroComboBox cmbMaterialID;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnClear;
        private delio_voivodaDataSet delio_voivodaDataSet;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private delio_voivodaDataSetTableAdapters.MaterialsTableAdapter materialsTableAdapter;
    }
}