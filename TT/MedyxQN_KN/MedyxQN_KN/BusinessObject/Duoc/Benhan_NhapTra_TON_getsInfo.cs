// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	Khambenh_ThuocSD_TON_getsInfo
// Kieu doi tuong  :	Khambenh_ThuocSD_TON_getsInfo
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
	/// This is a base generated class of <see cref="Khambenh_ThuocSD_TON_getsInfo" /> Business Object.
	/// </summary>
	
	[Serializable()]
    public partial class Benhan_Nhaptra_TON_getsInfo : ReadOnlyBase<Benhan_Nhaptra_TON_getsInfo>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _mATHUOC = String.Empty;
		private String _tENTM = String.Empty;
		private String _tENDVT = String.Empty;
		private Decimal _SLTRA = 0;
		private Decimal _dONGIA = 0;	
		private Decimal _sLDUYET = 0;
       
        private bool _duyet = false;	
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
       
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
    
		
		public string DONGIA
		{
			get 
			{
                CanReadProperty("DonGia", true);
                if (_dONGIA == 0)
                {
                    return "0";
                }
                else
                {
                    //return _dONGIATT.ToString("###,###.00");
                    return _dONGIA.ToString("###,###.0");
                }
			}
			set 
			{
                if (_dONGIA.ToString() != value)
                {
                    _dONGIA = decimal.Parse(value);
                }
			}
		}
		
	
        public string SLDUYET
        {
            get
            {
                CanReadProperty("SLDUYET", true);
                if (_sLDUYET == 0)
                    return "0";
                else
                    return _sLDUYET.ToString("###,###.0");

            }
            set
            {

                if (_sLDUYET.ToString() != value)
                {
                    _sLDUYET = decimal.Parse(value);

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
		protected internal Benhan_Nhaptra_TON_getsInfo()
		{	
			// Prevent direct creation
		}
        internal Benhan_Nhaptra_TON_getsInfo( 
              int OrderNumber,
              String mATHUOC ,
		      String tENTM ,
		      String tENDVT ,
		      Decimal SLTRA ,
		      Decimal dONGIA ,		      
		      Decimal sLDUYET ,            
              Boolean duyet
             
        )
        {
                      _OrderNumber = OrderNumber ;
                      _mATHUOC = mATHUOC;
                      _tENTM = tENTM;
                      _tENDVT = tENDVT;
                      _SLTRA = SLTRA ;                      
                      _dONGIA = dONGIA;                     
                      _sLDUYET = sLDUYET;
                      _duyet = duyet;
                      
        }
		
		#endregion
		
		
	}

}
