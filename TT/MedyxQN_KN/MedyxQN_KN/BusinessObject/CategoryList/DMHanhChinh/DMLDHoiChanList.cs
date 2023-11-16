using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMLDHoiChanList : BusinessListBase<DMLDHoiChanList, DMLDHoiChan>
    {
        #region Factory Methods
        public static DMLDHoiChanList GetAllDMLDHoiChan(Boolean qadmin)
        {
            return DataPortal.Fetch<DMLDHoiChanList>(new Criteria(qadmin));
        }

        public static DMLDHoiChanList FindDMLDHoiChanByMa(string MaLDHoiChan)
        {
            return DataPortal.Fetch<DMLDHoiChanList>(new CriteriaOther(1, MaLDHoiChan));
        }
        public static DMLDHoiChanList FindDMLDHoiChanByTen(string TenLDHoiChan)
        {
            return DataPortal.Fetch<DMLDHoiChanList>(new CriteriaOther(2, TenLDHoiChan));
        }

        public void NewTo(DMLDHoiChan _DMLDHoiChan)
        {
            if (this.Count == 0)
                _DMLDHoiChan.OrderNumber = 1;
            else
                _DMLDHoiChan.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMLDHoiChan);
        }
        public void UpdateTo(DMLDHoiChan _DMLDHoiChan)
        {
            _DMLDHoiChan.OrderNumber = this.Items[this.IndexOf(_DMLDHoiChan)].OrderNumber;
            this.Items[this.IndexOf(_DMLDHoiChan)] = _DMLDHoiChan;
        }
        public void RemoveTo(DMLDHoiChan DMLDHoiChan)
        {
            this.Items.Remove(DMLDHoiChan);
        }
        private DMLDHoiChanList()
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
                    _DK = "MaLDHoiChan like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenLDHoiChan)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMLDHoiChan(criteria.qadmin  )))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMLDHoiChan item = new DMLDHoiChan(
     i,
     dr.GetString("MaLDHoiChan") ,
			                                dr.GetString("TenLDHoiChan") ,
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMLDHoiChan(criteria.DK, false)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMLDHoiChan item = new DMLDHoiChan(
     i,
     dr.GetString("MaLDHoiChan"),
     dr.GetString("TenLDHoiChan"),
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
