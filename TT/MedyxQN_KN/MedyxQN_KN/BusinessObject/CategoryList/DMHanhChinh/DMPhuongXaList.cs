using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMPhuongXaList : ReadOnlyListBase<DMPhuongXaList, DMPhuongXa>
    {
        #region Factory Methods
        public static DMPhuongXaList GetAllDMPhuongXa()
        {
            return DataPortal.Fetch<DMPhuongXaList>();
        }
        public static DMPhuongXaList GetsByQH(string idQH)
        {
            return DataPortal.Fetch<DMPhuongXaList>(new Criteria(idQH ));
        }
        private DMPhuongXaList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            private string _id;
            public string Id
            {
                get
                {
                    return _id;
                }
            }
            public Criteria(string mId)
            {
                _id = mId;
            }
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
                    _DK = "MaPXa like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenPXa)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch()
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMPhuongXa()))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMPhuongXa item = new DMPhuongXa(
     i,
     dr.GetString("MaPXa"), 
			                                dr.GetString("MaQH"), 
			                                dr.GetString("TenPXa"), 
			                                dr.GetString("MaBHXH"),
                                             dr.GetString("MaTat"), 
			                                dr.GetString("MaMay"), 
			                                dr.GetBoolean("Huy"), 
			                                dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"),
     dr.GetString("hoten"),
     dr.GetString("TenQH")
    
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
        private void DataPortal_Fetch(Criteria criteria)
        {
            int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetsByQH(criteria.Id )))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMPhuongXa item = new DMPhuongXa(
     i,
     dr.GetString("MaPXa"),
     dr.GetString("MaQH"),
     dr.GetString("TenPXa"),
     dr.GetString("MaBHXH"),
      dr.GetString("MaTat"), 
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"),
     dr.GetString("hoten"),
     dr.GetString("TenQH")

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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMPhuongXa(criteria.DK )))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMPhuongXa item = new DMPhuongXa(
     i,
     dr.GetString("MaPXa"),
     dr.GetString("MaQH"),
     dr.GetString("TenPXa"),
     dr.GetString("MaBHXH"),
      dr.GetString("MaTat"), 
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),
     dr.GetString("hoten"),
     dr.GetString("TenQH")

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
