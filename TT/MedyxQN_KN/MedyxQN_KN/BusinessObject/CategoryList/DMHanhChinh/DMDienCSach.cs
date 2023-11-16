// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMDienCSach
// Kieu doi tuong  :	DMDienCSach
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	11/20/2008 2:34:50 PM
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
	/// This is a base generated class of <see cref="DMDienCSach" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMDienCSach : BusinessBase<DMDienCSach>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maDienCSach = String.Empty;
		private String _tenDienCSach = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private String _ghiChu = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String maDienCSach
		{
			get 
			{
				CanReadProperty("maDienCSach", true);
				return _maDienCSach;
			}
			set 
			{
				CanWriteProperty("maDienCSach", true);
				if (_maDienCSach != value) 
				{
					_maDienCSach = value;
					PropertyHasChanged("maDienCSach");
				}
			}
		}
		
		public String TenDienCSach
		{
			get 
			{
				CanReadProperty("TenDienCSach", true);
				return _tenDienCSach;
			}
			set 
			{
				CanWriteProperty("TenDienCSach", true);
				if (_tenDienCSach != value) 
				{
					_tenDienCSach = value;
					PropertyHasChanged("TenDienCSach");
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
			return _maDienCSach;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenDienCSach", 150));
            ValidationRules.AddRule<DMDienCSach>(StringRequired<DMDienCSach>, "TenDienCSach");

        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMDienCSach
        {

            if (target._tenDienCSach == null || target._tenDienCSach.Trim().Length == 0)
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
		/// Factory method. New <see cref="DMDienCSach" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMDienCSach NewDMDienCSach()
        {
            return DataPortal.Create<DMDienCSach>();
        }
		public static DMDienCSach GetDMDienCSach(String maDienCSach)
		{
			return DataPortal.Fetch<DMDienCSach>(new Criteria(maDienCSach));
		}
		
		/// <summary>
		/// Marks the <see cref="DMDienCSach" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMDienCSach(String maDienCSach, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maDienCSach));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMDienCSach()
		{	
			// Prevent direct creation
		}
        internal DMDienCSach(int ordernumber, string MaQG, string TenQG, string idmay, bool huy, SmartDate ngaySD, string NguoiSD, string ghichu, string hoten)
        {
            _OrderNumber = ordernumber;
            _maDienCSach   = MaQG;
            _tenDienCSach  = TenQG;
            _maMay = idmay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = NguoiSD;
            _ghiChu = ghichu;
            _hoten = hoten;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maDienCSach;
			public String maDienCSach 
			{
				get
				{
					return _maDienCSach;
				}
			}
			
			public Criteria(String maDienCSach)
			{
				_maDienCSach = maDienCSach;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maDienCSach.Equals(c._maDienCSach)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maDienCSach.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maDienCSach;
            public String maDienCSach
            {
                get
                {
                    return _maDienCSach;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maDienCSach)
            {
                _maDienCSach = maDienCSach;
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
		/// Retrieve an existing <see cref="DMDienCSach" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMDienCSach(String _maDienCSach);
			// public override IDataReader GetDMDienCSach(String _maDienCSach)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDienCSach));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMDienCSach(crit.maDienCSach)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMDienCSach" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("maDienCSach") != null) _maDienCSach = dr.GetString("maDienCSach");
			if (dr.GetString("TenDienCSach") != null) _tenDienCSach = dr.GetString("TenDienCSach");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetString("HoTen") != null) _hoten = dr.GetString("HoTen");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMDienCSach" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDienCSach
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _maDienCSach = DataProvider.Instance().InsertDMDienCSach(_tenDienCSach, _ghiChu, _maMay, _nguoiSD);
			// public abstract String InsertDMDienCSach(String _tenDienCSach, String _maMay, String _nguoiSD);
			// public override String InsertDMDienCSach(String _tenDienCSach, String _maMay, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenDienCSach, _maMay,  _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMDienCSach" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDienCSach
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMDienCSach(_maDienCSach, _tenDienCSach,_ghiChu, _maMay, _nguoiSD ,_huy  );
				// public abstract void UpdateDMDienCSach(String _maDienCSach, String _tenDienCSach, String _maMay, String _nguoiSD);
				// public override void UpdateDMDienCSach(String _maDienCSach, String _tenDienCSach, String _maMay, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDienCSach, _tenDienCSach, _maMay,  _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maDienCSach));
		}

		/// <summary>
		/// Delete the <see cref="DMDienCSach" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDienCSach
            DataProvider.Instance().DeleteDMDienCSach(crit.MaMay, crit.NguoiSD, crit.maDienCSach);
			// public abstract void DeleteDMDienCSach(String _maDienCSach);
			// public override void DeleteDMDienCSach(String _maDienCSach);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maDienCSach);
			// }
		}

		#endregion
	}

}
