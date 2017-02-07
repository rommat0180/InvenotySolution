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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.dataSet1.Orders);
            // TODO: This line of code loads data into the 'dataSet1.ProductsBrands' table. You can move, or remove it, as needed.
            this.productsBrandsTableAdapter.Fill(this.dataSet1.ProductsBrands);
            // TODO: This line of code loads data into the 'dataSet1.OrderProducts' table. You can move, or remove it, as needed.
            this.orderProductsTableAdapter.Fill(this.dataSet1.OrderProducts);
            // TODO: This line of code loads data into the 'dataSet1.ProductsBrands' table. You can move, or remove it, as needed.
            //this.productsBrandsTableAdapter.Fill(this.dataSet1.ProductsBrands);
            // TODO: This line of code loads data into the 'DataSet1.Orders' table. You can move, or remove it, as needed.
            //this.ordersTableAdapter.Fill(this.DataSet1.Orders);
            // TODO: This line of code loads data into the 'DataSet1.ProductsBrands' table. You can move, or remove it, as needed.
            //this.productsBrandsTableAdapter.Fill(this.DataSet1.ProductsBrands);
            // TODO: This line of code loads data into the 'DataSet1.OrderProducts' table. You can move, or remove it, as needed.
            //this.orderProductsTableAdapter.Fill(this.DataSet1.OrderProducts);
            // TODO: This line of code loads data into the 'DataSet1.OrderProducts' table. You can move, or remove it, as needed.
            //this.orderProductsTableAdapter.Fill(this.DataSet1.OrderProducts);
            // TODO: This line of code loads data into the 'DataSet1.OrderProducts' table. You can move, or remove it, as needed.
            //this.orderProductsTableAdapter.Fill(this.DataSet1.OrderProducts);
            // TODO: This line of code loads data into the 'DataSet1.Orders' table. You can move, or remove it, as needed.
            //this.ordersTableAdapter.Fill(this.DataSet1.Orders);

        }
    }
}
