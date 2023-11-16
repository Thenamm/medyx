using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMPhanLoaiList : BusinessListBase<DMPhanLoaiList, DMPhanLoai>
    {
        #region Factory Methods
        public static DMPhanLoaiList GetAllDMPhanLoai()
        {
            return DataPortal.Fetch<DMPhanLoaiList>(new Criteria() );
        }
        public void NewTo(DMPhanLoai _DMPhanLoai)
        {
            if (this.Count == 0)
                _DMPhanLoai.OrderNumber = 1;
            else
            _DMPhanLoai.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMPhanLoai);
        }
        public void UpdatedTo(DMPhanLoai _DMPhanLoai)
        {

            _DMPhanLoai.OrderNumber = this.Items[this.IndexOf(_DMPhanLoai)].OrderNumber;
            this.Items[this.IndexOf(_DMPhanLoai)] = _DMPhanLoai;
        }
        public void RemoveTo(DMPhanLoai _DMPhanLoai)
        {
            this.Items.Remove(_DMPhanLoai);

        }

        private DMPhanLoaiList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        #region Criteria
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
                    _DK = "MaPL like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenPL)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMPhanLoai(criteria.qadmin)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMPhanLoai item = new DMPhanLoai(
     i,
     dr.GetString("MaPL"), 
     dr.GetString ("TenPL"),
     dr.GetString("Ghichu"),
		 dr.GetString ("MaMay"),
		 dr.GetBoolean ("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMPhanLoai(criteria.DK, false)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMPhanLoai item = new DMPhanLoai(
     i,
     dr.GetString("MaPL"),
     dr.GetString("TenPL"),
     dr.GetString("Ghichu"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"),
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
