using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenNgocHaiDuong_27_ThiCSharp
{
    public partial class dinhdang : Form
    {
        public dinhdang()
        {
            InitializeComponent();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            txtLapTrinh.ForeColor = Color.Red;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Định_dạng_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnhapten_TextChanged(object sender, EventArgs e)
        {
            txtLapTrinh.Text = txtNhapTen.Text;
        }

        private void radgreen_CheckedChanged(object sender, EventArgs e)
        {
            txtLapTrinh.ForeColor = Color.LimeGreen;
        }

        private void radblue_CheckedChanged(object sender, EventArgs e)
        {
            txtLapTrinh.ForeColor = Color.Blue;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            txtLapTrinh.Font = new Font(txtLapTrinh.Font.Name, txtLapTrinh.Font.Size, txtLapTrinh.Font.Style ^ FontStyle.Bold);
        }

        private void lbllaptrinh_Click(object sender, EventArgs e)
        {
            txtLapTrinh.ForeColor = Color.Black;
        }

        private void chkitalic_CheckedChanged(object sender, EventArgs e)
        {
            txtLapTrinh.Font = new Font(txtLapTrinh.Font.Name, txtLapTrinh.Font.Size, txtLapTrinh.Font.Style ^ FontStyle.Italic);
        }

        private void chkunderline_CheckedChanged(object sender, EventArgs e)
        {
            txtLapTrinh.Font = new Font(txtLapTrinh.Font.Name, txtLapTrinh.Font.Size, txtLapTrinh.Font.Style ^ FontStyle.Underline);
        }
    }
}
