using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Koontabi.Domain;
using System.Data.Entity;
using System.Data.Entity.Validation;
using Koontabi.Helpers;


namespace Koontabi.Repository.CustomerRepository
{
   
    public class CustomerRepository : ICustomerRepository
    {
        public CustomerRepository()
        {
            Database.SetInitializer<KoontabiDBEntities>(null);
        }

        public Customer Add(Customer entity)
        {
            using (var db = new KoontabiDBEntities())
            {
                db.Customers.Add(entity);
                db.SaveChanges();
                return entity;
            }
        }

        public void Delete(int idEntity)
        {
            using (var db = new KoontabiDBEntities())
            {
                try
                {

                    var tempCustomer = db.Customers.Find(idEntity);
                    
                    if(tempCustomer.Invoices.Count > 0)
                    {
                        throw new Exception("No puede eliminar este cliente.");
                    }
                    db.Entry(tempCustomer).State = EntityState.Deleted;
                    //tempCustomer.State = CustomerState.ELIMINADO;
                    db.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        public List<sp_GetAllCustomerRadGridShowData> FillGridView()
        {

            using (var db = new KoontabiDBEntities())
            {

                return db.sp_GetAllCustomerRadGridShowData().ToList();
            }
        }

        public Customer Find(int idEntity)
        {
            using(var db = new KoontabiDBEntities())
            {
                return db.Customers.Find(idEntity);
            }
        }

        public IEnumerable<Customer> GetAll()
        {
            using(var db = new KoontabiDBEntities())
            {
                var result = from c in db.Customers
                             select c;
                return result.ToList();
            }
        }

        public void Update(Customer entity)
        {
            using (var db = new KoontabiDBEntities())
            {
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }


        public bool IsExitCustomerCode(string customerCode)
        {
            using (var db = new KoontabiDBEntities())
            {
                var result = db.sp_ExitCustomerCode(customerCode).FirstOrDefault();
                return result.Code == 1;
            }
        }


        public List<Sp_GetCustomerByParam> GetCustomerByParam(string param)
        {
            using (var db = new KoontabiDBEntities())
            {
                var result = db.Sp_GetCustomerByParam(param).ToList();
                return result;
            }
        }


        public List<Sp_GetCustomerByParam> Sp_GetAllCustomerToSearch()
        {
            using (var db = new KoontabiDBEntities())
            {
                var result = (from c in db.Customers
                             join p in db.Provinces
                             on c.ProvinceID equals p.ProvinceID
                             join m in db.Municipalities
                             on c.MunicipalityID equals m.MunicipalityID
                             select new{
                                 CustomerID=c.CustomerID,
                                 CustomerCode=c.CustomerCode,
                                 CompanyName=c.CompanyName,
                                 ContactName=c.ContactName,
                                 Address1 = c.Address1,
                                 Phone1= c.Phone1,
                                 Province = p.Name,
                                 Municipality = m.Name
                             });
                List<Sp_GetCustomerByParam> list = new List<Sp_GetCustomerByParam>();
                foreach(var c in result.ToList()){
                    list.Add(new Sp_GetCustomerByParam() {
                        CustomerID = c.CustomerID,
                        CustomerCode = c.CustomerCode,
                        CompanyName = c.CompanyName,
                        ContactName = c.ContactName,
                        Address1 = c.Address1,
                        Phone1 = c.Phone1,
                        Province = c.Province,
                        Municipality = c.Municipality
                    
                    });
                }
                return list;
            }
        }

        public string GetLastCustomerCode()
        {
            using (var db = new KoontabiDBEntities())
            {
                return db.Sp_GetLastCustomerCode().FirstOrDefault().CustomerCode;
            }
        }

        public bool IsExitCustomerDocumentID(string customerDocumentID)
        {
            using (var db = new KoontabiDBEntities()) {
                try
                {
                    db.Database.BeginTransaction();
                    var result = (from c in db.Customers
                                  where c.DocumentID == customerDocumentID
                                  select c).Count();

                    db.Database.CurrentTransaction.Commit();
                    return result == 1;
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
