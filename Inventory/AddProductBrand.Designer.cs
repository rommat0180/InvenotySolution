namespace Inventory
{
    partial class AddProductBrand
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
            this.BarcodeLbl = new System.Windows.Forms.Label();
            this.BarcodeTxt = new System.Windows.Forms.TextBox();
            this.VenderLbl = new System.Windows.Forms.Label();
            this.PricePerItemTxt = new System.Windows.Forms.TextBox();
            this.PricePerItemLbl = new System.Windows.Forms.Label();
            this.ProductTitleTxt = new System.Windows.Forms.TextBox();
            this.ProductTitleLbl = new System.Windows.Forms.Label();
            this.SaveBrand = new System.Windows.Forms.Button();
            this.FormHeaadingLbl = new System.Windows.Forms.Label();
            this.VenderComboBox = new System.Windows.Forms.ComboBox();
            this.ErrBarcode = new System.Windows.Forms.Label();
            this.ErrProductTitle = new System.Windows.Forms.Label();
            this.ErrVender = new System.Windows.Forms.Label();
            this.ErrPricePerItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BarcodeLbl
            // 
            this.BarcodeLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BarcodeLbl.AutoSize = true;
            this.BarcodeLbl.Location = new System.Drawing.Point(260, 176);
            this.BarcodeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BarcodeLbl.Name = "BarcodeLbl";
            this.BarcodeLbl.Size = new System.Drawing.Size(61, 17);
            this.BarcodeLbl.TabIndex = 0;
            this.BarcodeLbl.Text = "Barcode";
            // 
            // BarcodeTxt
            // 
            this.BarcodeTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BarcodeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeTxt.Location = new System.Drawing.Point(372, 167);
            this.BarcodeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.BarcodeTxt.Name = "BarcodeTxt";
            this.BarcodeTxt.Size = new System.Drawing.Size(463, 23);
            this.BarcodeTxt.TabIndex = 1;
            // 
            // VenderLbl
            // 
            this.VenderLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VenderLbl.AutoSize = true;
            this.VenderLbl.Location = new System.Drawing.Point(260, 323);
            this.VenderLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VenderLbl.Name = "VenderLbl";
            this.VenderLbl.Size = new System.Drawing.Size(54, 17);
            this.VenderLbl.TabIndex = 2;
            this.VenderLbl.Text = "Vender";
            // 
            // PricePerItemTxt
            // 
            this.PricePerItemTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PricePerItemTxt.Location = new System.Drawing.Point(372, 387);
            this.PricePerItemTxt.Margin = new System.Windows.Forms.Padding(4);
            this.PricePerItemTxt.Name = "PricePerItemTxt";
            this.PricePerItemTxt.Size = new System.Drawing.Size(463, 23);
            this.PricePerItemTxt.TabIndex = 5;
            // 
            // PricePerItemLbl
            // 
            this.PricePerItemLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PricePerItemLbl.AutoSize = true;
            this.PricePerItemLbl.Location = new System.Drawing.Point(260, 396);
            this.PricePerItemLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PricePerItemLbl.Name = "PricePerItemLbl";
            this.PricePerItemLbl.Size = new System.Drawing.Size(73, 17);
            this.PricePerItemLbl.TabIndex = 4;
            this.PricePerItemLbl.Text = "Unit Price ";
            // 
            // ProductTitleTxt
            // 
            this.ProductTitleTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductTitleTxt.Location = new System.Drawing.Point(372, 240);
            this.ProductTitleTxt.Margin = new System.Windows.Forms.Padding(4);
            this.ProductTitleTxt.Name = "ProductTitleTxt";
            this.ProductTitleTxt.Size = new System.Drawing.Size(463, 23);
            this.ProductTitleTxt.TabIndex = 7;
            // 
            // ProductTitleLbl
            // 
            this.ProductTitleLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductTitleLbl.AutoSize = true;
            this.ProductTitleLbl.Location = new System.Drawing.Point(260, 249);
            this.ProductTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductTitleLbl.Name = "ProductTitleLbl";
            this.ProductTitleLbl.Size = new System.Drawing.Size(88, 17);
            this.ProductTitleLbl.TabIndex = 6;
            this.ProductTitleLbl.Text = "Product Title";
            // 
            // SaveBrand
            // 
            this.SaveBrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveBrand.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SaveBrand.Location = new System.Drawing.Point(372, 451);
            this.SaveBrand.Margin = new System.Windows.Forms.Padding(4);
            this.SaveBrand.Name = "SaveBrand";
            this.SaveBrand.Size = new System.Drawing.Size(100, 28);
            this.SaveBrand.TabIndex = 8;
            this.SaveBrand.Text = "Save";
            this.SaveBrand.UseVisualStyleBackColor = true;
            this.SaveBrand.Click += new System.EventHandler(this.SaveBrand_Click);
            // 
            // FormHeaadingLbl
            // 
            this.FormHeaadingLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FormHeaadingLbl.AutoSize = true;
            this.FormHeaadingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormHeaadingLbl.Location = new System.Drawing.Point(367, 79);
            this.FormHeaadingLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FormHeaadingLbl.Name = "FormHeaadingLbl";
            this.FormHeaadingLbl.Size = new System.Drawing.Size(215, 29);
            this.FormHeaadingLbl.TabIndex = 9;
            this.FormHeaadingLbl.Text = "Add Product Brand";
            // 
            // VenderComboBox
            // 
            this.VenderComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VenderComboBox.FormattingEnabled = true;
            this.VenderComboBox.Location = new System.Drawing.Point(372, 316);
            this.VenderComboBox.Name = "VenderComboBox";
            this.VenderComboBox.Size = new System.Drawing.Size(463, 24);
            this.VenderComboBox.TabIndex = 10;
            // 
            // ErrBarcode
            // 
            this.ErrBarcode.AutoSize = true;
            this.ErrBarcode.ForeColor = System.Drawing.Color.Red;
            this.ErrBarcode.Location = new System.Drawing.Point(369, 195);
            this.ErrBarcode.Name = "ErrBarcode";
            this.ErrBarcode.Size = new System.Drawing.Size(46, 17);
            this.ErrBarcode.TabIndex = 11;
            this.ErrBarcode.Text = "label1";
            this.ErrBarcode.Visible = false;
            // 
            // ErrProductTitle
            // 
            this.ErrProductTitle.AutoSize = true;
            this.ErrProductTitle.ForeColor = System.Drawing.Color.Red;
            this.ErrProductTitle.Location = new System.Drawing.Point(369, 268);
            this.ErrProductTitle.Name = "ErrProductTitle";
            this.ErrProductTitle.Size = new System.Drawing.Size(46, 17);
            this.ErrProductTitle.TabIndex = 12;
            this.ErrProductTitle.Text = "label2";
            this.ErrProductTitle.Visible = false;
            // 
            // ErrVender
            // 
            this.ErrVender.AutoSize = true;
            this.ErrVender.ForeColor = System.Drawing.Color.Red;
            this.ErrVender.Location = new System.Drawing.Point(369, 344);
            this.ErrVender.Name = "ErrVender";
            this.ErrVender.Size = new System.Drawing.Size(46, 17);
            this.ErrVender.TabIndex = 13;
            this.ErrVender.Text = "label3";
            this.ErrVender.Visible = false;
            // 
            // ErrPricePerItem
            // 
            this.ErrPricePerItem.AutoSize = true;
            this.ErrPricePerItem.ForeColor = System.Drawing.Color.Red;
            this.ErrPricePerItem.Location = new System.Drawing.Point(369, 415);
            this.ErrPricePerItem.Name = "ErrPricePerItem";
            this.ErrPricePerItem.Size = new System.Drawing.Size(46, 17);
            this.ErrPricePerItem.TabIndex = 14;
            this.ErrPricePerItem.Text = "label4";
            this.ErrPricePerItem.Visible = false;
            this.ErrPricePerItem.Click += new System.EventHandler(this.label4_Click);
            // 
            // AddProductBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1136, 625);
            this.Controls.Add(this.ErrPricePerItem);
            this.Controls.Add(this.ErrVender);
            this.Controls.Add(this.ErrProductTitle);
            this.Controls.Add(this.ErrBarcode);
            this.Controls.Add(this.VenderComboBox);
            this.Controls.Add(this.FormHeaadingLbl);
            this.Controls.Add(this.SaveBrand);
            this.Controls.Add(this.ProductTitleTxt);
            this.Controls.Add(this.ProductTitleLbl);
            this.Controls.Add(this.PricePerItemTxt);
            this.Controls.Add(this.PricePerItemLbl);
            this.Controls.Add(this.VenderLbl);
            this.Controls.Add(this.BarcodeTxt);
            this.Controls.Add(this.BarcodeLbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddProductBrand";
            this.Text = "Add Product Brand";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddProductBrand_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BarcodeLbl;
        private System.Windows.Forms.TextBox BarcodeTxt;
        private System.Windows.Forms.Label VenderLbl;
        private System.Windows.Forms.TextBox PricePerItemTxt;
        private System.Windows.Forms.Label PricePerItemLbl;
        private System.Windows.Forms.TextBox ProductTitleTxt;
        private System.Windows.Forms.Label ProductTitleLbl;
        private System.Windows.Forms.Button SaveBrand;
        private System.Windows.Forms.Label FormHeaadingLbl;
        private System.Windows.Forms.ComboBox VenderComboBox;
        private System.Windows.Forms.Label ErrBarcode;
        private System.Windows.Forms.Label ErrProductTitle;
        private System.Windows.Forms.Label ErrPricePerItem;
        private System.Windows.Forms.Label ErrVender;
    }
}