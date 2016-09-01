namespace Koontabi.Reporting
{
    using Helpers;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;
    using System.Linq;
    using Domain;
    using BusinessLogic.InvoiceBL;

    /// <summary>
    /// Summary description for InvoiceReport.
    /// </summary>
    public partial class InvoiceReport : Telerik.Reporting.Report
    {
        
        public InvoiceReport()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();
        }

        
        
        public static String GetInvoiceNumberWithFormat(int InvoiceNumber)
        {
            return InvoiceNumber.GetInvoiceNumberExt();
        }

        public static String getFormatCustomer(params string[] name)
        {
            /*
            
            0-CustomerCompanyName
            1-CustomerCustomerCode
            2-CustomerContactName
            3-CustomerPhone1
            4-CustomerCellPhone
            5-CustomerAddress1
            6-CustomerAddress2
            7-MunicipalityOfCustomer
            8-ProvinceOfCustomer
            9-CustomerBusinessRegistration
            10-CustomerEmail
            11-CustomerTaxRegistration
            */



            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("{0} ({1})", name[0],name[1]))
              .AppendLine(name[2])
              .AppendLine(String.Format("Tel.:{0:(###)###-####} Cel.:{1}", name[3],name[4]))
              .AppendLine(String.Format("{0} {1}",name[5],name[6]))
              .AppendLine(String.Format("{0} / {1}",name[7],name[8]))
              .AppendLine(String.Format("{0}",name[9]))
              .AppendLine(String.Format("{0}", name[10]))
              .AppendLine(String.Format("{0}", name[11]));
            Console.WriteLine("Output getFormatCustomer()");
            Console.WriteLine(sb.ToString());
            return sb.ToString(); ;
        }

        public static String GetInvoiceDate(DateTime date)
        {
            return String.Format("{0:dd/MM/yyyy}",date);
        }

        public static Decimal GetITBIS(Decimal valor, Nullable<decimal> TaxValue)
        {
            Decimal CalITBIS = 0;
            if (TaxValue.HasValue)
            {
                CalITBIS = valor * TaxValue.Value / 100;
            }
            
            
            return CalITBIS;
        }

    }
}