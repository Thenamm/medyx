// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMTinh
// Kieu doi tuong  :	DMTinh
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	11/5/2008 11:27:37 AM
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
	/// This is a base generated class of <see cref="DMTinh" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMTinh : BusinessBase<DMTinh>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maTinh = String.Empty;
		private String _maQU = String.Empty;
		private String _maVungLT = DMVungLanhThoListcb.DefaultPosition()  ;
		private String _tenTinh = String.Empty;
        private String _tenVungLT = String.Empty;
		private String _maBHYT = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String MaTinh
		{
			get 
			{
				CanReadProperty("MaTinh", true);
				return _maTinh;
			}
			set 
			{
				CanWriteProperty("MaTinh", true);
				if (_maTinh != value) 
				{
					_maTinh = value;
					PropertyHasChanged("MaTinh");
				}
			}
		}
		
		public String MaQU
		{
			get 
			{
				CanReadProperty("MaQU", true);
				return _maQU;
			}
			set 
			{
				CanWriteProperty("MaQU", true);
				if (_maQU != value) 
				{
					_maQU = value;
					PropertyHasChanged("MaQU");
				}
			}
		}
		
		public string maVungLT
		{
			get 
			{
				CanReadProperty("maVungLT", true);
				return _maVungLT;
			}
			set 
			{
				CanWriteProperty("maVungLT", true);
				if (_maVungLT != value) 
				{
					_maVungLT = value;
					PropertyHasChanged("maVungLT");
				}
			}
		}
		
		public String TenTinh
		{
			get 
			{
				CanReadProperty("TenTinh", true);
				return _tenTinh;
			}
			set 
			{
				CanWriteProperty("TenTinh", true);
				if (_tenTinh != value) 
				{
					_tenTinh = value;
					PropertyHasChanged("TenTinh");
				}
			}
		}
        public String TenVungLT
        {
            get
            {
                CanReadProperty("TenVungLT", true);
                return _tenVungLT;
            }
            set
            {
                CanWriteProperty("TenVungLT", true);
                if (_tenVungLT != value)
                {
                    _tenVungLT = value;
                    PropertyHasChanged("TenmaVungLT");
                }
            }
        }
		public String MaBHYT
		{
			get 
			{
				CanReadProperty("MaBHYT", true);
				return _maBHYT;
			}
			set 
			{
				CanWriteProperty("MaBHYT", true);
				if (_maBHYT != value) 
				{
					_maBHYT = value;
					PropertyHasChanged("MaBHYT");
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
			return _maTinh;
		}
		
		#endregion
		#endregion
		
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMTinh" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMTinh NewDMTinh()
        {
            return new DMTinh();
        }
		public static DMTinh GetDMTinh(String maTinh)
		{
			return DataPortal.Fetch<DMTinh>(new Criteria(maTinh));
		}
		
		/// <summary>
		/// Marks the <see cref="DMTinh" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMTinh(String maTinh, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maTinh));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMTinh()
		{	
			// Prevent direct creation
		}

        internal DMTinh(int ordernumber, String matinh, String maQU, string maVungLT, String Tentinh, string maBHYT, String maMay, Boolean huy, SmartDate ngaySD, String nguoiSD, String hoten, String tenvunglt)
        {
            _OrderNumber = ordernumber;
            _maTinh = matinh ;
            _maQU = maQU ;
            _maVungLT = maVungLT ;
            _tenTinh = Tentinh ;
            _maBHYT = maBHYT  ;   
            _maMay = maMay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD;
            _hoten = hoten;
            _tenVungLT = tenvunglt;

        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maTinh;
			public String MaTinh 
			{
				get
				{
					return _maTinh;
				}
			}
			
			public Criteria(String maTinh)
			{
				_maTinh = maTinh;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maTinh.Equals(c._maTinh)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maTinh.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maTinh;
            public String MaTinh
            {
                get
                {
                    return _maTinh;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maTinh)
            {
                _maTinh = maTinh;
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
		/// Retrieve an existing <see cref="DMTinh" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMTinh(String _maTinh);
			// public override IDataReader GetDMTinh(String _maTinh)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maTinh));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMTinh(crit.MaTinh)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMTinh" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaTinh") != null) _maTinh = dr.GetString("MaTinh");
			if (dr.GetString("MaQU") != null) _maQU = dr.GetString("MaQU");
			if (dr.GetString("maVungLT") != null) _maVungLT = dr.GetString("maVungLT");
			if (dr.GetString("TenTinh") != null) _tenTinh = dr.GetString("TenTinh");
            if (dr.GetString("TenVungLT") != null) _tenVungLT = dr.GetString("TenVungLT");
			if (dr.GetString("MaBHYT") != null) _maBHYT = dr.GetString("MaBHYT");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("hoten") != null) _hoten = dr.GetString("hoten");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMTinh" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMTinh
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maTinh = DataProvider.Instance().InsertDMTinh(_maQU, _maVungLT, _tenTinh, _maBHYT, _maMay, _nguoiSD);
			// public abstract String InsertDMTinh(String _maTinh, String _maQU, String _maVungLT, String _tenTinh, String _maBHYT, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// public override String InsertDMTinh(String _maTinh, String _maQU, String _maVungLT, String _tenTinh, String _maBHYT, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maTinh, _maQU, _maVungLT, _tenTinh, _maBHYT, _maMay, _huy, _ngaySD.DBValue, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMTinh" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMTinh
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMTinh(_maTinh, _maQU, _maVungLT, _tenTinh, _maBHYT, _maMay, _nguoiSD);
				// public abstract void UpdateDMTinh(String _maTinh, String _maQU, String _maVungLT, String _tenTinh, String _maBHYT, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// public override void UpdateDMTinh(String _maTinh, String _maQU, String _maVungLT, String _tenTinh, String _maBHYT, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maTinh, _maQU, _maVungLT, _tenTinh, _maBHYT, _maMay, _huy, _ngaySD.DBValue, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
			DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maTinh));
		}

		/// <summary>
		/// Delete the <see cref="DMTinh" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMTinh
			DataProvider.Instance().DeleteDMTinh(crit.MaMay,crit.NguoiSD, crit.MaTinh);
			// public abstract void DeleteDMTinh(String _maTinh);
			// public override void DeleteDMTinh(String _maTinh);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maTinh);
			// }
		}

		#endregion
	}

}
