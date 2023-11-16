// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	KhamBenh_C
// Kieu doi tuong  :	KhamBenh_C
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	3/27/2009 9:48:09 PM
// Nguoi tao       :	BACHTX
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
using HTC.Business.CategoryList;

namespace HTC.Business.PhongKham
{

    /// <summary>
    /// This is a base generated class of <see cref="KhamBenh_C" /> Business Object.
    /// </summary>

    [Serializable()]
    public partial class KhamBenh_C : BusinessBase<KhamBenh_C>
    {
        #region Business Methods

        #region State Fields
        private String _machuyenkhoa = String.Empty;
        private byte _loai = 0;
        private String _maSoKham = String.Empty;
        private Int32 _sTT = 0;
        private String _maDV = String.Empty;
        private String _malh = String.Empty;
        private String _machungloai = String.Empty;
        private String _maDVTra = String.Empty;
        private String _maBN = String.Empty;
        private SmartDate _ngayDK = new SmartDate(true);
        private SmartDate _ngayhen = new SmartDate(true);
        private SmartDate _ngaydkd = new SmartDate(true);
        private Boolean _tToanSau = false;
        private String _soHD = String.Empty;
        private String _soSoHD = String.Empty;
        private String _soHDTra = String.Empty;
        private String _soSoHDTra = String.Empty;
        private String _kq = String.Empty;
        private Int32 _sophieu;
        private Decimal _soLuong = 0;
        private Decimal _slmua = 0;
        private Decimal _dongiaTT = 0;
        private Decimal _donGiaBH = 0;
        private Decimal _giaChenhLech = 0;
        private Decimal _thanhtien = 0;
        private Decimal _ck = 0;
        private Byte _daTT = 0;
        private String _ghichu = String.Empty;
        private SmartDate _ngayTToan = new SmartDate(true);
        private String _nguoiTT = String.Empty;
        private String _makhoa = String.Empty;
        private String _makhoaChoVV = String.Empty;
        private String _makhoaVV = String.Empty;
        private String _makhoacd = String.Empty;
        private String _tenkhoacd = String.Empty;
        private String _bschidinh = String.Empty;
        private String _tenkhoaChoVV = String.Empty;
        private String _tenbenh = String.Empty;
        private String _mabenh = String.Empty;
        private String _sophong = String.Empty;
        private Int32 _soTT = 0;
        private Int32 _soTTCu = 0;
        private String _bSKham = String.Empty;
        private String _maBS = String.Empty;
        private SmartDate _ngayGioKham = new SmartDate(true);
        private SmartDate _ngayGioVV = new SmartDate(true);
        private SmartDate _ngayKT = new SmartDate(true);
        private String _maHuongDT = "";
        private Boolean _tinhTien = false;
        private Boolean _bHTinhTien = false;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private Boolean _chon = false;
        private SmartDate _ngayHuy = new SmartDate(true);
        private String _nguoiHuy = String.Empty;
        private String _lyDoHuy = String.Empty;
        private SmartDate _ngayLap = new SmartDate(true);
        private String _nguoiLap = String.Empty;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private Byte _trangthai = 0;
        private String _loaihinh = String.Empty;
        private Boolean _daTra = false;
        private String _nguoiTra = String.Empty;
        private SmartDate _ngaytra = new SmartDate(true);
        private Decimal _sLTra = 0;
        private Decimal _sLTraCu = 0;
        private SmartDate _ngaySD1 = new SmartDate(true);
        private String _nguoiSD1 = String.Empty;

        private Decimal _tyGia = 0;
        private Boolean _aDGiaUSD = false;
        private Boolean _duan = false;
        private Byte _uuTien = 0;
        private Byte _TaiKham = 0;
        private String _TenTM = String.Empty;
        private String _tenkhoa = String.Empty;
        private String _tenbs = String.Empty;
        private String _tenbschidinh = String.Empty;
        private String _tenbs1 = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private String _tenNguoiTra = String.Empty;
        private String _tentat = String.Empty;
        private Boolean _NhapSL = false;
        private String _maicd = String.Empty;
        private String _DieuDuong = String.Empty;
        private String _DieuDuong1 = String.Empty;
        private String _tenDieuDuong = String.Empty;
        private String _tenDieuDuong1 = String.Empty;
        private Byte _daTTTT = 0;
        private SmartDate _ngayTToanTT = new SmartDate(true);
        private String _nguoiTTTT = String.Empty;
        private String _noiTTTT = String.Empty;
        private Byte _daTTBH = 0;
        private SmartDate _ngayTToanBH = new SmartDate(true);
        private String _nguoiTTBH = String.Empty;
        private String _noiTTBH = String.Empty;
        private String _maDT = String.Empty;
        private String _maicdKem = String.Empty;
        private String _tenbenhKem = String.Empty;
        private String _mabenhKem = String.Empty;
        private String _mabs3 = String.Empty;
        private String _mabs4 = String.Empty;
        private String _tenbs3 = String.Empty;
        private String _tenbs4 = String.Empty;
        private Boolean _DuyetBH = false;
        private Boolean _inthu = false;
        private String _tenBenhbd = String.Empty;
        private String _maicdKem2 = String.Empty;
        private String _tenbenhKem2 = String.Empty;
        private String _mabenhKem2 = String.Empty;
        private String _maicdKem3 = String.Empty;
        private String _tenbenhKem3 = String.Empty;
        private String _mabenhKem3 = String.Empty;
        private byte _LoaiDV = 0;
        #endregion

        #region Business Properties and Methods
        public String TenLoaiDV
        {
            get
            {
                CanReadProperty("TenLoaiDV", true);
                if (_LoaiDV == 0)
                    return "Nữ";
                else if (_LoaiDV == 1)
                    return "Nam";
                else
                    return "Tất cả";

            }

        }
        public byte LoaiDV
        {
            get
            {
                CanReadProperty(true);
                return _LoaiDV;
            }
            set
            {
                if (!LoaiDV.Equals(value))
                {
                    _LoaiDV = value;
                }
            }
        }
	
        public Boolean DuAn
        {
            get
            {
                CanReadProperty("DuAn", true);
                return _duan;
            }
            set
            {
                CanWriteProperty("DuAn", true);
                if (_duan != value)
                {
                    _duan = value;
                    PropertyHasChanged("DuAn");
                }
            }
        }

        public String TenBenhBD
        {
            get
            {
                CanReadProperty("TenBenhBD", true);
                return _tenBenhbd;
            }
            set
            {
                CanWriteProperty("TenBenhBD", true);
                if (_tenBenhbd != value)
                {
                    _tenBenhbd = value;
                    PropertyHasChanged("TenBenhBD");
                }
            }
        }
        public String malh
        {
            get
            {
                CanReadProperty("malh", true);
                return _malh;
            }
            set
            {
                CanWriteProperty("malh", true);
                if (_malh != value)
                {
                    _malh = value;
                    PropertyHasChanged("malh");
                }
            }
        }
        public String machungloai
        {
            get
            {
                CanReadProperty("machungloai", true);
                return _machungloai;
            }
            set
            {
                CanWriteProperty("machungloai", true);
                if (_machungloai != value)
                {
                    _machungloai = value;
                    PropertyHasChanged("machungloai");
                }
            }
        }
        public Boolean inthu
        {
            get
            {
                CanReadProperty("inthu", true);
                return _inthu;
            }
            set
            {
                CanWriteProperty("inthu", true);
                if (_inthu != value)
                {
                    _inthu = value;
                    PropertyHasChanged("inthu");
                }
            }
        }
        public Boolean DuyetBH
        {
            get
            {
                CanReadProperty("DuyetBH", true);
                return _DuyetBH;
            }
            set
            {
                CanWriteProperty("DuyetBH", true);
                if (_DuyetBH != value)
                {
                    _DuyetBH = value;
                    PropertyHasChanged("DuyetBH");
                }
            }
        }

        public String KQ
        {
            get
            {
                CanReadProperty("KQ", true);
                return _kq;
            }
            set
            {
                CanWriteProperty("KQ", true);
                if (_kq != value)
                {
                    _kq = value;
                    PropertyHasChanged("KQ");
                }
            }
        }

        public String tenbs3
        {
            get
            {
                CanReadProperty("tenbs3", true);
                return _tenbs3;
            }
            set
            {
                CanWriteProperty("tenbs31", true);
                if (_tenbs3 != value)
                {
                    _tenbs3 = value;
                    PropertyHasChanged("tenbs3");
                }
            }
        }
        public String Mabs3
        {
            get
            {
                CanReadProperty("Mabs3", true);
                return _mabs3;
            }
            set
            {
                CanWriteProperty("Mabs3", true);
                if (_mabs3 != value)
                {
                    _mabs3 = value;
                    PropertyHasChanged("Mabs3");
                }
            }
        }
        public String tenbs4
        {
            get
            {
                CanReadProperty("tenbs4", true);
                return _tenbs4;
            }
            set
            {
                CanWriteProperty("tenbs41", true);
                if (_tenbs4 != value)
                {
                    _tenbs4 = value;
                    PropertyHasChanged("tenbs4");
                }
            }
        }
        public String Mabs4
        {
            get
            {
                CanReadProperty("Mabs4", true);
                return _mabs4;
            }
            set
            {
                CanWriteProperty("Mabs4", true);
                if (_mabs4 != value)
                {
                    _mabs4 = value;
                    PropertyHasChanged("Mabs4");
                }
            }
        }
        public String Ghichu
        {
            get
            {
                CanReadProperty("Ghichu", true);
                return _ghichu;
            }
            set
            {
                CanWriteProperty("Ghichu", true);
                if (_ghichu != value)
                {
                    _ghichu = value;
                    PropertyHasChanged("Ghichu");
                }
            }
        }
        public String tenbenhKem
        {
            get
            {
                CanReadProperty("tenbenhKem", true);
                return _tenbenhKem;
            }
            set
            {
                CanWriteProperty("tenbenhKem", true);
                if (_tenbenhKem != value)
                {
                    _tenbenhKem = value;
                    PropertyHasChanged("tenbenhKem");
                }
            }
        }
        public String maicdKem
        {
            get
            {
                CanReadProperty("maicdKem", true);
                return _maicdKem;
            }
            set
            {
                CanWriteProperty("maicdKem", true);
                if (_maicdKem != value)
                {
                    _maicdKem = value;
                    PropertyHasChanged("maicdKem");
                }
            }
        }
        public String MabenhKem
        {
            get
            {
                CanReadProperty("MabenhKem", true);
                return _mabenhKem;
            }
            set
            {
                CanWriteProperty("MabenhKem", true);
                if (_mabenhKem != value)
                {
                    _mabenhKem = value;
                    PropertyHasChanged("MabenhKem");
                }
            }
        }

        public String tenbenhKem2
        {
            get
            {
                CanReadProperty("tenbenhKem2", true);
                return _tenbenhKem2;
            }
            set
            {
                CanWriteProperty("tenbenhKem2", true);
                if (_tenbenhKem2 != value)
                {
                    _tenbenhKem2 = value;
                    PropertyHasChanged("tenbenhKem2");
                }
            }
        }
        public String maicdKem2
        {
            get
            {
                CanReadProperty("maicdKem2", true);
                return _maicdKem2;
            }
            set
            {
                CanWriteProperty("maicdKem2", true);
                if (_maicdKem2 != value)
                {
                    _maicdKem2 = value;
                    PropertyHasChanged("maicdKem2");
                }
            }
        }
        public String MabenhKem2
        {
            get
            {
                CanReadProperty("MabenhKem2", true);
                return _mabenhKem2;
            }
            set
            {
                CanWriteProperty("MabenhKem2", true);
                if (_mabenhKem2 != value)
                {
                    _mabenhKem2 = value;
                    PropertyHasChanged("MabenhKem2");
                }
            }
        }

        public String tenbenhKem3
        {
            get
            {
                CanReadProperty("tenbenhKem3", true);
                return _tenbenhKem3;
            }
            set
            {
                CanWriteProperty("tenbenhKem3", true);
                if (_tenbenhKem3 != value)
                {
                    _tenbenhKem3 = value;
                    PropertyHasChanged("tenbenhKem3");
                }
            }
        }
        public String maicdKem3
        {
            get
            {
                CanReadProperty("maicdKem3", true);
                return _maicdKem3;
            }
            set
            {
                CanWriteProperty("maicdKem3", true);
                if (_maicdKem3 != value)
                {
                    _maicdKem3 = value;
                    PropertyHasChanged("maicdKem3");
                }
            }
        }
        public String MabenhKem3
        {
            get
            {
                CanReadProperty("MabenhKem3", true);
                return _mabenhKem3;
            }
            set
            {
                CanWriteProperty("MabenhKem3", true);
                if (_mabenhKem3 != value)
                {
                    _mabenhKem3 = value;
                    PropertyHasChanged("MabenhKem3");
                }
            }
        }
        //public String ngaydkd
        //{
        //    get
        //    {
        //        CanReadProperty("ngaydkd", true);
        //        _ngaydkd = _ngayDK;
        //        _ngaydkd.FormatString = "dd/MM/yyyy";
        //        return _ngaydkd.Text;
        //    }

