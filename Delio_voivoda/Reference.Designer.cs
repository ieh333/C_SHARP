
namespace Delio_voivoda
{
    partial class Reference
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rbtnReference_quantity = new MetroFramework.Controls.MetroRadioButton();
            this.rbtnReference_price = new MetroFramework.Controls.MetroRadioButton();
            this.btnGenerate = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.dgridReference = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dgridReference)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnReference_quantity
            // 
            this.rbtnReference_quantity.AutoSize = true;
            this.rbtnReference_quantity.Location = new System.Drawing.Point(23, 109);
            this.rbtnReference_quantity.Name = "rbtnReference_quantity";
            this.rbtnReference_quantity.Size = new System.Drawing.Size(323, 15);
            this.rbtnReference_quantity.TabIndex = 0;
            this.rbtnReference_quantity.Text = "Справка на произведената продукция (по количество)";
            this.rbtnReference_quantity.UseSelectable = true;
            // 
            // rbtnReference_price
            // 
            this.rbtnReference_price.AutoSize = true;
            this.rbtnReference_price.Location = new System.Drawing.Point(452, 109);
            this.rbtnReference_price.Name = "rbtnReference_price";
            this.rbtnReference_price.Size = new System.Drawing.Size(285, 15);
            this.rbtnReference_price.TabIndex = 1;
            this.rbtnReference_price.Text = "Справка на произведената продукция (по цена)";
            this.rbtnReference_price.UseSelectable = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(23, 189);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(160, 30);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Генерирай справка";
            this.btnGenerate.UseSelectable = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(452, 189);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(169, 30);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Изчисти";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgridReference
            // 
            this.dgridReference.AllowUserToAddRows = false;
            this.dgridReference.AllowUserToDeleteRows = false;
            this.dgridReference.AllowUserToResizeRows = false;
            this.dgridReference.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgridReference.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgridReference.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgridReference.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridReference.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgridReference.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgridReference.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgridReference.EnableHeadersVisualStyles = false;
            this.dgridReference.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgridReference.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgridReference.Location = new System.Drawing.Point(187, 277);
            this.dgridReference.Name = "dgridReference";
            this.dgridReference.ReadOnly = true;
            this.dgridReference.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridReference.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgridReference.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgridReference.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgridReference.Size = new System.Drawing.Size(346, 150);
            this.dgridReference.TabIndex = 4;
            // 
            // Reference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgridReference);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.rbtnReference_price);
            this.Controls.Add(this.rbtnReference_quantity);
            this.Name = "Reference";
            this.Text = "Справка";
            ((System.ComponentModel.ISupportInitialize)(this.dgridReference)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton rbtnReference_quantity;
        private MetroFramework.Controls.MetroRadioButton rbtnReference_price;
        private MetroFramework.Controls.MetroButton btnGenerate;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroGrid dgridReference;
    }
}