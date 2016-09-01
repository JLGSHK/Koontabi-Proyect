using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using Koontabi.Domain;
using System.Linq.Expressions;

namespace Koontabi.Repository.ReportRepository
{
    public class ReportRepository : IReportRepository
    {
        public IEnumerable<V_DisplayAllSales> DisplayAllSalesToReport(DateTime initDate, DateTime endDate)
        {

            using (var db = new KoontabiDBEntities())
            {
                var result = from x in db.V_DisplayAllSales
                             where DbFunctions.TruncateTime(x.InvoiceDate) >= initDate
                             where DbFunctions.TruncateTime(x.InvoiceDate) <= endDate
                             select x;
                return result.ToList();
            }
        }


        public IEnumerable<GetAllZoneProvince> GetAllZone()
        {
            using (var db = new KoontabiDBEntities())
            {
                var result = from zone in db.GetAllZoneProvince()
                             select zone;
                return result.ToList();
            }
        }


        public IEnumerable<V_DisplayAllInvoicesByZone> DisplayAllInvoiceByZone(string zone)
        {
            using (var db = new KoontabiDBEntities()) {
                
                if (zone.Equals("TODAS"))
                {
                    var result = from z in db.V_DisplayAllInvoicesByZone
                                 orderby z.Province
                                 select z ;
                    return result.ToList();
                }
                else {
                    var result = from z in db.V_DisplayAllInvoicesByZone
                                 where z.Zone == zone
                                 orderby z.Province
                                 select z;
                    return result.ToList();
                }
              
            }
        }

        public IEnumerable<V_DisplayAllSales> DisplayAllInvoiceByMonth(int initMonth, int year, int endMonth = 0)
        {
            using (var db = new KoontabiDBEntities())
            {
                if (endMonth != 0)
                {
                    var result = from m in db.V_DisplayAllSales
                                 where DbFunctions.TruncateTime(m.InvoiceDate).Value.Month >= initMonth
                                 && DbFunctions.TruncateTime(m.InvoiceDate).Value.Month <= endMonth
                                 && DbFunctions.TruncateTime(m.InvoiceDate).Value.Year == year
                                 select m;
                    return result.ToList();
                }
                else
                {
                    var result = from m in db.V_DisplayAllSales
                                 where DbFunctions.TruncateTime(m.InvoiceDate).Value.Month == initMonth
                                 && DbFunctions.TruncateTime(m.InvoiceDate).Value.Year == year
                                 select m;

                    
                    return result.ToList();
                }
            }
        }

        public IEnumerable<V_DisplayAllInvoicesByZone> DisplayAllSalesByCustomer(Expression<Func<V_DisplayAllInvoicesByZone, bool>> conditions, bool AllSalesAllCustomer=false)
        {
            using(var db = new KoontabiDBEntities())
            {
                if (AllSalesAllCustomer)
                {
                    return db.V_DisplayAllInvoicesByZone.ToList();
                }
                else
                {
                    return db.V_DisplayAllInvoicesByZone.Where(conditions).ToList();
                }
            }
        }
    }
}
