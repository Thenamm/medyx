using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMNCCList : ReadOnlyListBase<DMNCCList, DMNCC>
    {
        #region Factory Methods
        public static DMNCCList GetAllDMNCC(Byte loai)
        {
            return DataPortal.Fetch<DMNCCList>(new Criteria(loai,false ));
        }
        public static DMNCCList FindDMNCCByMa(Byte loai,String ma)
        {
            return DataPortal.Fetch<DMNCCList>(new CriteriaOther(loai,1, ma));
        }
        public static DMNCCList FindDMNCCByTen(Byte loai,String ten)
        {
            return DataPortal.Fetch<DMNCCList>(new CriteriaOther(loai,2, ten));
        }
        public static DMNCCList FindDMNCCByTenD(Byte loai,String ten)
        {
            return DataPortal.Fetch<DMNCCList>(new CriteriaOther(loai,3, ten));
        }
        private DMNCCList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access
        #region Criteria
        [Serializable()]
        private class Criteria
        {
            private Byte _Loai;
             private Boolean _qadmin = false ;
            public Byte Loai
            {
                get
                {
                    return _Loai;
                }
            }
            public bool  qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public Criteria(Byte mLoai, Boolean  mqadmin)
            {
                _Loai = mLoai;
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
            public CriteriaOther(Byte loai, Byte mIdFind, String mDK)
            {

                _IdFind = mIdFind;
                if (mIdFind == 1)
                    _DK = "MaNCC like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenNCC)) like N'" + mDK + "%'";
                else if (mIdFind == 3)
                    _DK = "ltrim(rtrim(TenNCC)) = N'" + mDK + "'";
                _DK = _DK + " and loai = " + loai + "";
            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMNCC(criteria.Loai, criteria.qadmin )))
            {
                int i = 1;
                IsReadOnly = false;
                //DMNCC item = new DMNCC(
                //                           i,
                //                           "",
                //                          "",
                //                           "",
                //                           "",
                //                           0,
                //                           false,
                //                           false,
                //                           SmartDate.Parse(""),
                //                           "","",""

                //                               );
                //this.Add(item);
                //i += 1;
                while (dr.Read())
                {
                    DMNCC item = new DMNCC(
     i,
     dr.GetString("MaNCC"), 
     dr.GetString ("TenNCC"),
     dr.GetString("Ghichu"),
		 dr.GetString ("MaMay"),
     dr.GetByte("Loai"), 
		 dr.GetBoolean ("Huy"),
     dr.GetBoolean("KhongSD"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"),
     dr.GetString("Tenta"),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMNCC(criteria.DK, false)))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMNCC item = new DMNCC(
     i,
     dr.GetString("MaNCC"),
     dr.GetString("TenNCC"),
     dr.GetString("Ghichu"),
     dr.GetString("MaMay"),
     dr.GetByte("Loai"),
     dr.GetBoolean("Huy"),
     dr.GetBoolean("KhongSD"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"),
     dr.GetString("Tenta"),
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
