// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	KhamBenh_TM
// Kieu doi tuong  :	KhamBenh_TM
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	4/2/2009 2:30:29 PM
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
using HTC.Business.CategoryList;

namespace HTC.Business.PhongKham
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="KhamBenh_TM" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class KhamBenh_TM : BusinessBase<KhamBenh_TM>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maSoKham = String.Empty;
		private Int32 _sTT = 0;
		private String _maDV = String.Empty;
		private String _lyDoKham = String.Empty;
		private String _mach = String.Empty;
		private String _apHuyet = String.Empty;
		private String _nhietDo = String.Empty;
		private String _nhipTho = String.Empty;
		private String _canNang = String.Empty;
		private String _chieuCao = String.Empty;
		private Boolean _da = false;
		private Boolean _phu = false;
		private Boolean _ngonTay = false;
		private Boolean _hach = false;
		private Boolean _khotho = false;
		private Boolean _ho = false;
		private Boolean _daunguc = false;
		private Boolean _tim = false;
		private Boolean _ngoiXom = false;
		private Boolean _ngat = false;
		private Boolean _hoihop = false;
		private String _dauhieuKhac = String.Empty;
		private String _longnguc = String.Empty;
		private String _vitrimomtim = String.Empty;
		private String _tiengtim = String.Empty;
		private String _tiengthoitim = String.Empty;
		private String _tiengthoimach = String.Empty;
		private String _tiengthoikhac = String.Empty;
		private String _machtuchi = String.Empty;
		private String _hohap = String.Empty;
		private String _bung = String.Empty;
		private String _thanhkinh = String.Empty;
		private String _coquankhac = String.Empty;
		private String _chanDoanBD = String.Empty;
		private String _dieuTri = String.Empty;
		private String _benhSu = String.Empty;
		private String _huongDT = String.Empty;
		private String _mabenh = String.Empty;
		private String _maBenhKem = String.Empty;
		private String _machuyenkhoa = String.Empty;
		private String _maPhieuHen = String.Empty;
		private SmartDate _ngayHen = new SmartDate(true);
		private String _maMay = String.Empty;
		private Boolean _huy = false ;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
		private String _mABV = String.Empty;
		private SmartDate _ngayVV = new SmartDate(true);
		private String _makhoaVV = String.Empty;
        private String _makhoaChoVV = String.Empty;
        private String _tenkhoaVV = String.Empty;
        private String _tenbv = String.Empty;
        private String _tenbenh = String.Empty;
        private String _tenbenhkem = String.Empty;
        private String _maicd = String.Empty;
        private String _mabhxh = String.Empty;
        private String _maicdkem = String.Empty;
        private String _maicdbd = String.Empty;
        private String _maicdngt = String.Empty;
        private String _tenbenhbd = String.Empty;
        private String _tenbenhngt = String.Empty;
        private String _mabenhngt = String.Empty;
        private Byte  _NNCapcuu = 0;
        private String _nYHA = String.Empty;
		#endregion
		
		#region Business Properties and Methods

        public byte NNCapcuu
		{
			get 
			{
                CanReadProperty("NNCapcuu", true);
                return _NNCapcuu;
			}
			set 
			{
                CanWriteProperty("NNCapcuu", true);
                if (_NNCapcuu != value) 
				{
                    _NNCapcuu = value;
                    PropertyHasChanged("NNCapcuu");
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
      
        public String maicdbd
        {
            get
            {
                CanReadProperty("maicdbd", true);
                return _maicdbd;
            }
            set
            {
                CanWriteProperty("maicdbd", true);
                if (_maicdbd != value)
                {
                    _maicdbd = value;
                    PropertyHasChanged("maicdbd");
                }
            }
        }
        public String tenbenhbd
        {
            get
            {
                CanReadProperty("tenbenhbd", true);
                return _tenbenhbd;
            }
            set
            {
                CanWriteProperty("tenbenhbd", true);
                if (_tenbenhbd != value)
                {
                    _tenbenhbd = value;
                    PropertyHasChanged("tenbenhbd");
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
        public String mabenhngt
        {
            get
            {
                CanReadProperty("mabenhngt", true);
                return _mabenhngt;
            }
            set
            {
                CanWriteProperty("mabenhngt", true);
                if (_mabenhngt != value)
                {
                    _mabenhngt = value;
                    PropertyHasChanged("mabenhngt");
                }
            }
        }
		public Int32 STT
		{
			get 
			{
				CanReadProperty("STT", true);
				return _sTT;
			}
			set 
			{
				CanWriteProperty("STT", true);
				if (_sTT != value) 
				{
					_sTT = value;
					PropertyHasChanged("STT");
				}
			}
		}
		
		public String MaDV
		{
			get 
			{
				CanReadProperty("MaDV", true);
				return _maDV;
			}
			set 
			{
				CanWriteProperty("MaDV", true);
				if (_maDV != value) 
				{
					_maDV = value;
					PropertyHasChanged("MaDV");
				}
			}
		}
		
		public String LyDoKham
		{
			get 
			{
				CanReadProperty("LyDoKham", true);
				return _lyDoKham;
			}
			set 
			{
				CanWriteProperty("LyDoKham", true);
				if (_lyDoKham != value) 
				{
					_lyDoKham = value;
					PropertyHasChanged("LyDoKham");
				}
			}
		}
		
		public String Mach
		{
			get 
			{
				CanReadProperty("Mach", true);
				return _mach;
			}
			set 
			{
				CanWriteProperty("Mach", true);
				if (_mach != value) 
				{
					_mach = value;
					PropertyHasChanged("Mach");
				}
			}
		}
		
		public String ApHuyet
		{
			get 
			{
				CanReadProperty("ApHuyet", true);
				return _apHuyet;
			}
			set 
			{
				CanWriteProperty("ApHuyet", true);
				if (_apHuyet != value) 
				{
					_apHuyet = value;
					PropertyHasChanged("ApHuyet");
				}
			}
		}
		
		public String NhietDo
		{
			get 
			{
				CanReadProperty("NhietDo", true);
				return _nhietDo;
			}
			set 
			{
				CanWriteProperty("NhietDo", true);
				if (_nhietDo != value) 
				{
					_nhietDo = value;
					PropertyHasChanged("NhietDo");
				}
			}
		}
		
		public String NhipTho
		{
			get 
			{
				CanReadProperty("NhipTho", true);
				return _nhipTho;
			}
			set 
			{
				CanWriteProperty("NhipTho", true);
				if (_nhipTho != value) 
				{
					_nhipTho = value;
					PropertyHasChanged("NhipTho");
				}
			}
		}
		
		public String CanNang
		{
			get 
			{
				CanReadProperty("CanNang", true);
				return _canNang;
			}
			set 
			{
				CanWriteProperty("CanNang", true);
				if (_canNang != value) 
				{
					_canNang = value;
					PropertyHasChanged("CanNang");
				}
			}
		}
		
		public String ChieuCao
		{
			get 
			{
				CanReadProperty("ChieuCao", true);
				return _chieuCao;
			}
			set 
			{
				CanWriteProperty("ChieuCao", true);
				if (_chieuCao != value) 
				{
					_chieuCao = value;
					PropertyHasChanged("ChieuCao");
				}
			}
		}
		
		public Boolean Da
		{
			get 
			{
				CanReadProperty("Da", true);
				return _da;
			}
			set 
			{
				CanWriteProperty("Da", true);
				if (_da != value) 
				{
					_da = value;
					PropertyHasChanged("Da");
				}
			}
		}
		
		public Boolean Phu
		{
			get 
			{
				CanReadProperty("Phu", true);
				return _phu;
			}
			set 
			{
				CanWriteProperty("Phu", true);
				if (_phu != value) 
				{
					_phu = value;
					PropertyHasChanged("Phu");
				}
			}
		}
		
		public Boolean NgonTay
		{
			get 
			{
				CanReadProperty("NgonTay", true);
				return _ngonTay;
			}
			set 
			{
				CanWriteProperty("NgonTay", true);
				if (_ngonTay != value) 
				{
					_ngonTay = value;
					PropertyHasChanged("NgonTay");
				}
			}
		}
		
		public Boolean Hach
		{
			get 
			{
				CanReadProperty("Hach", true);
				return _hach;
			}
			set 
			{
				CanWriteProperty("Hach", true);
				if (_hach != value) 
				{
					_hach = value;
					PropertyHasChanged("Hach");
				}
			}
		}
		
		public Boolean Khotho
		{
			get 
			{
				CanReadProperty("Khotho", true);
				return _khotho;
			}
			set 
			{
				CanWriteProperty("Khotho", true);
				if (_khotho != value) 
				{
					_khotho = value;
					PropertyHasChanged("Khotho");
				}
			}
		}
		
		public Boolean Ho
		{
			get 
			{
				CanReadProperty("Ho", true);
				return _ho;
			}
			set 
			{
				CanWriteProperty("Ho", true);
				if (_ho != value) 
				{
					_ho = value;
					PropertyHasChanged("Ho");
				}
			}
		}
		
		public Boolean Daunguc
		{
			get 
			{
				CanReadProperty("Daunguc", true);
				return _daunguc;
			}
			set 
			{
				CanWriteProperty("Daunguc", true);
				if (_daunguc != value) 
				{
					_daunguc = value;
					PropertyHasChanged("Daunguc");
				}
			}
		}
		
		public Boolean Tim
		{
			get 
			{
				CanReadProperty("Tim", true);
				return _tim;
			}
			set 
			{
				CanWriteProperty("Tim", true);
				if (_tim != value) 
				{
					_tim = value;
					PropertyHasChanged("Tim");
				}
			}
		}
		
		public Boolean NgoiXom
		{
			get 
			{
				CanReadProperty("NgoiXom", true);
				return _ngoiXom;
			}
			set 
			{
				CanWriteProperty("NgoiXom", true);
				if (_ngoiXom != value) 
				{
					_ngoiXom = value;
					PropertyHasChanged("NgoiXom");
				}
			}
		}
		
		public Boolean Ngat
		{
			get 
			{
				CanReadProperty("Ngat", true);
				return _ngat;
			}
			set 
			{
				CanWriteProperty("Ngat", true);
				if (_ngat != value) 
				{
					_ngat = value;
					PropertyHasChanged("Ngat");
				}
			}
		}
		
		public Boolean Hoihop
		{
			get 
			{
				CanReadProperty("Hoihop", true);
				return _hoihop;
			}
			set 
			{
				CanWriteProperty("Hoihop", true);
				if (_hoihop != value) 
				{
					_hoihop = value;
					PropertyHasChanged("Hoihop");
				}
			}
		}
		
		public String DauhieuKhac
		{
			get 
			{
				CanReadProperty("DauhieuKhac", true);
				return _dauhieuKhac;
			}
			set 
			{
				CanWriteProperty("DauhieuKhac", true);
				if (_dauhieuKhac != value) 
				{
					_dauhieuKhac = value;
					PropertyHasChanged("DauhieuKhac");
				}
			}
		}
		
		public String Longnguc
		{
			get 
			{
				CanReadProperty("Longnguc", true);
				return _longnguc;
			}
			set 
			{
				CanWriteProperty("Longnguc", true);
				if (_longnguc != value) 
				{
					_longnguc = value;
					PropertyHasChanged("Longnguc");
				}
			}
		}
		
		public String Vitrimomtim
		{
			get 
			{
				CanReadProperty("Vitrimomtim", true);
				return _vitrimomtim;
			}
			set 
			{
				CanWriteProperty("Vitrimomtim", true);
				if (_vitrimomtim != value) 
				{
					_vitrimomtim = value;
					PropertyHasChanged("Vitrimomtim");
				}
			}
		}
		
		public String Tiengtim
		{
			get 
			{
				CanReadProperty("Tiengtim", true);
				return _tiengtim;
			}
			set 
			{
				CanWriteProperty("Tiengtim", true);
				if (_tiengtim != value) 
				{
					_tiengtim = value;
					PropertyHasChanged("Tiengtim");
				}
			}
		}
		
		public String Tiengthoitim
		{
			get 
			{
				CanReadProperty("Tiengthoitim", true);
				return _tiengthoitim;
			}
			set 
			{
				CanWriteProperty("Tiengthoitim", true);
				if (_tiengthoitim != value) 
				{
					_tiengthoitim = value;
					PropertyHasChanged("Tiengthoitim");
				}
			}
		}
		
		public String Tiengthoimach
		{
			get 
			{
				CanReadProperty("Tiengthoimach", true);
				return _tiengthoimach;
			}
			set 
			{
				CanWriteProperty("Tiengthoimach", true);
				if (_tiengthoimach != value) 
				{
					_tiengthoimach = value;
					PropertyHasChanged("Tiengthoimach");
				}
			}
		}
		
		public String Tiengthoikhac
		{
			get 
			{
				CanReadProperty("Tiengthoikhac", true);
				return _tiengthoikhac;
			}
			set 
			{
				CanWriteProperty("Tiengthoikhac", true);
				if (_tiengthoikhac != value) 
				{
					_tiengthoikhac = value;
					PropertyHasChanged("Tiengthoikhac");
				}
			}
		}
		
		public String Machtuchi
		{
			get 
			{
				CanReadProperty("Machtuchi", true);
				return _machtuchi;
			}
			set 
			{
				CanWriteProperty("Machtuchi", true);
				if (_machtuchi != value) 
				{
					_machtuchi = value;
					PropertyHasChanged("Machtuchi");
				}
			}
		}
		
		public String Hohap
		{
			get 
			{
				CanReadProperty("Hohap", true);
				return _hohap;
			}
			set 
			{
				CanWriteProperty("Hohap", true);
				if (_hohap != value) 
				{
					_hohap = value;
					PropertyHasChanged("Hohap");
				}
			}
		}
		
		public String Bung
		{
			get 
			{
				CanReadProperty("Bung", true);
				return _bung;
			}
			set 
			{
				CanWriteProperty("Bung", true);
				if (_bung != value) 
				{
					_bung = value;
					PropertyHasChanged("Bung");
				}
			}
		}
		
		public String Thanhkinh
		{
			get 
			{
				CanReadProperty("Thanhkinh", true);
				return _thanhkinh;
			}
			set 
			{
				CanWriteProperty("Thanhkinh", true);
				if (_thanhkinh != value) 
				{
					_thanhkinh = value;
					PropertyHasChanged("Thanhkinh");
				}
			}
		}
		
		public String Coquankhac
		{
			get 
			{
				CanReadProperty("Coquankhac", true);
				return _coquankhac;
			}
			set 
			{
				CanWriteProperty("Coquankhac", true);
				if (_coquankhac != value) 
				{
					_coquankhac = value;
					PropertyHasChanged("Coquankhac");
				}
			}
		}
		
		public String ChanDoanBD
		{
			get 
			{
				CanReadProperty("ChanDoanBD", true);
				return _chanDoanBD;
			}
			set 
			{
				CanWriteProperty("ChanDoanBD", true);
				if (_chanDoanBD != value) 
				{
					_chanDoanBD = value;
					PropertyHasChanged("ChanDoanBD");
				}
			}
		}
		
		public String DieuTri
		{
			get 
			{
				CanReadProperty("DieuTri", true);
				return _dieuTri;
			}
			set 
			{
				CanWriteProperty("DieuTri", true);
				if (_dieuTri != value) 
				{
					_dieuTri = value;
					PropertyHasChanged("DieuTri");
				}
			}
		}
		
		public String BenhSu
		{
			get 
			{
				CanReadProperty("BenhSu", true);
				return _benhSu;
			}
			set 
			{
				CanWriteProperty("BenhSu", true);
				if (_benhSu != value) 
				{
					_benhSu = value;
					PropertyHasChanged("BenhSu");
				}
			}
		}
		
		public String HuongDT
		{
			get 
			{
				CanReadProperty("HuongDT", true);
				return _huongDT;
			}
			set 
			{
				CanWriteProperty("HuongDT", true);
				if (_huongDT != value) 
				{
					_huongDT = value;
					PropertyHasChanged("HuongDT");
				}
			}
		}
		
		public String Mabenh
		{
			get 
			{
				CanReadProperty("Mabenh", true);
				return _mabenh;
			}
			set 
			{
				CanWriteProperty("Mabenh", true);
				if (_mabenh != value) 
				{
					_mabenh = value;
					PropertyHasChanged("Mabenh");
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
		
		public String Machuyenkhoa
		{
			get 
			{
				CanReadProperty("Machuyenkhoa", true);
				return _machuyenkhoa;
			}
			set 
			{
				CanWriteProperty("Machuyenkhoa", true);
				if (_machuyenkhoa != value) 
				{
					_machuyenkhoa = value;
					PropertyHasChanged("Machuyenkhoa");
				}
			}
		}
		
		public String MaPhieuHen
		{
			get 
			{
				CanReadProperty("MaPhieuHen", true);
				return _maPhieuHen;
			}
			set 
			{
				CanWriteProperty("MaPhieuHen", true);
				if (_maPhieuHen != value) 
				{
					_maPhieuHen = value;
					PropertyHasChanged("MaPhieuHen");
				}
			}
		}
		
		public string NgayHen
		{
			get 
			{
				CanReadProperty("NgayHen", true);
				return _ngayHen.Text;
			}
			set 
			{
				CanWriteProperty("NgayHen", true);
				if (_ngayHen.Text != value) 
				{
					_ngayHen.Text = value;
					PropertyHasChanged("NgayHen");
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
		
		public String MABV
		{
			get 
			{
				CanReadProperty("MABV", true);
				return _mABV;
			}
			set 
			{
				CanWriteProperty("MABV", true);
				if (_mABV != value) 
				{
					_mABV = value;
					PropertyHasChanged("MABV");
				}
			}
		}
        public String NYHA
        {
            get
            {
                CanReadProperty("NYHA", true);
                return _nYHA;
            }
            set
            {
                CanWriteProperty("NYHA", true);
                if (_nYHA != value)
                {
                    _nYHA = value;
                    PropertyHasChanged("NYHA");
                }
            }
        }
		
		public string NgayVV
		{
			get 
			{
				CanReadProperty("NgayVV", true);
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
		
		public String MakhoaVV
		{
			get 
			{
				CanReadProperty("MakhoaVV", true);
				return _makhoaVV;
			}
			set 
			{
				CanWriteProperty("MakhoaVV", true);
				if (_makhoaVV != value) 
				{
					_makhoaVV = value;
					PropertyHasChanged("MakhoaVV");
				}
			}
		}
        public String MakhoaChoVV
        {
            get
            {
                CanReadProperty("MakhoaChoVV", true);
                return _makhoaChoVV;
            }
            set
            {
                CanWriteProperty("MakhoaChoVV", true);
                if (_makhoaChoVV != value)
                {
                    _makhoaChoVV = value;
                    PropertyHasChanged("MakhoaChoVV");
                }
            }
        }
        public String TenkhoaVV
        {
            get
            {
                CanReadProperty("TenkhoaVV", true);
                return _tenkhoaVV;
            }
            set
            {
                CanWriteProperty("TenkhoaVV", true);
                if (_tenkhoaVV != value)
                {
                    _tenkhoaVV = value;
                    PropertyHasChanged("TenkhoaVV");
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
        public String tenbenhkem
        {
            get
            {
                CanReadProperty("tenbenhkem", true);
                return _tenbenhkem;
            }
            set
            {
                CanWriteProperty("tenbenhkem", true);
                if (_tenbenhkem != value)
                {
                    _tenbenhkem = value;
                    PropertyHasChanged("tenbenhkem");
                }
            }
        }
		protected override Object GetIdValue()
		{
			return _maSoKham.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="KhamBenh_TM" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

        public static KhamBenh_TM NewKhamBenh_TM()
        {
            return new KhamBenh_TM();
            //return DataPortal.Create<DMDichVu_PhieuIn_C>();
        }
        public static KhamBenh_TM NewKhamBenh_TM(string idDMDichvu)
        {
            return new KhamBenh_TM(DMDichVu.GetDMDichVu(idDMDichvu));
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static KhamBenh_TM NewKhamBenh_TM(DMDichVu _DMDichvu)
        {
            return new KhamBenh_TM(_DMDichvu);
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static KhamBenh_TM NewKhamBenh_TM(string masokham, Int32 stt,  string idDMDichvu)
		{
            return new KhamBenh_TM(masokham, stt, idDMDichvu);
		}

		public static KhamBenh_TM GetKhamBenh_TM(String maSoKham, Int32 sTT)
		{
			return DataPortal.Fetch<KhamBenh_TM>(new Criteria(maSoKham, sTT));
		}

        public static KhamBenh_TM GetKhamBenh_TM(SafeDataReader dr)
        {
            return new KhamBenh_TM(dr);
        }
		
		/// <summary>
		/// Marks the <see cref="KhamBenh_TM" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteKhamBenh_TM(String maSoKham, Int32 sTT, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maSoKham, sTT));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal KhamBenh_TM()
		{	
			// Prevent direct creation
		}
		
        protected KhamBenh_TM(DMDichVu pro)
        {
            MarkAsChild();
           
            //_maPhieu = dr.GetString("MaPhieu");
            _maDV = pro.MaDV;
           // _maMay = pro.MaMay;
           // _huy = pro.Huy;
           //// _ngaySD = pro.NgaySD ;
           // _nguoiSD = pro.NguoiSD;
        //     _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_TM(string maSoKham,DMDichVu pro)
        {
            MarkAsChild();

            _maSoKham = maSoKham;
            _maDV = pro.MaDV;
            _maMay = pro.MaMay;
            _huy = pro.Huy;
            // _ngaySD = pro.NgaySD ;
            _nguoiSD = pro.NguoiSD;
          //  _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_TM(string masokham, Int32 stt, string idDMDichvu)
        {
            MarkAsChild();

            _maSoKham = masokham ;
            _maDV = idDMDichvu ;
            _sTT = stt;
            //  _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_TM(SafeDataReader dr)
        {
            MarkAsChild();

            Fetch(dr);
            MarkOld();
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
			
			private Int32 _sTT;
			public Int32 STT 
			{
				get
				{
					return _sTT;
				}
			}
			
			public Criteria(String maSoKham, Int32 sTT)
			{
				_maSoKham = maSoKham;
				_sTT = sTT;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maSoKham.Equals(c._maSoKham)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maSoKham.ToString(), _sTT.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maSoKham;
            public String maSoKham
            {
                get
                {
                    return _maSoKham;
                }
            }

            private int _sTT;
            public int sTT
            {
                get
                {
                    return _sTT;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maSoKham, int sTT)
            {
                _maSoKham = maSoKham;
                _sTT = sTT;
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
		/// Retrieve an existing <see cref="KhamBenh_TM" /> Object based on data in the database.
		/// </summary>
        /// 


		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetKhamBenh_TM(String _maSoKham, Int32 _sTT);
			// public override IDataReader GetKhamBenh_TM(String _maSoKham, Int32 _sTT)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_TM_GET", _maSoKham, _sTT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKhamBenh_TM(crit.MaSoKham, crit.STT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="KhamBenh_TM" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaSoKham") != null) _maSoKham = dr.GetString("MaSoKham");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
			if (dr.GetString("LyDoKham") != null) _lyDoKham = dr.GetString("LyDoKham");
			if (dr.GetString("Mach") != null) _mach = dr.GetString("Mach");
			if (dr.GetString("ApHuyet") != null) _apHuyet = dr.GetString("ApHuyet");
			if (dr.GetString("NhietDo") != null) _nhietDo = dr.GetString("NhietDo");
			if (dr.GetString("NhipTho") != null) _nhipTho = dr.GetString("NhipTho");
			if (dr.GetString("CanNang") != null) _canNang = dr.GetString("CanNang");
			if (dr.GetString("ChieuCao") != null) _chieuCao = dr.GetString("ChieuCao");
			if (dr.GetBoolean("Da") != null) _da = dr.GetBoolean("Da");
			if (dr.GetBoolean("Phu") != null) _phu = dr.GetBoolean("Phu");
			if (dr.GetBoolean("NgonTay") != null) _ngonTay = dr.GetBoolean("NgonTay");
			if (dr.GetBoolean("Hach") != null) _hach = dr.GetBoolean("Hach");
			if (dr.GetBoolean("Khotho") != null) _khotho = dr.GetBoolean("Khotho");
			if (dr.GetBoolean("Ho") != null) _ho = dr.GetBoolean("Ho");
			if (dr.GetBoolean("Daunguc") != null) _daunguc = dr.GetBoolean("Daunguc");
			if (dr.GetBoolean("Tim") != null) _tim = dr.GetBoolean("Tim");
			if (dr.GetBoolean("NgoiXom") != null) _ngoiXom = dr.GetBoolean("NgoiXom");
			if (dr.GetBoolean("Ngat") != null) _ngat = dr.GetBoolean("Ngat");
			if (dr.GetBoolean("Hoihop") != null) _hoihop = dr.GetBoolean("Hoihop");
			if (dr.GetString("DauhieuKhac") != null) _dauhieuKhac = dr.GetString("DauhieuKhac");
			if (dr.GetString("Longnguc") != null) _longnguc = dr.GetString("Longnguc");
			if (dr.GetString("Vitrimomtim") != null) _vitrimomtim = dr.GetString("Vitrimomtim");
			if (dr.GetString("Tiengtim") != null) _tiengtim = dr.GetString("Tiengtim");
			if (dr.GetString("Tiengthoitim") != null) _tiengthoitim = dr.GetString("Tiengthoitim");
			if (dr.GetString("Tiengthoimach") != null) _tiengthoimach = dr.GetString("Tiengthoimach");
			if (dr.GetString("Tiengthoikhac") != null) _tiengthoikhac = dr.GetString("Tiengthoikhac");
			if (dr.GetString("Machtuchi") != null) _machtuchi = dr.GetString("Machtuchi");
			if (dr.GetString("Hohap") != null) _hohap = dr.GetString("Hohap");
			if (dr.GetString("Bung") != null) _bung = dr.GetString("Bung");
			if (dr.GetString("Thanhkinh") != null) _thanhkinh = dr.GetString("Thanhkinh");
			if (dr.GetString("Coquankhac") != null) _coquankhac = dr.GetString("Coquankhac");
			if (dr.GetString("ChanDoanBD") != null) _chanDoanBD = dr.GetString("ChanDoanBD");
			if (dr.GetString("DieuTri") != null) _dieuTri = dr.GetString("DieuTri");
			if (dr.GetString("BenhSu") != null) _benhSu = dr.GetString("BenhSu");
			if (dr.GetString("HuongDT") != null) _huongDT = dr.GetString("HuongDT");
			if (dr.GetString("Mabenh") != null) _mabenh = dr.GetString("Mabenh");
			if (dr.GetString("MaBenhKem") != null) _maBenhKem = dr.GetString("MaBenhKem");
			if (dr.GetString("Machuyenkhoa") != null) _machuyenkhoa = dr.GetString("Machuyenkhoa");
			if (dr.GetString("MaPhieuHen") != null) _maPhieuHen = dr.GetString("MaPhieuHen");
			if (dr.GetSmartDate("NgayHen", true) != null) _ngayHen = dr.GetSmartDate("NgayHen", true);
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
			if (dr.GetString("MABV") != null) _mABV = dr.GetString("MABV");
			if (dr.GetSmartDate("NgayVV", true) != null) _ngayVV = dr.GetSmartDate("NgayVV", true);
			if (dr.GetString("MakhoaVV") != null) _makhoaVV = dr.GetString("MakhoaVV");
            if (dr.GetString("MakhoachoVV") != null) _makhoaChoVV = dr.GetString("MakhoachoVV");
            if (dr.GetString("tenkhoavv") != null) _tenkhoaVV = dr.GetString("tenkhoavv");
            if (dr.GetString("tenbenhkem") != null) _tenbenhkem = dr.GetString("tenbenhkem");
           // if (dr.GetString("tenbenh") != null) _tenbenh = dr.GetString("tenbenh");
            if (dr.GetString("tenbv") != null) _tenbv = dr.GetString("tenbv");
             if (dr.GetString("maicd") != null) _maicd = dr.GetString("maicd");
            if (dr.GetString("maicdkem") != null) _maicdkem = dr.GetString("maicdkem");
             if (dr.GetString("maicdbd") != null) _maicdbd = dr.GetString("maicdbd");
            if (dr.GetString("maicdngt") != null) _maicdngt = dr.GetString("maicdngt");
             if (dr.GetString("tenbenhbd") != null) _tenbenhbd = dr.GetString("tenbenhbd");
             if (dr.GetString("mabenhngt") != null) _mabenhngt = dr.GetString("mabenhngt");
             if (dr.GetByte("nncapcuu") != null) _NNCapcuu = dr.GetByte("nncapcuu");
             if (dr.GetString("tenbenhngt") != null) _tenbenhngt = dr.GetString("tenbenhngt");
            if (dr.GetString("mabhxh") != null) _mabhxh = dr.GetString("mabhxh");
            if (dr.GetString("NYHA") != null) _nYHA = dr.GetString("NYHA");
            
		}
		
		/// <summary>
		/// Insert the new <see cref="KhamBenh_TM" /> Object to underlying database.
		/// </summary>
        internal virtual void Insert(KhamBenh_C obj)
        {
            
              
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh_TM
			// Copy & paste ham duoi day vao file DataProvider.cs
            obj.MaSoKham = DataProvider.Instance().InsertKhamBenh_TM(obj.MaSoKham, obj.STT, obj.MaDV, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _da, _phu, _ngonTay, _hach, _khotho, _ho, _daunguc, _tim, _ngoiXom, _ngat, _hoihop, _dauhieuKhac, _longnguc, _vitrimomtim, _tiengtim, _tiengthoitim, _tiengthoimach, _tiengthoikhac, _machtuchi, _hohap, _bung, _thanhkinh, _coquankhac, _chanDoanBD, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _machuyenkhoa, _maPhieuHen, _ngayHen, _maMay, _nguoiSD , _mABV, _ngayVV, _makhoaVV, _makhoaChoVV, _tenbenhbd, _nYHA);
            MarkOld();// public abstract String InsertKhamBenh_TM(String _maSoKham, Int32 _sTT, String _maDV, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _da, Boolean _phu, Boolean _ngonTay, Boolean _hach, Boolean _khotho, Boolean _ho, Boolean _daunguc, Boolean _tim, Boolean _ngoiXom, Boolean _ngat, Boolean _hoihop, String _dauhieuKhac, String _longnguc, String _vitrimomtim, String _tiengtim, String _tiengthoitim, String _tiengthoimach, String _tiengthoikhac, String _machtuchi, String _hohap, String _bung, String _thanhkinh, String _coquankhac, String _chanDoanBD, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maPhieuHen, SmartDate _ngayHen, String _maMay, String _nguoiSD, String _mABV, SmartDate _ngayVV, String _makhoaVV);
			// public override String InsertKhamBenh_TM(String _maSoKham, Int32 _sTT, String _maDV, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _da, Boolean _phu, Boolean _ngonTay, Boolean _hach, Boolean _khotho, Boolean _ho, Boolean _daunguc, Boolean _tim, Boolean _ngoiXom, Boolean _ngat, Boolean _hoihop, String _dauhieuKhac, String _longnguc, String _vitrimomtim, String _tiengtim, String _tiengthoitim, String _tiengthoimach, String _tiengthoikhac, String _machtuchi, String _hohap, String _bung, String _thanhkinh, String _coquankhac, String _chanDoanBD, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maPhieuHen, SmartDate _ngayHen, String _maMay, String _nguoiSD, String _mABV, SmartDate _ngayVV, String _makhoaVV)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_TM_CREATE", _maSoKham, _sTT, _maDV, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _da, _phu, _ngonTay, _hach, _khotho, _ho, _daunguc, _tim, _ngoiXom, _ngat, _hoihop, _dauhieuKhac, _longnguc, _vitrimomtim, _tiengtim, _tiengthoitim, _tiengthoimach, _tiengthoikhac, _machtuchi, _hohap, _bung, _thanhkinh, _coquankhac, _chanDoanBD, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _machuyenkhoa, _maPhieuHen, _ngayHen.DBValue, _maMay, _nguoiSD , _mABV, _ngayVV.DBValue, _makhoaVV));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="KhamBenh_TM" /> Object to underlying database.
		/// </summary>
        internal virtual void Update(KhamBenh_C obj)
        {
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_TM
			if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateKhamBenh_TM(obj.MaSoKham, _sTT, _maDV, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _da, _phu, _ngonTay, _hach, _khotho, _ho, _daunguc, _tim, _ngoiXom, _ngat, _hoihop, _dauhieuKhac, _longnguc, _vitrimomtim, _tiengtim, _tiengthoitim, _tiengthoimach, _tiengthoikhac, _machtuchi, _hohap, _bung, _thanhkinh, _coquankhac, _chanDoanBD, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _machuyenkhoa, _maPhieuHen, _ngayHen, _maMay, _nguoiSD , _huy, _mABV, _ngayVV, _makhoaVV, _makhoaChoVV,_tenbenhbd,_nYHA   );
				// public abstract void UpdateKhamBenh_TM(String _maSoKham, Int32 _sTT, String _maDV, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _da, Boolean _phu, Boolean _ngonTay, Boolean _hach, Boolean _khotho, Boolean _ho, Boolean _daunguc, Boolean _tim, Boolean _ngoiXom, Boolean _ngat, Boolean _hoihop, String _dauhieuKhac, String _longnguc, String _vitrimomtim, String _tiengtim, String _tiengthoitim, String _tiengthoimach, String _tiengthoikhac, String _maochtuchi, String _hohap, String _bung, String _thanhkinh, String _coquankhac, String _chanDoanBD, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maPhieuHen, SmartDate _ngayHen, String _maMay, Boolean _huy, String _nguoiSD, String _mABV, SmartDate _ngayVV, String _makhoaVV);
				// public override void UpdateKhamBenh_TM(String _maSoKham, Int32 _sTT, String _maDV, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _da, Boolean _phu, Boolean _ngonTay, Boolean _hach, Boolean _khotho, Boolean _ho, Boolean _daunguc, Boolean _tim, Boolean _ngoiXom, Boolean _ngat, Boolean _hoihop, String _dauhieuKhac, String _longnguc, String _vitrimomtim, String _tiengtim, String _tiengthoitim, String _tiengthoimach, String _tiengthoikhac, String _machtuchi, String _hohap, String _bung, String _thanhkinh, String _coquankhac, String _chanDoanBD, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maPhieuHen, SmartDate _ngayHen, String _maMay, Boolean _huy, String _nguoiSD, String _mABV, SmartDate _ngayVV, String _makhoaVV)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_TM_UPDATE", _maSoKham, _sTT, _maDV, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _da, _phu, _ngonTay, _hach, _khotho, _ho, _daunguc, _tim, _ngoiXom, _ngat, _hoihop, _dauhieuKhac, _longnguc, _vitrimomtim, _tiengtim, _tiengthoitim, _tiengthoimach, _tiengthoikhac, _machtuchi, _hohap, _bung, _thanhkinh, _coquankhac, _chanDoanBD, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _machuyenkhoa, _maPhieuHen, _ngayHen.DBValue, _maMay, _huy, _nguoiSD , _mABV, _ngayVV.DBValue, _makhoaVV);
				// }	
                MarkOld();
			}
		}
		

		/// <summary>
		/// Delete the <see cref="KhamBenh_TM" />.
		/// </summary>
		

        internal void DeleteSelf(KhamBenh_C obj)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;
              
            DataProvider.Instance().DeleteKhamBenh_TM(_maMay, _nguoiSD , obj.MaSoKham, _sTT);
            MarkNew();
        }

		#endregion
	}

}
