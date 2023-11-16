// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	KhamBenh_Q
// Kieu doi tuong  :	KhamBenh_Q
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	3/23/2009 3:09:20 PM
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
using System.Transactions;
namespace HTC.Business.PhongKham
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="KhamBenh_Q" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class KhamBenh_Q : BusinessBase<KhamBenh_Q>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maSoKham = String.Empty;
		private String _maBN = String.Empty;
		private String _maDT = String.Empty;
		private String _sothe = String.Empty;
		private SmartDate _giatriDN = new SmartDate(true);
		private String _maBV = String.Empty;
        private String _mabhxh = String.Empty;
        private String _tenbv = String.Empty;
        private Decimal _bhtra = 0;
        private Decimal _sotienbhtra = 0;  
		private String _maTinh = String.Empty;
		private SmartDate _ngayKT = new SmartDate(true);
		private String _gio = String.Empty;
		private SmartDate _ngayduyet = new SmartDate(true);
		private String _nguoiduyet = String.Empty;
		private SmartDate _ngayQT = new SmartDate(true);
		private SmartDate _ngayQTTT = new SmartDate(true);
		private String _nguoiQT = String.Empty;
		private String _maBenhNoiGT = String.Empty;
        private String _maicdngt = String.Empty;
        private String _tenbenhngt = String.Empty;
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
        private String _nguoiHuy = String.Empty;
		private SmartDate _ngayHuy = new SmartDate(true);
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
		private String _dienThoai = String.Empty;
		private String _diaChi = String.Empty;
        public String _sosohd = String.Empty;
        public String _sohd = String.Empty;
        public Decimal _TongTien = 0;
        public  Decimal _TongBHTra = 0;
        public Decimal _TongBHKTra = 0;
        public  Decimal _TongTienBH = 0;
        public Decimal _TongTienTT = 0;
        public  Decimal _TongTienTTCTT = 0;
        public  Decimal _TongBHTraCTT = 0;
        public  Decimal _TongTienBHCTT = 0;
        public Decimal _TongTienTTDTT = 0;
        public Decimal _TongBHTraDTT = 0;
        public Decimal _TongTienBHDTT = 0;
        public Decimal _TongTienTTDTTKTra = 0;
        public Decimal _TongThanhToan = 0;
        public Decimal _TongTraLaiBN = 0;
        public Decimal _TongHD = 0;
        public Decimal _TongTienCTT = 0;
        public Decimal _TongTienHoaDon = 0;
        private SmartDate _ngayDK = new SmartDate(true);
        private Byte _loai = 0;
        private int _OrderNumber;
        public String _sophieuttrv = String.Empty;
        private SmartDate _giaTriTN = new SmartDate(true);
        public Decimal _TongSac = 0;
        public Decimal _TongThuHoaDon = 0;
        //private decimal _bhtrat;
        //private decimal _sotienbhtrat; 
		#endregion
		
		#region Business Properties and Methods
        public string TongSac
        {
            get
            {
                CanReadProperty("TongSac", true);

                return _TongSac.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TongSac", true);
                if (_TongSac.ToString() != value)
                {
                    _TongSac = decimal.Parse(value);
                    PropertyHasChanged("TongSac");
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
        public String sosohd
        {
            get
            {
                CanReadProperty("sosohd", true);
                return _sosohd;
            }
            set
            {
                CanWriteProperty("sosohd", true);
                if (_sosohd != value)
                {
                    _sosohd = value;
                    PropertyHasChanged("sosohd");
                }
            }
        }
        public String sohd
        {
            get
            {
                CanReadProperty("sohd", true);
                return _sohd;
            }
            set
            {
                CanWriteProperty("sohd", true);
                if (_sohd != value)
                {
                    _sohd = value;
                    PropertyHasChanged("sohd");
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
        public String sophieuttrv
        {
            get
            {
                CanReadProperty("sophieuttrv", true);
                return _sophieuttrv;
            }
            set
            {
                CanWriteProperty("sophieuttrv", true);
                if (_sophieuttrv != value)
                {
                    _sophieuttrv = value;
                    PropertyHasChanged("sophieuttrv");
                }
            }
        }
        public String tenbv
        {
            get
            {
                CanReadProperty("tenbv", true);
                return _tenbv;
            }
            set
            {
                CanWriteProperty("tenbv", true);
                if (_tenbv != value)
                {
                    _tenbv = value;
                    PropertyHasChanged("tenbv");
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
		
		public String Gio
		{
			get 
			{
				CanReadProperty("Gio", true);
				return _gio;
			}
			set 
			{
				CanWriteProperty("Gio", true);
				if (_gio != value) 
				{
					_gio = value;
					PropertyHasChanged("Gio");
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
        //        //CanReadProperty("TongTien", true);
        //        return _TongTien;
        //    }
        //    set
        //    {
        //        //CanWriteProperty("TongTien", true);
        //        if (_TongTien != value)
        //        {
        //            _TongTien = value;
        //            PropertyHasChanged("TongTien");
        //        }
        //    }
        //}

        //public Decimal TongBHTra
        //{
        //    get
        //    {
        //        CanReadProperty("TongBHTra", true);
        //        return _TongBHTra;
        //    }
        //    set
        //    {
        //        CanWriteProperty("TongBHTra", true);
        //        if (_TongBHTra != value)
        //        {
        //            _TongBHTra = value;
        //            PropertyHasChanged("TongBHTra");
        //        }
        //    }
        //}

        //public Decimal TongTienBH
        //{
        //    get
        //    {
        //        CanReadProperty("TongTienBH", true);
        //        return _TongTienBH;
        //    }
        //    set
        //    {
        //        CanWriteProperty("TongTienBH", true);
        //        if (_TongTienBH != value)
        //        {
        //            _TongTienBH = value;
        //            PropertyHasChanged("TongTienBH");
        //        }
        //    }
        //}

        //public Decimal TongTienTTCTT
        //{
        //    get
        //    {
        //        CanReadProperty("TongTienCTT", true);
        //        return _TongTienTTCTT;
        //    }
        //    set
        //    {
        //        CanWriteProperty("TongTienCTT", true);
        //        if (_TongTienTTCTT != value)
        //        {
        //            _TongTienTTCTT = value;
        //            PropertyHasChanged("TongTienCTT");
        //        }
        //    }
        //}

        //public Decimal TongTienBHTraCTT
        //{
        //    get
        //    {
        //        CanReadProperty("TongBHTraCTT", true);
        //        return _TongBHTraCTT;
        //    }
        //    set
        //    {
        //        CanWriteProperty("TongBHTraCTT", true);
        //        if (_TongBHTraCTT != value)
        //        {
        //            _TongBHTraCTT = value;
        //            PropertyHasChanged("TongBHTraCTT");
        //        }
        //    }
        //}

        //public Decimal TongTienBHCTT
        //{
        //    get
        //    {
        //        CanReadProperty("TongTienBHCTT", true);
        //        return _TongTienBHCTT;
        //    }
        //    set
        //    {
        //        CanWriteProperty("TongTienBHCTT", true);
        //        if (_TongTienBHCTT != value)
        //        {
        //            _TongTienBHCTT = value;
        //            PropertyHasChanged("TongTienBHCTT");
        //        }
        //    }
        //}

        //public Decimal TongTienDTT
        //{
        //    get
        //    {
        //        CanReadProperty("TongTienDTT", true);
        //        return _TongTienTTDTT;
        //    }
        //    set
        //    {
        //        CanWriteProperty("TongTienDTT", true);
        //        if (_TongTienTTDTT != value)
        //        {
        //            _TongTienTTDTT = value;
        //            PropertyHasChanged("TongTienDTT");
        //        }
        //    }
        //}

        //public Decimal TongTienBHTraDTT
        //{
        //    get
        //    {
        //        CanReadProperty("TongBHTraDTT", true);
        //        return _TongBHTraDTT;
        //    }
        //    set
        //    {
        //        CanWriteProperty("TongBHTraDTT", true);
        //        if (_TongBHTraDTT != value)
        //        {
        //            _TongBHTraDTT = value;
        //            PropertyHasChanged("TongBHTraDTT");
        //        }
        //    }
        //}

        public Decimal TongTienBHDTT
        {
            get
            {
                CanReadProperty("TongTienBHDTT", true);
                return _TongTienBHDTT;
            }
            set
            {
                CanWriteProperty("TongTienBHDTT", true);
                if (_TongTienBHDTT != value)
                {
                    _TongTienBHDTT = value;
                    PropertyHasChanged("TongTienBHDTT");
                }
            }
        }
        //public Decimal TongTienTT
        //{
        //    get
        //    {
        //        CanReadProperty("TongTienTT", true);
        //        return _TongTienTT;
        //    }
        //    set
        //    {
        //        CanWriteProperty("TongTienTT", true);
        //        if (_TongTienTT != value)
        //        {
        //            _TongTienTT = value;
        //            PropertyHasChanged("TongTienTT");
        //        }
        //    }
        //}
      
            public string TongBHKTra
        {
            get
            {
                CanReadProperty("TongBHKTra", true);

                return _TongBHKTra.ToString() ;
            }
            set
            {
                CanWriteProperty("TongBHKTra", true);
                if (_TongBHKTra.ToString()  != value)
                {
                    _TongBHKTra  = decimal.Parse(value);
                    PropertyHasChanged("TongBHKTra");
                }
            }
        }
        public string TongThanhToan
        {
            get
            {
                CanReadProperty("TongThanhToan", true);

                return _TongThanhToan.ToString("###,###") ;
            }
            set
            {
                CanWriteProperty("TongThanhToan", true);
                if (_TongThanhToan.ToString()  != value)
                {
                    _TongThanhToan  = decimal.Parse(value);
                    PropertyHasChanged("TongThanhToan");
                }
            }
        }
        public string TongHD
        {
            get
            {
                CanReadProperty("TongHD", true);

                return _TongHD.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TongHD", true);
                if (_TongHD.ToString() != value)
                {
                    _TongHD = decimal.Parse(value);
                    PropertyHasChanged("TongHD");
                }
            }
        }
        public string TongTraLaiBN
        {
            get
            {
                CanReadProperty("TongTraLaiBN", true);
                if (_TongThanhToan >= 0)
                    _TongTraLaiBN = 0;

                else
                    _TongTraLaiBN = 0 - _TongThanhToan;
               
                    return _TongTraLaiBN.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TongTraLaiBN", true);
                if (_TongTraLaiBN.ToString() != value)
                {
                    _TongTraLaiBN = decimal.Parse(value);
                    PropertyHasChanged("TongTraLaiBN");
                }
            }
        }
        public string TongTienCTT
        {
            get
            {
                CanReadProperty("TongTienCTT", true);
                return _TongTienCTT.ToString("###,###")  ;
            }
            set
            {
                CanWriteProperty("TongTienCTT", true);
              
                if (_TongTienCTT.ToString()  != value)
                {
                    _TongTienCTT  = decimal.Parse(value) ;
                    PropertyHasChanged("TongTienCTT");
                }
            }
        }
    
        //public Decimal TongBHKTra
        //{
        //    get
        //    {
        //        CanReadProperty("TongBHKTra", true);
        //        return _TongBHKTra;
        //    }
        //    set
        //    {
        //        CanWriteProperty("TongBHKTra", true);
        //        if (_TongBHKTra != value)
        //        {
        //            _TongBHKTra = value;
        //            PropertyHasChanged("TongBHKTra");
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
        public Byte loai
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _loai;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_loai.Equals(value))
                {
                    _loai = value;
                    //PropertyHasChanged();
                }
            }
        }

      

       
      
       
        KhamBenh_ThuocSDList _KhamBenh_ThuocSDList = KhamBenh_ThuocSDList.NewKhamBenh_ThuocSDList();

        public KhamBenh_ThuocSDList KhamBenh_ThuocSDList
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _KhamBenh_ThuocSDList;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_KhamBenh_ThuocSDList.Equals(value))
                {
                    _KhamBenh_ThuocSDList = value;
                    PropertyHasChanged();
                }
            }
        }
        KhamBenh_VTTHList _KhamBenh_VTTHList = KhamBenh_VTTHList.NewKhamBenh_VTTHList();

        public KhamBenh_VTTHList KhamBenh_VTTHList
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _KhamBenh_VTTHList;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_KhamBenh_VTTHList.Equals(value))
                {
                    _KhamBenh_VTTHList = value;
                    PropertyHasChanged();
                }
            }
        }
        KhamBenh_ThuocSD_DYList _KhamBenh_ThuocSD_DYList = KhamBenh_ThuocSD_DYList.NewKhamBenh_ThuocSD_DYList();

        public KhamBenh_ThuocSD_DYList KhamBenh_ThuocSD_DYList
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _KhamBenh_ThuocSD_DYList;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_KhamBenh_ThuocSD_DYList.Equals(value))
                {
                    _KhamBenh_ThuocSD_DYList = value;
                    PropertyHasChanged();
                }
            }
        }
        KhamBenh_HoaDonList _KhamBenh_HoaDonList = KhamBenh_HoaDonList.NewKhamBenh_HoaDonList();

        public KhamBenh_HoaDonList KhamBenh_HoaDonList
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _KhamBenh_HoaDonList;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_KhamBenh_HoaDonList.Equals(value))
                {
                    _KhamBenh_HoaDonList = value;
                    PropertyHasChanged();
                }
            }
        }

       
        KhamBenh_GetsDichVuList _KhamBenh_GetsDichVuCTTList = KhamBenh_GetsDichVuList.NewKhamBenh_GetsDichVuList();
        public KhamBenh_GetsDichVuList KhamBenh_GetsDichVuCTTList
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _KhamBenh_GetsDichVuCTTList;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_KhamBenh_GetsDichVuList.Equals(value))
                {
                    _KhamBenh_GetsDichVuCTTList = value;
                    PropertyHasChanged();
                }
            }
        }
        KhamBenh_GetsDichVuList _KhamBenh_GetsDichVuList = KhamBenh_GetsDichVuList.NewKhamBenh_GetsDichVuList();
        public KhamBenh_GetsDichVuList KhamBenh_GetsDichVuList
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _KhamBenh_GetsDichVuList;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_KhamBenh_GetsDichVuList.Equals(value))
                {
                    _KhamBenh_GetsDichVuList = value;
                    PropertyHasChanged();
                }
            }
        }
		protected override Object GetIdValue()
		{
			return _maSoKham;
		}

        public override bool IsDirty
        {
            get
            {

                return base.IsDirty || _KhamBenh_HoaDonList.IsDirty || _KhamBenh_ThuocSDList.IsDirty || _KhamBenh_ThuocSD_DYList.IsDirty;
                
            }
        }

        public override bool IsValid
        {
            get
            {

                return base.IsValid && _KhamBenh_HoaDonList.IsValid && _KhamBenh_ThuocSDList.IsValid && _KhamBenh_ThuocSD_DYList.IsValid;
               
            }
        }

		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="KhamBenh_Q" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static KhamBenh_Q NewKhamBenh()
        {
            //return new DMNhomThuoc();
            return DataPortal.Create<KhamBenh_Q>();
        }
        public static KhamBenh_Q GetKhamBenh(String maSoKham, Byte loai, Byte DATTTT, DateTime ngayyc, string dk, byte loaikqcn)
		{

            return DataPortal.Fetch<KhamBenh_Q>(new Criteria(maSoKham, loai, DATTTT, ngayyc, dk, loaikqcn));
		}

        public static KhamBenh_Q FindKhamBenh(String mabn,DateTime ngaydk, string dk,Byte loai,byte loaikqcn, byte loaikq, string makhoa)
		{
            return DataPortal.Fetch<KhamBenh_Q>(new FindCriteria(mabn, ngaydk, dk, loai, loaikqcn, loaikq, makhoa));
		}
        public static KhamBenh_Q FindKhamBenh(String mabn, DateTime ngaydk, string dk, Byte loai, byte loaikqcn)
        {
            return DataPortal.Fetch<KhamBenh_Q>(new FindCriteria(mabn, ngaydk, dk, loai, loaikqcn, 0,""));
        }
        public static void  ChangeKhamBenhDT(String maSoKham, string MaDT, byte loai)
        {
            //DataPortal.Execute<CommandBase>(new CommandBase(maSoKham, MaDT, loai, ""));
            DataProvider.Instance().KhamBenh_TINHLAIDT (maSoKham, MaDT, loai, "");
        }
      
       public static KhamBenh_Q GetKhamBenh(SafeDataReader dr,Byte loai,byte loaikqcn)
        {
            KhamBenh_Q obj = new KhamBenh_Q();
            obj.Fetch(dr,loai,"",loaikqcn,0,"" );
            return obj;
        }
		/// <summary>
		/// Marks the <see cref="KhamBenh_Q" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
		public static void DeleteKhamBenh(String maSoKham,Byte loai,Byte DATTTT,DateTime ngayyc,String dk)
		{
            DataPortal.Delete(new Criteria( maSoKham,loai,DATTTT,ngayyc,dk,1));
		}
        public static void UpdateKhamBenh(String maSoKham, Byte loai, Byte DATTTT, DateTime ngayyc, String dk)
        {
            DataPortal.Update(new Criteria(maSoKham, loai, DATTTT, ngayyc, dk,1));
        }
        public static void InsertKhamBenh(String maSoKham, Byte loai, Byte DATTTT, DateTime ngayyc, String dk)
        {
             //DataPortal.Insert(new Criteria(maSoKham, loai, DATTTT, ngayyc, dk));
        }
    
       #endregion
		
       
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        

        protected internal KhamBenh_Q()
		{	
			// Prevent direct creation
            
		}
        internal KhamBenh_Q(   int OrderNumber,
                             String maSoKham ,
		                     String maBN ,
		                     String maDT ,
		                     String sothe ,
		                     SmartDate giatriDN ,
		                     String maBV ,
		                     String maTinh ,
		                     SmartDate ngayKT ,
		                     String gio ,
		                     SmartDate ngayduyet ,
		                     String nguoiduyet ,
		                     SmartDate ngayQT ,
		                     SmartDate ngayQTTT ,
		                     String nguoiQT ,
		                     String maBenhNoiGT ,
		                     String maNoiGT ,
		                     String cDNoiGT ,
		                     String ghichu ,
		                     Byte loaiKham,
		                     Boolean cungtra ,
		                     Decimal ck ,
		                     SmartDate ngayLap  ,
		                     String nguoiLap  ,
		                     SmartDate ngaySD  ,
		                     String nguoiSD ,
		                     String maMay ,
		                     Boolean huy ,
                             String nguoiHuy,
		                     SmartDate ngayHuy ,
		                     SmartDate ngaySD1 ,
		                     String nguoiSD1 ,
		                     String dienThoai ,
		                     String diaChi,
                             Decimal tongTien , 
                             Decimal tongBHTra ,
                             Decimal tongTienBH,
                             string mabhxh,
                             decimal bhtra,
                             decimal sotienbhtra,
                             string tenbv,
                             SmartDate ngaydk,
                             SmartDate giatriTN, string mabaql, string tendt, string madonvi
 , string maquanham
 , string maquanheqd
 , string socmt
   )
        {
                                _OrderNumber = OrderNumber;
                                _maBN = maBN;
                                _maSoKham = maSoKham;
                
		                      _maDT = maDT  ;
		                      _sothe = sothe ;
		                      _giatriDN = giatriDN  ;
		                      _maBV = maBV  ;
		                      _maTinh = maTinh  ;
		                      _ngayKT = ngayKT  ;
		                      _gio = gio  ;
		                      _ngayduyet = ngayduyet  ;
		                      _nguoiduyet = nguoiduyet  ;
		                      _ngayQT = ngayQT  ;
		                      _ngayQTTT = ngayQTTT  ;
		                      _nguoiQT = nguoiQT  ;
		                      _maBenhNoiGT = maBenhNoiGT  ;
		                      _maNoiGT = maNoiGT  ;
		                      _cDNoiGT = cDNoiGT  ;
		                      _ghichu  = ghichu ;
		                      _loaiKham = loaiKham ;
		                      _cungtra = cungtra  ;
		                      _ck = ck  ;
		                      _ngayLap = ngayLap   ;
		                      _nguoiLap = nguoiLap   ;
		                      _ngaySD = ngaySD  ;
		                      _nguoiSD = nguoiSD  ;
		                      _maMay = maMay  ;
		                      _huy = huy  ;
		                      _nguoiHuy = nguoiHuy  ;
		                      _ngayHuy = ngayHuy  ;
		                      _ngaySD1 = ngaySD1  ;
		                      _nguoiSD1 = nguoiSD1  ;
		                      _dienThoai = dienThoai  ;
		                      _diaChi = diaChi  ;
                              _TongTien = tongTien;
                              _TongBHTra = tongBHTra;
                              _TongTienBH = tongTienBH;
                               _mabhxh= mabhxh;
                              _bhtra = bhtra;
                              _sotienbhtra = sotienbhtra;
                              _tenbv = tenbv;
                              _ngayDK = ngaydk;
                              _giaTriTN = giatriTN ;
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
            private Byte  _loai;
            public Byte loai
            {
                get
                {
                    return _loai;
                }
            }
            private Byte _loaikqcn;
            public Byte loaikqcn
            {
                get
                {
                    return _loaikqcn;
                }
            }
            private Byte _DATTTT;
            public Byte DATTTT
            {
                get
                {
                    return _DATTTT;
                }
            }
            private DateTime _ngayyc;
            public DateTime ngayyc
            {
                get
                {
                    return _ngayyc;
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
			public Criteria(String MaSoKham,Byte loai,Byte DATTTT,DateTime ngayyc,string dk,byte loaikqcn)
            {
                _maSoKham = MaSoKham;
              
                _loai = loai;
                _DATTTT = DATTTT;
                _ngayyc = ngayyc;
                _dk = dk;
                _loaikqcn = loaikqcn; 
            }
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maSoKham.Equals(c._maSoKham)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maSoKham.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maSoKham;
            public String MaSoKham
            {
                get
                {
                    return _maSoKham;
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
            private String _dk;
            public String dk
            {
                get
                {
                    return _dk;
                }
            }
            private Byte _loai;
            public Byte loai
            {
                get
                {
                    return _loai;
                }
            }
            private Byte _DATTTT;
            public Byte DATTTT
            {
                get
                {
                    return _DATTTT;
                }
            }
            private DateTime  _ngayyc;
            public DateTime ngayyc
            {
                get
                {
                    return _ngayyc;
                }
            }
            public OtherCriteria( String MaSoKham,Byte loai,Byte DATTTT,DateTime ngayyc,string dk)
            {
                _maSoKham = MaSoKham;
                
                _loai = loai;
                _DATTTT = DATTTT;
                _ngayyc = ngayyc;
                _dk = dk;
            }
        }
        [Serializable()]
   
        protected class FindCriteria
        {
            private String _mabn;
            public String Mabn
            {
                get
                {
                    return _mabn;
                }
            }
            private String _makhoa;
            public String Makhoa
            {
                get
                {
                    return _makhoa;
                }
            }
            private Byte _DATTTT;
            public Byte DATTTT
            {
                get
                {
                    return _DATTTT;
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
           
            private DateTime _ngaydk;
            public DateTime ngaydk
            {
                get
                {
                    return _ngaydk;
                }
            }
          
            private Byte _loai;
            public Byte loai
            {
                get
                {
                    return _loai;
                }
            }
            private Byte _loaikqcn;
            public Byte loaikqcn
            {
                get
                {
                    return _loaikqcn;
                }
            }
            private Byte _loaikq;
            public Byte loaikq
            {
                get
                {
                    return _loaikq;
                }
            }
             private Boolean _qadmin = false ;
            public Boolean qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public FindCriteria(String Mabn, DateTime ngaydk, string dk, Byte loai, byte loaikqcn, byte loaikq,string makhoa)
            {
                _mabn = Mabn;          
                _ngaydk = ngaydk;
                _dk = dk;
                _loai = loai;
                _loaikqcn =loaikqcn ;
                _loaikq = loaikq;
                _makhoa = makhoa ;
                
            }
        }
        [Serializable()]

        protected class CriteriaTL
        {
      
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
		/// Retrieve an existing <see cref="KhamBenh_Q" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetKhamBenh(String _maSoKham);
			// public override IDataReader GetKhamBenh(String _maSoKham)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maSoKham));
			// }
            _TongTien = 0;
            _TongBHTra = 0;
            _TongTienBH = 0;
            _TongTienTT = 0;
            _TongTienBHCTT = 0;
            _TongTienTTCTT = 0;
            _TongBHTraCTT = 0;
            _TongTienBHDTT = 0;
            _TongTienTTDTT = 0;
            _TongBHTraDTT = 0;
            _TongTienTTCTT = 0;
           
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKhamBenh(crit.MaSoKham,crit.loai)))
			{
				if (dr.Read()){
                     //String _masokhamt = dr.GetString("masokham");
                     //_bhtrat = dr.GetDecimal("BHtra");
                     //_sotienbhtrat = dr.GetDecimal("SotienbhTra");
					Fetch(dr,crit.loai,crit.dk,crit.loaikqcn, 0,"" );
                    //if (dr.NextResult())
                    //{
                    //    _KhamBenh_C_List = KhamBenh_C_List.GetKhamBenh_C_List(dr);
                    //    _TongTienBHCTT = _TongTienBHCTT + _KhamBenh_C_List._TongBHCTT;
                    //    _TongTienBHDTT = _TongTienBHDTT + _KhamBenh_C_List._TongBH;
                    //    _TongTienBH = _TongTienBH + _TongTienBHCTT + _TongTienBHDTT;
                    //    _TongTienTTCTT = _TongTienTTCTT + _KhamBenh_C_List._TongTTCTT;
                    //    _TongTienTTDTT = _TongTienTTDTT + _KhamBenh_C_List._TongTT;
                    //    _TongTienTT = _TongTienTT + _TongTienTTCTT + _TongTienTTDTT;
                    //}
                    //if (crit.loai != 3)
                    //{
                    //    if (dr.NextResult())
                    //    {
                    //        _KhamBenh_ThuocSDList = KhamBenh_ThuocSDList.GetKhamBenh_ThuocSDList(dr);
                    //        _TongTienBHCTT = _TongTienBHCTT + _KhamBenh_ThuocSDList._TongBHCTT;
                    //        _TongTienBHDTT = _TongTienBHDTT + _KhamBenh_ThuocSDList._TongBH;
                    //        _TongTienBH = _TongTienBH + _TongTienBHCTT + _TongTienBHDTT;
                    //        _TongTienTTCTT = _TongTienTTCTT + _KhamBenh_ThuocSDList._TongTTCTT;
                    //        _TongTienTTDTT = _TongTienTTDTT + _KhamBenh_ThuocSDList._TongTT  ;
                    //        _TongTienTT = _TongTienTT + _TongTienTTCTT + _TongTienTTDTT;
                           
                            
                    //    }
                    //    if (dr.NextResult())
                    //    {
                    //        _KhamBenh_MauList = KhamBenh_MauList.GetKhamBenh_MauList(dr);
                    //    }
                    //    if (dr.NextResult())
                    //    {
                    //        _KhamBenh_VTTHList = KhamBenh_VTTHList.GetKhamBenh_VTTHList(dr);
                    //    }
                    //}
                   
                    //// loai = 0 : tiep don , loai = 1 : vien phi, loai = 2 : kham benh , loai = 3 : can lam sang
                    //if ((crit.loai == 0) || (crit.loai ==  1)) 
                    //{
                       
                    //        _KhamBenh_GetsDichVuCTTList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_masokhamt,0, crit.ngayyc,crit.loai,   crit.dk); 
                    
                    //        _KhamBenh_GetsDichVuList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_masokhamt, 1, crit.ngayyc, crit.loai, crit.dk);
                       
                    //}
                    //MarkOld();
                    //ValidationRules.CheckRules();

				}
               // dr.Close();
			}
            //_TongTien = _TongTienBH + _TongTienTT;
            //if  (_TongTienBH <=_sotienbhtrat)
            //    _TongBHTra = _TongTienBH ;
            //else
            //    _TongBHTra = ((_TongTienBH ) * _bhtrat) / decimal.Parse("100")   ;
            //_TongBHKTra = TongTienBH - TongBHTra; 
           
            //if (_TongTienBHDTT  <= _sotienbhtrat)
            //    _TongBHTraDTT  = _TongTienBHDTT;
            //else
            //    _TongBHTraDTT = ((_TongTienBHDTT ) * _bhtrat) / decimal.Parse("100") ;
            //_TongThanhToan = _TongBHKTra - (_TongTienBHDTT - _TongBHTraDTT) + _TongTienTTCTT;
            //_TongTienCTT = _TongTienBHCTT + _TongTienTTCTT;
		}
        protected void DataPortal_Fetch(FindCriteria crit)
        {
            // public abstract IDataReader GetKhamBenh(String _maSoKham);
            // public override IDataReader GetKhamBenh(String _maSoKham)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maSoKham));
            // }
            
            _TongTien  = 0;
            _TongBHTra = 0;
            _TongTienBH = 0;
            _TongTienTT = 0;
            _TongTienBHCTT = 0;
            _TongTienTTCTT = 0;
            _TongBHTraCTT = 0;
            _TongTienBHDTT = 0;
            _TongTienTTDTT = 0;
            _TongBHTraDTT = 0;
            _TongTienTTCTT = 0;
          
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKhamBenh(crit.Mabn, crit.ngaydk ,crit.dk  , crit.loai,crit.loaikq,crit.qadmin     )))
            {
                if (dr.Read())
                {
                    //String _masokhamt = dr.GetString("masokham");
                    //_bhtrat = dr.GetDecimal("BHtra");
                    //_sotienbhtrat = dr.GetDecimal("SotienbhTra");
                    Fetch(dr,crit.loai,crit.dk,crit.loaikqcn,crit.loaikq  ,crit.Makhoa      );
                   
                    //if (crit.loai == 2)
                    //{
                    //    if (dr.NextResult())
                    //    {
                           
                    //        _KhamBenh_HoaDonList = KhamBenh_HoaDonList.GetKhamBenh_HoaDonList(dr);  
                    //    }
                    //}
                    //if (dr.NextResult())
                    //{
                    //    _KhamBenh_C_List = KhamBenh_C_List.GetKhamBenh_C_List(dr);
                    //    _TongTienBHCTT = _TongTienBHCTT + _KhamBenh_C_List._TongBHCTT;
                    //    _TongTienBHDTT = _TongTienBHDTT + _KhamBenh_C_List._TongBH;
                    //    _TongTienBH = _TongTienBH + _TongTienBHCTT + _TongTienBHDTT;
                    //    _TongTienTTCTT = _TongTienTTCTT + _KhamBenh_C_List._TongTTCTT;
                    //    _TongTienTTDTT = _TongTienTTDTT + _KhamBenh_C_List._TongTT;
                    //    _TongTienTT = _TongTienTT + _TongTienTTCTT + _TongTienTTDTT;
                    //}
                    //if (crit.loai != 4)
                    //{
                    //    if (dr.NextResult())
                    //    {
                    //        _KhamBenh_ThuocSDList = KhamBenh_ThuocSDList.GetKhamBenh_ThuocSDList(dr);
                    //        _TongTienBHCTT = _TongTienBHCTT + _KhamBenh_ThuocSDList._TongBHCTT;
                    //        _TongTienBHDTT = _TongTienBHDTT + _KhamBenh_ThuocSDList._TongBH;
                    //        _TongTienBH = _TongTienBH + _TongTienBHCTT + _TongTienBHDTT;
                    //        _TongTienTTCTT = _TongTienTTCTT + _KhamBenh_ThuocSDList._TongTTCTT;
                    //        _TongTienTTDTT = _TongTienTTDTT + _KhamBenh_ThuocSDList._TongTT;
                    //        _TongTienTT = _TongTienTT + _TongTienTTCTT + _TongTienTTDTT;


                    //    }
                    //    if (dr.NextResult())
                    //    {
                    //        _KhamBenh_MauList = KhamBenh_MauList.GetKhamBenh_MauList(dr);
                    //    }
                    //    if (dr.NextResult())
                    //    {
                    //        _KhamBenh_VTTHList = KhamBenh_VTTHList.GetKhamBenh_VTTHList(dr);
                    //    }
                    //}

                    //// loai = 1 : tiep don , loai = 2 : vien phi, loai = 3 : kham benh , loai = 4 : can lam sang
                    //if ((crit.loai == 1) || (crit.loai == 2))
                    //{
                       

                    //        _KhamBenh_GetsDichVuCTTList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_masokhamt, 0, crit.ngaydk, crit.loai, crit.dk);

                    //        _KhamBenh_GetsDichVuList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_masokhamt, 1, crit.ngaydk, crit.loai, crit.dk);

                        
                    //}
                    //MarkOld();
                    //ValidationRules.CheckRules();
                }
               // dr.Close();
               
            }
            //_TongTien = _TongTienBH + _TongTienTT;
            //if (_TongTienBH <= _sotienbhtrat)
            //    _TongBHTra = _TongTienBH;
            //else
            //    _TongBHTra = (_TongTienBH  * _bhtrat) / decimal.Parse("100") ;
            //_TongBHKTra = TongTienBH - TongBHTra;

            //if (_TongTienBHDTT <= _sotienbhtra)
            //    _TongBHTraDTT = _TongTienBHDTT;
            //else
            //    _TongBHTraDTT = ((_TongTienBHDTT ) * _bhtrat) / decimal.Parse("100") ;
            //_TongThanhToan = _TongBHKTra - (_TongTienBHDTT - _TongBHTraDTT) + _TongTienTTCTT;
            //_TongTienCTT = _TongTienBHCTT + _TongTienTTCTT;
        }
		/// <summary>
		/// Load a <see cref="KhamBenh_Q" /> Object from given SafeDataReader.
		/// </summary>
        private void Fetch(SafeDataReader dr, byte loaiphieu, string dk, Byte _loaikqcn, Byte _loaikq, string _makhoa)
		{
			// Value properties
          
                if (dr.GetString("MaSoKham") != null) _maSoKham = dr.GetString("MaSoKham");
                if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
                if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
                if (dr.GetString("Sothe") != null) _sothe = dr.GetString("Sothe");
                if (dr.GetSmartDate("GiatriDN", true) != null) _giatriDN = dr.GetSmartDate("GiatriDN", true);
              if (dr.GetSmartDate("GiatritN", true) != null) _giaTriTN = dr.GetSmartDate("GiatritN", true);
                if (dr.GetString("MaBV") != null) _maBV = dr.GetString("MaBV");
                if (dr.GetString("MaTinh") != null) _maTinh = dr.GetString("MaTinh");
                if (dr.GetSmartDate("NgayKT", true) != null) _ngayKT = dr.GetSmartDate("NgayKT", true);
                if (dr.GetString("Gio") != null) _gio = dr.GetString("Gio");
              
                if (dr.GetSmartDate("Ngayduyet", true) != null) _ngayduyet = dr.GetSmartDate("Ngayduyet", true);
                if (dr.GetString("Nguoiduyet") != null) _nguoiduyet = dr.GetString("Nguoiduyet");
                if (dr.GetSmartDate("NgayQT", true) != null) _ngayQT = dr.GetSmartDate("NgayQT", true);
                if (dr.GetSmartDate("NgayQTTT", true) != null) _ngayQTTT = dr.GetSmartDate("NgayQTTT", true);
                if (dr.GetString("NguoiQT") != null) _nguoiQT = dr.GetString("NguoiQT");
                if (dr.GetString("MaBenhNoiGT") != null) _maBenhNoiGT = dr.GetString("MaBenhNoiGT");
                if (dr.GetString("MaNoiGT") != null) _maNoiGT = dr.GetString("MaNoiGT");
                if (dr.GetString("CDNoiGT") != null) _cDNoiGT = dr.GetString("CDNoiGT");
                if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
                if (dr.GetByte("LoaiKham") != null) _loaiKham = dr.GetByte("LoaiKham");
                if (dr.GetBoolean("Cungtra") != null) _cungtra = dr.GetBoolean("Cungtra");
                if (dr.GetDecimal("CK") != null) _ck = dr.GetDecimal("CK");
                if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
                if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
                if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
                if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
                if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
                if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
                if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
                if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
                if (dr.GetSmartDate("ngaydk", true) != null) _ngayDK = dr.GetSmartDate("ngaydk", true);
                if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
                if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
                if (dr.GetString("DienThoai") != null) _dienThoai = dr.GetString("DienThoai");
                if (dr.GetString("DiaChi") != null) _diaChi = dr.GetString("DiaChi");
                if (dr.GetDecimal("TongTien") != null) _TongTien = dr.GetDecimal("tongTien");
                //if (dr.GetDecimal("TongTienBH") != null) _TongTienBH = dr.GetDecimal("tongTienBH");
                //if (dr.GetDecimal("TongBHTra") != null) _TongBHTra = dr.GetDecimal("TongBHTra");
                if (dr.GetDecimal("bhtra") != null) _bhtra = dr.GetDecimal("bhtra");
                if (dr.GetDecimal("sotienbhtra") != null) _sotienbhtra = dr.GetDecimal("sotienbhtra");
                if (dr.GetString("mabhxh") != null) _mabhxh = dr.GetString("mabhxh");
                if (dr.GetString("tenbv") != null) _tenbv = dr.GetString("tenbv");
                if (dr.GetString("tenbenhngt") != null) _tenbenhngt = dr.GetString("tenbenhngt");
                if (dr.GetString("maicdngt") != null) _maicdngt = dr.GetString("maicdngt");
                if (dr.GetString("sophieuttrv") != null) _sophieuttrv = dr.GetString("sophieuttrv");
                _TongTien = 0;
                _TongBHTra = 0;
                _TongTienBH = 0;
                _TongTienTT = 0;
                _TongTienBHCTT = 0;
                _TongTienTTCTT = 0;
                _TongBHTraCTT = 0;
                _TongTienBHDTT = 0;
                _TongTienTTDTT = 0;
                _TongBHTraDTT = 0;
                _TongTienTTCTT = 0;
                _TongTienTTDTTKTra = 0;
                 _loai = loaiphieu;
                    if (_loai == 2 || _loai ==7 || _loai ==9)
                    {
                        if (dr.NextResult())
                        {
                           _KhamBenh_HoaDonList = KhamBenh_HoaDonList.GetKhamBenh_HoaDonList(dr);
                           _TongHD = _KhamBenh_HoaDonList._TongTT;
                        }
                    }
               
                   

                  
                    if (_loai != 4 && _loai !=8)
                    {
                     
                        if (dr.NextResult())
                        {
                          
                            _KhamBenh_ThuocSDList = KhamBenh_ThuocSDList.GetKhamBenh_ThuocSDList(dr);
                          
                            //_TongTienBHCTT = _TongTienBHCTT + _KhamBenh_ThuocSDList._TongBHCTT;
                            //_TongTienBHDTT = _TongTienBHDTT + _KhamBenh_ThuocSDList._TongBH;
                            ////_TongTienBH = _TongTienBH + _TongTienBHCTT + _TongTienBHDTT;
                            //_TongTienTTCTT = _TongTienTTCTT + _KhamBenh_ThuocSDList._TongTTCTT;
                            //_TongTienTTDTT = _TongTienTTDTT + _KhamBenh_ThuocSDList._TongTT;
                            ////_TongTienTT = _TongTienTT + _TongTienTTCTT + _TongTienTTDTT;


                        }
                        if (dr.NextResult())
                        {
                            _KhamBenh_ThuocSD_DYList = KhamBenh_ThuocSD_DYList.GetKhamBenh_ThuocSD_DYList(dr);
                            //_TongTienBHCTT = _TongTienBHCTT + _KhamBenh_ThuocSDList._TongBHCTT;
                            //_TongTienBHDTT = _TongTienBHDTT + _KhamBenh_ThuocSDList._TongBH;
                            ////_TongTienBH = _TongTienBH + _TongTienBHCTT + _TongTienBHDTT;
                            //_TongTienTTCTT = _TongTienTTCTT + _KhamBenh_ThuocSDList._TongTTCTT;
                            //_TongTienTTDTT = _TongTienTTDTT + _KhamBenh_ThuocSDList._TongTT;
                            ////_TongTienTT = _TongTienTT + _TongTienTTCTT + _TongTienTTDTT;


                        }
                        if (dr.NextResult())
                        {
                            _KhamBenh_VTTHList = KhamBenh_VTTHList.GetKhamBenh_VTTHList(dr);
                            //_TongTienBHCTT = _TongTienBHCTT + _KhamBenh_ThuocSDList._TongBHCTT;
                            //_TongTienBHDTT = _TongTienBHDTT + _KhamBenh_ThuocSDList._TongBH;
                            ////_TongTienBH = _TongTienBH + _TongTienBHCTT + _TongTienBHDTT;
                            //_TongTienTTCTT = _TongTienTTCTT + _KhamBenh_ThuocSDList._TongTTCTT;
                            //_TongTienTTDTT = _TongTienTTDTT + _KhamBenh_ThuocSDList._TongTT;
                            ////_TongTienTT = _TongTienTT + _TongTienTTCTT + _TongTienTTDTT;


                        }
                        //if (dr.NextResult())
                        //{
                        //    _KhamBenh_ThuocSD_DYList = KhamBenh_ThuocSD_DYList.GetKhamBenh_ThuocSD_DYList(dr);
                        //    //_TongTienBHCTT = _TongTienBHCTT + _KhamBenh_ThuocSDList._TongBHCTT;
                        //    //_TongTienBHDTT = _TongTienBHDTT + _KhamBenh_ThuocSDList._TongBH;
                        //    ////_TongTienBH = _TongTienBH + _TongTienBHCTT + _TongTienBHDTT;
                        //    //_TongTienTTCTT = _TongTienTTCTT + _KhamBenh_ThuocSDList._TongTTCTT;
                        //    //_TongTienTTDTT = _TongTienTTDTT + _KhamBenh_ThuocSDList._TongTT;
                        //    ////_TongTienTT = _TongTienTT + _TongTienTTCTT + _TongTienTTDTT;


                        //}
                    }
              dr.Close();
                    dr = null;
                    // loai = 1 : tiep don , loai = 2 : vien phi, loai = 3 : kham benh , loai = 4 : can lam sang
                    if ( (_loai == 7) )
                    {

                      
                       
                            _KhamBenh_GetsDichVuCTTList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_maSoKham, 0,  _loai, "" );
                            if (_KhamBenh_HoaDonList.Count >= 1)
                            _KhamBenh_GetsDichVuList = KhamBenh_GetsDichVuList.GetAllGetsDichVu(_maSoKham, 1,  _loai, "" );
                          
                    }
                    //MarkOld();
                    //ValidationRules.CheckRules();
            //        _TongTienBH =  _TongTienBHCTT + _TongTienBHDTT;
            //        _TongTienTT =  _TongTienTTCTT + _TongTienTTDTT;
            //_TongTien = _TongTienBH + _TongTienTT;
            //if (_TongTienBH <= _sotienbhtra)
            //    _TongBHTra = _TongTienBH;
            //else
            //    _TongBHTra = (_TongTienBH  * _bhtra) / decimal.Parse("100") ;
            //_TongBHKTra = _TongTienBH - _TongBHTra;

            //if (_TongTienBHDTT <= _sotienbhtra)
            //    _TongBHTraDTT = _TongTienBHDTT;
            //else
            //    _TongBHTraDTT = ((_TongTienBHDTT ) * _bhtra) / decimal.Parse("100") ;
            //_TongThanhToan = _TongBHKTra - (_TongTienBHDTT - _TongBHTraDTT) + _TongTienTTCTT;
            //_TongTienCTT = _TongTienBHCTT + _TongTienTTCTT;
                    //////if (_loai == 1 || _loai == 2 || _loai == 3 || _loai == 7 || _loai == 9)
                    //////{
                    //////    decimal _tbhtra = 0;
                    //////    decimal _tbh = 0;
                    //////    //foreach (KhamBenh_GetsDichVu obj in _KhamBenh_GetsDichVuCTTList )
                    //////    // {

                    //////    //    if ((obj.BHTinhtien != false) && (obj.Tinhtien == false))
                    //////    //    {
                    //////    //        _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DONGIABH) * ((decimal.Parse(obj.SoLuong) ) * (100 - decimal.Parse(obj.CK)) / 100);
                    //////    //        _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SoLuong)) * (100 - decimal.Parse(obj.CK)) / 100);

                    //////    //    }
                    //////    //    else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                    //////    //        _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DONGIATT) * ((decimal.Parse(obj.SoLuong)) * (100 - decimal.Parse(obj.CK)) / 100);

                    //////    //}
                    //////    //foreach (KhamBenh_GetsDichVu obj in _KhamBenh_GetsDichVuList)
                    //////    //{
                    //////    //    if ((obj.BHTinhtien != false) && (obj.Tinhtien == false))
                    //////    //    {
                    //////    //        _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DONGIABH) * ((decimal.Parse(obj.SoLuong)) * (100 - decimal.Parse(obj.CK)) / 100);
                    //////    //        _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SoLuong)) * (100 - decimal.Parse(obj.CK)) / 100);

                    //////    //    }
                    //////    //    else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                    //////    //        _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DONGIATT) * ((decimal.Parse(obj.SoLuong )) * (100 - decimal.Parse(obj.CK)) / 100);

                    //////    //}

                    //////    // TINH LAI THUOC
                    //////    foreach (KhamBenh_ThuocSD obj in _KhamBenh_ThuocSDList)
                    //////    {


                    //////        if ((obj.DaTTTT != 0) && (obj.Huy ==false))
                    //////        {
                    //////            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false))
                    //////            {
                    //////                _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra))) * (100 - decimal.Parse(obj.CK)) / 100;
                    //////                _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                    //////                _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                    //////            }
                    //////            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                    //////            {
                    //////                _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                    //////                _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                    //////            }

                    //////        }
                    //////        else if ((obj.DaTTTT == 0) && (obj.Huy ==false))
                    //////        {
                    //////            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false))
                    //////            {
                    //////                _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                    //////                _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                    //////            }
                    //////            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                    //////                _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                    //////        }
                    //////    };
                    
                    //////    //TINH TIEN HOA DON
                    //////    _TongTienHoaDon = 0;
                    //////    foreach (KhamBenh_HoaDon obj in _KhamBenh_HoaDonList)
                    //////    {
                    //////        if ((obj.TongThu == obj.TongChi) && (obj.TongChi != obj.TongChiCu)) //&& (obj.TongTienBH != obj.TongTienBHCu))
                    //////            _tbhtra = _tbhtra + obj.TongTienBH;
                    //////        if ((obj.TongChi == 0)) //&& (obj.TongTienBH != obj.TongTienBHCu))
                    //////            _tbh = _tbh + obj.TongTienBH;
                    //////        _TongTienHoaDon = _TongTienHoaDon + obj.TongThu - obj.TongChi;


                    //////    };

                    //////    _TongTienBH = _TongTienBHCTT + _TongTienBHDTT;
                    //////    if (_TongTienBH <= _sotienbhtra)
                    //////        _TongBHTra = _TongTienBH;
                    //////    else
                    //////        _TongBHTra = (_TongTienBH * _bhtra) / decimal.Parse("100");

                    //////    _TongBHKTra = _TongTienBH - _TongBHTra;

                    //////    if (_TongTienBHDTT <= _sotienbhtra)
                    //////        _TongBHTraDTT = _TongTienBHDTT;
                    //////    else
                    //////    {
                    //////        _TongBHTraDTT = ((_TongTienBHDTT) * _bhtra) / decimal.Parse("100");

                    //////    }
                    //////    if (_maDT == "00001")
                    //////        {
                    //////        _TongBHKTra = 0;
                    //////        _TongTienBH=0;
                    //////        _TongBHTra=0;
                    //////        _tbh=0;
                    //////        }
                    //////    else
                    //////        _TongBHKTra = _TongTienBH - _TongBHTra - _tbh;

                    //////    _TongThanhToan = _TongBHKTra + _TongTienTTCTT - _TongTienTTDTTKTra + _TongTienTTDTT - _tbhtra;

                    //////    _TongTienCTT = _TongTienBHCTT + _TongTienTTCTT;


                    //////    //_TongThanhToan = _TongThanhToan - _tbh;
                    //////    //if ((_loai == 2) || (_loai == 7))
                    //////    //     if (_TongTienHoaDon > _TongTienTTCTT + _TongTienTTDTT)
                    //////    //  {
                    //////    //         KhamBenh_HoaDon _khambenhhd = _KhamBenh_HoaDonList.ContainsCIn();
                    //////    //    if (_khambenhhd == null)
                    //////    //    {
                    //////    //        //_khambenhhd = _KhamBenh_HoaDonList.NewTo();
                    //////    //        //if (_loai == 2)
                    //////    //        //    _khambenhhd.loai = 1;
                    //////    //        //else if (_loai == 7)
                    //////    //        //    _khambenhhd.loai = 2;
                    //////    //        //if (_khambenhhd.LydoChi  == "")
                    //////    //        //    _khambenhhd.LydoChi = _khambenhhd.LydoChi + "Chi hóa đơn";
                    //////    //        //else if (_khambenhhd.LydoChi.CompareTo("Chi hóa đơn") <= 0)
                    //////    //        //    _khambenhhd.LydoChi = _khambenhhd.LydoChi + "- Chi hóa đơn";
                    //////    //        //_khambenhhd.TongChi = _TongTienHoaDon - _TongTienTTCTT - _TongTienTTDTT;
                    //////    //       // _TongThanhToan = _TongTienTTDTT - _TongTienTTDTTKTra;
                    //////    //       // _KhamBenh_HoaDonList.AssignTo(_khambenhhd);  
                    //////    //    }
                    //////    //    else
                    //////    //    {
                    //////    //        //if (_khambenhhd.LydoChi == "")
                    //////    //        //    _khambenhhd.LydoChi = _khambenhhd.LydoChi + "Chi hóa đơn";
                    //////    //        //else if (_khambenhhd.LydoChi.CompareTo("Chi hóa đơn") <= 0)
                    //////    //        //    _khambenhhd.LydoChi = _khambenhhd.LydoChi + "- Chi hóa đơn";
                    //////    //        //_khambenhhd.TongChi = _khambenhhd.TongThu;// 0 - (0 - _khambenhhd.TongChi + _TongTienTTCTT + _TongTienTTDTT - _TongTienHoaDon);
                    //////    //        ////_TongThanhToan = _TongTienTTDTT - _TongTienTTDTTKTra;
                    //////    //        //_KhamBenh_HoaDonList.UpdatedTo(_khambenhhd);  
                    //////    //    }


                    //////    //}
                    //////    //else if ((_TongTienHoaDon < _TongTienTTCTT + _TongTienTTDTTKTra) && (_TongTienTTDTTKTra != _TongTienTTDTT ) && _TongThanhToan ==0 )
                    //////    //{
                    //////    //    KhamBenh_HoaDon _khambenhhd = _KhamBenh_HoaDonList.ContainsCIn();
                    //////    //    if (_khambenhhd == null)
                    //////    //    {
                    //////    //        _khambenhhd = _KhamBenh_HoaDonList.NewTo();
                    //////    //        if (_loai == 2)
                    //////    //            _khambenhhd.loai = 1;
                    //////    //        else if (_loai == 7)
                    //////    //            _khambenhhd.loai = 2;
                    //////    //        if (_TongThanhToan > 0)
                    //////    //        {

                    //////    //            _khambenhhd.TongChi  = _TongTienTTCTT + _TongTienTTDTT - _TongTienHoaDon;
                    //////    //        }
                    //////    //        else
                    //////    //        {
                    //////    //            if (_khambenhhd.LydoThu == "")
                    //////    //                _khambenhhd.LydoThu = _khambenhhd.LydoThu + "Đổi hóa đơn";
                    //////    //            else if (_khambenhhd.LydoThu.CompareTo("Đổi hóa đơn") <= 0)
                    //////    //                _khambenhhd.LydoChi = _khambenhhd.LydoChi + "- Đổi hóa đơn";
                    //////    //            _khambenhhd.TongThu  = _TongTienTTCTT + _TongTienTTDTT - _TongTienHoaDon;

                    //////    //            _TongThanhToan = _TongTienTTDTT - _TongTienTTDTTKTra;
                    //////    //            _KhamBenh_HoaDonList.AssignTo(_khambenhhd);  
                    //////    //        }

                    //////    //    }
                    //////    //    else
                    //////    //    {
                    //////    //        if (_khambenhhd.LydoChi == "")
                    //////    //            _khambenhhd.LydoChi = _khambenhhd.LydoChi + "Đổi hóa đơn";
                    //////    //        else if (_khambenhhd.LydoChi.CompareTo("Đổi hóa đơn") <= 0)
                    //////    //            _khambenhhd.LydoChi = _khambenhhd.LydoChi + "- Đổi hóa đơn";
                    //////    //        _khambenhhd.TongThu = _khambenhhd.TongThu + _TongTienTTCTT + _TongTienTTDTT - _TongTienHoaDon;
                    //////    //        _TongThanhToan = _TongTienTTDTT - _TongTienTTDTTKTra;
                    //////    //        _KhamBenh_HoaDonList.UpdatedTo(_khambenhhd);  
                    //////    //    }
                    //////    //    }
               // };
                    TinhLaiTienKhamBenh();
                
            //dr.Close();
            //dr = null;
		}
      		
		/// <summary>
		/// Insert the new <see cref="KhamBenh_Q" /> Object to underlying database.
		/// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            _maDT= "00001";
            _ngayDK.Date = DateTime.Now; 
            ValidationRules.CheckRules();
            //_KhamBenh_GetsDichVuList = KhamBenh_GetsDichVuList.NewKhamBenh_GetsDichVuList;   
        }

        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh
            // Copy & paste ham duoi day vao file DataProvider.cs
            
            
              //using (TransactionScope oTranScope = new TransactionScope())
            //{
            _maSoKham = DataProvider.Instance().InsertKhamBenh(_maBN, _maDT, _sothe, _giatriDN, _maBV, _maTinh, _ngayKT, _gio, _ngayduyet, _nguoiduyet, _ngayQT, _ngayQTTT, _nguoiQT, _maBenhNoiGT, _maNoiGT, _cDNoiGT, _ghichu, _loaiKham, _cungtra, _ck,_nguoiSD   ,_maMay ,   _TongTien, _TongBHTra, _TongTienBH, _ngayDK, _giaTriTN,"",_ngayDK,0,1,0,0 );
               MarkOld(); 
            if (this.sosohd != "")
                    _KhamBenh_HoaDonList.Update(this);
                
                _KhamBenh_ThuocSDList.Update(this);
                _KhamBenh_ThuocSD_DYList.Update(this);
                MarkOld();
                // public abstract String InsertKhamBenh(String _maBN, String _maDT, String _sothe, SmartDate _giatriDN, String _maBV, String _maTinh, SmartDate _ngayKT, String _gio, SmartDate _ngayduyet, String _nguoiduyet, SmartDate _ngayQT, SmartDate _ngayQTTT, String _nguoiQT, String _maBenhNoiGT, String _maNoiGT, String _cDNoiGT, String _ghichu, Byte _loaiKham, Boolean _cungtra, Decimal _ck, String _nguoiLap, String _maMay, Decimal _tongTien , Decimal _tongBHTra ,Decimal _tongTienBH );
                // public override String InsertKhamBenh(String _maBN, String _maDT, String _sothe, SmartDate _giatriDN, String _maBV, String _maTinh, SmartDate _ngayKT, String _gio, SmartDate _ngayduyet, String _nguoiduyet, SmartDate _ngayQT, SmartDate _ngayQTTT, String _nguoiQT, String _maBenhNoiGT, String _maNoiGT, String _cDNoiGT, String _ghichu, Byte _loaiKham, Boolean _cungtra, Decimal _ck, String _nguoiLap, String _maMay, Decimal _tongTien , Decimal _tongBHTra ,Decimal _tongTienBH )
                // {
                //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhambenh_Create", _maBN, _maDT, _sothe, _giatriDN.DBValue, _maBV, _maTinh, _ngayKT.DBValue, _gio, _ngayduyet.DBValue, _nguoiduyet, _ngayQT.DBValue, _ngayQTTT.DBValue, _nguoiQT, _maBenhNoiGT, _maNoiGT, _cDNoiGT, _ghichu, _loaiKham, _cungtra, _ck,_nguoiSD   ,_maMay ,  _tongTien , _tongBHTra , _tongTienBH );
                // }
            //    oTranScope.Complete();
            //}
        }
		
		/// <summary>
		/// Update all changes made on <see cref="KhamBenh_Q" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh
			if (IsDirty){
                
                  
                //using (TransactionScope oTranScope = new TransactionScope(TransactionScopeOption.RequiresNew ,HTC.ShareVariables.ts    ))
                //{
                _sophieuttrv = DataProvider.Instance().UpdateKhamBenh(_maSoKham, _maBN, _maDT, _sothe, _giatriDN, _maBV, _maTinh, _ngayKT, _gio, _ngayduyet, _nguoiduyet, _ngayQT, _ngayQTTT, _nguoiQT, _maBenhNoiGT, _maNoiGT, _cDNoiGT, _ghichu, _loaiKham, _cungtra, _ck, _nguoiSD , _maMay , _huy, _TongTien, _TongBHTra, _TongTienBH, _ngayDK, _giaTriTN, "", false, 0, 1, 0, _ngayDK,0,0,0);
                  
                    ////////_KhamBenh_C_List.Update(this);
                    //_KhamBenh_C_KB_List.Update(this);
                    _KhamBenh_ThuocSDList.Update(this);
                    _KhamBenh_ThuocSD_DYList.Update(this);
              
                    ////////_KhamBenh_VTTHList.Update(this);
                    ////////_KhamBenh_HoaChatList.Update(this);
                    ////////_KhamBenh_MauList.Update(this);
                    _KhamBenh_HoaDonList.Update(this);
                    MarkOld();
                 //   oTranScope.Complete();
                //}
                // public abstract void UpdateKhamBenh(String _maSoKham, String _maBN, String _maDT, String _sothe, SmartDate _giatriDN, String _maBV, String _maTinh, SmartDate _ngayKT, String _gio, SmartDate _ngayduyet, String _nguoiduyet, SmartDate _ngayQT, SmartDate _ngayQTTT, String _nguoiQT, String _maBenhNoiGT, String _maNoiGT, String _cDNoiGT, String _ghichu, Byte _loaiKham, Boolean _cungtra, Decimal _ck, String _nguoiSD, String _maMay, Boolean _huy,Decimal _tongTien , Decimal _tongBHTra ,Decimal _tongTienBH  );
                // public override void UpdateKhamBenh(String _maSoKham, String _maBN, String _maDT, String _sothe, SmartDate _giatriDN, String _maBV, String _maTinh, SmartDate _ngayKT, String _gio, SmartDate _ngayduyet, String _nguoiduyet, SmartDate _ngayQT, SmartDate _ngayQTTT, String _nguoiQT, String _maBenhNoiGT, String _maNoiGT, String _cDNoiGT, String _ghichu, Byte _loaiKham, Boolean _cungtra, Decimal _ck, String _nguoiSD, String _maMay, Boolean _huy,Decimal _tongTien , Decimal _tongBHTra ,Decimal _tongTienBH  )
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhambenh_Update", _maSoKham, _maBN, _maDT, _sothe, _giatriDN.DBValue, _maBV, _maTinh, _ngayKT.DBValue, _gio, _ngayduyet.DBValue, _nguoiduyet, _ngayQT.DBValue, _ngayQTTT.DBValue, _nguoiQT, _maBenhNoiGT, _maNoiGT, _cDNoiGT, _ghichu, _loaiKham, _cungtra, _ck,_nguoiSD   ,_maMay ,   _huy,_tongTien , _tongBHTra , _tongTienBH );
				// }				
			}
		}
        //protected override void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new OtherCriteria(_maSoKham, _loai,_da));
        //}

		/// <summary>
		/// Delete the <see cref="KhamBenh_Q" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh
            DataProvider.Instance().DeleteKhamBenh(crit.MaMay, crit.NguoiSD, crit.MaSoKham);
			// public abstract void DeleteKhamBenh(String _maSoKham);
			// public override void DeleteKhamBenh(String _maSoKham);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhambenh_Deleted", _maSoKham);
			// }
            
		}
        //protected void DataPortal_Execute(CommandBase crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh

        //    DataProvider.Instance().Khambenh_TINHLAIDT(crit.MaSoKham, crit.MaDT, crit.loai, crit.dk);


        //}
        public  void TinhLaiTienKhamBenh()
        {
            _TongTien = 0;
            _TongBHTra = 0;
            _TongTienBH = 0;
            _TongTienTT = 0;
            _TongTienBHCTT = 0;
            _TongTienTTCTT = 0;
            _TongBHTraCTT = 0;
            _TongTienBHDTT = 0;
            _TongTienTTDTT = 0;
            _TongBHTraDTT = 0;
            _TongTienTTCTT = 0;
            _TongTienTTDTTKTra = 0;
            decimal _tbhtra = 0;
            decimal _tttt = 0;
            decimal _tbh = 0;
            //foreach (KhamBenh_GetsDichVu obj in _KhamBenh_GetsDichVuCTTList )
            // {
               
            //    if ((obj.BHTinhtien != false) && (obj.Tinhtien == false))
            //    {
            //        _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DONGIABH) * ((decimal.Parse(obj.SoLuong) ) * (100 - decimal.Parse(obj.CK)) / 100);
            //        _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SoLuong)) * (100 - decimal.Parse(obj.CK)) / 100);

            //    }
            //    else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
            //        _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DONGIATT) * ((decimal.Parse(obj.SoLuong)) * (100 - decimal.Parse(obj.CK)) / 100);

            //}
            //foreach (KhamBenh_GetsDichVu obj in _KhamBenh_GetsDichVuList)
            //{
            //    if ((obj.BHTinhtien != false) && (obj.Tinhtien == false))
            //    {
            //        _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DONGIABH) * ((decimal.Parse(obj.SoLuong)) * (100 - decimal.Parse(obj.CK)) / 100);
            //        _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SoLuong)) * (100 - decimal.Parse(obj.CK)) / 100);
                    
            //    }
            //    else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
            //        _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DONGIATT) * ((decimal.Parse(obj.SoLuong )) * (100 - decimal.Parse(obj.CK)) / 100);

            //}
         
            // TINH LAI THUOC
            foreach (KhamBenh_ThuocSD obj in _KhamBenh_ThuocSDList)
            {


                if ((obj.DaTTTT != 0) && (obj.Huy ==false))
                {
                    if ((obj.BHTinhtien != false) && (obj.Tinhtien == false)) 
                    {
                        _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)))*(100 - decimal.Parse(obj.CK) )/100 ;
                        _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                        _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                    }
                    else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                    {
                        _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                        _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTraCu)) * (100 - decimal.Parse(obj.CK)) / 100);
                    }

                }
                else if ((obj.DaTTTT == 0) && (obj.Huy ==false))
                {
                    if ((obj.BHTinhtien != false) && (obj.Tinhtien == false))
                    {
                        _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DonGiaBH) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);
                        _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                    }
                    else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                        _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(obj.SLMua) - decimal.Parse(obj.SLTra)) * (100 - decimal.Parse(obj.CK)) / 100);

                }
            };

            // tinh thuoc dong y
            foreach (KhamBenh_ThuocSD_DY objM in _KhamBenh_ThuocSD_DYList)
            {
                if ((objM.Huy == false))
                {
                    if (objM.DaTTTT != 0)
                        if (objM.Sac == true)
                        {
                            _TongTienTTDTT = _TongTienTTDTT + objM.GiaSac * Decimal.Parse(objM.SLMua);
                            _TongSac = _TongSac + objM.GiaSac * Decimal.Parse(objM.SLMua);
                        }
                    if (objM.DaTTTT == 0)
                        if (objM.Sac == true)
                        {
                            _TongTienTTCTT = _TongTienTTCTT + objM.GiaSac * Decimal.Parse(objM.SLMua);
                            _TongSac = _TongSac + objM.GiaSac * Decimal.Parse(objM.SLMua);
                        }
                }

                if (objM.Huy == false)
                    foreach (KhamBenh_ThuocSD_DY_C obj in objM.KhamBenh_ThuocSD_DY_Cs)
                    {

                     if ((objM.DaTTTT != 0) && (objM.Huy == false) )
                        {
                            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((objM.MaDT == _maDT) || (1 == 1)))
                            {
                                _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
                                _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(objM.SLMua) - decimal.Parse(objM.SLTraCu)) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
                             }
                            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                            {
                                _TongTienTTDTT = _TongTienTTDTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
                                _TongTienTTDTTKTra = _TongTienTTDTTKTra + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(objM.SLMua) - decimal.Parse(objM.SLTraCu)) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
                            }

                        }
                        else if ((objM.DaTTBH != 0) && (obj.Huy == false) )
                        {
                            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((objM.MaDT == _maDT) || (1 == 1)))
                            {
                                _TongTienBHDTT = _TongTienBHDTT + decimal.Parse(obj.DongiaBH) * ((decimal.Parse(objM.SLMua) - objM.SLTra)) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100;


                            }

                        }
                        else if ((objM.DaTTTT == 0) && (obj.Huy == false) )
                        {
                            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((objM.MaDT == _maDT) || (1 == 1)))
                            {
                                _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.GiaChenhLech) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
                        
                            }
                            else if ((obj.BHTinhtien == false) || (obj.Tinhtien != false))
                            {
                                _TongTienTTCTT = _TongTienTTCTT + decimal.Parse(obj.DongiaTT) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);
                         
                            }
                        }
                        else if ((objM.DaTTBH == 0) && (obj.Huy == false))
                        {
                            if ((obj.BHTinhtien != false) && (obj.Tinhtien == false) && ((objM.MaDT == _maDT) || (1 == 1)))
                            {
                                _TongTienBHCTT = _TongTienBHCTT + decimal.Parse(obj.DongiaBH) * ((decimal.Parse(objM.SLMua) - objM.SLTra) * decimal.Parse(obj.SLMua) * (100 - objM.CK) / 100);

                            }
                        }
                    }
            };
            //TINH TIEN HOA DON
            _TongTienHoaDon = 0;
            foreach (KhamBenh_HoaDon obj in _KhamBenh_HoaDonList)
            {
              
                if ((obj.TongThu == obj.TongChi) && (obj.TongChi != obj.TongChiCu)) //&& (obj.TongTienBH != obj.TongTienBHCu))
                {
                    _tbhtra = 0;
                    _TongHD = _TongHD + obj.TongThu - obj.TongChiCu;
                }
                if ((obj.TongChi == 0)) //&& (obj.TongTienBH != obj.TongTienBHCu))
                    _tbh = 0;
                _TongTienHoaDon = _TongTienHoaDon + obj.TongThu - obj.TongChi;

            };
            _TongThuHoaDon = _TongTienHoaDon;
            _TongTienTT = _TongTienTTCTT + _TongTienTTDTT;
            _TongTienBH = _TongTienBHCTT + _TongTienBHDTT;

          
           
                _TongBHKTra = 0;
                _TongTienBH = 0;
                _TongBHTra = 0;
                _tbh = 0;
                _TongThanhToan = _TongTienTTCTT - _TongTienTTDTTKTra + _TongTienTTDTT;
                _TongTienCTT = _TongTienTTCTT;
               
                if (_TongThanhToan < 0)
                    _TongThuHoaDon = _TongThanhToan + _TongHD ;
                else
                    _TongThuHoaDon = _TongThanhToan ;
                _TongHD = _TongTienHoaDon;

           
                //_TongThanhToan = _TongThanhToan - _tbh;
            //if ((_loai == 2) || (_loai == 7))
            //     if (_TongTienHoaDon > _TongTienTTCTT + _TongTienTTDTT)
            //  {
            //         KhamBenh_HoaDon _khambenhhd = _KhamBenh_HoaDonList.ContainsCIn();
            //    if (_khambenhhd == null)
            //    {
            //        //_khambenhhd = _KhamBenh_HoaDonList.NewTo();
            //        //if (_loai == 2)
            //        //    _khambenhhd.loai = 1;
            //        //else if (_loai == 7)
            //        //    _khambenhhd.loai = 2;
            //        //if (_khambenhhd.LydoChi  == "")
            //        //    _khambenhhd.LydoChi = _khambenhhd.LydoChi + "Chi hóa đơn";
            //        //else if (_khambenhhd.LydoChi.CompareTo("Chi hóa đơn") <= 0)
            //        //    _khambenhhd.LydoChi = _khambenhhd.LydoChi + "- Chi hóa đơn";
            //        //_khambenhhd.TongChi = _TongTienHoaDon - _TongTienTTCTT - _TongTienTTDTT;
            //       // _TongThanhToan = _TongTienTTDTT - _TongTienTTDTTKTra;
            //       // _KhamBenh_HoaDonList.AssignTo(_khambenhhd);  
            //    }
            //    else
            //    {
            //        //if (_khambenhhd.LydoChi == "")
            //        //    _khambenhhd.LydoChi = _khambenhhd.LydoChi + "Chi hóa đơn";
            //        //else if (_khambenhhd.LydoChi.CompareTo("Chi hóa đơn") <= 0)
            //        //    _khambenhhd.LydoChi = _khambenhhd.LydoChi + "- Chi hóa đơn";
            //        //_khambenhhd.TongChi = _khambenhhd.TongThu;// 0 - (0 - _khambenhhd.TongChi + _TongTienTTCTT + _TongTienTTDTT - _TongTienHoaDon);
            //        ////_TongThanhToan = _TongTienTTDTT - _TongTienTTDTTKTra;
            //        //_KhamBenh_HoaDonList.UpdatedTo(_khambenhhd);  
            //    }


            //}
            //else if ((_TongTienHoaDon < _TongTienTTCTT + _TongTienTTDTTKTra) && (_TongTienTTDTTKTra != _TongTienTTDTT ) && _TongThanhToan ==0 )
            //{
            //    KhamBenh_HoaDon _khambenhhd = _KhamBenh_HoaDonList.ContainsCIn();
            //    if (_khambenhhd == null)
            //    {
            //        _khambenhhd = _KhamBenh_HoaDonList.NewTo();
            //        if (_loai == 2)
            //            _khambenhhd.loai = 1;
            //        else if (_loai == 7)
            //            _khambenhhd.loai = 2;
            //        if (_TongThanhToan > 0)
            //        {
                       
            //            _khambenhhd.TongChi  = _TongTienTTCTT + _TongTienTTDTT - _TongTienHoaDon;
            //        }
            //        else
            //        {
            //            if (_khambenhhd.LydoThu == "")
            //                _khambenhhd.LydoThu = _khambenhhd.LydoThu + "Đổi hóa đơn";
            //            else if (_khambenhhd.LydoThu.CompareTo("Đổi hóa đơn") <= 0)
            //                _khambenhhd.LydoChi = _khambenhhd.LydoChi + "- Đổi hóa đơn";
            //            _khambenhhd.TongThu  = _TongTienTTCTT + _TongTienTTDTT - _TongTienHoaDon;

            //            _TongThanhToan = _TongTienTTDTT - _TongTienTTDTTKTra;
            //            _KhamBenh_HoaDonList.AssignTo(_khambenhhd);  
            //        }
                   
            //    }
            //    else
            //    {
            //        if (_khambenhhd.LydoChi == "")
            //            _khambenhhd.LydoChi = _khambenhhd.LydoChi + "Đổi hóa đơn";
            //        else if (_khambenhhd.LydoChi.CompareTo("Đổi hóa đơn") <= 0)
            //            _khambenhhd.LydoChi = _khambenhhd.LydoChi + "- Đổi hóa đơn";
            //        _khambenhhd.TongThu = _khambenhhd.TongThu + _TongTienTTCTT + _TongTienTTDTT - _TongTienHoaDon;
            //        _TongThanhToan = _TongTienTTDTT - _TongTienTTDTTKTra;
            //        _KhamBenh_HoaDonList.UpdatedTo(_khambenhhd);  
            //    }
            //    }
            
  
 

        }
      
		#endregion
	}

}
