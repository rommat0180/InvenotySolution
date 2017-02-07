namespace Inventory
{
    partial class InventoryParent
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
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brandsManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductBrandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brandsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.brandsManagementToolStripMenuItem,
            this.storeManagementToolStripMenuItem,
            this.ordersManagementToolStripMenuItem,
            this.testFormToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(1284, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // brandsManagementToolStripMenuItem
            // 
            this.brandsManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendersToolStripMenuItem,
            this.addProductBrandToolStripMenuItem,
            this.brandsListToolStripMenuItem});
            this.brandsManagementToolStripMenuItem.Name = "brandsManagementToolStripMenuItem";
            this.brandsManagementToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.brandsManagementToolStripMenuItem.Text = "Brands Management";
            // 
            // vendersToolStripMenuItem
            // 
            this.vendersToolStripMenuItem.Name = "vendersToolStripMenuItem";
            this.vendersToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.vendersToolStripMenuItem.Text = "Venders";
            this.vendersToolStripMenuItem.Click += new System.EventHandler(this.vendersToolStripMenuItem_Click);
            // 
            // addProductBrandToolStripMenuItem
            // 
            this.addProductBrandToolStripMenuItem.Name = "addProductBrandToolStripMenuItem";
            this.addProductBrandToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.addProductBrandToolStripMenuItem.Text = "Add Product Brand";
            this.addProductBrandToolStripMenuItem.Click += new System.EventHandler(this.addProductBrandToolStripMenuItem_Click_1);
            // 
            // brandsListToolStripMenuItem
            // 
            this.brandsListToolStripMenuItem.Name = "brandsListToolStripMenuItem";
            this.brandsListToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.brandsListToolStripMenuItem.Text = "Brands List";
            this.brandsListToolStripMenuItem.Click += new System.EventHandler(this.brandsListToolStripMenuItem_Click);
            // 
            // storeManagementToolStripMenuItem
            // 
            this.storeManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToStockToolStripMenuItem,
            this.stockListToolStripMenuItem});
            this.storeManagementToolStripMenuItem.Name = "storeManagementToolStripMenuItem";
            this.storeManagementToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.storeManagementToolStripMenuItem.Text = "Stock Management";
            this.storeManagementToolStripMenuItem.Click += new System.EventHandler(this.storeManagementToolStripMenuItem_Click);
            // 
            // addToStockToolStripMenuItem
            // 
            this.addToStockToolStripMenuItem.Name = "addToStockToolStripMenuItem";
            this.addToStockToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.addToStockToolStripMenuItem.Text = "Add To Stock";
            this.addToStockToolStripMenuItem.Click += new System.EventHandler(this.addToStockToolStripMenuItem_Click);
            // 
            // stockListToolStripMenuItem
            // 
            this.stockListToolStripMenuItem.Name = "stockListToolStripMenuItem";
            this.stockListToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.stockListToolStripMenuItem.Text = "Stock List";
            this.stockListToolStripMenuItem.Click += new System.EventHandler(this.stockListToolStripMenuItem_Click);
            // 
            // ordersManagementToolStripMenuItem
            // 
            this.ordersManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOrderToolStripMenuItem,
            this.ordersListToolStripMenuItem});
            this.ordersManagementToolStripMenuItem.Name = "ordersManagementToolStripMenuItem";
            this.ordersManagementToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.ordersManagementToolStripMenuItem.Text = "Orders Management";
            // 
            // addOrderToolStripMenuItem
            // 
            this.addOrderToolStripMenuItem.Name = "addOrderToolStripMenuItem";
            this.addOrderToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.addOrderToolStripMenuItem.Text = "Add Order";
            this.addOrderToolStripMenuItem.Click += new System.EventHandler(this.addOrderToolStripMenuItem_Click);
            // 
            // ordersListToolStripMenuItem
            // 
            this.ordersListToolStripMenuItem.Name = "ordersListToolStripMenuItem";
            this.ordersListToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.ordersListToolStripMenuItem.Text = "Orders List";
            this.ordersListToolStripMenuItem.Click += new System.EventHandler(this.ordersListToolStripMenuItem_Click);
            // 
            // testFormToolStripMenuItem
            // 
            this.testFormToolStripMenuItem.Name = "testFormToolStripMenuItem";
            this.testFormToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saleReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // saleReportToolStripMenuItem
            // 
            this.saleReportToolStripMenuItem.Name = "saleReportToolStripMenuItem";
            this.saleReportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saleReportToolStripMenuItem.Text = "Sale Reports";
            this.saleReportToolStripMenuItem.Click += new System.EventHandler(this.saleReportToolStripMenuItem_Click_1);
            // 
            // InventoryParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1284, 782);
            this.Controls.Add(this.MainMenuStrip);
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(1800, 1200);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "InventoryParent";
            this.Text = "Inventory System";
            this.Load += new System.EventHandler(this.InventoryParent_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem storeManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brandsManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductBrandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brandsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        public System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleReportToolStripMenuItem;
    }
}

