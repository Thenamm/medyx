// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMNgoaiNgu
// Kieu doi tuong  :	DMNgoaiNgu
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
	/// This is a base generated class of <see cref="DMNgoaiNgu" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMNgoaiNgu : BusinessBase<DMNgoaiNgu>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maNgoaiNgu = String.Empty;
		private String _tenNgoaiNgu = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private String _ghiChu = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String maNgoaiNgu
		{
			get 
			{
				CanReadProperty("maNgoaiNgu", true);
				return _maNgoaiNgu;
			}
			set 
			{
				CanWriteProperty("maNgoaiNgu", true);
				if (_maNgoaiNgu != value) 
				{
					_maNgoaiNgu = value;
					PropertyHasChanged("maNgoaiNgu");
				}
			}
		}

        public String TenNgoaiNgu
		{
			get 
			{
                CanReadProperty("TenNgoaiNgu", true);
				return _tenNgoaiNgu;
			}
			set 
			{
                CanWriteProperty("TenNgoaiNgu", true);
				if (_tenNgoaiNgu != value) 
				{
					_tenNgoaiNgu = value;
                    PropertyHasChanged("TenNgoaiNgu");
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
			return _maNgoaiNgu;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenNgoaiNgu", 150));
            ValidationRules.AddRule<DMNgoaiNgu>(StringRequired<DMNgoaiNgu>, "TenNgoaiNgu");
           
        }
        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMNgoaiNgu
        {

            if (target._tenNgoaiNgu == null || target._tenNgoaiNgu.Trim().Length == 0)
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
		/// Factory method. New <see cref="DMNgoaiNgu" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMNgoaiNgu NewDMNgoaiNgu()
        {
            return DataPortal.Create<DMNgoaiNgu>();
        }
		public static DMNgoaiNgu GetDMNgoaiNgu(String maNgoaiNgu)
		{
			return DataPortal.Fetch<DMNgoaiNgu>(new Criteria(maNgoaiNgu));
		}
		
		/// <summary>
		/// Marks the <see cref="DMNgoaiNgu" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMNgoaiNgu(String maNgoaiNgu, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maNgoaiNgu));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMNgoaiNgu()
		{	
			// Prevent direct creation
		}
        internal DMNgoaiNgu(int ordernumber, string MaQG, string TenQG, string idmay, bool huy, SmartDate ngaySD, string NguoiSD, string ghichu, string hoten)
        {
            _OrderNumber = ordernumber;
            _maNgoaiNgu   = MaQG;
            _tenNgoaiNgu  = TenQG;
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
			private String _maNgoaiNgu;
			public String maNgoaiNgu 
			{
				get
				{
					return _maNgoaiNgu;
				}
			}
			
			public Criteria(String maNgoaiNgu)
			{
				_maNgoaiNgu = maNgoaiNgu;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maNgoaiNgu.Equals(c._maNgoaiNgu)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maNgoaiNgu.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maNgoaiNgu;
            public String maNgoaiNgu
            {
                get
                {
                    return _maNgoaiNgu;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maNgoaiNgu)
            {
                _maNgoaiNgu = maNgoaiNgu;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
            }

            //public override bool Equals(object obj)
            //{
            //    if (obj is Criteria)
            //    {
            //        Criteria c = (Criteria)obj;
            //        if (!_maDV.Equals(c._maDV))
            //            return false;
            //        return true;
            //    }
            //    return false;
            //}

            //public override int GetHashCode()
            //{
            //    return string.Concat("Criteria", _maDV.ToString()).GetHashCode();
            //}
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
		/// Retrieve an existing <see cref="DMNgoaiNgu" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMNgoaiNgu(String _maNgoaiNgu);
			// public override IDataReader GetDMNgoaiNgu(String _maNgoaiNgu)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNgoaiNgu));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMNgoaiNgu(crit.maNgoaiNgu)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMNgoaiNgu" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("maNgoaiNgu") != null) _maNgoaiNgu = dr.GetString("maNgoaiNgu");
            if (dr.GetString("TenNgoaiNgu") != null) _tenNgoaiNgu = dr.GetString("TenNgoaiNgu");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetString("HoTen") != null) _hoten = dr.GetString("HoTen");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMNgoaiNgu" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMNgoaiNgu
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _maNgoaiNgu = DataProvider.Instance().InsertDMNgoaiNgu(_tenNgoaiNgu, _ghiChu, _maMay, _nguoiSD);
			// public abstract String InsertDMNgoaiNgu(String _tenNgoaiNgu, String _maMay, String _nguoiSD);
			// public override String InsertDMNgoaiNgu(String _tenNgoaiNgu, String _maMay, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenNgoaiNgu, _maMay,  _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMNgoaiNgu" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMNgoaiNgu
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMNgoaiNgu(_maNgoaiNgu, _tenNgoaiNgu,_ghiChu, _maMay, _nguoiSD ,_huy  );
				// public abstract void UpdateDMNgoaiNgu(String _maNgoaiNgu, String _tenNgoaiNgu, String _maMay, String _nguoiSD);
				// public override void UpdateDMNgoaiNgu(String _maNgoaiNgu, String _tenNgoaiNgu, String _maMay, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNgoaiNgu, _tenNgoaiNgu, _maMay,  _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maNgoaiNgu));
		}

		/// <summary>
		/// Delete the <see cref="DMNgoaiNgu" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMNgoaiNgu
            DataProvider.Instance().DeleteDMNgoaiNgu(crit.MaMay, crit.NguoiSD, crit.maNgoaiNgu);
			// public abstract void DeleteDMNgoaiNgu(String _maNgoaiNgu);
			// public override void DeleteDMNgoaiNgu(String _maNgoaiNgu);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNgoaiNgu);
			// }
		}

		#endregion
	}

}
