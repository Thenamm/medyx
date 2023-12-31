using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using HTC.Business.CanLamSang;
using HTC.Business;
//

namespace HTC.Business.CanLamSang
{
    [Serializable()]
    public partial class MauPhieuNhap : BusinessBase<MauPhieuNhap>
    {

        #region Business Methods
		
		#region State Fields
		
		private String _maPN = String.Empty;
		private String _maNCC = String.Empty;
        private String _soChungTu = String.Empty;
		private String _soHopDong = String.Empty;
        private String _soHoaDon = String.Empty;
        private SmartDate _ngayHoaDon = new SmartDate("", true);
		private SmartDate _ngayMauPhieuNhap =  new SmartDate("",true ) ;
        private SmartDate _ngayMauPhieuNhapD =  new SmartDate("",true ) ;
        private String _maKho = String.Empty;
		private decimal _chietKhau = 0;
        private Boolean _thanhToan = false;
        private SmartDate _ngayThanhToan = new SmartDate(false );
        private SmartDate _ngayNhap = new SmartDate(DateTime.Today);
        private SmartDate _ngayNhapD = new SmartDate(DateTime.Today);
		private String _NhanVienNhap = String.Empty;
        private decimal _tong;
		private String _ghiChu = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngayLap = new SmartDate(false );
        private String _nguoiLap = String.Empty;
        private SmartDate _ngayHuy = new SmartDate(false );
        private String _nguoiHuy = String.Empty;
        private SmartDate _ngaySuDung = new SmartDate(false );
        private String _nguoiSuDung = String.Empty;
        private String _maMay = String.Empty;
        private SmartDate _ngaySuaDoi1 = new SmartDate(false );
        private String _nguoiSuaDoi1 = String.Empty;
        private String _nguoiGiao = String.Empty;
        private String _tenNCC = String.Empty;
        private String _tenKho = String.Empty;
        private String _tenNVNhap = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private String _maNguon = String.Empty;
        private String _maHinhThuc = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
		public String MaPN
		{
			get 
			{
				CanReadProperty("MaPN", true);
				return _maPN;
			}
			set 
			{
				CanWriteProperty("MaPN", true);
				if (_maPN != value) 
				{
					_maPN = value;
					PropertyHasChanged("MaPN");
				}
			}
		}
        public String MaHinhThuc
        {
            get
            {
                CanReadProperty("MaHinhThuc", true);
                return _maHinhThuc;
            }
            set
            {
                CanWriteProperty("MaHinhThuc", true);
                if (_maHinhThuc != value)
                {
                    _maHinhThuc = value;
                    PropertyHasChanged("MaHinhThuc");
                }
            }
        }
        public String MaNguon
        {
            get
            {
                CanReadProperty("MaNguon", true);
                return _maNguon;
            }
            set
            {
                CanWriteProperty("MaNguon", true);
                if (_maNguon != value)
                {
                    _maNguon = value;
                    PropertyHasChanged("MaNguon");
                }
            }
        }
		public String  MaNCC
		{
			get 
			{
				CanReadProperty("MaNCC", true);
				return _maNCC;
			}
			set 
			{
				CanWriteProperty("MaNCC", true);
				if (_maNCC != value) 
				{
					_maNCC = value;
					PropertyHasChanged("MaNCC");
				}
			}
		}
        public String  SoCT
		{
			get 
			{
                CanReadProperty("SoCT", true);
				return _soChungTu;
			}
			set 
			{
                CanWriteProperty("SoCT", true);
				if (_soChungTu != value) 
				{
					_soChungTu = value;
                    PropertyHasChanged("SoCT");
				}
			}
		}

