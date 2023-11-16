using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
namespace HTC.Business.NoiTru
{		
	/// <summary>
	/// This is a base generated class of <see cref="BenhAnPhauThuat_DungCuMo" /> Business Object.
	/// </summary>
	[Serializable()]
	public partial class BenhAnPhauThuat_DungCuMo : BusinessBase<BenhAnPhauThuat_DungCuMo>
	{
		#region Business Methods
		
		#region State Fields
        private String _MaDungCu = String.Empty;
        private String _TenDC = String.Empty;
        private String _MaBA = String.Empty;
        private Int32 _STT = 0;
        private Int32 _STTKhoa = 0;
        private String _MaDC = String.Empty;
        private Int32 _SLTruoc = 0;
        private Int32 _SLSau = 0;
        private String _ghiChu = string.Empty;
        private Boolean _huy = false;
        private String _maMay = String.Empty;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private String _HoTen = String.Empty;
        private String _MaDVT = String.Empty;
        private String _TenDVT = String.Empty;
        private Int32 _OrderNumber = 0;
        #endregion

        #region Business Properties and Methods

        public String MaDungCu
        {
            get
            {
                CanReadProperty("MaDungCu", true);
                return _MaDungCu;
            }
            set
            {
                CanWriteProperty("MaDungCu", true);
                if (_MaDungCu != value)
                {
                    _MaDungCu = value;
                    PropertyHasChanged("MaDungCu");
                }
            }
        }
        public String TenDC
        {
            get
            {
                CanReadProperty("TenDC", true);
                return _TenDC;
            }
            set
            {
                CanWriteProperty("TenDC", true);
                if (_TenDC != value)
                {
                    _TenDC = value;
                    PropertyHasChanged("TenDC");
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
        public String MaDC
        {
            get
            {
                CanReadProperty("MaDC", true);
                return _MaDC;
            }
            set
            {
                CanWriteProperty("MaDC", true);
                if (_MaDC != value)
                {
                    _MaDC = value;
                    PropertyHasChanged("MaDC");
                }
            }
        }
        public Int32 SLTruoc
        {
            get
            {
                CanReadProperty("SLTruoc", true);
                return _SLTruoc;
            }
            set
            {
                CanWriteProperty("SLTruoc", true);
                if (_SLTruoc != value)
                {
                    _SLTruoc = value;
                    PropertyHasChanged("SLTruoc");
                }
            }
        }
        public Int32 SLSau
        {
            get
            {
                CanReadProperty("SLSau", true);
                return _SLSau;
            }
            set
            {
                CanWriteProperty("SLSau", true);
                if (_SLSau != value)
                {
                    _SLSau = value;
                    PropertyHasChanged("SLSau");
                }
            }
        }
        public String GhiChu
        {
            get
            {
                CanReadProperty("GhiChu", true);
                return _ghiChu;
            }
            set
            {
                CanWriteProperty("GhiChu", true);
                if (_ghiChu != value)
                {
                    _ghiChu = value;
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
        public String HoTen
        {
            get
            {
                CanReadProperty("HoTen", true);
                return _HoTen;
            }
            set
            {
                CanWriteProperty("HoTen", true);
                if (_HoTen != value)
                {
                    _HoTen = value;
                    PropertyHasChanged("HoTen");
                }
            }
        }
        public String MaDVT
        {
            get
            {
                CanReadProperty("MaDVT", true);
                return _MaDVT;
            }
            set
            {
                CanWriteProperty("MaDVT", true);
                if (_MaDVT != value)
                {
                    _MaDVT = value;
                    PropertyHasChanged("MaDVT");
                }
            }
        }
        public String TenDVT
        {
            get
            {
                CanReadProperty("TenDVT", true);
                return _TenDVT;
            }
            set
            {
                CanWriteProperty("TenDVT", true);
                if (_TenDVT != value)
                {
                    _TenDVT = value;
                    PropertyHasChanged("TenDVT");
                }
            }
        }
        protected override Object GetIdValue()
        {
            return _MaDC.ToString() + _MaBA + _STT.ToString() + STTKhoa.ToString() + "!";
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
        #endregion
       
		#endregion

		#region Business Object Rules and Validation
        //protected override void AddBusinessRules()
        //{
        //TODO: add validation rules

        //ValidationRules.AddRule<BenhAn_ThuocSD>(ValidationTuNgayDenNgay<BenhAn_ThuocSD>, "TuNgay");
        //ValidationRules.AddRule<BenhAn_ThuocSD>(ValidationTuNgayDenNgay<BenhAn_ThuocSD>, "DenNgay");
        //ValidationRules.AddRule<BenhAn_ThuocSD>(ValidationNgayDKDenNgay<BenhAn_ThuocSD>, "DenNgay");
        //ValidationRules.AddRule<BenhAn_ThuocSD>(ValidationNgayDKDenNgay<BenhAn_ThuocSD>, "NgayDK");
        //ValidationRules.AddDependantProperty("TuNgay", "DenNgay");
        //ValidationRules.AddDependantProperty("DenNgay", "NgayDK");

        //}

        //private static bool ValidationNgaySinh<T>(T target, Csla.Validation.RuleArgs e) where T : BenhAn_Chamsoc
        //{
        //    if (target._tuNgay.Date > System.DateTime.Now.AddDays(1))
        //    {
        //        e.Description = "VALIDATION_NOW";
        //        return false;
        //    }
        //    else
        //        return true;
        //}
        //private static bool ValidationNgayDKDenNgay<T>(T target, Csla.Validation.RuleArgs e) where T : BenhAn_ThuocSD
        //{
        //    if (target._ngayDK > target._DenNgay)
        //    {
        //        e.Description = "Ngày lĩnh không được lớn hơn đến ngày";
        //        return false;
        //    }
        //    else
        //        return true;
        //}
        //private static bool ValidationTuNgayDenNgay<T>(T target, Csla.Validation.RuleArgs e) where T : BenhAn_ThuocSD
        //{
        //    if (target._TuNgay > target._DenNgay)
        //    {
        //        e.Description = "Từ ngày không được lớn hơn đến ngày";
        //        return false;
        //    }
        //    else
        //        return true;
        //}
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhAnPhauThuat_DungCuMo" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BenhAnPhauThuat_DungCuMo NewBenhAnPhauThuat_DungCuMo()
        {
            return new BenhAnPhauThuat_DungCuMo();
        }
        internal static BenhAnPhauThuat_DungCuMo GetBenhAnPhauThuat_DungCuMo(SafeDataReader dr, int i)
        {
            return new BenhAnPhauThuat_DungCuMo(dr, i);
        }
        public BenhAnPhauThuat_DungCuMo()
        {
            MarkAsChild();
        }
        public static BenhAnPhauThuat_DungCuMo GetAllBenhAnPhauThuat_DungCuMo(String maBA, int stt, int sttkhoa)
        {
            return DataPortal.Fetch<BenhAnPhauThuat_DungCuMo>(new Criteria(maBA,stt, sttkhoa));
        }
        public static BenhAnPhauThuat_DungCuMo GetBenhAnPhauThuat_DungCuMo(SafeDataReader dr)
        {
            BenhAnPhauThuat_DungCuMo obj = new BenhAnPhauThuat_DungCuMo();
            obj.Fetch(dr);
            return obj;
        }
		/// <summary>
		/// Marks the <see cref="BenhAnPhauThuat_DungCuMo" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBenhAnPhauThuat_DungCuMo(String maBA, int stt, int sttkhoa, string maDC, String Mamay, String Nguoisd)
        {
            DataPortal.Delete(new OtherCriteria(maBA, stt, sttkhoa, maDC, Mamay, Nguoisd));
        }
		
		#endregion
		
		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maBA;
			public String MaBA 
			{
				get
				{
					return _maBA;
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
			
			private Int32 _sTTKhoa;
			public Int32 STTKhoa 
			{
				get
				{
					return _sTTKhoa;
				}
			}
			public Criteria(String maBA, int stt, int sttkhoa)
			{
				_maBA = maBA;
                _sTT = stt;
                _sTTKhoa = sttkhoa;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBA.Equals(c._maBA)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					if (!_sTTKhoa.Equals(c._sTTKhoa)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBA.ToString(), _sTT.ToString(), _sTTKhoa.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maBA;
            public String MaBA
            {
                get
                {
                    return _maBA;
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

            private Int32 _sTTKhoa;
            public Int32 STTKhoa
            {
                get
                {
                    return _sTTKhoa;
                }
            }
            private String _MaDC;
            public String MaDC
            {
                get
                {
                    return _MaDC;
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
            public OtherCriteria( String maBA, int stt, int sttkhoa, string maDC,String Mamay, String Nguoisd)
            {
                _maBA = maBA;
                _MaDC = maDC;
                _sTT = stt;
                _sTTKhoa = sttkhoa;
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
		/// Retrieve an existing <see cref="BenhAnPhauThuat_DungCuMo" /> Object based on data in the database.
		/// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetBenhAnPhauThuat_DungCuMo(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
            // public override IDataReader GetBenhAnPhauThuat_DungCuMo(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBA, _sTT, _sTTKhoa));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_PhauThuat_DungCuMo(crit.MaBA,crit.STT,crit.STTKhoa )))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    MarkOld();
                    ValidationRules.CheckRules();
                }
            }
        }
		/// <summary>
		/// Load a <see cref="BenhAnPhauThuat_DungCuMo" /> Object from given SafeDataReader.
		/// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("MaDungCu") != null) _MaDungCu = dr.GetString("MaDungCu");
            if (dr.GetString("TenDC") != null) _TenDC = dr.GetString("TenDC");
            if (dr.GetString("MaBA") != null) _MaBA = dr.GetString("MaBA");
            if (dr.GetInt32("STT") != null) _STT = dr.GetInt32("STT");
            if (dr.GetInt32("STTKhoa") != null) _STTKhoa = dr.GetInt32("STTKhoa");
            if (dr.GetString("MaDC") != null) _MaDC = dr.GetString("MaDC");
            if (dr.GetInt32("SLTruoc") != null) _SLTruoc = dr.GetInt32("SLTruoc");
            if (dr.GetInt32("SLSau") != null) _SLSau = dr.GetInt32("SLSau");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("HoTen") != null) _HoTen = dr.GetString("HoTen");
            if (dr.GetString("MaDVT") != null) _MaDVT = dr.GetString("MaDVT");
            if (dr.GetString("TenDVT") != null) _TenDVT = dr.GetString("TenDVT");
        }
		
		/// <summary>
		/// Insert the new <see cref="BenhAnPhauThuat_DungCuMo" /> Object to underlying database.
		/// </summary>
        /// 

        private BenhAnPhauThuat_DungCuMo(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaDungCu") != null) _MaDungCu = dr.GetString("MaDungCu");
            if (dr.GetString("TenDC") != null) _TenDC = dr.GetString("TenDC");
            if (dr.GetString("MaBA") != null) _MaBA = dr.GetString("MaBA");
            if (dr.GetInt32("STT") != null) _STT = dr.GetInt32("STT");
            if (dr.GetInt32("STTKhoa") != null) _STTKhoa = dr.GetInt32("STTKhoa");
            if (dr.GetString("MaDC") != null) _MaDC = dr.GetString("MaDC");
            if (dr.GetInt32("SLTruoc") != null) _SLTruoc = dr.GetInt32("SLTruoc");
            if (dr.GetInt32("SLSau") != null) _SLSau = dr.GetInt32("SLSau");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("HoTen") != null) _HoTen = dr.GetString("HoTen");
            if (dr.GetString("MaDVT") != null) _MaDVT = dr.GetString("MaDVT");
            if (dr.GetString("TenDVT") != null) _TenDVT = dr.GetString("TenDVT");
            MarkOld();
        }
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;


            _MaBA = DataProvider.Instance().InsertBenhAn_PhauThuat_DungCuMo(_MaBA, _STT, _STTKhoa, _MaDungCu, _SLTruoc, _SLSau, _ghiChu);
			// public abstract String InsertBenhAnPhauThuat_DungCuMo(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap);
			// public override String InsertBenhAnPhauThuat_DungCuMo(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAnPhauThuat_DungCuMo_Create", _maBA, _sTT, _sTTKhoa, _maCPMau, _maBN, _ngayDK.DBValue, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _bSChiDinh, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT,_nguoiSD, _ngayTToan.DBValue, _daTra, _nguoiTra, _ngaytra.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _nguoiD, _nguoiP, _ngayD.DBValue,_maMay ,   _nguoiLap);
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAnPhauThuat_DungCuMo" /> Object to underlying database.
		/// </summary>
		internal void Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
            if (!this.IsDirty)
                return;


            DataProvider.Instance().UpdateBenhAn_PhauThuat_DungCuMo(_MaBA, _STT, _STTKhoa, _MaDC, _SLTruoc, _SLSau, _ghiChu, _huy, _maMay, _nguoiSD);
				// public abstract void UpdateBenhAnPhauThuat_DungCuMo(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateBenhAnPhauThuat_DungCuMo(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAnPhauThuat_DungCuMo_Update", _maBA, _sTT, _sTTKhoa, _maCPMau, _maBN, _ngayDK.DBValue, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _bSChiDinh, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT,_nguoiSD, _ngayTToan.DBValue, _daTra, _nguoiTra, _ngaytra.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _nguoiD, _nguoiP, _ngayD.DBValue,_maMay ,   _huy, _nguoiSD);
				// }	
                MarkOld();
			
		}
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            // _nguoiHuy = _nguoiHuy!=""?_nguoiHuy :  HTC.ShareVariables.pub_sNguoiSD;
            DataPortal_Delete(new OtherCriteria(_MaBA, _STT, _STTKhoa, _MaDC, _maMay, _nguoiSD));
            MarkNew();
        }

        private void DataPortal_Delete(OtherCriteria crit)
        {
            DataProvider.Instance().DeleteBenhAn_PhauThuat_DungCuMo(crit.MaBA, crit.STT,crit.STTKhoa,crit.MaDC, crit.MaMay, crit.NguoiSD);
        }

		/// <summary>
		/// Delete the <see cref="BenhAnPhauThuat_DungCuMo" />.
		/// </summary>
        //protected void DataPortal_Delete(Criteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAnPhauThuat_DungCuMo
        //    DataProvider.Instance().DeleteBenhAnPhauThuat_DungCuMo(crit.MaBA, crit.STT, crit.STTKhoa);
        //    // public abstract void DeleteBenhAnPhauThuat_DungCuMo(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        //    // public override void DeleteBenhAnPhauThuat_DungCuMo(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAnPhauThuat_DungCuMo_Deleted", _maBA, _sTT, _sTTKhoa);
        //    // }
        //}

		#endregion
	}
}
