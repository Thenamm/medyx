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
    public partial class PhieuKiemNghiem_C : BusinessBase<PhieuKiemNghiem_C>
    {
        #region Business Methods

        #region State Fields
        private Decimal _donGiaTT = 0;
     
        private String _MaKN = String.Empty;
        private Decimal _sTT;
        private String _MaDG = String.Empty;
        private String _MaCS = String.Empty;
     
    
        private Boolean _huy = false;

        private String _ghiChu = String.Empty;
        private String _maMay = String.Empty;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private String _MaKQ = String.Empty;
        private String _TenDG = String.Empty;
        private String _TenCS = String.Empty;
        private String _TenKQ = String.Empty;
        private String _KetQua = String.Empty;

        private String _tenNguoiSD = String.Empty;
        private Decimal _GHTu = 0;
        private Decimal _GHDen = 0;
        private String _YeuCau = String.Empty;
        private String _nguoiTH = String.Empty;
      
        #endregion

        #region Business Properties and Methods
        public string GHTu
        {
            get
            {
                CanReadProperty("GHTu", true);
                if (_GHTu == 0)
                {
                    return "0";
                }
                else
                {
                    return _GHTu.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("GHTu", true);

                if (_GHTu.ToString() != value)
                {
                    _GHTu = decimal.Parse(value);
                    PropertyHasChanged("GHTu");
                }
            }
        }
        public string GHDen
        {
            get
            {
                CanReadProperty("GHDen", true);
                if (_GHDen == 0)
                {
                    return "0";
                }
                else
                {
                    return _GHDen.ToString("###,###.00");
                }
            }
            set
            {
                CanWriteProperty("GHDen", true);

                if (_GHDen.ToString() != value)
                {
                    _GHDen = decimal.Parse(value);
                    PropertyHasChanged("GHDen");
                }
            }
        }
        public String YeuCau
        {
            get
            {
                CanReadProperty("YeuCau", true);
                return _YeuCau;
            }
            set
            {
                CanWriteProperty("YeuCau", true);
                if (_YeuCau != value)
                {
                    _YeuCau = value;
                    PropertyHasChanged("YeuCau");
                }
            }
        }
        public Decimal DonGiaTT
        {
            get
            {
                CanReadProperty("DonGiaTT", true);
                return _donGiaTT;
            }
            set
            {
                CanWriteProperty("DonGiaTT", true);
                if (_donGiaTT != value)
                {
                    _donGiaTT = value;
                    PropertyHasChanged("DonGiaTT");
                }
            }
        }
        public String MaKN
        {
            get
            {
                CanReadProperty("MaKN", true);
                return _MaKN;
            }
            set
            {
                CanWriteProperty("MaKN", true);
                if (_MaKN != value)
                {
                    _MaKN = value;
                    PropertyHasChanged("MaKN");
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
        public String MaDG
        {
            get
            {
                CanReadProperty("MaDG", true);
                return _MaDG;
            }
            set
            {
                CanWriteProperty("MaDG", true);
                if (_MaDG != value)
                {
                    _MaDG = value;
                    PropertyHasChanged("MaDG");
                }
            }
        }

        public String MaCS
        {
            get
            {
                CanReadProperty("MaCS", true);
                return _MaCS;
            }
            set
            {
                CanWriteProperty("MaCS", true);
                if (_MaCS != value)
                {
                    _MaCS = value;
                    PropertyHasChanged("MaCS");
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
        public String NguoiTH
        {
            get
            {
                CanReadProperty("NguoiTH", true);
                return _nguoiTH;
            }
            set
            {
                CanWriteProperty("NguoiTH", true);
                if (_nguoiTH != value)
                {
                    _nguoiTH = value;
                    PropertyHasChanged("NguoiTH");
                }
            }
        }
        public String MaKQ
        {
            get
            {
                CanReadProperty("MaKQ", true);
                return _MaKQ;
            }
            set
            {
                CanWriteProperty("MaKQ", true);
                if (_MaKQ != value)
                {
                    _MaKQ = value;
                    PropertyHasChanged("MaKQ");
                }
            }
        }
        public String TenDG
        {
            get
            {
                CanReadProperty("TenDG", true);
                return _TenDG;
            }
            set
            {
                CanWriteProperty("TenDG", true);
                if (_TenDG != value)
                {
                    _TenDG = value;
                    PropertyHasChanged("TenDG");
                }
            }
        }
      
        public String TenCS
        {
            get
            {
                CanReadProperty("TenCS", true);
                return _TenCS;
            }
            set
            {
                CanWriteProperty("TenCS", true);
                if (_TenCS != value)
                {
                    _TenCS = value;
                    PropertyHasChanged("TenCS");
                }
            }
        }
        public String TenKQ
        {
            get
            {
                CanReadProperty("TenKQ", true);
                return _TenKQ;
            }
            set
            {
                CanWriteProperty("TenKQ", true);
                if (_TenKQ != value)
                {
                    _TenKQ = value;
                    PropertyHasChanged("TenKQ");
                }
            }
        }
        public String KetQua
        {
            get
            {
                CanReadProperty("KetQua", true);
                return _KetQua;
            }
            set
            {
                CanWriteProperty("KetQua", true);
                if (_KetQua != value)
                {
                    _KetQua = value;
                    PropertyHasChanged("KetQua");
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

        public static PhieuKiemNghiem_C NewPhieuKiemNghiem_C()
        {
            return new PhieuKiemNghiem_C();

        }

       

        public static PhieuKiemNghiem_C GetPhieuKiemNghiem_C(String maPhieuKiemNghiem, decimal sTT)
        {
            return DataPortal.Fetch<PhieuKiemNghiem_C>(new Criteria(maPhieuKiemNghiem, sTT));
        }

        public static PhieuKiemNghiem_C GetPhieuKiemNghiem_C(SafeDataReader dr)
        {
            return new PhieuKiemNghiem_C(dr);
        }

        public static void DeletePhieuKiemNghiem_C(String _MaKN, decimal _sTT,string mamay,string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(_MaKN, _sTT, nguoihuy, mamay));
        }
        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public-++++ !!!

        protected internal PhieuKiemNghiem_C()
        {
            //
        }
      
      
        protected PhieuKiemNghiem_C(SafeDataReader dr)
        {
            MarkAsChild();
            _MaKN = dr.GetString("MaKN");
            _donGiaTT = dr.GetDecimal("DonGiaTT");
         
            _sTT = dr.GetDecimal("STT");
            _MaDG = dr.GetString("MaDG");
            _MaCS = dr.GetString("MaCS");
            _huy = dr.GetBoolean("Huy");
            _ghiChu = dr.GetString("GhiChu");
            _maMay = dr.GetString("MaMay");
            _ngaySD = dr.GetSmartDate("NgaySD", false);
            _nguoiSD = dr.GetString("NguoiSD");
            _nguoiTH = dr.GetString("NguoiTH");
            _MaKQ = dr.GetString("MaKQ");
            _TenDG = dr.GetString("TenDG");
           
            _TenCS = dr.GetString("TenCS");
            _KetQua = dr.GetString("KetQua");
            _TenKQ = dr.GetString("TenKQ");
         
            _tenNguoiSD = dr.GetString("TenNguoiSD");
            _YeuCau = dr.GetString("YeuCau");
             _GHTu = dr.GetDecimal("GHTu");
             _GHDen = dr.GetDecimal("GHDen");
            MarkOld();
        }

        #endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
            private String _MaKN;
            public String MaKN
            {
                get
                {
                    return _MaKN;
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
            public Criteria(String MaKN, decimal sTT)
            {
                _MaKN = MaKN;
                _STT = sTT;
            }
            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_MaKN.Equals(c._MaKN))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _MaKN.ToString()).GetHashCode();
            }
        }

        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaKN;
            public String MaKN
            {
                get
                {
                    return _MaKN;
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
            public OtherCriteria(String MaKN, decimal sTT, String Mamay, String Nguoisd)
            {
                _MaKN = MaKN;
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
            if (dr.GetString("MaKN") != null) _MaKN = dr.GetString("MaKN");
            if (dr.GetString("MaCS") != null) _MaCS = dr.GetString("MaCS");
            if (dr.GetDecimal("sTT") != null) _sTT = dr.GetDecimal("sTT");
            if (dr.GetString("MaDG") != null) _MaDG = dr.GetString("MaDG");
               if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetSmartDate("NgaySD", false) != null) _ngaySD = dr.GetSmartDate("NgaySD", false);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("NguoiTH") != null) _nguoiTH = dr.GetString("NguoiTH");
            if (dr.GetString("MaKQ") != null) _MaKQ = dr.GetString("MaKQ");
            if (dr.GetString("TenDG") != null) _TenDG = dr.GetString("TenDG");
            if (dr.GetDecimal("DonGiaTT") != null) _donGiaTT = dr.GetDecimal("DonGiaTT");
         
            if (dr.GetString("TenCS") != null) _TenCS = dr.GetString("TenCS");
            if (dr.GetString("TenKQ") != null) _TenKQ = dr.GetString("TenKQ");
            if (dr.GetString("KetQua") != null) _KetQua = dr.GetString("KetQua");
          
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("YeuCau") != null) _YeuCau = dr.GetString("YeuCau");
            if (dr.GetDecimal("GHTu") != null) _GHTu = dr.GetDecimal("GHTu");
            if (dr.GetDecimal("GHDen") != null) _GHDen = dr.GetDecimal("GHDen");
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
            //using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetPhieuKiemNghiem_C(crit.MaKN, crit.STT))) 
            //{
            //    if (dr.Read())
            //    {
            //        Fetch(dr);
            //        MarkOld();
            //        ValidationRules.CheckRules();
            //    }
            //}
        }
        internal virtual void Insert(PhieuKiemNghiem bill)
        {
            
              
            _MaKN = bill.MaKN;
            DataProvider.Instance().InsertPhieuKiemNghiem_C(bill.MaKN, _MaDG, _MaCS, _MaKQ, _KetQua, _donGiaTT, _ghiChu,_nguoiTH , _nguoiSD , _maMay);
            MarkOld();
        }

        internal virtual void Update(PhieuKiemNghiem bill)
        {
            if (IsDirty)
            {


                DataProvider.Instance().UpdatePhieuKiemNghiem_C(bill.MaKN, _sTT, _MaDG, _MaCS, _MaKQ, _KetQua, _donGiaTT, _ghiChu,_nguoiTH, _huy,  _nguoiSD, _maMay);
            }
        }
        internal void DeleteSelf(PhieuKiemNghiem packet)
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            
            
        
            DataProvider.Instance().DeletePhieuKiemNghiem_C(_MaKN, _sTT, _nguoiSD, _maMay);
            MarkNew();

        }
        #endregion
    }

}
