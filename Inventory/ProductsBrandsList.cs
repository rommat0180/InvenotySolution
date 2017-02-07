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
    public partial class ProductsBrandsList : Form
    {
        public ProductsBrandsList()
        {
            InitializeComponent();
        }

        private void ProductsBrandsList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Venders' table. You can move, or remove it, as needed.
            this.vendersTableAdapter.Fill(this.DataSet1.Venders);
            this.productsBrandsTableAdapter.Fill(this.DataSet1.ProductsBrands);
            
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkGoldenrod;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11.75F, FontStyle.Bold);
            //dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.EnableHeadersVisualStyles = false;
            //dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.RowHeadersDefaultCellStyle.ForeColor = Color.DarkGoldenrod;
            //dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //this.productsBrandsTableAdapter.Update(this.DataSet1.ProductsBrands);
        }
    }
}
