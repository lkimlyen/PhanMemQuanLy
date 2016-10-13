using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PHANMEMBANCHINH
{
    class KhachHang
    {
        DataBase db;
        public KhachHang()
        {
            db = new DataBase();
        }
        public DataTable Laydskhachhang()
        {
            string strsql = "Select * from KHACHHANG";
            DataTable dt = db.Execute(strsql);
            return dt;
        }
      
        public void xoakhachhang(int makh)
        {
            
            string sql1 = "Delete from KHACHHANG where  IDKH = '" + makh + "'";
            db.ExecuteNonQuery(sql1);
        }
        public void themkhachhang(string tendonvi, string masothue, string diachi, string sotaikhoan, string sdt)
        {
            string sql = string.Format("Insert Into KHACHHANG Values(N'{0}','{1}',N'{2}','{3}','{4}')", tendonvi, masothue, diachi, sotaikhoan,sdt);
            db.ExecuteNonQuery(sql);
        }
        public void capnhatkhachhang(int makh, string tendonvi, string masothue, string diachi, string sotaikhoan, string sdt)
        {
            string sql = string.Format("Update KHACHHANG set TenDonVi = N'{1}',MaSoThue = '{2}', DiaChi =N'{3}', SoTaiKhoan ='{4}', SDT = '{5}' where IDKH = '{0}'", makh, tendonvi, masothue, diachi, sotaikhoan, sdt);
            db.ExecuteNonQuery(sql);
        }
    }
}
