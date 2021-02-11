
namespace Delio_voivoda
{
    partial class Nomenclatures
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
            this.lblType = new MetroFramework.Controls.MetroLabel();
            this.lblNumber = new MetroFramework.Controls.MetroLabel();
            this.lblProductID = new MetroFramework.Controls.MetroLabel();
            this.tbxType = new MetroFramework.Controls.MetroTextBox();
            this.tbxNumber = new MetroFramework.Controls.MetroTextBox();
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
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(23, 87);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(110, 19);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Тип на продукта";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(461, 87);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(128, 19);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Номер на продукта";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(23, 155);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(109, 19);
            this.lblProductID.TabIndex = 2;
            this.lblProductID.Text = "Код на продукта";
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
            this.tbxType.Location = new System.Drawing.Point(139, 83);
            this.tbxType.MaxLength = 32767;
            this.tbxType.Name = "tbxType";
            this.tbxType.PasswordChar = '\0';
            this.tbxType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxType.SelectedText = "";
            this.tbxType.SelectionLength = 0;
            this.tbxType.SelectionStart = 0;
            this.tbxType.ShortcutsEnabled = true;
            this.tbxType.Size = new System.Drawing.Size(75, 23);
            this.tbxType.TabIndex = 3;
            this.tbxType.UseSelectable = true;
            this.tbxType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxNumber
            // 
            // 
            // 
            // 
            this.tbxNumber.CustomButton.Image = null;
            this.tbxNumber.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.tbxNumber.CustomButton.Name = "";
            this.tbxNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxNumber.CustomButton.TabIndex = 1;
            this.tbxNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxNumber.CustomButton.UseSelectable = true;
            this.tbxNumber.CustomButton.Visible = false;
            this.tbxNumber.Lines = new string[0];
            this.tbxNumber.Location = new System.Drawing.Point(595, 83);
            this.tbxNumber.MaxLength = 32767;
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.PasswordChar = '\0';
            this.tbxNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxNumber.SelectedText = "";
            this.tbxNumber.SelectionLength = 0;
            this.tbxNumber.SelectionStart = 0;
            this.tbxNumber.ShortcutsEnabled = true;
            this.tbxNumber.Size = new System.Drawing.Size(75, 23);
            this.tbxNumber.TabIndex = 4;
            this.tbxNumber.UseSelectable = true;
            this.tbxNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbProductID
            // 
            this.cmbProductID.DataSource = this.productsBindingSource;
            this.cmbProductID.DisplayMember = "ProductID";
            this.cmbProductID.FormattingEnabled = true;
            this.cmbProductID.ItemHeight = 23;
            this.cmbProductID.Location = new System.Drawing.Point(138, 145);
            this.cmbProductID.Name = "cmbProductID";
            this.cmbProductID.Size = new System.Drawing.Size(121, 29);
            this.cmbProductID.TabIndex = 5;
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
            this.btnAdd.Location = new System.Drawing.Point(139, 234);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добави";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(595, 234);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 30);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Изчисти";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // Nomenclatures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbProductID);
            this.Controls.Add(this.tbxNumber);
            this.Controls.Add(this.tbxType);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblType);
            this.Name = "Nomenclatures";
            this.Text = "Номенклатури";
            this.Load += new System.EventHandler(this.Nomenclatures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delio_voivodaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblType;
        private MetroFramework.Controls.MetroLabel lblNumber;
        private MetroFramework.Controls.MetroLabel lblProductID;
        private MetroFramework.Controls.MetroTextBox tbxType;
        private MetroFramework.Controls.MetroTextBox tbxNumber;
        private MetroFramework.Controls.MetroComboBox cmbProductID;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnClear;
        private delio_voivodaDataSet delio_voivodaDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private delio_voivodaDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
    }
}