using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Koontabi.Domain;
using Koontabi.Repository.InvoiceRepository;

namespace Koontabi.BusinessLogic.InvoiceBL
{
    public class InvoiceBL : IInvoiceBL
    {
        private IInvoiceRepository _repository;
        public InvoiceBL()
        {
            this._repository = new InvoiceRepository();
        }
        public Invoice Add(Invoice entity)
        {
            return this._repository.Add(entity);
        }

        public void Delete(int idEntity)
        {
            throw new NotImplementedException();
        }

        

        public Invoice Find(int idEntity)
        {
            return this._repository.Find(idEntity);
        }

        public IEnumerable<GetInvoiceByIDView> FindInvoiceToReport(Expression<Func<GetInvoiceByIDView, bool>> specification)
        {
            return this._repository.FindInvoiceToReport(specification);
        }

        public IEnumerable<Invoice> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool isExitReferenceInvoice(string refenceInvoice)
        {
            return this._repository.isExitReferenceInvoice(refenceInvoice);
        }

        public int? SpGetLastInvoiceNumber()
        {
            return this._repository.SpGetLastInvoiceNumber();
        }

        public void Update(Invoice entity)
        {
            this._repository.Update(entity);
        }

        public void Update(Invoice invoice, ICollection<InvoiceDetail> collectionToAddNew)
        {
            this._repository.Update(invoice, collectionToAddNew);
        }

        public IEnumerable<V_DisplayAllInvoices> VDisplayAllInvoices()
        {
            return this._repository.VDisplayAllInvoices();
        }
    }
}
