using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace wikiService.Models.ModelViewContract
{
    [DataContract (Name = "TaiKhoan")]
    public class UserContract
    {
        [DataMember (Name = "MaTaiKhoan")]
        public int ID { get; set; }
        [DataMember(Name = "TenTaiKhoan")]
        public string UserName { get; set; }
        [DataMember(Name = "Email")]
        public string email { get; set; }
        [DataMember(Name = "MatKhau")]
        public string Password { get; set; }
        [DataMember(Name = "TrangThai")]
        public bool active { get; set; }
        [DataMember(Name = "IDRole")]
        public int idR { get; set; }
    }
}