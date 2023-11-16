
using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{

    /// <summary>
    /// This is a base generated class of <see cref="DMMGThueThuNhap" /> Business Object.
    /// </summary>

    [Serializable()]
    public partial class DMMGThueThuNhap : BusinessBase<DMMGThueThuNhap>
    {
        #region Business Methods

        #region State Fields

        private String _maMGThueThuNhap = String.Empty;
        private String _tenMGThueThuNhap = String.Empty;
        private String _ghiChu = String.Empty;
        private Decimal _mucLuong = 0;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngaySD = new SmartDate(false);
        private String _nguoiSD = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;

        #endregion

        #region Business Properties and Methods

        public String MaMGThueThuNhap
        {
            get
            {
                CanReadProperty("MaMGThueThuNhap", true);
                return _maMGThueThuNhap ;
            }
            set
            {
                CanWriteProperty("MaMGThueThuNhap", true);
                if (_maMGThueThuNhap  != value)
                {
                    _maMGThueThuNhap  = value;
                    PropertyHasChanged("MaMGThueThuNhap");
                }
            }
        }

        public String TenMGThueThuNhap
        {
            get
            {
                CanReadProperty("TenMGThueThuNhap", true);
                return _tenMGThueThuNhap;
            }
            set
            {
                CanWriteProperty("TenMGThueThuNhap", true);
                if (_tenMGThueThuNhap != value)
                {
                    _tenMGThueThuNhap = value;
                    PropertyHasChanged("TenMGThueThuNhap");
                }
            }
        }
        public string MucLuong
        {
            get
            {
                CanReadProperty("MucLuong", true);
                return _mucLuong.ToString("###,###");
            }
            set
            {
                CanWriteProperty("MucLuong", true);
                if (_mucLuong.ToString() != value)
                {
                    _mucLuong = decimal.Parse(value);
                    PropertyHasChanged("MucLuong");
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
            return _maMGThueThuNhap ;
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation

        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="DMMGThueThuNhap" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static DMMGThueThuNhap NewDMMGThueThuNhap()
        {
            return new DMMGThueThuNhap();
        }
        public static DMMGThueThuNhap GetDMMGThueThuNhap(String maLuong)
        {
            return DataPortal.Fetch<DMMGThueThuNhap>(new Criteria(maLuong));
        }

        /// <summary>
        /// Marks the <see cref="DMMGThueThuNhap" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteDMMGThueThuNhap(String maLuong, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maLuong));
        }

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        protected internal DMMGThueThuNhap()
        {
            // Prevent direct creation
        }
        internal DMMGThueThuNhap(int ordernumber, string maMGThueThuNhap, string tenMGThueThuNhap, string ghichu, decimal mucLuong, string idmay, bool huy, SmartDate ngaySD, string NguoiSD, string hoten)
        {
            _OrderNumber = ordernumber;
            _maMGThueThuNhap  = maMGThueThuNhap ;
            _tenMGThueThuNhap = tenMGThueThuNhap ;
            _ghiChu = ghichu;
            _mucLuong  = mucLuong ;
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
        /// Retrieve an existing <see cref="DMMGThueThuNhap" /> Object based on data in the database.
        /// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetDMMGThueThuNhap(String _maLuong);
            // public override IDataReader GetDMMGThueThuNhap(String _maLuong)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maLuong));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMMGThueThuNhap(crit.MaMGThueThuNhap)))
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
        /// Load a <see cref="DMMGThueThuNhap" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("MaMGThueThuNhap") != null) _maMGThueThuNhap = dr.GetString("MaMGThueThuNhap");
            if (dr.GetString("TenMGThueThuNhap") != null) _tenMGThueThuNhap = dr.GetString("TenMGThueThuNhap");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetDecimal("MucLuong") != null) _mucLuong = dr.GetDecimal("MucLuong");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", false) != null) _ngaySD = dr.GetSmartDate("NgaySD", false);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");        
            if (dr.GetString("HoTen") != null) _hoten = dr.GetString("HoTen");
        }

        /// <summary>
        /// Insert the new <see cref="DMMGThueThuNhap" /> Object to underlying database.
        /// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMMGThueThuNhap
            // Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _maMGThueThuNhap  = DataProvider.Instance().InsertDMMGThueThuNhap(_tenMGThueThuNhap, _ghiChu, _mucLuong, _maMay, _nguoiSD);
            // public abstract String InsertDMMGThueThuNhap(String _tenLuong, String _maMay, String _nguoiSD);
            // public override String InsertDMMGThueThuNhap(String _tenLuong, String _maMay, String _nguoiSD);
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenLuong, _maMay,  _nguoiSD), String);
            // }
        }

        /// <summary>
        /// Update all changes made on <see cref="DMMGThueThuNhap" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMMGThueThuNhap
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateDMMGThueThuNhap(_maMGThueThuNhap, _tenMGThueThuNhap, _ghiChu, _mucLuong , _maMay, _nguoiSD , _huy);
                // public abstract void UpdateDMMGThueThuNhap(String _maLuong, String _tenLuong, String _maMay, String _nguoiSD);
                // public override void UpdateDMMGThueThuNhap(String _maLuong, String _tenLuong, String _maMay, String _nguoiSD);
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maLuong, _tenLuong, _maMay,  _nguoiSD);
                // }				
            }
        }
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maMGThueThuNhap ));
        }

        /// <summary>
        /// Delete the <see cref="DMMGThueThuNhap" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMMGThueThuNhap
            DataProvider.Instance().DeleteDMMGThueThuNhap(crit.MaMay, crit.NguoiSD, crit.maMGThueThuNhap);
            // public abstract void DeleteDMMGThueThuNhap(String _maLuong);
            // public override void DeleteDMMGThueThuNhap(String _maLuong);
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maLuong);
            // }
        }

        #endregion
    }

}