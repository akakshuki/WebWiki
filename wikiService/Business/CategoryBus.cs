using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wikiService.Dao;
using wikiService.ModelViewContract;

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
                    Name = x.nameCate
                }).ToList();
            return data;
        }
    }
}