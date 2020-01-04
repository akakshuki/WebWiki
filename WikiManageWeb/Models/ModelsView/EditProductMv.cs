using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WikiManageWeb.Models.ModelsView
{
    public class EditProductMv
    {
        public int ID { get; set; }
        public int ProductId { get; set; }
        public string Content { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime dayCreateEI { get; set; }
        public int UserID { get; set; }
        public UserMv User { get; set; }
    }
}