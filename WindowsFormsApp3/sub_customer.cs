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
    public partial class sub_customer : KryptonForm
    {
        public sub_customer()
        {
            InitializeComponent();
        }

        private void sub_customer_Load(object sender, EventArgs e)
        {
            rundatasetprgram();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Apictures_IM_DB.mdf;Integrated Security=True;Connect Timeout=30");

        private void cust_insertbutoon1_Click(object sender, EventArgs e)
        {
            int custid = int.Parse(cust_id.Text);
            string custname = cust_name.Text;
            int custpno= int.Parse(cust_pno.Text);
            string custemail = cust_email.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Apictures_IM_DB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "INSERT INTO Customers VALUES ('" + custid+ "','" + custname + "', '" + custpno + "','" + custemail + "')";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer's Data Insert Sussessfully!");
                rundatasetprgram();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void rundatasetprgram()
        {
            //select

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Apictures_IM_DB.mdf;Integrated Security=True;Connect Timeout=30");
            string custtbquery = "SELECT * FROM Customers";


            try
            {
                con.Open();
                SqlDataAdapter ctd = new SqlDataAdapter(custtbquery, con);
                SqlCommandBuilder buildcusttb= new SqlCommandBuilder(ctd);
                var ctdset = new DataSet();
                ctd.Fill(ctdset);
                customerDataGv.DataSource = ctdset.Tables[0];
                con.Close();

            }
            catch
            {

            }
        }


        private void customerDataGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cust_id.Text= customerDataGv.SelectedRows[0].Cells[0].Value.ToString();
            cust_name.Text = customerDataGv.SelectedRows[0].Cells[1].Value.ToString();
            cust_pno.Text = customerDataGv.SelectedRows[0].Cells[2].Value.ToString();
            cust_email.Text = customerDataGv.SelectedRows[0].Cells[3].Value.ToString();

            con.Open();
            //order Count
            SqlDataAdapter cod = new SqlDataAdapter("select Count(*) from Order_Details where Customer_Id= " + cust_id.Text + "", con);
            DataTable dt = new DataTable();
            cod.Fill(dt);
            ordercountlabel6.Text = dt.Rows[0][0].ToString();

            //Total Amount
            SqlDataAdapter cod1 = new SqlDataAdapter("select Total_Amount from Order_Details where Customer_Id= " + cust_id.Text + "", con);
            DataTable at1 = new DataTable();
            cod1.Fill(at1);
           
            orderamountabel7.Text = at1.Rows[0][0].ToString();

            SqlDataAdapter cod2 = new SqlDataAdapter("select MAX(Order_Date) from Order_Details where Customer_Id= " + cust_id.Text + "", con);
            DataTable at2 = new DataTable();
            cod2.Fill(at2);
            orderlastdatetabel8.Text = at2.Rows[0][0].ToString();
            con.Close();

        }

        private void cust_deletebutton2_Click(object sender, EventArgs e)
        {
            //delete
            if (cust_id.Text == "")
            {
                MessageBox.Show("Enter your Details!");
            }
            else
            {
                con.Open();
                string deletequery = "DELETE FROM Customers WHERE Customer_Id= '" + cust_id.Text + "' ";
                SqlCommand cmd = new SqlCommand(deletequery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Details Delete Successfully!");
                con.Close();
                rundatasetprgram();

            }
        }

        private void cust_updatebutton3_Click(object sender, EventArgs e)
        {
            string updatequery = "UPDATE Customers SET Customer_Name='" + cust_name.Text + "',Customer_Pho_Num='" + cust_pno.Text + "', Customer_Email= '" + cust_email.Text + "' where Customer_Id= '" + cust_id.Text + "' ";
            SqlCommand cmd = new SqlCommand(updatequery, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer's Data Update Sussessfully!");
                con.Close();
                rundatasetprgram();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
