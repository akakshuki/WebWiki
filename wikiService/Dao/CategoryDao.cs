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
      private  DBWikiEntities db = null;

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

            if (db.SaveChanges()>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}