// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	HCTonDau
// Kieu doi tuong  :	HCTonDau
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

namespace HTC.Business.HoaChat
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="HCTonDau" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class HCTonDau : BusinessBase<HCTonDau>
	{
		#region Business Methods
		
		#region State Fields
		
		private SmartDate _ngayTon = new SmartDate(true);
		private String _makho = String.Empty;
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
		
		public String Makho
		{
			get 
			{
				CanReadProperty("Makho", true);
				return _makho;
			}
			set 
			{
				CanWriteProperty("Makho", true);
				if (_makho != value) 
				{
					_makho = value;
					PropertyHasChanged("Makho");
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
			return _makho;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="HCTonDau" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static HCTonDau NewHCTonDau()
        {
            return DataPortal.Create<HCTonDau>();
        }
		public static HCTonDau GetHCTonDau(String makho)
		{
			return DataPortal.Fetch<HCTonDau>(new Criteria(makho));
		}
		
		/// <summary>
		/// Marks the <see cref="HCTonDau" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteHCTonDau(String makho)
        //{
        //    DataPortal.Delete(new Criteria(makho));
        //}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal HCTonDau( 
           )
		{	
			// Prevent direct creation
		}
        internal HCTonDau( SmartDate ngayTon ,
		     String makho ,
		     SmartDate ngaySD ,
		     String nguoiSD ,
		     String maMay )
        {
            _ngayTon = ngayTon;
            _makho = makho;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD;
            _maMay = maMay;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _makho;
			public String Makho 
			{
				get
				{
					return _makho;
				}
			}
			
			public Criteria(String makho)
			{
				_makho = makho;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_makho.Equals(c._makho)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _makho.ToString()).GetHashCode();
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
		/// Retrieve an existing <see cref="HCTonDau" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetHCTonDau(String _makho);
			// public override IDataReader GetHCTonDau(String _makho)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spHCTonDau_GET", _makho));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetHCTonDau(crit.Makho)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="HCTonDau" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetSmartDate("NgayTon", true) != null) _ngayTon = dr.GetSmartDate("NgayTon", true);
			if (dr.GetString("Makho") != null) _makho = dr.GetString("Makho");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
		}
		
		/// <summary>
		/// Insert the new <see cref="HCTonDau" /> Object to underlying database.
		/// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertHCTonDau
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_makho = DataProvider.Instance().InsertHCTonDau(_ngayTon, _makho, _nguoiSD , _maMay);
			// public abstract String InsertHCTonDau(SmartDate _ngayTon, String _makho, String _nguoiSD, String _maMay);
			// public override String InsertHCTonDau(SmartDate _ngayTon, String _makho, String _nguoiSD, String _maMay);
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spHCTonDau_CREATE", _ngayTon.DBValue, _makho, _nguoiSD , _maMay));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="HCTonDau" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateHCTonDau
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateHCTonDau(_ngayTon, _makho, _nguoiSD , _maMay);
				// public abstract void UpdateHCTonDau(SmartDate _ngayTon, String _makho,String _nguoiSD, String _maMay);
				// public override void UpdateHCTonDau(SmartDate _ngayTon, String _makho,  String _nguoiSD, String _maMay);
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spHCTonDau_UPDATE", _ngayTon.DBValue, _makho, _nguoiSD , _maMay);
				// }				
			}
		}
        //protected override void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new Criteria(_makho));
        //}

        ///// <summary>
        ///// Delete the <see cref="HCTonDau" />.
        ///// </summary>
        //protected void DataPortal_Delete(Criteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateHCTonDau
        //    DataProvider.Instance().DeleteHCTonDau(crit.Makho);
        //    // public abstract void DeleteHCTonDau(String _makho);
        //    // public override void DeleteHCTonDau(String _makho);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _makho);
        //    // }
        //}

		#endregion
	}

}
