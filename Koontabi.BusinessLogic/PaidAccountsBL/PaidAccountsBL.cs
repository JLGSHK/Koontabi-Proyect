using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Koontabi.Domain;
using Koontabi.Repository.PaidAccountsRepository;
using System.Linq.Expressions;

namespace Koontabi.BusinessLogic.PaidAccountsBL
{
    public class PaidAccountsBL : IPaidAccountsBL
    {
        private IPaidAccountsRepository _repository = null;
        public PaidAccountsBL()
        {
            this._repository = new PaidAccountsRepository();
        }
        public PaidAccount Add(PaidAccount entity)
        {
            throw new NotImplementedException();
        }

        public bool AddPaidAccountDetail(PaidAccountDetail _paidAccountDetail)
        {
            return this._repository.AddPaidAccountDetail(_paidAccountDetail);
        }

        public int CountAllInvoiceOverDue()
        {
            return this._repository.CountAllInvoiceOverDue();
        }

        public void Delete(int idEntity)
        {
            throw new NotImplementedException();
        }

        public PaidAccount Find(int idEntity)
        {
            throw new NotImplementedException();
        }

        public List<PaidAccount> FindPaidAccountByCondition
            (Expression<Func<PaidAccount, bool>> conditions)
        {
            return this._repository.FindPaidAccountByCondition(conditions);
        }

        public IEnumerable<PaidAccount> GetAll()
        {
            throw new NotImplementedException();
        }

        public object[] GetAllInvoiceOverDue()
        {
            return this._repository.GetAllInvoiceOverDue();
        }

        public List<PaidAccountDetail> ListPayAccountDetail(Expression<Func<PaidAccountDetail, bool>> conditions)
        {
            return this._repository.ListPayAccountDetail(conditions);
        }

        public bool SpValidateRefNumberInvoicePay(string refNumberInvoice)
        {
            return this._repository.SpValidateRefNumberInvoicePay(refNumberInvoice);
        }

        public void Update(PaidAccount entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateDayDelayAccounts()
        {
            this._repository.UpdateDayDelayAccounts();
        }

        public int? ValidateInvoiceOldByPay(int customerid, DateTime invoiceDateToValidate)
        {
            return this._repository.ValidateInvoiceOldByPay(customerid, invoiceDateToValidate);
        }
    }
}
