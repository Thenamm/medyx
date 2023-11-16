// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMViTriST
// Kieu doi tuong  :	DMViTriST
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
	/// This is a base generated class of <see cref="DMViTriST" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMViTriST : BusinessBase<DMViTriST>
	{
		#region Business Methods
		
		#region State Fields
        private String _maQL = String.Empty;
        private String _ghichu = String.Empty;
		private String _maViTri = String.Empty;
		private String _tenViTri = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String MaViTri
		{
			get 
			{
				CanReadProperty("MaViTri", true);
				return _maViTri;
			}
			set 
			{
				CanWriteProperty("MaViTri", true);
				if (_maViTri != value) 
				{
					_maViTri = value;
					PropertyHasChanged("MaViTri");
				}
			}
		}
        public String MaQL
        {
            get
            {
                CanReadProperty("MaQL", true);
                return _maQL;
            }
            set
            {
                CanWriteProperty("MaQL", true);
                if (_maQL != value)
                {
                    _maQL = value;
                    PropertyHasChanged("MaQL");
                }
            }
        }
		
		public String TenViTri
		{
			get 
			{
				CanReadProperty("TenViTri", true);
				return _tenViTri;
			}
			set 
			{
				CanWriteProperty("TenViTri", true);
				if (_tenViTri != value) 
				{
					_tenViTri = value;
					PropertyHasChanged("TenViTri");
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
			return _maViTri;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMViTriST" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMViTriST NewDMViTriST()
        {
            return new DMViTriST();
        }
		public static DMViTriST GetDMViTriST(String maViTri)
		{
			return DataPortal.Fetch<DMViTriST>(new Criteria(maViTri));
		}
		
		/// <summary>
		/// Marks the <see cref="DMViTriST" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMViTriST(String maViTri,string mamay,string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy,   maViTri));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMViTriST()
		{	
			// Prevent direct creation
		}
        internal DMViTriST(int ordernumber, string MaQG, string TenQG, string idmay, bool huy, SmartDate ngaySD, string NguoiSD, string maql, string ghichu)
        {
            _OrderNumber = ordernumber;
            _maViTri   = MaQG;
            _tenViTri  = TenQG;
            _maMay = idmay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = NguoiSD;
            _maQL = maql;
            _ghichu = ghichu;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maViTri;
			public String MaViTri 
			{
				get
				{
					return _maViTri;
				}
			}
			
			public Criteria(String maViTri)
			{
				_maViTri = maViTri;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maViTri.Equals(c._maViTri)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maViTri.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maViTri;
            public String MaViTri
            {
                get
                {
                    return _maViTri;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maViTri)
            {
                _maViTri = maViTri;
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
		/// Retrieve an existing <see cref="DMViTriST" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMViTriST(String _maViTri);
			// public override IDataReader GetDMViTriST(String _maViTri)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maViTri));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMViTriST(crit.MaViTri)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMViTriST" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
            if (dr.GetString("MaQL") != null) _maQL = dr.GetString("MaQL");
            if (dr.GetString("ghichu") != null) _ghichu = dr.GetString("ghichu");
			
			if (dr.GetString("MaViTri") != null) _maViTri = dr.GetString("MaViTri");
			if (dr.GetString("TenViTri") != null) _tenViTri = dr.GetString("TenViTri");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMViTriST" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMViTriST
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maViTri = DataProvider.Instance().InsertDMViTriST(_tenViTri, _maMay, _nguoiSD,_maQL,_ghichu );
			// public abstract String InsertDMViTriST(String _maViTri, String _tenViTri, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// public override String InsertDMViTriST(String _maViTri, String _tenViTri, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maViTri, _tenViTri, _maMay, _huy, _ngaySD.DBValue, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMViTriST" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMViTriST
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateDMViTriST(_maViTri, _tenViTri, _maMay, _nguoiSD, _maQL, _ghichu);
				// public abstract void UpdateDMViTriST(String _maViTri, String _tenViTri, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// public override void UpdateDMViTriST(String _maViTri, String _tenViTri, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maViTri, _tenViTri, _maMay, _huy, _ngaySD.DBValue, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maViTri));
		}

		/// <summary>
		/// Delete the <see cref="DMViTriST" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMViTriST
            DataProvider.Instance().DeleteDMViTriST(crit.MaMay, crit.NguoiSD, crit.MaViTri);
			// public abstract void DeleteDMViTriST(String _maViTri);
			// public override void DeleteDMViTriST(String _maViTri);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maViTri);
			// }
		}

		#endregion
	}

}
