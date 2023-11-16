// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMDanhGia_CS
// Kieu doi tuong  :	DMDanhGia_CS
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
	/// This is a base generated class of <see cref="DMDanhGia_CS" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMDanhGia_CS : BusinessBase<DMDanhGia_CS>
	{
		#region Business Methods
		
		#region State Fields
        private String _TenDG = String.Empty;
		private String _maCS = String.Empty;
		private String _tenCS = String.Empty;
		private String _maDG = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
        private int _OrderNumber;
        private String _hoten = String.Empty;
        private String _YeuCau = String.Empty;
        private Decimal _dongiaTT = 0;
        private String _tenLoaiCS = String.Empty;
	
		#endregion
		
		#region Business Properties and Methods
        public string dongiaTT
        {
            get
            {
                CanReadProperty("dongiaTT", true);
                if (_dongiaTT == 0)
                {
                    return "0";
                }
                else
                {
                    return _dongiaTT.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("dongiaTT", true);

                if (_dongiaTT.ToString() != value)
                {
                    _dongiaTT = decimal.Parse(value);
                    PropertyHasChanged("dongiaTT");
                }
            }
        }
		
        public String YeuCau
        {
            get
            {
                CanReadProperty("YeuCau", true);
                return _YeuCau;
            }
            set
            {
                CanWriteProperty("YeuCau", true);
                if (_YeuCau != value)
                {
                    _YeuCau = value;
                    PropertyHasChanged("YeuCau");
                }
            }
        }
	
        public String TenDG
        {
            get
            {
                CanReadProperty("TenDG", true);
                return _TenDG;
            }
            set
            {
                CanWriteProperty("TenDG", true);
                if (_TenDG != value)
                {
                    _TenDG = value;
                    PropertyHasChanged("TenDG");
                }
            }
        }
		
		public String MaCS
		{
			get 
			{
				CanReadProperty("MaCS", true);
				return _maCS;
			}
			set 
			{
				CanWriteProperty("MaCS", true);
				if (_maCS != value) 
				{
					_maCS = value;
					PropertyHasChanged("MaCS");
				}
			}
		}
        public String TenCS
        {
            get
            {
                CanReadProperty("TenCS", true);
                return _tenCS;
            }
            set
            {
                CanWriteProperty("TenCS", true);
                if (_tenCS != value)
                {
                    _tenCS = value;
                    PropertyHasChanged("TenCS");
                }
            }
        }
		public String TenLoaiCS
		{
			get 
			{
				CanReadProperty("TenLoaiCS", true);
				return _tenLoaiCS;
			}
			set 
			{
				CanWriteProperty("TenLoaiCS", true);
				if (_tenLoaiCS != value) 
				{
					_tenLoaiCS = value;
					PropertyHasChanged("TenLoaiCS");
				}
			}
		}
		
		public String maDG
		{
			get 
			{
				CanReadProperty("maDG", true);
				return _maDG;
			}
			set 
			{
				CanWriteProperty("maDG", true);
				if (_maDG != value) 
				{
					_maDG = value;
					PropertyHasChanged("maDG");
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
			return _maCS;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenCS", 150));
            ValidationRules.AddRule<DMDanhGia_CS>(StringRequired<DMDanhGia_CS>, "TenCS");


        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMDanhGia_CS
        {

            if (target._tenCS == null || target._tenCS.Trim().Length == 0)
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
		/// Factory method. New <see cref="DMDanhGia_CS" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMDanhGia_CS NewDMDanhGia_CS()
        {
            //return new DMNhomThuoc();
            return DataPortal.Create<DMDanhGia_CS>();
        }

		public static DMDanhGia_CS GetDMDanhGia_CS(String maCS)
		{
			return DataPortal.Fetch<DMDanhGia_CS>(new Criteria(maCS));
		}
		
		/// <summary>
		/// Marks the <see cref="DMDanhGia_CS" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMDanhGia_CS(String maCS, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maCS));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMDanhGia_CS()
		{	
			// Prevent direct creation
		}
        internal DMDanhGia_CS(int ordernumber, String maCS, String tenCS, String maDG, String YeuCau, Decimal dongiaTT, String maMay, Boolean huy, SmartDate ngaySD, String nguoiSD, String hoten, string TenDG, string TenLoaiCS)
        {
            _OrderNumber = ordernumber;
            _maCS   = maCS;
            _tenCS = tenCS;
            _maDG  = maDG ;
            _dongiaTT = dongiaTT;
            _YeuCau = YeuCau;
            _maMay = maMay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD;
            _hoten = hoten;
            _TenDG = TenDG;
            _tenLoaiCS = TenLoaiCS;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maCS;
			public String MaCS 
			{
				get
				{
					return _maCS;
				}
			}
			
			public Criteria(String maCS)
			{
				_maCS = maCS;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maCS.Equals(c._maCS)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maCS.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maCS;
            public String maCS
            {
                get
                {
                    return _maCS;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maCS)
            {
                _maCS = maCS;
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
		/// Retrieve an existing <see cref="DMDanhGia_CS" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMDanhGia_CS(String _maCS);
			// public override IDataReader GetDMDanhGia_CS(String _maCS)
			// {
			//	   return ((IDataReader)SqCSelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maCS));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMDanhGia_CS(crit.MaCS)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMDanhGia_CS" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaCS") != null) _maCS = dr.GetString("MaCS");
			if (dr.GetString("TenCS") != null) _tenCS = dr.GetString("TenCS");
            if (dr.GetString("TenLoaiCS") != null) _tenLoaiCS = dr.GetString("TenLoaiCS");
            if (dr.GetString("YeuCau") != null) _YeuCau = dr.GetString("YeuCau");
			if (dr.GetString("maDG") != null) _maDG = dr.GetString("maDG");
            if (dr.GetString("TenDG") != null) _TenDG = dr.GetString("TenDG");
            if (dr.GetDecimal("dongiaTT") != null) _dongiaTT = dr.GetDecimal("dongiaTT");
          
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMDanhGia_CS" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDanhGia_CS
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maCS = DataProvider.Instance().InsertDMDanhGia_CS(_tenCS, _maDG,_YeuCau ,_dongiaTT, _maMay, _nguoiSD,_tenLoaiCS );
			// public abstract String InsertDMDanhGia_CS(String _tenCS, String _maDG, String _maMay, String _nguoiSD);
			// public override String InsertDMDanhGia_CS(String _tenCS, String _maDG, String _maMay, String _nguoiSD);
			// {
			//		return CType(SqCSelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenCS, _maDG, _maMay, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMDanhGia_CS" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDanhGia_CS
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateDMDanhGia_CS(_maCS, _tenCS, _maDG, _YeuCau, _dongiaTT,_maMay, _huy, _nguoiSD, _tenLoaiCS);
				// public abstract void UpdateDMDanhGia_CS(String _maCS, String _tenCS, String _maDG, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateDMDanhGia_CS(String _maCS, String _tenCS, String _maDG, String _maMay, Boolean _huy, String _nguoiSD);
				// {
				//		SqCSelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maCS, _tenCS, _maDG, _maMay, _huy, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maCS));
		}

		/// <summary>
		/// Delete the <see cref="DMDanhGia_CS" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDanhGia_CS
            DataProvider.Instance().DeleteDMDanhGia_CS(crit.MaMay, crit.NguoiSD, crit.maCS);
			// public abstract void DeleteDMDanhGia_CS(String _maCS);
			// public override void DeleteDMDanhGia_CS(String _maCS);
			// {
			//		SqCSelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maCS);
			// }
		}

		#endregion
	}

}
