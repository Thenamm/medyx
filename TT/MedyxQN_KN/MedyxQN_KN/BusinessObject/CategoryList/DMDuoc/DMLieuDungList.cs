using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMLieuDungList : BusinessListBase<DMLieuDungList, DMLieuDung>
    {
        #region Factory Methods
        public static DMLieuDungList GetAllDMLieuDung(Byte loai, Boolean qadmin)
        {
            return DataPortal.Fetch<DMLieuDungList>(new Criteria(loai, qadmin));
        }

        public static DMLieuDungList FindDMLieuDungByMa(string MaKQTaiBien)
        {
            return DataPortal.Fetch<DMLieuDungList>(new CriteriaOther(1, MaKQTaiBien));
        }
        public static DMLieuDungList FindDMLieuDungByTen(string TenKQTaiBien)
        {
            return DataPortal.Fetch<DMLieuDungList>(new CriteriaOther(2, TenKQTaiBien));
        }
        public static DMLieuDungList FindDMLieuDungByTenD(string TenLieuDung)
        {
            return DataPortal.Fetch<DMLieuDungList>(new CriteriaOther(3, TenLieuDung));
        }

        public void NewTo(DMLieuDung _DMLieuDung)
        {
            if (this.Count == 0)
                _DMLieuDung.OrderNumber = 1;
            else
                _DMLieuDung.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMLieuDung);
        }
        public void UpdateTo(DMLieuDung _DMLieuDung)
        {
            _DMLieuDung.OrderNumber = this.Items[this.IndexOf(_DMLieuDung)].OrderNumber;
            this.Items[this.IndexOf(_DMLieuDung)] = _DMLieuDung;
        }
        public void RemoveTo(DMLieuDung DMLieuDung)
        {
            this.Items.Remove(DMLieuDung);
        }
        private DMLieuDungList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access
        #region Criteria
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
            public Criteria(Byte mLoai, Boolean mqadmin)
            {
                _Loai = mLoai;
                _qadmin = mqadmin;
            }
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
                    _DK = "MaLieuDung like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenLieuDung)) like N'" + mDK + "%'";
                else if (mIdFind == 3)
                    _DK = "ltrim(rtrim(TenLieuDung)) = N'" + mDK + "'";

            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMLieuDung(criteria.Loai, criteria.qadmin)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMLieuDung item = new DMLieuDung(
     i,
     dr.GetString("MaLieuDung"),
     dr.GetString("TenLieuDung"),
     dr.GetString("TenTA"),
     dr.GetString("GhiChu"),
     dr.GetString("MaMay"),
     dr.GetByte("Loai"),
     dr.GetBoolean("KhongSD"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", true),
     dr.GetString("NguoiSD"),
     dr.GetString("Hoten")
    
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMLieuDung(criteria.DK, false)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMLieuDung item = new DMLieuDung(
     i,
     dr.GetString("MaLieuDung"),
     dr.GetString("TenLieuDung"),
     dr.GetString("TenTA"),
     dr.GetString("GhiChu"),
     dr.GetString("MaMay"),
     dr.GetByte("Loai"),
     dr.GetBoolean("KhongSD"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", true),
     dr.GetString("NguoiSD"),
     dr.GetString("Hoten")

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
