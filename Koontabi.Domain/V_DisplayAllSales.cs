//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Koontabi.Domain
{
    
    
    using System;
    using System.Collections.Generic;
    
    public partial class V_DisplayAllSales
    {
        public int InvoiceID { get; set; }
        public int InvoiceNumber { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public string CompanyName { get; set; }
        public string TypeOfP { get; set; }
        public Nullable<double> DisCount { get; set; }
        public Nullable<decimal> ITBIS { get; set; }
        public Nullable<decimal> SubTotal { get; set; }
        public string Status { get; set; }
    }
}
