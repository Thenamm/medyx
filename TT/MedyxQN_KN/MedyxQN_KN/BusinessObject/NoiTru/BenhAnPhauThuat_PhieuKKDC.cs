using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
namespace HTC.Business.NoiTru
{		
	/// <summary>
	/// This is a base generated class of <see cref="BenhAnPhauThuat_PhieuKKDC" /> Business Object.
	/// </summary>
	[Serializable()]
	public partial class BenhAnPhauThuat_PhieuKKDC : BusinessBase<BenhAnPhauThuat_PhieuKKDC>
	{
		#region Business Methods
		
		#region State Fields
        private String _MaBA = String.Empty;
        private Int32 _STT = 0;
        private Int32 _STTKhoa = 0;
        private SmartDate _ngayKK = new SmartDate(true);
        private String _nguoiKK = String.Empty;
        private String _BSMo = String.Empty;
        private Boolean _huy = false;
        private String _maMay = String.Empty;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private String _TenNguoiKK = String.Empty;
        private String _TenBSMo = String.Empty;
        private String _TenNguoiSD = String.Empty;
        private Int32 _OrderNumber = 0;
        #endregion

        #region Business Properties and Methods

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
        public string NgayKK
        {
            get
            {
                CanReadProperty("NgayKK", true);
                return _ngayKK.Text;
            }
            set
            {
                CanWriteProperty("NgayKK", true);
                if (_ngayKK.Text != value)
                {
                    _ngayKK.Text = value;
                    PropertyHasChanged("NgaySD");
                }
            }
        }
        public String NguoiKK
        {
            get
            {
                CanReadProperty("NguoiKK", true);
                return _nguoiKK;
            }
            set
            {
                CanWriteProperty("NguoiKK", true);
                if (_nguoiKK != value)
                {
                    _nguoiKK = value;
                    PropertyHasChanged("NguoiKK");
                }
            }
        }
        public String BSMo
        {
            get
            {
                CanReadProperty("BSMo", true);
                return _BSMo;
            }
            set
            {
                CanWriteProperty("BSMo", true);
                if (_BSMo != value)
                {
                    _BSMo = value;
                    PropertyHasChanged("BSMo");
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
        public String TenNguoiKK
        {
            get
            {
                CanReadProperty("TenNguoiKK", true);
                return _TenNguoiKK;
            }
            set
            {
                CanWriteProperty("TenNguoiKK", true);
                if (_TenNguoiKK != value)
                {
                    _TenNguoiKK = value;
                    PropertyHasChanged("TenNguoiKK");
                }
            }
        }
        public String TenBSMo
        {
            get
            {
                CanReadProperty("TenBSMo", true);
                return _TenBSMo;
            }
            set
            {
                CanWriteProperty("TenBSMo", true);
                if (_TenBSMo != value)
                {
                    _TenBSMo = value;
                    PropertyHasChanged("TenBSMo");
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
        protected override Object GetIdValue()
        {
            return _MaBA.ToString() + "!";
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
		/// Factory method. New <see cref="BenhAnPhauThuat_PhieuKKDC" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BenhAnPhauThuat_PhieuKKDC NewBenhAnPhauThuat_PhieuKKDC()
        {
            return new BenhAnPhauThuat_PhieuKKDC();
        }
        internal static BenhAnPhauThuat_PhieuKKDC GetBenhAnPhauThuat_PhieuKKDC(SafeDataReader dr, int i)
        {
            return new BenhAnPhauThuat_PhieuKKDC(dr, i);
        }
        public BenhAnPhauThuat_PhieuKKDC()
        {
            MarkAsChild();
        }
        public static BenhAnPhauThuat_PhieuKKDC GetAllBenhAnPhauThuat_PhieuKKDC(String maBA, int stt, int sttkhoa)
        {
            return DataPortal.Fetch<BenhAnPhauThuat_PhieuKKDC>(new Criteria(maBA,stt, sttkhoa));
        }
        public static BenhAnPhauThuat_PhieuKKDC GetBenhAnPhauThuat_PhieuKKDC(SafeDataReader dr)
        {
            BenhAnPhauThuat_PhieuKKDC obj = new BenhAnPhauThuat_PhieuKKDC();
            obj.Fetch(dr);
            return obj;
        }
		/// <summary>
		/// Marks the <see cref="BenhAnPhauThuat_PhieuKKDC" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBenhAnPhauThuat_PhieuKKDC(String maBA, int stt, int sttkhoa, String Mamay, String Nguoisd)
        {
            DataPortal.Delete(new OtherCriteria(maBA, stt, sttkhoa, Mamay, Nguoisd));
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
            public OtherCriteria( String maBA, int stt, int sttkhoa,String Mamay, String Nguoisd)
            {
                _maBA = maBA;
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
		/// Retrieve an existing <see cref="BenhAnPhauThuat_PhieuKKDC" /> Object based on data in the database.
		/// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetBenhAnPhauThuat_PhieuKKDC(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
            // public override IDataReader GetBenhAnPhauThuat_PhieuKKDC(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBA, _sTT, _sTTKhoa));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_PhauThuat_PhieuKKDC(crit.MaBA,crit.STT,crit.STTKhoa )))
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
		/// Load a <see cref="BenhAnPhauThuat_PhieuKKDC" /> Object from given SafeDataReader.
		/// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("MaBA") != null) _MaBA = dr.GetString("MaBA");
            if (dr.GetInt32("STT") != null) _STT = dr.GetInt32("STT");
            if (dr.GetInt32("STTKhoa") != null) _STTKhoa = dr.GetInt32("STTKhoa");
            if (dr.GetSmartDate("NgayKK", true) != null) _ngayKK = dr.GetSmartDate("NgayKK", true);
            if (dr.GetString("NguoiKK") != null) _nguoiKK = dr.GetString("NguoiKK");
            if (dr.GetString("BSMo") != null) _BSMo = dr.GetString("BSMo");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("TenNguoiKK") != null) _TenNguoiKK = dr.GetString("TenNguoiKK");
            if (dr.GetString("TenBSMo") != null) _TenBSMo = dr.GetString("TenBSMo");
            if (dr.GetString("TenNguoiSD") != null) _TenNguoiSD = dr.GetString("TenNguoiSD");
        }
		
		/// <summary>
		/// Insert the new <see cref="BenhAnPhauThuat_PhieuKKDC" /> Object to underlying database.
		/// </summary>
        /// 

        private BenhAnPhauThuat_PhieuKKDC(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaBA") != null) _MaBA = dr.GetString("MaBA");
            if (dr.GetInt32("STT") != null) _STT = dr.GetInt32("STT");
            if (dr.GetInt32("STTKhoa") != null) _STTKhoa = dr.GetInt32("STTKhoa");
            if (dr.GetSmartDate("NgayKK", true) != null) _ngayKK = dr.GetSmartDate("NgayKK", true);
            if (dr.GetString("NguoiKK") != null) _nguoiKK = dr.GetString("NguoiKK");
            if (dr.GetString("BSMo") != null) _BSMo = dr.GetString("BSMo");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("TenNguoiKK") != null) _TenNguoiKK = dr.GetString("TenNguoiKK");
            if (dr.GetString("TenBSMo") != null) _TenBSMo = dr.GetString("TenBSMo");
            if (dr.GetString("TenNguoiSD") != null) _TenNguoiSD = dr.GetString("TenNguoiSD");
            MarkOld();
        }
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;


            _MaBA = DataProvider.Instance().InsertBenhAn_PhauThuat_PhieuKKDC(_MaBA, _STT , _STTKhoa , _ngayKK.Date , _nguoiKK , _BSMo , _maMay , _nguoiSD);
			// public abstract String InsertBenhAnPhauThuat_PhieuKKDC(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap);
			// public override String InsertBenhAnPhauThuat_PhieuKKDC(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAnPhauThuat_PhieuKKDC_Create", _maBA, _sTT, _sTTKhoa, _maCPMau, _maBN, _ngayDK.DBValue, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _bSChiDinh, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT,_nguoiSD, _ngayTToan.DBValue, _daTra, _nguoiTra, _ngaytra.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _nguoiD, _nguoiP, _ngayD.DBValue,_maMay ,   _nguoiLap);
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAnPhauThuat_PhieuKKDC" /> Object to underlying database.
		/// </summary>
		internal void Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
            if (!this.IsDirty)
                return;


            DataProvider.Instance().UpdateBenhAn_PhauThuat_PhieuKKDC(_MaBA, _STT, _STTKhoa, _ngayKK.Date, _nguoiKK, _BSMo, _maMay, _nguoiSD, _huy);
				// public abstract void UpdateBenhAnPhauThuat_PhieuKKDC(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateBenhAnPhauThuat_PhieuKKDC(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAnPhauThuat_PhieuKKDC_Update", _maBA, _sTT, _sTTKhoa, _maCPMau, _maBN, _ngayDK.DBValue, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _bSChiDinh, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT,_nguoiSD, _ngayTToan.DBValue, _daTra, _nguoiTra, _ngaytra.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _nguoiD, _nguoiP, _ngayD.DBValue,_maMay ,   _huy, _nguoiSD);
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
            DataPortal_Delete(new OtherCriteria(_MaBA, _STT, _STTKhoa, _maMay, _nguoiSD));
            MarkNew();
        }

        private void DataPortal_Delete(OtherCriteria crit)
        {
            DataProvider.Instance().DeleteBenhAn_PhauThuat_PhieuKKDC(crit.MaBA, crit.STT,crit.STTKhoa, crit.MaMay, crit.NguoiSD);
        }
		#endregion
	}
}
