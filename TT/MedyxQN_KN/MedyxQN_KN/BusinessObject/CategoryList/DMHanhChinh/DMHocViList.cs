using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMHocViList : BusinessListBase<DMHocViList, DMHocVi>
    {
        #region Factory Methods
        public static DMHocViList GetAllDMHocVi()
        {
            return DataPortal.Fetch<DMHocViList>(new Criteria());
        }
        public void NewTo(DMHocVi _DMHocVi)
        {
            if (this.Count == 0)
                _DMHocVi.OrderNumber = 1;
            else
                _DMHocVi.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMHocVi);
        }
        public void UpdatedTo(DMHocVi _DMHocVi)
        {

            _DMHocVi.OrderNumber = this.Items[this.IndexOf(_DMHocVi)].OrderNumber;
            this.Items[this.IndexOf(_DMHocVi)] = _DMHocVi;
        }
        public void RemoveTo(DMHocVi _DMHocVi)
        {
            this.Items.Remove(_DMHocVi);

        }
        private DMHocViList()
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
                    _DK = "MaHocVi like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenHocVi)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMHocVi(HTC.ShareVariables.pub_bQadmin   )))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMHocVi item = new DMHocVi(
     i,
     dr.GetString("MaHocVi"),
     dr.GetString("TenHocVi"),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMHocVi(criteria.DK, false)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMHocVi item = new DMHocVi(
     i,
     dr.GetString("MaHocVi"),
     dr.GetString("TenHocVi"),
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
