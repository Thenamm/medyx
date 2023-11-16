// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMNoiSua
// Kieu doi tuong  :	CslaObject
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	10/27/2008 9:40:15 AM
// Nguoi tao       :	HCABXT
//
// *****************************************************************************************************

// TODO:
// 1. Kiem tra lai su dung dan cua cac ham DataProvider.Instance()
// 2. Viet them cac ham tuong ung trong file DataProvider.cs
// 3. Viet them cac ham tuong ung trong file SqlDataProvider.cs
// 4. Viet Stored Procedure tuong ung voi cac ham can lay ra.
// *****************************************************************************************************
using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
// 
namespace HTC.Business.CategoryList
{

    /// <summary>
    /// This is a base generated class of <see cref="CslaObject" /> Business Object.
    /// </summary>

    [Serializable()]
    public partial class DMNoiSua : BusinessBase<DMNoiSua>
    {
        #region Business Methods

        #region State Fields

        private String _maNoiSua = String.Empty;
        private String _tenNoiSua = String.Empty;
        private String _tenta = String.Empty;
        private String _Ghichu = String.Empty;
        private string _DiaChi = string.Empty;
        private string _DienThoai = string.Empty;
        private String _maMay = String.Empty;
        private Byte _Loai = 0 ;
        private Boolean _huy = false;
        private SmartDate _ngaySD = new SmartDate(false);
        private String _nguoiSD = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;

        #endregion

        #region Business Properties and Methods

        public String MaNoiSua
        {
            get
            {
                CanReadProperty("MaNoiSua", true);
                return _maNoiSua;
            }
            set
            {
                CanWriteProperty("MaNoiSua", true);
                if (_maNoiSua != value)
                {
                    _maNoiSua = value;
                    PropertyHasChanged("MaNoiSua");
                }
            }
        }

        public String TenNoiSua
        {
            get
            {
                CanReadProperty("TenNoiSua", true);
                return _tenNoiSua;
            }
            set
            {
                CanWriteProperty("TenNoiSua", true);
                if (_tenNoiSua != value)
                {
                    _tenNoiSua = value;
                    PropertyHasChanged("TenNoiSua");
                }
            }
        }
        public String tenta
        {
            get
            {
                CanReadProperty("tenta", true);
                return _tenta;
            }
            set
            {
                CanWriteProperty("tenta", true);
                if (_tenta != value)
                {
                    _tenta = value;
                    PropertyHasChanged("tenta");
                }
            }
        }

        public String Ghichu
        {
            get
            {
                CanReadProperty("Ghichu", true);
                return _Ghichu;
            }
            set
            {
                CanWriteProperty("Ghichu", true);
                if (_Ghichu != value)
                {
                    _Ghichu = value;
                    PropertyHasChanged("Ghichu");
                }
            }
        }
        public String DiaChi
        {
            get
            {
                CanReadProperty("DiaChi", true);
                return _DiaChi ;
            }
            set
            {
                CanWriteProperty("DiaChi", true);
                if (_DiaChi != value)
                {
                    _DiaChi = value;
                    PropertyHasChanged("DiaChi");
                }
            }
        }
        public String DienThoai
        {
            get
            {
                CanReadProperty("DienThoai", true);
                return _DienThoai;
            }
            set
            {
                CanWriteProperty("DienThoai", true);
                if (_DienThoai != value)
                {
                    _DienThoai = value;
                    PropertyHasChanged("DienThoai");
                }
            }
        }
        public String MaMay
        {
            get
            {
                CanReadProperty("MaMay", true);
                return _maMay;
            }
            set
            {
                CanWriteProperty("MaMay", true);
                if (_maMay != value)
                {
                    _maMay = value;
                    PropertyHasChanged("MaMay");
                }
            }
        }

        public Byte Loai
        {
            get
            {
                CanReadProperty("Loai", true);
                return _Loai;
            }
            set
            {
                CanWriteProperty("Loai", true);
                if (_Loai != value)
                {
                    _Loai = value;
                    PropertyHasChanged("Loai");
                }
            }
        }

      
        public Boolean Huy
        {
            get
            {
                CanReadProperty("Huy", true);
                return _huy;
            }
            set
            {
                CanWriteProperty("Huy", true);
                if (_huy != value)
                {
                    _huy = value;
                    PropertyHasChanged("Huy");
                }
            }
        }
        public SmartDate NgaySD
        {
            get
            {
                CanReadProperty("NgaySD", true);
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngaySD;
            }
            set
            {
                CanWriteProperty("NgaySD", true);
                if (_ngaySD != value)
                {
                    _ngaySD = value;
                    PropertyHasChanged("NgaySD");
                }
            }
        }

