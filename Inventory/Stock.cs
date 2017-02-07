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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.ProductsBrands' table. You can move, or remove it, as needed.
            this.productsBrandsTableAdapter.Fill(this.DataSet1.ProductsBrands);
            // TODO: This line of code loads data into the 'DataSet1.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.DataSet1.Stock);

            
        }

        private void StockUpdateBtn_Click(object sender, EventArgs e)
        {
            this.stockTableAdapter.Update(this.DataSet1.Stock);
        }
    }
}
