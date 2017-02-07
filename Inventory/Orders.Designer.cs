namespace Inventory
{
    partial class Orders
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
            this.OrdersListHeading = new System.Windows.Forms.Label();
            this.OrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new Inventory.DataSet1();
            this.orderProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderProductsTableAdapter = new Inventory.DataSet1TableAdapters.OrderProductsTableAdapter();
            this.productsBrandsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBrandsTableAdapter = new Inventory.DataSet1TableAdapters.ProductsBrandsTableAdapter();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new Inventory.DataSet1TableAdapters.OrdersTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfItemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBrandsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdersListHeading
            // 
            this.OrdersListHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OrdersListHeading.AutoSize = true;
            this.OrdersListHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdersListHeading.ForeColor = System.Drawing.Color.White;
            this.OrdersListHeading.Location = new System.Drawing.Point(325, 26);
            this.OrdersListHeading.Name = "OrdersListHeading";
            this.OrdersListHeading.Size = new System.Drawing.Size(147, 31);
            this.OrdersListHeading.TabIndex = 0;
            this.OrdersListHeading.Text = "Orders List";
            this.OrdersListHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OrdersDataGridView
            // 
            this.OrdersDataGridView.AutoGenerateColumns = false;
            this.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.noOfItemsDataGridViewTextBoxColumn,
            this.subTotalDataGridViewTextBoxColumn,
            this.orderIdDataGridViewTextBoxColumn,
            this.OrderDate});
            this.OrdersDataGridView.DataSource = this.orderProductsBindingSource;
            this.OrdersDataGridView.Location = new System.Drawing.Point(12, 87);
            this.OrdersDataGridView.Name = "OrdersDataGridView";
            this.OrdersDataGridView.Size = new System.Drawing.Size(822, 253);
            this.OrdersDataGridView.TabIndex = 1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderProductsBindingSource
            // 
            this.orderProductsBindingSource.DataMember = "OrderProducts";
            this.orderProductsBindingSource.DataSource = this.dataSet1;
            // 
            // orderProductsTableAdapter
            // 
            this.orderProductsTableAdapter.ClearBeforeFill = true;
            // 
            // productsBrandsBindingSource
            // 
            this.productsBrandsBindingSource.DataMember = "ProductsBrands";
            this.productsBrandsBindingSource.DataSource = this.dataSet1;
            // 
            // productsBrandsTableAdapter
            // 
            this.productsBrandsTableAdapter.ClearBeforeFill = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.dataSet1;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.DataSource = this.productsBrandsBindingSource;
            this.productIdDataGridViewTextBoxColumn.DisplayMember = "ProductTitle";
            this.productIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.productIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // noOfItemsDataGridViewTextBoxColumn
            // 
            this.noOfItemsDataGridViewTextBoxColumn.DataPropertyName = "NoOfItems";
            this.noOfItemsDataGridViewTextBoxColumn.HeaderText = "NoOfItems";
            this.noOfItemsDataGridViewTextBoxColumn.Name = "noOfItemsDataGridViewTextBoxColumn";
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            this.subTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal";
            this.subTotalDataGridViewTextBoxColumn.HeaderText = "SubTotal";
            this.subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.DataSource = this.ordersBindingSource;
            this.orderIdDataGridViewTextBoxColumn.DisplayMember = "Total";
            this.orderIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "Total";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.orderIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.orderIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderId";
            this.OrderDate.DataSource = this.ordersBindingSource;
            this.OrderDate.DisplayMember = "OrderDate";
            this.OrderDate.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.OrderDate.HeaderText = "Date";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.OrderDate.ValueMember = "Id";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(884, 519);
            this.Controls.Add(this.OrdersDataGridView);
            this.Controls.Add(this.OrdersListHeading);
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBrandsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrdersListHeading;
        private System.Windows.Forms.DataGridView OrdersDataGridView;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource orderProductsBindingSource;
        private DataSet1TableAdapters.OrderProductsTableAdapter orderProductsTableAdapter;
        private System.Windows.Forms.BindingSource productsBrandsBindingSource;
        private DataSet1TableAdapters.ProductsBrandsTableAdapter productsBrandsTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private DataSet1TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfItemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn OrderDate;
    }
}