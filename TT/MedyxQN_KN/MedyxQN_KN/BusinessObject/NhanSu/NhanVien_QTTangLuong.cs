// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	NhanVien_QTTangLuong
// Kieu doi tuong  :	NhanVien_QTTangLuong
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	8/12/2009 10:17:31 AM
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
	/// This is a base generated class of <see cref="NhanVien_QTTangLuong" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class NhanVien_QTTangLuong : BusinessBase<NhanVien_QTTangLuong>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maNV = String.Empty;
		private Int32 _sTT = 0;
		private SmartDate _tungay = new SmartDate(true);
		private SmartDate _denngay = new SmartDate(true);
        private SmartDate _tungayD = new SmartDate(true);
		private String _mangach = String.Empty;
		private Decimal _heSo = 0;
		private Decimal _mucLuong = 0;
        private Decimal _mucLuongCB = 0;
		private Boolean _huy = false;
		private String _maMay = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _nguoiSD1 = String.Empty;
        private Int32 _maBac =  0;
        private String _tenNguoiSD = String.Empty;
        private String _tenNgach = String.Empty;
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

		public String Mangach
		{
			get 
			{
				CanReadProperty("Mangach", true);
				return _mangach;
			}
			set 
			{
				CanWriteProperty("Mangach", true);
				if (_mangach != value) 
				{
					_mangach = value;
					PropertyHasChanged("Mangach");
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

        public Decimal MucLuongCB
        {
            get
            {
                CanReadProperty("MucLuongCB", true);
                return _mucLuongCB;
            }
            set
            {
                CanWriteProperty("MucLuongCB", true);
                if (_mucLuongCB != value)
                {
                    _mucLuongCB = value;
                    PropertyHasChanged("MucLuongCB");
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

        public Int32  MaBac
		{
			get 
			{
				CanReadProperty("MaBac", true);
				return _maBac;
			}
			set 
			{
				CanWriteProperty("MaBac", true);
				if (_maBac != value) 
				{
					_maBac = value;
					PropertyHasChanged("MaBac");
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

        public String TenNgach
        {
            get
            {
                CanReadProperty("TenNgach", true);
                return _tenNgach;
            }
            set
            {
                CanWriteProperty("TenNgach", true);
                if (_tenNgach != value)
                {
                    _tenNgach = value;
                    PropertyHasChanged("TenNgach");
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
			return _maNV.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="NhanVien_QTTangLuong" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        //public static NhanVien_QTTangLuong GetNhanVien_QTTangLuong(String maNV, Int32 sTT)
        //{
        //    return DataPortal.Fetch<NhanVien_QTTangLuong>(new Criteria(maNV, sTT));
        //}
		
        ///// <summary>
        ///// Marks the <see cref="NhanVien_QTTangLuong" /> Object for deletion. The Object will be deleted as part of the next save operation.
        ///// </summary>
        //public static void DeleteNhanVien_QTTangLuong(String maNV, Int32 sTT)
        //{
        //    DataPortal.Delete(new Criteria(maNV, sTT));
        //}
		public static NhanVien_QTTangLuong NewNhanVien_QTTangLuong()
        {
            return DataPortal.Create<NhanVien_QTTangLuong>();
        }
        internal static NhanVien_QTTangLuong GetNhanVien_QTTangLuong(SafeDataReader dr, int i)
        {
            return new NhanVien_QTTangLuong(dr, i);
        }
        public NhanVien_QTTangLuong()
        {
            MarkAsChild();
        }
		#endregion
		
        //#region Constructors
        //// Chu y !!!
        //// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        //// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal NhanVien_QTTangLuong()
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
		/// Retrieve an existing <see cref="NhanVien_QTTangLuong" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetNhanVien_QTTangLuong(String _maNV, Int32 _sTT);
        //    // public override IDataReader GetNhanVien_QTTangLuong(String _maNV, Int32 _sTT)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maNV, _sTT));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetNhanVien_QTTangLuong(crit.MaNV, crit.STT)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
        ///// <summary>
        ///// Load a <see cref="NhanVien_QTTangLuong" /> Object from given SafeDataReader.
        ///// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
        //    if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
        //    if (dr.GetSmartDate("Tungay", true) != null) _tungay = dr.GetSmartDate("Tungay", true);
        //    if (dr.GetSmartDate("Denngay", true) != null) _denngay = dr.GetSmartDate("Denngay", true);
        //    if (dr.GetString("Mangach") != null) _mangach = dr.GetString("Mangach");
        //    if (dr.GetDecimal("HeSo") != null) _heSo = dr.GetDecimal("HeSo");
        //    if (dr.GetDecimal("MucLuong") != null) _mucLuong = dr.GetDecimal("MucLuong");
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //    if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
        //    if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //    if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
        //    if (dr.GetString("MaBac") != null) _maBac = dr.GetString("MaBac");
        //}
		private NhanVien_QTTangLuong(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
           if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetSmartDate("Tungay", true) != null) _tungay = dr.GetSmartDate("Tungay", true);
			if (dr.GetSmartDate("Denngay", true) != null) _denngay = dr.GetSmartDate("Denngay", true);
			if (dr.GetString("Mangach") != null) _mangach = dr.GetString("Mangach");
			if (dr.GetDecimal("HeSo") != null) _heSo = dr.GetDecimal("HeSo");
			if (dr.GetDecimal("MucLuong") != null) _mucLuong = dr.GetDecimal("MucLuong");           
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetInt32("MaBac") != null) _maBac = dr.GetInt32("MaBac");
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetDecimal("MucLuongcb") != null) _mucLuongCB = dr.GetDecimal("MucLuongcb");
            if (dr.GetString("TenNgach") != null) _tenNgach = dr.GetString("TenNgach");
            
 
          
            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="NhanVien_QTTangLuong" /> Object to underlying database.
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
            
              
			_maNV = DataProvider.Instance().InsertNhanVien_QTTangLuong(_maNV, _tungay, _denngay, _mangach, _heSo, _mucLuong, _maMay, _nguoiSD , _maBac);
			// public abstract String InsertNhanVien_QTTangLuong(String _maNV, SmartDate _tungay, SmartDate _denngay, String _mangach, Decimal _heSo, Decimal _mucLuong, String _maMay, SmartDate _ngaySD, String _nguoiSD,  String _maBac);
			// public override String InsertNhanVien_QTTangLuong(String _maNV, SmartDate _tungay, SmartDate _denngay, String _mangach, Decimal _heSo, Decimal _mucLuong, String _maMay, SmartDate _ngaySD, String _nguoiSD,  String _maBac)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spNhanVien_QTTangLuong_Create", _maNV, _sTT, _tungay.DBValue, _denngay.DBValue, _mangach, _heSo, _mucLuong, _maMay, _nguoiSD , _maBac));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="NhanVien_QTTangLuong" /> Object to underlying database.
		/// </summary>
		 internal void Update()
        {
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_DongTien
			if (!this.IsDirty)
                return;
            
              
				DataProvider.Instance().UpdateNhanVien_QTTangLuong(_maNV, _sTT, _tungay, _denngay, _mangach, _heSo, _mucLuong, _huy, _maMay, _nguoiSD , _maBac);
				// public abstract void UpdateNhanVien_QTTangLuong(String _maNV, Int32 _sTT, SmartDate _tungay, SmartDate _denngay, String _mangach, Decimal _heSo, Decimal _mucLuong, Boolean _huy, String _maMay, String _nguoiSD, String _maBac);
				// public override void UpdateNhanVien_QTTangLuong(String _maNV, Int32 _sTT, SmartDate _tungay, SmartDate _denngay, String _mangach, Decimal _heSo, Decimal _mucLuong, Boolean _huy, String _maMay, String _nguoiSD, String _maBac)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spNHANVIEN_QTTangLuong_Update", _maNV, _sTT, _tungay.DBValue, _denngay.DBValue, _mangach, _heSo, _mucLuong, _huy, _maMay,  _nguoiSD_maBac);
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
		/// Delete the <see cref="NhanVien_QTTangLuong" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateNhanVien_QTTangLuong
            DataProvider.Instance().DeleteNhanVien_QTTangLuong(crit.MaMay, crit.NguoiSD, crit.MaNV, crit.STT);
			// public abstract void DeleteNhanVien_QTTangLuong(String _maNV, Int32 _sTT);
			// public override void DeleteNhanVien_QTTangLuong(String _maNV, Int32 _sTT)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spNHANVIEN_QTTangLuong_DELETED", _maNV, _sTT);
			// }
		}

		#endregion
	}

}
