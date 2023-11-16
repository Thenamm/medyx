// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMTBYT_TON_GETSKHOInfo
// Kieu doi tuong  :	DMTBYT_TON_GETSKHOInfo
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	8/22/2009 9:33:30 AM
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

namespace HTC.Business.CategoryList
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="DMTBYT_TON_GETSKHOInfo" /> Business Object.
	/// </summary>
	
	[Serializable()]
    public partial class DMTBYT_TON_GETSKHOInfo : ReadOnlyBase<DMTBYT_TON_GETSKHOInfo>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _mATB = String.Empty;
		private String _mATBC = String.Empty;
		private String _tENTB = String.Empty;
		private String _tENDVT = String.Empty;
		private Decimal _tONCK = 0;
		private Decimal _tONCKDT = 0;
		private Decimal _sLSUACHUA = 0;
		private Decimal _sLBAODUONG = 0;
		private Decimal _sLXINTHANHLY = 0;
		private Decimal _gIANHAP = 0;
        private String _serialNo = String.Empty;
        private String _model = String.Empty;
        private String _congsuatTK = String.Empty;
        private int _OrderNumber;
        private int _SuDungDN;
        private SmartDate _NgayBaoDuong = new SmartDate(true);
		#endregion
		
		#region Business Properties and Methods
        public string NgayBaoDuong
        {
            get
            {
                CanReadProperty("NgayBaoDuong", true);
                return _NgayBaoDuong.Text;
            }
            set
            {
               
                if (_NgayBaoDuong.Text != value)
                {
                    _NgayBaoDuong.Text = value;
                    
                }
            }
        }
        public Int32 SuDungDN
        {
            get
            {
                CanReadProperty("SuDungDN", true);
                return _SuDungDN;
            }
            set
            {
                //CanWriteProperty("SuDungDN", true);
                if (_SuDungDN != value)
                {
                    _SuDungDN = value;
                  //  PropertyHasChanged("SuDungDN");
                }
            }
        }
		public String MATB
		{
			get 
			{
				return _mATB;
			}
			set 
			{
				if (_mATB != value) 
				{
					_mATB = value;
				}
			}
		}
		
		public String MATBC
		{
			get 
			{
				CanReadProperty("MATBC", true);
				return _mATBC;
			}
			set 
			{
				if (_mATBC != value) 
				{
					_mATBC = value;
				}
			}
		}
		
		public String TENTB
		{
			get 
			{
				return _tENTB;
			}
			set 
			{
				if (_tENTB != value) 
				{
					_tENTB = value;
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
                {
                    return "0";
                }
                else
                {
                    return _tONCK.ToString("###,###");
                }
            }
            set
            {
                //CanWriteProperty("TONCK", true);

                if (_tONCK.ToString() != value)
                {
                    _tONCK = decimal.Parse(value);
                   // PropertyHasChanged("TONCK");
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
		
		public Decimal SLSUACHUA
		{
			get 
			{
				CanReadProperty("SLSUACHUA", true);
				return _sLSUACHUA;
			}
			set 
			{
				if (_sLSUACHUA != value) 
				{
					_sLSUACHUA = value;
				}
			}
		}
		
		public Decimal SLBAODUONG
		{
			get 
			{
				CanReadProperty("SLBAODUONG", true);
				return _sLBAODUONG;
			}
			set 
			{
				if (_sLBAODUONG != value) 
				{
					_sLBAODUONG = value;
				}
			}
		}
		
		public Decimal SLXINTHANHLY
		{
			get 
			{
				CanReadProperty("SLXINTHANHLY", true);
				return _sLXINTHANHLY;
			}
			set 
			{
				if (_sLXINTHANHLY != value) 
				{
					_sLXINTHANHLY = value;
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
        public String SerialNo
        {
            get
            {
                CanReadProperty("SerialNo", true);
                return _serialNo;
            }
            set
            {
                if (_serialNo != value)
                {
                    _serialNo = value;
                }
            }
        }

        public String Model
        {
            get
            {
                CanReadProperty("Model", true);
                return _model;
            }
            set
            {
                if (_model != value)
                {
                    _model = value;
                }
            }
        }
        public String CongsuatTK
        {
            get
            {
                CanReadProperty("CongsuatTK", true);
                return _congsuatTK;
            }
            set
            {
                if (_congsuatTK != value)
                {
                    _congsuatTK = value;
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
            return _mATB;
        }
		#endregion
		#endregion

				
		
		
		
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal DMTBYT_TON_GETSKHOInfo()
		{	
			// Prevent direct creation
		}
        internal DMTBYT_TON_GETSKHOInfo(
  int OrderNumber,
  String mATB ,
		                                 String mATBC ,
		                                 String tENTB ,
		                                 String tENDVT ,
		                                 Decimal tONCK ,
		                                 Decimal tONCKDT ,
		                                 Decimal sLSUACHUA ,
		                                 Decimal sLBAODUONG ,
		                                 Decimal sLXINTHANHLY ,
		                                 Decimal gIANHAP ,
  String serialNo,
  String model,
            String CongSuatTK,
                                 Int32 SuDungDN,
                                SmartDate ngaybaoduong
            
            )
        {
   _OrderNumber = OrderNumber ;
   _mATB = mATB ;
   _SuDungDN = SuDungDN;
		                                  _mATBC = mATBC ;
		                                  _tENTB = tENTB ;
   _NgayBaoDuong = ngaybaoduong;
		                                  _tENDVT = tENDVT ;
		                                  _tONCK = tONCK  ;
		                                  _tONCKDT = tONCKDT  ;
		                                  _sLSUACHUA  = sLSUACHUA ;
		                                  _sLBAODUONG = sLBAODUONG  ;
		                                  _sLXINTHANHLY = sLXINTHANHLY  ;
   _gIANHAP = gIANHAP ;
   _serialNo = serialNo;
   _model = model;
   _congsuatTK = CongSuatTK;
        }
		#endregion
		
		
	}

}