        public String  SoHD
		{
			get 
			{
                CanReadProperty("SoHD", true);
				return _soHopDong;
			}
			set 
			{
                CanWriteProperty("SoHD", true);
				if (_soHopDong != value) 
				{
					_soHopDong = value;
                    PropertyHasChanged("SoHD");
				}
			}
		}
        public String SoHDon
        {
            get
            {
                CanReadProperty("SoHDon", true);
                return _soHoaDon ;
            }
            set
            {
                CanWriteProperty("SoHDon", true);
                if (_soHoaDon != value)
                {
                    _soHoaDon = value;
                    PropertyHasChanged("SoHDon");
                }
            }
        }
        public String NgayPNhap
		{
			get 
			{
                CanReadProperty("NgayPNhap", true);
               // _ngayMauPhieuNhap.FormatString = "MM/dd/yyyy"; 
                return _ngayMauPhieuNhap.Text ;
			}
			set 
			{
                CanWriteProperty("NgayPNhap", true);
				//if (_ngayMauPhieuNhap != value)
                if (!_ngayMauPhieuNhap.Equals(value))

				{
                  //  _ngayMauPhieuNhap.FormatString = "MM/dd/yyyy"; 
				    _ngayMauPhieuNhap.Text  = value;
                    PropertyHasChanged("NgayPNhap");
				}
			}
		}
        public String ngayHoaDon
        {
            get
            {
                CanReadProperty("ngayHoaDon", true);
                // _ngayPhieuNhap.FormatString = "MM/dd/yyyy"; 
                return _ngayHoaDon.Text;
            }
            set
            {
                CanWriteProperty("ngayHoaDon", true);
                //if (_ngayPhieuNhap != value)
                if (!_ngayHoaDon.Equals(value))
                {
                    //  _ngayPhieuNhap.FormatString = "MM/dd/yyyy"; 
                    _ngayHoaDon.Text = value;
                    PropertyHasChanged("ngayHoaDon");
                }
            }
        }
        public String NgayPNhapD
        {
            get
            {
                CanReadProperty("NgayPNhapD", true);
                _ngayMauPhieuNhapD.FormatString = "dd/MM/yyyy";
                _ngayMauPhieuNhapD = _ngayMauPhieuNhap;
                return _ngayMauPhieuNhapD.Text;
            }
            //set
            //{
            //    CanWriteProperty("NgayPNhapD", true);

            //    if (!_ngayMauPhieuNhap.Equals(value))
            //    {
            //        _ngayMauPhieuNhap.FormatString = "MM/dd/yyyy";
            //        _ngayMauPhieuNhap.Text = value;
            //        PropertyHasChanged("NgayPNhapD");
            //    }
            //}
        }

        public String MaKho
		{
			get 
			{
				CanReadProperty("MaKho", true);
				return _maKho;
			}
			set 
			{
				CanWriteProperty("MaKho", true);
				if (_maKho != value) 
				{
					_maKho = value;
					PropertyHasChanged("MaKho");
				}
			}
		}

