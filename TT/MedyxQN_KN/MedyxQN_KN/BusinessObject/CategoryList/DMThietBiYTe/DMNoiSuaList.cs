using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMNoiSuaList : ReadOnlyListBase<DMNoiSuaList, DMNoiSua>
    {
        #region Factory Methods
        public static DMNoiSuaList GetAllDMNoiSua()
        {
            return DataPortal.Fetch<DMNoiSuaList>(new Criteria(HTC.ShareVariables.pub_bQadmin));
        }
        public static DMNoiSuaList FindDMNoiSuaByMa(String ma)
        {
            return DataPortal.Fetch<DMNoiSuaList>(new CriteriaOther(1, ma));
        }
        public static DMNoiSuaList FindDMNoiSuaByTen(String ten)
        {
            return DataPortal.Fetch<DMNoiSuaList>(new CriteriaOther(2, ten));
        }
        private DMNoiSuaList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access
        #region Criteria
        [Serializable()]
        private class Criteria
        {
            private Boolean _Loai;
             private Boolean _qadmin = false ;
            public Boolean Loai
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
            public Criteria( Boolean  mqadmin)
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
                    _DK = "MaNoiSua like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenNoiSua)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMNoiSua( criteria.qadmin )))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMNoiSua item = new DMNoiSua(
     i,
     dr.GetString("MaNoiSua"), 
     dr.GetString ("TenNoiSua"),
     dr.GetString("Ghichu"),
     dr.GetString ("DiaChi"),
     dr.GetString ("DienThoai"),
		 dr.GetString ("MaMay"),
     dr.GetByte ("Loai"), 
		 dr.GetBoolean ("Huy"),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMNoiSua(criteria.DK, false)))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMNoiSua item = new DMNoiSua(
     i,
     dr.GetString("MaNoiSua"),
     dr.GetString("TenNoiSua"),
     dr.GetString("Ghichu"),
     dr.GetString("DiaChi"),
     dr.GetString("DienThoai"),
     dr.GetString("MaMay"),
     dr.GetByte  ("Loai"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
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
