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

namespace WindowsFormsApp3
{
    public partial class Dashboard : KryptonForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }
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
        {

        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            loadform(new sub_settings());
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
