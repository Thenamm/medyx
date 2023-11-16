// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
// Ten file        :	BenhAn_MienGiam
// Kieu doi tuong  :	CslaObject
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	6/11/2010 2:26:07 PM
// Nguoi tao       :	PM8
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
	/// This is a base generated class of <see cref="BenhAn_MienGiam" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_MienGiam : BusinessBase<BenhAn_MienGiam>
	{
		#region Business Methods

        #region State Fields
        private Byte _dATT = 0;
        private String _nguoiTT = String.Empty;
        private SmartDate _ngayTToan = new SmartDate(true);
        private String _maBA = String.Empty;
        private Int32 _sTT = 0;
        private String _maKhoa = String.Empty;
        private Int32 _sTTKhoa = 0;
        private String _soCT = String.Empty;
        private String _maMienGiam = String.Empty;
        private string _tenMienGiam = string.Empty;
        private Decimal _soTien = 0;
        private Decimal _soTienUSD = 0;
        private Decimal _tyGia = 0;
        private SmartDate _ngayKy = new SmartDate(true);
        private SmartDate _ngayKyD = new SmartDate("", true);
        private String _ghiChu = String.Empty;
        private String _maPT = String.Empty;
        private String _nguoiKy = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private SmartDate _ngayLap = new SmartDate(true);
        private String _nguoiLap = String.Empty;
        private String _nguoiHuy = String.Empty;
        private SmartDate _ngayHuy = new SmartDate(true);
        private SmartDate _ngaySD1 = new SmartDate(true);
        private String _nguoiSD1 = String.Empty;
        private String _tennguoiKy = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private String _tenPT = String.Empty;
        private String _maDT = String.Empty;
        private Decimal _ck = 0;
        private int _OrderNumber;

        #endregion

        #region Business Properties and Methods
        public Byte DATT
        {
            get
            {
                CanReadProperty("DATT", true);
                return _dATT;
            }
            set
            {
                CanWriteProperty("DATT", true);
                if (_dATT != value)
                {
                    _dATT = value;
                    PropertyHasChanged("DATT");
                }
            }
        }

        public String NguoiTT
        {
            get
            {
                CanReadProperty("NguoiTT", true);
                return _nguoiTT;
            }
            set
            {
                CanWriteProperty("NguoiTT", true);
                if (_nguoiTT != value)
                {
                    _nguoiTT = value;
                    PropertyHasChanged("NguoiTT");
                }
            }
        }

        public string NgayTToan
        {
            get
            {
                CanReadProperty("NgayTToan", true);
                return _ngayTToan.Text;
            }
            set
            {
                CanWriteProperty("NgayTToan", true);
                if (_ngayTToan.Text != value)
                {
                    _ngayTToan.Text = value;
                    PropertyHasChanged("NgayTToan");
                }
            }
        }
        public String MaDT
        {
            get
            {
                CanReadProperty("MaDT", true);
                return _maDT;
            }
            set
            {
                CanWriteProperty("MaDT", true);
                if (_maDT != value)
                {
                    _maDT = value;
                    PropertyHasChanged("MaDT");
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

        public String soCT
        {
            get
            {
                CanReadProperty("soCT", true);
                return _soCT;
            }
            set
            {
                CanWriteProperty("soCT", true);
                if (_soCT != value)
                {
                    _soCT = value;
                    PropertyHasChanged("soCT");
                }
            }
        }

        public String MaMienGiam
        {
            get
            {
                CanReadProperty("MaMienGiam", true);
                return _maMienGiam;
            }
            set
            {
                CanWriteProperty("MaMienGiam", true);
                if (_maMienGiam != value)
                {
                    _maMienGiam = value;
                    PropertyHasChanged("MaMienGiam");
                }
            }
        }
        public String TenMienGiam
        {
            get
            {
                CanReadProperty("TenMienGiam", true);
                return _tenMienGiam;
            }
            set
            {
                CanWriteProperty("TenMienGiam", true);
                if (_tenMienGiam != value)
                {
                    _tenMienGiam = value;
                    PropertyHasChanged("TenMienGiam");
                }
            }
        }
        //public Decimal SoTien
        //{
        //    get 
        //    {
        //        CanReadProperty("SoTien", true);
        //        return _soTien;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("SoTien", true);
        //        if (_soTien != value) 
        //        {
        //            _soTien = value;
        //            PropertyHasChanged("SoTien");
        //        }
        //    }
        //}
        public string SoTien
        {
            get
            {
                CanReadProperty("SoTien", true);
                return _soTien.ToString("###,###");
            }
            set
            {
                CanWriteProperty("SoTien", true);

                if (_soTien.ToString() != value)
                {
                    _soTien = decimal.Parse(value);
                    PropertyHasChanged("SoTien");
                }
            }
        }
        public Decimal SoTienUSD
        {
            get
            {
                CanReadProperty("SoTienUSD", true);
                return _soTienUSD;
            }
            set
            {
                CanWriteProperty("SoTienUSD", true);
                if (_soTienUSD != value)
                {
                    _soTienUSD = value;
                    PropertyHasChanged("SoTienUSD");
                }
            }
        }

        public Decimal TyGia
        {
            get
            {
                CanReadProperty("TyGia", true);
                return _tyGia;
            }
            set
            {
                CanWriteProperty("TyGia", true);
                if (_tyGia != value)
                {
                    _tyGia = value;
                    PropertyHasChanged("TyGia");
                }
            }
        }

        public string ngayKy
        {
            get
            {
                CanReadProperty("ngayKy", true);
                return _ngayKy.Text;
            }
            set
            {
                CanWriteProperty("ngayKy", true);
                if (_ngayKy.Text != value)
                {
                    _ngayKy.Text = value;
                    PropertyHasChanged("ngayKy");
                }
            }
        }

        public string ngayKyD
        {
            get
            {
                //CanReadProperty("ngayKy", true);
                _ngayKyD = _ngayKy;
                _ngayKyD.FormatString = "dd/MM/yyyy HH:mm ";
                return _ngayKyD.Text;
            }
            set
            {
                //CanWriteProperty("ngayKy", true);
                if (_ngayKyD.Text != value)
                {
                    _ngayKyD.Text = value;
                    //  PropertyHasChanged("ngayKy");
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

        public String MaPT
        {
            get
            {
                CanReadProperty("MaPT", true);
                return _maPT;
            }
            set
            {
                CanWriteProperty("MaPT", true);
                if (_maPT != value)
                {
                    _maPT = value;
                    PropertyHasChanged("MaPT");
                }
            }
        }

        public String nguoiKy
        {
            get
            {
                CanReadProperty("nguoiKy", true);
                return _nguoiKy;
            }
            set
            {
                CanWriteProperty("nguoiKy", true);
                if (_nguoiKy != value)
                {
                    _nguoiKy = value;
                    PropertyHasChanged("nguoiKy");
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
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm";
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

        public string NgayLap
        {
            get
            {
                CanReadProperty("NgayLap", true);
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
        public String TenNguoiLap
        {
            get
            {
                CanReadProperty("TenNguoiLap", true);
                return _tenNguoiLap;
            }
            set
            {
                CanWriteProperty("TenNguoiLap", true);
                if (_tenNguoiLap != value)
                {
                    _tenNguoiLap = value;
                    PropertyHasChanged("TenNguoiLap");
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
        public String TenNguoiHuy
        {
            get
            {
                CanReadProperty("TenNguoiHuy", true);
                return _tenNguoiHuy;
            }
            set
            {
                CanWriteProperty("TenNguoiHuy", true);
                if (_tenNguoiHuy != value)
                {
                    _tenNguoiHuy = value;
                    PropertyHasChanged("TenNguoiHuy");
                }
            }
        }

        public String TenPT
        {
            get
            {
                CanReadProperty("TenPT", true);
                return _tenPT;
            }
            set
            {
                CanWriteProperty("TenPT", true);
                if (_tenPT != value)
                {
                    _tenPT = value;
                    PropertyHasChanged("TenPT");
                }
            }
        }

        public String TennguoiKy
        {
            get
            {
                CanReadProperty("TennguoiKy", true);
                return _tennguoiKy;
            }
            set
            {
                CanWriteProperty("TennguoiKy", true);
                if (_tennguoiKy != value)
                {
                    _tennguoiKy = value;
                    PropertyHasChanged("TennguoiKy");
                }
            }
        }
        public Decimal CK
        {
            get
            {
                CanReadProperty("CK", true);
                return _ck;
            }
            set
            {
                CanWriteProperty("CK", true);
                if (_ck != value)
                {
                    _ck = value;
                    PropertyHasChanged("CK");
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
            return _maBA.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
        }

        #endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhAn_MienGiam" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BenhAn_MienGiam NewBenhAn_MienGiam()
        {
            return DataPortal.Create<BenhAn_MienGiam>();
            //return new BenhAn_ThuocSD();


        }
        internal static BenhAn_MienGiam GetBenhAn_MienGiam(SafeDataReader dr, int i)
        {
            return new BenhAn_MienGiam(dr, i);
        }
        public BenhAn_MienGiam()
        {
            MarkAsChild();
        }
                //public static BenhAn_MienGiam GetBenhAn_MienGiam(String maBA, Int32 sTT)
                //{
                //    return DataPortal.Fetch<BenhAn_MienGiam>(new Criteria(maBA, sTT));
                //}
        		
                ///// <summary>
                ///// Marks the <see cref="BenhAn_MienGiam" /> Object for deletion. The Object will be deleted as part of the next save operation.
                ///// </summary>
                //public static void DeleteBenhAn_MienGiam(String maBA, Int32 sTT)
                //{
                //    DataPortal.Delete(new Criteria(maBA, sTT));
                //}
		
		#endregion
		
        //#region Constructors
        //// Chu y !!!
        //// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        //// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal BenhAn_MienGiam()
        //{	
        //    // Prevent direct creation
        //}
		
        //#endregion

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
			
			public Criteria(String maBA, Int32 sTT)
			{
				_maBA = maBA;
				_sTT = sTT;
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
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBA.ToString(), _sTT.ToString()).GetHashCode();
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
            public OtherCriteria(String Mamay, String Nguoisd, String maBA, Int32 sTT)
            {
                _maBA = maBA;
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

        ///// <summary>
        ///// Retrieve an existing <see cref="BenhAn_MienGiam" /> Object based on data in the database.
        ///// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetBenhAn_MienGiam(String _maBA, Int32 _sTT);
        //    // public override IDataReader GetBenhAn_MienGiam(String _maBA, Int32 _sTT)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBA, _sTT));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_MienGiam(crit.MaBA, crit.STT)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="BenhAn_MienGiam" /> Object from given SafeDataReader.
		/// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
        //    if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
        //    if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
        //    if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
        //    if (dr.GetString("soCT") != null) _soCT = dr.GetString("soCT");
        //    if (dr.GetString("MaMienGiam") != null) _maMienGiam = dr.GetString("MaMienGiam");
        //    if (dr.GetDecimal("SoTien") != null) _soTien = dr.GetDecimal("SoTien");
        //    if (dr.GetDecimal("SoTienUSD") != null) _soTienUSD = dr.GetDecimal("SoTienUSD");
        //    if (dr.GetDecimal("TyGia") != null) _tyGia = dr.GetDecimal("TyGia");
        //    if (dr.GetSmartDate("ngayKy", true) != null) _ngayKy = dr.GetSmartDate("ngayKy", true);
        //    if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
        //    if (dr.GetString("MaPT") != null) _maPT = dr.GetString("MaPT");
        //    if (dr.GetString("nguoiKy") != null) _nguoiKy = dr.GetString("nguoiKy");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //    if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
        //    if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
        //    if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
        //    if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
        //    if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
        //    if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
        //}

        private BenhAn_MienGiam(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
            if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
            if (dr.GetString("MaMienGiam") != null) _maMienGiam = dr.GetString("MaMienGiam");
            if (dr.GetString("TenMienGiam") != null) _tenMienGiam  = dr.GetString("TenMienGiam");
            if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
            if (dr.GetDecimal("SoTien") != null) _soTien = dr.GetDecimal("SoTien");
            if (dr.GetDecimal("SoTienUSD") != null) _soTienUSD = dr.GetDecimal("SoTienUSD");
            if (dr.GetDecimal("TyGia") != null) _tyGia = dr.GetDecimal("TyGia");
            if (dr.GetSmartDate("ngayKy", true) != null) _ngayKy = dr.GetSmartDate("ngayKy", true);
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");         
            if (dr.GetByte("DATT") != null) _dATT = dr.GetByte("DATT");
            if (dr.GetString("nguoiKy") != null) _nguoiKy = dr.GetString("nguoiKy");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
            if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
            if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
            if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenNguoiLap") != null) _tenNguoiLap = dr.GetString("TenNguoiLap");
            if (dr.GetString("TenNguoiHuy") != null) _tenNguoiHuy = dr.GetString("TenNguoiHuy");
            if (dr.GetString("TennguoiKy") != null) _tennguoiKy = dr.GetString("TennguoiKy");
            
 
          
            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="BenhAn_MienGiam" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            _ngayLap.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }
        internal void Insert()
        {
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_MienGiam
			// Copy & paste ham duoi day vao file DataProvider.cs
             if (!this.IsDirty)
                return;
            
            
            _sTT = DataProvider.Instance().InsertBenhAn_MienGiam(_maBA, _maKhoa, _sTTKhoa,_sTT,  _maMienGiam, _soTien, _soTienUSD, _tyGia, _ngayKy, _ghiChu, _nguoiKy, _maMay, _nguoiSD ,_soCT,_maDT, _ck ,_dATT  );
			// public abstract String InsertBenhAn_MienGiam(String _maBA, Int32 _sTT, String _maKhoa, Int32 _sTTKhoa, String _soCT, String _maMienGiam, Decimal _soTien, Decimal _soTienUSD, Decimal _tyGia, SmartDate _ngayKy, String _ghiChu, String _maPT, String _nguoiKy, String _maMay, String _nguoiSD);
			// public override String InsertBenhAn_MienGiam(String _maBA, Int32 _sTT, String _maKhoa, Int32 _sTTKhoa, String _soCT, String _maMienGiam, Decimal _soTien, Decimal _soTienUSD, Decimal _tyGia, SmartDate _ngayKy, String _ghiChu, String _maPT, String _nguoiKy, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_MienGiam_CREATE", _maBA, _sTT, _maKhoa, _sTTKhoa, _soCT, _maMienGiam, _soTien, _soTienUSD, _tyGia, _ngayKy.DBValue, _ghiChu, _maPT, _nguoiKy, _maMay, _nguoiSD));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAn_MienGiam" /> Object to underlying database.
		/// </summary>
        internal void Update()
        {
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_MienGiam
			if (!this.IsDirty)
                return;
            
              
            DataProvider.Instance().UpdateBenhAn_MienGiam(_maBA, _maKhoa, _sTTKhoa, _sTT, _maMienGiam, _soTien, _soTienUSD, _tyGia, _ngayKy, _ghiChu, _nguoiKy, _maMay,_huy, _nguoiSD , _soCT, _maDT, _ck, _dATT);
				// public abstract void UpdateBenhAn_MienGiam(String _maBA, Int32 _sTT, String _maKhoa, Int32 _sTTKhoa, String _soCT, String _maMienGiam, Decimal _soTien, Decimal _soTienUSD, Decimal _tyGia, SmartDate _ngayKy, String _ghiChu, String _maPT, String _nguoiKy, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateBenhAn_MienGiam(String _maBA, Int32 _sTT, String _maKhoa, Int32 _sTTKhoa, String _soCT, String _maMienGiam, Decimal _soTien, Decimal _soTienUSD, Decimal _tyGia, SmartDate _ngayKy, String _ghiChu, String _maPT, String _nguoiKy, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_MienGiam_UPDATE", _maBA, _sTT, _maKhoa, _sTTKhoa, _soCT, _maMienGiam, _soTien, _soTienUSD, _tyGia, _ngayKy.DBValue, _ghiChu, _maPT, _nguoiKy, _maMay, _huy, _nguoiSD);
				// }				
			
		}

        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            //_nguoiHuy = HTC.ShareVariables.pub_sNguoiSD;
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maBA, _sTT));
            MarkNew();
        }
        //protected override void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new Criteria(_maBA, _sTT));
        //}

		/// <summary>
		/// Delete the <see cref="BenhAn_MienGiam" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_MienGiam
            DataProvider.Instance().DeleteBenhAn_MienGiam(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.STT);
			// public abstract void DeleteBenhAn_MienGiam(String _maBA, Int32 _sTT);
			// public override void DeleteBenhAn_MienGiam(String _maBA, Int32 _sTT);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_MienGiam_DELETED", _maBA, _sTT);
			// }
		}

		#endregion
	}

}
