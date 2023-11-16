// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMDTsudung
// Kieu doi tuong  :	DMDTsudung
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	12/20/2008 9:19:03 AM
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
	/// This is a base generated class of <see cref="DMDTsudung" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMDTsudung : BusinessBase<DMDTsudung>
	{
		#region Business Methods
		
		#region State Fields
		
		private Decimal _maDTsudung = 0;
		private String _tenDTsudung = String.Empty;
		private Byte _pPTinh = 0;
		private String _ghichu = String.Empty;
		private Decimal _sLTu = 0;
		private Decimal _sLDen = 0;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private int _OrderNumber;
        private String _hoten = String.Empty;
		#endregion
		
		#region Business Properties and Methods
		
		public Decimal MaDTsudung
		{
			get 
			{
				CanReadProperty("MaDTsudung", true);
				return _maDTsudung;
			}
			set 
			{
				CanWriteProperty("MaDTsudung", true);
				if (_maDTsudung != value) 
				{
					_maDTsudung = value;
					PropertyHasChanged("MaDTsudung");
				}
			}
		}
		
		public String TenDTsudung
		{
			get 
			{
				CanReadProperty("TenDTsudung", true);
				return _tenDTsudung;
			}
			set 
			{
				CanWriteProperty("TenDTsudung", true);
				if (_tenDTsudung != value) 
				{
					_tenDTsudung = value;
					PropertyHasChanged("TenDTsudung");
				}
			}
		}
		
		public Byte PPTinh
		{
			get 
			{
				CanReadProperty("PPTinh", true);
				return _pPTinh;
			}
			set 
			{
				CanWriteProperty("PPTinh", true);
				if (_pPTinh != value) 
				{
					_pPTinh = value;
					PropertyHasChanged("PPTinh");
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
		
		public Decimal SLTu
		{
			get 
			{
				CanReadProperty("SLTu", true);
				return _sLTu;
			}
			set 
			{
				CanWriteProperty("SLTu", true);
				if (_sLTu != value) 
				{
					_sLTu = value;
					PropertyHasChanged("SLTu");
				}
			}
		}
		
		public Decimal SLDen
		{
			get 
			{
				CanReadProperty("SLDen", true);
				return _sLDen;
			}
			set 
			{
				CanWriteProperty("SLDen", true);
				if (_sLDen != value) 
				{
					_sLDen = value;
					PropertyHasChanged("SLDen");
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
		
		public SmartDate NgaySD
		{
			get 
			{
				CanReadProperty("NgaySD", true);
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngaySD;
			}
			set 
			{
				CanWriteProperty("NgaySD", true);
				if (_ngaySD != value) 
				{
					_ngaySD = value;
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

       
        public String hoten
        {
            get
            {
                CanReadProperty("hoten", true);
                return _hoten;
            }
            set
            {
                CanWriteProperty("hoten", true);
                if (_hoten != value)
                {
                    _hoten = value;
                    PropertyHasChanged("hoten");
                }
            }
        }
		protected override Object GetIdValue()
		{
			return _maDTsudung;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TENDTsudung");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TENDTsudung", 150));
            ValidationRules.AddRule<DMDTsudung>(StringRequired<DMDTsudung>, "TENDTsudung");
            ValidationRules.AddInstanceRule<DMDTsudung>(StringRequired<DMDTsudung>, "TENDTsudung");

        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMDTsudung
        {

            if (target._tenDTsudung == null || target._tenDTsudung.Trim().Length == 0)
            {
                //e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                e.Description = "Tên đối tượng sử dụng không được để trống!";
                return false;
            }
            else
                return true;
        }
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMDTsudung" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMDTsudung NewDMDTsudung()
        {
            //return new DMNhomThuoc();
            return DataPortal.Create<DMDTsudung>();
        }
		public static DMDTsudung GetDMDTsudung(Decimal maDTsudung)
		{
			return DataPortal.Fetch<DMDTsudung>(new Criteria(maDTsudung));
		}
		
		/// <summary>
		/// Marks the <see cref="DMDTsudung" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMDTsudung(Decimal maDTsudung, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maDTsudung));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMDTsudung()
		{	
			// Prevent direct creation
		}
        internal DMDTsudung(int ordernumber, Decimal maDTsudung, String tenDTsudung, Byte pPTinh,String ghichu,Decimal sLTu,Decimal sLDen, String maMay, Boolean huy, SmartDate ngaySD, String nguoiSD,  String hoten)     
        {
            _OrderNumber = ordernumber;
            _maDTsudung   = maDTsudung;
            _tenDTsudung  = tenDTsudung;
            _pPTinh = pPTinh;
            _sLTu = sLTu;
            _sLDen = sLDen;
            _maMay = maMay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD;
            _hoten = hoten;

        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private Decimal _maDTsudung;
			public Decimal MaDTsudung 
			{
				get
				{
					return _maDTsudung;
				}
			}
			
			public Criteria(Decimal maDTsudung)
			{
				_maDTsudung = maDTsudung;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maDTsudung.Equals(c._maDTsudung)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maDTsudung.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private Decimal  _maDTsudung;
            public Decimal maDTsudung
            {
                get
                {
                    return _maDTsudung;
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
            public OtherCriteria(String Mamay, String Nguoisd, Decimal maDTsudung)
            {
                _maDTsudung = maDTsudung;
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
		/// Retrieve an existing <see cref="DMDTsudung" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMDTsudung(Decimal _maDTsudung);
			// public override IDataReader GetDMDTsudung(Decimal _maDTsudung)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDTsudung));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMDTsudung(crit.MaDTsudung)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMDTsudung" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetDecimal("MaDTsudung") != null) _maDTsudung = dr.GetDecimal("MaDTsudung");
			if (dr.GetString("TenDTsudung") != null) _tenDTsudung = dr.GetString("TenDTsudung");
			if (dr.GetByte("PPTinh") != null) _pPTinh = dr.GetByte("PPTinh");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetDecimal("SLTu") != null) _sLTu = dr.GetDecimal("SLTu");
			if (dr.GetDecimal("SLDen") != null) _sLDen = dr.GetDecimal("SLDen");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMDTsudung" /> Object to underlying database.
		/// </summary>
        ///  
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }

		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDTsudung
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maDTsudung = DataProvider.Instance().InsertDMDTsudung( _tenDTsudung, _pPTinh, _ghichu, _sLTu, _sLDen, _maMay, _nguoiSD);
			// public abstract Decimal InsertDMDTsudung(String _tenDTsudung, Byte _pPTinh, String _ghichu, Decimal _sLTu, Decimal _sLDen, String _maMay, String _nguoiSD);
			// public override Decimal InsertDMDTsudung(String _tenDTsudung, Byte _pPTinh, String _ghichu, Decimal _sLTu, Decimal _sLDen, String _maMay, String _nguoiSD)
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenDTsudung, _pPTinh, _ghichu, _sLTu, _sLDen, _maMay, _nguoiSD), Decimal);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMDTsudung" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDTsudung
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMDTsudung(_maDTsudung, _tenDTsudung, _pPTinh, _ghichu, _sLTu, _sLDen, _maMay, _nguoiSD);
				// public abstract void UpdateDMDTsudung(Decimal _maDTsudung, String _tenDTsudung, Byte _pPTinh, String _ghichu, Decimal _sLTu, Decimal _sLDen, String _maMay, String _nguoiSD);
				// public override void UpdateDMDTsudung(Decimal _maDTsudung, String _tenDTsudung, Byte _pPTinh, String _ghichu, Decimal _sLTu, Decimal _sLDen, String _maMay, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDTsudung, _tenDTsudung, _pPTinh, _ghichu, _sLTu, _sLDen, _maMay, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maDTsudung));
		}

		/// <summary>
		/// Delete the <see cref="DMDTsudung" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDTsudung
            DataProvider.Instance().DeleteDMDTsudung(crit.MaMay, crit.NguoiSD, crit.maDTsudung);
			// public abstract void DeleteDMDTsudung(Decimal _maDTsudung);
			// public override void DeleteDMDTsudung(Decimal _maDTsudung);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDTsudung);
			// }
		}

		#endregion
	}

}
