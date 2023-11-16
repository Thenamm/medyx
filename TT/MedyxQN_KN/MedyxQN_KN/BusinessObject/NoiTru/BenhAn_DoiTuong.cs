// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_DoiTuong
// Kieu doi tuong  :	BenhAn_DoiTuong
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	6/16/2009 10:12:26 AM
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

namespace HTC.Business.NoiTru
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="BenhAn_DoiTuong" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_DoiTuong : BusinessBase<BenhAn_DoiTuong>
	{
		#region Business Methods
		
		#region State Fields
       
		private String _maBA = String.Empty;
       
		private Int32 _STTDT = 0;
	
        private SmartDate _ngayVVTT = new SmartDate(true);//_nGAYVKhoaD

        private String _sothe = String.Empty;
        private SmartDate _giatriDN = new SmartDate(true);
        private String _maBV = String.Empty;
		private SmartDate _ngayKT = new SmartDate(true);
        private SmartDate _giaTriTN = new SmartDate(true);
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngayHuy = new SmartDate(true);
		private String _nguoiHuy = String.Empty;
	
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
		private String _tenDT = String.Empty;
        private String _maDT = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private int _OrderNumber;

        private String _ngayDu5Nam = String.Empty;
        private String _maKV = String.Empty;
        private String _ngayMienCCT = String.Empty;

		#endregion
		
		#region Business Properties and Methods

        public string MaKV
        {
            get
            {
                CanReadProperty(true);
                return _maKV;
            }
            set
            {
                CanReadProperty("MaKV", true);
                if (!_maKV.Equals(value))
                {
                    _maKV = value;
                    PropertyHasChanged("MaKV");
                }
            }
        }
        public string NgayMienCCT
        {
            get
            {
                CanReadProperty(true);
                return _ngayMienCCT;
            }
            set
            {
                CanReadProperty("NgayMienCCT", true);
                if (!_ngayMienCCT.Equals(value))
                {
                    _ngayMienCCT = value;
                    PropertyHasChanged("NgayMienCCT");
                }
            }
        }
        public String ngayDu5Nam
        {
            get
            {
                CanReadProperty("ngayDu5Nam", true);
                return _ngayDu5Nam;
            }
            set
            {
                CanWriteProperty("ngayDu5Nam", true);
                if (_ngayDu5Nam != value)
                {
                    _ngayDu5Nam = value;
                    PropertyHasChanged("ngayDu5Nam");
                }
            }
        }

		public String MaBA
		{
			get 
			{
				CanReadProperty("MaBA", true);
				return _maBA;
			}
			set 
			{
				CanWriteProperty("MaBA", true);
				if (_maBA != value) 
				{
					_maBA = value;
					PropertyHasChanged("MaBA");
				}
			}
		}
        public String Sothe
        {
            get
            {
                CanReadProperty("Sothe", true);
                return _sothe;
            }
            set
            {
                CanWriteProperty("Sothe", true);
                if (_sothe != value)
                {
                    _sothe = value;
                    PropertyHasChanged("Sothe");
                }
            }
        }

        public string GiatriDN
        {
            get
            {
                CanReadProperty("GiatriDN", true);
                return _giatriDN.Text;
            }
            set
            {
                CanWriteProperty("GiatriDN", true);
                if (_giatriDN.Text != value)
                {
                    _giatriDN.Text = value;
                    PropertyHasChanged("GiatriDN");
                }
            }
        }

        public String MaBV
        {
            get
            {
                CanReadProperty("MaBV", true);
                return _maBV;
            }
            set
            {
                CanWriteProperty("MaBV", true);
                if (_maBV != value)
                {
                    _maBV = value;
                    PropertyHasChanged("MaBV");
                }
            }
        }
        public string GiaTriTN
        {
            get
            {
                CanReadProperty("GiaTriTN", true);
                return _giaTriTN.Text;
            }
            set
            {
                CanWriteProperty("GiaTriTN", true);
                if (_giaTriTN.Text != value)
                {
                    _giaTriTN.Text = value;
                    PropertyHasChanged("GiaTriTN");
                }
            }
        }
       
		
		public Int32 STTDT
		{
			get 
			{
				CanReadProperty("STTDT", true);
				return _STTDT;
			}
			set 
			{
				CanWriteProperty("STTDT", true);
				if (_STTDT != value) 
				{
					_STTDT = value;
					PropertyHasChanged("STTDT");
				}
			}
		}
		
	
        public string NgayVVTT
        {
            get
            {
                CanReadProperty("NgayVVTT", true);
                return _ngayVVTT.Text;
            }
            set
            {
                CanWriteProperty("NgayVVTT", true);
                if (_ngayVVTT.Text != value)
                {
                    _ngayVVTT.Text = value;
                    PropertyHasChanged("NgayVVTT");
                }
            }
        }
		
	
		public string NgayKT
		{
			get 
			{
				CanReadProperty("NgayKT", true);
                this._ngayKT.FormatString = "dd/MM/yyyy";
				return _ngayKT.Text;
			}
			set 
			{
				CanWriteProperty("NgayKT", true);
				if (_ngayKT.Text != value) 
				{
					_ngayKT.Text = value;
					PropertyHasChanged("NgayKT");
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
                this._ngayLap.FormatString = "dd/MM/yyyy HH:mm";
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
               // this._ngaySD.FormatString = "dd/MM/yyyy";
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
			return _maBA.ToString() + "!" + _STTDT.ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhAn_DoiTuong" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

        public static BenhAn_DoiTuong NewBenhAn_DoiTuong()
        {
            return DataPortal.Create<BenhAn_DoiTuong>();
        }
        public static BenhAn_DoiTuong NewBenhAn_DoiTuong(string MaBA)
        {
            return DataPortal.Create<BenhAn_DoiTuong>(new CriteriaNew(MaBA));
        }
		public static BenhAn_DoiTuong GetBenhAn_DoiTuong(String maBA, Int32 STTDT)
		{
			return DataPortal.Fetch<BenhAn_DoiTuong>(new Criteria(maBA, STTDT));
		}
		
		/// <summary>
		/// Marks the <see cref="BenhAn_DoiTuong" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBenhAn_DoiTuong(String maBA, Int32 STTDT, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy , maBA, STTDT));
		}
        private BenhAn_DoiTuong(string MaBA)
        {
            _maBA = MaBA;
            
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BenhAn_DoiTuong()
		{	
			// Prevent direct creation
		}
        internal BenhAn_DoiTuong(
                                 int OrderNumber,
                                 String maBA ,
		                         Int32 STTDT ,
		                       
		                         SmartDate ngayKT ,
		                         String maMay ,
		                         Boolean huy ,
		                         SmartDate ngayHuy ,
		                         String nguoiHuy ,
		                       
		                         SmartDate ngayLap ,
		                         String nguoiLap ,
		                         SmartDate ngaySD ,
		                         String nguoiSD ,
		                         SmartDate ngaySD1,
		                         String nguoiSD1 ,
		                      
                             
                                 String tenDT ,
                                 String maDT ,

                                 SmartDate ngayvvtt,

                                 SmartDate giatridn,
           
                                
                                 SmartDate giatritn ,
         String sothe
                                )
        {
                                  _OrderNumber = OrderNumber ;
                                  _maBA = maBA ;
		                          _STTDT = STTDT;
                                  _giatriDN = giatridn;
                                  _giaTriTN = giatritn;
                                  _sothe = sothe;
                                  _ngayVVTT = ngayvvtt;
		                        
		                          _ngayKT = ngayKT ;
		                          _maMay = maMay ;
		                          _huy = huy;
		                          _ngayHuy = ngayHuy ;
		                          _nguoiHuy = nguoiHuy ;
		                       
		                          _ngayLap = ngayLap ;
		                          _nguoiLap = nguoiLap ;
		                          _ngaySD = ngaySD ;
		                          _nguoiSD = nguoiSD ;
		                          _ngaySD1 = ngaySD1 ;
		                          _nguoiSD1 = nguoiSD1 ;
		                        
                                  _tenDT = tenDT ;
                                  _maDT = maDT ;
                                


            
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maBA;
			public String MaBA 
			{
				get
				{
					return _maBA;
				}
			}
			
			private Int32 _STTDT;
			public Int32 STTDT 
			{
				get
				{
					return _STTDT;
				}
			}
			
			public Criteria(String maBA, Int32 STTDT)
			{
				_maBA = maBA;
				_STTDT = STTDT;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBA.Equals(c._maBA)) 
						return false;
					if (!_STTDT.Equals(c._STTDT)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBA.ToString(), _STTDT.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maBA;
            public String MaBA
            {
                get
                {
                    return _maBA;
                }
            }
            private Int32 _STTDT;
            public Int32 STTDT
            {
                get
                {
                    return _STTDT;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maba, Int32 STTDT)
            {
                _maBA = maba;
                _STTDT = STTDT;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
            }

        }

        protected class CriteriaNew
        {
            private String _maBA;
            public String maBA
            {
                get
                {
                    return _maBA;
                }
            }



            public CriteriaNew(String maBA)
            {
                _maBA = maBA; 
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
		/// Retrieve an existing <see cref="BenhAn_DoiTuong" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetBenhAn_DoiTuong(String _maBA, Int32 _STTDT);
			// public override IDataReader GetBenhAn_DoiTuong(String _maBA, Int32 _STTDT)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_DoiTuong_GET", _maBA, _STTDT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_DoiTuong(crit.MaBA, crit.STTDT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="BenhAn_DoiTuong" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
            if (dr.GetString("ngayDu5Nam") != null) _ngayDu5Nam = dr.GetString("ngayDu5Nam");
            if (dr.GetString("MaKV") != null) _maKV = dr.GetString("MaKV");
            if (dr.GetString("ngayMienCCT") != null) _ngayMienCCT = dr.GetString("ngayMienCCT");

			if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
			if (dr.GetInt32("STTDT") != null) _STTDT = dr.GetInt32("STTDT");
			
			if (dr.GetSmartDate("NgayKT", true) != null) _ngayKT = dr.GetSmartDate("NgayKT", true);
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
			if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
            if (dr.GetString("TENNGUOILAP") != null) _tenNguoiLap = dr.GetString("TENNGUOILAP");
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetSmartDate("giatridn", true) != null) _giatriDN = dr.GetSmartDate("giatridn", true);
            if (dr.GetSmartDate("giatritn", true) != null) _giaTriTN = dr.GetSmartDate("giatritn", true);
            if (dr.GetString("sothe") != null) _tenDT = dr.GetString("sothe");
            if (dr.GetString("TenDT") != null) _tenDT = dr.GetString("TenDT");
            if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
           
        }
		
		/// <summary>
		/// Insert the new <see cref="BenhAn_DoiTuong" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            //MarkAsChild();
            //ValidationRules.CheckRules();
            //MarkOld();
        }
        protected void DataPortal_Create(CriteriaNew param)
        {
            _maBA = param.maBA;
            //ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_DoiTuong
			// Copy & paste ham duoi day vao file DataProvider.cs
            _STTDT = DataProvider.Instance().InsertBenhAn_DoiTuong(_maBA, _ngayKT, _maMay, _nguoiLap, _maDT, _ngayVVTT, _sothe, _giatriDN, _maBV, _giaTriTN, _maKV, _ngayMienCCT, _ngayDu5Nam);
			// public abstract String InsertBenhAn_DoiTuong(String _maBA, String _maKhoa, String _maBN, SmartDate _ngayVKhoa, String _maBenh, String _maBenhKem, String _maTienLuong, String _bSDieuTri, String _yta, String _soPhong, String _soGiuong, SmartDate _ngayKT, String _maMay, String _nguoiLap);
			// public override String InsertBenhAn_DoiTuong(String _maBA, String _maKhoa, String _maBN, SmartDate _ngayVKhoa, String _maBenh, String _maBenhKem, String _maTienLuong, String _bSDieuTri, String _yta, String _soPhong, String _soGiuong, SmartDate _ngayKT, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_DoiTuong_CREATE", _maBA,  _maKhoa, _maBN, _ngayVKhoa.DBValue, _maBenh, _maBenhKem, _maTienLuong, _bSDieuTri, _yta, _soPhong, _soGiuong, _ngayKT.DBValue,_maMay ,   _nguoiLap);
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAn_DoiTuong" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_DoiTuong
			if (IsDirty){
                DataProvider.Instance().UpdateBenhAn_DoiTuong(_maBA, _STTDT, _ngayKT, _maMay, _huy, _nguoiSD, _maDT, _ngayVVTT, _sothe, _giatriDN, _maBV, _giaTriTN, _maKV, _ngayMienCCT, _ngayDu5Nam );
				// public abstract void UpdateBenhAn_DoiTuong(String _maBA, Int32 _STTDT, String _maKhoa, String _maBN, SmartDate _ngayVKhoa, String _maBenh, String _maBenhKem, String _maTienLuong, String _bSDieuTri, String _yta, String _soPhong, String _soGiuong, SmartDate _ngayKT, String _maMay, Boolean _huy, String _nguoiHuy, Byte _raKhoa);
				// public override void UpdateBenhAn_DoiTuong(String _maBA, Int32 _STTDT, String _maKhoa, String _maBN, SmartDate _ngayVKhoa, String _maBenh, String _maBenhKem, String _maTienLuong, String _bSDieuTri, String _yta, String _soPhong, String _soGiuong, SmartDate _ngayKT, String _maMay, Boolean _huy, String _nguoiHuy, Byte _raKhoa)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_DoiTuong_UPDATE", _maBA, _STTDT, _maKhoa, _maBN, _ngayVKhoa.DBValue, _maBenh, _maBenhKem, _maTienLuong, _bSDieuTri, _yta, _soPhong, _soGiuong, _ngayKT.DBValue,_maMay ,   _huy,_nguoiSD, _raKhoa);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            
            
        
            DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD   , _maBA, _STTDT));
		}

		/// <summary>
		/// Delete the <see cref="BenhAn_DoiTuong" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_DoiTuong
            DataProvider.Instance().DeleteBenhAn_DoiTuong(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.STTDT);
			// public abstract void DeleteBenhAn_DoiTuong(String _maBA, Int32 _STTDT);
			// public override void DeleteBenhAn_DoiTuong(String _maBA, Int32 _STTDT);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_DoiTuong_DELETED", _maBA, _STTDT);
			// }
		}

		#endregion
	}

}
