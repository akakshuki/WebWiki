using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wikiService.Dao;
using wikiService.EF;
using wikiService.Models.ModelViewContract;

namespace wikiService.Business
{
    public class ProductBus
    {
        public IEnumerable<ProductViewContract> getAllListProduct()
        {
            var result = new ProductDao().GetAllListProduct().Select(x => new ProductViewContract
            {
                ID = x.idInfor,
                Title = x.titleInfo,
                CateId = x.idCate,
                UserId = x.idUser,
                UserName = x.User.nameUser,
                User = new UserContract() { ID = x.idUser, UserName = x.User.nameUser },
                CategoryName = x.Category.nameCate,
                DateCreate = x.dayCreateInfo,
                Content = x.contentInfo,
                hideInfo = x.hideInfo,
                EditInforCount = x.EditInfoes.Where(k => k.idUser != x.idUser).Count()

            });

            return result;
        }

        public bool CheckProductTitleExist(string title)
        {
            return new ProductDao().CheckExistTile(title);
        }

        public bool CreateProduct(ProductViewContract product)
        {
            product.DateCreate = DateTime.Now;
            product.hideInfo = true;
            return new ProductDao().CreateNewProduct(product);
        }

        public ProductViewContract GetDetailProductById(int id)
        {

            var result = new ProductDao().GetDetailProductById(id);
            var data = new ProductViewContract()
            {
                ID = result.idInfor,
                Title = result.titleInfo,
                CateId = result.idCate,
                UserId = result.idUser,
                User = new UserContract() { ID = result.idUser, UserName = result.User.nameUser },
                UserName = result.User.nameUser,
                CategoryName = result.Category.nameCate,
                DateCreate = result.dayCreateInfo,
                Content = result.contentInfo,
                hideInfo = result.hideInfo,
                EditInforCount = result.EditInfoes.Count()
            };
            return data;
        }

        public bool DeleteProduct(int id)
        {
            return new ProductDao().DeleteProduct(id);
        }

        public bool EditProduct(ProductViewContract product)
        {
            return new ProductDao().EditProduct(product);
        }

        public IEnumerable<ProductViewContract> GetListProductByCateId(int idCate)
        {
            var list = new ProductDao().GetProductsClientByCateId(idCate).Select(x => new ProductViewContract()
            {
                ID = x.idInfor,
                Title = x.titleInfo,
                DateCreate = x.dayCreateInfo,
                User = new UserDao().GetUserDetailById(x.idUser),
                Category = new CategoryBus().GetDetailCategory(x.idCate),
                EditInforCount = x.EditInfoes.Count()

            }).ToList();
            return list;
        }

        public IEnumerable<ProductViewContract> GetListProductClientView()
        {
            var list = new ProductDao().GetProductsClientView().Select(x => new ProductViewContract()
            {
                ID = x.idInfor,
                Title = x.titleInfo,
                DateCreate = x.dayCreateInfo,
                User = new UserDao().GetUserDetailById(x.idUser),
                Category = new CategoryBus().GetDetailCategory(x.idCate),
                EditInforCount = x.EditInfoes.Count()

            }).ToList();
            return list;
        }

        public ProductViewContract getContentById(int id)
        {
            var data = new ProductDao().GetDetailProductById(id);
            var res = new ProductViewContract()
            {
                ID = data.idInfor,
                Title = data.titleInfo,
                User = new UserContract()
                {
                    ID = data.User.idUser,
                    UserName = data.User.nameUser,
                    ProductViewContracts = data.User.Information.Where(x => x.idInfor != data.idInfor && x.idUser == data.idUser).Select(x => new ProductViewContract
                    {
                        ID = x.idInfor,
                        Title = x.titleInfo,
                        EditInforCount = x.EditInfoes.Count,
                        DateCreate = x.dayCreateInfo
                    }).ToList()

                },
                Category = new CategoryContract()
                {
                    ID = data.Category.idCate,
                    Name = data.Category.nameCate
                },
                EditInforCount = data.EditInfoes.Count,
                EditProductViewContracts = data.EditInfoes.Select(x => new EditProductViewContract()
                {
                    ID = x.idEI,
                    User = new UserContract()
                    {
                        ID = x.idUser,
                        UserName = x.User.nameUser
                    },
                    DateCreateEI = x.dayCreateEI,
                    Content = x.contentEdit,
                    ProductId = x.idInfo,
                    UserID = x.idUser

                }).ToList(),
                Content = data.contentInfo,
                DateCreate = data.dayCreateInfo,




            };
            return res;
        }

        public bool LetUserComment(EditProductViewContract editProduct)
        {
            editProduct.DateCreateEI = DateTime.Now;
            return new ProductDao().LetUserComment(editProduct);
        }

        public bool DeleteComment(int id)
        {
            return new ProductDao().DeleteComment(id);
        }

        public List<ProductViewContract> SearchProduct(string name)
        {
           return new ProductDao().SearchProduct(name).Select(x=>new ProductViewContract()
           {
               ID = x.idInfor,
               Title = x.titleInfo   
           }).ToList();
        }
    }
}