using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMChungLoaiList : BusinessListBase<DMChungLoaiList, DMChungLoai>
    {
        #region Factory Methods
        public static DMChungLoaiList GetAllDMChungLoai(Byte loai)
        {
            return DataPortal.Fetch<DMChungLoaiList>(new Criteria(loai));
        }
        // tim theo dieu kien ten
        public static DMChungLoaiList FindDMChungLoaiByTen(string TenChungLoai)
        {
            return DataPortal.Fetch<DMChungLoaiList>(new CriteriaOther(2, TenChungLoai));
        }
        public static DMChungLoaiList FindDMDichVuByMa(string MaChungLoai)
        {
            return DataPortal.Fetch<DMChungLoaiList>(new CriteriaOther(1, MaChungLoai));
        }
        public void NewTo(DMChungLoai _DMChungLoai)
        {
            if (this.Count == 0)
                _DMChungLoai.OrderNumber = 1;
            else
            _DMChungLoai.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMChungLoai);
        }
        public void UpdatedTo(DMChungLoai _DMChungLoai)
        {

            _DMChungLoai.OrderNumber = this.Items[this.IndexOf(_DMChungLoai)].OrderNumber;
            this.Items[this.IndexOf(_DMChungLoai)] = _DMChungLoai;
        }
        public void RemoveTo(DMChungLoai _DMChungLoai)
        {
            this.Items.Remove(_DMChungLoai);

        }

        private DMChungLoaiList()
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
                    _DK = "MAChungLoai like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenChungLoai)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMChungLoai(criteria.Loai, criteria.qadmin )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMChungLoai item = new DMChungLoai(
     i,
     dr.GetString("MaChungLoai"), 
     dr.GetString("TenChungLoai"),
     dr.GetByte("Loai"), 
		 dr.GetString("MaMay"),
		 dr.GetBoolean ("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMChungLoai(criteria.DK, false)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMChungLoai item = new DMChungLoai(
     i,
     dr.GetString("MaChungLoai"),
     dr.GetString("TenChungLoai"),
     dr.GetByte("Loai"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"),
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
