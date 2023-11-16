
using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMMGThueThuNhapList : BusinessListBase<DMMGThueThuNhapList, DMMGThueThuNhap>
    {
        #region Factory Methods
        public static DMMGThueThuNhapList GetAllDMMGThueThuNhap()
        {
            return DataPortal.Fetch<DMMGThueThuNhapList>(new Criteria());
        }
        public void NewTo(DMMGThueThuNhap _DMMGThueThuNhap)
        {
            if (this.Count == 0)
                _DMMGThueThuNhap.OrderNumber = 1;
            else
                _DMMGThueThuNhap.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMMGThueThuNhap);
        }
        public void UpdatedTo(DMMGThueThuNhap _DMMGThueThuNhap)
        {

            _DMMGThueThuNhap.OrderNumber = this.Items[this.IndexOf(_DMMGThueThuNhap)].OrderNumber;
            this.Items[this.IndexOf(_DMMGThueThuNhap)] = _DMMGThueThuNhap;
        }
        public void RemoveTo(DMMGThueThuNhap _DMMGThueThuNhap)
        {
            this.Items.Remove(_DMMGThueThuNhap);

        }

        private DMMGThueThuNhapList()
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
                    _DK = "TenMGThueThuNhap like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenMGThueThuNhap)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMMGThueThuNhap(HTC.ShareVariables.pub_bQadmin)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMMGThueThuNhap item = new DMMGThueThuNhap(
     i,
     dr.GetString("MaMGThueThuNhap"),
     dr.GetString("TenMGThueThuNhap"),
     dr.GetString("GhiChu"),
     dr.GetDecimal("MucLuong"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),                           
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMMGThueThuNhap(criteria.DK, false)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMMGThueThuNhap item = new DMMGThueThuNhap(
     i,
     dr.GetString("MaMGThueThuNhap"),
     dr.GetString("TenMGThueThuNhap"),
     dr.GetString("GhiChu"),
     dr.GetDecimal("MucLuong"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),
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

