using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMVTYT_TonKhoList : ReadOnlyListBase<DMVTYT_TonKhoList, DMVTYT_TonKho>
    {
        #region Factory Methods
        public static DMVTYT_TonKhoList GetAllDMVTYTTonKho(String maKho, DateTime thang,string dk)
        {
            return DataPortal.Fetch<DMVTYT_TonKhoList>(new Criteria(0, maKho, thang ,dk));
        }
        public static DMVTYT_TonKhoList GetAllDMVTYTTonKho(String maKho, DateTime thang)
        {
            return DataPortal.Fetch<DMVTYT_TonKhoList>(new Criteria(0, maKho, thang, ""));
        }
        public static DMVTYT_TonKhoList FindDMVTYTTonKhoMa(String maKho, DateTime thang, String Ma)
        {
            return DataPortal.Fetch<DMVTYT_TonKhoList>(new Criteria(1, maKho, thang, Ma));
        }
        public static DMVTYT_TonKhoList FindDMVTYTTonKhoTen(String maKho, DateTime thang, String Ten)
        {
            return DataPortal.Fetch<DMVTYT_TonKhoList>(new Criteria(2, maKho, thang, Ten));
        }
        public static DMVTYT_TonKhoList FindDMVTYTTonKhoTenD(String maKho, DateTime thang, String Ten)
        {
            return DataPortal.Fetch<DMVTYT_TonKhoList>(new Criteria(3, maKho, thang, Ten));
        }
        private DMVTYT_TonKhoList()
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
                if (mIdFind == 1)
                   _dK = " and (a.MAvt like N'" + mDK + "%' or a.MAql like N'" + mDK + "%')";
                else if (mIdFind == 2)
                {
                    _dK = " and A.TENTM + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  like N'" + mDK + "%'";
                }
                else if (mIdFind == 3)
                {
                    _dK = " and A.TENTM + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  like N'" + mDK + "'";
                }
            }


        }



        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMVTYTTonKho(criteria.MaKho , criteria.thang, criteria.DK)))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMVTYT_TonKho item = new DMVTYT_TonKho(
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
