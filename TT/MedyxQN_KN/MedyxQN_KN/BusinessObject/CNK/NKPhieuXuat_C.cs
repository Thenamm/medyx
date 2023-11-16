using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using HTC.Business;
using HTC.Business.CNK;
using HTC.Business.CategoryList;

namespace HTC.Business.CNK
{	
	
	[Serializable()]
	public partial class NKPhieuXuat_C : BusinessBase<NKPhieuXuat_C>
	{
		#region Business Methods
		
		#region State Fields
		
        private String _maPX = String.Empty;
        private Decimal _sTT;
        private String _maVT=String.Empty;
        private Decimal _soLuong  ;
        private SmartDate _hanSD = new SmartDate(false);
        private String _soLo = String.Empty;
        private Decimal _donGia;
        private Decimal _soLuongYC ;
        private Decimal _giaBan;
        private Boolean _huy=false;
        private String _ghiChu = String.Empty;
        private String _maMay = String.Empty;
        private SmartDate _ngaySD =new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private String _tenTM = String.Empty;
        private String _tenDVT = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _maQL = String.Empty;
        private SmartDate _hanSDD = new SmartDate(false);
        private Decimal _TonCK = 0;
        private Decimal _TonCKDT = 0;
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
        public String HanSDD
        {
            get
            {
                CanReadProperty("HanSD", true);
                _hanSDD.FormatString = "dd/MM/yyyy";
                _hanSDD = _hanSD;
                return _hanSDD.Text;
            }

        }
        public String TonCK
        {
            get
            {
                CanReadProperty("TonCK", true);
                if (_TonCK == 0)
                    return "0";
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
		public String MaPX
		{
			get 
			{
				CanReadProperty("MaPX", true);
				return _maPX;
			}
			set 
			{
                CanWriteProperty("MaPX", true);
                if (_maPX != value) 
				{
                    _maPX = value;
                    PropertyHasChanged("MaPX");
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
        public String MaVT
        {
            get
            {
                CanReadProperty("MaVT", true);
                return _maVT;
            }
            set
            {
                CanWriteProperty("MaVT", true);
                if (_maVT != value)
                {
                    _maVT = value;
                    PropertyHasChanged("MaVT");
                }
            }
        }
        public String SoLuong
        {
            get
            {
                CanReadProperty("SoLuong", true);
                if (_soLuong == 0)
                    return "0";
                else
                return _soLuong.ToString("###,###");
            }
            set
            {
                CanWriteProperty("SoLuong", true);
                if (_soLuong.ToString() != value)
                {
                if (value == "")
                        _soLuong = 0;
                    else
                        _soLuong = decimal.Parse(value);

                    PropertyHasChanged("SoLuong");
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
        public String SoLuongYC
        {
            get
            {
                CanReadProperty("SoLuongYC", true);
                if (_soLuongYC == 0)
                    return "0";
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
        

		protected override Object GetIdValue()
		{
			return _sTT;
		}
		
		#endregion
		#endregion
				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods

        public static NKPhieuXuat_C NewNKPhieuXuat_C()
        {
            return new NKPhieuXuat_C();
            
        }

        public static NKPhieuXuat_C NewNKPhieuXuat_C(string idDMCNK)
        {
            return new NKPhieuXuat_C(DMCNK.GetDMCNK(idDMCNK));
        }

        public static NKPhieuXuat_C NewNKPhieuXuat_C(DMCNK _DMCNK)
        {
            return new NKPhieuXuat_C(_DMCNK);
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        
        public static NKPhieuXuat_C GetNKPhieuXuat_C(String maNKPhieuXuat, decimal sTT)
        {
            return DataPortal.Fetch<NKPhieuXuat_C>(new Criteria(maNKPhieuXuat, sTT));
        }

        public static NKPhieuXuat_C GetNKPhieuXuat_C(SafeDataReader dr)
        {
            return new NKPhieuXuat_C(dr);
        }

        public static void DeleteNKPhieuXuat_C(String _maPN, decimal _sTT,string _nguoisd,string _mamay)
        {
            DataPortal.Delete(new OtherCriteria(_maPN, _sTT, _nguoisd, _mamay));
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public-++++ !!!

        protected internal NKPhieuXuat_C()
        { 
            //
        }
        protected NKPhieuXuat_C(DMCNK pro)
        {
            MarkAsChild();
            _maVT = pro.MaVT;
            _tenTM = pro.TenTM;
        }
        protected NKPhieuXuat_C(string _idMaPX, DMCNK pro)
        {
            MarkAsChild();
            _maPX = _idMaPX;            
            _maVT = pro.MaVT;
            _tenTM = pro.TenTM;
            _maMay = pro.MaMay;
            _huy = pro.Huy;
            _nguoiSD = pro.NguoiSD;  
        }
        protected NKPhieuXuat_C(SafeDataReader dr)
        {
            MarkAsChild();
            _maPX = dr.GetString("MaPX");
            _sTT = dr.GetDecimal("STT");
            _maVT = dr.GetString("MaVT");
            _soLuong = dr.GetDecimal("Soluong");
            _hanSD = dr.GetSmartDate("HanSD",false);
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
            private String _maPX;
            public String MaPX
            {
                get
                {
                    return _maPX;
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
            public Criteria(String maPX,decimal sTT)
            {
                _maPX = maPX;
                _STT = sTT;
            }
            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maPX.Equals(c._maPX))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maPX.ToString()).GetHashCode();
            }
        }

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maPX;
            public String MaPX
            {
                get
                {
                    return _maPX;
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
            public OtherCriteria( String maPX, decimal sTT ,String Mamay, String Nguoisd)
            {
                _maPX = maPX;
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
            if (dr.GetString("MaPX") != null) _maPX = dr.GetString("MaPX");
            if(dr.GetString("MaVT")!=null) _maVT = dr.GetString("MaVT");
            if(dr.GetDecimal("SoLuong")!=null) _soLuong = dr.GetDecimal("SoLuong");
            if(dr.GetSmartDate("HanSD",false)!=null) _hanSD = dr.GetSmartDate("HanSD",false);
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
            if (dr.GetString("MaQL") != null) _maQL  = dr.GetString("MaQL");
            if (dr.GetDecimal("TonCK") != null) _TonCK = dr.GetDecimal("TonCK");
            if (dr.GetDecimal("TonCKDT") != null) _TonCKDT = dr.GetDecimal("TonCKDT");
            if (dr.GetBoolean("Handung") != null) _handung = dr.GetBoolean("Handung");
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
            //using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetNKPhieuXuat_C(crit.MaPX, crit.STT))) 
            //{
            //    if (dr.Read())
            //    {
            //        Fetch(dr);
            //        MarkOld();
            //        ValidationRules.CheckRules();
            //    }
            //}
        }
        internal virtual void Insert(NKPhieuXuat bill)
        {
            
              
            bill.MaPX = DataProvider.Instance().InsertNKPhieuXuat_C(bill.MaPX, _maVT, _soLuong, _hanSD, _soLo, _donGia, _soLuongYC, _giaBan, _ghiChu, _nguoiSD, _maMay);
            MarkOld();
        }

        internal virtual void Update(NKPhieuXuat bill)
        {
            if(IsDirty)
            {      
            
              
            DataProvider.Instance().UpdateNKPhieuXuat_C(bill.MaPX, _sTT, _maVT, _soLuong, _hanSD, _soLo, _donGia,  _soLuongYC, _giaBan,  _huy,  _ghiChu,  _nguoiSD,  _maMay);
            }
        }
        internal void DeleteSelf(NKPhieuXuat packet)
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            
            
          
            DataProvider.Instance().DeleteNKPhieuXuat_C(_maPX,_sTT,_nguoiSD,_maMay);
            MarkNew();
            
        }
		#endregion
	}

}