        //public decimal VAT
        //{
        //    get
        //    {
        //        CanReadProperty("VAT", true);
        //        return _chietKhau;
        //    }
        //    set
        //    {
        //        CanWriteProperty("VAT", true);
        //        if (_chietKhau != value)
        //        {
        //            _chietKhau = value;
        //            PropertyHasChanged("VAT");
        //        }
        //    }
        //}
        public string VAT
        {
            get
            {
                CanReadProperty("VAT", true);
                if (_chietKhau == 0)
                {
                    return "0";
                }
                else
                {
                    return _chietKhau.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("VAT", true);

                if (_chietKhau.ToString() != value)
                {
                    _chietKhau = decimal.Parse(value);
                    PropertyHasChanged("VAT");
                }
            }
        }
       
        public Boolean ThanhToan
		{
			get 
			{
				CanReadProperty("ThanhToan", true);
				return _thanhToan;
			}
			set 
			{
				CanWriteProperty("ThanhToan", true);
				if (_thanhToan != value) 
				{
					_thanhToan = value;
					PropertyHasChanged("ThanhToan");
				}
			}
		}
        public String NgayTToan
        {
            get
            {
                CanReadProperty("NgayTToan", true);
                // _ngayMauPhieuNhap.FormatString = "dd/MM/yyyy HH:mm"; 
                return _ngayThanhToan.Text;
            }
            set
            {
                CanWriteProperty("NgayTToan", true);
                if (_ngayThanhToan != value)
                {
                    _ngayThanhToan.Text = value;
                    PropertyHasChanged("NgayTToan");
                }
            }
        }
        //public SmartDate NgayTToan
        //{
        //    get 
        //    {
        //        CanReadProperty("NgayTToan", true);
        //        _ngayThanhToan.FormatString = "dd/MM/yyyy HH:mm"; 
        //        return _ngayThanhToan;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NgayTToan", true);
        //        if (_ngayThanhToan != value) 
        //        {
        //            _ngayThanhToan = value;
        //            PropertyHasChanged("NgayTToan");
        //        }
        //    }
        //}

        //public SmartDate NgayNhapTT
        //{
        //    get 
        //    {
        //        CanReadProperty("NgayNhapTT", true);
        //        //_ngayNhap.FormatString = "dd/MM/yyyy HH:mm"; 
        //        return _ngayNhap;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NgayNhapTT", true);
        //        if (_ngayNhap != value) 
        //        {
        //            _ngayNhap = value;
        //            PropertyHasChanged("NgayNhapTT");
        //        }
        //    }
        //}
        public String NgayNhapTT
        {
            get
            {
                CanReadProperty("NgayNhapTT", true);
                 //_ngayNhap.FormatString = "dd/MM/yyyy"; 
                return _ngayNhap.Text;
            }
            set
            {
                CanWriteProperty("NgayNhapTT", true);
                if (_ngayNhap != value)
                {
                    _ngayNhap.Text = value;
                    PropertyHasChanged("NgayNhapTT");
                }
            }
        }
        public String NgayNhapTTD
        {
            get
            {
                CanReadProperty("NgayNhapTTD", true);
                _ngayNhapD = _ngayNhap;
                this._ngayNhapD.FormatString = "dd/MM/yyyy";
                return _ngayNhapD.Text;
            }
           
        }

        public String NVNhap
		{
			get 
			{
                CanReadProperty("NVNhap", true);
				return _NhanVienNhap;
			}
			set 
			{
                CanWriteProperty("NVNhap", true);
				if (_NhanVienNhap != value) 
				{
					_NhanVienNhap = value;
                    PropertyHasChanged("NVNhap");
				}
			}
		}
        //public decimal Tong
        //{
        //    get 
        //    {
        //        CanReadProperty("Tong", true);
        //        return _tong;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("Tong", true);
        //        if (_tong != value) 
        //        {
        //            _tong = value;
        //            PropertyHasChanged("Tong");
        //        }
        //    }
        //}
        public string Tong
        {
            get
            {
                CanReadProperty("Tong", true);
                return _tong.ToString("###,###");
            }
            set
            {
                CanWriteProperty("Tong", true);

                if (_tong.ToString() != value)
                {
                    _tong = decimal.Parse(value);
                    PropertyHasChanged("Tong");
                }
            }
        }
		public String Ghichu
		{
			get 
			{
				CanReadProperty("Ghichu", true);
                return _ghiChu;
			}
			set 
			{
				CanWriteProperty("Ghichu", true);
                if (_ghiChu != value) 
				{
                    _ghiChu = value;
					PropertyHasChanged("Ghichu");
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

        public SmartDate NgayLap
		{
			get 
			{
				CanReadProperty("NgayLap", true);
                _ngayLap.FormatString = "dd/MM/yyyy HH:mm"; 
				return _ngayLap;
			}
			set 
			{
				CanWriteProperty("NgayLap", true);
				if (_ngayLap != value) 
				{
					_ngayLap = value;
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
        public SmartDate NgayHuy
		{
			get 
			{
				CanReadProperty("NgayHuy", true);
                _ngayHuy.FormatString = "dd/MM/yyyy HH:mm"; 
				return _ngayHuy;
			}
			set 
			{
				CanWriteProperty("NgayHuy", true);
				if (_ngayHuy != value) 
				{
					_ngayHuy = value;
					PropertyHasChanged("NgayHuy");
				}
			}
		}
        public String NguoiHuy
		{
			get 
			{
				CanReadProperty("NguoiHuy", true);
				return this._nguoiHuy;
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

         public SmartDate NgaySD
		{
			get 
			{
                CanReadProperty("NgaySD", true);
                _ngaySuDung.FormatString = "dd/MM/yyyy HH:mm"; 
				return _ngaySuDung;
			}
			set 
			{
                CanWriteProperty("NgaySD", true);
				if (_ngaySuDung != value) 
				{
					_ngaySuDung = value;
                    PropertyHasChanged("NgaySD");
				}
			}
		}
        public String NguoiSD
		{
			get 
			{
                CanReadProperty("NguoiSD", true);
				return _nguoiSuDung;
			}
			set 
			{
                CanWriteProperty("NguoiSD", true);
				if (_nguoiSuDung != value) 
				{
					_nguoiSuDung = value;
                    PropertyHasChanged("NguoiSD");
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
		
		 public SmartDate NgaySD1
		{
			get 
			{
                CanReadProperty("NgaySD1", true);
                _ngaySuaDoi1.FormatString = "dd/MM/yyyy HH:mm"; 
				return this._ngaySuaDoi1;
			}
			set 
			{
                CanWriteProperty("NgaySD1", true);
				if (_ngaySuaDoi1 != value) 
				{
					_ngaySuaDoi1 = value;
                    PropertyHasChanged("NgaySD1");
				}
			}
		}
        public String NguoiSD1
		{
			get 
			{
                CanReadProperty("NguoiSD1", true);
				return _nguoiSuaDoi1;
			}
			set 
			{
                CanWriteProperty("NguoiSD1", true);
				if (_nguoiSuaDoi1 != value) 
				{
					_nguoiSuaDoi1 = value;
                    PropertyHasChanged("NguoiSD1");
				}
			}
		}
		
		public String NguoiGiao
		{
			get 
			{
				CanReadProperty("NguoiGiao", true);
				return _nguoiGiao;
			}
			set 
			{
				CanWriteProperty("NguoiGiao", true);
				if (_nguoiGiao != value) 
				{
					_nguoiGiao = value;
					PropertyHasChanged("NguoiGiao");
				}
			}
		}
		
        public String TenNCC
		{
			get 
			{
                CanReadProperty("TenNCC", true);
				return _tenNCC;
			}
			set 
			{
                CanWriteProperty("TenNCC", true);
				if (_tenNCC != value) 
				{
					_tenNCC = value;
                    PropertyHasChanged("TenNCC");
				}
			}
		}
        public String TenKho
		{
			get 
			{
				CanReadProperty("TenKho", true);
				return _tenKho;
			}
			set 
			{
				CanWriteProperty("TenKho", true);
				if (_tenKho != value) 
				{
					_tenKho = value;
					PropertyHasChanged("TenKho");
				}
			}
		}

        public String TenNVNhap
		{
			get 
			{
				CanReadProperty("TenNVNhap", true);
				return _tenNVNhap;
			}
			set 
			{
				CanWriteProperty("TenNVNhap", true);
				if (_tenNVNhap != value) 
				{
					_tenNVNhap = value;
					PropertyHasChanged("TenNVNhap");
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

        MauPhieuNhap_Cs _MauPhieuNhap_Cs = MauPhieuNhap_Cs.NewMauPhieuNhap_Cs();

        public MauPhieuNhap_Cs MauPhieuNhapCs
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _MauPhieuNhap_Cs;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_MauPhieuNhap_Cs.Equals(value))
                {
                    _MauPhieuNhap_Cs = value;
                    PropertyHasChanged();
                }
            }
        }
        protected override Object GetIdValue()
        {
            return _maPN;
        }
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _MauPhieuNhap_Cs.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid && _MauPhieuNhap_Cs.IsValid;
            }
        }
		#endregion
		#endregion
				
		#region Business Object Rules and Validation //muon kiem tra null cua truong nao thi cho truong do

        protected override void AddBusinessRules()
        {
            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "MaNCC");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenNCC", 150));
            ValidationRules.AddRule<MauPhieuNhap>(StringRequired<MauPhieuNhap>, "TenNCC");
            ValidationRules.AddRule<MauPhieuNhap>(ValidationDateTT<MauPhieuNhap>, "NgayTToan");
        }
        private static bool ValidationDateTT<T>(T target, Csla.Validation.RuleArgs e) where T : MauPhieuNhap
        {
            if (target._ngayThanhToan < target._ngayMauPhieuNhap)
            {
                e.Description = "Ngày thanh toán phải lớn hơn ngày phiếu nhập";
                return false;
            }
            else
                return true;
        }
        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : MauPhieuNhap
        {

            if (target._tenNCC == null || target._tenNCC.Trim().Length == 0)
            {
                //e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                e.Description = "Bạn phải nhập tên nhà cung cấp";
                return false;
            }
            else
                return true;
        }
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMDichVu_BC" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static MauPhieuNhap NewMauPhieuNhap()
        {
            return DataPortal.Create<MauPhieuNhap>();
        }
		public static MauPhieuNhap GetMauPhieuNhap(String maPN,Boolean qadmin)
		{
            return DataPortal.Fetch<MauPhieuNhap>(new Criteria(maPN, qadmin));
		}
        public static MauPhieuNhap GetMauPhieuNhap(SafeDataReader dr)
        {
            MauPhieuNhap obj = new MauPhieuNhap();
            obj.Fetch(dr);
            return obj;
        }
		/// <summary>
		/// Marks the <see cref="DMDichVu_BC" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>//(String _maPN, SmartDate _ngaySD, String _maMay, String _nguoiSD);
        public static void DeleteMauPhieuNhap_C(String maPN, string mamay, string nguoisd)
        {
            DataPortal.Delete(new OtherCriteria(maPN, mamay, nguoisd));
        }
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal MauPhieuNhap()
		{	
			// Prevent direct creation
		}
        internal MauPhieuNhap(        int OrderNumber,  
  String maPN,
		                             String maNCC,
  String soChungTu,
		                             String soHopDong ,
  SmartDate ngayMauPhieuNhap,
  String maKho,
  Boolean thanhToan,
  SmartDate ngayThanhToan,
  SmartDate ngayNhap,
		                             String NhanVienNhap,
  decimal chietKhau,
  decimal tong,
  String ghiChu,
  Boolean huy,
  SmartDate ngaySuDung,
  String nguoiSuDung,
  SmartDate ngaySuaDoi1,
  String nguoiSuaDoi1,
  String nguoiGiao,  
  SmartDate ngayLap,
  String nguoiLap,   
  SmartDate ngayHuy,
  String nguoiHuy,  
  String maMay,
  String tenNCC,
  String tenKho,
  String tenNVNhap,   
  String tenNguoiLap,
  String tenNguoiSD,
  String tenNguoiHuy,
  SmartDate ngayMauPhieuNhapD
                 )
        {

 _OrderNumber = OrderNumber;  
   _maPN = maPN;
		                              _maNCC = maNCC;
  _soChungTu=soChungTu;
		                             _soHopDong =soHopDong;
  _ngayMauPhieuNhap = ngayMauPhieuNhap;
  _maKho = maKho;
  _chietKhau = chietKhau;
  _thanhToan = thanhToan;
  _ngayThanhToan = ngayThanhToan;
  _ngayNhap = ngayNhap;
		                             _NhanVienNhap = NhanVienNhap;
  _tong = tong;
  _ghiChu = ghiChu;
  _huy = huy;
  _ngayLap = ngayLap;
  _nguoiLap = nguoiLap;   
  _ngayHuy = ngayHuy;
  _nguoiHuy = nguoiHuy;
  _ngaySuDung = ngaySuDung;
  _nguoiSuDung = nguoiSuDung;
  _maMay = maMay;  
  _ngaySuaDoi1 = ngaySuaDoi1;   
  _nguoiSuaDoi1 = nguoiSuaDoi1;
  _nguoiGiao = nguoiGiao;   
  _tenNCC = tenNCC;
  _tenKho = tenKho;
  _tenNVNhap = tenNVNhap;   
  _tenNguoiLap = tenNguoiLap;
  _tenNguoiSD = tenNguoiSD;
  _tenNguoiHuy = tenNguoiHuy;
  _ngayMauPhieuNhapD = ngayMauPhieuNhapD;
                           
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maPN;
			public String MaPN 
			{
				get
				{
					return _maPN;
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
			public  Criteria(String maPN,Boolean qadmin)
			{
				_maPN = maPN;
                _qadmin = qadmin;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maPN.Equals(c._maPN)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maPN.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maPN;
            public String MaPN
            {
                get
                {
                    return _maPN;
                }
            }
            private SmartDate _ngaySD;
            public SmartDate NgaySD
            {
                get
                {
                    return _ngaySD;
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
            //DeleteMauPhieuNhap(String _maPN, SmartDate _ngaySD, String _maMay, String _nguoiSD);
            public OtherCriteria(String maPN, String Mamay, String Nguoisd)
            {
                _maPN = maPN;
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
		/// Retrieve an existing <see cref="DMDichVu_BC" /> Object based on data in the database.
		/// </summary>
        /// 
        protected void Fetch(SafeDataReader dr)
        {
            
            _maPN = dr.GetString("MaPN");
            _maNCC = dr.GetString("MaNCC");
            _soHopDong = dr.GetString("SoHD");
            _soHoaDon = dr.GetString("SoHDon");
            _soChungTu = dr.GetString("SoCT");
            _ngayHoaDon = dr.GetSmartDate("NgayhDon");
            _ngayMauPhieuNhap = dr.GetSmartDate("NgayPNhap");
            _maKho = dr.GetString("MaKho");
            _chietKhau = dr.GetDecimal("VAT");////
            _thanhToan = dr.GetBoolean("Thanhtoan");
            _ngayThanhToan = dr.GetSmartDate("NgayTToan");
            _ngayNhap = dr.GetSmartDate("NgayNhapTT");
            _ngayNhapD = dr.GetSmartDate("NgayNhapTT");
            _NhanVienNhap = dr.GetString("NVNhap");
            _tong = dr.GetDecimal("Tong");
            _ghiChu = dr.GetString("Ghichu");
            _huy = dr.GetBoolean("Huy");
            _ngaySuDung = dr.GetSmartDate("NgaySD");
            _nguoiSuDung = dr.GetString("NguoiSD");
            _ngaySuaDoi1 = dr.GetSmartDate("NgaySD1");
            _nguoiSuaDoi1 = dr.GetString("NguoiSD1");
            _nguoiGiao = dr.GetString("Nguoigiao");
            
            _ngayLap = dr.GetSmartDate("NgayLap");
            _nguoiLap = dr.GetString("NguoiLap");
            _ngayHuy = dr.GetSmartDate("NgayHuy");
            _nguoiHuy = dr.GetString("NguoiHuy");
            _maMay = dr.GetString("MaMay");
            _maNguon = dr.GetString("MaNguon");
            _maHinhThuc = dr.GetString("MaHinhThuc");
            _tenNCC = dr.GetString("TenNCC");
            _tenKho = dr.GetString("TenKho");
            _tenNVNhap = dr.GetString("TENNVNHAP");
            _tenNguoiLap = dr.GetString("TENNGUOILAP");
            _tenNguoiSD = dr.GetString("TENNGUOISD");
            _tenNguoiHuy = dr.GetString("TENNGUOIHUY");
           // _OrderNumber = dr.GetInt32("STT");
        }
        protected void DataPortal_Fetch(Criteria crit)
        {

            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllMauPhieuNhap_Get(crit.MaPN, crit.qadmin)))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    if (dr.NextResult())
                    {
                       _MauPhieuNhap_Cs = MauPhieuNhap_Cs.GetMauPhieuNhap_Cs(dr);//////////////
                    }
                    //ValidationRules.CheckRules();
                }
            }
        }
		
		
		/// <summary>
		/// Insert the new <see cref="DMDichVu_BC" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            _ngayLap.Date  = DateTime.Now;
            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDichVu_BC
            // Copy & paste ham duoi day vao file DataProvider.cs
            
            
            //public abstract String InsertMauPhieuNhap(string _m SmartDate _ngayPNhap, String _maKho, decimal _chietKhau, Boolean _thanhToan, SmartDate _ngayTToan, SmartDate _ngayNhapTT, String _NVNhap, decimal _Tong, String _ghiChu, Boolean _huy, String _nguoiSD, String _maMay, String _nguoiGiao);
            _maPN = DataProvider.Instance().InsertMauPhieuNhap(_maNCC, _soHopDong, _soChungTu, _ngayMauPhieuNhap, _maKho, _chietKhau, _thanhToan, _ngayThanhToan, _ngayNhap, _NhanVienNhap, _tong, _ghiChu, _huy, _nguoiSuDung,_maMay, _nguoiGiao,_maNguon,_maHinhThuc,_soHoaDon,_ngayHoaDon    );

           _MauPhieuNhap_Cs.Update(this);

        }
        

        /// <summary>
		/// Update all changes made on <see cref="DMDichVu_BC" /> Object to underlying database.
		/// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_BC
            if (IsDirty)
            {
               
                
                //////_nguoiSuDung = HTC.ShareVariables.pub_sNguoiSD;
                
                DataProvider.Instance().UpdateMauPhieuNhap(_maPN, _maNCC, _soHopDong, _soChungTu, _ngayMauPhieuNhap, _maKho, _chietKhau, _thanhToan, _ngayThanhToan, _ngayNhap, _NhanVienNhap, _tong, _ghiChu, _huy, _nguoiSuDung, _ngaySuaDoi1, _nguoiSuaDoi1, _nguoiGiao,_maNguon,_maHinhThuc,_soHoaDon,_ngayHoaDon    );
                _MauPhieuNhap_Cs.Update(this);

            }
        }
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maPN, _maMay, _nguoiSuDung));
		}


        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_BC
            
            ////_nguoiSuDung = HTC.ShareVariables.pub_sNguoiSD;

            DataProvider.Instance().DeleteMauPhieuNhap(crit.MaPN, crit.NgaySD, _maMay, _nguoiSuDung);

        }

		#endregion
	}

    
}
