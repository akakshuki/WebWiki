using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using wikiService.Dao;
using wikiService.Models.ModelViewContract;

namespace wikiService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AuthService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AuthService.svc or AuthService.svc.cs at the Solution Explorer and start debugging.
    public class AuthService : IAuthService
    {

        public List<ProductViewContract> ProductSearchByName(string name, string token)
        {
            if (new PartnerDao().CheckToken(token))
            {
                return new Responsetory().SearchProduct(name);
            }
            else
            {
                return null;
            }
        }
        public ProductViewContract GetContemProductById(int id, string token)
        {
            if (new PartnerDao().CheckToken(token))
            {
                return new Responsetory().GetDetailProductClientById(id);
            }
            else
            {
                return null;
            }

        }

    }
}
