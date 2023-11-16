// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMLoaiHinh
// Kieu doi tuong  :	DMLoaiHinh
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	1/21/2009 10:22:43 AM
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
	/// This is a base generated class of <see cref="DMLoaiHinh" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMLoaiHinh : BusinessBase<DMLoaiHinh>
	{
		#region Business Methods
		
		#region State Fields
        private String _tenChungLoai = String.Empty;
		private String _maLH = String.Empty;
		private String _tenLH = String.Empty;
		private String _maChungLoai = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
        private int _OrderNumber;
        private String _hoten = String.Empty;
		#endregion
		
		#region Business Properties and Methods
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
		
		public String MaLH
		{
			get 
			{
				CanReadProperty("MaLH", true);
				return _maLH;
			}
			set 
			{
				CanWriteProperty("MaLH", true);
				if (_maLH != value) 
				{
					_maLH = value;
					PropertyHasChanged("MaLH");
				}
			}
		}
		
		public String TenLH
		{
			get 
			{
				CanReadProperty("TenLH", true);
				return _tenLH;
			}
			set 
			{
				CanWriteProperty("TenLH", true);
				if (_tenLH != value) 
				{
					_tenLH = value;
					PropertyHasChanged("TenLH");
				}
			}
		}
		
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
		
		public string NgaySD
		{
			get 
			{
				CanReadProperty("NgaySD", true);
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm:ss";

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
			return _maLH;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenLH", 150));
            ValidationRules.AddRule<DMLoaiHinh>(StringRequired<DMLoaiHinh>, "TenLH");


        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMLoaiHinh
        {

            if (target._tenLH == null || target._tenLH.Trim().Length == 0)
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
		/// Factory method. New <see cref="DMLoaiHinh" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMLoaiHinh NewDMLoaiHinh()
        {
            //return new DMNhomThuoc();
            return DataPortal.Create<DMLoaiHinh>();
        }

		public static DMLoaiHinh GetDMLoaiHinh(String maLH)
		{
			return DataPortal.Fetch<DMLoaiHinh>(new Criteria(maLH));
		}
		
		/// <summary>
		/// Marks the <see cref="DMLoaiHinh" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMLoaiHinh(String maLH, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maLH));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMLoaiHinh()
		{	
			// Prevent direct creation
		}
        internal DMLoaiHinh(int ordernumber, String maNT, String tenNT, String maChungLoai, String maMay, Boolean huy, SmartDate ngaySD, String nguoiSD, String hoten,string tenchungloai)
        {
            _OrderNumber = ordernumber;
            _maLH   = maNT;
            _tenLH = tenNT;
            _maChungLoai  = maChungLoai ;
            _maMay = maMay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD;
            _hoten = hoten;
            _tenChungLoai = tenchungloai;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maLH;
			public String MaLH 
			{
				get
				{
					return _maLH;
				}
			}
			
			public Criteria(String maLH)
			{
				_maLH = maLH;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maLH.Equals(c._maLH)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maLH.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maLH;
            public String maLH
            {
                get
                {
                    return _maLH;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maLH)
            {
                _maLH = maLH;
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
		/// Retrieve an existing <see cref="DMLoaiHinh" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMLoaiHinh(String _maLH);
			// public override IDataReader GetDMLoaiHinh(String _maLH)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maLH));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMLoaiHinh(crit.MaLH)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMLoaiHinh" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaLH") != null) _maLH = dr.GetString("MaLH");
			if (dr.GetString("TenLH") != null) _tenLH = dr.GetString("TenLH");
			if (dr.GetString("MaChungLoai") != null) _maChungLoai = dr.GetString("MaChungLoai");
            if (dr.GetString("TenChungLoai") != null) _tenChungLoai = dr.GetString("TenChungLoai");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMLoaiHinh" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMLoaiHinh
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maLH = DataProvider.Instance().InsertDMLoaiHinh(_tenLH, _maChungLoai, _maMay, _nguoiSD);
			// public abstract String InsertDMLoaiHinh(String _tenLH, String _maChungLoai, String _maMay, String _nguoiSD);
			// public override String InsertDMLoaiHinh(String _tenLH, String _maChungLoai, String _maMay, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenLH, _maChungLoai, _maMay, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMLoaiHinh" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMLoaiHinh
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMLoaiHinh(_maLH, _tenLH, _maChungLoai, _maMay, _huy, _nguoiSD);
				// public abstract void UpdateDMLoaiHinh(String _maLH, String _tenLH, String _maChungLoai, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateDMLoaiHinh(String _maLH, String _tenLH, String _maChungLoai, String _maMay, Boolean _huy, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maLH, _tenLH, _maChungLoai, _maMay, _huy, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maLH));
		}

		/// <summary>
		/// Delete the <see cref="DMLoaiHinh" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMLoaiHinh
            DataProvider.Instance().DeleteDMLoaiHinh(crit.MaMay, crit.NguoiSD, crit.maLH);
			// public abstract void DeleteDMLoaiHinh(String _maLH);
			// public override void DeleteDMLoaiHinh(String _maLH);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maLH);
			// }
		}

		#endregion
	}

}
