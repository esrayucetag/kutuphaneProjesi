using System.Data;
using kutuphaneProjesi.DAL;

namespace kutuphaneProjesi.BLL
{
    public class UyePanelBLL
    {
        private readonly UyePanelDAL dal = new UyePanelDAL();

        public (bool ok, string mesaj, int uyeId, string adSoyad) UyeGiris(string tc, string sifre)
        {
            if (string.IsNullOrWhiteSpace(tc) || tc.Length != 11)
                return (false, "TC 11 haneli olmalı.", 0, "");

            if (string.IsNullOrWhiteSpace(sifre))
                return (false, "Şifre boş olamaz.", 0, "");

            var r = dal.UyeGiris(tc.Trim(), sifre.Trim());
            if (!r.ok) return (false, "TC veya şifre hatalı.", 0, "");

            return (true, "Giriş başarılı.", r.uyeId, r.adSoyad);
        }

        public DataTable UyeninTumIslemleri(int uyeId) => dal.UyeninTumIslemleri(uyeId);

        public (int uzerindeki, int geciken, int toplamOkunan, int karaListe) KartBilgileri(int uyeId)
            => dal.KartBilgileri(uyeId);
    }
}
