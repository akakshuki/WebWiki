
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WikiManageWeb.Models.ModelsView;
using WikiManageWeb.WikiService;

namespace WikiManageWeb.Dao
{
    public class UserDao
    {
        private WikiService.DichVuWikiClient cl = null;
        public UserDao()
        {
            cl = new DichVuWikiClient();
        }
        //Dang nhap
        public int LoginAdmin(string email , string password)
        {
            var data = new WikiService.TaiKhoan();
            data.Email = email;
            data.MatKhau = password;
            var result = cl.DangNhap(data);
            return result;
        }
        //checkRole
        public UserMv CheckRoleUserById(int id)
        {
            var data = new WikiService.TaiKhoan();
            data.MaTaiKhoan = id;
            var user = new UserMv();
            var result = cl.KiemTraTaiKhoan(data);
            user.ID = result.MaTaiKhoan;
            user.UserName = result.TenTaiKhoan;
            user.active = result.TrangThai;
            user.idR = result.IDRole;
            return user;
        }
    }
}