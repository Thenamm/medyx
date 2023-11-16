// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_DanhGiaTTDD
// Kieu doi tuong  :	BenhAn_DanhGiaTTDD
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	07/10/2010 09:22:49
// Nguoi tao       :	PM8
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
	/// This is a base generated class of <see cref="BenhAn_DanhGiaTTDD" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_DanhGiaTTDD : BusinessBase<BenhAn_DanhGiaTTDD>
	{
		#region Business Methods
		
		#region State Fields
        private String _maBA = String.Empty;
        private Int32 _sTT = 0;
        private Int32 _sTTKhoa = 0;
        private String _maKhoa = String.Empty;
        private Decimal _ChieuCao = 0;
        private Decimal _CanNangTruoc = 0;
        private Decimal _CanNangSau = 0;
        private Decimal _ChuViVongCanhTay = 0;
        private Decimal _Albumin = 0;
        private Decimal _Protein = 0;
        private Int32 _SutCan = 0;
        private Int32 _LuongAn = 0;
        private Int32 _BenhLy = 0;
        private Int32 _DuongNuoiAn = 0;
        private Boolean _HoiChanDD = false;
        private Int32 _TaiDanhGia = 0;
        private String _KQDGTTDDBMI = String.Empty;
        private Int32 _MucDoTTDDBMI = 0;
        private String _KQDGTTDDCanNangChieuCao = String.Empty;
        private Int32 _MucDoTTDDCanNangChieuCao = 0;
        private String _KQDGTTDDChieuCaoTuoi = String.Empty;
        private Int32 _MucDoTTDDChieuCaoTuoi = 0;
        private String _KQDGTTDDCanNangTuoi = String.Empty;
        private Int32 _MucDoTTDDCanNangTuoi = 0;
        private String _KQDGTTDDAlbumin = String.Empty;
        private Int32 _MucDoTTDDAlbumin = 0;
        private String _KQDGTTDDProtein = String.Empty;
        private Int32 _MucDoTTDDProtein = 0;
        private Int32 _KetLuanTTDD = 0;
        private Int32 _LanDanhGia = 0;
        private String _DeNghiCanThiep = String.Empty;
        private Int32 _TocDoTangCan = 0;
        private String _maMay = String.Empty;
        private String _bsDieuTri = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngayLap = new SmartDate(true);
        private String _nguoiLap = String.Empty;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private String _tENNGUOILAP = String.Empty;
        private String _tENNGUOISD = String.Empty;
        private String _tENNGUOIHUY = String.Empty;
        private String _ghiChu = string.Empty;
        private String _chanDoan = string.Empty;
        private String _MaCDAn = string.Empty;
        private Int32 _OrderNumber = 0;
        private Decimal _CanNangTruocMangThai = 0;
        private String _TextSutCan = String.Empty;
        private String _TextLuongAn = String.Empty;
        private String _TextBenhLy = String.Empty;
        private String _TextMucDoTTDDBMI = String.Empty;
        private String _TextMucDoTTDDChieuCaoTuoi = String.Empty;
        private String _TextMucDoTTDDCanNangTuoi = String.Empty;
        private String _TextMucDoTTDDCanNangChieuCao = String.Empty;
        private String _TextMucDoTTDDAlbumin = String.Empty;
        private String _TextMucDoTTDDProtein = String.Empty;
        private String _TextKetLuanTTDD = String.Empty;
        private String _TextDuongNuoiAn = String.Empty;
        private String _TextTaiDanhGia = String.Empty;
        private String _TextTocDoTangCan = String.Empty;
        private SmartDate _CSTuNgay = new SmartDate(true);
        private SmartDate _CSDenNgay = new SmartDate(true);
        private SmartDate _NgayDG = new SmartDate(true);
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
        public Decimal ChieuCao
        {
            get
            {
                CanReadProperty("ChieuCao", true);
                return _ChieuCao;
            }
            set
            {
                CanWriteProperty("ChieuCao", true);
                if (_ChieuCao != value)
                {
                    _ChieuCao = value;
                    PropertyHasChanged("ChieuCao");
                }
            }
        }
        public Decimal CanNangTruoc
        {
            get
            {
                CanReadProperty("CanNangTruoc", true);
                return _CanNangTruoc;
            }
            set
            {
                CanWriteProperty("CanNangTruoc", true);
                if (_CanNangTruoc != value)
                {
                    _CanNangTruoc = value;
                    PropertyHasChanged("CanNangTruoc");
                }
            }
        }
        public Decimal CanNangTruocMangThai
        {
            get
            {
                CanReadProperty("CanNangTruocMangThai", true);
                return _CanNangTruocMangThai;
            }
            set
            {
                CanWriteProperty("CanNangTruocMangThai", true);
                if (_CanNangTruocMangThai != value)
                {
                    _CanNangTruocMangThai = value;
                    PropertyHasChanged("CanNangTruocMangThai");
                }
            }
        }
        public Decimal CanNangSau
        {
            get
            {
                CanReadProperty("CanNangSau", true);
                return _CanNangSau;
            }
            set
            {
                CanWriteProperty("CanNangSau", true);
                if (_CanNangSau != value)
                {
                    _CanNangSau = value;
                    PropertyHasChanged("CanNangSau");
                }
            }
        }
        public Decimal ChuViVongCanhTay
        {
            get
            {
                CanReadProperty("ChuViVongCanhTay", true);
                return _ChuViVongCanhTay;
            }
            set
            {
                CanWriteProperty("ChuViVongCanhTay", true);
                if (_ChuViVongCanhTay != value)
                {
                    _ChuViVongCanhTay = value;
                    PropertyHasChanged("ChuViVongCanhTay");
                }
            }
        }
        public Decimal Albumin
        {
            get
            {
                CanReadProperty("Albumin", true);
                return _Albumin;
            }
            set
            {
                CanWriteProperty("Albumin", true);
                if (_Albumin != value)
                {
                    _Albumin = value;
                    PropertyHasChanged("Albumin");
                }
            }
        }
        public Decimal Protein
        {
            get
            {
                CanReadProperty("Protein", true);
                return _Protein;
            }
            set
            {
                CanWriteProperty("Protein", true);
                if (_Protein != value)
                {
                    _Protein = value;
                    PropertyHasChanged("Protein");
                }
            }
        }
        public Int32 SutCan
        {
            get
            {
                CanReadProperty("SutCan", true);
                return _SutCan;
            }
            set
            {
                CanWriteProperty("SutCan", true);
                if (_SutCan != value)
                {
                    _SutCan = value;
                    PropertyHasChanged("SutCan");
                }
            }
        }
        public Int32 LuongAn
        {
            get
            {
                CanReadProperty("LuongAn", true);
                return _LuongAn;
            }
            set
            {
                CanWriteProperty("LuongAn", true);
                if (_LuongAn != value)
                {
                    _LuongAn = value;
                    PropertyHasChanged("LuongAn");
                }
            }
        }
        public Int32 BenhLy
        {
            get
            {
                CanReadProperty("BenhLy", true);
                return _BenhLy;
            }
            set
            {
                CanWriteProperty("BenhLy", true);
                if (_BenhLy != value)
                {
                    _BenhLy = value;
                    PropertyHasChanged("BenhLy");
                }
            }
        }
        public Int32 DuongNuoiAn
        {
            get
            {
                CanReadProperty("DuongNuoiAn", true);
                return _DuongNuoiAn;
            }
            set
            {
                CanWriteProperty("DuongNuoiAn", true);
                if (_DuongNuoiAn != value)
                {
                    _DuongNuoiAn = value;
                    PropertyHasChanged("DuongNuoiAn");
                }
            }
        }
        public Boolean HoiChanDD
        {
            get
            {
                CanReadProperty("HoiChanDD", true);
                return _HoiChanDD;
            }
            set
            {
                CanWriteProperty("HoiChanDD", true);
                if (_HoiChanDD != value)
                {
                    _HoiChanDD = value;
                    PropertyHasChanged("HoiChanDD");
                }
            }
        }
        public Int32 TaiDanhGia
        {
            get
            {
                CanReadProperty("TaiDanhGia", true);
                return _TaiDanhGia;
            }
            set
            {
                CanWriteProperty("TaiDanhGia", true);
                if (_TaiDanhGia != value)
                {
                    _TaiDanhGia = value;
                    PropertyHasChanged("TaiDanhGia");
                }
            }
        }
        public String KQDGTTDDBMI
        {
            get
            {
                CanReadProperty("KQDGTTDDBMI", true);
                return _KQDGTTDDBMI;
            }
            set
            {
                CanWriteProperty("KQDGTTDDBMI", true);
                if (_KQDGTTDDBMI != value)
                {
                    _KQDGTTDDBMI = value;
                    PropertyHasChanged("KQDGTTDDBMI");
                }
            }
        }
        public Int32 MucDoTTDDBMI
        {
            get
            {
                CanReadProperty("MucDoTTDDBMI", true);
                return _MucDoTTDDBMI;
            }
            set
            {
                CanWriteProperty("MucDoTTDDBMI", true);
                if (_MucDoTTDDBMI != value)
                {
                    _MucDoTTDDBMI = value;
                    PropertyHasChanged("MucDoTTDDBMI");
                }
            }
        }
        public String KQDGTTDDCanNangChieuCao
        {
            get
            {
                CanReadProperty("KQDGTTDDCanNangChieuCao", true);
                return _KQDGTTDDCanNangChieuCao;
            }
            set
            {
                CanWriteProperty("KQDGTTDDCanNangChieuCao", true);
                if (_KQDGTTDDCanNangChieuCao != value)
                {
                    _KQDGTTDDCanNangChieuCao = value;
                    PropertyHasChanged("KQDGTTDDCanNangChieuCao");
                }
            }
        }
        public Int32 MucDoTTDDCanNangChieuCao
        {
            get
            {
                CanReadProperty("MucDoTTDDCanNangChieuCao", true);
                return _MucDoTTDDCanNangChieuCao;
            }
            set
            {
                CanWriteProperty("MucDoTTDDCanNangChieuCao", true);
                if (_MucDoTTDDCanNangChieuCao != value)
                {
                    _MucDoTTDDCanNangChieuCao = value;
                    PropertyHasChanged("MucDoTTDDCanNangChieuCao");
                }
            }
        }
        public String KQDGTTDDChieuCaoTuoi
        {
            get
            {
                CanReadProperty("KQDGTTDDChieuCaoTuoi", true);
                return _KQDGTTDDChieuCaoTuoi;
            }
            set
            {
                CanWriteProperty("KQDGTTDDChieuCaoTuoi", true);
                if (_KQDGTTDDChieuCaoTuoi != value)
                {
                    _KQDGTTDDChieuCaoTuoi = value;
                    PropertyHasChanged("KQDGTTDDChieuCaoTuoi");
                }
            }
        }
        public Int32 MucDoTTDDChieuCaoTuoi
        {
            get
            {
                CanReadProperty("MucDoTTDDChieuCaoTuoi", true);
                return _MucDoTTDDChieuCaoTuoi;
            }
            set
            {
                CanWriteProperty("MucDoTTDDChieuCaoTuoi", true);
                if (_MucDoTTDDChieuCaoTuoi != value)
                {
                    _MucDoTTDDChieuCaoTuoi = value;
                    PropertyHasChanged("MucDoTTDDChieuCaoTuoi");
                }
            }
        }
        public String KQDGTTDDCanNangTuoi
        {
            get
            {
                CanReadProperty("KQDGTTDDCanNangTuoi", true);
                return _KQDGTTDDCanNangTuoi;
            }
            set
            {
                CanWriteProperty("KQDGTTDDCanNangTuoi", true);
                if (_KQDGTTDDCanNangTuoi != value)
                {
                    _KQDGTTDDCanNangTuoi = value;
                    PropertyHasChanged("KQDGTTDDCanNangTuoi");
                }
            }
        }
        public Int32 MucDoTTDDCanNangTuoi
        {
            get
            {
                CanReadProperty("MucDoTTDDCanNangTuoi", true);
                return _MucDoTTDDCanNangTuoi;
            }
            set
            {
                CanWriteProperty("MucDoTTDDCanNangTuoi", true);
                if (_MucDoTTDDCanNangTuoi != value)
                {
                    _MucDoTTDDCanNangTuoi = value;
                    PropertyHasChanged("MucDoTTDDCanNangTuoi");
                }
            }
        }
        public String KQDGTTDDAlbumin
        {
            get
            {
                CanReadProperty("KQDGTTDDAlbumin", true);
                return _KQDGTTDDAlbumin;
            }
            set
            {
                CanWriteProperty("KQDGTTDDAlbumin", true);
                if (_KQDGTTDDAlbumin != value)
                {
                    _KQDGTTDDAlbumin = value;
                    PropertyHasChanged("KQDGTTDDAlbumin");
                }
            }
        }
        public Int32 MucDoTTDDAlbumin
        {
            get
            {
                CanReadProperty("MucDoTTDDAlbumin", true);
                return _MucDoTTDDAlbumin;
            }
            set
            {
                CanWriteProperty("MucDoTTDDAlbumin", true);
                if (_MucDoTTDDAlbumin != value)
                {
                    _MucDoTTDDAlbumin = value;
                    PropertyHasChanged("MucDoTTDDAlbumin");
                }
            }
        }
        public String KQDGTTDDProtein
        {
            get
            {
                CanReadProperty("KQDGTTDDProtein", true);
                return _KQDGTTDDProtein;
            }
            set
            {
                CanWriteProperty("KQDGTTDDProtein", true);
                if (_KQDGTTDDProtein != value)
                {
                    _KQDGTTDDProtein = value;
                    PropertyHasChanged("KQDGTTDDProtein");
                }
            }
        }
        public Int32 MucDoTTDDProtein
        {
            get
            {
                CanReadProperty("MucDoTTDDProtein", true);
                return _MucDoTTDDProtein;
            }
            set
            {
                CanWriteProperty("MucDoTTDDProtein", true);
                if (_MucDoTTDDProtein != value)
                {
                    _MucDoTTDDProtein = value;
                    PropertyHasChanged("MucDoTTDDProtein");
                }
            }
        }
        public Int32 KetLuanTTDD
        {
            get
            {
                CanReadProperty("KetLuanTTDD", true);
                return _KetLuanTTDD;
            }
            set
            {
                CanWriteProperty("KetLuanTTDD", true);
                if (_KetLuanTTDD != value)
                {
                    _KetLuanTTDD = value;
                    PropertyHasChanged("KetLuanTTDD");
                }
            }
        }
        public Int32 LanDanhGia
        {
            get
            {
                CanReadProperty("LanDanhGia", true);
                return _LanDanhGia;
            }
            set
            {
                CanWriteProperty("LanDanhGia", true);
                if (_LanDanhGia != value)
                {
                    _LanDanhGia = value;
                    PropertyHasChanged("LanDanhGia");
                }
            }
        }
        public String DeNghiCanThiep
        {
            get
            {
                CanReadProperty("DeNghiCanThiep", true);
                return _DeNghiCanThiep;
            }
            set
            {
                CanWriteProperty("DeNghiCanThiep", true);
                if (_DeNghiCanThiep != value)
                {
                    _DeNghiCanThiep = value;
                    PropertyHasChanged("DeNghiCanThiep");
                }
            }
        }
        public Int32 TocDoTangCan
        {
            get
            {
                CanReadProperty("TocDoTangCan", true);
                return _TocDoTangCan;
            }
            set
            {
                CanWriteProperty("TocDoTangCan", true);
                if (_TocDoTangCan != value)
                {
                    _TocDoTangCan = value;
                    PropertyHasChanged("TocDoTangCan");
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
        public String BSDieuTri
        {
            get
            {
                CanReadProperty("BSDieuTri", true);
                return _bsDieuTri;
            }
            set
            {
                CanWriteProperty("BSDieuTri", true);
                if (_bsDieuTri != value)
                {
                    _bsDieuTri = value;
                    PropertyHasChanged("BSDieuTri");
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
        public String NgayLap
        {
            get
            {
                CanReadProperty("NgayLap", true);
                this._ngayLap.FormatString = "dd/MM/yyyy";
                return _ngayLap.Text;
            }
            set
            {
                CanWriteProperty("NgayLap", true);
                if (_ngayLap.Text != value)
                {
                    _ngayLap.Text = value;
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
        public String NgaySD
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
        public String TENNGUOILAP
        {
            get
            {
                CanReadProperty("TENNGUOILAP", true);
                return _tENNGUOILAP;
            }
            set
            {
                CanWriteProperty("TENNGUOILAP", true);
                if (_tENNGUOILAP != value)
                {
                    _tENNGUOILAP = value;
                    PropertyHasChanged("TENNGUOILAP");
                }
            }
        }
        public String TENNGUOISD
        {
            get
            {
                CanReadProperty("TENNGUOISD", true);
                return _tENNGUOISD;
            }
            set
            {
                CanWriteProperty("TENNGUOISD", true);
                if (_tENNGUOISD != value)
                {
                    _tENNGUOISD = value;
                    PropertyHasChanged("TENNGUOISD");
                }
            }
        }
        public String TENNGUOIHUY
        {
            get
            {
                CanReadProperty("TENNGUOIHUY", true);
                return _tENNGUOIHUY;
            }
            set
            {
                CanWriteProperty("TENNGUOIHUY", true);
                if (_tENNGUOIHUY != value)
                {
                    _tENNGUOIHUY = value;
                    PropertyHasChanged("TENNGUOIHUY");
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
        public String ChanDoan
        {
            get
            {
                CanReadProperty("ChanDoan", true);
                return _chanDoan;
            }
            set
            {
                CanWriteProperty("ChanDoan", true);
                if (_chanDoan != value)
                {
                    _chanDoan = value;
                    PropertyHasChanged("ChanDoan");
                }
            }
        }
        public String MaCDAn
        {
            get
            {
                CanReadProperty("MaCDAn", true);
                return _MaCDAn;
            }
            set
            {
                CanWriteProperty("MaCDAn", true);
                if (_MaCDAn != value)
                {
                    _MaCDAn = value;
                    PropertyHasChanged("MaCDAn");
                }
            }
        }
        protected override Object GetIdValue()
        {
            return _maBA.ToString() + "!" + _sTT.ToString().ToString() + "!" + _sTTKhoa.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
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
        public String TextSutCan
        {
            get
            {
                CanReadProperty("TextSutCan", true);
                return _TextSutCan;
            }
            set
            {
                CanWriteProperty("TextSutCan", true);
                if (_TextSutCan != value)
                {
                    _TextSutCan = value;
                    PropertyHasChanged("TextSutCan");
                }
            }
        }
        public String TextLuongAn
        {
            get
            {
                CanReadProperty("TextLuongAn", true);
                return _TextLuongAn;
            }
            set
            {
                CanWriteProperty("TextLuongAn", true);
                if (_TextLuongAn != value)
                {
                    _TextLuongAn = value;
                    PropertyHasChanged("TextLuongAn");
                }
            }
        }
        public String TextBenhLy
        {
            get
            {
                CanReadProperty("TextBenhLy", true);
                return _TextBenhLy;
            }
            set
            {
                CanWriteProperty("TextBenhLy", true);
                if (_TextBenhLy != value)
                {
                    _TextBenhLy = value;
                    PropertyHasChanged("TextBenhLy");
                }
            }
        }
        public String TextMucDoTTDDBMI
        {
            get
            {
                CanReadProperty("TextMucDoTTDDBMI", true);
                return _TextMucDoTTDDBMI;
            }
            set
            {
                CanWriteProperty("TextMucDoTTDDBMI", true);
                if (_TextMucDoTTDDBMI != value)
                {
                    _TextMucDoTTDDBMI = value;
                    PropertyHasChanged("TextMucDoTTDDBMI");
                }
            }
        }
        public String TextMucDoTTDDChieuCaoTuoi
        {
            get
            {
                CanReadProperty("TextMucDoTTDDChieuCaoTuoi", true);
                return _TextMucDoTTDDChieuCaoTuoi;
            }
            set
            {
                CanWriteProperty("TextMucDoTTDDChieuCaoTuoi", true);
                if (_TextMucDoTTDDChieuCaoTuoi != value)
                {
                    _TextMucDoTTDDChieuCaoTuoi = value;
                    PropertyHasChanged("TextMucDoTTDDChieuCaoTuoi");
                }
            }
        }
        public String TextMucDoTTDDCanNangTuoi
        {
            get
            {
                CanReadProperty("TextMucDoTTDDCanNangTuoi", true);
                return _TextMucDoTTDDCanNangTuoi;
            }
            set
            {
                CanWriteProperty("TextMucDoTTDDCanNangTuoi", true);
                if (_TextMucDoTTDDCanNangTuoi != value)
                {
                    _TextMucDoTTDDCanNangTuoi = value;
                    PropertyHasChanged("TextMucDoTTDDCanNangTuoi");
                }
            }
        }
        public String TextMucDoTTDDCanNangChieuCao
        {
            get
            {
                CanReadProperty("TextMucDoTTDDCanNangChieuCao", true);
                return _TextMucDoTTDDCanNangChieuCao;
            }
            set
            {
                CanWriteProperty("TextMucDoTTDDCanNangChieuCao", true);
                if (_TextMucDoTTDDCanNangChieuCao != value)
                {
                    _TextMucDoTTDDCanNangChieuCao = value;
                    PropertyHasChanged("TextMucDoTTDDCanNangChieuCao");
                }
            }
        }
        public String TextMucDoTTDDAlbumin
        {
            get
            {
                CanReadProperty("TextMucDoTTDDAlbumin", true);
                return _TextMucDoTTDDAlbumin;
            }
            set
            {
                CanWriteProperty("TextMucDoTTDDAlbumin", true);
                if (_TextMucDoTTDDAlbumin != value)
                {
                    _TextMucDoTTDDAlbumin = value;
                    PropertyHasChanged("TextMucDoTTDDAlbumin");
                }
            }
        }
        public String TextMucDoTTDDProtein
        {
            get
            {
                CanReadProperty("TextMucDoTTDDProtein", true);
                return _TextMucDoTTDDProtein;
            }
            set
            {
                CanWriteProperty("TextMucDoTTDDProtein", true);
                if (_TextMucDoTTDDProtein != value)
                {
                    _TextMucDoTTDDProtein = value;
                    PropertyHasChanged("TextMucDoTTDDProtein");
                }
            }
        }
        public String TextKetLuanTTDD
        {
            get
            {
                CanReadProperty("TextKetLuanTTDD", true);
                return _TextKetLuanTTDD;
            }
            set
            {
                CanWriteProperty("TextKetLuanTTDD", true);
                if (_TextKetLuanTTDD != value)
                {
                    _TextKetLuanTTDD = value;
                    PropertyHasChanged("TextKetLuanTTDD");
                }
            }
        }
        public String TextDuongNuoiAn
        {
            get
            {
                CanReadProperty("TextDuongNuoiAn", true);
                return _TextDuongNuoiAn;
            }
            set
            {
                CanWriteProperty("TextDuongNuoiAn", true);
                if (_TextDuongNuoiAn != value)
                {
                    _TextDuongNuoiAn = value;
                    PropertyHasChanged("TextDuongNuoiAn");
                }
            }
        }
        public String TextTaiDanhGia
        {
            get
            {
                CanReadProperty("TextTaiDanhGia", true);
                return _TextTaiDanhGia;
            }
            set
            {
                CanWriteProperty("TextTaiDanhGia", true);
                if (_TextTaiDanhGia != value)
                {
                    _TextTaiDanhGia = value;
                    PropertyHasChanged("TextTaiDanhGia");
                }
            }
        }
        public String TextTocDoTangCan
        {
            get
            {
                CanReadProperty("TextTocDoTangCan", true);
                return _TextTocDoTangCan;
            }
            set
            {
                CanWriteProperty("TextTocDoTangCan", true);
                if (_TextTocDoTangCan != value)
                {
                    _TextTocDoTangCan = value;
                    PropertyHasChanged("TextTocDoTangCan");
                }
            }
        }
        public String CSTuNgay
        {
            get
            {
                CanReadProperty("CSTuNgay", true);
                this._CSTuNgay.FormatString = "dd/MM/yyyy";
                return _CSTuNgay.Text;
            }
            set
            {
                CanWriteProperty("CSTuNgay", true);
                if (_CSTuNgay.Text != value)
                {
                    _CSTuNgay.Text = value;
                    PropertyHasChanged("CSTuNgay");
                }
            }
        }
        public String CSDenNgay
        {
            get
            {
                CanReadProperty("CSDenNgay", true);
                this._CSDenNgay.FormatString = "dd/MM/yyyy";
                return _CSDenNgay.Text;
            }
            set
            {
                CanWriteProperty("CSDenNgay", true);
                if (_CSDenNgay.Text != value)
                {
                    _CSDenNgay.Text = value;
                    PropertyHasChanged("CSDenNgay");
                }
            }
        }
        public String NgayDG
        {
            get
            {
                CanReadProperty("NgayDG", true);
                this._NgayDG.FormatString = "dd/MM/yyyy";
                return _NgayDG.Text;
            }
            set
            {
                CanWriteProperty("NgayDG", true);
                if (_NgayDG.Text != value)
                {
                    _NgayDG.Text = value;
                    PropertyHasChanged("NgayDG");
                }
            }
        }
        #endregion

        #endregion


        #region Business Object Rules and Validation
        //protected override void AddBusinessRules()
        //{
        //TODO: add validation rules

        //ValidationRules.AddRule<BenhAn_ThuocSD>(ValidationTuNgayDenNgay<BenhAn_ThuocSD>, "TuNgay");
        //ValidationRules.AddRule<BenhAn_ThuocSD>(ValidationTuNgayDenNgay<BenhAn_ThuocSD>, "DenNgay");
        //ValidationRules.AddRule<BenhAn_ThuocSD>(ValidationNgayDKDenNgay<BenhAn_ThuocSD>, "DenNgay");
        //ValidationRules.AddRule<BenhAn_ThuocSD>(ValidationNgayDKDenNgay<BenhAn_ThuocSD>, "NgayDK");
        //ValidationRules.AddDependantProperty("TuNgay", "DenNgay");
        //ValidationRules.AddDependantProperty("DenNgay", "NgayDK");

        //}

        //private static bool ValidationNgaySinh<T>(T target, Csla.Validation.RuleArgs e) where T : BenhAn_Chamsoc
        //{
        //    if (target._tuNgay.Date > System.DateTime.Now.AddDays(1))
        //    {
        //        e.Description = "VALIDATION_NOW";
        //        return false;
        //    }
        //    else
        //        return true;
        //}
        //private static bool ValidationNgayDKDenNgay<T>(T target, Csla.Validation.RuleArgs e) where T : BenhAn_ThuocSD
        //{
        //    if (target._ngayDK > target._DenNgay)
        //    {
        //        e.Description = "Ngày lĩnh không được lớn hơn đến ngày";
        //        return false;
        //    }
        //    else
        //        return true;
        //}
        //private static bool ValidationTuNgayDenNgay<T>(T target, Csla.Validation.RuleArgs e) where T : BenhAn_ThuocSD
        //{
        //    if (target._TuNgay > target._DenNgay)
        //    {
        //        e.Description = "Từ ngày không được lớn hơn đến ngày";
        //        return false;
        //    }
        //    else
        //        return true;
        //}
        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="BenhAn_DanhGiaTTDD" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static BenhAn_DanhGiaTTDD NewBenhAn_DanhGiaTTDD()
        {
            return new BenhAn_DanhGiaTTDD();
        }
        internal static BenhAn_DanhGiaTTDD GetBenhAn_DanhGiaTTDD(SafeDataReader dr, int i)
        {
            return new BenhAn_DanhGiaTTDD(dr, i);
        }
        public BenhAn_DanhGiaTTDD()
        {
            MarkAsChild();
        }
        public static BenhAn_DanhGiaTTDD GetBenhAn_DanhGiaTTDD(String maBA, Int32 sTT, Int32 sTTKhoa, Int32 LanDanhGia)
        {
            return DataPortal.Fetch<BenhAn_DanhGiaTTDD>(new Criteria(maBA, sTT, sTTKhoa, false, LanDanhGia));
        }
        public static BenhAn_DanhGiaTTDD GetBenhAn_DanhGiaTTDD(SafeDataReader dr)
        {
            BenhAn_DanhGiaTTDD obj = new BenhAn_DanhGiaTTDD();
            obj.Fetch(dr);
            return obj;
        }
		/// <summary>
		/// Marks the <see cref="BenhAn_DanhGiaTTDD" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBenhAn_DanhGiaTTDD(String maBA, Int32 sTT, Int32 sTTKhoa, string mamay, string nguoihuy, int LanDanhGia)
        {
            DataPortal.Delete(new OtherCriteria(maBA, sTT, sTTKhoa, mamay, nguoihuy, LanDanhGia));
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
            private Int32 _LanDanhGia;
            public Int32 LanDanhGia
            {
                get
                {
                    return _LanDanhGia;
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
            private Boolean _qadmin= HTC.ShareVariables.pub_bQadmin ;
            public Boolean QAdmin
            {
                get
                {
                    return _qadmin;
                }
            }
			public Criteria(String maBA, Int32 sTT, Int32 sTTKhoa, Boolean QAdmin, Int32 LanDanhGia)
			{
				_maBA = maBA;
				_sTT = sTT;
				_sTTKhoa = sTTKhoa;
                _qadmin = QAdmin;
                _LanDanhGia = LanDanhGia;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
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
            private Int32 _LanDanhGia;
            public Int32 LanDanhGia
            {
                get
                {
                    return _LanDanhGia;
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
            private String _dienBien;
            public String DienBien
            {
                get
                {
                    return _dienBien;
                }
            }
            private String _xetNghiem;
            public String XetNghiem
            {
                get
                {
                    return _xetNghiem;
                }
            }
            private String _quaTrinh;
            public String QuaTrinh
            {
                get
                {
                    return _quaTrinh;
                }
            }
            private String _danhGia;
            public String DanhGia
            {
                get
                {
                    return _danhGia;
                }
            }
            private String _huongDT;
            public String HuongDT
            {
                get
                {
                    return _huongDT;
                }
            }
            private String _bsDieuTri;
            public String BSDieuTri
            {
                get
                {
                    return _bsDieuTri;
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
            private String _lydohuy;
            public String lydohuy
            {
                get
                {
                    return _lydohuy;
                }
            }
            public OtherCriteria( String maBA, Int32 sTT, Int32 sTTKhoa,String Mamay, String Nguoisd, Int32 LanDanhGia)
            {
                _maBA = maBA;
                _sTT = sTT;
                _sTTKhoa = sTTKhoa;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _LanDanhGia = LanDanhGia;
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
		/// Retrieve an existing <see cref="BenhAn_DanhGiaTTDD" /> Object based on data in the database.
		/// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetBenhAn_DanhGiaTTDD(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
            // public override IDataReader GetBenhAn_DanhGiaTTDD(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBA, _sTT, _sTTKhoa));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_DanhGiaTTDD(crit.MaBA, crit.STT, crit.STTKhoa,crit.QAdmin,crit.LanDanhGia )))
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
		/// Load a <see cref="BenhAn_DanhGiaTTDD" /> Object from given SafeDataReader.
		/// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
            if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
            if (dr.GetDecimal("ChieuCao") != null) _ChieuCao = dr.GetDecimal("ChieuCao");
            if (dr.GetDecimal("CanNangTruoc") != null) _CanNangTruoc = dr.GetDecimal("CanNangTruoc");
            if (dr.GetDecimal("CanNangTruocMangThai") != null) _CanNangTruocMangThai = dr.GetDecimal("CanNangTruocMangThai");
            if (dr.GetDecimal("CanNangSau") != null) _CanNangSau = dr.GetDecimal("CanNangSau");
            if (dr.GetDecimal("ChuViVongCanhTay") != null) _ChuViVongCanhTay = dr.GetDecimal("ChuViVongCanhTay");
            if (dr.GetDecimal("Albumin") != null) _Albumin = dr.GetDecimal("Albumin");
            if (dr.GetDecimal("Protein") != null) _Protein = dr.GetDecimal("Protein");
            if (dr.GetInt32("SutCan") != null) _SutCan = dr.GetInt32("SutCan");
            if (dr.GetInt32("LuongAn") != null) _LuongAn = dr.GetInt32("LuongAn");
            if (dr.GetInt32("BenhLy") != null) _BenhLy = dr.GetInt32("BenhLy");
            if (dr.GetInt32("DuongNuoiAn") != null) _DuongNuoiAn = dr.GetInt32("DuongNuoiAn");
            if (dr.GetBoolean("HoiChanDD") != null) _HoiChanDD = dr.GetBoolean("HoiChanDD");
            if (dr.GetInt32("TaiDanhGia") != null) _TaiDanhGia = dr.GetInt32("TaiDanhGia");
            if (dr.GetString("KQDGTTDDBMI") != null) _KQDGTTDDBMI = dr.GetString("KQDGTTDDBMI");
            if (dr.GetInt32("MucDoTTDDBMI") != null) _MucDoTTDDBMI = dr.GetInt32("MucDoTTDDBMI");
            if (dr.GetString("KQDGTTDDCanNangChieuCao") != null) _KQDGTTDDCanNangChieuCao = dr.GetString("KQDGTTDDCanNangChieuCao");
            if (dr.GetInt32("MucDoTTDDCanNangChieuCao") != null) _MucDoTTDDCanNangChieuCao = dr.GetInt32("MucDoTTDDCanNangChieuCao");
            if (dr.GetString("KQDGTTDDChieuCaoTuoi") != null) _KQDGTTDDChieuCaoTuoi = dr.GetString("KQDGTTDDChieuCaoTuoi");
            if (dr.GetInt32("MucDoTTDDChieuCaoTuoi") != null) _MucDoTTDDChieuCaoTuoi = dr.GetInt32("MucDoTTDDChieuCaoTuoi");
            if (dr.GetString("KQDGTTDDCanNangTuoi") != null) _KQDGTTDDCanNangTuoi = dr.GetString("KQDGTTDDCanNangTuoi");
            if (dr.GetInt32("MucDoTTDDCanNangTuoi") != null) _MucDoTTDDCanNangTuoi = dr.GetInt32("MucDoTTDDCanNangTuoi");
            if (dr.GetString("KQDGTTDDAlbumin") != null) _KQDGTTDDAlbumin = dr.GetString("KQDGTTDDAlbumin");
            if (dr.GetInt32("MucDoTTDDAlbumin") != null) _MucDoTTDDAlbumin = dr.GetInt32("MucDoTTDDAlbumin");
            if (dr.GetString("KQDGTTDDProtein") != null) _KQDGTTDDProtein = dr.GetString("KQDGTTDDProtein");
            if (dr.GetInt32("MucDoTTDDProtein") != null) _MucDoTTDDProtein = dr.GetInt32("MucDoTTDDProtein");
            if (dr.GetInt32("KetLuanTTDD") != null) _KetLuanTTDD = dr.GetInt32("KetLuanTTDD");
            if (dr.GetInt32("LanDanhGia") != null) _LanDanhGia = dr.GetInt32("LanDanhGia");
            if (dr.GetString("DeNghiCanThiep") != null) _DeNghiCanThiep = dr.GetString("DeNghiCanThiep");
            if (dr.GetInt32("TocDoTangCan") != null) _TocDoTangCan = dr.GetInt32("TocDoTangCan");
            if (dr.GetString("BSDieuTri") != null) _bsDieuTri = dr.GetString("BSDieuTri");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
            if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("TENNGUOILAP") != null) _tENNGUOILAP = dr.GetString("TENNGUOILAP");
            if (dr.GetString("TENNGUOISD") != null) _tENNGUOISD = dr.GetString("TENNGUOISD");
            if (dr.GetString("TENNGUOIHUY") != null) _tENNGUOIHUY = dr.GetString("TENNGUOIHUY");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetString("ChanDoan") != null) _chanDoan = dr.GetString("ChanDoan");
            if (dr.GetString("MaCDAn") != null) _MaCDAn = dr.GetString("MaCDAn");
            if (dr.GetString("TextSutCan") != null) _TextSutCan = dr.GetString("TextSutCan");
            if (dr.GetString("TextLuongAn") != null) _TextLuongAn = dr.GetString("TextLuongAn");
            if (dr.GetString("TextBenhLy") != null) _TextBenhLy = dr.GetString("TextBenhLy");
            if (dr.GetString("TextMucDoTTDDBMI") != null) _TextMucDoTTDDBMI = dr.GetString("TextMucDoTTDDBMI");
            if (dr.GetString("TextMucDoTTDDChieuCaoTuoi") != null) _TextMucDoTTDDChieuCaoTuoi = dr.GetString("TextMucDoTTDDChieuCaoTuoi");
            if (dr.GetString("TextMucDoTTDDCanNangTuoi") != null) _TextMucDoTTDDCanNangTuoi = dr.GetString("TextMucDoTTDDCanNangTuoi");
            if (dr.GetString("TextMucDoTTDDCanNangChieuCao") != null) _TextMucDoTTDDCanNangChieuCao = dr.GetString("TextMucDoTTDDCanNangChieuCao");
            if (dr.GetString("TextMucDoTTDDAlbumin") != null) _TextMucDoTTDDAlbumin = dr.GetString("TextMucDoTTDDAlbumin");
            if (dr.GetString("TextMucDoTTDDProtein") != null) _TextMucDoTTDDProtein = dr.GetString("TextMucDoTTDDProtein");
            if (dr.GetString("TextKetLuanTTDD") != null) _TextKetLuanTTDD = dr.GetString("TextKetLuanTTDD");
            if (dr.GetString("TextDuongNuoiAn") != null) _TextDuongNuoiAn = dr.GetString("TextDuongNuoiAn");
            if (dr.GetString("TextTaiDanhGia") != null) _TextTaiDanhGia = dr.GetString("TextTaiDanhGia");
            if (dr.GetString("TextTocDoTangCan") != null) _TextTocDoTangCan = dr.GetString("TextTocDoTangCan");
            if (dr.GetSmartDate("CSTuNgay", true) != null) _CSTuNgay = dr.GetSmartDate("CSTuNgay", true);
            if (dr.GetSmartDate("CSDenNgay", true) != null) _CSDenNgay = dr.GetSmartDate("CSDenNgay", true);
            if (dr.GetSmartDate("NgayDG", true) != null) _NgayDG = dr.GetSmartDate("NgayDG", true);
        }
		
		/// <summary>
		/// Insert the new <see cref="BenhAn_DanhGiaTTDD" /> Object to underlying database.
		/// </summary>
        /// 

        private BenhAn_DanhGiaTTDD(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
            if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
            if (dr.GetDecimal("ChieuCao") != null) _ChieuCao = dr.GetDecimal("ChieuCao");
            if (dr.GetDecimal("CanNangTruoc") != null) _CanNangTruoc = dr.GetDecimal("CanNangTruoc");
            if (dr.GetDecimal("CanNangTruocMangThai") != null) _CanNangTruocMangThai = dr.GetDecimal("CanNangTruocMangThai");
            if (dr.GetDecimal("CanNangSau") != null) _CanNangSau = dr.GetDecimal("CanNangSau");
            if (dr.GetDecimal("ChuViVongCanhTay") != null) _ChuViVongCanhTay = dr.GetDecimal("ChuViVongCanhTay");
            if (dr.GetDecimal("Albumin") != null) _Albumin = dr.GetDecimal("Albumin");
            if (dr.GetDecimal("Protein") != null) _Protein = dr.GetDecimal("Protein");
            if (dr.GetInt32("SutCan") != null) _SutCan = dr.GetInt32("SutCan");
            if (dr.GetInt32("LuongAn") != null) _LuongAn = dr.GetInt32("LuongAn");
            if (dr.GetInt32("BenhLy") != null) _BenhLy = dr.GetInt32("BenhLy");
            if (dr.GetInt32("DuongNuoiAn") != null) _DuongNuoiAn = dr.GetInt32("DuongNuoiAn");
            if (dr.GetBoolean("HoiChanDD") != null) _HoiChanDD = dr.GetBoolean("HoiChanDD");
            if (dr.GetInt32("TaiDanhGia") != null) _TaiDanhGia = dr.GetInt32("TaiDanhGia");
            if (dr.GetString("KQDGTTDDBMI") != null) _KQDGTTDDBMI = dr.GetString("KQDGTTDDBMI");
            if (dr.GetInt32("MucDoTTDDBMI") != null) _MucDoTTDDBMI = dr.GetInt32("MucDoTTDDBMI");
            if (dr.GetString("KQDGTTDDCanNangChieuCao") != null) _KQDGTTDDCanNangChieuCao = dr.GetString("KQDGTTDDCanNangChieuCao");
            if (dr.GetInt32("MucDoTTDDCanNangChieuCao") != null) _MucDoTTDDCanNangChieuCao = dr.GetInt32("MucDoTTDDCanNangChieuCao");
            if (dr.GetString("KQDGTTDDChieuCaoTuoi") != null) _KQDGTTDDChieuCaoTuoi = dr.GetString("KQDGTTDDChieuCaoTuoi");
            if (dr.GetInt32("MucDoTTDDChieuCaoTuoi") != null) _MucDoTTDDChieuCaoTuoi = dr.GetInt32("MucDoTTDDChieuCaoTuoi");
            if (dr.GetString("KQDGTTDDCanNangTuoi") != null) _KQDGTTDDCanNangTuoi = dr.GetString("KQDGTTDDCanNangTuoi");
            if (dr.GetInt32("MucDoTTDDCanNangTuoi") != null) _MucDoTTDDCanNangTuoi = dr.GetInt32("MucDoTTDDCanNangTuoi");
            if (dr.GetString("KQDGTTDDAlbumin") != null) _KQDGTTDDAlbumin = dr.GetString("KQDGTTDDAlbumin");
            if (dr.GetInt32("MucDoTTDDAlbumin") != null) _MucDoTTDDAlbumin = dr.GetInt32("MucDoTTDDAlbumin");
            if (dr.GetString("KQDGTTDDProtein") != null) _KQDGTTDDProtein = dr.GetString("KQDGTTDDProtein");
            if (dr.GetInt32("MucDoTTDDProtein") != null) _MucDoTTDDProtein = dr.GetInt32("MucDoTTDDProtein");
            if (dr.GetInt32("KetLuanTTDD") != null) _KetLuanTTDD = dr.GetInt32("KetLuanTTDD");
            if (dr.GetInt32("LanDanhGia") != null) _LanDanhGia = dr.GetInt32("LanDanhGia");
            if (dr.GetString("DeNghiCanThiep") != null) _DeNghiCanThiep = dr.GetString("DeNghiCanThiep");
            if (dr.GetInt32("TocDoTangCan") != null) _TocDoTangCan = dr.GetInt32("TocDoTangCan");
            if (dr.GetString("BSDieuTri") != null) _bsDieuTri = dr.GetString("BSDieuTri");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
            if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("TENNGUOILAP") != null) _tENNGUOILAP = dr.GetString("TENNGUOILAP");
            if (dr.GetString("TENNGUOISD") != null) _tENNGUOISD = dr.GetString("TENNGUOISD");
            if (dr.GetString("TENNGUOIHUY") != null) _tENNGUOIHUY = dr.GetString("TENNGUOIHUY");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetString("ChanDoan") != null) _chanDoan = dr.GetString("ChanDoan");
            if (dr.GetString("MaCDAn") != null) _MaCDAn = dr.GetString("MaCDAn");
            if (dr.GetString("TextSutCan") != null) _TextSutCan = dr.GetString("TextSutCan");
            if (dr.GetString("TextLuongAn") != null) _TextLuongAn = dr.GetString("TextLuongAn");
            if (dr.GetString("TextBenhLy") != null) _TextBenhLy = dr.GetString("TextBenhLy");
            if (dr.GetString("TextMucDoTTDDBMI") != null) _TextMucDoTTDDBMI = dr.GetString("TextMucDoTTDDBMI");
            if (dr.GetString("TextMucDoTTDDChieuCaoTuoi") != null) _TextMucDoTTDDChieuCaoTuoi = dr.GetString("TextMucDoTTDDChieuCaoTuoi");
            if (dr.GetString("TextMucDoTTDDCanNangTuoi") != null) _TextMucDoTTDDCanNangTuoi = dr.GetString("TextMucDoTTDDCanNangTuoi");
            if (dr.GetString("TextMucDoTTDDCanNangChieuCao") != null) _TextMucDoTTDDCanNangChieuCao = dr.GetString("TextMucDoTTDDCanNangChieuCao");
            if (dr.GetString("TextMucDoTTDDAlbumin") != null) _TextMucDoTTDDAlbumin = dr.GetString("TextMucDoTTDDAlbumin");
            if (dr.GetString("TextMucDoTTDDProtein") != null) _TextMucDoTTDDProtein = dr.GetString("TextMucDoTTDDProtein");
            if (dr.GetString("TextKetLuanTTDD") != null) _TextKetLuanTTDD = dr.GetString("TextKetLuanTTDD");
            if (dr.GetString("TextDuongNuoiAn") != null) _TextDuongNuoiAn = dr.GetString("TextDuongNuoiAn");
            if (dr.GetString("TextTaiDanhGia") != null) _TextTaiDanhGia = dr.GetString("TextTaiDanhGia");
            if (dr.GetString("TextTocDoTangCan") != null) _TextTocDoTangCan = dr.GetString("TextTocDoTangCan");
            if (dr.GetSmartDate("CSTuNgay", true) != null) _CSTuNgay = dr.GetSmartDate("CSTuNgay", true);
            if (dr.GetSmartDate("CSDenNgay", true) != null) _CSDenNgay = dr.GetSmartDate("CSDenNgay", true);
            if (dr.GetSmartDate("NgayDG", true) != null) _NgayDG = dr.GetSmartDate("NgayDG", true);
            MarkOld();
        }
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
            
            _maBA = DataProvider.Instance().InsertBenhAn_DanhGiaTTDD(_maBA, _sTT, _sTTKhoa , _ChieuCao
           ,_CanNangTruoc
           ,_CanNangSau
           ,_ChuViVongCanhTay
           ,_Albumin
           ,_Protein
           ,_SutCan
           ,_LuongAn
           ,_BenhLy
           ,_DuongNuoiAn
           ,_HoiChanDD
           ,_TaiDanhGia
           ,_KQDGTTDDBMI
           ,_MucDoTTDDBMI
           ,_KQDGTTDDCanNangChieuCao
           ,_MucDoTTDDCanNangChieuCao
           ,_KQDGTTDDChieuCaoTuoi
           ,_MucDoTTDDChieuCaoTuoi
           ,_KQDGTTDDCanNangTuoi
           ,_MucDoTTDDCanNangTuoi
           ,_KQDGTTDDAlbumin
           ,_MucDoTTDDAlbumin
           ,_KQDGTTDDProtein
           ,_MucDoTTDDProtein
           ,_KetLuanTTDD
           ,_LanDanhGia
           ,_DeNghiCanThiep
           ,_TocDoTangCan, _bsDieuTri, _maMay, _nguoiSD, _maKhoa, _ghiChu ,_chanDoan,_MaCDAn, _CanNangTruocMangThai,_CSTuNgay,_CSDenNgay,_NgayDG);
			// public abstract String InsertBenhAn_DanhGiaTTDD(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap);
			// public override String InsertBenhAn_DanhGiaTTDD(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_DanhGiaTTDD_Create", _maBA, _sTT, _sTTKhoa, _maCPMau, _maBN, _ngayDK.DBValue, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _bSChiDinh, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT,_nguoiSD, _ngayTToan.DBValue, _daTra, _nguoiTra, _ngaytra.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _nguoiD, _nguoiP, _ngayD.DBValue,_maMay ,   _nguoiLap);
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAn_DanhGiaTTDD" /> Object to underlying database.
		/// </summary>
		internal void Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
            if (!this.IsDirty)
                return;
            
              
            DataProvider.Instance().UpdateBenhAn_DanhGiaTTDD(_maBA, _sTT, _sTTKhoa, _ChieuCao
           , _CanNangTruoc
           , _CanNangSau
           , _ChuViVongCanhTay
           , _Albumin
           , _Protein
           , _SutCan
           , _LuongAn
           , _BenhLy
           , _DuongNuoiAn
           , _HoiChanDD
           , _TaiDanhGia
           , _KQDGTTDDBMI
           , _MucDoTTDDBMI
           , _KQDGTTDDCanNangChieuCao
           , _MucDoTTDDCanNangChieuCao
           , _KQDGTTDDChieuCaoTuoi
           , _MucDoTTDDChieuCaoTuoi
           , _KQDGTTDDCanNangTuoi
           , _MucDoTTDDCanNangTuoi
           , _KQDGTTDDAlbumin
           , _MucDoTTDDAlbumin
           , _KQDGTTDDProtein
           , _MucDoTTDDProtein
           , _KetLuanTTDD
           , _LanDanhGia
           , _DeNghiCanThiep
           , _TocDoTangCan, _bsDieuTri, _maMay, _nguoiSD, _huy, _maKhoa, _ghiChu, _chanDoan, _MaCDAn, _CanNangTruocMangThai, _CSTuNgay, _CSDenNgay,_NgayDG);
				// public abstract void UpdateBenhAn_DanhGiaTTDD(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateBenhAn_DanhGiaTTDD(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_DanhGiaTTDD_Update", _maBA, _sTT, _sTTKhoa, _maCPMau, _maBN, _ngayDK.DBValue, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _bSChiDinh, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT,_nguoiSD, _ngayTToan.DBValue, _daTra, _nguoiTra, _ngaytra.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _nguoiD, _nguoiP, _ngayD.DBValue,_maMay ,   _huy, _nguoiSD);
				// }	
                MarkOld();
			
		}
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
           // _nguoiHuy = _nguoiHuy!=""?_nguoiHuy :  HTC.ShareVariables.pub_sNguoiSD;
            DataPortal_Delete(new OtherCriteria( _maBA, _sTT, _sTTKhoa,_maMay,_nguoiSD,_LanDanhGia));
            MarkNew();
        }

        private void DataPortal_Delete(OtherCriteria crit)
        {
            DataProvider.Instance().DeleteBenhAn_DanhGiaTTDD(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.STT, crit.STTKhoa, crit.LanDanhGia);
        }
		/// <summary>
		/// Delete the <see cref="BenhAn_DanhGiaTTDD" />.
		/// </summary>
        //protected void DataPortal_Delete(Criteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_DanhGiaTTDD
        //    DataProvider.Instance().DeleteBenhAn_DanhGiaTTDD(crit.MaBA, crit.STT, crit.STTKhoa);
        //    // public abstract void DeleteBenhAn_DanhGiaTTDD(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        //    // public override void DeleteBenhAn_DanhGiaTTDD(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_DanhGiaTTDD_Deleted", _maBA, _sTT, _sTTKhoa);
        //    // }
        //}

		#endregion
	}

}
