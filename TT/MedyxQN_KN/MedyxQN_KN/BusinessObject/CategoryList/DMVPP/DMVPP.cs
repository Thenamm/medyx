// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMVTYT
// Kieu doi tuong  :	DMVTYT
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	3/26/2009 9:22:44 AM
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
	/// This is a base generated class of <see cref="DMVTYT" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMVPP : BusinessBase<DMVPP>
	{
		#region Business Methods
		
		#region State Fields
        private String _maql = String.Empty;
		private String _maVT = String.Empty;
		private String _maNhom = String.Empty;
        private String _maChungLoai = String.Empty;
		private String _tenTM = String.Empty;
        private String _tenTMHL = String.Empty;
		private String _tenTA = String.Empty;
		private String _maNSX = String.Empty;
		private Decimal _nguong = 0;
        private String _maDVT2 = String.Empty;
        private Decimal _quydoi = 0;
        private String _hamLuong = String.Empty;
        private String _hamLuongD = String.Empty;
        private String _maDVTHL = String.Empty;
        private String _tendvthl = String.Empty;
		private String _maDVT = String.Empty;
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
		private Boolean _vTThuT = false;
		private Boolean _vTPhauT = false;
		private Boolean _vTCLS = false;
		private Boolean _vTDuoc = false;
		private Boolean _vTBan = false;
        private Boolean _duyetNgoaiT = true;
        private Boolean _duyetNoiT = true;
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
		private Boolean _vTNoiT = false;
		private String _maLH = String.Empty;
        private int _OrderNumber;
        private String _tendvt = String.Empty;
        private String _tennguoiLap = String.Empty;
        private String _tennguoiSD = String.Empty;
        private String _tennguoiHuy = String.Empty;
        private String _tenNSX = String.Empty;
        private Boolean _KhongSD =false;
        private String _quycach = String.Empty;

		#endregion
		
		#region Business Properties and Methods

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
		public String MaVT
		{
			get 
			{
				CanReadProperty("MaVT", true);
				return _maVT;
			}
			set 
			{
				CanWriteProperty("MaVT", true);
				if (_maVT != value) 
				{
					_maVT = value;
					PropertyHasChanged("MaVT");
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
                return _hamLuong + " " + _tendvthl;
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
		
		public Boolean VTThuT
		{
			get 
			{
				CanReadProperty("VTThuT", true);
				return _vTThuT;
			}
			set 
			{
				CanWriteProperty("VTThuT", true);
				if (_vTThuT != value) 
				{
					_vTThuT = value;
					PropertyHasChanged("VTThuT");
				}
			}
		}
		
		public Boolean VTPhauT
		{
			get 
			{
				CanReadProperty("VTPhauT", true);
				return _vTPhauT;
			}
			set 
			{
				CanWriteProperty("VTPhauT", true);
				if (_vTPhauT != value) 
				{
					_vTPhauT = value;
					PropertyHasChanged("VTPhauT");
				}
			}
		}
		
		public Boolean VTCLS
		{
			get 
			{
				CanReadProperty("VTCLS", true);
				return _vTCLS;
			}
			set 
			{
				CanWriteProperty("VTCLS", true);
				if (_vTCLS != value) 
				{
					_vTCLS = value;
					PropertyHasChanged("VTCLS");
				}
			}
		}
		
		public Boolean VTDuoc
		{
			get 
			{
				CanReadProperty("VTDuoc", true);
				return _vTDuoc;
			}
			set 
			{
				CanWriteProperty("VTDuoc", true);
				if (_vTDuoc != value) 
				{
					_vTDuoc = value;
					PropertyHasChanged("VTDuoc");
				}
			}
		}
		
		public Boolean VTBan
		{
			get 
			{
				CanReadProperty("VTBan", true);
				return _vTBan;
			}
			set 
			{
				CanWriteProperty("VTBan", true);
				if (_vTBan != value) 
				{
					_vTBan = value;
					PropertyHasChanged("VTBan");
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
		
		public Boolean VTNoiT
		{
			get 
			{
				CanReadProperty("VTNoiT", true);
				return _vTNoiT;
			}
			set 
			{
				CanWriteProperty("VTNoiT", true);
				if (_vTNoiT != value) 
				{
					_vTNoiT = value;
					PropertyHasChanged("VTNoiT");
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
			return _maVT;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenTM", 350));
            ValidationRules.AddRule<DMVPP>(StringRequired<DMVPP>, "TenTM");
            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenTM", 350));
            ValidationRules.AddRule<DMVPP>(StringRequiredDVT<DMVPP>, "MaDVT");

        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMVPP
        {

            if (target._tenTM == null || target._tenTM.Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }

        private static bool StringRequiredDVT<T>(T target, Csla.Validation.RuleArgs e) where T : DMVPP
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
		/// Factory method. New <see cref="DMVPP" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMVPP NewDMVPP()
        {
            return DataPortal.Create<DMVPP>();
        }
		public static DMVPP GetDMVPP(String maVT)
		{
			return DataPortal.Fetch<DMVPP>(new Criteria(maVT));
		}
		
		/// <summary>
		/// Marks the <see cref="DMVPP" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMVPP(String maVT, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maVT));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMVPP()
		{	
			// Prevent direct creation
		}
        internal DMVPP(int OrderNumber,
                             String maVT ,
		                     String maNhom ,
                             String maChungLoai,
		                     String tenTM ,
		                     String tenTA ,
		                     String maNSX ,
		                     Decimal nguong ,
		                     String maDVT ,
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
		                     Decimal giaQuay ,
		                     Decimal giaQuay1 ,
		                     String khoban ,
		                     String khophat ,
		                     Boolean vTThuT ,
		                     Boolean vTPhauT ,
		                     Boolean vTCLS ,
		                     Boolean vTDuoc ,
		                     Boolean vTBan ,
		                     Boolean duyetNgoaiT ,
		                     Boolean duyetNoiT ,
		                     String ghichu ,
		                     String maMay ,
		                     Boolean huy ,
		                     SmartDate ngaySD ,
		                     String nguoiSD ,
		                     SmartDate ngaySD1 ,
		                     String nguoiSD1 ,
		                     SmartDate ngayLap ,
		                     String nguoiLap ,
		                     SmartDate ngayHuy ,
		                     String nguoiHuy ,
		                     Boolean vTNoiT ,
		                     String maLH ,
                             string tendvt,
                             String hamLuong ,
		                     String maDVTHL ,
                             string tendvthl,
                             string tennguoisd,
                             string tennguoilap,
                             string tennguoihuy,
                             string tennsx,
            Boolean KhongSD,
                                 string maql,
                                string quycach, String maDVT2, Decimal quydoi 
         
            )
        {
                              _OrderNumber = OrderNumber;
                              _maVT = maVT ;
                              _quydoi = quydoi;
                              _maDVT2 = maDVT2;
                              _quycach = quycach;
		                      _maNhom = maNhom  ;
		                      _maChungLoai = maChungLoai  ;
		                      _tenTM = tenTM  ;
		                      _tenTA = tenTA  ;
		                      _maNSX = maNSX  ;
		                      _nguong = nguong  ;
		                      _maDVT = maDVT  ;
		                      _apDungGoi = apDungGoi  ;
		                      _handung = handung  ;
		                      _gianhap = gianhap  ;
		                      _ngaynhap = ngaynhap  ;
		                      _gianhap1 = gianhap1 ;
		                      _ngaynhap1 = ngaynhap1  ;
		                      _gianhap2 = gianhap2   ;
		                      _ngaynhap2 = ngaynhap2  ;
		                      _donGiaTT = donGiaTT  ;
		                      _donGiaTT1  = donGiaTT1  ;
		                      _dongiaThuT = dongiaThuT  ;
		                      _dongiaPhauT = dongiaPhauT  ;
		                      _dongiaCLS = dongiaCLS  ;
                              _maql = maql;
		                      _giaQuay = giaQuay  ;
		                      _giaQuay1 = giaQuay1  ;
		                      _khoban = khoban  ;
		                      _khophat = khophat  ;
		                      _vTThuT = vTThuT  ;
		                      _vTPhauT = vTPhauT  ;
		                      _vTCLS = vTCLS  ;
		                      _vTDuoc = vTDuoc  ;
		                      _vTBan = vTBan  ;
		                      _duyetNgoaiT = duyetNgoaiT  ;
		                      _duyetNoiT = duyetNoiT  ;
		                      _ghichu = ghichu  ;
		                      _maMay = maMay  ;
		                      _huy = huy  ;
		                      _ngaySD = ngaySD  ;
		                      _nguoiSD = nguoiSD  ;
		                      _ngaySD1 = ngaySD1  ;
		                      _nguoiSD1 = nguoiSD1  ;
		                      _ngayLap = ngayLap  ;
		                      _nguoiLap = nguoiLap  ;
		                      _ngayHuy = ngayHuy  ;
		                      _nguoiHuy = nguoiHuy  ;
                              _vTNoiT = vTNoiT ;
		                      _maLH = maLH  ;
                              _tendvt = tendvt;
                              _hamLuong = hamLuong;
                              _maDVTHL = maDVTHL;
                              _tendvthl = tendvthl;
                              _tennguoiSD = tennguoisd;
                              _tennguoiLap = tennguoilap;
                              _tennguoiHuy = tennguoihuy;
                              _tenNSX = tennsx;
                              _KhongSD = KhongSD;
                              if (_maql == "")
                                  _maql = _maVT;

        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maVT;
			public String MaVT 
			{
				get
				{
					return _maVT;
				}
			}
			
			public Criteria(String maVT)
			{
				_maVT = maVT;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maVT.Equals(c._maVT)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maVT.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maVT;
            public String maVT
            {
                get
                {
                    return _maVT;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maVTYT)
            {
                _maVT = maVTYT;
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
		/// Retrieve an existing <see cref="DMVTYT" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMVTYT(String _maVT);
			// public override IDataReader GetDMVTYT(String _maVT)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maVT));
			// }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMVPP(crit.MaVT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMVTYT" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaVT") != null) _maVT = dr.GetString("MaVT");
            if (dr.GetString("maql") != null) _maql = dr.GetString("maql");
            if (_maql == "")
                _maql = _maVT;
			if (dr.GetString("MaNhom") != null) _maNhom = dr.GetString("MaNhom");
			if (dr.GetString("MaChungLoai") != null) _maChungLoai = dr.GetString("MaChungLoai");
			if (dr.GetString("TenTM") != null) _tenTM = dr.GetString("TenTM");
			if (dr.GetString("tenTA") != null) _tenTA = dr.GetString("tenTA");
			if (dr.GetString("MaNSX") != null) _maNSX = dr.GetString("MaNSX");
			if (dr.GetDecimal("Nguong") != null) _nguong = dr.GetDecimal("Nguong");
			if (dr.GetString("MaDVT") != null) _maDVT = dr.GetString("MaDVT");
            if (dr.GetString("HamLuong") != null) _hamLuong = dr.GetString("HamLuong");
            if (dr.GetString("MaDVTHL") != null) _maDVTHL = dr.GetString("MaDVTHL");
            if (dr.GetString("tendvthl") != null) _tendvthl = dr.GetString("tendvthl");
			if (dr.GetBoolean("ApDungGoi") != null) _apDungGoi = dr.GetBoolean("ApDungGoi");
            if (dr.GetString("quycach") != null) _quycach = dr.GetString("quycach");
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
            if (dr.GetDecimal("Quydoi") != null) _quydoi = dr.GetDecimal("Quydoi");
            if (dr.GetString("MaDVT2") != null) _maDVT2 = dr.GetString("MaDVT2");
			if (dr.GetBoolean("VTThuT") != null) _vTThuT = dr.GetBoolean("VTThuT");
			if (dr.GetBoolean("VTPhauT") != null) _vTPhauT = dr.GetBoolean("VTPhauT");
			if (dr.GetBoolean("VTCLS") != null) _vTCLS = dr.GetBoolean("VTCLS");
			if (dr.GetBoolean("VTDuoc") != null) _vTDuoc = dr.GetBoolean("VTDuoc");
			if (dr.GetBoolean("VTBan") != null) _vTBan = dr.GetBoolean("VTBan");
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
			if (dr.GetBoolean("VTNoiT") != null) _vTNoiT = dr.GetBoolean("VTNoiT");
			if (dr.GetString("MaLH") != null) _maLH = dr.GetString("MaLH");
            if (dr.GetString("tendvt") != null) _tendvt = dr.GetString("tendvt");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenNguoiLap") != null) _tennguoiLap = dr.GetString("TenNguoiLap");
            if (dr.GetString("TenNguoiHuy") != null) _tennguoiHuy = dr.GetString("TenNguoiHuy");
            if (dr.GetBoolean("KhongSD") != null) _KhongSD = dr.GetBoolean("KhongSD");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMVTYT" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMVTYT
			// Copy & paste ham duoi day vao file DataProvider.cs
            
            
            _maVT = DataProvider.Instance().InsertDMVPP(_maNhom, _maChungLoai, _tenTM, _tenTA, _maNSX, _nguong, _maDVT, _apDungGoi, _handung, _khoban, _khophat, _vTThuT, _vTPhauT, _vTCLS, _vTDuoc, _vTBan, _duyetNgoaiT, _duyetNoiT, _ghichu, _maMay, _nguoiSD , _vTNoiT, _maLH, _hamLuong, _maDVTHL, _KhongSD, _maql, _quycach, _maDVT2, _quydoi);
            // public abstract String InsertDMVTYT(String _maNhom, String _maChungLoai, String _tenTM, String _tenTA, String _maNSX, Decimal _nguong, String _maDVT, Boolean _apDungGoi, Boolean _handung, String _khoban, String _khophat, Boolean _vTThuT, Boolean _vTPhauT, Boolean _vTCLS, Boolean _vTDuoc, Boolean _vTBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, String _nguoiLap, Boolean _vTNoiT, String _maLH);
            // public override String InsertDMVTYT(String _maNhom, String _maChungLoai, String _tenTM, String _tenTA, String _maNSX, Decimal _nguong, String _maDVT, Boolean _apDungGoi, Boolean _handung, String _khoban, String _khophat, Boolean _vTThuT, Boolean _vTPhauT, Boolean _vTCLS, Boolean _vTDuoc, Boolean _vTBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, String _nguoiLap, Boolean _vTNoiT, String _maLH)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMVTYT_CREATE", _maNhom, _maChungLoai, _tenTM, _tenTA, _maNSX, _nguong, _maDVT, _apDungGoi, _handung, _khoban, _khophat, _vTThuT, _vTPhauT, _vTCLS, _vTDuoc, _vTBan, _duyetNgoaiT, _duyetNoiT, _ghichu, _maMay, _nguoiSD , _vTNoiT, _maLH));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="DMVTYT" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMVTYT
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateDMVPP(_maVT, _maNhom, _maChungLoai, _tenTM, _tenTA, _maNSX, _nguong, _maDVT, _apDungGoi, _handung, _khoban, _khophat, _vTThuT, _vTPhauT, _vTCLS, _vTDuoc, _vTBan, _duyetNgoaiT, _duyetNoiT, _ghichu, _maMay, _huy, _nguoiSD , _vTNoiT, _maLH, _hamLuong, _maDVTHL, _KhongSD, _maql, _quycach, _maDVT2, _quydoi);
				// public abstract void UpdateDMVTYT(String _maVT, String _maNhom, String _maChungLoai, String _tenTM, String _tenTA, String _maNSX, Decimal _nguong, String _maDVT, Boolean _apDungGoi, Boolean _handung, String _khoban, String _khophat, Boolean _vTThuT, Boolean _vTPhauT, Boolean _vTCLS, Boolean _vTDuoc, Boolean _vTBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD, Boolean _vTNoiT, String _maLH);
				// public override void UpdateDMVTYT(String _maVT, String _maNhom, String _maChungLoai, String _tenTM, String _tenTA, String _maNSX, Decimal _nguong, String _maDVT, Boolean _apDungGoi, Boolean _handung, String _khoban, String _khophat, Boolean _vTThuT, Boolean _vTPhauT, Boolean _vTCLS, Boolean _vTDuoc, Boolean _vTBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD, Boolean _vTNoiT, String _maLH)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMVTYT_UPDATE", _maVT, _maNhom, _maChungLoai, _tenTM, _tenTA, _maNSX, _nguong, _maDVT, _apDungGoi, _handung, _khoban, _khophat, _vTThuT, _vTPhauT, _vTCLS, _vTDuoc, _vTBan, _duyetNgoaiT, _duyetNoiT, _ghichu, _maMay, _huy, _nguoiSD , _vTNoiT, _maLH);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maVT));
		}

		/// <summary>
		/// Delete the <see cref="DMVTYT" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMVTYT
            DataProvider.Instance().DeleteDMVPP(crit.MaMay, crit.NguoiSD, crit.maVT);
			// public abstract void DeleteDMVTYT(String _maVT);
			// public override void DeleteDMVTYT(String _maVT);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMVTYT_DELETED", _maVT);
			// }
		}

		#endregion
	}

}
