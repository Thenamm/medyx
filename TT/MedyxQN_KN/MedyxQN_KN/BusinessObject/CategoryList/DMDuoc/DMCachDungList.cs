using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMCachDungList : BusinessListBase<DMCachDungList, DMCachDung>
    {
        #region Factory Methods
        public static DMCachDungList GetAllDMCachDung(Byte loai, Boolean qadmin)
        {
            return DataPortal.Fetch<DMCachDungList>(new Criteria(loai, qadmin));
        }

        public static DMCachDungList FindDMCachDungByMa(string MaKQTaiBien)
        {
            return DataPortal.Fetch<DMCachDungList>(new CriteriaOther(1, MaKQTaiBien));
        }
        public static DMCachDungList FindDMCachDungByTen(string TenKQTaiBien)
        {
            return DataPortal.Fetch<DMCachDungList>(new CriteriaOther(2, TenKQTaiBien));
        }
        public static DMCachDungList FindDMCachDungByTenD(string TenCachDung)
        {
            return DataPortal.Fetch<DMCachDungList>(new CriteriaOther(3, TenCachDung));
        }

        public void NewTo(DMCachDung _DMCachDung)
        {
            if (this.Count == 0)
                _DMCachDung.OrderNumber = 1;
            else
                _DMCachDung.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMCachDung);
        }
        public void UpdateTo(DMCachDung _DMCachDung)
        {
            _DMCachDung.OrderNumber = this.Items[this.IndexOf(_DMCachDung)].OrderNumber;
            this.Items[this.IndexOf(_DMCachDung)] = _DMCachDung;
        }
        public void RemoveTo(DMCachDung DMCachDung)
        {
            this.Items.Remove(DMCachDung);
        }
        private DMCachDungList()
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
                    _DK = "MaCachDung like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenCachDung)) like N'" + mDK + "%'";
                else if (mIdFind == 3)
                    _DK = "ltrim(rtrim(TenCachDung)) = N'" + mDK + "'";

            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMCachDung(criteria.Loai, criteria.qadmin)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMCachDung item = new DMCachDung(
     i,
     dr.GetString("MaCachDung"),
     dr.GetString("TenCachDung"),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMCachDung(criteria.DK, false)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMCachDung item = new DMCachDung(
     i,
     dr.GetString("MaCachDung"),
     dr.GetString("TenCachDung"),
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
