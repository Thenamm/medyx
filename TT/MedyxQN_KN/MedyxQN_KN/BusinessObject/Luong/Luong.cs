// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	Luong
// Kieu doi tuong  :	Luong
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	12/29/2009 9:27:28 AM
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

namespace HTC.Business.Luong
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="Luong" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class Luong : BusinessBase<Luong>
	{
		#region Business Methods
		
		#region State Fields
		
		private Int32 _sTT = 0;
		private SmartDate _thang = new SmartDate(true);
		private String _maNV = String.Empty;
		private String _makhoa = String.Empty;
        private Decimal _heSoChucVu = 0;
        private Decimal _heSo = 0;
        private Decimal _heSoLamDem = 0;
        private Decimal _heSoNgoaiGio = 0;
        private Decimal _heSoNgoaiGio7 = 0;
        private Decimal _heSoNgoaiGioLe = 0;
        private Decimal _donGiaAnTrua = 0;
        private Decimal _donGiaAnToi = 0;
        private Decimal _dienThoai = 0;
        private Decimal _congTac = 0;
        private Decimal _donGiaXQuang = 0;
        private Decimal _mucLuongCB = 0;
        private Decimal _LuongABC = 0;
        private Decimal _mucMGthueTNhap = 0; //da tinh toan trong store
        private String _maMGThueThuNhap = String.Empty;
        private Decimal _heSoDongThueThuNhap = 0;
        private Decimal _mucTTThue = 0;
        private Decimal _luongKhac = 0;
        private String _ghiChu = String.Empty;
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
        private String _hoten = String.Empty;
        private String _tenChuyenMon = String.Empty;
        private String _tenLoaiHD = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private SmartDate _ngaySinh = new SmartDate(true);
        private Boolean _gioitinh = false;
        private String _gioitinhD = String.Empty;
        private Decimal _TongCongHC;
        private Decimal _hanhChinh;
        private Decimal _phep;
        private Decimal _om;
        private Decimal _luyKe;
        private Decimal _ngoaiGio;
        private Decimal _ngoaiGio7;
        private Decimal _ngoaiGioLe;
        private Decimal _XQuang;
        private string _ABC;
        private Decimal _congAnToi;
        private Decimal _congAnTrua;
        private Decimal _congLamDem;
        private Decimal _luongTT = 0;
        private Decimal _luongTMCT = 0;
        private Decimal _luongTruc = 0;
        private Decimal _luongM1 = 0;
        private Decimal _luongM2 = 0;
        private Decimal _luongPT = 0;
        private Decimal _luongNghe = 0;
        private Decimal _luongNgoaiGio = 0; //luong ngoai gio thu 7
        private Decimal _luongNgoaiGio1 = 0; //luong ngoai gio 
        private Decimal _luongDocHai = 0;
        private Decimal _luongHoiChan = 0;
        private Decimal _luongBoiDuongPT = 0;
        private String _tenKhoa = String.Empty;
        private String _tenMGThueTNhap = String.Empty;
        private Decimal _tienKhauTru = 0;
        private Decimal _luongKyI = 0;
        private Decimal _luongKyII = 0;
        private Decimal _luongKyIthue = 0;
        private Decimal _luongKyIIthue = 0;
        private Decimal _tongTU = 0;
        private Decimal _tienPhaiTinhThue = 0;
        private Decimal _tienPhaiNopThue = 0;
        private Decimal _tienLinhDotII = 0;

        //private Decimal _tong = 0;

        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
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
		
		public string Thang
		{
			get 
			{
				CanReadProperty("Thang", true);
				return _thang.Text;
			}
			set 
			{
				CanWriteProperty("Thang", true);
				if (_thang.Text != value) 
				{
					_thang.Text = value;
					PropertyHasChanged("Thang");
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
        public String MaKhoa
        {
            get
            {
                CanReadProperty("MaKhoa", true);
                return _makhoa;
            }
            set
            {
                CanWriteProperty("MaKhoa", true);
                if (_makhoa != value)
                {
                    _makhoa = value;
                    PropertyHasChanged("MaKhoa");
                }
            }
        }

        public String HeSoChucVu
        {
            get
            {
                CanReadProperty("HeSoChucVu", true);
                if (_heSoChucVu == 0)
                {
                    return "";
                }
                else
                {
                    return _heSoChucVu.ToString("###,##0.00");
                }
            }
            set
            {
                CanWriteProperty("HeSoChucVu", true);
                if (_heSoChucVu.ToString() != value)
                {
                    if (value == "")
                        _heSoChucVu = 0;
                    else
                        _heSoChucVu = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("heSoChucVu");
                }
            }
        }

        public String HeSo
        {
            get
            {
                CanReadProperty("HeSo", true);
                if (_heSo == 0)
                {
                    return "";
                }
                else
                {
                    return _heSo.ToString("###,##0.00");
                }
            }
            set
            {
                CanWriteProperty("HeSo", true);
                if (_heSo.ToString() != value)
                {
                    if (value == "")
                        _heSo = 0;
                    else
                        _heSo = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("HeSo");
                }
            }
        }

        public String HeSoLamDem
        {
            get
            {
                CanReadProperty("HeSoLamDem", true);
                if (_heSoLamDem == 0)
                {
                    return "";
                }
                else
                {
                    return _heSoLamDem.ToString("###,##0.00");
                }
            }
            set
            {
                CanWriteProperty("HeSoLamDem", true);
                if (_heSoLamDem.ToString() != value)
                {
                    if (value == "")
                        _heSoLamDem = 0;
                    else
                        _heSoLamDem = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("HeSoLamDem");
                }
            }
        }

        public String HeSoNgoaiGio
        {
            get
            {
                CanReadProperty("HeSoNgoaiGio", true);
                if (_heSoNgoaiGio == 0)
                {
                    return "";
                }
                else
                {
                    return _heSoNgoaiGio.ToString("###,##0.00");
                }
            }
            set
            {
                CanWriteProperty("HeSoNgoaiGio", true);
                if (_heSoNgoaiGio.ToString() != value)
                {
                    if (value == "")
                        _heSoNgoaiGio = 0;
                    else
                        _heSoNgoaiGio = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("HeSoNgoaiGio");
                }
            }
        }

        public String HeSoNgoaiGio7
        {
            get
            {
                CanReadProperty("HeSoNgoaiGio7", true);
                if (_heSoNgoaiGio7 == 0)
                {
                    return "";
                }
                else
                {
                    return _heSoNgoaiGio7.ToString("###,##0.00");
                }
            }
            set
            {
                CanWriteProperty("HeSoNgoaiGio7", true);
                if (_heSoNgoaiGio7.ToString() != value)
                {
                    if (value == "")
                        _heSoNgoaiGio7 = 0;
                    else
                        _heSoNgoaiGio7 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("HeSoNgoaiGio7");
                }
            }
        }

        public String HeSoNgoaiGioLe
        {
            get
            {
                CanReadProperty("HeSoNgoaiGioLe", true);
                if (_heSoNgoaiGioLe == 0)
                {
                    return "";
                }
                else
                {
                    return _heSoNgoaiGioLe.ToString("###,##0.00");
                }
            }
            set
            {
                CanWriteProperty("HeSoNgoaiGioLe", true);
                if (_heSoNgoaiGioLe.ToString() != value)
                {
                    if (value == "")
                        _heSoNgoaiGioLe = 0;
                    else
                        _heSoNgoaiGioLe = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("HeSoNgoaiGioLe");
                }
            }
        }

        public String DonGiaAnTrua
        {
            get
            {
                CanReadProperty("DonGiaAnTrua", true);
                if (_donGiaAnTrua == 0)
                {
                    return "";
                }
                else
                {
                    return _donGiaAnTrua.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("DonGiaAnTrua", true);
                if (_donGiaAnTrua.ToString() != value)
                {
                    if (value == "")
                        _donGiaAnTrua = 0;
                    else
                        _donGiaAnTrua = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("THHANHTIENA");
                }
            }
        }

        public String DonGiaAnToi
        {
            get
            {
                CanReadProperty("DonGiaAnToi", true);
                if (_donGiaAnToi == 0)
                {
                    return "";
                }
                else
                {
                    return _donGiaAnToi.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("DonGiaAnToi", true);
                if (_donGiaAnToi.ToString() != value)
                {
                    if (value == "")
                        _donGiaAnToi = 0;
                    else
                        _donGiaAnToi = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaAnToi");
                }
            }
        }

        public String DienThoai
        {
            get
            {
                CanReadProperty("DienThoai", true);
                if (_dienThoai == 0)
                {
                    return "";
                }
                else
                {
                    return _dienThoai.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("DienThoai", true);
                if (_dienThoai.ToString() != value)
                {
                    if (value == "")
                        _dienThoai = 0;
                    else
                        _dienThoai = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DienThoai");
                }
            }
        }

        public String CongTac
        {
            get
            {
                CanReadProperty("CongTac", true);
                if (_congTac == 0)
                {
                    return "";
                }
                else
                {
                    return _congTac.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("CongTac", true);
                if (_congTac.ToString() != value)
                {
                    if (value == "")
                        _congTac = 0;
                    else
                        _congTac = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("CongTac");
                }
            }
        }

        public String DonGiaXQuang
        {
            get
            {
                CanReadProperty("DonGiaXQuang", true);
                if (_donGiaXQuang == 0)
                {
                    return "";
                }
                else
                {
                    return _donGiaXQuang.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("DonGiaXQuang", true);
                if (_donGiaXQuang.ToString() != value)
                {
                    if (value == "")
                        _donGiaXQuang = 0;
                    else
                        _donGiaXQuang = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("THHANHTIENA");
                }
            }
        }

        public String MucLuongCB
        {
            get
            {
                CanReadProperty("MucLuongCB", true);
                if (_mucLuongCB == 0)
                {
                    return "";
                }
                else
                {
                    return _mucLuongCB.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("MucLuongCB", true);
                if (_mucLuongCB.ToString() != value)
                {
                    if (value == "")
                        _mucLuongCB = 0;
                    else
                        _mucLuongCB = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("MucLuongCB");
                }
            }
        }

        public String LuongABC
        {
            get
            {
                CanReadProperty("LuongABC", true);
                if (_LuongABC == 0)
                {
                    return "";
                }
                else
                {
                    return _LuongABC.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("LuongABC", true);
                if (_LuongABC.ToString() != value)
                {
                    if (value == "")
                        _LuongABC = 0;
                    else
                        _LuongABC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("LuongABC");
                }
            }
        }


        public String MucMGThueTNhap
        {
            get
            {
                CanReadProperty("MucMGThueTNhap", true);
                if (_mucMGthueTNhap == 0)
                {
                    return "";
                }
                else
                {
                    return _mucMGthueTNhap.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("MucMGThueTNhap", true);
                if (_mucMGthueTNhap.ToString() != value)
                {
                    if (value == "")
                        _mucMGthueTNhap = 0;
                    else
                        _mucMGthueTNhap = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("MucMGThueTNhap");
                }
            }
        }

        public String MaMGThueThuNhap
        {
            get
            {
                CanReadProperty("MaMGThueThuNhap", true);
                return _maMGThueThuNhap;
            }
            set
            {
                CanWriteProperty("MaMGThueThuNhap", true);
                if (_maMGThueThuNhap != value)
                {
                    _maMGThueThuNhap = value;
                    PropertyHasChanged("MaMGThueThuNhap");
                }
            }
        }

        public String HeSoDongThueThuNhap
        {
            get
            {
                CanReadProperty("HeSoDongThueThuNhap", true);
                _tienPhaiTinhThue = _luongKyIthue + _luongKyIIthue - _tienKhauTru;
                if (_tienPhaiTinhThue > 0)
                {
                    foreach (DMDongThueThuNhap _dmdongthuethunhap in DMDongThueThuNhapList.GetAllDMDongThueThuNhap())
                        if ((_tienPhaiTinhThue >= _dmdongthuethunhap.SoTienTu) && (_tienPhaiTinhThue <= _dmdongthuethunhap.SoTienDen))
                        {
                            _heSoDongThueThuNhap = _dmdongthuethunhap.HeSo;
                            break;
                        }

                }
                if (_heSoDongThueThuNhap == 0)
                {
                    return "";
                }
                else
                {
                    return _heSoDongThueThuNhap.ToString("###,##0.00");
                }
            }
            set
            {
                CanWriteProperty("HeSoDongThueThuNhap", true);
                if (_heSoDongThueThuNhap.ToString() != value)
                {
                    if (value == "")
                        _heSoDongThueThuNhap = 0;
                    else
                        _heSoDongThueThuNhap = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("HeSoDongThueThuNhap");
                }
            }
        }

        public String MucTTThue
        {
            get
            {
                CanReadProperty("MucTTThue", true);
                if (_mucTTThue == 0)
                {
                    return "";
                }
                else
                {
                    return _mucTTThue.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("MucTTThue", true);
                if (_mucTTThue.ToString() != value)
                {
                    if (value == "")
                        _mucTTThue = 0;
                    else
                        _mucTTThue = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("MucTTThue");
                }
            }
        }

        public String LuongKhac
        {
            get
            {
                CanReadProperty("LuongKhac", true);
                if (_luongKhac == 0)
                {
                    return "";
                }
                else
                {
                    return _luongKhac.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("LuongKhac", true);
                if (_luongKhac.ToString() != value)
                {
                    if (value == "")
                        _luongKhac = 0;
                    else
                        _luongKhac = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("LuongKhac");
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
        public String HoTen
        {
            get
            {
                CanReadProperty("HoTen", true);
                return _hoten;
            }
            set
            {
                CanWriteProperty("HoTen", true);
                if (_hoten != value)
                {
                    _hoten = value;
                    PropertyHasChanged("HoTen");
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
        public String TenLoaiHD
        {
            get
            {
                CanReadProperty("TenLoaiHD", true);
                return _tenLoaiHD;
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
        public string NgaySinh
        {
            get
            {
                CanReadProperty("NgaySinh", true);
                return _ngaySinh.Text;
            }
            set
            {
                CanWriteProperty("NgaySinh", true);
                if (_ngaySinh.Text != value)
                {
                    _ngaySinh.Text = value;
                    PropertyHasChanged("NgaySinh");
                }
            }
        }
        public Boolean GioiTinh
        {
            get
            {

                return _gioitinh;
            }
            set
            {
                if (_gioitinh != value)
                {
                    _gioitinh = value;
                }
            }
        }
        public String GioiTinhD
        {
            get
            {

                if (_gioitinh == true)
                {
                    return "Nam";
                }
                else
                    return "Nữ";

            }

        }
        public string HanhChinh
        {
            get
            {
                CanReadProperty("HanhChinh", true);
                if (_hanhChinh == 0)
                {
                    return "";
                }
                else
                {
                    return _hanhChinh.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("HanhChinh", true);

                if (_hanhChinh.ToString() != value)
                {
                    if (value == "")
                        _hanhChinh = 0;
                    else
                        _hanhChinh = Decimal.Parse(value);
                    PropertyHasChanged("HanhChinh");
                }
            }
        }
        public string TongCongHC
        {
            get
            {
                CanReadProperty("TongCongHC", true);
                if (_TongCongHC == 0)
                {
                    return "";
                }
                else
                {
                    return _TongCongHC.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("TongCongHC", true);

                if (_TongCongHC.ToString() != value)
                {
                    if (value == "")
                        _TongCongHC = 0;
                    else
                        _TongCongHC = Decimal.Parse(value);
                    PropertyHasChanged("TongCongHC");
                }
            }
        }
        public string Phep
        {
            get
            {
                CanReadProperty("Phep", true);
                if (_phep == 0)
                {
                    return "";
                }
                else
                {
                    return _phep.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("Phep", true);

                if (_phep.ToString() != value)
                {
                    if (value == "")
                        _phep = 0;
                    else
                        _phep = Decimal.Parse(value);
                    PropertyHasChanged("Phep");
                }
            }
        }

        public string LuyKe
        {
            get
            {
                CanReadProperty("LuyKe", true);
                if (_luyKe == 0)
                {
                    return "";
                }
                else
                {
                    return _luyKe.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("LuyKe", true);

                if (_luyKe.ToString() != value)
                {
                    if (value == "")
                        _luyKe = 0;
                    else
                        _luyKe = Decimal.Parse(value);
                    PropertyHasChanged("LuyKe");
                }
            }
        }

        public string Om
        {
            get
            {
                CanReadProperty("Om", true);
                if (_om == 0)
                {
                    return "";
                }
                else
                {
                    return _om.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("Om", true);

                if (_om.ToString() != value)
                {
                    if (value == "")
                        _om = 0;
                    else
                        _om = Decimal.Parse(value);
                    PropertyHasChanged("Om");
                }
            }
        }

        public string NgoaiGio
        {
            get
            {
                CanReadProperty("NgoaiGio", true);
                if (_ngoaiGio == 0)
                {
                    return "";
                }
                else
                {
                    return _ngoaiGio.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("NgoaiGio", true);

                if (_ngoaiGio.ToString() != value)
                {
                    if (value == "")
                        _ngoaiGio = 0;
                    else
                        _ngoaiGio = Decimal.Parse(value);
                    PropertyHasChanged("NgoaiGio");
                }
            }
        }

        public string NgoaiGio7
        {
            get
            {
                CanReadProperty("NgoaiGio7", true);
                if (_ngoaiGio7 == 0)
                {
                    return "";
                }
                else
                {
                    return _ngoaiGio7.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("NgoaiGio7", true);

                if (_ngoaiGio7.ToString() != value)
                {
                    if (value == "")
                        _ngoaiGio7 = 0;
                    else
                        _ngoaiGio7 = Decimal.Parse(value);
                    PropertyHasChanged("NgoaiGio7");
                }
            }
        }

        public string NgoaiGioLe
        {
            get
            {
                CanReadProperty("NgoaiGioLe", true);
                if (_ngoaiGioLe == 0)
                {
                    return "";
                }
                else
                {
                    return _ngoaiGioLe.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("NgoaiGioLe", true);

                if (_ngoaiGioLe.ToString() != value)
                {
                    if (value == "")
                        _ngoaiGioLe = 0;
                    else
                        _ngoaiGioLe = Decimal.Parse(value);
                    PropertyHasChanged("NgoaiGioLe");
                }
            }
        }

        public string XQuang
        {
            get
            {
                CanReadProperty("XQuang", true);
                if (_XQuang == 0)
                {
                    return "";
                }
                else
                {
                    return _XQuang.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("XQuang", true);

                if (_XQuang.ToString() != value)
                {
                    if (value == "")
                        _XQuang = 0;
                    else
                        _XQuang = Decimal.Parse(value);
                    PropertyHasChanged("XQuang");
                }
            }
        }

        public string ABC
        {
            get
            {
                CanReadProperty("ABC", true);
                //if (_ABC == 0)
                //{
                //    return "";
                //}
                //else
                //{
                return _ABC;
                //}

            }
            set
            {
                CanWriteProperty("ABC", true);

                //if (_ABC.ToString() != value)
                //{
                //    if (value == "")
                //        _ABC = 0;
                //    else
                //        _ABC = Decimal.Parse(value);
                //    PropertyHasChanged("ABC");
                //}
                if (_ABC != value)
                {
                    _ABC = value;
                    PropertyHasChanged("TenMGThueTNhap");
                }
            }
        }

        public string CongAnToi
        {
            get
            {
                CanReadProperty("CongAnToi", true);
                if (_congAnToi == 0)
                {
                    return "";
                }
                else
                {
                    return _congAnToi.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("CongAnToi", true);

                if (_congAnToi.ToString() != value)
                {
                    if (value == "")
                        _congAnToi = 0;
                    else
                        _congAnToi = Decimal.Parse(value);
                    PropertyHasChanged("CongAnToi");
                }
            }
        }

        public string CongAnTrua
        {
            get
            {
                CanReadProperty("CongAnTrua", true);
                if (_congAnTrua == 0)
                {
                    return "";
                }
                else
                {
                    return _congAnTrua.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("CongAnTrua", true);

                if (_congAnTrua.ToString() != value)
                {
                    if (value == "")
                        _congAnTrua = 0;
                    else
                        _congAnTrua = Decimal.Parse(value);
                    PropertyHasChanged("CongAnTrua");
                }
            }
        }

        public string CongLamDem
        {
            get
            {
                CanReadProperty("CongLamDem", true);
                if (_congLamDem == 0)
                {
                    return "";
                }
                else
                {
                    return _congLamDem.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("CongLamDem", true);

                if (_congLamDem.ToString() != value)
                {
                    if (value == "")
                        _congLamDem = 0;
                    else
                        _congLamDem = Decimal.Parse(value);
                    PropertyHasChanged("CongLamDem");
                }
            }
        }

        public string LuongTT
        {
            get
            {
                CanReadProperty("LuongTT", true);
                if (_luongTT == 0)
                {
                    return "";
                }
                else
                {
                    return _luongTT.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("LuongTT", true);

                if (_luongTT.ToString() != value)
                {
                    if (value == "")
                        _luongTT = 0;
                    else
                        _luongTT = Decimal.Parse(value);
                    PropertyHasChanged("LuongTT");
                }
            }
        }

        public string LuongTMCT
        {
            get
            {
                CanReadProperty("LuongTMCT", true);
                if (_luongTMCT == 0)
                {
                    return "";
                }
                else
                {
                    return _luongTMCT.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("LuongTMCT", true);

                if (_luongTMCT.ToString() != value)
                {
                    if (value == "")
                        _luongTMCT = 0;
                    else
                        _luongTMCT = Decimal.Parse(value);
                    PropertyHasChanged("LuongTMCT");
                }
            }
        }

        public string LuongTruc
        {
            get
            {
                CanReadProperty("LuongTruc", true);
                if (_luongTruc == 0)
                {
                    return "";
                }
                else
                {
                    return _luongTruc.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("LuongTruc", true);

                if (_luongTruc.ToString() != value)
                {
                    if (value == "")
                        _luongTruc = 0;
                    else
                        _luongTruc = Decimal.Parse(value);
                    PropertyHasChanged("LuongTruc");
                }
            }
        }

        public string LuongM1
        {
            get
            {
                CanReadProperty("LuongM1", true);
                if (_luongM1 == 0)
                {
                    return "";
                }
                else
                {
                    return _luongM1.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("LuongM1", true);

                if (_luongM1.ToString() != value)
                {
                    if (value == "")
                        _luongM1 = 0;
                    else
                        _luongM1 = Decimal.Parse(value);
                    PropertyHasChanged("LuongM1");
                }
            }
        }

        public string LuongM2
        {
            get
            {
                CanReadProperty("LuongM2", true);
                if (_luongM2 == 0)
                {
                    return "";
                }
                else
                {
                    return _luongM2.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("LuongM2", true);

                if (_luongM2.ToString() != value)
                {
                    if (value == "")
                        _luongM2 = 0;
                    else
                        _luongM2 = Decimal.Parse(value);
                    PropertyHasChanged("LuongM2");
                }
            }
        }

        public string LuongPT
        {
            get
            {
                CanReadProperty("LuongPT", true);
                if (_luongPT == 0)
                {
                    return "";
                }
                else
                {
                    return _luongPT.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("LuongPT", true);

                if (_luongPT.ToString() != value)
                {
                    if (value == "")
                        _luongPT = 0;
                    else
                        _luongPT = Decimal.Parse(value);
                    PropertyHasChanged("LuongPT");
                }
            }
        }

        public string LuongNghe
        {
            get
            {
                CanReadProperty("LuongNghe", true);
                if (_luongNghe == 0)
                {
                    return "";
                }
                else
                {
                    return _luongNghe.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("LuongNghe", true);

                if (_luongNghe.ToString() != value)
                {
                    if (value == "")
                        _luongNghe = 0;
                    else
                        _luongNghe = Decimal.Parse(value);
                    PropertyHasChanged("LuongNghe");
                }
            }
        }

        public string LuongNgoaiGio
        {
            get
            {
                CanReadProperty("LuongNgoaiGio", true);
                if (_luongNgoaiGio == 0)
                {
                    return "";
                }
                else
                {
                    return _luongNgoaiGio.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("LuongNgoaiGio", true);

                if (_luongNgoaiGio.ToString() != value)
                {
                    if (value == "")
                        _luongNgoaiGio = 0;
                    else
                        _luongNgoaiGio = Decimal.Parse(value);
                    PropertyHasChanged("LuongNgoaiGio");
                }
            }
        }
        public string LuongNgoaiGio1
        {
            get
            {
                CanReadProperty("LuongNgoaiGio1", true);
                _luongNgoaiGio1 = (_ngoaiGio * _heSoNgoaiGio + _ngoaiGio7 * _heSoNgoaiGio7 + _ngoaiGioLe * _heSoNgoaiGioLe) * _mucLuongCB / 22;
                if (_luongNgoaiGio1 == 0)
                {
                    return "";
                }
                else
                {
                    return _luongNgoaiGio1.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("LuongNgoaiGio1", true);

                if (_luongNgoaiGio1.ToString() != value)
                {
                    if (value == "")
                        _luongNgoaiGio1 = 0;
                    else
                        _luongNgoaiGio1 = Decimal.Parse(value);
                    PropertyHasChanged("LuongNgoaiGio1");
                }
            }
        }

        public string LuongDocHai
        {
            get
            {
                CanReadProperty("LuongDocHai", true);
                if (_luongDocHai == 0)
                {
                    return "";
                }
                else
                {
                    return _luongDocHai.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("LuongDocHai", true);

                if (_luongDocHai.ToString() != value)
                {
                    if (value == "")
                        _luongDocHai = 0;
                    else
                        _luongDocHai = Decimal.Parse(value);
                    PropertyHasChanged("LuongDocHai");
                }
            }
        }

        public string LuongHoiChan
        {
            get
            {
                CanReadProperty("LuongHoiChan", true);
                if (_luongHoiChan == 0)
                {
                    return "";
                }
                else
                {
                    return _luongHoiChan.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("LuongHoiChan", true);

                if (_luongHoiChan.ToString() != value)
                {
                    if (value == "")
                        _luongHoiChan = 0;
                    else
                        _luongHoiChan = Decimal.Parse(value);
                    PropertyHasChanged("LuongHoiChan");
                }
            }
        }

        public string LuongBoiDuongPT
        {
            get
            {
                CanReadProperty("LuongBoiDuongPT", true);
                if (_luongBoiDuongPT == 0)
                {
                    return "";
                }
                else
                {
                    return _luongBoiDuongPT.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("LuongBoiDuongPT", true);

                if (_luongBoiDuongPT.ToString() != value)
                {
                    if (value == "")
                        _luongBoiDuongPT = 0;
                    else
                        _luongBoiDuongPT = Decimal.Parse(value);
                    PropertyHasChanged("LuongBoiDuongPT");
                }
            }
        }

        public string TienKhauTru
        {
            get
            {
                CanReadProperty("TienKhauTru", true);
                    _tienKhauTru = _mucMGthueTNhap + _mucTTThue ;
                if (_tienKhauTru == 0)
                {
                    return "";
                }
                else
                {
                    return _tienKhauTru.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TienKhauTru", true);

                if (_tienKhauTru.ToString() != value)
                {
                    if (value == "")
                        _tienKhauTru = 0;
                    else
                        _tienKhauTru = Decimal.Parse(value);
                    PropertyHasChanged("TienKhauTru");
                }
            }
        }

        public string LuongKyI
        {
            get
            {
                CanReadProperty("LuongKyI", true);
                _luongKyI = _luongM1 + _luongNgoaiGio + _congAnTrua * _donGiaAnTrua + (_congLamDem * _heSoLamDem * _mucLuongCB) / (8 * 22) + _congAnToi * _donGiaAnToi + _congTac + _dienThoai + _luongPT + _luongTT + _luongHoiChan + _luongBoiDuongPT;
                if (_luongKyI == 0)
                {
                    return "";
                }
                else
                {
                    return _luongKyI.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("LuongKyI", true);

                if (_luongKyI.ToString() != value)
                {
                    if (value == "")
                        _luongKyI = 0;
                    else
                        _luongKyI = Decimal.Parse(value);
                    PropertyHasChanged("LuongKyI");
                }
            }
        }

        public string LuongKyII
        {
            get
            {
                CanReadProperty("LuongKyII", true);
                _luongKyII = _luongM2 + _LuongABC + _luongNghe + ( _ngoaiGio  * _heSoNgoaiGio + _ngoaiGio7*_heSoNgoaiGio7 + _ngoaiGioLe * _heSoNgoaiGioLe  ) * _mucLuongCB / 22 +  _luongTMCT + _luongDocHai + _luongTruc + _XQuang * _donGiaXQuang  +_luongKhac  ;
                if (_luongKyII == 0)
                {
                    return "";
                }
                else
                {
                    return _luongKyII.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("LuongKyII", true);

                if (_luongKyII.ToString() != value)
                {
                    if (value == "")
                        _luongKyII = 0;
                    else
                        _luongKyII = Decimal.Parse(value);
                    PropertyHasChanged("LuongKyII");
                }
            }
        }

        public string LuongKyIthue
        {
            get
            {
                CanReadProperty("LuongKyI", true);
                _luongKyIthue = _luongM1 + _luongNgoaiGio + (_congLamDem * _heSoLamDem * _mucLuongCB) / (8 * 22) + _luongPT + _luongTT + _luongHoiChan + _luongBoiDuongPT;
                if (_luongKyIthue == 0)
                {
                    return "";
                }
                else
                {
                    return _luongKyIthue.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("LuongKyI", true);

                if (_luongKyIthue.ToString() != value)
                {
                    if (value == "")
                        _luongKyIthue = 0;
                    else
                        _luongKyIthue = Decimal.Parse(value);
                    PropertyHasChanged("LuongKyI");
                }
            }
        }

        public string LuongKyIIthue
        {
            get
            {
                CanReadProperty("LuongKyIIthue", true);
                _luongKyIIthue = _luongM2 + _LuongABC + (_ngoaiGio * _heSoNgoaiGio + _ngoaiGio7 * _heSoNgoaiGio7 + _ngoaiGioLe * _heSoNgoaiGioLe) * _mucLuongCB / 22 + _luongTMCT + _luongTruc + _XQuang * _donGiaXQuang;
                if (_luongKyIIthue == 0)
                {
                    return "";
                }
                else
                {
                    return _luongKyIIthue.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("LuongKyIIthue", true);

                if (_luongKyIIthue.ToString() != value)
                {
                    if (value == "")
                        _luongKyIIthue = 0;
                    else
                        _luongKyIIthue = Decimal.Parse(value);
                    PropertyHasChanged("LuongKyIIthue");
                }
            }
        }

        public string TongTU
        {
            get
            {
                CanReadProperty("TongTU", true);
                _tongTU = _luongKyIthue + _luongKyIIthue;
                if (_tongTU == 0)
                {
                    return "";
                }
                else
                {
                    return _tongTU.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TongTU", true);

                if (_tongTU.ToString() != value)
                {
                    if (value == "")
                        _tongTU = 0;
                    else
                        _tongTU = Decimal.Parse(value);
                    PropertyHasChanged("TongTU");
                }
            }
        }

        public string TienPhaiTinhThue
        {
            get
            {
                CanReadProperty("TienPhaiTinhThue", true);
                _tienPhaiTinhThue = _luongKyIthue + _luongKyIIthue - _tienKhauTru ;
                if (_tienPhaiTinhThue > 0)
                {
                    foreach( DMDongThueThuNhap _dmdongthuethunhap in DMDongThueThuNhapList.GetAllDMDongThueThuNhap() )
                        if ((_tienPhaiTinhThue >= _dmdongthuethunhap.SoTienTu) && (_tienPhaiTinhThue <= _dmdongthuethunhap.SoTienDen))
                        {
                            _heSoDongThueThuNhap = _dmdongthuethunhap.HeSo;
                            break;
                        }

                }
                if (_tienPhaiTinhThue == 0)
                {
                    return "";
                }
                else
                {
                    return _tienPhaiTinhThue.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TienPhaiTinhThue", true);

                if (_tienPhaiTinhThue.ToString() != value)
                {
                    if (value == "")
                        _tienPhaiTinhThue = 0;
                    else
                        _tienPhaiTinhThue = Decimal.Parse(value);
                    PropertyHasChanged("TienPhaiTinhThue");
                }
            }
        }

        public string TienPhaiNopThue
        {
            get
            {
                CanReadProperty("TienPhaiNopThue", true);
                if (_tienPhaiTinhThue >= 0)

               _tienPhaiNopThue = _tienPhaiTinhThue * _heSoDongThueThuNhap  ;

                   if (_tienPhaiNopThue == 0)
                   {
                       return "";
                   }
                   else
                   {
                       return _tienPhaiNopThue.ToString("###,###");
                   }
            }
            set
            {
                CanWriteProperty("TienPhaiNopThue", true);

                if (_tienPhaiNopThue.ToString() != value)
                {
                    if (value == "")
                        _tienPhaiNopThue = 0;
                    else
                        _tienPhaiNopThue = Decimal.Parse(value);
                    PropertyHasChanged("TienPhaiNopThue");
                }
            }
        }

        public string TienLinhDotII1
        {
            get
            {
                CanReadProperty("TienLinhDotII", true);
                // _tienLinhDotII = _tienPhaiNopThue + _tienLinhDotII;
                if (_tienLinhDotII == 0)
                {
                    return "";
                }
                else
                {
                    return _tienLinhDotII.ToString("###,###");
                    //return _tienLinhDotII.ToString("###,###,##0.##");
                }
            }
            set
            {
                CanWriteProperty("TienLinhDotII", true);

                if (_tienLinhDotII.ToString() != value)
                {
                    if (value == "")
                        _tienLinhDotII = 0;
                    else
                        _tienLinhDotII = Decimal.Parse(value);
                    PropertyHasChanged("TienLinhDotII");
                }
            }
        }

        public string TienLinhDotII
        {
            get
            {
                CanReadProperty("TienLinhDotII", true);
                _tienLinhDotII = _luongKyII - _tienPhaiNopThue;
                if (_tienLinhDotII == 0)
                {
                    return "";
                }
                else
                {
                    return _tienLinhDotII.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TienLinhDotII", true);

                if (_tienLinhDotII.ToString() != value)
                {
                    if (value == "")
                        _tienLinhDotII = 0;
                    else
                        _tienLinhDotII = Decimal.Parse(value);
                    PropertyHasChanged("TienLinhDotII");
                }
            }
        }

        //public string Tong
        //{
        //    get
        //    {
        //        CanReadProperty("Tong", true);
        //        _tong = _tienPhaiNopThue + _tienLinhDotII ;
        //        if (_tong == 0)
        //        {
        //            return "";
        //        }
        //        else
        //        {
        //            return _tong.ToString("###,###");
        //        }
        //    }
        //    set
        //    {
        //        CanWriteProperty("Tong", true);

        //        if (_tong.ToString() != value)
        //        {
        //            if (value == "")
        //                _tong = 0;
        //            else
        //                _tong = Decimal.Parse(value);
        //            PropertyHasChanged("Tong");
        //        }
        //    }
        //}


        public String TenKhoa
        {
            get
            {
                CanReadProperty("TenKhoa", true);
                return _tenKhoa;
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

        public String TenMGThueTNhap
        {
            get
            {
                CanReadProperty("TenMGThueTNhap", true);
                return _tenMGThueTNhap;
            }
            set
            {
                CanWriteProperty("TenMGThueTNhap", true);
                if (_tenMGThueTNhap != value)
                {
                    _tenMGThueTNhap = value;
                    PropertyHasChanged("TenMGThueTNhap");
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
			return _sTT.ToString() + "!" + _thang.ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="Luong" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static Luong NewLuong()
        {
            return new Luong();
            // return DataPortal.Create<BC_DuocBV>();
        }

        internal static Luong GetLuong(SafeDataReader dr, int i)
        {
            return new Luong(dr, i);
        }
       
        //public static Luong GetLuong(Int32 sTT, SmartDate thang)
        //{
        //    return DataPortal.Fetch<Luong>(new Criteria(sTT, thang));
        //}
        public Luong()
        {
            MarkAsChild();
        }
		/// <summary>
		/// Marks the <see cref="Luong" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteLuong(Int32 sTT, SmartDate thang)
        //{
        //    DataPortal.Delete(new Criteria(sTT, thang));
        //}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal Luong()
        //{	
        //    // Prevent direct creation
        //}
		
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private Int32 _sTT;
			public Int32 STT 
			{
				get
				{
					return _sTT;
				}
			}
			
			private SmartDate _thang;
			public SmartDate Thang 
			{
				get
				{
					return _thang;
				}
			}
			
			public Criteria(Int32 sTT, SmartDate thang)
			{
				_sTT = sTT;
				_thang = thang;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					if (!_thang.Equals(c._thang)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _sTT.ToString(), _thang.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class CriteriaOther
        {
            private Int32 _sTT;
            public Int32 STT
            {
                get
                {
                    return _sTT;
                }
            }

            private SmartDate _thang;
            public SmartDate Thang
            {
                get
                {
                    return _thang;
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
            public CriteriaOther(String Mamay, String Nguoisd, Int32 sTT, SmartDate thang)
            {
                _sTT = sTT;
                _thang = thang;
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
		/// Retrieve an existing <see cref="Luong" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetLuong(Int32 _sTT, SmartDate _thang);
        //    // public override IDataReader GetLuong(Int32 _sTT, SmartDate _thang)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _sTT, _thang));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetLuong(crit.STT, crit.Thang.DBValue)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="Luong" /> Object from given SafeDataReader.
		/// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
        //    if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
        //    if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
        //    if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
        //    if (dr.GetDecimal("MucLuongCB") != null) _mucLuongCB = dr.GetDecimal("MucLuongCB");
        //    if (dr.GetDecimal("HeSoLuong") != null) _heSoLuong = dr.GetDecimal("HeSoLuong");
        //    if (dr.GetDecimal("HeSoPC") != null) _heSoPC = dr.GetDecimal("HeSoPC");
        //    if (dr.GetDecimal("BHXH") != null) _bHXH = dr.GetDecimal("BHXH");
        //    if (dr.GetDecimal("BHYT") != null) _bHYT = dr.GetDecimal("BHYT");
        //    if (dr.GetDecimal("CongDoan") != null) _congDoan = dr.GetDecimal("CongDoan");
        //    if (dr.GetDecimal("AnToi") != null) _donGiaAnToi = dr.GetDecimal("AnToi");
        //    if (dr.GetDecimal("AnTrua") != null) _donGiaAnTrua = dr.GetDecimal("AnTrua");
        //    if (dr.GetDecimal("HeSoDocHai") != null) _heSoDocHai = dr.GetDecimal("HeSoDocHai");
        //    if (dr.GetDecimal("MucPCBoiDuong") != null) _mucPCBoiDuong = dr.GetDecimal("MucPCBoiDuong");
        //    if (dr.GetDecimal("HeSoPCTrachNhiem") != null) _heSoPCTrachNhiem = dr.GetDecimal("HeSoPCTrachNhiem");
        //    if (dr.GetDecimal("TienNgoaiGio") != null) _tienNgoaiGio = dr.GetDecimal("TienNgoaiGio");
        //    if (dr.GetDecimal("TienPC") != null) _PCDienThoai = dr.GetDecimal("TienPC");
        //    if (dr.GetDecimal("TienTruc") != null) _congTacPhi = dr.GetDecimal("TienTruc");
        //    if (dr.GetDecimal("TienLamDem") != null) _donGiaLamDem = dr.GetDecimal("TienLamDem");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //    if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
        //    if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
        //    if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
        //    if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
        //    if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //    if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
        //    if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //}
        private Luong(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
			if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
			if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
            if (dr.GetDecimal("HeSoChucVu") != null) _heSoChucVu = dr.GetDecimal("HeSoChucVu");
            if (dr.GetDecimal("HeSo") != null) _heSo = dr.GetDecimal("HeSo");
            if (dr.GetDecimal("HeSoLamDem") != null) _heSoLamDem = dr.GetDecimal("HeSoLamDem");
            if (dr.GetDecimal("HeSoNgoaiGio") != null) _heSoNgoaiGio = dr.GetDecimal("HeSoNgoaiGio");
            if (dr.GetDecimal("HeSoNgoaiGio7") != null) _heSoNgoaiGio7 = dr.GetDecimal("HeSoNgoaiGio7");
            if (dr.GetDecimal("HeSoNgoaiGioLe") != null) _heSoNgoaiGioLe = dr.GetDecimal("HeSoNgoaiGioLe");
            if (dr.GetDecimal("DonGiaAnTrua") != null) _donGiaAnTrua = dr.GetDecimal("DonGiaAnTrua");
            if (dr.GetDecimal("DonGiaAnToi") != null) _donGiaAnToi = dr.GetDecimal("DonGiaAnToi");
            if (dr.GetDecimal("DienThoai") != null) _dienThoai = dr.GetDecimal("DienThoai");
            if (dr.GetDecimal("CongTac") != null) _congTac = dr.GetDecimal("CongTac");
            if (dr.GetDecimal("DonGiaXQuang") != null) _donGiaXQuang = dr.GetDecimal("DonGiaXQuang");
            if (dr.GetDecimal("MucLuongCB") != null) _mucLuongCB = dr.GetDecimal("MucLuongCB");
            if (dr.GetDecimal("LuongABC") != null) _LuongABC = dr.GetDecimal("LuongABC");
            if (dr.GetDecimal("MucMGThueTNhap") != null) _mucMGthueTNhap = dr.GetDecimal("MucMGThueTNhap");
            if (dr.GetString("MaMGThueThuNhap") != null) _maMGThueThuNhap = dr.GetString("MaMGThueThuNhap");
            if (dr.GetDecimal("HeSoDongThueThuNhap") != null) _heSoDongThueThuNhap = dr.GetDecimal("HeSoDongThueThuNhap");
            if (dr.GetDecimal("MucTTThue") != null) _mucTTThue = dr.GetDecimal("MucTTThue");
            if (dr.GetDecimal("LuongKhac") != null) _luongKhac = dr.GetDecimal("LuongKhac");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
			if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenNguoiLap") != null) _tenNguoiLap = dr.GetString("TenNguoiLap");
            if (dr.GetString("TenNguoiHuy") != null) _tenNguoiHuy = dr.GetString("TenNguoiHuy");
            if (dr.GetString("HoTen") != null) _hoten = dr.GetString("HoTen");
            if (dr.GetString("TenChuyenMon") != null) _tenChuyenMon = dr.GetString("TenChuyenMon");
            if (dr.GetString("TenLoaiHD") != null) _tenLoaiHD = dr.GetString("TenLoaiHD");
            if (dr.GetSmartDate("NgaySinh", true) != null) _ngaySinh = dr.GetSmartDate("NgaySinh", true);
            if (dr.GetBoolean("GioiTinh") != null) _gioitinh = dr.GetBoolean("GioiTinh");
            if (dr.GetString("ABC") != null) _ABC = dr.GetString("ABC");

            if (dr.GetDecimal("TongCongHC") != null) _TongCongHC = dr.GetDecimal("TongCongHC");
            if (dr.GetDecimal("hanhChinh") != null) _hanhChinh = dr.GetDecimal("hanhChinh");
            if (dr.GetDecimal("phep") != null) _phep = dr.GetDecimal("phep");
            if (dr.GetDecimal("om") != null) _om = dr.GetDecimal("om");
            if (dr.GetDecimal("luyKe") != null) _luyKe = dr.GetDecimal("luyKe");
            if (dr.GetDecimal("ngoaiGio") != null) _ngoaiGio = dr.GetDecimal("ngoaiGio");
            if (dr.GetDecimal("ngoaiGio7") != null) _ngoaiGio7 = dr.GetDecimal("ngoaiGio7");
            if (dr.GetDecimal("ngoaiGioLe") != null) _ngoaiGioLe = dr.GetDecimal("ngoaiGioLe");
            if (dr.GetDecimal("XQuang") != null) _XQuang = dr.GetDecimal("XQuang");
            if (dr.GetDecimal("congAnToi") != null) _congAnToi = dr.GetDecimal("congAnToi");
            if (dr.GetDecimal("congAnTrua") != null) _congAnTrua = dr.GetDecimal("congAnTrua");
            if (dr.GetDecimal("congLamDem") != null) _congLamDem = dr.GetDecimal("congLamDem");
            if (dr.GetDecimal("luongTT") != null) _luongTT = dr.GetDecimal("luongTT");
            if (dr.GetDecimal("luongTMCT") != null) _luongTMCT = dr.GetDecimal("luongTMCT");
            if (dr.GetDecimal("luongTruc") != null) _luongTruc = dr.GetDecimal("luongTruc");
            if (dr.GetDecimal("luongM1") != null) _luongM1 = dr.GetDecimal("luongM1");
            if (dr.GetDecimal("luongM2") != null) _luongM2 = dr.GetDecimal("luongM2");
            if (dr.GetDecimal("luongPT") != null) _luongPT = dr.GetDecimal("luongPT");
            if (dr.GetDecimal("luongNghe") != null) _luongNghe = dr.GetDecimal("luongNghe");
            if (dr.GetDecimal("luongNgoaiGio") != null) _luongNgoaiGio = dr.GetDecimal("luongNgoaiGio");
            if (dr.GetDecimal("luongDocHai") != null) _luongDocHai = dr.GetDecimal("luongDocHai");
            if (dr.GetDecimal("luongHoiChan") != null) _luongHoiChan = dr.GetDecimal("luongHoiChan");
            if (dr.GetDecimal("luongBoiDuongPT") != null) _luongBoiDuongPT = dr.GetDecimal("luongBoiDuongPT");
            
            if (dr.GetString("TenKhoa") != null) _tenKhoa = dr.GetString("TenKhoa");
            if (dr.GetString("TenMGThueTNhap") != null) _tenMGThueTNhap = dr.GetString("TenMGThueTNhap");
            //_luongKyI = _luongM1 + _luongNgoaiGio + _congAnTrua * _donGiaAnTrua + (_congLamDem * _heSoLamDem * _mucLuongCB) / (8 * 22) + _congAnToi * _donGiaAnToi + _congTac + _dienThoai + _luongPT + _luongTT + _luongHoiChan + _luongBoiDuongPT;
           
            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="Luong" /> Object to underlying database.
		/// </summary>
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
            

            _luongKyI = _luongM1 + _luongNgoaiGio + _congAnTrua * _donGiaAnTrua + (_congLamDem * _heSoLamDem * _mucLuongCB) / (8 * 22) + _congAnToi * _donGiaAnToi + _congTac + _dienThoai + _luongPT + _luongTT + _luongHoiChan + _luongBoiDuongPT;
            _luongKyII = _luongM2 + _LuongABC + _luongNghe + (_ngoaiGio * _heSoNgoaiGio + _ngoaiGio7 * _heSoNgoaiGio7 + _ngoaiGioLe * _heSoNgoaiGioLe) * _mucLuongCB / 22 + _luongTMCT + _luongDocHai + _luongTruc + _XQuang * _donGiaXQuang + _luongKhac;
            _tienKhauTru = _mucMGthueTNhap + _mucTTThue;
            _luongKyIthue = _luongM1 + _luongNgoaiGio + (_congLamDem * _heSoLamDem * _mucLuongCB) / (8 * 22) + _luongPT + _luongTT + _luongHoiChan + _luongBoiDuongPT;
            _luongKyIIthue = _luongM2 + _LuongABC + (_ngoaiGio * _heSoNgoaiGio + _ngoaiGio7 * _heSoNgoaiGio7 + _ngoaiGioLe * _heSoNgoaiGioLe) * _mucLuongCB / 22 + _luongTMCT + _luongTruc + _XQuang * _donGiaXQuang;   
            _tienPhaiTinhThue = _luongKyIthue + _luongKyIIthue - _tienKhauTru;
            
            
            if (_tienPhaiTinhThue > 0)
            {
                foreach (DMDongThueThuNhap _dmdongthuethunhap in DMDongThueThuNhapList.GetAllDMDongThueThuNhap())

                    if ((_tienPhaiTinhThue >= _dmdongthuethunhap.SoTienTu) && (_tienPhaiTinhThue <= _dmdongthuethunhap.SoTienDen))
                    {
                        _heSoDongThueThuNhap = _dmdongthuethunhap.HeSo;

                        break;
                    }

            }
            _tienPhaiNopThue = _tienPhaiTinhThue * _heSoDongThueThuNhap;

            _tienLinhDotII = _luongKyII - _tienPhaiNopThue;
            _sTT = DataProvider.Instance().InsertLuong(_thang, _maNV, _makhoa, _heSoChucVu, _heSo, _heSoLamDem, _heSoNgoaiGio, _heSoNgoaiGio7, _heSoNgoaiGioLe, _donGiaAnTrua, _donGiaAnToi, _dienThoai, _congTac, _donGiaXQuang, _mucLuongCB, _LuongABC, _mucMGthueTNhap, _maMGThueThuNhap, _heSoDongThueThuNhap, _mucTTThue, _luongKhac, _luongKyI, _luongKyII, _luongM2, _luongNghe, _tienLinhDotII, _ghiChu, _maMay, _nguoiSD);
            // public abstract Int32 InsertLuong(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Decimal _heSoChucVu, Decimal _heSo, Decimal _heSoLamDem, Decimal _heSoNgoaiGio, Decimal _heSoNgoaiGio7, Decimal _heSoNgoaiGioLe, Decimal _donGiaAnTrua, Decimal _donGiaAnToi, Decimal _dienThoai, Decimal _congTac, Decimal _donGiaXQuang, Decimal _mucLuongCB, Decimal _aBC, Decimal _thueTNhap, String _maMGThueThuNhap, Decimal _heSoMGThueThuNhap, Decimal _mucTTThue, Decimal _luongKhac, String _ghiChu, String _maMay, String _nguoiLap);
            // public override Int32 InsertLuong(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Decimal _heSoChucVu, Decimal _heSo, Decimal _heSoLamDem, Decimal _heSoNgoaiGio, Decimal _heSoNgoaiGio7, Decimal _heSoNgoaiGioLe, Decimal _donGiaAnTrua, Decimal _donGiaAnToi, Decimal _dienThoai, Decimal _congTac, Decimal _donGiaXQuang, Decimal _mucLuongCB, Decimal _aBC, Decimal _thueTNhap, String _maMGThueThuNhap, Decimal _heSoMGThueThuNhap, Decimal _mucTTThue, Decimal _luongKhac, String _ghiChu, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spLUONG_CREATE", _sTT, _thang.DBValue, _maNV, _makhoa, _heSoChucVu, _heSo, _heSoLamDem, _heSoNgoaiGio, _heSoNgoaiGio7, _heSoNgoaiGioLe, _donGiaAnTrua, _donGiaAnToi, _dienThoai, _congTac, _donGiaXQuang, _mucLuongCB, _aBC, _thueTNhap, _maMGThueThuNhap, _heSoMGThueThuNhap, _mucTTThue, _luongKhac, _ghiChu, _maMay, _nguoiSD);
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="Luong" /> Object to underlying database.
		/// </summary>
		 internal void Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
			 if (!this.IsDirty)
                return;
                
                  
                _luongKyI = _luongM1 + _luongNgoaiGio + _congAnTrua * _donGiaAnTrua + (_congLamDem * _heSoLamDem * _mucLuongCB) / (8 * 22) + _congAnToi * _donGiaAnToi + _congTac + _dienThoai + _luongPT + _luongTT + _luongHoiChan + _luongBoiDuongPT;
                _luongKyII = _luongM2 + _LuongABC + _luongNghe + (_ngoaiGio * _heSoNgoaiGio + _ngoaiGio7 * _heSoNgoaiGio7 + _ngoaiGioLe * _heSoNgoaiGioLe) * _mucLuongCB / 22 + _luongTMCT + _luongDocHai + _luongTruc + _XQuang * _donGiaXQuang + _luongKhac;
                _tienKhauTru = _mucMGthueTNhap + _mucTTThue;
               
                _luongKyIthue = _luongM1 + _luongNgoaiGio + (_congLamDem * _heSoLamDem * _mucLuongCB) / (8 * 22) + _luongPT + _luongTT + _luongHoiChan + _luongBoiDuongPT;
                _luongKyIIthue = _luongM2 + _LuongABC + (_ngoaiGio * _heSoNgoaiGio + _ngoaiGio7 * _heSoNgoaiGio7 + _ngoaiGioLe * _heSoNgoaiGioLe) * _mucLuongCB / 22 + _luongTMCT + _luongTruc + _XQuang * _donGiaXQuang;
                _tienPhaiTinhThue = _luongKyIthue + _luongKyIIthue - _tienKhauTru;


                if (_tienPhaiTinhThue > 0)
                {
                    foreach (DMDongThueThuNhap _dmdongthuethunhap in DMDongThueThuNhapList.GetAllDMDongThueThuNhap())

                        if ((_tienPhaiTinhThue >= _dmdongthuethunhap.SoTienTu) && (_tienPhaiTinhThue <= _dmdongthuethunhap.SoTienDen))
                        {
                            _heSoDongThueThuNhap = _dmdongthuethunhap.HeSo;

                            break;
                        }

                }
                _tienPhaiNopThue = _tienPhaiTinhThue * _heSoDongThueThuNhap;

                _tienLinhDotII = _luongKyII - _tienPhaiNopThue;
                DataProvider.Instance().UpdateLuong(_sTT, _thang, _maNV, _makhoa, _heSoChucVu, _heSo, _heSoLamDem, _heSoNgoaiGio, _heSoNgoaiGio7, _heSoNgoaiGioLe, _donGiaAnTrua, _donGiaAnToi, _dienThoai, _congTac, _donGiaXQuang, _mucLuongCB, _LuongABC, _mucMGthueTNhap, _maMGThueThuNhap, _heSoDongThueThuNhap, _mucTTThue, _luongKhac, _luongKyI, _luongKyII, _luongM2, _luongNghe, _tienLinhDotII, _ghiChu, _maMay, _nguoiSD , _huy);
                // public abstract void UpdateLuong(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Decimal _heSoChucVu, Decimal _heSo, Decimal _heSoLamDem, Decimal _heSoNgoaiGio, Decimal _heSoNgoaiGio7, Decimal _heSoNgoaiGioLe, Decimal _donGiaAnTrua, Decimal _donGiaAnToi, Decimal _dienThoai, Decimal _congTac, Decimal _donGiaXQuang, Decimal _mucLuongCB, Decimal _aBC, Decimal _thueTNhap, String _maMGThueThuNhap, Decimal _heSoMGThueThuNhap, Decimal _mucTTThue, Decimal _luongKhac, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
                // public override void UpdateLuong(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Decimal _heSoChucVu, Decimal _heSo, Decimal _heSoLamDem, Decimal _heSoNgoaiGio, Decimal _heSoNgoaiGio7, Decimal _heSoNgoaiGioLe, Decimal _donGiaAnTrua, Decimal _donGiaAnToi, Decimal _dienThoai, Decimal _congTac, Decimal _donGiaXQuang, Decimal _mucLuongCB, Decimal _aBC, Decimal _thueTNhap, String _maMGThueThuNhap, Decimal _heSoMGThueThuNhap, Decimal _mucTTThue, Decimal _luongKhac, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spLUONG_UPDATE", _sTT, _thang.DBValue, _maNV, _makhoa, _heSoChucVu, _heSo, _heSoLamDem, _heSoNgoaiGio, _heSoNgoaiGio7, _heSoNgoaiGioLe, _donGiaAnTrua, _donGiaAnToi, _dienThoai, _congTac, _donGiaXQuang, _mucLuongCB, _aBC, _thueTNhap, _maMGThueThuNhap, _heSoMGThueThuNhap, _mucTTThue, _luongKhac, _ghiChu, _maMay, _nguoiSD , _huy);
				// }				
                MarkOld();
		}
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            DataPortal_Delete(new CriteriaOther(_maMay, _nguoiSD , _sTT, _thang));
            MarkNew();
        }

		/// <summary>
		/// Delete the <see cref="Luong" />.
		/// </summary>
        protected void DataPortal_Delete(CriteriaOther crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateLuong
            DataProvider.Instance().DeleteLuong(crit.MaMay, crit.NguoiSD, crit.STT, crit.Thang);
			// public abstract void DeleteLuong(Int32 _sTT, SmartDate _thang);
			// public override void DeleteLuong(Int32 _sTT, SmartDate _thang);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spLUONG_DELETED", _sTT, _thang);
			// }
		}

		#endregion
	}

}
