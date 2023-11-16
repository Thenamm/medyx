// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMLoaiHopDong
// Kieu doi tuong  :	DMLoaiHopDong
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
	/// This is a base generated class of <see cref="DMLoaiHopDong" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMLoaiHopDong : BusinessBase<DMLoaiHopDong>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maLoaiHD = String.Empty;
		private String _TenLoaiHD = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private String _ghiChu = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String maLoaiHD
		{
			get 
			{
				CanReadProperty("maLoaiHD", true);
				return _maLoaiHD;
			}
			set 
			{
				CanWriteProperty("maLoaiHD", true);
				if (_maLoaiHD != value) 
				{
					_maLoaiHD = value;
					PropertyHasChanged("maLoaiHD");
				}
			}
		}

        public String TenLoaiHD
		{
			get 
			{
                CanReadProperty("TenLoaiHD", true);
				return _TenLoaiHD;
			}
			set 
			{
                CanWriteProperty("TenLoaiHD", true);
				if (_TenLoaiHD != value) 
				{
					_TenLoaiHD = value;
                    PropertyHasChanged("TenLoaiHD");
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
			return _maLoaiHD;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenLoaiHD", 150));
            ValidationRules.AddRule<DMLoaiHopDong>(StringRequired<DMLoaiHopDong>, "TenLoaiHD");


        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMLoaiHopDong 
        {

            if (target._TenLoaiHD  == null || target._TenLoaiHD.Trim().Length == 0)
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
		/// Factory method. New <see cref="DMLoaiHopDong" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMLoaiHopDong NewDMLoaiHopDong()
        {
            //return new DMLoaiHopDong();
            return DataPortal.Create<DMLoaiHopDong>();
        }
		public static DMLoaiHopDong GetDMLoaiHopDong(String maLoaiHD)
		{
			return DataPortal.Fetch<DMLoaiHopDong>(new Criteria(maLoaiHD));
		}
		
		/// <summary>
		/// Marks the <see cref="DMLoaiHopDong" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMLoaiHopDong(String maLoaiHD, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maLoaiHD));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMLoaiHopDong()
		{	
			// Prevent direct creation
		}
        internal DMLoaiHopDong(int ordernumber, string MaQG, string TenQG, string idmay, bool huy, SmartDate ngaySD, string NguoiSD, string ghichu, string hoten)
        {
            _OrderNumber = ordernumber;
            _maLoaiHD   = MaQG;
            _TenLoaiHD  = TenQG;
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
			private String _maLoaiHD;
			public String maLoaiHD 
			{
				get
				{
					return _maLoaiHD;
				}
			}
			
			public Criteria(String maLoaiHD)
			{
				_maLoaiHD = maLoaiHD;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maLoaiHD.Equals(c._maLoaiHD)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maLoaiHD.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maLoaiHD;
            public String maLoaiHD
            {
                get
                {
                    return _maLoaiHD;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maLoaiHD)
            {
                _maLoaiHD = maLoaiHD;
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
		/// Retrieve an existing <see cref="DMLoaiHopDong" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMLoaiHopDong(String _maLoaiHD);
			// public override IDataReader GetDMLoaiHopDong(String _maLoaiHD)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maLoaiHD));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMLoaiHopDong(crit.maLoaiHD)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMLoaiHopDong" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("maLoaiHD") != null) _maLoaiHD = dr.GetString("maLoaiHD");
            if (dr.GetString("TenLoaiHD") != null) _TenLoaiHD = dr.GetString("TenLoaiHD");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetString("HoTen") != null) _hoten = dr.GetString("HoTen");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMLoaiHopDong" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMLoaiHopDong
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _maLoaiHD = DataProvider.Instance().InsertDMLoaiHopDong(_TenLoaiHD, _ghiChu, _maMay, _nguoiSD);
			// public abstract String InsertDMLoaiHopDong(String _TenLoaiHD, String _maMay, String _nguoiSD);
			// public override String InsertDMLoaiHopDong(String _TenLoaiHD, String _maMay, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _TenLoaiHD, _maMay,  _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMLoaiHopDong" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMLoaiHopDong
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMLoaiHopDong(_maLoaiHD, _TenLoaiHD,_ghiChu, _maMay, _nguoiSD ,_huy  );
				// public abstract void UpdateDMLoaiHopDong(String _maLoaiHD, String _TenLoaiHD, String _maMay, String _nguoiSD);
				// public override void UpdateDMLoaiHopDong(String _maLoaiHD, String _TenLoaiHD, String _maMay, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maLoaiHD, _TenLoaiHD, _maMay,  _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maLoaiHD));
		}

		/// <summary>
		/// Delete the <see cref="DMLoaiHopDong" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMLoaiHopDong
            DataProvider.Instance().DeleteDMLoaiHopDong(crit.MaMay, crit.NguoiSD, crit.maLoaiHD);
			// public abstract void DeleteDMLoaiHopDong(String _maLoaiHD);
			// public override void DeleteDMLoaiHopDong(String _maLoaiHD);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maLoaiHD);
			// }
		}

		#endregion
	}

}
