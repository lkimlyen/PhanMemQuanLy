using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANMEMBANCHINH
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConn;

        SqlCommand cm;
        SqlDataAdapter da;

        public Form1()
        {
            InitializeComponent();
        }
        KhachHang nv = new KhachHang();
        DataBase db = new DataBase();
        SanPham sp = new SanPham();
        private void button10_Click(object sender, EventArgs e)
        {
            FrmThemKH them = new FrmThemKH();
            them.ShowDialog();
        }
        void hienthikhachhang()
        {
            DataTable dt = nv.Laydskhachhang();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = listView1.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());

            }

            cbotendonvi.DataSource = dt;
            cbotendonvi.DisplayMember = "TenDonVi";
            cbotendonvi.ValueMember = "IDKH";
            cbotendonvi.Text = "Chọn khách hàng";
            txtmasothue.Text = "";
            txtsotaikhoan.Text = "";
            txtdiachi.Text = "";



        }

        void hienthisanpham()
        {
            DataTable dt = sp.Laydssanpham();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = listView2.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());

            }
            cbosanpham.DataSource = dt;
            cbosanpham.DisplayMember = "TenSanPham";
            cbosanpham.ValueMember = "IDSP";
            cbosanpham.Text = "Chọn sản phẩm";

            txtdongia.Text = "";
            txtdonvitinh.Text = "";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    nv.xoakhachhang(int.Parse(listView1.SelectedItems[0].SubItems[0].Text));
                    listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
                }
            }
            else
                MessageBox.Show("Bạn phải chọn khách hàng cần xóa", "Xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpngaylap.CustomFormat = "dd/MM/yyyy";
            panel1.Show();
            panel2.Hide();
            panel3.Hide();

            // TODO: This line of code loads data into the 'qUANLYBANHANGDataSet.HOADON' table. You can move, or remove it, as needed.
            this.hoadonTableAdapter1.Fill(this.qUANLYBANHANGDataSet.HOADON);
            hienthikhachhang();
            hienthisanpham();
            cbothanhtoan.Items.Add("Tiền mặt");
            cbothanhtoan.Items.Add("Chuyển khoản");
            cbothanhtoan.Items.Add("TM/CK");
            cbothanhtoan.SelectedIndex = 0;
            listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            dataGridView2.AutoResizeColumns();
            matutanghddv();
            label16.Hide();

            label14.Hide();
            label15.Hide();
            label17.Hide();

            label18.Hide();
            label19.Hide();
            label20.Hide();
            label21.Hide();
            label22.Hide();
            label23.Hide();
            label24.Hide();
            label25.Hide();
            label26.Hide();
            label27.Hide();
            label28.Hide();
            hienthitinhtien();
            btninhoadon.Enabled = false;
            btnluu.Enabled = false;
        }


        private void button14_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            hienthikhachhang();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            FrmThemSP them = new FrmThemSP();
            them.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }
        public void hienthitinhtien()
        {
            if (txtdongia.Text == "")
            {
                btntinhtien.Enabled = false;
            }
            else
                btntinhtien.Enabled = true;
        }
        private void comselect(object sender, EventArgs e)
        {
            this.cbotendonvi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbotendonvi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;

            if (cbotendonvi.SelectedValue != null)
            {
                sqlConn = db.data();
                sqlConn.Open();
                cm = new SqlCommand("Select * from KHACHHANG where IDKH = '" + cbotendonvi.SelectedValue.ToString() + "'", sqlConn);
                //string  sql = "select NguoiMuaHang, DiaChi, MaSoThue, SoTaiKhoan  from KHACHHANG where TenDonVi = N'" +cbotendonvi.SelectedValue.ToString() + "'";
                SqlDataReader reader = cm.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    txtdiachi.Text = reader.GetString(3).ToString();
                    txtmasothue.Text = reader.GetString(2).ToString();


                    if (reader.IsDBNull(4))
                    {
                        txtsotaikhoan.Text = "";
                    }
                    else
                    {
                        txtsotaikhoan.Text = reader.GetString(4).ToString();

                    }
                }
            }
        }

        private void saphamse(object sender, EventArgs e)
        {
            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");

            sqlConn = db.data();
            sqlConn.Open();
            cm = new SqlCommand("Select * from SANPHAM where IDSP = '" + cbosanpham.SelectedValue.ToString() + "'", sqlConn);
            SqlDataReader reader = cm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                //txtdongia.Text = string.Format("{0:#.##0,####}",Decimal.Parse(reader.GetValue(2).ToString()));
                txtdongia.Text = String.Format(info, "{0:c}", Decimal.Parse(reader.GetValue(2).ToString()));
                if (!reader.IsDBNull(3))
                    txtdonvitinh.Text = reader.GetString(3).ToString();
            }
        }



        private void button(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
            panel3.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Show();
            panel1.Hide();
            panel3.Hide();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        DataClasses1DataContext data = new DataClasses1DataContext();
        private void btnthemsp_Click(object sender, EventArgs e)
        {

            if (cbosanpham.Text == "Chọn sản phẩm")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                decimal soluong;

                if (!decimal.TryParse(numsoluong.Value.ToString(), out soluong))
                {
                    MessageBox.Show("Số lượng không hợp lệ");
                    return;
                }
                var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                MUAHANG hcm = dsmua.SingleOrDefault(p => p.IDSP == int.Parse(cbosanpham.SelectedValue.ToString()));
                if (hcm == null)
                {
                    if (dataGridView2.Rows.Count > 4)
                    {
                        MessageBox.Show("Một hóa đơn chỉ được 5 sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Decimal tongTienHienTai = Decimal.Parse(dsmua.Sum(p => p.SoLuong * p.DonGia).ToString());
                        if (tongTienHienTai + Decimal.Parse(txtdongia.Text.Replace(".", "").Replace(",", ".").Replace("₫", "")) * numsoluong.Value > 2000000000)
                        {
                            MessageBox.Show("Đơn hàng quá lớn, điều này sẽ gây tràn bộ nhớ. Vui lòng liên hệ nhà phát triển.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            SANPHAM dv = data.SANPHAMs.SingleOrDefault(p => p.IDSP == int.Parse(cbosanpham.SelectedValue.ToString()));
                            dsmua.Add(new MUAHANG
                            {
                                IDSP = dv.IDSP,
                                TenSanPham = dv.TenSanPham,
                                DonGia = Convert.ToDecimal(dv.DonGia),
                                SoLuong = soluong,
                                DonViTinh = dv.DonViTinh
                            });
                        }
                    }
                }
                else
                {
                    Decimal tongTienHienTai = Decimal.Parse(dsmua.Sum(p => p.SoLuong * p.DonGia).ToString());
                    tongTienHienTai = tongTienHienTai + (soluong - hcm.SoLuong) * Decimal.Parse(txtdongia.Text.Replace(".", "").Replace(",", ".").Replace("₫", ""));
                    if (tongTienHienTai > 2000000000)
                    {
                        MessageBox.Show("Đơn hàng quá lớn, điều này sẽ gây tràn bộ nhớ. Vui lòng liên hệ nhà phát triển.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        hcm.SoLuong = soluong;
                        MessageBox.Show("Đã cập nhật");
                    }
                }

                hienthidanhsachmua();
                hienthitinhtien();
            }

        }
        void hienthidanhsachmua()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = dsmua;

            if (dataGridView2.ColumnCount > 0)
            {
                dataGridView2.Columns[0].Visible = false;
            }
        }

        public class MUAHANG
        {
            public int IDSP { get; set; }
            public string TenSanPham { get; set; }
            public decimal SoLuong
            {
                get;
                set;
            }
            public decimal DonGia { get; set; }
            public decimal ThanhTien { get { return SoLuong * DonGia; } }

            public string DonViTinh { get; set; }

        }


        List<MUAHANG> dsmua = new List<MUAHANG>();

        private void btntinhtien_Click(object sender, EventArgs e)
        {
            btninhoadon.Enabled = true;

            decimal thue;
            if (!decimal.TryParse(numericUpDown2.Value.ToString(), out thue))
            {
                MessageBox.Show("Thuế không hợp lệ");
                return;
            }
            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");

            txtthanhtien.Text = String.Format(info, "{0:c}", dsmua.Sum(p => p.SoLuong * p.DonGia));
            Decimal n = Decimal.Parse(dsmua.Sum(p => p.SoLuong * p.DonGia).ToString());
            Decimal th = Decimal.Parse(numericUpDown2.Value.ToString());
            Decimal vat = th / 100;
            Decimal gtgt = n * vat;
            if (checkBox1.Checked)
            {

                txtthue.Text = String.Format(info, "{0:c}", gtgt);
            }
            else
            {
                txtthue.Text = null;
            }
            Decimal tong;
            if (checkBox1.Checked)
            {
                tong = n + gtgt;
            }
            else tong = n;
            txttongtien.Text = String.Format(info, "{0:c}", tong);
            Decimal y = 0;
            if (tong <= 1999999999999)
            {
                if (tong >= 0)
                {
                    label16.Text = ConvertDecimalToString(tong);
                }
                else
                    MessageBox.Show("Số không hợp lệ !");
            }
            else
                MessageBox.Show("Số quá lớn !");
            btnluu.Enabled = true;


        }

        private void check(object sender, EventArgs e)
        {
            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");

            if (checkBox1.Checked == false)
            {

                //var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");

                txtthue.Text = null;
                Decimal tong = Decimal.Parse(dsmua.Sum(p => p.SoLuong * p.DonGia).ToString());
                txttongtien.Text = String.Format(info, "{0:c}", tong);

                numericUpDown2.Value = 0;
                numericUpDown2.Enabled = false;
            }
            else
            {
                numericUpDown2.Value = 10;
                numericUpDown2.Enabled = true;
                Decimal n = Decimal.Parse(dsmua.Sum(p => p.SoLuong * p.DonGia).ToString());
                Decimal th = Decimal.Parse(numericUpDown2.Value.ToString());
                Decimal vat = th / 100;
                Decimal gtgt = n * vat;
                Decimal tong = n + gtgt;
                txttongtien.Text = String.Format(info, "{0:c}", tong);
                txtthue.Text = String.Format(info, "{0:c}", gtgt);

            }
        }



        private void button9_Click(object sender, EventArgs e)
        {
            FrmThemKH them = new FrmThemKH();
            them.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {

                dsmua.RemoveAt(dataGridView2.SelectedRows[0].Index);
                hienthidanhsachmua();
            }
            else
                MessageBox.Show("Bạn chưa chọn sản phẩm xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            // dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);

        }

        private void clivk(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (cbotendonvi.Text == "Chọn khách hàng")
            {
                MessageBox.Show("Bạn chưa điền tên khách hàng!", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (cbotendonvi.SelectedIndex > 0)
                {

                    HOADON hd = new HOADON

                    {
                        IDHD = txtmahoadon.Text.Trim(),
                        NgayLap = dtpngaylap.Value,
                        IDKH = int.Parse(cbotendonvi.SelectedValue.ToString()),
                        //Congtymuahang = cbotendonvi.Text,
                        NguoiMuaHang = txtnguoimuahang.Text.Trim(),
                        TienHang = Decimal.Parse(txtthanhtien.Text.Replace(".", "").Replace(",", ".").Replace("₫", "")),
                        TienThue = Decimal.Parse(txtthue.Text.Replace(".", "").Replace(",", ".").Replace("₫", "")),
                        TongTien = Decimal.Parse(txttongtien.Text.Replace(".", "").Replace(",", ".").Replace("₫", "")),
                        HinhThucThanhToan = cbothanhtoan.Text.Trim()

                    };

                    data.HOADONs.InsertOnSubmit(hd);
                    data.SubmitChanges();
                    CHITIETHOADON cthd = null;
                    foreach (MUAHANG hcm in dsmua)
                    {
                        cthd = new CHITIETHOADON
                        {
                            IDHD = hd.IDHD,
                            IDSP = hcm.IDSP,
                            SoLuong = hcm.SoLuong,
                            GiaBan = hcm.DonGia,
                            ThanhTien = hcm.ThanhTien,
                            DonViTinh = hcm.DonViTinh
                        };
                        data.CHITIETHOADONs.InsertOnSubmit(cthd);

                    }
                    data.SubmitChanges();
                    MessageBox.Show("Đã lưu thành công");

                    //hienthidanhsachmua();

                    ;
                    matutanghddv();

                    this.hoadonTableAdapter1.Fill(this.qUANLYBANHANGDataSet.HOADON);
                }
                else
                {
                    HOADON hd = new HOADON

                    {
                        IDHD = txtmahoadon.Text.Trim(),
                        NgayLap = dtpngaylap.Value,
                        //  IDKH = int.Parse(cbotendonvi.SelectedValue.ToString()),
                        Congtymuahang = cbotendonvi.Text,
                        NguoiMuaHang = txtnguoimuahang.Text.Trim(),
                        TienHang = Decimal.Parse(txtthanhtien.Text.Replace(".", "").Replace(",", ".").Replace("₫", "")),
                        TienThue = Decimal.Parse(txtthue.Text.Replace(".", "").Replace(",", ".").Replace("₫", "")),
                        TongTien = Decimal.Parse(txttongtien.Text.Replace(".", "").Replace(",", ".").Replace("₫", "")),
                        HinhThucThanhToan = cbothanhtoan.Text.Trim()

                    };

                    data.HOADONs.InsertOnSubmit(hd);
                    data.SubmitChanges();
                    CHITIETHOADON cthd = null;
                    foreach (MUAHANG hcm in dsmua)
                    {
                        cthd = new CHITIETHOADON
                        {
                            IDHD = hd.IDHD,
                            IDSP = hcm.IDSP,
                            SoLuong = hcm.SoLuong,
                            GiaBan = hcm.DonGia,
                            ThanhTien = hcm.ThanhTien,
                            DonViTinh = hcm.DonViTinh
                        };
                        data.CHITIETHOADONs.InsertOnSubmit(cthd);

                    }
                    data.SubmitChanges();
                    MessageBox.Show("Đã lưu thành công");

                    //hienthidanhsachmua();

                    ;
                    matutanghddv();

                    this.hoadonTableAdapter1.Fill(this.qUANLYBANHANGDataSet.HOADON);

                }
            }

        }
        public void matutanghddv()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "select * from HOADON h, CHITIETHOADON c where h.IDHD =c.IDHD";
            SqlCommand comd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(comd);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            string s = "";
            if (dt.Rows.Count <= 0)
            {
                s = "0000001";

            }
            else
            {
                int k;
                s = "000";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(4, 3));
                k = k + 1;
                if (k < 10)
                    s = s + "000";
                else if (k < 100)
                    s = s + "00";
                else if (k < 1000)
                    s = s + "0";
                s = s + k.ToString();
            }
            txtmahoadon.Text = s;
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLYBANHANG;Integrated Security=True");
        DataTable dt;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        public string ConvertDecimalToString(decimal number)
        {
            string s = number.ToString("#");
            string[] so = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] hang = new string[] { "", "nghìn", "triệu", "tỷ" };
            int i, j, donvi, chuc, tram;
            string str = " ";
            bool booAm = false;
            decimal decS = 0;
            //Tung addnew
            try
            {
                decS = Convert.ToDecimal(s.ToString());
            }
            catch
            {
            }
            if (decS < 0)
            {
                decS = -decS;
                s = decS.ToString();
                booAm = true;
            }
            i = s.Length;
            if (i == 0)
                str = so[0] + str;
            else
            {
                j = 0;
                while (i > 0)
                {
                    donvi = Convert.ToInt32(s.Substring(i - 1, 1));
                    i--;
                    if (i > 0)
                        chuc = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        chuc = -1;
                    i--;
                    if (i > 0)
                        tram = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        tram = -1;
                    i--;
                    if ((donvi > 0) || (chuc > 0) || (tram > 0) || (j == 3))
                        str = hang[j] + str;
                    j++;
                    if (j > 3) j = 1;
                    if ((donvi == 1) && (chuc > 1))
                        str = "một " + str;
                    else
                    {
                        if ((donvi == 5) && (chuc > 0))
                            str = "lăm " + str;
                        else if (donvi > 0)
                            str = so[donvi] + " " + str;
                    }
                    if (chuc < 0)
                        break;
                    else
                    {
                        if ((chuc == 0) && (donvi > 0)) str = "lẻ " + str;
                        if (chuc == 1) str = "mười " + str;
                        if (chuc > 1) str = so[chuc] + " mươi " + str;
                    }
                    if (tram < 0) break;
                    else
                    {
                        if ((tram > 0) || (chuc > 0) || (donvi > 0)) str = so[tram] + " trăm " + str;
                    }
                    str = " " + str;
                }
            }
            if (booAm) str = "Âm " + str;
            return str + "đồng";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (cbotendonvi.Text == "Chọn khách hàng")
            {
                MessageBox.Show("Vui lòng chọn khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((txtmasothue.Text.Length < 10 || txtmasothue.Text.Length > 14) && txtmasothue.Text.Length > 0)
            {
                MessageBox.Show("Mã số thuế phải từ 10 - 14 ký tự!", "Có lỗi xảy ra", MessageBoxButtons.OK);
            }
            else
            {
                if (txtmasothue.Text == "")
                {
                    label14.Text = "";
                    label15.Text = "";
                    label17.Text = "";
                    label18.Text = "";
                    label19.Text = "";
                    label20.Text = "";
                    label21.Text = "";
                    label22.Text = "";
                    label23.Text = "";
                    label24.Text = "";
                    label25.Text = "";
                    label26.Text = "";
                    label27.Text = "";
                    label28.Text = "";
                }
                else
                {
                    if (txtmasothue.Text.Length >= 14)
                    {
                        char[] t = txtmasothue.Text.ToCharArray();
                        label14.Text = Convert.ToString(t[0]);
                        label15.Text = Convert.ToString(t[1]);
                        label17.Text = Convert.ToString(t[2]);
                        label18.Text = Convert.ToString(t[3]);
                        label19.Text = Convert.ToString(t[4]);
                        label20.Text = Convert.ToString(t[5]);
                        label21.Text = Convert.ToString(t[6]);
                        label22.Text = Convert.ToString(t[7]);
                        label23.Text = Convert.ToString(t[8]);
                        label24.Text = Convert.ToString(t[9]);
                        label25.Text = Convert.ToString(t[10]);
                        label26.Text = Convert.ToString(t[11]);
                        label27.Text = Convert.ToString(t[12]);
                        label28.Text = Convert.ToString(t[13]);
                    }
                    else
                        if (txtmasothue.Text.Length >= 13 && txtmasothue.Text.Length < 14)
                    {
                        char[] t = txtmasothue.Text.ToCharArray();
                        label14.Text = "";
                        label15.Text = Convert.ToString(t[0]);
                        label17.Text = Convert.ToString(t[1]);

                        label18.Text = Convert.ToString(t[2]);
                        label19.Text = Convert.ToString(t[3]);
                        label20.Text = Convert.ToString(t[4]);
                        label21.Text = Convert.ToString(t[5]);
                        label22.Text = Convert.ToString(t[6]);
                        label23.Text = Convert.ToString(t[7]);
                        label24.Text = Convert.ToString(t[8]);
                        label25.Text = Convert.ToString(t[9]);
                        label26.Text = Convert.ToString(t[10]);
                        label27.Text = Convert.ToString(t[11]);
                        label28.Text = Convert.ToString(t[12]);
                    }
                    else
                            if (txtmasothue.Text.Length >= 12 && txtmasothue.Text.Length < 13)
                    {
                        char[] t = txtmasothue.Text.ToCharArray();
                        label14.Text = "";
                        label15.Text = "";
                        label17.Text = Convert.ToString(t[0]);

                        label18.Text = Convert.ToString(t[1]);
                        label19.Text = Convert.ToString(t[2]);
                        label20.Text = Convert.ToString(t[3]);
                        label21.Text = Convert.ToString(t[4]);
                        label22.Text = Convert.ToString(t[5]);
                        label23.Text = Convert.ToString(t[6]);
                        label24.Text = Convert.ToString(t[7]);
                        label25.Text = Convert.ToString(t[8]);
                        label26.Text = Convert.ToString(t[9]);
                        label27.Text = Convert.ToString(t[10]);
                        label28.Text = Convert.ToString(t[11]);
                    }
                    else
                                if (txtmasothue.Text.Length >= 11 && txtmasothue.Text.Length < 12)
                    {
                        char[] t = txtmasothue.Text.ToCharArray();
                        label14.Text = "";
                        label15.Text = "";
                        label17.Text = "";
                        label18.Text = Convert.ToString(t[0]);
                        label19.Text = Convert.ToString(t[1]);
                        label20.Text = Convert.ToString(t[2]);
                        label21.Text = Convert.ToString(t[3]);
                        label22.Text = Convert.ToString(t[4]);
                        label23.Text = Convert.ToString(t[5]);
                        label24.Text = Convert.ToString(t[6]);
                        label25.Text = Convert.ToString(t[7]);
                        label26.Text = Convert.ToString(t[8]);
                        label27.Text = Convert.ToString(t[9]);
                        label28.Text = Convert.ToString(t[10]);
                    }
                    else
                                    if (txtmasothue.Text.Length >= 10)
                    {
                        char[] t = txtmasothue.Text.ToCharArray();
                        label14.Text = "";
                        label15.Text = "";
                        label17.Text = "";

                        label18.Text = "";
                        label19.Text = Convert.ToString(t[0]);
                        label20.Text = Convert.ToString(t[1]);
                        label21.Text = Convert.ToString(t[2]);
                        label22.Text = Convert.ToString(t[3]);
                        label23.Text = Convert.ToString(t[4]);
                        label24.Text = Convert.ToString(t[5]);
                        label25.Text = Convert.ToString(t[6]);
                        label26.Text = Convert.ToString(t[7]);
                        label27.Text = Convert.ToString(t[8]);
                        label28.Text = Convert.ToString(t[9]);
                    }

                }





                Frminhoadon inhd = new Frminhoadon(txtnguoimuahang.Text, cbotendonvi.Text, txtdiachi.Text, txtmasothue.Text, txtsotaikhoan.Text, cbothanhtoan.Text, txtthue.Text, txttongtien.Text, dtpngaylap.Value, label16.Text, numericUpDown2.Value.ToString(), label14.Text, label15.Text, label17.Text, label18.Text, label19.Text, label20.Text, label21.Text, label22.Text, label23.Text, label24.Text, label25.Text, label26.Text, label27.Text, label28.Text, dsmua, txtthanhtien.Text);
                inhd.ShowDialog();
            }
        }

        private void hOADONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOADONBindingSource.EndEdit();


        }
        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Show();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {

                int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                string tenkh = listView1.SelectedItems[0].SubItems[1].Text;
                string mathue = listView1.SelectedItems[0].SubItems[2].Text;
                string diachi = listView1.SelectedItems[0].SubItems[3].Text;
                string sotaikhoan = listView1.SelectedItems[0].SubItems[4].Text;
                string sodienthoai = listView1.SelectedItems[0].SubItems[5].Text;
                FrmSuaKH sua = new FrmSuaKH(id, tenkh, mathue, diachi, sotaikhoan, sodienthoai);
                sua.ShowDialog();
            }
            else
                MessageBox.Show("Bạn phải chọn khách hàng cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void cHITIETHOADONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cHITIETHOADONBindingSource.EndEdit();

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hOADONBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void txttim_TextChanged(object sender, EventArgs e)
        {
        }

        private void button12_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            FrmThemKH them = new FrmThemKH();
            them.ShowDialog();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            hienthikhachhang();

        }

        private void Formclose(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Close", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void button17_Click_1(object sender, EventArgs e)
        {

        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    sp.xoasanpham(int.Parse(listView1.SelectedItems[0].SubItems[0].Text));
                    listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
                    listView1.Items.Clear();
                    hienthikhachhang();
                }
            }
            else

                MessageBox.Show("Bạn phải chọn sản phẩm cần xóa", "Xoá sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }



        private void btnxoakh_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    nv.xoakhachhang(int.Parse(listView1.SelectedItems[0].SubItems[0].Text));
                    listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
                    MessageBox.Show("Khách hàng đã được xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listView1.Items.Clear();
                    hienthikhachhang();

                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn khách hàng cần xóa", "Xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }
        private void btncapnhat_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            hienthikhachhang();
        }


        private void hOADONDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button10_Click_2(object sender, EventArgs e)
        {

            FrmThemKH them = new FrmThemKH();
            them.ShowDialog();
        }

        private void button12_Click_2(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    nv.xoakhachhang(int.Parse(listView1.SelectedItems[0].SubItems[0].Text));
                    listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
                    MessageBox.Show("Khách hàng đã được xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listView1.Items.Clear();
                    hienthikhachhang();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn khách hàng cần xóa", "Xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button14_Click_2(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            hienthikhachhang();
        }

        private void btncapnhasp_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            hienthisanpham();
        }

        private void btnxoasp_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    sp.xoasanpham(int.Parse(listView2.SelectedItems[0].SubItems[0].Text));
                    listView2.Items.RemoveAt(listView2.SelectedIndices[0]);
                    MessageBox.Show("Sản phẩm đã được xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listView2.Items.Clear();
                    hienthisanpham();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn sản phẩm cần xóa", "Xoá sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnsuasp_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedIndices.Count > 0)
            {

                int id = int.Parse(listView2.SelectedItems[0].SubItems[0].Text);
                string tensp = listView2.SelectedItems[0].SubItems[1].Text;
                Decimal dongia = Decimal.Parse(listView2.SelectedItems[0].SubItems[2].Text);
                string donvitinh = listView2.SelectedItems[0].SubItems[3].Text;

                FrmSuaSp sua = new FrmSuaSp(id, tensp, dongia, donvitinh);
                sua.ShowDialog();
            }
            else
                MessageBox.Show("Bạn phải chọn sản phẩm cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnsp_Click(object sender, EventArgs e)
        {
            FrmThemSP them = new FrmThemSP();
            them.ShowDialog();

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer(object sender, EventArgs e)
        {
            String s = "Hôm nay là ngày " + DateTime.Now.ToString("dd/MM/yyyy");
            s = s + " - Bây giờ là " + DateTime.Now.ToString("hh:mm:ss tt");
            toolStripStatusLabel1.Text = s;
            this.Text = this.Text.Substring(1, this.Text.Length - 1) + this.Text.Substring(0, 1);
        }

        private void btn(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            hienthikhachhang();
        }

        private void xoatrangfrm1(object sender, EventArgs e)
        {
            cbotendonvi.Text = "Chọn khách hàng";
            txtmasothue.Text = "";
            txtsotaikhoan.Text = "";
            txtdiachi.Text = "";
            txtnguoimuahang.Text = "";
            cbosanpham.Text = "Chọn sản phẩm";
            cbothanhtoan.SelectedIndex = 0;
            txtdongia.Text = "";
            txtdonvitinh.Text = "";
            txtthanhtien.Text = "";
            txtthue.Text = "";
            txttongtien.Text = "";
            btntinhtien.Enabled = false;
            btnluu.Enabled = false;
            btninhoadon.Enabled = false;
            dsmua.Clear();
            dataGridView2.DataSource = null;

        }

        private void keypressCBTenDonVi(object sender, KeyPressEventArgs e)
        {
            //e.Handled = true;
        }

        private void keyPressTenSanPham(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        private void keyPressHinhThucThanhToan(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Formclosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình không?", "Close", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void hOADONDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sotaikhoankpr(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgv_dataerror(object sender, DataGridViewDataErrorEventArgs e)
        { }

        private void TimKiem(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                //initialize a new instance of sqlcommand
                cm = new SqlCommand();
                //set a connection used by this instance of sqlcommand
                cm.Connection = con;
                //set the sql statement to execute at the data source
                cm.CommandText = "Select * FROM KHACHHANG WHERE TenDonVi LIKE N'%" + txtTimKiem.Text + "%'";

                //initialize a new instance of sqlDataAdapter
                da = new SqlDataAdapter();
                //set the sql statement or stored procedure to execute at the data source
                da.SelectCommand = cm;
                //initialize a new instance of DataTable
                dt = new DataTable();
                //add or resfresh rows in the certain range in the datatable to match those in the data source.
                da.Fill(dt);
                //add the data source to display the data in the ListView
                listView1.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi = listView1.Items.Add(dt.Rows[i][0].ToString());
                    lvi.SubItems.Add(dt.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt.Rows[i][2].ToString());
                    lvi.SubItems.Add(dt.Rows[i][3].ToString());
                    lvi.SubItems.Add(dt.Rows[i][4].ToString());
                    lvi.SubItems.Add(dt.Rows[i][5].ToString());

                }
            }
            catch (Exception ex)
            {
                //catching error 
                MessageBox.Show(ex.Message);
            }
            //release all resources used by the component
            da.Dispose();
            //dr.Close();
            //clossing connection
            con.Close();

        }

        private void masothue_keypress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }

}
