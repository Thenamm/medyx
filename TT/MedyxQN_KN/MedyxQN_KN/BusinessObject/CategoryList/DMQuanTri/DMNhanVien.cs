// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMNhanVien
// Kieu doi tuong  :	DMNhanVien
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	11/5/2008 4:20:21 PM
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

namespace HTC.Business.CategoryList
{

    /// <summary>
    /// This is a base generated class of <see cref="DMNhanVien" /> Business Object.
    /// </summary>

    [Serializable()]
    public partial class DMNhanVien : BusinessBase<DMNhanVien>
    {
        #region Business Methods

        #region State Fields

        private String _maNV = String.Empty;
        private string _hoTen = string.Empty;
        private String _maChucVu = String.Empty;
        private String _maLoaiHD = String.Empty;
        private String _maChuyenMon = String.Empty;
        private String _maCD = String.Empty;
        private String _maKhoa = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private Boolean _khongsd = false;
        private SmartDate _ngaySD = new SmartDate(false);
        private String _nguoiSD = String.Empty;
        private String _TenNguoiSD = String.Empty;
        private String _TenKhoa = String.Empty;
        private string _tenChuyenMon = String.Empty;
        private String _tenChucVu = String.Empty;
        private String _tenCD = String.Empty;
        private String _tentat = String.Empty;
        private String _ghichu = String.Empty;
        private string _idnhanvien = String.Empty;
        private int _OrderNumber;
        private String _dienThoai = String.Empty;
        private String _maChungChiHanhNghe = String.Empty;
        private String _NguoiGiamHo = String.Empty;
        private String _TenNguoiGiamHo = String.Empty;
        private String _TenLoaiHD = String.Empty;
        private String _DienThoaiKhoa = String.Empty;
        private string _ChuKy = String.Empty;
        #endregion

        #region Business Properties and Methods
        public string ChuKy
        {
            get
            {
                CanReadProperty("ChuKy", true);
                return _ChuKy;
            }
            set
            {
                CanWriteProperty("ChuKy", true);
                if (_ChuKy != value)
                {
                    _ChuKy = value;
                    PropertyHasChanged("_ChuKy");
                }
                //bool setNewValue = false;
                //if (value != null && _ChuKy == null)
                //    setNewValue = true;
                //if (!setNewValue && value != null && _ChuKy != null)
                //{
                //    if (_ChuKy.Length != value.Length)
                //    {
                //        setNewValue = true;
                //    }
                //    else
                //    {
                //        for (int i = 0; i < value.Length; i++)
                //        {
                //            if (value[i] != _ChuKy[i])
                //            {
                //                setNewValue = true;
                //                break;
                //            }
                //        }
                //    }
                //}
                //if (setNewValue)
                //{
                //    _ChuKy = value;
                //    PropertyHasChanged("ChuKy");
                //}
            }
        }
        public String DienThoaiKhoa
        {
            get
            {
                CanReadProperty("DienThoaiKhoa", true);
                return _DienThoaiKhoa;
            }
            set
            {
                CanWriteProperty("DienThoaiKhoa", true);
                if (_DienThoaiKhoa != value)
                {
                    _DienThoaiKhoa = value;
                    PropertyHasChanged("DienThoaiKhoa");
                }
            }
        }
        public String TenLoaiHD
        {
            get
            {
                CanReadProperty("TenLoaiHD", true);
                return _TenLoaiHD;
            }
            set
            {
                CanWriteProperty("TenLoaiHD", true);
                if (_TenLoaiHD != value)
                {
                    _TenLoaiHD = value;
                    PropertyHasChanged("TenLoaiHD");
                }
            }
        }
        public String TenNguoiGiamHo
        {
            get
            {
                CanReadProperty("TenNguoiGiamHo", true);
                return _TenNguoiGiamHo;
            }
            set
            {
                CanWriteProperty("TenNguoiGiamHo", true);
                if (_TenNguoiGiamHo != value)
                {
                    _TenNguoiGiamHo = value;
                    PropertyHasChanged("TenNguoiGiamHo");
                }
            }
        }
        public String NguoiGiamHo
        {
            get
            {
                CanReadProperty("NguoiGiamHo", true);
                return _NguoiGiamHo;
            }
            set
            {
                CanWriteProperty("NguoiGiamHo", true);
                if (_NguoiGiamHo != value)
                {
                    _NguoiGiamHo = value;
                    PropertyHasChanged("NguoiGiamHo");
                }
            }
        }
        public String DienThoai
        {
            get
            {
                CanReadProperty("DienThoai", true);
                return _dienThoai;
            }
            set
            {
                CanWriteProperty("DienThoai", true);
                if (_dienThoai != value)
                {
                    _dienThoai = value;
                    PropertyHasChanged("DienThoai");
                }
            }
        }

