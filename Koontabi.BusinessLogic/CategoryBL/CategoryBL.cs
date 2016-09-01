using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Koontabi.Domain;
using Koontabi.Repository.CategoryRepository;

namespace Koontabi.BusinessLogic.CategoryBL
{
    public class CategoryBL : ICategoryBL
    {
        private ICategoryRepository _repository;

        public CategoryBL()
        {
            _repository = new CategoryRepository();
        }

        public Category Add(Category entity)
        {
            return this._repository.Add(entity);
        }

        public void Delete(int idEntity)
        {
            this._repository.Delete(idEntity);
        }

        public bool ExitCategoryCode(string code, bool isEditCode = false)
        {
            return this._repository.ExitCategoryCode(code, isEditCode);
        }

        public Category Find(int idEntity)
        {
            return this._repository.Find(idEntity);
        }

        public IEnumerable<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sp_GetAllCategories> GetAllCategories()
        {
            return _repository.GetAllCategories();
        }

        public IEnumerable<Sp_GetCategories> GetCategories()
        {
            return _repository.GetCategories();
        }

        public void Update(Category entity)
        {
            this._repository.Update(entity);
        }
    }
}
