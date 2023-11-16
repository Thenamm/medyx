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
    public partial class PhieuKiemNghiem_MT : BusinessBase<PhieuKiemNghiem_MT>
    {
        #region Business Methods

        #region State Fields
      
        private String _MaKN = String.Empty;
        private Decimal _sTT;
        private String _MaMT = String.Empty;
        private String _TenMT = String.Empty;
        private String _KQ1 = String.Empty;
        private String _KQ2 = String.Empty;
       
        private Boolean _huy = false;
        private String _ghiChu = String.Empty;
        private String _maMay = String.Empty;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _MaCS = String.Empty;
     
      
        #endregion

        #region Business Properties and Methods
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
        public String MaMT
        {
            get
            {
                CanReadProperty("MaMT", true);
                return _MaMT;
            }
            set
            {
                CanWriteProperty("MaMT", true);
                if (_MaMT != value)
                {
                    _MaMT = value;
                    PropertyHasChanged("MaMT");
                }
            }
        }

        public String TenMT
        {
            get
            {
                CanReadProperty("TenMT", true);
                return _TenMT;
            }
            set
            {
                CanWriteProperty("TenMT", true);
                if (_TenMT != value)
                {
                    _TenMT = value;
                    PropertyHasChanged("TenMT");
                }
            }
        }
        public String KQ1
        {
            get
            {
                CanReadProperty("KQ1", true);
                return _KQ1;
            }
            set
            {
                CanWriteProperty("KQ1", true);
                if (_KQ1 != value)
                {
                    _KQ1 = value;
                    PropertyHasChanged("KQ1");
                }
            }
        }
        public String KQ2
        {
            get
            {
                CanReadProperty("KQ2", true);
                return _KQ2;
            }
            set
            {
                CanWriteProperty("KQ2", true);
                if (_KQ2 != value)
                {
                    _KQ2 = value;
                    PropertyHasChanged("KQ2");
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

        public static PhieuKiemNghiem_MT NewPhieuKiemNghiem_MT()
        {
            return new PhieuKiemNghiem_MT();

        }

       

        public static PhieuKiemNghiem_MT GetPhieuKiemNghiem_MT(String maPhieuKiemNghiem, decimal sTT)
        {
            return DataPortal.Fetch<PhieuKiemNghiem_MT>(new Criteria(maPhieuKiemNghiem, sTT));
        }

        public static PhieuKiemNghiem_MT GetPhieuKiemNghiem_MT(SafeDataReader dr)
        {
            return new PhieuKiemNghiem_MT(dr);
        }

        public static void DeletePhieuKiemNghiem_MT(String _MaKN, decimal _sTT,string mamay ,string nguoisd)
        {
            DataPortal.Delete(new OtherCriteria(_MaKN, _sTT, nguoisd  , mamay));
        }
        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public-++++ !!!

        protected internal PhieuKiemNghiem_MT()
        {
            //
        }
      
      
        protected PhieuKiemNghiem_MT(SafeDataReader dr)
        {
            MarkAsChild();
            _MaKN = dr.GetString("MaKN");
           
            _sTT = dr.GetDecimal("STT");
            _MaMT = dr.GetString("MaMT");
            _KQ1 = dr.GetString("KQ1");
            _TenMT = dr.GetString("TenMT");
            _KQ2 = dr.GetString("KQ2");
            
            _huy = dr.GetBoolean("Huy");
            _ghiChu = dr.GetString("GhiChu");
            _maMay = dr.GetString("MaMay");
            _ngaySD = dr.GetSmartDate("NgaySD", false);
            _nguoiSD = dr.GetString("NguoiSD");
            _MaCS = dr.GetString("MaCS");
         
            _tenNguoiSD = dr.GetString("TenNguoiSD");
          
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
            if (dr.GetDecimal("sTT") != null) _sTT = dr.GetDecimal("sTT");
            if (dr.GetString("MaMT") != null) _MaMT = dr.GetString("MaMT");
            if (dr.GetString("KQ1") != null) _KQ1 = dr.GetString("KQ1");
            if (dr.GetString("TenMT") != null) _TenMT = dr.GetString("TenMT");
            if (dr.GetString("KQ2") != null) _KQ2 = dr.GetString("KQ2");
            if (dr.GetString("MaCS") != null) _MaCS = dr.GetString("MaCS");
           
               if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetSmartDate("NgaySD", false) != null) _ngaySD = dr.GetSmartDate("NgaySD", false);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        
          
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
          
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
            //using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetPhieuKiemNghiem_MT(crit.MaKN, crit.STT))) 
            //{
            //    if (dr.Read())
            //    {
            //        Fetch(dr);
            //        MarkOld();
            //        ValidationRules.CheckRules();
            //    }
            //}
        }
        internal virtual void Insert()
        {
            
              
           
            DataProvider.Instance().InsertPhieuKiemNghiem_MT(_MaKN, _MaMT, _KQ1, _KQ2,_ghiChu, _nguoiSD , _maMay);
            MarkOld();
        }

        internal virtual void Update()
        {
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdatePhieuKiemNghiem_MT(_MaKN, _sTT, _MaMT,  _KQ1, _KQ2, _ghiChu, _huy, _nguoiSD , _maMay);
            }
        }
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            DataProvider.Instance().DeletePhieuKiemNghiem_MT(_MaKN, _sTT, _nguoiSD, _maMay);
            MarkNew();

        }
        #endregion
    }

}
