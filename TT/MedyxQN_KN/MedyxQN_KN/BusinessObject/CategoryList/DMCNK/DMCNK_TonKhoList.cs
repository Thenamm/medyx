using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMCNK_TonKhoList : ReadOnlyListBase<DMCNK_TonKhoList, DMCNK_TonKho>
    {
        #region Factory Methods
        public static DMCNK_TonKhoList GetAllDMCNKTonKho(String maKho, DateTime thang,String DK)
        {
            return DataPortal.Fetch<DMCNK_TonKhoList>(new Criteria(0, maKho, thang ,DK));
        }
        public static DMCNK_TonKhoList FindDMCNKTonKhoMa(String maKho, DateTime thang, String Ma)
        {
            return DataPortal.Fetch<DMCNK_TonKhoList>(new Criteria(1, maKho, thang, Ma));
        }
        public static DMCNK_TonKhoList FindDMCNKTonKhoTen(String maKho, DateTime thang, String Ten)
        {
            return DataPortal.Fetch<DMCNK_TonKhoList>(new Criteria(2, maKho, thang, Ten));
        }
        public static DMCNK_TonKhoList FindDMCNKTonKhoTenD(String maKho, DateTime thang, String Ten)
        {
            return DataPortal.Fetch<DMCNK_TonKhoList>(new Criteria(3, maKho, thang, Ten));
        }
        private DMCNK_TonKhoList()
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
                if (mIdFind == 1)
                    _dK = " and (a.MAvt like N'" + mDK + "%' or a.MAql like N'" + mDK + "%')";
                else if (mIdFind == 2)
                {
                    _dK = " and A.TENTM + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDV,'') like N'" + mDK + "%'";
                }
                else if (mIdFind == 3)
                {
                    _dK = " and A.TENTM + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDV,'') like N'" + mDK + "'";
                }
                else if (mIdFind == 0)
                    _dK = mDK;
            }


        }



        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMCNKTonKho(criteria.MaKho , criteria.thang, criteria.DK)))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMCNK_TonKho item = new DMCNK_TonKho(
     i,
     dr.GetString("MaVT"),
     dr.GetString("TenTM"),
     dr.GetString("TenDVT"),
     dr.GetDecimal("TonCK"),
     dr.GetDecimal("TonCKDT"),
     dr.GetString("TenTA"),
     dr.GetBoolean("Handung"),
     dr.GetString("TenNSX"),
     dr.GetString("MaQL"),
     dr.GetDecimal("DonGiatt"),
     dr.GetDecimal("gianhap")
     //dr.GetString("Tengoc")
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
