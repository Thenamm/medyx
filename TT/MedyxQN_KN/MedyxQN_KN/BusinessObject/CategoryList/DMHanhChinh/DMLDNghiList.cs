using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMLDNghiList : BusinessListBase<DMLDNghiList, DMLDNghi>
    {
        #region Factory Methods
        public static DMLDNghiList GetAllDMLDNghi()
        {
            return DataPortal.Fetch<DMLDNghiList>(new Criteria());
        }
        public void NewTo(DMLDNghi _DMLDNghi)
        {
            if (this.Count == 0)
                _DMLDNghi.OrderNumber = 1;
            else
                _DMLDNghi.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMLDNghi);
        }
        public void UpdatedTo(DMLDNghi _DMLDNghi)
        {

            _DMLDNghi.OrderNumber = this.Items[this.IndexOf(_DMLDNghi)].OrderNumber;
            this.Items[this.IndexOf(_DMLDNghi)] = _DMLDNghi;
        }
        public void RemoveTo(DMLDNghi _DMLDNghi)
        {
            this.Items.Remove(_DMLDNghi);

        }
        private DMLDNghiList()
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
                    _DK = "maLDNghi like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenLDNghi)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMLDNghi(HTC.ShareVariables.pub_bQadmin)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMLDNghi item = new DMLDNghi(
     i,
     dr.GetString("maLDNghi"),
     dr.GetString("TenLDNghi"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),
     dr.GetString("GhiChu"),
     dr.GetString("HoTen")

         );
                    this.Add(item);
                    i += 1;

                }
            }


            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMLDNghi(criteria.DK, false)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMLDNghi item = new DMLDNghi(
     i,
     dr.GetString("maLDNghi"),
     dr.GetString("TenLDNghi"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),
     dr.GetString("GhiChu"),
     dr.GetString("HoTen")

         );
                    this.Add(item);
                    i += 1;

                }
            }

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
    }
}
