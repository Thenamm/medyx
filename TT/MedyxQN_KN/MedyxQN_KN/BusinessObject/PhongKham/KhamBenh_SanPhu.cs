// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	KhamBenh_SanPhu
// Kieu doi tuong  :	KhamBenh_SanPhu
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	03/30/2010 1:34:22 PM
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
	/// This is a base generated class of <see cref="KhamBenh_SanPhu" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class KhamBenh_SanPhu : BusinessBase<KhamBenh_SanPhu>
	{
		#region Business Methods
		
		#region State Fields
        private String _mabhxh = String.Empty;
        private String _tenBV = String.Empty;
	
		private String _MaSoKham = String.Empty;
		private Int32 _sTT = 0;
        private String _maDV = String.Empty;
		private SmartDate _ngayKham = new SmartDate(true);
		private String _bSKham = String.Empty;
		private String _lyDoKham = String.Empty;
        private Boolean _Rubella = false;
        private Boolean _UonVan = false;
        private Boolean _TiemChungKhac = false;
        private String _TrieuChung = String.Empty;
        private String _DieuTri = String.Empty;
     
        private String _amho = String.Empty;
		private String _amdao = String.Empty;
		private String _CTC = String.Empty;
		private String _Tucung = String.Empty;
        private String _PhanPhu = String.Empty;
        private String _KetLuan = String.Empty;
        private String _Tuvan = String.Empty;
        private String _Mach = String.Empty;
        private String _ApHuyet = String.Empty;
        private String _NhietDo = String.Empty;
        private String _NhipTho = String.Empty;
        private String _Chuandoan = String.Empty;
        private String _BenhKhac = String.Empty;
        private String _TenBenh = String.Empty;
        private String _LoiDanBS = String.Empty;
       
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
        private String _tenBSKham = String.Empty;
     
        private int _OrderNumber;
		
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
        public Boolean Rubella
        {
            get
            {
                CanReadProperty("Rubella", true);
                return _Rubella;
            }
            set
            {
                CanWriteProperty("Rubella", true);
                if (_Rubella != value)
                {
                    _Rubella = value;
                    PropertyHasChanged("Rubella");
                }
            }
        }

        public Boolean UonVan
        {
            get
            {
                CanReadProperty("UonVan", true);
                return _UonVan;
            }
            set
            {
                CanWriteProperty("UonVan", true);
                if (_UonVan != value)
                {
                    _UonVan = value;
                    PropertyHasChanged("UonVan");
                }
            }
        }
        public Boolean TiemChungKhac
        {
            get
            {
                CanReadProperty("TiemChungKhac", true);
                return _TiemChungKhac;
            }
            set
            {
                CanWriteProperty("TiemChungKhac", true);
                if (_TiemChungKhac != value)
                {
                    _TiemChungKhac = value;
                    PropertyHasChanged("TiemChungKhac");
                }
            }
        }

        public String TrieuChung
        {
            get
            {
                CanReadProperty("TrieuChung", true);
                return _TrieuChung;
            }
            set
            {
                CanWriteProperty("TrieuChung", true);
                if (_TrieuChung != value)
                {
                    _TrieuChung = value;
                    PropertyHasChanged("TrieuChung");
                }
            }
        }

		
		public String amho
		{
			get 
			{
				CanReadProperty("amho", true);
				return _amho;
			}
			set 
			{
				CanWriteProperty("amho", true);
				if (_amho != value) 
				{
					_amho = value;
					PropertyHasChanged("amho");
				}
			}
		}
		
		public String amdao
		{
			get 
			{
				CanReadProperty("amdao", true);
				return _amdao;
			}
			set 
			{
				CanWriteProperty("amdao", true);
                if (_amdao != value) 
				{
                    _amdao = value;
					PropertyHasChanged("amdao");
				}
			}
		}

        public String CTC
		{
			get 
			{
                CanReadProperty("CTC", true);
                return _CTC;
			}
			set 
			{
                CanWriteProperty("CTC", true);
                if (_CTC != value) 
				{
                    _CTC = value;
                    PropertyHasChanged("CTC");
				}
			}
		}
		
		public String Tucung
		{
			get 
			{
				CanReadProperty("Tucung", true);
				return _Tucung;
			}
			set 
			{
				CanWriteProperty("Tucung", true);
				if (_Tucung != value) 
				{
					_Tucung = value;
					PropertyHasChanged("Tucung");
				}
			}
		}
		

		public String PhanPhu
		{
			get 
			{
				CanReadProperty("PhanPhu", true);
				return _PhanPhu;
			}
			set 
			{
				CanWriteProperty("PhanPhu", true);
				if (_PhanPhu != value) 
				{
					_PhanPhu = value;
					PropertyHasChanged("PhanPhu");
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
		
		public String Mach
		{
			get 
			{
				CanReadProperty("Mach", true);
				return _Mach;
			}
			set 
			{
				CanWriteProperty("Mach", true);
				if (_Mach != value) 
				{
					_Mach = value;
					PropertyHasChanged("Mach");
				}
			}
		}
		
		public String ApHuyet
		{
			get 
			{
				CanReadProperty("ApHuyet", true);
				return _ApHuyet;
			}
			set 
			{
				CanWriteProperty("ApHuyet", true);
				if (_ApHuyet != value) 
				{
					_ApHuyet = value;
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

        public String BenhKhac 
		{
			get 
			{
                CanReadProperty("BenhKhac ", true);
                return _BenhKhac;
			}
			set 
			{
                CanWriteProperty("BenhKhac ", true);
                if (_BenhKhac != value) 
				{
                    _BenhKhac = value;
                    PropertyHasChanged("BenhKhac");
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

        //public String TuoiKinh
        //{
        //    get 
        //    {
        //        CanReadProperty("TuoiKinh", true);
        //        return _TuoiKinh;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("TuoiKinh", true);
        //        if (_TuoiKinh != value) 
        //        {
        //            _TuoiKinh = value;
        //            PropertyHasChanged("TuoiKinh");
        //        }
        //    }
        //}

        //public String ChuKyKinh
        //{
        //    get 
        //    {
        //        CanReadProperty("ChuKyKinh", true);
        //        return _ChuKyKinh;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("ChuKyKinh", true);
        //        if (_ChuKyKinh != value) 
        //        {
        //            _ChuKyKinh = value;
        //            PropertyHasChanged("ChuKyKinh");
        //        }
        //    }
        //}

        //public String NgayThayKinh
        //{
        //    get 
        //    {
        //        CanReadProperty("NgayThayKinh", true);
        //        return _NgayThayKinh;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NgayThayKinh", true);
        //        if (_NgayThayKinh != value) 
        //        {
        //            _NgayThayKinh = value;
        //            PropertyHasChanged("NgayThayKinh");
        //        }
        //    }
        //}

        //public String TuoiLayChong
        //{
        //    get 
        //    {
        //        CanReadProperty("TuoiLayChong", true);
        //        return _TuoiLayChong;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("TuoiLayChong", true);
        //        if (_TuoiLayChong != value) 
        //        {
        //            _TuoiLayChong = value;
        //            PropertyHasChanged("TuoiLayChong");
        //        }
        //    }
        //}

        //public String BenhPhuKhoadamac
        //{
        //    get 
        //    {
        //        CanReadProperty("BenhPhuKhoadamac", true);
        //        return _BenhPhuKhoadamac;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("BenhPhuKhoadamac", true);
        //        if (_BenhPhuKhoadamac != value) 
        //        {
        //            _BenhPhuKhoadamac = value;
        //            PropertyHasChanged("BenhPhuKhoadamac");
        //        }
        //    }
        //}

        //public Boolean Ubt 
        //{
        //    get
        //    {
        //        CanReadProperty("Ubt", true);
        //        return _Ubt;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Ubt", true);
        //        if (_Ubt != value)
        //        {
        //            _Ubt = value;
        //            PropertyHasChanged("Ubt");
        //        }
        //    }
        //}
        //public Boolean UxoTC 
        //{
        //    get
        //    {
        //        CanReadProperty("UxoTC", true);
        //        return _UxoTC;
        //    }
        //    set
        //    {
        //        CanWriteProperty("UxoTC", true);
        //        if (_UxoTC != value)
        //        {
        //            _UxoTC = value;
        //            PropertyHasChanged("UxoTC");
        //        }
        //    }
        //}
        //public Boolean DiDangSD
        //{
        //    get
        //    {
        //        CanReadProperty("DiDangSD ", true);
        //        return _DiDangSD;
        //    }
        //    set
        //    {
        //        CanWriteProperty("DiDangSD", true);
        //        if (_DiDangSD != value)
        //        {
        //            _DiDangSD = value;
        //            PropertyHasChanged("DiDangSD");
        //        }
        //    }
        //}
        //public Boolean SSD
        //{
        //    get
        //    {
        //        CanReadProperty("SSD ", true);
        //        return _SSD;
        //    }
        //    set
        //    {
        //        CanWriteProperty("SSD", true);
        //        if (_SSD != value)
        //        {
        //            _SSD = value;
        //            PropertyHasChanged("SSD");
        //        }
        //    }
        //}
        //public Boolean TSM
        //{
        //    get
        //    {
        //        CanReadProperty("TSM ", true);
        //        return _TSM;
        //    }
        //    set
        //    {
        //        CanWriteProperty("TSM", true);
        //        if (_TSM != value)
        //        {
        //            _TSM = value;
        //            PropertyHasChanged("TSM");
        //        }
        //    }
        //}
        //public Boolean DieuTriCTC
        //{
        //    get
        //    {
        //        CanReadProperty("DieuTriCTC ", true);
        //        return _DieuTriCTC;
        //    }
        //    set
        //    {
        //        CanWriteProperty("DieuTriCTC", true);
        //        if (_DieuTriCTC != value)
        //        {
        //            _DieuTriCTC = value;
        //            PropertyHasChanged("DieuTriCTC");
        //        }
        //    }
        //}
        //public Boolean CatCutCTC
        //{
        //    get
        //    {
        //        CanReadProperty("CatCutCTC ", true);
        //        return _CatCutCTC;
        //    }
        //    set
        //    {
        //        CanWriteProperty("CatCutCTC", true);
        //        if (_CatCutCTC != value)
        //        {
        //            _CatCutCTC = value;
        //            PropertyHasChanged("CatCutCTC");
        //        }
        //    }
        //}
        //public String LoaiKhac
        //{
        //    get
        //    {
        //        CanReadProperty("LoaiKhac", true);
        //        return _LoaiKhac;
        //    }
        //    set
        //    {
        //        CanWriteProperty("LoaiKhac", true);
        //        if (_LoaiKhac != value)
        //        {
        //            _LoaiKhac = value;
        //            PropertyHasChanged("LoaiKhac");
        //        }
        //    }
        //}
        //public String Para
        //{
        //    get
        //    {
        //        CanReadProperty("Para", true);
        //        return _Para;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Para", true);
        //        if (_Para != value)
        //        {
        //            _Para = value;
        //            PropertyHasChanged("Para");
        //        }
        //    }
        //}
        //public String Solancothai
        //{
        //    get
        //    {
        //        CanReadProperty("Solancothai", true);
        //        return _Solancothai;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Solancothai", true);
        //        if (_Solancothai != value)
        //        {
        //            _Solancothai = value;
        //            PropertyHasChanged("Solancothai");
        //        }
        //    }
        //}
        //public String Solansay
        //{
        //    get
        //    {
        //        CanReadProperty("Solansay", true);
        //        return _Solansay;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Solansay", true);
        //        if (_Solansay != value)
        //        {
        //            _Solansay = value;
        //            PropertyHasChanged("Solansay");
        //        }
        //    }
        //}
        //public String SolanNaoHut
        //{
        //    get
        //    {
        //        CanReadProperty("SolanNaoHut", true);
        //        return _SolanNaoHut;
        //    }
        //    set
        //    {
        //        CanWriteProperty("SolanNaoHut", true);
        //        if (_SolanNaoHut != value)
        //        {
        //            _SolanNaoHut = value;
        //            PropertyHasChanged("SolanNaoHut");
        //        }
        //    }
        //}
        //public String Solande
        //{
        //    get
        //    {
        //        CanReadProperty("Solande", true);
        //        return _Solande;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Solande", true);
        //        if (_Solande != value)
        //        {
        //            _Solande = value;
        //            PropertyHasChanged("Solande");
        //        }
        //    }
        //}
        //public String Soconsong 
        //{
        //    get
        //    {
        //        CanReadProperty("Soconsong", true);
        //        return _Soconsong;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Soconsong", true);
        //        if (_Soconsong != value)
        //        {
        //            _Soconsong = value;
        //            PropertyHasChanged("Soconsong");
        //        }
        //    }
        //}
        //public String Cachde 
        //{
        //    get
        //    {
        //        CanReadProperty("Cachde", true);
        //        return _Cachde;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Cachde", true);
        //        if (_Cachde != value)
        //        {
        //            _Cachde = value;
        //            PropertyHasChanged("Cachde");
        //        }
        //    }
        //}

        //public Boolean CaoHA
        //{
        //    get
        //    {
        //        CanReadProperty("CaoHA", true);
        //        return _CaoHA;
        //    }
        //    set
        //    {
        //        CanWriteProperty("CaoHA", true);
        //        if (_CaoHA != value)
        //        {
        //            _CaoHA = value;
        //            PropertyHasChanged("CaoHA");
        //        }
        //    }
        //}
        //public Boolean BenhTim 
        //{
        //    get
        //    {
        //        CanReadProperty("BenhTim", true);
        //        return _BenhTim;
        //    }
        //    set
        //    {
        //        CanWriteProperty("BenhTim", true);
        //        if (_BenhTim != value)
        //        {
        //            _BenhTim = value;
        //            PropertyHasChanged("BenhTim");
        //        }
        //    }
        //}
        //public Boolean LaoPhoi 
        //{
        //    get
        //    {
        //        CanReadProperty("LaoPhoi", true);
        //        return _LaoPhoi;
        //    }
        //    set
        //    {
        //        CanWriteProperty("LaoPhoi", true);
        //        if (_LaoPhoi != value)
        //        {
        //            _LaoPhoi = value;
        //            PropertyHasChanged("LaoPhoi");
        //        }
        //    }
        //}
        //public Boolean HenPheQuan 
        //{
        //    get
        //    {
        //        CanReadProperty("HenPheQuan", true);
        //        return _HenPheQuan;
        //    }
        //    set
        //    {
        //        CanWriteProperty("HenPheQuan", true);
        //        if (_HenPheQuan != value)
        //        {
        //            _HenPheQuan = value;
        //            PropertyHasChanged("HenPheQuan");
        //        }
        //    }
        //}
        //public Boolean BenhThan 
        //{
        //    get
        //    {
        //        CanReadProperty("BenhThan", true);
        //        return _BenhThan;
        //    }
        //    set
        //    {
        //        CanWriteProperty("BenhThan", true);
        //        if (_BenhThan != value)
        //        {
        //            _BenhThan = value;
        //            PropertyHasChanged("BenhThan");
        //        }
        //    }
        //}
        //public Boolean BaseDow 
        //{
        //    get
        //    {
        //        CanReadProperty("BaseDow", true);
        //        return _BaseDow;
        //    }
        //    set
        //    {
        //        CanWriteProperty("BaseDow", true);
        //        if (_BaseDow != value)
        //        {
        //            _BaseDow = value;
        //            PropertyHasChanged("BaseDow");
        //        }
        //    }
        //}
        //public Boolean ViemTacTM 
        //{
        //    get
        //    {
        //        CanReadProperty("ViemTacTM", true);
        //        return _ViemTacTM;
        //    }
        //    set
        //    {
        //        CanWriteProperty("ViemTacTM", true);
        //        if (_ViemTacTM != value)
        //        {
        //            _ViemTacTM = value;
        //            PropertyHasChanged("ViemTacTM");
        //        }
        //    }
        //}
        //public Boolean DongKinh 
        //{
        //    get
        //    {
        //        CanReadProperty("DongKinh", true);
        //        return _DongKinh;
        //    }
        //    set
        //    {
        //        CanWriteProperty("DongKinh", true);
        //        if (_DongKinh != value)
        //        {
        //            _DongKinh = value;
        //            PropertyHasChanged("DongKinh");
        //        }
        //    }
        //}
        //public Boolean MoRuotThua 
        //{
        //    get
        //    {
        //        CanReadProperty("MoRuotThua", true);
        //        return _MoRuotThua;
        //    }
        //    set
        //    {
        //        CanWriteProperty("MoRuotThua", true);
        //        if (_MoRuotThua != value)
        //        {
        //            _MoRuotThua = value;
        //            PropertyHasChanged("MoRuotThua");
        //        }
        //    }
        //}
        //public String DungThuoc 
        //{
        //    get
        //    {
        //        CanReadProperty("DungThuoc", true);
        //        return _DungThuoc;
        //    }
        //    set
        //    {
        //        CanWriteProperty("DungThuoc", true);
        //        if (_DungThuoc != value)
        //        {
        //            _DungThuoc = value;
        //            PropertyHasChanged("DungThuoc");
        //        }
        //    }
        //}
        //public String PTobung 
        //{
        //    get
        //    {
        //        CanReadProperty("PTobung", true);
        //        return _PTobung;
        //    }
        //    set
        //    {
        //        CanWriteProperty("PTobung", true);
        //        if (_PTobung != value)
        //        {
        //            _PTobung = value;
        //            PropertyHasChanged("PTobung");
        //        }
        //    }
        //}
        //public String BenhkhacNoiKhoa 
        //{
        //    get
        //    {
        //        CanReadProperty("BenhkhacNoiKhoa", true);
        //        return _BenhkhacNoiKhoa;
        //    }
        //    set
        //    {
        //        CanWriteProperty("BenhkhacNoiKhoa", true);
        //        if (_BenhkhacNoiKhoa != value)
        //        {
        //            _BenhkhacNoiKhoa = value;
        //            PropertyHasChanged("BenhkhacNoiKhoa");
        //        }
        //    }
        //}
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
        /// Factory method. New <see cref="KhamBenh_SanPhu" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 

        public static KhamBenh_SanPhu NewKhamBenh_SanPhu()
        {
            return new KhamBenh_SanPhu();
            //return DataPortal.Create<DMDichVu_PhieuIn_C>();
        }
        public static KhamBenh_SanPhu NewKhamBenh_SanPhu(string idDMDichvu)
        {
            return new KhamBenh_SanPhu(DMDichVu.GetDMDichVu(idDMDichvu));
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static KhamBenh_SanPhu NewKhamBenh_SanPhu(DMDichVu _DMDichvu)
        {
            return new KhamBenh_SanPhu(_DMDichvu);
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static KhamBenh_SanPhu NewKhamBenh_SanPhu(string masokham, Int32 stt, string idDMDichvu)
        {
            return new KhamBenh_SanPhu(masokham, stt, idDMDichvu);
        }

        public static KhamBenh_SanPhu GetKhamBenh_SanPhu(String maSoKham, Int32 sTT)
        {
            return DataPortal.Fetch<KhamBenh_SanPhu>(new Criteria(maSoKham, sTT));
        }

        public static KhamBenh_SanPhu GetKhamBenh_SanPhu(SafeDataReader dr)
        {
            return new KhamBenh_SanPhu(dr);
        }

        /// <summary>
        /// Marks the <see cref="KhamBenh_SanPhu" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteKhamBenh_SanPhu(String maSoKham, Int32 sTT, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maSoKham, sTT));
        }

        #endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal KhamBenh_SanPhu()
		{	
			// Prevent direct creation
		}
		
        protected KhamBenh_SanPhu(DMDichVu pro)
        {
            MarkAsChild();
           
            //_maPhieu = dr.GetString("MaPhieu");
            _maDV = pro.MaDV;
           // _maMay = pro.MaMay;
           // _Huy = pro.Huy;
           //// _ngaySD = pro.NgaySD ;
           // _nguoiSD = pro.NguoiSD;
        //     _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_SanPhu(string maSoKham,DMDichVu pro)
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
        protected KhamBenh_SanPhu(string masokham, Int32 stt, string idDMDichvu)
        {
            MarkAsChild();

            _MaSoKham = masokham ;
            _maDV = idDMDichvu ;
            _sTT = stt;
            //  _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_SanPhu(SafeDataReader dr)
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
		/// Retrieve an existing <see cref="KhamBenh_SanPhu" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetKhamBenh_SanPhu(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa);
			// public override IDataReader GetKhamBenh_SanPhu(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_SanPhu_GET", _MaSoKham, _sTT, _sTTKhoa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKhamBenh_SanPhu(crit.MaSoKham, crit.STT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="KhamBenh_SanPhu" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
            if (dr.GetString("mabhxh") != null) _mabhxh = dr.GetString("mabhxh");
            if (dr.GetString("tenBV") != null) _tenBV = dr.GetString("tenBV");
            if (dr.GetString("DieuTri") != null) _DieuTri = dr.GetString("DieuTri");

			if (dr.GetString("MaSoKham") != null) _MaSoKham = dr.GetString("MaSoKham");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
            //if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
			if (dr.GetSmartDate("NgayKham", true) != null) _ngayKham = dr.GetSmartDate("NgayKham", true);
			if (dr.GetString("BSKham") != null) _bSKham = dr.GetString("BSKham");
			if (dr.GetString("LyDoKham") != null) _lyDoKham = dr.GetString("LyDoKham");
            if (dr.GetBoolean("Rubella") != null) _Rubella = dr.GetBoolean("Rubella");
            if (dr.GetBoolean("UonVan") != null) _UonVan = dr.GetBoolean("UonVan");
            if (dr.GetBoolean("TiemChungKhac") != null) _TiemChungKhac = dr.GetBoolean("TiemChungKhac");
            if (dr.GetString("TrieuChung") != null) _TrieuChung = dr.GetString("TrieuChung");
            if (dr.GetString("amho") != null) _amho = dr.GetString("amho");
            if (dr.GetString("amdao") != null) _amdao = dr.GetString("amdao");
            if (dr.GetString("CTC") != null) _CTC = dr.GetString("CTC");
            if (dr.GetString("Tucung") != null) _Tucung = dr.GetString("Tucung");
            if (dr.GetString("PhanPhu") != null) _PhanPhu = dr.GetString("PhanPhu");
            if (dr.GetString("KetLuan") != null) _KetLuan = dr.GetString("KetLuan");
            if (dr.GetString("Tuvan") != null) _Tuvan = dr.GetString("Tuvan");
            if (dr.GetString("Mach") != null) _Mach = dr.GetString("Mach");
            if (dr.GetString("ApHuyet") != null) _ApHuyet = dr.GetString("ApHuyet");
            if (dr.GetString("NhietDo") != null) _NhietDo = dr.GetString("NhietDo");
            if (dr.GetString("NhipTho") != null) _NhipTho = dr.GetString("NhipTho");
            if (dr.GetString("Chuandoan") != null) _Chuandoan = dr.GetString("Chuandoan");
            if (dr.GetString("BenhKhac") != null) _BenhKhac = dr.GetString("BenhKhac");
            if (dr.GetString("TenBenh") != null) _TenBenh = dr.GetString("TenBenh");
            if (dr.GetString("LoiDanBS") != null) _LoiDanBS = dr.GetString("LoiDanBS");
            //if (dr.GetString("TuoiKinh") != null) _TuoiKinh = dr.GetString("TuoiKinh");
            //if (dr.GetString("ChuKyKinh") != null) _ChuKyKinh = dr.GetString("ChuKyKinh");
            //if (dr.GetString("NgayThayKinh") != null) _NgayThayKinh = dr.GetString("NgayThayKinh");
            //if (dr.GetString("TuoiLayChong") != null) _TuoiLayChong = dr.GetString("TuoiLayChong");
            //if (dr.GetString("BenhPhuKhoadamac") != null) _BenhPhuKhoadamac = dr.GetString("BenhPhuKhoadamac");
            //if (dr.GetBoolean("Ubt") != null) _Ubt = dr.GetBoolean("Ubt");
            //if (dr.GetBoolean("UxoTC") != null) _UxoTC = dr.GetBoolean("UxoTC");
            //if (dr.GetBoolean("DiDangSD") != null) _DiDangSD = dr.GetBoolean("DiDangSD");
            //if (dr.GetBoolean("SSD") != null) _SSD = dr.GetBoolean("SSD");
            //if (dr.GetBoolean("TSM") != null) _TSM = dr.GetBoolean("TSM");
            //if (dr.GetBoolean("DieuTriCTC") != null) _DieuTriCTC = dr.GetBoolean("DieuTriCTC");
            //if (dr.GetBoolean("CatCutCTC") != null) _CatCutCTC = dr.GetBoolean("CatCutCTC");
            //if (dr.GetString("LoaiKhac") != null) _LoaiKhac = dr.GetString("BenhPhuKhoadamac");
            //if (dr.GetString("BenhPhuKhoadamac") != null) _BenhPhuKhoadamac = dr.GetString("LoaiKhac");
            //if (dr.GetString("Para") != null) _Para = dr.GetString("Para");
            //if (dr.GetString("Solancothai") != null) _Solancothai = dr.GetString("Solancothai");
            //if (dr.GetString("Solansay") != null) _Solansay = dr.GetString("Solansay");
            //if (dr.GetString("SolanNaoHut") != null) _SolanNaoHut = dr.GetString("SolanNaoHut");
            //if (dr.GetString("Solande") != null) _Solande = dr.GetString("Solande");
            //if (dr.GetString("Soconsong") != null) _Soconsong = dr.GetString("Soconsong");
            //if (dr.GetString("Cachde") != null) _Cachde = dr.GetString("Cachde");
            //if (dr.GetBoolean("CaoHA") != null) _CaoHA = dr.GetBoolean("CaoHA");
            //if (dr.GetBoolean("BenhTim") != null) _BenhTim = dr.GetBoolean("BenhTim");
            //if (dr.GetBoolean("LaoPhoi") != null) _LaoPhoi = dr.GetBoolean("LaoPhoi");
            //if (dr.GetBoolean("HenPheQuan") != null) _HenPheQuan = dr.GetBoolean("HenPheQuan");
            //if (dr.GetBoolean("BenhThan") != null) _BenhThan = dr.GetBoolean("BenhThan");
            //if (dr.GetBoolean("BaseDow") != null) _BaseDow = dr.GetBoolean("BaseDow");
            //if (dr.GetBoolean("ViemTacTM") != null) _ViemTacTM = dr.GetBoolean("ViemTacTM");
            //if (dr.GetBoolean("DongKinh") != null) _DongKinh = dr.GetBoolean("DongKinh");
            //if (dr.GetBoolean("MoRuotThua") != null) _MoRuotThua = dr.GetBoolean("MoRuotThua");
            //if (dr.GetString("PTobung") != null) _PTobung = dr.GetString("PTobung");
            //if (dr.GetString("BenhkhacNoiKhoa") != null) _BenhkhacNoiKhoa = dr.GetString("BenhkhacNoiKhoa");
            if (dr.GetString("BenhSu") != null) _BenhSu = dr.GetString("BenhSu");
          
            if (dr.GetString("HuongDT") != null) _HuongDT = dr.GetString("HuongDT");
            if (dr.GetString("Mabenh") != null) _Mabenh = dr.GetString("Mabenh");
            if (dr.GetString("MaBenhKem") != null) _MaBenhKem = dr.GetString("MaBenhKem");
            if (dr.GetString("MaBV") != null) _MaBV = dr.GetString("MaBV");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");

            if (dr.GetBoolean("Huy") != null) _Huy = dr.GetBoolean("Huy");

            if (dr.GetSmartDate("NgaySD", true) != null) _NgaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _NguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("NgaySD1", true) != null) _NgaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetString("NguoiSD1") != null) _NguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetString("tenBSKham") != null) _tenBSKham = dr.GetString("tenBSKham");
        
		}
		
		/// <summary>
		/// Insert the new <see cref="KhamBenh_SanPhu" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh_SanPhu
			// Copy & paste ham duoi day vao file DataProvider.cs
            
              
            DataProvider.Instance().InsertKhamBenh_SanPhu(_MaSoKham, _sTT, _maDV, _ngayKham, _bSKham, _lyDoKham, _Rubella, _UonVan, _TiemChungKhac, _TrieuChung, _amho, _amdao, _CTC, _Tucung, _PhanPhu, _KetLuan, _Tuvan, _Mach, _ApHuyet, _NhietDo, _NhipTho, _Chuandoan, _BenhKhac, _TenBenh, _LoiDanBS, _BenhSu , _HuongDT, _Mabenh, _MaBenhKem, _MaBV,_DieuTri , _maMay , _NguoiSD);
            MarkOld(); //  _MaSoKham = DataProvider.Instance().InsertKhamBenh_SanPhu(_MaSoKham, _sTT, _maDV, _ngayKham, _bSKham, _lyDoKham, _Rubella, _UonVan, _TiemChungKhac, _TrieuChung, _amho, _amdao, _CTC, _Tucung, _PhanPhu, _KetLuan, _Tuvan, _Mach, _ApHuyet, _NhietDo, _NhipTho, _Chuandoan, _BenhKhac, _TenBenh, _LoiDanBS, _TuoiKinh, _ChuKyKinh, _NgayThayKinh, _TuoiLayChong, _BenhPhuKhoadamac, _Ubt, _UxoTC, _DiDangSD, _SSD, _TSM, _DieuTriCTC, _CatCutCTC, _LoaiKhac, _Para, _Solancothai, _Solansay, _SolanNaoHut, _Solande, _Soconsong, _Cachde, _CaoHA, _BenhTim, _LaoPhoi, _HenPheQuan, _BenhThan, _BaseDow, _ViemTacTM, _DongKinh, _MoRuotThua, _DungThuoc, _PTobung, _BenhkhacNoiKhoa, _HuongDT, _Mabenh, _MaBenhKem, _MaBV, _maMay , _NguoiSD);
            // public abstract String InsertKhamBenh_SanPhu(String _MaSoKham, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _mach, String _da, String _niemMac, String _apHuyet, String _xuatHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _phu, String _thieuMau, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, String _tomTat, String _dieuTri, String _chanDoan, String _maMay, String _nguoiSD);
			// public override String InsertKhamBenh_SanPhu(String _MaSoKham, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _mach, String _da, String _niemMac, String _apHuyet, String _xuatHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _phu, String _thieuMau, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, String _tomTat, String _dieuTri, String _chanDoan, String _maMay, String _nguoiSD
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_SanPhu_CREATE", _MaSoKham, _sTTKhoa, _ngayKham.DBValue, _bSKham, _lyDoKham, _mach, _da, _niemMac, _apHuyet, _xuatHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _thieuMau, _cao, _tim, _gan, _phoi, _than, _benhKhac, _tomTat, _dieuTri, _chanDoan,_maMay ,   _nguoiSD));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="KhamBenh_SanPhu" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_SanPhu
			if (IsDirty){
                
                  
                  DataProvider.Instance().UpdateKhamBenh_SanPhu(_MaSoKham, _sTT, _maDV, _ngayKham, _bSKham, _lyDoKham, _Rubella, _UonVan, _TiemChungKhac, _TrieuChung, _amho, _amdao, _CTC, _Tucung, _PhanPhu, _KetLuan, _Tuvan, _Mach, _ApHuyet, _NhietDo, _NhipTho, _Chuandoan, _BenhKhac, _TenBenh, _LoiDanBS, _BenhSu, _HuongDT, _Mabenh, _MaBenhKem, _MaBV, _DieuTri, _maMay, _Huy, _NguoiSD);
              //  DataProvider.Instance().UpdateKhamBenh_SanPhu(_MaSoKham, _sTT, _maDV, _ngayKham, _bSKham, _lyDoKham, _Rubella, _UonVan, _TiemChungKhac, _TrieuChung, _amho, _amdao, _CTC, _Tucung, _PhanPhu, _KetLuan, _Tuvan, _Mach, _ApHuyet, _NhietDo, _NhipTho, _Chuandoan, _BenhKhac, _TenBenh, _LoiDanBS, _TuoiKinh, _ChuKyKinh, _NgayThayKinh, _TuoiLayChong, _BenhPhuKhoadamac, _Ubt, _UxoTC, _DiDangSD, _SSD, _TSM, _DieuTriCTC, _CatCutCTC, _LoaiKhac, _Para, _Solancothai, _Solansay, _SolanNaoHut, _Solande, _Soconsong, _Cachde, _CaoHA, _BenhTim, _LaoPhoi, _HenPheQuan, _BenhThan, _BaseDow, _ViemTacTM, _DongKinh, _MoRuotThua, _DungThuoc, _PTobung, _BenhkhacNoiKhoa, _HuongDT, _Mabenh, _MaBenhKem, _MaBV, _maMay , _Huy, _nguoiSD);
                // public abstract void UpdateKhamBenh_SanPhu(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _mach, String _da, String _niemMac, String _apHuyet, String _xuatHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _phu, String _thieuMau, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, String _tomTat, String _dieuTri, String _chanDoan, String _maMay, Boolean _Huy, String _nguoiSD);
				// public override void UpdateKhamBenh_SanPhu(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _mach, String _da, String _niemMac, String _apHuyet, String _xuatHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _phu, String _thieuMau, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, String _tomTat, String _dieuTri, String _chanDoan, String _maMay, Boolean _Huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_SanPhu_UPDATE", _MaSoKham, _sTT, _sTTKhoa, _ngayKham.DBValue, _bSKham, _lyDoKham, _mach, _da, _niemMac, _apHuyet, _xuatHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _thieuMau, _cao, _tim, _gan, _phoi, _than, _benhKhac, _tomTat, _dieuTri, _chanDoan,_maMay ,   _Huy, _nguoiSD );
				// }	
                MarkOld();
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay,_NguoiSD, _MaSoKham, _sTT));
		}

		/// <summary>
		/// Delete the <see cref="KhamBenh_SanPhu" />.
		/// </summary>
        /// 

        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_SanPhu
            DataProvider.Instance().DeleteKhamBenh_SanPhu(crit.MaMay, crit.NguoiSD, crit.MaSoKham, crit.STT);
			
		}
        internal virtual void Insert(KhamBenh_C obj)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh_SanPhu
            // Copy & paste ham duoi day vao file DataProvider.cs
            
            

            DataProvider.Instance().InsertKhamBenh_SanPhu(obj.MaSoKham, obj.STT, obj.MaDV, _ngayKham, _bSKham, _lyDoKham, _Rubella, _UonVan, _TiemChungKhac, _TrieuChung, _amho, _amdao, _CTC, _Tucung, _PhanPhu, _KetLuan, _Tuvan, _Mach, _ApHuyet, _NhietDo, _NhipTho, _Chuandoan, _BenhKhac, _TenBenh, _LoiDanBS, _BenhSu, _HuongDT, _Mabenh, _MaBenhKem, _MaBV, _DieuTri, _maMay, _NguoiSD);
            MarkOld(); //_MaSoKham = DataProvider.Instance().InsertKhamBenh_SanPhu(_MaSoKham, _sTT, _maDV, _ngayKham, _bSKham, _lyDoKham, _Rubella, _UonVan, _TiemChungKhac, _TrieuChung, _amho, _amdao, _CTC, _Tucung, _PhanPhu, _KetLuan, _Tuvan, _Mach, _ApHuyet, _NhietDo, _NhipTho, _Chuandoan, _BenhKhac, _TenBenh, _LoiDanBS, _TuoiKinh, _ChuKyKinh, _NgayThayKinh, _TuoiLayChong, _BenhPhuKhoadamac, _Ubt, _UxoTC, _DiDangSD, _SSD, _TSM, _DieuTriCTC, _CatCutCTC, _LoaiKhac, _Para, _Solancothai, _Solansay, _SolanNaoHut, _Solande, _Soconsong, _Cachde, _CaoHA, _BenhTim, _LaoPhoi, _HenPheQuan, _BenhThan, _BaseDow, _ViemTacTM, _DongKinh, _MoRuotThua, _DungThuoc, _PTobung, _BenhkhacNoiKhoa, _HuongDT, _Mabenh, _MaBenhKem, _MaBV, _maMay , _NguoiSD);
            // public abstract String InsertKhamBenh_SanPhu(String _MaSoKham, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _mach, String _da, String _niemMac, String _apHuyet, String _xuatHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _phu, String _thieuMau, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, String _tomTat, String _dieuTri, String _chanDoan, String _maMay, String _nguoiSD);
            // public override String InsertKhamBenh_SanPhu(String _MaSoKham, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _mach, String _da, String _niemMac, String _apHuyet, String _xuatHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _phu, String _thieuMau, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, String _tomTat, String _dieuTri, String _chanDoan, String _maMay, String _nguoiSD
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_SanPhu_CREATE", _MaSoKham, _sTTKhoa, _ngayKham.DBValue, _bSKham, _lyDoKham, _mach, _da, _niemMac, _apHuyet, _xuatHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _thieuMau, _cao, _tim, _gan, _phoi, _than, _benhKhac, _tomTat, _dieuTri, _chanDoan,_maMay ,   _nguoiSD));
            // }
        }

        /// <summary>
        /// Update all changes made on <see cref="KhamBenh_SanPhu" /> Object to underlying database.
        /// </summary>
       internal virtual void Update(KhamBenh_C obj)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_SanPhu
            if (IsDirty)
            {
                
                  
                  DataProvider.Instance().UpdateKhamBenh_SanPhu(_MaSoKham, _sTT, _maDV, _ngayKham, _bSKham, _lyDoKham, _Rubella, _UonVan, _TiemChungKhac, _TrieuChung, _amho, _amdao, _CTC, _Tucung, _PhanPhu, _KetLuan, _Tuvan, _Mach, _ApHuyet, _NhietDo, _NhipTho, _Chuandoan, _BenhKhac, _TenBenh, _LoiDanBS, _BenhSu, _HuongDT, _Mabenh, _MaBenhKem, _MaBV, _DieuTri, _maMay, _Huy, _NguoiSD);
               // DataProvider.Instance().UpdateKhamBenh_SanPhu(_MaSoKham, _sTT, _maDV, _ngayKham, _bSKham, _lyDoKham, _Rubella, _UonVan, _TiemChungKhac, _TrieuChung, _amho, _amdao, _CTC, _Tucung, _PhanPhu, _KetLuan, _Tuvan, _Mach, _ApHuyet, _NhietDo, _NhipTho, _Chuandoan, _BenhKhac, _TenBenh, _LoiDanBS, _TuoiKinh, _ChuKyKinh, _NgayThayKinh, _TuoiLayChong, _BenhPhuKhoadamac, _Ubt, _UxoTC, _DiDangSD, _SSD, _TSM, _DieuTriCTC, _CatCutCTC, _LoaiKhac, _Para, _Solancothai, _Solansay, _SolanNaoHut, _Solande, _Soconsong, _Cachde, _CaoHA, _BenhTim, _LaoPhoi, _HenPheQuan, _BenhThan, _BaseDow, _ViemTacTM, _DongKinh, _MoRuotThua, _DungThuoc, _PTobung, _BenhkhacNoiKhoa, _HuongDT, _Mabenh, _MaBenhKem, _MaBV, _maMay , _Huy, _nguoiSD);
                // public abstract void UpdateKhamBenh_SanPhu(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _mach, String _da, String _niemMac, String _apHuyet, String _xuatHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _phu, String _thieuMau, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, String _tomTat, String _dieuTri, String _chanDoan, String _maMay, Boolean _Huy, String _nguoiSD);
                // public override void UpdateKhamBenh_SanPhu(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKham, String _lyDoKham, String _mach, String _da, String _niemMac, String _apHuyet, String _xuatHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _phu, String _thieuMau, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, String _tomTat, String _dieuTri, String _chanDoan, String _maMay, Boolean _Huy, String _nguoiSD)
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_SanPhu_UPDATE", _MaSoKham, _sTT, _sTTKhoa, _ngayKham.DBValue, _bSKham, _lyDoKham, _mach, _da, _niemMac, _apHuyet, _xuatHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _thieuMau, _cao, _tim, _gan, _phoi, _than, _benhKhac, _tomTat, _dieuTri, _chanDoan,_maMay ,   _Huy, _nguoiSD );
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
            
            
               
            DataProvider.Instance().DeleteKhamBenh_SanPhu(_maMay, _NguoiSD , obj.MaSoKham, _sTT);
            MarkNew();
        }
		#endregion
	}

}
