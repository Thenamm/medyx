// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	KhamBenh_San
// Kieu doi tuong  :	KhamBenh_San
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
////
using HTC.Business.CategoryList;

namespace HTC.Business.PhongKham
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="KhamBenh_San" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class KhamBenh_San : BusinessBase<KhamBenh_San>
	{
		#region Business Methods
		
		#region State Fields
        private String _mabhxh = String.Empty;
        private String _tenBV = String.Empty;
		private String _MaSoKham = String.Empty;
		private Int32 _sTT = 0;
        //private Int32 _sTTKhoa = 0;
		private SmartDate _ngayKham = new SmartDate(true);
        private String _maDV = String.Empty;
        private SmartDate _ngayKhamD = new SmartDate(true);
		private String _bSKHAM = String.Empty;

		private String _lyDoKham = String.Empty;
		private String _mach = String.Empty;
		private String _apHuyet = String.Empty;
		private String _nhietDo = String.Empty;
		private String _nhipTho = String.Empty;
		private String _canNang = String.Empty;
		private String _chieuCao = String.Empty;

        private Boolean _phu = false;
        private String _toanThan = String.Empty;
        private String _toanTrang = String.Empty;
        private String _cao = String.Empty;
        private String _tim = String.Empty;
        private String _gan = String.Empty;
        private String _phoi = String.Empty;
        private String _than = String.Empty;
        private String _benhKhac = String.Empty;
        private Boolean _seoPTCu = false;
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
        private String _vu = String.Empty;
        private String _luongMao = String.Empty;
        private String _luongMau = String.Empty;
        private String _cutHaVe = String.Empty;
        private String _amHo = String.Empty;
        private String _amDao = String.Empty;
        private String _coTuCung = String.Empty;
        private String _phanPhu = String.Empty;
        private SmartDate _oiVo = new SmartDate(true);
        private String _mauOi = String.Empty;
        private String _ngoi = String.Empty;
        private String _the = String.Empty;
        private String _doLot = String.Empty;
        private String _tangSinhMon = String.Empty;
        private String _tinhTrangOi = String.Empty;
        private String _oivoTuNhien = String.Empty;
        private String _luongNuocOi = String.Empty;
        private String _kieuThe = String.Empty;
        private String _duongKinhNho = String.Empty;
        private String _tomTat = String.Empty;

		private String _dieuTri = String.Empty;
		private String _benhSu = String.Empty;
		private String _huongDT = String.Empty;
		private String _mabenh = String.Empty;
		private String _maBenhKem = String.Empty;
		private String _MaBV = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
        private String _tenBenh = String.Empty;
        private String _tenBenhKem = String.Empty;
        private String _maICD = String.Empty;
        private String _maICDKem = String.Empty;
        private String _tenBSKham = String.Empty;
        private String _tennguoiSD = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
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
		public String MaSoKham
		{
			get 
			{
				CanReadProperty("MaSoKham", true);
				return _MaSoKham;
			}
			set 
			{
				CanWriteProperty("MaSoKham", true);
				if (_MaSoKham != value) 
				{
					_MaSoKham = value;
					PropertyHasChanged("MaSoKham");
				}
			}
		}
        //public string NgayKhamD
        //{
        //    get
        //    {
        //        CanReadProperty("NgayKhamD", true);
        //        _ngayKhamD = _ngayKham;
        //        _ngayKhamD.FormatString = "dd/MM/yyyy HH:mm";

        //        return _ngayKhamD.Text;
        //    }

        //}
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

        public Boolean SeoPTCu
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

        public String CoTuCung
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
        public String PhanPhu
        {
            get
            {
                CanReadProperty("PhanPhu", true);
                return _phanPhu;
            }
            set
            {
                CanWriteProperty("PhanPhu", true);
                if (_phanPhu != value)
                {
                    _phanPhu = value;
                    PropertyHasChanged("PhanPhu");
                }
            }
        }

        //public string OiVo
        //{
        //    get
        //    {
        //        CanReadProperty("OiVo", true);
        //        return _oiVo.Text;
        //    }
        //    set
        //    {
        //        CanWriteProperty("OiVo", true);
        //        if (_oiVo.Text != value)
        //        {
        //            _oiVo.Text = value;
        //            PropertyHasChanged("OiVo");
        //        }
        //    }
        //}
        public DateTime  OiVo
        {
            get
            {
                CanReadProperty("OiVo", true);
                return _oiVo.Date ;
            }
            set
            {
                CanWriteProperty("OiVo", true);
                if (_oiVo.Date  != value)
                {
                    _oiVo.Date  = value ;
                    PropertyHasChanged("OiVo");
                }
            }
        }
        public String MauOi
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

        public String DoLot
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

        public String TinhTrangOi
        {
            get
            {
                CanReadProperty("TinhTrangOi", true);
                return _tinhTrangOi;
            }
            set
            {
                CanWriteProperty("TinhTrangOi", true);
                if (_tinhTrangOi != value)
                {
                    _tinhTrangOi = value;
                    PropertyHasChanged("TinhTrangOi");
                }
            }
        }

        public String OivoTuNhien
        {
            get
            {
                CanReadProperty("OivoTuNhien", true);
                return _oivoTuNhien;
            }
            set
            {
                CanWriteProperty("OivoTuNhien", true);
                if (_oivoTuNhien != value)
                {
                    _oivoTuNhien = value;
                    PropertyHasChanged("OivoTuNhien");
                }
            }
        }

        public String LuongNuocOi
        {
            get
            {
                CanReadProperty("LuongNuocOi", true);
                return _luongNuocOi;
            }
            set
            {
                CanWriteProperty("LuongNuocOi", true);
                if (_luongNuocOi != value)
                {
                    _luongNuocOi = value;
                    PropertyHasChanged("LuongNuocOi");
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

        public String TomTat
        {
            get
            {
                CanReadProperty("TomTat", true);
                return _tomTat;
            }
            set
            {
                CanWriteProperty("TomTat", true);
                if (_tomTat != value)
                {
                    _tomTat = value;
                    PropertyHasChanged("TomTat");
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
		
		public String MaBV
		{
			get 
			{
				CanReadProperty("MaBV", true);
				return _MaBV;
			}
			set 
			{
				CanWriteProperty("MaBV", true);
				if (_MaBV != value) 
				{
					_MaBV = value;
					PropertyHasChanged("MaBV");
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
        public String TenBenh
        {
            get
            {
                CanReadProperty("TenBenh", true);
                return _tenBenh;
            }
            set
            {
                CanWriteProperty("TenBenh", true);
                if (_tenBenh != value)
                {
                    _tenBenh = value;
                    PropertyHasChanged("TenBenh");
                }
            }
        }
        public String TenBenhKem
        {
            get
            {
                CanReadProperty("TenBenhKem", true);
                return _tenBenhKem;
            }
            set
            {
                CanWriteProperty("TenBenhKem", true);
                if (_tenBenhKem != value)
                {
                    _tenBenhKem = value;
                    PropertyHasChanged("TenBenhKem");
                }
            }
        }
        public String MaICD
        {
            get
            {
                CanReadProperty("MaICD", true);
                return _maICD;
            }
            set
            {
                CanWriteProperty("MaICD", true);
                if (_maICD != value)
                {
                    _maICD = value;
                    PropertyHasChanged("MaICD");
                }
            }
        }
        public String MaICDKem
        {
            get
            {
                CanReadProperty("MaICDKem", true);
                return _maICDKem;
            }
            set
            {
                CanWriteProperty("MaICDKem", true);
                if (_maICDKem != value)
                {
                    _maICDKem = value;
                    PropertyHasChanged("MaICDKem");
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

        //public String TenNguoiSD
        //{
        //    get
        //    {
        //        CanReadProperty("TenNguoiSD", true);
        //        return _tennguoiSD;
        //    }
        //    set
        //    {
        //        CanWriteProperty("TenNguoiSD", true);
        //        if (_tennguoiSD != value)
        //        {
        //            _tennguoiSD = value;
        //            PropertyHasChanged("TenNguoiSD");
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
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                }
            }
        }
		protected override Object GetIdValue()
		{
			return _MaSoKham.ToString() + "!" + _sTT.ToString().ToString() + "!" ;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="KhamBenh_San" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 

        public static KhamBenh_San NewKhamBenh_San()
        {
            return new KhamBenh_San();
            //return DataPortal.Create<DMDichVu_PhieuIn_C>();
        }
        public static KhamBenh_San NewKhamBenh_San(string idDMDichvu)
        {
            return new KhamBenh_San(DMDichVu.GetDMDichVu(idDMDichvu));
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static KhamBenh_San NewKhamBenh_San(DMDichVu _DMDichvu)
        {
            return new KhamBenh_San(_DMDichvu);
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static KhamBenh_San NewKhamBenh_San(string masokham, Int32 stt, string idDMDichvu)
        {
            return new KhamBenh_San(masokham, stt, idDMDichvu);
        }

        public static KhamBenh_San GetKhamBenh_San(String maSoKham, Int32 sTT)
        {
            return DataPortal.Fetch<KhamBenh_San>(new Criteria(maSoKham, sTT));
        }

        public static KhamBenh_San GetKhamBenh_San(SafeDataReader dr)
        {
            return new KhamBenh_San(dr);
        }

        /// <summary>
        /// Marks the <see cref="KhamBenh_San" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteKhamBenh_San(String maSoKham, Int32 sTT, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maSoKham, sTT));
        }

        #endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal KhamBenh_San()
		{	
			// Prevent direct creation
		}
		
        protected KhamBenh_San(DMDichVu pro)
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
        protected KhamBenh_San(string maSoKham,DMDichVu pro)
        {
            MarkAsChild();

            _MaSoKham = maSoKham;
            _maDV = pro.MaDV;
            _maMay = pro.MaMay;
            _huy = pro.Huy;
            // _ngaySD = pro.NgaySD ;
            _nguoiSD = pro.NguoiSD;
          //  _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_San(string masokham, Int32 stt, string idDMDichvu)
        {
            MarkAsChild();

            _MaSoKham = masokham ;
            _maDV = idDMDichvu ;
            _sTT = stt;
            //  _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_San(SafeDataReader dr)
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
			private String _MaSoKham;
			public String MaSoKham 
			{
				get
				{
					return _MaSoKham;
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
			
			
			
			public Criteria(String MaSoKham, Int32 sTT)
			{
				_MaSoKham = MaSoKham;
				_sTT = sTT;
				
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_MaSoKham.Equals(c._MaSoKham)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
                    //if (!_sTTKhoa.Equals(c._sTTKhoa)) 
                    //    return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _MaSoKham.ToString(), _sTT.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaSoKham;
            public String MaSoKham
            {
                get
                {
                    return _MaSoKham;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaSoKham, Int32 sTT)
            {
                _MaSoKham = MaSoKham;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _sTT = sTT;
               

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
		/// Retrieve an existing <see cref="KhamBenh_San" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetKhamBenh_San(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa);
			// public override IDataReader GetKhamBenh_San(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_San_GET", _MaSoKham, _sTT, _sTTKhoa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKhamBenh_San(crit.MaSoKham, crit.STT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="KhamBenh_San" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaSoKham") != null) _MaSoKham = dr.GetString("MaSoKham");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
          
            //if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
			if (dr.GetSmartDate("NgayKham", true) != null) _ngayKham = dr.GetSmartDate("NgayKham", true);
			if (dr.GetString("BSKHAM") != null) _bSKHAM = dr.GetString("BSKHAM");
			if (dr.GetString("LyDoKham") != null) _lyDoKham = dr.GetString("LyDoKham");
			if (dr.GetString("Mach") != null) _mach = dr.GetString("Mach");
			if (dr.GetString("ApHuyet") != null) _apHuyet = dr.GetString("ApHuyet");
			if (dr.GetString("NhietDo") != null) _nhietDo = dr.GetString("NhietDo");
			if (dr.GetString("NhipTho") != null) _nhipTho = dr.GetString("NhipTho");
			if (dr.GetString("CanNang") != null) _canNang = dr.GetString("CanNang");
			if (dr.GetString("ChieuCao") != null) _chieuCao = dr.GetString("ChieuCao");

            if (dr.GetBoolean("Phu") != null) _phu = dr.GetBoolean("Phu");
            if (dr.GetString("ToanThan") != null) _toanThan = dr.GetString("ToanThan");
            if (dr.GetString("ToanTrang") != null) _toanTrang = dr.GetString("ToanTrang");
            if (dr.GetString("Cao") != null) _cao = dr.GetString("Cao");
            if (dr.GetString("Tim") != null) _tim = dr.GetString("Tim");
            if (dr.GetString("Gan") != null) _gan = dr.GetString("Gan");
            if (dr.GetString("Phoi") != null) _phoi = dr.GetString("Phoi");
            if (dr.GetString("Than") != null) _than = dr.GetString("Than");
            if (dr.GetString("BenhKhac") != null) _benhKhac = dr.GetString("BenhKhac");
            if (dr.GetBoolean("SeoPTCu") != null) _seoPTCu = dr.GetBoolean("SeoPTCu");
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
            if (dr.GetString("Vu") != null) _vu = dr.GetString("Vu");
            if (dr.GetString("LuongMao") != null) _luongMao = dr.GetString("LuongMao");
            if (dr.GetString("LuongMau") != null) _luongMau = dr.GetString("LuongMau");
            if (dr.GetString("CutHaVe") != null) _cutHaVe = dr.GetString("CutHaVe");
            if (dr.GetString("AmHo") != null) _amHo = dr.GetString("AmHo");
            if (dr.GetString("AmDao") != null) _amDao = dr.GetString("AmDao");
            if (dr.GetString("CoTuCung") != null) _coTuCung = dr.GetString("CoTuCung");
            if (dr.GetString("PhanPhu") != null) _phanPhu = dr.GetString("PhanPhu");
            if (dr.GetSmartDate("OiVo", true) != null) _oiVo = dr.GetSmartDate("OiVo", true);
            if (dr.GetString("MauOi") != null) _mauOi = dr.GetString("MauOi");
            if (dr.GetString("Ngoi") != null) _ngoi = dr.GetString("Ngoi");
            if (dr.GetString("The") != null) _the = dr.GetString("The");
            if (dr.GetString("DoLot") != null) _doLot = dr.GetString("DoLot");
            if (dr.GetString("TangSinhMon") != null) _tangSinhMon = dr.GetString("TangSinhMon");
            if (dr.GetString("TinhTrangOi") != null) _tinhTrangOi = dr.GetString("TinhTrangOi");
            if (dr.GetString("OivoTuNhien") != null) _oivoTuNhien = dr.GetString("OivoTuNhien");
            if (dr.GetString("LuongNuocOi") != null) _luongNuocOi = dr.GetString("LuongNuocOi");
            if (dr.GetString("KieuThe") != null) _kieuThe = dr.GetString("KieuThe");
            if (dr.GetString("DuongKinhNho") != null) _duongKinhNho = dr.GetString("DuongKinhNho");
            if (dr.GetString("TomTat") != null) _tomTat = dr.GetString("TomTat");
            if (dr.GetString("mabhxh") != null) _mabhxh = dr.GetString("mabhxh");
            if (dr.GetString("tenBV") != null) _tenBV = dr.GetString("tenBV");
            if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
			if (dr.GetString("DieuTri") != null) _dieuTri = dr.GetString("DieuTri");
			if (dr.GetString("BenhSu") != null) _benhSu = dr.GetString("BenhSu");
			if (dr.GetString("HuongDT") != null) _huongDT = dr.GetString("HuongDT");
			if (dr.GetString("Mabenh") != null) _mabenh = dr.GetString("Mabenh");
			if (dr.GetString("MaBenhKem") != null) _maBenhKem = dr.GetString("MaBenhKem");
			if (dr.GetString("MaBV") != null) _MaBV = dr.GetString("MaBV");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetString("TenBenh") != null) _tenBenh = dr.GetString("TenBenh");
            if (dr.GetString("TenBenhKem") != null) _tenBenhKem = dr.GetString("TenBenhKem");
            if (dr.GetString("MaICD") != null) _maICD = dr.GetString("MaICD");
            if (dr.GetString("TenBSKham") != null) _tenBSKham = dr.GetString("TenBSKham");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");
        }
		
		/// <summary>
		/// Insert the new <see cref="KhamBenh_San" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh_San
			// Copy & paste ham duoi day vao file DataProvider.cs

            _MaSoKham = DataProvider.Instance().InsertKhamBenh_San(_MaSoKham, _sTT, _maDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _toanThan, _toanTrang, _cao, _tim, _gan, _phoi, _than, _benhKhac, _seoPTCu, _chieuCaoTC, _vongBung, _timThai, _timThaiRo, _luongGai, _baudelocque, _luongUNgoi, _hinhDangTC, _tuThe, _conCoTC, _vu, _luongMao, _luongMau, _cutHaVe, _amHo, _amDao, _coTuCung, _phanPhu, _oiVo, _mauOi, _ngoi, _the, _doLot, _tangSinhMon, _tinhTrangOi, _oivoTuNhien, _luongNuocOi, _kieuThe, _duongKinhNho, _tomTat, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV, _maMay , _nguoiSD);
            MarkOld(); // public abstract String InsertKhamBenh_San(String _MaSoKham, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, Boolean _seoPTCu, String _chieuCaoTC, String _vongBung, String _timThai, Boolean _timThaiRo, String _luongGai, String _baudelocque, String _luongUNgoi, String _hinhDangTC, String _tuThe, String _conCoTC, String _vu, String _luongMao, String _luongMau, String _cutHaVe, String _amHo, String _amDao, String _coTuCung, SmartDate _oiVo, String _mauOi, String _ngoi, String _the, String _doLot, String _tangSinhMon, String _tinhTrangOi, String _oivoTuNhien, String _luongNuocOi, String _kieuThe, String _duongKinhNho, String _tomTat, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD);
            // public override String InsertKhamBenh_San(String _MaSoKham, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, Boolean _seoPTCu, String _chieuCaoTC, String _vongBung, String _timThai, Boolean _timThaiRo, String _luongGai, String _baudelocque, String _luongUNgoi, String _hinhDangTC, String _tuThe, String _conCoTC, String _vu, String _luongMao, String _luongMau, String _cutHaVe, String _amHo, String _amDao, String _coTuCung, SmartDate _oiVo, String _mauOi, String _ngoi, String _the, String _doLot, String _tangSinhMon, String _tinhTrangOi, String _oivoTuNhien, String _luongNuocOi, String _kieuThe, String _duongKinhNho, String _tomTat, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD)

			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_San_CREATE", _MaSoKham, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _toanThan, _toanTrang, _cao, _tim, _gan, _phoi, _than, _benhKhac, _seoPTCu, _chieuCaoTC, _vongBung, _timThai, _timThaiRo, _luongGai, _baudelocque, _luongUNgoi, _hinhDangTC, _tuThe, _conCoTC, _vu, _luongMao, _luongMau, _cutHaVe, _amHo, _amDao, _coTuCung, _oiVo, _mauOi, _ngoi, _the, _doLot, _tangSinhMon, _tinhTrangOi, _oivoTuNhien, _luongNuocOi, _kieuThe, _duongKinhNho, _tomTat, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV,_maMay ,   _huy, _ngaySD.DBValue,_nguoiSD , _ngaySD1.DBValue, _nguoiSD1), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="KhamBenh_San" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_San
			if (IsDirty){

                DataProvider.Instance().UpdateKhamBenh_San(_MaSoKham, _sTT, _maDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _toanThan, _toanTrang, _cao, _tim, _gan, _phoi, _than, _benhKhac, _seoPTCu, _chieuCaoTC, _vongBung, _timThai, _timThaiRo, _luongGai, _baudelocque, _luongUNgoi, _hinhDangTC, _tuThe, _conCoTC, _vu, _luongMao, _luongMau, _cutHaVe, _amHo, _amDao, _coTuCung,_phanPhu , _oiVo, _mauOi, _ngoi, _the, _doLot, _tangSinhMon, _tinhTrangOi, _oivoTuNhien, _luongNuocOi, _kieuThe, _duongKinhNho, _tomTat, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV,_maMay ,   _huy, _nguoiSD );
                // public abstract void UpdateKhamBenh_San(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, Boolean _seoPTCu, String _chieuCaoTC, String _vongBung, String _timThai, Boolean _timThaiRo, String _luongGai, String _baudelocque, String _luongUNgoi, String _hinhDangTC, String _tuThe, String _conCoTC, String _vu, String _luongMao, String _luongMau, String _cutHaVe, String _amHo, String _amDao, String _coTuCung, SmartDate _oiVo, String _mauOi, String _ngoi, String _the, String _doLot, String _tangSinhMon, String _tinhTrangOi, String _oivoTuNhien, String _luongNuocOi, String _kieuThe, String _duongKinhNho, String _tomTat, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD);
                // public override void UpdateKhamBenh_San(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, Boolean _seoPTCu, String _chieuCaoTC, String _vongBung, String _timThai, Boolean _timThaiRo, String _luongGai, String _baudelocque, String _luongUNgoi, String _hinhDangTC, String _tuThe, String _conCoTC, String _vu, String _luongMao, String _luongMau, String _cutHaVe, String _amHo, String _amDao, String _coTuCung, SmartDate _oiVo, String _mauOi, String _ngoi, String _the, String _doLot, String _tangSinhMon, String _tinhTrangOi, String _oivoTuNhien, String _luongNuocOi, String _kieuThe, String _duongKinhNho, String _tomTat, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD)

				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_San_UPDATE", _MaSoKham, _sTT, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _toanThan, _toanTrang, _cao, _tim, _gan, _phoi, _than, _benhKhac, _seoPTCu, _chieuCaoTC, _vongBung, _timThai, _timThaiRo, _luongGai, _baudelocque, _luongUNgoi, _hinhDangTC, _tuThe, _conCoTC, _vu, _luongMao, _luongMau, _cutHaVe, _amHo, _amDao, _coTuCung, _oiVo, _mauOi, _ngoi, _the, _doLot, _tangSinhMon, _tinhTrangOi, _oivoTuNhien, _luongNuocOi, _kieuThe, _duongKinhNho, _tomTat, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV,_maMay ,   _huy, _nguoiSD );
				// }	
                MarkOld();
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD    , _MaSoKham, _sTT));
		}

		/// <summary>
		/// Delete the <see cref="KhamBenh_San" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_San
            DataProvider.Instance().DeleteKhamBenh_San(crit.MaMay, crit.NguoiSD, crit.MaSoKham, crit.STT);
			// public abstract void DeleteKhamBenh_San(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa);
			// public override void DeleteKhamBenh_San(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_San_Deleted", _MaSoKham, _sTT, _sTTKhoa);
			// }
		}

        internal virtual void Insert(KhamBenh_C obj)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh_San
            // Copy & paste ham duoi day vao file DataProvider.cs

            _MaSoKham = DataProvider.Instance().InsertKhamBenh_San(obj.MaSoKham, obj.STT, obj.MaDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _toanThan, _toanTrang, _cao, _tim, _gan, _phoi, _than, _benhKhac, _seoPTCu, _chieuCaoTC, _vongBung, _timThai, _timThaiRo, _luongGai, _baudelocque, _luongUNgoi, _hinhDangTC, _tuThe, _conCoTC, _vu, _luongMao, _luongMau, _cutHaVe, _amHo, _amDao, _coTuCung, _phanPhu, _oiVo, _mauOi, _ngoi, _the, _doLot, _tangSinhMon, _tinhTrangOi, _oivoTuNhien, _luongNuocOi, _kieuThe, _duongKinhNho, _tomTat, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV, _maMay , _nguoiSD);
            MarkOld(); // public abstract String InsertKhamBenh_San(String _MaSoKham, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, Boolean _seoPTCu, String _chieuCaoTC, String _vongBung, String _timThai, Boolean _timThaiRo, String _luongGai, String _baudelocque, String _luongUNgoi, String _hinhDangTC, String _tuThe, String _conCoTC, String _vu, String _luongMao, String _luongMau, String _cutHaVe, String _amHo, String _amDao, String _coTuCung, SmartDate _oiVo, String _mauOi, String _ngoi, String _the, String _doLot, String _tangSinhMon, String _tinhTrangOi, String _oivoTuNhien, String _luongNuocOi, String _kieuThe, String _duongKinhNho, String _tomTat, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD);
            // public override String InsertKhamBenh_San(String _MaSoKham, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, Boolean _seoPTCu, String _chieuCaoTC, String _vongBung, String _timThai, Boolean _timThaiRo, String _luongGai, String _baudelocque, String _luongUNgoi, String _hinhDangTC, String _tuThe, String _conCoTC, String _vu, String _luongMao, String _luongMau, String _cutHaVe, String _amHo, String _amDao, String _coTuCung, SmartDate _oiVo, String _mauOi, String _ngoi, String _the, String _doLot, String _tangSinhMon, String _tinhTrangOi, String _oivoTuNhien, String _luongNuocOi, String _kieuThe, String _duongKinhNho, String _tomTat, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD)

            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_San_CREATE", _MaSoKham, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _toanThan, _toanTrang, _cao, _tim, _gan, _phoi, _than, _benhKhac, _seoPTCu, _chieuCaoTC, _vongBung, _timThai, _timThaiRo, _luongGai, _baudelocque, _luongUNgoi, _hinhDangTC, _tuThe, _conCoTC, _vu, _luongMao, _luongMau, _cutHaVe, _amHo, _amDao, _coTuCung, _oiVo, _mauOi, _ngoi, _the, _doLot, _tangSinhMon, _tinhTrangOi, _oivoTuNhien, _luongNuocOi, _kieuThe, _duongKinhNho, _tomTat, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV,_maMay ,   _huy, _ngaySD.DBValue,_nguoiSD , _ngaySD1.DBValue, _nguoiSD1), String);
            // }
        }

        /// <summary>
        /// Update all changes made on <see cref="KhamBenh_San" /> Object to underlying database.
        /// </summary>
       internal virtual void Update(KhamBenh_C obj)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_San
            if (IsDirty)
            {

                DataProvider.Instance().UpdateKhamBenh_San(obj.MaSoKham, obj.STT, obj.MaDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _toanThan, _toanTrang, _cao, _tim, _gan, _phoi, _than, _benhKhac, _seoPTCu, _chieuCaoTC, _vongBung, _timThai, _timThaiRo, _luongGai, _baudelocque, _luongUNgoi, _hinhDangTC, _tuThe, _conCoTC, _vu, _luongMao, _luongMau, _cutHaVe, _amHo, _amDao, _coTuCung, _phanPhu, _oiVo, _mauOi, _ngoi, _the, _doLot, _tangSinhMon, _tinhTrangOi, _oivoTuNhien, _luongNuocOi, _kieuThe, _duongKinhNho, _tomTat, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV, _maMay , _huy, _nguoiSD);
                // public abstract void UpdateKhamBenh_San(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, Boolean _seoPTCu, String _chieuCaoTC, String _vongBung, String _timThai, Boolean _timThaiRo, String _luongGai, String _baudelocque, String _luongUNgoi, String _hinhDangTC, String _tuThe, String _conCoTC, String _vu, String _luongMao, String _luongMau, String _cutHaVe, String _amHo, String _amDao, String _coTuCung, SmartDate _oiVo, String _mauOi, String _ngoi, String _the, String _doLot, String _tangSinhMon, String _tinhTrangOi, String _oivoTuNhien, String _luongNuocOi, String _kieuThe, String _duongKinhNho, String _tomTat, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD);
                // public override void UpdateKhamBenh_San(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, Boolean _seoPTCu, String _chieuCaoTC, String _vongBung, String _timThai, Boolean _timThaiRo, String _luongGai, String _baudelocque, String _luongUNgoi, String _hinhDangTC, String _tuThe, String _conCoTC, String _vu, String _luongMao, String _luongMau, String _cutHaVe, String _amHo, String _amDao, String _coTuCung, SmartDate _oiVo, String _mauOi, String _ngoi, String _the, String _doLot, String _tangSinhMon, String _tinhTrangOi, String _oivoTuNhien, String _luongNuocOi, String _kieuThe, String _duongKinhNho, String _tomTat, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD)

                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_San_UPDATE", _MaSoKham, _sTT, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _toanThan, _toanTrang, _cao, _tim, _gan, _phoi, _than, _benhKhac, _seoPTCu, _chieuCaoTC, _vongBung, _timThai, _timThaiRo, _luongGai, _baudelocque, _luongUNgoi, _hinhDangTC, _tuThe, _conCoTC, _vu, _luongMao, _luongMau, _cutHaVe, _amHo, _amDao, _coTuCung, _oiVo, _mauOi, _ngoi, _the, _doLot, _tangSinhMon, _tinhTrangOi, _oivoTuNhien, _luongNuocOi, _kieuThe, _duongKinhNho, _tomTat, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV,_maMay ,   _huy, _nguoiSD );
                // }	
                MarkOld();
            }
        }
        internal void DeleteSelf(KhamBenh_C obj)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;
              
            DataProvider.Instance().DeleteKhamBenh_San(_maMay, _nguoiSD , obj.MaSoKham, _sTT);
            MarkNew();
        }

		#endregion
	}

}
