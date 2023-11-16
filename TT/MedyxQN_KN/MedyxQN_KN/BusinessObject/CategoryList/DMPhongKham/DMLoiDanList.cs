using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMLoiDanList : BusinessListBase<DMLoiDanList, DMLoiDan>
    {
        #region Factory Methods
        public static DMLoiDanList GetAllDMLoiDan(Byte loai, Boolean qadmin)
        {
            return DataPortal.Fetch<DMLoiDanList>(new Criteria(loai, qadmin));
        }

        public static DMLoiDanList FindDMLoiDanByMa(string MaKQTaiBien)
        {
            return DataPortal.Fetch<DMLoiDanList>(new CriteriaOther(1, MaKQTaiBien));
        }
        public static DMLoiDanList FindDMLoiDanByTen(string TenKQTaiBien)
        {
            return DataPortal.Fetch<DMLoiDanList>(new CriteriaOther(2, TenKQTaiBien));
        }
        public static DMLoiDanList FindDMLoiDanByTenD(string TenLoiDan)
        {
            return DataPortal.Fetch<DMLoiDanList>(new CriteriaOther(3, TenLoiDan));
        }

        public void NewTo(DMLoiDan _DMLoiDan)
        {
            if (this.Count == 0)
                _DMLoiDan.OrderNumber = 1;
            else
                _DMLoiDan.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMLoiDan);
        }
        public void UpdateTo(DMLoiDan _DMLoiDan)
        {
            _DMLoiDan.OrderNumber = this.Items[this.IndexOf(_DMLoiDan)].OrderNumber;
            this.Items[this.IndexOf(_DMLoiDan)] = _DMLoiDan;
        }
        public void RemoveTo(DMLoiDan DMLoiDan)
        {
            this.Items.Remove(DMLoiDan);
        }
        private DMLoiDanList()
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
                    _DK = "MaLoiDan like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenLoiDan)) like N'" + mDK + "%'";
                else if (mIdFind == 3)
                    _DK = "ltrim(rtrim(TenLoiDan)) = N'" + mDK + "'";

            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMLoiDan(criteria.Loai, criteria.qadmin)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMLoiDan item = new DMLoiDan(
     i,
     dr.GetString("MaLoiDan"),
     dr.GetString("TenLoiDan"),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMLoiDan(criteria.DK, false)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMLoiDan item = new DMLoiDan(
     i,
     dr.GetString("MaLoiDan"),
     dr.GetString("TenLoiDan"),
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
