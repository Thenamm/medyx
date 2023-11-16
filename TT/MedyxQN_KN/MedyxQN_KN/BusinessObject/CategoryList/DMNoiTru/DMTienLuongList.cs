using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMTienLuongList : BusinessListBase<DMTienLuongList, DMTienLuong>
    {
        #region Factory Methods
        public static DMTienLuongList GetAllDMTienLuong()
        {
            return DataPortal.Fetch<DMTienLuongList>(new Criteria());
        }
        // tim theo dieu kien ten
        public static DMTienLuongList FindDMTienLuongByTen(string TenTienLuong)
        {
            return DataPortal.Fetch<DMTienLuongList>(new CriteriaOther(2, TenTienLuong));
        }
        public static DMTienLuongList FindDMDichVuByMa(string MaTienLuong)
        {
            return DataPortal.Fetch<DMTienLuongList>(new CriteriaOther(1, MaTienLuong));
        }
        public void NewTo(DMTienLuong _DMTienLuong)
        {
            if (this.Count == 0)
                _DMTienLuong.OrderNumber = 1;
            else
            _DMTienLuong.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMTienLuong);
        }
        public void UpdatedTo(DMTienLuong _DMTienLuong)
        {

            _DMTienLuong.OrderNumber = this.Items[this.IndexOf(_DMTienLuong)].OrderNumber;
            this.Items[this.IndexOf(_DMTienLuong)] = _DMTienLuong;
        }
        public void RemoveTo(DMTienLuong _DMTienLuong)
        {
            this.Items.Remove(_DMTienLuong);

        }

        private DMTienLuongList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

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
           
        }

        // tim kiem theo ten
        #region CriteriaOther
        [Serializable()]
        private class CriteriaOther
        {
            //private int _id;
            //public int Id
            //{
            //    get
            //    {
            //        return _id;
            //    }
            //}
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
                    _DK = "MaTienLuong like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenTienLuong)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMTienLuong( criteria.qadmin )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMTienLuong item = new DMTienLuong(
     i,
    dr.GetString("MaTienluong"),
			                               dr.GetString("TenTienluong"),
			                               dr.GetString("MaMay") ,
			                               dr.GetBoolean("Huy") ,
			                               dr.GetSmartDate("NgaySD", true) ,
			                               dr.GetString("NguoiSD") ,
			                               dr.GetString("GhiChu") ,
     dr.GetString("hoten")
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMTienLuong(criteria.DK, false)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMTienLuong item = new DMTienLuong(
     i,
     dr.GetString("MaTienluong"),
			                               dr.GetString("TenTienluong"),
			                               dr.GetString("MaMay") ,
			                               dr.GetBoolean("Huy") ,
			                               dr.GetSmartDate("NgaySD", true) ,
			                               dr.GetString("NguoiSD") ,
			                               dr.GetString("GhiChu") ,
     dr.GetString("hoten")
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
