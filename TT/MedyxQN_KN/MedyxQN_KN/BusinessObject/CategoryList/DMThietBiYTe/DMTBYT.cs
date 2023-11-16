// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMTBYT
// Kieu doi tuong  :	DMTBYT
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	7/28/2009 11:17:54 AM
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
	/// This is a base generated class of <see cref="DMTBYT" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMTBYT : BusinessBase<DMTBYT>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maTB = String.Empty;
		private String _tenTB = String.Empty;
		private String _maNhom = String.Empty;
		private String _maChungLoai = String.Empty;
		private String _maLH = String.Empty;
		private String _maDVT = String.Empty;
		private SmartDate _namSX = new SmartDate(true);
		private Decimal _khoiLuong = 0;
		private Decimal _tl_khcb = 0;
		private String _ghichu = String.Empty;
		private Boolean _s_khauhao = false;
		private String _congsuatTK = String.Empty;
		private String _maNSX = String.Empty;
		private String _maQG = String.Empty;
		private Int32 _kyBaoDuong = 0;
		private String _maMay = String.Empty;
		private SmartDate _ngayHuy = new SmartDate(true);
		private String _nguoiHuy = String.Empty;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private Boolean _huy = false;
        private Boolean _KhongTinhTon = false;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
        private String _tennhom = String.Empty;
        private String _tenChungLoai = String.Empty;
        private String _tenNSX = String.Empty;
        private String _tenDVT = String.Empty;
        private String _tenQG = String.Empty;
        private String _tennguoiLap = String.Empty;
        private String _tennguoiSD = String.Empty;
        private String _tennguoiHuy = String.Empty;
        private int _OrderNumber;
        private int _ThangSD;
		#endregion
		
		#region Business Properties and Methods
        public Int32 ThangSD
        {
            get
            {
                CanReadProperty("ThangSD", true);
                return _ThangSD;
            }
            set
            {
                CanWriteProperty("ThangSD", true);
                if (_ThangSD != value)
                {
                    _ThangSD = value;
                    PropertyHasChanged("ThangSD");
                }
            }
        }
		public String MaTB
		{
			get 
			{
				CanReadProperty("MaTB", true);
				return _maTB;
			}
			set 
			{
				CanWriteProperty("MaTB", true);
				if (_maTB != value) 
				{
					_maTB = value;
					PropertyHasChanged("MaTB");
				}
			}
		}
		
		public String TenTB
		{
			get 
			{
				CanReadProperty("TenTB", true);
				return _tenTB;
			}
			set 
			{
				CanWriteProperty("TenTB", true);
				if (_tenTB != value) 
				{
					_tenTB = value;
					PropertyHasChanged("TenTB");
				}
			}
		}
		
		public String MaNhom
		{
			get 
			{
				CanReadProperty("MaNhom", true);
				return _maNhom;
			}
			set 
			{
				CanWriteProperty("MaNhom", true);
				if (_maNhom != value) 
				{
					_maNhom = value;
					PropertyHasChanged("MaNhom");
				}
			}
		}
		
		public String MaChungLoai
		{
			get 
			{
				CanReadProperty("MaChungLoai", true);
				return _maChungLoai;
			}
			set 
			{
				CanWriteProperty("MaChungLoai", true);
				if (_maChungLoai != value) 
				{
					_maChungLoai = value;
					PropertyHasChanged("MaChungLoai");
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
		
		public String MaDVT
		{
			get 
			{
				CanReadProperty("MaDVT", true);
				return _maDVT;
			}
			set 
			{
				CanWriteProperty("MaDVT", true);
				if (_maDVT != value) 
				{
					_maDVT = value;
					PropertyHasChanged("MaDVT");
				}
			}
		}
		
		public string NamSX
		{
			get 
			{
				CanReadProperty("NamSX", true);
				return _namSX.Text;
			}
			set 
			{
				CanWriteProperty("NamSX", true);
				if (_namSX.Text != value) 
				{
					_namSX.Text = value;
					PropertyHasChanged("NamSX");
				}
			}
		}
		
		public Decimal KhoiLuong
		{
			get 
			{
				CanReadProperty("KhoiLuong", true);
				return _khoiLuong;
			}
			set 
			{
				CanWriteProperty("KhoiLuong", true);
				if (_khoiLuong != value) 
				{
					_khoiLuong = value;
					PropertyHasChanged("KhoiLuong");
				}
			}
		}
		
		public Decimal Tl_khcb
		{
			get 
			{
				CanReadProperty("Tl_khcb", true);
				return _tl_khcb;
			}
			set 
			{
				CanWriteProperty("Tl_khcb", true);
				if (_tl_khcb != value) 
				{
					_tl_khcb = value;
					PropertyHasChanged("Tl_khcb");
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
		
		public Boolean S_khauhao
		{
			get 
			{
				CanReadProperty("S_khauhao", true);
				return _s_khauhao;
			}
			set 
			{
				CanWriteProperty("S_khauhao", true);
				if (_s_khauhao != value) 
				{
					_s_khauhao = value;
					PropertyHasChanged("S_khauhao");
				}
			}
		}
		
		public String CongsuatTK
		{
			get 
			{
				CanReadProperty("CongsuatTK", true);
				return _congsuatTK;
			}
			set 
			{
				CanWriteProperty("CongsuatTK", true);
				if (_congsuatTK != value) 
				{
					_congsuatTK = value;
					PropertyHasChanged("CongsuatTK");
				}
			}
		}
		
		public String MaNSX
		{
			get 
			{
				CanReadProperty("MaNSX", true);
				return _maNSX;
			}
			set 
			{
				CanWriteProperty("MaNSX", true);
				if (_maNSX != value) 
				{
					_maNSX = value;
					PropertyHasChanged("MaNSX");
				}
			}
		}
		
		public String MaQG
		{
			get 
			{
				CanReadProperty("MaQG", true);
				return _maQG;
			}
			set 
			{
				CanWriteProperty("MaQG", true);
				if (_maQG != value) 
				{
					_maQG = value;
					PropertyHasChanged("MaQG");
				}
			}
		}
		
		public Int32 KyBaoDuong
		{
			get 
			{
				CanReadProperty("KyBaoDuong", true);
				return _kyBaoDuong;
			}
			set 
			{
				CanWriteProperty("KyBaoDuong", true);
				if (_kyBaoDuong != value) 
				{
					_kyBaoDuong = value;
					PropertyHasChanged("KyBaoDuong");
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
        public Boolean KhongTinhTon
		{
			get 
			{
                CanReadProperty("KhongTinhTon", true);
                return _KhongTinhTon;
			}
			set 
			{
                CanWriteProperty("KhongTinhTon", true);
                if (_KhongTinhTon != value) 
				{
                    _KhongTinhTon = value;
                    PropertyHasChanged("KhongTinhTon");
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
                return _tennhom;
            }
            set
            {
                CanWriteProperty("TenNhom", true);
                if (_tennhom != value)
                {
                    _tennhom = value;
                    PropertyHasChanged("TenNhom");
                }
            }
        }

        public String TenChungLoai
        {
            get
            {
                CanReadProperty("TenChungLoai", true);
                return _tenChungLoai;
            }
            set
            {
                CanWriteProperty("TenChungLoai", true);
                if (_tenChungLoai != value)
                {
                    _tenChungLoai = value;
                    PropertyHasChanged("TenChungLoai");
                }
            }
        }

        public String TenNSX
        {
            get
            {
                CanReadProperty("TenNSX", true);
                return _tenNSX;
            }
            set
            {
                CanWriteProperty("TenNSX", true);
                if (_tenNSX != value)
                {
                    _tenNSX = value;
                    PropertyHasChanged("TenNSX");
                }
            }
        }

       
        public String TenDVT
        {
            get
            {
                CanReadProperty("TENDVT", true);
                return _tenDVT;
            }
            set
            {
                CanWriteProperty("TENDVT", true);
                if (_tenDVT != value)
                {
                    _tenDVT = value;
                    PropertyHasChanged("TENDVT");
                }
            }
        }

        public String TenQG
        {
            get
            {
                CanReadProperty("TenQG", true);
                return _tenQG;
            }
            set
            {
                CanWriteProperty("TenQG", true);
                if (_tenQG != value)
                {
                    _tenQG = value;
                    PropertyHasChanged("TenQG");
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
			return _maTB;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
		//protected override void AddBusinessRules()
		//{

		//	ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenTB", 350));
		//	ValidationRules.AddRule<DMTBYT>(StringRequired<DMTBYT>, "TenTB");
		//	ValidationRules.AddRule<DMTBYT>(StringRequiredDVT<DMTBYT>, "MaDVT");
		//	//ValidationRules.AddRule<DMTBYT>(ValidationNamSX<DMTBYT>, "NamSX");
            
		//}

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMTBYT
        {

            if (target._tenTB == null || target._tenTB.Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }

        private static bool StringRequiredDVT<T>(T target, Csla.Validation.RuleArgs e) where T : DMTBYT
        {

            if (target._maDVT == null || target._maDVT.Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }
        private static bool ValidationNamSX<T>(T target, Csla.Validation.RuleArgs e) where T : DMTBYT
        {
            if (target._namSX  > System.DateTime.Now)
            {
                e.Description = HTC.ShareVariables.VAR_VALIDATION_NOW;
                return false;
            }
            else
                return true;
        }
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMTBYT" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMTBYT NewDMTBYT()
        {
            return DataPortal.Create<DMTBYT>();
        }
		public static DMTBYT GetDMTBYT(String maTB)
		{
			return DataPortal.Fetch<DMTBYT>(new Criteria(maTB));
		}
		
		/// <summary>
		/// Marks the <see cref="DMTBYT" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMTBYT(String maTB, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maTB));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMTBYT()
		{	
			// Prevent direct creation
		}
        internal DMTBYT( 
                                 int OrderNumber,
                                 String maTB ,
		                         String tenTB ,
		                         String maNhom ,
		                         String maChungLoai ,
		                         String maLH ,
		                         String maDVT ,
		                         SmartDate namSX ,
		                         Decimal khoiLuong ,
		                         Decimal tl_khcb ,
		                         String ghichu ,
		                         Boolean s_khauhao ,
		                         String congsuatTK ,
		                         String maNSX ,
		                         String maQG ,
		                         Int32 kyBaoDuong ,
		                         String maMay ,
		                         SmartDate ngayHuy ,
		                         String nguoiHuy ,
		                         SmartDate ngayLap,
		                         String nguoiLap ,
		                         SmartDate ngaySD ,
		                         String nguoiSD ,
		                         Boolean huy ,
		                         SmartDate ngaySD1 ,
		                         String nguoiSD1 ,
                                 String tennhom ,
                                 String tenChungLoai ,
                                 String tenNSX ,
                                 String tenDVT ,
                                 String tenQG ,
                                 String tennguoiLap ,
                                 String tennguoiSD ,
                                 String tennguoiHuy ,
                                Int32 ThangSD
         )
        {
                          _OrderNumber = OrderNumber ;
                          _maTB = maTB ;
                         
		                  _tenTB = tenTB ;
		                  _maNhom = maNhom ;
		                  _maChungLoai = maChungLoai ;
		                  _maLH = maLH ;
		                  _maDVT = maDVT ;
		                  _namSX = namSX ;
		                  _khoiLuong = khoiLuong ;
		                  _tl_khcb = tl_khcb ;
		                  _ghichu = ghichu ;
		                  _s_khauhao = s_khauhao ;
		                  _congsuatTK = congsuatTK ;
		                  _maNSX = maNSX ;
		                  _maQG = maQG ;
		                  _kyBaoDuong = kyBaoDuong ;
		                  _maMay = maMay ;
		                  _ngayHuy = ngayHuy ;
		                  _nguoiHuy = String.Empty;
		                  _ngayLap = ngayLap ;
		                  _nguoiLap = nguoiLap ;
		                  _ngaySD = ngaySD ;
		                  _nguoiSD = nguoiSD ;
		                  _huy = huy;
                          _KhongTinhTon = KhongTinhTon;
		                  _ngaySD1 = ngaySD1 ;
		                  _nguoiSD1 = nguoiSD1 ;
                          _tennhom = tennhom ;
                          _tenChungLoai = tenChungLoai ;
                          _tenNSX = tenNSX ;
                          _tenDVT = tenDVT ;
                          _tenQG = tenQG ;
                          _tennguoiLap = tennguoiLap ;
                          _tennguoiSD = tennguoiSD ;
                          _tennguoiHuy = tennguoiHuy ;
                          _ThangSD = ThangSD;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maTB;
			public String MaTB 
			{
				get
				{
					return _maTB;
				}
			}
			
			public Criteria(String maTB)
			{
				_maTB = maTB;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maTB.Equals(c._maTB)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maTB.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maTB;
            public String MaTB
            {
                get
                {
                    return _maTB;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maTB)
            {
                _maTB  = maTB;
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
		/// Retrieve an existing <see cref="DMTBYT" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMTBYT(String _maTB);
			// public override IDataReader GetDMTBYT(String _maTB)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMTBYT_GET", _maTB));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMTBYT(crit.MaTB)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMTBYT" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaTB") != null) _maTB = dr.GetString("MaTB");
            if (dr.GetInt32("ThangSD") != null) _ThangSD = dr.GetInt32("ThangSD");
			if (dr.GetString("TenTB") != null) _tenTB = dr.GetString("TenTB");
			if (dr.GetString("MaNhom") != null) _maNhom = dr.GetString("MaNhom");
			if (dr.GetString("MaChungLoai") != null) _maChungLoai = dr.GetString("MaChungLoai");
			if (dr.GetString("MaLH") != null) _maLH = dr.GetString("MaLH");
			if (dr.GetString("MaDVT") != null) _maDVT = dr.GetString("MaDVT");
			if (dr.GetSmartDate("NamSX", true) != null) _namSX = dr.GetSmartDate("NamSX", true);
			if (dr.GetDecimal("KhoiLuong") != null) _khoiLuong = dr.GetDecimal("KhoiLuong");
			if (dr.GetDecimal("Tl_khcb") != null) _tl_khcb = dr.GetDecimal("Tl_khcb");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetBoolean("S_khauhao") != null) _s_khauhao = dr.GetBoolean("S_khauhao");
			if (dr.GetString("CongsuatTK") != null) _congsuatTK = dr.GetString("CongsuatTK");
			if (dr.GetString("MaNSX") != null) _maNSX = dr.GetString("MaNSX");
			if (dr.GetString("MaQG") != null) _maQG = dr.GetString("MaQG");
			if (dr.GetInt32("KyBaoDuong") != null) _kyBaoDuong = dr.GetInt32("KyBaoDuong");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
			if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr["KhongTinhTon"].GetType().Name != "DBNull" && dr.GetBoolean("KhongTinhTon") != null) _KhongTinhTon = dr.GetBoolean("KhongTinhTon");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetString("tenNSX") != null) _tenNSX = dr.GetString("tenNSX");
            if (dr.GetString("tendvt") != null) _tenDVT = dr.GetString("tendvt");
            if (dr.GetString("TenNhom") != null) _tennhom = dr.GetString("TenNhom");
            if (dr.GetString("TenChungLoai") != null) _tenChungLoai = dr.GetString("TenChungLoai");
            if (dr.GetString("TenQG") != null) _tenQG = dr.GetString("TenQG");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenNguoiLap") != null) _tennguoiLap = dr.GetString("TenNguoiLap");
            if (dr.GetString("TenNguoiHuy") != null) _tennguoiHuy = dr.GetString("TenNguoiHuy");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMTBYT" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMTBYT
			// Copy & paste ham duoi day vao file DataProvider.cs
            
            
              _maTB = DataProvider.Instance().InsertDMTBYT(_tenTB, _maNhom, _maChungLoai, _maLH, _maDVT, _namSX, _khoiLuong, _tl_khcb, _ghichu, _s_khauhao, _congsuatTK, _maNSX, _maQG, _kyBaoDuong, _maMay,_nguoiSD, ThangSD, _KhongTinhTon);
            // public abstract String InsertDMTBYT(String _tenTB, String _maNhom, String _maChungLoai, String _maLH, String _maDVT, SmartDate _namSX, Decimal _khoiLuong, Decimal _tl_khcb, String _ghichu, Boolean _s_khauhao, String _congsuatTK, String _maNSX, String _maQG, Int32 _kyBaoDuong, String _maMay, String _nguoiLap);
            // public override String InsertDMTBYT(String _tenTB, String _maNhom, String _maChungLoai, String _maLH, String _maDVT, SmartDate _namSX, Decimal _khoiLuong, Decimal _tl_khcb, String _ghichu, Boolean _s_khauhao, String _congsuatTK, String _maNSX, String _maQG, Int32 _kyBaoDuong, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMTBYT_CREATE", _tenTB, _maNhom, _maChungLoai, _maLH, _maDVT, _namSX.DBValue, _khoiLuong, _tl_khcb, _ghichu, _s_khauhao, _congsuatTK, _maNSX, _maQG, _kyBaoDuong, _maMay, _nguoiSD));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMTBYT" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMTBYT
			if (IsDirty){
                
                  
                  DataProvider.Instance().UpdateDMTBYT(_maTB, _tenTB, _maNhom, _maChungLoai, _maLH, _maDVT, _namSX, _khoiLuong, _tl_khcb, _ghichu, _s_khauhao, _congsuatTK, _maNSX, _maQG, _kyBaoDuong, _maMay,_nguoiSD, _huy, ThangSD, _KhongTinhTon);
				// public abstract void UpdateDMTBYT(String _maTB, String _tenTB, String _maNhom, String _maChungLoai, String _maLH, String _maDVT, SmartDate _namSX, Decimal _khoiLuong, Decimal _tl_khcb, String _ghichu, Boolean _s_khauhao, String _congsuatTK, String _maNSX, String _maQG, Int32 _kyBaoDuong, String _maMay, String _nguoiSD, Boolean _huy);
				// public override void UpdateDMTBYT(String _maTB, String _tenTB, String _maNhom, String _maChungLoai, String _maLH, String _maDVT, SmartDate _namSX, Decimal _khoiLuong, Decimal _tl_khcb, String _ghichu, Boolean _s_khauhao, String _congsuatTK, String _maNSX, String _maQG, Int32 _kyBaoDuong, String _maMay, String _nguoiSD, Boolean _huy)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMTBYT_UPDATE", _maTB, _tenTB, _maNhom, _maChungLoai, _maLH, _maDVT, _namSX.DBValue, _khoiLuong, _tl_khcb, _ghichu, _s_khauhao, _congsuatTK, _maNSX, _maQG, _kyBaoDuong, _maMay, _nguoiSD , _huy);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            //_nguoiHuy = HTC.ShareVariables.pub_sNguoiSD;
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maTB));
		}

		/// <summary>
		/// Delete the <see cref="DMTBYT" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMTBYT
            DataProvider.Instance().DeleteDMTBYT(crit.MaMay, crit.NguoiSD, crit.MaTB);
			// public abstract void DeleteDMTBYT(String _maTB);
			// public override void DeleteDMTBYT(String _maTB);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maTB);
			// }
		}

		#endregion
	}

}
