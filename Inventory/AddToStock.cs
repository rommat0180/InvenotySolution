using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory
{
    public partial class AddToStock : Form
    {
        public static string connstr = ConfigurationManager.ConnectionStrings["inventorysolution"].ConnectionString;
        SqlConnection Conn = new SqlConnection(connstr);    

        public AddToStock()
        {
            InitializeComponent();
        }

        

        private void Barcode_LoadProduct(object sender, EventArgs e)
        {
           // MessageBox.Show("k hh k k ");
        }

        private void AddToStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.ProductsBrands' table. You can move, or remove it, as needed.
            this.productsBrandsTableAdapter.Fill(this.DataSet1.ProductsBrands);
            productsBrandsBindingSource.Sort = "ProductTitle ASC";
        }

        private void SaveBrand_Click(object sender, EventArgs e)
        {
            int bar; int prod;
            //MessageBox.Show(ProductIdComboBox.SelectedValue.ToString());
            //MessageBox.Show(VenderComboBox.Text);
            //barcode = new SqlDataAdapter("Select Count(Id) From ProductsBrands Where Barcode='"+BarcodeTxt.Text+"'",Conn);




            decimal NoOfItems;
            int Cost;
            bool VldNoOfItems = decimal.TryParse(NoOfItemsTxt.Text, out NoOfItems);
            bool VldCost = int.TryParse(CostTxt.Text, out Cost);
            ErrNoOfItems.Visible = false;
            ErrCost.Visible = false;
            if (!VldNoOfItems)
            {
                ErrNoOfItems.Text = "Enter NoOfItems in digits";
                ErrNoOfItems.Visible = true;
            }
            else if (!VldCost)
            {
                ErrCost.Text = "Enter Cost in digits";
                ErrCost.Visible = true;
            }
            else
            {
                DateTime ReceivingDate = DateTime.Now;
                SqlCommand cmd = new SqlCommand("INSERT Into Stock (ProductId,NoOfItems,Cost,ReceivingDate,AdminId) VALUES ('" + Int32.Parse(ProductIdComboBox.SelectedValue.ToString()) + "','" + NoOfItemsTxt.Text + "','" + CostTxt.Text + "', '"+ ReceivingDate+ "','1' )");
                Conn.Open();
                cmd.Connection = Conn;
                cmd.ExecuteNonQuery();
                Conn.Close();
                ProductIdComboBox.SelectedValue = 0;
                NoOfItemsTxt.Text = "";
                CostTxt.Text = "";
            }

                /*Conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT Into ProductsBrands (BarCode,ProductTitle,Vender,PricePerItem,AdminId) VALUES ('"+BarcodeTxt.Text+"','"+ProductTitleTxt.Text+"','"+VenderTxt.Text+"','"+PricePerItemTxt.Text+"','1' )");
                cmd.Connection = Conn;
                cmd.ExecuteNonQuery();
                Conn.Close();*/
        }
    }
}
