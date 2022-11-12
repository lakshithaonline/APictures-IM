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
    public partial class sub_products : KryptonForm
    {
        public sub_products()
        {
            InitializeComponent();
        }


        private void sub_products_Load(object sender, EventArgs e)
        {
            flitercategory();
            rundatasetprgram();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Apictures_IM_DB.mdf;Integrated Security=True;Connect Timeout=30");
        private void label7_Click(object sender, EventArgs e)
        {

        }
        void flitercategory()
        {
            string catefilterquery = "select * from Category";
            SqlCommand cmd = new SqlCommand(catefilterquery, con);
            SqlDataReader rfilcate;

            try
            {
                con.Open();
                DataTable cdt = new DataTable();
                cdt.Columns.Add("Category_Name", typeof(string));
                rfilcate = cmd.ExecuteReader();
                cdt.Load(rfilcate);
                product_category.ValueMember = "Category_Name";
                product_category.DataSource = cdt;
                categorydropdownsearchbar1.ValueMember = "Category_Name";
                categorydropdownsearchbar1.DataSource = cdt;
                con.Close();   
            }
            catch
            {
                
            }
        }


        void fliterseacrhcategory()
        {
            try
            {
                con.Open();
                string catesearchquery = "select * from Products where Pro_Category= '" + categorydropdownsearchbar1.SelectedValue.ToString() + "' ";
                SqlDataAdapter ptd = new SqlDataAdapter(catesearchquery, con);
                SqlCommandBuilder buildprotb = new SqlCommandBuilder(ptd);
                var ptdset = new DataSet();
                ptd.Fill(ptdset);
                bunifuDataGridView1.DataSource = ptdset.Tables[0];
                con.Close();
            }
            catch
            {
                
            }
        }

        private void productinsertbutton1_Click(object sender, EventArgs e)
        {

            int pro_id= int.Parse(product_id.Text);
            string pro_name= product_name.Text;
            int pro_qty = int.Parse(product_qty.Text);
            int pro_price= int.Parse(product_price.Text);
            string pro_category= product_category.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Apictures_IM_DB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "INSERT INTO Products VALUES ('" + pro_id + "','" +pro_name + "', '" +pro_qty+ "','" + pro_price + "', '" + pro_category + "')";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Data Insert Sussessfully!");
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
            string protbquery = "SELECT * FROM Products";


            try
            {
                con.Open();
                SqlDataAdapter ptd = new SqlDataAdapter(protbquery, con);
                SqlCommandBuilder buildprotb = new SqlCommandBuilder(ptd);
                var ptdset = new DataSet();
                ptd.Fill(ptdset);
                bunifuDataGridView1.DataSource = ptdset.Tables[0];
                con.Close();

            }
            catch
            {

            }
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            product_id.Text = bunifuDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            product_name.Text = bunifuDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            product_qty.Text = bunifuDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            product_price.Text = bunifuDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            product_category.Text = bunifuDataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void productdeletebutton2_Click(object sender, EventArgs e)
        {

            //delete
            if (product_id.Text == "")
            {
                MessageBox.Show("Enter your Details!");
            }
            else
            {
                con.Open();
                string deletequery = "DELETE FROM Products WHERE Product_Id= '" + product_id.Text + "' ";
                SqlCommand cmd = new SqlCommand(deletequery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Products Details Delete Successfully!");
                con.Close();
                rundatasetprgram();

            }
        }

        private void productupdatebutton3_Click(object sender, EventArgs e)
        {
            string updatequery = "UPDATE Products SET Pro_Name='" + product_name.Text + "',Pro_Quantity='" + product_qty.Text + "', Pro_Price= '" + product_price.Text + "', Pro_Category= '" + product_category.Text + "' where Product_Id= '" + product_id.Text + "' ";
            SqlCommand cmd = new SqlCommand(updatequery, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Products Data Update Sussessfully!");
                con.Close();
                rundatasetprgram();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void productsearchbutton1_Click(object sender, EventArgs e)
        {
            fliterseacrhcategory();
            
        }

        private void refreshbutton1_Click(object sender, EventArgs e)
        {
            rundatasetprgram();
        }
    }
}
