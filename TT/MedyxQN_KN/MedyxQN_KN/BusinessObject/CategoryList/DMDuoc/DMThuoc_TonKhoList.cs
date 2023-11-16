using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMThuoc_TonKhoList : ReadOnlyListBase<DMThuoc_TonKhoList, DMThuoc_TonKho>
    {
        #region Factory Methods
        public static DMThuoc_TonKhoList GetAllDMThuocTonKho(String maKho, DateTime thang)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoList>(new Criteria(0, maKho, thang ,""));
        }
        public static DMThuoc_TonKhoList GetAllDMThuocTonKho(String maKho, DateTime thang, string dk)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoList>(new Criteria(8, maKho, thang, dk));
        }
        public static DMThuoc_TonKhoList FindDMThuocTonKhoMa(String maKho, DateTime thang, String Ma)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoList>(new Criteria(1, maKho, thang, Ma));
        }
        public static DMThuoc_TonKhoList FindDMThuocTonKhoTen(String maKho, DateTime thang, String Ten)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoList>(new Criteria(2, maKho, thang, Ten));
        }
        public static DMThuoc_TonKhoList FindDMThuocTonKhoTenD(String maKho, DateTime thang, String Ten)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoList>(new Criteria(3, maKho, thang, Ten));
        }
        public static DMThuoc_TonKhoList GetAllDMThuocTonKho(String maKho, String MaDT, DateTime thang)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoList>(new CriteriaOther(0, maKho, MaDT, thang, ""));
        }
        public static DMThuoc_TonKhoList GetAllDMThuocTonKho(String maKho, String MaDT, DateTime thang, string dk)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoList>(new CriteriaOther(0, maKho, MaDT, thang, dk));
        }
        public static DMThuoc_TonKhoList FindDMThuocTonKhoMa(String maKho, String MaDT, DateTime thang, String Ma)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoList>(new CriteriaOther(1, maKho, MaDT, thang, Ma));
        }
        public static DMThuoc_TonKhoList FindDMThuocTonKhoTen(String maKho, String MaDT, DateTime thang, String Ten)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoList>(new CriteriaOther(2, maKho, MaDT, thang, Ten));
        }
        public static DMThuoc_TonKhoList FindDMThuocTonKho(String maKho,  DateTime thang, String dk)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoList>(new Criteria(8, maKho,thang, dk));
        }
        public static DMThuoc_TonKhoList FindDMThuocTonKhoTenD(String maKho, String MaDT, DateTime thang, String Ten)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoList>(new CriteriaOther(3, maKho,MaDT, thang, Ten));
        }
        public static DMThuoc_TonKhoList FindDMThuocTonKhoMaTY(String maKho, DateTime thang, String Ma)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoList>(new Criteria(4, maKho, thang, Ma));
        }
        public static DMThuoc_TonKhoList FindDMThuocTonKhoTenTY(String maKho, DateTime thang, String Ten)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoList>(new Criteria(5, maKho, thang, Ten));
        }
        public static DMThuoc_TonKhoList FindDMThuocTonKhoTenTYD(String maKho, DateTime thang, String Ten)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoList>(new Criteria(6, maKho, thang, Ten));
        }
        public static DMThuoc_TonKhoList FindDMThuocTonKhoMaTY(String maKho, String MaDT, DateTime thang, String Ma)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoList>(new CriteriaOther(4, maKho, MaDT, thang, Ma));
        }
        public static DMThuoc_TonKhoList FindDMThuocTonKhoTenTY(String maKho, String MaDT, DateTime thang, String Ten)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoList>(new CriteriaOther(5, maKho, MaDT, thang, Ten));
        }
        public static DMThuoc_TonKhoList FindDMThuocTonKhoTenTYD(String maKho, String MaDT, DateTime thang, String Ten)
        {
            return DataPortal.Fetch<DMThuoc_TonKhoList>(new CriteriaOther(5, maKho, MaDT, thang, Ten));
        }
        private DMThuoc_TonKhoList()
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
            private String _dK;
            public String DK
            {
                get
                {
                    return _dK;
                }
            }
            public Criteria(Byte mIdFind, String maKho, DateTime thang, String mDK)
            {
                _maKho = maKho;
                _thang = thang;
                _dK = mDK;
                if ((mIdFind == 1) || (mIdFind==4))
                    _dK = " and (a.MAthuoc like N'" + mDK + "%' or a.MAql like N'" + mDK + "%')";
                else if ((mIdFind == 2)|| (mIdFind==5))
                {
                    _dK =  " AND ((A.TENTM  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                    _dK = _dK + " Like N'" + mDK + "%')";
                    _dK = _dK + " or ( A.TENTM1  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                    _dK = _dK + " Like N'" + mDK + "%')";
                    _dK = _dK + " or ( A.TENTM2  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                    _dK = _dK + " Like N'" + mDK + "%')) ";
                }
                else if ((mIdFind == 3)|| (mIdFind==6))
                {
                    _dK = "  A.TENTM + CASE WHEN ISNULL(TENTM1,'') <>'' THEN '('+ TENTM1 +')' else '' END ";
                    _dK = _dK + " + CASE WHEN ISNULL(TENTM2,'') <>'' THEN '('+ TENTM2 +')' else '' END + ' ' +  ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(A.QUYCACH,'') +' '+  ISNULL(E.TENNSX,'')";

                    //_dK = " and A.TENTM + CASE WHEN ISNULL(TENTM1,'') <>'' ";
                    //_dK = _dK + " THEN '('+ TENTM1 +')' ELSE '' END  + CASE WHEN ISNULL(TENTM2,'') <>'' ";
                    //_dK = _dK + "  THEN '('+ TENTM2 +')' ELSE ''END + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  like N'" + mDK + "%'";
                }
                if ((mIdFind == 4) || (mIdFind == 5) || (mIdFind == 6) )
                    _dK = _dK + " and isnull(a.machungloai,'') <> '00019'";

            }
        }



        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMThuocTonKho(criteria.MaKho , criteria.thang, criteria.DK)))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMThuoc_TonKho item = new DMThuoc_TonKho(
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
     dr.GetDecimal("quydoi"),
      dr.GetString("sovisa"),
       dr.GetString("duongdung"),
        dr.GetString("hamluong"),
         dr.GetString("matduong")

         );
                    this.Add(item);
                    i += 1;
                }
                IsReadOnly = true;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

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
            private String _dK;
            public String DK
            {
                get
                {
                    return _dK;
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
            public CriteriaOther(Byte mIdFind, String maKho, String MaDT, DateTime thang, String mDK)
            {
                _maKho = maKho;
                _MaDT = MaDT;
                _thang = thang;
                _dK = mDK;
                if  ((mIdFind == 1) || (mIdFind==4))
                    _dK = " and (a.MAthuoc like N'" + mDK + "%' or a.MAql like N'" + mDK + "%')";
                else if  ((mIdFind == 2) || (mIdFind==5))
                {
                    _dK = " AND ((A.TENTM  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                    _dK = _dK + " Like N'" + mDK + "%')";
                    _dK = _dK + " or ( A.TENTM1  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                    _dK = _dK + " Like N'" + mDK + "%')";
                    _dK = _dK + " or ( A.TENTM2  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                    _dK = _dK + " Like N'" + mDK + "%')) ";
                }
                //else if ((mIdFind == 3) || (mIdFind == 6))
                //{
                //    _dK = " and A.TENTM + CASE WHEN ISNULL(TENTM1,'') <>'' ";
                //    _dK = _dK + " THEN '('+ TENTM1 +')' ELSE '' END  + CASE WHEN ISNULL(TENTM2,'') <>'' ";
                //    _dK = _dK + "  THEN '('+ TENTM2 +')' ELSE ''END + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  like N'" + mDK + "%'";
                //}
                else if ((mIdFind == 3) || (mIdFind == 6))
                {
                    _dK = " and A.TENTM + CASE WHEN ISNULL(TENTM1,'') <>'' ";
                    _dK = _dK + " THEN '('+ TENTM1 +')' ELSE '' END  + CASE WHEN ISNULL(TENTM2,'') <>'' ";
                    _dK = _dK + "  THEN '('+ TENTM2 +')' ELSE ''END + ' ' + ISNULL(A.HAMLUONG,'')  + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  like N'" + mDK + "%'";
                }
                if ((mIdFind == 4) || (mIdFind == 5) || (mIdFind == 6))
                    _dK = _dK + " and isnull(a.machungloai,'') <> '00019'";
            }


        }



        private void DataPortal_Fetch(CriteriaOther CriteriaOther)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMThuocTonKho(CriteriaOther.MaKho, CriteriaOther.MaDT, CriteriaOther.thang, CriteriaOther.DK)))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMThuoc_TonKho item = new DMThuoc_TonKho(
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
     dr.GetDecimal("quydoi") ,
     dr.GetString("sovisa"),
       dr.GetString("duongdung"),
        dr.GetString("hamluong"),
         dr.GetString("matduong")
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
