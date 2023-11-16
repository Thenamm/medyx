// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	NhanVien_QTDongBHXH
// Kieu doi tuong  :	NhanVien_QTDongBHXH
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	8/12/2009 10:15:59 AM
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
	/// This is a base generated class of <see cref="NhanVien_QTDongBHXH" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class NhanVien_QTDongBHXH : BusinessBase<NhanVien_QTDongBHXH>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maNV = String.Empty;
		private Int32 _sTT = 0;
		private SmartDate _tuNgay = new SmartDate(true);
        private SmartDate _tuNgayD = new SmartDate(true);
		private SmartDate _denNgay = new SmartDate(true);
        private SmartDate _denNgayD = new SmartDate(true);
		private String _maKhoa = String.Empty;
		private Decimal _heSo = 0;
		private Decimal _mucLuong = 0;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
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
		
		public string TuNgay
		{
			get 
			{
				CanReadProperty("TuNgay", true);
				return _tuNgay.Text;
			}
			set 
			{
				CanWriteProperty("TuNgay", true);
				if (_tuNgay.Text != value) 
				{
					_tuNgay.Text = value;
					PropertyHasChanged("TuNgay");
				}
			}
		}

        public string TungayD
        {
            get
            {
                CanReadProperty("TungayD", true);
                _tuNgayD = _tuNgay;
                _tuNgayD.FormatString = "dd/MM/yyyy";
                return _tuNgayD.Text;
            }

        }
		
		public string DenNgay
		{
			get 
			{
				CanReadProperty("DenNgay", true);
				return _denNgay.Text;
			}
			set 
			{
				CanWriteProperty("DenNgay", true);
				if (_denNgay.Text != value) 
				{
					_denNgay.Text = value;
					PropertyHasChanged("DenNgay");
				}
			}
		}

        public string DenngayD
        {
            get
            {
                CanReadProperty("DenngayD", true);
                _denNgayD = _denNgay;
                _denNgayD.FormatString = "dd/MM/yyyy";
                return _denNgayD.Text;
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
		
		public Decimal HeSo
		{
			get 
			{
				CanReadProperty("HeSo", true);
				return _heSo;
			}
			set 
			{
				CanWriteProperty("HeSo", true);
				if (_heSo != value) 
				{
					_heSo = value;
					PropertyHasChanged("HeSo");
				}
			}
		}

        public string MucLuong
        {
            get
            {
                CanReadProperty("MucLuong", true);
                if (_mucLuong == 0)
                {
                    return "0";
                }
                else
                {
                    return _mucLuong.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("MucLuong", true);

                if (_mucLuong.ToString() != value)
                {
                    _mucLuong = decimal.Parse(value);
                    PropertyHasChanged("MucLuong");
                }
            }
        }

        //public Decimal MucLuong
        //{
        //    get
        //    {
        //        CanReadProperty("MucLuong", true);
        //        return _mucLuong;
        //    }
        //    set
        //    {
        //        CanWriteProperty("MucLuong", true);
        //        if (_mucLuong != value)
        //        {
        //            _mucLuong = value;
        //            PropertyHasChanged("MucLuong");
        //        }
        //    }
        //}
		
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
		
		public string NgaySD1
		{
			get 
			{
				CanReadProperty("NgaySD1", true);
				return _ngaySD1.Text;
			}
			set 
			{
				CanWriteProperty("NgaySD1", true);
				if (_ngaySD1.Text != value) 
				{
					_ngaySD1.Text = value;
					PropertyHasChanged("NgaySD1");
				}
			}
		}
		
		public String NguoiSD1
		{
			get 
			{
				CanReadProperty("NguoiSD1", true);
				return _nguoiSD1;
			}
			set 
			{
				CanWriteProperty("NguoiSD1", true);
				if (_nguoiSD1 != value) 
				{
					_nguoiSD1 = value;
					PropertyHasChanged("NguoiSD1");
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
			return _maNV.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="NhanVien_QTDongBHXH" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static NhanVien_QTDongBHXH NewNhanVien_QTDongBHXH()
        {
            return DataPortal.Create<NhanVien_QTDongBHXH>();
        }
        internal static NhanVien_QTDongBHXH GetNhanVien_QTDongBHXH(SafeDataReader dr, int i)
        {
            return new NhanVien_QTDongBHXH(dr, i);
        }
        public NhanVien_QTDongBHXH()
        {
            MarkAsChild();
        }
        //public static NhanVien_QTDongBHXH GetNhanVien_QTDongBHXH(String maNV, Int32 sTT)
        //{
        //    return DataPortal.Fetch<NhanVien_QTDongBHXH>(new Criteria(maNV, sTT));
        //}
		
		/// <summary>
		/// Marks the <see cref="NhanVien_QTDongBHXH" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteNhanVien_QTDongBHXH(String maNV, Int32 sTT)
        //{
        //    DataPortal.Delete(new Criteria(maNV, sTT));
        //}
		
		#endregion
		
        //#region Constructors
        //// Chu y !!!
        //// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        //// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal NhanVien_QTDongBHXH()
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
		/// Retrieve an existing <see cref="NhanVien_QTDongBHXH" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetNhanVien_QTDongBHXH(String _maNV, Int32 _sTT);
        //    // public override IDataReader GetNhanVien_QTDongBHXH(String _maNV, Int32 _sTT)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNV, _sTT));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetNhanVien_QTDongBHXH(crit.MaNV, crit.STT)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
        ///// <summary>
        ///// Load a <see cref="NhanVien_QTDongBHXH" /> Object from given SafeDataReader.
        ///// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
        //    if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
        //    if (dr.GetSmartDate("TuNgay", true) != null) _tuNgay = dr.GetSmartDate("TuNgay", true);
        //    if (dr.GetSmartDate("DenNgay", true) != null) _denNgay = dr.GetSmartDate("DenNgay", true);
        //    if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
        //    if (dr.GetDecimal("HeSo") != null) _heSo = dr.GetDecimal("HeSo");
        //    if (dr.GetDecimal("MucLuong") != null) _mucLuong = dr.GetDecimal("MucLuong");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //    if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
        //    if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
        //}
        private NhanVien_QTDongBHXH(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetSmartDate("TuNgay", true) != null) _tuNgay = dr.GetSmartDate("TuNgay", true);
            if (dr.GetSmartDate("DenNgay", true) != null) _denNgay = dr.GetSmartDate("DenNgay", true);
            if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
            if (dr.GetDecimal("HeSo") != null) _heSo = dr.GetDecimal("HeSo");
            if (dr.GetDecimal("MucLuong") != null) _mucLuong = dr.GetDecimal("MucLuong");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            
 
          
            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="NhanVien_QTDongBHXH" /> Object to underlying database.
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
            
              
			_maNV = DataProvider.Instance().InsertNhanVien_QTDongBHXH(_maNV, _tuNgay, _denNgay, _maKhoa, _heSo, _mucLuong, _maMay, _nguoiSD);
			// public abstract String InsertNhanVien_QTDongBHXH(String _maNV, SmartDate _tuNgay, SmartDate _denNgay, String _maKhoa, Decimal _heSo, Decimal _mucLuong, String _maMay, String _nguoiSD);
			// public override String InsertNhanVien_QTDongBHXH(String _maNV, SmartDate _tuNgay, SmartDate _denNgay, String _maKhoa, Decimal _heSo, Decimal _mucLuong, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spNhanVien_QTdongBHXH_Create", _maNV, _tuNgay.DBValue, _denNgay.DBValue, _maKhoa, _heSo, _mucLuong, _maMay, _nguoiSD));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="NhanVien_QTDongBHXH" /> Object to underlying database.
		/// </summary>
		 internal void Update()
        {
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_DongTien
			if (!this.IsDirty)
                return;
            
              
				DataProvider.Instance().UpdateNhanVien_QTDongBHXH(_maNV, _sTT, _tuNgay, _denNgay, _maKhoa, _heSo, _mucLuong, _maMay, _huy, _nguoiSD);
				// public abstract void UpdateNhanVien_QTDongBHXH(String _maNV, Int32 _sTT, SmartDate _tuNgay, SmartDate _denNgay, String _maKhoa, Decimal _heSo, Decimal _mucLuong, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateNhanVien_QTDongBHXH(String _maNV, Int32 _sTT, SmartDate _tuNgay, SmartDate _denNgay, String _maKhoa, Decimal _heSo, Decimal _mucLuong, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spNHANVIEN_QTdongBHXH_Update", _maNV, _sTT, _tuNgay.DBValue, _denNgay.DBValue, _maKhoa, _heSo, _mucLuong, _maMay, _huy, _ngaySD.DBValue, _nguoiSD , _ngaySD1.DBValue, _nguoiSD1);
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
		/// Delete the <see cref="NhanVien_QTDongBHXH" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateNhanVien_QTDongBHXH
            DataProvider.Instance().DeleteNhanVien_QTDongBHXH(crit.MaMay, crit.NguoiSD, crit.MaNV, crit.STT);
			// public abstract void DeleteNhanVien_QTDongBHXH(String _maNV, Int32 _sTT);
			// public override void DeleteNhanVien_QTDongBHXH(String _maNV, Int32 _sTT)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spNHANVIEN_QTdongBHXH_DELETED", _maNV, _sTT);
			// }
		}

		#endregion
	}

}
