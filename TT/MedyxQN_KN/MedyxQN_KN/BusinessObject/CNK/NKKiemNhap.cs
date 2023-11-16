// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	NKKiemNhap
// Kieu doi tuong  :	NKKiemNhap
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	4/8/2009 10:36:25 AM
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


namespace HTC.Business.CNK
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="NKKiemNhap" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class NKKiemNhap : BusinessBase<NKKiemNhap>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maPhieu = String.Empty;
		private Byte _sTT = 0;
		private String _maNV = String.Empty;
		private String _maCD = String.Empty;
        private Byte _loai = 0;
		private Boolean _huy = false;
		private String _ghichu = String.Empty;
        private String _maMay = String.Empty;
		private SmartDate _ngaySD = new SmartDate(DateTime.Today);
        private SmartDate _ngaySDD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private String _sohdon = String.Empty;
        private Byte _vaitro = 0;
        private String _tenChucVu = String.Empty;
        private String _tenChucDanh = String.Empty;
        //private String _tenChucDanh = HTC.Business.CategoryList.DMChucDanhListcb.DefaultPosition();
        private String _tenNhanVien = String.Empty;
        private String _tenNguoiSD = String.Empty;

		#endregion
		
		#region Business Properties and Methods
		
		public String MaPhieu
		{
			get 
			{
				CanReadProperty("MaPhieu", true);
				return _maPhieu;
			}
			set 
			{
				CanWriteProperty("MaPhieu", true);
				if (_maPhieu != value) 
				{
					_maPhieu = value;
					PropertyHasChanged("MaPhieu");
				}
			}
		}
        public String tenChucVu
        {
            get
            {
                CanReadProperty("tenChucVu", true);
                return _tenChucVu;
            }
            set
            {
                CanWriteProperty("tenChucVu", true);
                if (_tenChucVu != value)
                {
                    _tenChucVu = value;
                    PropertyHasChanged("tenChucVu");
                }
            }
        }
        public String tenChucDanh
        {
            get
            {
                CanReadProperty("tenChucDanh", true);
                return _tenChucDanh;
            }
            set
            {
                CanWriteProperty("tenChucDanh", true);
                if (_tenChucDanh != value)
                {
                    _tenChucDanh = value;
                    PropertyHasChanged("tenChucDanh");
                }
            }
        }
        public String tenNhanVien
        {
            get
            {
                CanReadProperty("tenNhanVien", true);
                return _tenNhanVien;
            }
            set
            {
                CanWriteProperty("tenNhanVien", true);
                if (_tenNhanVien != value)
                {
                    _tenNhanVien = value;
                    PropertyHasChanged("tenNhanVien");
                }
            }
        }
        public String sohdon
        {
            get
            {
                CanReadProperty("sohdon", true);
                return _sohdon;
            }
            set
            {
                CanWriteProperty("sohdon", true);
                if (_sohdon != value)
                {
                    _sohdon = value;
                    PropertyHasChanged("sohdon");
                }
            }
        }
		public Byte STT
		{
			get 
			{
				CanReadProperty("STT", true);
				return _sTT;
			}
			set 
			{
				CanWriteProperty("STT", true);
				if (_sTT != value) 
				{
					_sTT = value;
					PropertyHasChanged("STT");
				}
			}
		}
        public Byte vaitro
        {
            get
            {
                CanReadProperty("vaitro", true);
                return _vaitro;
            }
            set
            {
                CanWriteProperty("vaitro", true);
                if (_vaitro != value)
                {
                    _vaitro = value;
                    PropertyHasChanged("vaitro");
                }
            }
        }
		public String MaNV
		{
			get 
			{
				CanReadProperty("MaNV", true);
				return _maNV;
			}
			set 
			{
				CanWriteProperty("MaNV", true);
				if (_maNV != value) 
				{
					_maNV = value;
					PropertyHasChanged("MaNV");
				}
			}
		}
		
		public String MaCD
		{
			get 
			{
				CanReadProperty("MaCD", true);
				return _maCD;
			}
			set 
			{
				CanWriteProperty("MaCD", true);
				if (_maCD != value) 
				{
					_maCD = value;
					PropertyHasChanged("MaCD");
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
		
		public SmartDate NgaySD
		{
			get 
			{
				CanReadProperty("NgaySD", true);
                _ngaySD.FormatString = "dd/MM/yyyy" ;
				return _ngaySD;
			}
			set 
			{
				CanWriteProperty("NgaySD", true);
				if (_ngaySD != value) 
				{
                    _ngaySD.FormatString = "dd/MM/yyyy";
					_ngaySD = value;
					PropertyHasChanged("NgaySD");
				}
			}
		}
        public String NgaySDD
        {
            get
            {
                CanReadProperty("NgaySDD", true);
                this._ngaySD.FormatString = "dd/MM/yyyy";
                return _ngaySD.Text;
            }
            set
            {
                CanWriteProperty("NgaySDD", true);
                if (_ngaySD != value)
                {
                    _ngaySD.FormatString = "MM/dd/yyyy";
                    _ngaySD.Text = value;
                    PropertyHasChanged("NgaySDD");
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

        public String TenNguoiSD
        {
            get
            {
                CanReadProperty("TenNguoiSD", true);
                return _tenNguoiSD;
            }
            set
            {
                CanWriteProperty("TenNguoiSD", true);
                if (_tenNguoiSD != value)
                {
                    _tenNguoiSD = value;
                    PropertyHasChanged("TenNguoiSD");
                }
            }
        }
		
		protected override Object GetIdValue()
		{
			return _maPhieu.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {
            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "MaNCC");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("HOTEN", 150));
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("MaNV", 6));
            ValidationRules.AddRule<NKKiemNhap>(StringRequired<NKKiemNhap>, "HOTEN");
            ValidationRules.AddRule<NKKiemNhap>(StringRequiredSoLo<NKKiemNhap>, "MaNV");

        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : NKKiemNhap
        {

            if (target._tenNhanVien == null || target._tenNhanVien.Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }
        private static bool StringRequiredSoLo<T>(T target, Csla.Validation.RuleArgs e) where T : NKKiemNhap
        {

            if (target._maNV == null || target._maNV.Trim().Length == 0)
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
		/// Factory method. New <see cref="NKKiemNhap" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

        public static NKKiemNhap NewNKKiemNhap()
        {
            return new NKKiemNhap();
        }

        public static NKKiemNhap NewNKKiemNhap(Byte Loai, String MaPhieu)
        {
            return new NKKiemNhap(Loai, MaPhieu);
        }
        //public static NKKiemNhap GetNKKiemNhap(String maPhieu, Byte sTT)
        //{
        //    return DataPortal.Fetch<NKKiemNhap>(new Criteria(maPhieu, sTT));
        //}
        internal static NKKiemNhap GetNKKiemNhap(SafeDataReader dr)
        {
            return new NKKiemNhap(dr);
        }
		/// <summary>
		/// Marks the <see cref="NKKiemNhap" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteNKKiemNhap(String maPhieu, Byte sTT)
        //{
        //    DataPortal.Delete(new Criteria(maPhieu, sTT));
        //}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal NKKiemNhap()
		{	
			// Prevent direct creation
		}
        private NKKiemNhap(Byte Loai, String MaPhieu)
        {
            _loai = Loai;
            _maPhieu = MaPhieu;
            MarkAsChild();
        }
        private NKKiemNhap(SafeDataReader dr)
        {
            MarkAsChild();
            // Value properties
             if (dr.GetString("MaPhieu") != null) _maPhieu = dr.GetString("MaPhieu");
			if (dr.GetByte("STT") != null) _sTT = dr.GetByte("STT");
            if (dr.GetByte("vaitro") != null) _vaitro = dr.GetByte("vaitro");
			if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
            if (dr.GetString("tencd") != null) _tenChucDanh  = dr.GetString("tencd");
            if (dr.GetString("HOTEN") != null) _tenNhanVien = dr.GetString("HOTEN");
            //if (dr.GetString("sohdon") != null) _sohdon = dr.GetString("sohdon");
            if (dr.GetString("tencv") != null) _tenChucVu = dr.GetString("tencv");
			if (dr.GetString("MaCD") != null) _maCD = dr.GetString("MaCD");
            if (dr.GetByte("Loai") != null) _loai = dr.GetByte("Loai");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySDD = dr.GetSmartDate("NgaySD", true);
           // if (dr.GetSmartDate("NgayKK", true) != null) _ngayKKD = dr.GetSmartDate("NgayKK");
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            MarkOld();
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maPhieu;
			public String MaPhieu 
			{
				get
				{
					return _maPhieu;
				}
			}
			
			private Byte _sTT;
			public Byte STT 
			{
				get
				{
					return _sTT;
				}
			}
			
			public Criteria(String maPhieu, Byte sTT)
			{
				_maPhieu = maPhieu;
				_sTT = sTT;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maPhieu.Equals(c._maPhieu)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maPhieu.ToString(), _sTT.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            
            private String _maPhieu;
            public String maPhieu
            {
                get
                {
                    return _maPhieu;
                }
            }
            private Byte _sTT;
            public Byte STT
            {
                get
                {
                    return _sTT;
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

            public OtherCriteria(String Mamay, String Nguoisd, String maPhieu, Byte sTT)
            {
                _sTT = sTT;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _maPhieu = maPhieu;
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
		/// Retrieve an existing <see cref="NKKiemNhap" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetNKKiemNhap(String _maPhieu, Byte _sTT);
        //    // public override IDataReader GetNKKiemNhap(String _maPhieu, Byte _sTT)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maPhieu, _sTT));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetNKKiemNhap(crit.MaPhieu, crit.STT)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="NKKiemNhap" /> Object from given SafeDataReader.
		/// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaPhieu") != null) _maPhieu = dr.GetString("MaPhieu");
        //    if (dr.GetByte("STT") != null) _sTT = dr.GetByte("STT");
        //    if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
        //    if (dr.GetString("MaCD") != null) _maCD = dr.GetString("MaCD");
        //    if (dr.GetBoolean("Loai") != null) _loai = dr.GetBoolean("Loai");
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //    if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //}
		
		/// <summary>
		/// Insert the new <see cref="NKKiemNhap" /> Object to underlying database.
		/// </summary>
        internal void Insert()
        {
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertNKKiemNhap
			// Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
              
			_maPhieu = DataProvider.Instance().InsertNKKiemNhap(_maPhieu, _maNV, _maCD, _loai, _ghichu, _maMay, _nguoiSD, _vaitro);
			// public abstract String InsertNKKiemNhap(String _maPhieu, String _maNV, String _maCD, Boolean _loai, String _ghichu, String _maMay, String _nguoiSD);
			// public override String InsertNKKiemNhap(String _maPhieu, String _maNV, String _maCD, Boolean _loai, String _ghichu, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spNKKiemNhap_CREATE", _maPhieu,  _maNV, _maCD, _loai,  _ghichu, _maMay, _nguoiSD));
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="NKKiemNhap" /> Object to underlying database.
		/// </summary>
        internal void Update()
        {
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateNKKiemNhap
			if (IsDirty){
				DataProvider.Instance().UpdateNKKiemNhap(_maPhieu, _sTT, _maNV, _maCD, _loai, _huy, _ghichu, _maMay, _nguoiSD, _vaitro);
				// public abstract void UpdateNKKiemNhap(String _maPhieu, Byte _sTT, String _maNV, String _maCD, Boolean _loai, Boolean _huy, String _ghichu, String _maMay, String _nguoiSD);
				// public override void UpdateNKKiemNhap(String _maPhieu, Byte _sTT, String _maNV, String _maCD, Boolean _loai, Boolean _huy, String _ghichu, String _maMay, String _nguoiSD);
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spNKKiemNhap_UPDATE", _maPhieu, _sTT, _maNV, _maCD, _loai, _huy, _ghichu, _maMay, _nguoiSD);
				// }		
                MarkOld();
			}
		}
        //protected override void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new Criteria(_maPhieu, _sTT));
        //}

		/// <summary>
		/// Delete the <see cref="NKKiemNhap" />.
		/// </summary>
		protected void DataPortal_Delete(Criteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateNKKiemNhap
			//DataProvider.Instance().DeleteNKKiemNhap(crit.MaPhieu, crit.STT);
			// public abstract void DeleteNKKiemNhap(String _maPhieu, Byte _sTT);
			// public override void DeleteNKKiemNhap(String _maPhieu, Byte _sTT);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spNKKiemNhap_DELETED", _maPhieu, _sTT);
			// }
		}
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD,_maPhieu, _sTT));
            MarkNew();
        }

        private void DataPortal_Delete(OtherCriteria crit)
        {
            DataProvider.Instance().DeleteNKKiemNhap(crit.MaMay, crit.NguoiSD, crit.maPhieu, crit.STT);
        }
		#endregion
	}

}
