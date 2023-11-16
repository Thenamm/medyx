// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	ThongTinBN_TienSu_San
// Kieu doi tuong  :	ThongTinBN_TienSu_San
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	03/31/2010 9:56:31 AM
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
	/// This is a base generated class of <see cref="ThongTinBN_TienSu_San" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class ThongTinBN_TienSu_San : BusinessBase<ThongTinBN_TienSu_San>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maBN = String.Empty;
		private Boolean _tSGDSinhdoi = false;
        private Boolean _tSGDSinhdoiT = false;

		private Boolean _tSGDDidang = false;
        private Boolean _tSGDDidangT = false;

		private Boolean _tSGDBenhditruyen = false;
        private Boolean _tSGDBenhditruyenT = false;

		private Boolean _tSGDDaiduong = false;
        private Boolean _tSGDDaiduongT = false;

		private Boolean _tSGDCaoHA = false;
        private Boolean _tSGDCaoHAT = false;

		private String _tSGDKhac = String.Empty;

		private Boolean _tSBTCaoHA = false;
        private Boolean _tSBTCaoHAT = false;

		private Boolean _tSBTBenhTim = false;
        private Boolean _tSBTBenhTimT = false;

		private Boolean _tSBTLaoPhoi = false;
        private Boolean _tSBTLaoPhoiT = false;

		private Boolean _tSBTHenphequan = false;
        private Boolean _tSBTHenphequanT = false;

		private Boolean _tSBTBenhthan = false;
        private Boolean _tSBTBenhthanT = false;

		private Boolean _tSBTBasedow = false;
        private Boolean _tSBTBasedowT = false;

		private Boolean _tSBTViemtacTM = false;
        private Boolean _tSBTViemtacTMT = false;

		private Boolean _tSBTDongkinh = false;
        private Boolean _tSBTDongkinhT = false;

		private Boolean _tSBTMoRuotthua = false;
        private Boolean _tSBTMoRuotthuaT = false;


        private Boolean _diungthuoc = false;
        private Boolean _diungthuocT = false;
		private String _pTObung = String.Empty;
		private String _tuoiCokinh = String.Empty;
		private String _chukyKinh = String.Empty;
		private String _songayKinh = String.Empty;
		private String _tuoiLaychong = String.Empty;
		private String _benhphukhoa = String.Empty;

		private Boolean _khoiUBT = false;
        private Boolean _khoiUBTT = false;

		private Boolean _uxoTC = false;
        private Boolean _uxoTCT = false;

		private Boolean _didangSD = false;
        private Boolean _didangSDT = false;

		private Boolean _sSD = false;
        private Boolean _sSDT = false;

		private Boolean _tSM = false;
        private Boolean _tSMT = false;

		private Boolean _dieuTriCTC = false;
        private Boolean _dieuTriCTCT = false;

		private Boolean _catcutCTC = false;
        private Boolean _catcutCTCT = false;

		private String _phauthuatKhac = String.Empty;
		private String _pARA = String.Empty;
		private String _tSBTKhac = String.Empty;
		private Byte _solancothai = 0;
		private Byte _solansaythai = 0;
		private Byte _solannaothai = 0;
		private Byte _solande = 0;
		private String _cachde = String.Empty;
		private Byte _soconsong = 0;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
        private String _tennguoiSD = String.Empty;
        private String _cuthe = String.Empty;
        private int _OrderNumber;
		#endregion
		
		#region Business Properties and Methods
		
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
		
		public Boolean TSGDSinhdoi
		{
			get 
			{
				CanReadProperty("TSGDSinhdoi", true);
				return _tSGDSinhdoi;
			}
			set 
			{
				CanWriteProperty("TSGDSinhdoi", true);
				if (_tSGDSinhdoi != value) 
				{
					_tSGDSinhdoi = value;
					PropertyHasChanged("TSGDSinhdoi");
				}
			}
		}
       
        public Boolean TSGDSinhdoiT
        {
            get
            {
                CanReadProperty("TSGDSinhdoiT", true);
                if (_tSGDSinhdoi  == true)
                    return false ;
                else
                    return true ;
            }
            set
            {
                CanWriteProperty("TSGDSinhdoiT", true);
                this._tSGDSinhdoiT = value;
                if (_tSGDSinhdoiT == true)
                    _tSGDSinhdoi = false;
                PropertyHasChanged("TSGDSinhdoiT");

            }

        }
		
		public Boolean TSGDDidang
		{
			get 
			{
				CanReadProperty("TSGDDidang", true);
				return _tSGDDidang;
			}
			set 
			{
				CanWriteProperty("TSGDDidang", true);
				if (_tSGDDidang != value) 
				{
					_tSGDDidang = value;
					PropertyHasChanged("TSGDDidang");
				}
			}
		}

        public Boolean TSGDDidangT
        {
            get
            {
                CanReadProperty("TSGDDidangT", true);
                if (_tSGDDidang  == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("TSGDDidangT", true);
                this._tSGDDidangT = value;
                if (_tSGDDidangT == true)
                    _tSGDDidang = false;
                PropertyHasChanged("TSGDDidangT");

            }


        }
		
		public Boolean TSGDBenhditruyen
		{
			get 
			{
				CanReadProperty("TSGDBenhditruyen", true);
				return _tSGDBenhditruyen;
			}
			set 
			{
				CanWriteProperty("TSGDBenhditruyen", true);
				if (_tSGDBenhditruyen != value) 
				{
					_tSGDBenhditruyen = value;
					PropertyHasChanged("TSGDBenhditruyen");
				}
			}
		}

        public Boolean TSGDBenhditruyenT
        {
            get
            {
                CanReadProperty("TSGDBenhditruyenT", true);
                if (_tSGDBenhditruyen  == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("TSGDBenhditruyenT", true);
                this._tSGDBenhditruyenT = value;
                if (_tSGDBenhditruyenT == true)
                    _tSGDBenhditruyen = false;
                PropertyHasChanged("TSGDBenhditruyenT");

            }

        }


		public Boolean TSGDDaiduong
		{
			get 
			{
				CanReadProperty("TSGDDaiduong", true);
				return _tSGDDaiduong;
			}
			set 
			{
				CanWriteProperty("TSGDDaiduong", true);
				if (_tSGDDaiduong != value) 
				{
					_tSGDDaiduong = value;
					PropertyHasChanged("TSGDDaiduong");
				}
			}
		}

        public Boolean TSGDDaiduongT
        {
            get
            {
                CanReadProperty("TSGDDaiduongT", true);
                if (_tSGDDaiduong == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("TSGDDaiduongT", true);
                this._tSGDDaiduongT = value;
                if (_tSGDDaiduongT == true)
                    _tSGDDaiduong = false;
                PropertyHasChanged("TSGDDaiduongT");

            }

        }
		
		public Boolean TSGDCaoHA
		{
			get 
			{
				CanReadProperty("TSGDCaoHA", true);
				return _tSGDCaoHA;
			}
			set 
			{
				CanWriteProperty("TSGDCaoHA", true);
				if (_tSGDCaoHA != value) 
				{
					_tSGDCaoHA = value;
					PropertyHasChanged("TSGDCaoHA");
				}
			}
		}
        public Boolean TSGDCaoHAT
        {
            get
            {
                CanReadProperty("TSGDCaoHAT", true);
                if (_tSGDCaoHA == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("TSGDCaoHAT", true);
                this._tSGDCaoHAT = value;
                if (_tSGDCaoHAT == true)
                    _tSGDCaoHA = false;
                PropertyHasChanged("TSGDCaoHAT");

            }

        }
		
		public String TSGDKhac
		{
			get 
			{
				CanReadProperty("TSGDKhac", true);
				return _tSGDKhac;
			}
			set 
			{
				CanWriteProperty("TSGDKhac", true);
				if (_tSGDKhac != value) 
				{
					_tSGDKhac = value;
					PropertyHasChanged("TSGDKhac");
				}
			}
		}
		
		public Boolean TSBTCaoHA
		{
			get 
			{
				CanReadProperty("TSBTCaoHA", true);
				return _tSBTCaoHA;
			}
			set 
			{
				CanWriteProperty("TSBTCaoHA", true);
				if (_tSBTCaoHA != value) 
				{
					_tSBTCaoHA = value;
					PropertyHasChanged("TSBTCaoHA");
				}
			}
		}

        public Boolean TSBTCaoHAT
        {
            get
            {
                CanReadProperty("TSBTCaoHAT", true);
                if (_tSBTCaoHA == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("TSBTCaoHAT", true);
                this._tSBTCaoHAT = value;
                if (_tSBTCaoHAT == true)
                    _tSBTCaoHA = false;
                PropertyHasChanged("TSBTCaoHAT");

            }


        }
		
		public Boolean TSBTBenhTim
		{
			get 
			{
				CanReadProperty("TSBTBenhTim", true);
				return _tSBTBenhTim;
			}
			set 
			{
				CanWriteProperty("TSBTBenhTim", true);
				if (_tSBTBenhTim != value) 
				{
					_tSBTBenhTim = value;
					PropertyHasChanged("TSBTBenhTim");
				}
			}
		}
        public Boolean TSBTBenhTimT
        {
            get
            {
                CanReadProperty("TSBTBenhTimT", true);
                if (_tSBTBenhTim == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("TSBTBenhTimT", true);
                this._tSBTBenhTimT = value;
                if (_tSBTBenhTimT == true)
                    _tSBTBenhTim = false;
                PropertyHasChanged("TSBTBenhTimT");

            }

        }
		
		public Boolean TSBTLaoPhoi
		{
			get 
			{
				CanReadProperty("TSBTLaoPhoi", true);
				return _tSBTLaoPhoi;
			}
			set 
			{
				CanWriteProperty("TSBTLaoPhoi", true);
				if (_tSBTLaoPhoi != value) 
				{
					_tSBTLaoPhoi = value;
					PropertyHasChanged("TSBTLaoPhoi");
				}
			}
		}
        public Boolean TSBTLaoPhoiT
        {
            get
            {
                CanReadProperty("TSBTLaoPhoiT", true);
                if (_tSBTLaoPhoi == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("TSBTLaoPhoiT", true);
                this._tSBTLaoPhoiT = value;
                if (_tSBTLaoPhoiT == true)
                    _tSBTLaoPhoi = false;
                PropertyHasChanged("TSBTLaoPhoiT");

            }

        }
		
		public Boolean TSBTHenphequan
		{
			get 
			{
				CanReadProperty("TSBTHenphequan", true);
				return _tSBTHenphequan;
			}
			set 
			{
				CanWriteProperty("TSBTHenphequan", true);
				if (_tSBTHenphequan != value) 
				{
					_tSBTHenphequan = value;
					PropertyHasChanged("TSBTHenphequan");
				}
			}
		}
        public Boolean TSBTHenphequanT
        {
            get
            {
                CanReadProperty("TSBTHenphequanT", true);
                if (_tSBTHenphequan == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("TSBTHenphequanT", true);
                this._tSBTHenphequanT = value;
                if (_tSBTHenphequanT == true)
                    _tSBTHenphequan = false;
                PropertyHasChanged("TSBTHenphequanT");

            }

        }
		
		public Boolean TSBTBenhthan
		{
			get 
			{
				CanReadProperty("TSBTBenhthan", true);
				return _tSBTBenhthan;
			}
			set 
			{
				CanWriteProperty("TSBTBenhthan", true);
				if (_tSBTBenhthan != value) 
				{
					_tSBTBenhthan = value;
					PropertyHasChanged("TSBTBenhthan");
				}
			}
		}
        public Boolean TSBTBenhthanT
        {
            get
            {
                CanReadProperty("TSBTBenhthanT", true);
                if (_tSBTBenhthan == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("TSBTBenhthanT", true);
                this._tSBTBenhthanT = value;
                if (_tSBTBenhthanT == true)
                    _tSBTBenhthan = false;
                PropertyHasChanged("TSBTBenhthanT");

            }

        }
		
		public Boolean TSBTBasedow
		{
			get 
			{
				CanReadProperty("TSBTBasedow", true);
				return _tSBTBasedow;
			}
			set 
			{
				CanWriteProperty("TSBTBasedow", true);
				if (_tSBTBasedow != value) 
				{
					_tSBTBasedow = value;
					PropertyHasChanged("TSBTBasedow");
				}
			}
		}
        public Boolean TSBTBasedowT
        {
            get
            {
                CanReadProperty("TSBTBasedowT", true);
                if (_tSBTBasedow == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("TSBTBasedowT", true);
                this._tSBTBasedowT = value;
                if (_tSBTBasedowT == true)
                    _tSBTBasedow = false;
                PropertyHasChanged("TSBTBasedowT");

            }

        }
		

		public Boolean TSBTViemtacTM
		{
			get 
			{
				CanReadProperty("TSBTViemtacTM", true);
				return _tSBTViemtacTM;
			}
			set 
			{
				CanWriteProperty("TSBTViemtacTM", true);
				if (_tSBTViemtacTM != value) 
				{
					_tSBTViemtacTM = value;
					PropertyHasChanged("TSBTViemtacTM");
				}
			}
		}
        public Boolean TSBTViemtacTMT
        {
            get
            {
                CanReadProperty("TSBTViemtacTMT", true);
                if (_tSBTViemtacTM == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("TSBTViemtacTMT", true);
                this._tSBTViemtacTMT = value;
                if (_tSBTViemtacTMT == true)
                    _tSBTViemtacTM = false;
                PropertyHasChanged("TSBTViemtacTMT");

            }

        }
		
		public Boolean TSBTDongkinh
		{
			get 
			{
				CanReadProperty("TSBTDongkinh", true);
				return _tSBTDongkinh;
			}
			set 
			{
				CanWriteProperty("TSBTDongkinh", true);
				if (_tSBTDongkinh != value) 
				{
					_tSBTDongkinh = value;
					PropertyHasChanged("TSBTDongkinh");
				}
			}
		}
        public Boolean TSBTDongkinhT
        {
            get
            {
                CanReadProperty("TSBTDongkinhT", true);
                if (_tSBTDongkinh == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("TSBTDongkinhT", true);
                this._tSBTDongkinhT = value;
                if (_tSBTDongkinhT == true)
                    _tSBTDongkinh = false;
                PropertyHasChanged("TSBTDongkinhT");

            }
        }
		
		public Boolean TSBTMoRuotthua
		{
			get 
			{
				CanReadProperty("TSBTMoRuotthua", true);
				return _tSBTMoRuotthua;
			}
			set 
			{
				CanWriteProperty("TSBTMoRuotthua", true);
				if (_tSBTMoRuotthua != value) 
				{
					_tSBTMoRuotthua = value;
					PropertyHasChanged("TSBTMoRuotthua");
				}
			}
		}
        public Boolean TSBTMoRuotthuaT
        {
            get
            {
                CanReadProperty("TSBTMoRuotthuaT", true);
                if (_tSBTMoRuotthua == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("TSBTMoRuotthuaT", true);
                this._tSBTMoRuotthuaT = value;
                if (_tSBTMoRuotthuaT == true)
                    _tSBTMoRuotthua = false;
                PropertyHasChanged("TSBTMoRuotthuaT");

            }
        }
		
	
        public Boolean diungthuoc
        {
            get
            {
                CanReadProperty("diungthuoc", true);
                return _diungthuoc;
            }
            set
            {
                CanWriteProperty("diungthuoc", true);
                if (_diungthuoc != value)
                {
                    _diungthuoc = value;
                    PropertyHasChanged("diungthuoc");
                }
            }
        }
		
		public String PTObung
		{
			get 
			{
				CanReadProperty("PTObung", true);
				return _pTObung;
			}
			set 
			{
				CanWriteProperty("PTObung", true);
				if (_pTObung != value) 
				{
					_pTObung = value;
					PropertyHasChanged("PTObung");
				}
			}
		}
		
		public String TuoiCokinh
		{
			get 
			{
				CanReadProperty("TuoiCokinh", true);
				return _tuoiCokinh;
			}
			set 
			{
				CanWriteProperty("TuoiCokinh", true);
				if (_tuoiCokinh != value) 
				{
					_tuoiCokinh = value;
					PropertyHasChanged("TuoiCokinh");
				}
			}
		}
		
		public String ChukyKinh
		{
			get 
			{
				CanReadProperty("ChukyKinh", true);
				return _chukyKinh;
			}
			set 
			{
				CanWriteProperty("ChukyKinh", true);
				if (_chukyKinh != value) 
				{
					_chukyKinh = value;
					PropertyHasChanged("ChukyKinh");
				}
			}
		}
		
		public String SongayKinh
		{
			get 
			{
				CanReadProperty("SongayKinh", true);
				return _songayKinh;
			}
			set 
			{
				CanWriteProperty("SongayKinh", true);
				if (_songayKinh != value) 
				{
					_songayKinh = value;
					PropertyHasChanged("SongayKinh");
				}
			}
		}
		
		public String TuoiLaychong
		{
			get 
			{
				CanReadProperty("TuoiLaychong", true);
				return _tuoiLaychong;
			}
			set 
			{
				CanWriteProperty("TuoiLaychong", true);
				if (_tuoiLaychong != value) 
				{
					_tuoiLaychong = value;
					PropertyHasChanged("TuoiLaychong");
				}
			}
		}
		
		public String Benhphukhoa
		{
			get 
			{
				CanReadProperty("Benhphukhoa", true);
				return _benhphukhoa;
			}
			set 
			{
				CanWriteProperty("Benhphukhoa", true);
				if (_benhphukhoa != value) 
				{
					_benhphukhoa = value;
					PropertyHasChanged("Benhphukhoa");
				}
			}
		}
		
		public Boolean KhoiUBT
		{
			get 
			{
				CanReadProperty("KhoiUBT", true);
				return _khoiUBT;
			}
			set 
			{
				CanWriteProperty("KhoiUBT", true);
				if (_khoiUBT != value) 
				{
					_khoiUBT = value;
					PropertyHasChanged("KhoiUBT");
				}
			}
		}
        public Boolean KhoiUBTT
        {
            get
            {
                CanReadProperty("KhoiUBTT", true);
                if (_khoiUBT == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("KhoiUBTT", true);
                this._khoiUBTT = value;
                if (_khoiUBTT == true)
                    _khoiUBT = false;
                PropertyHasChanged("KhoiUBTT");

            }
        }
		
		public Boolean UxoTC
		{
			get 
			{
				CanReadProperty("UxoTC", true);
				return _uxoTC;
			}
			set 
			{
				CanWriteProperty("UxoTC", true);
				if (_uxoTC != value) 
				{
					_uxoTC = value;
					PropertyHasChanged("UxoTC");
				}
			}
		}
        public Boolean UxoTCT
        {
            get
            {
                CanReadProperty("UxoTCT", true);
                if (_uxoTC == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("UxoTCT", true);
                this._uxoTCT = value;
                if (_uxoTCT == true)
                    _uxoTC = false;
                PropertyHasChanged("UxoTCT");

            }
        }
		
		public Boolean DidangSD
		{
			get 
			{
				CanReadProperty("DidangSD", true);
				return _didangSD;
			}
			set 
			{
				CanWriteProperty("DidangSD", true);
				if (_didangSD != value) 
				{
					_didangSD = value;
					PropertyHasChanged("DidangSD");
				}
			}
		}
        public Boolean DidangSDT
        {
            get
            {
                CanReadProperty("DidangSDT", true);
                if (_didangSD == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("DidangSDT", true);
                this._didangSDT = value;
                if (_didangSDT == true)
                    _didangSD = false;
                PropertyHasChanged("DidangSDT");

            }
        }
		
		public Boolean SSD
		{
			get 
			{
				CanReadProperty("SSD", true);
				return _sSD;
			}
			set 
			{
				CanWriteProperty("SSD", true);
				if (_sSD != value) 
				{
					_sSD = value;
					PropertyHasChanged("SSD");
				}
			}
		}
        public Boolean SSDT
        {
            get
            {
                CanReadProperty("SSDT", true);
                if (_sSD == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("SSDT", true);
                this._sSDT = value;
                if (_sSDT == true)
                    _sSD = false;
                PropertyHasChanged("SSDT");

            }
        }
		
		public Boolean TSM
		{
			get 
			{
				CanReadProperty("TSM", true);
				return _tSM;
			}
			set 
			{
				CanWriteProperty("TSM", true);
				if (_tSM != value) 
				{
					_tSM = value;
					PropertyHasChanged("TSM");
				}
			}
		}
        public Boolean TSMT
        {
            get
            {
                CanReadProperty("TSMT", true);
                if (_tSM == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("TSMT", true);
                this._tSMT = value;
                if (_tSMT == true)
                    _tSM = false;
                PropertyHasChanged("TSMT");

            }
        }
		
		public Boolean DieuTriCTC
		{
			get 
			{
				CanReadProperty("DieuTriCTC", true);
				return _dieuTriCTC;
			}
			set 
			{
				CanWriteProperty("DieuTriCTC", true);
				if (_dieuTriCTC != value) 
				{
					_dieuTriCTC = value;
					PropertyHasChanged("DieuTriCTC");
				}
			}
		}
        public Boolean DieuTriCTCT
        {
            get
            {
                CanReadProperty("DieuTriCTCT", true);
                if (_dieuTriCTC == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("DieuTriCTCT", true);
                this._dieuTriCTCT = value;
                if (_dieuTriCTCT == true)
                    _dieuTriCTC = false;
                PropertyHasChanged("DieuTriCTCT");

            }
        }
		
		public Boolean CatcutCTC
		{
			get 
			{
				CanReadProperty("CatcutCTC", true);
				return _catcutCTC;
			}
			set 
			{
				CanWriteProperty("CatcutCTC", true);
				if (_catcutCTC != value) 
				{
					_catcutCTC = value;
					PropertyHasChanged("CatcutCTC");
				}
			}
		}
        public Boolean CatcutCTCT
        {
            get
            {
                CanReadProperty("CatcutCTCT", true);
                if (_catcutCTC == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("CatcutCTCT", true);
                this._catcutCTCT = value;
                if (_catcutCTCT == true)
                    _catcutCTC = false;
                PropertyHasChanged("CatcutCTCT");

            }
        }
		
		public String PhauthuatKhac
		{
			get 
			{
				CanReadProperty("PhauthuatKhac", true);
				return _phauthuatKhac;
			}
			set 
			{
				CanWriteProperty("PhauthuatKhac", true);
				if (_phauthuatKhac != value) 
				{
					_phauthuatKhac = value;
					PropertyHasChanged("PhauthuatKhac");
				}
			}
		}
		
		public String PARA
		{
			get 
			{
				CanReadProperty("PARA", true);
				return _pARA;
			}
			set 
			{
				CanWriteProperty("PARA", true);
				if (_pARA != value) 
				{
					_pARA = value;
					PropertyHasChanged("PARA");
				}
			}
		}
		
		public String TSBTKhac
		{
			get 
			{
				CanReadProperty("TSBTKhac", true);
				return _tSBTKhac;
			}
			set 
			{
				CanWriteProperty("TSBTKhac", true);
				if (_tSBTKhac != value) 
				{
					_tSBTKhac = value;
					PropertyHasChanged("TSBTKhac");
				}
			}
		}
		

		public Byte Solancothai
		{
			get 
			{
				CanReadProperty("Solancothai", true);
				return _solancothai;
			}
			set 
			{
				CanWriteProperty("Solancothai", true);
				if (_solancothai != value) 
				{
					_solancothai = value;
					PropertyHasChanged("Solancothai");
				}
			}
		}
		
		public Byte Solansaythai
		{
			get 
			{
				CanReadProperty("Solansaythai", true);
				return _solansaythai;
			}
			set 
			{
				CanWriteProperty("Solansaythai", true);
				if (_solansaythai != value) 
				{
					_solansaythai = value;
					PropertyHasChanged("Solansaythai");
				}
			}
		}
		
		public Byte Solannaothai
		{
			get 
			{
				CanReadProperty("Solannaothai", true);
				return _solannaothai;
			}
			set 
			{
				CanWriteProperty("Solannaothai", true);
				if (_solannaothai != value) 
				{
					_solannaothai = value;
					PropertyHasChanged("Solannaothai");
				}
			}
		}
		
		public Byte Solande
		{
			get 
			{
				CanReadProperty("Solande", true);
				return _solande;
			}
			set 
			{
				CanWriteProperty("Solande", true);
				if (_solande != value) 
				{
					_solande = value;
					PropertyHasChanged("Solande");
				}
			}
		}
		
		public String Cachde
		{
			get 
			{
				CanReadProperty("Cachde", true);
				return _cachde;
			}
			set 
			{
				CanWriteProperty("Cachde", true);
				if (_cachde != value) 
				{
					_cachde = value;
					PropertyHasChanged("Cachde");
				}
			}
		}
		
		public Byte Soconsong
		{
			get 
			{
				CanReadProperty("Soconsong", true);
				return _soconsong;
			}
			set 
			{
				CanWriteProperty("Soconsong", true);
				if (_soconsong != value) 
				{
					_soconsong = value;
					PropertyHasChanged("Soconsong");
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

        public String CuThe
        {
            get
            {
                CanReadProperty("CuThe", true);
                return _cuthe;
            }
            set
            {
                CanWriteProperty("CuThe", true);
                if (_cuthe != value)
                {
                    _cuthe = value;
                    PropertyHasChanged("CuThe");
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

        ThongTinBN_TienSu_San_CList _ThongTinBN_TienSu_San_CList = ThongTinBN_TienSu_San_CList.NewThongTinBN_TienSu_San_CList();

        public ThongTinBN_TienSu_San_CList ThongTinBN_TienSu_San_CList
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _ThongTinBN_TienSu_San_CList;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_ThongTinBN_TienSu_San_CList.Equals(value))
                {
                    _ThongTinBN_TienSu_San_CList = value;
                    PropertyHasChanged();
                }
            }
        }

		protected override Object GetIdValue()
		{
			return _maBN;
		}
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _ThongTinBN_TienSu_San_CList.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid && _ThongTinBN_TienSu_San_CList.IsValid;
            }
        }
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="ThongTinBN_TienSu_San" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static ThongTinBN_TienSu_San NewThongTinBN_TienSu_San()
        {
            return DataPortal.Create<ThongTinBN_TienSu_San>();
        }
		public static ThongTinBN_TienSu_San GetThongTinBN_TienSu_San(String maBN)
		{
			return DataPortal.Fetch<ThongTinBN_TienSu_San>(new Criteria(maBN));
		}
        public static ThongTinBN_TienSu_San GetThongTinBN_TienSu_San(SafeDataReader dr)
        {
            ThongTinBN_TienSu_San obj = new ThongTinBN_TienSu_San();
            obj.Fetch(dr);
            return obj;
        }
        public static ThongTinBN_TienSu_San GetThongTinBN_TienSu_San(SafeDataReader dr, int i)
        {
            return new ThongTinBN_TienSu_San(dr, i);

        }
		/// <summary>
		/// Marks the <see cref="ThongTinBN_TienSu_San" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteThongTinBN_TienSu_San(String maBN, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maBN));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal ThongTinBN_TienSu_San()
		{	
			// Prevent direct creation
		}
        internal ThongTinBN_TienSu_San( 
                            int OrderNumber,
                            String maBN ,
		                 Boolean tSGDSinhdoi ,
		                 Boolean tSGDDidang ,
		                 Boolean tSGDBenhditruyen ,
		                 Boolean tSGDDaiduong ,
		                 Boolean tSGDCaoHA ,
		                 String tSGDKhac ,
		                 Boolean tSBTCaoHA ,
		                 Boolean tSBTBenhTim ,
		                 Boolean tSBTLaoPhoi ,
		                 Boolean tSBTHenphequan ,
		                 Boolean tSBTBenhthan ,
		                 Boolean tSBTBasedow ,
		                 Boolean tSBTViemtacTM ,
		                 Boolean tSBTDongkinh ,
		                 Boolean tSBTMoRuotthua ,
                         Boolean diungthuoc,
		                 String pTObung ,
		                 String tuoiCokinh ,
		                 String chukyKinh ,
		                 String songayKinh ,
		                 String tuoiLaychong ,
		                 String benhphukhoa ,
		                 Boolean khoiUBT ,
		                 Boolean uxoTC ,
		                 Boolean didangSD ,
		                 Boolean sSD ,
		                 Boolean tSM ,
		                 Boolean dieuTriCTC ,
		                 Boolean catcutCTC ,
		                 String phauthuatKhac ,
		                 String pARA ,
		                 String tSBTKhac ,
		                 Byte solancothai ,
		                 Byte solansaythai ,
		                 Byte solannaothai,
		                 Byte solande ,
		                 String cachde ,
		                 Byte soconsong ,
		                 String maMay ,
		                 Boolean huy ,
		                 SmartDate ngaySD ,
		                 String nguoiSD ,
		                 SmartDate ngaySD1 ,
		                 String nguoiSD1 ,
                         String tennguoiSD ,
                         String cuthe

         )
        {
          _OrderNumber = OrderNumber ;
             _maBN = maBN ;
		  _tSGDSinhdoi = tSGDSinhdoi ;
		  _tSGDDidang = tSGDDidang ;
		  _tSGDBenhditruyen = tSGDBenhditruyen ;
		  _tSGDDaiduong = tSGDDaiduong ;
		  _tSGDCaoHA = tSGDCaoHA ;
		  _tSGDKhac = tSGDKhac ;
		  _tSBTCaoHA = tSBTCaoHA ;
		  _tSBTBenhTim = tSBTBenhTim ;
		  _tSBTLaoPhoi = tSBTLaoPhoi ;
		  _tSBTHenphequan = tSBTHenphequan ;
		  _tSBTBenhthan = tSBTBenhthan ;
		  _tSBTBasedow = tSBTBasedow;
		  _tSBTViemtacTM = tSBTViemtacTM ;
		  _tSBTDongkinh = tSBTDongkinh ;
		  _tSBTMoRuotthua = tSBTMoRuotthua ;
		  _diungthuoc = diungthuoc ;
		  _pTObung = pTObung ;
		  _tuoiCokinh = tuoiCokinh ;
		  _chukyKinh = chukyKinh ;
		  _songayKinh = songayKinh ;
		  _tuoiLaychong = tuoiLaychong ;
		  _benhphukhoa = benhphukhoa ;
		  _khoiUBT = khoiUBT ;
		  _uxoTC = uxoTC ;
		  _didangSD = didangSD ;
		  _sSD = sSD ;
		  _tSM = tSM ;
		  _dieuTriCTC = dieuTriCTC ;
		  _catcutCTC = catcutCTC ;
		  _phauthuatKhac = phauthuatKhac ;
		  _pARA = pARA ;
		  _tSBTKhac = tSBTKhac ;
		  _solancothai = solancothai ;
		  _solansaythai = solansaythai ;
		  _solannaothai = solannaothai ;
		  _solande = solande ;
		  _cachde = cachde ;
		  _soconsong = soconsong ;
		  _maMay = maMay ;
		  _huy = huy ;
		  _ngaySD = ngaySD ;
		  _nguoiSD = nguoiSD ;
		  _ngaySD1 = ngaySD1 ;
		  _nguoiSD1 = nguoiSD1 ;
          _tennguoiSD = tennguoiSD ;
          _cuthe = cuthe;
        }

        protected ThongTinBN_TienSu_San(SafeDataReader dr, int i)
        {
            MarkAsChild();

            if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
            if (dr.GetBoolean("TSGDSinhdoi") != null) _tSGDSinhdoi = dr.GetBoolean("TSGDSinhdoi");
            if (dr.GetBoolean("TSGDDidang") != null) _tSGDDidang = dr.GetBoolean("TSGDDidang");
            if (dr.GetBoolean("TSGDBenhditruyen") != null) _tSGDBenhditruyen = dr.GetBoolean("TSGDBenhditruyen");
            if (dr.GetBoolean("TSGDDaiduong") != null) _tSGDDaiduong = dr.GetBoolean("TSGDDaiduong");
            if (dr.GetBoolean("TSGDCaoHA") != null) _tSGDCaoHA = dr.GetBoolean("TSGDCaoHA");
            if (dr.GetString("TSGDKhac") != null) _tSGDKhac = dr.GetString("TSGDKhac");
            if (dr.GetBoolean("TSBTCaoHA") != null) _tSBTCaoHA = dr.GetBoolean("TSBTCaoHA");
            if (dr.GetBoolean("TSBTBenhTim") != null) _tSBTBenhTim = dr.GetBoolean("TSBTBenhTim");
            if (dr.GetBoolean("TSBTLaoPhoi") != null) _tSBTLaoPhoi = dr.GetBoolean("TSBTLaoPhoi");
            if (dr.GetBoolean("TSBTHenphequan") != null) _tSBTHenphequan = dr.GetBoolean("TSBTHenphequan");
            if (dr.GetBoolean("TSBTBenhthan") != null) _tSBTBenhthan = dr.GetBoolean("TSBTBenhthan");
            if (dr.GetBoolean("TSBTBasedow") != null) _tSBTBasedow = dr.GetBoolean("TSBTBasedow");
            if (dr.GetBoolean("TSBTViemtacTM") != null) _tSBTViemtacTM = dr.GetBoolean("TSBTViemtacTM");
            if (dr.GetBoolean("TSBTDongkinh") != null) _tSBTDongkinh = dr.GetBoolean("TSBTDongkinh");
            if (dr.GetBoolean("TSBTMoRuotthua") != null) _tSBTMoRuotthua = dr.GetBoolean("TSBTMoRuotthua");
            if (dr.GetBoolean("Diungthuoc") != null) _diungthuoc = dr.GetBoolean("Diungthuoc");
            if (dr.GetString("PTObung") != null) _pTObung = dr.GetString("PTObung");
            if (dr.GetString("TuoiCokinh") != null) _tuoiCokinh = dr.GetString("TuoiCokinh");
            if (dr.GetString("ChukyKinh") != null) _chukyKinh = dr.GetString("ChukyKinh");
            if (dr.GetString("SongayKinh") != null) _songayKinh = dr.GetString("SongayKinh");
            if (dr.GetString("TuoiLaychong") != null) _tuoiLaychong = dr.GetString("TuoiLaychong");
            if (dr.GetString("Benhphukhoa") != null) _benhphukhoa = dr.GetString("Benhphukhoa");
            if (dr.GetBoolean("KhoiUBT") != null) _khoiUBT = dr.GetBoolean("KhoiUBT");
            if (dr.GetBoolean("UxoTC") != null) _uxoTC = dr.GetBoolean("UxoTC");
            if (dr.GetBoolean("DidangSD") != null) _didangSD = dr.GetBoolean("DidangSD");
            if (dr.GetBoolean("SSD") != null) _sSD = dr.GetBoolean("SSD");
            if (dr.GetBoolean("TSM") != null) _tSM = dr.GetBoolean("TSM");
            if (dr.GetBoolean("DieuTriCTC") != null) _dieuTriCTC = dr.GetBoolean("DieuTriCTC");
            if (dr.GetBoolean("CatcutCTC") != null) _catcutCTC = dr.GetBoolean("CatcutCTC");
            if (dr.GetString("PhauthuatKhac") != null) _phauthuatKhac = dr.GetString("PhauthuatKhac");
            if (dr.GetString("PARA") != null) _pARA = dr.GetString("PARA");
            if (dr.GetString("TSBTKhac") != null) _tSBTKhac = dr.GetString("TSBTKhac");
            if (dr.GetByte("Solancothai") != null) _solancothai = dr.GetByte("Solancothai");
            if (dr.GetByte("Solansaythai") != null) _solansaythai = dr.GetByte("Solansaythai");
            if (dr.GetByte("Solannaothai") != null) _solannaothai = dr.GetByte("Solannaothai");
            if (dr.GetByte("Solande") != null) _solande = dr.GetByte("Solande");
            if (dr.GetString("Cachde") != null) _cachde = dr.GetString("Cachde");
            if (dr.GetByte("Soconsong") != null) _soconsong = dr.GetByte("Soconsong");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            _tennguoiSD = dr.GetString("TenNguoiSD");
            _cuthe = dr.GetString("cuthe");

            if (dr.NextResult())

                _ThongTinBN_TienSu_San_CList = ThongTinBN_TienSu_San_CList.GetThongTinBN_TienSu_San_CList(dr);
            MarkOld();
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maBN;
			public String MaBN 
			{
				get
				{
					return _maBN;
				}
			}
			
			public Criteria(String maBN)
			{
				_maBN = maBN;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBN.Equals(c._maBN)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBN.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maBN;
            public String MaBN
            {
                get
                {
                    return _maBN;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maBN)
            {
                _maBN = maBN;
               
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
		/// Retrieve an existing <see cref="ThongTinBN_TienSu_San" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetThongTinBN_TienSu_San(String _maBN);
			// public override IDataReader GetThongTinBN_TienSu_San(String _maBN)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spThongTinBN_TienSu_San_GET", _maBN));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetThongTinBN_TienSu_San(crit.MaBN)))
			{
				if (dr.Read()){
					Fetch(dr);
                    if (dr.NextResult())
                    {
                        _ThongTinBN_TienSu_San_CList = ThongTinBN_TienSu_San_CList.GetThongTinBN_TienSu_San_CList(dr);//////////////
                    }
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="ThongTinBN_TienSu_San" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
			if (dr.GetBoolean("TSGDSinhdoi") != null) _tSGDSinhdoi = dr.GetBoolean("TSGDSinhdoi");
			if (dr.GetBoolean("TSGDDidang") != null) _tSGDDidang = dr.GetBoolean("TSGDDidang");
			if (dr.GetBoolean("TSGDBenhditruyen") != null) _tSGDBenhditruyen = dr.GetBoolean("TSGDBenhditruyen");
			if (dr.GetBoolean("TSGDDaiduong") != null) _tSGDDaiduong = dr.GetBoolean("TSGDDaiduong");
			if (dr.GetBoolean("TSGDCaoHA") != null) _tSGDCaoHA = dr.GetBoolean("TSGDCaoHA");
			if (dr.GetString("TSGDKhac") != null) _tSGDKhac = dr.GetString("TSGDKhac");
			if (dr.GetBoolean("TSBTCaoHA") != null) _tSBTCaoHA = dr.GetBoolean("TSBTCaoHA");
			if (dr.GetBoolean("TSBTBenhTim") != null) _tSBTBenhTim = dr.GetBoolean("TSBTBenhTim");
			if (dr.GetBoolean("TSBTLaoPhoi") != null) _tSBTLaoPhoi = dr.GetBoolean("TSBTLaoPhoi");
			if (dr.GetBoolean("TSBTHenphequan") != null) _tSBTHenphequan = dr.GetBoolean("TSBTHenphequan");
			if (dr.GetBoolean("TSBTBenhthan") != null) _tSBTBenhthan = dr.GetBoolean("TSBTBenhthan");
			if (dr.GetBoolean("TSBTBasedow") != null) _tSBTBasedow = dr.GetBoolean("TSBTBasedow");
			if (dr.GetBoolean("TSBTViemtacTM") != null) _tSBTViemtacTM = dr.GetBoolean("TSBTViemtacTM");
			if (dr.GetBoolean("TSBTDongkinh") != null) _tSBTDongkinh = dr.GetBoolean("TSBTDongkinh");
			if (dr.GetBoolean("TSBTMoRuotthua") != null) _tSBTMoRuotthua = dr.GetBoolean("TSBTMoRuotthua");
            if (dr.GetBoolean("Diungthuoc") != null) _diungthuoc = dr.GetBoolean("Diungthuoc");
			if (dr.GetString("PTObung") != null) _pTObung = dr.GetString("PTObung");
			if (dr.GetString("TuoiCokinh") != null) _tuoiCokinh = dr.GetString("TuoiCokinh");
			if (dr.GetString("ChukyKinh") != null) _chukyKinh = dr.GetString("ChukyKinh");
			if (dr.GetString("SongayKinh") != null) _songayKinh = dr.GetString("SongayKinh");
			if (dr.GetString("TuoiLaychong") != null) _tuoiLaychong = dr.GetString("TuoiLaychong");
			if (dr.GetString("Benhphukhoa") != null) _benhphukhoa = dr.GetString("Benhphukhoa");
			if (dr.GetBoolean("KhoiUBT") != null) _khoiUBT = dr.GetBoolean("KhoiUBT");
			if (dr.GetBoolean("UxoTC") != null) _uxoTC = dr.GetBoolean("UxoTC");
			if (dr.GetBoolean("DidangSD") != null) _didangSD = dr.GetBoolean("DidangSD");
			if (dr.GetBoolean("SSD") != null) _sSD = dr.GetBoolean("SSD");
			if (dr.GetBoolean("TSM") != null) _tSM = dr.GetBoolean("TSM");
			if (dr.GetBoolean("DieuTriCTC") != null) _dieuTriCTC = dr.GetBoolean("DieuTriCTC");
			if (dr.GetBoolean("CatcutCTC") != null) _catcutCTC = dr.GetBoolean("CatcutCTC");
			if (dr.GetString("PhauthuatKhac") != null) _phauthuatKhac = dr.GetString("PhauthuatKhac");
			if (dr.GetString("PARA") != null) _pARA = dr.GetString("PARA");
			if (dr.GetString("TSBTKhac") != null) _tSBTKhac = dr.GetString("TSBTKhac");
			if (dr.GetByte("Solancothai") != null) _solancothai = dr.GetByte("Solancothai");
			if (dr.GetByte("Solansaythai") != null) _solansaythai = dr.GetByte("Solansaythai");
			if (dr.GetByte("Solannaothai") != null) _solannaothai = dr.GetByte("Solannaothai");
			if (dr.GetByte("Solande") != null) _solande = dr.GetByte("Solande");
			if (dr.GetString("Cachde") != null) _cachde = dr.GetString("Cachde");
			if (dr.GetByte("Soconsong") != null) _soconsong = dr.GetByte("Soconsong");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            _tennguoiSD = dr.GetString("TenNguoiSD");
            _cuthe = dr.GetString("cuthe");

		}
		
		/// <summary>
		/// Insert the new <see cref="ThongTinBN_TienSu_San" /> Object to underlying database.
		/// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            _ngaySD.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertThongTinBN_TienSu_San
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maBN = DataProvider.Instance().InsertThongTinBN_TienSu_San(_maBN, _tSGDSinhdoi, _tSGDDidang, _tSGDBenhditruyen, _tSGDDaiduong, _tSGDCaoHA, _tSGDKhac, _tSBTCaoHA, _tSBTBenhTim, _tSBTLaoPhoi, _tSBTHenphequan, _tSBTBenhthan, _tSBTBasedow, _tSBTViemtacTM, _tSBTDongkinh, _tSBTMoRuotthua,_diungthuoc, _pTObung, _tuoiCokinh, _chukyKinh, _songayKinh, _tuoiLaychong, _benhphukhoa, _khoiUBT, _uxoTC, _didangSD, _sSD, _tSM, _dieuTriCTC, _catcutCTC, _phauthuatKhac, _pARA, _tSBTKhac, _solancothai, _solansaythai,_solannaothai,_solande, _cachde, _soconsong, _maMay, _nguoiSD , _cuthe);
			// public abstract String InsertThongTinBN_TienSu_San(String _maBN, Boolean _tSGDSinhdoi, Boolean _tSGDDidang, Boolean _tSGDBenhditruyen, Boolean _tSGDDaiduong, Boolean _tSGDCaoHA, String _tSGDKhac, Boolean _tSBTCaoHA, Boolean _tSBTBenhTim, Boolean _tSBTLaoPhoi, Boolean _tSBTHenphequan, Boolean _tSBTBenhthan, Boolean _tSBTBasedow, Boolean _tSBTViemtacTM, Boolean _tSBTDongkinh, Boolean _tSBTMoRuotthua, String _diungthuoc, String _pTObung, String _tuoiCokinh, String _chukyKinh, String _songayKinh, String _tuoiLaychong, String _benhphukhoa, Boolean _khoiUBT, Boolean _uxoTC, Boolean _didangSD, Boolean _sSD, Boolean _tSM, Boolean _dieuTriCTC, Boolean _catcutCTC, String _phauthuatKhac, String _pARA, String _tSBTKhac, Byte _solancothai, Byte _solansaythai, Byte _solannaothai, Byte _solande, String _cachde, Byte _soconsong, String _maMay, String _nguoiSD);
			// public override String InsertThongTinBN_TienSu_San(String _maBN, Boolean _tSGDSinhdoi, Boolean _tSGDDidang, Boolean _tSGDBenhditruyen, Boolean _tSGDDaiduong, Boolean _tSGDCaoHA, String _tSGDKhac, Boolean _tSBTCaoHA, Boolean _tSBTBenhTim, Boolean _tSBTLaoPhoi, Boolean _tSBTHenphequan, Boolean _tSBTBenhthan, Boolean _tSBTBasedow, Boolean _tSBTViemtacTM, Boolean _tSBTDongkinh, Boolean _tSBTMoRuotthua, String _diungthuoc, String _pTObung, String _tuoiCokinh, String _chukyKinh, String _songayKinh, String _tuoiLaychong, String _benhphukhoa, Boolean _khoiUBT, Boolean _uxoTC, Boolean _didangSD, Boolean _sSD, Boolean _tSM, Boolean _dieuTriCTC, Boolean _catcutCTC, String _phauthuatKhac, String _pARA, String _tSBTKhac, Byte _solancothai, Byte _solansaythai, Byte _solannaothai, Byte _solande, String _cachde, Byte _soconsong, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spThongTinBN_TienSu_San_CREATE", _maBN, _tSGDSinhdoi, _tSGDDidang, _tSGDBenhditruyen, _tSGDDaiduong, _tSGDCaoHA, _tSGDKhac, _tSBTCaoHA, _tSBTBenhTim, _tSBTLaoPhoi, _tSBTHenphequan, _tSBTBenhthan, _tSBTBasedow, _tSBTViemtacTM, _tSBTDongkinh, _tSBTMoRuotthua, _diungthuoc, _pTObung, _tuoiCokinh, _chukyKinh, _songayKinh, _tuoiLaychong, _benhphukhoa, _khoiUBT, _uxoTC, _didangSD, _sSD, _tSM, _dieuTriCTC, _catcutCTC, _phauthuatKhac, _pARA, _tSBTKhac, _solancothai, _solansaythai, _solannaothai, _solande, _cachde, _soconsong, _maMay, _nguoiSD));
			// }
            if (IsDirty)
            _ThongTinBN_TienSu_San_CList.Update(this);
		}
		
		/// <summary>
		/// Update all changes made on <see cref="ThongTinBN_TienSu_San" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateThongTinBN_TienSu_San
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateThongTinBN_TienSu_San(_maBN, _tSGDSinhdoi, _tSGDDidang, _tSGDBenhditruyen, _tSGDDaiduong, _tSGDCaoHA, _tSGDKhac, _tSBTCaoHA, _tSBTBenhTim, _tSBTLaoPhoi, _tSBTHenphequan, _tSBTBenhthan, _tSBTBasedow, _tSBTViemtacTM, _tSBTDongkinh, _tSBTMoRuotthua, _diungthuoc, _pTObung, _tuoiCokinh, _chukyKinh, _songayKinh, _tuoiLaychong, _benhphukhoa, _khoiUBT, _uxoTC, _didangSD, _sSD, _tSM, _dieuTriCTC, _catcutCTC, _phauthuatKhac, _pARA, _tSBTKhac, _solancothai, _solansaythai, _solannaothai, _solande, _cachde, _soconsong, _maMay, _huy, _nguoiSD , _cuthe );
				// public abstract void UpdateThongTinBN_TienSu_San(String _maBN, Boolean _tSGDSinhdoi, Boolean _tSGDDidang, Boolean _tSGDBenhditruyen, Boolean _tSGDDaiduong, Boolean _tSGDCaoHA, String _tSGDKhac, Boolean _tSBTCaoHA, Boolean _tSBTBenhTim, Boolean _tSBTLaoPhoi, Boolean _tSBTHenphequan, Boolean _tSBTBenhthan, Boolean _tSBTBasedow, Boolean _tSBTViemtacTM, Boolean _tSBTDongkinh, Boolean _tSBTMoRuotthua, String _diungthuoc, String _pTObung, String _tuoiCokinh, String _chukyKinh, String _songayKinh, String _tuoiLaychong, String _benhphukhoa, Boolean _khoiUBT, Boolean _uxoTC, Boolean _didangSD, Boolean _sSD, Boolean _tSM, Boolean _dieuTriCTC, Boolean _catcutCTC, String _phauthuatKhac, String _pARA, String _tSBTKhac, Byte _solancothai, Byte _solansaythai, Byte _solannaothai, Byte _solande, String _cachde, Byte _soconsong, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateThongTinBN_TienSu_San(String _maBN, Boolean _tSGDSinhdoi, Boolean _tSGDDidang, Boolean _tSGDBenhditruyen, Boolean _tSGDDaiduong, Boolean _tSGDCaoHA, String _tSGDKhac, Boolean _tSBTCaoHA, Boolean _tSBTBenhTim, Boolean _tSBTLaoPhoi, Boolean _tSBTHenphequan, Boolean _tSBTBenhthan, Boolean _tSBTBasedow, Boolean _tSBTViemtacTM, Boolean _tSBTDongkinh, Boolean _tSBTMoRuotthua, String _diungthuoc, String _pTObung, String _tuoiCokinh, String _chukyKinh, String _songayKinh, String _tuoiLaychong, String _benhphukhoa, Boolean _khoiUBT, Boolean _uxoTC, Boolean _didangSD, Boolean _sSD, Boolean _tSM, Boolean _dieuTriCTC, Boolean _catcutCTC, String _phauthuatKhac, String _pARA, String _tSBTKhac, Byte _solancothai, Byte _solansaythai, Byte _solannaothai, Byte _solande, String _cachde, Byte _soconsong, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spThongTinBN_TienSu_San_UPDATE", _maBN, _tSGDSinhdoi, _tSGDDidang, _tSGDBenhditruyen, _tSGDDaiduong, _tSGDCaoHA, _tSGDKhac, _tSBTCaoHA, _tSBTBenhTim, _tSBTLaoPhoi, _tSBTHenphequan, _tSBTBenhthan, _tSBTBasedow, _tSBTViemtacTM, _tSBTDongkinh, _tSBTMoRuotthua, _diungthuoc, _pTObung, _tuoiCokinh, _chukyKinh, _songayKinh, _tuoiLaychong, _benhphukhoa, _khoiUBT, _uxoTC, _didangSD, _sSD, _tSM, _dieuTriCTC, _catcutCTC, _phauthuatKhac, _pARA, _tSBTKhac, _solancothai, _solansaythai, _solannaothai, _solande, _cachde, _soconsong, _maMay, _huy, _nguoiSD);
				// }	
                
                _ThongTinBN_TienSu_San_CList.Update(this);
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maBN));
		}

		/// <summary>
		/// Delete the <see cref="ThongTinBN_TienSu_San" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateThongTinBN_TienSu_San
            DataProvider.Instance().DeleteThongTinBN_TienSu_San(crit.MaMay, crit.NguoiSD, crit.MaBN);
			// public abstract void DeleteThongTinBN_TienSu_San(String _maBN);
			// public override void DeleteThongTinBN_TienSu_San(String _maBN);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spThongTinBN_TienSu_San_Deleted", _maBN);
			// }
		}

		#endregion
	}

}
