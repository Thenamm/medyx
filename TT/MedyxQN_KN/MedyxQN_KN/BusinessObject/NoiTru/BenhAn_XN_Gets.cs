using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;


namespace HTC.Business.NoiTru
{
    [Serializable()]
    public partial class BenhAn_XN_Gets : BusinessBase<BenhAn_XN_Gets>
    {
        #region Business Methods

        #region State Fields

        private String _maba = String.Empty;
        private Int32 _sTT = 0;
        private Int32 _sTTKhoa = 0;
        private String _mADV = String.Empty;
        private String _bSCHIDINH = String.Empty;
        private Byte[] _fILEKQ = new Byte[] { };
        private String _kq = String.Empty;
        private Int32 _sTTCS = 0;
        private String _mACS = String.Empty;
        private String _kQCS = String.Empty;
        private String _tENCS = String.Empty;
        private String _tENDV = String.Empty;
        private String _cHISOCAONAM = String.Empty;
        private String _cHISOCAONU = String.Empty;
        private String _cHISOTHAPNAM = String.Empty;
        private String _cHISOTHAPNU = String.Empty;
        private String _dONVI = String.Empty;
        private String _cHISOCAONAMCS = String.Empty;
        private String _cHISOCAONUCS = String.Empty;
        private String _cHISOTHAPNAMCS = String.Empty;
        private String _cHISOTHAPNUCS = String.Empty;
        private String _dONVICS = String.Empty;
        private Byte _lOAIKQ = 0;
        private int _OrderNumber;
        private String _tenKQ = String.Empty;
        private SmartDate _ngayDK = new SmartDate("", true);
        private Byte _daTT = 0;
        private Boolean _NhapSL = false;
        private String _formSudung = String.Empty;
        private String _makq = String.Empty;
	
        #endregion

        #region Business Properties and Methods
        public string NgayDK
        {
            get
            {
                CanReadProperty("NgayDK", true);
                return _ngayDK.Text;
            }
            set
            {
                CanWriteProperty("NgayDK", true);
                if (_ngayDK.Text != value)
                {
                    _ngayDK.Text = value;
                    PropertyHasChanged("NgayDK");
                }
            }
        }
        public String tenKQ
        {
            get
            {
                CanReadProperty("tenKQ", true);
                return _tenKQ;
            }
            set
            {
                CanWriteProperty("tenKQ", true);
                if (_tenKQ != value)
                {
                    _tenKQ = value;
                    PropertyHasChanged("tenKQ");
                }
            }
        }
	
        public String makq
        {
            get
            {
                CanReadProperty("makq", true);
                return _makq;
            }
            set
            {
                CanWriteProperty("makq", true);
                if (_makq != value)
                {
                    _makq = value;
                    PropertyHasChanged("makq");
                }
            }
        }
	
