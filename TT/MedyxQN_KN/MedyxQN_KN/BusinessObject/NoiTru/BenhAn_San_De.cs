// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_San_De
// Kieu doi tuong  :	BenhAn_San_De
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	03/30/2010 11:06:27 AM
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
	/// This is a base generated class of <see cref="BenhAn_San_De" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_San_De : BusinessBase<BenhAn_San_De>
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
        private String _benhSu = String.Empty;
		private SmartDate _ngayDe = new SmartDate(true);
		private String _tenConTrai = String.Empty;
		private String _tenConGai = String.Empty;
		private String _tinhThan = String.Empty;
		private String _theTrang = String.Empty;
		private String _mach = String.Empty;
		private String _da = String.Empty;
		private String _niemMac = String.Empty;
		private String _apHuyet = String.Empty;
		private String _nhietDo = String.Empty;
		private String _nhipTho = String.Empty;
		private String _canNang = String.Empty;
		private String _chieuCao = String.Empty;

		private Byte _phu = 0;
        private Boolean _phuCo = false;
        private Boolean _phuKhong = false;
        private Boolean _phuToanThan = false;

		private String _toanThan = String.Empty;
		private String _toanTrang = String.Empty;
		private String _cao = String.Empty;
		private String _tim = String.Empty;
		private String _gan = String.Empty;
		private String _phoi = String.Empty;
		private String _than = String.Empty;
		private String _benhKhac = String.Empty;
		private String _khamTai = String.Empty;
		private Byte _tuoiThai = 0;

		private Boolean _tiemPhong = false;
        private Boolean _tiemPhongT = false;

        private String _mui = String.Empty;
		private SmartDate _ngayChuyenDa = new SmartDate(true);
		private String _trieuTrung = String.Empty;
		private String _dauHieu = String.Empty;

		private Byte  _seoPTCu = 0;
        private Boolean _seoPTCuCo = false;
        private Boolean _seoPTCuKhong = false;
        private Boolean _seoPTCuDau = false;


		private Boolean _dauVetMo = false;
		private String _chieuCaoTC = String.Empty;
		private String _vongBung = String.Empty;
		private String _timThai = String.Empty;
		private Boolean _timThaiRo = false;
		private String _luongGai = String.Empty;
		private String _baudelocque = String.Empty;
		private String _luongUNgoi = String.Empty;
		private String _hinhDangTC = String.Empty;
		private String _tuThe = String.Empty;
		private String _conCoTC = String.Empty;
		private String _ngoiThai = String.Empty;
		private String _vu = String.Empty;
		private String _luongMao = String.Empty;
		private String _luongMau = String.Empty;

		private Byte _khungChau = 0;
        private Boolean _khungChauBT = false;
        private Boolean _khungChauHep = false;
        private Boolean _khungChauMeo = false;
        private Boolean _khungChauLech = false;


		private String _cutHaVe = String.Empty;
		private String _amHo = String.Empty;
		private String _amDao = String.Empty;
		private Byte  _coTuCung = 0;
        private Boolean _coTuCungT = false;
      
        private Boolean _coTuCungK = false;
		private String _mo = String.Empty;
		private String _bishop = String.Empty;
		private Boolean _khoiU = false;
        private Boolean _khoiUT = false;

		private String _khoiUC = String.Empty;

		private Byte _dauOi = 0;
        private Boolean _DauOiPhong = false;
        private Boolean _DauOiDet = false;
        private Boolean _DauOiQuaLe = false;
        private Boolean _DauOiRi = false;
        private Boolean _DauOiVo = false;

        private Byte _kieuOiVo = 0;
        private Boolean _kieuOiVoT = false;

		private SmartDate _oiVo = new SmartDate(true);

        private Byte _mauOi = 0;
        private Boolean _mauOiTrong = false;
        private Boolean _mauOiXanh = false;
        private Boolean _mauOiLan = false;

		private String _ngoi = String.Empty;
		private String _the = String.Empty;

		private Byte _doLot = 0;
        private Boolean _doLotLong = false;
        private Boolean _doLotChuc = false;
        private Boolean _doLotChat = false;
        private Boolean _doLotLot = false;

		private String _tangSinhMon = String.Empty;
		private String _kieuThe = String.Empty;
		private String _duongKinhNho = String.Empty;
		private String _tienLuong = String.Empty;
		private String _dieuTri = String.Empty;
		private String _chanDoan = String.Empty;
		private String _khiDe = String.Empty;
		private String _phanBiet = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
        private String _tenBSKham = String.Empty;
        private String _tennguoiSD = String.Empty;
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

        public String NgayKhamD
        {
            get
            {
                CanReadProperty("NgayKhamD", true);
                _ngayKhamD = _ngayKham;
                _ngayKhamD.FormatString = "dd/MM/yyyy";
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
		
		public string NgayDe
		{
			get 
			{
				CanReadProperty("NgayDe", true);
                _ngayDe.FormatString = "dd/MM/yyyy HH:mm:ss";
				return _ngayDe.Text;
			}
			set 
			{
				CanWriteProperty("NgayDe", true);
				if (_ngayDe.Text != value) 
				{
					_ngayDe.Text = value;
					PropertyHasChanged("NgayDe");
				}
			}
		}
		
		public String TenConTrai
		{
			get 
			{
				CanReadProperty("TenConTrai", true);
				return _tenConTrai;
			}
			set 
			{
				CanWriteProperty("TenConTrai", true);
				if (_tenConTrai != value) 
				{
					_tenConTrai = value;
					PropertyHasChanged("TenConTrai");
				}
			}
		}
		
		public String TenConGai
		{
			get 
			{
				CanReadProperty("TenConGai", true);
				return _tenConGai;
			}
			set 
			{
				CanWriteProperty("TenConGai", true);
				if (_tenConGai != value) 
				{
					_tenConGai = value;
					PropertyHasChanged("TenConGai");
				}
			}
		}
		
		public String TinhThan
		{
			get 
			{
				CanReadProperty("TinhThan", true);
				return _tinhThan;
			}
			set 
			{
				CanWriteProperty("TinhThan", true);
				if (_tinhThan != value) 
				{
					_tinhThan = value;
					PropertyHasChanged("TinhThan");
				}
			}
		}
		
		public String TheTrang
		{
			get 
			{
				CanReadProperty("TheTrang", true);
				return _theTrang;
			}
			set 
			{
				CanWriteProperty("TheTrang", true);
				if (_theTrang != value) 
				{
					_theTrang = value;
					PropertyHasChanged("TheTrang");
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
		
		public String Da
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
		
		public String NiemMac
		{
			get 
			{
				CanReadProperty("NiemMac", true);
				return _niemMac;
			}
			set 
			{
				CanWriteProperty("NiemMac", true);
				if (_niemMac != value) 
				{
					_niemMac = value;
					PropertyHasChanged("NiemMac");
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
		
        public Byte Phu
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

        public Boolean PhuCo
        {
            get
            {
                CanReadProperty("PhuCo", true);

                if (_phu  == 1)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("PhuCo", true);

                if (_phuCo  != value)
                {

                    _phuCo = value;

                }
                if (_phuCo == true)
                    _phu = 1;
                PropertyHasChanged("PhuCo");

            }
        }
        public Boolean PhuKhong
        {
            get
            {
                CanReadProperty("PhuKhong", true);

                if (_phu  == 0)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("PhuKhong", true);

                if (_phuKhong  != value)
                {

                    _phuKhong = value;

                }
                if (_phuKhong == true)
                    _phu = 0;
                PropertyHasChanged("PhuKhong");

            }
        }
        public Boolean PhuToanThan
        {
            get
            {
                CanReadProperty("PhuToanThan", true);


                if (_phu  == 2)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("PhuToanThan", true);

                if (_phuToanThan  != value)
                {

                    _phuToanThan = value;

                }
                if (_phuToanThan == true)
                    _phu  = 2;
                PropertyHasChanged("PhuToanThan");
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
		
		public String Cao
		{
			get 
			{
				CanReadProperty("Cao", true);
				return _cao;
			}
			set 
			{
				CanWriteProperty("Cao", true);
				if (_cao != value) 
				{
					_cao = value;
					PropertyHasChanged("Cao");
				}
			}
		}
		
		public String Tim
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
		
		public String Gan
		{
			get 
			{
				CanReadProperty("Gan", true);
				return _gan;
			}
			set 
			{
				CanWriteProperty("Gan", true);
				if (_gan != value) 
				{
					_gan = value;
					PropertyHasChanged("Gan");
				}
			}
		}
		
		public String Phoi
		{
			get 
			{
				CanReadProperty("Phoi", true);
				return _phoi;
			}
			set 
			{
				CanWriteProperty("Phoi", true);
				if (_phoi != value) 
				{
					_phoi = value;
					PropertyHasChanged("Phoi");
				}
			}
		}
		
		public String Than
		{
			get 
			{
				CanReadProperty("Than", true);
				return _than;
			}
			set 
			{
				CanWriteProperty("Than", true);
				if (_than != value) 
				{
					_than = value;
					PropertyHasChanged("Than");
				}
			}
		}
		
		public String BenhKhac
		{
			get 
			{
				CanReadProperty("BenhKhac", true);
				return _benhKhac;
			}
			set 
			{
				CanWriteProperty("BenhKhac", true);
				if (_benhKhac != value) 
				{
					_benhKhac = value;
					PropertyHasChanged("BenhKhac");
				}
			}
		}
		
		public String KhamTai
		{
			get 
			{
				CanReadProperty("KhamTai", true);
				return _khamTai;
			}
			set 
			{
				CanWriteProperty("KhamTai", true);
				if (_khamTai != value) 
				{
					_khamTai = value;
					PropertyHasChanged("KhamTai");
				}
			}
		}
		
		public Byte TuoiThai
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
		

        public Boolean TiemPhong
        {
            get
            {
                CanReadProperty("TiemPhong", true);
                return _tiemPhong;
            }
            set
            {
                CanWriteProperty("TiemPhong", true);
                if (_tiemPhong != value)
                {
                    _tiemPhong = value;
                    PropertyHasChanged("TiemPhong");
                }
            }
        }

        public Boolean TiemPhongT
        {
            get
            {
                CanReadProperty("TiemPhongT", true);
                if (_tiemPhong == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("TiemPhongT", true);
                this._tiemPhongT = value;
                if (_tiemPhongT == true)
                    _tiemPhong = false;
                PropertyHasChanged("TiemPhongT");

            }

        }
		
		public String Mui
		{
			get 
			{
				CanReadProperty("Mui", true);
				return _mui;
			}
			set 
			{
				CanWriteProperty("Mui", true);
				if (_mui != value) 
				{
					_mui = value;
					PropertyHasChanged("Mui");
				}
			}
		}
		
		public string NgayChuyenDa
		{
			get 
			{
				CanReadProperty("NgayChuyenDa", true);
                _ngayChuyenDa.FormatString = "dd/MM/yyyy HH:mm:ss";
				return _ngayChuyenDa.Text;
			}
			set 
			{
				CanWriteProperty("NgayChuyenDa", true);
				if (_ngayChuyenDa.Text != value) 
				{
					_ngayChuyenDa.Text = value;
					PropertyHasChanged("NgayChuyenDa");
				}
			}
		}
		
		public String TrieuTrung
		{
			get 
			{
				CanReadProperty("TrieuTrung", true);
				return _trieuTrung;
			}
			set 
			{
				CanWriteProperty("TrieuTrung", true);
				if (_trieuTrung != value) 
				{
					_trieuTrung = value;
					PropertyHasChanged("TrieuTrung");
				}
			}
		}
		
		public String DauHieu
		{
			get 
			{
				CanReadProperty("DauHieu", true);
				return _dauHieu;
			}
			set 
			{
				CanWriteProperty("DauHieu", true);
				if (_dauHieu != value) 
				{
					_dauHieu = value;
					PropertyHasChanged("DauHieu");
				}
			}
		}
		
		public Byte SeoPTCu
		{
			get 
			{
				CanReadProperty("SeoPTCu", true);
				return _seoPTCu;
			}
			set 
			{
				CanWriteProperty("SeoPTCu", true);
				if (_seoPTCu != value) 
				{
					_seoPTCu = value;
					PropertyHasChanged("SeoPTCu");
				}
			}
		}

        public Boolean SeoPTCuCo
        {
            get
            {
                CanReadProperty("SeoPTCuCo", true);

                if (_seoPTCu == 1)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("SeoPTCuCo", true);

                if (_seoPTCuCo  != value)
                {

                    _seoPTCuCo = value;

                }
                if (_seoPTCuCo == true)
                    _seoPTCu = 1;
                PropertyHasChanged("SeoPTCuCo");

            }
        }
        public Boolean SeoPTCuKhong
        {
            get
            {
                CanReadProperty("SeoPTCuKhong", true);

                if (_seoPTCu  == 0)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("SeoPTCuKhong", true);

                if (_seoPTCuKhong  != value)
                {

                    _seoPTCuKhong = value;

                }
                if (_seoPTCuKhong == true)
                    _seoPTCu = 0;
                PropertyHasChanged("SeoPTCuKhong");

            }
        }
        public Boolean SeoPTCuDau
        {
            get
            {
                CanReadProperty("SeoPTCuDau", true);


                if (_seoPTCu  == 2)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("SeoPTCuDau", true);

                if (_seoPTCuDau  != value)
                {

                    _seoPTCuDau  = value;

                }
                if (_seoPTCuDau == true)
                    _seoPTCu = 2;
                PropertyHasChanged("SeoPTCuDau");
            }
        }
        
		
		public Boolean DauVetMo
		{
			get 
			{
				CanReadProperty("DauVetMo", true);
				return _dauVetMo;
			}
			set 
			{
				CanWriteProperty("DauVetMo", true);
				if (_dauVetMo != value) 
				{
					_dauVetMo = value;
					PropertyHasChanged("DauVetMo");
				}
			}
		}
		
		public String ChieuCaoTC
		{
			get 
			{
				CanReadProperty("ChieuCaoTC", true);
				return _chieuCaoTC;
			}
			set 
			{
				CanWriteProperty("ChieuCaoTC", true);
				if (_chieuCaoTC != value) 
				{
					_chieuCaoTC = value;
					PropertyHasChanged("ChieuCaoTC");
				}
			}
		}
		
		public String VongBung
		{
			get 
			{
				CanReadProperty("VongBung", true);
				return _vongBung;
			}
			set 
			{
				CanWriteProperty("VongBung", true);
				if (_vongBung != value) 
				{
					_vongBung = value;
					PropertyHasChanged("VongBung");
				}
			}
		}
		
		public String TimThai
		{
			get 
			{
				CanReadProperty("TimThai", true);
				return _timThai;
			}
			set 
			{
				CanWriteProperty("TimThai", true);
				if (_timThai != value) 
				{
					_timThai = value;
					PropertyHasChanged("TimThai");
				}
			}
		}
		
		public Boolean TimThaiRo
		{
			get 
			{
				CanReadProperty("TimThaiRo", true);
				return _timThaiRo;
			}
			set 
			{
				CanWriteProperty("TimThaiRo", true);
				if (_timThaiRo != value) 
				{
					_timThaiRo = value;
					PropertyHasChanged("TimThaiRo");
				}
			}
		}
		
		public String LuongGai
		{
			get 
			{
				CanReadProperty("LuongGai", true);
				return _luongGai;
			}
			set 
			{
				CanWriteProperty("LuongGai", true);
				if (_luongGai != value) 
				{
					_luongGai = value;
					PropertyHasChanged("LuongGai");
				}
			}
		}
		
		public String Baudelocque
		{
			get 
			{
				CanReadProperty("Baudelocque", true);
				return _baudelocque;
			}
			set 
			{
				CanWriteProperty("Baudelocque", true);
				if (_baudelocque != value) 
				{
					_baudelocque = value;
					PropertyHasChanged("Baudelocque");
				}
			}
		}
		
		public String LuongUNgoi
		{
			get 
			{
				CanReadProperty("LuongUNgoi", true);
				return _luongUNgoi;
			}
			set 
			{
				CanWriteProperty("LuongUNgoi", true);
				if (_luongUNgoi != value) 
				{
					_luongUNgoi = value;
					PropertyHasChanged("LuongUNgoi");
				}
			}
		}
		
		public String HinhDangTC
		{
			get 
			{
				CanReadProperty("HinhDangTC", true);
				return _hinhDangTC;
			}
			set 
			{
				CanWriteProperty("HinhDangTC", true);
				if (_hinhDangTC != value) 
				{
					_hinhDangTC = value;
					PropertyHasChanged("HinhDangTC");
				}
			}
		}
		
		public String TuThe
		{
			get 
			{
				CanReadProperty("TuThe", true);
				return _tuThe;
			}
			set 
			{
				CanWriteProperty("TuThe", true);
				if (_tuThe != value) 
				{
					_tuThe = value;
					PropertyHasChanged("TuThe");
				}
			}
		}
		
		public String ConCoTC
		{
			get 
			{
				CanReadProperty("ConCoTC", true);
				return _conCoTC;
			}
			set 
			{
				CanWriteProperty("ConCoTC", true);
				if (_conCoTC != value) 
				{
					_conCoTC = value;
					PropertyHasChanged("ConCoTC");
				}
			}
		}
		
		public String NgoiThai
		{
			get 
			{
				CanReadProperty("NgoiThai", true);
				return _ngoiThai;
			}
			set 
			{
				CanWriteProperty("NgoiThai", true);
				if (_ngoiThai != value) 
				{
					_ngoiThai = value;
					PropertyHasChanged("NgoiThai");
				}
			}
		}
		
		public String Vu
		{
			get 
			{
				CanReadProperty("Vu", true);
				return _vu;
			}
			set 
			{
				CanWriteProperty("Vu", true);
				if (_vu != value) 
				{
					_vu = value;
					PropertyHasChanged("Vu");
				}
			}
		}
		
		public String LuongMao
		{
			get 
			{
				CanReadProperty("LuongMao", true);
				return _luongMao;
			}
			set 
			{
				CanWriteProperty("LuongMao", true);
				if (_luongMao != value) 
				{
					_luongMao = value;
					PropertyHasChanged("LuongMao");
				}
			}
		}
		
		public String LuongMau
		{
			get 
			{
				CanReadProperty("LuongMau", true);
				return _luongMau;
			}
			set 
			{
				CanWriteProperty("LuongMau", true);
				if (_luongMau != value) 
				{
					_luongMau = value;
					PropertyHasChanged("LuongMau");
				}
			}
		}
		
		public Byte KhungChau
		{
			get 
			{
				CanReadProperty("KhungChau", true);
				return _khungChau;
			}
			set 
			{
				CanWriteProperty("KhungChau", true);
				if (_khungChau != value) 
				{
					_khungChau = value;
					PropertyHasChanged("KhungChau");
				}
			}
		}
		
		public String CutHaVe
		{
			get 
			{
				CanReadProperty("CutHaVe", true);
				return _cutHaVe;
			}
			set 
			{
				CanWriteProperty("CutHaVe", true);
				if (_cutHaVe != value) 
				{
					_cutHaVe = value;
					PropertyHasChanged("CutHaVe");
				}
			}
		}
		
		public String AmHo
		{
			get 
			{
				CanReadProperty("AmHo", true);
				return _amHo;
			}
			set 
			{
				CanWriteProperty("AmHo", true);
				if (_amHo != value) 
				{
					_amHo = value;
					PropertyHasChanged("AmHo");
				}
			}
		}
		
		public String AmDao
		{
			get 
			{
				CanReadProperty("AmDao", true);
				return _amDao;
			}
			set 
			{
				CanWriteProperty("AmDao", true);
				if (_amDao != value) 
				{
					_amDao = value;
					PropertyHasChanged("AmDao");
				}
			}
		}
		
		public Byte  CoTuCung
		{
			get 
			{
				CanReadProperty("CoTuCung", true);
				return _coTuCung;
			}
			set 
			{
				CanWriteProperty("CoTuCung", true);
				if (_coTuCung != value) 
				{
					_coTuCung = value;
					PropertyHasChanged("CoTuCung");
				}
			}
		}
        public Boolean CoTuCungK
        {
            get
            {
                CanReadProperty("CoTuCungK", true);
                return _coTuCungK;
            }
            set
            {
                CanWriteProperty("CoTuCungK", true);
                if (_coTuCungK != value)
                {
                    _coTuCungK = value;
                    PropertyHasChanged("CoTuCungK");
                }
            }
        }

        public Boolean CoTuCungT
        {
            get
            {
                CanReadProperty("CoTuCungT", true);
                return _coTuCungT;
            }
            set
            {
                CanWriteProperty("CoTuCungT", true);
                if (_coTuCungT != value)
                {
                    _coTuCungT = value;
                    PropertyHasChanged("CoTuCungT");
                }
            }
        }
		public String Mo
		{
			get 
			{
				CanReadProperty("Mo", true);
				return _mo;
			}
			set 
			{
				CanWriteProperty("Mo", true);
				if (_mo != value) 
				{
					_mo = value;
					PropertyHasChanged("Mo");
				}
			}
		}
		
		public String Bishop
		{
			get 
			{
				CanReadProperty("Bishop", true);
				return _bishop;
			}
			set 
			{
				CanWriteProperty("Bishop", true);
				if (_bishop != value) 
				{
					_bishop = value;
					PropertyHasChanged("Bishop");
				}
			}
		}
		
		public Boolean KhoiU
		{
			get 
			{
				CanReadProperty("KhoiU", true);
				return _khoiU;
			}
			set 
			{
				CanWriteProperty("KhoiU", true);
				if (_khoiU != value) 
				{
					_khoiU = value;
					PropertyHasChanged("KhoiU");
				}
			}
		}
        public Boolean KhoiUT
        {
            get
            {
                CanReadProperty("KhoiUT", true);
                if (_khoiU == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("KhoiUT", true);
                this._khoiUT = value;
                if (_khoiUT == true)
                    _khoiU = false;
                PropertyHasChanged("KhoiUT");

            }

        }
		
		public String KhoiUC
		{
			get 
			{
				CanReadProperty("KhoiUC", true);
				return _khoiUC;
			}
			set 
			{
				CanWriteProperty("KhoiUC", true);
				if (_khoiUC != value) 
				{
					_khoiUC = value;
					PropertyHasChanged("KhoiUC");
				}
			}
		}
		
		public Byte DauOi
		{
			get 
			{
				CanReadProperty("DauOi", true);
				return _dauOi;
			}
			set 
			{
				CanWriteProperty("DauOi", true);
				if (_dauOi != value) 
				{
					_dauOi = value;
					PropertyHasChanged("DauOi");
				}
			}
		}
        public Byte KieuOiVo
        {
            get
            {
                CanReadProperty("KieuOiVo", true);

                return _kieuOiVo ;

            }
            set
            {
                CanWriteProperty("KieuOiVo", true);
                if (_kieuOiVo != value)
                {
                    _kieuOiVo = value;

                    PropertyHasChanged("KieuOiVo");
                }
               
            }
        }
        public bool KieuOiVoT
        {
            get
            {
                CanReadProperty("KieuOiVoT", true);

                if (_kieuOiVo  == 1)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("KieuOiVoT", true);
                //if (_kieuOiVoT != value)
                //{

                //    if (value == true)
                //        _kieuOiVo = false;
                //    else
                //        _kieuOiVo= true;
                //    _kieuOiVoT = value;

                //    PropertyHasChanged("KieuOiVoT");
                //}
            }
        }
		
		public string OiVo
		{
			get 
			{
				CanReadProperty("OiVo", true);
                _oiVo.FormatString = "dd/MM/yyyy HH:mm";
				return _oiVo.Text;
			}
			set 
			{
				CanWriteProperty("OiVo", true);
				if (_oiVo.Text != value) 
				{
					_oiVo.Text = value;
					PropertyHasChanged("OiVo");
				}
			}
		}
		
		public byte MauOi
		{
			get 
			{
				CanReadProperty("MauOi", true);
				return _mauOi;
			}
			set 
			{
				CanWriteProperty("MauOi", true);
				if (_mauOi != value) 
				{
					_mauOi = value;
					PropertyHasChanged("MauOi");
				}
			}
		}
		
		public String Ngoi
		{
			get 
			{
				CanReadProperty("Ngoi", true);
				return _ngoi;
			}
			set 
			{
				CanWriteProperty("Ngoi", true);
				if (_ngoi != value) 
				{
					_ngoi = value;
					PropertyHasChanged("Ngoi");
				}
			}
		}
		
		public String The
		{
			get 
			{
				CanReadProperty("The", true);
				return _the;
			}
			set 
			{
				CanWriteProperty("The", true);
				if (_the != value) 
				{
					_the = value;
					PropertyHasChanged("The");
				}
			}
		}
		
		public Byte DoLot
		{
			get 
			{
				CanReadProperty("DoLot", true);
				return _doLot;
			}
			set 
			{
				CanWriteProperty("DoLot", true);
				if (_doLot != value) 
				{
					_doLot = value;
					PropertyHasChanged("DoLot");
				}
			}
		}
		
		public String TangSinhMon
		{
			get 
			{
				CanReadProperty("TangSinhMon", true);
				return _tangSinhMon;
			}
			set 
			{
				CanWriteProperty("TangSinhMon", true);
				if (_tangSinhMon != value) 
				{
					_tangSinhMon = value;
					PropertyHasChanged("TangSinhMon");
				}
			}
		}
		
		public String KieuThe
		{
			get 
			{
				CanReadProperty("KieuThe", true);
				return _kieuThe;
			}
			set 
			{
				CanWriteProperty("KieuThe", true);
				if (_kieuThe != value) 
				{
					_kieuThe = value;
					PropertyHasChanged("KieuThe");
				}
			}
		}
		
		public String DuongKinhNho
		{
			get 
			{
				CanReadProperty("DuongKinhNho", true);
				return _duongKinhNho;
			}
			set 
			{
				CanWriteProperty("DuongKinhNho", true);
				if (_duongKinhNho != value) 
				{
					_duongKinhNho = value;
					PropertyHasChanged("DuongKinhNho");
				}
			}
		}
		
		public String TienLuong
		{
			get 
			{
				CanReadProperty("TienLuong", true);
				return _tienLuong;
			}
			set 
			{
				CanWriteProperty("TienLuong", true);
				if (_tienLuong != value) 
				{
					_tienLuong = value;
					PropertyHasChanged("TienLuong");
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
		
		public String KhiDe
		{
			get 
			{
				CanReadProperty("KhiDe", true);
				return _khiDe;
			}
			set 
			{
				CanWriteProperty("KhiDe", true);
				if (_khiDe != value) 
				{
					_khiDe = value;
					PropertyHasChanged("KhiDe");
				}
			}
		}
		
		public String PhanBiet
		{
			get 
			{
				CanReadProperty("PhanBiet", true);
				return _phanBiet;
			}
			set 
			{
				CanWriteProperty("PhanBiet", true);
				if (_phanBiet != value) 
				{
					_phanBiet = value;
					PropertyHasChanged("PhanBiet");
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

        public Boolean KhungChauBT
        {
            get
            {
                CanReadProperty("KhungChauBT", true);

                if (_khungChau  == 1)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("KhungChauBT", true);

                if (_khungChauBT != value)
                {

                    _khungChauBT = value;

                }
                if (_khungChauBT == true)
                    _khungChau = 1;
                PropertyHasChanged("KhungChauBT");

            }
        }
        public Boolean KhungChauHep
        {
            get
            {
                CanReadProperty("KhungChauHep", true);

                if (_khungChau  == 0)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("KhungChauHep", true);

                if (_khungChauHep != value)
                {

                    _khungChauHep = value;

                }
                if (_khungChauHep == true)
                    _khungChau = 0;
                PropertyHasChanged("KhungChauHep");

            }
        }
        public Boolean KhungChauMeo
        {
            get
            {
                CanReadProperty("KhungChauMeo", true);


                if (_khungChau  == 2)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("KhungChauMeo", true);

                if (_khungChauMeo != value)
                {

                    _khungChauMeo = value;

                }
                if (_khungChauMeo == true)
                    _khungChau  = 2;
                PropertyHasChanged("KhungChauMeo");
            }
        }
        public Boolean KhungChauLech
        {
            get
            {
                CanReadProperty("KhungChauLech", true);

                if (_khungChau == 3)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("KhungChauLech", true);

                if (_khungChauLech != value)
                {

                    _khungChauLech = value;

                }
                if (_khungChauLech == true)
                    _khungChau = 3;
                PropertyHasChanged("KhungChauLech");

            }
        }

        public Boolean DauOiDet
        {
            get
            {
                CanReadProperty("DauOiDet", true);

                if (_dauOi == 1)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("DauOiDet", true);

                if (_DauOiDet != value)
                {

                    _DauOiDet = value;

                }
                if (_DauOiDet == true)
                    _dauOi = 1;
                PropertyHasChanged("DauOiDet");

            }
        }
        public Boolean DauOiPhong
        {
            get
            {
                CanReadProperty("DauOiPhong", true);

                if (_dauOi == 0)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("DauOiPhong", true);

                if (_DauOiPhong != value)
                {

                    _DauOiPhong = value;

                }
                if (_DauOiPhong == true)
                    _dauOi = 0;
                PropertyHasChanged("DauOiPhong");

            }
        }
        public Boolean DauOiQuaLe
        {
            get
            {
                CanReadProperty("DauOiQuaLe", true);


                if (_dauOi == 2)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("DauOiQuaLe", true);

                if (_DauOiQuaLe != value)
                {

                    _DauOiQuaLe = value;

                }
                if (_DauOiQuaLe == true)
                    _dauOi = 2;
                PropertyHasChanged("DauOiQuaLe");
            }
        }
        public Boolean DauOiRi
        {
            get
            {
                CanReadProperty("DauOiRi", true);

                if (_dauOi == 3)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("DauOiRi", true);

                if (_DauOiRi != value)
                {

                    _DauOiRi = value;

                }
                if (_DauOiRi == true)
                    _dauOi = 3;
                PropertyHasChanged("DauOiRi");

            }
        }
        public Boolean DauOiVo
        {
            get
            {
                CanReadProperty("DauOiVo", true);


                if (_dauOi == 4)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("DauOiVo", true);

                if (_DauOiVo != value)
                {

                    _DauOiVo = value;

                }
                if (_DauOiVo == true)
                    _dauOi = 4;
                PropertyHasChanged("DauOiVo");
            }
        }

        public Boolean DoLotLong
        {
            get
            {
                CanReadProperty("DoLotLong", true);

                if (_doLot == 1)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("DoLotLong", true);

                if (_doLotLong != value)
                {

                    _doLotLong = value;

                }
                if (_doLotLong == true)
                    _doLot  = 1;
                PropertyHasChanged("DoLotLong");

            }
        }
        public Boolean DoLotChuc
        {
            get
            {
                CanReadProperty("DoLotChuc", true);

                if (_doLot == 0)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("DoLotChuc", true);

                if (_doLotChuc != value)
                {

                    _doLotChuc = value;

                }
                if (_doLotChuc == true)
                    _doLot  = 0;
                PropertyHasChanged("DoLotChuc");

            }
        }
        public Boolean DoLotChat
        {
            get
            {
                CanReadProperty("DoLotChat", true);


                if (_doLot == 2)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("DoLotChat", true);

                if (_doLotChat != value)
                {

                    _doLotChat = value;

                }
                if (_doLotChat == true)
                    _doLot = 2;
                PropertyHasChanged("DoLotChat");
            }
        }
        public Boolean DoLotLot
        {
            get
            {
                CanReadProperty("DoLotLot", true);

                if (_doLot == 3)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("DoLotLot", true);

                if (_doLotLot != value)
                {

                    _doLotLot = value;

                }
                if (_doLotLot == true)
                    _doLot  = 3;
                PropertyHasChanged("DoLotLot");

            }
        }

        public Boolean MauOiXanh
        {
            get
            {
                CanReadProperty("MauOiXanh", true);

                if (_mauOi  == 1)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("MauOiXanh", true);

                if (_mauOiXanh  != value)
                {

                    _mauOiXanh = value;

                }
                if (_mauOiXanh == true)
                    _mauOi = 1;
                PropertyHasChanged("MauOiXanh");

            }
        }
        public Boolean MauOiTrong
        {
            get
            {
                CanReadProperty("MauOiTrong", true);

                if (_mauOi  == 0)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("MauOiTrong", true);

                if (_mauOiTrong != value)
                {

                    _mauOiTrong = value;

                }
                if (_mauOiTrong == true)
                    _mauOi = 0;
                PropertyHasChanged("MauOiTrong");

            }
        }
        public Boolean MauOiLan
        {
            get
            {
                CanReadProperty("MauOiLan", true);


                if (_mauOi  == 2)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("MauOiLan", true);

                if (_mauOiLan != value)
                {

                    _mauOiLan = value;

                }
                if (_mauOiLan == true)
                    _mauOi = 2;
                PropertyHasChanged("MauOiLan");
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
			return _maBA.ToString() + "!" + _sTT.ToString().ToString() + "!" + _sTTKhoa.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhAn_San_De" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BenhAn_San_De NewBenhAn_San_De()
        {
            return DataPortal.Create<BenhAn_San_De>();
        }
		public static BenhAn_San_De GetBenhAn_San_De(String maBA, Int32 sTT, Int32 sTTKhoa)
		{
			return DataPortal.Fetch<BenhAn_San_De>(new Criteria(maBA, sTT, sTTKhoa));
		}
		
		/// <summary>
		/// Marks the <see cref="BenhAn_San_De" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBenhAn_San_De(String maBA, Int32 sTT, Int32 sTTKhoa, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maBA, sTT, sTTKhoa));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BenhAn_San_De()
		{	
			// Prevent direct creation
		}
        internal BenhAn_San_De( 
            int OrderNumber,
            String maBA ,
		 Int32 sTT ,
		 Int32 sTTKhoa ,
		 SmartDate ngayKham ,
		 String bSKham ,
		 String lyDoKham ,
            string benhsu,
		 SmartDate ngayDe ,
		 String tenConTrai ,
		 String tenConGai ,
		 String tinhThan ,
		 String theTrang ,
		 String mach ,
		 String da ,
		 String niemMac ,
		 String apHuyet ,
		 String nhietDo ,
		 String nhipTho ,
		 String canNang ,
		 String chieuCao ,
         Byte phu,
		 String toanThan ,
		 String toanTrang ,
		 String cao ,
		 String tim ,
		 String gan ,
		 String phoi ,
		 String than ,
		 String benhKhac ,
		 String khamTai ,
		 Byte tuoiThai ,
		 Boolean tiemPhong ,
         String mui,
		 SmartDate ngayChuyenDa ,
		 String trieuTrung ,
		 String dauHieu ,
         Byte seoPTCu,
		 Boolean dauVetMo ,
		 String chieuCaoTC ,
		 String vongBung ,
		 String timThai ,
		 Boolean timThaiRo ,
		 String luongGai ,
		 String baudelocque ,
		 String luongUNgoi ,
		 String hinhDangTC ,
		 String tuThe ,
		 String conCoTC ,
		 String ngoiThai ,
		 String vu ,
		 String luongMao ,
		 String luongMau ,
		 Byte khungChau ,
		 String cutHaVe ,
		 String amHo ,
		 String amDao ,
         Byte coTuCung,
		 String mo ,
		 String bishop ,
		 Boolean khoiU ,
		 String khoiUC ,
		 Byte dauOi ,
         Byte kieuOiVo,
		 SmartDate oiVo ,
         Byte mauOi,
		 String ngoi ,
		 String the ,
		 Byte doLot ,
		 String tangSinhMon ,
		 String kieuThe ,
		 String duongKinhNho ,
		 String tienLuong ,
		 String dieuTri ,
		 String chanDoan ,
		 String khiDe ,
		 String phanBiet ,
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
             _OrderNumber = OrderNumber;
             _maBA = maBA ;
		  _sTT = sTT ;
		  _sTTKhoa = sTTKhoa ;
		  _ngayKham = ngayKham ;
		  _bSKham = bSKham ;
		  _lyDoKham = lyDoKham ;
          _benhSu = benhsu;
		  _ngayDe = ngayDe ;
		  _tenConTrai = tenConTrai ;
		  _tenConGai = tenConGai ;
		  _tinhThan = tinhThan ;
		  _theTrang = theTrang ;
		  _mach = mach ;
		  _da = da ;
		  _niemMac = niemMac ;
		  _apHuyet = apHuyet ;
		  _nhietDo = nhietDo ;
		  _nhipTho = nhipTho ;
		  _canNang = canNang ;
		  _chieuCao = chieuCao ;
		  _phu = phu ;
		  _toanThan = toanThan ;
		  _toanTrang = toanTrang ;
		  _cao = cao ;
		  _tim = tim ;
		  _gan = gan ;
		  _phoi = phoi ;
		  _than = than ;
		  _benhKhac = benhKhac ;
		  _khamTai = khamTai ;
		  _tuoiThai = tuoiThai ;
		  _tiemPhong = tiemPhong ;
		  _mui = mui ;
		  _ngayChuyenDa = ngayChuyenDa ;
		  _trieuTrung = trieuTrung ;
		  _dauHieu = dauHieu ;
		  _seoPTCu = seoPTCu ;
		  _dauVetMo = dauVetMo ;
		  _chieuCaoTC = chieuCaoTC ;
		  _vongBung = vongBung ;
		  _timThai = timThai ;
		  _timThaiRo = timThaiRo ;
		  _luongGai = luongGai ;
		  _baudelocque = baudelocque ;
		  _luongUNgoi = luongUNgoi ;
		  _hinhDangTC = hinhDangTC ;
		  _tuThe = tuThe ;
		  _conCoTC = conCoTC ;
		  _ngoiThai = ngoiThai ;
		  _vu = vu ;
		  _luongMao = luongMao ;
		  _luongMau = luongMau ;
		  _khungChau = khungChau ;
		  _cutHaVe = cutHaVe ;
		  _amHo = amHo ;
		  _amDao = amDao ;
		  _coTuCung = coTuCung ;
		  _mo = mo ;
		  _bishop = bishop ;
		  _khoiU = khoiU ;
		  _khoiUC = khoiUC ;
		  _dauOi = dauOi ;
		  _kieuOiVo = kieuOiVo ;
		  _oiVo = oiVo ;
		  _mauOi = mauOi ;
		  _ngoi = ngoi ;
		  _the = the ;
		  _doLot = doLot ;
		  _tangSinhMon = tangSinhMon ;
		  _kieuThe = kieuThe ;
		  _duongKinhNho = duongKinhNho ;
		  _tienLuong = tienLuong ;
		  _dieuTri = dieuTri ;
		  _chanDoan = chanDoan ;
		  _khiDe = khiDe ;
		  _phanBiet = phanBiet ;
		  _maMay = maMay ;
		  _huy = huy ;
		  _ngaySD = ngaySD ;
		  _nguoiSD = nguoiSD ;
		  _ngaySD1 = ngaySD1 ;
		  _nguoiSD1 = nguoiSD1 ;
          _tenBSKham = tenBSKham ;
          _tennguoiSD = tennguoiSD ;
          if (_coTuCung == 10)
          {
              _coTuCungK = true;
              _coTuCungT = false;
          }
          else if ((_coTuCung < 10) || (_coTuCung > 0))
          {
              _coTuCungT = true;
              _coTuCungK = false;
          }
          else if (_coTuCung > 10)
          {
              _coTuCungT = true;
              _coTuCungK = true;
          }
          else
          {
              _coTuCungT = false;
              _coTuCungK = false;
          }
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
		/// Retrieve an existing <see cref="BenhAn_San_De" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetBenhAn_San_De(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
			// public override IDataReader GetBenhAn_San_De(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_San_De_GET", _maBA, _sTT, _sTTKhoa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_San_De(crit.MaBA, crit.STT, crit.STTKhoa)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="BenhAn_San_De" /> Object from given SafeDataReader.
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
			if (dr.GetSmartDate("NgayDe", true) != null) _ngayDe = dr.GetSmartDate("NgayDe", true);
			if (dr.GetString("TenConTrai") != null) _tenConTrai = dr.GetString("TenConTrai");
			if (dr.GetString("TenConGai") != null) _tenConGai = dr.GetString("TenConGai");
			if (dr.GetString("TinhThan") != null) _tinhThan = dr.GetString("TinhThan");
			if (dr.GetString("TheTrang") != null) _theTrang = dr.GetString("TheTrang");
			if (dr.GetString("Mach") != null) _mach = dr.GetString("Mach");
            if (dr.GetString("Da") != null) _da = dr.GetString("Da");
            if (dr.GetString("NiemMac") != null) _niemMac = dr.GetString("NiemMac");
			if (dr.GetString("ApHuyet") != null) _apHuyet = dr.GetString("ApHuyet");
			if (dr.GetString("NhietDo") != null) _nhietDo = dr.GetString("NhietDo");
			if (dr.GetString("NhipTho") != null) _nhipTho = dr.GetString("NhipTho");
			if (dr.GetString("CanNang") != null) _canNang = dr.GetString("CanNang");
			if (dr.GetString("ChieuCao") != null) _chieuCao = dr.GetString("ChieuCao");
            if (dr.GetByte("Phu") != null) _phu = dr.GetByte("Phu");
			if (dr.GetString("ToanThan") != null) _toanThan = dr.GetString("ToanThan");
			if (dr.GetString("ToanTrang") != null) _toanTrang = dr.GetString("ToanTrang");
			if (dr.GetString("Cao") != null) _cao = dr.GetString("Cao");
			if (dr.GetString("Tim") != null) _tim = dr.GetString("Tim");
			if (dr.GetString("Gan") != null) _gan = dr.GetString("Gan");
			if (dr.GetString("Phoi") != null) _phoi = dr.GetString("Phoi");
			if (dr.GetString("Than") != null) _than = dr.GetString("Than");
			if (dr.GetString("BenhKhac") != null) _benhKhac = dr.GetString("BenhKhac");
			if (dr.GetString("KhamTai") != null) _khamTai = dr.GetString("KhamTai");
			if (dr.GetByte("TuoiThai") != null) _tuoiThai = dr.GetByte("TuoiThai");
			if (dr.GetBoolean("TiemPhong") != null) _tiemPhong = dr.GetBoolean("TiemPhong");
            if (dr.GetString("Mui") != null) _mui = dr.GetString("Mui");
			if (dr.GetSmartDate("NgayChuyenDa", true) != null) _ngayChuyenDa = dr.GetSmartDate("NgayChuyenDa", true);
			if (dr.GetString("TrieuTrung") != null) _trieuTrung = dr.GetString("TrieuTrung");
			if (dr.GetString("DauHieu") != null) _dauHieu = dr.GetString("DauHieu");
            if (dr.GetByte("SeoPTCu") != null) _seoPTCu = dr.GetByte("SeoPTCu");
			if (dr.GetBoolean("DauVetMo") != null) _dauVetMo = dr.GetBoolean("DauVetMo");
			if (dr.GetString("ChieuCaoTC") != null) _chieuCaoTC = dr.GetString("ChieuCaoTC");
			if (dr.GetString("VongBung") != null) _vongBung = dr.GetString("VongBung");
			if (dr.GetString("TimThai") != null) _timThai = dr.GetString("TimThai");
			if (dr.GetBoolean("TimThaiRo") != null) _timThaiRo = dr.GetBoolean("TimThaiRo");
			if (dr.GetString("LuongGai") != null) _luongGai = dr.GetString("LuongGai");
			if (dr.GetString("Baudelocque") != null) _baudelocque = dr.GetString("Baudelocque");
			if (dr.GetString("LuongUNgoi") != null) _luongUNgoi = dr.GetString("LuongUNgoi");
			if (dr.GetString("HinhDangTC") != null) _hinhDangTC = dr.GetString("HinhDangTC");
			if (dr.GetString("TuThe") != null) _tuThe = dr.GetString("TuThe");
			if (dr.GetString("ConCoTC") != null) _conCoTC = dr.GetString("ConCoTC");
			if (dr.GetString("NgoiThai") != null) _ngoiThai = dr.GetString("NgoiThai");
			if (dr.GetString("Vu") != null) _vu = dr.GetString("Vu");
			if (dr.GetString("LuongMao") != null) _luongMao = dr.GetString("LuongMao");
			if (dr.GetString("LuongMau") != null) _luongMau = dr.GetString("LuongMau");
			if (dr.GetByte("KhungChau") != null) _khungChau = dr.GetByte("KhungChau");
			if (dr.GetString("CutHaVe") != null) _cutHaVe = dr.GetString("CutHaVe");
			if (dr.GetString("AmHo") != null) _amHo = dr.GetString("AmHo");
			if (dr.GetString("AmDao") != null) _amDao = dr.GetString("AmDao");
            if (dr.GetByte("CoTuCung") != null) _coTuCung = dr.GetByte("CoTuCung");
            if (_coTuCung == 10)
            {
                _coTuCungK = true;
                _coTuCungT = false;
            }
            else if ((_coTuCung < 10) || (_coTuCung >0))
            { _coTuCungT = true;
                _coTuCungK = false;
            }
            else if (_coTuCung > 10)
            {
                _coTuCungT = true;
                _coTuCungK = true;
            }
            else
            {
                _coTuCungT = false;
                _coTuCungK = false;
            }
                if (dr.GetString("Mo") != null) _mo = dr.GetString("Mo");
			if (dr.GetString("Bishop") != null) _bishop = dr.GetString("Bishop");
			if (dr.GetBoolean("KhoiU") != null) _khoiU = dr.GetBoolean("KhoiU");
			if (dr.GetString("KhoiUC") != null) _khoiUC = dr.GetString("KhoiUC");
			if (dr.GetByte("DauOi") != null) _dauOi = dr.GetByte("DauOi");
            if (dr.GetByte("KieuOiVo") != null) _kieuOiVo = dr.GetByte("KieuOiVo");
			if (dr.GetSmartDate("OiVo", true) != null) _oiVo = dr.GetSmartDate("OiVo", true);
			if (dr.GetByte("MauOi") != null) _mauOi = dr.GetByte("MauOi");
			if (dr.GetString("Ngoi") != null) _ngoi = dr.GetString("Ngoi");
			if (dr.GetString("The") != null) _the = dr.GetString("The");
			if (dr.GetByte("DoLot") != null) _doLot = dr.GetByte("DoLot");
			if (dr.GetString("TangSinhMon") != null) _tangSinhMon = dr.GetString("TangSinhMon");
			if (dr.GetString("KieuThe") != null) _kieuThe = dr.GetString("KieuThe");
			if (dr.GetString("DuongKinhNho") != null) _duongKinhNho = dr.GetString("DuongKinhNho");
			if (dr.GetString("TienLuong") != null) _tienLuong = dr.GetString("TienLuong");
			if (dr.GetString("DieuTri") != null) _dieuTri = dr.GetString("DieuTri");
			if (dr.GetString("ChanDoan") != null) _chanDoan = dr.GetString("ChanDoan");
			if (dr.GetString("KhiDe") != null) _khiDe = dr.GetString("KhiDe");
			if (dr.GetString("PhanBiet") != null) _phanBiet = dr.GetString("PhanBiet");
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
		/// Insert the new <see cref="BenhAn_San_De" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_San_De
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
			_maBA = DataProvider.Instance().InsertBenhAn_San_De(_maBA, _sTTKhoa, _ngayKham, _bSKham, _lyDoKham,_benhSu , _ngayDe, _tenConTrai, _tenConGai, _tinhThan, _theTrang, _mach, _da, _niemMac, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _toanThan, _toanTrang, _cao, _tim, _gan, _phoi, _than, _benhKhac, _khamTai, _tuoiThai, _tiemPhong, _mui, _ngayChuyenDa, _trieuTrung, _dauHieu, _seoPTCu, _dauVetMo, _chieuCaoTC, _vongBung, _timThai, _timThaiRo, _luongGai, _baudelocque, _luongUNgoi, _hinhDangTC, _tuThe, _conCoTC, _ngoiThai, _vu, _luongMao, _luongMau, _khungChau, _cutHaVe, _amHo, _amDao, _coTuCung, _mo, _bishop, _khoiU, _khoiUC, _dauOi, _kieuOiVo, _oiVo, _mauOi, _ngoi, _the, _doLot, _tangSinhMon, _kieuThe, _duongKinhNho, _tienLuong, _dieuTri, _chanDoan, _khiDe, _phanBiet, _maMay, _nguoiSD);
			// public abstract String InsertBenhAn_San_De(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, SmartDate _ngayDe, String _tenConTrai, String _tenConGai, String _tinhThan, String _theTrang, String _mach, String _da, String _niemMac, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, String _khamTai, Byte _tuoiThai, Boolean _tiemPhong, Byte _mui, SmartDate _ngayChuyenDa, String _trieuTrung, String _dauHieu, Boolean _seoPTCu, Boolean _dauVetMo, String _chieuCaoTC, String _vongBung, String _timThai, Boolean _timThaiRo, String _luongGai, String _baudelocque, String _luongUNgoi, String _hinhDangTC, String _tuThe, String _conCoTC, String _ngoiThai, String _vu, String _luongMao, String _luongMau, Byte _khungChau, String _cutHaVe, String _amHo, String _amDao, Boolean _coTuCung, String _mo, String _bishop, Boolean _khoiU, String _khoiUC, Byte _dauOi, Byte _kieuOiVo, SmartDate _oiVo, String _mauOi, String _ngoi, String _the, Byte _doLot, String _tangSinhMon, String _kieuThe, String _duongKinhNho, String _tienLuong, String _dieuTri, String _chanDoan, String _khiDe, String _phanBiet, String _maMay, String _nguoiSD);
			// public override String InsertBenhAn_San_De(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, SmartDate _ngayDe, String _tenConTrai, String _tenConGai, String _tinhThan, String _theTrang, String _mach, String _da, String _niemMac, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, String _khamTai, Byte _tuoiThai, Boolean _tiemPhong, Byte _mui, SmartDate _ngayChuyenDa, String _trieuTrung, String _dauHieu, Boolean _seoPTCu, Boolean _dauVetMo, String _chieuCaoTC, String _vongBung, String _timThai, Boolean _timThaiRo, String _luongGai, String _baudelocque, String _luongUNgoi, String _hinhDangTC, String _tuThe, String _conCoTC, String _ngoiThai, String _vu, String _luongMao, String _luongMau, Byte _khungChau, String _cutHaVe, String _amHo, String _amDao, Boolean _coTuCung, String _mo, String _bishop, Boolean _khoiU, String _khoiUC, Byte _dauOi, Byte _kieuOiVo, SmartDate _oiVo, String _mauOi, String _ngoi, String _the, Byte _doLot, String _tangSinhMon, String _kieuThe, String _duongKinhNho, String _tienLuong, String _dieuTri, String _chanDoan, String _khiDe, String _phanBiet, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_San_De_CREATE", _maBA, _sTT, _sTTKhoa, _ngayKham.DBValue, _bSKham, _lyDoKham, _ngayDe.DBValue, _tenConTrai, _tenConGai, _tinhThan, _theTrang, _mach, _da, _niemMac, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _toanThan, _toanTrang, _cao, _tim, _gan, _phoi, _than, _benhKhac, _khamTai, _tuoiThai, _tiemPhong, _mui, _ngayChuyenDa.DBValue, _trieuTrung, _dauHieu, _seoPTCu, _dauVetMo, _chieuCaoTC, _vongBung, _timThai, _timThaiRo, _luongGai, _baudelocque, _luongUNgoi, _hinhDangTC, _tuThe, _conCoTC, _ngoiThai, _vu, _luongMao, _luongMau, _khungChau, _cutHaVe, _amHo, _amDao, _coTuCung, _mo, _bishop, _khoiU, _khoiUC, _dauOi, _kieuOiVo, _oiVo.DBValue, _mauOi, _ngoi, _the, _doLot, _tangSinhMon, _kieuThe, _duongKinhNho, _tienLuong, _dieuTri, _chanDoan, _khiDe, _phanBiet, _maMay, _nguoiSD));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAn_San_De" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_San_De
			if (IsDirty){
                
                  
				DataProvider.Instance().UpdateBenhAn_San_De(_maBA, _sTT, _sTTKhoa, _ngayKham, _bSKham, _lyDoKham,_benhSu , _ngayDe, _tenConTrai, _tenConGai, _tinhThan, _theTrang, _mach, _da, _niemMac, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _toanThan, _toanTrang, _cao, _tim, _gan, _phoi, _than, _benhKhac, _khamTai, _tuoiThai, _tiemPhong, _mui, _ngayChuyenDa, _trieuTrung, _dauHieu, _seoPTCu, _dauVetMo, _chieuCaoTC, _vongBung, _timThai, _timThaiRo, _luongGai, _baudelocque, _luongUNgoi, _hinhDangTC, _tuThe, _conCoTC, _ngoiThai, _vu, _luongMao, _luongMau, _khungChau, _cutHaVe, _amHo, _amDao, _coTuCung, _mo, _bishop, _khoiU, _khoiUC, _dauOi, _kieuOiVo, _oiVo, _mauOi, _ngoi, _the, _doLot, _tangSinhMon, _kieuThe, _duongKinhNho, _tienLuong, _dieuTri, _chanDoan, _khiDe, _phanBiet, _maMay, _huy, _nguoiSD);
				// public abstract void UpdateBenhAn_San_De(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, SmartDate _ngayDe, String _tenConTrai, String _tenConGai, String _tinhThan, String _theTrang, String _mach, String _da, String _niemMac, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, String _khamTai, Byte _tuoiThai, Boolean _tiemPhong, Byte _mui, SmartDate _ngayChuyenDa, String _trieuTrung, String _dauHieu, Boolean _seoPTCu, Boolean _dauVetMo, String _chieuCaoTC, String _vongBung, String _timThai, Boolean _timThaiRo, String _luongGai, String _baudelocque, String _luongUNgoi, String _hinhDangTC, String _tuThe, String _conCoTC, String _ngoiThai, String _vu, String _luongMao, String _luongMau, Byte _khungChau, String _cutHaVe, String _amHo, String _amDao, Boolean _coTuCung, String _mo, String _bishop, Boolean _khoiU, String _khoiUC, Byte _dauOi, Byte _kieuOiVo, SmartDate _oiVo, String _mauOi, String _ngoi, String _the, Byte _doLot, String _tangSinhMon, String _kieuThe, String _duongKinhNho, String _tienLuong, String _dieuTri, String _chanDoan, String _khiDe, String _phanBiet, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateBenhAn_San_De(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, SmartDate _ngayDe, String _tenConTrai, String _tenConGai, String _tinhThan, String _theTrang, String _mach, String _da, String _niemMac, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, String _khamTai, Byte _tuoiThai, Boolean _tiemPhong, Byte _mui, SmartDate _ngayChuyenDa, String _trieuTrung, String _dauHieu, Boolean _seoPTCu, Boolean _dauVetMo, String _chieuCaoTC, String _vongBung, String _timThai, Boolean _timThaiRo, String _luongGai, String _baudelocque, String _luongUNgoi, String _hinhDangTC, String _tuThe, String _conCoTC, String _ngoiThai, String _vu, String _luongMao, String _luongMau, Byte _khungChau, String _cutHaVe, String _amHo, String _amDao, Boolean _coTuCung, String _mo, String _bishop, Boolean _khoiU, String _khoiUC, Byte _dauOi, Byte _kieuOiVo, SmartDate _oiVo, String _mauOi, String _ngoi, String _the, Byte _doLot, String _tangSinhMon, String _kieuThe, String _duongKinhNho, String _tienLuong, String _dieuTri, String _chanDoan, String _khiDe, String _phanBiet, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_San_De_UPDATE", _maBA, _sTT, _sTTKhoa, _ngayKham.DBValue, _bSKham, _lyDoKham, _ngayDe.DBValue, _tenConTrai, _tenConGai, _tinhThan, _theTrang, _mach, _da, _niemMac, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _toanThan, _toanTrang, _cao, _tim, _gan, _phoi, _than, _benhKhac, _khamTai, _tuoiThai, _tiemPhong, _mui, _ngayChuyenDa.DBValue, _trieuTrung, _dauHieu, _seoPTCu, _dauVetMo, _chieuCaoTC, _vongBung, _timThai, _timThaiRo, _luongGai, _baudelocque, _luongUNgoi, _hinhDangTC, _tuThe, _conCoTC, _ngoiThai, _vu, _luongMao, _luongMau, _khungChau, _cutHaVe, _amHo, _amDao, _coTuCung, _mo, _bishop, _khoiU, _khoiUC, _dauOi, _kieuOiVo, _oiVo.DBValue, _mauOi, _ngoi, _the, _doLot, _tangSinhMon, _kieuThe, _duongKinhNho, _tienLuong, _dieuTri, _chanDoan, _khiDe, _phanBiet, _maMay, _huy, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maBA, _sTT, _sTTKhoa));
		}

		/// <summary>
		/// Delete the <see cref="BenhAn_San_De" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_San_De
            DataProvider.Instance().DeleteBenhAn_San_De(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.STT, crit.STTKhoa);
			// public abstract void DeleteBenhAn_San_De(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
			// public override void DeleteBenhAn_San_De(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_San_De_Deleted", _maBA, _sTT, _sTTKhoa);
			// }
		}

		#endregion
	}

}
