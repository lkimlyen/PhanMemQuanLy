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
    public partial class FrmThemKH : Form
    {
       KhachHang nv = new KhachHang();
        DataBase db = new DataBase();
        public FrmThemKH()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            txtdiachi.Clear();
            txtmasothue.Clear();
            txtnguoimuahang.Clear();
            txtsotaikhoan.Clear();
            txttendonvi.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
           
        }

        private void FrmThemKH_Load(object sender, EventArgs e)
        {
            txttendonvi.Focus();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtdiachi.Clear();
            txtmasothue.Clear();
            txtnguoimuahang.Clear();
            txtsotaikhoan.Clear();
            txttendonvi.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            if(txttendonvi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đơn vị!","Có lỗi xảy ra", MessageBoxButtons.OK);
            }
           
            else if ((txtnguoimuahang.Text.Length > 14 || txtnguoimuahang.Text.Length < 10) && txtnguoimuahang.Text.Length > 0)
            {
                MessageBox.Show("Mã số thuế phải từ 10 - 14 ký tự!", "Có lỗi xảy ra", MessageBoxButtons.OK);
            }
            else
            if (txttendonvi.Text != "")
            {
                nv.themkhachhang(txttendonvi.Text, txtnguoimuahang.Text, txtmasothue.Text, txtdiachi.Text, txtsotaikhoan.Text);
                MessageBox.Show("Thêm mới thành công", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
        }

      

        private void formclosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Close", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void masothuekr(object sender, KeyPressEventArgs e)
        {
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtnguoimuahang_TextChanged(object sender, EventArgs e)
        {

        }

        private void keypresssotaikhoan(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }   
        }

        private void keypressdienthoai(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }   
        }

        private void txttendonvi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
