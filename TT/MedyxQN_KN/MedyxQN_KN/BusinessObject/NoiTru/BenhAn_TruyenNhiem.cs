// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_TruyenNhiem
// Kieu doi tuong  :	BenhAn_TruyenNhiem
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	7/8/2009 2:28:41 PM
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

namespace HTC.Business.NoiTru
{

    /// <summary>
    /// This is a base generated class of <see cref="BenhAn_TruyenNhiem" /> Business Object.
    /// </summary>

    [Serializable()]
    public partial class BenhAn_TruyenNhiem : BusinessBase<BenhAn_TruyenNhiem>
    {
        #region Business Methods

        #region State Fields

        private String _maBA = String.Empty;
        private Int32 _sTT = 0;
        private Int32 _sTTKhoa = 0;
        private SmartDate _ngayKham = new SmartDate(true);
        private SmartDate _ngayKhamD = new SmartDate(true);
        private String _bSKHAM = String.Empty;
        private String _lyDoKham = String.Empty;
        private String _mach = String.Empty;
        private String _apHuyet = String.Empty;
        private String _nhietDo = String.Empty;
        private String _nhipTho = String.Empty;
        private String _canNang = String.Empty;
        private String _chieuCao = String.Empty;

        private String _TSDichTe = String.Empty;
        private String _TSBenhCapTinh = String.Empty;
        private String _TSNoiSongTruocKhiBenh = String.Empty;
        private SmartDate _TSThoiGianNoiSong = new SmartDate(true);
        private String _TSMoiSinh = String.Empty;
        


        private String _toanThan = String.Empty;
        private String _benhngoaiKhoa = String.Empty;
        private String _tuanHoan = String.Empty;
        private String _hoHap = String.Empty;
        private String _tieuHoa = String.Empty;
        private String _ThanTNieuSDuc = String.Empty;
        private String _thanKinh = String.Empty;
        private String _XuongKhop = String.Empty;
        private String _taiMuiHong = String.Empty;
        private String _rangHamMat = String.Empty;
        private String _mat = String.Empty;
        private String _BenhLyKhac = String.Empty;

        private String _dieuTri = String.Empty;
        private String _benhSu = String.Empty;
        private String _huongDT = String.Empty;

        private String _machuyenkhoa = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private SmartDate _ngaySD1 = new SmartDate(true);
        private String _nguoiSD1 = String.Empty;
        private String _mabenh = String.Empty;
        private String _maBenhKem = String.Empty;
        private String _tenBenh = String.Empty;
        private String _tenBenhKem = String.Empty;
        private String _maICD = String.Empty;
        private String _maICDKem = String.Empty;
        private String _tenBSKham = String.Empty;
        private String _tennguoiSD = String.Empty;
        private int _OrderNumber;

        #endregion

        #region Business Properties and Methods

