// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	Khambenh_ThuocSD_DY_TON_getsInfo
// Kieu doi tuong  :	Khambenh_ThuocSD_DY_TON_getsInfo
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	11/25/2009 2:34:36 PM
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

namespace HTC.Business.Duoc
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="Khambenh_ThuocSD_DY_TON_getsInfo" /> Business Object.
	/// </summary>
	
	[Serializable()]
    public partial class Khambenh_ThuocSD_DY_TON_getsInfo : ReadOnlyBase<Khambenh_ThuocSD_DY_TON_getsInfo>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _mATHUOC = String.Empty;
		private String _tENTM = String.Empty;
		private String _tENDVT = String.Empty;
        private String _tENDVT2 = String.Empty;
		private Decimal _tONCK = 0;
        private Decimal _tONCKD = 0;
		private Decimal _tONCKDT = 0;
		private String _tENTA = String.Empty;
		private String _tENGOC = String.Empty;
		private Boolean _hANDUNG = false;
		private String _tENNSX = String.Empty;
		private Decimal _dONGIATT = 0;
		private Decimal _gIANHAP = 0;
        private Decimal _gIANHAPD = 0;
		private Decimal _sLDUYET = 0;
		private Decimal _sLPHAT = 0;
        private Decimal _sLPHATD = 0;
		private Decimal _qUYDOI = 0;
        private bool _duyet = false;
        private bool _Phat = false;
        private Decimal _SLMUATT = 0;
        private Decimal _SLDUYETD = 0;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
        public Decimal SLMUATT
        {
            get
            {
                CanReadProperty("SLMUATT", true);
                return _SLMUATT;


            }
            set
            {
                if (_SLMUATT != value)
                {
                    _SLMUATT = value;
                }
            }
        }
        public bool Phat
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _Phat;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_Phat.Equals(value))
                {
                    _Phat = value;
                    //PropertyHasChanged();
                }
            }
        }
        public bool Duyet
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _duyet;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_duyet.Equals(value))
                {
                    _duyet = value;
                    //PropertyHasChanged();
                }
            }
        }
		public String MATHUOC
		{
			get 
			{
				CanReadProperty("MATHUOC", true);
				return _mATHUOC;
			}
			set 
			{
				if (_mATHUOC != value) 
				{
					_mATHUOC = value;
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
        public String TENDVT2
        {
            get
            {
                CanReadProperty("TENDVT2", true);
                return _tENDVT2;
            }
            set
            {
                if (_tENDVT2 != value)
                {
                    _tENDVT2 = value;
                }
            }
        }
		
		public Decimal TONCK
		{
			get 
			{
				CanReadProperty("TONCK", true);
                return _tONCK;
              
				
			}
			set 
			{
				if (_tONCK != value) 
				{
					_tONCK = value;
				}
			}
		}
        public string GIANHAPD
        {
            get
            {
                CanReadProperty("GIANHAPD", true);
                if (_qUYDOI > 0)
                    _gIANHAPD = _gIANHAP ;
                if (_gIANHAPD == 0)
                {
                    return "0";
                }
                else if (_gIANHAPD - (int)(_gIANHAPD) != 0)
                {
                    return _gIANHAPD.ToString("###,##0.###");
                }
                else
                {
                    return _gIANHAPD.ToString("###,###");
                }


            }
            set
            {
                if (_gIANHAPD.ToString() != value)
                {
                    _gIANHAPD = decimal.Parse(value);
                }
            }
        }
        public string TONCKD
        {
            get
            {
                CanReadProperty("TONCKD", true);
                if (_qUYDOI > 0)
                  _tONCKD=  _tONCK;
              if (_tONCKD == 0)
              {
                  return "0";
              }
              else if (_tONCKD - (int)(_tONCKD) != 0)
              {
                  return _tONCKD.ToString("###,##0.###");
              }
              else
              {
                  return _tONCKD.ToString("###,###");
              }
             
               
            }
            set
            {
                if (_tONCKD.ToString()  != value)
                {
                    _tONCKD = decimal.Parse(value);
                }
            }
        }
		public Decimal TONCKDT
		{
			get 
			{
				CanReadProperty("TONCKDT", true);
				return _tONCKDT;
			}
			set 
			{
				if (_tONCKDT != value) 
				{
					_tONCKDT = value;
				}
			}
		}
		
		public String TENTA
		{
			get 
			{
				CanReadProperty("TENTA", true);
				return _tENTA;
			}
			set 
			{
				if (_tENTA != value) 
				{
					_tENTA = value;
				}
			}
		}
		
		public String TENGOC
		{
			get 
			{
				CanReadProperty("TENGOC", true);
				return _tENGOC;
			}
			set 
			{
				if (_tENGOC != value) 
				{
					_tENGOC = value;
				}
			}
		}
		
		public Boolean HANDUNG
		{
			get 
			{
				CanReadProperty("HANDUNG", true);
				return _hANDUNG;
			}
			set 
			{
				if (_hANDUNG != value) 
				{
					_hANDUNG = value;
				}
			}
		}
		
		public String TENNSX
		{
			get 
			{
				CanReadProperty("TENNSX", true);
				return _tENNSX;
			}
			set 
			{
				if (_tENNSX != value) 
				{
					_tENNSX = value;
				}
			}
		}
		
		public Decimal DONGIATT
		{
			get 
			{
				CanReadProperty("DONGIATT", true);
				return _dONGIATT;
			}
			set 
			{
				if (_dONGIATT != value) 
				{
					_dONGIATT = value;
				}
			}
		}
		
		public Decimal GIANHAP
		{
			get 
			{
				CanReadProperty("GIANHAP", true);
				return _gIANHAP;
			}
			set 
			{
				if (_gIANHAP != value) 
				{
					_gIANHAP = value;
				}
			}
		}
		
		public Decimal SLDUYET
		{
			get 
			{
				CanReadProperty("SLDUYET", true);
				// _sLDUYET= _sLPHAT ;
                
                     return _sLDUYET;
                                 
			}
			set 
			{
				if (_sLDUYET != value) 
				{
					_sLDUYET = value;
				}
			}
		}
        public string SLDUYETD
        {
            get
            {
                CanReadProperty("SLDUYETD", true);
                _SLDUYETD = _sLDUYET;
                if (_sLDUYET == 0)
                {
                    return "0";
                }
                else if (_sLDUYET - (int)(_sLDUYET) != 0)
                {
                    return _sLDUYET.ToString("###,##0.00");
                }
                else
                {
                    return _sLDUYET.ToString("###,###");
                }

            }
            set
            {
                if (_SLDUYETD.ToString() != value)
                {
                    _SLDUYETD = decimal.Parse(value);
                }
            }
        }
		public Decimal SLPHAT
		{
			get 
			{
				CanReadProperty("SLPHAT", true);
              
                    return _sLPHAT;
               
               
			}
			set 
			{
				if (_sLPHAT != value) 
				{
					_sLPHAT = value;
				}
			}
		}
        public string SLPHATD
        {
            get
            {
                CanReadProperty("SLPHATD", true);
                 _sLPHATD = _sLPHAT ;
                 if (_sLPHATD == 0)
                 {
                     return "0";
                 }
                 else if (_sLPHATD - (int)(_sLPHATD) != 0)
                 {
                     return _sLPHATD.ToString("###,##0.###");
                 }
                 else
                 {
                     return _sLPHATD.ToString("###,###");
                 }
               
            }
            set
            {
                if (_sLPHATD.ToString()  != value)
                {
                    _sLPHATD  = decimal.Parse(value);
                }
            }
        }
		
		public Decimal QUYDOI
		{
			get 
			{
				CanReadProperty("QUYDOI", true);
				return _qUYDOI;
			}
			set 
			{
				if (_qUYDOI != value) 
				{
					_qUYDOI = value;
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
            return _mATHUOC;
        }
		#endregion
		#endregion							
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal Khambenh_ThuocSD_DY_TON_getsInfo()
		{	
			// Prevent direct creation
		}
        internal Khambenh_ThuocSD_DY_TON_getsInfo(
                         int OrderNumber,
                         String mATHUOC ,
		                 String tENTM ,
		                 String tENDVT ,
                         String tENDVT2,
		                 Decimal tONCK ,
		                 Decimal tONCKDT ,
		                 String tENTA ,
		                 String tENGOC ,
		                 Boolean hANDUNG ,
		                 String tENNSX ,
		                 Decimal dONGIATT ,
		                 Decimal gIANHAP ,
		                 Decimal sLDUYET ,
		                 Decimal sLPHAT ,
		                 Decimal qUYDOI ,
                         Boolean Duyet,
                         Boolean Phat,Decimal SLMUATT
                        
            )
        {
                          _OrderNumber = OrderNumber ;
                          _mATHUOC = mATHUOC ;
		                  _tENTM = tENTM  ;
		                  _tENDVT = tENDVT ;
                          _tENDVT2 = tENDVT2;
		                  _tONCK = tONCK ;
		                  _tONCKDT = tONCKDT ;
		                  _tENTA = tENTA ;
		                  _tENGOC = tENGOC ;
		                  _hANDUNG = hANDUNG ;
		                  _tENNSX = tENNSX ;
		                  _dONGIATT = dONGIATT ;
		                  _gIANHAP = gIANHAP ;
		                  _sLDUYET = sLDUYET ;
		                  _sLPHAT = sLPHAT  ;
		                  _qUYDOI = qUYDOI ;
                          _duyet = Duyet;
                          _Phat = Phat;
                         _SLMUATT = SLMUATT; 
        }
		#endregion
		
		

		
	}

}
