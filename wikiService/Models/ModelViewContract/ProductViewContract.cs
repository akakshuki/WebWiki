using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using wikiService.Models.ModelViewContract;

namespace wikiService.Models.ModelViewContract
{
    [DataContract(Name = "BaiViet")]
    public class ProductViewContract
    {
        [DataMember(Name = "MaBaiViet")]
        public int ID { get; set; }
        [DataMember(Name = "TieuDe")]
        public string Title { get; set; }
        [DataMember(Name = "NoiDung")]
        public string Content { get; set; }
        [DataMember(Name = "NgayTao")]
        public DateTime DateCreate { get; set; }
        [DataMember(Name = "MaNguoiDung")]
        public int UserId { get; set; }
        [DataMember(Name = "TenNguoiDung")]
        public string UserName { get; set; }
        [DataMember(Name = "NguoiDung")]
        public UserContract User { get; set; }
        [DataMember(Name = "MaDanhMuc")]
        public int CateId { get; set; }
        [DataMember(Name = "TenDanhMuc")]
        public string CategoryName { get; set; }
        [DataMember(Name = "DanhMuc")]
        public CategoryContract Category { get; set; }
        [DataMember(Name = "TrangThai")]
        public bool hideInfo { get; set; }

        [DataMember(Name = "BinhLuan")]
        public EditProductViewContract EditProductViewContract { get; set; }
        [DataMember(Name = "DanhSachBinhLuan")]
        public IEnumerable<EditProductViewContract> EditProductViewContracts { get; set; }
    }
}