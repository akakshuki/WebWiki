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
        private MangeServiceEntities db = null;

        public PartnerDao()
        {
            db = new MangeServiceEntities();
        }


        public bool CreateNewPartner(AccountServiceContract accountRole)
        {
            try
            {
                var data = new AccountService()
                {
                    Name = accountRole.Name,
                    Password = accountRole.Password,
                    IDASR = accountRole.IDASR,
                    Token = accountRole.Token,
                    Active = true
           
               
                };
                db.AccountServices.Add(data);
                    if (db.SaveChanges() > 0 )
                {
                    return true;
                }
                else
                {
                    return false;
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public IEnumerable<AccountRoleServiceContract> GetListPartnerRole()
        {
            var list = db.AccountServiceRoles.Select(x=>new AccountRoleServiceContract()
            {
                ID = x.ID,
                Name = x.Name
            }).ToList();
            return list;
        }

        public AccountServiceContract GetPartnerLogin(AccountServiceContract account)
        {
            var data = db.AccountServices.Where(x => x.Name == account.Name && x.Password == account.Password)
                .SingleOrDefault();
            var res = new AccountServiceContract()
            {
                ID = data.ID,
                Name = data.Name,
               Token = data.Token,
               Link = "http://localhost:60198/AuthService.svc"
            };
            return res;
        }

        public bool CheckToken(string token)
        {
            if (db.AccountServices.Where(x=>x.Token == token).Count() > 0 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}