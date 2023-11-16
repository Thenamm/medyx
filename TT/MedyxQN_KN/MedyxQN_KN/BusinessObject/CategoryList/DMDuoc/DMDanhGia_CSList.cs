using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMDanhGia_CSList : BusinessListBase<DMDanhGia_CSList, DMDanhGia_CS>
    {
        #region Factory Methods
        public static DMDanhGia_CSList GetAllDMDanhGia_CS(string _maDG )
        {
            return DataPortal.Fetch<DMDanhGia_CSList>(new Criteria(_maDG));
        }

        public void NewTo(DMDanhGia_CS _DMDanhGia_CS)
        {
            if (this.Count == 0)
                _DMDanhGia_CS.OrderNumber = 1;
            else
            _DMDanhGia_CS.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMDanhGia_CS);
        }
        public void UpdatedTo(DMDanhGia_CS _DMDanhGia_CS)
        {

            _DMDanhGia_CS.OrderNumber = this.Items[this.IndexOf(_DMDanhGia_CS)].OrderNumber;
            this.Items[this.IndexOf(_DMDanhGia_CS)] = _DMDanhGia_CS;
        }
        public void RemoveTo(DMDanhGia_CS _DMDanhGia_CS)
        {
            this.Items.Remove(_DMDanhGia_CS);

        }

        private DMDanhGia_CSList()
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
            private string _maDG;
            public string maDG
            {
                get
                {
                    return _maDG;
                }
            }
            public Criteria(string mmaDG)
            {
                _maDG = mmaDG;
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
                    _DK = "MACS like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenCS)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDanhGia_CS(criteria.qadmin, criteria.maDG )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMDanhGia_CS item = new DMDanhGia_CS(
     i,
     dr.GetString("MaCS"), 
     dr.GetString ("TenCS"),
     dr.GetString("maDG"),
      dr.GetString("YeuCau"),
        dr.GetDecimal("dongiatt"),
		 dr.GetString("MaMay"),
		 dr.GetBoolean ("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"),
     dr.GetString("hoten"),
     dr.GetString("tenDG"),
     dr.GetString("tenloaics")
         );
                    this.Add(item);
                    i += 1;

                }
                //IsReadOnly = true;
            }
            // Xem lai doan code duoi
            //ArrayList arrList;
            //arrList = CBO.FillCollection(DataProvider.Instance().GetLocations(criteria.Id), typeof(LocationListInfo));
            //IsReadOnly = false;
            //foreach (LocationListInfo obj in arrList)
            //{
            //    this.Add(obj);
            //}
            //IsReadOnly = true;

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDanhGia_CS(criteria.DK, false)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMDanhGia_CS item = new DMDanhGia_CS(
     i,
     dr.GetString("MaCS"),
     dr.GetString("TenCS"),
     dr.GetString("maDG"),
      dr.GetString("YeuCau"),
        dr.GetDecimal("dongiatt"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"),
     dr.GetString("hoten"),
     dr.GetString("tenDG"),
     dr.GetString("tenloaics")
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
