using Koontabi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.BusinessLogic.CategoryBL
{
    public interface ICategoryBL : IGenericBL<Category>
    {
        IEnumerable<Sp_GetAllCategories> GetAllCategories();
        IEnumerable<Sp_GetCategories> GetCategories();
        bool ExitCategoryCode(string code,bool isEditCode = false);
    }
}
