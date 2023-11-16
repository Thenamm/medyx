using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMHocHamList : BusinessListBase<DMHocHamList, DMHocHam>
    {
        #region Factory Methods
        public static DMHocHamList GetAllDMHocHam()
        {
            return DataPortal.Fetch<DMHocHamList>(new Criteria());
        }
        public void NewTo(DMHocHam _DMHocHam)
        {
            if (this.Count == 0)
                _DMHocHam.OrderNumber = 1;
            else
                _DMHocHam.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMHocHam);
        }
        public void UpdatedTo(DMHocHam _DMHocHam)
        {

            _DMHocHam.OrderNumber = this.Items[this.IndexOf(_DMHocHam)].OrderNumber;
            this.Items[this.IndexOf(_DMHocHam)] = _DMHocHam;
        }
        public void RemoveTo(DMHocHam _DMHocHam)
        {
            this.Items.Remove(_DMHocHam);

        }

        private DMHocHamList()
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
                    _DK = "MaHocHam like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenHocHam)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMHocHam(HTC.ShareVariables.pub_bQadmin   )))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMHocHam item = new DMHocHam(
     i,
     dr.GetString("MaHocHam"),
     dr.GetString("TenHocHam"),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMHocHam(criteria.DK, false)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMHocHam item = new DMHocHam(
     i,
     dr.GetString("MaHocHam"),
     dr.GetString("TenHocHam"),
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
