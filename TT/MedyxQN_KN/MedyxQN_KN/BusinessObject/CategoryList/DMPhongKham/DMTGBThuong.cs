using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{

    /// <summary>
    /// This is a base generated class of <see cref="DMLoaiBA" /> Business Object.
    /// </summary>

    [Serializable()]
    public partial class DMTGBThuong : BusinessBase<DMTGBThuong>
    {
        #region Business Methods

        #region State Fields

        private String _maTGBThuong = String.Empty;
        private String _tenTGBThuong = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngaySD = new SmartDate(false);
        private String _nguoiSD = String.Empty;
        private String _ghiChu = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;

        #endregion

        #region Business Properties and Methods

        public String MaTGBThuong
        {
            get
            {
                CanReadProperty("MaTGBThuong", true);
                return _maTGBThuong;
            }
            set
            {
                CanWriteProperty("MaTGBThuong", true);
                if (_maTGBThuong != value)
                {
                    _maTGBThuong = value;
                    PropertyHasChanged("MaTGBThuong");
                }
            }
        }

        public String TenTGBThuong
        {
            get
            {
                CanReadProperty("TenTGBThuong", true);
                return _tenTGBThuong;
            }
            set
            {
                CanWriteProperty("TenTGBThuong", true);
                if (_tenTGBThuong != value)
                {
                    _tenTGBThuong = value;
                    PropertyHasChanged("TenTGBThuong");
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
            return _maTGBThuong;
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation

        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="DMLoaiBA" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static DMTGBThuong NewDMTGBThuong()
        {

            return DataPortal.Create<DMTGBThuong>();
        }
        public static DMTGBThuong GetDMTGBThuong(String maTGBThuong)
        {
            return DataPortal.Fetch<DMTGBThuong>(new Criteria(maTGBThuong));
        }

        /// <summary>
        /// Marks the <see cref="DMLoaiBA" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteDMTGBThuong(String maTGBThuong, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maTGBThuong));
        }

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        protected internal DMTGBThuong()
        {
            // Prevent direct creation
        }
        internal DMTGBThuong(int ordernumber, string MaTGBThuong, string TenTGBThuong, string idmay, bool huy, SmartDate ngaySD, string NguoiSD, string ghichu, String hoten)
        {
            _OrderNumber = ordernumber;
            _maTGBThuong = MaTGBThuong;
            _tenTGBThuong = TenTGBThuong;
            _maMay = idmay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = NguoiSD;
            _ghiChu = ghichu;
            _hoten = hoten;
        }
        #endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
            private String _maTGBThuong;
            public String MaTGBThuong
            {
                get
                {
                    return _maTGBThuong;
                }
            }

            public Criteria(String maTGBThuong)
            {
                _maTGBThuong = maTGBThuong;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maTGBThuong.Equals(c._maTGBThuong))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maTGBThuong.ToString()).GetHashCode();
            }
        }

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maTGBThuong;
            public String MaTGBThuong
            {
                get
                {
                    return _maTGBThuong;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maTGBThuong)
            {
                _maTGBThuong = maTGBThuong;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
            }


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
        /// Retrieve an existing <see cref="DMLoaiBA" /> Object based on data in the database.
        /// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetDMLoaiBA(String _maLoaiBA);
            // public override IDataReader GetDMLoaiBA(String _maLoaiBA)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maLoaiBA));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMTGBThuong(crit.MaTGBThuong)))
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
        /// Load a <see cref="DMLoaiBA" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("MaTGBThuong") != null) _maTGBThuong = dr.GetString("MaTGBThuong");
            if (dr.GetString("TenTGBThuong") != null) _tenTGBThuong = dr.GetString("TenTGBThuong");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", false) != null) _ngaySD = dr.GetSmartDate("NgaySD", false);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetString("HoTen") != null) _hoten = dr.GetString("HoTen");


        }

        /// <summary>
        /// Insert the new <see cref="DMLoaiBA" /> Object to underlying database.
        /// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMLoaiBA
            // Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _maTGBThuong = DataProvider.Instance().InsertDMTGBThuong(_tenTGBThuong, _ghiChu, _maMay, _nguoiSD);
            // public abstract String InsertDMLoaiBA(String _tenLoaiBA, String _ghiChu, String _maMay,  String _nguoiSD);
            // public override String InsertDMLoaiBA(String _tenLoaiBA, String _ghiChu, String _maMay,  String _nguoiSD);
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenLoaiBA, _ghiChu, _maMay,  _nguoiSD), String);
            // }
        }

        /// <summary>
        /// Update all changes made on <see cref="DMLoaiBA" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMLoaiBA
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateDMTGBThuong(_maTGBThuong, _tenTGBThuong, _ghiChu, _maMay, _nguoiSD , _huy );
                // public abstract void UpdateDMLoaiBA(String _maLoaiBA, String _tenLoaiBA, String _ghiChu, String _maMay, String _nguoiSD);
                // public override void UpdateDMLoaiBA(String _maLoaiBA, String _tenLoaiBA, String _ghiChu, String _maMay, String _nguoiSD);
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maLoaiBA, _tenLoaiBA, _ghiChu, _maMay, _nguoiSD);
                // }				
            }
        }
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maTGBThuong));
        }

        /// <summary>
        /// Delete the <see cref="DMLoaiBA" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMLoaiBA
            DataProvider.Instance().DeleteDMTGBThuong(crit.MaMay, crit.NguoiSD, crit.MaTGBThuong);
            // public abstract void DeleteDMLoaiBA(String _maLoaiBA);
            // public override void DeleteDMLoaiBA(String _maLoaiBA);
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maLoaiBA);
            // }
        }

        #endregion
    }

}