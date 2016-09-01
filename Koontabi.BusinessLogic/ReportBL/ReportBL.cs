using Koontabi.Repository.ReportRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Koontabi.Repository;
using Koontabi.Domain;
using System.Linq.Expressions;

namespace Koontabi.BusinessLogic.ReportBL
{
    public class ReportBL : IReportBL
    {
        private IReportRepository _repository = null;

        public ReportBL() {
            this._repository = new ReportRepository();
        }
        public IEnumerable<V_DisplayAllSales> DisplayAllSalesToReport(DateTime initDate, DateTime endDate)
        {
            return this._repository.DisplayAllSalesToReport(initDate, endDate);
        }


        public IEnumerable<GetAllZoneProvince> GetAllZone()
        {
            return this._repository.GetAllZone();
        }


        public IEnumerable<V_DisplayAllInvoicesByZone> DisplayAllInvoiceByZone(string zone)
        {
            return this._repository.DisplayAllInvoiceByZone(zone);
        }

        public IEnumerable<V_DisplayAllSales> DisplayAllInvoiceByMonth(int initMonth, int year, int endMonth = 0)
        {
            return this._repository.DisplayAllInvoiceByMonth(initMonth, year, endMonth);
        }

        public IEnumerable<V_DisplayAllInvoicesByZone> DisplayAllSalesByCustomer(Expression<Func<V_DisplayAllInvoicesByZone, bool>> conditions, bool AllSalesAllCustomer = false)
        {
            return this._repository.DisplayAllSalesByCustomer(conditions,AllSalesAllCustomer);
        }
    }
}
