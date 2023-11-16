using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMMayXNList : ReadOnlyListBase<DMMayXNList, DMMayXN>
    {
        #region Factory Methods
        public static DMMayXNList GetAllDMMayXN()
        {
            return DataPortal.Fetch<DMMayXNList>(new Criteria());
        }

        private DMMayXNList()
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

        // tim kiem theo ten
        #region CriteriaOther
        [Serializable()]
        private class CriteriaOther
        {
            //private int _id;
            //public int Id
            //{
            //    get
            //    {
            //        return _id;
            //    }
            //}
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
                    _DK = "tenmayxn like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(tendmmayxn)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMMayXN()))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMMayXN item = new DMMayXN(
     i,
     dr.GetString("tenmayxn"), 
     dr.GetString ("tendmmayxn"),
     dr.GetString("MaKhoa"),
      dr.GetString("TenKhoa"),
			                                dr.GetString("IP"),
		 dr.GetString ("MaMaySD"),
		 dr.GetBoolean ("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD") 
    
         );
                    this.Add(item);
                    i += 1;
                }
                IsReadOnly = true;
            }
            // Xem lai doan code duoi
            //ArrayList arrList;
            //arrList = CBO.FillCollection(DataProvider.Instance().GetLocations(criteria.Id), typeof(LocationListInfo));
            //IsReadOnly = false;
            //foreach (LocationListInfo obj in arrList)
            //{
            //    this.Add(obj);
            //}
            //IsReadOnly = true;

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMMayXN(criteria.DK, false)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMMayXN item = new DMMayXN(
     i,
     dr.GetString("tenmayxn"),
     dr.GetString("tendmmayxn"),
     dr.GetString("MaKhoa"),
      dr.GetString("TenKhoa"),
     dr.GetString("IP"),
     dr.GetString("MaMaySD"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD")

         );
                    this.Add(item);
                    i += 1;
                }
                IsReadOnly = true;
            }
            

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
    }
}
