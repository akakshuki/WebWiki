using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;

namespace wikiService.Models.ServicepartnerContract
{
    [DataContract (Name = "QuanLiCacOperationContract")]
    public class DataContractServiceRole
    {
        [DataMember (Name = "MaQuanLi")]
        public int ID { get; set; }
        [DataMember(Name = "TenOperationContrac")]
        public string OperationName { get; set; }
        [DataMember(Name="MaQuyen")]
        public int IDASR { get; set; }
        [DataMember (Name = "QuyenCuaPartner")]
        public AccountRoleServiceContract AccountRoleServiceContract { get; set; }
    }
}