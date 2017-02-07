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
    public partial class AddProductBrand : Form
    {
        public static string connstr = ConfigurationManager.ConnectionStrings["inventorysolution"].ConnectionString; 
        SqlConnection Conn = new SqlConnection(connstr);
        
        public AddProductBrand()
        {
            InitializeComponent();
        }

        private void SaveBrand_Click(object sender, EventArgs e)
        {
            int bar; int prod;
            decimal PricePerItem;
            bool VldPrice = decimal.TryParse(PricePerItemTxt.Text, out PricePerItem);
            if (ProductTitleTxt.Text == "")
            {
                ErrProductTitle.Text = "Enter Product Title";
                ErrProductTitle.Visible = true;
            }
            else if (!VldPrice)
            {
                ErrPricePerItem.Text = "Enter Unit Price in Digits";
                ErrPricePerItem.Visible = true;
            }
            else
            {
                
               /* using (SqlCommand command = new SqlCommand("Select Count(Id) From ProductsBrands Where Barcode='" + BarcodeTxt.Text + "'", Conn))
                {
                    Conn.Open();
                    using (SqlDataReader rd = command.ExecuteReader())
                    {
                        rd.Read();
                        bar = rd.GetInt32(0);
                    }
                    Conn.Close();
                }*/
                using (SqlCommand command = new SqlCommand("Select Count(Id) From ProductsBrands Where ProductTitle='" + ProductTitleTxt.Text + "'", Conn))
                {
                    Conn.Open();
                    using (SqlDataReader rd = command.ExecuteReader())
                    {
                        rd.Read();
                        prod = rd.GetInt32(0);                        
                    }
                    Conn.Close();
                }

                /*if (bar > 0)
                {
                    MessageBox.Show("Product having this barcode already exists ");
                }*/
                if (prod > 0)
                {
                    MessageBox.Show("Product having this Product Title already exists ");
                }
                else { 
                    SqlCommand cmd = new SqlCommand("INSERT Into ProductsBrands (BarCode,ProductTitle,Vender,PricePerItem,AdminId) VALUES ('" + BarcodeTxt.Text + "','" + ProductTitleTxt.Text + "','" + Int32.Parse(VenderComboBox.SelectedValue.ToString()) + "','" + PricePerItemTxt.Text + "','1' )");
                    Conn.Open();
                    cmd.Connection = Conn;
                    cmd.ExecuteNonQuery();
                    Conn.Close();

                    BarcodeTxt.Text = "";
                    ProductTitleTxt.Text = "";
                    VenderComboBox.SelectedValue = 0;
                    PricePerItemTxt.Text = "";
                }
            }
        }

        private void AddProductBrand_Load(object sender, EventArgs e)
        {
            VenderAutocompleteCombobox();
        }
        private void VenderAutocompleteCombobox()
        {
            // First make simple combobox with dropdown on click
            DataSet ds = new DataSet();
            SqlDataAdapter pidname = new SqlDataAdapter("Select * From Venders", Conn);
            pidname.Fill(ds, "Venders");
            VenderComboBox.DataSource = ds.Tables[0];
            VenderComboBox.ValueMember = "Id";
            VenderComboBox.DisplayMember = "Name";

            //Then make the above combobox as autocomplete
            VenderComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            VenderComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection autocomp = new AutoCompleteStringCollection();
            int i = 0;
            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                autocomp.Add(ds.Tables[0].Rows[i]["Name"].ToString());

            }
            VenderComboBox.AutoCompleteCustomSource = autocomp;
            
        }
        /*private void VenderAutocompleteTxtbox()
        {
            using (SqlCommand command = new SqlCommand("select name from Venders", Conn))
            {
                Conn.Open();
                using (SqlDataReader rd = command.ExecuteReader())
                {
                    AutoCompleteStringCollection autocomp = new AutoCompleteStringCollection();
                    while (rd.Read())
                    {
                        autocomp.Add(rd.GetString(0));   
                    }
                    VenderTxt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    VenderTxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    VenderTxt.AutoCompleteCustomSource = autocomp;
                }
                
                Conn.Close();
            }
        }*/

        
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
