using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Inventory
{
    public partial class TestForm1 : Form
    {
        public TestForm1()
        {
            InitializeComponent();
        }

        private void TestForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet2.SaleReportSP' table. You can move, or remove it, as needed.
            //this.SaleReportSPTableAdapter.Fill(this.DataSet2.SaleReportSP);
            // TODO: This line of code loads data into the 'dataSet1.ProductsBrands' table. You can move, or remove it, as needed.
            this.productsBrandsTableAdapter.Fill(this.dataSet1.ProductsBrands);
            // TODO: This line of code loads data into the 'DataSet2.SaleReportDateSP' table. You can move, or remove it, as needed.
            //this.SaleReportDateSPTableAdapter.Fill(this.DataSet2.SaleReportDateSP, DateFrom, DateTo);

            //this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SaleReportDateSPTableAdapter.Fill(this.DataSet2.SaleReportDateSP, dateFromPicker.Value, dateToPicker.Value);
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = SaleReportDateSPBindingSource;
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //this.SaleReportSPTableAdapter.Fill(this.DataSet2.SaleReportSP);
            this.SaleReportSPTableAdapter.Fill(this.DataSet2.SaleReportSP, dateFromPicker2.Value, dateToPicker2.Value, Convert.ToInt32(comboBox1.SelectedValue.ToString()));
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSetSaleReportWithTitle";
            rds.Value = SaleReportSPBindingSource;
            this.reportViewer2.LocalReport.DataSources.Clear();
            this.reportViewer2.LocalReport.DataSources.Add(rds);
            this.reportViewer2.LocalReport.Refresh();
            this.reportViewer2.RefreshReport();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
