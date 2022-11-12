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
    public partial class sub_category : KryptonForm
    {
        public sub_category()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Apictures_IM_DB.mdf;Integrated Security=True;Connect Timeout=30");

        private void sub_category_Load(object sender, EventArgs e)
        {
            rundatasetprgram();
        }

        private void Category_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void categinsertbutton1_Click(object sender, EventArgs e)
        {

            int categid = int.Parse(categ_id.Text);
            string categname = categ_name.Text;
            string categdescription = categ_description.Text;
          

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Apictures_IM_DB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "INSERT INTO Category VALUES ('" + categid+ "','" + categname + "', '" + categdescription + "')";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Data Insert Sussessfully!");
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
            string categtbbquery = "SELECT * FROM Category";


            try
            {
                con.Open();
                SqlDataAdapter catd = new SqlDataAdapter(categtbbquery, con);
                SqlCommandBuilder buildcategtb = new SqlCommandBuilder(catd);
                var categdset = new DataSet();
                catd.Fill(categdset);
                categoryDataGv.DataSource = categdset.Tables[0];
                con.Close();

            }
            catch
            {

            }
        }
        private void bunifuDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            categ_id.Text = categoryDataGv.SelectedRows[0].Cells[0].Value.ToString();
            categ_name.Text = categoryDataGv.SelectedRows[0].Cells[1].Value.ToString();
            categ_description.Text = categoryDataGv.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void categdeletebutton2_Click(object sender, EventArgs e)
        {
            //delete
            if (categ_id.Text == "")
            {
                MessageBox.Show("Enter your Details!");
            }
            else
            {
                con.Open();
                string deletequery = "DELETE FROM Category WHERE Category_ID= '" + categ_id.Text+ "' ";
                SqlCommand cmd = new SqlCommand(deletequery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Details Delete Successfully!");
                con.Close();
                rundatasetprgram();

            }
        }

        private void categupdatebutton3_Click(object sender, EventArgs e)
        {
            string updatequery = "UPDATE Category SET Category_Name='" + categ_name.Text + "',Category_Description='" + categ_description.Text + "' where Category_ID= '" + categ_id.Text + "' ";
            SqlCommand cmd = new SqlCommand(updatequery, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Data Update Sussessfully!");
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
