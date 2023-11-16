// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	TBPhieuNhap
// Kieu doi tuong  :	TBPhieuNhap
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	8/10/2009 10:20:07 AM
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
////

namespace HTC.Business.TBYT
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="TBPhieuNhap" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class TBPhieuNhap : BusinessBase<TBPhieuNhap>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maPN = String.Empty;
		private String _maNCC = String.Empty;
		private String _soHD = String.Empty;
		private String _soCT = String.Empty;
		private String _soHDon = String.Empty;
		private String _makho = String.Empty;
		private Boolean _thanhtoan = false;
		private SmartDate _ngayTToan = new SmartDate(true);
		private SmartDate _ngayNhapTT = new SmartDate(DateTime.Today);
        private SmartDate _ngayNhapTTD = new SmartDate(DateTime.Today);
		private String _nVNhap = String.Empty;
		private Decimal _vAT = 0;
		private Decimal _tong = 0;
		private String _ghichu = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
		private String _nguoigiao = String.Empty;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngayhuy = new SmartDate(true);
		private String _nguoihuy = String.Empty;
		private String _maMay = String.Empty;
		private String _maHinhThuc = String.Empty;
		private String _maNguon = String.Empty;
		private SmartDate _ngayHDon = new SmartDate(true);
		private SmartDate _ngayPnhap = new SmartDate(true);
        private String _tenNCC = String.Empty;
        private String _tenKho = String.Empty;
        private String _tenNVNhap = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        public Decimal _tongTien = 0;

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
		
		public String MaNCC
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
		
		public String SoCT
		{
			get 
			{
				CanReadProperty("SoCT", true);
				return _soCT;
			}
			set 
			{
				CanWriteProperty("SoCT", true);
				if (_soCT != value) 
				{
					_soCT = value;
					PropertyHasChanged("SoCT");
				}
			}
		}
		
		public String SoHDon
		{
			get 
			{
				CanReadProperty("SoHDon", true);
				return _soHDon;
			}
			set 
			{
				CanWriteProperty("SoHDon", true);
				if (_soHDon != value) 
				{
					_soHDon = value;
					PropertyHasChanged("SoHDon");
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
		
		public Boolean Thanhtoan
		{
			get 
			{
				CanReadProperty("Thanhtoan", true);
				return _thanhtoan;
			}
			set 
			{
				CanWriteProperty("Thanhtoan", true);
				if (_thanhtoan != value) 
				{
					_thanhtoan = value;
					PropertyHasChanged("Thanhtoan");
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
		
		public string NgayNhapTT
		{
			get 
			{
				CanReadProperty("NgayNhapTT", true);
				return _ngayNhapTT.Text;
			}
			set 
			{
				CanWriteProperty("NgayNhapTT", true);
				if (_ngayNhapTT.Text != value) 
				{
					_ngayNhapTT.Text = value;
					PropertyHasChanged("NgayNhapTT");
				}
			}
		}
        public string NgayNhapTTD
        {
            //get
            //{
            //    CanReadProperty("NgayNhapTTD", true);
            //    _ngayNhapTTD = _ngayNhapTT;
            //    _ngayNhapTTD.FormatString = "dd/MM/yyyy";
            //    return _ngayNhapTTD.Text;
            //}
            get
            {
                CanReadProperty("NgayNhapTTD", true);
                _ngayNhapTTD = _ngayNhapTT;
                this._ngayNhapTTD.FormatString = "dd/MM/yyyy";
                return _ngayNhapTTD.Text;
            }
         

        }
		
		public String NVNhap
		{
			get 
			{
				CanReadProperty("NVNhap", true);
				return _nVNhap;
			}
			set 
			{
				CanWriteProperty("NVNhap", true);
				if (_nVNhap != value) 
				{
					_nVNhap = value;
					PropertyHasChanged("NVNhap");
				}
			}
		}
		
		public Decimal VAT
		{
			get 
			{
				CanReadProperty("VAT", true);
				return _vAT;
			}
			set 
			{
				CanWriteProperty("VAT", true);
				if (_vAT != value) 
				{
					_vAT = value;
					PropertyHasChanged("VAT");
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
                _ngaySD.FormatString = "dd/MM/yyyy";
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
		
		public String Nguoigiao
		{
			get 
			{
				CanReadProperty("Nguoigiao", true);
				return _nguoigiao;
			}
			set 
			{
				CanWriteProperty("Nguoigiao", true);
				if (_nguoigiao != value) 
				{
					_nguoigiao = value;
					PropertyHasChanged("Nguoigiao");
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
		
		public string Ngayhuy
		{
			get 
			{
				CanReadProperty("Ngayhuy", true);
				return _ngayhuy.Text;
			}
			set 
			{
				CanWriteProperty("Ngayhuy", true);
				if (_ngayhuy.Text != value) 
				{
					_ngayhuy.Text = value;
					PropertyHasChanged("Ngayhuy");
				}
			}
		}
		
		public String Nguoihuy
		{
			get 
			{
				CanReadProperty("Nguoihuy", true);
				return _nguoihuy;
			}
			set 
			{
				CanWriteProperty("Nguoihuy", true);
				if (_nguoihuy != value) 
				{
					_nguoihuy = value;
					PropertyHasChanged("Nguoihuy");
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
		
		public string NgayHDon
		{
			get 
			{
				CanReadProperty("NgayHDon", true);
				return _ngayHDon.Text;
			}
			set 
			{
				CanWriteProperty("NgayHDon", true);
				if (_ngayHDon.Text != value) 
				{
					_ngayHDon.Text = value;
					PropertyHasChanged("NgayHDon");
				}
			}
		}
		
		public string NgayPnhap
		{
			get 
			{
				CanReadProperty("NgayPnhap", true);
				return _ngayPnhap.Text;
			}
			set 
			{
				CanWriteProperty("NgayPnhap", true);
				if (_ngayPnhap.Text != value) 
				{
					_ngayPnhap.Text = value;
					PropertyHasChanged("NgayPnhap");
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
        TBPhieuNhap_C_List _TBPhieuNhap_Cs = TBPhieuNhap_C_List.NewTBPhieuNhap_C_List();

        public TBPhieuNhap_C_List TBPhieuNhap_Cs
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _TBPhieuNhap_Cs;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_TBPhieuNhap_Cs.Equals(value))
                {
                    _TBPhieuNhap_Cs = value;
                    PropertyHasChanged();
                }
            }
        }

        //public Decimal  TongTien
        //{
        //    get
        //    {
        //        Decimal total = 0;
        //        foreach (TBPhieuNhap_C obj in _TBPhieuNhap_Cs)
        //            total += Convert.ToDecimal(obj.ThanhTien )  ;
        //        _tongTien = total;
        //        return _tongTien;
        //    }
        //    set
        //    {
        //        CanWriteProperty("TongTien", true);
        //        if (_tongTien != value)
        //        {
        //            _tongTien = value;
        //            PropertyHasChanged("TongTien");
        //        }
        //    }
        //}

        //public Decimal TongCong
        //{
        //    get
        //    {
        //        bool kt = false;
        //        //Decimal total = 0;
        //        foreach (TBPhieuNhap_C obj in _TBPhieuNhap_Cs)
        //        //total += Convert.ToDecimal(obj.ThanhTien);
        //        {
        //            if (obj.Vat != 0)
        //            {
        //                kt = true;

        //                break;
        //            }
        //            else
        //            {
        //                kt = false;
        //            }
        //        }
        //        if (kt = true)
        //        {
        //            return _tongTien;
        //        }
        //        else
        //            return _tongTien + _tongTien * _vAT;
        //    }
        //}

        public Decimal TongTien
        {
            get
            {
                //Decimal total = 0;
                //foreach (TBPhieuNhap_C obj in _TBPhieuNhap_Cs)
                //    total += Convert.ToDecimal(obj.ThanhTien);
                //_tongTien = total;
                return _tongTien;
            }
            set
            {
                CanWriteProperty("TongTien", true);
                if (_tongTien != value)
                {
                    _tongTien = value;
                    PropertyHasChanged("TongTien");
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
                return base.IsDirty || _TBPhieuNhap_Cs.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid && _TBPhieuNhap_Cs.IsValid;
            }
        }
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {
            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "MaNCC");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenNCC", 150));
            ValidationRules.AddRule<TBPhieuNhap>(StringRequired<TBPhieuNhap>, "TenNCC");
           // ValidationRules.AddRule<TBPhieuNhap>(ValidationDateTT<TBPhieuNhap>, "NgayTToan");
        }
        //private static bool ValidationDateTT<T>(T target, Csla.Validation.RuleArgs e) where T : TBPhieuNhap
        //{
        //    if (target._ngayTToan < target._ngayPnhap)
        //    {
        //        e.Description = "Ngày thanh toán phải lớn hơn ngày phiếu nhập";
        //        return false;
        //    }
        //    else
        //        return true;
        //}
        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : TBPhieuNhap
        {

            if (target._tenNCC == null || target._tenNCC.Trim().Length == 0)
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
		/// Factory method. New <see cref="TBPhieuNhap" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static TBPhieuNhap NewTBPhieuNhap()
        {
            return DataPortal.Create<TBPhieuNhap>();
        }
		public static TBPhieuNhap GetTBPhieuNhap(String maPN,Boolean qadmin)
		{
            return DataPortal.Fetch<TBPhieuNhap>(new Criteria(maPN, qadmin));
		}
        public static TBPhieuNhap GetTBPhieuNhap(SafeDataReader dr)
        {
            TBPhieuNhap obj = new TBPhieuNhap();
            obj.Fetch(dr);
            return obj;
        }
		/// <summary>
		/// Marks the <see cref="TBPhieuNhap" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteTBPhieuNhap(String maPN, string mamay, string nguoihuy)
		{
            
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maPN));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal TBPhieuNhap()
		{	
			// Prevent direct creation
		}
        internal TBPhieuNhap( 
  int OrderNumber,
  String maPN ,
		                             String maNCC ,
		                             String soHD ,
		                             String soCT ,
		                             String soHDon ,
		                             String makho ,
		                             Boolean thanhtoan ,
		                             SmartDate ngayTToan ,
		                             SmartDate ngayNhapTT ,
		                             String nVNhap ,
		                             Decimal vAT ,
		                             Decimal tong ,
		                             String ghichu ,
		                             Boolean huy ,
		                             SmartDate ngaySD ,
		                             String nguoiSD ,
		                             SmartDate ngaySD1 ,
		                             String nguoiSD1 ,
		                             String nguoigiao ,
		                             SmartDate ngayLap ,
		                             String nguoiLap ,
		                             SmartDate ngayhuy ,
		                             String nguoihuy ,
		                             String maMay ,
		                             String maHinhThuc ,
		                             String maNguon ,
		                             SmartDate ngayHDon ,
		                             SmartDate ngayPnhap ,
  String tenNCC ,
  String tenKho ,
  String tenNVNhap ,
  String tenNguoiLap ,
  String tenNguoiSD ,
  String tenNguoiHuy,
            Decimal tongTien
        )
        {
                          _OrderNumber = OrderNumber ;
                          _maPN = maPN ;
		                  _maNCC = maNCC ;
		                  _soHD = soHD ;
		                  _soCT = soCT ;
		                  _soHDon = soHDon ;
		                  _makho = makho ;
		                  _thanhtoan = thanhtoan ;
		                  _ngayTToan = ngayTToan ;
		                  _ngayNhapTT = ngayNhapTT ;
		                  _nVNhap = nVNhap ;
		                  _vAT = vAT;
		                  _tong = tong ;
		                  _ghichu = ghichu ;
		                  _huy = huy ;
		                  _ngaySD = ngaySD ;
		                  _nguoiSD = nguoiSD ;
		                  _ngaySD1 = ngaySD1 ;
		                  _nguoiSD1 = nguoiSD1 ;
		                  _nguoigiao = nguoigiao ;
		                  _ngayLap = ngayLap ;
		                  _nguoiLap = nguoiLap ;
		                  _ngayhuy = ngayhuy ;
		                  _nguoihuy = nguoihuy ;
		                  _maMay = maMay ;
		                  _maHinhThuc = maHinhThuc ;
		                  _maNguon = maNguon ;
		                  _ngayHDon = ngayHDon ;
		                  _ngayPnhap = ngayPnhap ;
                          _tenNCC = tenNCC ;
                          _tenKho = tenKho ;
                          _tenNVNhap = tenNVNhap ;
                          _tenNguoiLap = tenNguoiLap ;
                          _tenNguoiSD = tenNguoiSD ;
                          _tenNguoiHuy = tenNguoiHuy ;
                          _tongTien = tongTien;
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
            private bool  _qadmin = false;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
			
			public Criteria(String maPN,Boolean qadmin)
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
            //DeletePhieuNhap(String _maPN, SmartDate _ngaySD, String _maMay, String _nguoiSD);
            public OtherCriteria(String Mamay, String Nguoisd, String maPN )
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
		/// Retrieve an existing <see cref="TBPhieuNhap" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetTBPhieuNhap(String _maPN);
			// public override IDataReader GetTBPhieuNhap(String _maPN)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBPHIEUNHAP_GET", _maPN));
			// }
            _tongTien = 0;
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetTBPhieuNhap(crit.MaPN, crit.qadmin  )))
			{
				if (dr.Read()){
					Fetch(dr);
                    if (dr.NextResult())
                    {
                        _TBPhieuNhap_Cs = TBPhieuNhap_C_List.GetTBPhieuNhap_C_List(dr);//////////////
                        _tongTien = _tongTien + _TBPhieuNhap_Cs._TongTien;
                    }
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="TBPhieuNhap" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaPN") != null) _maPN = dr.GetString("MaPN");
			if (dr.GetString("MaNCC") != null) _maNCC = dr.GetString("MaNCC");
			if (dr.GetString("SoHD") != null) _soHD = dr.GetString("SoHD");
			if (dr.GetString("SoCT") != null) _soCT = dr.GetString("SoCT");
			if (dr.GetString("SoHDon") != null) _soHDon = dr.GetString("SoHDon");
			if (dr.GetString("Makho") != null) _makho = dr.GetString("Makho");
			if (dr.GetBoolean("Thanhtoan") != null) _thanhtoan = dr.GetBoolean("Thanhtoan");
			if (dr.GetSmartDate("NgayTToan", true) != null) _ngayTToan = dr.GetSmartDate("NgayTToan", true);
			if (dr.GetSmartDate("NgayNhapTT", true) != null) _ngayNhapTT = dr.GetSmartDate("NgayNhapTT", true);
            if (dr.GetSmartDate("NgayNhapTT", true) != null) _ngayNhapTTD = dr.GetSmartDate("NgayNhapTT", true);
			if (dr.GetString("NVNhap") != null) _nVNhap = dr.GetString("NVNhap");
			if (dr.GetDecimal("VAT") != null) _vAT = dr.GetDecimal("VAT");
			if (dr.GetDecimal("Tong") != null) _tong = dr.GetDecimal("Tong");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
			if (dr.GetString("Nguoigiao") != null) _nguoigiao = dr.GetString("Nguoigiao");
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("Ngayhuy", true) != null) _ngayhuy = dr.GetSmartDate("Ngayhuy", true);
			if (dr.GetString("Nguoihuy") != null) _nguoihuy = dr.GetString("Nguoihuy");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetString("MaHinhThuc") != null) _maHinhThuc = dr.GetString("MaHinhThuc");
			if (dr.GetString("MaNguon") != null) _maNguon = dr.GetString("MaNguon");
			if (dr.GetSmartDate("NgayHDon", true) != null) _ngayHDon = dr.GetSmartDate("NgayHDon", true);
			if (dr.GetSmartDate("NgayPnhap", true) != null) _ngayPnhap = dr.GetSmartDate("NgayPnhap", true);
            _tenNCC = dr.GetString("TenNCC");
            _tenKho = dr.GetString("TenKho");
            _tenNVNhap = dr.GetString("TENNVNHAP");
            _tenNguoiLap = dr.GetString("TENNGUOILAP");
            _tenNguoiSD = dr.GetString("TENNGUOISD");
            _tenNguoiHuy = dr.GetString("TENNGUOIHUY");
            try
            {
                //if (dr.GetDecimal("TongTien") != null) _tongTien = dr.GetDecimal("TongTien");

                string v = dr.GetString("Tongtien");
                //decimal.TryParse(
            }
            catch (Exception)
            {
                _tongTien = -1;
                }
            
         //   _tongTien = _tongTien + _TBPhieuNhap_Cs._TongTien;
            //_tongTien = 0;

		}
		
		/// <summary>
		/// Insert the new <see cref="TBPhieuNhap" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            _ngayLap.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertTBPhieuNhap
			// Copy & paste ham duoi day vao file DataProvider.cs
            
            
			_maPN = DataProvider.Instance().InsertTBPhieuNhap(_maNCC, _soHD, _soCT, _soHDon, _makho, _thanhtoan, _ngayTToan, _ngayNhapTT, _nVNhap, _vAT, _tong, _ghichu, _nguoiSD , _nguoigiao, _maMay, _maHinhThuc, _maNguon, _ngayHDon, _ngayPnhap);
            MarkOld();	// public abstract String InsertTBPhieuNhap(String _maNCC, String _soHD, String _soCT, String _soHDon, String _makho, Boolean _thanhtoan, SmartDate _ngayTToan, SmartDate _ngayNhapTT, String _nVNhap, Decimal _vAT, Decimal _tong, String _ghichu, String _nguoiLap, String _nguoigiao, String _maMay, String _maHinhThuc, String _maNguon, SmartDate _ngayHDon, SmartDate _ngayPnhap);
            // public override String InsertTBPhieuNhap(String _maNCC, String _soHD, String _soCT, String _soHDon, String _makho, Boolean _thanhtoan, SmartDate _ngayTToan, SmartDate _ngayNhapTT, String _nVNhap, Decimal _vAT, Decimal _tong, String _ghichu, String _nguoiLap, String _nguoigiao, String _maMay, String _maHinhThuc, String _maNguon, SmartDate _ngayHDon, SmartDate _ngayPnhap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBPHIEUNHAP_CREATE", _maNCC, _soHD, _soCT, _soHDon, _makho, _thanhtoan, _ngayTToan.DBValue, _ngayNhapTT.DBValue, _nVNhap, _vAT, _tong, _ghichu, _nguoiSD , _nguoigiao, _maMay, _maHinhThuc, _maNguon, _ngayHDon.DBValue, _ngayPnhap.DBValue));
			// }
            _TBPhieuNhap_Cs.Update(this);
		}
		
		/// <summary>
		/// Update all changes made on <see cref="TBPhieuNhap" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateTBPhieuNhap
			if (IsDirty){
                
                
				DataProvider.Instance().UpdateTBPhieuNhap(_maPN, _maNCC, _soHD, _soCT, _soHDon, _makho, _thanhtoan, _ngayTToan, _ngayNhapTT, _nVNhap, _vAT, _tong, _ghichu, _huy, _nguoiSD , _nguoigiao, _maMay, _maHinhThuc, _maNguon, _ngayHDon, _ngayPnhap);
				// public abstract void UpdateTBPhieuNhap(String _maPN, String _maNCC, String _soHD, String _soCT, String _soHDon, String _makho, Boolean _thanhtoan, SmartDate _ngayTToan, SmartDate _ngayNhapTT, String _nVNhap, Decimal _vAT, Decimal _tong, String _ghichu, Boolean _huy, String _nguoiSD, String _nguoigiao, String _maMay, String _maHinhThuc, String _maNguon, SmartDate _ngayHDon, SmartDate _ngayPnhap);
				// public override void UpdateTBPhieuNhap(String _maPN, String _maNCC, String _soHD, String _soCT, String _soHDon, String _makho, Boolean _thanhtoan, SmartDate _ngayTToan, SmartDate _ngayNhapTT, String _nVNhap, Decimal _vAT, Decimal _tong, String _ghichu, Boolean _huy, String _nguoiSD, String _nguoigiao, String _maMay, String _maHinhThuc, String _maNguon, SmartDate _ngayHDon, SmartDate _ngayPnhap)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBPHIEUNHAP_UPDATE", _maPN, _maNCC, _soHD, _soCT, _soHDon, _makho, _thanhtoan, _ngayTToan.DBValue, _ngayNhapTT.DBValue, _nVNhap, _vAT, _tong, _ghichu, _huy, , _nguoiSD , _nguoigiao, _maMay, _maHinhThuc, _maNguon, _ngayHDon.DBValue, _ngayPnhap.DBValue);
				// }			
                _TBPhieuNhap_Cs.Update(this);
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            //_nguoihuy = HTC.ShareVariables.pub_sNguoiSD ;  
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoihuy , _maPN));
		}

		/// <summary>
		/// Delete the <see cref="TBPhieuNhap" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateTBPhieuNhap
            DataProvider.Instance().DeleteTBPhieuNhap(crit.MaMay, crit.NguoiSD, crit.MaPN);
			// public abstract void DeleteTBPhieuNhap(String _maPN);
			// public override void DeleteTBPhieuNhap(String _maPN);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spTBPHIEUNHAP_DELETED", _maPN);
			// }
		}
        //public void TinhLaiTongTien()
        //{
        //    _tongTien = 0;
        //   // Decimal total = 0;
        //    foreach (TBPhieuNhap_C obj in _TBPhieuNhap_Cs)
        //        //_tongTien += Convert.ToDecimal(obj.ThanhTien);
        //        //_tongTien + = object.  * dr.GetDecimal("Soluong") * (100 + dr.GetDecimal("vat")) / 100;
        //        _tongTien  = _tongTien + obj.DonGia * obj.Soluong * (100 + obj.Vat) / 100;
        //    //_tongTien = total;
        //    //return _tongTien;
        //}
		#endregion
	}

}
