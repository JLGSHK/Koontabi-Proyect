using Koontabi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.Helpers
{
    public static class InvoiceHelpers
    {
        public static int? GetInvoiceNumberWithRemoveAllFirstZero(this String invoiceNumber)
        {
            return null;
        }
        public static String GetInvoiceNumberExt(this int invoiceNumber)
        {
            if (invoiceNumber >= 1 && invoiceNumber <= 9)
            {
                return string.Format("000{0}", invoiceNumber);
            }
            else if (invoiceNumber >= 10 && invoiceNumber <= 99)
            {
                return string.Format("00{0}", invoiceNumber);
            }
            else if (invoiceNumber >= 100 && invoiceNumber <= 999)
            {
                return string.Format("0{0}", invoiceNumber);
            }
            else
            {
                return string.Format("{0}", invoiceNumber);
            }
        }
       
    }
}
