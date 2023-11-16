using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMDTsudungList : ReadOnlyListBase<DMDTsudungList, DMDTsudung>
    {
        #region Factory Methods
        public static DMDTsudungList GetAllDMDTsudung()
        {
            return DataPortal.Fetch<DMDTsudungList>();
        }

        private DMDTsudungList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access
        #region Criteria
        [Serializable()]
        private class Criteria
        {

             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public Criteria(Boolean mqadmin)
            {

                _qadmin = mqadmin;
            }
        }
        #endregion

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
                    _DK = "MaDTsudung like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenDTsudung)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDTsudung(criteria.qadmin)))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMDTsudung item = new DMDTsudung(
     i,
     dr.GetDecimal("MaDTsudung"),
     dr.GetString("TenDTsudung"),
     dr.GetByte("PPTinh") ,
			                                dr.GetString("Ghichu") ,
			                                dr.GetDecimal("SLTu") ,
			                                dr.GetDecimal("SLDen") ,
		 dr.GetString("MaMay"),
		 dr.GetBoolean ("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"), 
     dr.GetString("hoten") 
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDTsudung(criteria.DK, false)))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMDTsudung item = new DMDTsudung(
     i,
     dr.GetDecimal("MaDTsudung"),
     dr.GetString("TenDTsudung"),
     dr.GetByte("PPTinh"),
     dr.GetString("Ghichu"),
     dr.GetDecimal("SLTu"),
     dr.GetDecimal("SLDen"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"),
     dr.GetString("hoten")
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
