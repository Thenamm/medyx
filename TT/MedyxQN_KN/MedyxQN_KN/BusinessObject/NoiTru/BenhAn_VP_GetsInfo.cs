// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_VP_GetsInfo
// Kieu doi tuong  :	BenhAn_VP_GetsInfo
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	4/1/2009 2:46:27 PM
// Nguoi tao       :	HCABXT
//
// *****************************************************************************************************

// TODO:
// 1. Kiem tra lai su dung dan cua cac ham DataProvider.Instance()
// 2. Viet them cac ham tuong ung trong file DataProvider.cs
// 3. Viet them cac ham tuong ung trong file SqlDataProvider.cs
// 4. Viet Stored Procedure tuong ung voi ca c ham can lay ra.
// *****************************************************************************************************
using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="BenhAn_VP_GetsInfo" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_VP_GetsInfo : BusinessBase<BenhAn_VP_GetsInfo>
	{
		#region Business Methods
		
		#region State Fields

        private Int32 _lOAIBN = 0;
        private Int32 _namsinh = 0;
        private String _mABA = String.Empty;
        private String _mAKHOA = String.Empty;
        private Int32 _sTTKHOA = 0;
        private String _mABN = String.Empty;
        private SmartDate _nGAYDK = new SmartDate(true);
        private String _mADV = String.Empty;
        private String _tENDV = String.Empty;
        private Decimal _tHUOC = 0;
        private Decimal _mAU = 0;
        private Decimal _xn = 0;
        private Decimal _cDHA = 0;
        private Decimal _dVKTTT = 0;
        private Decimal _dVKTC = 0;
        private Decimal _vTTH = 0;
        private Decimal _vCBN = 0;
        private Decimal _tDCN = 0;
        private Decimal _tHUOCTN = 0;
        private Decimal _mAUTN = 0;
        private Decimal _xNTN = 0;
        private Decimal _cDHATN = 0;
        private Decimal _dVKTTTTN = 0;
        private Decimal _dVKTCTN = 0;
        private Decimal _vTTHTN = 0;
        private Decimal _vCBNTN = 0;
        private Decimal _tDCNTN = 0;
        private Decimal _gIUONG = 0;
        private Decimal _gIUONGTN = 0;
        private Decimal _pHAUTHUAT = 0;
        private Decimal _pHAUTHUATTN = 0;
        private Decimal _DVTuNguyen = 0;
        private Boolean _gt = false;
        private String _sOTHE = String.Empty;
        private SmartDate _gIATRIDN = new SmartDate(true);
        private String _mABV = String.Empty;
        private String _mAICD = String.Empty;
        private String _KQDT = String.Empty;
        private String _sOPHIEUTTRV = String.Empty;
        private Decimal _bHTRA = 0;
        private Decimal _TongTien = 0;
        private Decimal _TongTienBH = 0;
        private Decimal _TongTienTT = 0;
        private Decimal _sOTIENMAX = 0;
        private int _OrderNumber;
        
		#endregion
		
		#region Business Properties and Methods
        public Int32 LOAIBN
        {
            get
            {
                CanReadProperty("LOAIBN", true);
                return _lOAIBN;
            }
            set
            {
                CanWriteProperty("LOAIBN", true);
                if (_lOAIBN != value)
                {
                    _lOAIBN = value;
                    PropertyHasChanged("LOAIBN");
                }
            }
        }

        public Int32 Namsinh
        {
            get
            {
                CanReadProperty("Namsinh", true);
                return _namsinh;
            }
            set
            {
                CanWriteProperty("Namsinh", true);
                if (_namsinh != value)
                {
                    _namsinh = value;
                    PropertyHasChanged("Namsinh");
                }
            }
        }

        public String MABA
        {
            get
            {
                CanReadProperty("MABA", true);
                return _mABA;
            }
            set
            {
                CanWriteProperty("MABA", true);
                if (_mABA != value)
                {
                    _mABA = value;
                    PropertyHasChanged("MABA");
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

        public Int32 STTKHOA
        {
            get
            {
                CanReadProperty("STTKHOA", true);
                return _sTTKHOA;
            }
            set
            {
                CanWriteProperty("STTKHOA", true);
                if (_sTTKHOA != value)
                {
                    _sTTKHOA = value;
                    PropertyHasChanged("STTKHOA");
                }
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
                CanWriteProperty("MABN", true);
                if (_mABN != value)
                {
                    _mABN = value;
                    PropertyHasChanged("MABN");
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
                CanWriteProperty("NGAYDK", true);
                if (_nGAYDK.Text != value)
                {
                    _nGAYDK.Text = value;
                    PropertyHasChanged("NGAYDK");
                }
            }
        }

        public String MADV
        {
            get
            {
                CanReadProperty("MADV", true);
                return _mADV;
            }
            set
            {
                CanWriteProperty("MADV", true);
                if (_mADV != value)
                {
                    _mADV = value;
                    PropertyHasChanged("MADV");
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

        public Decimal THUOC
        {
            get
            {
                CanReadProperty("THUOC", true);
                return _tHUOC;
            }
            set
            {
                CanWriteProperty("THUOC", true);
                if (_tHUOC != value)
                {
                    _tHUOC = value;
                    PropertyHasChanged("THUOC");
                }
            }
        }

        public Decimal MAU
        {
            get
            {
                CanReadProperty("MAU", true);
                return _mAU;
            }
            set
            {
                CanWriteProperty("MAU", true);
                if (_mAU != value)
                {
                    _mAU = value;
                    PropertyHasChanged("MAU");
                }
            }
        }

        public Decimal XN
        {
            get
            {
                CanReadProperty("XN", true);
                return _xn;
            }
            set
            {
                CanWriteProperty("XN", true);
                if (_xn != value)
                {
                    _xn = value;
                    PropertyHasChanged("XN");
                }
            }
        }

        public Decimal CDHA
        {
            get
            {
                CanReadProperty("CDHA", true);
                return _cDHA;
            }
            set
            {
                CanWriteProperty("CDHA", true);
                if (_cDHA != value)
                {
                    _cDHA = value;
                    PropertyHasChanged("CDHA");
                }
            }
        }

        public Decimal DVKTTT
        {
            get
            {
                CanReadProperty("DVKTTT", true);
                return _dVKTTT;
            }
            set
            {
                CanWriteProperty("DVKTTT", true);
                if (_dVKTTT != value)
                {
                    _dVKTTT = value;
                    PropertyHasChanged("DVKTTT");
                }
            }
        }

        public Decimal DVKTC
        {
            get
            {
                CanReadProperty("DVKTC", true);
                return _dVKTC;
            }
            set
            {
                CanWriteProperty("DVKTC", true);
                if (_dVKTC != value)
                {
                    _dVKTC = value;
                    PropertyHasChanged("DVKTC");
                }
            }
        }
        public Decimal DVTuNguyen
        {
            get
            {
                CanReadProperty("DVTuNguyen", true);
                return _DVTuNguyen;
            }
            set
            {
                CanWriteProperty("DVTuNguyen", true);
                if (_DVTuNguyen != value)
                {
                    _DVTuNguyen = value;
                    PropertyHasChanged("DVTuNguyen");
                }
            }
        }
        public Decimal VTTH
        {
            get
            {
                CanReadProperty("VTTH", true);
                return _vTTH;
            }
            set
            {
                CanWriteProperty("VTTH", true);
                if (_vTTH != value)
                {
                    _vTTH = value;
                    PropertyHasChanged("VTTH");
                }
            }
        }

        public Decimal VCBN
        {
            get
            {
                CanReadProperty("VCBN", true);
                return _vCBN;
            }
            set
            {
                CanWriteProperty("VCBN", true);
                if (_vCBN != value)
                {
                    _vCBN = value;
                    PropertyHasChanged("VCBN");
                }
            }
        }

        public Decimal TDCN
        {
            get
            {
                CanReadProperty("TDCN", true);
                return _tDCN;
            }
            set
            {
                CanWriteProperty("TDCN", true);
                if (_tDCN != value)
                {
                    _tDCN = value;
                    PropertyHasChanged("TDCN");
                }
            }
        }

        public Decimal THUOCTN
        {
            get
            {
                CanReadProperty("THUOCTN", true);
                return _tHUOCTN;
            }
            set
            {
                CanWriteProperty("THUOCTN", true);
                if (_tHUOCTN != value)
                {
                    _tHUOCTN = value;
                    PropertyHasChanged("THUOCTN");
                }
            }
        }

        public Decimal MAUTN
        {
            get
            {
                CanReadProperty("MAUTN", true);
                return _mAUTN;
            }
            set
            {
                CanWriteProperty("MAUTN", true);
                if (_mAUTN != value)
                {
                    _mAUTN = value;
                    PropertyHasChanged("MAUTN");
                }
            }
        }

        public Decimal XNTN
        {
            get
            {
                CanReadProperty("XNTN", true);
                return _xNTN;
            }
            set
            {
                CanWriteProperty("XNTN", true);
                if (_xNTN != value)
                {
                    _xNTN = value;
                    PropertyHasChanged("XNTN");
                }
            }
        }

        public Decimal CDHATN
        {
            get
            {
                CanReadProperty("CDHATN", true);
                return _cDHATN;
            }
            set
            {
                CanWriteProperty("CDHATN", true);
                if (_cDHATN != value)
                {
                    _cDHATN = value;
                    PropertyHasChanged("CDHATN");
                }
            }
        }

        public Decimal DVKTTTTN
        {
            get
            {
                CanReadProperty("DVKTTTTN", true);
                return _dVKTTTTN;
            }
            set
            {
                CanWriteProperty("DVKTTTTN", true);
                if (_dVKTTTTN != value)
                {
                    _dVKTTTTN = value;
                    PropertyHasChanged("DVKTTTTN");
                }
            }
        }

        public Decimal DVKTCTN
        {
            get
            {
                CanReadProperty("DVKTCTN", true);
                return _dVKTCTN;
            }
            set
            {
                CanWriteProperty("DVKTCTN", true);
                if (_dVKTCTN != value)
                {
                    _dVKTCTN = value;
                    PropertyHasChanged("DVKTCTN");
                }
            }
        }

        public Decimal VTTHTN
        {
            get
            {
                CanReadProperty("VTTHTN", true);
                return _vTTHTN;
            }
            set
            {
                CanWriteProperty("VTTHTN", true);
                if (_vTTHTN != value)
                {
                    _vTTHTN = value;
                    PropertyHasChanged("VTTHTN");
                }
            }
        }

        public Decimal VCBNTN
        {
            get
            {
                CanReadProperty("VCBNTN", true);
                return _vCBNTN;
            }
            set
            {
                CanWriteProperty("VCBNTN", true);
                if (_vCBNTN != value)
                {
                    _vCBNTN = value;
                    PropertyHasChanged("VCBNTN");
                }
            }
        }

        public Decimal TDCNTN
        {
            get
            {
                CanReadProperty("TDCNTN", true);
                return _tDCNTN;
            }
            set
            {
                CanWriteProperty("TDCNTN", true);
                if (_tDCNTN != value)
                {
                    _tDCNTN = value;
                    PropertyHasChanged("TDCNTN");
                }
            }
        }

        public Decimal GIUONG
        {
            get
            {
                CanReadProperty("GIUONG", true);
                return _gIUONG;
            }
            set
            {
                CanWriteProperty("GIUONG", true);
                if (_gIUONG != value)
                {
                    _gIUONG = value;
                    PropertyHasChanged("GIUONG");
                }
            }
        }

        public Decimal GIUONGTN
        {
            get
            {
                CanReadProperty("GIUONGTN", true);
                return _gIUONGTN;
            }
            set
            {
                CanWriteProperty("GIUONGTN", true);
                if (_gIUONGTN != value)
                {
                    _gIUONGTN = value;
                    PropertyHasChanged("GIUONGTN");
                }
            }
        }

        public Decimal PHAUTHUAT
        {
            get
            {
                CanReadProperty("PHAUTHUAT", true);
                return _pHAUTHUAT;
            }
            set
            {
                CanWriteProperty("PHAUTHUAT", true);
                if (_pHAUTHUAT != value)
                {
                    _pHAUTHUAT = value;
                    PropertyHasChanged("PHAUTHUAT");
                }
            }
        }

        public Decimal PHAUTHUATTN
        {
            get
            {
                CanReadProperty("PHAUTHUATTN", true);
                return _pHAUTHUATTN;
            }
            set
            {
                CanWriteProperty("PHAUTHUATTN", true);
                if (_pHAUTHUATTN != value)
                {
                    _pHAUTHUATTN = value;
                    PropertyHasChanged("PHAUTHUATTN");
                }
            }
        }

        public Boolean GT
        {
            get
            {
                CanReadProperty("GT", true);
                return _gt;
            }
            set
            {
                CanWriteProperty("GT", true);
                if (_gt != value)
                {
                    _gt = value;
                    PropertyHasChanged("GT");
                }
            }
        }

        public String SOTHE
        {
            get
            {
                CanReadProperty("SOTHE", true);
                return _sOTHE;
            }
            set
            {
                CanWriteProperty("SOTHE", true);
                if (_sOTHE != value)
                {
                    _sOTHE = value;
                    PropertyHasChanged("SOTHE");
                }
            }
        }

        public string GIATRIDN
        {
            get
            {
                CanReadProperty("GIATRIDN", true);
                return _gIATRIDN.Text;
            }
            set
            {
                CanWriteProperty("GIATRIDN", true);
                if (_gIATRIDN.Text != value)
                {
                    _gIATRIDN.Text = value;
                    PropertyHasChanged("GIATRIDN");
                }
            }
        }

        public String MABV
        {
            get
            {
                CanReadProperty("MABV", true);
                return _mABV;
            }
            set
            {
                CanWriteProperty("MABV", true);
                if (_mABV != value)
                {
                    _mABV = value;
                    PropertyHasChanged("MABV");
                }
            }
        }

        public String MAICD
        {
            get
            {
                CanReadProperty("MAICD", true);
                return _mAICD;
            }
            set
            {
                CanWriteProperty("MAICD", true);
                if (_mAICD != value)
                {
                    _mAICD = value;
                    PropertyHasChanged("MAICD");
                }
            }
        }

        public String SOPHIEUTTRV
        {
            get
            {
                CanReadProperty("SOPHIEUTTRV", true);
                return _sOPHIEUTTRV;
            }
            set
            {
                CanWriteProperty("SOPHIEUTTRV", true);
                if (_sOPHIEUTTRV != value)
                {
                    _sOPHIEUTTRV = value;
                    PropertyHasChanged("SOPHIEUTTRV");
                }
            }
        }
        public String KQDT
        {
            get
            {
                CanReadProperty("KQDT", true);
                return _KQDT;
            }
            set
            {
                CanWriteProperty("KQDT", true);
                if (_KQDT != value)
                {
                    _KQDT = value;
                    PropertyHasChanged("KQDT");
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
        public Decimal TongTien
        {
            get
            {
                CanReadProperty("TongTien", true);
                return _TongTien ;
            }
            set
            {
                CanWriteProperty("TongTien", true);
                if (_TongTien != value)
                {
                    _TongTien = value;
                    PropertyHasChanged("TongTien");
                }
            }
        }
        public Decimal TongTienBH
        {
            get
            {
                CanReadProperty("TongTienBH", true);
                return _TongTienBH;
            }
            set
            {
                CanWriteProperty("TongTienBH", true);
                if (_TongTienBH != value)
                {
                    _TongTienBH = value;
                    PropertyHasChanged("TongTienBH");
                }
            }
        }
        public Decimal TongTienTT
        {
            get
            {
                CanReadProperty("TongTienTT", true);
                return _TongTienTT;
            }
            set
            {
                CanWriteProperty("TongTienTT", true);
                if (_TongTienTT != value)
                {
                    _TongTienTT = value;
                    PropertyHasChanged("TongTienTT");
                }
            }
        }
        public Decimal SOTIENMAX
        {
            get
            {
                CanReadProperty("SOTIENMAX", true);
                return _sOTIENMAX;
            }
            set
            {
                CanWriteProperty("SOTIENMAX", true);
                if (_sOTIENMAX != value)
                {
                    _sOTIENMAX = value;
                    PropertyHasChanged("SOTIENMAX");
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
			return _mABA ;
		}
		#endregion
		#endregion


        #region Factory Methods




        public static BenhAn_VP_GetsInfo GetAllBenhAn_VP_GetsInfo(string _maba, Byte _datt)
        {
            return DataPortal.Fetch<BenhAn_VP_GetsInfo>(new Criteria(_maba, _datt, ""));
        }

        /// <summary>
        /// Marks the <see cref="DMKho" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
      
        #endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		

        protected internal BenhAn_VP_GetsInfo()
        {
            // Prevent direct creation
        }

        internal BenhAn_VP_GetsInfo(int OrderNumber,
  Int32 lOAIBN,
         Int32 namsinh,
         String mABA,
         String mAKHOA,
         Int32 sTTKHOA,
         String mABN,
         SmartDate nGAYDK,
         String mADV,
         String tENDV,
         Decimal tHUOC,
         Decimal mAU,
         Decimal xn,
         Decimal cDHA,
         Decimal dVKTTT,
         Decimal dVKTC,
         Decimal vTTH,
         Decimal vCBN,
         Decimal tDCN,
         Decimal tHUOCTN,
         Decimal mAUTN,
         Decimal xNTN,
         Decimal cDHATN,
         Decimal dVKTTTTN,
         Decimal dVKTCTN,
         Decimal vTTHTN,
         Decimal vCBNTN,
         Decimal tDCNTN,
         Decimal gIUONG,
         Decimal gIUONGTN,
         Decimal pHAUTHUAT,
         Decimal pHAUTHUATTN,
         Boolean gt,
         String sOTHE,
         SmartDate gIATRIDN,
         String mABV,
         String mAICD,
         String sOPHIEUTTRV,
         Decimal bHTRA,
         Decimal sOTIENMAX,
            String KQDT,
           Decimal DVTuNguyen,
           Decimal tongtien
            )
        {
            _OrderNumber = OrderNumber;
            _lOAIBN = lOAIBN;
            _DVTuNguyen = DVTuNguyen;
            _namsinh = namsinh;
            _mABA = mABA;
            _mAKHOA = mAKHOA;
            _sTTKHOA = sTTKHOA;
            _mABN = mABN;
            _nGAYDK = nGAYDK;
            _mADV = mADV;
            _tENDV = tENDV;
            _tHUOC = tHUOC;
            _mAU = mAU;
            _xn = xn;
            _cDHA = cDHA;
            _dVKTTT = dVKTTT;
            _dVKTC = dVKTC;
            _vTTH = vTTH;
            _vCBN = vCBN;
            _tDCN = tDCN;
            _tHUOCTN = tHUOCTN;
            _mAUTN = mAUTN;
            _xNTN = xNTN;
            _cDHATN = cDHATN;
            _dVKTTTTN = dVKTTTTN;
            _dVKTCTN = dVKTCTN;
            _vTTHTN = vTTHTN;
            _vCBNTN = vCBNTN;
            _tDCNTN = tDCNTN;
            _gIUONG = gIUONG;
            _gIUONGTN = gIUONGTN;
            _pHAUTHUAT = pHAUTHUAT;
            _pHAUTHUATTN = pHAUTHUATTN;
            _gt = gt;
            _sOTHE = sOTHE;
            _gIATRIDN = gIATRIDN;
            _mABV = mABV;
            _mAICD = mAICD;
            _sOPHIEUTTRV = sOPHIEUTTRV;
            _bHTRA = bHTRA;
            _sOTIENMAX = sOTIENMAX;
            _KQDT = KQDT;
            _TongTien = tongtien;

        }
		#endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {

            private string _maba;
             private Boolean _qadmin = false ;

            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private String _DK;
            public String DK
            {
                get
                {
                    return _DK;
                }
            }

            private Byte _DaTT;
            public Byte DaTT
            {
                get
                {
                    return _DaTT;
                }
            }

            public string maba
            {
                get
                {
                    return _maba;
                }
            }


            public Criteria(string maba, Byte datt, string dk)
            {

                _DK = dk;
                _DaTT = datt;

                _maba = maba;

            }
        }



        private void DataPortal_Fetch(Criteria criteria)
        {

            
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_VP_GetsInfo (criteria.maba, criteria.DaTT, criteria.DK)))
            {
                if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="DMKho" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
     
            //                                 dr.GetInt32("LOAIBN"),
            // dr.GetInt32("Namsinh"),
            // dr.GetString("MABA"),
            // dr.GetString("MAKHOA"),
            //dr.GetInt32("STTKHOA"),
            // dr.GetString("MABN"),
            // dr.GetSmartDate("NGAYDK", true),
            // dr.GetString("MADV"),
            // dr.GetString("TENDV"),
            // dr.GetDecimal("THUOC"),
            // dr.GetDecimal("MAU"),
            // dr.GetDecimal("XN"),
            // dr.GetDecimal("CDHA"),
            // dr.GetDecimal("DVKTTT"),
            // dr.GetDecimal("DVKTC"),
            // dr.GetDecimal("VTTH"),
            // dr.GetDecimal("VCBN"),
            // dr.GetDecimal("TDCN"),
            // dr.GetDecimal("THUOCTN"),
            // dr.GetDecimal("MAUTN"),
            // dr.GetDecimal("XNTN"),
            // dr.GetDecimal("CDHATN"),
            // dr.GetDecimal("DVKTTTTN"),
            // dr.GetDecimal("DVKTCTN"),
            // dr.GetDecimal("VTTHTN"),
            // dr.GetDecimal("VCBNTN"),
            // dr.GetDecimal("TDCNTN"),
            // dr.GetDecimal("GIUONG"),
            // dr.GetDecimal("GIUONGTN"),
            // dr.GetDecimal("PHAUTHUAT"),
            // dr.GetDecimal("PHAUTHUATTN"),
            // dr.GetBoolean("GT"),
            //           dr.GetString("SOTHE"),
            // dr.GetSmartDate("GIATRIDN", true),
            // dr.GetString("MABV"),
            // dr.GetString("MAICD"),
            // dr.GetString("SOPHIEUTTRV"),
            // dr.GetDecimal("BHTRA"),
            // dr.GetDecimal("SOTIENMAX"),
            //          dr.GetString("KQDT"));
            if (dr.GetInt32("LOAIBN") != null) _lOAIBN = dr.GetInt32("LOAIBN");
            if (dr.GetInt32("Namsinh") != null) _namsinh = dr.GetInt32("Namsinh");
            if (dr.GetString("MABA") != null) _mABA = dr.GetString("MABA");
            if (dr.GetString("MAKHOA") != null) _mAKHOA = dr.GetString("MAKHOA");
            if (dr.GetInt32("STTKHOA") != null) _sTTKHOA = dr.GetInt32("STTKHOA");
            if (dr.GetString("MABN") != null) _mABN = dr.GetString("MABN");
            if (dr.GetSmartDate("NGAYDK", true) != null) _nGAYDK = dr.GetSmartDate("NGAYDK", true);
            if (dr.GetString("MADV") != null) _mADV = dr.GetString("MADV");
            if (dr.GetString("TENDV") != null) _tENDV = dr.GetString("TENDV");
            if (dr.GetDecimal("THUOC") != null) _tHUOC = dr.GetDecimal("THUOC");
            if (dr.GetDecimal("MAU") != null) _mAU = dr.GetDecimal("MAU");
            if (dr.GetDecimal("XN") != null) _xn = dr.GetDecimal("XN");
            if (dr.GetDecimal("DVTuNguyen") != null) _DVTuNguyen = dr.GetDecimal("DVTuNguyen");
            if (dr.GetDecimal("CDHA") != null) _cDHA = dr.GetDecimal("CDHA");
            if (dr.GetDecimal("DVKTTT") != null) _dVKTTT = dr.GetDecimal("DVKTTT");
            if (dr.GetDecimal("DVKTC") != null) _dVKTC = dr.GetDecimal("DVKTC");
            if (dr.GetDecimal("VTTH") != null) _vTTH = dr.GetDecimal("VTTH");
            if (dr.GetDecimal("VCBN") != null) _vCBN = dr.GetDecimal("VCBN");
            if (dr.GetDecimal("TDCN") != null) _tDCN = dr.GetDecimal("TDCN");
            if (dr.GetDecimal("THUOCTN") != null) _tHUOCTN = dr.GetDecimal("THUOCTN");
            if (dr.GetDecimal("MAUTN") != null) _mAUTN = dr.GetDecimal("MAUTN");
            if (dr.GetDecimal("XNTN") != null) _xNTN = dr.GetDecimal("XNTN");
            if (dr.GetDecimal("CDHATN") != null) _cDHATN = dr.GetDecimal("CDHATN");
            if (dr.GetDecimal("DVKTTTTN") != null) _dVKTTTTN = dr.GetDecimal("DVKTTTTN");
            if (dr.GetDecimal("DVKTCTN") != null) _dVKTCTN = dr.GetDecimal("DVKTCTN");
            if (dr.GetDecimal("VTTHTN") != null) _vTTHTN = dr.GetDecimal("VTTHTN");
            if (dr.GetDecimal("VCBNTN") != null) _vCBNTN = dr.GetDecimal("VCBNTN");
            if (dr.GetDecimal("TDCNTN") != null) _tDCNTN = dr.GetDecimal("TDCNTN");
            if (dr.GetDecimal("GIUONG") != null) _gIUONG = dr.GetDecimal("GIUONG");
            if (dr.GetDecimal("GIUONGTN") != null) _gIUONGTN = dr.GetDecimal("GIUONGTN");
            if (dr.GetDecimal("PHAUTHUAT") != null) _pHAUTHUAT = dr.GetDecimal("PHAUTHUAT");
            if (dr.GetDecimal("PHAUTHUATTN") != null) _pHAUTHUATTN = dr.GetDecimal("PHAUTHUATTN");
            if (dr.GetBoolean("GT") != null) _gt = dr.GetBoolean("GT");
            if (dr.GetString("SOTHE") != null) _sOTHE = dr.GetString("SOTHE");
            if (dr.GetSmartDate("GIATRIDN", true) != null) _gIATRIDN = dr.GetSmartDate("GIATRIDN", true);
            if (dr.GetString("MABV") != null) _mABV = dr.GetString("MABV");
            if (dr.GetString("kqdt") != null) _KQDT  = dr.GetString("kqdt");
            if (dr.GetString("MAICD") != null) _mAICD = dr.GetString("MAICD");
            if (dr.GetString("SOPHIEUTTRV") != null) _sOPHIEUTTRV = dr.GetString("SOPHIEUTTRV");
            if (dr.GetDecimal("BHTRA") != null) _bHTRA = dr.GetDecimal("BHTRA");
            if (dr.GetDecimal("SOTIENMAX") != null) _sOTIENMAX = dr.GetDecimal("SOTIENMAX");
            if (dr.GetDecimal("TongTien") != null) _TongTien = dr.GetDecimal("TongTien");
        }


        #endregion
	}

}
