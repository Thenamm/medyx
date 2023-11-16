// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMHTRaVien
// Kieu doi tuong  :	DMHTRaVien
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
// 

namespace HTC.Business.CategoryList
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="DMHTRaVien" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMHTRaVien : BusinessBase<DMHTRaVien>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maHTRaVien = String.Empty;
		private String _tenHTRaVien = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private String _ghiChu = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;
        private String _MaBYTe = String.Empty;
		#endregion
		
		#region Business Properties and Methods
        public String MaBYTe
        {
            get
            {
                CanReadProperty("MaBYTe", true);
                return _MaBYTe;
            }
            set
            {
                CanWriteProperty("MaBYTe", true);
                if (_MaBYTe != value)
                {
                    _MaBYTe = value;
                    PropertyHasChanged("MaBYTe");
                }
            }
        }
		public String maHTRaVien
		{
			get 
			{
				CanReadProperty("maHTRaVien", true);
				return _maHTRaVien;
			}
			set 
			{
				CanWriteProperty("maHTRaVien", true);
				if (_maHTRaVien != value) 
				{
					_maHTRaVien = value;
					PropertyHasChanged("maHTRaVien");
				}
			}
		}
		
		public String TenHTRaVien
		{
			get 
			{
				CanReadProperty("TenHTRaVien", true);
				return _tenHTRaVien;
			}
			set 
			{
				CanWriteProperty("TenHTRaVien", true);
				if (_tenHTRaVien != value) 
				{
					_tenHTRaVien = value;
					PropertyHasChanged("TenHTRaVien");
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
			return _maHTRaVien;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenHTRaVien", 150));
            ValidationRules.AddRule<DMHTRaVien>(StringRequired<DMHTRaVien>, "TenHTRaVien");

        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMHTRaVien
        {

            if (target._tenHTRaVien == null || target._tenHTRaVien.Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }

		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMHTRaVien" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMHTRaVien NewDMHTRaVien()
        {
            return DataPortal.Create<DMHTRaVien>();
        }
		public static DMHTRaVien GetDMHTRaVien(String maHTRaVien)
		{
			return DataPortal.Fetch<DMHTRaVien>(new Criteria(maHTRaVien));
		}
		
		/// <summary>
		/// Marks the <see cref="DMHTRaVien" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMHTRaVien(String maHTRaVien, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maHTRaVien));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMHTRaVien()
		{	
			// Prevent direct creation
		}
        internal DMHTRaVien(int ordernumber, string MaQG, string TenQG, string idmay, bool huy, SmartDate ngaySD, string NguoiSD, string ghichu, string hoten)
        {
            _OrderNumber = ordernumber;
            _maHTRaVien   = MaQG;
            _tenHTRaVien  = TenQG;
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
			private String _maHTRaVien;
			public String maHTRaVien 
			{
				get
				{
					return _maHTRaVien;
				}
			}
			
			public Criteria(String maHTRaVien)
			{
				_maHTRaVien = maHTRaVien;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maHTRaVien.Equals(c._maHTRaVien)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maHTRaVien.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maHTRaVien;
            public String maHTRaVien
            {
                get
                {
                    return _maHTRaVien;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maHTRaVien)
            {
                _maHTRaVien = maHTRaVien;
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
		/// Retrieve an existing <see cref="DMHTRaVien" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMHTRaVien(String _maHTRaVien);
			// public override IDataReader GetDMHTRaVien(String _maHTRaVien)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maHTRaVien));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMHTRaVien(crit.maHTRaVien)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMHTRaVien" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("maHTRaVien") != null) _maHTRaVien = dr.GetString("maHTRaVien");
			if (dr.GetString("TenHTRaVien") != null) _tenHTRaVien = dr.GetString("TenHTRaVien");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetString("HoTen") != null) _hoten = dr.GetString("HoTen");
            if (dr.GetString("MaBYTe") != null) _MaBYTe = dr.GetString("MaBYTe");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMHTRaVien" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMHTRaVien
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _maHTRaVien = DataProvider.Instance().InsertDMHTRaVien(_tenHTRaVien, _ghiChu, _maMay, _nguoiSD);
			// public abstract String InsertDMHTRaVien(String _tenHTRaVien, String _maMay, String _nguoiSD);
			// public override String InsertDMHTRaVien(String _tenHTRaVien, String _maMay, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenHTRaVien, _maMay,  _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMHTRaVien" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMHTRaVien
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMHTRaVien(_maHTRaVien, _tenHTRaVien,_ghiChu, _maMay, _nguoiSD ,_huy  );
				// public abstract void UpdateDMHTRaVien(String _maHTRaVien, String _tenHTRaVien, String _maMay, String _nguoiSD);
				// public override void UpdateDMHTRaVien(String _maHTRaVien, String _tenHTRaVien, String _maMay, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maHTRaVien, _tenHTRaVien, _maMay,  _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maHTRaVien));
		}

		/// <summary>
		/// Delete the <see cref="DMHTRaVien" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMHTRaVien
            DataProvider.Instance().DeleteDMHTRaVien(crit.MaMay, crit.NguoiSD, crit.maHTRaVien);
			// public abstract void DeleteDMHTRaVien(String _maHTRaVien);
			// public override void DeleteDMHTRaVien(String _maHTRaVien);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maHTRaVien);
			// }
		}

		#endregion
	}

}
