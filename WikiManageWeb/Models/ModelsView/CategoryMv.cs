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
        [Display(Name = "Danh Muc")]
        public string Name { get; set; }
    }
}