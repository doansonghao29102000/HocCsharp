using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapTrinhWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHoLot_Click(object sender, EventArgs e)
        {
            lbHoLot.Text = txtHoLot.Text;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lbTen.Text = txtTen.Text;
        }

        private void btnHoVaTen_Click(object sender, EventArgs e)
        {
            lbHoVaTen.Text = txtHoLot.Text + " " +
                txtTen.Text;
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHoLot_KeyDown(object sender, KeyEventArgs e)
        {
            lbHoLot.Text = txtHoLot.Text;
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            lbTen.Text = txtTen.Text;
        }
    }
}
