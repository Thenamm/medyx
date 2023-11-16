using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMTaiKhoanList : ReadOnlyListBase<DMTaiKhoanList, DMTaiKhoan>
    {
        #region Factory Methods
        public static DMTaiKhoanList GetAllDMTaiKhoan()
        {
            return DataPortal.Fetch<DMTaiKhoanList>(new Criteria());
        }
        
        public void NewTo(DMTaiKhoan _DMTaiKhoan)
        {
            if (this.Count == 0)
                _DMTaiKhoan.OrderNumber = 1;
            else
                _DMTaiKhoan.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMTaiKhoan);
        }
        public void UpdateTo(DMTaiKhoan _DMTaiKhoan)
        {
            _DMTaiKhoan.OrderNumber = this.Items[this.IndexOf(_DMTaiKhoan)].OrderNumber;
            this.Items[this.IndexOf(_DMTaiKhoan)] = _DMTaiKhoan;
        }
        public void RemoveTo(DMTaiKhoan _DMTaiKhoan)
        {
            this.Items.Remove(_DMTaiKhoan);
        }
        public DMTaiKhoan GetTo(decimal STT)
        {
            foreach (DMTaiKhoan obj in this)
                if (obj.OrderNumber == STT)
                    return obj;
            return null;

        }
        private DMTaiKhoanList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            
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
                    _DK = "MaTK like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenTK)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMTaiKhoan(HTC.ShareVariables.pub_bQadmin  )))
            {
                int i = 1;

                IsReadOnly = false;
                while (dr.Read())
                {
                    DMTaiKhoan item = new DMTaiKhoan(
     i,
     dr.GetString("Ma"),
     dr.GetString("MaTK"), 
     dr.GetString ("TenTK"),
		 dr.GetString("MaMay"),
		 dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD") ,
     dr.GetString("ghichu") ,
     dr.GetString("hoten") 
         );
                    this.Add(item);
                    i += 1;

                }
                IsReadOnly = true;
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMTaiKhoan(criteria.DK, false)))
            {
                int i = 1;

                IsReadOnly = false;
                while (dr.Read())
                {
                    DMTaiKhoan item = new DMTaiKhoan(
     i,
     dr.GetString("Ma"),
     dr.GetString("MaTK"), 
     dr.GetString("TenTK"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"),
     dr.GetString("ghichu"),
     dr.GetString("hoten")
         );
                    this.Add(item);
                    i += 1;

                }
                IsReadOnly = true;
            }
            
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
    }
}
