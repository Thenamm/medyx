// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMVungLanhTho
// Kieu doi tuong  :	CslaObject
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	10/27/2008 9:40:15 AM
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

namespace HTC.Business.CategoryList
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="CslaObject" /> Business Object.
	/// </summary>
	
	[Serializable()]
    public partial class BenhAn_ThuPhanUngThuoc : BusinessBase<BenhAn_ThuPhanUngThuoc>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _MaThu = String.Empty;
		private String _MaBA = String.Empty;
        private int _STT = 0;
        private int _STTKhoa = 0;
        private String _MaThuoc = String.Empty;
        private String _MaBN = String.Empty;
        private SmartDate _TuNgay = new SmartDate(false);
        private SmartDate _DenNgay = new SmartDate(false);
        private String _PhuongPhapThu = String.Empty;
        private String _BSChiDinh = String.Empty;
        private String _NguoiThu = String.Empty;
        private String _BSDoc = String.Empty;
        private String _KQ = String.Empty;
        private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(false);
		private String _nguoiSD = String.Empty;
        private String _TenThuoc = String.Empty;
        private String _TenBSChiDinh = String.Empty;
        private String _TenNguoiThu = String.Empty;
        private String _TenBSDoc = String.Empty;
        private String _TenNguoiSD = String.Empty;
        private int _OrderNumber;
		#endregion
		
		#region Business Properties and Methods
		
		public String MaThu
        {
			get 
			{
                CanReadProperty("MaThu", true);
				return _MaThu;
			}
			set 
			{
                CanWriteProperty("MaThu", true);
                if (_MaThu != value) 
				{
                    _MaThu = value;
                    PropertyHasChanged("MaThu");
				}
			}
		}
		public String MaBA
        {
			get 
			{
                CanReadProperty("MaBA", true);
				return _MaBA;
			}
			set 
			{
                CanWriteProperty("MaBA", true);
                if (_MaBA != value) 
				{
                    _MaBA = value;
                    PropertyHasChanged("MaBA");
				}
			}
		}
        public Int32 STT
        {
            get
            {
                CanReadProperty("STT", true);
                return _STT;
            }
            set
            {
                CanWriteProperty("STT", true);
                if (_STT != value)
                {
                    _STT = value;
                    PropertyHasChanged("STT");
                }
            }
        }
        public Int32 STTKhoa
        {
            get
            {
                CanReadProperty("STTKhoa", true);
                return _STTKhoa;
            }
            set
            {
                CanWriteProperty("STTKhoa", true);
                if (_STTKhoa != value)
                {
                    _STTKhoa = value;
                    PropertyHasChanged("STTKhoa");
                }
            }
        }
        public String MaThuoc
        {
            get
            {
                CanReadProperty("MaThuoc", true);
                return _MaThuoc;
            }
            set
            {
                CanWriteProperty("MaThuoc", true);
                if (_MaThuoc != value)
                {
                    _MaThuoc = value;
                    PropertyHasChanged("MaThuoc");
                }
            }
        }
        public String MaBN
        {
            get
            {
                CanReadProperty("MaBN", true);
                return _MaBN;
            }
            set
            {
                CanWriteProperty("MaBN", true);
                if (_MaBN != value)
                {
                    _MaBN = value;
                    PropertyHasChanged("MaBN");
                }
            }
        }
        public SmartDate TuNgay
        {
            get
            {
                CanReadProperty("TuNgay", true);
                _TuNgay.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _TuNgay;
            }
            set
            {
                CanWriteProperty("TuNgay", true);
                if (_TuNgay != value)
                {
                    _TuNgay = value;
                    PropertyHasChanged("TuNgay");
                }
            }
        }
        public SmartDate DenNgay
        {
            get
            {
                CanReadProperty("DenNgay", true);
                _DenNgay.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _DenNgay;
            }
            set
            {
                CanWriteProperty("DenNgay", true);
                if (_DenNgay != value)
                {
                    _DenNgay = value;
                    PropertyHasChanged("DenNgay");
                }
            }
        }
        public string txtTuNgay
        {
            get
            {
                CanReadProperty("TuNgay", true);
                _TuNgay.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _TuNgay.ToString();
            }
        }
        public string txtDenNgay
        {
            get
            {
                CanReadProperty("DenNgay", true);
                _DenNgay.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _DenNgay.ToString();
            }
        }
        public String PhuongPhapThu
        {
            get
            {
                CanReadProperty("PhuongPhapThu", true);
                return _PhuongPhapThu;
            }
            set
            {
                CanWriteProperty("PhuongPhapThu", true);
                if (_PhuongPhapThu != value)
                {
                    _PhuongPhapThu = value;
                    PropertyHasChanged("PhuongPhapThu");
                }
            }
        }
        public String BSChiDinh
        {
            get
            {
                CanReadProperty("BSChiDinh", true);
                return _BSChiDinh;
            }
            set
            {
                CanWriteProperty("BSChiDinh", true);
                if (_BSChiDinh != value)
                {
                    _BSChiDinh = value;
                    PropertyHasChanged("BSChiDinh");
                }
            }
        }
        public String NguoiThu
        {
            get
            {
                CanReadProperty("NguoiThu", true);
                return _NguoiThu;
            }
            set
            {
                CanWriteProperty("NguoiThu", true);
                if (_NguoiThu != value)
                {
                    _NguoiThu = value;
                    PropertyHasChanged("NguoiThu");
                }
            }
        }
        public String BSDoc
        {
            get
            {
                CanReadProperty("BSDoc", true);
                return _BSDoc;
            }
            set
            {
                CanWriteProperty("BSDoc", true);
                if (_BSDoc != value)
                {
                    _BSDoc = value;
                    PropertyHasChanged("BSDoc");
                }
            }
        }
        public String KQ
        {
            get
            {
                CanReadProperty("KQ", true);
                return _KQ;
            }
            set
            {
                CanWriteProperty("KQ", true);
                if (_KQ != value)
                {
                    _KQ = value;
                    PropertyHasChanged("KQ");
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
        public String TenThuoc
        {
            get
            {
                CanReadProperty("TenThuoc", true);
                return _TenThuoc;
            }
            set
            {
                CanWriteProperty("TenThuoc", true);
                if (_TenThuoc != value)
                {
                    _TenThuoc = value;
                    PropertyHasChanged("TenThuoc");
                }
            }
        }
        public String TenBSChiDinh
        {
            get
            {
                CanReadProperty("TenBSChiDinh", true);
                return _TenBSChiDinh;
            }
            set
            {
                CanWriteProperty("TenBSChiDinh", true);
                if (_TenBSChiDinh != value)
                {
                    _TenBSChiDinh = value;
                    PropertyHasChanged("TenBSChiDinh");
                }
            }
        }
        public String TenNguoiThu
        {
            get
            {
                CanReadProperty("TenNguoiThu", true);
                return _TenNguoiThu;
            }
            set
            {
                CanWriteProperty("TenNguoiThu", true);
                if (_TenNguoiThu != value)
                {
                    _TenNguoiThu = value;
                    PropertyHasChanged("TenNguoiThu");
                }
            }
        }
        public String TenBSDoc
        {
            get
            {
                CanReadProperty("TenBSDoc", true);
                return _TenBSDoc;
            }
            set
            {
                CanWriteProperty("TenBSDoc", true);
                if (_TenBSDoc != value)
                {
                    _TenBSDoc = value;
                    PropertyHasChanged("TenBSDoc");
                }
            }
        }
        public String TenNguoiSD
        {
            get
            {
                CanReadProperty("TenNguoiSD", true);
                return _TenNguoiSD;
            }
            set
            {
                CanWriteProperty("TenNguoiSD", true);
                if (_TenNguoiSD != value)
                {
                    _TenNguoiSD = value;
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
			return _MaThu;
		}
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="CslaObject" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        public static BenhAn_ThuPhanUngThuoc NewBenhAn_ThuPhanUngThuoc()
        {
            //return DataPortal.Create<DMVungLanhTho>();
            return new BenhAn_ThuPhanUngThuoc();
        }
        public static BenhAn_ThuPhanUngThuoc GetBenhAn_ThuPhanUngThuoc(String MaBA, int STT, int STTKhoa, String MaThu)
		{
            return DataPortal.Fetch<BenhAn_ThuPhanUngThuoc>(new Criteria( MaBA, STT, STTKhoa, MaThu));
		}
		
		/// <summary>
		/// Marks the <see cref="CslaObject" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBenhAn_ThuPhanUngThuoc(String _MaThu, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy, _MaThu));
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
        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        protected internal BenhAn_ThuPhanUngThuoc()
		{	
			// Prevent direct creation
		}
		
        internal BenhAn_ThuPhanUngThuoc(int ordernumber, String MaThu,
         String MaBA,
         int STT,
         int STTKhoa,
         String MaThuoc,
         String MaBN,
         SmartDate TuNgay,
         SmartDate DenNgay,
         String PhuongPhapThu,
         String BSChiDinh,
         String NguoiThu,
         String BSDoc,
         String KQ,
         String maMay,
         Boolean huy,
        SmartDate ngaySD,
        String nguoiSD,
         String TenThuoc,
         String TenBSChiDinh,
         String TenNguoiThu,
         String TenBSDoc,
         String TenNguoiSD)
        {
            _OrderNumber = ordernumber;
            _MaThu = MaThu;
            _MaBA = MaBA;
            _STT = STT;
            _STTKhoa = STTKhoa;
            _MaThuoc = MaThuoc;
            _MaBN = MaBN;
            _TuNgay = TuNgay;
            _DenNgay = DenNgay;
            _PhuongPhapThu = PhuongPhapThu;
            _BSChiDinh = BSChiDinh;
            _NguoiThu = NguoiThu;
            _BSDoc = BSDoc;
            _KQ = KQ;
            _maMay = maMay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD;
            _TenThuoc = TenThuoc;
            _TenBSChiDinh = TenBSChiDinh;
            _TenNguoiThu = TenNguoiThu;
            _TenBSDoc = TenBSDoc;
            _TenNguoiSD = TenNguoiSD;
        }
        #endregion

        #region Criteria

        [Serializable()]
		protected class Criteria
		{
			private String _MaThu;
			public String MaThu 
			{
				get
				{
					return _MaThu;
				}
			}
            private String _MaBA;
            public String MaBA
            {
                get
                {
                    return _MaBA;
                }
            }
            private int _STT;
            public int STT
            {
                get
                {
                    return _STT;
                }
            }
            private int _STTKhoa;
            public int STTKhoa
            {
                get
                {
                    return _STTKhoa;
                }
            }
            public Criteria(String MaBA, int STT, int STTKhoa, String MaThu)
			{
                _MaThu = MaThu;
                _MaBA = MaBA;
                _STT = STT;
                _STTKhoa = STTKhoa;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
                    if (!_MaThu.Equals(c._MaThu)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _MaThu.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaThu;
            public String MaThu
            {
                get
                {
                    return _MaThu;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaThu)
            {
                _MaThu = MaThu;
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

		#region Data Access

		/// <summary>
		/// Retrieve an existing <see cref="CslaObject" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetCslaObject(String _maVungLT);
			// public override IDataReader GetCslaObject(String _maVungLT)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maVungLT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_ThuPhanUngThuoc(crit.MaBA,crit.STT,crit.STTKhoa,crit.MaThu)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="CslaObject" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
            // Value properties
            if (dr.GetString("MaThu") != null) _MaThu = dr.GetString("MaThu ");
            if (dr.GetString("MaBA") != null) _MaBA = dr.GetString("MaBA ");
            if (dr.GetInt32("STT") != null) _STT = dr.GetInt32("STT ");
            if (dr.GetInt32("STTKhoa") != null) _STTKhoa = dr.GetInt32("STTKhoa ");
            if (dr.GetString("MaThuoc") != null) _MaThuoc = dr.GetString("MaThuoc ");
            if (dr.GetString("MaBN") != null) _MaBN = dr.GetString("MaBN ");
            if (dr.GetSmartDate("TuNgay") != null) _TuNgay = dr.GetSmartDate("TuNgay ");
            if (dr.GetSmartDate("DenNgay") != null) _DenNgay = dr.GetSmartDate("DenNgay ");
            if (dr.GetString("PhuongPhapThu") != null) _PhuongPhapThu = dr.GetString("PhuongPhapThu ");
            if (dr.GetString("BSChiDinh") != null) _BSChiDinh = dr.GetString("BSChiDinh ");
            if (dr.GetString("NguoiThu") != null) _NguoiThu = dr.GetString("NguoiThu ");
            if (dr.GetString("BSDoc") != null) _BSDoc = dr.GetString("BSDoc ");
            if (dr.GetString("KQ") != null) _KQ = dr.GetString("KQ ");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", false) != null) _ngaySD = dr.GetSmartDate("NgaySD", false);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("TenThuoc") != null) _TenThuoc = dr.GetString("TenThuoc ");
            if (dr.GetString("TenBSChiDinh") != null) _TenBSChiDinh = dr.GetString("TenBSChiDinh ");
            if (dr.GetString("TenNguoiThu") != null) _TenNguoiThu = dr.GetString("TenNguoiThu ");
            if (dr.GetString("TenBSDoc") != null) _TenBSDoc = dr.GetString("TenBSDoc ");
            if (dr.GetString("TenNguoiSD") != null) _TenNguoiSD = dr.GetString("TenNguoiSD");
		}
		
		/// <summary>
		/// Insert the new <see cref="CslaObject" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertCslaObject
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _MaThu = DataProvider.Instance().InsertBenhAn_ThuPhanUngThuoc(_MaBA,_STT,_STTKhoa,_MaThuoc,_MaBN,_TuNgay.Date,_DenNgay.Date, _PhuongPhapThu,_BSChiDinh, _NguoiThu,_BSDoc, _KQ);
			// public abstract String InsertCslaObject(String _maVungLT, String _tenVungLT, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// public override String InsertCslaObject(String _maVungLT, String _tenVungLT, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maVungLT, _tenVungLT, _maMay, _huy, _ngaySD.DBValue, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="CslaObject" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateCslaObject
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateBenhAn_ThuPhanUngThuoc(_MaThu, _MaBA, _STT, _STTKhoa, _MaThuoc, _MaBN, _TuNgay.Date, _DenNgay.Date, _PhuongPhapThu, _BSChiDinh, _NguoiThu, _BSDoc, _KQ,_huy, _maMay, _nguoiSD);
				// public abstract void UpdateCslaObject(String _maVungLT, String _tenVungLT, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// public override void UpdateCslaObject(String _maVungLT, String _tenVungLT, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maVungLT, _tenVungLT, _maMay, _huy, _ngaySD.DBValue, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
			DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD,_MaThu ));
		}
        internal void DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD, _MaThu));
        }
        internal void Insert(string _MaBA, int _STT, int _STTKhoa, string _MaThuoc, string _MaBN, DateTime _TuNgay, DateTime _DenNgay, string _PhuongPhapThu, string _BSChiDinh, string _NguoiThu, string _BSDoc, string _KQ)
        {
            _MaThu = DataProvider.Instance().InsertBenhAn_ThuPhanUngThuoc(_MaBA, _STT, _STTKhoa, _MaThuoc, _MaBN, _TuNgay, _DenNgay, _PhuongPhapThu, _BSChiDinh, _NguoiThu, _BSDoc, _KQ);
            MarkOld();
        }
        internal void Update(String _MaThu, String _MaBA, int _STT, int _STTKhoa, String _MaThuoc, String _MaBN, DateTime _TuNgay, DateTime _DenNgay, String _PhuongPhapThu, String _BSChiDinh, String _NguoiThu, String _BSDoc, String _KQ, Boolean _huy, String _maMay, String _nguoiSD)
        {
            DataProvider.Instance().UpdateBenhAn_ThuPhanUngThuoc(_MaThu, _MaBA, _STT, _STTKhoa, _MaThuoc, _MaBN, _TuNgay, _DenNgay, _PhuongPhapThu, _BSChiDinh, _NguoiThu, _BSDoc, _KQ, _huy, _maMay, _nguoiSD);
            MarkOld();
        }
        /// <summary>
        /// Delete the <see cref="CslaObject" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateCslaObject
            DataProvider.Instance().DeleteBenhAn_ThuPhanUngThuoc(crit.MaMay, crit.NguoiSD, crit.MaThu);
			// public abstract void DeleteCslaObject(String _maVungLT);
			// public override void DeleteCslaObject(String _maVungLT);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maVungLT);
			// }
		}

		#endregion
	}

}
