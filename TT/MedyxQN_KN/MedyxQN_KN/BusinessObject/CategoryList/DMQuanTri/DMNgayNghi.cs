// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMNgayNghi
// Kieu doi tuong  :	DMNgayNghi
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
	/// This is a base generated class of <see cref="DMNgayNghi" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMNgayNghi : BusinessBase<DMNgayNghi>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maNgayNghi = String.Empty;
		private String _tenNgayNghi = String.Empty;
		private String _ghichu = String.Empty;
		private String _maMaySD = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
   
		public String maNgayNghi
		{
			get 
			{
				CanReadProperty("maNgayNghi", true);
				return _maNgayNghi;
			}
			set 
			{
				CanWriteProperty("maNgayNghi", true);
				if (_maNgayNghi != value) 
				{
					_maNgayNghi = value;
					PropertyHasChanged("maNgayNghi");
				}
			}
		}
		
		public String tenNgayNghi
		{
			get 
			{
				CanReadProperty("tenNgayNghi", true);
				return _tenNgayNghi;
			}
			set 
			{
				CanWriteProperty("tenNgayNghi", true);
				if (_tenNgayNghi != value) 
				{
					_tenNgayNghi = value;
					PropertyHasChanged("tenNgayNghi");
				}
			}
		}
		
		
		public String ghichu
		{
			get 
			{
				CanReadProperty("ghichu", true);
				return _ghichu;
			}
			set 
			{
				CanWriteProperty("ghichu", true);
				if (_ghichu != value) 
				{
					_ghichu = value;
					PropertyHasChanged("ghichu");
				}
			}
		}
		
		public String maMaySD
		{
			get 
			{
				CanReadProperty("maMaySD", true);
				return _maMaySD;
			}
			set 
			{
				CanWriteProperty("maMaySD", true);
				if (_maMaySD != value) 
				{
					_maMaySD = value;
					PropertyHasChanged("maMaySD");
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
			return _maNgayNghi;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMNgayNghi" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        public static DMNgayNghi NewDMNgayNghi()
        {
            //return DataPortal.Create<DMVungLanhTho>();
            return new DMNgayNghi();
        }
		public static DMNgayNghi GetDMNgayNghi(String maNgayNghi)
		{
            return DataPortal.Fetch<DMNgayNghi>(new Criteria(maNgayNghi));
		}
		
		/// <summary>
		/// Marks the <see cref="DMNgayNghi" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMNgayNghi(String mamaysd, string maNgayNghi, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamaysd, nguoihuy, maNgayNghi));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMNgayNghi()
		{	
			// Prevent direct creation
		}
        internal DMNgayNghi(int ordernumber, string MaQG, string TenQG,  string ghichu,
            string idmay, bool huy, SmartDate ngaySD, string NguoiSD)
        {
            _OrderNumber = ordernumber;
            _maNgayNghi  = MaQG;
            _tenNgayNghi = TenQG;
            _ghichu = ghichu;
            _maMaySD = idmay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = NguoiSD;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maNgayNghi;
			public String maNgayNghi 
			{
				get
				{
					return _maNgayNghi;
				}
			}
			
			public Criteria(String maNgayNghi)
			{
				_maNgayNghi = maNgayNghi;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maNgayNghi.Equals(c._maNgayNghi)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maNgayNghi.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maNgayNghi;
            public String maNgayNghi
            {
                get
                {
                    return _maNgayNghi;
                }
            }

            private String _maMaySD;
            public String maMaySD
            {
                get
                {
                    return _maMaySD;
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
            public OtherCriteria(String maMaySD, String Nguoisd, String maNgayNghi)
            {
                _maNgayNghi = maNgayNghi;
                _maMaySD = maMaySD;
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
		/// Retrieve an existing <see cref="DMNgayNghi" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMNgayNghi(String _maNgayNghi);
			// public override IDataReader GetDMNgayNghi(String _maNgayNghi)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNgayNghi));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMNgayNghi(crit.maNgayNghi)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMNgayNghi" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("maNgayNghi") != null) _maNgayNghi = dr.GetString("maNgayNghi");
			if (dr.GetString("tenNgayNghi") != null) _tenNgayNghi = dr.GetString("tenNgayNghi");
         	if (dr.GetString("ghichu") != null) _ghichu = dr.GetString("ghichu");
			if (dr.GetString("maMaySD") != null) _maMaySD = dr.GetString("maMaySD");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMNgayNghi" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMNgayNghi
			// Copy & paste ham duoi day vao file DataProvider.cs
          
              
			_maNgayNghi = DataProvider.Instance().InsertDMNgayNghi(_tenNgayNghi,_ghichu, _maMaySD, _nguoiSD);
			// public abstract String InsertDMNgayNghi(String _maNgayNghi, String _tenNgayNghi, String _maKhoa, String _ghichu, String _maMaySD, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// public override String InsertDMNgayNghi(String _maNgayNghi, String _tenNgayNghi, String _maKhoa, String _ghichu, String _maMaySD, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNgayNghi, _tenNgayNghi, _maKhoa, _ghichu, _maMaySD, _huy, _ngaySD.DBValue, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMNgayNghi" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMNgayNghi
			if (IsDirty){
              
                  
				DataProvider.Instance().UpdateDMNgayNghi(_maNgayNghi, _tenNgayNghi, _ghichu, _maMaySD, _nguoiSD);
				// public abstract void UpdateDMNgayNghi(String _maNgayNghi, String _tenNgayNghi, String _maKhoa, String _ghichu, String _maMaySD, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// public override void UpdateDMNgayNghi(String _maNgayNghi, String _tenNgayNghi, String _maKhoa, String _ghichu, String _maMaySD, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNgayNghi, _tenNgayNghi, _maKhoa, _ghichu, _maMaySD, _huy, _ngaySD.DBValue, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
			DataPortal_Delete(new OtherCriteria(_maMaySD,_nguoiSD,_maNgayNghi));
		}

		/// <summary>
		/// Delete the <see cref="DMNgayNghi" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMNgayNghi
			DataProvider.Instance().DeleteDMNgayNghi(crit.maMaySD,crit.NguoiSD, crit.maNgayNghi );
			// public abstract void DeleteDMNgayNghi(String _maNgayNghi);
			// public override void DeleteDMNgayNghi(String _maNgayNghi);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNgayNghi);
			// }
		}

		#endregion
	}

}
