using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMNgachBacList : BusinessListBase<DMNgachBacList, DMNgachBac>
    {
        #region Factory Methods
        public static DMNgachBacList GetAllDMNgachBac(string  MaNgach )
        {
            return DataPortal.Fetch<DMNgachBacList>(new Criteria( MaNgach ));
        }
        public void NewTo(DMNgachBac _DMNgachBac)
        {
            if (this.Count == 0)
                _DMNgachBac.OrderNumber = 1;
            else
                _DMNgachBac.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMNgachBac);
        }
        public void UpdatedTo(DMNgachBac _DMNgachBac)
        {

            _DMNgachBac.OrderNumber = this.Items[this.IndexOf(_DMNgachBac)].OrderNumber;
            this.Items[this.IndexOf(_DMNgachBac)] = _DMNgachBac;
        }
        public void RemoveTo(DMNgachBac _DMNgachBac)
        {
            this.Items.Remove(_DMNgachBac);

        }

        private DMNgachBacList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            private string  _MaNgach;
            public string  MaNgach
            {
                get
                {
                    return _MaNgach;
                }
            }
            public Criteria(string mMaNgach)
            {
                _MaNgach = mMaNgach;
            }
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
                    _DK = "MaTDNgoaiNgu like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenTDNgoaiNgu)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMNgachBac(criteria.MaNgach ,  HTC.ShareVariables.pub_bQadmin)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMNgachBac item = new DMNgachBac(
     i,
     dr.GetString("MaNgach"),
     dr.GetInt32("Bac"),
     dr.GetString("TenNgach"),
     dr.GetDecimal ("Heso"),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMNgachBac(criteria.DK, false)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMNgachBac item = new DMNgachBac(
       i,
     dr.GetString("MaNgach"),
     dr.GetInt32  ("Bac"),
     dr.GetString("TenNgach"),
     dr.GetDecimal("Heso"),
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
