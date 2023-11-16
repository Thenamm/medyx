using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMNgheNghiepList : ReadOnlyListBase<DMNgheNghiepList, DMNgheNghiep>
    {
        #region Factory Methods
        public static DMNgheNghiepList GetAllDMNgheNghiep()
        {
            return DataPortal.Fetch<DMNgheNghiepList>(new Criteria());
        }

        private DMNgheNghiepList()
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
                    _DK = "MaNN like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenNN)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            int i = 1;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMNgheNghiep()))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMNgheNghiep item = new DMNgheNghiep(
     i,
     dr.GetString("MaNN"), 
     dr.GetString ("TenNN"),
		 dr.GetString ("MaMay"),
		 dr.GetBoolean ("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD") 
    
         );
                    this.Add(item);
                    i +=1; 
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
            RaiseListChangedEvents = false;
            int i = 1;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMNgheNghiep(criteria.DK, false)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMNgheNghiep item = new DMNgheNghiep(
     i,
     dr.GetString("MaNN"),
     dr.GetString("TenNN"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD",false),
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
