using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMHinhThucList : BusinessListBase<DMHinhThucList, DMHinhThuc>
    {
        #region Factory Methods
        public static DMHinhThucList GetAllDMHinhThuc(Byte loai)
        {
            return DataPortal.Fetch<DMHinhThucList>(new Criteria(loai));
        }
        public void NewTo(DMHinhThuc _DMHinhThuc)
        {
            if (this.Count == 0)
                _DMHinhThuc.OrderNumber = 1;
            else
                _DMHinhThuc.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMHinhThuc);
        }
        public void UpdatedTo(DMHinhThuc _DMHinhThuc)
        {

            _DMHinhThuc.OrderNumber = this.Items[this.IndexOf(_DMHinhThuc)].OrderNumber;
            this.Items[this.IndexOf(_DMHinhThuc)] = _DMHinhThuc;
        }
        public void RemoveTo(DMHinhThuc _DMHinhThuc)
        {
            this.Items.Remove(_DMHinhThuc);

        }
        private DMHinhThucList()
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
                    _DK = "MaKho like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenKho)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMHinhThuc(criteria.Loai, criteria.qadmin)))
            {
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMHinhThuc item = new DMHinhThuc(
     i,

     dr.GetString("MaHinhThuc"),
     dr.GetString("TenHinhThuc"),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMHinhThuc(criteria.DK, false)))
            {
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMHinhThuc item = new DMHinhThuc(
          i,
     dr.GetString("MaHinhThuc"),
     dr.GetString("TenHinhThuc"),
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
