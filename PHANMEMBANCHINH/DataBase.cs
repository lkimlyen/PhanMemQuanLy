using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PHANMEMBANCHINH
{
    class DataBase
    {
        SqlConnection sqlConn;
        SqlDataAdapter da;

        public SqlConnection data()
        {
           SqlConnection con  = new SqlConnection("Server=" + srvName + ";database=" + dbName + ";Integrated Security = True");
            return con;
        }
        DataSet ds;
        public string srvName = ".\\SQLEXPRESS";
        public string dbName = "QUANLYBANHANG";
        public DataBase()
        {
            string strCnn = "Data source=" + srvName + ";database=" + dbName + ";Integrated Security = True";
            sqlConn = new SqlConnection(strCnn);
        }
        public DataTable Execute(string sqlStr)
        {
            da = new SqlDataAdapter(sqlStr, sqlConn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public void ExecuteNonQuery(string strSQL)
        {
            SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn);
            sqlConn.Open();
            sqlcmd.ExecuteNonQuery();
            sqlConn.Close();
        }
       public SqlDataReader thucthilay1recored(string strSQL)
        {
            SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn);
            sqlConn.Open();
            sqlcmd.ExecuteNonQuery();
            SqlDataReader dr = sqlcmd.ExecuteReader();  
            sqlConn.Close();
            sqlConn.Dispose();
            return dr;
        }

    }
}
