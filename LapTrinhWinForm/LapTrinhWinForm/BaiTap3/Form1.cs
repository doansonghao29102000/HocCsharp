using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdCloudy.Checked = true;
            picCloudy.Visible = true;
            picRainy.Visible = false;
            picSnowy.Visible = false;
            picSunny.Visible = false;
        }

        private void rdCloudy_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCloudy.Checked)
            {
                picCloudy.Visible = true;
                picRainy.Visible = false;
                picSnowy.Visible = false;
                picSunny.Visible = false;
            }
        }

        private void rdRainy_CheckedChanged(object sender, EventArgs e)
        {
            if (rdRainy.Checked)
            {
                picCloudy.Visible = false;
                picRainy.Visible = true;
                picSnowy.Visible = false;
                picSunny.Visible = false;
            }
        }

        private void rdSnowy_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSnowy.Checked)
            {
                picCloudy.Visible = false;
                picRainy.Visible = false;
                picSnowy.Visible = true;
                picSunny.Visible = false;
            }
        }

        private void rdSunny_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSunny.Checked)
            {
                picCloudy.Visible = false;
                picRainy.Visible = false;
                picSnowy.Visible = false;
                picSunny.Visible = true;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string ms = "";
            if (rdCloudy.Checked)
                ms = " có nhiều mây ";
            else if (rdRainy.Checked)
                ms = " có mưa ";
            else if (rdSunny.Checked)
                ms = " có nắng  ";
            else
                ms = " có tuyết rơi";


            lbDisplay.Text = " Xin chào " +
                txtHoTen.Text + "\n" +
                " hôm nay trời " + ms;
        }
    }
}
