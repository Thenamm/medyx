using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhAn_DongTien_SearchListInfo  : ReadOnlyListBase<BenhAn_DongTien_SearchListInfo, BenhAn_DongTien_SearchInfo >
    {
        #region Factory Methods
        public  BenhAn_DongTien_SearchInfo GetTo(string maba) //
        {
            foreach (BenhAn_DongTien_SearchInfo obj in this)
                if (obj.SoPhieu  == maba)
                    return obj;
            return null;

        }
        public static BenhAn_DongTien_SearchListInfo BenhAn_DongTien_SearchInfo(String _maSoKham, String _dK, Boolean _qadmin)
        {
            return DataPortal.Fetch<BenhAn_DongTien_SearchListInfo>(new CriteriaOther( _maSoKham,  _dK ,  _qadmin));
        }

        private BenhAn_DongTien_SearchListInfo()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class CriteriaOther
        {
            private string _MaBA;
            public string MaBA
            {
                get
                {
                    return _MaBA;
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
            public bool Qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public CriteriaOther(
                   String mmaBA,
                  
                 string mDK,
                Boolean mQadmin
                    )
            {
                _MaBA = mmaBA;
                _DK = mDK;

                _qadmin = mQadmin;
            }
        }

        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().BenhAn_DongTien_SearchInfo(
                      criteria.MaBA  ,
                      criteria.DK,
                      criteria.Qadmin 
                      )))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_DongTien_SearchInfo item = new BenhAn_DongTien_SearchInfo
             (i,            
                 dr.GetString("TenLDThuTien"),
                 dr.GetString("SoPhieu"),
                 dr.GetDecimal("SoTien"),
                 dr.GetString("KyHieu"),
                 dr.GetString("tENKHOA"),
                 dr.GetString("TenNguoiThu"),
                 dr.GetSmartDate("NgayDong", true));
                    this.Add(item);
                    i += 1;

                }
                dr.Close(); dr.Dispose();//IsReadOnly = true;
            }

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
    }
}
