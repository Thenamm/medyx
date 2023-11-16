// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMBatThuong
// Kieu doi tuong  :	DMBatThuong
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	11/20/2008 2:19:14 PM
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
	/// This is a base generated class of <see cref="DMBatThuong" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMBatThuong : BusinessBase<DMBatThuong>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maBatThuong = String.Empty;
		private String _tenBatThuong = String.Empty;
		private Boolean _khongSD = false;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String MaBatThuong
		{
			get 
			{
				CanReadProperty("MaBatThuong", true);
				return _maBatThuong;
			}
			set 
			{
				CanWriteProperty("MaBatThuong", true);
				if (_maBatThuong != value) 
				{
					_maBatThuong = value;
					PropertyHasChanged("MaBatThuong");
				}
			}
		}
		
		public String TenBatThuong
		{
			get 
			{
				CanReadProperty("TenBatThuong", true);
				return _tenBatThuong;
			}
			set 
			{
				CanWriteProperty("TenBatThuong", true);
				if (_tenBatThuong != value) 
				{
					_tenBatThuong = value;
					PropertyHasChanged("TenBatThuong");
				}
			}
		}
		
		public Boolean KhongSD
		{
			get 
			{
				CanReadProperty("KhongSD", true);
				return _khongSD;
			}
			set 
			{
				CanWriteProperty("KhongSD", true);
				if (_khongSD != value) 
				{
					_khongSD = value;
					PropertyHasChanged("KhongSD");
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
		protected override Object GetIdValue()
		{
			return _maBatThuong;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMBatThuong" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMBatThuong NewDMBatThuong()
        {
            return new DMBatThuong();
        }
        public static DMBatThuong GetDMBatThuong(String maBatThuong)
		{
			return DataPortal.Fetch<DMBatThuong>(new Criteria(maBatThuong));
		}
		
		/// <summary>
		/// Marks the <see cref="DMBatThuong" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMBatThuong(String maBatThuong, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maBatThuong));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMBatThuong()
		{	
			// Prevent direct creation
		}
        internal DMBatThuong(int ordernumber, string MaQG, string TenQG,Boolean khongSD, string idmay, bool huy, SmartDate ngaySD, string NguoiSD)
        {
            _OrderNumber = ordernumber;
            _maBatThuong   = MaQG;
            _tenBatThuong  = TenQG;
            _khongSD = khongSD;
            _maMay = idmay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = NguoiSD;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maBatThuong;
			public String MaBatThuong 
			{
				get
				{
					return _maBatThuong;
				}
			}
			
			public Criteria(String maBatThuong)
			{
				_maBatThuong = maBatThuong;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBatThuong.Equals(c._maBatThuong)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBatThuong.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maBatThuong;
            public String MaBatThuong
            {
                get
                {
                    return _maBatThuong;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maBatThuong)
            {
                _maBatThuong = maBatThuong;
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
		/// Retrieve an existing <see cref="DMBatThuong" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMBatThuong(String _maBatThuong);
			// public override IDataReader GetDMBatThuong(String _maBatThuong)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBatThuong));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMBatThuong(crit.MaBatThuong)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMBatThuong" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaBatThuong") != null) _maBatThuong = dr.GetString("MaBatThuong");
			if (dr.GetString("TenBatThuong") != null) _tenBatThuong = dr.GetString("TenBatThuong");
			if (dr.GetBoolean("KhongSD") != null) _khongSD = dr.GetBoolean("KhongSD");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMBatThuong" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMBatThuong
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maBatThuong = DataProvider.Instance().InsertDMBatThuong(_tenBatThuong, _khongSD, _maMay, _nguoiSD);
			// public abstract String InsertDMBatThuong(String _maBatThuong, String _tenBatThuong, Boolean _khongSD, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// public override String InsertDMBatThuong(String _maBatThuong, String _tenBatThuong, Boolean _khongSD, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBatThuong, _tenBatThuong, _khongSD, _maMay, _huy, _ngaySD.DBValue, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMBatThuong" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMBatThuong
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMBatThuong(_maBatThuong, _tenBatThuong, _khongSD, _maMay,  _nguoiSD);
				// public abstract void UpdateDMBatThuong(String _maBatThuong, String _tenBatThuong, Boolean _khongSD, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// public override void UpdateDMBatThuong(String _maBatThuong, String _tenBatThuong, Boolean _khongSD, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBatThuong, _tenBatThuong, _khongSD, _maMay, _huy, _ngaySD.DBValue, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maBatThuong));
		}

		/// <summary>
		/// Delete the <see cref="DMBatThuong" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMBatThuong
            DataProvider.Instance().DeleteDMBatThuong(crit.MaMay, crit.NguoiSD, crit.MaBatThuong);
			// public abstract void DeleteDMBatThuong(String _maBatThuong);
			// public override void DeleteDMBatThuong(String _maBatThuong);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBatThuong);
			// }
		}

		#endregion
	}

}
