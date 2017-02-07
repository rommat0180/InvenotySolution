namespace Inventory
{
    partial class AddNewOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewOrder));
            this.AddNewOrderHeading = new System.Windows.Forms.Label();
            this.ProductTitlePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PricePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.NoOfItemsPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SubtotalPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.AaddMoreBtn = new System.Windows.Forms.Button();
            this.TotalPriceLbl = new System.Windows.Forms.Label();
            this.TotalTxt = new System.Windows.Forms.TextBox();
            this.SaveOrderBtn = new System.Windows.Forms.Button();
            this.InvoicePrintDocument = new System.Drawing.Printing.PrintDocument();
            this.InvoicePrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.PrintPreviewBtn = new System.Windows.Forms.Button();
            this.ProductTitlePanel.SuspendLayout();
            this.PricePanel.SuspendLayout();
            this.NoOfItemsPanel.SuspendLayout();
            this.SubtotalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddNewOrderHeading
            // 
            this.AddNewOrderHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddNewOrderHeading.AutoSize = true;
            this.AddNewOrderHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewOrderHeading.Location = new System.Drawing.Point(336, 37);
            this.AddNewOrderHeading.Name = "AddNewOrderHeading";
            this.AddNewOrderHeading.Size = new System.Drawing.Size(200, 31);
            this.AddNewOrderHeading.TabIndex = 0;
            this.AddNewOrderHeading.Text = "Add New Order";
            // 
            // ProductTitlePanel
            // 
            this.ProductTitlePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductTitlePanel.AutoScroll = true;
            this.ProductTitlePanel.Controls.Add(this.label1);
            this.ProductTitlePanel.Location = new System.Drawing.Point(12, 117);
            this.ProductTitlePanel.Name = "ProductTitlePanel";
            this.ProductTitlePanel.Size = new System.Drawing.Size(330, 381);
            this.ProductTitlePanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products";
            // 
            // PricePanel
            // 
            this.PricePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PricePanel.AutoScroll = true;
            this.PricePanel.Controls.Add(this.label2);
            this.PricePanel.Location = new System.Drawing.Point(367, 117);
            this.PricePanel.Name = "PricePanel";
            this.PricePanel.Size = new System.Drawing.Size(150, 381);
            this.PricePanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price Per Item";
            // 
            // NoOfItemsPanel
            // 
            this.NoOfItemsPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NoOfItemsPanel.AutoScroll = true;
            this.NoOfItemsPanel.Controls.Add(this.label3);
            this.NoOfItemsPanel.Location = new System.Drawing.Point(541, 117);
            this.NoOfItemsPanel.Name = "NoOfItemsPanel";
            this.NoOfItemsPanel.Size = new System.Drawing.Size(150, 381);
            this.NoOfItemsPanel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "No of Items";
            // 
            // SubtotalPanel
            // 
            this.SubtotalPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubtotalPanel.AutoScroll = true;
            this.SubtotalPanel.Controls.Add(this.label4);
            this.SubtotalPanel.Location = new System.Drawing.Point(714, 117);
            this.SubtotalPanel.Name = "SubtotalPanel";
            this.SubtotalPanel.Size = new System.Drawing.Size(150, 381);
            this.SubtotalPanel.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Subtotal";
            // 
            // AaddMoreBtn
            // 
            this.AaddMoreBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AaddMoreBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AaddMoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AaddMoreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AaddMoreBtn.Location = new System.Drawing.Point(749, 40);
            this.AaddMoreBtn.Name = "AaddMoreBtn";
            this.AaddMoreBtn.Size = new System.Drawing.Size(110, 27);
            this.AaddMoreBtn.TabIndex = 2;
            this.AaddMoreBtn.Text = "Add More Row";
            this.AaddMoreBtn.UseVisualStyleBackColor = true;
            this.AaddMoreBtn.Click += new System.EventHandler(this.AaddMoreBtn_Click);
            // 
            // TotalPriceLbl
            // 
            this.TotalPriceLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalPriceLbl.AutoSize = true;
            this.TotalPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceLbl.Location = new System.Drawing.Point(12, 538);
            this.TotalPriceLbl.Name = "TotalPriceLbl";
            this.TotalPriceLbl.Size = new System.Drawing.Size(115, 26);
            this.TotalPriceLbl.TabIndex = 3;
            this.TotalPriceLbl.Text = "Total Price";
            // 
            // TotalTxt
            // 
            this.TotalTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTxt.Location = new System.Drawing.Point(202, 542);
            this.TotalTxt.Name = "TotalTxt";
            this.TotalTxt.ReadOnly = true;
            this.TotalTxt.Size = new System.Drawing.Size(140, 26);
            this.TotalTxt.TabIndex = 4;
            this.TotalTxt.Text = "0.00";
            this.TotalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SaveOrderBtn
            // 
            this.SaveOrderBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveOrderBtn.Location = new System.Drawing.Point(749, 538);
            this.SaveOrderBtn.Name = "SaveOrderBtn";
            this.SaveOrderBtn.Size = new System.Drawing.Size(115, 30);
            this.SaveOrderBtn.TabIndex = 5;
            this.SaveOrderBtn.Text = "Save";
            this.SaveOrderBtn.UseVisualStyleBackColor = true;
            this.SaveOrderBtn.Click += new System.EventHandler(this.SaveOrderBtn_Click);
            // 
            // InvoicePrintDocument
            // 
            this.InvoicePrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // InvoicePrintPreviewDialog
            // 
            this.InvoicePrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.InvoicePrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.InvoicePrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.InvoicePrintPreviewDialog.Enabled = true;
            this.InvoicePrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("InvoicePrintPreviewDialog.Icon")));
            this.InvoicePrintPreviewDialog.Name = "InvoicePrintPreviewDialog";
            this.InvoicePrintPreviewDialog.Visible = false;
            // 
            // PrintPreviewBtn
            // 
            this.PrintPreviewBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrintPreviewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintPreviewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintPreviewBtn.Location = new System.Drawing.Point(607, 538);
            this.PrintPreviewBtn.Name = "PrintPreviewBtn";
            this.PrintPreviewBtn.Size = new System.Drawing.Size(115, 30);
            this.PrintPreviewBtn.TabIndex = 6;
            this.PrintPreviewBtn.Text = "Print Preview";
            this.PrintPreviewBtn.UseVisualStyleBackColor = true;
            this.PrintPreviewBtn.Click += new System.EventHandler(this.PrintPreviewBtn_Click);
            // 
            // AddNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(902, 626);
            this.Controls.Add(this.PrintPreviewBtn);
            this.Controls.Add(this.SaveOrderBtn);
            this.Controls.Add(this.TotalTxt);
            this.Controls.Add(this.TotalPriceLbl);
            this.Controls.Add(this.AaddMoreBtn);
            this.Controls.Add(this.PricePanel);
            this.Controls.Add(this.NoOfItemsPanel);
            this.Controls.Add(this.SubtotalPanel);
            this.Controls.Add(this.ProductTitlePanel);
            this.Controls.Add(this.AddNewOrderHeading);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "AddNewOrder";
            this.Text = "Add New Order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddNewOrder_Load);
            this.ProductTitlePanel.ResumeLayout(false);
            this.ProductTitlePanel.PerformLayout();
            this.PricePanel.ResumeLayout(false);
            this.PricePanel.PerformLayout();
            this.NoOfItemsPanel.ResumeLayout(false);
            this.NoOfItemsPanel.PerformLayout();
            this.SubtotalPanel.ResumeLayout(false);
            this.SubtotalPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddNewOrderHeading;
        private System.Windows.Forms.Panel ProductTitlePanel;
        private System.Windows.Forms.Panel PricePanel;
        private System.Windows.Forms.Panel NoOfItemsPanel;
        private System.Windows.Forms.Panel SubtotalPanel;
        private System.Windows.Forms.Button AaddMoreBtn;
        private System.Windows.Forms.Label TotalPriceLbl;
        private System.Windows.Forms.TextBox TotalTxt;
        private System.Windows.Forms.Button SaveOrderBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Drawing.Printing.PrintDocument InvoicePrintDocument;
        private System.Windows.Forms.PrintPreviewDialog InvoicePrintPreviewDialog;
        private System.Windows.Forms.Button PrintPreviewBtn;
    }
}