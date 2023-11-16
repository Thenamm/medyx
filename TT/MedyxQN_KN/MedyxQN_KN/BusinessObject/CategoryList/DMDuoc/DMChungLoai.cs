// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMChungLoai
// Kieu doi tuong  :	DMChungLoai
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	12/11/2008 11:11:49 AM
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
	/// This is a base generated class of <see cref="DMChungLoai" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMChungLoai : BusinessBase<DMChungLoai>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maChungLoai = String.Empty;
		private String _tenChungLoai = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private Byte _lOAI = 0;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private int _OrderNumber;
        private String _hoten = String.Empty;
		#endregion
		
		#region Business Properties and Methods
		
		public String MaChungLoai
		{
			get 
			{
				CanReadProperty("MaChungLoai", true);
				return _maChungLoai;
			}
			set 
			{
				CanWriteProperty("MaChungLoai", true);
				if (_maChungLoai != value) 
				{
					_maChungLoai = value;
					PropertyHasChanged("MaChungLoai");
				}
			}
		}
		
		public String TenChungLoai
		{
			get 
			{
				CanReadProperty("TenChungLoai", true);
				return _tenChungLoai;
			}
			set 
			{
				CanWriteProperty("TenChungLoai", true);
				if (_tenChungLoai != value) 
				{
					_tenChungLoai = value;
					PropertyHasChanged("TenChungLoai");
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
		
		public Byte LOAI
		{
			get 
			{
				CanReadProperty("LOAI", true);
				return _lOAI;
			}
			set 
			{
				CanWriteProperty("LOAI", true);
				if (_lOAI != value) 
				{
					_lOAI = value;
					PropertyHasChanged("LOAI");
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
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                }
            }
        }

		protected override Object GetIdValue()
		{
			return _maChungLoai;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenChungLoai", 150));
            ValidationRules.AddRule<DMChungLoai>(StringRequired<DMChungLoai>, "TenChungLoai");


        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMChungLoai
        {

            if (target._tenChungLoai == null || target._tenChungLoai.Trim().Length == 0)
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
		/// Factory method. New <see cref="DMChungLoai" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMChungLoai NewDMChungLoai()
        {
            return DataPortal.Create<DMChungLoai>();
        }
		public static DMChungLoai GetDMChungLoai(String maChungLoai)
		{
			return DataPortal.Fetch<DMChungLoai>(new Criteria(maChungLoai));
		}
		
		/// <summary>
		/// Marks the <see cref="DMChungLoai" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMChungLoai(String maChungLoai, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maChungLoai));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMChungLoai()
		{	
			// Prevent direct creation
		}
        internal DMChungLoai(int ordernumber, String maNT, String tenNT,byte loai, String maMay, Boolean huy, SmartDate ngaySD, String nguoiSD ,String hoten)
        {
            _OrderNumber = ordernumber;
            _maChungLoai  = maNT;
            _tenChungLoai = tenNT;
            _lOAI = loai;
            _maMay = maMay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD;
            _hoten = hoten;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maChungLoai;
			public String MaChungLoai 
			{
				get
				{
					return _maChungLoai;
				}
			}
			
			public Criteria(String maChungLoai)
			{
				_maChungLoai = maChungLoai;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maChungLoai.Equals(c._maChungLoai)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maChungLoai.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maCL;
            public String maCL
            {
                get
                {
                    return _maCL;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maCL)
            {
                _maCL = maCL;
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
		/// Retrieve an existing <see cref="DMChungLoai" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMChungLoai(String _maChungLoai);
			// public override IDataReader GetDMChungLoai(String _maChungLoai)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maChungLoai));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMChungLoai(crit.MaChungLoai)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMChungLoai" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaChungLoai") != null) _maChungLoai = dr.GetString("MaChungLoai");
			if (dr.GetString("TenChungLoai") != null) _tenChungLoai = dr.GetString("TenChungLoai");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetByte("LOAI") != null) _lOAI = dr.GetByte("LOAI");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMChungLoai" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMChungLoai
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maChungLoai = DataProvider.Instance().InsertDMChungLoai(_tenChungLoai, _maMay, _lOAI, _nguoiSD);
			// public abstract String InsertDMChungLoai(String _tenChungLoai, String _maMay, Byte _lOAI, String _nguoiSD);
			// public override String InsertDMChungLoai(String _tenChungLoai, String _maMay, Byte _lOAI, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenChungLoai, _maMay, _lOAI, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMChungLoai" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMChungLoai
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMChungLoai(_maChungLoai, _tenChungLoai, _maMay, _huy,   _lOAI,  _nguoiSD);
				// public abstract void UpdateDMChungLoai(String _maChungLoai, String _tenChungLoai, String _maMay,  Byte _lOAI, String _nguoiSD);
				// public override void UpdateDMChungLoai(String _maChungLoai, String _tenChungLoai, String _maMay,  Byte _lOAI, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maChungLoai, _tenChungLoai, _maMay, _lOAI,  _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maChungLoai));
		}

		/// <summary>
		/// Delete the <see cref="DMChungLoai" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMChungLoai
            DataProvider.Instance().DeleteDMChungLoai(crit.MaMay, crit.NguoiSD, crit.maCL );
			// public abstract void DeleteDMChungLoai(String _maChungLoai);
			// public override void DeleteDMChungLoai(String _maChungLoai);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maChungLoai);
			// }
		}

		#endregion
	}

}
