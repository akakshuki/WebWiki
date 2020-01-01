using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace wikiService.Models.ModelViewContract
{
    [DataContract (Name = "DanhMuc")]
    public class CategoryContract
    {
        [DataMember (Name = "MaDanhMuc")] public int ID { get; set; }   
        [DataMember (Name = "TenDanhMuc")] public string Name { get; set; }
        [DataMember(Name="SoSanpham")]
        public int ProductCount { get; set; }

    }   
}