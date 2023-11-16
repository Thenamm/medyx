// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_Nghi
// Kieu doi tuong  :	BenhAn_Nghi
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
	/// This is a base generated class of <see cref="BenhAn_Nghi" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_Nghi : BusinessBase<BenhAn_Nghi>
	{
		#region Business Methods
		
		#region State Fields
        private String _maBA = String.Empty;
        private Int32 _sTT = 0;
        private Int32 _sTTKhoa = 0;
        private String _maKhoa = String.Empty;
        private String _maLDNghi = String.Empty;
        private SmartDate _tuNgay = new SmartDate(true);
        private SmartDate _denNgay = new SmartDate(true);
        private SmartDate _NgayTT = new SmartDate(true);
        private SmartDate _NgayTTD = new SmartDate(true);
        private SmartDate _tuNgayD = new SmartDate(true);
        private SmartDate _denNgayD = new SmartDate(true);
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngayHuy = new SmartDate(true);
        private SmartDate _ngayHuyD = new SmartDate(true);
        private String _lyDoHuy = String.Empty;
        private SmartDate _ngayLap = new SmartDate(true);
        private String _nguoiLap = String.Empty;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private String _nguoiHuy = String.Empty;
        private SmartDate _ngaySD1 = new SmartDate(true);
        private String _nguoiSD1 = String.Empty;
        private String _tenLDNghi = String.Empty;
        private String _tENNGUOILAP = String.Empty;
        private String _tENNGUOISD = String.Empty;
        private String _tENNGUOIHUY = String.Empty;
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

        public Int32 STTKhoa
        {
            get
            {
                CanReadProperty("STTKhoa", true);
                return _sTTKhoa;
            }
            set
            {
                CanWriteProperty("STTKhoa", true);
                if (_sTTKhoa != value)
                {
                    _sTTKhoa = value;
                    PropertyHasChanged("STTKhoa");
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

        public String MaLDNghi
        {
            get
            {
                CanReadProperty("MaLDNghi", true);
                return _maLDNghi;
            }
            set
            {
                CanWriteProperty("MaLDNghi", true);
                if (_maLDNghi != value)
                {
                    _maLDNghi = value;
                    PropertyHasChanged("MaLDNghi");
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
        public String TuNgayD
        {
            get
            {
                CanReadProperty("TuNgayD", true);
                _tuNgayD = _tuNgay;
                this._tuNgayD.FormatString = "dd/MM/yyyy";
                return _tuNgayD.Text;
            }

        }
        public String DenNgayD
        {
            get
            {
                CanReadProperty("DenNgayD", true);
                _denNgayD = _denNgay;
                this._denNgayD.FormatString = "dd/MM/yyyy";
                return _denNgayD.Text;
            }

        }
        public String NgayTTD
        {
            get
            {
                CanReadProperty("DenNgayD", true);
                _denNgayD = _denNgay;
                this._denNgayD.FormatString = "dd/MM/yyyy";
                return _denNgayD.Text;
            }

        }
        public string NgayTT
        {
            get
            {
                CanReadProperty("NgayTT", true);
                return _NgayTT.Text;
            }
            set
            {
                CanWriteProperty("NgayTT", true);
                if (_NgayTT.Text != value)
                {
                    _NgayTT.Text = value;
                    PropertyHasChanged("NgayTT");
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

        public string NgayHuy
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
        public String NgayHuyD
        {
            get
            {
                CanReadProperty("NgayHuyD", true);
                _ngayHuyD = _ngayHuy ;
                this._ngayHuyD.FormatString = "dd/MM/yyyy";
                return _ngayHuyD.Text;
            }

        }
        public String LyDoHuy
        {
            get
            {
                CanReadProperty("LyDoHuy", true);
                return _lyDoHuy;
            }
            set
            {
                CanWriteProperty("LyDoHuy", true);
                if (_lyDoHuy != value)
                {
                    _lyDoHuy = value;
                    PropertyHasChanged("LyDoHuy");
                }
            }
        }

        public string NgayLap
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

        public String TenLDNghi
        {
            get
            {
                CanReadProperty("TenLDNghi", true);
                return _tenLDNghi;
            }
            set
            {
                CanWriteProperty("TenLDNghi", true);
                if (_tenLDNghi != value)
                {
                    _tenLDNghi = value;
                    PropertyHasChanged("TenLDNghi");
                }
            }
        }

        public String TENNGUOILAP
        {
            get
            {
                CanReadProperty("TENNGUOILAP", true);
                return _tENNGUOILAP;
            }
            set
            {
                CanWriteProperty("TENNGUOILAP", true);
                if (_tENNGUOILAP != value)
                {
                    _tENNGUOILAP = value;
                    PropertyHasChanged("TENNGUOILAP");
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

        public String TENNGUOIHUY
        {
            get
            {
                CanReadProperty("TENNGUOIHUY", true);
                return _tENNGUOIHUY;
            }
            set
            {
                CanWriteProperty("TENNGUOIHUY", true);
                if (_tENNGUOIHUY != value)
                {
                    _tENNGUOIHUY = value;
                    PropertyHasChanged("TENNGUOIHUY");
                }
            }
        }
        protected override Object GetIdValue()
        {
            return _maBA.ToString() + "!" + _sTT.ToString().ToString() + "!" + _sTTKhoa.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
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
		/// Factory method. New <see cref="BenhAn_Nghi" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BenhAn_Nghi NewBenhAn_Nghi()
        {
            return new BenhAn_Nghi();
        }
        internal static BenhAn_Nghi GetBenhAn_Nghi(SafeDataReader dr, int i)
        {
            return new BenhAn_Nghi(dr, i);
        }
        public BenhAn_Nghi()
        {
            MarkAsChild();
        }
        public static BenhAn_Nghi GetBenhAn_Nghi(String maBA, Int32 sTT, Int32 sTTKhoa)
        {
            return DataPortal.Fetch<BenhAn_Nghi>(new Criteria(maBA, sTT, sTTKhoa,false ));
        }
        public static BenhAn_Nghi GetBenhAn_Nghi(SafeDataReader dr)
        {
            BenhAn_Nghi obj = new BenhAn_Nghi();
            obj.Fetch(dr);
            return obj;
        }
		/// <summary>
		/// Marks the <see cref="BenhAn_Nghi" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBenhAn_Nghi(String maBA, Int32 sTT, Int32 sTTKhoa, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(maBA, sTT, sTTKhoa, mamay, nguoihuy,""));
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
            private Boolean _qadmin= HTC.ShareVariables.pub_bQadmin ;
            public Boolean QAdmin
            {
                get
                {
                    return _qadmin;
                }
            }
			public Criteria(String maBA, Int32 sTT, Int32 sTTKhoa, Boolean QAdmin)
			{
				_maBA = maBA;
				_sTT = sTT;
				_sTTKhoa = sTTKhoa;
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
            private String _lydohuy;
            public String lydohuy
            {
                get
                {
                    return _lydohuy;
                }
            }
            public OtherCriteria( String maBA, Int32 sTT, Int32 sTTKhoa,String Mamay, String Nguoisd, String lydohuy)
            {
                _maBA = maBA;
                _sTT = sTT;
                _sTTKhoa = sTTKhoa;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _lydohuy = lydohuy;
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
		/// Retrieve an existing <see cref="BenhAn_Nghi" /> Object based on data in the database.
		/// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetBenhAn_Nghi(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
            // public override IDataReader GetBenhAn_Nghi(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBA, _sTT, _sTTKhoa));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_Nghi(crit.MaBA, crit.STT, crit.STTKhoa,crit.QAdmin )))
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
		/// Load a <see cref="BenhAn_Nghi" /> Object from given SafeDataReader.
		/// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
            if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
            if (dr.GetString("MaLDNghi") != null) _maLDNghi = dr.GetString("MaLDNghi");
            if (dr.GetSmartDate("TuNgay", true) != null) _tuNgay = dr.GetSmartDate("TuNgay", true);
            if (dr.GetSmartDate("DenNgay", true) != null) _denNgay = dr.GetSmartDate("DenNgay", true);
            if (dr.GetSmartDate("NgayTT", true) != null) _NgayTT = dr.GetSmartDate("NgayTT", true);
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
            if (dr.GetString("LyDoHuy") != null) _lyDoHuy = dr.GetString("LyDoHuy");
            if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
            if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
            if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetString("TenLDNghi") != null) _tenLDNghi = dr.GetString("TenLDNghi");
            if (dr.GetString("TENNGUOILAP") != null) _tENNGUOILAP = dr.GetString("TENNGUOILAP");
            if (dr.GetString("TENNGUOISD") != null) _tENNGUOISD = dr.GetString("TENNGUOISD");
            if (dr.GetString("TENNGUOIHUY") != null) _tENNGUOIHUY = dr.GetString("TENNGUOIHUY");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");

        }
		
		/// <summary>
		/// Insert the new <see cref="BenhAn_Nghi" /> Object to underlying database.
		/// </summary>
        /// 

        private BenhAn_Nghi(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
            if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
            if (dr.GetString("MaLDNghi") != null) _maLDNghi = dr.GetString("MaLDNghi");
            if (dr.GetSmartDate("TuNgay", true) != null) _tuNgay = dr.GetSmartDate("TuNgay", true);
            if (dr.GetSmartDate("DenNgay", true) != null) _denNgay = dr.GetSmartDate("DenNgay", true);
            if (dr.GetSmartDate("NgayTT", true) != null) _NgayTT = dr.GetSmartDate("NgayTT", true);
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
            if (dr.GetString("LyDoHuy") != null) _lyDoHuy = dr.GetString("LyDoHuy");
            if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
            if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
            if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetString("TenLDNghi") != null) _tenLDNghi = dr.GetString("TenLDNghi");
            if (dr.GetString("TENNGUOILAP") != null) _tENNGUOILAP = dr.GetString("TENNGUOILAP");
            if (dr.GetString("TENNGUOISD") != null) _tENNGUOISD = dr.GetString("TENNGUOISD");
            if (dr.GetString("TENNGUOIHUY") != null) _tENNGUOIHUY = dr.GetString("TENNGUOIHUY");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            MarkOld();
        }
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
            
            _maBA = DataProvider.Instance().InsertBenhAn_Nghi(_maBA, _sTT, _sTTKhoa, _maKhoa , _maLDNghi , _ghiChu, _maMay , _nguoiSD ,_tuNgay ,_denNgay );
			// public abstract String InsertBenhAn_Nghi(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap);
			// public override String InsertBenhAn_Nghi(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Nghi_Create", _maBA, _sTT, _sTTKhoa, _maCPMau, _maBN, _ngayDK.DBValue, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _bSChiDinh, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT,_nguoiSD, _ngayTToan.DBValue, _daTra, _nguoiTra, _ngaytra.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _nguoiD, _nguoiP, _ngayD.DBValue,_maMay ,   _nguoiLap);
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAn_Nghi" /> Object to underlying database.
		/// </summary>
		internal void Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
            if (!this.IsDirty)
                return;
            
              
            DataProvider.Instance().UpdateBenhAn_Nghi(_maBA, _sTT, _sTTKhoa, _maKhoa, _maLDNghi, _ghiChu, _tuNgay, _denNgay, _maMay, _huy , _nguoiSD,_NgayTT  );
				// public abstract void UpdateBenhAn_Nghi(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateBenhAn_Nghi(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Nghi_Update", _maBA, _sTT, _sTTKhoa, _maCPMau, _maBN, _ngayDK.DBValue, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _bSChiDinh, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT,_nguoiSD, _ngayTToan.DBValue, _daTra, _nguoiTra, _ngaytra.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _nguoiD, _nguoiP, _ngayD.DBValue,_maMay ,   _huy, _nguoiSD);
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
            DataPortal_Delete(new OtherCriteria( _maBA, _sTT, _sTTKhoa,_maMay,_nguoiSD, _lyDoHuy));
            MarkNew();
        }

        private void DataPortal_Delete(OtherCriteria crit)
        {
            DataProvider.Instance().DeleteBenhAn_Nghi(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.STT, crit.STTKhoa, crit.lydohuy);
        }

		/// <summary>
		/// Delete the <see cref="BenhAn_Nghi" />.
		/// </summary>
        //protected void DataPortal_Delete(Criteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_Nghi
        //    DataProvider.Instance().DeleteBenhAn_Nghi(crit.MaBA, crit.STT, crit.STTKhoa);
        //    // public abstract void DeleteBenhAn_Nghi(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        //    // public override void DeleteBenhAn_Nghi(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Nghi_Deleted", _maBA, _sTT, _sTTKhoa);
        //    // }
        //}

		#endregion
	}

}
