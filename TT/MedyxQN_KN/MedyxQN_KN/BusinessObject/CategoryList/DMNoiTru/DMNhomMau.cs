// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMNhomMau
// Kieu doi tuong  :	DMNhomMau
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	6/12/2009 1:38:57 PM
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
	/// This is a base generated class of <see cref="DMNhomMau" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMNhomMau : BusinessBase<DMNhomMau>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maTienluong = String.Empty;
		private String _tenTienluong = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _ghiChu = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String MaTienluong
		{
			get 
			{
				CanReadProperty("MaTienluong", true);
				return _maTienluong;
			}
			set 
			{
				CanWriteProperty("MaTienluong", true);
				if (_maTienluong != value) 
				{
					_maTienluong = value;
					PropertyHasChanged("MaTienluong");
				}
			}
		}
		
		public String TenTienluong
		{
			get 
			{
				CanReadProperty("TenTienluong", true);
				return _tenTienluong;
			}
			set 
			{
				CanWriteProperty("TenTienluong", true);
				if (_tenTienluong != value) 
				{
					_tenTienluong = value;
					PropertyHasChanged("TenTienluong");
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
		
		public String GhiChu
		{
			get 
			{
				CanReadProperty("GhiChu", true);
				return _ghiChu;
			}
			set 
			{
				CanWriteProperty("GhiChu", true);
				if (_ghiChu != value) 
				{
					_ghiChu = value;
					PropertyHasChanged("GhiChu");
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
			return _maTienluong;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	 protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenTienluong", 150));
            ValidationRules.AddRule<DMNhomMau>(StringRequired<DMNhomMau>, "TenTienluong");


        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMNhomMau
        {

            if (target._tenTienluong == null || target._tenTienluong.Trim().Length == 0)
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
		/// Factory method. New <see cref="DMNhomMau" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMNhomMau NewDMNhomMau()
        {
            return DataPortal.Create<DMNhomMau>();
        }
		public static DMNhomMau GetDMNhomMau(String maTienluong)
		{
			return DataPortal.Fetch<DMNhomMau>(new Criteria(maTienluong));
		}
		
		/// <summary>
		/// Marks the <see cref="DMNhomMau" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMNhomMau(String maTienluong, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maTienluong));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMNhomMau()
		{	
			// Prevent direct creation
		}

        internal DMNhomMau(    int OrderNumber,
                                 String maTienluong ,
		                         String tenTienluong ,
		                         String maMay ,
		                         Boolean huy ,
		                         SmartDate ngaySD ,
		                         String nguoiSD ,
		                         String ghiChu ,
                                 String hoten 
                                 
            )
        {
                                  _OrderNumber = OrderNumber ;
                                  _maTienluong = maTienluong ;
		                          _tenTienluong = tenTienluong ;
		                          _maMay = maMay ;
		                          _huy = huy ;
		                          _ngaySD = ngaySD ;
		                          _nguoiSD = nguoiSD ;
		                          _ghiChu = ghiChu ;
                                  _hoten = hoten ;
        }

		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maTienluong;
			public String MaTienluong 
			{
				get
				{
					return _maTienluong;
				}
			}
			
			public Criteria(String maTienluong)
			{
				_maTienluong = maTienluong;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maTienluong.Equals(c._maTienluong)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maTienluong.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maTienluong;
            public String MaTienluong
            {
                get
                {
                    return _maTienluong;
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
            public OtherCriteria(String Mamay, String Nguoisd, String matenluong)
            {
                _maTienluong = matenluong;
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
		/// Retrieve an existing <see cref="DMNhomMau" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMNhomMau(String _maTienluong);
			// public override IDataReader GetDMNhomMau(String _maTienluong)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maTienluong));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMNhomMau(crit.MaTienluong)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMNhomMau" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaTienluong") != null) _maTienluong = dr.GetString("MaTienluong");
			if (dr.GetString("TenTienluong") != null) _tenTienluong = dr.GetString("TenTienluong");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMNhomMau" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMNhomMau
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maTienluong = DataProvider.Instance().InsertDMNhomMau(_tenTienluong, _maMay, _nguoiSD , _ghiChu);
			// public abstract String InsertDMNhomMau(String _tenTienluong, String _maMay, String _nguoiSD, String _ghiChu);
			// public override String InsertDMNhomMau(String _tenTienluong, String _maMay, String _nguoiSD, String _ghiChu)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMNhomMau_CREATE", _tenTienluong, _maMay, _nguoiSD , _ghiChu));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMNhomMau" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMNhomMau
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMNhomMau(_maTienluong, _tenTienluong, _maMay, _huy, _nguoiSD , _ghiChu);
				// public abstract void UpdateDMNhomMau(String _maTienluong, String _tenTienluong, String _maMay, Boolean _huy, String _nguoiSD, String _ghiChu);
				// public override void UpdateDMNhomMau(String _maTienluong, String _tenTienluong, String _maMay, Boolean _huy, String _nguoiSD, String _ghiChu)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMNhomMau_UPDATE", _maTienluong, _tenTienluong, _maMay, _huy, _nguoiSD , _ghiChu);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maTienluong));
		}

		/// <summary>
		/// Delete the <see cref="DMNhomMau" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMNhomMau
            DataProvider.Instance().DeleteDMNhomMau(crit.MaMay, crit.NguoiSD, crit.MaTienluong);
			// public abstract void DeleteDMNhomMau(String _maTienluong);
			// public override void DeleteDMNhomMau(String _maTienluong)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMNhomMau_DELETED", _maTienluong);
			// }
		}

		#endregion
	}

}