        //}
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
        public String bschidinh
        {
            get
            {
                CanReadProperty("bschidinh", true);
                return _bschidinh;
            }
            set
            {
                CanWriteProperty("bschidinh", true);
                if (_bschidinh != value)
                {
                    _bschidinh = value;
                    PropertyHasChanged("bschidinh");
                }
            }
        }
        public String makhoacd
        {
            get
            {
                CanReadProperty("makhoacd", true);
                return _makhoacd;
            }
            set
            {
                CanWriteProperty("makhoacd", true);
                if (_makhoacd != value)
                {
                    _makhoacd = value;
                    PropertyHasChanged("makhoacd");
                }
            }
        }
        public String tenkhoacd
        {
            get
            {
                CanReadProperty("tenkhoacd", true);
                return _tenkhoacd;
            }
            set
            {
                CanWriteProperty("tenkhoacd", true);
                if (_tenkhoacd != value)
                {
                    _tenkhoacd = value;
                    PropertyHasChanged("tenkhoacd");
                }
            }
        }
        public String NguoiTTBH
        {
            get
            {
                CanReadProperty("NguoiTTBH", true);
                return _nguoiTTBH;
            }
            set
            {
                CanWriteProperty("NguoiTTBH", true);
                if (_nguoiTTBH != value)
                {
                    _nguoiTTBH = value;
                    PropertyHasChanged("NguoiTTBH");
                }
            }
        }
        public String NoiTTBH
        {
            get
            {
                CanReadProperty("NoiTTBH", true);
                return _noiTTBH;
            }
            set
            {
                CanWriteProperty("NoiTTBH", true);
                if (_noiTTBH != value)
                {
                    _noiTTBH = value;
                    PropertyHasChanged("NoiTTBH");
                }
            }
        }
        public Byte DaTTBH
        {
            get
            {
                CanReadProperty("DaTTBH", true);
                return _daTTBH;
            }
            set
            {
                CanWriteProperty("DaTTBH", true);
                if (_daTTBH != value)
                {
                    _daTTBH = value;
                    PropertyHasChanged("DaTTBH");
                }
            }
        }

        public string NgayTToanBH
        {
            get
            {
                CanReadProperty("NgayTToanBH", true);
                return _ngayTToanBH.Text;
            }
            set
            {
                CanWriteProperty("NgayTToanBH", true);
                if (_ngayTToanBH.Text != value)
                {
                    _ngayTToanBH.Text = value;
                    PropertyHasChanged("NgayTToanBH");
                }
            }
        }
        public String NguoiTTTT
        {
            get
            {
                CanReadProperty("NguoiTTTT", true);
                return _nguoiTTTT;
            }
            set
            {
                CanWriteProperty("NguoiTTTT", true);
                if (_nguoiTTTT != value)
                {
                    _nguoiTTTT = value;
                    PropertyHasChanged("NguoiTTTT");
                }
            }
        }
        public String NoiTTTT
        {
            get
            {
                CanReadProperty("NoiTTTT", true);
                return _noiTTTT;
            }
            set
            {
                CanWriteProperty("NoiTTTT", true);
                if (_noiTTTT != value)
                {
                    _noiTTTT = value;
                    PropertyHasChanged("NoiTTTT");
                }
            }
        }
        public String MaDT
        {
            get
            {
                CanReadProperty("MaDT", true);
                return _maDT;
            }
            set
            {
                CanWriteProperty("MaDT", true);
                if (_maDT != value)
                {
                    _maDT = value;
                    PropertyHasChanged("MaDT");
                }
            }
        }
        public Byte DaTTTT
        {
            get
            {
                CanReadProperty("DaTTTT", true);
                return _daTTTT;
            }
            set
            {
                CanWriteProperty("DaTTTT", true);
                if (_daTTTT != value)
                {
                    _daTTTT = value;
                    PropertyHasChanged("DaTTTT");
                }
            }
        }

        public string NgayTToanTT
        {
            get
            {
                CanReadProperty("NgayTToanTT", true);
                return _ngayTToanTT.Text;
            }
            set
            {
                CanWriteProperty("NgayTToanTT", true);
                if (_ngayTToanTT.Text != value)
                {
                    _ngayTToanTT.Text = value;
                    PropertyHasChanged("NgayTToanTT");
                }
            }
        }

