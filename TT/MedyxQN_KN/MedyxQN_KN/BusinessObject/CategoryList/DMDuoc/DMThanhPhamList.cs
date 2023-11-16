using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMThanhPhamList : BusinessListBase<DMThanhPhamList, DMThanhPham>
    {
        #region Factory Methods
        public static DMThanhPhamList GetAllDMThanhPham(string _maNhom )
        {
            return DataPortal.Fetch<DMThanhPhamList>(new Criteria(_maNhom));
        }
        public static DMThanhPhamList GetAllDMThanhPham()
        {
            return DataPortal.Fetch<DMThanhPhamList>(new Criteria(""));
        }
        public void NewTo(DMThanhPham _DMThanhPham)
        {
            if (this.Count == 0)
                _DMThanhPham.OrderNumber = 1;
            else
            _DMThanhPham.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMThanhPham);
        }
        public void UpdatedTo(DMThanhPham _DMThanhPham)
        {

            _DMThanhPham.OrderNumber = this.Items[this.IndexOf(_DMThanhPham)].OrderNumber;
            this.Items[this.IndexOf(_DMThanhPham)] = _DMThanhPham;
        }
        public void RemoveTo(DMThanhPham _DMThanhPham)
        {
            this.Items.Remove(_DMThanhPham);

        }

        private DMThanhPhamList()
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
            private string _maNhom;
            public string maNhom
            {
                get
                {
                    return _maNhom;
                }
            }
            public Criteria(string mmaNhom)
            {
                _maNhom = mmaNhom;
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
                    _DK = "MATP like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenTP)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMThanhPham(criteria.qadmin, criteria.maNhom )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMThanhPham item = new DMThanhPham(
     i,
     dr.GetString("MaTP"), 
     dr.GetString ("TenTP"),
     dr.GetString("MaNhom"), 
		 dr.GetString("MaMay"),
		 dr.GetBoolean ("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"),
     dr.GetString("hoten"),
     dr.GetString("tennhom")
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMThanhPham(criteria.DK, false)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMThanhPham item = new DMThanhPham(
     i,
     dr.GetString("MaNhom"),
     dr.GetString("TenNhom"),
     dr.GetString("MaNhom"), 
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"),
     dr.GetString("hoten"),
     dr.GetString("tennhom")
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
