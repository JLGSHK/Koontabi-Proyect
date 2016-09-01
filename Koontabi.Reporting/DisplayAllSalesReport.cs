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
    /// Summary description for DisplayAllSalesReport.
    /// </summary>
    public partial class DisplayAllSalesReport : Telerik.Reporting.Report
    {
        public DisplayAllSalesReport()
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
    }
}