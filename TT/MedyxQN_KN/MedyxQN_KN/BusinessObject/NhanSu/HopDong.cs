

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace HTC.Business.NhanSu
{

    /// <summary>
    /// This is a base generated class of <see cref="HopDong" /> Business Object.
    /// </summary>

    [Serializable()]
    public partial class HopDong : BusinessBase<HopDong>
    {
        #region Business Methods

        #region State Fields

        private String _soHD = String.Empty;
        private String _maNV = String.Empty;
        private String _maKhoa = String.Empty;
        private SmartDate _ngayKy = new SmartDate(true);
        private SmartDate _ngayKyD = new SmartDate(true);
        private String _nguoiKy = String.Empty;
        private String _maLoaiHD = String.Empty;
        private SmartDate _tuNgay = new SmartDate(true);
        private SmartDate _denNgay = new SmartDate(true);
        private String _diaDiem = String.Empty;
        private String _maChucVu = String.Empty;
        private String _tenCongViec = String.Empty;
        private Decimal _mucLuong = 0;
        private SmartDate _thuViecTuNgay = new SmartDate(true);
        private SmartDate _thuViecDenNgay = new SmartDate(true);
        private String _maCheDoLV = String.Empty;
        private String _thoiGianLV = String.Empty;
        private String _dungCu = String.Empty;
        private String _soNgayNghi = String.Empty;
        private String _phucLoi = String.Empty;
        private String _ghiChu = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngayHuy = new SmartDate(true);
        private String _lyDoHuy = String.Empty;
        private SmartDate _ngayLap = new SmartDate(true);
        private String _nguoiLap = String.Empty;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private String _nguoiHuy = String.Empty;
        private SmartDate _ngaySD1 = new SmartDate(true);
        private String _nguoiSD1 = String.Empty;
        private String _tenKhoa = String.Empty;
        private String _tenLoaiHD = String.Empty;
        private String _tenCheDoLV = String.Empty;
        private String _tenCV = String.Empty;
        private String _hoTen = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private int _OrderNumber;

        #endregion

        #region Business Properties and Methods

        public String SoHD
        {
            get
            {
                CanReadProperty("SoHD", true);
                return _soHD ;
            }
            set
            {
                CanWriteProperty("SoHD", true);
                if (_soHD != value)
                {
                    _soHD = value;
                    PropertyHasChanged("SoHD");
                }
            }
        }

        public String MaNV
        {
            get
            {
                CanReadProperty("MaNV", true);
                return _maNV ;
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

        public String MaKhoa
        {
            get
            {
                CanReadProperty("MaKhoa", true);
                return _maKhoa ;
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

        public string NgayKy
        {
            get
            {
                CanReadProperty("NgayKy", true);
                return _ngayKy.Text;
            }
            set
            {
                CanWriteProperty("NgayKy", true);
                if (_ngayKy.Text != value)
                {
                    _ngayKy.Text = value;
                    PropertyHasChanged("NgayKy");
                }
            }
        }

        public string NgayKyD
        {
            get
            {
                CanReadProperty("NgaysinhD", true);
                _ngayKyD = _ngayKy ;
                _ngayKyD.FormatString = "dd/MM/yyyy";
                return _ngayKyD.Text;
            }

        }

        public String NguoiKy
        {
            get
            {
                CanReadProperty("NguoiKy", true);
                return _nguoiKy ;
            }
            set
            {
                CanWriteProperty("NguoiKy", true);
                if (_nguoiKy != value)
                {
                    _nguoiKy = value;
                    PropertyHasChanged("NguoiKy");
                }
            }
        }

        public String MaLoaiHD
        {
            get
            {
                CanReadProperty("MaLoaiHD", true);
                return _maLoaiHD ;
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

        public string TuNgay
        {
            get
            {
                CanReadProperty("TuNgay", true);
                return _tuNgay.Text;
            }
            set
            {
                CanWriteProperty("TuNgay", true);
                if (_tuNgay.Text != value)
                {
                    _tuNgay.Text = value;
                    PropertyHasChanged("TuNgay");
                }
            }
        }

        public string DenNgay
        {
            get
            {
                CanReadProperty("DenNgay", true);
                return _denNgay.Text;
            }
            set
            {
                CanWriteProperty("DenNgay", true);
                if (_denNgay.Text != value)
                {
                    _denNgay.Text = value;
                    PropertyHasChanged("DenNgay");
                }
            }
        }

        public string DiaDiem
        {
            get
            {
                CanReadProperty("DiaDiem", true);
                return _diaDiem;
            }
            set
            {
                CanWriteProperty("DiaDiem", true);
                if (_diaDiem != value)
                {
                    _diaDiem = value;
                    PropertyHasChanged("DiaDiem");
                }
            }
        }

        public string MaChucVu
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

        public string TenCongViec
        {
            get
            {
                CanReadProperty("TenCongViec", true);
                return _tenCongViec;
            }
            set
            {
                CanWriteProperty("TenCongViec", true);
                if (_tenCongViec != value)
                {
                    _tenCongViec = value;
                    PropertyHasChanged("TenCongViec");
                }
            }
        }

        public Decimal MucLuong
        {
            get
            {
                CanReadProperty("MucLuong", true);
                return _mucLuong;
            }
            set
            {
                CanWriteProperty("MucLuong", true);
                if (_mucLuong != value)
                {
                    _mucLuong = value;
                    PropertyHasChanged("MucLuong");
                }
            }
        }

        public string ThuViecTuNgay
        {
            get
            {
                CanReadProperty("ThuViecTuNgay", true);
                return _thuViecTuNgay.Text;
            }
            set
            {
                CanWriteProperty("ThuViecTuNgay", true);
                if (_thuViecTuNgay.Text != value)
                {
                    _thuViecTuNgay.Text = value;
                    PropertyHasChanged("ThuViecTuNgay");
                }
            }
        }

        public string ThuViecDenNgay
        {
            get
            {
                CanReadProperty("ThuViecDenNgay", true);
                return _thuViecDenNgay.Text;
            }
            set
            {
                CanWriteProperty("ThuViecDenNgay", true);
                if (_thuViecDenNgay.Text != value)
                {
                    _thuViecDenNgay.Text = value;
                    PropertyHasChanged("ThuViecDenNgay");
                }
            }
        }

        public String MaCheDoLV
        {
            get
            {
                CanReadProperty("MaCheDoLV", true);
                return _maCheDoLV ;
            }
            set
            {
                CanWriteProperty("MaCheDoLV", true);
                if (_maCheDoLV != value)
                {
                    _maCheDoLV = value;
                    PropertyHasChanged("MaCheDoLV");
                }
            }
        }

        public String ThoiGianLV
        {
            get
            {
                CanReadProperty("ThoiGianLV", true);
                return _thoiGianLV ;
            }
            set
            {
                CanWriteProperty("ThoiGianLV", true);
                if (_thoiGianLV != value)
                {
                    _thoiGianLV = value;
                    PropertyHasChanged("ThoiGianLV");
                }
            }
        }

        public String DungCu
        {
            get
            {
                CanReadProperty("DungCu", true);
                return _dungCu ;
            }
            set
            {
                CanWriteProperty("DungCu", true);
                if (_dungCu != value)
                {
                    _dungCu = value;
                    PropertyHasChanged("DungCu");
                }
            }
        }

        public String SoNgayNghi
        {
            get
            {
                CanReadProperty("SoNgayNghi", true);
                return _soNgayNghi ;
            }
            set
            {
                CanWriteProperty("SoNgayNghi", true);
                if (_soNgayNghi != value)
                {
                    _soNgayNghi = value;
                    PropertyHasChanged("SoNgayNghi");
                }
            }
        }

        public String PhucLoi
        {
            get
            {
                CanReadProperty("PhucLoi", true);
                return _phucLoi;
            }
            set
            {
                CanWriteProperty("PhucLoi", true);
                if (_phucLoi != value)
                {
                    _phucLoi = value;
                    PropertyHasChanged("PhucLoi");
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

        public SmartDate NgayHuy
        {
            get
            {
                CanReadProperty("NgayHuy", true);
                _ngaySD.FormatString = "dd/MM/yyyy";
                return this._ngaySD;
            }
            set
            {
                CanWriteProperty("NgayHuy", true);
                if (_ngaySD != value)
                {
                    _ngaySD = value;
                    PropertyHasChanged("NgayHuy");
                }
            }
        }

        public String LyDoHuy
        {
            get
            {
                CanReadProperty("LyDoHuy", true);
                return _lyDoHuy;
            }
            set
            {
                CanWriteProperty("LyDoHuy", true);
                if (_lyDoHuy != value)
                {
                    _lyDoHuy = value;
                    PropertyHasChanged("LyDoHuy");
                }
            }
        }

        public SmartDate NgayLap
        {
            get
            {
                CanReadProperty("NgayLap", true);
                _ngayLap.FormatString = "dd/MM/yyyy";
                return this._ngaySD;
            }
            set
            {
                CanWriteProperty("NgayLap", true);
                if (_ngayLap != value)
                {
                    _ngayLap = value;
                    PropertyHasChanged("NgayLap");
                }
            }
        }

        public String NguoiLap
        {
            get
            {
                CanReadProperty("NguoiLap", true);
                return _nguoiLap;
            }
            set
            {
                CanWriteProperty("NguoiLap", true);
                if (_nguoiLap != value)
                {
                    _nguoiLap = value;
                    PropertyHasChanged("NguoiLap");
                }
            }
        }

        public SmartDate NgaySD
        {
            get
            {
                CanReadProperty("NgaySD", true);
                _ngaySD.FormatString = "dd/MM/yyyy";
                return this._ngaySD;
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

        public String NguoiHuy
        {
            get
            {
                CanReadProperty("NguoiHuy", true);
                return _nguoiHuy;
            }
            set
            {
                CanWriteProperty("NguoiHuy", true);
                if (_nguoiHuy != value)
                {
                    _nguoiHuy = value;
                    PropertyHasChanged("NguoiHuy");
                }
            }
        }

        public string NgaySD1
        {
            get
            {
                CanReadProperty("NgaySD1", true);
                return _ngaySD1.Text;
            }
            set
            {
                CanWriteProperty("NgaySD1", true);
                if (_ngaySD1.Text != value)
                {
                    _ngaySD1.Text = value;
                    PropertyHasChanged("NgaySD1");
                }
            }
        }

        public String NguoiSD1
        {
            get
            {
                CanReadProperty("NguoiSD1", true);
                return _nguoiSD1;
            }
            set
            {
                CanWriteProperty("NguoiSD1", true);
                if (_nguoiSD1 != value)
                {
                    _nguoiSD1 = value;
                    PropertyHasChanged("NguoiSD1");
                }
            }
        }

        public String TenKhoa
        {
            get
            {
                CanReadProperty("TenKhoa", true);
                return _tenKhoa ;
            }
            set
            {
                CanWriteProperty("TenKhoa", true);
                if (_tenKhoa != value)
                {
                    _tenKhoa = value;
                    PropertyHasChanged("TenKhoa");
                }
            }
        }

        public String TenLoaiHD
        {
            get
            {
                CanReadProperty("TenLoaiHD", true);
                return _tenLoaiHD ;
            }
            set
            {
                CanWriteProperty("TenLoaiHD", true);
                if (_tenLoaiHD != value)
                {
                    _tenLoaiHD = value;
                    PropertyHasChanged("TenLoaiHD");
                }
            }
        }

        public String TenCheDoLV
        {
            get
            {
                CanReadProperty("TenCheDoLV", true);
                return _tenCheDoLV ;
            }
            set
            {
                CanWriteProperty("TenCheDoLV", true);
                if (_tenCheDoLV != value)
                {
                    _tenCheDoLV = value;
                    PropertyHasChanged("TenCheDoLV");
                }
            }
        }

        public String TenCV
        {
            get
            {
                CanReadProperty("TenCV", true);
                return _tenCongViec ;
            }
            set
            {
                CanWriteProperty("TenCV", true);
                if (_tenCongViec != value)
                {
                    _tenCongViec = value;
                    PropertyHasChanged("TenCV");
                }
            }
        }

        public String HoTen
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

        public String TenNguoiLap
        {
            get
            {
                CanReadProperty("TenNguoiLap", true);
                return _tenNguoiLap ;
            }
            set
            {
                CanWriteProperty("TenNguoiLap", true);
                if (_tenNguoiLap != value)
                {
                    _tenNguoiLap = value;
                    PropertyHasChanged("TenNguoiLap");
                }
            }
        }

        public String TenNguoiSD
        {
            get
            {
                CanReadProperty("TenNguoiSD", true);
                return _tenNguoiSD ;
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

        public String TenNguoiHuy
        {
            get
            {
                CanReadProperty("TenNguoiHuy", true);
                return _tenNguoiHuy ;
            }
            set
            {
                CanWriteProperty("TenNguoiHuy", true);
                if (_tenNguoiHuy != value)
                {
                    _tenNguoiHuy = value;
                    PropertyHasChanged("TenNguoiHuy");
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
            return _soHD ;
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation

        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="HopDong" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static HopDong NewHopDong()
        {
            return DataPortal.Create<HopDong>();
        }
        public static HopDong GetHopDong(String soHD)
        {
            return DataPortal.Fetch<HopDong>(new Criteria(soHD ));
        }

        /// <summary>
        /// Marks the <see cref="HopDong" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteHopDong(String soHD, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy,  soHD));
        }

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        protected internal HopDong()
        {
            // Prevent direct creation
        }

        internal HopDong(
                                int OrderNumber,
                             String soHD,
                             String maNV,
                             String maKhoa,
                             SmartDate ngayKy,
                             String nguoiKy,
                             String maLoaiHD,
                             SmartDate tuNgay,
                             SmartDate denNgay,
                             String diaDiem,
                             String maChucVu,
                             String tenCongViec,
                             Decimal mucLuong,
                             SmartDate thuViecTuNgay,
                             SmartDate thuViecDenNgay,
                             String maCheDoLV,
                             String thoiGianLV,
                             String dungCu,
                             String soNgayNghi,
                             String phucLoi,
                             String ghiChu,
                             String maMay,
                             Boolean huy,
                             SmartDate ngayHuy,                         
                             String lyDoHuy,
                             SmartDate ngayLap,
                             String nguoiLap,
                             SmartDate ngaySD,
                             String nguoiSD,
                             String nguoiHuy,
                             SmartDate ngaySD1,
                             String nguoiSD1,
                            String tenKhoa,
                            String tenLoaiHD,
                            String tenCheDoLV,
                            String tenCV,
                            String hoTen,
                            String tenNguoiLap,
                            String tenNguoiSD,
                            String tenNguoiHuy


                             
         )
        {
            _OrderNumber = OrderNumber;
            _soHD  = soHD ;
            _maNV = maNV ;
            _maKhoa  = maKhoa ;
            _ngayKy   = ngayKy ;
            _nguoiKy  = nguoiKy ;
            _maLoaiHD  = maLoaiHD ;
            _tuNgay  = tuNgay ;
            _denNgay  = denNgay ;
            _diaDiem  = diaDiem ;
            _maChucVu  = maChucVu ;
            _tenCongViec  = tenCongViec  ;
            _mucLuong  = mucLuong ;
            _thuViecTuNgay  = thuViecTuNgay ;
            _thuViecDenNgay  = thuViecDenNgay ;
            _maCheDoLV  = maCheDoLV ;
            _thoiGianLV  = thoiGianLV ;
            _dungCu  = dungCu ;
            _soNgayNghi  = soNgayNghi ;
            _phucLoi  = phucLoi ;
            _ghiChu  = ghiChu ;
            _maMay  = maMay ;
            _huy  = huy ;
            _ngayHuy  = ngayHuy;
            _lyDoHuy  = lyDoHuy ;
            _ngayLap  = ngayLap ;
            _nguoiLap  = nguoiLap ;
            _ngaySD  = ngaySD ;
            _nguoiSD  = nguoiSD;
            _nguoiHuy  = nguoiHuy ;
            _ngaySD1  = ngaySD1;
            _nguoiSD1  = nguoiSD1 ;
            _tenKhoa = tenKhoa ;
            _tenLoaiHD  = tenLoaiHD ;
            _tenCheDoLV  = tenCheDoLV;
            _tenCV  = tenCV ;
            _hoTen  = hoTen ;
            _tenNguoiLap  = tenNguoiLap ;
            _tenNguoiSD  = tenNguoiSD ;
            _tenNguoiHuy  = tenNguoiHuy ;

        }

        #endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
            private String _soHD;
            public String SoHD
            {
                get
                {
                    return _soHD;
                }
            }

            public Criteria(String soHD)
            {
                _soHD = soHD ;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_soHD.Equals(c._soHD))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _soHD.ToString()).GetHashCode();
            }
        }

        [Serializable()]
        protected class OtherCriteria
        {
            private String _soHD;
            public String SoHD
            {
                get
                {
                    return _soHD;
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
            public OtherCriteria(String Mamay, String Nguoisd, String soHD)
            {
                _soHD = soHD ;
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
        /// Retrieve an existing <see cref="HopDong" /> Object based on data in the database.
        /// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetHopDong(String _maNV);
            // public override IDataReader GetHopDong(String _maNV)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spHopDong_Get", _maNV));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetHopDong(crit.SoHD)))
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
        /// Load a <see cref="HopDong" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("SoHD") != null) _soHD  = dr.GetString("SoHD");
            if (dr.GetString("MaNV") != null) _maNV  = dr.GetString("MaNV");
            if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
            if (dr.GetSmartDate("NgayKy", true) != null) _ngayKy  = dr.GetSmartDate("NgayKy", true);
            if (dr.GetString("NguoiKy") != null) _nguoiKy  = dr.GetString("NguoiKy");
            if (dr.GetString("MaLoaiHD") != null) _maLoaiHD  = dr.GetString("MaLoaiHD");
            if (dr.GetSmartDate("TuNgay", true) != null) _tuNgay  = dr.GetSmartDate("TuNgay", true);
            if (dr.GetSmartDate("DenNgay", true) != null) _denNgay = dr.GetSmartDate("DenNgay", true);
            if (dr.GetString("DiaDiem") != null) _diaDiem  = dr.GetString("DiaDiem");
            if (dr.GetString("MaChucVu") != null) _maChucVu  = dr.GetString("MaChucVu");
            if (dr.GetString("TenCongViec") != null) _tenCongViec = dr.GetString("TenCongViec");
            if (dr.GetDecimal("MucLuong") != null) _mucLuong = dr.GetDecimal("MucLuong");
            if (dr.GetSmartDate("ThuViecTuNgay", true) != null) _thuViecTuNgay  = dr.GetSmartDate("ThuViecTuNgay", true);
            if (dr.GetSmartDate("ThuViecDenNgay", true) != null) _thuViecDenNgay  = dr.GetSmartDate("ThuViecDenNgay", true);
            if (dr.GetString("MaCheDoLV") != null) _maCheDoLV = dr.GetString("MaCheDoLV");
            if (dr.GetString("ThoiGianLV") != null) _thoiGianLV = dr.GetString("ThoiGianLV");
            if (dr.GetString("DungCu") != null) _dungCu = dr.GetString("DungCu");
            if (dr.GetString("SoNgayNghi") != null) _soNgayNghi  = dr.GetString("SoNgayNghi");
            if (dr.GetString("PhucLoi") != null) _phucLoi = dr.GetString("PhucLoi");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
            if (dr.GetString("LyDoHuy") != null) _lyDoHuy = dr.GetString("LyDoHuy");
            if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
            if (dr.GetString("NguoiLap") != null) _nguoiLap  = dr.GetString("NguoiLap");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
            if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetString("TenKhoa") != null) _tenKhoa = dr.GetString("TenKhoa");
            if (dr.GetString("TenLoaiHD") != null) _tenLoaiHD = dr.GetString("TenLoaiHD");
            if (dr.GetString("TenCheDoLV") != null) _tenCheDoLV = dr.GetString("TenCheDoLV");
            if (dr.GetString("TenCV") != null) _tenCV  = dr.GetString("TenCV");
            if (dr.GetString("HoTen") != null) _hoTen = dr.GetString("HoTen");
            if (dr.GetString("TenNguoiLap") != null) _tenNguoiLap  = dr.GetString("TenNguoiLap");
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD  = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenNguoiHuy") != null) _tenNguoiSD = dr.GetString("TenNguoiHuy");

        }

        /// <summary>
        /// Insert the new <see cref="HopDong" /> Object to underlying database.
        /// </summary>
        /// 


        protected override void DataPortal_Create()
        {
            

            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertHopDong
            // Copy & paste ham duoi day vao file DataProvider.cs
            
            
            _maNV = DataProvider.Instance().InsertHopDong(_soHD , _maNV , _maKhoa, _ngayKy , _nguoiKy , _maLoaiHD , _tuNgay , _denNgay , _diaDiem , _maChucVu , _tenCongViec , _mucLuong , _thuViecTuNgay , _thuViecDenNgay , _maCheDoLV , _thoiGianLV , _dungCu , _soNgayNghi , _phucLoi , _ghiChu, _maMay , _nguoiSD );
            
        }

        /// <summary>
        /// Update all changes made on <see cref="HopDong" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateHopDong
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateHopDong(_soHD, _maNV, _maKhoa, _ngayKy, _nguoiKy, _maLoaiHD, _tuNgay, _denNgay, _diaDiem, _maChucVu, _tenCongViec, _mucLuong, _thuViecTuNgay, _thuViecDenNgay, _maCheDoLV, _thoiGianLV, _dungCu, _soNgayNghi, _phucLoi, _ghiChu, _maMay, _nguoiSD ,_huy);
                				
            }
        }
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _soHD ));
        }

        /// <summary>
        /// Delete the <see cref="HopDong" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateHopDong
            DataProvider.Instance().DeleteHopDong(crit.MaMay, crit.NguoiSD, crit.SoHD);
            // public abstract void DeleteHopDong(String _maNV);
            // public override void DeleteHopDong(String _maNV)
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spHopDong_DELETED", _maNV);
            // }
        }

        #endregion
    }

}
