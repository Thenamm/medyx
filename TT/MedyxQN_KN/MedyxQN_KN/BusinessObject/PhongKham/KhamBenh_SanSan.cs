// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	KhamBenh_SanSan
// Kieu doi tuong  :	KhamBenh_SanSan
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
    /// This is a base generated class of <see cref="KhamBenh_SanSan" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class KhamBenh_SanSan : BusinessBase<KhamBenh_SanSan>
	{
		#region Business Methods
		
		#region State Fields
        private String _mabhxh = String.Empty;
        private String _tenBV = String.Empty;
	
        private String _MaSoKham = String.Empty;
        private Int32 _sTT = 0;
        private String _maDV = String.Empty;
        private SmartDate _ngayKham = new SmartDate(true);
        private String _bSKHAM = String.Empty;
        private String _lyDoKham = String.Empty;
		private String _mach = String.Empty;
		private String _apHuyet = String.Empty;
		private String _nhietDo = String.Empty;
		private String _nhipTho = String.Empty;

		private String _canNang = String.Empty;
		private String _chieuCao = String.Empty;
        private Boolean _Rubella = false;
        private Boolean _UonVan = false;
        private Boolean _TiemChungKhac = false;
        private SmartDate _NgayDauKyKCC = new SmartDate(true);
        private String _CannangTruoc = String.Empty;
        private String _TuoiThai = String.Empty;
        private Boolean _Seomocu = false;
        private Boolean _dauvetmo = false;

        private SmartDate _ngaydedukien = new SmartDate(true);
        private SmartDate _ngaydedukienSA = new SmartDate(true);
        private String _TaiTdThai = String.Empty;
        private String _ChieuCaoTC = String.Empty;
        private String _CTCVB = String.Empty;
        private String _NgoiThai = String.Empty;
        private String _SLThai = String.Empty;
        private String _TimThaiMoTa = String.Empty;
        private Boolean _TimThai = false;
        private String _BatThuong = String.Empty;
        private String _Tuvan = String.Empty;
        private String _DieuTri = String.Empty;
        private String _tenBSKham = String.Empty;
     
        private String _Chuandoan = String.Empty;
        private String _BenhKhac = String.Empty;
        private String _LoiDanBS = String.Empty;
        //private Boolean _Sinhdoi = false;
        //private Boolean _Benhditruyen = false;
        //private Boolean _Caohuyetap = false;
        //private Boolean _Didang = false;
        //private Boolean _Daiduong = false;
        //private Boolean _Loaikhac = false;
        //private Boolean _Caohuyetapkhoa = false;

        //private Boolean _Than = false;
        //private Boolean _Moruotthua = false;
        //private Boolean _Tim = false;
        //private Boolean _Basedow = false;
        //private Boolean _Laophoi = false;
        //private Boolean _Diungthuoc = false;
        //private Boolean _Viemtactinhmach = false;
        //private Boolean _Cuthe = false;
        //private Boolean _Henphequan = false;
        //private Boolean _Dongkinh = false;

        //private String _PTongbung = String.Empty;
        //private String _Tuoicokinh = String.Empty;
        //private Boolean _UBT = false;
        //private Boolean _TSM = false;
        //private String _Chukykinh = String.Empty;
        //private Boolean _UsoTC = false;
        //private Boolean _DieutriCTC = false;
        //private String _Ngaythaykinh = String.Empty;
        //private Boolean _DidangSD = false;
        //private Boolean _CatcutCTC = false;

        //private String _Tuoilaychong = String.Empty;
        //private Boolean _SSD = false;
        //private String _LoaikhacPT = String.Empty;
        //private Boolean _PARA = false;
        private String _BenhSu = String.Empty;
        private String _HuongDT = String.Empty;
        private String _Mabenh = String.Empty;
        private String _MaBenhKem = String.Empty;
        private String _MaBV = String.Empty;
       	private String _maMay = String.Empty;

		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
        
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
                CanReadProperty("UonVan ", true);
                return _UonVan ;
            }
            set
            {
                CanWriteProperty("UonVan ", true);
                if (_UonVan  != value)
                {
                    _UonVan  = value;
                    PropertyHasChanged("UonVan");
                }
            }
        }
        public Boolean TiemChungKhac
        {
            get
            {
                CanReadProperty("TiemChungKhac ", true);
                return _UonVan;
            }
            set
            {
                CanWriteProperty("TiemChungKhac ", true);
                if (_TiemChungKhac != value)
                {
                    _TiemChungKhac = value;
                    PropertyHasChanged("TiemChungKhac");
                }
            }
        }
        public string NgayDauKyKCC 
        {
            get
            {
                CanReadProperty("NgayDauKyKCC", true);

                return _NgayDauKyKCC.Text;
            }
            set
            {
                CanWriteProperty("NgayDauKyKCC", true);
                if (_NgayDauKyKCC.Text != value)
                {
                    _NgayDauKyKCC.Text = value;
                    PropertyHasChanged("NgayDauKyKCC");
                }
            }
        }

        public String CannangTruoc 
        {
            get
            {
                CanReadProperty("CannangTruoc", true);
                return _CannangTruoc;
            }
            set
            {
                CanWriteProperty("CannangTruoc", true);
                if (_CannangTruoc != value)
                {
                    _CannangTruoc = value;
                    PropertyHasChanged("CannangTruoc");
                }
            }
        }

        public String TuoiThai 
        {
            get
            {
                CanReadProperty("TuoiThai", true);
                return _TuoiThai;
            }
            set
            {
                CanWriteProperty("TuoiThai", true);
                if (_TuoiThai != value)
                {
                    _TuoiThai = value;
                    PropertyHasChanged("TuoiThai");
                }
            }
        }
        public Boolean Seomocu 
        {
            get
            {
                CanReadProperty("Seomocu", true);
                return _Seomocu;
            }
            set
            {
                CanWriteProperty("Seomocu", true);
                if (_Seomocu != value)
                {
                    _Seomocu = value;
                    PropertyHasChanged("Seomocu");
                }
            }
        }
        public Boolean dauvetmo 
        {
            get
            {
                CanReadProperty("dauvetmo", true);
                return _dauvetmo;
            }
            set
            {
                CanWriteProperty("dauvetmo", true);
                if (_dauvetmo != value)
                {
                    _dauvetmo = value;
                    PropertyHasChanged("dauvetmo");
                }
            }
        }
        public string ngaydedukien 
        {
            get
            {
                CanReadProperty("ngaydedukien", true);

                return _ngaydedukien.Text;
            }
            set
            {
                CanWriteProperty("ngaydedukien", true);
                if (_ngaydedukien.Text != value)
                {
                    _ngaydedukien.Text = value;
                    PropertyHasChanged("ngaydedukien");
                }
            }
        }
        public string ngaydedukienSA 
        {
            get
            {
                CanReadProperty("ngaydedukienSA", true);

                return _ngaydedukienSA.Text;
            }
            set
            {
                CanWriteProperty("ngaydedukienSA", true);
                if (_ngaydedukienSA.Text != value)
                {
                    _ngaydedukienSA.Text = value;
                    PropertyHasChanged("ngaydedukienSA");
                }
            }
        }
        public String TaiTdThai 
        {
            get
            {
                CanReadProperty("TaiTdThai", true);
                return _TaiTdThai;
            }
            set
            {
                CanWriteProperty("TaiTdThai", true);
                if (_TaiTdThai != value)
                {
                    _TaiTdThai = value;
                    PropertyHasChanged("TaiTdThai");
                }
            }
        }

        public String ChieuCaoTC 
        {
            get
            {
                CanReadProperty("ChieuCaoTC", true);
                return _ChieuCaoTC;
            }
            set
            {
                CanWriteProperty("ChieuCaoTC", true);
                if (_ChieuCaoTC != value)
                {
                    _ChieuCaoTC = value;
                    PropertyHasChanged("ChieuCaoTC");
                }
            }
        }

        public String CTCVB 
        {
            get
            {
                CanReadProperty("CTCVB", true);
                return _CTCVB;
            }
            set
            {
                CanWriteProperty("CTCVB", true);
                if (_CTCVB != value)
                {
                    _CTCVB = value;
                    PropertyHasChanged("CTCVB");
                }
            }
        }

        public String NgoiThai 
        {
            get
            {
                CanReadProperty("NgoiThai", true);
                return _NgoiThai;
            }
            set
            {
                CanWriteProperty("NgoiThai", true);
                if (_NgoiThai != value)
                {
                    _NgoiThai = value;
                    PropertyHasChanged("NgoiThai");
                }
            }
        }

        public String SLThai 
        {
            get
            {
                CanReadProperty("SLThai", true);
                return _SLThai;
            }
            set
            {
                CanWriteProperty("SLThai", true);
                if (_SLThai != value)
                {
                    _SLThai = value;
                    PropertyHasChanged("SLThai");
                }
            }
        }
        public String TimThaiMoTa
        {
            get
            {
                CanReadProperty("TimThaiMoTa", true);
                return _TimThaiMoTa;
            }
            set
            {
                CanWriteProperty("TimThaiMoTa", true);
                if (_TimThaiMoTa != value)
                {
                    _TimThaiMoTa = value;
                    PropertyHasChanged("SeoPTCu");
                }
            }
        }
        public Boolean TimThai 
        {
            get
            {
                CanReadProperty("TimThai", true);
                return _TimThai;
            }
            set
            {
                CanWriteProperty("TimThai", true);
                if (_TimThai != value)
                {
                    _TimThai = value;
                    PropertyHasChanged("SeoPTCu");
                }
            }
        }

        public String BatThuong
        {
            get
            {
                CanReadProperty("BatThuong", true);
                return _BatThuong;
            }
            set
            {
                CanWriteProperty("BatThuong", true);
                if (_BatThuong != value)
                {
                    _BatThuong = value;
                    PropertyHasChanged("BatThuong");
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
        //public Boolean Sinhdoi
        //{
        //    get
        //    {
        //        CanReadProperty("Sinhdoi", true);
        //        return _Sinhdoi;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Sinhdoi", true);
        //        if (_Sinhdoi != value)
        //        {
        //            _Sinhdoi = value;
        //            PropertyHasChanged("Sinhdoi");
        //        }
        //    }
        //}
        //public Boolean Benhditruyen 
        //{
        //    get
        //    {
        //        CanReadProperty("Benhditruyen", true);
        //        return _Benhditruyen ;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Benhditruyen", true);
        //        if (_Benhditruyen  != value)
        //        {
        //            _Benhditruyen  = value;
        //            PropertyHasChanged("Benhditruyen");
        //        }
        //    }
        //}
        //public Boolean Caohuyetap 
        //{
        //    get
        //    {
        //        CanReadProperty("Caohuyetap", true);
        //        return _Caohuyetap ;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Caohuyetap", true);
        //        if (_Caohuyetap  != value)
        //        {
        //            _Caohuyetap  = value;
        //            PropertyHasChanged("Caohuyetap");
        //        }
        //    }

        //}
        //public Boolean Didang  
        //{
        //    get
        //    {
        //        CanReadProperty("Didang", true);
        //        return _Didang ;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Didang", true);
        //        if (_Didang  != value)
        //        {
        //            _Didang  = value;
        //            PropertyHasChanged("Didang");
        //        }
        //    }
        //}
        //public Boolean Daiduong  
        //{
        //    get
        //    {
        //        CanReadProperty("Daiduong", true);
        //        return _Daiduong ;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Daiduong", true);
        //        if (_Daiduong  != value)
        //        {
        //            _Daiduong  = value;
        //            PropertyHasChanged("Daiduong");
        //        }
        //    }
        //}
        //public Boolean Loaikhac  
        //{
        //    get
        //    {
        //        CanReadProperty("Loaikhac", true);
        //        return _Loaikhac ;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Loaikhac", true);
        //        if (_Loaikhac  != value)
        //        {
        //            _Loaikhac  = value;
        //            PropertyHasChanged("Loaikhac");
        //        }
        //    }
        //}
        //public Boolean Caohuyetapkhoa  
        //{
        //    get
        //    {
        //        CanReadProperty("Caohuyetapkhoa", true);
        //        return _Caohuyetapkhoa ;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Caohuyetapkhoa", true);
        //        if (_Caohuyetapkhoa  != value)
        //        {
        //            _Caohuyetapkhoa  = value;
        //            PropertyHasChanged("Caohuyetapkhoa");
        //        }
        //    }
        //}
        //public Boolean Than  
        //{
        //    get
        //    {
        //        CanReadProperty("Than", true);
        //        return _Than ;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Than", true);
        //        if (_Than  != value)
        //        {
        //            _Than  = value;
        //            PropertyHasChanged("Than");
        //        }
        //    }
        //}
        //public Boolean Moruotthua  
        //{
        //    get
        //    {
        //        CanReadProperty("Moruotthua", true);
        //        return _Moruotthua ;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Moruotthua", true);
        //        if (_Moruotthua  != value)
        //        {
        //            _Moruotthua  = value;
        //            PropertyHasChanged("Moruotthua");
        //        }
        //    }
        //}
        //public Boolean Tim  
        //{
        //    get
        //    {
        //        CanReadProperty("Tim", true);
        //        return _Tim ;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Tim", true);
        //        if (_Tim  != value)
        //        {
        //            _Tim  = value;
        //            PropertyHasChanged("Tim");
        //        }
        //    }
        //}
        //public Boolean Basedow  
        //{
        //    get
        //    {
        //        CanReadProperty("Basedow", true);
        //        return _Basedow ;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Basedow", true);
        //        if (_Basedow  != value)
        //        {
        //            _Basedow  = value;
        //            PropertyHasChanged("Basedow");
        //        }
        //    }
        //}
        //public Boolean Diungthuoc
        //{
        //    get
        //    {
        //        CanReadProperty("Diungthuoc", true);
        //        return _Diungthuoc;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Diungthuoc", true);
        //        if (_Diungthuoc != value)
        //        {
        //            _Diungthuoc = value;
        //            PropertyHasChanged("Diungthuoc");
        //        }
        //    }
        //}
        //public Boolean Laophoi 
        //{
        //    get
        //    {
        //        CanReadProperty("Laophoi", true);
        //        return _Laophoi;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Laophoi", true);
        //        if (_Laophoi != value)
        //        {
        //            _Laophoi = value;
        //            PropertyHasChanged("Laophoi");
        //        }
        //    }
        //}
        //public Boolean Viemtactinhmach 
        //{
        //    get
        //    {
        //        CanReadProperty("Viemtactinhmach", true);
        //        return _Viemtactinhmach;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Viemtactinhmach", true);
        //        if (_Viemtactinhmach != value)
        //        {
        //            _Viemtactinhmach = value;
        //            PropertyHasChanged("Viemtactinhmach");
        //        }
        //    }
        //}
        //public Boolean Cuthe 
        //{
        //    get
        //    {
        //        CanReadProperty("Cuthe", true);
        //        return _Cuthe;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Cuthe", true);
        //        if (_Cuthe != value)
        //        {
        //            _Cuthe = value;
        //            PropertyHasChanged("Cuthe");
        //        }
        //    }
        //}
        //public Boolean Henphequan 
        //{
        //    get
        //    {
        //        CanReadProperty("Henphequan", true);
        //        return _Henphequan;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Henphequan", true);
        //        if (_Henphequan != value)
        //        {
        //            _Henphequan = value;
        //            PropertyHasChanged("Henphequan");
        //        }
        //    }
        //}
        //public Boolean Dongkinh 
        //{
        //    get
        //    {
        //        CanReadProperty("Dongkinh", true);
        //        return _Dongkinh;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Dongkinh", true);
        //        if (_Dongkinh != value)
        //        {
        //            _Dongkinh = value;
        //            PropertyHasChanged("Dongkinh");
        //        }
        //    }
        //}

        //public String PTongbung 
        //{
        //    get
        //    {
        //        CanReadProperty("PTongbung", true);
        //        return _PTongbung;
        //    }
        //    set
        //    {
        //        CanWriteProperty("PTongbung", true);
        //        if (_PTongbung != value)
        //        {
        //            _PTongbung = value;
        //            PropertyHasChanged("PTongbung");
        //        }
        //    }
        //}

        //public String Tuoicokinh 
        //{
        //    get
        //    {
        //        CanReadProperty("Tuoicokinh", true);
        //        return _Tuoicokinh;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Tuoicokinh", true);
        //        if (_Tuoicokinh != value)
        //        {
        //            _Tuoicokinh = value;
        //            PropertyHasChanged("Tuoicokinh");
        //        }
        //    }
        //}
        //public Boolean UBT 
        //{
        //    get
        //    {
        //        CanReadProperty("UBT", true);
        //        return _UBT;
        //    }
        //    set
        //    {
        //        CanWriteProperty("UBT", true);
        //        if (_UBT != value)
        //        {
        //            _UBT = value;
        //            PropertyHasChanged("UBT");
        //        }
        //    }
        //}
        //public Boolean TSM 
        //{
        //    get
        //    {
        //        CanReadProperty("TSM", true);
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

        //public String Chukykinh 
        //{
        //    get
        //    {
        //        CanReadProperty("Chukykinh", true);
        //        return _Chukykinh;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Chukykinh", true);
        //        if (_Chukykinh != value)
        //        {
        //            _Chukykinh = value;
        //            PropertyHasChanged("Chukykinh");
        //        }
        //    }
        //}
        //public Boolean UsoTC 
        //{
        //    get
        //    {
        //        CanReadProperty("UsoTC", true);
        //        return _UsoTC;
        //    }
        //    set
        //    {
        //        CanWriteProperty("UsoTC", true);
        //        if (_UsoTC != value)
        //        {
        //            _UsoTC = value;
        //            PropertyHasChanged("UsoTC");
        //        }
        //    }
        //}
        //public Boolean DieutriCTC 
        //{
        //    get
        //    {
        //        CanReadProperty("DieutriCTC", true);
        //        return _DieutriCTC;
        //    }
        //    set
        //    {
        //        CanWriteProperty("DieutriCTC", true);
        //        if (_DieutriCTC != value)
        //        {
        //            _DieutriCTC = value;
        //            PropertyHasChanged("DieutriCTC");
        //        }
        //    }
        //}
        //public String Ngaythaykinh 
        //{
        //    get
        //    {
        //        CanReadProperty("Ngaythaykinh", true);
        //        return _Ngaythaykinh;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Ngaythaykinh", true);
        //        if (_Ngaythaykinh != value)
        //        {
        //            _Ngaythaykinh = value;
        //            PropertyHasChanged("Ngaythaykinh");
        //        }
        //    }
        //}
        //public Boolean DidangSD 
        //{
        //    get
        //    {
        //        CanReadProperty("DidangSD", true);
        //        return _DidangSD;
        //    }
        //    set
        //    {
        //        CanWriteProperty("DidangSD", true);
        //        if (_DidangSD != value)
        //        {
        //            _DidangSD = value;
        //            PropertyHasChanged("DidangSD");
        //        }
        //    }
        //}
        //public Boolean CatcutCTC 
        //{
        //    get
        //    {
        //        CanReadProperty("CatcutCTC", true);
        //        return _CatcutCTC;
        //    }
        //    set
        //    {
        //        CanWriteProperty("CatcutCTC", true);
        //        if (_CatcutCTC != value)
        //        {
        //            _CatcutCTC = value;
        //            PropertyHasChanged("CatcutCTC");
        //        }
        //    }
        //}
        //public String Tuoilaychong 
        //{
        //    get
        //    {
        //        CanReadProperty("Tuoilaychong", true);
        //        return _Tuoilaychong;
        //    }
        //    set
        //    {
        //        CanWriteProperty("Tuoilaychong", true);
        //        if (_Tuoilaychong != value)
        //        {
        //            _Tuoilaychong = value;
        //            PropertyHasChanged("Tuoilaychong");
        //        }
        //    }
        //}

        //public Boolean SSD 
        //{
        //    get
        //    {
        //        CanReadProperty("SSD", true);
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
        //public String LoaikhacPT 
        //{
        //    get
        //    {
        //        CanReadProperty("LoaikhacPT", true);
        //        return _LoaikhacPT;
        //    }
        //    set
        //    {
        //        CanWriteProperty("LoaikhacPT", true);
        //        if (_LoaikhacPT != value)
        //        {
        //            _LoaikhacPT = value;
        //            PropertyHasChanged("LoaikhacPT");
        //        }
        //    }
        //}
        //public Boolean PARA 
        //{
        //    get
        //    {
        //        CanReadProperty("PARA", true);
        //        return _PARA;
        //    }
        //    set
        //    {
        //        CanWriteProperty("PARA", true);
        //        if (_PARA != value)
        //        {
        //            _PARA = value;
        //            PropertyHasChanged("PARA");
        //        }
        //    }
        //}


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
        /// Factory method. New <see cref="KhamBenh_SanSan" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 

        public static KhamBenh_SanSan NewKhamBenh_SanSan()
        {
            return new KhamBenh_SanSan();
            //return DataPortal.Create<DMDichVu_PhieuIn_C>();
        }
        public static KhamBenh_SanSan NewKhamBenh_SanSan(string idDMDichvu)
        {
            return new KhamBenh_SanSan(DMDichVu.GetDMDichVu(idDMDichvu));
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static KhamBenh_SanSan NewKhamBenh_SanSan(DMDichVu _DMDichvu)
        {
            return new KhamBenh_SanSan(_DMDichvu);
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static KhamBenh_SanSan NewKhamBenh_SanSan(string masokham, Int32 stt, string idDMDichvu)
        {
            return new KhamBenh_SanSan(masokham, stt, idDMDichvu);
        }

        public static KhamBenh_SanSan GetKhamBenh_SanSan(String maSoKham, Int32 sTT)
        {
            return DataPortal.Fetch<KhamBenh_SanSan>(new Criteria(maSoKham, sTT));
        }

        public static KhamBenh_SanSan GetKhamBenh_SanSan(SafeDataReader dr)
        {
            return new KhamBenh_SanSan(dr);
        }

        /// <summary>
        /// Marks the <see cref="KhamBenh_SanSan" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteKhamBenh_SanSan(String maSoKham, Int32 sTT, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maSoKham, sTT));
        }

        #endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal KhamBenh_SanSan()
		{	
			// Prevent direct creation
		}
		
        protected KhamBenh_SanSan(DMDichVu pro)
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
        protected KhamBenh_SanSan(string maSoKham,DMDichVu pro)
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
        protected KhamBenh_SanSan(string masokham, Int32 stt, string idDMDichvu)
        {
            MarkAsChild();

            _MaSoKham = masokham ;
            _maDV = idDMDichvu ;
            _sTT = stt;
            //  _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_SanSan(SafeDataReader dr)
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
		/// Retrieve an existing <see cref="KhamBenh_SanSan" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetKhamBenh_SanSan(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa);
			// public override IDataReader GetKhamBenh_SanSan(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_San_GET", _MaSoKham, _sTT, _sTTKhoa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKhamBenh_SanSan(crit.MaSoKham, crit.STT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="KhamBenh_SanSan" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
            if (dr.GetString("mabhxh") != null) _mabhxh = dr.GetString("mabhxh");
            if (dr.GetString("tenBV") != null) _tenBV = dr.GetString("tenBV");
            if (dr.GetString("DieuTri") != null) _DieuTri = dr.GetString("DieuTri");

			if (dr.GetString("MaSoKham") != null) _MaSoKham = dr.GetString("MaSoKham");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetString("maDV") != null) _maDV = dr.GetString("maDV");
            if (dr.GetSmartDate("NgayKham", true) != null) _ngayKham = dr.GetSmartDate("NgayKham", true);
			if (dr.GetString("BSKHAM") != null) _bSKHAM = dr.GetString("BSKHAM");
			if (dr.GetString("LyDoKham") != null) _lyDoKham = dr.GetString("LyDoKham");
			if (dr.GetString("Mach") != null) _mach = dr.GetString("Mach");
			if (dr.GetString("ApHuyet") != null) _apHuyet = dr.GetString("ApHuyet");
			if (dr.GetString("NhietDo") != null) _nhietDo = dr.GetString("NhietDo");
			if (dr.GetString("NhipTho") != null) _nhipTho = dr.GetString("NhipTho");
			if (dr.GetString("CanNang") != null) _canNang = dr.GetString("CanNang");
			if (dr.GetString("ChieuCao") != null) _chieuCao = dr.GetString("ChieuCao");
            if (dr.GetBoolean("Rubella") != null) _Rubella = dr.GetBoolean("Rubella");
            if (dr.GetBoolean("UonVan") != null) _UonVan = dr.GetBoolean("UonVan");
            if (dr.GetBoolean("TiemChungKhac") != null) _TiemChungKhac = dr.GetBoolean("TiemChungKhac");
            if (dr.GetSmartDate("NgayDauKyKCC", true) != null) _NgayDauKyKCC = dr.GetSmartDate("NgayDauKyKCC", true);
            if (dr.GetString("CannangTruoc") != null) _CannangTruoc = dr.GetString("CannangTruoc");
            if (dr.GetString("TuoiThai") != null) _TuoiThai = dr.GetString("TuoiThai");
            if (dr.GetString("TaiTdThai") != null) _TaiTdThai = dr.GetString("TaiTdThai");
            if (dr.GetString("ChieuCaoTC") != null) _ChieuCaoTC = dr.GetString("ChieuCaoTC");
            if (dr.GetString("CTCVB") != null) _CTCVB = dr.GetString("CTCVB");
            if (dr.GetString("NgoiThai") != null) _NgoiThai = dr.GetString("NgoiThai");
            if (dr.GetString("SLThai") != null) _SLThai = dr.GetString("SLThai");
            if (dr.GetString("BatThuong") != null) _BatThuong = dr.GetString("BatThuong");
            if (dr.GetString("Tuvan") != null) _Tuvan = dr.GetString("Tuvan");
            if (dr.GetString("Chuandoan") != null) _Chuandoan = dr.GetString("Chuandoan");
            if (dr.GetString("BenhKhac") != null) _BenhKhac = dr.GetString("BenhKhac");
            if (dr.GetString("LoiDanBS") != null) _LoiDanBS = dr.GetString("LoiDanBS");
            if (dr.GetSmartDate("ngaydedukien", true) != null) _ngaydedukien = dr.GetSmartDate("ngaydedukien", true);
            if (dr.GetSmartDate("ngaydedukienSA", true) != null) _ngaydedukienSA = dr.GetSmartDate("ngaydedukienSA", true);
            if (dr.GetBoolean("TimThai") != null) _TimThai = dr.GetBoolean("TimThai");
            if (dr.GetString("TimThaiMoTa") != null) _TimThaiMoTa = dr.GetString("TimThaiMoTa");
            if (dr.GetBoolean("Seomocu") != null) _Seomocu = dr.GetBoolean("Seomocu");
            if (dr.GetBoolean("dauvetmo") != null) _dauvetmo = dr.GetBoolean("dauvetmo");
            //if (dr.GetBoolean("Sinhdoi") != null) _Sinhdoi = dr.GetBoolean("Sinhdoi");
            //if (dr.GetBoolean("Benhditruyen") != null) _Benhditruyen = dr.GetBoolean("Benhditruyen");
            //if (dr.GetBoolean("Caohuyetap") != null) _Caohuyetap = dr.GetBoolean("Caohuyetap");
            //if (dr.GetBoolean("Didang") != null) _Didang = dr.GetBoolean("Didang");
            //if (dr.GetBoolean("Daiduong") != null) _Daiduong = dr.GetBoolean("Daiduong");
            //if (dr.GetBoolean("Loaikhac") != null) _Loaikhac = dr.GetBoolean("Loaikhac");
            //if (dr.GetBoolean("Caohuyetapkhoa") != null) _Caohuyetapkhoa = dr.GetBoolean("Caohuyetapkhoa");
            //if (dr.GetBoolean("Than") != null) _Than = dr.GetBoolean("Than");
            //if (dr.GetBoolean("Moruotthua") != null) _Moruotthua = dr.GetBoolean("Moruotthua");
            //if (dr.GetBoolean("Tim") != null) _Tim = dr.GetBoolean("Tim");
            //if (dr.GetBoolean("Diungthuoc") != null) _Diungthuoc = dr.GetBoolean("Diungthuoc");
            //if (dr.GetBoolean("Laophoi") != null) _Laophoi = dr.GetBoolean("Laophoi");
            //if (dr.GetBoolean("Diungthuo") != null) _Diungthuoc = dr.GetBoolean("Diungthuo");
            //if (dr.GetBoolean("Viemtactinhmach") != null) _Viemtactinhmach = dr.GetBoolean("Viemtactinhmach");
            //if (dr.GetBoolean("Cuthe") != null) _Cuthe = dr.GetBoolean("Cuthe");
            //if (dr.GetBoolean("Henphequan") != null) _Henphequan = dr.GetBoolean("Henphequan");
            //if (dr.GetBoolean("Dongkinh") != null) _Dongkinh = dr.GetBoolean("Dongkinh");
            //if (dr.GetBoolean("UBT") != null) _UBT = dr.GetBoolean("UBT");
            //if (dr.GetBoolean("TSM") != null) _TSM = dr.GetBoolean("TSM");
            //if (dr.GetBoolean("UsoTC") != null) _UsoTC = dr.GetBoolean("UsoTC");
            //if (dr.GetBoolean("DieutriCTC") != null) _DieutriCTC = dr.GetBoolean("DieutriCTC");
            //if (dr.GetBoolean("DidangSD") != null) _DidangSD = dr.GetBoolean("DidangSD");
            //if (dr.GetBoolean("CatcutCTC") != null) _CatcutCTC = dr.GetBoolean("CatcutCTC");
            //if (dr.GetBoolean("SSD") != null) _SSD = dr.GetBoolean("SSD");
            //if (dr.GetBoolean("PARA") != null) _PARA = dr.GetBoolean("PARA");
            //if (dr.GetString("PTongbung") != null) _PTongbung = dr.GetString("PTongbung");
            //if (dr.GetString("Tuoicokinh") != null) _Tuoicokinh = dr.GetString("Tuoicokinh");
            //if (dr.GetString("Chukykinh") != null) _Chukykinh = dr.GetString("Chukykinh");
            //if (dr.GetString("Ngaythaykinh") != null) _Ngaythaykinh = dr.GetString("Ngaythaykinh");
            //if (dr.GetString("Tuoilaychong") != null) _Tuoilaychong = dr.GetString("Tuoilaychong");
            //if (dr.GetString("LoaikhacPT") != null) _LoaikhacPT = dr.GetString("LoaikhacPT");
            if (dr.GetString("BenhSu") != null) _BenhSu = dr.GetString("BenhSu");
            if (dr.GetString("HuongDT") != null) _HuongDT = dr.GetString("HuongDT");
            if (dr.GetString("Mabenh") != null) _Mabenh = dr.GetString("Mabenh");
            if (dr.GetString("MaBenhKem") != null) _MaBenhKem = dr.GetString("MaBenhKem");
            if (dr.GetString("MaBV") != null) _MaBV = dr.GetString("MaBV");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetString("tenBSKham") != null) _tenBSKham = dr.GetString("tenBSKham");
        
        }
		
		/// <summary>
		/// Insert the new <see cref="KhamBenh_SanSan" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh_SanSan
			// Copy & paste ham duoi day vao file DataProvider.cs
            DataProvider.Instance().InsertKhamBenh_SanSan(_MaSoKham, _sTT, _maDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _Rubella, _UonVan, _TiemChungKhac, _NgayDauKyKCC, _CannangTruoc, _TuoiThai, _Seomocu, _dauvetmo, _ngaydedukien, _ngaydedukienSA, _TaiTdThai, _ChieuCaoTC, _CTCVB, _NgoiThai, _SLThai,_TimThaiMoTa, _TimThai, _BatThuong, _Tuvan, _Chuandoan, _BenhKhac, _LoiDanBS,BenhSu, _HuongDT, _Mabenh, _MaBenhKem, _MaBV,_DieuTri , _maMay , _nguoiSD);
            MarkOld();
           // _MaSoKham = DataProvider.Instance().InsertKhamBenh_SanSan( _MaSoKham, _sTT, _maDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _Rubella, _UonVan, _TiemChungKhac, _NgayDauKyKCC, _CannangTruoc, _TuoiThai, _Seomocu, _dauvetmo, _ngaydedukien, _ngaydedukienSA, _TaiTdThai, _ChieuCaoTC, _CTCVB, _NgoiThai, _SLThai, _TimThai, _BatThuong, _Tuvan, _Chuandoan, _BenhKhac, _LoiDanBS, _Sinhdoi, _Benhditruyen, _Caohuyetap, _Didang, _Daiduong, _Loaikhac, _Caohuyetapkhoa, _Than, _Moruotthua, _Tim, _Basedow, _Laophoi, _Diungthuoc, _Viemtactinhmach, _Cuthe, _Henphequan, _Dongkinh, _PTongbung, _Tuoicokinh, _UBT, _TSM, _Chukykinh, _UsoTC, _DieutriCTC, _Ngaythaykinh, _DidangSD, _CatcutCTC, _Tuoilaychong, _SSD, _LoaikhacPT, _PARA, _BenhSu, _HuongDT, _Mabenh, _MaBenhKem, _MaBV, _maMay , _nguoiSD);
            // public abstract String InsertKhamBenh_SanSan(String _MaSoKham, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, Boolean _seoPTCu, String _chieuCaoTC, String _vongBung, String _timThai, Boolean _timThaiRo, String _luongGai, String _baudelocque, String _luongUNgoi, String _hinhDangTC, String _tuThe, String _conCoTC, String _vu, String _luongMao, String _luongMau, String _cutHaVe, String _amHo, String _amDao, String _coTuCung, SmartDate _oiVo, String _mauOi, String _ngoi, String _the, String _doLot, String _tangSinhMon, String _tinhTrangOi, String _oivoTuNhien, String _luongNuocOi, String _kieuThe, String _duongKinhNho, String _tomTat, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD);
            // public override String InsertKhamBenh_SanSan(String _MaSoKham, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, Boolean _seoPTCu, String _chieuCaoTC, String _vongBung, String _timThai, Boolean _timThaiRo, String _luongGai, String _baudelocque, String _luongUNgoi, String _hinhDangTC, String _tuThe, String _conCoTC, String _vu, String _luongMao, String _luongMau, String _cutHaVe, String _amHo, String _amDao, String _coTuCung, SmartDate _oiVo, String _mauOi, String _ngoi, String _the, String _doLot, String _tangSinhMon, String _tinhTrangOi, String _oivoTuNhien, String _luongNuocOi, String _kieuThe, String _duongKinhNho, String _tomTat, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD)

			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_San_CREATE", _MaSoKham, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _toanThan, _toanTrang, _cao, _tim, _gan, _phoi, _than, _benhKhac, _seoPTCu, _chieuCaoTC, _vongBung, _timThai, _timThaiRo, _luongGai, _baudelocque, _luongUNgoi, _hinhDangTC, _tuThe, _conCoTC, _vu, _luongMao, _luongMau, _cutHaVe, _amHo, _amDao, _coTuCung, _oiVo, _mauOi, _ngoi, _the, _doLot, _tangSinhMon, _tinhTrangOi, _oivoTuNhien, _luongNuocOi, _kieuThe, _duongKinhNho, _tomTat, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV,_maMay ,   _huy, _ngaySD.DBValue,_nguoiSD , _ngaySD1.DBValue, _nguoiSD1), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="KhamBenh_SanSan" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_SanSan
			if (IsDirty){
                DataProvider.Instance().UpdateKhamBenh_SanSan(_MaSoKham, _sTT, _maDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _Rubella, _UonVan, _TiemChungKhac, _NgayDauKyKCC, _CannangTruoc, _TuoiThai, _Seomocu, _dauvetmo, _ngaydedukien, _ngaydedukienSA, _TaiTdThai, _ChieuCaoTC, _CTCVB, _NgoiThai, _SLThai, _TimThaiMoTa, _TimThai, _BatThuong, _Tuvan, _Chuandoan, _BenhKhac, _LoiDanBS, _BenhSu, _HuongDT, _Mabenh, _MaBenhKem, _MaBV, _DieuTri, _maMay, _nguoiSD);
                MarkOld();
              //  DataProvider.Instance().UpdateKhamBenh_SanSan( _MaSoKham, _sTT, _maDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _Rubella, _UonVan, _TiemChungKhac, _NgayDauKyKCC, _CannangTruoc, _TuoiThai, _Seomocu, _dauvetmo, _ngaydedukien, _ngaydedukienSA, _TaiTdThai, _ChieuCaoTC, _CTCVB, _NgoiThai, _SLThai, _TimThai, _BatThuong, _Tuvan, _Chuandoan, _BenhKhac, _LoiDanBS, _Sinhdoi, _Benhditruyen, _Caohuyetap, _Didang, _Daiduong, _Loaikhac, _Caohuyetapkhoa, _Than, _Moruotthua, _Tim, _Basedow, _Laophoi, _Diungthuoc, _Viemtactinhmach, _Cuthe, _Henphequan, _Dongkinh, _PTongbung, _Tuoicokinh, _UBT, _TSM, _Chukykinh, _UsoTC, _DieutriCTC, _Ngaythaykinh, _DidangSD, _CatcutCTC, _Tuoilaychong, _SSD, _LoaikhacPT, _PARA, _BenhSu, _HuongDT, _Mabenh, _MaBenhKem, _MaBV, _maMay , _nguoiSD);
                // public abstract void UpdateKhamBenh_SanSan(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, Boolean _seoPTCu, String _chieuCaoTC, String _vongBung, String _timThai, Boolean _timThaiRo, String _luongGai, String _baudelocque, String _luongUNgoi, String _hinhDangTC, String _tuThe, String _conCoTC, String _vu, String _luongMao, String _luongMau, String _cutHaVe, String _amHo, String _amDao, String _coTuCung, SmartDate _oiVo, String _mauOi, String _ngoi, String _the, String _doLot, String _tangSinhMon, String _tinhTrangOi, String _oivoTuNhien, String _luongNuocOi, String _kieuThe, String _duongKinhNho, String _tomTat, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD);
                // public override void UpdateKhamBenh_SanSan(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, Boolean _seoPTCu, String _chieuCaoTC, String _vongBung, String _timThai, Boolean _timThaiRo, String _luongGai, String _baudelocque, String _luongUNgoi, String _hinhDangTC, String _tuThe, String _conCoTC, String _vu, String _luongMao, String _luongMau, String _cutHaVe, String _amHo, String _amDao, String _coTuCung, SmartDate _oiVo, String _mauOi, String _ngoi, String _the, String _doLot, String _tangSinhMon, String _tinhTrangOi, String _oivoTuNhien, String _luongNuocOi, String _kieuThe, String _duongKinhNho, String _tomTat, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD)

				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_San_UPDATE", _MaSoKham, _sTT, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _toanThan, _toanTrang, _cao, _tim, _gan, _phoi, _than, _benhKhac, _seoPTCu, _chieuCaoTC, _vongBung, _timThai, _timThaiRo, _luongGai, _baudelocque, _luongUNgoi, _hinhDangTC, _tuThe, _conCoTC, _vu, _luongMao, _luongMau, _cutHaVe, _amHo, _amDao, _coTuCung, _oiVo, _mauOi, _ngoi, _the, _doLot, _tangSinhMon, _tinhTrangOi, _oivoTuNhien, _luongNuocOi, _kieuThe, _duongKinhNho, _tomTat, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV,_maMay ,   _huy, _nguoiSD );
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD    , _MaSoKham, _sTT));
		}

		/// <summary>
		/// Delete the <see cref="KhamBenh_SanSan" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_SanSan
            DataProvider.Instance().DeleteKhamBenh_SanSan(crit.MaMay, crit.NguoiSD, crit.MaSoKham, crit.STT);
			// public abstract void DeleteKhamBenh_SanSan(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa);
			// public override void DeleteKhamBenh_SanSan(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_San_Deleted", _MaSoKham, _sTT, _sTTKhoa);
			// }
		}

        internal virtual void Insert(KhamBenh_C obj)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh_SanSan
            // Copy & paste ham duoi day vao file DataProvider.cs
            DataProvider.Instance().InsertKhamBenh_SanSan(obj.MaSoKham, obj.STT, obj.MaDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _Rubella, _UonVan, _TiemChungKhac, _NgayDauKyKCC, _CannangTruoc, _TuoiThai, _Seomocu, _dauvetmo, _ngaydedukien, _ngaydedukienSA, _TaiTdThai, _ChieuCaoTC, _CTCVB, _NgoiThai, _SLThai,_TimThaiMoTa, _TimThai, _BatThuong, _Tuvan, _Chuandoan, _BenhKhac, _LoiDanBS, _BenhSu, _HuongDT, _Mabenh, _MaBenhKem, _MaBV, _DieuTri, _maMay, _nguoiSD);
             MarkOld();
            //_MaSoKham = DataProvider.Instance().InsertKhamBenh_SanSan( _MaSoKham, _sTT, _maDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _Rubella, _UonVan, _TiemChungKhac, _NgayDauKyKCC, _CannangTruoc, _TuoiThai, _Seomocu, _dauvetmo, _ngaydedukien, _ngaydedukienSA, _TaiTdThai, _ChieuCaoTC, _CTCVB, _NgoiThai, _SLThai, _TimThai, _BatThuong, _Tuvan, _Chuandoan, _BenhKhac, _LoiDanBS, _Sinhdoi, _Benhditruyen, _Caohuyetap, _Didang, _Daiduong, _Loaikhac, _Caohuyetapkhoa, _Than, _Moruotthua, _Tim, _Basedow, _Laophoi, _Diungthuoc, _Viemtactinhmach, _Cuthe, _Henphequan, _Dongkinh, _PTongbung, _Tuoicokinh, _UBT, _TSM, _Chukykinh, _UsoTC, _DieutriCTC, _Ngaythaykinh, _DidangSD, _CatcutCTC, _Tuoilaychong, _SSD, _LoaikhacPT, _PARA, _BenhSu, _HuongDT, _Mabenh, _MaBenhKem, _MaBV, _maMay , _nguoiSD);
            // public abstract String InsertKhamBenh_SanSan(String _MaSoKham, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, Boolean _seoPTCu, String _chieuCaoTC, String _vongBung, String _timThai, Boolean _timThaiRo, String _luongGai, String _baudelocque, String _luongUNgoi, String _hinhDangTC, String _tuThe, String _conCoTC, String _vu, String _luongMao, String _luongMau, String _cutHaVe, String _amHo, String _amDao, String _coTuCung, SmartDate _oiVo, String _mauOi, String _ngoi, String _the, String _doLot, String _tangSinhMon, String _tinhTrangOi, String _oivoTuNhien, String _luongNuocOi, String _kieuThe, String _duongKinhNho, String _tomTat, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD);
            // public override String InsertKhamBenh_SanSan(String _MaSoKham, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, Boolean _seoPTCu, String _chieuCaoTC, String _vongBung, String _timThai, Boolean _timThaiRo, String _luongGai, String _baudelocque, String _luongUNgoi, String _hinhDangTC, String _tuThe, String _conCoTC, String _vu, String _luongMao, String _luongMau, String _cutHaVe, String _amHo, String _amDao, String _coTuCung, SmartDate _oiVo, String _mauOi, String _ngoi, String _the, String _doLot, String _tangSinhMon, String _tinhTrangOi, String _oivoTuNhien, String _luongNuocOi, String _kieuThe, String _duongKinhNho, String _tomTat, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD)

            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_San_CREATE", _MaSoKham, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _toanThan, _toanTrang, _cao, _tim, _gan, _phoi, _than, _benhKhac, _seoPTCu, _chieuCaoTC, _vongBung, _timThai, _timThaiRo, _luongGai, _baudelocque, _luongUNgoi, _hinhDangTC, _tuThe, _conCoTC, _vu, _luongMao, _luongMau, _cutHaVe, _amHo, _amDao, _coTuCung, _oiVo, _mauOi, _ngoi, _the, _doLot, _tangSinhMon, _tinhTrangOi, _oivoTuNhien, _luongNuocOi, _kieuThe, _duongKinhNho, _tomTat, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV,_maMay ,   _huy, _ngaySD.DBValue,_nguoiSD , _ngaySD1.DBValue, _nguoiSD1), String);
            // }
        }

        /// <summary>
        /// Update all changes made on <see cref="KhamBenh_SanSan" /> Object to underlying database.
        /// </summary>
       internal virtual void Update(KhamBenh_C obj)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_SanSan
            if (IsDirty)
            {
                DataProvider.Instance().UpdateKhamBenh_SanSan(_MaSoKham, _sTT, _maDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _Rubella, _UonVan, _TiemChungKhac, _NgayDauKyKCC, _CannangTruoc, _TuoiThai, _Seomocu, _dauvetmo, _ngaydedukien, _ngaydedukienSA, _TaiTdThai, _ChieuCaoTC, _CTCVB, _NgoiThai, _SLThai,_TimThaiMoTa, _TimThai, _BatThuong, _Tuvan, _Chuandoan, _BenhKhac, _LoiDanBS, _BenhSu, _HuongDT, _Mabenh, _MaBenhKem, _MaBV, _DieuTri, _maMay, _nguoiSD);
                MarkOld();
                //DataProvider.Instance().UpdateKhamBenh_SanSan( _MaSoKham, _sTT, _maDV, _ngayKham, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _Rubella, _UonVan, _TiemChungKhac, _NgayDauKyKCC, _CannangTruoc, _TuoiThai, _Seomocu, _dauvetmo, _ngaydedukien, _ngaydedukienSA, _TaiTdThai, _ChieuCaoTC, _CTCVB, _NgoiThai, _SLThai, _TimThai, _BatThuong, _Tuvan, _Chuandoan, _BenhKhac, _LoiDanBS, _Sinhdoi, _Benhditruyen, _Caohuyetap, _Didang, _Daiduong, _Loaikhac, _Caohuyetapkhoa, _Than, _Moruotthua, _Tim, _Basedow, _Laophoi, _Diungthuoc, _Viemtactinhmach, _Cuthe, _Henphequan, _Dongkinh, _PTongbung, _Tuoicokinh, _UBT, _TSM, _Chukykinh, _UsoTC, _DieutriCTC, _Ngaythaykinh, _DidangSD, _CatcutCTC, _Tuoilaychong, _SSD, _LoaikhacPT, _PARA, _BenhSu, _HuongDT, _Mabenh, _MaBenhKem, _MaBV, _maMay , _nguoiSD);
                // public abstract void UpdateKhamBenh_SanSan(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, Boolean _seoPTCu, String _chieuCaoTC, String _vongBung, String _timThai, Boolean _timThaiRo, String _luongGai, String _baudelocque, String _luongUNgoi, String _hinhDangTC, String _tuThe, String _conCoTC, String _vu, String _luongMao, String _luongMau, String _cutHaVe, String _amHo, String _amDao, String _coTuCung, SmartDate _oiVo, String _mauOi, String _ngoi, String _the, String _doLot, String _tangSinhMon, String _tinhTrangOi, String _oivoTuNhien, String _luongNuocOi, String _kieuThe, String _duongKinhNho, String _tomTat, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD);
                // public override void UpdateKhamBenh_SanSan(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, Boolean _phu, String _toanThan, String _toanTrang, String _cao, String _tim, String _gan, String _phoi, String _than, String _benhKhac, Boolean _seoPTCu, String _chieuCaoTC, String _vongBung, String _timThai, Boolean _timThaiRo, String _luongGai, String _baudelocque, String _luongUNgoi, String _hinhDangTC, String _tuThe, String _conCoTC, String _vu, String _luongMao, String _luongMau, String _cutHaVe, String _amHo, String _amDao, String _coTuCung, SmartDate _oiVo, String _mauOi, String _ngoi, String _the, String _doLot, String _tangSinhMon, String _tinhTrangOi, String _oivoTuNhien, String _luongNuocOi, String _kieuThe, String _duongKinhNho, String _tomTat, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD)

                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_San_UPDATE", _MaSoKham, _sTT, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _phu, _toanThan, _toanTrang, _cao, _tim, _gan, _phoi, _than, _benhKhac, _seoPTCu, _chieuCaoTC, _vongBung, _timThai, _timThaiRo, _luongGai, _baudelocque, _luongUNgoi, _hinhDangTC, _tuThe, _conCoTC, _vu, _luongMao, _luongMau, _cutHaVe, _amHo, _amDao, _coTuCung, _oiVo, _mauOi, _ngoi, _the, _doLot, _tangSinhMon, _tinhTrangOi, _oivoTuNhien, _luongNuocOi, _kieuThe, _duongKinhNho, _tomTat, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV,_maMay ,   _huy, _nguoiSD );
                // }				
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
              
            DataProvider.Instance().DeleteKhamBenh_SanSan(_maMay, _nguoiSD , obj.MaSoKham, _sTT);
            MarkNew();
        }

		#endregion
	}

}
