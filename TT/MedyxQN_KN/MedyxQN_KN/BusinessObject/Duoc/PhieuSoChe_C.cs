using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using HTC.Business;
using HTC.Business.Duoc;
using HTC.Business.CategoryList;

namespace HTC.Business.Duoc
{	
	
	[Serializable()]
	public partial class PhieuSoChe_C : BusinessBase<PhieuSoChe_C>
	{
		#region Business Methods
		
		#region State Fields
		
        private String _MaSC = String.Empty;
        private Decimal _sTT;
        private String _maThuocS=String.Empty;
        private String _maThuocC = String.Empty;

        private Decimal _soLuongS  ;
        private Decimal _soLuongC;

        private SmartDate _hanSD = new SmartDate(false);
        private String _soLo = String.Empty;
        private Decimal _donGiaS;
        private Decimal _donGiaC;
        private Decimal _soLuongYC ;
        private Decimal _giaBan;
        private Boolean _huy=false;
        private String _ghiChu = String.Empty;
        private String _maMay = String.Empty;
        private SmartDate _ngaySD =new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private String _maQL = String.Empty;
        private String _tenTMS = String.Empty;
        private String _tenTMC = String.Empty;
        private String _tenDVTS = String.Empty;

        private String _tenNguoiSD = String.Empty;
        private SmartDate _hanSDD = new SmartDate(false);
        private Decimal _TonCK = 0;
        private Decimal _TonCKDT = 0;
        private Boolean _handung = false;

        private Boolean _Phanloai=false ;
        private String _tenDVTC = String.Empty;
        private String _soLoC = String.Empty;
        private SmartDate _hanSDC = new SmartDate(false);
        private SmartDate _hanSDCD = new SmartDate(false);
        private String _MaNSC = String.Empty;
        
     
		#endregion
		
		#region Business Properties and Methods
     
        
        public String HanSDD
        {
            get
            {
                CanReadProperty("HanSD", true);
                _hanSDD = _hanSD;
                _hanSDD.FormatString = "dd/MM/yyyy";
               
                return _hanSDD.Text;
            }

        }
        public String HanSDCD
        {
            get
            {
                CanReadProperty("HanSDC", true);
                _hanSDCD = _hanSDC;
                _hanSDCD.FormatString = "dd/MM/yyyy";

                return _hanSDCD.Text;
            }

        }
        public String TonCK
        {
            get
            {
                CanReadProperty("TonCK", true);
                if (_TonCK == 0)
                    return "0";

                else if (_TonCK - (int)(_TonCK) != 0)
                    return _TonCK.ToString("###,###.###");

                else
                    return _TonCK.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TonCK", true);
                if (_TonCK.ToString() != value)
                {
                    if (value == "")
                        _TonCK = 0;
                    else
                    _TonCK = decimal.Parse(value);
                    PropertyHasChanged("TonCK");
                }
            }
        }

