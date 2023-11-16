using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMTonGiaoList : BusinessListBase<DMTonGiaoList, DMTonGiao>
    {
        #region Factory Methods
        public static DMTonGiaoList GetAllDMTonGiao()
        {
            return DataPortal.Fetch<DMTonGiaoList>(new Criteria());
        }
        public void NewTo(DMTonGiao _DMTonGiao)
        {
            if (this.Count == 0)
                _DMTonGiao.OrderNumber = 1;
            else
                _DMTonGiao.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMTonGiao);
        }
        public void UpdatedTo(DMTonGiao _DMTonGiao)
        {

            _DMTonGiao.OrderNumber = this.Items[this.IndexOf(_DMTonGiao)].OrderNumber;
            this.Items[this.IndexOf(_DMTonGiao)] = _DMTonGiao;
        }
        public void RemoveTo(DMTonGiao _DMTonGiao)
        {
            this.Items.Remove(_DMTonGiao);

        }
        private DMTonGiaoList()
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
                    _DK = "MaTonGiao like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenTonGiao)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMTonGiao(HTC.ShareVariables.pub_bQadmin   )))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMTonGiao item = new DMTonGiao(
     i,
     dr.GetString("MaTonGiao"),
     dr.GetString("TenTonGiao"),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMTonGiao(criteria.DK, false)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMTonGiao item = new DMTonGiao(
     i,
     dr.GetString("MaTonGiao"),
     dr.GetString("TenTonGiao"),
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
