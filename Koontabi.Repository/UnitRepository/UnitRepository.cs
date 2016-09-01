using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Koontabi.Domain;

namespace Koontabi.Repository.UnitRepository
{
    public class UnitRepository : IUnitRepository
    {
        public Unit Add(Unit entity)
        {
           using(var db = new KoontabiDBEntities())
            {
                try
                {
                    db.Database.BeginTransaction();
                    db.Units.Add(entity);
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
            using (var db = new KoontabiDBEntities())
            {
                try
                {
                    db.Database.BeginTransaction();
                    var objTemp = db.Units.Find(idEntity);
                    db.Entry(objTemp).State = System.Data.Entity.EntityState.Deleted;
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

        public Unit Find(int idEntity)
        {
            using (var db = new KoontabiDBEntities())
            {
                try
                {
                    var result = db.Units.Find(idEntity);
                    return result;
                }
                catch (Exception)
                {
                   
                    throw;
                }
            }
        }

        public IEnumerable<Unit> GetAll()
        {
            using(var db = new KoontabiDBEntities())
            {
                var result = db.Units.ToList();
                return result;
            }
        }

        public IEnumerable<Sp_GetUnits> Sp_GetUnits()
        {
            using(var db = new KoontabiDBEntities())
            {
                return db.Sp_GetUnits().ToList();
            }
        }

        public void Update(Unit entity)
        {
            using (var db = new KoontabiDBEntities())
            {
                try
                {
                    db.Database.BeginTransaction();
                    db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
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
    }
}
