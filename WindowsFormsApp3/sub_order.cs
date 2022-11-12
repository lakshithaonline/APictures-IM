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
    public partial class sub_order : KryptonForm
    {
        public sub_order()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Apictures_IM_DB.mdf;Integrated Security=True;Connect Timeout=30");

        void rundatasetprgram()
        {
            //select
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         
            try
            {
                con.Open();
                string custtbquery = "SELECT * FROM Customers";
                SqlDataAdapter ctd = new SqlDataAdapter(custtbquery, con);
                SqlCommandBuilder buildcusttb = new SqlCommandBuilder(ctd);
                var ctdset = new DataSet();
                ctd.Fill(ctdset);
                customerviewDataGV.DataSource = ctdset.Tables[0];
                con.Close();

            }
            catch
            {

            }
        }

        void rundatasetprgram1()
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
                productviewDataGV.DataSource = ptdset.Tables[0];
                con.Close();

            }
            catch
            {

            }
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
                //product_category.ValueMember = "Category_Name";
                // product_category.DataSource = cdt;
                selectcategory.ValueMember = "Category_Name";
                selectcategory.DataSource = cdt;
                con.Close();
            }
            catch
            {

            }
        }

        int number=0;
        int itemqty;
        int itemprice;
        int totalprice;
        string product;

        DataTable dt = new DataTable();
        private void sub_order_Load(object sender, EventArgs e)
        {
            rundatasetprgram();
            rundatasetprgram1();
            flitercategory();
          

            dt.Columns.Add("Number", typeof(int));
            dt.Columns.Add("Product_Name", typeof(string));
            dt.Columns.Add("Product_Qty", typeof(int));
            dt.Columns.Add("Unit_Price", typeof(int));
            dt.Columns.Add("Total_Price", typeof(int));
          
            addorderDataGV.DataSource = dt;
     
        }

        private void customerviewDataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cust_id_for_order.Text = customerviewDataGV.SelectedRows[0].Cells[0].Value.ToString();

            cust_name_for_order.Text = customerviewDataGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void selectcategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string catesearchquery = "select * from Products where Pro_Category= '" + selectcategory.SelectedValue.ToString() + "' ";
                SqlDataAdapter ptd = new SqlDataAdapter(catesearchquery, con);
                SqlCommandBuilder buildprotb = new SqlCommandBuilder(ptd);
                var ptdset = new DataSet();
                ptd.Fill(ptdset);
                productviewDataGV.DataSource = ptdset.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }

        
        int checkstock;
        void updateproductstock()
        {
          
            int id = Convert.ToInt32(productviewDataGV.SelectedRows[0].Cells[0].Value.ToString());
            int newproQty = checkstock - Convert.ToInt32(product_quantity1.Text);
            if (newproQty < 0)
            {
                MessageBox.Show("Inventry Manage Operation Failed!");
            }
            else
            {
                con.Open();
                string stockquery = "UPDATE Products set Pro_Quantity = " + newproQty + " where Product_Id = " + id + ";  ";
                SqlCommand cmd = new SqlCommand(stockquery, con);
                cmd.ExecuteNonQuery();
                con.Close();
                rundatasetprgram1();

            }
            

        }

        int flag = 0;
        private void productviewDataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // product = productviewDataGV.SelectedRows[0].Cells[1].Value.ToString();
            // itemprice = Convert.ToInt32(productviewDataGV.SelectedRows[0].Cells[2].Value.ToString());
            // itemprice = Convert.ToInt32(productviewDataGV.Rows[0].Cells[3].ToString());
            //product= productviewDataGV.SelectedRows[0].Cells["Pro_Name"].Value.ToString();
            // item_qty = Convert.ToInt32(product_quantity1.Text);
            //  itemprice = Convert.ToInt32(productviewDataGV.SelectedRows[0].Cells["Pro_Price"].Value.ToString());
            // totalprice = item_qty * itemprice;
            /*
            textBox1.Text = productviewDataGV.SelectedRows[0].Cells[0].Value.ToString();
           product = productviewDataGV.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = productviewDataGV.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = productviewDataGV.SelectedRows[0].Cells[3].Value.ToString();
           textBox5.Text = productviewDataGV.SelectedRows[0].Cells[4].Value.ToString();
            */

            product = productviewDataGV.SelectedRows[0].Cells[1].Value.ToString();
            //itemqty = Convert.ToInt32(product_quantity1.Text);
            checkstock = Convert.ToInt32(productviewDataGV.SelectedRows[0].Cells[2].Value.ToString());
            itemprice = Convert.ToInt32(productviewDataGV.SelectedRows[0].Cells[3].Value.ToString());
  
           
            //totalprice = itemqty * itemprice;
            flag = 1;


        }

       int sum = 0;
        private void addqtybutton1_Click(object sender, EventArgs e)
        {
            if (product_quantity1.Text == "")

                MessageBox.Show("Insert the Quantity Of Customer's Selected Products ");


            else if (flag == 0)

                MessageBox.Show("Select the Product");
            else if (Convert.ToInt32(product_quantity1.Text) > checkstock)
                MessageBox.Show("Out of Stock!");

            else
            {

                number = number + 1;
                itemqty = Convert.ToInt32(product_quantity1.Text);
                

               
                totalprice = itemqty * itemprice;

                // int i = 0;
                //while (i < 5)


                dt.Rows.Add(number, product, itemqty, itemprice, totalprice);
                addorderDataGV.DataSource = dt;
                flag = 0;

            }

            sum = sum + totalprice;
            totalamount.Text = " " + sum.ToString();
            updateproductstock();
        }
        private void Insertorderdetailsbutton1_Click(object sender, EventArgs e)
        {
            if (order_id_for_order.Text == "" || cust_id_for_order.Text=="" || cust_name_for_order.Text == "" || totalamount.Text=="" || orderdate_for_order.Text=="")
            {
                MessageBox.Show("Fill The Data Correctly!");
            }
            else
            {
                int order_id = int.Parse(order_id_for_order.Text);
                int customers_id = int.Parse(cust_id_for_order.Text);
                string customer_name = cust_name_for_order.Text;
               DateTime orderdate = DateTime.Parse(orderdate_for_order.Text);
                string totalamounts1 = totalamount.Text;
                Int32.TryParse(totalamounts1, out int result);

               /* 
                int totalamounts1 = 0;
                int.TryParse(totalamount.Text, out totalamounts1);
               */

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Apictures_IM_DB.mdf;Integrated Security=True;Connect Timeout=30");
                string query = "INSERT INTO Order_Details VALUES ('" + order_id + "','" + customers_id + "', '" +customer_name + "','" + orderdate + "', '" + totalamounts1 + "')";
                SqlCommand cmd = new SqlCommand(query, con); 

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Details Data Insert Sussessfully!");
                    rundatasetprgram();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton12_Click(object sender, EventArgs e)
        {

        }

       

        private void label6_Click(object sender, EventArgs e)
        {

        }

        
    }
}
