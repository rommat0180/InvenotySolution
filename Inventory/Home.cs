using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class Home : Form
    {
        InventoryParent ParentFm; 
        public Home(InventoryParent ParentFm2)
        {
            
            InitializeComponent();
            ParentFm = ParentFm2;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Properties.Settings.Default.Setting.ToString());
            VendersLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            AddProductBrandLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            BrandsListLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            AddToStockLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            StockListLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            AddNewOrderLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            OrdersListLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            SaleTrackingLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            
        }

        private void VendersLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Vender frm = new Vender();
            frm.MdiParent = ParentFm;
            frm.Show();
        }

        private void AddProductBrandLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            AddProductBrand frm = new AddProductBrand();
            frm.MdiParent = ParentFm;
            frm.Show();
        }

        private void BrandsListLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            ProductsBrandsList frm = new ProductsBrandsList();
            frm.MdiParent = ParentFm;
            frm.Show();
        }

        private void AddToStockLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            AddToStock frm = new AddToStock();
            frm.MdiParent = ParentFm;
            frm.Show();
        }

        private void StockListLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Stock frm = new Stock();
            frm.MdiParent = ParentFm;
            frm.Show();
        }

        private void AddNewOrderLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            AddNewOrder frm = new AddNewOrder(ParentFm);
            frm.MdiParent = ParentFm;
            frm.Show();
        }

        private void OrdersListLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Orders frm = new Orders();
            frm.MdiParent = ParentFm;
            frm.Show();
        }

        private void SaleReportLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            ReportSaleForm frm = new ReportSaleForm();
            frm.MdiParent = ParentFm;
            frm.Show();
        }
    }
}
