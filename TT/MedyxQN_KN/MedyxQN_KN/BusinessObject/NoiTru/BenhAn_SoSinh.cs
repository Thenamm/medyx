// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_SoSinh
// Kieu doi tuong  :	BenhAn_SoSinh
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	03/31/2010 2:13:47 PM
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
	/// This is a base generated class of <see cref="BenhAn_SoSinh" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_SoSinh : BusinessBase<BenhAn_SoSinh>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maBA = String.Empty;
		private Int32 _sTT = 0;
		private Int32 _sTTKhoa = 0;
		private SmartDate _ngayKham = new SmartDate(true);
        private SmartDate _ngayKhamD = new SmartDate(true);
		private String _bSKham = String.Empty;
		private String _lyDoKham = String.Empty;
		private String _meMach = String.Empty;
		private String _meDa = String.Empty;
        private String _benhSu = String.Empty;
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
        private String _meKieuOiVo = String.Empty;
		private String _meTieng = String.Empty;
        private String _meCachDe = String.Empty;
        private SmartDate _meGioDe = new SmartDate(true);
		private String _meLyDo = String.Empty;
		private String _meNguoiDoDe = String.Empty;
		private String _meApgar1 = String.Empty;
		private String _meApgar5 = String.Empty;
		private Boolean _hutDich = false;
        private Boolean _hutDichK = false;
		private Boolean _xoaBop = false;
        private Boolean _xoaBopK = false;
		private Boolean _tho = false;
        private Boolean _thoK = false;
		private Boolean _diTat = false;
        private Boolean _diTatK = false;
		private Boolean _datNoiKhiQuan = false;
		private Boolean _bopBong = false;
		private Boolean _diTathaumon = false;
        private Boolean _datNoiKhiQuanK = false;
        private Boolean _bopBongK = false;
        private Boolean _diTathaumonK = false;
		private String _cuThe = String.Empty;
		private String _nguoiChuyen = String.Empty;
		private String _nhipTim = String.Empty;
		private String _xuongKhop = String.Empty;
		private String _apHuyet = String.Empty;
		private String _nhietDo = String.Empty;
		private String _nhipTho = String.Empty;
		private String _canNang = String.Empty;
		private String _chieuCao = String.Empty;
		private Boolean _phu = false;
		private String _toanThan = String.Empty;
		private String _toanTrang = String.Empty;
		private String _vongDau = String.Empty;
		private String _vongNguc = String.Empty;
		private Byte _da = 0;
        private Boolean _daH = false;
        private Boolean _daX = false;
        private Boolean _daV = false;
        private Boolean _daT = false;
		private String _nghePhoi = String.Empty;
		private String _chiSoSilerman = String.Empty;
		private String _bung = String.Empty;
		private String _sinhDucNgoai = String.Empty;
		private String _phanXa = String.Empty;
		private String _truongLucCo = String.Empty;
		private String _boPhanKhac = String.Empty;
		private String _tuoiThai = String.Empty;
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
        private int _OrderNumber;

        private String _benhsu = String.Empty;
        private Int32 _hohapnhiptho = 0;
        private String _mabenhICD = String.Empty;
        //private SmartDate _methoigianvooi = new SmartDate(true);
        //private String _meapgar10 = String.Empty;
        //private Byte _loaitinhtrangkhisinh = 0;
        //private Boolean _hoisinhkhac = false;
        //private String _cannangvaokhoa = String.Empty;
        //private String _dienbien = String.Empty;
        //private Byte _vaovienngaythucuabenh = 0;
        //private String _CacXetNghiemCanLamSangCanLam = String.Empty;
        //private String _DinhDuongSauSinh = String.Empty;
        //private String _TinhHinhKhiVaoKhoa = String.Empty;
        //private String _TinhTrangToanThan = String.Empty;
        //private String _tomtat = String.Empty;
        //private Byte _CachDe = 0;
        //private Byte _lansinh = 0;
        //private Byte _soconsong = 0;
        //private String _noisinh = String.Empty;
        //private String _tinhtrangcon = String.Empty;
        //private String _nguoidode = String.Empty;
        //private String _phauthuat = String.Empty;





        #endregion

        #region Business Properties and Methods

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
        public string NgayKhamD
        {
            get
            {
                CanReadProperty("NgayKhamD", true);
                _ngayKhamD = _ngayKham;
                _ngayKhamD.FormatString = "dd/MM/yyyy HH:mm";

                return _ngayKhamD.Text;
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

        public String MeKieuOiVo
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
		
		public String MeCachDe
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
		
		public string MeGioDe
		{
			get 
			{
				CanReadProperty("MeGioDe", true);
                _meGioDe.FormatString = "dd/MM/yyyy HH:mm:ss";
				return _meGioDe.Text ;
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
		
		public String MeApgar1
		{
			get 
			{
				CanReadProperty("MeApgar1", true);
				return _meApgar1;
			}
			set 
			{
				CanWriteProperty("MeApgar1", true);
				if (_meApgar1 != value) 
				{
					_meApgar1 = value;
					PropertyHasChanged("MeApgar1");
				}
			}
		}
		
		public String MeApgar5
		{
			get 
			{
				CanReadProperty("MeApgar5", true);
				return _meApgar5;
			}
			set 
			{
				CanWriteProperty("MeApgar5", true);
				if (_meApgar5 != value) 
				{
					_meApgar5 = value;
					PropertyHasChanged("MeApgar5");
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
		public Boolean DiTat
		{
			get 
			{
				CanReadProperty("DiTat", true);
				return _diTat;
			}
			set 
			{
				CanWriteProperty("DiTat", true);
				if (_diTat != value) 
				{
					_diTat = value;
					PropertyHasChanged("DiTat");
				}
			}
		}
        public Boolean DiTatK
        {
            get
            {
                CanReadProperty("DiTatK", true);
                if (_diTat == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("DiTatK", true);
                if (_diTatK != value)
                {
                    if (value == true)
                        _diTat = false;
                    else
                        _diTat = true;
                    _diTatK = value;

                    PropertyHasChanged("DiTatK");
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
		
		public String NguoiChuyen
		{
			get 
			{
				CanReadProperty("NguoiChuyen", true);
				return _nguoiChuyen;
			}
			set 
			{
				CanWriteProperty("NguoiChuyen", true);
				if (_nguoiChuyen != value) 
				{
					_nguoiChuyen = value;
					PropertyHasChanged("NguoiChuyen");
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
		
		public String ToanThan
		{
			get 
			{
				CanReadProperty("ToanThan", true);
				return _toanThan;
			}
			set 
			{
				CanWriteProperty("ToanThan", true);
				if (_toanThan != value) 
				{
					_toanThan = value;
					PropertyHasChanged("ToanThan");
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
		
		public String VongDau
		{
			get 
			{
				CanReadProperty("VongDau", true);
				return _vongDau;
			}
			set 
			{
				CanWriteProperty("VongDau", true);
				if (_vongDau != value) 
				{
					_vongDau = value;
					PropertyHasChanged("VongDau");
				}
			}
		}
		
		public String VongNguc
		{
			get 
			{
				CanReadProperty("VongNguc", true);
				return _vongNguc;
			}
			set 
			{
				CanWriteProperty("VongNguc", true);
				if (_vongNguc != value) 
				{
					_vongNguc = value;
					PropertyHasChanged("VongNguc");
				}
			}
		}
   
		public Byte Da
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
        public Boolean DaH
        {
            get
            {
                CanReadProperty("DaH", true);

                if (_da == 0)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("DaH", true);

                if (_daH != value)
                {

                    _daH = value;

                }
                if (_daH == true)
                    _da = 0;
                PropertyHasChanged("DaH");

            }
        }
        public Boolean DaX
        {
            get
            {
                CanReadProperty("DaX", true);

                if (_da == 1)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("DaX", true);

                if (_daX != value)
                {

                    _daX = value;

                }
                if (_daX == true)
                    _da = 1;
                PropertyHasChanged("DaX");

            }
        }
        public Boolean DaV
        {
            get
            {
                CanReadProperty("DaV", true);

                if (_da == 2)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("DaV", true);

                if (_daV != value)
                {

                    _daV = value;

                }
                if (_daV == true)
                    _da = 2;
                PropertyHasChanged("DaV");

            }
        }
        public Boolean DaT
        {
            get
            {
                CanReadProperty("DaT", true);

                if (_da == 3)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("DaT", true);

                if (_daT != value)
                {

                    _daT = value;

                }
                if (_daT == true)
                    _da = 3;
                PropertyHasChanged("DaT");

            }
        }
		public String NghePhoi
		{
			get 
			{
				CanReadProperty("NghePhoi", true);
				return _nghePhoi;
			}
			set 
			{
				CanWriteProperty("NghePhoi", true);
				if (_nghePhoi != value) 
				{
					_nghePhoi = value;
					PropertyHasChanged("NghePhoi");
				}
			}
		}
		
		public String ChiSoSilerman
		{
			get 
			{
				CanReadProperty("ChiSoSilerman", true);
				return _chiSoSilerman;
			}
			set 
			{
				CanWriteProperty("ChiSoSilerman", true);
				if (_chiSoSilerman != value) 
				{
					_chiSoSilerman = value;
					PropertyHasChanged("ChiSoSilerman");
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
		
		public String SinhDucNgoai
		{
			get 
			{
				CanReadProperty("SinhDucNgoai", true);
				return _sinhDucNgoai;
			}
			set 
			{
				CanWriteProperty("SinhDucNgoai", true);
				if (_sinhDucNgoai != value) 
				{
					_sinhDucNgoai = value;
					PropertyHasChanged("SinhDucNgoai");
				}
			}
		}
		
		public String PhanXa
		{
			get 
			{
				CanReadProperty("PhanXa", true);
				return _phanXa;
			}
			set 
			{
				CanWriteProperty("PhanXa", true);
				if (_phanXa != value) 
				{
					_phanXa = value;
					PropertyHasChanged("PhanXa");
				}
			}
		}
		
		public String TruongLucCo
		{
			get 
			{
				CanReadProperty("TruongLucCo", true);
				return _truongLucCo;
			}
			set 
			{
				CanWriteProperty("TruongLucCo", true);
				if (_truongLucCo != value) 
				{
					_truongLucCo = value;
					PropertyHasChanged("TruongLucCo");
				}
			}
		}
		
		public String BoPhanKhac
		{
			get 
			{
				CanReadProperty("BoPhanKhac", true);
				return _boPhanKhac;
			}
			set 
			{
				CanWriteProperty("BoPhanKhac", true);
				if (_boPhanKhac != value) 
				{
					_boPhanKhac = value;
					PropertyHasChanged("BoPhanKhac");
				}
			}
		}
		
		public String TuoiThai
		{
			get 
			{
				CanReadProperty("TuoiThai", true);
				return _tuoiThai;
			}
			set 
			{
				CanWriteProperty("TuoiThai", true);
				if (_tuoiThai != value) 
				{
					_tuoiThai = value;
					PropertyHasChanged("TuoiThai");
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

        public String benhsu
        {
            get
            {
                CanReadProperty("benhsu", true);
                return _benhsu;
            }
            set
            {
                CanWriteProperty("benhsu", true);
                if (_benhsu != value)
                {
                    _benhsu = value;
                    PropertyHasChanged("benhsu");
                }
            }
        }

        public Int32 hohapnhiptho
        {
            get
            {
                CanReadProperty("hohapnhiptho", true);
                return _hohapnhiptho;
            }
            set
            {
                CanWriteProperty("hohapnhiptho", true);
                if (_hohapnhiptho != value)
                {
                    _hohapnhiptho = value;
                    PropertyHasChanged("hohapnhiptho");
                }
            }
        }

        public String mabenhICD
        {
            get
            {
                CanReadProperty("mabenhICD", true);
                return _mabenhICD;
            }
            set
            {
                CanWriteProperty("mabenhICD", true);
                if (_mabenhICD != value)
                {
                    _mabenhICD = value;
                    PropertyHasChanged("mabenhICD");
                }
            }
        }

        //public string Tinhtrangcon { get; set; }

        protected override Object GetIdValue()
		{
			return _maBA.ToString() + "!" + _sTT.ToString().ToString() + "!" + _sTTKhoa.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhAn_SoSinh" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BenhAn_SoSinh NewBenhAn_SoSinh()
        {
            return DataPortal.Create<BenhAn_SoSinh>();
        }
		public static BenhAn_SoSinh GetBenhAn_SoSinh(String maBA, Int32 sTT, Int32 sTTKhoa)
		{
			return DataPortal.Fetch<BenhAn_SoSinh>(new Criteria(maBA, sTT, sTTKhoa));
		}
		
		/// <summary>
		/// Marks the <see cref="BenhAn_SoSinh" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBenhAn_SoSinh(String maBA, Int32 sTT, Int32 sTTKhoa, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maBA, sTT, sTTKhoa));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BenhAn_SoSinh()
		{	
			// Prevent direct creation
		}
        internal BenhAn_SoSinh(
                        int OrderNumber,
                         String maBA ,
		             Int32 sTT ,
		             Int32 sTTKhoa ,
		             SmartDate ngayKham ,
		             String bSKham ,
		             String lyDoKham ,
                     string benhsu,
		             String meMach ,
		             String meDa ,
		             String meNiemMac ,
		             String meApHuyet ,
		             String meNhietDo ,
		             String meNhipTho ,
		             String meCanNang ,
		             String meChieuCao ,
		             Boolean mePhu ,
		             String meToanThan ,
		             String meToanTrang ,
		             String meCao ,
		             String meTim ,
		             String meGan ,
		             String mePhoi ,
		             String meThan ,
		             String meBenhKhac ,
                     String meKieuOiVo,
		             String meTieng ,
		             String meCachDe ,
                     SmartDate meGioDe,
		             String meLyDo ,
		             String meNguoiDoDe ,
		             String meApgar1 ,
		             String meApgar5 ,
		             Boolean hutDich ,
		             Boolean xoaBop ,
		             Boolean tho ,
		             Boolean diTat ,
		             Boolean datNoiKhiQuan ,
		             Boolean bopBong ,
		             Boolean diTathaumon ,
		             String cuThe ,
		             String nguoiChuyen ,
		             String mach ,
		             String niemMac ,
		             String apHuyet ,
		             String nhietDo ,
		             String nhipTho ,
		             String canNang ,
		             String chieuCao ,
		             Boolean phu ,
		             String toanThan ,
		             String toanTrang ,
		             String vongDau ,
		             String vongNguc ,
		             Byte da ,
		             String nghePhoi ,
		             String chiSoSilerman ,
		             String bung ,
		             String sinhDucNgoai ,
		             String phanXa ,
		             String truongLucCo ,
		             String boPhanKhac ,
		             String tuoiThai ,
		             String dieuTri ,
		             String chanDoan ,
		             String maMay ,
		             Boolean huy ,
		             SmartDate ngaySD ,
		             String nguoiSD ,
		             SmartDate ngaySD1 ,
		             String nguoiSD1 ,
                     String tenBSKham ,
                     String tennguoiSD
         )
        {
             _OrderNumber = OrderNumber ;
              _maBA = maBA;
		  _sTT = sTT;
        
		  _sTTKhoa = sTTKhoa;
		  _ngayKham = ngayKham;
		  _bSKham = bSKham;
		  _lyDoKham = lyDoKham ;
          _benhSu = benhsu;
		  _meMach = meMach ;
		  _meDa = meDa ;
		  _meNiemMac = meNiemMac ;
		  _meApHuyet = meApHuyet ;
		  _meNhietDo = meNhietDo ;
		  _meNhipTho = meNhipTho ;
		  _meCanNang = meCanNang ;
		  _meChieuCao = meChieuCao ;
		  _mePhu = mePhu ;
		  _meToanThan = meToanThan ;
		  _meToanTrang = meToanTrang ;
		  _meCao = meCao ;
		  _meTim = meTim ;
		  _meGan = meGan ;
		  _mePhoi = mePhoi ;
		  _meThan = meThan ;
		  _meNuocOi = meBenhKhac ;
		  _meKieuOiVo = meKieuOiVo ;
		  _meTieng = meTieng ;
		  _meCachDe = meCachDe ;
		  _meGioDe = meGioDe ;
		  _meLyDo = meLyDo ;
		  _meNguoiDoDe = meNguoiDoDe ;
		  _meApgar1 = meApgar1 ;
		  _meApgar5 = meApgar5 ;
		  _hutDich = hutDich ;
		  _xoaBop = xoaBop ;
		  _tho = tho ;
		  _diTat = diTat ;
		  _datNoiKhiQuan = datNoiKhiQuan ;
		  _bopBong = bopBong ;
		  _diTathaumon = diTathaumon ;
		  _cuThe = cuThe ;
		  _nguoiChuyen = nguoiChuyen ;
		  _nhipTim = mach ;
		  _xuongKhop = niemMac ;
		  _apHuyet = apHuyet ;
		  _nhietDo = nhietDo ;
		  _nhipTho = nhipTho ;
		  _canNang = canNang ;
		  _chieuCao = chieuCao ;
		  _phu = phu ;
		  _toanThan = toanThan ;
		  _toanTrang = toanTrang ;
		  _vongDau = vongDau ;
		  _vongNguc = vongNguc ;
		  _da = da ;
		  _nghePhoi = nghePhoi ;
		  _chiSoSilerman = chiSoSilerman ;
		  _bung = bung ;
		  _sinhDucNgoai = sinhDucNgoai ;
		  _phanXa = phanXa ;
		  _truongLucCo = truongLucCo ;
		  _boPhanKhac = boPhanKhac ;
		  _tuoiThai = tuoiThai ;
		  _dieuTri = dieuTri ;
		  _chanDoan = chanDoan ;
		  _maMay = maMay ;
		  _huy = huy ;
		  _ngaySD = ngaySD ;
		  _nguoiSD = nguoiSD ;
		  _ngaySD1 = ngaySD1 ;
		  _nguoiSD1 = nguoiSD1 ;
          _tenBSKham = tenBSKham ;
          _tennguoiSD = tennguoiSD ;
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
			
			private Int32 _sTTKhoa;
			public Int32 STTKhoa 
			{
				get
				{
					return _sTTKhoa;
				}
			}
			
			public Criteria(String maBA, Int32 sTT, Int32 sTTKhoa)
			{
				_maBA = maBA;
				_sTT = sTT;
				_sTTKhoa = sTTKhoa;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBA.Equals(c._maBA)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					if (!_sTTKhoa.Equals(c._sTTKhoa)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBA.ToString(), _sTT.ToString(), _sTTKhoa.ToString()).GetHashCode();
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
            public OtherCriteria(String Mamay, String Nguoisd, String maba, Int32 sTT, Int32 sTTKhoa)
            {
                _maBA = maba;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _sTT = sTT;
                _sTTKhoa = sTTKhoa;

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
		/// Retrieve an existing <see cref="BenhAn_SoSinh" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetBenhAn_SoSinh(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
			// public override IDataReader GetBenhAn_SoSinh(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_SoSinh_GET", _maBA, _sTT, _sTTKhoa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_SoSinh(crit.MaBA, crit.STT, crit.STTKhoa)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="BenhAn_SoSinh" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
			if (dr.GetSmartDate("NgayKham", true) != null) _ngayKham = dr.GetSmartDate("NgayKham", true);
			if (dr.GetString("BSKham") != null) _bSKham = dr.GetString("BSKham");
			if (dr.GetString("LyDoKham") != null) _lyDoKham = dr.GetString("LyDoKham");
            if (dr.GetString("BenhSu") != null) _benhSu = dr.GetString("BenhSu");
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
            if (dr.GetString("meNuocOi") != null) _meNuocOi = dr.GetString("meNuocOi");
            if (dr.GetString("MeKieuOiVo") != null) _meKieuOiVo = dr.GetString("MeKieuOiVo");
			if (dr.GetString("MeTieng") != null) _meTieng = dr.GetString("MeTieng");
            if (dr.GetString("MeCachDe") != null) _meCachDe = dr.GetString("MeCachDe");
            if (dr.GetSmartDate("MeGioDe", true) != null) _meGioDe = dr.GetSmartDate("MeGioDe", true);

			if (dr.GetString("MeLyDo") != null) _meLyDo = dr.GetString("MeLyDo");
			if (dr.GetString("MeNguoiDoDe") != null) _meNguoiDoDe = dr.GetString("MeNguoiDoDe");
			if (dr.GetString("MeApgar1") != null) _meApgar1 = dr.GetString("MeApgar1");
			if (dr.GetString("MeApgar5") != null) _meApgar5 = dr.GetString("MeApgar5");
			if (dr.GetBoolean("HutDich") != null) _hutDich = dr.GetBoolean("HutDich");
			if (dr.GetBoolean("XoaBop") != null) _xoaBop = dr.GetBoolean("XoaBop");
			if (dr.GetBoolean("Tho") != null) _tho = dr.GetBoolean("Tho");
			if (dr.GetBoolean("DiTat") != null) _diTat = dr.GetBoolean("DiTat");
			if (dr.GetBoolean("DatNoiKhiQuan") != null) _datNoiKhiQuan = dr.GetBoolean("DatNoiKhiQuan");
			if (dr.GetBoolean("BopBong") != null) _bopBong = dr.GetBoolean("BopBong");
			if (dr.GetBoolean("DiTathaumon") != null) _diTathaumon = dr.GetBoolean("DiTathaumon");
			if (dr.GetString("CuThe") != null) _cuThe = dr.GetString("CuThe");
			if (dr.GetString("NguoiChuyen") != null) _nguoiChuyen = dr.GetString("NguoiChuyen");
            if (dr.GetString("nhipTim") != null) _nhipTim = dr.GetString("nhipTim");
            if (dr.GetString("xuongKhop") != null) _xuongKhop = dr.GetString("xuongKhop");
			if (dr.GetString("ApHuyet") != null) _apHuyet = dr.GetString("ApHuyet");
			if (dr.GetString("NhietDo") != null) _nhietDo = dr.GetString("NhietDo");
			if (dr.GetString("NhipTho") != null) _nhipTho = dr.GetString("NhipTho");
			if (dr.GetString("CanNang") != null) _canNang = dr.GetString("CanNang");
			if (dr.GetString("ChieuCao") != null) _chieuCao = dr.GetString("ChieuCao");
			if (dr.GetBoolean("Phu") != null) _phu = dr.GetBoolean("Phu");
			if (dr.GetString("ToanThan") != null) _toanThan = dr.GetString("ToanThan");
			if (dr.GetString("ToanTrang") != null) _toanTrang = dr.GetString("ToanTrang");
			if (dr.GetString("VongDau") != null) _vongDau = dr.GetString("VongDau");
			if (dr.GetString("VongNguc") != null) _vongNguc = dr.GetString("VongNguc");
			if (dr.GetByte("Da") != null) _da = dr.GetByte("Da");
           
			if (dr.GetString("NghePhoi") != null) _nghePhoi = dr.GetString("NghePhoi");
			if (dr.GetString("ChiSoSilerman") != null) _chiSoSilerman = dr.GetString("ChiSoSilerman");
			if (dr.GetString("Bung") != null) _bung = dr.GetString("Bung");
			if (dr.GetString("SinhDucNgoai") != null) _sinhDucNgoai = dr.GetString("SinhDucNgoai");
			if (dr.GetString("PhanXa") != null) _phanXa = dr.GetString("PhanXa");
			if (dr.GetString("TruongLucCo") != null) _truongLucCo = dr.GetString("TruongLucCo");
			if (dr.GetString("BoPhanKhac") != null) _boPhanKhac = dr.GetString("BoPhanKhac");
			if (dr.GetString("TuoiThai") != null) _tuoiThai = dr.GetString("TuoiThai");
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
		}
		
		/// <summary>
		/// Insert the new <see cref="BenhAn_SoSinh" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_SoSinh
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maBA = DataProvider.Instance().InsertBenhAn_SoSinh(_maBA, _sTTKhoa, _ngayKham, _bSKham, _lyDoKham,_benhSu, _meMach, _meDa, _meNiemMac, _meApHuyet, _meNhietDo, _meNhipTho, _meCanNang, _meChieuCao, _mePhu, _meToanThan, _meToanTrang, _meCao, _meTim, _meGan, _mePhoi, _meThan, _meNuocOi, _meKieuOiVo, _meTieng, _meCachDe, _meGioDe, _meLyDo, _meNguoiDoDe, _meApgar1, _meApgar5, _hutDich, _xoaBop, _tho, _diTat, _datNoiKhiQuan, _bopBong, _diTathaumon, _cuThe, _nguoiChuyen, _nhipTim, _xuongKhop, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _toanThan, _toanTrang, _vongDau, _vongNguc, _da, _nghePhoi, _chiSoSilerman, _bung, _sinhDucNgoai, _phanXa, _truongLucCo, _boPhanKhac, _tuoiThai, _dieuTri, _chanDoan, _maMay, _nguoiSD);
			// public abstract String InsertBenhAn_SoSinh(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _meMach, String _meDa, String _meNiemMac, String _meApHuyet, String _meNhietDo, String _meNhipTho, String _meCanNang, String _meChieuCao, Boolean _mePhu, String _meToanThan, String _meToanTrang, String _meCao, String _meTim, String _meGan, String _mePhoi, String _meThan, String _meBenhKhac, Byte _meKieuOiVo, String _meTieng, Byte _meCachDe, Byte _meGioDe, String _meLyDo, String _meNguoiDoDe, String _meApgar1, String _meApgar5, Boolean _hutDich, Boolean _xoaBop, Boolean _tho, Boolean _diTat, Boolean _datNoiKhiQuan, Boolean _bopBong, Boolean _diTathaumon, String _cuThe, String _nguoiChuyen, String _nhipTim, String _niemMac, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _vongDau, String _vongNguc, Byte _da, String _nghePhoi, String _chiSoSilerman, String _bung, String _sinhDucNgoai, String _phanXa, String _truongLucCo, String _boPhanKhac, String _tuoiThai, String _dieuTri, String _chanDoan, String _maMay, String _nguoiSD);
			// public override String InsertBenhAn_SoSinh(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _meMach, String _meDa, String _meNiemMac, String _meApHuyet, String _meNhietDo, String _meNhipTho, String _meCanNang, String _meChieuCao, Boolean _mePhu, String _meToanThan, String _meToanTrang, String _meCao, String _meTim, String _meGan, String _mePhoi, String _meThan, String _meBenhKhac, Byte _meKieuOiVo, String _meTieng, Byte _meCachDe, Byte _meGioDe, String _meLyDo, String _meNguoiDoDe, String _meApgar1, String _meApgar5, Boolean _hutDich, Boolean _xoaBop, Boolean _tho, Boolean _diTat, Boolean _datNoiKhiQuan, Boolean _bopBong, Boolean _diTathaumon, String _cuThe, String _nguoiChuyen, String _mach, String _niemMac, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _vongDau, String _vongNguc, Byte _da, String _nghePhoi, String _chiSoSilerman, String _bung, String _sinhDucNgoai, String _phanXa, String _truongLucCo, String _boPhanKhac, String _tuoiThai, String _dieuTri, String _chanDoan, String _maMay, String _nguoiSD);
			// {
			//		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_SoSinh_CREATE", _maBA, _sTTKhoa, _ngayKham.DBValue, _bSKham, _lyDoKham, _meMach, _meDa, _meNiemMac, _meApHuyet, _meNhietDo, _meNhipTho, _meCanNang, _meChieuCao, _mePhu, _meToanThan, _meToanTrang, _meCao, _meTim, _meGan, _mePhoi, _meThan, _meBenhKhac, _meKieuOiVo, _meTieng, _meCachDe, _meGioDe, _meLyDo, _meNguoiDoDe, _meApgar1, _meApgar5, _hutDich, _xoaBop, _tho, _diTat, _datNoiKhiQuan, _bopBong, _diTathaumon, _cuThe, _nguoiChuyen, _mach, _niemMac, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _toanThan, _toanTrang, _vongDau, _vongNguc, _da, _nghePhoi, _chiSoSilerman, _bung, _sinhDucNgoai, _phanXa, _truongLucCo, _boPhanKhac, _tuoiThai, _dieuTri, _chanDoan, _maMay, _nguoiSD));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAn_SoSinh" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_SoSinh
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateBenhAn_SoSinh(_maBA, _sTT, _sTTKhoa, _ngayKham, _bSKham, _lyDoKham,_benhSu , _meMach, _meDa, _meNiemMac, _meApHuyet, _meNhietDo, _meNhipTho, _meCanNang, _meChieuCao, _mePhu, _meToanThan, _meToanTrang, _meCao, _meTim, _meGan, _mePhoi, _meThan, _meNuocOi, _meKieuOiVo, _meTieng, _meCachDe, _meGioDe, _meLyDo, _meNguoiDoDe, _meApgar1, _meApgar5, _hutDich, _xoaBop, _tho, _diTat, _datNoiKhiQuan, _bopBong, _diTathaumon, _cuThe, _nguoiChuyen, _nhipTim, _xuongKhop, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _toanThan, _toanTrang, _vongDau, _vongNguc, _da, _nghePhoi, _chiSoSilerman, _bung, _sinhDucNgoai, _phanXa, _truongLucCo, _boPhanKhac, _tuoiThai, _dieuTri, _chanDoan, _maMay,_huy, _nguoiSD);
                // public abstract void UpdateBenhAn_SoSinh(String _maBA,Int32 _sTT,  Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _meMach, String _meDa, String _meNiemMac, String _meApHuyet, String _meNhietDo, String _meNhipTho, String _meCanNang, String _meChieuCao, Boolean _mePhu, String _meToanThan, String _meToanTrang, String _meCao, String _meTim, String _meGan, String _mePhoi, String _meThan, String _meBenhKhac, Byte _meKieuOiVo, String _meTieng, Byte _meCachDe, Byte _meGioDe, String _meLyDo, String _meNguoiDoDe, String _meApgar1, String _meApgar5, Boolean _hutDich, Boolean _xoaBop, Boolean _tho, Boolean _diTat, Boolean _datNoiKhiQuan, Boolean _bopBong, Boolean _diTathaumon, String _cuThe, String _nguoiChuyen, String _nhipTim, String _niemMac, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _vongDau, String _vongNguc, Byte _da, String _nghePhoi, String _chiSoSilerman, String _bung, String _sinhDucNgoai, String _phanXa, String _truongLucCo, String _boPhanKhac, String _tuoiThai, String _dieuTri, String _chanDoan, String _maMay,Boolean _huy,  String _nguoiSD);
                // public override void UpdateBenhAn_SoSinh(String _maBA,Int32 _sTT,  Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _meMach, String _meDa, String _meNiemMac, String _meApHuyet, String _meNhietDo, String _meNhipTho, String _meCanNang, String _meChieuCao, Boolean _mePhu, String _meToanThan, String _meToanTrang, String _meCao, String _meTim, String _meGan, String _mePhoi, String _meThan, String _meBenhKhac, Byte _meKieuOiVo, String _meTieng, Byte _meCachDe, Byte _meGioDe, String _meLyDo, String _meNguoiDoDe, String _meApgar1, String _meApgar5, Boolean _hutDich, Boolean _xoaBop, Boolean _tho, Boolean _diTat, Boolean _datNoiKhiQuan, Boolean _bopBong, Boolean _diTathaumon, String _cuThe, String _nguoiChuyen, String _mach, String _niemMac, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _vongDau, String _vongNguc, Byte _da, String _nghePhoi, String _chiSoSilerman, String _bung, String _sinhDucNgoai, String _phanXa, String _truongLucCo, String _boPhanKhac, String _tuoiThai, String _dieuTri, String _chanDoan, String _maMay,Boolean _huy,  String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_SoSinh_UPDATE", _maBA,_sTT, _sTTKhoa, _ngayKham.DBValue, _bSKham, _lyDoKham, _meMach, _meDa, _meNiemMac, _meApHuyet, _meNhietDo, _meNhipTho, _meCanNang, _meChieuCao, _mePhu, _meToanThan, _meToanTrang, _meCao, _meTim, _meGan, _mePhoi, _meThan, _meBenhKhac, _meKieuOiVo, _meTieng, _meCachDe, _meGioDe, _meLyDo, _meNguoiDoDe, _meApgar1, _meApgar5, _hutDich, _xoaBop, _tho, _diTat, _datNoiKhiQuan, _bopBong, _diTathaumon, _cuThe, _nguoiChuyen, _mach, _niemMac, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _toanThan, _toanTrang, _vongDau, _vongNguc, _da, _nghePhoi, _chiSoSilerman, _bung, _sinhDucNgoai, _phanXa, _truongLucCo, _boPhanKhac, _tuoiThai, _dieuTri, _chanDoan, _maMay,_huy,  _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maBA, _sTT, _sTTKhoa));
		}

		/// <summary>
		/// Delete the <see cref="BenhAn_SoSinh" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_SoSinh
            DataProvider.Instance().DeleteBenhAn_SoSinh(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.STT, crit.STTKhoa);
			// public abstract void DeleteBenhAn_SoSinh(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
			// public override void DeleteBenhAn_SoSinh(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_SoSinh_Deleted", _maBA, _sTT, _sTTKhoa);
			// }
		}

		#endregion
	}

}
