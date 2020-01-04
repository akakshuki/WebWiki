using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace wikiService.Models.ServicepartnerContract
{
    [DataContract(Name = "QuyenPartner")]
    public class AccountRoleServiceContract
    {
        [DataMember(Name = "MaQuyen")]
        public int ID { get; set; }
        [DataMember(Name = "TenQuyen")]
        public string Name { get; set; }
        [DataMember(Name = "TrangThai")]
        public bool Active { get; set; }


        [DataMember (Name = "DanhSachCacAccountpartner")]
        public List<AccountServiceContract> AccountContracts { get; set; }
        [DataMember(Name = "DanhSachCacOperationContract")]
        public List<DataContractServiceRole> DataContracts { get; set; }
    }
}