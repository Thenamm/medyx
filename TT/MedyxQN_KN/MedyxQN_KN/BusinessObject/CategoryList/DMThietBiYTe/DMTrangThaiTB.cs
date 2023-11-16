// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMTrangThaiTB
// Kieu doi tuong  :	DMTrangThaiTB
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
	/// This is a base generated class of <see cref="DMTrangThaiTB" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMTrangThaiTB : BusinessBase<DMTrangThaiTB>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maTrangThaiTB = String.Empty;
		private String _tenTrangThaiTB = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private String _ghiChu = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String maTrangThaiTB
		{
			get 
			{
				CanReadProperty("maTrangThaiTB", true);
				return _maTrangThaiTB;
			}
			set 
			{
				CanWriteProperty("maTrangThaiTB", true);
				if (_maTrangThaiTB != value) 
				{
					_maTrangThaiTB = value;
					PropertyHasChanged("maTrangThaiTB");
				}
			}
		}

        public String TenTrangThaiTB
		{
			get 
			{
                CanReadProperty("TenTrangThaiTB", true);
				return _tenTrangThaiTB;
			}
			set 
			{
                CanWriteProperty("TenTrangThaiTB", true);
				if (_tenTrangThaiTB != value) 
				{
					_tenTrangThaiTB = value;
                    PropertyHasChanged("TenTrangThaiTB");
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
			return _maTrangThaiTB;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMTrangThaiTB" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMTrangThaiTB NewDMTrangThaiTB()
        {
            return new DMTrangThaiTB();
        }
		public static DMTrangThaiTB GetDMTrangThaiTB(String maTrangThaiTB)
		{
			return DataPortal.Fetch<DMTrangThaiTB>(new Criteria(maTrangThaiTB));
		}
		
		/// <summary>
		/// Marks the <see cref="DMTrangThaiTB" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMTrangThaiTB(String maTrangThaiTB, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maTrangThaiTB));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMTrangThaiTB()
		{	
			// Prevent direct creation
		}
        internal DMTrangThaiTB(int ordernumber, string MaQG, string TenQG, string idmay, bool huy, SmartDate ngaySD, string NguoiSD, string ghichu, string hoten)
        {
            _OrderNumber = ordernumber;
            _maTrangThaiTB   = MaQG;
            _tenTrangThaiTB  = TenQG;
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
			private String _maTrangThaiTB;
			public String maTrangThaiTB 
			{
				get
				{
					return _maTrangThaiTB;
				}
			}
			
			public Criteria(String maTrangThaiTB)
			{
				_maTrangThaiTB = maTrangThaiTB;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maTrangThaiTB.Equals(c._maTrangThaiTB)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maTrangThaiTB.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maTrangThaiTB;
            public String maTrangThaiTB
            {
                get
                {
                    return _maTrangThaiTB;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maTrangThaiTB)
            {
                _maTrangThaiTB = maTrangThaiTB;
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
		/// Retrieve an existing <see cref="DMTrangThaiTB" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMTrangThaiTB(String _maTrangThaiTB);
			// public override IDataReader GetDMTrangThaiTB(String _maTrangThaiTB)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maTrangThaiTB));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMTrangThaiTB(crit.maTrangThaiTB)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMTrangThaiTB" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaTrangThaiTB") != null) _maTrangThaiTB = dr.GetString("maTrangThaiTB");
            if (dr.GetString("TenTrangThaiTB") != null) _tenTrangThaiTB = dr.GetString("TenTrangThaiTB");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetString("HoTen") != null) _hoten = dr.GetString("HoTen");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMTrangThaiTB" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMTrangThaiTB
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _maTrangThaiTB = DataProvider.Instance().InsertDMTrangThaiTB(_tenTrangThaiTB, _ghiChu, _maMay, _nguoiSD);
			// public abstract String InsertDMTrangThaiTB(String _tenTrangThaiTB, String _maMay, String _nguoiSD);
			// public override String InsertDMTrangThaiTB(String _tenTrangThaiTB, String _maMay, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenTrangThaiTB, _maMay,  _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMTrangThaiTB" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMTrangThaiTB
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMTrangThaiTB(_maTrangThaiTB, _tenTrangThaiTB,_ghiChu, _maMay, _nguoiSD ,_huy  );
				// public abstract void UpdateDMTrangThaiTB(String _maTrangThaiTB, String _tenTrangThaiTB, String _maMay, String _nguoiSD);
				// public override void UpdateDMTrangThaiTB(String _maTrangThaiTB, String _tenTrangThaiTB, String _maMay, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maTrangThaiTB, _tenTrangThaiTB, _maMay,  _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maTrangThaiTB));
		}

		/// <summary>
		/// Delete the <see cref="DMTrangThaiTB" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMTrangThaiTB
            DataProvider.Instance().DeleteDMTrangThaiTB(crit.MaMay, crit.NguoiSD, crit.maTrangThaiTB);
			// public abstract void DeleteDMTrangThaiTB(String _maTrangThaiTB);
			// public override void DeleteDMTrangThaiTB(String _maTrangThaiTB);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maTrangThaiTB);
			// }
		}

		#endregion
	}

}
