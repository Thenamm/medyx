// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAnPK_DY
// Kieu doi tuong  :	BenhAnPK_DY
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

namespace HTC.Business.PhongKham
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="BenhAnPK_DY" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAnPK_DY : BusinessBase<BenhAnPK_DY>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maBA = String.Empty;
        private String _bSKHAM = String.Empty;
		private SmartDate _ngayKham = new SmartDate(true);
        private SmartDate _ngayKhamD = new SmartDate(true);
        private String _LyDoKham = String.Empty;
		private String _ToanThan = String.Empty;
        private String _BoPhan = String.Empty;
        private String _mach = String.Empty;
        private String _apHuyet = String.Empty;
        private String _nhietDo = String.Empty;
        private String _nhipTho = String.Empty;
        private String _canNang = String.Empty;
        private String _chieuCao = String.Empty;
        private String _MotaVongChan = String.Empty;
    
        private String _MoTaVanChan = String.Empty;
     
        private String _MTVaanChan = String.Empty;


        private String _MTXucChan = String.Empty;
        private String _MachTrai = String.Empty;
        private String _MachPhai = String.Empty;
   
        private String _TomtatTuChan = String.Empty;
      
        private String _BenhDanh = String.Empty;
        private String _Batcuong = String.Empty;
        private String _Tangphu = String.Empty;
        private String _KinhMach = String.Empty;
     
        private String _Nguyennhan = String.Empty;

        private String _BenhDanhRV = String.Empty;
        private String _BatcuongRV = String.Empty;
        private String _TangphuRV = String.Empty;
        private String _KinhMachRV = String.Empty;
        private String _NguyennhanRV = String.Empty;


        private String _ChanDoanRaVien = String.Empty;
        private String _Phapdieutri = String.Empty;
        private String _Phuongthuoc = String.Empty;
        private String _Phuonghuyet = String.Empty;
     
        private String _Khac = String.Empty;
        private String _mabenhRaVien = String.Empty;
     
        private String _maBenhKKB = String.Empty;
        private String _maICDRaVien = String.Empty;
     
        private String _maICDKKB = String.Empty;
   
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
        private String _maBenhChinh = String.Empty;
        private String _tenBenhChinh = String.Empty;
        private String _maBenhKemTheo = String.Empty;
        private String _tenBenhKemTheo = String.Empty;
        private String _maBenhPhanBiet = String.Empty;
        private String _tenBenhPhanBiet = String.Empty;
         
        private String _TomTatKQCLS = String.Empty;
        
        private int _OrderNumber;

        #endregion

        #region Business Properties and Methods
        public String MaBenhChinh
        {
            get
            {
                CanReadProperty("MaBenhChinh", true);
                return _maBenhChinh;
            }
            set
            {
                CanWriteProperty("MaBenhChinh", true);
                if (_maBenhChinh != value)
                {
                    _maBenhChinh = value;
                    PropertyHasChanged("MaBenhChinh");
                }
            }
        }
        public String TenBenhChinh
        {
            get
            {
                CanReadProperty("TenBenhChinh", true);
                return _tenBenhChinh;
            }
            set
            {
                CanWriteProperty("TenBenhChinh", true);
                if (_tenBenhChinh != value)
                {
                    _tenBenhChinh = value;
                    PropertyHasChanged("TenBenhChinh");
                }
            }
        }
        public String MaBenhKemTheo
        {
            get
            {
                CanReadProperty("MaBenhKemTheo", true);
                return _maBenhKemTheo;
            }
            set
            {
                CanWriteProperty("MaBenhKemTheo", true);
                if (_maBenhKemTheo != value)
                {
                    _maBenhKemTheo = value;
                    PropertyHasChanged("MaBenhKemTheo");
                }
            }
        }
        public String TenBenhKemTheo
        {
            get
            {
                CanReadProperty("TenBenhKemTheo", true);
                return _tenBenhKemTheo;
            }
            set
            {
                CanWriteProperty("TenBenhKemTheo", true);
                if (_tenBenhKemTheo != value)
                {
                    _tenBenhKemTheo = value;
                    PropertyHasChanged("TenBenhKemTheo");
                }
            }
        }
        public String MaBenhPhanBiet
        {
            get
            {
                CanReadProperty("MaBenhPhanBiet", true);
                return _maBenhPhanBiet;
            }
            set
            {
                CanWriteProperty("MaBenhPhanBiet", true);
                if (_maBenhPhanBiet != value)
                {
                    _maBenhPhanBiet = value;
                    PropertyHasChanged("MaBenhPhanBiet");
                }
            }
        }
        public String TenBenhPhanBiet
        {
            get
            {
                CanReadProperty("TenBenhPhanBiet", true);
                return _tenBenhPhanBiet;
            }
            set
            {
                CanWriteProperty("TenBenhPhanBiet", true);
                if (_tenBenhPhanBiet != value)
                {
                    _tenBenhPhanBiet = value;
                    PropertyHasChanged("TenBenhPhanBiet");
                }
            }
        }
        public String TomTatKQCLS
        {
            get
            {
                CanReadProperty("TomTatKQCLS", true);
                return _TomTatKQCLS;
            }
            set
            {
                CanWriteProperty("TomTatKQCLS", true);
                if (_TomTatKQCLS != value)
                {
                    _TomTatKQCLS = value;
                    PropertyHasChanged("TomTatKQCLS");
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
                return _LyDoKham;
            }
            set
            {
                CanWriteProperty("LyDoKham", true);
                if (_LyDoKham != value)
                {
                    _LyDoKham = value;
                    PropertyHasChanged("LyDoKham");
                }
            }
        }
        public String ToanThan
        {
            get
            {
                CanReadProperty("ToanThan", true);
                return _ToanThan;
            }
            set
            {
                CanWriteProperty("ToanThan", true);
                if (_ToanThan != value)
                {
                    _ToanThan = value;
                    PropertyHasChanged("ToanThan");
                }
            }
        }
        public String BoPhan
        {
            get
            {
                CanReadProperty("BoPhan", true);
                return _BoPhan;
            }
            set
            {
                CanWriteProperty("BoPhan", true);
                if (_BoPhan != value)
                {
                    _BoPhan = value;
                    PropertyHasChanged("BoPhan");
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

        public String MTXucChan
        {
            get
            {
                CanReadProperty("MTXucChan", true);
                return _MTXucChan;
            }
            set
            {
                CanWriteProperty("MTXucChan", true);
                if (_MTXucChan != value)
                {
                    _MTXucChan = value;
                    PropertyHasChanged("MTXucChan");
                }
            }
        }
      
        public String MachTrai
        {
            get
            {
                CanReadProperty("MachTrai", true);
                return _MachTrai;
            }
            set
            {
                CanWriteProperty("MachTrai", true);
                if (_MachTrai != value)
                {
                    _MachTrai = value;
                    PropertyHasChanged("MachTrai");
                }
            }
        }
        public String MachPhai
        {
            get
            {
                CanReadProperty("MachPhai", true);
                return _MachPhai;
            }
            set
            {
                CanWriteProperty("MachPhai", true);
                if (_MachPhai != value)
                {
                    _MachPhai = value;
                    PropertyHasChanged("MachPhai");
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
        public String BenhDanhRV
        {
            get
            {
                CanReadProperty("BenhDanhRV", true);
                return _BenhDanhRV;
            }
            set
            {
                CanWriteProperty("BenhDanhRV", true);
                if (_BenhDanhRV != value)
                {
                    _BenhDanhRV = value;
                    PropertyHasChanged("BenhDanhRV");
                }
            }
        }
        public String BatcuongRV
        {
            get
            {
                CanReadProperty("BatcuongRV", true);
                return _BatcuongRV;
            }
            set
            {
                CanWriteProperty("BatcuongRV", true);
                if (_BatcuongRV != value)
                {
                    _BatcuongRV = value;
                    PropertyHasChanged("BatcuongRV");
                }
            }
        }
        public String TangphuRV
        {
            get
            {
                CanReadProperty("TangphuRV", true);
                return _TangphuRV;
            }
            set
            {
                CanWriteProperty("TangphuRV", true);
                if (_TangphuRV != value)
                {
                    _TangphuRV = value;
                    PropertyHasChanged("TangphuRV");
                }
            }
        }
        public String KinhMachRV
        {
            get
            {
                CanReadProperty("KinhMachRV", true);
                return _KinhMachRV;
            }
            set
            {
                CanWriteProperty("KinhMachRV", true);
                if (_KinhMachRV != value)
                {
                    _KinhMachRV = value;
                    PropertyHasChanged("KinhMachRV");
                }
            }
        }
        public String NguyennhanRV
        {
            get
            {
                CanReadProperty("NguyennhanRV", true);
                return _NguyennhanRV;
            }
            set
            {
                CanWriteProperty("NguyennhanRV", true);
                if (_NguyennhanRV != value)
                {
                    _NguyennhanRV = value;
                    PropertyHasChanged("NguyennhanRV");
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
			return _maBA.ToString() ;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhAnPK_DY" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BenhAnPK_DY NewBenhAnPK_DY()
        {
            return DataPortal.Create<BenhAnPK_DY>();
        }
		public static BenhAnPK_DY GetBenhAnPK_DY(String maBA)
		{
			return DataPortal.Fetch<BenhAnPK_DY>(new Criteria(maBA));
		}
		
		/// <summary>
		/// Marks the <see cref="BenhAnPK_DY" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBenhAnPK_DY(String maBA, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maBA));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BenhAnPK_DY()
		{	
			// Prevent direct creation
		}

        internal BenhAnPK_DY(     int OrderNumber,
                                 String maBA ,
		                      
		                         SmartDate ngayKham ,
		                         String bSKHAM ,
           String LyDoKham,
         String ToanThan,
         String BoPhan,
       String mach,
                                 String apHuyet,
                                 String nhietDo,
                                 String nhipTho,
                                 String canNang,
                                 String chieuCao,
         String MotaVongChan,
      
         String MoTaVanChan,
      
         String MTVaanChan,


         String MTXucChan,
       
         String MachTrai,
         String MachPhai,
       
         String TomtatTuChan,
        
         String BenhDanh,
         String Batcuong,
         String Tangphu,
         String KinhMach,
       
         String Nguyennhan,
         String BenhDanhRV,
         String BatcuongRV,
         String TangphuRV,
         String KinhMachRV,
         String NguyennhanRV,
         String ChanDoanRaVien,
         String Phapdieutri,
         String Phuongthuoc,
         String Phuonghuyet,
       
         String Khac,
         String mabenhRaVien,
      
         String maBenhKKB,
         String maICDRaVien,
       
         String maICDKKB,
       
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
		                       
		                          _ngayKham = ngayKham ;
		                          _bSKHAM = bSKHAM ;
		                       _LyDoKham =LyDoKham;
       _ToanThan =ToanThan;
         _BoPhan =BoPhan;
         _mach = mach;
         _apHuyet = apHuyet;
         _nhietDo = nhietDo;
         _nhipTho = nhipTho;
         _canNang = canNang;
         _chieuCao = chieuCao;
          _MotaVongChan =MotaVongChan;
        
          _MoTaVanChan = MoTaVanChan;
         
          _MTVaanChan = MTVaanChan;


          _MTXucChan = MTXucChan;

          _MachTrai = MachTrai;
          _MachPhai = MachPhai;
         
          _TomtatTuChan = TomtatTuChan;
         
          _BenhDanh = BenhDanh;
          _Batcuong = Batcuong;
          _Tangphu = Tangphu;
          _KinhMach = KinhMach;
         
          _Nguyennhan = Nguyennhan;

          _BenhDanhRV = BenhDanhRV;
          _BatcuongRV = BatcuongRV;
          _TangphuRV = TangphuRV;
          _KinhMachRV = KinhMachRV;
          _NguyennhanRV = NguyennhanRV;

          _ChanDoanRaVien = ChanDoanRaVien;
          _Phapdieutri = Phapdieutri;
          _Phuongthuoc = Phuongthuoc;
          _Phuonghuyet = Phuonghuyet;
        
          _Khac = Khac;
          _mabenhRaVien = mabenhRaVien;
        
          _maBenhKKB = maBenhKKB;
          _maICDRaVien = maICDRaVien;
       
          _maICDKKB = maICDKKB;
         
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
			
		
			public Criteria(String maBA)
			{
				_maBA = maBA;
			
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBA.Equals(c._maBA)) 
						return false;
					
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBA.ToString()).GetHashCode();
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
            public OtherCriteria(String Mamay, String Nguoisd, String maba)
            {
                _maBA = maba;
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
		/// Retrieve an existing <see cref="BenhAnPK_DY" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetBenhAnPK_DY(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
			// public override IDataReader GetBenhAnPK_DY(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAnPK_DY_GET", _maBA, _sTT, _sTTKhoa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAnPK_DY(crit.MaBA)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="BenhAnPK_DY" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
			if (dr.GetSmartDate("NgayKham", true) != null) _ngayKham = dr.GetSmartDate("NgayKham", true);
			if (dr.GetString("BSKHAM") != null) _bSKHAM = dr.GetString("BSKHAM");
	  if (dr.GetString("LyDoKham") != null) _LyDoKham =dr.GetString("LyDoKham");
         if (dr.GetString("ToanThan") != null) _ToanThan =dr.GetString("ToanThan");
         if (dr.GetString("BoPhan") != null) _BoPhan =dr.GetString("BoPhan");
         if (dr.GetString("Mach") != null) _mach = dr.GetString("Mach");
         if (dr.GetString("ApHuyet") != null) _apHuyet = dr.GetString("ApHuyet");
         if (dr.GetString("NhietDo") != null) _nhietDo = dr.GetString("NhietDo");
         if (dr.GetString("NhipTho") != null) _nhipTho = dr.GetString("NhipTho");
         if (dr.GetString("CanNang") != null) _canNang = dr.GetString("CanNang");
         if (dr.GetString("ChieuCao") != null) _chieuCao = dr.GetString("ChieuCao");
         if (dr.GetString("MotaVongChan") != null) _MotaVongChan =dr.GetString("MotaVongChan");
         if (dr.GetString("MoTaVanChan") != null) _MoTaVanChan = dr.GetString("MoTaVanChan");
            if (dr.GetString("MaBenhChinh") != null) _maBenhChinh = dr.GetString("MaBenhChinh");
            if (dr.GetString("TenBenhChinh") != null) _tenBenhChinh = dr.GetString("TenBenhChinh");
            if (dr.GetString("MaBenhPhanBiet") != null) _maBenhPhanBiet = dr.GetString("MaBenhPhanBiet");
            if (dr.GetString("TenBenhPhanBiet") != null) _tenBenhPhanBiet = dr.GetString("TenBenhPhanBiet");
            if (dr.GetString("MaBenhKemTheo") != null) _maBenhKemTheo = dr.GetString("MaBenhKemTheo");
            if (dr.GetString("TenBenhKemTheo") != null) _tenBenhKemTheo = dr.GetString("TenBenhKemTheo");
            if (dr.GetString("TomTatKQCLS") != null) _TomTatKQCLS = dr.GetString("TomTatKQCLS");
            
            if (dr.GetString("MTVaanChan") != null) _MTVaanChan =dr.GetString("MTVaanChan");

      
         if (dr.GetString("MTXucChan") != null) _MTXucChan  =dr.GetString("MTXucChan");
         if (dr.GetString("MachTrai") != null) _MachTrai = dr.GetString("MachTrai");
         if (dr.GetString("MachPhai") != null) _MachPhai = dr.GetString("MachPhai");
      
        
         if (dr.GetString("TomtatTuChan") != null) _TomtatTuChan =dr.GetString("TomtatTuChan");
          if (dr.GetString("BenhDanh") != null) _BenhDanh =dr.GetString("BenhDanh");
         if (dr.GetString("Batcuong") != null) _Batcuong =dr.GetString("Batcuong");
         if (dr.GetString("Tangphu") != null) _Tangphu =dr.GetString("Tangphu");
         if (dr.GetString("KinhMach") != null) _KinhMach =dr.GetString("KinhMach");
        
         if (dr.GetString("Nguyennhan") != null) _Nguyennhan =dr.GetString("Nguyennhan");

         if (dr.GetString("BenhDanhRV") != null) _BenhDanhRV = dr.GetString("BenhDanhRV");
         if (dr.GetString("BatcuongRV") != null) _BatcuongRV = dr.GetString("BatcuongRV");
         if (dr.GetString("TangphuRV") != null) _TangphuRV = dr.GetString("TangphuRV");
         if (dr.GetString("KinhMachRV") != null) _KinhMachRV = dr.GetString("KinhMachRV");

         if (dr.GetString("NguyennhanRV") != null) _NguyennhanRV = dr.GetString("NguyennhanRV");

         if (dr.GetString("ChanDoanRaVien") != null) _ChanDoanRaVien =dr.GetString("ChanDoanRaVien");
         if (dr.GetString("Phapdieutri") != null) _Phapdieutri =dr.GetString("Phapdieutri");
         if (dr.GetString("Phuongthuoc") != null) _Phuongthuoc =dr.GetString("Phuongthuoc");
         if (dr.GetString("Phuonghuyet") != null) _Phuonghuyet =dr.GetString("Phuonghuyet");
          if (dr.GetString("Khac") != null) _Khac =dr.GetString("Khac");
         if (dr.GetString("mabenhRaVien") != null) _mabenhRaVien =dr.GetString("mabenhRaVien");
          if (dr.GetString("maBenhKKB") != null) _maBenhKKB =dr.GetString("maBenhKKB");
         if (dr.GetString("maICDRaVien") != null) _maICDRaVien =dr.GetString("maICDRaVien");
          if (dr.GetString("maICDKKB") != null) _maICDKKB =dr.GetString("maICDKKB");
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
		/// Insert the new <see cref="BenhAnPK_DY" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAnPK_DY
			// Copy & paste ham duoi day vao file DataProvider.cs
            _maBA = DataProvider.Instance().InsertBenhAnPK_DY(_maBA, _ngayKham, _bSKHAM, _LyDoKham  ,
         _ToanThan  ,
         _BoPhan  ,
       _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, 
         _MotaVongChan  ,
       
         _MoTaVanChan  ,
      
         _MTVaanChan  ,

      
         _MTXucChan  ,
       
         _MachTrai  ,
         _MachPhai  ,
       
         _TomtatTuChan  ,
       
         _BenhDanh  ,
         _Batcuong  ,
         _Tangphu  ,
         _KinhMach ,
        
         _Nguyennhan  ,
           _BenhDanhRV,
         _BatcuongRV,
         _TangphuRV,
         _NguyennhanRV,
         _ChanDoanRaVien  ,
         _Phapdieutri  ,
         _Phuongthuoc  ,
         _Phuonghuyet  ,
        
         _Khac  ,
         _mabenhRaVien  ,
        
         _maBenhKKB  ,
     
        
         _ChanDoanKKB  ,
         _CheDoDinhDuong  ,
         _CheDoChamSoc  , _TienLuong, _maMay, _nguoiSD, _TomTatKQCLS, _maBenhChinh,_tenBenhChinh,_maBenhKemTheo,_tenBenhKemTheo,_maBenhPhanBiet,_tenBenhPhanBiet);
            // public abstract String InsertBenhAnPK_DY(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _tieuHoa, String _ThanTNieuSDuc, String _thanKinh, String _XuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _BenhLyKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD);
            // public override String InsertBenhAnPK_DY(String _maBA, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _tieuHoa, String _ThanTNieuSDuc, String _thanKinh, String _XuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _BenhLyKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAnPK_DY_CREATE", _maBA, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _toanThan, _benhngoaiKhoa, _tuanHoan, _hoHap, _tieuHoa, _ThanTNieuSDuc, _thanKinh, _XuongKhop, _taiMuiHong, _rangHamMat, _mat, _BenhLyKhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _machuyenkhoa, _maMay, _huy, _ngaySD.DBValue, _nguoiSD , _ngaySD1.DBValue, _nguoiSD1), String);
            // }
            MarkOld();

        }
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAnPK_DY" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAnPK_DY
			if (IsDirty){
                DataProvider.Instance().UpdateBenhAnPK_DY(_maBA,  _ngayKham, _bSKHAM, _LyDoKham,
         _ToanThan,
         _BoPhan,
          _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, 
         _MotaVongChan,

         _MoTaVanChan,

         _MTVaanChan,


         _MTXucChan,

         _MachTrai,
         _MachPhai,

         _TomtatTuChan,

         _BenhDanh,
         _Batcuong,
         _Tangphu,
         _KinhMach,

         _Nguyennhan,
          _BenhDanhRV,
         _BatcuongRV,
         _TangphuRV,
         _NguyennhanRV,
         _ChanDoanRaVien,
         _Phapdieutri,
         _Phuongthuoc,
         _Phuonghuyet,

         _Khac,
         _mabenhRaVien,

         _maBenhKKB,


         _ChanDoanKKB,
         _CheDoDinhDuong,
         _CheDoChamSoc, _TienLuong, _maMay, _huy,_nguoiSD, _TomTatKQCLS, _maBenhChinh, _tenBenhChinh, _maBenhKemTheo, _tenBenhKemTheo, _maBenhPhanBiet, _tenBenhPhanBiet);
                // public abstract void UpdateBenhAnPK_DY(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _tieuHoa, String _ThanTNieuSDuc, String _thanKinh, String _XuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _BenhLyKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD);
                // public override void UpdateBenhAnPK_DY(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _ngayKham, String _bSKHAM, String _lyDoKham, String _mach, String _apHuyet, String _nhietDo, String _nhipTho, String _canNang, String _chieuCao, String _toanThan, String _benhngoaiKhoa, String _tuanHoan, String _hoHap, String _tieuHoa, String _ThanTNieuSDuc, String _thanKinh, String _XuongKhop, String _taiMuiHong, String _rangHamMat, String _mat, String _BenhLyKhac, String _dieuTri, String _benhSu, String _huongDT, String _mabenh, String _maBenhKem, String _machuyenkhoa, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAnPK_DY_UPDATE", _maBA, _sTT, _sTTKhoa, _ngayKham.DBValue, _bSKHAM, _lyDoKham, _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _toanThan, _benhngoaiKhoa, _tuanHoan, _hoHap, _tieuHoa, _ThanTNieuSDuc, _thanKinh, _XuongKhop, _taiMuiHong, _rangHamMat, _mat, _BenhLyKhac, _dieuTri, _benhSu, _huongDT, _mabenh, _maBenhKem, _machuyenkhoa, _maMay, _huy, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maBA));
		}

		/// <summary>
		/// Delete the <see cref="BenhAnPK_DY" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAnPK_DY
            DataProvider.Instance().DeleteBenhAnPK_DY(crit.MaMay, crit.NguoiSD, crit.MaBA);
			// public abstract void DeleteBenhAnPK_DY(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
			// public override void DeleteBenhAnPK_DY(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAnPK_DY_Deleted", _maBA, _sTT, _sTTKhoa);
			// }
		}

		#endregion
	}

}
