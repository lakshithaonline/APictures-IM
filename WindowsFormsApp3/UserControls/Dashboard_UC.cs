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
        }

        private void Dashboard_UC_Load(object sender, EventArgs e)
        {

        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
