using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;

namespace WikiManageWeb.Models.AuthModelView
{

    public class AccountService
    {
        
        public int ID { get; set; }
        [Required(ErrorMessage = "Nhập tài khoản đăng kí")]
        [Display(Name = "Tài khoản")]
        public string Name { get; set; }
        [Display(Name = "Mật Khẩu")]
        [Required(ErrorMessage = "Nhập mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Chưa nhập xác minh mật khẩu")]
        [Display(Name = "Đặt lại Mật Khẩu")]
        [Compare("Password", ErrorMessage = "Mật khẩu không khớp")]
        public string ConfirmPassword { get; set; }
        [Display(Name = "Token")]
        public string Token { get; set; }
        [Display(Name = "Link")]
        public string Link { get; set; }
        [Display(Name = "Trạng thái")]
        public bool Active { get; set; }
        public int IDASR { get; set; }
        public AccountRole AccountRoleServiceContract { get; set; }
    }
}