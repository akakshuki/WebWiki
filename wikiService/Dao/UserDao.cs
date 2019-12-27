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
    }
}