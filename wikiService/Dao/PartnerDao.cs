using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using wikiService.EF;
using wikiService.Models.ServicepartnerContract;

namespace wikiService.Dao
{
    public class PartnerDao
    {
        private ConcurrencyCheckAttributeConvention db = null;

        public PartnerDao()
        {
            db = new ConcurrencyCheckAttributeConvention();
        }


        public bool CreateNewPartner(AccountServiceContract accountRole)
        {
           var data = new AccountService()
           {
               Name = accountRole.Name,
               Password = accountRole.Password,
               IDASR = accountRole.AccountRoleServiceContract.ID,
               Token = accountRole.Token,
               
               
           };
           return false;
        }
    }
}