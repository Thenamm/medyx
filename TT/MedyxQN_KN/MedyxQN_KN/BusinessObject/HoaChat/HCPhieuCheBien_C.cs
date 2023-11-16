using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using HTC.Business;
using HTC.Business.HoaChat;
using HTC.Business.CategoryList;

namespace HTC.Business.HoaChat
{

    [Serializable()]
    public partial class HCPhieuCheBien_C : BusinessBase<HCPhieuCheBien_C>
    {
        #region Business Methods

        #region State Fields

        private String _MaCB = String.Empty;
        private Decimal _sTT;
        private String _maHC = String.Empty;
      
        private Decimal _soLuong;
     
        private Decimal _donGia;
        private Decimal _soLuongYC;
        private Decimal _giaBan;
        private Boolean _huy = false;
        private String _ghiChu = String.Empty;
        private String _maMay = String.Empty;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private String _maQL = String.Empty;
        private String _tenTM = String.Empty;
        private String _tenDVT = String.Empty;

        private String _tenNguoiSD = String.Empty;
        private Decimal _TonCK = 0;
        private Decimal _TonCKDT = 0;
      
      
        #endregion

        #region Business Properties and Methods


       
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
        public String MaCB
        {
            get
            {
                CanReadProperty("MaCB", true);
                return _MaCB;
            }
            set
            {
                CanWriteProperty("MaCB", true);
                if (_MaCB != value)
                {
                    _MaCB = value;
                    PropertyHasChanged("MaCB");
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
        public String maHC
        {
            get
            {
                CanReadProperty("maHC", true);
                return _maHC;
            }
            set
            {
                CanWriteProperty("maHC", true);
                if (_maHC != value)
                {
                    _maHC = value;
                    PropertyHasChanged("maHC");
                }
            }
        }
      
        public String soLuong
        {
            get
            {
                CanReadProperty("soLuong", true);
                if (_soLuong == 0)
                    return "0";
                else if (_soLuong - (int)(_soLuong) != 0)
                    return _soLuong.ToString("###,###.###");
                else
                    return _soLuong.ToString("###,###");
            }
            set
            {
                CanWriteProperty("soLuong", true);
                if (_soLuong.ToString() != value)
                {
                    if (value == "")
                        _soLuong = 0;
                    else
                        _soLuong = decimal.Parse(value);

                    PropertyHasChanged("soLuong");
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
       

        protected override Object GetIdValue()
        {
            return _sTT;
        }

        #endregion
        #endregion

        #region Business Object Rules and Validation

        #endregion

        #region Factory Methods

        public static HCPhieuCheBien_C NewHCPhieuCheBien_C()
        {
            return new HCPhieuCheBien_C();

        }

        public static HCPhieuCheBien_C NewHCPhieuCheBien_C(string idDMThuoc)
        {
            return new HCPhieuCheBien_C(DMHoaChat.GetDMHoaChat(idDMThuoc));
        }

        public static HCPhieuCheBien_C NewHCPhieuCheBien_C(DMHoaChat _DMHoaChat)
        {
            return new HCPhieuCheBien_C(_DMHoaChat);
        }

        public static HCPhieuCheBien_C GetHCPhieuCheBien_C(String maHCPhieuCheBien, decimal sTT)
        {
            return DataPortal.Fetch<HCPhieuCheBien_C>(new Criteria(maHCPhieuCheBien, sTT));
        }

        public static HCPhieuCheBien_C GetHCPhieuCheBien_C(SafeDataReader dr)
        {
            return new HCPhieuCheBien_C(dr);
        }

        public static void DeleteHCPhieuCheBien_C(String _maPN, decimal _sTT, string nguoisd, string mamay)
        {
            DataPortal.Delete(new OtherCriteria(_maPN, _sTT, nguoisd  , mamay));
        }
        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public-++++ !!!

        protected internal HCPhieuCheBien_C()
        {
            //
        }
        protected HCPhieuCheBien_C(DMHoaChat pro)
        {
            MarkAsChild();
            _maHC = pro.MaHC;
            _tenTM = pro.TenTM;
        }
        protected HCPhieuCheBien_C(string _idMaCB, DMHoaChat pro)
        {
            MarkAsChild();
            _MaCB = _idMaCB;
            _maHC = pro.MaHC;
            _tenTM = pro.TenTM;
            _maMay = pro.MaMay;
            _huy = pro.Huy;
            _nguoiSD = pro.NguoiSD;
        }
        protected HCPhieuCheBien_C(SafeDataReader dr)
        {
            MarkAsChild();
            _MaCB = dr.GetString("MaCB");
        
            _sTT = Decimal.Parse(dr["STT"].ToString());
            _maHC = dr.GetString("maHC");
            _soLuong = dr.GetDecimal("soLuong");
          
            _donGia = dr.GetDecimal("DonGia");
            _soLuongYC = dr.GetDecimal("SLyc");
            _giaBan = dr.GetDecimal("GiaBan");
            _huy = dr.GetBoolean("Huy");
            _ghiChu = dr.GetString("GhiChu");
            _maMay = dr.GetString("MaMay");
            _ngaySD = dr.GetSmartDate("NgaySD", false);
            _nguoiSD = dr.GetString("NguoiSD");
            _maQL = dr.GetString("MaQL");
            _tenTM = dr.GetString("TenTM");
           
            _tenDVT = dr.GetString("TenDVT");
         
            _tenNguoiSD = dr.GetString("TenNguoiSD");
            _TonCK = dr.GetDecimal("TonCK");
            _TonCKDT = dr.GetDecimal("TonCKDT");
          
            MarkOld();
        }

        #endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
            private String _MaCB;
            public String MaCB
            {
                get
                {
                    return _MaCB;
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
            public Criteria(String MaCB, decimal sTT)
            {
                _MaCB = MaCB;
                _STT = sTT;
            }
            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_MaCB.Equals(c._MaCB))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _MaCB.ToString()).GetHashCode();
            }
        }

        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaCB;
            public String MaCB
            {
                get
                {
                    return _MaCB;
                }
            }
            private decimal _sTT;
            public decimal sTT
            {
                get
                {
                    return _sTT;
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
            public OtherCriteria(String MaCB, decimal sTT, String Mamay, String Nguoisd)
            {
                _MaCB = MaCB;
                _sTT = sTT;
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
            if (dr.GetString("MaCB") != null) _MaCB = dr.GetString("MaCB");
      
            if (dr.GetString("maHC") != null) _maHC = dr.GetString("maHC");
            if (dr.GetDecimal("soLuong") != null) _soLuong = dr.GetDecimal("soLuong");
         
        
            if (dr.GetDecimal("DonGia") != null) _donGia = dr.GetDecimal("DonGia");
            if (dr.GetDecimal("SoLuongYC") != null) _soLuongYC = dr.GetDecimal("SoLuongYC");
            if (dr.GetDecimal("GiaBan") != null) _giaBan = dr.GetDecimal("GiaBan");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetSmartDate("NgaySD", false) != null) _ngaySD = dr.GetSmartDate("NgaySD", false);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("MaQL") != null) _maQL = dr.GetString("MaQL");
            if (dr.GetString("TenTM") != null) _tenTM = dr.GetString("TenTM");
        
            if (dr.GetString("TenDVT") != null) _tenDVT = dr.GetString("TenDVT");
          
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetDecimal("TonCK") != null) _TonCK = dr.GetDecimal("TonCK");
            if (dr.GetDecimal("TonCKDT") != null) _TonCKDT = dr.GetDecimal("TonCKDT");
          
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
            //using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetHCPhieuCheBien_C(crit.MaCB, crit.STT))) 
            //{
            //    if (dr.Read())
            //    {
            //        Fetch(dr);
            //        MarkOld();
            //        ValidationRules.CheckRules();
            //    }
            //}
        }
        internal virtual void Insert(HCPhieuCheBien bill)
        {
            
              
            _MaCB = bill.MaCB;
            DataProvider.Instance().InsertHCPhieuCheBien_C(bill.MaCB, _maHC, _soLuong, _donGia, _soLuongYC, _giaBan, _ghiChu, _nguoiSD , _maMay);
            MarkOld();
        }

        internal virtual void Update(HCPhieuCheBien bill)
        {
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateHCPhieuCheBien_C(bill.MaCB, _sTT, _maHC, _soLuong, _donGia, _soLuongYC, _giaBan, _huy, _ghiChu, _nguoiSD , _maMay);
            }
        }
        internal void DeleteSelf(HCPhieuCheBien packet)
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            
            
            
            DataProvider.Instance().DeleteHCPhieuCheBien_C(_MaCB, _sTT, _nguoiSD, _maMay);
            MarkNew();

        }
        #endregion
    }

}
