using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;

namespace WikiManageWeb.Models.AuthModelView
{

    public class DataContract
    {

        public int ID { get; set; }
        public string OperationName { get; set; }
        public int IDASR { get; set; }
        public AccountRole AccountRoleServiceContract { get; set; }
    }
}