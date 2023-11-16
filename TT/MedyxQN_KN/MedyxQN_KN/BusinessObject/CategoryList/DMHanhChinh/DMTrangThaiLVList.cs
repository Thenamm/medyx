using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMTrangThaiLVList : BusinessListBase<DMTrangThaiLVList, DMTrangThaiLV>
    {
        #region Factory Methods
        public static DMTrangThaiLVList GetAllDMTrangThaiLV()
        {
            return DataPortal.Fetch<DMTrangThaiLVList>(new Criteria());
        }
        public void NewTo(DMTrangThaiLV _DMTrangThaiLV)
        {
            if (this.Count == 0)
                _DMTrangThaiLV.OrderNumber = 1;
            else
                _DMTrangThaiLV.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMTrangThaiLV);
        }
        public void UpdatedTo(DMTrangThaiLV _DMTrangThaiLV)
        {

            _DMTrangThaiLV.OrderNumber = this.Items[this.IndexOf(_DMTrangThaiLV)].OrderNumber;
            this.Items[this.IndexOf(_DMTrangThaiLV)] = _DMTrangThaiLV;
        }
        public void RemoveTo(DMTrangThaiLV _DMTrangThaiLV)
        {
            this.Items.Remove(_DMTrangThaiLV);

        }

        private DMTrangThaiLVList()
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
                    _DK = "MaTrangThaiLV like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenTrangThaiLV)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMTrangThaiLV(HTC.ShareVariables.pub_bQadmin   )))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMTrangThaiLV item = new DMTrangThaiLV(
     i,
     dr.GetString("MaTrangThaiLV"),
     dr.GetString("TenTrangThaiLV"),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMTrangThaiLV(criteria.DK, false)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMTrangThaiLV item = new DMTrangThaiLV(
     i,
     dr.GetString("MaTrangThaiLV"),
     dr.GetString("TenTrangThaiLV"),
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
