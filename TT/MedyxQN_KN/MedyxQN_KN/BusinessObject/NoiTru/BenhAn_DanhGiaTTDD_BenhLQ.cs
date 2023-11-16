// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_DanhGiaTTDD_BenhLQ
// Kieu doi tuong  :	BenhAn_DanhGiaTTDD_BenhLQ
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
	/// This is a base generated class of <see cref="BenhAn_DanhGiaTTDD_BenhLQ" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_DanhGiaTTDD_BenhLQ : BusinessBase<BenhAn_DanhGiaTTDD_BenhLQ>
	{
		#region Business Methods
		
		#region State Fields
        private String _maBA = String.Empty;
        private String _MaBenhID = String.Empty;
        private String _TenBenh = String.Empty;
        private Int32 _LanDanhGia = 0;
        private String _maMay = String.Empty;
        private SmartDate _ngayLap = new SmartDate(true);
        private String _nguoiLap = String.Empty;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private Boolean _huy = false;
        private Boolean _Checked = false;
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
        public String MaBenhID
        {
            get
            {
                CanReadProperty("MaBenhID", true);
                return _MaBenhID;
            }
            set
            {
                CanWriteProperty("MaBenhID", true);
                if (_MaBenhID != value)
                {
                    _MaBenhID = value;
                    PropertyHasChanged("MaBenhID");
                }
            }
        }
        public String TenBenh
        {
            get
            {
                CanReadProperty("TenBenh", true);
                return _TenBenh;
            }
            set
            {
                CanWriteProperty("TenBenh", true);
                if (_TenBenh != value)
                {
                    _TenBenh = value;
                    PropertyHasChanged("TenBenh");
                }
            }
        }
        public Int32 LanDanhGia
        {
            get
            {
                CanReadProperty("LanDanhGia", true);
                return _LanDanhGia;
            }
            set
            {
                CanWriteProperty("LanDanhGia", true);
                if (_LanDanhGia != value)
                {
                    _LanDanhGia = value;
                    PropertyHasChanged("LanDanhGia");
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
        public Boolean Checked
        {
            get
            {
                CanReadProperty("Checked", true);
                return _Checked;
            }
            set
            {
                CanWriteProperty("Checked", true);
                if (_Checked != value)
                {
                    _Checked = value;
                    PropertyHasChanged("Checked");
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
        protected override Object GetIdValue()
        {
            return _maBA.ToString() + "!" + _MaBenhID.ToString().ToString() + "!" + _LanDanhGia.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
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
		/// Factory method. New <see cref="BenhAn_DanhGiaTTDD_BenhLQ" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BenhAn_DanhGiaTTDD_BenhLQ NewBenhAn_DanhGiaTTDD_BenhLQ()
        {
            return new BenhAn_DanhGiaTTDD_BenhLQ();
        }
        internal static BenhAn_DanhGiaTTDD_BenhLQ GetBenhAn_DanhGiaTTDD_BenhLQ(SafeDataReader dr, int i)
        {
            return new BenhAn_DanhGiaTTDD_BenhLQ(dr, i);
        }
        public BenhAn_DanhGiaTTDD_BenhLQ()
        {
            MarkAsChild();
        }
        public static BenhAn_DanhGiaTTDD_BenhLQ GetBenhAn_DanhGiaTTDD_BenhLQ(String maBA, Int32 sTT, Int32 sTTKhoa, Int32 LanDanhGia)
        {
            return DataPortal.Fetch<BenhAn_DanhGiaTTDD_BenhLQ>(new Criteria(maBA, sTT, sTTKhoa, false, LanDanhGia));
        }
        public static BenhAn_DanhGiaTTDD_BenhLQ GetBenhAn_DanhGiaTTDD_BenhLQ(SafeDataReader dr)
        {
            BenhAn_DanhGiaTTDD_BenhLQ obj = new BenhAn_DanhGiaTTDD_BenhLQ();
            obj.Fetch(dr);
            return obj;
        }
		/// <summary>
		/// Marks the <see cref="BenhAn_DanhGiaTTDD_BenhLQ" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBenhAn_DanhGiaTTDD_BenhLQ(String maBA, String MaBenhID, string mamay, string nguoihuy, int LanDanhGia)
        {
            DataPortal.Delete(new OtherCriteria(mamay, nguoihuy, maBA, MaBenhID, LanDanhGia));
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
			public Criteria(String maBA, Int32 sTT, Int32 sTTKhoa, Boolean QAdmin, Int32 LanDanhGia)
			{
				_maBA = maBA;
				_sTT = sTT;
				_sTTKhoa = sTTKhoa;
                _qadmin = QAdmin;
                _LanDanhGia = LanDanhGia;
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
            private String _MaBenhID;
            public String MaBenhID
            {
                get
                {
                    return _MaBenhID;
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
            public OtherCriteria(  String Mamay, String Nguoisd, String maBA, String MaBenhID, Int32 LanDanhGia)
            {
                _maBA = maBA;
                _MaBenhID = MaBenhID;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _LanDanhGia = LanDanhGia;
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
		/// Retrieve an existing <see cref="BenhAn_DanhGiaTTDD_BenhLQ" /> Object based on data in the database.
		/// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetBenhAn_DanhGiaTTDD_BenhLQ(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
            // public override IDataReader GetBenhAn_DanhGiaTTDD_BenhLQ(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBA, _sTT, _sTTKhoa));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_DanhGiaTTDD_BenhLQ(crit.MaBA,crit.QAdmin,crit.LanDanhGia )))
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
		/// Load a <see cref="BenhAn_DanhGiaTTDD_BenhLQ" /> Object from given SafeDataReader.
		/// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
            if (dr.GetString("MaBenhID") != null) _MaBenhID = dr.GetString("MaBenhID");
            if (dr.GetString("TenBenh") != null) _TenBenh = dr.GetString("TenBenh");
            if (dr.GetInt32("LanDanhGia") != null) _LanDanhGia = dr.GetInt32("LanDanhGia");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetBoolean("Checked") != null) _Checked = dr.GetBoolean("Checked");
            if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
            if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        }
		
		/// <summary>
		/// Insert the new <see cref="BenhAn_DanhGiaTTDD_BenhLQ" /> Object to underlying database.
		/// </summary>
        /// 

        private BenhAn_DanhGiaTTDD_BenhLQ(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
            if (dr.GetString("MaBenhID") != null) _MaBenhID = dr.GetString("MaBenhID");
            if (dr.GetString("TenBenh") != null) _TenBenh = dr.GetString("TenBenh");
            if (dr.GetInt32("LanDanhGia") != null) _LanDanhGia = dr.GetInt32("LanDanhGia");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetBoolean("Checked") != null) _Checked = dr.GetBoolean("Checked");
            if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
            if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            MarkOld();
        }
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;


            _maBA = DataProvider.Instance().InsertBenhAn_DanhGiaTTDD_BenhLQ(_maBA, _MaBenhID, _LanDanhGia, _maMay, _nguoiSD);
			// public abstract String InsertBenhAn_DanhGiaTTDD_BenhLQ(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap);
			// public override String InsertBenhAn_DanhGiaTTDD_BenhLQ(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_DanhGiaTTDD_BenhLQ_Create", _maBA, _sTT, _sTTKhoa, _maCPMau, _maBN, _ngayDK.DBValue, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _bSChiDinh, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT,_nguoiSD, _ngayTToan.DBValue, _daTra, _nguoiTra, _ngaytra.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _nguoiD, _nguoiP, _ngayD.DBValue,_maMay ,   _nguoiLap);
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAn_DanhGiaTTDD_BenhLQ" /> Object to underlying database.
		/// </summary>
		internal void Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
            if (!this.IsDirty)
                return;
            
              
            DataProvider.Instance().UpdateBenhAn_DanhGiaTTDD_BenhLQ(_maBA, _MaBenhID, _LanDanhGia, _maMay, _nguoiSD, _huy);
				// public abstract void UpdateBenhAn_DanhGiaTTDD_BenhLQ(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateBenhAn_DanhGiaTTDD_BenhLQ(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_DanhGiaTTDD_BenhLQ_Update", _maBA, _sTT, _sTTKhoa, _maCPMau, _maBN, _ngayDK.DBValue, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _bSChiDinh, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT,_nguoiSD, _ngayTToan.DBValue, _daTra, _nguoiTra, _ngaytra.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _nguoiD, _nguoiP, _ngayD.DBValue,_maMay ,   _huy, _nguoiSD);
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
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD, _maBA, _MaBenhID, _LanDanhGia));
            MarkNew();
        }

        private void DataPortal_Delete(OtherCriteria crit)
        {
            DataProvider.Instance().DeleteBenhAn_DanhGiaTTDD_BenhLQ(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.MaBenhID, crit.LanDanhGia);
        }

		/// <summary>
		/// Delete the <see cref="BenhAn_DanhGiaTTDD_BenhLQ" />.
		/// </summary>
        //protected void DataPortal_Delete(Criteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_DanhGiaTTDD_BenhLQ
        //    DataProvider.Instance().DeleteBenhAn_DanhGiaTTDD_BenhLQ(crit.MaBA, crit.STT, crit.STTKhoa);
        //    // public abstract void DeleteBenhAn_DanhGiaTTDD_BenhLQ(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        //    // public override void DeleteBenhAn_DanhGiaTTDD_BenhLQ(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_DanhGiaTTDD_BenhLQ_Deleted", _maBA, _sTT, _sTTKhoa);
        //    // }
        //}

		#endregion
	}

}
