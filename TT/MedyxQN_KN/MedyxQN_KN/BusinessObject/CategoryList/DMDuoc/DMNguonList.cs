using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMNguonList : BusinessListBase<DMNguonList, DMNguon>
    {
        #region Factory Methods
        public static DMNguonList GetAllDMNguon(Byte loai)
        {
            return DataPortal.Fetch<DMNguonList>(new Criteria(loai));
        }
        public void NewTo(DMNguon _DMNguon)
        {
            if (this.Count == 0)
                _DMNguon.OrderNumber = 1;
            else
                _DMNguon.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMNguon);
        }

        public void UpdatedTo(DMNguon _DMNguon)
        {

            _DMNguon.OrderNumber = this.Items[this.IndexOf(_DMNguon)].OrderNumber;
            this.Items[this.IndexOf(_DMNguon)] = _DMNguon;
        }
        public void RemoveTo(DMNguon _DMNguon)
        {
            this.Items.Remove(_DMNguon);

        }
        private DMNguonList()
        {  /* Require use of factory methods */ }

        #endregion

     
        #region Data Access

        [Serializable()]
        private class Criteria
        {
            private Byte _Loai;
             private Boolean _qadmin = false ;
            public Byte Loai
            {
                get
                {
                    return _Loai;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public Criteria(Byte mLoai)
            {
                _Loai = mLoai;

            }
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
                    _DK = "MaNguon like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenNguon)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMNguon(criteria.Loai, criteria.qadmin)))
            {
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMNguon item = new DMNguon(
     i,
      
     dr.GetString("MaNguon"),
     dr.GetString("TenNguon"),
     dr.GetString("Ghichu"),
     dr.GetString("MaMay"),
     dr.GetByte("Loai"),
     dr.GetBoolean("Huy"),
     dr.GetBoolean("KhongSD"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),
     dr.GetString("Tenta"),
     dr.GetString("hoten") 

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
            int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMNguon(  criteria.DK,criteria.qadmin)))
            {
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMNguon item = new DMNguon(
          i,
     dr.GetString("MaNguon"),
     dr.GetString("TenNguon"),
     dr.GetString("Ghichu"),
     dr.GetString("MaMay"),
     dr.GetByte("Loai"),
     dr.GetBoolean("Huy"),
     dr.GetBoolean("KhongSD"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),
     dr.GetString("Tenta"),
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
