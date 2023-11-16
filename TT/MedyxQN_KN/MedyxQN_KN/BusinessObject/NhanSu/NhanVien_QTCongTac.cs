// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	NhanVien_QTCongTac
// Kieu doi tuong  :	NhanVien_QTCongTac
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	8/4/2009 2:27:11 PM
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

namespace HTC.Business.NhanSu
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="NhanVien_QTCongTac" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class NhanVien_QTCongTac : BusinessBase<NhanVien_QTCongTac>
	{
		#region Business Methods
		
		#region State Fields
        private SmartDate _denngay = new SmartDate(true);
        private SmartDate _denngayD = new SmartDate(true);
		private String _maNV = String.Empty;
		private Int32 _sTT = 0;
		private SmartDate _tungay = new SmartDate(true);
        private SmartDate _tungayD = new SmartDate(true);
		private String _congviec = String.Empty;
		private String _noiLamviec = String.Empty;
		private String _soHD = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _maLoaiHD = String.Empty;
		private String _maKhoa = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenKhoa = String.Empty;
        private String _tenLoaiHD = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
        public string Denngay
        {
            get
            {
                CanReadProperty("Denngay", true);
                return _denngay.Text;
            }
            set
            {
                CanWriteProperty("Denngay", true);
                if (_denngay.Text != value)
                {
                    _denngay.Text = value;
                    PropertyHasChanged("Denngay");
                }
            }
        }

        public string DenngayD
        {
            get
            {
                CanReadProperty("DenngayD", true);
                _denngayD = _denngay;
                _denngayD.FormatString = "dd/MM/yyyy";
                return _denngayD.Text;
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
		
		public Int32 STT
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
		
		public string Tungay
		{
			get 
			{
				CanReadProperty("Tungay", true);
				return _tungay.Text;
			}
			set 
			{
				CanWriteProperty("Tungay", true);
				if (_tungay.Text != value) 
				{
					_tungay.Text = value;
					PropertyHasChanged("Tungay");
				}
			}
		}
        public string TungayD
        {
            get
            {
                CanReadProperty("TungayD", true);
                _tungayD = _tungay;
                _tungayD.FormatString = "dd/MM/yyyy";
                return _tungayD.Text;
            }

        }
		
		public String Congviec
		{
			get 
			{
				CanReadProperty("Congviec", true);
				return _congviec;
			}
			set 
			{
				CanWriteProperty("Congviec", true);
				if (_congviec != value) 
				{
					_congviec = value;
					PropertyHasChanged("Congviec");
				}
			}
		}
		
		public String NoiLamviec
		{
			get 
			{
				CanReadProperty("NoiLamviec", true);
				return _noiLamviec;
			}
			set 
			{
				CanWriteProperty("NoiLamviec", true);
				if (_noiLamviec != value) 
				{
					_noiLamviec = value;
					PropertyHasChanged("NoiLamviec");
				}
			}
		}
		
		public String SoHD
		{
			get 
			{
				CanReadProperty("SoHD", true);
				return _soHD;
			}
			set 
			{
				CanWriteProperty("SoHD", true);
				if (_soHD != value) 
				{
					_soHD = value;
					PropertyHasChanged("SoHD");
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
		
		public String MaLoaiHD
		{
			get 
			{
				CanReadProperty("MaLoaiHD", true);
				return _maLoaiHD;
			}
			set 
			{
				CanWriteProperty("MaLoaiHD", true);
				if (_maLoaiHD != value) 
				{
					_maLoaiHD = value;
					PropertyHasChanged("MaLoaiHD");
				}
			}
		}
		
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

        public String TenLoaiHD
        {
            get
            {
                CanReadProperty("TenLoaiHD", true);
                return _tenLoaiHD ;
            }
            set
            {
                CanWriteProperty("TenLoaiHD", true);
                if (_tenLoaiHD  != value)
                {
                    _tenLoaiHD = value;
                    PropertyHasChanged("TenLoaiHD");
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
			return _maNV.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="NhanVien_QTCongTac" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static NhanVien_QTCongTac NewNhanVien_QTCongTac()
        {
            return DataPortal.Create<NhanVien_QTCongTac>();
        }
        internal static NhanVien_QTCongTac GetNhanVien_QTCongTac(SafeDataReader dr, int i)
        {
            return new NhanVien_QTCongTac(dr, i);
        }
        public NhanVien_QTCongTac()
        {
            MarkAsChild();
        }
        //public static NhanVien_QTCongTac GetNhanVien_QTCongTac(String maNV, Int32 sTT)
        //{
        //    return DataPortal.Fetch<NhanVien_QTCongTac>(new Criteria(maNV, sTT));
        //}
		
		/// <summary>
		/// Marks the <see cref="NhanVien_QTCongTac" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteNhanVien_QTCongTac(String maNV, Int32 sTT)
        //{
        //    DataPortal.Delete(new Criteria(maNV, sTT));
        //}
		
		#endregion
		
        //#region Constructors
        //// Chu y !!!
        //// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        //// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal NhanVien_QTCongTac()
        //{	
        //    // Prevent direct creation
        //}
		
        //#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maNV;
			public String MaNV 
			{
				get
				{
					return _maNV;
				}
			}
			
			private Int32 _sTT;
			public Int32 STT 
			{
				get
				{
					return _sTT;
				}
			}
			
			public Criteria(String maNV, Int32 sTT)
			{
				_maNV = maNV;
				_sTT = sTT;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maNV.Equals(c._maNV)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maNV.ToString(), _sTT.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maNV;
            public String MaNV
            {
                get
                {
                    return _maNV;
                }
            }

            private Int32 _sTT;
            public Int32 STT
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
           
            public OtherCriteria(String Mamay, String Nguoisd, String maNV, Int32 sTT)
            {
                _maNV = maNV;
                _sTT = sTT;
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
		/// Retrieve an existing <see cref="NhanVien_QTCongTac" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetNhanVien_QTCongTac(String _maNV, Int32 _sTT);
        //    // public override IDataReader GetNhanVien_QTCongTac(String _maNV, Int32 _sTT)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNV, _sTT));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetNhanVien_QTCongTac(crit.MaNV, crit.STT)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="NhanVien_QTCongTac" /> Object from given SafeDataReader.
		/// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
        //    if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
        //    if (dr.GetSmartDate("Tungay", true) != null) _tungay = dr.GetSmartDate("Tungay", true);
        //    if (dr.GetString("Congviec") != null) _congviec = dr.GetString("Congviec");
        //    if (dr.GetString("NoiLamviec") != null) _noiLamviec = dr.GetString("NoiLamviec");
        //    if (dr.GetString("SoHD") != null) _soHD = dr.GetString("SoHD");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //    if (dr.GetString("MaLoaiHD") != null) _maLoaiHD = dr.GetString("MaLoaiHD");
        //    if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
        //}
        private NhanVien_QTCongTac(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetSmartDate("Tungay", true) != null) _tungay = dr.GetSmartDate("Tungay", true);
			if (dr.GetString("Congviec") != null) _congviec = dr.GetString("Congviec");
			if (dr.GetString("NoiLamviec") != null) _noiLamviec = dr.GetString("NoiLamviec");
			if (dr.GetString("SoHD") != null) _soHD = dr.GetString("SoHD");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("MaLoaiHD") != null) _maLoaiHD = dr.GetString("MaLoaiHD");
			if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenKhoa") != null) _tenKhoa = dr.GetString("TenKhoa");
            if (dr.GetString("TenLoaiHD") != null) _tenLoaiHD = dr.GetString("TenLoaiHD");
            if (dr.GetSmartDate("Denngay", true) != null) _denngay = dr.GetSmartDate("Denngay", true);
 
          
            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="NhanVien_QTCongTac" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            _ngaySD.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_DongTien
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
              
            _maNV = DataProvider.Instance().InsertNhanVien_QTCongTac(_maNV, _tungay, _congviec, _noiLamviec, _soHD, _maMay, _nguoiSD , _maLoaiHD, _maKhoa, _denngay);
			// public abstract String InsertNhanVien_QTCongTac(String _maNV, SmartDate _tungay, String _congviec, String _noiLamviec, String _soHD, String _maMay, String _nguoiSD, String _maLoaiHD, String _maKhoa);
			// public override String InsertNhanVien_QTCongTac(String _maNV, SmartDate _tungay, String _congviec, String _noiLamviec, String _soHD, String _maMay, String _nguoiSD, String _maLoaiHD, String _maKhoa)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spNHANVIEN_QTCONGTAC_Create", _maNV,  _tungay.DBValue, _congviec, _noiLamviec, _soHD, _maMay, _nguoiSD , _maLoaiHD, _maKhoa));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="NhanVien_QTCongTac" /> Object to underlying database.
		/// </summary>
		 internal void Update()
        {
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_DongTien
			if (!this.IsDirty)
                return;
            
              
				DataProvider.Instance().UpdateNhanVien_QTCongTac(_maNV, _sTT, _tungay, _congviec, _noiLamviec, _soHD, _maMay, _huy, _nguoiSD , _maLoaiHD, _maKhoa,_denngay);
				// public abstract void UpdateNhanVien_QTCongTac(String _maNV, Int32 _sTT, SmartDate _tungay, String _congviec, String _noiLamviec, String _soHD, String _maMay, Boolean _huy, String _nguoiSD, String _maLoaiHD, String _maKhoa);
				// public override void UpdateNhanVien_QTCongTac(String _maNV, Int32 _sTT, SmartDate _tungay, String _congviec, String _noiLamviec, String _soHD, String _maMay, Boolean _huy, String _nguoiSD, String _maLoaiHD, String _maKhoa)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spNHANVIEN_QTCONGTAC_Update", _maNV, _sTT, _tungay.DBValue, _congviec, _noiLamviec, _soHD, _maMay, _huy, _nguoiSD , _maLoaiHD, _maKhoa);
				// }				
			
		}
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
              
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maNV, _sTT));
            MarkNew();
        }

		/// <summary>
		/// Delete the <see cref="NhanVien_QTCongTac" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateNhanVien_QTCongTac
            DataProvider.Instance().DeleteNhanVien_QTCongTac(crit.MaMay, crit.NguoiSD, crit.MaNV, crit.STT);
			// public abstract void DeleteNhanVien_QTCongTac(String _maNV, Int32 _sTT);
			// public override void DeleteNhanVien_QTCongTac(String _maNV, Int32 _sTT);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spNHANVIEN_QTCONGTAC_DELETED", _maNV, _sTT);
			// }
		}

		#endregion
	}

}
