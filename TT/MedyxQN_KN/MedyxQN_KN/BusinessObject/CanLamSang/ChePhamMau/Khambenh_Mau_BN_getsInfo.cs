// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	Khambenh_Mau_BN_getsInfo
// Kieu doi tuong  :	Khambenh_Mau_BN_getsInfo
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	5/5/2009 2:38:31 PM
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

namespace HTC.Business.CanLamSang
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="Khambenh_Mau_BN_getsInfo" /> Business Object.
	/// </summary>
	
	[Serializable()]
    public partial class Khambenh_Mau_BN_getsInfo : BusinessBase<Khambenh_Mau_BN_getsInfo>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _hOTEN = String.Empty;
		private Boolean _gt = false;
		private String _mABN = String.Empty;
		private String _dIACHI = String.Empty;
		private String _mASOKHAM = String.Empty;
		private Int32 _sTT = 0;
        private Int32 _sTTKhoa = 0;
		private String _mADT = String.Empty;
		private String _tENDT = String.Empty;
		private SmartDate _nGAYDK = new SmartDate(true);
        private SmartDate _TuNgay = new SmartDate(true);
        private String _tENTM = String.Empty;
		private String _tENDVT = String.Empty;
		private Byte _tUOI = 0;
		private SmartDate _nGAYSINH = new SmartDate(true);
		private String _macpmau = String.Empty;
		private Boolean _dUYET = false;
        private Boolean _pHAT = false;
        //private bool _chon = false;
		private Decimal _dongiaTT = 0;
        private int _OrderNumber;
        private Decimal _sLMua = 0;
        private Decimal _sL = 0;
        private string _hanSD = String.Empty;
      
        private String _soLo = String.Empty;
        private String _ABOBN = String.Empty;
        private String _ABOMau = String.Empty;
        private String _RhDBN = String.Empty;
        private String _HoaHopcheo1 = String.Empty;
        private String _HoaHopcheo2 = String.Empty;
        private String _HoaHoptieucau = String.Empty;
        private String _Coombs = String.Empty;
        private String _MaNhomMau = String.Empty;
        private String _RhD = String.Empty;
        private String _TenNhom = String.Empty;
        private String _SoGiuong = String.Empty;
        private String _SoPhong = String.Empty;
        private String _bschidinh = String.Empty;
        private String _MaMau = String.Empty;
		#endregion
		
		#region Business Properties and Methods
        public String bschidinh
        {
            get
            {
                CanReadProperty("bschidinh", true);
                return _bschidinh;
            }
            set
            {
                CanWriteProperty("bschidinh", true);
                if (_bschidinh != value)
                {
                    _bschidinh = value;
                    PropertyHasChanged("bschidinh");
                }
            }
        }
        public String TenNhom
        {
            get
            {
                CanReadProperty("TenNhom", true);
                return _TenNhom;
            }
            set
            {
                if (_TenNhom != value)
                {
                    _TenNhom = value;

                }
            }
        }
        public String SoGiuong
        {
            get
            {
                CanReadProperty("SoGiuong", true);
                return _SoGiuong;
            }
            set
            {
                if (_SoGiuong != value)
                {
                    _SoGiuong = value;

                }
            }
        }
        public String SoPhong
        {
            get
            {
                CanReadProperty("SoPhong", true);
                return _SoPhong;
            }
            set
            {
                if (_SoPhong != value)
                {
                    _SoPhong = value;

                }
            }
        }
        public String MaNhomMau
        {
            get
            {
                CanReadProperty("MaNhomMau", true);
                return _MaNhomMau;
            }
            set
            {
                 if (_MaNhomMau != value)
                {
                    _MaNhomMau = value;
                   
                }
            }
        }
        public String MaMau
        {
            get
            {
                CanReadProperty("MaMau", true);
                return _MaMau;
            }
            set
            {
                if (_MaMau != value)
                {
                    _MaMau = value;

                }
            }
        }
        public String RhD
        {
            get
            {
                CanReadProperty("RhD", true);
                return _RhD;
            }
            set
            {
                if (_RhD != value)
                {
                    _RhD = value;

                }
            }
        }
        public String Coombs
        {
            get
            {
                CanReadProperty("Coombs", true);
                return _Coombs;
            }
            set
            {
                if (_Coombs != value)
                {
                    _Coombs = value;

                }
            }
        }
        public String HoaHoptieucau
        {
            get
            {
                CanReadProperty("HoaHoptieucau", true);
                return _HoaHoptieucau;
            }
            set
            {
                if (_HoaHoptieucau != value)
                {
                    _HoaHoptieucau = value;

                }
            }
        }
        public String HoaHopcheo2
        {
            get
            {
                CanReadProperty("HoaHopcheo2", true);
                return _HoaHopcheo2;
            }
            set
            {
                if (_HoaHopcheo2 != value)
                {
                    _HoaHopcheo2 = value;

                }
            }
        }
        public String HoaHopcheo1
        {
            get
            {
                CanReadProperty("HoaHopcheo1", true);
                return _HoaHopcheo1;
            }
            set
            {
                if (_HoaHopcheo1 != value)
                {
                    _HoaHopcheo1 = value;

                }
            }
        }
        public String RhDBN
        {
            get
            {
                CanReadProperty("RhDBN", true);
                return _RhDBN;
            }
            set
            {
                if (_RhDBN != value)
                {
                    _RhDBN = value;

                }
            }
        }
        public String ABOMau
        {
            get
            {
                CanReadProperty("ABOMau", true);
                return _ABOMau;
            }
            set
            {
                if (_ABOMau != value)
                {
                    _ABOMau = value;

                }
            }
        }
        public String ABOBN
        {
            get
            {
                CanReadProperty("ABOBN", true);
                return _ABOBN;
            }
            set
            {
                if (_ABOBN != value)
                {
                    _ABOBN = value;

                }
            }
        }
        public String HanSD
        {
            get
            {
                CanReadProperty("HanSD", true);
             
                return _hanSD;
            }
            set
            {
               

                if (!_hanSD.Equals(value))
                {
                  
                    _hanSD = value;
                  
                }
            }
        }
       
     
        public String SoLo
        {
            get
            {
                CanReadProperty("SoLo", true);
                return _soLo;
            }
            set
            {
               
                if (_soLo != value)
                {
                    _soLo = value;
                  
                }
            }
        }
		public String HOTEN
		{
			get 
			{
				CanReadProperty("HOTEN", true);
				return _hOTEN;
			}
			set 
			{
				if (_hOTEN != value) 
				{
					_hOTEN = value;
				}
			}
		}
		
		public Boolean GT
		{
			get 
			{
				CanReadProperty("GT", true);
				return _gt;
			}
			set 
			{
				if (_gt != value) 
				{
					_gt = value;
				}
			}
		}
		
		public String MABN
		{
			get 
			{
				CanReadProperty("MABN", true);
				return _mABN;
			}
			set 
			{
				if (_mABN != value) 
				{
					_mABN = value;
				}
			}
		}
       
        public string SLMua
        {
            get
            {
                CanReadProperty("SLMua", true);
                if (_sLMua == 0)
                    return "0";
                else
                    return _sLMua.ToString("###,###");
            }
            set
            {
               // CanWriteProperty("SLMua", true);
                if (_sLMua.ToString() != value)
                {
                    _sLMua = decimal.Parse(value);
                 //   PropertyHasChanged("SLMua");
                }
            }
        }
        public string SL
        {
            get
            {
                CanReadProperty("SLMua", true);
                if (_sL == 0)
                    return "0";
                else
                    return _sL.ToString("###,###");
            }
            set
            {
                // CanWriteProperty("SLMua", true);
                if (_sL.ToString() != value)
                {
                    _sL = decimal.Parse(value);
                    //   PropertyHasChanged("SLMua");
                }
            }
        }
		public String DIACHI
		{
			get 
			{
				CanReadProperty("DIACHI", true);
				return _dIACHI;
			}
			set 
			{
				if (_dIACHI != value) 
				{
					_dIACHI = value;
				}
			}
		}
		
		public String MASOKHAM
		{
			get 
			{
				CanReadProperty("MASOKHAM", true);
				return _mASOKHAM;
			}
			set 
			{
				if (_mASOKHAM != value) 
				{
					_mASOKHAM = value;
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
				if (_sTT != value) 
				{
					_sTT = value;
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
                if (_sTTKhoa != value)
                {
                    _sTTKhoa = value;
                }
            }
        }
		
		public String MADT
		{
			get 
			{
				CanReadProperty("MADT", true);
				return _mADT;
			}
			set 
			{
				if (_mADT != value) 
				{
					_mADT = value;
				}
			}
		}
		
		public String TENDT
		{
			get 
			{
				CanReadProperty("TENDT", true);
				return _tENDT;
			}
			set 
			{
				if (_tENDT != value) 
				{
					_tENDT = value;
				}
			}
		}
		
		public string NGAYDK
		{
			get 
			{
				CanReadProperty("NGAYDK", true);
				return _nGAYDK.Text;
			}
			set 
			{
				if (_nGAYDK.Text != value) 
				{
					_nGAYDK.Text = value;
				}
			}
		}
        public string TuNgay
        {
            get
            {
                CanReadProperty("TuNgay", true);
                return _TuNgay.Text;
            }
            set
            {
                if (_TuNgay.Text != value)
                {
                    _TuNgay.Text = value;
                }
            }
        }
		public String TENTM
		{
			get 
			{
				CanReadProperty("TENTM", true);
				return _tENTM;
			}
			set 
			{
				if (_tENTM != value) 
				{
					_tENTM = value;
				}
			}
		}
		
		public String TENDVT
		{
			get 
			{
				CanReadProperty("TENDVT", true);
				return _tENDVT;
			}
			set 
			{
				if (_tENDVT != value) 
				{
					_tENDVT = value;
				}
			}
		}
		
		public Byte TUOI
		{
			get 
			{
				CanReadProperty("TUOI", true);
				return _tUOI;
			}
			set 
			{
				if (_tUOI != value) 
				{
					_tUOI = value;
				}
			}
		}
		
		public string NGAYSINH
		{
			get 
			{
				CanReadProperty("NGAYSINH", true);
				return _nGAYSINH.Text;
			}
			set 
			{
				if (_nGAYSINH.Text != value) 
				{
					_nGAYSINH.Text = value;
				}
			}
		}
		
		public String MaCPMau
		{
			get 
			{
				CanReadProperty("MaCPMau", true);
				return _macpmau;
			}
			set 
			{
				if (_macpmau != value) 
				{
					_macpmau = value;
				}
			}
		}

        public Boolean DUYET
		{
			get 
			{
				CanReadProperty("DUYET", true);
				return _dUYET;
			}
			set 
			{
				if (_dUYET != value) 
				{
					_dUYET = value;
				}
			}
		}
		
		public Boolean Phat
		{
			get 
			{
				CanReadProperty("PHAT", true);
				return _pHAT;
			}
			set 
			{
				if (_pHAT != value) 
				{
					_pHAT = value;
				}
			}
		}
		
		public string DongiaTT
		{
			get 
			{
                CanReadProperty("DonGiaTT", true);
                if (_dongiaTT == 0)
                {
                    return "0";
                }
                else
                {
                    return _dongiaTT.ToString("###,###");
                }
			}
			set 
			{
                if (_dongiaTT.ToString() != value)
                {
                    _dongiaTT = decimal.Parse(value);
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

        protected override object GetIdValue()
        {
            return _sTT;
        }
		#endregion

		#endregion
        #region Factory Methods

        public static Khambenh_Mau_BN_getsInfo NewKhambenh_Mau_BN_getsInfo()
        {
            return new Khambenh_Mau_BN_getsInfo();

        }
        #endregion
        #region Constructors
        // Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal Khambenh_Mau_BN_getsInfo()
		{	
			// Prevent direct creation
		}

        internal Khambenh_Mau_BN_getsInfo(   int ordernumber,
          String hOTEN ,
		  Boolean gt ,
		  String mABN ,
		  String dIACHI ,
		  String mASOKHAM ,
		  Int32 sTT ,
          Int32 sTTKhoa,
		  String mADT ,
          String tenDT,
		  SmartDate nGAYDK,
             SmartDate tunGAY,
		  String tENTM ,
		  String tENDVT ,
		  Byte tUOI ,
		  SmartDate nGAYSINH ,
		  String MaCPMau,
          Boolean dUYET,
          Boolean pHAT,
          Decimal dongiaTT, Decimal slmua, Decimal sL, string solo, string hansd, string manhommau
            , string TenNhom
            , string SoGiuong
            , string SoPhong
            , string ABOBN
            , string ABOMau
            , string RhDBN
            , string HoaHopcheo1
            , string HoaHopcheo2
            , string HoaHoptieucau
            , string Coombs
            , string RhD
            , string bs
            )

           

        {
 _OrderNumber = ordernumber;
 _MaNhomMau = manhommau;
 _ABOMau = ABOMau;
 _ABOBN = ABOBN;
 _SoPhong = SoPhong;
 _SoGiuong = SoGiuong;
 _TenNhom = TenNhom;
 _RhD = RhD;
 _RhDBN = RhDBN;
 _Coombs = Coombs;
 _HoaHoptieucau = HoaHoptieucau;
 _HoaHopcheo2 = HoaHopcheo2;
 _HoaHopcheo1 = HoaHopcheo1;
 _bschidinh = bs;
 _hOTEN = hOTEN;
 _gt = gt;
 _mABN = mABN;
 _dIACHI = dIACHI;
 _mASOKHAM = mASOKHAM;
 _sTT = sTT;
 _sTTKhoa = sTTKhoa;
 _mADT = mADT;
 _tENDT = tenDT;
 _nGAYDK = nGAYDK;
 _TuNgay = tunGAY;
 _tENTM = tENTM;
 _tENDVT = tENDVT;
 _tUOI = tUOI;
 _nGAYSINH = nGAYSINH;
 _macpmau = MaCPMau;
 _dUYET = dUYET;
 _pHAT = pHAT;
 _dongiaTT = dongiaTT;
 _sLMua = slmua;
 _sL = sL;
 _soLo = solo;
 _hanSD = hansd;
        }


		#endregion
		
		
	}

}
