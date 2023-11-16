// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	Khambenh_Mau_TON_getsInfo
// Kieu doi tuong  :	Khambenh_Mau_TON_getsInfo
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	5/5/2009 3:31:11 PM
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
	/// This is a base generated class of <see cref="Khambenh_Mau_TON_getsInfo" /> Business Object.
	/// </summary>
	
	[Serializable()]
    public partial class Khambenh_Mau_TON_getsInfo : ReadOnlyBase<Khambenh_Mau_TON_getsInfo>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _macpmau = String.Empty;
		private String _tENTM = String.Empty;
		private String _tENDVT = String.Empty;
		private Decimal _tONCK = 0;
		private Decimal _tONCKDT = 0;
		private String _tENTA = String.Empty;
		private String _tENGOC = String.Empty;
		private Boolean _hANDUNG = false;
		private String _tENNSX = String.Empty;
		private Decimal _dONGIATT = 0;
		private Decimal _gIANHAP = 0;
		private Decimal _sLDUYET = 0;
        private bool _chon = false;
        private bool _duyet = false;
		private Decimal _sLPHAT = 0;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
        public bool Phat
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _chon;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_chon.Equals(value))
                {
                    _chon = value;
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
		
        //public Decimal TONCK
        //{
        //    get 
        //    {
        //        CanReadProperty("TONCK", true);
        //        return _tONCK;
        //    }
        //    set 
        //    {
        //        if (_tONCK != value) 
        //        {
        //            _tONCK = value;
        //        }
        //    }
        //}
        public string TONCK
        {
            get
            {
                CanReadProperty("TONCK", true);
                if (_tONCK == 0)
                    return "0";
                else
                    return _tONCK.ToString("###,###");
            }
            set
            {
                // CanWriteProperty("SLMua", true);
                if (_tONCK.ToString() != value)
                {
                    _tONCK = decimal.Parse(value);
                    //   PropertyHasChanged("SLMua");
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
		
		public string DONGIATT
		{
			get 
			{
                CanReadProperty("DonGiaTT", true);
                if (_dONGIATT == 0)
                {
                    return "0";
                }
                else
                {
                    return _dONGIATT.ToString("###,###");
                }
			}
			set 
			{
                if (_dONGIATT.ToString() != value)
                {
                    _dONGIATT = decimal.Parse(value);
                }
			}
		}
		
		public string GIANHAP
		{
			get 
			{
                CanReadProperty("GiaNhap", true);
                if (_gIANHAP == 0)
                {
                    return "0";
                }
                else
                {
                    return _gIANHAP.ToString("###,###.00");
                }
			}
			set 
			{
                if (_gIANHAP.ToString() != value)
                {
                    _gIANHAP = decimal.Parse(value);
                    
                }
			}
		}
		
		public Decimal SLDUYET
		{
			get 
			{
				CanReadProperty("SLDUYET", true);
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

        //public Decimal SLPHAT
        //{
        //    get
        //    {
        //        CanReadProperty("SLPHAT", true);
        //        return _sLPHAT;
        //    }
        //    set
        //    {
        //        if (_sLPHAT != value)
        //        {
        //            _sLPHAT = value;
        //        }
        //    }
        //}
        public string SLPHAT
        {
            get
            {
                CanReadProperty("SLPHAT", true);
                if (_sLPHAT == 0)
                    return "0";
                else
                    return _sLPHAT.ToString("###,###");

            }
            set
            {

                if (_sLPHAT.ToString() != value)
                {
                    _sLPHAT = decimal.Parse(value);

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
            return _macpmau ;
        }
		#endregion
		#endregion

				
		
		
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal Khambenh_Mau_TON_getsInfo()
		{	
			// Prevent direct creation
		}
        internal Khambenh_Mau_TON_getsInfo( 
              int OrderNumber,
              String MaCPMau ,
		      String tENTM ,
		      String tENDVT ,
		      Decimal tONCK ,
		      Decimal tONCKDT ,
		      String tENTA ,
		     // String tENGOC ,
		      Boolean hANDUNG ,
		    //  String tENNSX ,
		      Decimal dONGIATT ,
		      Decimal gIANHAP ,
		      Decimal sLDUYET ,
              Decimal sLPHAT, 
              Boolean chon,
              Boolean duyet
         )
        {
                      _OrderNumber = OrderNumber ;
                      _macpmau = MaCPMau;
                      _tENTM = tENTM;
                      _tENDVT = tENDVT;
                      _tONCK = tONCK;
                      _tONCKDT = tONCKDT;
                      _tENTA = tENTA;
                      //_tENGOC = tENGOC;
                      _hANDUNG = hANDUNG;
                      //_tENNSX = tENNSX;
                      _dONGIATT = dONGIATT;
                      _gIANHAP = gIANHAP;
                      _sLDUYET = sLDUYET;
                      _sLPHAT = sLPHAT;
                      _chon = chon;
                      _duyet = duyet;  
        }
		
		#endregion
		
		
	}

}
