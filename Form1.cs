using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace NguyenNgocHaiDuong_27_ThiCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string HoTenSV = "Nguyen Ngoc Hai Duong";
            string MSSV = "01223360136";
            string Monthi = "Lập Trình Windows 2 C#";

            lblInfor.Text = "Họ và Tên: " + HoTenSV;
            lblInfor.Text += "\nMSSV" + MSSV;
            lblInfor.Text += "\nMonThi" + Monthi;
            lblInfor.Text += "\nTime" + System.DateTime.Now.ToString();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void giảiPhươngTrìnhBậc2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            giaiphuongtrinhbac2 gptb2 = new giaiphuongtrinhbac2();
            gptb2.Show();
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dinhdang dd = new dinhdang();
            dd.Show();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("chương trình tiện ích", "Thông tin");
        }
    }
}
