using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMNoiXuatList : BusinessListBase<DMNoiXuatList, DMNoiXuat>
    {
        #region Factory Methods
        public static DMNoiXuatList GetAllDMNoiXuat(Byte loai)
        {
            return DataPortal.Fetch<DMNoiXuatList>(new Criteria(loai));
        }
        // tim theo dieu kien ten
        public static DMNoiXuatList FindDMNoiXuatByTen(string TenChungLoai)
        {
            return DataPortal.Fetch<DMNoiXuatList>(new CriteriaOther(2, TenChungLoai));
        }
        public static DMNoiXuatList FindDMNoiXuatByMa(string MaChungLoai)
        {
            return DataPortal.Fetch<DMNoiXuatList>(new CriteriaOther(1, MaChungLoai));
        }
        public void NewTo(DMNoiXuat _DMNoiXuat)
        {
            if (this.Count == 0)
                _DMNoiXuat.OrderNumber =1;
            else 
            _DMNoiXuat.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMNoiXuat);
        } 
        public void UpdatedTo(DMNoiXuat _DMNoiXuat)
        {

            _DMNoiXuat.OrderNumber = this.Items[this.IndexOf(_DMNoiXuat)].OrderNumber;
            this.Items[this.IndexOf(_DMNoiXuat)] = _DMNoiXuat;
        }
        public void RemoveTo(DMNoiXuat _DMNoiXuat)
        {
            this.Items.Remove(_DMNoiXuat);

        }

        private DMNoiXuatList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

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
            public Criteria(Byte mLoai)
            {
                _Loai = mLoai;
                
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
                    _DK = "MaNoiXuat like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenMaNoiXuat)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMNoiXuat(criteria.Loai, criteria.qadmin )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMNoiXuat item = new DMNoiXuat(
     i,
     dr.GetString("MaNoiXuat") ,
			                                dr.GetByte("Loai") ,
     dr.GetString("TenNoiXuat") ,
			                                dr.GetString("Ghichu") ,
			                                dr.GetBoolean("Huy") ,
			                                dr.GetSmartDate("NgaySD", true) ,
			                                dr.GetString("NguoiSD") ,
     dr.GetString("MaMay") 
    // dr.GetString("HOTEN")
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMNoiXuat(criteria.DK, false)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMNoiXuat item = new DMNoiXuat(
     i,
     dr.GetString("MaNoiXuat"),
     dr.GetByte("Loai"),
     dr.GetString("TenNoiXuat"),
     dr.GetString("Ghichu"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", true),
     dr.GetString("NguoiSD"),
     dr.GetString("MaMay")
    // dr.GetString("HOTEN")
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
