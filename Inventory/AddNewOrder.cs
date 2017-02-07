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
    public partial class AddNewOrder : Form
    {
       
        static int col = 0;
        static int rowpos = 30;
        static int CountR=1;
        InventoryParent TheParent;
        DataTable dtCurrentOrder;
        public static string connstr = ConfigurationManager.ConnectionStrings["inventorysolution"].ConnectionString;
        SqlConnection Conn = new SqlConnection(connstr);

        public AddNewOrder(InventoryParent ParentForm)
        {
            InitializeComponent();
            TheParent = ParentForm;
        }
        
        private void AddNewOrder_Load(object sender, EventArgs e)
        {
            CountR = 1;
            rowpos = 30;
            //MessageBox.Show(CountR.ToString());
            AdControllRows(8);
        }

        void AdControllRows(int n)
        {
            int m = CountR + n;
            int i;
            for ( i = CountR; i < m; i++)
            {
                ComboBox ComboBox1 = new ComboBox();
                ComboBox1.Name = "ProductTitleComboBox" + i.ToString();
                ComboBox1.Location = new Point(col, rowpos);
                ComboBox1.Size = new Size(330, 30);
                ComboBox1.SelectedValueChanged += new System.EventHandler(ProductTitle_SelectedValueChanged); 

                DataSet ds = new DataSet();
                SqlDataAdapter pidname = new SqlDataAdapter(@"Select Distinct PB.* From ProductsBrands PB INNER JOIN
                        Stock S ON PB.Id = S.ProductId", Conn);
                pidname.Fill(ds);

                DataRow row = ds.Tables[0].NewRow();
                row["ProductTitle"] = ""; //insert a blank row - you can even write something lile  = "Please select bellow...";
                ds.Tables[0].Rows.InsertAt(row, 0);

                ComboBox1.DataSource = ds.Tables[0];
                ComboBox1.SelectedIndex = -1;

                ComboBox1.ValueMember = "Id";
                ComboBox1.DisplayMember = "ProductTitle";

                //Then make the above combobox as autocomplete
                ComboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                ComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                AutoCompleteStringCollection autocomp = new AutoCompleteStringCollection();

                
                int k = 0;
                for (k = 0; k <= ds.Tables[0].Rows.Count - 1; k++)
                {
                    autocomp.Add(ds.Tables[0].Rows[k]["ProductTitle"].ToString());

                }
                
                ComboBox1.AutoCompleteCustomSource = autocomp;
                //ComboBox1.SelectedIndex = -1;
                // ComboBox1.SelectedValue = 2;

                ProductTitlePanel.Controls.Add(ComboBox1);


                TextBox textBox2 = new TextBox();
                textBox2.Name = "PricePerItemTxt" + i.ToString();
                textBox2.Location = new Point(col, rowpos);
                textBox2.Size = new Size(150, 30);
                textBox2.ReadOnly = true;
                //textBox2.Visible = false;
                PricePanel.Controls.Add(textBox2);

                TextBox textBox3 = new TextBox();
                textBox3.Name = "NoOfItemsTxt" + i.ToString();
                textBox3.Location = new Point(col, rowpos);
                textBox3.Size = new Size(150, 30);
                textBox3.Text = "1";
                textBox3.TextChanged += new System.EventHandler(NoOfItems_TextChanged); 
                NoOfItemsPanel.Controls.Add(textBox3);

                Label ErrtextBox3 = new Label();
                ErrtextBox3.Name = "ErrNoOfItems" + i.ToString();
                ErrtextBox3.Location = new Point(col, rowpos+20);
                ErrtextBox3.ForeColor = Color.Red;
                ErrtextBox3.Text = "Enter Quantity";
                ErrtextBox3.Height = 20;
                ErrtextBox3.Visible = false;
                NoOfItemsPanel.Controls.Add(ErrtextBox3);


                TextBox textBox4 = new TextBox();
                textBox4.Name = "SubtotalTxt" + i.ToString();
                textBox4.Location = new Point(col, rowpos);
                textBox4.Size = new Size(150, 30);
                textBox4.ReadOnly = true;
                SubtotalPanel.Controls.Add(textBox4);

               rowpos += 40;               
            }
            CountR = i;
        }

        private void AaddMoreBtn_Click(object sender, EventArgs e)
        {
            AdControllRows(1);
        }

        private void ProductTitle_SelectedValueChanged(object sender, EventArgs e)
        {
            PriceFiller();
        }

        private void NoOfItems_TextChanged(object sender, EventArgs e)
        {
            
            PriceFiller();
        }

        private void PriceFiller()
        {
            Decimal Total = 0;
            int ProductId;
            int NoOfItems;
            for (int j = 1; j < CountR; j++)
            {
                
                bool result = Int32.TryParse(((ComboBox)ProductTitlePanel.Controls["ProductTitleComboBox" + j.ToString()]).SelectedValue.ToString(), out ProductId);
                bool result2 = Int32.TryParse(((TextBox)NoOfItemsPanel.Controls["NoOfItemsTxt" + j.ToString()]).Text, out NoOfItems);
                
                if (result)
                {
                    SqlDataAdapter sda = new SqlDataAdapter(@"Select PB.PricePerItem,S.Cost as CostPerItem  
                        From ProductsBrands PB INNER JOIN
                        Stock S ON PB.Id = S.ProductId 
                        WHERE PB.Id='" + ProductId + "'", Conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    decimal PricePerItem = decimal.Parse(dt.Rows[0]["PricePerItem"].ToString());
                    decimal CostPerItem = decimal.Parse(dt.Rows[0]["CostPerItem"].ToString());
                    NoOfItems = (result2) ? NoOfItems : 1;
                    decimal Subtotal = NoOfItems * PricePerItem;
                    Total += Subtotal;
                    ((TextBox)PricePanel.Controls["PricePerItemTxt" + j.ToString()]).Text = PricePerItem.ToString();
                    //((TextBox)PricePanel.Controls["CostPerItemTxt" + j.ToString()]).Text = CostPerItem.ToString();
                    ((TextBox)SubtotalPanel.Controls["SubtotalTxt" + j.ToString()]).Text = Subtotal.ToString();
                    //((TextBox)NoOfItemsPanel.Controls["NoOfItemsTxt" + j.ToString()]).Text = NoOfItems.ToString();
                }
            }
            TotalTxt.Text = Total.ToString();
        }

        private void SaveOrderBtn_Click(object sender, EventArgs e)
        {
            //SaveOrderBtn.Enabled = false;
            DateTime OrderDate = DateTime.Now;
            decimal Total;
            int SalemanId = 2;
            string Status = "Completed";
            bool result5 = decimal.TryParse(TotalTxt.Text, out Total);
            SqlDataAdapter sda = new SqlDataAdapter("Insert Into Orders (OrderDate,Total,SalemanId,Status) Values('" + OrderDate + "','" + Total + "','" + SalemanId + "','" + Status + "');SELECT SCOPE_IDENTITY() as CurrentOrderId;", Conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int CurrentOrderId = Int32.Parse(dt.Rows[0]["CurrentOrderId"].ToString());
            //MessageBox.Show(CurrentOrderId.ToString());

            int ProductId;
            decimal PricePerItem;
            decimal CostPerItem;
            int NoOfItems;
            decimal Subtotal;

            for (int j = 1; j < CountR; j++)
            {
                                
                bool result = Int32.TryParse(((ComboBox)ProductTitlePanel.Controls["ProductTitleComboBox" + j.ToString()]).SelectedValue.ToString(), out ProductId);
                bool result2 = decimal.TryParse(((TextBox)PricePanel.Controls["PricePerItemTxt" + j.ToString()]).Text, out PricePerItem);
                //bool result2Hidden = decimal.TryParse(((TextBox)PricePanel.Controls["CostPerItemTxt" + j.ToString()]).Text, out CostPerItem);
                bool result3 = Int32.TryParse(((TextBox)NoOfItemsPanel.Controls["NoOfItemsTxt" + j.ToString()]).Text, out NoOfItems);
                bool result4 = decimal.TryParse(((TextBox)SubtotalPanel.Controls["SubtotalTxt" + j.ToString()]).Text, out Subtotal);
                ((Label)NoOfItemsPanel.Controls["ErrNoOfItems" + j.ToString()]).Text = "";
                if (result)
                {
                    if (!result3)
                    {
                        ((Label)NoOfItemsPanel.Controls["ErrNoOfItems" + j.ToString()]).Text = "Enter Quantity digits";
                        ((Label)NoOfItemsPanel.Controls["ErrNoOfItems" + j.ToString()]).Visible = true;
                        return;
                    }                    
                }
            }
            for (int j = 1; j < CountR; j++)
            {

                bool result = Int32.TryParse(((ComboBox)ProductTitlePanel.Controls["ProductTitleComboBox" + j.ToString()]).SelectedValue.ToString(), out ProductId);
                bool result2 = decimal.TryParse(((TextBox)PricePanel.Controls["PricePerItemTxt" + j.ToString()]).Text, out PricePerItem);
               // bool result2Hidden = decimal.TryParse(((TextBox)PricePanel.Controls["CostPerItemTxt" + j.ToString()]).Text, out CostPerItem);
                bool result3 = Int32.TryParse(((TextBox)NoOfItemsPanel.Controls["NoOfItemsTxt" + j.ToString()]).Text, out NoOfItems);
                bool result4 = decimal.TryParse(((TextBox)SubtotalPanel.Controls["SubtotalTxt" + j.ToString()]).Text, out Subtotal);

                if (result)
                {
                    SqlDataAdapter sda2 = new SqlDataAdapter("Insert Into OrderProducts (ProductId,Price,NoOfItems,Subtotal,OrderId) Values('" + ProductId + "','" + PricePerItem + "','" + NoOfItems + "','" + Subtotal + "','" + CurrentOrderId + "')", Conn);
                    dtCurrentOrder = new DataTable();
                    sda2.Fill(dtCurrentOrder);                   
                }
            }
           InvoicePrintDocument.Print(); 

            /*
             * print invoice and then make the fields empty
            */

            
            AddNewOrder frm = new AddNewOrder(TheParent);
            frm.MdiParent = TheParent;
            frm.Show();
            this.Close();
            /*for (int j = 1; j < CountR; j++)
            {


                bool result = Int32.TryParse(((ComboBox)ProductTitlePanel.Controls["ProductTitleComboBox" + j.ToString()]).SelectedValue.ToString(), out ProductId);
                bool result2 = decimal.TryParse(((TextBox)PricePanel.Controls["PricePerItemTxt" + j.ToString()]).Text, out PricePerItem);
                bool result3 = Int32.TryParse(((TextBox)NoOfItemsPanel.Controls["NoOfItemsTxt" + j.ToString()]).Text, out NoOfItems);
                bool result4 = decimal.TryParse(((TextBox)SubtotalPanel.Controls["SubtotalTxt" + j.ToString()]).Text, out Subtotal);

               // ProductTitlePanel.Controls.Remove((ComboBox)ProductTitlePanel.Controls["ProductTitleComboBox" + j.ToString()]);
                // NoOfItemsPanel.Controls.Remove((TextBox)NoOfItemsPanel.Controls["NoOfItemsTxt" + j.ToString()]);


                if (result)
                {

                    //ComboBox1.SelectedValueChanged -= new System.EventHandler(ProductTitle_SelectedValueChanged);
                    //textBox3.TextChanged += new System.EventHandler(NoOfItems_TextChanged);
                    ((ComboBox)ProductTitlePanel.Controls["ProductTitleComboBox" + j.ToString()]).SelectedValue = 0;
                    ((TextBox)PricePanel.Controls["PricePerItemTxt" + j.ToString()]).Text = "0";
                    ((TextBox)NoOfItemsPanel.Controls["NoOfItemsTxt" + j.ToString()]).Text = "0";
                    ((TextBox)SubtotalPanel.Controls["SubtotalTxt" + j.ToString()]).Text = "0";
                }
            }*/

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Product Title", new Font("Georgia",14, FontStyle.Bold), Brushes.Black, 50, 50);
            e.Graphics.DrawString("Unit Price", new Font("Georgia", 14, FontStyle.Bold), Brushes.Black, 300, 50);
            e.Graphics.DrawString("Quantity", new Font("Georgia", 14, FontStyle.Bold), Brushes.Black, 500, 50);
            e.Graphics.DrawString("Subtotal", new Font("Georgia", 14, FontStyle.Bold), Brushes.Black, 700, 50);

            string ProductTitle;
            decimal PricePerItem;
            int NoOfItems;
            decimal Subtotal;
            decimal Total = 0;
            int yPos = 100;
            
            for (int j = 1; j < CountR; j++)
            { 
                ProductTitle = ((ComboBox)ProductTitlePanel.Controls["ProductTitleComboBox" + j.ToString()]).Text;
                bool result2 = decimal.TryParse(((TextBox)PricePanel.Controls["PricePerItemTxt" + j.ToString()]).Text, out PricePerItem);
                bool result3 = Int32.TryParse(((TextBox)NoOfItemsPanel.Controls["NoOfItemsTxt" + j.ToString()]).Text, out NoOfItems);
                bool result4 = decimal.TryParse(((TextBox)SubtotalPanel.Controls["SubtotalTxt" + j.ToString()]).Text, out Subtotal);
                //MessageBox.Show(ProductTitle);
                if (ProductTitle != "")
                {
                    e.Graphics.DrawString(ProductTitle, new Font("Georgia", 10, FontStyle.Bold), Brushes.Black, 50, yPos);
                    e.Graphics.DrawString(PricePerItem.ToString() , new Font("Georgia", 10, FontStyle.Bold), Brushes.Black, 300, yPos);
                    e.Graphics.DrawString(NoOfItems.ToString(), new Font("Georgia", 10, FontStyle.Bold), Brushes.Black, 500, yPos);
                    e.Graphics.DrawString(Subtotal.ToString(), new Font("Georgia", 10, FontStyle.Bold), Brushes.Black, 700, yPos);
                    Total += Subtotal;
                    yPos = yPos + 50;
                }
            }
            decimal Total2 = Convert.ToDecimal("12.3400");
            e.Graphics.DrawString("Total:", new Font("Georgia", 14, FontStyle.Bold), Brushes.Black, 60, yPos);
            e.Graphics.DrawString(Total2.ToString("0.##"), new Font("Georgia", 14, FontStyle.Bold), Brushes.Black, 300, yPos);

            yPos = yPos + 50;
            DateTime OrderDate = DateTime.Now;
            e.Graphics.DrawString("Date:", new Font("Georgia", 14, FontStyle.Bold), Brushes.Black, 60, yPos);
            e.Graphics.DrawString(OrderDate.ToString("dd MMMM, yyyy H:mm:ss"), new Font("Georgia", 14, FontStyle.Bold), Brushes.Black, 300, yPos);
            yPos = yPos + 50;
            e.Graphics.DrawString("Billed By:", new Font("Georgia", 14, FontStyle.Bold), Brushes.Black, 60, yPos);
            e.Graphics.DrawString(Properties.Settings.Default.Username, new Font("Georgia", 14, FontStyle.Bold), Brushes.Black, 300, yPos);

        }

        private void PrintPreviewBtn_Click(object sender, EventArgs e)
        {
            InvoicePrintPreviewDialog.Document = InvoicePrintDocument;
            InvoicePrintPreviewDialog.ShowDialog();
        }
    }
}
