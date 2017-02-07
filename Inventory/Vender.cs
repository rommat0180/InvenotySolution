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
    public partial class Vender : Form
    {
        SqlDataAdapter sda;
        DataTable dt;
        // SqlCommandBuilder scb;
        public static string connstr = ConfigurationManager.ConnectionStrings["inventorysolution"].ConnectionString;
        SqlConnection Conn = new SqlConnection(connstr);
        public Vender()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (VenderName.Text != "")
            {
                Conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT Into Venders (Name) VALUES ('" + VenderName.Text + "')");
                cmd.Connection = Conn;
                cmd.ExecuteNonQuery();
                Conn.Close();
                VenderName.Text = "";
                this.ReadToGrid();
            }
        }

        private void Vender_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Venders' table. You can move, or remove it, as needed.
            //this.vendersTableAdapter.Fill(this.DataSet1.Venders);

            ReadToGrid();
        }
        private void ReadToGrid()
        {
           /* using (SqlCommand command = new SqlCommand("select * from Venders", Conn))
            {
                Conn.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt;
                }
                Conn.Close();
            }*/
            sda = new SqlDataAdapter("select * from Venders", Conn);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void UpdateVenders_Click(object sender, EventArgs e)
        {
            
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }
    }
}
