using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wikiService.Dao;
using wikiService.Models.ModelViewContract;


namespace wikiService.Business
{
    public class CategoryBus
    {
        public List<CategoryContract> ListCategories()
        {
            var data = new CategoryDao().CetAllListCategory()
                .Select(x=> new CategoryContract
                {
                    ID =x.idCate,
                    Name = x.nameCate,
                    ProductCount = x.Information.Where(k=>k.hideInfo).Count()
                }).ToList();
            return data;
        }

        public bool CheckCategoryExist(string categoryName)
        {
          return  new CategoryDao().CheckCategoryExist(categoryName);
        }

        public CategoryContract GetDetailCategory(int idCategory)
        {
            var newCategory = new CategoryContract();
            var result = new CategoryDao().GetDetailCategories(idCategory);
            newCategory.ID = result.idCate;
            newCategory.Name = result.nameCate;
            return newCategory;
        }

        public bool CreateCategory(CategoryContract category)
        {
            var result = new CategoryDao().CreateNewCategory(category);
            return result;

        }

        public bool EditCategory(CategoryContract category)
        {
          var result = new CategoryDao().EditCategory(category);
          return result;
        }
    }
}