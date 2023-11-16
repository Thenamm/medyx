// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	Luong_DocHai
// Kieu doi tuong  :	Luong_DocHai
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
	/// This is a base generated class of <see cref="Luong_DocHai" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class Luong_DocHai : BusinessBase<Luong_DocHai>
	{
		#region Business Methods
		
		#region State Fields
		
		private Int32 _sTT = 0;
		private SmartDate _thang = new SmartDate(true);
		private String _maNV = String.Empty;
		private String _makhoa = String.Empty;
        private String _maPCDocHai = String.Empty;
        private Decimal _heSoDocHai = 0;
        private Decimal _ngayCong = 0;
        private Decimal _ngayCongDocHai = 0;
        private Decimal _thanhTienDocHai = 0;
        private String _maPCHienVat = String.Empty;
        private Decimal _donGiaHienVat = 0;
        private Decimal _thanhTienHienVat = 0;
        private String _maPCTrachNhiem = String.Empty;
        private Decimal _heSoTrachNhiem = 0;
        private Decimal _mucLuongCB = 0;
        private Decimal _mucLuongDocHai = 0;
        private Decimal _thanhTienTrachNhiem = 0;
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

        public string MaPCDocHai
        {
            get
            {
                CanReadProperty("MaPCDocHai", true);
                return _maPCDocHai;
            }
            set
            {
                CanWriteProperty("MaPCDocHai", true);
                if (_maPCDocHai != value)
                {
                    _maPCDocHai = value;
                    PropertyHasChanged("Makhoa");
                }
            }
        }

        public string  HeSoDocHai
        {
            get
            {
                CanReadProperty("HeSoDocHai", true);

                if (_heSoDocHai  == 0)
                {
                    return "";
                }
                else if (_heSoDocHai - (int)(_heSoDocHai) != 0)
                    return _heSoDocHai.ToString("###,##0.##");
                else
                    return _heSoDocHai.ToString("###,###");
                   
               
            }
            set
            {
                CanWriteProperty("HeSoDocHai", true);

                if (_heSoDocHai.ToString() != value)
                {
                    if (value == "")
                        _heSoDocHai = 0;
                    else
                        _heSoDocHai = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("HeSoDocHai");
                }
            }
        }


        public string  NgayCong
        {
            get
            {
                CanReadProperty("NgayCong", true);
                //if ((_ngayCong !=0) && (_ngayCongDocHai != 0) && (_maPCDocHai != ""))
                //    _ngayCongDocHai = _ngayCong;
                if (_ngayCong == 0)
                {
                    return "";
                }
                else if (_ngayCong - (int)(_ngayCong) != 0)
                    return _ngayCong.ToString("###,##0.##");
                else
                    return _ngayCong.ToString("###,###");
            }
            set
            {
                CanWriteProperty("NgayCong", true);

                if (_ngayCong.ToString() != value)
                {
                    if (value == "")
                        _ngayCong = 0;
                    else
                        _ngayCong = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("NgayCong");
                }
            }
        }

        public string NgayCongDocHai
        {
            get
            {
                CanReadProperty("NgayCongDocHai", true);
                
                if (_ngayCongDocHai == 0)
                {
                    return "";
                }
                else if (_ngayCongDocHai - (int)(_ngayCongDocHai) != 0)
                    return _ngayCongDocHai.ToString("###,##0.##");
                else
                    return _ngayCongDocHai.ToString("###,###");
            }
            set
            {
                CanWriteProperty("NgayCongDocHai", true);

                if (_ngayCongDocHai.ToString() != value)
                {
                    if (value == "")
                        _ngayCongDocHai = 0;
                    else
                        _ngayCongDocHai = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("NgayCongDocHai");
                }
            }
        }

        public string ThanhTienDocHai
        {
            get
            {
                CanReadProperty("ThanhTienDocHai", true);
                //_thanhTienDocHai= (_heSoDocHai*_ngayCong*_mucLuongDocHai )/22;
                _thanhTienDocHai = (_heSoDocHai * _ngayCong * _mucLuongDocHai)/22;
                if (_thanhTienDocHai == 0)
                {
                    return "";
                }
                else if (_thanhTienDocHai - (int)(_thanhTienDocHai) != 0)
                    return _thanhTienDocHai.ToString("###,###.##");
                else
                    return _thanhTienDocHai.ToString("###,###");
            }
            set
            {
                CanWriteProperty("ThanhTienDocHai", true);

                if (_thanhTienDocHai.ToString() != value)
                {
                    if (value == "")
                        _thanhTienDocHai = 0;
                    else
                        _thanhTienDocHai = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("ThanhTienDocHai");
                }
            }
        }


        public String MaPCHienVat
        {
            get
            {
                CanReadProperty("MaPCHienVat", true);
                return _maPCHienVat;
            }
            set
            {
                CanWriteProperty("MaPCHienVat", true);
                if (_maPCHienVat != value)
                {
                    _maPCHienVat = value;
                    PropertyHasChanged("MaPCHienVat");
                }
            }
        }

        public string  DonGiaHienVat
        {
            get
            {
                CanReadProperty("DonGiaHienVat", true);
                if (_donGiaHienVat == 0)
                {
                    return "";
                }
                //else if (_donGiaHienVat - (int)(_donGiaHienVat) != 0)
                //    return _donGiaHienVat.ToString("###,###.##");
                else
                    return _donGiaHienVat.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DonGiaHienVat", true);

                if (_donGiaHienVat.ToString() != value)
                {
                    if (value == "")
                        _donGiaHienVat = 0;
                    else
                        _donGiaHienVat = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaHienVat");
                }
            }
        }
        public string ThanhTienHienVat
        {
            get
            {
                CanReadProperty("ThanhTienHienVat", true);
                _thanhTienHienVat = _ngayCong * _donGiaHienVat;
                if (_thanhTienHienVat == 0)
                {
                    return "";
                }
               
                else
                    return _thanhTienHienVat.ToString("###,###");
            }
            set
            {
                CanWriteProperty("ThanhTienHienVat", true);

                if (_thanhTienHienVat.ToString() != value)
                {
                    if (value == "")
                        _thanhTienHienVat = 0;
                    else
                        _thanhTienHienVat = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("ThanhTienHienVat");
                }
            }
        }
        public String MaPCTrachNhiem
        {
            get
            {
                CanReadProperty("MaPCTrachNhiem", true);
                return _maPCTrachNhiem;
            }
            set
            {
                CanWriteProperty("MaPCTrachNhiem", true);
                if (_maPCTrachNhiem != value)
                {
                    _maPCTrachNhiem = value;
                    PropertyHasChanged("MaPCTrachNhiem");
                }
            }
        }

        public string  HeSoTrachNhiem
        {
            get
            {
                CanReadProperty("HeSoTrachNhiem", true);
                if (_heSoTrachNhiem == 0)
                {
                    return "";
                }
                else
                    return _heSoTrachNhiem.ToString("###,##0.##");
                
            }
            set
            {
                CanWriteProperty("HeSoTrachNhiem", true);

                if (_heSoTrachNhiem.ToString() != value)
                {
                    if (value == "")
                        _heSoTrachNhiem = 0;
                    else
                        _heSoTrachNhiem = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("HeSoTrachNhiem");
                }
            }
        }

        public string  MucLuongCB
        {
            get
            {
                CanReadProperty("MucLuongCB", true);
                if (_mucLuongCB == 0)
                {
                    return "";
                }
                //else if (_MucLuongCB - (int)(_MucLuongCB) != 0)
                //    return _MucLuongCB.ToString("###,###.##");
                else
                    return _mucLuongCB.ToString("###,###");
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
        public string ThanhTienTrachNhiem
        {
            get
            {
                CanReadProperty("ThanhTienTrachNhiem", true);
                _thanhTienTrachNhiem = _heSoTrachNhiem * _mucLuongCB;
                if (_thanhTienTrachNhiem == 0)
                {
                    return "";
                }
                else if (_thanhTienTrachNhiem - (int)(_thanhTienTrachNhiem) != 0)
                    return _thanhTienTrachNhiem.ToString("###,###.##");
                else
                    return _thanhTienTrachNhiem.ToString("###,###");
            }
            set
            {
                CanWriteProperty("ThanhTienTrachNhiem", true);

                if (_thanhTienTrachNhiem.ToString() != value)
                {
                    if (value == "")
                        _thanhTienTrachNhiem = 0;
                    else
                        _thanhTienTrachNhiem = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("ThanhTienTrachNhiem");
                }
            }
        }
        public string  MucLuongDocHai
        {
            get
            {
                CanReadProperty("MucLuongDocHai", true);
                if (_mucLuongDocHai == 0)
                {
                    return "";
                }
               
                else
                    return _mucLuongDocHai.ToString("###,###");
            }
            set
            {
                CanWriteProperty("MucLuongDocHai", true);

                if (_mucLuongDocHai.ToString() != value)
                {
                    if (value == "")
                        _mucLuongDocHai = 0;
                    else
                        _mucLuongDocHai = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("MucLuongDocHai");
                }
            }
        }
        public string  Tong
        {
            get
            {
                CanReadProperty("Tong", true);
                _tong = _thanhTienDocHai + _thanhTienHienVat + _thanhTienTrachNhiem;
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
		/// Factory method. New <see cref="Luong_DocHai" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static Luong_DocHai NewLuong_DocHai()
        {
            return new Luong_DocHai();
            // return DataPortal.Create<BC_DuocBV>();
        }

        internal static Luong_DocHai GetLuong_DocHai(SafeDataReader dr, int i)
        {
            return new Luong_DocHai(dr, i);
        }
        //public static Luong_DocHai GetLuong_DocHai(Int32 sTT, SmartDate thang)
        //{
        //    return DataPortal.Fetch<Luong_DocHai>(new Criteria(sTT, thang));
        //}
        public Luong_DocHai()
        {
            MarkAsChild();
        }
		/// <summary>
		/// Marks the <see cref="Luong_DocHai" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteLuong_DocHai(Int32 sTT, SmartDate thang)
        //{
        //    DataPortal.Delete(new Criteria(sTT, thang));
        //}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal Luong_DocHai()
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
		/// Retrieve an existing <see cref="Luong_DocHai" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetLuong_DocHai(Int32 _sTT, SmartDate _thang);
        //    // public override IDataReader GetLuong_DocHai(Int32 _sTT, SmartDate _thang)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _sTT, _thang));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetLuong_DocHai(crit.STT, crit.Thang.DBValue)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="Luong_DocHai" /> Object from given SafeDataReader.
		/// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
        //    if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
        //    if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
        //    if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
        //    if (dr.GetDecimal("MucLuong_DocHaiCB") != null) _mucLuong_DocHaiCB = dr.GetDecimal("MucLuong_DocHaiCB");
        //    if (dr.GetDecimal("HeSoLuong_DocHai") != null) _heSoLuong_DocHai = dr.GetDecimal("HeSoLuong_DocHai");
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
        private Luong_DocHai(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
			if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
			if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
            if (dr.GetString("MaPCDocHai") != null) _maPCDocHai = dr.GetString("MaPCDocHai");
            if (dr.GetDecimal("HeSoDocHai") != null) _heSoDocHai = dr.GetDecimal("HeSoDocHai");
            if (dr.GetDecimal("NgayCong") != null) _ngayCong = dr.GetDecimal("NgayCong");
            if (dr.GetDecimal("NgayCongDocHai") != null) _ngayCongDocHai = dr.GetDecimal("NgayCongDocHai");

            if (dr.GetString("MaPCHienVat") != null) _maPCHienVat = dr.GetString("MaPCHienVat");
            if (dr.GetDecimal("DonGiaHienVat") != null) _donGiaHienVat = dr.GetDecimal("DonGiaHienVat");
            if (dr.GetString("MaPCTrachNhiem") != null) _maPCTrachNhiem = dr.GetString("MaPCTrachNhiem");
            if (dr.GetDecimal("HeSoTrachNhiem") != null) _heSoTrachNhiem = dr.GetDecimal("HeSoTrachNhiem");
            if (dr.GetDecimal("MucLuongCB") != null) _mucLuongCB = dr.GetDecimal("MucLuongCB");
            if (dr.GetDecimal("MucLuongDocHai") != null) _mucLuongDocHai = dr.GetDecimal("MucLuongDocHai");
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
            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="Luong_DocHai" /> Object to underlying database.
		/// </summary>
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
            
            _sTT = DataProvider.Instance().InsertLuong_DocHai(_thang, _maNV, _makhoa, _maPCDocHai, _heSoDocHai, _ngayCong, _maPCHienVat, _donGiaHienVat, _maPCTrachNhiem, _heSoTrachNhiem, _mucLuongCB, _mucLuongDocHai, _tong, _ghiChu, _maMay, _nguoiSD , _ngayCongDocHai);
            // public abstract Int32 InsertLuong_DocHai(SmartDate _thang, String _maNV, String _makhoa, String _maPCDocHai, Decimal _heSoDocHai, Decimal _ngayCong, String _maPCHienVat, Decimal _donGiaHienVat, String _maPCTrachNhiem, Decimal _heSoTrachNhiem, Decimal _mucLuongCB, Decimal _mucLuongDocHai, Decimal _tong, String _ghiChu, String _maMay, String _nguoiLap);
            // public override Int32 InsertLuong_DocHai(SmartDate _thang, String _maNV, String _makhoa, String _maPCDocHai, Decimal _heSoDocHai, Decimal _ngayCong, String _maPCHienVat, Decimal _donGiaHienVat, String _maPCTrachNhiem, Decimal _heSoTrachNhiem, Decimal _mucLuongCB, Decimal _mucLuongDocHai, Decimal _tong, String _ghiChu, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_DocHai_CREATE", _thang.DBValue, _maNV, _makhoa, _maPCDocHai, _heSoDocHai, _ngayCong, _maPCHienVat, _donGiaHienVat, _maPCTrachNhiem, _heSoTrachNhiem, _mucLuongCB, _mucLuongDocHai, _tong, _ghiChu, _maMay, _nguoiSD);
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="Luong_DocHai" /> Object to underlying database.
		/// </summary>
		 internal void Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
			 if (!this.IsDirty)
                return;
                
                  
                DataProvider.Instance().UpdateLuong_DocHai(_sTT, _thang, _maNV, _makhoa, _maPCDocHai, _heSoDocHai, _ngayCong, _maPCHienVat, _donGiaHienVat, _maPCTrachNhiem, _heSoTrachNhiem, _mucLuongCB, _mucLuongDocHai, _tong, _ghiChu, _maMay, _nguoiSD , _huy, _ngayCongDocHai);
                // public abstract void UpdateLuong_DocHai(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, String _maPCDocHai, Decimal _heSoDocHai, Decimal _ngayCong, String _maPCHienVat, Decimal _donGiaHienVat, String _maPCTrachNhiem, Decimal _heSoTrachNhiem, Decimal _mucLuongCB, Decimal _mucLuongDocHai, Decimal _tong, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
                // public override void UpdateLuong_DocHai(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, String _maPCDocHai, Decimal _heSoDocHai, Decimal _ngayCong, String _maPCHienVat, Decimal _donGiaHienVat, String _maPCTrachNhiem, Decimal _heSoTrachNhiem, Decimal _mucLuongCB, Decimal _mucLuongDocHai, Decimal _tong, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_DocHai_UPDATE", _sTT, _thang.DBValue, _maNV, _makhoa, _maPCDocHai, _heSoDocHai, _ngayCong, _maPCHienVat, _donGiaHienVat, _maPCTrachNhiem, _heSoTrachNhiem, _mucLuongCB, _mucLuongDocHai, _tong, _ghiChu, _maMay, _nguoiSD , _huy);
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
		/// Delete the <see cref="Luong_DocHai" />.
		/// </summary>
        protected void DataPortal_Delete(CriteriaOther crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateLuong_DocHai
            DataProvider.Instance().DeleteLuong_DocHai(crit.MaMay, crit.NguoiSD, crit.STT, crit.Thang);
			// public abstract void DeleteLuong_DocHai(Int32 _sTT, SmartDate _thang);
			// public override void DeleteLuong_DocHai(Int32 _sTT, SmartDate _thang);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_DocHai_DELETED", _sTT, _thang);
			// }
		}

		#endregion
	}

}
