using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMDanhGiaList : BusinessListBase<DMDanhGiaList, DMDanhGia>
    {
        #region Factory Methods
        public static DMDanhGiaList GetAllDMDanhGia(Byte loai)
        {
            return DataPortal.Fetch<DMDanhGiaList>(new Criteria(loai));
        }
        // tim theo dieu kien ten
        public static DMDanhGiaList FindDMDanhGiaByTen(string TenDG)
        {
            return DataPortal.Fetch<DMDanhGiaList>(new CriteriaOther(2, TenDG));
        }
        public static DMDanhGiaList FindDMDichVuByMa(string MaDG)
        {
            return DataPortal.Fetch<DMDanhGiaList>(new CriteriaOther(1, MaDG));
        }
        public void NewTo(DMDanhGia _DMDanhGia)
        {
            if (this.Count == 0)
                _DMDanhGia.OrderNumber = 1;
            else
            _DMDanhGia.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMDanhGia);
        }
        public void UpdatedTo(DMDanhGia _DMDanhGia)
        {

            _DMDanhGia.OrderNumber = this.Items[this.IndexOf(_DMDanhGia)].OrderNumber;
            this.Items[this.IndexOf(_DMDanhGia)] = _DMDanhGia;
        }
        public void RemoveTo(DMDanhGia _DMDanhGia)
        {
            this.Items.Remove(_DMDanhGia);

        }

        private DMDanhGiaList()
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
                    _DK = "MaDG like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenDG)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDanhGia(criteria.Loai, criteria.qadmin )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMDanhGia item = new DMDanhGia(
     i,
     dr.GetString("MaDG"), 
     dr.GetString("TenDG"),
     dr.GetByte("Loai"), 
		 dr.GetString("MaMay"),
		 dr.GetBoolean ("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"),
     dr.GetString("hoten"),
   
      dr.GetString("ghichu")
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDanhGia(criteria.DK, false)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMDanhGia item = new DMDanhGia(
     i,
     dr.GetString("MaDG"),
     dr.GetString("TenDG"),
     dr.GetByte("Loai"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"),
     dr.GetString("hoten"),
   
      dr.GetString("ghichu")
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
