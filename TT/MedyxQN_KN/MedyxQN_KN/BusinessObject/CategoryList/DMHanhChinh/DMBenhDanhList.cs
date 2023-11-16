using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMBenhDanhList : ReadOnlyListBase<DMBenhDanhList, DMBenhDanh>
    {
        #region Factory Methods
        public static DMBenhDanhList GetAllDMBenhDanh()
        {
            return DataPortal.Fetch<DMBenhDanhList>();
        }
        public static DMBenhDanhList GetsDMBenhDanhByID(string id)
        {
            return DataPortal.Fetch<DMBenhDanhList>(new Criteria(id));
        }
        private DMBenhDanhList()
        {  /* Require use of factory methods */ }
        public static DMBenhDanhList FindDMBenhDanhByMa(string MaDV)
        {
            return DataPortal.Fetch<DMBenhDanhList>(new CriteriaOther(1, MaDV));
        }
        public static DMBenhDanhList FindDMBenhDanhByMaICD(string MaDV)
        {
            return DataPortal.Fetch<DMBenhDanhList>(new CriteriaOther(3, MaDV));
        }
        public static DMBenhDanhList FindDMBenhDanhByMaICDD(string MaDV)
        {
            return DataPortal.Fetch<DMBenhDanhList>(new CriteriaOther(5, MaDV));
        }
        public static DMBenhDanhList FindDMBenhDanhByTen(string TenDV)
        {
            return DataPortal.Fetch<DMBenhDanhList>(new CriteriaOther(2, TenDV));
        }
        public static DMBenhDanhList FindDMBenhDanhByTenD(string TenDV)
        {
            return DataPortal.Fetch<DMBenhDanhList>(new CriteriaOther(4, TenDV));
        }
        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            private string _id;
            public string Id
            {
                get
                {
                    return _id;
                }
            }
            public Criteria(string mId)
            {
                _id = mId;
            }
        }
        private class CriteriaOther
        {
          
            private string _DK;
            public string DK
            {
                get
                {
                    return _DK;
                }
            }
            public CriteriaOther(Byte mIdFind, String mDK)
            {

                _DK = "  isnull(khongsd,0) = 0 and isnull(huy,0) =0 ";

                if (mIdFind == 1)
                    _DK = _DK + " and (MABENHID like '%" + mDK + "' OR MAICD LIKE N'" + mDK + "%')";
                else if (mIdFind == 3)
                    _DK = _DK + " and (MAICD LIKE N'" + mDK + "%')";
                else if (mIdFind == 5)
                    _DK = _DK + " and (MAICD LIKE N'" + mDK + "')";
                else if (mIdFind == 2)
                    _DK = _DK + " and (ltrim(rtrim(TenBENH)) like N'" + mDK + "%' or ( tenta <> '' and tenta =N'" + mDK + "'))";
                else if (mIdFind == 4)
                    _DK = _DK + " and (ltrim(rtrim(TenBENH)) like N'" + mDK + "' or ( tenta <> '' and tenta =N'" + mDK + "')) ";
               
               
            }
        }

        private void DataPortal_Fetch()
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMBenhDanh()))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMBenhDanh item = new DMBenhDanh(
     i,
     dr.GetString("MaBenhID"),
     dr.GetString("MaICD"),
     dr.GetString ("MaNhomICD"),
     dr.GetString("TenBenh"),
     dr.GetString("TenBenhICD"),
     dr.GetString("MaNhom"),
     dr.GetString("MaBHXH"),
     dr.GetString("MaVN"),
     dr.GetByte("Cap"),
		 dr.GetString ("MaMay"),
		 dr.GetBoolean ("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD") ,
     dr.GetString("idparent"), 
     dr.GetString("Tenta"),
     dr.GetBoolean("khongsd")
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

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetsDMBenhDanhByID(criteria.Id)))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMBenhDanh item = new DMBenhDanh(
     i,
     dr.GetString("MaBenhID"),
     dr.GetString("MaICD"),
     dr.GetString ("MaNhomICD"),
     dr.GetString("TenBenh"),
     dr.GetString("TenBenhICD"),
     dr.GetString("MaNhom"),
     dr.GetString("MaBHXH"),
     dr.GetString("MaVN"),
     dr.GetByte("Cap"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"),
     dr.GetString("idparent"),
     dr.GetString("Tenta"),
     dr.GetBoolean("khongsd")
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMBenhDanh(criteria.DK )))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMBenhDanh item = new DMBenhDanh(
     i,
     dr.GetString("MaBenhID"),
     dr.GetString("MaICD"),
     dr.GetString ("MaNhomICD"),
     dr.GetString("TenBenh"),
     dr.GetString("TenBenhICD"),
     dr.GetString("MaNhom"),
     dr.GetString("MaBHXH"),
     dr.GetString("MaVN"),
     dr.GetByte("Cap"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),
     dr.GetString("idparent"),
     dr.GetString("Tenta"),
     dr.GetBoolean("khongsd")
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
        #endregion
    }
}
