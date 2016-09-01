using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Koontabi.Domain;

namespace Koontabi.Repository.KardexRepository
{
    public class KardexRepository : IKardexRepository
    {
        public int AddKardex(Kardex _k)
        {
            using(var db = new KoontabiDBEntities())
            {
                var tempKardexID = db.Kardexes.Add(_k).KardexID;
                db.SaveChanges();
                return tempKardexID;
            }
        }

        public IEnumerable<KardexGridModel> GetAllKardexGridModel(string productCode,int bodegaID)
        {
            using(var db = new KoontabiDBEntities())
            {
                var result = from k in db.Kardexes
                             join pd in db.ProductDetails
                             on k.ProductDetailsID equals pd.ProductDetailsID
                             join p in db.Products
                             on pd.ProductID equals p.ProductID
                             join ivd in db.InvoiceDetails
                             on k.KardexID equals ivd.KardexID into LeftJoined
                             from ivd in LeftJoined.DefaultIfEmpty()
                             join iv in db.Invoices
                             on ivd.InvoiceID equals iv.InvoiceID into LeftJoined2
                             from iv in LeftJoined2.DefaultIfEmpty()
                             where p.ProductCode.Equals(productCode)
                             where pd.BodegaID == bodegaID
                             select new KardexGridModel() {
                                 RegisterDate = k.RegisterDate,
                                 TypeOfMove = k.TypeOfMove,
                                 ProductCode = p.ProductCode,
                                 ProductName = p.ProductName,
                                 KardexIn = (Int32)k.KardexIn,
                                 KardexOut = (Int32)k.KardexOut,
                                 KardexStock = (Int32)k.KardexStock   
                             };

                return result.ToList<KardexGridModel>().OrderByDescending(x=>x.RegisterDate);
            }
        }
    }
}
