// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	KhamBenh_GETsMABNInfo
// Kieu doi tuong  :	KhamBenh_GETsMABNInfo
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	4/1/2009 2:46:27 PM
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
	/// This is a base generated class of <see cref="KhamBenh_GETsMABNInfo" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class KhamBenh_GETsMABNInfo : BusinessBase<KhamBenh_GETsMABNInfo>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maSoKham = String.Empty;
		private String _maBN = String.Empty;
        private String _HoTen = String.Empty;
		private String _maDT = String.Empty;
		private String _sothe = String.Empty;
        private String _bschidinh = String.Empty;
		private SmartDate _giatriDN = new SmartDate(true);
		private String _maBV = String.Empty;
		private String _maTinh = String.Empty;
        private String _tenbenh = String.Empty;
		private SmartDate _ngayKT = new SmartDate(true);
		private String _gio = String.Empty;
		private SmartDate _ngayduyet = new SmartDate(true);
		private String _nguoiduyet = String.Empty;
		private SmartDate _ngayQT = new SmartDate(true);
		private SmartDate _ngayQTTT = new SmartDate(true);
		private String _nguoiQT = String.Empty;
		private String _maBenhNoiGT = String.Empty;
		private String _maNoiGT = String.Empty;
		private String _cDNoiGT = String.Empty;
		private String _ghichu = String.Empty;
		private Byte _loaiKham = 0;
		private Boolean _cungtra = false;
		private Decimal _ck = 0;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private Byte _nguoiHuy = 0;
		private SmartDate _ngayHuy = new SmartDate(true);
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
		private String _dienThoai = String.Empty;
		private String _diaChi = String.Empty;
		private Decimal _tongTien = 0;
		private Decimal _tongBHTra = 0;
		private Decimal _tongTienBH = 0;
        private int _OrderNumber;
        private SmartDate _ngaydk = new SmartDate(true);
		#endregion
		
		#region Business Properties and Methods
        public String bschidinh
        {
            get
            {
                CanReadProperty("bschidinh", true);
                return _bschidinh;
            }
            set
            {
                CanWriteProperty("bschidinh", true);
                if (_bschidinh != value)
                {
                    _bschidinh = value;
                    PropertyHasChanged("bschidinh");
                }
            }
        }
        public String tenbenh
        {
            get
            {
                CanReadProperty("tenbenh", true);
                return _tenbenh;
            }
            set
            {
                CanWriteProperty("tenbenh", true);
                if (_tenbenh != value)
                {
                    _tenbenh = value;
                    PropertyHasChanged("tenbenh");
                }
            }
        }
        public String HoTen
        {
            get
            {
                CanReadProperty("HoTen", true);
                return _HoTen;
            }
            set
            {
                CanWriteProperty("HoTen", true);
                if (_HoTen != value)
                {
                    _HoTen = value;
                    PropertyHasChanged("HoTen");
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
		
		public String Sothe
		{
			get 
			{
				CanReadProperty("Sothe", true);
				return _sothe;
			}
			set 
			{
				CanWriteProperty("Sothe", true);
				if (_sothe != value) 
				{
					_sothe = value;
					PropertyHasChanged("Sothe");
				}
			}
		}
		
		public string GiatriDN
		{
			get 
			{
				CanReadProperty("GiatriDN", true);
				return _giatriDN.Text;
			}
			set 
			{
				CanWriteProperty("GiatriDN", true);
				if (_giatriDN.Text != value) 
				{
					_giatriDN.Text = value;
					PropertyHasChanged("GiatriDN");
				}
			}
		}
		
		public String MaBV
		{
			get 
			{
				CanReadProperty("MaBV", true);
				return _maBV;
			}
			set 
			{
				CanWriteProperty("MaBV", true);
				if (_maBV != value) 
				{
					_maBV = value;
					PropertyHasChanged("MaBV");
				}
			}
		}
		
		public String MaTinh
		{
			get 
			{
				CanReadProperty("MaTinh", true);
				return _maTinh;
			}
			set 
			{
				CanWriteProperty("MaTinh", true);
				if (_maTinh != value) 
				{
					_maTinh = value;
					PropertyHasChanged("MaTinh");
				}
			}
		}
		
		public string NgayKT
		{
			get 
			{
				CanReadProperty("NgayKT", true);
				return _ngayKT.Text;
			}
			set 
			{
				CanWriteProperty("NgayKT", true);
				if (_ngayKT.Text != value) 
				{
					_ngayKT.Text = value;
					PropertyHasChanged("NgayKT");
				}
			}
		}
		
        //public String Gio
        //{
        //    get 
        //    {
        //        CanReadProperty("Gio", true);
        //        return _gio;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("Gio", true);
        //        if (_gio != value) 
        //        {
        //            _gio = value;
        //            PropertyHasChanged("Gio");
        //        }
        //    }
        //}
		
        //public string Ngayduyet
        //{
        //    get 
        //    {
        //        CanReadProperty("Ngayduyet", true);
        //        return _ngayduyet.Text;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("Ngayduyet", true);
        //        if (_ngayduyet.Text != value) 
        //        {
        //            _ngayduyet.Text = value;
        //            PropertyHasChanged("Ngayduyet");
        //        }
        //    }
        //}
		
        //public String Nguoiduyet
        //{
        //    get 
        //    {
        //        CanReadProperty("Nguoiduyet", true);
        //        return _nguoiduyet;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("Nguoiduyet", true);
        //        if (_nguoiduyet != value) 
        //        {
        //            _nguoiduyet = value;
        //            PropertyHasChanged("Nguoiduyet");
        //        }
        //    }
        //}
		
		public string NgayQT
		{
			get 
			{
				CanReadProperty("NgayQT", true);
				return _ngayQT.Text;
			}
			set 
			{
				CanWriteProperty("NgayQT", true);
				if (_ngayQT.Text != value) 
				{
					_ngayQT.Text = value;
					PropertyHasChanged("NgayQT");
				}
			}
		}
		
		public string NgayQTTT
		{
			get 
			{
				CanReadProperty("NgayQTTT", true);
				return _ngayQTTT.Text;
			}
			set 
			{
				CanWriteProperty("NgayQTTT", true);
				if (_ngayQTTT.Text != value) 
				{
					_ngayQTTT.Text = value;
					PropertyHasChanged("NgayQTTT");
				}
			}
		}
		
		public String NguoiQT
		{
			get 
			{
				CanReadProperty("NguoiQT", true);
				return _nguoiQT;
			}
			set 
			{
				CanWriteProperty("NguoiQT", true);
				if (_nguoiQT != value) 
				{
					_nguoiQT = value;
					PropertyHasChanged("NguoiQT");
				}
			}
		}
		
		public String MaBenhNoiGT
		{
			get 
			{
				CanReadProperty("MaBenhNoiGT", true);
				return _maBenhNoiGT;
			}
			set 
			{
				CanWriteProperty("MaBenhNoiGT", true);
				if (_maBenhNoiGT != value) 
				{
					_maBenhNoiGT = value;
					PropertyHasChanged("MaBenhNoiGT");
				}
			}
		}
		
		public String MaNoiGT
		{
			get 
			{
				CanReadProperty("MaNoiGT", true);
				return _maNoiGT;
			}
			set 
			{
				CanWriteProperty("MaNoiGT", true);
				if (_maNoiGT != value) 
				{
					_maNoiGT = value;
					PropertyHasChanged("MaNoiGT");
				}
			}
		}
		
		public String CDNoiGT
		{
			get 
			{
				CanReadProperty("CDNoiGT", true);
				return _cDNoiGT;
			}
			set 
			{
				CanWriteProperty("CDNoiGT", true);
				if (_cDNoiGT != value) 
				{
					_cDNoiGT = value;
					PropertyHasChanged("CDNoiGT");
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
		
		public Byte LoaiKham
		{
			get 
			{
				CanReadProperty("LoaiKham", true);
				return _loaiKham;
			}
			set 
			{
				CanWriteProperty("LoaiKham", true);
				if (_loaiKham != value) 
				{
					_loaiKham = value;
					PropertyHasChanged("LoaiKham");
				}
			}
		}
		
		public Boolean Cungtra
		{
			get 
			{
				CanReadProperty("Cungtra", true);
				return _cungtra;
			}
			set 
			{
				CanWriteProperty("Cungtra", true);
				if (_cungtra != value) 
				{
					_cungtra = value;
					PropertyHasChanged("Cungtra");
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
		
        //public string NgayLap
        //{
        //    get 
        //    {
        //        CanReadProperty("NgayLap", true);
        //        return _ngayLap.Text;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NgayLap", true);
        //        if (_ngayLap.Text != value) 
        //        {
        //            _ngayLap.Text = value;
        //            PropertyHasChanged("NgayLap");
        //        }
        //    }
        //}
		
        //public String NguoiLap
        //{
        //    get 
        //    {
        //        CanReadProperty("NguoiLap", true);
        //        return _nguoiLap;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NguoiLap", true);
        //        if (_nguoiLap != value) 
        //        {
        //            _nguoiLap = value;
        //            PropertyHasChanged("NguoiLap");
        //        }
        //    }
        //}
		
        //public string NgaySD
        //{
        //    get 
        //    {
        //        CanReadProperty("NgaySD", true);
        //        return _ngaySD.Text;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NgaySD", true);
        //        if (_ngaySD.Text != value) 
        //        {
        //            _ngaySD.Text = value;
        //            PropertyHasChanged("NgaySD");
        //        }
        //    }
        //}
        public string NgayDK
        {
            get
            {
                CanReadProperty("Ngaydk", true);
                _ngaydk.FormatString = "dd/MM/yyyy";  
                return _ngaydk.Text;
            }
            set
            {
                CanWriteProperty("Ngaydk", true);
                if (_ngaydk.Text != value)
                {
                    _ngaydk.Text = value;
                    PropertyHasChanged("Ngaydk");
                }
            }
        }
        //public String NguoiSD
        //{
        //    get 
        //    {
        //        CanReadProperty("NguoiSD", true);
        //        return _nguoiSD;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NguoiSD", true);
        //        if (_nguoiSD != value) 
        //        {
        //            _nguoiSD = value;
        //            PropertyHasChanged("NguoiSD");
        //        }
        //    }
        //}
		
        //public String MaMay
        //{
        //    get 
        //    {
        //        CanReadProperty("MaMay", true);
        //        return _maMay;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("MaMay", true);
        //        if (_maMay != value) 
        //        {
        //            _maMay = value;
        //            PropertyHasChanged("MaMay");
        //        }
        //    }
        //}
		
        //public Boolean Huy
        //{
        //    get 
        //    {
        //        CanReadProperty("Huy", true);
        //        return _huy;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("Huy", true);
        //        if (_huy != value) 
        //        {
        //            _huy = value;
        //            PropertyHasChanged("Huy");
        //        }
        //    }
        //}
		
        //public Byte NguoiHuy
        //{
        //    get 
        //    {
        //        CanReadProperty("NguoiHuy", true);
        //        return _nguoiHuy;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NguoiHuy", true);
        //        if (_nguoiHuy != value) 
        //        {
        //            _nguoiHuy = value;
        //            PropertyHasChanged("NguoiHuy");
        //        }
        //    }
        //}
		
        //public string NgayHuy
        //{
        //    get 
        //    {
        //        CanReadProperty("NgayHuy", true);
        //        return _ngayHuy.Text;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NgayHuy", true);
        //        if (_ngayHuy.Text != value) 
        //        {
        //            _ngayHuy.Text = value;
        //            PropertyHasChanged("NgayHuy");
        //        }
        //    }
        //}
		
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
		
		public String DienThoai
		{
			get 
			{
				CanReadProperty("DienThoai", true);
				return _dienThoai;
			}
			set 
			{
				CanWriteProperty("DienThoai", true);
				if (_dienThoai != value) 
				{
					_dienThoai = value;
					PropertyHasChanged("DienThoai");
				}
			}
		}
		
		public String DiaChi
		{
			get 
			{
				CanReadProperty("DiaChi", true);
				return _diaChi;
			}
			set 
			{
				CanWriteProperty("DiaChi", true);
				if (_diaChi != value) 
				{
					_diaChi = value;
					PropertyHasChanged("DiaChi");
				}
			}
		}
		
        //public Decimal TongTien
        //{
        //    get 
        //    {
        //        CanReadProperty("TongTien", true);
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
		
        //public Decimal TongBHTra
        //{
        //    get 
        //    {
        //        CanReadProperty("TongBHTra", true);
        //        return _tongBHTra;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("TongBHTra", true);
        //        if (_tongBHTra != value) 
        //        {
        //            _tongBHTra = value;
        //            PropertyHasChanged("TongBHTra");
        //        }
        //    }
        //}
		
        //public Decimal TongTienBH
        //{
        //    get 
        //    {
        //        CanReadProperty("TongTienBH", true);
        //        return _tongTienBH;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("TongTienBH", true);
        //        if (_tongTienBH != value) 
        //        {
        //            _tongTienBH = value;
        //            PropertyHasChanged("TongTienBH");
        //        }
        //    }
        //}

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
			return _maSoKham;
		}
		#endregion
		#endregion

				
        //#region Business Object Rules and Validation
	
        //#endregion
		
        //#region Factory Methods
		
		
        //#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal KhamBenh_GETsMABNInfo()
		{	
			// Prevent direct creation
		}
		
        internal KhamBenh_GETsMABNInfo(  int ordernumber,
  String maSoKham ,
		                                 String maBN ,
		                                 String maDT ,
		                                 String sothe ,
		                                 SmartDate giatriDN ,
		                                 String maBV ,
		                                 String maTinh ,
		                                 SmartDate ngayKT ,
		                                 String gio ,
		                                 SmartDate ngayduyet,
		                                 String nguoiduyet,
		                                 SmartDate ngayQT ,
		                                 SmartDate ngayQTTT ,
		                                 String nguoiQT ,
		                                 String maBenhNoiGT,
		                                 String maNoiGT ,
		                                 String cDNoiGT ,
		                                 String ghichu ,
		                                 Byte loaiKham ,
		                                 Boolean cungtra ,
		                                 Decimal ck ,
		                                 SmartDate ngayLap ,
		                                 String nguoiLap ,
		                                 SmartDate ngaySD ,
		                                 String nguoiSD ,
		                                 String maMay ,
		                                 Boolean huy ,
		                                 Byte nguoiHuy ,
		                                 SmartDate ngayHuy ,
		                                 SmartDate ngaySD1 ,
		                                 String nguoiSD1 ,
		                                 String dienThoai ,
		                                 String diaChi ,
		                                 Decimal tongTien ,
		                                 Decimal tongBHTra ,
		                                 Decimal tongTienBH,
  SmartDate ngaydk,
  string hoten,
  string bschidinh,
  string tenbenh
            )
        {
  _HoTen = hoten;
 _OrderNumber = ordernumber;
 _bschidinh = bschidinh;
 _tenbenh = tenbenh;
   _maSoKham = maSoKham;
		                                  _maBN = maBN;
		                                  _maDT = maDT;
		                                  _sothe = sothe;
		                                  _giatriDN = giatriDN;
		                                  _maBV = maBV;
		                                  _maTinh = maTinh;
		                                  _ngayKT = ngayKT;
		                                  _gio = gio;
		                                  _ngayduyet= ngayduyet;
		                                  _nguoiduyet= nguoiduyet;
		                                  _ngayQT = ngayQT;
		                                  _ngayQTTT = ngayQTTT;
		                                  _nguoiQT = nguoiQT;
		                                  _maBenhNoiGT= maBenhNoiGT;
		                                  _maNoiGT = maNoiGT;
		                                  _cDNoiGT = cDNoiGT;
		                                  _ghichu = ghichu;
		                                  _loaiKham = loaiKham;
		                                  _cungtra = cungtra;
		                                  _ck = ck;
		                                  _ngayLap = ngayLap ;
		                                  _nguoiLap = nguoiLap;
		                                  _ngaySD = ngaySD;
		                                  _nguoiSD = nguoiSD;
		                                  _maMay = maMay;
		                                  _huy = huy;
		                                  _nguoiHuy = nguoiHuy;
		                                  _ngayHuy = ngayHuy;
		                                  _ngaySD1 = ngaySD1;
		                                  _nguoiSD1 = nguoiSD1;
		                                  _dienThoai = dienThoai;
		                                  _diaChi = diaChi;
		                                  _tongTien = tongTien;
		                                  _tongBHTra = tongBHTra;
		                                  _tongTienBH =  tongTienBH;
   _ngaydk = ngaydk;
   
        }
        internal KhamBenh_GETsMABNInfo(int ordernumber,
 String maSoKham,
                                        String maBN,
                                     
 SmartDate ngaydk,
 
 string bschidinh,
 string tenbenh
           )
        {
            _OrderNumber = ordernumber;
            _bschidinh = bschidinh;
            _tenbenh = tenbenh;
            _maSoKham = maSoKham;
            _maBN = maBN;
            _ngaydk = ngaydk;

        }
		#endregion
		
        //#region Authorization

        //public static bool CanGetObject()
        //{
        //    return true;
        //}
		
        //public static bool CanDeleteObject()
        //{
        //    return true;
        //}

        //public static bool CanAddObject()
        //{
        //    return true;
        //}

        //public static bool CanEditObject()
        //{
        //    return true;
        //}
		
        //#endregion

        //#region Data Access
        ///// <summary>
        ///// Load a <see cref="KhamBenh_GETsMABNInfo" /> Object from given SafeDataReader.
        ///// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaSoKham") != null) _maSoKham = dr.GetString("MaSoKham");
        //    if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
        //    if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
        //    if (dr.GetString("Sothe") != null) _sothe = dr.GetString("Sothe");
        //    if (dr.GetSmartDate("GiatriDN", true) != null) _giatriDN = dr.GetSmartDate("GiatriDN", true);
        //    if (dr.GetString("MaBV") != null) _maBV = dr.GetString("MaBV");
        //    if (dr.GetString("MaTinh") != null) _maTinh = dr.GetString("MaTinh");
        //    if (dr.GetSmartDate("NgayKT", true) != null) _ngayKT = dr.GetSmartDate("NgayKT", true);
        //    if (dr.GetString("Gio") != null) _gio = dr.GetString("Gio");
        //    if (dr.GetSmartDate("Ngayduyet", true) != null) _ngayduyet = dr.GetSmartDate("Ngayduyet", true);
        //    if (dr.GetString("Nguoiduyet") != null) _nguoiduyet = dr.GetString("Nguoiduyet");
        //    if (dr.GetSmartDate("NgayQT", true) != null) _ngayQT = dr.GetSmartDate("NgayQT", true);
        //    if (dr.GetSmartDate("NgayQTTT", true) != null) _ngayQTTT = dr.GetSmartDate("NgayQTTT", true);
        //    if (dr.GetString("NguoiQT") != null) _nguoiQT = dr.GetString("NguoiQT");
        //    if (dr.GetString("MaBenhNoiGT") != null) _maBenhNoiGT = dr.GetString("MaBenhNoiGT");
        //    if (dr.GetString("MaNoiGT") != null) _maNoiGT = dr.GetString("MaNoiGT");
        //    if (dr.GetString("CDNoiGT") != null) _cDNoiGT = dr.GetString("CDNoiGT");
        //    if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
        //    if (dr.GetByte("LoaiKham") != null) _loaiKham = dr.GetByte("LoaiKham");
        //    if (dr.GetBoolean("Cungtra") != null) _cungtra = dr.GetBoolean("Cungtra");
        //    if (dr.GetDecimal("CK") != null) _ck = dr.GetDecimal("CK");
        //    if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
        //    if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
        //    if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetByte("NguoiHuy") != null) _nguoiHuy = dr.GetByte("NguoiHuy");
        //    if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
        //    if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
        //    if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
        //    if (dr.GetString("DienThoai") != null) _dienThoai = dr.GetString("DienThoai");
        //    if (dr.GetString("DiaChi") != null) _diaChi = dr.GetString("DiaChi");
        //    if (dr.GetDecimal("TongTien") != null) _tongTien = dr.GetDecimal("TongTien");
        //    if (dr.GetDecimal("TongBHTra") != null) _tongBHTra = dr.GetDecimal("TongBHTra");
        //    if (dr.GetDecimal("TongTienBH") != null) _tongTienBH = dr.GetDecimal("TongTienBH");
        //}
		
        ///// <summary>
        ///// Insert the new <see cref="KhamBenh_GETsMABNInfo" /> Object to underlying database.
        ///// </summary>
        ////protected override void DataPortal_Insert()
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh_GETsMABNInfo
        //    // Copy & paste ham duoi day vao file DataProvider.cs
        //            }
		
        ///// <summary>
        ///// Update all changes made on <see cref="KhamBenh_GETsMABNInfo" /> Object to underlying database.
        ///// </summary>
        ////protected override void DataPortal_Update()
        ////{
        ////    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_GETsMABNInfo
        ////    if (IsDirty){
        ////        DataProvider.Instance().UpdateKhamBenh_GETsMABNInfo(_maSoKham, _maBN, _maDT, _sothe, _giatriDN, _maBV, _maTinh, _ngayKT, _gio, _ngayduyet, _nguoiduyet, _ngayQT, _ngayQTTT, _nguoiQT, _maBenhNoiGT, _maNoiGT, _cDNoiGT, _ghichu, _loaiKham, _cungtra, _ck, _ngayLap, _nguoiSD , _ngaySD, _nguoiSD , _maMay, _huy, _nguoiSD , _ngayHuy, _ngaySD1, _nguoiSD1, _dienThoai, _diaChi, _tongTien, _tongBHTra, _tongTienBH);
        ////        // public abstract void UpdateKhamBenh_GETsMABNInfo(String _maSoKham, String _maBN, String _maDT, String _sothe, SmartDate _giatriDN, String _maBV, String _maTinh, SmartDate _ngayKT, String _gio, SmartDate _ngayduyet, String _nguoiduyet, SmartDate _ngayQT, SmartDate _ngayQTTT, String _nguoiQT, String _maBenhNoiGT, String _maNoiGT, String _cDNoiGT, String _ghichu, Byte _loaiKham, Boolean _cungtra, Decimal _ck, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngaySD, String _nguoiSD, String _maMay, Boolean _huy, Byte _nguoiHuy, SmartDate _ngayHuy, SmartDate _ngaySD1, String _nguoiSD1, String _dienThoai, String _diaChi, Decimal _tongTien, Decimal _tongBHTra, Decimal _tongTienBH);
        ////        // public override void UpdateKhamBenh_GETsMABNInfo(String _maSoKham, String _maBN, String _maDT, String _sothe, SmartDate _giatriDN, String _maBV, String _maTinh, SmartDate _ngayKT, String _gio, SmartDate _ngayduyet, String _nguoiduyet, SmartDate _ngayQT, SmartDate _ngayQTTT, String _nguoiQT, String _maBenhNoiGT, String _maNoiGT, String _cDNoiGT, String _ghichu, Byte _loaiKham, Boolean _cungtra, Decimal _ck, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngaySD, String _nguoiSD, String _maMay, Boolean _huy, Byte _nguoiHuy, SmartDate _ngayHuy, SmartDate _ngaySD1, String _nguoiSD1, String _dienThoai, String _diaChi, Decimal _tongTien, Decimal _tongBHTra, Decimal _tongTienBH);
        ////        // {
        ////        //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maSoKham, _maBN, _maDT, _sothe, _giatriDN.DBValue, _maBV, _maTinh, _ngayKT.DBValue, _gio, _ngayduyet.DBValue, _nguoiduyet, _ngayQT.DBValue, _ngayQTTT.DBValue, _nguoiQT, _maBenhNoiGT, _maNoiGT, _cDNoiGT, _ghichu, _loaiKham, _cungtra, _ck, _ngayLap.DBValue, _nguoiSD , _ngaySD.DBValue, _nguoiSD , _maMay, _huy, _nguoiSD , _ngayHuy.DBValue, _ngaySD1.DBValue, _nguoiSD1, _dienThoai, _diaChi, _tongTien, _tongBHTra, _tongTienBH);
        ////        // }				
        ////    }
        ////}
        //#endregion
	}

}
