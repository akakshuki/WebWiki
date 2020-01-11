using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.ServiceModel;
using wikiService.Models.ModelViewContract;
using wikiService.Models.ServicepartnerContract;


namespace wikiService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IwikiService" in both code and config file together.
    [ServiceContract(Name = "DichVuWiki")]
    public interface IwikiService
    {

        #region User
        [OperationContract(Name = "DangNhap")]
        int Login(UserContract userCaContract);
        [OperationContract(Name = "DangKiTaiKhoanAdmin")]
        bool RegisterAdmin(UserContract userContract);
        [OperationContract(Name = "DangKiTaiKhoanUser")]
        bool RegisterUser(UserContract userContract);

        [OperationContract(Name = "KiemTraiTaiKhoanDatontai")]
        bool checkEmaiilUser(string email);
        [OperationContract(Name = "KiemTraTaiKhoan")]
        UserContract CheckRoleUser(UserContract userContract);
        [OperationContract(Name = "ThongTinTaiKhoan")]
        UserContract UserProfile(int id);
        [OperationContract(Name = "DanhSachTaiKhoan")]
        List<UserContract> ListUser();
        [OperationContract(Name = "DanhSachTaiKhoanAdmin")]
        List<UserContract> ListUserAdmin();
        #endregion


        #region Category

        [OperationContract(Name = "DanhSachDanhMuc")]
        IEnumerable<CategoryContract> ListCategory();
        [OperationContract(Name = "ThemMoiDanhMuc")]
        bool CreateCategory(CategoryContract category);
        [OperationContract(Name = "KiemTraDanhMucDaTonTai")]
        bool CheckCategoryExist(string categoryName);
        [OperationContract(Name = "ChitTietDanhMuc")]
        CategoryContract DetailCategory(int idCategory);
        [OperationContract(Name = "SuaDanhMuc")]
        bool EditCategory(CategoryContract category);
        [OperationContract(Name = "XoaDanhMuc")]
        bool DeleteCategory(int id);

        #endregion


        #region Product
        [OperationContract(Name = "DanhSachTatCaBaiViet")]
        IEnumerable<ProductViewContract> ListAllProduct();
        [OperationContract(Name = "DanhSachTatCaBaiVietDaXem")]
        IEnumerable<ProductViewContract> ListAllProductSeen();
        [OperationContract(Name = "DanhSachTatCaBaiVietChuaXem")]
        IEnumerable<ProductViewContract> ListAllProductUnseen();
        [OperationContract(Name = "DanhSachBaiVietNguoiDung")]
        IEnumerable<ProductViewContract> ListAllProductClientView();
        [OperationContract(Name = "DanhSachSanPhamTheoDanhMuc")]
        IEnumerable<ProductViewContract> ListAllProductByCategory(int idCate);


        [OperationContract(Name = "KiemTraTieuDeDaTonTai")]
        bool CheckTitleExist(string title);
        [OperationContract(Name = "TaoBaiVietMoi")]
        bool CreateNewProduct(ProductViewContract product);
        [OperationContract(Name = "ChiTietSanPham")]
        ProductViewContract DetaiContract(int id);
        [OperationContract(Name = "NoiDungBaiVietClient")]
        ProductViewContract GetContemProductById(int id);
        [OperationContract(Name = "SuaBaiViet")]
        bool EditProduct(ProductViewContract product);
        [OperationContract(Name = "CapNhatBaiViet")]
        bool UpdateProduct(ProductViewContract product);
        [OperationContract(Name = "XoaBaiViet")]
        bool DeleteProduct(int id);
        [OperationContract(Name = "TimBaiVietTheoTen")]
        List<ProductViewContract> ProductSearchByName(string name);


        [OperationContract(Name = "BinhLuanSanPham")]
        bool CommentProductByClient(EditProductViewContract editProduct);
        [OperationContract(Name = "XoaBinhLuan")]
        bool DeleteComment(int id);

        #endregion


        #region PartnerService

        [OperationContract(Name = "ThemMoiPartner")]
        bool CreatePartner(AccountServiceContract account);
        [OperationContract(Name = "DanhSachServiceRole")]
        IEnumerable<AccountRoleServiceContract> RoleService();
        [OperationContract(Name = "PartnerLogin")]
        AccountServiceContract PartnerLogin(AccountServiceContract account);
        #endregion

    }
}
