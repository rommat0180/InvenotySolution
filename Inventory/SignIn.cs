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
    public partial class SignIn : Form
    {
        public static string connstr = ConfigurationManager.ConnectionStrings["inventorysolution"].ConnectionString;
        SqlConnection Conn = new SqlConnection(connstr);
        InventoryParent TheParent;
        public SignIn(InventoryParent ParentForm)
        {
            InitializeComponent();
            TheParent = ParentForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from Users WHERE Username='"+ UsernameTxt.Text+ "' AND Password='"+PasswordTxt.Text+"'", Conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            if(dt.Rows.Count > 0)
            {
                Properties.Settings.Default.UserId = Int32.Parse(dt.Rows[0]["Id"].ToString());
                Properties.Settings.Default.Username = dt.Rows[0]["Username"].ToString();
                Home IPF = new Home(TheParent);
                IPF.MdiParent = TheParent;
                IPF.Show();
                TheParent.MainMenuStrip.Visible = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usernaame or Paasword doesn't match");
            }
            //dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
