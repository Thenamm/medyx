


using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using HTC.Business;
//

namespace HTC.Business.KHTH
{
    [Serializable()]
    public partial class BC_THChuyenMon : BusinessBase<BC_THChuyenMon>
    {

        #region Business Methods

        #region State Fields
        private String _maBC = String.Empty;
        private SmartDate _tuNgay = new SmartDate(true);
        private SmartDate _denNgay = new SmartDate(true);
        private String _tieude = "";
       
        private Byte _loaiBC = 0;
        private Int32 _giuongKH = 0;
        private Int32 _giuongTT = 0;
        private Int32 _solanKham = 0;
        private Int32 _solanKham_KKB = 0;
        private Int32 _solanKham_PhuongXa = 0;
        private Int32 _solanKham_KhuVuc = 0;
        private Int32 _solanKham_DuPhong = 0;
        private Int32 _solanKhamCC = 0;
        private Int32 _solanKhamCC_DUOI6TUOI = 0;
        private Int32 _solanKhamCC_NGOAITINH = 0;
        private Int32 _solanKhamCC_BH = 0;
        private Int32 _solanKhamCC_YC = 0;
        private Int32 _solanKhamCC_NN = 0;
        private Int32 _solanKhamCC_MF = 0;
        private Int32 _solanKhamCC_TE = 0;
        private Int32 _songuoikham = 0;
        private Int32 _songuoikham_KKB = 0;
        private Int32 _songuoikham_NN = 0;
        private Int32 _songuoikham_DUOI6TUOI = 0;
        private Int32 _songuoikham_NBNgoaiTinh = 0;
        private Int32 _songuoiKham_PhuongXa = 0;
        private Int32 _songuoiKham_KhuVuc = 0;
        private Int32 _songuoiKham_DuPhong = 0;
        private Int32 _songuoiDTNgoaitru = 0;
        private Int32 _songayDTNgoaitru = 0;
        private Int32 _tainan = 0;
       
        private Int32 _tainanGiaothong = 0;
        private Int32 _tainanGiaothong_NBTuVong = 0;
        private Int32 _tainanGiaothong_PHAUTHUATCHANTHUONG = 0;
        private Int32 _tainanGiaothong_PHAUTHUATCHINHHINH = 0;
        
        private Int32 _tainanSinhhoat = 0;
        private Int32 _tainanLaodong = 0;
        private Int32 _phauThuat = 0;
        
        private Int32 _phauThuat_KH = 0;
        private Int32 _phauThuat_CC = 0;
        private Int32 _tHUTHUAT = 0;
       
        private Int32 _tHUTHUAT_KH = 0;
        private Int32 _tHUTHUAT_CC = 0;
        private Int32 _cHUYENVIEN = 0;
       
        private Int32 _cHUYENVIEN_NOITRU = 0;
        private Int32 _cHUYENVIEN_NGOAITRU = 0;
        private Int32 _tUVONG = 0;
        private Int32 _tUVONG_NGUOILON = 0;
        private Int32 _tUVONG_DUOI5TUOI = 0;
        private Int32 _tUVONG_TREN5TUOI = 0;
        private Int32 _tUVONG_NOITRU = 0;
        private Int32 _tUVONG_KKB = 0;
        private Int32 _cHETTRUOC24H = 0;
        private Int32 _cHETTRUOC24H_NGUOILON = 0;
        private Int32 _cHETTRUOC24H_DUOI5TUOI = 0;
        private Int32 _cHETTRUOC24H_TU5DEN15TUOI = 0;
        private Int32 _cHETTRUOC24H_NOITRU = 0;
        private Int32 _cHETTRUOC24H_KKB = 0;
        private Int32 _tIEUBANXETNGHIEM = 0;
        private Int32 _cHANDOANHINHANH = 0;
        private Int32 _chieuXQ = 0;
        private Int32 _chupXQ = 0;
        private Int32 _sIEUAM = 0;
        private Int32 _scanner = 0;
        private Int32 _xQKhac = 0;
        private Int32 _sIEUAMKHAC = 0;
        private Int32 _tHAMDOCHUCNANG = 0;
        private Int32 _dIENTIM = 0;
        private Int32 _dienNao = 0;
        private Int32 _noiSoi = 0;
        private Int32 _tDCNKhac = 0;
        private Int32 _sOBENHANDAKIEMTRA = 0;
        private Int32 _sONGUOIBENHDAUKY = 0;
        private Int32 _sONGUOIBENHVAOVIEN = 0;
        private Int32 _sONGUOIBENHVAOVIEN_BH = 0;
        private Int32 _sONGUOIBENHVAOVIEN_KHONGBH = 0;
        private Int32 _sONGUOIBENHVAOVIEN_NGUOINGHEO = 0;
        private Int32 _sONGUOIBENHVAOVIEN_DUOI6TUOI = 0;
        private Int32 _sONGUOIBENHVAOVIEN_6DEN15TUOI = 0;
        private Int32 _sONGUOIBENHVAOVIEN_NGOAITINH = 0;
        private Int32 _sONGUOIBENHRAVIEN = 0;
        private Int32 _sONGUOIBENHCONLAI = 0;
        private Int32 _sONGUOIBENHCONLAI_BH = 0;
        private Int32 _sONGUOIBENHCONLAI_KHONGBH = 0;
        private Int32 _sONGUOIBENHCONLAI_DUOI6TUOI = 0;
        private Int32 _sONGUOIBENHCONLAI_TU6DEN15TUOI = 0;
        private Int32 _tONGSONGAYDIEUTRI = 0;
        private Int32 _tONGSONGAYDIEUTRI_RAVIEN = 0;
        private Decimal _tONGGIUONG = 0;
        private Int32 _sXH_Cu = 0;
        private Int32 _sXH_Vao = 0;
        private Int32 _sXH_CVien = 0;
       
        private Int32 _sXH_Ra = 0;
        private Int32 _sXH_TVong = 0;
        private Int32 _sXH_HienCo = 0;
        private Int32 _sXH_TichLuy = 0;
        private Int32 _tCC_Cu = 0;
        private Int32 _tCC_Vao = 0;
        private Int32 _tCC_CVien = 0;
       
        private Int32 _tCC_Ra = 0;
        private Int32 _tCC_TVong = 0;
        private Int32 _tCC_HienCo = 0;
        private Int32 _tCC_TichLuy = 0;
        private Int32 _khac_Cu = 0;
        private Int32 _khac_Vao = 0;
        private Int32 _khac_CVien = 0;
       
        private Int32 _khac_Ra = 0;
        private Int32 _khac_TVong = 0;
        private Int32 _khac_HienCo = 0;
        private Int32 _khac_TichLuy = 0;
        private Int32 _khac_Cu1 = 0;
        private Int32 _khac_Vao1 = 0;
        private Int32 _khac_CVien1 = 0;
       
        private Int32 _khac_Ra1 = 0;
        private Int32 _khac_TVong1 = 0;
        private Int32 _khac_HienCo1 = 0;
        private Int32 _khac_TichLuy1 = 0;
        private Decimal _benhAnKT_Tot = 0;
        private Decimal _benhAnKT_Kha = 0;
        private Decimal _benhAnKT_TB = 0;
        private Decimal _benhAnKT_Kem = 0;
        private Decimal _donThuocKT_Tot = 0;
        private Decimal _donThuocKT_Kha = 0;
        private Decimal _donThuocKT_TB = 0;
        private Decimal _donThuocKT_Kem = 0;
        private String _tacHaiThuoc = String.Empty;
        private String _taiBien = String.Empty;
        private String _dacBiet = String.Empty;
        private String _cacHDCM = String.Empty;
        private String _deNghiSoYT = String.Empty;
        private String _ghiChu = String.Empty;
        private String _nguoiSD = String.Empty;
        private SmartDate _ngaySD = new SmartDate(true);
        private Boolean _huy = false;
        private String _maMay = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private int _OrderNumber;

        #endregion

