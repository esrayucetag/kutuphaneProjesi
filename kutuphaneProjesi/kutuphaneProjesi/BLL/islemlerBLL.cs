using System;
using System.Data;
using kutuphaneProjesi.DAL;

namespace kutuphaneProjesi.BLL
{
    public class islemlerBLL
    {
        private readonly islemlerDAL dal = new islemlerDAL();


        public DataTable UyeBul(string tc) => dal.TCIleUyeSorgula(tc);
        public DataTable IslemleriListele() => dal.AktifIslemleriGetir();
        public DataTable KitaplariListele() => dal.KitaplariListele();

    
        public bool OduncVer(int uId, int kId, DateTime verilisTarihi)
            => dal.OduncVer(uId, kId, verilisTarihi);

        public void TeslimAl(int islemId, int kitapId)
            => dal.TeslimAl(islemId, kitapId);

        public int AktifOduncSayisi(int uId) => dal.AktifOduncSayisi(uId);

   
        public (int karaListe, int gecikmeSayisi) UyeDurumGetir(int uId)
            => dal.UyeDurumGetir(uId);


        public DataTable RaporEnCokOkunanlar() => dal.RaporEnCokOkunanlar();
        public DataTable RaporGecikenKitaplar() => dal.RaporGecikenKitaplar();

        public DataTable RaporPopulerKitaplar() => RaporEnCokOkunanlar();
        public DataTable RaporGecikenler() => RaporGecikenKitaplar();

        public DataTable GetEnCokOkunanlar() => RaporEnCokOkunanlar();
        public DataTable GetGecikenKitaplar() => RaporGecikenKitaplar();
    }
}
