namespace Inventory
{
    partial class AddToStock
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
            this.SaveBrand = new System.Windows.Forms.Button();
            this.ProductTitleLbl = new System.Windows.Forms.Label();
            this.CostTxt = new System.Windows.Forms.TextBox();
            this.CostLbl = new System.Windows.Forms.Label();
            this.NoOfItemsTxt = new System.Windows.Forms.TextBox();
            this.NoOfItemsLbl = new System.Windows.Forms.Label();
            this.BarcodeTxt = new System.Windows.Forms.TextBox();
            this.BarcodeLbl = new System.Windows.Forms.Label();
            this.ProductIdComboBox = new System.Windows.Forms.ComboBox();
            this.productsBrandsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Inventory.DataSet1();
            this.productsBrandsTableAdapter = new Inventory.DataSet1TableAdapters.ProductsBrandsTableAdapter();
            this.AddToStockLbl = new System.Windows.Forms.Label();
            this.ErrNoOfItems = new System.Windows.Forms.Label();
            this.ErrCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsBrandsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveBrand
            // 
            this.SaveBrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveBrand.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SaveBrand.Location = new System.Drawing.Point(279, 292);
            this.SaveBrand.Name = "SaveBrand";
            this.SaveBrand.Size = new System.Drawing.Size(75, 23);
            this.SaveBrand.TabIndex = 17;
            this.SaveBrand.Text = "Save";
            this.SaveBrand.UseVisualStyleBackColor = true;
            this.SaveBrand.Click += new System.EventHandler(this.SaveBrand_Click);
            // 
            // ProductTitleLbl
            // 
            this.ProductTitleLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductTitleLbl.AutoSize = true;
            this.ProductTitleLbl.Location = new System.Drawing.Point(195, 162);
            this.ProductTitleLbl.Name = "ProductTitleLbl";
            this.ProductTitleLbl.Size = new System.Drawing.Size(67, 13);
            this.ProductTitleLbl.TabIndex = 15;
            this.ProductTitleLbl.Text = "Product Title";
            // 
            // CostTxt
            // 
            this.CostTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CostTxt.Location = new System.Drawing.Point(500, 222);
            this.CostTxt.Name = "CostTxt";
            this.CostTxt.Size = new System.Drawing.Size(127, 20);
            this.CostTxt.TabIndex = 14;
            // 
            // CostLbl
            // 
            this.CostLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CostLbl.AutoSize = true;
            this.CostLbl.Location = new System.Drawing.Point(437, 229);
            this.CostLbl.Name = "CostLbl";
            this.CostLbl.Size = new System.Drawing.Size(28, 13);
            this.CostLbl.TabIndex = 13;
            this.CostLbl.Text = "Cost";
            // 
            // NoOfItemsTxt
            // 
            this.NoOfItemsTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NoOfItemsTxt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NoOfItemsTxt.Location = new System.Drawing.Point(279, 226);
            this.NoOfItemsTxt.Name = "NoOfItemsTxt";
            this.NoOfItemsTxt.Size = new System.Drawing.Size(127, 20);
            this.NoOfItemsTxt.TabIndex = 12;
            // 
            // NoOfItemsLbl
            // 
            this.NoOfItemsLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NoOfItemsLbl.AutoSize = true;
            this.NoOfItemsLbl.Location = new System.Drawing.Point(195, 233);
            this.NoOfItemsLbl.Name = "NoOfItemsLbl";
            this.NoOfItemsLbl.Size = new System.Drawing.Size(57, 13);
            this.NoOfItemsLbl.TabIndex = 11;
            this.NoOfItemsLbl.Text = "NoOfItems";
            // 
            // BarcodeTxt
            // 
            this.BarcodeTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BarcodeTxt.Location = new System.Drawing.Point(279, 84);
            this.BarcodeTxt.Name = "BarcodeTxt";
            this.BarcodeTxt.Size = new System.Drawing.Size(348, 20);
            this.BarcodeTxt.TabIndex = 10;
            this.BarcodeTxt.Leave += new System.EventHandler(this.Barcode_LoadProduct);
            // 
            // BarcodeLbl
            // 
            this.BarcodeLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BarcodeLbl.AutoSize = true;
            this.BarcodeLbl.Location = new System.Drawing.Point(195, 91);
            this.BarcodeLbl.Name = "BarcodeLbl";
            this.BarcodeLbl.Size = new System.Drawing.Size(47, 13);
            this.BarcodeLbl.TabIndex = 9;
            this.BarcodeLbl.Text = "Barcode";
            // 
            // ProductIdComboBox
            // 
            this.ProductIdComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductIdComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProductIdComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ProductIdComboBox.DataSource = this.productsBrandsBindingSource;
            this.ProductIdComboBox.DisplayMember = "ProductTitle";
            this.ProductIdComboBox.FormattingEnabled = true;
            this.ProductIdComboBox.Location = new System.Drawing.Point(279, 154);
            this.ProductIdComboBox.Name = "ProductIdComboBox";
            this.ProductIdComboBox.Size = new System.Drawing.Size(348, 21);
            this.ProductIdComboBox.TabIndex = 21;
            this.ProductIdComboBox.ValueMember = "Id";
            // 
            // productsBrandsBindingSource
            // 
            this.productsBrandsBindingSource.DataMember = "ProductsBrands";
            this.productsBrandsBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBrandsTableAdapter
            // 
            this.productsBrandsTableAdapter.ClearBeforeFill = true;
            // 
            // AddToStockLbl
            // 
            this.AddToStockLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddToStockLbl.AutoSize = true;
            this.AddToStockLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToStockLbl.Location = new System.Drawing.Point(349, 19);
            this.AddToStockLbl.Name = "AddToStockLbl";
            this.AddToStockLbl.Size = new System.Drawing.Size(177, 31);
            this.AddToStockLbl.TabIndex = 22;
            this.AddToStockLbl.Text = "Add To Stock";
            // 
            // ErrNoOfItems
            // 
            this.ErrNoOfItems.AutoSize = true;
            this.ErrNoOfItems.ForeColor = System.Drawing.Color.Red;
            this.ErrNoOfItems.Location = new System.Drawing.Point(276, 249);
            this.ErrNoOfItems.Name = "ErrNoOfItems";
            this.ErrNoOfItems.Size = new System.Drawing.Size(35, 13);
            this.ErrNoOfItems.TabIndex = 23;
            this.ErrNoOfItems.Text = "label1";
            this.ErrNoOfItems.Visible = false;
            // 
            // ErrCost
            // 
            this.ErrCost.AutoSize = true;
            this.ErrCost.ForeColor = System.Drawing.Color.Red;
            this.ErrCost.Location = new System.Drawing.Point(497, 249);
            this.ErrCost.Name = "ErrCost";
            this.ErrCost.Size = new System.Drawing.Size(35, 13);
            this.ErrCost.TabIndex = 24;
            this.ErrCost.Text = "label2";
            this.ErrCost.Visible = false;
            // 
            // AddToStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(860, 518);
            this.Controls.Add(this.ErrCost);
            this.Controls.Add(this.ErrNoOfItems);
            this.Controls.Add(this.AddToStockLbl);
            this.Controls.Add(this.ProductIdComboBox);
            this.Controls.Add(this.SaveBrand);
            this.Controls.Add(this.ProductTitleLbl);
            this.Controls.Add(this.CostTxt);
            this.Controls.Add(this.CostLbl);
            this.Controls.Add(this.NoOfItemsTxt);
            this.Controls.Add(this.NoOfItemsLbl);
            this.Controls.Add(this.BarcodeTxt);
            this.Controls.Add(this.BarcodeLbl);
            this.Name = "AddToStock";
            this.Text = "Add To Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddToStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBrandsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveBrand;
        private System.Windows.Forms.Label ProductTitleLbl;
        private System.Windows.Forms.TextBox CostTxt;
        private System.Windows.Forms.Label CostLbl;
        private System.Windows.Forms.TextBox NoOfItemsTxt;
        private System.Windows.Forms.Label NoOfItemsLbl;
        private System.Windows.Forms.TextBox BarcodeTxt;
        private System.Windows.Forms.Label BarcodeLbl;
        private System.Windows.Forms.ComboBox ProductIdComboBox;
        private DataSet1 DataSet1;
        private System.Windows.Forms.BindingSource productsBrandsBindingSource;
        private DataSet1TableAdapters.ProductsBrandsTableAdapter productsBrandsTableAdapter;
        private System.Windows.Forms.Label AddToStockLbl;
        private System.Windows.Forms.Label ErrNoOfItems;
        private System.Windows.Forms.Label ErrCost;
    }
}