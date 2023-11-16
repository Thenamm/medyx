// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	MauNhapTra_C_TonBN_getsInfo
// Kieu doi tuong  :	MauNhapTra_C_TonBN_getsInfo
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
	/// This is a base generated class of <see cref="MauNhapTra_C_TonBN_getsInfo" /> Business Object.
	/// </summary>
	
	[Serializable()]
    public partial class MauNhapTra_C_TonBN_getsInfo : ReadOnlyBase<MauNhapTra_C_TonBN_getsInfo>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _mACPMau = String.Empty;
		private String _tENTM = String.Empty;
		private String _tENDVT = String.Empty;
		private Decimal _tONCK = 0;
        private String _mAQL = String.Empty;
        private SmartDate _hanSD = new SmartDate(false);
        private SmartDate _hanSDD = new SmartDate(false);
        //private SmartDate _hanSD = new SmartDate(false);
        //private SmartDate _hanSDD = new SmartDate(false);
        private String _soLo = String.Empty;
        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods

        public String HanSD
        {
            get
            {
                CanReadProperty("HanSD", true);

                return _hanSD.Text;
            }
            set
            {
               

                if (!_hanSD.Text.Equals(value))
                {

                    //_hanSD.Date   = DateTime.Parse(value);
                    _hanSD.Text = value;
                   
                }
            }
        }
        //public String HanSDD
        //{
        //    get
        //    {
        //        CanReadProperty("HanSDD", true);
        //        this._hanSD.FormatString = "dd/MM/yyyy";
        //        return _hanSD.Text;
        //    }
        //    set
        //    {
        //        CanWriteProperty("HanSDD", true);

        //        if (!_hanSD.Equals(value))
        //        {
        //           // _hanSD.FormatString = "MM/dd/yyyy";
        //            _hanSD.Text = value;
        //            PropertyHasChanged("HanSDD");
        //        }
        //    }
        //}
        public String HanSDD
        {
            get
            {
                CanReadProperty("HanSDD", true);



                _hanSDD = _hanSD;
                this._hanSDD.FormatString = "dd/MM/yyyy";
                return _hanSDD.Text;
            }
            //set
            //{
            //    CanWriteProperty("HanSDD", true);

            //    if (!_hanSDD.Equals(value))
            //    {
            //        _hanSDD.FormatString = "MM/dd/yyyy";
            //        _hanSDD.Text = value;
            //        PropertyHasChanged("HanSDD");
            //    }
            //}
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
		public String MACPMau
		{
			get 
			{
				CanReadProperty("MACPMau", true);
				return _mACPMau;
			}
			set 
			{
				if (_mACPMau != value) 
				{
					_mACPMau = value;
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
            return _mACPMau ;
        }
		#endregion
		#endregion

				
		
		
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal MauNhapTra_C_TonBN_getsInfo()
		{	
			// Prevent direct creation
		}
        internal MauNhapTra_C_TonBN_getsInfo( 
              int OrderNumber,
              String mACPMau ,
		      String tENTM ,
		      String tENDVT ,
		      Decimal tONCK ,
		    String mAQL,
		    String SOLO,
             SmartDate hansd
         )
        {
                      _OrderNumber = OrderNumber ;
                      _mACPMau = mACPMau;
                      _tENTM = tENTM;
                      _tENDVT = tENDVT;
                      _tONCK = tONCK;
                      _mAQL = MAQL;
                      _soLo = SOLO;
                      _hanSD = hansd;
        }
		
		#endregion
		
		
	}

}
