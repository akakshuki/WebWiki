using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wikiService.Models.ServicepartnerContract;

namespace wikiService.Dao
{
    public class PartnerBus
    {
        public bool CreaterNewPartner(AccountServiceContract account) {
            return  new PartnerDao().CreateNewPartner(account);
        }
    }
}