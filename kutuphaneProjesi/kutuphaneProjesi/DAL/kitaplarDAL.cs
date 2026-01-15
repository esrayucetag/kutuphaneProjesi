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
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM books", conn);
                da.Fill(dt);
            }
            return dt;
        }
        public int KitapIdGetir(string ad, string yazar)
        {
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();
                string sql = "SELECT id FROM books WHERE kitapAd = @ad AND yazar = @yazar";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ad", ad);
                cmd.Parameters.AddWithValue("@yazar", yazar);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
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
                string sql = "INSERT INTO books (kitapAd, yazar, adet, kitapTuru) VALUES (@ad, @yazar, @adet, @tur)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ad", ad);
                cmd.Parameters.AddWithValue("@yazar", yazar);
                cmd.Parameters.AddWithValue("@adet", adet);
                cmd.Parameters.AddWithValue("@tur", tur);

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