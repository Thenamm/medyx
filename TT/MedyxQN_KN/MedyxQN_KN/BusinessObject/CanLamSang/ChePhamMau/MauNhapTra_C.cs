using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using HTC.Business;
using HTC.Business.CanLamSang;
using HTC.Business.CategoryList;
//


namespace HTC.Business.CanLamSang
{	
	
	[Serializable()]
	public partial class MauNhapTra_C : BusinessBase<MauNhapTra_C>
	{
		#region Business Methods
		
		#region State Fields
		
        private String _MaPNT = String.Empty;
        private Decimal _sTT=0;
        private String _maCPMau=String.Empty;
        private Decimal _soLuong=0;
        private Decimal _soLuongD = 0;
        private SmartDate _hanSD = new SmartDate(false);
        private SmartDate _hanSDD = new SmartDate(false);
        private String _soLo = String.Empty;
        private Decimal _donGia=0;
        private Decimal _soLuongYC=0;
        private Decimal _giaBan=0;
        private Boolean _huy=false;
        private String _ghiChu = String.Empty;
        private String _maMay = String.Empty;
        private SmartDate _ngaySD =new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private String _TenTM = String.Empty;
        private String _tenDVT = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private int _OrderNumber;
        private Decimal _tonCk = 0;
        private Boolean _handung = false;
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
        public String MaCPMau
        {
            get
            {
                CanReadProperty("MaCPMau", true);
                return _maCPMau;
            }
            set
            {
                CanWriteProperty("MaCPMau", true);
                if (_maCPMau != value)
                {
                    _maCPMau = value;
                    PropertyHasChanged("MaCPMau");
                }
            }
        }
        //public Decimal SoLuong
        //{
        //    get
        //    {
        //        CanReadProperty("SoLuong", true);
        //        return _soLuong;
        //    }
        //    set
        //    {
        //        CanWriteProperty("SoLuong", true);
        //        if (_soLuong != value)
        //        {
        //            _soLuong = value;
        //            PropertyHasChanged("SoLuong");
        //        }
        //    }
        //}
        public string Soluong
        {
            get
            {
                CanReadProperty("Soluong", true);
                if (_soLuong == 0)
                {
                    return "0";
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
                //_hanSD.FormatString = "MM/dd/yyyy";
                return _hanSD.Text;
            }
            set
            {
                CanWriteProperty("HanSD", true);

                if (!_hanSD.Equals(value))
                {
                    //  _hanSD.FormatString = "MM/dd/yyyy";
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
        //public Decimal SoLuongYC
        //{
        //    get
        //    {
        //        CanReadProperty("SoLuongYC", true);
        //        return _soLuongYC;
        //    }
        //    set
        //    {
        //        CanWriteProperty("SoLuongYC", true);
        //        if (_soLuongYC != value)
        //        {
        //            _soLuongYC = value;
        //            PropertyHasChanged("SoLuongYC");
        //        }
        //    }
        //}
        public string SoluongYC
        {
            get
            {
                CanReadProperty("SoluongYC", true);
                if (_soLuongYC == 0)
                {
                    return "0";
                }
                else
                {
                    return _soLuongYC.ToString("###,###");
                }
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
        public String TenTM
        {
            get
            {
                CanReadProperty("TenTM", true);
                return _TenTM;
            }
            set
            {
                CanWriteProperty("TenTM", true);
                if (_TenTM != value)
                {
                    _TenTM = value;
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
        public Decimal TonCk
        {
            get
            {
                CanReadProperty("TonCk", true);
                return _tonCk;
            }
            set
            {
                CanWriteProperty("TonCk", true);
                if (_tonCk != value)
                {
                    _tonCk = value;
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
           // ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("MaCPMau", 5));
            //ValidationRules.AddRule<MauNhapTra_C>(StringRequired<MauNhapTra_C>, "MaCPMau");

            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenTM", 350));
            ValidationRules.AddRule<MauNhapTra_C>(StringRequiredTenTM<MauNhapTra_C>, "TenTM");


        }
        //private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : MauNhapTra_C
        //{

        //    if (target._maCPMau == null || target._maCPMau.Trim().Length == 0)
        //    {
        //        e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
        //        return false;
        //    }
        //    else
        //        return true;
        //}

        private static bool StringRequiredTenTM<T>(T target, Csla.Validation.RuleArgs e) where T : MauNhapTra_C
        {

            if (target._TenTM == null || target._TenTM.Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }
		#endregion
		
		#region Factory Methods

        public static MauNhapTra_C NewMauNhapTra_C()
        {
            return new MauNhapTra_C();
            
        }

        public static MauNhapTra_C NewMauNhapTra_C(string idDMChePhamMau)
        {
            return new MauNhapTra_C(DMChePhamMau.GetDMChePhamMau(idDMChePhamMau));
        }

        public static MauNhapTra_C NewMauNhapTra_C(DMChePhamMau _DMChePhamMau)
        {
            return new MauNhapTra_C(_DMChePhamMau);
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static MauNhapTra_C GetMauNhapTra_C(String maCPMau, Byte sTT)
        {
            return DataPortal.Fetch<MauNhapTra_C>(new Criteria(maCPMau, sTT));
        }

        public static MauNhapTra_C GetMauNhapTra_C(SafeDataReader dr)
        {
            return new MauNhapTra_C(dr);
        }

		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public-++++ !!!

        protected internal MauNhapTra_C()
        { 
            //
        }
        protected MauNhapTra_C(DMChePhamMau pro)
        {
            MarkAsChild();
            _maCPMau = pro.MaCPMau;
            _TenTM = pro.TenCPMau ;
        }
        protected MauNhapTra_C(string _idMaPNT, DMChePhamMau pro)
        {
            MarkAsChild();
            _MaPNT = _idMaPNT;            
            _maCPMau = pro.MaCPMau;
            _TenTM = pro.TenCPMau ;
            _maMay = pro.MaMay;
            _huy = pro.Huy;
        }
        protected MauNhapTra_C(SafeDataReader dr)
        {
            MarkAsChild();
            _MaPNT = dr.GetString("MaPNT");
            _sTT = dr.GetDecimal("STT");
            _maCPMau = dr.GetString("MaCPMau");
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
            _TenTM = dr.GetString("TenTM");
            _tenDVT = dr.GetString("TenDVT");
            _tenNguoiSD = dr.GetString("TenNguoiSD");
            _tonCk = dr.GetDecimal("TonCK");
            if (dr.GetBoolean("Handung") != null) _handung = dr.GetBoolean("Handung");
            //_tonCk = HTC.Business.CategoryList.DMChePhamMau_TonKho.GetDMChePhamMauTonKho(_maCPMau, _ngayn).TonCK;
               
            MarkOld();
        }

		#endregion

		#region Criteria
         	
		[Serializable()]
        protected class Criteria
        {
            private String _MaPNT;
            public String MaPNT
            {
                get
                {
                    return _MaPNT;
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
            if(dr.GetString("MaCPMau")!=null) _maCPMau = dr.GetString("MaCPMau");
            if(dr.GetDecimal("SoLuong")!=null) _soLuong = dr.GetDecimal("SoLuong");
            if (dr.GetDecimal("SoLuong") != null) _soLuongD = dr.GetDecimal("SoLuong");
            if (dr.GetSmartDate("HanSD", false) != null) _hanSD = dr.GetSmartDate("HanSD", false);
            if (dr.GetSmartDate("HanSD", false) != null) _hanSDD = dr.GetSmartDate("HanSD", false);
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
            if(dr.GetString("TenTM")!=null) _TenTM = dr.GetString("TenTM");
            if(dr.GetString("TenDVT")!=null) _tenDVT = dr.GetString("TenDVT");
            if(dr.GetString("TenNguoiSD")!=null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetDecimal("TonCK") != null) _tonCk = dr.GetDecimal("TonCK");
            if (dr.GetBoolean("Handung") != null) _handung = dr.GetBoolean("Handung");
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetMauNhapTra_C(crit.MaPNT, crit.STT))) 
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
        internal virtual void Insert(MauNhapTra bill)
        {
            
              //InsertMauNhapTra_C(String _MaPNT, String _maCPMau, Decimal _soLuong, SmartDate _hanSD,  Decimal _donGia,String _soLo,  Boolean Huy, String _ghiChu,String _maMay, String _nguoiSD);
            bill.MaPNT = DataProvider.Instance().InsertMauNhapTra_C(bill.MaPNT, _maCPMau, _soLuong, _hanSD, _donGia, _soLo,_huy, _ghiChu,  _maMay, _nguoiSD , _soLuongYC);
        }

        internal virtual void Update(MauNhapTra bill)
        {
            if(IsDirty)
            {      
            
              
            DataProvider.Instance().UpdateMauNhapTra_C(bill.MaPNT, _sTT, _maCPMau, _soLuong, _hanSD, _soLo, _donGia,  _soLuongYC, _giaBan,  _huy,  _ghiChu, _nguoiSD ,  _maMay);
            }
        }
        internal void DeleteSelf(MauNhapTra packet)
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            DataProvider.Instance().DeleteMauNhapTra_C(_MaPNT,_sTT,_nguoiSD,_maMay);
            MarkNew();
            
        }
		#endregion
	}

}
