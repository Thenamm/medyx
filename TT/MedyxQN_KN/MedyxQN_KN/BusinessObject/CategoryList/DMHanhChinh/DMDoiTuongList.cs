using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMDoiTuongList : ReadOnlyListBase<DMDoiTuongList, DMDoiTuong>
    {
        #region Factory Methods
        public static DMDoiTuongList GetAllDMDoiTuong()
        {
            return DataPortal.Fetch<DMDoiTuongList>(new Criteria());
        }
        public static DMDoiTuongList FindDMDoiTuongAccount()
        {
            return DataPortal.Fetch<DMDoiTuongList>(new CriteriaOther(1, ""));
        }
        public static DMDoiTuongList FindDMDoiTuongKyHieu(string kyhieu)
        {
            return DataPortal.Fetch<DMDoiTuongList>(new CriteriaOther(5, kyhieu));
        }
        public static DMDoiTuongList FindDMDoiTuongKyHieu(string dk, string kyhieu)
        {
            return DataPortal.Fetch<DMDoiTuongList>(new OtherCriteria(dk, kyhieu));
        }
        private DMDoiTuongList()
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
                    _DK = "MaDT like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenDT)) like N'" + mDK + "%'";
                else   if (mIdFind == 5)
                    _DK = "charindex(N'," + mDK + ",',kieuthe)<>0";
                else
                    { _DK = "  EXISTS(SELECT B.madt FROM ACCOUNT B WHERE ACCOUNT ='" + mDK;
                    _DK = _DK + "' AND (CHARINDEX( A.madt  ,B.MAdt,1) <> 0 OR  ALLMAdt = 1  ))"; };

            }
        }
        #endregion
        #region CriteriaOther

        [Serializable()]
        private class OtherCriteria
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
            public OtherCriteria(String sDK, String mDK)
            {
               
            _DK = "charindex(N'," + mDK + ",',kieuthe)<>0";
            _DK = _DK + " and madt like '" + sDK + "%'";
            

            }
        }
          #endregion
        private void DataPortal_Fetch(Criteria criteria)
        {
            int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDoiTuong()))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMDoiTuong item = new DMDoiTuong(
     i,
     dr.GetString("MaDT"), 
     dr.GetString ("TenDT"),
     dr.GetDecimal("bhtra"),
     dr.GetDecimal("SoTien"),
      dr.GetDecimal("SoTienKTC"),
		 dr.GetString ("MaMay"),
		 dr.GetBoolean ("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"),     
     false ,
     dr.GetString("Kieuthe")
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDoiTuong(criteria.DK, false)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMDoiTuong item = new DMDoiTuong(
     i,
     dr.GetString("MaDT"),
     dr.GetString("TenDT"),
     dr.GetDecimal("bhtra"),
     dr.GetDecimal("SoTien"),
     dr.GetDecimal("sotienKTC"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"),
     false ,
     dr.GetString("Kieuthe")
         );
                    this.Add(item);
                    i += 1;
                }
                IsReadOnly = true;
            }
           

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDoiTuong(criteria.DK, false)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMDoiTuong item = new DMDoiTuong(
     i,
     dr.GetString("MaDT"),
     dr.GetString("TenDT"),
     dr.GetDecimal("bhtra"),
     dr.GetDecimal("SoTien"),
       dr.GetDecimal("SoTienKTC"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),
     false,
     dr.GetString("Kieuthe")
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
