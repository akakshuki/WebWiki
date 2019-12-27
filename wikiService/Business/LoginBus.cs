﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopOnline.Common;
using wikiService.Dao;
using wikiService.Models.ModelViewContract;

namespace wikiService.Business
{
    public class LoginBus
    {
      
        public int UserLogin(UserContract userCaContract)
        {
            var email = userCaContract.email;
            var password = Encryptor.MD5Hash(Encryptor.Base64Hash(userCaContract.email) + Encryptor.Base64Hash(userCaContract.Password));
            var result = new UserDao().Login(email, password);
            return result;
        }

        public UserContract CheckRoleUser(UserContract userContract)
        {
            var userRole = new UserContract();
            var data = new UserDao().CheckRole(userContract.ID);
            userRole.ID = data.idUser;
            userRole.UserName = data.nameUser;
            userRole.email = data.email;
            userRole.idR = data.idR;
            
            return userRole;
        }
    }
}