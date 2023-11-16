using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMVaiTroList : BusinessListBase<DMVaiTroList, DMVaiTro>
    {
        #region Factory Methods
        public static DMVaiTroList GetAllDMVaiTro(Byte loai)
        {
            return DataPortal.Fetch<DMVaiTroList>(new Criteria(loai));
        }
        public void NewTo(DMVaiTro _DMVaiTro)
        {
            if (this.Count == 0)
                _DMVaiTro.OrderNumber = 1;
            else
                _DMVaiTro.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMVaiTro);
        }
        public void UpdatedTo(DMVaiTro _DMVaiTro)
        {

            _DMVaiTro.OrderNumber = this.Items[this.IndexOf(_DMVaiTro)].OrderNumber;
            this.Items[this.IndexOf(_DMVaiTro)] = _DMVaiTro;
        }
        public void RemoveTo(DMVaiTro _DMVaiTro)
        {
            this.Items.Remove(_DMVaiTro);

        }
        private DMVaiTroList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMVaiTro(criteria.Loai, criteria.qadmin)))
            {
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMVaiTro item = new DMVaiTro(
     i,

     dr.GetByte("MaVaiTro"),
     dr.GetString("TenVaiTro"),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMVaiTro(criteria.DK, false)))
            {
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMVaiTro item = new DMVaiTro(
          i,
     dr.GetByte("MaVaiTro"),
     dr.GetString("TenVaiTro"),
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
