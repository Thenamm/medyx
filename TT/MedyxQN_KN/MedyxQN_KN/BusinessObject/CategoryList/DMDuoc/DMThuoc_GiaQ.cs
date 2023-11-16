// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMThuoc_GiaQ
// Kieu doi tuong  :	DMThuoc_GiaQ
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
	/// This is a base generated class of <see cref="DMThuoc_GiaQ" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class DMThuoc_GiaQ : BusinessBase<DMThuoc_GiaQ>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maThuoc = String.Empty;
		private String _parent = String.Empty;
		private String _maNhom = String.Empty;
        private String _maPL = String.Empty;
        private String _maChungLoai = String.Empty;
		private String _tenGoc = String.Empty;
		private String _tenTC = String.Empty;
		private String _tenTM = String.Empty;
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
		private Decimal _quydoi = 0;
        private String _maThuoc2 = String.Empty;
		private String _maDVT2 = String.Empty;
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
		private Boolean _duyetNgoaiT = false;
		private Boolean _duyetNoiT = false;
		private String _ghichu = String.Empty;
		private String _maMay = String.Empty;
        private String _tendvt = String.Empty;
        private String _tendvthl = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
		private SmartDate _ngayQuay = new SmartDate(true);
        private SmartDate _ngayQuayD = new SmartDate(true);
		private String _nguoiQuay = String.Empty;
		private SmartDate _ngayHuy = new SmartDate(true);
		private String _nguoiHuy = String.Empty;
        private String _malh = String.Empty;
        private String _tennguoiQuay = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
        public String TenNguoiQuay
        {
            get
            {
                CanReadProperty("TenNguoiQuay", true);
                return _tennguoiQuay;
            }
            set
            {
                CanWriteProperty("TenNguoiQuay", true);
                if (_tennguoiQuay != value)
                {
                    _tennguoiQuay = value;
                    PropertyHasChanged("TenNguoiQuay");
                }
            }
        }
		public String MaThuoc
		{
			get 
			{
				CanReadProperty("MaThuoc", true);
				return _maThuoc;
			}
			set 
			{
				CanWriteProperty("MaThuoc", true);
				if (_maThuoc != value) 
				{
					_maThuoc = value;
					PropertyHasChanged("MaThuoc");
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
		
		public String maThuocgoc
		{
			get 
			{
				CanReadProperty("MaThuocgoc", true);
				return _maThuoc2;
			}
			set 
			{
				CanWriteProperty("MaThuocgoc", true);
				if (_maThuoc2 != value) 
				{
					_maThuoc2 = value;
					PropertyHasChanged("MaThuocgoc");
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
		
        //public Decimal GiaQuay
        //{
        //    get 
        //    {
        //        CanReadProperty("GiaQuay", true);
        //        return _giaQuay;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("GiaQuay", true);
        //        if (_giaQuay != value) 
        //        {
        //            _giaQuay = value;
        //            PropertyHasChanged("GiaQuay");
        //        }
        //    }
        //}
        public string GiaQuay
        {
            get
            {
                CanReadProperty("GiaQuay", true);
                if (_giaQuay == 0)
                {
                    return "0";
                }
                else
                {
                    return _giaQuay.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("GiaQuay", true);

                if (_giaQuay.ToString() != value)
                {
                    _giaQuay = decimal.Parse(value);
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
		
		public string NgayQuay
		{
			get 
			{
				CanReadProperty("NgayQuay", true);
				return _ngayQuay.Text;
			}
			set 
			{
				CanWriteProperty("NgayQuay", true);
				if (_ngayQuay.Text != value) 
				{
					_ngayQuay.Text = value;
					PropertyHasChanged("NgayQuay");
				}
			}
		}
        public String NgayQuayD
        {
            get
            {
                CanReadProperty("NgayQuayD", true);
                _ngayQuayD = _ngayQuay;
                this._ngayQuayD.FormatString = "dd/MM/yyyy HH:mm";
                return _ngayQuayD.Text;
            }
           
        }
		
		public String NguoiQuay
		{
			get 
			{
				CanReadProperty("NguoiQuay", true);
				return _nguoiQuay;
			}
			set 
			{
				CanWriteProperty("NguoiQuay", true);
				if (_nguoiQuay != value) 
				{
					_nguoiQuay = value;
					PropertyHasChanged("NguoiQuay");
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
			return _maThuoc;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            ////ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenTM", 350));
            //ValidationRules.AddRule<DMThuoc_GiaQ>(StringRequired<DMThuoc_GiaQ>, "TenTM");
            ////ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenTM", 350));
            //ValidationRules.AddRule<DMThuoc_GiaQ>(StringRequiredDVT<DMThuoc_GiaQ>, "MaDVT");

        }

        //private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMThuoc_GiaQ
        //{

        //    if (target._tenTM == null || target._tenTM.Trim().Length == 0)
        //    {
        //        e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
        //        return false;
        //    }
        //    else
        //        return true;
        //}

        //private static bool StringRequiredDVT<T>(T target, Csla.Validation.RuleArgs e) where T : DMThuoc_GiaQ
        //{

        //    if (target._maDVT == null || target._maDVT.Trim().Length == 0)
        //    {
        //        e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
        //        return false;
        //    }
        //    else
        //        return true;
        //}	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="DMThuoc_GiaQ" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static DMThuoc_GiaQ NewDMThuoc_GiaQ()
        {
            //return new DMNhomThuoc();
            return DataPortal.Create<DMThuoc_GiaQ>();
        }
		public static DMThuoc_GiaQ GetDMThuoc_GiaQ(String maThuoc)
		{
			return DataPortal.Fetch<DMThuoc_GiaQ>(new Criteria(maThuoc));
		}
		
		/// <summary>
		/// Marks the <see cref="DMThuoc_GiaQ" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteDMThuoc_GiaQ(String maThuoc, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maThuoc));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMThuoc_GiaQ()
		{	
			// Prevent direct creation
		}
        internal DMThuoc_GiaQ(        int OrderNumber,
                                 String maThuoc ,
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
		                         String maThuocgoc ,
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
		                         SmartDate ngayQuay ,
		                         String nguoiQuay ,
		                         SmartDate ngayHuy ,
		                         String nguoiHuy ,
string malh,
                                String tendvt,
string tendvthl,
string tennguoiquay
            )
        {
              _OrderNumber = OrderNumber ;
              _maThuoc = maThuoc;
		      _parent = parent ;
		      _maNhom = maNhom ;
              _tennguoiQuay = tennguoiquay;
		      _maPL = maPL ;
		      _maChungLoai = maChungLoai ;
		      _tenGoc = tenGoc;
		      _tenTC = tenTC ;
		      _tenTM = tenTM ;
		      _tenTM1 = tenTM1 ;
		      _tenTM2 = tenTM2 ;
		      _tenTA = tenTA ;
		      _thuocGoc = thuocGoc ;
		      _ngaydungtoida = ngaydungtoida ;
		      _maNSX = maNSX ;
		      _hamLuong = hamLuong ;
		      _maDVTHL = maDVTHL ;
		      _nguong = nguong ;
		      _maDVT = maDVT ;
		      _quydoi = quydoi ;
		      _maThuoc2 = maThuocgoc ;
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
		      _ngayQuay = ngayQuay ;
		      _nguoiQuay = nguoiQuay ;
		      _ngayHuy = ngayHuy  ;
		      _nguoiHuy = nguoiHuy ;
              _malh = malh;
              _tendvt = tendvt;
              _tendvthl = tendvthl;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maThuoc;
			public String MaThuoc 
			{
				get
				{
					return _maThuoc;
				}
			}
			
			public Criteria(String maThuoc)
			{
				_maThuoc = maThuoc;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maThuoc.Equals(c._maThuoc)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maThuoc.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maThuoc;
            public String maThuoc
            {
                get
                {
                    return _maThuoc;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maThuoc)
            {
                _maThuoc = maThuoc;
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
		/// Retrieve an existing <see cref="DMThuoc_GiaQ" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetDMThuoc_GiaQ(String _maThuoc);
			// public override IDataReader GetDMThuoc_GiaQ(String _maThuoc)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maThuoc));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMThuoc_GiaQ(crit.MaThuoc)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMThuoc_GiaQ" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaThuoc") != null) _maThuoc = dr.GetString("MaThuoc");
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
            if (dr.GetString("MaThuocgoc") != null) _maThuoc2 = dr.GetString("MaThuocgoc");
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
			if (dr.GetSmartDate("NgayQuay", true) != null) _ngayQuay = dr.GetSmartDate("NgayQuay", true);
			if (dr.GetString("NguoiQuay") != null) _nguoiQuay = dr.GetString("NguoiQuay");
			if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
			if (dr.GetString("nguoiHuy") != null) _nguoiHuy = dr.GetString("nguoiHuy");
            if (dr.GetString("malh") != null) _malh = dr.GetString("malh");
            if (dr.GetString("tendvt") != null) _tendvt = dr.GetString("tendvt");
            if (dr.GetString("TenNguoiquay") != null) _tennguoiQuay = dr.GetString("TenNguoiquay");
            if (dr.GetString("tendvthl") != null) _tendvthl = dr.GetString("tendvthl");
		}
		
		/// <summary>
		/// Insert the new <see cref="DMThuoc_GiaQ" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
        internal void Insert()
        {
            if (!this.IsDirty)
                return;
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_GiaQ
            // Copy & paste ham duoi day vao file DataProvider.cs
            
              
            DataProvider.Instance().UpdateDMThuoc_GiaQ(_maThuoc, _giaQuay, _maMay, _nguoiSD);
            // public abstract String InsertDMThuoc_GiaQ(String _parent, String _maNhom, String _maPL, String _maChungLoai, String _tenGoc, String _tenTC, String _tenTM, String _tenTM1, String _tenTM2, String _tenTA, Boolean _thuocGoc, Decimal _ngaydungtoida, String _maNSX, String _hamLuong, String _maDVTHL, Decimal _nguong, String _maDVT, Decimal _quydoi, String _maThuoc2, String _maDVT2, Boolean _apDungGoi, Boolean _handung, String _lieudung, String _cachdung, String _khoban, String _khophat, Boolean _thuocThuT, Boolean _thuocPhauT, Boolean _thuocCLS, Boolean _ThuocNoiT, Boolean _thuocDuoc, Boolean _thuocBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, String _nguoiSD);
            // public override String InsertDMThuoc_GiaQ(String _parent, String _maNhom, String _maPL, String _maChungLoai, String _tenGoc, String _tenTC, String _tenTM, String _tenTM1, String _tenTM2, String _tenTA, Boolean _thuocGoc, Decimal _ngaydungtoida, String _maNSX, String _hamLuong, String _maDVTHL, Decimal _nguong, String _maDVT, Decimal _quydoi, String _maThuoc2, String _maDVT2, Boolean _apDungGoi, Boolean _handung, String _lieudung, String _cachdung, String _khoban, String _khophat, Boolean _thuocThuT, Boolean _thuocPhauT, Boolean _thuocCLS, Boolean _ThuocNoiT, Boolean _thuocDuoc, Boolean _thuocBan, Boolean _duyetNgoaiT, Boolean _duyetNoiT, String _ghichu, String _maMay, String _nguoiSD);
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMThuoc_GiaQ_CREATE",  _parent, _maNhom, _maPL, _maChungLoai, _tenGoc, _tenTC, _tenTM, _tenTM1, _tenTM2, _tenTA, _thuocGoc, _ngaydungtoida, _maNSX, _hamLuong, _maDVTHL, _nguong, _maDVT, _quydoi, _maThuoc2, _maDVT2, _apDungGoi, _handung, _lieudung, _cachdung, _khoban, _khophat, _thuocThuT, _thuocPhauT, _thuocCLS, _ThuocNoiT, _thuocDuoc, _thuocBan, _duyetNgoaiT, _duyetNoiT, _ghichu, _maMay, _nguoiSD), String);
            // }
            MarkOld();
        }
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD ,_maThuoc ));
            MarkNew();
        }
		/// <summary>
		/// Update all changes made on <see cref="DMThuoc_GiaQ" /> Object to underlying database.
		/// </summary>
        internal void Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_GiaQ
			if (!this.IsDirty)
                return;
                
                  
                DataProvider.Instance().UpdateDMThuoc_GiaQ(_maThuoc, _giaQuay, _maMay, _nguoiSD);
							
			
		}
		protected override void DataPortal_DeleteSelf()
		{
            
		}

		/// <summary>
		/// Delete the <see cref="DMThuoc_GiaQ" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			
		}

		#endregion
	}

}
