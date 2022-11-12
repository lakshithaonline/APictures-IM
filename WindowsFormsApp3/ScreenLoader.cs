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

namespace WindowsFormsApp3
{
    public partial class ScreenLoader : KryptonForm
    {
        public ScreenLoader()
        {
            InitializeComponent();
        }

        private void bunifuPanel3_Click(object sender, EventArgs e)
        {

        }

        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;

            
            progressbar.Value = startpoint;
            if (progressbar.Value == 100)
            {
                progressbar.Value = 0;
                timer1.Stop();
                Login log = new Login();
                this.Hide();
                log.Show();

            }


        }

        private void ScreenLoader_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void bunifuProgressBar1_ProgressChanged(object sender, Bunifu.UI.WinForms.BunifuProgressBar.ProgressChangedEventArgs e)
        {

        }

        private void progressbar_ProgressChanged(object sender, Bunifu.UI.WinForms.BunifuCircleProgress.ProgressChangedEventArgs e)
        {

        }
    }
}
