// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMChePhamMau
// Kieu doi tuong  :	DMChePhamMau
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	3/5/2009 10:11:23 AM
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
//

namespace HTC.Business.CategoryList
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="DMChePhamMau" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMChePhamMau : BusinessBase<DMChePhamMau>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _MaCPMau = String.Empty;
		private String _TenCPMau = String.Empty;
        private String _tenTMHL = String.Empty;
		private String _tenTA = String.Empty;
		private String _ghichu = String.Empty;
		private String _maNhom = String.Empty;
		private string _hamluong = String.Empty;
		private Decimal _nguong = 0;
		private String _maDVT = String.Empty;
        private String _tenDVT = String.Empty;
        private String _maDVTHL = String.Empty;
        private String _tenDVTHL = String.Empty;
        private Decimal _dongiaTT = 0;
        private Decimal _dongiaTT1 = 0;
        private Boolean _apDungGoi = true;
		private Decimal _gianhap = 0;
		private Decimal _gianhap1 = 0;
		private Decimal _gianhap2 = 0;
		private SmartDate _ngaynhap = new SmartDate(true);
		private SmartDate _ngaynhap1 = new SmartDate(true);
		private SmartDate _ngaynhap2 = new SmartDate(true);
		private String _makho = String.Empty;
		private Boolean _huy = false;
        private String _maMay = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _nguoiSD1 = String.Empty;
        private String _hoten = String.Empty;
        private String _tenkho = String.Empty;
        private Boolean _handung = true;
        private int _OrderNumber;
        private String _maChungLoai = String.Empty;
        private String _maLH = String.Empty;
        private String _maBYTe = String.Empty;
        private String _TenCPMauBH = String.Empty;
        private String _QuyetDinh = String.Empty;
        private String _QuyetDinhBH = String.Empty;
       private String _MaBH = String.Empty;
        private string _MaTDuong = String.Empty;
        private String _TenBYTe = String.Empty;
		#endregion
		
		#region Business Properties and Methods
        public String MaTDuong
        {
            get
            {
                CanReadProperty("MaTDuong", true);
                return _MaTDuong;
            }
            set
            {
                CanWriteProperty("MaTDuong", true);
                if (_MaTDuong != value)
                {
                    _MaTDuong = value;
                    PropertyHasChanged("MaTDuong");
                }
            }
        }
        public String MaBH
        {
            get
            {
                CanReadProperty("MaBH", true);
                return _MaBH;
            }
            set
            {
                CanWriteProperty("MaBH", true);
                if (_MaBH != value)
                {
                    _MaBH = value;
                    PropertyHasChanged("MaBH");
                }
            }
        }
        public String QuyetDinhBH
        {
            get
            {
                CanReadProperty("QuyetDinhBH", true);
                return _QuyetDinhBH;
            }
            set
            {
                CanWriteProperty("QuyetDinhBH", true);
                if (_QuyetDinhBH != value)
                {
                    _QuyetDinhBH = value;
                    PropertyHasChanged("QuyetDinhBH");
                }
            }
        }
        public String TenBYTe
        {
            get
            {
                CanReadProperty("TenBYTe", true);
                return _TenBYTe;
            }
            set
            {
                CanWriteProperty("TenBYTe", true);
                if (_TenBYTe != value)
                {
                    _TenBYTe = value;
                    PropertyHasChanged("TenBYTe");
                }
            }
        }
        public String TenCPMauDu
        {
            get
            {

                return _MaCPMau + "-" + _TenCPMau;
            }

        }
        public String MaBYTe
        {
            get
            {
                CanReadProperty("MaBYTe", true);
                return _maBYTe;
            }
            set
            {
                CanWriteProperty("MaBYTe", true);
                if (_maBYTe != value)
                {
                    _maBYTe = value;
                    PropertyHasChanged("MaBYTe");
                }
            }
        }

        public String QuyetDinh
        {
            get
            {
                CanReadProperty("QuyetDinh", true);
                return _QuyetDinh;
            }
            set
            {
                CanWriteProperty("QuyetDinh", true);
                if (_QuyetDinh != value)
                {
                    _QuyetDinh = value;
                    PropertyHasChanged("QuyetDinh");
                }
            }
        }
        public String TenCPMauBH
        {
            get
            {
                CanReadProperty("TenCPMauBH", true);
                return _TenCPMauBH;
            }
            set
            {
                CanWriteProperty("TenCPMauBH", true);
                if (_TenCPMauBH != value)
                {
                    _TenCPMauBH = value;
                    PropertyHasChanged("TenCPMauBH");
                }
            }
        }
        public String MaLH
        {
            get
            {
                CanReadProperty("MaLH", true);
                return _maLH;
            }
            set
            {
                CanWriteProperty("MaLH", true);
                if (_maLH != value)
                {
                    _maLH = value;
                    PropertyHasChanged("MaLH");
                }
            }
        }
        public String MaChungLoai
        {
            get
            {
                CanReadProperty("MaChungLoai", true);
                return _maChungLoai;
            }
            set
            {
                CanWriteProperty("MaChungLoai", true);
                if (_maChungLoai != value)
                {
                    _maChungLoai = value;
                    PropertyHasChanged("MaChungLoai");
                }
            }
        }
        public String TenTMHL
        {
            get
            {
                CanReadProperty("TenTMHL", true);
                return _TenCPMau + " " + _hamluong + " " + _tenDVTHL;
            }
            //set
            //{
            //    CanWriteProperty("TenTMHL", true);
            //    if (_tenTM != value)
            //    {
            //        _tenTM = value;
            //        PropertyHasChanged("TenTMHL");
            //    }
            //}
        }
        public Boolean Handung
        {
            get
            {
                CanReadProperty("Handung", true);
                return _handung;
            }
            set
            {
                CanWriteProperty("Handung", true);
                if (_handung != value)
                {
                    _handung = value;
                    PropertyHasChanged("Handung");
                }
            }
        }
		public String MaCPMau
		{
			get 
			{
				CanReadProperty("MaCPMau", true);
				return _MaCPMau;
			}
			set 
			{
				CanWriteProperty("MaCPMau", true);
				if (_MaCPMau != value) 
				{
					_MaCPMau = value;
					PropertyHasChanged("MaCPMau");
				}
			}
		}
		
		public String TenCPMau
		{
			get 
			{
				CanReadProperty("TenCPMau", true);
				return _TenCPMau;
			}
			set 
			{
				CanWriteProperty("TenCPMau", true);
				if (_TenCPMau != value) 
				{
					_TenCPMau = value;
					PropertyHasChanged("TenCPMau");
				}
			}
		}
		
		public String TenTA
		{
			get 
			{
				CanReadProperty("TenTA", true);
				return _tenTA;
			}
			set 
			{
				CanWriteProperty("TenTA", true);
				if (_tenTA != value) 
				{
					_tenTA = value;
					PropertyHasChanged("TenTA");
				}
			}
		}
		
		public String Ghichu
		{
			get 
			{
				CanReadProperty("Ghichu", true);
				return _ghichu;
			}
			set 
			{
				CanWriteProperty("Ghichu", true);
				if (_ghichu != value) 
				{
					_ghichu = value;
					PropertyHasChanged("Ghichu");
				}
			}
		}
		
		public String MaNhom
		{
			get 
			{
				CanReadProperty("MaNhom", true);
				return _maNhom;
			}
			set 
			{
				CanWriteProperty("MaNhom", true);
				if (_maNhom != value) 
				{
					_maNhom = value;
					PropertyHasChanged("MaNhom");
				}
			}
		}
		
		public String Hamluong
		{
			get 
			{
				CanReadProperty("Hamluong", true);
				return _hamluong;
			}
			set 
			{
				CanWriteProperty("Hamluong", true);
				if (_hamluong != value) 
				{
					_hamluong = value;
					PropertyHasChanged("Hamluong");
				}
			}
		}
		
		public Decimal Nguong
		{
			get 
			{
				CanReadProperty("Nguong", true);
				return _nguong;
			}
			set 
			{
				CanWriteProperty("Nguong", true);
				if (_nguong != value) 
				{
					_nguong = value;
					PropertyHasChanged("Nguong");
				}
			}
		}
		
		public String MaDVT
		{
			get 
			{
				CanReadProperty("MaDVT", true);
				return _maDVT;
			}
			set 
			{
				CanWriteProperty("MaDVT", true);
				if (_maDVT != value) 
				{
					_maDVT = value;
					PropertyHasChanged("MaDVT");
				}
			}
		}
        public String TenDVT
        {
            get
            {
                CanReadProperty("TenDVT", true);
                return _tenDVT;
            }
            set
            {
                CanWriteProperty("TenDVT", true);
                if (_tenDVT != value)
                {
                    _tenDVT = value;
                    PropertyHasChanged("TenDVT");
                }
            }
        }
        public String MaDVTHL
        {
            get
            {
                CanReadProperty("MaDVTHL", true);
                return _maDVTHL ;
            }
            set
            {
                CanWriteProperty("MaDVTHL", true);
                if (_maDVTHL  != value)
                {
                    _maDVTHL  = value;
                    PropertyHasChanged("MaDVTHL");
                }
            }
        }
        public String TenDVTHL
        {
            get
            {
                CanReadProperty("TenDVTHL", true);
                return _tenDVTHL ;
            }
            set
            {
                CanWriteProperty("TenDVTHL", true);
                if (_tenDVTHL  != value)
                {
                    _tenDVTHL  = value;
                    PropertyHasChanged("TenDVTHL");
                }
            }
        }


        public Decimal DongiaTT
        {
            get
            {
                CanReadProperty("DongiaTT", true);
                return _dongiaTT;
            }
            set
            {
                CanWriteProperty("DongiaTT", true);
                if (_dongiaTT != value)
                {
                    _dongiaTT = value;
                    PropertyHasChanged("DongiaTT");
                }
            }
        }

        public Decimal DongiaTT1
        {
            get
            {
                CanReadProperty("DongiaTT1", true);
                return _dongiaTT1;
            }
            set
            {
                CanWriteProperty("DongiaTT1", true);
                if (_dongiaTT1 != value)
                {
                    _dongiaTT1 = value;
                    PropertyHasChanged("DongiaTT1");
                }
            }
        }

        public Boolean ApDungGoi
        {
            get
            {
                CanReadProperty("ApDungGoi", true);
                return _apDungGoi;
            }
            set
            {
                CanWriteProperty("ApDungGoi", true);
                if (_apDungGoi != value)
                {
                    _apDungGoi = value;
                    PropertyHasChanged("ApDungGoi");
                }
            }
        }

		public Decimal Gianhap
		{
			get 
			{
				CanReadProperty("Gianhap", true);
				return _gianhap;
			}
			set 
			{
				CanWriteProperty("Gianhap", true);
				if (_gianhap != value) 
				{
					_gianhap = value;
					PropertyHasChanged("Gianhap");
				}
			}
		}
		
		public Decimal Gianhap1
		{
			get 
			{
				CanReadProperty("Gianhap1", true);
				return _gianhap1;
			}
			set 
			{
				CanWriteProperty("Gianhap1", true);
				if (_gianhap1 != value) 
				{
					_gianhap1 = value;
					PropertyHasChanged("Gianhap1");
				}
			}
		}
		
		public Decimal Gianhap2
		{
			get 
			{
				CanReadProperty("Gianhap2", true);
				return _gianhap2;
			}
			set 
			{
				CanWriteProperty("Gianhap2", true);
				if (_gianhap2 != value) 
				{
					_gianhap2 = value;
					PropertyHasChanged("Gianhap2");
				}
			}
		}
		
		public string Ngaynhap
		{
			get 
			{
				CanReadProperty("Ngaynhap", true);
                _ngaynhap.FormatString = "dd/MM/yyyy HH:mm:ss";
				return _ngaynhap.Text;
			}
			set 
			{
				CanWriteProperty("Ngaynhap", true);
				if (_ngaynhap.Text != value) 
				{
					_ngaynhap.Text = value;
					PropertyHasChanged("Ngaynhap");
				}
			}
		}
		
		public string Ngaynhap1
		{
			get 
			{
				CanReadProperty("Ngaynhap1", true);
                _ngaynhap1.FormatString = "dd/MM/yyyy HH:mm:ss";
				return _ngaynhap1.Text;
			}
			set 
			{
				CanWriteProperty("Ngaynhap1", true);
				if (_ngaynhap1.Text != value) 
				{
					_ngaynhap1.Text = value;
					PropertyHasChanged("Ngaynhap1");
				}
			}
		}
		
		public string Ngaynhap2
		{
			get 
			{
				CanReadProperty("Ngaynhap2", true);
                _ngaynhap2.FormatString = "dd/MM/yyyy HH:mm:ss";
				return _ngaynhap2.Text;
			}
			set 
			{
				CanWriteProperty("Ngaynhap2", true);
				if (_ngaynhap2.Text != value) 
				{
					_ngaynhap2.Text = value;
					PropertyHasChanged("Ngaynhap2");
				}
			}
		}
		
		public String Makho
		{
			get 
			{
				CanReadProperty("Makho", true);
				return _makho;
			}
			set 
			{
				CanWriteProperty("Makho", true);
				if (_makho != value) 
				{
					_makho = value;
					PropertyHasChanged("Makho");
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
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm:ss";
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
		
		public string NgaySD1
		{
			get 
			{
				CanReadProperty("NgaySD1", true);
                _ngaySD1.FormatString = "dd/MM/yyyy HH:mm:ss";
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

        public String HoTen
        {
            get
            {
                CanReadProperty("HoTen", true);
                return _hoten;
            }
            set
            {
                CanWriteProperty("HoTen", true);
                if (_hoten != value)
                {
                    _hoten = value;
                    PropertyHasChanged("HoTen");
                }
            }
        }

        public String TenKho
        {
            get
            {
                CanReadProperty("TenKho", true);
                return _tenkho;
            }
            set
            {
                CanWriteProperty("TenKho", true);
                if (_tenkho != value)
                {
                    _tenkho = value;
                    PropertyHasChanged("TenKho");
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
                //CanWriteProperty(true);
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                    //PropertyHasChanged();
                }
            }
        }

		protected override Object GetIdValue()
		{
			return _MaCPMau;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenCPMau", 150));
            ValidationRules.AddRule<DMChePhamMau>(StringRequired<DMChePhamMau>, "TenCPMau");


        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMChePhamMau
        {

            if (target._TenCPMau == null || target._TenCPMau.Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMChePhamMau" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMChePhamMau NewDMChePhamMau()
        {
            //return new DMNhomThuoc();
            return DataPortal.Create<DMChePhamMau>();
        }
		public static DMChePhamMau GetDMChePhamMau(String MaCPMau)
		{
			return DataPortal.Fetch<DMChePhamMau>(new Criteria(MaCPMau));
		}
		
		/// <summary>
		/// Marks the <see cref="DMChePhamMau" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMChePhamMau(String MaCPMau, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,MaCPMau));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMChePhamMau()
		{	
			// Prevent direct creation
		}
        internal DMChePhamMau(int ordernumber,  
                                 String MaCPMau ,
		                         String TenCPMau ,
                                 String tenTA ,
		                         String ghichu ,
		                         String maNhom ,
		                         String hamluong ,
		                         Decimal nguong,
		                         String maDVT ,
                                 String tenDVT,
                                  String maDVTHL,
                                 String tenDVTHL,
                                 Decimal dongiaTT ,
                                 Decimal dongiaTT1 ,
                                 Boolean apDungGoi ,
                                 Decimal gianhap,
		                         Decimal gianhap1 ,
		                         Decimal gianhap2 ,
		                         SmartDate ngaynhap ,
                                 SmartDate ngaynhap1 ,
		                         SmartDate ngaynhap2 ,
		                         String makho ,
		                         Boolean huy,
                                 String maMay,
		                         SmartDate ngaySD ,
		                         SmartDate ngaySD1 ,
		                         String nguoiSD ,
		                         String nguoiSD1 ,
                                 String hoten,
                                 String tenkho,
                                  Boolean handung,
                                 String machungloai,
                                 String malh, String maBYTe,
             String quyetdinh,
            String tencpmaubh,
            String maBh,String matduong,
             String quyetdinhbh,
            String tenbyte

            )
        {
             _MaBH = maBh; _MaTDuong = matduong;
            _TenBYTe = tenbyte;
            _QuyetDinhBH = quyetdinhbh;
            _maBYTe = maBYTe;
            _QuyetDinh = quyetdinh;
            _TenCPMauBH = tencpmaubh;
                        _OrderNumber = ordernumber ;
                         _MaCPMau = MaCPMau;
		                 _TenCPMau = TenCPMau ;
		                 _tenTA = tenTA ;
		                 _ghichu = ghichu  ;
		                 _maNhom = maNhom ;
		                 _hamluong = hamluong  ;
		                 _nguong = nguong  ;
		                 _maDVT = maDVT  ;
                         _tenDVT = tenDVT;
                         _maDVTHL = maDVTHL;
                         _tenDVTHL  = tenDVTHL;
                          _dongiaTT = dongiaTT ;
                        _dongiaTT1 = dongiaTT1 ;
                         _apDungGoi = apDungGoi ;
		                 _gianhap = gianhap  ;
		                 _gianhap1 = gianhap1  ;
		                 _gianhap2 = gianhap2  ;
		                 _ngaynhap = ngaynhap  ;
		                 _ngaynhap1 = ngaynhap1 ;
		                 _ngaynhap2 = ngaynhap2 ;
		                 _makho = makho  ;
		                 _huy = huy  ;
                         _maMay = maMay;
		                 _ngaySD = ngaySD  ;
		                 _ngaySD1 = ngaySD1  ;
		                 _nguoiSD = nguoiSD  ;
		                 _nguoiSD1 = nguoiSD1  ;
                         _hoten = hoten;
                         _tenkho = tenkho;
                        _handung =handung;
                        _maChungLoai = machungloai;
                        _maLH = malh;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _MaCPMau;
			public String MaCPMau 
			{
				get
				{
					return _MaCPMau;
				}
			}
			
			public Criteria(String MaCPMau)
			{
				_MaCPMau = MaCPMau;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_MaCPMau.Equals(c._MaCPMau)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _MaCPMau.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaCPMau;
            public String MaCPMau
            {
                get
                {
                    return _MaCPMau;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maCPMau)
            {
                _MaCPMau = maCPMau;
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
		/// Retrieve an existing <see cref="DMChePhamMau" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMChePhamMau(String _MaCPMauMau);
			// public override IDataReader GetDMChePhamMau(String _MaCPMauMau)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaCPMauMau));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMChePhamMau(crit.MaCPMau)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMChePhamMau" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
            if (dr.GetString("MaBH") != null) _MaBH = dr.GetString("MaBH");
            if (dr.GetString("MaTDuong") != null) _MaTDuong = dr.GetString("MaTDuong");
            if (dr.GetString("QuyetDinhBH") != null) _QuyetDinhBH = dr.GetString("QuyetDinhBH");
            if (dr.GetString("TenBYte") != null) _TenBYTe = dr.GetString("TenBYte");

            if (dr.GetString("MaBYTe") != null) _maBYTe = dr.GetString("MaBYTe");
            if (dr.GetString("QuyetDinh") != null) _QuyetDinh = dr.GetString("QuyetDinh");
            if (dr.GetString("TenCPMauBH") != null) _TenCPMauBH = dr.GetString("TenCPMauBH");
			if (dr.GetString("MaCPMau") != null) _MaCPMau = dr.GetString("MaCPMau");
			if (dr.GetString("TenCPMau") != null) _TenCPMau = dr.GetString("TenCPMau");
			if (dr.GetString("TenTA") != null) _tenTA = dr.GetString("TenTA");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetString("MaNhom") != null) _maNhom = dr.GetString("MaNhom");
			if (dr.GetString("Hamluong") != null) _hamluong = dr.GetString("Hamluong");
			if (dr.GetDecimal("Nguong") != null) _nguong = dr.GetDecimal("Nguong");
			if (dr.GetString("MaDVT") != null) _maDVT = dr.GetString("MaDVT");
            if (dr.GetString("TenDVT") != null) _tenDVT = dr.GetString("TenDVT");
            if (dr.GetString("MaDVTHL") != null) _maDVTHL  = dr.GetString("MaDVTHL");
            if (dr.GetString("TenDVTHL") != null) _tenDVTHL = dr.GetString("TenDVTHL");
            if (dr.GetDecimal("DongiaTT") != null) _dongiaTT  = dr.GetDecimal("DongiaTT");
            if (dr.GetDecimal("DongiaTT1") != null) _dongiaTT1 = dr.GetDecimal("DongiaTT1");
            if (dr.GetBoolean("ApdungGoi") != null) _apDungGoi = dr.GetBoolean("ApdungGoi");
			if (dr.GetDecimal("Gianhap") != null) _gianhap = dr.GetDecimal("Gianhap");
			if (dr.GetDecimal("Gianhap1") != null) _gianhap1 = dr.GetDecimal("Gianhap1");
			if (dr.GetDecimal("Gianhap2") != null) _gianhap2 = dr.GetDecimal("Gianhap2");
			if (dr.GetSmartDate("Ngaynhap", true) != null) _ngaynhap = dr.GetSmartDate("Ngaynhap", true);
			if (dr.GetSmartDate("Ngaynhap1", true) != null) _ngaynhap1 = dr.GetSmartDate("Ngaynhap1", true);
			if (dr.GetSmartDate("Ngaynhap2", true) != null) _ngaynhap2 = dr.GetSmartDate("Ngaynhap2", true);
			if (dr.GetString("Makho") != null) _makho = dr.GetString("Makho");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetBoolean("Handung") != null) _handung = dr.GetBoolean("Handung");
            if (dr.GetString("HoTen") != null) _hoten = dr.GetString("HoTen");
            if (dr.GetString("MaChungLoai") != null) _maChungLoai = dr.GetString("MaChungLoai");
            if (dr.GetString("MaLH") != null) _maLH = dr.GetString("MaLH");

		}
		
		/// <summary>
		/// Insert the new <see cref="DMChePhamMau" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMChePhamMau
			// Copy & paste ham duoi day vao file DataProvider.cs
            _MaCPMau = DataProvider.Instance().InsertDMChePhamMau(_TenCPMau, _tenTA, _ghichu, _maNhom, _hamluong, _nguong, _maDVT, _maDVTHL, _apDungGoi, _makho, _maMay, _nguoiSD, _maChungLoai, _maLH, _handung, _maBYTe, _QuyetDinh, _TenCPMauBH, _MaBH,_MaTDuong, _QuyetDinhBH, _TenBYTe);
            // public abstract String InsertDMChePhamMau(String _TenCPMau, String _tenTA, String _ghichu, String _maNhom, String _hamluong, Decimal _nguong, String _maDVT,_apDungGoi,_apDungGoi, String _makho,String _maMay,String _nguoiSD);
            // public override String InsertDMChePhamMau(String _TenCPMau, String _tenTA, String _ghichu, String _maNhom, String _hamluong, Decimal _nguong, String _maDVT,_apDungGoi,_apDungGoi, String _makho,String _maMay,String _nguoiSD);
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMCHEPHAMMAU_CREATE", _TenCPMau, _tenTA, _ghichu, _maNhom, _hamluong, _nguong, _maDVT, _makho,_maMay,  _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMChePhamMau" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMChePhamMau
			if (IsDirty){
                DataProvider.Instance().UpdateDMChePhamMau(_MaCPMau, _TenCPMau, _tenTA, _ghichu, _maNhom, _hamluong, _nguong, _maDVT, _maDVTHL, _apDungGoi, _makho, _huy, _maMay, _nguoiSD, _maChungLoai, _maLH, _handung, _maBYTe, _QuyetDinh, _TenCPMauBH, _MaBH,_MaTDuong, _QuyetDinhBH, _TenBYTe);
                // public abstract void UpdateDMChePhamMau(String _MaCPMau, String _TenCPMau, String _tenTA, String _ghichu, String _maNhom, String _hamluong, Decimal _nguong, String _maDVT,_apDungGoi,_apDungGoi, String _makho, Boolean _huy, String _maMay,String _nguoiSD);
                // public override void UpdateDMChePhamMau(String _MaCPMau, String _TenCPMau, String _tenTA, String _ghichu, String _maNhom, String _hamluong, Decimal _nguong, String _maDVT,_apDungGoi,_apDungGoi, String _makho, Boolean _huy, String _maMay,String _nguoiSD);
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMCHEPHAMMAU_UPDATE", _MaCPMau, _TenCPMau, _tenTA, _ghichu, _maNhom, _hamluong, _nguong, _maDVT, _makho, _huy, _maMay, _nguoiSD );
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _MaCPMau));
		}

		/// <summary>
		/// Delete the <see cref="DMChePhamMau" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMChePhamMau
            
            

            DataProvider.Instance().DeleteDMChePhamMau(_maMay, _nguoiSD, crit.MaCPMau);
			// public abstract void DeleteDMChePhamMau(String _MaCPMau);
			// public override void DeleteDMChePhamMau(String _MaCPMau);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMCHEPHAMMAU_DELETED", _MaCPMau);
			// }
		}

		#endregion
	}

}
