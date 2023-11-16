// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMHoaChat
// Kieu doi tuong  :	DMHoaChat
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	3/28/2009 10:43:45 AM
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
	/// This is a base generated class of <see cref="DMHoaChat" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMHoaChat : BusinessBase<DMHoaChat>
	{
		#region Business Methods
		
		#region State Fields
        private String _maql = String.Empty;
		private String _maHC = String.Empty;
		private String _maNhom = String.Empty;
        private String _maChungLoai = String.Empty;
		private String _tenTM = String.Empty;
        private String _tenTMHL = String.Empty;
		private String _tenTA = String.Empty;
		private String _maNSX = String.Empty;
		private String _hamLuong = String.Empty;
        private String _hamLuongD = String.Empty;
		private String _maDVTHL = String.Empty;
		private Decimal _nguong = 0;
		private String _maDVT = String.Empty;
		private Decimal _quydoi = 0;
        private String _maHCgoc = String.Empty;
		private String _maDVTGoc = String.Empty;
		private Boolean _apDungGoi = true;
        private Boolean _handung = true;
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
		private Boolean _hCThuT = false;
		private Boolean _hCPhauT = false;
		private Boolean _hCCLS = false;
		private Boolean _hCDuoc = false;
		private Boolean _hCBan = false;
		private Boolean _duyetNgoaiT = false;
		private Boolean _duyetNoiT = false;
		private String _ghichu = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngayHuy = new SmartDate(true);
		private String _nguoiHuy = String.Empty;
		private Boolean _hCNoiT = false;
		private String _maLH = String.Empty;
        private int _OrderNumber;
        private String _tendvt = String.Empty;
        private String _tendvthl = String.Empty;
        private String _tenNSX = String.Empty;
        private String _quycach = String.Empty;
        private String _tennguoiLap = String.Empty;
        private String _tennguoiSD = String.Empty;
        private String _tennguoiHuy = String.Empty;
        private Boolean _KhongSD =false;
        private Byte _sothanghd = 12;
        private Byte _loai = 0;
        private String _maBYTe = String.Empty;
        private String _TenTMBH = String.Empty;
        private String _QuyetDinh = String.Empty;
        private String _QuyetDinhBH = String.Empty;
       private String _MaBH = String.Empty;
        private string _MaTDuong = String.Empty;
        private String _TenBYTe = String.Empty;
        
		#endregion
		
		#region Business Properties and Methods
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
        public String TenTMDu
        {
            get
            {

                return _maHC + "-" + _tenTM;
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
        public String TenTMBH
        {
            get
            {
                CanReadProperty("TenTMBH", true);
                return _TenTMBH;
            }
            set
            {
                CanWriteProperty("TenTMBH", true);
                if (_TenTMBH != value)
                {
                    _TenTMBH = value;
                    PropertyHasChanged("TenTMBH");
                }
            }
        }
        public Byte sothanghd
        {
            get
            {
                CanReadProperty("sothanghd", true);
                return _sothanghd;
            }
            set
            {
                CanWriteProperty("sothanghd", true);
                if (_sothanghd != value)
                {
                    _sothanghd = value;
                    PropertyHasChanged("sothanghd");
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
        public String TenTMHL
        {
            get
            {
                CanReadProperty("TenTMHL", true);
                return _tenTM + " " +_maql +" " + _hamLuong + " " + _tendvthl + " " + _quycach + " " + _tenNSX ;
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
        public String HamLuongD
        {
            get
            {
                CanReadProperty("HamLuong", true);
                return _hamLuong + " " + _tendvthl;
            }

        }
		public String MaHC
		{
			get 
			{
				CanReadProperty("MaHC", true);
				return _maHC;
			}
			set 
			{
				CanWriteProperty("MaHC", true);
				if (_maHC != value) 
				{
					_maHC = value;
					PropertyHasChanged("MaHC");
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
		
		public String MaHCgoc
		{
			get 
			{
				CanReadProperty("MaHCgoc", true);
				return _maHCgoc;
			}
			set 
			{
				CanWriteProperty("MaHCgoc", true);
				if (_maHCgoc != value) 
				{
					_maHCgoc = value;
					PropertyHasChanged("MaHCgoc");
				}
			}
		}
		
		public String MaDVTGoc
		{
			get 
			{
				CanReadProperty("MaDVTGoc", true);
				return _maDVTGoc;
			}
			set 
			{
				CanWriteProperty("MaDVTGoc", true);
				if (_maDVTGoc != value) 
				{
					_maDVTGoc = value;
					PropertyHasChanged("MaDVTGoc");
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
		
		public Boolean HCThuT
		{
			get 
			{
				CanReadProperty("HCThuT", true);
				return _hCThuT;
			}
			set 
			{
				CanWriteProperty("HCThuT", true);
				if (_hCThuT != value) 
				{
					_hCThuT = value;
					PropertyHasChanged("HCThuT");
				}
			}
		}
		
		public Boolean HCPhauT
		{
			get 
			{
				CanReadProperty("HCPhauT", true);
				return _hCPhauT;
			}
			set 
			{
				CanWriteProperty("HCPhauT", true);
				if (_hCPhauT != value) 
				{
					_hCPhauT = value;
					PropertyHasChanged("HCPhauT");
				}
			}
		}
		
		public Boolean HCCLS
		{
			get 
			{
				CanReadProperty("HCCLS", true);
				return _hCCLS;
			}
			set 
			{
				CanWriteProperty("HCCLS", true);
				if (_hCCLS != value) 
				{
					_hCCLS = value;
					PropertyHasChanged("HCCLS");
				}
			}
		}
		
		public Boolean HCDuoc
		{
			get 
			{
				CanReadProperty("HCDuoc", true);
				return _hCDuoc;
			}
			set 
			{
				CanWriteProperty("HCDuoc", true);
				if (_hCDuoc != value) 
				{
					_hCDuoc = value;
					PropertyHasChanged("HCDuoc");
				}
			}
		}
		
		public Boolean HCBan
		{
			get 
			{
				CanReadProperty("HCBan", true);
				return _hCBan;
			}
			set 
			{
				CanWriteProperty("HCBan", true);
				if (_hCBan != value) 
				{
					_hCBan = value;
					PropertyHasChanged("HCBan");
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
		
		public Boolean HCNoiT
		{
			get 
			{
				CanReadProperty("HCNoiT", true);
				return _hCNoiT;
			}
			set 
			{
				CanWriteProperty("HCNoiT", true);
				if (_hCNoiT != value) 
				{
					_hCNoiT = value;
					PropertyHasChanged("HCNoiT");
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
			return _maHC;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenTM", 350));
            ValidationRules.AddRule<DMHoaChat>(StringRequired<DMHoaChat>, "TenTM");
            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenTM", 350));
            ValidationRules.AddRule<DMHoaChat>(StringRequiredDVT<DMHoaChat>, "MaDVT");

        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMHoaChat
        {

            if (target._tenTM == null || target._tenTM.Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }

        private static bool StringRequiredDVT<T>(T target, Csla.Validation.RuleArgs e) where T : DMHoaChat
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
		/// Factory method. New <see cref="DMHoaChat" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMHoaChat NewDMHoaChat()
        {
            return DataPortal.Create<DMHoaChat>();
        }
		public static DMHoaChat GetDMHoaChat(String maHC)
		{
			return DataPortal.Fetch<DMHoaChat>(new Criteria(maHC));
		}
		
		/// <summary>
		/// Marks the <see cref="DMHoaChat" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMHoaChat(String maHC, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maHC));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMHoaChat()
		{	
			// Prevent direct creation
		}
        internal DMHoaChat(  int OrderNumber,
             String maHC ,
		 String maNhom ,
         String maChungLoai,
		 String tenTM ,
		 String tenTA ,
		 String maNSX ,
		 String hamLuong ,
		 String maDVTHL ,
		 Decimal nguong ,
		 String maDVT ,
		 Decimal quydoi ,
		 String maHCgoc ,
		 String maDHCGoc ,
		 Boolean apDungGoi ,
		 Boolean handung ,
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
		 Decimal giaQuay,
		 Decimal giaQuay1 ,
		 String khoban ,
		 String khophat ,
		 Boolean hCThuT ,
		 Boolean hCPhauT ,
		 Boolean hCCLS ,
		 Boolean hCDuoc ,
		 Boolean hCBan ,
		 Boolean duyetNgoaiT ,
		 Boolean duyetNoiT ,
		 String ghichu ,
		 String maMay ,
		 Boolean huy ,
		 SmartDate ngaySD ,
		 String nguoiSD,
		 SmartDate ngaySD1 ,
		 String nguoiSD1 ,
		 SmartDate ngayLap ,
		 String nguoiLap ,
		 SmartDate ngayHuy ,
		 String nguoiHuy ,
		 Boolean hCNoiT ,
		 String maLH ,
         String tendvt,
         string tendvthl,
         string tennguoisd,
         string tennguoilap,
         string tennguoihuy,
            string tennsx,
             string quycach,
            Boolean KhongSD,
            byte sothanghd, String maBYTe,
             String quyetdinh,
            String tentmbh,
            String maBh,String matduong,
             String quyetdinhbh,
            String tenbyte ,string maql

            )
        {
            _maql = maql;
             _MaBH = maBh; _MaTDuong = matduong;
            _TenBYTe = tenbyte;
            _QuyetDinhBH = quyetdinhbh;
            _maBYTe = maBYTe;
            _QuyetDinh = quyetdinh;
            _TenTMBH = tentmbh;
            _OrderNumber = OrderNumber;
            _sothanghd = sothanghd;
            _maHC = maHC;
            _maNhom = maNhom;
            _maChungLoai = maChungLoai;
            _tenTM = tenTM;
            _tenTA = tenTA;
            _maNSX = maNSX;
		  _hamLuong = hamLuong ;
		  _maDVTHL= maDVTHL;
		  _nguong= nguong;
		  _maDVT= maDVT;
		  _quydoi= quydoi;
		  _maHCgoc= maHCgoc;
		  _maDVTGoc= maDHCGoc;
		  _apDungGoi =apDungGoi;
		  _handung =handung;
		  _gianhap =gianhap;
		  _ngaynhap =ngaynhap;
		  _gianhap1 =gianhap1;
		  _ngaynhap1 =ngaynhap1;
		  _gianhap2 =gianhap2;
		  _ngaynhap2 =ngaynhap2;
		  _donGiaTT =donGiaTT;
		  _donGiaTT1 =donGiaTT1;
		  _dongiaThuT =dongiaThuT;
		  _dongiaPhauT =dongiaPhauT;
		  _dongiaCLS =dongiaCLS;
		  _giaQuay=giaQuay;
		  _giaQuay1 =giaQuay1;
		  _khoban =khoban;
		  _khophat =khophat;
		  _hCThuT =hCThuT;
		  _hCPhauT =hCPhauT;
		  _hCCLS =hCCLS;
		  _hCDuoc =hCDuoc;
		  _hCBan =hCBan;
		  _duyetNgoaiT =duyetNgoaiT;
		  _duyetNoiT =duyetNoiT;
		  _ghichu =ghichu;
		  _maMay =maMay;
		  _huy =huy;
		  _ngaySD =ngaySD;
		  _nguoiSD =nguoiSD;
		  _ngaySD1 =ngaySD1;
		  _nguoiSD1 =nguoiSD1;
		  _ngayLap =ngayLap;
		  _nguoiLap= nguoiLap;
		  _ngayHuy =ngayHuy;
		  _nguoiHuy= nguoiHuy;
		  _hCNoiT =hCNoiT;
          _maLH = maLH;
          _tendvt = tendvt;
          _tendvthl = tendvthl;
          _tennguoiSD = tennguoisd;
          _tennguoiLap = tennguoilap;
          _tennguoiHuy = tennguoihuy;
          _tenNSX = tennsx;
          _KhongSD = KhongSD;
          _quycach = quycach;
         
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maHC;
			public String MaHC 
			{
				get
				{
					return _maHC;
				}
			}
			
			public Criteria(String maHC)
			{
				_maHC = maHC;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maHC.Equals(c._maHC)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maHC.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maHC;
            public String MaHC
            {
                get
                {
                    return _maHC;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maHC)
            {
                _maHC = maHC;
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
		/// Retrieve an existing <see cref="DMHoaChat" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMHoaChat(String _maHC);
			// public override IDataReader GetDMHoaChat(String _maHC)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maHC));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMHoaChat(crit.MaHC)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMHoaChat" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
            if (dr.GetString("MaBYTe") != null) _maBYTe = dr.GetString("MaBYTe");
            if (dr.GetString("QuyetDinh") != null) _QuyetDinh = dr.GetString("QuyetDinh");
            if (dr.GetString("TenTMBH") != null) _TenTMBH = dr.GetString("TenTMBH");
			if (dr.GetString("MaHC") != null) _maHC = dr.GetString("MaHC");
			if (dr.GetString("MaNhom") != null) _maNhom = dr.GetString("MaNhom");
			if (dr.GetString("MaChungLoai") != null) _maChungLoai = dr.GetString("MaChungLoai");
            if (dr.GetByte("sothanghd") != null) _sothanghd = dr.GetByte("sothanghd");
			if (dr.GetString("TenTM") != null) _tenTM = dr.GetString("TenTM");
			if (dr.GetString("tenTA") != null) _tenTA = dr.GetString("tenTA");
			if (dr.GetString("MaNSX") != null) _maNSX = dr.GetString("MaNSX");
            if (dr.GetString("tenNSX") != null) _tenNSX = dr.GetString("tenNSX");
            if (dr.GetString("maql") != null) _maql = dr.GetString("maql");
			if (dr.GetString("HamLuong") != null) _hamLuong = dr.GetString("HamLuong");
			if (dr.GetString("MaDVTHL") != null) _maDVTHL = dr.GetString("MaDVTHL");
			if (dr.GetDecimal("Nguong") != null) _nguong = dr.GetDecimal("Nguong");
			if (dr.GetString("MaDVT") != null) _maDVT = dr.GetString("MaDVT");
			if (dr.GetDecimal("Quydoi") != null) _quydoi = dr.GetDecimal("Quydoi");
			if (dr.GetString("MaHCgoc") != null) _maHCgoc = dr.GetString("MaHCgoc");
            if (dr.GetString("MaDVTGoc") != null) _maDVTGoc = dr.GetString("MaDVTGoc");
			if (dr.GetBoolean("ApDungGoi") != null) _apDungGoi = dr.GetBoolean("ApDungGoi");
			if (dr.GetBoolean("Handung") != null) _handung = dr.GetBoolean("Handung");
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
			if (dr.GetBoolean("HCThuT") != null) _hCThuT = dr.GetBoolean("HCThuT");
			if (dr.GetBoolean("HCPhauT") != null) _hCPhauT = dr.GetBoolean("HCPhauT");
			if (dr.GetBoolean("HCCLS") != null) _hCCLS = dr.GetBoolean("HCCLS");
			if (dr.GetBoolean("HCDuoc") != null) _hCDuoc = dr.GetBoolean("HCDuoc");
			if (dr.GetBoolean("HCBan") != null) _hCBan = dr.GetBoolean("HCBan");
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
			if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
			if (dr.GetBoolean("HCNoiT") != null) _hCNoiT = dr.GetBoolean("HCNoiT");
			if (dr.GetString("MaLH") != null) _maLH = dr.GetString("MaLH");
            if (dr.GetString("tendvt") != null) _tendvt = dr.GetString("tendvt");
            if (dr.GetString("tendvthl") != null) _tendvthl = dr.GetString("tendvthl");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenNguoiLap") != null) _tennguoiLap = dr.GetString("TenNguoiLap");
            if (dr.GetString("TenNguoiHuy") != null) _tennguoiHuy = dr.GetString("TenNguoiHuy");
            if (dr.GetString("quycach") != null) _quycach = dr.GetString("quycach");
            if (dr.GetBoolean("KhongSD") != null) _KhongSD = dr.GetBoolean("KhongSD");
            
		}
		
		/// <summary>
		/// Insert the new <see cref="DMHoaChat" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMHoaChat
			// Copy & paste ham duoi day vao file DataProvider.cs


            _maHC = DataProvider.Instance().InsertDMHoaChat(_maNhom, _maChungLoai, _tenTM, _tenTA, _maNSX, _hamLuong, _maDVTHL, _nguong, _maDVT, _quydoi, _maHCgoc, _maDVTGoc, _apDungGoi, _handung, _khoban, _khophat, _hCThuT, _hCPhauT, _hCCLS, _hCDuoc, _hCBan, _duyetNgoaiT, _duyetNoiT, _ghichu, _maMay, _nguoiSD, _hCNoiT, _maLH, _quycach, _KhongSD, _sothanghd, _loai, _maBYTe, _QuyetDinh, _TenTMBH,_MaBH,_MaTDuong,_QuyetDinhBH,_TenBYTe ,  _maql);
			// public abstract String InsertDMHoaChat(String _maNhom, String _maChungLoai, String _tenTM, String _tenTA, String _maNSX, String _hamLuong, String _maDVTHL, Decimal _nguong, String _maDVT, Decimal _quydoi, String _maHCgoc, String _maDHCGoc, Boolean _apDungGoi, Boolean _handung, Decimal _gianhap, SmartDate _ngaynhap, Decimal _gianhap1, SmartDate _ngaynhap1, Decimal _gianhap2, SmartDate _ngaynhap2, Decimal _donGiaTT, Decimal _donGiaTT1, Decimal _dongiaThuT, Decimal _dongiaPhauT, Decimal _dongiaCLS, Decimal _giaQuay, Decimal _giaQuay1, String _khoban, String _khophat, Boolean _hCThuT, Boolean _hCPhauT, Boolean _hCCLS, Boolean _hCDuoc, Boolean _hCBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, Boolean _huy, SmartDate _ngaySD, String _nguoiSD, SmartDate _ngaySD1, String _nguoiSD1, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngayHuy, String _nguoiHuy, Boolean _hCNoiT, String _maLH);
			// public override String InsertDMHoaChat(String _maNhom, String _maChungLoai, String _tenTM, String _tenTA, String _maNSX, String _hamLuong, String _maDVTHL, Decimal _nguong, String _maDVT, Decimal _quydoi, String _maHCgoc, String _maDHCGoc, Boolean _apDungGoi, Boolean _handung, Decimal _gianhap, SmartDate _ngaynhap, Decimal _gianhap1, SmartDate _ngaynhap1, Decimal _gianhap2, SmartDate _ngaynhap2, Decimal _donGiaTT, Decimal _donGiaTT1, Decimal _dongiaThuT, Decimal _dongiaPhauT, Decimal _dongiaCLS, Decimal _giaQuay, Decimal _giaQuay1, String _khoban, String _khophat, Boolean _hCThuT, Boolean _hCPhauT, Boolean _hCCLS, Boolean _hCDuoc, Boolean _hCBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, Boolean _huy, SmartDate _ngaySD, String _nguoiSD, SmartDate _ngaySD1, String _nguoiSD1, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngayHuy, String _nguoiHuy, Boolean _hCNoiT, String _maLH)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMHOACHAT_CREATE",_maNhom, _maChungLoai, _tenTM, _tenTA, _maNSX, _hamLuong, _maDVTHL, _nguong, _maDVT, _quydoi, _maHCgoc, _maDHCGoc, _apDungGoi, _handung, _khoban, _khophat, _hCThuT, _hCPhauT, _hCCLS, _hCDuoc, _hCBan, _duyetNgoaiT, _duyetNoiT, _ghichu, _maMay, _nguoiSD , _hCNoiT, _maLH));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMHoaChat" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMHoaChat
			if (IsDirty){


                DataProvider.Instance().UpdateDMHoaChat(_maHC, _maNhom, _maChungLoai, _tenTM, _tenTA, _maNSX, _hamLuong, _maDVTHL, _nguong, _maDVT, _quydoi, _maHCgoc, _maDVTGoc, _apDungGoi, _handung, _khoban, _khophat, _hCThuT, _hCPhauT, _hCCLS, _hCDuoc, _hCBan, _duyetNgoaiT, _duyetNoiT, _ghichu, _maMay, _huy, _nguoiSD, _hCNoiT, _maLH, _quycach, _KhongSD, _sothanghd, _maBYTe, _QuyetDinh, _TenTMBH, MaBH, _MaTDuong, _QuyetDinhBH, _TenBYTe, _maql);
				// public abstract void UpdateDMHoaChat(String _maHC, String _maNhom, String _maChungLoai, String _tenTM, String _tenTA, String _maNSX, String _hamLuong, String _maDVTHL, Decimal _nguong, String _maDVT, Decimal _quydoi, String _maHCgoc, String _maDHCGoc, Boolean _apDungGoi, Boolean _handung, String _khoban, String _khophat, Boolean _hCThuT, Boolean _hCPhauT, Boolean _hCCLS, Boolean _hCDuoc, Boolean _hCBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD, Boolean _hCNoiT, String _maLH);
				// public override void UpdateDMHoaChat(String _maHC, String _maNhom, String _maChungLoai, String _tenTM, String _tenTA, String _maNSX, String _hamLuong, String _maDVTHL, Decimal _nguong, String _maDVT, Decimal _quydoi, String _maHCgoc, String _maDHCGoc, Boolean _apDungGoi, Boolean _handung, String _khoban, String _khophat, Boolean _hCThuT, Boolean _hCPhauT, Boolean _hCCLS, Boolean _hCDuoc, Boolean _hCBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD, Boolean _hCNoiT, String _maLH)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMHOACHAT_UPDATE", _maHC, _maNhom, _maChungLoai, _tenTM, _tenTA, _maNSX, _hamLuong, _maDVTHL, _nguong, _maDVT, _quydoi, _maHCgoc, _maDHCGoc, _apDungGoi, _handung, _khoban, _khophat, _hCThuT, _hCPhauT, _hCCLS, _hCDuoc, _hCBan, _duyetNgoaiT, _duyetNoiT, _ghichu, _maMay, _huy, _nguoiSD , _hCNoiT, _maLH);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maHC));
		}

		/// <summary>
		/// Delete the <see cref="DMHoaChat" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMHoaChat
            DataProvider.Instance().DeleteDMHoaChat(crit.MaMay, crit.NguoiSD, crit.MaHC);
			// public abstract void DeleteDMHoaChat(String _maHC);
			// public override void DeleteDMHoaChat(String _maHC);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMHOACHAT_DELETED", _maHC);
			// }
		}

		#endregion
	}

}
