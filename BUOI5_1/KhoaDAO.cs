using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUOI5_1
{
    internal class KhoaDAO
    {

        SqlConnection conn = nu1l;
        Sqlommand cmd = null;
        SqlDataAdapter apt = nu1l;
        KetNoi kn = new KetNoi();

        public DataTable getList()
        {
            conn = kn.getConnect();
            string sq1 = "SELECT * FROM Khoa";
            cmd = new SqlCommand(sq1, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }
    }
}
