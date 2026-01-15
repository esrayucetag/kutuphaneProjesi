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
                try
                {
                    conn.Open();
                    
                    string sql = @"INSERT INTO islemler (uyeId, kitapId, verilisTarihi, teslimTarihi, islemDurumu) 
                           VALUES (@uId, @kId, @vTarih, DATE_ADD(@vTarih, INTERVAL 15 DAY), 1)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@uId", uId);
                    cmd.Parameters.AddWithValue("@kId", kId);
                    cmd.Parameters.AddWithValue("@vTarih", verilisTarihi); 
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch { return false; }
            }
        }

        
        public DataTable KitaplariListele()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();
                string sql = "SELECT id, kitapAd, yazar, adet FROM books"; 
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(dt);
            }
            return dt;
        }

        public void TeslimAl(int islemId, int kitapId)
        {
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();
                string sql = "UPDATE islemler SET islemDurumu = 0, teslimTarihi = NOW() WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", islemId);
                cmd.ExecuteNonQuery();

                string up = "UPDATE books SET adet = adet + 1 WHERE id = @kId";
                MySqlCommand upCmd = new MySqlCommand(up, conn);
                upCmd.Parameters.AddWithValue("@kId", kitapId);
                upCmd.ExecuteNonQuery();
            }
        }

        public DataTable KitapListesiGetir()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();
                new MySqlDataAdapter("SELECT id, kitapAd FROM books WHERE adet > 0", conn).Fill(dt);
            }
            return dt;
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
      
        public DataTable GetEnCokOkunanlar()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
          
                string sql = @"SELECT b.kitapAd as 'Kitap Adı', b.yazar as 'Yazar', COUNT(i.id) as 'Okunma Sayısı' 
                       FROM islemler i 
                       JOIN books b ON i.kitapId = b.id 
                       GROUP BY b.id 
                       ORDER BY COUNT(i.id) DESC LIMIT 5";
                new MySqlDataAdapter(sql, conn).Fill(dt);
            }
            return dt;
        }

        public DataTable GetGecikenKitaplar()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();
               
                string sql = @"SELECT u.userAdSoyad as 'Üye', b.kitapAd as 'Kitap', i.teslimTarihi as 'Son Tarih' 
                       FROM islemler i 
                       JOIN users u ON i.uyeId = u.userId 
                       JOIN books b ON i.kitapId = b.id 
                       WHERE i.islemDurumu = 1"; 
                new MySqlDataAdapter(sql, conn).Fill(dt);
            }
            return dt;
        }
        public DataTable TCIleUyeSorgula(string tc)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT userId, userAdSoyad FROM users WHERE userTc = @tc", conn);
                cmd.Parameters.AddWithValue("@tc", tc);
                new MySqlDataAdapter(cmd).Fill(dt);
            }
            return dt;
        }

        public DataTable AktifIslemleriGetir()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();
                string sql = "SELECT i.id, u.userAdSoyad, b.kitapAd, i.verilisTarihi, i.teslimTarihi, b.id as kitapId FROM islemler i JOIN users u ON i.uyeId = u.userId JOIN books b ON i.kitapId = b.id WHERE i.islemDurumu = 1";
                new MySqlDataAdapter(sql, conn).Fill(dt);
            }
            return dt;
        }
    }
}