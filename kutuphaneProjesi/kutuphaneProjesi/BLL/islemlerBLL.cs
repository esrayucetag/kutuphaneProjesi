using System.Data;
using kutuphaneProjesi.DAL;

namespace kutuphaneProjesi.BLL
{
    public class islemlerBLL
    {
        islemlerDAL islemDal = new islemlerDAL();
        public DataTable GetEnCokOkunanlar() => islemDal.RaporEnCokOkunanlar();
        public DataTable GetGecikenKitaplar() => islemDal.RaporGecikenKitaplar();
        public DataTable RaporPopulerKitaplar() => islemDal.GetEnCokOkunanlar();
        public DataTable RaporGecikenler() => islemDal.GetGecikenKitaplar();
        public DataTable UyeBul(string tc) => islemDal.TCIleUyeSorgula(tc);
        public DataTable IslemleriListele() => islemDal.AktifIslemleriGetir();
        public bool OduncVer(int uId, int kId, DateTime verilisTarihi)
        {
            return islemDal.OduncVer(uId, kId, verilisTarihi);
        }

        public DataTable KitaplariListele() => islemDal.KitaplariListele();

        public void TeslimAl(int islemId, int kitapId) => islemDal.TeslimAl(islemId, kitapId);
    }
}