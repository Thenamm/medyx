using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMThueTNList : BusinessListBase<DMThueTNList, DMThueTN>
    {
        #region Factory Methods
        public static DMThueTNList GetAllDMThueTN()
        {
            return DataPortal.Fetch<DMThueTNList>(new Criteria());
        }
        public void NewTo(DMThueTN _DMThueTN)
        {
            if (this.Count == 0)
                _DMThueTN.OrderNumber = 1;
            else
                _DMThueTN.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMThueTN);
        }
        public void UpdatedTo(DMThueTN _DMThueTN)
        {

            _DMThueTN.OrderNumber = this.Items[this.IndexOf(_DMThueTN)].OrderNumber;
            this.Items[this.IndexOf(_DMThueTN)] = _DMThueTN;
        }
        public void RemoveTo(DMThueTN _DMThueTN)
        {
            this.Items.Remove(_DMThueTN);

        }
        private DMThueTNList()
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
                    _DK = "MaThueTN like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenThueTN)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMThueTN(HTC.ShareVariables.pub_bQadmin)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMThueTN item = new DMThueTN(
     i,
     dr.GetString("MaThueTN"),
     dr.GetString("TenThueTN"),
     dr.GetDecimal("MucLuongTu"),
     dr.GetDecimal("MucLuongDen"),
     dr.GetDecimal("Heso"),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMThueTN(criteria.DK, false)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMThueTN item = new DMThueTN(
     i,
     dr.GetString("MaThueTN"),
     dr.GetString("TenThueTN"),
     dr.GetDecimal("MucLuongTu"),
     dr.GetDecimal("MucLuongDen"),
     dr.GetDecimal("Heso"),
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
