
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WikiManageWeb.Models.ModelsView;
using WikiManageWeb.WikiService;
using WikiManageWeb.Common;



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
        public int LoginAdmin(string email, string password)
        {
            try
            {
                var data = new TaiKhoan();
                data.Email = email;
                data.MatKhau = Encryptor.MD5Hash(Encryptor.Base64Hash(email) + Encryptor.Base64Hash(password));
                var result = cl.DangNhap(data);
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }
        public int LoginClient(UserMv user)
        {
            try
            {
                var data = new TaiKhoan()
                {
                    Email = user.Email,
                    MatKhau = Encryptor.MD5Hash(Encryptor.Base64Hash(user.Email) + Encryptor.Base64Hash(user.Password))
                };
                return cl.DangNhap(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
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

        public bool RegisterAdminAccount(UserMv user)
        {
            var data = new WikiService.TaiKhoan();
            data.TenTaiKhoan = user.UserName;
            data.Email = user.Email;
            data.MatKhau = Encryptor.MD5Hash(Encryptor.Base64Hash(user.Email) + Encryptor.Base64Hash(user.Password));
            var result = cl.DangKiTaiKhoanAdmin(data);
            return result;
        }

        public bool CheckEmailUser(string userEmail)
        {
            return cl.KiemTraiTaiKhoanDatontai(userEmail);
        }

        public bool RegisterClientAccount(UserMv user)
        {
            var data = new WikiService.TaiKhoan()
            {
                TenTaiKhoan = user.UserName,
                Email = user.Email,
                MatKhau = Encryptor.MD5Hash(Encryptor.Base64Hash(user.Email) + Encryptor.Base64Hash(user.Password)
                )
            };

            var result = cl.DangKiTaiKhoanUser(data);
            return result;
        }

        public List<UserMv> ListUserAccount()
        {
            return cl.DanhSachTaiKhoan().Select(x=>new UserMv
            {
                ID = x.MaTaiKhoan,
                UserName = x.TenTaiKhoan,
                Email = x.Email,
                ProductCount = x.SoBaiViet,
                EditProductCount = x.SoBinhLuan,
                active = x.TrangThai

            }).ToList();
        }
        public List<UserMv> ListAdminAccount()
        {
            return cl.DanhSachTaiKhoanAdmin().Select(x => new UserMv
            {
                ID = x.MaTaiKhoan,
                UserName = x.TenTaiKhoan,
                Email = x.Email,
                ProductCount = x.SoBaiViet,
                EditProductCount = x.SoBinhLuan,
                active = x.TrangThai

            }).ToList();
        }

        public UserMv GetUserProfile(int id)
        {
            var x = cl.ThongTinTaiKhoan(id);
            return  new UserMv()
            {
                ID = x.MaTaiKhoan,
                UserName = x.TenTaiKhoan,
                Email = x.Email,
                ProductCount = x.SoBaiViet,
                EditProductCount = x.SoBinhLuan,
                ProductViews= x.DanhSachBaiVietKhac.Select(e=>new ProductMv()
                {
                    ID = e.MaBaiViet,
                    Title = e.TieuDe
                }).ToList()

            };
        }
    }
}