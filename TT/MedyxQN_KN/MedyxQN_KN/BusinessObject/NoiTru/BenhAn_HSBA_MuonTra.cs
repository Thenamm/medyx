// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_HSBA_MuonTra
// Kieu doi tuong  :	BenhAn_HSBA_MuonTra
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
	/// This is a base generated class of <see cref="BenhAn_HSBA_MuonTra" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_HSBA_MuonTra : BusinessBase<BenhAn_HSBA_MuonTra>
	{
        #region Business Methods
        #region State Fields
        private String _MaMuon = String.Empty;
        private String _maBA = String.Empty;
        private Boolean _Muon = false;
        private SmartDate _NgayMuon = new SmartDate(true);
        private SmartDate _NgayTra = new SmartDate(true);
        private String _NguoiMuon = String.Empty;
        private String _KhoaMuon = String.Empty;
        private String _ghiChu = string.Empty;
        private SmartDate _ngayLap = new SmartDate(true);
        private String _nguoiLap = String.Empty;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private SmartDate _ngayHuy = new SmartDate(true);
        private String _nguoiHuy = String.Empty;
        private Boolean _huy = false;
        private String _maMay = String.Empty;
        private Int32 _OrderNumber = 0;
        private String _TenNguoiMuon = String.Empty;
        private String _TenKhoaMuon = String.Empty;
        #endregion
        #region Business Properties and Methods
        public String MaMuon
        {
            get
            {
                CanReadProperty("MaMuon", true);
                return _MaMuon;
            }
            set
            {
                CanWriteProperty("MaMuon", true);
                if (_MaMuon != value)
                {
                    _MaMuon = value;
                    PropertyHasChanged("MaMuon");
                }
            }
        }
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
        public Boolean Muon
        {
            get
            {
                CanReadProperty("Muon", true);
                return _Muon;
            }
            set
            {
                CanWriteProperty("Muon", true);
                if (_Muon != value)
                {
                    _Muon = value;
                    PropertyHasChanged("Muon");
                }
            }
        }
        public String NgayMuon
        {
            get
            {
                CanReadProperty("NgayMuon", true);
                this._NgayMuon.FormatString = "dd/MM/yyyy";
                return _NgayMuon.Text;
            }
            set
            {
                CanWriteProperty("NgayMuon", true);
                if (_NgayMuon.Text != value)
                {
                    _NgayMuon.Text = value;
                    PropertyHasChanged("NgayMuon");
                }
            }
        }
        public String NgayTra
        {
            get
            {
                CanReadProperty("NgayTra", true);
                this._NgayTra.FormatString = "dd/MM/yyyy";
                return _NgayTra.Text;
            }
            set
            {
                CanWriteProperty("NgayTra", true);
                if (_NgayTra.Text != value)
                {
                    _NgayTra.Text = value;
                    PropertyHasChanged("NgayTra");
                }
            }
        }
        public String NguoiMuon
        {
            get
            {
                CanReadProperty("NguoiMuon", true);
                return _NguoiMuon;
            }
            set
            {
                CanWriteProperty("NguoiMuon", true);
                if (_NguoiMuon != value)
                {
                    _NguoiMuon = value;
                    PropertyHasChanged("NguoiMuon");
                }
            }
        }
        public String KhoaMuon
        {
            get
            {
                CanReadProperty("KhoaMuon", true);
                return _KhoaMuon;
            }
            set
            {
                CanWriteProperty("KhoaMuon", true);
                if (_KhoaMuon != value)
                {
                    _KhoaMuon = value;
                    PropertyHasChanged("KhoaMuon");
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
        public String NgayLap
        {
            get
            {
                CanReadProperty("NgayLap", true);
                this._ngayLap.FormatString = "dd/MM/yyyy";
                return _ngayLap.Text;
            }
            set
            {
                CanWriteProperty("NgayLap", true);
                if (_ngayLap.Text != value)
                {
                    _ngayLap.Text = value;
                    PropertyHasChanged("NgayLap");
                }
            }
        }
        public String NguoiLap
        {
            get
            {
                CanReadProperty("NguoiLap", true);
                return _nguoiLap;
            }
            set
            {
                CanWriteProperty("NguoiLap", true);
                if (_nguoiLap != value)
                {
                    _nguoiLap = value;
                    PropertyHasChanged("NguoiLap");
                }
            }
        }
        public String NgaySD
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
        public String NgayHuy
        {
            get
            {
                CanReadProperty("NgayHuy", true);
                return _ngayHuy.Text;
            }
            set
            {
                CanWriteProperty("NgayHuy", true);
                if (_ngayHuy.Text != value)
                {
                    _ngayHuy.Text = value;
                    PropertyHasChanged("NgayHuy");
                }
            }
        }
        public String NguoiHuy
        {
            get
            {
                CanReadProperty("NguoiHuy", true);
                return _nguoiHuy;
            }
            set
            {
                CanWriteProperty("NguoiHuy", true);
                if (_nguoiHuy != value)
                {
                    _nguoiHuy = value;
                    PropertyHasChanged("NguoiHuy");
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
        public String TenNguoiMuon
        {
            get
            {
                CanReadProperty("TenNguoiMuon", true);
                return _TenNguoiMuon;
            }
            set
            {
                CanWriteProperty("TenNguoiMuon", true);
                if (_TenNguoiMuon != value)
                {
                    _TenNguoiMuon = value;
                    PropertyHasChanged("TenNguoiMuon");
                }
            }
        }
        public String TenKhoaMuon
        {
            get
            {
                CanReadProperty("TenKhoaMuon", true);
                return _TenKhoaMuon;
            }
            set
            {
                CanWriteProperty("TenKhoaMuon", true);
                if (_TenKhoaMuon != value)
                {
                    _TenKhoaMuon = value;
                    PropertyHasChanged("TenKhoaMuon");
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
        protected override Object GetIdValue()
        {
            return _MaMuon;
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
        /// Factory method. New <see cref="BenhAn_HSBA_MuonTra" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static BenhAn_HSBA_MuonTra NewBenhAn_HSBA_MuonTra()
        {
            return new BenhAn_HSBA_MuonTra();
        }
        internal static BenhAn_HSBA_MuonTra GetBenhAn_HSBA_MuonTra(SafeDataReader dr, int i)
        {
            return new BenhAn_HSBA_MuonTra(dr, i);
        }
        public BenhAn_HSBA_MuonTra()
        {
            MarkAsChild();
        }
        public static BenhAn_HSBA_MuonTra GetBenhAn_HSBA_MuonTra(String maBA, String MaMuon, bool qAdmin)
        {
            return DataPortal.Fetch<BenhAn_HSBA_MuonTra>(new Criteria(maBA, MaMuon,qAdmin));
        }
        public static BenhAn_HSBA_MuonTra GetBenhAn_HSBA_MuonTra(SafeDataReader dr)
        {
            BenhAn_HSBA_MuonTra obj = new BenhAn_HSBA_MuonTra();
            obj.Fetch(dr);
            return obj;
        }
		/// <summary>
		/// Marks the <see cref="BenhAn_HSBA_MuonTra" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBenhAn_HSBA_MuonTra(string mamay, string nguoihuy, String maBA, String maMuon )
        {
            DataPortal.Delete(new OtherCriteria(mamay, nguoihuy, maBA, maMuon));
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
            private String _maMuon;
            public String MaMuon
            {
                get
                {
                    return _maMuon;
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
            private Int32 _LanDanhGia;
            public Int32 LanDanhGia
            {
                get
                {
                    return _LanDanhGia;
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
			public Criteria(String maBA, String maMuon, Boolean QAdmin)
			{
				_maBA = maBA;
                _maMuon = maMuon;
                _qadmin = QAdmin;
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
            private Int32 _LanDanhGia;
            public Int32 LanDanhGia
            {
                get
                {
                    return _LanDanhGia;
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
            private String _maMuon;
            public String MaMuon
            {
                get
                {
                    return _maMuon;
                }
            }
            private String _dienBien;
            public String DienBien
            {
                get
                {
                    return _dienBien;
                }
            }
            private String _xetNghiem;
            public String XetNghiem
            {
                get
                {
                    return _xetNghiem;
                }
            }
            private String _quaTrinh;
            public String QuaTrinh
            {
                get
                {
                    return _quaTrinh;
                }
            }
            private String _danhGia;
            public String DanhGia
            {
                get
                {
                    return _danhGia;
                }
            }
            private String _huongDT;
            public String HuongDT
            {
                get
                {
                    return _huongDT;
                }
            }
            private String _bsDieuTri;
            public String BSDieuTri
            {
                get
                {
                    return _bsDieuTri;
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
            private String _lydohuy;
            public String lydohuy
            {
                get
                {
                    return _lydohuy;
                }
            }
            public OtherCriteria(String Mamay, String Nguoisd, String maBA, String maMuon)
            {
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _maBA = maBA;
                _maMuon = maMuon;
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
		/// Retrieve an existing <see cref="BenhAn_HSBA_MuonTra" /> Object based on data in the database.
		/// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetBenhAn_HSBA_MuonTra(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
            // public override IDataReader GetBenhAn_HSBA_MuonTra(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBA, _sTT, _sTTKhoa));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_HSBA_MuonTra(crit.MaBA, crit.MaMuon,crit.QAdmin)))
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
		/// Load a <see cref="BenhAn_HSBA_MuonTra" /> Object from given SafeDataReader.
		/// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("MaMuon") != null) _MaMuon = dr.GetString("MaMuon");
            if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
            if (dr.GetBoolean("Muon") != null) _Muon = dr.GetBoolean("Muon");
            if (dr.GetSmartDate("NgayMuon", true) != null) _NgayMuon = dr.GetSmartDate("NgayMuon", true);
            if (dr.GetSmartDate("NgayTra", true) != null) _NgayTra = dr.GetSmartDate("NgayTra", true);
            if (dr.GetString("NguoiMuon") != null) _NguoiMuon = dr.GetString("Muon");
            if (dr.GetString("KhoaMuon") != null) _KhoaMuon = dr.GetString("KhoaMuon");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
            if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
            if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("TenNguoiMuon") != null) _TenNguoiMuon = dr.GetString("TenNguoiMuon");
            if (dr.GetString("TenKhoaMuon") != null) _TenKhoaMuon = dr.GetString("TenKhoaMuon");
        }
		
		/// <summary>
		/// Insert the new <see cref="BenhAn_HSBA_MuonTra" /> Object to underlying database.
		/// </summary>
        /// 

        private BenhAn_HSBA_MuonTra(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaMuon") != null) _MaMuon = dr.GetString("MaMuon");
            if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
            if (dr.GetBoolean("Muon") != null) _Muon = dr.GetBoolean("Muon");
            if (dr.GetSmartDate("NgayMuon", true) != null) _NgayMuon = dr.GetSmartDate("NgayMuon", true);
            if (dr.GetSmartDate("NgayTra", true) != null) _NgayTra = dr.GetSmartDate("NgayTra", true);
            if (dr.GetString("NguoiMuon") != null) _NguoiMuon = dr.GetString("NguoiMuon");
            if (dr.GetString("KhoaMuon") != null) _KhoaMuon = dr.GetString("KhoaMuon");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
            if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
            if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("TenNguoiMuon") != null) _TenNguoiMuon = dr.GetString("TenNguoiMuon");
            if (dr.GetString("TenKhoaMuon") != null) _TenKhoaMuon = dr.GetString("TenKhoaMuon");
            MarkOld();
        }
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;


            _maBA = DataProvider.Instance().InsertBenhAn_HSBA_MuonTra(_maBA, _NguoiMuon, _KhoaMuon, _ghiChu, _maMay, _nguoiLap);
			// public abstract String InsertBenhAn_HSBA_MuonTra(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap);
			// public override String InsertBenhAn_HSBA_MuonTra(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_HSBA_MuonTra_Create", _maBA, _sTT, _sTTKhoa, _maCPMau, _maBN, _ngayDK.DBValue, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _bSChiDinh, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT,_nguoiSD, _ngayTToan.DBValue, _daTra, _nguoiTra, _ngaytra.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _nguoiD, _nguoiP, _ngayD.DBValue,_maMay ,   _nguoiLap);
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAn_HSBA_MuonTra" /> Object to underlying database.
		/// </summary>
		internal void Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
            if (!this.IsDirty)
                return;
            
              
            DataProvider.Instance().UpdateBenhAn_HSBA_MuonTra(_MaMuon, _maBA, _Muon, _NgayMuon, _NgayTra, _NguoiMuon, _KhoaMuon, _ghiChu, _nguoiSD, _huy, _maMay);
				// public abstract void UpdateBenhAn_HSBA_MuonTra(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateBenhAn_HSBA_MuonTra(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_HSBA_MuonTra_Update", _maBA, _sTT, _sTTKhoa, _maCPMau, _maBN, _ngayDK.DBValue, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _bSChiDinh, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT,_nguoiSD, _ngayTToan.DBValue, _daTra, _nguoiTra, _ngaytra.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _nguoiD, _nguoiP, _ngayD.DBValue,_maMay ,   _huy, _nguoiSD);
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
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD, _maBA, _MaMuon));
            MarkNew();
        }

        private void DataPortal_Delete(OtherCriteria crit)
        {
            DataProvider.Instance().DeleteBenhAn_HSBA_MuonTra(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.MaMuon);
        }

		/// <summary>
		/// Delete the <see cref="BenhAn_HSBA_MuonTra" />.
		/// </summary>
        //protected void DataPortal_Delete(Criteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_HSBA_MuonTra
        //    DataProvider.Instance().DeleteBenhAn_HSBA_MuonTra(crit.MaBA, crit.STT, crit.STTKhoa);
        //    // public abstract void DeleteBenhAn_HSBA_MuonTra(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        //    // public override void DeleteBenhAn_HSBA_MuonTra(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_HSBA_MuonTra_Deleted", _maBA, _sTT, _sTTKhoa);
        //    // }
        //}

		#endregion
	}

}
