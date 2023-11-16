// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_DY
// Kieu doi tuong  :	BenhAn_DY
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	7/8/2009 2:28:41 PM
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
	/// This is a base generated class of <see cref="BenhAn_DY" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_DY : BusinessBase<BenhAn_DY>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maBA = String.Empty;
		private Int32 _sTT = 0;
		private Int32 _sTTKhoa = 0;
		private SmartDate _ngayKham = new SmartDate(true);
        private SmartDate _ngayKhamD = new SmartDate(true);
		private String _bSKHAM = String.Empty;
        private String _HinhThai = String.Empty;
        private String _Than = String.Empty;
        private String _Sac = String.Empty;
        private String _Trach = String.Empty;
        private String _ChatLuoi = String.Empty;
        private String _Sacluoi = String.Empty;
        private String _ReuLuoi = String.Empty;
        private String _KhacVongChan = String.Empty;
        private String _MotaVongChan = String.Empty;
        private String _Giongnoi = String.Empty;
        private String _HoiTho = String.Empty;
        private Boolean _CoHo = false;
        private String _Ho = String.Empty;
        private Boolean _OAmThanh = false;
        private Boolean _NacAmThanh = false;
        private Boolean _CoMui = false;
        private String _KieuMui = String.Empty;
        private Boolean _CoChatThai = false;
        private String _KieuChatThai = String.Empty;
        private String _MoTaVanChan = String.Empty;
        private Byte _BHHanNhiet = 0;
        private String _MTBieuhien = String.Empty;
        private String _Thichnghi = String.Empty;
        private String _Mohoi = String.Empty;
        private Boolean _BHDauMat = false;
        private String _DauDau = String.Empty;
        private String _DauMat = String.Empty;
        private String _DauTai = String.Empty;
        private String _DauMui = String.Empty;
        private String _DauHong = String.Empty;
        private String _DauCoVai = String.Empty;
        private Boolean _BHLung = false;
        private String _Lung = String.Empty;
        private Boolean _BHBungNguc = false;
        private String _BungNguc = String.Empty;
        private Boolean _BHChanTay = false;
        private Boolean _BHAn = false;
        private String _An = String.Empty;
        private Boolean _BHUong = false;
        private String _Uong = String.Empty;
        private Boolean _BHDTT = false;
        private String _TieuTien = String.Empty;
        private String _DaiTien = String.Empty;
        private Boolean _BHNgu = false;
        private String _Ngu = String.Empty;
        private Boolean _BHKN = false;
        private String _RLKinhnguyet = String.Empty;
        private String _ThongKinh = String.Empty;
        private String _DoiHa = String.Empty;
        private Boolean _RLKNSinhDuc = false;
        private String _RLNam = String.Empty;
        private String _RLNu = String.Empty;
        private Boolean _DKXHBenh = false;
        private String _MTVaanChan = String.Empty;

      
        private String _XucChan_da = String.Empty;
        private String _XucChan_mohoi = String.Empty;
        private String _XucChan_coxuongkhop = String.Empty;
        private String _XucChan_bung = String.Empty;
        private String _MachChan = String.Empty;
        private String _TongKhanTrai = String.Empty;
        private String _TongKhanPhai = String.Empty;
        private String _ViKhanTraiThon = String.Empty;
        private String _ViKhanPhaiThon = String.Empty;
        private String _ViKhanTraiQuan = String.Empty;
        private String _ViKhanPhaiQuan = String.Empty;
        private String _ViKhanTraiXich = String.Empty;
        private String _ViKhanPhaiXich = String.Empty;
        private String _MTThietChan = String.Empty;
        private String _TomtatTuChan = String.Empty;
        private String _BienChungLieuTri = String.Empty;
        private String _BenhDanh = String.Empty;
        private String _Batcuong = String.Empty;
        private String _Tangphu = String.Empty;
        private String _KinhMach = String.Empty;
        private String _Nguyennhan = String.Empty;

        private String _BatcuongDT = String.Empty;
        private String _TangphuDT = String.Empty;
        private String _KinhMachDT = String.Empty;
        private String _NguyennhanDT = String.Empty;

        private String _DinhViBenhTheo = String.Empty;
      
        private String _ChanDoanRaVien = String.Empty;
        private String _Phapdieutri = String.Empty;
        private String _Phuongthuoc = String.Empty;
        private String _Phuonghuyet = String.Empty;
        private String _XoaBop = String.Empty;
        private String _Khac = String.Empty;
        private String _mabenhRaVien = String.Empty;
        private String _maBenhDT = String.Empty;
        private String _maBenhKKB = String.Empty;
        private String _maICDRaVien = String.Empty;
        private String _maICDDT = String.Empty;
        private String _maICDKKB = String.Empty;
        private String _ChanDoanDT = String.Empty;
        private String _ChanDoanKKB = String.Empty;
        private String _CheDoDinhDuong = String.Empty;
        private String _CheDoChamSoc = String.Empty;
        private String _TienLuong = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
        private String _tenBSKham = String.Empty;
        private String _tennguoiSD = String.Empty;
        private String _pPhapDieuTriYHCT = String.Empty;
        private String _pPhapDieuTriYHHD = String.Empty;
        private int _OrderNumber;

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
        public String PPDieuTriYHCT
        {
            get
            {
                CanReadProperty("PPDieuTriYHCT", true);
                return _pPhapDieuTriYHCT;
            }
            set
            {
                CanWriteProperty("PPDieuTriYHCT", true);
                if (_pPhapDieuTriYHCT != value)
                {
                    _pPhapDieuTriYHCT = value;
                    PropertyHasChanged("PPDieuTriYHCT");
                }
            }
        }
        public String PPDieuTriYHHD
        {
            get
            {
                CanReadProperty("PPDieuTriYHHD", true);
                return _pPhapDieuTriYHHD;
            }
            set
            {
                CanWriteProperty("PPDieuTriYHHD", true);
                if (_pPhapDieuTriYHHD != value)
                {
                    _pPhapDieuTriYHHD = value;
                    PropertyHasChanged("PPDieuTriYHHD");
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
		public String BSKHAM
		{
			get 
			{
				CanReadProperty("BSKHAM", true);
				return _bSKHAM;
			}
			set 
			{
				CanWriteProperty("BSKHAM", true);
				if (_bSKHAM != value) 
				{
					_bSKHAM = value;
					PropertyHasChanged("BSKHAM");
				}
			}
		}

        public String HinhThai
        {
            get
            {
                CanReadProperty("HinhThai", true);
                return _HinhThai;
            }
            set
            {
                CanWriteProperty("HinhThai", true);
                if (_HinhThai != value)
                {
                    _HinhThai = value;
                    PropertyHasChanged("HinhThai");
                }
            }
        }
        public String Than
        {
            get
            {
                CanReadProperty("Than", true);
                return _Than;
            }
            set
            {
                CanWriteProperty("Than", true);
                if (_Than != value)
                {
                    _Than = value;
                    PropertyHasChanged("Than");
                }
            }
        }
        public String Sac
        {
            get
            {
                CanReadProperty("Sac", true);
                return _Sac;
            }
            set
            {
                CanWriteProperty("Sac", true);
                if (_Sac != value)
                {
                    _Sac = value;
                    PropertyHasChanged("Sac");
                }
            }
        }
        public String Trach
        {
            get
            {
                CanReadProperty("Trach", true);
                return _Trach;
            }
            set
            {
                CanWriteProperty("Trach", true);
                if (_Trach != value)
                {
                    _Trach = value;
                    PropertyHasChanged("Trach");
                }
            }
        }
        public String ChatLuoi
        {
            get
            {
                CanReadProperty("ChatLuoi", true);
                return _ChatLuoi;
            }
            set
            {
                CanWriteProperty("ChatLuoi", true);
                if (_ChatLuoi != value)
                {
                    _ChatLuoi = value;
                    PropertyHasChanged("ChatLuoi");
                }
            }
        }
        public String Sacluoi
        {
            get
            {
                CanReadProperty("Sacluoi", true);
                return _Sacluoi;
            }
            set
            {
                CanWriteProperty("Sacluoi", true);
                if (_Sacluoi != value)
                {
                    _Sacluoi = value;
                    PropertyHasChanged("Sacluoi");
                }
            }
        }
        public String ReuLuoi
        {
            get
            {
                CanReadProperty("ReuLuoi", true);
                return _ReuLuoi;
            }
            set
            {
                CanWriteProperty("ReuLuoi", true);
                if (_ReuLuoi != value)
                {
                    _ReuLuoi = value;
                    PropertyHasChanged("ReuLuoi");
                }
            }
        }
        public String KhacVongChan
        {
            get
            {
                CanReadProperty("KhacVongChan", true);
                return _KhacVongChan;
            }
            set
            {
                CanWriteProperty("KhacVongChan", true);
                if (_KhacVongChan != value)
                {
                    _KhacVongChan = value;
                    PropertyHasChanged("KhacVongChan");
                }
            }
        }
        public String MotaVongChan
        {
            get
            {
                CanReadProperty("MotaVongChan", true);
                return _MotaVongChan;
            }
            set
            {
                CanWriteProperty("MotaVongChan", true);
                if (_MotaVongChan != value)
                {
                    _MotaVongChan = value;
                    PropertyHasChanged("MotaVongChan");
                }
            }
        }
        public String Giongnoi
        {
            get
            {
                CanReadProperty("Giongnoi", true);
                return _Giongnoi;
            }
            set
            {
                CanWriteProperty("Giongnoi", true);
                if (_Giongnoi != value)
                {
                    _Giongnoi = value;
                    PropertyHasChanged("Giongnoi");
                }
            }
        }
        public String HoiTho
        {
            get
            {
                CanReadProperty("HoiTho", true);
                return _HoiTho;
            }
            set
            {
                CanWriteProperty("HoiTho", true);
                if (_HoiTho != value)
                {
                    _HoiTho = value;
                    PropertyHasChanged("HoiTho");
                }
            }
        }
        public Boolean CoHo
        {
            get
            {
                CanReadProperty("CoHo", true);
                return _CoHo;
            }
            set
            {
                CanWriteProperty("CoHo", true);
                if (_CoHo != value)
                {
                    _CoHo = value;
                    PropertyHasChanged("CoHo");
                }
            }
        }
        public String Ho
        {
            get
            {
                CanReadProperty("Ho", true);
                return _Ho;
            }
            set
            {
                CanWriteProperty("Ho", true);
                if (_Ho != value)
                {
                    _Ho = value;
                    PropertyHasChanged("Ho");
                }
            }
        }
        public Boolean OAmThanh
        {
            get
            {
                CanReadProperty("OAmThanh", true);
                return _OAmThanh;
            }
            set
            {
                CanWriteProperty("OAmThanh", true);
                if (_OAmThanh != value)
                {
                    _OAmThanh = value;
                    PropertyHasChanged("OAmThanh");
                }
            }
        }
        public Boolean NacAmThanh
        {
            get
            {
                CanReadProperty("NacAmThanh", true);
                return _NacAmThanh;
            }
            set
            {
                CanWriteProperty("NacAmThanh", true);
                if (_NacAmThanh != value)
                {
                    _NacAmThanh = value;
                    PropertyHasChanged("NacAmThanh");
                }
            }
        }
        public Boolean CoMui
        {
            get
            {
                CanReadProperty("CoMui", true);
                return _CoMui;
            }
            set
            {
                CanWriteProperty("CoMui", true);
                if (_CoMui != value)
                {
                    _CoMui = value;
                    PropertyHasChanged("CoMui");
                }
            }
        }
        public String KieuMui
        {
            get
            {
                CanReadProperty("KieuMui", true);
                return _KieuMui;
            }
            set
            {
                CanWriteProperty("KieuMui", true);
                if (_KieuMui != value)
                {
                    _KieuMui = value;
                    PropertyHasChanged("KieuMui");
                }
            }
        }
        public Boolean CoChatThai
        {
            get
            {
                CanReadProperty("CoChatThai", true);
                return _CoChatThai;
            }
            set
            {
                CanWriteProperty("CoChatThai", true);
                if (_CoChatThai != value)
                {
                    _CoChatThai = value;
                    PropertyHasChanged("CoChatThai");
                }
            }
        }
        public String KieuChatThai
        {
            get
            {
                CanReadProperty("KieuChatThai", true);
                return _KieuChatThai;
            }
            set
            {
                CanWriteProperty("KieuChatThai", true);
                if (_KieuChatThai != value)
                {
                    _KieuChatThai = value;
                    PropertyHasChanged("KieuChatThai");
                }
            }
        }
        public String MoTaVanChan
        {
            get
            {
                CanReadProperty("MoTaVanChan", true);
                return _MoTaVanChan;
            }
            set
            {
                CanWriteProperty("MoTaVanChan", true);
                if (_MoTaVanChan != value)
                {
                    _MoTaVanChan = value;
                    PropertyHasChanged("MoTaVanChan");
                }
            }
        }
        public byte  BHHanNhiet
        {
            get
            {
                CanReadProperty("BHHanNhiet", true);
                return _BHHanNhiet;
            }
            set
            {
                CanWriteProperty("BHHanNhiet", true);
                if (_BHHanNhiet != value)
                {
                    _BHHanNhiet = value;
                    PropertyHasChanged("BHHanNhiet");
                }
            }
        }

        public String MTBieuhien
        {
            get
            {
                CanReadProperty("MTBieuhien", true);
                return _MTBieuhien;
            }
            set
            {
                CanWriteProperty("MTBieuhien", true);
                if (_MTBieuhien != value)
                {
                    _MTBieuhien = value;
                    PropertyHasChanged("MTBieuhien");
                }
            }
        }
        public String Thichnghi
        {
            get
            {
                CanReadProperty("Thichnghi", true);
                return _Thichnghi;
            }
            set
            {
                CanWriteProperty("Thichnghi", true);
                if (_Thichnghi != value)
                {
                    _Thichnghi = value;
                    PropertyHasChanged("Thichnghi");
                }
            }
        }
        public String Mohoi
        {
            get
            {
                CanReadProperty("Mohoi", true);
                return _Mohoi;
            }
            set
            {
                CanWriteProperty("Mohoi", true);
                if (_Mohoi != value)
                {
                    _Mohoi = value;
                    PropertyHasChanged("Mohoi");
                }
            }
        }

        public Boolean BHDauMat
        {
            get
            {
                CanReadProperty("BHDauMat", true);
                return _BHDauMat;
            }
            set
            {
                CanWriteProperty("BHDauMat", true);
                if (_BHDauMat != value)
                {
                    _BHDauMat = value;
                    PropertyHasChanged("BHDauMat");
                }
            }
        }
        public String DauDau
        {
            get
            {
                CanReadProperty("DauDau", true);
                return _DauDau;
            }
            set
            {
                CanWriteProperty("DauDau", true);
                if (_DauDau != value)
                {
                    _DauDau = value;
                    PropertyHasChanged("DauDau");
                }
            }
        }
        public String DauMat
        {
            get
            {
                CanReadProperty("DauMat", true);
                return _DauMat;
            }
            set
            {
                CanWriteProperty("DauMat", true);
                if (_DauMat != value)
                {
                    _DauMat = value;
                    PropertyHasChanged("DauMat");
                }
            }
        }
        public String DauTai
        {
            get
            {
                CanReadProperty("DauTai", true);
                return _DauTai;
            }
            set
            {
                CanWriteProperty("DauTai", true);
                if (_DauTai != value)
                {
                    _DauTai = value;
                    PropertyHasChanged("DauTai");
                }
            }
        }
        public String DauMui
        {
            get
            {
                CanReadProperty("DauMui", true);
                return _DauMui;
            }
            set
            {
                CanWriteProperty("DauMui", true);
                if (_DauMui != value)
                {
                    _DauMui = value;
                    PropertyHasChanged("DauMui");
                }
            }
        }
        public String DauHong
        {
            get
            {
                CanReadProperty("DauHong", true);
                return _DauHong;
            }
            set
            {
                CanWriteProperty("DauHong", true);
                if (_DauHong != value)
                {
                    _DauHong = value;
                    PropertyHasChanged("DauHong");
                }
            }
        }
        public String DauCoVai
        {
            get
            {
                CanReadProperty("DauCoVai", true);
                return _DauCoVai;
            }
            set
            {
                CanWriteProperty("DauCoVai", true);
                if (_DauCoVai != value)
                {
                    _DauCoVai = value;
                    PropertyHasChanged("DauCoVai");
                }
            }
        }

        public Boolean BHLung
        {
            get
            {
                CanReadProperty("BHLung", true);
                return _BHLung;
            }
            set
            {
                CanWriteProperty("BHLung", true);
                if (_BHLung != value)
                {
                    _BHLung = value;
                    PropertyHasChanged("BHLung");
                }
            }
        }
        public String Lung
        {
            get
            {
                CanReadProperty("Lung", true);
                return _Lung;
            }
            set
            {
                CanWriteProperty("Lung", true);
                if (_Lung != value)
                {
                    _Lung = value;
                    PropertyHasChanged("Lung");
                }
            }
        }
        public Boolean BHBungNguc
        {
            get
            {
                CanReadProperty("BHBungNguc", true);
                return _BHBungNguc;
            }
            set
            {
                CanWriteProperty("BHBungNguc", true);
                if (_BHBungNguc != value)
                {
                    _BHBungNguc = value;
                    PropertyHasChanged("BHBungNguc");
                }
            }
        }
        public String BungNguc
        {
            get
            {
                CanReadProperty("BungNguc", true);
                return _BungNguc;
            }
            set
            {
                CanWriteProperty("BungNguc", true);
                if (_BungNguc != value)
                {
                    _BungNguc = value;
                    PropertyHasChanged("BungNguc");
                }
            }
        }
        public Boolean BHChanTay
        {
            get
            {
                CanReadProperty("BHChanTay", true);
                return _BHChanTay;
            }
            set
            {
                CanWriteProperty("BHChanTay", true);
                if (_BHChanTay != value)
                {
                    _BHChanTay = value;
                    PropertyHasChanged("BHChanTay");
                }
            }
        }
        public Boolean BHAn
        {
            get
            {
                CanReadProperty("BHAn", true);
                return _BHAn;
            }
            set
            {
                CanWriteProperty("BHAn", true);
                if (_BHAn != value)
                {
                    _BHAn = value;
                    PropertyHasChanged("BHAn");
                }
            }
        }
        public String An
        {
            get
            {
                CanReadProperty("An", true);
                return _An;
            }
            set
            {
                CanWriteProperty("An", true);
                if (_An != value)
                {
                    _An = value;
                    PropertyHasChanged("An");
                }
            }
        }
        public Boolean BHUong
        {
            get
            {
                CanReadProperty("BHUong", true);
                return _BHUong;
            }
            set
            {
                CanWriteProperty("BHUong", true);
                if (_BHUong != value)
                {
                    _BHUong = value;
                    PropertyHasChanged("BHUong");
                }
            }
        }
        public String Uong
        {
            get
            {
                CanReadProperty("Uong", true);
                return _Uong;
            }
            set
            {
                CanWriteProperty("Uong", true);
                if (_Uong != value)
                {
                    _Uong = value;
                    PropertyHasChanged("Uong");
                }
            }
        }
        public Boolean BHDTT
        {
            get
            {
                CanReadProperty("BHDTT", true);
                return _BHDTT;
            }
            set
            {
                CanWriteProperty("BHDTT", true);
                if (_BHDTT != value)
                {
                    _BHDTT = value;
                    PropertyHasChanged("BHDTT");
                }
            }
        }
        public String DaiTien
        {
            get
            {
                CanReadProperty("DaiTien", true);
                return _DaiTien;
            }
            set
            {
                CanWriteProperty("DaiTien", true);
                if (_DaiTien != value)
                {
                    _DaiTien = value;
                    PropertyHasChanged("DaiTien");
                }
            }
        }
        public String TieuTien
        {
            get
            {
                CanReadProperty("TieuTien", true);
                return _TieuTien;
            }
            set
            {
                CanWriteProperty("TieuTien", true);
                if (_TieuTien != value)
                {
                    _TieuTien = value;
                    PropertyHasChanged("TieuTien");
                }
            }
        }
        public Boolean BHNgu
        {
            get
            {
                CanReadProperty("BHNgu", true);
                return _BHNgu;
            }
            set
            {
                CanWriteProperty("BHNgu", true);
                if (_BHNgu != value)
                {
                    _BHNgu = value;
                    PropertyHasChanged("BHNgu");
                }
            }
        }
        public String Ngu
        {
            get
            {
                CanReadProperty("Ngu", true);
                return _Ngu;
            }
            set
            {
                CanWriteProperty("Ngu", true);
                if (_Ngu != value)
                {
                    _Ngu = value;
                    PropertyHasChanged("Ngu");
                }
            }
        }
        public Boolean BHKN
        {
            get
            {
                CanReadProperty("BHKN", true);
                return _BHKN;
            }
            set
            {
                CanWriteProperty("BHKN", true);
                if (_BHKN != value)
                {
                    _BHKN = value;
                    PropertyHasChanged("BHKN");
                }
            }
        }
        public String RLKinhnguyet
        {
            get
            {
                CanReadProperty("RLKinhnguyet", true);
                return _RLKinhnguyet;
            }
            set
            {
                CanWriteProperty("RLKinhnguyet", true);
                if (_RLKinhnguyet != value)
                {
                    _RLKinhnguyet = value;
                    PropertyHasChanged("RLKinhnguyet");
                }
            }
        }
        public String ThongKinh
        {
            get
            {
                CanReadProperty("ThongKinh", true);
                return _ThongKinh;
            }
            set
            {
                CanWriteProperty("ThongKinh", true);
                if (_ThongKinh != value)
                {
                    _ThongKinh = value;
                    PropertyHasChanged("ThongKinh");
                }
            }
        }
        public String DoiHa
        {
            get
            {
                CanReadProperty("DoiHa", true);
                return _DoiHa;
            }
            set
            {
                CanWriteProperty("DoiHa", true);
                if (_DoiHa != value)
                {
                    _DoiHa = value;
                    PropertyHasChanged("DoiHa");
                }
            }
        }
        public Boolean RLKNSinhDuc
        {
            get
            {
                CanReadProperty("RLKNSinhDuc", true);
                return _RLKNSinhDuc;
            }
            set
            {
                CanWriteProperty("RLKNSinhDuc", true);
                if (_RLKNSinhDuc != value)
                {
                    _RLKNSinhDuc = value;
                    PropertyHasChanged("RLKNSinhDuc");
                }
            }
        }
        public String RLNam
        {
            get
            {
                CanReadProperty("RLNam", true);
                return _RLNam;
            }
            set
            {
                CanWriteProperty("RLNam", true);
                if (_RLNam != value)
                {
                    _RLNam = value;
                    PropertyHasChanged("RLNam");
                }
            }
        }
        public String RLNu
        {
            get
            {
                CanReadProperty("RLNu", true);
                return _RLNu;
            }
            set
            {
                CanWriteProperty("RLNu", true);
                if (_RLNu != value)
                {
                    _RLNu = value;
                    PropertyHasChanged("RLNu");
                }
            }
        }
        public Boolean DKXHBenh
        {
            get
            {
                CanReadProperty("DKXHBenh", true);
                return _DKXHBenh;
            }
            set
            {
                CanWriteProperty("DKXHBenh", true);
                if (_DKXHBenh != value)
                {
                    _DKXHBenh = value;
                    PropertyHasChanged("DKXHBenh");
                }
            }
        }
        public String MTVaanChan
        {
            get
            {
                CanReadProperty("MTVaanChan", true);
                return _MTVaanChan;
            }
            set
            {
                CanWriteProperty("MTVaanChan", true);
                if (_MTVaanChan != value)
                {
                    _MTVaanChan = value;
                    PropertyHasChanged("MTVaanChan");
                }
            }
        }

        public String XucChan_da
        {
            get
            {
                CanReadProperty("XucChan_da", true);
                return _XucChan_da;
            }
            set
            {
                CanWriteProperty("XucChan_da", true);
                if (_XucChan_da != value)
                {
                    _XucChan_da = value;
                    PropertyHasChanged("XucChan_da");
                }
            }
        }
        public String XucChan_mohoi
        {
            get
            {
                CanReadProperty("XucChan_mohoi", true);
                return _XucChan_mohoi;
            }
            set
            {
                CanWriteProperty("XucChan_mohoi", true);
                if (_XucChan_mohoi != value)
                {
                    _XucChan_mohoi = value;
                    PropertyHasChanged("XucChan_mohoi");
                }
            }
        }
        public String XucChan_coxuongkhop
        {
            get
            {
                CanReadProperty("XucChan_coxuongkhop", true);
                return _XucChan_coxuongkhop;
            }
            set
            {
                CanWriteProperty("XucChan_coxuongkhop", true);
                if (_XucChan_coxuongkhop != value)
                {
                    _XucChan_coxuongkhop = value;
                    PropertyHasChanged("XucChan_coxuongkhop");
                }
            }
        }
        public String XucChan_bung
        {
            get
            {
                CanReadProperty("XucChan_bung", true);
                return _XucChan_bung;
            }
            set
            {
                CanWriteProperty("XucChan_bung", true);
                if (_XucChan_bung != value)
                {
                    _XucChan_bung = value;
                    PropertyHasChanged("XucChan_bung");
                }
            }
        }
        public String MachChan
        {
            get
            {
                CanReadProperty("MachChan", true);
                return _MachChan;
            }
            set
            {
                CanWriteProperty("MachChan", true);
                if (_MachChan != value)
                {
                    _MachChan = value;
                    PropertyHasChanged("MachChan");
                }
            }
        }
        public String TongKhanTrai
        {
            get
            {
                CanReadProperty("TongKhanTrai", true);
                return _TongKhanTrai;
            }
            set
            {
                CanWriteProperty("TongKhanTrai", true);
                if (_TongKhanTrai != value)
                {
                    _TongKhanTrai = value;
                    PropertyHasChanged("TongKhanTrai");
                }
            }
        }
        public String TongKhanPhai
        {
            get
            {
                CanReadProperty("TongKhanPhai", true);
                return _TongKhanPhai;
            }
            set
            {
                CanWriteProperty("TongKhanPhai", true);
                if (_TongKhanPhai != value)
                {
                    _TongKhanPhai = value;
                    PropertyHasChanged("TongKhanPhai");
                }
            }
        }
        public String ViKhanTraiThon
        {
            get
            {
                CanReadProperty("ViKhanTraiThon", true);
                return _ViKhanTraiThon;
            }
            set
            {
                CanWriteProperty("ViKhanTraiThon", true);
                if (_ViKhanTraiThon != value)
                {
                    _ViKhanTraiThon = value;
                    PropertyHasChanged("ViKhanTraiThon");
                }
            }
        }
        public String ViKhanPhaiThon
        {
            get
            {
                CanReadProperty("ViKhanPhaiThon", true);
                return _ViKhanPhaiThon;
            }
            set
            {
                CanWriteProperty("ViKhanPhaiThon", true);
                if (_ViKhanPhaiThon != value)
                {
                    _ViKhanPhaiThon = value;
                    PropertyHasChanged("ViKhanPhaiThon");
                }
            }
        }
        public String ViKhanTraiQuan
        {
            get
            {
                CanReadProperty("ViKhanTraiQuan", true);
                return _ViKhanTraiQuan;
            }
            set
            {
                CanWriteProperty("ViKhanTraiQuan", true);
                if (_ViKhanTraiQuan != value)
                {
                    _ViKhanTraiQuan = value;
                    PropertyHasChanged("ViKhanTraiQuan");
                }
            }
        }
        public String ViKhanPhaiQuan
        {
            get
            {
                CanReadProperty("ViKhanPhaiQuan", true);
                return _ViKhanPhaiQuan;
            }
            set
            {
                CanWriteProperty("ViKhanPhaiQuan", true);
                if (_ViKhanPhaiQuan != value)
                {
                    _ViKhanPhaiQuan = value;
                    PropertyHasChanged("ViKhanPhaiQuan");
                }
            }
        }
        public String ViKhanTraiXich
        {
            get
            {
                CanReadProperty("ViKhanTraiXich", true);
                return _ViKhanTraiXich;
            }
            set
            {
                CanWriteProperty("ViKhanTraiXich", true);
                if (_ViKhanTraiXich != value)
                {
                    _ViKhanTraiXich = value;
                    PropertyHasChanged("ViKhanTraiXich");
                }
            }
        }
        public String ViKhanPhaiXich
        {
            get
            {
                CanReadProperty("ViKhanPhaiXich", true);
                return _ViKhanPhaiXich;
            }
            set
            {
                CanWriteProperty("ViKhanPhaiXich", true);
                if (_ViKhanPhaiXich != value)
                {
                    _ViKhanPhaiXich = value;
                    PropertyHasChanged("ViKhanPhaiXich");
                }
            }
        }
        public String MTThietChan
        {
            get
            {
                CanReadProperty("MTThietChan", true);
                return _MTThietChan;
            }
            set
            {
                CanWriteProperty("MTThietChan", true);
                if (_MTThietChan != value)
                {
                    _MTThietChan = value;
                    PropertyHasChanged("MTThietChan");
                }
            }
        }
        public String TomtatTuChan
        {
            get
            {
                CanReadProperty("TomtatTuChan", true);
                return _TomtatTuChan;
            }
            set
            {
                CanWriteProperty("TomtatTuChan", true);
                if (_TomtatTuChan != value)
                {
                    _TomtatTuChan = value;
                    PropertyHasChanged("TomtatTuChan");
                }
            }
        }
        public String BienChungLieuTri
        {
            get
            {
                CanReadProperty("BienChungLieuTri", true);
                return _BienChungLieuTri;
            }
            set
            {
                CanWriteProperty("BienChungLieuTri", true);
                if (_BienChungLieuTri != value)
                {
                    _BienChungLieuTri = value;
                    PropertyHasChanged("BienChungLieuTri");
                }
            }
        }
        public String BenhDanh
        {
            get
            {
                CanReadProperty("BenhDanh", true);
                return _BenhDanh;
            }
            set
            {
                CanWriteProperty("BenhDanh", true);
                if (_BenhDanh != value)
                {
                    _BenhDanh = value;
                    PropertyHasChanged("BenhDanh");
                }
            }
        }
        public String Batcuong
        {
            get
            {
                CanReadProperty("Batcuong", true);
                return _Batcuong;
            }
            set
            {
                CanWriteProperty("Batcuong", true);
                if (_Batcuong != value)
                {
                    _Batcuong = value;
                    PropertyHasChanged("Batcuong");
                }
            }
        }
        public String Tangphu
        {
            get
            {
                CanReadProperty("Tangphu", true);
                return _Tangphu;
            }
            set
            {
                CanWriteProperty("Tangphu", true);
                if (_Tangphu != value)
                {
                    _Tangphu = value;
                    PropertyHasChanged("Tangphu");
                }
            }
        }
        public String KinhMach
        {
            get
            {
                CanReadProperty("KinhMach", true);
                return _KinhMach;
            }
            set
            {
                CanWriteProperty("KinhMach", true);
                if (_KinhMach != value)
                {
                    _KinhMach = value;
                    PropertyHasChanged("KinhMach");
                }
            }
        }

     
        public String BatcuongDT
        {
            get
            {
                CanReadProperty("BatcuongDT", true);
                return _BatcuongDT;
            }
            set
            {
                CanWriteProperty("BatcuongDT", true);
                if (_BatcuongDT != value)
                {
                    _BatcuongDT = value;
                    PropertyHasChanged("BatcuongDT");
                }
            }
        }
        public String TangphuDT
        {
            get
            {
                CanReadProperty("TangphuDT", true);
                return _TangphuDT;
            }
            set
            {
                CanWriteProperty("TangphuDT", true);
                if (_TangphuDT != value)
                {
                    _TangphuDT = value;
                    PropertyHasChanged("TangphuDT");
                }
            }
        }
        public String KinhMachDT
        {
            get
            {
                CanReadProperty("KinhMachDT", true);
                return _KinhMachDT;
            }
            set
            {
                CanWriteProperty("KinhMachDT", true);
                if (_KinhMachDT != value)
                {
                    _KinhMachDT = value;
                    PropertyHasChanged("KinhMachDT");
                }
            }
        }
        public String NguyennhanDT
        {
            get
            {
                CanReadProperty("NguyennhanDT", true);
                return _NguyennhanDT;
            }
            set
            {
                CanWriteProperty("NguyennhanDT", true);
                if (_NguyennhanDT != value)
                {
                    _NguyennhanDT = value;
                    PropertyHasChanged("NguyennhanDT");
                }
            }
        }

        public String DinhViBenhTheo
        {
            get
            {
                CanReadProperty("DinhViBenhTheo", true);
                return _DinhViBenhTheo;
            }
            set
            {
                CanWriteProperty("DinhViBenhTheo", true);
                if (_DinhViBenhTheo != value)
                {
                    _DinhViBenhTheo = value;
                    PropertyHasChanged("DinhViBenhTheo");
                }
            }
        }
        public String Nguyennhan
        {
            get
            {
                CanReadProperty("Nguyennhan", true);
                return _Nguyennhan;
            }
            set
            {
                CanWriteProperty("Nguyennhan", true);
                if (_Nguyennhan != value)
                {
                    _Nguyennhan = value;
                    PropertyHasChanged("Nguyennhan");
                }
            }
        }
        public String ChanDoanRaVien
        {
            get
            {
                CanReadProperty("ChanDoanRaVien", true);
                return _ChanDoanRaVien;
            }
            set
            {
                CanWriteProperty("ChanDoanRaVien", true);
                if (_ChanDoanRaVien != value)
                {
                    _ChanDoanRaVien = value;
                    PropertyHasChanged("ChanDoanRaVien");
                }
            }
        }
       
        public String Phapdieutri
        {
            get
            {
                CanReadProperty("Phapdieutri", true);
                return _Phapdieutri;
            }
            set
            {
                CanWriteProperty("Phapdieutri", true);
                if (_Phapdieutri != value)
                {
                    _Phapdieutri = value;
                    PropertyHasChanged("Phapdieutri");
                }
            }
        }
        public String Phuongthuoc
        {
            get
            {
                CanReadProperty("Phuongthuoc", true);
                return _Phuongthuoc;
            }
            set
            {
                CanWriteProperty("Phuongthuoc", true);
                if (_Phuongthuoc != value)
                {
                    _Phuongthuoc = value;
                    PropertyHasChanged("Phuongthuoc");
                }
            }
        }
        public String Phuonghuyet
        {
            get
            {
                CanReadProperty("Phuonghuyet", true);
                return _Phuonghuyet;
            }
            set
            {
                CanWriteProperty("Phuonghuyet", true);
                if (_Phuonghuyet != value)
                {
                    _Phuonghuyet = value;
                    PropertyHasChanged("Phuonghuyet");
                }
            }
        }
        public String XoaBop
        {
            get
            {
                CanReadProperty("XoaBop", true);
                return _XoaBop;
            }
            set
            {
                CanWriteProperty("XoaBop", true);
                if (_XoaBop != value)
                {
                    _XoaBop = value;
                    PropertyHasChanged("XoaBop");
                }
            }
        }
        public String Khac
        {
            get
            {
                CanReadProperty("Khac", true);
                return _Khac;
            }
            set
            {
                CanWriteProperty("Khac", true);
                if (_Khac != value)
                {
                    _Khac = value;
                    PropertyHasChanged("Khac");
                }
            }
        }
        public String mabenhRaVien
        {
            get
            {
                CanReadProperty("mabenhRaVien", true);
                return _mabenhRaVien;
            }
            set
            {
                CanWriteProperty("mabenhRaVien", true);
                if (_mabenhRaVien != value)
                {
                    _mabenhRaVien = value;
                    PropertyHasChanged("mabenhRaVien");
                }
            }
        }

        public String maBenhKKB
        {
            get
            {
                CanReadProperty("maBenhKKB", true);
                return _maBenhKKB;
            }
            set
            {
                CanWriteProperty("maBenhKKB", true);
                if (_maBenhKKB != value)
                {
                    _maBenhKKB = value;
                    PropertyHasChanged("maBenhKKB");
                }
            }
        }
        public String maBenhDT
        {
            get
            {
                CanReadProperty("maBenhDT", true);
                return _maBenhDT;
            }
            set
            {
                CanWriteProperty("maBenhDT", true);
                if (_maBenhDT != value)
                {
                    _maBenhDT = value;
                    PropertyHasChanged("maBenhDT");
                }
            }
        }
        public String ChanDoanDT
        {
            get
            {
                CanReadProperty("ChanDoanDT", true);
                return _ChanDoanDT;
            }
            set
            {
                CanWriteProperty("ChanDoanDT", true);
                if (_ChanDoanDT != value)
                {
                    _ChanDoanDT = value;
                    PropertyHasChanged("ChanDoanDT");
                }
            }
        }
        public String ChanDoanKKB
        {
            get
            {
                CanReadProperty("ChanDoanKKB", true);
                return _ChanDoanKKB;
            }
            set
            {
                CanWriteProperty("ChanDoanKKB", true);
                if (_ChanDoanKKB != value)
                {
                    _ChanDoanKKB = value;
                    PropertyHasChanged("ChanDoanKKB");
                }
            }
        }
        public String maICDRaVien
        {
            get
            {
                CanReadProperty("maICDRaVien", true);
                return _maICDRaVien;
            }
            set
            {
                CanWriteProperty("maICDRaVien", true);
                if (_maICDRaVien != value)
                {
                    _maICDRaVien = value;
                    PropertyHasChanged("maICDRaVien");
                }
            }
        }

        public String maICDKKB
        {
            get
            {
                CanReadProperty("maICDKKB", true);
                return _maICDKKB;
            }
            set
            {
                CanWriteProperty("maICDKKB", true);
                if (_maICDKKB != value)
                {
                    _maICDKKB = value;
                    PropertyHasChanged("maICDKKB");
                }
            }
        }
        public String maICDDT
        {
            get
            {
                CanReadProperty("maICDDT", true);
                return _maICDDT;
            }
            set
            {
                CanWriteProperty("maICDDT", true);
                if (_maICDDT != value)
                {
                    _maICDDT = value;
                    PropertyHasChanged("maICDDT");
                }
            }
        }
        public String CheDoDinhDuong
        {
            get
            {
                CanReadProperty("CheDoDinhDuong", true);
                return _CheDoDinhDuong;
            }
            set
            {
                CanWriteProperty("CheDoDinhDuong", true);
                if (_CheDoDinhDuong != value)
                {
                    _CheDoDinhDuong = value;
                    PropertyHasChanged("CheDoDinhDuong");
                }
            }
        }
        public String CheDoChamSoc
        {
            get
            {
                CanReadProperty("CheDoChamSoc", true);
                return _CheDoChamSoc;
            }
            set
            {
                CanWriteProperty("CheDoChamSoc", true);
                if (_CheDoChamSoc != value)
                {
                    _CheDoChamSoc = value;
                    PropertyHasChanged("CheDoChamSoc");
                }
            }
        }
        public String TienLuong
        {
            get
            {
                CanReadProperty("TienLuong", true);
                return _TienLuong;
            }
            set
            {
                CanWriteProperty("TienLuong", true);
                if (_TienLuong != value)
                {
                    _TienLuong = value;
                    PropertyHasChanged("TienLuong");
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
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm"; 
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
		protected override Object GetIdValue()
		{
			return _maBA.ToString() + "!" + _sTT.ToString().ToString() + "!" + _sTTKhoa.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhAn_DY" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BenhAn_DY NewBenhAn_DY()
        {
            return DataPortal.Create<BenhAn_DY>();
        }
		public static BenhAn_DY GetBenhAn_DY(String maBA, Int32 sTT, Int32 sTTKhoa)
		{
			return DataPortal.Fetch<BenhAn_DY>(new Criteria(maBA, sTT, sTTKhoa));
		}
		
		/// <summary>
		/// Marks the <see cref="BenhAn_DY" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBenhAn_DY(String maBA, Int32 sTT, Int32 sTTKhoa, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maBA, sTT, sTTKhoa));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BenhAn_DY()
		{	
			// Prevent direct creation
		}

        internal BenhAn_DY(     int OrderNumber,
                                 String maBA ,
		                         Int32 sTT ,
		                         Int32 sTTKhoa ,
		                         SmartDate ngayKham ,
		                         String bSKHAM ,
           String HinhThai,
         String Than,
         String Sac,
         String Trach,
         String ChatLuoi,
         String Sacluoi,
         String ReuLuoi,
         String KhacVongChan,
         String MotaVongChan,
         String Giongnoi,
         String HoiTho,
         Boolean CoHo,
         String Ho,
         Boolean OAmThanh,
         Boolean NacAmThanh,
         Boolean CoMui,
         String KieuMui,
         Boolean CoChatThai,
         String KieuChatThai,
         String MoTaVanChan,
         Byte BHHanNhiet,
         String MTBieuhien,
         String Thichnghi,
         String Mohoi,
         Boolean BHDauMat,
         String DauDau,
         String DauMat,
         String DauTai,
         String DauMui,
         String DauHong,
         String DauCoVai,
         Boolean BHLung,
         String Lung,
         Boolean BHBungNguc,
         String BungNguc,
         Boolean BHChanTay,
         Boolean BHAn,
         String An,
         Boolean BHUong,
         String Uong,
         Boolean BHDTT,
         String TieuTien,
         String DaiTien,
         Boolean BHNgu,
         String Ngu,
         Boolean BHKN,
         String RLKinhnguyet,
         String ThongKinh,
         String DoiHa,
         Boolean RLKNSinhDuc,
         String RLNam,
         String RLNu,
         Boolean DKXHBenh,
         String MTVaanChan,


         String XucChanda,
         String XucChanmohoi,
         String XucChancoxuongkhop,
         String XucChanbung,
         String MachChan,
         String TongKhanTrai,
         String TongKhanPhai,
         String ViKhanTraiThon,
         String ViKhanPhaiThon,
         String ViKhanTraiQuan,
         String ViKhanPhaiQuan,
         String ViKhanTraiXich,
         String ViKhanPhaiXich,
         String MTThietChan,
         String TomtatTuChan,
         String BienChungLieuTri,
         String BenhDanh,
         String Batcuong,
         String Tangphu,
         String KinhMach,
         String DinhViBenhTheo,
         String Nguyennhan,
         String BatcuongDT,
         String TangphuDT,
         String NguyennhanDT,
         String ChanDoanRaVien,
         String Phapdieutri,
         String Phuongthuoc,
         String Phuonghuyet,
         String XoaBop,
         String Khac,
         String mabenhRaVien,
         String maBenhDT,
         String maBenhKKB,
         String maICDRaVien,
         String maICDDT,
         String maICDKKB,
         String ChanDoanDT,
         String ChanDoanKKB,
         String CheDoDinhDuong,
         String CheDoChamSoc,
             String TienLuong,

		                         String maMay ,
		                         Boolean huy ,
		                         SmartDate ngaySD ,
		                         String nguoiSD ,
		                         SmartDate ngaySD1 ,
		                         String nguoiSD1 ,
                              
                                 String tenBSKham ,
                                string tennguoisd
                                )
        {
                                  _OrderNumber = OrderNumber ;
                                  _maBA = maBA ;
		                          _sTT = sTT;
		                          _sTTKhoa = sTTKhoa;
		                          _ngayKham = ngayKham ;
		                          _bSKHAM = bSKHAM ;
		                       _HinhThai =HinhThai;
       _Than =Than;
         _Sac =Sac;
         _Trach =Trach;
        _ChatLuoi =ChatLuoi;
         _Sacluoi =Sacluoi;
        _ReuLuoi =ReuLuoi;
         _KhacVongChan =KhacVongChan;
          _MotaVongChan =MotaVongChan;
          _Giongnoi = Giongnoi;
          _HoiTho = HoiTho;
          _CoHo = CoHo;
          _Ho = Ho;
          _OAmThanh = OAmThanh;
          _NacAmThanh = NacAmThanh;
          _CoMui = CoMui;
          _KieuMui = KieuMui;
          _CoChatThai = CoChatThai;
          _KieuChatThai = KieuChatThai;
          _MoTaVanChan = MoTaVanChan;
          _BHHanNhiet = BHHanNhiet;
          _MTBieuhien = MTBieuhien;
          _Thichnghi = Thichnghi;
          _Mohoi = Mohoi;
          _BHDauMat = BHDauMat;
          _DauDau = DauDau;
          _DauMat = DauMat;
          _DauTai = DauTai;
          _DauMui = DauMui;
          _DauHong = DauHong;
          _DauCoVai = DauCoVai;
          _BHLung = BHLung;
          _Lung = Lung;
          _BHBungNguc = BHBungNguc;
          _BungNguc = BungNguc;
          _BHChanTay = BHChanTay;
          _BHAn = BHAn;
          _An = An;
          _BHUong = BHUong;
          _Uong = Uong;
          _BHDTT = BHDTT;
          _TieuTien = TieuTien;
          _DaiTien = DaiTien;
          _BHNgu = BHNgu;
          _Ngu = Ngu;
          _BHKN = BHKN;
          _RLKinhnguyet = RLKinhnguyet;
          _ThongKinh = ThongKinh;
          _DoiHa = DoiHa;
          _RLKNSinhDuc = RLKNSinhDuc;
          _RLNam = RLNam;
          _RLNu = RLNu;
          _DKXHBenh = DKXHBenh;
          _MTVaanChan = MTVaanChan;
          _XucChan_da = XucChan_da;
          _XucChan_mohoi = XucChan_mohoi;
          _XucChan_coxuongkhop = XucChan_coxuongkhop;
          _XucChan_bung = XucChan_bung;
          _MachChan = MachChan;
          _TongKhanTrai = TongKhanTrai;
          _TongKhanPhai = TongKhanPhai;
          _ViKhanTraiThon = ViKhanTraiThon;
          _ViKhanPhaiThon = ViKhanPhaiThon;
          _ViKhanTraiQuan = ViKhanTraiQuan;
          _ViKhanPhaiQuan = ViKhanPhaiQuan;
          _ViKhanTraiXich = ViKhanTraiXich;
          _ViKhanPhaiXich = ViKhanPhaiXich;
          _MTThietChan = MTThietChan;
          _TomtatTuChan = TomtatTuChan;
          _BienChungLieuTri = BienChungLieuTri;
          _BenhDanh = BenhDanh;
          _Batcuong = Batcuong;
          _Tangphu = Tangphu;
          _KinhMach = KinhMach;
          _DinhViBenhTheo = DinhViBenhTheo;
          _Nguyennhan = Nguyennhan;
          _BatcuongDT = BatcuongDT;
          _TangphuDT = TangphuDT;
          _NguyennhanDT = NguyennhanDT;

          _ChanDoanRaVien = ChanDoanRaVien;
          _Phapdieutri = Phapdieutri;
          _Phuongthuoc = Phuongthuoc;
          _Phuonghuyet = Phuonghuyet;
          _XoaBop = XoaBop;
          _Khac = Khac;
          _mabenhRaVien = mabenhRaVien;
          _maBenhDT = maBenhDT;
          _maBenhKKB = maBenhKKB;
          _maICDRaVien = maICDRaVien;
          _maICDDT = maICDDT;
          _maICDKKB = maICDKKB;
          _ChanDoanDT = ChanDoanDT;
          _ChanDoanKKB = ChanDoanKKB;
          _CheDoDinhDuong = CheDoDinhDuong;
          _CheDoChamSoc = CheDoChamSoc;
          _TienLuong = TienLuong;
		                          _maMay = maMay ;
		                          _huy = huy ;
		                          _ngaySD = ngaySD ;
		                          _nguoiSD = nguoiSD ;
		                          _ngaySD1 = ngaySD1 ;
		                          _nguoiSD1 = nguoiSD1 ;
                            
                                  _tenBSKham = tenBSKham ;
                                  _tennguoiSD = tennguoisd;
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
		/// Retrieve an existing <see cref="BenhAn_DY" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetBenhAn_DY(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
			// public override IDataReader GetBenhAn_DY(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_DY_GET", _maBA, _sTT, _sTTKhoa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_DY(crit.MaBA, crit.STT, crit.STTKhoa)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="BenhAn_DY" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
            if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
            if (dr.GetSmartDate("NgayKham", true) != null) _ngayKham = dr.GetSmartDate("NgayKham", true);
            if (dr.GetString("BSKHAM") != null) _bSKHAM = dr.GetString("BSKHAM");
            if (dr.GetString("HinhThai") != null) _HinhThai =dr.GetString("HinhThai");
            if (dr.GetString("Than") != null) _Than =dr.GetString("Than");
            if (dr.GetString("Sac") != null) _Sac =dr.GetString("Sac");
            if (dr.GetString("Trach") != null) _Trach =dr.GetString("Trach");
            if (dr.GetString("ChatLuoi") != null) _ChatLuoi =dr.GetString("ChatLuoi");
            if (dr.GetString("Sacluoi") != null) _Sacluoi =dr.GetString("Sacluoi");
            if (dr.GetString("ReuLuoi") != null) _ReuLuoi =dr.GetString("ReuLuoi");
            if (dr.GetString("KhacVongChan") != null) _KhacVongChan =dr.GetString("KhacVongChan");
            if (dr.GetString("MotaVongChan") != null) _MotaVongChan =dr.GetString("MotaVongChan");
            if (dr.GetString("Giongnoi") != null) _Giongnoi =dr.GetString("Giongnoi");
            if (dr.GetString("HoiTho") != null) _HoiTho =dr.GetString("HoiTho");
            if (dr.GetBoolean("CoHo") != null) _CoHo =  dr.GetBoolean("CoHo");
            if (dr.GetString("Ho") != null) _Ho =dr.GetString("Ho");
            if (dr.GetBoolean("OAmThanh") != null) _OAmThanh = dr.GetBoolean("OAmThanh");
            if (dr.GetBoolean("NacAmThanh") != null) _NacAmThanh = dr.GetBoolean("NacAmThanh");
            if (dr.GetBoolean("CoMui") != null) _CoMui = dr.GetBoolean("CoMui");
            if (dr.GetString("KieuMui") != null) _KieuMui =dr.GetString("KieuMui");
            if (dr.GetBoolean("CoChatThai") != null) _CoChatThai = dr.GetBoolean("CoChatThai");
            if (dr.GetString("KieuChatThai") != null) _KieuChatThai =dr.GetString("KieuChatThai");
            if (dr.GetString("MoTaVanChan") != null) _MoTaVanChan =dr.GetString("MoTaVanChan");
            if (dr.GetByte("BHHanNhiet")  != null) _BHHanNhiet = dr.GetByte("BHHanNhiet");
            if (dr.GetString("MTBieuhien") != null) _MTBieuhien =dr.GetString("MTBieuhien");
            if (dr.GetString("Thichnghi") != null) _Thichnghi =dr.GetString("Thichnghi");
            if (dr.GetString("Mohoi") != null) _Mohoi =dr.GetString("Mohoi");
            if (dr.GetBoolean("BHDauMat") != null) _BHDauMat = dr.GetBoolean("BHDauMat");
            if (dr.GetString("DauDau") != null) _DauDau =dr.GetString("DauDau");
            if (dr.GetString("DauMat") != null) _DauMat =dr.GetString("DauMat");
            if (dr.GetString("DauTai") != null) _DauTai =dr.GetString("DauTai");
            if (dr.GetString("DauMui") != null) _DauMui =dr.GetString("DauMui");
            if (dr.GetString("DauHong") != null) _DauHong =dr.GetString("DauHong");
            if (dr.GetString("DauCoVai") != null) _DauCoVai =dr.GetString("DauCoVai");
            if (dr.GetBoolean("BHLung") != null) _BHLung = dr.GetBoolean("BHLung");
            if (dr.GetString("Lung") != null) _Lung =dr.GetString("Lung");
            if (dr.GetBoolean("BHBungNguc") != null) _BHBungNguc = dr.GetBoolean("BHBungNguc");
            if (dr.GetString("BungNguc") != null) _BungNguc =dr.GetString("BungNguc");
            if (dr.GetBoolean("BHChanTay") != null) _BHChanTay = dr.GetBoolean("BHChanTay");
            if (dr.GetBoolean("BHAn") != null) _BHAn = dr.GetBoolean("BHAn");
            if (dr.GetString("An") != null) _An =dr.GetString("An");
            if (dr.GetBoolean("BHUong") != null) _BHUong = dr.GetBoolean("BHUong");
            if (dr.GetString("Uong") != null) _Uong =dr.GetString("Uong");
            if (dr.GetBoolean("BHDTT") != null) _BHDTT = dr.GetBoolean("BHDTT");
            if (dr.GetString("TieuTien") != null) _TieuTien =dr.GetString("TieuTien");
            if (dr.GetString("DaiTien") != null) _DaiTien =dr.GetString("DaiTien");
            if (dr.GetBoolean("BHNgu") != null) _BHNgu = dr.GetBoolean("BHNgu");
            if (dr.GetString("Ngu") != null) _Ngu =dr.GetString("Ngu");
            if (dr.GetBoolean("BHKN") != null) _BHKN = dr.GetBoolean("BHKN");
            if (dr.GetString("RLKinhnguyet") != null) _RLKinhnguyet =dr.GetString("RLKinhnguyet");
            if (dr.GetString("ThongKinh") != null) _ThongKinh =dr.GetString("ThongKinh");
            if (dr.GetString("DoiHa") != null) _DoiHa =dr.GetString("DoiHa");
            if (dr.GetBoolean("RLKNSinhDuc") != null) _RLKNSinhDuc = dr.GetBoolean("RLKNSinhDuc");
            if (dr.GetString("RLNam") != null) _RLNam =dr.GetString("RLNam");
            if (dr.GetString("RLNu") != null) _RLNu =dr.GetString("RLNu");
            if (dr.GetBoolean("DKXHBenh") != null) _DKXHBenh = dr.GetBoolean("DKXHBenh");
            if (dr.GetString("MTVaanChan") != null) _MTVaanChan =dr.GetString("MTVaanChan");

            if (dr.GetString("PPDieuTriYHCT") != null) _pPhapDieuTriYHCT = dr.GetString("PPDieuTriYHCT");
            if (dr.GetString("PPDieuTriYHHD") != null) _pPhapDieuTriYHHD = dr.GetString("PPDieuTriYHHD");

            if (dr.GetString("XucChan_da") != null) _XucChan_da  =dr.GetString("XucChan_da");
            if (dr.GetString("XucChan_mohoi") != null) _XucChan_mohoi  =dr.GetString("XucChan_mohoi");
            if (dr.GetString("XucChan_coxuongkhop") != null) _XucChan_coxuongkhop  =dr.GetString("XucChan_coxuongkhop");
            if (dr.GetString("XucChan_bung") != null) _XucChan_bung =dr.GetString("XucChan_bung");
            if (dr.GetString("MachChan") != null) _MachChan =dr.GetString("MachChan");
            if (dr.GetString("TongKhanTrai") != null) _TongKhanTrai =dr.GetString("TongKhanTrai");
            if (dr.GetString("TongKhanPhai") != null) _TongKhanPhai =dr.GetString("TongKhanPhai");
            if (dr.GetString("ViKhanTraiThon") != null) _ViKhanTraiThon =dr.GetString("ViKhanTraiThon");
            if (dr.GetString("ViKhanPhaiThon") != null) _ViKhanPhaiThon =dr.GetString("ViKhanPhaiThon");
            if (dr.GetString("ViKhanTraiQuan") != null) _ViKhanTraiQuan =dr.GetString("ViKhanTraiQuan");
            if (dr.GetString("ViKhanPhaiQuan") != null) _ViKhanPhaiQuan =dr.GetString("ViKhanPhaiQuan");
            if (dr.GetString("ViKhanTraiXich") != null) _ViKhanTraiXich =dr.GetString("ViKhanTraiXich");
            if (dr.GetString("ViKhanPhaiXich") != null) _ViKhanPhaiXich =dr.GetString("ViKhanPhaiXich");
            if (dr.GetString("MTThietChan") != null) _MTThietChan =dr.GetString("MTThietChan");
            if (dr.GetString("TomtatTuChan") != null) _TomtatTuChan =dr.GetString("TomtatTuChan");
            if (dr.GetString("BienChungLieuTri") != null) _BienChungLieuTri =dr.GetString("BienChungLieuTri");
            if (dr.GetString("BenhDanh") != null) _BenhDanh =dr.GetString("BenhDanh");
            if (dr.GetString("Batcuong") != null) _Batcuong =dr.GetString("Batcuong");
            if (dr.GetString("Tangphu") != null) _Tangphu =dr.GetString("Tangphu");
            if (dr.GetString("KinhMach") != null) _KinhMach =dr.GetString("KinhMach");
            if (dr.GetString("DinhViBenhTheo") != null) _DinhViBenhTheo =dr.GetString("DinhViBenhTheo");
            if (dr.GetString("Nguyennhan") != null) _Nguyennhan =dr.GetString("Nguyennhan");


            if (dr.GetString("BatcuongDT") != null) _BatcuongDT = dr.GetString("BatcuongDT");
            if (dr.GetString("TangphuDT") != null) _TangphuDT = dr.GetString("TangphuDT");
           // if (dr.GetString("KinhMachDT") != null) _KinhMachDT = dr.GetString("KinhMachDT");
       
            if (dr.GetString("NguyennhanDT") != null) _NguyennhanDT = dr.GetString("NguyennhanDT");
            if (dr.GetString("ChanDoanRaVien") != null) _ChanDoanRaVien =dr.GetString("ChanDoanRaVien");
            if (dr.GetString("Phapdieutri") != null) _Phapdieutri =dr.GetString("Phapdieutri");
            if (dr.GetString("Phuongthuoc") != null) _Phuongthuoc =dr.GetString("Phuongthuoc");
            if (dr.GetString("Phuonghuyet") != null) _Phuonghuyet =dr.GetString("Phuonghuyet");
            if (dr.GetString("XoaBop") != null) _XoaBop =dr.GetString("XoaBop");
            if (dr.GetString("Khac") != null) _Khac =dr.GetString("Khac");
            if (dr.GetString("mabenhRaVien") != null) _mabenhRaVien =dr.GetString("mabenhRaVien");
            if (dr.GetString("maBenhDT") != null) _maBenhDT =dr.GetString("maBenhDT");
            if (dr.GetString("maBenhKKB") != null) _maBenhKKB =dr.GetString("maBenhKKB");
            if (dr.GetString("maICDRaVien") != null) _maICDRaVien =dr.GetString("maICDRaVien");
            if (dr.GetString("maICDDT") != null) _maICDDT =dr.GetString("maICDDT");
            if (dr.GetString("maICDKKB") != null) _maICDKKB =dr.GetString("maICDKKB");
            if (dr.GetString("ChanDoanDT") != null) _ChanDoanDT =dr.GetString("ChanDoanDT");
            if (dr.GetString("ChanDoanKKB") != null) _ChanDoanKKB = dr.GetString("ChanDoanKKB");
            if (dr.GetString("CheDoDinhDuong") != null) _CheDoDinhDuong =dr.GetString("CheDoDinhDuong");
            if (dr.GetString("CheDoChamSoc") != null) _CheDoChamSoc =dr.GetString("CheDoChamSoc");
            if (dr.GetString("TienLuong") != null) _TienLuong = dr.GetString("TienLuong");
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
		/// Insert the new <see cref="BenhAn_DY" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_DY
			// Copy & paste ham duoi day vao file DataProvider.cs
            _maBA = DataProvider.Instance().InsertBenhAn_DY(_maBA, _sTTKhoa, _sTT,_ngayKham, _bSKHAM, _HinhThai  ,
         _Than  ,
         _Sac  ,
         _Trach  ,
         _ChatLuoi  ,
         _Sacluoi  ,
         _ReuLuoi  ,
         _KhacVongChan  ,
         _MotaVongChan  ,
         _Giongnoi  ,
         _HoiTho  ,
        _CoHo  ,
         _Ho  ,
        _OAmThanh  ,
        _NacAmThanh  ,
        _CoMui  ,
         _KieuMui  ,
        _CoChatThai  ,
         _KieuChatThai  ,
         _MoTaVanChan  ,
         _BHHanNhiet  ,
         _MTBieuhien  ,
         _Thichnghi  ,
         _Mohoi  ,
        _BHDauMat  ,
         _DauDau  ,
         _DauMat  ,
         _DauTai  ,
         _DauMui  ,
         _DauHong  ,
         _DauCoVai  ,
        _BHLung  ,
         _Lung  ,
        _BHBungNguc  ,
         _BungNguc  ,
        _BHChanTay  ,
        _BHAn  ,
         _An  ,
        _BHUong  ,
         _Uong  ,
        _BHDTT  ,
         _TieuTien  ,
         _DaiTien  ,
        _BHNgu  ,
         _Ngu  ,
        _BHKN  ,
         _RLKinhnguyet  ,
         _ThongKinh  ,
         _DoiHa  ,
        _RLKNSinhDuc  ,
         _RLNam  ,
         _RLNu  ,
        _DKXHBenh  ,
         _MTVaanChan  ,

      
         _XucChan_da  ,
         _XucChan_mohoi  ,
         _XucChan_coxuongkhop  ,
         _XucChan_bung  ,
         _MachChan  ,
         _TongKhanTrai  ,
         _TongKhanPhai  ,
         _ViKhanTraiThon  ,
         _ViKhanPhaiThon  ,
         _ViKhanTraiQuan  ,
         _ViKhanPhaiQuan  ,
         _ViKhanTraiXich  ,
         _ViKhanPhaiXich  ,
         _MTThietChan  ,
         _TomtatTuChan  ,
         _BienChungLieuTri  ,
         _BenhDanh  ,
         _Batcuong  ,
         _Tangphu  ,
         _KinhMach  ,
         _DinhViBenhTheo  ,
         _Nguyennhan  ,
        
         _BatcuongDT,
         _TangphuDT,
         _NguyennhanDT,
         _ChanDoanRaVien  ,
         _Phuongthuoc  ,
         _Phuonghuyet  ,
         _XoaBop  ,
         _Khac  ,
         _mabenhRaVien  ,
         _maBenhDT  ,
         _maBenhKKB  ,
     
         _ChanDoanDT  ,
         _ChanDoanKKB  ,
         _CheDoDinhDuong  ,
         _CheDoChamSoc  , _TienLuong, _maMay, _nguoiSD, _Phapdieutri, _pPhapDieuTriYHHD);
            // public abstract String InsertBenhAn_DY(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _tieuHoa, String _ThanTNieuSDuc, String _thanKinh, String _XuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _BenhLyKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD);
            // public override String InsertBenhAn_DY(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _tieuHoa, String _ThanTNieuSDuc, String _thanKinh, String _XuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _BenhLyKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_DY_CREATE", _maBA, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _toanThan, _benhngoaiKhoa, _tuanHoan, _hoHap, _tieuHoa, _ThanTNieuSDuc, _thanKinh, _XuongKhop, _taiMuiHong, _rangHamMat, _mat, _BenhLyKhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _machuyenkhoa, _maMay, _huy, _ngaySD.DBValue, _nguoiSD , _ngaySD1.DBValue, _nguoiSD1), String);
            // }
            MarkOld();

        }
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAn_DY" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_DY
			if (IsDirty){
                DataProvider.Instance().UpdateBenhAn_DY(_maBA, _sTT, _sTTKhoa, _ngayKham, _bSKHAM,  _HinhThai  ,
         _Than  ,
         _Sac  ,
         _Trach  ,
         _ChatLuoi  ,
         _Sacluoi  ,
         _ReuLuoi  ,
         _KhacVongChan  ,
         _MotaVongChan  ,
         _Giongnoi  ,
         _HoiTho  ,
        _CoHo  ,
         _Ho  ,
        _OAmThanh  ,
        _NacAmThanh  ,
        _CoMui  ,
         _KieuMui  ,
        _CoChatThai  ,
         _KieuChatThai  ,
         _MoTaVanChan  ,
         _BHHanNhiet  ,
         _MTBieuhien  ,
         _Thichnghi  ,
         _Mohoi  ,
        _BHDauMat  ,
         _DauDau  ,
         _DauMat  ,
         _DauTai  ,
         _DauMui  ,
         _DauHong  ,
         _DauCoVai  ,
        _BHLung  ,
         _Lung  ,
        _BHBungNguc  ,
         _BungNguc  ,
        _BHChanTay  ,
        _BHAn  ,
         _An  ,
        _BHUong  ,
         _Uong  ,
        _BHDTT  ,
         _TieuTien  ,
         _DaiTien  ,
        _BHNgu  ,
         _Ngu  ,
        _BHKN  ,
         _RLKinhnguyet  ,
         _ThongKinh  ,
         _DoiHa  ,
        _RLKNSinhDuc  ,
         _RLNam  ,
         _RLNu  ,
        _DKXHBenh  ,
         _MTVaanChan  ,

      
         _XucChan_da  ,
         _XucChan_mohoi  ,
         _XucChan_coxuongkhop  ,
         _XucChan_bung  ,
         _MachChan  ,
         _TongKhanTrai  ,
         _TongKhanPhai  ,
         _ViKhanTraiThon  ,
         _ViKhanPhaiThon  ,
         _ViKhanTraiQuan  ,
         _ViKhanPhaiQuan  ,
         _ViKhanTraiXich  ,
         _ViKhanPhaiXich  ,
         _MTThietChan  ,
         _TomtatTuChan  ,
         _BienChungLieuTri  ,
         _BenhDanh  ,
         _Batcuong  ,
         _Tangphu  ,
         _KinhMach  ,
         _DinhViBenhTheo  ,
         _Nguyennhan  ,
           _BatcuongDT,
         _TangphuDT,
         _NguyennhanDT,
         _ChanDoanRaVien  ,
         _Phuongthuoc  ,
         _Phuonghuyet  ,
         _XoaBop  ,
         _Khac  ,
         _mabenhRaVien  ,
         _maBenhDT  ,
         _maBenhKKB  ,
     
         _ChanDoanDT  ,
         _ChanDoanKKB  ,
         _CheDoDinhDuong  ,
         _CheDoChamSoc, _TienLuong, _maMay, _huy, _nguoiSD,_Phapdieutri,_pPhapDieuTriYHHD);
                // public abstract void UpdateBenhAn_DY(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _tieuHoa, String _ThanTNieuSDuc, String _thanKinh, String _XuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _BenhLyKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
                // public override void UpdateBenhAn_DY(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _tieuHoa, String _ThanTNieuSDuc, String _thanKinh, String _XuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _BenhLyKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_DY_UPDATE", _maBA, _sTT, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _toanThan, _benhngoaiKhoa, _tuanHoan, _hoHap, _tieuHoa, _ThanTNieuSDuc, _thanKinh, _XuongKhop, _taiMuiHong, _rangHamMat, _mat, _BenhLyKhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _machuyenkhoa, _maMay, _huy, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maBA, _sTT, _sTTKhoa));
		}

		/// <summary>
		/// Delete the <see cref="BenhAn_DY" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_DY
            DataProvider.Instance().DeleteBenhAn_DY(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.STT, crit.STTKhoa);
			// public abstract void DeleteBenhAn_DY(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
			// public override void DeleteBenhAn_DY(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_DY_Deleted", _maBA, _sTT, _sTTKhoa);
			// }
		}

		#endregion
	}

}
