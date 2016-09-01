using Koontabi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.BusinessLogic.InvoiceBL
{
    public interface IInvoiceBL : IGenericBL<Invoice>
    {
        Nullable<Int32> SpGetLastInvoiceNumber();
        IEnumerable<V_DisplayAllInvoices> VDisplayAllInvoices();
        bool isExitReferenceInvoice(String refenceInvoice);
        void Update(Invoice invoice, ICollection<InvoiceDetail> collectionToAddNew);
        IEnumerable<GetInvoiceByIDView> FindInvoiceToReport(Expression<Func<GetInvoiceByIDView, bool>> specification);
    }
}
