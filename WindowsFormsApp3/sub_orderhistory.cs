using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class sub_orderhistory : KryptonForm
    {
        public sub_orderhistory()
        {
            InitializeComponent();
        }

        private void sub_orderhistory_Load(object sender, EventArgs e)
        {
            runorderDetailstable();
        }

        void runorderDetailstable()
        {
            //select

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Apictures_IM_DB.mdf;Integrated Security=True;Connect Timeout=30");
            string protbquery = "SELECT * FROM Order_Details";


            try
            {
                con.Open();
                SqlDataAdapter ptd = new SqlDataAdapter(protbquery, con);
                SqlCommandBuilder buildprotb = new SqlCommandBuilder(ptd);
                var ptdset = new DataSet();
                ptd.Fill(ptdset);
                viewOrderDataGV.DataSource = ptdset.Tables[0];
                con.Close();

            }
            catch
            {

            }
        }



        private void viewOrderDataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
