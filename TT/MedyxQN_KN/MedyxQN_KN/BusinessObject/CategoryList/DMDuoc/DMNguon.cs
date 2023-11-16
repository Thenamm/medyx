// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMNguon
// Kieu doi tuong  :	DMNguon
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	11/7/2008 9:56:20 AM
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
    /// This is a base generated class of <see cref="DMNguon" /> Business Object.
    /// </summary>

    [Serializable()]
    public partial class DMNguon : BusinessBase<DMNguon>
    {
        #region Business Methods

        #region State Fields

        private String _maNguon = String.Empty;
        private String _tenNguon = String.Empty;
        private String _tenta = String.Empty;
        private String _Ghichu = String.Empty;
        private String _maMay = String.Empty;
        private Byte _Loai;
        private Boolean _huy = false;
        private Boolean _KhongSD = false;
        private SmartDate _ngaySD = new SmartDate(false);
        private String _nguoiSD = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;


        #endregion

        #region Business Properties and Methods

        public String MaNguon
        {
            get
            {
                CanReadProperty("MaNguon", true);
                return _maNguon;
            }
            set
            {
                CanWriteProperty("MaNguon", true);
                if (_maNguon != value)
                {
                    _maNguon = value;
                    PropertyHasChanged("MaNguon");
                }
            }
        }

        public String TenNguon
        {
            get
            {
                CanReadProperty("TenNguon", true);
                return _tenNguon;
            }
            set
            {
                CanWriteProperty("TenNguon", true);
                if (_tenNguon != value)
                {
                    _tenNguon = value;
                    PropertyHasChanged("TenNguon");
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

        public Boolean KhongSD
        {
            get
            {
                CanReadProperty("KhongSD", true);
                return _KhongSD;
            }
            set
            {
                CanWriteProperty("KhongSD", true);
                if (_KhongSD != value)
                {
                    _KhongSD = value;
                    PropertyHasChanged("KhongSD");
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
            return _maNguon;
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenNguon", 150));
            ValidationRules.AddRule<DMNguon>(StringRequired<DMNguon>, "TenNguon");


        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMNguon
        {

            if (target._tenNguon == null || target._tenNguon.Trim().Length == 0)
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
        /// Factory method. New <see cref="DMNguon" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static DMNguon NewDMNguon()
        {
            //return new DMNguon();
            return DataPortal.Create<DMNguon>();
        }
        public static DMNguon GetDMNguon(String maNguon)
        {
            return DataPortal.Fetch<DMNguon>(new Criteria(maNguon));
        }

        /// <summary>
        /// Marks the <see cref="DMNguon" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteDMNguon(String maNguon, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maNguon));
        }

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham Nguoni tao duoi day voi tu Nguona public !!!
        protected internal DMNguon()
        {
            // Prevent direct creation
        }

        internal DMNguon(int ordernumber, string MaQG, string TenQG, string Ghichu, string idmay, Byte Loai, bool huy, bool khongsd, SmartDate ngaySD, string NguoiSD, String tenta, string hoten)
        {
            _OrderNumber = ordernumber;
            _maNguon = MaQG;
            _tenNguon = TenQG;
            _Ghichu = Ghichu;
            _maMay = idmay;
            _Loai = Loai;
            _huy = huy;
            _KhongSD = khongsd;
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
            private String _maNguon;
            public String MaNguon
            {
                get
                {
                    return _maNguon;
                }
            }

            public Criteria(String maNguon)
            {
                _maNguon = maNguon;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maNguon.Equals(c._maNguon))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maNguon.ToString()).GetHashCode();
            }
        }

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maNguon;
            public String MaNguon
            {
                get
                {
                    return _maNguon;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maNguon)
            {
                _maNguon = maNguon;
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
        /// Retrieve an existing <see cref="DMNguon" /> Object based on data in the database.
        /// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetDMNguon(String _maNguon);
            // public override IDataReader GetDMNguon(String _maNguon)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNguon));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMNguon(crit.MaNguon)))
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
        /// Load a <see cref="DMNguon" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("MaNguon") != null) _maNguon = dr.GetString("MaNguon");
            if (dr.GetString("TenNguon") != null) _tenNguon = dr.GetString("TenNguon");
            if (dr.GetString("Ghichu") != null) _Ghichu = dr.GetString("Ghichu");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetByte("Loai") != null) _Loai = dr.GetByte("Loai");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetBoolean("KhongSD") != null) _KhongSD = dr.GetBoolean("KhongSD");
            if (dr.GetSmartDate("NgaySD", false) != null) _ngaySD = dr.GetSmartDate("NgaySD", false);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("Tenta") != null) _tenta = dr.GetString("Tenta");
            if (dr.GetString("hoten") != null) _hoten = dr.GetString("hoten");


        }

        /// <summary>
        /// Insert the new <see cref="DMNguon" /> Object to underlying database.
        /// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMNguon
            // Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _maNguon = DataProvider.Instance().InsertDMNguon(_tenNguon, _Ghichu, _maMay, _Loai, _nguoiSD , _tenta);
            // public abstract String InsertDMNguon(String _maNguon, String _tenNguon, Boolean _Nguonchinh, String _ghichu, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
            // public override String InsertDMNguon(String _maNguon, String _tenNguon, Boolean _Nguonchinh, String _ghichu, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNguon, _tenNguon, _Nguonchinh, _ghichu, _maMay, _huy, _ngaySD.DBValue, _nguoiSD), String);
            // }
        }

        /// <summary>
        /// Update all changes made on <see cref="DMNguon" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMNguon
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateDMNguon(_maNguon, _tenNguon, _Ghichu, _maMay, _Loai, _huy, _KhongSD, _nguoiSD , _tenta);
                // public abstract void UpdateDMNguon(String _maNguon, String _tenNguon, Boolean _Nguonchinh, String _ghichu, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
                // public override void UpdateDMNguon(String _maNguon, String _tenNguon, Boolean _Nguonchinh, String _ghichu, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNguon, _tenNguon, _Nguonchinh, _ghichu, _maMay, _huy, _ngaySD.DBValue, _nguoiSD);
                // }				
            }
        }
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maNguon));
        }

        /// <summary>
        /// Delete the <see cref="DMNguon" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMNguon
            DataProvider.Instance().DeleteDMNguon(crit.MaMay, crit.NguoiSD, crit.MaNguon);
            // public abstract void DeleteDMNguon(String _maNguon);
            // public override void DeleteDMNguon(String _maNguon);
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNguon);
            // }
        }

        #endregion
    }

}
