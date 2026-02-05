using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace kutuphaneProjesi.DAL
{
    public class kitaplarDAL
    {
        public DataTable KitaplariGetir()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(
                    "SELECT id, kitapAd, yazar, adet, kitapTuru FROM books ORDER BY id DESC", conn);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable KitapAra(string arama)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();

                string sql = @"
                    SELECT id, kitapAd, yazar, adet, kitapTuru
                    FROM books
                    WHERE kitapAd LIKE @q OR yazar LIKE @q OR kitapTuru LIKE @q
                    ORDER BY id DESC";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@q", "%" + arama + "%");

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public void KitapAdetGuncelle(int id, int miktar)
        {
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();
                string sql = "UPDATE books SET adet = adet + @miktar WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@miktar", miktar);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public void KitapEkle(string ad, string yazar, int adet, string tur)
        {
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();

                string sql = @"
        INSERT INTO books (kitapAd, yazar, adet, kitapTuru)
        VALUES (@ad, @yazar, @adet, @tur)
        ON DUPLICATE KEY UPDATE adet = adet + VALUES(adet)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ad", ad.Trim());
                cmd.Parameters.AddWithValue("@yazar", yazar.Trim());
                cmd.Parameters.AddWithValue("@adet", adet);
                cmd.Parameters.AddWithValue("@tur", tur.Trim());

                cmd.ExecuteNonQuery();
            }
        }


        public void KitapTamamenSil(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();
                string sql = "DELETE FROM books WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
