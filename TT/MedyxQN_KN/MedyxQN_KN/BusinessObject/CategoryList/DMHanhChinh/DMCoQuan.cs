// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMCoQuan
// Kieu doi tuong  :	DMCoQuan
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
	/// This is a base generated class of <see cref="DMCoQuan" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMCoQuan : BusinessBase<DMCoQuan>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maCQ = String.Empty;
		private String _tenCQ = String.Empty;
		private Boolean _khongSD = false;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String MaCQ
		{
			get 
			{
				CanReadProperty("MaCQ", true);
				return _maCQ;
			}
			set 
			{
				CanWriteProperty("MaCQ", true);
				if (_maCQ != value) 
				{
					_maCQ = value;
					PropertyHasChanged("MaCQ");
				}
			}
		}
		
		public String TenCQ
		{
			get 
			{
				CanReadProperty("TenCQ", true);
				return _tenCQ;
			}
			set 
			{
				CanWriteProperty("TenCQ", true);
				if (_tenCQ != value) 
				{
					_tenCQ = value;
					PropertyHasChanged("TenCQ");
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
			return _maCQ;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMCoQuan" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMCoQuan NewDMCoQuan()
        {
            return new DMCoQuan();
        }
        public static DMCoQuan GetDMCoQuan(String maCQ)
		{
			return DataPortal.Fetch<DMCoQuan>(new Criteria(maCQ));
		}
		
		/// <summary>
		/// Marks the <see cref="DMCoQuan" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMCoQuan(String maCQ, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maCQ));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMCoQuan()
		{	
			// Prevent direct creation
		}
        internal DMCoQuan(int ordernumber, string MaQG, string TenQG,Boolean khongSD, string idmay, bool huy, SmartDate ngaySD, string NguoiSD)
        {
            _OrderNumber = ordernumber;
            _maCQ   = MaQG;
            _tenCQ  = TenQG;
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
			private String _maCQ;
			public String MaCQ 
			{
				get
				{
					return _maCQ;
				}
			}
			
			public Criteria(String maCQ)
			{
				_maCQ = maCQ;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maCQ.Equals(c._maCQ)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maCQ.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maCQ;
            public String MaCQ
            {
                get
                {
                    return _maCQ;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maCQ)
            {
                _maCQ = maCQ;
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
		/// Retrieve an existing <see cref="DMCoQuan" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMCoQuan(String _maCQ);
			// public override IDataReader GetDMCoQuan(String _maCQ)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maCQ));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMCoQuan(crit.MaCQ)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMCoQuan" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaCQ") != null) _maCQ = dr.GetString("MaCQ");
			if (dr.GetString("TenCQ") != null) _tenCQ = dr.GetString("TenCQ");
			if (dr.GetBoolean("KhongSD") != null) _khongSD = dr.GetBoolean("KhongSD");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMCoQuan" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMCoQuan
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maCQ = DataProvider.Instance().InsertDMCoQuan(_tenCQ, _khongSD, _maMay, _nguoiSD);
			// public abstract String InsertDMCoQuan(String _maCQ, String _tenCQ, Boolean _khongSD, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// public override String InsertDMCoQuan(String _maCQ, String _tenCQ, Boolean _khongSD, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maCQ, _tenCQ, _khongSD, _maMay, _huy, _ngaySD.DBValue, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMCoQuan" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMCoQuan
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMCoQuan(_maCQ, _tenCQ, _khongSD, _maMay,  _nguoiSD);
				// public abstract void UpdateDMCoQuan(String _maCQ, String _tenCQ, Boolean _khongSD, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// public override void UpdateDMCoQuan(String _maCQ, String _tenCQ, Boolean _khongSD, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maCQ, _tenCQ, _khongSD, _maMay, _huy, _ngaySD.DBValue, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maCQ));
		}

		/// <summary>
		/// Delete the <see cref="DMCoQuan" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMCoQuan
            DataProvider.Instance().DeleteDMCoQuan(crit.MaMay, crit.NguoiSD, crit.MaCQ);
			// public abstract void DeleteDMCoQuan(String _maCQ);
			// public override void DeleteDMCoQuan(String _maCQ);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maCQ);
			// }
		}

		#endregion
	}

}
