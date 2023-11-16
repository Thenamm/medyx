// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	PhieuThuChi
// Kieu doi tuong  :	PhieuThuChi
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
	/// This is a base generated class of <see cref="PhieuThuChi" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class PhieuThuChi : BusinessBase<PhieuThuChi>
	{
		#region Business Methods
		
		#region State Fields
        private Byte _loai = 0;
        private String _noiTT = String.Empty;
      
       
		private String _SoPhieu = String.Empty;
		
		private String _bskham = String.Empty;
	
		
		private String _maLDThuTien = String.Empty;
        private string _tenLDThuTien = string.Empty;
        private Decimal _soTien = 0;
		private Decimal _soTienUSD = 0;
		private Decimal _tyGia = 0;
		private SmartDate _ngayDong = new SmartDate(true);
        private SmartDate _ngayDongD = new SmartDate("",true);
		private String _ghiChu = String.Empty;
	
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
        private String _tenbs = String.Empty;
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
     
       
		public String SoPhieu
		{
			get 
			{
				CanReadProperty("SoPhieu", true);
				return _SoPhieu;
			}
			set 
			{
				CanWriteProperty("SoPhieu", true);
				if (_SoPhieu != value) 
				{
					_SoPhieu = value;
					PropertyHasChanged("SoPhieu");
				}
			}
		}
		
	
		
		public String bskham
		{
			get 
			{
				CanReadProperty("bskham", true);
				return _bskham;
			}
			set 
			{
				CanWriteProperty("bskham", true);
				if (_bskham != value) 
				{
					_bskham = value;
					PropertyHasChanged("bskham");
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
        public String tenbs
        {
            get
            {
                CanReadProperty("tenbs", true);
                return _tenbs;
            }
            set
            {
                CanWriteProperty("tenbs", true);
                if (_tenbs != value)
                {
                    _tenbs = value;
                    PropertyHasChanged("tenbs");
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
            return _SoPhieu.ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="PhieuThuChi" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static PhieuThuChi NewPhieuThuChi()
        {
            return DataPortal.Create<PhieuThuChi>();
            //return new KhamBenh_ThuocSD();


        }
        public static PhieuThuChi GetPhieuThuChi(String SoPhieu)
        {
            return DataPortal.Fetch<PhieuThuChi>(new Criteria(SoPhieu));
        }
        internal static PhieuThuChi GetPhieuThuChi(SafeDataReader dr, int i)
        {
            return new PhieuThuChi(dr, i);
        }
        public PhieuThuChi()
        {
           // MarkAsChild();
        }
                //public static PhieuThuChi GetPhieuThuChi(String SoPhieu, Int32 sTT)
                //{
                //    return DataPortal.Fetch<PhieuThuChi>(new Criteria(SoPhieu, sTT));
                //}
        		
                ///// <summary>
                ///// Marks the <see cref="PhieuThuChi" /> Object for deletion. The Object will be deleted as part of the next save operation.
                ///// </summary>
                //public static void DeletePhieuThuChi(String SoPhieu, Int32 sTT)
                //{
                //    DataPortal.Delete(new Criteria(SoPhieu, sTT));
                //}
		
		#endregion
		
        //#region Constructors
        //// Chu y !!!
        //// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        //// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal PhieuThuChi()
        //{	
        //    // Prevent direct creation
        //}
		
        //#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _SoPhieu;
			public String SoPhieu 
			{
				get
				{
					return _SoPhieu;
				}
			}
			
		
			
			public Criteria(String SoPhieu)
			{
				_SoPhieu = SoPhieu;
			
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_SoPhieu.Equals(c._SoPhieu)) 
						return false;
				
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _SoPhieu.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _SoPhieu;
            public String SoPhieu
            {
                get
                {
                    return _SoPhieu;
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
            public OtherCriteria(String Mamay, String Nguoisd, String SoPhieu)
            {
                _SoPhieu = SoPhieu;
               
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
        ///// Retrieve an existing <see cref="PhieuThuChi" /> Object based on data in the database.
        ///// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetPhieuThuChi(String _SoPhieu, Int32 _sTT);
            // public override IDataReader GetPhieuThuChi(String _SoPhieu, Int32 _sTT)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _SoPhieu, _sTT));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetPhieuThuChi(crit.SoPhieu)))
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
		/// Load a <see cref="PhieuThuChi" /> Object from given SafeDataReader.
		/// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("SoPhieu") != null) _SoPhieu = dr.GetString("SoPhieu");

            if (dr.GetString("bskham") != null) _bskham = dr.GetString("bskham");


            if (dr.GetString("MaLDThuTien") != null) _maLDThuTien = dr.GetString("MaLDThuTien");
            if (dr.GetString("TenLDThuTien") != null) _tenLDThuTien = dr.GetString("TenLDThuTien");

            if (dr.GetDecimal("SoTien") != null) _soTien = dr.GetDecimal("SoTien");
            if (dr.GetDecimal("SoTienUSD") != null) _soTienUSD = dr.GetDecimal("SoTienUSD");
            if (dr.GetDecimal("TyGia") != null) _tyGia = dr.GetDecimal("TyGia");
            if (dr.GetSmartDate("NgayDong", true) != null) _ngayDong = dr.GetSmartDate("NgayDong", true);
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");


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
            if (dr.GetString("tenbs") != null) _tenbs = dr.GetString("tenbs");
            if (dr.GetString("TenNguoiThu") != null) _tenNguoiThu = dr.GetString("TenNguoiThu");
            if (dr.GetString("NoiTT") != null) _noiTT = dr.GetString("NoiTT");
        }

        private PhieuThuChi(SafeDataReader dr, int i)
        {
           // MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("SoPhieu") != null) _SoPhieu = dr.GetString("SoPhieu");
         
            if (dr.GetString("bskham") != null) _bskham = dr.GetString("bskham");
         
         
            if (dr.GetString("MaLDThuTien") != null) _maLDThuTien = dr.GetString("MaLDThuTien");
            if (dr.GetString("TenLDThuTien") != null) _tenLDThuTien  = dr.GetString("TenLDThuTien");
          
            if (dr.GetDecimal("SoTien") != null) _soTien = dr.GetDecimal("SoTien");
            if (dr.GetDecimal("SoTienUSD") != null) _soTienUSD = dr.GetDecimal("SoTienUSD");
            if (dr.GetDecimal("TyGia") != null) _tyGia = dr.GetDecimal("TyGia");
            if (dr.GetSmartDate("NgayDong", true) != null) _ngayDong = dr.GetSmartDate("NgayDong", true);
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
          
          
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
            if (dr.GetString("tenbs") != null) _tenbs = dr.GetString("tenbs");
            if (dr.GetString("TenNguoiThu") != null) _tenNguoiThu = dr.GetString("TenNguoiThu");
            if (dr.GetString("NoiTT") != null) _noiTT = dr.GetString("NoiTT");
       
 
          
            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="PhieuThuChi" /> Object to underlying database.
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
            
            
             string sohd = DataProvider.Instance().InsertPhieuThuChi( _bskham, _maLDThuTien, _noiTT, _loai, _soTien, _soTienUSD, _tyGia, _ngayDong, _ghiChu, _nguoiThu, _maMay,_nguoiSD,  _lanin);
             _SoPhieu = sohd;
            MarkOld();// public abstract String InsertPhieuThuChi(String _SoPhieu, Int32 _sTT, String _bskham, String _sPThu, String _maLDThuTien, Decimal _soTien, Decimal _soTienUSD, Decimal _tyGia, SmartDate _ngayDong, String _ghiChu, String _maPT, String _nguoiThu, String _maMay, String _nguoiSD);
			// public override String InsertPhieuThuChi(String _SoPhieu, Int32 _sTT, String _bskham, String _sPThu, String _maLDThuTien, Decimal _soTien, Decimal _soTienUSD, Decimal _tyGia, SmartDate _ngayDong, String _ghiChu, String _maPT, String _nguoiThu, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spPhieuThuChi_CREATE", _SoPhieu, _sTT, _bskham, _sPThu, _maLDThuTien, _soTien, _soTienUSD, _tyGia, _ngayDong.DBValue, _ghiChu, _maPT, _nguoiThu, _maMay, _nguoiSD));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="PhieuThuChi" /> Object to underlying database.
		/// </summary>
        internal void Update()
        {
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdatePhieuThuChi
			if (!this.IsDirty)
                return;
            
              
				DataProvider.Instance().UpdatePhieuThuChi(_SoPhieu,  _bskham, _maLDThuTien, _soTien, _soTienUSD, _tyGia, _ngayDong, _ghiChu, _nguoiThu, _maMay, _huy, _nguoiSD ,_lanin );
				// public abstract void UpdatePhieuThuChi(String _SoPhieu, Int32 _sTT, String _bskham, String _sPThu, String _maLDThuTien, Decimal _soTien, Decimal _soTienUSD, Decimal _tyGia, SmartDate _ngayDong, String _ghiChu, String _maPT, String _nguoiThu, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdatePhieuThuChi(String _SoPhieu, Int32 _sTT, String _bskham, String _sPThu, String _maLDThuTien, Decimal _soTien, Decimal _soTienUSD, Decimal _tyGia, SmartDate _ngayDong, String _ghiChu, String _maPT, String _nguoiThu, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spPhieuThuChi_UPDATE", _SoPhieu, _sTT, _bskham, _sPThu, _maLDThuTien, _soTien, _soTienUSD, _tyGia, _ngayDong.DBValue, _ghiChu, _maPT, _nguoiThu, _maMay, _huy, _nguoiSD);
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
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _SoPhieu));
            MarkNew();
        }
        //protected override void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new Criteria(_SoPhieu, _sTT));
        //}

		/// <summary>
		/// Delete the <see cref="PhieuThuChi" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdatePhieuThuChi
            DataProvider.Instance().DeletePhieuThuChi(crit.MaMay, crit.NguoiSD, crit.SoPhieu);
			// public abstract void DeletePhieuThuChi(String _SoPhieu, Int32 _sTT);
			// public override void DeletePhieuThuChi(String _SoPhieu, Int32 _sTT);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spPhieuThuChi_DELETED", _SoPhieu, _sTT);
			// }
		}
        //


        protected override void DataPortal_Insert()
        {
      
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertPhieuThuChi
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
            
            string sohd ="";
            sohd = DataProvider.Instance().InsertPhieuThuChi( _bskham,_maLDThuTien,_noiTT ,_loai , _soTien, _soTienUSD, _tyGia,_ngayDong, _ghiChu, _nguoiThu, _maMay, _nguoiSD, _lanin);
            _SoPhieu = sohd;
            // public abstract String InsertPhieuThuChi(String _SoPhieu, Int32 _sTT, String _bskham, String _sPThu, String _maLDThuTien, Decimal _soTien, Decimal _soTienUSD, Decimal _tyGia, SmartDate _ngayDong, String _ghiChu, String _maPT, String _nguoiThu, String _maMay, String _nguoiSD);
            // public override String InsertPhieuThuChi(String _SoPhieu, Int32 _sTT, String _bskham, String _sPThu, String _maLDThuTien, Decimal _soTien, Decimal _soTienUSD, Decimal _tyGia, SmartDate _ngayDong, String _ghiChu, String _maPT, String _nguoiThu, String _maMay, String _nguoiSD)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spPhieuThuChi_CREATE", _SoPhieu, _sTT, _bskham, _sPThu, _maLDThuTien, _soTien, _soTienUSD, _tyGia, _ngayDong.DBValue, _ghiChu, _maPT, _nguoiThu, _maMay, _nguoiSD));
            // }
            MarkOld();
        }

        /// <summary>
        /// Update all changes made on <see cref="PhieuThuChi" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdatePhieuThuChi
            if (!this.IsDirty)
                return;
            
              
            DataProvider.Instance().UpdatePhieuThuChi(_SoPhieu, _bskham, _maLDThuTien, _soTien, _soTienUSD, _tyGia, _ngayDong, _ghiChu,_nguoiThu, _maMay, _huy, _nguoiSD , _lanin);
            // public abstract void UpdatePhieuThuChi(String _SoPhieu, Int32 _sTT, String _bskham, String _sPThu, String _maLDThuTien, Decimal _soTien, Decimal _soTienUSD, Decimal _tyGia, SmartDate _ngayDong, String _ghiChu, String _maPT, String _nguoiThu, String _maMay, Boolean _huy, String _nguoiSD);
            // public override void UpdatePhieuThuChi(String _SoPhieu, Int32 _sTT, String _bskham, String _sPThu, String _maLDThuTien, Decimal _soTien, Decimal _soTienUSD, Decimal _tyGia, SmartDate _ngayDong, String _ghiChu, String _maPT, String _nguoiThu, String _maMay, Boolean _huy, String _nguoiSD)
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spPhieuThuChi_UPDATE", _SoPhieu, _sTT, _bskham, _sPThu, _maLDThuTien, _soTien, _soTienUSD, _tyGia, _ngayDong.DBValue, _ghiChu, _maPT, _nguoiThu, _maMay, _huy, _nguoiSD);
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
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _SoPhieu));
            MarkNew();
        }
		#endregion
	}

}
