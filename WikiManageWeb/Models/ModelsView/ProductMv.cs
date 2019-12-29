using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WikiManageWeb.Models.ModelsView
{
    public class ProductMv
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateCreate { get; set; }
        public int UserId { get; set; }
        public UserMv user { get; set; }
        public int CateId { get; set; }
        public CategoryMv Category { get; set; }
        public bool hideInfo { get; set; }

        public EditProductMv EditProductViewContract { get; set; }
        public List<EditProductMv> EditProductViewContracts { get; set; }
    }
}