// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_GETsBCDICHVUInfo
// Kieu doi tuong  :	BenhAn_GETsBCDICHVUInfo
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	4/2/2009 3:21:38 PM
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
using HTC.Business.CategoryList;

namespace HTC.Business.NoiTru
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="BenhAn_GETsBCDICHVUInfo" /> Business Object.
	/// </summary>
	
	[Serializable()]
    public partial class BenhAn_GETsBCDICHVUInfo : BusinessBase<BenhAn_GETsBCDICHVUInfo>
	{
        #region Business Methods

        #region State Fields

        private String _madt = String.Empty;
        private Int32 _sTTDT = 0;
        private String _mASOKHAM = String.Empty;
        private Int32 _lOAIDV = 0;
        private String _maDV = String.Empty;
        private String _tENDV = String.Empty;
        private Int32 _sTT = 0;
        private Decimal _dONGIATT = 0;
        private Decimal _dONGIABH = 0;
        private Boolean _aDGIAUSD = false;
        private Decimal _sOLUONG = 0;
        private String _mAKHOA = String.Empty;
        private String _bSKHAM = String.Empty;
        private Boolean _tINHTIEN = false;
        private Boolean _bHTINHTIEN = false;
        private Byte _dATT = 0;
        private Decimal _ck = 0;
        private String _tENKHOA = String.Empty;
        private String _tENBS = String.Empty;
        private Int32 _nGAYYC = 0;
        private Int32 _nGAYLAP = 0;
        private String _nGUOILAP = String.Empty;
        private String _nGUOISD = String.Empty;
        private Int32 _nGAYSD = 0;
        private Int32 _nGAYHUY = 0;
        private String _nGUOIHUY = String.Empty;
        private String _tENNGUOILAP = String.Empty;
        private String _tENNGUOISD = String.Empty;
        private String _tENNGUOIHUY = String.Empty;
        private String _sOHD = String.Empty;
        private String _sOSOHD = String.Empty;
        private Int32 _tYGIA = 0;
        private Decimal _gIACHENHLECH = 0;
        private String _tENDVT = String.Empty;
        private String _tENDT = String.Empty;
        private Decimal _bHTRA = 0;
        private SmartDate _nGAYVVTT = new SmartDate(true);
        private SmartDate _nGAYKT = new SmartDate(true);
        private Decimal _thanhTien;
        private int _OrderNumber;
        private String _KQ = String.Empty;
        private String _tENCS = String.Empty;
        private String _tENKQ = String.Empty;
    
        #endregion

        #region Business Properties and Methods
        public String TENCS
        {
            get
            {
                CanReadProperty("TENCS", true);
                return _tENCS;
            }
            set
            {
                CanWriteProperty("TENCS", true);
                if (_tENCS != value)
                {
                    _tENCS = value;
                    PropertyHasChanged("TENCS");
                }
            }
        }
        public String TENKQ
        {
            get
            {
                CanReadProperty("TENKQ", true);
                return _tENKQ;
            }
            set
            {
                CanWriteProperty("TENKQ", true);
                if (_tENKQ != value)
                {
                    _tENKQ = value;
                    PropertyHasChanged("TENKQ");
                }
            }
        }
        public String Madt
        {
            get
            {
                CanReadProperty("Madt", true);
                return _madt;
            }
            set
            {
                CanWriteProperty("Madt", true);
                if (_madt != value)
                {
                    _madt = value;
                    PropertyHasChanged("Madt");
                }
            }
        }
        public String KQ
        {
            get
            {
                CanReadProperty("KQ", true);
                return _KQ;
            }
            set
            {
                CanWriteProperty("KQ", true);
                if (_KQ != value)
                {
                    _KQ = value;
                    PropertyHasChanged("KQ");
                }
            }
        }
        public Int32 STTDT
        {
            get
            {
                CanReadProperty("STTDT", true);
                return _sTTDT;
            }
            set
            {
                CanWriteProperty("STTDT", true);
                if (_sTTDT != value)
                {
                    _sTTDT = value;
                    PropertyHasChanged("STTDT");
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
                CanWriteProperty("MASOKHAM", true);
                if (_mASOKHAM != value)
                {
                    _mASOKHAM = value;
                    PropertyHasChanged("MASOKHAM");
                }
            }
        }

        public Int32 LOAIDV
        {
            get
            {
                CanReadProperty("LOAIDV", true);
                return _lOAIDV;
            }
            set
            {
                CanWriteProperty("LOAIDV", true);
                if (_lOAIDV != value)
                {
                    _lOAIDV = value;
                    PropertyHasChanged("LOAIDV");
                }
            }
        }

        public String MaDV
        {
            get
            {
                CanReadProperty("MaDV", true);
                return _maDV;
            }
            set
            {
                CanWriteProperty("MaDV", true);
                if (_maDV != value)
                {
                    _maDV = value;
                    PropertyHasChanged("MaDV");
                }
            }
        }

        public String TENDV
        {
            get
            {
                CanReadProperty("TENDV", true);
                return _tENDV;
            }
            set
            {
                CanWriteProperty("TENDV", true);
                if (_tENDV != value)
                {
                    _tENDV = value;
                    PropertyHasChanged("TENDV");
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
                CanWriteProperty("STT", true);
                if (_sTT != value)
                {
                    _sTT = value;
                    PropertyHasChanged("STT");
                }
            }
        }

        public string DONGIATT
        {
            get
            {
                CanReadProperty("DONGIATT", true);
                if (_dONGIATT == 0)
                    return "0";
                else
                    return _dONGIATT.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DONGIATT", true);

                if (_dONGIATT.ToString() != value)
                {
                    _dONGIATT = decimal.Parse(value);
                    PropertyHasChanged("DONGIATT");
                }
            }
        }

        public string DONGIABH
        {
            get
            {
                CanReadProperty("DONGIABH", true);
                if (_dONGIABH == 0)
                    return "0";
                else
                    return _dONGIABH.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DONGIABH", true);

                if (_dONGIABH.ToString() != value)
                {
                    _dONGIABH = decimal.Parse(value);
                    PropertyHasChanged("DONGIABH");
                }
            }
        }

        public Boolean ADGIAUSD
        {
            get
            {
                CanReadProperty("ADGIAUSD", true);
                return _aDGIAUSD;
            }
            set
            {
                CanWriteProperty("ADGIAUSD", true);
                if (_aDGIAUSD != value)
                {
                    _aDGIAUSD = value;
                    PropertyHasChanged("ADGIAUSD");
                }
            }
        }

        public Decimal SOLUONG
        {
            get
            {
                CanReadProperty("SOLUONG", true);
                return _sOLUONG;
            }
            set
            {
                CanWriteProperty("SOLUONG", true);
                if (_sOLUONG != value)
                {
                    _sOLUONG = value;
                    PropertyHasChanged("SOLUONG");
                }
            }
        }

        public String MAKHOA
        {
            get
            {
                CanReadProperty("MAKHOA", true);
                return _mAKHOA;
            }
            set
            {
                CanWriteProperty("MAKHOA", true);
                if (_mAKHOA != value)
                {
                    _mAKHOA = value;
                    PropertyHasChanged("MAKHOA");
                }
            }
        }

        public String BSKHAM
        {
            get
            {
                CanReadProperty("BSKHAM", true);
                return _bSKHAM;
            }
            set
            {
                CanWriteProperty("BSKHAM", true);
                if (_bSKHAM != value)
                {
                    _bSKHAM = value;
                    PropertyHasChanged("BSKHAM");
                }
            }
        }

        public Boolean TINHTIEN
        {
            get
            {
                CanReadProperty("TINHTIEN", true);
                return _tINHTIEN;
            }
            set
            {
                CanWriteProperty("TINHTIEN", true);
                if (_tINHTIEN != value)
                {
                    _tINHTIEN = value;
                    PropertyHasChanged("TINHTIEN");
                }
            }
        }

        public Boolean BHTINHTIEN
        {
            get
            {
                CanReadProperty("BHTINHTIEN", true);
                return _bHTINHTIEN;
            }
            set
            {
                CanWriteProperty("BHTINHTIEN", true);
                if (_bHTINHTIEN != value)
                {
                    _bHTINHTIEN = value;
                    PropertyHasChanged("BHTINHTIEN");
                }
            }
        }

        public Byte DATT
        {
            get
            {
                CanReadProperty("DATT", true);
                return _dATT;
            }
            set
            {
                CanWriteProperty("DATT", true);
                if (_dATT != value)
                {
                    _dATT = value;
                    PropertyHasChanged("DATT");
                }
            }
        }

        public Decimal CK
        {
            get
            {
                CanReadProperty("CK", true);
                return _ck;
            }
            set
            {
                CanWriteProperty("CK", true);
                if (_ck != value)
                {
                    _ck = value;
                    PropertyHasChanged("CK");
                }
            }
        }

        public String TENKHOA
        {
            get
            {
                CanReadProperty("TENKHOA", true);
                return _tENKHOA;
            }
            set
            {
                CanWriteProperty("TENKHOA", true);
                if (_tENKHOA != value)
                {
                    _tENKHOA = value;
                    PropertyHasChanged("TENKHOA");
                }
            }
        }

        public String TENBS
        {
            get
            {
                CanReadProperty("TENBS", true);
                return _tENBS;
            }
            set
            {
                CanWriteProperty("TENBS", true);
                if (_tENBS != value)
                {
                    _tENBS = value;
                    PropertyHasChanged("TENBS");
                }
            }
        }

        public Int32 NGAYYC
        {
            get
            {
                CanReadProperty("NGAYYC", true);
                return _nGAYYC;
            }
            set
            {
                CanWriteProperty("NGAYYC", true);
                if (_nGAYYC != value)
                {
                    _nGAYYC = value;
                    PropertyHasChanged("NGAYYC");
                }
            }
        }

        public Int32 NGAYLAP
        {
            get
            {
                CanReadProperty("NGAYLAP", true);
                return _nGAYLAP;
            }
            set
            {
                CanWriteProperty("NGAYLAP", true);
                if (_nGAYLAP != value)
                {
                    _nGAYLAP = value;
                    PropertyHasChanged("NGAYLAP");
                }
            }
        }

        public String NGUOILAP
        {
            get
            {
                CanReadProperty("NGUOILAP", true);
                return _nGUOILAP;
            }
            set
            {
                CanWriteProperty("NGUOILAP", true);
                if (_nGUOILAP != value)
                {
                    _nGUOILAP = value;
                    PropertyHasChanged("NGUOILAP");
                }
            }
        }

        public String NGUOISD
        {
            get
            {
                CanReadProperty("NGUOISD", true);
                return _nGUOISD;
            }
            set
            {
                CanWriteProperty("NGUOISD", true);
                if (_nGUOISD != value)
                {
                    _nGUOISD = value;
                    PropertyHasChanged("NGUOISD");
                }
            }
        }

        public Int32 NGAYSD
        {
            get
            {
                CanReadProperty("NGAYSD", true);
                return _nGAYSD;
            }
            set
            {
                CanWriteProperty("NGAYSD", true);
                if (_nGAYSD != value)
                {
                    _nGAYSD = value;
                    PropertyHasChanged("NGAYSD");
                }
            }
        }

        public Int32 NGAYHUY
        {
            get
            {
                CanReadProperty("NGAYHUY", true);
                return _nGAYHUY;
            }
            set
            {
                CanWriteProperty("NGAYHUY", true);
                if (_nGAYHUY != value)
                {
                    _nGAYHUY = value;
                    PropertyHasChanged("NGAYHUY");
                }
            }
        }

        public String NGUOIHUY
        {
            get
            {
                CanReadProperty("NGUOIHUY", true);
                return _nGUOIHUY;
            }
            set
            {
                CanWriteProperty("NGUOIHUY", true);
                if (_nGUOIHUY != value)
                {
                    _nGUOIHUY = value;
                    PropertyHasChanged("NGUOIHUY");
                }
            }
        }

        public String TENNGUOILAP
        {
            get
            {
                CanReadProperty("TENNGUOILAP", true);
                return _tENNGUOILAP;
            }
            set
            {
                CanWriteProperty("TENNGUOILAP", true);
                if (_tENNGUOILAP != value)
                {
                    _tENNGUOILAP = value;
                    PropertyHasChanged("TENNGUOILAP");
                }
            }
        }

        public String TENNGUOISD
        {
            get
            {
                CanReadProperty("TENNGUOISD", true);
                return _tENNGUOISD;
            }
            set
            {
                CanWriteProperty("TENNGUOISD", true);
                if (_tENNGUOISD != value)
                {
                    _tENNGUOISD = value;
                    PropertyHasChanged("TENNGUOISD");
                }
            }
        }

        public String TENNGUOIHUY
        {
            get
            {
                CanReadProperty("TENNGUOIHUY", true);
                return _tENNGUOIHUY;
            }
            set
            {
                CanWriteProperty("TENNGUOIHUY", true);
                if (_tENNGUOIHUY != value)
                {
                    _tENNGUOIHUY = value;
                    PropertyHasChanged("TENNGUOIHUY");
                }
            }
        }

        public String SOHD
        {
            get
            {
                CanReadProperty("SOHD", true);
                return _sOHD;
            }
            set
            {
                CanWriteProperty("SOHD", true);
                if (_sOHD != value)
                {
                    _sOHD = value;
                    PropertyHasChanged("SOHD");
                }
            }
        }

        public String SOSOHD
        {
            get
            {
                CanReadProperty("SOSOHD", true);
                return _sOSOHD;
            }
            set
            {
                CanWriteProperty("SOSOHD", true);
                if (_sOSOHD != value)
                {
                    _sOSOHD = value;
                    PropertyHasChanged("SOSOHD");
                }
            }
        }

        public Int32 TYGIA
        {
            get
            {
                CanReadProperty("TYGIA", true);
                return _tYGIA;
            }
            set
            {
                CanWriteProperty("TYGIA", true);
                if (_tYGIA != value)
                {
                    _tYGIA = value;
                    PropertyHasChanged("TYGIA");
                }
            }
        }


        public string GIACHENHLECH
        {
            get
            {
                CanReadProperty("GIACHENHLECH", true);
                if (_gIACHENHLECH == 0)
                    return "0";
                else
                    return _gIACHENHLECH.ToString("###,###");
            }
            set
            {
                CanWriteProperty("GIACHENHLECH", true);

                if (_gIACHENHLECH.ToString() != value)
                {
                    _gIACHENHLECH = decimal.Parse(value);
                    PropertyHasChanged("GIACHENHLECH");
                }
            }
        }
        public string  ThanhTien
        {
            get
            {
                CanReadProperty("ThanhTien", true);
                if ((_bHTINHTIEN != false) && (_tINHTIEN == false))
                {
                    _thanhTien = (_dONGIABH * (100 - _ck) * (_sOLUONG )) / (100)
                    + _gIACHENHLECH * (100 - _ck) * (_sOLUONG) / 100;
                }

                if ((_bHTINHTIEN == false) || (_tINHTIEN != false))
                    _thanhTien = _dONGIATT * (100 - _ck) * (_sOLUONG) / 100;

                return _thanhTien.ToString("###,###");
            }
            set
            {
                CanWriteProperty("ThanhTien", true);
                if (_thanhTien.ToString() != value)
                {
                   _thanhTien = decimal.Parse(value);
                    PropertyHasChanged("ThanhTien");
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
                CanWriteProperty("TENDVT", true);
                if (_tENDVT != value)
                {
                    _tENDVT = value;
                    PropertyHasChanged("TENDVT");
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
                CanWriteProperty("TENDT", true);
                if (_tENDT != value)
                {
                    _tENDT = value;
                    PropertyHasChanged("TENDT");
                }
            }
        }

        public Decimal BHTRA
        {
            get
            {
                CanReadProperty("BHTRA", true);
                return _bHTRA;
            }
            set
            {
                CanWriteProperty("BHTRA", true);
                if (_bHTRA != value)
                {
                    _bHTRA = value;
                    PropertyHasChanged("BHTRA");
                }
            }
        }

        public string NGAYVVTT
        {
            get
            {
                CanReadProperty("NGAYVVTT", true);
                return _nGAYVVTT.Text;
            }
            set
            {
                CanWriteProperty("NGAYVVTT", true);
                if (_nGAYVVTT.Text != value)
                {
                    _nGAYVVTT.Text = value;
                    PropertyHasChanged("NGAYVVTT");
                }
            }
        }

        public string NGAYKT
        {
            get
            {
                CanReadProperty("NGAYKT", true);
                return _nGAYKT.Text;
            }
            set
            {
                CanWriteProperty("NGAYKT", true);
                if (_nGAYKT.Text != value)
                {
                    _nGAYKT.Text = value;
                    PropertyHasChanged("NGAYKT");
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
            return _mASOKHAM ;
        }
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid;
            }
        }
        #endregion
   
        #endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
        protected internal BenhAn_GETsBCDICHVUInfo()
        {
            // Prevent direct creation
        }
        internal BenhAn_GETsBCDICHVUInfo(int OrderNumber,
  String madt, 
 Int32 sTTDT, 
 String mASOKHAM, 
 Int32 lOAIDV, 
 String maDV, 
 String tENDV, 
 Int32 sTT, 
 Decimal dONGIATT,
 Decimal dONGIABH, 
 Boolean aDGIAUSD, 
 Decimal sOLUONG,
 String mAKHOA,
 String bSKHAM, 
 Boolean tINHTIEN, 
 Boolean bHTINHTIEN, 
 Byte dATT,
 Decimal ck, 
 String tENKHOA,
 String tENBS, 
 Int32 nGAYYC, 
 Int32 nGAYLAP, 
 String nGUOILAP, 
 String nGUOISD, 
 Int32 nGAYSD, 
 Int32 nGAYHUY, 
 String nGUOIHUY, 
 String tENNGUOILAP, 
 String tENNGUOISD, 
 String tENNGUOIHUY, 
 String sOHD, 
 String sOSOHD, 
 Int32 tYGIA, 
 Decimal gIACHENHLECH, 
 String tENDVT,
 String tENDT, 
 Decimal bHTRA, 
 SmartDate nGAYVVTT, 
 SmartDate nGAYKT,string KQ)
        { 
  _OrderNumber = OrderNumber ;
  _madt = madt;
  _KQ = KQ;
  _sTTDT = sTTDT;
 _mASOKHAM= mASOKHAM; 
 _lOAIDV= lOAIDV; 
 _maDV = maDV; 
 _tENDV = tENDV; 
 _sTT =  sTT; 
_dONGIATT  =  dONGIATT;
 _dONGIABH = dONGIABH; 
 _aDGIAUSD = aDGIAUSD; 
 _sOLUONG = sOLUONG;
 _mAKHOA = mAKHOA;
 _bSKHAM = bSKHAM; 
 _tINHTIEN = tINHTIEN; 
 _bHTINHTIEN =  bHTINHTIEN; 
 _dATT = dATT;
 _ck= ck; 
 _tENKHOA =  tENKHOA;
 _tENBS = tENBS; 
 _nGAYYC = nGAYYC; 
 _nGAYLAP = nGAYLAP;
 _nGUOILAP = nGUOILAP;
 _nGUOISD =  nGUOISD;
 _nGAYSD =  nGAYSD;
 _nGAYHUY = nGAYHUY;
 _nGUOIHUY =  nGUOIHUY;
 _tENNGUOILAP = tENNGUOILAP;
 _tENNGUOISD =  tENNGUOISD;
 _tENNGUOIHUY =  tENNGUOIHUY;
 _sOHD =  sOHD;
 _sOSOHD = sOSOHD;
 _tYGIA = tYGIA;
 _gIACHENHLECH =  gIACHENHLECH;
 _tENDVT =  tENDVT;
 _tENDT =  tENDT;
 _bHTRA = bHTRA;
 _nGAYVVTT = nGAYVVTT;
 _nGAYKT = nGAYKT;

        }
		/// <summary>
		/// Factory method. New <see cref="BenhAn_GETsBCDICHVUInfo" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

      

		#endregion
	}

}
