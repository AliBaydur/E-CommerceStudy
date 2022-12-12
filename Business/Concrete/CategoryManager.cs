using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _category;

        public CategoryManager(ICategoryDal category)
        {
            _category = category;
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_category.GetAll());
        }

        public IDataResult<Category> GetById(int categoryId)
        {
           return new SuccessDataResult<Category>(_category.Get(c => c.CategoryId == categoryId));
        }
    }
}
