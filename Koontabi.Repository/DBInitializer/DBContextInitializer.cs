using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Koontabi.Repository.DBInitializer
{
    public class DBContextInitializer
    {
        public void InitDb()
        {
            using(var db = new KoontabiDBEntities())
            {
                var result = from x in db.Bodegas
                             where x.BodegaID == 1
                             select x;
                result.FirstOrDefault();
            }
            
        }
    }
}
