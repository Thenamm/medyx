// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn
// Kieu doi tuong  :	BenhAn
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	6/15/2009 8:58:55 AM
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
//them 1 truong Ma loại benh án 
namespace HTC.Business.NoiTru
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="BenhAn" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn : BusinessBase<BenhAn>
	{
		#region Business Methods
		
		#region State Fields
        private String _noiTT = String.Empty;
        private String _maBAQL = String.Empty;
		private String _maBA = String.Empty;
        private String _maLoaiBA = String.Empty;
		private String _maBN = String.Empty;
		private String _maDT = String.Empty;
		private String _sothe = String.Empty;
		private SmartDate _giatriDN = new SmartDate(true);
		private String _maBV = String.Empty;
		private String _maTinh = String.Empty;
		private SmartDate _ngayKT = new SmartDate(true);
		private SmartDate _ngayduyet = new SmartDate(true);
		private String _nguoiduyet = String.Empty;
		private SmartDate _ngayQT = new SmartDate(true);
		private SmartDate _ngayQTTT = new SmartDate(true);
		private String _nguoiQT = String.Empty;
		private String _maBenhNoiGT = String.Empty;
		private String _maNoiGT = String.Empty;
		private String _cDNoiGT = String.Empty;
		private String _ghichu = String.Empty;
		private Boolean _cungtra = false;
		private Decimal _ck = 0;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private String _nguoiHuy = String.Empty;
        private SmartDate _giaTriTN = new SmartDate(true);
		private SmartDate _ngayHuy = new SmartDate(true);
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
		private SmartDate _ngayVV = new SmartDate(true);
        private SmartDate _NgayVVD = new SmartDate(true);
		private String _soPhieuTTRV = String.Empty;
		private String _maBALuu = String.Empty;
        private String _mabsravien = String.Empty;
        private String _tenbsravien = String.Empty;
		private Boolean _raVien = false;
		private String _maKhoa_HT = String.Empty;
        private String _mabhxh = String.Empty;
        private String _tendt = String.Empty;
        private Decimal _bhtra = 0;
        private Decimal _sotienbhtra = 0;
        private String _tenBV = String.Empty;
        private String _maicdngt = String.Empty;
        private String _tenbenhngt = String.Empty;
        private String _hoten = String.Empty;
        private Byte _tuoi = 0;
        private Byte _dattoan = 0;
        private SmartDate _ngaySinh = new SmartDate(true);
        private String _diaChi = String.Empty;
        private Boolean _gt = false;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private String _tenKhoaHT = String.Empty;
        private Decimal _tongtien = 0;
        private Decimal _giatrimaxktc = 0;
        private Boolean _apDungGoi = false;
        private Boolean _daks = false;
        private Boolean _taibienThuoc = false;
        private Boolean _taibienPT = false;
        private Boolean _taibienTT = false;
        private Boolean _hoichan = false;
        private SmartDate _ngayhuongbh = new SmartDate(true);
        private SmartDate _ngayRaVien = new SmartDate(true);
        private String _maBALienQuan = String.Empty;
        private int _OrderNumber;

        private String _ngayDu5Nam = String.Empty;
        private String _maKV = String.Empty;
        private String _ngayMienCCT = String.Empty;

		#endregion
		
		#region Business Properties and Methods

        public string MaKV
        {
            get
            {
                CanReadProperty(true);
                return _maKV;
            }
            set
            {
                CanReadProperty("MaKV", true);
                if (!_maKV.Equals(value))
                {
                    _maKV = value;
                    PropertyHasChanged("MaKV");
                }
            }
        }
        public string NgayMienCCT
        {
            get
            {
                CanReadProperty(true);
                return _ngayMienCCT;
            }
            set
            {
                CanReadProperty("NgayMienCCT", true);
                if (!_ngayMienCCT.Equals(value))
                {
                    _ngayMienCCT = value;
                    PropertyHasChanged("NgayMienCCT");
                }
            }
        }
        public String ngayDu5Nam
        {
            get
            {
                CanReadProperty("ngayDu5Nam", true);
                return _ngayDu5Nam;
            }
            set
            {
                CanWriteProperty("ngayDu5Nam", true);
                if (_ngayDu5Nam != value)
                {
                    _ngayDu5Nam = value;
                    PropertyHasChanged("ngayDu5Nam");
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
        public String MaBAQL
        {
            get
            {
                CanReadProperty("MaBAQL", true);
                return _maBAQL;
            }
            set
            {
                CanWriteProperty("MaBAQL", true);
                if (_maBAQL != value)
                {
                    _maBAQL = value;
                    PropertyHasChanged("MaBAQL");
                }
            }
        }
        public string GiaTriTN
        {
            get
            {
                CanReadProperty("GiaTriTN", true);
                return _giaTriTN.Text;
            }
            set
            {
                CanWriteProperty("GiaTriTN", true);
                if (_giaTriTN.Text != value)
                {
                    _giaTriTN.Text = value;
                    PropertyHasChanged("GiaTriTN");
                }
            }
        }
        public string mabsravien
        {
            get
            {
                CanReadProperty("mabsravien", true);
                return _mabsravien;
            }
            set
            {
                CanWriteProperty("mabsravien", true);
                if (_mabsravien != value)
                {
                    _mabsravien = value;
                    PropertyHasChanged("mabsravien");
                }
            }
        }
        public string tenbsravien
        {
            get
            {
                CanReadProperty("tenbsravien", true);
                return _tenbsravien;
            }
            set
            {
                CanWriteProperty("tenbsravien", true);
                if (_tenbsravien != value)
                {
                    _tenbsravien = value;
                    PropertyHasChanged("tenbsravien");
                }
            }
        }
        public Boolean GoiDichVu
        {
            get
            {
                CanReadProperty("GoiDichVu", true);
                return _apDungGoi;
            }
            set
            {
                CanWriteProperty("GoiDichVu", true);
                if (_apDungGoi != value)
                {
                    _apDungGoi = value;
                    PropertyHasChanged("GoiDichVu");
                }
            }
        }
        public Boolean daks
        {
            get
            {
                CanReadProperty("daks", true);
                return _daks;
            }
            set
            {
                CanWriteProperty("daks", true);
                if (_daks != value)
                {
                    _daks = value;
                    PropertyHasChanged("daks");
                }
            }
        }
        public Boolean taibienThuoc
        {
            get
            {
                CanReadProperty("taibienThuoc", true);
                return _taibienThuoc;
            }
            set
            {
                CanWriteProperty("taibienThuoc", true);
                if (_taibienThuoc != value)
                {
                    _taibienThuoc = value;
                    PropertyHasChanged("taibienThuoc");
                }
            }
        }
        public Boolean hoichan
        {
            get
            {
                CanReadProperty("hoichan", true);
                return _hoichan;
            }
            set
            {
                CanWriteProperty("hoichan", true);
                if (_hoichan != value)
                {
                    _hoichan = value;
                    PropertyHasChanged("hoichan");
                }
            }
        }
        public Boolean taibienPT
        {
            get
            {
                CanReadProperty("taibienPT", true);
                return _taibienPT;
            }
            set
            {
                CanWriteProperty("taibienPT", true);
                if (_taibienPT != value)
                {
                    _taibienPT = value;
                    PropertyHasChanged("taibienPT");
                }
            }
        }
        public Boolean taibienTT
        {
            get
            {
                CanReadProperty("taibienTT", true);
                return _taibienTT;
            }
            set
            {
                CanWriteProperty("taibienTT", true);
                if (_taibienTT != value)
                {
                    _taibienTT = value;
                    PropertyHasChanged("taibienTT");
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

        public String MaLoaiBA
        {
            get
            {
                CanReadProperty("MaLoaiBA", true);
                return _maLoaiBA;
            }
            set
            {
                CanWriteProperty("MaLoaiBA", true);
                if (_maLoaiBA != value)
                {
                    _maLoaiBA = value;
                    PropertyHasChanged("MaLoaiBA");
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
		
		public string Ngayduyet
		{
			get 
			{
				CanReadProperty("Ngayduyet", true);
				return _ngayduyet.Text;
			}
			set 
			{
				CanWriteProperty("Ngayduyet", true);
				if (_ngayduyet.Text != value) 
				{
					_ngayduyet.Text = value;
					PropertyHasChanged("Ngayduyet");
				}
			}
		}
		
		public String Nguoiduyet
		{
			get 
			{
				CanReadProperty("Nguoiduyet", true);
				return _nguoiduyet;
			}
			set 
			{
				CanWriteProperty("Nguoiduyet", true);
				if (_nguoiduyet != value) 
				{
					_nguoiduyet = value;
					PropertyHasChanged("Nguoiduyet");
				}
			}
		}
		
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
        public string ngayhuongbh
        {
            get
            {
                CanReadProperty("ngayhuongbh", true);
                return _ngayhuongbh.Text;
            }
            set
            {
                CanWriteProperty("ngayhuongbh", true);
                if (_ngayhuongbh.Text != value)
                {
                    _ngayhuongbh.Text = value;
                    PropertyHasChanged("ngayhuongbh");
                }
            }
        }

        public string NgayRaVien
        {
            get
            {
                CanReadProperty("NgayRaVien", true);
                return _ngayRaVien.Text;
            }
            set
            {
                CanWriteProperty("NgayRaVien", true);
                if (_ngayRaVien.Text != value)
                {
                    _ngayRaVien.Text = value;
                    PropertyHasChanged("NgayRaVien");
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
		
		public string NgayVV
		{
			get 
			{
				CanReadProperty("NgayVV", true);
                _ngayVV.FormatString = "MM/dd/yyyy HH:mm:ss";
                return _ngayVV.Text;
			}
			set 
			{
				CanWriteProperty("NgayVV", true);
				if (_ngayVV.Text != value) 
				{
					_ngayVV.Text = value;
					PropertyHasChanged("NgayVV");
				}
			}
		}

        public string ngayVVD
        {
            get
            {
                //CanReadProperty("NgayDong", true);
                _NgayVVD = _ngayVV ;
                _NgayVVD.FormatString = "dd/MM/yyyy HH:mm";
                return _NgayVVD.Text;
            }
            set
            {
                //CanWriteProperty("NgayDong", true);
                if (_NgayVVD.Text != value)
                {
                    _NgayVVD.Text = value;
                    //  PropertyHasChanged("NgayDong");
                }
            }
        }
		public String SoPhieuTTRV
		{
			get 
			{
				CanReadProperty("SoPhieuTTRV", true);
				return _soPhieuTTRV;
			}
			set 
			{
				CanWriteProperty("SoPhieuTTRV", true);
				if (_soPhieuTTRV != value) 
				{
					_soPhieuTTRV = value;
					PropertyHasChanged("SoPhieuTTRV");
				}
			}
		}
		
		public String MaBALuu
		{
			get 
			{
				CanReadProperty("MaBALuu", true);
				return _maBALuu;
			}
			set 
			{
				CanWriteProperty("MaBALuu", true);
				if (_maBALuu != value) 
				{
					_maBALuu = value;
					PropertyHasChanged("MaBALuu");
				}
			}
		}
		
		public Boolean RaVien
		{
			get 
			{
				CanReadProperty("RaVien", true);
				return _raVien;
			}
			set 
			{
				CanWriteProperty("RaVien", true);
				if (_raVien != value) 
				{
					_raVien = value;
					PropertyHasChanged("RaVien");
				}
			}
		}
		
		public String MaKhoa_HT
		{
			get 
			{
				CanReadProperty("MaKhoa_HT", true);
				return _maKhoa_HT;
			}
			set 
			{
				CanWriteProperty("MaKhoa_HT", true);
				if (_maKhoa_HT != value) 
				{
					_maKhoa_HT = value;
					PropertyHasChanged("MaKhoa_HT");
				}
			}
		}

        public String mabhxh
        {
            get
            {
                CanReadProperty("mabhxh", true);
                return _mabhxh;
            }
            set
            {
                CanWriteProperty("mabhxh", true);
                if (_mabhxh != value)
                {
                    _mabhxh = value;
                    PropertyHasChanged("mabhxh");
                }
            }
        }

        public String tendt
        {
            get
            {
                CanReadProperty("tendt", true);
                return _tendt;
            }
            set
            {
                CanWriteProperty("tendt", true);
                if (_tendt != value)
                {
                    _tendt = value;
                    PropertyHasChanged("tendt");
                }
            }
        }

        public Decimal bhtra
        {
            get
            {
                CanReadProperty("bhtra", true);
                return _bhtra;
            }
            set
            {
                CanWriteProperty("bhtra", true);
                if (_bhtra != value)
                {
                    _bhtra = value;
                    PropertyHasChanged("bhtra");
                }
            }
        }
        public Decimal sotienbhtra
        {
            get
            {
                CanReadProperty("sotienbhtra", true);
                return _sotienbhtra;
            }
            set
            {
                CanWriteProperty("sotienbhtra", true);
                if (_sotienbhtra != value)
                {
                    _sotienbhtra = value;
                    PropertyHasChanged("sotienbhtra");
                }
            }
        }

        public String TenBV
        {
            get
            {
                CanReadProperty("TenBV", true);
                return _tenBV;
            }
            set
            {
                CanWriteProperty("TenBV", true);
                if (_tenBV != value)
                {
                    _tenBV = value;
                    PropertyHasChanged("TenBV");
                }
            }
        }
        public String maicdngt
        {
            get
            {
                CanReadProperty("maicdngt", true);
                return _maicdngt;
            }
            set
            {
                CanWriteProperty("maicdngt", true);
                if (_maicdngt != value)
                {
                    _maicdngt = value;
                    PropertyHasChanged("maicdngt");
                }
            }
        }
        public String tenbenhngt
        {
            get
            {
                CanReadProperty("tenbenhngt", true);
                return _tenbenhngt;
            }
            set
            {
                CanWriteProperty("tenbenhngt", true);
                if (_tenbenhngt != value)
                {
                    _tenbenhngt = value;
                    PropertyHasChanged("tenbenhngt");
                }
            }
        }

        public String Hoten
        {
            get
            {
                CanReadProperty("Hoten", true);
                return _hoten;
            }
            set
            {
                CanWriteProperty("Hoten", true);
                if (_hoten != value)
                {
                    _hoten = value;
                    PropertyHasChanged("Hoten");
                }
            }
        }

        public byte Tuoi
        {
            get
            {

                return _tuoi;
            }
            set
            {
                CanWriteProperty("Tuoi", true);
                if (_tuoi != value)
                {
                    _tuoi = value;
                    PropertyHasChanged("Tuoi");
                }
            }
        }
        public byte dattoan
        {
            get
            {

                return _dattoan;
            }
            set
            {
                CanWriteProperty("dattoan", true);
                if (_dattoan != value)
                {
                    _dattoan = value;
                    PropertyHasChanged("dattoan");
                }
            }
        }
        public string NgaySinh
        {
            get
            {
                CanReadProperty("NgaySinh", true);
                return _ngaySinh.Text;
            }
            set
            {
                CanWriteProperty("NgaySinh", true);
                if (_ngaySinh.Text != value)
                {
                    _ngaySinh.Text = value;
                    PropertyHasChanged("NgaySinh");
                }
            }
        }

        public string Diachi
        {
            get
            {
                CanReadProperty("Diachi", true);
                return _diaChi;
            }
            set
            {
                CanWriteProperty("Diachi", true);
                if (_diaChi != value)
                {
                    _diaChi = value;
                    PropertyHasChanged("Diachi");
                }
            }
        }

        public Boolean GT
        {
            get
            {
                CanReadProperty("GT", true);
                return _gt;
            }
            set
            {
                CanWriteProperty("GT", true);
                if (_gt != value)
                {
                    _gt = value;
                    PropertyHasChanged("GT");
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

        public String TenKhoaHT
        {
            get
            {
                CanReadProperty("TenKhoaHT", true);
                return _tenKhoaHT;
            }
            set
            {
                CanWriteProperty("TenKhoaHT", true);
                if (_tenKhoaHT != value)
                {
                    _tenKhoaHT = value;
                    PropertyHasChanged("TenKhoaHT");
                }
            }
        }
        public Decimal giatrimaxktc
        {
            get
            {
                CanReadProperty("giatrimaxktc", true);
                return _giatrimaxktc;
            }
            set
            {
                CanWriteProperty("giatrimaxktc", true);
                if (_giatrimaxktc != value)
                {
                    _giatrimaxktc = value;
                    PropertyHasChanged("giatrimaxktc");
                }
            }
        }
        public Decimal TongTien
        {
            get
            {
                CanReadProperty("TongTien", true);
                return _tongtien;
            }
            set
            {
                CanWriteProperty("TongTien", true);
                if (_tongtien != value)
                {
                    _tongtien = value;
                    PropertyHasChanged("TongTien");
                }
            }
        }
        public String MaBALienQuan
        {
            get
            {
                CanReadProperty("MaBALienQuan", true);
                return _maBALienQuan;
            }
            set
            {
                CanWriteProperty("MaBALienQuan", true);
                if (_maBALienQuan != value)
                {
                    _maBALienQuan = value;
                    PropertyHasChanged("MaBALienQuan");
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
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                }
            }
        }

		protected override Object GetIdValue()
		{
			return _maBA;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhAn" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BenhAn NewBenhAn()
        {
            return DataPortal.Create<BenhAn>();
        }
        public static BenhAn GetBenhAn(String maBA, string dk,byte loaikq =0)
		{
			return DataPortal.Fetch<BenhAn>(new Criteria(maBA,dk,loaikq ));
		}
        public static BenhAn GetBenhAn(String maBA, string dk)
        {
            return DataPortal.Fetch<BenhAn>(new Criteria(maBA, dk, 0));
        }
		/// <summary>
		/// Marks the <see cref="BenhAn" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBenhAn(String maBA, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maBA));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BenhAn()
		{	
			// Prevent direct creation
		}

        internal BenhAn(
                                 int OrderNumber,
                                 String maBA ,
                                 String maLoaiBA,
		                         String maBN ,
		                         String maDT ,
		                         String sothe ,
		                         SmartDate giatriDN ,
		                         String maBV ,
		                         String maTinh ,
		                         SmartDate ngayKT ,
		                         SmartDate ngayduyet,
		                         String nguoiduyet ,
		                         SmartDate ngayQT ,
		                         SmartDate ngayQTTT ,
		                         String nguoiQT ,
		                         String maBenhNoiGT ,
		                         String maNoiGT ,
		                         String cDNoiGT ,
		                         String ghichu ,
		                         Boolean cungtra,
		                         Decimal ck ,
		                         SmartDate ngayLap ,
		                         String nguoiLap ,
		                         SmartDate ngaySD ,
		                         String nguoiSD ,
		                         String maMay ,
		                         Boolean huy ,
		                         String nguoiHuy ,
		                         SmartDate ngayHuy ,
		                         SmartDate ngaySD1 ,
		                         String nguoiSD1 ,
		                         SmartDate ngayVV ,
		                         String soPhieuTTRV ,
		                         String maBALuu ,
		                         Boolean raVien ,
		                         String maKhoa_HT ,
                                 String mabhxh ,
                                 String tendt ,
                                 Decimal bhtra ,
                                 Decimal sotienbhtra ,
                                 String tenBV ,
                                 String maicdngt ,
                                 String tenbenhngt ,
                                 String hoten ,
                                 Byte tuoi ,
                                 SmartDate ngaySinh ,
                                 String diaChi ,
                                 Boolean gt ,
                                 String tenNguoiLap ,
                                 String tenNguoiSD ,
                                 String tenNguoiHuy ,
                                 String tenKhoaHT ,
                                 Decimal tongtien,
             Decimal giatrimaxktc,
                                 SmartDate giaTriTN,
                                 SmartDate ngayRaVien,
                                 String maBALienQuan,
                             String maBAQL,Boolean TAIBIENTHUOC,Boolean TAIBIENPT,
            Boolean TAIBIENTT,Boolean hoichan
         
            )
        {
            _maBAQL = maBAQL;
            _taibienThuoc = TAIBIENTHUOC;
            _taibienTT = TAIBIENTT;
            _taibienPT = TAIBIENPT;
            _hoichan = hoichan;
                                  _OrderNumber = OrderNumber ;
                                  _maBA = maBA ;
                                  _maLoaiBA = maLoaiBA;
		                          _maBN = maBN ;
		                          _maDT = maDT ;
		                          _sothe = sothe ;
		                          _giatriDN = giatriDN ;
		                          _maBV = maBV ;
		                          _maTinh = maTinh ;
		                          _ngayKT = ngayKT ;
		                          _ngayduyet = ngayduyet ;
		                          _nguoiduyet = nguoiduyet ;
		                          _ngayQT = ngayQT ;
		                          _ngayQTTT = ngayQTTT ;
		                          _nguoiQT = nguoiQT ;
		                          _maBenhNoiGT = maBenhNoiGT ;
		                          _maNoiGT = maNoiGT ;
		                          _cDNoiGT = cDNoiGT ;
		                          _ghichu = ghichu ;
		                          _cungtra = cungtra ;
		                          _ck = ck;
		                          _ngayLap = ngayLap ;
		                          _nguoiLap = nguoiLap ;
		                          _ngaySD = ngaySD ;
		                          _nguoiSD = nguoiSD ;
		                          _maMay = maMay ;
		                          _huy = huy ;
		                          _nguoiHuy = nguoiHuy ;
		                          _ngayHuy = ngayHuy ;
		                          _ngaySD1 = ngaySD1 ;
		                          _nguoiSD1 = nguoiSD1 ;
		                          _ngayVV = ngayVV ;
		                          _soPhieuTTRV = soPhieuTTRV ;
		                          _maBALuu = maBALuu ;
		                          _raVien = raVien ;
		                          _maKhoa_HT = maKhoa_HT ;
                                  _mabhxh = mabhxh ;
                                  _tendt = tendt ;
                                  _bhtra = bhtra ;
                                  _sotienbhtra = sotienbhtra ;
                                  _tenBV = TenBV ;
                                  _maicdngt = maicdngt ;
                                  _tenbenhngt = tenbenhngt ;
                                  _hoten = hoten ;
                                  _tuoi = tuoi ;
                                  _ngaySinh = ngaySinh ;
                                  _diaChi = diaChi ;
                                  _gt = gt;        
                                  _tenNguoiLap = tenNguoiLap ;
                                  _tenNguoiSD = tenNguoiSD ;
                                  _tenNguoiHuy = tenNguoiHuy ;
                                  _tenKhoaHT = tenKhoaHT ;
                                  _tongtien = tongtien;
                                  //_giatrimaxktc = giatrimaxktc;
                                  _giaTriTN = giaTriTN;
                                  _ngayRaVien = ngayRaVien;
                                  _maBALienQuan = maBALienQuan;

        }

		#endregion

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
            private String _dk;
            public String dk
            {
                get
                {
                    return _dk;
                }
            }
            private byte _loaikq;
            public byte loaikq
            {
                get
                {
                    return _loaikq;
                }
            }
            public Criteria(String maBA, String dk,byte loaikq =0)
			{
				_maBA = maBA;
                _loaikq = loaikq;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBA.Equals(c._maBA)) 
						return false;
                    if (!_dk.Equals(c._dk))
                        return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBA.ToString(), _dk.ToString() ).GetHashCode();
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
            public OtherCriteria(String Mamay, String Nguoisd, String maba)
            {
                _maBA = maba ;
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
		/// Retrieve an existing <see cref="BenhAn" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetBenhAn(String _maBA);
			// public override IDataReader GetBenhAn(String _maBA)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBA));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn(crit.MaBA, crit.dk,crit.loaikq )))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="BenhAn" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
            //if (dr.GetString("ngayDu5Nam") != null) _ngayDu5Nam = dr.GetString("ngayDu5Nam");
            //if (dr.GetString("MaKV") != null) _maKV = dr.GetString("MaKV");
            //if (dr.GetString("ngayMienCCT") != null) _ngayMienCCT = dr.GetString("ngayMienCCT");

            if (dr.GetString("MaBAQL") != null) _maBAQL = dr.GetString("MaBAQL");
			if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
            if (dr.GetString("MaLoaiBA") != null) _maLoaiBA = dr.GetString("MaLoaiBA");
			if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
            if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
			if (dr.GetString("Sothe") != null) _sothe = dr.GetString("Sothe");
			if (dr.GetSmartDate("GiatriDN", true) != null) _giatriDN = dr.GetSmartDate("GiatriDN", true);
			if (dr.GetString("MaBV") != null) _maBV = dr.GetString("MaBV");
			if (dr.GetString("MaTinh") != null) _maTinh = dr.GetString("MaTinh");
			if (dr.GetSmartDate("NgayKT", true) != null) _ngayKT = dr.GetSmartDate("NgayKT", true);
			if (dr.GetSmartDate("Ngayduyet", true) != null) _ngayduyet = dr.GetSmartDate("Ngayduyet", true);
			if (dr.GetString("Nguoiduyet") != null) _nguoiduyet = dr.GetString("Nguoiduyet");
			if (dr.GetSmartDate("NgayQT", true) != null) _ngayQT = dr.GetSmartDate("NgayQT", true);
			if (dr.GetSmartDate("NgayQTTT", true) != null) _ngayQTTT = dr.GetSmartDate("NgayQTTT", true);
			if (dr.GetString("NguoiQT") != null) _nguoiQT = dr.GetString("NguoiQT");
			if (dr.GetString("MaBenhNoiGT") != null) _maBenhNoiGT = dr.GetString("MaBenhNoiGT");
			if (dr.GetString("MaNoiGT") != null) _maNoiGT = dr.GetString("MaNoiGT");
			if (dr.GetString("CDNoiGT") != null) _cDNoiGT = dr.GetString("CDNoiGT");
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
			if (dr.GetBoolean("Cungtra") != null) _cungtra = dr.GetBoolean("Cungtra");
            if (dr.GetSmartDate("GiaTriTN", true) != null) _giaTriTN = dr.GetSmartDate("GiaTriTN", true);
			if (dr.GetDecimal("CK") != null) _ck = dr.GetDecimal("CK");
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
			if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
			if (dr.GetSmartDate("NgayVV", true) != null) _ngayVV = dr.GetSmartDate("NgayVV", true);
			if (dr.GetString("SoPhieuTTRV") != null) _soPhieuTTRV = dr.GetString("SoPhieuTTRV");
			if (dr.GetString("MaBALuu") != null) _maBALuu = dr.GetString("MaBALuu");
			if (dr.GetBoolean("RaVien") != null) _raVien = dr.GetBoolean("RaVien");
			if (dr.GetString("MaKhoa_HT") != null) _maKhoa_HT = dr.GetString("MaKhoa_HT");
            if (dr.GetBoolean("GoiDichVu") != null) _apDungGoi = dr.GetBoolean("GoiDichVu");
            if (dr.GetString("mabhxh") != null) _mabhxh = dr.GetString("mabhxh");
            if (dr.GetString("tendt") != null) _tendt = dr.GetString("tendt");
            if (dr.GetDecimal("bhtra") != null) _bhtra = dr.GetDecimal("bhtra");
            if (dr.GetDecimal("sotienbhtra") != null) _sotienbhtra = dr.GetDecimal("sotienbhtra");
            if (dr.GetString("tenBV") != null) _tenBV = dr.GetString("tenBV");
            if (dr.GetString("maicdngt") != null) _maicdngt = dr.GetString("maicdngt");
            if (dr.GetString("tenbenhngt") != null) _tenbenhngt = dr.GetString("tenbenhngt");
            if (dr.GetString("mabsravien") != null) _mabsravien = dr.GetString("mabsravien");
            if (dr.GetString("tenbsravien") != null) _tenbsravien = dr.GetString("tenbsravien");
            if (dr.GetString("hoten") != null) _hoten = dr.GetString("hoten");
            if (dr.GetByte("tuoi") != null) _tuoi = dr.GetByte("tuoi");
            if (dr.GetByte("dattoan") != null) _dattoan = dr.GetByte("dattoan");
            if (dr.GetSmartDate("ngaySinh", true) != null) _ngaySinh = dr.GetSmartDate("ngaySinh", true);
            if (dr.GetSmartDate("ngayhuongbh", true) != null) _ngayhuongbh = dr.GetSmartDate("ngayhuongbh", true);
            if (dr.GetString("diaChi") != null) _diaChi = dr.GetString("diaChi");
            if (dr.GetBoolean("gt") != null) _gt = dr.GetBoolean("gt");
            if (dr.GetBoolean("taibienthuoc") != null) _taibienThuoc = dr.GetBoolean("taibienthuoc");
            if (dr.GetBoolean("taibienpt") != null) _taibienPT = dr.GetBoolean("taibienpt");
            if (dr.GetBoolean("taibientt") != null) _taibienTT = dr.GetBoolean("taibientt");
            if (dr.GetBoolean("hoichan") != null) _hoichan = dr.GetBoolean("hoichan");
            if (dr.GetBoolean("daks") != null) _daks = dr.GetBoolean("daks");
            if (dr.GetString("tenNguoiLap") != null) _tenNguoiLap = dr.GetString("tenNguoiLap");
            if (dr.GetString("tenNguoiSD") != null) _tenNguoiSD = dr.GetString("tenNguoiSD");
            if (dr.GetString("tenNguoiHuy") != null) _tenNguoiHuy = dr.GetString("tenNguoiHuy");
            if (dr.GetString("tenKhoaHT") != null) _tenKhoaHT = dr.GetString("tenKhoaHT");
            //if (dr.GetDecimal("tongtien") != null) _tongtien = dr.GetDecimal("tongtien");
            if (dr.GetSmartDate("NgayRaVien", true) != null) _ngayRaVien = dr.GetSmartDate("NgayRaVien", true);
            if (dr.GetString("MaBALienQuan") != null) _maBALienQuan = dr.GetString("MaBALienQuan");
            if (dr.GetDecimal("giatrimaxktc") != null) _giatrimaxktc = dr.GetDecimal("giatrimaxktc");
        
		}
		
		/// <summary>
		/// Insert the new <see cref="BenhAn" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            //MarkAsChild();
            ValidationRules.CheckRules();
            //MarkOld();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn
			// Copy & paste ham duoi day vao file DataProvider.cs
            _maBA = DataProvider.Instance().InsertBenhAn(_maBN, _noiTT, _maDT, _sothe, _giatriDN, _maBV, _maTinh, _ngayKT, _ngayduyet, _nguoiduyet, _ngayQT, _ngayQTTT, _nguoiQT, _maBenhNoiGT, _maNoiGT, _cDNoiGT, _ghichu, _cungtra, _ck, _nguoiSD, _maMay, _ngayVV, _maKhoa_HT, _apDungGoi, _ngayhuongbh, _giaTriTN, _maLoaiBA, _maBALienQuan, _maBAQL);
			// public abstract String InsertBenhAn(String _maBN, String _maDT, String _sothe, SmartDate _giatriDN, String _maBV, String _maTinh, SmartDate _ngayKT, SmartDate _ngayduyet, String _nguoiduyet, SmartDate _ngayQT, SmartDate _ngayQTTT, String _nguoiQT, String _maBenhNoiGT, String _maNoiGT, String _cDNoiGT, String _ghichu, Boolean _cungtra, Decimal _ck, String _nguoiLap, SmartDate _ngayVV, String _maKhoa_HT);
			// public override String InsertBenhAn(String _maBN, String _maDT, String _sothe, SmartDate _giatriDN, String _maBV, String _maTinh, SmartDate _ngayKT, SmartDate _ngayduyet, String _nguoiduyet, SmartDate _ngayQT, SmartDate _ngayQTTT, String _nguoiQT, String _maBenhNoiGT, String _maNoiGT, String _cDNoiGT, String _ghichu, Boolean _cungtra, Decimal _ck, String _nguoiLap, SmartDate _ngayVV, String _maKhoa_HT)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Create", _maBN, _maDT, _sothe, _giatriDN.DBValue, _maBV, _maTinh, _ngayKT.DBValue, _ngayduyet.DBValue, _nguoiduyet, _ngayQT.DBValue, _ngayQTTT.DBValue, _nguoiQT, _maBenhNoiGT, _maNoiGT, _cDNoiGT, _ghichu, _cungtra, _ck, _nguoiSD , _ngayVV.DBValue, _maKhoa_HT));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAn" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn
			//if (IsDirty){
            _soPhieuTTRV = DataProvider.Instance().UpdateBenhAn(_maBA, _maBN, _maDT, _sothe, _giatriDN, _maBV, _maTinh, _ngayKT, _ngayduyet, _nguoiduyet, _ngayQT, _ngayQTTT, _nguoiQT, _maBenhNoiGT, _maNoiGT, _cDNoiGT, _ghichu, _cungtra, _ck, _nguoiSD, _maMay, _huy, _ngayVV, _apDungGoi, _ngayhuongbh, _giaTriTN, _ngayRaVien, _maLoaiBA, _raVien, _mabsravien, _maBALuu, _daks, _maBALienQuan, _maBAQL, _taibienThuoc, _taibienPT, _taibienTT, _hoichan);
				// public abstract void UpdateBenhAn(String _maBA, String _maBN, String _maDT, String _sothe, SmartDate _giatriDN, String _maBV, String _maTinh, SmartDate _ngayKT, SmartDate _ngayduyet, String _nguoiduyet, SmartDate _ngayQT, SmartDate _ngayQTTT, String _nguoiQT, String _maBenhNoiGT, String _maNoiGT, String _cDNoiGT, String _ghichu, Boolean _cungtra, Decimal _ck, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngaySD, String _nguoiSD, String _maMay, Boolean _huy, String _nguoiHuy, SmartDate _ngayHuy, SmartDate _ngaySD1, String _nguoiSD1, SmartDate _ngayVV, String _soPhieuTTRV, String _maBALuu, Boolean _raVien, String _maKhoa_HT);
				// public override void UpdateBenhAn(String _maBA, String _maBN, String _maDT, String _sothe, SmartDate _giatriDN, String _maBV, String _maTinh, SmartDate _ngayKT, SmartDate _ngayduyet, String _nguoiduyet, SmartDate _ngayQT, SmartDate _ngayQTTT, String _nguoiQT, String _maBenhNoiGT, String _maNoiGT, String _cDNoiGT, String _ghichu, Boolean _cungtra, Decimal _ck, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngaySD, String _nguoiSD, String _maMay, Boolean _huy, String _nguoiHuy, SmartDate _ngayHuy, SmartDate _ngaySD1, String _nguoiSD1, SmartDate _ngayVV, String _soPhieuTTRV, String _maBALuu, Boolean _raVien, String _maKhoa_HT)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Update", _maBA, _maBN, _maDT, _sothe, _giatriDN.DBValue, _maBV, _maTinh, _ngayKT.DBValue, _ngayduyet.DBValue, _nguoiduyet, _ngayQT.DBValue, _ngayQTTT.DBValue, _nguoiQT, _maBenhNoiGT, _maNoiGT, _cDNoiGT, _ghichu, _cungtra, _ck, _nguoiSD , _maMay, _huy, _ngayVV.DBValue);
				// }				
			//}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maBA));
		}

		/// <summary>
		/// Delete the <see cref="BenhAn" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn
            DataProvider.Instance().DeleteBenhAn(crit.MaMay, crit.NguoiSD, crit.MaBA);
			// public abstract void DeleteBenhAn(String _maBA);
			// public override void DeleteBenhAn(String _maBA);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Deleted", _maBA);
			// }
		}

		#endregion
	}

}
