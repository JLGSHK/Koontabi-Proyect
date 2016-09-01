using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Koontabi.Domain;
using System.Linq.Expressions;

namespace Koontabi.Repository.PaidAccountsRepository
{
    public class PaidAccountsRepository : IPaidAccountsRepository
    {
        
        public PaidAccount Add(PaidAccount entity)
        {
            throw new NotImplementedException();
        }

        public bool AddPaidAccountDetail(PaidAccountDetail _paidAccountDetail)
        {
            using (var db = new KoontabiDBEntities())
            {
                try
                {
                    db.Database.BeginTransaction();
                    db.PaidAccountDetails.Add(_paidAccountDetail);
                    var result = db.PaidAccounts.Find(_paidAccountDetail.PaidAccountID);
                    result.AmountPending -= _paidAccountDetail.Payment;
                    if(result.AmountPending == 0)
                    {
                       result.State =db.SP_GET_STATUS(2).FirstOrDefault().STATUS;
                       result.DayDelay = 0;
                    }
               
                    db.SaveChanges();
                    db.Database.CurrentTransaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    db.Database.CurrentTransaction.Rollback();
                    
                    throw;
                }
            }
        }

        public int CountAllInvoiceOverDue()
        {
            using (var db = new KoontabiDBEntities()) {

                return db.Database.SqlQuery<Int32>("EXEC dbo.Sp_CountAllInvoicesOverDue").FirstOrDefault();
            }
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
            using(var db = new KoontabiDBEntities())
            {
                var result = db.PaidAccounts.Include("Invoice")
                               .Include("Invoice.Customer")
                               .Where(conditions).Select(x=>x).ToList();
                return result;
            }
        }

        public IEnumerable<PaidAccount> GetAll()
        {
            throw new NotImplementedException();
        }

        public object[] GetAllInvoiceOverDue()
        {
            using (var db = new KoontabiDBEntities())
            {
                db.Database.ExecuteSqlCommand("Exec UpdateDayDelayInPaidAccounts");
                var result1 = db.Sp_GetAllInvoicesOverDue().ToList();
                var result2 = db.Sp_GetAllInvoicesDetailsOverDue().ToList();
                Object[] InvoiceOverDue = new Object[] { result1, result2 };
                return InvoiceOverDue;
            }
        }

        public List<PaidAccountDetail> ListPayAccountDetail(Expression<Func<PaidAccountDetail, bool>> conditions)
        {
            using (var db = new KoontabiDBEntities())
            {
                var result = db.PaidAccountDetails.Where(conditions).Select(x => x).ToList();
                return result;
            }
        }

        /// <summary>
        ///if refNumberInvoice exit return false and other way return true
        /// </summary>
        /// <param name="refNumberInvoice"></param>
        /// <returns>Bool</returns>
        public bool SpValidateRefNumberInvoicePay(string refNumberInvoice)
        {
           using(var db = new KoontabiDBEntities())
            {
                 return db.Sp_ValidateRefNumberInvoicePay(refNumberInvoice).FirstOrDefault().Result.Value;
            }
        }

        public void Update(PaidAccount entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateDayDelayAccounts()
        {
            using(var db = new KoontabiDBEntities())
            {
                db.Database.ExecuteSqlCommand("Exec UpdateDayDelayInPaidAccounts");
            }
        }

        public int? ValidateInvoiceOldByPay(int customerid, DateTime invoiceDateToValidate)
        {
            using(var db = new KoontabiDBEntities())
            {
                var result = db.Sp_ValidateInvoiceOldByPay(invoiceDateToValidate, customerid).FirstOrDefault();
                return  result != null?result.InvoiceNumber:0;
            }
        }
    }
}