        public String NguoiSD
        {
            get
            {
                CanReadProperty("NguoiSD", true);
                return _nguoiSD;
            }
            set
            {
                CanWriteProperty("NguoiSD", true);
                if (_nguoiSD != value)
                {
                    _nguoiSD = value;
                    PropertyHasChanged("NguoiSD");
                }
            }
        }
        public String hoten
        {
            get
            {
                CanReadProperty("hoten", true);
                return _hoten;
            }
            set
            {
                CanWriteProperty("hoten", true);
                if (_hoten != value)
                {
                    _hoten = value;
                    PropertyHasChanged("hoten");
                }
            }
        }
        public int OrderNumber
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _OrderNumber;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                    //PropertyHasChanged();
                }
            }
        }
        protected override Object GetIdValue()
        {
            return _maNoiSua;
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenNoiSua", 150));
            ValidationRules.AddRule<DMNoiSua>(StringRequired<DMNoiSua>, "TenNoiSua");

        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMNoiSua
        {

            if (target._tenNoiSua == null || target._tenNoiSua.Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }
        
        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="CslaObject" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        public static DMNoiSua NewDMNoiSua()
        {
             return DataPortal.Create<DMNoiSua>();
           // return new DMNoiSua();
        }
        public static DMNoiSua GetDMNoiSua(String maNoiSua)
        {
            return DataPortal.Fetch<DMNoiSua>(new Criteria(maNoiSua));
        }

        /// <summary>
        /// Marks the <see cref="CslaObject" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteDMNoiSua(String _maNoiSua, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy, _maNoiSua));
        }

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        protected internal DMNoiSua()
        {
            // Prevent direct creation
        }

        internal DMNoiSua(int ordernumber, string MaNoisua, string TenNoisua, string Ghichu, string DiaChi, string DienThoai, string idmay, Byte  Loai, bool huy, SmartDate ngaySD, string NguoiSD, String tenta, string hoten)
        {
            _OrderNumber = ordernumber;
            _maNoiSua = MaNoisua;
            _tenNoiSua = TenNoisua;
            _Ghichu = Ghichu;
            _DiaChi = DiaChi;
            _DienThoai = DienThoai;
            _maMay = idmay;
            _Loai = Loai;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = NguoiSD;
            _tenta = tenta;
            _hoten = hoten;
        }
        #endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
            private String _maNoiSua;
            public String MaNoiSua
            {
                get
                {
                    return _maNoiSua;
                }
            }

            public Criteria(String maNoiSua)
            {
                _maNoiSua = maNoiSua;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maNoiSua.Equals(c._maNoiSua))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maNoiSua.ToString()).GetHashCode();
            }
        }
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maNoiSua;
            public String MaNoiSua
            {
                get
                {
                    return _maNoiSua;
                }
            }

            private String _maMay;
            public String MaMay
            {
                get
                {
                    return _maMay;
                }
            }

            private String _NguoiSD;
            public String NguoiSD
            {
                get
                {
                    return _NguoiSD;
                }
            }
            public OtherCriteria(String Mamay, String Nguoisd, String maNoiSua)
            {
                _maNoiSua = maNoiSua;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
            }

            //public override bool Equals(object obj)
            //{
            //    if (obj is Criteria)
            //    {
            //        Criteria c = (Criteria)obj;
            //        if (!_maDV.Equals(c._maDV))
            //            return false;
            //        return true;
            //    }
            //    return false;
            //}

            //public override int GetHashCode()
            //{
            //    return string.Concat("Criteria", _maDV.ToString()).GetHashCode();
            //}
        }
        #endregion

        #region Authorization

        public static bool CanGetObject()
        {
            return true;
        }

        public static bool CanDeleteObject()
        {
            return true;
        }

        public static bool CanAddObject()
        {
            return true;
        }

        public static bool CanEditObject()
        {
            return true;
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Retrieve an existing <see cref="CslaObject" /> Object based on data in the database.
        /// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetCslaObject(String _maVungLT);
            // public override IDataReader GetCslaObject(String _maVungLT)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maVungLT));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMNoiSua(crit.MaNoiSua)))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    MarkOld();
                    ValidationRules.CheckRules();
                }
            }
        }
        /// <summary>
        /// Load a <see cref="CslaObject" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("MaNoiSua") != null) _maNoiSua = dr.GetString("MaNoiSua");
            if (dr.GetString("TenNoiSua") != null) _tenNoiSua = dr.GetString("TenNoiSua");
            if (dr.GetString("Ghichu") != null) _Ghichu = dr.GetString("Ghichu");
            if (dr.GetString("DiaChi") != null) _DiaChi = dr.GetString("DiaChi");
            if (dr.GetString("DienThoai") != null) _DienThoai = dr.GetString("DienThoai");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetByte("Loai") != null) _Loai = dr.GetByte("Loai");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("Tenta") != null) _tenta = dr.GetString("Tenta");
            if (dr.GetString("HOTEN") != null) _hoten = dr.GetString("hoten");
        }

        /// <summary>
        /// Insert the new <see cref="CslaObject" /> Object to underlying database.
        /// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertCslaObject
            // Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _maNoiSua = DataProvider.Instance().InsertDMNoiSua(_tenNoiSua, _tenta, _Loai,_DiaChi, _DienThoai , _Ghichu, _maMay, _nguoiSD);
            // public abstract String InsertCslaObject(String _maVungLT, String _tenVungLT, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
            // public override String InsertCslaObject(String _maVungLT, String _tenVungLT, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maVungLT, _tenVungLT, _maMay, _huy, _ngaySD.DBValue, _nguoiSD), String);
            // }
        }

        /// <summary>
        /// Update all changes made on <see cref="CslaObject" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateCslaObject
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateDMNoiSua(_maNoiSua, _tenNoiSua, _tenta, _Loai, _DiaChi, _DienThoai, _Ghichu, _maMay, _nguoiSD , _huy);
                // public abstract void UpdateCslaObject(String _maVungLT, String _tenVungLT, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
                // public override void UpdateCslaObject(String _maVungLT, String _tenVungLT, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maVungLT, _tenVungLT, _maMay, _huy, _ngaySD.DBValue, _nguoiSD);
                // }				
            }
        }
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maNoiSua));
        }

        /// <summary>
        /// Delete the <see cref="CslaObject" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateCslaObject
            DataProvider.Instance().DeleteDMNoiSua(crit.MaMay, crit.NguoiSD, crit.MaNoiSua);
            // public abstract void DeleteCslaObject(String _maVungLT);
            // public override void DeleteCslaObject(String _maVungLT);
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maVungLT);
            // }
        }

        #endregion
    }

}
