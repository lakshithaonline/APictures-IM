using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;
namespace WindowsFormsApp3

{
    public partial class Dashboard : KryptonForm
    {
        public Dashboard(string ulg)
        {
            InitializeComponent();

            bunifuLabel3.Text = ulg;
        }
        public Dashboard()
        {
            InitializeComponent();

        
        }



        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Apictures_IM_DB.mdf;Integrated Security=True;Connect Timeout=30");
        public void loadform(object form)
        {
            if (this.bunifuPanel5.Controls.Count > 0)
                this.bunifuPanel5.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.bunifuPanel5.Controls.Add(f);
            this.bunifuPanel5.Tag = f;
            f.Show();




        }

        private void Navi_Load(object sender, EventArgs e)
        {

        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {/*
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Apictures_IM_DB.mdf;Integrated Security=True;Connect Timeout=30");
            string usertbquery2 = "SELECT Uname FROM Users ";

            Session["Uname"] = bunifuLabel3.Text;
            Viewstate["Online"] = txtusername.Text;
            Response.Write(Session["Uname"].ToString());
            Response.Write(Session["Username"].ToString())
            */
            /*
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from Users where Uname = '" + unametype1.Text + "' and Password = '" + password.Text + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Dashboard dash = new Dashboard();
                dash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
            con.Close();
            */
           /* con.Open();
            SqlDataAdapter cod2 = new SqlDataAdapter("select Uname from Users", con);
            DataTable at2 = new DataTable();
            cod2.Fill(at2);
            bunifuLabel3.Text = at2.Rows[0][0].ToString();
            con.Close();
           */
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            loadform(new sub_settings());
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void bunifuPanel5_Click(object sender, EventArgs e)
        {
           // sub_dashboard objForm = sub_dashboard.InstanceForm();
            //objForm.TopLevel = false;
            //Dashboard.Controls.Add(objForm);
            //objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //objForm.Dock = DockStyle.Fill;
            //objForm.Show(); loadform(new sub_dashboard());
        }

        private void bunifuPanel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_dash_Click_1(object sender, EventArgs e)
        {
            loadform(new sub_dashboard());
        }

        private void Category_dash_Click_1(object sender, EventArgs e)
        {
            loadform(new sub_category());
        }

        private void Products_dash_Click(object sender, EventArgs e)
        {
            loadform(new sub_products());
        }

        private void Customer_dash_Click(object sender, EventArgs e)
        {
            loadform(new sub_customer());
        }

        private void Order_dash_Click(object sender, EventArgs e)
        {
            loadform(new sub_order());
        }

        private void OrderHistory_dash_Click(object sender, EventArgs e)
        {
            loadform(new sub_orderhistory());
        }

        private void dashboard_UC1_Load(object sender, EventArgs e)
        {

        }

        private void dashboard_UC1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
