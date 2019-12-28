using System;
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
            return new Responsetory().CreateCategory(category);
        }
        //kiem tra danh muc
        public bool CheckCategoryExist(string categoryName)
        {
            return  new Responsetory().checkCategoryExist(categoryName);
        }
        //chi tiet danh muc
        public CategoryContract DetailCategory(int idCategory)
        {
            return new Responsetory().GetDetailCategory(idCategory);
        }
        //sua danh muc
        public bool EditCategory(CategoryContract category)
        {
           return new Responsetory().EditCategory(category);
        }
        //xoa danh muc
        public bool DeleteCategory(int id)
        {
            return  new Responsetory().DeleteCategory(id);
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
            userContract.idR = 1;
            var result = new Responsetory().AdminRegister(userContract);
            return result;
        }

        public bool checkEmaiilUser(string email)
        {
            return new Responsetory().CheckUserExist(email);
        }

        public UserContract CheckRoleUser(UserContract userContract)
        {
           var result = new Responsetory().CheckRoleUser(userContract);
           return result;
        }
        #endregion
    }
}