        public string NgayGioVV
        {
            get
            {
                CanReadProperty("NgayGioVV", true);
                _ngayGioVV.FormatString = "MM/dd/yyyy HH:mm:ss";
                return _ngayGioVV.Text;
            }
            set
            {
                CanWriteProperty("NgayGioVV", true);
                if (_ngayGioVV.Text != value)
                {
                    _ngayGioVV.Text = value;
                    PropertyHasChanged("NgayGioVV");
                }
            }
        }
        public String tenbenh
        {
            get
            {
                CanReadProperty("tenbenh", true);
                return _tenbenh;
            }
            set
            {
                CanWriteProperty("tenbenh", true);
                if (_tenbenh != value)
                {
                    _tenbenh = value;
                    PropertyHasChanged("tenbenh");
                }
            }
        }
        public String DieuDuong
        {
            get
            {
                CanReadProperty("DieuDuong", true);
                return _DieuDuong;
            }
            set
            {
                CanWriteProperty("DieuDuong", true);
                if (_DieuDuong != value)
                {
                    _DieuDuong = value;
                    PropertyHasChanged("DieuDuong");
                }
            }
        }
        public String DieuDuong1
        {
            get
            {
                CanReadProperty("DieuDuong1", true);
                return _DieuDuong1;
            }
            set
            {
                CanWriteProperty("DieuDuong1", true);
                if (_DieuDuong1 != value)
                {
                    _DieuDuong1 = value;
                    PropertyHasChanged("DieuDuong1");
                }
            }
        }
        public String tenDieuDuong
        {
            get
            {
                CanReadProperty("tenDieuDuong", true);
                return _tenDieuDuong;
            }
            set
            {
                CanWriteProperty("tenDieuDuong", true);
                if (_tenDieuDuong != value)
                {
                    _tenDieuDuong = value;
                    PropertyHasChanged("tenDieuDuong");
                }
            }
        }
        public String tenDieuDuong1
        {
            get
            {
                CanReadProperty("tenDieuDuong1", true);
                return _tenDieuDuong1;
            }
            set
            {
                CanWriteProperty("tenDieuDuong1", true);
                if (_tenDieuDuong1 != value)
                {
                    _tenDieuDuong1 = value;
                    PropertyHasChanged("tenDieuDuong1");
                }
            }
        }
        public String maicd
        {
            get
            {
                CanReadProperty("maicd", true);
                return _maicd;
            }
            set
            {
                CanWriteProperty("maicd", true);
                if (_maicd != value)
                {
                    _maicd = value;
                    PropertyHasChanged("maicd");
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

        public String MakhoaVV
        {
            get
            {
                CanReadProperty("MakhoaVV", true);
                return _makhoaVV;
            }
            set
            {
                CanWriteProperty("MakhoaVV", true);
                if (_makhoaVV != value)
                {
                    _makhoaVV = value;
                    PropertyHasChanged("MakhoaVV");
                }
            }
        }
        public String MakhoaChoVV
        {
            get
            {
                CanReadProperty("MakhoaChoVV", true);
                return _makhoaChoVV;
            }
            set
            {
                CanWriteProperty("MakhoaChoVV", true);
                if (_makhoaChoVV != value)
                {
                    _makhoaChoVV = value;
                    PropertyHasChanged("MakhoaChoVV");
                }
            }
        }
        public String TenkhoaChoVV
        {
            get
            {
                CanReadProperty("TenkhoaChoVV", true);
                return _tenkhoaChoVV;
            }
            set
            {
                CanWriteProperty("TenkhoaChoVV", true);
                if (_tenkhoaChoVV != value)
                {
                    _tenkhoaChoVV = value;
                    PropertyHasChanged("TenkhoaChoVV");
                }
            }
        }
        public Boolean NhapSL
        {
            get
            {
                CanReadProperty("NhapSL", true);
                return _NhapSL;
            }
            set
            {
                CanWriteProperty("NhapSL", true);
                if (_NhapSL != value)
                {
                    _NhapSL = value;
                    PropertyHasChanged("NhapSL");
                }
            }
        }
        public String MaSoKham
        {
            get
            {
                CanReadProperty("MaSoKham", true);
                return _maSoKham;
            }
            set
            {
                CanWriteProperty("MaSoKham", true);
                if (_maSoKham != value)
                {
                    _maSoKham = value;
                    PropertyHasChanged("MaSoKham");
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
        public String MaDVTra
        {
            get
            {
                CanReadProperty("MaDVTra", true);
                return _maDVTra;
            }
            set
            {
                CanWriteProperty("MaDVTra", true);
                if (_maDVTra != value)
                {
                    _maDVTra = value;
                    PropertyHasChanged("MaDVTra");
                }
            }
        }
        public String MaDV
        {
            get
            {
                CanReadProperty("MaDV", true);
                return _maDV;
            }
            set
            {
                CanWriteProperty("MaDV", true);
                if (_maDV != value)
                {
                    _maDV = value;
                    PropertyHasChanged("MaDV");
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
        public String MaBN
        {
            get
            {
                CanReadProperty("MaBN", true);
                return _maBN;
            }
            set
            {
                CanWriteProperty("MaBN", true);
                if (_maBN != value)
                {
                    _maBN = value;
                    PropertyHasChanged("MaBN");
                }
            }
        }

        public string NgayDK
        {
            get
            {
                CanReadProperty("NgayDK", true);
                return _ngayDK.Text;
            }
            set
            {
                CanWriteProperty("NgayDK", true);
                if (_ngayDK.Text != value)
                {
                    _ngayDK.Text = value;
                    PropertyHasChanged("NgayDK");
                }
            }
        }

        //public string NgayDK
        //{
        //    get
        //    {
        //        CanReadProperty("NgayDK", true);
        //        _ngayDK.FormatString = "dd/MM/yyyy";
        //        return _ngayDK.Text;
        //    }
        //    set
        //    {
        //        CanWriteProperty("NgayDK", true);
        //        if (_ngayDK.Text != value)
        //        {
        //            _ngayDK.FormatString = "dd/MM/yyyy";
        //            _ngayDK.Text = value;
        //            PropertyHasChanged("NgayDK");
        //        }
        //    }
        //}
        public string ngayhen
        {
            get
            {
                CanReadProperty("ngayhen", true);
                return _ngayhen.Text;
            }
            set
            {
                CanWriteProperty("ngayhen", true);
                if (_ngayhen.Text != value)
                {
                    _ngayhen.Text = value;
                    PropertyHasChanged("ngayhen");
                }
            }
        }
        public Boolean TToanSau
        {
            get
            {
                CanReadProperty("TToanSau", true);
                return _tToanSau;
            }
            set
            {
                CanWriteProperty("TToanSau", true);
                if (_tToanSau != value)
                {
                    _tToanSau = value;
                    PropertyHasChanged("TToanSau");
                }
            }
        }

        public String SoHD
        {
            get
            {
                CanReadProperty("SoHD", true);
                return _soHD;
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

        public String SoSoHD
        {
            get
            {
                CanReadProperty("SoSoHD", true);
                return _soSoHD;
            }
            set
            {
                CanWriteProperty("SoSoHD", true);
                if (_soSoHD != value)
                {
                    _soSoHD = value;
                    PropertyHasChanged("SoSoHD");
                }
            }
        }
        public String SoHDTra
        {
            get
            {
                CanReadProperty("SoHDTra", true);
                return _soHDTra;
            }
            set
            {
                CanWriteProperty("SoHDTra", true);
                if (_soHDTra != value)
                {
                    _soHDTra = value;
                    PropertyHasChanged("SoHDTra");
                }
            }
        }

        public String SoSoHDTra
        {
            get
            {
                CanReadProperty("SoSoHDTra", true);
                return _soSoHDTra;
            }
            set
            {
                CanWriteProperty("SoSoHDTra", true);
                if (_soSoHDTra != value)
                {
                    _soSoHDTra = value;
                    PropertyHasChanged("SoSoHDTra");
                }
            }
        }
        public Int32 Sophieu
        {
            get
            {
                CanReadProperty("Sophieu", true);
                return _sophieu;
            }
            set
            {
                CanWriteProperty("Sophieu", true);
                if (_sophieu != value)
                {
                    _sophieu = value;
                    PropertyHasChanged("Sophieu");
                }
            }
        }

        public string SoLuong
        {
            get
            {
                CanReadProperty("SoLuong", true);
                if (_soLuong == 0)
                    return "0";
                else if (_soLuong - (int)(_soLuong) != 0)
                    return _soLuong.ToString("###,###.#");
                else
                    return _soLuong.ToString("###,###");
            }
            set
            {
                CanWriteProperty("SoLuong", true);
                if (_soLuong.ToString() != value)
                {
                    _soLuong = decimal.Parse(value);
                    PropertyHasChanged("SoLuong");
                }
            }
        }
        public string slmua
        {
            get
            {
                CanReadProperty("slmua", true);
                if (_slmua == 0)
                    return "0";
                else if (_slmua - (int)(_slmua) != 0)
                    return _slmua.ToString("###,###.#");
                else
                    return _slmua.ToString("###,###");
            }
            set
            {
                CanWriteProperty("slmua", true);
                if (_slmua.ToString() != value)
                {
                    _slmua = decimal.Parse(value);
                    PropertyHasChanged("slmua");
                }
            }
        }
        public string Dongia
        {
            get
            {
                CanReadProperty("Dongia", true);
                if (_dongiaTT == 0)
                    return "0";
                else
                    return _dongiaTT.ToString("###,###");
            }
            
        }
        public string DongiaTT
        {
            get
            {
                CanReadProperty("DongiaTT", true);
                if (_dongiaTT == 0)
                    return "0";
                else
                    return _dongiaTT.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DongiaTT", true);
                if (_dongiaTT.ToString() != value)
                {
                    _dongiaTT = decimal.Parse(value);
                    PropertyHasChanged("DongiaTT");
                }
            }
        }

        public string DonGiaBH
        {
            get
            {
                CanReadProperty("DonGiaBH", true);
                if (_donGiaBH == 0)
                    return "0";
                else
                    return _donGiaBH.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DonGiaBH", true);

                if (_donGiaBH.ToString() != value)
                {
                    _donGiaBH = decimal.Parse(value);
                    PropertyHasChanged("DonGiaBH");
                }
            }
        }

        public string GiaChenhLech
        {
            get
            {
                CanReadProperty("GiaChenhLech", true);
                if (_giaChenhLech == 0)
                    return "0";
                else
                    return _giaChenhLech.ToString("###,###");
            }
            set
            {
                CanWriteProperty("GiaChenhLech", true);
                if (_giaChenhLech.ToString() != value)
                {
                    _giaChenhLech = decimal.Parse(value);
                    PropertyHasChanged("GiaChenhLech");
                }
            }
        }

        public string CK
        {
            get
            {
                CanReadProperty("CK", true);
                if (_ck == 0)
                    return "0";
                else
                    return _ck.ToString("###,###");
            }
            set
            {
                CanWriteProperty("CK", true);
                if (_ck.ToString() != value)
                {

                    _ck = decimal.Parse(value);
                    PropertyHasChanged("CK");
                }
            }
        }

        public Byte DaTT
        {
            get
            {
                CanReadProperty("DaTT", true);
                return _daTT;
            }
            set
            {
                CanWriteProperty("DaTT", true);
                if (_daTT != value)
                {
                    _daTT = value;
                    PropertyHasChanged("DaTT");
                }
            }
        }

        public string NgayTToan
        {
            get
            {
                CanReadProperty("NgayTToan", true);
                return _ngayTToan.Text;
            }
            set
            {
                CanWriteProperty("NgayTToan", true);
                if (_ngayTToan.Text != value)
                {
                    _ngayTToan.Text = value;
                    PropertyHasChanged("NgayTToan");
                }
            }
        }

        public String Makhoa
        {
            get
            {
                CanReadProperty("Makhoa", true);
                return _makhoa;
            }
            set
            {
                CanWriteProperty("Makhoa", true);
                if (_makhoa != value)
                {
                    _makhoa = value;
                    PropertyHasChanged("Makhoa");
                }
            }
        }

        public String Sophong
        {
            get
            {
                CanReadProperty("Sophong", true);
                return _sophong;
            }
            set
            {
                CanWriteProperty("Sophong", true);
                if (_sophong != value)
                {
                    _sophong = value;
                    PropertyHasChanged("Sophong");
                }
            }
        }

        public Int32 SoTT
        {
            get
            {
                CanReadProperty("SoTT", true);
                return _soTT;
            }
            set
            {
                CanWriteProperty("SoTT", true);
                if (_soTT != value)
                {
                    _soTT = value;
                    PropertyHasChanged("SoTT");
                }
            }
        }

        public Int32 SoTTCu
        {
            get
            {
                CanReadProperty("SoTTCu", true);
                return _soTTCu;
            }
            set
            {
                CanWriteProperty("SoTTCu", true);
                if (_soTTCu != value)
                {
                    _soTTCu = value;
                    PropertyHasChanged("SoTTCu");
                }
            }
        }

        public String BSKham
        {
            get
            {
                CanReadProperty("BSKham", true);
                return _bSKham;
            }
            set
            {
                CanWriteProperty("BSKham", true);
                if (_bSKham != value)
                {
                    _bSKham = value;
                    PropertyHasChanged("BSKham");
                }
            }
        }

        public String MaBS
        {
            get
            {
                CanReadProperty("MaBS", true);
                return _maBS;
            }
            set
            {
                CanWriteProperty("MaBS", true);
                if (_maBS != value)
                {
                    _maBS = value;
                    PropertyHasChanged("MaBS");
                }
            }
        }

      public string NgayGioKham
       {
            get
            {
                CanReadProperty("NgayGioKham", true);
                _ngayGioKham.FormatString = "dd/MM/yyyy HH:mm";
                return _ngayGioKham.Text;
            }
            set
            {
                CanWriteProperty("NgayGioKham", true);
                if (_ngayGioKham.Text != value)
                {
                    _ngayGioKham.Text = value;
                    PropertyHasChanged("NgayGioKham");
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

        public String MaHuongDT
        {
            get
            {
                CanReadProperty("MaHuongDT", true);
                return _maHuongDT;
            }
            set
            {
                CanWriteProperty("MaHuongDT", true);
                if (_maHuongDT != value)
                {
                    _maHuongDT = value;
                    PropertyHasChanged("MaHuongDT");
                }
            }
        }

        public Boolean Tinhtien
        {
            get
            {
                CanReadProperty("TinhTien", true);
                return _tinhTien;
            }
            set
            {
                CanWriteProperty("TinhTien", true);
                if (_tinhTien != value)
                {
                    _tinhTien = value;
                    PropertyHasChanged("TinhTien");
                }
            }
        }

        public Boolean BHTinhtien
        {
            get
            {
                CanReadProperty("BHTinhTien", true);
                return _bHTinhTien;
            }
            set
            {
                CanWriteProperty("BHTinhTien", true);
                if (_bHTinhTien != value)
                {
                    _bHTinhTien = value;
                    PropertyHasChanged("BHTinhTien");
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
        public Boolean chon
        {
            get
            {
                CanReadProperty("chon", true);
                return _huy;
            }
            set
            {
                CanWriteProperty("chon", true);
                if (_huy != value)
                {
                    _huy = value;
                    PropertyHasChanged("chon");
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

        public string NgayHuy
        {
            get
            {
                CanReadProperty("NgayHuy", true);
                return _ngayHuy.Text;
            }
            set
            {
                CanWriteProperty("NgayHuy", true);
                if (_ngayHuy.Text != value)
                {
                    _ngayHuy.Text = value;
                    PropertyHasChanged("NgayHuy");
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

        public string NgayLap
        {
            get
            {
                CanReadProperty("NgayLap", true);
                _ngayLap.FormatString = "MM/dd/yyyy HH:mm";
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

        public Byte Trangthai
        {
            get
            {
                CanReadProperty("Trangthai", true);
                return _trangthai;
            }
            set
            {
                CanWriteProperty("Trangthai", true);
                if (_trangthai != value)
                {
                    _trangthai = value;
                    PropertyHasChanged("Trangthai");
                }
            }
        }

        public String loaihinh
        {
            get
            {
                CanReadProperty("loaihinh", true);
                return _loaihinh;
            }
            set
            {
                CanWriteProperty("loaihinh", true);
                if (_loaihinh != value)
                {
                    _loaihinh = value;
                    PropertyHasChanged("loaihinh");
                }
            }
        }

        public Boolean DaTra
        {
            get
            {
                CanReadProperty("DaTra", true);
                return _daTra;
            }
            set
            {
                CanWriteProperty("DaTra", true);
                if (_daTra != value)
                {
                    _daTra = value;
                    PropertyHasChanged("DaTra");
                }
            }
        }

        public String NguoiTra
        {
            get
            {
                CanReadProperty("NguoiTra", true);
                return _nguoiTra;
            }
            set
            {
                CanWriteProperty("NguoiTra", true);
                if (_nguoiTra != value)
                {
                    _nguoiTra = value;
                    PropertyHasChanged("NguoiTra");
                }
            }
        }

        public string Ngaytra
        {
            get
            {
                CanReadProperty("Ngaytra", true);
                return _ngaytra.Text;
            }
            set
            {
                CanWriteProperty("Ngaytra", true);
                if (_ngaytra.Text != value)
                {
                    _ngaytra.Text = value;
                    PropertyHasChanged("Ngaytra");
                }
            }
        }

        public string SLTra
        {
            get
            {
                CanReadProperty("SLTra", true);
                if (_sLTra == 0)
                    return "0";
                else if (_sLTra - (int)(_sLTra) != 0)
                    return _sLTra.ToString("###,###.#");
                else
                    return _sLTra.ToString("###,###");

            }
            set
            {
                CanWriteProperty("SLTra", true);
                if (_sLTra.ToString() != value)
                {
                    _sLTra = decimal.Parse(value);
                    PropertyHasChanged("SLTra");
                }
            }
        }
        public string SLTraCu
        {
            get
            {
                CanReadProperty("SLTraCu", true);
                if (_sLTraCu == 0)
                    return "0";
                else if (_sLTraCu - (int)(_sLTraCu) != 0)
                    return _sLTraCu.ToString("###,###.#");
                else
                    return _sLTraCu.ToString("###,###");

            }
            set
            {
                CanWriteProperty("SLTraCu", true);
                if (_sLTraCu.ToString() != value)
                {
                    _sLTraCu = decimal.Parse(value);
                    PropertyHasChanged("SLTraCu");
                }
            }
        }
        public string thanhtien
        {
            get
            {
                CanReadProperty("thanhtien", true);
                if ((_bHTinhTien != false) && (_tinhTien == false))
                {
                    _thanhtien = (_donGiaBH * (100 - _ck) * (_slmua - _sLTra)) / (100)
                    + _giaChenhLech * (100 - _ck) * (_slmua - _sLTra) / 100;
                }

                if ((_bHTinhTien == false) || (_tinhTien != false))
                    _thanhtien = _dongiaTT * (100 - _ck) * (_slmua - _sLTra) / 100;

                return _thanhtien.ToString("###,###");
            }
            set
            {
                CanWriteProperty("thanhtien", true);
                if (_thanhtien.ToString() != value)
                {
                    _thanhtien = decimal.Parse(value);
                    PropertyHasChanged("thanhtien");
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

        public String NguoiTT
        {
            get
            {
                CanReadProperty("NguoiTT", true);
                return _nguoiTT;
            }
            set
            {
                CanWriteProperty("NguoiTT", true);
                if (_nguoiTT != value)
                {
                    _nguoiTT = value;
                    PropertyHasChanged("NguoiTT");
                }
            }
        }

        public Decimal TyGia
        {
            get
            {
                CanReadProperty("TyGia", true);
                return _tyGia;
            }
            set
            {
                CanWriteProperty("TyGia", true);
                if (_tyGia != value)
                {
                    _tyGia = value;
                    PropertyHasChanged("TyGia");
                }
            }
        }

        public Boolean ADGiaUSD
        {
            get
            {
                CanReadProperty("ADGiaUSD", true);
                return _aDGiaUSD;
            }
            set
            {
                CanWriteProperty("ADGiaUSD", true);
                if (_aDGiaUSD != value)
                {
                    _aDGiaUSD = value;
                    PropertyHasChanged("ADGiaUSD");
                }
            }
        }

        public Byte UuTien
        {
            get
            {
                CanReadProperty("UuTien", true);
                return _uuTien;
            }
            set
            {
                CanWriteProperty("UuTien", true);
                if (_uuTien != value)
                {
                    _uuTien = value;
                    PropertyHasChanged("UuTien");
                }
            }
        }
        public Byte TaiKham
        {
            get
            {
                CanReadProperty("TaiKham", true);
                return _TaiKham;
            }
            set
            {
                CanWriteProperty("TaiKham", true);
                if (_TaiKham != value)
                {
                    _TaiKham = value;

                    PropertyHasChanged("TaiKham");
                }
            }
        }
        public String TenDV
        {
            get
            {
                CanReadProperty("TenTM", true);
                return _TenTM;
            }
           
        }
        public String TenTM
        {
            get
            {
                CanReadProperty("TenTM", true);
                return _TenTM;
            }
            set
            {
                CanWriteProperty("TenTM", true);
                if (_TenTM != value)
                {
                    _TenTM = value;
                    PropertyHasChanged("TenTM");
                }
            }
        }
        public String tenbschidinh
        {
            get
            {
                CanReadProperty("tenbschidinh", true);
                return _tenbschidinh;
            }
            set
            {
                CanWriteProperty("tenbschidinh", true);
                if (_tenbschidinh != value)
                {
                    _tenbschidinh = value;
                    PropertyHasChanged("tenbschidinh");
                }
            }
        }
        public String tenbs
        {
            get
            {
                CanReadProperty("tenbs", true);
                return _tenbs;
            }
            set
            {
                CanWriteProperty("tenbs", true);
                if (_tenbs != value)
                {
                    _tenbs = value;
                    PropertyHasChanged("tenbs");
                }
            }
        }
        public String tenbs1
        {
            get
            {
                CanReadProperty("tenbs1", true);
                return _tenbs1;
            }
            set
            {
                CanWriteProperty("tenbs1", true);
                if (_tenbs1 != value)
                {
                    _tenbs1 = value;
                    PropertyHasChanged("tenbs1");
                }
            }
        }
        public String TenNguoiLap
        {
            get
            {
                CanReadProperty("TenNguoiLap", true);
                return _tenNguoiLap;
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
        public String TenNguoiHuy
        {
            get
            {
                CanReadProperty("TenNguoiHuy", true);
                return _tenNguoiHuy;
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
        public String tenkhoa
        {
            get
            {
                CanReadProperty("tenkhoa", true);
                return _tenkhoa;
            }
            set
            {
                CanWriteProperty("tenkhoa", true);
                if (_tenkhoa != value)
                {
                    _tenkhoa = value;
                    PropertyHasChanged("tenkhoa");
                }
            }
        }

        public String tenNguoiTra
        {
            get
            {
                CanReadProperty("TenNguoiHuy", true);
                return _tenNguoiHuy;
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
        private KhamBenh_XNList _KhamBenh_XNList = KhamBenh_XNList.NewKhamBenh_XNList();

        public KhamBenh_XNList KhamBenh_XNList
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                if (_loai == 4 ||_loai ==6)
                    return _KhamBenh_XNList;
                else
                    return null;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_KhamBenh_XNList.Equals(value))
                {
                    _KhamBenh_XNList = value;
                    PropertyHasChanged();
                }
            }
        }
        //KhamBenh_TM_List _KhamBenh_TM_List = KhamBenh_TM_List.NewKhamBenh_TM_List();

        //public KhamBenh_TM_List KhamBenh_TM_List
        //{
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    get
        //    {
        //        //CanReadProperty(true);
        //        return _KhamBenh_TM_List;
        //    }
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    set
        //    {
        //        //CanWriteProperty(true);
        //        if (!_KhamBenh_TM_List.Equals(value))
        //        {
        //            _KhamBenh_TM_List = value;
        //            PropertyHasChanged();
        //        }
        //    }
        //}
        //KhamBenh_NoiList _KhamBenh_NoiList = KhamBenh_NoiList.NewKhamBenh_NoiList();

        //public KhamBenh_NoiList KhamBenh_NoiList
        //{
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    get
        //    {
        //        //CanReadProperty(true);
        //        if (_loai == 3 && HTC.ShareVariables.pub_spC !="PS")
        //            return _KhamBenh_NoiList;
        //        else
        //            return null;
        //    }
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    set
        //    {
        //        //CanWriteProperty(true);
        //        if (!_KhamBenh_NoiList.Equals(value))
        //        {
        //            _KhamBenh_NoiList = value;
        //            PropertyHasChanged();
        //        }
        //    }
        //}
        //KhamBenh_TMHList _KhamBenh_TMHList = KhamBenh_TMHList.NewKhamBenh_TMHList();

        //public KhamBenh_TMHList KhamBenh_TMHList
        //{
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    get
        //    {
        //        //CanReadProperty(true);
        //        return _KhamBenh_TMHList;
        //    }
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    set
        //    {
        //        //CanWriteProperty(true);
        //        if (!_KhamBenh_TMHList.Equals(value))
        //        {
        //            _KhamBenh_TMHList = value;
        //            PropertyHasChanged();
        //        }
        //    }
        //}

        //KhamBenh_RHMList _KhamBenh_RHMList = KhamBenh_RHMList.NewKhamBenh_RHMList();

        //public KhamBenh_RHMList KhamBenh_RHMList
        //{
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    get
        //    {
        //        //CanReadProperty(true);
        //        return _KhamBenh_RHMList;
        //    }
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    set
        //    {
        //        //CanWriteProperty(true);
        //        if (!_KhamBenh_RHMList.Equals(value))
        //        {
        //            _KhamBenh_RHMList = value;
        //            PropertyHasChanged();
        //        }
        //    }
        //}

        //KhamBenh_MatList _KhamBenh_MatList = KhamBenh_MatList.NewKhamBenh_MatList();

        //public KhamBenh_MatList KhamBenh_MatList
        //{
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    get
        //    {
        //        //CanReadProperty(true);
        //        return _KhamBenh_MatList;
        //    }
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    set
        //    {
        //        //CanWriteProperty(true);
        //        if (!_KhamBenh_MatList.Equals(value))
        //        {
        //            _KhamBenh_MatList = value;
        //            PropertyHasChanged();
        //        }
        //    }
        //}

        //KhamBenh_VLTLList _KhamBenh_VLTLList = KhamBenh_VLTLList.NewKhamBenh_VLTLList();

        //public KhamBenh_VLTLList KhamBenh_VLTLList
        //{
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    get
        //    {
        //        //CanReadProperty(true);
        //        return _KhamBenh_VLTLList;
        //    }
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    set
        //    {
        //        //CanWriteProperty(true);
        //        if (!_KhamBenh_VLTLList.Equals(value))
        //        {
        //            _KhamBenh_VLTLList = value;
        //            PropertyHasChanged();
        //        }
        //    }
        //}
        //KhamBenh_NgoaiList _KhamBenh_NgoaiList = KhamBenh_NgoaiList.NewKhamBenh_NgoaiList();

        //public KhamBenh_NgoaiList KhamBenh_NgoaiList
        //{
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    get
        //    {
        //        //CanReadProperty(true);
        //        return _KhamBenh_NgoaiList;
        //    }
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    set
        //    {
        //        //CanWriteProperty(true);
        //        if (!_KhamBenh_NgoaiList.Equals(value))
        //        {
        //            _KhamBenh_NgoaiList = value;
        //            PropertyHasChanged();
        //        }
        //    }
        //}
        ////KhamBenh_SanList _KhamBenh_SanList = KhamBenh_SanList.NewKhamBenh_SanList();

        ////public KhamBenh_SanList KhamBenh_SanList
        ////{
        ////    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        ////    get
        ////    {
        ////        //CanReadProperty(true);
        ////        return _KhamBenh_SanList;
        ////    }
        ////    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        ////    set
        ////    {
        ////        //CanWriteProperty(true);
        ////        if (!_KhamBenh_SanList.Equals(value))
        ////        {
        ////            _KhamBenh_SanList = value;
        ////            PropertyHasChanged();
        ////        }
        ////    }
        ////}
        //KhamBenh_SanPhuList _KhamBenh_SanPhuList = KhamBenh_SanPhuList.NewKhamBenh_SanPhuList();

        //public KhamBenh_SanPhuList KhamBenh_SanPhuList
        //{
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    get
        //    {
        //        //CanReadProperty(true);
        //        if (_loai == 3 && HTC .ShareVariables .pub_spC  == "PS" )
        //            return _KhamBenh_SanPhuList;
        //        else
        //            return null;
        //    }
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    set
        //    {
        //        //CanWriteProperty(true);
        //        if (!_KhamBenh_SanPhuList.Equals(value))
        //        {
        //            _KhamBenh_SanPhuList = value;
        //            PropertyHasChanged();
        //        }
        //    }
        //}
        //KhamBenh_SanSanCCList _KhamBenh_SanSanCCList = KhamBenh_SanSanCCList.NewKhamBenh_SanSanList();

        //public KhamBenh_SanSanCCList KhamBenh_SanSanCCList
        //{
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    get
        //    {
        //        //CanReadProperty(true);
        //        if (_loai == 3 && HTC.ShareVariables.pub_spC == "PS")
        //            return _KhamBenh_SanSanCCList;
        //        else
        //            return null;
        //    }
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    set
        //    {
        //        //CanWriteProperty(true);
        //        if (!_KhamBenh_SanSanCCList.Equals(value))
        //        {
        //            _KhamBenh_SanSanCCList = value;
        //            PropertyHasChanged();
        //        }
        //    }
        //}
        //KhamBenh_SanSanList _KhamBenh_SanSanList = KhamBenh_SanSanList.NewKhamBenh_SanSanList();

        //public KhamBenh_SanSanList KhamBenh_SanSanList
        //{
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    get
        //    {
        //        //CanReadProperty(true);
        //        if (_loai == 3 && HTC.ShareVariables.pub_spC == "PS")
        //            return _KhamBenh_SanSanList;
        //        else
        //            return null;
        //    }
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    set
        //    {
        //        //CanWriteProperty(true);
        //        if (!_KhamBenh_SanSanList.Equals(value))
        //        {
        //            _KhamBenh_SanSanList = value;
        //            PropertyHasChanged();
        //        }
        //    }
        //}

        //KhamBenh_NhiList _KhamBenh_NhiList = KhamBenh_NhiList.NewKhamBenh_NhiList();

        //public KhamBenh_NhiList KhamBenh_NhiList
        //{
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    get
        //    {
        //        //CanReadProperty(true);
        //        if (_loai == 3 && HTC.ShareVariables.pub_spC == "PS")
        //            return _KhamBenh_NhiList;
        //        else
        //            return null;
        //    }
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    set
        //    {
        //        //CanWriteProperty(true);
        //        if (!_KhamBenh_NhiList.Equals(value))
        //        {
        //            _KhamBenh_NhiList = value;
        //            PropertyHasChanged();
        //        }
        //    }
        //}

        //KhamBenh_VoSinhList _KhamBenh_VoSinhList = KhamBenh_VoSinhList.NewKhamBenh_VoSinhList();

        //public KhamBenh_VoSinhList KhamBenh_VoSinhList
        //{
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    get
        //    {
        //        //CanReadProperty(true);
        //        if (_loai == 3 && HTC.ShareVariables.pub_spC == "PS")
        //            return _KhamBenh_VoSinhList;
        //        else
        //            return null;
        //    }
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    set
        //    {
        //        //CanWriteProperty(true);
        //        if (!_KhamBenh_VoSinhList.Equals(value))
        //        {
        //            _KhamBenh_VoSinhList = value;
        //            PropertyHasChanged();
        //        }
        //    }
        //}

        //KhamBenh_CoXuongKhopList _KhamBenh_CoXuongKhopList = KhamBenh_CoXuongKhopList.NewKhamBenh_CoXuongKhopList();

        //public KhamBenh_CoXuongKhopList KhamBenh_CoXuongKhopList
        //{
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    get
        //    {
        //        //CanReadProperty(true);
        //        return _KhamBenh_CoXuongKhopList;
        //    }
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    set
        //    {
        //        //CanWriteProperty(true);
        //        if (!_KhamBenh_CoXuongKhopList.Equals(value))
        //        {
        //            _KhamBenh_CoXuongKhopList = value;
        //            PropertyHasChanged();
        //        }
        //    }
        //}
        //KhamBenh_DYList _KhamBenh_DYList = KhamBenh_DYList.NewKhamBenh_DYList();

        //public KhamBenh_DYList KhamBenh_DYList
        //{
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    get
        //    {
        //        //CanReadProperty(true);
        //        if (_loai == 3 && HTC.ShareVariables.pub_spC != "PS")
        //            return _KhamBenh_DYList;
        //        else
        //            return null;
        //    }
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    set
        //    {
        //        //CanWriteProperty(true);
        //        if (!_KhamBenh_DYList.Equals(value))
        //        {
        //            _KhamBenh_DYList = value;
        //            PropertyHasChanged();
        //        }
        //    }
        //}
        protected override Object GetIdValue()
        {
            return _maSoKham.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString();
        }

        public override bool IsDirty
        {
            get
            {
                //   return base.IsDirty || _KhamBenh_XNList.IsDirty || _KhamBenh_TM_List.IsDirty || _KhamBenh_NhiList.IsDirty || _KhamBenh_SanSanList.IsDirty || _KhamBenh_SanPhuList.IsDirty || _KhamBenh_VoSinhList.IsDirty || _KhamBenh_TMHList.IsDirty || _KhamBenh_RHMList.IsDirty || _KhamBenh_NoiList.IsDirty || _KhamBenh_VLTLList.IsDirty || _KhamBenh_MatList.IsDirty || _KhamBenh_SanList.IsDirty || _KhamBenh_CoXuongKhopList.IsDirty;
                if (_loai == 1 || _loai == 2 || _loai == 9)
                    return base.IsDirty;
                else if (_loai == 7 && HTC.ShareVariables.pub_spC == "YH")
                    return base.IsDirty;
                else if (_loai == 3)
                    return base.IsDirty;
                //else if (_loai == 3 && HTC .ShareVariables .pub_spC =="YH")
                //    return base.IsDirty || _KhamBenh_DYList.IsDirty  || _KhamBenh_NoiList.IsDirty || _KhamBenh_NhiList.IsDirty || _KhamBenh_SanSanList.IsDirty || _KhamBenh_SanPhuList.IsDirty || _KhamBenh_VoSinhList.IsDirty;
                //else if (_loai == 3 && HTC.ShareVariables.pub_spC == "PS")
                //    return base.IsDirty || _KhamBenh_NhiList.IsDirty || _KhamBenh_SanSanList.IsDirty || _KhamBenh_SanPhuList.IsDirty || _KhamBenh_VoSinhList.IsDirty || _KhamBenh_NgoaiList.IsDirty;
                //else if (_loai == 3)
                //    return base.IsDirty || _KhamBenh_TM_List.IsDirty || _KhamBenh_VLTLList.IsDirty || _KhamBenh_MatList.IsDirty || _KhamBenh_CoXuongKhopList.IsDirty || _KhamBenh_NgoaiList.IsDirty || _KhamBenh_TMHList.IsDirty || _KhamBenh_RHMList.IsDirty || _KhamBenh_DYList.IsDirty || _KhamBenh_NoiList.IsDirty || _KhamBenh_NhiList.IsDirty || _KhamBenh_SanSanList.IsDirty || _KhamBenh_SanPhuList.IsDirty || _KhamBenh_VoSinhList.IsDirty;
                else if (_loai == 4 || _loai == 6)
                    return base.IsDirty || _KhamBenh_XNList.IsDirty;
                else
                    return base.IsDirty ;//|| _KhamBenh_TM_List.IsDirty || _KhamBenh_VLTLList.IsDirty || _KhamBenh_MatList.IsDirty || _KhamBenh_CoXuongKhopList.IsDirty || _KhamBenh_NgoaiList.IsDirty || _KhamBenh_TMHList.IsDirty || _KhamBenh_RHMList.IsDirty || _KhamBenh_DYList.IsDirty || _KhamBenh_NoiList.IsDirty || _KhamBenh_NhiList.IsDirty || _KhamBenh_SanSanList.IsDirty || _KhamBenh_SanPhuList.IsDirty || _KhamBenh_VoSinhList.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                if (_loai == 1 || _loai == 2 || _loai == 9)
                    return base.IsValid;
                else if (_loai == 7 && HTC.ShareVariables.pub_spC == "YH")
                    return base.IsValid;
                else if (_loai == 3)
                    return base.IsValid;
                //else if (_loai == 3 && HTC.ShareVariables.pub_spC == "YH")
                //    return base.IsValid && _KhamBenh_DYList.IsValid && _KhamBenh_NoiList.IsValid;
                //else if (_loai == 3 && HTC.ShareVariables.pub_spC == "PS")
                //    return base.IsValid && _KhamBenh_NhiList.IsValid && _KhamBenh_SanSanList.IsValid && _KhamBenh_SanPhuList.IsValid && _KhamBenh_VoSinhList.IsValid  && _KhamBenh_SanSanCCList.IsValid;
                //else if (_loai == 3)
                //    return base.IsValid && _KhamBenh_TM_List.IsValid && _KhamBenh_VLTLList.IsValid && _KhamBenh_MatList.IsValid && _KhamBenh_CoXuongKhopList.IsValid && _KhamBenh_NgoaiList.IsValid && _KhamBenh_TMHList.IsValid && _KhamBenh_RHMList.IsValid && _KhamBenh_DYList.IsValid && _KhamBenh_NoiList.IsValid && _KhamBenh_NhiList.IsValid && _KhamBenh_SanSanList.IsValid && _KhamBenh_SanPhuList.IsValid && _KhamBenh_VoSinhList.IsDirty;
                else if (_loai == 4 || _loai == 6)
                    return base.IsValid && _KhamBenh_XNList.IsValid;

                else
                    return base.IsValid ;//&& _KhamBenh_TM_List.IsValid && _KhamBenh_VLTLList.IsValid && _KhamBenh_MatList.IsValid && _KhamBenh_CoXuongKhopList.IsValid && _KhamBenh_NgoaiList.IsValid && _KhamBenh_TMHList.IsValid && _KhamBenh_RHMList.IsValid && _KhamBenh_DYList.IsValid && _KhamBenh_NoiList.IsValid && _KhamBenh_NhiList.IsValid && _KhamBenh_SanSanList.IsValid && _KhamBenh_SanPhuList.IsValid && _KhamBenh_VoSinhList.IsDirty;
                // return base.IsValid && _KhamBenh_XNList.IsValid && _KhamBenh_NhiList.IsValid && _KhamBenh_VoSinhList.IsValid && _KhamBenh_SanSanList.IsValid && _KhamBenh_SanPhuList.IsValid && _KhamBenh_TM_List.IsValid && _KhamBenh_TMHList.IsValid && _KhamBenh_RHMList.IsValid && _KhamBenh_NoiList.IsValid && _KhamBenh_VLTLList.IsValid && _KhamBenh_MatList.IsValid && _KhamBenh_SanList.IsValid && _KhamBenh_CoXuongKhopList.IsValid;
            }
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation

        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="KhamBenh_C" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static KhamBenh_C NewKhamBenh_C()
        {
            return new KhamBenh_C();
        }
        public static KhamBenh_C NewKhamBenh_C(string idDMDichvu)
        {
            return new KhamBenh_C(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static KhamBenh_C NewKhamBenh_C(DMDichVu _DMDichvu)
        {
            return new KhamBenh_C(_DMDichvu);
        }
        public static KhamBenh_C GetKhamBenh_C(String maSoKham, Int32 sTT, Byte loai, byte loaikqcn)
        {
            return DataPortal.Fetch<KhamBenh_C>(new Criteria(maSoKham, sTT, loai, loaikqcn));
        }

        public static KhamBenh_C GetKhamBenh_C(SafeDataReader dr)
        {
            return new KhamBenh_C(dr);
        }
        public static KhamBenh_C GetKhamBenh_C(SafeDataReader dr, byte loai)
        {
            return new KhamBenh_C(dr, loai);
        }
        /// <summary>
        /// Marks the <see cref="KhamBenh_C" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteKhamBenh_C(String maSoKham, Int32 sTT, byte loai,string nguoihuy,string mamay)
        {
            DataPortal.Delete(new OtherCriteria(mamay  , nguoihuy , maSoKham, sTT, loai));
        }

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        protected internal KhamBenh_C()
        {
            // Prevent direct creation
            _slmua = 1;
            _soLuong = 1;
            _sLTra = 0;
            _ck = 0;
        }
        protected KhamBenh_C(DMDichVu pro)
        {
            MarkAsChild();

            //_maPhieu = dr.GetString("MaPhieu");
            _maDV = pro.MaDV;
            // _maMay = pro.MaMay;
            // _huy = pro.Huy;
            //// _ngaySD = pro.NgaySD ;
            // _nguoiSD = pro.NguoiSD;
            //     _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_C(string maSoKham, DMDichVu pro)
        {
            MarkAsChild();

            _maSoKham = maSoKham;
            _maDV = pro.MaDV;
            _maMay = pro.MaMay;
            _huy = pro.Huy;
            // _ngaySD = pro.NgaySD ;
            _nguoiSD = pro.NguoiSD;
            //  _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_C(SafeDataReader dr)
        {
            MarkAsChild();

            //_maSoKham = dr.GetString("MaSoKham");
            //_maDV = dr.GetString("MaDV");
            // _maMay = dr.GetString("MaMay");
            // _huy = dr.GetBoolean("Huy");
            // _ngaySD = dr.GetSmartDate("NgaySD",false);
            //_nguoiSD = dr.GetString("NguoiSD");
            //  _tenDV = dr.GetString("TenDV");
            //  _hoten = dr.GetString("Hoten");
            //_sTT = dr.GetInt32("STT");
            Fetch(dr);
            if ((dr.GetBoolean("BHTinhtien") != false) && (dr.GetBoolean("Tinhtien") == false))
            {
                _thanhtien = dr.GetDecimal("DongiaBH") * (100 - dr.GetDecimal("ck")) / 100 * (dr.GetDecimal("SLMua") - dr.GetDecimal("SLTra"))
                + dr.GetDecimal("giachenhlech") * (100 - dr.GetDecimal("ck")) / 100 * (dr.GetDecimal("SLMua") - dr.GetDecimal("SLTra"));
            }

            if ((dr.GetBoolean("BHTinhtien") == false) || (dr.GetBoolean("Tinhtien") != false))
                _thanhtien = dr.GetDecimal("DongiaTT") * (100 - dr.GetDecimal("ck")) / 100 * (dr.GetDecimal("SLMua") - dr.GetDecimal("SLTra"));

            MarkOld();
        }
        protected KhamBenh_C(SafeDataReader dr, byte loai)
        {
            MarkAsChild();

            //_maSoKham = dr.GetString("MaSoKham");
            //_maDV = dr.GetString("MaDV");
            // _maMay = dr.GetString("MaMay");
            // _huy = dr.GetBoolean("Huy");
            // _ngaySD = dr.GetSmartDate("NgaySD",false);
            //_nguoiSD = dr.GetString("NguoiSD");
            //  _tenDV = dr.GetString("TenDV");
            //  _hoten = dr.GetString("Hoten");
            //_sTT = dr.GetInt32("STT");
            Fetch(dr, loai);

            MarkOld();
        }
        #endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
            private String _maSoKham;
            public String MaSoKham
            {
                get
                {
                    return _maSoKham;
                }
            }

            private Int32 _sTT;
            public Int32 sTT
            {
                get
                {
                    return _sTT;
                }
            }
            private Byte _Loai;
            public Byte Loai
            {
                get
                {
                    return _Loai;
                }
            }
            private Byte _loaikqcn;
            public Byte loaikqcn
            {
                get
                {
                    return _loaikqcn;
                }
            }
            public Criteria(String maSoKham, Int32 sTT, Byte loai, byte loaikqcn)
            {
                _maSoKham = maSoKham;
                _sTT = sTT;
                _Loai = loai;
                _loaikqcn = loaikqcn;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maSoKham.Equals(c._maSoKham))
                        return false;
                    if (!_sTT.Equals(c._sTT))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maSoKham.ToString(), _sTT.ToString()).GetHashCode();
            }
        }

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maSoKham;
            public String maSoKham
            {
                get
                {
                    return _maSoKham;
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
            private Byte _Loai;
            public Byte Loai
            {
                get
                {
                    return _Loai;
                }
            }
            private Byte _loaikqcn;
            public Byte loaikqcn
            {
                get
                {
                    return _loaikqcn;
                }
            }
            public OtherCriteria(String Mamay, String Nguoisd, String maSoKham, Int32 sTT, Byte loai)
            {
                _maSoKham = maSoKham;
                _sTT = sTT;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _Loai = loai;
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
        /// Retrieve an existing <see cref="KhamBenh_C" /> Object based on data in the database.
        /// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetKhamBenh_C(String _maSoKham, Int32  _sTT);
            // public override IDataReader GetKhamBenh_C(String _maSoKham, Int32  _sTT)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maSoKham, _sTT));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKhamBenh_C(crit.MaSoKham, crit.sTT, crit.Loai)))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    //if (dr.NextResult())
                    //{
                    //    _KhamBenh_XNList = KhamBenh_XNList.GetKhamBenh_XNList(dr);
                    //}
                    //if (dr.NextResult())
                    //{
                    //    _KhamBenh_TM_List = KhamBenh_TM_List.GetKhamBenh_TM_List(dr);
                    //}
                    //MarkOld();
                    //ValidationRules.CheckRules();
                }
            }
        }
        /// <summary>
        /// Load a <see cref="KhamBenh_C" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("Machuyenkhoa") != null) _machuyenkhoa = dr.GetString("Machuyenkhoa");
            if (dr.GetString("MaSoKham") != null) _maSoKham = dr.GetString("MaSoKham");
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
            if(HTC .ShareVariables .pub_spC=="YH")
            if (dr.GetString("TenBenhbd") != null) _tenBenhbd = dr.GetString("TenBenhbd");
            if (dr.GetString("MaDVTra") != null) _maDVTra = dr.GetString("MaDVTra");
            if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
            if (dr.GetSmartDate("NgayDK", true) != null) _ngayDK = dr.GetSmartDate("NgayDK", true);
            if (dr.GetSmartDate("Ngayhen", true) != null) _ngayhen = dr.GetSmartDate("Ngayhen", true);
            if (dr.GetBoolean("TToanSau") != null) _tToanSau = dr.GetBoolean("TToanSau");
            if (dr.GetString("SoHDTra") != null) _soHDTra = dr.GetString("SoHDTra");
            if (dr.GetString("SoSoHDTra") != null) _soSoHDTra = dr.GetString("SoSoHDTra");
            if (dr.GetString("SoHD") != null) _soHD = dr.GetString("SoHD");
            if (dr.GetString("SoSoHD") != null) _soSoHD = dr.GetString("SoSoHD");
            if (dr.GetInt32("Sophieu") != null) _sophieu = dr.GetInt32("Sophieu");
            if (dr.GetDecimal("SoLuong") != null) _soLuong = dr.GetDecimal("SoLuong");
            if (dr.GetDecimal("Slmua") != null) _slmua = dr.GetDecimal("slmua");
            if (dr.GetDecimal("DongiaTT") != null) _dongiaTT = dr.GetDecimal("DongiaTT");
            if (dr.GetDecimal("DonGiaBH") != null) _donGiaBH = dr.GetDecimal("DonGiaBH");
            if (dr.GetDecimal("GiaChenhLech") != null) _giaChenhLech = dr.GetDecimal("GiaChenhLech");
            if (dr.GetDecimal("CK") != null) _ck = dr.GetDecimal("CK");
            if (dr.GetByte("DaTT") != null) _daTT = dr.GetByte("DaTT");
            if (dr.GetString("maicd") != null) _maicd = dr.GetString("maicd");
            if (dr.GetString("tenbenh") != null) _tenbenh = dr.GetString("tenbenh");//////////

            if (dr.GetSmartDate("NgayTToan", true) != null) _ngayTToan = dr.GetSmartDate("NgayTToan", true);
            if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
            if (dr.GetString("Sophong") != null) _sophong = dr.GetString("Sophong");
            if (dr.GetInt32("SoTT") != null) _soTT = dr.GetInt32("SoTT");
            if (dr.GetInt32("SoTTCu") != null) _soTTCu = dr.GetInt32("SoTTCu");
            if (dr.GetString("BSKham") != null) _bSKham = dr.GetString("BSKham");
            if (dr.GetString("MaBS") != null) _maBS = dr.GetString("MaBS");
            if (dr.GetSmartDate("NgayGioKham", true) != null) _ngayGioKham = dr.GetSmartDate("NgayGioKham", true);
            if (dr.GetSmartDate("NgayKT", true) != null) _ngayKT = dr.GetSmartDate("NgayKT", true);
            if (dr.GetString("MaHuongDT") != null) _maHuongDT = dr.GetString("MaHuongDT");
            if (dr.GetBoolean("Tinhtien") != null) _tinhTien = dr.GetBoolean("Tinhtien");
            if (dr.GetBoolean("BHTinhtien") != null) _bHTinhTien = dr.GetBoolean("BHTinhtien");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
            if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
            if (dr.GetString("LyDoHuy") != null) _lyDoHuy = dr.GetString("LyDoHuy");
            if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
            if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetByte("Trangthai") != null) _trangthai = dr.GetByte("Trangthai");
            if (dr.GetByte("TAIKHAM") != null) _TaiKham = dr.GetByte("TAIKHAM");
            if (dr.GetString("loaihinh") != null) _loaihinh = dr.GetString("loaihinh");
            if (dr.GetBoolean("DaTra") != null) _daTra = dr.GetBoolean("DaTra");
            if (dr.GetString("NguoiTra") != null) _nguoiTra = dr.GetString("NguoiTra");
            if (dr.GetSmartDate("Ngaytra", true) != null) _ngaytra = dr.GetSmartDate("Ngaytra", true);
            if (dr.GetDecimal("SLTra") != null) _sLTra = dr.GetDecimal("SLTra");
            if (dr.GetDecimal("SLTra") != null) _sLTraCu = dr.GetDecimal("SLTra");
            if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetSmartDate("ngayGioVV", true) != null) _ngayGioVV = dr.GetSmartDate("ngayGioVV", true);
            if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetString("NguoiTT") != null) _nguoiTT = dr.GetString("NguoiTT");
            if (dr.GetDecimal("TyGia") != null) _tyGia = dr.GetDecimal("TyGia");
            if (dr.GetBoolean("ADGiaUSD") != null) _aDGiaUSD = dr.GetBoolean("ADGiaUSD");
            if (dr.GetBoolean("NhapSL") != null) _NhapSL = dr.GetBoolean("NhapSL");
            if (dr.GetByte("taikham") != null) _TaiKham = dr.GetByte("taikham"); //+ int.Parse("4");
            //if (dr.GetByte("UuTien") >= 4) _TaiKham = dr.GetByte("UuTien"); //+ int.Parse("4");
            //if (dr.GetByte("UuTien") >= 4)  _TaiKham = ++_TaiKham;
            //if (dr.GetByte("UuTien") >= 4)  _TaiKham = ++_TaiKham;
            //if (dr.GetByte("UuTien") >= 4) _TaiKham = ++_TaiKham;
            if (dr.GetByte("UuTien") != null) _uuTien = dr.GetByte("UuTien");
            if (dr.GetString("TENdv") != null) _TenTM = dr.GetString("TENdv");
            if (dr.GetString("TENbs") != null) _tenbs = dr.GetString("TENbs");
            if (dr.GetString("TENbsCHIDINH") != null) _tenbschidinh = dr.GetString("TENbsCHIDINH");
            if (dr.GetString("TENbs1") != null) _tenbs1 = dr.GetString("TENbs1");
            if (dr.GetString("TENdieuduong") != null) _tenDieuDuong = dr.GetString("TENdieuduong");
            if (dr.GetString("TENdieuduong1") != null) _tenDieuDuong1 = dr.GetString("TENdieuduong1");
            if (dr.GetString("dieuduong") != null) _DieuDuong = dr.GetString("dieuduong");
            if (dr.GetString("dieuduong1") != null) _DieuDuong1 = dr.GetString("dieuduong1");
            if (dr.GetString("KQ") != null) _kq = dr.GetString("KQ");

            if (dr.GetString("TENbs1") != null) _tenbs1 = dr.GetString("TENbs1");
            if (dr.GetString("tenkhoa") != null) _tenkhoa = dr.GetString("TENkhoa");
            if (dr.GetString("tentat") != null) _tentat = dr.GetString("TENtat");
            if (dr.GetString("Mabenh") != null) _mabenh = dr.GetString("Mabenh");
            if (dr.GetString("maicdKem") != null) _maicdKem = dr.GetString("maicdKem");
            if (dr.GetString("tenbenhKem") != null) _tenbenhKem = dr.GetString("tenbenhKem");//////////
            if (dr.GetString("MabenhKem") != null) _mabenhKem = dr.GetString("MabenhKem");

            if (dr.GetString("maicdKem2") != null) _maicdKem2 = dr.GetString("maicdKem2");
            if (dr.GetString("tenbenhKem2") != null) _tenbenhKem2 = dr.GetString("tenbenhKem2");//////////
            if (dr.GetString("MabenhKem2") != null) _mabenhKem2 = dr.GetString("MabenhKem2");

            if (dr.GetString("maicdKem3") != null) _maicdKem3 = dr.GetString("maicdKem3");
            if (dr.GetString("tenbenhKem3") != null) _tenbenhKem3 = dr.GetString("tenbenhKem3");//////////
            if (dr.GetString("MabenhKem3") != null) _mabenhKem3 = dr.GetString("MabenhKem3");

            if (dr.GetString("MakhoachoVV") != null) _makhoaChoVV = dr.GetString("MakhoachoVV");
            if (dr.GetString("MakhoaVV") != null) _makhoaVV = dr.GetString("MakhoaVV");
            if (dr.GetString("bschidinh") != null) _bschidinh = dr.GetString("bschidinh");
            if (dr.GetString("makhoacd") != null) _makhoacd = dr.GetString("makhoacd");
            if (dr.GetString("NguoiTTBH") != null) _nguoiTTBH = dr.GetString("NguoiTTBH");
            if (dr.GetString("NoiTTBH") != null) _noiTTBH = dr.GetString("NoiTTBH");

            if (dr.GetByte("DaTTBH") != null) _daTTBH = dr.GetByte("DaTTBH");
            if (dr.GetSmartDate("NgayTToanBH", true) != null) _ngayTToanBH = dr.GetSmartDate("NgayTToanBH", true);

            if (dr.GetString("NguoiTTTT") != null) _nguoiTTTT = dr.GetString("NguoiTTTT");
            if (dr.GetString("NoiTTTT") != null) _noiTTTT = dr.GetString("NoiTTTT");
            if (dr.GetString("MADT") != null) _maDT = dr.GetString("MADT");
            if (_maDT == "70000")
                _duan = true;
            if (dr.GetByte("DaTTTT") != null) _daTTTT = dr.GetByte("DaTTTT");
            if (dr.GetSmartDate("NgayTToanTT", true) != null) _ngayTToanTT = dr.GetSmartDate("NgayTToanTT", true);
            if (dr.GetBoolean("duyetbh") != null) _DuyetBH = dr.GetBoolean("duyetbh");

            //if (dr.GetString("TENNGUOILAP") != null) _tenNguoiLap = dr.GetString("TENNGUOILAP");
            if (dr.GetString("TENNGUOISD") != null) _tenNguoiSD = dr.GetString("TENNGUOISD");
            //if (dr.GetString("TENNGUOIHUY") != null) _tenNguoiHuy = dr.GetString("TENNGUOIHUY");
            //if (dr.GetString("TENNGUOId") != null) _tenNguoiD = dr.GetString("TENNGUOId");
            //if (dr.GetString("TENNGUOIp") != null) _tenNguoiP = dr.GetString("TENNGUOIp");
            //if (dr.GetString("TENNGUOItra") != null) _tenNguoiTra = dr.GetString("TENNGUOItra");
          
          //  _KhamBenh_XNList = KhamBenh_XNList.GetKhamBenh_XNList(_maSoKham, _sTT);
             if ((_loai == 4 || _loai == 6)&&_maHuongDT !="")
            {
                _KhamBenh_XNList = KhamBenh_XNList.GetKhamBenh_XNList(_maSoKham, _sTT);
            }
            //else if (_loai == 3)
            //{
               
            //    if (_machuyenkhoa == "00000")
            //        _KhamBenh_NoiList = KhamBenh_NoiList.GetKhamBenh_NoiList(_maSoKham, _sTT);
            //    else if (_machuyenkhoa == "00001")
            //        _KhamBenh_NoiList = KhamBenh_NoiList.GetKhamBenh_NoiList(_maSoKham, _sTT);
            //   else if (_machuyenkhoa == "00004")
            //          _KhamBenh_TMHList = KhamBenh_TMHList.GetKhamBenh_TMHList(_maSoKham, _sTT);
            //    else if (_machuyenkhoa == "00006")
            //        _KhamBenh_RHMList = KhamBenh_RHMList.GetKhamBenh_RHMList(_maSoKham, _sTT);
            //    else if (_machuyenkhoa == "00005")
            //        _KhamBenh_MatList = KhamBenh_MatList.GetKhamBenh_MatList(_maSoKham, _sTT);
            //    else if (_machuyenkhoa == "00007")
            //        _KhamBenh_VLTLList = KhamBenh_VLTLList.GetKhamBenh_VLTLList(_maSoKham, _sTT);
            //    else if (_machuyenkhoa == "00003")
            //        _KhamBenh_TM_List = KhamBenh_TM_List.GetKhamBenh_TM_List(_maSoKham, _sTT);
            //    else if (_machuyenkhoa == "00002")
            //        _KhamBenh_NgoaiList = KhamBenh_NgoaiList.GetKhamBenh_NgoaiList(_maSoKham, _sTT);
            //    else if (_machuyenkhoa == "00010")
            //        _KhamBenh_CoXuongKhopList = KhamBenh_CoXuongKhopList.GetKhamBenh_CoXuongKhopList(_maSoKham, _sTT);
            //    else if (_machuyenkhoa == "00013")
            //         _KhamBenh_SanSanCCList = KhamBenh_SanSanCCList.GetKhamBenh_SanSanList(_maSoKham, _sTT);
            //    else if (_machuyenkhoa == "00014")
            //        _KhamBenh_SanPhuList = KhamBenh_SanPhuList.GetKhamBenh_SanPhuList(_maSoKham, _sTT);
            //    else if (_machuyenkhoa == "00026")
            //        _KhamBenh_SanSanList = KhamBenh_SanSanList.GetKhamBenh_SanSanList(_maSoKham, _sTT);
            //    else if (_machuyenkhoa == "00027")
            //        _KhamBenh_NhiList = KhamBenh_NhiList.GetKhamBenh_NhiList(_maSoKham, _sTT);
            //    else if (_machuyenkhoa == "00028")
            //        _KhamBenh_VoSinhList = KhamBenh_VoSinhList.GetKhamBenh_VoSinhList(_maSoKham, _sTT);
            //    else if (_machuyenkhoa == "00040" || _machuyenkhoa == "00041" || _machuyenkhoa == "00031" || _machuyenkhoa == "00032" || _machuyenkhoa == "00033" || _machuyenkhoa == "00034" || _machuyenkhoa == "00035" || _machuyenkhoa == "00036" || _machuyenkhoa == "00037" || _machuyenkhoa == "00038" || _machuyenkhoa == "00039")
            //        _KhamBenh_DYList = KhamBenh_DYList.GetKhamBenh_DYList(_maSoKham, _sTT);

            //    else
            //        _KhamBenh_NoiList = KhamBenh_NoiList.GetKhamBenh_NoiList(_maSoKham, _sTT);
           // }
        }
        private void Fetch(SafeDataReader dr, byte loai)
        {
            // Value properties
            _loai = loai;
            if (HTC.ShareVariables.pub_spC == "YH")
            if (dr.GetString("TenBenhbd") != null) _tenBenhbd = dr.GetString("TenBenhbd");
            if (dr.GetString("MaSoKham") != null) _maSoKham = dr.GetString("MaSoKham");
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetString("Machuyenkhoa") != null) _machuyenkhoa = dr.GetString("Machuyenkhoa");
            if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
            if (dr.GetString("MaDVTra") != null) _maDVTra = dr.GetString("MaDVTra");
            if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
            if (dr.GetSmartDate("NgayDK", true) != null) _ngayDK = dr.GetSmartDate("NgayDK", true);
            if (dr.GetSmartDate("ngayhen", true) != null) _ngayhen = dr.GetSmartDate("ngayhen", true);
            if (dr.GetBoolean("TToanSau") != null) _tToanSau = dr.GetBoolean("TToanSau");
            if (dr.GetString("SoHDTra") != null) _soHDTra = dr.GetString("SoHDTra");
            if (dr.GetString("SoSoHDTra") != null) _soSoHDTra = dr.GetString("SoSoHDTra");
            if (dr.GetString("SoHD") != null) _soHD = dr.GetString("SoHD");
            if (dr.GetString("SoSoHD") != null) _soSoHD = dr.GetString("SoSoHD");
            if (dr.GetInt32("Sophieu") != null) _sophieu = dr.GetInt32("Sophieu");
            if (dr.GetDecimal("SoLuong") != null) _soLuong = dr.GetDecimal("SoLuong");
            if (dr.GetString("KQ") != null) _kq = dr.GetString("KQ");

            if (dr.GetSmartDate("ngayGioVV", true) != null) _ngayGioVV = dr.GetSmartDate("ngayGioVV", true);
            if (dr.GetDecimal("Slmua") != null) _slmua = dr.GetDecimal("slmua");
            if (dr.GetDecimal("DongiaTT") != null) _dongiaTT = dr.GetDecimal("DongiaTT");
            if (dr.GetDecimal("DonGiaBH") != null) _donGiaBH = dr.GetDecimal("DonGiaBH");
            if (dr.GetDecimal("GiaChenhLech") != null) _giaChenhLech = dr.GetDecimal("GiaChenhLech");
            if (dr.GetDecimal("CK") != null) _ck = dr.GetDecimal("CK");
            if (dr.GetByte("DaTT") != null) _daTT = dr.GetByte("DaTT");
            if (dr.GetString("maicd") != null) _maicd = dr.GetString("maicd");
            if (dr.GetString("tenbenh") != null) _tenbenh = dr.GetString("tenbenh");//////////
            if (dr.GetSmartDate("NgayTToan", true) != null) _ngayTToan = dr.GetSmartDate("NgayTToan", true);
            if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
            if (dr.GetString("Sophong") != null) _sophong = dr.GetString("Sophong");
            if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
            if (dr.GetInt32("SoTT") != null) _soTT = dr.GetInt32("SoTT");
            if (dr.GetInt32("SoTTCu") != null) _soTTCu = dr.GetInt32("SoTTCu");
            if (dr.GetString("BSKham") != null) _bSKham = dr.GetString("BSKham");
            if (dr.GetString("MaBS") != null) _maBS = dr.GetString("MaBS");
            if (dr.GetString("bschidinh") != null) _bschidinh = dr.GetString("bschidinh");
            if (dr.GetString("makhoacd") != null) _makhoacd = dr.GetString("makhoacd");
            if (dr.GetSmartDate("NgayGioKham", true) != null) _ngayGioKham = dr.GetSmartDate("NgayGioKham", true);
            if (dr.GetSmartDate("NgayKT", true) != null) _ngayKT = dr.GetSmartDate("NgayKT", true);
            if (dr.GetString("MaHuongDT") != null) _maHuongDT = dr.GetString("MaHuongDT");
            if (dr.GetBoolean("Tinhtien") != null) _tinhTien = dr.GetBoolean("Tinhtien");
            if (dr.GetBoolean("BHTinhtien") != null) _bHTinhTien = dr.GetBoolean("BHTinhtien");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
           
            if (!(loai == 4))
            {
                 if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
                if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
                if (dr.GetString("LyDoHuy") != null) _lyDoHuy = dr.GetString("LyDoHuy");
                if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
                if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
                if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
                if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
                if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
                if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
                if (dr.GetString("NguoiTT") != null) _nguoiTT = dr.GetString("NguoiTT");
                if (dr.GetDecimal("TyGia") != null) _tyGia = dr.GetDecimal("TyGia");
                if (dr.GetBoolean("ADGiaUSD") != null) _aDGiaUSD = dr.GetBoolean("ADGiaUSD");
                if (dr.GetString("TENdieuduong") != null) _tenDieuDuong = dr.GetString("TENdieuduong");
                if (dr.GetString("TENdieuduong1") != null) _tenDieuDuong1 = dr.GetString("TENdieuduong1");
                if (dr.GetString("dieuduong") != null) _DieuDuong = dr.GetString("dieuduong");
                if (dr.GetString("dieuduong1") != null) _DieuDuong1 = dr.GetString("dieuduong1");
                if (dr.GetString("TENNGUOISD") != null) _tenNguoiSD = dr.GetString("TENNGUOISD");
            }
            else
            {
                if (dr.GetString("TENNGUOISD") != null) _tenNguoiSD = dr.GetString("TENNGUOISD");

                //if (dr.GetString("tenkhoacd") != null) _tenkhoacd = dr.GetString("tenkhoacd");
            }
            if (dr.GetByte("Trangthai") != null) _trangthai = dr.GetByte("Trangthai");
            if (dr.GetString("loaihinh") != null) _loaihinh = dr.GetString("loaihinh");
            if (dr.GetBoolean("DaTra") != null) _daTra = dr.GetBoolean("DaTra");
            if (dr.GetString("NguoiTra") != null) _nguoiTra = dr.GetString("NguoiTra");
            if (dr.GetSmartDate("Ngaytra", true) != null) _ngaytra = dr.GetSmartDate("Ngaytra", true);
            if (dr.GetDecimal("SLTra") != null) _sLTra = dr.GetDecimal("SLTra");
            if (dr.GetDecimal("SLTra") != null) _sLTraCu = dr.GetDecimal("SLTra");
         
            if (dr.GetBoolean("NhapSL") != null) _NhapSL = dr.GetBoolean("NhapSL");
            if (dr.GetByte("taikham") != null) _TaiKham = dr.GetByte("taikham"); //+ int.Parse("4");
            //if (dr.GetByte("UuTien") >= 4) _TaiKham = dr.GetByte("UuTien"); //+ int.Parse("4");
            //if (dr.GetByte("UuTien") >= 4) _TaiKham = ++_TaiKham;
            //if (dr.GetByte("UuTien") >= 4) _TaiKham = ++_TaiKham;
            //if (dr.GetByte("UuTien") >= 4) _TaiKham = ++_TaiKham;
            if (dr.GetByte("UuTien") != null) _uuTien = dr.GetByte("UuTien");
            if (dr.GetString("TENdv") != null) _TenTM = dr.GetString("TENdv");
            if (dr.GetString("TENbs") != null) _tenbs = dr.GetString("TENbs");
            if (dr.GetString("tentat") != null) _tentat = dr.GetString("TENtat");
            if (dr.GetString("Mabenh") != null) _mabenh = dr.GetString("Mabenh");
            if (dr.GetString("maicdKem") != null) _maicdKem = dr.GetString("maicdKem");
            if (dr.GetString("tenbenhKem") != null) _tenbenhKem = dr.GetString("tenbenhKem");//////////
            if (dr.GetString("MabenhKem") != null) _mabenhKem = dr.GetString("MabenhKem");

            if (dr.GetString("maicdKem2") != null) _maicdKem2 = dr.GetString("maicdKem2");
            if (dr.GetString("tenbenhKem2") != null) _tenbenhKem2 = dr.GetString("tenbenhKem2");//////////
            if (dr.GetString("MabenhKem2") != null) _mabenhKem2 = dr.GetString("MabenhKem2");

            if (dr.GetString("maicdKem3") != null) _maicdKem3 = dr.GetString("maicdKem3");
            if (dr.GetString("tenbenhKem3") != null) _tenbenhKem3 = dr.GetString("tenbenhKem3");//////////
            if (dr.GetString("MabenhKem3") != null) _mabenhKem3 = dr.GetString("MabenhKem3");

            if (dr.GetString("TENbsCHIDINH") != null) _tenbschidinh = dr.GetString("TENbsCHIDINH");

            if (dr.GetString("TENbs1") != null) _tenbs1 = dr.GetString("TENbs1");
            if (dr.GetString("tenkhoa") != null) _tenkhoa = dr.GetString("TENkhoa");
            if (dr.GetString("MakhoachoVV") != null) _makhoaChoVV = dr.GetString("MakhoachoVV");
            if (dr.GetString("MakhoaVV") != null) _makhoaVV = dr.GetString("MakhoaVV");
            //if (dr.GetString("TENNGUOILAP") != null) _tenNguoiLap = dr.GetString("TENNGUOILAP");
            //if (dr.GetString("TENNGUOISD") != null) _tenNguoiSD = dr.GetString("TENNGUOISD");
            //if (dr.GetString("TENNGUOIHUY") != null) _tenNguoiHuy = dr.GetString("TENNGUOIHUY");
            //if (dr.GetString("TENNGUOId") != null) _tenNguoiD = dr.GetString("TENNGUOId");
            //if (dr.GetString("TENNGUOIp") != null) _tenNguoiP = dr.GetString("TENNGUOIp");
            //if (dr.GetString("TENNGUOItra") != null) _tenNguoiTra = dr.GetString("TENNGUOItra");
            if (dr.GetString("NguoiTTBH") != null) _nguoiTTBH = dr.GetString("NguoiTTBH");
            if (dr.GetString("NoiTTBH") != null) _noiTTBH = dr.GetString("NoiTTBH");

            if (dr.GetByte("DaTTBH") != null) _daTTBH = dr.GetByte("DaTTBH");
            if (dr.GetSmartDate("NgayTToanBH", true) != null) _ngayTToanBH = dr.GetSmartDate("NgayTToanBH", true);

            if (dr.GetString("NguoiTTTT") != null) _nguoiTTTT = dr.GetString("NguoiTTTT");
            if (dr.GetString("NoiTTTT") != null) _noiTTTT = dr.GetString("NoiTTTT");
            if (dr.GetString("malh") != null) _malh = dr.GetString("malh");
            if (HTC .ShareVariables .pub_sTenBV == "BỆNH VIỆN ĐA KHOA MƯỜNG KHƯƠNG")
            if (dr.GetString("machungloai") != null) _machungloai = dr.GetString("machungloai");


            if (dr.GetByte("DaTTTT") != null) _daTTTT = dr.GetByte("DaTTTT");
            if (dr.GetSmartDate("NgayTToanTT", true) != null) _ngayTToanTT = dr.GetSmartDate("NgayTToanTT", true);
            if (dr.GetString("MADT") != null) _maDT = dr.GetString("MADT");
            if (dr.GetBoolean("duyetbh") != null) _DuyetBH = dr.GetBoolean("duyetbh");
            if (dr.GetBoolean("inthu") != null) _inthu = dr.GetBoolean("inthu");
            if (_maDT == "70000")
                _duan = true;
            if ((_loai == 4 || _loai == 6) && _maHuongDT != "")
            {
                _KhamBenh_XNList = KhamBenh_XNList.GetKhamBenh_XNList(_maSoKham, _sTT);
            }
            //else  if ((_loai == 3))
            //{
            //    if (_machuyenkhoa == "00000")
            //        _KhamBenh_NoiList = KhamBenh_NoiList.GetKhamBenh_NoiList(_maSoKham, _sTT);
            //       else if (_machuyenkhoa == "00001")
            //        _KhamBenh_NoiList = KhamBenh_NoiList.GetKhamBenh_NoiList(_maSoKham, _sTT);
            //   else if (_machuyenkhoa == "00004")
            //          _KhamBenh_TMHList = KhamBenh_TMHList.GetKhamBenh_TMHList(_maSoKham, _sTT);
            //    else if (_machuyenkhoa == "00006")
            //        _KhamBenh_RHMList = KhamBenh_RHMList.GetKhamBenh_RHMList(_maSoKham, _sTT);
            //    else if (_machuyenkhoa == "00005")
            //        _KhamBenh_MatList = KhamBenh_MatList.GetKhamBenh_MatList(_maSoKham, _sTT);
            //    else if (_machuyenkhoa == "00007")
            //        _KhamBenh_VLTLList = KhamBenh_VLTLList.GetKhamBenh_VLTLList(_maSoKham, _sTT);
            //    else if (_machuyenkhoa == "00003")
            //        _KhamBenh_TM_List = KhamBenh_TM_List.GetKhamBenh_TM_List(_maSoKham, _sTT);
            //    else if (_machuyenkhoa == "00002")
            //        _KhamBenh_NgoaiList = KhamBenh_NgoaiList.GetKhamBenh_NgoaiList(_maSoKham, _sTT);
            //    else if (_machuyenkhoa == "00010")
            //        _KhamBenh_CoXuongKhopList = KhamBenh_CoXuongKhopList.GetKhamBenh_CoXuongKhopList(_maSoKham, _sTT);               
            //    else if (_machuyenkhoa == "00013")
            //        _KhamBenh_SanSanCCList = KhamBenh_SanSanCCList.GetKhamBenh_SanSanList(_maSoKham, _sTT);
            //    else if (_machuyenkhoa == "00014")
            //        _KhamBenh_SanPhuList = KhamBenh_SanPhuList.GetKhamBenh_SanPhuList(_maSoKham, _sTT);
            //    else if (_machuyenkhoa == "00041" || _machuyenkhoa == "00040" || _machuyenkhoa == "00031" || _machuyenkhoa == "00032" || _machuyenkhoa == "00033" || _machuyenkhoa == "00034" || _machuyenkhoa == "00035" || _machuyenkhoa == "00036" || _machuyenkhoa == "00037" || _machuyenkhoa == "00038" || _machuyenkhoa == "00039")
            //        _KhamBenh_DYList = KhamBenh_DYList.GetKhamBenh_DYList(_maSoKham, _sTT);

            //    else if (_machuyenkhoa == "00026")
            //        _KhamBenh_SanSanList = KhamBenh_SanSanList.GetKhamBenh_SanSanList(_maSoKham, _sTT);
            //    else if (_machuyenkhoa == "00027")
            //        _KhamBenh_NhiList = KhamBenh_NhiList.GetKhamBenh_NhiList(_maSoKham, _sTT);
            //    else if (_machuyenkhoa == "00028")
            //        _KhamBenh_VoSinhList = KhamBenh_VoSinhList.GetKhamBenh_VoSinhList(_maSoKham, _sTT);

            //    else
            //        _KhamBenh_NoiList = KhamBenh_NoiList.GetKhamBenh_NoiList(_maSoKham, _sTT);

            //}
        }

        /// <summary>
        /// Insert the new <see cref="KhamBenh_C" /> Object to underlying database.
        /// </summary>
        /// 
        internal virtual void Insert(KhamBenh bill)
        {
            
            //_nguoiLap = _nguoiLap != "" ? _nguoiLap : HTC.ShareVariables.pub_sNguoiSD;
            if (_daTT != 0)
                _nguoiTT = _nguoiSD ;
            if (_TaiKham != 0)
                _uuTien = _TaiKham;
            else
                _uuTien = 0;
            if (bill.LoaiKham == 2)
                _uuTien = 3;

            _maBN = bill.MaBN;
            if ((_ngayDK == null) || (_ngayDK.DBValue.ToString() == "12:00 PM") || (_ngayDK.DBValue.ToString() == "01/01/0001 12:00 PM") || (_ngayDK.DBValue.ToString() == ""))
                _ngayDK = SmartDate.Parse(bill.NgayDK);
            if (_slmua != 0)
            {
                _maSoKham = bill.MaSoKham;
                _sTT = DataProvider.Instance().InsertKhamBenh_C(bill.MaSoKham, _sTT, _maDV, bill.MaBN, _ngayDK, _tToanSau, _soHD, _soSoHD, _sophieu, _soLuong, _slmua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _daTT, _ngayTToan, _makhoa, _sophong, _soTT, _soTTCu, _bSKham, _maBS, _ngayGioKham, _ngayKT, _maHuongDT, _tinhTien, _bHTinhTien, _maMay,_nguoiSD, _trangthai,_nguoiSD, _tyGia, _aDGiaUSD, _uuTien, _maDVTra, _mabenh, _makhoaChoVV, _makhoaVV, _daTTTT, _ngayTToanTT, _daTTBH, _ngayTToanBH, _noiTTTT, _noiTTBH, _nguoiTTTT, _nguoiTTBH, (_maDT == "" ? bill.MaDT : _maDT), _machuyenkhoa, _bschidinh, _makhoacd, _ngayhen, _ghichu, _tenbenh, _mabenhKem, _tenbenhKem,_mabenhKem2, _tenbenhKem2, _mabenhKem3, _tenbenhKem3);
                _maSoKham = bill.MaSoKham;
                MarkOld();
                if (bill.loai ==4||bill .loai ==6)
               _KhamBenh_XNList.Update(this);
                  
                //if (_machuyenkhoa == "00000")
                //    _KhamBenh_NoiList.Update(this);
                //else if (_machuyenkhoa == "00001")
                //    _KhamBenh_NoiList.Update(this);
                //else if (_machuyenkhoa == "00002")
                //    _KhamBenh_NgoaiList.Update(this);
                //else if (_machuyenkhoa == "00004")
                //      _KhamBenh_TMHList.Update(this);
                //else if (_machuyenkhoa == "00006")
                //    _KhamBenh_RHMList.Update(this);
                //else if (_machuyenkhoa == "00007")
                //    _KhamBenh_VLTLList.Update(this);
                //else if (_machuyenkhoa == "00005")
                //    _KhamBenh_MatList.Update(this);
                //else if (_machuyenkhoa == "00003")
                //    _KhamBenh_TMHList.Update(this);
                //else if (_machuyenkhoa == "00010")
                //    _KhamBenh_CoXuongKhopList.Update(this);
                //else if (_machuyenkhoa == "00013")
                //    _KhamBenh_SanSanCCList.Update (this) ;
                //else if (_machuyenkhoa == "00030" || _machuyenkhoa == "00031" || _machuyenkhoa == "00032" || _machuyenkhoa == "00033" || _machuyenkhoa == "00034" || _machuyenkhoa == "00035" || _machuyenkhoa == "00036" || _machuyenkhoa == "00037" || _machuyenkhoa == "00038" || _machuyenkhoa == "00039")
                //    _KhamBenh_DYList.Update(this);

                //else if (_machuyenkhoa == "00014")
                //    _KhamBenh_SanPhuList.Update(this);
                //else if (_machuyenkhoa == "00026")
                //    _KhamBenh_SanSanList.Update(this);
                //else if (_machuyenkhoa == "00027")
                //    _KhamBenh_NhiList.Update(this);
                //else if (_machuyenkhoa == "00028")
                //    _KhamBenh_VoSinhList.Update(this);

                //else
                //    _KhamBenh_NoiList.Update(this);

            }

            // public abstract String InsertKhamBenh_C(String _maSoKham, Int32  _sTT, String _maDV, String _maBN, SmartDate _ngayDK, Boolean _tToanSau, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _soLuong, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, Byte _daTT, SmartDate _ngayTToan, String _makhoa, String _sophong, Int32 _soTT, Int32 _soTTCu, String _bSKham, String _maBS, SmartDate _ngayGioKham, SmartDate _ngayKT, Byte _maHuongDT, Boolean _tinhtien, Boolean _bHTinhTien, String _maMay, SmartDate _ngayLap, String _nguoiLap,Byte _trangThai, String _nguoiTT, Decimal _tyGia, Boolean _aDGiaUSD);
            // public override String InsertKhamBenh_C(String _maSoKham, Int32  _sTT, String _maDV, String _maBN, SmartDate _ngayDK, Boolean _tToanSau, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _soLuong, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, Byte _daTT, SmartDate _ngayTToan, String _makhoa, String _sophong, Int32 _soTT, Int32 _soTTCu, String _bSKham, String _maBS, SmartDate _ngayGioKham, SmartDate _ngayKT, Byte _maHuongDT, Boolean _tinhtien, Boolean _bHTinhTien, String _maMay, SmartDate _ngayLap, String _nguoiLap,Byte _trangThai, String _nguoiTT, Decimal _tyGia, Boolean _aDGiaUSD)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_C_Create", _maSoKham, _sTT, _maDV, _maBN, _ngayDK.DBValue, _tToanSau, _soHD, _soSoHD, _sophieu, _soLuong, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _daTT, _ngayTToan.DBValue, _makhoa, _sophong, _soTT, _soTTCu, _bSKham, _maBS, _ngayGioKham.DBValue, _ngayKT.DBValue, _maHuongDT, _tinhTien, _bHTinhTien,_maMay ,  _ngayLap _nguoiLap,_trangThai,  _nguoiTT, _tyGia, _aDGiaUSD, ), String);
            // }
        }

        /// <summary>
        /// Update all changes made on <see cref="KhamBenh_C" /> Object to underlying database.
        /// </summary>
        /// 
        internal virtual void Update(KhamBenh bill)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_PhieuIn_C
            if (IsDirty)
            {
                if ((_TaiKham != 0) && (_daTT == 0))
                    _uuTien = _TaiKham;
                else if ((_daTT == 0))
                    _uuTien = 0;
                
                
                if ((_ngayDK == null) || (_ngayDK.DBValue.ToString() == "12:00 PM") || (_ngayDK.DBValue.ToString() == "01/01/0001 12:00 PM") || (_ngayDK.DBValue.ToString() == ""))
                    _ngayDK = SmartDate.Parse(bill.NgayDK);
                if ((bill.loai == 2 || bill.loai == 9) && (_slmua == 0 && _sLTra == 0))
                {
                    _daTTBH = 0;
                    _daTT = 0;
                    _daTTTT = 0;
                }


                if (((bill.loai != 2) && (bill.loai != 9)) || ((bill.loai == 2 || bill.loai == 9) && (_slmua != 0 || _sLTra != 0) && (_daTTBH != 0 || _daTTTT != 0 || _daTT != 0)))
                {
                    if (base.IsDirty)
                        _soTT = DataProvider.Instance().UpdateKhamBenh_C(bill.MaSoKham, _sTT, _maDV, _maBN, _ngayDK, _tToanSau, _soHD, _soSoHD, _sophieu, _soLuong, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _daTT, _ngayTToan, _makhoa, _sophong, _soTT, _soTTCu, _bSKham, _maBS, _ngayGioKham, _ngayKT, _maHuongDT, _tinhTien, _bHTinhTien, _maMay, _huy, _ngaySD, _nguoiSD, _trangthai, _loaihinh, _daTra, _nguoiTra, _ngaytra, _sLTra, _nguoiSD, _tyGia, _aDGiaUSD, _uuTien, _soHDTra, _soSoHDTra, _maDVTra, _mabenh, _makhoaChoVV, _makhoaVV, _slmua, _tenbenh, _daTTTT, _ngayTToanTT, _daTTBH, _ngayTToanBH, _noiTTTT, _noiTTBH, _nguoiTTTT, _nguoiTTBH, (_maDT == "" ? bill.MaDT : _maDT), _machuyenkhoa, _bschidinh, _makhoacd, _ngayhen, _mabenhKem, _tenbenhKem, _mabenhKem2, _tenbenhKem2, _mabenhKem3, _tenbenhKem3,  _ghichu, _mabs3, _mabs4, _kq, bill.loai);
                }
                if (bill.loai ==4||bill.loai ==6)
                    if (_KhamBenh_XNList.IsDirty)
                        _KhamBenh_XNList.Update(this);
                //if (bill.loai == 3)
                //{
                //    if (_machuyenkhoa == "00000")
                //        _KhamBenh_NoiList.Update(this);
                //    else if (_machuyenkhoa == "00001")
                //        _KhamBenh_NoiList.Update(this);
                //    else if (_machuyenkhoa == "00002")
                //        _KhamBenh_NgoaiList.Update(this);
                //    else if (_machuyenkhoa == "00004")
                //        _KhamBenh_TMHList.Update(this);
                //    else if (_machuyenkhoa == "00006")
                //        _KhamBenh_RHMList.Update(this);
                //    else if (_machuyenkhoa == "00007")
                //        _KhamBenh_VLTLList.Update(this);
                //    else if (_machuyenkhoa == "00005")
                //        _KhamBenh_MatList.Update(this);
                //    else if (_machuyenkhoa == "00003")
                //        _KhamBenh_TMHList.Update(this);
                //    else if (_machuyenkhoa == "00010")
                //        _KhamBenh_CoXuongKhopList.Update(this);
                //    else if (_machuyenkhoa == "00013")
                //        _KhamBenh_SanSanCCList.Update(this);
                //    else if (_machuyenkhoa == "00030" || _machuyenkhoa == "00031" || _machuyenkhoa == "00032" || _machuyenkhoa == "00033" || _machuyenkhoa == "00034" || _machuyenkhoa == "00035" || _machuyenkhoa == "00036" || _machuyenkhoa == "00037" || _machuyenkhoa == "00038" || _machuyenkhoa == "00039")
                //        _KhamBenh_DYList.Update(this);
                //    else if (_machuyenkhoa == "00014")
                //        _KhamBenh_SanPhuList.Update(this);
                //    else if (_machuyenkhoa == "00026")
                //        _KhamBenh_SanSanList.Update(this);
                //    else if (_machuyenkhoa == "00027")
                //        _KhamBenh_NhiList.Update(this);
                //    else if (_machuyenkhoa == "00028")
                //        _KhamBenh_VoSinhList.Update(this);
                //    else
                //        _KhamBenh_NoiList.Update(this);
                //}
                MarkOld();
            }
        }

        // public abstract void UpdateKhamBenh_C(String _maSoKham, Int32  _sTT, String _maDV, String _maBN, SmartDate _ngayDK, Boolean _tToanSau, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _soLuong, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, Byte _daTT, SmartDate _ngayTToan, String _makhoa, String _sophong, Int32 _soTT, Int32 _soTTCu, String _bSKham, String _maBS, SmartDate _ngayGioKham, SmartDate _ngayKT, Byte _maHuongDT, Boolean _tinhtien, Boolean _bHTinhTien, String _maMay, Boolean _huy, SmartDate _ngaySD, String _nguoiSD, Byte _trangthai, String _loaihinh, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, String _nguoiTT, Decimal _tyGia, Boolean _aDGiaUSD, Byte _uuTien);
        // public override void UpdateKhamBenh_C(String _maSoKham, Int32  _sTT, String _maDV, String _maBN, SmartDate _ngayDK, Boolean _tToanSau, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _soLuong, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, Byte _daTT, SmartDate _ngayTToan, String _makhoa, String _sophong, Int32 _soTT, Int32 _soTTCu, String _bSKham, String _maBS, SmartDate _ngayGioKham, SmartDate _ngayKT, Byte _maHuongDT, Boolean _tinhtien, Boolean _bHTinhTien, String _maMay, Boolean _huy, SmartDate _ngaySD, String _nguoiSD, Byte _trangthai, String _loaihinh, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, String _nguoiTT, Decimal _tyGia, Boolean _aDGiaUSD, Byte _uuTien)
        // {
        //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_C_Update", _maSoKham, _sTT, _maDV, _maBN, _ngayDK.DBValue, _tToanSau, _soHD, _soSoHD, _sophieu, _soLuong, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _daTT, _ngayTToan.DBValue, _makhoa, _sophong, _soTT, _soTTCu, _bSKham, _maBS, _ngayGioKham.DBValue, _ngayKT.DBValue, _maHuongDT, _tinhTien, _bHTinhTien,_maMay ,   _huy, _ngaySD.DBValue,_nguoiSD , _trangthai, _loaihinh, _daTra, _nguoiTra, _ngaytra.DBValue, _sLTra,_nguoiSD, _tyGia, _aDGiaUSD, _uuTien);
        // }				

        internal void DeleteSelf(KhamBenh bill)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;
            //_nguoiHuy = HTC.ShareVariables.pub_sNguoiSD;
            DataProvider.Instance().DeleteKhamBenh_C(_maMay,_nguoiSD, bill.MaSoKham, _sTT, _lyDoHuy);
            MarkNew();
        }



        #endregion
    }

}
