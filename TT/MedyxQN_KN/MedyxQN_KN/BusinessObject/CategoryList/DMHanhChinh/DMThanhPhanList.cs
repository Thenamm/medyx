using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMThanhPhanList : BusinessListBase<DMThanhPhanList, DMThanhPhan>
    {
        #region Factory Methods
        public static DMThanhPhanList GetAllDMThanhPhan()
        {
            return DataPortal.Fetch<DMThanhPhanList>(new Criteria());
        }
        public void NewTo(DMThanhPhan _DMThanhPhan)
        {
            if (this.Count == 0)
                _DMThanhPhan.OrderNumber = 1;
            else
                _DMThanhPhan.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMThanhPhan);
        }
        public void UpdatedTo(DMThanhPhan _DMThanhPhan)
        {

            _DMThanhPhan.OrderNumber = this.Items[this.IndexOf(_DMThanhPhan)].OrderNumber;
            this.Items[this.IndexOf(_DMThanhPhan)] = _DMThanhPhan;
        }
        public void RemoveTo(DMThanhPhan _DMThanhPhan)
        {
            this.Items.Remove(_DMThanhPhan);

        }

        private DMThanhPhanList()
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
                    _DK = "MaThanhPhan like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenThanhPhan)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMThanhPhan(HTC.ShareVariables.pub_bQadmin   )))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMThanhPhan item = new DMThanhPhan(
     i,
     dr.GetString("MaThanhPhan"),
     dr.GetString("TenThanhPhan"),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMThanhPhan(criteria.DK, false)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMThanhPhan item = new DMThanhPhan(
     i,
     dr.GetString("MaThanhPhan"),
     dr.GetString("TenThanhPhan"),
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
