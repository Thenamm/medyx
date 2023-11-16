// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMGPBenh
// Kieu doi tuong  :	DMGPBenh
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
	/// This is a base generated class of <see cref="DMGPBenh" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMGPBenh : BusinessBase<DMGPBenh>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maGPBenh = String.Empty;
		private String _tenGPBenh = String.Empty;
		private String _ghiChu = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String MaGPBenh
		{
			get 
			{
				CanReadProperty("MaGPBenh", true);
				return _maGPBenh;
			}
			set 
			{
				CanWriteProperty("MaGPBenh", true);
				if (_maGPBenh != value) 
				{
					_maGPBenh = value;
					PropertyHasChanged("MaGPBenh");
				}
			}
		}
		
		public String TenGPBenh
		{
			get 
			{
				CanReadProperty("TenGPBenh", true);
				return _tenGPBenh;
			}
			set 
			{
				CanWriteProperty("TenGPBenh", true);
				if (_tenGPBenh != value) 
				{
					_tenGPBenh = value;
					PropertyHasChanged("TenGPBenh");
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
			return _maGPBenh;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMGPBenh" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMGPBenh NewDMGPBenh()
        {
            //return new DMGPBenh();
            return DataPortal.Create<DMGPBenh>();
        }
		public static DMGPBenh GetDMGPBenh(String maGPBenh)
		{
			return DataPortal.Fetch<DMGPBenh>(new Criteria(maGPBenh));
		}
		
		/// <summary>
		/// Marks the <see cref="DMGPBenh" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMGPBenh(String maGPBenh, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maGPBenh));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMGPBenh()
		{	
			// Prevent direct creation
		}
        internal DMGPBenh(int ordernumber, string MaGPBenh, string TenGPBenh,string ghichu, string idmay, bool huy, SmartDate ngaySD, string NguoiSD,String hoten)
        {
            _OrderNumber = ordernumber;
            _maGPBenh = MaGPBenh ;
            _tenGPBenh  = TenGPBenh;
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
			private String _maGPBenh;
			public String MaGPBenh 
			{
				get
				{
					return _maGPBenh;
				}
			}
			
			public Criteria(String maGPBenh)
			{
				_maGPBenh = maGPBenh;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maGPBenh.Equals(c._maGPBenh)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maGPBenh.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maGPBenh;
            public String MaGPBenh
            {
                get
                {
                    return _maGPBenh;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maGPBenh)
            {
                _maGPBenh = maGPBenh;
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
		/// Retrieve an existing <see cref="DMGPBenh" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMGPBenh(String _maGPBenh);
			// public override IDataReader GetDMGPBenh(String _maGPBenh)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maGPBenh));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMGPBenh(crit.MaGPBenh)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMGPBenh" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaGPBenh") != null) _maGPBenh = dr.GetString("MaGPBenh");
			if (dr.GetString("TenGPBenh") != null) _tenGPBenh = dr.GetString("TenGPBenh");
			if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMGPBenh" /> Object to underlying database.
		/// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMGPBenh
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maGPBenh = DataProvider.Instance().InsertDMGPBenh(_tenGPBenh, _ghiChu, _maMay, _nguoiSD);
			// public abstract String InsertDMGPBenh(String _tenGPBenh, String _ghiChu, String _maMay,  String _nguoiSD);
			// public override String InsertDMGPBenh(String _tenGPBenh, String _ghiChu, String _maMay,  String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenGPBenh, _ghiChu, _maMay,  _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMGPBenh" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMGPBenh
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMGPBenh(_maGPBenh, _tenGPBenh, _ghiChu, _maMay, _nguoiSD);
				// public abstract void UpdateDMGPBenh(String _maGPBenh, String _tenGPBenh, String _ghiChu, String _maMay, String _nguoiSD);
				// public override void UpdateDMGPBenh(String _maGPBenh, String _tenGPBenh, String _ghiChu, String _maMay, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maGPBenh, _tenGPBenh, _ghiChu, _maMay, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maGPBenh));
		}

		/// <summary>
		/// Delete the <see cref="DMGPBenh" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMGPBenh
            DataProvider.Instance().DeleteDMGPBenh(crit.MaMay, crit.NguoiSD, crit.MaGPBenh);
			// public abstract void DeleteDMGPBenh(String _maGPBenh);
			// public override void DeleteDMGPBenh(String _maGPBenh);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maGPBenh);
			// }
		}

		#endregion
	}

}
