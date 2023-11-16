// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	Luong_M1
// Kieu doi tuong  :	Luong_M1
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
	/// This is a base generated class of <see cref="Luong_M1" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class Luong_M1 : BusinessBase<Luong_M1>
	{
		#region Business Methods
		
		#region State Fields
		
		private Int32 _sTT = 0;
		private SmartDate _thang = new SmartDate(true);
		private String _maNV = String.Empty;
		private String _makhoa = String.Empty;
        private Decimal _heSoChucVu = 0;
        private Decimal _heSo = 0;
        private Decimal _bHXH = 0;
        private Decimal _bHYT = 0;
        private Decimal _congDoan = 0;
        private Decimal _bHXHCu = 0;
        private Decimal _bHYTCu = 0;
        private Decimal _congDoanCu = 0;
        private Decimal _bHXHTien = 0;
        private Decimal _bHYTTien = 0;
        private Decimal _congDoanTien = 0;
        private Decimal _mucLuongCB = 0;
        private Decimal _tong = 0;
        private decimal _congHeSo = 0;
        private decimal _duocLinh= 0;
        private decimal _thucLinh = 0;
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

        public string HeSoChucVu
        {
            get
            {
                CanReadProperty("HeSoChucVu", true);
                if (_heSoChucVu == 0)
                {
                    return "";
                }
                else if (_heSoChucVu - (int)(_heSoChucVu) != 0)
                    return _heSoChucVu.ToString("###,##0.##");
                else
                    return _heSoChucVu.ToString("###,###");
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
                    PropertyHasChanged("HeSoChucVu");
                }
            }
        }
        public string DuocLinh
        {
            get
            {
                CanReadProperty("DuocLinh", true);
                _duocLinh = _tong - (_bHYTTien + _bHXHTien + _congDoanTien);
                if (_duocLinh == 0)
                {
                    return "";
                }
                else if (_duocLinh - (int)(_duocLinh) != 0)
                    return _duocLinh.ToString("###,##0.##");
                else
                    return _duocLinh.ToString("###,###");

            }
            set
            {
                CanWriteProperty("DuocLinh", true);

                if (_duocLinh.ToString() != value)
                {
                    if (value == "")
                        _duocLinh = 0;
                    else
                        _duocLinh = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DuocLinh");
                }
            }
        }
        public string CongHeSo
        {
            get
            {
                CanReadProperty("CongHeSo", true);
                _congHeSo = _heSo + _heSoChucVu;
                if (_congHeSo == 0)
                {
                    return "";
                }
                else
                    return _congHeSo.ToString("###,##0.##");
            
            }
            set
            {
                CanWriteProperty("CongHeSo", true);

                if (_congHeSo.ToString() != value)
                {
                    if (value == "")
                        _congHeSo = 0;
                    else
                        _congHeSo = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("CongHeSo");
                }
            }
        }
        public string ThucLinh
        {
            get
            {
                CanReadProperty("ThucLinh", true);
                _thucLinh = _duocLinh; 
                if (_thucLinh == 0)
                {
                    return "";
                }
                return _thucLinh.ToString("###,###");

            }
            set
            {
                CanWriteProperty("ThucLinh", true);

                if (_thucLinh.ToString() != value)
                {
                    if (value == "")
                        _thucLinh = 0;
                    else
                        _thucLinh = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("ThucLinh");
                }
            }
        }
        public string  HeSo
        {
            get
            {
                CanReadProperty("HeSo", true);
                if (_heSo  == 0)
                {
                    return "";
                }
                else if (_heSo - (int)(_heSo) != 0)
                    return _heSo.ToString("###,##0.##");
                else
                    return _heSo.ToString("###,###");

            }
            set
            {
                CanWriteProperty("HeSo", true);

                if (_heSo .ToString() != value)
                {
                    if (value == "")
                        _heSo  = 0;
                    else
                        _heSo  = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("HeSo");
                }
            }
        }

        public string  BHXH
        {
            get
            {
                CanReadProperty("BHXH", true);
                //_bHXH = (_tong * 5) / 100;

                return _bHXH.ToString("###,##0.##");

            }
            set
            {
                CanWriteProperty("BHXH", true);

                if (_bHXH.ToString() != value)
                {
                    if (value == "")
                        _bHXH = 0;
                    else
                        _bHXH = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("BHXH");
                }
            }
        }
        public string BHXHTien
        {
            get
            {
                CanReadProperty("BHXHTien", true);
                _bHXHTien = (_mucLuongCB * _congHeSo * _bHXH);
                if (_bHXHTien == 0)
                {
                    return "";
                }

                else
                {
                    return _bHXHTien.ToString("###,###");
                }

            }
            set
            {
                CanWriteProperty("BHXHTien", true);

                if (_bHXHTien.ToString() != value)
                {
                    if (value == "")
                    {
                        _bHXH = 0;
                        _bHXHTien = 0;
                    }
                    else
                    {
                        _bHXH = _bHXHCu;
                        _bHXHTien = decimal.Parse(value.Replace(",", ""));
                    }
                    PropertyHasChanged("BHXHTien");
                }
            }
        }

        public String  BHYT
        {
            get
            {
                CanReadProperty("BHYT", true);
              
                    return _bHYT.ToString("###,##0.##");

            }
            set
            {
                CanWriteProperty("BHYT", true);

                if (_bHYT.ToString() != value)
                {
                    if (value == "")
                        _bHYT = 0;
                    else
                        _bHYT = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("BHYT");
                }
            }
        }
        public string BHYTTien
        {
            get
            {
                CanReadProperty("BHYTTien", true);
                _bHYTTien = (_mucLuongCB * _congHeSo * _bHYT);
                if (_bHYTTien == 0)
                {
                    return "";
                }

                else
                {
                    return _bHYTTien.ToString("###,###");
                }

            }
            set
            {
                CanWriteProperty("BHYTTien", true);

                if (_bHYTTien.ToString() != value)
                {
                    if (value == "")
                    {
                        _bHXH = 0;
                        _bHYTTien = 0;
                    }
                    else
                    {
                        _bHXH = _bHXHCu;
                        _bHYTTien = decimal.Parse(value.Replace(",", ""));
                    }
                    PropertyHasChanged("BHYTTien");
                }
            }
        }
        public string  CongDoan
        {
            get
            {
                CanReadProperty("CongDoan", true);
               
       
                    return _congDoan.ToString("###,##0.##");

            }
            set
            {
                CanWriteProperty("CongDoan", true);

                if (_congDoan.ToString() != value)
                {
                    if (value == "")
                   
                        _congDoan = 0;
                    else
                        _congDoan = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("CongDoan");
                }
            }
        }
        public string CongDoanTien
        {
            get
            {
                CanReadProperty("CongDoanTien", true);
                _congDoanTien = (_mucLuongCB * _congHeSo * _congDoan);
                if (_congDoanTien == 0)
                {
                    return "";
                }

                else
                {
                    return _congDoanTien.ToString("###,###");
                }

            }
            set
            {
                CanWriteProperty("CongDoanTien", true);

                if (_congDoanTien.ToString() != value)
                {
                    if (value == "")
                    {
                        _congDoan = 0;
                        _congDoanTien = 0;
                    }
                    else
                    {
                        _congDoan = _congDoanCu;
                        _congDoanTien = decimal.Parse(value.Replace(",", ""));
                    }
                    PropertyHasChanged("CongDoanTien");
                }
            }
        }
        public string  MucLuongCB
        {
            get
            {
                CanReadProperty("MucLuongCB", true);
               
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

        public string  Tong
        {
            get
            {
                CanReadProperty("Tong", true);
                _tong = _mucLuongCB * _congHeSo; 
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
			return _sTT.ToString() + "!" + _thang.ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="Luong_M1" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static Luong_M1 NewLuong_M1()
        {
            return new Luong_M1();
            // return DataPortal.Create<BC_DuocBV>();
        }

        internal static Luong_M1 GetLuong_M1(SafeDataReader dr, int i)
        {
            return new Luong_M1(dr, i);
        }
        //public static Luong_M1 GetLuong_M1(Int32 sTT, SmartDate thang)
        //{
        //    return DataPortal.Fetch<Luong_M1>(new Criteria(sTT, thang));
        //}
        public Luong_M1()
        {
            MarkAsChild();
        }
		/// <summary>
		/// Marks the <see cref="Luong_M1" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteLuong_M1(Int32 sTT, SmartDate thang)
        //{
        //    DataPortal.Delete(new Criteria(sTT, thang));
        //}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal Luong_M1()
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
		/// Retrieve an existing <see cref="Luong_M1" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetLuong_M1(Int32 _sTT, SmartDate _thang);
        //    // public override IDataReader GetLuong_M1(Int32 _sTT, SmartDate _thang)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _sTT, _thang));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetLuong_M1(crit.STT, crit.Thang.DBValue)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="Luong_M1" /> Object from given SafeDataReader.
		/// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
        //    if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
        //    if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
        //    if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
        //    if (dr.GetDecimal("MucLuong_M1CB") != null) _mucLuong_M1CB = dr.GetDecimal("MucLuong_M1CB");
        //    if (dr.GetDecimal("HeSoLuong_M1") != null) _heSoLuong_M1 = dr.GetDecimal("HeSoLuong_M1");
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
        private Luong_M1(SafeDataReader dr, int i)
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
            if (dr.GetDecimal("BHXH") != null) _bHXH = dr.GetDecimal("BHXH");
            if (dr.GetDecimal("BHYT") != null) _bHYT = dr.GetDecimal("BHYT");
            if (dr.GetDecimal("CongDoan") != null) _congDoan = dr.GetDecimal("CongDoan");
            if (dr.GetDecimal("BHXH") != null) _bHXHCu = dr.GetDecimal("BHXH");
            if (dr.GetDecimal("BHYT") != null) _bHYTCu = dr.GetDecimal("BHYT");
            if (dr.GetDecimal("CongDoan") != null) _congDoanCu = dr.GetDecimal("CongDoan");
            if (dr.GetDecimal("MucLuongCB") != null) _mucLuongCB = dr.GetDecimal("MucLuongCB");
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
		/// Insert the new <see cref="Luong_M1" /> Object to underlying database.
		/// </summary>
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
            
            _sTT = DataProvider.Instance().InsertLuong_M1(_thang, _maNV, _makhoa, _heSoChucVu, _heSo, _bHXH, _bHYT, _congDoan, _mucLuongCB, _tong, _ghiChu, _maMay, _nguoiSD);
            // public abstract Int32 InsertLuong_M1(SmartDate _thang, String _maNV, String _makhoa, Decimal _heSoChucVu, Decimal _heSo, Decimal _bHXH, Decimal _bHYT, Decimal _congDoan, Decimal _mucLuongCB, Decimal _tong, String _ghiChu, String _maMay, String _nguoiLap);
            // public override Int32 InsertLuong_M1(SmartDate _thang, String _maNV, String _makhoa, Decimal _heSoChucVu, Decimal _heSo, Decimal _bHXH, Decimal _bHYT, Decimal _congDoan, Decimal _mucLuongCB, Decimal _tong, String _ghiChu, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_M1_CREATE", _thang.DBValue, _maNV, _makhoa, _heSoChucVu, _heSo, _bHXH, _bHYT, _congDoan, _mucLuongCB, _tong, _ghiChu, _maMay, _nguoiSD);
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="Luong_M1" /> Object to underlying database.
		/// </summary>
		 internal void Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
			 if (!this.IsDirty)
                return;
                
                  
                DataProvider.Instance().UpdateLuong_M1(_sTT, _thang, _maNV, _makhoa, _heSoChucVu, _heSo, _bHXH, _bHYT, _congDoan, _mucLuongCB, _tong, _ghiChu, _maMay, _nguoiSD , _huy);
                // public abstract void UpdateLuong_M1(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Decimal _heSoChucVu, Decimal _heSo, Decimal _bHXH, Decimal _bHYT, Decimal _congDoan, Decimal _mucLuongCB, Decimal _tong, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
                // public override void UpdateLuong_M1(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Decimal _heSoChucVu, Decimal _heSo, Decimal _bHXH, Decimal _bHYT, Decimal _congDoan, Decimal _mucLuongCB, Decimal _tong, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_M1_UPDATE", _sTT, _thang.DBValue, _maNV, _makhoa, _heSoChucVu, _heSo, _bHXH, _bHYT, _congDoan, _mucLuongCB, _tong, _ghiChu, _maMay, _nguoiSD , _huy);
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
		/// Delete the <see cref="Luong_M1" />.
		/// </summary>
        protected void DataPortal_Delete(CriteriaOther crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateLuong_M1
            DataProvider.Instance().DeleteLuong_M1(crit.MaMay, crit.NguoiSD, crit.STT, crit.Thang);
			// public abstract void DeleteLuong_M1(Int32 _sTT, SmartDate _thang);
			// public override void DeleteLuong_M1(Int32 _sTT, SmartDate _thang);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_M1_DELETED", _sTT, _thang);
			// }
		}

		#endregion
	}

}
