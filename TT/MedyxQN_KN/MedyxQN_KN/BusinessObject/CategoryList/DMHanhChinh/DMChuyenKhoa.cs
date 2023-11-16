// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMChuyenKhoa
// Kieu doi tuong  :	DMChuyenKhoa
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	11/14/2008 2:28:49 PM
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
	/// This is a base generated class of <see cref="DMChuyenKhoa" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMChuyenKhoa : BusinessBase<DMChuyenKhoa>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maCK = String.Empty;
		private String _tenCK = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String MaCK
		{
			get 
			{
				CanReadProperty("MaCK", true);
				return _maCK;
			}
			set 
			{
				CanWriteProperty("MaCK", true);
				if (_maCK != value) 
				{
					_maCK = value;
					PropertyHasChanged("MaCK");
				}
			}
		}
		
		public String TenCK
		{
			get 
			{
				CanReadProperty("TenCK", true);
				return _tenCK;
			}
			set 
			{
				CanWriteProperty("TenCK", true);
				if (_tenCK != value) 
				{
					_tenCK = value;
					PropertyHasChanged("TenCK");
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
			return _maCK;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMChuyenKhoa" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMChuyenKhoa NewDMChuyenKhoa()
        {
            return new DMChuyenKhoa();
        }
		public static DMChuyenKhoa GetDMChuyenKhoa(String maCK)
		{
			return DataPortal.Fetch<DMChuyenKhoa>(new Criteria(maCK));
		}
		
		/// <summary>
		/// Marks the <see cref="DMChuyenKhoa" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMChuyenKhoa(String maCK, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maCK));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMChuyenKhoa()
		{	
			// Prevent direct creation
		}
        internal DMChuyenKhoa(int ordernumber, String maNT, String tenNT, String maMay,  Boolean huy, SmartDate ngaySD, String nguoiSD)
        {
            _OrderNumber = ordernumber;
            _maCK  = maNT;
            _tenCK = tenNT;
            _maMay = maMay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD;

        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maCK;
			public String MaCK 
			{
				get
				{
					return _maCK;
				}
			}
			
			public Criteria(String maCK)
			{
				_maCK = maCK;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maCK.Equals(c._maCK)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maCK.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maCK;
            public String maCK
            {
                get
                {
                    return _maCK;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maCK)
            {
                _maCK = maCK;
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
		/// Retrieve an existing <see cref="DMChuyenKhoa" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMChuyenKhoa(String _maCK);
			// public override IDataReader GetDMChuyenKhoa(String _maCK)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maCK));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMChuyenKhoa(crit.MaCK)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMChuyenKhoa" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaCK") != null) _maCK = dr.GetString("MaCK");
			if (dr.GetString("TenCK") != null) _tenCK = dr.GetString("TenCK");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMChuyenKhoa" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMChuyenKhoa
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maCK = DataProvider.Instance().InsertDMChuyenKhoa(_tenCK, _maMay, _nguoiSD);
			// public abstract String InsertDMChuyenKhoa(String _maCK, String _tenCK, String _maMay, Boolean _huy, Byte _lOAI,SmartDate _ngaySD, String _nguoiSD);
			// public override String InsertDMChuyenKhoa(String _maCK, String _tenCK, String _maMay, Boolean _huy, Byte _lOAI,SmartDate _ngaySD, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maCK, _tenCK, _maMay, _huy, _lOAI, _ngaySD.DBValue, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMChuyenKhoa" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMChuyenKhoa
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMChuyenKhoa(_maCK, _tenCK, _maMay, _nguoiSD);
				// public abstract void UpdateDMChuyenKhoa(String _maCK, String _tenCK, String _maMay, Boolean _huy, Byte _lOAI,SmartDate _ngaySD, String _nguoiSD);
				// public override void UpdateDMChuyenKhoa(String _maCK, String _tenCK, String _maMay, Boolean _huy, Byte _lOAI,SmartDate _ngaySD, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maCK, _tenCK, _maMay, _huy, _lOAI, _ngaySD.DBValue, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
			DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD ,  _maCK));
		}

		/// <summary>
		/// Delete the <see cref="DMChuyenKhoa" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMChuyenKhoa
			DataProvider.Instance().DeleteDMChuyenKhoa(crit.MaMay, crit.NguoiSD,   crit.maCK );
			// public abstract void DeleteDMChuyenKhoa(String _maCK);
			// public override void DeleteDMChuyenKhoa(String _maCK);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maCK);
			// }
		}

		#endregion
	}

}
