﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using wikiService.EF;
using wikiService.Models.ModelViewContract;
using wikiService.ModelViewContract;

namespace wikiService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "wikiService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select wikiService.svc or wikiService.svc.cs at the Solution Explorer and start debugging.
    public class wikiService : IwikiService
    {
        #region Category

        //Danh sach danh muc
       

        public IEnumerable<CategoryContract> ListCategory()
        {
            var listCate = new Responsetory().listCategories();
            return listCate;
        }
        //Them moi danh muc
        public bool CreateCategory(CategoryContract category)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region User

        public int Login(UserContract userCaContract)
        {
            var result = new Responsetory().LoginUser(userCaContract);
            return result;
        }

        public bool RegisterAdmin(UserContract userContract)
        {
            throw new NotImplementedException();
        }

        public UserContract CheckRoleUser(UserContract userContract)
        {
           var result = new Responsetory().CheckRoleUser(userContract);
           return result;
        }
        #endregion
    }
}
