using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMTenTatList : ReadOnlyListBase<DMTenTatList, DMTenTat>
    {
        #region Factory Methods
        public static DMTenTatList GetAllDMTenTat()
        {
            return DataPortal.Fetch<DMTenTatList>(new Criteria(""));
        }
        public static DMTenTatList GetAllDMTenTatByTenTat(string ten)
        {
            return DataPortal.Fetch<DMTenTatList>(new Criteria(ten));
        }
        private DMTenTatList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            private string _dk;
            public string DK
            {
                get
                {
                    return _dk;
                }
            }
            public Criteria(string mId)
            {
                _dk=  "and tententat like '"+ mId +"%'";
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
                    _DK = "maTenTat like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(tenTenTat)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            if (criteria.DK !="")
          {
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMTenTat(criteria .DK,false )))
            {
                int i = 1;

                IsReadOnly = false;
                while (dr.Read())
                {
                    DMTenTat item = new DMTenTat(
     i,
     dr.GetString("maTenTat"),
     dr.GetString("tenTenTat"),
      dr.GetString("GhiChu"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD")

         );
                    this.Add(item);
                    i += 1;
            }
                IsReadOnly = true;
            }}
            else
            {
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance() .GetAllDMTenTat(HTC.ShareVariables.pub_bQadmin)))
            {
                int i = 1;

                IsReadOnly = false;
                while (dr.Read())
                {
                    DMTenTat item = new DMTenTat(
     i,
     dr.GetString("maTenTat"),
     dr.GetString("tenTenTat"),
      dr.GetString("GhiChu"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD")

         );
                    this.Add(item);
                    i += 1;

                }
                IsReadOnly = true;
            }}
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMTenTat(criteria.DK, false)))
            {
                int i = 1;

                IsReadOnly = false;
                while (dr.Read())
                {
                    DMTenTat item = new DMTenTat(
     i,
     dr.GetString("maTenTat"),
     dr.GetString("tenTenTat"),
     dr.GetString("Ghichu"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD")

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