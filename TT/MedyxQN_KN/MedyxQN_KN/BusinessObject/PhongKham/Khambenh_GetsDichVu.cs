using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;


namespace HTC.Business.PhongKham
{
    [Serializable()]
    public partial class KhamBenh_GetsDichVu : BusinessBase<KhamBenh_GetsDichVu>
    {
        #region Business Methods

        #region State Fields

        private Int32  _lOAIDV = 0;
        private String _maDV = String.Empty;
        private String _MaSoKham = String.Empty;
        private String _tENDV = String.Empty;
        private Int32 _SoTT = 0;
        private Decimal _dONGIATT = 0;
        private Decimal _dONGIABH = 0;
        private Boolean _aDGIAUSD = false;
        private Decimal _giaChenhLech = 0;
        private Decimal _SLMua = 0;
        private Decimal _SLTra = 0;
        private Decimal _SLTTe = 0;
        private String _mAKHOA = String.Empty;
        private String _bSKHAM = String.Empty;
        private Boolean _tINHTIEN = false;
        private Boolean _bHTinhTien = false;
        private SmartDate _ngayGioKham = new SmartDate(true);
        private Byte _dATT = 0;
        private Decimal _ck = 0;
        private String _tENKHOA = String.Empty;
        private String _tENBS = String.Empty;
        private SmartDate _nGAYYC = new SmartDate(true);
        private SmartDate _nGAYLAP = new SmartDate(true);
        private String _nGUOILAP = String.Empty;
        private String _nGUOISD = String.Empty;
        private SmartDate _nGAYSD = new SmartDate(true);
        private SmartDate _nGAYHUY = new SmartDate(true);
        private String _nGUOIHUY = String.Empty;
        private String _tENNGUOILAP = String.Empty;
        private String _tENNGUOISD = String.Empty;
        private String _tENNGUOIHUY = String.Empty;
        private int _OrderNumber;
        private String _soHD = String.Empty;
        private String _soSoHD = String.Empty;
        private Decimal _thanhtien = 0;
        private Decimal _thanhtienBH = 0;
        private String _soHDTra = String.Empty;
        private String _soSoHDTra = String.Empty;
        private String _tentat = String.Empty;
        private Boolean _inthu = false;
        private Boolean _DuyetBH = false;
     
        #endregion

        #region Business Properties and Methods
        public String tentat
        {
            get
            {
                CanReadProperty("tentat", true);
                return _tentat;
            }
            set
            {
                CanWriteProperty("tentat", true);
                if (_tentat != value)
                {
                    _tentat = value;
                    PropertyHasChanged("tentat");
                }
            }
        }
        public Boolean inthu
        {
            get
            {
                CanReadProperty("inthu", true);
                return _inthu;
            }
            set
            {
                CanWriteProperty("inthu", true);
                if (_inthu != value)
                {
                    _inthu = value;
                    PropertyHasChanged("inthu");
                }
            }
        }
        public Boolean DuyetBH
        {
            get
            {
                CanReadProperty("DuyetBH", true);
                return _DuyetBH;
            }
            set
            {
                CanWriteProperty("DuyetBH", true);
                if (_DuyetBH != value)
                {
                    _DuyetBH = value;
                    PropertyHasChanged("DuyetBH");
                }
            }
        }
        public Boolean MG
        {
            get
            {
               if(_ck !=0 &&_ck !=null)
                return true;
               else
                   return false;
            }
        }
        public string NgayGioKham
        {
            get
            {
                CanReadProperty("NgayGioKham", true);
                return _ngayGioKham.Text;
            }
            set
            {
                CanWriteProperty("NgayGioKham", true);
                if (_ngayGioKham.Text != value)
                {
                    _ngayGioKham.Text = value;
                    PropertyHasChanged("NgayGioKham");
                }
            }
        }
        public string GiaChenhLech
        {
            get
            {
                CanReadProperty("GiaChenhLech", true);
                if (_giaChenhLech == 0)
                    return "0";
                else
                return _giaChenhLech.ToString("###,####") ;
            }
            set
            {
                CanWriteProperty("GiaChenhLech", true);
                if (_giaChenhLech.ToString()  != value)
                {
                    _giaChenhLech = decimal.Parse (value);
                    PropertyHasChanged("GiaChenhLech");
                }
            }
        }
        public String SoHDTra
        {
            get
            {
                CanReadProperty("SoHDTra", true);
                return _soHDTra;
            }
            set
            {
                CanWriteProperty("SoHDTra", true);
                if (_soHDTra != value)
                {
                    _soHDTra = value;
                    PropertyHasChanged("SoHDTra");
                }
            }
        }

