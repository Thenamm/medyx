// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMDanhGiaHoSo
// Kieu doi tuong  :	DMDanhGiaHoSo
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
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
//

namespace HTC.Business.CategoryList
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="DMDanhGiaHoSo" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMDanhGiaHoSo : BusinessBase<DMDanhGiaHoSo>
	{
        string DatabaseOwner = "dbo.";
        String ConnectionString = ConfigurationManager.ConnectionStrings["SqlDataProvider"].ConnectionString + "; connection timeout=600; pooling=true; Max Pool Size=6000;Timeout=600;MultipleActiveResultSets=True";
        string ObjectQualifier = "";
        #region Business Methods

        #region State Fields

        private String _maDGHS = String.Empty;
		private String _tenDGHS = String.Empty;
        private String _tenNhom = String.Empty;
        private int _sTTNhom;
        private Decimal _diemToiDa;
		private String _ghichu = String.Empty;
		private String _maMay = String.Empty;
		private SmartDate _ngayHuy = new SmartDate(true);
		private String _nguoiHuy = String.Empty;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private Boolean _huy = false;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private int _OrderNumber;

		#endregion
        #region Business Properties and Methods
        public String MaDGHS
		{
			get 
			{
				CanReadProperty("MaDGHS", true);
				return _maDGHS;
			}
			set 
			{
				CanWriteProperty("MaDGHS", true);
				if (_maDGHS != value) 
				{
					_maDGHS = value;
					PropertyHasChanged("MaDGHS");
				}
			}
		}
		
		public String TenDGHS
		{
			get 
			{
				CanReadProperty("TenDGHS", true);
				return _tenDGHS;
			}
			set 
			{
				CanWriteProperty("TenDGHS", true);
				if (_tenDGHS != value) 
				{
					_tenDGHS = value;
					PropertyHasChanged("TenDGHS");
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
        public int STTNhom
        {
            get
            {
                CanReadProperty("STTNhom", true);
                return _sTTNhom;
            }
            set
            {
                CanWriteProperty("STTNhom", true);
                if (_sTTNhom != value)
                {
                    _sTTNhom = value;
                    PropertyHasChanged("STTNhom");
                }
            }
        }
        public Decimal DiemToiDa
		{
			get 
			{
				CanReadProperty("DiemToiDa", true);
				return _diemToiDa;
			}
			set 
			{
				CanWriteProperty("DiemToiDa", true);
				if (_diemToiDa != value) 
				{
					_diemToiDa = value;
					PropertyHasChanged("DiemToiDa");
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
			return _maDGHS;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenDGHS", 250));
            ValidationRules.AddRule<DMDanhGiaHoSo>(StringRequired<DMDanhGiaHoSo>, "TenDGHS");
          
        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMDanhGiaHoSo
        {

            if (target._tenDGHS == null || target._tenDGHS.Trim().Length == 0)
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
		/// Factory method. New <see cref="DMDanhGiaHoSo" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMDanhGiaHoSo NewDMDanhGiaHoSo()
        {
            return DataPortal.Create<DMDanhGiaHoSo>();
        }
		public static DMDanhGiaHoSo GetDMDanhGiaHoSo(String maDGHS)
		{
			return DataPortal.Fetch<DMDanhGiaHoSo>(new Criteria(maDGHS));
		}
		
		/// <summary>
		/// Marks the <see cref="DMDanhGiaHoSo" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMDanhGiaHoSo(String maDGHS, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maDGHS));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMDanhGiaHoSo()
		{	
			// Prevent direct creation
		}

        internal DMDanhGiaHoSo( 
 int OrderNumber,
 String maDGHS ,
		                         String tenDGHS ,
                                 String tenNhom,
                                 int sTTNhom,
		                         Decimal diemToiDa ,
		                         String ghichu ,
		                         String maMay ,
		                         SmartDate ngayHuy ,
		                         String nguoiHuy ,
		                         SmartDate ngayLap ,
		                         String nguoiLap ,
		                         SmartDate ngaySD ,
		                         String nguoiSD ,
		                         Boolean huy ,
                                 String tenNguoiLap ,
                                 String tenNguoiSD ,
                                 String tenNguoiHuy 
            )
        {
                                  _OrderNumber = OrderNumber ;
                                  _maDGHS = maDGHS ;
		                          _tenDGHS = tenDGHS ;
            _tenNhom = tenNhom;
            _sTTNhom = sTTNhom;
            _diemToiDa = diemToiDa;
		                          _ghichu = ghichu ;
		                          _maMay = maMay ;
		                          _ngayHuy = ngayHuy ;
		                          _nguoiHuy = nguoiHuy ;
		                          _ngayLap = ngayLap ;
		                          _nguoiLap = nguoiLap;
		                          _ngaySD = ngaySD ;
		                          _nguoiSD = nguoiSD ;
		                          _huy = huy;
        }

		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maDGHS;
			public String MaDGHS 
			{
				get
				{
					return _maDGHS;
				}
			}
			
			public Criteria(String maDGHS)
			{
				_maDGHS = maDGHS;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maDGHS.Equals(c._maDGHS)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maDGHS.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maDGHS;
            public String MaDGHS
            {
                get
                {
                    return _maDGHS;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaDGHS)
            {
                _maDGHS = MaDGHS;
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
		/// Retrieve an existing <see cref="DMDanhGiaHoSo" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
            // public abstract IDataReader GetDMDanhGiaHoSo(String _maDGHS);
            // public override IDataReader GetDMDanhGiaHoSo(String _maDGHS)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDanhGiaHoSo_Get", _maDGHS));
            // }


            using (SafeDataReader dr = new SafeDataReader((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDanhGiaHoSo_Get", crit.MaDGHS)))
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
		/// Load a <see cref="DMDanhGiaHoSo" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
         	if (dr.GetString("MaDGHS") != null) _maDGHS = dr.GetString("MaDGHS");
			if (dr.GetString("TenDGHS") != null) _tenDGHS = dr.GetString("TenDGHS");
            if (dr.GetString("TenNhom") != null) _tenNhom = dr.GetString("TenNhom");
            if (dr.GetInt32("STTNhom") != null) _sTTNhom = dr.GetInt32("STTNhom");
            if (dr.GetDecimal("diemToiDa") != null) _diemToiDa = dr.GetDecimal("diemToiDa");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
			if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetString("TenNguoiLap") != null) _tenNguoiLap = dr.GetString("TenNguoiLap");
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenNguoiHuy") != null) _tenNguoiHuy = dr.GetString("TenNguoiHuy");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMDanhGiaHoSo" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            _ngayLap.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDanhGiaHoSo
            // Copy & paste ham duoi day vao file DataProvider.cs
            _maDGHS = System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDanhGiaHoSo_CREATE", _tenDGHS, _diemToiDa, _ghichu, _maMay, _nguoiSD, _tenNhom,_sTTNhom));
			// public abstract String InsertDMDanhGiaHoSo(String _tenDGHS, String _maNHOM, String _tenTA, String _tenTat, Decimal _diemToiDa, Decimal _diemToiDa1, SmartDate _ngayTT1, String _ghichu, String _maMay, String _nguoiLap, Boolean _apdungGoi, Decimal _hoaHong, Decimal _gTHoaHong, Boolean _bCThu, Boolean _inThu);
			// public override String InsertDMDanhGiaHoSo(String _tenDGHS, String _maNHOM, String _tenTA, String _tenTat, Decimal _diemToiDa, Decimal _diemToiDa1, SmartDate _ngayTT1, String _ghichu, String _maMay, String _nguoiLap, Boolean _apdungGoi, Decimal _hoaHong, Decimal _gTHoaHong, Boolean _bCThu, Boolean _inThu)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDanhGiaHoSo_CREATE", _maDGHS, _tenDGHS, _maNHOM, _tenTA, _tenTat, _diemToiDa, _diemToiDa1, _ngayTT1.DBValue, _ghichu, _maMay, _nguoiSD , _apdungGoi, _hoaHong, _gTHoaHong, _bCThu, _inThu));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMDanhGiaHoSo" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDanhGiaHoSo
			if (IsDirty){
                SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDanhGiaHoSo_UPDATE", _maDGHS, _tenDGHS, _diemToiDa, _ghichu, _maMay, _nguoiSD, _huy, _tenNhom,_sTTNhom);
                //DataProvider.Instance().UpdateDMDanhGiaHoSo(_maDGHS, _tenDGHS, _diemToiDa, _ghichu, _maMay, _nguoiSD, _huy);
				// public abstract void UpdateDMDanhGiaHoSo(String _maDGHS, String _tenDGHS, String _maNHOM, String _tenTA, String _tenTat, Decimal _diemToiDa, Decimal _diemToiDa1, SmartDate _ngayTT1, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy, Boolean _apdungGoi, Decimal _hoaHong, Decimal _gTHoaHong, Boolean _bCThu, Boolean _inThu);
				// public override void UpdateDMDanhGiaHoSo(String _maDGHS, String _tenDGHS, String _maNHOM, String _tenTA, String _tenTat, Decimal _diemToiDa, Decimal _diemToiDa1, SmartDate _ngayTT1, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy, Boolean _apdungGoi, Decimal _hoaHong, Decimal _gTHoaHong, Boolean _bCThu, Boolean _inThu)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDanhGiaHoSo_UPDATE", _maDGHS, _tenDGHS, _maNHOM, _tenTA, _tenTat, _diemToiDa, _diemToiDa1, _ngayTT1.DBValue, _ghichu, _maMay, _nguoiSD , _huy, _apdungGoi, _hoaHong, _gTHoaHong, _bCThu, _inThu);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maDGHS));
		}

		/// <summary>
		/// Delete the <see cref="DMDanhGiaHoSo" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDanhGiaHoSo
            SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDanhGiaHoSo_DELETED", crit.MaMay, crit.NguoiSD, crit.MaDGHS);
            //DataProvider.Instance().DeleteDMDanhGiaHoSo(crit.MaMay, crit.NguoiSD, crit.MaDGHS);
			// public abstract void DeleteDMDanhGiaHoSo(String _maDGHS);
			// public override void DeleteDMDanhGiaHoSo(String _maDGHS)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDanhGiaHoSo_DELETED", _maDGHS);
			// }
		}

		#endregion
	}

}
