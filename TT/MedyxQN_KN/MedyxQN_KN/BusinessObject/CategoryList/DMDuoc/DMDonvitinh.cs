// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMDonvitinh
// Kieu doi tuong  :	DMDonvitinh
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	10/24/2008 4:05:10 PM
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
	/// This is a base generated class of <see cref="DMDonvitinh" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMDonvitinh : BusinessBase<DMDonvitinh>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _MaDVT = String.Empty;
		private String _tenDVT = String.Empty;
		private String _ghichu = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private String _tenta = String.Empty;
		#endregion
		
		#region Business Properties and Methods
		
		public String MaDVT
		{
			get 
			{
				CanReadProperty("MaDVT", true);
				return _MaDVT;
			}
			set 
			{
				CanWriteProperty("MaDVT", true);
				if (_MaDVT != value) 
				{
					_MaDVT = value;
					PropertyHasChanged("MaDVT");
				}
			}
		}
		
		public String tenDVT
		{
			get 
			{
				CanReadProperty("tenDVT", true);
				return _tenDVT;
			}
			set 
			{
				CanWriteProperty("tenDVT", true);
				if (_tenDVT != value) 
				{
					_tenDVT = value;
					PropertyHasChanged("tenDVT");
				}
			}
		}
        public String tenta
        {
            get
            {
                CanReadProperty("tenta", true);
                return _tenta;
            }
            set
            {
                CanWriteProperty("tenta", true);
                if (_tenta != value)
                {
                    _tenta = value;
                    PropertyHasChanged("tenta");
                }
            }
        }
		public String Ghichu
		{
			get 
			{
				CanReadProperty("Ghichu", true);
				return _ghichu;
			}
			set 
			{
				CanWriteProperty("Ghichu", true);
				if (_ghichu != value) 
				{
					_ghichu = value;
					PropertyHasChanged("Ghichu");
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
		
		protected override object GetIdValue()
		{
			return _MaDVT;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMDonvitinh" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        public static DMDonvitinh NewDMDonvitinh()
		{
            //return DataPortal.Create<DMDonvitinh>();
            return new DMDonvitinh();
		}
		public static DMDonvitinh GetDMDonvitinh(String MaDVT)
		{
			return DataPortal.Fetch<DMDonvitinh>(new Criteria(MaDVT));
		}
		
		/// <summary>
		/// Marks the <see cref="DMDonvitinh" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
		public static void DeleteDMDonvitinh(String MaDVT,string mamay,string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,MaDVT));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMDonvitinh()
		{	
			// Prevent direct creation
		}
		
		#endregion

		#region Criteria

        //[Serializable()]
        protected class Criteria
        {
            private String _MaDVT;

            public String MaDVT
            {
                get
                {
                    return _MaDVT;
                }
            }

            public Criteria(String MaDVT)
            {
                _MaDVT = MaDVT;

            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_MaDVT.Equals(c._MaDVT))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _MaDVT.ToString()).GetHashCode();
            }
        }

        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaDVT;
            public String MaDVT
            {
                get
                {
                    return _MaDVT;
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
            public OtherCriteria(String Mamay, String Nguoisd,String MaDVT)
            {
                _MaDVT = MaDVT;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
            }

            //public override bool Equals(object obj)
            //{
            //    if (obj is Criteria)
            //    {
            //        Criteria c = (Criteria)obj;
            //        if (!_MaDVT.Equals(c._MaDVT))
            //            return false;
            //        return true;
            //    }
            //    return false;
            //}

            //public override int GetHashCode()
            //{
            //    return string.Concat("Criteria", _MaDVT.ToString()).GetHashCode();
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
		/// Retrieve an existing <see cref="DMDonvitinh" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMDonvitinh(String _MaDVT);
			// public override IDataReader GetDMDonvitinh(String _MaDVT)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaDVT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMDonvitinh(crit.MaDVT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMDonvitinh" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaDVT") != null) _MaDVT = dr.GetString("MaDVT");
			if (dr.GetString("tenDVT") != null) _tenDVT = dr.GetString("tenDVT");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("tenta") != null) _tenta = dr.GetString("tenta");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMDonvitinh" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDonvitinh
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_MaDVT = DataProvider.Instance().InsertDMDonvitinh(_tenDVT,_ghichu , _maMay, _nguoiSD ,_tenta);
			// public abstract String InsertDMDonvitinh(String _MaDVT, String _tenDVT, String _ghichu, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// public override String InsertDMDonvitinh(String _MaDVT, String _tenDVT, String _ghichu, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaDVT, _tenDVT, _ghichu, _maMay, _huy, _ngaySD.DBValue, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMDonvitinh" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDonvitinh
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMDonvitinh(_MaDVT, _tenDVT, _ghichu, _maMay, _nguoiSD ,_tenta, _huy);
				// public abstract void UpdateDMDonvitinh(String _MaDVT, String _tenDVT, String _ghichu, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// public override void UpdateDMDonvitinh(String _MaDVT, String _tenDVT, String _ghichu, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaDVT, _tenDVT, _ghichu, _maMay, _huy, _ngaySD.DBValue, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD,_MaDVT));
		}

		/// <summary>
		/// Delete the <see cref="DMDonvitinh" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDonvitinh
			DataProvider.Instance().DeleteDMDonvitinh(crit.MaMay, crit.NguoiSD, crit.MaDVT  );
			// public abstract void DeleteDMDonvitinh(String _MaDVT);
			// public override void DeleteDMDonvitinh(String _MaDVT);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaDVT);
			// }
		}

		#endregion
	}

}
