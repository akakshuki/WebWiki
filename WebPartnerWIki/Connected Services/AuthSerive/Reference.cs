﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebPartnerWIki.AuthSerive {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaiViet", Namespace="http://schemas.datacontract.org/2004/07/wikiService.Models.ModelViewContract")]
    [System.SerializableAttribute()]
    public partial class BaiViet : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebPartnerWIki.AuthSerive.LichSuBinhLuan BinhLuanField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebPartnerWIki.AuthSerive.DanhMuc DanhMucField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<WebPartnerWIki.AuthSerive.LichSuBinhLuan> DanhSachBinhLuanField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaBaiVietField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaDanhMucField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaNguoiDungField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime NgayTaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebPartnerWIki.AuthSerive.TaiKhoan NguoiDungField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NoiDungField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SoBinhLuanField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenDanhMucField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenNguoiDungField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TieuDeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool TrangThaiField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebPartnerWIki.AuthSerive.LichSuBinhLuan BinhLuan {
            get {
                return this.BinhLuanField;
            }
            set {
                if ((object.ReferenceEquals(this.BinhLuanField, value) != true)) {
                    this.BinhLuanField = value;
                    this.RaisePropertyChanged("BinhLuan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebPartnerWIki.AuthSerive.DanhMuc DanhMuc {
            get {
                return this.DanhMucField;
            }
            set {
                if ((object.ReferenceEquals(this.DanhMucField, value) != true)) {
                    this.DanhMucField = value;
                    this.RaisePropertyChanged("DanhMuc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<WebPartnerWIki.AuthSerive.LichSuBinhLuan> DanhSachBinhLuan {
            get {
                return this.DanhSachBinhLuanField;
            }
            set {
                if ((object.ReferenceEquals(this.DanhSachBinhLuanField, value) != true)) {
                    this.DanhSachBinhLuanField = value;
                    this.RaisePropertyChanged("DanhSachBinhLuan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaBaiViet {
            get {
                return this.MaBaiVietField;
            }
            set {
                if ((this.MaBaiVietField.Equals(value) != true)) {
                    this.MaBaiVietField = value;
                    this.RaisePropertyChanged("MaBaiViet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaDanhMuc {
            get {
                return this.MaDanhMucField;
            }
            set {
                if ((this.MaDanhMucField.Equals(value) != true)) {
                    this.MaDanhMucField = value;
                    this.RaisePropertyChanged("MaDanhMuc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaNguoiDung {
            get {
                return this.MaNguoiDungField;
            }
            set {
                if ((this.MaNguoiDungField.Equals(value) != true)) {
                    this.MaNguoiDungField = value;
                    this.RaisePropertyChanged("MaNguoiDung");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime NgayTao {
            get {
                return this.NgayTaoField;
            }
            set {
                if ((this.NgayTaoField.Equals(value) != true)) {
                    this.NgayTaoField = value;
                    this.RaisePropertyChanged("NgayTao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebPartnerWIki.AuthSerive.TaiKhoan NguoiDung {
            get {
                return this.NguoiDungField;
            }
            set {
                if ((object.ReferenceEquals(this.NguoiDungField, value) != true)) {
                    this.NguoiDungField = value;
                    this.RaisePropertyChanged("NguoiDung");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NoiDung {
            get {
                return this.NoiDungField;
            }
            set {
                if ((object.ReferenceEquals(this.NoiDungField, value) != true)) {
                    this.NoiDungField = value;
                    this.RaisePropertyChanged("NoiDung");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SoBinhLuan {
            get {
                return this.SoBinhLuanField;
            }
            set {
                if ((this.SoBinhLuanField.Equals(value) != true)) {
                    this.SoBinhLuanField = value;
                    this.RaisePropertyChanged("SoBinhLuan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TenDanhMuc {
            get {
                return this.TenDanhMucField;
            }
            set {
                if ((object.ReferenceEquals(this.TenDanhMucField, value) != true)) {
                    this.TenDanhMucField = value;
                    this.RaisePropertyChanged("TenDanhMuc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TenNguoiDung {
            get {
                return this.TenNguoiDungField;
            }
            set {
                if ((object.ReferenceEquals(this.TenNguoiDungField, value) != true)) {
                    this.TenNguoiDungField = value;
                    this.RaisePropertyChanged("TenNguoiDung");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TieuDe {
            get {
                return this.TieuDeField;
            }
            set {
                if ((object.ReferenceEquals(this.TieuDeField, value) != true)) {
                    this.TieuDeField = value;
                    this.RaisePropertyChanged("TieuDe");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool TrangThai {
            get {
                return this.TrangThaiField;
            }
            set {
                if ((this.TrangThaiField.Equals(value) != true)) {
                    this.TrangThaiField = value;
                    this.RaisePropertyChanged("TrangThai");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LichSuBinhLuan", Namespace="http://schemas.datacontract.org/2004/07/wikiService.Models.ModelViewContract")]
    [System.SerializableAttribute()]
    public partial class LichSuBinhLuan : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaBaiVietField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaBinhLuanField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaNguoiDungField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime NgayCapNhatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebPartnerWIki.AuthSerive.TaiKhoan NguoiDungField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NoiDungBinhLuanField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaBaiViet {
            get {
                return this.MaBaiVietField;
            }
            set {
                if ((this.MaBaiVietField.Equals(value) != true)) {
                    this.MaBaiVietField = value;
                    this.RaisePropertyChanged("MaBaiViet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaBinhLuan {
            get {
                return this.MaBinhLuanField;
            }
            set {
                if ((this.MaBinhLuanField.Equals(value) != true)) {
                    this.MaBinhLuanField = value;
                    this.RaisePropertyChanged("MaBinhLuan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaNguoiDung {
            get {
                return this.MaNguoiDungField;
            }
            set {
                if ((this.MaNguoiDungField.Equals(value) != true)) {
                    this.MaNguoiDungField = value;
                    this.RaisePropertyChanged("MaNguoiDung");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime NgayCapNhat {
            get {
                return this.NgayCapNhatField;
            }
            set {
                if ((this.NgayCapNhatField.Equals(value) != true)) {
                    this.NgayCapNhatField = value;
                    this.RaisePropertyChanged("NgayCapNhat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebPartnerWIki.AuthSerive.TaiKhoan NguoiDung {
            get {
                return this.NguoiDungField;
            }
            set {
                if ((object.ReferenceEquals(this.NguoiDungField, value) != true)) {
                    this.NguoiDungField = value;
                    this.RaisePropertyChanged("NguoiDung");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NoiDungBinhLuan {
            get {
                return this.NoiDungBinhLuanField;
            }
            set {
                if ((object.ReferenceEquals(this.NoiDungBinhLuanField, value) != true)) {
                    this.NoiDungBinhLuanField = value;
                    this.RaisePropertyChanged("NoiDungBinhLuan");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DanhMuc", Namespace="http://schemas.datacontract.org/2004/07/wikiService.Models.ModelViewContract")]
    [System.SerializableAttribute()]
    public partial class DanhMuc : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaDanhMucField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SoSanphamField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenDanhMucField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaDanhMuc {
            get {
                return this.MaDanhMucField;
            }
            set {
                if ((this.MaDanhMucField.Equals(value) != true)) {
                    this.MaDanhMucField = value;
                    this.RaisePropertyChanged("MaDanhMuc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SoSanpham {
            get {
                return this.SoSanphamField;
            }
            set {
                if ((this.SoSanphamField.Equals(value) != true)) {
                    this.SoSanphamField = value;
                    this.RaisePropertyChanged("SoSanpham");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TenDanhMuc {
            get {
                return this.TenDanhMucField;
            }
            set {
                if ((object.ReferenceEquals(this.TenDanhMucField, value) != true)) {
                    this.TenDanhMucField = value;
                    this.RaisePropertyChanged("TenDanhMuc");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TaiKhoan", Namespace="http://schemas.datacontract.org/2004/07/wikiService.Models.ModelViewContract")]
    [System.SerializableAttribute()]
    public partial class TaiKhoan : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<WebPartnerWIki.AuthSerive.BaiViet> DanhSachBaiVietKhacField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<WebPartnerWIki.AuthSerive.LichSuBinhLuan> DanhSachBinhLuanField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDRoleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaTaiKhoanField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MatKhauField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SoBaiVietField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SoBinhLuanField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenTaiKhoanField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool TrangThaiField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<WebPartnerWIki.AuthSerive.BaiViet> DanhSachBaiVietKhac {
            get {
                return this.DanhSachBaiVietKhacField;
            }
            set {
                if ((object.ReferenceEquals(this.DanhSachBaiVietKhacField, value) != true)) {
                    this.DanhSachBaiVietKhacField = value;
                    this.RaisePropertyChanged("DanhSachBaiVietKhac");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<WebPartnerWIki.AuthSerive.LichSuBinhLuan> DanhSachBinhLuan {
            get {
                return this.DanhSachBinhLuanField;
            }
            set {
                if ((object.ReferenceEquals(this.DanhSachBinhLuanField, value) != true)) {
                    this.DanhSachBinhLuanField = value;
                    this.RaisePropertyChanged("DanhSachBinhLuan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IDRole {
            get {
                return this.IDRoleField;
            }
            set {
                if ((this.IDRoleField.Equals(value) != true)) {
                    this.IDRoleField = value;
                    this.RaisePropertyChanged("IDRole");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaTaiKhoan {
            get {
                return this.MaTaiKhoanField;
            }
            set {
                if ((this.MaTaiKhoanField.Equals(value) != true)) {
                    this.MaTaiKhoanField = value;
                    this.RaisePropertyChanged("MaTaiKhoan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MatKhau {
            get {
                return this.MatKhauField;
            }
            set {
                if ((object.ReferenceEquals(this.MatKhauField, value) != true)) {
                    this.MatKhauField = value;
                    this.RaisePropertyChanged("MatKhau");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SoBaiViet {
            get {
                return this.SoBaiVietField;
            }
            set {
                if ((this.SoBaiVietField.Equals(value) != true)) {
                    this.SoBaiVietField = value;
                    this.RaisePropertyChanged("SoBaiViet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SoBinhLuan {
            get {
                return this.SoBinhLuanField;
            }
            set {
                if ((this.SoBinhLuanField.Equals(value) != true)) {
                    this.SoBinhLuanField = value;
                    this.RaisePropertyChanged("SoBinhLuan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TenTaiKhoan {
            get {
                return this.TenTaiKhoanField;
            }
            set {
                if ((object.ReferenceEquals(this.TenTaiKhoanField, value) != true)) {
                    this.TenTaiKhoanField = value;
                    this.RaisePropertyChanged("TenTaiKhoan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool TrangThai {
            get {
                return this.TrangThaiField;
            }
            set {
                if ((this.TrangThaiField.Equals(value) != true)) {
                    this.TrangThaiField = value;
                    this.RaisePropertyChanged("TrangThai");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AuthSerive.KiemSoatPartner")]
    public interface KiemSoatPartner {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/KiemSoatPartner/TimBaiVietTheoTen", ReplyAction="http://tempuri.org/KiemSoatPartner/TimBaiVietTheoTenResponse")]
        System.Collections.Generic.List<WebPartnerWIki.AuthSerive.BaiViet> TimBaiVietTheoTen(string name, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/KiemSoatPartner/TimBaiVietTheoTen", ReplyAction="http://tempuri.org/KiemSoatPartner/TimBaiVietTheoTenResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WebPartnerWIki.AuthSerive.BaiViet>> TimBaiVietTheoTenAsync(string name, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/KiemSoatPartner/NoiDungBaiVietClient", ReplyAction="http://tempuri.org/KiemSoatPartner/NoiDungBaiVietClientResponse")]
        WebPartnerWIki.AuthSerive.BaiViet NoiDungBaiVietClient(int id, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/KiemSoatPartner/NoiDungBaiVietClient", ReplyAction="http://tempuri.org/KiemSoatPartner/NoiDungBaiVietClientResponse")]
        System.Threading.Tasks.Task<WebPartnerWIki.AuthSerive.BaiViet> NoiDungBaiVietClientAsync(int id, string token);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface KiemSoatPartnerChannel : WebPartnerWIki.AuthSerive.KiemSoatPartner, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class KiemSoatPartnerClient : System.ServiceModel.ClientBase<WebPartnerWIki.AuthSerive.KiemSoatPartner>, WebPartnerWIki.AuthSerive.KiemSoatPartner {
        
        public KiemSoatPartnerClient() {
        }
        
        public KiemSoatPartnerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public KiemSoatPartnerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KiemSoatPartnerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KiemSoatPartnerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<WebPartnerWIki.AuthSerive.BaiViet> TimBaiVietTheoTen(string name, string token) {
            return base.Channel.TimBaiVietTheoTen(name, token);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WebPartnerWIki.AuthSerive.BaiViet>> TimBaiVietTheoTenAsync(string name, string token) {
            return base.Channel.TimBaiVietTheoTenAsync(name, token);
        }
        
        public WebPartnerWIki.AuthSerive.BaiViet NoiDungBaiVietClient(int id, string token) {
            return base.Channel.NoiDungBaiVietClient(id, token);
        }
        
        public System.Threading.Tasks.Task<WebPartnerWIki.AuthSerive.BaiViet> NoiDungBaiVietClientAsync(int id, string token) {
            return base.Channel.NoiDungBaiVietClientAsync(id, token);
        }
    }
}
