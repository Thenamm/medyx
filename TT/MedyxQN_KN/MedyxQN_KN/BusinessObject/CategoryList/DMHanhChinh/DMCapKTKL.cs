// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMCapKTKL
// Kieu doi tuong  :	DMCapKTKL
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
	/// This is a base generated class of <see cref="DMCapKTKL" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMCapKTKL : BusinessBase<DMCapKTKL>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maCapKTKL = String.Empty;
		private String _tenCapKTKL = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private String _ghiChu = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String maCapKTKL
		{
			get 
			{
				CanReadProperty("maCapKTKL", true);
				return _maCapKTKL;
			}
			set 
			{
				CanWriteProperty("maCapKTKL", true);
				if (_maCapKTKL != value) 
				{
					_maCapKTKL = value;
					PropertyHasChanged("maCapKTKL");
				}
			}
		}

        public String TenCapKTKL
		{
			get 
			{
                CanReadProperty("TenCapKTKL", true);
				return _tenCapKTKL;
			}
			set 
			{
                CanWriteProperty("TenCapKTKL", true);
				if (_tenCapKTKL != value) 
				{
					_tenCapKTKL = value;
                    PropertyHasChanged("TenCapKTKL");
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
			return _maCapKTKL;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenCapKTKL", 150));
            ValidationRules.AddRule<DMCapKTKL>(StringRequired<DMCapKTKL>, "TenCapKTKL");
           
        }
        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMCapKTKL
        {

            if (target._tenCapKTKL == null || target._tenCapKTKL.Trim().Length == 0)
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
		/// Factory method. New <see cref="DMCapKTKL" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMCapKTKL NewDMCapKTKL()
        {
            return DataPortal.Create<DMCapKTKL>();
        }
		public static DMCapKTKL GetDMCapKTKL(String maCapKTKL)
		{
			return DataPortal.Fetch<DMCapKTKL>(new Criteria(maCapKTKL));
		}
		
		/// <summary>
		/// Marks the <see cref="DMCapKTKL" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMCapKTKL(String maCapKTKL, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maCapKTKL));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMCapKTKL()
		{	
			// Prevent direct creation
		}
        internal DMCapKTKL(int ordernumber, string MaQG, string TenQG, string idmay, bool huy, SmartDate ngaySD, string NguoiSD, string ghichu, string hoten)
        {
            _OrderNumber = ordernumber;
            _maCapKTKL   = MaQG;
            _tenCapKTKL  = TenQG;
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
			private String _maCapKTKL;
			public String maCapKTKL 
			{
				get
				{
					return _maCapKTKL;
				}
			}
			
			public Criteria(String maCapKTKL)
			{
				_maCapKTKL = maCapKTKL;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maCapKTKL.Equals(c._maCapKTKL)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maCapKTKL.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maCapKTKL;
            public String maCapKTKL
            {
                get
                {
                    return _maCapKTKL;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maCapKTKL)
            {
                _maCapKTKL = maCapKTKL;
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
		/// Retrieve an existing <see cref="DMCapKTKL" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMCapKTKL(String _maCapKTKL);
			// public override IDataReader GetDMCapKTKL(String _maCapKTKL)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maCapKTKL));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMCapKTKL(crit.maCapKTKL)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMCapKTKL" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("maCapKTKL") != null) _maCapKTKL = dr.GetString("maCapKTKL");
            if (dr.GetString("TenCapKTKL") != null) _tenCapKTKL = dr.GetString("TenCapKTKL");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetString("HoTen") != null) _hoten = dr.GetString("HoTen");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMCapKTKL" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMCapKTKL
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _maCapKTKL = DataProvider.Instance().InsertDMCapKTKL(_tenCapKTKL, _ghiChu, _maMay, _nguoiSD);
			// public abstract String InsertDMCapKTKL(String _tenCapKTKL, String _maMay, String _nguoiSD);
			// public override String InsertDMCapKTKL(String _tenCapKTKL, String _maMay, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenCapKTKL, _maMay,  _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMCapKTKL" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMCapKTKL
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMCapKTKL(_maCapKTKL, _tenCapKTKL,_ghiChu, _maMay, _nguoiSD ,_huy  );
				// public abstract void UpdateDMCapKTKL(String _maCapKTKL, String _tenCapKTKL, String _maMay, String _nguoiSD);
				// public override void UpdateDMCapKTKL(String _maCapKTKL, String _tenCapKTKL, String _maMay, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maCapKTKL, _tenCapKTKL, _maMay,  _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maCapKTKL));
		}

		/// <summary>
		/// Delete the <see cref="DMCapKTKL" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMCapKTKL
            DataProvider.Instance().DeleteDMCapKTKL(crit.MaMay, crit.NguoiSD, crit.maCapKTKL);
			// public abstract void DeleteDMCapKTKL(String _maCapKTKL);
			// public override void DeleteDMCapKTKL(String _maCapKTKL);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maCapKTKL);
			// }
		}

		#endregion
	}

}
