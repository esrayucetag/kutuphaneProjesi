using MySql.Data.MySqlClient;
using System.Data;

namespace kutuphaneProjesi.DAL
{
    public class uyelerDAL
    {
        public DataTable UyeleriGetir()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();
                MySqlDataAdapter da =
                    new MySqlDataAdapter("SELECT * FROM users", conn);
                da.Fill(dt);
            }
            return dt;
        }

        public void UyeEkle(string tc, string ad, string sifre)
        {
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO users (userTc,userAdSoyad,password) VALUES (@tc,@ad,@sifre)",
                    conn);

                cmd.Parameters.AddWithValue("@tc", tc);
                cmd.Parameters.AddWithValue("@ad", ad);
                cmd.Parameters.AddWithValue("@sifre", sifre);
                cmd.ExecuteNonQuery();
            }
        }

        public void UyeSil(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();
                MySqlCommand cmd =
                    new MySqlCommand("DELETE FROM users WHERE userId=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public void UyeGuncelle(int id, string tc, string ad, string sifre)
        {
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "UPDATE users SET userTc=@tc,userAdSoyad=@ad,password=@sifre WHERE userId=@id",
                    conn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@tc", tc);
                cmd.Parameters.AddWithValue("@ad", ad);
                cmd.Parameters.AddWithValue("@sifre", sifre);
                cmd.ExecuteNonQuery();
            }
        }

        public bool YeniUyeKaydet(string tc, string adSoyad, string sifre)
        {
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();
                string sql = "INSERT INTO users (userTc, userAdSoyad, password) VALUES (@tc, @ad, @sifre)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@tc", tc);
                cmd.Parameters.AddWithValue("@ad", adSoyad);
                cmd.Parameters.AddWithValue("@sifre", sifre);

                int sonuc = cmd.ExecuteNonQuery();
                return sonuc > 0;
            }
        }
        public DataTable UyeGecmisiGetir(int uId)
        {
            using (MySqlConnection conn = new MySqlConnection(DB.ConnStr))
            {
                conn.Open();
                string sql = @"SELECT b.kitapAd as 'Kitap Adı', i.verilisTarihi as 'Alış Tarihi', 
                       i.teslimTarihi as 'İade Tarihi'
                       FROM islemler i 
                       JOIN books b ON i.kitapId = b.id 
                       WHERE i.uyeId = @uId 
                       ORDER BY i.verilisTarihi DESC";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uId", uId);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
