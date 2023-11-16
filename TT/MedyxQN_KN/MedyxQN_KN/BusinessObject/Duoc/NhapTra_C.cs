using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using HTC.Business;
using HTC.Business.Duoc;
using HTC.Business.CategoryList;
//


namespace HTC.Business.Duoc
{	
	
	[Serializable()]
	public partial class NhapTra_C : BusinessBase<NhapTra_C>
	{
		#region Business Methods
		
		#region State Fields
		
        private String _MaPNT = String.Empty;
        private Decimal _sTT=0;
        private String _maThuoc=String.Empty;
        private Decimal _soLuong=0;
        private Decimal _soLuongD = 0;
        private SmartDate _hanSD = new SmartDate(false);
        private SmartDate _hanSDD = new SmartDate(false);
        //private SmartDate _hanSD = new SmartDate(false);
        //private SmartDate _hanSDD = new SmartDate(false);
        private String _soLo = String.Empty;
        private Decimal _donGia=0;
        private Decimal _soLuongYC=0;
        private Decimal _giaBan=0;
        private Boolean _huy=false;
        private String _ghiChu = String.Empty;
        private String _maMay = String.Empty;
        private SmartDate _ngaySD =new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private String _tenTM = String.Empty;
        private String _tenDVT = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private int _OrderNumber;
        private Decimal _tonCk = 0;
        private Boolean _handung = false;
        private String _maQL = String.Empty;
		#endregion
		
