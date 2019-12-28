using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WikiManageWeb.Models.ModelsView
{
    public class UserMv
    {
        [Display (Name = "Mã tài khoản") ]
        public int ID { get; set; }
        [Display(Name = "Tên tài khoản")]
        public string UserName { get; set; }
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Mật Khẩu")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage = "Mật khẩu không khớp")]
        public string Password1 { get; set; }
        [Display(Name = "Trạng thái")]
        public bool active { get; set; }
        [Display(Name = "Mã Quyền")]
        public int idR { get; set; }
    }
}