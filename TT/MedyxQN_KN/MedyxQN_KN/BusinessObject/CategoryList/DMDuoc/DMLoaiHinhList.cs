using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMLoaiHinhList : BusinessListBase<DMLoaiHinhList, DMLoaiHinh>
    {
        #region Factory Methods
        public static DMLoaiHinhList GetAllDMLoaiHinh(string _machungloai )
        {
            return DataPortal.Fetch<DMLoaiHinhList>(new Criteria(_machungloai));
        }

        public void NewTo(DMLoaiHinh _DMLoaiHinh)
        {
            if (this.Count == 0)
                _DMLoaiHinh.OrderNumber = 1;
            else
            _DMLoaiHinh.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMLoaiHinh);
        }
        public void UpdatedTo(DMLoaiHinh _DMLoaiHinh)
        {

            _DMLoaiHinh.OrderNumber = this.Items[this.IndexOf(_DMLoaiHinh)].OrderNumber;
            this.Items[this.IndexOf(_DMLoaiHinh)] = _DMLoaiHinh;
        }
        public void RemoveTo(DMLoaiHinh _DMLoaiHinh)
        {
            this.Items.Remove(_DMLoaiHinh);

        }

        private DMLoaiHinhList()
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
            private string _machungloai;
            public string machungloai
            {
                get
                {
                    return _machungloai;
                }
            }
            public Criteria(string mmachungloai)
            {
                _machungloai = mmachungloai;
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
                    _DK = "MALH like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenLH)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMLoaiHinh(criteria.qadmin, criteria.machungloai )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMLoaiHinh item = new DMLoaiHinh(
     i,
     dr.GetString("MaLH"), 
     dr.GetString ("TenLH"),
     dr.GetString("MaChungLoai"), 
		 dr.GetString("MaMay"),
		 dr.GetBoolean ("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"),
     dr.GetString("hoten"),
     dr.GetString("tenchungloai")
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMLoaiHinh(criteria.DK, false)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMLoaiHinh item = new DMLoaiHinh(
     i,
     dr.GetString("MaLH"),
     dr.GetString("TenLH"),
     dr.GetString("MaChungLoai"), 
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"),
     dr.GetString("hoten"),
     dr.GetString("tenchungloai")
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
