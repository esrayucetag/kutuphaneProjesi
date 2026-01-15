using System;
using System.Data;
using kutuphaneProjesi.DAL;

namespace kutuphaneProjesi.BLL
{
    public class kitaplarBLL
    {
        kitaplarDAL dal = new kitaplarDAL();

        public DataTable KitaplariGetir() => dal.KitaplariGetir();

        public void KitapEkleBLL(string ad, string yazar, int adet, string tur)
        {
            // Küçük bir kontrol ekleyelim
            if (!string.IsNullOrEmpty(ad) && !string.IsNullOrEmpty(yazar))
            {
                kitaplarDAL dal = new kitaplarDAL();
                dal.KitapEkle(ad, yazar, adet, tur);
            }
            else
            {
                throw new Exception("Kitap adı ve yazar boş bırakılamaz!");
            }
        }

        public void KitapEksilt(int id, int mevcutAdet)
        {
            if (mevcutAdet > 1)
                dal.KitapAdetGuncelle(id, -1);
            else
                dal.KitapTamamenSil(id); 
        }
    }
}