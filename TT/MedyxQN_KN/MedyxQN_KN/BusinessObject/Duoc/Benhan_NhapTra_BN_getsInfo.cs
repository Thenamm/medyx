// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	NhapTra_C_TonBN_getsInfo
// Kieu doi tuong  :	NhapTra_C_TonBN_getsInfo
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

namespace HTC.Business.Duoc
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="NhapTra_C_TonBN_getsInfo" /> Business Object.
	/// </summary>
	
	[Serializable()]
    public partial class Benhan_NhapTra_BN_getsInfo : ReadOnlyBase<Benhan_NhapTra_BN_getsInfo>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _mATHUOC = String.Empty;
		private String _tENTM = String.Empty;
		private String _tENDVT = String.Empty;
		private Decimal _SLTRA = 0;
        private Decimal _sL = 0;
        private String _mAQL = String.Empty;
        private String _Hoten= String.Empty;
        private Boolean _tra;
        private String _mASOKHAM = String.Empty;
        private String _mABN = String.Empty;
        private Boolean _gt = false;
        private Int32 _sTTKhoa = 0;
        private Int32 _sTT = 0;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
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
        //public Boolean GT
        //{
        //    get
        //    {
        //        CanReadProperty("GT", true);
        //        return _gt;
        //    }
        //    set
        //    {
        //        if (_gt != value)
        //        {
        //            _gt = value;
        //        }
        //    }
        //}
        public string GT
        {
            get
            {
                CanReadProperty("GT", true);
                if (_gt == false)
                    return "Nữ";
                else
                    return "Nam";
            }
            //set
            //{
            //    CanWriteProperty("GT", true);
            //    if (_gt != value)
            //    {
            //        _gt = value;
            //        PropertyHasChanged("GT");
            //    }
            //}
        }

        public String HOTEN
        {
            get
            {
                CanReadProperty("HOTEN", true);
                return _Hoten;
            }
            set
            {
                if (_Hoten != value)
                {
                    _Hoten = value;
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
		public String MAQL
		{
			get 
			{
				CanReadProperty("MAQL", true);
				return _mAQL;
			}
			set 
			{
				if (_mAQL != value) 
				{
					_mAQL = value;
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
		
		public Decimal SLTRA
		{
			get 
			{
                CanReadProperty("SLTRA", true);
                return _SLTRA;
			}
			set 
			{
                if (_SLTRA != value) 
				{
                    _SLTRA = value;
				}
			}
		}
        public string SL
        {
            get
            {
                CanReadProperty("SLTRA", true);
                if (_sL == 0)
                    return "0";
                else
                    return _sL.ToString("###,###.0");
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
        public Boolean tra
        {
            get
            {
                CanReadProperty("tra", true);
                return _tra;
            }
            set
            {
                if (_tra != value)
                {
                    _tra = value;
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
            return _mATHUOC ;
        }
		#endregion
		#endregion

				
		
		
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal Benhan_NhapTra_BN_getsInfo()
		{	
			// Prevent direct creation
		}
        internal Benhan_NhapTra_BN_getsInfo( 
              int OrderNumber,
              String mATHUOC ,
		      String tENTM ,
		      String tENDVT ,
              Decimal SLTRA,
              Decimal sL,
		      String Hoten,
              Boolean tra,
             String mASOKHAM ,
             String mABN ,
             Boolean gt,
             Int32 Sttkhoa,
             Int32 Stt
                    
         )
        {
                      _OrderNumber = OrderNumber ;
                      _mATHUOC = mATHUOC;
                      _tENTM = tENTM;
                      _tENDVT = tENDVT;
                      _SLTRA = SLTRA ;                    
                      _Hoten = Hoten ;
                      _sL = sL;
                      _tra = tra;
                      _mASOKHAM =mASOKHAM ;
                      _mABN =mABN ;
                      _gt=gt ;
                      _sTTKhoa = Sttkhoa;
                      _sTT = Stt; 
        }
		

         
		#endregion
		
		
	}

}
