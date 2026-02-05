#nullable disable
using System.Data;
using kutuphaneProjesi.DAL;

namespace kutuphaneProjesi.BLL
{
    public class uyelerBLL
    {
        uyelerDAL dal = new uyelerDAL();

        public DataTable UyeleriGetir() => dal.UyeleriGetir();
        public DataTable KaraListeGetir() => dal.KaraListeGetir();

        public DataTable UyeAraTC(string tc, bool karaListeModu) => dal.UyeAraTC(tc, karaListeModu);

        public void UyeEkle(string tc, string ad, string sifre) => dal.UyeEkle(tc, ad, sifre);
        public void UyeSil(int id) => dal.UyeSil(id);
        public void UyeGuncelle(int id, string tc, string ad, string sifre) => dal.UyeGuncelle(id, tc, ad, sifre);

        public void KaraListeyeAl(int id) => dal.KaraListeyeAl(id);
        public void KaraListedenCikar(int id) => dal.KaraListedenCikar(id);
    }
}
