using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WikiManageWeb.Models.ModelsView
{
    public partial class CategoryMv
    {
        
        public int ID { get; set; }
        [Display(Name = "Tên danh mục")]
        [Required(ErrorMessage = "Điền đủ thông tin ")]
        public string Name { get; set; }
        public int ProductCount { get; set; }
    }
}