using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace kutuphaneProjesi.DAL
{
    public class istatistikDAL
    {
        public int[] GenelSayilar()
        {
            int[] sayilar = new int[3];
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();
                string sql1 = "SELECT SUM(adet) FROM books";
                MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                object res1 = cmd1.ExecuteScalar();
                sayilar[0] = res1 != DBNull.Value ? Convert.ToInt32(res1) : 0;
                string sql2 = "SELECT COUNT(*) FROM users";
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                sayilar[1] = Convert.ToInt32(cmd2.ExecuteScalar());
                string sql3 = "SELECT COUNT(*) FROM islemler WHERE islemDurumu = 1";
                MySqlCommand cmd3 = new MySqlCommand(sql3, conn);
                sayilar[2] = Convert.ToInt32(cmd3.ExecuteScalar());
            }
            return sayilar;
        }

        public DataTable EnCokOkuyanlar()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();
                string sql = @"SELECT u.userAdSoyad as 'Üye Adı', COUNT(i.id) as 'Okunan Kitap' 
                               FROM islemler i 
                               JOIN users u ON i.uyeId = u.userId 
                               GROUP BY u.userId 
                               ORDER BY COUNT(i.id) DESC LIMIT 5";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(dt);
            }
            return dt;
        }
    }
}