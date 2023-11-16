// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_Khoa
// Kieu doi tuong  :	BenhAn_Khoa
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	6/16/2009 10:12:26 AM
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

namespace HTC.Business.NoiTru
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="BenhAn_Khoa" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_Khoa : BusinessBase<BenhAn_Khoa>
	{
		#region Business Methods
		
		#region State Fields
        private String _maloaibn = String.Empty;
        private String _noiTT = String.Empty;
        private Int32 _STTDT = 0;
        private String _maBAQL = String.Empty;
		private String _maBA = String.Empty;
        private String _maLoaiBA = String.Empty;
		private Int32 _sTTKhoa = 0;
		private String _maKhoa = String.Empty;
		private String _maBN = String.Empty;
        private SmartDate _ngayVKhoa = new SmartDate(true);//_nGAYVKhoaD
        private SmartDate _ngayVVTT = new SmartDate(true);//_nGAYVv
        private Boolean _raVien = false;
        private SmartDate _nGAYVKhoaD = new SmartDate(true);
		private String _maBenh = String.Empty;
		private String _maBenhKem = String.Empty;
		private String _maTienLuong = String.Empty;
		private String _bSDieuTri = String.Empty;
		private String _yta = String.Empty;
		private String _soPhong = String.Empty;
		private String _soGiuong = String.Empty;
		private SmartDate _ngayKT = new SmartDate(true);
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngayHuy = new SmartDate(true);
		private String _nguoiHuy = String.Empty;
		private String _lyDoHuy = String.Empty;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
		private Byte _raKhoa = 0;
        private String _ghichu = String.Empty;
        private String _maicd = String.Empty;
        private String _tenbenh = String.Empty;
        private String _maicdkem = String.Empty;
        private String _tenbenhkem = String.Empty;
        private String _tenDT = String.Empty;
        private String _maDT = String.Empty;
        private String _hoten = String.Empty;
        private Byte _tuoi = 0;
        private SmartDate _ngaySinh = new SmartDate(true);
        private SmartDate _ngaySinhD = new SmartDate(true);
        private String _diaChi = String.Empty;
        private Boolean _gt = false;
        private Boolean _gtNu = false;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private String _tenBSChidinh = String.Empty;
        private String _tenYTa = String.Empty;
        private String _tenKhoa = String.Empty;
        private int _OrderNumber;
        private decimal _giuong = 0;
        private String _kethuoc = String.Empty;
        private String _sothe = String.Empty;
        private String _maBV = String.Empty;
        private String _mabhxh = String.Empty;
        private SmartDate _giaTriTN = new SmartDate(true);
        private SmartDate _giatriDN = new SmartDate(true);
        private String _tenBV = String.Empty;
        private decimal _tongTien = 0;
        private decimal _tongTienBH = 0;
        private decimal _tongTienBNtra = 0;
        private decimal _tongTamthu = 0;
        private SmartDate _ngayQT = new SmartDate(true);
        private String _NguoiQT = String.Empty;
        private Boolean _GoiDichVu = false;
        private SmartDate _ngayhuongbh = new SmartDate(true);
        private SmartDate _ngayduyet = new SmartDate(true);
	
		#endregion
		
		#region Business Properties and Methods
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
	
        public Boolean GoiDichVu
        {
            get
            {
                CanReadProperty("GoiDichVu", true);
                return _GoiDichVu;
            }
            set
            {
                CanWriteProperty("GoiDichVu", true);
                if (_GoiDichVu != value)
                {
                    _GoiDichVu = value;
                    PropertyHasChanged("GoiDichVu");
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
        public string NguoiQT
        {
            get
            {
                CanReadProperty("NguoiQT", true);
                return _NguoiQT;
            }
            set
            {
                CanWriteProperty("NguoiQT", true);
                if (_NguoiQT != value)
                {
                    _NguoiQT = value;
                    PropertyHasChanged("NguoiQT");
                }
            }
        }
        public Int32 NgayDT
        {
            get
            {
                if (_raKhoa > 0)
                    return (_ngayKT - _ngayVKhoa).Days+1;
                else
                    return (SmartDate.Parse(DateTime.Now.ToString()) - _ngayVKhoa).Days+1;
            }
        }
        public String maloaibn
        {
            get
            {
                CanReadProperty("maloaibn", true);
                return _maloaibn;
            }
            set
            {
                CanWriteProperty("maloaibn", true);
                if (_maloaibn != value)
                {
                    _maloaibn = value;
                    PropertyHasChanged("maloaibn");
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
        public Int32 STTDT
        {
            get
            {
                CanReadProperty("STTDT", true);
                return _STTDT;
            }
            set
            {
                CanWriteProperty("STTDT", true);
                if (_STTDT != value)
                {
                    _STTDT = value;
                    PropertyHasChanged("STTDT");
                }
            }
        }
        public String kethuoc
        {
            get
            {
                CanReadProperty("kethuoc", true);
                return _kethuoc;
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
		
		public Int32 STTKhoa
		{
			get 
			{
				CanReadProperty("STTKhoa", true);
				return _sTTKhoa;
			}
			set 
			{
				CanWriteProperty("STTKhoa", true);
				if (_sTTKhoa != value) 
				{
					_sTTKhoa = value;
					PropertyHasChanged("STTKhoa");
				}
			}
		}
		
		public String MaKhoa
		{
			get 
			{
				CanReadProperty("MaKhoa", true);
				return _maKhoa;
			}
			set 
			{
				CanWriteProperty("MaKhoa", true);
				if (_maKhoa != value) 
				{
					_maKhoa = value;
					PropertyHasChanged("MaKhoa");
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
        public string NgayVVTT
        {
            get
            {
                CanReadProperty("NgayVVTT", true);
                _ngayVVTT.FormatString = "dd/MM/yyyy HH:mm";

                return _ngayVVTT.Text;
            }
            set
            {
                CanWriteProperty("NgayVVTT", true);
                if (_ngayVVTT.Text != value)
                {
                    _ngayVVTT.Text = value;
                    PropertyHasChanged("NgayVVTT");
                }
            }
        }
        public string NgayVVD
        {
            get
            {
               
                

                return _ngayVVTT.Text.Substring(0,10);
            }
           
        }
		public string NgayVKhoa
		{
			get 
			{
				CanReadProperty("NgayVKhoa", true);
                _ngayVKhoa.FormatString = "dd/MM/yyyy";
				return _ngayVKhoa.Text;
			}
			set 
			{
				CanWriteProperty("NgayVKhoa", true);
				if (_ngayVKhoa.Text != value) 
				{
					_ngayVKhoa.Text = value;
					PropertyHasChanged("NgayVKhoa");
				}
			}
		}
        public string NGAYVKhoaD
        {
            get
            {
                CanReadProperty("NGAYVKhoaD", true);
                _nGAYVKhoaD = _ngayVKhoa;
                this._nGAYVKhoaD.FormatString = "dd/MM/yyyy";

                return _nGAYVKhoaD.Text;
            }
            
        }
		
		
		public String MaBenh
		{
			get 
			{
				CanReadProperty("MaBenh", true);
				return _maBenh;
			}
			set 
			{
				CanWriteProperty("MaBenh", true);
				if (_maBenh != value) 
				{
					_maBenh = value;
					PropertyHasChanged("MaBenh");
				}
			}
		}
		
		public String MaBenhKem
		{
			get 
			{
				CanReadProperty("MaBenhKem", true);
				return _maBenhKem;
			}
			set 
			{
				CanWriteProperty("MaBenhKem", true);
				if (_maBenhKem != value) 
				{
					_maBenhKem = value;
					PropertyHasChanged("MaBenhKem");
				}
			}
		}
		
		public String MaTienLuong
		{
			get 
			{
				CanReadProperty("MaTienLuong", true);
				return _maTienLuong;
			}
			set 
			{
				CanWriteProperty("MaTienLuong", true);
				if (_maTienLuong != value) 
				{
					_maTienLuong = value;
					PropertyHasChanged("MaTienLuong");
				}
			}
		}
		
		public String BSDieuTri
		{
			get 
			{
				CanReadProperty("BSDieuTri", true);
				return _bSDieuTri;
			}
			set 
			{
				CanWriteProperty("BSDieuTri", true);
				if (_bSDieuTri != value) 
				{
					_bSDieuTri = value;
					PropertyHasChanged("BSDieuTri");
				}
			}
		}
		
		public String Yta
		{
			get 
			{
				CanReadProperty("Yta", true);
				return _yta;
			}
			set 
			{
				CanWriteProperty("Yta", true);
				if (_yta != value) 
				{
					_yta = value;
					PropertyHasChanged("Yta");
				}
			}
		}
		
		public String SoPhong
		{
			get 
			{
				CanReadProperty("SoPhong", true);
				return _soPhong;
			}
			set 
			{
				CanWriteProperty("SoPhong", true);
				if (_soPhong != value) 
				{
					_soPhong = value;
					PropertyHasChanged("SoPhong");
				}
			}
		}
		
		public String SoGiuong
		{
			get 
			{
				CanReadProperty("SoGiuong", true);
				return _soGiuong;
			}
			set 
			{
				CanWriteProperty("SoGiuong", true);
				if (_soGiuong != value) 
				{
					_soGiuong = value;
					PropertyHasChanged("SoGiuong");
				}
			}
		}
        public decimal  Giuong
        {
            get
            {
                CanReadProperty("Giuong", true);
                return _giuong;
               //if (decimal.Parse(_soGiuong) == 0)
               // {
               //     return "0";
               // }
               // else if (decimal.Parse(_soGiuong)  - (int)(decimal.Parse(_soGiuong) ) != 0)
               // {
               //     return decimal.Parse(_soGiuong).ToString("###,##0.##");
               // }
               // else
               // {
               //     return decimal.Parse(_soGiuong).ToString("###,###");
               // }
            }
            set
            {
                CanWriteProperty("Giuong", true);
                if (_giuong != value)
                {
                    _giuong = value;
                    PropertyHasChanged("Giuong");
                }
            } 
        }
		public string NgayKT
		{
			get 
			{
				CanReadProperty("NgayKT", true);
                this._ngayKT.FormatString = "dd/MM/yyyy HH:mm";
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
		
		public String LyDoHuy
		{
			get 
			{
				CanReadProperty("LyDoHuy", true);
				return _lyDoHuy;
			}
			set 
			{
				CanWriteProperty("LyDoHuy", true);
				if (_lyDoHuy != value) 
				{
					_lyDoHuy = value;
					PropertyHasChanged("LyDoHuy");
				}
			}
		}
		
		public string NgayLap
		{
			get 
			{
				CanReadProperty("NgayLap", true);
                this._ngayLap.FormatString = "dd/MM/yyyy";
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
               // this._ngaySD.FormatString = "dd/MM/yyyy";
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
		
		
		
		public Byte  RaKhoa
		{
			get 
			{
				CanReadProperty("RaKhoa", true);
				return _raKhoa;
			}
			set 
			{
				CanWriteProperty("RaKhoa", true);
				if (_raKhoa != value) 
				{
					_raKhoa = value;
					PropertyHasChanged("RaKhoa");
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
        public String maicd
        {
            get
            {
                CanReadProperty("maicd", true);
                return _maicd;
            }
            set
            {
                CanWriteProperty("maicd", true);
                if (_maicd != value)
                {
                    _maicd = value;
                    PropertyHasChanged("maicd");
                }
            }
        }

        public String TenBenh
        {
            get
            {
                CanReadProperty("TenBenh", true);
                return _tenbenh;
            }
            set
            {
                CanWriteProperty("TenBenh", true);
                if (_tenbenh != value)
                {
                    _tenbenh = value;
                    PropertyHasChanged("TenBenh");
                }
            }
        }

        public String TenBenhKem
        {
            get
            {
                CanReadProperty("TenBenhKem", true);
                return _tenbenhkem;
            }
            set
            {
                CanWriteProperty("TenBenhKem", true);
                if (_tenbenhkem != value)
                {
                    _tenbenhkem = value;
                    PropertyHasChanged("TenBenhKem");
                }
            }
        }

        public String maicdkem
        {
            get
            {
                CanReadProperty("maicdkem", true);
                return _maicdkem;
            }
            set
            {
                CanWriteProperty("maicdkem", true);
                if (_maicdkem != value)
                {
                    _maicdkem = value;
                    PropertyHasChanged("maicdkem");
                }
            }
        }
        public String TenDT
        {
            get
            {
                CanReadProperty("TenDT", true);
                return _tenDT;
            }
            set
            {
                CanWriteProperty("TenDT", true);
                if (_tenDT != value)
                {
                    _tenDT = value;
                    PropertyHasChanged("TenDT");
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

        

        public String BAHoten
        {
            get
            {
                
                return _maBA +"   "+ _hoten;
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
        public string NgaySinhD
        {
            get
            {
                CanReadProperty("NgaySinhD", true);
                _ngaySinhD = _ngaySinh;
                this._ngaySinhD.FormatString = "dd/MM/yyyy";

                return _ngaySinhD.Text;
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

        public Boolean GTNu
        {
            get
            {
                CanReadProperty("GTNu", true);
                if (_gt == true)
                    return false;
                else
                    return true;
            }

        }
        public string GTD
        {
            get
            {
                CanReadProperty("GTD", true);
                if (_gt == false)
                    return "Nữ";
                else
                    return "Nam";
            }
            //set
            //{
            //    CanWriteProperty("GT", true);
            //    if (_gt != value)
            //    {
            //        _gt = value;
            //        PropertyHasChanged("GT");
            //    }
            //}
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

        public String TenBSChidinh
        {
            get
            {
                CanReadProperty("TenBSChidinh", true);
                return _tenBSChidinh;
            }
            set
            {
                CanWriteProperty("TenBSChidinh", true);
                if (_tenBSChidinh != value)
                {
                    _tenBSChidinh = value;
                    PropertyHasChanged("TenBSChidinh");
                }
            }
        }

        public String TenYTa
        {
            get
            {
                CanReadProperty("TenYTa", true);
                return _tenYTa;
            }
            set
            {
                CanWriteProperty("TenYTa", true);
                if (_tenYTa != value)
                {
                    _tenYTa = value;
                    PropertyHasChanged("TenYTa");
                }
            }
        }

        public String TenKhoa
        {
            get
            {
                CanReadProperty("TenKhoa", true);
                return _tenKhoa;
            }
            set
            {
                CanWriteProperty("TenKhoa", true);
                if (_tenKhoa != value)
                {
                    _tenKhoa = value;
                    PropertyHasChanged("TenKhoa");
                }
            }
        }
        public decimal ConLai
        {
            get
            {
               
                    return _tongTamthu - _tongTienBNtra;
               
            }

        }
        public decimal Thua
        {
            get
            {
                if (_tongTamthu - _tongTienBNtra > 0)
                    return _tongTamthu - _tongTienBNtra;
                else
                    return 0;
            }
           
        }
        public decimal Thieu
        {
            get
            {
                if (_tongTamthu - _tongTienBNtra < 0)
                    return 0-_tongTamthu + _tongTienBNtra;
                else
                    return 0;
            }

        }
        public decimal  TongTien
        {
            get
            {
                CanReadProperty("TongTien", true);
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
        public decimal TongTienBH
        {
            get
            {
                CanReadProperty("TongTienBH", true);
                return _tongTienBH;
            }
            set
            {
                CanWriteProperty("TongTienBH", true);
                if (_tongTienBH != value)
                {
                    _tongTienBH = value;
                    PropertyHasChanged("TongTienBH");
                }
            }
        }
        public decimal TongTienBNTra
        {
            get
            {
                CanReadProperty("TongTienBNTra", true);
                return _tongTienBNtra;
            }
            set
            {
                CanWriteProperty("TongTienBNTra", true);
                if (_tongTienBNtra != value)
                {
                    _tongTienBNtra = value;
                    PropertyHasChanged("TongTienBNTra");
                }
            }
        }
        public decimal TongTamThu
        {
            get
            {
                CanReadProperty("TongTamThu", true);
                return _tongTamthu;
            }
            set
            {
                CanWriteProperty("TongTamThu", true);
                if (_tongTamthu != value)
                {
                    _tongTamthu = value;
                    PropertyHasChanged("TongTamThu");
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
			return _maBA.ToString() + "!" + _sTTKhoa.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhAn_Khoa" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

        public static BenhAn_Khoa NewBenhAn_Khoa()
        {
            return DataPortal.Create<BenhAn_Khoa>();
        }
        public static BenhAn_Khoa NewBenhAn_Khoa(string MaBA)
        {
            return DataPortal.Create<BenhAn_Khoa>(new CriteriaNew(MaBA));
        }
		public static BenhAn_Khoa GetBenhAn_Khoa(String maBA, Int32 sTTKhoa)
		{
			return DataPortal.Fetch<BenhAn_Khoa>(new Criteria(maBA, sTTKhoa));
		}
        public static BenhAn_Khoa GetBenhAn_KhoaTT(String maBA, Int32 sTTKhoa)
        {
            return DataPortal.Fetch<BenhAn_Khoa>(new CriteriaTT(maBA, sTTKhoa, 0));
        }
        public static BenhAn_Khoa GetBenhAn_KhoaTT(String maBA, Int32 sTTKhoa, byte loaikq)
        {
            return DataPortal.Fetch<BenhAn_Khoa>(new CriteriaTT(maBA, sTTKhoa,loaikq ));
        }
        public static BenhAn_Khoa GetBenhAnTT(String maBA)
        {
            return DataPortal.Fetch<BenhAn_Khoa>(new CriteriaTien(maBA));
        }
		/// <summary>
		/// Marks the <see cref="BenhAn_Khoa" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBenhAn_Khoa(String maBA, Int32 sTTKhoa, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maBA, sTTKhoa));
		}
        private BenhAn_Khoa(string MaBA)
        {
            _maBA = MaBA;
            
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BenhAn_Khoa()
		{	
			// Prevent direct creation
		}
        internal BenhAn_Khoa(
                                 int OrderNumber,
                                 String maBA,
                                 Int32 sTTKhoa,
                                 String maKhoa,
                                 String maBN,
                                 SmartDate ngayVKhoa,
                                 String maBenh,
                                 String maBenhKem,
                                 String MaTienLuong,
                                 String bSDieuTri,
                                 String yta,
                                 String soPhong,
                                 String soGiuong,
                                 SmartDate ngayKT,
                                 String maMay,
                                 Boolean goichichvu,
            SmartDate  ngaYduyet,
            SmartDate ngaYhuongbh,
                                 SmartDate ngayHuy,
                                 String nguoiHuy,
                                 String lyDoHuy,
                                 SmartDate ngayLap,
                                 String nguoiLap,
                                 SmartDate ngaySD,
                                 String nguoiSD,
                                 SmartDate ngaySD1,
                                 String nguoiSD1,
                                 Byte raKhoa,
                                 String ghichu,
                                 String maicd,
                                 String tenbenh,
                                 String maicdkem,
                                 String tenbenhkem,
                                 String tenDT,
                                 String maDT,
                                 String hoten,
                                 Byte tuoi,
                                 SmartDate ngaySinh,
                                 String diaChi,
                                 Boolean gt,
                                 String tenNguoiLap,
                                 String tenNguoiSD,
                                 String tenNguoiHuy,
                                 String tenBSChidinh,
                                 String tenYTa,
              decimal tongtien,
             decimal tongtienbh,
             decimal tongTienBNTra,
             decimal tongtamthu,
              SmartDate ngayqt,
             string nguoiqt,
                                 string tenkhoa,
                                 String maLoaiBA,
                             String maBAQL,
                                 SmartDate giatridn,
                             String kethuoc,
            string sothe,
            SmartDate giatritn,
            string mabv,
            string tenbv,
            string mabhxh,
            SmartDate ngayvvtt,
            string noitt,
            Boolean ravien
             , String maloaibn
                                )
        {
            _sothe = sothe;
            _raVien = ravien;
            _giaTriTN = giatritn;
            _maloaibn = maloaibn;
            _maBV = mabv;
            _tenBV = tenbv;
            _mabhxh = mabhxh;
            _ngayVVTT = ngayvvtt;
            _noiTT = noitt;
            _OrderNumber = OrderNumber;
            _kethuoc = kethuoc;
            _giatriDN = giatridn;
            _maBA = maBA;
            _sTTKhoa = sTTKhoa;
            _maBAQL = maBAQL;
            _maKhoa = maKhoa;
            _maBN = maBN;
            _GoiDichVu = goichichvu;
            _ngayduyet = ngaYduyet;
            _ngayhuongbh = ngaYhuongbh;
            _ngayVKhoa = ngayVKhoa;
            _maBenh = maBenh;
            _maBenhKem = maBenhKem;
            _maTienLuong = MaTienLuong;
            _bSDieuTri = bSDieuTri;
            _yta = yta;
            _soPhong = soPhong;
            _soGiuong = soGiuong;
            _ngayKT = ngayKT;
            _maMay = maMay;
            _GoiDichVu = goichichvu ;
            _ngayhuongbh = ngaYhuongbh;
            _ngayduyet = ngaYduyet;
            _ngayHuy = ngayHuy;
            _nguoiHuy = nguoiHuy;
            _lyDoHuy = lyDoHuy;
            _ngayLap = ngayLap;
            _nguoiLap = nguoiLap;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD;
            _ngaySD1 = ngaySD1;
            _nguoiSD1 = nguoiSD1;
            _raKhoa = raKhoa;
            _ghichu = ghichu;
            _maicd = maicd;
            _tenbenh = tenbenh;
            _maicdkem = maicdkem;
            _tenbenhkem = tenbenhkem;
            _tenDT = tenDT;
            _maDT = maDT;
            _hoten = hoten;
            _tuoi = tuoi;
            _ngaySinh = ngaySinh;
            _diaChi = diaChi;
            _gt = gt;
            _tenNguoiLap = tenNguoiLap;
            _tenNguoiSD = tenNguoiSD;
            _tenNguoiHuy = tenNguoiHuy;
            _tenBSChidinh = tenBSChidinh;
            _tenYTa = tenYTa;
            _tongTien = tongtien;
            _tongTamthu = tongtamthu;
            _tongTienBH = tongtienbh;
            _tongTienBNtra = tongTienBNTra;
            _ngayQT = ngayqt;
            _NguoiQT = nguoiqt;
            _tenKhoa = tenkhoa;
            _maLoaiBA = maLoaiBA;
            try
            {
                if (soGiuong != "")
                    _giuong = decimal.Parse(soGiuong);
            }
            catch
            { }



        }
         internal BenhAn_Khoa(
                                 int OrderNumber,
                                 String maBA ,
		                         Int32 sTTKhoa ,
		                         String maKhoa ,
		                         String maBN ,
		                         SmartDate ngayVKhoa ,
		                           String soPhong ,
		                         String soGiuong,
		                         SmartDate ngayKT ,
		                         String maMay ,
		                         Boolean goiDichVu ,
                                 SmartDate ngaYduyet,
                                 SmartDate ngaYhuongbh,
		                         SmartDate ngaySD ,
              String NguoiSD,
		                           String tenDT ,
                                 String maDT ,
             byte rakhoa,
                                 String hoten ,
                                 Byte tuoi ,
                                 SmartDate ngaySinh ,
                                 String diaChi ,
                                 Boolean gt ,
                                   decimal tongtien, 
             decimal tongtienbh,
             decimal tongTienBNTra,
             decimal tongtamthu,
              SmartDate ngayqt,
             string nguoiqt,
                                 string tenkhoa,
                                 String maLoaiBA,
                             String maBAQL,
                              
                             String kethuoc,
            string sothe,
           
            SmartDate ngayvvtt,
            string noitt,
            Boolean ravien
              , String maloaibn
                                )
        {
            _sothe = sothe;
            _raVien = ravien;
         
            _mabhxh = mabhxh;
            _ngayVVTT = ngayvvtt;
            _noiTT = noitt;
            _maloaibn = maloaibn;
            _ngayduyet = ngaYduyet;
            _ngayhuongbh = ngaYhuongbh;
                                  _OrderNumber = OrderNumber ;
                                  _kethuoc = kethuoc;
                                  _maBA = maBA ;
		                          _sTTKhoa = sTTKhoa;
                                  _maBAQL = maBAQL;
		                          _maKhoa = maKhoa ;
		                          _maBN = maBN;
                               
		                          _ngayVKhoa = ngayVKhoa ;
		                           _soPhong = soPhong ;
		                          _soGiuong = soGiuong ;
		                          _ngayKT = ngayKT ;
		                          _maMay = maMay ;
                                  _GoiDichVu = goiDichVu;
		                        //  _huy = huy;
		                            _ngaySD = ngaySD ;
                                    _nguoiSD = NguoiSD;
		                            _maicd = maicd ;
                                    _tenDT = tenDT;
                                  _maDT = maDT ;
                                  _raKhoa = rakhoa;
                                  _hoten = hoten ;
                                  _tuoi = tuoi ;
                                  _ngaySinh = ngaySinh ;
                                  _diaChi = diaChi ;
                                  _gt = gt;
                                     _tongTien = tongtien;
                                     _tongTamthu = tongtamthu;
                                     _tongTienBH = tongtienbh;
                                     _tongTienBNtra = tongTienBNTra;
                                     _ngayQT = ngayqt;
                                     _NguoiQT = nguoiqt;
                                  _tenKhoa = tenkhoa;
                                  _maLoaiBA = maLoaiBA;

              
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
			
			private Int32 _sTTKhoa;
			public Int32 STTKhoa 
			{
				get
				{
					return _sTTKhoa;
				}
			}
			
			public Criteria(String maBA, Int32 sTTKhoa)
			{
				_maBA = maBA;
				_sTTKhoa = sTTKhoa;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBA.Equals(c._maBA)) 
						return false;
					if (!_sTTKhoa.Equals(c._sTTKhoa)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBA.ToString(), _sTTKhoa.ToString()).GetHashCode();
			}
		}
        protected class CriteriaTT
        {
            private String _maBA;
            public String MaBA
            {
                get
                {
                    return _maBA;
                }
            }

            private Int32 _sTTKhoa;
            public Int32 STTKhoa
            {
                get
                {
                    return _sTTKhoa;
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

            public CriteriaTT(String maBA, Int32 sTTKhoa,byte loaikq=0)
            {
                _maBA = maBA;
                _sTTKhoa = sTTKhoa;
                _loaikq = loaikq;
            }

            public override bool Equals(object obj)
            {
                if (obj is CriteriaTT)
                {
                    CriteriaTT c = (CriteriaTT)obj;
                    if (!_maBA.Equals(c._maBA))
                        return false;
                    if (!_sTTKhoa.Equals(c._sTTKhoa))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("CriteriaTT", _maBA.ToString(), _sTTKhoa.ToString()).GetHashCode();
            }
        }

        protected class CriteriaTien
        {
            private String _maBA;
            public String MaBA
            {
                get
                {
                    return _maBA;
                }
            }


            public CriteriaTien(String maBA)
            {
                _maBA = maBA;
               
            }

            public override bool Equals(object obj)
            {
                if (obj is CriteriaTien)
                {
                    CriteriaTien c = (CriteriaTien)obj;
                    if (!_maBA.Equals(c._maBA))
                        return false;
                  
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("CriteriaTien", _maBA.ToString()).GetHashCode();
            }
        }
  
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
            private Int32 _sTTKhoa;
            public Int32 STTKhoa
            {
                get
                {
                    return _sTTKhoa;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maba, Int32 STTKhoa)
            {
                _maBA = maba;
                _sTTKhoa = STTKhoa;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
            }

        }

        protected class CriteriaNew
        {
            private String _maBA;
            public String maBA
            {
                get
                {
                    return _maBA;
                }
            }



            public CriteriaNew(String maBA)
            {
                _maBA = maBA; 
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

		public static bool CanATTObject()
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
		/// Retrieve an existing <see cref="BenhAn_Khoa" /> Object based on data in the database.
		/// </summary>
        protected void DataPortal_Fetch(CriteriaTT crit)
        {
            // public abstract IDataReader GetBenhAn_Khoa(String _maBA, Int32 _sTTKhoa);
            // public override IDataReader GetBenhAn_Khoa(String _maBA, Int32 _sTTKhoa)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Khoa_GET", _maBA, _sTTKhoa));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_KhoaTT(crit.MaBA, crit.STTKhoa,crit.loaikq)))
            {
                if (dr.Read())
                {
                    Fetch(dr,1);
                    MarkOld();
                    ValidationRules.CheckRules();
                }
            }
        }
        protected void DataPortal_Fetch(CriteriaTien crit)
        {
            // public abstract IDataReader GetBenhAn_Khoa(String _maBA, Int32 _sTTKhoa);
            // public override IDataReader GetBenhAn_Khoa(String _maBA, Int32 _sTTKhoa)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Khoa_GET", _maBA, _sTTKhoa));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_Tien(crit.MaBA)))
            {
                if (dr.Read())
                {
                    if (dr.GetDecimal("TongTamThu") != null) _tongTamthu = dr.GetDecimal("TongTamThu");
                    if (dr.GetDecimal("tongTien") != null) _tongTien = dr.GetDecimal("tongTien");
                    if (dr.GetDecimal("tongTienBH") != null) _tongTienBH = dr.GetDecimal("tongTienBH");
                    if (dr.GetDecimal("tongTienBNTra") != null) _tongTienBNtra = dr.GetDecimal("tongTienBNTra");
        
                    MarkOld();
                    ValidationRules.CheckRules();
                }
            }
        }
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetBenhAn_Khoa(String _maBA, Int32 _sTTKhoa);
			// public override IDataReader GetBenhAn_Khoa(String _maBA, Int32 _sTTKhoa)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Khoa_GET", _maBA, _sTTKhoa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_Khoa(crit.MaBA, crit.STTKhoa)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="BenhAn_Khoa" /> Object from given SafeDataReader.
		/// </summary>
         	private void Fetch(SafeDataReader dr,int i)
		{
			// Value properties
       
            if (dr.GetString("sothe") != null) _sothe = dr.GetString("sothe");

            if (dr.GetString("mabv") != null) _maBV = dr.GetString("mabv");
            if (dr.GetString("maloaibn") != null) _maloaibn = dr.GetString("maloaibn");
            if (dr.GetString("tenbv") != null) _tenBV = dr.GetString("tenbv");
            if (dr.GetString("NoiTT") != null) _noiTT = dr.GetString("NoiTT");
            if (dr.GetSmartDate("Ngayduyet", true) != null) _ngayduyet = dr.GetSmartDate("Ngayduyet", true);
            if (dr.GetSmartDate("ngayhuongbh", true) != null) _ngayhuongbh = dr.GetSmartDate("ngayhuongbh", true);
          
            if (dr.GetString("mabhxh") != null) _mabhxh = dr.GetString("mabhxh");
            if (dr.GetSmartDate("giatriTN", true) != null) _giaTriTN = dr.GetSmartDate("giatriTN", true);
		
			if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
			if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
            if (dr.GetInt32("STTDT") != null) _STTDT = dr.GetInt32("STTDT");
			if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
			if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
            if (dr.GetSmartDate("giatriDN", true) != null) _giatriDN = dr.GetSmartDate("giatriDN", true);
            if (dr.GetSmartDate("NgayVVTT", true) != null) _ngayVVTT = dr.GetSmartDate("NgayVVTT", true);
            if (dr.GetBoolean("RaVien") != null) _raVien = dr.GetBoolean("RaVien");
			if (dr.GetSmartDate("NgayVKhoa", true) != null) _ngayVKhoa = dr.GetSmartDate("NgayVKhoa", true);
			if (dr.GetString("MaBenh") != null) _maBenh = dr.GetString("MaBenh");
            if (dr.GetString("MaBenhKem") != null) _maBenhKem = dr.GetString("MaBenhKem");
			if (dr.GetString("MaTienLuong") != null) _maTienLuong = dr.GetString("MaTienLuong");
			if (dr.GetString("BSDieuTri") != null) _bSDieuTri = dr.GetString("BSDieuTri");
			if (dr.GetString("Yta") != null) _yta = dr.GetString("Yta");
			if (dr.GetString("SoPhong") != null) _soPhong = dr.GetString("SoPhong");
            if (dr.GetString("MaBAQL") != null) _maBAQL = dr.GetString("MaBAQL");
            //if (dr.GetString("kethuoc") != null) _kethuoc = dr.GetString("kethuoc");
			if (dr.GetString("SoGiuong") != null) _soGiuong = dr.GetString("SoGiuong");
           			if (dr.GetSmartDate("NgayKT", true) != null) _ngayKT = dr.GetSmartDate("NgayKT", true);
            if (dr.GetBoolean("GoiDichVu") != null) _GoiDichVu = dr.GetBoolean("GoiDichVu");
         
            if (dr.GetByte ("RaKhoa") != null) _raKhoa = dr.GetByte("RaKhoa");
            if (dr.GetString("ghichu") != null) _ghichu  = dr.GetString("ghichu");
            //if (dr.GetString("maicd") != null) _maicd = dr.GetString("maicd");
            if (dr.GetString("tenbenh") != null) _tenbenh = dr.GetString("tenbenh");
            //if (dr.GetString("maicdkem") != null) _maicdkem = dr.GetString("maicdkem");
            //if (dr.GetString("tenbenhkem") != null) _tenbenhkem = dr.GetString("tenbenhkem");
            if (dr.GetString("TenDT") != null) _tenDT = dr.GetString("TenDT");
            if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
            _hoten = dr.GetString("Hoten");
            _tuoi = dr.GetByte("Tuoi");
            _ngaySinh = dr.GetSmartDate("NgaySinh", true);
            _diaChi = dr.GetString("DiaChi");
            _gt = dr.GetBoolean("GT");
            //if (dr.GetString("tenNguoiLap") != null) _tenNguoiLap  = dr.GetString("tenNguoiLap");
            //if (dr.GetString("tenNguoiSD") != null) _tenNguoiSD = dr.GetString("tenNguoiSD");
            //if (dr.GetString("tenNguoiHuy") != null) _tenNguoiHuy = dr.GetString("tenNguoiHuy");
            if (dr.GetString("tenBSChidinh") != null) _tenBSChidinh = dr.GetString("tenBSChidinh");
            //if (dr.GetDecimal("TongTien") != null) _tongTien = dr.GetDecimal("TongTien");
            if (dr.GetString("tenKhoa") != null) _tenKhoa = dr.GetString("tenKhoa");
            if (dr.GetString("MALOAIBA") != null) _maLoaiBA = dr.GetString("MALOAIBA");
            if (dr.GetDecimal("TongTamThu") != null) _tongTamthu = dr.GetDecimal("TongTamThu");
            if (dr.GetDecimal("tongTien") != null) _tongTien = dr.GetDecimal("tongTien");
            if (dr.GetDecimal("tongTienBH") != null) _tongTienBH = dr.GetDecimal("tongTienBH");
            if (dr.GetDecimal("tongTienBNTra") != null) _tongTienBNtra = dr.GetDecimal("tongTienBNTra");
            if (dr.GetSmartDate("NgayQT", true) != null) _ngayQT = dr.GetSmartDate("NgayQT", true);
            if (dr.GetString("nguoiqt") != null) _NguoiQT = dr.GetString("nguoiqt");
        }
	
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
            if (dr.GetSmartDate("Ngayduyet", true) != null) _ngayduyet = dr.GetSmartDate("Ngayduyet", true);
            if (dr.GetSmartDate("ngayhuongbh", true) != null) _ngayhuongbh = dr.GetSmartDate("ngayhuongbh", true);
          
            if (dr.GetString("sothe") != null) _sothe = dr.GetString("sothe");

            if (dr.GetString("mabv") != null) _maBV = dr.GetString("mabv");

            if (dr.GetString("tenbv") != null) _tenBV = dr.GetString("tenbv");
            if (dr.GetString("NoiTT") != null) _noiTT = dr.GetString("NoiTT");
      
            if (dr.GetString("mabhxh") != null) _mabhxh = dr.GetString("mabhxh");
            if (dr.GetSmartDate("giatriTN", true) != null) _giaTriTN = dr.GetSmartDate("giatriTN", true);
            if (dr.GetString("maloaibn") != null) _maloaibn = dr.GetString("maloaibn");
			if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
			if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
            if (dr.GetInt32("STTDT") != null) _STTDT = dr.GetInt32("STTDT");
			if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
			if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
            if (dr.GetSmartDate("giatriDN", true) != null) _giatriDN = dr.GetSmartDate("giatriDN", true);
            if (dr.GetSmartDate("NgayVVTT", true) != null) _ngayVVTT = dr.GetSmartDate("NgayVVTT", true);
            if (dr.GetBoolean("RaVien") != null) _raVien = dr.GetBoolean("RaVien");
			if (dr.GetSmartDate("NgayVKhoa", true) != null) _ngayVKhoa = dr.GetSmartDate("NgayVKhoa", true);
			if (dr.GetString("MaBenh") != null) _maBenh = dr.GetString("MaBenh");
            if (dr.GetString("MaBenhKem") != null) _maBenhKem = dr.GetString("MaBenhKem");
			if (dr.GetString("MaTienLuong") != null) _maTienLuong = dr.GetString("MaTienLuong");
            if (dr.GetString("BSDieuTri") != null) _bSDieuTri = dr.GetString("BSDieuTri");
            //if (dr.GetString("Yta") != null) _yta = dr.GetString("Yta");
			if (dr.GetString("SoPhong") != null) _soPhong = dr.GetString("SoPhong");
            if (dr.GetString("MaBAQL") != null) _maBAQL = dr.GetString("MaBAQL");
            //if (dr.GetString("kethuoc") != null) _kethuoc = dr.GetString("kethuoc");
			if (dr.GetString("SoGiuong") != null) _soGiuong = dr.GetString("SoGiuong");
            //try
            //{
            //    if (_soGiuong != "")
            //        _giuong = decimal.Parse(_soGiuong);
            //}
            //catch
            //{ }
            
			if (dr.GetSmartDate("NgayKT", true) != null) _ngayKT = dr.GetSmartDate("NgayKT", true);
            if (dr.GetBoolean("GoiDichVu") != null) _GoiDichVu = dr.GetBoolean("GoiDichVu");
            //if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            //if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            //if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
            //if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
            //if (dr.GetString("LyDoHuy") != null) _lyDoHuy = dr.GetString("LyDoHuy");
            //if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
            //if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            //if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            //if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            //if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
            //if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetByte ("RaKhoa") != null) _raKhoa = dr.GetByte("RaKhoa");
            if (dr.GetString("ghichu") != null) _ghichu  = dr.GetString("ghichu");
            if (dr.GetString("maicd") != null) _maicd = dr.GetString("maicd");
            if (dr.GetString("tenbenh") != null) _tenbenh = dr.GetString("tenbenh");
            if (dr.GetString("maicdkem") != null) _maicdkem = dr.GetString("maicdkem");
            if (dr.GetString("tenbenhkem") != null) _tenbenhkem = dr.GetString("tenbenhkem");
            if (dr.GetString("TenDT") != null) _tenDT = dr.GetString("TenDT");
            if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
            _hoten = dr.GetString("Hoten");
            _tuoi = dr.GetByte("Tuoi");
            _ngaySinh = dr.GetSmartDate("NgaySinh", true);
            _diaChi = dr.GetString("DiaChi");
            _gt = dr.GetBoolean("GT");
            //if (dr.GetString("tenNguoiLap") != null) _tenNguoiLap  = dr.GetString("tenNguoiLap");
            //if (dr.GetString("tenNguoiSD") != null) _tenNguoiSD = dr.GetString("tenNguoiSD");
            //if (dr.GetString("tenNguoiHuy") != null) _tenNguoiHuy = dr.GetString("tenNguoiHuy");
            if (dr.GetString("tenBSChidinh") != null) _tenBSChidinh = dr.GetString("tenBSChidinh");
            //if (dr.GetDecimal("TongTien") != null) _tongTien = dr.GetDecimal("TongTien");
            if (dr.GetString("tenKhoa") != null) _tenKhoa = dr.GetString("tenKhoa");
            if (dr.GetString("MALOAIBA") != null) _maLoaiBA = dr.GetString("MALOAIBA");
            if (dr.GetDecimal("TongTamThu") != null) _tongTamthu = dr.GetDecimal("TongTamThu");
            if (dr.GetDecimal("tongTien") != null) _tongTien = dr.GetDecimal("tongTien");
            if (dr.GetDecimal("tongTienBH") != null) _tongTienBH = dr.GetDecimal("tongTienBH");
            if (dr.GetDecimal("tongTienBNTra") != null) _tongTienBNtra = dr.GetDecimal("tongTienBNTra");
            if (dr.GetSmartDate("NgayQT", true) != null) _ngayQT = dr.GetSmartDate("NgayQT", true);
            if (dr.GetString("nguoiqt") != null) _NguoiQT = dr.GetString("nguoiqt");

        }
		
		/// <summary>
		/// Insert the new <see cref="BenhAn_Khoa" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            //MarkAsChild();
            //ValidationRules.CheckRules();
            //MarkOld();
        }
        protected void DataPortal_Create(CriteriaNew param)
        {
            _maBA = param.maBA;
            //ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_Khoa
			// Copy & paste ham duoi day vao file DataProvider.cs
			_sTTKhoa = DataProvider.Instance().InsertBenhAn_Khoa(_maBA, _maKhoa, _maBN, _ngayVKhoa, _maBenh, _maBenhKem, _maTienLuong, _bSDieuTri, _yta, _soPhong, _soGiuong, _ngayKT,_maMay ,_nguoiSD, _ghichu, _tenbenh );
			// public abstract String InsertBenhAn_Khoa(String _maBA, String _maKhoa, String _maBN, SmartDate _ngayVKhoa, String _maBenh, String _maBenhKem, String _maTienLuong, String _bSDieuTri, String _yta, String _soPhong, String _soGiuong, SmartDate _ngayKT, String _maMay, String _nguoiLap);
			// public override String InsertBenhAn_Khoa(String _maBA, String _maKhoa, String _maBN, SmartDate _ngayVKhoa, String _maBenh, String _maBenhKem, String _maTienLuong, String _bSDieuTri, String _yta, String _soPhong, String _soGiuong, SmartDate _ngayKT, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBENHAN_KHOA_CREATE", _maBA,  _maKhoa, _maBN, _ngayVKhoa.DBValue, _maBenh, _maBenhKem, _maTienLuong, _bSDieuTri, _yta, _soPhong, _soGiuong, _ngayKT.DBValue,_maMay ,   _nguoiLap);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAn_Khoa" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_Khoa
			if (IsDirty){
                DataProvider.Instance().UpdateBenhAn_Khoa(_maBA, _sTTKhoa, _maKhoa, _maBN, _ngayVKhoa, _maBenh, _maBenhKem, _maTienLuong, _bSDieuTri, _yta, _soPhong, _soGiuong,_ngayKT,_maMay ,  _huy,_nguoiSD, _raKhoa, _ghichu, _tenbenh,_tenbenhkem);
				// public abstract void UpdateBenhAn_Khoa(String _maBA, Int32 _sTTKhoa, String _maKhoa, String _maBN, SmartDate _ngayVKhoa, String _maBenh, String _maBenhKem, String _maTienLuong, String _bSDieuTri, String _yta, String _soPhong, String _soGiuong, SmartDate _ngayKT, String _maMay, Boolean _huy, String _nguoiHuy, Byte _raKhoa);
				// public override void UpdateBenhAn_Khoa(String _maBA, Int32 _sTTKhoa, String _maKhoa, String _maBN, SmartDate _ngayVKhoa, String _maBenh, String _maBenhKem, String _maTienLuong, String _bSDieuTri, String _yta, String _soPhong, String _soGiuong, SmartDate _ngayKT, String _maMay, Boolean _huy, String _nguoiHuy, Byte _raKhoa)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBENHAN_KHOA_UPDATE", _maBA, _sTTKhoa, _maKhoa, _maBN, _ngayVKhoa.DBValue, _maBenh, _maBenhKem, _maTienLuong, _bSDieuTri, _yta, _soPhong, _soGiuong, _ngayKT.DBValue,_maMay ,   _huy,_nguoiSD, _raKhoa);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD   , _maBA, _sTTKhoa));
		}

		/// <summary>
		/// Delete the <see cref="BenhAn_Khoa" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_Khoa
            DataProvider.Instance().DeleteBenhAn_Khoa(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.STTKhoa);
			// public abstract void DeleteBenhAn_Khoa(String _maBA, Int32 _sTTKhoa);
			// public override void DeleteBenhAn_Khoa(String _maBA, Int32 _sTTKhoa);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBENHAN_KHOA_DELETED", _maBA, _sTTKhoa);
			// }
		}

		#endregion
	}

}
