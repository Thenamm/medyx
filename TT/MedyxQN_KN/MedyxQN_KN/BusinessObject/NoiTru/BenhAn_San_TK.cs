// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_San_TK
// Kieu doi tuong  :	BenhAn_San_TK
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	04/03/2010 11:17:12 AM
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
	/// This is a base generated class of <see cref="BenhAn_San_TK" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_San_TK : BusinessBase<BenhAn_San_TK>
	{
		#region Business Methods
		
		#region State Fields
        private Int32 _sTT = 0;
		private String _maBA = String.Empty;
		private SmartDate _ngayKham = new SmartDate(true);
		private String _bSKham = String.Empty;
		private String _lyDoKham = String.Empty;
		private String _nhipTim = String.Empty;
		private String _xuongKhop = String.Empty;
		private String _apHuyet = String.Empty;
		private String _nhietDo = String.Empty;
		private String _nhipTho = String.Empty;
		private String _canNang = String.Empty;
		private String _chieuCao = String.Empty;
		private Boolean _gt = false;
        private Boolean _gtNu = false;
		private String _luongDinh = String.Empty;
		private String _toanTrang = String.Empty;
		private Boolean _hutDich = false;
        private Boolean _hutDichK = false;
		private Boolean _xoaBop = false;
        private Boolean _xoaBopK = false;
		private Boolean _tho = false;
        private Boolean _thoK = false;
		private Boolean _khac = false;
        private Boolean _khacK = false;
		private Boolean _datNoiKhiQuan = false;
        private Boolean _datNoiKhiQuanK = false;
		private Boolean _bopBong = false;
        private Boolean _bopBongK = false;
		private Boolean _diTathaumon = false;
        private Boolean _diTathaumonK = false;
		private Boolean _diTatKhac = false;
		private String _cuThe = String.Empty;
		private SmartDate _rauSo = new SmartDate(true);
		private Byte _kieuSo = 0;
        private Boolean _kieuSoMatmang = false;
        private Boolean _kieuSoMatmui = false;
        private Boolean _kieuSoRaubongnon = false;
		private String _thoiGianSoRau = String.Empty;
		private Boolean _rauConCo = false;
        private Boolean _rauConCoK = false;
		private String _chieuDaiRau = String.Empty;
		private Boolean _kiemSoatTuCung = false;
        private Boolean _kiemSoatTuCungK = false;
		private String _lyDoKiemSoat = String.Empty;
		private Boolean _bocRau = false;
        private Boolean _bocRauK = false;
		private String _lyDoBocRau = String.Empty;
		private Boolean _chayMau = false;
        private Boolean _chayMauK = false;
		private String _soLuong = String.Empty;
		private String _meMach = String.Empty;
		private String _meDa = String.Empty;
		private String _meNiemMac = String.Empty;
		private String _meApHuyet = String.Empty;
		private String _meNhietDo = String.Empty;
		private String _meNhipTho = String.Empty;
		private String _meCanNang = String.Empty;
		private String _meChieuCao = String.Empty;
		private Boolean _mePhu = false;
		private String _meToanThan = String.Empty;
		private String _meToanTrang = String.Empty;
		private String _meCao = String.Empty;
		private String _meTim = String.Empty;
		private String _meGan = String.Empty;
		private String _mePhoi = String.Empty;
		private String _meThan = String.Empty;
		private String _meNuocOi = String.Empty;
		private Byte _meKieuOiVo = 0;
		private String _meTieng = String.Empty;
        private String _meCachDe = "00000";
        private Boolean _meCachDeThuong = false;
        private Boolean _meCachDeFoocxep = false;
        private Boolean _meCachDeGiachut = false;
        private Boolean _meCachDeMo = false;
        private Boolean _meCachDeChihuy = false;
		private SmartDate _meGioDe = new SmartDate(true);
		private String _meLyDoCachDe = String.Empty;
		private String _meNguoiDoDe = String.Empty;
		private String _meNguoiMo = String.Empty;
		private Byte _meTSM = 0;
        private Boolean _meTSMR = false;
        private Boolean _meTSMC = false;
        private Boolean _meTSMT = false;
		private String _meLyDoTSM = String.Empty;
		private Byte _meAmDao = 0;
        private Boolean _meAmDaoR = false;
        private Boolean _meAmDaoC = false;
        private Boolean _meAmDaoT = false;
		private String _meLyDoAmDao = String.Empty;
		private Byte _meCoTuCung = 0;
        private Boolean _meCoTuCungR = false;
        private Boolean _meCoTuCungC = false;
        private Boolean _meCoTuCungT = false;
		private String _meLyDoCoTuCung = String.Empty;
		private String _meCanThiepKhac = String.Empty;
		private String _meLyDo = String.Empty;
		private String _meThoiGianChuyenDa = String.Empty;
		private String _meThoiGianTheoDoi = String.Empty;
		private String _dieuTri = String.Empty;
		private String _chanDoan = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
        private String _tenBSKham = String.Empty;
        private String _tennguoiSD = String.Empty;
        private String _rauCanNang = String.Empty;
        private int _OrderNumber;
		#endregion
		
		#region Business Properties and Methods
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
		
		public string NgayKham
		{
			get 
			{
				CanReadProperty("NgayKham", true);
				return _ngayKham.Text;
			}
			set 
			{
				CanWriteProperty("NgayKham", true);
				if (_ngayKham.Text != value) 
				{
					_ngayKham.Text = value;
					PropertyHasChanged("NgayKham");
				}
			}
		}
		
		public String BSKham
		{
			get 
			{
				CanReadProperty("BSKham", true);
				return _bSKham;
			}
			set 
			{
				CanWriteProperty("BSKham", true);
				if (_bSKham != value) 
				{
					_bSKham = value;
					PropertyHasChanged("BSKham");
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
		
		public String NhipTim
		{
			get 
			{
				CanReadProperty("NhipTim", true);
				return _nhipTim;
			}
			set 
			{
				CanWriteProperty("NhipTim", true);
				if (_nhipTim != value) 
				{
					_nhipTim = value;
					PropertyHasChanged("NhipTim");
				}
			}
		}
		
		public String XuongKhop
		{
			get 
			{
				CanReadProperty("XuongKhop", true);
				return _xuongKhop;
			}
			set 
			{
				CanWriteProperty("XuongKhop", true);
				if (_xuongKhop != value) 
				{
					_xuongKhop = value;
					PropertyHasChanged("XuongKhop");
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
            set
            {
                CanWriteProperty("GTNu", true);
                if (_gtNu != value)
                {
                    if (value == true)
                        _gt = false;
                    else
                        _gt = true;
                    _gtNu = value;

                    PropertyHasChanged("GTNu");
                }

            }
        }

		public String LuongDinh
		{
			get 
			{
				CanReadProperty("LuongDinh", true);
				return _luongDinh;
			}
			set 
			{
				CanWriteProperty("LuongDinh", true);
				if (_luongDinh != value) 
				{
					_luongDinh = value;
					PropertyHasChanged("LuongDinh");
				}
			}
		}
		
		public String ToanTrang
		{
			get 
			{
				CanReadProperty("ToanTrang", true);
				return _toanTrang;
			}
			set 
			{
				CanWriteProperty("ToanTrang", true);
				if (_toanTrang != value) 
				{
					_toanTrang = value;
					PropertyHasChanged("ToanTrang");
				}
			}
		}
		
		public Boolean HutDich
		{
			get 
			{
				CanReadProperty("HutDich", true);
				return _hutDich;
			}
			set 
			{
				CanWriteProperty("HutDich", true);
				if (_hutDich != value) 
				{
					_hutDich = value;
					PropertyHasChanged("HutDich");
				}
			}
		}
        public Boolean HutDichK
        {
            get
            {
                CanReadProperty("HutDichK", true);
                if (_hutDich == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("HutDichK", true);
                if (_hutDichK != value)
                {
                    if (value == true)
                        _hutDich = false;
                    else
                        _hutDich = true;
                    _hutDichK = value;

                    PropertyHasChanged("HutDichK");
                }

            }
        }
		public Boolean XoaBop
		{
			get 
			{
				CanReadProperty("XoaBop", true);
				return _xoaBop;
			}
			set 
			{
				CanWriteProperty("XoaBop", true);
				if (_xoaBop != value) 
				{
					_xoaBop = value;
					PropertyHasChanged("XoaBop");
				}
			}
		}
        public Boolean XoaBopK
        {
            get
            {
                CanReadProperty("XoaBopK", true);
                if (_xoaBop == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("XoaBopK", true);
                if (_xoaBopK != value)
                {
                    if (value == true)
                        _xoaBop = false;
                    else
                        _xoaBop = true;
                    _xoaBopK = value;

                    PropertyHasChanged("XoaBopK");
                }

            }
        }
		public Boolean Tho
		{
			get 
			{
				CanReadProperty("Tho", true);
				return _tho;
			}
			set 
			{
				CanWriteProperty("Tho", true);
				if (_tho != value) 
				{
					_tho = value;
					PropertyHasChanged("Tho");
				}
			}
		}
        public Boolean ThoK
        {
            get
            {
                CanReadProperty("ThoK", true);
                if (_tho == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("ThoK", true);
                if (_thoK != value)
                {
                    if (value == true)
                        _tho = false;
                    else
                        _tho = true;
                    _thoK = value;

                    PropertyHasChanged("ThoK");
                }

            }
        }
		public Boolean Khac
		{
			get 
			{
                CanReadProperty("Khac", true);
				return _khac;
			}
			set 
			{
                CanWriteProperty("Khac", true);
				if (_khac != value) 
				{
					_khac = value;
                    PropertyHasChanged("Khac");
				}
			}
		}
        public Boolean KhacK
        {
            get
            {
                CanReadProperty("KhacK", true);
                if (_khac == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("KhacK", true);
                if (_khacK != value)
                {
                    if (value == true)
                        _khac = false;
                    else
                        _khac = true;
                    _khacK = value;

                    PropertyHasChanged("KhacK");
                }

            }
        }
		public Boolean DatNoiKhiQuan
		{
			get 
			{
				CanReadProperty("DatNoiKhiQuan", true);
				return _datNoiKhiQuan;
			}
			set 
			{
				CanWriteProperty("DatNoiKhiQuan", true);
				if (_datNoiKhiQuan != value) 
				{
					_datNoiKhiQuan = value;
					PropertyHasChanged("DatNoiKhiQuan");
				}
			}
		}
        public Boolean DatNoiKhiQuanK
        {
            get
            {
                CanReadProperty("DatNoiKhiQuanK", true);
                if (_datNoiKhiQuan == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("DatNoiKhiQuanK", true);
                if (_datNoiKhiQuanK != value)
                {
                    if (value == true)
                        _datNoiKhiQuan = false;
                    else
                        _datNoiKhiQuan = true;
                    _datNoiKhiQuanK = value;

                    PropertyHasChanged("DatNoiKhiQuanK");
                }

            }
        }
		public Boolean BopBong
		{
			get 
			{
				CanReadProperty("BopBong", true);
				return _bopBong;
			}
			set 
			{
				CanWriteProperty("BopBong", true);
				if (_bopBong != value) 
				{
					_bopBong = value;
					PropertyHasChanged("BopBong");
				}
			}
		}
        public Boolean BopBongK
        {
            get
            {
                CanReadProperty("BopBongK", true);
                if (_bopBong == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("BopBongK", true);
                if (_bopBongK != value)
                {
                    if (value == true)
                        _bopBong = false;
                    else
                        _bopBong = true;
                    _bopBongK = value;

                    PropertyHasChanged("BopBongK");
                }

            }
        }
		public Boolean DiTathaumon
		{
			get 
			{
				CanReadProperty("DiTathaumon", true);
				return _diTathaumon;
			}
			set 
			{
				CanWriteProperty("DiTathaumon", true);
				if (_diTathaumon != value) 
				{
					_diTathaumon = value;
					PropertyHasChanged("DiTathaumon");
				}
			}
		}

        public Boolean DiTathaumonK
        {
            get
            {
                CanReadProperty("DiTathaumonK", true);
                if (_diTathaumon == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("DiTathaumonK", true);
                if (_diTathaumonK != value)
                {
                    if (value == true)
                        _diTathaumon = false;
                    else
                        _diTathaumon = true;
                    _diTathaumonK = value;

                    PropertyHasChanged("DiTathaumonK");
                }

            }
        }

		public Boolean DiTatKhac
		{
			get 
			{
				CanReadProperty("DiTatKhac", true);
				return _diTatKhac;
			}
			set 
			{
				CanWriteProperty("DiTatKhac", true);
				if (_diTatKhac != value) 
				{
					_diTatKhac = value;
					PropertyHasChanged("DiTatKhac");
				}
			}
		}
		
		public String CuThe
		{
			get 
			{
				CanReadProperty("CuThe", true);
				return _cuThe;
			}
			set 
			{
				CanWriteProperty("CuThe", true);
				if (_cuThe != value) 
				{
					_cuThe = value;
					PropertyHasChanged("CuThe");
				}
			}
		}
		
		public string RauSo
		{
			get 
			{
				CanReadProperty("RauSo", true);
                _rauSo.FormatString = "dd/MM/yyyy HH:mm";
				return _rauSo.Text;
			}
			set 
			{
				CanWriteProperty("RauSo", true);
				if (_rauSo.Text != value) 
				{
					_rauSo.Text = value;
					PropertyHasChanged("RauSo");
				}
			}
		}
		
		public Byte KieuSo
		{
			get 
			{
				CanReadProperty("KieuSo", true);
				return _kieuSo;
			}
			set 
			{
				CanWriteProperty("KieuSo", true);
				if (_kieuSo != value) 
				{
					_kieuSo = value;
					PropertyHasChanged("KieuSo");
				}
			}
		}
        public Boolean KieuSoMatmang
        {
            get
            {
                CanReadProperty("KieuSoMatmang", true);

                if (_kieuSo == 0)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("KieuSoMatmang", true);

                if (_kieuSoMatmang != value)
                {

                    _kieuSoMatmang = value;

                }
                if (_kieuSoMatmang == true)
                    _kieuSo = 0;
                PropertyHasChanged("KieuSoMatmang");

            }
        }

        public Boolean KieuSoMatmui
        {
            get
            {
                CanReadProperty("KieuSoMatmui", true);

                if (_kieuSo == 1)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("KieuSoMatmui", true);

                if (_kieuSoMatmui != value)
                {

                    _kieuSoMatmui = value;

                }
                if (_kieuSoMatmui == true)
                    _kieuSo = 1;
                PropertyHasChanged("KieuSoMatmui");

            }
        }

        public Boolean KieuSoRaubongnon
        {
            get
            {
                CanReadProperty("KieuSoRaubongnon", true);

                if (_kieuSo == 2)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("KieuSoRaubongnon", true);

                if (_kieuSoRaubongnon != value)
                {

                    _kieuSoRaubongnon = value;

                }
                if (_kieuSoRaubongnon == true)
                    _kieuSo = 2;
                PropertyHasChanged("KieuSoRaubongnon");

            }
        }

		public String ThoiGianSoRau
		{
			get 
			{
				CanReadProperty("ThoiGianSoRau", true);
				return _thoiGianSoRau;
			}
			set 
			{
				CanWriteProperty("ThoiGianSoRau", true);
				if (_thoiGianSoRau != value) 
				{
					_thoiGianSoRau = value;
					PropertyHasChanged("ThoiGianSoRau");
				}
			}
		}
		
		public Boolean RauConCo
		{
			get 
			{
				CanReadProperty("RauConCo", true);
				return _rauConCo;
			}
			set 
			{
				CanWriteProperty("RauConCo", true);
				if (_rauConCo != value) 
				{
					_rauConCo = value;
					PropertyHasChanged("RauConCo");
				}
			}
		}
        public Boolean RauConCoK
        {
            get
            {
                CanReadProperty("RauConCoK", true);
                if (_rauConCo == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("RauConCoK", true);
                if (_rauConCoK != value)
                {
                    if (value == true)
                        _rauConCo = false;
                    else
                        _rauConCo = true;
                    _rauConCoK = value;

                    PropertyHasChanged("RauConCoK");
                }

            }
        }
		public String ChieuDaiRau
		{
			get 
			{
				CanReadProperty("ChieuDaiRau", true);
				return _chieuDaiRau;
			}
			set 
			{
				CanWriteProperty("ChieuDaiRau", true);
				if (_chieuDaiRau != value) 
				{
					_chieuDaiRau = value;
					PropertyHasChanged("ChieuDaiRau");
				}
			}
		}
		
		public Boolean KiemSoatTuCung
		{
			get 
			{
				CanReadProperty("KiemSoatTuCung", true);
				return _kiemSoatTuCung;
			}
			set 
			{
				CanWriteProperty("KiemSoatTuCung", true);
				if (_kiemSoatTuCung != value) 
				{
					_kiemSoatTuCung = value;
					PropertyHasChanged("KiemSoatTuCung");
				}
			}
		}
        public Boolean KiemSoatTuCungK
        {
            get
            {
                CanReadProperty("KiemSoatTuCungK", true);
                if (_kiemSoatTuCung == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("KiemSoatTuCungK", true);
                if (_kiemSoatTuCungK != value)
                {
                    if (value == true)
                        _kiemSoatTuCung = false;
                    else
                        _kiemSoatTuCung = true;
                    _kiemSoatTuCungK = value;

                    PropertyHasChanged("KiemSoatTuCungK");
                }

            }
        }
		public String LyDoKiemSoat
		{
			get 
			{
				CanReadProperty("LyDoKiemSoat", true);
				return _lyDoKiemSoat;
			}
			set 
			{
				CanWriteProperty("LyDoKiemSoat", true);
				if (_lyDoKiemSoat != value) 
				{
					_lyDoKiemSoat = value;
					PropertyHasChanged("LyDoKiemSoat");
				}
			}
		}
		
		public Boolean BocRau
		{
			get 
			{
				CanReadProperty("BocRau", true);
				return _bocRau;
			}
			set 
			{
				CanWriteProperty("BocRau", true);
				if (_bocRau != value) 
				{
					_bocRau = value;
					PropertyHasChanged("BocRau");
				}
			}
		}
        public Boolean BocRauK
        {
            get
            {
                CanReadProperty("BocRauK", true);
                if (_bocRau == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("BocRauK", true);
                if (_bocRauK != value)
                {
                    if (value == true)
                        _bocRau = false;
                    else
                        _bocRau = true;
                    _bocRauK = value;

                    PropertyHasChanged("BocRauK");
                }

            }
        }
		public String LyDoBocRau
		{
			get 
			{
				CanReadProperty("LyDoBocRau", true);
				return _lyDoBocRau;
			}
			set 
			{
				CanWriteProperty("LyDoBocRau", true);
				if (_lyDoBocRau != value) 
				{
					_lyDoBocRau = value;
					PropertyHasChanged("LyDoBocRau");
				}
			}
		}
		
		public Boolean ChayMau
		{
			get 
			{
				CanReadProperty("ChayMau", true);
				return _chayMau;
			}
			set 
			{
				CanWriteProperty("ChayMau", true);
				if (_chayMau != value) 
				{
					_chayMau = value;
					PropertyHasChanged("ChayMau");
				}
			}
		}
        public Boolean ChayMauK
        {
            get
            {
                CanReadProperty("ChayMauK", true);
                if (_chayMau == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("ChayMauK", true);
                if (_chayMauK != value)
                {
                    if (value == true)
                        _chayMau = false;
                    else
                        _chayMau = true;
                    _chayMauK = value;

                    PropertyHasChanged("ChayMauK");
                }

            }
        }
		public String SoLuong
		{
			get 
			{
				CanReadProperty("SoLuong", true);
				return _soLuong;
			}
			set 
			{
				CanWriteProperty("SoLuong", true);
				if (_soLuong != value) 
				{
					_soLuong = value;
					PropertyHasChanged("SoLuong");
				}
			}
		}
		
		public String MeMach
		{
			get 
			{
				CanReadProperty("MeMach", true);
				return _meMach;
			}
			set 
			{
				CanWriteProperty("MeMach", true);
				if (_meMach != value) 
				{
					_meMach = value;
					PropertyHasChanged("MeMach");
				}
			}
		}
		
		public String MeDa
		{
			get 
			{
				CanReadProperty("MeDa", true);
				return _meDa;
			}
			set 
			{
				CanWriteProperty("MeDa", true);
				if (_meDa != value) 
				{
					_meDa = value;
					PropertyHasChanged("MeDa");
				}
			}
		}
		
		public String MeNiemMac
		{
			get 
			{
				CanReadProperty("MeNiemMac", true);
				return _meNiemMac;
			}
			set 
			{
				CanWriteProperty("MeNiemMac", true);
				if (_meNiemMac != value) 
				{
					_meNiemMac = value;
					PropertyHasChanged("MeNiemMac");
				}
			}
		}
		
		public String MeApHuyet
		{
			get 
			{
				CanReadProperty("MeApHuyet", true);
				return _meApHuyet;
			}
			set 
			{
				CanWriteProperty("MeApHuyet", true);
				if (_meApHuyet != value) 
				{
					_meApHuyet = value;
					PropertyHasChanged("MeApHuyet");
				}
			}
		}
		
		public String MeNhietDo
		{
			get 
			{
				CanReadProperty("MeNhietDo", true);
				return _meNhietDo;
			}
			set 
			{
				CanWriteProperty("MeNhietDo", true);
				if (_meNhietDo != value) 
				{
					_meNhietDo = value;
					PropertyHasChanged("MeNhietDo");
				}
			}
		}
		
		public String MeNhipTho
		{
			get 
			{
				CanReadProperty("MeNhipTho", true);
				return _meNhipTho;
			}
			set 
			{
				CanWriteProperty("MeNhipTho", true);
				if (_meNhipTho != value) 
				{
					_meNhipTho = value;
					PropertyHasChanged("MeNhipTho");
				}
			}
		}
		
		public String MeCanNang
		{
			get 
			{
				CanReadProperty("MeCanNang", true);
				return _meCanNang;
			}
			set 
			{
				CanWriteProperty("MeCanNang", true);
				if (_meCanNang != value) 
				{
					_meCanNang = value;
					PropertyHasChanged("MeCanNang");
				}
			}
		}
		
		public String MeChieuCao
		{
			get 
			{
				CanReadProperty("MeChieuCao", true);
				return _meChieuCao;
			}
			set 
			{
				CanWriteProperty("MeChieuCao", true);
				if (_meChieuCao != value) 
				{
					_meChieuCao = value;
					PropertyHasChanged("MeChieuCao");
				}
			}
		}
		
		public Boolean MePhu
		{
			get 
			{
				CanReadProperty("MePhu", true);
				return _mePhu;
			}
			set 
			{
				CanWriteProperty("MePhu", true);
				if (_mePhu != value) 
				{
					_mePhu = value;
					PropertyHasChanged("MePhu");
				}
			}
		}
		
		public String MeToanThan
		{
			get 
			{
				CanReadProperty("MeToanThan", true);
				return _meToanThan;
			}
			set 
			{
				CanWriteProperty("MeToanThan", true);
				if (_meToanThan != value) 
				{
					_meToanThan = value;
					PropertyHasChanged("MeToanThan");
				}
			}
		}
		
		public String MeToanTrang
		{
			get 
			{
				CanReadProperty("MeToanTrang", true);
				return _meToanTrang;
			}
			set 
			{
				CanWriteProperty("MeToanTrang", true);
				if (_meToanTrang != value) 
				{
					_meToanTrang = value;
					PropertyHasChanged("MeToanTrang");
				}
			}
		}
		
		public String MeCao
		{
			get 
			{
				CanReadProperty("MeCao", true);
				return _meCao;
			}
			set 
			{
				CanWriteProperty("MeCao", true);
				if (_meCao != value) 
				{
					_meCao = value;
					PropertyHasChanged("MeCao");
				}
			}
		}
		
		public String MeTim
		{
			get 
			{
				CanReadProperty("MeTim", true);
				return _meTim;
			}
			set 
			{
				CanWriteProperty("MeTim", true);
				if (_meTim != value) 
				{
					_meTim = value;
					PropertyHasChanged("MeTim");
				}
			}
		}
		
		public String MeGan
		{
			get 
			{
				CanReadProperty("MeGan", true);
				return _meGan;
			}
			set 
			{
				CanWriteProperty("MeGan", true);
				if (_meGan != value) 
				{
					_meGan = value;
					PropertyHasChanged("MeGan");
				}
			}
		}
		
		public String MePhoi
		{
			get 
			{
				CanReadProperty("MePhoi", true);
				return _mePhoi;
			}
			set 
			{
				CanWriteProperty("MePhoi", true);
				if (_mePhoi != value) 
				{
					_mePhoi = value;
					PropertyHasChanged("MePhoi");
				}
			}
		}
		
		public String MeThan
		{
			get 
			{
				CanReadProperty("MeThan", true);
				return _meThan;
			}
			set 
			{
				CanWriteProperty("MeThan", true);
				if (_meThan != value) 
				{
					_meThan = value;
					PropertyHasChanged("MeThan");
				}
			}
		}
		
		public String MeNuocOi
		{
			get 
			{
				CanReadProperty("MeNuocOi", true);
				return _meNuocOi;
			}
			set 
			{
				CanWriteProperty("MeNuocOi", true);
				if (_meNuocOi != value) 
				{
					_meNuocOi = value;
					PropertyHasChanged("MeNuocOi");
				}
			}
		}
		
		public Byte MeKieuOiVo
		{
			get 
			{
				CanReadProperty("MeKieuOiVo", true);
				return _meKieuOiVo;
			}
			set 
			{
				CanWriteProperty("MeKieuOiVo", true);
				if (_meKieuOiVo != value) 
				{
					_meKieuOiVo = value;
					PropertyHasChanged("MeKieuOiVo");
				}
			}
		}
		
		public String MeTieng
		{
			get 
			{
				CanReadProperty("MeTieng", true);
				return _meTieng;
			}
			set 
			{
				CanWriteProperty("MeTieng", true);
				if (_meTieng != value) 
				{
					_meTieng = value;
					PropertyHasChanged("MeTieng");
				}
			}
		}
		
		public string MeCachDe
		{
			get 
			{
				CanReadProperty("MeCachDe", true);
				return _meCachDe;
			}
			set 
			{
				CanWriteProperty("MeCachDe", true);
				if (_meCachDe != value) 
				{
					_meCachDe = value;
					PropertyHasChanged("MeCachDe");
				}
			}
		}
        public Boolean MeCachDeThuong
        {
            get
            {
                CanReadProperty("MeCachDeThuong", true);

                //if (_meCachDe.Substring(1,1) =="1" )
                //    return true;
                //else
                //    return false;
                return _meCachDeThuong;
            }
            set
            {
                CanWriteProperty("MeCachDeThuong", true);

                if (_meCachDeThuong != value)
                {

                    _meCachDeThuong = value;

                
                if (_meCachDeThuong == true)
                    _meCachDe = "1" + _meCachDe.Substring(1, 4);
                else
                    _meCachDe = "0" + _meCachDe.Substring(1, 4);
                PropertyHasChanged("MeCachDeThuong");
            }
            }
        }

        public Boolean MeCachDeFoocxep
        {
            get
            {
                CanReadProperty("MeCachDeFoocxep", true);
                return _meCachDeFoocxep;
                //if (_meCachDe.Substring(2, 1) == "1")
                //    return true;
                //else
                //    return false;

            }
            set
            {
                CanWriteProperty("MeCachDeFoocxep", true);

                if (_meCachDeFoocxep != value)
                {

                    _meCachDeFoocxep = value;

               
                if (_meCachDeFoocxep == true)
                    _meCachDe = _meCachDe.Substring(0, 1) + "1" + _meCachDe.Substring(2, 3);
                else
                    _meCachDe = _meCachDe.Substring(0, 1) + "0" + _meCachDe.Substring(2, 3);
                PropertyHasChanged("MeCachDeFoocxep");
            }
            }
        }

        public Boolean MeCachDeGiachut
        {
            get
            {
                CanReadProperty("MeCachDeGiachut", true);

                //if (_meCachDe.Substring(3, 1) == "1")
                //    return true;
                //else
                //    return false;
                return _meCachDeGiachut;
            }
            set
            {
                CanWriteProperty("MeCachDeGiachut", true);

                if (_meCachDeGiachut != value)
                {

                    _meCachDeGiachut = value;

               
                if (_meCachDeGiachut == true)
                    _meCachDe = _meCachDe.Substring(0, 2) + "1" + _meCachDe.Substring(3, 2);
                else
                    _meCachDe = _meCachDe.Substring(0, 2) + "0" + _meCachDe.Substring(3, 2);
                PropertyHasChanged("MeCachDeGiachut");
            }
            }
        }

        public Boolean MeCachDeMo
        {
            get
            {
                CanReadProperty("MeCachDeMo", true);

                //if (_meCachDe.Substring(4, 1) == "1")
                //    return true;
                //else
                //    return false;
                return _meCachDeMo;
            }
            set
            {
                CanWriteProperty("MeCachDeMo", true);

                if (_meCachDeMo != value)
                {

                    _meCachDeMo = value;

               
                if (_meCachDeMo == true)
                        _meCachDe = _meCachDe.Substring(0, 3) + "1" + _meCachDe.Substring(4, 1);
                    else
                        _meCachDe = _meCachDe.Substring(0, 3) + "0" + _meCachDe.Substring(4, 1);
              
                PropertyHasChanged("MeCachDeMo");
            }
            }
        }

        public Boolean MeCachDeChihuy
        {
            get
            {
                CanReadProperty("MeCachDeChihuy", true);

                //if (_meCachDe.Substring(5, 1) == "1")
                //    return true;
                //else
                //    return false;
                return _meCachDeChihuy;
            }
            set
            {
                CanWriteProperty("MeCachDeChihuy", true);

                if (_meCachDeChihuy != value)
                {

                    _meCachDeChihuy = value;

                
                if (_meCachDeChihuy == true)
                    _meCachDe = _meCachDe.Substring(0, 4) + "1" ;
                else
                    _meCachDe = _meCachDe.Substring(0, 4) + "0" ;
                PropertyHasChanged("MeCachDeChihuy");
                }
            }
        }

		public string MeGioDe
		{
			get 
			{
				CanReadProperty("MeGioDe", true);
                _meGioDe.FormatString = "dd/MM/yyyy HH:mm";
				return _meGioDe.Text;
			}
			set 
			{
				CanWriteProperty("MeGioDe", true);
				if (_meGioDe.Text != value) 
				{
					_meGioDe.Text = value;
					PropertyHasChanged("MeGioDe");
				}
			}
		}
		
		public String MeLyDoCachDe
		{
			get 
			{
				CanReadProperty("MeLyDoCachDe", true);
				return _meLyDoCachDe;
			}
			set 
			{
				CanWriteProperty("MeLyDoCachDe", true);
				if (_meLyDoCachDe != value) 
				{
					_meLyDoCachDe = value;
					PropertyHasChanged("MeLyDoCachDe");
				}
			}
		}
		
		public String MeNguoiDoDe
		{
			get 
			{
				CanReadProperty("MeNguoiDoDe", true);
				return _meNguoiDoDe;
			}
			set 
			{
				CanWriteProperty("MeNguoiDoDe", true);
				if (_meNguoiDoDe != value) 
				{
					_meNguoiDoDe = value;
					PropertyHasChanged("MeNguoiDoDe");
				}
			}
		}
		
		public String MeNguoiMo
		{
			get 
			{
				CanReadProperty("MeNguoiMo", true);
				return _meNguoiMo;
			}
			set 
			{
				CanWriteProperty("MeNguoiMo", true);
				if (_meNguoiMo != value) 
				{
					_meNguoiMo = value;
					PropertyHasChanged("MeNguoiMo");
				}
			}
		}
		
		public Byte MeTSM
		{
			get 
			{
				CanReadProperty("MeTSM", true);
				return _meTSM;
			}
			set 
			{
				CanWriteProperty("MeTSM", true);
				if (_meTSM != value) 
				{
					_meTSM = value;
					PropertyHasChanged("MeTSM");
				}
			}
		}
        public Boolean MeTSMR
        {
            get
            {
                CanReadProperty("MeTSMR", true);

                if (_meTSM == 0)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("MeTSMR", true);

                if (_meTSMR != value)
                {

                    _meTSMR = value;

                }
                if (_meTSMR == true)
                    _meTSM = 0;
                PropertyHasChanged("MeTSMR");

            }
        }

        public Boolean MeTSMC
        {
            get
            {
                CanReadProperty("MeTSMC", true);

                if (_meTSM == 1)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("MeTSMC", true);

                if (_meTSMC != value)
                {

                    _meTSMC = value;

                }
                if (_meTSMC == true)
                    _meTSM = 1;
                PropertyHasChanged("MeTSMC");

            }
        }

        public Boolean MeTSMT
        {
            get
            {
                CanReadProperty("MeTSMT", true);

                if (_meTSM == 2)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("MeTSMT", true);

                if (_meTSMT != value)
                {

                    _meTSMT = value;

                }
                if (_meTSMT == true)
                    _meTSM = 2;
                PropertyHasChanged("MeTSMT");

            }
        }

		public String MeLyDoTSM
		{
			get 
			{
				CanReadProperty("MeLyDoTSM", true);
				return _meLyDoTSM;
			}
			set 
			{
				CanWriteProperty("MeLyDoTSM", true);
				if (_meLyDoTSM != value) 
				{
					_meLyDoTSM = value;
					PropertyHasChanged("MeLyDoTSM");
				}
			}
		}
		
		public Byte MeAmDao
		{
			get 
			{
				CanReadProperty("MeAmDao", true);
				return _meAmDao;
			}
			set 
			{
				CanWriteProperty("MeAmDao", true);
				if (_meAmDao != value) 
				{
					_meAmDao = value;
					PropertyHasChanged("MeAmDao");
				}
			}
		}
        public Boolean MeAmDaoR
        {
            get
            {
                CanReadProperty("MeAmDaoR", true);

                if (_meAmDao == 0)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("MeAmDaoR", true);

                if (_meAmDaoR != value)
                {

                    _meAmDaoR = value;

                }
                if (_meAmDaoR == true)
                    _meAmDao = 0;
                PropertyHasChanged("MeAmDaoR");

            }
        }

        public Boolean MeAmDaoC
        {
            get
            {
                CanReadProperty("MeAmDaoC", true);

                if (_meAmDao == 1)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("MeAmDaoC", true);

                if (_meAmDaoC != value)
                {

                    _meAmDaoC = value;

                }
                if (_meAmDaoC == true)
                    _meAmDao = 1;
                PropertyHasChanged("MeAmDaoC");

            }
        }
        public Boolean MeAmDaoT
        {
            get
            {
                CanReadProperty("MeAmDaoT", true);

                if (_meAmDao == 2)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("MeAmDaoT", true);

                if (_meAmDaoT != value)
                {

                    _meAmDaoT = value;

                }
                if (_meAmDaoT == true)
                    _meAmDao = 2;
                PropertyHasChanged("MeAmDaoT");

            }
        }
		public String MeLyDoAmDao
		{
			get 
			{
				CanReadProperty("MeLyDoAmDao", true);
				return _meLyDoAmDao;
			}
			set 
			{
				CanWriteProperty("MeLyDoAmDao", true);
				if (_meLyDoAmDao != value) 
				{
					_meLyDoAmDao = value;
					PropertyHasChanged("MeLyDoAmDao");
				}
			}
		}
		
		public Byte MeCoTuCung
		{
			get 
			{
				CanReadProperty("MeCoTuCung", true);
				return _meCoTuCung;
			}
			set 
			{
				CanWriteProperty("MeCoTuCung", true);
				if (_meCoTuCung != value) 
				{
					_meCoTuCung = value;
					PropertyHasChanged("MeCoTuCung");
				}
			}
		}
        public Boolean MeCoTuCungR
        {
            get
            {
                CanReadProperty("MeCoTuCungR", true);

                if (_meCoTuCung == 0)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("MeCoTuCungR", true);

                if (_meCoTuCungR != value)
                {

                    _meCoTuCungR = value;

                }
                if (_meCoTuCungR == true)
                    _meCoTuCung = 0;
                PropertyHasChanged("MeCoTuCungR");

            }
        }

        public Boolean MeCoTuCungC
        {
            get
            {
                CanReadProperty("MeCoTuCungC", true);

                if (_meCoTuCung == 1)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("MeCoTuCungC", true);

                if (_meCoTuCungC != value)
                {

                    _meCoTuCungC = value;

                }
                if (_meCoTuCungC == true)
                    _meCoTuCung = 1;
                PropertyHasChanged("MeCoTuCungC");

            }
        }

        public Boolean MeCoTuCungT
        {
            get
            {
                CanReadProperty("MeCoTuCungT", true);

                if (_meCoTuCung == 2)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("MeCoTuCungT", true);

                if (_meCoTuCungT != value)
                {

                    _meCoTuCungT = value;

                }
                if (_meCoTuCungT == true)
                    _meCoTuCung = 2;
                PropertyHasChanged("MeCoTuCungT");

            }
        }
		public String MeLyDoCoTuCung
		{
			get 
			{
				CanReadProperty("MeLyDoCoTuCung", true);
				return _meLyDoCoTuCung;
			}
			set 
			{
				CanWriteProperty("MeLyDoCoTuCung", true);
				if (_meLyDoCoTuCung != value) 
				{
					_meLyDoCoTuCung = value;
					PropertyHasChanged("MeLyDoCoTuCung");
				}
			}
		}
		
		public String MeCanThiepKhac
		{
			get 
			{
				CanReadProperty("MeCanThiepKhac", true);
				return _meCanThiepKhac;
			}
			set 
			{
				CanWriteProperty("MeCanThiepKhac", true);
				if (_meCanThiepKhac != value) 
				{
					_meCanThiepKhac = value;
					PropertyHasChanged("MeCanThiepKhac");
				}
			}
		}
		
		public String MeLyDo
		{
			get 
			{
				CanReadProperty("MeLyDo", true);
				return _meLyDo;
			}
			set 
			{
				CanWriteProperty("MeLyDo", true);
				if (_meLyDo != value) 
				{
					_meLyDo = value;
					PropertyHasChanged("MeLyDo");
				}
			}
		}
		
		public String MeThoiGianChuyenDa
		{
			get 
			{
				CanReadProperty("MeThoiGianChuyenDa", true);
				return _meThoiGianChuyenDa;
			}
			set 
			{
				CanWriteProperty("MeThoiGianChuyenDa", true);
				if (_meThoiGianChuyenDa != value) 
				{
					_meThoiGianChuyenDa = value;
					PropertyHasChanged("MeThoiGianChuyenDa");
				}
			}
		}
		
		public String MeThoiGianTheoDoi
		{
			get 
			{
				CanReadProperty("MeThoiGianTheoDoi", true);
				return _meThoiGianTheoDoi;
			}
			set 
			{
				CanWriteProperty("MeThoiGianTheoDoi", true);
				if (_meThoiGianTheoDoi != value) 
				{
					_meThoiGianTheoDoi = value;
					PropertyHasChanged("MeThoiGianTheoDoi");
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
		
		public String ChanDoan
		{
			get 
			{
				CanReadProperty("ChanDoan", true);
				return _chanDoan;
			}
			set 
			{
				CanWriteProperty("ChanDoan", true);
				if (_chanDoan != value) 
				{
					_chanDoan = value;
					PropertyHasChanged("ChanDoan");
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

        public String TenBSKham
        {
            get
            {
                CanReadProperty("TenBSKham", true);
                return _tenBSKham;
            }
            set
            {
                CanWriteProperty("TenBSKham", true);
                if (_tenBSKham != value)
                {
                    _tenBSKham = value;
                    PropertyHasChanged("TenBSKham");
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

        public String RauCanNang
        {
            get
            {
                CanReadProperty("RauCanNang", true);
                return _rauCanNang;
            }
            set
            {
                CanWriteProperty("RauCanNang", true);
                if (_rauCanNang != value)
                {
                    _rauCanNang = value;
                    PropertyHasChanged("RauCanNang");
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
            return _maBA + "!" + _sTT.ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhAn_San_TK" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BenhAn_San_TK NewBenhAn_San_TK()
        {
            return DataPortal.Create<BenhAn_San_TK>();
        }
       
        internal static BenhAn_San_TK GetBenhAn_San_TK(SafeDataReader dr, int i)
        {
            return new BenhAn_San_TK(dr, i);
        }
		/// <summary>
		/// Marks the <see cref="BenhAn_San_TK" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBenhAn_San_TK(String maBA, string mamay, string nguoihuy,int stt)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maBA,stt));
		}
        public static BenhAn_San_TK GetBenhAn_San_TK(String maBA,int stt)
        {
            return DataPortal.Fetch<BenhAn_San_TK>(new CriteriaOther(maBA,stt));
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BenhAn_San_TK()
		{	
			// Prevent direct creation
            _meCachDe = "00000";
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

            private Int32 _sTT;
            public Int32 STT
            {
                get
                {
                    return _sTT;
                }
            }

            public Criteria(String maBA, Int32 sTT)
            {
                _maBA = maBA;
                _sTT = sTT;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maBA.Equals(c._maBA))
                        return false;
                    if (!_sTT.Equals(c._sTT))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maBA.ToString(), _sTT.ToString()).GetHashCode();
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

            private Int32 _sTT;
            public Int32 STT
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
            private String _lydohuy;
            public String lydohuy
            {
                get
                {
                    return _lydohuy;
                }
            }
            public OtherCriteria(String Mamay, String Nguoisd, String maBA,int stt)
            {
                _maBA = maBA;
            
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _sTT = stt;
            }
        }
        protected class CriteriaOther
        {
            private String _maBA;
            public String MaBA
            {
                get
                {
                    return _maBA;
                }
            }

            private int _stt;
            public int stt
            {
                get
                {
                    return _stt;
                }
            }



          
            public CriteriaOther( String maBA,int stt)
            {
                _maBA = maBA;
                _stt = stt;
               
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
		/// Retrieve an existing <see cref="BenhAn_San_TK" /> Object based on data in the database.
		/// </summary>
        protected void DataPortal_Fetch(CriteriaOther crit)
        {
             //public abstract IDataReader GetBenhAn_San_TK(String _maBA);
             //public override IDataReader GetBenhAn_San_TK(String _maBA)
             //{
             //      return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_San_TK_GET", _maBA));
             //}
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_San_TK(crit.MaBA, crit.stt)))
            {
                if (dr.Read()){
                    	Fetch(dr);
                    MarkOld();
                    ValidationRules.CheckRules();
                }
            }
        }
		/// <summary>
		/// Load a <see cref="BenhAn_San_TK" /> Object from given SafeDataReader.
		/// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
           
            if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");

            if (dr.GetSmartDate("NgayKham", true) != null) _ngayKham = dr.GetSmartDate("NgayKham", true);
            if (dr.GetString("BSKham") != null) _bSKham = dr.GetString("BSKham");
            if (dr.GetString("LyDoKham") != null) _lyDoKham = dr.GetString("LyDoKham");
            if (dr.GetString("NhipTim") != null) _nhipTim = dr.GetString("NhipTim");
            if (dr.GetString("XuongKhop") != null) _xuongKhop = dr.GetString("XuongKhop");
            if (dr.GetString("ApHuyet") != null) _apHuyet = dr.GetString("ApHuyet");
            if (dr.GetString("NhietDo") != null) _nhietDo = dr.GetString("NhietDo");
            if (dr.GetString("NhipTho") != null) _nhipTho = dr.GetString("NhipTho");
            if (dr.GetString("CanNang") != null) _canNang = dr.GetString("CanNang");
            if (dr.GetString("ChieuCao") != null) _chieuCao = dr.GetString("ChieuCao");
            if (dr.GetBoolean("GT") != null) _gt = dr.GetBoolean("GT");
            if (dr.GetString("LuongDinh") != null) _luongDinh = dr.GetString("LuongDinh");
            if (dr.GetString("ToanTrang") != null) _toanTrang = dr.GetString("ToanTrang");
            if (dr.GetBoolean("HutDich") != null) _hutDich = dr.GetBoolean("HutDich");
            if (dr.GetBoolean("XoaBop") != null) _xoaBop = dr.GetBoolean("XoaBop");
            if (dr.GetBoolean("Tho") != null) _tho = dr.GetBoolean("Tho");
            if (dr.GetBoolean("Khac") != null) _khac = dr.GetBoolean("Khac");
            if (dr.GetBoolean("DatNoiKhiQuan") != null) _datNoiKhiQuan = dr.GetBoolean("DatNoiKhiQuan");
            if (dr.GetBoolean("BopBong") != null) _bopBong = dr.GetBoolean("BopBong");
            if (dr.GetBoolean("DiTathaumon") != null) _diTathaumon = dr.GetBoolean("DiTathaumon");
            if (dr.GetBoolean("DiTatKhac") != null) _diTatKhac = dr.GetBoolean("DiTatKhac");
            if (dr.GetString("CuThe") != null) _cuThe = dr.GetString("CuThe");
            if (dr.GetSmartDate("RauSo", true) != null) _rauSo = dr.GetSmartDate("RauSo", true);
            if (dr.GetByte("KieuSo") != null) _kieuSo = dr.GetByte("KieuSo");
            if (dr.GetString("ThoiGianSoRau") != null) _thoiGianSoRau = dr.GetString("ThoiGianSoRau");
            if (dr.GetBoolean("RauConCo") != null) _rauConCo = dr.GetBoolean("RauConCo");
            if (dr.GetString("ChieuDaiRau") != null) _chieuDaiRau = dr.GetString("ChieuDaiRau");
            if (dr.GetBoolean("KiemSoatTuCung") != null) _kiemSoatTuCung = dr.GetBoolean("KiemSoatTuCung");
            if (dr.GetString("LyDoKiemSoat") != null) _lyDoKiemSoat = dr.GetString("LyDoKiemSoat");
            if (dr.GetBoolean("BocRau") != null) _bocRau = dr.GetBoolean("BocRau");
            if (dr.GetString("LyDoBocRau") != null) _lyDoBocRau = dr.GetString("LyDoBocRau");
            if (dr.GetBoolean("ChayMau") != null) _chayMau = dr.GetBoolean("ChayMau");
            if (dr.GetString("SoLuong") != null) _soLuong = dr.GetString("SoLuong");
            if (dr.GetString("MeMach") != null) _meMach = dr.GetString("MeMach");
            if (dr.GetString("MeDa") != null) _meDa = dr.GetString("MeDa");
            if (dr.GetString("MeNiemMac") != null) _meNiemMac = dr.GetString("MeNiemMac");
            if (dr.GetString("MeApHuyet") != null) _meApHuyet = dr.GetString("MeApHuyet");
            if (dr.GetString("MeNhietDo") != null) _meNhietDo = dr.GetString("MeNhietDo");
            if (dr.GetString("MeNhipTho") != null) _meNhipTho = dr.GetString("MeNhipTho");
            if (dr.GetString("MeCanNang") != null) _meCanNang = dr.GetString("MeCanNang");
            if (dr.GetString("MeChieuCao") != null) _meChieuCao = dr.GetString("MeChieuCao");
            if (dr.GetBoolean("MePhu") != null) _mePhu = dr.GetBoolean("MePhu");
            if (dr.GetString("MeToanThan") != null) _meToanThan = dr.GetString("MeToanThan");
            if (dr.GetString("MeToanTrang") != null) _meToanTrang = dr.GetString("MeToanTrang");
            if (dr.GetString("MeCao") != null) _meCao = dr.GetString("MeCao");
            if (dr.GetString("MeTim") != null) _meTim = dr.GetString("MeTim");
            if (dr.GetString("MeGan") != null) _meGan = dr.GetString("MeGan");
            if (dr.GetString("MePhoi") != null) _mePhoi = dr.GetString("MePhoi");
            if (dr.GetString("MeThan") != null) _meThan = dr.GetString("MeThan");
            if (dr.GetString("MeNuocOi") != null) _meNuocOi = dr.GetString("MeNuocOi");
            if (dr.GetByte("MeKieuOiVo") != null) _meKieuOiVo = dr.GetByte("MeKieuOiVo");
            if (dr.GetString("MeTieng") != null) _meTieng = dr.GetString("MeTieng");
            if (dr.GetString("MeCachDe") != null) _meCachDe = dr.GetString("MeCachDe");
            if ((_meCachDe != "") || (_meCachDe.Length == 5))
                if (_meCachDe.Substring(0, 1) == "1")
                    _meCachDeThuong = true;
                else if (_meCachDe.Substring(1, 1) == "1")
                    _meCachDeFoocxep = true;
                else if (_meCachDe.Substring(2, 1) == "1")
                    _meCachDeGiachut = true;
                else if (_meCachDe.Substring(3, 1) == "1")
                    _meCachDeMo = true;
                else if (_meCachDe.Substring(4, 1) == "1")
                    _meCachDeChihuy = true;
            if (dr.GetSmartDate("MeGioDe", true) != null) _meGioDe = dr.GetSmartDate("MeGioDe", true);
            if (dr.GetString("MeLyDoCachDe") != null) _meLyDoCachDe = dr.GetString("MeLyDoCachDe");
            if (dr.GetString("MeNguoiDoDe") != null) _meNguoiDoDe = dr.GetString("MeNguoiDoDe");
            if (dr.GetString("MeNguoiMo") != null) _meNguoiMo = dr.GetString("MeNguoiMo");
            if (dr.GetByte("MeTSM") != null) _meTSM = dr.GetByte("MeTSM");

            // exec dbo.spBenhAn_San_TK_GETAll @MaBA=N'14BA00025944',@dk=N'',@qadmin=1
            //if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            if (dr.GetString("MeLyDoTSM") != null) _meLyDoTSM = dr.GetString("MeLyDoTSM");
            if (dr.GetByte("MeAmDao") != null) _meAmDao = dr.GetByte("MeAmDao");
            if (dr.GetString("MeLyDoAmDao") != null) _meLyDoAmDao = dr.GetString("MeLyDoAmDao");
            if (dr.GetByte("MeCoTuCung") != null) _meCoTuCung = dr.GetByte("MeCoTuCung");
            if (dr.GetString("MeLyDoCoTuCung") != null) _meLyDoCoTuCung = dr.GetString("MeLyDoCoTuCung");
            if (dr.GetString("MeCanThiepKhac") != null) _meCanThiepKhac = dr.GetString("MeCanThiepKhac");
            if (dr.GetString("MeLyDo") != null) _meLyDo = dr.GetString("MeLyDo");
            if (dr.GetString("MeThoiGianChuyenDa") != null) _meThoiGianChuyenDa = dr.GetString("MeThoiGianChuyenDa");
            if (dr.GetString("MeThoiGianTheoDoi") != null) _meThoiGianTheoDoi = dr.GetString("MeThoiGianTheoDoi");
            if (dr.GetString("DieuTri") != null) _dieuTri = dr.GetString("DieuTri");
            if (dr.GetString("ChanDoan") != null) _chanDoan = dr.GetString("ChanDoan");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetString("TenBSKham") != null) _tenBSKham = dr.GetString("TenBSKham");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("RauCanNang") != null) _rauCanNang = dr.GetString("RauCanNang");

        }
         private BenhAn_San_TK(SafeDataReader dr,int i)
        {
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
         
            if (dr.GetSmartDate("NgayKham", true) != null) _ngayKham = dr.GetSmartDate("NgayKham", true);
            if (dr.GetString("BSKham") != null) _bSKham = dr.GetString("BSKham");
            if (dr.GetString("LyDoKham") != null) _lyDoKham = dr.GetString("LyDoKham");
            if (dr.GetString("NhipTim") != null) _nhipTim = dr.GetString("NhipTim");
            if (dr.GetString("XuongKhop") != null) _xuongKhop = dr.GetString("XuongKhop");
            if (dr.GetString("ApHuyet") != null) _apHuyet = dr.GetString("ApHuyet");
            if (dr.GetString("NhietDo") != null) _nhietDo = dr.GetString("NhietDo");
            if (dr.GetString("NhipTho") != null) _nhipTho = dr.GetString("NhipTho");
            if (dr.GetString("CanNang") != null) _canNang = dr.GetString("CanNang");
            if (dr.GetString("ChieuCao") != null) _chieuCao = dr.GetString("ChieuCao");
            if (dr.GetBoolean("GT") != null) _gt = dr.GetBoolean("GT");
            if (dr.GetString("LuongDinh") != null) _luongDinh = dr.GetString("LuongDinh");
            if (dr.GetString("ToanTrang") != null) _toanTrang = dr.GetString("ToanTrang");
            if (dr.GetBoolean("HutDich") != null) _hutDich = dr.GetBoolean("HutDich");
            if (dr.GetBoolean("XoaBop") != null) _xoaBop = dr.GetBoolean("XoaBop");
            if (dr.GetBoolean("Tho") != null) _tho = dr.GetBoolean("Tho");
            if (dr.GetBoolean("Khac") != null) _khac = dr.GetBoolean("Khac");
            if (dr.GetBoolean("DatNoiKhiQuan") != null) _datNoiKhiQuan = dr.GetBoolean("DatNoiKhiQuan");
            if (dr.GetBoolean("BopBong") != null) _bopBong = dr.GetBoolean("BopBong");
            if (dr.GetBoolean("DiTathaumon") != null) _diTathaumon = dr.GetBoolean("DiTathaumon");
            if (dr.GetBoolean("DiTatKhac") != null) _diTatKhac = dr.GetBoolean("DiTatKhac");
            if (dr.GetString("CuThe") != null) _cuThe = dr.GetString("CuThe");
            if (dr.GetSmartDate("RauSo", true) != null) _rauSo = dr.GetSmartDate("RauSo", true);
            if (dr.GetByte("KieuSo") != null) _kieuSo = dr.GetByte("KieuSo");
            if (dr.GetString("ThoiGianSoRau") != null) _thoiGianSoRau = dr.GetString("ThoiGianSoRau");
            if (dr.GetBoolean("RauConCo") != null) _rauConCo = dr.GetBoolean("RauConCo");
            if (dr.GetString("ChieuDaiRau") != null) _chieuDaiRau = dr.GetString("ChieuDaiRau");
            if (dr.GetBoolean("KiemSoatTuCung") != null) _kiemSoatTuCung = dr.GetBoolean("KiemSoatTuCung");
            if (dr.GetString("LyDoKiemSoat") != null) _lyDoKiemSoat = dr.GetString("LyDoKiemSoat");
            if (dr.GetBoolean("BocRau") != null) _bocRau = dr.GetBoolean("BocRau");
            if (dr.GetString("LyDoBocRau") != null) _lyDoBocRau = dr.GetString("LyDoBocRau");
            if (dr.GetBoolean("ChayMau") != null) _chayMau = dr.GetBoolean("ChayMau");
            if (dr.GetString("SoLuong") != null) _soLuong = dr.GetString("SoLuong");
            if (dr.GetString("MeMach") != null) _meMach = dr.GetString("MeMach");
            if (dr.GetString("MeDa") != null) _meDa = dr.GetString("MeDa");
            if (dr.GetString("MeNiemMac") != null) _meNiemMac = dr.GetString("MeNiemMac");
            if (dr.GetString("MeApHuyet") != null) _meApHuyet = dr.GetString("MeApHuyet");
            if (dr.GetString("MeNhietDo") != null) _meNhietDo = dr.GetString("MeNhietDo");
            if (dr.GetString("MeNhipTho") != null) _meNhipTho = dr.GetString("MeNhipTho");
            if (dr.GetString("MeCanNang") != null) _meCanNang = dr.GetString("MeCanNang");
            if (dr.GetString("MeChieuCao") != null) _meChieuCao = dr.GetString("MeChieuCao");
            if (dr.GetBoolean("MePhu") != null) _mePhu = dr.GetBoolean("MePhu");
            if (dr.GetString("MeToanThan") != null) _meToanThan = dr.GetString("MeToanThan");
            if (dr.GetString("MeToanTrang") != null) _meToanTrang = dr.GetString("MeToanTrang");
            if (dr.GetString("MeCao") != null) _meCao = dr.GetString("MeCao");
            if (dr.GetString("MeTim") != null) _meTim = dr.GetString("MeTim");
            if (dr.GetString("MeGan") != null) _meGan = dr.GetString("MeGan");
            if (dr.GetString("MePhoi") != null) _mePhoi = dr.GetString("MePhoi");
            if (dr.GetString("MeThan") != null) _meThan = dr.GetString("MeThan");
            if (dr.GetString("MeNuocOi") != null) _meNuocOi = dr.GetString("MeNuocOi");
            if (dr.GetByte("MeKieuOiVo") != null) _meKieuOiVo = dr.GetByte("MeKieuOiVo");
            if (dr.GetString("MeTieng") != null) _meTieng = dr.GetString("MeTieng");
            if ((_meCachDe != "") || (_meCachDe.Length == 5))
                if (_meCachDe.Substring(0, 1) == "1")
                    _meCachDeThuong = true;
                else if (_meCachDe.Substring(1, 1) == "1")
                    _meCachDeFoocxep = true;
                else if (_meCachDe.Substring(2, 1) == "1")
                    _meCachDeGiachut = true;
                else if (_meCachDe.Substring(3, 1) == "1")
                    _meCachDeMo = true;
                else if (_meCachDe.Substring(4, 1) == "1")
                    _meCachDeChihuy = true;
            if (dr.GetSmartDate("MeGioDe", true) != null) _meGioDe = dr.GetSmartDate("MeGioDe", true);
            if (dr.GetString("MeLyDoCachDe") != null) _meLyDoCachDe = dr.GetString("MeLyDoCachDe");
            if (dr.GetString("MeNguoiDoDe") != null) _meNguoiDoDe = dr.GetString("MeNguoiDoDe");
            if (dr.GetString("MeNguoiMo") != null) _meNguoiMo = dr.GetString("MeNguoiMo");
            if (dr.GetByte("MeTSM") != null) _meTSM = dr.GetByte("MeTSM");

            // exec dbo.spBenhAn_San_TK_GETAll @MaBA=N'14BA00025944',@dk=N'',@qadmin=1
            //if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            if (dr.GetString("MeLyDoTSM") != null) _meLyDoTSM = dr.GetString("MeLyDoTSM");
            if (dr.GetByte("MeAmDao") != null) _meAmDao = dr.GetByte("MeAmDao");
            if (dr.GetString("MeLyDoAmDao") != null) _meLyDoAmDao = dr.GetString("MeLyDoAmDao");
            if (dr.GetByte("MeCoTuCung") != null) _meCoTuCung = dr.GetByte("MeCoTuCung");
            if (dr.GetString("MeLyDoCoTuCung") != null) _meLyDoCoTuCung = dr.GetString("MeLyDoCoTuCung");
            if (dr.GetString("MeCanThiepKhac") != null) _meCanThiepKhac = dr.GetString("MeCanThiepKhac");
            if (dr.GetString("MeLyDo") != null) _meLyDo = dr.GetString("MeLyDo");
            if (dr.GetString("MeThoiGianChuyenDa") != null) _meThoiGianChuyenDa = dr.GetString("MeThoiGianChuyenDa");
            if (dr.GetString("MeThoiGianTheoDoi") != null) _meThoiGianTheoDoi = dr.GetString("MeThoiGianTheoDoi");
            if (dr.GetString("DieuTri") != null) _dieuTri = dr.GetString("DieuTri");
            if (dr.GetString("ChanDoan") != null) _chanDoan = dr.GetString("ChanDoan");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetString("TenBSKham") != null) _tenBSKham = dr.GetString("TenBSKham");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("RauCanNang") != null) _rauCanNang = dr.GetString("RauCanNang");

        }
		
		/// <summary>
		/// Insert the new <see cref="BenhAn_San_TK" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		 internal void Insert()
        {
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_San_TK
			// Copy & paste ham duoi day vao file DataProvider.cs
             if (!this.IsDirty)
                return;
            
              
            _sTT = DataProvider.Instance().InsertBenhAn_San_TK(_maBA, _ngayKham, _bSKham, _lyDoKham, _nhipTim, _xuongKhop, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _gt, _luongDinh, _toanTrang, _hutDich, _xoaBop, _tho, _khac, _datNoiKhiQuan, _bopBong, _diTathaumon, _diTatKhac, _cuThe, _rauSo, _kieuSo, _thoiGianSoRau, _rauConCo, _chieuDaiRau, _kiemSoatTuCung, _lyDoKiemSoat, _bocRau, _lyDoBocRau, _chayMau, _soLuong, _meMach, _meDa, _meNiemMac, _meApHuyet, _meNhietDo, _meNhipTho, _meCanNang, _meChieuCao, _mePhu, _meToanThan, _meToanTrang, _meCao, _meTim, _meGan, _mePhoi, _meThan, _meNuocOi, _meKieuOiVo, _meTieng, _meCachDe, _meGioDe, _meLyDoCachDe, _meNguoiDoDe, _meNguoiMo, _meTSM, _meLyDoTSM, _meAmDao, _meLyDoAmDao, _meCoTuCung, _meLyDoCoTuCung, _meCanThiepKhac, _meLyDo, _meThoiGianChuyenDa, _meThoiGianTheoDoi, _dieuTri, _chanDoan, _maMay,_nguoiSD , _rauCanNang );
			// public abstract String InsertBenhAn_San_TK(String _maBA, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _nhipTim, String _xuongKhop, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _gt, String _luongDinh, String _toanTrang, Boolean _hutDich, Boolean _xoaBop, Boolean _tho, Boolean _diTat, Boolean _datNoiKhiQuan, Boolean _bopBong, Boolean _diTathaumon, Boolean _diTatKhac, String _cuThe, SmartDate _rauSo, Byte _kieuSo, String _thoiGianSoRau, Boolean _rauConCo, String _chieuDaiRau, Boolean _kiemSoatTuCung, String _lyDoKiemSoat, Boolean _bocRau, String _lyDoBocRau, Boolean _chayMau, String _soLuong, String _meMach, String _meDa, String _meNiemMac, String _meApHuyet, String _meNhietDo, String _meNhipTho, String _meCanNang, String _meChieuCao, Boolean _mePhu, String _meToanThan, String _meToanTrang, String _meCao, String _meTim, String _meGan, String _mePhoi, String _meThan, String _meNuocOi, Byte _meKieuOiVo, String _meTieng, Byte _meCachDe, SmartDate _meGioDe, String _meLyDoCachDe, String _meNguoiDoDe, String _meNguoiMo, Byte _meTSM, String _meLyDoTSM, Byte _meAmDao, String _meLyDoAmDao, Byte _meCoTuCung, String _meLyDoCoTuCung, String _meCanThiepKhac, String _meLyDo, String _meThoiGianChuyenDa, String _meThoiGianTheoDoi, String _dieuTri, String _chanDoan, String _maMay, String _nguoiSD);
			// public override String InsertBenhAn_San_TK(String _maBA, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _nhipTim, String _xuongKhop, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _gt, String _luongDinh, String _toanTrang, Boolean _hutDich, Boolean _xoaBop, Boolean _tho, Boolean _diTat, Boolean _datNoiKhiQuan, Boolean _bopBong, Boolean _diTathaumon, Boolean _diTatKhac, String _cuThe, SmartDate _rauSo, Byte _kieuSo, String _thoiGianSoRau, Boolean _rauConCo, String _chieuDaiRau, Boolean _kiemSoatTuCung, String _lyDoKiemSoat, Boolean _bocRau, String _lyDoBocRau, Boolean _chayMau, String _soLuong, String _meMach, String _meDa, String _meNiemMac, String _meApHuyet, String _meNhietDo, String _meNhipTho, String _meCanNang, String _meChieuCao, Boolean _mePhu, String _meToanThan, String _meToanTrang, String _meCao, String _meTim, String _meGan, String _mePhoi, String _meThan, String _meNuocOi, Byte _meKieuOiVo, String _meTieng, Byte _meCachDe, SmartDate _meGioDe, String _meLyDoCachDe, String _meNguoiDoDe, String _meNguoiMo, Byte _meTSM, String _meLyDoTSM, Byte _meAmDao, String _meLyDoAmDao, Byte _meCoTuCung, String _meLyDoCoTuCung, String _meCanThiepKhac, String _meLyDo, String _meThoiGianChuyenDa, String _meThoiGianTheoDoi, String _dieuTri, String _chanDoan, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_San_TK_CREATE", _maBA, _ngayKham.DBValue, _bSKham, _lyDoKham, _nhipTim, _xuongKhop, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _gt, _luongDinh, _toanTrang, _hutDich, _xoaBop, _tho, _diTat, _datNoiKhiQuan, _bopBong, _diTathaumon, _diTatKhac, _cuThe, _rauSo.DBValue, _kieuSo, _thoiGianSoRau, _rauConCo, _chieuDaiRau, _kiemSoatTuCung, _lyDoKiemSoat, _bocRau, _lyDoBocRau, _chayMau, _soLuong, _meMach, _meDa, _meNiemMac, _meApHuyet, _meNhietDo, _meNhipTho, _meCanNang, _meChieuCao, _mePhu, _meToanThan, _meToanTrang, _meCao, _meTim, _meGan, _mePhoi, _meThan, _meNuocOi, _meKieuOiVo, _meTieng, _meCachDe, _meGioDe.DBValue, _meLyDoCachDe, _meNguoiDoDe, _meNguoiMo, _meTSM, _meLyDoTSM, _meAmDao, _meLyDoAmDao, _meCoTuCung, _meLyDoCoTuCung, _meCanThiepKhac, _meLyDo, _meThoiGianChuyenDa, _meThoiGianTheoDoi, _dieuTri, _chanDoan, _maMay, _nguoiSD));
			// }
		}
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_San_TK
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
              
			_sTT  = DataProvider.Instance().InsertBenhAn_San_TK(_maBA, _ngayKham, _bSKham, _lyDoKham, _nhipTim, _xuongKhop, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _gt, _luongDinh, _toanTrang, _hutDich, _xoaBop, _tho, _khac, _datNoiKhiQuan, _bopBong, _diTathaumon, _diTatKhac, _cuThe, _rauSo, _kieuSo, _thoiGianSoRau, _rauConCo, _chieuDaiRau, _kiemSoatTuCung, _lyDoKiemSoat, _bocRau, _lyDoBocRau, _chayMau, _soLuong, _meMach, _meDa, _meNiemMac, _meApHuyet, _meNhietDo, _meNhipTho, _meCanNang, _meChieuCao, _mePhu, _meToanThan, _meToanTrang, _meCao, _meTim, _meGan, _mePhoi, _meThan, _meNuocOi, _meKieuOiVo, _meTieng, _meCachDe, _meGioDe, _meLyDoCachDe, _meNguoiDoDe, _meNguoiMo, _meTSM, _meLyDoTSM, _meAmDao, _meLyDoAmDao, _meCoTuCung, _meLyDoCoTuCung, _meCanThiepKhac, _meLyDo, _meThoiGianChuyenDa, _meThoiGianTheoDoi, _dieuTri, _chanDoan, _maMay, _nguoiSD , _rauCanNang);
            // public abstract String InsertBenhAn_San_TK(String _maBA, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _nhipTim, String _xuongKhop, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _gt, String _luongDinh, String _toanTrang, Boolean _hutDich, Boolean _xoaBop, Boolean _tho, Boolean _diTat, Boolean _datNoiKhiQuan, Boolean _bopBong, Boolean _diTathaumon, Boolean _diTatKhac, String _cuThe, SmartDate _rauSo, Byte _kieuSo, String _thoiGianSoRau, Boolean _rauConCo, String _chieuDaiRau, Boolean _kiemSoatTuCung, String _lyDoKiemSoat, Boolean _bocRau, String _lyDoBocRau, Boolean _chayMau, String _soLuong, String _meMach, String _meDa, String _meNiemMac, String _meApHuyet, String _meNhietDo, String _meNhipTho, String _meCanNang, String _meChieuCao, Boolean _mePhu, String _meToanThan, String _meToanTrang, String _meCao, String _meTim, String _meGan, String _mePhoi, String _meThan, String _meNuocOi, Byte _meKieuOiVo, String _meTieng, Byte _meCachDe, SmartDate _meGioDe, String _meLyDoCachDe, String _meNguoiDoDe, String _meNguoiMo, Byte _meTSM, String _meLyDoTSM, Byte _meAmDao, String _meLyDoAmDao, Byte _meCoTuCung, String _meLyDoCoTuCung, String _meCanThiepKhac, String _meLyDo, String _meThoiGianChuyenDa, String _meThoiGianTheoDoi, String _dieuTri, String _chanDoan, String _maMay, String _nguoiSD);
            // public override String InsertBenhAn_San_TK(String _maBA, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _nhipTim, String _xuongKhop, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _gt, String _luongDinh, String _toanTrang, Boolean _hutDich, Boolean _xoaBop, Boolean _tho, Boolean _diTat, Boolean _datNoiKhiQuan, Boolean _bopBong, Boolean _diTathaumon, Boolean _diTatKhac, String _cuThe, SmartDate _rauSo, Byte _kieuSo, String _thoiGianSoRau, Boolean _rauConCo, String _chieuDaiRau, Boolean _kiemSoatTuCung, String _lyDoKiemSoat, Boolean _bocRau, String _lyDoBocRau, Boolean _chayMau, String _soLuong, String _meMach, String _meDa, String _meNiemMac, String _meApHuyet, String _meNhietDo, String _meNhipTho, String _meCanNang, String _meChieuCao, Boolean _mePhu, String _meToanThan, String _meToanTrang, String _meCao, String _meTim, String _meGan, String _mePhoi, String _meThan, String _meNuocOi, Byte _meKieuOiVo, String _meTieng, Byte _meCachDe, SmartDate _meGioDe, String _meLyDoCachDe, String _meNguoiDoDe, String _meNguoiMo, Byte _meTSM, String _meLyDoTSM, Byte _meAmDao, String _meLyDoAmDao, Byte _meCoTuCung, String _meLyDoCoTuCung, String _meCanThiepKhac, String _meLyDo, String _meThoiGianChuyenDa, String _meThoiGianTheoDoi, String _dieuTri, String _chanDoan, String _maMay, String _nguoiSD)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_San_TK_CREATE", _maBA, _ngayKham.DBValue, _bSKham, _lyDoKham, _nhipTim, _xuongKhop, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _gt, _luongDinh, _toanTrang, _hutDich, _xoaBop, _tho, _diTat, _datNoiKhiQuan, _bopBong, _diTathaumon, _diTatKhac, _cuThe, _rauSo.DBValue, _kieuSo, _thoiGianSoRau, _rauConCo, _chieuDaiRau, _kiemSoatTuCung, _lyDoKiemSoat, _bocRau, _lyDoBocRau, _chayMau, _soLuong, _meMach, _meDa, _meNiemMac, _meApHuyet, _meNhietDo, _meNhipTho, _meCanNang, _meChieuCao, _mePhu, _meToanThan, _meToanTrang, _meCao, _meTim, _meGan, _mePhoi, _meThan, _meNuocOi, _meKieuOiVo, _meTieng, _meCachDe, _meGioDe.DBValue, _meLyDoCachDe, _meNguoiDoDe, _meNguoiMo, _meTSM, _meLyDoTSM, _meAmDao, _meLyDoAmDao, _meCoTuCung, _meLyDoCoTuCung, _meCanThiepKhac, _meLyDo, _meThoiGianChuyenDa, _meThoiGianTheoDoi, _dieuTri, _chanDoan, _maMay, _nguoiSD));
            // }
        }
		/// <summary>
		/// Update all changes made on <see cref="BenhAn_San_TK" /> Object to underlying database.
		/// </summary>
		   internal void Update()
        {
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_San_TK
			if (!this.IsDirty)
                return;
            
              
              DataProvider.Instance().UpdateBenhAn_San_TK(_maBA, _sTT, _ngayKham, _bSKham, _lyDoKham, _nhipTim, _xuongKhop, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _gt, _luongDinh, _toanTrang, _hutDich, _xoaBop, _tho, _khac, _datNoiKhiQuan, _bopBong, _diTathaumon, _diTatKhac, _cuThe, _rauSo, _kieuSo, _thoiGianSoRau, _rauConCo, _chieuDaiRau, _kiemSoatTuCung, _lyDoKiemSoat, _bocRau, _lyDoBocRau, _chayMau, _soLuong, _meMach, _meDa, _meNiemMac, _meApHuyet, _meNhietDo, _meNhipTho, _meCanNang, _meChieuCao, _mePhu, _meToanThan, _meToanTrang, _meCao, _meTim, _meGan, _mePhoi, _meThan, _meNuocOi, _meKieuOiVo, _meTieng, _meCachDe, _meGioDe, _meLyDoCachDe, _meNguoiDoDe, _meNguoiMo, _meTSM, _meLyDoTSM, _meAmDao, _meLyDoAmDao, _meCoTuCung, _meLyDoCoTuCung, _meCanThiepKhac, _meLyDo, _meThoiGianChuyenDa, _meThoiGianTheoDoi, _dieuTri, _chanDoan, _maMay, _huy,_nguoiSD, _rauCanNang);
				// public abstract void UpdateBenhAn_San_TK(String _maBA, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _nhipTim, String _xuongKhop, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _gt, String _luongDinh, String _toanTrang, Boolean _hutDich, Boolean _xoaBop, Boolean _tho, Boolean _diTat, Boolean _datNoiKhiQuan, Boolean _bopBong, Boolean _diTathaumon, Boolean _diTatKhac, String _cuThe, SmartDate _rauSo, Byte _kieuSo, String _thoiGianSoRau, Boolean _rauConCo, String _chieuDaiRau, Boolean _kiemSoatTuCung, String _lyDoKiemSoat, Boolean _bocRau, String _lyDoBocRau, Boolean _chayMau, String _soLuong, String _meMach, String _meDa, String _meNiemMac, String _meApHuyet, String _meNhietDo, String _meNhipTho, String _meCanNang, String _meChieuCao, Boolean _mePhu, String _meToanThan, String _meToanTrang, String _meCao, String _meTim, String _meGan, String _mePhoi, String _meThan, String _meNuocOi, Byte _meKieuOiVo, String _meTieng, Byte _meCachDe, SmartDate _meGioDe, String _meLyDoCachDe, String _meNguoiDoDe, String _meNguoiMo, Byte _meTSM, String _meLyDoTSM, Byte _meAmDao, String _meLyDoAmDao, Byte _meCoTuCung, String _meLyDoCoTuCung, String _meCanThiepKhac, String _meLyDo, String _meThoiGianChuyenDa, String _meThoiGianTheoDoi, String _dieuTri, String _chanDoan, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateBenhAn_San_TK(String _maBA, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _nhipTim, String _xuongKhop, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _gt, String _luongDinh, String _toanTrang, Boolean _hutDich, Boolean _xoaBop, Boolean _tho, Boolean _diTat, Boolean _datNoiKhiQuan, Boolean _bopBong, Boolean _diTathaumon, Boolean _diTatKhac, String _cuThe, SmartDate _rauSo, Byte _kieuSo, String _thoiGianSoRau, Boolean _rauConCo, String _chieuDaiRau, Boolean _kiemSoatTuCung, String _lyDoKiemSoat, Boolean _bocRau, String _lyDoBocRau, Boolean _chayMau, String _soLuong, String _meMach, String _meDa, String _meNiemMac, String _meApHuyet, String _meNhietDo, String _meNhipTho, String _meCanNang, String _meChieuCao, Boolean _mePhu, String _meToanThan, String _meToanTrang, String _meCao, String _meTim, String _meGan, String _mePhoi, String _meThan, String _meNuocOi, Byte _meKieuOiVo, String _meTieng, Byte _meCachDe, SmartDate _meGioDe, String _meLyDoCachDe, String _meNguoiDoDe, String _meNguoiMo, Byte _meTSM, String _meLyDoTSM, Byte _meAmDao, String _meLyDoAmDao, Byte _meCoTuCung, String _meLyDoCoTuCung, String _meCanThiepKhac, String _meLyDo, String _meThoiGianChuyenDa, String _meThoiGianTheoDoi, String _dieuTri, String _chanDoan, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_San_TK_UPDATE", _maBA, _ngayKham.DBValue, _bSKham, _lyDoKham, _nhipTim, _xuongKhop, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _gt, _luongDinh, _toanTrang, _hutDich, _xoaBop, _tho, _diTat, _datNoiKhiQuan, _bopBong, _diTathaumon, _diTatKhac, _cuThe, _rauSo.DBValue, _kieuSo, _thoiGianSoRau, _rauConCo, _chieuDaiRau, _kiemSoatTuCung, _lyDoKiemSoat, _bocRau, _lyDoBocRau, _chayMau, _soLuong, _meMach, _meDa, _meNiemMac, _meApHuyet, _meNhietDo, _meNhipTho, _meCanNang, _meChieuCao, _mePhu, _meToanThan, _meToanTrang, _meCao, _meTim, _meGan, _mePhoi, _meThan, _meNuocOi, _meKieuOiVo, _meTieng, _meCachDe, _meGioDe.DBValue, _meLyDoCachDe, _meNguoiDoDe, _meNguoiMo, _meTSM, _meLyDoTSM, _meAmDao, _meLyDoAmDao, _meCoTuCung, _meLyDoCoTuCung, _meCanThiepKhac, _meLyDo, _meThoiGianChuyenDa, _meThoiGianTheoDoi, _dieuTri, _chanDoan, _maMay, _huy, _nguoiSD);
				// }				
			}

        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_San_TK
            if (!this.IsDirty)
                return;
            
              
            DataProvider.Instance().UpdateBenhAn_San_TK(_maBA,_sTT , _ngayKham, _bSKham, _lyDoKham, _nhipTim, _xuongKhop, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _gt, _luongDinh, _toanTrang, _hutDich, _xoaBop, _tho, _khac, _datNoiKhiQuan, _bopBong, _diTathaumon, _diTatKhac, _cuThe, _rauSo, _kieuSo, _thoiGianSoRau, _rauConCo, _chieuDaiRau, _kiemSoatTuCung, _lyDoKiemSoat, _bocRau, _lyDoBocRau, _chayMau, _soLuong, _meMach, _meDa, _meNiemMac, _meApHuyet, _meNhietDo, _meNhipTho, _meCanNang, _meChieuCao, _mePhu, _meToanThan, _meToanTrang, _meCao, _meTim, _meGan, _mePhoi, _meThan, _meNuocOi, _meKieuOiVo, _meTieng, _meCachDe, _meGioDe, _meLyDoCachDe, _meNguoiDoDe, _meNguoiMo, _meTSM, _meLyDoTSM, _meAmDao, _meLyDoAmDao, _meCoTuCung, _meLyDoCoTuCung, _meCanThiepKhac, _meLyDo, _meThoiGianChuyenDa, _meThoiGianTheoDoi, _dieuTri, _chanDoan, _maMay, _huy, _nguoiSD , _rauCanNang);
            // public abstract void UpdateBenhAn_San_TK(String _maBA, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _nhipTim, String _xuongKhop, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _gt, String _luongDinh, String _toanTrang, Boolean _hutDich, Boolean _xoaBop, Boolean _tho, Boolean _diTat, Boolean _datNoiKhiQuan, Boolean _bopBong, Boolean _diTathaumon, Boolean _diTatKhac, String _cuThe, SmartDate _rauSo, Byte _kieuSo, String _thoiGianSoRau, Boolean _rauConCo, String _chieuDaiRau, Boolean _kiemSoatTuCung, String _lyDoKiemSoat, Boolean _bocRau, String _lyDoBocRau, Boolean _chayMau, String _soLuong, String _meMach, String _meDa, String _meNiemMac, String _meApHuyet, String _meNhietDo, String _meNhipTho, String _meCanNang, String _meChieuCao, Boolean _mePhu, String _meToanThan, String _meToanTrang, String _meCao, String _meTim, String _meGan, String _mePhoi, String _meThan, String _meNuocOi, Byte _meKieuOiVo, String _meTieng, Byte _meCachDe, SmartDate _meGioDe, String _meLyDoCachDe, String _meNguoiDoDe, String _meNguoiMo, Byte _meTSM, String _meLyDoTSM, Byte _meAmDao, String _meLyDoAmDao, Byte _meCoTuCung, String _meLyDoCoTuCung, String _meCanThiepKhac, String _meLyDo, String _meThoiGianChuyenDa, String _meThoiGianTheoDoi, String _dieuTri, String _chanDoan, String _maMay, Boolean _huy, String _nguoiSD);
            // public override void UpdateBenhAn_San_TK(String _maBA, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _nhipTim, String _xuongKhop, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _gt, String _luongDinh, String _toanTrang, Boolean _hutDich, Boolean _xoaBop, Boolean _tho, Boolean _diTat, Boolean _datNoiKhiQuan, Boolean _bopBong, Boolean _diTathaumon, Boolean _diTatKhac, String _cuThe, SmartDate _rauSo, Byte _kieuSo, String _thoiGianSoRau, Boolean _rauConCo, String _chieuDaiRau, Boolean _kiemSoatTuCung, String _lyDoKiemSoat, Boolean _bocRau, String _lyDoBocRau, Boolean _chayMau, String _soLuong, String _meMach, String _meDa, String _meNiemMac, String _meApHuyet, String _meNhietDo, String _meNhipTho, String _meCanNang, String _meChieuCao, Boolean _mePhu, String _meToanThan, String _meToanTrang, String _meCao, String _meTim, String _meGan, String _mePhoi, String _meThan, String _meNuocOi, Byte _meKieuOiVo, String _meTieng, Byte _meCachDe, SmartDate _meGioDe, String _meLyDoCachDe, String _meNguoiDoDe, String _meNguoiMo, Byte _meTSM, String _meLyDoTSM, Byte _meAmDao, String _meLyDoAmDao, Byte _meCoTuCung, String _meLyDoCoTuCung, String _meCanThiepKhac, String _meLyDo, String _meThoiGianChuyenDa, String _meThoiGianTheoDoi, String _dieuTri, String _chanDoan, String _maMay, Boolean _huy, String _nguoiSD)
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_San_TK_UPDATE", _maBA, _ngayKham.DBValue, _bSKham, _lyDoKham, _nhipTim, _xuongKhop, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _gt, _luongDinh, _toanTrang, _hutDich, _xoaBop, _tho, _diTat, _datNoiKhiQuan, _bopBong, _diTathaumon, _diTatKhac, _cuThe, _rauSo.DBValue, _kieuSo, _thoiGianSoRau, _rauConCo, _chieuDaiRau, _kiemSoatTuCung, _lyDoKiemSoat, _bocRau, _lyDoBocRau, _chayMau, _soLuong, _meMach, _meDa, _meNiemMac, _meApHuyet, _meNhietDo, _meNhipTho, _meCanNang, _meChieuCao, _mePhu, _meToanThan, _meToanTrang, _meCao, _meTim, _meGan, _mePhoi, _meThan, _meNuocOi, _meKieuOiVo, _meTieng, _meCachDe, _meGioDe.DBValue, _meLyDoCachDe, _meNguoiDoDe, _meNguoiMo, _meTSM, _meLyDoTSM, _meAmDao, _meLyDoAmDao, _meCoTuCung, _meLyDoCoTuCung, _meCanThiepKhac, _meLyDo, _meThoiGianChuyenDa, _meThoiGianTheoDoi, _dieuTri, _chanDoan, _maMay, _huy, _nguoiSD);
            // }				
        }
           internal void DeleteSelf()
            {
                if (!this.IsDirty)
                    return;
                if (this.IsNew)
                    return;
              
                DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maBA,_sTT ));
		    }

		/// <summary>
		/// Delete the <see cref="BenhAn_San_TK" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_San_TK
            DataProvider.Instance().DeleteBenhAn_San_TK(crit.MaMay, crit.NguoiSD, crit.MaBA,crit .STT);
			// public abstract void DeleteBenhAn_San_TK(String _maBA);
			// public override void DeleteBenhAn_San_TK(String _maBA)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_San_TK_Deleted", _maBA);
			// }
		}
     
		#endregion
	}

}
