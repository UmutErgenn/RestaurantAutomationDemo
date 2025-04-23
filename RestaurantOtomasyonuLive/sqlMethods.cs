using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOtomasyonuLive
{
    internal class sqlMethods
    {
        public static bool login(string mail, string psswrd)
        {
            Connection connection = new Connection();
            SqlCommand cmd = new SqlCommand("giris_proc2", connection.Connect);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter p_mail = new SqlParameter("mail", mail); // databasede oluşturduğumuz procedure'daki parametre adı / bu metoda parametre olarak gelen kadi değeri
            SqlParameter p_psswrd = new SqlParameter("psswrd", psswrd);
            cmd.Parameters.Add(p_mail);
            cmd.Parameters.Add(p_psswrd);
            SqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
                return true;
            else
                return false;
        }
    }
}
