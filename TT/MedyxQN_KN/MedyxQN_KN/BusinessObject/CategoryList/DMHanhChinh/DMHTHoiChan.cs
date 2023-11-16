// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMHTHoiChan
// Kieu doi tuong  :	DMHTHoiChan
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
	/// This is a base generated class of <see cref="DMHTHoiChan" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMHTHoiChan : BusinessBase<DMHTHoiChan>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maHTHoiChan = String.Empty;
		private String _tenHTHoiChan = String.Empty;
		private String _ghiChu = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;
		#endregion
		
		#region Business Properties and Methods
		
		public String MaHTHoiChan
		{
			get 
			{
				CanReadProperty("MaHTHoiChan", true);
				return _maHTHoiChan;
			}
			set 
			{
				CanWriteProperty("MaHTHoiChan", true);
				if (_maHTHoiChan != value) 
				{
					_maHTHoiChan = value;
					PropertyHasChanged("MaHTHoiChan");
				}
			}
		}
		
		public String TenHTHoiChan
		{
			get 
			{
				CanReadProperty("TenHTHoiChan", true);
				return _tenHTHoiChan;
			}
			set 
			{
				CanWriteProperty("TenHTHoiChan", true);
				if (_tenHTHoiChan != value) 
				{
					_tenHTHoiChan = value;
					PropertyHasChanged("TenHTHoiChan");
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
			return _maHTHoiChan;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenHTHoiChan", 150));
            ValidationRules.AddRule<DMHTHoiChan>(StringRequired<DMHTHoiChan>, "TenHTHoiChan");
        }
        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMHTHoiChan
        {

            if (target._tenHTHoiChan == null || target._tenHTHoiChan.Trim().Length == 0)
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
		/// Factory method. New <see cref="DMHTHoiChan" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMHTHoiChan NewDMHTHoiChan()
        {
            return DataPortal.Create<DMHTHoiChan>();
            
        }
		public static DMHTHoiChan GetDMHTHoiChan(String MaHTHoiChan)
		{
			return DataPortal.Fetch<DMHTHoiChan>(new Criteria(MaHTHoiChan));
		}
		
		/// <summary>
		/// Marks the <see cref="DMHTHoiChan" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMHTHoiChan(String MaHTHoiChan, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,MaHTHoiChan));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMHTHoiChan()
		{	
			// Prevent direct creation
		}
        internal DMHTHoiChan(    int OrderNumber,
                                 String MaHTHoiChan ,
		                         String TenHTHoiChan ,
		                         String ghiChu ,
		                         String maMay ,
		                         Boolean huy ,
		                         SmartDate ngaySD ,
		                         String nguoiSD ,
                                 String hoten 
                                 )
        {
                                 _OrderNumber = OrderNumber ;
                                  _maHTHoiChan = MaHTHoiChan ;
		                          _tenHTHoiChan = TenHTHoiChan ;
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
			private String _maHTHoiChan;
			public String MaHTHoiChan 
			{
				get
				{
					return _maHTHoiChan;
				}
			}
			
			public Criteria(String MaHTHoiChan)
			{
				_maHTHoiChan = MaHTHoiChan;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maHTHoiChan.Equals(c._maHTHoiChan)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maHTHoiChan.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maHTHoiChan;
            public String MaHTHoiChan
            {
                get
                {
                    return _maHTHoiChan;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaHTHoiChan)
            {
                _maHTHoiChan = MaHTHoiChan;
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
		/// Retrieve an existing <see cref="DMHTHoiChan" /> Object based on data in the database.
		/// </summary>
        /// 

		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMHTHoiChan(String _maHTHoiChan);
			// public override IDataReader GetDMHTHoiChan(String _maHTHoiChan)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maHTHoiChan));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMHTHoiChan(crit.MaHTHoiChan)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMHTHoiChan" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaHTHoiChan") != null) _maHTHoiChan = dr.GetString("MaHTHoiChan");
			if (dr.GetString("TenHTHoiChan") != null) _tenHTHoiChan = dr.GetString("TenHTHoiChan");
			if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMHTHoiChan" /> Object to underlying database.
		/// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMHTHoiChan
			// Copy & paste ham duoi day vao file DataProvider.cs
			_maHTHoiChan = DataProvider.Instance().InsertDMHTHoiChan(_tenHTHoiChan, _ghiChu, _maMay, _nguoiSD);
			// public abstract String InsertDMHTHoiChan(String _tenHTHoiChan, String _ghiChu, String _maMay, String _nguoiSD);
			// public override String InsertDMHTHoiChan(String _tenHTHoiChan, String _ghiChu, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMHTHoiChan_CREATE", _tenHTHoiChan, _ghiChu, _maMay, _nguoiSD));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMHTHoiChan" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMHTHoiChan
			if (IsDirty){
                DataProvider.Instance().UpdateDMHTHoiChan(_maHTHoiChan, _tenHTHoiChan, _ghiChu, _maMay, _nguoiSD , _huy);
				// public abstract void UpdateDMHTHoiChan(String _maHTHoiChan, String _tenHTHoiChan, String _ghiChu, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateDMHTHoiChan(String _maHTHoiChan, String _tenHTHoiChan, String _ghiChu, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMHTHoiChan_UPDATE", _maHTHoiChan, _tenHTHoiChan, _ghiChu, _maMay, _huy, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maHTHoiChan));
		}

		/// <summary>
		/// Delete the <see cref="DMHTHoiChan" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMHTHoiChan
            DataProvider.Instance().DeleteDMHTHoiChan(crit.MaMay, crit.NguoiSD, crit.MaHTHoiChan);
			// public abstract void DeleteDMHTHoiChan(String _maHTHoiChan);
			// public override void DeleteDMHTHoiChan(String _maHTHoiChan)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMHTHoiChan_DELETED", _maHTHoiChan);
			// }
		}

		#endregion
	}

}
