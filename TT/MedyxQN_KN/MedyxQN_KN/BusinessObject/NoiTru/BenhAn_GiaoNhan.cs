// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_GiaoNhan
// Kieu doi tuong  :	BenhAn_GiaoNhan
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	4/2/2009 3:21:38 PM
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
using HTC.Business.CategoryList;

namespace HTC.Business.NoiTru
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="BenhAn_GiaoNhan" /> Business Object.
	/// </summary>
	
	[Serializable()]
    public partial class BenhAn_GiaoNhan : BusinessBase<BenhAn_GiaoNhan>
	{
        #region Business Methods

        #region State Fields
        private String _MaPhieuGN = String.Empty;
        private String _MaPhieuGN_C = String.Empty;
        private String _MaQL = String.Empty;
        private String _MaKhoa = String.Empty;
        private SmartDate _giaTriTN = new SmartDate(true);
        private String _maBN = String.Empty;
        private String _hoten = String.Empty;
        private String _sothe = String.Empty;
        private String _maBV = String.Empty;
        private SmartDate _giaTriDN = new SmartDate(true);
        private String _maDT = String.Empty;
        private String _diaChi = String.Empty;
        private String _diaChiC = String.Empty;
        private String _dienThoai = String.Empty;
        private String _dTDD = String.Empty;
        private String _dTCQ = String.Empty;
        private String _mail = String.Empty;
        private Byte _tuoi = 1;
        private int _thang = 1;
        private SmartDate _ngaySinh = new SmartDate(true);
        private SmartDate _ngaySinhD = new SmartDate(true);
        private SmartDate _ngayyc = new SmartDate(true);
        private Boolean _gt = false;
        private Boolean _gtNu = false;
        private String _baoTin = String.Empty;
        private String _maQG = String.Empty;
        private String _maTinh = String.Empty;
        private String _maHuyen = String.Empty;
        private String _maNN = String.Empty;
        private String _tienSu = String.Empty;
        private String _tienSuThuoc = String.Empty;
        private String _tienSuGiaDinh = String.Empty;
        private String _nhomMau = String.Empty;
        private String _maBANoiT = String.Empty;
        private String _maKhoaVV = String.Empty;
        private SmartDate _ngayVV = new SmartDate(true);
        private SmartDate _ngayRaVien = new SmartDate(true);
        private String _maBAQL = String.Empty;
        private SmartDate _ngayKham = new SmartDate(true);
        private String _ghichu = String.Empty;
        private String _maMay = String.Empty;
        private SmartDate _ngayLap = new SmartDate(true);
        private String _nguoiLap = String.Empty;
        private SmartDate _ngayHuy = new SmartDate(true);
        private String _nguoiHuy = String.Empty;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private SmartDate _ngaySD1 = new SmartDate(true);
        private String _nguoiSD1 = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngayBANgoaiT = new SmartDate(true);
        private string _mabaluu = String.Empty;
        private String _madantoc = String.Empty;
        private String _hotenbome = String.Empty;
        private int _OrderNumber;
        private String _mabhxh = String.Empty;
        private String _tenbv = String.Empty;
        private String _TenKhoa = String.Empty;
        private SmartDate _NgayRaVien = new SmartDate(true);
        private String _MAICD = string.Empty;
        private String _TenBenh = string.Empty;
        private Int32 _ToTal;
        private String thoihan = String.Empty;
        private Int32 _NgayQuaHan;
        #endregion

        #region Business Properties and Methods
        public String MaPhieuGN
        {
            get
            {
                CanReadProperty("MaPhieuGN", true);
                return _MaPhieuGN;
            }
            set
            {
                CanWriteProperty("MaPhieuGN", true);
                if (_MaPhieuGN != value)
                {
                    _MaPhieuGN = value;
                    PropertyHasChanged("MaPhieuGN");
                }
            }
        }
        public String MaPhieuGN_C
        {
            get
            {
                CanReadProperty("MaPhieuGN_C", true);
                return _MaPhieuGN_C;
            }
            set
            {
                CanWriteProperty("MaPhieuGN_C", true);
                if (_MaPhieuGN_C != value)
                {
                    _MaPhieuGN_C = value;
                    PropertyHasChanged("MaPhieuGN_C");
                }
            }
        }
        public String MaQL
        {
            get
            {
                CanReadProperty("MaQL", true);
                return _MaQL;
            }
            set
            {
                CanWriteProperty("MaQL", true);
                if (_MaQL != value)
                {
                    _MaQL = value;
                    PropertyHasChanged("MaQL");
                }
            }
        }
        public Int32 ToTal
        {
            get
            {
                CanReadProperty("ToTal", true);
                return _ToTal;
            }
            set
            {
                CanWriteProperty("ToTal", true);
                if (_ToTal != value)
                {
                    _ToTal = value;
                    PropertyHasChanged("ToTal");
                }
            }
        }
        public String TenKhoa
        {
            get
            {
                CanReadProperty("TENKHOAHT", true);
                return _TenKhoa;
            }
            set
            {
                CanWriteProperty("TENKHOAHT", true);
                if (_TenKhoa != value)
                {
                    _TenKhoa = value;
                    PropertyHasChanged("TENKHOAHT");
                }
            }
        }
        public String MaKhoa
        {
            get
            {
                CanReadProperty("MaKhoa", true);
                return _MaKhoa;
            }
            set
            {
                CanWriteProperty("MaKhoa", true);
                if (_MaKhoa != value)
                {
                    _MaKhoa = value;
                    PropertyHasChanged("MaKhoa");
                }
            }
        }
        public String TenBenh
        {
            get
            {
                CanReadProperty("tenbenhRAVIEN", true);
                return _TenBenh;
            }
            set
            {
                CanWriteProperty("tenbenhRAVIEN", true);
                if (_TenBenh != value)
                {
                    _TenBenh = value;
                    PropertyHasChanged("tenbenhRAVIEN");
                }
            }
        }
        public String ThoiHan
        {
            get
            {
                CanReadProperty("thoihan", true);
                return thoihan;
            }
            set
            {
                CanWriteProperty("thoihan", true);
                if (thoihan != value)
                {
                    thoihan = value;
                    PropertyHasChanged("thoihan");
                }
            }
        }
        public String MAICD
        {
            get
            {
                CanReadProperty("MAICDVV", true);
                return _MAICD;
            }
            set
            {
                CanWriteProperty("MAICDVV", true);
                if (_MAICD != value)
                {
                    _MAICD = value;
                    PropertyHasChanged("MAICDVV");
                }
            }
        }
        public string NgayRaVien
        {
            get
            {
                CanReadProperty("NGAYRAVIEN", true);
                _NgayRaVien.FormatString = "dd/MM/yyyy";
                return _NgayRaVien.Text;
            }
            set
            {
                CanWriteProperty("NGAYRAVIEN", true);
                if (_NgayRaVien.Text != value)
                {
                    _NgayRaVien.Text = value;
                    PropertyHasChanged("NGAYRAVIEN");
                }
            }
        }
        public String mabaluu
        {
            get
            {
                CanReadProperty("mabaluu", true);
                return _mabaluu;
            }
            set
            {
                CanWriteProperty("mabaluu", true);
                if (_mabaluu != value)
                {
                    _mabaluu = value;
                    PropertyHasChanged("mabaluu");
                }
            }
        }
        public string GiaTriTN
        {
            get
            {
                CanReadProperty("GiaTriTN", true);
                return _giaTriTN.Text;
            }
            set
            {
                CanWriteProperty("GiaTriTN", true);
                if (_giaTriTN.Text != value)
                {
                    _giaTriTN.Text = value;
                    PropertyHasChanged("GiaTriTN");
                }
            }
        }
        public String mabhxh
        {
            get
            {
                CanReadProperty("mabhxh", true);
                return _mabhxh;
            }
            set
            {
                CanWriteProperty("mabhxh", true);
                if (_mabhxh != value)
                {
                    _mabhxh = value;
                    PropertyHasChanged("mabhxh");
                }
            }
        }
        public String gioitinh
        {
            get
            {
                if (_gt == false)
                    return "Nữ";
                else
                    return "Nam";
            }

        }
        public String hotenbome
        {
            get
            {
                CanReadProperty("hotenbome", true);
                return _hotenbome;
            }
            set
            {
                CanWriteProperty("hotenbome", true);
                if (_hotenbome != value)
                {
                    _hotenbome = value;
                    PropertyHasChanged("hotenbome");
                }
            }
        }
        public String madantoc
        {
            get
            {
                CanReadProperty("madantoc", true);
                return _madantoc;
            }
            set
            {
                CanWriteProperty("madantoc", true);
                if (_madantoc != value)
                {
                    _madantoc = value;
                    PropertyHasChanged("madantoc");
                }
            }
        }
        public String tenbv
        {
            get
            {
                CanReadProperty("tenbv", true);
                return _tenbv;
            }
            set
            {
                CanWriteProperty("tenbv", true);
                if (_tenbv != value)
                {
                    _tenbv = value;
                    PropertyHasChanged("tenbv");
                }
            }
        }
        public String Sothe
        {
            get
            {
                CanReadProperty("Sothe", true);
                return _sothe;
            }
            set
            {
                CanWriteProperty("Sothe", true);
                if (_sothe != value)
                {
                    _sothe = value;
                    PropertyHasChanged("Sothe");
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

        public String Hoten
        {
            get
            {
                CanReadProperty("Hoten", true);
                return _hoten.ToUpper();
            }
            set
            {
                CanWriteProperty("Hoten", true);
                if (_hoten != value)
                {
                    _hoten = value;
                    PropertyHasChanged("Hoten");
                }
            }
        }

        //public String Sothe
        //{
        //    get 
        //    {
        //        CanReadProperty("Sothe", true);
        //        return _sothe;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("Sothe", true);
        //        if (_sothe != value) 
        //        {
        //            _sothe = value;
        //            PropertyHasChanged("Sothe");
        //        }
        //    }
        //}

        public String MaBV
        {
            get
            {
                CanReadProperty("MaBV", true);
                return _maBV;
            }
            set
            {
                CanWriteProperty("MaBV", true);
                if (_maBV != value)
                {
                    _maBV = value;
                    PropertyHasChanged("MaBV");
                }
            }
        }

        public string GiaTriDN
        {
            get
            {
                CanReadProperty("GiaTriDN", true);
                return _giaTriDN.Text;
            }
            set
            {
                CanWriteProperty("GiaTriDN", true);
                if (_giaTriDN.Text != value)
                {
                    _giaTriDN.Text = value;
                    PropertyHasChanged("GiaTriDN");
                }
            }
        }

        public String DiaChi
        {
            get
            {
                CanReadProperty("DiaChi", true);

                return _diaChi;
            }
            set
            {
                CanWriteProperty("DiaChi", true);
                if (_diaChi != value)
                {
                    _diaChi = value;
                    PropertyHasChanged("DiaChi");
                }
            }
        }
        public String DiaChiC
        {
            get
            {
                CanReadProperty("DiaChiC", true);

                return _diaChiC;
            }
            set
            {
                CanWriteProperty("DiaChiC", true);
                if (_diaChiC != value)
                {
                    _diaChiC = value;
                    PropertyHasChanged("DiaChiC");
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

        public String DTDD
        {
            get
            {
                CanReadProperty("DTDD", true);
                return _dTDD;
            }
            set
            {
                CanWriteProperty("DTDD", true);
                if (_dTDD != value)
                {
                    _dTDD = value;
                    PropertyHasChanged("DTDD");
                }
            }
        }

        public String DTCQ
        {
            get
            {
                CanReadProperty("DTCQ", true);
                return _dTCQ;
            }
            set
            {
                CanWriteProperty("DTCQ", true);
                if (_dTCQ != value)
                {
                    _dTCQ = value;
                    PropertyHasChanged("DTCQ");
                }
            }
        }

        public String Mail
        {
            get
            {
                CanReadProperty("Mail", true);
                return _mail;
            }
            set
            {
                CanWriteProperty("Mail", true);
                if (_mail != value)
                {
                    _mail = value;
                    PropertyHasChanged("Mail");
                }
            }
        }

        public byte Tuoi
        {
            get
            {

                //CanReadProperty("Tuoi", true);
                if (_ngaySinh.Date != DateTime.MinValue)
                    if (_ngaySinh.Date.Year != 0)
                        _tuoi = Convert.ToByte(Convert.ToInt32(DateTime.Now.Year) - _ngaySinh.Date.Year);
                return _tuoi;
            }
            set
            {
                CanWriteProperty("Tuoi", true);
                if (_tuoi != value)
                {
                    _tuoi = value;
                    PropertyHasChanged("Tuoi");
                }
            }
        }
        public int thang
        {
            get
            {

                //CanReadProperty("thang", true);
                if (Convert.ToInt32(DateTime.Now.Month - _ngaySinh.Date.Month) < 0)
                    _thang = Convert.ToInt32(DateTime.Now.Month - _ngaySinh.Date.Month + 13);
                else
                    _thang = Convert.ToInt32(DateTime.Now.Month - _ngaySinh.Date.Month + 1);
                return _thang;
            }
            set
            {
                CanWriteProperty("thang", true);
                if (_thang != value)
                {
                    _thang = value;
                    PropertyHasChanged("thang");
                }
            }
        }
        public string NgaySinh
        {
            get
            {
                CanReadProperty("NgaySinh", true);
                _ngaySinh.FormatString = "MM/dd/yyyy";
                return _ngaySinh.Text;
            }
            set
            {
                CanWriteProperty("NgaySinh", true);
                if (_ngaySinh.Text != value)
                {
                    _ngaySinh.Text = value;
                    if (_ngaySinh.Date.Year != 1)
                        _tuoi = Convert.ToByte(Convert.ToInt32(DateTime.Now.Year) - _ngaySinh.Date.Year);
                    PropertyHasChanged("NgaySinh");
                }
            }
        }
        public string NgaySinhD
        {
            get
            {
                CanReadProperty("NgaySinh", true);
                _ngaySinhD = _ngaySinh;
                _ngaySinhD.FormatString = "dd/MM/yyyy";
                return _ngaySinh.Text;
            }

        }
        public Boolean GT
        {
            get
            {
                CanReadProperty("GT", true);
                return _gt;
            }
            set
            {
                CanWriteProperty("GT", true);
                if (_gt != value)
                {
                    _gt = value;
                    PropertyHasChanged("GT");
                }
            }
        }
        public Boolean GTNu
        {
            get
            {
                CanReadProperty("GTNu", true);
                if (_gt == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("GTNu", true);
                if (_gtNu != value)
                {
                    if (value == true)
                        _gt = false;
                    else
                        _gt = true;
                    _gtNu = value;

                    PropertyHasChanged("GTnu");
                }

            }
        }
        public String BaoTin
        {
            get
            {
                CanReadProperty("BaoTin", true);
                return _baoTin;
            }
            set
            {
                CanWriteProperty("BaoTin", true);
                if (_baoTin != value)
                {
                    _baoTin = value;
                    PropertyHasChanged("BaoTin");
                }
            }
        }

        public String MaQG
        {
            get
            {
                CanReadProperty("MaQG", true);
                return _maQG;
            }
            set
            {
                CanWriteProperty("MaQG", true);
                if (_maQG != value)
                {
                    _maQG = value;
                    PropertyHasChanged("MaQG");
                }
            }
        }
       
        public String MaTinh
        {
            get
            {
                CanReadProperty("MaTinh", true);
                return _maTinh;
            }
            set
            {
                CanWriteProperty("MaTinh", true);
                if (_maTinh != value)
                {
                    _maTinh = value;
                    PropertyHasChanged("MaTinh");
                }
            }
        }

        public String MaHuyen
        {
            get
            {
                CanReadProperty("MaHuyen", true);
                return _maHuyen;
            }
            set
            {
                CanWriteProperty("MaHuyen", true);
                if (_maHuyen != value)
                {
                    _maHuyen = value;
                    PropertyHasChanged("MaHuyen");
                }
            }
        }

        public String MaNN
        {
            get
            {
                CanReadProperty("MaNN", true);
                return _maNN;
            }
            set
            {
                CanWriteProperty("MaNN", true);
                if (_maNN != value)
                {
                    _maNN = value;
                    PropertyHasChanged("MaNN");
                }
            }
        }

        public String TienSu
        {
            get
            {
                CanReadProperty("TienSu", true);
                return _tienSu;
            }
            set
            {
                CanWriteProperty("TienSu", true);
                if (_tienSu != value)
                {
                    _tienSu = value;
                    PropertyHasChanged("TienSu");
                }
            }
        }

        public String TienSuThuoc
        {
            get
            {
                CanReadProperty("TienSuThuoc", true);
                return _tienSuThuoc;
            }
            set
            {
                CanWriteProperty("TienSuThuoc", true);
                if (_tienSuThuoc != value)
                {
                    _tienSuThuoc = value;
                    PropertyHasChanged("TienSuThuoc");
                }
            }
        }

        public String TienSuGiaDinh
        {
            get
            {
                CanReadProperty("TienSuGiaDinh", true);
                return _tienSuGiaDinh;
            }
            set
            {
                CanWriteProperty("TienSuGiaDinh", true);
                if (_tienSuGiaDinh != value)
                {
                    _tienSuGiaDinh = value;
                    PropertyHasChanged("TienSuGiaDinh");
                }
            }
        }

        public String NhomMau
        {
            get
            {
                CanReadProperty("NhomMau", true);
                return _nhomMau;
            }
            set
            {
                CanWriteProperty("NhomMau", true);
                if (_nhomMau != value)
                {
                    _nhomMau = value;
                    PropertyHasChanged("NhomMau");
                }
            }
        }

        public String MaBANoiT
        {
            get
            {
                CanReadProperty("MaBANoiT", true);
                return _maBANoiT;
            }
            set
            {
                CanWriteProperty("MaBANoiT", true);
                if (_maBANoiT != value)
                {
                    _maBANoiT = value;
                    PropertyHasChanged("MaBANoiT");
                }
            }
        }

        public String MaKhoaVV
        {
            get
            {
                CanReadProperty("MaKhoaVV", true);
                return _maKhoaVV;
            }
            set
            {
                CanWriteProperty("MaKhoaVV", true);
                if (_maKhoaVV != value)
                {
                    _maKhoaVV = value;
                    PropertyHasChanged("MaKhoaVV");
                }
            }
        }

        public string NgayVV
        {
            get
            {
                CanReadProperty("NgayVV", true);
                return _ngayVV.Text;
            }
            set
            {
                CanWriteProperty("NgayVV", true);
                if (_ngayVV.Text != value)
                {
                    _ngayVV.Text = value;
                    PropertyHasChanged("NgayVV");
                }
            }
        }
        public String MaBAQL
        {
            get
            {
                CanReadProperty("MaBAQL", true);
                return _maBAQL;
            }
            set
            {
                CanWriteProperty("MaBAQL", true);
                if (_maBAQL != value)
                {
                    _maBAQL = value;
                    PropertyHasChanged("MaBAQL");
                }
            }
        }

        public string NgayKham
        {
            get
            {
                CanReadProperty("NgayKham", true);
                _ngayKham.FormatString = "dd/MM/yyyy";
                return _ngayKham.Text;
            }
            set
            {
                CanWriteProperty("NgayKham", true);
                if (_ngayKham.Text != value)
                {
                    _ngayKham.FormatString = "dd/MM/yyyy";
                    _ngayKham.Text = value;
                    PropertyHasChanged("NgayKham");
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

        public string NgayLap
        {
            get
            {
                CanReadProperty("NgayLap", true);
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

        public string NgayBANgoaiT
        {
            get
            {
                CanReadProperty("NgayBANgoaiT", true);
                return _ngayBANgoaiT.Text;
            }
            set
            {
                CanWriteProperty("NgayBANgoaiT", true);
                if (_ngayBANgoaiT.Text != value)
                {
                    _ngayBANgoaiT.Text = value;
                    PropertyHasChanged("NgayBANgoaiT");
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
        public Int32 NgayQuaHan
        {
            get
            {
                CanReadProperty("NgayQuaHan", true);
                return _NgayQuaHan;
            }
            set
            {
                CanWriteProperty("NgayQuaHan", true);
                if (_NgayQuaHan != value)
                {
                    _NgayQuaHan = value;
                    PropertyHasChanged("NgayQuaHan");
                }
            }
        }
        protected override Object GetIdValue()
        {
            return _maBN;
        }
        //public override bool IsDirty
        //{
        //    get
        //    {
        //        return base.IsDirty; 
        //    }
        //}

        //public override bool IsValid
        //{
        //    get
        //    {
        //        return base.IsValid;
        //    }
        //}
        #endregion
        #endregion


        #region Business Object Rules and Validation

        #endregion

        #region Factory Methods
        protected internal BenhAn_GiaoNhan()
        {
            // Prevent direct creation
        }
        internal BenhAn_GiaoNhan(int OrderNumber,
            String MaPhieuGN, String MaPhieuGN_C, String MaKhoa,
  String maDT,
  String hoten,
  String sothe,
  String maBV,
  SmartDate giaTriDN,
  String diaChi,
  String diaChiC,
  String dienThoai,
  String dTDD,
  String dTCQ,
  String mail,
  Byte tuoi,
  SmartDate ngaySinh,
  Boolean gt,
  String baoTin,
  String maQG,
  String maTinh,
  String maHuyen,
  String maNN,
  String tienSu,
  String tienSuThuoc,
  String tienSuGiaDinh,
  String nhomMau,
  String maBANoiT,
  //String maKhoaVV,
 // SmartDate ngayVV,
  String maBAQL,
  //SmartDate ngayKham,
  String ghichu,
  String maMay,
  SmartDate ngayLap,
  String nguoiLap,
  SmartDate ngayHuy,
  String nguoiHuy,
  SmartDate ngaySD,
  String nguoiSD,
  SmartDate ngayvv,
  
  Boolean huy,
 // SmartDate ngayBANgoaiT,
  string mabhxh,
  string maBN,
  string tenbv,
 
                             SmartDate giatriTN,
            string mabaluu, string TenKhoa, SmartDate NgayRaVien, string MAICD, string TenBenh, int ToTal, String MaQL,String Thoihan, Int32 NgayQuaHan)
        { 
            _OrderNumber = OrderNumber ;
            _MaPhieuGN = MaPhieuGN;
            _MaPhieuGN_C = MaPhieuGN_C;
            _MaKhoa = MaKhoa;
            _maDT = maDT;
            _hoten = hoten  ;
            _sothe = sothe  ;
            _maBV = maBV  ;
            if(giaTriDN!=null) _giaTriDN = giaTriDN  ;
            _diaChi = diaChi  ;
            _diaChiC = diaChiC;
            _mabaluu =mabaluu ;
            _dienThoai = dienThoai  ;
            _dTDD = dTDD  ;
            _dTCQ = dTCQ  ;
            _mail = mail  ;
            _tuoi = tuoi  ;
            if(ngaySinh!=null) _ngaySinh = ngaySinh ;
            _gt = gt  ;
            _baoTin = baoTin  ;
            _maQG = maQG  ;
            _maTinh = maTinh  ;
            _maHuyen = maHuyen  ;
            _maNN = maNN  ;
            _tienSu = tienSu  ;
            _tienSuThuoc = tienSuThuoc  ;
            _tienSuGiaDinh = tienSuGiaDinh  ;
            _nhomMau = nhomMau  ;
            _maBANoiT = maBANoiT  ;
            _maBAQL = maBAQL  ;
            _ghichu = ghichu  ;
            _maMay = maMay  ;
            if(ngayLap!=null) _ngayLap = ngayLap;
            _nguoiLap = nguoiLap  ;
            if (ngayHuy != null) _ngayHuy = ngayHuy;
            _nguoiHuy = nguoiHuy  ;
            if (ngaySD != null) _ngaySD = ngaySD;
            _nguoiSD  = nguoiSD ;
            if (ngayvv != null) _ngayVV = ngayvv;
            _huy = huy  ;
            _mabhxh = mabhxh;
            _maBN = maBN;
            _tenbv = tenbv;
            if (giatriTN != null) _giaTriTN = giatriTN;
            _TenKhoa = TenKhoa;
            _NgayRaVien = NgayRaVien;
            _MAICD = MAICD;
            _TenBenh = TenBenh;
            _ToTal = ToTal;
            _MaQL = MaQL;
            thoihan = Thoihan;
            _NgayQuaHan = NgayQuaHan;
        }
        /// <summary>
        /// Factory method. New <see cref="BenhAn_GiaoNhan" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static BenhAn_GiaoNhan NewBenhAn_GiaoNhan()
        {
            return new BenhAn_GiaoNhan();
        }
        #endregion
    }
}
