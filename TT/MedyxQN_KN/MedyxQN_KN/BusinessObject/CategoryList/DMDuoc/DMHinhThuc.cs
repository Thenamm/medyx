// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMHinhThuc
// Kieu doi tuong  :	DMHinhThuc
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
    /// This is a base generated class of <see cref="DMHinhThuc" /> Business Object.
    /// </summary>

    [Serializable()]
    public partial class DMHinhThuc : BusinessBase<DMHinhThuc>
    {
        #region Business Methods

        #region State Fields

        private String _maHinhThuc = String.Empty;
        private String _tenHinhThuc = String.Empty;
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

        public String MaHinhThuc
        {
            get
            {
                CanReadProperty("MaHinhThuc", true);
                return _maHinhThuc;
            }
            set
            {
                CanWriteProperty("MaHinhThuc", true);
                if (_maHinhThuc != value)
                {
                    _maHinhThuc = value;
                    PropertyHasChanged("MaHinhThuc");
                }
            }
        }

        public String TenHinhThuc
        {
            get
            {
                CanReadProperty("TenHinhThuc", true);
                return _tenHinhThuc;
            }
            set
            {
                CanWriteProperty("TenHinhThuc", true);
                if (_tenHinhThuc != value)
                {
                    _tenHinhThuc = value;
                    PropertyHasChanged("TenHinhThuc");
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
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm";
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
            return _maHinhThuc;
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenHinhThuc", 150));
            ValidationRules.AddRule<DMHinhThuc>(StringRequired<DMHinhThuc>, "TenHinhThuc");


        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMHinhThuc
        {

            if (target._tenHinhThuc == null || target._tenHinhThuc.Trim().Length == 0)
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
        /// Factory method. New <see cref="DMHinhThuc" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static DMHinhThuc NewDMHinhThuc()
        {
            //return new DMHinhThuc();
            return DataPortal.Create<DMHinhThuc>();
        }
        public static DMHinhThuc GetDMHinhThuc(String maHinhThuc)
        {
            return DataPortal.Fetch<DMHinhThuc>(new Criteria(maHinhThuc));
        }

        /// <summary>
        /// Marks the <see cref="DMHinhThuc" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteDMHinhThuc(String maHinhThuc, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maHinhThuc));
        }

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham HinhThuci tao duoi day voi tu HinhThuca public !!!
        protected internal DMHinhThuc()
        {
            // Prevent direct creation
        }

        internal DMHinhThuc(int ordernumber, string MaQG, string TenQG, string Ghichu, string idmay, Byte Loai, bool huy, bool khongsd, SmartDate ngaySD, string NguoiSD, String tenta, string hoten)
        {
            _OrderNumber = ordernumber;
            _maHinhThuc = MaQG;
            _tenHinhThuc = TenQG;
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
            private String _maHinhThuc;
            public String MaHinhThuc
            {
                get
                {
                    return _maHinhThuc;
                }
            }

            public Criteria(String maHinhThuc)
            {
                _maHinhThuc = maHinhThuc;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maHinhThuc.Equals(c._maHinhThuc))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maHinhThuc.ToString()).GetHashCode();
            }
        }

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maHinhThuc;
            public String MaHinhThuc
            {
                get
                {
                    return _maHinhThuc;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maHinhThuc)
            {
                _maHinhThuc = maHinhThuc;
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
        /// Retrieve an existing <see cref="DMHinhThuc" /> Object based on data in the database.
        /// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetDMHinhThuc(String _maHinhThuc);
            // public override IDataReader GetDMHinhThuc(String _maHinhThuc)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maHinhThuc));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMHinhThuc(crit.MaHinhThuc)))
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
        /// Load a <see cref="DMHinhThuc" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("MaHinhThuc") != null) _maHinhThuc = dr.GetString("MaHinhThuc");
            if (dr.GetString("TenHinhThuc") != null) _tenHinhThuc = dr.GetString("TenHinhThuc");
            if (dr.GetString("Ghichu") != null) _Ghichu = dr.GetString("Ghichu");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetByte("Loai") != null) _Loai = dr.GetByte("Loai");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetBoolean("KhongSD") != null) _KhongSD = dr.GetBoolean("KhongSD");
            if (dr.GetSmartDate("NgaySD", false) != null) _ngaySD = dr.GetSmartDate("NgaySD", false);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("Tenta") != null) _tenta = dr.GetString("Tenta");

        }

        /// <summary>
        /// Insert the new <see cref="DMHinhThuc" /> Object to underlying database.
        /// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMHinhThuc
            // Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _maHinhThuc = DataProvider.Instance().InsertDMHinhThuc(_tenHinhThuc, _Ghichu, _maMay, _Loai, _nguoiSD , _tenta);
            // public abstract String InsertDMHinhThuc(String _maHinhThuc, String _tenHinhThuc, Boolean _HinhThucchinh, String _ghichu, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
            // public override String InsertDMHinhThuc(String _maHinhThuc, String _tenHinhThuc, Boolean _HinhThucchinh, String _ghichu, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maHinhThuc, _tenHinhThuc, _HinhThucchinh, _ghichu, _maMay, _huy, _ngaySD.DBValue, _nguoiSD), String);
            // }
        }

        /// <summary>
        /// Update all changes made on <see cref="DMHinhThuc" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMHinhThuc
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateDMHinhThuc(_maHinhThuc, _tenHinhThuc, _Ghichu, _maMay, _Loai, _huy, _KhongSD, _nguoiSD , _tenta);
                // public abstract void UpdateDMHinhThuc(String _maHinhThuc, String _tenHinhThuc, Boolean _HinhThucchinh, String _ghichu, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
                // public override void UpdateDMHinhThuc(String _maHinhThuc, String _tenHinhThuc, Boolean _HinhThucchinh, String _ghichu, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maHinhThuc, _tenHinhThuc, _HinhThucchinh, _ghichu, _maMay, _huy, _ngaySD.DBValue, _nguoiSD);
                // }				
            }
        }
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maHinhThuc));
        }

        /// <summary>
        /// Delete the <see cref="DMHinhThuc" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMHinhThuc
            DataProvider.Instance().DeleteDMHinhThuc(crit.MaMay, crit.NguoiSD, crit.MaHinhThuc);
            // public abstract void DeleteDMHinhThuc(String _maHinhThuc);
            // public override void DeleteDMHinhThuc(String _maHinhThuc);
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maHinhThuc);
            // }
        }

        #endregion
    }

}
