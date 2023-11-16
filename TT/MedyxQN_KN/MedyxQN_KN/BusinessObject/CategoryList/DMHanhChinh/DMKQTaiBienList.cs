using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMKQTaiBienList : BusinessListBase<DMKQTaiBienList, DMKQTaiBien>
    {
        #region Factory Methods
        public static DMKQTaiBienList GetAllDMKQTaiBien(Byte loai, Boolean qadmin)
        {
            return DataPortal.Fetch<DMKQTaiBienList>(new Criteria(loai, qadmin));
        }

        public static DMKQTaiBienList FindDMKQTaiBienByMa(string MaKQTaiBien)
        {
            return DataPortal.Fetch<DMKQTaiBienList>(new CriteriaOther(1, MaKQTaiBien));
        }
        public static DMKQTaiBienList FindDMKQTaiBienByTen(string TenKQTaiBien)
        {
            return DataPortal.Fetch<DMKQTaiBienList>(new CriteriaOther(2, TenKQTaiBien));
        }

        public void NewTo(DMKQTaiBien _DMKQTaiBien)
        {
            if (this.Count == 0)
                _DMKQTaiBien.OrderNumber = 1;
            else
                _DMKQTaiBien.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMKQTaiBien);
        }
        public void UpdateTo(DMKQTaiBien _DMKQTaiBien)
        {
            _DMKQTaiBien.OrderNumber = this.Items[this.IndexOf(_DMKQTaiBien)].OrderNumber;
            this.Items[this.IndexOf(_DMKQTaiBien)] = _DMKQTaiBien;
        }
        public void RemoveTo(DMKQTaiBien DMKQTaiBien)
        {
            this.Items.Remove(DMKQTaiBien);
        }
        private DMKQTaiBienList()
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
                    _DK = "MaKQTaiBien like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenKQTaiBien)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMKQTaiBien(criteria.Loai, criteria.qadmin)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMKQTaiBien item = new DMKQTaiBien(
     i,
     dr.GetString("MaKQTaiBien"),
     dr.GetString("TenKQTaiBien"),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMKQTaiBien(criteria.DK, false)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMKQTaiBien item = new DMKQTaiBien(
     i,
     dr.GetString("MaKQTaiBien"),
     dr.GetString("TenKQTaiBien"),
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
