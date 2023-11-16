// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMThuoc_Ke
// Kieu doi tuong  :	DMThuoc_Ke
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	3/8/2009 4:10:41 PM
// Nguoi tao       :	BACHTX
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
	/// This is a base generated class of <see cref="DMThuoc_Ke" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMThuoc_Ke : BusinessBase<DMThuoc_Ke>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _MaKe = String.Empty;
		private String _parent = String.Empty;
		private String _maNhom = String.Empty;
        private String _maPL = String.Empty;
        private String _maChungLoai = String.Empty;
		private String _tenGoc = String.Empty;
		private String _tenTC = String.Empty;
		private String _tenTM = String.Empty;
        private String _tenTMHL = String.Empty;
		private String _tenTM1 = String.Empty;
		private String _tenTM2 = String.Empty;
		private String _tenTA = String.Empty;
		private Boolean _thuocGoc = false;
		private Decimal _ngaydungtoida = 0;
		private String _maNSX = String.Empty;
		private String _hamLuong = String.Empty;
        private String _hamLuongD = String.Empty;
		private String _maDVTHL = String.Empty;
		private Decimal _nguong = 0;
		private String _maDVT = String.Empty;
        private String _maDVT2 = String.Empty;
		private Decimal _quydoi = 0;
        private String _MaKe2 = String.Empty;
		
		private Boolean _apDungGoi = true;
		private Boolean _handung = true;
		private String _lieudung = String.Empty;
		private String _cachdung = String.Empty;
		private Decimal _gianhap = 0;
		private SmartDate _ngaynhap = new SmartDate(true);
		private Decimal _gianhap1 = 0;
		private SmartDate _ngaynhap1 = new SmartDate(true);
		private Decimal _gianhap2 = 0;
		private SmartDate _ngaynhap2 = new SmartDate(true);
		private Decimal _donGiaTT = 0;
		private Decimal _donGiaTT1 = 0;
		private Decimal _dongiaThuT = 0;
		private Decimal _dongiaPhauT = 0;
		private Decimal _dongiaCLS = 0;
		private Decimal _giaQuay = 0;
		private Decimal _giaQuay1 = 0;
		private String _khoban = String.Empty;
		private String _khophat = String.Empty;
		private Boolean _thuocThuT = false;
		private Boolean _thuocPhauT = false;
		private Boolean _thuocCLS = false;
		private Boolean _ThuocNoiT = false;
		private Boolean _thuocDuoc = false;
		private Boolean _thuocBan = false;
        private Boolean _duyetNgoaiT = true;
        private Boolean _duyetNoiT = true;
		private String _ghichu = String.Empty;
		private String _maMay = String.Empty;
        private String _tendvt = String.Empty;
        private String _tendvt2 = String.Empty;
        private String _tendvthl = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngayHuy = new SmartDate(true);
		private String _nguoiHuy = String.Empty;
        private String _malh = String.Empty;
        private String _matp = String.Empty;
        private String _duongdung = String.Empty;
        private int _OrderNumber;
        private String _tennguoiLap = String.Empty;
        private String _tennguoiSD = String.Empty;
        private String _tennguoiHuy = String.Empty;
        private String _tenNSX = String.Empty;
        private String _quycach = String.Empty;
        private String _matk = String.Empty;
        private String _sovisa = String.Empty;
        private Boolean _thuocban2 = false;
        private Boolean _KhongSD =false;
        private Decimal _giaQuay56 = 0;
        private Decimal _giaQuay561 = 0;

        private String _maql = String.Empty;
        private Decimal _gianhap43 = 0;
        private SmartDate _ngaynhap43 = new SmartDate(true);
        private Decimal _gianhap56 = 0;
        private SmartDate _ngaynhap56 = new SmartDate(true);

        private Boolean _thuocHoiChan = false;
        private Byte _thuocTieuHao = 0;
		#endregion
		
		#region Business Properties and Methods
        public Decimal Gianhap43
        {
            get
            {
                CanReadProperty("Gianhap43", true);
                return _gianhap43;
            }
            set
            {
                CanWriteProperty("Gianhap43", true);
                if (_gianhap43 != value)
                {
                    _gianhap43 = value;
                    PropertyHasChanged("Gianhap43");
                }
            }
        }

        public string Ngaynhap43
        {
            get
            {
                CanReadProperty("Ngaynhap43", true);
                return _ngaynhap43.Text;
            }
            set
            {
                CanWriteProperty("Ngaynhap43", true);
                if (_ngaynhap43.Text != value)
                {
                    _ngaynhap43.Text = value;
                    PropertyHasChanged("Ngaynhap43");
                }
            }
        }
        public Decimal Gianhap56
        {
            get
            {
                CanReadProperty("Gianhap56", true);
                return _gianhap56;
            }
            set
            {
                CanWriteProperty("Gianhap56", true);
                if (_gianhap56 != value)
                {
                    _gianhap56 = value;
                    PropertyHasChanged("Gianhap56");
                }
            }
        }

        public string Ngaynhap56
        {
            get
            {
                CanReadProperty("Ngaynhap56", true);
                return _ngaynhap56.Text;
            }
            set
            {
                CanWriteProperty("Ngaynhap56", true);
                if (_ngaynhap56.Text != value)
                {
                    _ngaynhap56.Text = value;
                    PropertyHasChanged("Ngaynhap56");
                }
            }
        }
        public String maql
        {
            get
            {
                CanReadProperty("maql", true);
                return _maql;
            }
            set
            {
                CanWriteProperty("maql", true);
                if (_maql != value)
                {
                    _maql = value;
                    PropertyHasChanged("maql");
                }
            }
        }
        public Boolean KhongSD
        {
            get
            {
                CanReadProperty("KhongSD", true);
                return _KhongSD;
            }
            set
            {
                CanWriteProperty("KhongSD", true);
                if (_KhongSD != value)
                {
                    _KhongSD = value;
                    PropertyHasChanged("KhongSD");
                }
            }
        }
		public String MaKe
		{
			get 
			{
				CanReadProperty("MaKe", true);
				return _MaKe;
			}
			set 
			{
				CanWriteProperty("MaKe", true);
				if (_MaKe != value) 
				{
					_MaKe = value;
					PropertyHasChanged("MaKe");
				}
			}
		}
        public String quycach
        {
            get
            {
                CanReadProperty("quycach", true);
                return _quycach;
            }
            set
            {
                CanWriteProperty("quycach", true);
                if (_quycach != value)
                {
                    _quycach = value;
                    PropertyHasChanged("quycach");
                }
            }
        }
        public String matk
        {
            get
            {
                CanReadProperty("matk", true);
                return _matk;
            }
            set
            {
                CanWriteProperty("matk", true);
                if (_matk != value)
                {
                    _matk = value;
                    PropertyHasChanged("matk");
                }
            }
        }
        public String sovisa
        {
            get
            {
                CanReadProperty("sovisa", true);
                return _sovisa;
            }
            set
            {
                CanWriteProperty("sovisa", true);
                if (_sovisa != value)
                {
                    _sovisa = value;
                    PropertyHasChanged("sovisa");
                }
            }
        }
        public String tendvt2
        {
            get
            {
                CanReadProperty("tendvt2", true);
                return _tendvt2;
            }
            set
            {
                CanWriteProperty("tendvt2", true);
                if (_tendvt2 != value)
                {
                    _tendvt2 = value;
                    PropertyHasChanged("tendvt2");
                }
            }
        }
        public String tendvt
        {
            get
            {
                CanReadProperty("tendvt", true);
                return _tendvt;
            }
            set
            {
                CanWriteProperty("tendvt", true);
                if (_tendvt != value)
                {
                    _tendvt = value;
                    PropertyHasChanged("tendvt");
                }
            }
        }
        public String tendvthl
        {
            get
            {
                CanReadProperty("tendvthl", true);
                return _tendvthl;
            }
            set
            {
                CanWriteProperty("tendvthl", true);
                if (_tendvthl != value)
                {
                    _tendvthl = value;
                    PropertyHasChanged("tendvthl");
                }
            }
        }
		public String Parent
		{
			get 
			{
				CanReadProperty("Parent", true);
				return _parent;
			}
			set 
			{
				CanWriteProperty("Parent", true);
				if (_parent != value) 
				{
					_parent = value;
					PropertyHasChanged("Parent");
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
		
		public String MaPL
		{
			get 
			{
				CanReadProperty("MaPL", true);
				return _maPL;
			}
			set 
			{
				CanWriteProperty("MaPL", true);
				if (_maPL != value) 
				{
					_maPL = value;
					PropertyHasChanged("MaPL");
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
		
		public String TenGoc
		{
			get 
			{
				CanReadProperty("TenGoc", true);
				return _tenGoc;
			}
			set 
			{
				CanWriteProperty("TenGoc", true);
				if (_tenGoc != value) 
				{
					_tenGoc = value;
					PropertyHasChanged("TenGoc");
				}
			}
		}
		
		public String TenTC
		{
			get 
			{
				CanReadProperty("TenTC", true);
				return _tenTC;
			}
			set 
			{
				CanWriteProperty("TenTC", true);
				if (_tenTC != value) 
				{
					_tenTC = value;
					PropertyHasChanged("TenTC");
				}
			}
		}
		
		public String TenTM
		{
			get 
			{
				CanReadProperty("TenTM", true);
				return _tenTM;
			}
			set 
			{
				CanWriteProperty("TenTM", true);
				if (_tenTM != value) 
				{
					_tenTM = value;
					PropertyHasChanged("TenTM");
				}
			}
		}
        public String TenTMHL
        {
            get
            {
                CanReadProperty("TenTMHL", true);
                if ((_tenTM1!="")&& (_tenTM2 !=""))
                    return _tenTM + "(" + _tenTM1 +")" +  "("+_tenTM2 +")"+ " " + _hamLuong + " " + _tendvthl + " " +_quycach + " " +_tenNSX  ;
                else if ((_tenTM1 =="")&& (_tenTM2 !=""))
                    return _tenTM + "(" + _tenTM2 +")" + " " + _hamLuong + " " + _tendvthl + " " + _quycach + " " + _tenNSX ;

                else if ((_tenTM1 != "") && (_tenTM2 == ""))
                    return _tenTM + "(" + _tenTM1 +")" + " " + _hamLuong + " " + _tendvthl + " " + _quycach + " " + _tenNSX ;
                else
                    return _tenTM + " " + _hamLuong + " " + _tendvthl + " " + _quycach + " " + _tenNSX ;
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
		
		public String TenTM1
		{
			get 
			{
				CanReadProperty("TenTM1", true);
				return _tenTM1;
			}
			set 
			{
				CanWriteProperty("TenTM1", true);
				if (_tenTM1 != value) 
				{
					_tenTM1 = value;
					PropertyHasChanged("TenTM1");
				}
			}
		}
		
		public String TenTM2
		{
			get 
			{
				CanReadProperty("TenTM2", true);
				return _tenTM2;
			}
			set 
			{
				CanWriteProperty("TenTM2", true);
				if (_tenTM2 != value) 
				{
					_tenTM2 = value;
					PropertyHasChanged("TenTM2");
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
		
		public Boolean ThuocGoc
		{
			get 
			{
				CanReadProperty("ThuocGoc", true);
				return _thuocGoc;
			}
			set 
			{
				CanWriteProperty("ThuocGoc", true);
				if (_thuocGoc != value) 
				{
					_thuocGoc = value;
					PropertyHasChanged("ThuocGoc");
				}
			}
		}
        public Boolean thuocban2
        {
            get
            {
                CanReadProperty("thuocban2", true);
                return _thuocban2;
            }
            set
            {
                CanWriteProperty("thuocban2", true);
                if (_thuocban2 != value)
                {
                    _thuocban2 = value;
                    PropertyHasChanged("thuocban2");
                }
            }
        }
		public Decimal Ngaydungtoida
		{
			get 
			{
				CanReadProperty("Ngaydungtoida", true);
				return _ngaydungtoida;
			}
			set 
			{
				CanWriteProperty("Ngaydungtoida", true);
				if (_ngaydungtoida != value) 
				{
					_ngaydungtoida = value;
					PropertyHasChanged("Ngaydungtoida");
				}
			}
		}
		
		public String MaNSX
		{
			get 
			{
				CanReadProperty("MaNSX", true);
				return _maNSX;
			}
			set 
			{
				CanWriteProperty("MaNSX", true);
				if (_maNSX != value) 
				{
					_maNSX = value;
					PropertyHasChanged("MaNSX");
				}
			}
		}
		
		public String HamLuong
		{
			get 
			{
				CanReadProperty("HamLuong", true);
				return _hamLuong;
			}
			set 
			{
				CanWriteProperty("HamLuong", true);
				if (_hamLuong != value) 
				{
					_hamLuong = value;
					PropertyHasChanged("HamLuong");
				}
			}
		}
        public String HamLuongD
        {
            get
            {
                CanReadProperty("HamLuong", true);
                return _hamLuong + " " + _tendvthl ;
            }
           
        }
		public String MaDVTHL
		{
			get 
			{
				CanReadProperty("MaDVTHL", true);
				return _maDVTHL;
			}
			set 
			{
				CanWriteProperty("MaDVTHL", true);
				if (_maDVTHL != value) 
				{
					_maDVTHL = value;
					PropertyHasChanged("MaDVTHL");
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
		
		public Decimal Quydoi
		{
			get 
			{
				CanReadProperty("Quydoi", true);
				return _quydoi;
			}
			set 
			{
				CanWriteProperty("Quydoi", true);
				if (_quydoi != value) 
				{
					_quydoi = value;
					PropertyHasChanged("Quydoi");
				}
			}
		}
        public String MaDVT2
        {
            get
            {
                CanReadProperty("MaDVT2", true);
                return _maDVT2;
            }
            set
            {
                CanWriteProperty("MaDVT2", true);
                if (_maDVT2 != value)
                {
                    _maDVT2 = value;
                    PropertyHasChanged("MaDVT2");
                }
            }
        }
		public String MaKegoc
		{
			get 
			{
				CanReadProperty("MaKegoc", true);
				return _MaKe2;
			}
			set 
			{
				CanWriteProperty("MaKegoc", true);
				if (_MaKe2 != value) 
				{
					_MaKe2 = value;
					PropertyHasChanged("MaKegoc");
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
		
		public String Lieudung
		{
			get 
			{
				CanReadProperty("Lieudung", true);
				return _lieudung;
			}
			set 
			{
				CanWriteProperty("Lieudung", true);
				if (_lieudung != value) 
				{
					_lieudung = value;
					PropertyHasChanged("Lieudung");
				}
			}
		}
		
		public String Cachdung
		{
			get 
			{
				CanReadProperty("Cachdung", true);
				return _cachdung;
			}
			set 
			{
				CanWriteProperty("Cachdung", true);
				if (_cachdung != value) 
				{
					_cachdung = value;
					PropertyHasChanged("Cachdung");
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
		
		public string Ngaynhap
		{
			get 
			{
				CanReadProperty("Ngaynhap", true);
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
		
		public string Ngaynhap1
		{
			get 
			{
				CanReadProperty("Ngaynhap1", true);
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
		
		public string Ngaynhap2
		{
			get 
			{
				CanReadProperty("Ngaynhap2", true);
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
		
		public Decimal DonGiaTT
		{
			get 
			{
				CanReadProperty("DonGiaTT", true);
				return _donGiaTT;
			}
			set 
			{
				CanWriteProperty("DonGiaTT", true);
				if (_donGiaTT != value) 
				{
					_donGiaTT = value;
					PropertyHasChanged("DonGiaTT");
				}
			}
		}
		
		public Decimal DonGiaTT1
		{
			get 
			{
				CanReadProperty("DonGiaTT1", true);
				return _donGiaTT1;
			}
			set 
			{
				CanWriteProperty("DonGiaTT1", true);
				if (_donGiaTT1 != value) 
				{
					_donGiaTT1 = value;
					PropertyHasChanged("DonGiaTT1");
				}
			}
		}
		
		public Decimal DongiaThuT
		{
			get 
			{
				CanReadProperty("DongiaThuT", true);
				return _dongiaThuT;
			}
			set 
			{
				CanWriteProperty("DongiaThuT", true);
				if (_dongiaThuT != value) 
				{
					_dongiaThuT = value;
					PropertyHasChanged("DongiaThuT");
				}
			}
		}
		
		public Decimal DongiaPhauT
		{
			get 
			{
				CanReadProperty("DongiaPhauT", true);
				return _dongiaPhauT;
			}
			set 
			{
				CanWriteProperty("DongiaPhauT", true);
				if (_dongiaPhauT != value) 
				{
					_dongiaPhauT = value;
					PropertyHasChanged("DongiaPhauT");
				}
			}
		}
		
		public Decimal DongiaCLS
		{
			get 
			{
				CanReadProperty("DongiaCLS", true);
				return _dongiaCLS;
			}
			set 
			{
				CanWriteProperty("DongiaCLS", true);
				if (_dongiaCLS != value) 
				{
					_dongiaCLS = value;
					PropertyHasChanged("DongiaCLS");
				}
			}
		}
		
		public Decimal GiaQuay
		{
			get 
			{
				CanReadProperty("GiaQuay", true);
				return _giaQuay;
			}
			set 
			{
				CanWriteProperty("GiaQuay", true);
				if (_giaQuay != value) 
				{
					_giaQuay = value;
					PropertyHasChanged("GiaQuay");
				}
			}
		}
        public Decimal GiaQuay56
        {
            get
            {
                CanReadProperty("GiaQuay56", true);
                return _giaQuay56;
            }
            set
            {
                CanWriteProperty("GiaQuay56", true);
                if (_giaQuay56 != value)
                {
                    _giaQuay56 = value;
                    PropertyHasChanged("GiaQuay56");
                }
            }
        }
        public Decimal GiaQuay561
        {
            get
            {
                CanReadProperty("GiaQuay561", true);
                return _giaQuay561;
            }
            set
            {
                CanWriteProperty("GiaQuay561", true);
                if (_giaQuay561 != value)
                {
                    _giaQuay561 = value;
                    PropertyHasChanged("GiaQuay561");
                }
            }
        }
		
		public Decimal GiaQuay1
		{
			get 
			{
				CanReadProperty("GiaQuay1", true);
				return _giaQuay1;
			}
			set 
			{
				CanWriteProperty("GiaQuay1", true);
				if (_giaQuay1 != value) 
				{
					_giaQuay1 = value;
					PropertyHasChanged("GiaQuay1");
				}
			}
		}
		
		public String Khoban
		{
			get 
			{
				CanReadProperty("Khoban", true);
				return _khoban;
			}
			set 
			{
				CanWriteProperty("Khoban", true);
				if (_khoban != value) 
				{
					_khoban = value;
					PropertyHasChanged("Khoban");
				}
			}
		}
		
		public String Khophat
		{
			get 
			{
				CanReadProperty("Khophat", true);
				return _khophat;
			}
			set 
			{
				CanWriteProperty("Khophat", true);
				if (_khophat != value) 
				{
					_khophat = value;
					PropertyHasChanged("Khophat");
				}
			}
		}
		
		public Boolean ThuocThuT
		{
			get 
			{
				CanReadProperty("ThuocThuT", true);
				return _thuocThuT;
			}
			set 
			{
				CanWriteProperty("ThuocThuT", true);
				if (_thuocThuT != value) 
				{
					_thuocThuT = value;
					PropertyHasChanged("ThuocThuT");
				}
			}
		}
		
		public Boolean ThuocPhauT
		{
			get 
			{
				CanReadProperty("ThuocPhauT", true);
				return _thuocPhauT;
			}
			set 
			{
				CanWriteProperty("ThuocPhauT", true);
				if (_thuocPhauT != value) 
				{
					_thuocPhauT = value;
					PropertyHasChanged("ThuocPhauT");
				}
			}
		}
		
		public Boolean ThuocCLS
		{
			get 
			{
				CanReadProperty("ThuocCLS", true);
				return _thuocCLS;
			}
			set 
			{
				CanWriteProperty("ThuocCLS", true);
				if (_thuocCLS != value) 
				{
					_thuocCLS = value;
					PropertyHasChanged("ThuocCLS");
				}
			}
		}
		
		public Boolean ThuocNoiT
		{
			get 
			{
				CanReadProperty("ThuocNoiT", true);
				return _ThuocNoiT;
			}
			set 
			{
				CanWriteProperty("ThuocNoiT", true);
				if (_ThuocNoiT != value) 
				{
					_ThuocNoiT = value;
					PropertyHasChanged("ThuocNoiT");
				}
			}
		}
		
		public Boolean ThuocDuoc
		{
			get 
			{
				CanReadProperty("ThuocDuoc", true);
				return _thuocDuoc;
			}
			set 
			{
				CanWriteProperty("ThuocDuoc", true);
				if (_thuocDuoc != value) 
				{
					_thuocDuoc = value;
					PropertyHasChanged("ThuocDuoc");
				}
			}
		}
		
		public Boolean ThuocBan
		{
			get 
			{
				CanReadProperty("ThuocBan", true);
				return _thuocBan;
			}
			set 
			{
				CanWriteProperty("ThuocBan", true);
				if (_thuocBan != value) 
				{
					_thuocBan = value;
					PropertyHasChanged("ThuocBan");
				}
			}
		}
		
		public Boolean DuyetNgoaiT
		{
			get 
			{
				CanReadProperty("DuyetNgoaiT", true);
				return _duyetNgoaiT;
			}
			set 
			{
				CanWriteProperty("DuyetNgoaiT", true);
				if (_duyetNgoaiT != value) 
				{
					_duyetNgoaiT = value;
					PropertyHasChanged("DuyetNgoaiT");
				}
			}
		}
		
		public Boolean DuyetNoiT
		{
			get 
			{
				CanReadProperty("DuyetNoiT", true);
				return _duyetNoiT;
			}
			set 
			{
				CanWriteProperty("DuyetNoiT", true);
				if (_duyetNoiT != value) 
				{
					_duyetNoiT = value;
					PropertyHasChanged("DuyetNoiT");
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
        public Boolean ThuocHoiChan
        {
            get
            {
                CanReadProperty("ThuocHoiChan", true);
                return _thuocHoiChan;
            }
            set
            {
                CanWriteProperty("ThuocHoiChan", true);
                if (_thuocHoiChan != value)
                {
                    _thuocHoiChan = value;
                    PropertyHasChanged("ThuocHoiChan");
                }
            }
        }
        public Byte  ThuocTieuHao
        {
            get
            {
                CanReadProperty("ThuocTieuHao", true);
                return _thuocTieuHao;
            }
            set
            {
                CanWriteProperty("ThuocTieuHao", true);
                if (_thuocTieuHao != value)
                {
                    _thuocTieuHao = value;
                    PropertyHasChanged("ThuocTieuHao");
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
        public String TenNguoiSD
        {
            get
            {
                CanReadProperty("TenNguoiSD", true);
                return _tennguoiSD;
            }
            set
            {
                CanWriteProperty("TenNguoiSD", true);
                if (_tennguoiSD != value)
                {
                    _tennguoiSD = value;
                    PropertyHasChanged("TenNguoiSD");
                }
            }
        }

        public String TenNguoiLap
        {
            get
            {
                CanReadProperty("TenNguoiLap", true);
                return _tennguoiLap;
            }
            set
            {
                CanWriteProperty("TenNguoiLap", true);
                if (_tennguoiLap != value)
                {
                    _tennguoiLap = value;
                    PropertyHasChanged("TenNguoiLap");
                }
            }
        }

        public String TenNguoiHuy
        {
            get
            {
                CanReadProperty("TenNguoiHuy", true);
                return _tennguoiHuy;
            }
            set
            {
                CanWriteProperty("TenNguoiHuy", true);
                if (_tennguoiHuy != value)
                {
                    _tennguoiHuy = value;
                    PropertyHasChanged("TenNguoiHuy");
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
		
		public string NgayLap
		{
			get 
			{
				CanReadProperty("NgayLap", true);
                _ngayLap.FormatString = "dd/MM/yyyy HH:mm:ss";
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
		
		public string NgayHuy
		{
			get 
			{
				CanReadProperty("NgayHuy", true);
                _ngayHuy.FormatString = "dd/MM/yyyy HH:mm:ss";
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
		
		public String nguoiHuy
		{
			get 
			{
				CanReadProperty("nguoiHuy", true);
				return _nguoiHuy;
			}
			set 
			{
				CanWriteProperty("nguoiHuy", true);
				if (_nguoiHuy != value) 
				{
					_nguoiHuy = value;
					PropertyHasChanged("nguoiHuy");
				}
			}
		}
        public String matp
        {
            get
            {
                CanReadProperty("matp", true);
                return _matp;
            }
            set
            {
                CanWriteProperty("matp", true);
                if (_matp != value)
                {
                    _matp = value;
                    PropertyHasChanged("matp");
                }
            }
        }
        public String duongdung
        {
            get
            {
                CanReadProperty("duongdung", true);
                return _duongdung;
            }
            set
            {
                CanWriteProperty("duongdung", true);
                if (_duongdung != value)
                {
                    _duongdung = value;
                    PropertyHasChanged("duongdung");
                }
            }
        }
        public String malh
        {
            get
            {
                CanReadProperty("malh", true);
                return _malh;
            }
            set
            {
                CanWriteProperty("malh", true);
                if (_malh != value)
                {
                    _malh = value;
                    PropertyHasChanged("malh");
                }
            }
        }
   
        public String TenNSX
        {
            get
            {
                CanReadProperty("TenNSX", true);
                return _tenNSX;
            }
            set
            {
                CanWriteProperty("TenNSX", true);
                if (_tenNSX != value)
                {
                    _tenNSX = value;
                    PropertyHasChanged("TenNSX");
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
			return _MaKe;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenTM", 350));
            ValidationRules.AddRule<DMThuoc_Ke>(StringRequired<DMThuoc_Ke>, "TenTM");
            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenTM", 350));
            ValidationRules.AddRule<DMThuoc_Ke>(StringRequiredDVT<DMThuoc_Ke>, "MaDVT");

        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMThuoc_Ke
        {

            if (target._tenTM == null || target._tenTM.Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }

        private static bool StringRequiredDVT<T>(T target, Csla.Validation.RuleArgs e) where T : DMThuoc_Ke
        {

            if (target._maDVT == null || target._maDVT.Trim().Length == 0)
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
		/// Factory method. New <see cref="DMThuoc_Ke" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMThuoc_Ke NewDMThuoc_Ke()
        {
            //return new DMNhomThuoc();
            return DataPortal.Create<DMThuoc_Ke>();
        }
		public static DMThuoc_Ke GetDMThuoc_Ke(String MaKe)
		{
			return DataPortal.Fetch<DMThuoc_Ke>(new Criteria(MaKe));
		}
		
		/// <summary>
		/// Marks the <see cref="DMThuoc_Ke" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMThuoc_Ke(String MaKe, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,MaKe));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMThuoc_Ke()
		{	
			// Prevent direct creation
		}
        internal DMThuoc_Ke(        int OrderNumber,
                                 String MaKe ,
		                         String parent ,
		                         String maNhom ,
                                 String maPL,
                                 String maChungLoai,
		                         String tenGoc ,
		                         String tenTC ,
		                         String tenTM ,
		                         String tenTM1 ,
		                         String tenTM2 ,
		                         String tenTA ,
		                         Boolean thuocGoc ,
		                         Decimal ngaydungtoida ,
		                         String maNSX ,
		                         String hamLuong ,
		                         String maDVTHL ,
		                         Decimal nguong,
		                         String maDVT ,
		                         Decimal quydoi ,
		                         String MaKegoc ,
		                         String maDVT2 ,
		                         Boolean apDungGoi ,
		                         Boolean handung ,
		                         String lieudung ,
		                         String cachdung ,
		                         Decimal gianhap ,
		                         SmartDate ngaynhap ,
		                         Decimal gianhap1 ,
		                         SmartDate ngaynhap1 ,
		                         Decimal gianhap2 ,
		                         SmartDate ngaynhap2 ,
		                         Decimal donGiaTT ,
		                         Decimal donGiaTT1 ,
		                         Decimal dongiaThuT ,
		                         Decimal dongiaPhauT ,
		                         Decimal dongiaCLS ,
		                         Decimal giaQuay ,
		                         Decimal giaQuay1 ,
		                         String khoban ,
		                         String khophat ,
		                         Boolean thuocThuT ,
		                         Boolean thuocPhauT ,
		                         Boolean thuocCLS ,
		                         Boolean ThuocNoiT ,
		                         Boolean thuocDuoc ,
		                         Boolean thuocBan ,
		                         Boolean duyetNgoaiT ,
		                         Boolean duyetNoiT ,
		                         String ghichu ,
		                         String maMay ,
		                         Boolean huy ,
		                         SmartDate ngaySD ,
		                         String nguoiSD ,
		                         SmartDate ngaySD1,
		                         String nguoiSD1 ,
		                         SmartDate ngayLap ,
		                         String nguoiLap ,
		                         SmartDate ngayHuy ,
		                         String nguoiHuy ,
                                 string malh,
                                 String tendvt,
                                 string tendvthl,
                                 string tennguoisd,
                                 string tennguoilap,
                                 string tennguoihuy,
                                 string tennsx,
                                 string quycach,
                                 string matk,
                                 string sovisa,
                                 Boolean thuocban2,
 Boolean ThuocHoiChan,
 Byte ThuocTieuHao,
 Boolean KhongSD,
                                 Decimal giaQuay56,
                                 Decimal giaQuay561,
                                 string maql, string matp, string duongdung, string tendvt2,
                                 Decimal gianhap43,
                                 SmartDate ngaynhap43,
                                 Decimal gianhap56,
                                 SmartDate ngaynhap56
            )
        {
              _OrderNumber = OrderNumber ;
              _gianhap56 = gianhap56;
              _ngaynhap56 = ngaynhap56;
              _gianhap43 = gianhap43;
              _ngaynhap43 = ngaynhap43;
              _MaKe = MaKe;
		      _parent = parent ;
		      _maNhom = maNhom ;
		      _maPL = maPL ;
              _duongdung = duongdung;
              _matp = matp;
		      _maChungLoai = maChungLoai ;
		      _tenGoc = tenGoc;
		      _tenTC = tenTC ;
		      _tenTM = tenTM ;
		      _tenTM1 = tenTM1 ;
		      _tenTM2 = tenTM2 ;
		      _tenTA = tenTA ;
              _tendvt2 = tendvt2;
		      _thuocGoc = thuocGoc ;
		      _ngaydungtoida = ngaydungtoida ;
		      _maNSX = maNSX ;
		      _hamLuong = hamLuong ;
		      _maDVTHL = maDVTHL ;
		      _nguong = nguong ;
		      _maDVT = maDVT ;
		      _quydoi = quydoi ;
		      _MaKe2 = MaKegoc ;
		      _maDVT2 = maDVT2 ;
		      _apDungGoi = apDungGoi ;
		      _handung = handung ;
		      _lieudung = lieudung ;
		      _cachdung = cachdung ;
		      _gianhap = gianhap ;
		      _ngaynhap = ngaynhap ;
		      _gianhap1 = gianhap1  ;
		      _ngaynhap1 = ngaynhap1 ;
		      _gianhap2 = gianhap2  ;
		      _ngaynhap2 = ngaynhap2 ;
		      _donGiaTT = donGiaTT  ;
		      _donGiaTT1 = donGiaTT1 ;
		      _dongiaThuT = dongiaThuT  ;
		      _dongiaPhauT = dongiaPhauT ;
		      _dongiaCLS = dongiaCLS  ;
		      _giaQuay = giaQuay  ;
		      _giaQuay1 = giaQuay1 ;
		      _khoban = khoban ;
              _maql = maql;
		      _khophat = khophat  ;
		      _thuocThuT = thuocThuT  ;
		      _thuocPhauT = ThuocPhauT  ;
		      _thuocCLS = thuocCLS ;
		      _ThuocNoiT =  ThuocNoiT ;
		      _thuocDuoc = thuocDuoc  ;
		      _thuocBan = thuocBan  ;
		      _duyetNgoaiT = duyetNgoaiT  ;
		      _duyetNoiT = duyetNoiT ;
		      _ghichu = ghichu ;
		      _maMay = maMay  ;
		      _huy = huy ;
		      _ngaySD = ngaySD  ;
		      _nguoiSD = nguoiSD ;
		      _ngaySD1 = ngaySD1  ;
		      _nguoiSD1 = nguoiSD1  ;
		      _ngayLap = ngayLap ;
		      _nguoiLap = nguoiLap ;
		      _ngayHuy = ngayHuy  ;
		      _nguoiHuy = nguoiHuy ;
              _malh = malh;
              _tendvt = tendvt;
              _tendvthl = tendvthl;
              _tennguoiSD = tennguoisd;
              _tennguoiLap  = tennguoilap;
              _tennguoiHuy = tennguoihuy;
              _tenNSX = tennsx;
              _KhongSD = KhongSD;
                                 _quycach= quycach;
                                 _matk = matk;
                                 _sovisa= sovisa;
                                 _thuocban2= thuocban2;
                                 _thuocHoiChan = ThuocHoiChan;
                                 _thuocTieuHao = ThuocTieuHao;
                                 _giaQuay56 = giaQuay56;
                                 _giaQuay561 = giaQuay561;
                                 if (_maql == "")
  _maql = _MaKe;

        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _MaKe;
			public String MaKe 
			{
				get
				{
					return _MaKe;
				}
			}
			
			public Criteria(String MaKe)
			{
				_MaKe = MaKe;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_MaKe.Equals(c._MaKe)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _MaKe.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaKe;
            public String MaKe
            {
                get
                {
                    return _MaKe;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaKe)
            {
                _MaKe = MaKe;
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
		/// Retrieve an existing <see cref="DMThuoc_Ke" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMThuoc_Ke(String _MaKe);
			// public override IDataReader GetDMThuoc_Ke(String _MaKe)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaKe));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMThuoc_Ke(crit.MaKe)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMThuoc_Ke" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaKe") != null) _MaKe = dr.GetString("MaKe");
            if (dr.GetDecimal("Gianhap56") != null) _gianhap56 = dr.GetDecimal("Gianhap56");
            if (dr.GetSmartDate("Ngaynhap56", true) != null) _ngaynhap56 = dr.GetSmartDate("Ngaynhap56", true);

            if (dr.GetDecimal("Gianhap43") != null) _gianhap43 = dr.GetDecimal("Gianhap43");
            if (dr.GetSmartDate("Ngaynhap43", true) != null) _ngaynhap43 = dr.GetSmartDate("Ngaynhap43", true);
            if (dr.GetString("maql") != null) _maql = dr.GetString("maql");
			if (dr.GetString("Parent") != null) _parent = dr.GetString("Parent");
			if (dr.GetString("MaNhom") != null) _maNhom = dr.GetString("MaNhom");
			if (dr.GetString("MaPL") != null) _maPL = dr.GetString("MaPL");
			if (dr.GetString("MaChungLoai") != null) _maChungLoai = dr.GetString("MaChungLoai");
			if (dr.GetString("TenGoc") != null) _tenGoc = dr.GetString("TenGoc");
			if (dr.GetString("TenTC") != null) _tenTC = dr.GetString("TenTC");
			if (dr.GetString("TenTM") != null) _tenTM = dr.GetString("TenTM");
			if (dr.GetString("TenTM1") != null) _tenTM1 = dr.GetString("TenTM1");
			if (dr.GetString("TenTM2") != null) _tenTM2 = dr.GetString("TenTM2");
			if (dr.GetString("tenTA") != null) _tenTA = dr.GetString("tenTA");
			if (dr.GetBoolean("ThuocGoc") != null) _thuocGoc = dr.GetBoolean("ThuocGoc");
			if (dr.GetDecimal("Ngaydungtoida") != null) _ngaydungtoida = dr.GetDecimal("Ngaydungtoida");
			if (dr.GetString("MaNSX") != null) _maNSX = dr.GetString("MaNSX");
			if (dr.GetString("HamLuong") != null) _hamLuong = dr.GetString("HamLuong");
			if (dr.GetString("MaDVTHL") != null) _maDVTHL = dr.GetString("MaDVTHL");
			if (dr.GetDecimal("Nguong") != null) _nguong = dr.GetDecimal("Nguong");
			if (dr.GetString("MaDVT") != null) _maDVT = dr.GetString("MaDVT");
			if (dr.GetDecimal("Quydoi") != null) _quydoi = dr.GetDecimal("Quydoi");
            if (dr.GetString("MaKegoc") != null) _MaKe2 = dr.GetString("MaKegoc");
			if (dr.GetString("MaDVT2") != null) _maDVT2 = dr.GetString("MaDVT2");
			if (dr.GetBoolean("ApDungGoi") != null) _apDungGoi = dr.GetBoolean("ApDungGoi");
			if (dr.GetBoolean("Handung") != null) _handung = dr.GetBoolean("Handung");
			if (dr.GetString("Lieudung") != null) _lieudung = dr.GetString("Lieudung");
			if (dr.GetString("Cachdung") != null) _cachdung = dr.GetString("Cachdung");
			if (dr.GetDecimal("Gianhap") != null) _gianhap = dr.GetDecimal("Gianhap");
			if (dr.GetSmartDate("Ngaynhap", true) != null) _ngaynhap = dr.GetSmartDate("Ngaynhap", true);
			if (dr.GetDecimal("Gianhap1") != null) _gianhap1 = dr.GetDecimal("Gianhap1");
			if (dr.GetSmartDate("Ngaynhap1", true) != null) _ngaynhap1 = dr.GetSmartDate("Ngaynhap1", true);
			if (dr.GetDecimal("Gianhap2") != null) _gianhap2 = dr.GetDecimal("Gianhap2");
			if (dr.GetSmartDate("Ngaynhap2", true) != null) _ngaynhap2 = dr.GetSmartDate("Ngaynhap2", true);
			if (dr.GetDecimal("DonGiaTT") != null) _donGiaTT = dr.GetDecimal("DonGiaTT");
			if (dr.GetDecimal("DonGiaTT1") != null) _donGiaTT1 = dr.GetDecimal("DonGiaTT1");
			if (dr.GetDecimal("DongiaThuT") != null) _dongiaThuT = dr.GetDecimal("DongiaThuT");
			if (dr.GetDecimal("DongiaPhauT") != null) _dongiaPhauT = dr.GetDecimal("DongiaPhauT");
			if (dr.GetDecimal("DongiaCLS") != null) _dongiaCLS = dr.GetDecimal("DongiaCLS");
			if (dr.GetDecimal("GiaQuay") != null) _giaQuay = dr.GetDecimal("GiaQuay");
			if (dr.GetDecimal("GiaQuay1") != null) _giaQuay1 = dr.GetDecimal("GiaQuay1");
			if (dr.GetString("Khoban") != null) _khoban = dr.GetString("Khoban");
			if (dr.GetString("Khophat") != null) _khophat = dr.GetString("Khophat");
			if (dr.GetBoolean("ThuocThuT") != null) _thuocThuT = dr.GetBoolean("ThuocThuT");
			if (dr.GetBoolean("ThuocPhauT") != null) _thuocPhauT = dr.GetBoolean("ThuocPhauT");
			if (dr.GetBoolean("ThuocCLS") != null) _thuocCLS = dr.GetBoolean("ThuocCLS");
			if (dr.GetBoolean("ThuocNoiT") != null) _ThuocNoiT = dr.GetBoolean("ThuocNoiT");
			if (dr.GetBoolean("ThuocDuoc") != null) _thuocDuoc = dr.GetBoolean("ThuocDuoc");
			if (dr.GetBoolean("ThuocBan") != null) _thuocBan = dr.GetBoolean("ThuocBan");
			if (dr.GetBoolean("DuyetNgoaiT") != null) _duyetNgoaiT = dr.GetBoolean("DuyetNgoaiT");
			if (dr.GetBoolean("DuyetNoiT") != null) _duyetNoiT = dr.GetBoolean("DuyetNoiT");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
			if (dr.GetString("nguoiHuy") != null) _nguoiHuy = dr.GetString("nguoiHuy");
            if (dr.GetString("malh") != null) _malh = dr.GetString("malh");
            if (dr.GetString("duongdung") != null) _duongdung = dr.GetString("duongdung");
            if (dr.GetString("matp") != null) _matp = dr.GetString("matp");
            if (dr.GetString("tendvt") != null) _tendvt = dr.GetString("tendvt");
            if (dr.GetString("tendvt2") != null) _tendvt2 = dr.GetString("tendvt2");
            if (dr.GetString("tendvthl") != null) _tendvthl = dr.GetString("tendvthl");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenNguoiLap") != null) _tennguoiLap = dr.GetString("TenNguoiLap");
            if (dr.GetString("TenNguoiHuy") != null) _tennguoiHuy = dr.GetString("TenNguoiHuy");
            if (dr.GetString("quycach") != null) _quycach = dr.GetString("quycach");
            if (dr.GetString("matk") != null) _matk = dr.GetString("matk");
            if (dr.GetString("sovisa") != null) _sovisa = dr.GetString("sovisa");
            if (dr.GetBoolean("thuocban2") != null) _thuocban2 = dr.GetBoolean("thuocban2");
            if (dr.GetBoolean("ThuocHoiChan") != null) _thuocHoiChan  = dr.GetBoolean("ThuocHoiChan");
            if (dr.GetByte ("ThuocTieuHao") != null) _thuocTieuHao = dr.GetByte ("ThuocTieuHao");
            if (dr.GetBoolean("khongsd") != null) _KhongSD = dr.GetBoolean("khongsd");
            if (dr.GetDecimal("GiaQuay56") != null) _giaQuay56 = dr.GetDecimal("GiaQuay56");
            if (dr.GetDecimal("GiaQuay561") != null) _giaQuay561 = dr.GetDecimal("GiaQuay561");
            if (_maql == "")
                _maql = _MaKe;
		}
		
		/// <summary>
		/// Insert the new <see cref="DMThuoc_Ke" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_Ke
			// Copy & paste ham duoi day vao file DataProvider.cs
            
            
            _MaKe = DataProvider.Instance().InsertDMThuoc_Ke(_parent, _maNhom, _maPL, _maChungLoai, _tenGoc, _tenTC, _tenTM, _tenTM1, _tenTM2, _tenTA, _thuocGoc, _ngaydungtoida, _maNSX, _hamLuong, _maDVTHL, _nguong, _maDVT, _quydoi, _MaKe2, _maDVT2, _apDungGoi, _handung, _lieudung, _cachdung, _khoban, _khophat, _thuocThuT, _thuocPhauT, _thuocCLS, _ThuocNoiT, _thuocDuoc, _thuocBan, _duyetNgoaiT, _duyetNoiT, _ghichu, _maMay, _nguoiSD , _malh, _quycach, _matk, _sovisa, _thuocban2, _KhongSD, _maql, _thuocTieuHao, _matp, _duongdung, _gianhap, _gianhap43, _gianhap56);
			// public abstract String InsertDMThuoc_Ke(String _parent, String _maNhom, String _maPL, String _maChungLoai, String _tenGoc, String _tenTC, String _tenTM, String _tenTM1, String _tenTM2, String _tenTA, Boolean _thuocGoc, Decimal _ngaydungtoida, String _maNSX, String _hamLuong, String _maDVTHL, Decimal _nguong, String _maDVT, Decimal _quydoi, String _MaKe2, String _maDVT2, Boolean _apDungGoi, Boolean _handung, String _lieudung, String _cachdung, String _khoban, String _khophat, Boolean _thuocThuT, Boolean _thuocPhauT, Boolean _thuocCLS, Boolean _ThuocNoiT, Boolean _thuocDuoc, Boolean _thuocBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, String _nguoiSD);
			// public override String InsertDMThuoc_Ke(String _parent, String _maNhom, String _maPL, String _maChungLoai, String _tenGoc, String _tenTC, String _tenTM, String _tenTM1, String _tenTM2, String _tenTA, Boolean _thuocGoc, Decimal _ngaydungtoida, String _maNSX, String _hamLuong, String _maDVTHL, Decimal _nguong, String _maDVT, Decimal _quydoi, String _MaKe2, String _maDVT2, Boolean _apDungGoi, Boolean _handung, String _lieudung, String _cachdung, String _khoban, String _khophat, Boolean _thuocThuT, Boolean _thuocPhauT, Boolean _thuocCLS, Boolean _ThuocNoiT, Boolean _thuocDuoc, Boolean _thuocBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, String _nguoiSD);
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMThuoc_Ke_CREATE",  _parent, _maNhom, _maPL, _maChungLoai, _tenGoc, _tenTC, _tenTM, _tenTM1, _tenTM2, _tenTA, _thuocGoc, _ngaydungtoida, _maNSX, _hamLuong, _maDVTHL, _nguong, _maDVT, _quydoi, _MaKe2, _maDVT2, _apDungGoi, _handung, _lieudung, _cachdung, _khoban, _khophat, _thuocThuT, _thuocPhauT, _thuocCLS, _ThuocNoiT, _thuocDuoc, _thuocBan, _duyetNgoaiT, _duyetNoiT, _ghichu, _maMay, _nguoiSD), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMThuoc_Ke" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_Ke
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateDMThuoc_Ke(_MaKe, _parent, _maNhom, _maPL, _maChungLoai, _tenGoc, _tenTC, _tenTM, _tenTM1, _tenTM2, _tenTA, _thuocGoc, _ngaydungtoida, _maNSX, _hamLuong, _maDVTHL, _nguong, _maDVT, _quydoi, _MaKe2, _maDVT2, _apDungGoi, _handung, _lieudung, _cachdung, _khoban, _khophat, _thuocThuT, _thuocPhauT, _thuocCLS, _ThuocNoiT, _thuocDuoc, _thuocBan, _duyetNgoaiT, _duyetNoiT, _ghichu, _maMay, _huy, _nguoiSD , _malh, _quycach, _matk, _sovisa, _thuocban2, _KhongSD, _maql, _thuocTieuHao, _matp, _duongdung, _gianhap, _gianhap43, _gianhap56);
				// public abstract void UpdateDMThuoc_Ke(String _MaKe, String _parent, String _maNhom, String _maPL, String _maChungLoai, String _tenGoc, String _tenTC, String _tenTM, String _tenTM1, String _tenTM2, String _tenTA, Boolean _thuocGoc, Decimal _ngaydungtoida, String _maNSX, String _hamLuong, String _maDVTHL, Decimal _nguong, String _maDVT, Decimal _quydoi, String _MaKe2, String _maDVT2, Boolean _apDungGoi, Boolean _handung, String _lieudung, String _cachdung, String _khoban, String _khophat, Boolean _thuocThuT, Boolean _thuocPhauT, Boolean _thuocCLS, Boolean _ThuocNoiT, Boolean _thuocDuoc, Boolean _thuocBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateDMThuoc_Ke(String _MaKe, String _parent, String _maNhom, String _maPL, String _maChungLoai, String _tenGoc, String _tenTC, String _tenTM, String _tenTM1, String _tenTM2, String _tenTA, Boolean _thuocGoc, Decimal _ngaydungtoida, String _maNSX, String _hamLuong, String _maDVTHL, Decimal _nguong, String _maDVT, Decimal _quydoi, String _MaKe2, String _maDVT2, Boolean _apDungGoi, Boolean _handung, String _lieudung, String _cachdung, String _khoban, String _khophat, Boolean _thuocThuT, Boolean _thuocPhauT, Boolean _thuocCLS, Boolean _ThuocNoiT, Boolean _thuocDuoc, Boolean _thuocBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD);
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMThuoc_Ke_UPDATE", _MaKe, _parent, _maNhom, _maPL, _maChungLoai, _tenGoc, _tenTC, _tenTM, _tenTM1, _tenTM2, _tenTA, _thuocGoc, _ngaydungtoida, _maNSX, _hamLuong, _maDVTHL, _nguong, _maDVT, _quydoi, _MaKe2, _maDVT2, _apDungGoi, _handung, _lieudung, _cachdung, _gianhap, _ngaynhap.DBValue, _gianhap1, _ngaynhap1.DBValue, _gianhap2, _ngaynhap2.DBValue, _donGiaTT, _donGiaTT1, _dongiaThuT, _dongiaPhauT, _dongiaCLS, _giaQuay, _giaQuay1, _khoban, _khophat, _thuocThuT, _thuocPhauT, _thuocCLS, _ThuocNoiT, _thuocDuoc, _thuocBan, _duyetNgoaiT, _duyetNoiT, _ghichu, _maMay, _huy, _nguoiSD , );
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            //_nguoiHuy = HTC.ShareVariables.pub_sNguoiSD;
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _MaKe));
		}

		/// <summary>
		/// Delete the <see cref="DMThuoc_Ke" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_Ke
            DataProvider.Instance().DeleteDMThuoc_Ke(crit.MaMay, crit.NguoiSD, crit.MaKe);
			// public abstract void DeleteDMThuoc_Ke(String _MaKe);
			// public override void DeleteDMThuoc_Ke(String _MaKe);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMThuoc_Ke_DELETED", _MaKe);
			// }
		}

		#endregion
	}

}
