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
    public partial class sub_settings : KryptonForm
    {
        public sub_settings()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Apictures_IM_DB.mdf;Integrated Security=True;Connect Timeout=30");

        private void sub_settings_Load(object sender, EventArgs e)
        {
            rundatasetprgram();
        }



        private void insertbutton1_Click(object sender, EventArgs e)

        {
            string Uname = uname.Text;
            string Email = email.Text;
            string Password = password.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Apictures_IM_DB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "INSERT INTO Users VALUES ('" + Uname + "','" + Email + "', '" + Password + "')";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User's Data Insert Sussessfully!");
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
            string usertbquery = "SELECT * FROM Users"; 
           

            try
            {
                con.Open();
                SqlDataAdapter utd = new SqlDataAdapter(usertbquery, con);
                SqlCommandBuilder buildusertb = new SqlCommandBuilder(utd);
                var utdset = new DataSet();
                utd.Fill(utdset);

                userdataGridView.DataSource = utdset.Tables[0];
                con.Close();

            }
            catch
            {
                
            }
        }

        private void deletebutton2_Click(object sender, EventArgs e)
        {
            //delete
            if (uname.Text == "")
            {
                MessageBox.Show("Enter your Details!");
            }
            else
            {
                con.Open();
                string deletequery = "DELETE FROM Users WHERE Uname= '"+ uname.Text + "' ";
                SqlCommand cmd = new SqlCommand(deletequery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Details Delete Successfully!");
                con.Close();
                rundatasetprgram();

            }

        }

        private void userdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //read
            uname.Text = userdataGridView.SelectedRows[0].Cells[0].Value.ToString();
           email.Text = userdataGridView.SelectedRows[0].Cells[1].Value.ToString();
            password.Text = userdataGridView.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void updatebutton3_Click(object sender, EventArgs e)
        {
           

            string updatequery = "UPDATE Users SET  Email='" + email.Text + "',Password= '" + password.Text+ "' where Uname= '" + uname.Text + "' ";
            SqlCommand cmd = new SqlCommand(updatequery, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User's Data Update Sussessfully!");
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
