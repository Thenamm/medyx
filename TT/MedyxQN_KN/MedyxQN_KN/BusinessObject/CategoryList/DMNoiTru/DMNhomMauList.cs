using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMNhomMauList : BusinessListBase<DMNhomMauList, DMNhomMau>
    {
        #region Factory Methods
        public static DMNhomMauList GetAllDMNhomMau()
        {
            return DataPortal.Fetch<DMNhomMauList>(new Criteria());
        }
        // tim theo dieu kien ten
        public static DMNhomMauList FindDMNhomMauByTen(string TenNhomMau)
        {
            return DataPortal.Fetch<DMNhomMauList>(new CriteriaOther(2, TenNhomMau));
        }
        public static DMNhomMauList FindDMDichVuByMa(string MaNhomMau)
        {
            return DataPortal.Fetch<DMNhomMauList>(new CriteriaOther(1, MaNhomMau));
        }
        public void NewTo(DMNhomMau _DMNhomMau)
        {
            if (this.Count == 0)
                _DMNhomMau.OrderNumber = 1;
            else
            _DMNhomMau.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMNhomMau);
        }
        public void UpdatedTo(DMNhomMau _DMNhomMau)
        {

            _DMNhomMau.OrderNumber = this.Items[this.IndexOf(_DMNhomMau)].OrderNumber;
            this.Items[this.IndexOf(_DMNhomMau)] = _DMNhomMau;
        }
        public void RemoveTo(DMNhomMau _DMNhomMau)
        {
            this.Items.Remove(_DMNhomMau);

        }

        private DMNhomMauList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMNhomMau( criteria.qadmin )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMNhomMau item = new DMNhomMau(
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMNhomMau(criteria.DK, false)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMNhomMau item = new DMNhomMau(
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
