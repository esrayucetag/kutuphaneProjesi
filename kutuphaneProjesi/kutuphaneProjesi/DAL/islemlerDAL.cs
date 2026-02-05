using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace kutuphaneProjesi.DAL
{
    public class islemlerDAL
    {
        public bool OduncVer(int uId, int kId, DateTime verilisTarihi)
        {
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();

            
                if (UyeKaraListedeMi(uId, conn))
                    return false;

    
                if (!KitapStokDus(kId, conn))
                    return false;

      
                string sql = @"INSERT INTO islemler (uyeId, kitapId, verilisTarihi, teslimTarihi, islemDurumu) 
                               VALUES (@uId, @kId, @vTarih, DATE_ADD(@vTarih, INTERVAL 14 DAY), 1)";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@uId", uId);
                    cmd.Parameters.AddWithValue("@kId", kId);
                    cmd.Parameters.AddWithValue("@vTarih", verilisTarihi);

                    int ok = cmd.ExecuteNonQuery();
                    if (ok <= 0)
                    {

                        KitapStokArttir(kId, conn);
                        return false;
                    }
                }

                return true;
            }
        }

        public DataTable KitaplariListele()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();
                string sql = "SELECT id, kitapAd, yazar, adet FROM books WHERE adet > 0";
                new MySqlDataAdapter(sql, conn).Fill(dt);
            }
            return dt;
        }

        public void TeslimAl(int islemId, int kitapId)
        {
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();


                int uyeId;
                DateTime sonTeslim;

                string q = "SELECT uyeId, teslimTarihi FROM islemler WHERE id=@id";
                using (MySqlCommand cmdQ = new MySqlCommand(q, conn))
                {
                    cmdQ.Parameters.AddWithValue("@id", islemId);
                    using (var dr = cmdQ.ExecuteReader())
                    {
                        if (!dr.Read()) return;
                        uyeId = Convert.ToInt32(dr["uyeId"]);
                        sonTeslim = Convert.ToDateTime(dr["teslimTarihi"]);
                    }
                }


                string upd = "UPDATE islemler SET islemDurumu=0, teslimTarihi=NOW() WHERE id=@id";
                using (MySqlCommand cmdU = new MySqlCommand(upd, conn))
                {
                    cmdU.Parameters.AddWithValue("@id", islemId);
                    cmdU.ExecuteNonQuery();
                }

 
                KitapStokArttir(kitapId, conn);

  
                if (DateTime.Now.Date > sonTeslim.Date)
                {
    
                    string inc = "UPDATE users SET gecikmeSayisi = gecikmeSayisi + 1, karaListe = 1 WHERE userId=@uId";
                    using (MySqlCommand cmdInc = new MySqlCommand(inc, conn))
                    {
                        cmdInc.Parameters.AddWithValue("@uId", uyeId);
                        cmdInc.ExecuteNonQuery();
                    }
                }
                else
                {

                    if (!GecikmisAktifVarMi(uyeId, conn))
                    {
                        string clr = "UPDATE users SET karaListe=0 WHERE userId=@uId";
                        using (MySqlCommand cmdClr = new MySqlCommand(clr, conn))
                        {
                            cmdClr.Parameters.AddWithValue("@uId", uyeId);
                            cmdClr.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        public DataTable TCIleUyeSorgula(string tc)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(
                    "SELECT userId, userAdSoyad FROM users WHERE userTc=@tc", conn))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);
                    new MySqlDataAdapter(cmd).Fill(dt);
                }
            }
            return dt;
        }

        public DataTable AktifIslemleriGetir()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();
                string sql = @"SELECT i.id, u.userAdSoyad, b.kitapAd, i.verilisTarihi, i.teslimTarihi, b.id as kitapId
                               FROM islemler i 
                               JOIN users u ON i.uyeId = u.userId 
                               JOIN books b ON i.kitapId = b.id 
                               WHERE i.islemDurumu = 1";
                new MySqlDataAdapter(sql, conn).Fill(dt);
            }
            return dt;
        }

        public int AktifOduncSayisi(int uId)
        {
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM islemler WHERE uyeId=@u AND islemDurumu=1";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@u", uId);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }


        public (int karaListe, int gecikmeSayisi) UyeDurumGetir(int uId)
        {
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();
                string sql = "SELECT karaListe, gecikmeSayisi FROM users WHERE userId=@id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", uId);
                    using (var r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            int kara = Convert.ToInt32(r["karaListe"]);
                            int gec = Convert.ToInt32(r["gecikmeSayisi"]);
                            return (kara, gec);
                        }
                    }
                }
            }
            return (0, 0);
        }

        private bool UyeKaraListedeMi(int uId, MySqlConnection conn)
        {
            string sql = "SELECT karaListe FROM users WHERE userId=@id";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", uId);
                object r = cmd.ExecuteScalar();
                return r != null && Convert.ToInt32(r) == 1;
            }
        }

        private bool KitapStokDus(int kitapId, MySqlConnection conn)
        {
            string sql = "UPDATE books SET adet = adet - 1 WHERE id=@id AND adet > 0";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", kitapId);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        private void KitapStokArttir(int kitapId, MySqlConnection conn)
        {
            string sql = "UPDATE books SET adet = adet + 1 WHERE id=@id";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", kitapId);
                cmd.ExecuteNonQuery();
            }
        }

        private bool GecikmisAktifVarMi(int uId, MySqlConnection conn)
        {
            string sql = @"SELECT COUNT(*) 
                           FROM islemler 
                           WHERE uyeId=@u AND islemDurumu=1 AND teslimTarihi < CURRENT_DATE()";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@u", uId);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

  
        public DataTable RaporEnCokOkunanlar()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                string sql = @"SELECT b.kitapAd, COUNT(i.id) as 'Adet' 
                               FROM islemler i 
                               JOIN books b ON i.kitapId = b.id 
                               GROUP BY b.id ORDER BY Adet DESC LIMIT 5";
                new MySqlDataAdapter(sql, conn).Fill(dt);
            }
            return dt;
        }

        public DataTable RaporGecikenKitaplar()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                string sql = @"SELECT u.userAdSoyad as 'Üye', b.kitapAd as 'Kitap', i.teslimTarihi 
                               FROM islemler i 
                               JOIN users u ON i.uyeId = u.userId 
                               JOIN books b ON i.kitapId = b.id 
                               WHERE i.islemDurumu = 1 AND i.teslimTarihi < CURRENT_DATE()";
                new MySqlDataAdapter(sql, conn).Fill(dt);
            }
            return dt;
        }
    }
}
