using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMChePhamMau_TonKhoHDList : ReadOnlyListBase<DMChePhamMau_TonKhoHDList, DMChePhamMau_TonKhoHD>
    {
        #region Factory Methods
        public static DMChePhamMau_TonKhoHDList GetAllDMChePhamMauTonKho(String maKho, DateTime thang)
        {
            return DataPortal.Fetch<DMChePhamMau_TonKhoHDList>(new Criteria(0, maKho, thang, "", "", DateTime.Parse("01/01/1900")));
        }
        public static DMChePhamMau_TonKhoHDList FindDMChePhamMauTonKhoMa(String maKho, DateTime thang, String Ma)
        {
            return DataPortal.Fetch<DMChePhamMau_TonKhoHDList>(new Criteria(1, maKho, thang, Ma, "", DateTime.Parse("01/01/1900")));
        }

        public static DMChePhamMau_TonKhoHDList FindDMChePhamMauTonKhoTen(String maKho, DateTime thang, String Ten)
        {
            return DataPortal.Fetch<DMChePhamMau_TonKhoHDList>(new Criteria(2, maKho, thang, Ten, "", DateTime.Parse("01/01/1900")));
        }
        public static DMChePhamMau_TonKhoHDList GetAllDMChePhamMauTonKho(String maKho, DateTime thang, string solo, DateTime hansd)
        {
            return DataPortal.Fetch<DMChePhamMau_TonKhoHDList>(new Criteria(0, maKho, thang, "", solo, hansd));
        }
        public static DMChePhamMau_TonKhoHDList FindDMChePhamMauTonKhoMa(String maKho, DateTime thang, String Ma, string solo, DateTime hansd)
        {
            return DataPortal.Fetch<DMChePhamMau_TonKhoHDList>(new Criteria(1, maKho, thang, Ma, solo, hansd));
        }
        public static DMChePhamMau_TonKhoHDList FindDMChePhamMauTonKhoMa(String maKho, DateTime thang, String Ma, string solo)
        {
            return DataPortal.Fetch<DMChePhamMau_TonKhoHDList>(new Criteria(1, maKho, thang, Ma, solo, DateTime.Parse ("01/01/1900" )));
        }
        public static DMChePhamMau_TonKhoHDList FindDMChePhamMauTonKhoTen(String maKho, DateTime thang, String Ten, string solo, DateTime hansd)
        {
            return DataPortal.Fetch<DMChePhamMau_TonKhoHDList>(new Criteria(2, maKho, thang, Ten, solo, hansd));
        }

        private DMChePhamMau_TonKhoHDList()
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
                _solo = solo;
                _hansd = hansd;
                if (_hansd == DateTime.Parse("01/01/0001"))
                    _hansd = DateTime.Parse("01/01/1900"); 
                if (mIdFind == 1)
                    _dK = " and a.MaCPMau like N'" + mDK + "%'";
                else if (mIdFind == 2)
                {
                    _dK = " and A.TENcpmau  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') like N'" + mDK.Trim() + "%'";
                }
            }


        }



        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMChePhamMauTonKhoHD(criteria.MaKho , criteria.thang, criteria.DK,criteria.solo,criteria.hansd   )))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMChePhamMau_TonKhoHD item = new DMChePhamMau_TonKhoHD(
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
     dr.GetDecimal("gianhap"),
     //dr.GetString("Tengoc"),
     dr.GetString("SoLo"),
     dr.GetSmartDate("HanSD", false)
     //dr.GetDecimal("nguong")
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
