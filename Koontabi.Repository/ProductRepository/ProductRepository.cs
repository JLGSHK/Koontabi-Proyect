using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Koontabi.Domain;
using System.Data.Entity;
using System.IO;

namespace Koontabi.Repository.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        public Product Add(Product entity)
        {
            using (var db = new KoontabiDBEntities())
            {
                db.Products.Add(entity);
                db.SaveChanges();
                return entity;
            }
        }

        public void Delete(int idEntity)
        {
            throw new NotImplementedException();
        }

        public Product Find(int idEntity)
        {
            //using(var db = new KoontabiDBEntities())
            //{
            //    var _productToToFind = db.Products.Include("ProductDetails")
            //                            .Include("Kardexes")
            //                            .Include("Unit")
            //                            .Include("Category")
            //                            .Where(x => x.ProductID == idEntity)
            //                            .Select(x=>x);
            //    return _productToToFind.FirstOrDefault();

            //}
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sp_GetAllProducts> SpGetAllProducts()
        {
            using (var db = new KoontabiDBEntities()) {
                return db.Sp_GetAllProducts().ToList();
                    
            }
        }

        public Sp_GetProductByID SpGetProductByID(int productID)
        {
            using (var db = new KoontabiDBEntities())
            {
                return db.Sp_GetProductByID(productID).FirstOrDefault();
            }
        }
        
        public void Update(Product entity)
        {
           
            using (var db = new KoontabiDBEntities())
            {
               
               db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
               foreach (var item in entity.ProductDetails) {
                   db.Entry(item).State = EntityState.Modified;
               }
               db.SaveChanges();
                
            }
        }

        public bool ValidateProductCodeIfExit(string productCode)
        {
            using(var db = new KoontabiDBEntities())
            {
                var result = db.Sp_ValidateProductCodeIfExit(productCode).FirstOrDefault();
                if(result != null)
                {
                    return result.Result == 1;
                }
                return false;
            }
        }




        public List<ProductToSearch> ProductToSearching()
        {
            try
            {
                using (var db = new KoontabiDBEntities())
                {
                    var result = from p in db.Products
                                 join pd in db.ProductDetails
                                 on p.ProductID equals pd.ProductID
                                 select new ProductToSearch()
                                 {
                                     ProductID = p.ProductID,
                                     ProductDetailID = pd.ProductDetailsID,
                                     ProductCode = p.ProductCode,
                                     ProductName = p.ProductName,
                                     UnitPrice1 = pd.UnitPrice1.HasValue? pd.UnitPrice1.Value : 0,
                                     UnitPrice2 = pd.UnitPrice2.HasValue ? pd.UnitPrice2.Value : 0,
                                     UnitPrice3 = pd.UnitPrice3.HasValue ? pd.UnitPrice2.Value : 0,
                                     Stock = pd.Stock

                                 };
                    return result.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int? GetStockByProductIDAndBodegaID(int productID, int bodegaID)
        {
            using (var db = new KoontabiDBEntities())
            {
                var stock = from pd in db.ProductDetails
                            where pd.ProductID == productID
                            where pd.BodegaID == bodegaID
                            select pd.Stock;
                return stock.First();
            }
                
        }

        public void UpdateStockByProductIDAndBodegaID(int stock, int productID, int bodegaID)
        {
            using (var db = new KoontabiDBEntities())
            {
                try
                {
                    db.Database.BeginTransaction();
                    var productTemp = (from pd in db.ProductDetails
                                       where pd.ProductID == productID
                                       where pd.BodegaID == bodegaID
                                       select pd).FirstOrDefault();
                    productTemp.Stock = stock;
                    db.Entry(productTemp).State = EntityState.Modified;
                    db.SaveChanges();
                    db.Database.CurrentTransaction.Commit();
                }
                catch (Exception)
                {
                    db.Database.CurrentTransaction.Rollback();
                    throw;
                }
            }
        }

        public Product GetProductByProductCode(string ProductCode)
        {
            using(var db = new KoontabiDBEntities())
            {
                try
                {
                    var productToSearch = db.Products.Include("ProductDetails").Include("ProductDetails.Kardexes").Where(x => x.ProductCode.Equals(ProductCode)).FirstOrDefault();
                    if(productToSearch != null)return productToSearch;

                    return null;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public IEnumerable<ProductInventory> ProductsInventory()
        {
            using (var db = new KoontabiDBEntities()) {
                var result = from p in db.Products
                             join pd in db.ProductDetails
                             on p.ProductID equals pd.ProductID
                             select new ProductInventory() {
                                 ProductCode = p.ProductCode,
                                 ProductName = p.ProductName,
                                 ProductCost = pd.ProductCost,
                                 UnitPrice1 = pd.UnitPrice1.HasValue?pd.UnitPrice1.Value:0,
                                 Stock = pd.Stock,
                                 InventoryValue = pd.Stock * pd.ProductCost,
                                 ValueSale = pd.Stock * (pd.UnitPrice1.HasValue ? pd.UnitPrice1.Value : 0),
                             };

                return result != null?result.ToList():null;
            }
        }
    }
}
