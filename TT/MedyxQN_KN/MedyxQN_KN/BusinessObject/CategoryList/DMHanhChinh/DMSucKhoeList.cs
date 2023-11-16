using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMSucKhoeList : BusinessListBase<DMSucKhoeList, DMSucKhoe>
    {
        #region Factory Methods
        public static DMSucKhoeList GetAllDMSucKhoe()
        {
            return DataPortal.Fetch<DMSucKhoeList>(new Criteria());
        }
        public void NewTo(DMSucKhoe _DMSucKhoe)
        {
            if (this.Count == 0)
                _DMSucKhoe.OrderNumber = 1;
            else
                _DMSucKhoe.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMSucKhoe);
        }
        public void UpdatedTo(DMSucKhoe _DMSucKhoe)
        {

            _DMSucKhoe.OrderNumber = this.Items[this.IndexOf(_DMSucKhoe)].OrderNumber;
            this.Items[this.IndexOf(_DMSucKhoe)] = _DMSucKhoe;
        }
        public void RemoveTo(DMSucKhoe _DMSucKhoe)
        {
            this.Items.Remove(_DMSucKhoe);

        }

        private DMSucKhoeList()
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
                    _DK = "MaSucKhoe like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenSucKhoe)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMSucKhoe(HTC.ShareVariables.pub_bQadmin   )))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMSucKhoe item = new DMSucKhoe(
     i,
     dr.GetString("MaSucKhoe"),
     dr.GetString("TenSucKhoe"),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMSucKhoe(criteria.DK, false)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMSucKhoe item = new DMSucKhoe(
     i,
     dr.GetString("MaSucKhoe"),
     dr.GetString("TenSucKhoe"),
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
