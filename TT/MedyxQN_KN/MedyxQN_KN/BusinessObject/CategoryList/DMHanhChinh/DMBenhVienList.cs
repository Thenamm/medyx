using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMBenhVienList : ReadOnlyListBase<DMBenhVienList, DMBenhVien>
    {
        #region Factory Methods
        public static DMBenhVienList GetAllDMBenhVien()
        {
            return DataPortal.Fetch<DMBenhVienList>(new Criteria());
        }
        public static DMBenhVienList FindDMBenhVienByMa(string MaBV)
        {
            return DataPortal.Fetch<DMBenhVienList>(new CriteriaOther(1, MaBV));
        }
        public static DMBenhVienList FindDMBenhVienByMaD(string MaBV)
        {
            return DataPortal.Fetch<DMBenhVienList>(new CriteriaOther(6, MaBV));
        }
        public static DMBenhVienList FindDMBenhVienByTen(string TenBV)
        {
            return DataPortal.Fetch<DMBenhVienList>(new CriteriaOther(2, TenBV));
        }
        public static DMBenhVienList FindDMBenhVienByMaCT(string MaBV)
        {
            return DataPortal.Fetch<DMBenhVienList>(new CriteriaOther(4, MaBV));
        }
       
        public static DMBenhVienList FindDMBenhVienByTenD(string TenBV)
        {
            return DataPortal.Fetch<DMBenhVienList>(new CriteriaOther(4, TenBV));
        }
        public static DMBenhVienList GetsDMBenhVienByTinh(string MaTinh)
        {
            return DataPortal.Fetch<DMBenhVienList>(new CriteriaOther(3, MaTinh));
        }
        public void NewTo(DMBenhVien _DMBenhVien)
        {
            if (this.Count == 0)
                _DMBenhVien.OrderNumber = 1;
            else
                _DMBenhVien.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMBenhVien);
        }
        public void UpdatedTo(DMBenhVien _DMBenhVien)
        {

            _DMBenhVien.OrderNumber = this.Items[this.IndexOf(_DMBenhVien)].OrderNumber;
            this.Items[this.IndexOf(_DMBenhVien)] = _DMBenhVien;
        }
        public void RemoveTo(DMBenhVien _DMBenhVien)
        {
            this.Items.Remove(_DMBenhVien);

        }

        private DMBenhVienList()
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

        //        {
        //            return _maTinh;
        //        }
        //    }
        //    public Criteria(string mmaTinh)
        //    {
        //        _maTinh = mmaTinh;
        //    }









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
                _DK = " isnull(a.huy,0) = 0";
                if (mIdFind == 1)
                    _DK = _DK + " and (MaBHXH LIKE N'" + mDK + "%')";
                if (mIdFind == 6)
                    _DK = _DK + " and (MaBHXH = N'" + mDK + "')";
                else if (mIdFind == 5)
                    _DK = _DK + " and ( mabv like N'" + mDK + "%' or MaBHXH LIKE N'" + mDK + "%')";
                else if (mIdFind == 2)
                    _DK = _DK + " and (ltrim(rtrim(TenBV)) like N'" + mDK + "%')";
                else if (mIdFind == 3)
                    _DK = _DK + " and ( a.Matinh like '%" + mDK + "')";
                else if (mIdFind == 4)
                    _DK = _DK + " and (ltrim(rtrim(TenBV)) like N'" + mDK + "')";
            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;

            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMBenhVien()))

            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMBenhVien item = new DMBenhVien(
     i,
     dr.GetString("MaBV"),
     dr.GetString("TenBV"),
     dr.GetString("MaBHXH"),
     dr.GetString("MaTinh"),
     dr.GetString("Diachi"),
     dr.GetString("Tel"),
		 dr.GetString ("MaMay"),
		 dr.GetBoolean ("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD") ,
     dr.GetString("TenTA"),
     dr.GetString("TenTinh")
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMBenhVien(criteria.DK)))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMBenhVien item = new DMBenhVien(
     i,
     dr.GetString("MaBV"),
     dr.GetString("TenBV"),
     dr.GetString("MaBHXH"),
     dr.GetString("MaTinh"),
     dr.GetString("Diachi"),
     dr.GetString("Tel"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"),
     dr.GetString("TenTA"),
     dr.GetString("tentinh")

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
