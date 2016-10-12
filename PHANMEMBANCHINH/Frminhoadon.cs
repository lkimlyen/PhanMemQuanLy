using Microsoft.Reporting.WinForms;
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
    public partial class Frminhoadon : Form
    {


        public Frminhoadon(string nguoimuahang, string tendonvi, string diachi, string masothue, string sotaikhoan, string hinhthucthanhtoan, string tienthue, string tongtien, DateTime ngaymua, string chu, string thue, string m, string h, string b, string bo, string n, string s, string bam, string t, string c, string mu, string mm, string mh, string mbam, string mbo,List<PHANMEMBANCHINH.Form1.MUAHANG> mua)
        {
            InitializeComponent();
            NguoiMuaHang = nguoimuahang;
            muahang = mua;
            TenDonVi = tendonvi;
            DiaChi = diachi;
            MaSoThue = masothue;
            SoTaiKhoan = sotaikhoan;
            HinhThucThanhToan = hinhthucthanhtoan;
            TienThue = tienthue;
            TongTien = tongtien;
            NgayLap = ngaymua;
            SoVietBangChu = chu;
            

            Thue = thue;
            mot = m;
            hai = h;
            ba = b;
            bon = bo;
            nam = n;
            sau =  s;
            bay = bam;
            tam = t;
            chin = c;
            muoi = mu;
            mmot = mm;
            mhai = mh;
            mba = mbam;
            mbon = mbo;

           
        }

       

       
        public DateTime NgayLap { get; set; }
       
        public string NguoiMuaHang { get; set; }
        public List<PHANMEMBANCHINH.Form1.MUAHANG> muahang { get; set; }
        public string TenDonVi { get; set; }
        public string DiaChi { get; set; }
        public string MaSoThue { get; set; }
        public string SoTaiKhoan { get; set; }
        public string HinhThucThanhToan { get; set; }
        public string TienThue { get; set; }
        public string TongTien { get; set; }
        public string  SoVietBangChu { get; set; }
        public string Thue { get; set; }
        public string mot { get; set; }
        public string hai { get; set; }
        public string ba { get; set; }
        public string bon { get; set; }
        public string nam { get; set; }
        public string sau { get; set; }
        public string bay { get; set; }
        public string tam { get; set; }
        public string chin { get; set; }
        public string muoi { get; set; }
        public string mmot { get; set; }
        public string mhai { get; set; }
        public string mba { get; set; }
        public string mbon { get; set; }
        private void Frminhoadon_Load(object sender, EventArgs e)
        {

            ReportParameter[] param = new ReportParameter[25];
            param[0] = new ReportParameter("NguoiMuaHang", NguoiMuaHang);
            param[1] = new ReportParameter("TenDonVi", TenDonVi);
            param[2] = new ReportParameter("DiaChi", DiaChi);
            param[3] = new ReportParameter("MaSoThue", MaSoThue);
            param[4] = new ReportParameter("SoTaiKhoan", SoTaiKhoan);
            param[5] = new ReportParameter("HinhThucThanhToan", HinhThucThanhToan);
            param[6] = new ReportParameter("TienThue", TienThue);
            param[7] = new ReportParameter("TongTien", TongTien);
            param[8] = new ReportParameter("NgayLap", NgayLap.ToShortDateString());
            param[9] = new ReportParameter("SoTienVietBangCHu", SoVietBangChu);
            param[10] = new ReportParameter("Thue", Thue);
            param[11] = new ReportParameter("mot",mot);
            param[12] = new ReportParameter("hai",hai);
            param[13] = new ReportParameter("ba",ba);
            param[14] = new ReportParameter("bon",bon);
            param[15] = new ReportParameter("nam",nam);
            param[16] = new ReportParameter("sau",sau);
            param[17] = new ReportParameter("bay", bay);
            param[18] = new ReportParameter("tam", tam);
            param[19] = new ReportParameter("chin", chin);
            param[20] = new ReportParameter("muoi", muoi);
            param[21] = new ReportParameter("mmot", mmot);
            param[22] = new ReportParameter("mhai", mhai);
            param[23] = new ReportParameter("mba", mba);
            param[24] = new ReportParameter("mbon", mbon);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSHoaDon",muahang));
            reportViewer1.LocalReport.SetParameters(param);
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
