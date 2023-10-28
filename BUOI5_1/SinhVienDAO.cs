using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUOI5_1
{
    internal class SinhVienDAO
    {

        SqlConnection conn = nu1ll;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();



        public SinhVienDAO()

        {
            conn = kn.getConnect();
            if (conn.State == ConnectionState.Closed)
            {

                conn.Open();

            }
        }
    }
}

