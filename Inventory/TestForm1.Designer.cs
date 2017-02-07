namespace Inventory
{
    partial class TestForm1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SaleReportDateSPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet2 = new Inventory.DataSet2();
            this.SaleReportDateSPTableAdapter = new Inventory.DataSet2TableAdapters.SaleReportDateSPTableAdapter();
            this.dataSet1 = new Inventory.DataSet1();
            this.productsBrandsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBrandsTableAdapter = new Inventory.DataSet1TableAdapters.ProductsBrandsTableAdapter();
            this.SaleReportSPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaleReportSPTableAdapter = new Inventory.DataSet2TableAdapters.SaleReportSPTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateToPicker = new System.Windows.Forms.DateTimePicker();
            this.dateFromPicker = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dateToPicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateFromPicker2 = new System.Windows.Forms.DateTimePicker();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.SaleReportDateSPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBrandsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleReportSPBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaleReportDateSPBindingSource
            // 
            this.SaleReportDateSPBindingSource.DataMember = "SaleReportDateSP";
            this.SaleReportDateSPBindingSource.DataSource = this.DataSet2;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SaleReportDateSPTableAdapter
            // 
            this.SaleReportDateSPTableAdapter.ClearBeforeFill = true;
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
            // SaleReportSPBindingSource
            // 
            this.SaleReportSPBindingSource.DataMember = "SaleReportSP";
            this.SaleReportSPBindingSource.DataSource = this.DataSet2;
            // 
            // SaleReportSPTableAdapter
            // 
            this.SaleReportSPTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dateToPicker);
            this.groupBox1.Controls.Add(this.dateFromPicker);
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Location = new System.Drawing.Point(12, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 260);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateToPicker
            // 
            this.dateToPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateToPicker.Location = new System.Drawing.Point(496, 130);
            this.dateToPicker.Name = "dateToPicker";
            this.dateToPicker.Size = new System.Drawing.Size(200, 20);
            this.dateToPicker.TabIndex = 14;
            // 
            // dateFromPicker
            // 
            this.dateFromPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFromPicker.Location = new System.Drawing.Point(483, 51);
            this.dateFromPicker.Name = "dateFromPicker";
            this.dateFromPicker.Size = new System.Drawing.Size(200, 20);
            this.dateFromPicker.TabIndex = 13;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SaleReportDateSPBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(64, 7);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 376);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 394);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.dateToPicker2);
            this.tabPage1.Controls.Add(this.dateFromPicker2);
            this.tabPage1.Controls.Add(this.reportViewer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(752, 368);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.productsBrandsBindingSource;
            this.comboBox1.DisplayMember = "ProductTitle";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(488, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.ValueMember = "Id";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(545, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateToPicker2
            // 
            this.dateToPicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateToPicker2.Location = new System.Drawing.Point(488, 187);
            this.dateToPicker2.Name = "dateToPicker2";
            this.dateToPicker2.Size = new System.Drawing.Size(200, 20);
            this.dateToPicker2.TabIndex = 19;
            // 
            // dateFromPicker2
            // 
            this.dateFromPicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFromPicker2.Location = new System.Drawing.Point(488, 135);
            this.dateFromPicker2.Name = "dateFromPicker2";
            this.dateFromPicker2.Size = new System.Drawing.Size(200, 20);
            this.dateFromPicker2.TabIndex = 18;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSetSaleReportWithTitle";
            reportDataSource2.Value = this.SaleReportSPBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Inventory.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(36, 64);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(396, 246);
            this.reportViewer2.TabIndex = 17;
            // 
            // TestForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 782);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(1200, 1200);
            this.Name = "TestForm1";
            this.Text = "TestForm1";
            this.Load += new System.EventHandler(this.TestForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SaleReportDateSPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBrandsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleReportSPBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource SaleReportDateSPBindingSource;
        private DataSet2 DataSet2;
        private DataSet2TableAdapters.SaleReportDateSPTableAdapter SaleReportDateSPTableAdapter;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource productsBrandsBindingSource;
        private DataSet1TableAdapters.ProductsBrandsTableAdapter productsBrandsTableAdapter;
        private System.Windows.Forms.BindingSource SaleReportSPBindingSource;
        private DataSet2TableAdapters.SaleReportSPTableAdapter SaleReportSPTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateToPicker;
        private System.Windows.Forms.DateTimePicker dateFromPicker;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateToPicker2;
        private System.Windows.Forms.DateTimePicker dateFromPicker2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.TabPage tabPage2;
    }
}