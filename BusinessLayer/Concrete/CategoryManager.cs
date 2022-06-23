﻿using BusinessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryServise
    {
        CategoryRepository categoryRepository = new CategoryRepository();
        public void CategoryAdd(Category category)
        {
            if(category.CategoryName!="" && category.CategoryDescription!="" && category.CategoryName.Length>=5 && category.CategoryStatus== true)
            {
                categoryRepository.AddCategory(category);
            }
            else
            {
                //hata mesajı ver.
            }
        }

        public void CategoryDelete(Category category)
        {
            throw new NotImplementedException();
        }

        public void CategoryUpdate(Category category)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
