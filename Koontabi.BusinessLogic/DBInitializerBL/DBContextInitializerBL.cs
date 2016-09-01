using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Koontabi.Repository.DBInitializer;
namespace Koontabi.BusinessLogic.DBInitializerBL
{
    public class DBContextInitializerBL
    {
        public void InitDb()
        {
            DBContextInitializer init = new DBContextInitializer();
            init.InitDb();

        }
    }
}
