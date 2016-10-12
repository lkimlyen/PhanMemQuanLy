using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PHANMEMBANCHINH
{
    class SanPham
    {
        DataBase db;
        public SanPham()
        {
            db = new DataBase();
        }
        public DataTable Laydssanpham()
        {
            string strsql = "Select * from SANPHAM";
            DataTable dt = db.Execute(strsql);
            return dt;
        }

        public void xoasanpham(int makh)
        {
            string sql = "Delete from SANPHAM where IDSP = '" + makh + "'";
            db.ExecuteNonQuery(sql);
        }
        public void themsanpham(string tensanpham, int dongia, string donvitinh)
        {
            string sql = string.Format("Insert Into SANPHAM Values(N'{0}',{1},N'{2}')", tensanpham, dongia, donvitinh);
            db.ExecuteNonQuery(sql);
        }
        public void capnhatsanpham(int masp, string tensanpham, int dongia, string donvitinh)
        {
            string sql = string.Format("Update SANPHAM set TenSanPham = N'{1}',DonGia ={2}, DonViTinh = N'{3}' where IDSP = '{0}'", masp, tensanpham, dongia, donvitinh);
            db.ExecuteNonQuery(sql);
        }
    }
}
