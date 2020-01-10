using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wikiService.Common;
using wikiService.Models.ServicepartnerContract;

namespace wikiService.Dao
{
    public class PartnerBus
    {
        public bool CreaterNewPartner(AccountServiceContract account)
        {
            account.Token = TokenGenerator.Generate(64);
            return  new PartnerDao().CreateNewPartner(account);
        }

        public IEnumerable<AccountRoleServiceContract> GetPartnerRole()
        {
            return  new PartnerDao().GetListPartnerRole();
        }
    }
}