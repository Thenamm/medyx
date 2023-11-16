using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMChePhamMau_TonKhoList : ReadOnlyListBase<DMChePhamMau_TonKhoList, DMChePhamMau_TonKho>
    {
        #region Factory Methods
        public static DMChePhamMau_TonKhoList GetAllDMChePhamMauTonKho(String maKho, DateTime thang)
        {
            return DataPortal.Fetch<DMChePhamMau_TonKhoList>(new Criteria(0, maKho, thang ,""));
        }
        public static DMChePhamMau_TonKhoList FindDMChePhamMauTonKhoMa(String maKho, DateTime thang, String Ma)
        {
            return DataPortal.Fetch<DMChePhamMau_TonKhoList>(new Criteria(1, maKho, thang, Ma));
        }
        public static DMChePhamMau_TonKhoList FindDMChePhamMauTonKhoTen(String maKho, DateTime thang, String Ten)
        {
            return DataPortal.Fetch<DMChePhamMau_TonKhoList>(new Criteria(2, maKho, thang, Ten));
        }
        private DMChePhamMau_TonKhoList()
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
                    _dK = " and a.MaCPMau like N'" + mDK + "%'";
                else if (mIdFind == 2)
                {
                    _dK = " and A.TENcpmau  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') like N'" + mDK + "%'";
                }
            }


        }



        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMChePhamMauTonKho(criteria.MaKho , criteria.thang, criteria.DK)))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMChePhamMau_TonKho item = new DMChePhamMau_TonKho(
     i,
     dr.GetString("MaCPMau"),
     dr.GetString("TenTM"),
     dr.GetString("TenDVT"),
     dr.GetDecimal("TonCK"),
     dr.GetDecimal("TonCKDT"),
     dr.GetString("TenTA"),
     dr.GetBoolean("Handung"),
     //dr.GetString("TenNSX"),
     dr.GetDecimal("DonGiatt"),
     dr.GetDecimal("gianhap")//,
   //  dr.GetString("Tengoc")
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
