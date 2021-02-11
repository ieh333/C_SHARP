
namespace Delio_voivoda
{
    partial class Providers
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
            this.lblCity = new MetroFramework.Controls.MetroLabel();
            this.lblAddress = new MetroFramework.Controls.MetroLabel();
            this.lblPhone = new MetroFramework.Controls.MetroLabel();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.lblMaterialID = new MetroFramework.Controls.MetroLabel();
            this.tbxName = new MetroFramework.Controls.MetroTextBox();
            this.tbxCity = new MetroFramework.Controls.MetroTextBox();
            this.tbxAddress = new MetroFramework.Controls.MetroTextBox();
            this.tbxPhone = new MetroFramework.Controls.MetroTextBox();
            this.tbxEmail = new MetroFramework.Controls.MetroTextBox();
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
            this.lblName.Location = new System.Drawing.Point(23, 78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(126, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Име на доставчика";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(430, 78);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(37, 19);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "Град";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(23, 137);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(46, 19);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Адрес";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(430, 137);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(62, 19);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Телефон";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(23, 209);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 19);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblMaterialID
            // 
            this.lblMaterialID.AutoSize = true;
            this.lblMaterialID.Location = new System.Drawing.Point(430, 209);
            this.lblMaterialID.Name = "lblMaterialID";
            this.lblMaterialID.Size = new System.Drawing.Size(124, 19);
            this.lblMaterialID.TabIndex = 5;
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
            this.tbxName.Location = new System.Drawing.Point(155, 78);
            this.tbxName.MaxLength = 32767;
            this.tbxName.Name = "tbxName";
            this.tbxName.PasswordChar = '\0';
            this.tbxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxName.SelectedText = "";
            this.tbxName.SelectionLength = 0;
            this.tbxName.SelectionStart = 0;
            this.tbxName.ShortcutsEnabled = true;
            this.tbxName.Size = new System.Drawing.Size(75, 23);
            this.tbxName.TabIndex = 6;
            this.tbxName.UseSelectable = true;
            this.tbxName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxCity
            // 
            // 
            // 
            // 
            this.tbxCity.CustomButton.Image = null;
            this.tbxCity.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.tbxCity.CustomButton.Name = "";
            this.tbxCity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxCity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxCity.CustomButton.TabIndex = 1;
            this.tbxCity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxCity.CustomButton.UseSelectable = true;
            this.tbxCity.CustomButton.Visible = false;
            this.tbxCity.Lines = new string[0];
            this.tbxCity.Location = new System.Drawing.Point(473, 78);
            this.tbxCity.MaxLength = 32767;
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.PasswordChar = '\0';
            this.tbxCity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxCity.SelectedText = "";
            this.tbxCity.SelectionLength = 0;
            this.tbxCity.SelectionStart = 0;
            this.tbxCity.ShortcutsEnabled = true;
            this.tbxCity.Size = new System.Drawing.Size(75, 23);
            this.tbxCity.TabIndex = 7;
            this.tbxCity.UseSelectable = true;
            this.tbxCity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxCity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxAddress
            // 
            // 
            // 
            // 
            this.tbxAddress.CustomButton.Image = null;
            this.tbxAddress.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.tbxAddress.CustomButton.Name = "";
            this.tbxAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxAddress.CustomButton.TabIndex = 1;
            this.tbxAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxAddress.CustomButton.UseSelectable = true;
            this.tbxAddress.CustomButton.Visible = false;
            this.tbxAddress.Lines = new string[0];
            this.tbxAddress.Location = new System.Drawing.Point(75, 137);
            this.tbxAddress.MaxLength = 32767;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.PasswordChar = '\0';
            this.tbxAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxAddress.SelectedText = "";
            this.tbxAddress.SelectionLength = 0;
            this.tbxAddress.SelectionStart = 0;
            this.tbxAddress.ShortcutsEnabled = true;
            this.tbxAddress.Size = new System.Drawing.Size(75, 23);
            this.tbxAddress.TabIndex = 8;
            this.tbxAddress.UseSelectable = true;
            this.tbxAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxPhone
            // 
            // 
            // 
            // 
            this.tbxPhone.CustomButton.Image = null;
            this.tbxPhone.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.tbxPhone.CustomButton.Name = "";
            this.tbxPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxPhone.CustomButton.TabIndex = 1;
            this.tbxPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxPhone.CustomButton.UseSelectable = true;
            this.tbxPhone.CustomButton.Visible = false;
            this.tbxPhone.Lines = new string[0];
            this.tbxPhone.Location = new System.Drawing.Point(498, 133);
            this.tbxPhone.MaxLength = 32767;
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.PasswordChar = '\0';
            this.tbxPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxPhone.SelectedText = "";
            this.tbxPhone.SelectionLength = 0;
            this.tbxPhone.SelectionStart = 0;
            this.tbxPhone.ShortcutsEnabled = true;
            this.tbxPhone.Size = new System.Drawing.Size(75, 23);
            this.tbxPhone.TabIndex = 9;
            this.tbxPhone.UseSelectable = true;
            this.tbxPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxEmail
            // 
            // 
            // 
            // 
            this.tbxEmail.CustomButton.Image = null;
            this.tbxEmail.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.tbxEmail.CustomButton.Name = "";
            this.tbxEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxEmail.CustomButton.TabIndex = 1;
            this.tbxEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxEmail.CustomButton.UseSelectable = true;
            this.tbxEmail.CustomButton.Visible = false;
            this.tbxEmail.Lines = new string[0];
            this.tbxEmail.Location = new System.Drawing.Point(70, 209);
            this.tbxEmail.MaxLength = 32767;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.PasswordChar = '\0';
            this.tbxEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxEmail.SelectedText = "";
            this.tbxEmail.SelectionLength = 0;
            this.tbxEmail.SelectionStart = 0;
            this.tbxEmail.ShortcutsEnabled = true;
            this.tbxEmail.Size = new System.Drawing.Size(75, 23);
            this.tbxEmail.TabIndex = 10;
            this.tbxEmail.UseSelectable = true;
            this.tbxEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbMaterialID
            // 
            this.cmbMaterialID.DataSource = this.materialsBindingSource;
            this.cmbMaterialID.DisplayMember = "MaterialID";
            this.cmbMaterialID.FormattingEnabled = true;
            this.cmbMaterialID.ItemHeight = 23;
            this.cmbMaterialID.Location = new System.Drawing.Point(560, 199);
            this.cmbMaterialID.Name = "cmbMaterialID";
            this.cmbMaterialID.Size = new System.Drawing.Size(121, 29);
            this.cmbMaterialID.TabIndex = 11;
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
            this.btnAdd.Location = new System.Drawing.Point(155, 289);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 30);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Добави";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(473, 289);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 30);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Изчисти";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // Providers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbMaterialID);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxPhone);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.tbxCity);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblMaterialID);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblName);
            this.Name = "Providers";
            this.Text = "Доставчици";
            this.Load += new System.EventHandler(this.Providers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delio_voivodaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblCity;
        private MetroFramework.Controls.MetroLabel lblAddress;
        private MetroFramework.Controls.MetroLabel lblPhone;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroLabel lblMaterialID;
        private MetroFramework.Controls.MetroTextBox tbxName;
        private MetroFramework.Controls.MetroTextBox tbxCity;
        private MetroFramework.Controls.MetroTextBox tbxAddress;
        private MetroFramework.Controls.MetroTextBox tbxPhone;
        private MetroFramework.Controls.MetroTextBox tbxEmail;
        private MetroFramework.Controls.MetroComboBox cmbMaterialID;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnClear;
        private delio_voivodaDataSet delio_voivodaDataSet;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private delio_voivodaDataSetTableAdapters.MaterialsTableAdapter materialsTableAdapter;
    }
}