        #region Business Properties and Methods
        public String MaBC
        {
            get
            {
                CanReadProperty("MaBC", true);
                return _maBC;
            }
            set
            {
                CanWriteProperty("MaBC", true);
                if (_maBC != value)
                {
                    _maBC = value;
                    PropertyHasChanged("MaBC");
                }
            }
        }
        public String tieude
        {
            get
            {
                CanReadProperty("tieude", true);
                if (_loaiBC == 0)
                    _tieude = "Báo cáo tuần từ" + _tuNgay.ToString("dd/MM/yyyy") + " đến " + _denNgay.ToString("dd/MM/yyyy");  
                else if (_loaiBC == 1)
                    _tieude = "Báo cáo tuần tháng" + _tuNgay.ToString("dd/MM/yyyy") + " đến " + _denNgay.ToString("dd/MM/yyyy");
                else if (_loaiBC == 2)
                    _tieude = "Báo cáo tuần quý" + _tuNgay.ToString("dd/MM/yyyy") + " đến " + _denNgay.ToString("dd/MM/yyyy");
                else if (_loaiBC == 3)
                    _tieude = "Báo cáo tuần năm" + _tuNgay.ToString("dd/MM/yyyy") + " đến " + _denNgay.ToString("dd/MM/yyyy");  
               
                return _tieude;
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

        public Byte LoaiBC
        {
            get
            {
                CanReadProperty("LoaiBC", true);
                return _loaiBC;
            }
            set
            {
                CanWriteProperty("LoaiBC", true);
                if (_loaiBC != value)
                {
                    _loaiBC = value;
                    PropertyHasChanged("LoaiBC");
                }
            }
        }

        public Int32 GiuongKH
        {
            get
            {
                CanReadProperty("GiuongKH", true);
                return _giuongKH;
            }
            set
            {
                CanWriteProperty("GiuongKH", true);
                if (_giuongKH != value)
                {
                    _giuongKH = value;
                    PropertyHasChanged("GiuongKH");
                }
            }
        }

        public Int32 GiuongTT
        {
            get
            {
                CanReadProperty("GiuongTT", true);
                return _giuongTT;
            }
            set
            {
                CanWriteProperty("GiuongTT", true);
                if (_giuongTT != value)
                {
                    _giuongTT = value;
                    PropertyHasChanged("GiuongTT");
                }
            }
        }
        public Int32 SolanKham
        {
            get
            {
                CanReadProperty("SolanKham", true);
                _solanKham = _solanKham_KKB + _solanKham_KhuVuc + _solanKham_PhuongXa; 
                return _solanKham;
            }
           
        }
        public Int32 SolanKham_KKB
        {
            get
            {
                CanReadProperty("SolanKham_KKB", true);
                return _solanKham_KKB;
            }
            set
            {
                CanWriteProperty("SolanKham_KKB", true);
                if (_solanKham_KKB != value)
                {
                    _solanKham_KKB = value;
                    PropertyHasChanged("SolanKham_KKB");
                }
            }
        }

        public Int32 SolanKham_PhuongXa
        {
            get
            {
                CanReadProperty("SolanKham_PhuongXa", true);
                return _solanKham_PhuongXa;
            }
            set
            {
                CanWriteProperty("SolanKham_PhuongXa", true);
                if (_solanKham_PhuongXa != value)
                {
                    _solanKham_PhuongXa = value;
                    PropertyHasChanged("SolanKham_PhuongXa");
                }
            }
        }

        public Int32 SolanKham_KhuVuc
        {
            get
            {
                CanReadProperty("SolanKham_KhuVuc", true);
                return _solanKham_KhuVuc;
            }
            set
            {
                CanWriteProperty("SolanKham_KhuVuc", true);
                if (_solanKham_KhuVuc != value)
                {
                    _solanKham_KhuVuc = value;
                    PropertyHasChanged("SolanKham_KhuVuc");
                }
            }
        }

        public Int32 SolanKham_DuPhong
        {
            get
            {
                CanReadProperty("SolanKham_DuPhong", true);
                return _solanKham_DuPhong;
            }
            set
            {
                CanWriteProperty("SolanKham_DuPhong", true);
                if (_solanKham_DuPhong != value)
                {
                    _solanKham_DuPhong = value;
                    PropertyHasChanged("SolanKham_DuPhong");
                }
            }
        }

        public Int32 SolanKhamCC
        {
            get
            {
                CanReadProperty("SolanKhamCC", true);
                return _solanKhamCC;
            }
            set
            {
                CanWriteProperty("SolanKhamCC", true);
                if (_solanKhamCC != value)
                {
                    _solanKhamCC = value;
                    PropertyHasChanged("SolanKhamCC");
                }
            }
        }

        public Int32 SolanKhamCC_DUOI6TUOI
        {
            get
            {
                CanReadProperty("SolanKhamCC_DUOI6TUOI", true);
                return _solanKhamCC_DUOI6TUOI;
            }
            set
            {
                CanWriteProperty("SolanKhamCC_DUOI6TUOI", true);
                if (_solanKhamCC_DUOI6TUOI != value)
                {
                    _solanKhamCC_DUOI6TUOI = value;
                    PropertyHasChanged("SolanKhamCC_DUOI6TUOI");
                }
            }
        }

        public Int32 SolanKhamCC_NGOAITINH
        {
            get
            {
                CanReadProperty("SolanKhamCC_NGOAITINH", true);
                return _solanKhamCC_NGOAITINH;
            }
            set
            {
                CanWriteProperty("SolanKhamCC_NGOAITINH", true);
                if (_solanKhamCC_NGOAITINH != value)
                {
                    _solanKhamCC_NGOAITINH = value;
                    PropertyHasChanged("SolanKhamCC_NGOAITINH");
                }
            }
        }

        public Int32 SolanKhamCC_BH
        {
            get
            {
                CanReadProperty("SolanKhamCC_BH", true);
                return _solanKhamCC_BH;
            }
            set
            {
                CanWriteProperty("SolanKhamCC_BH", true);
                if (_solanKhamCC_BH != value)
                {
                    _solanKhamCC_BH = value;
                    PropertyHasChanged("SolanKhamCC_BH");
                }
            }
        }

        public Int32 SolanKhamCC_YC
        {
            get
            {
                CanReadProperty("SolanKhamCC_YC", true);
                return _solanKhamCC_YC;
            }
            set
            {
                CanWriteProperty("SolanKhamCC_YC", true);
                if (_solanKhamCC_YC != value)
                {
                    _solanKhamCC_YC = value;
                    PropertyHasChanged("SolanKhamCC_YC");
                }
            }
        }

        public Int32 SolanKhamCC_NN
        {
            get
            {
                CanReadProperty("SolanKhamCC_NN", true);
                return _solanKhamCC_NN;
            }
            set
            {
                CanWriteProperty("SolanKhamCC_NN", true);
                if (_solanKhamCC_NN != value)
                {
                    _solanKhamCC_NN = value;
                    PropertyHasChanged("SolanKhamCC_NN");
                }
            }
        }

        public Int32 SolanKhamCC_MF
        {
            get
            {
                CanReadProperty("SolanKhamCC_MF", true);
                return _solanKhamCC_MF;
            }
            set
            {
                CanWriteProperty("SolanKhamCC_MF", true);
                if (_solanKhamCC_MF != value)
                {
                    _solanKhamCC_MF = value;
                    PropertyHasChanged("SolanKhamCC_MF");
                }
            }
        }

        public Int32 SolanKhamCC_TE
        {
            get
            {
                CanReadProperty("SolanKhamCC_TE", true);
                return _solanKhamCC_TE;
            }
            set
            {
                CanWriteProperty("SolanKhamCC_TE", true);
                if (_solanKhamCC_TE != value)
                {
                    _solanKhamCC_TE = value;
                    PropertyHasChanged("SolanKhamCC_TE");
                }
            }
        }
        public Int32 SonguoiKham
        {
            get
            {
                CanReadProperty("SonguoiKham", true);
                _songuoikham = _songuoikham_KKB + _songuoiKham_KhuVuc + _songuoiKham_PhuongXa;
                return _songuoikham;
            }

        }
        public Int32 Songuoikham_KKB
        {
            get
            {
                CanReadProperty("Songuoikham_KKB", true);
                return _songuoikham_KKB;
            }
            set
            {
                CanWriteProperty("Songuoikham_KKB", true);
                if (_songuoikham_KKB != value)
                {
                    _songuoikham_KKB = value;
                    PropertyHasChanged("Songuoikham_KKB");
                }
            }
        }

        public Int32 Songuoikham_NN
        {
            get
            {
                CanReadProperty("Songuoikham_NN", true);
                return _songuoikham_NN;
            }
            set
            {
                CanWriteProperty("Songuoikham_NN", true);
                if (_songuoikham_NN != value)
                {
                    _songuoikham_NN = value;
                    PropertyHasChanged("Songuoikham_NN");
                }
            }
        }

        public Int32 Songuoikham_DUOI6TUOI
        {
            get
            {
                CanReadProperty("Songuoikham_DUOI6TUOI", true);
                return _songuoikham_DUOI6TUOI;
            }
            set
            {
                CanWriteProperty("Songuoikham_DUOI6TUOI", true);
                if (_songuoikham_DUOI6TUOI != value)
                {
                    _songuoikham_DUOI6TUOI = value;
                    PropertyHasChanged("Songuoikham_DUOI6TUOI");
                }
            }
        }

        public Int32 Songuoikham_NBNgoaiTinh
        {
            get
            {
                CanReadProperty("Songuoikham_NBNgoaiTinh", true);
                return _songuoikham_NBNgoaiTinh;
            }
            set
            {
                CanWriteProperty("Songuoikham_NBNgoaiTinh", true);
                if (_songuoikham_NBNgoaiTinh != value)
                {
                    _songuoikham_NBNgoaiTinh = value;
                    PropertyHasChanged("Songuoikham_NBNgoaiTinh");
                }
            }
        }

        public Int32 SonguoiKham_PhuongXa
        {
            get
            {
                CanReadProperty("SonguoiKham_PhuongXa", true);
                return _songuoiKham_PhuongXa;
            }
            set
            {
                CanWriteProperty("SonguoiKham_PhuongXa", true);
                if (_songuoiKham_PhuongXa != value)
                {
                    _songuoiKham_PhuongXa = value;
                    PropertyHasChanged("SonguoiKham_PhuongXa");
                }
            }
        }

        public Int32 SonguoiKham_KhuVuc
        {
            get
            {
                CanReadProperty("SonguoiKham_KhuVuc", true);
                return _songuoiKham_KhuVuc;
            }
            set
            {
                CanWriteProperty("SonguoiKham_KhuVuc", true);
                if (_songuoiKham_KhuVuc != value)
                {
                    _songuoiKham_KhuVuc = value;
                    PropertyHasChanged("SonguoiKham_KhuVuc");
                }
            }
        }

        public Int32 SonguoiKham_DuPhong
        {
            get
            {
                CanReadProperty("SonguoiKham_DuPhong", true);
                return _songuoiKham_DuPhong;
            }
            set
            {
                CanWriteProperty("SonguoiKham_DuPhong", true);
                if (_songuoiKham_DuPhong != value)
                {
                    _songuoiKham_DuPhong = value;
                    PropertyHasChanged("SonguoiKham_DuPhong");
                }
            }
        }

        public Int32 SonguoiDTNgoaitru
        {
            get
            {
                CanReadProperty("SonguoiDTNgoaitru", true);
                return _songuoiDTNgoaitru;
            }
            set
            {
                CanWriteProperty("SonguoiDTNgoaitru", true);
                if (_songuoiDTNgoaitru != value)
                {
                    _songuoiDTNgoaitru = value;
                    PropertyHasChanged("SonguoiDTNgoaitru");
                }
            }
        }

        public Int32 SongayDTNgoaitru
        {
            get
            {
                CanReadProperty("SongayDTNgoaitru", true);
                return _songayDTNgoaitru;
            }
            set
            {
                CanWriteProperty("SongayDTNgoaitru", true);
                if (_songayDTNgoaitru != value)
                {
                    _songayDTNgoaitru = value;
                    PropertyHasChanged("SongayDTNgoaitru");
                }
            }
        }
        public Int32 Tainan
        {
            get
            {
                CanReadProperty("Tainan", true);
                _tainan = _tainanGiaothong + _tainanLaodong + _tainanSinhhoat;
                return _tainan;
            }
           
        }

        public Int32 TainanGiaothong
        {
            get
            {
                CanReadProperty("TainanGiaothong", true);
                return _tainanGiaothong;
            }
            set
            {
                CanWriteProperty("TainanGiaothong", true);
                if (_tainanGiaothong != value)
                {
                    _tainanGiaothong = value;
                    PropertyHasChanged("TainanGiaothong");
                }
            }
        }

        public Int32 TainanGiaothong_NBTuVong
        {
            get
            {
                CanReadProperty("TainanGiaothong_NBTuVong", true);
                return _tainanGiaothong_NBTuVong;
            }
            set
            {
                CanWriteProperty("TainanGiaothong_NBTuVong", true);
                if (_tainanGiaothong_NBTuVong != value)
                {
                    _tainanGiaothong_NBTuVong = value;
                    PropertyHasChanged("TainanGiaothong_NBTuVong");
                }
            }
        }

        public Int32 TainanGiaothong_PHAUTHUATCHANTHUONG
        {
            get
            {
                CanReadProperty("TainanGiaothong_PHAUTHUATCHANTHUONG", true);
                return _tainanGiaothong_PHAUTHUATCHANTHUONG;
            }
            set
            {
                CanWriteProperty("TainanGiaothong_PHAUTHUATCHANTHUONG", true);
                if (_tainanGiaothong_PHAUTHUATCHANTHUONG != value)
                {
                    _tainanGiaothong_PHAUTHUATCHANTHUONG = value;
                    PropertyHasChanged("TainanGiaothong_PHAUTHUATCHANTHUONG");
                }
            }
        }
        public Int32 TainanGiaothong_PHAUTHUATCHINHHINH
        {
            get
            {
                CanReadProperty("TainanGiaothong_PHAUTHUATCHINHHINH", true);
                return _tainanGiaothong_PHAUTHUATCHINHHINH;
            }
            set
            {
                CanWriteProperty("TainanGiaothong_PHAUTHUATCHINHHINH", true);
                if (_tainanGiaothong_PHAUTHUATCHINHHINH != value)
                {
                    _tainanGiaothong_PHAUTHUATCHINHHINH = value;
                    PropertyHasChanged("TainanGiaothong_PHAUTHUATCHINHHINH");
                }
            }
        }

        public Int32 TainanSinhhoat
        {
            get
            {
                CanReadProperty("TainanSinhhoat", true);
                return _tainanSinhhoat;
            }
            set
            {
                CanWriteProperty("TainanSinhhoat", true);
                if (_tainanSinhhoat != value)
                {
                    _tainanSinhhoat = value;
                    PropertyHasChanged("TainanSinhhoat");
                }
            }
        }

        public Int32 TainanLaodong
        {
            get
            {
                CanReadProperty("TainanLaodong", true);
                return _tainanLaodong;
            }
            set
            {
                CanWriteProperty("TainanLaodong", true);
                if (_tainanLaodong != value)
                {
                    _tainanLaodong = value;
                    PropertyHasChanged("TainanLaodong");
                }
            }
        }
        public Int32 PhauThuat
        {
            get
            {
                CanReadProperty("PhauThuat", true);
                _phauThuat = _phauThuat_CC + _phauThuat_KH;
                return _phauThuat;
            }
           
        }
        public Int32 PhauThuat_CC
        {
            get
            {
                CanReadProperty("PhauThuat_CC", true);
                return _phauThuat_CC;
            }
            set
            {
                CanWriteProperty("PhauThuat_CC", true);
                if (_phauThuat_CC != value)
                {
                    _phauThuat_CC = value;
                    PropertyHasChanged("PhauThuat_CC");
                }
            }
        }
     
        public Int32 PhauThuat_KH
        {
            get
            {
                CanReadProperty("PhauThuat_KH", true);
                return _phauThuat_KH;
            }
            set
            {
                CanWriteProperty("PhauThuat_KH", true);
                if (_phauThuat_KH != value)
                {
                    _phauThuat_KH = value;
                    PropertyHasChanged("PhauThuat_KH");
                }
            }
        }
        public Int32 THUTHUAT
        {
            get
            {
                CanReadProperty("THUTHUAT", true);
                _tHUTHUAT = _tHUTHUAT_CC + _tHUTHUAT_KH;
                return _tHUTHUAT;
            }
            
        }
        public Int32 THUTHUAT_KH
        {
            get
            {
                CanReadProperty("THUTHUAT_KH", true);
                return _tHUTHUAT_KH;
            }
            set
            {
                CanWriteProperty("THUTHUAT_KH", true);
                if (_tHUTHUAT_KH != value)
                {
                    _tHUTHUAT_KH = value;
                    PropertyHasChanged("THUTHUAT_KH");
                }
            }
        }

        public Int32 THUTHUAT_CC
        {
            get
            {
                CanReadProperty("THUTHUAT_CC", true);
                return _tHUTHUAT_CC;
            }
            set
            {
                CanWriteProperty("THUTHUAT_CC", true);
                if (_tHUTHUAT_CC != value)
                {
                    _tHUTHUAT_CC = value;
                    PropertyHasChanged("THUTHUAT_CC");
                }
            }
        }
        public Int32 CHUYENVIEN
        {
            get
            {
                CanReadProperty("CHUYENVIEN", true);
                _cHUYENVIEN = _cHUYENVIEN_NOITRU + _cHUYENVIEN_NGOAITRU;
                return _cHUYENVIEN;
            }
          
        }

        public Int32 CHUYENVIEN_NOITRU
        {
            get
            {
                CanReadProperty("CHUYENVIEN_NOITRU", true);
                return _cHUYENVIEN_NOITRU;
            }
            set
            {
                CanWriteProperty("CHUYENVIEN_NOITRU", true);
                if (_cHUYENVIEN_NOITRU != value)
                {
                    _cHUYENVIEN_NOITRU = value;
                    PropertyHasChanged("CHUYENVIEN_NOITRU");
                }
            }
        }

        public Int32 CHUYENVIEN_NGOAITRU
        {
            get
            {
                CanReadProperty("CHUYENVIEN_NGOAITRU", true);
                return _cHUYENVIEN_NGOAITRU;
            }
            set
            {
                CanWriteProperty("CHUYENVIEN_NGOAITRU", true);
                if (_cHUYENVIEN_NGOAITRU != value)
                {
                    _cHUYENVIEN_NGOAITRU = value;
                    PropertyHasChanged("CHUYENVIEN_NGOAITRU");
                }
            }
        }
        public Int32 TUVONG
        {
            get
            {
                CanReadProperty("TUVONG", true);
                _tUVONG = _tUVONG_DUOI5TUOI + _tUVONG_TREN5TUOI + _tUVONG_DUOI5TUOI;
                return _tUVONG;
            }
          
        }

        public Int32 TUVONG_NGUOILON
        {
            get
            {
                CanReadProperty("TUVONG_NGUOILON", true);
                return _tUVONG_NGUOILON;
            }
            set
            {
                CanWriteProperty("TUVONG_NGUOILON", true);
                if (_tUVONG_NGUOILON != value)
                {
                    _tUVONG_NGUOILON = value;
                    PropertyHasChanged("TUVONG_NGUOILON");
                }
            }
        }

        public Int32 TUVONG_DUOI5TUOI
        {
            get
            {
                CanReadProperty("TUVONG_DUOI5TUOI", true);
                return _tUVONG_DUOI5TUOI;
            }
            set
            {
                CanWriteProperty("TUVONG_DUOI5TUOI", true);
                if (_tUVONG_DUOI5TUOI != value)
                {
                    _tUVONG_DUOI5TUOI = value;
                    PropertyHasChanged("TUVONG_DUOI5TUOI");
                }
            }
        }

        public Int32 TUVONG_TREN5TUOI
        {
            get
            {
                CanReadProperty("TUVONG_TREN5TUOI", true);
                return _tUVONG_TREN5TUOI;
            }
            set
            {
                CanWriteProperty("TUVONG_TREN5TUOI", true);
                if (_tUVONG_TREN5TUOI != value)
                {
                    _tUVONG_TREN5TUOI = value;
                    PropertyHasChanged("TUVONG_TREN5TUOI");
                }
            }
        }

        public Int32 TUVONG_NOITRU
        {
            get
            {
                CanReadProperty("TUVONG_NOITRU", true);
                return _tUVONG_NOITRU;
            }
            set
            {
                CanWriteProperty("TUVONG_NOITRU", true);
                if (_tUVONG_NOITRU != value)
                {
                    _tUVONG_NOITRU = value;
                    PropertyHasChanged("TUVONG_NOITRU");
                }
            }
        }

        public Int32 TUVONG_KKB
        {
            get
            {
                CanReadProperty("TUVONG_KKB", true);
                _tUVONG_KKB = _tUVONG - _tUVONG_NOITRU;
                return _tUVONG_KKB;
            }
          
        }
        public Int32 CHETTRUOC24H
        {
            get
            {
                CanReadProperty("CHETTRUOC24H", true);
                _cHETTRUOC24H = _cHETTRUOC24H_DUOI5TUOI + _cHETTRUOC24H_NGUOILON + _cHETTRUOC24H_TU5DEN15TUOI;
                return _cHETTRUOC24H;
            }
           
        }

        public Int32 CHETTRUOC24H_NGUOILON
        {
            get
            {
                CanReadProperty("CHETTRUOC24H_NGUOILON", true);
                return _cHETTRUOC24H_NGUOILON;
            }
            set
            {
                CanWriteProperty("CHETTRUOC24H_NGUOILON", true);
                if (_cHETTRUOC24H_NGUOILON != value)
                {
                    _cHETTRUOC24H_NGUOILON = value;
                    PropertyHasChanged("CHETTRUOC24H_NGUOILON");
                }
            }
        }

        public Int32 CHETTRUOC24H_DUOI5TUOI
        {
            get
            {
                CanReadProperty("CHETTRUOC24H_DUOI5TUOI", true);
                return _cHETTRUOC24H_DUOI5TUOI;
            }
            set
            {
                CanWriteProperty("CHETTRUOC24H_DUOI5TUOI", true);
                if (_cHETTRUOC24H_DUOI5TUOI != value)
                {
                    _cHETTRUOC24H_DUOI5TUOI = value;
                    PropertyHasChanged("CHETTRUOC24H_DUOI5TUOI");
                }
            }
        }

        public Int32 CHETTRUOC24H_TU5DEN15TUOI
        {
            get
            {
                CanReadProperty("CHETTRUOC24H_TU5DEN15TUOI", true);
                return _cHETTRUOC24H_TU5DEN15TUOI;
            }
            set
            {
                CanWriteProperty("CHETTRUOC24H_TU5DEN15TUOI", true);
                if (_cHETTRUOC24H_TU5DEN15TUOI != value)
                {
                    _cHETTRUOC24H_TU5DEN15TUOI = value;
                    PropertyHasChanged("CHETTRUOC24H_TU5DEN15TUOI");
                }
            }
        }

        public Int32 CHETTRUOC24H_NOITRU
        {
            get
            {
                CanReadProperty("CHETTRUOC24H_NOITRU", true);
                return _cHETTRUOC24H_NOITRU;
            }
            set
            {
                CanWriteProperty("CHETTRUOC24H_NOITRU", true);
                if (_cHETTRUOC24H_NOITRU != value)
                {
                    _cHETTRUOC24H_NOITRU = value;
                    PropertyHasChanged("CHETTRUOC24H_NOITRU");
                }
            }
        }

        public Int32 CHETTRUOC24H_KKB
        {
            get
            {
                CanReadProperty("CHETTRUOC24H_KKB", true);
                _cHETTRUOC24H_KKB = _cHETTRUOC24H - _cHETTRUOC24H_NOITRU;
                return _cHETTRUOC24H_KKB;
            }
            
        }

        public Int32 TIEUBANXETNGHIEM
        {
            get
            {
                CanReadProperty("TIEUBANXETNGHIEM", true);
                return _tIEUBANXETNGHIEM;
            }
            set
            {
                CanWriteProperty("TIEUBANXETNGHIEM", true);
                if (_tIEUBANXETNGHIEM != value)
                {
                    _tIEUBANXETNGHIEM = value;
                    PropertyHasChanged("TIEUBANXETNGHIEM");
                }
            }
        }

        public Int32 CHANDOANHINHANH
        {
            get
            {
                CanReadProperty("CHANDOANHINHANH", true);
                _cHANDOANHINHANH = _chieuXQ + _chupXQ + _sIEUAM + _scanner + _xQKhac;
                return _cHANDOANHINHANH;
            }
            
        }

        public Int32 ChieuXQ
        {
            get
            {
                CanReadProperty("ChieuXQ", true);
                return _chieuXQ;
            }
            set
            {
                CanWriteProperty("ChieuXQ", true);
                if (_chieuXQ != value)
                {
                    _chieuXQ = value;
                    PropertyHasChanged("ChieuXQ");
                }
            }
        }

        public Int32 ChupXQ
        {
            get
            {
                CanReadProperty("ChupXQ", true);
                return _chupXQ;
            }
            set
            {
                CanWriteProperty("ChupXQ", true);
                if (_chupXQ != value)
                {
                    _chupXQ = value;
                    PropertyHasChanged("ChupXQ");
                }
            }
        }

        public Int32 SIEUAM
        {
            get
            {
                CanReadProperty("SIEUAM", true);
                return _sIEUAM;
            }
            set
            {
                CanWriteProperty("SIEUAM", true);
                if (_sIEUAM != value)
                {
                    _sIEUAM = value;
                    PropertyHasChanged("SIEUAM");
                }
            }
        }

        public Int32 Scanner
        {
            get
            {
                CanReadProperty("Scanner", true);
                return _scanner;
            }
            set
            {
                CanWriteProperty("Scanner", true);
                if (_scanner != value)
                {
                    _scanner = value;
                    PropertyHasChanged("Scanner");
                }
            }
        }

        public Int32 XQKhac
        {
            get
            {
                CanReadProperty("XQKhac", true);
                return _xQKhac;
            }
            set
            {
                CanWriteProperty("XQKhac", true);
                if (_xQKhac != value)
                {
                    _xQKhac = value;
                    PropertyHasChanged("XQKhac");
                }
            }
        }

        public Int32 SIEUAMKHAC
        {
            get
            {
                CanReadProperty("SIEUAMKHAC", true);
                return _sIEUAMKHAC;
            }
            set
            {
                CanWriteProperty("SIEUAMKHAC", true);
                if (_sIEUAMKHAC != value)
                {
                    _sIEUAMKHAC = value;
                    PropertyHasChanged("SIEUAMKHAC");
                }
            }
        }

        public Int32 THAMDOCHUCNANG
        {
            get
            {
                CanReadProperty("THAMDOCHUCNANG", true);
                _tHAMDOCHUCNANG = _dIENTIM + _dienNao + _noiSoi + _tDCNKhac;
                return _tHAMDOCHUCNANG;
            }
           
        }

        public Int32 DIENTIM
        {
            get
            {
                CanReadProperty("DIENTIM", true);
                return _dIENTIM;
            }
            set
            {
                CanWriteProperty("DIENTIM", true);
                if (_dIENTIM != value)
                {
                    _dIENTIM = value;
                    PropertyHasChanged("DIENTIM");
                }
            }
        }

        public Int32 DienNao
        {
            get
            {
                CanReadProperty("DienNao", true);
                return _dienNao;
            }
            set
            {
                CanWriteProperty("DienNao", true);
                if (_dienNao != value)
                {
                    _dienNao = value;
                    PropertyHasChanged("DienNao");
                }
            }
        }

        public Int32 NoiSoi
        {
            get
            {
                CanReadProperty("NoiSoi", true);
                return _noiSoi;
            }
            set
            {
                CanWriteProperty("NoiSoi", true);
                if (_noiSoi != value)
                {
                    _noiSoi = value;
                    PropertyHasChanged("NoiSoi");
                }
            }
        }

        public int TDCNKhac
        {
            get
            {
                CanReadProperty("TDCNKhac", true);
                return _tDCNKhac;
            }
            set
            {
                CanWriteProperty("TDCNKhac", true);
                if (_tDCNKhac != value)
                {
                    _tDCNKhac = value;
                    PropertyHasChanged("TDCNKhac");
                }
            }
        }

        public Int32 SOBENHANDAKIEMTRA
        {
            get
            {
                CanReadProperty("SOBENHANDAKIEMTRA", true);
                return _sOBENHANDAKIEMTRA;
            }
            set
            {
                CanWriteProperty("SOBENHANDAKIEMTRA", true);
                if (_sOBENHANDAKIEMTRA != value)
                {
                    _sOBENHANDAKIEMTRA = value;
                    PropertyHasChanged("SOBENHANDAKIEMTRA");
                }
            }
        }

        public Int32 SONGUOIBENHDAUKY
        {
            get
            {
                CanReadProperty("SONGUOIBENHDAUKY", true);
                return _sONGUOIBENHDAUKY;
            }
            set
            {
                CanWriteProperty("SONGUOIBENHDAUKY", true);
                if (_sONGUOIBENHDAUKY != value)
                {
                    _sONGUOIBENHDAUKY = value;
                    PropertyHasChanged("SONGUOIBENHDAUKY");
                }
            }
        }

        public Int32 SONGUOIBENHVAOVIEN
        {
            get
            {
                CanReadProperty("SONGUOIBENHVAOVIEN", true);
                _sONGUOIBENHVAOVIEN = _sONGUOIBENHVAOVIEN_BH + _sONGUOIBENHVAOVIEN_KHONGBH;
                return _sONGUOIBENHVAOVIEN;
            }
           
        }

        public Int32 SONGUOIBENHVAOVIEN_BH
        {
            get
            {
                CanReadProperty("SONGUOIBENHVAOVIEN_BH", true);
                return _sONGUOIBENHVAOVIEN_BH;
            }
            set
            {
                CanWriteProperty("SONGUOIBENHVAOVIEN_BH", true);
                if (_sONGUOIBENHVAOVIEN_BH != value)
                {
                    _sONGUOIBENHVAOVIEN_BH = value;
                    PropertyHasChanged("SONGUOIBENHVAOVIEN_BH");
                }
            }
        }

        public Int32 SONGUOIBENHVAOVIEN_KHONGBH
        {
            get
            {
                CanReadProperty("SONGUOIBENHVAOVIEN_KHONGBH", true);
                return _sONGUOIBENHVAOVIEN_KHONGBH;
            }
            set
            {
                CanWriteProperty("SONGUOIBENHVAOVIEN_KHONGBH", true);
                if (_sONGUOIBENHVAOVIEN_KHONGBH != value)
                {
                    _sONGUOIBENHVAOVIEN_KHONGBH = value;
                    PropertyHasChanged("SONGUOIBENHVAOVIEN_KHONGBH");
                }
            }
        }

        public Int32 SONGUOIBENHVAOVIEN_NGUOINGHEO
        {
            get
            {
                CanReadProperty("SONGUOIBENHVAOVIEN_NGUOINGHEO", true);
                return _sONGUOIBENHVAOVIEN_NGUOINGHEO;
            }
            set
            {
                CanWriteProperty("SONGUOIBENHVAOVIEN_NGUOINGHEO", true);
                if (_sONGUOIBENHVAOVIEN_NGUOINGHEO != value)
                {
                    _sONGUOIBENHVAOVIEN_NGUOINGHEO = value;
                    PropertyHasChanged("SONGUOIBENHVAOVIEN_NGUOINGHEO");
                }
            }
        }

        public Int32 SONGUOIBENHVAOVIEN_DUOI6TUOI
        {
            get
            {
                CanReadProperty("SONGUOIBENHVAOVIEN_DUOI6TUOI", true);
                return _sONGUOIBENHVAOVIEN_DUOI6TUOI;
            }
            set
            {
                CanWriteProperty("SONGUOIBENHVAOVIEN_DUOI6TUOI", true);
                if (_sONGUOIBENHVAOVIEN_DUOI6TUOI != value)
                {
                    _sONGUOIBENHVAOVIEN_DUOI6TUOI = value;
                    PropertyHasChanged("SONGUOIBENHVAOVIEN_DUOI6TUOI");
                }
            }
        }

        public Int32 SONGUOIBENHVAOVIEN_6DEN15TUOI
        {
            get
            {
                CanReadProperty("SONGUOIBENHVAOVIEN_6DEN15TUOI", true);
                return _sONGUOIBENHVAOVIEN_6DEN15TUOI;
            }
            set
            {
                CanWriteProperty("SONGUOIBENHVAOVIEN_6DEN15TUOI", true);
                if (_sONGUOIBENHVAOVIEN_6DEN15TUOI != value)
                {
                    _sONGUOIBENHVAOVIEN_6DEN15TUOI = value;
                    PropertyHasChanged("SONGUOIBENHVAOVIEN_6DEN15TUOI");
                }
            }
        }

        public Int32 SONGUOIBENHVAOVIEN_NGOAITINH
        {
            get
            {
                CanReadProperty("SONGUOIBENHVAOVIEN_NGOAITINH", true);
                return _sONGUOIBENHVAOVIEN_NGOAITINH;
            }
            set
            {
                CanWriteProperty("SONGUOIBENHVAOVIEN_NGOAITINH", true);
                if (_sONGUOIBENHVAOVIEN_NGOAITINH != value)
                {
                    _sONGUOIBENHVAOVIEN_NGOAITINH = value;
                    PropertyHasChanged("SONGUOIBENHVAOVIEN_NGOAITINH");
                }
            }
        }

        public Int32 SONGUOIBENHRAVIEN
        {
            get
            {
                CanReadProperty("SONGUOIBENHRAVIEN", true);
                return _sONGUOIBENHRAVIEN;
            }
            set
            {
                CanWriteProperty("SONGUOIBENHRAVIEN", true);
                if (_sONGUOIBENHRAVIEN != value)
                {
                    _sONGUOIBENHRAVIEN = value;
                    PropertyHasChanged("SONGUOIBENHRAVIEN");
                }
            }
        }

        public Int32 SONGUOIBENHCONLAI
        {
            get
            {
                CanReadProperty("SONGUOIBENHCONLAI", true);
                _sONGUOIBENHCONLAI = _sONGUOIBENHCONLAI_BH + _sONGUOIBENHVAOVIEN_KHONGBH;
                return _sONGUOIBENHCONLAI;
            }
           
        }

        public Int32 SONGUOIBENHCONLAI_BH
        {
            get
            {
                CanReadProperty("SONGUOIBENHCONLAI_BH", true);
                return _sONGUOIBENHCONLAI_BH;
            }
            set
            {
                CanWriteProperty("SONGUOIBENHCONLAI_BH", true);
                if (_sONGUOIBENHCONLAI_BH != value)
                {
                    _sONGUOIBENHCONLAI_BH = value;
                    PropertyHasChanged("SONGUOIBENHCONLAI_BH");
                }
            }
        }

        public Int32 SONGUOIBENHCONLAI_KHONGBH
        {
            get
            {
                CanReadProperty("SONGUOIBENHCONLAI_KHONGBH", true);
                return _sONGUOIBENHCONLAI_KHONGBH;
            }
            set
            {
                CanWriteProperty("SONGUOIBENHCONLAI_KHONGBH", true);
                if (_sONGUOIBENHCONLAI_KHONGBH != value)
                {
                    _sONGUOIBENHCONLAI_KHONGBH = value;
                    PropertyHasChanged("SONGUOIBENHCONLAI_KHONGBH");
                }
            }
        }

        public Int32 SONGUOIBENHCONLAI_DUOI6TUOI
        {
            get
            {
                CanReadProperty("SONGUOIBENHCONLAI_DUOI6TUOI", true);
                return _sONGUOIBENHCONLAI_DUOI6TUOI;
            }
            set
            {
                CanWriteProperty("SONGUOIBENHCONLAI_DUOI6TUOI", true);
                if (_sONGUOIBENHCONLAI_DUOI6TUOI != value)
                {
                    _sONGUOIBENHCONLAI_DUOI6TUOI = value;
                    PropertyHasChanged("SONGUOIBENHCONLAI_DUOI6TUOI");
                }
            }
        }

        public Int32 SONGUOIBENHCONLAI_TU6DEN15TUOI
        {
            get
            {
                CanReadProperty("SONGUOIBENHCONLAI_TU6DEN15TUOI", true);
                return _sONGUOIBENHCONLAI_TU6DEN15TUOI;
            }
            set
            {
                CanWriteProperty("SONGUOIBENHCONLAI_TU6DEN15TUOI", true);
                if (_sONGUOIBENHCONLAI_TU6DEN15TUOI != value)
                {
                    _sONGUOIBENHCONLAI_TU6DEN15TUOI = value;
                    PropertyHasChanged("SONGUOIBENHCONLAI_TU6DEN15TUOI");
                }
            }
        }

        public Int32 TONGSONGAYDIEUTRI
        {
            get
            {
                CanReadProperty("TONGSONGAYDIEUTRI", true);
                return _tONGSONGAYDIEUTRI;
            }
            set
            {
                CanWriteProperty("TONGSONGAYDIEUTRI", true);
                if (_tONGSONGAYDIEUTRI != value)
                {
                    _tONGSONGAYDIEUTRI = value;
                    PropertyHasChanged("TONGSONGAYDIEUTRI");
                }
            }
        }

        public Int32 TONGSONGAYDIEUTRI_RAVIEN
        {
            get
            {
                CanReadProperty("TONGSONGAYDIEUTRI_RAVIEN", true);
                return _tONGSONGAYDIEUTRI_RAVIEN;
            }
            set
            {
                CanWriteProperty("TONGSONGAYDIEUTRI_RAVIEN", true);
                if (_tONGSONGAYDIEUTRI_RAVIEN != value)
                {
                    _tONGSONGAYDIEUTRI_RAVIEN = value;
                    PropertyHasChanged("TONGSONGAYDIEUTRI_RAVIEN");
                }
            }
        }

        public Decimal TONGGIUONG
        {
            get
            {
                CanReadProperty("TONGGIUONG", true);
                TimeSpan T = _denNgay.Date.Subtract(_tuNgay.Date);
               if (((T.Days  + 1)* _giuongKH) != 0)
                   _tONGGIUONG = _tONGSONGAYDIEUTRI / ((T.Days + 1) * _giuongKH); 
                return _tONGGIUONG;
            }
          
        }

        public Int32 SXH_Cu
        {
            get
            {
                CanReadProperty("SXH_Cu", true);
                return _sXH_Cu;
            }
            set
            {
                CanWriteProperty("SXH_Cu", true);
                if (_sXH_Cu != value)
                {
                    _sXH_Cu = value;
                    PropertyHasChanged("SXH_Cu");
                }
            }
        }

        public Int32 SXH_Vao
        {
            get
            {
                CanReadProperty("SXH_Vao", true);
                return _sXH_Vao;
            }
            set
            {
                CanWriteProperty("SXH_Vao", true);
                if (_sXH_Vao != value)
                {
                    _sXH_Vao = value;
                    PropertyHasChanged("SXH_Vao");
                }
            }
        }
        public Int32 SXH_CVien
        {
            get
            {
                CanReadProperty("SXH_CVien", true);
                return _sXH_CVien;
            }
            set
            {
                CanWriteProperty("SXH_CVien", true);
                if (_sXH_CVien != value)
                {
                    _sXH_CVien = value;
                    PropertyHasChanged("SXH_CVien");
                }
            }
        }
        public Int32 SXH_Ra
        {
            get
            {
                CanReadProperty("SXH_Ra", true);
                return _sXH_Ra;
            }
            set
            {
                CanWriteProperty("SXH_Ra", true);
                if (_sXH_Ra != value)
                {
                    _sXH_Ra = value;
                    PropertyHasChanged("SXH_Ra");
                }
            }
        }

        public Int32 SXH_TVong
        {
            get
            {
                CanReadProperty("SXH_TVong", true);
                return _sXH_TVong;
            }
            set
            {
                CanWriteProperty("SXH_TVong", true);
                if (_sXH_TVong != value)
                {
                    _sXH_TVong = value;
                    PropertyHasChanged("SXH_TVong");
                }
            }
        }

        public Int32 SXH_HienCo
        {
            get
            {
                CanReadProperty("SXH_HienCo", true);
                _sXH_HienCo = _sXH_Cu + _sXH_Vao - _sXH_Ra - _sXH_TVong - _sXH_CVien ;
                return _sXH_HienCo;
            }
            
        }

        public Int32 SXH_TichLuy
        {
            get
            {
                CanReadProperty("SXH_TichLuy", true);
                return _sXH_TichLuy;
            }
            set
            {
                CanWriteProperty("SXH_TichLuy", true);
                if (_sXH_TichLuy != value)
                {
                    _sXH_TichLuy = value;
                    PropertyHasChanged("SXH_TichLuy");
                }
            }
        }

        public Int32 TCC_Cu
        {
            get
            {
                CanReadProperty("TCC_Cu", true);
                return _tCC_Cu;
            }
            set
            {
                CanWriteProperty("TCC_Cu", true);
                if (_tCC_Cu != value)
                {
                    _tCC_Cu = value;
                    PropertyHasChanged("TCC_Cu");
                }
            }
        }

        public Int32 TCC_Vao
        {
            get
            {
                CanReadProperty("TCC_Vao", true);
                return _tCC_Vao;
            }
            set
            {
                CanWriteProperty("TCC_Vao", true);
                if (_tCC_Vao != value)
                {
                    _tCC_Vao = value;
                    PropertyHasChanged("TCC_Vao");
                }
            }
        }
        public Int32 TCC_CVien
        {
            get
            {
                CanReadProperty("TCC_CVien", true);
                return _tCC_CVien;
            }
            set
            {
                CanWriteProperty("TCC_CVien", true);
                if (_tCC_CVien != value)
                {
                    _tCC_CVien = value;
                    PropertyHasChanged("TCC_CVien");
                }
            }
        }
        public Int32 TCC_Ra
        {
            get
            {
                CanReadProperty("TCC_Ra", true);
                return _tCC_Ra;
            }
            set
            {
                CanWriteProperty("TCC_Ra", true);
                if (_tCC_Ra != value)
                {
                    _tCC_Ra = value;
                    PropertyHasChanged("TCC_Ra");
                }
            }
        }

        public Int32 TCC_TVong
        {
            get
            {
                CanReadProperty("TCC_TVong", true);
                return _tCC_TVong;
            }
            set
            {
                CanWriteProperty("TCC_TVong", true);
                if (_tCC_TVong != value)
                {
                    _tCC_TVong = value;
                    PropertyHasChanged("TCC_TVong");
                }
            }
        }

        public Int32 TCC_HienCo
        {
            get
            {
                CanReadProperty("TCC_HienCo", true);
                _tCC_HienCo = _tCC_Cu + _tCC_Vao - _tCC_Ra - _tCC_TVong - _tCC_CVien ;
             
                return _tCC_HienCo;
            }
           
        }

        public Int32 TCC_TichLuy
        {
            get
            {
                CanReadProperty("TCC_TichLuy", true);
                return _tCC_TichLuy;
            }
            set
            {
                CanWriteProperty("TCC_TichLuy", true);
                if (_tCC_TichLuy != value)
                {
                    _tCC_TichLuy = value;
                    PropertyHasChanged("TCC_TichLuy");
                }
            }
        }

        public Int32 Khac_Cu
        {
            get
            {
                CanReadProperty("Khac_Cu", true);
                return _khac_Cu;
            }
            set
            {
                CanWriteProperty("Khac_Cu", true);
                if (_khac_Cu != value)
                {
                    _khac_Cu = value;
                    PropertyHasChanged("Khac_Cu");
                }
            }
        }

        public Int32 Khac_Vao
        {
            get
            {
                CanReadProperty("Khac_Vao", true);
                return _khac_Vao;
            }
            set
            {
                CanWriteProperty("Khac_Vao", true);
                if (_khac_Vao != value)
                {
                    _khac_Vao = value;
                    PropertyHasChanged("Khac_Vao");
                }
            }
        }
        public Int32 Khac_CVien
        {
            get
            {
                CanReadProperty("Khac_CVien", true);
                return _khac_CVien;
            }
            set
            {
                CanWriteProperty("Khac_CVien", true);
                if (_khac_CVien != value)
                {
                    _khac_CVien = value;
                    PropertyHasChanged("Khac_CVien");
                }
            }
        }
        public Int32 Khac_Ra
        {
            get
            {
                CanReadProperty("Khac_Ra", true);
                return _khac_Ra;
            }
            set
            {
                CanWriteProperty("Khac_Ra", true);
                if (_khac_Ra != value)
                {
                    _khac_Ra = value;
                    PropertyHasChanged("Khac_Ra");
                }
            }
        }

        public Int32 Khac_TVong
        {
            get
            {
                CanReadProperty("Khac_TVong", true);
                return _khac_TVong;
            }
            set
            {
                CanWriteProperty("Khac_TVong", true);
                if (_khac_TVong != value)
                {
                    _khac_TVong = value;
                    PropertyHasChanged("Khac_TVong");
                }
            }
        }

        public Int32 Khac_HienCo
        {
            get
            {
                CanReadProperty("Khac_HienCo", true);
                _khac_HienCo = _khac_Cu + _khac_Vao - _khac_Ra - _khac_TVong -_khac_CVien ;
            
                return _khac_HienCo;
            }
            
        }

        public Int32 Khac_TichLuy
        {
            get
            {
                CanReadProperty("Khac_TichLuy", true);
                return _khac_TichLuy;
            }
            set
            {
                CanWriteProperty("Khac_TichLuy", true);
                if (_khac_TichLuy != value)
                {
                    _khac_TichLuy = value;
                    PropertyHasChanged("Khac_TichLuy");
                }
            }
        }

        public Int32 Khac_Cu1
        {
            get
            {
                CanReadProperty("Khac_Cu1", true);
                return _khac_Cu1;
            }
            set
            {
                CanWriteProperty("Khac_Cu1", true);
                if (_khac_Cu1 != value)
                {
                    _khac_Cu1 = value;
                    PropertyHasChanged("Khac_Cu1");
                }
            }
        }

        public Int32 Khac_Vao1
        {
            get
            {
                CanReadProperty("Khac_Vao1", true);
                return _khac_Vao1;
            }
            set
            {
                CanWriteProperty("Khac_Vao1", true);
                if (_khac_Vao1 != value)
                {
                    _khac_Vao1 = value;
                    PropertyHasChanged("Khac_Vao1");
                }
            }
        }
        public Int32 Khac_CVien1
        {
            get
            {
                CanReadProperty("Khac_CVien1", true);
                return _khac_CVien1;
            }
            set
            {
                CanWriteProperty("Khac_CVien1", true);
                if (_khac_CVien1 != value)
                {
                    _khac_CVien1 = value;
                    PropertyHasChanged("Khac_CVien1");
                }
            }
        }
        public Int32 Khac_Ra1
        {
            get
            {
                CanReadProperty("Khac_Ra1", true);
                return _khac_Ra1;
            }
            set
            {
                CanWriteProperty("Khac_Ra1", true);
                if (_khac_Ra1 != value)
                {
                    _khac_Ra1 = value;
                    PropertyHasChanged("Khac_Ra1");
                }
            }
        }

        public Int32 Khac_TVong1
        {
            get
            {
                CanReadProperty("Khac_TVong1", true);
                return _khac_TVong1;
            }
            set
            {
                CanWriteProperty("Khac_TVong1", true);
                if (_khac_TVong1 != value)
                {
                    _khac_TVong1 = value;
                    PropertyHasChanged("Khac_TVong1");
                }
            }
        }

        public Int32 Khac_HienCo1
        {
            get
            {
                CanReadProperty("Khac_HienCo1", true);
                _khac_HienCo1 = _khac_Cu1 + _khac_Vao1 - _khac_Ra1 - _khac_TVong1 -_khac_CVien1 ;
            
                return _khac_HienCo1;
            }
           
        }

        public Int32 Khac_TichLuy1
        {
            get
            {
                CanReadProperty("Khac_TichLuy1", true);
                return _khac_TichLuy1;
            }
            set
            {
                CanWriteProperty("Khac_TichLuy1", true);
                if (_khac_TichLuy1 != value)
                {
                    _khac_TichLuy1 = value;
                    PropertyHasChanged("Khac_TichLuy1");
                }
            }
        }

        public Decimal BenhAnKT_Tot
        {
            get
            {
                CanReadProperty("BenhAnKT_Tot", true);
                return _benhAnKT_Tot;
            }
            set
            {
                CanWriteProperty("BenhAnKT_Tot", true);
                if (_benhAnKT_Tot != value)
                {
                    _benhAnKT_Tot = value;
                    PropertyHasChanged("BenhAnKT_Tot");
                }
            }
        }

        public Decimal BenhAnKT_Kha
        {
            get
            {
                CanReadProperty("BenhAnKT_Kha", true);
                return _benhAnKT_Kha;
            }
            set
            {
                CanWriteProperty("BenhAnKT_Kha", true);
                if (_benhAnKT_Kha != value)
                {
                    _benhAnKT_Kha = value;
                    PropertyHasChanged("BenhAnKT_Kha");
                }
            }
        }

        public Decimal BenhAnKT_TB
        {
            get
            {
                CanReadProperty("BenhAnKT_TB", true);
                return _benhAnKT_TB;
            }
            set
            {
                CanWriteProperty("BenhAnKT_TB", true);
                if (_benhAnKT_TB != value)
                {
                    _benhAnKT_TB = value;
                    PropertyHasChanged("BenhAnKT_TB");
                }
            }
        }

        public Decimal BenhAnKT_Kem
        {
            get
            {
                CanReadProperty("BenhAnKT_Kem", true);
                return _benhAnKT_Kem;
            }
            set
            {
                CanWriteProperty("BenhAnKT_Kem", true);
                if (_benhAnKT_Kem != value)
                {
                    _benhAnKT_Kem = value;
                    PropertyHasChanged("BenhAnKT_Kem");
                }
            }
        }

        public Decimal DonThuocKT_Tot
        {
            get
            {
                CanReadProperty("DonThuocKT_Tot", true);
                return _donThuocKT_Tot;
            }
            set
            {
                CanWriteProperty("DonThuocKT_Tot", true);
                if (_donThuocKT_Tot != value)
                {
                    _donThuocKT_Tot = value;
                    PropertyHasChanged("DonThuocKT_Tot");
                }
            }
        }

        public Decimal DonThuocKT_Kha
        {
            get
            {
                CanReadProperty("DonThuocKT_Kha", true);
                return _donThuocKT_Kha;
            }
            set
            {
                CanWriteProperty("DonThuocKT_Kha", true);
                if (_donThuocKT_Kha != value)
                {
                    _donThuocKT_Kha = value;
                    PropertyHasChanged("DonThuocKT_Kha");
                }
            }
        }

        public Decimal DonThuocKT_TB
        {
            get
            {
                CanReadProperty("DonThuocKT_TB", true);
                return _donThuocKT_TB;
            }
            set
            {
                CanWriteProperty("DonThuocKT_TB", true);
                if (_donThuocKT_TB != value)
                {
                    _donThuocKT_TB = value;
                    PropertyHasChanged("DonThuocKT_TB");
                }
            }
        }

        public Decimal DonThuocKT_Kem
        {
            get
            {
                CanReadProperty("DonThuocKT_Kem", true);
                return _donThuocKT_Kem;
            }
            set
            {
                CanWriteProperty("DonThuocKT_Kem", true);
                if (_donThuocKT_Kem != value)
                {
                    _donThuocKT_Kem = value;
                    PropertyHasChanged("DonThuocKT_Kem");
                }
            }
        }

        public String TacHaiThuoc
        {
            get
            {
                CanReadProperty("TacHaiThuoc", true);
                return _tacHaiThuoc;
            }
            set
            {
                CanWriteProperty("TacHaiThuoc", true);
                if (_tacHaiThuoc != value)
                {
                    _tacHaiThuoc = value;
                    PropertyHasChanged("TacHaiThuoc");
                }
            }
        }

        public String TaiBien
        {
            get
            {
                CanReadProperty("TaiBien", true);
                return _taiBien;
            }
            set
            {
                CanWriteProperty("TaiBien", true);
                if (_taiBien != value)
                {
                    _taiBien = value;
                    PropertyHasChanged("TaiBien");
                }
            }
        }

        public String DacBiet
        {
            get
            {
                CanReadProperty("DacBiet", true);
                return _dacBiet;
            }
            set
            {
                CanWriteProperty("DacBiet", true);
                if (_dacBiet != value)
                {
                    _dacBiet = value;
                    PropertyHasChanged("DacBiet");
                }
            }
        }

        public String CacHDCM
        {
            get
            {
                CanReadProperty("CacHDCM", true);
                return _cacHDCM;
            }
            set
            {
                CanWriteProperty("CacHDCM", true);
                if (_cacHDCM != value)
                {
                    _cacHDCM = value;
                    PropertyHasChanged("CacHDCM");
                }
            }
        }

        public String DeNghiSoYT
        {
            get
            {
                CanReadProperty("DeNghiSoYT", true);
                return _deNghiSoYT;
            }
            set
            {
                CanWriteProperty("DeNghiSoYT", true);
                if (_deNghiSoYT != value)
                {
                    _deNghiSoYT = value;
                    PropertyHasChanged("DeNghiSoYT");
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
            return _maBC.ToString() ;
        }
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty ;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid ;
            }
        }
        #endregion
        #endregion

        #region Business Object Rules and Validation //muon kiem tra null cua truong nao thi cho truong do

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="DMDichVu_BC" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static BC_THChuyenMon NewBC_THChuyenMon()
        {
            return DataPortal.Create<BC_THChuyenMon>();
        }
        public static BC_THChuyenMon GetBC_THChuyenMon(string  mabc)
        {
            return DataPortal.Fetch<BC_THChuyenMon>(new Criteria(mabc));
        }
        public static BC_THChuyenMon GetBC_THChuyenMon(DateTime tungay ,DateTime denngay,byte loaibc)
        {
            return DataPortal.Fetch<BC_THChuyenMon>(new CriteriaOther (tungay ,denngay,loaibc ,""));
        }
        public static BC_THChuyenMon GetBC_THChuyenMon(SafeDataReader dr)
        {
            BC_THChuyenMon obj = new BC_THChuyenMon();
            obj.Fetch(dr);
            return obj;
        }
        /// <summary>
        /// Marks the <see cref="DMDichVu_BC" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>//(String _maPN, SmartDate _ngaySD, String _maMay, String _nguoiSD);
        public static void DeleteBC_THChuyenMon_C(string mabc,string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mabc, mamay, nguoihuy));
        }

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        protected internal BC_THChuyenMon()
        {
            // Prevent direct creation
        }
        internal BC_THChuyenMon(int OrderNumber,
 string mabc ,
SmartDate TuNgay		,
	SmartDate DenNgay		,
	byte LoaiBC		,
	int GiuongKH		,
	int GiuongTT		,
	int SolanKham_KKB		,
	int SolanKham_PhuongXa		,
	int SolanKham_KhuVuc		,
	int SolanKham_DuPhong		,
	int SolanKhamCC		,
	int SolanKhamCC_DUOI6TUOI		,
	int SolanKhamCC_NGOAITINH		,
	int SolanKhamCC_BH		,
	int SolanKhamCC_YC		,
	int SolanKhamCC_NN		,
	int SolanKhamCC_MF		,
	int SolanKhamCC_TE		,
	int Songuoikham_KKB		,
	int Songuoikham_NN		,
	int Songuoikham_DUOI6TUOI		,
	int Songuoikham_NBNgoaiTinh		,
	int SonguoiKham_PhuongXa		,
	int SonguoiKham_KhuVuc		,
	int SonguoiKham_DuPhong		,
	int SonguoiDTNgoaitru		,
	int SongayDTNgoaitru		,
	int TainanGiaothong		,
	int TainanGiaothong_NBTuVong		,
	int TainanGiaothong_PHAUTHUATCHANTHUONG		,
    int TainanGiaothong_PHAUTHUATCHINHHINH,
	
	int TainanSinhhoat		,
	int TainanLaodong		,
	int PhauThuat_KH		,
    int PhauThuat_CC,
	int THUTHUAT_KH		,
	int THUTHUAT_CC		,
	int CHUYENVIEN_NOITRU		,
	int CHUYENVIEN_NGOAITRU		,
	int TUVONG_NGUOILON		,
	int TUVONG_DUOI5TUOI		,
	int TUVONG_TREN5TUOI		,
	int TUVONG_NOITRU		,
	int TUVONG_KKB		,
	int CHETTRUOC24H_NGUOILON		,
	int CHETTRUOC24H_DUOI5TUOI		,
	int CHETTRUOC24H_TU5DEN15TUOI		,
	int CHETTRUOC24H_NOITRU		,
	int CHETTRUOC24H_KKB		,
	int TIEUBANXETNGHIEM		,
	int CHANDOANHINHANH		,
	int ChieuXQ		,
	int ChupXQ		,
	int SIEUAM		,
	int Scanner		,
	int XQKhac		,
	int SIEUAMKHAC		,
	int THAMDOCHUCNANG		,
	int DIENTIM		,
	int DienNao		,
	int NoiSoi		,
	int TDCNKhac		,
	int SOBENHANDAKIEMTRA		,
	int SONGUOIBENHDAUKY		,
	int SONGUOIBENHVAOVIEN		,
	int SONGUOIBENHVAOVIEN_BH		,
	int SONGUOIBENHVAOVIEN_KHONGBH		,
	int SONGUOIBENHVAOVIEN_NGUOINGHEO		,
	int SONGUOIBENHVAOVIEN_DUOI6TUOI		,
	int SONGUOIBENHVAOVIEN_6DEN15TUOI		,
	int SONGUOIBENHVAOVIEN_NGOAITINH		,
	int SONGUOIBENHRAVIEN		,
	int SONGUOIBENHCONLAI		,
	int SONGUOIBENHCONLAI_BH		,
	int SONGUOIBENHCONLAI_KHONGBH		,
	int SONGUOIBENHCONLAI_DUOI6TUOI		,
	int SONGUOIBENHCONLAI_TU6DEN15TUOI		,
	int TONGSONGAYDIEUTRI		,
	int TONGSONGAYDIEUTRI_RAVIEN		,
	int TONGGIUONG		,
	int SXH_Cu		,
	int SXH_Vao		,
    int SXH_CVien,
	int SXH_Ra		,
	int SXH_TVong		,
	int SXH_HienCo		,
	int SXH_TichLuy		,
	int TCC_Cu		,
	int TCC_Vao		,
    int TCC_CVien,
	int TCC_Ra		,
	int TCC_TVong		,
	int TCC_HienCo		,
	int TCC_TichLuy		,
	int Khac_Cu		,
	int Khac_Vao		,
    int Khac_CVien,
	int Khac_Ra		,
	int Khac_TVong		,
	int Khac_HienCo		,
	int Khac_TichLuy		,
	int Khac_Cu1		,
	int Khac_Vao1		,
    int Khac_CVien1,
	int Khac_Ra1		,
	int Khac_TVong1		,
	int Khac_HienCo1		,
	int Khac_TichLuy1		,
	decimal BenhAnKT_Tot		,
	decimal BenhAnKT_Kha		,
	decimal BenhAnKT_TB		,
	decimal BenhAnKT_Kem		,
	decimal DonThuocKT_Tot		,
	decimal DonThuocKT_Kha		,
	decimal DonThuocKT_TB		,
	decimal DonThuocKT_Kem		,
	String TacHaiThuoc		,
	String TaiBien		,
	String DacBiet		,
	String CacHDCM		,
	String DeNghiSoYT		,
  Boolean huy,
  SmartDate ngaySD,
  String nguoiSD,

  String maMay,

  String tenNguoiSD

                 )
        {

            _OrderNumber = OrderNumber;
            _maBC = mabc;
            _tuNgay = TuNgay;
            _denNgay = DenNgay;
            _loaiBC = LoaiBC;
            _giuongKH = GiuongKH;
            _giuongTT = GiuongTT;
            _solanKham_KKB = SolanKham_KKB;
            _solanKham_PhuongXa = SolanKham_PhuongXa;
            _solanKham_KhuVuc = SolanKham_KhuVuc;
            _solanKham_DuPhong = SolanKham_DuPhong;
            _solanKhamCC = SolanKhamCC; 
            _solanKhamCC_DUOI6TUOI = SolanKhamCC_DUOI6TUOI;
            _solanKhamCC_NGOAITINH = SolanKhamCC_NGOAITINH;
            _solanKhamCC_BH = SolanKhamCC_BH; 
            _solanKhamCC_YC = SolanKhamCC_YC; 
            _solanKhamCC_NN = SolanKhamCC_NN;
            _solanKhamCC_MF = SolanKhamCC_MF;
            _solanKhamCC_TE = SolanKhamCC_TE; 
            _songuoikham_KKB = Songuoikham_KKB;
            _songuoikham_NN = Songuoikham_NN;
            _songuoikham_DUOI6TUOI = Songuoikham_DUOI6TUOI;
            _songuoikham_NBNgoaiTinh = Songuoikham_NBNgoaiTinh;
            _songuoiKham_PhuongXa = SonguoiKham_PhuongXa; 
            _songuoiKham_KhuVuc = SonguoiKham_KhuVuc;
            _songuoiKham_DuPhong = SonguoiKham_DuPhong;
            _songuoiDTNgoaitru = SonguoiDTNgoaitru;
            _songayDTNgoaitru = SongayDTNgoaitru;
            _tainanGiaothong = TainanGiaothong;
            _tainanGiaothong_NBTuVong = TainanGiaothong_NBTuVong;
            _tainanGiaothong_PHAUTHUATCHANTHUONG = TainanGiaothong_PHAUTHUATCHANTHUONG;
            _tainanGiaothong_PHAUTHUATCHINHHINH = TainanGiaothong_PHAUTHUATCHINHHINH;
            _tainanSinhhoat = TainanSinhhoat; 
            _tainanLaodong = TainanLaodong; 
            _phauThuat_KH = PhauThuat_KH;
            _phauThuat_CC = PhauThuat_CC;
            _tHUTHUAT_KH = THUTHUAT_KH;
            _tHUTHUAT_CC = THUTHUAT_CC; 
            _cHUYENVIEN_NOITRU = CHUYENVIEN_NOITRU; 
            _cHUYENVIEN_NGOAITRU = CHUYENVIEN_NGOAITRU; 
            _tUVONG_NGUOILON = TUVONG_NGUOILON;
            _tUVONG_DUOI5TUOI = TUVONG_DUOI5TUOI;
            _tUVONG_TREN5TUOI = TUVONG_TREN5TUOI; _tUVONG_NOITRU = TUVONG_NOITRU; _tUVONG_KKB = TUVONG_KKB; 
            _cHETTRUOC24H_NGUOILON = CHETTRUOC24H_NGUOILON; _cHETTRUOC24H_DUOI5TUOI = CHETTRUOC24H_DUOI5TUOI; 
            _cHETTRUOC24H_TU5DEN15TUOI = CHETTRUOC24H_TU5DEN15TUOI;
            _cHETTRUOC24H_NOITRU = CHETTRUOC24H_NOITRU; _cHETTRUOC24H_KKB = CHETTRUOC24H_KKB; _tIEUBANXETNGHIEM = TIEUBANXETNGHIEM; _cHANDOANHINHANH = CHANDOANHINHANH; _chieuXQ = ChieuXQ; _chupXQ = ChupXQ;
            _sIEUAM = SIEUAM; _scanner = Scanner; 
            _xQKhac = XQKhac; _sIEUAMKHAC = SIEUAMKHAC; _tHAMDOCHUCNANG = THAMDOCHUCNANG; _dIENTIM = DIENTIM; _dienNao = DienNao; _noiSoi = NoiSoi; _tDCNKhac = TDCNKhac; _sOBENHANDAKIEMTRA = SOBENHANDAKIEMTRA; _sONGUOIBENHDAUKY = SONGUOIBENHDAUKY; 
            _sONGUOIBENHVAOVIEN = SONGUOIBENHVAOVIEN; _sONGUOIBENHVAOVIEN_BH = SONGUOIBENHVAOVIEN_BH; 
            _sONGUOIBENHVAOVIEN_KHONGBH = SONGUOIBENHVAOVIEN_KHONGBH;
            _sONGUOIBENHVAOVIEN_NGUOINGHEO = SONGUOIBENHVAOVIEN_NGUOINGHEO;
            _sONGUOIBENHVAOVIEN_DUOI6TUOI = SONGUOIBENHVAOVIEN_DUOI6TUOI;
            _sONGUOIBENHVAOVIEN_6DEN15TUOI = SONGUOIBENHVAOVIEN_6DEN15TUOI;
            _sONGUOIBENHVAOVIEN_NGOAITINH = SONGUOIBENHVAOVIEN_NGOAITINH;
            _sONGUOIBENHRAVIEN = SONGUOIBENHRAVIEN; 
            _sONGUOIBENHCONLAI = SONGUOIBENHCONLAI; 
            _sONGUOIBENHCONLAI_BH = SONGUOIBENHCONLAI_BH; 
            _sONGUOIBENHCONLAI_KHONGBH = SONGUOIBENHCONLAI_KHONGBH; 
            _sONGUOIBENHCONLAI_DUOI6TUOI = SONGUOIBENHCONLAI_DUOI6TUOI;
            _sONGUOIBENHCONLAI_TU6DEN15TUOI = SONGUOIBENHCONLAI_TU6DEN15TUOI;
            _tONGSONGAYDIEUTRI = TONGSONGAYDIEUTRI; 
            _tONGSONGAYDIEUTRI_RAVIEN = TONGSONGAYDIEUTRI_RAVIEN; 
            _tONGGIUONG = TONGGIUONG; _sXH_Cu = SXH_Cu; _sXH_Vao = SXH_Vao;
            _sXH_CVien = SXH_CVien; _sXH_Ra = SXH_Ra; _sXH_TVong = SXH_TVong; _sXH_HienCo = SXH_HienCo; 
            _sXH_TichLuy = SXH_TichLuy; _tCC_Cu = TCC_Cu; _tCC_Vao = TCC_Vao;
            _tCC_CVien = TCC_CVien; _tCC_Ra = TCC_Ra; _tCC_TVong = TCC_TVong; _tCC_HienCo = TCC_HienCo; 
            _tCC_TichLuy = TCC_TichLuy; _khac_Cu = Khac_Cu; _khac_Vao = Khac_Vao;
            _khac_CVien = Khac_CVien; _khac_Ra = Khac_Ra; _khac_TVong = Khac_TVong; 
            _khac_HienCo = Khac_HienCo; _khac_TichLuy = Khac_TichLuy;
            _khac_Cu1 = Khac_Cu1; _khac_Vao1 = Khac_Vao1; _khac_CVien1 = Khac_CVien1; _khac_Ra1 = Khac_Ra1;
            _khac_TVong1 = Khac_TVong1; _khac_HienCo1 = Khac_HienCo1; 
            _khac_TichLuy1 = Khac_TichLuy1; _benhAnKT_Tot = BenhAnKT_Tot; 
            _benhAnKT_Kha = BenhAnKT_Kha; _benhAnKT_TB = BenhAnKT_TB; 
            _benhAnKT_Kem = BenhAnKT_Kem; _donThuocKT_Tot = DonThuocKT_Tot; 
            _donThuocKT_Kha = DonThuocKT_Kha; _donThuocKT_TB = DonThuocKT_TB;
            _donThuocKT_Kem = DonThuocKT_Kem; _tacHaiThuoc = TacHaiThuoc; 
            _taiBien = TaiBien; _dacBiet = DacBiet; 
            _cacHDCM = CacHDCM; _deNghiSoYT = DeNghiSoYT; _ghiChu = GhiChu;
            _huy = huy ;
            _ngaySD = ngaySD ;
            _nguoiSD = NguoiSD;
            _tenNguoiSD = tenNguoiSD;
            _maMay = maMay;

        }
        #endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
          
             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private string _mabc;
            public string mabc
            {
                get
                {
                    return _mabc;
                }
            }
            public Criteria( string mabc)
            {
                _mabc = mabc ;
                
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_mabc.Equals(c._mabc) )
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _mabc.ToString()).GetHashCode();
            }
        }

        [Serializable()]
        protected class OtherCriteria
        {
             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private string _mabc;
            public string mabc
            {
                get
                {
                    return _mabc;
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
            //DeleteBC_THChuyenMon(String _maPN, SmartDate _ngaySD, String _maMay, String _nguoiSD);
            public OtherCriteria(string mabc, String Mamay, String Nguoisd)
            {
                _mabc = mabc;

                _maMay = Mamay;
                _NguoiSD = Nguoisd;
               
            }

        }
        private class CriteriaOther
        {
            private DateTime _TuThang;
            private DateTime _DenThang;
            private String _DK;
             private byte _loaibc;
            public String DK
            {
                get
                {
                    return _DK;
                }
            }

            public DateTime TuThang
            {
                get
                {
                    return _TuThang;
                }
            }
            public DateTime DenThang
            {
                get
                {
                    return _DenThang;
                }
            }
              public byte loaibc
            {
                get
                {
                    return _loaibc;
                }
            }
            public CriteriaOther(DateTime mTuThang, DateTime mDenThang, byte loaibc ,String dk)
            {
                _TuThang = mTuThang;
                _DenThang = mDenThang;
                _DK = dk;
                _loaibc = loaibc;


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
        /// Retrieve an existing <see cref="DMDichVu_BC" /> Object based on data in the database.
        /// </summary>
        /// 
        protected void Fetch(SafeDataReader dr)
        {
            if (dr.GetString("mabc") != null) _maBC = dr.GetString("mabc");

            if (dr.GetSmartDate("TuNgay", true) != null) _tuNgay = dr.GetSmartDate("TuNgay", true);
            if (dr.GetSmartDate("DenNgay", true) != null) _denNgay = dr.GetSmartDate("DenNgay", true);
            if (dr.GetByte("LoaiBC") != null) _loaiBC = dr.GetByte("LoaiBC");
            if (dr.GetInt32("GiuongKH") != null) _giuongKH = dr.GetInt32("GiuongKH");
            if (dr.GetInt32("GiuongTT") != null) _giuongTT = dr.GetInt32("GiuongTT");
            if (dr.GetInt32("SolanKham_KKB") != null) _solanKham_KKB = dr.GetInt32("SolanKham_KKB");
            if (dr.GetInt32("SolanKham_PhuongXa") != null) _solanKham_PhuongXa = dr.GetInt32("SolanKham_PhuongXa");
            if (dr.GetInt32("SolanKham_KhuVuc") != null) _solanKham_KhuVuc = dr.GetInt32("SolanKham_KhuVuc");
            if (dr.GetInt32("SolanKham_DuPhong") != null) _solanKham_DuPhong = dr.GetInt32("SolanKham_DuPhong");
            if (dr.GetInt32("SolanKhamCC") != null) _solanKhamCC = dr.GetInt32("SolanKhamCC");
            if (dr.GetInt32("SolanKhamCC_DUOI6TUOI") != null) _solanKhamCC_DUOI6TUOI = dr.GetInt32("SolanKhamCC_DUOI6TUOI");
            if (dr.GetInt32("SolanKhamCC_NGOAITINH") != null) _solanKhamCC_NGOAITINH = dr.GetInt32("SolanKhamCC_NGOAITINH");
            if (dr.GetInt32("SolanKhamCC_BH") != null) _solanKhamCC_BH = dr.GetInt32("SolanKhamCC_BH");
            if (dr.GetInt32("SolanKhamCC_YC") != null) _solanKhamCC_YC = dr.GetInt32("SolanKhamCC_YC");
            if (dr.GetInt32("SolanKhamCC_NN") != null) _solanKhamCC_NN = dr.GetInt32("SolanKhamCC_NN");
            if (dr.GetInt32("SolanKhamCC_MF") != null) _solanKhamCC_MF = dr.GetInt32("SolanKhamCC_MF");
            if (dr.GetInt32("SolanKhamCC_TE") != null) _solanKhamCC_TE = dr.GetInt32("SolanKhamCC_TE");
            if (dr.GetInt32("Songuoikham_KKB") != null) _songuoikham_KKB = dr.GetInt32("Songuoikham_KKB");
            if (dr.GetInt32("Songuoikham_NN") != null) _songuoikham_NN = dr.GetInt32("Songuoikham_NN");
            
            if (dr.GetInt32("Songuoikham_DUOI6TUOI") != null) _songuoikham_DUOI6TUOI = dr.GetInt32("Songuoikham_DUOI6TUOI");
            if (dr.GetInt32("Songuoikham_NBNgoaiTinh") != null) _songuoikham_NBNgoaiTinh = dr.GetInt32("Songuoikham_NBNgoaiTinh");
            if (dr.GetInt32("SonguoiKham_PhuongXa") != null) _songuoiKham_PhuongXa = dr.GetInt32("SonguoiKham_PhuongXa");
            if (dr.GetInt32("SonguoiKham_KhuVuc") != null) _songuoiKham_KhuVuc = dr.GetInt32("SonguoiKham_KhuVuc");
            if (dr.GetInt32("SonguoiKham_DuPhong") != null) _songuoiKham_DuPhong = dr.GetInt32("SonguoiKham_DuPhong");
            if (dr.GetInt32("SonguoiDTNgoaitru") != null) _songuoiDTNgoaitru = dr.GetInt32("SonguoiDTNgoaitru");
            if (dr.GetInt32("SongayDTNgoaitru") != null) _songayDTNgoaitru = dr.GetInt32("SongayDTNgoaitru");
            if (dr.GetInt32("TainanGiaothong") != null) _tainanGiaothong = dr.GetInt32("TainanGiaothong");
            if (dr.GetInt32("TainanGiaothong_NBTuVong") != null) _tainanGiaothong_NBTuVong = dr.GetInt32("TainanGiaothong_NBTuVong");
            if (dr.GetInt32("TainanGiaothong_PHAUTHUATCHANTHUONG") != null) _tainanGiaothong_PHAUTHUATCHANTHUONG = dr.GetInt32("TainanGiaothong_PHAUTHUATCHANTHUONG");
            if (dr.GetInt32("TainanGiaothong_PHAUTHUATCHINHHINH") != null) _tainanGiaothong_PHAUTHUATCHINHHINH = dr.GetInt32("TainanGiaothong_PHAUTHUATCHINHHINH");
            if (dr.GetInt32("TainanSinhhoat") != null) _tainanSinhhoat = dr.GetInt32("TainanSinhhoat");
            if (dr.GetInt32("TainanLaodong") != null) _tainanLaodong = dr.GetInt32("TainanLaodong");
            if (dr.GetInt32("PhauThuat_KH") != null) _phauThuat_KH = dr.GetInt32("PhauThuat_KH");
            if (dr.GetInt32("PhauThuat_CC") != null) _phauThuat_CC = dr.GetInt32("PhauThuat_CC");
            
            if (dr.GetInt32("THUTHUAT_KH") != null) _tHUTHUAT_KH = dr.GetInt32("THUTHUAT_KH");
            if (dr.GetInt32("THUTHUAT_CC") != null) _tHUTHUAT_CC = dr.GetInt32("THUTHUAT_CC");
            if (dr.GetInt32("CHUYENVIEN_NOITRU") != null) _cHUYENVIEN_NOITRU = dr.GetInt32("CHUYENVIEN_NOITRU");
            if (dr.GetInt32("CHUYENVIEN_NGOAITRU") != null) _cHUYENVIEN_NGOAITRU = dr.GetInt32("CHUYENVIEN_NGOAITRU");
            if (dr.GetInt32("TUVONG_NGUOILON") != null) _tUVONG_NGUOILON = dr.GetInt32("TUVONG_NGUOILON");
            if (dr.GetInt32("TUVONG_DUOI5TUOI") != null) _tUVONG_DUOI5TUOI = dr.GetInt32("TUVONG_DUOI5TUOI");
            if (dr.GetInt32("TUVONG_TREN5TUOI") != null) _tUVONG_TREN5TUOI = dr.GetInt32("TUVONG_TREN5TUOI");
            if (dr.GetInt32("TUVONG_NOITRU") != null) _tUVONG_NOITRU = dr.GetInt32("TUVONG_NOITRU");
            if (dr.GetInt32("TUVONG_KKB") != null) _tUVONG_KKB = dr.GetInt32("TUVONG_KKB");
            if (dr.GetInt32("CHETTRUOC24H_NGUOILON") != null) _cHETTRUOC24H_NGUOILON = dr.GetInt32("CHETTRUOC24H_NGUOILON");
            if (dr.GetInt32("CHETTRUOC24H_DUOI5TUOI") != null) _cHETTRUOC24H_DUOI5TUOI = dr.GetInt32("CHETTRUOC24H_DUOI5TUOI");
            if (dr.GetInt32("CHETTRUOC24H_TU5DEN15TUOI") != null) _cHETTRUOC24H_TU5DEN15TUOI = dr.GetInt32("CHETTRUOC24H_TU5DEN15TUOI");
            if (dr.GetInt32("CHETTRUOC24H_NOITRU") != null) _cHETTRUOC24H_NOITRU = dr.GetInt32("CHETTRUOC24H_NOITRU");
            if (dr.GetInt32("CHETTRUOC24H_KKB") != null) _cHETTRUOC24H_KKB = dr.GetInt32("CHETTRUOC24H_KKB");
            if (dr.GetInt32("TIEUBANXETNGHIEM") != null) _tIEUBANXETNGHIEM = dr.GetInt32("TIEUBANXETNGHIEM");
            if (dr.GetInt32("CHANDOANHINHANH") != null) _cHANDOANHINHANH = dr.GetInt32("CHANDOANHINHANH");
            if (dr.GetInt32("ChieuXQ") != null) _chieuXQ = dr.GetInt32("ChieuXQ");
            if (dr.GetInt32("ChupXQ") != null) _chupXQ = dr.GetInt32("ChupXQ");
            if (dr.GetInt32("SIEUAM") != null) _sIEUAM = dr.GetInt32("SIEUAM");
            if (dr.GetInt32("Scanner") != null) _scanner = dr.GetInt32("Scanner");
            if (dr.GetInt32("XQKhac") != null) _xQKhac = dr.GetInt32("XQKhac");
            if (dr.GetInt32("SIEUAMKHAC") != null) _sIEUAMKHAC = dr.GetInt32("SIEUAMKHAC");
            if (dr.GetInt32("THAMDOCHUCNANG") != null) _tHAMDOCHUCNANG = dr.GetInt32("THAMDOCHUCNANG");
            if (dr.GetInt32("DIENTIM") != null) _dIENTIM = dr.GetInt32("DIENTIM");
            if (dr.GetInt32("DienNao") != null) _dienNao = dr.GetInt32("DienNao");
            if (dr.GetInt32("NoiSoi") != null) _noiSoi = dr.GetInt32("NoiSoi");
            if (dr.GetInt32("TDCNKhac") != null) _tDCNKhac = dr.GetInt32("TDCNKhac");
            if (dr.GetInt32("SOBENHANDAKIEMTRA") != null) _sOBENHANDAKIEMTRA = dr.GetInt32("SOBENHANDAKIEMTRA");
            if (dr.GetInt32("SONGUOIBENHDAUKY") != null) _sONGUOIBENHDAUKY = dr.GetInt32("SONGUOIBENHDAUKY");
            if (dr.GetInt32("SONGUOIBENHVAOVIEN") != null) _sONGUOIBENHVAOVIEN = dr.GetInt32("SONGUOIBENHVAOVIEN");
            if (dr.GetInt32("SONGUOIBENHVAOVIEN_BH") != null) _sONGUOIBENHVAOVIEN_BH = dr.GetInt32("SONGUOIBENHVAOVIEN_BH");
            if (dr.GetInt32("SONGUOIBENHVAOVIEN_KHONGBH") != null) _sONGUOIBENHVAOVIEN_KHONGBH = dr.GetInt32("SONGUOIBENHVAOVIEN_KHONGBH");
            if (dr.GetInt32("SONGUOIBENHVAOVIEN_NGUOINGHEO") != null) _sONGUOIBENHVAOVIEN_NGUOINGHEO = dr.GetInt32("SONGUOIBENHVAOVIEN_NGUOINGHEO");
            if (dr.GetInt32("SONGUOIBENHVAOVIEN_DUOI6TUOI") != null) _sONGUOIBENHVAOVIEN_DUOI6TUOI = dr.GetInt32("SONGUOIBENHVAOVIEN_DUOI6TUOI");
            if (dr.GetInt32("SONGUOIBENHVAOVIEN_6DEN15TUOI") != null) _sONGUOIBENHVAOVIEN_6DEN15TUOI = dr.GetInt32("SONGUOIBENHVAOVIEN_6DEN15TUOI");
            if (dr.GetInt32("SONGUOIBENHVAOVIEN_NGOAITINH") != null) _sONGUOIBENHVAOVIEN_NGOAITINH = dr.GetInt32("SONGUOIBENHVAOVIEN_NGOAITINH");
            if (dr.GetInt32("SONGUOIBENHRAVIEN") != null) _sONGUOIBENHRAVIEN = dr.GetInt32("SONGUOIBENHRAVIEN");
            if (dr.GetInt32("SONGUOIBENHCONLAI") != null) _sONGUOIBENHCONLAI = dr.GetInt32("SONGUOIBENHCONLAI");
            if (dr.GetInt32("SONGUOIBENHCONLAI_BH") != null) _sONGUOIBENHCONLAI_BH = dr.GetInt32("SONGUOIBENHCONLAI_BH");
            if (dr.GetInt32("SONGUOIBENHCONLAI_KHONGBH") != null) _sONGUOIBENHCONLAI_KHONGBH = dr.GetInt32("SONGUOIBENHCONLAI_KHONGBH");
            if (dr.GetInt32("SONGUOIBENHCONLAI_DUOI6TUOI") != null) _sONGUOIBENHCONLAI_DUOI6TUOI = dr.GetInt32("SONGUOIBENHCONLAI_DUOI6TUOI");
            if (dr.GetInt32("SONGUOIBENHCONLAI_TU6DEN15TUOI") != null) _sONGUOIBENHCONLAI_TU6DEN15TUOI = dr.GetInt32("SONGUOIBENHCONLAI_TU6DEN15TUOI");
            if (dr.GetInt32("TONGSONGAYDIEUTRI") != null) _tONGSONGAYDIEUTRI = dr.GetInt32("TONGSONGAYDIEUTRI");
            if (dr.GetInt32("TONGSONGAYDIEUTRI_RAVIEN") != null) _tONGSONGAYDIEUTRI_RAVIEN = dr.GetInt32("TONGSONGAYDIEUTRI_RAVIEN");
            if (dr.GetDecimal("TONGGIUONG") != null) _tONGGIUONG = dr.GetDecimal("TONGGIUONG");
            if (dr.GetInt32("SXH_Cu") != null) _sXH_Cu = dr.GetInt32("SXH_Cu");
            if (dr.GetInt32("SXH_Vao") != null) _sXH_Vao = dr.GetInt32("SXH_Vao");
            if (dr.GetInt32("SXH_CVien") != null) _sXH_CVien = dr.GetInt32("SXH_CVien");
           
            if (dr.GetInt32("SXH_Ra") != null) _sXH_Ra = dr.GetInt32("SXH_Ra");
            if (dr.GetInt32("SXH_TVong") != null) _sXH_TVong = dr.GetInt32("SXH_TVong");
            if (dr.GetInt32("SXH_HienCo") != null) _sXH_HienCo = dr.GetInt32("SXH_HienCo");
            if (dr.GetInt32("SXH_TichLuy") != null) _sXH_TichLuy = dr.GetInt32("SXH_TichLuy");
            if (dr.GetInt32("TCC_Cu") != null) _tCC_Cu = dr.GetInt32("TCC_Cu");
            if (dr.GetInt32("TCC_Vao") != null) _tCC_Vao = dr.GetInt32("TCC_Vao");
            if (dr.GetInt32("TCC_CVien") != null) _tCC_CVien = dr.GetInt32("TCC_CVien");
            if (dr.GetInt32("TCC_Ra") != null) _tCC_Ra = dr.GetInt32("TCC_Ra");
            if (dr.GetInt32("TCC_TVong") != null) _tCC_TVong = dr.GetInt32("TCC_TVong");
            if (dr.GetInt32("TCC_HienCo") != null) _tCC_HienCo = dr.GetInt32("TCC_HienCo");
            if (dr.GetInt32("TCC_TichLuy") != null) _tCC_TichLuy = dr.GetInt32("TCC_TichLuy");
            if (dr.GetInt32("Khac_Cu") != null) _khac_Cu = dr.GetInt32("Khac_Cu");
            if (dr.GetInt32("Khac_Vao") != null) _khac_Vao = dr.GetInt32("Khac_Vao");
            if (dr.GetInt32("Khac_CVien") != null) _khac_CVien = dr.GetInt32("Khac_CVien");
            if (dr.GetInt32("Khac_Ra") != null) _khac_Ra = dr.GetInt32("Khac_Ra");
            if (dr.GetInt32("Khac_TVong") != null) _khac_TVong = dr.GetInt32("Khac_TVong");
            if (dr.GetInt32("Khac_HienCo") != null) _khac_HienCo = dr.GetInt32("Khac_HienCo");
            if (dr.GetInt32("Khac_TichLuy") != null) _khac_TichLuy = dr.GetInt32("Khac_TichLuy");
            if (dr.GetInt32("Khac_Cu1") != null) _khac_Cu1 = dr.GetInt32("Khac_Cu1");
            if (dr.GetInt32("Khac_Vao1") != null) _khac_Vao1 = dr.GetInt32("Khac_Vao1");
            if (dr.GetInt32("Khac_CVien1") != null) _khac_CVien1 = dr.GetInt32("Khac_CVien1");
            if (dr.GetInt32("Khac_Ra1") != null) _khac_Ra1 = dr.GetInt32("Khac_Ra1");
            if (dr.GetInt32("Khac_TVong1") != null) _khac_TVong1 = dr.GetInt32("Khac_TVong1");
            if (dr.GetInt32("Khac_HienCo1") != null) _khac_HienCo1 = dr.GetInt32("Khac_HienCo1");
            if (dr.GetInt32("Khac_TichLuy1") != null) _khac_TichLuy1 = dr.GetInt32("Khac_TichLuy1");
            if (dr.GetDecimal("BenhAnKT_Tot") != null) _benhAnKT_Tot = dr.GetDecimal("BenhAnKT_Tot");
            if (dr.GetDecimal("BenhAnKT_Kha") != null) _benhAnKT_Kha = dr.GetDecimal("BenhAnKT_Kha");
            if (dr.GetDecimal("BenhAnKT_TB") != null) _benhAnKT_TB = dr.GetDecimal("BenhAnKT_TB");
            if (dr.GetDecimal("BenhAnKT_Kem") != null) _benhAnKT_Kem = dr.GetDecimal("BenhAnKT_Kem");
            if (dr.GetDecimal("DonThuocKT_Tot") != null) _donThuocKT_Tot = dr.GetDecimal("DonThuocKT_Tot");
            if (dr.GetDecimal("DonThuocKT_Kha") != null) _donThuocKT_Kha = dr.GetDecimal("DonThuocKT_Kha");
            if (dr.GetDecimal("DonThuocKT_TB") != null) _donThuocKT_TB = dr.GetDecimal("DonThuocKT_TB");
            if (dr.GetDecimal("DonThuocKT_Kem") != null) _donThuocKT_Kem = dr.GetDecimal("DonThuocKT_Kem");
            if (dr.GetString("TacHaiThuoc") != null) _tacHaiThuoc = dr.GetString("TacHaiThuoc");
            if (dr.GetString("TaiBien") != null) _taiBien = dr.GetString("TaiBien");
            if (dr.GetString("DacBiet") != null) _dacBiet = dr.GetString("DacBiet");
            if (dr.GetString("CacHDCM") != null) _cacHDCM = dr.GetString("CacHDCM");
            if (dr.GetString("DeNghiSoYT") != null) _deNghiSoYT = dr.GetString("DeNghiSoYT");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");

            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            // _OrderNumber = dr.GetInt32("STT");
        }
        protected void DataPortal_Fetch(Criteria crit)
        {

            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBC_THChuyenMon(crit.mabc )))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                   
                    //ValidationRules.CheckRules();
                }
            }
        }
        private void DataPortal_Fetch(CriteriaOther crit)
        {
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBC_THChuyenMon(crit.TuThang,crit .DenThang,crit .loaibc ,crit.DK  )))
            {
                if (dr.Read())
                {
                    Fetch(dr);

                    //ValidationRules.CheckRules();
                }
            }
        }


        /// <summary>
        /// Insert the new <see cref="DMDichVu_BC" /> Object to underlying database.
        /// </summary>
        /// 
        protected override void DataPortal_Create()
        {
           
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDichVu_BC
            // Copy & paste ham duoi day vao file DataProvider.cs
            
              
            //public abstract String InsertBC_THChuyenMon(string _m SmartDate _ngayPNhap, String _maKho, decimal _chietKhau, Boolean _thanhToan, SmartDate _ngayTToan, SmartDate _ngayNhapTT, String _NVNhap, decimal _Tong, String _ghiChu, Boolean _huy, String _nguoiSD, String _maMay, String _nguoiGiao);
            DataProvider.Instance().InsertBC_THChuyenMon(_tuNgay, _denNgay, _loaiBC, _giuongKH, _giuongTT, _solanKham_KKB, _solanKham_PhuongXa, _solanKham_KhuVuc, _solanKham_DuPhong, _solanKhamCC, _solanKhamCC_DUOI6TUOI, _solanKhamCC_NGOAITINH, _solanKhamCC_BH, _solanKhamCC_YC, _solanKhamCC_NN, _solanKhamCC_MF, _solanKhamCC_TE, _songuoikham_KKB, _songuoikham_NN, _songuoikham_DUOI6TUOI, _songuoikham_NBNgoaiTinh, _songuoiKham_PhuongXa, _songuoiKham_KhuVuc, _songuoiKham_DuPhong, _songuoiDTNgoaitru, _songayDTNgoaitru, _tainanGiaothong, _tainanGiaothong_NBTuVong, _tainanGiaothong_PHAUTHUATCHANTHUONG, _tainanGiaothong_PHAUTHUATCHINHHINH, _tainanSinhhoat, _tainanLaodong, _phauThuat_KH, _phauThuat_CC, _tHUTHUAT_KH, _tHUTHUAT_CC, _cHUYENVIEN_NOITRU, _cHUYENVIEN_NGOAITRU, _tUVONG_NGUOILON, _tUVONG_DUOI5TUOI, _tUVONG_TREN5TUOI, _tUVONG_NOITRU, _tUVONG_KKB, _cHETTRUOC24H_NGUOILON, _cHETTRUOC24H_DUOI5TUOI, _cHETTRUOC24H_TU5DEN15TUOI, _cHETTRUOC24H_NOITRU, _cHETTRUOC24H_KKB, _tIEUBANXETNGHIEM, _cHANDOANHINHANH, _chieuXQ, _chupXQ, _sIEUAM, _scanner, _xQKhac, _sIEUAMKHAC, _tHAMDOCHUCNANG, _dIENTIM, _dienNao, _noiSoi, _tDCNKhac, _sOBENHANDAKIEMTRA, _sONGUOIBENHDAUKY, _sONGUOIBENHVAOVIEN, _sONGUOIBENHVAOVIEN_BH, _sONGUOIBENHVAOVIEN_KHONGBH, _sONGUOIBENHVAOVIEN_NGUOINGHEO, _sONGUOIBENHVAOVIEN_DUOI6TUOI, _sONGUOIBENHVAOVIEN_6DEN15TUOI, _sONGUOIBENHVAOVIEN_NGOAITINH, _sONGUOIBENHRAVIEN, _sONGUOIBENHCONLAI, _sONGUOIBENHCONLAI_BH, _sONGUOIBENHCONLAI_KHONGBH, _sONGUOIBENHCONLAI_DUOI6TUOI, _sONGUOIBENHCONLAI_TU6DEN15TUOI, _tONGSONGAYDIEUTRI, _tONGSONGAYDIEUTRI_RAVIEN, _tONGGIUONG, _sXH_Cu, _sXH_Vao, _sXH_CVien, _sXH_Ra, _sXH_TVong, _sXH_HienCo, _sXH_TichLuy, _tCC_Cu, _tCC_Vao, _tCC_CVien, _tCC_Ra, _tCC_TVong, _tCC_HienCo, _tCC_TichLuy, _khac_Cu, _khac_Vao, _khac_CVien, _khac_Ra, _khac_TVong, _khac_HienCo, _khac_TichLuy, _khac_Cu1, _khac_Vao1, _khac_CVien1, _khac_Ra1, _khac_TVong1, _khac_HienCo1, _khac_TichLuy1, _benhAnKT_Tot, _benhAnKT_Kha, _benhAnKT_TB, _benhAnKT_Kem, _donThuocKT_Tot, _donThuocKT_Kha, _donThuocKT_TB, _donThuocKT_Kem, _tacHaiThuoc, _taiBien, _dacBiet, _cacHDCM, _deNghiSoYT, _ghiChu, _nguoiSD, _maMay); 

        }


        /// <summary>
        /// Update all changes made on <see cref="DMDichVu_BC" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_BC
            if (IsDirty)
            {

                
                  

                DataProvider.Instance().UpdateBC_THChuyenMon(_maBC,_tuNgay, _denNgay, _loaiBC, _giuongKH, _giuongTT, _solanKham_KKB, _solanKham_PhuongXa, _solanKham_KhuVuc, _solanKham_DuPhong, _solanKhamCC, _solanKhamCC_DUOI6TUOI, _solanKhamCC_NGOAITINH, _solanKhamCC_BH, _solanKhamCC_YC, _solanKhamCC_NN, _solanKhamCC_MF, _solanKhamCC_TE, _songuoikham_KKB, _songuoikham_NN, _songuoikham_DUOI6TUOI, _songuoikham_NBNgoaiTinh, _songuoiKham_PhuongXa, _songuoiKham_KhuVuc, _songuoiKham_DuPhong, _songuoiDTNgoaitru, _songayDTNgoaitru, _tainanGiaothong, _tainanGiaothong_NBTuVong, _tainanGiaothong_PHAUTHUATCHANTHUONG, _tainanGiaothong_PHAUTHUATCHINHHINH, _tainanSinhhoat, _tainanLaodong, _phauThuat_KH, _phauThuat_CC, _tHUTHUAT_KH, _tHUTHUAT_CC, _cHUYENVIEN_NOITRU, _cHUYENVIEN_NGOAITRU, _tUVONG_NGUOILON, _tUVONG_DUOI5TUOI, _tUVONG_TREN5TUOI, _tUVONG_NOITRU, _tUVONG_KKB, _cHETTRUOC24H_NGUOILON, _cHETTRUOC24H_DUOI5TUOI, _cHETTRUOC24H_TU5DEN15TUOI, _cHETTRUOC24H_NOITRU, _cHETTRUOC24H_KKB, _tIEUBANXETNGHIEM, _cHANDOANHINHANH, _chieuXQ, _chupXQ, _sIEUAM, _scanner, _xQKhac, _sIEUAMKHAC, _tHAMDOCHUCNANG, _dIENTIM, _dienNao, _noiSoi, _tDCNKhac, _sOBENHANDAKIEMTRA, _sONGUOIBENHDAUKY, _sONGUOIBENHVAOVIEN, _sONGUOIBENHVAOVIEN_BH, _sONGUOIBENHVAOVIEN_KHONGBH, _sONGUOIBENHVAOVIEN_NGUOINGHEO, _sONGUOIBENHVAOVIEN_DUOI6TUOI, _sONGUOIBENHVAOVIEN_6DEN15TUOI, _sONGUOIBENHVAOVIEN_NGOAITINH, _sONGUOIBENHRAVIEN, _sONGUOIBENHCONLAI, _sONGUOIBENHCONLAI_BH, _sONGUOIBENHCONLAI_KHONGBH, _sONGUOIBENHCONLAI_DUOI6TUOI, _sONGUOIBENHCONLAI_TU6DEN15TUOI, _tONGSONGAYDIEUTRI, _tONGSONGAYDIEUTRI_RAVIEN, _tONGGIUONG, _sXH_Cu, _sXH_Vao, _sXH_CVien, _sXH_Ra, _sXH_TVong, _sXH_HienCo, _sXH_TichLuy, _tCC_Cu, _tCC_Vao, _tCC_CVien, _tCC_Ra, _tCC_TVong, _tCC_HienCo, _tCC_TichLuy, _khac_Cu, _khac_Vao, _khac_CVien, _khac_Ra, _khac_TVong, _khac_HienCo, _khac_TichLuy, _khac_Cu1, _khac_Vao1, _khac_CVien1, _khac_Ra1, _khac_TVong1, _khac_HienCo1, _khac_TichLuy1, _benhAnKT_Tot, _benhAnKT_Kha, _benhAnKT_TB, _benhAnKT_Kem, _donThuocKT_Tot, _donThuocKT_Kha, _donThuocKT_TB, _donThuocKT_Kem, _tacHaiThuoc, _taiBien, _dacBiet, _cacHDCM, _deNghiSoYT, _ghiChu, _nguoiSD, _huy, _maMay);

            }
        }
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maBC , _nguoiSD, _maMay));
        }


        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_BC
            DataProvider.Instance().DeleteBC_THChuyenMon(crit.mabc  , crit.NguoiSD, crit.MaMay);

        }

        #endregion
    }

        #endregion
}
