using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WikiManageWeb.Models.AuthModelView;
using WikiManageWeb.WikiService;

namespace WikiManageWeb.Dao
{
    public class PartnerDao
    {
        private DichVuWikiClient cl = null;

        public PartnerDao()
        {
            cl = new DichVuWikiClient();
        }

        public bool Create( AccountService account )
        {
            var value = cl.ThemMoiPartner(new TaiKhoanPartner()
            {
                TenDangNhap = account.Name,
                MatKhau =  account.Password,
                MaQuyenPartner = account.IDASR
            });
            return value;
        }

        public List<AccountRole> GetListRolePartner()
        {
            var res = cl.DanhSachServiceRole().Select(x=> new AccountRole()
            {
                ID = x.MaQuyen,
                Name = x.TenQuyen,
                
            }).ToList();
            return res;
        }
        public AccountService GetPartnerLogin(AccountService account)
        {
            var data = new TaiKhoanPartner()
            {
                TenDangNhap = account.Name,
                MatKhau =  account.Password
            };
            var res = cl.PartnerLogin(data);
            
            return new AccountService()
            {
                ID = res.MaTaiKhoan,
                Name = res.TenDangNhap,
                Active = res.TrangThai,
                Token = res.MaToken,
                Link = res.Link
                
            };
        }
    }
}