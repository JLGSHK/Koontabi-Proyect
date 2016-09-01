using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Koontabi.Domain;

namespace Koontabi.Repository.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        public Category Add(Category entity)
        {
            using(var db = new KoontabiDBEntities())
            {
                try
                {
                    db.Database.BeginTransaction();
                    db.Categories.Add(entity);
                    db.SaveChanges();
                    db.Database.CurrentTransaction.Commit();
                    return entity;
                }
                catch (Exception)
                {

                    db.Database.CurrentTransaction.Rollback();
                    throw;
                }
            }
        }

        public void Delete(int idEntity)
        {
            using (var db = new KoontabiDBEntities()) {

                try
                {
                    db.Database.BeginTransaction();
                    var currentObj = db.Categories.Find(idEntity);
                    if(currentObj != null)
                    {
                        db.Entry(currentObj).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("No existe categoria");
                    }
                    db.Database.CurrentTransaction.Commit();
                }
                catch (Exception)
                {
                    db.Database.CurrentTransaction.Rollback();
                    throw;
                }
            }
            
        }

        public bool ExitCategoryCode(string code, bool isEditCode = false)
        {
            try
            {
                using (var db = new KoontabiDBEntities())
                {
                    if (isEditCode)
                    {
                        return false;

                    }
                    else
                    {
                        var result = from c in db.Categories
                                     where c.CategoryCode.Equals(code)
                                     select true;
                        return result.FirstOrDefault();
                    }
                   
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Category Find(int idEntity)
        {
            try
            {
                using(var db = new KoontabiDBEntities()) {
                    var resultEntity = db.Categories.Where(x => x.CategoryID == idEntity).FirstOrDefault();
                    return resultEntity;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sp_GetAllCategories> GetAllCategories()
        {
            using(var db = new KoontabiDBEntities())
            {
                return db.Sp_GetAllCategories().ToList();
            }
        }

        public IEnumerable<Sp_GetCategories> GetCategories()
        {
            using (var db = new KoontabiDBEntities())
            {
                return db.Sp_GetCategories().ToList();
            }
        }

        public void Update(Category entity)
        {
            try
            {
                using(var db = new KoontabiDBEntities()) {
                    db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
