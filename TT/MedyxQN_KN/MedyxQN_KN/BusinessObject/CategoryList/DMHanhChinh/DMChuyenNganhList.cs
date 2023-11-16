


using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMChuyenNganhList : ReadOnlyListBase<DMChuyenNganhList, DMChuyenNganh>
    {
        #region Factory Methods
        public static DMChuyenNganhList GetAllDMChuyenNganh()
        {
            return DataPortal.Fetch<DMChuyenNganhList>(new Criteria());
        }

        private DMChuyenNganhList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            //private int _id;
            //public int Id
            //{
            //    get
            //    {
            //        return _id;
            //    }
            //}
            //public Criteria(int mId)
            //{
            //    _id = mId;
            //}
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
                    _DK = "MaChuyenNganh like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenChuyenNganh)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMChuyenNganh()))
            {
                int i = 1;

                IsReadOnly = false;
                while (dr.Read())
                {
                    DMChuyenNganh item = new DMChuyenNganh(
     i,
     dr.GetString("MaChuyenNganh"),
     dr.GetString("TenChuyenNganh"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),
     dr.GetString("loai"),
     dr.GetByte("Cap"),
     dr.GetString("idparent")
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMChuyenNganh(criteria.DK, false)))
            {
                int i = 1;

                IsReadOnly = false;
                while (dr.Read())
                {
                    DMChuyenNganh item = new DMChuyenNganh(
     i,
     dr.GetString("MaChuyenNganh"),
     dr.GetString("TenChuyenNganh"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),
     dr.GetString("loai"),
     dr.GetByte("Cap"),
     dr.GetString("idparent")
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
