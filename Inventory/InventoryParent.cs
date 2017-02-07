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
    public partial class InventoryParent : Form
    {
        
        
        public InventoryParent()
        {
            InitializeComponent();

        }

        

        private void InventoryParent_Load(object sender, EventArgs e)
        {
           //MessageBox.Show(Environment.UserDomainName);
           // string mycolor="h kjjjk";
            if(Properties.Settings.Default.UserId == 0)
            {
                MainMenuStrip.Visible=false;
            }
            SignIn childForm = new SignIn(this);
            childForm.MdiParent = this;
            childForm.Show();
            
        }

        

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Orders>().Count() == 1)
                Application.OpenForms.OfType<Orders>().First().Close();
            Orders childForm = new Orders();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void productsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (Application.OpenForms.OfType<ReportSaleForm>().Count() == 1)
            //    Application.OpenForms.OfType<ReportSaleForm>().First().Close();
            //ReportSaleForm childForm = new ReportSaleForm();
            //childForm.MdiParent = this;
            //childForm.Show();
        }

        private void storeManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vendersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Vender>().Count() == 1)
                Application.OpenForms.OfType<Vender>().First().Close();
            Vender childForm = new Vender();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void addProductBrandToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<AddProductBrand>().Count() == 1)
                Application.OpenForms.OfType<AddProductBrand>().First().Close();
            AddProductBrand childForm = new AddProductBrand();
            childForm.MdiParent = this;
            childForm.Show();
        }

        //private void testFormToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    TestForm1 childForm = new TestForm1();
        //    childForm.MdiParent = this;
        //    childForm.Show();
        //}

        private void brandsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ProductsBrandsList>().Count() == 1)
                Application.OpenForms.OfType<ProductsBrandsList>().First().Close();

            ProductsBrandsList childForm = new ProductsBrandsList();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void addToStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<AddToStock>().Count() == 1)
                Application.OpenForms.OfType<AddToStock>().First().Close();

            AddToStock childForm = new AddToStock();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void stockListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Stock>().Count() == 1)
                Application.OpenForms.OfType<Stock>().First().Close();
            Stock childForm = new Stock();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void addOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<AddNewOrder>().Count() == 1)
                Application.OpenForms.OfType<AddNewOrder>().First().Close();
            AddNewOrder childForm = new AddNewOrder(this);
            childForm.MdiParent = this;
            childForm.Show();

        }

        private void ordersListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Orders>().Count() == 1)
                Application.OpenForms.OfType<Orders>().First().Close();
            Orders childForm = new Orders();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Home>().Count() == 1)
                Application.OpenForms.OfType<Home>().First().Close();
            Home childForm = new Home(this);
            childForm.MdiParent = this;
            childForm.Show();
        }

       

        private void saleReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ReportSaleForm>().Count() == 1)
                Application.OpenForms.OfType<ReportSaleForm>().First().Close();
            ReportSaleForm childForm = new ReportSaleForm();
            childForm.MdiParent = this;
            childForm.Show();
        }
    }
}