        public String FormSudung
        {
            get
            {
                CanReadProperty("FormSudung", true);
                return _formSudung;
            }
            set
            {
                CanWriteProperty("FormSudung", true);
                if (_formSudung != value)
                {
                    _formSudung = value;
                    PropertyHasChanged("FormSudung");
                }
            }
        }
        public Byte DaTT
        {
            get
            {
                CanReadProperty("DaTT", true);
                return _daTT;
            }
            set
            {
                CanWriteProperty("DaTT", true);
                if (_daTT != value)
                {
                    _daTT = value;
                    PropertyHasChanged("DaTT");
                }
            }
        }
        public Boolean  NhapSL
        {
            get
            {
                CanReadProperty("NhapSL", true);
                return _NhapSL;
            }
            set
            {
                CanWriteProperty("NhapSL", true);
                if (_NhapSL != value)
                {
                    _NhapSL = value;
                    PropertyHasChanged("NhapSL");
                }
            }
        }
        public String maba
        {
            get
            {
                CanReadProperty("maba", true);
                return _maba;
            }
            set
            {
                CanWriteProperty("maba", true);
                if (_maba != value)
                {
                    _maba = value;
                    PropertyHasChanged("maba");
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
        public Int32 STTKhoa
        {
            get
            {
                CanReadProperty("STTKhoa", true);
                return _sTTKhoa;
            }
            set
            {
                CanWriteProperty("STTKhoa", true);
                if (_sTTKhoa != value)
                {
                    _sTTKhoa = value;
                    PropertyHasChanged("STTKhoa");
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

        public String BSCHIDINH
        {
            get
            {
                CanReadProperty("BSCHIDINH", true);
                return _bSCHIDINH;
            }
            set
            {
                CanWriteProperty("BSCHIDINH", true);
                if (_bSCHIDINH != value)
                {
                    _bSCHIDINH = value;
                    PropertyHasChanged("BSCHIDINH");
                }
            }
        }

        public Byte[] FILEKQ
        {
            get
            {
                CanReadProperty("FILEKQ", true);
                return _fILEKQ;
            }
            set
            {
                CanWriteProperty("FILEKQ", true);
                bool setNewValue = false;
                if (value != null && _fILEKQ == null)
                    setNewValue = true;
                if (!setNewValue && value != null && _fILEKQ != null)
                {
                    if (_fILEKQ.Length != value.Length)
                    {
                        setNewValue = true;
                    }
                    else
                    {
                        for (int i = 0; i < value.Length; i++)
                        {
                            if (value[i] != _fILEKQ[i])
                            {
                                setNewValue = true;
                                break;
                            }
                        }
                    }
                }
                if (setNewValue)
                {
                    _fILEKQ = value;
                    PropertyHasChanged("FILEKQ");
                }
            }
        }

        public String KQ
        {
            get
            {
                CanReadProperty("KQ", true);
                return _kq;
            }
            set
            {
                CanWriteProperty("KQ", true);
                if (_kq != value)
                {
                    _kq = value;
                    PropertyHasChanged("KQ");
                }
            }
        }

        public Int32 STTCS
        {
            get
            {
                CanReadProperty("STTCS", true);
                return _sTTCS;
            }
            set
            {
                CanWriteProperty("STTCS", true);
                if (_sTTCS != value)
                {
                    _sTTCS = value;
                    PropertyHasChanged("STTCS");
                }
            }
        }

        public String MACS
        {
            get
            {
                CanReadProperty("MACS", true);
                return _mACS;
            }
            set
            {
                CanWriteProperty("MACS", true);
                if (_mACS != value)
                {
                    _mACS = value;
                    PropertyHasChanged("MACS");
                }
            }
        }

        public String KQCS
        {
            get
            {
                CanReadProperty("KQCS", true);
                return _kQCS;
            }
            set
            {
                CanWriteProperty("KQCS", true);
                if (_kQCS != value)
                {
                    _kQCS = value;
                    PropertyHasChanged("KQCS");
                }
            }
        }

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

        public String CHISOCAONAM
        {
            get
            {
                CanReadProperty("CHISOCAONAM", true);
                return _cHISOCAONAM;
            }
            set
            {
                CanWriteProperty("CHISOCAONAM", true);
                if (_cHISOCAONAM != value)
                {
                    _cHISOCAONAM = value;
                    PropertyHasChanged("CHISOCAONAM");
                }
            }
        }

        public String CHISOCAONU
        {
            get
            {
                CanReadProperty("CHISOCAONU", true);
                return _cHISOCAONU;
            }
            set
            {
                CanWriteProperty("CHISOCAONU", true);
                if (_cHISOCAONU != value)
                {
                    _cHISOCAONU = value;
                    PropertyHasChanged("CHISOCAONU");
                }
            }
        }

        public String CHISOTHAPNAM
        {
            get
            {
                CanReadProperty("CHISOTHAPNAM", true);
                return _cHISOTHAPNAM;
            }
            set
            {
                CanWriteProperty("CHISOTHAPNAM", true);
                if (_cHISOTHAPNAM != value)
                {
                    _cHISOTHAPNAM = value;
                    PropertyHasChanged("CHISOTHAPNAM");
                }
            }
        }

        public String CHISOTHAPNU
        {
            get
            {
                CanReadProperty("CHISOTHAPNU", true);
                return _cHISOTHAPNU;
            }
            set
            {
                CanWriteProperty("CHISOTHAPNU", true);
                if (_cHISOTHAPNU != value)
                {
                    _cHISOTHAPNU = value;
                    PropertyHasChanged("CHISOTHAPNU");
                }
            }
        }

        public String DONVI
        {
            get
            {
                CanReadProperty("DONVI", true);
                return _dONVI;
            }
            set
            {
                CanWriteProperty("DONVI", true);
                if (_dONVI != value)
                {
                    _dONVI = value;
                    PropertyHasChanged("DONVI");
                }
            }
        }

        public String CHISOCAONAMCS
        {
            get
            {
                CanReadProperty("CHISOCAONAMCS", true);
                return _cHISOCAONAMCS;
            }
            set
            {
                CanWriteProperty("CHISOCAONAMCS", true);
                if (_cHISOCAONAMCS != value)
                {
                    _cHISOCAONAMCS = value;
                    PropertyHasChanged("CHISOCAONAMCS");
                }
            }
        }

        public String CHISOCAONUCS
        {
            get
            {
                CanReadProperty("CHISOCAONUCS", true);
                return _cHISOCAONUCS;
            }
            set
            {
                CanWriteProperty("CHISOCAONUCS", true);
                if (_cHISOCAONUCS != value)
                {
                    _cHISOCAONUCS = value;
                    PropertyHasChanged("CHISOCAONUCS");
                }
            }
        }

        public String CHISOTHAPNAMCS
        {
            get
            {
                CanReadProperty("CHISOTHAPNAMCS", true);
                return _cHISOTHAPNAMCS;
            }
            set
            {
                CanWriteProperty("CHISOTHAPNAMCS", true);
                if (_cHISOTHAPNAMCS != value)
                {
                    _cHISOTHAPNAMCS = value;
                    PropertyHasChanged("CHISOTHAPNAMCS");
                }
            }
        }

        public String CHISOTHAPNUCS
        {
            get
            {
                CanReadProperty("CHISOTHAPNUCS", true);
                return _cHISOTHAPNUCS;
            }
            set
            {
                CanWriteProperty("CHISOTHAPNUCS", true);
                if (_cHISOTHAPNUCS != value)
                {
                    _cHISOTHAPNUCS = value;
                    PropertyHasChanged("CHISOTHAPNUCS");
                }
            }
        }

        public String DONVICS
        {
            get
            {
                CanReadProperty("DONVICS", true);
                return _dONVICS;
            }
            set
            {
                CanWriteProperty("DONVICS", true);
                if (_dONVICS != value)
                {
                    _dONVICS = value;
                    PropertyHasChanged("DONVICS");
                }
            }
        }

        public Byte LOAIKQ
        {
            get
            {
                CanReadProperty("LOAIKQ", true);
                return _lOAIKQ;
            }
            set
            {
                CanWriteProperty("LOAIKQ", true);
                if (_lOAIKQ != value)
                {
                    _lOAIKQ = value;
                    PropertyHasChanged("LOAIKQ");
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
            return _OrderNumber;
        }
        #endregion
        #endregion
                      
		#region Business Object Rules and Validation

       
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhAn_XN_Gets" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BenhAn_XN_Gets NewBenhAn_XN_Gets()
        {
            return new BenhAn_XN_Gets();
           
        }
       public static BenhAn_XN_Gets NewBenhAn_XN_Gets(BenhAn_C _BenhAn_C)
        {
            return new BenhAn_XN_Gets(_BenhAn_C);
         
        }
        public static BenhAn_XN_Gets GetBenhAn_XN_Gets(String _maba, Int32 _SoTTkhoa, Int32 _SoTT, Byte _Loai)
        {
            return DataPortal.Fetch<BenhAn_XN_Gets>(new Criteria(_maba, _SoTTkhoa,_SoTT , _Loai ));
        }
        
        
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public-++++ !!!
        protected internal BenhAn_XN_Gets()
        {
            // Prevent direct creation
        }
        internal BenhAn_XN_Gets(
             String maba ,
            Int32 sTTKhoa,
		 Int32 sTT ,
		 String mADV ,
         String bSCHIDINH,
		 Byte[] fILEKQ ,
		 String kq ,
		 Int32 sTTCS ,
		 String mACS ,
		 String kQCS ,
		 String tENCS ,
		 String tENDV ,
		 String cHISOCAONAM ,
		 String cHISOCAONU ,
		 String cHISOTHAPNAM ,
		 String cHISOTHAPNU ,
		 String dONVI ,
		 String cHISOCAONAMCS ,
		 String cHISOCAONUCS ,
		 String cHISOTHAPNAMCS ,
		 String cHISOTHAPNUCS ,
		 String dONVICS ,
		 Byte lOAIKQ ,
         int OrderNumber,
         Byte DATT,
            Boolean nhapsl,
            string formSudung, string makq,string tenkq,SmartDate ngaydk)
        {
            _makq = makq;
            _tenKQ = tenkq;
            _ngayDK = ngaydk;
            _maba = maba ;
            _formSudung = formSudung;
            _sTT = sTT;
            _sTTKhoa = sTTKhoa;
            _mADV = mADV;
            _bSCHIDINH = bSCHIDINH;
            _fILEKQ = fILEKQ;
            _kq = kq;
            _sTTCS = sTTCS;
            _mACS = mACS;
            _kQCS = kQCS;
            _tENCS = tENCS;
            _tENDV = tENDV;
            _cHISOCAONAM = cHISOCAONAM;
            _cHISOCAONU = cHISOCAONU;
            _cHISOTHAPNAM = cHISOTHAPNAM;
            _cHISOTHAPNU = cHISOTHAPNU;
            _dONVI = dONVI;
            _cHISOCAONAMCS = cHISOCAONAMCS;
            _cHISOCAONUCS = cHISOCAONUCS;
            _cHISOTHAPNAMCS = cHISOTHAPNAMCS;
            _cHISOTHAPNUCS = cHISOTHAPNUCS;
             _dONVICS = dONVICS;
             _lOAIKQ = lOAIKQ;
            _OrderNumber = OrderNumber;
            _daTT = DATT;
            _NhapSL = nhapsl;
        }



        protected BenhAn_XN_Gets(BenhAn_C pro)
        {
            MarkAsChild();

            // day so lieu 1 dich vu de hien thi len
        }
        
       
		#endregion

		#region Criteria
         	
        [Serializable()]
        protected class Criteria
        {
            private String _maba;
            public String maba 
            {
                get
                {
                    return _maba;
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
            private Int32 _SoTTKhoa;
            public Int32 SoTTKhoa
            {
                get
                {
                    return _SoTTKhoa;
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
            public Criteria(String maba, Int32 SoTTKhoa, Int32 SoTT, Byte Loai)
            {
                _maba = maba;
                _SoTT = SoTT;
                _SoTTKhoa = SoTTKhoa;
                _Loai = Loai; 
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maba.Equals(c._maba))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maba.ToString()).GetHashCode();
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
		/// Retrieve an existing <see cref="BenhAn_XN_Gets" /> Object based on data in the database.
		/// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
           
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_XN_Gets(crit.maba ,  crit.SoTT,crit.SoTTKhoa ,  crit.Loai  )))
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
		/// Load a <see cref="BenhAn_XN_Gets" /> Object from given SafeDataReader.
		/// </summary>
        private void Fetch(SafeDataReader dr )//lay o chi tiet thu tuc spBenhAn_XN_Gets_Get
        {
            // Value properties
            try
            {
                if (dr.GetString("FormSudung") != null) _formSudung = dr.GetString("FormSudung");
           
                if (dr.GetString("maba") != null) _maba = dr.GetString("maba");
                if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
                if (dr.GetInt32("STTkhoa") != null) _sTTKhoa = dr.GetInt32("STTkhoa");
                if (dr.GetString("MADV") != null) _mADV = dr.GetString("MADV");
                if (dr.GetString("BSCHIDINH") != null) _bSCHIDINH = dr.GetString("BSCHIDINH");
                if ((Byte[])dr.GetValue("FILEKQ") != null) _fILEKQ = (Byte[])dr.GetValue("FILEKQ");
                 if (dr.GetByte("LOAIKQ") != null) _lOAIKQ = dr.GetByte("LOAIKQ");
                 if (dr.GetBoolean("nhapsl") != null) _NhapSL = dr.GetBoolean("nhapsl");
                 if (dr.GetString("MaKQ") != null) _makq = dr.GetString("MaKQ");
                 if (dr.GetString("tenKQ") != null) _tenKQ = dr.GetString("tenKQ");
                 if (dr.GetSmartDate("NgayDK", true) != null) _ngayDK = dr.GetSmartDate("NgayDK", true);
                 if (_lOAIKQ == 2)
                 {
                     if (dr.GetString("KQ") != null) _kq = dr.GetString("KQ");
                     if (dr.GetString("CHISOCAONAM") != null) _cHISOCAONAM = dr.GetString("CHISOCAONAM");
                     if (dr.GetString("CHISOCAONU") != null) _cHISOCAONU = dr.GetString("CHISOCAONU");
                     if (dr.GetString("CHISOTHAPNAM") != null) _cHISOTHAPNAM = dr.GetString("CHISOTHAPNAM");
                     if (dr.GetString("CHISOTHAPNU") != null) _cHISOTHAPNU = dr.GetString("CHISOTHAPNU");
                     if (dr.GetString("DONVI") != null) _dONVI = dr.GetString("DONVI");

                 }
                 else if (_lOAIKQ == 3)
                 {
                     if (dr.GetString("KQCS") != null) _kq = dr.GetString("KQCS");
                     if (dr.GetString("CHISOCAONAMCS") != null) _cHISOCAONAM  = dr.GetString("CHISOCAONAMCS");
                     if (dr.GetString("CHISOCAONUCS") != null) _cHISOCAONU  = dr.GetString("CHISOCAONUCS");
                     if (dr.GetString("CHISOTHAPNAMCS") != null) _cHISOTHAPNAM  = dr.GetString("CHISOTHAPNAMCS");
                     if (dr.GetString("CHISOTHAPNUCS") != null) _cHISOTHAPNU = dr.GetString("CHISOTHAPNUCS");
                     if (dr.GetString("DONVICS") != null) _dONVI = dr.GetString("DONVICS");
                     if (dr.GetInt32("STTCS") != null) _sTTCS = dr.GetInt32("STTCS");
                     if (dr.GetString("MACS") != null) _mACS = dr.GetString("MACS");
                     if (dr.GetString("TENCS") != null) _tENCS = dr.GetString("TENCS");
                 }
                 if (dr.GetString("TENDV") != null) _tENDV = dr.GetString("TENDV"); 
                if (dr.GetString("CHISOCAONAMCS") != null) _cHISOCAONAMCS = dr.GetString("CHISOCAONAMCS");
                if (dr.GetString("CHISOCAONUCS") != null) _cHISOCAONUCS = dr.GetString("CHISOCAONUCS");
                if (dr.GetString("CHISOTHAPNAMCS") != null) _cHISOTHAPNAMCS = dr.GetString("CHISOTHAPNAMCS");
                if (dr.GetString("CHISOTHAPNUCS") != null) _cHISOTHAPNUCS = dr.GetString("CHISOTHAPNUCS");
                if (dr.GetString("DONVICS") != null) _dONVICS = dr.GetString("DONVICS");
                if (dr.GetByte("DaTT") != null) _daTT = dr.GetByte("DaTT");
            }
            catch (Exception ex)
            { }


        }
		
		/// <summary>
		/// Insert the new <see cref="BenhAn_XN_Gets" /> Object to underlying database.
		/// </summary>
        /// 
        //protected override void DataPortal_Create()
        //{
        //    ValidationRules.CheckRules();
        //}
		//protected override void DataPortal_Insert()

       
       
		/// Update all changes made on <see cref="BenhAn_XN_Gets" /> Object to underlying database.
		/// </summary>
		//protected override void DataPortal_Update()
        
       
        //protected void DataPortal_Delete(Criteria crit)
       
      
       
		#endregion
	}

   
}
