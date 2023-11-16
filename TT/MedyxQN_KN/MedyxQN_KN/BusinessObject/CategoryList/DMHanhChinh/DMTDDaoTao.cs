// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMTDDaoTao
// Kieu doi tuong  :	DMTDDaoTao
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
	/// This is a base generated class of <see cref="DMTDDaoTao" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMTDDaoTao : BusinessBase<DMTDDaoTao>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maTDDaoTao = String.Empty;
		private String _tenTDDaoTao = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private String _ghiChu = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String maTDDaoTao
		{
			get 
			{
				CanReadProperty("maTDDaoTao", true);
				return _maTDDaoTao;
			}
			set 
			{
				CanWriteProperty("maTDDaoTao", true);
				if (_maTDDaoTao != value) 
				{
					_maTDDaoTao = value;
					PropertyHasChanged("maTDDaoTao");
				}
			}
		}

        public String TenTDDaoTao
		{
			get 
			{
                CanReadProperty("TenTDDaoTao", true);
				return _tenTDDaoTao;
			}
			set 
			{
                CanWriteProperty("TenTDDaoTao", true);
				if (_tenTDDaoTao != value) 
				{
					_tenTDDaoTao = value;
                    PropertyHasChanged("TenTDDaoTao");
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
			return _maTDDaoTao;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenTDDaoTao", 150));
            ValidationRules.AddRule<DMTDDaoTao>(StringRequired<DMTDDaoTao>, "TenTDDaoTao");
        }
        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMTDDaoTao
        {

            if (target._tenTDDaoTao == null || target._tenTDDaoTao.Trim().Length == 0)
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
		/// Factory method. New <see cref="DMTDDaoTao" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMTDDaoTao NewDMTDDaoTao()
        {
            return DataPortal.Create<DMTDDaoTao>();
        }
		public static DMTDDaoTao GetDMTDDaoTao(String maTDDaoTao)
		{
			return DataPortal.Fetch<DMTDDaoTao>(new Criteria(maTDDaoTao));
		}
		
		/// <summary>
		/// Marks the <see cref="DMTDDaoTao" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMTDDaoTao(String maTDDaoTao, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maTDDaoTao));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMTDDaoTao()
		{	
			// Prevent direct creation
		}
        internal DMTDDaoTao(int ordernumber, string MaQG, string TenQG, string idmay, bool huy, SmartDate ngaySD, string NguoiSD, string ghichu, string hoten)
        {
            _OrderNumber = ordernumber;
            _maTDDaoTao   = MaQG;
            _tenTDDaoTao  = TenQG;
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
			private String _maTDDaoTao;
			public String maTDDaoTao 
			{
				get
				{
					return _maTDDaoTao;
				}
			}
			
			public Criteria(String maTDDaoTao)
			{
				_maTDDaoTao = maTDDaoTao;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maTDDaoTao.Equals(c._maTDDaoTao)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maTDDaoTao.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maTDDaoTao;
            public String maTDDaoTao
            {
                get
                {
                    return _maTDDaoTao;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maTDDaoTao)
            {
                _maTDDaoTao = maTDDaoTao;
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
		/// Retrieve an existing <see cref="DMTDDaoTao" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMTDDaoTao(String _maTDDaoTao);
			// public override IDataReader GetDMTDDaoTao(String _maTDDaoTao)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maTDDaoTao));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMTDDaoTao(crit.maTDDaoTao)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMTDDaoTao" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("maTDDaoTao") != null) _maTDDaoTao = dr.GetString("maTDDaoTao");
            if (dr.GetString("TenTDDaoTao") != null) _tenTDDaoTao = dr.GetString("TenTDDaoTao");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetString("HoTen") != null) _hoten = dr.GetString("HoTen");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMTDDaoTao" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMTDDaoTao
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _maTDDaoTao = DataProvider.Instance().InsertDMTDDaoTao(_tenTDDaoTao, _ghiChu, _maMay, _nguoiSD);
			// public abstract String InsertDMTDDaoTao(String _tenTDDaoTao, String _maMay, String _nguoiSD);
			// public override String InsertDMTDDaoTao(String _tenTDDaoTao, String _maMay, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenTDDaoTao, _maMay,  _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMTDDaoTao" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMTDDaoTao
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMTDDaoTao(_maTDDaoTao, _tenTDDaoTao,_ghiChu, _maMay, _nguoiSD ,_huy  );
				// public abstract void UpdateDMTDDaoTao(String _maTDDaoTao, String _tenTDDaoTao, String _maMay, String _nguoiSD);
				// public override void UpdateDMTDDaoTao(String _maTDDaoTao, String _tenTDDaoTao, String _maMay, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maTDDaoTao, _tenTDDaoTao, _maMay,  _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maTDDaoTao));
		}

		/// <summary>
		/// Delete the <see cref="DMTDDaoTao" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMTDDaoTao
            DataProvider.Instance().DeleteDMTDDaoTao(crit.MaMay, crit.NguoiSD, crit.maTDDaoTao);
			// public abstract void DeleteDMTDDaoTao(String _maTDDaoTao);
			// public override void DeleteDMTDDaoTao(String _maTDDaoTao);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maTDDaoTao);
			// }
		}

		#endregion
	}

}
