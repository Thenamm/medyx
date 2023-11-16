using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class BenhAn_PhieuGNList : ReadOnlyListBase<BenhAn_PhieuGNList, BenhAn_PhieuGN>
    {
        #region Factory Methods
        public static BenhAn_PhieuGNList GetAllBenhAn_PhieuGN(DateTime TuNgay, DateTime DenNgay, String MaKhoa, Boolean tra, Boolean NoiTru)
        {
            return DataPortal.Fetch<BenhAn_PhieuGNList>(new Criteria(TuNgay, DenNgay, MaKhoa,tra, NoiTru));
        }

        private BenhAn_PhieuGNList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            private DateTime _TuNgay;
            public DateTime TuNgay
            {
                get
                {
                    return _TuNgay;
                }
            }
            private DateTime _DenNgay;
            public DateTime DenNgay
            {
                get
                {
                    return _DenNgay;
                }
            }
            private String _MaKhoa;
            public String MaKhoa
            {
                get
                {
                    return _MaKhoa;
                }
            }
            private Boolean _Tra;
            public Boolean Tra
            {
                get
                {
                    return _Tra;
                }
            }
            private Boolean _NoiTru;
            public Boolean NoiTru
            {
                get
                {
                    return _NoiTru;
                }
            }
            public Criteria(DateTime TuNgay, DateTime DenNgay, String MaKHoa, Boolean Tra, Boolean NoiTru)
            {
                _TuNgay = TuNgay;
                _DenNgay = DenNgay;
                _MaKhoa = MaKHoa;
                _Tra = Tra;
                _NoiTru = NoiTru;
            }
        }
        #region CriteriaOther

        [Serializable()]
        private class CriteriaOther
        {

            private Byte _IdFind;
            public Byte IdFind
            {
                get
                {
                    return _IdFind;
                }
            }
            private string _DK;
            public string DK
            {
                get
                {
                    return _DK;
                }
            }
             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            //public Criteria(Boolean mqadmin)
            //{

            //    _qadmin = mqadmin;
            //}
            public CriteriaOther(Byte mIdFind, String mDK)
            {

                _IdFind = mIdFind;
                if (mIdFind == 1)
                    _DK = "MaPhieuGN like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenKhoa)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_PhieuGN(criteria.TuNgay, criteria.DenNgay, criteria.MaKhoa,criteria.Tra,criteria.NoiTru)))
            {
                int i = 1;

                IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_PhieuGN item = new BenhAn_PhieuGN(
     i,
     dr.GetString("MaPhieuGN"),
      dr.GetString("MaKhoa"),
     dr.GetString ("TenKhoa"),
     dr.GetString("GhiChu"),
      dr.GetSmartDate("NgayGN", false),
         dr.GetString ("MaMay"),
		 dr.GetBoolean ("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"), 
    dr.GetBoolean("NoiTru")
         );
                    this.Add(item);
                    i += 1;

                }
                IsReadOnly = true;
            }
            // Xem lai doan code duoi
            //ArrayList arrList;
            //arrList = CBO.FillCollection(DataProvider.Instance().GetLocations(criteria.Id), typeof(LocationListInfo));
            //IsReadOnly = false;
            //foreach (LocationListInfo obj in arrList)
            //{
            //    this.Add(obj);
            //}
            //IsReadOnly = true;

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindBenhAn_PhieuGN(criteria.DK, false)))
            {
                int i = 1;

                IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_PhieuGN item = new BenhAn_PhieuGN(
     i,
      dr.GetString("MaPhieuGN"),
      dr.GetString("MaKhoa"),
     dr.GetString("TenKhoa"),
     dr.GetString("GhiChu"),
      dr.GetSmartDate("NgayGN", false),
         dr.GetString("MaMay"),
         dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),
    dr.GetBoolean("NoiTru")

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
