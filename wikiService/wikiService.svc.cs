using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using wikiService.EF;
using wikiService.Models.ModelViewContract;
using wikiService.Models.ServicepartnerContract;


namespace wikiService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "wikiService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select wikiService.svc or wikiService.svc.cs at the Solution Explorer and start debugging.
    public class wikiService : IwikiService
    {

        #region Product

        public IEnumerable<ProductViewContract> ListAllProduct()
        {
            return new Responsetory().GetAllListProduct();
        }

        public IEnumerable<ProductViewContract> ListAllProductSeen()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductViewContract> ListAllProductUnseen()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductViewContract> ListAllProductClientView()
        {
            return  new Responsetory().GetProductListClientView();
        }

        public IEnumerable<ProductViewContract> ListAllProductByCategory(int idCate)
        {
            return new Responsetory().GetAllLisProuctByCate(idCate);
        }

        public bool CheckTitleExist(string title)
        {
            return new Responsetory().checkProductTitleExist(title);
        }

        public bool CreateNewProduct(ProductViewContract product)
        {
            return  new Responsetory().CreateNewProduct(product);
        }

        public ProductViewContract DetaiContract(int id)
        {
            return new Responsetory().GetDetailProductById(id);
        }

        public ProductViewContract GetContemProductById(int id)
        {
           return  new Responsetory().GetDetailProductClientById(id);
        }


        public bool EditProduct(ProductViewContract product)
        {
            return  new Responsetory().EditProduct(product);
        }

        public bool UpdateProduct(ProductViewContract product)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProduct(int id)
        {
           return new Responsetory().DeleteProduct(id);
        }

        public List<ProductViewContract> ProductSearchByName(string name)
        {
            return new Responsetory().SearchProduct(name);
        }

        public bool CommentProductByClient(EditProductViewContract editProduct)
        {
            return new Responsetory().LetUserComment(editProduct);
        }

        public bool DeleteComment(int id)
        {
            return new Responsetory().DeleteComment(id);
        }

       

        #endregion


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
            return new Responsetory().checkCategoryExist(categoryName);
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
            return new Responsetory().DeleteCategory(id);
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
           
            var result = new Responsetory().AdminRegister(userContract);
            return result;
        }

        public bool RegisterUser(UserContract userContract)
        {
            return new Responsetory().RegisterUser(userContract);
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

        public UserContract UserProfile(int id)
        {
            return new Responsetory().GetUserProfile(id);
        }


        public List<UserContract> ListUserAdmin()
        {
            return new Responsetory().listUserAdmin();
        }
        public List<UserContract> ListUser()
        {
          return  new Responsetory().listUser();
            
        }


        #endregion

        #region partner





        public bool CreatePartner(AccountServiceContract account)
        {
            return new Responsetory().CreateNewPartner(account);
        }

     

        #endregion
    }
}
