using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMTinhList : ReadOnlyListBase<DMTinhList, DMTinh>
    {
        #region Factory Methods
        public static DMTinhList GetAllDMTinh()
        {
            return DataPortal.Fetch<DMTinhList>(new Criteria());
        }
        public static DMTinhList FindDMTinhByMa(string MaTinh)
        {
            return DataPortal.Fetch<DMTinhList>(new CriteriaOther(1, MaTinh));
        }
        public static DMTinhList FindDMTinhByTen(string TenTinh)
        {
            return DataPortal.Fetch<DMTinhList>(new CriteriaOther(2, TenTinh));
        }
        public static DMTinhList FindDMTinhByTenD(string TenTinh)
        {
            return DataPortal.Fetch<DMTinhList>(new CriteriaOther(4, TenTinh));
        }
        private DMTinhList()
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
                    _DK = "MaTinh like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenTinh)) like N'" + mDK + "%'";

                else if (mIdFind == 4)
                    _DK = "ltrim(rtrim(TenTinh)) like N'" + mDK + "'";
            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMTinh()))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMTinh item = new DMTinh(
     i,
     dr.GetString("MaTinh"), 
			                                dr.GetString("MaQU"), 
			                                dr.GetString("maVungLT"),
     dr.GetString("TenTinh") ,
			                                dr.GetString("MaBHYT"), 
			                                dr.GetString("MaMay"), 
			                                dr.GetBoolean("Huy"), 
			                                dr.GetSmartDate("NgaySD",false), 
			                                dr.GetString("NguoiSD"),
     dr.GetString("HoTen"), 
     dr.GetString("tenvunglt") 
    
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMTinh(criteria.DK, false)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMTinh item = new DMTinh(
     i,
     dr.GetString("MaTinh"),
     dr.GetString("MaQU"),
     dr.GetString("maVungLT"),
     dr.GetString("TenTinh"),
     dr.GetString("MaBHYT"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),
     dr.GetString("HoTen"),
     dr.GetString("tenvunglt") 

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
