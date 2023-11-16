// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	Luong_HoiChan
// Kieu doi tuong  :	Luong_HoiChan
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

namespace HTC.Business.Luong
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="Luong_HoiChan" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class Luong_HoiChan : BusinessBase<Luong_HoiChan>
	{
		#region Business Methods
		
		#region State Fields
		
		private Int32 _sTT = 0;
		private SmartDate _thang = new SmartDate(true);
		private String _maNV = String.Empty;
		private String _makhoa = String.Empty;
        private Byte _vaiTro = 0;
        private Decimal _NgoaiVien = 0;
        private Decimal _ThanhTienNgoaiVien = 0;
        private Decimal _chuTri = 0;
        private Decimal _ThanhTienChuTri = 0;
        private Decimal _thuKy = 0;
        private Decimal _ThanhTienThuKy = 0;
        private Decimal _bacSy = 0;
        private Decimal _ThanhTienBacSy = 0;
        private Decimal _dd = 0;
        private Decimal _ThanhTienDd = 0;
        private Decimal _nVien = 0;
        private Decimal _ThanhTienNVien = 0;
        private Decimal _dONGIANgoaiVien = 0;
        private Decimal _dONGIAChuTri = 0;
        private Decimal _dONGIAThuKy = 0;
        private Decimal _dONGIABacSy = 0;
        private Decimal _dONGIADD = 0;
        private Decimal _DonGiaNVien = 0;
        private Decimal _tong = 0;
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
        private String _tenKhoa = String.Empty;
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
        public Byte VaiTro
        {
            get
            {
                CanReadProperty("VaiTro", true);
                return _vaiTro;
            }
            set
            {
                CanWriteProperty("VaiTro", true);
                if (_vaiTro != value)
                {
                    _vaiTro = value;
                    PropertyHasChanged("VaiTro");
                }
            }
        }
        public String  NgoaiVien
        {
            get
            {
                CanReadProperty("NgoaiVien", true);
                if (_NgoaiVien == 0)
                {
                    return "";
                }
                else if (_NgoaiVien - (int)(_NgoaiVien) != 0)
                    return _NgoaiVien.ToString("###,##0.##");
                else
                    return _NgoaiVien.ToString("###,###");
            }
            set
            {
                CanWriteProperty("NgoaiVien", true);

                if (_NgoaiVien.ToString() != value)
                {
                    if (value == "")
                        _NgoaiVien = 0;
                    else
                        _NgoaiVien = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("NgoaiVien");
                }
            }
        }
        public String ThanhTienNgoaiVien
        {
            get
            {
                CanReadProperty("ThanhTienNgoaiVien", true);
                _ThanhTienNgoaiVien = _NgoaiVien * _dONGIANgoaiVien;
                if (_ThanhTienNgoaiVien == 0)
                {
                    return "";
                }
                else if (_ThanhTienNgoaiVien - (int)(_ThanhTienNgoaiVien) != 0)
                    return _ThanhTienNgoaiVien.ToString("###,##0.##");
                else
                    return _ThanhTienNgoaiVien.ToString("###,###");
            }
            set
            {
                CanWriteProperty("ThanhTienNgoaiVien", true);

                if (_ThanhTienNgoaiVien.ToString() != value)
                {
                    if (value == "")
                        _ThanhTienNgoaiVien = 0;
                    else
                        _ThanhTienNgoaiVien = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("ThanhTienNgoaiVien");
                }
            }
        }
        public String  ChuTri
        {
            get
            {
                CanReadProperty("ChuTri", true);
                if (_chuTri == 0)
                {
                    return "";
                }
                else if (_chuTri - (int)(_chuTri) != 0)
                    return _chuTri.ToString("###,##0.##");
                else
                    return _chuTri.ToString("###,###");
            }
            set
            {
                CanWriteProperty("ChuTri", true);

                if (_chuTri.ToString() != value)
                {
                    if (value == "")
                        _chuTri = 0;
                    else
                        _chuTri = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("ChuTri");
                }
            }
        }
        public String ThanhTienChuTri
        {
            get
            {
                CanReadProperty("ThanhTienChuTri", true);
                _ThanhTienChuTri = _chuTri * _dONGIAChuTri;
                if (_ThanhTienChuTri == 0)
                {
                    return "";
                }
                else if (_ThanhTienChuTri - (int)(_ThanhTienChuTri) != 0)
                    return _ThanhTienChuTri.ToString("###,##0.##");
                else
                    return _ThanhTienChuTri.ToString("###,###");
            }
            set
            {
                CanWriteProperty("ThanhTienChuTri", true);

                if (_ThanhTienChuTri.ToString() != value)
                {
                    if (value == "")
                        _ThanhTienChuTri = 0;
                    else
                        _ThanhTienChuTri = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("ThanhTienChuTri");
                }
            }
        }
        public String  ThuKy
        {
            get
            {
                CanReadProperty("ThuKy", true);
                if (_thuKy == 0)
                {
                    return "";
                }
                else if (_thuKy - (int)(_thuKy) != 0)
                    return _thuKy.ToString("###,##0.##");
                else
                    return _thuKy.ToString("###,###");
            }
            set
            {
                CanWriteProperty("ThuKy", true);

                if (_thuKy.ToString() != value)
                {
                    if (value == "")
                        _thuKy = 0;
                    else
                        _thuKy = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("ThuKy");
                }
            }
        }

        public String ThanhTienThuKy
        {
            get
            {
                CanReadProperty("ThanhTienThuKy", true);
                _ThanhTienThuKy = _thuKy * _dONGIAThuKy;
                if (_ThanhTienThuKy == 0)
                {
                    return "";
                }
                else if (_ThanhTienThuKy - (int)(_ThanhTienThuKy) != 0)
                    return _ThanhTienThuKy.ToString("###,##0.##");
                else
                    return _ThanhTienThuKy.ToString("###,###");
            }
            set
            {
                CanWriteProperty("ThanhTienThuKy", true);

                if (_ThanhTienThuKy.ToString() != value)
                {
                    if (value == "")
                        _ThanhTienThuKy = 0;
                    else
                        _ThanhTienThuKy = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("ThanhTienThuKy");
                }
            }
        }


        public String  BacSy
        {
            get
            {
                CanReadProperty("BacSy", true);
                if (_bacSy == 0)
                {
                    return "";
                }
                else if (_bacSy - (int)(_bacSy) != 0)
                    return _bacSy.ToString("###,##0.##");
                else
                    return _bacSy.ToString("###,###");
            }
            set
            {
                CanWriteProperty("BacSy", true);

                if (_bacSy.ToString() != value)
                {
                    if (value == "")
                        _bacSy = 0;
                    else
                        _bacSy = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("BacSy");
                }
            }
        }
        public String ThanhTienBacSy
        {
            get
            {
                CanReadProperty("ThanhTienBacSy", true);
                _ThanhTienBacSy = _bacSy * _dONGIABacSy;
                if (_ThanhTienBacSy == 0)
                {
                    return "";
                }
                else if (_ThanhTienBacSy - (int)(_ThanhTienBacSy) != 0)
                    return _ThanhTienBacSy.ToString("###,##0.##");
                else
                    return _ThanhTienBacSy.ToString("###,###");
            }
            set
            {
                CanWriteProperty("ThanhTienBacSy", true);

                if (_ThanhTienBacSy.ToString() != value)
                {
                    if (value == "")
                        _ThanhTienBacSy = 0;
                    else
                        _ThanhTienBacSy = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("ThanhTienBacSy");
                }
            }
        }
        public String  DD
        {
            get
            {
                CanReadProperty("DD", true);
                if (_dd == 0)
                {
                    return "";
                }
                else if (_dd - (int)(_dd) != 0)
                    return _dd.ToString("###,##0.##");
                else
                    return _dd.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DD", true);

                if (_dd.ToString() != value)
                {
                    if (value == "")
                        _dd = 0;
                    else
                        _dd = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DD");
                }
            }
        }
        public String ThanhTienDD
        {
            get
            {
                CanReadProperty("ThanhTienDD", true);
                _ThanhTienDd = _dd * _dONGIADD;
                if (_ThanhTienDd == 0)
                {
                    return "";
                }
                else if (_ThanhTienDd - (int)(_ThanhTienDd) != 0)
                    return _ThanhTienDd.ToString("###,##0.##");
                else
                    return _ThanhTienDd.ToString("###,###");
            }
            set
            {
                CanWriteProperty("ThanhTienDD", true);

                if (_ThanhTienDd.ToString() != value)
                {
                    if (value == "")
                        _ThanhTienDd = 0;
                    else
                        _ThanhTienDd = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("ThanhTienDD");
                }
            }
        }
        public String  NVien
        {
            get
            {
                CanReadProperty("NVien", true);
                if (_nVien == 0)
                {
                    return "";
                }
                else if (_nVien - (int)(_nVien) != 0)
                    return _nVien.ToString("###,##0.##");
                else
                    return _nVien.ToString("###,###");
            }
            set
            {
                CanWriteProperty("NVien", true);

                if (_nVien.ToString() != value)
                {
                    if (value == "")
                        _nVien = 0;
                    else
                        _nVien = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("NVien");
                }
            }
        }
        public String ThanhTienNVien
        {
            get
            {
                CanReadProperty("ThanhTienNVien", true);
                _ThanhTienNVien = _nVien * _DonGiaNVien;
                if (_ThanhTienNVien == 0)
                {
                    return "";
                }
                else if (_ThanhTienNVien - (int)(_ThanhTienNVien) != 0)
                    return _ThanhTienNVien.ToString("###,##0.##");
                else
                    return _ThanhTienNVien.ToString("###,###");
            }
            set
            {
                CanWriteProperty("ThanhTienNVien", true);

                if (_ThanhTienNVien.ToString() != value)
                {
                    if (value == "")
                        _ThanhTienNVien = 0;
                    else
                        _ThanhTienNVien = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("ThanhTienNVien");
                }
            }
        }
        public String  DONGIANgoaiVien
        {
            get
            {
                CanReadProperty("DonGiaNgoaiVien", true);
                if (_dONGIANgoaiVien == 0)
                {
                    return "";
                }
                    else
                    return _dONGIANgoaiVien.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DonGiaNgoaiVien", true);

                if (_dONGIANgoaiVien.ToString() != value)
                {
                    if (value == "")
                        _dONGIANgoaiVien = 0;
                    else
                        _dONGIANgoaiVien = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNgoaiVien");
                }
            }
        }
       

        public String  DONGIAChuTri
        {
            get
            {
                CanReadProperty("DonGiaChuTri", true);
                if (_dONGIAChuTri == 0)
                {
                    return "";
                }
                else
                    return _dONGIAChuTri.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DonGiaChuTri", true);

                if (_dONGIAChuTri.ToString() != value)
                {
                    if (value == "")
                        _dONGIAChuTri = 0;
                    else
                        _dONGIAChuTri = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaChuTri");
                }
            }
        }
        public String  DONGIAThuKy
        {
            get
            {
                CanReadProperty("DonGiaThuKy", true);
                if (_dONGIAThuKy == 0)
                {
                    return "";
                }
                else
                    return _dONGIAThuKy.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DonGiaThuKy", true);

                if (_dONGIAThuKy.ToString() != value)
                {
                    if (value == "")
                        _dONGIAThuKy = 0;
                    else
                        _dONGIAThuKy = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaThuKy");
                }
            }
        }
        public String DonGiaNVien
        {
            get
            {
                CanReadProperty("DonGiaNVien", true);
                if (_DonGiaNVien == 0)
                {
                    return "";
                }
                else
                    return _DonGiaNVien.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DonGiaNVien", true);

                if (_DonGiaNVien.ToString() != value)
                {
                    if (value == "")
                        _DonGiaNVien = 0;
                    else
                        _DonGiaNVien = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNVien");
                }
            }
        }
        public String DONGIABacSy
        {
            get
            {
                CanReadProperty("DonGiaBacSy", true);
                if (_dONGIABacSy == 0)
                {
                    return "";
                }
                else
                    return _dONGIABacSy.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DonGiaBacSy", true);

                if (_dONGIABacSy.ToString() != value)
                {
                    if (value == "")
                        _dONGIABacSy = 0;
                    else
                        _dONGIABacSy = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaBacSy");
                }
            }
        }
        public String  DONGIADD
        {
            get
            {
                CanReadProperty("DonGiaDD", true);
                if (_dONGIADD == 0)
                {
                    return "";
                }
                else
                    return _dONGIADD.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DonGiaDD", true);

                if (_dONGIADD.ToString() != value)
                {
                    if (value == "")
                        _dONGIADD = 0;
                    else
                        _dONGIADD = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaDD");
                }
            }
        }
        public String  Tong
        {
            get
            {
                CanReadProperty("Tong", true);
                _tong = _ThanhTienChuTri + _ThanhTienThuKy + _ThanhTienBacSy + _ThanhTienDd + _ThanhTienNVien+_ThanhTienNgoaiVien ;
                if (_tong == 0)
                {
                    return "";
                }
                else
                    return _tong.ToString("###,###");
            }
            set
            {
                CanWriteProperty("Tong", true);

                if (_tong.ToString() != value)
                {
                    if (value == "")
                        _tong = 0;
                    else
                        _tong = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("Tong");
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
			return _sTT .ToString() + "!" + _thang.ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="Luong_HoiChan" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static Luong_HoiChan NewLuong_HoiChan()
        {
            return new Luong_HoiChan();
            // return DataPortal.Create<BC_DuocBV>();
        }

        internal static Luong_HoiChan GetLuong_HoiChan(SafeDataReader dr, int i)
        {
            return new Luong_HoiChan(dr, i);
        }
        //public static Luong_HoiChan GetLuong_HoiChan(Int32 sTT, SmartDate thang)
        //{
        //    return DataPortal.Fetch<Luong_HoiChan>(new Criteria(sTT, thang));
        //}
        public Luong_HoiChan()
        {
            MarkAsChild();
        }
		/// <summary>
		/// Marks the <see cref="Luong_HoiChan" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteLuong_HoiChan(Int32 sTT, SmartDate thang)
        //{
        //    DataPortal.Delete(new Criteria(sTT, thang));
        //}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal Luong_HoiChan()
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
		/// Retrieve an existing <see cref="Luong_HoiChan" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetLuong_HoiChan(Int32 _sTT, SmartDate _thang);
        //    // public override IDataReader GetLuong_HoiChan(Int32 _sTT, SmartDate _thang)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _sTT, _thang));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetLuong_HoiChan(crit.STT, crit.Thang.DBValue)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="Luong_HoiChan" /> Object from given SafeDataReader.
		/// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
        //    if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
        //    if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
        //    if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
        //    if (dr.GetDecimal("MucLuong_HoiChanCB") != null) _mucLuong_HoiChanCB = dr.GetDecimal("MucLuong_HoiChanCB");
        //    if (dr.GetDecimal("HeSoLuong_HoiChan") != null) _heSoLuong_HoiChan = dr.GetDecimal("HeSoLuong_HoiChan");
        //    if (dr.GetDecimal("HeSoPC") != null) _heSoPC = dr.GetDecimal("HeSoPC");
        //    if (dr.GetDecimal("BHXH") != null) _bHXH = dr.GetDecimal("BHXH");
        //    if (dr.GetDecimal("BHYT") != null) _bHYT = dr.GetDecimal("BHYT");
        //    if (dr.GetDecimal("CongDoan") != null) _congDoan = dr.GetDecimal("CongDoan");
        //    if (dr.GetDecimal("AnToi") != null) _anToi = dr.GetDecimal("AnToi");
        //    if (dr.GetDecimal("AnTrua") != null) _anTrua = dr.GetDecimal("AnTrua");
        //    if (dr.GetDecimal("HeSoDocHai") != null) _heSoDocHai = dr.GetDecimal("HeSoDocHai");
        //    if (dr.GetDecimal("MucPCBoiDuong") != null) _mucPCBoiDuong = dr.GetDecimal("MucPCBoiDuong");
        //    if (dr.GetDecimal("HeSoPCTrachNhiem") != null) _heSoPCTrachNhiem = dr.GetDecimal("HeSoPCTrachNhiem");
        //    if (dr.GetDecimal("TienNgoaiGio") != null) _tienNgoaiGio = dr.GetDecimal("TienNgoaiGio");
        //    if (dr.GetDecimal("TienPC") != null) _tienPC = dr.GetDecimal("TienPC");
        //    if (dr.GetDecimal("TienTruc") != null) _tienTruc = dr.GetDecimal("TienTruc");
        //    if (dr.GetDecimal("TienLamDem") != null) _tienLamDem = dr.GetDecimal("TienLamDem");
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
        private Luong_HoiChan(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
			if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
			if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
            if (dr.GetByte("VaiTro") != null) _vaiTro = dr.GetByte("VaiTro");
            if (dr.GetDecimal("NgoaiVien") != null) _NgoaiVien = dr.GetDecimal("NgoaiVien");
            if (dr.GetDecimal("ChuTri") != null) _chuTri = dr.GetDecimal("ChuTri");
            if (dr.GetDecimal("ThuKy") != null) _thuKy = dr.GetDecimal("ThuKy");
            if (dr.GetDecimal("BacSy") != null) _bacSy = dr.GetDecimal("BacSy");
            if (dr.GetDecimal("DD") != null) _dd = dr.GetDecimal("DD");
            if (dr.GetDecimal("NVien") != null) _nVien = dr.GetDecimal("NVien");
            if (dr.GetDecimal("DONGIANgoaiVien") != null) _dONGIANgoaiVien = dr.GetDecimal("DONGIANgoaiVien");
            if (dr.GetDecimal("DONGIAChuTri") != null) _dONGIAChuTri = dr.GetDecimal("DONGIAChuTri");
            if (dr.GetDecimal("DONGIAThuKy") != null) _dONGIAThuKy = dr.GetDecimal("DONGIAThuKy");
            if (dr.GetDecimal("DONGIABacSy") != null) _dONGIABacSy = dr.GetDecimal("DONGIABacSy");
            if (dr.GetDecimal("DONGIADD") != null) _dONGIADD = dr.GetDecimal("DONGIADD");
            if (dr.GetDecimal("DONGIANVien") != null) _DonGiaNVien = dr.GetDecimal("DONGIANVien");
            if (dr.GetDecimal("Tong") != null) _tong = dr.GetDecimal("Tong");
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
            if (dr.GetString("TenKhoa") != null) _tenKhoa = dr.GetString("TenKhoa");
          

            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="Luong_HoiChan" /> Object to underlying database.
		/// </summary>
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
            
            _sTT = DataProvider.Instance().InsertLuong_HoiChan(_thang, _maNV, _makhoa, _vaiTro, _NgoaiVien, _chuTri, _thuKy, _bacSy, _dd, _nVien, _dONGIANgoaiVien, _dONGIAChuTri, _dONGIAThuKy, _dONGIABacSy, _dONGIADD, _DonGiaNVien, _tong, _ghiChu, _maMay, _nguoiSD);
            // public abstract Int32 InsertLuong_HoiChan(SmartDate _thang, String _maNV, String _makhoa, Byte _vaiTro, Decimal _NgoaiVien, Decimal _chuTri, Decimal _thuKy, Decimal _bacSy, Decimal _dd, Decimal _nVien, Decimal _dONGIANgoaiVien, Decimal _dONGIAChuTri, Decimal _dONGIAThuKy, Decimal _dONGIABacSy, Decimal _dONGIADD, Decimal _DONGIANgoaiVien, Decimal _tong, String _ghiChu, String _maMay, String _nguoiLap);
            // public override Int32 InsertLuong_HoiChan(SmartDate _thang, String _maNV, String _makhoa, Byte _vaiTro, Decimal _NgoaiVien, Decimal _chuTri, Decimal _thuKy, Decimal _bacSy, Decimal _dd, Decimal _nVien, Decimal _dONGIANgoaiVien, Decimal _dONGIAChuTri, Decimal _dONGIAThuKy, Decimal _dONGIABacSy, Decimal _dONGIADD, Decimal _DONGIANgoaiVien, Decimal _tong, String _ghiChu, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_HoiChan_CREATE",  _thang.DBValue, _maNV, _makhoa, _vaiTro, _NgoaiVien, _chuTri, _thuKy, _bacSy, _dd, _nVien, _dONGIANgoaiVien, _dONGIAChuTri, _dONGIAThuKy, _dONGIABacSy, _dONGIADD, _DONGIANgoaiVien, _tong, _ghiChu, _maMay, _nguoiSD);
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="Luong_HoiChan" /> Object to underlying database.
		/// </summary>
		 internal void Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
			 if (!this.IsDirty)
                return;
                
                  
                DataProvider.Instance().UpdateLuong_HoiChan(_sTT, _thang, _maNV, _makhoa, _vaiTro, _NgoaiVien, _chuTri, _thuKy, _bacSy, _dd, _nVien, _dONGIANgoaiVien, _dONGIAChuTri, _dONGIAThuKy, _dONGIABacSy, _dONGIADD, _DonGiaNVien, _tong, _ghiChu, _maMay, _nguoiSD , _huy);
                // public abstract void UpdateLuong_HoiChan(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Byte _vaiTro, Decimal _NgoaiVien, Decimal _chuTri, Decimal _thuKy, Decimal _bacSy, Decimal _dd, Decimal _nVien, Decimal _dONGIANgoaiVien, Decimal _dONGIAChuTri, Decimal _dONGIAThuKy, Decimal _dONGIABacSy, Decimal _dONGIADD, Decimal _DONGIANgoaiVien, Decimal _tong, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
                // public override void UpdateLuong_HoiChan(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Byte _vaiTro, Decimal _NgoaiVien, Decimal _chuTri, Decimal _thuKy, Decimal _bacSy, Decimal _dd, Decimal _nVien, Decimal _dONGIANgoaiVien, Decimal _dONGIAChuTri, Decimal _dONGIAThuKy, Decimal _dONGIABacSy, Decimal _dONGIADD, Decimal _DONGIANgoaiVien, Decimal _tong, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_HoiChan_UPDATE", _sTT, _thang.DBValue, _maNV, _makhoa, _vaiTro, _NgoaiVien, _chuTri, _thuKy, _bacSy, _dd, _nVien, _dONGIANgoaiVien, _dONGIAChuTri, _dONGIAThuKy, _dONGIABacSy, _dONGIADD, _DONGIANgoaiVien, _tong, _ghiChu, _maMay, _nguoiSD , _huy);
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
		/// Delete the <see cref="Luong_HoiChan" />.
		/// </summary>
        protected void DataPortal_Delete(CriteriaOther crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateLuong_HoiChan
            DataProvider.Instance().DeleteLuong_HoiChan(crit.MaMay, crit.NguoiSD, crit.STT, crit.Thang);
			// public abstract void DeleteLuong_HoiChan(Int32 _sTT, SmartDate _thang);
			// public override void DeleteLuong_HoiChan(Int32 _sTT, SmartDate _thang);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_HoiChan_DELETED", _sTT, _thang);
			// }
		}

		#endregion
	}

}
