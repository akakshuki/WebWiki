using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wikiService.Business;
using wikiService.EF;
using wikiService.Models.ModelViewContract;
using wikiService.ModelViewContract;

namespace wikiService
{
    public class Responsetory
    {
        public List<CategoryContract> listCategories()
        {
            var data = new CategoryBus().ListCategories();
            return data;
        }

        public int LoginUser(UserContract userCaContract)
        {
            var result = new LoginBus().UserLogin(userCaContract);
            return result;
        }

        public UserContract CheckRoleUser(UserContract userContract)
        {
            var result = new LoginBus().CheckRoleUser(userContract);
            return result;

        }
    }
}