        public String MaBA
        {
            get
            {
                CanReadProperty("MaBA", true);
                return _maBA;
            }
            set
            {
                CanWriteProperty("MaBA", true);
                if (_maBA != value)
                {
                    _maBA = value;
                    PropertyHasChanged("MaBA");
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

        public Int32 STTKhoa
        {
            get
            {
                CanReadProperty("STTKhoa", true);
                return _sTTKhoa;
            }
            set
            {
                CanWriteProperty("STTKhoa", true);
                if (_sTTKhoa != value)
                {
                    _sTTKhoa = value;
                    PropertyHasChanged("STTKhoa");
                }
            }
        }

        public string NgayKham
        {
            get
            {
                CanReadProperty("NgayKham", true);

                return _ngayKham.Text;
            }
            set
            {
                CanWriteProperty("NgayKham", true);
                if (_ngayKham.Text != value)
                {
                    _ngayKham.Text = value;
                    PropertyHasChanged("NgayKham");
                }
            }
        }
        public string NgayKhamD
        {
            get
            {
                CanReadProperty("NgayKhamD", true);
                _ngayKhamD = _ngayKham;
                _ngayKhamD.FormatString = "dd/MM/yyyy HH:mm";

                return _ngayKhamD.Text;
            }

        }
        public String BSKHAM
        {
            get
            {
                CanReadProperty("BSKHAM", true);
                return _bSKHAM;
            }
            set
            {
                CanWriteProperty("BSKHAM", true);
                if (_bSKHAM != value)
                {
                    _bSKHAM = value;
                    PropertyHasChanged("BSKHAM");
                }
            }
        }

        public String LyDoKham
        {
            get
            {
                CanReadProperty("LyDoKham", true);
                return _lyDoKham;
            }
            set
            {
                CanWriteProperty("LyDoKham", true);
                if (_lyDoKham != value)
                {
                    _lyDoKham = value;
                    PropertyHasChanged("LyDoKham");
                }
            }
        }

        public String Mach
        {
            get
            {
                CanReadProperty("Mach", true);
                return _mach;
            }
            set
            {
                CanWriteProperty("Mach", true);
                if (_mach != value)
                {
                    _mach = value;
                    PropertyHasChanged("Mach");
                }
            }
        }

        public String ApHuyet
        {
            get
            {
                CanReadProperty("ApHuyet", true);
                return _apHuyet;
            }
            set
            {
                CanWriteProperty("ApHuyet", true);
                if (_apHuyet != value)
                {
                    _apHuyet = value;
                    PropertyHasChanged("ApHuyet");
                }
            }
        }

        public String NhietDo
        {
            get
            {
                CanReadProperty("NhietDo", true);
                return _nhietDo;
            }
            set
            {
                CanWriteProperty("NhietDo", true);
                if (_nhietDo != value)
                {
                    _nhietDo = value;
                    PropertyHasChanged("NhietDo");
                }
            }
        }

        public String NhipTho
        {
            get
            {
                CanReadProperty("NhipTho", true);
                return _nhipTho;
            }
            set
            {
                CanWriteProperty("NhipTho", true);
                if (_nhipTho != value)
                {
                    _nhipTho = value;
                    PropertyHasChanged("NhipTho");
                }
            }
        }

        public String CanNang
        {
            get
            {
                CanReadProperty("CanNang", true);
                return _canNang;
            }
            set
            {
                CanWriteProperty("CanNang", true);
                if (_canNang != value)
                {
                    _canNang = value;
                    PropertyHasChanged("CanNang");
                }
            }
        }

        public String ChieuCao
        {
            get
            {
                CanReadProperty("ChieuCao", true);
                return _chieuCao;
            }
            set
            {
                CanWriteProperty("ChieuCao", true);
                if (_chieuCao != value)
                {
                    _chieuCao = value;
                    PropertyHasChanged("ChieuCao");
                }
            }
        }
        public String TSDichTe
        {
            get
            {
                CanReadProperty("TSDichTe", true);
                return _TSDichTe;
            }
            set
            {
                CanWriteProperty("TSDichTe", true);
                if (_TSDichTe != value)
                {
                    _TSDichTe = value;
                    PropertyHasChanged("TSDichTe");
                }
            }
        }
        public String TSBenhCapTinh
        {
            get
            {
                CanReadProperty("TSBenhCapTinh", true);
                return _TSBenhCapTinh;
            }
            set
            {
                CanWriteProperty("TSBenhCapTinh", true);
                if (_TSBenhCapTinh != value)
                {
                    _TSBenhCapTinh = value;
                    PropertyHasChanged("TSBenhCapTinh");
                }
            }
        }
        public String TSNoiSongTruocKhiBenh
        {
            get
            {
                CanReadProperty("TSNoiSongTruocKhiBenh", true);
                return _TSNoiSongTruocKhiBenh;
            }
            set
            {
                CanWriteProperty("TSNoiSongTruocKhiBenh", true);
                if (_TSNoiSongTruocKhiBenh != value)
                {
                    _TSNoiSongTruocKhiBenh = value;
                    PropertyHasChanged("TSNoiSongTruocKhiBenh");
                }
            }
        }
     
        public string TSThoiGianNoiSong
        {
            get
            {
                CanReadProperty("TSThoiGianNoiSong", true);
                _TSThoiGianNoiSong.FormatString = "dd/MM/yyyy";
                return _TSThoiGianNoiSong.Text;
            }
            set
            {
                CanWriteProperty("TSThoiGianNoiSong", true);
                if (_TSThoiGianNoiSong.Text != value)
                {
                    _TSThoiGianNoiSong.Text = value;
                    PropertyHasChanged("TSThoiGianNoiSong");
                }
            }
        }
        public String TSMoiSinh
        {
            get
            {
                CanReadProperty("TSMoiSinh", true);
                return _TSMoiSinh;
            }
            set
            {
                CanWriteProperty("TSMoiSinh", true);
                if (_TSMoiSinh != value)
                {
                    _TSMoiSinh = value;
                    PropertyHasChanged("TSMoiSinh");
                }
            }
        }
        public String ToanThan
        {
            get
            {
                CanReadProperty("ToanThan", true);
                return _toanThan;
            }
            set
            {
                CanWriteProperty("ToanThan", true);
                if (_toanThan != value)
                {
                    _toanThan = value;
                    PropertyHasChanged("ToanThan");
                }
            }
        }



        public String TuanHoan
        {
            get
            {
                CanReadProperty("TuanHoan", true);
                return _tuanHoan;
            }
            set
            {
                CanWriteProperty("TuanHoan", true);
                if (_tuanHoan != value)
                {
                    _tuanHoan = value;
                    PropertyHasChanged("TuanHoan");
                }
            }
        }

        public String HoHap
        {
            get
            {
                CanReadProperty("HoHap", true);
                return _hoHap;
            }
            set
            {
                CanWriteProperty("HoHap", true);
                if (_hoHap != value)
                {
                    _hoHap = value;
                    PropertyHasChanged("HoHap");
                }
            }
        }

        public String TieuHoa
        {
            get
            {
                CanReadProperty("TieuHoa", true);
                return _tieuHoa;
            }
            set
            {
                CanWriteProperty("TieuHoa", true);
                if (_tieuHoa != value)
                {
                    _tieuHoa = value;
                    PropertyHasChanged("TieuHoa");
                }
            }
        }

        public String ThanTNieuSDuc
        {
            get
            {
                CanReadProperty("ThanTNieuSDuc", true);
                return _ThanTNieuSDuc;
            }
            set
            {
                CanWriteProperty("ThanTNieuSDuc", true);
                if (_ThanTNieuSDuc != value)
                {
                    _ThanTNieuSDuc = value;
                    PropertyHasChanged("ThanTNieuSDuc");
                }
            }
        }

        public String ThanKinh
        {
            get
            {
                CanReadProperty("ThanKinh", true);
                return _thanKinh;
            }
            set
            {
                CanWriteProperty("ThanKinh", true);
                if (_thanKinh != value)
                {
                    _thanKinh = value;
                    PropertyHasChanged("ThanKinh");
                }
            }
        }

        public String XuongKhop
        {
            get
            {
                CanReadProperty("XuongKhop", true);
                return _XuongKhop;
            }
            set
            {
                CanWriteProperty("XuongKhop", true);
                if (_XuongKhop != value)
                {
                    _XuongKhop = value;
                    PropertyHasChanged("XuongKhop");
                }
            }
        }

        public String TaiMuiHong
        {
            get
            {
                CanReadProperty("TaiMuiHong", true);
                return _taiMuiHong;
            }
            set
            {
                CanWriteProperty("TaiMuiHong", true);
                if (_taiMuiHong != value)
                {
                    _taiMuiHong = value;
                    PropertyHasChanged("TaiMuiHong");
                }
            }
        }

        public String RangHamMat
        {
            get
            {
                CanReadProperty("RangHamMat", true);
                return _rangHamMat;
            }
            set
            {
                CanWriteProperty("RangHamMat", true);
                if (_rangHamMat != value)
                {
                    _rangHamMat = value;
                    PropertyHasChanged("RangHamMat");
                }
            }
        }

        public String Mat
        {
            get
            {
                CanReadProperty("Mat", true);
                return _mat;
            }
            set
            {
                CanWriteProperty("Mat", true);
                if (_mat != value)
                {
                    _mat = value;
                    PropertyHasChanged("Mat");
                }
            }
        }

        public String BenhLyKhac
        {
            get
            {
                CanReadProperty("BenhLyKhac", true);
                return _BenhLyKhac;
            }
            set
            {
                CanWriteProperty("BenhLyKhac", true);
                if (_BenhLyKhac != value)
                {
                    _BenhLyKhac = value;
                    PropertyHasChanged("BenhLyKhac");
                }
            }
        }
        public String DieuTri
        {
            get
            {
                CanReadProperty("DieuTri", true);
                return _dieuTri;
            }
            set
            {
                CanWriteProperty("DieuTri", true);
                if (_dieuTri != value)
                {
                    _dieuTri = value;
                    PropertyHasChanged("DieuTri");
                }
            }
        }

        public String BenhSu
        {
            get
            {
                CanReadProperty("BenhSu", true);
                return _benhSu;
            }
            set
            {
                CanWriteProperty("BenhSu", true);
                if (_benhSu != value)
                {
                    _benhSu = value;
                    PropertyHasChanged("BenhSu");
                }
            }
        }

        public String HuongDT
        {
            get
            {
                CanReadProperty("HuongDT", true);
                return _huongDT;
            }
            set
            {
                CanWriteProperty("HuongDT", true);
                if (_huongDT != value)
                {
                    _huongDT = value;
                    PropertyHasChanged("HuongDT");
                }
            }
        }

        public String Mabenh
        {
            get
            {
                CanReadProperty("Mabenh", true);
                return _mabenh;
            }
            set
            {
                CanWriteProperty("Mabenh", true);
                if (_mabenh != value)
                {
                    _mabenh = value;
                    PropertyHasChanged("Mabenh");
                }
            }
        }

        public String MaBenhKem
        {
            get
            {
                CanReadProperty("MaBenhKem", true);
                return _maBenhKem;
            }
            set
            {
                CanWriteProperty("MaBenhKem", true);
                if (_maBenhKem != value)
                {
                    _maBenhKem = value;
                    PropertyHasChanged("MaBenhKem");
                }
            }
        }

        public String Machuyenkhoa
        {
            get
            {
                CanReadProperty("Machuyenkhoa", true);
                return _machuyenkhoa;
            }
            set
            {
                CanWriteProperty("Machuyenkhoa", true);
                if (_machuyenkhoa != value)
                {
                    _machuyenkhoa = value;
                    PropertyHasChanged("Machuyenkhoa");
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
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm";
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
        public String TenBenh
        {
            get
            {
                CanReadProperty("TenBenh", true);
                return _tenBenh;
            }
            set
            {
                CanWriteProperty("TenBenh", true);
                if (_tenBenh != value)
                {
                    _tenBenh = value;
                    PropertyHasChanged("TenBenh");
                }
            }
        }
        public String TenBenhKem
        {
            get
            {
                CanReadProperty("TenBenhKem", true);
                return _tenBenhKem;
            }
            set
            {
                CanWriteProperty("TenBenhKem", true);
                if (_tenBenhKem != value)
                {
                    _tenBenhKem = value;
                    PropertyHasChanged("TenBenhKem");
                }
            }
        }
        public String MaICD
        {
            get
            {
                CanReadProperty("MaICD", true);
                return _maICD;
            }
            set
            {
                CanWriteProperty("MaICD", true);
                if (_maICD != value)
                {
                    _maICD = value;
                    PropertyHasChanged("MaICD");
                }
            }
        }
        public String MaICDKem
        {
            get
            {
                CanReadProperty("MaICDKem", true);
                return _maICDKem;
            }
            set
            {
                CanWriteProperty("MaICDKem", true);
                if (_maICDKem != value)
                {
                    _maICDKem = value;
                    PropertyHasChanged("MaICDKem");
                }
            }
        }
        public String TenBSKham
        {
            get
            {
                CanReadProperty("TenBSKham", true);
                return _tenBSKham;
            }
            set
            {
                CanWriteProperty("TenBSKham", true);
                if (_tenBSKham != value)
                {
                    _tenBSKham = value;
                    PropertyHasChanged("TenBSKham");
                }
            }
        }

        public String TenNguoiSD
        {
            get
            {
                CanReadProperty("TenNguoiSD", true);
                return _tennguoiSD;
            }
            set
            {
                CanWriteProperty("TenNguoiSD", true);
                if (_tennguoiSD != value)
                {
                    _tennguoiSD = value;
                    PropertyHasChanged("TenNguoiSD");
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
            return _maBA.ToString() + "!" + _sTT.ToString().ToString() + "!" + _sTTKhoa.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation

        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="BenhAn_TruyenNhiem" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static BenhAn_TruyenNhiem NewBenhAn_TruyenNhiem()
        {
            return DataPortal.Create<BenhAn_TruyenNhiem>();
        }
        public static BenhAn_TruyenNhiem GetBenhAn_TruyenNhiem(String maBA, Int32 sTT, Int32 sTTKhoa)
        {
            return DataPortal.Fetch<BenhAn_TruyenNhiem>(new Criteria(maBA, sTT, sTTKhoa));
        }

        /// <summary>
        /// Marks the <see cref="BenhAn_TruyenNhiem" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteBenhAn_TruyenNhiem(String maBA, Int32 sTT, Int32 sTTKhoa, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay, nguoihuy, maBA, sTT, sTTKhoa));
        }

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        protected internal BenhAn_TruyenNhiem()
        {
            // Prevent direct creation
        }

        internal BenhAn_TruyenNhiem(int OrderNumber,
                                 String maBA,
                                 Int32 sTT,
                                 Int32 sTTKhoa,
                                 SmartDate ngayKham,
                                 String bSKHAM,
                                 String lyDoKham,
                                 String mach,
                                 String apHuyet,
                                 String nhietDo,
                                 String nhipTho,
                                 String canNang,
                                 String chieuCao,
                                 String TSDichTe,
                                 String TSBenhCapTinh,
                                 String TSNoiSongTruocKhiBenh,
                                 SmartDate TSThoiGianNoiSong,
                                 String TSMoiSinh,

                                String toanThan,
                                String tuanHoan,
                                String hoHap,
                                String tieuHoa,
                                String ThanTNieuSDuc,
                                String thanKinh,
                                String XuongKhop,
                                String taiMuiHong,
                                String rangHamMat,
                                String mat,
                                String BenhLyKhac,

                                 String dieuTri,
                                 String benhSu,
                                 String huongDT,
                                 String mabenh,
                                 String maBenhKem,
                                 String machuyenkhoa,
                                 String maMay,
                                 Boolean huy,
                                 SmartDate ngaySD,
                                 String nguoiSD,
                                 SmartDate ngaySD1,
                                 String nguoiSD1,
                                 String tenBenh,
                                 String tenBenhKem,
            String maICD ,
                                 String maICDKem,
                                 String tenBSKham,
                                string tennguoisd
                                )
        {
            _OrderNumber = OrderNumber;
            _maBA = maBA;
            _sTT = sTT;
            _sTTKhoa = sTTKhoa;
            _ngayKham = ngayKham;
            _bSKHAM = bSKHAM;
            _lyDoKham = lyDoKham;
            _mach = mach;
            _apHuyet = apHuyet;
            _nhietDo = nhietDo;
            _nhipTho = nhipTho;
            _canNang = canNang;
            _chieuCao = chieuCao;
            _TSBenhCapTinh = TSBenhCapTinh;
            _TSDichTe = TSDichTe;
            _TSMoiSinh = TSMoiSinh;
            _TSNoiSongTruocKhiBenh = TSNoiSongTruocKhiBenh;
            _TSThoiGianNoiSong = TSThoiGianNoiSong;

            _toanThan = toanThan;
            _tuanHoan = tuanHoan;
            _hoHap = hoHap;
            _tieuHoa = tieuHoa;
            _ThanTNieuSDuc = ThanTNieuSDuc;
            _thanKinh = thanKinh;
            _XuongKhop = XuongKhop;
            _taiMuiHong = taiMuiHong;
            _rangHamMat = rangHamMat;
            _mat = mat;
            _BenhLyKhac = BenhLyKhac;

            _dieuTri = dieuTri;
            _benhSu = benhSu;
            _huongDT = huongDT;
            _mabenh = mabenh;
            _maBenhKem = maBenhKem;
            _machuyenkhoa = machuyenkhoa;
            _maMay = maMay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD;
            _ngaySD1 = ngaySD1;
            _nguoiSD1 = nguoiSD1;
            _tenBenh = tenBenh;
            _tenBenhKem = tenBenhKem;
             _maICD = maICD ;
            _maICDKem = maICDKem;
            _tenBSKham = tenBSKham;
            _tennguoiSD = tennguoisd;
        }

        #endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
            private String _maBA;
            public String MaBA
            {
                get
                {
                    return _maBA;
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

            private Int32 _sTTKhoa;
            public Int32 STTKhoa
            {
                get
                {
                    return _sTTKhoa;
                }
            }

            public Criteria(String maBA, Int32 sTT, Int32 sTTKhoa)
            {
                _maBA = maBA;
                _sTT = sTT;
                _sTTKhoa = sTTKhoa;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maBA.Equals(c._maBA))
                        return false;
                    if (!_sTT.Equals(c._sTT))
                        return false;
                    if (!_sTTKhoa.Equals(c._sTTKhoa))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maBA.ToString(), _sTT.ToString(), _sTTKhoa.ToString()).GetHashCode();
            }
        }

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maBA;
            public String MaBA
            {
                get
                {
                    return _maBA;
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

            private Int32 _sTTKhoa;
            public Int32 STTKhoa
            {
                get
                {
                    return _sTTKhoa;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maba, Int32 sTT, Int32 sTTKhoa)
            {
                _maBA = maba;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _sTT = sTT;
                _sTTKhoa = sTTKhoa;

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
        /// Retrieve an existing <see cref="BenhAn_TruyenNhiem" /> Object based on data in the database.
        /// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetBenhAn_TruyenNhiem(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
            // public override IDataReader GetBenhAn_TruyenNhiem(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_TruyenNhiem_GET", _maBA, _sTT, _sTTKhoa));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_TruyenNhiem(crit.MaBA, crit.STT, crit.STTKhoa)))
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
        /// Load a <see cref="BenhAn_TruyenNhiem" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
            if (dr.GetSmartDate("NgayKham", true) != null) _ngayKham = dr.GetSmartDate("NgayKham", true);
            if (dr.GetString("BSKHAM") != null) _bSKHAM = dr.GetString("BSKHAM");
            if (dr.GetString("LyDoKham") != null) _lyDoKham = dr.GetString("LyDoKham");
            if (dr.GetString("Mach") != null) _mach = dr.GetString("Mach");
            if (dr.GetString("ApHuyet") != null) _apHuyet = dr.GetString("ApHuyet");
            if (dr.GetString("NhietDo") != null) _nhietDo = dr.GetString("NhietDo");
            if (dr.GetString("NhipTho") != null) _nhipTho = dr.GetString("NhipTho");
            if (dr.GetString("CanNang") != null) _canNang = dr.GetString("CanNang");
            if (dr.GetString("ChieuCao") != null) _chieuCao = dr.GetString("ChieuCao");

            if (dr.GetString("TSDichTe") != null) _TSDichTe = dr.GetString("TSDichTe");
            if (dr.GetString("TSBenhCapTinh") != null) _TSBenhCapTinh = dr.GetString("TSBenhCapTinh");
            if (dr.GetString("TSNoiSongTruocKhiBenh") != null) _TSNoiSongTruocKhiBenh = dr.GetString("TSNoiSongTruocKhiBenh");
            if (dr.GetSmartDate("TSThoiGianNoiSong", true) != null) _TSThoiGianNoiSong = dr.GetSmartDate("TSThoiGianNoiSong", true);
            if (dr.GetString("TSMoiSinh") != null) _TSMoiSinh = dr.GetString("TSMoiSinh");



            if (dr.GetString("ToanThan") != null) _toanThan = dr.GetString("ToanThan");
            if (dr.GetString("TuanHoan") != null) _tuanHoan = dr.GetString("TuanHoan");
            if (dr.GetString("HoHap") != null) _hoHap = dr.GetString("HoHap");
            if (dr.GetString("TieuHoa") != null) _tieuHoa = dr.GetString("TieuHoa");
            if (dr.GetString("ThanTNieuSDuc") != null) _ThanTNieuSDuc = dr.GetString("ThanTNieuSDuc");
            if (dr.GetString("ThanKinh") != null) _thanKinh = dr.GetString("ThanKinh");
            if (dr.GetString("XuongKhop") != null) _XuongKhop = dr.GetString("XuongKhop");
            if (dr.GetString("TaiMuiHong") != null) _taiMuiHong = dr.GetString("TaiMuiHong");
            if (dr.GetString("RangHamMat") != null) _rangHamMat = dr.GetString("RangHamMat");
            if (dr.GetString("Mat") != null) _mat = dr.GetString("Mat");
            if (dr.GetString("BenhLyKhac") != null) _BenhLyKhac = dr.GetString("BenhLyKhac");

            if (dr.GetString("DieuTri") != null) _dieuTri = dr.GetString("DieuTri");
            if (dr.GetString("BenhSu") != null) _benhSu = dr.GetString("BenhSu");
            if (dr.GetString("HuongDT") != null) _huongDT = dr.GetString("HuongDT");
            if (dr.GetString("Mabenh") != null) _mabenh = dr.GetString("Mabenh");
            if (dr.GetString("MaBenhKem") != null) _maBenhKem = dr.GetString("MaBenhKem");
            if (dr.GetString("Machuyenkhoa") != null) _machuyenkhoa = dr.GetString("Machuyenkhoa");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetString("TenBenh") != null) _tenBenh = dr.GetString("TenBenh");
            if (dr.GetString("TenBenhKem") != null) _tenBenhKem = dr.GetString("TenBenhKem");
            if (dr.GetString("MaICD") != null) _maICD = dr.GetString("MaICD");
            if (dr.GetString("TenBSKham") != null) _tenBSKham = dr.GetString("TenBSKham");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");
        }

        /// <summary>
        /// Insert the new <see cref="BenhAn_TruyenNhiem" /> Object to underlying database.
        /// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_TruyenNhiem
            // Copy & paste ham duoi day vao file DataProvider.cs
            _sTT = DataProvider.Instance().InsertBenhAn_TruyenNhiem(_maBA, _sTTKhoa, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _TSDichTe,_TSBenhCapTinh, _TSNoiSongTruocKhiBenh, _TSThoiGianNoiSong, _TSMoiSinh,  _toanThan, _tuanHoan, _hoHap, _tieuHoa, _ThanTNieuSDuc, _thanKinh, _XuongKhop, _taiMuiHong, _rangHamMat, _mat, _BenhLyKhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _machuyenkhoa, _maMay, _nguoiSD);
            // public abstract String InsertBenhAn_TruyenNhiem(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _tieuHoa, String _ThanTNieuSDuc, String _thanKinh, String _XuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _BenhLyKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD);
            // public override String InsertBenhAn_TruyenNhiem(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _tieuHoa, String _ThanTNieuSDuc, String _thanKinh, String _XuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _BenhLyKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_TruyenNhiem_CREATE", _maBA, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _toanThan, _benhngoaiKhoa, _tuanHoan, _hoHap, _tieuHoa, _ThanTNieuSDuc, _thanKinh, _XuongKhop, _taiMuiHong, _rangHamMat, _mat, _BenhLyKhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _machuyenkhoa, _maMay, _huy, _ngaySD.DBValue, _nguoiSD , _ngaySD1.DBValue, _nguoiSD1), String);
            // }
            MarkOld();

        }

        /// <summary>
        /// Update all changes made on <see cref="BenhAn_TruyenNhiem" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_TruyenNhiem
            if (IsDirty)
            {
                DataProvider.Instance().UpdateBenhAn_TruyenNhiem(_maBA, _sTT, _sTTKhoa, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _TSDichTe,_TSBenhCapTinh, _TSNoiSongTruocKhiBenh, _TSThoiGianNoiSong, _TSMoiSinh, _toanThan, _tuanHoan, _hoHap, _tieuHoa, _ThanTNieuSDuc, _thanKinh, _XuongKhop, _taiMuiHong, _rangHamMat, _mat, _BenhLyKhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _machuyenkhoa, _maMay, _huy, _nguoiSD);
                // public abstract void UpdateBenhAn_TruyenNhiem(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _tieuHoa, String _ThanTNieuSDuc, String _thanKinh, String _XuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _BenhLyKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
                // public override void UpdateBenhAn_TruyenNhiem(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _tieuHoa, String _ThanTNieuSDuc, String _thanKinh, String _XuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _BenhLyKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD)
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_TruyenNhiem_UPDATE", _maBA, _sTT, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _toanThan, _benhngoaiKhoa, _tuanHoan, _hoHap, _tieuHoa, _ThanTNieuSDuc, _thanKinh, _XuongKhop, _taiMuiHong, _rangHamMat, _mat, _BenhLyKhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _machuyenkhoa, _maMay, _huy, _nguoiSD);
                // }				
            }
        }
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD, _maBA, _sTT, _sTTKhoa));
        }

        /// <summary>
        /// Delete the <see cref="BenhAn_TruyenNhiem" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_TruyenNhiem
            DataProvider.Instance().DeleteBenhAn_TruyenNhiem(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.STT, crit.STTKhoa);
            // public abstract void DeleteBenhAn_TruyenNhiem(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
            // public override void DeleteBenhAn_TruyenNhiem(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_TruyenNhiem_Deleted", _maBA, _sTT, _sTTKhoa);
            // }
        }

        #endregion
    }

}
