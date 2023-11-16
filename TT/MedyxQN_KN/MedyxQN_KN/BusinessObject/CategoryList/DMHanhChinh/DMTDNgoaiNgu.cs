// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMTDNgoaiNgu
// Kieu doi tuong  :	DMTDNgoaiNgu
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

namespace HTC.Business.CategoryList
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="DMTDNgoaiNgu" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMTDNgoaiNgu : BusinessBase<DMTDNgoaiNgu>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maTDNgoaiNgu = String.Empty;
		private String _tenTDNgoaiNgu = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private String _ghiChu = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String maTDNgoaiNgu
		{
			get 
			{
				CanReadProperty("maTDNgoaiNgu", true);
				return _maTDNgoaiNgu;
			}
			set 
			{
				CanWriteProperty("maTDNgoaiNgu", true);
				if (_maTDNgoaiNgu != value) 
				{
					_maTDNgoaiNgu = value;
					PropertyHasChanged("maTDNgoaiNgu");
				}
			}
		}

        public String TenTDNgoaiNgu
		{
			get 
			{
                CanReadProperty("TenTDNgoaiNgu", true);
				return _tenTDNgoaiNgu;
			}
			set 
			{
                CanWriteProperty("TenTDNgoaiNgu", true);
				if (_tenTDNgoaiNgu != value) 
				{
					_tenTDNgoaiNgu = value;
                    PropertyHasChanged("TenTDNgoaiNgu");
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
			return _maTDNgoaiNgu;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMTDNgoaiNgu" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMTDNgoaiNgu NewDMTDNgoaiNgu()
        {
            return new DMTDNgoaiNgu();
        }
		public static DMTDNgoaiNgu GetDMTDNgoaiNgu(String maTDNgoaiNgu)
		{
			return DataPortal.Fetch<DMTDNgoaiNgu>(new Criteria(maTDNgoaiNgu));
		}
		
		/// <summary>
		/// Marks the <see cref="DMTDNgoaiNgu" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMTDNgoaiNgu(String maTDNgoaiNgu, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maTDNgoaiNgu));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMTDNgoaiNgu()
		{	
			// Prevent direct creation
		}
        internal DMTDNgoaiNgu(int ordernumber, string MaQG, string TenQG, string idmay, bool huy, SmartDate ngaySD, string NguoiSD, string ghichu, string hoten)
        {
            _OrderNumber = ordernumber;
            _maTDNgoaiNgu   = MaQG;
            _tenTDNgoaiNgu  = TenQG;
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
			private String _maTDNgoaiNgu;
			public String maTDNgoaiNgu 
			{
				get
				{
					return _maTDNgoaiNgu;
				}
			}
			
			public Criteria(String maTDNgoaiNgu)
			{
				_maTDNgoaiNgu = maTDNgoaiNgu;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maTDNgoaiNgu.Equals(c._maTDNgoaiNgu)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maTDNgoaiNgu.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maTDNgoaiNgu;
            public String maTDNgoaiNgu
            {
                get
                {
                    return _maTDNgoaiNgu;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maTDNgoaiNgu)
            {
                _maTDNgoaiNgu = maTDNgoaiNgu;
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
		/// Retrieve an existing <see cref="DMTDNgoaiNgu" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMTDNgoaiNgu(String _maTDNgoaiNgu);
			// public override IDataReader GetDMTDNgoaiNgu(String _maTDNgoaiNgu)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maTDNgoaiNgu));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMTDNgoaiNgu(crit.maTDNgoaiNgu)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMTDNgoaiNgu" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("maTDNgoaiNgu") != null) _maTDNgoaiNgu = dr.GetString("maTDNgoaiNgu");
            if (dr.GetString("TenTDNgoaiNgu") != null) _tenTDNgoaiNgu = dr.GetString("TenTDNgoaiNgu");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetString("HoTen") != null) _hoten = dr.GetString("HoTen");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMTDNgoaiNgu" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMTDNgoaiNgu
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _maTDNgoaiNgu = DataProvider.Instance().InsertDMTDNgoaiNgu(_tenTDNgoaiNgu, _ghiChu, _maMay, _nguoiSD);
			// public abstract String InsertDMTDNgoaiNgu(String _tenTDNgoaiNgu, String _maMay, String _nguoiSD);
			// public override String InsertDMTDNgoaiNgu(String _tenTDNgoaiNgu, String _maMay, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenTDNgoaiNgu, _maMay,  _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMTDNgoaiNgu" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMTDNgoaiNgu
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMTDNgoaiNgu(_maTDNgoaiNgu, _tenTDNgoaiNgu,_ghiChu, _maMay, _nguoiSD ,_huy  );
				// public abstract void UpdateDMTDNgoaiNgu(String _maTDNgoaiNgu, String _tenTDNgoaiNgu, String _maMay, String _nguoiSD);
				// public override void UpdateDMTDNgoaiNgu(String _maTDNgoaiNgu, String _tenTDNgoaiNgu, String _maMay, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maTDNgoaiNgu, _tenTDNgoaiNgu, _maMay,  _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maTDNgoaiNgu));
		}

		/// <summary>
		/// Delete the <see cref="DMTDNgoaiNgu" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMTDNgoaiNgu
            DataProvider.Instance().DeleteDMTDNgoaiNgu(crit.MaMay, crit.NguoiSD, crit.maTDNgoaiNgu);
			// public abstract void DeleteDMTDNgoaiNgu(String _maTDNgoaiNgu);
			// public override void DeleteDMTDNgoaiNgu(String _maTDNgoaiNgu);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maTDNgoaiNgu);
			// }
		}

		#endregion
	}

}
