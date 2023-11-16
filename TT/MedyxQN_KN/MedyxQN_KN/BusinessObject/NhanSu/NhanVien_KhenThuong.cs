




using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace HTC.Business.NhanSu
{

    /// <summary>
    /// This is a base generated class of <see cref="NhanVien_QTCongTac" /> Business Object.
    /// </summary>

    [Serializable()]
    public partial class NhanVien_KhenThuong : BusinessBase<NhanVien_KhenThuong>
    {
        #region Business Methods

        #region State Fields

        private String _maNV = String.Empty;
        private Int32 _sTT = 0;
        private SmartDate _ngayKT = new SmartDate(true);
        private SmartDate _ngayKTD = new SmartDate(true);
        private String _maCapKTKL = String.Empty;
        private String _maHTKhen = String.Empty;
        private String _noiDungKT = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenCapKTKL = String.Empty;
        private String _tenHTKhen = String.Empty;
        private int _OrderNumber;

        #endregion

        #region Business Properties and Methods

        public String MaNV
        {
            get
            {
                CanReadProperty("MaNV", true);
                return _maNV;
            }
            set
            {
                CanWriteProperty("MaNV", true);
                if (_maNV != value)
                {
                    _maNV = value;
                    PropertyHasChanged("MaNV");
                }
            }
        }

        public Int32 STT
        {
            get
            {
                CanReadProperty("STT", true);
                return _sTT;
            }
            set
            {
                CanWriteProperty("STT", true);
                if (_sTT != value)
                {
                    _sTT = value;
                    PropertyHasChanged("STT");
                }
            }
        }

        public string NgayKT
        {
            get
            {
                CanReadProperty("NgayKT", true);
                return _ngayKT.Text;
            }
            set
            {
                CanWriteProperty("NgayKT", true);
                if (_ngayKT.Text != value)
                {
                    _ngayKT.Text = value;
                    PropertyHasChanged("NgayKT");
                }
            }
        }

        public string NgayKTD
        {
            get
            {
                CanReadProperty("NgayKTD", true);
                _ngayKTD  = _ngayKT;
                _ngayKTD.FormatString = "dd/MM/yyyy";
                return _ngayKTD.Text;
            }

        }

        public String MaCapKTKL
        {
            get
            {
                CanReadProperty("MaCapKTKL", true);
                return _maCapKTKL;
            }
            set
            {
                CanWriteProperty("MaCapKTKL", true);
                if (_maCapKTKL != value)
                {
                    _maCapKTKL = value;
                    PropertyHasChanged("MaCapKTKL");
                }
            }
        }

        public String MaHTKhen
        {
            get
            {
                CanReadProperty("MaHTKhen", true);
                return _maHTKhen;
            }
            set
            {
                CanWriteProperty("MaHTKhen", true);
                if (_maHTKhen != value)
                {
                    _maHTKhen = value;
                    PropertyHasChanged("MaHTKhen");
                }
            }
        }

        public String NoiDungKT
        {
            get
            {
                CanReadProperty("NoiDungKT", true);
                return _noiDungKT;
            }
            set
            {
                CanWriteProperty("NoiDungKT", true);
                if (_noiDungKT != value)
                {
                    _noiDungKT = value;
                    PropertyHasChanged("NoiDungKT");
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

        public string NgaySD
        {
            get
            {
                CanReadProperty("NgaySD", true);
                return _ngaySD.Text;
            }
            set
            {
                CanWriteProperty("NgaySD", true);
                if (_ngaySD.Text != value)
                {
                    _ngaySD.Text = value;
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

        public String TenNguoiSD
        {
            get
            {
                CanReadProperty("TenNguoiSD", true);
                return _tenNguoiSD;
            }
            set
            {
                CanWriteProperty("TenNguoiSD", true);
                if (_tenNguoiSD != value)
                {
                    _tenNguoiSD = value;
                    PropertyHasChanged("TenNguoiSD");
                }
            }
        }

        public String TenCapKTKL
        {
            get
            {
                CanReadProperty("TenCapKTKL", true);
                return _tenCapKTKL;
            }
            set
            {
                CanWriteProperty("TenCapKTKL", true);
                if (_tenCapKTKL != value)
                {
                    _tenCapKTKL = value;
                    PropertyHasChanged("TenCapKTKL");
                }
            }
        }


        public String TenHTKhen
        {
            get
            {
                CanReadProperty("TenHTKhen", true);
                return _tenHTKhen;
            }
            set
            {
                CanWriteProperty("TenHTKhen", true);
                if (_tenHTKhen != value)
                {
                    _tenHTKhen = value;
                    PropertyHasChanged("TenHTKhen");
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
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                }
            }
        }

        protected override Object GetIdValue()
        {
            return _maNV.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation

        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="NhanVien_QTCongTac" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static NhanVien_KhenThuong NewNhanVien_KhenThuong()
        {
            return DataPortal.Create<NhanVien_KhenThuong>();
        }
        internal static NhanVien_KhenThuong GetNhanVien_KhenThuong(SafeDataReader dr, int i)
        {
            return new NhanVien_KhenThuong(dr, i);
        }
        public NhanVien_KhenThuong()
        {
            MarkAsChild();
        }
        //public static NhanVien_QTCongTac GetNhanVien_QTCongTac(String maNV, Int32 sTT)
        //{
        //    return DataPortal.Fetch<NhanVien_QTCongTac>(new Criteria(maNV, sTT));
        //}

        /// <summary>
        /// Marks the <see cref="NhanVien_QTCongTac" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        //public static void DeleteNhanVien_QTCongTac(String maNV, Int32 sTT)
        //{
        //    DataPortal.Delete(new Criteria(maNV, sTT));
        //}

        #endregion

        //#region Constructors
        //// Chu y !!!
        //// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        //// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal NhanVien_QTCongTac()
        //{	
        //    // Prevent direct creation
        //}

        //#endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
            private String _maNV;
            public String MaNV
            {
                get
                {
                    return _maNV;
                }
            }

            private Int32 _sTT;
            public Int32 STT
            {
                get
                {
                    return _sTT;
                }
            }

            public Criteria(String maNV, Int32 sTT)
            {
                _maNV = maNV;
                _sTT = sTT;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maNV.Equals(c._maNV))
                        return false;
                    if (!_sTT.Equals(c._sTT))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maNV.ToString(), _sTT.ToString()).GetHashCode();
            }
        }
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maNV;
            public String MaNV
            {
                get
                {
                    return _maNV;
                }
            }

            private Int32 _sTT;
            public Int32 STT
            {
                get
                {
                    return _sTT;
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

            public OtherCriteria(String Mamay, String Nguoisd, String maNV, Int32 sTT)
            {
                _maNV = maNV;
                _sTT = sTT;
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
        /// Retrieve an existing <see cref="NhanVien_QTCongTac" /> Object based on data in the database.
        /// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetNhanVien_QTCongTac(String _maNV, Int32 _sTT);
        //    // public override IDataReader GetNhanVien_QTCongTac(String _maNV, Int32 _sTT)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNV, _sTT));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetNhanVien_QTCongTac(crit.MaNV, crit.STT)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
        /// <summary>
        /// Load a <see cref="NhanVien_QTCongTac" /> Object from given SafeDataReader.
        /// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
        //    if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
        //    if (dr.GetSmartDate("Tungay", true) != null) _tungay = dr.GetSmartDate("Tungay", true);
        //    if (dr.GetString("Congviec") != null) _congviec = dr.GetString("Congviec");
        //    if (dr.GetString("NoiLamviec") != null) _noiLamviec = dr.GetString("NoiLamviec");
        //    if (dr.GetString("SoHD") != null) _soHD = dr.GetString("SoHD");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //    if (dr.GetString("MaLoaiHD") != null) _maLoaiHD = dr.GetString("MaLoaiHD");
        //    if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
        //}
        private NhanVien_KhenThuong(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetSmartDate("NgayKT", true) != null) _ngayKT = dr.GetSmartDate("NgayKT", true);
            if (dr.GetString("MaCapKTKL") != null) _maCapKTKL = dr.GetString("MaCapKTKL");
            if (dr.GetString("MaHTKhen") != null) _maHTKhen  = dr.GetString("MaHTKhen");
            if (dr.GetString("NoiDungKT") != null) _noiDungKT = dr.GetString("NoiDungKT");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("TenCapKTKL") != null) _tenCapKTKL = dr.GetString("TenCapKTKL");
            if (dr.GetString("TenHTKhen") != null) _tenHTKhen = dr.GetString("TenHTKhen");

            MarkOld();
        }
        /// <summary>
        /// Insert the new <see cref="NhanVien_QTCongTac" /> Object to underlying database.
        /// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            _ngaySD.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_DongTien
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
              
            _maNV = DataProvider.Instance().InsertNhanVien_KhenThuong(_maNV, _ngayKT , _maCapKTKL , _maHTKhen , _noiDungKT, _maMay, _nguoiSD);
            // public abstract String InsertNhanVien_QTCongTac(String _maNV, SmartDate _tungay, String _congviec, String _noiLamviec, String _soHD, String _maMay, String _nguoiSD, String _maLoaiHD, String _maKhoa);
            // public override String InsertNhanVien_QTCongTac(String _maNV, SmartDate _tungay, String _congviec, String _noiLamviec, String _soHD, String _maMay, String _nguoiSD, String _maLoaiHD, String _maKhoa)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spNHANVIEN_QTCONGTAC_Create", _maNV,  _tungay.DBValue, _congviec, _noiLamviec, _soHD, _maMay, _nguoiSD , _maLoaiHD, _maKhoa));
            // }
        }

        /// <summary>
        /// Update all changes made on <see cref="NhanVien_QTCongTac" /> Object to underlying database.
        /// </summary>
        internal void Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_DongTien
            if (!this.IsDirty)
                return;
            
              
            DataProvider.Instance().UpdateNhanVien_KhenThuong(_maNV, _sTT, _ngayKT , _maCapKTKL , _maHTKhen , _noiDungKT, _maMay, _huy, _nguoiSD);
            // public abstract void UpdateNhanVien_QTCongTac(String _maNV, Int32 _sTT, SmartDate _tungay, String _congviec, String _noiLamviec, String _soHD, String _maMay, Boolean _huy, String _nguoiSD, String _maLoaiHD, String _maKhoa);
            // public override void UpdateNhanVien_QTCongTac(String _maNV, Int32 _sTT, SmartDate _tungay, String _congviec, String _noiLamviec, String _soHD, String _maMay, Boolean _huy, String _nguoiSD, String _maLoaiHD, String _maKhoa)
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spNHANVIEN_QTCONGTAC_Update", _maNV, _sTT, _tungay.DBValue, _congviec, _noiLamviec, _soHD, _maMay, _huy, _nguoiSD , _maLoaiHD, _maKhoa);
            // }				

        }
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
              
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maNV, _sTT));
            MarkNew();
        }

        /// <summary>
        /// Delete the <see cref="NhanVien_QTCongTac" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateNhanVien_QTCongTac
            DataProvider.Instance().DeleteNhanVien_KhenThuong(crit.MaMay, crit.NguoiSD, crit.MaNV, crit.STT);
            // public abstract void DeleteNhanVien_QTCongTac(String _maNV, Int32 _sTT);
            // public override void DeleteNhanVien_QTCongTac(String _maNV, Int32 _sTT);
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spNHANVIEN_QTCONGTAC_DELETED", _maNV, _sTT);
            // }
        }

        #endregion
    }

}
