// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	KhamBenh_VoSinhNu
// Kieu doi tuong  :	KhamBenh_VoSinhNu
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
	/// This is a base generated class of <see cref="KhamBenh_VoSinhNu" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class KhamBenh_VoSinhNu : BusinessBase<KhamBenh_VoSinhNu>
	{
		#region Business Methods
		
		#region State Fields
        private String _MaSoKham = String.Empty;
        private Int32 _sTT = 0;
        private String _maDV = String.Empty;
        private SmartDate _ngayKham = new SmartDate(true);
        private String _bSKHAM = String.Empty;
        private String _lyDoKham = String.Empty;
        private String _mach = String.Empty;
		private String _apHuyet = String.Empty;
		private String _NhietDo = String.Empty;
		private String _NhipTho = String.Empty;
        private String _canNang = String.Empty;
		private String _chieuCao = String.Empty;

        private Byte _cokinhlandau = 0; //thêm mới1
        private Boolean _chukykinhnguyet_deu = false;
        private Byte _chukykinhnguyet_ngay = 0; //thêm mới2
        private Byte _songaycokinh = 0; //thêm mới3
        private Byte _soluongkinhnguyet = 0; //thêm mới4
        private Boolean _vokinh = false;
        private Boolean _vosinh = false;
        private Byte _solancothai_chonghientai = 0; //thêm mới5
        private Byte _solancothai = 0; //thêm mới5
        private Byte _soconsong = 0; //thêm mới6
        private Byte _saythai = 0; //thêm mới7
        private Byte _nao_hut = 0; //thêm mới8
        private Byte _thailuu = 0; //thêm mới9

        private Byte _soconsong_chonghientai = 0; //thêm mới6
        private Byte _saythai_chonghientai = 0; //thêm mới7
        private Byte _nao_hut_chonghientai = 0; //thêm mới8
        private Byte _thailuu_chonghientai = 0; //thêm mới9
        private Boolean _phattrienvu = false;
        
        private Boolean _mangtrinh = false;
        private Boolean _amdao = false;
        private Byte _co_tc = 0; //thêm mới10
        private String _tucung_thetich = String.Empty;       
        private String _tucung_matdo = String.Empty;
        private String _tucung_tuthe = String.Empty;
        private String _tucung_didong = String.Empty;
        private Boolean _haiphanphu = false;
        private Boolean _test_catheter = false;

        private String _KetLuan = String.Empty;
        private String _Tuvan = String.Empty;
        private String _Chuandoan = String.Empty;
        private String _LoiDanBS = String.Empty;
        private String _TenBenh = String.Empty;
        private String _BenhKhac = String.Empty;
        private String _DieuTri = String.Empty;
        private String _BenhSu = String.Empty;
        private String _HuongDT = String.Empty;
        private String _Mabenh = String.Empty;
        private String _MaBenhKem = String.Empty;
        private String _MaBV = String.Empty;       
        private String _maMay = String.Empty;
        private Boolean _Huy = false;
        private SmartDate _NgaySD = new SmartDate(true);
        private String _NguoiSD = String.Empty;
        private SmartDate _NgaySD1 = new SmartDate(true);
        private String _NguoiSD1 = String.Empty;
        private int _OrderNumber;
        private String _mabhxh = String.Empty;
        private String _tenBV = String.Empty;
        private String _tenBSKham = String.Empty;
     
      
		#endregion
		
			#region Business Properties and Methods
        public String tenBSKham
        {
            get
            {
                CanReadProperty("tenBSKham", true);
                return _tenBSKham;
            }
            set
            {
                CanWriteProperty("tenBSKham", true);
                if (_tenBSKham != value)
                {
                    _tenBSKham = value;
                    PropertyHasChanged("tenBSKham");
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
				return _NhietDo;
			}
			set 
			{
				CanWriteProperty("NhietDo", true);
				if (_NhietDo != value) 
				{
					_NhietDo = value;
					PropertyHasChanged("NhietDo");
				}
			}
		}
	    public String NhipTho
		{
			get 
			{
				CanReadProperty("NhipTho", true);
				return _NhipTho;
			}
			set 
			{
				CanWriteProperty("NhipTho", true);
				if (_NhipTho != value) 
				{
					_NhipTho = value;
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
        public Boolean chukykinhnguyet_deu 
		{
			get 
			{
                CanReadProperty("chukykinhnguyet_deu", true);
                return _chukykinhnguyet_deu;
			}
			set 
			{
                CanWriteProperty("chukykinhnguyet_deu", true);
                if (_chukykinhnguyet_deu != value) 
				{
                    _chukykinhnguyet_deu = value;
                    PropertyHasChanged("chukykinhnguyet_deu");
				}
			}
		}
	    public Boolean vokinh
		{
			get 
			{
				CanReadProperty("vokinh", true);
                return _vokinh;
			}
			set 
			{
				CanWriteProperty("vokinh", true);
                if (_vokinh != value) 
				{
                    _vokinh = value;
					PropertyHasChanged("vokinh");
				}
			}
		}
        public Boolean vosinh
		{
			get 
			{
                CanReadProperty("vosinh", true);
                return _vosinh;
			}
			set 
			{
                CanWriteProperty("vosinh", true);
                if (_vosinh != value) 
				{
                    _vosinh = value;
                    PropertyHasChanged("vosinh");
				}
			}
		}
        public Boolean phattrienvu
        {
            get
            {
                CanReadProperty("phattrienvu ", true);
                return _phattrienvu;
            }
            set
            {
                CanWriteProperty("phattrienvu ", true);
                if (_phattrienvu != value)
                {
                    _phattrienvu = value;
                    PropertyHasChanged("phattrienvu");
                }
            }
        }
        public Byte cokinhlandau
        {
            get
            {
                CanReadProperty("cokinhlandau", true);
                return _cokinhlandau;
            }
            set
            {
                CanWriteProperty("cokinhlandau", true);
                if (_cokinhlandau != value)
                {
                    _cokinhlandau = value;
                    PropertyHasChanged("cokinhlandau");
                }
            }
        }
        public Byte chukykinhnguyet_ngay
        {
            get
            {
                CanReadProperty("chukykinhnguyet_ngay", true);
                return _chukykinhnguyet_ngay;
            }
            set
            {
                CanWriteProperty("chukykinhnguyet_ngay", true);
                if (_chukykinhnguyet_ngay != value)
                {
                    _chukykinhnguyet_ngay = value;
                    PropertyHasChanged("chukykinhnguyet_ngay");
                }
            }
        }
        public Byte songaycokinh
        {
            get
            {
                CanReadProperty("songaycokinh", true);
                return _songaycokinh;
            }
            set
            {
                CanWriteProperty("songaycokinh", true);
                if (_songaycokinh != value)
                {
                    _songaycokinh = value;
                    PropertyHasChanged("songaycokinh");
                }
            }
        }
        public Byte soluongkinhnguyet
        {
            get
            {
                CanReadProperty("soluongkinhnguyet", true);
                return _soluongkinhnguyet;
            }
            set
            {
                CanWriteProperty("soluongkinhnguyet", true);
                if (_soluongkinhnguyet != value)
                {
                    _soluongkinhnguyet = value;
                    PropertyHasChanged("soluongkinhnguyet");
                }
            }
        }
        public Byte solancothai_chonghientai
        {
            get
            {
                CanReadProperty("solancothai_chonghientai", true);
                return _solancothai_chonghientai;
            }
            set
            {
                CanWriteProperty("solancothai_chonghientai", true);
                if (_solancothai_chonghientai != value)
                {
                    _solancothai_chonghientai = value;
                    PropertyHasChanged("solancothai_chonghientai");
                }
            }
        }
        public Byte solancothai
        {
            get
            {
                CanReadProperty("solancothai", true);
                return _solancothai;
            }
            set
            {
                CanWriteProperty("solancothai", true);
                if (_solancothai != value)
                {
                    _solancothai = value;
                    PropertyHasChanged("solancothai");
                }
            }
        }
        public Byte soconsong
        {
            get
            {
                CanReadProperty("soconsong", true);
                return _soconsong;
            }
            set
            {
                CanWriteProperty("soconsong", true);
                if (_soconsong != value)
                {
                    _soconsong = value;
                    PropertyHasChanged("soconsong");
                }
            }
        }

        public Byte soconsong_chonghientai
        {
            get
            {
                CanReadProperty("soconsong_chonghientai", true);
                return _soconsong_chonghientai;
            }
            set
            {
                CanWriteProperty("soconsong_chonghientai", true);
                if (_soconsong_chonghientai != value)
                {
                    _soconsong_chonghientai = value;
                    PropertyHasChanged("soconsong_chonghientai");
                }
            }
        }

        public Byte saythai
        {
            get
            {
                CanReadProperty("saythai", true);
                return _saythai;
            }
            set
            {
                CanWriteProperty("saythai", true);
                if (_saythai != value)
                {
                    _saythai = value;
                    PropertyHasChanged("saythai");
                }
            }
        }
        public Byte saythai_chonghientai
        {
            get
            {
                CanReadProperty("saythai_chonghientai", true);
                return _saythai_chonghientai;
            }
            set
            {
                CanWriteProperty("saythai_chonghientai", true);
                if (_saythai_chonghientai != value)
                {
                    _saythai_chonghientai = value;
                    PropertyHasChanged("saythai_chonghientai");
                }
            }
        }
        public Byte nao_hut
        {
            get
            {
                CanReadProperty("nao_hut", true);
                return _nao_hut;
            }
            set
            {
                CanWriteProperty("nao_hut", true);
                if (_nao_hut != value)
                {
                    _nao_hut = value;
                    PropertyHasChanged("nao_hut");
                }
            }
        }

        public Byte nao_hut_chonghientai
        {
            get
            {
                CanReadProperty("nao_hut_chonghientai", true);
                return _nao_hut_chonghientai;
            }
            set
            {
                CanWriteProperty("nao_hut_chonghientai", true);
                if (_nao_hut_chonghientai != value)
                {
                    _nao_hut_chonghientai = value;
                    PropertyHasChanged("nao_hut_chonghientai");
                }
            }
        }

        public Byte thailuu
        {
            get
            {
                CanReadProperty("thailuu", true);
                return _thailuu;
            }
            set
            {
                CanWriteProperty("thailuu", true);
                if (_thailuu != value)
                {
                    _thailuu = value;
                    PropertyHasChanged("thailuu");
                }
            }
        }
        public Byte thailuu_chonghientai
        {
            get
            {
                CanReadProperty("thailuu_chonghientai", true);
                return _thailuu_chonghientai;
            }
            set
            {
                CanWriteProperty("thailuu_chonghientai", true);
                if (_thailuu_chonghientai != value)
                {
                    _thailuu_chonghientai = value;
                    PropertyHasChanged("thailuu_chonghientai");
                }
            }
        }

        public Byte co_tc
        {
            get
            {
                CanReadProperty("co_tc", true);
                return _co_tc;
            }
            set
            {
                CanWriteProperty("co_tc", true);
                if (_co_tc != value)
                {
                    _co_tc = value;
                    PropertyHasChanged("co_tc");
                }
            }
        }


        public Boolean mangtrinh
        {
            get
            {
                CanReadProperty("mangtrinh ", true);
                return _mangtrinh;
            }
            set
            {
                CanWriteProperty("mangtrinh ", true);
                if (_mangtrinh != value)
                {
                    _mangtrinh = value;
                    PropertyHasChanged("mangtrinh");
                }
            }
        }
        public Boolean amdao 
        {
            get
            {
                CanReadProperty("amdao ", true);
                return _amdao;
            }
            set
            {
                CanWriteProperty("amdao ", true);
                if (_amdao != value)
                {
                    _amdao = value;
                    PropertyHasChanged("amdao");
                }
            }
        }
        public String tucung_thetich 
		{
			get 
			{
                CanReadProperty("tucung_thetich", true);
                return _tucung_thetich;
			}
			set 
			{
                CanWriteProperty("tucung_thetich", true);
                if (_tucung_thetich != value) 
				{
                    _tucung_thetich = value;
                    PropertyHasChanged("tucung_thetich");
				}
			}
		}

        public Boolean haiphanphu
        {
            get
            {
                CanReadProperty("haiphanphu ", true);
                return _haiphanphu;
            }
            set
            {
                CanWriteProperty("haiphanphu ", true);
                if (_haiphanphu != value)
                {
                    _haiphanphu = value;
                    PropertyHasChanged("haiphanphu");
                }
            }
        }
        public String tucung_matdo 
		{
			get 
			{
				CanReadProperty("tucung_matdo ", true);
                return _tucung_matdo;
			}
			set 
			{
				CanWriteProperty("tucung_matdo ", true);
                if (_tucung_matdo != value) 
				{
                    _tucung_matdo = value;
					PropertyHasChanged("tucung_matdo");
				}
			}
		}
        public String tucung_tuthe
		{
			get 
			{
                CanReadProperty("tucung_tuthe", true);
				return _tucung_tuthe ;
			}
			set 
			{
                CanWriteProperty("tucung_tuthe", true);
				if (_tucung_tuthe  != value) 
				{
					_tucung_tuthe  = value;
                    PropertyHasChanged("tucung_tuthe");
				}
			}
		}
        public String tucung_didong
		{
			get 
			{
                CanReadProperty("tucung_didong", true);
				return _tucung_didong ;
			}
			set 
			{
                CanWriteProperty("tucung_didong", true);
				if (_tucung_didong  != value) 
				{
					_tucung_didong  = value;
                    PropertyHasChanged("tucung_didong");
				}
			}
		}
        public Boolean test_catheter 
		{
			get 
			{
                CanReadProperty("test_catheter", true);
                return _test_catheter;
			}
			set 
			{
                CanWriteProperty("test_catheter", true);
                if (_test_catheter != value) 
				{
                    _test_catheter = value;
                    PropertyHasChanged("test_catheter");
				}
			}
		}

        public String KetLuan
        {
            get
            {
                CanReadProperty("KetLuan", true);
                return _KetLuan;
            }
            set
            {
                CanWriteProperty("KetLuan", true);
                if (_KetLuan != value)
                {
                    _KetLuan = value;
                    PropertyHasChanged("KetLuan");
                }
            }
        }
        public String Tuvan 
        {
            get
            {
                CanReadProperty("Tuvan", true);
                return _Tuvan;
            }
            set
            {
                CanWriteProperty("Tuvan", true);
                if (_Tuvan != value)
                {
                    _Tuvan = value;
                    PropertyHasChanged("Tuvan");
                }
            }
        }
        public String Chuandoan 
        {
            get
            {
                CanReadProperty("Chuandoan", true);
                return _Chuandoan;
            }
            set
            {
                CanWriteProperty("Chuandoan", true);
                if (_Chuandoan != value)
                {
                    _Chuandoan = value;
                    PropertyHasChanged("Chuandoan");
                }
            }
        }
        public String LoiDanBS 
        {
            get
            {
                CanReadProperty("LoiDanBS", true);
                return _LoiDanBS;
            }
            set
            {
                CanWriteProperty("LoiDanBS", true);
                if (_LoiDanBS != value)
                {
                    _LoiDanBS = value;
                    PropertyHasChanged("LoiDanBS");
                }
            }
        }
        public String TenBenh
        {
            get
            {
                CanReadProperty("TenBenh", true);
                return _TenBenh;
            }
            set
            {
                CanWriteProperty("TenBenh", true);
                if (_TenBenh != value)
                {
                    _TenBenh = value;
                    PropertyHasChanged("TenBenh");
                }
            }
        }
        public String BenhKhac
        {
            get
            {
                CanReadProperty("BenhKhac", true);
                return _BenhKhac;
            }
            set
            {
                CanWriteProperty("BenhKhac", true);
                if (_BenhKhac != value)
                {
                    _BenhKhac = value;
                    PropertyHasChanged("BenhKhac");
                }
            }
        }
        public String DieuTri 
        {
            get
            {
                CanReadProperty("DieuTri", true);
                return _DieuTri;
            }
            set
            {
                CanWriteProperty("DieuTri", true);
                if (_DieuTri != value)
                {
                    _DieuTri = value;
                    PropertyHasChanged("DieuTri");
                }
            }
        }

        public String BenhSu
        {
            get
            {
                CanReadProperty("BenhSu", true);
                return _BenhSu;
            }
            set
            {
                CanWriteProperty("BenhSu", true);
                if (_BenhSu != value)
                {
                    _BenhSu = value;
                    PropertyHasChanged("BenhSu");
                }
            }
        }
        public String HuongDT 
        {
            get
            {
                CanReadProperty("HuongDT", true);
                return _HuongDT;
            }
            set
            {
                CanWriteProperty("HuongDT", true);
                if (_HuongDT != value)
                {
                    _HuongDT = value;
                    PropertyHasChanged("HuongDT");
                }
            }
        }
        public String Mabenh
        {
            get
            {
                CanReadProperty("Mabenh", true);
                return _Mabenh;
            }
            set
            {
                CanWriteProperty("Mabenh", true);
                if (_Mabenh != value)
                {
                    _Mabenh = value;
                    PropertyHasChanged("Mabenh");
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

        public String MaBenhKem 
        {
            get
            {
                CanReadProperty("MaBenhKem", true);
                return _MaBenhKem;
            }
            set
            {
                CanWriteProperty("MaBenhKem", true);
                if (_MaBenhKem != value)
                {
                    _MaBenhKem = value;
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
       

		public Boolean Huy
		{
			get 
			{
				CanReadProperty("Huy", true);
				return _Huy;
			}
			set 
			{
				CanWriteProperty("Huy", true);
				if (_Huy != value) 
				{
					_Huy = value;
					PropertyHasChanged("Huy");
				}
			}
		}
		public string NgaySD
		{
			get 
			{
				CanReadProperty("NgaySD", true);
                _NgaySD.FormatString = "dd/MM/yyyy HH:mm"; 
				return _NgaySD.Text;
			}
			set 
			{
				CanWriteProperty("NgaySD", true);
				if (_NgaySD.Text != value) 
				{
					_NgaySD.Text = value;
					PropertyHasChanged("NgaySD");
				}
			}
		}
		public String NguoiSD
		{
			get 
			{
				CanReadProperty("NguoiSD", true);
				return _NguoiSD;
			}
			set 
			{
				CanWriteProperty("NguoiSD", true);
				if (_NguoiSD != value) 
				{
					_NguoiSD = value;
					PropertyHasChanged("NguoiSD");
				}
			}
		}
        //public string NgaySD1
        //{
        //    get 
        //    {
        //        CanReadProperty("NgaySD1", true);
        //        return _NgaySD1.Text;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NgaySD1", true);
        //        if (_NgaySD1.Text != value) 
        //        {
        //            _NgaySD1.Text = value;
        //            PropertyHasChanged("NgaySD1");
        //        }
        //    }
        //}
        //public String NguoiSD1
        //{
        //    get 
        //    {
        //        CanReadProperty("NguoiSD1", true);
        //        return _NguoiSD1;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NguoiSD1", true);
        //        if (_NguoiSD1 != value) 
        //        {
        //            _NguoiSD1 = value;
        //            PropertyHasChanged("NguoiSD1");
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
        /// Factory method. New <see cref="KhamBenh_VoSinhNu" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 

        public static KhamBenh_VoSinhNu NewKhamBenh_VoSinhNu()
        {
            return new KhamBenh_VoSinhNu();
            //return DataPortal.Create<DMDichVu_PhieuIn_C>();
        }
        public static KhamBenh_VoSinhNu NewKhamBenh_VoSinhNu(string idDMDichvu)
        {
            return new KhamBenh_VoSinhNu(DMDichVu.GetDMDichVu(idDMDichvu));
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static KhamBenh_VoSinhNu NewKhamBenh_VoSinhNu(DMDichVu _DMDichvu)
        {
            return new KhamBenh_VoSinhNu(_DMDichvu);
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static KhamBenh_VoSinhNu NewKhamBenh_VoSinhNu(string masokham, Int32 stt, string idDMDichvu)
        {
            return new KhamBenh_VoSinhNu(masokham, stt, idDMDichvu);
        }

        public static KhamBenh_VoSinhNu GetKhamBenh_VoSinhNu(String maSoKham, Int32 sTT)
        {
            return DataPortal.Fetch<KhamBenh_VoSinhNu>(new Criteria(maSoKham, sTT));
        }

        public static KhamBenh_VoSinhNu GetKhamBenh_VoSinhNu(SafeDataReader dr)
        {
            return new KhamBenh_VoSinhNu(dr);
        }

        /// <summary>
        /// Marks the <see cref="KhamBenh_VoSinhNu" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteKhamBenh_VoSinhNu(String maSoKham, Int32 sTT, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maSoKham, sTT));
        }

        #endregion
		
			#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal KhamBenh_VoSinhNu()
		{	
			// Prevent direct creation
		}
		
        protected KhamBenh_VoSinhNu(DMDichVu pro)
        {
            MarkAsChild();
           
            
            _maDV = pro.MaDV;
         
        }
        protected KhamBenh_VoSinhNu(string maSoKham,DMDichVu pro)
        {
            MarkAsChild();

            _MaSoKham = maSoKham;
            _maDV = pro.MaDV;
            _maMay = pro.MaMay;
            _Huy = pro.Huy;
            // _ngaySD = pro.NgaySD ;
            _NguoiSD = pro.NguoiSD;
          //  _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_VoSinhNu(string masokham, Int32 stt, string idDMDichvu)
        {
            MarkAsChild();

            _MaSoKham = masokham ;
            _maDV = idDMDichvu ;
            _sTT = stt;
            //  _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_VoSinhNu(SafeDataReader dr)
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
		/// Retrieve an existing <see cref="KhamBenh_VoSinhNu" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetKhamBenh_VoSinhNu(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa);
			// public override IDataReader GetKhamBenh_VoSinhNu(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_VoSinhNu_GET", _MaSoKham, _sTT, _sTTKhoa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKhamBenh_VoSinhNu(crit.MaSoKham, crit.STT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="KhamBenh_VoSinhNu" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
            if (dr.GetString("mabhxh") != null) _mabhxh = dr.GetString("mabhxh");
            if (dr.GetString("tenBV") != null) _tenBV = dr.GetString("tenBV");
			
           	if (dr.GetString("MaSoKham") != null) _MaSoKham = dr.GetString("MaSoKham");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
            if (dr.GetSmartDate("NgayKham", true) != null) _ngayKham = dr.GetSmartDate("NgayKham", true);
           	if (dr.GetString("BSKHAM") != null) _bSKHAM = dr.GetString("BSKHAM");
			if (dr.GetString("LyDoKham") != null) _lyDoKham = dr.GetString("LyDoKham");
			if (dr.GetString("Mach") != null) _mach = dr.GetString("Mach");
			if (dr.GetString("ApHuyet") != null) _apHuyet = dr.GetString("ApHuyet");
			if (dr.GetString("NhietDo") != null) _NhietDo = dr.GetString("NhietDo");
			if (dr.GetString("NhipTho") != null) _NhipTho = dr.GetString("NhipTho");

			if (dr.GetString("CanNang") != null) _canNang = dr.GetString("CanNang");
			if (dr.GetString("ChieuCao") != null) _chieuCao = dr.GetString("ChieuCao");
            if (dr.GetBoolean("chukykinhnguyet_deu") != null) _chukykinhnguyet_deu = dr.GetBoolean("chukykinhnguyet_deu");
            if (dr.GetBoolean("vokinh") != null) _vokinh = dr.GetBoolean("vokinh");
            if (dr.GetBoolean("vosinh") != null) _vosinh = dr.GetBoolean("vosinh");
            if (dr.GetBoolean("phattrienvu") != null) _phattrienvu = dr.GetBoolean("phattrienvu");

            if (dr.GetBoolean("mangtrinh") != null) _mangtrinh = dr.GetBoolean("mangtrinh");
            if (dr.GetBoolean("amdao") != null) _amdao = dr.GetBoolean("amdao");
            if (dr.GetString("tucung_thetich") != null) _tucung_thetich = dr.GetString("tucung_thetich");

            if (dr.GetBoolean("amdao") != null) _amdao = dr.GetBoolean("amdao");
            if (dr.GetString("tucung_matdo") != null) _tucung_matdo = dr.GetString("tucung_matdo");
            if (dr.GetString("tucung_tuthe") != null) _tucung_tuthe = dr.GetString("tucung_tuthe");
            if (dr.GetString("tucung_didong") != null) _tucung_didong = dr.GetString("tucung_didong");

            if (dr.GetByte("cokinhlandau") != null) _cokinhlandau = dr.GetByte("cokinhlandau");
            if (dr.GetByte("chukykinhnguyet_ngay") != null) _chukykinhnguyet_ngay = dr.GetByte("chukykinhnguyet_ngay");
            if (dr.GetByte("songaycokinh") != null) songaycokinh = dr.GetByte("songaycokinh");
            if (dr.GetByte("soluongkinhnguyet") != null) _soluongkinhnguyet = dr.GetByte("soluongkinhnguyet");
            if (dr.GetByte("solancothai_chonghientai") != null) _solancothai_chonghientai = dr.GetByte("solancothai_chonghientai");
            if (dr.GetByte("solancothai") != null) _solancothai = dr.GetByte("solancothai");
          
            if (dr.GetByte("soconsong") != null) _soconsong = dr.GetByte("soconsong");
            if (dr.GetByte("saythai") != null) _saythai = dr.GetByte("saythai");
            if (dr.GetByte("nao_hut") != null) _nao_hut = dr.GetByte("nao_hut");
            if (dr.GetByte("thailuu") != null) _thailuu = dr.GetByte("thailuu");

            if (dr.GetByte("soconsong_chonghientai") != null) _soconsong_chonghientai = dr.GetByte("soconsong_chonghientai");
            if (dr.GetByte("saythai_chonghientai") != null) _saythai_chonghientai = dr.GetByte("saythai_chonghientai");
            if (dr.GetByte("nao_hut_chonghientai") != null) _nao_hut_chonghientai = dr.GetByte("nao_hut_chonghientai");
            if (dr.GetByte("thailuu_chonghientai") != null) _thailuu_chonghientai = dr.GetByte("thailuu_chonghientai");

            if (dr.GetByte("co_tc") != null) _co_tc = dr.GetByte("co_tc");

            if (dr.GetBoolean("test_catheter") != null) _test_catheter = dr.GetBoolean("test_catheter");


            if (dr.GetString("KetLuan") != null) _KetLuan = dr.GetString("KetLuan");
            if (dr.GetString("Tuvan") != null) _Tuvan = dr.GetString("Tuvan");
            if (dr.GetString("Chuandoan") != null) _Chuandoan = dr.GetString("Chuandoan");
            if (dr.GetString("LoiDanBS") != null) _LoiDanBS = dr.GetString("LoiDanBS");
            if (dr.GetString("TenBenh") != null) _TenBenh = dr.GetString("TenBenh");
            if (dr.GetString("BenhKhac") != null) _BenhKhac = dr.GetString("BenhKhac");
            if (dr.GetString("DieuTri") != null) _DieuTri = dr.GetString("DieuTri");


            if (dr.GetString("BenhSu") != null) _BenhSu  = dr.GetString("BenhSu");
            if (dr.GetString("HuongDT") != null) _HuongDT  = dr.GetString("HuongDT");
            if (dr.GetString("Mabenh") != null) _Mabenh  = dr.GetString("Mabenh");
            if (dr.GetString("MaBenhKem") != null) _MaBenhKem  = dr.GetString("MaBenhKem");
            if (dr.GetString("MaBV") != null) _MaBV  = dr.GetString("MaBV");

            if (dr.GetString("tenBSKham") != null) _tenBSKham = dr.GetString("tenBSKham");
        
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _Huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _NgaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _NguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("NgaySD1", true) != null) _NgaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetString("NguoiSD1") != null) _NguoiSD1 = dr.GetString("NguoiSD1");
           
        }
		
		/// <summary>
		/// Insert the new <see cref="KhamBenh_VoSinhNu" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh_VoSinhNu
			// Copy & paste ham duoi day vao file DataProvider.cs
            _MaSoKham = DataProvider.Instance().InsertKhamBenh_VoSinhNu(_MaSoKham, _sTT, _maDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _NhietDo, _NhipTho, _canNang, _chieuCao, _cokinhlandau, _chukykinhnguyet_deu, _chukykinhnguyet_ngay, _songaycokinh, _soluongkinhnguyet, _vokinh, _vosinh, _solancothai_chonghientai, _soconsong_chonghientai, _saythai_chonghientai, _nao_hut_chonghientai, _thailuu_chonghientai, _solancothai, _soconsong, _saythai, _nao_hut, _thailuu, _phattrienvu, _mangtrinh, _amdao, _co_tc, _tucung_thetich, _haiphanphu, _tucung_matdo, _tucung_tuthe, _tucung_didong, _test_catheter, _KetLuan, _Tuvan, _Chuandoan, _LoiDanBS, _TenBenh, _BenhKhac, _DieuTri, _BenhSu, _HuongDT, _Mabenh, _MaBenhKem, _MaBV, _maMay, _NguoiSD);
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="KhamBenh_VoSinhNu" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_VoSinhNu
			if (IsDirty){
                DataProvider.Instance().UpdateKhamBenh_VoSinhNu(_MaSoKham, _sTT, _maDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _NhietDo, _NhipTho, _canNang, _chieuCao, _cokinhlandau, _chukykinhnguyet_deu, _chukykinhnguyet_ngay, _songaycokinh, _soluongkinhnguyet, _vokinh, _vosinh, _solancothai_chonghientai, _soconsong_chonghientai, _saythai_chonghientai, _nao_hut_chonghientai, _thailuu_chonghientai, _solancothai, _soconsong, _saythai, _nao_hut, _thailuu, _phattrienvu, _mangtrinh, _amdao, _co_tc, _tucung_thetich, _haiphanphu, _tucung_matdo, _tucung_tuthe, _tucung_didong, _test_catheter, _KetLuan, _Tuvan, _Chuandoan, _LoiDanBS, _TenBenh, _BenhKhac, _DieuTri, _BenhSu, _HuongDT, _Mabenh, _MaBenhKem, _MaBV, _maMay, _Huy, _NguoiSD);
                MarkOld();
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay,_NguoiSD , _MaSoKham, _sTT));
		}

		/// <summary>
		/// Delete the <see cref="KhamBenh_VoSinhNu" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_VoSinhNu
            DataProvider.Instance().DeleteKhamBenh_VoSinhNu(crit.MaMay, crit.NguoiSD, crit.MaSoKham, crit.STT);
			
		}
        internal virtual void Insert(KhamBenh_C obj)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh_VoSinhNu
            // Copy & paste ham duoi day vao file DataProvider.cs



            _MaSoKham = DataProvider.Instance().InsertKhamBenh_VoSinhNu(obj.MaSoKham, obj.STT, obj.MaDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _NhietDo, _NhipTho, _canNang, _chieuCao, _cokinhlandau, _chukykinhnguyet_deu, _chukykinhnguyet_ngay, _songaycokinh, _soluongkinhnguyet, _vokinh, _vosinh, _solancothai_chonghientai, _soconsong_chonghientai, _saythai_chonghientai, _nao_hut_chonghientai, _thailuu_chonghientai, _solancothai, _soconsong, _saythai, _nao_hut, _thailuu, _phattrienvu, _mangtrinh, _amdao, _co_tc, _tucung_thetich, _haiphanphu, _tucung_matdo, _tucung_tuthe, _tucung_didong, _test_catheter, _KetLuan, _Tuvan, _Chuandoan, _LoiDanBS, _TenBenh, _BenhKhac, _DieuTri, _BenhSu, _HuongDT, _Mabenh, _MaBenhKem, _MaBV, _maMay, _NguoiSD);
            MarkOld();
        }

        /// <summary>
        /// Update all changes made on <see cref="KhamBenh_VoSinhNu" /> Object to underlying database.
        /// </summary>
       internal virtual void Update(KhamBenh_C obj)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_VoSinhNu
            if (IsDirty)
            {



                DataProvider.Instance().UpdateKhamBenh_VoSinhNu(obj.MaSoKham, obj.STT, _maDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _NhietDo, _NhipTho, _canNang, _chieuCao, _cokinhlandau, _chukykinhnguyet_deu, _chukykinhnguyet_ngay, _songaycokinh, _soluongkinhnguyet, _vokinh, _vosinh, _solancothai_chonghientai, _soconsong_chonghientai, _saythai_chonghientai, _nao_hut_chonghientai, _thailuu_chonghientai, _solancothai, _soconsong, _saythai, _nao_hut, _thailuu, _phattrienvu, _mangtrinh, _amdao, _co_tc, _tucung_thetich, _haiphanphu, _tucung_matdo, _tucung_tuthe, _tucung_didong, _test_catheter, _KetLuan, _Tuvan, _Chuandoan, _LoiDanBS, _TenBenh, _BenhKhac, _DieuTri, _BenhSu, _HuongDT, _Mabenh, _MaBenhKem, _MaBV, _maMay, _Huy, _NguoiSD);
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
              
              DataProvider.Instance().DeleteKhamBenh_VoSinhNu(_maMay, _NguoiSD, obj.MaSoKham, _sTT);
            MarkNew();
        }
		#endregion
	}

}
