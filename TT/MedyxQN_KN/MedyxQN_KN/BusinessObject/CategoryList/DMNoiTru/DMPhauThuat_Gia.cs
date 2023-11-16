// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMPhauThuat_Gia
// Kieu doi tuong  :	DMPhauThuat_Gia
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	6/8/2009 10:55:33 AM
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
	/// This is a base generated class of <see cref="DMPhauThuat_Gia" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMPhauThuat_Gia : BusinessBase<DMPhauThuat_Gia>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maDT = String.Empty;
		private Decimal _sTT = 0;
		private String _mAPT = String.Empty;
		private Decimal _dongia = 0;
		private Decimal _giaChenhlech = 0;
		private Boolean _aDChenhlech = false;
		private Boolean _adgiausd = false;
		private Boolean _dTBH = false;
		private Byte _aDPhongMo = 0;
		private Decimal _dongia1 = 0;
		private Decimal _giaChenhlech1 = 0;
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
        private String _tenPT = String.Empty; 
        private String _tenDT = String.Empty;
        private String _tennguoiLap = String.Empty;
        private String _tennguoiSD = String.Empty;
        private String _tennguoiHuy = String.Empty;
        private Decimal _dongiaTT = 0;
        private Boolean _nhapSL = false;
        private String _tenTat = String.Empty;
        private int _OrderNumber;
		
		#endregion
		
		#region Business Properties and Methods
        public Decimal DonGiaBH
        {
            get;
            set;
        }

        public Decimal DonGiaBH1
        {
            get;
            set;
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
		
		public String MAPT
		{
			get 
			{
				CanReadProperty("MAPT", true);
				return _mAPT;
			}
			set 
			{
				CanWriteProperty("MAPT", true);
				if (_mAPT != value) 
				{
					_mAPT = value;
					PropertyHasChanged("MAPT");
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
		
        //public Decimal GiaChenhlech
        //{
        //    get 
        //    {
        //        CanReadProperty("GiaChenhlech", true);
        //        return _giaChenhlech;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("GiaChenhlech", true);
        //        if (_giaChenhlech != value) 
        //        {
        //            _giaChenhlech = value;
        //            PropertyHasChanged("GiaChenhlech");
        //        }
        //    }
        //}
        public string GiaChenhlech
        {
            get
            {
                CanReadProperty("GiaChenhlech", true);
                if (_giaChenhlech == 0)
                {
                    return "0";
                }
                else
                {
                    return _giaChenhlech.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("GiaChenhlech", true);

                if (_giaChenhlech.ToString() != value)
                {
                    _giaChenhlech = decimal.Parse(value);
                    PropertyHasChanged("GiaChenhlech");
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
		
		public Boolean Adgiausd
		{
			get 
			{
				CanReadProperty("Adgiausd", true);
				return _adgiausd;
			}
			set 
			{
				CanWriteProperty("Adgiausd", true);
				if (_adgiausd != value) 
				{
					_adgiausd = value;
					PropertyHasChanged("Adgiausd");
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
		
		public Decimal Dongia1
		{
			get 
			{
				CanReadProperty("Dongia1", true);
				return _dongia1;
			}
			set 
			{
				CanWriteProperty("Dongia1", true);
				if (_dongia1 != value) 
				{
					_dongia1 = value;
					PropertyHasChanged("Dongia1");
				}
			}
		}
		
		public Decimal GiaChenhlech1
		{
			get 
			{
				CanReadProperty("GiaChenhlech1", true);
				return _giaChenhlech1;
			}
			set 
			{
				CanWriteProperty("GiaChenhlech1", true);
				if (_giaChenhlech1 != value) 
				{
					_giaChenhlech1 = value;
					PropertyHasChanged("GiaChenhlech1");
				}
			}
		}
		
		public string Ngay1
		{
			get 
			{
				CanReadProperty("Ngay1", true);
                _ngay1.FormatString = "dd/MM/yyyy HH:mm";
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
		
		public string NgayLap
		{
			get 
			{
				CanReadProperty("NgayLap", true);
                _ngayLap.FormatString = "dd/MM/yyyy HH:mm";
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
                _ngayHuy.FormatString = "dd/MM/yyyy HH:mm";
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
		
		public string NgaySD1
		{
			get 
			{
				CanReadProperty("NgaySD1", true);
                _ngaySD1.FormatString = "dd/MM/yyyy HH:mm";
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
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm";
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

        public String TenPT
        {
            get
            {
                CanReadProperty("TenPT", true);
                return _tenPT;
            }
            set
            {
                CanWriteProperty("TenPT", true);
                if (_tenPT != value)
                {
                    _tenPT = value;
                    PropertyHasChanged("TenPT");
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

        //public Decimal DongiaTT
        //{
        //    get
        //    {
        //        CanReadProperty("DongiaTT", true);
        //        return _dongiaTT;
        //    }
        //    set
        //    {
        //        CanWriteProperty("DongiaTT", true);
        //        if (_dongiaTT != value)
        //        {
        //            _dongiaTT = value;
        //            PropertyHasChanged("DongiaTT");
        //        }
        //    }
        //}
        public string DongiaTT
        {
            get
            {
                CanReadProperty("DongiaTT", true);
                if (_dongiaTT == 0)
                {
                    return "0";
                }
                else
                {
                    return _dongiaTT.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("DongiaTT", true);

                if (_dongiaTT.ToString() != value)
                {
                    _dongiaTT = decimal.Parse(value);
                    PropertyHasChanged("DongiaTT");
                }
            }
        }

        public Boolean NhapSL
        {
            get
            {
                CanReadProperty("NhapSL", true);
                return _nhapSL;
            }
            set
            {
                CanWriteProperty("NhapSL", true);
                if (_nhapSL != value)
                {
                    _nhapSL = value;
                    PropertyHasChanged("NhapSL");
                }
            }
        }

        public String TenTat
        {
            get
            {
                CanReadProperty("TenTat", true);
                return _tenTat;
            }
            set
            {
                CanWriteProperty("TenTat", true);
                if (_tenTat != value)
                {
                    _tenTat = value;
                    PropertyHasChanged("TenTat");
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
			return _maDT.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMPhauThuat_Gia" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMPhauThuat_Gia NewDMPhauThuat_Gia()
        {
            return new DMPhauThuat_Gia();
        }
        //public static DMPhauThuat_Gia GetDMPhauThuat_Gia(String maDT, Decimal sTT)
        //{
        //    return DataPortal.Fetch<DMPhauThuat_Gia>(new Criteria(maDT, sTT));
        //}
		
		/// <summary>
		/// Marks the <see cref="DMPhauThuat_Gia" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        /// 
        internal static DMPhauThuat_Gia GetDMPhauThuat_Gia(SafeDataReader dr, int i)
        {
            return new DMPhauThuat_Gia (dr,i);
        }
        public DMPhauThuat_Gia()
        {
           MarkAsChild();
        }
        //public static void DeleteDMPhauThuat_Gia(String maDT, Decimal sTT)
        //{
        //    DataPortal.Delete(new Criteria(maDT, sTT));
        //}
		
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
            public String MaDT
            {
                get
                {
                    return _maDT;
                }
            }

            private Decimal _STT;
            public Decimal STT
            {
                get
                {
                    return _STT;
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
                _STT = sTT;
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


        private DMPhauThuat_Gia(SafeDataReader dr, int i)
        {
            // Value properties
            MarkAsChild();
            _OrderNumber = i;
            if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
            if (dr.GetDecimal("STT") != null) _sTT = dr.GetDecimal("STT");
            if (dr.GetString("MAPT") != null) _mAPT = dr.GetString("MAPT");
            if (dr.GetDecimal("Dongia") != null) _dongia = dr.GetDecimal("Dongia");
            if (dr.GetDecimal("GiaChenhlech") != null) _giaChenhlech = dr.GetDecimal("GiaChenhlech");
            if (dr.GetBoolean("ADChenhlech") != null) _aDChenhlech = dr.GetBoolean("ADChenhlech");
            if (dr.GetBoolean("Adgiausd") != null) _adgiausd = dr.GetBoolean("Adgiausd");
            if (dr.GetBoolean("DTBH") != null) _dTBH = dr.GetBoolean("DTBH");
            if (dr.GetByte("ADPhongMo") != null) _aDPhongMo = dr.GetByte("ADPhongMo");
            if (dr.GetDecimal("Dongia1") != null) _dongia1 = dr.GetDecimal("Dongia1");
            if (dr.GetDecimal("GiaChenhlech1") != null) _giaChenhlech1 = dr.GetDecimal("GiaChenhlech1");
            if (dr.GetSmartDate("Ngay1", true) != null) _ngay1 = dr.GetSmartDate("Ngay1", true);
            if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
            if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
            if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
            if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetBoolean("NhapSL") != null) _nhapSL = dr.GetBoolean("NhapSL");
            if (dr.GetString("TenTat") != null) _tenTat = dr.GetString("TenTat");
            if (dr.GetString("TenNguoiLap") != null) _tennguoiLap = dr.GetString("TenNguoiLap");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenNguoiHuy") != null) _tennguoiHuy = dr.GetString("TenNguoiHuy");
            if (dr.GetDecimal("DongiaTT") != null) _dongiaTT = dr.GetDecimal("DongiaTT");
            if (dr.GetString("TenPT") != null) _tenPT = dr.GetString("TenPT");
            if (dr.GetString("TenDT") != null) _tenDT = dr.GetString("TenDT");
            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="DMPhauThuat_Gia" /> Object to underlying database.
		/// </summary>
        internal void Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMPhauThuat_Gia
			// Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
              
			//_maDT = 
                DataProvider.Instance().InsertDMPhauThuat_Gia(_maDT, _mAPT, _dongia, _giaChenhlech, _aDChenhlech, _adgiausd, _dTBH, _aDPhongMo, _dongia1, _giaChenhlech1, _ngay1, _ghichu, _maMay, _nguoiSD);
			// public abstract String InsertDMPhauThuat_Gia(String _maDT, String _mAPT, Decimal _dongia, Decimal _giaChenhlech, Boolean _aDChenhlech, Boolean _adgiausd, Boolean _dTBH, Byte _aDPhongMo, Decimal _dongia1, Decimal _giaChenhlech1, SmartDate _ngay1, String _ghichu, String _maMay, String _nguoiLap);
			// public override String InsertDMPhauThuat_Gia(String _maDT, String _mAPT, Decimal _dongia, Decimal _giaChenhlech, Boolean _aDChenhlech, Boolean _adgiausd, Boolean _dTBH, Byte _aDPhongMo, Decimal _dongia1, Decimal _giaChenhlech1, SmartDate _ngay1, String _ghichu, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMPhauThuat_GIA_CREATE", _maDT, _mAPT, _dongia, _giaChenhlech, _aDChenhlech, _adgiausd, _dTBH, _aDPhongMo, _dongia1, _giaChenhlech1, _ngay1.DBValue, _ghichu, _maMay, _nguoiSD));
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMPhauThuat_Gia" /> Object to underlying database.
		/// </summary>
        internal void Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMPhauThuat_Gia
			 if (!this.IsDirty)
                return;
                
                  
				DataProvider.Instance().UpdateDMPhauThuat_Gia(_maDT, _sTT, _mAPT, _dongia, _giaChenhlech, _aDChenhlech, _adgiausd, _dTBH, _aDPhongMo, _ghichu, _maMay, _huy, _nguoiSD);
				// public abstract void UpdateDMPhauThuat_Gia(String _maDT, Decimal _sTT, String _mAPT, Decimal _dongia, Decimal _giaChenhlech, Boolean _aDChenhlech, Boolean _adgiausd, Boolean _dTBH, Byte _aDPhongMo, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateDMPhauThuat_Gia(String _maDT, Decimal _sTT, String _mAPT, Decimal _dongia, Decimal _giaChenhlech, Boolean _aDChenhlech, Boolean _adgiausd, Boolean _dTBH, Byte _aDPhongMo, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMPhauThuat_GIA_UPDATE ", _maDT, _sTT, _mAPT, _dongia, _giaChenhlech, _aDChenhlech, _adgiausd, _dTBH, _aDPhongMo, _ghichu, _maMay, _huy, _nguoiSD);
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
		/// Delete the <see cref="DMPhauThuat_Gia" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMPhauThuat_Gia
            DataProvider.Instance().DeleteDMPhauThuat_Gia(crit.MaMay, crit.NguoiSD, crit.MaDT, crit.STT);
			// public abstract void DeleteDMPhauThuat_Gia(String _maDT, Decimal _sTT);
			// public override void DeleteDMPhauThuat_Gia(String _maDT, Decimal _sTT);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMPhauThuat_GIA_DELETED", _maDT, _sTT);
			// }
		}

		#endregion
	}

}
