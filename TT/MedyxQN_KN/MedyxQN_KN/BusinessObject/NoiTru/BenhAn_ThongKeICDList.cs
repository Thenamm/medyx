using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class BenhAn_ThongKeICDList : ReadOnlyListBase<BenhAn_ThongKeICDList, BenhAn_ThongKeICD>
    {
        #region Factory Methods
        public static BenhAn_ThongKeICDList GetAllBenhAn_ThongKeICD(DateTime TuNgay, DateTime DenNgay, Boolean ntbn)
        {
            return DataPortal.Fetch<BenhAn_ThongKeICDList>(new Criteria(TuNgay, DenNgay, ntbn));
        }

        private BenhAn_ThongKeICDList()
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
            private Boolean _ntbn;
            public Boolean ntbn
            {
                get
                {
                    return _ntbn;
                }
            }
            public Criteria(DateTime TuNgay, DateTime DenNgay, Boolean ntbn)
            {
                _TuNgay = TuNgay;
                _DenNgay = DenNgay;
                _ntbn = ntbn;
            }
        }

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_ThongKeICD(criteria.TuNgay, criteria.DenNgay, criteria.ntbn)))
            {
                int i = 1;

                IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_ThongKeICD item = new BenhAn_ThongKeICD(
     i,
     dr.GetString("MaICD"),
      dr.GetString("TenICD"),
     dr.GetInt32("SoHS") 
         );
                    this.Add(item);
                    i += 1;

                }
                IsReadOnly = true;
            }
            RaiseListChangedEvents = true;
        }
        #endregion
    }
}