        public String TonCKDT
        {
            get
            {
                CanReadProperty("TonCKDT", true);
                if (_TonCKDT == 0)
                    return "0";
                else if (_TonCKDT - (int)(_TonCKDT) != 0)
                    return _TonCKDT.ToString("###,###.###");
                else
                    return _TonCKDT.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TonCKDT", true);
                if (_TonCKDT.ToString() != value)
                {
                    _TonCKDT = decimal.Parse(value);
                    PropertyHasChanged("TonCKDT");
                }
            }
        }
		public String MaSC
		{
			get 
			{
				CanReadProperty("MaSC", true);
				return _MaSC;
			}
			set 
			{
                CanWriteProperty("MaSC", true);
                if (_MaSC != value) 
				{
                    _MaSC = value;
                    PropertyHasChanged("MaSC");
				}
			}
		}
        public String MaNSC
        {
            get
            {
                CanReadProperty("MaNSC", true);
                return _MaNSC;
            }
            set
            {
                CanWriteProperty("MaNSC", true);
                if (_MaNSC != value)
                {
                    _MaNSC = value;
                    PropertyHasChanged("MaNSC");
                }
            }
        }
        public Decimal STT
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
        public String maThuocS
        {
            get
            {
                CanReadProperty("maThuocS", true);
                return _maThuocS;
            }
            set
            {
                CanWriteProperty("maThuocS", true);
                if (_maThuocS != value)
                {
                    _maThuocS = value;
                    PropertyHasChanged("maThuocS");
                }
            }
        }
        public String maThuocC
        {
            get
            {
                CanReadProperty("maThuocC", true);
                return _maThuocC;
            }
            set
            {
                CanWriteProperty("maThuocC", true);
                if (_maThuocC != value)
                {
                    _maThuocC = value;
                    PropertyHasChanged("maThuocC");
                }
            }
        }
        public String soLuongS
        {
            get
            {
                CanReadProperty("soLuongS", true);
                if (_soLuongS == 0)
                    return "0";
                else if (_soLuongS - (int)(_soLuongS) != 0)
                    return _soLuongS.ToString("###,###.###");
                else
                    return _soLuongS.ToString("###,###");
            }
            set
            {
                CanWriteProperty("soLuongS", true);
                if (_soLuongS.ToString() != value)
                {
                if (value == "")
                        _soLuongS = 0;
                    else
                        _soLuongS = decimal.Parse(value);

                    PropertyHasChanged("soLuongS");
                }
            }
        }
        public String soLuongC
        {
            get
            {
                CanReadProperty("soLuongC", true);
                if (_soLuongC == 0)
                    return "0";
                else if (_soLuongC - (int)(_soLuongC) != 0)
                    return _soLuongC.ToString("###,###.###");
                else
                    return _soLuongC.ToString("###,###");
            }
            set
            {
                CanWriteProperty("soLuongC", true);
                if (_soLuongC.ToString() != value)
                {
                    if (value == "")
                        _soLuongC = 0;
                    else
                        _soLuongC = decimal.Parse(value);

                    PropertyHasChanged("soLuongC");
                }
            }
        }
        public String HanSD
        {
            get
            {
                CanReadProperty("HanSD", true);
               // _hanSD.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _hanSD.Text;
            }
            set
            {
                CanWriteProperty("HanSD", true);

                if (!_hanSD.Equals(value))
                {
                    //_hanSD.FormatString = "dd/MM/yyyy HH:mm:ss";
                    _hanSD.Text = value;
                    PropertyHasChanged("HanSD");
                }
            }
        }
        public String HanSDC
        {
            get
            {
                CanReadProperty("HanSDC", true);
                // _hanSD.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _hanSDC.Text;
            }
            set
            {
                CanWriteProperty("HanSDC", true);

                if (!_hanSDC.Equals(value))
                {
                    //_hanSD.FormatString = "dd/MM/yyyy HH:mm:ss";
                    _hanSDC.Text = value;
                    PropertyHasChanged("HanSDC");
                }
            }
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
                CanWriteProperty("SoLo", true);
                if (_soLo != value)
                {
                    _soLo = value;
                    PropertyHasChanged("SoLo");
                }
            }
        }
        public String SoLoC
        {
            get
            {
                CanReadProperty("SoLoC", true);
                return _soLoC;
            }
            set
            {
                CanWriteProperty("SoLoC", true);
                if (_soLoC != value)
                {
                    _soLoC = value;
                    PropertyHasChanged("SoLoC");
                }
            }
        }
        public Decimal DonGiaS
        {
            get
            {
                CanReadProperty("DonGiaS", true);
                return _donGiaS;
            }
            set
            {
                CanWriteProperty("DonGiaS", true);
                if (_donGiaS != value)
                {
                    _donGiaS = value;
                    PropertyHasChanged("DonGiaS");
                }
            }
        }
        public Decimal DonGiaC
        {
            get
            {
                CanReadProperty("DonGiaC", true);
                return _donGiaC;
            }
            set
            {
                CanWriteProperty("DonGiaC", true);
                if (_donGiaC != value)
                {
                    _donGiaC = value;
                    PropertyHasChanged("DonGiaC");
                }
            }
        }
        public Boolean Handung
        {
            get
            {
                CanReadProperty("Handung", true);
                return _handung;
            }
            set
            {
                CanWriteProperty("Handung", true);
                if (_handung != value)
                {
                    _handung = value;
                    PropertyHasChanged("Handung");
                }
            }
        }
        public String SoLuongYC
        {
            get
            {
                CanReadProperty("SoLuongYC", true);
                if (_soLuongYC == 0)
                    return "0";
                else if (_soLuongYC - (int)(_soLuongYC) != 0)
                    return _soLuongYC.ToString("###,###.###");
                else
                    return _soLuongYC.ToString("###,###");
            }
            set
            {
                CanWriteProperty("SoLuongYC", true);
                if (_soLuongYC.ToString() != value)
                {
                    if (value == "")
                        _soLuongYC = 0;
                    else
                        _soLuongYC = decimal.Parse(value);
                        PropertyHasChanged("SoLuongYC");
                }
            }
        }
        public Decimal GiaBan
        {
            get
            {
                CanReadProperty("GiaBan", true);
                return _giaBan;
            }
            set
            {
                CanWriteProperty("GiaBan", true);
                if (_giaBan != value)
                {
                    _giaBan = value;
                    PropertyHasChanged("GiaBan");
                }
            }
        }
        public Boolean Huy
        {
            get
            {
                CanReadProperty("Huy", true);
                return _huy;
            }
            set
            {
                CanWriteProperty("Huy", true);
                if (_huy != value)
                {
                    _huy = value;
                    PropertyHasChanged("Huy");
                }
            }
        }
        public String GhiChu
        {
            get
            {
                CanReadProperty("GhiChu", true);
                return _ghiChu;
            }
            set
            {
                CanWriteProperty("GhiChu", true);
                if (_ghiChu != value)
                {
                    _ghiChu = value;
                    PropertyHasChanged("GhiChu");
                }
            }
        }
        public String MaMay
        {
            get
            {
                CanReadProperty("MaMay", true);
                return _maMay;
            }
            set
            {
                CanWriteProperty("MaMay", true);
                if (_maMay != value)
                {
                    _maMay = value;
                    PropertyHasChanged("MaMay");
                }
            }
        }
        public SmartDate NgaySD
        {
            get
            {
                CanReadProperty("NgaySD", true);
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngaySD;
            }
            set
            {
                CanWriteProperty("NgaySD", true);
                if (_ngaySD != value)
                {
                    _ngaySD = value;
                    PropertyHasChanged("NgaySD");
                }
            }
        }
        public String NguoiSD
        {
            get
            {
                CanReadProperty("NguoiSD", true);
                return _nguoiSD;
            }
            set
            {
                CanWriteProperty("NguoiSD", true);
                if (_nguoiSD != value)
                {
                    _nguoiSD = value;
                    PropertyHasChanged("NguoiSD");
                }
            }
        }
        public String MaQL
        {
            get
            {
                CanReadProperty("MaQL", true);
                return _maQL;
            }
            set
            {
                CanWriteProperty("MaQL", true);
                if (_maQL != value)
                {
                    _maQL = value;
                    PropertyHasChanged("MaQL");
                }
            }
        }
        public String TenTMS
        {
            get
            {
                CanReadProperty("TenTMS", true);
                return _tenTMS;
            }
            set
            {
                CanWriteProperty("TenTMS", true);
                if (_tenTMS != value)
                {
                    _tenTMS = value;
                    PropertyHasChanged("TenTMS");
                }
            }
        }
        public String TenTMC
        {
            get
            {
                CanReadProperty("TenTMC", true);
                return _tenTMC;
            }
            set
            {
                CanWriteProperty("TenTMC", true);
                if (_tenTMC != value)
                {
                    _tenTMC = value;
                    PropertyHasChanged("TenTMC");
                }
            }
        }
        public String TenDVTS
        {
            get
            {
                CanReadProperty("TenDVTS", true);
                return _tenDVTS;
            }
            set
            {
                CanWriteProperty("TenDVTS", true);
                if (_tenDVTS != value)
                {
                    _tenDVTS = value;
                    PropertyHasChanged("TenDVTS");
                }
            }
        }
        public String TenDVTC
        {
            get
            {
                CanReadProperty("TenDVTC", true);
                return _tenDVTC;
            }
            set
            {
                CanWriteProperty("TenDVTC", true);
                if (_tenDVTC != value)
                {
                    _tenDVTC = value;
                    PropertyHasChanged("TenDVTC");
                }
            }
        }
        public String TenNguoiSD
        {
            get
            {
                CanReadProperty("TenNguoiSD", true);
                return _tenNguoiSD;
            }
            set
            {
                CanWriteProperty("TenNguoiSD", true);
                if (_tenNguoiSD != value)
                {
                    _tenNguoiSD = value;
                    PropertyHasChanged("TenNguoiSD");
                }
            }
        }
   public Boolean  Phanloai
        {
            get
            {
                CanReadProperty("Phanloai", true);
                return _Phanloai;
            }
            set
            {
                CanWriteProperty("Phanloai", true);
                if (_Phanloai != value)
                {
                    _Phanloai = value;
                    PropertyHasChanged("Phanloai");
                }
            }
        }       

