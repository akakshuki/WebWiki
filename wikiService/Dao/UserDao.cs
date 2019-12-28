using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wikiService.EF;
using wikiService.Models.ModelViewContract;

namespace wikiService.Dao
{
    public class UserDao
    {
        private DBWikiEntities db = null;
        public UserDao()
        {
            db = new DBWikiEntities();
        }

        public int Login(string email, string password)
        {
            try
            {
                var idUser = db.Users.Where(x => x.email == email && x.pwd == password).Select( x=> new
                {
                    ID = x.idUser,
                    Status = x.active
                }).SingleOrDefault();
                if (idUser != null && idUser.Status)
                {
                    return idUser.ID;
                }else if (idUser.Status == false)
                {
                    return -1;
                }else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }

        }

        public User CheckRole(int userContractId)
        {
            var result = db.Users.Find(userContractId);
            return result;
        }

        public bool CreateAccount(UserContract userContract)
        {
            var data = new User();
            data.nameUser = userContract.UserName;
            data.email = userContract.email;
            data.pwd = userContract.Password;
            data.idR = userContract.idR;
            data.active = true;

            db.Users.Add(data);
            try
            {
                if (db.SaveChanges()>0)
                {
                    return true;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

        }

        public bool CheckUserExist(string email)
        {
            var result = db.Users.SingleOrDefault(x => x.email == email);
            if (result != null)
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