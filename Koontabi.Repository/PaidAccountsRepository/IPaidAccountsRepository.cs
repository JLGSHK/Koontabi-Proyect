using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Koontabi.Domain;
using System.Linq.Expressions;

namespace Koontabi.Repository.PaidAccountsRepository
{
    public interface IPaidAccountsRepository : IGenericRepository<PaidAccount>
    {
        List<PaidAccount> FindPaidAccountByCondition
            (Expression<Func<PaidAccount, bool>> conditions);
        bool AddPaidAccountDetail(PaidAccountDetail _paidAccountDetail);
        void UpdateDayDelayAccounts();
        bool SpValidateRefNumberInvoicePay(string refNumberInvoice);
        List<PaidAccountDetail> ListPayAccountDetail(Expression<Func<PaidAccountDetail, bool>> conditions);
        Nullable<Int32> ValidateInvoiceOldByPay(Int32 customerid, DateTime invoiceDateToValidate);
        Object[] GetAllInvoiceOverDue();
        Int32 CountAllInvoiceOverDue();


    }
}
