// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_San_Kham
// Kieu doi tuong  :	BenhAn_San_Kham
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	03/31/2010 9:17:28 AM
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
	/// This is a base generated class of <see cref="BenhAn_San_Kham" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_San_Kham : BusinessBase<BenhAn_San_Kham>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maBA = String.Empty;
		private SmartDate _ngayDauKyKCC = new SmartDate(true);
		private Int16 _cannangtruocthai = 0;
		private Decimal _tuoithai = 0;
		private Byte _chieucaoTC = 0;
		private Int16 _cTC_VB = 0;
        private string _ngoithai = String.Empty;
		private Byte _sLThai = 0;
		private String _timthai = String.Empty;
		private Byte _tinhtrangtimthai = 0;
        private Boolean _tinhtrangtimthaiT = false;
		private SmartDate _ngaydukiende = new SmartDate(true);
		private String _dauhieubatthuong = String.Empty;
		private String _xutri = String.Empty;
		private String _lydoVV = String.Empty;
		private Byte _tinhthan = 0;
        private Boolean  _tinhthanHonMe = false ;
        private Boolean _tinhtao = false;
        private Boolean _tinhthank = false;
		private Byte _phu = 0;
        private Boolean _phuT = false;
		private String _proteinNieu = String.Empty;
		private Byte _seomocu = 0;
		private String _concotucung = String.Empty;
		private Byte _cotucung = 0;
		private String _cTCMo = String.Empty;
		private String _bishop = String.Empty;
		private Byte _dauoi = 0;
		private String _tGVooi = String.Empty;
		private Byte _nuocoi = 0;
		private String _tienluong = String.Empty;
		private Byte _dauseomo = 0;
		private SmartDate _ngaydeDukienSA = new SmartDate(true);
		private Byte _tuanSA = 0;
		private String _tinhthanKhac = String.Empty;
		private SmartDate _ngayDe = new SmartDate(true);
		private String _tenConTrai = String.Empty;
		private String _tenConGai = String.Empty;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
        private String _tennguoiSD = String.Empty;
        private int _OrderNumber;
        private String _mach = String.Empty;
        private String _apHuyet = String.Empty;
        private String _nhietDo = String.Empty;
        private String _nhipTho = String.Empty;
        private String _canNang = String.Empty;
        private String _chieuCao = String.Empty;
        private Boolean _SeoMoCo = false;
        private Boolean _SeoMoKhong = false;
        private Boolean _SeoMoDau= false;
        private Boolean _CoTuCungDong = false;
        private Boolean _CoTuCungMo = false;
        private Boolean _CoTuCungXoa = false;
        private Boolean _DauOiPhong = false;
        private Boolean _DauOiDet = false;
        private Boolean _DauOiQuaLe = false;
        private Boolean _DauOiRi = false;
        private Boolean _DauOiVo = false;
        private Boolean _NuocOiTrong = false;
        private Boolean _NuocOiXanh = false;
        private Boolean _NuocOiLan = false;
        private String _dieuTri = String.Empty;
        private String _chanDoan = String.Empty;
		#endregion
		
		#region Business Properties and Methods

        public Boolean SeoMoKhong
        {
            get
            {
                CanReadProperty("SeoMoKhong", true);

                if (_dauseomo == 1)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("SeoMoKhong", true);

                if (_SeoMoKhong != value)
                {

                    _SeoMoKhong = value;

                }
                if (_SeoMoKhong == true)
                    _dauseomo = 1;
                PropertyHasChanged("dauseomo");

            }
        }
        public Boolean SeoMoCo
        {
            get
            {
                CanReadProperty("SeoMoCo", true);

                if (_dauseomo == 0)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("SeoMoCo", true);

                if (_SeoMoCo != value)
                {

                    _SeoMoCo = value;

                }
                if (_SeoMoCo == true)
                    _dauseomo = 0;
                PropertyHasChanged("dauseomo");

            }
        }
        public Boolean SeoMoDau
        {
            get
            {
                CanReadProperty("SeoMoDau", true);


                if (_dauseomo == 2)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("SeoMoDau", true);

                if (_SeoMoDau != value)
                {

                    _SeoMoDau = value;

                }
                if (_SeoMoDau == true)
                    _dauseomo = 2;
                PropertyHasChanged("dauseomo");
            }
        }
        public Boolean CoTuCungXoa
        {
            get
            {
                CanReadProperty("CoTuCungXoa", true);

                if (_cotucung == 1)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("CoTuCungXoa", true);

                if (_CoTuCungXoa != value)
                {

                    _CoTuCungXoa = value;

                }
                if (_CoTuCungXoa == true)
                    _cotucung = 1;
                PropertyHasChanged("cotucung");

            }
        }
        public Boolean CoTuCungMo
        {
            get
            {
                CanReadProperty("CoTuCungMo", true);

                if (_cotucung == 2)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("CoTuCungMo", true);

                if (_CoTuCungMo != value)
                {

                    _CoTuCungMo = value;

                }
                if (_CoTuCungMo == true)
                    _cotucung = 2;
                PropertyHasChanged("cotucung");

            }
        }
        public Boolean CoTuCungDong
        {
            get
            {
                CanReadProperty("CoTuCungDong", true);


                if (_cotucung == 0)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("CoTuCungDong", true);

                if (_CoTuCungDong != value)
                {

                    _CoTuCungDong = value;

                }
                if (_CoTuCungDong == true)
                    _cotucung = 0;
                PropertyHasChanged("cotucung");
            }
        }
        public Boolean DauOiDet
        {
            get
            {
                CanReadProperty("DauOiDet", true);

                if (_dauoi == 1)
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
                    _dauoi = 1;
                PropertyHasChanged("dauoi");

            }
        }
        public Boolean DauOiPhong
        {
            get
            {
                CanReadProperty("DauOiPhong", true);

                if (_dauoi == 0)
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
                    _dauoi = 0;
                PropertyHasChanged("dauoi");

            }
        }
        public Boolean DauOiQuaLe
        {
            get
            {
                CanReadProperty("DauOiQuaLe", true);


                if (_dauoi == 2)
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
                    _dauoi = 2;
                PropertyHasChanged("dauoi");
            }
        }
        public Boolean DauOiRi
        {
            get
            {
                CanReadProperty("DauOiRi", true);

                if (_dauoi == 3)
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
                    _dauoi = 3;
                PropertyHasChanged("dauoi");

            }
        }
        public Boolean DauOiVo
        {
            get
            {
                CanReadProperty("DauOiVo", true);


                if (_dauoi == 4)
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
                    _dauoi = 4;
                PropertyHasChanged("dauoi");
            }
        }
        public Boolean NuocOiXanh
        {
            get
            {
                CanReadProperty("NuocOiXanh", true);

                if (_nuocoi == 1)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("NuocOiXanh", true);

                if (_NuocOiXanh != value)
                {

                    _NuocOiXanh = value;

                }
                if (_NuocOiXanh == true)
                    _nuocoi = 1;
                PropertyHasChanged("nuocoi");

            }
        }
        public Boolean NuocOiTrong
        {
            get
            {
                CanReadProperty("NuocOiTrong", true);

                if (_nuocoi == 0)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("NuocOiTrong", true);

                if (_NuocOiTrong != value)
                {

                    _NuocOiTrong = value;

                }
                if (_NuocOiTrong == true)
                    _nuocoi = 0;
                PropertyHasChanged("nuocoi");

            }
        }
        public Boolean NuocOiLan
        {
            get
            {
                CanReadProperty("NuocOiLan", true);


                if (_nuocoi == 2)
                    return true;
                else
                    return false;

            }
            set
            {
                CanWriteProperty("NuocOiLan", true);

                if (_NuocOiLan != value)
                {

                    _NuocOiLan = value;

                }
                if (_NuocOiLan == true)
                    _nuocoi = 2;
                PropertyHasChanged("dauoi");
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
		
		public string NgayDauKyKCC
		{
			get 
			{
				CanReadProperty("NgayDauKyKCC", true);
				return _ngayDauKyKCC.Text;
			}
			set 
			{
				CanWriteProperty("NgayDauKyKCC", true);
				if (_ngayDauKyKCC.Text != value) 
				{
					_ngayDauKyKCC.Text = value;
					PropertyHasChanged("NgayDauKyKCC");
				}
			}
		}
		
		public Int16 Cannangtruocthai
		{
			get 
			{
				CanReadProperty("Cannangtruocthai", true);
				return _cannangtruocthai;
			}
			set 
			{
				CanWriteProperty("Cannangtruocthai", true);
				if (_cannangtruocthai != value) 
				{
					_cannangtruocthai = value;
					PropertyHasChanged("Cannangtruocthai");
				}
			}
		}
		
		public Decimal Tuoithai
		{
			get 
			{
				CanReadProperty("Tuoithai", true);
				return _tuoithai;
			}
			set 
			{
				CanWriteProperty("Tuoithai", true);
				if (_tuoithai != value) 
				{
					_tuoithai = value;
					PropertyHasChanged("Tuoithai");
				}
			}
		}
		
		public Byte ChieucaoTC
		{
			get 
			{
				CanReadProperty("ChieucaoTC", true);
				return _chieucaoTC;
			}
			set 
			{
				CanWriteProperty("ChieucaoTC", true);
				if (_chieucaoTC != value) 
				{
					_chieucaoTC = value;
					PropertyHasChanged("ChieucaoTC");
				}
			}
		}
		
		public Int16 CTC_VB
		{
			get 
			{
				CanReadProperty("CTC_VB", true);
				return _cTC_VB;
			}
			set 
			{
				CanWriteProperty("CTC_VB", true);
				if (_cTC_VB != value) 
				{
					_cTC_VB = value;
					PropertyHasChanged("CTC_VB");
				}
			}
		}
		
		public string Ngoithai
		{
			get 
			{
				CanReadProperty("Ngoithai", true);
				return _ngoithai;
			}
			set 
			{
				CanWriteProperty("Ngoithai", true);
				if (_ngoithai != value) 
				{
					_ngoithai = value;
					PropertyHasChanged("Ngoithai");
				}
			}
		}
		
		public Byte SLThai
		{
			get 
			{
				CanReadProperty("SLThai", true);
				return _sLThai;
			}
			set 
			{
				CanWriteProperty("SLThai", true);
				if (_sLThai != value) 
				{
					_sLThai = value;
					PropertyHasChanged("SLThai");
				}
			}
		}
		
		public String Timthai
		{
			get 
			{
				CanReadProperty("Timthai", true);
				return _timthai;
			}
			set 
			{
				CanWriteProperty("Timthai", true);
				if (_timthai != value) 
				{
					_timthai = value;
					PropertyHasChanged("Timthai");
				}
			}
		}
		
		public Byte Tinhtrangtimthai
		{
			get 
			{
				CanReadProperty("Tinhtrangtimthai", true);
				return _tinhtrangtimthai;
			}
			set 
			{
				CanWriteProperty("Tinhtrangtimthai", true);
				if (_tinhtrangtimthai != value) 
				{
					_tinhtrangtimthai = value;
					PropertyHasChanged("Tinhtrangtimthai");
				}
			}
		}
		
		public string Ngaydukiende
		{
			get 
			{
				CanReadProperty("Ngaydukiende", true);
				return _ngaydukiende.Text;
			}
			set 
			{
				CanWriteProperty("Ngaydukiende", true);
				if (_ngaydukiende.Text != value) 
				{
					_ngaydukiende.Text = value;
					PropertyHasChanged("Ngaydukiende");
				}
			}
		}
		
		public String Dauhieubatthuong
		{
			get 
			{
				CanReadProperty("Dauhieubatthuong", true);
				return _dauhieubatthuong;
			}
			set 
			{
				CanWriteProperty("Dauhieubatthuong", true);
				if (_dauhieubatthuong != value) 
				{
					_dauhieubatthuong = value;
					PropertyHasChanged("Dauhieubatthuong");
				}
			}
		}
		
		public String Xutri
		{
			get 
			{
				CanReadProperty("Xutri", true);
				return _xutri;
			}
			set 
			{
				CanWriteProperty("Xutri", true);
				if (_xutri != value) 
				{
					_xutri = value;
					PropertyHasChanged("Xutri");
				}
			}
		}
		
		public String LydoVV
		{
			get 
			{
				CanReadProperty("LydoVV", true);
				return _lydoVV;
			}
			set 
			{
				CanWriteProperty("LydoVV", true);
				if (_lydoVV != value) 
				{
					_lydoVV = value;
					PropertyHasChanged("LydoVV");
				}
			}
		}
		
		public Byte Tinhthan
		{
			get 
			{
				CanReadProperty("Tinhthan", true);
               
                    return _tinhthan;
                
			}
			set 
			{
				CanWriteProperty("Tinhthan", true);
				if (_tinhthan != value) 
				{

					_tinhthan = value;
					
				}
                //if (_tinhthan == 1)
                //    _tinhthanHonMe = true;
                //else if (_tinhthan == 0)
                //_tinhthank =true;
                //else if (_tinhthan == 2)
                //_tinhtao =true;
            PropertyHasChanged("Tinhthan");
			}
		}
        public Boolean  TinhthanHonMe
        {
            get
            {
                CanReadProperty("TinhthanHonMe", true);
              
                if (_tinhthan == 1)
                    return true;
                else
                    return false;
               
            }
            set
            {
                CanWriteProperty("tinhthanHonMe", true);
               
                if (_tinhthanHonMe != value)
                {
                   
                    _tinhthanHonMe = value;
                   
                } 
                if (_tinhthanHonMe == true)
                    _tinhthan = 1;
                PropertyHasChanged("tinhthanHonMe");

            }
        }
        public Boolean  TinhTao
        {
            get
            {
                CanReadProperty("TinhTao", true);
                
                if (_tinhthan == 0)
                    return true;
                else
                    return false;
               
            }
            set
            {
                CanWriteProperty("TinhTao", true);
              
                if (_tinhtao != value)
                {
                
                    _tinhtao = value;
                    
                } 
                if (_tinhtao == true)
                    _tinhthan = 0;
                PropertyHasChanged("TinhTao");

            }
        }
        public Boolean tinhthank
        {
            get
            {
                CanReadProperty("tinhthank", true);
              

                if (_tinhthan == 2)
                    return true;
                else
                    return false;
                
            }
            set
            {
                CanWriteProperty("tinhthank", true);
               
                if (_tinhthank != value)
                {
                   
                    _tinhthank = value;
                  
                }
                if (_tinhthank == true)
                    _tinhthan = 2;
                PropertyHasChanged("tinhthan");
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
        public bool PhuT
        {
            get
            {
                CanReadProperty("PhuT", true);

                if (_phu  == 1)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("PhuT", true);
               
                   
                    _phuT = value;
                    if (_phuT == true)
                        _phu = 0;
                    PropertyHasChanged("PhuT");
               
            }
        }
        public bool tinhtrangtimthaiT
        {
            get
            {
                CanReadProperty("tinhtrangtimthaiT", true);

                if (_tinhtrangtimthai == 1)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("tinhtrangtimthaiT", true);


                _tinhtrangtimthaiT = value;
                if (_tinhtrangtimthaiT == true)
                    _tinhtrangtimthai = 0;
                PropertyHasChanged("tinhtrangtimthaiT");

            }
        }
		public String ProteinNieu
		{
			get 
			{
				CanReadProperty("ProteinNieu", true);
				return _proteinNieu;
			}
			set 
			{
				CanWriteProperty("ProteinNieu", true);
				if (_proteinNieu != value) 
				{
					_proteinNieu = value;
					PropertyHasChanged("ProteinNieu");
				}
			}
		}
		
		public Byte Seomocu
		{
			get 
			{
				CanReadProperty("Seomocu", true);
				return _seomocu;
			}
			set 
			{
				CanWriteProperty("Seomocu", true);
				if (_seomocu != value) 
				{
					_seomocu = value;
					PropertyHasChanged("Seomocu");
				}
			}
		}
		
		public String Concotucung
		{
			get 
			{
				CanReadProperty("Concotucung", true);
				return _concotucung;
			}
			set 
			{
				CanWriteProperty("Concotucung", true);
				if (_concotucung != value) 
				{
					_concotucung = value;
					PropertyHasChanged("Concotucung");
				}
			}
		}
		
		public Byte Cotucung
		{
			get 
			{
				CanReadProperty("Cotucung", true);
				return _cotucung;
			}
			set 
			{
				CanWriteProperty("Cotucung", true);
				if (_cotucung != value) 
				{
					_cotucung = value;
					PropertyHasChanged("Cotucung");
				}
			}
		}
		
		public String CTCMo
		{
			get 
			{
				CanReadProperty("CTCMo", true);
				return _cTCMo;
			}
			set 
			{
				CanWriteProperty("CTCMo", true);
				if (_cTCMo != value) 
				{
					_cTCMo = value;
					PropertyHasChanged("CTCMo");
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
		
		public Byte Dauoi
		{
			get 
			{
				CanReadProperty("Dauoi", true);
				return _dauoi;
			}
			set 
			{
				CanWriteProperty("Dauoi", true);
				if (_dauoi != value) 
				{
					_dauoi = value;
					PropertyHasChanged("Dauoi");
				}
			}
		}
		
		public String TGVooi
		{
			get 
			{
				CanReadProperty("TGVooi", true);
				return _tGVooi;
			}
			set 
			{
				CanWriteProperty("TGVooi", true);
				if (_tGVooi != value) 
				{
					_tGVooi = value;
					PropertyHasChanged("TGVooi");
				}
			}
		}
		
		public Byte Nuocoi
		{
			get 
			{
				CanReadProperty("Nuocoi", true);
				return _nuocoi;
			}
			set 
			{
				CanWriteProperty("Nuocoi", true);
				if (_nuocoi != value) 
				{
					_nuocoi = value;
					PropertyHasChanged("Nuocoi");
				}
			}
		}
		
		public String Tienluong
		{
			get 
			{
				CanReadProperty("Tienluong", true);
				return _tienluong;
			}
			set 
			{
				CanWriteProperty("Tienluong", true);
				if (_tienluong != value) 
				{
					_tienluong = value;
					PropertyHasChanged("Tienluong");
				}
			}
		}
		
		public Byte Dauseomo
		{
			get 
			{
				CanReadProperty("Dauseomo", true);
				return _dauseomo;
			}
			set 
			{
				CanWriteProperty("Dauseomo", true);
				if (_dauseomo != value) 
				{
					_dauseomo = value;
					PropertyHasChanged("Dauseomo");
				}
			}
		}
		
		public string NgaydeDukienSA
		{
			get 
			{
				CanReadProperty("NgaydeDukienSA", true);
				return _ngaydeDukienSA.Text;
			}
			set 
			{
				CanWriteProperty("NgaydeDukienSA", true);
				if (_ngaydeDukienSA.Text != value) 
				{
					_ngaydeDukienSA.Text = value;
					PropertyHasChanged("NgaydeDukienSA");
				}
			}
		}
		
		public Byte TuanSA
		{
			get 
			{
				CanReadProperty("TuanSA", true);
				return _tuanSA;
			}
			set 
			{
				CanWriteProperty("TuanSA", true);
				if (_tuanSA != value) 
				{
					_tuanSA = value;
					PropertyHasChanged("TuanSA");
				}
			}
		}
		
		public String TinhThanKhac
		{
			get 
			{
                CanReadProperty("TinhThanKhac", true);
                return _tinhthanKhac;
			}
			set 
			{
                CanWriteProperty("TinhThanKhac", true);
                if (_tinhthanKhac != value) 
				{
                    _tinhthanKhac  = value;
                    PropertyHasChanged("TinhThanKhac");
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
			return _maBA;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhAn_San_Kham" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BenhAn_San_Kham NewBenhAn_San_Kham()
        {
            return DataPortal.Create<BenhAn_San_Kham>();
        }
		public static BenhAn_San_Kham GetBenhAn_San_Kham(String maBA)
		{
			return DataPortal.Fetch<BenhAn_San_Kham>(new Criteria(maBA ));
		}
		
		/// <summary>
		/// Marks the <see cref="BenhAn_San_Kham" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBenhAn_San_Kham(String maBA, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maBA));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BenhAn_San_Kham()
		{	
			// Prevent direct creation
		}
        internal BenhAn_San_Kham( 
                        int OrderNumber,
                        String maBA ,
		             SmartDate ngayDauKyKCC ,
		             Int16 cannangtruocthai ,
		             Decimal tuoithai ,
		             Byte chieucaoTC ,
		             Int16 cTC_VB ,
		             string maNgoithai ,
		             Byte sLThai ,
		             String timthai ,
		             Byte tinhtrangtimthai ,
		             SmartDate ngaydukiende ,
		             String dauhieubatthuong ,
		             String xutri ,
		             String lydoVV ,
		             Byte tinhthan ,
		             Byte phu ,
		             String proteinNieu ,
		             Byte seomocu ,
		             String concotucung ,
		             Byte cotucung ,
		             String cTCMo ,
		             String bishop ,
		             Byte dauoi ,
		             String tGVooi ,
		             Byte nuocoi ,
		             String tienluong ,
		             Byte dauseomo ,
		             SmartDate ngaydeDukienSA ,
		             Byte tuanSA ,
		             String tinhthanKhac ,
		             SmartDate ngayDe ,
		             String tenConTrai ,
		             String tenConGai ,
		             String maMay ,
		             Boolean huy ,
		             SmartDate ngaySD ,
		             String nguoiSD ,
		             SmartDate ngaySD1 ,
		             String nguoiSD1 ,
                     String tennguoiSD,
                     String mach ,
            	     String apHuyet ,
		             String nhietDo ,
		             String nhipTho ,
		             String canNang ,
		             String chieuCao ,
                     String dieuTri,
                     String chanDoan 
         )
        {
          _OrderNumber = OrderNumber ;
             _maBA = maBA ;
		  _ngayDauKyKCC = ngayDauKyKCC ;
		  _cannangtruocthai = cannangtruocthai ;
		  _tuoithai = tuoithai ;
		  _chieucaoTC = chieucaoTC ;
		  _cTC_VB = cTC_VB;
		  _ngoithai = maNgoithai ;
		  _sLThai = sLThai ;
		  _timthai = timthai ;
		  _tinhtrangtimthai = tinhtrangtimthai ;
		  _ngaydukiende = ngaydukiende ;
		  _dauhieubatthuong = dauhieubatthuong ;
		  _xutri = xutri ;
		  _lydoVV = lydoVV ;
		  _tinhthan = tinhthan ;
		  _phu = phu ;
		  _proteinNieu = proteinNieu ;
		  _seomocu = seomocu ;
		  _concotucung = concotucung ;
		  _cotucung = cotucung  ;
		  _cTCMo = cTCMo ;
		  _bishop = bishop ;
		  _dauoi = dauoi ;
		  _tGVooi = tGVooi ;
		  _nuocoi = nuocoi ;
		  _tienluong = tienluong ;
		  _dauseomo = dauseomo ;
		  _ngaydeDukienSA = ngaydeDukienSA  ;
		  _tuanSA = tuanSA ;
		  _tinhthanKhac = tinhthanKhac ;
		  _ngayDe = ngayDe ;
		  _tenConTrai = tenConTrai ;
		  _tenConGai = tenConGai ;
		  _maMay = maMay ;
		  _huy = huy ;
		  _ngaySD = ngaySD ;
		  _nguoiSD = nguoiSD ;
		  _ngaySD1 = ngaySD1 ;
		  _nguoiSD1 = nguoiSD1 ;
          _tennguoiSD = tennguoiSD ;
          _mach = mach;
          _apHuyet = apHuyet;
          _nhietDo = nhietDo;
          _nhipTho = nhipTho;
          _canNang = canNang;
          _chieuCao = chieuCao;
          _dieuTri = dieuTri;
          _chanDoan = chanDoan;
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
		/// Retrieve an existing <see cref="BenhAn_San_Kham" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetBenhAn_San_Kham(String _maBA);
			// public override IDataReader GetBenhAn_San_Kham(String _maBA)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_San_Kham_GET", _maBA));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_San_Kham(crit.MaBA)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="BenhAn_San_Kham" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
			if (dr.GetSmartDate("NgayDauKyKCC", true) != null) _ngayDauKyKCC = dr.GetSmartDate("NgayDauKyKCC", true);
			if (dr.GetInt16("Cannangtruocthai") != null) _cannangtruocthai = dr.GetInt16("Cannangtruocthai");
			if (dr.GetDecimal("Tuoithai") != null) _tuoithai = dr.GetDecimal("Tuoithai");
			if (dr.GetByte("ChieucaoTC") != null) _chieucaoTC = dr.GetByte("ChieucaoTC");
			if (dr.GetInt16("CTC_VB") != null) _cTC_VB = dr.GetInt16("CTC_VB");
            if (dr.GetString("Ngoithai") != null) _ngoithai = dr.GetString("Ngoithai");
			if (dr.GetByte("SLThai") != null) _sLThai = dr.GetByte("SLThai");
			if (dr.GetString("Timthai") != null) _timthai = dr.GetString("Timthai");
			if (dr.GetByte("Tinhtrangtimthai") != null) _tinhtrangtimthai = dr.GetByte("Tinhtrangtimthai");
			if (dr.GetSmartDate("Ngaydukiende", true) != null) _ngaydukiende = dr.GetSmartDate("Ngaydukiende", true);
			if (dr.GetString("Dauhieubatthuong") != null) _dauhieubatthuong = dr.GetString("Dauhieubatthuong");
			if (dr.GetString("Xutri") != null) _xutri = dr.GetString("Xutri");
			if (dr.GetString("LydoVV") != null) _lydoVV = dr.GetString("LydoVV");
			if (dr.GetByte("Tinhthan") != null) _tinhthan = dr.GetByte("Tinhthan");
			if (dr.GetByte("Phu") != null) _phu = dr.GetByte("Phu");
			if (dr.GetString("ProteinNieu") != null) _proteinNieu = dr.GetString("ProteinNieu");
			if (dr.GetByte("Seomocu") != null) _seomocu = dr.GetByte("Seomocu");
			if (dr.GetString("Concotucung") != null) _concotucung = dr.GetString("Concotucung");
			if (dr.GetByte("Cotucung") != null) _cotucung = dr.GetByte("Cotucung");
			if (dr.GetString("CTCMo") != null) _cTCMo = dr.GetString("CTCMo");
			if (dr.GetString("Bishop") != null) _bishop = dr.GetString("Bishop");
			if (dr.GetByte("Dauoi") != null) _dauoi = dr.GetByte("Dauoi");
			if (dr.GetString("TGVooi") != null) _tGVooi = dr.GetString("TGVooi");
			if (dr.GetByte("Nuocoi") != null) _nuocoi = dr.GetByte("Nuocoi");
			if (dr.GetString("Tienluong") != null) _tienluong = dr.GetString("Tienluong");
			if (dr.GetByte("Dauseomo") != null) _dauseomo = dr.GetByte("Dauseomo");
			if (dr.GetSmartDate("NgaydeDukienSA", true) != null) _ngaydeDukienSA = dr.GetSmartDate("NgaydeDukienSA", true);
			if (dr.GetByte("TuanSA") != null) _tuanSA = dr.GetByte("TuanSA");
			if (dr.GetString("TinhthanKhac") != null) _tinhthanKhac = dr.GetString("TinhthanKhac");
			if (dr.GetSmartDate("NgayDe", true) != null) _ngayDe = dr.GetSmartDate("NgayDe", true);
			if (dr.GetString("TenConTrai") != null) _tenConTrai = dr.GetString("TenConTrai");
			if (dr.GetString("TenConGai") != null) _tenConGai = dr.GetString("TenConGai");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("Mach") != null) _mach = dr.GetString("Mach");
            if (dr.GetString("ApHuyet") != null) _apHuyet = dr.GetString("ApHuyet");
            if (dr.GetString("NhietDo") != null) _nhietDo = dr.GetString("NhietDo");
            if (dr.GetString("NhipTho") != null) _nhipTho = dr.GetString("NhipTho");
            if (dr.GetString("CanNang") != null) _canNang = dr.GetString("CanNang");
            if (dr.GetString("ChieuCao") != null) _chieuCao = dr.GetString("ChieuCao");
            if (dr.GetString("DieuTri") != null) _dieuTri = dr.GetString("DieuTri");
            if (dr.GetString("ChanDoan") != null) _chanDoan = dr.GetString("ChanDoan");
		}
		
		/// <summary>
		/// Insert the new <see cref="BenhAn_San_Kham" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_San_Kham
			// Copy & paste ham duoi day vao file DataProvider.cs
            _maBA = DataProvider.Instance().InsertBenhAn_San_Kham(_maBA, _ngayDauKyKCC, _cannangtruocthai, _tuoithai, _chieucaoTC, _cTC_VB, _ngoithai, _sLThai, _timthai, _tinhtrangtimthai, _ngaydukiende, _dauhieubatthuong, _xutri, _lydoVV, _tinhthan, _phu, _proteinNieu, _seomocu, _concotucung, _cotucung, _cTCMo, _bishop, _dauoi, _tGVooi, _nuocoi, _tienluong, _dauseomo, _ngaydeDukienSA, _tuanSA, _tinhthanKhac, _ngayDe, _tenConTrai, _tenConGai, _maMay, _nguoiSD , _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _dieuTri, _chanDoan);
			// public abstract String InsertBenhAn_San_Kham(String _maBA, SmartDate _ngayDauKyKCC, Int16 _cannangtruocthai, Decimal _tuoithai, Byte _chieucaoTC, Int16 _cTC_VB, Byte _ngoithai, Byte _sLThai, String _timthai, Byte _tinhtrangtimthai, SmartDate _ngaydukiende, String _dauhieubatthuong, String _xutri, String _lydoVV, Byte _tinhthan, Byte _phu, String _proteinNieu, Byte _seomocu, String _concotucung, Byte _cotucung, String _cTCMo, String _bishop, Byte _dauoi, String _tGVooi, Byte _nuocoi, String _tienluong, Byte _dauseomo, SmartDate _ngaydeDukienSA, Byte _tuanSA, String _tinhthanKhac, SmartDate _ngayDe, String _tenConTrai, String _tenConGai, String _maMay, String _nguoiSD);
			// public override String InsertBenhAn_San_Kham(String _maBA, SmartDate _ngayDauKyKCC, Int16 _cannangtruocthai, Decimal _tuoithai, Byte _chieucaoTC, Int16 _cTC_VB, Byte _ngoithai, Byte _sLThai, String _timthai, Byte _tinhtrangtimthai, SmartDate _ngaydukiende, String _dauhieubatthuong, String _xutri, String _lydoVV, Byte _tinhthan, Byte _phu, String _proteinNieu, Byte _seomocu, String _concotucung, Byte _cotucung, String _cTCMo, String _bishop, Byte _dauoi, String _tGVooi, Byte _nuocoi, String _tienluong, Byte _dauseomo, SmartDate _ngaydeDukienSA, Byte _tuanSA, String _tinhthanKhac, SmartDate _ngayDe, String _tenConTrai, String _tenConGai, String _maMay, String _nguoiSD)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_San_Kham_CREATE", _maBA, _ngayDauKyKCC.DBValue, _cannangtruocthai, _tuoithai, _chieucaoTC, _cTC_VB, _ngoithai, _sLThai, _timthai, _tinhtrangtimthai, _ngaydukiende.DBValue, _dauhieubatthuong, _xutri, _lydoVV, _tinhthan, _phu, _proteinNieu, _seomocu, _concotucung, _cotucung, _cTCMo, _bishop, _dauoi, _tGVooi, _nuocoi, _tienluong, _dauseomo, _ngaydeDukienSA.DBValue, _tuanSA, _tinhthanKhac, _ngayDe.DBValue, _tenConTrai, _tenConGai, _maMay, _nguoiSD));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAn_San_Kham" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_San_Kham
			if (IsDirty){
                DataProvider.Instance().UpdateBenhAn_San_Kham(_maBA, _ngayDauKyKCC, _cannangtruocthai, _tuoithai, _chieucaoTC, _cTC_VB, _ngoithai, _sLThai, _timthai, _tinhtrangtimthai, _ngaydukiende, _dauhieubatthuong, _xutri, _lydoVV, _tinhthan, _phu, _proteinNieu, _seomocu, _concotucung, _cotucung, _cTCMo, _bishop, _dauoi, _tGVooi, _nuocoi, _tienluong, _dauseomo, _ngaydeDukienSA, _tuanSA, _tinhthanKhac, _ngayDe, _tenConTrai, _tenConGai, _maMay, _huy, _nguoiSD , _mach, _apHuyet, _nhietDo, _nhipTho, _canNang, _chieuCao, _dieuTri, _chanDoan);
				// public abstract void UpdateBenhAn_San_Kham(String _maBA, SmartDate _ngayDauKyKCC, Int16 _cannangtruocthai, Decimal _tuoithai, Byte _chieucaoTC, Int16 _cTC_VB, Byte _ngoithai, Byte _sLThai, String _timthai, Byte _tinhtrangtimthai, SmartDate _ngaydukiende, String _dauhieubatthuong, String _xutri, String _lydoVV, Byte _tinhthan, Byte _phu, String _proteinNieu, Byte _seomocu, String _concotucung, Byte _cotucung, String _cTCMo, String _bishop, Byte _dauoi, String _tGVooi, Byte _nuocoi, String _tienluong, Byte _dauseomo, SmartDate _ngaydeDukienSA, Byte _tuanSA, String _tinhthanKhac, SmartDate _ngayDe, String _tenConTrai, String _tenConGai, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateBenhAn_San_Kham(String _maBA, SmartDate _ngayDauKyKCC, Int16 _cannangtruocthai, Decimal _tuoithai, Byte _chieucaoTC, Int16 _cTC_VB, Byte _ngoithai, Byte _sLThai, String _timthai, Byte _tinhtrangtimthai, SmartDate _ngaydukiende, String _dauhieubatthuong, String _xutri, String _lydoVV, Byte _tinhthan, Byte _phu, String _proteinNieu, Byte _seomocu, String _concotucung, Byte _cotucung, String _cTCMo, String _bishop, Byte _dauoi, String _tGVooi, Byte _nuocoi, String _tienluong, Byte _dauseomo, SmartDate _ngaydeDukienSA, Byte _tuanSA, String _tinhthanKhac, SmartDate _ngayDe, String _tenConTrai, String _tenConGai, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_San_Kham_Update", _maBA, _ngayDauKyKCC.DBValue, _cannangtruocthai, _tuoithai, _chieucaoTC, _cTC_VB, _ngoithai, _sLThai, _timthai, _tinhtrangtimthai, _ngaydukiende.DBValue, _dauhieubatthuong, _xutri, _lydoVV, _tinhthan, _phu, _proteinNieu, _seomocu, _concotucung, _cotucung, _cTCMo, _bishop, _dauoi, _tGVooi, _nuocoi, _tienluong, _dauseomo, _ngaydeDukienSA.DBValue, _tuanSA, _tinhthanKhac, _ngayDe.DBValue, _tenConTrai, _tenConGai, _maMay, _huy, _nguoiSD);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maBA));
		}

		/// <summary>
		/// Delete the <see cref="BenhAn_San_Kham" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_San_Kham
            DataProvider.Instance().DeleteBenhAn_San_Kham(crit.MaMay, crit.NguoiSD, crit.MaBA);
			// public abstract void DeleteBenhAn_San_Kham(String _maBA);
			// public override void DeleteBenhAn_San_Kham(String _maBA)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_San_Kham_Deleted", _maBA);
			// }
		}

		#endregion
	}

}
