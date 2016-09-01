using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Koontabi.Domain;
using System.Linq.Expressions;

namespace Koontabi.Repository.ReportRepository
{
    public interface IReportRepository
    {
        IEnumerable<V_DisplayAllSales> DisplayAllSalesToReport(DateTime initDate, DateTime endDate);
        IEnumerable<GetAllZoneProvince> GetAllZone();
        IEnumerable<V_DisplayAllInvoicesByZone> DisplayAllInvoiceByZone(String zone);
        IEnumerable<V_DisplayAllSales> DisplayAllInvoiceByMonth(int initMonth,int year,int endMonth = 0);
        IEnumerable<V_DisplayAllInvoicesByZone> DisplayAllSalesByCustomer(Expression<Func<V_DisplayAllInvoicesByZone,bool>> conditions,bool AllSalesAllCustomer = false);

    }
}
