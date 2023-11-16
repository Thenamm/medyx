using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMHTKyLuatList : BusinessListBase<DMHTKyLuatList, DMHTKyLuat>
    {
        #region Factory Methods
        public static DMHTKyLuatList GetAllDMHTKyLuat()
        {
            return DataPortal.Fetch<DMHTKyLuatList>(new Criteria());
        }
        public void NewTo(DMHTKyLuat _DMHTKyLuat)
        {
            if (this.Count == 0)
                _DMHTKyLuat.OrderNumber = 1;
            else
                _DMHTKyLuat.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMHTKyLuat);
        }
        public void UpdatedTo(DMHTKyLuat _DMHTKyLuat)
        {

            _DMHTKyLuat.OrderNumber = this.Items[this.IndexOf(_DMHTKyLuat)].OrderNumber;
            this.Items[this.IndexOf(_DMHTKyLuat)] = _DMHTKyLuat;
        }
        public void RemoveTo(DMHTKyLuat _DMHTKyLuat)
        {
            this.Items.Remove(_DMHTKyLuat);

        }
        private DMHTKyLuatList()
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
                    _DK = "maHTKyLuat like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenHTKyLuat)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMHTKyLuat(HTC.ShareVariables.pub_bQadmin)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMHTKyLuat item = new DMHTKyLuat(
     i,
     dr.GetString("maHTKyLuat"),
     dr.GetString("TenHTKyLuat"),
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

        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMHTKyLuat(criteria.DK, false)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMHTKyLuat item = new DMHTKyLuat(
     i,
     dr.GetString("maHTKyLuat"),
     dr.GetString("TenHTKyLuat"),
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
