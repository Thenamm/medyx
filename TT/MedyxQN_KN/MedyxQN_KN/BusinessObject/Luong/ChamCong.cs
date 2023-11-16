// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	ChamCong
// Kieu doi tuong  :	ChamCong
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	10/24/2009 9:06:04 AM
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
	/// This is a base generated class of <see cref="ChamCong" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class ChamCong : BusinessBase<ChamCong>
	{
		#region Business Methods
		
		#region State Fields
		
		private Int32 _sTT = 0;
		private SmartDate _thang = new SmartDate(true);
		private String _maNV = String.Empty;
		private String _makhoa = String.Empty;
		private Decimal _hanhChinh;
        private Decimal _TongCongHC;
		private Decimal _phep ;
		private Decimal _om ;
		private Decimal _ngoaiGio ;
		private Decimal _ngoaiGio7 ;
		private Decimal _ngoaiGioLe ;
		private Decimal _XQuang ;
        private String _ABC ="A";
		private Decimal _congAnToi ;
		private Decimal _congAnTrua ;
        private Decimal _CongLamDem ;
        private Decimal _ThaiSan;
        private Decimal _NghiBu;
        private Decimal _NghiKhongLuong;
        private Decimal _NganHan;
        private Decimal _DaiHan;
        private Decimal _NuocNgoai;
        private Decimal _HocBongNuocNgoai;
        private Decimal _CongThuc;
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
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;

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
                _thang.FormatString = "MM/yyyy";

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
                    return _hanhChinh.ToString("##0.##");
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
                    return _TongCongHC.ToString("##0.##");
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
                    return _phep.ToString("##0.##");
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
                    return _om.ToString("##0.##");
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
                    return _ngoaiGio.ToString("##0.##");
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
                    return _ngoaiGio7.ToString("##0.##");
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
                    return _ngoaiGioLe.ToString("##0.##");
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
                    return _XQuang.ToString("##0.##");
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
               
                    return _ABC;
               
            }
            set
            {
                CanWriteProperty("ABC", true);

                if (_ABC != value)
                {
                    
                        _ABC = value;
                    PropertyHasChanged("ABC");
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
                    return _congAnToi.ToString("##0.##");
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
                    return _congAnTrua.ToString("##0.##");
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
                if (_CongLamDem == 0)
                {
                    return "";
                }
                else
                {
                    return _CongLamDem.ToString("##0.##");
                }
            }
            set
            {
                CanWriteProperty("CongLamDem", true);

                if (_CongLamDem.ToString() != value)
                {
                    if (value == "")
                        _CongLamDem = 0;
                    else
                        _CongLamDem = Decimal.Parse(value);
                    PropertyHasChanged("CongLamDem");
                }
            }
        }

        public string ThaiSan
        {
            get
            {
                CanReadProperty("ThaiSan", true);
                if (_ThaiSan == 0)
                {
                    return "";
                }
                else
                {
                    return _ThaiSan.ToString("##0.##");
                }
            }
            set
            {
                CanWriteProperty("ThaiSan", true);

                if (_ThaiSan.ToString() != value)
                {
                    if (value == "")
                        _ThaiSan = 0;
                    else
                        _ThaiSan = Decimal.Parse(value);
                    PropertyHasChanged("ThaiSan");
                }
            }
        }

        public string NghiBu
        {
            get
            {
                CanReadProperty("NghiBu", true);
                if (_NghiBu == 0)
                {
                    return "";
                }
                else
                {
                    return _NghiBu.ToString("##0.##");
                }
            }
            set
            {
                CanWriteProperty("NghiBu", true);

                if (_NghiBu.ToString() != value)
                {
                    if (value == "")
                        _NghiBu = 0;
                    else
                        _NghiBu = Decimal.Parse(value);
                    PropertyHasChanged("NghiBu");
                }
            }
        }

        public string NghiKhongLuong
        {
            get
            {
                CanReadProperty("NghiKhongLuong", true);
               
                if (_NghiKhongLuong == 0)
                {
                    return "";
                }
                else
                {
                    return _NghiKhongLuong.ToString("##0.##");
                }
            }
            set
            {
                CanWriteProperty("NghiKhongLuong", true);

                if (_NghiKhongLuong.ToString() != value)
                {
                    if (value == "")
                        _NghiKhongLuong = 0;
                    else
                        _NghiKhongLuong = Decimal.Parse(value);
                    PropertyHasChanged("NghiKhongLuong");
                }
            }
        }

        public string NganHan
        {
            get
            {
                CanReadProperty("NganHan", true);
                if (_NganHan == 0)
                {
                    return "";
                }
                else
                {
                    return _NganHan.ToString("##0.##");
                }
            }
            set
            {
                CanWriteProperty("NganHan", true);

                if (_NganHan.ToString() != value)
                {
                    if (value == "")
                        _NganHan = 0;
                    else
                        _NganHan = Decimal.Parse(value);
                    PropertyHasChanged("NganHan");
                }
            }
        }

        public string DaiHan
        {
            get
            {
                CanReadProperty("DaiHan", true);
                if (_DaiHan == 0)
                {
                    return "";
                }
                else
                {
                    return _DaiHan.ToString("##0.##");
                }
            }
            set
            {
                CanWriteProperty("DaiHan", true);

                if (_DaiHan.ToString() != value)
                {
                    if (value == "")
                        _DaiHan = 0;
                    else
                        _DaiHan = Decimal.Parse(value);
                    PropertyHasChanged("DaiHan");
                }
            }
        }

        public string NuocNgoai
        {
            get
            {
                CanReadProperty("NuocNgoai", true);
                if (_NuocNgoai == 0)
                {
                    return "";
                }
                else
                {
                    return _NuocNgoai.ToString("##0.##");
                }
            }
            set
            {
                CanWriteProperty("NuocNgoai", true);

                if (_NuocNgoai.ToString() != value)
                {
                    if (value == "")
                        _NuocNgoai = 0;
                    else
                        _NuocNgoai = Decimal.Parse(value);
                    PropertyHasChanged("NuocNgoai");
                }
            }
        }

        public string HocBongNuocNgoai
        {
            get
            {
                CanReadProperty("HocBongNuocNgoai", true);
                if (_HocBongNuocNgoai == 0)
                {
                    return "";
                }
                else
                {
                    return _HocBongNuocNgoai.ToString("##0.##");
                }
            }
            set
            {
                CanWriteProperty("HocBongNuocNgoai", true);

                if (_HocBongNuocNgoai.ToString() != value)
                {
                    if (value == "")
                        _HocBongNuocNgoai = 0;
                    else
                        _HocBongNuocNgoai = Decimal.Parse(value);
                    PropertyHasChanged("HocBongNuocNgoai");
                }
            }
        }

        public string CongThuc
        {
            get
            {
                CanReadProperty("CongThuc", true);
                //if ((_phep == 0) && (_om == 0))
                //{
                   _CongThuc = _hanhChinh + _phep + _om + _NghiBu;
                //}
                    if (_CongThuc == 0)
                    {
                        return "";
                    }
                    else
                    {
                        return _CongThuc.ToString("##0.##");
                    }
                
            }
            set
            {
                CanWriteProperty("CongThuc", true);

                if (_CongThuc.ToString() != value)
                {
                    if (value == "")
                        _CongThuc = 0;
                    else
                        _CongThuc = Decimal.Parse(value);
                    PropertyHasChanged("CongThuc");
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
			return _sTT.ToString() + "!" + _thang.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="ChamCong" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

        public static ChamCong NewChamCong()
        {
            return new ChamCong();
            // return DataPortal.Create<BC_DuocBV>();
        }

        internal static ChamCong GetChamCong(SafeDataReader dr, int i)
        {
            return new ChamCong(dr, i);
        }
        public static ChamCong GetChamCong(Int32 sTT, DateTime thang)
        {
            return DataPortal.Fetch<ChamCong>(new Criteria(sTT, thang));
        }
		
        ///// <summary>
        ///// Marks the <see cref="ChamCong" /> Object for deletion. The Object will be deleted as part of the next save operation.
        ///// </summary>
        //public static void DeleteChamCong(Int32 sTT, SmartDate thang)
        //{
        //    DataPortal.Delete(new Criteria(sTT, thang));
        //}
        public ChamCong()
        {
            MarkAsChild();
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal ChamCong()
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

            private DateTime _thang;
            public DateTime Thang 
			{
				get
				{
					return _thang;
				}
			}

            public Criteria(Int32 sTT, DateTime thang)
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
            private String _MaNV;
            public String MaNV
            {
                get
                {
                    return _MaNV;
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
            public CriteriaOther(String Mamay, String Nguoisd,string maNV, Int32 sTT, SmartDate thang)
            {
                _sTT = sTT;
                _thang = thang;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _MaNV = maNV;
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
		/// Retrieve an existing <see cref="ChamCong" /> Object based on data in the database.
		/// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetChamCong(Int32 _sTT, DateTime _thang);
            // public override IDataReader GetChamCong(Int32 _sTT, DateTime _thang)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _sTT, _thang));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetChamCong(crit.STT, crit.Thang)))
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
		/// Load a <see cref="ChamCong" /> Object from given SafeDataReader.
		/// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
            if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
            if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
            if (dr.GetDecimal("HanhChinh") != null) _hanhChinh = dr.GetDecimal("HanhChinh");
            if (dr.GetDecimal("Phep") != null) _phep = dr.GetDecimal("Phep");
            if (dr.GetDecimal("Om") != null) _om = dr.GetDecimal("Om");
            if (dr.GetDecimal("NgoaiGio") != null) _ngoaiGio = dr.GetDecimal("NgoaiGio");
            if (dr.GetDecimal("NgoaiGio7") != null) _ngoaiGio7 = dr.GetDecimal("NgoaiGio7");
            if (dr.GetDecimal("NgoaiGioLe") != null) _ngoaiGioLe = dr.GetDecimal("NgoaiGioLe");
            if (dr.GetDecimal("XQuang") != null) _XQuang = dr.GetDecimal("XQuang");

            if (dr.GetString("ABC") != null) _ABC = dr.GetString("ABC");
            if (dr.GetDecimal("CongAnToi") != null) _congAnToi = dr.GetDecimal("CongAnToi");
            if (dr.GetDecimal("CongAnTrua") != null) _congAnTrua = dr.GetDecimal("CongAnTrua");
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
        }
        private ChamCong(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
			if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
			if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
			if (dr.GetDecimal("HanhChinh") != null) _hanhChinh = dr.GetDecimal("HanhChinh");
            if (dr.GetDecimal("TongCongHC") != null) _TongCongHC = dr.GetDecimal("TongCongHC");
			if (dr.GetDecimal("Phep") != null) _phep = dr.GetDecimal("Phep");
			if (dr.GetDecimal("Om") != null) _om = dr.GetDecimal("Om");
			if (dr.GetDecimal("NgoaiGio") != null) _ngoaiGio = dr.GetDecimal("NgoaiGio");
			if (dr.GetDecimal("NgoaiGio7") != null) _ngoaiGio7 = dr.GetDecimal("NgoaiGio7");
			if (dr.GetDecimal("NgoaiGioLe") != null) _ngoaiGioLe = dr.GetDecimal("NgoaiGioLe");
			if (dr.GetDecimal("XQuang") != null) _XQuang = dr.GetDecimal("XQuang");
            if (dr.GetString("ABC") != null) _ABC = dr.GetString("ABC");
			if (dr.GetDecimal("CongAnToi") != null) _congAnToi = dr.GetDecimal("CongAnToi");
			if (dr.GetDecimal("CongAnTrua") != null) _congAnTrua = dr.GetDecimal("CongAnTrua");
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
             _hoten = dr.GetString("HoTen");
            _tenNguoiLap = dr.GetString("TenNguoiLap");
            _tenNguoiSD = dr.GetString("TenNguoiSD");
            _tenNguoiHuy = dr.GetString("TenNguoiHuy");
            if (dr.GetDecimal("CongLamDem") != null) _CongLamDem = dr.GetDecimal("CongLamDem");
            if (dr.GetDecimal("ThaiSan") != null) _ThaiSan = dr.GetDecimal("ThaiSan");
            if (dr.GetDecimal("NghiBu") != null) _NghiBu = dr.GetDecimal("NghiBu");
            if (dr.GetDecimal("NghiKhongLuong") != null) _NghiKhongLuong = dr.GetDecimal("NghiKhongLuong");
            if (dr.GetDecimal("NganHan") != null) _NganHan = dr.GetDecimal("NganHan");
            if (dr.GetDecimal("DaiHan") != null) _DaiHan = dr.GetDecimal("DaiHan");
            if (dr.GetDecimal("NuocNgoai") != null) _NuocNgoai = dr.GetDecimal("NuocNgoai");
            if (dr.GetDecimal("HocBongNuocNgoai") != null) _HocBongNuocNgoai = dr.GetDecimal("HocBongNuocNgoai");
            if (dr.GetDecimal("CongThuc") != null) _CongThuc = dr.GetDecimal("CongThuc");

            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="ChamCong" /> Object to underlying database.
		/// </summary>
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
            
            _sTT = DataProvider.Instance().InsertChamCong(_thang, _maNV, _makhoa, _hanhChinh, _phep, _om, _ngoaiGio, _ngoaiGio7, _ngoaiGioLe, _congAnToi, _congAnTrua, _maMay, _nguoiSD , _CongLamDem, _TongCongHC, _ABC, _XQuang, _ThaiSan, _NghiBu, _NghiKhongLuong, _NganHan, _DaiHan, _NuocNgoai, _HocBongNuocNgoai, _CongThuc);
			// public abstract Int32 InsertChamCong(SmartDate _thang, String _maNV, String _makhoa, Decimal _hanhChinh, Decimal _phep, Decimal _om, Decimal _ngoaiGio, Decimal _ngoaiGio7, Decimal _ngoaiGioLe, Decimal _XQuang, Decimal _congTruc, Decimal _ABC, Decimal _congTrucLe, Decimal _congAnToi, Decimal _congAnTrua, String _maMay, String _nguoiLap);
			// public override Int32 InsertChamCong(SmartDate _thang, String _maNV, String _makhoa, Decimal _hanhChinh, Decimal _phep, Decimal _om, Decimal _ngoaiGio, Decimal _ngoaiGio7, Decimal _ngoaiGioLe, Decimal _XQuang, Decimal _congTruc, Decimal _ABC, Decimal _congTrucLe, Decimal _congAnToi, Decimal _congAnTrua, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spCHAMCONG_CREATE", _sTT, _thang.DBValue, _maNV, _makhoa, _hanhChinh, _phep, _om, _ngoaiGio, _ngoaiGio7, _ngoaiGioLe, _XQuang, _congTruc, _ABC, _congTrucLe, _congAnToi, _congAnTrua, _maMay, _nguoiSD));
			// }
            MarkOld();

		}
		
		/// <summary>
		/// Update all changes made on <see cref="ChamCong" /> Object to underlying database.
		/// </summary>
		 internal void Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
			 if (!this.IsDirty)
                return;
                
                  
                DataProvider.Instance().UpdateChamCong(_sTT, _thang, _maNV, _makhoa, _hanhChinh, _phep, _om, _ngoaiGio, _ngoaiGio7, _ngoaiGioLe, _congAnToi, _congAnTrua, _maMay, _nguoiSD , _huy, _CongLamDem, _TongCongHC, _ABC, _XQuang, _ThaiSan, _NghiBu, _NghiKhongLuong, _NganHan, _DaiHan, _NuocNgoai, _HocBongNuocNgoai, _CongThuc);
				// public abstract void UpdateChamCong(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Decimal _hanhChinh, Decimal _phep, Decimal _om, Decimal _ngoaiGio, Decimal _ngoaiGio7, Decimal _ngoaiGioLe, Decimal _XQuang, Decimal _congTruc, Decimal _ABC, Decimal _congTrucLe, Decimal _congAnToi, Decimal _congAnTrua, String _maMay, String _nguoiSD, Boolean _huy);
				// public override void UpdateChamCong(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Decimal _hanhChinh, Decimal _phep, Decimal _om, Decimal _ngoaiGio, Decimal _ngoaiGio7, Decimal _ngoaiGioLe, Decimal _XQuang, Decimal _congTruc, Decimal _ABC, Decimal _congTrucLe, Decimal _congAnToi, Decimal _congAnTrua, String _maMay, String _nguoiSD, Boolean _huy)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spCHAMCONG_UPDATE", _sTT, _thang.DBValue, _maNV, _makhoa, _hanhChinh, _phep, _om, _ngoaiGio, _ngoaiGio7, _ngoaiGioLe, _XQuang, _congTruc, _ABC, _congTrucLe, _congAnToi, _congAnTrua, _maMay, _nguoiSD , _huy);
				// }				
                MarkOld();

		}
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            DataPortal_Delete(new CriteriaOther(_maMay, _nguoiSD , _maNV, _sTT, _thang ));
            MarkNew();
        }

		/// <summary>
		/// Delete the <see cref="ChamCong" />.
		/// </summary>
        protected void DataPortal_Delete(CriteriaOther crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateChamCong
            DataProvider.Instance().DeleteChamCong(crit.MaMay, crit.NguoiSD,crit.MaNV , crit.STT, crit.Thang);
			// public abstract void DeleteChamCong(Int32 _sTT, SmartDate _thang);
			// public override void DeleteChamCong(Int32 _sTT, SmartDate _thang);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spCHAMCONG_Deleted", _sTT, _thang);
			// }
		}

		#endregion
	}

}
