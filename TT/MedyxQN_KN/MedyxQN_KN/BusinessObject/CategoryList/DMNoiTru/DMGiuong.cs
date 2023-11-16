// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMGiuong
// Kieu doi tuong  :	DMGiuong
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	6/11/2009 8:38:08 AM
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
	/// This is a base generated class of <see cref="DMGiuong" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMGiuong : BusinessBase<DMGiuong>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maGiuong = String.Empty;
		private String _tenGiuong = String.Empty;
		private String _maNHOM = String.Empty;
		private String _tenTA = String.Empty;
		private String _tenTat = String.Empty;
		private Decimal _dongiaTT = 0;
		private Decimal _dongiaTT1 = 0;
		private SmartDate _ngayTT1 = new SmartDate(true);
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
		private Decimal _BHTra = 0;
		private Decimal _gTHoaHong = 0;
		private Boolean _bCThu = false;
		private Boolean _inThu = false;
        private String _tenNhom = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private String _tenGiuongBH = String.Empty;
        private String _maBYTe = String.Empty;
        private String _QuyetDinhBH = String.Empty;
       private String _MaBH = String.Empty; private string _MaTDuong = String.Empty;
        private String _TenBYTe = String.Empty;
        private String _QuyetDinh = String.Empty;
        private int _OrderNumber;

		#endregion
        public String MaTDuong
        {
            get
            {
                CanReadProperty("MaTDuong", true);
                return _MaTDuong;
            }
            set
            {
                CanWriteProperty("MaTDuong", true);
                if (_MaTDuong != value)
                {
                    _MaTDuong = value;
                    PropertyHasChanged("MaTDuong");
                }
            }
        }
        public String MaBH
        {
            get
            {
                CanReadProperty("MaBH", true);
                return _MaBH;
            }
            set
            {
                CanWriteProperty("MaBH", true);
                if (_MaBH != value)
                {
                    _MaBH = value;
                    PropertyHasChanged("MaBH");
                }
            }
        }
        public String QuyetDinhBH
        {
            get
            {
                CanReadProperty("QuyetDinhBH", true);
                return _QuyetDinhBH;
            }
            set
            {
                CanWriteProperty("QuyetDinhBH", true);
                if (_QuyetDinhBH != value)
                {
                    _QuyetDinhBH = value;
                    PropertyHasChanged("QuyetDinhBH");
                }
            }
        }
        public String TenBYTe
        {
            get
            {
                CanReadProperty("TenBYTe", true);
                return _TenBYTe;
            }
            set
            {
                CanWriteProperty("TenBYTe", true);
                if (_TenBYTe != value)
                {
                    _TenBYTe = value;
                    PropertyHasChanged("TenBYTe");
                }
            }
        }
		#region Business Properties and Methods
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

        public String QuyetDinh
        {
            get
            {
                CanReadProperty("QuyetDinh", true);
                return _QuyetDinh;
            }
            set
            {
                CanWriteProperty("QuyetDinh", true);
                if (_QuyetDinh != value)
                {
                    _QuyetDinh = value;
                    PropertyHasChanged("QuyetDinh");
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
        public String TenGiuongDu
        {
            get
            {

                return _maGiuong + "-" + _tenGiuong;
            }

        }
        public String TenGiuongBH
        {
            get
            {
                CanReadProperty("TenGiuongBH", true);
                return _tenGiuongBH;
            }
            set
            {
                CanWriteProperty("TenGiuongBH", true);
                if (_tenGiuongBH != value)
                {
                    _tenGiuongBH = value;
                    PropertyHasChanged("TenGiuongBH");
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
		
		public Decimal BHTra
		{
			get 
			{
				CanReadProperty("BHTra", true);
				return _BHTra;
			}
			set 
			{
				CanWriteProperty("BHTra", true);
				if (_BHTra != value) 
				{
					_BHTra = value;
					PropertyHasChanged("BHTra");
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
			return _maGiuong;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenGiuong", 450));
            ValidationRules.AddRule<DMGiuong>(StringRequired<DMGiuong>, "TenGiuong");
          
        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMGiuong
        {

            if (target._tenGiuong == null || target._tenGiuong.Trim().Length == 0)
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
		/// Factory method. New <see cref="DMGiuong" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMGiuong NewDMGiuong()
        {
            return DataPortal.Create<DMGiuong>();
        }
		public static DMGiuong GetDMGiuong(String maGiuong)
		{
			return DataPortal.Fetch<DMGiuong>(new Criteria(maGiuong));
		}
		
		/// <summary>
		/// Marks the <see cref="DMGiuong" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMGiuong(String maGiuong, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maGiuong));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMGiuong()
		{	
			// Prevent direct creation
		}

        internal DMGiuong( 
 int OrderNumber,
 String maGiuong ,
		                         String tenGiuong ,
		                         String maNHOM ,
		                         String tenTA ,
		                         String tenTat ,
		                         Decimal dongiaTT ,
		                         Decimal dongiaTT1 ,
		                         SmartDate ngayTT1 ,
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
		                         Decimal BHTra ,
		                         Decimal gTHoaHong ,
		                         Boolean bCThu ,
		                         Boolean inThu ,
                                 String tenNhom ,
                                 String tenNguoiLap ,
                                 String tenNguoiSD ,
                                 String tenNguoiHuy ,String maBYTe,
             String quyetdinh,

                                 String tenGiuongBH,
            String maBh,String matduong,
             String quyetdinhbh,
            String tenbyte

            )
        {
             _MaBH = maBh; _MaTDuong = matduong;
            _TenBYTe = tenbyte;
            _QuyetDinhBH = quyetdinhbh;
            _maBYTe = maBYTe;
            _QuyetDinh = quyetdinh;
           
                                  _OrderNumber = OrderNumber ;
                                  _maGiuong = maGiuong ;
		                          _tenGiuong = tenGiuong ;
		                          _maNHOM = maNHOM ;
		                          _tenTA = tenTA ;
		                          _tenTat = tenTat ;
		                          _dongiaTT = dongiaTT ;
		                          _dongiaTT1 = dongiaTT1 ;
		                          _ngayTT1 = ngayTT1 ;
		                          _ghichu = ghichu ;
		                          _maMay = maMay ;
		                          _ngayHuy = ngayHuy ;
		                          _nguoiHuy = nguoiHuy ;
		                          _ngayLap = ngayLap ;
		                          _nguoiLap = nguoiLap;
		                          _ngaySD = ngaySD ;
		                          _nguoiSD = nguoiSD ;
		                          _huy = huy;
		                          _ngaySD1 = ngaySD1 ;
		                          _nguoiSD1 = nguoiSD1 ;
		                          _aDGiaUSD = aDGiaUSD ;
		                          _ngayGia = ngayGia ;
		                          _apdungGoi = apdungGoi ;
		                          _BHTra = BHTra ;
		                          _gTHoaHong = gTHoaHong ;
		                          _bCThu = bCThu ;
		                          _inThu = inThu ;
                                  _tenNhom = tenNhom ;
                                  _tenNguoiLap = tenNguoiLap ;
                                  _tenNguoiSD = tenNguoiSD ;
                                  _tenNguoiHuy = tenNguoiHuy ;
                                  _tenGiuongBH = tenGiuongBH;  
        }

		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maGiuong;
			public String MaGiuong 
			{
				get
				{
					return _maGiuong;
				}
			}
			
			public Criteria(String maGiuong)
			{
				_maGiuong = maGiuong;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maGiuong.Equals(c._maGiuong)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maGiuong.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maGiuong;
            public String MaGiuong
            {
                get
                {
                    return _maGiuong;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaGiuong)
            {
                _maGiuong = MaGiuong;
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
		/// Retrieve an existing <see cref="DMGiuong" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMGiuong(String _maGiuong);
			// public override IDataReader GetDMGiuong(String _maGiuong)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMGiuong_Get", _maGiuong));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMGiuong(crit.MaGiuong)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMGiuong" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
            if (dr.GetString("MaBH") != null) _MaBH = dr.GetString("MaBH"); if (dr.GetString("MaTDuong") != null) _MaTDuong = dr.GetString("MaTDuong");
            if (dr.GetString("QuyetDinhBH") != null) _QuyetDinhBH = dr.GetString("QuyetDinhBH");
            if (dr.GetString("TenBYte") != null) _TenBYTe = dr.GetString("TenBYte");

            if (dr.GetString("MaBYTe") != null) _maBYTe = dr.GetString("MaBYTe");
            if (dr.GetString("QuyetDinh") != null) _QuyetDinh = dr.GetString("QuyetDinh");
         	if (dr.GetString("MaGiuong") != null) _maGiuong = dr.GetString("MaGiuong");
			if (dr.GetString("TenGiuong") != null) _tenGiuong = dr.GetString("TenGiuong");
			if (dr.GetString("MaNHOM") != null) _maNHOM = dr.GetString("MaNHOM");
			if (dr.GetString("TenTA") != null) _tenTA = dr.GetString("TenTA");
			if (dr.GetString("TenTat") != null) _tenTat = dr.GetString("TenTat");
			if (dr.GetDecimal("DongiaTT") != null) _dongiaTT = dr.GetDecimal("DongiaTT");
			if (dr.GetDecimal("DongiaTT1") != null) _dongiaTT1 = dr.GetDecimal("DongiaTT1");
			if (dr.GetSmartDate("NgayTT1", true) != null) _ngayTT1 = dr.GetSmartDate("NgayTT1", true);
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
			if (dr.GetDecimal("BHTra") != null) _BHTra = dr.GetDecimal("BHTra");
			if (dr.GetDecimal("GTHoaHong") != null) _gTHoaHong = dr.GetDecimal("GTHoaHong");
			if (dr.GetBoolean("BCThu") != null) _bCThu = dr.GetBoolean("BCThu");
			if (dr.GetBoolean("InThu") != null) _inThu = dr.GetBoolean("InThu");
            if (dr.GetString("TenNhom") != null) _tenNhom = dr.GetString("TenNhom");
            if (dr.GetString("TenNguoiLap") != null) _tenNguoiLap = dr.GetString("TenNguoiLap");
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenNguoiHuy") != null) _tenNguoiHuy = dr.GetString("TenNguoiHuy");
            if (dr.GetString("TenGiuongBH") != null) _tenGiuongBH = dr.GetString("TenGiuongBH");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMGiuong" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            _ngayLap.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMGiuong
			// Copy & paste ham duoi day vao file DataProvider.cs


            _maGiuong = DataProvider.Instance().InsertDMGiuong(_tenGiuong, _maNHOM, _tenTA, _tenTat, _dongiaTT, _dongiaTT1, _ngayTT1, _ghichu, _maMay, _nguoiSD, _apdungGoi, _BHTra, _gTHoaHong, _bCThu, _inThu, _tenGiuongBH, _maBYTe, _QuyetDinh, _MaBH,_MaTDuong, _QuyetDinhBH, _TenBYTe);
			// public abstract String InsertDMGiuong(String _tenGiuong, String _maNHOM, String _tenTA, String _tenTat, Decimal _dongiaTT, Decimal _dongiaTT1, SmartDate _ngayTT1, String _ghichu, String _maMay, String _nguoiLap, Boolean _apdungGoi, Decimal _hoaHong, Decimal _gTHoaHong, Boolean _bCThu, Boolean _inThu);
			// public override String InsertDMGiuong(String _tenGiuong, String _maNHOM, String _tenTA, String _tenTat, Decimal _dongiaTT, Decimal _dongiaTT1, SmartDate _ngayTT1, String _ghichu, String _maMay, String _nguoiLap, Boolean _apdungGoi, Decimal _hoaHong, Decimal _gTHoaHong, Boolean _bCThu, Boolean _inThu)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMGiuong_CREATE", _maGiuong, _tenGiuong, _maNHOM, _tenTA, _tenTat, _dongiaTT, _dongiaTT1, _ngayTT1.DBValue, _ghichu, _maMay, _nguoiSD , _apdungGoi, _hoaHong, _gTHoaHong, _bCThu, _inThu));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMGiuong" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMGiuong
			if (IsDirty){
                DataProvider.Instance().UpdateDMGiuong(_maGiuong, _tenGiuong, _maNHOM, _tenTA, _tenTat, _dongiaTT, _dongiaTT1, _ngayTT1, _ghichu, _maMay, _nguoiSD, _huy, _apdungGoi, _BHTra, _gTHoaHong, _bCThu, _inThu, _tenGiuongBH, _maBYTe, _QuyetDinh, _MaBH,_MaTDuong, _QuyetDinhBH, _TenBYTe);
				// public abstract void UpdateDMGiuong(String _maGiuong, String _tenGiuong, String _maNHOM, String _tenTA, String _tenTat, Decimal _dongiaTT, Decimal _dongiaTT1, SmartDate _ngayTT1, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy, Boolean _apdungGoi, Decimal _hoaHong, Decimal _gTHoaHong, Boolean _bCThu, Boolean _inThu);
				// public override void UpdateDMGiuong(String _maGiuong, String _tenGiuong, String _maNHOM, String _tenTA, String _tenTat, Decimal _dongiaTT, Decimal _dongiaTT1, SmartDate _ngayTT1, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy, Boolean _apdungGoi, Decimal _hoaHong, Decimal _gTHoaHong, Boolean _bCThu, Boolean _inThu)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMGiuong_UPDATE", _maGiuong, _tenGiuong, _maNHOM, _tenTA, _tenTat, _dongiaTT, _dongiaTT1, _ngayTT1.DBValue, _ghichu, _maMay, _nguoiSD , _huy, _apdungGoi, _hoaHong, _gTHoaHong, _bCThu, _inThu);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maGiuong));
		}

		/// <summary>
		/// Delete the <see cref="DMGiuong" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMGiuong
            DataProvider.Instance().DeleteDMGiuong(crit.MaMay, crit.NguoiSD, crit.MaGiuong);
			// public abstract void DeleteDMGiuong(String _maGiuong);
			// public override void DeleteDMGiuong(String _maGiuong)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMGiuong_DELETED", _maGiuong);
			// }
		}

		#endregion
	}

}
