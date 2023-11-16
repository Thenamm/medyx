using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMHTDaoTaoList : BusinessListBase<DMHTDaoTaoList, DMHTDaoTao>
    {
        #region Factory Methods
        public static DMHTDaoTaoList GetAllDMHinhThucDaoTao()
        {
            return DataPortal.Fetch<DMHTDaoTaoList>(new Criteria());
        }
        public void NewTo(DMHTDaoTao _DMHTDaoTao)
        {
            if (this.Count == 0)
                _DMHTDaoTao.OrderNumber = 1;
            else
                _DMHTDaoTao.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMHTDaoTao);
        }
        public void UpdatedTo(DMHTDaoTao _DMHTDaoTao)
        {

            _DMHTDaoTao.OrderNumber = this.Items[this.IndexOf(_DMHTDaoTao)].OrderNumber;
            this.Items[this.IndexOf(_DMHTDaoTao)] = _DMHTDaoTao;
        }
        public void RemoveTo(DMHTDaoTao _DMHTDaoTao)
        {
            this.Items.Remove(_DMHTDaoTao);

        }

        private DMHTDaoTaoList()
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
                    _DK = "MaHTDaoTao like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenHTDaoTao)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMHinhThucDaoTao(HTC.ShareVariables.pub_bQadmin   )))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMHTDaoTao item = new DMHTDaoTao(
     i,
     dr.GetString("MaHTDaoTao"),
     dr.GetString("TenHTDaoTao"),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMHinhThucDaoTao(criteria.DK, false)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMHTDaoTao item = new DMHTDaoTao(
     i,
     dr.GetString("MaHTDaoTao"),
     dr.GetString("TenHTDaoTao"),
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
