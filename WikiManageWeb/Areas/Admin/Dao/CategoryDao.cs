using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WikiManageWeb.Models.ModelsView;
using WikiManageWeb.WikiService;

namespace WikiManageWeb.Dao
{
    public class CategoryDao
    {
        private WikiService.DichVuWikiClient cl = null;

        public CategoryDao()
        {
            cl = new DichVuWikiClient();
        }

        public List<CategoryMv> ListCate()
        {
            var data = cl.DanhSachDanhMuc().Select(x=> new CategoryMv
            {
                ID = x.MaDanhMuc,
                Name = x.TenDanhMuc

            }).ToList();
            return data;
        }
    }
}