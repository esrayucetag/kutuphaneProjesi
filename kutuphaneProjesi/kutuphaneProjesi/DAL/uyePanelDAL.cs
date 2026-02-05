using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace kutuphaneProjesi.DAL
{
    public class UyePanelDAL
    {
        public (bool ok, int uyeId, string adSoyad) UyeGiris(string tc, string sifre)
        {
            using (var conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();
                string sql = @"SELECT userId, userAdSoyad
                               FROM users
                               WHERE userTc = @tc AND password = @sifre
                               LIMIT 1";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);
                    cmd.Parameters.AddWithValue("@sifre", sifre);

                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            int id = Convert.ToInt32(dr["userId"]);
                            string ad = dr["userAdSoyad"].ToString();
                            return (true, id, ad);
                        }
                    }
                }
            }

            return (false, 0, "");
        }

        public DataTable UyeninTumIslemleri(int uyeId)
        {
            using (var conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();


                string sql = @"
                    SELECT 
                        b.kitapAd AS KitapAdi,
                        i.verilisTarihi AS AlisTarihi,
                        COALESCE(i.teslimTarihi, DATE_ADD(i.verilisTarihi, INTERVAL 14 DAY)) AS SonTeslim,
                        i.islemDurumu AS Durum
                    FROM islemler i
                    INNER JOIN books b ON b.id = i.kitapId
                    WHERE i.uyeId = @uyeId
                    ORDER BY i.verilisTarihi DESC;";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@uyeId", uyeId);
                    using (var adp = new MySqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        adp.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public (int uzerindeki, int geciken, int toplamOkunan, int karaListe) KartBilgileri(int uyeId)
        {
            using (var conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();

                string sql = @"
                    SELECT
                        (SELECT COUNT(*) FROM islemler WHERE uyeId=@uyeId AND islemDurumu=1) AS Uzerindeki,
                        (SELECT COUNT(*) 
                            FROM islemler 
                            WHERE uyeId=@uyeId AND islemDurumu=1
                              AND CURDATE() > COALESCE(teslimTarihi, DATE_ADD(verilisTarihi, INTERVAL 14 DAY))
                        ) AS Geciken,
                        (SELECT COUNT(*) FROM islemler WHERE uyeId=@uyeId AND islemDurumu=0) AS ToplamOkunan,
                        (SELECT karaListe FROM users WHERE userId=@uyeId LIMIT 1) AS KaraListe;
                ";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@uyeId", uyeId);
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            int u = Convert.ToInt32(dr["Uzerindeki"]);
                            int g = Convert.ToInt32(dr["Geciken"]);
                            int t = Convert.ToInt32(dr["ToplamOkunan"]);
                            int k = Convert.ToInt32(dr["KaraListe"]);
                            return (u, g, t, k);
                        }
                    }
                }
            }

            return (0, 0, 0, 0);
        }
    }
}
