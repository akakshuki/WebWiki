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

            }).OrderByDescending(x=>x.ID).ToList();
            return data;
        }

        public bool checkExistCategory(string categoryName)
        {
            var result = cl.KiemTraDanhMucDaTonTai(categoryName);
            return result;
        }

        public bool CreateNewCategory(CategoryMv category)
        {
            var data = new DanhMuc();
            data.TenDanhMuc = category.Name;
            var result = cl.ThemMoiDanhMuc(data);
            return result;
        }

        public CategoryMv getCategoryDetail(int id)
        {
            var result = new CategoryMv();
            var data = cl.ChitTietDanhMuc(id);
            result.Name = data.TenDanhMuc;
            return result;
        }

        public bool EditCategory(CategoryMv category)
        {
            var data =new DanhMuc();
            data.TenDanhMuc = category.Name;
            data.MaDanhMuc = category.ID;
            return cl.SuaDanhMuc(data);
        }

        public bool DeleteCategory(int id)
        {
            return cl.XoaDanhMuc(id);
        }
    }
}