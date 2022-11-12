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
using FsCheck.Experimental;

namespace WindowsFormsApp3
{
    public partial class sub_dashboard : KryptonForm
    {
        public sub_dashboard()
        {
            InitializeComponent();
            countasetprgram();
            countasetprgram2();
            countasetprgram3();
            countasetprgram4();
            countasetprgram5();


        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Apictures_IM_DB.mdf;Integrated Security=True;Connect Timeout=30");
        private void sub_dashboard_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Apictures_IM_DB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select SUM(Pro_Quantity) from Products ", con);
            var coun1 = cmd.ExecuteScalar();
            progresslabel1.Text = coun1.ToString();
            con.Close();

            con.Open();
            SqlCommand cmd1 = new SqlCommand("Select SUM(Total_Amount) from Order_Details ", con);
            var coun2 = cmd1.ExecuteScalar();
            revenuelabel.Text = coun2.ToString();
            con.Close();
        }

        private void dashboard_lbl_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuPictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuPanel8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox5_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel18_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel22_Click(object sender, EventArgs e)
        {


        }

        private void bunifuLabel23_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel13_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void Category_dash_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {

        }

        private void bunifuPanel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel7_Click(object sender, EventArgs e)
        {

        }

        internal static sub_dashboard InstanceForm()
        {
            throw new NotImplementedException();
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }
       // int prductid = int.Parse(label1.Text);
        private void label1_Click(object sender, EventArgs e)
        {

           countasetprgram();
            //label1.Text = customerDataGv.SelectedRows[0].Cells[0].Value.ToString();


            //order Count
            /* con.Open();
             SqlDataAdapter cod = new SqlDataAdapter("select Count(*) from Products where Product_Id= " + label1.Text + "", con);
             DataTable dt = new DataTable();
             cod.Fill(dt);
             label1.Text = dt.Rows[0][0].ToString();

             con.Close();
            */
            /*
             con.Open();
             string ActiveProducts = "SELECT Count (*) FROM Products WHERE Product_Id='" + "pro_id" + "'";
             SqlCommand cmd = new SqlCommand(ActiveProducts, con);
             SqlDataAdapter sda = new SqlDataAdapter(cmd);
             DataSet ds = new DataSet();
             sda.Fill(ds);
             con.Close();

             label1.Text = ds.Tables[0].Rows.Count.ToString();
            */
            /*
            string stmt = "SELECT COUNT(*) FROM Products where Product_Id;
            int count = 0;

          
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, con))
                {
                    con.Open();
                    count = (int)cmdCount.ExecuteScalar();
                    SqlCommand cmd = new SqlCommand(stmt, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    label1.Text = ds.Tables[0].Rows.Count.ToString();
                    con.Close();
                }
            }
      */
            /*
            public static int GetTableCount(string Products, string connStr = null)
            {
                string stmt = string.Format("SELECT COUNT(*) FROM {0}", Products);
                if (String.IsNullOrEmpty(connStr))
                    connStr = ConnectionString;
                int count = 0;
                try
                {

                    using (SqlConnection thisConnection = new SqlConnection(connStr))
                    {
                        using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                        {
                            thisConnection.Open();
                            count = (int)cmdCount.ExecuteScalar();
                        }
                    }
                    return count;
                }
                catch (Exception ex)
                {
                    VDBLogger.LogError(ex);
                    return 0;
                }
            }
            */

            /*String lsSqlStr = "Select Count(Product_Id) From Products"
           SqlCommand lObjCmd = New SqlCommand(lsSqlStr, con);
             // con defines the connection string

            SqlDataReader lObjDr = New  SqlDataReader();
            lObjDr = lObjCmd.ExecuteReader();

            // Open DataReader to Read the Data
            lObjDr.Read();

            int lsCountVal = Convert.ToInt32(lObjDr[0].ToString());

            // Close DataReader
            lObjDr.Close();
            lObjDr.Dispose();

            // Close Connection
            con.Close();
            con Dispose();
            */


        }
        void countasetprgram()
        {
            //select

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Apictures_IM_DB.mdf;Integrated Security=True;Connect Timeout=30");
            string custtbquery = "SELECT * FROM Products";


            try
            {
                con.Open();
                SqlDataAdapter ctd = new SqlDataAdapter(custtbquery, con);
                SqlCommandBuilder buildcusttb = new SqlCommandBuilder(ctd);
                DataTable dt = new DataTable();
                var ctdset = new DataSet();
                ctd.Fill(dt);
                label1.Text = dt.Rows.Count.ToString();
                con.Close(); 

            }
            catch
            {

            }
        }

