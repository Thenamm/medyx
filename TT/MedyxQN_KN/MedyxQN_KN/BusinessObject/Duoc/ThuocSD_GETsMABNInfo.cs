// *****************************************************************************************************
using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace HTC.Business.Duoc
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="ThuocSD_GETsMABNInfo" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class ThuocSD_GETsMABNInfo : BusinessBase<ThuocSD_GETsMABNInfo>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maSoKham = String.Empty;
		private String _maBN = String.Empty;
        private SmartDate _ngaydk = new SmartDate(true);
        private SmartDate _ngayDKD = new SmartDate("", true);
        private Decimal _sLMUA = 0;
     
        private String _tENTM = String.Empty;
        private String _tENDVT = String.Empty;
        private String _mathuoc = String.Empty;
        private Decimal _sLTHANG = 0;
        private int _OrderNumber;
       
		#endregion
		
		#region Business Properties and Methods
       
		public String MaSoKham
		{
			get 
			{
				CanReadProperty("MaSoKham", true);
				return _maSoKham;
			}
			set 
			{
				CanWriteProperty("MaSoKham", true);
				if (_maSoKham != value) 
				{
					_maSoKham = value;
					PropertyHasChanged("MaSoKham");
				}
			}
		}
		
		public String MaBN
		{
			get 
			{
				CanReadProperty("MaBN", true);
				return _maBN;
			}
			set 
			{
				CanWriteProperty("MaBN", true);
				if (_maBN != value) 
				{
					_maBN = value;
					PropertyHasChanged("MaBN");
				}
			}
		}
        public Decimal SLTHANG
        {
            get
            {
                CanReadProperty("SLMUAT", true);
                return _sLTHANG;
            }
            set
            {
                if (_sLTHANG != value)
                {
                    _sLTHANG = value;
                }
            }
        }
        public Decimal SLMua
        {
            get
            {
                CanReadProperty("SLMua", true);
                return _sLMUA;
            }
            set
            {
                if (_sLMUA != value)
                {
                    _sLMUA = value;
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
        public String Mathuoc
        {
            get
            {
                CanReadProperty("Mathuoc", true);
                return _mathuoc;
            }
            set
            {
                if (_mathuoc != value)
                {
                    _mathuoc = value;
                }
            }
        }

        public string NGAYDK
        {
            get
            {
                CanReadProperty("NGAYDK", true);
                return _ngaydk.Text;
            }
            set
            {
                if (_ngaydk.Text != value)
                {
                    _ngaydk.Text = value;
                }
            }
        }
        public string NgayDKD
        {
            get
            {
                CanReadProperty("NgayDKD", true);

                _ngayDKD = _ngaydk;
                _ngayDKD.FormatString = "dd/MM/yyyy";
                return _ngayDKD.Text;
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
                //CanWriteProperty(true);
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                    //PropertyHasChanged();
                }
            }
        }

		protected override Object GetIdValue()
		{
			return _maSoKham;
		}
		#endregion
		#endregion

		
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal ThuocSD_GETsMABNInfo()
		{	
			// Prevent direct creation
		}
		
        internal ThuocSD_GETsMABNInfo(  int ordernumber,
   String maBN ,
  String MASOKHAM ,
  SmartDate NGAYDK,
  String TENTM ,
  String TENDVT,  
  String MATHUOC ,           
  Decimal SLMua ,   
  Decimal SLTHANG
            )
        {
_maBN = maBN ;
  _maSoKham=MASOKHAM ;
  _ngaydk = NGAYDK;
  _tENTM= TENTM ;
  _tENDVT = TENDVT ;
  _mathuoc = MATHUOC ;
  _sLMUA = SLMua ; 
  _sLTHANG=SLTHANG;
   
        }
		#endregion
		
     
	}

}
