using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMMienGiamList : BusinessListBase<DMMienGiamList, DMMienGiam>
    {
        #region Factory Methods
        public static DMMienGiamList GetAllDMMienGiam()
        {
            return DataPortal.Fetch<DMMienGiamList>(new Criteria());
        }
        // tim theo dieu kien ten
        public static DMMienGiamList FindDMMienGiamByTen(string TenMienGiam)
        {
            return DataPortal.Fetch<DMMienGiamList>(new CriteriaOther(2, TenMienGiam));
        }
        public static DMMienGiamList FindDMDichVuByMa(string MaMienGiam)
        {
            return DataPortal.Fetch<DMMienGiamList>(new CriteriaOther(1, MaMienGiam));
        }
        public void NewTo(DMMienGiam _DMMienGiam)
        {
            if (this.Count == 0)
                _DMMienGiam.OrderNumber = 1;
            else
            _DMMienGiam.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMMienGiam);
        }
        public void UpdatedTo(DMMienGiam _DMMienGiam)
        {

            _DMMienGiam.OrderNumber = this.Items[this.IndexOf(_DMMienGiam)].OrderNumber;
            this.Items[this.IndexOf(_DMMienGiam)] = _DMMienGiam;
        }
        public void RemoveTo(DMMienGiam _DMMienGiam)
        {
            this.Items.Remove(_DMMienGiam);

        }

        private DMMienGiamList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            
            private Boolean _qadmin = false ;
           
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
           
        }

        // tim kiem theo ten
        #region CriteriaOther
        [Serializable()]
        private class CriteriaOther
        {
            //private int _id;
            //public int Id
            //{
            //    get
            //    {
            //        return _id;
            //    }
            //}
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
                    _DK = "MaMienGiam like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenMienGiam)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMMienGiam( criteria.qadmin )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMMienGiam item = new DMMienGiam(
     i,
    dr.GetString("MaMienGiam"),
			                               dr.GetString("TenMienGiam"),
			                               dr.GetString("MaMay") ,
			                               dr.GetBoolean("Huy") ,
			                               dr.GetSmartDate("NgaySD", true) ,
			                               dr.GetString("NguoiSD") ,
			                               dr.GetString("GhiChu") ,
     dr.GetString("hoten")
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMMienGiam(criteria.DK, false)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMMienGiam item = new DMMienGiam(
     i,
     dr.GetString("MaMienGiam"),
			                               dr.GetString("TenMienGiam"),
			                               dr.GetString("MaMay") ,
			                               dr.GetBoolean("Huy") ,
			                               dr.GetSmartDate("NgaySD", true) ,
			                               dr.GetString("NguoiSD") ,
			                               dr.GetString("GhiChu") ,
     dr.GetString("hoten")
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
