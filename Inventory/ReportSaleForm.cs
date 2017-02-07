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
    public partial class ReportSaleForm : Form
    {
        public ReportSaleForm()
        {
            InitializeComponent();
        }

        private void ReportSaleForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet2.SaleReportSP' table. You can move, or remove it, as needed.
            //this.SaleReportSPTableAdapter.Fill(this.DataSet2.SaleReportSP);
            // TODO: This line of code loads data into the 'dataSet1.ProductsBrands' table. You can move, or remove it, as needed.
            this.productsBrandsTableAdapter.Fill(this.dataSet1.ProductsBrands);
            // TODO: This line of code loads data into the 'DataSetSaleReport.SaleReportDateSP' table. You can move, or remove it, as needed.
            //this.SaleReportDateSPTableAdapter.Fill(this.DataSetSaleReport.SaleReportDateSP);

        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            this.saleReportDateSPTableAdapter.Fill(this.dataSetSaleReport.SaleReportDateSP, dateFromPicker.Value, dateToPicker.Value);
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "SaleReportDate";
            rds.Value = saleReportDateSPBindingSource;
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void FilterBtn2_Click(object sender, EventArgs e)
        {
            this.saleReportSPTableAdapter.Fill(this.dataSetSaleReport.SaleReportSP, dateFromPicker2.Value, dateToPicker2.Value, Convert.ToInt32(comboBoxProductTitle.SelectedValue.ToString()));
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "SaleReportProduct";
            rds.Value = saleReportSPBindingSource;
            this.reportViewer2.LocalReport.DataSources.Clear();
            this.reportViewer2.LocalReport.DataSources.Add(rds);
            this.reportViewer2.LocalReport.Refresh();
            this.reportViewer2.RefreshReport();
        }

        private void tabPageAllSoldProductsWithDateFilter_Click(object sender, EventArgs e)
        {

        }
    }
}
