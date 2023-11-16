// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	Khambenh_ThuocSD_DY_BN_getsInfo
// Kieu doi tuong  :	Khambenh_ThuocSD_DY_BN_getsInfo
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	11/25/2009 2:03:31 PM
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
	/// This is a base generated class of <see cref="Khambenh_ThuocSD_DY_BN_getsInfo" /> Business Object.
	/// </summary>
	
	[Serializable()]
    public partial class Khambenh_ThuocSD_DY_BN_getsInfo : ReadOnlyBase<Khambenh_ThuocSD_DY_BN_getsInfo>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _hOTEN = String.Empty;
		private Boolean _gt = false;
		private String _mABN = String.Empty;
		private String _dIACHI = String.Empty;
		private String _mASOKHAM = String.Empty;
		private Int32 _sTT = 0;
		private String _mADT = String.Empty;
		private String _tENDT = String.Empty;
		private SmartDate _nGAYDK = new SmartDate(true);
		private Decimal _sLMUA = 0;
		private String _sOGIUONG = String.Empty;
		private Byte _tUOI = 0;
		private SmartDate _nGAYSINH = new SmartDate(true);
		private Boolean _dUYET = false;
		private Boolean _pHAT = false;
		private Int32 _sTTKHOA = 0;
        private int _OrderNumber;       
        private Decimal _sL = 0;
        private SmartDate _NgaykhamCuoi = new SmartDate(true);
        private String _TenBenh = String.Empty;
        private String _BSKham = String.Empty;
        private SmartDate _tUNGAY = new SmartDate(true);
        private SmartDate _dENNGAY = new SmartDate(true);
        private SmartDate _TuNgayD = new SmartDate(true);
        private SmartDate _DenNgayD = new SmartDate(true);
        private Decimal _TONGKE = 0;
        private Boolean _KhoaD = false; // khoa duyet
        private SmartDate _ngayKD = new SmartDate(true); // ngay duyet cua khoa
        private SmartDate _ngayKDD = new SmartDate("", true);
        private String _NguoiKD = String.Empty; // nguoi duyet cua khoa
       

		#endregion
		
		#region Business Properties and Methods
       
        public string TUNGAY
        {
            get
            {
                CanReadProperty("TUNGAY", true);
                return _tUNGAY.Text;
            }
            set
            {
                if (_tUNGAY.Text != value)
                {
                    _tUNGAY.Text = value;
                }
            }
        }
        public string TuNgayD
        {
            get
            {
                CanReadProperty("TuNgayD", true);
                _TuNgayD = _tUNGAY;
                _TuNgayD.FormatString = "dd/MM/yyyy";
                return _TuNgayD.Text;
            }

        }

        public string DENNGAY
        {
            get
            {
                CanReadProperty("DENNGAY", true);
                return _dENNGAY.Text;
            }
            set
            {
                if (_dENNGAY.Text != value)
                {
                    _dENNGAY.Text = value;
                }
            }
        }
        public string DenNgayD
        {
            get
            {
                CanReadProperty("DenNgayD", true);
                _DenNgayD = _dENNGAY;
                _DenNgayD.FormatString = "dd/MM/yyyy";
                return _DenNgayD.Text;
            }

        }
        public string TONGKE 
        {
            get
            {
                CanReadProperty("TONGKE", true);
                if (_TONGKE  == 0)
                    return "0";
                else
                    return _TONGKE .ToString("###,###.00");
            }
            set
            {
                // CanWriteProperty("TONGKE Mua", true);
                if (_TONGKE.ToString() != value)
                {
                    _TONGKE  = decimal.Parse(value);
                    //   PropertyHasChanged("TONGKE Mua");
                }
            }
        }
	
        public string ngayKD
        {
            get
            {
                CanReadProperty("ngayKD", true);
                return _ngayKD.Text;
            }
            set
            {
                if (_ngayKD.Text != value)
                {
                    _ngayKD.Text = value;
                }
            }
        }
        public string ngayKDD
        {
            get
            {
                CanReadProperty("ngayKDD", true);

                _ngayKDD = _ngayKDD;
                _ngayKDD.FormatString = "dd/MM/yyyy";
                return _ngayKDD.Text;
            }

        }
        public String NguoiKD
        {
            get
            {
                CanReadProperty("NguoiKD", true);
                return _NguoiKD;
            }
            set
            {
                if (_NguoiKD != value)
                {
                    _NguoiKD = value;
                }
            }
        }

        public String TenBenh
        {
            get
            {
                CanReadProperty("TenBenh", true);
                return _TenBenh;
            }
            set
            {
                if (_TenBenh != value)
                {
                    _TenBenh = value;
                }
            }
        }
        public String BSKham
        {
            get
            {
                CanReadProperty("BSKham", true);
                return _BSKham;
            }
            set
            {
                if (_BSKham != value)
                {
                    _BSKham = value;
                }
            }
        }
        public string NgaykhamCuoi
        {
            get
            {
                CanReadProperty("NgaykhamCuoi", true);
                return _NgaykhamCuoi.Text;
            }
            set
            {
                if (_NgaykhamCuoi.Text != value)
                {
                    _NgaykhamCuoi.Text = value;
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
		
		
        public String GT
        {
            get
            {
                CanReadProperty("GT", true);
                if (_gt == true)
                    return "Nam";
                else
                    return "Nữ";
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
		
		public Decimal SLMUA
		{
			get 
			{
				CanReadProperty("SLMUA", true);
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

        public String sOGIUONG
		{
			get 
			{
                CanReadProperty("SOGIUONG", true);
				return _sOGIUONG;
			}
			set 
			{
				if (_sOGIUONG != value) 
				{
					_sOGIUONG = value;
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
		
		public Boolean PHAT
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
		
		public Int32 STTKHOA
		{
			get 
			{
				CanReadProperty("STTKHOA", true);
				return _sTTKHOA;
			}
			set 
			{
				if (_sTTKHOA != value) 
				{
					_sTTKHOA = value;
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
		protected internal Khambenh_ThuocSD_DY_BN_getsInfo()
		{	
			// Prevent direct creation
		}
        internal Khambenh_ThuocSD_DY_BN_getsInfo(
                             int OrderNumber,
                             String hOTEN ,
		                     Boolean gt ,
		                     String mABN ,
		                     String dIACHI ,
		                     String mASOKHAM ,
		                     Int32 sTT ,
		                     String mADT ,
		                     String tENDT ,
		                     SmartDate nGAYDK ,
		                     Decimal sLMUA ,
		                     String sOGIUONG ,
		                     Byte tUOI ,
		                     SmartDate nGAYSINH ,
		                     Boolean dUYET ,
		                     Boolean pHAT ,
                             Int32 sTTKHOA, 
                            Decimal SL  ,
                              SmartDate NgaykhamCuoi,
                             String BSKham,
                             String TenBenh,
                            SmartDate TUNGAY,
                             SmartDate DENNGAY,
                             Decimal TONGKE,
                             Boolean KHOAD,
                            SmartDate NGAYKD,
                             String NGUOIKD

            )
        {
                      _OrderNumber = OrderNumber ;
                      _hOTEN = hOTEN ;
		              _gt = gt ;
		              _mABN = mABN ;
		              _dIACHI = dIACHI ;
		              _mASOKHAM = mASOKHAM ;
		              _sTT = sTT ;
		              _mADT = mADT ;
		              _tENDT = tENDT ;
		              _nGAYDK = nGAYDK ;
		              _sLMUA = sLMUA ;
		              _sOGIUONG = sOGIUONG ;
		              _tUOI = tUOI ;
		              _nGAYSINH = nGAYSINH ;
		              _dUYET = dUYET ;
		              _pHAT = pHAT ;
		              _sTTKHOA = sTTKHOA ;
                      _sL = SL;
                      _NgaykhamCuoi = NgaykhamCuoi;
                      _BSKham = BSKham;
                      _TenBenh = TenBenh;
                      _tUNGAY = TUNGAY;
                      _dENNGAY = DENNGAY;
                      _TONGKE = TONGKE;
                      _KhoaD = KHOAD;
                      _ngayKD = NGAYKD;
                      _NguoiKD = NGUOIKD;
                     
                  }
		#endregion
		
		

		
	}

}
