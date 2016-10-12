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
    public partial class FrmSuaKH : Form
    {
        public FrmSuaKH(int idkh, string ten, string ma, string dc, string sotk, string dt)
        {
            InitializeComponent();
            id = idkh;
            tenkh = ten;
            masothue = ma;
            diachi = dc;
            sotaikhoan = sotk;
            dienthoai = dt;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không", "Close", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
           e.Cancel = true;
        }
        KhachHang kh = new KhachHang();
        private void button2_Click(object sender, EventArgs e)
        {
            if (txttendonvi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đơn vị!", "Có lỗi xảy ra", MessageBoxButtons.OK);
            }

            else 
            if ((txtnguoimuahang.Text.Length > 14 || txtnguoimuahang.Text.Length < 10) && txtnguoimuahang.Text.Length > 0)
            {
                MessageBox.Show("Mã số thuế phải từ 10 - 14 ký tự!", "Có lỗi xảy ra", MessageBoxButtons.OK);
            }
            else
            if(txttendonvi.Text != "")
            {
                kh.capnhatkhachhang(int.Parse(txtkhachhang.Text), txttendonvi.Text, txtnguoimuahang.Text, txtmasothue.Text, txtdiachi.Text, txtsotaikhoan.Text);
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtsotaikhoan_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtdiachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmasothue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnguoimuahang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttendonvi_TextChanged(object sender, EventArgs e)
        {

        }
        public int id { get; set; }
        public string tenkh { get; set; }

        public string masothue { get; set; }
        public string diachi { get; set; }
        public string sotaikhoan { get; set; }
        public string dienthoai { get; set; }
        private void FrmSuaKH_Load(object sender, EventArgs e)
        {
            txttendonvi.Focus();
            // string kh = "Select * from KHACHHANG where IDKH = '" + id + "'";
            txtkhachhang.Text = id.ToString();
            txttendonvi.Text = tenkh.ToString();
            txtnguoimuahang.Text = masothue.ToString();
           
            txtmasothue.Text = diachi.ToString();
            txtdiachi.Text = sotaikhoan.ToString();
          txtsotaikhoan.Text = dienthoai.ToString();

        }

        private void keypressmasothue(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void keypresssodienthoai(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }   
        }

        private void keypresssotaikhoan(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
