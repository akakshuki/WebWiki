using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;

namespace wikiService.Models.ModelViewContract
{
    [DataContract(Name = "LichSuBinhLuan")]
    public class EditProductViewContract
    {
        [DataMember(Name = "MaBinhLuan")]
        public int ID { get; set; }
        [DataMember(Name = "MaBaiViet")]
        public int ProductId { get; set; }
        [DataMember(Name = "NoiDungBinhLuan")]
        public string Content { get; set; }
        [DataMember(Name = "NgayCapNhat")]
        public DateTime DateCreateEI { get; set; }
        [DataMember(Name = "MaNguoiDung")]
        public int UserID { get; set; }
        [DataMember(Name= "NguoiDung")]
        public UserContract User { get; set; }      

    }
}