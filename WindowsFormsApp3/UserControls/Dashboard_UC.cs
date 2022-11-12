using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
namespace WindowsFormsApp3
{
    public partial class Dashboard_UC : UserControl
    {
       // [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn
            //(
          //  int nLeftRect,     // x-coordinate of upper-left corner
          //  int nTopRect,      // y-coordinate of upper-left corner
           // int nRightRect,    // x-coordinate of lower-right corner
            //int nBottomRect,   // y-coordinate of lower-right corner
            //int nWidthEllipse, // height of ellipse
            //int nHeightEllipse // width of ellipse
            //);
        public Dashboard_UC()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            countasetprgram();
            countasetprgram2();
            countasetprgram3();
            countasetprgram4();
            countasetprgram5();
          
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Apictures_IM_DB.mdf;Integrated Security=True;Connect Timeout=30");
        private void Dashboard_UC_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Apictures_IM_DB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select SUM(Pro_Quantity) from Products ", con);
            var coun1 = cmd.ExecuteScalar();
            bunifuciclebar5.Text = coun1.ToString();
            con.Close();

            con.Open();
            SqlCommand cmd1 = new SqlCommand("Select SUM(Total_Amount) from Order_Details ", con);
            var coun2 = cmd1.ExecuteScalar();
            revenuelabel2.Text = coun2.ToString();
            con.Close();
        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {
            countasetprgram();
        }
        private void customercount5_Click(object sender, EventArgs e)
        {
            countasetprgram2();
        }
        private void categorycount5_Click(object sender, EventArgs e)
        {
            countasetprgram3();
        }

        private void ordercount5_Click(object sender, EventArgs e)
        {
            countasetprgram4();
        }

        private void bunifuciclebar5_Click(object sender, EventArgs e)
        {
            countasetprgram5();

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
                productcount5.Text = dt.Rows.Count.ToString();
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
                customercount5.Text = dt1.Rows.Count.ToString();
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
               categorycount5.Text = dt.Rows.Count.ToString();
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
                ordercount5.Text = dt.Rows.Count.ToString();
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


       
    

        private void revenuelabel2_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuCircleProgress2_ProgressChanged(object sender, Bunifu.UI.WinForms.BunifuCircleProgress.ProgressChangedEventArgs e)
        {
            
        }
    }
}
