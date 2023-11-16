using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMQHGiaDinhList : BusinessListBase<DMQHGiaDinhList, DMQHGiaDinh>
    {
        #region Factory Methods
        public static DMQHGiaDinhList GetAllDMQHGiaDinh()
        {
            return DataPortal.Fetch<DMQHGiaDinhList>(new Criteria());
        }
        public void NewTo(DMQHGiaDinh _DMQHGiaDinh)
        {
            if (this.Count == 0)
                _DMQHGiaDinh.OrderNumber = 1;
            else
                _DMQHGiaDinh.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMQHGiaDinh);
        }
        public void UpdatedTo(DMQHGiaDinh _DMQHGiaDinh)
        {

            _DMQHGiaDinh.OrderNumber = this.Items[this.IndexOf(_DMQHGiaDinh)].OrderNumber;
            this.Items[this.IndexOf(_DMQHGiaDinh)] = _DMQHGiaDinh;
        }
        public void RemoveTo(DMQHGiaDinh _DMQHGiaDinh)
        {
            this.Items.Remove(_DMQHGiaDinh);

        }

        private DMQHGiaDinhList()
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
                    _DK = "MaQHGiaDinh like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenQHGiaDinh)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMQHGiaDinh(HTC.ShareVariables.pub_bQadmin   )))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMQHGiaDinh item = new DMQHGiaDinh(
     i,
     dr.GetString("MaQHGiaDinh"),
     dr.GetString("TenQHGiaDinh"),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMQHGiaDinh(criteria.DK, false)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMQHGiaDinh item = new DMQHGiaDinh(
     i,
     dr.GetString("MaQHGiaDinh"),
     dr.GetString("TenQHGiaDinh"),
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
