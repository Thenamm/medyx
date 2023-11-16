// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	Luong_NgoaiGio_NV
// Kieu doi tuong  :	Luong_NgoaiGio_NV
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	01/05/2010 9:11:33 AM
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
using HTC.Business;
//
using HTC.Business.CategoryList ;

namespace HTC.Business.Luong
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="Luong_NgoaiGio_NV" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class Luong_NgoaiGio_NV : BusinessBase<Luong_NgoaiGio_NV>
	{
		#region Business Methods
		
		#region State Fields
		
		private Int32 _sTT = 0;
		private SmartDate _thang = new SmartDate(true);
		private String _maNV = String.Empty;
		private String _maKhoa = String.Empty;
		private String _maPC = String.Empty;
		private Decimal _tongTuan1 = 0;
		private Decimal _tongTuan2 = 0;
		private Decimal _tongTuan3 = 0;
		private Decimal _tongTuan4 = 0;
		private Decimal _tongTuan5 = 0;
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
        private SmartDate _ngay1 = new SmartDate(true);
        private SmartDate _ngay2 = new SmartDate(true);
        private SmartDate _ngay3 = new SmartDate(true);
        private SmartDate _ngay4 = new SmartDate(true);
        private SmartDate _ngay5 = new SmartDate(true);
        private Decimal _tT11 = 0;
        private Decimal _tT12 = 0;
        private Decimal _tT13 = 0;
        private Decimal _tT14 = 0;
        private Decimal _tT21 = 0;
        private Decimal _tT22 = 0;
        private Decimal _tT23 = 0;
        private Decimal _tT24 = 0;
        private Decimal _tT31 = 0;
        private Decimal _tT32 = 0;
        private Decimal _tT33 = 0;
        private Decimal _tT34 = 0;
        private Decimal _tT41 = 0;
        private Decimal _tT42 = 0;
        private Decimal _tT43 = 0;
        private Decimal _tT44 = 0;
        private Decimal _tT51 = 0;
        private Decimal _tT52 = 0;
        private Decimal _tT53 = 0;
        private Decimal _tT54 = 0;
        private String _maPC1 = String.Empty;
        private String _maPC2 = String.Empty;
        private String _maPC3 = String.Empty;
        private String _maPC4 = String.Empty;
        private Decimal _heSo1 = 0;
        private Decimal _heSo2 = 0;
        private Decimal _heSo3 = 0;
        private Decimal _heSo4 = 0;
        private Decimal _tien1 = 0;
        private Decimal _tien2 = 0;
        private Decimal _tien3 = 0;
        private Decimal _tien4 = 0;
        private Decimal _tien5 = 0;
        private String _cmbT1 = String.Empty;
        private String _cmbT2 = String.Empty;
        private String _cmbT3 = String.Empty;
        private String _cmbT4 = String.Empty;
        private String _cmbT5 = String.Empty;
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

        public String CMBT1
        {
            get
            {
                CanReadProperty("CMBT1", true);
                return _cmbT1;
            }
            set
            {
                CanWriteProperty("CMBT1", true);
                if (_cmbT1 != value)
                {
                    _cmbT1 = value;
                    PropertyHasChanged("CMBT1");
                }
            }
        }

        public String CMBT2
        {
            get
            {
                CanReadProperty("CMBT2", true);
                return _cmbT2;
            }
            set
            {
                CanWriteProperty("CMBT2", true);
                if (_cmbT2 != value)
                {
                    _cmbT2 = value;
                    PropertyHasChanged("CMBT2");
                }
            }
        }

        public String CMBT3
        {
            get
            {
                CanReadProperty("CMBT3", true);
                return _cmbT3;
            }
            set
            {
                CanWriteProperty("CMBT3", true);
                if (_cmbT3 != value)
                {
                    _cmbT3 = value;
                    PropertyHasChanged("CMBT3");
                }
            }
        }

        public String CMBT4
        {
            get
            {
                CanReadProperty("CMBT4", true);
                return _cmbT4;
            }
            set
            {
                CanWriteProperty("CMBT4", true);
                if (_cmbT4 != value)
                {
                    _cmbT4 = value;
                    PropertyHasChanged("CMBT4");
                }
            }
        }

        public String CMBT5
        {
            get
            {
                CanReadProperty("CMBT5", true);
                return _cmbT5;
            }
            set
            {
                CanWriteProperty("CMBT5", true);
                if (_cmbT5 != value)
                {
                    _cmbT5 = value;
                    PropertyHasChanged("CMBT5");
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
		
		public String MaPC
		{
			get 
			{
				CanReadProperty("MaPC", true);
				return _maPC;
			}
			set 
			{
				CanWriteProperty("MaPC", true);
				if (_maPC != value) 
				{
					_maPC = value;
					PropertyHasChanged("MaPC");
				}
			}
		}
        //###,##0.00
		public string TongTuan1
		{
			get 
			{
				CanReadProperty("TongTuan1", true);
                if (_tongTuan1 == 0)
                {
                    return "";
                }
                else
                {
                    return _tongTuan1.ToString("###,###");
                }
			}
			set 
			{
				CanWriteProperty("TongTuan1", true);
                if (_tongTuan1.ToString() != value)
                {
                    if (value == "")
                        _tongTuan1 = 0;
                    else
                        _tongTuan1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TongTuan1");
                }
			}
		}

        public string TongTuan2
        {
            get
            {
                CanReadProperty("TongTuan2", true);
                if (_tongTuan2 == 0)
                {
                    return "";
                }
                else
                {
                    return _tongTuan2.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TongTuan2", true);
                if (_tongTuan2.ToString() != value)
                {
                    if (value == "")
                        _tongTuan2 = 0;
                    else
                        _tongTuan2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TongTuan2");
                }
            }
        }

        public string TongTuan3
        {
            get
            {
                CanReadProperty("TongTuan3", true);
                if (_tongTuan3 == 0)
                {
                    return "";
                }
                else
                {
                    return _tongTuan3.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TongTuan3", true);
                if (_tongTuan3.ToString() != value)
                {
                    if (value == "")
                        _tongTuan3 = 0;
                    else
                        _tongTuan3 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TongTuan3");
                }
            }
        }

        public string TongTuan4
        {
            get
            {
                CanReadProperty("TongTuan4", true);
                if (_tongTuan4 == 0)
                {
                    return "";
                }
                else
                {
                    return _tongTuan4.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TongTuan4", true);
                if (_tongTuan4.ToString() != value)
                {
                    if (value == "")
                        _tongTuan4 = 0;
                    else
                        _tongTuan4 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TongTuan4");
                }
            }
        }

        public string TongTuan5
        {
            get
            {
                CanReadProperty("TongTuan5", true);
                if (_tongTuan5 == 0)
                {
                    return "";
                }
                else
                {
                    return _tongTuan5.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TongTuan5", true);
                if (_tongTuan5.ToString() != value)
                {
                    if (value == "")
                        _tongTuan5 = 0;
                    else
                        _tongTuan5 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TongTuan5");
                }
            }
        }



        public string Tong
		{
			get 
			{
				CanReadProperty("Tong", true);
                _tong = _tongTuan1 + _tongTuan2 + _tongTuan3 + _tongTuan4 + _tongTuan5;
                if (_tong == 0)
                {
                    return "";
                }
                else
                {
                    return _tong.ToString("###,###");
                }
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
                    PropertyHasChanged("TongTuan5");
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

        public string Ngay1
        {
            get
            {
                CanReadProperty("Ngay1", true);
                return _ngay1.Text;
            }
            set
            {
                CanWriteProperty("Ngay1", true);
                if (_ngay1.Text != value)
                {
                    _ngay1.Text = value;
                    PropertyHasChanged("Ngay1");
                }
            }
        }

        public string Ngay2
        {
            get
            {
                CanReadProperty("Ngay2", true);
                return _ngay2.Text;
            }
            set
            {
                CanWriteProperty("Ngay2", true);
                if (_ngay2.Text != value)
                {
                    _ngay2.Text = value;
                    PropertyHasChanged("Ngay2");
                }
            }
        }

        public string Ngay3
        {
            get
            {
                CanReadProperty("Ngay3", true);
                return _ngay3.Text;
            }
            set
            {
                CanWriteProperty("Ngay3", true);
                if (_ngay3.Text != value)
                {
                    _ngay3.Text = value;
                    PropertyHasChanged("Ngay3");
                }
            }
        }

        public string Ngay4
        {
            get
            {
                CanReadProperty("Ngay4", true);
                return _ngay4.Text;
            }
            set
            {
                CanWriteProperty("Ngay4", true);
                if (_ngay4.Text != value)
                {
                    _ngay4.Text = value;
                    PropertyHasChanged("Ngay4");
                }
            }
        }

        public string Ngay5
        {
            get
            {
                CanReadProperty("Ngay5", true);
                return _ngay5.Text;
            }
            set
            {
                CanWriteProperty("Ngay5", true);
                if (_ngay5.Text != value)
                {
                    _ngay5.Text = value;
                    PropertyHasChanged("Ngay5");
                }
            }
        }
        public String MaPC1
        {
            get
            {
                CanReadProperty("MaPC1", true);
                return _maPC1;
            }
            set
            {
                CanWriteProperty("MaPC1", true);
                if (_maPC1 != value)
                {
                    _maPC1 = value;
                    PropertyHasChanged("MaPC1");
                }
            }
        }

        public String MaPC2
        {
            get
            {
                CanReadProperty("MaPC2", true);
                return _maPC2;
            }
            set
            {
                CanWriteProperty("MaPC2", true);
                if (_maPC2 != value)
                {
                    _maPC2 = value;
                    PropertyHasChanged("MaPC2");
                }
            }
        }

        public String MaPC3
        {
            get
            {
                CanReadProperty("MaPC3", true);
                return _maPC3;
            }
            set
            {
                CanWriteProperty("MaPC3", true);
                if (_maPC3 != value)
                {
                    _maPC3 = value;
                    PropertyHasChanged("MaPC3");
                }
            }
        }

        public String MaPC4
        {
            get
            {
                CanReadProperty("MaPC4", true);
                return _maPC4;
            }
            set
            {
                CanWriteProperty("MaPC4", true);
                if (_maPC4 != value)
                {
                    _maPC4 = value;
                    PropertyHasChanged("MaPC4");
                }
            }
        }
        public string HeSo1
        {
            get
            {
                CanReadProperty("HeSo1", true);
                //_heSo1 = _heSo1;
                if (_heSo1 == 0)
                {
                    return "";
                }
                else
                {
                    return _heSo1.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("HeSo1", true);
                if (_heSo1.ToString() != value)
                {
                    if (value == "")
                        _heSo1 = 0;
                    else
                        _heSo1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("HeSo1");
                }
            }
        }
        public string HeSo2
        {
            get
            {
                CanReadProperty("HeSo2", true);
                if (_heSo2 == 0)
                {
                    return "";
                }
                else
                {
                    return _heSo2.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("HeSo2", true);
                if (_heSo2.ToString() != value)
                {
                    if (value == "")
                        _heSo2 = 0;
                    else
                        _heSo2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("HeSo2");
                }
            }
        }
        public string HeSo3
        {
            get
            {
                CanReadProperty("HeSo3", true);
                if (_heSo3 == 0)
                {
                    return "";
                }
                else
                {
                    return _heSo3.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("HeSo3", true);
                if (_heSo3.ToString() != value)
                {
                    if (value == "")
                        _heSo3 = 0;
                    else
                        _heSo3 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("HeSo3");
                }
            }
        }
        public string HeSo4
        {
            get
            {
                CanReadProperty("HeSo4", true);
                if (_heSo4 == 0)
                {
                    return "";
                }
                else
                {
                    return _heSo4.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("HeSo4", true);
                if (_heSo4.ToString() != value)
                {
                    if (value == "")
                        _heSo4 = 0;
                    else
                        _heSo4 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("HeSo4");
                }
            }
        }
        public string Tien1
        {
            get
            {
                CanReadProperty("Tien1", true);
                if (_tien1 == 0)
                {
                    return "";
                }
                else
                {
                    return _tien1.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("Tien1", true);
                if (_tien1.ToString() != value)
                {
                    if (value == "")
                        _tien1 = 0;
                    else
                        _tien1 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("Tien1");
                }
            }
        }
        public string Tien2
        {
            get
            {
                CanReadProperty("Tien2", true);
                if (_tien2 == 0)
                {
                    return "";
                }
                else
                {
                    return _tien2.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("Tien2", true);
                if (_tien2.ToString() != value)
                {
                    if (value == "")
                        _tien2 = 0;
                    else
                        _tien2 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("Tien2");
                }
            }
        }
        public string Tien3
        {
            get
            {
                CanReadProperty("Tien3", true);
                if (_tien3 == 0)
                {
                    return "";
                }
                else
                {
                    return _tien3.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("Tien3", true);
                if (_tien3.ToString() != value)
                {
                    if (value == "")
                        _tien3 = 0;
                    else
                        _tien3 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("Tien3");
                }
            }
        }
        public string Tien4
        {
            get
            {
                CanReadProperty("Tien4", true);
                if (_tien4 == 0)
                {
                    return "";
                }
                else
                {
                    return _tien4.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("Tien4", true);
                if (_tien4.ToString() != value)
                {
                    if (value == "")
                        _tien4 = 0;
                    else
                        _tien4 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("Tien4");
                }
            }
        }
        public string Tien5
        {
            get
            {
                CanReadProperty("Tien5", true);
                if (_tien5 == 0)
                {
                    return "";
                }
                else
                {
                    return _tien5.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("Tien5", true);
                if (_tien5.ToString() != value)
                {
                    if (value == "")
                        _tien5 = 0;
                    else
                        _tien5 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("Tien5");
                }
            }
        }

        public string TT11
        {
            get
            {
                CanReadProperty("TT11", true);
                if ((_maPC == _maPC1) && (_tongTuan1 != 0))
                {
                    _tT11 = _heSo1 / 100 * _tien1;
                    _tongTuan1 = _tT11;
                }
                else
                {
                    _tT11 = 0;
                }
                if (_tT11 == 0)
                {
                    return "";
                }
                else
                {
                    return _tT11.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TT11", true);
                //if (_maPC == _maPC1)
                //{
                    if (_tT11.ToString() != value)
                    {
                        if (value == "")
                            _tT11 = 0;
                        else
                            _tT11 = decimal.Parse(value.Replace(",", ""));
                        PropertyHasChanged("TT11");
                    }

                }
            //}
                
        }
        public string TT12
        {
            get
            {
                CanReadProperty("TT12", true);
                if ((_maPC == _maPC2) && (_tongTuan1 != 0))
                {
                    _tT12 = _heSo2 / 100 * _tien1;
                    _tongTuan1 = _tT12;
                }
                else
                { 
                    _tT12 = 0;
                }
                if (_tT12 == 0)
                {
                    return "";
                }
                else
                {
                    return _tT12.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TT12", true);
                if (_tT12.ToString() != value)
                {
                    if (value == "")
                        _tT12 = 0;
                    else
                        _tT12 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TT12");
                }
            }
        }
        public string TT13
        {
            get
            {
                CanReadProperty("TT13", true);
                if ((_maPC == _maPC3) && (_tongTuan1 != 0))
                {
                    _tT13 = _heSo3 / 100 * _tien1;
                    _tongTuan1 = _tT13;
                }
                else
                {
                    _tT13 = 0;
                }
                if (_tT13 == 0)
                {
                    return "";
                }
                else
                {
                    return _tT13.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TT13", true);
                if (_tT13.ToString() != value)
                {
                    if (value == "")
                        _tT13 = 0;
                    else
                        _tT13 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TT13");
                }
            }
        }
        public string TT14
        {
            get
            {
                CanReadProperty("TT14", true);
                if ((_maPC == _maPC4) && (_tongTuan1 != 0))
                {
                    _tT14 = _heSo4 / 100 * _tien1;
                    _tongTuan1 = _tT14;
                }
                else
                {
                    _tT14 = 0;
                }
                if (_tT14 == 0)
                {
                    return "";
                }
                else
                {
                    return _tT14.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TT14", true);
                if (_tT14.ToString() != value)
                {
                    if (value == "")
                        _tT14 = 0;
                    else
                        _tT14 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TT14");
                }
            }
        }

        public string TT21
        {
            get
            {
                CanReadProperty("TT21", true);
                if ((_maPC == _maPC1) && (_tongTuan2 != 0))
                {
                    _tT21 = _heSo1 / 100 * _tien2;
                    _tongTuan2 = _tT21;
                }
                else
                {
                    _tT21 = 0;
                }
                if (_tT21 == 0)
                {
                    return "";
                }
                else
                {
                    return _tT21.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TT21", true);
                if (_tT21.ToString() != value)
                {
                    if (value == "")
                        _tT21 = 0;
                    else
                        _tT21 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TT21");
                }
            }
        }
        public string TT22
        {
            get
            {
                CanReadProperty("TT22", true);
                if ((_maPC == _maPC2) && (_tongTuan2 != 0))
                {
                    _tT22 = _heSo2 / 100 * _tien2;
                    _tongTuan2 = _tT22;
                }
                else
                {
                    _tT22 = 0;
                }
                if (_tT22 == 0)
                {
                    return "";
                }
                else
                {
                    return _tT22.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TT22", true);
                if (_tT22.ToString() != value)
                {
                    if (value == "")
                        _tT22 = 0;
                    else
                        _tT22 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TT22");
                }
            }
        }
        public string TT23
        {
            get
            {
                CanReadProperty("TT23", true);
                if ((_maPC == _maPC3) && (_tongTuan2 != 0))
                {
                    _tT23 = _heSo3 / 100 * _tien2;
                    _tongTuan2 = _tT23;
                }
                else
                {
                    _tT23 = 0;
                }
                if (_tT23 == 0)
                {
                    return "";
                }
                else
                {
                    return _tT23.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TT23", true);
                if (_tT23.ToString() != value)
                {
                    if (value == "")
                        _tT23 = 0;
                    else
                        _tT23 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TT23");
                }
            }
        }
        public string TT24
        {
            get
            {
                CanReadProperty("TT24", true);
                if ((_maPC == _maPC4) && (_tongTuan2 != 0))
                {
                    _tT24 = _heSo4 / 100 * _tien2;
                    _tongTuan2 = _tT24;
                }
                else
                {
                    _tT24 = 0;
                }
                if (_tT24 == 0)
                {
                    return "";
                }
                else
                {
                    return _tT24.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TT24", true);
                if (_tT24.ToString() != value)
                {
                    if (value == "")
                        _tT24 = 0;
                    else
                        _tT24 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TT24");
                }
            }
        }

        public string TT31
        {
            get
            {
                CanReadProperty("TT31", true);
                if ((_maPC == _maPC1) && (_tongTuan3 != 0))
                {
                    _tT31 = _heSo1 / 100 * _tien3;
                    _tongTuan3 = _tT31;
                }
                else
                {
                    _tT31 = 0;
                }
                if (_tT31 == 0)
                {
                    return "";
                }
                else
                {
                    return _tT31.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TT31", true);
                if (_tT31.ToString() != value)
                {
                    if (value == "")
                        _tT31 = 0;
                    else
                        _tT31 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TT31");
                }
            }
        }
        public string TT32
        {
            get
            {
                CanReadProperty("TT32", true);
                if ((_maPC == _maPC2) && (_tongTuan3 != 0))
                {
                    _tT32 = _heSo2 / 100 * _tien3;
                    _tongTuan3 = _tT32;
                }
                else
                {
                    _tT32 = 0;
                }
                if (_tT32 == 0)
                {
                    return "";
                }
                else
                {
                    return _tT32.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TT32", true);
                if (_tT32.ToString() != value)
                {
                    if (value == "")
                        _tT32 = 0;
                    else
                        _tT32 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TT32");
                }
            }
        }
        public string TT33
        {
            get
            {
                CanReadProperty("TT33", true);
                if ((_maPC == _maPC3) && (_tongTuan3 != 0))
                {
                    _tT33 = _heSo3 / 100 * _tien3;
                    _tongTuan3 = _tT33;
                }
                else
                {
                    _tT33 = 0;
                }
                if (_tT33 == 0)
                {
                    return "";
                }
                else
                {
                    return _tT33.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TT33", true);
                if (_tT33.ToString() != value)
                {
                    if (value == "")
                        _tT33 = 0;
                    else
                        _tT33 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TT33");
                }
            }
        }
        public string TT34
        {
            get
            {
                CanReadProperty("TT34", true);
                if ((_maPC == _maPC4) && (_tongTuan3 != 0))
                {
                    _tT34 = _heSo4 / 100 * _tien3;
                    _tongTuan3 = _tT34;
                }
                else
                {
                    _tT34 = 0;
                }
                if (_tT34 == 0)
                {
                    return "";
                }
                else
                {
                    return _tT34.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TT34", true);
                if (_tT34.ToString() != value)
                {
                    if (value == "")
                        _tT34 = 0;
                    else
                        _tT34 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TT34");
                }
            }
        }

        public string TT41
        {
            get
            {
                CanReadProperty("TT41", true);
                if ((_maPC == _maPC1) && (_tongTuan4 != 0))
                {
                    _tT41 = _heSo1 / 100 * _tien4;
                    _tongTuan4 = _tT41;
                }
                else
                {
                    _tT41 = 0;
                }
                if (_tT41 == 0)
                {
                    return "";
                }
                else
                {
                    return _tT41.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TT41", true);
                if (_tT41.ToString() != value)
                {
                    if (value == "")
                        _tT41 = 0;
                    else
                        _tT41 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TT41");
                }
            }
        }
        public string TT42
        {
            get
            {
                CanReadProperty("TT42", true);
                if ((_maPC == _maPC2) && (_tongTuan4 != 0))
                {
                    _tT42 = _heSo2 / 100 * _tien4;
                    _tongTuan4 = _tT42;
                }
                else
                {
                    _tT42 = 0;
                }
                if (_tT42 == 0)
                {
                    return "";
                }
                else
                {
                    return _tT42.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TT42", true);
                if (_tT42.ToString() != value)
                {
                    if (value == "")
                        _tT42 = 0;
                    else
                        _tT42 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TT42");
                }
            }
        }
        public string TT43
        {
            get
            {
                CanReadProperty("TT43", true);
                if ((_maPC == _maPC3) && (_tongTuan4 != 0))
                {
                    _tT43 = _heSo3 / 100 * _tien4;
                    _tongTuan4 = _tT43;
                }
                else
                {
                    _tT43 = 0;
                }
                if (_tT43 == 0)
                {
                    return "";
                }
                else
                {
                    return _tT43.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TT43", true);
                if (_tT43.ToString() != value)
                {
                    if (value == "")
                        _tT43 = 0;
                    else
                        _tT43 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TT43");
                }
            }
        }
        public string TT44
        {
            get
            {
                CanReadProperty("TT44", true);
                if ((_maPC == _maPC4) && (_tongTuan4 != 0))
                {
                    _tT44 = _heSo4 / 100 * _tien4;
                    _tongTuan4 = _tT44;
                }
                else
                {
                    _tT44 = 0;
                }
                if (_tT44 == 0)
                {
                    return "";
                }
                else
                {
                    return _tT44.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TT44", true);
                if (_tT44.ToString() != value)
                {
                    if (value == "")
                        _tT44 = 0;
                    else
                        _tT44 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TT44");
                }
            }
        }

        public string TT51
        {
            get
            {
                CanReadProperty("TT51", true);
                if ((_maPC == _maPC1) && (_tongTuan5 != 0))
                {
                    _tT51 = _heSo1 / 100 * _tien5;
                    _tongTuan5 = _tT51;
                }
                else
                {
                    _tT51 = 0;
                }
                if (_tT51 == 0)
                {
                    return "";
                }
                else
                {
                    return _tT51.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TT51", true);
                if (_tT51.ToString() != value)
                {
                    if (value == "")
                        _tT51 = 0;
                    else
                        _tT51 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TT51");
                }
            }
        }
        public string TT52
        {
            get
            {
                CanReadProperty("TT52", true);
                if ((_maPC == _maPC2) && (_tongTuan5 != 0))
                {
                    _tT52 = _heSo2 / 100 * _tien5;
                    _tongTuan5 = _tT52;
                }
                else
                {
                    _tT52 = 0;
                }
                if (_tT52 == 0)
                {
                    return "";
                }
                else
                {
                    return _tT52.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TT52", true);
                if (_tT52.ToString() != value)
                {
                    if (value == "")
                        _tT52 = 0;
                    else
                        _tT52 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TT52");
                }
            }
        }
        public string TT53
        {
            get
            {
                CanReadProperty("TT53", true);
                if ((_maPC == _maPC3) && (_tongTuan5 != 0))
                {
                    _tT53 = _heSo3 / 100 * _tien5;
                    _tongTuan5 = _tT53;
                }
                else
                {
                    _tT53 = 0;
                }
                if (_tT53 == 0)
                {
                    return "";
                }
                else
                {
                    return _tT53.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TT53", true);
                if (_tT53.ToString() != value)
                {
                    if (value == "")
                        _tT53 = 0;
                    else
                        _tT53 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TT53");
                }
            }
        }
        public string TT54
        {
            get
            {
                CanReadProperty("TT54", true);
                if ((_maPC == _maPC4) && (_tongTuan5 != 0))
                {
                    _tT54 = _heSo4 / 100 * _tien5;
                    _tongTuan5 = _tT54;
                }
                else
                {
                    _tT54 = 0;
                }
                if (_tT54 == 0)
                {
                    return "";
                }
                else
                {
                    return _tT54.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TT54", true);
                if (_tT54.ToString() != value)
                {
                    if (value == "")
                        _tT54 = 0;
                    else
                        _tT54 = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TT54");
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
			return _sTT.ToString() + "!" + _thang.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="Luong_NgoaiGio_NV" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static Luong_NgoaiGio_NV NewLuong_NgoaiGio_NV()
        {
            return new Luong_NgoaiGio_NV();

        }
        public static Luong_NgoaiGio_NV NewLuong_NgoaiGio_NV(string maNhanvien)
        {
            return new Luong_NgoaiGio_NV(DMNhanVien.GetDMNhanVien(maNhanvien));
        }
        public static Luong_NgoaiGio_NV NewLuong_NgoaiGio_NV(DMNhanVien _DMNhanVien)
        {
            return new Luong_NgoaiGio_NV(_DMNhanVien);
        }
		public static Luong_NgoaiGio_NV GetLuong_NgoaiGio_NV(Int32 sTT, SmartDate thang)
		{
			return DataPortal.Fetch<Luong_NgoaiGio_NV>(new Criteria(sTT, thang));
		}
        public static Luong_NgoaiGio_NV GetLuong_NgoaiGio_NV(SafeDataReader dr)
        {
            return new Luong_NgoaiGio_NV(dr);
        }
        public static Luong_NgoaiGio_NV GetLuong_NgoaiGio_NV(SafeDataReader dr, int i)
        {
            return new Luong_NgoaiGio_NV(dr,i);
        }
		/// <summary>
		/// Marks the <see cref="Luong_NgoaiGio_NV" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteLuong_NgoaiGio_NV(Int32 sTT, SmartDate thang, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new CriteriaOther(mamay,nguoihuy , sTT, thang));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal Luong_NgoaiGio_NV()
		{	
			// Prevent direct creation
		}
        protected Luong_NgoaiGio_NV(DMNhanVien pro)
        {
            MarkAsChild();

            //_maPhieu = dr.GetString("MaPhieu");
            _maNV = pro.MaNV;
           
        }
        protected Luong_NgoaiGio_NV(string _MaKhoa, DMNhanVien pro)
        {
            MarkAsChild();
            _MaKhoa = _MaKhoa ;
            _maNV = pro.MaNV;
            _maMay = pro.MaMay;
            _huy = pro.Huy;
            _nguoiSD = pro.NguoiSD;
             
            //MarkOld();
        }
        protected Luong_NgoaiGio_NV(SafeDataReader dr, int i)//lay nhung thang hien ra tren luoi
        {
            MarkAsChild();
            _OrderNumber = i;
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
            if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
            if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
            if (dr.GetString("MaPC") != null) _maPC = dr.GetString("MaPC");
            if (dr.GetDecimal("TongTuan1") != null) _tongTuan1 = dr.GetDecimal("TongTuan1");
            if (_tongTuan1 == 0)
            {
                _cmbT1 = "";
            }
            else
                _cmbT1 = "X";
            if (dr.GetDecimal("TongTuan2") != null) _tongTuan2 = dr.GetDecimal("TongTuan2");
            if (_tongTuan2 == 0)
            {
                _cmbT2 = "";
            }
            else
                _cmbT2 = "X";

            if (dr.GetDecimal("TongTuan3") != null) _tongTuan3 = dr.GetDecimal("TongTuan3");

            if (_tongTuan3 == 0)
            {
                _cmbT3 = "";
            }
            else
                _cmbT3 = "X";

            if (dr.GetDecimal("TongTuan4") != null) _tongTuan4 = dr.GetDecimal("TongTuan4");

            if (_tongTuan4 == 0)
            {
                _cmbT4 = "";
            }
            else
                _cmbT4 = "X";
            if (dr.GetDecimal("TongTuan5") != null) _tongTuan5 = dr.GetDecimal("TongTuan5");
            if (_tongTuan5 == 0)
            {
                _cmbT5 = "";
            }
            else
                _cmbT5 = "X";
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

            if (dr.GetDecimal("HeSo1") != null) _heSo1 = dr.GetDecimal("HeSo1") * 100;
            if (dr.GetDecimal("HeSo2") != null) _heSo2 = dr.GetDecimal("HeSo2") * 100;
            if (dr.GetDecimal("HeSo3") != null) _heSo3 = dr.GetDecimal("HeSo3") * 100;
            if (dr.GetDecimal("HeSo4") != null) _heSo4 = dr.GetDecimal("HeSo4") * 100;
            if (dr.GetDecimal("Tien1") != null) _tien1 = dr.GetDecimal("Tien1");
            if (dr.GetDecimal("Tien2") != null) _tien2 = dr.GetDecimal("Tien2");
            if (dr.GetDecimal("Tien3") != null) _tien3 = dr.GetDecimal("Tien3");
            if (dr.GetDecimal("Tien4") != null) _tien4 = dr.GetDecimal("Tien4");
            if (dr.GetDecimal("Tien5") != null) _tien5 = dr.GetDecimal("Tien5");
            if (dr.GetString("MaPC1") != null) _maPC1 = dr.GetString("MaPC1");
            if (dr.GetString("MaPC2") != null) _maPC2 = dr.GetString("MaPC2");
            if (dr.GetString("MaPC3") != null) _maPC3 = dr.GetString("MaPC3");
            if (dr.GetString("MaPC4") != null) _maPC4 = dr.GetString("MaPC4");
            if (dr.GetSmartDate("Ngay1", true) != null) _ngay1 = dr.GetSmartDate("Ngay1", true);
            if (dr.GetSmartDate("Ngay2", true) != null) _ngay2 = dr.GetSmartDate("Ngay2", true);
            if (dr.GetSmartDate("Ngay3", true) != null) _ngay3 = dr.GetSmartDate("Ngay3", true);
            if (dr.GetSmartDate("Ngay4", true) != null) _ngay4 = dr.GetSmartDate("Ngay4", true);
            if (dr.GetSmartDate("Ngay5", true) != null) _ngay5 = dr.GetSmartDate("Ngay5", true);
            //_cmbT1 = "ABC";
            MarkOld();
        }
        protected Luong_NgoaiGio_NV(SafeDataReader dr)//lay nhung thang hien ra tren luoi
        {
            MarkAsChild();
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
            if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
            if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
            if (dr.GetString("MaPC") != null) _maPC = dr.GetString("MaPC");
            if (dr.GetDecimal("TongTuan1") != null) _tongTuan1 = dr.GetDecimal("TongTuan1");
            if (dr.GetDecimal("TongTuan2") != null) _tongTuan2 = dr.GetDecimal("TongTuan2");
            if (dr.GetDecimal("TongTuan3") != null) _tongTuan3 = dr.GetDecimal("TongTuan3");
            if (dr.GetDecimal("TongTuan4") != null) _tongTuan4 = dr.GetDecimal("TongTuan4");
            if (dr.GetDecimal("TongTuan5") != null) _tongTuan5 = dr.GetDecimal("TongTuan5");
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

            if (dr.GetDecimal("HeSo1") != null) _heSo1 = dr.GetDecimal("HeSo1")* 100;
            if (dr.GetDecimal("HeSo2") != null) _heSo2 = dr.GetDecimal("HeSo2")* 100;
            if (dr.GetDecimal("HeSo3") != null) _heSo3 = dr.GetDecimal("HeSo3")* 100;
            if (dr.GetDecimal("HeSo4") != null) _heSo4 = dr.GetDecimal("HeSo4")* 100;
            if (dr.GetDecimal("Tien1") != null) _tien1 = dr.GetDecimal("Tien1");
            if (dr.GetDecimal("Tien2") != null) _tien2 = dr.GetDecimal("Tien2");
            if (dr.GetDecimal("Tien3") != null) _tien3 = dr.GetDecimal("Tien3");
            if (dr.GetDecimal("Tien4") != null) _tien4 = dr.GetDecimal("Tien4");
            if (dr.GetDecimal("Tien5") != null) _tien4 = dr.GetDecimal("Tien5");
            if (dr.GetString("MaPC1") != null) _maPC1 = dr.GetString("MaPC1");
            if (dr.GetString("MaPC2") != null) _maPC2 = dr.GetString("MaPC2");
            if (dr.GetString("MaPC3") != null) _maPC3 = dr.GetString("MaPC3");
            if (dr.GetString("MaPC4") != null) _maPC4 = dr.GetString("MaPC4");
            if (dr.GetSmartDate("Ngay1", true) != null) _ngay1 = dr.GetSmartDate("Ngay1", true);
            if (dr.GetSmartDate("Ngay2", true) != null) _ngay2 = dr.GetSmartDate("Ngay2", true);
            if (dr.GetSmartDate("Ngay3", true) != null) _ngay3 = dr.GetSmartDate("Ngay3", true);
            if (dr.GetSmartDate("Ngay4", true) != null) _ngay4 = dr.GetSmartDate("Ngay4", true);
            if (dr.GetSmartDate("Ngay5", true) != null) _ngay5 = dr.GetSmartDate("Ngay5", true);
            MarkOld();
        }

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
		/// Retrieve an existing <see cref="Luong_NgoaiGio_NV" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetLuong_NgoaiGio_NV(Int32 _sTT, SmartDate _thang);
        //    // public override IDataReader GetLuong_NgoaiGio_NV(Int32 _sTT, SmartDate _thang)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _sTT, _thang));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetLuong_NgoaiGio_NV(crit.STT, crit.Thang.DBValue)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="Luong_NgoaiGio_NV" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
			if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
			if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
			if (dr.GetString("MaPC") != null) _maPC = dr.GetString("MaPC");
			if (dr.GetDecimal("TongTuan1") != null) _tongTuan1 = dr.GetDecimal("TongTuan1");
			if (dr.GetDecimal("TongTuan2") != null) _tongTuan2 = dr.GetDecimal("TongTuan2");
			if (dr.GetDecimal("TongTuan3") != null) _tongTuan3 = dr.GetDecimal("TongTuan3");
			if (dr.GetDecimal("TongTuan4") != null) _tongTuan4 = dr.GetDecimal("TongTuan4");
			if (dr.GetDecimal("TongTuan5") != null) _tongTuan5 = dr.GetDecimal("TongTuan5");
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

            if (dr.GetDecimal("HeSo1") != null) _heSo1 = dr.GetDecimal("HeSo1")* 100;
            if (dr.GetDecimal("HeSo2") != null) _heSo2 = dr.GetDecimal("HeSo2")* 100;
            if (dr.GetDecimal("HeSo3") != null) _heSo3 = dr.GetDecimal("HeSo3")* 100;
            if (dr.GetDecimal("HeSo4") != null) _heSo4 = dr.GetDecimal("HeSo4")* 100;
            if (dr.GetDecimal("Tien1") != null) _tien1 = dr.GetDecimal("Tien1");
            if (dr.GetDecimal("Tien2") != null) _tien2 = dr.GetDecimal("Tien2");
            if (dr.GetDecimal("Tien3") != null) _tien3 = dr.GetDecimal("Tien3");
            if (dr.GetDecimal("Tien4") != null) _tien4 = dr.GetDecimal("Tien4");
            if (dr.GetDecimal("Tien5") != null) _tien4 = dr.GetDecimal("Tien5");
            if (dr.GetString("MaPC1") != null) _maPC1 = dr.GetString("MaPC1");
            if (dr.GetString("MaPC2") != null) _maPC2 = dr.GetString("MaPC2");
            if (dr.GetString("MaPC3") != null) _maPC3 = dr.GetString("MaPC3");
            if (dr.GetString("MaPC4") != null) _maPC4 = dr.GetString("MaPC4");
            if (dr.GetSmartDate("Ngay1", true) != null) _ngay1 = dr.GetSmartDate("Ngay1", true);
            if (dr.GetSmartDate("Ngay2", true) != null) _ngay2 = dr.GetSmartDate("Ngay2", true);
            if (dr.GetSmartDate("Ngay3", true) != null) _ngay3 = dr.GetSmartDate("Ngay3", true);
            if (dr.GetSmartDate("Ngay4", true) != null) _ngay4 = dr.GetSmartDate("Ngay4", true);
            if (dr.GetSmartDate("Ngay5", true) != null) _ngay5 = dr.GetSmartDate("Ngay5", true);


		}
		
		/// <summary>
		/// Insert the new <see cref="Luong_NgoaiGio_NV" /> Object to underlying database.
		/// </summary>
        internal virtual void Insert(Luong_NgoaiGio  bill)
        {
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertLuong_NgoaiGio_NV
			// Copy & paste ham duoi day vao file DataProvider.cs
            
            
			bill.MaKhoa = DataProvider.Instance().InsertLuong_NgoaiGio_NV(_thang, _maNV, _maKhoa, _maPC, _tongTuan1, _tongTuan2, _tongTuan3, _tongTuan4, _tongTuan5, _tong, _ghiChu, _maMay, _nguoiSD);
			// public abstract Int32 InsertLuong_NgoaiGio_NV(SmartDate _thang, String _maNV, String _maKhoa, String _maPC, Decimal _tongTuan1, Decimal _tongTuan2, Decimal _tongTuan3, Decimal _tongTuan4, Decimal _tongTuan5, Decimal _tong, String _ghiChu, String _maMay, String _nguoiLap);
			// public override Int32 InsertLuong_NgoaiGio_NV(SmartDate _thang, String _maNV, String _maKhoa, String _maPC, Decimal _tongTuan1, Decimal _tongTuan2, Decimal _tongTuan3, Decimal _tongTuan4, Decimal _tongTuan5, Decimal _tong, String _ghiChu, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spLUONG_NgoaiGio_NV_CREATE", _sTT, _thang.DBValue, _maNV, _maKhoa, _maPC, _tongTuan1, _tongTuan2, _tongTuan3, _tongTuan4, _tongTuan5, _tong, _ghiChu, _maMay, _nguoiSD));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="Luong_NgoaiGio_NV" /> Object to underlying database.
		/// </summary>
        internal virtual void Update(Luong_NgoaiGio bill)
        {
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateLuong_NgoaiGio_NV
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateLuong_NgoaiGio_NV(_sTT, _thang, _maNV, _maKhoa, _maPC, _tongTuan1, _tongTuan2, _tongTuan3, _tongTuan4, _tongTuan5, _tong, _ghiChu, _maMay, _nguoiSD , _huy);
				// public abstract void UpdateLuong_NgoaiGio_NV(Int32 _sTT, SmartDate _thang, String _maNV, String _maKhoa, String _maPC, Decimal _tongTuan1, Decimal _tongTuan2, Decimal _tongTuan3, Decimal _tongTuan4, Decimal _tongTuan5, Decimal _tong, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
				// public override void UpdateLuong_NgoaiGio_NV(Int32 _sTT, SmartDate _thang, String _maNV, String _maKhoa, String _maPC, Decimal _tongTuan1, Decimal _tongTuan2, Decimal _tongTuan3, Decimal _tongTuan4, Decimal _tongTuan5, Decimal _tong, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spLUONG_NgoaiGio_NV_UPDATE", _sTT, _thang.DBValue, _maNV, _maKhoa, _maPC, _tongTuan1, _tongTuan2, _tongTuan3, _tongTuan4, _tongTuan5, _tong, _ghiChu, _maMay, _nguoiSD , _huy);
				// }				
			}
		}
        internal void DeleteSelf(Luong_NgoaiGio bill)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;

            DataProvider.Instance().DeleteLuong_NgoaiGio_NV(_maMay, _nguoiSD , _sTT, _thang);
            MarkNew();
        }

		/// <summary>
		/// Delete the <see cref="Luong_NgoaiGio_NV" />.
		/// </summary>
        //protected void DataPortal_Delete(Criteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateLuong_NgoaiGio_NV
        //    DataProvider.Instance().DeleteLuong_NgoaiGio_NV(crit.STT, crit.Thang.DBValue);
        //    // public abstract void DeleteLuong_NgoaiGio_NV(Int32 _sTT, SmartDate _thang);
        //    // public override void DeleteLuong_NgoaiGio_NV(Int32 _sTT, SmartDate _thang)
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spLUONG_NgoaiGio_NV_DELETED", _sTT, _thang);
        //    // }
        //}

		#endregion
	}

}
