// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMKTPhauThuat
// Kieu doi tuong  :	DMKTPhauThuat
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	6/8/2009 9:30:58 AM
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
// 

namespace HTC.Business.CategoryList
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="DMKTPhauThuat" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMKTPhauThuat : BusinessBase<DMKTPhauThuat>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maPT = String.Empty;
		private String _tenPT = String.Empty;
		private String _maNHOM = String.Empty;
		private String _tenTA = String.Empty;
		private String _maBYTe = String.Empty;
		private Boolean _nhapSL = false;
		private String _tenTat = String.Empty;
		private String _maLH = String.Empty;
		private Decimal _dongiaTT = 0;
		private Decimal _dongiaTT1 = 0;
		private SmartDate _ngayTT1 = new SmartDate(true);
		private String _maChungloai = String.Empty;
		private Boolean _kTCao = false;
		private String _ghichu = String.Empty;
		private String _maMay = String.Empty;
		private SmartDate _ngayHuy = new SmartDate(true);
		private String _nguoiHuy = String.Empty;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
		private Boolean _aDGiaUSD = false;
		private SmartDate _ngayGia = new SmartDate(true);
        private Boolean _apdungGoi = true;
		private Boolean _dichVuGui = false;
		private Decimal _hoaHong = 0;
		private Decimal _gTHoaHong = 0;
		private Boolean _bCThu = false;
		private Boolean _inThu = false;
        private String _tenNhom = String.Empty;     
        private String _tennguoiLap = String.Empty;
        private String _tennguoiSD = String.Empty;
        private String _tennguoiHuy = String.Empty;
        private Boolean _goidichvu = false;
        private int _OrderNumber;
		#endregion
		
		#region Business Properties and Methods
		
		public String MaPT
		{
			get 
			{
				CanReadProperty("MaPT", true);
				return _maPT;
			}
			set 
			{
				CanWriteProperty("MaPT", true);
				if (_maPT != value) 
				{
					_maPT = value;
					PropertyHasChanged("MaPT");
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
		
		public String MaNHOM
		{
			get 
			{
				CanReadProperty("MaNHOM", true);
				return _maNHOM;
			}
			set 
			{
				CanWriteProperty("MaNHOM", true);
				if (_maNHOM != value) 
				{
					_maNHOM = value;
					PropertyHasChanged("MaNHOM");
				}
			}
		}
		
		public String TenTA
		{
			get 
			{
				CanReadProperty("TenTA", true);
				return _tenTA;
			}
			set 
			{
				CanWriteProperty("TenTA", true);
				if (_tenTA != value) 
				{
					_tenTA = value;
					PropertyHasChanged("TenTA");
				}
			}
		}
		
		public String MaBYTe
		{
			get 
			{
				CanReadProperty("MaBYTe", true);
				return _maBYTe;
			}
			set 
			{
				CanWriteProperty("MaBYTe", true);
				if (_maBYTe != value) 
				{
					_maBYTe = value;
					PropertyHasChanged("MaBYTe");
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
		
		public String MaLH
		{
			get 
			{
				CanReadProperty("MaLH", true);
				return _maLH;
			}
			set 
			{
				CanWriteProperty("MaLH", true);
				if (_maLH != value) 
				{
					_maLH = value;
					PropertyHasChanged("MaLH");
				}
			}
		}
		
		public Decimal DongiaTT
		{
			get 
			{
				CanReadProperty("DongiaTT", true);
				return _dongiaTT;
			}
			set 
			{
				CanWriteProperty("DongiaTT", true);
				if (_dongiaTT != value) 
				{
					_dongiaTT = value;
					PropertyHasChanged("DongiaTT");
				}
			}
		}
		
		public Decimal DongiaTT1
		{
			get 
			{
				CanReadProperty("DongiaTT1", true);
				return _dongiaTT1;
			}
			set 
			{
				CanWriteProperty("DongiaTT1", true);
				if (_dongiaTT1 != value) 
				{
					_dongiaTT1 = value;
					PropertyHasChanged("DongiaTT1");
				}
			}
		}
		
		public string NgayTT1
		{
			get 
			{
				CanReadProperty("NgayTT1", true);
                _ngayTT1.FormatString = "dd/MM/yyyy HH:mm:ss";
				return _ngayTT1.Text;
			}
			set 
			{
				CanWriteProperty("NgayTT1", true);
				if (_ngayTT1.Text != value) 
				{
					_ngayTT1.Text = value;
					PropertyHasChanged("NgayTT1");
				}
			}
		}
		
		public String MaChungloai
		{
			get 
			{
				CanReadProperty("MaChungloai", true);
				return _maChungloai;
			}
			set 
			{
				CanWriteProperty("MaChungloai", true);
				if (_maChungloai != value) 
				{
					_maChungloai = value;
					PropertyHasChanged("MaChungloai");
				}
			}
		}
		
		public Boolean KTCao
		{
			get 
			{
				CanReadProperty("KTCao", true);
				return _kTCao;
			}
			set 
			{
				CanWriteProperty("KTCao", true);
				if (_kTCao != value) 
				{
					_kTCao = value;
					PropertyHasChanged("KTCao");
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
		
		public string NgayHuy
		{
			get 
			{
				CanReadProperty("NgayHuy", true);
                _ngayHuy.FormatString = "dd/MM/yyyy HH:mm:ss";
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
		
		public string NgayLap
		{
			get 
			{
				CanReadProperty("NgayLap", true);
                _ngayLap.FormatString = "dd/MM/yyyy HH:mm:ss";
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
		
		public Boolean ADGiaUSD
		{
			get 
			{
				CanReadProperty("ADGiaUSD", true);
				return _aDGiaUSD;
			}
			set 
			{
				CanWriteProperty("ADGiaUSD", true);
				if (_aDGiaUSD != value) 
				{
					_aDGiaUSD = value;
					PropertyHasChanged("ADGiaUSD");
				}
			}
		}
		
		public string NgayGia
		{
			get 
			{
				CanReadProperty("NgayGia", true);
                _ngayGia.FormatString = "dd/MM/yyyy HH:mm:ss";
				return _ngayGia.Text;
			}
			set 
			{
				CanWriteProperty("NgayGia", true);
				if (_ngayGia.Text != value) 
				{
					_ngayGia.Text = value;
					PropertyHasChanged("NgayGia");
				}
			}
		}
        public Boolean goidichvu
        {
            get
            {
                CanReadProperty("goidichvu", true);
                return _goidichvu;
            }
            set
            {
                CanWriteProperty("goidichvu", true);
                if (_goidichvu != value)
                {
                    _goidichvu = value;
                    PropertyHasChanged("goidichvu");
                }
            }
        }
		public Boolean ApdungGoi
		{
			get 
			{
				CanReadProperty("ApdungGoi", true);
				return _apdungGoi;
			}
			set 
			{
				CanWriteProperty("ApdungGoi", true);
				if (_apdungGoi != value) 
				{
					_apdungGoi = value;
					PropertyHasChanged("ApdungGoi");
				}
			}
		}
		
		public Boolean DichVuGui
		{
			get 
			{
				CanReadProperty("DichVuGui", true);
				return _dichVuGui;
			}
			set 
			{
				CanWriteProperty("DichVuGui", true);
				if (_dichVuGui != value) 
				{
					_dichVuGui = value;
					PropertyHasChanged("DichVuGui");
				}
			}
		}
		
		public Decimal HoaHong
		{
			get 
			{
				CanReadProperty("HoaHong", true);
				return _hoaHong;
			}
			set 
			{
				CanWriteProperty("HoaHong", true);
				if (_hoaHong != value) 
				{
					_hoaHong = value;
					PropertyHasChanged("HoaHong");
				}
			}
		}
		
		public Decimal GTHoaHong
		{
			get 
			{
				CanReadProperty("GTHoaHong", true);
				return _gTHoaHong;
			}
			set 
			{
				CanWriteProperty("GTHoaHong", true);
				if (_gTHoaHong != value) 
				{
					_gTHoaHong = value;
					PropertyHasChanged("GTHoaHong");
				}
			}
		}
		
		public Boolean BCThu
		{
			get 
			{
				CanReadProperty("BCThu", true);
				return _bCThu;
			}
			set 
			{
				CanWriteProperty("BCThu", true);
				if (_bCThu != value) 
				{
					_bCThu = value;
					PropertyHasChanged("BCThu");
				}
			}
		}
		
		public Boolean InThu
		{
			get 
			{
				CanReadProperty("InThu", true);
				return _inThu;
			}
			set 
			{
				CanWriteProperty("InThu", true);
				if (_inThu != value) 
				{
					_inThu = value;
					PropertyHasChanged("InThu");
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

        public String TenNhom
        {
            get
            {
                CanReadProperty("TenNhom", true);
                return _tenNhom;
            }
            set
            {
                CanWriteProperty("TenNhom", true);
                if (_tenNhom != value)
                {
                    _tenNhom = value;
                    PropertyHasChanged("TenNhom");
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
			return _maPT;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenPT", 150));
            ValidationRules.AddRule<DMKTPhauThuat>(StringRequired<DMKTPhauThuat>, "TenPT");

        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMKTPhauThuat
        {

            if (target._tenPT == null || target._tenPT.Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMKTPhauThuat" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMKTPhauThuat NewDMKTPhauThuat()
        {
            return DataPortal.Create<DMKTPhauThuat>();
        }
		public static DMKTPhauThuat GetDMKTPhauThuat(String maPT)
		{
			return DataPortal.Fetch<DMKTPhauThuat>(new Criteria(maPT));
		}
		
		/// <summary>
		/// Marks the <see cref="DMKTPhauThuat" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMKTPhauThuat(String maPT, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maPT));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMKTPhauThuat()
		{	
			// Prevent direct creation
		}
        internal DMKTPhauThuat(
                         int OrderNumber,
                         String maPT ,
		                 String tenPT ,
		                 String maNHOM ,
		                 String tenTA ,
		                 String maBYTe ,
		                 Boolean nhapSL,
                         String tentat,
		                 String maLH,
		                 Decimal dongiaTT ,
		                 Decimal dongiaTT1 ,
		                 SmartDate ngayTT1 ,
		                 String maChungloai ,
		                 Boolean kTCao ,
		                 String ghichu ,
		                 String maMay ,
		                 SmartDate ngayHuy ,
		                 String nguoiHuy ,
		                 SmartDate ngayLap ,
		                 String nguoiLap ,
		                 SmartDate ngaySD ,
		                 String nguoiSD ,
		                 Boolean huy ,
		                 SmartDate ngaySD1 ,
		                 String nguoiSD1 ,
		                 Boolean aDGiaUSD ,
		                 SmartDate ngayGia ,
		                 Boolean apdungGoi ,
		                 Boolean dichVuGui ,
		                 Decimal hoaHong ,
		                 Decimal gTHoaHong ,
		                 Boolean bCThu ,
		                 Boolean inThu ,
                         String tenNhom ,   
                         String tennguoiLap ,
                         String tennguoiSD ,
                         String tennguoiHuy ,
                         Boolean goidichvu
          )
        {
                          _OrderNumber = OrderNumber ;
                          _maPT = maPT;
                          _tenPT = tenPT;
                          _maNHOM = maNHOM;
                          _tenTA = tenTA;
                          _maBYTe = maBYTe;
                          _nhapSL = nhapSL;
                          _tenTat = TenTat;
                          _maLH = maLH;
                          _dongiaTT = dongiaTT;
                          _dongiaTT1 = dongiaTT1;
                          _ngayTT1 = ngayTT1;
                          _maChungloai = maChungloai;
                          _kTCao = kTCao;
                          _ghichu = ghichu;
                          _maMay = maMay;
                          _ngayHuy = ngayHuy;
                          _nguoiHuy = nguoiHuy;
                          _ngayLap = ngayLap;
                          _nguoiLap = nguoiLap;
                          _ngaySD = ngaySD;
                          _nguoiSD = nguoiSD;
                          _huy = huy;
                          _ngaySD1 = ngaySD1;
                          _nguoiSD1 = nguoiSD1;
                          _aDGiaUSD = aDGiaUSD;
                          _ngayGia = ngayGia;
                          _apdungGoi = apdungGoi;
                          _dichVuGui = dichVuGui;
                          _hoaHong = hoaHong;
                          _gTHoaHong = gTHoaHong;
                          _bCThu = bCThu;
                          _inThu = inThu;
                          _tenNhom = tenNhom;
                          _tennguoiLap = tennguoiLap;
                          _tennguoiSD = tennguoiSD;
                          _tennguoiHuy = tennguoiHuy;
                          _goidichvu = goidichvu;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maPT;
			public String MaPT 
			{
				get
				{
					return _maPT;
				}
			}
			
			public Criteria(String maPT)
			{
				_maPT = maPT;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maPT.Equals(c._maPT)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maPT.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maPT;
            public String MaPT
            {
                get
                {
                    return _maPT;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maPT)
            {
                _maPT = maPT;
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
		/// Retrieve an existing <see cref="DMKTPhauThuat" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMKTPhauThuat(String _maPT);
			// public override IDataReader GetDMKTPhauThuat(String _maPT)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maPT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMKTPhauThuat(crit.MaPT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMKTPhauThuat" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaPT") != null) _maPT = dr.GetString("MaPT");
			if (dr.GetString("TenPT") != null) _tenPT = dr.GetString("TenPT");
			if (dr.GetString("MaNHOM") != null) _maNHOM = dr.GetString("MaNHOM");
			if (dr.GetString("TenTA") != null) _tenTA = dr.GetString("TenTA");
			if (dr.GetString("MaBYTe") != null) _maBYTe = dr.GetString("MaBYTe");
			if (dr.GetBoolean("NhapSL") != null) _nhapSL = dr.GetBoolean("NhapSL");
			if (dr.GetString("TenTat") != null) _tenTat = dr.GetString("TenTat");
			if (dr.GetString("MaLH") != null) _maLH = dr.GetString("MaLH");
			if (dr.GetDecimal("DongiaTT") != null) _dongiaTT = dr.GetDecimal("DongiaTT");
			if (dr.GetDecimal("DongiaTT1") != null) _dongiaTT1 = dr.GetDecimal("DongiaTT1");
			if (dr.GetSmartDate("NgayTT1", true) != null) _ngayTT1 = dr.GetSmartDate("NgayTT1", true);
			if (dr.GetString("MaChungloai") != null) _maChungloai = dr.GetString("MaChungloai");
			if (dr.GetBoolean("KTCao") != null) _kTCao = dr.GetBoolean("KTCao");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
			if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
			if (dr.GetBoolean("ADGiaUSD") != null) _aDGiaUSD = dr.GetBoolean("ADGiaUSD");
			if (dr.GetSmartDate("NgayGia", true) != null) _ngayGia = dr.GetSmartDate("NgayGia", true);
			if (dr.GetBoolean("ApdungGoi") != null) _apdungGoi = dr.GetBoolean("ApdungGoi");
            if (dr.GetBoolean("goidichvu") != null) _goidichvu = dr.GetBoolean("goidichvu");
			if (dr.GetBoolean("DichVuGui") != null) _dichVuGui = dr.GetBoolean("DichVuGui");
			if (dr.GetDecimal("HoaHong") != null) _hoaHong = dr.GetDecimal("HoaHong");
			if (dr.GetDecimal("GTHoaHong") != null) _gTHoaHong = dr.GetDecimal("GTHoaHong");
			if (dr.GetBoolean("BCThu") != null) _bCThu = dr.GetBoolean("BCThu");
			if (dr.GetBoolean("InThu") != null) _inThu = dr.GetBoolean("InThu");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMKTPhauThuat" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            _ngayLap.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMKTPhauThuat
			// Copy & paste ham duoi day vao file DataProvider.cs
            
            
			_maPT = DataProvider.Instance().InsertDMKTPhauThuat(_tenPT, _maNHOM, _tenTA, _maBYTe, _nhapSL, _tenTat, _maLH, _dongiaTT, _dongiaTT1, _ngayTT1, _maChungloai, _kTCao, _ghichu, _maMay, _nguoiSD , _apdungGoi, _dichVuGui, _hoaHong, _gTHoaHong, _bCThu, _inThu,_goidichvu );
			// public abstract String InsertDMKTPhauThuat(String _tenPT, String _maNHOM, String _tenTA, String _maBYTe, Boolean _nhapSL, String _tenTat, String _maLH, Decimal _dongiaTT, Decimal _dongiaTT1, SmartDate _ngayTT1, String _maChungloai, Boolean _kTCao, String _ghichu, String _maMay, String _nguoiLap, Boolean _apdungGoi, Boolean _dichVuGui, Decimal _hoaHong, Decimal _gTHoaHong, Boolean _bCThu, Boolean _inThu);
            // public override String InsertDMKTPhauThuat(String _tenPT, String _maNHOM, String _tenTA, String _maBYTe, Boolean _nhapSL, String _tenTat, String _maLH, Decimal _dongiaTT, Decimal _dongiaTT1, SmartDate _ngayTT1, String _maChungloai, Boolean _kTCao, String _ghichu, String _maMay, String _nguoiLap, Boolean _apdungGoi, Boolean _dichVuGui, Decimal _hoaHong, Decimal _gTHoaHong, Boolean _bCThu, Boolean _inThu)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMKTPhauThuat_CREATE", _tenPT, _maNHOM, _tenTA, _maBYTe, _nhapSL, _tenTat, _maLH, _dongiaTT, _dongiaTT1, _ngayTT1.DBValue, _maChungloai, _kTCao, _ghichu, _maMay, _nguoiSD , _apdungGoi, _dichVuGui, _hoaHong, _gTHoaHong, _bCThu, _inThu));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMKTPhauThuat" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMKTPhauThuat
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMKTPhauThuat(_maPT, _tenPT, _maNHOM, _tenTA, _maBYTe, _nhapSL, _tenTat, _maLH, _dongiaTT, _dongiaTT1, _ngayTT1, _maChungloai, _kTCao, _ghichu, _maMay, _nguoiSD , _huy, _apdungGoi, _dichVuGui, _hoaHong, _gTHoaHong, _bCThu, _inThu,_goidichvu );
				// public abstract void UpdateDMKTPhauThuat(String _maPT, String _tenPT, String _maNHOM, String _tenTA, String _maBYTe, Boolean _nhapSL, String _tenTat, String _maLH, Decimal _dongiaTT, Decimal _dongiaTT1, SmartDate _ngayTT1, String _maChungloai, Boolean _kTCao, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy, Boolean _apdungGoi, Boolean _dichVuGui, Decimal _hoaHong, Decimal _gTHoaHong, Boolean _bCThu, Boolean _inThu);
				// public override void UpdateDMKTPhauThuat(String _maPT, String _tenPT, String _maNHOM, String _tenTA, String _maBYTe, Boolean _nhapSL, String _tenTat, String _maLH, Decimal _dongiaTT, Decimal _dongiaTT1, SmartDate _ngayTT1, String _maChungloai, Boolean _kTCao, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy, Boolean _apdungGoi, Boolean _dichVuGui, Decimal _hoaHong, Decimal _gTHoaHong, Boolean _bCThu, Boolean _inThu)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMKTPhauThuat_UPDATE", _maPT, _tenPT, _maNHOM, _tenTA, _maBYTe, _nhapSL, _tenTat, _maLH, _dongiaTT, _dongiaTT1, _ngayTT1.DBValue, _maChungloai, _kTCao, _ghichu, _maMay, _ngayHuy.DBValue, _nguoiSD , _ngayLap.DBValue, _nguoiSD , _ngaySD.DBValue, _nguoiSD , _huy, _ngaySD1.DBValue, _nguoiSD1, _aDGiaUSD, _ngayGia.DBValue, _apdungGoi, _dichVuGui, _hoaHong, _gTHoaHong, _bCThu, _inThu);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maPT));
		}

		/// <summary>
		/// Delete the <see cref="DMKTPhauThuat" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMKTPhauThuat
            DataProvider.Instance().DeleteDMKTPhauThuat(crit.MaMay, crit.NguoiSD, crit.MaPT);
			// public abstract void DeleteDMKTPhauThuat(String _maPT);
			// public override void DeleteDMKTPhauThuat(String _maPT)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMKTPhauThuat_DELETED", _maPT);
			// }
		}

		#endregion
	}

}