        public String MaChungChiHanhNghe
        {
            get
            {
                CanReadProperty("MaChungChiHanhNghe", true);
                return _maChungChiHanhNghe;
            }
            set
            {
                CanWriteProperty("MaChungChiHanhNghe", true);
                if (_maChungChiHanhNghe != value)
                {
                    _maChungChiHanhNghe = value;
                    PropertyHasChanged("MaChungChiHanhNghe");
                }
            }
        }

        public String tentat
        {
            get
            {
                CanReadProperty("tentat", true);
                return _tentat;
            }
            set
            {
                CanWriteProperty("tentat", true);
                if (_tentat != value)
                {
                    _tentat = value;
                    PropertyHasChanged("tentat");
                }
            }
        }
        public String macd
        {
            get
            {
                CanReadProperty("macd", true);
                return _maCD;
            }
            set
            {
                CanWriteProperty("macd", true);
                if (_maCD != value)
                {
                    _maCD = value;
                    PropertyHasChanged("macd");
                }
            }
        }
        public String idnhanvien
        {
            get
            {
                CanReadProperty("idnhanvien", true);
                return _idnhanvien;
            }
            set
            {
                CanWriteProperty("idnhanvien", true);
                if (_idnhanvien != value)
                {
                    _idnhanvien = value;
                    PropertyHasChanged("idnhanvien");
                }
            }
        }
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

        public String MaNVHoTen
        {
            get
            {
               
                return _hoTen+"-"+_maNV ;
            }
           
        }

        public String ghichu
        {
            get
            {
                CanReadProperty("ghichu", true);
                return _ghichu;
            }
            set
            {
                CanWriteProperty("ghichu", true);
                if (_ghichu != value)
                {
                    _ghichu = value;
                    PropertyHasChanged("ghichu");
                }
            }
        }
        public string HoTen
        {
            get
            {
                CanReadProperty("HoTen", true);
                return _hoTen;
            }
            set
            {
                CanWriteProperty("HoTen", true);
                if (_hoTen != value)
                {
                    _hoTen = value;
                    PropertyHasChanged("HoTen");
                }
            }
        }

        public String MaLoaiHD
        {
            get
            {
                CanReadProperty("MaLoaiHD", true);
                return _maLoaiHD;
            }
            set
            {
                CanWriteProperty("MaLoaiHD", true);
                if (_maLoaiHD != value)
                {
                    _maLoaiHD = value;
                    PropertyHasChanged("MaLoaiHD");
                }
            }
        }

        public String MaChucVu
        {
            get
            {
                CanReadProperty("MaChucVu", true);
                return _maChucVu;
            }
            set
            {
                CanWriteProperty("MaChucVu", true);
                if (_maChucVu != value)
                {
                    _maChucVu = value;
                    PropertyHasChanged("MaChucVu");
                }
            }
        }
        public String MaCD
        {
            get
            {
                CanReadProperty("MaCD", true);
                return _maCD;
            }
            set
            {
                CanWriteProperty("MaCD", true);
                if (_maCD != value)
                {
                    _maCD = value;
                    PropertyHasChanged("MaCD");
                }
            }
        }
        public string MaChuyenMon
        {
            get
            {
                CanReadProperty("MaChuyenMon", true);
                return _maChuyenMon;
            }
            set
            {
                CanWriteProperty("MaChuyenMon", true);
                if (_maChuyenMon != value)
                {
                    _maChuyenMon = value;
                    PropertyHasChanged("MaChuyenMon");
                }
            }
        }