        void countasetprgram2()
        {
            //select

            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Apictures_IM_DB.mdf;Integrated Security=True;Connect Timeout=30");
            string custtbquery1 = "SELECT * FROM Customers";


            try
            {
                con1.Open();
                SqlDataAdapter ctd1 = new SqlDataAdapter(custtbquery1, con1);
                SqlCommandBuilder buildcusttb1 = new SqlCommandBuilder(ctd1);
                DataTable dt1 = new DataTable();
                var ctdset1 = new DataSet();
                ctd1.Fill(dt1);
                label2.Text = dt1.Rows.Count.ToString();
                con1.Close();

            }
            catch
            {

            }
        }

        void countasetprgram3()
        {
            //select

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Apictures_IM_DB.mdf;Integrated Security=True;Connect Timeout=30");
            string custtbquery = "SELECT * FROM Category";


            try
            {
                con.Open();
                SqlDataAdapter ctd = new SqlDataAdapter(custtbquery, con);
                SqlCommandBuilder buildcusttb = new SqlCommandBuilder(ctd);
                DataTable dt = new DataTable();
                var ctdset = new DataSet();
                ctd.Fill(dt);
                label7.Text = dt.Rows.Count.ToString();
                con.Close();

            }
            catch
            {

            }
        }

        void countasetprgram4()
        {
            //select

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Apictures_IM_DB.mdf;Integrated Security=True;Connect Timeout=30");
            string custtbquery = "SELECT * FROM Order_Details";


            try
            {
                con.Open();
                SqlDataAdapter ctd = new SqlDataAdapter(custtbquery, con);
                SqlCommandBuilder buildcusttb = new SqlCommandBuilder(ctd);
                DataTable dt = new DataTable();
                var ctdset = new DataSet();
                ctd.Fill(dt);
                label8.Text = dt.Rows.Count.ToString();
                con.Close();

            }
            catch
            {

            }
        }



        void countasetprgram5()
         
        {
            
            //select

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Apictures_IM_DB.mdf;Integrated Security=True;Connect Timeout=30");
            string custtbquery = "SELECT SUM(Pro_Quantity) FROM Products";


            try
            {
             
                SqlDataAdapter ctd = new SqlDataAdapter(custtbquery, con);
                SqlCommandBuilder buildcusttb = new SqlCommandBuilder(ctd);
                DataTable dt = new DataTable();
                var ctdset = new DataSet();
                ctd.Fill(dt);
                

               // progresslabel1.Text = dt.Rows.Count.ToString();

               

            }
            catch
            {

            }
        }

        void countasetprgram6()

        {

            //select

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Apictures_IM_DB.mdf;Integrated Security=True;Connect Timeout=30");
            string custtbquery = "SELECT SUM (Pro_Quantity) FROM Products";


            try
            {

                SqlDataAdapter ctd = new SqlDataAdapter(custtbquery, con);
                SqlCommandBuilder buildcusttb = new SqlCommandBuilder(ctd);
                DataTable dt = new DataTable();
                var ctdset= new DataSet();
                ctd.Fill(dt);


               // progresslabel1.Text = dt.Rows.Count.ToString();



            }
            catch
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            countasetprgram2();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            countasetprgram3();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            countasetprgram4();
        }

        private void bunifuCircleProgressstock1_ProgressChanged(object sender, Bunifu.UI.WinForms.BunifuCircleProgress.ProgressChangedEventArgs e)
        {
            countasetprgram5();
        }

        private void progresslabel2_Click(object sender, EventArgs e)
        {
            countasetprgram6();
        }

        private void progresslabel1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void OrderHistory_dash_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void revenuelabel_Click(object sender, EventArgs e)
        {

        }

        private void Customer_dash_Click(object sender, EventArgs e)
        {

        }
    }
}
