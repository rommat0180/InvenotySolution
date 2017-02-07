namespace Inventory
{
    partial class ReportSaleForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAllSoldProductsWithDateFilter = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FromDateLbl = new System.Windows.Forms.Label();
            this.ToDateLbl = new System.Windows.Forms.Label();
            this.FilterBtn = new System.Windows.Forms.Button();
            this.dateToPicker = new System.Windows.Forms.DateTimePicker();
            this.dateFromPicker = new System.Windows.Forms.DateTimePicker();
            this.tabPageAllSoldProductsWithTitleFilter = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProductTitleLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FilterBtn2 = new System.Windows.Forms.Button();
            this.dateToPicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateFromPicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxProductTitle = new System.Windows.Forms.ComboBox();
            this.dataSet1 = new Inventory.DataSet1();
            this.productsBrandsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBrandsTableAdapter = new Inventory.DataSet1TableAdapters.ProductsBrandsTableAdapter();
            this.dataSetSaleReport = new Inventory.DataSetSaleReport();
            this.saleReportDateSPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleReportDateSPTableAdapter = new Inventory.DataSetSaleReportTableAdapters.SaleReportDateSPTableAdapter();
            this.saleReportSPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleReportSPTableAdapter = new Inventory.DataSetSaleReportTableAdapters.SaleReportSPTableAdapter();
            this.LblFromDate = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageAllSoldProductsWithDateFilter.SuspendLayout();
            this.tabPageAllSoldProductsWithTitleFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBrandsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSaleReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleReportDateSPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleReportSPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAllSoldProductsWithDateFilter);
            this.tabControl1.Controls.Add(this.tabPageAllSoldProductsWithTitleFilter);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1162, 783);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageAllSoldProductsWithDateFilter
            // 
            this.tabPageAllSoldProductsWithDateFilter.Controls.Add(this.reportViewer1);
            this.tabPageAllSoldProductsWithDateFilter.Controls.Add(this.FromDateLbl);
            this.tabPageAllSoldProductsWithDateFilter.Controls.Add(this.ToDateLbl);
            this.tabPageAllSoldProductsWithDateFilter.Controls.Add(this.FilterBtn);
            this.tabPageAllSoldProductsWithDateFilter.Controls.Add(this.dateToPicker);
            this.tabPageAllSoldProductsWithDateFilter.Controls.Add(this.dateFromPicker);
            this.tabPageAllSoldProductsWithDateFilter.Location = new System.Drawing.Point(4, 22);
            this.tabPageAllSoldProductsWithDateFilter.Name = "tabPageAllSoldProductsWithDateFilter";
            this.tabPageAllSoldProductsWithDateFilter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAllSoldProductsWithDateFilter.Size = new System.Drawing.Size(1154, 757);
            this.tabPageAllSoldProductsWithDateFilter.TabIndex = 0;
            this.tabPageAllSoldProductsWithDateFilter.Text = "All Sold Products With Date Filter";
            this.tabPageAllSoldProductsWithDateFilter.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource6.Name = "SaleReportDate";
            reportDataSource6.Value = this.saleReportDateSPBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.ReportSaleReportDate.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 85);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1142, 580);
            this.reportViewer1.TabIndex = 3;
            // 
            // FromDateLbl
            // 
            this.FromDateLbl.AutoSize = true;
            this.FromDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDateLbl.Location = new System.Drawing.Point(128, 44);
            this.FromDateLbl.Name = "FromDateLbl";
            this.FromDateLbl.Size = new System.Drawing.Size(88, 17);
            this.FromDateLbl.TabIndex = 2;
            this.FromDateLbl.Text = "From Date:";
            // 
            // ToDateLbl
            // 
            this.ToDateLbl.AutoSize = true;
            this.ToDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDateLbl.Location = new System.Drawing.Point(349, 47);
            this.ToDateLbl.Name = "ToDateLbl";
            this.ToDateLbl.Size = new System.Drawing.Size(71, 17);
            this.ToDateLbl.TabIndex = 2;
            this.ToDateLbl.Text = "To Date:";
            // 
            // FilterBtn
            // 
            this.FilterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterBtn.Location = new System.Drawing.Point(574, 37);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(75, 31);
            this.FilterBtn.TabIndex = 1;
            this.FilterBtn.Text = "Filter";
            this.FilterBtn.UseVisualStyleBackColor = true;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // dateToPicker
            // 
            this.dateToPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateToPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateToPicker.Location = new System.Drawing.Point(426, 44);
            this.dateToPicker.Name = "dateToPicker";
            this.dateToPicker.Size = new System.Drawing.Size(122, 23);
            this.dateToPicker.TabIndex = 0;
            // 
            // dateFromPicker
            // 
            this.dateFromPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFromPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFromPicker.Location = new System.Drawing.Point(220, 44);
            this.dateFromPicker.Name = "dateFromPicker";
            this.dateFromPicker.Size = new System.Drawing.Size(109, 23);
            this.dateFromPicker.TabIndex = 0;
            // 
            // tabPageAllSoldProductsWithTitleFilter
            // 
            this.tabPageAllSoldProductsWithTitleFilter.Controls.Add(this.comboBoxProductTitle);
            this.tabPageAllSoldProductsWithTitleFilter.Controls.Add(this.reportViewer2);
            this.tabPageAllSoldProductsWithTitleFilter.Controls.Add(this.ProductTitleLbl);
            this.tabPageAllSoldProductsWithTitleFilter.Controls.Add(this.LblFromDate);
            this.tabPageAllSoldProductsWithTitleFilter.Controls.Add(this.label2);
            this.tabPageAllSoldProductsWithTitleFilter.Controls.Add(this.FilterBtn2);
            this.tabPageAllSoldProductsWithTitleFilter.Controls.Add(this.dateToPicker2);
            this.tabPageAllSoldProductsWithTitleFilter.Controls.Add(this.dateFromPicker2);
            this.tabPageAllSoldProductsWithTitleFilter.Location = new System.Drawing.Point(4, 22);
            this.tabPageAllSoldProductsWithTitleFilter.Name = "tabPageAllSoldProductsWithTitleFilter";
            this.tabPageAllSoldProductsWithTitleFilter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAllSoldProductsWithTitleFilter.Size = new System.Drawing.Size(1154, 757);
            this.tabPageAllSoldProductsWithTitleFilter.TabIndex = 1;
            this.tabPageAllSoldProductsWithTitleFilter.Text = "All Sold Products With Title Filter";
            this.tabPageAllSoldProductsWithTitleFilter.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            reportDataSource5.Name = "SaleReportProduct";
            reportDataSource5.Value = this.saleReportSPBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Inventory.ReportSaleReportProduct.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(-5, 61);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(1142, 616);
            this.reportViewer2.TabIndex = 9;
            // 
            // ProductTitleLbl
            // 
            this.ProductTitleLbl.AutoSize = true;
            this.ProductTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductTitleLbl.Location = new System.Drawing.Point(167, 37);
            this.ProductTitleLbl.Name = "ProductTitleLbl";
            this.ProductTitleLbl.Size = new System.Drawing.Size(106, 17);
            this.ProductTitleLbl.TabIndex = 7;
            this.ProductTitleLbl.Text = "Product Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(658, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "To Date:";
            // 
            // FilterBtn2
            // 
            this.FilterBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterBtn2.Location = new System.Drawing.Point(863, 30);
            this.FilterBtn2.Name = "FilterBtn2";
            this.FilterBtn2.Size = new System.Drawing.Size(75, 30);
            this.FilterBtn2.TabIndex = 6;
            this.FilterBtn2.Text = "Filter";
            this.FilterBtn2.UseVisualStyleBackColor = true;
            this.FilterBtn2.Click += new System.EventHandler(this.FilterBtn2_Click);
            // 
            // dateToPicker2
            // 
            this.dateToPicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateToPicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateToPicker2.Location = new System.Drawing.Point(735, 33);
            this.dateToPicker2.Name = "dateToPicker2";
            this.dateToPicker2.Size = new System.Drawing.Size(122, 23);
            this.dateToPicker2.TabIndex = 4;
            // 
            // dateFromPicker2
            // 
            this.dateFromPicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFromPicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFromPicker2.Location = new System.Drawing.Point(543, 32);
            this.dateFromPicker2.Name = "dateFromPicker2";
            this.dateFromPicker2.Size = new System.Drawing.Size(109, 23);
            this.dateFromPicker2.TabIndex = 5;
            // 
            // comboBoxProductTitle
            // 
            this.comboBoxProductTitle.DataSource = this.productsBrandsBindingSource;
            this.comboBoxProductTitle.DisplayMember = "ProductTitle";
            this.comboBoxProductTitle.FormattingEnabled = true;
            this.comboBoxProductTitle.Location = new System.Drawing.Point(279, 35);
            this.comboBoxProductTitle.Name = "comboBoxProductTitle";
            this.comboBoxProductTitle.Size = new System.Drawing.Size(149, 21);
            this.comboBoxProductTitle.TabIndex = 10;
            this.comboBoxProductTitle.ValueMember = "Id";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dataSetSaleReport
            // 
            this.dataSetSaleReport.DataSetName = "DataSetSaleReport";
            this.dataSetSaleReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saleReportDateSPBindingSource
            // 
            this.saleReportDateSPBindingSource.DataMember = "SaleReportDateSP";
            this.saleReportDateSPBindingSource.DataSource = this.dataSetSaleReport;
            // 
            // saleReportDateSPTableAdapter
            // 
            this.saleReportDateSPTableAdapter.ClearBeforeFill = true;
            // 
            // saleReportSPBindingSource
            // 
            this.saleReportSPBindingSource.DataMember = "SaleReportSP";
            this.saleReportSPBindingSource.DataSource = this.dataSetSaleReport;
            // 
            // saleReportSPTableAdapter
            // 
            this.saleReportSPTableAdapter.ClearBeforeFill = true;
            // 
            // LblFromDate
            // 
            this.LblFromDate.AutoSize = true;
            this.LblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFromDate.Location = new System.Drawing.Point(449, 36);
            this.LblFromDate.Name = "LblFromDate";
            this.LblFromDate.Size = new System.Drawing.Size(88, 17);
            this.LblFromDate.TabIndex = 8;
            this.LblFromDate.Text = "From Date:";
            // 
            // ReportSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 576);
            this.Controls.Add(this.tabControl1);
            this.Name = "ReportSaleForm";
            this.Text = "ReportSaleForm";
            this.Load += new System.EventHandler(this.ReportSaleForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAllSoldProductsWithDateFilter.ResumeLayout(false);
            this.tabPageAllSoldProductsWithDateFilter.PerformLayout();
            this.tabPageAllSoldProductsWithTitleFilter.ResumeLayout(false);
            this.tabPageAllSoldProductsWithTitleFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBrandsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSaleReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleReportDateSPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleReportSPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAllSoldProductsWithDateFilter;
        private System.Windows.Forms.TabPage tabPageAllSoldProductsWithTitleFilter;
        private System.Windows.Forms.Label FromDateLbl;
        private System.Windows.Forms.Label ToDateLbl;
        private System.Windows.Forms.Button FilterBtn;
        private System.Windows.Forms.DateTimePicker dateToPicker;
        private System.Windows.Forms.DateTimePicker dateFromPicker;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Label ProductTitleLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FilterBtn2;
        private System.Windows.Forms.DateTimePicker dateToPicker2;
        private System.Windows.Forms.DateTimePicker dateFromPicker2;
        private System.Windows.Forms.ComboBox comboBoxProductTitle;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource productsBrandsBindingSource;
        private DataSet1TableAdapters.ProductsBrandsTableAdapter productsBrandsTableAdapter;
        private System.Windows.Forms.BindingSource saleReportDateSPBindingSource;
        private DataSetSaleReport dataSetSaleReport;
        private System.Windows.Forms.BindingSource saleReportSPBindingSource;
        private DataSetSaleReportTableAdapters.SaleReportDateSPTableAdapter saleReportDateSPTableAdapter;
        private DataSetSaleReportTableAdapters.SaleReportSPTableAdapter saleReportSPTableAdapter;
        private System.Windows.Forms.Label LblFromDate;
    }
}