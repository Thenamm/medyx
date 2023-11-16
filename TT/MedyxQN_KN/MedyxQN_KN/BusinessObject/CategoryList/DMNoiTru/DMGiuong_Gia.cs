// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMGiuong_Gia
// Kieu doi tuong  :	DMGiuong_Gia
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	6/11/2009 9:34:02 AM
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
	/// This is a base generated class of <see cref="DMGiuong_Gia" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMGiuong_Gia : BusinessBase<DMGiuong_Gia>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maDT = String.Empty;
		private Decimal _sTT = 0;
		private String _maGiuong = String.Empty;
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
        private String _tenGiuong = String.Empty;
        private String _tenDT = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private Decimal _donGiaTT = 0;
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
		
		public String MaGiuong
		{
			get 
			{
				CanReadProperty("MaGiuong", true);
				return _maGiuong;
			}
			set 
			{
				CanWriteProperty("MaGiuong", true);
				if (_maGiuong != value) 
				{
					_maGiuong = value;
					PropertyHasChanged("MaGiuong");
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

        public String TenGiuong
        {
            get
            {
                CanReadProperty("TenGiuong", true);
                return _tenGiuong;
            }
            set
            {
                CanWriteProperty("TenGiuong", true);
                if (_tenGiuong != value)
                {
                    _tenGiuong = value;
                    PropertyHasChanged("TenGiuong");
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

        //public Decimal DonGiaTT
        //{
        //    get
        //    {
        //        CanReadProperty("DonGiaTT", true);
        //        return _donGiaTT;
        //    }
        //    set
        //    {
        //        CanWriteProperty("DonGiaTT", true);
        //        if (_donGiaTT != value)
        //        {
        //            _donGiaTT = value;
        //            PropertyHasChanged("DonGiaTT");
        //        }
        //    }
        //}
        public string DongiaTT
        {
            get
            {
                CanReadProperty("DongiaTT", true);
                if (_donGiaTT == 0)
                {
                    return "0";
                }
                else
                {
                    return _donGiaTT.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("DongiaTT", true);

                if (_donGiaTT.ToString() != value)
                {
                    _donGiaTT = decimal.Parse(value);
                    PropertyHasChanged("DongiaTT");
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
			return _maDT.ToString() + "!" + _sTT.ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMGiuong_Gia" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMGiuong_Gia NewDMGiuong_Gia()
        {
            return new DMGiuong_Gia();
        }
      
        internal static DMGiuong_Gia GetDMGiuong_Gia(SafeDataReader dr, int i)
        {
            return new DMGiuong_Gia(dr, i);
        }
		/// <summary>
		/// Marks the <see cref="DMGiuong_Gia" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
		
        public DMGiuong_Gia()
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

		/// <summary>
		/// Retrieve an existing <see cref="DMGiuong_Gia" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetDMGiuong_Gia(String _maDT, Decimal _sTT);
        //    // public override IDataReader GetDMGiuong_Gia(String _maDT, Decimal _sTT)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDT, _sTT));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMGiuong_Gia(crit.MaDT, crit.STT)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
        ///// <summary>
        ///// Load a <see cref="DMGiuong_Gia" /> Object from given SafeDataReader.
        ///// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
        //    if (dr.GetDecimal("STT") != null) _sTT = dr.GetDecimal("STT");
        //    if (dr.GetString("MaGiuong") != null) _maGiuong = dr.GetString("MaGiuong");
        //    if (dr.GetDecimal("Dongia") != null) _dongia = dr.GetDecimal("Dongia");
        //    if (dr.GetDecimal("GiaChenhlech") != null) _giaChenhlech = dr.GetDecimal("GiaChenhlech");
        //    if (dr.GetBoolean("ADChenhlech") != null) _aDChenhlech = dr.GetBoolean("ADChenhlech");
        //    if (dr.GetBoolean("Adgiausd") != null) _adgiausd = dr.GetBoolean("Adgiausd");
        //    if (dr.GetBoolean("DTBH") != null) _dTBH = dr.GetBoolean("DTBH");
        //    if (dr.GetByte("ADPhongMo") != null) _aDPhongMo = dr.GetByte("ADPhongMo");
        //    if (dr.GetDecimal("Dongia1") != null) _dongia1 = dr.GetDecimal("Dongia1");
        //    if (dr.GetDecimal("GiaChenhlech1") != null) _giaChenhlech1 = dr.GetDecimal("GiaChenhlech1");
        //    if (dr.GetSmartDate("Ngay1", true) != null) _ngay1 = dr.GetSmartDate("Ngay1", true);
        //    if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
        //    if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
        //    if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
        //    if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
        //    if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
        //    if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
        //    if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //}
		

        private  DMGiuong_Gia(SafeDataReader dr,int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT"); if (dr.GetDecimal("STT") != null) _sTT = dr.GetDecimal("STT");
			if (dr.GetString("MaGiuong") != null) _maGiuong = dr.GetString("MaGiuong");
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
			if (dr.GetString("NguoiSD")!= null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("TenGiuong") != null) _tenGiuong = dr.GetString("TenGiuong");
            if (dr.GetString("TenDT") != null) _tenDT = dr.GetString("TenDT");
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenNguoiLap") != null) _tenNguoiLap = dr.GetString("TenNguoiLap");
            if (dr.GetString("TenNguoiHuy") != null) _tenNguoiHuy = dr.GetString("TenNguoiHuy");
            if (dr.GetDecimal("DonGiaTT") != null) _donGiaTT = dr.GetDecimal("DonGiaTT");
            if (dr.GetString("TenTat") != null) _tenTat = dr.GetString("TenTat");
         
            MarkOld();
        }

		/// <summary>
		/// Insert the new <see cref="DMGiuong_Gia" /> Object to underlying database.
		/// </summary>
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMGiuong_Gia
			// Copy & paste ham duoi day vao file DataProvider.cs
            
            
			_maDT = DataProvider.Instance().InsertDMGiuong_Gia(_maDT, _maGiuong, _dongia, _giaChenhlech, _aDChenhlech, _adgiausd, _dTBH, _aDPhongMo, _dongia1, _giaChenhlech1, _ngay1, _ghichu, _maMay, _nguoiSD);
			// public abstract String InsertDMGiuong_Gia(String _maDT, String _maGiuong, Decimal _dongia, Decimal _giaChenhlech, Boolean _aDChenhlech, Boolean _adgiausd, Boolean _dTBH, Byte _aDPhongMo, Decimal _dongia1, Decimal _giaChenhlech1, SmartDate _ngay1, String _ghichu, String _maMay, String _nguoiLap);
			// public override String InsertDMGiuong_Gia(String _maDT, String _maGiuong, Decimal _dongia, Decimal _giaChenhlech, Boolean _aDChenhlech, Boolean _adgiausd, Boolean _dTBH, Byte _aDPhongMo, Decimal _dongia1, Decimal _giaChenhlech1, SmartDate _ngay1, String _ghichu, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMGiuong_GIA_CREATE", _maDT, _maGiuong, _dongia, _giaChenhlech, _aDChenhlech, _adgiausd, _dTBH, _aDPhongMo, _dongia1, _giaChenhlech1, _ngay1.DBValue, _ghichu, _maMay, _nguoiSD);
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMGiuong_Gia" /> Object to underlying database.
		/// </summary>
        internal void Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
            if (!this.IsDirty)
                return;

			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMGiuong_Gia
			
				DataProvider.Instance().UpdateDMGiuong_Gia(_maDT, _sTT, _maGiuong, _dongia, _giaChenhlech, _aDChenhlech, _adgiausd, _dTBH, _aDPhongMo, _ghichu, _maMay, _huy, _nguoiSD);
				// public abstract void UpdateDMGiuong_Gia(String _maDT, Decimal _sTT, String _maGiuong, Decimal _dongia, Decimal _giaChenhlech, Boolean _aDChenhlech, Boolean _adgiausd, Boolean _dTBH, Byte _aDPhongMo, Decimal _dongia1, Decimal _giaChenhlech1, SmartDate _ngay1, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateDMGiuong_Gia(String _maDT, Decimal _sTT, String _maGiuong, Decimal _dongia, Decimal _giaChenhlech, Boolean _aDChenhlech, Boolean _adgiausd, Boolean _dTBH, Byte _aDPhongMo, Decimal _dongia1, Decimal _giaChenhlech1, SmartDate _ngay1, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMGiuong_GIA_UPDATE", _maDT, _sTT, _maGiuong, _dongia, _giaChenhlech, _aDChenhlech, _adgiausd, _dTBH, _aDPhongMo, _dongia1, _giaChenhlech1, _ngay1.DBValue, _ghichu, _maMay, _huy, _nguoiSD);
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
        private void DataPortal_Delete(OtherCriteria crit)
        {
            DataProvider.Instance().DeleteDMGiuong_Gia(crit.MaMay, crit.NguoiSD, crit.maDT, crit.sTT);
        }
		/// <summary>
		/// Delete the <see cref="DMGiuong_Gia" />.
		/// </summary>
        //protected void DataPortal_Delete(Criteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMGiuong_Gia
        //    DataProvider.Instance().DeleteDMGiuong_Gia(crit.MaDT, crit.STT);
        //    // public abstract void DeleteDMGiuong_Gia(String _maDT, Decimal _sTT);
        //    // public override void DeleteDMGiuong_Gia(String _maDT, Decimal _sTT);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMGiuong_GIA_DELETED", _maDT, _sTT);
        //    // }
        //}

		#endregion
	}

}
