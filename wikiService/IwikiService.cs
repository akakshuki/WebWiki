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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IwikiService" in both code and config file together.
    [ServiceContract(Name = "DichVuWiki")]
    public interface IwikiService
    {

        #region User
        [OperationContract(Name = "DangNhap")]
        int Login(UserContract userCaContract);

        [OperationContract(Name = "DangKiTaiKhoanAdmin")]
        bool RegisterAdmin(UserContract userContract);

        [OperationContract(Name = "KiemTraiTaiKhoanDatontai")]
        bool checkEmaiilUser(string email);
        
        

        [OperationContract(Name = "KiemTraTaiKhoan")]
        UserContract CheckRoleUser(UserContract userContract);
        #endregion


        #region Category

        [OperationContract(Name = "DanhSachDanhMuc")]
        IEnumerable<CategoryContract> ListCategory();

        [OperationContract(Name = "ThemMoiDanhMuc")]
        bool CreateCategory(CategoryContract category);

        #endregion



    }
}
