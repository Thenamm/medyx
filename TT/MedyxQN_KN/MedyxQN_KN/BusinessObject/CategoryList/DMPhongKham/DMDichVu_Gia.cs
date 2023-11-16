// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMDichVu_Gia
// Kieu doi tuong  :	DMDichVu_Gia
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	3/9/2009 3:56:55 PM
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

namespace HTC.Business.CategoryList
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="DMDichVu_Gia" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMDichVu_Gia : BusinessBase<DMDichVu_Gia>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maDT = String.Empty;
        private String _tenDT = String.Empty;
        private Decimal _sTT = 0;
		private String _maDV = String.Empty;
		private Decimal _dongia = 0;
        private Decimal _dongiatt = 0;
        private Boolean _nhapsl = false;
        private String _tentat = String.Empty;
        private String _makhoa = String.Empty;
        private String _mabs = String.Empty;
        private String _tenkhoa = String.Empty;
        private String _tenbs = String.Empty;
		private Decimal _giaChenhlenh = 0;
		private Boolean _aDChenhlech = false;
		private Boolean _dTBH = false;
        private Byte _aDPhongMo = 0;
        private Boolean _aDGiauSD = false;
		private Decimal _dongia1 = 0;
        private Decimal _giaChenhlenh1 = 0;
        private Decimal _dongiatt1 = 0;
		private SmartDate _ngay1 = new SmartDate(true);
		private String _ghichu = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
        private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
        private SmartDate _ngayHuy = new SmartDate(true);
		private String _nguoiHuy = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
        private String _tenDV = String.Empty;
        private Byte _loaiKQ = 0;
        private String _tennguoiLap = String.Empty;
        private String _tennguoiSD = String.Empty;
        private String _tennguoiHuy = String.Empty;
        private int _OrderNumber;
        private String _tendd = String.Empty;
        //private String _noiTT = String.Empty;
      	#endregion
		
		#region Business Properties and Methods
        //public String NoiTT
        //{
        //    get
        //    {
        //        CanReadProperty("NoiTT", true);
        //        return _noiTT;
        //    }
        //    set
        //    {
        //        CanWriteProperty("NoiTT", true);
        //        if (_noiTT != value)
        //        {
        //            _noiTT = value;
        //            PropertyHasChanged("NoiTT");
        //        }
        //    }
        //}
        public Byte LoaiKQ
        {
            get
            {
                CanReadProperty("LoaiKQ", true);
                return _loaiKQ;
            }
            set
            {
                CanWriteProperty("LoaiKQ", true);
                if (_loaiKQ != value)
                {
                    _loaiKQ = value;
                    PropertyHasChanged("LoaiKQ");
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
        public String TenDT
        {
            get
            {
                CanReadProperty("TenDT", true);
                return _tenDT;
            }
            set
            {
                CanWriteProperty("TenDT", true);
                if (_tenDT != value)
                {
                    _tenDT = value;
                    PropertyHasChanged("TenDT");
                }
            }
        }
        public String tendd
        {
            get
            {
                if (_tentat.Length > 1)
                    _tendd = _tentat.Substring(0, 2) + " " + _tenDV;
                else
                    _tendd = _tenDV;
                CanReadProperty("tendd", true);
                return _tendd;
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
        public String mabs
        {
            get
            {
                CanReadProperty("mabs", true);
                return _mabs;
            }
            set
            {
                CanWriteProperty("mabs", true);
                if (_mabs != value)
                {
                    _mabs = value;
                    PropertyHasChanged("mabs");
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
        
        public String makhoa
        {
            get
            {
                CanReadProperty("makhoa", true);
                return _makhoa;
            }
            set
            {
                CanWriteProperty("makhoa", true);
                if (_makhoa != value)
                {
                    _makhoa = value;
                    PropertyHasChanged("makhoa");
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
        public Decimal STT
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
        public Decimal dongiatt
        {
            get
            {
                CanReadProperty("dongiatt", true);
                return _dongiatt;
            }
            set
            {
                CanWriteProperty("dongiatt", true);
                if (_dongiatt != value)
                {
                    _dongiatt = value;
                    PropertyHasChanged("dongiatt");
                }
            }
        }
      
       
        public Boolean nhapsl
        {
            get
            {
                CanReadProperty("nhapsl", true);
                return _nhapsl;
            }
            set
            {
                CanWriteProperty("nhapsl", true);
                if (_nhapsl != value)
                {
                    _nhapsl = value;
                    PropertyHasChanged("nhapsl");
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
		
        //public Decimal Dongia
        //{
        //    get 
        //    {
        //        CanReadProperty("Dongia", true);
        //        return _dongia;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("Dongia", true);
        //        if (_dongia != value) 
        //        {
        //            _dongia = value;
        //            PropertyHasChanged("Dongia");
        //        }
        //    }
        //}
        public string Dongia
        {
            get
            {
                CanReadProperty("Dongia", true);
                if (_dongia == 0)
                {
                    return "0";
                }
                else
                {
                    return _dongia.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("Dongia", true);

                if (_dongia.ToString() != value)
                {
                    _dongia = decimal.Parse(value);
                    PropertyHasChanged("Dongia");
                }
            }
        }
		
        //public Decimal GiaChenhlenh
        //{
        //    get 
        //    {
        //        CanReadProperty("GiaChenhlenh", true);
        //        return _giaChenhlenh;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("GiaChenhlenh", true);
        //        if (_giaChenhlenh != value) 
        //        {
        //            _giaChenhlenh = value;
        //            PropertyHasChanged("GiaChenhlenh");
        //        }
        //    }
        //}
        public string GiaChenhlenh
        {
            get
            {
                CanReadProperty("GiaChenhlenh", true);
                if (_giaChenhlenh == 0)
                {
                    return "0";
                }
                else
                {
                    return _giaChenhlenh.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("GiaChenhlenh", true);

                if (_giaChenhlenh.ToString() != value)
                {
                    _giaChenhlenh = decimal.Parse(value);
                    PropertyHasChanged("GiaChenhlenh");
                }
            }
        }
		
		public Boolean ADChenhlech
		{
			get 
			{
				CanReadProperty("ADChenhlech", true);
				return _aDChenhlech;
			}
			set 
			{
				CanWriteProperty("ADChenhlech", true);
				if (_aDChenhlech != value) 
				{
					_aDChenhlech = value;
					PropertyHasChanged("ADChenhlech");
				}
			}
		}

        public Boolean aDGiauSD
        {
            get
            {
                CanReadProperty("aDGiauSD", true);
                return _aDGiauSD;
            }
            set
            {
                CanWriteProperty("aDGiauSD", true);
                if (_aDGiauSD != value)
                {
                    _aDGiauSD = value;
                    PropertyHasChanged("aDGiauSD");
                }
            }
        }

		public Boolean DTBH
		{
			get 
			{
				CanReadProperty("DTBH", true);
				return _dTBH;
			}
			set 
			{
				CanWriteProperty("DTBH", true);
				if (_dTBH != value) 
				{
					_dTBH = value;
					PropertyHasChanged("DTBH");
				}
			}
		}

        public Byte ADPhongMo
		{
			get 
			{
				CanReadProperty("ADPhongMo", true);
				return _aDPhongMo;
			}
			set 
			{
				CanWriteProperty("ADPhongMo", true);
				if (_aDPhongMo != value) 
				{
					_aDPhongMo = value;
					PropertyHasChanged("ADPhongMo");
				}
			}
		}
		
        //public Decimal Dongia1
        //{
        //    get 
        //    {
        //        CanReadProperty("Dongia1", true);
        //        return _dongia1;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("Dongia1", true);
        //        if (_dongia1 != value) 
        //        {
        //            _dongia1 = value;
        //            PropertyHasChanged("Dongia1");
        //        }
        //    }
        //}
        public string Dongia1
        {
            get
            {
                CanReadProperty("Dongia1", true);
                if (_dongia1 == 0)
                {
                    return "0";
                }
                else
                {
                    return _dongia1.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("Dongia1", true);

                if (_dongia1.ToString() != value)
                {
                    _dongia1 = decimal.Parse(value);
                    PropertyHasChanged("Dongia1");
                }
            }
        }
        public string Dongiatt1
        {
            get
            {
                CanReadProperty("Dongiatt1", true);
                if (_dongiatt1 == 0)
                {
                    return "0";
                }
                else
                {
                    return _dongiatt1.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("Dongiatt1", true);

                if (_dongiatt1.ToString() != value)
                {
                    _dongiatt1 = decimal.Parse(value);
                    PropertyHasChanged("Dongiatt1");
                }
            }
        }
        public Decimal GiaChenhlenh1
        {
            get
            {
                CanReadProperty("GiaChenhlenh1", true);
                return _giaChenhlenh1;
            }
            set
            {
                CanWriteProperty("GiaChenhlenh1", true);
                if (_giaChenhlenh1 != value)
                {
                    _giaChenhlenh1 = value;
                    PropertyHasChanged("GiaChenhlenh1");
                }
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
		
		public String NgayLap
		{
			get 
			{
				CanReadProperty("NgayLap", true);
                _ngayLap.FormatString = "dd/MM/yyyy HH:mm:ss";
				return _ngayLap.Text ;
			}
			set 
			{
				CanWriteProperty("NgayLap", true);
				if (_ngayLap.Text  != value) 
				{
					_ngayLap.Text  = value;
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
		
		public String NgayHuy
		{
			get 
			{
				CanReadProperty("NgayHuy", true);
                _ngayHuy.FormatString = "dd/MM/yyyy HH:mm:ss";

				return _ngayHuy.Text ;
			}
			set 
			{
				CanWriteProperty("NgayHuy", true);
				if (_ngayHuy.Text  != value) 
				{
					_ngayHuy.Text  = value;
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
		
		public string NgaySD1
		{
			get 
			{
				CanReadProperty("NgaySD1", true);
                _ngaySD1.FormatString = "dd/MM/yyyy HH:mm:ss";

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
		
		public string NgaySD
		{
			get 
			{
				CanReadProperty("NgaySD", true);
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm:ss";

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
        public String TenNguoiSD
        {
            get
            {
                CanReadProperty("TenNguoiSD", true);
                return _tennguoiSD;
            }
            set
            {
                CanWriteProperty("TenNguoiSD", true);
                if (_tennguoiSD != value)
                {
                    _tennguoiSD = value;
                    PropertyHasChanged("TenNguoiSD");
                }
            }
        }

        public String TenNguoiLap
        {
            get
            {
                CanReadProperty("TenNguoiLap", true);
                return _tennguoiLap;
            }
            set
            {
                CanWriteProperty("TenNguoiLap", true);
                if (_tennguoiLap != value)
                {
                    _tennguoiLap = value;
                    PropertyHasChanged("TenNguoiLap");
                }
            }
        }

        public String TenNguoiHuy
        {
            get
            {
                CanReadProperty("TenNguoiHuy", true);
                return _tennguoiHuy;
            }
            set
            {
                CanWriteProperty("TenNguoiHuy", true);
                if (_tennguoiHuy != value)
                {
                    _tennguoiHuy = value;
                    PropertyHasChanged("TenNguoiHuy");
                }
            }
        }

        public String TenDV
        {
            get
            {
                CanReadProperty("TenDV", true);
                return _tenDV;
            }
            set
            {
                CanWriteProperty("TenDV", true);
                if (_tenDV != value)
                {
                    _tenDV = value;
                    PropertyHasChanged("TenDV");
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
			return _maDT.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMDichVu_Gia" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMDichVu_Gia NewDMDichVu_Gia()
        {
            return new DMDichVu_Gia ();
        }
   
        internal static DMDichVu_Gia  GetDMDichVu_Gia(SafeDataReader dr,int i)
        {
            return new DMDichVu_Gia (dr,i);
        }
		
	
        public DMDichVu_Gia()
        {
            MarkAsChild();
        }
		
		#endregion
		    
		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maDT;
			public String MaDT 
			{
				get
				{
					return _maDT;
				}
			}

            private Decimal _sTT;
            public Decimal STT 
			{
				get
				{
					return _sTT;
				}
			}

            public Criteria(String maDT, Decimal sTT)
			{
				_maDT = maDT;
				_sTT = sTT;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maDT.Equals(c._maDT)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maDT.ToString(), _sTT.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maDT;
            public String maDT
            {
                get
                {
                    return _maDT;
                }
            }

            private Decimal _sTT;
            public Decimal sTT
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
            public OtherCriteria(String Mamay, String Nguoisd, String maDT, Decimal sTT)
            {
                _maDT = maDT;
                _sTT = sTT;
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

		
        private  DMDichVu_Gia(SafeDataReader dr,int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
            if (dr.GetString("TenDT") != null) _tenDT = dr.GetString("TenDT");
            if (dr.GetDecimal("STT") != null) _sTT = dr.GetDecimal("STT");
            if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
            if (dr.GetDecimal("Dongia") != null) _dongia = dr.GetDecimal("Dongia");
            if (dr.GetDecimal("GiaChenhlenh") != null) _giaChenhlenh = dr.GetDecimal("GiaChenhlenh");
            if (dr.GetBoolean("ADChenhlech") != null) _aDChenhlech = dr.GetBoolean("ADChenhlech");
            if (dr.GetBoolean("DTBH") != null) _dTBH = dr.GetBoolean("DTBH");
            if (dr.GetByte("ADPhongMo") != null) _aDPhongMo = dr.GetByte("ADPhongMo");
            if (dr.GetBoolean("ADGiauSD") != null) _aDGiauSD = dr.GetBoolean("ADGiauSD");
            if (dr.GetDecimal("Dongia1") != null) _dongia1 = dr.GetDecimal("Dongia1");
            if (dr.GetDecimal("GiaChenhlenh1") != null) _giaChenhlenh1 = dr.GetDecimal("GiaChenhlenh1");
            if (dr.GetSmartDate("Ngay1", true) != null) _ngay1 = dr.GetSmartDate("Ngay1", true);
            if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgayLap") != null) _ngayLap = dr.GetSmartDate("NgayLap");
            if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetSmartDate("NgayHuy") != null) _ngayHuy = dr.GetSmartDate("NgayHuy");
            if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
            if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("TenDV") != null) _tenDV = dr.GetString("TenDV");
            if (dr.GetString("tentat") != null) _tentat = dr.GetString("tentat");
            if (dr.GetString("mabs") != null) _mabs = dr.GetString("mabs");
            if (dr.GetString("tenbs") != null) _tenbs = dr.GetString("tenbs");
            if (dr.GetString("makhoa") != null) _makhoa = dr.GetString("makhoa");
         
            if (dr.GetString("tenkhoa") != null) _tenkhoa = dr.GetString("tenkhoa");
            if (dr.GetDecimal("GiaChenhlenh") != null) _giaChenhlenh = dr.GetDecimal("GiaChenhlenh");
            if (dr.GetBoolean("nhapsl") != null) _nhapsl = dr.GetBoolean("nhapsl");
            if (dr.GetByte("LoaiKQ") != null) _loaiKQ = dr.GetByte("LoaiKQ");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenNguoiLap") != null) _tennguoiLap = dr.GetString("TenNguoiLap");
            if (dr.GetString("TenNguoiHuy") != null) _tennguoiHuy = dr.GetString("TenNguoiHuy");
          
              
             if (dr.GetDecimal("dongiatt") != null) _dongiatt = dr.GetDecimal("dongiatt");
             if (HTC.ShareVariables.pub_spC == "HU") 
                 _dongiatt = _dongia + _giaChenhlenh;
            _dongiatt1 = _dongia1 + _giaChenhlenh1; 
            //if (dr.GetString("noiTT") != null) _noiTT = dr.GetString("noiTT");
            MarkOld();
        }
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
            
            //_maDT = 
                DataProvider.Instance().InsertDMDichVu_Gia(_maDT, _maDV, _dongia, _giaChenhlenh, _aDChenhlech, _dTBH, _aDPhongMo, _dongia1, _giaChenhlenh1, _ngay1, _ghichu, _maMay, _nguoiSD , _aDGiauSD);
            // public abstract String InsertDMThuoc_KhoKhoa(String _makho, String _makhoa, String _maThuoc, String _nguoiSD, String _maMay);
            // public override String InsertDMThuoc_KhoKhoa(String _makho, String _makhoa, String _maThuoc, String _nguoiSD, String _maMay)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMThuoc_KhoKhoa_Create", _makho, _makhoa, _maThuoc, _nguoiSD , _maMay), String);
            // }
            MarkOld();
        }
		
		/// <summary>
		/// Update all changes made on <see cref="DMDichVu_Gia" /> Object to underlying database.
		/// </summary>
        //protected override void DataPortal_Update()
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_Gia
        //    if (IsDirty){
        //        DataProvider.Instance().UpdateDMDichVu_Gia(_maDT, _sTT, _maDV, _dongia, _giaChenhlenh, _aDChenhlech, _dTBH, _aDPhongMo, _ghichu, _maMay, _huy, _nguoiSD , _aDGiauSD);
        //        // public abstract void UpdateDMDichVu_Gia(String _maDT, Byte _sTT, String _maDV, Decimal _dongia, Decimal _giaChenhlenh, Boolean _aDChenhlech, Boolean _dTBH, Boolean _aDPhongMo, Decimal _dongia1, SmartDate _ngay1, String _ghichu, String _maMay, Boolean _huy, String _ngayLap, String _nguoiLap, String _ngayHuy, String _nguoiHuy, SmartDate _ngaySD1, String _nguoiSD1, SmartDate _ngaySD, String _nguoiSD);
        //        // public override void UpdateDMDichVu_Gia(String _maDT, Byte _sTT, String _maDV, Decimal _dongia, Decimal _giaChenhlenh, Boolean _aDChenhlech, Boolean _dTBH, Boolean _aDPhongMo, Decimal _dongia1, SmartDate _ngay1, String _ghichu, String _maMay, Boolean _huy, String _ngayLap, String _nguoiLap, String _ngayHuy, String _nguoiHuy, SmartDate _ngaySD1, String _nguoiSD1, SmartDate _ngaySD, String _nguoiSD);
        //        // {
        //        //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDT, _sTT, _maDV, _dongia, _giaChenhlenh, _aDChenhlech, _dTBH, _aDPhongMo, _dongia1, _ngay1.DBValue, _ghichu, _maMay, _huy, _ngayLap, _nguoiSD , _ngayHuy, _nguoiSD , _ngaySD1.DBValue, _nguoiSD1, _ngaySD.DBValue, _nguoiSD);
        //        // }				
        //    }
        //}
        internal void Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
            if (!this.IsDirty)
                return;
            
              
            DataProvider.Instance().UpdateDMDichVu_Gia(_maDT, _sTT, _maDV, _dongia, _giaChenhlenh, _aDChenhlech, _dTBH, _aDPhongMo, _ghichu, _maMay, _huy, _nguoiSD , _aDGiauSD);
            // public abstract void UpdateDMThuoc_KhoKhoa(String _makho, Decimal _sTT, String _makhoa, String _maThuoc, Boolean _huy, String _nguoiSD, String _maMay);
            // public override void UpdateDMThuoc_KhoKhoa(String _makho, Decimal _sTT, String _makhoa, String _maThuoc, Boolean _huy, String _nguoiSD, String _maMay)
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMThuoc_KhoKhoa_Update", _makho, _sTT, _makhoa, _maThuoc, _huy, _nguoiSD , _maMay);
            // }				
            MarkOld();
        }
    
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maDT, _sTT));
            MarkNew();
        }


		/// <summary>
		/// Delete the <see cref="DMDichVu_Gia" />.
		/// </summary>
        //protected void DataPortal_Delete(OtherCriteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_Gia
        //    DataProvider.Instance().DeleteDMDichVu_Gia(crit.MaMay, crit.NguoiSD, crit.maDT, crit.sTT);
        //    // public abstract void DeleteDMDichVu_Gia(String _maDT, Byte _sTT);
        //    // public override void DeleteDMDichVu_Gia(String _maDT, Byte _sTT);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDT, _sTT);
        //    // }
        //}
        private void DataPortal_Delete(OtherCriteria crit)
        {
            DataProvider.Instance().DeleteDMDichVu_Gia(crit.MaMay, crit.NguoiSD, crit.maDT, crit.sTT);
        }

		#endregion
	}

}
