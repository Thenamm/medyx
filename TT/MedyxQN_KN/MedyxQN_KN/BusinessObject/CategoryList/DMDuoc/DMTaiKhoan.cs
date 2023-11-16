// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMTaiKhoan
// Kieu doi tuong  :	DMTaiKhoan
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	11/20/2008 11:44:11 AM
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
	/// This is a base generated class of <see cref="DMTaiKhoan" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMTaiKhoan : BusinessBase<DMTaiKhoan>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maTK = String.Empty;
        private String _ma = String.Empty;
		private String _tenTK = String.Empty;
		private String _maMay = String.Empty;
        private String _Ghichu = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private int _OrderNumber;
        private String _hoten = String.Empty;
		#endregion
		
		#region Business Properties and Methods
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
		public String MaTK
		{
			get 
			{
				CanReadProperty("MaTK", true);
				return _maTK;
			}
			set 
			{
				CanWriteProperty("MaTK", true);
				if (_maTK != value) 
				{
					_maTK = value;
					PropertyHasChanged("MaTK");
				}
			}
		}
        public String Ma
        {
            get
            {
                CanReadProperty("MaTK", true);
                return _ma;
            }
            set
            {
                //CanWriteProperty("MaTK", true);
                if (_ma != value)
                {
                    _ma = value;
                   // PropertyHasChanged("MaTK");
                }
            }
        }
		public String TenTK
		{
			get 
			{
				CanReadProperty("TenTK", true);
				return _tenTK;
			}
			set 
			{
				CanWriteProperty("TenTK", true);
				if (_tenTK != value) 
				{
					_tenTK = value;
					PropertyHasChanged("TenTK");
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
        public String Ghichu
        {
            get
            {
                CanReadProperty("Ghichu", true);
                return _Ghichu;
            }
            set
            {
                CanWriteProperty("Ghichu", true);
                if (_Ghichu != value)
                {
                    _Ghichu = value;
                    PropertyHasChanged("Ghichu");
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
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                }
            }
        }

		protected override Object GetIdValue()
		{
			return _ma;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMTaiKhoan" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMTaiKhoan NewDMTaiKhoan()
        {
            return new DMTaiKhoan();
        }
		public static DMTaiKhoan GetDMTaiKhoan(String ma)
		{
            return DataPortal.Fetch<DMTaiKhoan>(new Criteria(ma));
		}
		
		/// <summary>
		/// Marks the <see cref="DMTaiKhoan" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMTaiKhoan(String ma, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,ma));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMTaiKhoan()
		{	
			// Prevent direct creation
		}
        internal DMTaiKhoan(int ordernumber, string ma, string MaQG, string TenQG, string idmay, bool huy, SmartDate ngaySD, string NguoiSD, string ghichu, string hoten)
        {
            _OrderNumber = ordernumber;
            _maTK   = MaQG;
            _ma = ma;
            _tenTK  = TenQG;
            _maMay = idmay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = NguoiSD;
            _Ghichu = ghichu ;
            _hoten = hoten;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _ma;
			public String Ma 
			{
				get
				{
					return _ma;
				}
			}
			
			public Criteria(String ma)
			{
				_ma = ma;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_ma.Equals(c._ma)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _ma.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _ma;
            public String Ma
            {
                get
                {
                    return _ma;
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
            public OtherCriteria(String Mamay, String Nguoisd, String ma)
            {
                _ma = ma;
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
		/// Retrieve an existing <see cref="DMTaiKhoan" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMTaiKhoan(String _maTK);
			// public override IDataReader GetDMTaiKhoan(String _maTK)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maTK));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMTaiKhoan(crit.Ma)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMTaiKhoan" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaTK") != null) _maTK = dr.GetString("MaTK");
            if (dr.GetString("Ma") != null) _ma = dr.GetString("Ma");
			if (dr.GetString("TenTK") != null) _tenTK = dr.GetString("TenTK");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("HOTEN") != null) _hoten = dr.GetString("hoten");
            if (dr.GetString("Ghichu") != null) _Ghichu = dr.GetString("Ghichu");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMTaiKhoan" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMTaiKhoan
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			 DataProvider.Instance().InsertDMTaiKhoan(_maTK,_tenTK, _Ghichu, _maMay, _nguoiSD);
			// public abstract String InsertDMTaiKhoan(String _maTK, String _tenTK, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// public override String InsertDMTaiKhoan(String _maTK, String _tenTK, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maTK, _tenTK, _maMay, _huy, _ngaySD.DBValue, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMTaiKhoan" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMTaiKhoan
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMTaiKhoan(_ma,  _maTK, _tenTK, _Ghichu, _maMay, _nguoiSD , _huy );
				// public abstract void UpdateDMTaiKhoan(String _maTK, String _tenTK, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// public override void UpdateDMTaiKhoan(String _maTK, String _tenTK, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maTK, _tenTK, _maMay, _huy, _ngaySD.DBValue, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _ma));
		}

		/// <summary>
		/// Delete the <see cref="DMTaiKhoan" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMTaiKhoan
            DataProvider.Instance().DeleteDMTaiKhoan(crit.MaMay, crit.NguoiSD, crit.Ma);
			// public abstract void DeleteDMTaiKhoan(String _maTK);
			// public override void DeleteDMTaiKhoan(String _maTK);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maTK);
			// }
		}

		#endregion
	}

}
