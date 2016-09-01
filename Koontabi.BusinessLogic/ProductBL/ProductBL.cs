using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Koontabi.Domain;
using Koontabi.Repository.ProductRepository;

namespace Koontabi.BusinessLogic.ProductBL
{
    public class ProductBL : IProductBL
    {
        private IProductRepository _repository;
        public ProductBL()
        {
            this._repository = new ProductRepository();
        }
        public Product Add(Product entity)
        {
           return _repository.Add(entity);
        }

        public void Delete(int idEntity)
        {
            throw new NotImplementedException();
        }

        public Product Find(int idEntity)
        {
            //return this._repository.Find(idEntity);
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sp_GetAllProducts> SpGetAllProducts()
        {
            return this._repository.SpGetAllProducts();
        }

        public Sp_GetProductByID SpGetProductByID(int productID)
        {
            return this._repository.SpGetProductByID(productID);
        }

        public void Update(Product entity)
        {
            this._repository.Update(entity);
        }

        public bool ValidateProductCodeIfExit(string productCode)
        {
            return _repository.ValidateProductCodeIfExit(productCode);
        }


        public List<ProductToSearch> ProductToSearching()
        {
            return _repository.ProductToSearching();
        }

        public int? GetStockByProductIDAndBodegaID(int productID, int bodegaID)
        {
            return this._repository.GetStockByProductIDAndBodegaID(productID, bodegaID);
        }

        public void UpdateStockByProductIDAndBodegaID(int stock, int productID, int bodegaID)
        {
            this._repository.UpdateStockByProductIDAndBodegaID(stock, productID, bodegaID);
        }

        public Product GetProductByProductCode(string ProductCode)
        {
            return this._repository.GetProductByProductCode(ProductCode);
        }

        public IEnumerable<ProductInventory> ProductsInventory()
        {
            return this._repository.ProductsInventory();
        }
    }
}
