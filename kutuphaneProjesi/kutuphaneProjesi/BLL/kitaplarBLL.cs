using System;
using System.Data;
using kutuphaneProjesi.DAL;

namespace kutuphaneProjesi.BLL
{
    public class kitaplarBLL
    {
        private readonly kitaplarDAL dal = new kitaplarDAL();

        public DataTable KitaplariGetir() => dal.KitaplariGetir();

        public DataTable KitapAra(string arama)
        {
            if (string.IsNullOrWhiteSpace(arama))
                return dal.KitaplariGetir();

            return dal.KitapAra(arama.Trim());
        }

        public void KitapEkleBLL(string ad, string yazar, int adet, string tur)
        {
            if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(yazar))
                throw new Exception("Kitap adı ve yazar boş bırakılamaz!");

            if (adet <= 0)
                throw new Exception("Adet 0'dan büyük olmalı!");

            dal.KitapEkle(ad.Trim(), yazar.Trim(), adet, (tur ?? "").Trim());
        }
        public void KitapTamamenSil(int id)
        {
            dal.KitapTamamenSil(id);
        }
        public void KitapAdetDusur(int id, int mevcutAdet, int dusulecek)
        {
            if (dusulecek <= 0) return;

            if (mevcutAdet > dusulecek)
                dal.KitapAdetGuncelle(id, -dusulecek);
            else
                dal.KitapTamamenSil(id);
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
