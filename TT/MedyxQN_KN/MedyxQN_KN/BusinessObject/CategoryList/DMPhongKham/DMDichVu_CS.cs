// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMDichVu_CS
// Kieu doi tuong  :	DMDichVu_CS
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	3/5/2009 4:12:22 PM
// Nguoi tao       :	HCABXT1
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
	/// This is a base generated class of <see cref="DMDichVu_CS" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMDichVu_CS : BusinessBase<DMDichVu_CS>
	{
		#region Business Methods
		
		#region State Fields
        private String _tenCS = String.Empty;
		private String _maCS = String.Empty;
		private String _maDV = String.Empty;
		
		private String _chisocaoNam = String.Empty;
		private String _chisocaoNu = String.Empty;
		private String _chisothapNu = String.Empty;
		private String _chisothapNam = String.Empty;
        private String _chisoin = String.Empty;
		private String _donvi = String.Empty;
		private String _ghichu = String.Empty;
		private String _maMay = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private Boolean _huy = false;
        private int _OrderNumber;
        private int _STTIn;
        private String _hoten = String.Empty;
        private String _tenCSBH = String.Empty;
        private String _maCSBH = String.Empty;
     
		
		#endregion
		
		#region Business Properties and Methods
        public String MaCSBH
        {
            get
            {
                CanReadProperty("MaCSBH", true);
                return _maCSBH;
            }
            set
            {
                CanWriteProperty("MaCSBH", true);
                if (_maCSBH != value)
                {
                    _maCSBH = value;
                    PropertyHasChanged("MaCSBH");
                }
            }
        }
        public String TenCSBH
        {
            get
            {
                CanReadProperty("TenCSBH", true);
                return _tenCSBH;
            }
            set
            {
                CanWriteProperty("TenCSBH", true);
                if (_tenCSBH != value)
                {
                    _tenCSBH = value;
                    PropertyHasChanged("TenCSBH");
                }
            }
        }
        public int STTIn
        {
            get
            {
                CanReadProperty("STTIn", true);
                return _STTIn;
            }
            set
            {
                CanWriteProperty("STTIn", true);
                if (_STTIn != value)
                {
                    _STTIn = value;
                    PropertyHasChanged("STTIn");
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
	
		public String MaDV
		{
			get 
			{
				CanReadProperty("MaDV", true);
				return _maDV;
			}
			set 
			{
				CanWriteProperty("MaDV", true);
				if (_maDV != value) 
				{
					_maDV = value;
					PropertyHasChanged("MaDV");
				}
			}
		}
		
		
		public String ChisocaoNam
		{
			get 
			{
				CanReadProperty("ChisocaoNam", true);
				return _chisocaoNam;
			}
			set 
			{
				CanWriteProperty("ChisocaoNam", true);
				if (_chisocaoNam != value) 
				{
					_chisocaoNam = value;
					PropertyHasChanged("ChisocaoNam");
				}
			}
		}
		
		public String ChisocaoNu
		{
			get 
			{
				CanReadProperty("ChisocaoNu", true);
				return _chisocaoNu;
			}
			set 
			{
				CanWriteProperty("ChisocaoNu", true);
				if (_chisocaoNu != value) 
				{
					_chisocaoNu = value;
					PropertyHasChanged("ChisocaoNu");
				}
			}
		}
		
		public String ChisothapNu
		{
			get 
			{
				CanReadProperty("ChisothapNu", true);
				return _chisothapNu;
			}
			set 
			{
				CanWriteProperty("ChisothapNu", true);
				if (_chisothapNu != value) 
				{
					_chisothapNu = value;
					PropertyHasChanged("ChisothapNu");
				}
			}
		}
		
		public String ChisothapNam
		{
			get 
			{
				CanReadProperty("ChisothapNam", true);
				return _chisothapNam;
			}
			set 
			{
				CanWriteProperty("ChisothapNam", true);
				if (_chisothapNam != value) 
				{
					_chisothapNam = value;
					PropertyHasChanged("ChisothapNam");
				}
			}
		}
        public String Chisoin
        {
            get
            {
                CanReadProperty("Chisoin", true);
                return _chisoin;
            }
            set
            {
                CanWriteProperty("Chisoin", true);
                if (_chisoin != value)
                {
                    _chisoin = value;
                    PropertyHasChanged("Chisoin");
                }
            }
        }
		public String Donvi
		{
			get 
			{
				CanReadProperty("Donvi", true);
				return _donvi;
			}
			set 
			{
				CanWriteProperty("Donvi", true);
				if (_donvi != value) 
				{
					_donvi = value;
					PropertyHasChanged("Donvi");
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
		
		public string NgaySD
		{
			get 
			{
				CanReadProperty("NgaySD", true);
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
            ValidationRules.AddRule<DMDichVu_CS>(StringRequired<DMDichVu_CS>, "TenCS");


        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMDichVu_CS
        {

            if (target._tenCS  == null || target._tenCS.Trim().Length == 0)
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
		/// Factory method. New <see cref="DMDichVu_CS" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMDichVu_CS NewDMDichVu_CS()
        {
            return DataPortal.Create<DMDichVu_CS>();
        }
        public static DMDichVu_CS NewDMDichVu_CS(string madv)
        {
            return DataPortal.Create<DMDichVu_CS>(new CriteriaNew(madv));
        }
		public static DMDichVu_CS GetDMDichVu_CS(String maCS)
		{
			return DataPortal.Fetch<DMDichVu_CS>(new Criteria(maCS));
		}
		
		/// <summary>
		/// Marks the <see cref="DMDichVu_CS" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMDichVu_CS(String maCS, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maCS));
		}
        private DMDichVu_CS(string madv)
        {
            _maDV = madv;
            
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMDichVu_CS()
		{	
			// Prevent direct creation
		}
        internal DMDichVu_CS( 
                         int OrderNumber,
                         String maCS ,
		                 String maDV ,
		                 String tenCS ,
		                 String chisocaoNam ,
		                 String chisocaoNu ,
		                 String chisothapNu ,
		                 String chisothapNam ,
                         String chisoin,
		                 String donvi ,
		                 String ghichu ,
		                 String maMay ,
		                 SmartDate ngaySD ,
		                 String nguoiSD ,
		                 Boolean huy,         
                         String hoten,
            int sttin,
            String macsbh,
            string tencsbh)
        {
            _maCSBH = macsbh;
            _tenCSBH = tencsbh;
                     _maCS = maCS  ;
                     _STTIn = sttin;
		             _maDV = maDV ;
		             _tenCS = tenCS  ;
		             _chisocaoNam = chisocaoNam  ;
		             _chisocaoNu = chisocaoNu  ;
		             _chisothapNu = chisothapNu  ;
		             _chisothapNam = chisothapNam  ;
                     _chisoin = chisoin;
		             _donvi = donvi  ;
		             _ghichu = ghichu  ;
		             _maMay = maMay  ;
		             _ngaySD = ngaySD  ;
		             _nguoiSD = nguoiSD  ;
		             _huy = huy  ;
                     _OrderNumber = OrderNumber ;
                    _hoten = hoten  ;
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
            private String _MaCS;
            public String MaCS
            {
                get
                {
                    return _MaCS;
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
                _MaCS = maCS;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
            }
        }

        [Serializable()]
        protected class CriteriaNew
        {
            private String _maDV;
            public String maDV
            {
                get
                {
                    return _maDV;
                }
            }

            public CriteriaNew(String maDV)
            {
                _maDV = maDV;
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
		/// Retrieve an existing <see cref="DMDichVu_CS" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMDichVu_CS(String _maCS);
			// public override IDataReader GetDMDichVu_CS(String _maCS)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maCS));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMDichVu_CS(crit.MaCS)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMDichVu_CS" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
            if (dr.GetString("TenCS") != null) _tenCS = dr.GetString("TenCS");
			if (dr.GetString("MaCS") != null) _maCS = dr.GetString("MaCS");
			if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
            if (dr.GetString("TenCSBH") != null) _tenCSBH = dr.GetString("TenCSBH");
            if (dr.GetString("MaCSBH") != null) _maCSBH = dr.GetString("MaCSBH");
         
			if (dr.GetString("ChisocaoNam") != null) _chisocaoNam = dr.GetString("ChisocaoNam");
			if (dr.GetString("ChisocaoNu") != null) _chisocaoNu = dr.GetString("ChisocaoNu");
			if (dr.GetString("ChisothapNu") != null) _chisothapNu = dr.GetString("ChisothapNu");
			if (dr.GetString("ChisothapNam") != null) _chisothapNam = dr.GetString("ChisothapNam");
            if (dr.GetString("Chisoin") != null) _chisoin = dr.GetString("Chisoin");
			if (dr.GetString("Donvi") != null) _donvi = dr.GetString("Donvi");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetInt32("STTIn") != null) _STTIn = dr.GetInt32("STTIn");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMDichVu_CS" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
        protected void DataPortal_Create(CriteriaNew param)
        {
            _maDV = param.maDV;
           
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDichVu_CS
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
              _maCS = DataProvider.Instance().InsertDMDichVu_CS(_maDV, _tenCS, _chisocaoNam, _chisocaoNu, _chisothapNu, _chisothapNam, _chisoin, _donvi, _ghichu, _STTIn,_maCSBH ,_tenCSBH , _maMay, _nguoiSD);
			// public abstract String InsertDMDichVu_CS(String _maDV, String _tenCS, String _chisocaoNam, String _chisocaoNu, String _chisothapNu, String _chisothapNam, String _donvi, String _ghichu, String _maMay, String _nguoiSD);
			// public override String InsertDMDichVu_CS(String _maDV, String _tenCS, String _chisocaoNam, String _chisocaoNu, String _chisothapNu, String _chisothapNam, String _donvi, String _ghichu, String _maMay, String _nguoiSD);
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDICHVU_CS_CREATE", _maDV, _tenCS, _chisocaoNam, _chisocaoNu, _chisothapNu, _chisothapNam, _donvi, _ghichu, _maMay, _nguoiSD ), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMDichVu_CS" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_CS
			if (IsDirty){


                DataProvider.Instance().UpdateDMDichVu_CS(_maCS, _maDV, _tenCS, _chisocaoNam, _chisocaoNu, _chisothapNu, _chisothapNam, _chisoin, _donvi, _ghichu, _STTIn, _maCSBH, _tenCSBH, _maMay, _nguoiSD, _huy);
				// public abstract void UpdateDMDichVu_CS(String _maCS, String _maDV, String _tenCS, String _chisocaoNam, String _chisocaoNu, String _chisothapNu, String _chisothapNam, String _donvi, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy);
				// public override void UpdateDMDichVu_CS(String _maCS, String _maDV, String _tenCS, String _chisocaoNam, String _chisocaoNu, String _chisothapNu, String _chisothapNam, String _donvi, String _ghichu, String _maMay, String _nguoiSD, Boolean _huy);
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDICHVU_CS_UPDATE", _maCS, _maDV, _tenCS, _chisocaoNam, _chisocaoNu, _chisothapNu, _chisothapNam, _donvi, _ghichu, _maMay, _nguoiSD , _huy);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maCS));
		}

		/// <summary>
		/// Delete the <see cref="DMDichVu_CS" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_CS
              
            DataProvider.Instance().DeleteDMDichVu_CS(crit.MaMay, crit.NguoiSD, crit.MaCS);
			// public abstract void DeleteDMDichVu_CS(String _maCS);
			// public override void DeleteDMDichVu_CS(String _maCS);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMDICHVU_DELETED", _maCS);
			// }
		}

		#endregion
	}

}