        public String SoSoHDTra
        {
            get
            {
                CanReadProperty("SoSoHDTra", true);
                return _soSoHDTra;
            }
            set
            {
                CanWriteProperty("SoSoHDTra", true);
                if (_soSoHDTra != value)
                {
                    _soSoHDTra = value;
                    PropertyHasChanged("SoSoHDTra");
                }
            }
        }
        public string thanhtien
        {
            get
            {
                CanReadProperty("thanhtien", true);
                if ((_bHTinhTien != false) && (_tINHTIEN == false))
                {
                    _thanhtien = //(_dONGIABH * (100 - _ck)* (_soLuong)) / (100 )
                     _giaChenhLech * (100 - _ck) * (_SLMua-_SLTra)/ 100 ;
                }

                if ((_bHTinhTien == false) || (_tINHTIEN != false))
                    _thanhtien = _dONGIATT * (100 - _ck) * (_SLMua - _SLTra) / 100;
               
                return _thanhtien.ToString("###,###") ;
            }
            set
            {
                CanWriteProperty("thanhtien", true);
                if (_thanhtien.ToString()  != value)
                {
                    _thanhtien = decimal.Parse(value);
                    PropertyHasChanged("thanhtien");
                }
            }
        }
        public string thanhtienBH
        {
            get
            {
                CanReadProperty("thanhtienBH", true);
                if ((_bHTinhTien != false) && (_tINHTIEN == false))
                {
                    //_thanhtienBH = (_dONGIABH * (100 - _ck) * (_soLuong)) / (100)
                    //+ _giaChenhLech * (100 - _ck) * (_soLuong) / 100;
                    _thanhtienBH = (_dONGIABH * (100 - _ck) * (_SLMua - _SLTra)) / (100);
                    
                }

               
                return _thanhtienBH.ToString("###,###");
            }
            set
            {
                CanWriteProperty("thanhtienBH", true);
                if (_thanhtienBH.ToString() != value)
                {
                    _thanhtienBH = decimal.Parse(value);
                    PropertyHasChanged("thanhtienBH");
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
        public String SoHD
        {
            get
            {
                CanReadProperty("SoHD", true);
                return _soHD;
            }
            set
            {
                CanWriteProperty("SoHD", true);
                if (_soHD != value)
                {
                    _soHD = value;
                    PropertyHasChanged("SoHD");
                }
            }
        }

        public String SoSoHD
        {
            get
            {
                CanReadProperty("SoSoHD", true);
                return _soSoHD;
            }
            set
            {
                CanWriteProperty("SoSoHD", true);
                if (_soSoHD != value)
                {
                    _soSoHD = value;
                    PropertyHasChanged("SoSoHD");
                }
            }
        }
        public String MaSoKham
        {
            get
            {
                CanReadProperty("MaSoKham", true);
                return _MaSoKham;
            }
            set
            {
                CanWriteProperty("MaSoKham", true);
                if (_MaSoKham != value)
                {
                    _MaSoKham = value;
                    PropertyHasChanged("MaSoKham");
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

        public Int32  SoTT
        {
            get
            {
                CanReadProperty("SoTT", true);
                return _SoTT;
            }
            set
            {
                CanWriteProperty("SoTT", true);
                if (_SoTT != value)
                {
                    _SoTT = value;
                    PropertyHasChanged("SoTT");
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

        public string  DONGIABH
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
                if (_dONGIABH.ToString()  != value)
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

        public string SLMua
        {
            get
            {
                CanReadProperty("SLMua", true);
                if (_SLMua == 0)
                    return "0";
                else if (_SLMua - (int)(_SLMua) != 0)
                    return _SLMua.ToString("###,###.###");
                else

                    return _SLMua.ToString("###,###");
            }
            set
            {
                CanWriteProperty("SLMua", true);
                if (_SLMua.ToString() != value)
                {
                    _SLMua = decimal.Parse(value);
                    PropertyHasChanged("SLMua");
                }
            }
        }
        public string SLTra
        {
            get
            {
                CanReadProperty("SLTra", true);
                if (_SLTra == 0)
                    return "0";
                else if (_SLTra - (int)(_SLTra) != 0)
                    return _SLTra.ToString("###,###.###");
                else

                    return _SLTra.ToString("###,###");
            }
            set
            {
                CanWriteProperty("SLTra", true);
                if (_SLTra.ToString() != value)
                {
                    _SLTra = decimal.Parse(value);
                    PropertyHasChanged("SLTra");
                }
            }
        }
        public string SLTTe
        {

            get
            {
                 if (_SLMua- _SLTra == 0)
                    return "0";
                 else if (_SLMua - _SLTra - (int)(_SLMua - _SLTra) != 0)
                     return (_SLMua - _SLTra).ToString("###,###.###");
                else

                    return (_SLMua- _SLTra).ToString("###,###");
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

        public Boolean Tinhtien
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

        public Boolean BHTinhtien
        {
            get
            {
                CanReadProperty("BHTINHTIEN", true);
                return _bHTinhTien;
            }
            set
            {
                CanWriteProperty("BHTINHTIEN", true);
                if (_bHTinhTien != value)
                {
                    _bHTinhTien = value;
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

        public string CK
        {
            get
            {
                CanReadProperty("CK", true);
                if (_ck == 0)
                    return "0";
                else
                return _ck.ToString("###,###");
            }
            set
            {
                CanWriteProperty("CK", true);
                if (_ck.ToString()  != value)
                {
                    _ck = decimal.Parse(value);
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

        public string NGAYYC
        {
            get
            {
                CanReadProperty("NGAYYC", true);
                return _nGAYYC.Text;
            }
            set
            {
                CanWriteProperty("NGAYYC", true);
                if (_nGAYYC.Text != value)
                {
                    _nGAYYC.Text = value;
                    PropertyHasChanged("NGAYYC");
                }
            }
        }

        //public string NGAYLAP
        //{
        //    get
        //    {
        //        CanReadProperty("NGAYLAP", true);
        //        return _nGAYLAP.Text;
        //    }
        //    set
        //    {
        //        CanWriteProperty("NGAYLAP", true);
        //        if (_nGAYLAP.Text != value)
        //        {
        //            _nGAYLAP.Text = value;
        //            PropertyHasChanged("NGAYLAP");
        //        }
        //    }
        //}

        //public String NGUOILAP
        //{
        //    get
        //    {
        //        CanReadProperty("NGUOILAP", true);
        //        return _nGUOILAP;
        //    }
        //    set
        //    {
        //        CanWriteProperty("NGUOILAP", true);
        //        if (_nGUOILAP != value)
        //        {
        //            _nGUOILAP = value;
        //            PropertyHasChanged("NGUOILAP");
        //        }
        //    }
        //}

        //public String NGUOISD
        //{
        //    get
        //    {
        //        CanReadProperty("NGUOISD", true);
        //        return _nGUOISD;
        //    }
        //    set
        //    {
        //        CanWriteProperty("NGUOISD", true);
        //        if (_nGUOISD != value)
        //        {
        //            _nGUOISD = value;
        //            PropertyHasChanged("NGUOISD");
        //        }
        //    }
        //}

        //public string NGAYSD
        //{
        //    get
        //    {
        //        CanReadProperty("NGAYSD", true);
        //        return _nGAYSD.Text;
        //    }
        //    set
        //    {
        //        CanWriteProperty("NGAYSD", true);
        //        if (_nGAYSD.Text != value)
        //        {
        //            _nGAYSD.Text = value;
        //            PropertyHasChanged("NGAYSD");
        //        }
        //    }
        //}

        //public string NGAYHUY
        //{
        //    get
        //    {
        //        CanReadProperty("NGAYHUY", true);
        //        return _nGAYHUY.Text;
        //    }
        //    set
        //    {
        //        CanWriteProperty("NGAYHUY", true);
        //        if (_nGAYHUY.Text != value)
        //        {
        //            _nGAYHUY.Text = value;
        //            PropertyHasChanged("NGAYHUY");
        //        }
        //    }
        //}
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
        protected override Object GetIdValue()
        {
            return _OrderNumber;
        }
        #endregion
        #endregion
                      
		#region Business Object Rules and Validation

       
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="KhamBenh_GetsDichVu" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static KhamBenh_GetsDichVu NewKhamBenh_GetsDichVu()
        {
            return new KhamBenh_GetsDichVu();
           
        }
       public static KhamBenh_GetsDichVu NewKhamBenh_GetsDichVu(KhamBenh_C _KhamBenh_C)
        {
            return new KhamBenh_GetsDichVu(_KhamBenh_C);
         
        }
        public static KhamBenh_GetsDichVu GetKhamBenh_GetsDichVu(String _MaSoKham, Int32 _SoTT, Byte _Loai)
        {
            return DataPortal.Fetch<KhamBenh_GetsDichVu>(new Criteria(_MaSoKham, _SoTT,_Loai ));
        }
        
        
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public-++++ !!!
        protected internal KhamBenh_GetsDichVu()
        {
            // Prevent direct creation
        }
        internal KhamBenh_GetsDichVu(
            String MaSoKham,
            Int32  lOAIDV,
         String maDV,
         String tENDV,
         Int32 SoTT,
         Decimal dONGIATT,
         Decimal dONGIABH,
         Boolean aDGIAUSD,
         Decimal slmua,
            Decimal sltra,
         String mAKHOA,
         String bSKHAM,
         Boolean Tinhtien,
         Boolean BHTinhtien,
         Byte dATT,
         Decimal ck,
         String tENKHOA,
         String tENBS,
         SmartDate nGAYYC,
         SmartDate nGAYLAP,
         String nGUOILAP,
         String nGUOISD,
         SmartDate nGAYSD,
         SmartDate nGAYHUY,
         String nGUOIHUY,
         String tENNGUOILAP,
         String tENNGUOISD,
         String tENNGUOIHUY,
         int OrderNumber,
         string sosohd,
         string sohd,
         Decimal giachenhlech,
         SmartDate ngaygiokham,
            string tentat,
           Boolean inthu ,
           Boolean duyetbh)
        {
            _MaSoKham = MaSoKham;
            _tentat = tentat;
            _inthu = inthu;
            _DuyetBH = duyetbh;
            _lOAIDV = lOAIDV;
            _maDV = maDV;
            _tENDV = tENDV;
            _SoTT = SoTT;
            _dONGIATT = dONGIATT;
            _dONGIABH = dONGIABH;
            _aDGIAUSD = aDGIAUSD;
            _SLMua = slmua ;
            _SLTra = sltra;
            _mAKHOA = mAKHOA;
            _bSKHAM = bSKHAM;
            _tINHTIEN = Tinhtien;
            _ngayGioKham = ngaygiokham;
            _bHTinhTien = BHTinhtien;
            _dATT = dATT;
            _ck = ck;
            _tENKHOA = tENKHOA;
            _tENBS = tENBS;
            _nGAYYC = nGAYYC;
            _nGAYLAP = nGAYLAP;
            _nGUOILAP = nGUOILAP;
            _nGUOISD = nGUOISD;
            _nGAYSD = nGAYSD;
            _nGAYHUY = nGAYHUY;
            _nGUOIHUY = nGUOIHUY;
            _tENNGUOILAP = tENNGUOILAP;
            _tENNGUOISD = tENNGUOISD;
            _tENNGUOIHUY = tENNGUOIHUY;
            _OrderNumber = OrderNumber;
            _soHD = sohd;
            _soSoHD = sosohd;
            _giaChenhLech = giachenhlech ;
        }



        protected KhamBenh_GetsDichVu(KhamBenh_C pro)
        {
            MarkAsChild();

            // day so lieu 1 dich vu de hien thi len
        }
        
       
		#endregion

		#region Criteria
         	
        [Serializable()]
        protected class Criteria
        {
            private String _MaSoKham;
            public String MaSoKham 
            {
                get
                {
                    return _MaSoKham;
                }
            }
            private Int32 _SoTT;
            public Int32 SoTT
            {
                get
                {
                    return _SoTT;
                }
            }
            private Byte _Loai;
            public Byte Loai
            {
                get
                {
                    return _Loai;
                }
            }
            private Byte _loaikqcn;
            public Byte loaikqcn
            {
                get
                {
                    return _loaikqcn;
                }
            }
            public Criteria(String MaSoKham, Int32 SoTT, Byte Loai)
            {
                _MaSoKham = MaSoKham;
                _SoTT = SoTT;
                _Loai = Loai;
                
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_MaSoKham.Equals(c._MaSoKham))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _MaSoKham.ToString()).GetHashCode();
            }
        }
       
           
       
		 
		#endregion
		
		#region Authorization

		public static bool CanGetObject()
		{
			return true;
		}
		
		public static bool CanDeleteObject()
		{
			return true;
		}

		public static bool CanAddObject()
		{
			return true;
		}

		public static bool CanEditObject()
		{
			return true;
		}
		
		#endregion

		#region Data Access

		/// <summary>
		/// Retrieve an existing <see cref="KhamBenh_GetsDichVu" /> Object based on data in the database.
		/// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
           
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKhamBenh_GetsDichVu(crit.MaSoKham , crit.SoTT,crit.Loai    )))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    MarkOld();
                    ValidationRules.CheckRules();
                }
            }
        }
		/// <summary>
		/// Load a <see cref="KhamBenh_GetsDichVu" /> Object from given SafeDataReader.
		/// </summary>
        private void Fetch(SafeDataReader dr)//lay o chi tiet thu tuc spKhamBenh_GetsDichVu_Get
        {
            // Value properties
            try
            {
                if (dr.GetInt32("LOAIDV") != null) _lOAIDV = dr.GetInt32("LOAIDV");
                if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
                if (dr.GetString("tentat") != null) _tentat = dr.GetString("tentat");
                if (dr.GetBoolean("inthu") != null) _inthu = dr.GetBoolean("inthu");
              
                if (dr.GetString("TENDV") != null) _tENDV = dr.GetString("TENDV");
                if (dr.GetInt32("STT") != null) _SoTT = dr.GetInt32("STT");
                if (dr.GetDecimal("DONGIATT") != null) _dONGIATT = dr.GetDecimal("DONGIATT");
                if (dr.GetDecimal("DONGIABH") != null) _dONGIABH = dr.GetDecimal("DONGIABH");
                if (dr.GetBoolean("ADGIAUSD") != null) _aDGIAUSD = dr.GetBoolean("ADGIAUSD");
                if (dr.GetDecimal("SoLuong") != null) _SLMua = dr.GetDecimal("SoLuong");
                if (dr.GetDecimal("giachenhlech") != null) _giaChenhLech = dr.GetDecimal("giachenhlech");
                if (dr.GetString("MAKHOA") != null) _mAKHOA = dr.GetString("MAKHOA");
                if (dr.GetString("BSKHAM") != null) _bSKHAM = dr.GetString("BSKHAM");
                if (dr.GetBoolean("Tinhtien") != null) _tINHTIEN = dr.GetBoolean("Tinhtien");
                if (dr.GetBoolean("BHTinhtien") != null) _bHTinhTien = dr.GetBoolean("BHTinhtien");
                if (dr.GetByte("DATT") != null) _dATT = dr.GetByte("DATT");
                if (dr.GetSmartDate("NgayGioKham", true) != null) _ngayGioKham = dr.GetSmartDate("NgayGioKham", true);
			
                if (dr.GetDecimal("CK") != null) _ck = dr.GetDecimal("CK");
                if (dr.GetString("TENKHOA") != null) _tENKHOA = dr.GetString("TENKHOA");
                if (dr.GetString("TENBS") != null) _tENBS = dr.GetString("TENBS");
                if (dr.GetSmartDate("NGAYYC", true) != null) _nGAYYC = dr.GetSmartDate("NGAYYC", true);
                if (dr.GetSmartDate("NGAYLAP", true) != null) _nGAYLAP = dr.GetSmartDate("NGAYLAP", true);
                if (dr.GetString("NGUOILAP") != null) _nGUOILAP = dr.GetString("NGUOILAP");
                if (dr.GetString("NGUOISD") != null) _nGUOISD = dr.GetString("NGUOISD");
                if (dr.GetSmartDate("NGAYSD", true) != null) _nGAYSD = dr.GetSmartDate("NGAYSD", true);
                if (dr.GetSmartDate("NGAYHUY", true) != null) _nGAYHUY = dr.GetSmartDate("NGAYHUY", true);
                if (dr.GetString("NGUOIHUY") != null) _nGUOIHUY = dr.GetString("NGUOIHUY");
                if (dr.GetString("TENNGUOILAP") != null) _tENNGUOILAP = dr.GetString("TENNGUOILAP");
                if (dr.GetString("TENNGUOISD") != null) _tENNGUOISD = dr.GetString("TENNGUOISD");
                if (dr.GetString("TENNGUOIHUY") != null) _tENNGUOIHUY = dr.GetString("TENNGUOIHUY");
                if (dr.GetString("SoHD") != null) _soHD = dr.GetString("SoHD");
                if (dr.GetString("SoSoHD") != null) _soSoHD = dr.GetString("SoSoHD");
                //if ((dr.GetBoolean("BHTinhtien") != false) && (dr.GetBoolean("Tinhtien") == false))
                //{
                //    _thanhtien = dr.GetDecimal("DongiaBH") * (100 - dr.GetDecimal("ck")) / 100 * (dr.GetDecimal("SLMua") - dr.GetDecimal("SLTra"))
                //    + dr.GetDecimal("giachenhlech") * (100 - dr.GetDecimal("ck")) / 100 * (dr.GetDecimal("SLMua") - dr.GetDecimal("SLTra"));
                //}

                //if ((dr.GetBoolean("BHTinhtien") == false) || (dr.GetBoolean("Tinhtien") != false))
                //    _thanhtien = dr.GetDecimal("DongiaTT") * (100 - dr.GetDecimal("ck")) / 100 * (dr.GetDecimal("SLMua") - dr.GetDecimal("SLTra"));
                if ((dr.GetBoolean("BHTinhtien") != false) && (dr.GetBoolean("Tinhtien") == false))
                {// SUA LAI 
                    //_thanhtien = dr.GetDecimal("DongiaBH") * (100 - dr.GetDecimal("ck")) / 100 * (dr.GetDecimal("Soluong"))
                    //+ dr.GetDecimal("giachenhlech") * (100 - dr.GetDecimal("ck")) / 100 * (dr.GetDecimal("Soluong"));
                    _thanhtien = dr.GetDecimal("giachenhlech") * (100 - dr.GetDecimal("ck")) / 100 * (dr.GetDecimal("Soluong"));
                }
                if ((dr.GetBoolean("BHTinhtien") != false) && (dr.GetBoolean("Tinhtien") == false))
                {// SUA LAI 
                    _thanhtienBH = dr.GetDecimal("DongiaBH") * (100 - dr.GetDecimal("ck")) / 100 * (dr.GetDecimal("Soluong"));
                   
                }
                if ((dr.GetBoolean("BHTinhtien") == false) || (dr.GetBoolean("Tinhtien") != false))
                    _thanhtien = dr.GetDecimal("DongiaTT") * (100 - dr.GetDecimal("ck")) / 100 * (dr.GetDecimal("Soluong"));
            
            
            }
            catch (Exception ex)
            { }


        }
		
		/// <summary>
		/// Insert the new <see cref="KhamBenh_GetsDichVu" /> Object to underlying database.
		/// </summary>
        /// 
        //protected override void DataPortal_Create()
        //{
        //    ValidationRules.CheckRules();
        //}
		//protected override void DataPortal_Insert()

       
       
		/// Update all changes made on <see cref="KhamBenh_GetsDichVu" /> Object to underlying database.
		/// </summary>
		//protected override void DataPortal_Update()
        
       
        //protected void DataPortal_Delete(Criteria crit)
       
      
       
		#endregion
	}

   
}
