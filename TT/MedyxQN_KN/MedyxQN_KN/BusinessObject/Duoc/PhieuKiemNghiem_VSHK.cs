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
    public partial class PhieuKiemNghiem_VSHK : BusinessBase<PhieuKiemNghiem_VSHK>
    {
        #region Business Methods

        #region State Fields
      
        private String _MaKN = String.Empty;
        private Decimal _sTT;
        private SmartDate _NgayKQ = new SmartDate(true);
        private String _Dia = String.Empty;
        private String _VK101 = String.Empty;
        private String _VK102 = String.Empty;
        private String _VK103 = String.Empty;
        private String _VK104 = String.Empty;
        private String _VK105 = String.Empty;
        private String _VKN101 = String.Empty;
        private String _VKN102 = String.Empty;
        private String _VKN103 = String.Empty;
        private Boolean _huy = false;
        private String _ghiChu = String.Empty;
        private String _maMay = String.Empty;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private String _tenNguoiSD = String.Empty;
       
      
        #endregion

        #region Business Properties and Methods
       
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
        public String Dia
        {
            get
            {
                CanReadProperty("Dia", true);
                return _Dia;
            }
            set
            {
                CanWriteProperty("Dia", true);
                if (_Dia != value)
                {
                    _Dia = value;
                    PropertyHasChanged("Dia");
                }
            }
        }

        public String VK101
        {
            get
            {
                CanReadProperty("VK101", true);
                return _VK101;
            }
            set
            {
                CanWriteProperty("VK101", true);
                if (_VK101 != value)
                {
                    _VK101 = value;
                    PropertyHasChanged("VK101");
                }
            }
        }
        public String VK102
        {
            get
            {
                CanReadProperty("VK102", true);
                return _VK102;
            }
            set
            {
                CanWriteProperty("VK102", true);
                if (_VK102 != value)
                {
                    _VK102 = value;
                    PropertyHasChanged("VK102");
                }
            }
        }
        public String VK103
        {
            get
            {
                CanReadProperty("VK103", true);
                return _VK103;
            }
            set
            {
                CanWriteProperty("VK103", true);
                if (_VK103 != value)
                {
                    _VK103 = value;
                    PropertyHasChanged("VK103");
                }
            }
        }
        public String VK104
        {
            get
            {
                CanReadProperty("VK104", true);
                return _VK104;
            }
            set
            {
                CanWriteProperty("VK104", true);
                if (_VK104 != value)
                {
                    _VK104 = value;
                    PropertyHasChanged("VK104");
                }
            }
        }
        public String VK105
        {
            get
            {
                CanReadProperty("VK105", true);
                return _VK105;
            }
            set
            {
                CanWriteProperty("VK105", true);
                if (_VK105 != value)
                {
                    _VK105 = value;
                    PropertyHasChanged("VK105");
                }
            }
        }

        public String VKN101
        {
            get
            {
                CanReadProperty("VKN101", true);
                return _VKN101;
            }
            set
            {
                CanWriteProperty("VKN101", true);
                if (_VKN101 != value)
                {
                    _VKN101 = value;
                    PropertyHasChanged("VKN101");
                }
            }
        }
        public String VKN102
        {
            get
            {
                CanReadProperty("VKN102", true);
                return _VKN102;
            }
            set
            {
                CanWriteProperty("VKN102", true);
                if (_VKN102 != value)
                {
                    _VKN102 = value;
                    PropertyHasChanged("VKN102");
                }
            }
        }
        public String VKN103
        {
            get
            {
                CanReadProperty("VKN103", true);
                return _VKN103;
            }
            set
            {
                CanWriteProperty("VKN103", true);
                if (_VKN103 != value)
                {
                    _VKN103 = value;
                    PropertyHasChanged("VKN103");
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
        public String NgayKQ
        {
            get
            {
                CanReadProperty("NgayKQ", true);
                // _NgayKQ.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _NgayKQ.Text;
            }
            set
            {
                CanWriteProperty("NgayKQ", true);
                if (_NgayKQ != value)
                {
                    _NgayKQ.Text = value;
                    PropertyHasChanged("NgayKQ");
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

        public static PhieuKiemNghiem_VSHK NewPhieuKiemNghiem_VSHK()
        {
            return new PhieuKiemNghiem_VSHK();

        }

       

        public static PhieuKiemNghiem_VSHK GetPhieuKiemNghiem_VSHK(String maPhieuKiemNghiem, decimal sTT)
        {
            return DataPortal.Fetch<PhieuKiemNghiem_VSHK>(new Criteria(maPhieuKiemNghiem, sTT));
        }

        public static PhieuKiemNghiem_VSHK GetPhieuKiemNghiem_VSHK(SafeDataReader dr)
        {
            return new PhieuKiemNghiem_VSHK(dr);
        }

        public static void DeletePhieuKiemNghiem_VSHK(String _MaKN, decimal _sTT,string nguoisd,string mamay)
        {
            DataPortal.Delete(new OtherCriteria(_MaKN, _sTT,  nguoisd  , mamay));
        }
        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public-++++ !!!

        protected internal PhieuKiemNghiem_VSHK()
        {
            //
        }
      
      
        protected PhieuKiemNghiem_VSHK(SafeDataReader dr)
        {
            MarkAsChild();
            _MaKN = dr.GetString("MaKN");
           
            _sTT = dr.GetDecimal("STT");
            _NgayKQ = dr.GetSmartDate("NgayKQ", false);
            _Dia = dr.GetString("Dia");
            _VK102 = dr.GetString("VK102");
            _VK101 = dr.GetString("VK101");
            _VK103 = dr.GetString("VK103");
            _VK104 = dr.GetString("VK104");
            _VK105 = dr.GetString("VK105");
             _VKN102 = dr.GetString("VKN102");
             _VKN101 = dr.GetString("VKN101");
            _VKN103 = dr.GetString("VKN103");
            _huy = dr.GetBoolean("Huy");
            _ghiChu = dr.GetString("GhiChu");
            _maMay = dr.GetString("MaMay");
            _ngaySD = dr.GetSmartDate("NgaySD", false);
            _nguoiSD = dr.GetString("NguoiSD");
          
         
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
            if (dr.GetString("Dia") != null) _Dia = dr.GetString("Dia");
            if (dr.GetString("NgayKQ") != null) _NgayKQ = dr.GetSmartDate("NgayKQ", false);
          
            if (dr.GetString("VK102") != null) _VK102 = dr.GetString("VK102");
            if (dr.GetString("VK101") != null) _VK101 = dr.GetString("VK101");
            if (dr.GetString("VK103") != null) _VK103 = dr.GetString("VK103");
            if (dr.GetString("VK104") != null) _VK104 = dr.GetString("VK104");
            if (dr.GetString("VK105") != null) _VK105 = dr.GetString("VK105");
            if (dr.GetString("VKN102") != null) _VKN102 = dr.GetString("VKN102");
            if (dr.GetString("VKN101") != null) _VKN101 = dr.GetString("VKN101");
            if (dr.GetString("VKN103") != null) _VKN103 = dr.GetString("VKN103");
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
            //using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetPhieuKiemNghiem_VSHK(crit.MaKN, crit.STT))) 
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
            
              
           
            DataProvider.Instance().InsertPhieuKiemNghiem_VSHK(_MaKN, _NgayKQ , _Dia, _VK101, _VK102, _VK103, _VK104, _VK105, _VKN101, _VKN102, _VKN103,_ghiChu, _nguoiSD , _maMay);
            MarkOld();
        }

        internal virtual void Update()
        {
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdatePhieuKiemNghiem_VSHK(_MaKN, _sTT, _NgayKQ, _Dia, _VK101, _VK102, _VK103, _VK104, _VK105, _VKN101, _VKN102, _VKN103, _ghiChu, _huy, _nguoiSD , _maMay);
            }
        }
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            
            
              
            DataProvider.Instance().DeletePhieuKiemNghiem_VSHK(_MaKN, _sTT, _nguoiSD, _maMay);
            MarkNew();

        }
        #endregion
    }

}
