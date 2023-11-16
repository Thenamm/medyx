// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	Luong_BoiDuongPT_NV
// Kieu doi tuong  :	Luong_BoiDuongPT_NV
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
	/// This is a base generated class of <see cref="Luong_BoiDuongPT_NV" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class Luong_BoiDuongPT_NV : BusinessBase<Luong_BoiDuongPT_NV>
	{
		#region Business Methods
		
		#region State Fields
		
		private Int32 _sTT = 0;
		private SmartDate _thang = new SmartDate(true);
		private String _maNV = String.Empty;
		private String _maKhoa = String.Empty;
        private Decimal _heSo = 0;      
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
        private Decimal _hesoPTHS = 0;
        private Decimal _TongTien = 0;
        private Decimal _TongTienD = 0;
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

        public String HeSoPTHS
        {
            get
            {
                CanReadProperty("HePTHS", true);
                if (_hesoPTHS == 0)
                {
                    return "";
                }
                else
                {
                    return _hesoPTHS.ToString("###,##0.00");
                }
            }
            set
            {
                CanWriteProperty("HePTHS", true);
                if (_hesoPTHS.ToString() != value)
                {
                    if (value == "")
                        _hesoPTHS = 0;
                    else
                        _hesoPTHS = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("HeSo");
                }
            }
        }

        public String TongTien
        {
            get
            {
                CanReadProperty("TongTien", true);
                if (_TongTien == 0)
                {
                    return "";
                }
                else
                {
                    return _TongTien.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("TongTien", true);
                if (_TongTien.ToString() != value)
                {
                    if (value == "")
                        _TongTien = 0;
                    else
                        _TongTien = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("HeSo");
                }
            }
        }

        public String TongTienD
        {
            get
            {
                if (_TongTienD == 0)
                {
                    return "";
                }
                else
                {
                    return _TongTienD.ToString("###,###");
                }
            }
            set
            {
                if (_TongTienD.ToString() != value)
                {
                    if (value == "")
                        _TongTienD = 0;
                    else
                        _TongTienD = decimal.Parse(value.Replace(",", ""));
                }
            }
        }

        public String Tong
        {
            get
            {
                CanReadProperty("Tong", true);
                _tong = (_heSo * _TongTien * _hesoPTHS)/100;
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
                    PropertyHasChanged("HeSo");
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
		/// Factory method. New <see cref="Luong_BoiDuongPT_NV" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static Luong_BoiDuongPT_NV NewLuong_BoiDuongPT_NV()
        {
            return new Luong_BoiDuongPT_NV();

        }
        public static Luong_BoiDuongPT_NV NewLuong_BoiDuongPT_NV(string maNhanvien)
        {
            return new Luong_BoiDuongPT_NV(DMNhanVien.GetDMNhanVien(maNhanvien));
        }
        public static Luong_BoiDuongPT_NV NewLuong_BoiDuongPT_NV(DMNhanVien _DMNhanVien)
        {
            return new Luong_BoiDuongPT_NV(_DMNhanVien);
        }
		public static Luong_BoiDuongPT_NV GetLuong_BoiDuongPT_NV(Int32 sTT, SmartDate thang)
		{
			return DataPortal.Fetch<Luong_BoiDuongPT_NV>(new Criteria(sTT, thang));
		}
        public static Luong_BoiDuongPT_NV GetLuong_BoiDuongPT_NV(SafeDataReader dr)
        {
            return new Luong_BoiDuongPT_NV(dr);
        }
        public static Luong_BoiDuongPT_NV GetLuong_BoiDuongPT_NV(SafeDataReader dr, int i)
        {
            return new Luong_BoiDuongPT_NV(dr, i);
        }
		/// <summary>
		/// Marks the <see cref="Luong_BoiDuongPT_NV" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteLuong_BoiDuongPT_NV(string makhoa, SmartDate thang, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new CriteriaOther(mamay,nguoihuy , makhoa, thang));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal Luong_BoiDuongPT_NV()
		{	
			// Prevent direct creation
		}
        protected Luong_BoiDuongPT_NV(DMNhanVien pro)
        {
            MarkAsChild();

            //_maPhieu = dr.GetString("MaPhieu");
            _maNV = pro.MaNV;
           
        }
        protected Luong_BoiDuongPT_NV(string _MaKhoa, DMNhanVien pro)
        {
            MarkAsChild();
            _MaKhoa = _MaKhoa ;
            _maNV = pro.MaNV;
            _maMay = pro.MaMay;
            _huy = pro.Huy;
            _nguoiSD = pro.NguoiSD;
             
            //MarkOld();
        }
        protected Luong_BoiDuongPT_NV(SafeDataReader dr)//lay nhung thang hien ra tren luoi
        {
            MarkAsChild();

            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
            if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
            if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
            if (dr.GetDecimal("HeSo") != null) _heSo = dr.GetDecimal("HeSo");
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
            if (dr.GetDecimal("HeSoPTHS") != null) _hesoPTHS = dr.GetDecimal("HeSoPTHS");
            if (dr.GetDecimal("TongTien") != null) _TongTien = dr.GetDecimal("TongTien");

            MarkOld();
        }
        protected Luong_BoiDuongPT_NV(SafeDataReader dr, int i)//lay nhung thang hien ra tren luoi
        {
            MarkAsChild();
            _OrderNumber = i;
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
            if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
            if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
            if (dr.GetDecimal("HeSo") != null) _heSo = dr.GetDecimal("HeSo");
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
            if (dr.GetDecimal("HeSoPTHS") != null) _hesoPTHS = dr.GetDecimal("HeSoPTHS");
            if (dr.GetDecimal("TongTien") != null) _TongTien = dr.GetDecimal("TongTien");

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
            //private Int32 _sTT;
            //public Int32 STT
            //{
            //    get
            //    {
            //        return _sTT;
            //    }
            //}
            private string _Makhoa;
            public string Makhoa
            {
                get
                {
                    return _Makhoa;
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
            public CriteriaOther(String Mamay, String Nguoisd, string makhoa, SmartDate thang)
            {
               // _sTT = sTT;
                _Makhoa = makhoa;
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
		/// Retrieve an existing <see cref="Luong_BoiDuongPT_NV" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetLuong_BoiDuongPT_NV(Int32 _sTT, SmartDate _thang);
        //    // public override IDataReader GetLuong_BoiDuongPT_NV(Int32 _sTT, SmartDate _thang)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _sTT, _thang));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetLuong_BoiDuongPT_NV(crit.STT, crit.Thang.DBValue)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="Luong_BoiDuongPT_NV" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
			if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
            if (dr.GetDecimal("HeSo") != null) _heSo = dr.GetDecimal("HeSo");
            
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
            if (dr.GetDecimal("HeSoPTHS") != null) _hesoPTHS = dr.GetDecimal("HeSoPTHS");

		}
		
		/// <summary>
		/// Insert the new <see cref="Luong_BoiDuongPT_NV" /> Object to underlying database.
		/// </summary>
        internal virtual void Insert(Luong_BoiDuongPT  bill)
        {
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertLuong_BoiDuongPT_NV
			// Copy & paste ham duoi day vao file DataProvider.cs
            
            
            bill.MaKhoa = DataProvider.Instance().InsertLuong_BoiDuongPT_NV(_thang, _maNV, _maKhoa, _heSo, _tong, _ghiChu, _maMay, _nguoiSD);
            // public abstract Int32 InsertLuong_BoiDuongPT_NV(SmartDate _thang, String _maNV, String _maKhoa, Decimal _heSo, Decimal _tong, String _ghiChu, String _maMay, String _nguoiLap);
            // public override Int32 InsertLuong_BoiDuongPT_NV(SmartDate _thang, String _maNV, String _maKhoa, Decimal _heSo, Decimal _tong, String _ghiChu, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_BoiDuongPT_NV_CREATE", _sTT, _thang.DBValue, _maNV, _maKhoa, _heSo, _tong, _ghiChu, _maMay, _nguoiSD));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="Luong_BoiDuongPT_NV" /> Object to underlying database.
		/// </summary>
        internal virtual void Update(Luong_BoiDuongPT bill)
        {
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateLuong_BoiDuongPT_NV
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateLuong_BoiDuongPT_NV(_sTT, _thang, _maNV, _maKhoa, _heSo, _tong, _ghiChu, _maMay, _nguoiSD , _huy);
                // public abstract void UpdateLuong_BoiDuongPT_NV(Int32 _sTT, SmartDate _thang, String _maNV, String _maKhoa, Decimal _heSo, Decimal _tong, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
                // public override void UpdateLuong_BoiDuongPT_NV(Int32 _sTT, SmartDate _thang, String _maNV, String _maKhoa, Decimal _heSo, Decimal _tong, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_BoiDuongPT_NV_UPDATE", _sTT, _thang.DBValue, _maNV, _maKhoa, _heSo, _tong, _ghiChu, _maMay, _nguoiSD , _huy);
				// }				
			}
		}
        internal void DeleteSelf(Luong_BoiDuongPT bill)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;

            DataProvider.Instance().DeleteLuong_BoiDuongPT_NV(_maMay, _nguoiSD , _sTT, _thang);
            MarkNew();
        }

		/// <summary>
		/// Delete the <see cref="Luong_BoiDuongPT_NV" />.
		/// </summary>
        //protected void DataPortal_Delete(Criteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateLuong_BoiDuongPT_NV
        //    DataProvider.Instance().DeleteLuong_BoiDuongPT_NV(crit.STT, crit.Thang.DBValue);
        //    // public abstract void DeleteLuong_BoiDuongPT_NV(Int32 _sTT, SmartDate _thang);
        //    // public override void DeleteLuong_BoiDuongPT_NV(Int32 _sTT, SmartDate _thang)
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_BoiDuongPT_NV_DELETED", _sTT, _thang);
        //    // }
        //}

		#endregion
	}

}
