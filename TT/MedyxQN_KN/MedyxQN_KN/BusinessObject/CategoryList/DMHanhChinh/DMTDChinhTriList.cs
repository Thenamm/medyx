using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMTDChinhTriList : BusinessListBase<DMTDChinhTriList, DMTDChinhTri>
    {
        #region Factory Methods
        public static DMTDChinhTriList GetAllDMTDChinhTri()
        {
            return DataPortal.Fetch<DMTDChinhTriList>(new Criteria());
        }
        public void NewTo(DMTDChinhTri _DMTDChinhTri)
        {
            if (this.Count == 0)
                _DMTDChinhTri.OrderNumber = 1;
            else
                _DMTDChinhTri.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMTDChinhTri);
        }
        public void UpdatedTo(DMTDChinhTri _DMTDChinhTri)
        {

            _DMTDChinhTri.OrderNumber = this.Items[this.IndexOf(_DMTDChinhTri)].OrderNumber;
            this.Items[this.IndexOf(_DMTDChinhTri)] = _DMTDChinhTri;
        }
        public void RemoveTo(DMTDChinhTri _DMTDChinhTri)
        {
            this.Items.Remove(_DMTDChinhTri);

        }

        private DMTDChinhTriList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMTDChinhTri(HTC.ShareVariables.pub_bQadmin   )))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMTDChinhTri item = new DMTDChinhTri(
     i,
     dr.GetString("MaTDChinhTri"),
     dr.GetString("TenTDChinhTri"),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMTDChinhTri(criteria.DK, false)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMTDChinhTri item = new DMTDChinhTri(
     i,
     dr.GetString("MaTDChinhTri"),
     dr.GetString("TenTDChinhTri"),
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
