using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.ModelBinding;
using wikiService.EF;
using wikiService.ModelViewContract;

namespace wikiService.Dao
{
    public class CategoryDao
    {
        private DBWikiEntities db = null;

        public CategoryDao()
        {
            db = new DBWikiEntities();
        }

        public List<Category> CetAllListCategory()
        {
            var data = db.Categories.ToList();
            return data;
        }

        public bool CreateCategory(CategoryContract category)
        {
            var data = new Category();
            data.nameCate = category.Name;

            if (db.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Category GetDetailCategories(int idCategory)
        {
            return db.Categories.Find(idCategory);
        }

        public bool CheckCategoryExist(string categoryName)
        {
            var result = db.Categories.SingleOrDefault(x => x.nameCate == categoryName);
            if (result != null)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CreateNewCategory(CategoryContract category)
        { 
            var data = new Category();
            data.nameCate = category.Name;
            db.Categories.Add(data);
            try
            {
                if (db.SaveChanges()>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool EditCategory(CategoryContract category)
        {
            var data = db.Categories.Find(category.ID);
            data.nameCate = category.Name;
            if (db.SaveChanges()>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteCategory(int id)
        {
            var data = db.Categories.Find(id);
            db.Categories.Remove(data);
            try
            {
                if (db.SaveChanges()>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}