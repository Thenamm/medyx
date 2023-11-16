using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMLoaiHopDongList : BusinessListBase<DMLoaiHopDongList, DMLoaiHopDong>
    {
        #region Factory Methods
        public static DMLoaiHopDongList GetAllDMLoaiHopDong()
        {
            return DataPortal.Fetch<DMLoaiHopDongList>(new Criteria());
        }
        public void NewTo(DMLoaiHopDong _DMLoaiHopDong)
        {
            if (this.Count == 0)
                _DMLoaiHopDong.OrderNumber = 1;
            else
                _DMLoaiHopDong.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMLoaiHopDong);
        }
        public void UpdatedTo(DMLoaiHopDong _DMLoaiHopDong)
        {

            _DMLoaiHopDong.OrderNumber = this.Items[this.IndexOf(_DMLoaiHopDong)].OrderNumber;
            this.Items[this.IndexOf(_DMLoaiHopDong)] = _DMLoaiHopDong;
        }
        public void RemoveTo(DMLoaiHopDong _DMLoaiHopDong)
        {
            this.Items.Remove(_DMLoaiHopDong);

        }

        private DMLoaiHopDongList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            //private int _id;
            //public int Id
            //{
            //    get
            //    {
            //        return _id;
            //    }
            //}
            //public Criteria(int mId)
            //{
            //    _id = mId;
            //}
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
                    _DK = "maLoaiHD like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenLoaiHD)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMLoaiHopDong(HTC.ShareVariables.pub_bQadmin   )))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMLoaiHopDong item = new DMLoaiHopDong(
     i,
     dr.GetString("maLoaiHD"),
     dr.GetString("TenLoaiHD"),
		 dr.GetString ("MaMay"),
		 dr.GetBoolean ("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD") ,
     dr.GetString("GhiChu") ,
     dr.GetString("HoTen") 
    
         );
                    this.Add(item);
                    i += 1;

                }
            }
          

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMLoaiHopDong(criteria.DK, false)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMLoaiHopDong item = new DMLoaiHopDong(
     i,
     dr.GetString("maLoaiHD"),
     dr.GetString("TenLoaiHD"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),
     dr.GetString("GhiChu"),
     dr.GetString("HoTen") 

         );
                    this.Add(item);
                    i += 1;

                }
            }
           
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
    }
}
