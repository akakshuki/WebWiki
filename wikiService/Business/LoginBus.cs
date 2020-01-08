using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.Xml;
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
            var password =userCaContract.Password;
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

        public bool Register(UserContract userContract)
        {
            userContract.idR = 1;
            var result = new UserDao().CreateAccount(userContract);
            return result;

        }

        public bool RegisterClient(UserContract userContract)
        {
            userContract.idR = 2;
            var result = new UserDao().CreateAccount(userContract);
            return result;
        }

        public List<UserContract> UserAccounts()
        {
            var data = new UserDao().GetListUserAccounts();
            return data.Select(x=>new UserContract
            {
                ID = x.idUser,
                UserName = x.nameUser,
                email = x.email,
                ProductCount = x.Information.Count,
                EditProductCount = x.EditInfoes.Count,
                active = x.active
                
                
            }).ToList();
        }

        public List<UserContract> UserAdminAccounts()
        {
            var data = new UserDao().GetListAdminAccounts();
            return data.Select(x => new UserContract
            {
                ID = x.idUser,
                UserName = x.nameUser,
                email = x.email,
                ProductCount = x.Information.Count,
                EditProductCount = x.EditInfoes.Count,
                active = x.active


            }).ToList();

            
        }

        public UserContract GetProfileUser(int id)
        {
           var data = new UserDao().GetUserProfileById(id);
           return  new UserContract()
           {
               ID = data.idUser,
               UserName = data.nameUser,
               ProductCount = data.Information.Count,
               EditProductCount = data.EditInfoes.Count,
               ProductViewContracts = data.Information.Select(x=> new ProductViewContract()
               {
                   ID = x.idInfor,
                   Title = x.titleInfo
               }).ToList(),
               email = data.email
               
           };
        }
    }
}