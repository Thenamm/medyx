// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BC_DMKhoa
// Kieu doi tuong  :	BC_DMKhoa
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	11/5/2008 10:27:03 AM
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

namespace HTC.Business.KHTH
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="BC_DMKhoa" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BC_DMKhoa : BusinessBase<BC_DMKhoa>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maKhoa = String.Empty;
		private String _tenKhoa = String.Empty;
		private Byte _loai = 0;
		private Byte _cap = 0;
		private Decimal _sogiuong = 0;
		private String _machuyenkhoa = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private String _tenta = String.Empty;
        private String _idparent = String.Empty;
        private String _hoten = String.Empty;
        private String _diadiem = String.Empty;
        private String _ghichu = String.Empty;
        private int _OrderNumber;
        private Boolean _chon = true;
        private Boolean _KhongHD = false;
        private String _maNhom = String.Empty;
        private String _tenNhom = String.Empty;
		#endregion
		
		#region Business Properties and Methods
		
		public String MaKhoa
		{
			get 
			{
				CanReadProperty("MaKhoa", true);
				return _maKhoa;
			}
			set 
			{
				CanWriteProperty("MaKhoa", true);
				if (_maKhoa != value) 
				{
					_maKhoa = value;
					PropertyHasChanged("MaKhoa");
				}
			}
		}
        public String MaNhom
        {
            get
            {
                CanReadProperty("MaNhom", true);
                return _maNhom;
            }
            set
            {
                CanWriteProperty("MaNhom", true);
                if (_maNhom != value)
                {
                    _maNhom = value;
                    PropertyHasChanged("MaNhom");
                }
            }
        }
        public String TenNhom
        {
            get
            {
                CanReadProperty("TenNhom", true);
                return _tenNhom;
            }
            set
            {
                CanWriteProperty("TenNhom", true);
                if (_tenNhom != value)
                {
                    _tenNhom = value;
                    PropertyHasChanged("TenNhom");
                }
            }
        }
        public String ghichu
        {
            get
            {
                CanReadProperty("ghichu", true);
                return _ghichu;
            }
            set
            {
                CanWriteProperty("ghichu", true);
                if (_ghichu != value)
                {
                    _ghichu = value;
                    PropertyHasChanged("ghichu");
                }
            }
        }
        public String diadiem
        {
            get
            {
                CanReadProperty("diadiem", true);
                return _diadiem;
            }
            set
            {
                CanWriteProperty("diadiem", true);
                if (_diadiem != value)
                {
                    _diadiem = value;
                    PropertyHasChanged("diadiem");
                }
            }
        }
		public String TenKhoa
		{
			get 
			{
				CanReadProperty("TenKhoa", true);
				return _tenKhoa;
			}
			set 
			{
				CanWriteProperty("TenKhoa", true);
				if (_tenKhoa != value) 
				{
					_tenKhoa = value;
					PropertyHasChanged("TenKhoa");
				}
			}
		}

        public Byte Loai
		{
			get 
			{
				CanReadProperty("Loai", true);
				return _loai;
			}
			set 
			{
				CanWriteProperty("Loai", true);
				if (_loai != value) 
				{
					_loai = value;
					PropertyHasChanged("Loai");
				}
			}
		}
		
		public Byte Cap
		{
			get 
			{
				CanReadProperty("Cap", true);
				return _cap;
			}
			set 
			{
				CanWriteProperty("Cap", true);
				if (_cap != value) 
				{
					_cap = value;
					PropertyHasChanged("Cap");
				}
			}
		}
		
		public Decimal Sogiuong
		{
			get 
			{
				CanReadProperty("Sogiuong", true);
				return _sogiuong;
			}
			set 
			{
				CanWriteProperty("Sogiuong", true);
				if (_sogiuong != value) 
				{
					_sogiuong = value;
					PropertyHasChanged("Sogiuong");
				}
			}
		}
		
		public String Machuyenkhoa
		{
			get 
			{
				CanReadProperty("Machuyenkhoa", true);
				return _machuyenkhoa;
			}
			set 
			{
				CanWriteProperty("Machuyenkhoa", true);
				if (_machuyenkhoa != value) 
				{
					_machuyenkhoa = value;
					PropertyHasChanged("Machuyenkhoa");
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
        public Boolean chon
        {
            get
            {
                CanReadProperty("chon", true);
                return _chon;
            }
            set
            {
                CanWriteProperty("chon", true);
                if (_chon != value)
                {
                    _chon = value;
                    PropertyHasChanged("chon");
                }
            }
        }
        public Boolean KhongHD
        {
            get
            {
                CanReadProperty("KhongHD", true);
                return _KhongHD;
            }
            set
            {
                CanWriteProperty("KhongHD", true);
                if (_KhongHD != value)
                {
                    _KhongHD = value;
                    PropertyHasChanged("KhongHD");
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
        public String idparent
        {
            get
            {
                CanReadProperty("idparent", true);
                return _idparent;
            }
            set
            {
                CanWriteProperty("idparent", true);
                if (_idparent != value)
                {
                    _idparent = value;
                    PropertyHasChanged("idparent");
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
        public String tenta
        {
            get
            {
                CanReadProperty("tenta", true);
                return _tenta;
            }
            set
            {
                CanWriteProperty("tenta", true);
                if (_tenta != value)
                {
                    _tenta = value;
                    PropertyHasChanged("tenta");
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
			return _maKhoa;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenKhoa", 150));
            ValidationRules.AddRule<BC_DMKhoa>(StringRequired<BC_DMKhoa>, "TenKhoa");


        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : BC_DMKhoa
        {

            if (target._tenKhoa == null || target._tenKhoa.Trim().Length == 0)
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
		/// Factory method. New <see cref="BC_DMKhoa" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        public static BC_DMKhoa NewBC_DMKhoa()
        {
            return DataPortal.Create<BC_DMKhoa>();
            //return new BC_DMKhoa();
        }
        public static BC_DMKhoa NewBC_DMKhoa(string idparent)
        {
            //return new DMNhom(idparent);
            return DataPortal.Create<BC_DMKhoa>(new Criteria(idparent));
        }
		public static BC_DMKhoa GetBC_DMKhoa(String maKhoa)
		{
			return DataPortal.Fetch<BC_DMKhoa>(new Criteria(maKhoa));
		}
		
		/// <summary>
		/// Marks the <see cref="BC_DMKhoa" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBC_DMKhoa(String maKhoa, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maKhoa));
		}
        private BC_DMKhoa(string idparent)
        {
            _idparent = idparent;
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BC_DMKhoa()
		{	
			// Prevent direct creation
		}
        internal BC_DMKhoa(int ordernumber, string MaQG, string TenQG, Byte loai, Byte cap, Decimal sogiuong, string machuyenkhoa, string idmay, bool huy, SmartDate ngaySD, string NguoiSD, string idparent, string tenta, string hoten, Boolean chon, string diadiem, string ghichu, Boolean khonghd,string manhom, string tennhom)
        {
            _OrderNumber = ordernumber;
            _maKhoa = MaQG;
            _tenKhoa = TenQG;
            _loai = loai;
            _cap = cap;
            _sogiuong = sogiuong;
            _maMay = idmay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = NguoiSD;
            _tenta = tenta;
            _idparent = idparent;
            _hoten = hoten;
            _diadiem = diadiem;
            _ghichu = ghichu;
            _KhongHD = khonghd;
            _maNhom = manhom;
            _tenNhom = tennhom;

        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maKhoa;
			public String MaKhoa 
			{
				get
				{
					return _maKhoa;
				}
			}
			
			public Criteria(String makhoa)
			{
                _maKhoa = makhoa ;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maKhoa.Equals(c._maKhoa)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maKhoa.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maKhoa;
            public String MaKhoa
            {
                get
                {
                    return _maKhoa;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maKhoa)
            {
                _maKhoa = maKhoa;
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
		/// Retrieve an existing <see cref="BC_DMKhoa" /> Object based on data in the database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
        protected void DataPortal_Create(Criteria param)
        {
            _idparent = param.MaKhoa ;
            //NameRoot = param.RootName;
            ValidationRules.CheckRules();
        }
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetBC_DMKhoa(String _maKhoa);
			// public override IDataReader GetBC_DMKhoa(String _maKhoa)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maKhoa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBC_DMKhoa(crit.MaKhoa)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="BC_DMKhoa" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
			if (dr.GetString("TenKhoa") != null) _tenKhoa = dr.GetString("TenKhoa");
            if (dr.GetByte("Loai") != null) _loai = dr.GetByte("Loai");
			if (dr.GetByte("Cap") != null) _cap = dr.GetByte("Cap");
			if (dr.GetDecimal("Sogiuong") != null) _sogiuong = dr.GetDecimal("Sogiuong");
			if (dr.GetString("Machuyenkhoa") != null) _machuyenkhoa = dr.GetString("Machuyenkhoa");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
            if (dr.GetString("idparent") != null) _idparent = dr.GetString("idparent");
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("Tenta") != null) _tenta = dr.GetString("Tenta");
            if (dr.GetString("diadiem") != null) _diadiem = dr.GetString("diadiem");
            if (dr.GetString("ghichu") != null) _ghichu = dr.GetString("ghichu");
            if (dr.GetString("hoten") != null) _hoten = dr.GetString("hoten");
            if (dr.GetBoolean("khonghd") != null) _KhongHD  = dr.GetBoolean("khonghd");
            if (dr.GetString("MaNhom") != null) _maNhom = dr.GetString("MaNhom");
            if (dr.GetString("TenNhom") != null) _tenNhom = dr.GetString("TenNhom");
		}
		
		/// <summary>
		/// Insert the new <see cref="BC_DMKhoa" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBC_DMKhoa
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
           
			_maKhoa = DataProvider.Instance().InsertBC_DMKhoa(_tenKhoa, _loai, _sogiuong, _machuyenkhoa, _maMay, _nguoiSD ,_idparent ,_tenta,_diadiem ,_ghichu,_KhongHD, _maNhom  );
			// public abstract String InsertBC_DMKhoa(String _maKhoa, String _tenKhoa, String _loai, Byte _cap, Decimal _sogiuong, String _machuyenkhoa, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// public override String InsertBC_DMKhoa(String _maKhoa, String _tenKhoa, String _loai, Byte _cap, Decimal _sogiuong, String _machuyenkhoa, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maKhoa, _tenKhoa, _loai, _cap, _sogiuong, _machuyenkhoa, _maMay, _huy, _ngaySD.DBValue, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BC_DMKhoa" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBC_DMKhoa
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateBC_DMKhoa(_maKhoa, _tenKhoa, _loai, _cap, _sogiuong, _machuyenkhoa, _maMay, _nguoiSD , _tenta, _huy, _diadiem, _ghichu,_KhongHD,_maNhom  );
				// public abstract void UpdateBC_DMKhoa(String _maKhoa, String _tenKhoa, String _loai, Byte _cap, Decimal _sogiuong, String _machuyenkhoa, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// public override void UpdateBC_DMKhoa(String _maKhoa, String _tenKhoa, String _loai, Byte _cap, Decimal _sogiuong, String _machuyenkhoa, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maKhoa, _tenKhoa, _loai, _cap, _sogiuong, _machuyenkhoa, _maMay, _huy, _ngaySD.DBValue, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maKhoa));
		}

		/// <summary>
		/// Delete the <see cref="BC_DMKhoa" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBC_DMKhoa
            DataProvider.Instance().DeleteBC_DMKhoa(crit.MaMay, crit.NguoiSD, crit.MaKhoa);
			// public abstract void DeleteBC_DMKhoa(String _maKhoa);
			// public override void DeleteBC_DMKhoa(String _maKhoa);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maKhoa);
			// }
		}

		#endregion
	}

}