        public String MaKhoa
        {
            get
            {
                CanReadProperty("MaKhoa", true);
                return _maKhoa;
            }
            set
            {
                CanWriteProperty("MaKhoa", true);
                if (_maKhoa != value)
                {
                    _maKhoa = value;
                    PropertyHasChanged("MaKhoa");
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
        public Boolean KhongSD
        {
            get
            {
                CanReadProperty("khongsd", true);
                return _khongsd;
            }
            set
            {
                CanWriteProperty("Huy", true);
                if (_khongsd != value)
                {
                    _khongsd = value;
                    PropertyHasChanged("khongsd");
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
        public String TenNguoiSD
        {
            get
            {
                CanReadProperty("TenNguoiSD", true);
                return _TenNguoiSD;
            }
            set
            {
                CanWriteProperty("TenNguoiSD", true);
                if (_TenNguoiSD != value)
                {
                    _TenNguoiSD = value;
                    PropertyHasChanged("TenNguoiSD");
                }
            }
        }



        public String TenKhoa
        {
            get
            {
                CanReadProperty("TenKhoa", true);
                return _TenKhoa;
            }
            set
            {
                CanWriteProperty("TenKhoa", true);
                if (_TenKhoa != value)
                {
                    _TenKhoa = value;
                    PropertyHasChanged("TenKhoa");
                }
            }
        }

        public String TenChuyenMon
        {
            get
            {
                CanReadProperty("TenChuyenMon", true);
                return _tenChuyenMon;
            }
            set
            {
                CanWriteProperty("TenChuyenMon", true);
                if (_tenChuyenMon != value)
                {
                    _tenChuyenMon = value;
                    PropertyHasChanged("TenChuyenMon");
                }
            }
        }

        public String TenCV
        {
            get
            {
                CanReadProperty("TenCV", true);
                return _tenChucVu;
            }
            set
            {
                CanWriteProperty("TenCV", true);
                if (_tenChucVu != value)
                {
                    _tenChucVu = value;
                    PropertyHasChanged("TenCV");
                }
            }
        }
        public String TenCD
        {
            get
            {
                CanReadProperty("TenCD", true);
                return _tenCD;
            }
            set
            {
                CanWriteProperty("TenCD", true);
                if (_tenCD != value)
                {
                    _tenCD = value;
                    PropertyHasChanged("TenCD");
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
            return _maNV;
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation

        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="DMNhanVien" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static DMNhanVien NewDMNhanVien()
        {
            return new DMNhanVien();
        }
        public static DMNhanVien GetDMNhanVien(String maNV)
        {
            return DataPortal.Fetch<DMNhanVien>(new Criteria(maNV));
        }

        /// <summary>
        /// Marks the <see cref="DMNhanVien" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteDMNhanVien(String maNV, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maNV));
        }

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        protected internal DMNhanVien()
        {
            // Prevent direct creation
        }

        internal DMNhanVien(int ordernumber,
                            string MaNV,
                            string HoTen,
                            string machucvu,
                            string maLoaiHD,
                            string machuyenmon,
                            string makhoa,
                            string mamay,
                            bool khongsd,
                            bool huy,
                            SmartDate ngaySD,
                            string NguoiSD,
                            string TenNguoiSD,
                            string TenKhoa,
                            string TenChuyenMon,
                            string Tenchucvu,
                             string maCD,
                            string tenCD,
                            string tentat,
                            string ghichu,
                            string dienThoai,
                            string maChungChiHanhNghe,
                            string NguoiGiamHo,
                            string TenNguoiGiamHo,
                             string tenLoaiHD,
                            string DienThoaiKhoa,
            string chuky
            )
        {
            _DienThoaiKhoa = DienThoaiKhoa;
            _TenNguoiGiamHo = TenNguoiGiamHo;
            _TenLoaiHD = tenLoaiHD;
            _ChuKy = chuky;
            _NguoiGiamHo = NguoiGiamHo;
            _OrderNumber = ordernumber;
            _maNV = MaNV;
            _hoTen = HoTen;
            _maChucVu = machucvu;
            _maLoaiHD = maLoaiHD;
            _maCD = maCD;
            _tenCD = tenCD;
            _maChuyenMon = machuyenmon;
            _maKhoa = makhoa;
            _maMay = mamay;
            _huy = huy;
            _khongsd = khongsd;
            _nguoiSD = NguoiSD;
            _ngaySD = ngaySD;
            _TenNguoiSD = TenNguoiSD;
            _TenKhoa = TenKhoa;
            _tenChuyenMon = TenChuyenMon;
            _tenChucVu = Tenchucvu;
            _tentat = tentat;
            _ghichu = ghichu;
            _dienThoai = dienThoai;
            _maChungChiHanhNghe = maChungChiHanhNghe;
        }

        #endregion

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

            public Criteria(String maNV)
            {
                _maNV = maNV;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maNV.Equals(c._maNV))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maNV.ToString()).GetHashCode();
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
            public OtherCriteria(String Mamay, String Nguoisd, String maNV)
            {
                _maNV = maNV;
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
        /// Retrieve an existing <see cref="DMNhanVien" /> Object based on data in the database.
        /// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetDMNhanVien(String _maNV);
            // public override IDataReader GetDMNhanVien(String _maNV)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNV));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMNhanVien(crit.MaNV)))
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
        /// Load a <see cref="DMNhanVien" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
            if (dr.GetString("HoTen") != null) _hoTen = dr.GetString("HoTen");
            if (dr.GetString("MaChucVu") != null) _maChucVu = dr.GetString("MaChucVu");
            if (dr.GetString("MaLoaiHD") != null) _maLoaiHD = dr.GetString("MaLoaiHD");
            if (dr.GetString("tenCV") != null) _tenChucVu = dr.GetString("TenCV");
            if (dr.GetString("MaCD") != null) _maCD = dr.GetString("MaCD");
			if (dr.GetString("TenKhoa") != null) _TenKhoa = dr.GetString("TenKhoa");
            if (dr.GetString("TenCD") != null) _tenCD = dr.GetString("TenCD");
            if (dr.GetString("MaChuyenMon") != null) _maChuyenMon = dr.GetString("MaChuyenMon");
            if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetBoolean("khongsd") != null) _khongsd = dr.GetBoolean("khongsd");
            if (dr.GetSmartDate("NgaySD", false) != null) _ngaySD = dr.GetSmartDate("NgaySD", false);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("TenNguoiSD") != null) _TenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("tentat") != null) _tentat = dr.GetString("tentat");

            if (dr.GetString("idnhanvien") != null) _idnhanvien = dr.GetString("idnhanvien");
            if (dr.GetString("TenChuyenMon") != null) _tenChuyenMon = dr.GetString("TenChuyenMon");
            if (dr.GetString("DienThoai") != null) _dienThoai = dr.GetString("DienThoai");
            if (dr.GetString("MaChungChiHanhNghe") != null) _maChungChiHanhNghe = dr.GetString("MaChungChiHanhNghe");
            if (dr.GetString("DienThoaiKhoa") != null) _DienThoaiKhoa = dr.GetString("DienThoaiKhoa");
            if (dr.GetString("TenNguoiGiamHo") != null) _TenNguoiGiamHo = dr.GetString("TenNguoiGiamHo");
            if (dr.GetString("TenLoaiHD") != null) _TenLoaiHD = dr.GetString("TenLoaiHD");
            if (dr.GetString("NguoiGiamHo") != null) _NguoiGiamHo = dr.GetString("NguoiGiamHo");
            if (dr.GetString("GhiChu") != null) _ghichu = dr.GetString("GhiChu");

            if (dr.GetString("ChuKy") != null) _ChuKy = dr.GetString("ChuKy");
        }

        /// <summary>
        /// Insert the new <see cref="DMNhanVien" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMNhanVien
            // Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _maNV = DataProvider.Instance().InsertDMNhanVien(_hoTen, _maChucVu,_maLoaiHD, _maChuyenMon, _maKhoa, _khongsd, _maMay, _nguoiSD, _maCD, tentat, ghichu,_idnhanvien, _dienThoai, _maChungChiHanhNghe, _NguoiGiamHo, _DienThoaiKhoa);
            // public abstract String InsertDMNhanVien(String _maNV, String _hoTen, String _account, String _password, String _maKhoaLS, String _maKhoaCLS, String _maKho, Boolean _allMaKho, Boolean _allMaKhoaCLS, Boolean _allMaKhoaLS, String _maChucVu, String _maChuyenMon, String _maKhoa, String _quyenDTuong, Boolean _allQuyenDTuong, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
            // public override String InsertDMNhanVien(String _maNV, String _hoTen, String _account, String _password, String _maKhoaLS, String _maKhoaCLS, String _maKho, Boolean _allMaKho, Boolean _allMaKhoaCLS, Boolean _allMaKhoaLS, String _maChucVu, String _maChuyenMon, String _maKhoa, String _quyenDTuong, Boolean _allQuyenDTuong, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNV, _hoTen, _account, _password, _maKhoaLS, _maKhoaCLS, _maKho, _allMaKho, _allMaKhoaCLS, _allMaKhoaLS, _maChucVu, _maChuyenMon, _maKhoa, _quyenDTuong, _allQuyenDTuong, _maMay, _huy, _ngaySD.DBValue, _nguoiSD), String);
            // }
        }

        /// <summary>
        /// Update all changes made on <see cref="DMNhanVien" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMNhanVien
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateDMNhanVien(_maNV, _hoTen, _maChucVu,_maLoaiHD , _maChuyenMon, _maKhoa, _khongsd, _huy, _maMay, _nguoiSD, _maCD, tentat, ghichu,_idnhanvien, _dienThoai, _maChungChiHanhNghe, _NguoiGiamHo, _DienThoaiKhoa);
                // public abstract void UpdateDMNhanVien(String _maNV, String _hoTen, String _account, String _password, String _maKhoaLS, String _maKhoaCLS, String _maKho, Boolean _allMaKho, Boolean _allMaKhoaCLS, Boolean _allMaKhoaLS, String _maChucVu, String _maChuyenMon, String _maKhoa, String _quyenDTuong, Boolean _allQuyenDTuong, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
                // public override void UpdateDMNhanVien(String _maNV, String _hoTen, String _account, String _password, String _maKhoaLS, String _maKhoaCLS, String _maKho, Boolean _allMaKho, Boolean _allMaKhoaCLS, Boolean _allMaKhoaLS, String _maChucVu, String _maChuyenMon, String _maKhoa, String _quyenDTuong, Boolean _allQuyenDTuong, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNV, _hoTen, _account, _password, _maKhoaLS, _maKhoaCLS, _maKho, _allMaKho, _allMaKhoaCLS, _allMaKhoaLS, _maChucVu, _maChuyenMon, _maKhoa, _quyenDTuong, _allQuyenDTuong, _maMay, _huy, _ngaySD.DBValue, _nguoiSD);
                // }				
            }
        }
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD, _maNV));
        }

        /// <summary>
        /// Delete the <see cref="DMNhanVien" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMNhanVien
            DataProvider.Instance().DeleteDMNhanVien(crit.MaMay, crit.NguoiSD, crit.MaNV);
            // public abstract void DeleteDMNhanVien(String _maNV);
            // public override void DeleteDMNhanVien(String _maNV);
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNV);
            // }
        }

        #endregion
    }

}
