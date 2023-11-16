// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMMayXN
// Kieu doi tuong  :	DMMayXN
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	11/5/2008 10:55:12 AM
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
	/// This is a base generated class of <see cref="DMMayXN" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMMayXN : BusinessBase<DMMayXN>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _tenmayxn = String.Empty;
		private String _tendmmayxn = String.Empty;
		private String _maKhoa = String.Empty;
        private String _tenKhoa = String.Empty;
		private String _ip = String.Empty;
		private String _tenmayxnSD = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
        public String TenKhoa
        {
            get
            {
                CanReadProperty("TenKhoa", true);
                return _tenKhoa;
            }
            set
            {
                CanWriteProperty("TenKhoa", true);
                if (_tenKhoa != value)
                {
                    _tenKhoa = value;
                    PropertyHasChanged("TenKhoa");
                }
            }
        }
		public String tenmayxn
        {
			get 
			{
				CanReadProperty("tenmayxn", true);
				return _tenmayxn;
			}
			set 
			{
				CanWriteProperty("tenmayxn", true);
				if (_tenmayxn != value) 
				{
					_tenmayxn = value;
					PropertyHasChanged("tenmayxn");
				}
			}
		}
		
		public String tendmmayxn
        {
			get 
			{
				CanReadProperty("tendmmayxn", true);
				return _tendmmayxn;
			}
			set 
			{
				CanWriteProperty("tendmmayxn", true);
				if (_tendmmayxn != value) 
				{
					_tendmmayxn = value;
					PropertyHasChanged("tendmmayxn");
				}
			}
		}
		
		public String MaKhoa
		{
			get 
			{
				CanReadProperty("MaKhoa", true);
				return _maKhoa;
			}
			set 
			{
				CanWriteProperty("MaKhoa", true);
				if (_maKhoa != value) 
				{
					_maKhoa = value;
					PropertyHasChanged("MaKhoa");
				}
			}
		}
		
		public String IP
		{
			get 
			{
				CanReadProperty("IP", true);
				return _ip;
			}
			set 
			{
				CanWriteProperty("IP", true);
				if (_ip != value) 
				{
					_ip = value;
					PropertyHasChanged("IP");
				}
			}
		}
		
		public String MaMaySD
		{
			get 
			{
				CanReadProperty("MaMaySD", true);
				return _tenmayxnSD;
			}
			set 
			{
				CanWriteProperty("MaMaySD", true);
				if (_tenmayxnSD != value) 
				{
					_tenmayxnSD = value;
					PropertyHasChanged("MaMaySD");
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
			return _tenmayxn;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMMayXN" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        public static DMMayXN NewDMMayXN()
        {
            //return DataPortal.Create<DMVungLanhTho>();
            return new DMMayXN();
        }
		public static DMMayXN GetDMMayXN(String maMay)
		{
            return DataPortal.Fetch<DMMayXN>(new Criteria(maMay));
		}
		
		/// <summary>
		/// Marks the <see cref="DMMayXN" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMMayXN(String maMay, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maMay));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMMayXN()
		{	
			// Prevent direct creation
		}
        internal DMMayXN(int ordernumber, string MaQG, string TenQG, string makhoa, string tenkhoa, string ip,
            string idmay, bool huy, SmartDate ngaySD, string NguoiSD)
        {
            _OrderNumber = ordernumber;
            _tenmayxn  = MaQG;
            _tendmmayxn = TenQG;
            _maKhoa = makhoa;
            _tenKhoa = tenkhoa;
            _ip = ip;
            _tenmayxnSD = idmay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = NguoiSD;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _tenmayxn;
			public String MaMay 
			{
				get
				{
					return _tenmayxn;
				}
			}
			
			public Criteria(String maMay)
			{
				_tenmayxn = maMay;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_tenmayxn.Equals(c._tenmayxn)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _tenmayxn.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _tenmayxn;
            public String MaMay
            {
                get
                {
                    return _tenmayxn;
                }
            }

            private String _tenmayxnSD;
            public String MaMaySD
            {
                get
                {
                    return _tenmayxnSD;
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
            public OtherCriteria(String MamaySD, String Nguoisd, String maMay)
            {
                _tenmayxn = maMay;
                _tenmayxnSD = MamaySD;
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
		/// Retrieve an existing <see cref="DMMayXN" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMMayXN(String _tenmayxn);
			// public override IDataReader GetDMMayXN(String _tenmayxn)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenmayxn));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMMayXN(crit.MaMay)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMMayXN" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaMay") != null) _tenmayxn = dr.GetString("MaMay");
			if (dr.GetString("TenMay") != null) _tendmmayxn = dr.GetString("TenMay");
            if (dr.GetString("TenKhoa") != null) _tenKhoa = dr.GetString("TenKhoa");
			if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
			if (dr.GetString("IP") != null) _ip = dr.GetString("IP");
			if (dr.GetString("MaMaySD") != null) _tenmayxnSD = dr.GetString("MaMaySD");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMMayXN" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMMayXN
			// Copy & paste ham duoi day vao file DataProvider.cs
          
              
			_tenmayxn = DataProvider.Instance().InsertDMMayXN(_tendmmayxn, _maKhoa, _ip, _tenmayxnSD, _nguoiSD);
			// public abstract String InsertDMMayXN(String _tenmayxn, String _tendmmayxn, String _maKhoa, String _ip, String _tenmayxnSD, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// public override String InsertDMMayXN(String _tenmayxn, String _tendmmayxn, String _maKhoa, String _ip, String _tenmayxnSD, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenmayxn, _tendmmayxn, _maKhoa, _ip, _tenmayxnSD, _huy, _ngaySD.DBValue, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMMayXN" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMMayXN
			if (IsDirty){
              
                  
				DataProvider.Instance().UpdateDMMayXN(_tenmayxn, _tendmmayxn, _maKhoa, _ip, _tenmayxnSD, _nguoiSD);
				// public abstract void UpdateDMMayXN(String _tenmayxn, String _tendmmayxn, String _maKhoa, String _ip, String _tenmayxnSD, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// public override void UpdateDMMayXN(String _tenmayxn, String _tendmmayxn, String _maKhoa, String _ip, String _tenmayxnSD, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenmayxn, _tendmmayxn, _maKhoa, _ip, _tenmayxnSD, _huy, _ngaySD.DBValue, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
			DataPortal_Delete(new OtherCriteria(_tenmayxnSD,_nguoiSD,_tenmayxn));
		}

		/// <summary>
		/// Delete the <see cref="DMMayXN" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMMayXN
			DataProvider.Instance().DeleteDMMayXN(crit.MaMaySD,crit.NguoiSD, crit.MaMay );
			// public abstract void DeleteDMMayXN(String _tenmayxn);
			// public override void DeleteDMMayXN(String _tenmayxn);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenmayxn);
			// }
		}

		#endregion
	}

}
