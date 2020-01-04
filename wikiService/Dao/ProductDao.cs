using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wikiService.EF;
using wikiService.Models.ModelViewContract;

namespace wikiService.Dao
{
    public class ProductDao
    {
        private DBWikiEntities db = null;

        public ProductDao()
        {
            db = new DBWikiEntities();
        }

        public IEnumerable<Information> GetAllListProduct()
        {
            var result = db.Information.ToList();
            return result;
        }

        public bool CheckExistTile(string title)
        {
            if (db.Information.Where(x=>x.titleInfo== title).Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //shortly code insert to db
        public bool CreateNewProduct(ProductViewContract product)
        {
            try
            {
                db.Information.Add(new Information
                {
                    titleInfo = product.Title,
                    contentInfo = product.Content,
                    idCate = product.CateId,
                    idUser = product.UserId,
                    dayCreateInfo = product.DateCreate,
                    hideInfo = product.hideInfo,
                });
                if (db.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public Information GetDetailProductById(int id)
        {
            return db.Information.Find(id); 
        }

        public bool DeleteProduct(int id)
        {
            try
            {
                var data = db.Information.Find(id);

                var listComment = db.EditInfoes.Where(x => x.idInfo== data.idInfor).ToList();
                foreach (var item in listComment)
                {
                    db.EditInfoes.Remove(item);
                }
                db.Information.Remove(data);
                if (db.SaveChanges()>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool EditProduct(ProductViewContract product)
        {
            try
            {
                var data = db.Information.Find(product.ID);
                data.titleInfo = product.Title;
                data.contentInfo = product.Content;
                data.idCate = product.CateId;
                if (db.SaveChanges()>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

     

        public IEnumerable<Information> GetProductsClientByCateId(int idCate)
        {
          var data = db.Information.Where(x => x.idCate == idCate && x.hideInfo).ToList();
            return data;
        }
        public IEnumerable<Information> GetProductsClientView()
        {
            var data = db.Information.Where(x=>x.hideInfo).ToList();
            return data;
        }

        public bool LetUserComment(EditProductViewContract editProduct)
        {
           var data = db.EditInfoes.Add(new EditInfo()
           {
               idUser = editProduct.UserID,
               idInfo = editProduct.ProductId,
               contentEdit = editProduct.Content,
               dayCreateEI = editProduct.DateCreateEI,
               
           });
           if (db.SaveChanges()>0)
           {
               return true;
            }
           else
           {
               return false;
           }
           
        }

        public bool DeleteComment(int id)
        {
            var data = db.EditInfoes.Find(id);
            db.EditInfoes.Remove(data);
            if (db.SaveChanges()>0)
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