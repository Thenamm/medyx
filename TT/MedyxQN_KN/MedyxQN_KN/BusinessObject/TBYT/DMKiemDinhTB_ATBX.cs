// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMKiemDinh_ATBX
// Kieu doi tuong  :	DMKiemDinh_ATBX
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	11/20/2008 2:34:50 PM
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
	/// This is a base generated class of <see cref="DMKiemDinh_ATBX" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMKiemDinh_ATBX : BusinessBase<DMKiemDinh_ATBX>
	{
        #region Business Methods

        #region State Fields
        private String _MaKD = String.Empty;
        private String _MaTB = String.Empty;
        private String _MaGP = String.Empty;
        private SmartDate _NgayKD = new SmartDate(false);
        private SmartDate _NgayHetHanKD = new SmartDate(false);
        private String _HoatDo = String.Empty;
        private Boolean _SuDung = false;
        private String _KQKiemDinh = String.Empty;
        private byte _TTKhaiBao = 0;
        private String _GhiChu = String.Empty;
        private Boolean _huy = false;
        private String _maMay = String.Empty;
        private SmartDate _ngaySD = new SmartDate(false);
        private String _nguoiSD = String.Empty;
        private String _TenTBYT = String.Empty;
        private String _MaKhoa = String.Empty;
        private String _TenKhoa = String.Empty;
        private SmartDate _NgayCap = new SmartDate(false);
        private SmartDate _NgayHetHan = new SmartDate(false);
        private String _NoiCap = String.Empty;
        private String _TenTTKhaiBao = String.Empty;
        private String _hoten = String.Empty;
        private String _SoGP = String.Empty;
        private int _OrderNumber;
        #endregion

        #region Business Properties and Methods
        public String MaKD
        {
            get
            {
                CanReadProperty("MaKD", true);
                return _MaKD;
            }
            set
            {
                CanWriteProperty("MaKD", true);
                if (_MaKD != value)
                {
                    _MaKD = value;
                    PropertyHasChanged("MaKD");
                }
            }
        }
        public String MaTB
		{
			get 
			{
				CanReadProperty("MaTB", true);
				return _MaTB;
			}
			set 
			{
				CanWriteProperty("MaTB", true);
				if (_MaTB != value) 
				{
                    _MaTB = value;
					PropertyHasChanged("MaTB");
				}
			}
		}
        public String MaGP
        {
            get
            {
                CanReadProperty("MaGP", true);
                return _MaGP;
            }
            set
            {
                CanWriteProperty("MaGP", true);
                if (_MaGP != value)
                {
                    _MaGP = value;
                    PropertyHasChanged("MaGP");
                }
            }
        }
        public SmartDate NgayKD
        {
            get
            {
                CanReadProperty("NgayKD", true);
                _NgayKD.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _NgayKD;
            }
            set
            {
                CanWriteProperty("NgayKD", true);
                if (_NgayKD != value)
                {
                    _NgayKD = value;
                    PropertyHasChanged("NgayKD");
                }
            }
        }
        public SmartDate NgayHetHanKD
        {
            get
            {
                CanReadProperty("NgayHetHanKD", true);
                _NgayHetHanKD.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _NgayHetHanKD;
            }
            set
            {
                CanWriteProperty("NgayHetHanKD", true);
                if (_NgayHetHanKD != value)
                {
                    _NgayHetHanKD = value;
                    PropertyHasChanged("NgayHetHanKD");
                }
            }
        }
        public string txtNgayKD
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _NgayKD.ToString();
            }
        }
        public string txtNgayHetHanKD
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _NgayHetHanKD.ToString();
            }
        }
        public String HoatDo
        {
            get
            {
                CanReadProperty("HoatDo", true);
                return _HoatDo;
            }
            set
            {
                CanWriteProperty("HoatDo", true);
                if (_HoatDo != value)
                {
                    _HoatDo = value;
                    PropertyHasChanged("HoatDo");
                }
            }
        }
        public Boolean SuDung
        {
            get
            {
                CanReadProperty("SuDung", true);
                return _SuDung;
            }
            set
            {
                CanWriteProperty("SuDung", true);
                if (_SuDung != value)
                {
                    _SuDung = value;
                    PropertyHasChanged("SuDung");
                }
            }
        }
        public String KQKiemDinh
        {
            get
            {
                CanReadProperty("KQKiemDinh", true);
                return _KQKiemDinh;
            }
            set
            {
                CanWriteProperty("KQKiemDinh", true);
                if (_KQKiemDinh != value)
                {
                    _KQKiemDinh = value;
                    PropertyHasChanged("KQKiemDinh");
                }
            }
        }
        public byte TTKhaiBao
        {
            get
            {
                CanReadProperty("TTKhaiBao", true);
                return _TTKhaiBao;
            }
            set
            {
                CanWriteProperty("TTKhaiBao", true);
                if (_TTKhaiBao != value)
                {
                    _TTKhaiBao = value;
                    PropertyHasChanged("TTKhaiBao");
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
        public String TenTBYT
        {
            get
            {
                CanReadProperty("TenTBYT", true);
                return _TenTBYT;
            }
            set
            {
                CanWriteProperty("TenTBYT", true);
                if (_TenTBYT != value)
                {
                    _TenTBYT = value;
                    PropertyHasChanged("TenTBYT");
                }
            }
        }
        public String MaKhoa
		{
			get 
			{
                CanReadProperty("MaKhoa", true);
				return _MaKhoa;
			}
			set 
			{
                CanWriteProperty("MaKhoa", true);
				if (_MaKhoa != value) 
				{
                    _MaKhoa = value;
                    PropertyHasChanged("MaKhoa");
				}
			}
		}
        public String TenKhoa
        {
            get
            {
                CanReadProperty("TenKhoa", true);
                return _TenKhoa;
            }
            set
            {
                CanWriteProperty("TenKhoa", true);
                if (_TenKhoa != value)
                {
                    _TenKhoa = value;
                    PropertyHasChanged("TenKhoa");
                }
            }
        }
        public SmartDate NgayCap
        {
            get
            {
                CanReadProperty("NgayCap", true);
                _NgayCap.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _NgayCap;
            }
            set
            {
                CanWriteProperty("NgayCap", true);
                if (_NgayCap != value)
                {
                    _NgayCap = value;
                    PropertyHasChanged("NgayCap");
                }
            }
        }
        public SmartDate NgayHetHan
        {
            get
            {
                CanReadProperty("NgayHetHan", true);
                _NgayHetHan.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _NgayHetHan;
            }
            set
            {
                CanWriteProperty("NgayHetHan", true);
                if (_NgayHetHan != value)
                {
                    _NgayHetHan = value;
                    PropertyHasChanged("NgayHetHan");
                }
            }
        }
        public String NoiCap
        {
            get
            {
                CanReadProperty("NoiCap", true);
                return _NoiCap;
            }
            set
            {
                CanWriteProperty("NoiCap", true);
                if (_NoiCap != value)
                {
                    _NoiCap = value;
                    PropertyHasChanged("NoiCap");
                }
            }
        }
        public String TenTTKhaiBao
        {
            get
            {
                CanReadProperty("TenTTKhaiBao", true);
                return _TenTTKhaiBao;
            }
            set
            {
                CanWriteProperty("TenTTKhaiBao", true);
                if (_TenTTKhaiBao != value)
                {
                    _TenTTKhaiBao = value;
                    PropertyHasChanged("TenTTKhaiBao");
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
        public String SoGP
        {
            get
            {
                CanReadProperty("SoGP", true);
                return _SoGP;
            }
            set
            {
                CanWriteProperty("SoGP", true);
                if (_SoGP != value)
                {
                    _SoGP = value;
                    PropertyHasChanged("SoGP");
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
			return _MaKD;
		}
		
		#endregion
		#endregion

		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {
            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("MaKD", 10));
            ValidationRules.AddRule<DMKiemDinh_ATBX>(StringRequired<DMKiemDinh_ATBX>, "MaKD");
        }
        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMKiemDinh_ATBX
        {

            if (target._MaKD == null || target._MaKD.Trim().Length == 0)
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
		/// Factory method. New <see cref="DMKiemDinh_ATBX" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMKiemDinh_ATBX NewDMKiemDinh_ATBX()
        {
            return DataPortal.Create<DMKiemDinh_ATBX>();
        }
		public static DMKiemDinh_ATBX GetDMKiemDinh_ATBX_ByID(String MaKD)
		{
			return DataPortal.Fetch<DMKiemDinh_ATBX>(new Criteria(MaKD));
		}
        /// <summary>
        /// Marks the <see cref="DMKiemDinh_ATBX" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteDMKiemDinh_ATBX(String MaKD, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,MaKD));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMKiemDinh_ATBX()
		{	
			// Prevent direct creation
		}
        internal DMKiemDinh_ATBX(String MaKD,String MaTB,String MaGP,SmartDate NgayKD,SmartDate NgayHetHanKD,String HoatDo,Boolean SuDung,
String KQKiemDinh,byte TTKhaiBao,String GhiChu,Boolean huy,String maMay,SmartDate ngaySD,String nguoiSD,String TenTBYT,String MaKhoa,
String TenKhoa,SmartDate NgayCap,SmartDate NgayHetHan,String NoiCap,String TenTTKhaiBao,String hoten, String SoGP,int OrderNumber
)
        {
            _MaKD = MaKD;
            _MaTB = MaTB;
            _MaGP = MaGP;
            _NgayKD = NgayKD;
            _NgayHetHanKD = NgayHetHanKD;
            _HoatDo = HoatDo;
            _SuDung = SuDung;
            _KQKiemDinh = KQKiemDinh;
            _TTKhaiBao = TTKhaiBao;
            _GhiChu = GhiChu;
            _huy = huy;
            _maMay = maMay;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD;
            _TenTBYT = TenTBYT;
            _MaKhoa = MaKhoa;
            _TenKhoa = TenKhoa;
            _NgayCap = NgayCap;
            _NgayHetHan = NgayHetHan;
            _NoiCap = NoiCap;
            _TenTTKhaiBao = TenTTKhaiBao;
            _hoten = hoten;
            _SoGP = SoGP;
            _OrderNumber = OrderNumber;
        }
        #endregion

        #region Criteria

        [Serializable()]
		protected class Criteria
		{
			private String _MaKD;
			public String MaKD 
			{
				get
				{
					return _MaKD;
				}
			}
			
			public Criteria(String MaKD)
			{
				_MaKD = MaKD;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_MaKD.Equals(c._MaKD)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _MaKD.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaKD;
            public String MaKD
            {
                get
                {
                    return _MaKD;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaKD)
            {
                _MaKD = MaKD;
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
		/// Retrieve an existing <see cref="DMKiemDinh_ATBX" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMKiemDinh_ATBX(String _MaKD);
			// public override IDataReader GetDMKiemDinh_ATBX(String _MaKD)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaKD));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMKiemDinh_ATBX(crit.MaKD)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
        /// <summary>
        /// Load a <see cref="DMKiemDinh_ATBX" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
		{
            // Value properties
            if (dr.GetString("MaKD") != null) _MaKD = dr.GetString("MaKD");
            if (dr.GetString("MaTB") != null) _MaTB = dr.GetString("MaTB");
            if (dr.GetString("MaGP") != null) _MaGP = dr.GetString("MaGP");
            if (dr.GetSmartDate("NgayKD", false) != null) _NgayKD = dr.GetSmartDate("NgayKD", false);
            if (dr.GetSmartDate("NgayHetHanKD", false) != null) _NgayHetHanKD = dr.GetSmartDate("NgayHetHanKD", false);
            if (dr.GetString("HoatDo") != null) _HoatDo = dr.GetString("HoatDo");
            if (dr.GetBoolean("SuDung") != null) _SuDung = dr.GetBoolean("SuDung");
            if (dr.GetString("KQKiemDinh") != null) _KQKiemDinh = dr.GetString("KQKiemDinh");
            if (dr.GetByte("TTKhaiBao") != null) _TTKhaiBao = dr.GetByte("TTKhaiBao");
            if (dr.GetString("GhiChu") != null) _GhiChu = dr.GetString("GhiChu");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetSmartDate("NgaySD", false) != null) _ngaySD = dr.GetSmartDate("NgaySD", false);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("TenTBYT") != null) _TenTBYT = dr.GetString("TenTBYT");
            if (dr.GetString("MaKhoa") != null) _MaKhoa = dr.GetString("MaKhoa");
            if (dr.GetString("TenKhoa") != null) _TenKhoa = dr.GetString("TenKhoa");
            if (dr.GetSmartDate("NgayCap", false) != null) _NgayCap = dr.GetSmartDate("NgayCap", false);
            if (dr.GetString("NoiCap") != null) _NoiCap = dr.GetString("NoiCap");
            if (dr.GetSmartDate("NgayHetHan", false) != null) _NgayHetHan = dr.GetSmartDate("NgayHetHan", false);
            if (dr.GetString("HoTen") != null) _hoten = dr.GetString("HoTen");
            if (dr.GetString("SoGP") != null) _SoGP = dr.GetString("SoGP");
            if (dr.GetString("TenTTKhaiBao") != null) _TenTTKhaiBao = dr.GetString("TenTTKhaiBao");
        }
		
		/// <summary>
		/// Insert the new <see cref="DMKiemDinh_ATBX" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMKiemDinh_ATBX
			// Copy & paste ham duoi day vao file DataProvider.cs
            _MaKD = DataProvider.Instance().InsertDMKiemDinh_ATBX( _MaTB,  _MaGP
           ,  _NgayKD.Date
           ,  _NgayHetHanKD.Date
           ,  _HoatDo
           ,  _SuDung
           ,  _KQKiemDinh
           ,  _TTKhaiBao
           ,  _GhiChu);
			// public abstract String InsertDMKiemDinh_ATBX(String _tenKiemDinh_ATBX, String _maMay, String _nguoiSD);
			// public override String InsertDMKiemDinh_ATBX(String _tenKiemDinh_ATBX, String _maMay, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenKiemDinh_ATBX, _maMay,  _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMKiemDinh_ATBX" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMKiemDinh_ATBX
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateDMKiemDinh_ATBX(_MaKD,
_MaGP,
_MaTB,
     _NgayKD.Date,
     _NgayHetHanKD.Date,
      _HoatDo,
      _SuDung,
      _KQKiemDinh,
      _TTKhaiBao,
      _GhiChu,
      _huy,
      _maMay,
      _nguoiSD);
				// public abstract void UpdateDMKiemDinh_ATBX(String _MaKD, String _tenKiemDinh_ATBX, String _maMay, String _nguoiSD);
				// public override void UpdateDMKiemDinh_ATBX(String _MaKD, String _tenKiemDinh_ATBX, String _maMay, String _nguoiSD);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaKD, _tenKiemDinh_ATBX, _maMay,  _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _MaKD));
		}

		/// <summary>
		/// Delete the <see cref="DMKiemDinh_ATBX" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMKiemDinh_ATBX
            DataProvider.Instance().DeleteDMKiemDinh_ATBX( crit.MaMay, crit.NguoiSD, crit.MaKD);
			// public abstract void DeleteDMKiemDinh_ATBX(String _MaKD);
			// public override void DeleteDMKiemDinh_ATBX(String _MaKD);
			// {
			//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaKD);
			// }
		}

		#endregion
	}

}
