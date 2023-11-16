// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	Roles
// Kieu doi tuong  :	Roles
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	4/14/2009 3:58:46 PM
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
using HTC.Business.CategoryList;
 
namespace HTC.Business.Officer
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="Roles" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class Roles : BusinessBase<Roles>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _account = String.Empty;
		private String _maRole = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
        private String _hoten = String.Empty;
        private String _maRoleOld = String.Empty;
		#endregion
		
		#region Business Properties and Methods
		
		public String Account
		{
			get 
			{
				CanReadProperty("Account", true);
				return _account;
			}
			set 
			{
				CanWriteProperty("Account", true);
				if (_account != value) 
				{
					_account = value;
					PropertyHasChanged("Account");
				}
			}
		}
		
		public String MaRole
		{
			get 
			{
				CanReadProperty("MaRole", true);
				return _maRole;
			}
			set 
			{
				CanWriteProperty("MaRole", true);
				if (_maRole != value) 
				{
					_maRole = value;
					PropertyHasChanged("MaRole");
				}
			}
		}

        public String MaRoleOld
        {
            get
            {
                CanReadProperty("MaRoleOld", true);
                return _maRoleOld;
            }
            set
            {
                CanWriteProperty("MaRoleOld", true);
                if (_maRoleOld != value)
                {
                    _maRoleOld = value;
                    PropertyHasChanged("MaRoleOld");
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

		protected override Object GetIdValue()
		{
			return _account.ToString() + "!" + _maRole.ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="Roles" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 



        public static Roles NewRoles()
        {
            return new Roles();
        }
        public static Roles NewRoles(string marole)
        {
            return new Roles(DMRole.GetDMRole(marole));
        }
        public static Roles NewRoles(DMRole _DMRole)
        {
            return new Roles(_DMRole);
        }
		public static Roles GetRoles(String account, string marole)
		{
			return DataPortal.Fetch<Roles>(new Criteria(account, marole ));
		}
        public static Roles GetRoles(SafeDataReader dr)
        {
            return new Roles(dr);
        }
		/// <summary>
		/// Marks the <see cref="Roles" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteRoles(String account, String maRole, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy,  account, maRole));
           // DataProvider.Instance().DeleteRoles(_maMay, _nguoiSD , account, maRole);
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal Roles()
		{	
			// Prevent direct creation
		}
        protected Roles(DMRole pro)
        {
            MarkAsChild();
           
            //_maPhieu = dr.GetString("MaPhieu");
            _maRole = pro.MaRole;
           // _maMay = pro.MaMay;
           // _huy = pro.Huy;
           //// _ngaySD = pro.NgaySD ;
           // _nguoiSD = pro.NguoiSD;
            //_tenDV = pro.TenDV;
            //MarkOld();
        }

        protected Roles(string account, DMRole pro)
        {
            MarkAsChild();

            _account = account;
            _maRole = pro.MaRole;
            _maMay = pro.MaMay;
            _huy = pro.Huy;
            // _ngaySD = pro.NgaySD ;
            _nguoiSD = pro.NguoiSD;
            //_tenDV = pro.TenDV;
            //MarkOld();
        }

        protected Roles(SafeDataReader dr)
        {
            MarkAsChild();
         
             _account = dr.GetString("Account");
            _maRole = dr.GetString("MaRole");
             _maMay = dr.GetString("MaMay");
             _huy = dr.GetBoolean("Huy");
             _ngaySD = dr.GetSmartDate("NgaySD",false);
            _nguoiSD = dr.GetString("NguoiSD");
            _maRoleOld = dr.GetString("MaRole");
            
            MarkOld();
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _account;
			public String Account 
			{
				get
				{
					return _account;
				}
			}
			
			private String _maRole;
			public String MaRole 
			{
				get
				{
					return _maRole;
				}
			}
			
			public Criteria(String account, String maRole)
			{
				_account = account;
				_maRole = maRole;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_account.Equals(c._account)) 
						return false;
					if (!_maRole.Equals(c._maRole)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _account.ToString(), _maRole.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maRole;
            public String MaRole
            {
                get
                {
                    return _maRole;
                }
            }

            private String _account;
            public String Account
            {
                get
                {
                    return _account;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaRole, String account)
            {
                _maRole = MaRole;
                _account = account;
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
		/// Retrieve an existing <see cref="Roles" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetRoles(String _account, String _maRole);
			// public override IDataReader GetRoles(String _account, String _maRole)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _account, _maRole));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetRoles(crit.Account, crit.MaRole)))
			{
				if (dr.Read()){
					Fetch(dr);
                    //MarkOld();
                    //ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="Roles" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("Account") != null) _account = dr.GetString("Account");
			if (dr.GetString("MaRole") != null) _maRole = dr.GetString("MaRole");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("Hoten") != null) _hoten = dr.GetString("Hoten");
            if (dr.GetString("MaRole") != null) _maRoleOld = dr.GetString("MaRole");
		}
		
		/// <summary>
		/// Insert the new <see cref="Roles" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
        internal virtual void Insert(Account bill)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertRoles
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
            bill.account = DataProvider.Instance().InsertRoles(bill.account, _maRole, _maMay, _nguoiSD);
			// public abstract String InsertRoles(String _account, String _maRole, String _maMay, String _nguoiSD);
			// public override String InsertRoles(String _account, String _maRole, String _maMay,  String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spRoles_CREATE", _account, _maRole, _maMay, _nguoiSD));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="Roles" /> Object to underlying database.
		/// </summary>
        internal virtual void Update(Account bill)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateRoles
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateRoles(bill.account, _maRole,_maRoleOld , _maMay, _huy, _nguoiSD);
				// public abstract void UpdateRoles(String _account, String _maRole, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateRoles(String _account, String _maRole, String _maMay, Boolean _huy, String _nguoiSD);
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spROLES_UPDATE", _account, _maRole, _maMay, _huy, _nguoiSD);
				// }				
			}
		}
        //protected override void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _account, _maRole));
        //}

        ///// <summary>
        ///// Delete the <see cref="Roles" />.
        ///// </summary>
        //protected void DataPortal_Delete(OtherCriteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateRoles
        //    DataProvider.Instance().DeleteRoles(crit.MaMay, crit.NguoiSD, crit.Account, crit.MaRole);
        //    // public abstract void DeleteRoles(String _account, String _maRole);
        //    // public override void DeleteRoles(String _account, String _maRole);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spROLES_DELETED", _account, _maRole);
        //    // }
        //}
        internal void DeleteSelf(Account bill)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;
            DataProvider.Instance().DeleteRoles(_maMay, _nguoiSD , bill.account, _maRole );
            MarkNew();
        }
		#endregion
	}

}
