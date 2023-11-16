using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMViTriSTList : ReadOnlyListBase<DMViTriSTList, DMViTriST>
    {
        #region Factory Methods
        public static DMViTriSTList GetAllDMViTriST()
        {
            return DataPortal.Fetch<DMViTriSTList>(new Criteria());
        }
        public static DMViTriSTList FindDMViTriSTMa(string ma)
        {
            return DataPortal.Fetch<DMViTriSTList>(new CriteriaOther(1,ma));
        }
        public static DMViTriSTList FindDMViTriSTMaD(string ma)
        {
            return DataPortal.Fetch<DMViTriSTList>(new CriteriaOther(3,ma));
        }
        private DMViTriSTList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            
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
                    _DK = "( MaViTri like '%" + mDK + "' or maql like '" + mDK + "%')";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenViTri)) like N'" + mDK + "%'";
                else if (mIdFind == 3)
                    _DK = "( MaViTri like '" + mDK + "' or maql like '" + mDK + "')";

            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMViTriST()))
            {
                int i = 1;

                IsReadOnly = false;
                while (dr.Read())
                {
                    DMViTriST item = new DMViTriST(
     i,
     dr.GetString("MaViTri"), 
     dr.GetString ("TenViTri"),
		 dr.GetString ("MaMay"),
		 dr.GetBoolean ("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"),
     dr.GetString("maql"),
     dr.GetString("ghichu") 
    
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
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMViTriST(criteria.DK, false)))
            {
                int i = 1;

                IsReadOnly = false;
                while (dr.Read())
                {
                    DMViTriST item = new DMViTriST(
     i,
     dr.GetString("MaViTri"),
     dr.GetString("TenViTri"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"),
     dr.GetString("maql"),
     dr.GetString("ghichu")

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
