using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMDienCSachList : BusinessListBase<DMDienCSachList, DMDienCSach>
    {
        #region Factory Methods
        public static DMDienCSachList GetAllDMDienCSach()
        {
            return DataPortal.Fetch<DMDienCSachList>(new Criteria());
        }
        public void NewTo(DMDienCSach _DMDienCSach)
        {
            if (this.Count == 0)
                _DMDienCSach.OrderNumber = 1;
            else
                _DMDienCSach.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMDienCSach);
        }
        public void UpdatedTo(DMDienCSach _DMDienCSach)
        {

            _DMDienCSach.OrderNumber = this.Items[this.IndexOf(_DMDienCSach)].OrderNumber;
            this.Items[this.IndexOf(_DMDienCSach)] = _DMDienCSach;
        }
        public void RemoveTo(DMDienCSach _DMDienCSach)
        {
            this.Items.Remove(_DMDienCSach);

        }
        private DMDienCSachList()
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
                    _DK = "maDienCSach like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenDienCSach)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDienCSach(HTC.ShareVariables.pub_bQadmin   )))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMDienCSach item = new DMDienCSach(
     i,
     dr.GetString("maDienCSach"),
     dr.GetString("TenDienCSach"),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDienCSach(criteria.DK, false)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMDienCSach item = new DMDienCSach(
     i,
     dr.GetString("maDienCSach"),
     dr.GetString("TenDienCSach"),
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
