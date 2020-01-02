using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WikiManageWeb.Models.ModelsView
{
    public class UserMv
    {
        [Display(Name = "Mã tài khoản")]
        public int ID { get; set; }
        [Display(Name = "Tên tài khoản")]
        [Required(ErrorMessage = "Nhập tên tài khoản")]
        public string UserName { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Nhập Email đăng nhập")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Mật Khẩu")]
        [Required(ErrorMessage = "Nhập mật khẩu")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Chưa nhập xác minh mật khẩu")]
        [Display(Name = "Đặt lại Mật Khẩu")]
        [Compare("Password", ErrorMessage = "Mật khẩu không khớp")]
        public string ConfirmPassword { get; set; }
        [Display(Name = "Trạng thái")]
        public bool active { get; set; }
        [Display(Name = "Mã Quyền")]
        public int idR { get; set; }



        public List<ProductMv> ProductViewContracts { get; set; }
        public List<EditProductMv> EditProductViewContracts { get; set; }
    }
}