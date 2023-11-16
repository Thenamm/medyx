// *****************************************************************************************************
//  File nay HoaChat sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	Khambenh_HoaChat_BN_getsInfo
// Kieu doi tuong  :	Khambenh_HoaChat_BN_getsInfo
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

namespace HTC.Business.HoaChat
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="Khambenh_HoaChat_BN_getsInfo" /> Business Object.
	/// </summary>
	
	[Serializable()]
    public partial class Khambenh_HoaChat_BN_getsInfo : ReadOnlyBase<Khambenh_HoaChat_BN_getsInfo>
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
		private String _tENTM = String.Empty;
		private String _tENDVT = String.Empty;
		private Byte _tUOI = 0;
		private SmartDate _nGAYSINH = new SmartDate(true);
		private String _MaHC = String.Empty;
		private Boolean _dUYET = false;
        private Boolean _pHAT = false;
        //private bool _chon = false;
		private Decimal _dongiaTT = 0;
        private int _OrderNumber;
        private Decimal _sLMua = 0;
        private Decimal _sL = 0;
		#endregion
		
		#region Business Properties and Methods
       
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
                else if (_sLMua - (int)(_sLMua) != 0)
                    return _sLMua.ToString("###,###.###");
                else
                    return _sLMua.ToString("###,###.00");
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
                else if (_sL - (int)(_sL) != 0)
                    return _sL.ToString("###,###.###");
                else
                    return _sL.ToString("###,###.00");
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
		
		public String MaHC
		{
			get 
			{
				CanReadProperty("MaHC", true);
				return _MaHC;
			}
			set 
			{
				if (_MaHC != value) 
				{
					_MaHC = value;
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
                else if (_dongiaTT - (int)(_dongiaTT) != 0)
                {
                    return _dongiaTT.ToString("###,###.###");
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
			
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal Khambenh_HoaChat_BN_getsInfo()
		{	
			// Prevent direct creation
		}

        internal Khambenh_HoaChat_BN_getsInfo(   int ordernumber,
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
		  String tENTM ,
		  String tENDVT ,
		  Byte tUOI ,
		  SmartDate nGAYSINH ,
		  String MaHC,
          Boolean dUYET,
          Boolean pHAT,
		  Decimal dongiaTT, Decimal slmua, Decimal sL)
        {
 _OrderNumber = ordernumber;
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
 _tENTM = tENTM;
 _tENDVT = tENDVT;
 _tUOI = tUOI;
 _nGAYSINH = nGAYSINH;
 _MaHC = MaHC;
 _dUYET = dUYET;
 _pHAT = pHAT;
 _dongiaTT = dongiaTT;
 _sLMua = slmua;
 _sL = sL;
        }
		#endregion
		
		
	}

}
