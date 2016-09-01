namespace Koontabi.Reporting
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;
    using Koontabi.Helpers;
    /// <summary>
    /// Summary description for DisplayAllInvoicesByZoneReport.
    /// </summary>
    public partial class DisplayAllInvoicesByZoneReport : Telerik.Reporting.Report
    {
        public DisplayAllInvoicesByZoneReport()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        public static String GetInvoiceNumberFormat(Int32 invoiceNumber)
        {
            return invoiceNumber.GetInvoiceNumberExt();
        }

        public static String GetStatus(String stateInvoice)
        {
            if (stateInvoice == null)
            {
                return "EFECTIVO";
            }
            else {
                return stateInvoice;
            }
        }
    }
}