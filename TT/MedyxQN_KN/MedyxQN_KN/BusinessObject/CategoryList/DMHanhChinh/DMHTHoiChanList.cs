using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMHTHoiChanList : BusinessListBase<DMHTHoiChanList, DMHTHoiChan>
    {
        #region Factory Methods
        public static DMHTHoiChanList GetAllDMHTHoiChan(Boolean qadmin)
        {
            return DataPortal.Fetch<DMHTHoiChanList>(new Criteria(qadmin));
        }

        public static DMBenhVienList FindDMHTHoiChanByMa(string MaHTHoiChan)
        {
            return DataPortal.Fetch<DMBenhVienList>(new CriteriaOther(1, MaHTHoiChan));
        }
        public static DMBenhVienList FindDMHTHoiChanByTen(string TenHTHoiChan)
        {
            return DataPortal.Fetch<DMBenhVienList>(new CriteriaOther(2, TenHTHoiChan));
        }

        public void NewTo(DMHTHoiChan _DMHTHoiChan)
        {
            if (this.Count == 0)
                _DMHTHoiChan.OrderNumber = 1;
            else
                _DMHTHoiChan.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMHTHoiChan);
        }
        public void UpdateTo(DMHTHoiChan _DMHTHoiChan)
        {
            _DMHTHoiChan.OrderNumber = this.Items[this.IndexOf(_DMHTHoiChan)].OrderNumber;
            this.Items[this.IndexOf(_DMHTHoiChan)] = _DMHTHoiChan;
        }
        public void RemoveTo(DMHTHoiChan DMHTHoiChan)
        {
            this.Items.Remove(DMHTHoiChan);
        }
        private DMHTHoiChanList()
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
            public Criteria(Boolean qadmin)
            {
                _qadmin = qadmin;
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
                    _DK = "MaHTHoiChan like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenHTHoiChan)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMHTHoiChan(criteria.qadmin  )))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMHTHoiChan item = new DMHTHoiChan(
     i,
     dr.GetString("MaHTHoiChan") ,
			                                dr.GetString("TenHTHoiChan") ,
			                                dr.GetString("GhiChu") ,
			                                dr.GetString("MaMay") ,
			                                dr.GetBoolean("Huy") ,
			                                dr.GetSmartDate("NgaySD", true) ,
			                                dr.GetString("NguoiSD"),
     dr.GetString("Hoten")
    
         );
                    this.Add(item);
                    i += 1;

                }
                //IsReadOnly = true;
            }
           
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMHTHoiChan(criteria.DK, false)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMHTHoiChan item = new DMHTHoiChan(
     i,
     dr.GetString("MaHTHoiChan"),
     dr.GetString("TenHTHoiChan"),
     dr.GetString("GhiChu"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", true),
     dr.GetString("NguoiSD"),
     dr.GetString("Hoten")

         );
                    this.Add(item);
                    i += 1;

                }
                //IsReadOnly = true;
            }
            

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        #endregion
    }
}
