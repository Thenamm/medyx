using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMDDHoiChanList : BusinessListBase<DMDDHoiChanList, DMDDHoiChan>
    {
        #region Factory Methods
        public static DMDDHoiChanList GetAllDMDDHoiChan(Boolean qadmin)
        {
            return DataPortal.Fetch<DMDDHoiChanList>(new Criteria(qadmin));
        }

        public static DMDDHoiChanList FindDMDDHoiChanByMa(string MaDDHoiChan)
        {
            return DataPortal.Fetch<DMDDHoiChanList>(new CriteriaOther(1, MaDDHoiChan));
        }
        public static DMDDHoiChanList FindDMDDHoiChanByTen(string TenDDHoiChan)
        {
            return DataPortal.Fetch<DMDDHoiChanList>(new CriteriaOther(2, TenDDHoiChan));
        }

        public void NewTo(DMDDHoiChan _DMDDHoiChan)
        {
            if (this.Count == 0)
                _DMDDHoiChan.OrderNumber = 1;
            else
                _DMDDHoiChan.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMDDHoiChan);
        }
        public void UpdateTo(DMDDHoiChan _DMDDHoiChan)
        {
            _DMDDHoiChan.OrderNumber = this.Items[this.IndexOf(_DMDDHoiChan)].OrderNumber;
            this.Items[this.IndexOf(_DMDDHoiChan)] = _DMDDHoiChan;
        }
        public void RemoveTo(DMDDHoiChan DMDDHoiChan)
        {
            this.Items.Remove(DMDDHoiChan);
        }
        private DMDDHoiChanList()
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
                    _DK = "MaDDHoiChan like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenDDHoiChan)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDDHoiChan(criteria.qadmin  )))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMDDHoiChan item = new DMDDHoiChan(
     i,
     dr.GetString("MaDDHoiChan") ,
			                                dr.GetString("TenDDHoiChan") ,
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDDHoiChan(criteria.DK, false)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMDDHoiChan item = new DMDDHoiChan(
     i,
     dr.GetString("MaDDHoiChan"),
     dr.GetString("TenDDHoiChan"),
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
