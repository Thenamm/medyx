using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMTDNgoaiNguList : BusinessListBase<DMTDNgoaiNguList, DMTDNgoaiNgu>
    {
        #region Factory Methods
        public static DMTDNgoaiNguList GetAllDMTDNgoaiNgu()
        {
            return DataPortal.Fetch<DMTDNgoaiNguList>(new Criteria());
        }
        public static DMTDNgoaiNguList FindDMTDNgoaiNguByTen(String ten)
        {
            return DataPortal.Fetch<DMTDNgoaiNguList>(new CriteriaOther(2, ten));
        }
        public void NewTo(DMTDNgoaiNgu _DMTDNgoaiNgu)
        {
            if (this.Count == 0)
                _DMTDNgoaiNgu.OrderNumber = 1;
            else
                _DMTDNgoaiNgu.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMTDNgoaiNgu);
        }
        public void UpdatedTo(DMTDNgoaiNgu _DMTDNgoaiNgu)
        {

            _DMTDNgoaiNgu.OrderNumber = this.Items[this.IndexOf(_DMTDNgoaiNgu)].OrderNumber;
            this.Items[this.IndexOf(_DMTDNgoaiNgu)] = _DMTDNgoaiNgu;
        }
        public void RemoveTo(DMTDNgoaiNgu _DMTDNgoaiNgu)
        {
            this.Items.Remove(_DMTDNgoaiNgu);

        }

        private DMTDNgoaiNguList()
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
                    _DK = "MaTDNgoaiNgu like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenTDNgoaiNgu)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMTDNgoaiNgu(HTC.ShareVariables.pub_bQadmin   )))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMTDNgoaiNgu item = new DMTDNgoaiNgu(
     i,
     dr.GetString("MaTDNgoaiNgu"),
     dr.GetString("TenTDNgoaiNgu"),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMTDNgoaiNgu(criteria.DK, false)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMTDNgoaiNgu item = new DMTDNgoaiNgu(
     i,
     dr.GetString("MaTDNgoaiNgu"),
     dr.GetString("TenTDNgoaiNgu"),
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
