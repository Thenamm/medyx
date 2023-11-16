// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMPhanLoai
// Kieu doi tuong  :	DMPhanLoai
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
	/// This is a base generated class of <see cref="DMPhanLoai" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMPhanLoai : BusinessBase<DMPhanLoai>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maPL = String.Empty;
		private String _tenPL = String.Empty;
		private String _ghiChu = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String MaPL
		{
			get 
			{
				CanReadProperty("MaPL", true);
				return _maPL;
			}
			set 
			{
				CanWriteProperty("MaPL", true);
				if (_maPL != value) 
				{
					_maPL = value;
					PropertyHasChanged("MaPL");
				}
			}
		}
		
		public String TenPL
		{
			get 
			{
				CanReadProperty("TenPL", true);
				return _tenPL;
			}
			set 
			{
				CanWriteProperty("TenPL", true);
				if (_tenPL != value) 
				{
					_tenPL = value;
					PropertyHasChanged("TenPL");
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
			return _maPL;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMPhanLoai" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMPhanLoai NewDMPhanLoai()
        {
            //return new DMPhanLoai();
            return DataPortal.Create<DMPhanLoai>();
        }
		public static DMPhanLoai GetDMPhanLoai(String maPL)
		{
			return DataPortal.Fetch<DMPhanLoai>(new Criteria(maPL));
		}
		
		/// <summary>
		/// Marks the <see cref="DMPhanLoai" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMPhanLoai(String maPL, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maPL));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMPhanLoai()
		{	
			// Prevent direct creation
		}
        internal DMPhanLoai(int ordernumber, string MaPL, string TenPL,string ghichu, string idmay, bool huy, SmartDate ngaySD, string NguoiSD,String hoten)
        {
            _OrderNumber = ordernumber;
            _maPL = MaPL ;
            _tenPL  = TenPL;
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
			private String _maPL;
			public String MaPL 
			{
				get
				{
					return _maPL;
				}
			}
			
			public Criteria(String maPL)
			{
				_maPL = maPL;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maPL.Equals(c._maPL)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maPL.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maPL;
            public String MaPL
            {
                get
                {
                    return _maPL;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maPL)
            {
                _maPL = maPL;
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
		/// Retrieve an existing <see cref="DMPhanLoai" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMPhanLoai(String _maPL);
			// public override IDataReader GetDMPhanLoai(String _maPL)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maPL));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMPhanLoai(crit.MaPL)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMPhanLoai" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaPL") != null) _maPL = dr.GetString("MaPL");
			if (dr.GetString("TenPL") != null) _tenPL = dr.GetString("TenPL");
			if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMPhanLoai" /> Object to underlying database.
		/// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMPhanLoai
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maPL = DataProvider.Instance().InsertDMPhanLoai(_tenPL, _ghiChu, _maMay, _nguoiSD);
			// public abstract String InsertDMPhanLoai(String _tenPL, String _ghiChu, String _maMay,  String _nguoiSD);
			// public override String InsertDMPhanLoai(String _tenPL, String _ghiChu, String _maMay,  String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenPL, _ghiChu, _maMay,  _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMPhanLoai" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMPhanLoai
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMPhanLoai(_maPL, _tenPL, _ghiChu, _maMay, _nguoiSD , _huy);
				// public abstract void UpdateDMPhanLoai(String _maPL, String _tenPL, String _ghiChu, String _maMay, String _nguoiSD);
				// public override void UpdateDMPhanLoai(String _maPL, String _tenPL, String _ghiChu, String _maMay, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maPL, _tenPL, _ghiChu, _maMay, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maPL));
		}

		/// <summary>
		/// Delete the <see cref="DMPhanLoai" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMPhanLoai
            DataProvider.Instance().DeleteDMPhanLoai(crit.MaMay, crit.NguoiSD, crit.MaPL);
			// public abstract void DeleteDMPhanLoai(String _maPL);
			// public override void DeleteDMPhanLoai(String _maPL);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maPL);
			// }
		}

		#endregion
	}

}
