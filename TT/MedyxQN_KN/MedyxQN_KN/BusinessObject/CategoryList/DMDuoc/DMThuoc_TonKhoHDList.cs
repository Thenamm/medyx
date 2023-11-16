using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMThuoc_TonKhoHDList : ReadOnlyListBase<DMThuoc_TonKhoHDList, DMThuoc_TonKhoHD>
    {
        #region Factory Methods
        public DMThuoc_TonKhoHD Containsfind(string mathuoc, string solo, string hansd)
        {
            foreach (DMThuoc_TonKhoHD obj in this)
                if (solo == "" && hansd == "")
                {
                    if (obj.MaThuoc == mathuoc)
                        return obj;
                }
                else if ((obj.MaThuoc == mathuoc) && (obj.SoLo == solo) && (obj.HanSD == hansd))
                    return obj;
            return null;

        }
        public static DMThuoc_TonKhoHDList GetAllDMThuocTonKho(String maKho, DateTime thang)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoHDList>(new Criteria(0, maKho, thang, "", "", DateTime.Parse("01/01/1900")));
        }
        public static DMThuoc_TonKhoHDList GetAllDMThuocTonKho(String maKho, DateTime thang,string dk)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoHDList>(new Criteria(0, maKho, thang, dk, "", DateTime.Parse("01/01/1900")));
        }
        public static DMThuoc_TonKhoHDList FindDMThuocTonKhoMa(String maKho, DateTime thang, String Ma)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoHDList>(new Criteria(1, maKho, thang, Ma, "", DateTime.Parse("01/01/1900")));
        }
        public static DMThuoc_TonKhoHDList FindDMThuocTonKhoTen(String maKho, DateTime thang, String Ten)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoHDList>(new Criteria(2, maKho, thang, Ten, "", DateTime.Parse("01/01/1900")));
        }
        public static DMThuoc_TonKhoHDList FindDMThuocTonKhoTenD(String maKho, DateTime thang, String Ten)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoHDList>(new Criteria(3, maKho, thang, Ten, "", DateTime.Parse("01/01/1900")));
        }
     
        public static DMThuoc_TonKhoHDList GetAllDMThuocTonKho(String maKho, DateTime thang, string solo, DateTime hansd)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoHDList>(new Criteria(0, maKho, thang, "", solo, hansd));
        }
        public static DMThuoc_TonKhoHDList FindDMThuocTonKhoMa(String maKho, DateTime thang, String Ma, string solo, DateTime hansd)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoHDList>(new Criteria(1, maKho, thang, Ma, solo, hansd));
        }
        public static DMThuoc_TonKhoHDList FindDMThuocTonKhoTen(String maKho, DateTime thang, String Ten, string solo, DateTime hansd)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoHDList>(new Criteria(2, maKho, thang, Ten, solo, hansd));
        }
        public static DMThuoc_TonKhoHDList FindDMThuocTonKhoTenD(String maKho, DateTime thang, String Ten, string solo, DateTime hansd)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoHDList>(new Criteria(3, maKho, thang, Ten, solo, hansd));
        }
        public static DMThuoc_TonKhoHDList FindDMThuocTonKhoMa(String maKho, DateTime thang, String Ma,string dk)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoHDList>(new Criteria(4, maKho, thang, Ma, dk, DateTime.Parse("01/01/1900")));
        }
        public static DMThuoc_TonKhoHDList FindDMThuocTonKhoTen(String maKho, DateTime thang, String Ten, string dk)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoHDList>(new Criteria(5, maKho, thang, Ten, dk, DateTime.Parse("01/01/1900")));
        }
        public static DMThuoc_TonKhoHDList GetAllDMThuocTonKho(String maKho, String MaDT, DateTime thang)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoHDList>(new CriteriaOther(0, maKho, MaDT, thang, "", "", DateTime.Parse("01/01/1900")));
        }
        public static DMThuoc_TonKhoHDList GetAllDMThuocTonKho(String maKho, String MaDT, DateTime thang, string dk)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoHDList>(new CriteriaOther(0, maKho, MaDT, thang, dk, "", DateTime.Parse("01/01/1900")));
        }
        public static DMThuoc_TonKhoHDList FindDMThuocTonKhoMa(String maKho, String MaDT, DateTime thang, String Ma)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoHDList>(new CriteriaOther(1, maKho, MaDT, thang, Ma, "", DateTime.Parse("01/01/1900")));
        }
        //
        public static DMThuoc_TonKhoHDList FindDMThuocTonKhoMa(String maKho, String MaNcc, String SoHD,String DK, String SoLo,DateTime HanDung)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoHDList>(new CriteriaOther1(1, maKho, MaNcc, SoHD, DateTime.Parse("01/01/1900"), DK, SoLo, HanDung));
        }
        //
        public static DMThuoc_TonKhoHDList FindDMThuocTonKhoTen(String maKho, String MaDT, DateTime thang, String Ten)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoHDList>(new CriteriaOther(2, maKho, MaDT, thang, Ten, "", DateTime.Parse("01/01/1900")));
        }
        public static DMThuoc_TonKhoHDList FindDMThuocTonKhoTenD(String maKho, String MaDT, DateTime thang, String Ten)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoHDList>(new CriteriaOther(3, maKho, MaDT, thang, Ten, "", DateTime.Parse("01/01/1900")));
        }
        public static DMThuoc_TonKhoHDList GetAllDMThuocTonKho(String maKho, String MaDT, DateTime thang, string solo, DateTime hansd)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoHDList>(new CriteriaOther(0, maKho, MaDT, thang, "", solo, hansd));
        }
        public static DMThuoc_TonKhoHDList FindDMThuocTonKhoMa(String maKho, String MaDT, DateTime thang, String Ma, string solo, DateTime hansd)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoHDList>(new CriteriaOther(1, maKho, MaDT, thang, Ma, solo, hansd));
        }
        public static DMThuoc_TonKhoHDList FindDMThuocTonKhoTen(String maKho, String MaDT, DateTime thang, String Ten, string solo, DateTime hansd)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoHDList>(new CriteriaOther(2, maKho, MaDT, thang, Ten, solo, hansd));
        }
        public static DMThuoc_TonKhoHDList FindDMThuocTonKhoTenD(String maKho, String MaDT, DateTime thang, String Ten, string solo, DateTime hansd)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoHDList>(new CriteriaOther(3, maKho, MaDT, thang, Ten, solo, hansd));
        }
        public static DMThuoc_TonKhoHDList FindDMThuocTonKhoMa(String maKho, String MaDT, DateTime thang, String Ma, string dk)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoHDList>(new CriteriaOther(4, maKho, MaDT, thang, Ma, dk, DateTime.Parse("01/01/1900")));
        }
        public static DMThuoc_TonKhoHDList FindDMThuocTonKhoTen(String maKho, String MaDT, DateTime thang, String Ten, string dk)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoHDList>(new CriteriaOther(5, maKho, MaDT, thang, Ten, dk, DateTime.Parse("01/01/1900")));
        }
        private DMThuoc_TonKhoHDList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        protected class Criteria
        {
            private String _maKho;
            public String MaKho
            {
                get
                {
                    return _maKho;
                }
            }

            private DateTime _thang;
            public DateTime thang
            {
                get
                {
                    return _thang ;
                }
            }
            private DateTime _hansd;
            public DateTime hansd
            {
                get
                {
                    return _hansd;
                }
            }
            private String _dK;
            public String DK
            {
                get
                {
                    return _dK;
                }
            }
            private String _solo;
            public String solo
            {
                get
                {
                    return _solo;
                }
            }
            public Criteria(Byte mIdFind, String maKho, DateTime thang, String mDK, string solo, DateTime hansd)
            {
                _maKho = maKho;
                _thang = thang;
               
                _hansd = hansd;
                if (_hansd == DateTime.Parse("01/01/0001"))
                    _hansd = DateTime.Parse("01/01/1900");
                _dK = mDK;
                if ((mIdFind == 1) || (mIdFind == 4))
                    _dK = " and (a.MAthuoc like N'" + mDK + "%' or a.MAql like N'" + mDK + "%')";
                else if ((mIdFind == 2) || (mIdFind == 5))
               {
                   _dK =  " AND ((A.TENTM  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                   _dK = _dK + " Like N'" + mDK + "%')";
                   _dK = _dK + " or ( A.TENTM1  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                   _dK = _dK + " Like N'" + mDK + "%')";
                   _dK = _dK + " or ( A.TENTM2  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                   _dK = _dK + " Like N'" + mDK + "%')) ";
                }
                else if (mIdFind == 3)
                {
                    _dK = " and A.TENTM + CASE WHEN ISNULL(TENTM1,'') <>'' ";
                    _dK = _dK + " THEN '('+ TENTM1 +')' ELSE '' END  + CASE WHEN ISNULL(TENTM2,'') <>'' ";
                    _dK = _dK + "  THEN '('+ TENTM2 +')' ELSE '' END + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  like N'" + mDK + "'";
                }
                if ((mIdFind == 4) || (mIdFind == 5))
                {
                    _dK = _dK + solo;
                    _solo = "";
                }
                else
                    _solo = solo;
            }


        }



        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMThuocTonKhoHD(criteria.MaKho , criteria.thang, criteria.DK,criteria.solo,criteria.hansd   )))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMThuoc_TonKhoHD item = new DMThuoc_TonKhoHD(
     i,
     dr.GetString("MaThuoc"),
     dr.GetString("TenTM"),
     dr.GetString("TenDVT"),
     dr.GetDecimal("TonCK"),
     dr.GetDecimal("TonCKDT"),
     dr.GetString("TenTA"),
     dr.GetBoolean("Handung"),
     dr.GetString("TenNSX"),
     dr.GetString("MaQL"),
     dr.GetDecimal("DonGiatt"),
     dr.GetDecimal("gianhap"),
     dr.GetString("Tengoc"),
     dr.GetString("SoLo"),
     dr.GetSmartDate("HanSD", false),
     dr.GetDecimal("quydoi"),
     dr.GetDecimal("nguong")
         );
                    this.Add(item);
                    i += 1;
                }
                IsReadOnly = true;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        // class object truyen vao
        protected class CriteriaOther
        {
            private String _maKho;
            public String MaKho
            {
                get
                {
                    return _maKho;
                }
            }

            private DateTime _thang;
            public DateTime thang
            {
                get
                {
                    return _thang;
                }
            }
            private DateTime _hansd;
            public DateTime hansd
            {
                get
                {
                    return _hansd;
                }
            }
            private String _dK;
            public String DK
            {
                get
                {
                    return _dK;
                }
            }
            private String _solo;
            public String solo
            {
                get
                {
                    return _solo;
                }
            }
            private String _MaDT;
            public String MaDT
            {
                get
                {
                    return _MaDT;
                }
            }
            public CriteriaOther(Byte mIdFind, String maKho, String MaDT, DateTime thang, String mDK, string solo, DateTime hansd)
            {
                _maKho = maKho;
                _MaDT = MaDT;
                _thang = thang;

                _hansd = hansd;
                if (_hansd == DateTime.Parse("01/01/0001"))
                    _hansd = DateTime.Parse("01/01/1900");
                _dK = mDK;
                if ((mIdFind == 1) || (mIdFind == 4))
                    _dK = " and (a.MAthuoc like N'" + mDK + "%' or a.MAql like N'" + mDK + "%')";
                else if ((mIdFind == 2) || (mIdFind == 5))
                {
                    _dK = " AND ((A.TENTM  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                    _dK = _dK + " Like N'" + mDK + "%')";
                    _dK = _dK + " or ( A.TENTM1  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                    _dK = _dK + " Like N'" + mDK + "%')";
                    _dK = _dK + " or ( A.TENTM2  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                    _dK = _dK + " Like N'" + mDK + "%')) ";
                }
                else if (mIdFind == 3)
                {
                    _dK = " and A.TENTM + CASE WHEN ISNULL(TENTM1,'') <>'' ";
                    _dK = _dK + " THEN '('+ TENTM1 +')' ELSE '' END  + CASE WHEN ISNULL(TENTM2,'') <>'' ";
                    _dK = _dK + "  THEN '('+ TENTM2 +')' ELSE '' END + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  like N'" + mDK + "'";
                }
                if ((mIdFind == 4) || (mIdFind == 5))
                {
                    _dK = _dK + solo;
                    _solo = "";
                }
                else
                    _solo = solo;
            }


        }
        // tao 1 class moi
        protected class CriteriaOther1
        {
            private String _maKho;
            public String MaKho
            {
                get
                {
                    return _maKho;
                }
            }
            private String _MaNcc;
            public String MaNcc
            {
                get
                {
                    return _MaNcc;
                }
            }
            private String _soHD;
            public String SoHD
            {
                get
                {
                    return _soHD;
                }
            }
            private DateTime _thang;
            public DateTime thang
            {
                get
                {
                    return _thang;
                }
            }
            private DateTime _hansd;
            public DateTime hansd
            {
                get
                {
                    return _hansd;
                }
            }
            private String _dK;
            public String DK
            {
                get
                {
                    return _dK;
                }
            }
            private String _solo;
            public String solo
            {
                get
                {
                    return _solo;
                }
            }
            private String _MaDT;
            public String MaDT
            {
                get
                {
                    return _MaDT;
                }
            }
            public CriteriaOther1(Byte mIdFind, String maKho,String MaNcc ,String SoHD, DateTime thang, String mDK, string solo, DateTime hansd)
            {
                _maKho = maKho;
                _MaNcc = MaNcc;
                _solo = "";
                _soHD = SoHD;
                _MaDT = MaDT;
                _thang = thang;

                _hansd = hansd;
                if (_hansd == DateTime.Parse("01/01/0001"))
                    _hansd = DateTime.Parse("01/01/1900");
                _dK = mDK;
            }
        }

        // Tao ham goi moi
        private void DataPortal_Fetch(CriteriaOther1 criteria)
        {
            RaiseListChangedEvents = false;
            if (criteria.SoHD=="")
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMThuocTonKhoHD(criteria.MaKho,criteria.MaNcc,criteria.SoHD,criteria.DK,criteria.solo,criteria.hansd)))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMThuoc_TonKhoHD item = new DMThuoc_TonKhoHD(
     i,
     dr.GetString("MaThuoc"),
     dr.GetString("TenTM"),
     dr.GetString("TenDVT"),
     dr.GetDecimal("TonCK"),
     dr.GetDecimal("TonCKDT"),
     dr.GetString("TenTA"),
     dr.GetBoolean("Handung"),
     dr.GetString("TenNSX"),
     dr.GetString("MaQL"),
     dr.GetDecimal("DonGiatt"),
     dr.GetDecimal("gianhap"),
     dr.GetString("Tengoc"),
     dr.GetString("SoLo"),
     dr.GetSmartDate("HanSD", false),
     dr.GetDecimal("quydoi"),
     dr.GetDecimal("nguong")
         );
                    this.Add(item);
                    i += 1;
                }
                IsReadOnly = true;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        // ham goi 
        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMThuocTonKhoHD(criteria.MaKho, criteria.MaDT, criteria.thang, criteria.DK, criteria.solo, criteria.hansd)))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMThuoc_TonKhoHD item = new DMThuoc_TonKhoHD(
     i,
     dr.GetString("MaThuoc"),
     dr.GetString("TenTM"),
     dr.GetString("TenDVT"),
     dr.GetDecimal("TonCK"),
     dr.GetDecimal("TonCKDT"),
     dr.GetString("TenTA"),
     dr.GetBoolean("Handung"),
     dr.GetString("TenNSX"),
     dr.GetString("MaQL"),
     dr.GetDecimal("DonGiatt"),
     dr.GetDecimal("gianhap"),
     dr.GetString("Tengoc"),
     dr.GetString("SoLo"),
     dr.GetSmartDate("HanSD", false),
     dr.GetDecimal("quydoi"),
     dr.GetDecimal("nguong")
         );
                    this.Add(item);
                    i += 1;
                }
                IsReadOnly = true;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        #endregion
    }
}
