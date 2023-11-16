// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMDDHoiChan
// Kieu doi tuong  :	DMDDHoiChan
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	6/3/2009 9:56:57 AM
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
	/// This is a base generated class of <see cref="DMDDHoiChan" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMDDHoiChan : BusinessBase<DMDDHoiChan>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maDDHoiChan = String.Empty;
		private String _tenDDHoiChan = String.Empty;
		private String _ghiChu = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;
		#endregion
		
		#region Business Properties and Methods
		
		public String MaDDHoiChan
		{
			get 
			{
				CanReadProperty("MaDDHoiChan", true);
				return _maDDHoiChan;
			}
			set 
			{
				CanWriteProperty("MaDDHoiChan", true);
				if (_maDDHoiChan != value) 
				{
					_maDDHoiChan = value;
					PropertyHasChanged("MaDDHoiChan");
				}
			}
		}
		
		public String TenDDHoiChan
		{
			get 
			{
				CanReadProperty("TenDDHoiChan", true);
				return _tenDDHoiChan;
			}
			set 
			{
				CanWriteProperty("TenDDHoiChan", true);
				if (_tenDDHoiChan != value) 
				{
					_tenDDHoiChan = value;
					PropertyHasChanged("TenDDHoiChan");
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
                    _ngaySD.FormatString = "dd/MM/yyyy HH:mm:ss";
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

        public String Hoten
        {
            get
            {
                CanReadProperty("Hoten", true);
                return _hoten;
            }
            set
            {
                CanWriteProperty("Hoten", true);
                if (_hoten != value)
                {
                    _hoten = value;
                    PropertyHasChanged("Hoten");
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
			return _maDDHoiChan;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenDDHoiChan", 150));
            ValidationRules.AddRule<DMDDHoiChan>(StringRequired<DMDDHoiChan>, "TenDDHoiChan");
        }
        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMDDHoiChan
        {

            if (target._tenDDHoiChan == null || target._tenDDHoiChan.Trim().Length == 0)
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
		/// Factory method. New <see cref="DMDDHoiChan" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMDDHoiChan NewDMDDHoiChan()
        {
            return DataPortal.Create<DMDDHoiChan>();
            
        }
		public static DMDDHoiChan GetDMDDHoiChan(String maDDHoiChan)
		{
			return DataPortal.Fetch<DMDDHoiChan>(new Criteria(maDDHoiChan));
		}
		
		/// <summary>
		/// Marks the <see cref="DMDDHoiChan" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMDDHoiChan(String maDDHoiChan, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maDDHoiChan));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMDDHoiChan()
		{	
			// Prevent direct creation
		}
        internal DMDDHoiChan(    int OrderNumber,
                                 String maDDHoiChan ,
		                         String tenDDHoiChan ,
		                         String ghiChu ,
		                         String maMay ,
		                         Boolean huy ,
		                         SmartDate ngaySD ,
		                         String nguoiSD ,
                                 String hoten 
                                 )
        {
                                 _OrderNumber = OrderNumber ;
                                  _maDDHoiChan = maDDHoiChan ;
		                          _tenDDHoiChan = tenDDHoiChan ;
		                          _ghiChu = ghiChu ;
		                          _maMay = maMay ;
		                          _huy = huy;
		                          _ngaySD = ngaySD ;
		                          _nguoiSD = nguoiSD ;
                                  _hoten = hoten ;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maDDHoiChan;
			public String MaDDHoiChan 
			{
				get
				{
					return _maDDHoiChan;
				}
			}
			
			public Criteria(String maDDHoiChan)
			{
				_maDDHoiChan = maDDHoiChan;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maDDHoiChan.Equals(c._maDDHoiChan)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maDDHoiChan.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maDDHoiChan;
            public String maDDHoiChan
            {
                get
                {
                    return _maDDHoiChan;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maDDHoiChan)
            {
                _maDDHoiChan = maDDHoiChan;
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
		/// Retrieve an existing <see cref="DMDDHoiChan" /> Object based on data in the database.
		/// </summary>
        /// 

		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMDDHoiChan(String _maDDHoiChan);
			// public override IDataReader GetDMDDHoiChan(String _maDDHoiChan)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDDHoiChan));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMDDHoiChan(crit.MaDDHoiChan)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMDDHoiChan" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaDDHoiChan") != null) _maDDHoiChan = dr.GetString("MaDDHoiChan");
			if (dr.GetString("TenDDHoiChan") != null) _tenDDHoiChan = dr.GetString("TenDDHoiChan");
			if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMDDHoiChan" /> Object to underlying database.
		/// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDDHoiChan
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maDDHoiChan = DataProvider.Instance().InsertDMDDHoiChan(_tenDDHoiChan, _ghiChu, _maMay, _nguoiSD);
			// public abstract String InsertDMDDHoiChan(String _tenDDHoiChan, String _ghiChu, String _maMay, String _nguoiSD);
			// public override String InsertDMDDHoiChan(String _tenDDHoiChan, String _ghiChu, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDDHoiChan_CREATE", _tenDDHoiChan, _ghiChu, _maMay, _nguoiSD));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMDDHoiChan" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDDHoiChan
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMDDHoiChan(_maDDHoiChan, _tenDDHoiChan, _ghiChu, _maMay, _huy, _nguoiSD);
				// public abstract void UpdateDMDDHoiChan(String _maDDHoiChan, String _tenDDHoiChan, String _ghiChu, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateDMDDHoiChan(String _maDDHoiChan, String _tenDDHoiChan, String _ghiChu, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDDHoiChan_UPDATE", _maDDHoiChan, _tenDDHoiChan, _ghiChu, _maMay, _huy, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maDDHoiChan));
		}

		/// <summary>
		/// Delete the <see cref="DMDDHoiChan" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDDHoiChan
            DataProvider.Instance().DeleteDMDDHoiChan(crit.MaMay, crit.NguoiSD, crit.maDDHoiChan);
			// public abstract void DeleteDMDDHoiChan(String _maDDHoiChan);
			// public override void DeleteDMDDHoiChan(String _maDDHoiChan)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDDHoiChan_DELETED", _maDDHoiChan);
			// }
		}

		#endregion
	}

}