		protected override Object GetIdValue()
		{
			return _sTT;
		}
		
		#endregion
		#endregion
				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods

        public static PhieuSoChe_C NewPhieuSoChe_C()
        {
            return new PhieuSoChe_C();
            
        }

        public static PhieuSoChe_C NewPhieuSoChe_C(string idDMThuoc)
        {
            return new PhieuSoChe_C(DMThuoc.GetDMThuoc(idDMThuoc));
        }

        public static PhieuSoChe_C NewPhieuSoChe_C(DMThuoc _DMThuoc)
        {
            return new PhieuSoChe_C(_DMThuoc);
        }
        
        public static PhieuSoChe_C GetPhieuSoChe_C(String maPhieuSoChe, decimal sTT)
        {
            return DataPortal.Fetch<PhieuSoChe_C>(new Criteria(maPhieuSoChe, sTT));
        }

        public static PhieuSoChe_C GetPhieuSoChe_C(SafeDataReader dr)
        {
            return new PhieuSoChe_C(dr);
        }

        public static void DeletePhieuSoChe_C(String _maPN, decimal _sTT, string _nguoiSD, string _mamay)
        {
            DataPortal.Delete(new OtherCriteria(_maPN, _sTT,_nguoiSD,_mamay));
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public-++++ !!!

        protected internal PhieuSoChe_C()
        { 
            //
        }
        protected PhieuSoChe_C(DMThuoc pro)
        {
            MarkAsChild();
            _maThuocS = pro.MaThuoc ;
            _tenTMS = pro.TenTM;
        }
        protected PhieuSoChe_C(string _idMaSC, DMThuoc pro)
        {
            MarkAsChild();
            _MaSC = _idMaSC;            
            _maThuocS = pro.MaThuoc ;
            _tenTMS = pro.TenTM;
            _maMay = pro.MaMay;
            _huy = pro.Huy;
            _nguoiSD = pro.NguoiSD;  
        }
        protected PhieuSoChe_C(SafeDataReader dr)
        {
            MarkAsChild();
            _MaSC = dr.GetString("MaSC");
             _sTT = dr.GetDecimal("STT");
            _maThuocS = dr.GetString("maThuocS");
            _soLuongS = dr.GetDecimal("soLuongS");
            _maThuocC = dr.GetString("maThuocC");
            _soLuongC = dr.GetDecimal("soLuongC");
            _Phanloai = dr.GetBoolean("Phanloai");
            _hanSD = dr.GetSmartDate("HanSD",false);
            _soLo = dr.GetString("SoLo");
            _hanSDC = dr.GetSmartDate("HanSDC", false);
            _soLoC = dr.GetString("SoLoC");
            _donGiaS = dr.GetDecimal("DonGiaS");
            _donGiaC = dr.GetDecimal("DonGiaC");
            _soLuongYC = dr.GetDecimal("SLyc");
            _giaBan = dr.GetDecimal("GiaBan");
            _huy = dr.GetBoolean("Huy");
            _ghiChu = dr.GetString("GhiChu");
            _maMay = dr.GetString("MaMay");
            _ngaySD = dr.GetSmartDate("NgaySD",false);
            _nguoiSD = dr.GetString("NguoiSD");
            _maQL = dr.GetString("MaQL");
            _tenTMS = dr.GetString("TenTMS");
            _tenTMC = dr.GetString("TenTMC");
            _tenDVTS = dr.GetString("TenDVTS");
            _tenDVTC = dr.GetString("TenDVTC");
            _tenNguoiSD = dr.GetString("TenNguoiSD");
            _TonCK = dr.GetDecimal("TonCK");
             _TonCKDT = dr.GetDecimal("TonCKDT");
             if (dr.GetBoolean("Handung") != null) _handung = dr.GetBoolean("Handung");
            MarkOld();
        }

		#endregion

		#region Criteria
         	
		[Serializable()]
        protected class Criteria
        {
            private String _MaSC;
            public String MaSC
            {
                get
                {
                    return _MaSC;
                }
            }
            private decimal _STT;
            public decimal STT
            {
                get
                {
                    return _STT;
                }
            }
            public Criteria(String MaSC,decimal sTT)
            {
                _MaSC = MaSC;
                _STT = sTT;
            }
            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_MaSC.Equals(c._MaSC))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _MaSC.ToString()).GetHashCode();
            }
        }

        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaSC;
            public String MaSC
            {
                get
                {
                    return _MaSC;
                }
            }
            private decimal _sTT;
            public decimal sTT
            {
                get
                {
                    return _sTT ;
                }
            }
            private String _maMay;
            public String MaMay
            {
                get
                {
                    return _maMay;
                }
            }
            private String _NguoiSD;
            public String NguoiSD
            {
                get
                {
                    return _NguoiSD;
                }
            }
            public OtherCriteria( String MaSC, decimal sTT ,String Mamay, String Nguoisd)
            {
                _MaSC = MaSC;
                _sTT=sTT ;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
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

        protected void Fetch(SafeDataReader dr)
        {
            if (dr.GetString("MaSC") != null) _MaSC = dr.GetString("MaSC");
            if (dr.GetString("MaNSC") != null) _MaNSC = dr.GetString("MaNSC");
            if(dr.GetString("maThuocS")!=null) _maThuocS = dr.GetString("maThuocS");
            if(dr.GetDecimal("soLuongS")!=null) _soLuongS = dr.GetDecimal("soLuongS");
            if(dr.GetSmartDate("HanSD",false)!=null) _hanSD = dr.GetSmartDate("HanSD",false);
            if (dr.GetString("maThuocC") != null) _maThuocC  = dr.GetString("maThuocC");
            if (dr.GetDecimal("soLuongC") != null) _soLuongC = dr.GetDecimal("soLuongC");
            if (dr.GetSmartDate("HanSDC", false) != null) _hanSDC = dr.GetSmartDate("HanSDC", false);
            if (dr.GetString("SoLoC") != null) _soLoC = dr.GetString("SoLoC");
            if(dr.GetString("SoLo")!=null) _soLo = dr.GetString("SoLo");
            if(dr.GetDecimal("DonGiaS")!=null) _donGiaS = dr.GetDecimal("DonGiaS");
            if (dr.GetDecimal("DonGiaC") != null) _donGiaC = dr.GetDecimal("DonGiaC");
            if(dr.GetDecimal("SoLuongYC")!=null) _soLuongYC = dr.GetDecimal("SoLuongYC");
            if(dr.GetDecimal("GiaBan")!=null) _giaBan = dr.GetDecimal("GiaBan");
            if(dr.GetBoolean("Huy")!=null) _huy = dr.GetBoolean("Huy");
            if(dr.GetString("GhiChu")!=null) _ghiChu = dr.GetString("GhiChu");
            if(dr.GetString("MaMay")!=null) _maMay = dr.GetString("MaMay");
            if(dr.GetSmartDate("NgaySD",false)!=null) _ngaySD = dr.GetSmartDate("NgaySD",false);
            if(dr.GetString("NguoiSD")!=null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("MaQL") != null) _maQL = dr.GetString("MaQL");
            if(dr.GetString("TenTMS")!=null) _tenTMS = dr.GetString("TenTMS");
            if (dr.GetString("TenTMC") != null) _tenTMC = dr.GetString("TenTMC");
            if(dr.GetString("TenDVTS")!=null) _tenDVTS = dr.GetString("TenDVTS");
            if (dr.GetString("TenDVTC") != null) _tenDVTC = dr.GetString("TenDVTC");
            if(dr.GetString("TenNguoiSD")!=null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetDecimal("TonCK") != null) _TonCK = dr.GetDecimal("TonCK");
            if (dr.GetDecimal("TonCKDT") != null) _TonCKDT = dr.GetDecimal("TonCKDT");
            if (dr.GetBoolean("Handung") != null) _handung = dr.GetBoolean("Handung");
            if (dr.GetBoolean("Phanloai") != null) _Phanloai = dr.GetBoolean("Phanloai");
            try
            {
                
            }
            catch
            { 
                //
            }
            
        }
        protected void DataPortal_Fetch(Criteria crit)
        {
            //using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetPhieuSoChe_C(crit.MaSC, crit.STT))) 
            //{
            //    if (dr.Read())
            //    {
            //        Fetch(dr);
            //        MarkOld();
            //        ValidationRules.CheckRules();
            //    }
            //}
        }
        internal virtual void Insert(PhieuSoChe bill)
        {
            
              
            _MaSC = bill.MaSC;
            DataProvider.Instance().InsertPhieuSoChe_C(bill.MaSC, _maThuocS, _soLuongS, _maThuocC, _soLuongC, _hanSD, _soLo, _donGiaS, _soLuongYC, _giaBan, _ghiChu, _nguoiSD , _maMay,_Phanloai );
            MarkOld();
        }

        internal virtual void Update(PhieuSoChe bill)
        {
            if(IsDirty)
            {      
            
              
            DataProvider.Instance().UpdatePhieuSoche_C(bill.MaSC, _sTT, _maThuocS, _soLuongS, _maThuocC, _soLuongC, _hanSD, _soLo, _hanSDC, _soLoC, _donGiaS, _soLuongYC, _giaBan, _huy, _ghiChu, _nguoiSD , _maMay, _Phanloai);
            }
        }
        internal void DeleteSelf(PhieuSoChe packet)
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            DataProvider.Instance().DeletePhieuSoche_C(_MaSC,_sTT,_nguoiSD,_maMay);
            MarkNew();
            
        }
		#endregion
	}

}
