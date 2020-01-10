using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Web;
using wikiService.Business;
using wikiService.Dao;
using wikiService.EF;
using wikiService.Models.ModelViewContract;
using wikiService.Models.ServicepartnerContract;


namespace wikiService
{
    public class Responsetory
    {

        #region user

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

        public bool AdminRegister(UserContract userContract)
        {
            return new LoginBus().Register(userContract);
        }

        public bool RegisterUser(UserContract userContract)
        {
            return new LoginBus().RegisterClient(userContract);
        }

        public bool CheckUserExist(string email)
        {
            return new UserDao().CheckUserExist(email);
        }
        #endregion

        #region category

        public List<CategoryContract> listCategories()
        {
            var data = new CategoryBus().ListCategories();
            return data;

        }
        public bool checkCategoryExist(string categoryName)
        {
            return new CategoryBus().CheckCategoryExist(categoryName);
        }

        public CategoryContract GetDetailCategory(int idCategory)
        {
            return new CategoryBus().GetDetailCategory(idCategory);
        }

        public bool EditCategory(CategoryContract category)
        {
            return new CategoryBus().EditCategory(category);
        }

        public bool DeleteCategory(int id)
        {
            return new CategoryDao().DeleteCategory(id);
        }
        public bool CreateCategory(CategoryContract category)
        {
            return new CategoryBus().CreateCategory(category);
        }
        #endregion
        
        #region product

        public IEnumerable<ProductViewContract> GetAllListProduct()
        {
            return new ProductBus().getAllListProduct();
        }

        public bool checkProductTitleExist(string title)
        {
            return new ProductBus().CheckProductTitleExist(title);
        }

        public bool CreateNewProduct(ProductViewContract product)
        {
            return new ProductBus().CreateProduct(product);
        }

        public ProductViewContract GetDetailProductById(int id)
        {
            return new ProductBus().GetDetailProductById(id);
        }
        public bool DeleteProduct(int id)
        {
            return new ProductBus().DeleteProduct(id);
        }

        public bool EditProduct(ProductViewContract product)
        {
            return new ProductBus().EditProduct(product);
        }
        public IEnumerable<ProductViewContract> GetAllLisProuctByCate(int idCate)
        {
            return new ProductBus().GetListProductByCateId(idCate);
        }

        public IEnumerable<ProductViewContract> GetProductListClientView()
        {
            return new ProductBus().GetListProductClientView();
        }
        public ProductViewContract GetDetailProductClientById(int id)
        {
            return  new ProductBus().getContentById(id);
        }


        public bool LetUserComment(EditProductViewContract editProduct)
        {
            return new ProductBus().LetUserComment(editProduct);
        }

        public bool DeleteComment(int id)
        {
            return new ProductBus().DeleteComment(id);
        }

        #endregion


        public bool CreateNewPartner(AccountServiceContract account)
        {
            return  new PartnerBus().CreaterNewPartner(account);
        }

        public List<UserContract> listUserAdmin()
        {
          return  new LoginBus().UserAdminAccounts();
        }

        public List<UserContract> listUser()
        {
            return new LoginBus().UserAccounts();
        }

        public UserContract GetUserProfile(int id)
        {
           return new LoginBus().GetProfileUser(id);
        }

        public List<ProductViewContract> SearchProduct(string name)
        {
            return  new ProductBus().SearchProduct(name);
        }

        public IEnumerable<AccountRoleServiceContract> GetListPartnerRole()
        {
         return  new PartnerBus().GetPartnerRole();
        }
    }
}