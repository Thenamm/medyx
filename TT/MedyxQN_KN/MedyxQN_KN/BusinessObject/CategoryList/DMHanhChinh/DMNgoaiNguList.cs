using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMNgoaiNguList : BusinessListBase<DMNgoaiNguList, DMNgoaiNgu>
    {
        #region Factory Methods
        public static DMNgoaiNguList GetAllDMNgoaiNgu()
        {
            return DataPortal.Fetch<DMNgoaiNguList>(new Criteria());
        }
        public void NewTo(DMNgoaiNgu _DMNgoaiNgu)
        {
            if (this.Count == 0)
                _DMNgoaiNgu.OrderNumber = 1;
            else
                _DMNgoaiNgu.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMNgoaiNgu);
        }
        public void UpdatedTo(DMNgoaiNgu _DMNgoaiNgu)
        {

            _DMNgoaiNgu.OrderNumber = this.Items[this.IndexOf(_DMNgoaiNgu)].OrderNumber;
            this.Items[this.IndexOf(_DMNgoaiNgu)] = _DMNgoaiNgu;
        }
        public void RemoveTo(DMNgoaiNgu _DMNgoaiNgu)
        {
            this.Items.Remove(_DMNgoaiNgu);

        }

        private DMNgoaiNguList()
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
                    _DK = "MaNgoaiNgu like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenNgoaiNgu)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMNgoaiNgu(HTC.ShareVariables.pub_bQadmin   )))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMNgoaiNgu item = new DMNgoaiNgu(
     i,
     dr.GetString("MaNgoaiNgu"),
     dr.GetString("TenNgoaiNgu"),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMNgoaiNgu(criteria.DK, false)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMNgoaiNgu item = new DMNgoaiNgu(
     i,
     dr.GetString("MaNgoaiNgu"),
     dr.GetString("TenNgoaiNgu"),
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
