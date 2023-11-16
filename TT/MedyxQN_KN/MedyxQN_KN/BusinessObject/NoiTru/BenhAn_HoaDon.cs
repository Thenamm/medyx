// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_HoaDon
// Kieu doi tuong  :	BenhAn_HoaDon
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	9/29/2009 9:33:09 AM
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

namespace HTC.Business.NoiTru
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="BenhAn_HoaDon" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_HoaDon : BusinessBase<BenhAn_HoaDon>
	{
		#region Business Methods
		
		#region State Fields
        private String _maDT = String.Empty;
        private Byte _dATT = 0;
        private String _nguoiTT = String.Empty;
        private SmartDate _ngayTToan = new SmartDate(true);
		private String _maBA = String.Empty;
		private Int32 _sTT = 0;
		private String _maBN = String.Empty;
		private SmartDate _ngayDK = new SmartDate(true);
		private String _soHD = String.Empty;
		private String _soSoHD = String.Empty;
		private Int32 _sophieu = 0;
		private Decimal _tongThu = 0;
		private Decimal _tongChi = 0;
		private SmartDate _ngayThu = new SmartDate(true);
		private SmartDate _ngayChi = new SmartDate(true);
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngayHuy = new SmartDate(true);
		private String _nguoiHuy = String.Empty;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
        private SmartDate _ngaySDD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
		private String _lYDOThu = String.Empty;
		private String _nGUOITHU = String.Empty;
		private String _nGUOICHI = String.Empty;
		private Byte _lanIn = 0;
		private Byte _loai = 0;
		private String _lYDOChi = String.Empty;
        private String _tenNguoiThu = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private SmartDate _ngayThuD = new SmartDate(true);
        private SmartDate _ngayChiD = new SmartDate(true);
        private String _tenNguoiChi = String.Empty;
        private String _maKhoa = String.Empty;
        private Decimal _soLuong = 1;
        private String _mabs = String.Empty;
        private String _tenbs = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;
		#endregion
		
		#region Business Properties and Methods
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
        public string SoLuong
        {
            get
            {
                CanReadProperty("SoLuong", true);
                if (_soLuong == 0)
                {
                    return "0";
                }
                else if (_soLuong - (int)(_soLuong) != 0)
                {
                    return _soLuong.ToString("###,###.##");
                }
                else
                {
                    return _soLuong.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoLuong", true);

                if (_soLuong.ToString() != value)
                {
                    _soLuong = decimal.Parse(value);
                    PropertyHasChanged("SoLuong");
                }
            }
        }
        public String mabs
        {
            get
            {
                CanReadProperty("mabs", true);
                return _mabs;
            }
            set
            {
                CanWriteProperty("mabs", true);
                if (_mabs != value)
                {
                    _mabs = value;
                    PropertyHasChanged("mabs");
                }
            }
        }
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
        public String NgaySDD
        {
            get
            {
                CanReadProperty("NgaySDD", true);
                _ngaySDD = _ngaySD;
                this._ngaySDD.FormatString = "dd/MM/yyyy";
                return _ngaySDD.Text;
            }

        }
        public String ngayThuD
        {
            get
            {
                CanReadProperty("ngayThuD", true);
                _ngayThuD = _ngayThu;
                this._ngayThuD.FormatString = "dd/MM/yyyy";
                return _ngayThuD.Text;
            }

        }
        public String ngayChiD
        {
            get
            {
                CanReadProperty("ngayChiD", true);
                _ngayChiD = _ngayChi;
                this._ngayChiD.FormatString = "dd/MM/yyyy";
                return _ngayChiD.Text;
            }

        }
		public String MaBN
		{
			get 
			{
				CanReadProperty("MaBN", true);
				return _maBN;
			}
			set 
			{
				CanWriteProperty("MaBN", true);
				if (_maBN != value) 
				{
					_maBN = value;
					PropertyHasChanged("MaBN");
				}
			}
		}
		
		public string NgayDK
		{
			get 
			{
				CanReadProperty("NgayDK", true);
				return _ngayDK.Text;
			}
			set 
			{
				CanWriteProperty("NgayDK", true);
				if (_ngayDK.Text != value) 
				{
					_ngayDK.Text = value;
					PropertyHasChanged("NgayDK");
				}
			}
		}
		
		public String SoHD
		{
			get 
			{
				CanReadProperty("SoHD", true);
				return _soHD;
			}
			set 
			{
				CanWriteProperty("SoHD", true);
				if (_soHD != value) 
				{
					_soHD = value;
					PropertyHasChanged("SoHD");
				}
			}
		}
		
		public String SoSoHD
		{
			get 
			{
				CanReadProperty("SoSoHD", true);
				return _soSoHD;
			}
			set 
			{
				CanWriteProperty("SoSoHD", true);
				if (_soSoHD != value) 
				{
					_soSoHD = value;
					PropertyHasChanged("SoSoHD");
				}
			}
		}
		
		public Int32 Sophieu
		{
			get 
			{
				CanReadProperty("Sophieu", true);
				return _sophieu;
			}
			set 
			{
				CanWriteProperty("Sophieu", true);
				if (_sophieu != value) 
				{
					_sophieu = value;
					PropertyHasChanged("Sophieu");
				}
			}
		}
        public string ThucThu
        {
            get
            {
                CanReadProperty("ThucThu", true);
                if ((_tongThu -_tongChi)  == 0)
                {
                    return "0";
                }
               
                else
                {
                    return (_tongThu -_tongChi).ToString("###,###");
                }
            }
          
        }
   
		public Decimal TongThu
		{
			get 
			{
				CanReadProperty("TongThu", true);
				return _tongThu;
			}
			set 
			{
				CanWriteProperty("TongThu", true);
				if (_tongThu != value) 
				{
					_tongThu = value;
					PropertyHasChanged("TongThu");
				}
			}
		}
		
		public Decimal TongChi
		{
			get 
			{
				CanReadProperty("TongChi", true);
				return _tongChi;
			}
			set 
			{
				CanWriteProperty("TongChi", true);
				if (_tongChi != value) 
				{
					_tongChi = value;
					PropertyHasChanged("TongChi");
				}
			}
		}
		
		public string NgayThu
		{
			get 
			{
				CanReadProperty("NgayThu", true);
				return _ngayThu.Text;
			}
			set 
			{
				CanWriteProperty("NgayThu", true);
				if (_ngayThu.Text != value) 
				{
					_ngayThu.Text = value;
					PropertyHasChanged("NgayThu");
				}
			}
		}
		
		public string NgayChi
		{
			get 
			{
				CanReadProperty("NgayChi", true);
				return _ngayChi.Text;
			}
			set 
			{
				CanWriteProperty("NgayChi", true);
				if (_ngayChi.Text != value) 
				{
					_ngayChi.Text = value;
					PropertyHasChanged("NgayChi");
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
		
		public String LYDOThu
		{
			get 
			{
				CanReadProperty("LYDOThu", true);
				return _lYDOThu;
			}
			set 
			{
				CanWriteProperty("LYDOThu", true);
				if (_lYDOThu != value) 
				{
					_lYDOThu = value;
					PropertyHasChanged("LYDOThu");
				}
			}
		}
		
		public String NGUOITHU
		{
			get 
			{
				CanReadProperty("NGUOITHU", true);
				return _nGUOITHU;
			}
			set 
			{
				CanWriteProperty("NGUOITHU", true);
				if (_nGUOITHU != value) 
				{
					_nGUOITHU = value;
					PropertyHasChanged("NGUOITHU");
				}
			}
		}
		
		public String NGUOICHI
		{
			get 
			{
				CanReadProperty("NGUOICHI", true);
				return _nGUOICHI;
			}
			set 
			{
				CanWriteProperty("NGUOICHI", true);
				if (_nGUOICHI != value) 
				{
					_nGUOICHI = value;
					PropertyHasChanged("NGUOICHI");
				}
			}
		}
		
		public Byte LanIn
		{
			get 
			{
				CanReadProperty("LanIn", true);
				return _lanIn;
			}
			set 
			{
				CanWriteProperty("LanIn", true);
				if (_lanIn != value) 
				{
					_lanIn = value;
					PropertyHasChanged("LanIn");
				}
			}
		}
		
		public Byte Loai
		{
			get 
			{
				CanReadProperty("Loai", true);
				return _loai;
			}
			set 
			{
				CanWriteProperty("Loai", true);
				if (_loai != value) 
				{
					_loai = value;
					PropertyHasChanged("Loai");
				}
			}
		}
		
		public String LYDOChi
		{
			get 
			{
				CanReadProperty("LYDOChi", true);
				return _lYDOChi;
			}
			set 
			{
				CanWriteProperty("LYDOChi", true);
				if (_lYDOChi != value) 
				{
					_lYDOChi = value;
					PropertyHasChanged("LYDOChi");
				}
			}
		}
		public String tenNguoiThu
        {
            get
            {
                CanReadProperty("tenNguoiThu", true);
                return _tenNguoiThu;
            }
            set
            {
                CanWriteProperty("tenNguoiThu", true);
                if (_tenNguoiThu != value)
                {
                    _tenNguoiThu = value;
                    PropertyHasChanged("tenNguoiThu");
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
        
        public String tenNguoiChi
        {
            get
            {
                CanReadProperty("tenNguoiChi", true);
                return _tenNguoiChi;
            }
            set
            {
                CanWriteProperty("tenNguoiChi", true);
                if (_tenNguoiChi != value)
                {
                    _tenNguoiChi = value;
                    PropertyHasChanged("tenNguoiChi");
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
		protected override Object GetIdValue()
		{
			return _maBA.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhAn_HoaDon" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BenhAn_HoaDon NewBenhAn_HoaDon()
        {
            return new BenhAn_HoaDon();
        }
        //public static BenhAn_HoaDon GetBenhAn_HoaDon(Int32 sTT, String maBA, Int32 sTTKhoa)
        //{
        //    return DataPortal.Fetch<BenhAn_HoaDon>(new Criteria(sTT, maBA, sTTKhoa));
        //}
        internal static BenhAn_HoaDon GetBenhAn_HoaDon(SafeDataReader dr, int i)
        {
            return new BenhAn_HoaDon(dr, i);
        }
        //public static BenhAn_HoaDon GetBenhAn_HoaDon(String maBA, Int32 sTT)
        //{
        //    return DataPortal.Fetch<BenhAn_HoaDon>(new Criteria(maBA, sTT));
        //}
		
		/// <summary>
		/// Marks the <see cref="BenhAn_HoaDon" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteBenhAn_HoaDon(String maBA, Int32 sTT)
        //{
        //    DataPortal.Delete(new Criteria(maBA, sTT));
        //}
        public BenhAn_HoaDon()
        {
            MarkAsChild();
        }
		#endregion
		
        //#region Constructors
        //// Chu y !!!
        //// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        //// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal BenhAn_HoaDon()
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

		/// <summary>
		/// Retrieve an existing <see cref="BenhAn_HoaDon" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetBenhAn_HoaDon(String _maBA, Int32 _sTT);
        //    // public override IDataReader GetBenhAn_HoaDon(String _maBA, Int32 _sTT)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBA, _sTT));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_HoaDon(crit.MaBA, crit.STT)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="BenhAn_HoaDon" /> Object from given SafeDataReader.
		/// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
        //    if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
        //    if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
        //    if (dr.GetSmartDate("NgayDK", true) != null) _ngayDK = dr.GetSmartDate("NgayDK", true);
        //    if (dr.GetString("SoHD") != null) _soHD = dr.GetString("SoHD");
        //    if (dr.GetString("SoSoHD") != null) _soSoHD = dr.GetString("SoSoHD");
        //    if (dr.GetInt32("Sophieu") != null) _sophieu = dr.GetInt32("Sophieu");
        //    if (dr.GetDecimal("TongThu") != null) _tongThu = dr.GetDecimal("TongThu");
        //    if (dr.GetDecimal("TongChi") != null) _tongChi = dr.GetDecimal("TongChi");
        //    if (dr.GetSmartDate("NgayThu", true) != null) _ngayThu = dr.GetSmartDate("NgayThu", true);
        //    if (dr.GetSmartDate("NgayChi", true) != null) _ngayChi = dr.GetSmartDate("NgayChi", true);
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
        //    if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
        //    if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
        //    if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
        //    if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //    if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
        //    if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
        //    if (dr.GetString("LYDOThu") != null) _lYDOThu = dr.GetString("LYDOThu");
        //    if (dr.GetString("NGUOITHU") != null) _nGUOITHU = dr.GetString("NGUOITHU");
        //    if (dr.GetString("NGUOICHI") != null) _nGUOICHI = dr.GetString("NGUOICHI");
        //    if (dr.GetByte("LanIn") != null) _lanIn = dr.GetByte("LanIn");
        //    if (dr.GetByte("Loai") != null) _loai = dr.GetByte("Loai");
        //    if (dr.GetString("LYDOChi") != null) _lYDOChi = dr.GetString("LYDOChi");
        //}
		
		/// <summary>
		/// Insert the new <see cref="BenhAn_HoaDon" /> Object to underlying database.
		/// </summary>
        /// 

        private BenhAn_HoaDon(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
			if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
            if (dr.GetByte("DATT") != null) _dATT = dr.GetByte("DATT");
            if (dr.GetByte("stt") != null) _sTT = dr.GetByte("stt");
		
			if (dr.GetSmartDate("NgayDK", true) != null) _ngayDK = dr.GetSmartDate("NgayDK", true);
			if (dr.GetString("SoHD") != null) _soHD = dr.GetString("SoHD");
            if (dr.GetString("madt") != null) _maDT = dr.GetString("madt");
            if (dr.GetString("makhoa") != null) _maDT = dr.GetString("makhoa");
			if (dr.GetString("SoSoHD") != null) _soSoHD = dr.GetString("SoSoHD");
			if (dr.GetInt32("Sophieu") != null) _sophieu = dr.GetInt32("Sophieu");
			if (dr.GetDecimal("TongThu") != null) _tongThu = dr.GetDecimal("TongThu");
			if (dr.GetDecimal("TongChi") != null) _tongChi = dr.GetDecimal("TongChi");
			if (dr.GetSmartDate("NgayThu", true) != null) _ngayThu = dr.GetSmartDate("NgayThu", true);
			if (dr.GetSmartDate("NgayChi", true) != null) _ngayChi = dr.GetSmartDate("NgayChi", true);
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
			if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
			if (dr.GetString("LYDOThu") != null) _lYDOThu = dr.GetString("LYDOThu");
			if (dr.GetString("NGUOITHU") != null) _nGUOITHU = dr.GetString("NGUOITHU");
			if (dr.GetString("NGUOICHI") != null) _nGUOICHI = dr.GetString("NGUOICHI");
			if (dr.GetByte("LanIn") != null) _lanIn = dr.GetByte("LanIn");
			if (dr.GetByte("Loai") != null) _loai = dr.GetByte("Loai");
			if (dr.GetString("LYDOChi") != null) _lYDOChi = dr.GetString("LYDOChi");
            if (dr.GetString("tennguoiSD") != null) _tenNguoiSD = dr.GetString("tennguoiSD");
            if (dr.GetString("TenNguoiLap") != null) _tenNguoiLap = dr.GetString("TenNguoiLap");
            if (dr.GetString("TenNguoiHuy") != null) _tenNguoiHuy = dr.GetString("TenNguoiHuy");
            if (dr.GetString("TenNguoiChi") != null) _tenNguoiChi = dr.GetString("TenNguoiChi");
            if (dr.GetString("TenNguoiThu") != null) _tenNguoiThu = dr.GetString("TenNguoiThu");
            if (dr.GetString("Mabs") != null) _mabs = dr.GetString("Mabs");
            if (dr.GetString("TENbs") != null) _tenbs = dr.GetString("TENbs");
            if (dr.GetString("hoten") != null) _hoten = dr.GetString("hoten");
            if (dr.GetDecimal("SoLuong") != null) _soLuong = dr.GetDecimal("SoLuong");
            MarkOld();
        }

        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
            
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_HoaDon
			// Copy & paste ham duoi day vao file DataProvider.cs
            _maBA = DataProvider.Instance().InsertBenhAn_HoaDon(_maBA, _maBN, _ngayDK, _soHD, _soSoHD, _sophieu, _tongThu, _tongChi, _ngayThu, _maMay, _nguoiSD , _lYDOThu, _nGUOITHU, _lanIn, _loai, _lYDOChi,_dATT,_maDT ,_maKhoa,_soLuong ,_mabs );
			// public abstract String InsertBenhAn_HoaDon(String _maBA, String _maBN, SmartDate _ngayDK, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _tongThu, Decimal _tongChi, SmartDate _ngayThu, String _maMay, String _nguoiLap, String _lYDOThu, String _nGUOITHU, Byte _lanIn, Byte _loai, String _lYDOChi);
			// public override String InsertBenhAn_HoaDon(String _maBA, String _maBN, SmartDate _ngayDK, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _tongThu, Decimal _tongChi, SmartDate _ngayThu, String _maMay, String _nguoiLap, String _lYDOThu, String _nGUOITHU, Byte _lanIn, Byte _loai, String _lYDOChi)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_HoaDon_Create", _maBA, _maBN, _ngayDK.DBValue, _soHD, _soSoHD, _sophieu, _tongThu, _tongChi, _ngayThu.DBValue, _maMay, _nguoiSD , _lYDOThu, _nGUOITHU, _lanIn, _loai, _lYDOChi), String);
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAn_HoaDon" /> Object to underlying database.
		/// </summary>
		 internal void Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
            if (!this.IsDirty)
                return;
            
              
            DataProvider.Instance().UpdateBenhAn_HoaDon(_maBA, _sTT, _maBN, _ngayDK, _soHD, _soSoHD, _sophieu, _tongThu, _tongChi, _ngayThu, _ngayChi, _maMay, _huy, _nguoiSD , _lYDOThu, _nGUOITHU, _nGUOICHI, _lanIn, _lYDOChi, _dATT, _soLuong, _mabs);
				// public abstract void UpdateBenhAn_HoaDon(String _maBA, Int32 _sTT, String _maBN, SmartDate _ngayDK, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _tongThu, Decimal _tongChi, SmartDate _ngayThu, SmartDate _ngayChi, String _maMay, Boolean _huy, String _nguoiSD, String _lYDOThu, String _nGUOITHU, String _nGUOICHI, Byte _lanIn, String _lYDOChi);
				// public override void UpdateBenhAn_HoaDon(String _maBA, Int32 _sTT, String _maBN, SmartDate _ngayDK, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _tongThu, Decimal _tongChi, SmartDate _ngayThu, SmartDate _ngayChi, String _maMay, Boolean _huy, String _nguoiSD, String _lYDOThu, String _nGUOITHU, String _nGUOICHI, Byte _lanIn, String _lYDOChi)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_HoaDon_Update", _maBA, _sTT, _maBN, _ngayDK.DBValue, _soHD, _soSoHD, _sophieu, _tongThu, _tongChi, _ngayThu.DBValue, _ngayChi.DBValue, _maMay, _huy, _nguoiSD , _lYDOThu, _nGUOITHU, _nGUOICHI, _lanIn, _lYDOChi);
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
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maBA, _sTT ));
            MarkNew();
        }

		/// <summary>
		/// Delete the <see cref="BenhAn_HoaDon" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_HoaDon
            DataProvider.Instance().DeleteBenhAn_HoaDon(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.STT);
			// public abstract void DeleteBenhAn_HoaDon(String _maBA, Int32 _sTT);
			// public override void DeleteBenhAn_HoaDon(String _maBA, Int32 _sTT)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_HoaDon_Deleted", _maBA, _sTT);
			// }
		}

		#endregion
	}

}
