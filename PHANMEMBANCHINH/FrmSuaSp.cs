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
    public partial class FrmSuaSp : Form
    {
        public FrmSuaSp( int id, string ten, int dg, string dvt)
        {
            InitializeComponent();
            idsp = id;
            tensp = ten;
            dongia = dg;
            donvitinh = dvt;
        }

        private void tenSanPhamLabel_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
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
                sp.capnhatsanpham(int.Parse(iDSPTextBox.Text), tenSanPhamTextBox.Text, int.Parse(donGiaTextBox.Text), donViTinhTextBox.Text);
                MessageBox.Show("Sửa thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmSuaSp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Close", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void dg(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public string donvitinh { get; set; }

        public int dongia { get; set; }

        public string tensp { get; set; }

        public int idsp { get; set; }

        private void FrmSuaSp_Load(object sender, EventArgs e)
        {
            tenSanPhamTextBox.Focus();
            iDSPTextBox.Text = idsp.ToString();
            donGiaTextBox.Text = dongia.ToString();
            tenSanPhamTextBox.Text = tensp.ToString();
            donViTinhTextBox.Text = donvitinh.ToString();
        }
    }
}
