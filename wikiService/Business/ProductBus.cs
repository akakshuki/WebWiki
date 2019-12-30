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
            var result = new ProductDao().GetAllListProduct().Select(x=>new ProductViewContract
            {
                ID = x.idInfor,
                Title = x.titleInfo,
                CateId = x.idCate,
                UserId = x.idUser,
                UserName = x.User.nameUser,
                CategoryName = x.Category.nameCate,
                DateCreate = x.dayCreateInfo,
                Content = x.contentInfo,
                hideInfo = x.hideInfo
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
                UserName = result.User.nameUser,
                CategoryName = result.Category.nameCate,
                DateCreate = result.dayCreateInfo,
                Content = result.contentInfo,
                hideInfo = result.hideInfo
            };
           return  data;
        }

        public bool DeleteProduct(int id)
        {
           return new ProductDao().DeleteProduct(id);
        }

        public bool EditProduct(ProductViewContract product)
        {
            return new ProductDao().EditProduct(product);
        }
    }
}