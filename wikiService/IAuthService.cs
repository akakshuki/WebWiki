using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using wikiService.Models.ModelViewContract;

namespace wikiService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAuthService" in both code and config file together.
    [ServiceContract(Name = "KiemSoatPartner")]
    public interface IAuthService
    {
      
        [OperationContract(Name = "TimBaiVietTheoTen")]
        List<ProductViewContract> ProductSearchByName(string name , string token );

        [OperationContract(Name = "NoiDungBaiVietClient")]
        ProductViewContract GetContemProductById(int id, string token);
    }
}
