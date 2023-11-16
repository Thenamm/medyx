// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMPhuCap
// Kieu doi tuong  :	DMPhuCap
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
	/// This is a base generated class of <see cref="DMPhuCap" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMPhuCap : BusinessBase<DMPhuCap>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maPhuCap = String.Empty;
        private String _maNhom = String.Empty;
		private String _tenPhuCap = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private Boolean _lOAI = false ;
        private Boolean _loaichi = false;
        private Boolean _CoBan = false;
        private decimal _HeSo= 0;
        private decimal _MucLuong = 0;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private int _OrderNumber;
        private String _hoten = String.Empty;
        private String _GhiChu = String.Empty;

		#endregion
		
		#region Business Properties and Methods
		
		public String MaPhuCap
		{
			get 
			{
				CanReadProperty("MaPhuCap", true);
				return _maPhuCap;
			}
			set 
			{
				CanWriteProperty("MaPhuCap", true);
				if (_maPhuCap != value) 
				{
					_maPhuCap = value;
					PropertyHasChanged("MaPhuCap");
				}
			}
		}
        public String MaNhom
        {
            get
            {
                CanReadProperty("MaNhom", true);
                return _maNhom ;
            }
            set
            {
                CanWriteProperty("MaNhom", true);
                if (_maNhom  != value)
                {
                    _maNhom = value;
                    PropertyHasChanged("MaNhom");
                }
            }
        }

        public string   MucLuong
		{
			get 
			{
                CanReadProperty("MucLuong", true);
                return _MucLuong.ToString("###,###");
             
			}
            set
            {
                CanWriteProperty("MucLuong", true);

                if (_MucLuong.ToString() != value)
                {
                    _MucLuong = decimal.Parse(value);
                    PropertyHasChanged("MucLuong");
                }
            }
        }


        public Decimal  HeSo
        {
            get
            {
                CanReadProperty("HeSo", true);
                return _HeSo;
            }
            set
            {
                CanWriteProperty("HeSo", true);
                if (_HeSo != value)
                {
                    _HeSo = value;
                    PropertyHasChanged("HeSo");
                }
            }
        }

        public Boolean  CoBan
        {
            get
            {
                CanReadProperty("CoBan", true);
                return _CoBan;
            }
            set
            {
                CanWriteProperty("CoBan", true);
                if (_CoBan != value)
                {
                    _CoBan = value;
                    PropertyHasChanged("CoBan");
                }
            }
        }

        public String GhiChu
        {
            get
            {
                CanReadProperty("GhiChu", true);
                return _GhiChu;
            }
            set
            {
                CanWriteProperty("GhiChu", true);
                if (_GhiChu != value)
                {
                    _GhiChu = value;
                    PropertyHasChanged("GhiChu");
                }
            }
        }
        public String TenPhuCap
        {
            get
            {
                CanReadProperty("TenPhuCap", true);
                return _tenPhuCap;
            }
            set
            {
                CanWriteProperty("TenPhuCap", true);
                if (_tenPhuCap != value)
                {
                    _tenPhuCap = value;
                    PropertyHasChanged("TenPhuCap");
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
		
		public Boolean LOAI
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
        public Boolean LoaiChi
        {
            get
            {
                //CanReadProperty("LoaiChi", true);
                if (_lOAI == true)
                    return false;
                else
                    return true;
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
            //[System.Runtime.CompilerServices.MethodImpl(System.RuPhuCapime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _OrderNumber;
            }
           // [System.Runtime.CompilerServices.MethodImpl(System.RuPhuCapime.CompilerServices.MethodImplOptions.NoInlining)]
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
			return _maPhuCap;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenPhuCap");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenPhuCap", 150));
            ValidationRules.AddRule<DMPhuCap>(StringRequired<DMPhuCap>, "TenPhuCap");
            ValidationRules.AddRule<DMPhuCap>(StringRequired1<DMPhuCap>, "CoBan");
           



        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMPhuCap
        {

            if (target._tenPhuCap == null || target._tenPhuCap.Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }
        private static bool StringRequired1<T>(T target, Csla.Validation.RuleArgs e) where T : DMPhuCap
        {

            if (target._CoBan == null )
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
		/// Factory method. New <see cref="DMPhuCap" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMPhuCap NewDMPhuCap()
        {
            return DataPortal.Create<DMPhuCap>();
        }
		public static DMPhuCap GetDMPhuCap(String maPhuCap)
		{
			return DataPortal.Fetch<DMPhuCap>(new Criteria(maPhuCap));
		}
		
		/// <summary>
		/// Marks the <see cref="DMPhuCap" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMPhuCap(String maPhuCap, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maPhuCap));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMPhuCap()
		{	
			// PrevePhuCap direct creation
		}
        internal DMPhuCap(int ordernumber, String maPhuCap, String maNhom, String tenPhuCap, Boolean loai, Boolean CoBan, decimal HeSo, decimal MucLuong, String maMay, Boolean huy, SmartDate ngaySD, String nguoiSD, String hoten, string GhiChu)
        {
            _OrderNumber = ordernumber;
            _maPhuCap  = maPhuCap;
            _maNhom = maNhom;
            _tenPhuCap = tenPhuCap;
            _lOAI = loai;
            _CoBan = CoBan;
            _HeSo = HeSo;
            _MucLuong = MucLuong;
            _maMay = maMay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD;
            _hoten = hoten;
            _GhiChu = GhiChu;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maPhuCap;
			public String MaPhuCap 
			{
				get
				{
					return _maPhuCap;
				}
			}
			
			public Criteria(String maPhuCap)
			{
				_maPhuCap = maPhuCap;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maPhuCap.Equals(c._maPhuCap)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int  GetHashCode()
			{
				return string.Concat("Criteria", _maPhuCap.ToString()).GetHashCode();
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
		/// Retrieve an existing <see cref="DMPhuCap" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMPhuCap(String _maPhuCap);
			// public override IDataReader GetDMPhuCap(String _maPhuCap)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maPhuCap));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMPhuCap(crit.MaPhuCap)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMPhuCap" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaPhuCap") != null) _maPhuCap = dr.GetString("MaPhuCap");
            if (dr.GetString("MaNhom") != null) _maNhom = dr.GetString("MaNhom");
			if (dr.GetString("TenPhuCap") != null) _tenPhuCap = dr.GetString("TenPhuCap");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetBoolean ("LOAI") != null) _lOAI = dr.GetBoolean("LOAI");
            if (dr.GetBoolean("CoBan") != null) _CoBan = dr.GetBoolean("CoBan");
            if (dr.GetDecimal("HeSo") != null) _HeSo = dr.GetDecimal("HeSo");
            if (dr.GetDecimal("MucLuong") != null) _MucLuong = dr.GetDecimal("MucLuong");
            if (dr.GetString("GhiChu") != null) _GhiChu = dr.GetString("GhiChu");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMPhuCap" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMPhuCap
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maPhuCap = DataProvider.Instance().InsertDMPhuCap(_tenPhuCap, _GhiChu ,  _CoBan , _lOAI, _HeSo ,_MucLuong ,_maMay , _nguoiSD , _maNhom );
			// public abstract String InsertDMPhuCap(String _tenPhuCap, String _maMay, Boolean _lOAI, String _nguoiSD);
			// public override String InsertDMPhuCap(String _tenPhuCap, String _maMay, Boolean _lOAI, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenPhuCap, _maMay, _lOAI, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMPhuCap" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMPhuCap
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateDMPhuCap(_maPhuCap, _tenPhuCap, _GhiChu, _CoBan, _lOAI, _HeSo, _MucLuong, _maMay, _huy , _nguoiSD , _maNhom );
				// public abstract void UpdateDMPhuCap(String _maPhuCap, String _tenPhuCap, String _maMay,  Boolean _lOAI, String _nguoiSD);
				// public override void UpdateDMPhuCap(String _maPhuCap, String _tenPhuCap, String _maMay,  Boolean _lOAI, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maPhuCap, _tenPhuCap, _maMay, _lOAI,  _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maPhuCap));
		}

		/// <summary>
		/// Delete the <see cref="DMPhuCap" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMPhuCap
            DataProvider.Instance().DeleteDMPhuCap(crit.MaMay, crit.NguoiSD, crit.maCL );
			// public abstract void DeleteDMPhuCap(String _maPhuCap);
			// public override void DeleteDMPhuCap(String _maPhuCap);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maPhuCap);
			// }
		}

		#endregion
	}

}
