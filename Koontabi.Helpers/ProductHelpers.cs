using Koontabi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.Helpers
{
    public static class ProductHelpers
    {
        public static Product ConvertToProduct(this Sp_GetProductByID currentObject)
        {
            var product = Product.CreateNewInstance();
            product.ProductID = currentObject.ProductID;
            product.ProductCode = currentObject.ProductCode;
            product.ProductName = currentObject.ProductName;
            product.Description = currentObject.Description;
            product.CategoryID = currentObject.CategoryID;
            product.UnitID = currentObject.UnitID;
            product.State = currentObject.State;
            product.InvoiceWithoutStock = currentObject.InvoiceWithoutStock;
            product.InvoiceWithPrice = currentObject.InvoiceWithPrice;

            ProductDetail pd = ProductDetail.CreateNewInstance();
            pd.ProductDetailsID = currentObject.ProductDetailsID;
            pd.ProductID = product.ProductID;
            pd.UnitPrice1 = currentObject.UnitPrice1;
            pd.UnitPrice2 = currentObject.UnitPrice2;
            pd.UnitPrice3 = currentObject.UnitPrice3;
            pd.ProductCost = currentObject.ProductCost;
            pd.BodegaID = currentObject.BodegaID;
            pd.TaxID = currentObject.TaxID;
            pd.Stock = currentObject.Stock;
            

            Kardex kardex = Kardex.CreateNewInstance();
            kardex.KardexID = currentObject.KardexID;
            kardex.KardexIn = currentObject.KardexIn;

            pd.Kardexes.Add(kardex);
            
            product.ProductDetails.Add(pd);


            return product;
        }
    }
}
