using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMLuongList : BusinessListBase<DMLuongList, DMLuong>
    {
        #region Factory Methods
        public static DMLuongList GetAllDMLuong()
        {
            return DataPortal.Fetch<DMLuongList>(new Criteria());
        }
        public void NewTo(DMLuong _DMLuong)
        {
            if (this.Count == 0)
                _DMLuong.OrderNumber = 1;
            else
                _DMLuong.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMLuong);
        }
        public void UpdatedTo(DMLuong _DMLuong)
        {

            _DMLuong.OrderNumber = this.Items[this.IndexOf(_DMLuong)].OrderNumber;
            this.Items[this.IndexOf(_DMLuong)] = _DMLuong;
        }
        public void RemoveTo(DMLuong _DMLuong)
        {
            this.Items.Remove(_DMLuong);

        }

        private DMLuongList()
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
                    _DK = "MaLuong like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenLuong)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMLuong(HTC.ShareVariables.pub_bQadmin   )))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMLuong item = new DMLuong(
     i,
     dr.GetString("MaLuong"),
     dr.GetString("TenLuong"),
     dr.GetDecimal("MucLuong"),
		 dr.GetString ("MaMay"),
		 dr.GetBoolean ("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD") ,
     dr.GetString("GhiChu") ,
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMLuong(criteria.DK, false)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMLuong item = new DMLuong(
     i,
     dr.GetString("MaLuong"),
     dr.GetString("TenLuong"),
     dr.GetDecimal("MucLuong"),
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
