using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Koontabi.Repository
{
    public abstract class MainRepository<T> where T:class
    {
        //CREATE CRUD
       
        public MainRepository()
        {
            
        }

        //Create
        public virtual void Add(T t) {
            using (var myContext = new KoontabiDBEntities())
            {
                myContext.Entry(t).State = System.Data.Entity.EntityState.Added;
                myContext.SaveChanges();
                
               
            }
                
        }
        //Read
        public virtual T Find(Expression<Func<T, bool>> specification)
        {
            using (var myContext = new KoontabiDBEntities())
            {
                var objectContext = ((IObjectContextAdapter)myContext).ObjectContext;
                return objectContext.CreateObjectSet<T>().FirstOrDefault(specification);

            }
        }
        //Update
        public virtual void Update(T t)
        {
            using (var myContext = new KoontabiDBEntities())
            {
                myContext.Entry(t).State = System.Data.Entity.EntityState.Unchanged;
                myContext.Entry(t).State = System.Data.Entity.EntityState.Modified;
                myContext.SaveChanges();
            }
        }
        //Delete
        public void Delete(T t)
        {
            using (var myContext = new KoontabiDBEntities())
            {
                var objectContext = ((IObjectContextAdapter)myContext).ObjectContext;
                objectContext.DeleteObject(t);

            }
        }

        //Get All
        public virtual IEnumerable<T> GetAll() {

            using (var myContext = new KoontabiDBEntities())
            {
                var objectContext = ((IObjectContextAdapter)myContext).ObjectContext;
                return objectContext.CreateObjectSet<T>().ToList();

            }  
        }
        
        
    }

}
