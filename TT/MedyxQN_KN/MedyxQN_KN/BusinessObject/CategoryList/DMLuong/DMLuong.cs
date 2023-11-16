// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMLuong
// Kieu doi tuong  :	DMLuong
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	7/30/2008 2:32:50 PM
// Nguoi tao       :	Shadow
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
	/// This is a base generated class of <see cref="DMLuong" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMLuong : BusinessBase<DMLuong>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maLuong = String.Empty;
		private String _tenLuong = String.Empty;
        private Decimal  _MucLuong = 0;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private String _ghiChu = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String maLuong
		{
			get 
			{
				CanReadProperty("maLuong", true);
				return _maLuong;
			}
			set 
			{
				CanWriteProperty("maLuong", true);
				if (_maLuong != value) 
				{
					_maLuong = value;
					PropertyHasChanged("maLuong");
				}
			}
		}

        public String TenLuong
		{
			get 
			{
                CanReadProperty("TenLuong", true);
				return _tenLuong;
			}
			set 
			{
                CanWriteProperty("TenLuong", true);
				if (_tenLuong != value) 
				{
					_tenLuong = value;
                    PropertyHasChanged("TenLuong");
				}
			}
		}
        public string   MucLuong
        {
            get
            {
                CanReadProperty("MucLuong", true);
                return _MucLuong.ToString("###,###");
            }
            set
            {
                CanWriteProperty("MucLuong", true);
                if (_MucLuong.ToString() != value)
                {
                    _MucLuong = decimal.Parse(value);
                    PropertyHasChanged("MucLuong");
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
			return _maLuong;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMLuong" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMLuong NewDMLuong()
        {
            return new DMLuong();
        }
		public static DMLuong GetDMLuong(String maLuong)
		{
			return DataPortal.Fetch<DMLuong>(new Criteria(maLuong));
		}
		
		/// <summary>
		/// Marks the <see cref="DMLuong" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMLuong(String maLuong, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maLuong));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMLuong()
		{	
			// Prevent direct creation
		}
        internal DMLuong(int ordernumber, string MaQG, string TenQG,decimal MucLuong, string idmay, bool huy, SmartDate ngaySD, string NguoiSD, string ghichu, string hoten)
        {
            _OrderNumber = ordernumber;
            _maLuong   = MaQG;
            _tenLuong  = TenQG;
            _MucLuong = MucLuong;
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
			private String _maLuong;
			public String maLuong 
			{
				get
				{
					return _maLuong;
				}
			}
			
			public Criteria(String maLuong)
			{
				_maLuong = maLuong;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maLuong.Equals(c._maLuong)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maLuong.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maLuong;
            public String maLuong
            {
                get
                {
                    return _maLuong;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maLuong)
            {
                _maLuong = maLuong;
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
		/// Retrieve an existing <see cref="DMLuong" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMLuong(String _maLuong);
			// public override IDataReader GetDMLuong(String _maLuong)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maLuong));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMLuong(crit.maLuong)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMLuong" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("maLuong") != null) _maLuong = dr.GetString("maLuong");
            if (dr.GetString("TenLuong") != null) _tenLuong = dr.GetString("TenLuong");
            if (dr.GetDecimal("MucLuong") != null) _MucLuong = dr.GetDecimal("MucLuong");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetString("HoTen") != null) _hoten = dr.GetString("HoTen");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMLuong" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMLuong
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _maLuong = DataProvider.Instance().InsertDMLuong(_tenLuong, _ghiChu, _MucLuong, _maMay, _nguoiSD);
			// public abstract String InsertDMLuong(String _tenLuong, String _maMay, String _nguoiSD);
			// public override String InsertDMLuong(String _tenLuong, String _maMay, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenLuong, _maMay,  _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMLuong" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMLuong
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateDMLuong(_maLuong, _tenLuong, _ghiChu, _MucLuong, _maMay, _nguoiSD , _huy);
				// public abstract void UpdateDMLuong(String _maLuong, String _tenLuong, String _maMay, String _nguoiSD);
				// public override void UpdateDMLuong(String _maLuong, String _tenLuong, String _maMay, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maLuong, _tenLuong, _maMay,  _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maLuong));
		}

		/// <summary>
		/// Delete the <see cref="DMLuong" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMLuong
            DataProvider.Instance().DeleteDMLuong(crit.MaMay, crit.NguoiSD, crit.maLuong);
			// public abstract void DeleteDMLuong(String _maLuong);
			// public override void DeleteDMLuong(String _maLuong);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maLuong);
			// }
		}

		#endregion
	}

}
