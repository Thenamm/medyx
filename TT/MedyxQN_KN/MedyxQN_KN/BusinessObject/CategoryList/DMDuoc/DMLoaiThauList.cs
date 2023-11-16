using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMLoaiThauList : ReadOnlyListBase<DMLoaiThauList, DMLoaiThau>
    {
        #region Factory Methods
        public static DMLoaiThauList GetAllDMLoaiThau(byte loai, bool qAdmin)
        {
            return DataPortal.Fetch<DMLoaiThauList>(new Criteria(loai, qAdmin));
        }

        private DMLoaiThauList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            private byte _Loai;
            public byte Loai
            {
                get
                {
                    return _Loai;
                }
            }
            private bool _qAdmin;
            public bool qAdmin
            {
                get
                {
                    return _qAdmin;
                }
            }
            public Criteria(byte Loai, bool qAdmin)
            {
                _Loai = Loai;
                _qAdmin = qAdmin;
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
                    _DK = "MaCV like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenCV)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMLoaiThau(criteria.Loai, criteria.qAdmin)))
            {
                int i = 1;

                IsReadOnly = false;
                while (dr.Read())
                {
                    DMLoaiThau item = new DMLoaiThau(
     i,
     dr.GetString("MaLoaiThau"), 
     dr.GetString ("TenLoaiThau"),
     dr.GetByte("Loai"),
     dr.GetString("TenTA"),
     dr.GetString("GhiChu"),
     dr.GetBoolean("KhongSD"),
		 dr.GetString ("MaMay"),
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
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMLoaiThau(criteria.DK, false)))
            {
                int i = 1;

                IsReadOnly = false;
                while (dr.Read())
                {
                    DMLoaiThau item = new DMLoaiThau(
     i,
     dr.GetString("MaLoaiThau"),
     dr.GetString("TenLoaiThau"),
     dr.GetByte("Loai"),
     dr.GetString("TenTA"),
     dr.GetString("GhiChu"),
     dr.GetBoolean("KhongSD"),
         dr.GetString("MaMay"),
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
