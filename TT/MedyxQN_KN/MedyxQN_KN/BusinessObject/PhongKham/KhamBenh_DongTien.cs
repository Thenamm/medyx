// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	KhamBenh_DongTien
// Kieu doi tuong  :	KhamBenh_DongTien
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	7/27/2009 9:23:29 AM
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

namespace HTC.Business.PhongKham
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="KhamBenh_DongTien" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class KhamBenh_DongTien : BusinessBase<KhamBenh_DongTien>
	{
		#region Business Methods
		
		#region State Fields
        private Byte _loai = 0;
        private String _noiTT = String.Empty;
      
        private String _nguoiTT = String.Empty;
        private SmartDate _ngayTToan = new SmartDate(true);
		private String _maSoKham = String.Empty;
		private Int32 _sTT = 0;
		private String _maKhoa = String.Empty;
	
		private String _sPThu = String.Empty;
		private String _maLDThuTien = String.Empty;
        private string _tenLDThuTien = string.Empty;
        private Decimal _soTien = 0;
		private Decimal _soTienUSD = 0;
		private Decimal _tyGia = 0;
		private SmartDate _ngayDong = new SmartDate(true);
        private SmartDate _ngayDongD = new SmartDate("",true);
		private String _ghiChu = String.Empty;
		private String _maPT = String.Empty;
		private String _nguoiThu = String.Empty;
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
        private String _tenNguoiThu = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private String _tenPT = String.Empty;
        private String _maDT = String.Empty;
        private int _OrderNumber;
        private byte _lanin = 0;
		#endregion
		
		#region Business Properties and Methods
        public Byte loai
        {
            get
            {
                CanReadProperty("loai", true);
                return _loai;
            }
            set
            {
                CanWriteProperty("loai", true);
                if (_loai != value)
                {
                    _loai = value;
                    PropertyHasChanged("loai");
                }
            }
        }
        public String NoiTT
        {
            get
            {
                CanReadProperty("NoiTT", true);
                return _noiTT;
            }
            set
            {
                CanWriteProperty("NoiTT", true);
                if (_noiTT != value)
                {
                    _noiTT = value;
                    PropertyHasChanged("NoiTT");
                }
            }
        }
        public Byte lanin
        {
            get
            {
                CanReadProperty("lanin", true);
                return _lanin;
            }
            set
            {
                CanWriteProperty("lanin", true);
                if (_lanin != value)
                {
                    _lanin = value;
                    PropertyHasChanged("lanin");
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
		public String MaSoKham
		{
			get 
			{
				CanReadProperty("MaSoKham", true);
				return _maSoKham;
			}
			set 
			{
				CanWriteProperty("MaSoKham", true);
				if (_maSoKham != value) 
				{
					_maSoKham = value;
					PropertyHasChanged("MaSoKham");
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
		
	
		
		public String SPThu
		{
			get 
			{
				CanReadProperty("SPThu", true);
				return _sPThu;
			}
			set 
			{
				CanWriteProperty("SPThu", true);
				if (_sPThu != value) 
				{
					_sPThu = value;
					PropertyHasChanged("SPThu");
				}
			}
		}
		
		public String MaLDThuTien
		{
			get 
			{
				CanReadProperty("MaLDThuTien", true);
				return _maLDThuTien;
			}
			set 
			{
				CanWriteProperty("MaLDThuTien", true);
				if (_maLDThuTien != value) 
				{
					_maLDThuTien = value;
					PropertyHasChanged("MaLDThuTien");
				}
			}
		}
        public String TenLDThuTien
        {
            get
            {
                CanReadProperty("TenLDThuTien", true);
                return _tenLDThuTien;
            }
            set
            {
                CanWriteProperty("TenLDThuTien", true);
                if (_tenLDThuTien != value)
                {
                    _tenLDThuTien = value;
                    PropertyHasChanged("TenLDThuTien");
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
		
		public string NgayDong
		{
			get 
			{
				CanReadProperty("NgayDong", true);
				return _ngayDong.Text;
			}
			set 
			{
				CanWriteProperty("NgayDong", true);
				if (_ngayDong.Text != value) 
				{
					_ngayDong.Text = value;
					PropertyHasChanged("NgayDong");
				}
			}
		}

        public string NgayDongD
        {
            get
            {
                //CanReadProperty("NgayDong", true);
                _ngayDongD = _ngayDong;
                _ngayDongD.FormatString = "dd/MM/yyyy HH:mm ";
                return _ngayDongD.Text;
            }
            set
            {
                //CanWriteProperty("NgayDong", true);
                if (_ngayDongD.Text != value)
                {
                    _ngayDongD.Text = value;
                  //  PropertyHasChanged("NgayDong");
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
		
		public String NguoiThu
		{
			get 
			{
				CanReadProperty("NguoiThu", true);
				return _nguoiThu;
			}
			set 
			{
				CanWriteProperty("NguoiThu", true);
				if (_nguoiThu != value) 
				{
					_nguoiThu = value;
					PropertyHasChanged("NguoiThu");
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
		
        //public string NgaySD1
        //{
        //    get 
        //    {
        //        CanReadProperty("NgaySD1", true);
        //        return _ngaySD1.Text;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NgaySD1", true);
        //        if (_ngaySD1.Text != value) 
        //        {
        //            _ngaySD1.Text = value;
        //            PropertyHasChanged("NgaySD1");
        //        }
        //    }
        //}
		
        //public String NguoiSD1
        //{
        //    get 
        //    {
        //        CanReadProperty("NguoiSD1", true);
        //        return _nguoiSD1;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NguoiSD1", true);
        //        if (_nguoiSD1 != value) 
        //        {
        //            _nguoiSD1 = value;
        //            PropertyHasChanged("NguoiSD1");
        //        }
        //    }
        //}
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
        //public String TenNguoiSD
        //{
        //    get
        //    {
        //        CanReadProperty("TenNguoiSD", true);
        //        return _tenNguoiSD;
        //    }
        //    set
        //    {
        //        CanWriteProperty("TenNguoiSD", true);
        //        if (_tenNguoiSD != value)
        //        {
        //            _tenNguoiSD = value;
        //            PropertyHasChanged("TenNguoiSD");
        //        }
        //    }
        //}
        //public String TenNguoiHuy
        //{
        //    get
        //    {
        //        CanReadProperty("TenNguoiHuy", true);
        //        return _tenNguoiHuy;
        //    }
        //    set
        //    {
        //        CanWriteProperty("TenNguoiHuy", true);
        //        if (_tenNguoiHuy != value)
        //        {
        //            _tenNguoiHuy = value;
        //            PropertyHasChanged("TenNguoiHuy");
        //        }
        //    }
        //}

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

        public String TenNguoiThu
        {
            get
            {
                CanReadProperty("TenNguoiThu", true);
                return _tenNguoiThu;
            }
            set
            {
                CanWriteProperty("TenNguoiThu", true);
                if (_tenNguoiThu != value)
                {
                    _tenNguoiThu = value;
                    PropertyHasChanged("TenNguoiThu");
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
			return _maSoKham.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="KhamBenh_DongTien" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static KhamBenh_DongTien NewKhamBenh_DongTien()
        {
            return DataPortal.Create<KhamBenh_DongTien>();
            //return new KhamBenh_ThuocSD();


        }
        internal static KhamBenh_DongTien GetKhamBenh_DongTien(SafeDataReader dr, int i)
        {
            return new KhamBenh_DongTien(dr, i);
        }
        public KhamBenh_DongTien()
        {
            MarkAsChild();
        }
                //public static KhamBenh_DongTien GetKhamBenh_DongTien(String maSoKham, Int32 sTT)
                //{
                //    return DataPortal.Fetch<KhamBenh_DongTien>(new Criteria(maSoKham, sTT));
                //}
        		
                ///// <summary>
                ///// Marks the <see cref="KhamBenh_DongTien" /> Object for deletion. The Object will be deleted as part of the next save operation.
                ///// </summary>
                //public static void DeleteKhamBenh_DongTien(String maSoKham, Int32 sTT)
                //{
                //    DataPortal.Delete(new Criteria(maSoKham, sTT));
                //}
		
		#endregion
		
        //#region Constructors
        //// Chu y !!!
        //// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        //// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal KhamBenh_DongTien()
        //{	
        //    // Prevent direct creation
        //}
		
        //#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maSoKham;
			public String MaSoKham 
			{
				get
				{
					return _maSoKham;
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
			
			public Criteria(String maSoKham, Int32 sTT)
			{
				_maSoKham = maSoKham;
				_sTT = sTT;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maSoKham.Equals(c._maSoKham)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maSoKham.ToString(), _sTT.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maSoKham;
            public String MaSoKham
            {
                get
                {
                    return _maSoKham;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maSoKham, Int32 sTT)
            {
                _maSoKham = maSoKham;
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
        ///// Retrieve an existing <see cref="KhamBenh_DongTien" /> Object based on data in the database.
        ///// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetKhamBenh_DongTien(String _maSoKham, Int32 _sTT);
        //    // public override IDataReader GetKhamBenh_DongTien(String _maSoKham, Int32 _sTT)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maSoKham, _sTT));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKhamBenh_DongTien(crit.MaSoKham, crit.STT)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="KhamBenh_DongTien" /> Object from given SafeDataReader.
		/// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaSoKham") != null) _maSoKham = dr.GetString("MaSoKham");
        //    if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
        //    if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
    
        //    if (dr.GetString("SPThu") != null) _sPThu = dr.GetString("SPThu");
        //    if (dr.GetString("MaLDThuTien") != null) _maLDThuTien = dr.GetString("MaLDThuTien");
        //    if (dr.GetDecimal("SoTien") != null) _soTien = dr.GetDecimal("SoTien");
        //    if (dr.GetDecimal("SoTienUSD") != null) _soTienUSD = dr.GetDecimal("SoTienUSD");
        //    if (dr.GetDecimal("TyGia") != null) _tyGia = dr.GetDecimal("TyGia");
        //    if (dr.GetSmartDate("NgayDong", true) != null) _ngayDong = dr.GetSmartDate("NgayDong", true);
        //    if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
        //    if (dr.GetString("MaPT") != null) _maPT = dr.GetString("MaPT");
        //    if (dr.GetString("NguoiThu") != null) _nguoiThu = dr.GetString("NguoiThu");
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

        private KhamBenh_DongTien(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaSoKham") != null) _maSoKham = dr.GetString("MaSoKham");
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
         
            if (dr.GetString("sophieu") != null) _sPThu = dr.GetString("sophieu");
            if (dr.GetString("MaLDThuTien") != null) _maLDThuTien = dr.GetString("MaLDThuTien");
            if (dr.GetString("TenLDThuTien") != null) _tenLDThuTien  = dr.GetString("TenLDThuTien");
            if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
            if (dr.GetDecimal("SoTien") != null) _soTien = dr.GetDecimal("SoTien");
            if (dr.GetDecimal("SoTienUSD") != null) _soTienUSD = dr.GetDecimal("SoTienUSD");
            if (dr.GetDecimal("TyGia") != null) _tyGia = dr.GetDecimal("TyGia");
            if (dr.GetSmartDate("NgayDong", true) != null) _ngayDong = dr.GetSmartDate("NgayDong", true);
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetString("MaPT") != null) _maPT = dr.GetString("MaPT");
          
            if (dr.GetByte("lanin") != null) _lanin = dr.GetByte("lanin");
	
            if (dr.GetString("NguoiThu") != null) _nguoiThu = dr.GetString("NguoiThu");
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
            if (dr.GetString("TenPT") != null) _tenPT = dr.GetString("TenPT");
            if (dr.GetString("TenNguoiThu") != null) _tenNguoiThu = dr.GetString("TenNguoiThu");
            if (dr.GetString("NoiTT") != null) _noiTT = dr.GetString("NoiTT");
       
 
          
            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="KhamBenh_DongTien" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            _ngayLap.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }
        internal void Insert()
        {
			// TODO: Kiem tra lai cac tham so truyen vao cho ham CriteriaOther(mamay,nguoihuy , _DongTien
			// Copy & paste ham duoi day vao file DataProvider.cs
             if (!this.IsDirty)
                return;
            
            
             string sohd = DataProvider.Instance().InsertKhamBenh_DongTien(_maSoKham, _maKhoa, _maLDThuTien, _noiTT, _loai, _soTien, _soTienUSD, _tyGia, _ngayDong, _ghiChu, _maPT, _nguoiThu, _maMay,_nguoiSD, _sPThu, _maDT, _lanin);
             _sPThu = sohd;
            MarkOld();// public abstract String InsertKhamBenh_DongTien(String _maSoKham, Int32 _sTT, String _maKhoa, String _sPThu, String _maLDThuTien, Decimal _soTien, Decimal _soTienUSD, Decimal _tyGia, SmartDate _ngayDong, String _ghiChu, String _maPT, String _nguoiThu, String _maMay, String _nguoiSD);
			// public override String InsertKhamBenh_DongTien(String _maSoKham, Int32 _sTT, String _maKhoa, String _sPThu, String _maLDThuTien, Decimal _soTien, Decimal _soTienUSD, Decimal _tyGia, SmartDate _ngayDong, String _ghiChu, String _maPT, String _nguoiThu, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_DONGTIEN_CREATE", _maSoKham, _sTT, _maKhoa, _sPThu, _maLDThuTien, _soTien, _soTienUSD, _tyGia, _ngayDong.DBValue, _ghiChu, _maPT, _nguoiThu, _maMay, _nguoiSD));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="KhamBenh_DongTien" /> Object to underlying database.
		/// </summary>
        internal void Update()
        {
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_DongTien
			if (!this.IsDirty)
                return;
            
              
				DataProvider.Instance().UpdateKhamBenh_DongTien(_maSoKham, _sTT, _maKhoa, _maLDThuTien, _soTien, _soTienUSD, _tyGia, _ngayDong, _ghiChu, _maPT, _nguoiThu, _maMay, _huy, _nguoiSD ,_sPThu,_maDT ,_lanin );
				// public abstract void UpdateKhamBenh_DongTien(String _maSoKham, Int32 _sTT, String _maKhoa, String _sPThu, String _maLDThuTien, Decimal _soTien, Decimal _soTienUSD, Decimal _tyGia, SmartDate _ngayDong, String _ghiChu, String _maPT, String _nguoiThu, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateKhamBenh_DongTien(String _maSoKham, Int32 _sTT, String _maKhoa, String _sPThu, String _maLDThuTien, Decimal _soTien, Decimal _soTienUSD, Decimal _tyGia, SmartDate _ngayDong, String _ghiChu, String _maPT, String _nguoiThu, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_DONGTIEN_UPDATE", _maSoKham, _sTT, _maKhoa, _sPThu, _maLDThuTien, _soTien, _soTienUSD, _tyGia, _ngayDong.DBValue, _ghiChu, _maPT, _nguoiThu, _maMay, _huy, _nguoiSD);
				// }	
                MarkOld();
			
		}

        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            //_nguoiHuy = HTC.ShareVariables.pub_sNguoiSD;
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maSoKham, _sTT));
            MarkNew();
        }
        //protected override void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new Criteria(_maSoKham, _sTT));
        //}

		/// <summary>
		/// Delete the <see cref="KhamBenh_DongTien" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_DongTien
            DataProvider.Instance().DeleteKhamBenh_DongTien(crit.MaMay, crit.NguoiSD, crit.MaSoKham, crit.STT);
			// public abstract void DeleteKhamBenh_DongTien(String _maSoKham, Int32 _sTT);
			// public override void DeleteKhamBenh_DongTien(String _maSoKham, Int32 _sTT);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_DONGTIEN_DELETED", _maSoKham, _sTT);
			// }
		}
        //


        protected override void DataPortal_Insert()
        {
      
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh_DongTien
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
            
            string sohd ="";
            sohd = DataProvider.Instance().InsertKhamBenh_DongTien(_maSoKham, _maKhoa,_maLDThuTien,_noiTT ,_loai , _soTien, _soTienUSD, _tyGia, _ngayDong, _ghiChu, _maPT, _nguoiThu, _maMay, _nguoiSD , _sPThu, _maDT, _lanin);
            _sPThu = sohd;
            // public abstract String InsertKhamBenh_DongTien(String _maSoKham, Int32 _sTT, String _maKhoa, String _sPThu, String _maLDThuTien, Decimal _soTien, Decimal _soTienUSD, Decimal _tyGia, SmartDate _ngayDong, String _ghiChu, String _maPT, String _nguoiThu, String _maMay, String _nguoiSD);
            // public override String InsertKhamBenh_DongTien(String _maSoKham, Int32 _sTT, String _maKhoa, String _sPThu, String _maLDThuTien, Decimal _soTien, Decimal _soTienUSD, Decimal _tyGia, SmartDate _ngayDong, String _ghiChu, String _maPT, String _nguoiThu, String _maMay, String _nguoiSD)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_DONGTIEN_CREATE", _maSoKham, _sTT, _maKhoa, _sPThu, _maLDThuTien, _soTien, _soTienUSD, _tyGia, _ngayDong.DBValue, _ghiChu, _maPT, _nguoiThu, _maMay, _nguoiSD));
            // }
            MarkOld();
        }

        /// <summary>
        /// Update all changes made on <see cref="KhamBenh_DongTien" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_DongTien
            if (!this.IsDirty)
                return;
            
              
            DataProvider.Instance().UpdateKhamBenh_DongTien(_maSoKham, _sTT, _maKhoa, _maLDThuTien, _soTien, _soTienUSD, _tyGia, _ngayDong, _ghiChu, _maPT, _nguoiThu, _maMay, _huy, _nguoiSD , _sPThu, _maDT, _lanin);
            // public abstract void UpdateKhamBenh_DongTien(String _maSoKham, Int32 _sTT, String _maKhoa, String _sPThu, String _maLDThuTien, Decimal _soTien, Decimal _soTienUSD, Decimal _tyGia, SmartDate _ngayDong, String _ghiChu, String _maPT, String _nguoiThu, String _maMay, Boolean _huy, String _nguoiSD);
            // public override void UpdateKhamBenh_DongTien(String _maSoKham, Int32 _sTT, String _maKhoa, String _sPThu, String _maLDThuTien, Decimal _soTien, Decimal _soTienUSD, Decimal _tyGia, SmartDate _ngayDong, String _ghiChu, String _maPT, String _nguoiThu, String _maMay, Boolean _huy, String _nguoiSD)
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_DONGTIEN_UPDATE", _maSoKham, _sTT, _maKhoa, _sPThu, _maLDThuTien, _soTien, _soTienUSD, _tyGia, _ngayDong.DBValue, _ghiChu, _maPT, _nguoiThu, _maMay, _huy, _nguoiSD);
            // }	
            MarkOld();

        }

        protected override void DataPortal_DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            //_nguoiHuy = HTC.ShareVariables.pub_sNguoiSD;
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maSoKham, _sTT));
            MarkNew();
        }
		#endregion
	}

}
