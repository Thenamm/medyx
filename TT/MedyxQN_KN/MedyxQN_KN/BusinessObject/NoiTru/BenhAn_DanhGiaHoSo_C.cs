// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_DanhGiaHoSo_C
// Kieu doi tuong  :	BenhAn_DanhGiaHoSo_C
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	07/10/2010 09:22:49
// Nguoi tao       :	PM8
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

namespace HTC.Business.NoiTru
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="BenhAn_DanhGiaHoSo_C" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_DanhGiaHoSo_C : BusinessBase<BenhAn_DanhGiaHoSo_C>
	{
		#region Business Methods
		
		#region State Fields
        private String _maBA = String.Empty;
        private String _maDGHS = String.Empty;
        private String _tenDGHS = String.Empty;
        private int _sTTNhom = 0;
        private String _tenNhom = String.Empty;
        private Decimal _diemToiDa = 0;
        private Decimal _diemDG = 0;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private String _tENNGUOISD = String.Empty;
        private String _ghiChu = string.Empty;
        private Int32 _OrderNumber = 0;

		#endregion

        #region Business Properties and Methods

        public String MaBA
        {
            get
            {
                CanReadProperty("MaBA", true);
                return _maBA;
            }
            set
            {
                CanWriteProperty("MaBA", true);
                if (_maBA != value)
                {
                    _maBA = value;
                    PropertyHasChanged("MaBA");
                }
            }
        }
        public String MaDGHS
        {
            get
            {
                CanReadProperty("MaDGHS", true);
                return _maDGHS;
            }
            set
            {
                CanWriteProperty("MaDGHS", true);
                if (_maDGHS != value)
                {
                    _maDGHS = value;
                    PropertyHasChanged("MaDGHS");
                }
            }
        }
        public String TenDGHS
        {
            get
            {
                CanReadProperty("TenDGHS", true);
                return _tenDGHS;
            }
            set
            {
                CanWriteProperty("TenDGHS", true);
                if (_tenDGHS != value)
                {
                    _tenDGHS = value;
                    PropertyHasChanged("TenDGHS");
                }
            }
        }
        public Decimal DiemToiDa
        {
            get
            {
                CanReadProperty("DiemToiDa", true);
                return _diemToiDa;
            }
            set
            {
                CanWriteProperty("DiemToiDa", true);
                if (_diemToiDa != value)
                {
                    _diemToiDa = value;
                    PropertyHasChanged("DiemToiDa");
                }
            }
        }
        public int STTNhom
        {
            get
            {
                CanReadProperty("STTNhom", true);
                return _sTTNhom;
            }
            set
            {
                CanWriteProperty("STTNhom", true);
                if (_sTTNhom != value)
                {
                    _sTTNhom = value;
                    PropertyHasChanged("STTNhom");
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
        public Decimal DiemDG
        {
            get
            {
                CanReadProperty("DiemDG", true);
                return _diemDG;
            }
            set
            {
                CanWriteProperty("DiemDG", true);
                if (_diemDG != value)
                {
                    _diemDG = value;
                    PropertyHasChanged("DiemDG");
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
        public String TENNGUOISD
        {
            get
            {
                CanReadProperty("TENNGUOISD", true);
                return _tENNGUOISD;
            }
            set
            {
                CanWriteProperty("TENNGUOISD", true);
                if (_tENNGUOISD != value)
                {
                    _tENNGUOISD = value;
                    PropertyHasChanged("TENNGUOISD");
                }
            }
        }
        protected override Object GetIdValue()
        {
            return _maDGHS.ToString() + "!";
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
		/// Factory method. New <see cref="BenhAn_DanhGiaHoSo_C" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BenhAn_DanhGiaHoSo_C NewBenhAn_DanhGiaHoSo_C()
        {
            return new BenhAn_DanhGiaHoSo_C();
        }
        internal static BenhAn_DanhGiaHoSo_C GetBenhAn_DanhGiaHoSo_C(SafeDataReader dr, int i)
        {
            return new BenhAn_DanhGiaHoSo_C(dr, i);
        }
        public BenhAn_DanhGiaHoSo_C()
        {
            MarkAsChild();
        }
        public static BenhAn_DanhGiaHoSo_C GetBenhAn_DanhGiaHoSo_C(String maDGHS)
        {
            return DataPortal.Fetch<BenhAn_DanhGiaHoSo_C>(new Criteria(maDGHS,false ));
        }
        public static BenhAn_DanhGiaHoSo_C GetBenhAn_DanhGiaHoSo_C(SafeDataReader dr)
        {
            BenhAn_DanhGiaHoSo_C obj = new BenhAn_DanhGiaHoSo_C();
            obj.Fetch(dr);
            return obj;
        }
		/// <summary>
		/// Marks the <see cref="BenhAn_DanhGiaHoSo_C" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBenhAn_DanhGiaHoSo_C(String maBA, String maDGHS, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(maBA, maDGHS, mamay, nguoihuy));
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
            private String _maDGHS;
            public String MaDGHS
            {
                get
                {
                    return _maDGHS;
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
            private Boolean _qadmin= HTC.ShareVariables.pub_bQadmin ;
            public Boolean QAdmin
            {
                get
                {
                    return _qadmin;
                }
            }
			public Criteria(String maBA, Boolean QAdmin)
			{
				_maBA = maBA;
                _qadmin = QAdmin;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBA.Equals(c._maBA)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBA.ToString()).GetHashCode();
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
            private String _maDGHS;
            public String MaDGHS
            {
                get
                {
                    return _maDGHS;
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
            public OtherCriteria( String maBA, String maDGHS, String Mamay, String Nguoisd)
            {
                _maBA = maBA;
                _maDGHS = MaDGHS;
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
		/// Retrieve an existing <see cref="BenhAn_DanhGiaHoSo_C" /> Object based on data in the database.
		/// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetBenhAn_DanhGiaHoSo_C(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
            // public override IDataReader GetBenhAn_DanhGiaHoSo_C(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBA, _sTT, _sTTKhoa));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_DanhGiaHoSo_C(crit.MaDGHS,crit.QAdmin )))
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
		/// Load a <see cref="BenhAn_DanhGiaHoSo_C" /> Object from given SafeDataReader.
		/// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
            if (dr.GetString("MaDGHS") != null) _maDGHS = dr.GetString("MaDGHS");
            if (dr.GetString("TenDGHS") != null) _tenDGHS = dr.GetString("TenDGHS");
            if (dr.GetInt32("STTNhom") != null) _sTTNhom = dr.GetInt32("STTNhom");
            if (dr.GetString("TenNhom") != null) _tenNhom = dr.GetString("TenNhom");
            if (dr.GetDecimal("DiemToiDa") != null) _diemToiDa = dr.GetDecimal("DiemToiDa");
            if (dr.GetDecimal("DiemDG") != null) _diemDG = dr.GetDecimal("DiemDG");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("TENNGUOISD") != null) _tENNGUOISD = dr.GetString("TENNGUOISD");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
        }
		
		/// <summary>
		/// Insert the new <see cref="BenhAn_DanhGiaHoSo_C" /> Object to underlying database.
		/// </summary>
        /// 

        private BenhAn_DanhGiaHoSo_C(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
            if (dr.GetString("MaDGHS") != null) _maDGHS = dr.GetString("MaDGHS");
            if(dr.GetString("TenDGHS") != null) _tenDGHS = dr.GetString("TenDGHS");
            if (dr.GetInt32("STTNhom") != null) _sTTNhom = dr.GetInt32("STTNhom");
            if (dr.GetString("TenNhom") != null) _tenNhom = dr.GetString("TenNhom");
            if (dr.GetDecimal("DiemToiDa") != null) _diemToiDa = dr.GetDecimal("DiemToiDa");
            if (dr.GetDecimal("DiemDG") != null) _diemDG = dr.GetDecimal("DiemDG");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("TENNGUOISD") != null) _tENNGUOISD = dr.GetString("TENNGUOISD");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            MarkOld();
        }
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;


            _maBA = DataProvider.Instance().InsertBenhAn_DanhGiaHoSo_C(_maBA, _maDGHS, _diemDG, _ghiChu, _maMay, _nguoiSD);
			// public abstract String InsertBenhAn_DanhGiaHoSo_C(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap);
			// public override String InsertBenhAn_DanhGiaHoSo_C(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_DanhGiaHoSo_C_Create", _maBA, _sTT, _sTTKhoa, _maCPMau, _maBN, _ngayDK.DBValue, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _bSChiDinh, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT,_nguoiSD, _ngayTToan.DBValue, _daTra, _nguoiTra, _ngaytra.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _nguoiD, _nguoiP, _ngayD.DBValue,_maMay ,   _nguoiLap);
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAn_DanhGiaHoSo_C" /> Object to underlying database.
		/// </summary>
		internal void Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
            if (!this.IsDirty)
                return;
            
              
            DataProvider.Instance().UpdateBenhAn_DanhGiaHoSo_C(_maBA, _maDGHS, _diemDG, _ghiChu, _maMay, _huy , _nguoiSD);
				// public abstract void UpdateBenhAn_DanhGiaHoSo_C(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateBenhAn_DanhGiaHoSo_C(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_DanhGiaHoSo_C_Update", _maBA, _sTT, _sTTKhoa, _maCPMau, _maBN, _ngayDK.DBValue, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _bSChiDinh, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT,_nguoiSD, _ngayTToan.DBValue, _daTra, _nguoiTra, _ngaytra.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _nguoiD, _nguoiP, _ngayD.DBValue,_maMay ,   _huy, _nguoiSD);
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
            DataPortal_Delete(new OtherCriteria( _maBA, _maDGHS, _maMay,_nguoiSD));
            MarkNew();
        }

        private void DataPortal_Delete(OtherCriteria crit)
        {
            DataProvider.Instance().DeleteBenhAn_DanhGiaHoSo_C(crit.MaBA, crit.MaDGHS, crit.MaMay, crit.NguoiSD);
        }

		/// <summary>
		/// Delete the <see cref="BenhAn_DanhGiaHoSo_C" />.
		/// </summary>
        //protected void DataPortal_Delete(Criteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_DanhGiaHoSo_C
        //    DataProvider.Instance().DeleteBenhAn_DanhGiaHoSo_C(crit.MaBA, crit.STT, crit.STTKhoa);
        //    // public abstract void DeleteBenhAn_DanhGiaHoSo_C(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        //    // public override void DeleteBenhAn_DanhGiaHoSo_C(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_DanhGiaHoSo_C_Deleted", _maBA, _sTT, _sTTKhoa);
        //    // }
        //}

		#endregion
	}

}
