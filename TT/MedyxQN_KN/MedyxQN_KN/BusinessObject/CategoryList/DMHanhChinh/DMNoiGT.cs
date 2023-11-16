// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMNoiGT
// Kieu doi tuong  :	DMNoiGT
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	11/20/2008 2:34:50 PM
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
	/// This is a base generated class of <see cref="DMNoiGT" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMNoiGT : BusinessBase<DMNoiGT>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maNoiGT = String.Empty;
		private String _tenNoiGT = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String MaNoiGT
		{
			get 
			{
				CanReadProperty("MaNoiGT", true);
				return _maNoiGT;
			}
			set 
			{
				CanWriteProperty("MaNoiGT", true);
				if (_maNoiGT != value) 
				{
					_maNoiGT = value;
					PropertyHasChanged("MaNoiGT");
				}
			}
		}
		
		public String TenNoiGT
		{
			get 
			{
				CanReadProperty("TenNoiGT", true);
				return _tenNoiGT;
			}
			set 
			{
				CanWriteProperty("TenNoiGT", true);
				if (_tenNoiGT != value) 
				{
					_tenNoiGT = value;
					PropertyHasChanged("TenNoiGT");
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
			return _maNoiGT;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMNoiGT" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMNoiGT NewDMNoiGT()
        {
            return new DMNoiGT();
        }
		public static DMNoiGT GetDMNoiGT(String maNoiGT)
		{
			return DataPortal.Fetch<DMNoiGT>(new Criteria(maNoiGT));
		}
		
		/// <summary>
		/// Marks the <see cref="DMNoiGT" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMNoiGT(String maNoiGT, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maNoiGT));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMNoiGT()
		{	
			// Prevent direct creation
		}
        internal DMNoiGT(int ordernumber, string MaQG, string TenQG, string idmay, bool huy, SmartDate ngaySD, string NguoiSD)
        {
            _OrderNumber = ordernumber;
            _maNoiGT   = MaQG;
            _tenNoiGT  = TenQG;
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
			private String _maNoiGT;
			public String MaNoiGT 
			{
				get
				{
					return _maNoiGT;
				}
			}
			
			public Criteria(String maNoiGT)
			{
				_maNoiGT = maNoiGT;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maNoiGT.Equals(c._maNoiGT)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maNoiGT.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maNoiGT;
            public String MaNoiGT
            {
                get
                {
                    return _maNoiGT;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maNoiGT)
            {
                _maNoiGT = maNoiGT;
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
		/// Retrieve an existing <see cref="DMNoiGT" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMNoiGT(String _maNoiGT);
			// public override IDataReader GetDMNoiGT(String _maNoiGT)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNoiGT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMNoiGT(crit.MaNoiGT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMNoiGT" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaNoiGT") != null) _maNoiGT = dr.GetString("MaNoiGT");
			if (dr.GetString("TenNoiGT") != null) _tenNoiGT = dr.GetString("TenNoiGT");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMNoiGT" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMNoiGT
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maNoiGT = DataProvider.Instance().InsertDMNoiGT(_tenNoiGT, _maMay,  _nguoiSD);
			// public abstract String InsertDMNoiGT(String _tenNoiGT, String _maMay, String _nguoiSD);
			// public override String InsertDMNoiGT(String _tenNoiGT, String _maMay, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenNoiGT, _maMay,  _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMNoiGT" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMNoiGT
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMNoiGT(_maNoiGT, _tenNoiGT, _maMay, _nguoiSD);
				// public abstract void UpdateDMNoiGT(String _maNoiGT, String _tenNoiGT, String _maMay, String _nguoiSD);
				// public override void UpdateDMNoiGT(String _maNoiGT, String _tenNoiGT, String _maMay, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNoiGT, _tenNoiGT, _maMay,  _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maNoiGT));
		}

		/// <summary>
		/// Delete the <see cref="DMNoiGT" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMNoiGT
            DataProvider.Instance().DeleteDMNoiGT(crit.MaMay, crit.NguoiSD, crit.MaNoiGT);
			// public abstract void DeleteDMNoiGT(String _maNoiGT);
			// public override void DeleteDMNoiGT(String _maNoiGT);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNoiGT);
			// }
		}

		#endregion
	}

}
