
namespace Delio_voivoda
{
    partial class Objects
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
            this.lblType = new MetroFramework.Controls.MetroLabel();
            this.lblProductID = new MetroFramework.Controls.MetroLabel();
            this.tbxName = new MetroFramework.Controls.MetroTextBox();
            this.tbxCity = new MetroFramework.Controls.MetroTextBox();
            this.tbxAddress = new MetroFramework.Controls.MetroTextBox();
            this.tbxType = new MetroFramework.Controls.MetroTextBox();
            this.cmbProductID = new MetroFramework.Controls.MetroComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.delio_voivodaDataSet = new Delio_voivoda.delio_voivodaDataSet();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.productsTableAdapter = new Delio_voivoda.delio_voivodaDataSetTableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delio_voivodaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 96);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(99, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Име на обекта";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(470, 96);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(37, 19);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "Град";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(23, 149);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(46, 19);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Адрес";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(470, 149);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(96, 19);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Тип на обекта";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(23, 201);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(109, 19);
            this.lblProductID.TabIndex = 4;
            this.lblProductID.Text = "Код на продукта";
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
            this.tbxName.Location = new System.Drawing.Point(128, 92);
            this.tbxName.MaxLength = 32767;
            this.tbxName.Name = "tbxName";
            this.tbxName.PasswordChar = '\0';
            this.tbxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxName.SelectedText = "";
            this.tbxName.SelectionLength = 0;
            this.tbxName.SelectionStart = 0;
            this.tbxName.ShortcutsEnabled = true;
            this.tbxName.Size = new System.Drawing.Size(75, 23);
            this.tbxName.TabIndex = 5;
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
            this.tbxCity.Location = new System.Drawing.Point(513, 92);
            this.tbxCity.MaxLength = 32767;
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.PasswordChar = '\0';
            this.tbxCity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxCity.SelectedText = "";
            this.tbxCity.SelectionLength = 0;
            this.tbxCity.SelectionStart = 0;
            this.tbxCity.ShortcutsEnabled = true;
            this.tbxCity.Size = new System.Drawing.Size(75, 23);
            this.tbxCity.TabIndex = 6;
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
            this.tbxAddress.Location = new System.Drawing.Point(75, 145);
            this.tbxAddress.MaxLength = 32767;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.PasswordChar = '\0';
            this.tbxAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxAddress.SelectedText = "";
            this.tbxAddress.SelectionLength = 0;
            this.tbxAddress.SelectionStart = 0;
            this.tbxAddress.ShortcutsEnabled = true;
            this.tbxAddress.Size = new System.Drawing.Size(75, 23);
            this.tbxAddress.TabIndex = 7;
            this.tbxAddress.UseSelectable = true;
            this.tbxAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxType
            // 
            // 
            // 
            // 
            this.tbxType.CustomButton.Image = null;
            this.tbxType.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.tbxType.CustomButton.Name = "";
            this.tbxType.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxType.CustomButton.TabIndex = 1;
            this.tbxType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxType.CustomButton.UseSelectable = true;
            this.tbxType.CustomButton.Visible = false;
            this.tbxType.Lines = new string[0];
            this.tbxType.Location = new System.Drawing.Point(572, 145);
            this.tbxType.MaxLength = 32767;
            this.tbxType.Name = "tbxType";
            this.tbxType.PasswordChar = '\0';
            this.tbxType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxType.SelectedText = "";
            this.tbxType.SelectionLength = 0;
            this.tbxType.SelectionStart = 0;
            this.tbxType.ShortcutsEnabled = true;
            this.tbxType.Size = new System.Drawing.Size(75, 23);
            this.tbxType.TabIndex = 8;
            this.tbxType.UseSelectable = true;
            this.tbxType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbProductID
            // 
            this.cmbProductID.DataSource = this.productsBindingSource;
            this.cmbProductID.DisplayMember = "ProductID";
            this.cmbProductID.FormattingEnabled = true;
            this.cmbProductID.ItemHeight = 23;
            this.cmbProductID.Location = new System.Drawing.Point(138, 191);
            this.cmbProductID.Name = "cmbProductID";
            this.cmbProductID.Size = new System.Drawing.Size(121, 29);
            this.cmbProductID.TabIndex = 9;
            this.cmbProductID.UseSelectable = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.delio_voivodaDataSet;
            // 
            // delio_voivodaDataSet
            // 
            this.delio_voivodaDataSet.DataSetName = "delio_voivodaDataSet";
            this.delio_voivodaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(128, 268);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 30);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Добави";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(513, 268);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 30);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Изчисти";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // Objects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbProductID);
            this.Controls.Add(this.tbxType);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.tbxCity);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblName);
            this.Name = "Objects";
            this.Text = "Обекти";
            this.Load += new System.EventHandler(this.Objects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delio_voivodaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblCity;
        private MetroFramework.Controls.MetroLabel lblAddress;
        private MetroFramework.Controls.MetroLabel lblType;
        private MetroFramework.Controls.MetroLabel lblProductID;
        private MetroFramework.Controls.MetroTextBox tbxName;
        private MetroFramework.Controls.MetroTextBox tbxCity;
        private MetroFramework.Controls.MetroTextBox tbxAddress;
        private MetroFramework.Controls.MetroTextBox tbxType;
        private MetroFramework.Controls.MetroComboBox cmbProductID;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnClear;
        private delio_voivodaDataSet delio_voivodaDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private delio_voivodaDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
    }
}