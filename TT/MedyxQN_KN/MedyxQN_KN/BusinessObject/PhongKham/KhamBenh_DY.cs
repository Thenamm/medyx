// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	KhamBenh_DY
// Kieu doi tuong  :	KhamBenh_DY
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
	/// This is a base generated class of <see cref="KhamBenh_DY" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class KhamBenh_DY : BusinessBase<KhamBenh_DY>
	{
		#region Business Methods
		
		#region State Fields
        private String _mabhxh = String.Empty;
        private String _tenBV = String.Empty;
		private String _MaSoKham = String.Empty;
		private Int32 _sTT = 0;
        private String _maDV = String.Empty;
		private SmartDate _ngayKham = new SmartDate(true);
        private SmartDate _ngayKhamD = new SmartDate(true);
		private String _bSKHAM = String.Empty;
		private String _lyDoKham = String.Empty;
		private String _mach = String.Empty;
		private String _apHuyet = String.Empty;
		private String _nhietDo = String.Empty;
		private String _nhipTho = String.Empty;
		private String _canNang = String.Empty;
        private String _chieuCao = String.Empty;
        private String _toanThan = String.Empty;
        private Boolean _Rubella = false;
        private Boolean _UonVan = false;
        private Boolean _TiemChungKhac = false;

        private Boolean _Batcuong_Bieu =false;
        private Boolean _Batcuong_Ly = false;
        private Boolean _Batcuong_Hu = false;
        private Boolean _Batcuong_Thuc = false;
        private Boolean _Batcuong_Han = false;
        private Boolean _Batcuong_Nhiet = false;
        private Boolean _Batcuong_Am = false;
        private Boolean _Batcuong_Duong = false;

        private Boolean _Tangphu_Tam = false;
        private Boolean _Tangphu_Can = false;
        private Boolean _Tangphu_Ty = false;
        private Boolean _Tangphu_Phe = false;
        private Boolean _Tangphu_Than = false;
        private Boolean _Tangphu_TamBao = false;
        private Boolean _Tangphu_vi = false;
        private Boolean _Tangphu_Dom = false;
        private Boolean _Tangphu_DaiTrang = false;
        private Boolean _Tangphu_TieuTruong = false;
        private Boolean _Tangphu_BangQuang = false;
        private Boolean _Tangphu_TamTieu = false;
        private Boolean _Tangphu_PhuKyHang = false;

        private Boolean _KinhMach_Tam = false;
        private Boolean _KinhMach_Can = false;
        private Boolean _KinhMach_Ty = false;
        private Boolean _KinhMach_Phe = false;
        private Boolean _KinhMach_Than = false;
        private Boolean _KinhMach_vi = false;
        private Boolean _KinhMach_Dom = false;
        private Boolean _KinhMach_DaiTruong = false;
        private Boolean _KinhMach_TieuTruong = false;
        private Boolean _KinhMach_BangQuang = false;
        private Boolean _KinhMach_TamBaoLac = false;
        private Boolean _KinhMach_TamTieu = false;
        private Boolean _KinhMach_MachDoc = false;
        private Boolean _KinhMach_MachNham = false;

        private Boolean _DinhViTheo_Dinh = false;
        private Boolean _DinhViTheo_Ve = false;
        private Boolean _DinhViTheo_Khi = false;
        private Boolean _DinhViTheo_Huyet = false;

        private Boolean _NguyenNhan_NoiNhan = false;
        private Boolean _NguyenNhan_NgoaiNhan = false;
        private Boolean _NguyenNhan_BatNoiNgoaiNhan = false;
        private Boolean _huy = false;


        private String _BenhLyKhac = String.Empty;
		private String _dieuTri = String.Empty;
		private String _benhSu = String.Empty;
		private String _huongDT = String.Empty;
		private String _mabenh = String.Empty;
		private String _maBenhKem = String.Empty;
		private String _MaBV = String.Empty;
		private String _maMay = String.Empty;
		private Boolean CGM = false;
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
        public Boolean Batcuong_Bieu
        {
            get
            {
                CanReadProperty("Batcuong_Bieu", true);
                return _Batcuong_Bieu;
            }
            set
            {
                CanWriteProperty("Batcuong_Bieu", true);
                if (_Batcuong_Bieu != value)
                {
                    _Batcuong_Bieu = value;
                    PropertyHasChanged("Batcuong_Bieu");
                }
            }
        }
        public Boolean Batcuong_Ly
        {
            get
            {
                CanReadProperty("Batcuong_Ly", true);
                return _Batcuong_Ly;
            }
            set
            {
                CanWriteProperty("Batcuong_Ly", true);
                if (_Batcuong_Ly != value)
                {
                    _Batcuong_Ly = value;
                    PropertyHasChanged("Batcuong_Ly");
                }
            }
        }
        public Boolean Batcuong_Hu
        {
            get
            {
                CanReadProperty("Batcuong_Hu", true);
                return _Batcuong_Hu;
            }
            set
            {
                CanWriteProperty("Batcuong_Hu", true);
                if (_Batcuong_Hu != value)
                {
                    _Batcuong_Hu = value;
                    PropertyHasChanged("Batcuong_Hu");
                }
            }
        }
        public Boolean Batcuong_Thuc
        {
            get
            {
                CanReadProperty("Batcuong_Thuc", true);
                return _Batcuong_Thuc;
            }
            set
            {
                CanWriteProperty("Batcuong_Thuc", true);
                if (_Batcuong_Thuc != value)
                {
                    _Batcuong_Thuc = value;
                    PropertyHasChanged("Batcuong_Thuc");
                }
            }
        }
        public Boolean Batcuong_Han
        {
            get
            {
                CanReadProperty("Batcuong_Han", true);
                return _Batcuong_Han;
            }
            set
            {
                CanWriteProperty("Batcuong_Han", true);
                if (_Batcuong_Han != value)
                {
                    _Batcuong_Han = value;
                    PropertyHasChanged("Batcuong_Han");
                }
            }
        }
        public Boolean Batcuong_Nhiet
        {
            get
            {
                CanReadProperty("Batcuong_Nhiet", true);
                return _Batcuong_Nhiet;
            }
            set
            {
                CanWriteProperty("Batcuong_Nhiet", true);
                if (_Batcuong_Nhiet != value)
                {
                    _Batcuong_Nhiet = value;
                    PropertyHasChanged("Batcuong_Nhiet");
                }
            }
        }
        public Boolean Batcuong_Am
        {
            get
            {
                CanReadProperty("Batcuong_Am", true);
                return _Batcuong_Am;
            }
            set
            {
                CanWriteProperty("Batcuong_Am", true);
                if (_Batcuong_Am != value)
                {
                    _Batcuong_Am = value;
                    PropertyHasChanged("Batcuong_Am");
                }
            }
        }
        public Boolean Batcuong_Duong
        {
            get
            {
                CanReadProperty("Batcuong_Duong", true);
                return _Batcuong_Duong;
            }
            set
            {
                CanWriteProperty("Batcuong_Duong", true);
                if (_Batcuong_Duong != value)
                {
                    _Batcuong_Duong = value;
                    PropertyHasChanged("Batcuong_Duong");
                }
            }
        }

        public Boolean Tangphu_Tam
        {
            get
            {
                CanReadProperty("Tangphu_Tam", true);
                return _Tangphu_Tam;
            }
            set
            {
                CanWriteProperty("Tangphu_Tam", true);
                if (_Tangphu_Tam != value)
                {
                    _Tangphu_Tam = value;
                    PropertyHasChanged("Tangphu_Tam");
                }
            }
        }
        public Boolean Tangphu_Can
        {
            get
            {
                CanReadProperty("Tangphu_Can", true);
                return _Tangphu_Can;
            }
            set
            {
                CanWriteProperty("Tangphu_Can", true);
                if (_Tangphu_Can != value)
                {
                    _Tangphu_Can = value;
                    PropertyHasChanged("Tangphu_Can");
                }
            }
        }
        public Boolean Tangphu_Ty
        {
            get
            {
                CanReadProperty("Tangphu_Ty", true);
                return _Tangphu_Ty;
            }
            set
            {
                CanWriteProperty("Tangphu_Ty", true);
                if (_Tangphu_Ty != value)
                {
                    _Tangphu_Ty = value;
                    PropertyHasChanged("Tangphu_Ty");
                }
            }
        }
        public Boolean Tangphu_Phe
        {
            get
            {
                CanReadProperty("Tangphu_Phe", true);
                return _Tangphu_Phe;
            }
            set
            {
                CanWriteProperty("Tangphu_Phe", true);
                if (_Tangphu_Phe != value)
                {
                    _Tangphu_Phe = value;
                    PropertyHasChanged("Tangphu_Phe");
                }
            }
        }
        public Boolean Tangphu_Than
        {
            get
            {
                CanReadProperty("Tangphu_Than", true);
                return _Tangphu_Than;
            }
            set
            {
                CanWriteProperty("Tangphu_Than", true);
                if (_Tangphu_Than != value)
                {
                    _Tangphu_Than = value;
                    PropertyHasChanged("Tangphu_Than");
                }
            }
        }
        public Boolean Tangphu_TamBao
        {
            get
            {
                CanReadProperty("Tangphu_TamBao", true);
                return _Tangphu_TamBao;
            }
            set
            {
                CanWriteProperty("Tangphu_TamBao", true);
                if (_Tangphu_TamBao != value)
                {
                    _Tangphu_TamBao = value;
                    PropertyHasChanged("Tangphu_TamBao");
                }
            }
        }
        public Boolean Tangphu_vi
        {
            get
            {
                CanReadProperty("Tangphu_vi", true);
                return _Tangphu_vi;
            }
            set
            {
                CanWriteProperty("Tangphu_vi", true);
                if (_Tangphu_vi != value)
                {
                    _Tangphu_vi = value;
                    PropertyHasChanged("Tangphu_vi");
                }
            }
        }
        public Boolean Tangphu_Dom
        {
            get
            {
                CanReadProperty("Tangphu_Dom", true);
                return _Tangphu_Dom;
            }
            set
            {
                CanWriteProperty("Tangphu_Dom", true);
                if (_Tangphu_Dom != value)
                {
                    _Tangphu_Dom = value;
                    PropertyHasChanged("Tangphu_Dom");
                }
            }
        }
        public Boolean Tangphu_DaiTrang
        {
            get
            {
                CanReadProperty("Tangphu_DaiTrang", true);
                return _Tangphu_DaiTrang;
            }
            set
            {
                CanWriteProperty("Tangphu_DaiTrang", true);
                if (_Tangphu_DaiTrang != value)
                {
                    _Tangphu_DaiTrang = value;
                    PropertyHasChanged("Tangphu_DaiTrang");
                }
            }
        }
        public Boolean Tangphu_TieuTruong
        {
            get
            {
                CanReadProperty("Tangphu_TieuTruong", true);
                return _Tangphu_TieuTruong;
            }
            set
            {
                CanWriteProperty("Tangphu_TieuTruong", true);
                if (_Tangphu_TieuTruong != value)
                {
                    _Tangphu_TieuTruong = value;
                    PropertyHasChanged("Tangphu_TieuTruong");
                }
            }
        }
        public Boolean Tangphu_BangQuang
        {
            get
            {
                CanReadProperty("Tangphu_BangQuang", true);
                return _Tangphu_BangQuang;
            }
            set
            {
                CanWriteProperty("Tangphu_BangQuang", true);
                if (_Tangphu_BangQuang != value)
                {
                    _Tangphu_BangQuang = value;
                    PropertyHasChanged("Tangphu_BangQuang");
                }
            }
        }
        public Boolean Tangphu_TamTieu
        {
            get
            {
                CanReadProperty("Tangphu_TamTieu", true);
                return _Tangphu_TamTieu;
            }
            set
            {
                CanWriteProperty("Tangphu_TamTieu", true);
                if (_Tangphu_TamTieu != value)
                {
                    _Tangphu_TamTieu = value;
                    PropertyHasChanged("Tangphu_TamTieu");
                }
            }
        }
        public Boolean Tangphu_PhuKyHang
        {
            get
            {
                CanReadProperty("Tangphu_PhuKyHang", true);
                return _Tangphu_PhuKyHang;
            }
            set
            {
                CanWriteProperty("Tangphu_PhuKyHang", true);
                if (_Tangphu_PhuKyHang != value)
                {
                    _Tangphu_PhuKyHang = value;
                    PropertyHasChanged("Tangphu_PhuKyHang");
                }
            }
        }


        public Boolean KinhMach_Tam
        {
            get
            {
                CanReadProperty("KinhMach_Tam", true);
                return _KinhMach_Tam;
            }
            set
            {
                CanWriteProperty("KinhMach_Tam", true);
                if (_KinhMach_Tam != value)
                {
                    _KinhMach_Tam = value;
                    PropertyHasChanged("KinhMach_Tam");
                }
            }
        }
        public Boolean KinhMach_Can
        {
            get
            {
                CanReadProperty("KinhMach_Can", true);
                return _KinhMach_Can;
            }
            set
            {
                CanWriteProperty("KinhMach_Can", true);
                if (_KinhMach_Can != value)
                {
                    _KinhMach_Can = value;
                    PropertyHasChanged("KinhMach_Can");
                }
            }
        }
        public Boolean KinhMach_Ty
        {
            get
            {
                CanReadProperty("KinhMach_Ty", true);
                return _KinhMach_Ty;
            }
            set
            {
                CanWriteProperty("KinhMach_Ty", true);
                if (_KinhMach_Ty != value)
                {
                    _KinhMach_Ty = value;
                    PropertyHasChanged("KinhMach_Ty");
                }
            }
        }
        public Boolean KinhMach_Phe
        {
            get
            {
                CanReadProperty("KinhMach_Phe", true);
                return _KinhMach_Phe;
            }
            set
            {
                CanWriteProperty("KinhMach_Phe", true);
                if (_KinhMach_Phe != value)
                {
                    _KinhMach_Phe = value;
                    PropertyHasChanged("KinhMach_Phe");
                }
            }
        }
        public Boolean KinhMach_Than
        {
            get
            {
                CanReadProperty("KinhMach_Than", true);
                return _KinhMach_Than;
            }
            set
            {
                CanWriteProperty("KinhMach_Than", true);
                if (_KinhMach_Than != value)
                {
                    _KinhMach_Than = value;
                    PropertyHasChanged("KinhMach_Than");
                }
            }
        }
        public Boolean KinhMach_vi
        {
            get
            {
                CanReadProperty("KinhMach_vi", true);
                return _KinhMach_vi;
            }
            set
            {
                CanWriteProperty("KinhMach_vi", true);
                if (_KinhMach_vi != value)
                {
                    _KinhMach_vi = value;
                    PropertyHasChanged("KinhMach_vi");
                }
            }
        }
        public Boolean KinhMach_Dom
        {
            get
            {
                CanReadProperty("KinhMach_Dom", true);
                return _KinhMach_Dom;
            }
            set
            {
                CanWriteProperty("KinhMach_Dom", true);
                if (_KinhMach_Dom != value)
                {
                    _KinhMach_Dom = value;
                    PropertyHasChanged("KinhMach_Dom");
                }
            }
        }
        public Boolean KinhMach_DaiTruong
        {
            get
            {
                CanReadProperty("KinhMach_DaiTruong", true);
                return _KinhMach_DaiTruong;
            }
            set
            {
                CanWriteProperty("KinhMach_DaiTruong", true);
                if (_KinhMach_DaiTruong != value)
                {
                    _KinhMach_DaiTruong = value;
                    PropertyHasChanged("KinhMach_DaiTruong");
                }
            }
        }
        public Boolean KinhMach_TieuTruong
        {
            get
            {
                CanReadProperty("KinhMach_TieuTruong", true);
                return _KinhMach_TieuTruong;
            }
            set
            {
                CanWriteProperty("KinhMach_TieuTruong", true);
                if (_KinhMach_TieuTruong != value)
                {
                    _KinhMach_TieuTruong = value;
                    PropertyHasChanged("KinhMach_TieuTruong");
                }
            }
        }
        public Boolean KinhMach_BangQuang
        {
            get
            {
                CanReadProperty("KinhMach_BangQuang", true);
                return _KinhMach_BangQuang;
            }
            set
            {
                CanWriteProperty("KinhMach_BangQuang", true);
                if (_KinhMach_BangQuang != value)
                {
                    _KinhMach_BangQuang = value;
                    PropertyHasChanged("KinhMach_BangQuang");
                }
            }
        }
        public Boolean KinhMach_TamTieu
        {
            get
            {
                CanReadProperty("KinhMach_TamTieu", true);
                return _KinhMach_TamTieu;
            }
            set
            {
                CanWriteProperty("KinhMach_TamTieu", true);
                if (_KinhMach_TamTieu != value)
                {
                    _KinhMach_TamTieu = value;
                    PropertyHasChanged("KinhMach_TamTieu");
                }
            }
        }
        public Boolean KinhMach_TamBaoLac
        {
            get
            {
                CanReadProperty("KinhMach_TamBaoLac", true);
                return _KinhMach_TamBaoLac;
            }
            set
            {
                CanWriteProperty("KinhMach_TamBaoLac", true);
                if (_KinhMach_TamBaoLac != value)
                {
                    _KinhMach_TamBaoLac = value;
                    PropertyHasChanged("KinhMach_TamBaoLac");
                }
            }
        }
        public Boolean KinhMach_MachDoc
        {
            get
            {
                CanReadProperty("KinhMach_MachDoc", true);
                return _KinhMach_MachDoc;
            }
            set
            {
                CanWriteProperty("KinhMach_MachDoc", true);
                if (_KinhMach_MachDoc != value)
                {
                    _KinhMach_MachDoc = value;
                    PropertyHasChanged("KinhMach_MachDoc");
                }
            }
        }
        public Boolean KinhMach_MachNham
        {
            get
            {
                CanReadProperty("KinhMach_MachNham", true);
                return _KinhMach_MachNham;
            }
            set
            {
                CanWriteProperty("KinhMach_MachNham", true);
                if (_KinhMach_MachNham != value)
                {
                    _KinhMach_MachNham = value;
                    PropertyHasChanged("KinhMach_MachNham");
                }
            }
        }


        public Boolean DinhViTheo_Dinh
        {
            get
            {
                CanReadProperty("DinhViTheo_Dinh", true);
                return _DinhViTheo_Dinh;
            }
            set
            {
                CanWriteProperty("DinhViTheo_Dinh", true);
                if (_DinhViTheo_Dinh != value)
                {
                    _DinhViTheo_Dinh = value;
                    PropertyHasChanged("DinhViTheo_Dinh");
                }
            }
        }
        public Boolean DinhViTheo_Ve
        {
            get
            {
                CanReadProperty("DinhViTheo_Ve", true);
                return _DinhViTheo_Ve;
            }
            set
            {
                CanWriteProperty("DinhViTheo_Ve", true);
                if (_DinhViTheo_Ve != value)
                {
                    _DinhViTheo_Ve = value;
                    PropertyHasChanged("DinhViTheo_Ve");
                }
            }
        }
        public Boolean DinhViTheo_Khi
        {
            get
            {
                CanReadProperty("DinhViTheo_Khi", true);
                return _DinhViTheo_Khi;
            }
            set
            {
                CanWriteProperty("DinhViTheo_Khi", true);
                if (_DinhViTheo_Khi != value)
                {
                    _DinhViTheo_Khi = value;
                    PropertyHasChanged("DinhViTheo_Khi");
                }
            }
        }
        public Boolean DinhViTheo_Huyet
        {
            get
            {
                CanReadProperty("DinhViTheo_Huyet", true);
                return _DinhViTheo_Huyet;
            }
            set
            {
                CanWriteProperty("DinhViTheo_Huyet", true);
                if (_DinhViTheo_Huyet != value)
                {
                    _DinhViTheo_Huyet = value;
                    PropertyHasChanged("DinhViTheo_Huyet");
                }
            }
        }
        public Boolean NguyenNhan_NoiNhan
        {
            get
            {
                CanReadProperty("NguyenNhan_NoiNhan", true);
                return _NguyenNhan_NoiNhan;
            }
            set
            {
                CanWriteProperty("NguyenNhan_NoiNhan", true);
                if (_NguyenNhan_NoiNhan != value)
                {
                    _NguyenNhan_NoiNhan = value;
                    PropertyHasChanged("NguyenNhan_NoiNhan");
                }
            }
        }
        public Boolean NguyenNhan_NgoaiNhan
        {
            get
            {
                CanReadProperty("NguyenNhan_NgoaiNhan", true);
                return _NguyenNhan_NgoaiNhan;
            }
            set
            {
                CanWriteProperty("NguyenNhan_NgoaiNhan", true);
                if (_NguyenNhan_NgoaiNhan != value)
                {
                    _NguyenNhan_NgoaiNhan = value;
                    PropertyHasChanged("NguyenNhan_NgoaiNhan");
                }
            }
        }
        public Boolean NguyenNhan_BatNoiNgoaiNhan
        {
            get
            {
                CanReadProperty("NguyenNhan_BatNoiNgoaiNhan", true);
                return _NguyenNhan_BatNoiNgoaiNhan;
            }
            set
            {
                CanWriteProperty("NguyenNhan_BatNoiNgoaiNhan", true);
                if (_NguyenNhan_BatNoiNgoaiNhan != value)
                {
                    _NguyenNhan_BatNoiNgoaiNhan = value;
                    PropertyHasChanged("NguyenNhan_BatNoiNgoaiNhan");
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
		
		
		

		public String BenhLyKhac
		{
            get
            {
                CanReadProperty("BenhLyKhac", true);
                return _BenhLyKhac;
            }
            set
            {
                CanWriteProperty("BenhLyKhac", true);
                if (_BenhLyKhac != value)
                {
                    _BenhLyKhac = value;
                    PropertyHasChanged("BenhLyKhac");
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
        /// Factory method. New <see cref="KhamBenh_DY" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 

        public static KhamBenh_DY NewKhamBenh_DY()
        {
            return new KhamBenh_DY();
            //return DataPortal.Create<DMDichVu_PhieuIn_C>();
        }
        public static KhamBenh_DY NewKhamBenh_DY(string idDMDichvu)
        {
            return new KhamBenh_DY(DMDichVu.GetDMDichVu(idDMDichvu));
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static KhamBenh_DY NewKhamBenh_DY(DMDichVu _DMDichvu)
        {
            return new KhamBenh_DY(_DMDichvu);
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static KhamBenh_DY NewKhamBenh_DY(string masokham, Int32 stt, string idDMDichvu)
        {
            return new KhamBenh_DY(masokham, stt, idDMDichvu);
        }

        public static KhamBenh_DY GetKhamBenh_DY(String maSoKham, Int32 sTT)
        {
            return DataPortal.Fetch<KhamBenh_DY>(new Criteria(maSoKham, sTT));
        }

        public static KhamBenh_DY GetKhamBenh_DY(SafeDataReader dr)
        {
            return new KhamBenh_DY(dr);
        }

        /// <summary>
        /// Marks the <see cref="KhamBenh_DY" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteKhamBenh_DY(String maSoKham, Int32 sTT, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maSoKham, sTT));
        }

        #endregion
		
			#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal KhamBenh_DY()
		{	
			// Prevent direct creation
		}
		
        protected KhamBenh_DY(DMDichVu pro)
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
        protected KhamBenh_DY(string maSoKham,DMDichVu pro)
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
        protected KhamBenh_DY(string masokham, Int32 stt, string idDMDichvu)
        {
            MarkAsChild();

            _MaSoKham = masokham ;
            _maDV = idDMDichvu ;
            _sTT = stt;
            //  _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_DY(SafeDataReader dr)
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
		/// Retrieve an existing <see cref="KhamBenh_DY" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetKhamBenh_DY(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa);
			// public override IDataReader GetKhamBenh_DY(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_DY_GET", _MaSoKham, _sTT, _sTTKhoa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKhamBenh_DY(crit.MaSoKham, crit.STT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="KhamBenh_DY" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaSoKham") != null) _MaSoKham = dr.GetString("MaSoKham");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
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
            if (dr.GetString("mabhxh") != null) _mabhxh = dr.GetString("mabhxh");
            if (dr.GetString("tenBV") != null) _tenBV = dr.GetString("tenBV");
            if (dr.GetString("ToanThan") != null) _toanThan = dr.GetString("ToanThan");
            //if (dr.GetBoolean("Rubella") != null) _Rubella = dr.GetBoolean("Rubella");
            //if (dr.GetBoolean("UonVan") != null) _UonVan = dr.GetBoolean("UonVan");
            //if (dr.GetBoolean("TiemChungKhac") != null) _TiemChungKhac = dr.GetBoolean("TiemChungKhac");
            if (dr.GetBoolean("Batcuong_Bieu") != null) _Batcuong_Bieu = dr.GetBoolean("Batcuong_Bieu");
            if (dr.GetBoolean("Batcuong_Ly") != null) _Batcuong_Ly = dr.GetBoolean("Batcuong_Ly");
            if (dr.GetBoolean("Batcuong_Hu") != null) _Batcuong_Hu = dr.GetBoolean("Batcuong_Hu");
            if (dr.GetBoolean("Batcuong_Thuc") != null) _Batcuong_Thuc = dr.GetBoolean("Batcuong_Thuc");
            if (dr.GetBoolean("Batcuong_Han") != null) _Batcuong_Han = dr.GetBoolean("Batcuong_Han");
            if (dr.GetBoolean("Batcuong_Nhiet") != null) _Batcuong_Nhiet = dr.GetBoolean("Batcuong_Nhiet");
            if (dr.GetBoolean("Batcuong_Am") != null) _Batcuong_Am = dr.GetBoolean("Batcuong_Am");
            if (dr.GetBoolean("Batcuong_Duong") != null) _Batcuong_Duong = dr.GetBoolean("Batcuong_Duong");

            if (dr.GetBoolean("Tangphu_Tam") != null) _Tangphu_Tam = dr.GetBoolean("Tangphu_Tam");
            if (dr.GetBoolean("Tangphu_Can") != null) _Tangphu_Can = dr.GetBoolean("Tangphu_Can");
            if (dr.GetBoolean("Tangphu_Ty") != null) _Tangphu_Ty = dr.GetBoolean("Tangphu_Ty");
            if (dr.GetBoolean("Tangphu_Phe") != null) _Tangphu_Phe = dr.GetBoolean("Tangphu_Phe");
            if (dr.GetBoolean("Tangphu_Than") != null) _Tangphu_Than = dr.GetBoolean("Tangphu_Than");
            if (dr.GetBoolean("Tangphu_TamBao") != null) _Tangphu_TamBao = dr.GetBoolean("Tangphu_TamBao");
            if (dr.GetBoolean("Tangphu_vi") != null) _Tangphu_vi = dr.GetBoolean("Tangphu_vi");
            if (dr.GetBoolean("Tangphu_DaiTrang") != null) _Tangphu_DaiTrang = dr.GetBoolean("Tangphu_DaiTrang");
            if (dr.GetBoolean("Tangphu_TieuTruong") != null) _Tangphu_TieuTruong = dr.GetBoolean("Tangphu_TieuTruong");
            if (dr.GetBoolean("Tangphu_BangQuang") != null) _Tangphu_BangQuang = dr.GetBoolean("Tangphu_BangQuang");
            if (dr.GetBoolean("Tangphu_TamTieu") != null) _Tangphu_TamTieu = dr.GetBoolean("Tangphu_TamTieu");
            if (dr.GetBoolean("Tangphu_Dom") != null) _Tangphu_Dom = dr.GetBoolean("Tangphu_Dom");
            if (dr.GetBoolean("Tangphu_PhuKyHang") != null) _Tangphu_PhuKyHang = dr.GetBoolean("Tangphu_PhuKyHang");


            if (dr.GetBoolean("KinhMach_Tam") != null) _KinhMach_Tam = dr.GetBoolean("KinhMach_Tam");
            if (dr.GetBoolean("KinhMach_Can") != null) _KinhMach_Can = dr.GetBoolean("KinhMach_Can");
            if (dr.GetBoolean("KinhMach_Ty") != null) _KinhMach_Ty = dr.GetBoolean("KinhMach_Ty");
            if (dr.GetBoolean("KinhMach_Phe") != null) _KinhMach_Phe = dr.GetBoolean("KinhMach_Phe");
            if (dr.GetBoolean("KinhMach_Than") != null) _KinhMach_Than = dr.GetBoolean("KinhMach_Than");
            if (dr.GetBoolean("KinhMach_TamBaoLac") != null) _KinhMach_TamBaoLac = dr.GetBoolean("KinhMach_TamBaoLac");
            if (dr.GetBoolean("KinhMach_vi") != null) _KinhMach_vi = dr.GetBoolean("KinhMach_vi");
            if (dr.GetBoolean("KinhMach_DaiTruong") != null) _KinhMach_DaiTruong = dr.GetBoolean("KinhMach_DaiTruong");
            if (dr.GetBoolean("KinhMach_TieuTruong") != null) _KinhMach_TieuTruong = dr.GetBoolean("KinhMach_TieuTruong");
            if (dr.GetBoolean("KinhMach_BangQuang") != null) _KinhMach_BangQuang = dr.GetBoolean("KinhMach_BangQuang");
            if (dr.GetBoolean("KinhMach_TamTieu") != null) _KinhMach_TamTieu = dr.GetBoolean("KinhMach_TamTieu");
            if (dr.GetBoolean("KinhMach_Dom") != null) _KinhMach_Dom = dr.GetBoolean("KinhMach_Dom");
            if (dr.GetBoolean("KinhMach_MachDoc") != null) _KinhMach_MachDoc = dr.GetBoolean("KinhMach_MachDoc");
            if (dr.GetBoolean("KinhMach_MachNham") != null) _KinhMach_MachNham = dr.GetBoolean("KinhMach_MachNham");

            if (dr.GetBoolean("DinhViTheo_Dinh") != null) _DinhViTheo_Dinh = dr.GetBoolean("DinhViTheo_Dinh");
            if (dr.GetBoolean("DinhViTheo_Ve") != null) _DinhViTheo_Ve = dr.GetBoolean("DinhViTheo_Ve");
            if (dr.GetBoolean("DinhViTheo_Khi") != null) _DinhViTheo_Khi = dr.GetBoolean("DinhViTheo_Khi");
            if (dr.GetBoolean("DinhViTheo_Huyet") != null) _DinhViTheo_Huyet = dr.GetBoolean("DinhViTheo_Huyet");

            if (dr.GetBoolean("NguyenNhan_NoiNhan") != null) _NguyenNhan_NoiNhan = dr.GetBoolean("NguyenNhan_NoiNhan");
            if (dr.GetBoolean("NguyenNhan_NgoaiNhan") != null) _NguyenNhan_NgoaiNhan = dr.GetBoolean("NguyenNhan_NgoaiNhan");
            if (dr.GetBoolean("NguyenNhan_BatNoiNgoaiNhan") != null) _NguyenNhan_BatNoiNgoaiNhan = dr.GetBoolean("NguyenNhan_BatNoiNgoaiNhan");


            if (dr.GetString("BenhLyKhac") != null) _BenhLyKhac = dr.GetString("BenhLyKhac");
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
		/// Insert the new <see cref="KhamBenh_DY" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh_DY
			// Copy & paste ham duoi day vao file DataProvider.cs
            _MaSoKham = DataProvider.Instance().InsertKhamBenh_DY(_MaSoKham, _sTT, _maDV, _ngayKham, _bSKHAM, _lyDoKham,  _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _toanThan, _Batcuong_Bieu, _Batcuong_Ly, _Batcuong_Hu, _Batcuong_Thuc, _Batcuong_Han, _Batcuong_Nhiet, _Batcuong_Am, _Batcuong_Duong, _Tangphu_Tam, _Tangphu_Can, _Tangphu_Ty, _Tangphu_Phe, _Tangphu_Than, _Tangphu_vi, _Tangphu_DaiTrang, _Tangphu_TieuTruong, _Tangphu_TamBao, _Tangphu_TamTieu, _Tangphu_Dom, _Tangphu_BangQuang, _Tangphu_PhuKyHang, _KinhMach_Tam, _KinhMach_Can, _KinhMach_Ty, _KinhMach_Phe, _KinhMach_Than, _KinhMach_vi, _KinhMach_DaiTruong, _KinhMach_TieuTruong, _KinhMach_TamBaoLac, _KinhMach_TamTieu, _KinhMach_Dom, _KinhMach_BangQuang, _KinhMach_MachDoc, _KinhMach_MachNham, _DinhViTheo_Dinh, _DinhViTheo_Ve, _DinhViTheo_Khi, _DinhViTheo_Huyet, _NguyenNhan_NoiNhan, _NguyenNhan_NgoaiNhan, _NguyenNhan_BatNoiNgoaiNhan, _BenhLyKhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV, _maMay, _nguoiSD);
            MarkOld();// public abstract String InsertKhamBenh_DY(String _MaSoKham, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _tieuHoa, String _ThanTNieuSDuc, String _thanKinh, String _XuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _BenhLyKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD);
            // public override String InsertKhamBenh_DY(String _MaSoKham, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _tieuHoa, String _ThanTNieuSDuc, String _thanKinh, String _XuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _BenhLyKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_DY_CREATE", _MaSoKham, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _toanThan, _benhngoaiKhoa, _tuanHoan, _hoHap, _tieuHoa, _ThanTNieuSDuc, _thanKinh, _XuongKhop, _taiMuiHong, _rangHamMat, _mat, _BenhLyKhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV,_maMay ,   _huy, _ngaySD.DBValue,_nguoiSD , _ngaySD1.DBValue, _nguoiSD1), String);
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="KhamBenh_DY" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_DY
			if (IsDirty){
                DataProvider.Instance().UpdateKhamBenh_DY(_MaSoKham, _sTT, _maDV, _ngayKham, _bSKHAM, _lyDoKham,  _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _toanThan, _Batcuong_Bieu, _Batcuong_Ly, _Batcuong_Hu, _Batcuong_Thuc, _Batcuong_Han, _Batcuong_Nhiet, _Batcuong_Am, _Batcuong_Duong, _Tangphu_Tam, _Tangphu_Can, _Tangphu_Ty, _Tangphu_Phe, _Tangphu_Than, _Tangphu_vi, _Tangphu_DaiTrang, _Tangphu_TieuTruong, _Tangphu_TamBao, _Tangphu_TamTieu, _Tangphu_Dom, _Tangphu_BangQuang, _Tangphu_PhuKyHang, _KinhMach_Tam, _KinhMach_Can, _KinhMach_Ty, _KinhMach_Phe, _KinhMach_Than, _KinhMach_vi, _KinhMach_DaiTruong, _KinhMach_TieuTruong, _KinhMach_TamBaoLac, _KinhMach_TamTieu, _KinhMach_Dom, _KinhMach_BangQuang, _KinhMach_MachDoc, _KinhMach_MachNham, _DinhViTheo_Dinh, _DinhViTheo_Ve, _DinhViTheo_Khi, _DinhViTheo_Huyet, _NguyenNhan_NoiNhan, _NguyenNhan_NgoaiNhan, _NguyenNhan_BatNoiNgoaiNhan, _BenhLyKhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV, _maMay, Huy, _nguoiSD);
                // public abstract void UpdateKhamBenh_DY(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _tieuHoa, String _ThanTNieuSDuc, String _thanKinh, String _XuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _BenhLyKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD);
                // public override void UpdateKhamBenh_DY(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _tieuHoa, String _ThanTNieuSDuc, String _thanKinh, String _XuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _BenhLyKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_DY_UPDATE", _MaSoKham, _sTT, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _toanThan, _benhngoaiKhoa, _tuanHoan, _hoHap, _tieuHoa, _ThanTNieuSDuc, _thanKinh, _XuongKhop, _taiMuiHong, _rangHamMat, _mat, _BenhLyKhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV,_maMay ,   _huy, _nguoiSD );
				// }
                MarkOld();
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD , _MaSoKham, _sTT));
		}

		/// <summary>
		/// Delete the <see cref="KhamBenh_DY" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_DY
            DataProvider.Instance().DeleteKhamBenh_DY(crit.MaMay, crit.NguoiSD, crit.MaSoKham, crit.STT);
			// public abstract void DeleteKhamBenh_DY(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa);
			// public override void DeleteKhamBenh_DY(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_DY_Deleted", _MaSoKham, _sTT, _sTTKhoa);
			// }
		}
        internal virtual void Insert(KhamBenh_C obj)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh_DY
            // Copy & paste ham duoi day vao file DataProvider.cs
            _MaSoKham = DataProvider.Instance().InsertKhamBenh_DY(obj.MaSoKham, obj.STT, obj.MaDV, _ngayKham, _bSKHAM, _lyDoKham,  _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _toanThan, _Batcuong_Bieu, _Batcuong_Ly, _Batcuong_Hu, _Batcuong_Thuc, _Batcuong_Han, _Batcuong_Nhiet, _Batcuong_Am, _Batcuong_Duong, _Tangphu_Tam, _Tangphu_Can, _Tangphu_Ty, _Tangphu_Phe, _Tangphu_Than, _Tangphu_vi, _Tangphu_DaiTrang, _Tangphu_TieuTruong, _Tangphu_TamBao, _Tangphu_TamTieu, _Tangphu_Dom, _Tangphu_BangQuang, _Tangphu_PhuKyHang, _KinhMach_Tam, _KinhMach_Can, _KinhMach_Ty, _KinhMach_Phe, _KinhMach_Than, _KinhMach_vi, _KinhMach_DaiTruong, _KinhMach_TieuTruong, _KinhMach_TamBaoLac, _KinhMach_TamTieu, _KinhMach_Dom, _KinhMach_BangQuang, _KinhMach_MachDoc, _KinhMach_MachNham, _DinhViTheo_Dinh, _DinhViTheo_Ve, _DinhViTheo_Khi, _DinhViTheo_Huyet, _NguyenNhan_NoiNhan, _NguyenNhan_NgoaiNhan, _NguyenNhan_BatNoiNgoaiNhan, _BenhLyKhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV, _maMay,_nguoiSD);
            MarkOld(); // public abstract String InsertKhamBenh_DY(String _MaSoKham, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _tieuHoa, String _ThanTNieuSDuc, String _thanKinh, String _XuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _BenhLyKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD);
            // public override String InsertKhamBenh_DY(String _MaSoKham, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _tieuHoa, String _ThanTNieuSDuc, String _thanKinh, String _XuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _BenhLyKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, String _nguoiSD)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_DY_CREATE", _MaSoKham, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _toanThan, _benhngoaiKhoa, _tuanHoan, _hoHap, _tieuHoa, _ThanTNieuSDuc, _thanKinh, _XuongKhop, _taiMuiHong, _rangHamMat, _mat, _BenhLyKhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV,_maMay ,   _huy, _ngaySD.DBValue,_nguoiSD , _ngaySD1.DBValue, _nguoiSD1), String);
            // }
        }

        /// <summary>
        /// Update all changes made on <see cref="KhamBenh_DY" /> Object to underlying database.
        /// </summary>
       internal virtual void Update(KhamBenh_C obj)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_DY
            if (IsDirty)
            {
                DataProvider.Instance().UpdateKhamBenh_DY(obj.MaSoKham, obj.STT, obj.MaDV, _ngayKham, _bSKHAM, _lyDoKham,  _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _toanThan, _Batcuong_Bieu, _Batcuong_Ly, _Batcuong_Hu, _Batcuong_Thuc, _Batcuong_Han, _Batcuong_Nhiet, _Batcuong_Am, _Batcuong_Duong, _Tangphu_Tam, _Tangphu_Can, _Tangphu_Ty, _Tangphu_Phe, _Tangphu_Than, _Tangphu_vi, _Tangphu_DaiTrang, _Tangphu_TieuTruong, _Tangphu_TamBao, _Tangphu_TamTieu, _Tangphu_Dom, _Tangphu_BangQuang, _Tangphu_PhuKyHang, _KinhMach_Tam, _KinhMach_Can, _KinhMach_Ty, _KinhMach_Phe, _KinhMach_Than, _KinhMach_vi, _KinhMach_DaiTruong, _KinhMach_TieuTruong, _KinhMach_TamBaoLac, _KinhMach_TamTieu, _KinhMach_Dom, _KinhMach_BangQuang, _KinhMach_MachDoc, _KinhMach_MachNham, _DinhViTheo_Dinh, _DinhViTheo_Ve, _DinhViTheo_Khi, _DinhViTheo_Huyet, _NguyenNhan_NoiNhan, _NguyenNhan_NgoaiNhan, _NguyenNhan_BatNoiNgoaiNhan, _BenhLyKhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV, _maMay, _huy,_nguoiSD);
                // public abstract void UpdateKhamBenh_DY(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _tieuHoa, String _ThanTNieuSDuc, String _thanKinh, String _XuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _BenhLyKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD);
                // public override void UpdateKhamBenh_DY(String _MaSoKham, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _tieuHoa, String _ThanTNieuSDuc, String _thanKinh, String _XuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _BenhLyKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _MaBV, String _maMay, Boolean _huy, String _nguoiSD)
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_DY_UPDATE", _MaSoKham, _sTT, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _toanThan, _benhngoaiKhoa, _tuanHoan, _hoHap, _tieuHoa, _ThanTNieuSDuc, _thanKinh, _XuongKhop, _taiMuiHong, _rangHamMat, _mat, _BenhLyKhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _MaBV,_maMay ,   _huy, _nguoiSD );
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
              
            DataProvider.Instance().DeleteKhamBenh_DY(_maMay, _nguoiSD , obj.MaSoKham, _sTT);
            MarkNew();
        }
		#endregion
	}

}
