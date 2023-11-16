// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMLDTVong
// Kieu doi tuong  :	DMLDTVong
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	12/11/2008 11:14:33 AM
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
	/// This is a base generated class of <see cref="DMLDTVong" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMLDTVong : BusinessBase<DMLDTVong>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maLDTVong = String.Empty;
		private String _tenLDTVong = String.Empty;
		private String _ghiChu = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String MaLDTVong
		{
			get 
			{
				CanReadProperty("MaLDTVong", true);
				return _maLDTVong;
			}
			set 
			{
				CanWriteProperty("MaLDTVong", true);
				if (_maLDTVong != value) 
				{
					_maLDTVong = value;
					PropertyHasChanged("MaLDTVong");
				}
			}
		}
		
		public String TenLDTVong
		{
			get 
			{
				CanReadProperty("TenLDTVong", true);
				return _tenLDTVong;
			}
			set 
			{
				CanWriteProperty("TenLDTVong", true);
				if (_tenLDTVong != value) 
				{
					_tenLDTVong = value;
					PropertyHasChanged("TenLDTVong");
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
			return _maLDTVong;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMLDTVong" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMLDTVong NewDMLDTVong()
        {
            //return new DMLDTVong();
            return DataPortal.Create<DMLDTVong>();
        }
		public static DMLDTVong GetDMLDTVong(String maLDTVong)
		{
			return DataPortal.Fetch<DMLDTVong>(new Criteria(maLDTVong));
		}
		
		/// <summary>
		/// Marks the <see cref="DMLDTVong" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMLDTVong(String maLDTVong, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maLDTVong));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMLDTVong()
		{	
			// Prevent direct creation
		}
        internal DMLDTVong(int ordernumber, string MaLDTVong, string TenLDTVong,string ghichu, string idmay, bool huy, SmartDate ngaySD, string NguoiSD,String hoten)
        {
            _OrderNumber = ordernumber;
            _maLDTVong = MaLDTVong ;
            _tenLDTVong  = TenLDTVong;
            _ghiChu = ghichu;
            _maMay = idmay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = NguoiSD;
            _hoten = hoten;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maLDTVong;
			public String MaLDTVong 
			{
				get
				{
					return _maLDTVong;
				}
			}
			
			public Criteria(String maLDTVong)
			{
				_maLDTVong = maLDTVong;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maLDTVong.Equals(c._maLDTVong)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maLDTVong.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maLDTVong;
            public String MaLDTVong
            {
                get
                {
                    return _maLDTVong;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maLDTVong)
            {
                _maLDTVong = maLDTVong;
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
		/// Retrieve an existing <see cref="DMLDTVong" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMLDTVong(String _maLDTVong);
			// public override IDataReader GetDMLDTVong(String _maLDTVong)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maLDTVong));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMLDTVong(crit.MaLDTVong)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMLDTVong" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaLDTVong") != null) _maLDTVong = dr.GetString("MaLDTVong");
			if (dr.GetString("TenLDTVong") != null) _tenLDTVong = dr.GetString("TenLDTVong");
			if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("HoTen") != null) _nguoiSD = dr.GetString("HoTen");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMLDTVong" /> Object to underlying database.
		/// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMLDTVong
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maLDTVong = DataProvider.Instance().InsertDMLDTVong(_tenLDTVong, _ghiChu, _maMay, _nguoiSD);
			// public abstract String InsertDMLDTVong(String _tenLDTVong, String _ghiChu, String _maMay,  String _nguoiSD);
			// public override String InsertDMLDTVong(String _tenLDTVong, String _ghiChu, String _maMay,  String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenLDTVong, _ghiChu, _maMay,  _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMLDTVong" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMLDTVong
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMLDTVong(_maLDTVong, _tenLDTVong, _ghiChu, _maMay, _nguoiSD , _huy);
				// public abstract void UpdateDMLDTVong(String _maLDTVong, String _tenLDTVong, String _ghiChu, String _maMay, String _nguoiSD);
				// public override void UpdateDMLDTVong(String _maLDTVong, String _tenLDTVong, String _ghiChu, String _maMay, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maLDTVong, _tenLDTVong, _ghiChu, _maMay, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maLDTVong));
		}

		/// <summary>
		/// Delete the <see cref="DMLDTVong" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMLDTVong
            DataProvider.Instance().DeleteDMLDTVong(crit.MaMay, crit.NguoiSD, crit.MaLDTVong);
			// public abstract void DeleteDMLDTVong(String _maLDTVong);
			// public override void DeleteDMLDTVong(String _maLDTVong);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maLDTVong);
			// }
		}

		#endregion
	}

}
