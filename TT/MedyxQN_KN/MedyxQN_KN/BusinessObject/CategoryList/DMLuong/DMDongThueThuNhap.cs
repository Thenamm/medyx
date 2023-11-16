
using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{

    /// <summary>
    /// This is a base generated class of <see cref="DMDongThueThuNhap" /> Business Object.
    /// </summary>

    [Serializable()]
    public partial class DMDongThueThuNhap : BusinessBase<DMDongThueThuNhap>
    {
        #region Business Methods

        #region State Fields

        private String _maDongThueThuNhap = String.Empty;
        private String _tenDongThueThuNhap = String.Empty;
        private String _ghiChu = String.Empty;
        private Decimal _soTienTu = 0;
        private Decimal _soTienDen = 0;
        private Decimal _heSo = 0;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngaySD = new SmartDate(false);
        private String _nguoiSD = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;

        #endregion

        #region Business Properties and Methods

        public String MaDongThueThuNhap
        {
            get
            {
                CanReadProperty("MaDongThueThuNhap", true);
                return _maDongThueThuNhap;
            }
            set
            {
                CanWriteProperty("MaDongThueThuNhap", true);
                if (_maDongThueThuNhap != value)
                {
                    _maDongThueThuNhap = value;
                    PropertyHasChanged("MaDongThueThuNhap");
                }
            }
        }

        public String TenDongThueThuNhap
        {
            get
            {
                CanReadProperty("TenDongThueThuNhap", true);
                return _tenDongThueThuNhap;
            }
            set
            {
                CanWriteProperty("TenDongThueThuNhap", true);
                if (_tenDongThueThuNhap != value)
                {
                    _tenDongThueThuNhap = value;
                    PropertyHasChanged("TenDongThueThuNhap");
                }
            }
        }

        public String GhiChu
        {
            get
            {
                CanReadProperty("GhiChu", true);
                return _ghiChu;
            }
            set
            {
                CanWriteProperty("GhiChu", true);
                if (_ghiChu != value)
                {
                    _ghiChu = value;
                    PropertyHasChanged("GhiChu");
                }
            }
        }

        public Decimal SoTienTu
        {
            get
            {
                CanReadProperty("SoTienTu", true);
                return _soTienTu;
            }
            set
            {
                CanWriteProperty("SoTienTu", true);
                if (_soTienTu != value)
                {
                    _soTienTu = value;
                    PropertyHasChanged("SoTienTu");
                }
            }
        }

        public Decimal SoTienDen
        {
            get
            {
                CanReadProperty("SoTienDen", true);
                return _soTienDen;
            }
            set
            {
                CanWriteProperty("SoTienDen", true);
                if (_soTienDen != value)
                {
                    _soTienDen = value;
                    PropertyHasChanged("SoTienDen");
                }
            }
        }

        public Decimal HeSo
        {
            get
            {
                CanReadProperty("HeSo", true);
                return _heSo;
            }
            set
            {
                CanWriteProperty("HeSo", true);
                if (_heSo != value)
                {
                    _heSo = value;
                    PropertyHasChanged("HeSo");
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
            return _maDongThueThuNhap ;
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation

        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="DMDongThueThuNhap" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static DMDongThueThuNhap NewDMDongThueThuNhap()
        {
            return new DMDongThueThuNhap();
        }
        public static DMDongThueThuNhap GetDMDongThueThuNhap(String maLuong)
        {
            return DataPortal.Fetch<DMDongThueThuNhap>(new Criteria(maLuong));
        }

        /// <summary>
        /// Marks the <see cref="DMDongThueThuNhap" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteDMDongThueThuNhap(String maLuong, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maLuong));
        }

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        protected internal DMDongThueThuNhap()
        {
            // Prevent direct creation
        }
        internal DMDongThueThuNhap(int ordernumber,  String maDongThueThuNhap ,
         String tenDongThueThuNhap ,
         String ghiChu ,
         Decimal soTienTu ,
         Decimal soTienDen ,
         Decimal heSo , string idmay, bool huy, SmartDate ngaySD, string NguoiSD, string hoten)
        {
            _OrderNumber = ordernumber;
              _maDongThueThuNhap = maDongThueThuNhap ;
          _tenDongThueThuNhap = tenDongThueThuNhap ;
          _ghiChu =ghiChu ;
          _soTienTu = soTienTu ;
          _soTienDen = soTienDen ;
          _heSo = heSo ;
            _maMay = idmay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = NguoiSD;      
            _hoten = hoten;
        }
        #endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
            private String _maMGThueThuNhap;
            public String MaMGThueThuNhap
            {
                get
                {
                    return _maMGThueThuNhap;
                }
            }

            public Criteria(String maMGThueThuNhap)
            {
                _maMGThueThuNhap = maMGThueThuNhap ;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maMGThueThuNhap.Equals(c._maMGThueThuNhap))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maMGThueThuNhap.ToString()).GetHashCode();
            }
        }
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maMGThueThuNhap;
            public String maMGThueThuNhap
            {
                get
                {
                    return _maMGThueThuNhap ;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maMGThueThuNhap)
            {
                _maMGThueThuNhap = maMGThueThuNhap ;
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
        /// Retrieve an existing <see cref="DMDongThueThuNhap" /> Object based on data in the database.
        /// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetDMDongThueThuNhap(String _maLuong);
            // public override IDataReader GetDMDongThueThuNhap(String _maLuong)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maLuong));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMDongThueThuNhap(crit.MaMGThueThuNhap)))
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
        /// Load a <see cref="DMDongThueThuNhap" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("MaDongThueThuNhap") != null) _maDongThueThuNhap = dr.GetString("MaDongThueThuNhap");
            if (dr.GetString("TenDongThueThuNhap") != null) _tenDongThueThuNhap = dr.GetString("TenDongThueThuNhap");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetDecimal("SoTienTu") != null) _soTienTu = dr.GetDecimal("SoTienTu");
            if (dr.GetDecimal("SoTienDen") != null) _soTienDen = dr.GetDecimal("SoTienDen");
            if (dr.GetDecimal("HeSo") != null) _heSo = dr.GetDecimal("HeSo");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", false) != null) _ngaySD = dr.GetSmartDate("NgaySD", false);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");        
            if (dr.GetString("HoTen") != null) _hoten = dr.GetString("HoTen");
        }

        /// <summary>
        /// Insert the new <see cref="DMDongThueThuNhap" /> Object to underlying database.
        /// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDongThueThuNhap
            // Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _maDongThueThuNhap = DataProvider.Instance().InsertDMDongThueThuNhap(_tenDongThueThuNhap, _ghiChu, _soTienTu, _soTienDen, _heSo, _maMay, _nguoiSD);
            // public abstract String InsertDMDongThueThuNhap(String _tenDongThueThuNhap, String _ghiChu, Decimal _soTienTu, Decimal _soTienDen, Decimal _heSo, String _maMay, String _nguoiSD);
            // public override String InsertDMDongThueThuNhap(String _tenDongThueThuNhap, String _ghiChu, Decimal _soTienTu, Decimal _soTienDen, Decimal _heSo, String _maMay, String _nguoiSD)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDongThueThuNhap_CREATE", _tenDongThueThuNhap, _ghiChu, _soTienTu, _soTienDen, _heSo, _maMay,  _nguoiSD), String);
            // }
        }

        /// <summary>
        /// Update all changes made on <see cref="DMDongThueThuNhap" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDongThueThuNhap
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateDMDongThueThuNhap(_maDongThueThuNhap, _tenDongThueThuNhap, _ghiChu, _soTienTu, _soTienDen, _heSo, _maMay, _nguoiSD , _huy);
                // public abstract void UpdateDMDongThueThuNhap(String _maLuong, String _tenDongThueThuNhap, String _ghiChu, Decimal _soTienTu, Decimal _soTienDen, Decimal _heSo, String _maMay, String _nguoiSD);
                // public override void UpdateDMDongThueThuNhap(String _maLuong, String _tenDongThueThuNhap, String _ghiChu, Decimal _soTienTu, Decimal _soTienDen, Decimal _heSo, String _maMay, String _nguoiSD)
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDongThueThuNhap_UPDATED", _maLuong, _tenDongThueThuNhap, _ghiChu, _soTienTu, _soTienDen, _heSo, _maMay,  _nguoiSD);
                // }				
            }
        }
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maDongThueThuNhap ));
        }

        /// <summary>
        /// Delete the <see cref="DMDongThueThuNhap" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDongThueThuNhap
            DataProvider.Instance().DeleteDMDongThueThuNhap(crit.MaMay, crit.NguoiSD, crit.maMGThueThuNhap);
            // public abstract void DeleteDMDongThueThuNhap(String _maLuong);
            // public override void DeleteDMDongThueThuNhap(String _maLuong)
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDongThueThuNhap_DELETED", _maLuong);
            // }
        }

        #endregion
    }

}