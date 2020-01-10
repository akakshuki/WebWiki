using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WikiManageWeb.Models.AuthModelView
{
   
    public class AccountRole
    {
        [Display(Name = "Mã")]
        public int ID { get; set; }
        [Display(Name = "Tên bậc")]
        public string Name { get; set; }
        [Display(Name = "Trạng thái")]
        public bool Active { get; set; }
        public List<AccountService> AccountContracts { get; set; } 
        public List<DataContract> DataContracts { get; set; }
    }
}