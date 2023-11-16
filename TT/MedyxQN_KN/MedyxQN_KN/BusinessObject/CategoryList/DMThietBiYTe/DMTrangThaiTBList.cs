using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMTrangThaiTBList : BusinessListBase<DMTrangThaiTBList, DMTrangThaiTB>
    {
        #region Factory Methods
        public static DMTrangThaiTBList GetAllDMTrangThaiTB()
        {
            return DataPortal.Fetch<DMTrangThaiTBList>(new Criteria());
        }
        public void NewTo(DMTrangThaiTB _DMTrangThaiTB)
        {
            if (this.Count == 0)
                _DMTrangThaiTB.OrderNumber = 1;
            else
                _DMTrangThaiTB.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMTrangThaiTB);
        }
        public void UpdatedTo(DMTrangThaiTB _DMTrangThaiTB)
        {

            _DMTrangThaiTB.OrderNumber = this.Items[this.IndexOf(_DMTrangThaiTB)].OrderNumber;
            this.Items[this.IndexOf(_DMTrangThaiTB)] = _DMTrangThaiTB;
        }
        public void RemoveTo(DMTrangThaiTB _DMTrangThaiTB)
        {
            this.Items.Remove(_DMTrangThaiTB);

        }

        private DMTrangThaiTBList()
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
                    _DK = "MaTrangThaiTB like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenTrangThaiTB)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMTrangThaiTB(HTC.ShareVariables.pub_bQadmin)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMTrangThaiTB item = new DMTrangThaiTB(i,
     dr.GetString("MaTrangThai"),
     dr.GetString("TenTrangThai"),
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
          

            RaiseListChangedEvents = true;
        }

        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMTrangThaiTB(criteria.DK, false)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMTrangThaiTB item = new DMTrangThaiTB(
     i,
     dr.GetString("MaTrangThaiTB"),
     dr.GetString("TenTrangThaiTB"),
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
           
            RaiseListChangedEvents = true;
        }

        #endregion
    }
}
