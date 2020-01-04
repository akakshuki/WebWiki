using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WikiManageWeb.Models.ModelsView;
using WikiManageWeb.WikiService;

namespace WikiManageWeb.Dao
{
    public class ProductDao
    {
        private WikiService.DichVuWikiClient cl = null;

        public ProductDao()
        {
            cl = new DichVuWikiClient();
        }

        public List<ProductMv> GetAlListProducts()
        {
            return cl.DanhSachTatCaBaiViet().OrderByDescending(x => x.NgayTao).Select(x => new ProductMv
            {
                ID = x.MaBaiViet,
                Title = x.TieuDe,
                Content = x.NoiDung,
                UserName = x.TenNguoiDung,
                CateName = x.TenDanhMuc,
                hideInfo = x.TrangThai,
                DateCreate = x.NgayTao,
                CateId = x.MaDanhMuc,
                UserId = x.MaNguoiDung
            }).ToList();
        }

        public List<ProductMv> GetListProductClientView()
        {
            var data = cl.DanhSachBaiVietNguoiDung().OrderByDescending(x=> x.NgayTao).Select(x => new ProductMv()
            {
                ID = x.MaBaiViet,
                Title = x.TieuDe,
                user = new UserMv()
                {
                    ID = x.MaNguoiDung,
                    UserName = x.NguoiDung.TenTaiKhoan
                },
                Category = new CategoryMv()
                {
                    ID = x.DanhMuc.MaDanhMuc,
                    Name = x.DanhMuc.TenDanhMuc
                },
                DateCreate = x.NgayTao,
                EditProductViewCount = x.SoBinhLuan

            }).ToList();
            return data;
        }

        public List<ProductMv> GetListProductClientView(int CateId)
        {
            var data = cl.DanhSachSanPhamTheoDanhMuc(CateId).OrderByDescending(x=>x.NgayTao).Select(x => new ProductMv()
            {
                ID = x.MaBaiViet,
                Title = x.TieuDe,
                user = new UserMv()
                {
                    ID = x.MaNguoiDung,
                    UserName = x.NguoiDung.TenTaiKhoan
                },
                Category = new CategoryMv()
                {
                    ID = x.DanhMuc.MaDanhMuc,
                    Name = x.DanhMuc.TenDanhMuc
                },
                DateCreate = x.NgayTao,
                EditProductViewCount = x.SoBinhLuan

            }).ToList();
            return data;
        }

        public bool ChecKTileExist(string title)
        {
            return cl.KiemTraTieuDeDaTonTai(title);
        }

        public bool CreateNewProduct(ProductMv product)
        {

            var data = new BaiViet()
            {
                TieuDe = product.Title,
                NoiDung = product.Content,
                MaDanhMuc = product.CateId,
                MaNguoiDung = product.UserId,

            };
            return cl.TaoBaiVietMoi(data);
        }

        public ProductMv GetDetailProduct(int id)
        {
                var data = cl.ChiTietSanPham(id);
            return new ProductMv()
            {
                ID = data.MaBaiViet,
                Title = data.TieuDe,
                Content = data.NoiDung,
                UserName = data.TenNguoiDung,
                CateName = data.TenDanhMuc,
                hideInfo = data.TrangThai,
                DateCreate = data.NgayTao,
                CateId = data.MaDanhMuc,
                UserId = data.MaNguoiDung
            };
        }

        public bool EditProduct(ProductMv product)
        {
            return cl.SuaBaiViet(new BaiViet()
            {
                MaBaiViet = product.ID,
                TieuDe = product.Title,
                NoiDung = product.Content,
                MaDanhMuc = product.CateId
            });
        }

        public bool DeleteProduct(int id)
        {
            return cl.XoaBaiViet(id);
        }


        public object ContenProduct(int id)
        {
            var data = cl.NoiDungBaiVietClient(id);
            return new ProductMv()
            {
                ID = data.MaBaiViet,
               Title = data.TieuDe,
                user = new UserMv()
                {
                    ID = data.NguoiDung.MaTaiKhoan,
                    UserName = data.NguoiDung.TenTaiKhoan,
                    ProductViewContracts = data.NguoiDung.DanhSachBaiVietKhac.Select(x => new ProductMv
                    {
                        ID = x.MaBaiViet,
                        Title = x.TieuDe,
                        DateCreate = x.NgayTao,
                        EditProductViewCount = x.SoBinhLuan
                    }).ToList(),
                },
                DateCreate = data.NgayTao,
                EditProductViewCount = data.SoBinhLuan,
                Category = new CategoryMv()
                {
                    ID = data.DanhMuc.MaDanhMuc,
                    Name = data.DanhMuc.TenDanhMuc
                },
                Content = data.NoiDung,
                EditProductViews = data.DanhSachBinhLuan.Select(x => new EditProductMv()
                {
                    ID = x.MaBinhLuan,
                    User = new UserMv()
                    {
                        ID = x.NguoiDung.MaTaiKhoan,
                        UserName = x.NguoiDung.TenTaiKhoan
                    },
                    Content = x.NoiDungBinhLuan,
                    dayCreateEI = x.NgayCapNhat,

                }).ToList()
            };
        }

        public bool LetUserComment(EditProductMv editProduct)
        {
            var data = new LichSuBinhLuan()
            {
                MaNguoiDung =  editProduct.UserID,
                MaBaiViet = editProduct.ProductId,
                NoiDungBinhLuan = editProduct.Content
            };

            return cl.BinhLuanSanPham(data);
        }

        public bool DeleteComment(int id)
        {
            return cl.XoaBinhLuan(id);
        }

    }
}