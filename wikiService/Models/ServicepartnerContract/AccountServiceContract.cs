using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;

namespace wikiService.Models.ServicepartnerContract
{
    [DataContract (Name = "TaiKhoanPartner")]
    public class AccountServiceContract
    {
        [DataMember (Name = "MaTaiKhoan")]
        public int ID { get; set; }
        [DataMember(Name = "TenDangNhap")]
        public string Name { get; set; }
        [DataMember(Name = "MatKhau")]
        public string Password { get; set; }
        [DataMember(Name = "MaToken")]
        public string Token { get; set; }
        [DataMember(Name = "Link")]
        public string Link { get; set; }
        [DataMember(Name = "TrangThai")]
        public bool Active { get; set; }

        [DataMember(Name = "MaQuyenPartner")]
        public int IDASR { get; set; }
        [DataMember(Name = "QuyenCuaPartner")]
        public AccountRoleServiceContract AccountRoleServiceContract { get; set; }
    }
}