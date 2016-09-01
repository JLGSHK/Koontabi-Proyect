using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Koontabi.Domain;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;

namespace Koontabi.Repository.InvoiceRepository
{
    public class InvoiceRepository : IInvoiceRepository
    {
        public Invoice Add(Invoice entity)
        {
            using(var db = new KoontabiDBEntities())
            {
                try
                {
                    db.Database.BeginTransaction();
                    db.Invoices.Add(entity);

                    if(entity.TypeOfPayID == 2)
                    {
                        decimal subtotal = 0;
                        decimal discount = 0;
                        decimal itbis = 0;
                        foreach(var item in entity.InvoiceDetails)
                        {
                            subtotal += item.Quantity * item.UnitPrice;
                        }
                        if (entity.DisCount.HasValue)
                        {
                            discount = ((decimal)entity.DisCount.Value * 100) * subtotal / 100;
                        }
                        if (entity.TaxID.HasValue)
                        {
                            Tax t = db.Taxes.Find(entity.TaxID.Value);
                            itbis = (t.TaxValue * subtotal) / 100;
                        }
                        subtotal -= discount;
                        subtotal += itbis;

                        PaidAccount p = new PaidAccount();
                        p.InvoiceID = entity.InvoiceID;
                        p.DateEmit = entity.InvoiceDate;
                        p.ExpirationDate = entity.ExpirationInvoiceDate;
                        p.Amount = subtotal;
                        p.AmountPending = subtotal;
                        p.DayDelay = Convert.ToInt32((entity.InvoiceDate - entity.ExpirationInvoiceDate).TotalDays);
                        p.State = db.SP_GET_STATUS(1).FirstOrDefault().STATUS;

                        db.PaidAccounts.Add(p);

                             
                    }

                   
                    db.SaveChanges();

                    db.Database.CurrentTransaction.Commit();
                    return new Invoice() {InvoiceID = entity.InvoiceID};
                }
                catch (Exception)
                {
                    db.Database.CurrentTransaction.Rollback();
                    throw;
                }
               
            }
        }

        public void Delete(int idEntity)
        {
            throw new NotImplementedException();
        }

       

        public Invoice Find(int idEntity)
        {
            using(var db = new KoontabiDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = true;

                var r = db.Invoices.Include("Bodega")
                                   .Include("Customer")
                                   .Include("Employee")
                                   .Include("InvoiceDetails")
                                   .Include("Tax")
                                   .Include("TypeOfPay")
                                   .Include("InvoiceDetails.Kardex")
                                   .Include("Customer.Municipality")
                                   .Include("Customer.Province")
                                   .Include("InvoiceDetails.Kardex.ProductDetail.Product")
                                   .Where(x => x.InvoiceID == idEntity)
                                   .Select(p=> p).FirstOrDefault();   
                return r;
            }
        }

        public IEnumerable<GetInvoiceByIDView> FindInvoiceToReport(Expression<Func<GetInvoiceByIDView, bool>> specification)
        {
            using (var db = new KoontabiDBEntities())
            {
                var result = db.GetInvoiceByIDViews.Where(specification).ToList();
                return result;
            }
        }

        public IEnumerable<Invoice> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool isExitReferenceInvoice(string refenceInvoice)
        {
            using(var db = new KoontabiDBEntities())
            {
                var _referenceInvoice = db.SpValidateIfExitRefenceInvoice(refenceInvoice).FirstOrDefault();
                return _referenceInvoice != null? _referenceInvoice.ReferenceInvoice ==1:false;
            }
        }

        public Nullable<Int32> SpGetLastInvoiceNumber()
        {
            using(var db = new KoontabiDBEntities())
            {
                return db.Sp_GetLastInvoiceNumber().FirstOrDefault().InvoiceNumber;
            }
        }

        public void Update(Invoice entity)
        {
            try
            {
                using (var db = new KoontabiDBEntities())
                {
                    db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Invoice invoice, ICollection<InvoiceDetail> collectionToAddNew)
        {
            using (var db = new KoontabiDBEntities())
            {
                try
            {
                    db.Database.BeginTransaction();
                    var objectContext = ((IObjectContextAdapter)db).ObjectContext;
                    db.Entry(invoice).State = System.Data.Entity.EntityState.Unchanged;
                    //Delete al details and kardex from collectionToDelete
                    foreach(var item in invoice.InvoiceDetails.ToList())
                    {
                        /*
                            Eliminando la linea del Kardex y 
                            el detalle de la factura

                        Nota: 
                        */
                        
                        objectContext.DeleteObject(item.Kardex);
                        objectContext.DeleteObject(item);
                    }
                    
                    foreach(var itemToAdd in collectionToAddNew)
                    {
                        invoice.InvoiceDetails.Add(itemToAdd);
                    }

                    db.Entry(invoice).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    db.Database.CurrentTransaction.Commit();
                
            }
            catch (Exception)
            {
                    db.Database.CurrentTransaction.Rollback();
                throw;
            }
            }
        }

        public Task<IEnumerable<V_DisplayAllInvoices>> VDisplayAllInvoices()
        {
            
           /* using (var db = new KoontabiDBEntities())
            {

                return db.V_DisplayAllInvoices.ToList();
            }*/

        }
    }
}
