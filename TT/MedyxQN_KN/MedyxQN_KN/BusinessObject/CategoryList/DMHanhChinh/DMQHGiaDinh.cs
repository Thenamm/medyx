// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMQHGiaDinh
// Kieu doi tuong  :	DMQHGiaDinh
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
// 

namespace HTC.Business.CategoryList
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="DMQHGiaDinh" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMQHGiaDinh : BusinessBase<DMQHGiaDinh>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maQHGiaDinh = String.Empty;
		private String _tenQHGiaDinh = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private String _ghiChu = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods

        public String MaQHGiaDinh
		{
			get 
			{
                CanReadProperty("MaQHGiaDinh", true);
				return _maQHGiaDinh;
			}
			set 
			{
                CanWriteProperty("MaQHGiaDinh", true);
				if (_maQHGiaDinh != value) 
				{
					_maQHGiaDinh = value;
                    PropertyHasChanged("MaQHGiaDinh");
				}
			}
		}

        public String TenQHGiaDinh
		{
			get 
			{
                CanReadProperty("TenQHGiaDinh", true);
				return _tenQHGiaDinh;
			}
			set 
			{
                CanWriteProperty("TenQHGiaDinh", true);
				if (_tenQHGiaDinh != value) 
				{
					_tenQHGiaDinh = value;
                    PropertyHasChanged("TenQHGiaDinh");
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
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm";
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
			return _maQHGiaDinh;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenQHGiaDinh", 150));
            ValidationRules.AddRule<DMQHGiaDinh>(StringRequired<DMQHGiaDinh>, "TenQHGiaDinh");


        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMQHGiaDinh 
        {

            if (target._tenQHGiaDinh == null || target._tenQHGiaDinh.Trim().Length == 0)
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
		/// Factory method. New <see cref="DMQHGiaDinh" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMQHGiaDinh NewDMQHGiaDinh()
        {
            return DataPortal.Create<DMQHGiaDinh>();
        }
		public static DMQHGiaDinh GetDMQHGiaDinh(String maQHGiaDinh)
		{
			return DataPortal.Fetch<DMQHGiaDinh>(new Criteria(maQHGiaDinh));
		}
		
		/// <summary>
		/// Marks the <see cref="DMQHGiaDinh" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMQHGiaDinh(String maQHGiaDinh, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maQHGiaDinh));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMQHGiaDinh()
		{	
			// Prevent direct creation
		}
        internal DMQHGiaDinh(int ordernumber, string MaQG, string TenQG, string idmay, bool huy, SmartDate ngaySD, string NguoiSD, string ghichu, string hoten)
        {
            _OrderNumber = ordernumber;
            _maQHGiaDinh   = MaQG;
            _tenQHGiaDinh  = TenQG;
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
			private String _maQHGiaDinh;
			public String maQHGiaDinh 
			{
				get
				{
					return _maQHGiaDinh;
				}
			}
			
			public Criteria(String maQHGiaDinh)
			{
				_maQHGiaDinh = maQHGiaDinh;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maQHGiaDinh.Equals(c._maQHGiaDinh)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maQHGiaDinh.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maQHGiaDinh;
            public String maQHGiaDinh
            {
                get
                {
                    return _maQHGiaDinh;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maQHGiaDinh)
            {
                _maQHGiaDinh = maQHGiaDinh;
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
		/// Retrieve an existing <see cref="DMQHGiaDinh" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMQHGiaDinh(String _maQHGiaDinh);
			// public override IDataReader GetDMQHGiaDinh(String _maQHGiaDinh)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maQHGiaDinh));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMQHGiaDinh(crit.maQHGiaDinh)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMQHGiaDinh" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
            if (dr.GetString("MaQHGiaDinh") != null) _maQHGiaDinh = dr.GetString("MaQHGiaDinh");
            if (dr.GetString("TenQHGiaDinh") != null) _tenQHGiaDinh = dr.GetString("TenQHGiaDinh");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetString("HoTen") != null) _hoten = dr.GetString("HoTen");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMQHGiaDinh" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMQHGiaDinh
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _maQHGiaDinh = DataProvider.Instance().InsertDMQHGiaDinh(_tenQHGiaDinh, _ghiChu, _maMay, _nguoiSD);
			// public abstract String InsertDMQHGiaDinh(String _tenQHGiaDinh, String _maMay, String _nguoiSD);
			// public override String InsertDMQHGiaDinh(String _tenQHGiaDinh, String _maMay, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenQHGiaDinh, _maMay,  _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMQHGiaDinh" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMQHGiaDinh
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMQHGiaDinh(_maQHGiaDinh, _tenQHGiaDinh,_ghiChu, _maMay, _nguoiSD ,_huy  );
				// public abstract void UpdateDMQHGiaDinh(String _maQHGiaDinh, String _tenQHGiaDinh, String _maMay, String _nguoiSD);
				// public override void UpdateDMQHGiaDinh(String _maQHGiaDinh, String _tenQHGiaDinh, String _maMay, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maQHGiaDinh, _tenQHGiaDinh, _maMay,  _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maQHGiaDinh));
		}

		/// <summary>
		/// Delete the <see cref="DMQHGiaDinh" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMQHGiaDinh
            DataProvider.Instance().DeleteDMQHGiaDinh(crit.MaMay, crit.NguoiSD, crit.maQHGiaDinh);
			// public abstract void DeleteDMQHGiaDinh(String _maQHGiaDinh);
			// public override void DeleteDMQHGiaDinh(String _maQHGiaDinh);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maQHGiaDinh);
			// }
		}

		#endregion
	}

}
