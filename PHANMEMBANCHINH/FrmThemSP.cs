using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANMEMBANCHINH
{
    public partial class FrmThemSP : Form
    {
        public FrmThemSP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tenSanPhamTextBox.Text = "";
            donGiaTextBox.Text = "";
            donViTinhTextBox.Text = "";
            tenSanPhamTextBox.Focus();
        }
        SanPham sp = new SanPham();
        private void button2_Click(object sender, EventArgs e)
        {
            if (tenSanPhamTextBox.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên sản phẩm!", "Có lỗi xảy ra", MessageBoxButtons.OK);
            }
            else
            if (donGiaTextBox.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đơn giá!", "Có lỗi xảy ra", MessageBoxButtons.OK);
            }
            else
            if (donGiaTextBox.Text != "" && tenSanPhamTextBox.Text != "")
            {
                sp.themsanpham(tenSanPhamTextBox.Text, Convert.ToDecimal(donGiaTextBox.Text), donViTinhTextBox.Text);
                MessageBox.Show("Thêm mới thành công", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmThemSP_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn thoát không", "Close", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void FrmThemSP_Load(object sender, EventArgs e)
        {
            tenSanPhamTextBox.Focus();
        }

        private void keypressdongia(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
