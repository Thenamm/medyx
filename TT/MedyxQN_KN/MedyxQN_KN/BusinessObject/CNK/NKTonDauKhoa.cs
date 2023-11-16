// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	NKTonDauKhoa
// Kieu doi tuong  :	NKTonDauKhoa
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	4/14/2009 4:36:02 PM
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

namespace HTC.Business.CNK
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="NKTonDauKhoa" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class NKTonDauKhoa : BusinessBase<NKTonDauKhoa>
	{
		#region Business Methods
		
		#region State Fields
		
		private SmartDate _ngayTon = new SmartDate(true);
		private String _makhoa = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _maMay = String.Empty;
		
		#endregion
		
		#region Business Properties and Methods
		
		public string NgayTon
		{
			get 
			{
				CanReadProperty("NgayTon", true);
				return _ngayTon.Text;
			}
			set 
			{
				CanWriteProperty("NgayTon", true);
				if (_ngayTon.Text != value) 
				{
					_ngayTon.Text = value;
					PropertyHasChanged("NgayTon");
				}
			}
		}
		
		public String Makhoa
		{
			get 
			{
				//CanReadProperty("Makho", true);
				return _makhoa;
			}
			set 
			{
				//CanWriteProperty("Makho", true);
				if (_makhoa != value) 
				{
					_makhoa = value;
					//PropertyHasChanged("Makho");
				}
			}
		}
		
		public string NgaySD
		{
			get 
			{
				CanReadProperty("NgaySD", true);
				return _ngaySD.Text;
			}
			set 
			{
				CanWriteProperty("NgaySD", true);
				if (_ngaySD.Text != value) 
				{
					_ngaySD.Text = value;
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
		
		protected override Object GetIdValue()
		{
			return _makhoa;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="NKTonDauKhoa" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static NKTonDauKhoa NewNKTonDauKhoa()
        {
            return DataPortal.Create<NKTonDauKhoa>();
        }
		public static NKTonDauKhoa GetNKTonDauKhoa(String makhoa)
		{
			return DataPortal.Fetch<NKTonDauKhoa>(new Criteria(makhoa));
		}
		
		/// <summary>
		/// Marks the <see cref="NKTonDauKhoa" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteNKTonDauKhoa(String makho)
        //{
        //    DataPortal.Delete(new Criteria(makho));
        //}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal NKTonDauKhoa( 
           )
		{	
			// Prevent direct creation
		}
        internal NKTonDauKhoa( SmartDate ngayTon ,
		     String makhoa ,
		     SmartDate ngaySD ,
		     String nguoiSD ,
		     String maMay )
        {
            _ngayTon = ngayTon;
            _makhoa = makhoa;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD;
            _maMay = maMay;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _makhoa;
			public String Makhoa 
			{
				get
				{
					return _makhoa;
				}
			}
			
			public Criteria(String makhoa)
			{
				_makhoa = makhoa;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_makhoa.Equals(c._makhoa)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _makhoa.ToString()).GetHashCode();
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
		/// Retrieve an existing <see cref="NKTonDauKhoa" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetNKTonDauKhoa(String _makhoa);
			// public override IDataReader GetNKTonDauKhoa(String _makhoa)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spNKTonDauKhoa_GET", _makhoa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetNKTonDauKhoa(crit.Makhoa)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="NKTonDauKhoa" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetSmartDate("NgayTon", true) != null) _ngayTon = dr.GetSmartDate("NgayTon", true);
			if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
		}
		
		/// <summary>
		/// Insert the new <see cref="NKTonDauKhoa" /> Object to underlying database.
		/// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertNKTonDauKhoa
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_makhoa = DataProvider.Instance().InsertNKTonDauKhoa(_ngayTon, _makhoa, _nguoiSD, _maMay);
			// public abstract String InsertNKTonDauKhoa(SmartDate _ngayTon, String _makhoa, String _nguoiSD, String _maMay);
			// public override String InsertNKTonDauKhoa(SmartDate _ngayTon, String _makhoa, String _nguoiSD, String _maMay);
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spNKTonDauKhoa_CREATE", _ngayTon.DBValue, _makhoa, _nguoiSD, _maMay));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="NKTonDauKhoa" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateNKTonDauKhoa
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateNKTonDauKhoa(_ngayTon, _makhoa, _nguoiSD, _maMay);
				// public abstract void UpdateNKTonDauKhoa(SmartDate _ngayTon, String _makhoa,String _nguoiSD, String _maMay);
				// public override void UpdateNKTonDauKhoa(SmartDate _ngayTon, String _makhoa,  String _nguoiSD, String _maMay);
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spNKTonDauKhoa_UPDATE", _ngayTon.DBValue, _makhoa,  _nguoiSD, _maMay);
				// }				
			}
		}
        //protected override void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new Criteria(_makhoa));
        //}

        ///// <summary>
        ///// Delete the <see cref="NKTonDauKhoa" />.
        ///// </summary>
        //protected void DataPortal_Delete(Criteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateNKTonDauKhoa
        //    DataProvider.Instance().DeleteNKTonDauKhoa(crit.Makho);
        //    // public abstract void DeleteNKTonDauKhoa(String _makhoa);
        //    // public override void DeleteNKTonDauKhoa(String _makhoa);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _makhoa);
        //    // }
        //}

		#endregion
	}

}
