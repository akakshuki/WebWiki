using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WikiManageWeb.Models.ModelsView
{
    public class ProductMv
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Phải có tiêu đề")]
        [Display(Name="Tiêu đề")]
        public string Title { get; set; }
        [Required (ErrorMessage = "Hãy điền đủ nội dung")]
        [Display(Name = "Nội dung")]
        [AllowHtml]
        public string Content { get; set; }
        public DateTime DateCreate { get; set; }
        public int UserId { get; set; }
        [Display(Name = "Tác giả")]
        public string UserName { get; set; }
        public UserMv user { get; set; }
        [Required(ErrorMessage = "Hãy chọn Danh mục")]
        public int CateId { get; set; }
        [Display(Name = "Tên danh mục")]
        public string CateName { get; set; }
        public CategoryMv Category { get; set; }
        public bool hideInfo { get; set; }
        public EditProductMv EditProductView { get; set; }
        public int EditProductViewCount { get; set; }
        public List<EditProductMv> EditProductViews { get; set; }
    }
}