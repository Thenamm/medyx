// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	quocgia
// Kieu doi tuong  :	DMQuocGia
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	10/24/2008 11:01:11 AM
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
using HTC.Business;

namespace HTC.Business.CategoryList
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="DMQuocGia" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMQuocGia : BusinessBase<DMQuocGia>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maQG = String.Empty;
		private String _tenQG = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
		
		#endregion
		
		#region Business Properties and Methods
		
		public String MaQG
		{
			get 
			{
				CanReadProperty("MaQG", true);
				return _maQG;
			}
			set 
			{
				CanWriteProperty("MaQG", true);
				if (_maQG != value) 
				{
					_maQG = value;
					PropertyHasChanged("MaQG");
				}
			}
		}
		
		public String TenQG
		{
			get 
			{
				CanReadProperty("TenQG", true);
				return _tenQG;
			}
			set 
			{
				CanWriteProperty("TenQG", true);
				if (_tenQG != value) 
				{
					_tenQG = value;
					PropertyHasChanged("TenQG");
				}
			}
		}

        public String MaMay
		{
			get 
			{
				CanReadProperty("IDMay", true);
				return _maMay;
			}
			set 
			{
				CanWriteProperty("IDMay", true);
				if (_maMay != value) 
				{
					_maMay = value;
					PropertyHasChanged("IDMay");
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
		
		protected override object GetIdValue()
		{
			return _maQG;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMQuocGia" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        public static DMQuocGia NewDMQuocGia()
        {
            //return DataPortal.Create<DMQuocGia>();
            return new DMQuocGia(); 
        }
        public static DMQuocGia GetDMQuocGia(String maQG)
		{
            return DataPortal.Fetch<DMQuocGia>(new Criteria(maQG));
		}
		
		/// <summary>
		/// Marks the <see cref="DMQuocGia" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMQuocGia(String maQG, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maQG));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMQuocGia()
		{	
			// Prevent direct creation
		}
		
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maQG;
			public String MaQG 
			{
				get
				{
					return _maQG;
				}
			}
			
			public Criteria(String maQG)
			{
				_maQG = maQG;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maQG.Equals(c._maQG)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maQG.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maQG;
            public String MaQG
            {
                get
                {
                    return _maQG;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maQG)
            {
                _maQG = maQG;
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
		/// Retrieve an existing <see cref="DMQuocGia" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMQuocGia(String _maQG);
			// public override IDataReader GetDMQuocGia(String _maQG)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maQG));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMQuocGia(crit.MaQG)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMQuocGia" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaQG") != null) _maQG = dr.GetString("MaQG");
			if (dr.GetString("TenQG") != null) _tenQG = dr.GetString("TenQG");

			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");

            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");

			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMQuocGia" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMQuocGia
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maQG = DataProvider.Instance().InsertDMQuocGia(_tenQG, _maMay, _nguoiSD);
			// public abstract String InsertDMQuocGia(String _maQG, String _tenQG, String _iDMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// public override String InsertDMQuocGia(String _maQG, String _tenQG, String _iDMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maQG, _tenQG, _iDMay, _huy, _ngaySD.DBValue, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMQuocGia" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMQuocGia
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMQuocGia(_maQG, _tenQG, _maMay,_nguoiSD);
				// public abstract void UpdateDMQuocGia(String _maQG, String _tenQG, String _iDMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// public override void UpdateDMQuocGia(String _maQG, String _tenQG, String _iDMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maQG, _tenQG, _iDMay, _huy, _ngaySD.DBValue, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
			DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD,_maQG ));
		}

		/// <summary>
		/// Delete the <see cref="DMQuocGia" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMQuocGia
			DataProvider.Instance().DeleteDMQuocGia(crit.MaMay, crit.NguoiSD, crit.MaQG );
			// public abstract void DeleteDMQuocGia(String _maQG);
			// public override void DeleteDMQuocGia(String _maQG);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maQG);
			// }
		}

		#endregion
	}

}
