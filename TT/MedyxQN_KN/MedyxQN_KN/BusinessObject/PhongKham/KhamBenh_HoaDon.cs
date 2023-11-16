// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	KhamBenh_HoaDon
// Kieu doi tuong  :	KhamBenh_HoaDon
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	4/2/2009 3:21:38 PM
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
using HTC.Business.CategoryList;

namespace HTC.Business.PhongKham
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="KhamBenh_HoaDon" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class KhamBenh_HoaDon : BusinessBase<KhamBenh_HoaDon>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maSoKham = String.Empty;
		private Int32 _sTT = 0;
		private String _maBN = String.Empty;
		private SmartDate _ngayDK = new SmartDate(true);
		private Decimal _TongThu = 0;
        private Decimal _ThucThu = 0;
        private Decimal _TongBHTra = 0;
        private Decimal _TongBH = 0;
        private Decimal _TongTienBH = 0;
        private Decimal _TongTienBHCu = 0;
		private Decimal _TongChi = 0;
        private Decimal _TongChiCu = 0;
		private String _soHD = String.Empty;
        private Byte _loai = 0;
        private Byte _lanin = 0;
		private String _soSoHD = String.Empty;
		private Int32 _sophieu = 0;
        private int _OrderNumber;
		private String _NguoiThu = String.Empty;
	
		private String _NguoiChi = String.Empty;
		private SmartDate _NgayThu = new SmartDate(true);
	
		private SmartDate _NgayChi = new SmartDate(true);
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngayHuy = new SmartDate(true);
		private String _LydoThu = String.Empty;
        private String _LydoChi = String.Empty;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _nguoiHuy = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
        private String _hoten = String.Empty;
        private String _tenNguoiThu = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
       
        private String _tenNguoChi = String.Empty;
        private SmartDate _ngaySDD = new SmartDate(true);
        private SmartDate _ngayThuD = new SmartDate(true);
        private SmartDate _ngayChiD = new SmartDate(true);
        private String _noiTT = String.Empty;
        private String _maDT = String.Empty;
        private String _noiCT = String.Empty;
		#endregion
		
		#region Business Properties and Methods
        public int OrderNumber
        {
            get
            {
                CanReadProperty("OrderNumber", true);
                return _OrderNumber;
            }
            set
            {
                CanWriteProperty("OrderNumber", true);
                if (_OrderNumber != value)
                {
                    _OrderNumber = value;
                    PropertyHasChanged("OrderNumber");
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
        public String NoiCT
        {
            get
            {
                CanReadProperty("NoiCT", true);
                return _noiCT;
            }
            set
            {
                CanWriteProperty("NoiCT", true);
                if (_noiCT != value)
                {
                    _noiCT = value;
                    PropertyHasChanged("NoiCT");
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
        public string ThucThu
        {
            get
            {
                CanReadProperty("ThucThu", true);
                if (_TongThu - _TongChi  == 0)
                {
                    return "0";
                }
                else if ((_TongThu - _TongChi) - (int)(_TongThu - _TongChi) != 0)
                {
                    return (_TongThu - _TongChi).ToString("###,###.###");
                }
                else
                {
                    return (_TongThu - _TongChi).ToString("###,###");
                }
            }
        
        }
		public Decimal TongThu
		{
			get 
			{
				CanReadProperty("TongThu", true);
				return _TongThu;
			}
			set 
			{
				CanWriteProperty("TongThu", true);
				if (_TongThu != value) 
				{
					_TongThu = value;
					PropertyHasChanged("TongThu");
				}
			}
		}
		
		public Decimal TongChi
		{
			get 
			{
				CanReadProperty("TongChi", true);
				return _TongChi;
			}
			set 
			{
				CanWriteProperty("TongChi", true);
				if (_TongChi != value) 
				{
					_TongChi = value;
					PropertyHasChanged("TongChi");
				}
			}
		}
        public Decimal TongChiCu
        {
            get
            {
                CanReadProperty("TongChiCu", true);
                return _TongChiCu;
            }
            set
            {
                CanWriteProperty("TongChiCu", true);
                if (_TongChiCu != value)
                {
                    _TongChiCu = value;
                    PropertyHasChanged("TongChiCu");
                }
            }
        }
        public Decimal TongBHTra
        {
            get
            {
                CanReadProperty("TongBHTra", true);
                return _TongBHTra;
            }
            set
            {
                CanWriteProperty("TongBHTra", true);
                if (_TongBHTra != value)
                {
                    _TongBHTra = value;
                    PropertyHasChanged("TongBHTra");
                }
            }
        }
        public Decimal TongBH
        {
            get
            {
                CanReadProperty("TongBH", true);
                return _TongBH;
            }
            set
            {
                CanWriteProperty("TongBH", true);
                if (_TongBH != value)
                {
                    _TongBH = value;
                    PropertyHasChanged("TongBH");
                }
            }
        }
        public Decimal TongTienBH
        {
            get
            {
                CanReadProperty("TongTienBH", true);
                return _TongTienBH;
            }
            set
            {
                CanWriteProperty("TongTienBH", true);
                if (_TongTienBH != value)
                {
                    _TongTienBH = value;
                    PropertyHasChanged("TongTienBH");
                }
            }
        }
        //public Decimal TongTienBHCu
        //{
        //    get
        //    {
        //        CanReadProperty("TongTienBHCu", true);
        //        return _TongTienBHCu;
        //    }
        //    set
        //    {
        //        CanWriteProperty("TongTienBHCu", true);
        //        if (_TongTienBHCu != value)
        //        {
        //            _TongTienBHCu = value;
        //            PropertyHasChanged("TongTienBHCu");
        //        }
        //    }
        //}
	
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
		public String NguoiThu
		{
			get 
			{
				CanReadProperty("NguoiThu", true);
				return _NguoiThu;
			}
			set 
			{
				CanWriteProperty("NguoiThu", true);
				if (_NguoiThu != value) 
				{
					_NguoiThu = value;
					PropertyHasChanged("NguoiThu");
				}
			}
		}
	
		public String NguoiChi
		{
			get 
			{
				CanReadProperty("NguoiChi", true);
				return _NguoiChi;
			}
			set 
			{
				CanWriteProperty("NguoiChi", true);
				if (_NguoiChi != value) 
				{
					_NguoiChi = value;
					PropertyHasChanged("NguoiChi");
				}
			}
		}
		
		public string NgayThu
		{
			get 
			{
				CanReadProperty("NgayThu", true);
				return _NgayThu.Text;
			}
			set 
			{
				CanWriteProperty("NgayThu", true);
				if (_NgayThu.Text != value) 
				{
					_NgayThu.Text = value;
					PropertyHasChanged("NgayThu");
				}
			}
		}
		
		
		
	
		
		public string NgayChi
		{
			get 
			{
				CanReadProperty("NgayChi", true);
				return _NgayChi.Text;
			}
			set 
			{
				CanWriteProperty("NgayChi", true);
				if (_NgayChi.Text != value) 
				{
					_NgayChi.Text = value;
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
		
		public String LydoThu
		{
			get 
			{
				CanReadProperty("LydoThu", true);
				return _LydoThu;
			}
			set 
			{
				CanWriteProperty("LydoThu", true);
				if (_LydoThu != value) 
				{
					_LydoThu = value;
					PropertyHasChanged("LydoThu");
				}
			}
		}
        public String LydoChi
        {
            get
            {
                CanReadProperty("LydoChi", true);
                return _LydoChi;
            }
            set
            {
                CanWriteProperty("LydoChi", true);
                if (_LydoChi != value)
                {
                    _LydoChi = value;
                    PropertyHasChanged("LydoChi");
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
        //public String NgaySDD
        //{
        //    get
        //    {
        //        CanReadProperty("NgaySDD", true);
        //        _ngaySDD = _ngaySD;
        //        this._ngaySDD.FormatString = "dd/MM/yyyy";
        //        return _ngaySDD.Text;
        //    }

        //}
        //public String ngayThuD
        //{
        //    get
        //    {
        //        CanReadProperty("ngayThuD", true);
        //        _ngayThuD = _NgayThu;
        //        this._ngayThuD.FormatString = "dd/MM/yyyy";
        //        return _ngayThuD.Text;
        //    }

        //}
        //public String ngayChiD
        //{
        //    get
        //    {
        //        CanReadProperty("ngayChiD", true);
        //        _ngayChiD = _NgayChi;
        //        this._ngayChiD.FormatString = "dd/MM/yyyy";
        //        return _ngayChiD.Text;
        //    }

        //}
        public String tenNguoChi
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
		protected override Object GetIdValue()
		{
			return _maSoKham.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="KhamBenh_HoaDon" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

        public static KhamBenh_HoaDon NewKhamBenh_HoaDon()
        {
            return new KhamBenh_HoaDon();
        }
      
		public static KhamBenh_HoaDon GetKhamBenh_HoaDon(String maSoKham, Int32 sTT)
		{
			return DataPortal.Fetch<KhamBenh_HoaDon>(new Criteria(maSoKham, sTT ));
		}
        public static KhamBenh_HoaDon GetKhamBenh_HoaDon(String sosohd, String sohd)
        {
            return DataPortal.Fetch<KhamBenh_HoaDon>(new CriteriaOther(sosohd, sohd));
        }
        public static KhamBenh_HoaDon GetKhamBenh_HoaDon(SafeDataReader dr)
        {
            return new KhamBenh_HoaDon(dr);
        }
        public static KhamBenh_HoaDon GetKhamBenh_HoaDon(SafeDataReader dr,int i)
        {
            return new KhamBenh_HoaDon(dr,i);
        }
		/// <summary>
		/// Marks the <see cref="KhamBenh_HoaDon" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
		public static void DeleteKhamBenh_HoaDon(String maSoKham, Int32 sTT)
		{
            DataPortal.Delete(new Criteria( maSoKham, sTT ));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal KhamBenh_HoaDon()
		{	
			// Prevent direct creation
		}
		protected KhamBenh_HoaDon(KhamBenh   pro)
        {
           // MarkAsChild();
           
           
        }
        protected KhamBenh_HoaDon(SafeDataReader dr)
        {
           // MarkAsChild();

            Fetch(dr);
            MarkOld();
        }
        protected KhamBenh_HoaDon(SafeDataReader dr,int i)
        {
          //  MarkAsChild();

            Fetch(dr,i);
            MarkOld();
        }
		#endregion

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
             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private string _NguoiSD = "" ;
            public String NguoiSD
            {
                get
                {
                    return _NguoiSD;
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
        protected class CriteriaOther
        {
            private String _sosohd;
            public String SoSoHD
            {
                get
                {
                    return _sosohd;
                }
            }
             private String _sohd;
            public String SoHD
            {
                get
                {
                    return _sohd;
                }
            }
             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
          
         
            public CriteriaOther(String sosohd, String sohd)
            {
                _sosohd  = sosohd ;
                _sohd = sohd;

            }

            

            
        }
		#endregion
		
		
		#region Data Access

		/// <summary>
		/// Retrieve an existing <see cref="KhamBenh_HoaDon" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetKhamBenh_HoaDon(String _maSoKham, Int32 _sTT);
			// public override IDataReader GetKhamBenh_HoaDon(String _maSoKham, Int32 _sTT)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maSoKham, _sTT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKhamBenh_HoaDon(crit.MaSoKham, crit.STT )))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
        protected void DataPortal_Fetch(CriteriaOther crit)
        {
            // public abstract IDataReader GetKhamBenh_HoaDon(String _maSoKham, Int32 _sTT);
            // public override IDataReader GetKhamBenh_HoaDon(String _maSoKham, Int32 _sTT)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maSoKham, _sTT));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKhamBenh_HoaDon(crit.SoSoHD , crit.SoHD )))
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
		/// Load a <see cref="KhamBenh_HoaDon" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaSoKham") != null) _maSoKham = dr.GetString("MaSoKham");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
		
			if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
			if (dr.GetSmartDate("NgayDK", true) != null) _ngayDK = dr.GetSmartDate("NgayDK", true);
			if (dr.GetDecimal("TongThu") != null) _TongThu = dr.GetDecimal("TongThu");
			if (dr.GetDecimal("TongChi") != null) _TongChi = dr.GetDecimal("TongChi");
            if (dr.GetDecimal("TongChi") != null) _TongChiCu = dr.GetDecimal("TongChi");
            if (dr.GetDecimal("TongTienBH") != null) _TongTienBH = dr.GetDecimal("TongTienBH");
            if (dr.GetDecimal("TongBHTra") != null) _TongBHTra = dr.GetDecimal("TongBHTra");
            if (dr.GetDecimal("TongBH") != null) _TongBHTra = dr.GetDecimal("TongBH");
            if (dr.GetDecimal("TongTienBH") != null) _TongTienBHCu = dr.GetDecimal("TongTienBH");
			if (dr.GetString("SoHD") != null) _soHD = dr.GetString("SoHD");
			if (dr.GetString("SoSoHD") != null) _soSoHD = dr.GetString("SoSoHD");
			if (dr.GetInt32("Sophieu") != null) _sophieu = dr.GetInt32("Sophieu");
            if (dr.GetByte("lanin") != null) _lanin = dr.GetByte("lanin");
            if (dr.GetByte("loai") != null) _loai = dr.GetByte("loai");
			if (dr.GetString("NguoiThu") != null) _NguoiThu = dr.GetString("NguoiThu");
			
			if (dr.GetString("NguoIChi") != null) _NguoiChi = dr.GetString("NguoiChi");
			if (dr.GetSmartDate("NgayThu", true) != null) _NgayThu = dr.GetSmartDate("NgayThu", true);
		
			if (dr.GetSmartDate("NgayChi", true) != null) _NgayChi = dr.GetSmartDate("NgayChi", true);
			
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
			if (dr.GetString("LydoThu") != null) _LydoThu = dr.GetString("LydoThu");
            if (dr.GetString("Lydochi") != null) _LydoChi = dr.GetString("Lydochi");

			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
         
            if (dr.GetString("TENNguoiThu") != null) _tenNguoiThu = dr.GetString("TENNguoiThu");
            if (dr.GetString("TENNGUOILAP") != null) _tenNguoiLap = dr.GetString("TENNGUOILAP");
            if (dr.GetString("TENNGUOISD") != null) _tenNguoiSD = dr.GetString("TENNGUOISD");
            if (dr.GetString("TENNGUOIHUY") != null) _tenNguoiHuy = dr.GetString("TENNGUOIHUY");
            if (dr.GetString("NoiTT") != null) _noiTT = dr.GetString("NoiTT");
            if (dr.GetString("hoten") != null) _hoten = dr.GetString("hoten");
            if (dr.GetString("MADT") != null) _maDT = dr.GetString("MADT");
   
            if (dr.GetString("tenNguoIChi") != null) _tenNguoChi = dr.GetString("tenNguoIChi");
		}
        private void Fetch(SafeDataReader dr,int i)
        {
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaSoKham") != null) _maSoKham = dr.GetString("MaSoKham");
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");

            if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
            if (dr.GetSmartDate("NgayDK", true) != null) _ngayDK = dr.GetSmartDate("NgayDK", true);
            if (dr.GetDecimal("TongThu") != null) _TongThu = dr.GetDecimal("TongThu");
            if (dr.GetDecimal("TongChi") != null) _TongChi = dr.GetDecimal("TongChi");
            if (dr.GetDecimal("TongChi") != null) _TongChiCu = dr.GetDecimal("TongChi");
            if (dr.GetDecimal("TongTienBH") != null) _TongTienBH = dr.GetDecimal("TongTienBH");
            if (dr.GetDecimal("TongBHTra") != null) _TongBHTra = dr.GetDecimal("TongBHTra");
            if (dr.GetDecimal("TongBH") != null) _TongBHTra = dr.GetDecimal("TongBH");
            if (dr.GetDecimal("TongTienBH") != null) _TongTienBHCu = dr.GetDecimal("TongTienBH");
            if (dr.GetString("SoHD") != null) _soHD = dr.GetString("SoHD");
            if (dr.GetString("SoSoHD") != null) _soSoHD = dr.GetString("SoSoHD");
            if (dr.GetInt32("Sophieu") != null) _sophieu = dr.GetInt32("Sophieu");
            if (dr.GetByte("lanin") != null) _lanin = dr.GetByte("lanin");
            if (dr.GetByte("loai") != null) _loai = dr.GetByte("loai");
            if (dr.GetString("NguoiThu") != null) _NguoiThu = dr.GetString("NguoiThu");

            if (dr.GetString("NguoIChi") != null) _NguoiChi = dr.GetString("NguoiChi");
            if (dr.GetSmartDate("NgayThu", true) != null) _NgayThu = dr.GetSmartDate("NgayThu", true);

            if (dr.GetSmartDate("NgayChi", true) != null) _NgayChi = dr.GetSmartDate("NgayChi", true);

            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
            if (dr.GetString("LydoThu") != null) _LydoThu = dr.GetString("LydoThu");
            if (dr.GetString("Lydochi") != null) _LydoChi = dr.GetString("Lydochi");

            if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
            if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
            if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");

            if (dr.GetString("TENNguoiThu") != null) _tenNguoiThu = dr.GetString("TENNguoiThu");
            if (dr.GetString("TENNGUOILAP") != null) _tenNguoiLap = dr.GetString("TENNGUOILAP");
            if (dr.GetString("TENNGUOISD") != null) _tenNguoiSD = dr.GetString("TENNGUOISD");
            if (dr.GetString("TENNGUOIHUY") != null) _tenNguoiHuy = dr.GetString("TENNGUOIHUY");
            if (dr.GetString("NoiTT") != null) _noiTT = dr.GetString("NoiTT");
            if (dr.GetString("MADT") != null) _maDT = dr.GetString("MADT");
            if (dr.GetString("hoten") != null) _hoten = dr.GetString("hoten");
            if (dr.GetString("tenNguoIChi") != null) _tenNguoChi = dr.GetString("tenNguoIChi");
        }
		
		/// <summary>
		/// Insert the new <see cref="KhamBenh_HoaDon" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh_HoaDon
			// Copy & paste ham duoi day vao file DataProvider.cs
            if ((_TongChi !=0) || (_TongThu !=0))
                _soHD = DataProvider.Instance().InsertKhamBenh_HoaDon(_maSoKham, _maBN, _ngayDK, _TongThu, _soHD, _soSoHD, _sophieu, _NgayThu  ,_maMay ,_nguoiSD, _NguoiThu, _LydoThu, _loai, _lanin, _LydoChi,_TongChi,_TongTienBH ,_TongBHTra,_TongBH,_noiTT,_maDT);
            MarkOld();// public abstract String InsertKhamBenh_HoaDon(String _maSoKham, Int32 _sTT, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _TongThu, Decimal _TongChi, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _ck, String _NguoiThu, Boolean _tinhtien, Boolean _bHTinhTien, Byte _dATT, Boolean _tToanSau, String _NguoiChi, SmartDate _NgayThu, Boolean _daTra, String _nguoiTra, SmartDate _NgayChi, String _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, SmartDate _ngayHuy, String _LydoThu, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngaySD, String _nguoiSD, String _nguoiHuy, SmartDate _ngaySD1, String _nguoiSD1);
			// public override String InsertKhamBenh_HoaDon(String _maSoKham, Int32 _sTT, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _TongThu, Decimal _TongChi, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _ck, String _NguoiThu, Boolean _tinhtien, Boolean _bHTinhTien, Byte _dATT, Boolean _tToanSau, String _NguoiChi, SmartDate _NgayThu, Boolean _daTra, String _nguoiTra, SmartDate _NgayChi, String _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, SmartDate _ngayHuy, String _LydoThu, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngaySD, String _nguoiSD, String _nguoiHuy, SmartDate _ngaySD1, String _nguoiSD1);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maSoKham, _sTT, _maCPMau, _maBN, _ngayDK.DBValue, _TongThu, _TongChi, _dongiaTT, _donGiaBH, _giaChenhLech, _soHD, _soSoHD, _sophieu, _ck, _NguoiThu, _tinhtien, _bHTinhTien, _dATT, _tToanSau, _NguoiChi, _NgayThu.DBValue, _daTra, _nguoiTra, _NgayChi.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _nguoiD, _nguoiP, _ngayD.DBValue,_maMay ,   _huy, _ngayHuy.DBValue, _LydoThu, _ngayLap.DBValue,_nguoiSD , _ngaySD.DBValue,false   ,_nguoiSD, _ngaySD1.DBValue, _nguoiSD1), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="KhamBenh_HoaDon" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_HoaDon
			if (IsDirty){
                DataProvider.Instance().UpdateKhamBenh_HoaDon(_maSoKham, _sTT, _maBN, _ngayDK, _soHD, _soSoHD, _sophieu, _TongThu, _TongChi, _NgayThu, _NgayChi, _NguoiThu, _NguoiChi, _maMay , _huy, _nguoiSD , _LydoThu, _lanin, _LydoChi, _TongTienBH, _TongBHTra, _TongBH, _noiTT,_maDT,_noiCT );
				// public abstract void UpdateKhamBenh_HoaDon(String _maSoKham, Int32 _sTT, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _TongThu, Decimal _TongChi, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _ck, String _NguoiThu, Boolean _tinhtien, Boolean _bHTinhTien, Byte _dATT, Boolean _tToanSau, String _NguoiChi, SmartDate _NgayThu, Boolean _daTra, String _nguoiTra, SmartDate _NgayChi, String _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, SmartDate _ngayHuy, String _LydoThu, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngaySD, String _nguoiSD, String _nguoiHuy, SmartDate _ngaySD1, String _nguoiSD1);
				// public override void UpdateKhamBenh_HoaDon(String _maSoKham, Int32 _sTT, String _maCPMau, String _maBN, SmartDate _ngayDK, Decimal _TongThu, Decimal _TongChi, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _ck, String _NguoiThu, Boolean _tinhtien, Boolean _bHTinhTien, Byte _dATT, Boolean _tToanSau, String _NguoiChi, SmartDate _NgayThu, Boolean _daTra, String _nguoiTra, SmartDate _NgayChi, String _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, SmartDate _ngayHuy, String _LydoThu, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngaySD, String _nguoiSD, String _nguoiHuy, SmartDate _ngaySD1, String _nguoiSD1);
				// {
				//		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maSoKham, _sTT, _maCPMau, _maBN, _ngayDK.DBValue, _TongThu, _TongChi, _dongiaTT, _donGiaBH, _giaChenhLech, _soHD, _soSoHD, _sophieu, _ck, _NguoiThu, _tinhtien, _bHTinhTien, _dATT, _tToanSau, _NguoiChi, _NgayThu.DBValue, _daTra, _nguoiTra, _NgayChi.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _nguoiD, _nguoiP, _ngayD.DBValue,_maMay ,   _huy, _ngayHuy.DBValue, _LydoThu, _ngayLap.DBValue,_nguoiSD , _ngaySD.DBValue,false   ,_nguoiSD, _ngaySD1.DBValue, _nguoiSD1);
				// }	
                MarkOld();
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
			DataPortal_Delete(new Criteria(_maSoKham, _sTT ));
		}

		/// <summary>
		/// Delete the <see cref="KhamBenh_HoaDon" />.
		/// </summary>
		protected void DataPortal_Delete(Criteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_HoaDon

			DataProvider.Instance().DeleteKhamBenh_HoaDon(crit.NguoiSD,crit.NguoiSD ,crit.MaSoKham, crit.STT  );
			// public abstract void DeleteKhamBenh_HoaDon(String _maSoKham, Int32 _sTT);
			// public override void DeleteKhamBenh_HoaDon(String _maSoKham, Int32 _sTT);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_HoaDon_Deleted", _maSoKham, _sTT);
			// }
		}
        internal virtual void Update(KhamBenh bill)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_PhieuIn_C
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateKhamBenh_HoaDon(bill.MaSoKham, _sTT, bill.MaBN, SmartDate.Parse(bill.NgayDK), _soHD, _soSoHD, _sophieu, _TongThu, _TongChi, _NgayThu, _NgayChi, _NguoiThu, _NguoiChi,_maMay ,   _huy,_nguoiSD ,_LydoThu,_lanin,_LydoChi,_TongTienBH,_TongBHTra ,_TongBH,_noiTT ,_maDT ,_noiCT   );

                MarkOld();			
            }
        }
        internal virtual void Update( )
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_PhieuIn_C
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateKhamBenh_HoaDon(_maSoKham, _sTT, _maBN, _ngayDK , _soHD, _soSoHD, _sophieu, _TongThu, _TongChi, _NgayThu, _NgayChi, _NguoiThu, _NguoiChi, _maMay , _huy, _nguoiSD , _LydoThu, _lanin, _LydoChi, _TongTienBH, _TongBHTra, _TongBH,_noiTT ,_maDT,_noiCT );
                MarkOld();

            }
        }
        internal virtual void Insert(KhamBenh bill)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_PhieuIn_C
            if (IsDirty)
            {
                
                
             _soHD =   DataProvider.Instance().InsertKhamBenh_HoaDon(bill.MaSoKham, bill.MaBN, SmartDate.Parse(bill.NgayDK), _TongThu, _soHD, _soSoHD, _sophieu, _NgayThu, _maMay , _nguoiSD , _NguoiThu, _LydoThu, _loai, _lanin, _LydoChi, _TongChi, _TongTienBH, _TongBHTra, _TongBH, _noiTT, _maDT);
                MarkOld();
                			
            }
        }

        internal void DeleteSelf(KhamBenh bill)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;

            DataProvider.Instance().DeleteKhamBenh_HoaDon(_maMay,_nguoiSD, bill.MaSoKham, _sTT);
            MarkNew();
        }
        internal virtual void Update(KhamBenh_Q bill)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_PhieuIn_C
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateKhamBenh_HoaDon(bill.MaSoKham, _sTT, bill.MaBN, SmartDate.Parse(bill.NgayDK), _soHD, _soSoHD, _sophieu, _TongThu, _TongChi, _NgayThu, _NgayChi, _NguoiThu, _NguoiChi, _maMay , _huy,_nguoiSD, _LydoThu, _lanin, _LydoChi, _TongTienBH, _TongBHTra, _TongBH, _noiTT, _maDT, _noiCT);

                MarkOld();
            }
        }
        internal virtual void Insert(KhamBenh_Q bill)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_PhieuIn_C
            if (IsDirty)
            {
                
                
             _soHD =   DataProvider.Instance().InsertKhamBenh_HoaDon(bill.MaSoKham, bill.MaBN, SmartDate.Parse(bill.NgayDK), _TongThu, _soHD, _soSoHD, _sophieu, _NgayThu, _maMay , _nguoiSD , _NguoiThu, _LydoThu, _loai, _lanin, _LydoChi, _TongChi, _TongTienBH, _TongBHTra, _TongBH, _noiTT, _maDT);
                MarkOld();

            }
        }

        internal void DeleteSelf(KhamBenh_Q bill)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;

            DataProvider.Instance().DeleteKhamBenh_HoaDon(_maMay, _nguoiSD , bill.MaSoKham, _sTT);
            MarkNew();
        }
     
		#endregion
	}

}
