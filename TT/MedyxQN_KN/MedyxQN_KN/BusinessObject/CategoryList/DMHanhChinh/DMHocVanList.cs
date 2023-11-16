using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMHocVanList : BusinessListBase<DMHocVanList, DMHocVan>
    {
        #region Factory Methods
        public static DMHocVanList GetAllDMHocVan()
        {
            return DataPortal.Fetch<DMHocVanList>(new Criteria());
        }
        public void NewTo(DMHocVan _DMHocVan)
        {
            if (this.Count == 0)
                _DMHocVan.OrderNumber = 1;
            else
                _DMHocVan.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMHocVan);
        }
        public void UpdatedTo(DMHocVan _DMHocVan)
        {

            _DMHocVan.OrderNumber = this.Items[this.IndexOf(_DMHocVan)].OrderNumber;
            this.Items[this.IndexOf(_DMHocVan)] = _DMHocVan;
        }
        public void RemoveTo(DMHocVan _DMHocVan)
        {
            this.Items.Remove(_DMHocVan);

        }
        private DMHocVanList()
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
                    _DK = "maHocVan like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenHocVan)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMHocVan(HTC.ShareVariables.pub_bQadmin   )))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMHocVan item = new DMHocVan(
     i,
     dr.GetString("maHocVan"),
     dr.GetString("TenHocVan"),
		 dr.GetString ("MaMay"),
		 dr.GetBoolean ("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD") ,
     dr.GetString("GhiChu") ,
     dr.GetString("HoTen") 
    
         );
                    this.Add(item);
                    i += 1;

                }
            }
         

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMHocVan(criteria.DK, false)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMHocVan item = new DMHocVan(
     i,
     dr.GetString("maHocVan"),
     dr.GetString("TenHocVan"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),
     dr.GetString("GhiChu"),
     dr.GetString("HoTen") 

         );
                    this.Add(item);
                    i += 1;

                }
            }
           
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
    }
}
