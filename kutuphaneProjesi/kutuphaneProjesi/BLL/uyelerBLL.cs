using System.Data;
using kutuphaneProjesi.DAL;

namespace kutuphaneProjesi.BLL
{
    public class uyelerBLL
    {
        uyelerDAL dal = new uyelerDAL();

        public DataTable UyeleriGetir()
        {
            return dal.UyeleriGetir();
        }

        public void UyeEkle(string tc, string ad, string sifre)
        {
            dal.UyeEkle(tc, ad, sifre);
        }

        public void UyeSil(int id)
        {
            dal.UyeSil(id);
        }

        public void UyeGuncelle(int id, string tc, string ad, string sifre)
        {
            dal.UyeGuncelle(id, tc, ad, sifre);
        }
    }
}
