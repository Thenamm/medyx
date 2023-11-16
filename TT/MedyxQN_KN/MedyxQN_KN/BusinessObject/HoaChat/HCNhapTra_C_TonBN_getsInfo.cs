// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	HCNhapTra_C_TonBN_getsInfo
// Kieu doi tuong  :	HCNhapTra_C_TonBN_getsInfo
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

namespace HTC.Business.HoaChat
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="HCNhapTra_C_TonBN_getsInfo" /> Business Object.
	/// </summary>
	
	[Serializable()]
    public partial class HCNhapTra_C_TonBN_getsInfo : ReadOnlyBase<HCNhapTra_C_TonBN_getsInfo>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _MaHC = String.Empty;
		private String _tENTM = String.Empty;
		private String _tENDVT = String.Empty;
		private Decimal _tONCK = 0;
        private String _mAQL = String.Empty;
      
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
     
		
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
            return _MaHC ;
        }
		#endregion
		#endregion

				
		
		
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal HCNhapTra_C_TonBN_getsInfo()
		{	
			// Prevent direct creation
		}
        internal HCNhapTra_C_TonBN_getsInfo( 
              int OrderNumber,
              String MaHC ,
		      String tENTM ,
		      String tENDVT ,
		      Decimal tONCK ,
		    String mAQL 
         )
        {
                      _OrderNumber = OrderNumber ;
                      _MaHC = MaHC;
                      _tENTM = tENTM;
                      _tENDVT = tENDVT;
                      _tONCK = tONCK;
                      _mAQL = MAQL;
        }
		
		#endregion
		
		
	}

}
