using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMDuongDungList : BusinessListBase<DMDuongDungList, DMDuongDung>
    {
        #region Factory Methods
        public static DMDuongDungList GetAllDMDuongDung(Byte loai, Boolean qadmin)
        {
            return DataPortal.Fetch<DMDuongDungList>(new Criteria(loai, qadmin));
        }

        public static DMDuongDungList FindDMDuongDungByMa(string MaKQTaiBien)
        {
            return DataPortal.Fetch<DMDuongDungList>(new CriteriaOther(1, MaKQTaiBien));
        }
        public static DMDuongDungList FindDMDuongDungByTen(string TenKQTaiBien)
        {
            return DataPortal.Fetch<DMDuongDungList>(new CriteriaOther(2, TenKQTaiBien));
        }
        public static DMDuongDungList FindDMDuongDungByTenD(string TenDuongDung)
        {
            return DataPortal.Fetch<DMDuongDungList>(new CriteriaOther(3, TenDuongDung));
        }

        public void NewTo(DMDuongDung _DMDuongDung)
        {
            if (this.Count == 0)
                _DMDuongDung.OrderNumber = 1;
            else
                _DMDuongDung.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMDuongDung);
        }
        public void UpdateTo(DMDuongDung _DMDuongDung)
        {
            _DMDuongDung.OrderNumber = this.Items[this.IndexOf(_DMDuongDung)].OrderNumber;
            this.Items[this.IndexOf(_DMDuongDung)] = _DMDuongDung;
        }
        public void RemoveTo(DMDuongDung DMDuongDung)
        {
            this.Items.Remove(DMDuongDung);
        }
        private DMDuongDungList()
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
                    _DK = "MaDuongDung like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenDuongDung)) like N'" + mDK + "%'";
                else if (mIdFind == 3)
                    _DK = "ltrim(rtrim(TenDuongDung)) = N'" + mDK + "'";

            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDuongDung(criteria.Loai, criteria.qadmin)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMDuongDung item = new DMDuongDung(
     i,
     dr.GetString("MaDuongDung"),
     dr.GetString("TenDuongDung"),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDuongDung(criteria.DK, false)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMDuongDung item = new DMDuongDung(
     i,
     dr.GetString("MaDuongDung"),
     dr.GetString("TenDuongDung"),
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
