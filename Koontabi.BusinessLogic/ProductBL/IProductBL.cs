using Koontabi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.BusinessLogic.ProductBL
{
    public interface IProductBL : IGenericBL<Product>
    {
        bool ValidateProductCodeIfExit(string productCode);
        IEnumerable<Sp_GetAllProducts> SpGetAllProducts();
        Sp_GetProductByID SpGetProductByID(int productID);
        List<ProductToSearch> ProductToSearching();
        Nullable<Int32> GetStockByProductIDAndBodegaID(int productID, int bodegaID);
        void UpdateStockByProductIDAndBodegaID(int stock, int productID, int bodegaID);
        Product GetProductByProductCode(String ProductCode);
        IEnumerable<ProductInventory> ProductsInventory();
    }
}
