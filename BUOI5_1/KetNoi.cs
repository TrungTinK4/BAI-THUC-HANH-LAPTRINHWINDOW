using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;




namespace BUOI5_1
{
    internal class KetNoi
    {
      


        String sqlConnect;

        public KetNoi()
        {
            sqlConnect = ConfigurationManager.ConnectionStrings["ChuoiKN"].ToString();
        }


    }
    public SqlConnection getConnect()
    {
        SqlConnection conn = new SqlConnection(sqlConnect);
        return conn;
    }

}

