using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMTaiBienList : BusinessListBase<DMTaiBienList, DMTaiBien>
    {
        #region Factory Methods
        public static DMTaiBienList GetAllDMTaiBien(Byte loai, Boolean qadmin)
        {
            return DataPortal.Fetch<DMTaiBienList>(new Criteria(loai, qadmin));
        }

        public static DMTaiBienList FindDMTaiBienByMa(string MaDDHoiChan)
        {
            return DataPortal.Fetch<DMTaiBienList>(new CriteriaOther(1, MaDDHoiChan));
        }
        public static DMTaiBienList FindDMTaiBienByTen(string TenDDHoiChan)
        {
            return DataPortal.Fetch<DMTaiBienList>(new CriteriaOther(2, TenDDHoiChan));
        }

        public void NewTo(DMTaiBien _DMTaiBien)
        {
            if (this.Count == 0)
                _DMTaiBien.OrderNumber = 1;
            else
                _DMTaiBien.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMTaiBien);
        }
        public void UpdateTo(DMTaiBien _DMTaiBien)
        {
            _DMTaiBien.OrderNumber = this.Items[this.IndexOf(_DMTaiBien)].OrderNumber;
            this.Items[this.IndexOf(_DMTaiBien)] = _DMTaiBien;
        }
        public void RemoveTo(DMTaiBien DMTaiBien)
        {
            this.Items.Remove(DMTaiBien);
        }
        private DMTaiBienList()
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
                    _DK = "MaTaiBien like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenTaiBien)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMTaiBien(criteria.Loai, criteria.qadmin)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMTaiBien item = new DMTaiBien(
     i,
     dr.GetString("MaTaiBien"),
     dr.GetString("TenTaiBien"),
     dr.GetString("TenTA"),
     dr.GetString("GhiChu"),
     dr.GetString("MaMay"),
     dr.GetByte("Loai"),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMTaiBien(criteria.DK, false)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMTaiBien item = new DMTaiBien(
     i,
     dr.GetString("MaTaiBien"),
     dr.GetString("TenTaiBien"),
     dr.GetString("TenTA"),
     dr.GetString("GhiChu"),
     dr.GetString("MaMay"),
     dr.GetByte("Loai"),
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
