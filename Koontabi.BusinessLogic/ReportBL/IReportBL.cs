using Koontabi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Koontabi.BusinessLogic.ReportBL
{
    public interface IReportBL
    {
        IEnumerable<V_DisplayAllSales> DisplayAllSalesToReport(DateTime initDate, DateTime endDate);
        IEnumerable<GetAllZoneProvince> GetAllZone();
        IEnumerable<V_DisplayAllInvoicesByZone> DisplayAllInvoiceByZone(string zone);
        IEnumerable<V_DisplayAllSales> DisplayAllInvoiceByMonth(int initMonth, int year, int endMonth = 0);
        IEnumerable<V_DisplayAllInvoicesByZone> DisplayAllSalesByCustomer(Expression<Func<V_DisplayAllInvoicesByZone, bool>> conditions, bool AllSalesAllCustomer = false);

    }
}
