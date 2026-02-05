using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace kutuphaneProjesi.DAL
{
    public class istatistikDAL
    {
        public DataTable AylikOduncIstatistik()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();

                string sql = @"
                    SELECT 
                        DATE_FORMAT(verilisTarihi, '%Y-%m') AS AyEtiket,
                        COUNT(*) AS OduncSayisi
                    FROM islemler
                    WHERE verilisTarihi >= DATE_SUB(CURDATE(), INTERVAL 6 MONTH)
                    GROUP BY AyEtiket
                    ORDER BY AyEtiket;
                ";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(dt);
            }

            return dt;
        }

        public int[] GenelSayilar()
        {
            int[] sayilar = new int[3];

            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();

                string sql1 = "SELECT IFNULL(SUM(adet),0) FROM books";
                using (MySqlCommand cmd1 = new MySqlCommand(sql1, conn))
                    sayilar[0] = Convert.ToInt32(cmd1.ExecuteScalar());

                string sql2 = "SELECT COUNT(*) FROM users";
                using (MySqlCommand cmd2 = new MySqlCommand(sql2, conn))
                    sayilar[1] = Convert.ToInt32(cmd2.ExecuteScalar());

                string sql3 = "SELECT COUNT(*) FROM islemler WHERE islemDurumu = 1";
                using (MySqlCommand cmd3 = new MySqlCommand(sql3, conn))
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
                string sql = @"
                    SELECT 
                        u.userAdSoyad AS 'Üye Adı', 
                        COUNT(i.id) AS 'Okunan Kitap'
                    FROM islemler i
                    JOIN users u ON i.uyeId = u.userId
                    GROUP BY u.userId, u.userAdSoyad
                    ORDER BY COUNT(i.id) DESC
                    LIMIT 5";

                using (MySqlDataAdapter da = new MySqlDataAdapter(sql, conn))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public DataTable AylikOduncIstatistikSon6Ay()
        {
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();

                string query = @"
            SELECT 
    DATE_FORMAT(verilisTarihi,'%Y-%m') AS AyEtiket,
    COUNT(*) AS OduncSayisi
FROM islemler
GROUP BY YEAR(verilisTarihi), MONTH(verilisTarihi)
ORDER BY YEAR(verilisTarihi), MONTH(verilisTarihi)

        ";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }


        public int[] OduncGecikmeOrani()
        {
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();

                string q1 = "SELECT COUNT(*) FROM islemler WHERE islemDurumu = 1";
                int oduncToplam = Convert.ToInt32(new MySqlCommand(q1, conn).ExecuteScalar());

                string q2 = @"SELECT COUNT(*) 
                              FROM islemler 
                              WHERE islemDurumu = 1 AND teslimTarihi < CURDATE()";
                int geciken = Convert.ToInt32(new MySqlCommand(q2, conn).ExecuteScalar());

                return new int[] { oduncToplam, geciken };
            }

        }
    }
}