		#region Business Properties and Methods
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
		public String MaPNT
		{
			get 
			{
				CanReadProperty("MaPNT", true);
				return _MaPNT;
			}
			set 
			{
                CanWriteProperty("MaPNT", true);
                if (_MaPNT != value) 
				{
                    _MaPNT = value;
                    PropertyHasChanged("MaPNT");
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
        public String MaThuoc
        {
            get
            {
                CanReadProperty("MaThuoc", true);
                return _maThuoc;
            }
            set
            {
                CanWriteProperty("MaThuoc", true);
                if (_maThuoc != value)
                {
                    _maThuoc = value;
                    PropertyHasChanged("MaThuoc");
                }
            }
        }
        public string Soluong
        {
            get
            {
                CanReadProperty("Soluong", true);
                if (_soLuong == 0)
                {
                    return "0";
                }
                else if (_soLuong - (int)(_soLuong) != 0)
                {
                    return _soLuong.ToString("###,###.###");
                }
                else
                {
                    return _soLuong.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("Soluong", true);
                if (_soLuong.ToString() == "" || value == null)
                {
                    _soLuong = 0;
                    PropertyHasChanged("Soluong");
                }
                else if (_soLuong.ToString() != value)
                {
                    _soLuong = decimal.Parse(value);
                    PropertyHasChanged("Soluong");
                }
                

            }
        }
        public string SoluongD
        {
            get
            {
                CanReadProperty("SoluongD", true);
                if (_soLuongD == 0)
                {
                    return "0";
                }
                else if (_soLuongD - (int)(_soLuongD) != 0)
                {
                    return _soLuongD.ToString("###,###.###");
                }

                else
                {
                    return _soLuongD.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoluongD", true);
                if (_soLuongD.ToString() == "" || value == null)
                {
                    _soLuongD = 0;
                    PropertyHasChanged("SoluongD");
                }
                else if (_soLuongD.ToString() != value)
                {
                    _soLuongD = decimal.Parse(value);
                    PropertyHasChanged("SoluongD");
                }


            }
        }
        //public SmartDate HanSD
        //{
        //    get
        //    {
        //        CanReadProperty("HanSD", true);
        //        _hanSD.FormatString = "dd/MM/yyyy HH:mm:ss";
        //        return _hanSD;
        //    }
        //    set
        //    {
        //        CanWriteProperty("HanSD", true);
        //        if (_hanSD != value)
        //        {
        //            _hanSD = value;
        //            PropertyHasChanged("HanSD");
        //        }
        //    }
        //}

        public String HanSD
        {
            get
            {
                CanReadProperty("HanSD", true);
               
                return _hanSD.Text;
            }
            set
            {
                CanWriteProperty("HanSD", true);

                if (!_hanSD.Text.Equals(value))
                {
                  
                    //_hanSD.Date   = DateTime.Parse(value);
                    _hanSD.Text = value;
                    PropertyHasChanged("HanSD");
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
                CanWriteProperty("SoLo", true);
                if (_soLo != value)
                {
                    _soLo = value;
                    PropertyHasChanged("SoLo");
                }
            }
        }
        public Decimal DonGia
        {
            get
            {
                CanReadProperty("DonGia", true);
                return _donGia;
            }
            set
            {
                CanWriteProperty("DonGia", true);
                if (_donGia != value)
                {
                    _donGia = value;
                    PropertyHasChanged("DonGia");
                }
            }
        }
        public string SoLuongYC
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
                if (_soLuongYC.ToString() == "" || value == null)
                {
                    _soLuongYC = 0;
                    PropertyHasChanged("SoLuongYC");
                }
                else if (_soLuongYC.ToString() != value)
                {
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
        public string NgaySD
        {
            get
            {
                CanReadProperty("NgaySD", true);
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngaySD.Text ;
            }
            set
            {
                CanWriteProperty("NgaySD", true);
                if (_ngaySD.Text  != value)
                {
                    _ngaySD.Text  = value;
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
        public String TenTM
        {
            get
            {
                CanReadProperty("TenTM", true);
                return _tenTM;
            }
            set
            {
                CanWriteProperty("TenTM", true);
                if (_tenTM != value)
                {
                    _tenTM = value;
                    PropertyHasChanged("TenTM");
                }
            }
        }
        public String TenDVT
        {
            get
            {
                CanReadProperty("TenDVT", true);
                return _tenDVT;
            }
            set
            {
                CanWriteProperty("TenDVT", true);
                if (_tenDVT != value)
                {
                    _tenDVT = value;
                    PropertyHasChanged("TenDVT");
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
        public string  TonCk
        {
            get
            {
                CanReadProperty("TonCk", true);
                if (_tonCk == 0)
                    return "0";
                else if (_tonCk - (int)(_tonCk) != 0)
                    return _tonCk.ToString("###,###.###");
                else
                    return _tonCk.ToString("###,###"); 
                
            }
            set
            {
                CanWriteProperty("TonCk", true);
                if (_tonCk.ToString () != value)
                {
                    _tonCk = decimal.Parse(value);
                    PropertyHasChanged("TonCk");
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
                if (!OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
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
        protected override void AddBusinessRules()
        {
            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "MaNCC");
           // ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("MaThuoc", 5));
            //ValidationRules.AddRule<NhapTra_C>(StringRequired<NhapTra_C>, "MaThuoc");

            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenTM", 350));
            ValidationRules.AddRule<NhapTra_C>(StringRequiredTenTM<NhapTra_C>, "TenTM");


        }
        //private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : NhapTra_C
        //{

        //    if (target._maThuoc == null || target._maThuoc.Trim().Length == 0)
        //    {
        //        e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
        //        return false;
        //    }
        //    else
        //        return true;
        //}

        private static bool StringRequiredTenTM<T>(T target, Csla.Validation.RuleArgs e) where T : NhapTra_C
        {

            if (target._tenTM == null || target._tenTM.Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }
		#endregion
		
		#region Factory Methods

        public static NhapTra_C NewNhapTra_C()
        {
            return new NhapTra_C();
            
        }

        public static NhapTra_C NewNhapTra_C(string idDMThuoc)
        {
            return new NhapTra_C(DMThuoc.GetDMThuoc(idDMThuoc));
        }

        public static NhapTra_C NewNhapTra_C(DMThuoc _DMThuoc)
        {
            return new NhapTra_C(_DMThuoc);
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static NhapTra_C GetNhapTra_C(String maThuoc, Byte sTT)
        {
            return DataPortal.Fetch<NhapTra_C>(new Criteria(maThuoc, sTT));
        }

        public static NhapTra_C GetNhapTra_C(SafeDataReader dr)
        {
            return new NhapTra_C(dr);
        }

		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public-++++ !!!

        protected internal NhapTra_C()
        { 
            //
        }
        protected NhapTra_C(DMThuoc pro)
        {
            MarkAsChild();
            _maThuoc = pro.MaThuoc;
            _tenTM = pro.TenTM;
        }
        protected NhapTra_C(string _idMaPNT, DMThuoc pro)
        {
            MarkAsChild();
            _MaPNT = _idMaPNT;            
            _maThuoc = pro.MaThuoc;
            _tenTM = pro.TenTM;
            _maMay = pro.MaMay;
            _huy = pro.Huy;
        }
        protected NhapTra_C(SafeDataReader dr)
        {
            MarkAsChild();
            _MaPNT = dr.GetString("MaPNT");
            _sTT = dr.GetDecimal("STT");
            _maThuoc = dr.GetString("MaThuoc");
            _soLuong = dr.GetDecimal("Soluong");
            _soLuongD = dr.GetDecimal("Soluong");
            _hanSD = dr.GetSmartDate("HanSD",false);
            _hanSDD = dr.GetSmartDate("HanSD", false);
            _soLo = dr.GetString("SoLo");
            _donGia = dr.GetDecimal("DonGia");
            _soLuongYC = dr.GetDecimal("SLyc");
            _giaBan = dr.GetDecimal("GiaBan");
            _huy = dr.GetBoolean("Huy");
            _ghiChu = dr.GetString("GhiChu");
            _maMay = dr.GetString("MaMay");
            _ngaySD = dr.GetSmartDate("NgaySD",false);
            _nguoiSD = dr.GetString("NguoiSD");
            _tenTM = dr.GetString("TenTM");
            _tenDVT = dr.GetString("TenDVT");
            _tenNguoiSD = dr.GetString("TenNguoiSD");
            _maQL = dr.GetString("MaQL");
            _tonCk = dr.GetDecimal("TonCK");
            if (dr.GetBoolean("Handung") != null) _handung = dr.GetBoolean("Handung");
            //_tonCk = HTC.Business.CategoryList.DMThuoc_TonKho.GetDMThuocTonKho(_maThuoc, _ngayn).TonCK;
               
            MarkOld();
        }

		#endregion

		#region Criteria
         	
		[Serializable()]
        protected class Criteria
        {
            private String _MaPNT;
            private String _MaThuoc;
            public String MaPNT
            {
                get
                {
                    return _MaPNT;
                }
            }
            public String MaThuoc
            {
                get
                {
                    return _MaThuoc;
                }
            }
           
            public Criteria(String MaPNT)
            {
                _MaPNT = MaPNT;
            }
            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_MaPNT.Equals(c._MaPNT))
                        return false;
                    return true;
                }
                return false;
            }
            private Byte _STT;
            public Byte STT
            {
                get
                {
                    return _STT;
                }
            }
            public Criteria(String MaPNT, Byte sTT)
            {
                _MaPNT = MaPNT;
                _STT = sTT;
            }
            public override int GetHashCode()
            {
                return string.Concat("Criteria", _MaPNT.ToString()).GetHashCode();
            }
        }

        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaPNT;
            public String MaPNT
            {
                get
                {
                    return _MaPNT;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaPNT)
            {
                _MaPNT = MaPNT;
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
            if (dr.GetString("MaPNT") != null) _MaPNT = dr.GetString("MaPNT");
            if(dr.GetString("MaThuoc")!=null) _maThuoc = dr.GetString("MaThuoc");
            if(dr.GetDecimal("SoLuong")!=null) _soLuong = dr.GetDecimal("SoLuong");
            if (dr.GetDecimal("SoLuong") != null) _soLuongD = dr.GetDecimal("SoLuong");
            if (dr.GetSmartDate("HanSD", false) != null) _hanSD = dr.GetSmartDate("HanSD", false);
            if (dr.GetSmartDate("HanSD", false) != null) _hanSDD = dr.GetSmartDate("HanSD", false);
            if (dr.GetBoolean("Handung") != null) _handung = dr.GetBoolean("Handung");
            //if (dr.GetSmartDate("HanSD", false) != null) _hanSD = dr.GetSmartDate("HanSD");
            //if (dr.GetSmartDate("HanSD", false) != null) _hanSDD = dr.GetSmartDate("HanSD");
            if(dr.GetString("SoLo")!=null) _soLo = dr.GetString("SoLo");
            if(dr.GetDecimal("DonGia")!=null) _donGia = dr.GetDecimal("DonGia");
            if(dr.GetDecimal("SoLuongYC")!=null) _soLuongYC = dr.GetDecimal("SoLuongYC");
            if(dr.GetDecimal("GiaBan")!=null) _giaBan = dr.GetDecimal("GiaBan");
            if(dr.GetBoolean("Huy")!=null) _huy = dr.GetBoolean("Huy");
            if(dr.GetString("GhiChu")!=null) _ghiChu = dr.GetString("GhiChu");
            if(dr.GetString("MaMay")!=null) _maMay = dr.GetString("MaMay");
            if(dr.GetSmartDate("NgaySD",false)!=null) _ngaySD = dr.GetSmartDate("NgaySD",false);
            if(dr.GetString("NguoiSD")!=null) _nguoiSD = dr.GetString("NguoiSD");
            if(dr.GetString("TenTM")!=null) _tenTM = dr.GetString("TenTM");
            if(dr.GetString("TenDVT")!=null) _tenDVT = dr.GetString("TenDVT");
            if(dr.GetString("TenNguoiSD")!=null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("MaQL") != null) _maQL = dr.GetString("MaQL");
            if (dr.GetDecimal("TonCK") != null) _tonCk = dr.GetDecimal("TonCK");
            try
            {
                _OrderNumber = dr.GetByte("STT");
            }
            catch
            { 
                //
            }
            
        }
        protected void DataPortal_Fetch(Criteria crit)
        {
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetNhapTra_C(crit.MaPNT, crit.STT))) 
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    MarkOld();
                    ValidationRules.CheckRules();
                }
            }
        }
        protected void DataPortal_Create()
        {
            _ngaySD.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }
        internal virtual void Insert(NhapTra bill)
        {
            
              //InsertNhapTra_C(String _MaPNT, String _maThuoc, Decimal _soLuong, SmartDate _hanSD,  Decimal _donGia,String _soLo,  Boolean Huy, String _ghiChu,String _maMay, String _nguoiSD);
            _MaPNT = bill.MaPNT;
            DataProvider.Instance().InsertNhapTra_C(bill.MaPNT, _maThuoc, _soLuong, _hanSD, _donGia, _soLo,_huy, _ghiChu,  _maMay, _nguoiSD , _soLuongYC,_giaBan);
            MarkOld();
        }
        internal virtual void Insert(NhapTraDT bill)
        {
            
              //InsertNhapTra_C(String _MaPNT, String _maThuoc, Decimal _soLuong, SmartDate _hanSD,  Decimal _donGia,String _soLo,  Boolean Huy, String _ghiChu,String _maMay, String _nguoiSD);
            _MaPNT = bill.MaPNT;
            DataProvider.Instance().InsertNhapTra_C(bill.MaPNT, _maThuoc, _soLuong, _hanSD, _donGia, _soLo, _huy, _ghiChu, _maMay, _nguoiSD , _soLuongYC,_giaBan );
            MarkOld();
        }
        internal virtual void Update(NhapTra bill)
        {
            if(IsDirty)
            {      
            
              
            DataProvider.Instance().UpdateNhapTra_C(bill.MaPNT, _sTT, _maThuoc, _soLuong, _hanSD, _soLo, _donGia,  _soLuongYC, _giaBan,  _huy,  _ghiChu, _nguoiSD ,  _maMay);
            }
        }
        internal virtual void Update(NhapTraDT bill)
        {
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateNhapTra_C(bill.MaPNT, _sTT, _maThuoc, _soLuong, _hanSD, _soLo, _donGia, _soLuongYC, _giaBan, _huy, _ghiChu, _nguoiSD , _maMay);
            }
        }
        internal void DeleteSelf(NhapTra packet)
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            DataProvider.Instance().DeleteNhapTra_C(_MaPNT,_sTT,_nguoiSD,_maMay);
            MarkNew();
            
        }
        internal void DeleteSelf(NhapTraDT packet)
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            DataProvider.Instance().DeleteNhapTra_C(_MaPNT, _sTT, _nguoiSD, _maMay);
            MarkNew();

        }
		#endregion
	}

}
