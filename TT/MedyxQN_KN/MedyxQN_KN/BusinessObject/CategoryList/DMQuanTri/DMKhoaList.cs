using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMKhoaList : ReadOnlyListBase<DMKhoaList, DMKhoa>
    {
        #region Factory Methods
        public static DMKhoaList GetAllDMKhoa()
        {
            return DataPortal.Fetch<DMKhoaList>(new Criteria());
        }
        public static DMKhoaList FindDMKhoaByMa(String ma, string account)
        {
            return DataPortal.Fetch<DMKhoaList>(new CriteriaOther(1, ma, account));
        }

        public static DMKhoaList FindDMKhoaDK(String Loai, string account)
        {
            return DataPortal.Fetch<DMKhoaList>(new CriteriaOther(100, Loai, account));
        }
        public static DMKhoaList DMKhoaCap1s(string account)
        {
            return DataPortal.Fetch<DMKhoaList>(new CriteriaOther(3, "", account));
        }
        public static DMKhoaList FindDMKhoaByTen(String ten, string account)
        {
            return DataPortal.Fetch<DMKhoaList>(new CriteriaOther(2, ten, account));
        }
        public static DMKhoaList GetAllDMKhoaCap1ByAccount(string account)
        {
            return DataPortal.Fetch<DMKhoaList>(new OtherCriteria("", "", account));
        }
        private DMKhoaList()
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
            private Boolean _qadmin = false;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private string _account = "";
            public string account
            {
                get
                {
                    return _account;
                }
            }
            //public Criteria(Boolean mqadmin)
            //{

            //    _qadmin = mqadmin;
            //}
            public CriteriaOther(Byte mIdFind, String mDK, string acount)
            {
                _account = acount;
                _IdFind = mIdFind;
                _DK = " ISNULL(a.HUY,0) = 0";
                if (mIdFind == 3)
                    _DK = _DK + " AND a.cap = 1  ";
                else
                {
                    _DK = _DK + "  AND EXISTS(SELECT B.MAKHOals FROM ACCOUNT B WHERE DBO.FGIAIMA(ACCOUNT)  ='" + _account;
                    _DK = _DK + "' AND (CHARINDEX(''+ A.MAKHOa + '',B.MAKHOals,1) <> 0 OR  ALLMAKHOacls = 1  or ALLMAKHOals = 1 )) ";
                    if (mIdFind == 1)
                        _DK = _DK + " AND a.MAKHOA like '%" + mDK + "'";
                    else if (mIdFind == 2)
                        _DK = _DK + "AND ltrim(rtrim(TENKHOA)) like N'" + mDK + "%'";
                    else if (mIdFind == 100)
                    {
                        _DK = _DK + " AND a.loai = '" + mDK + "'";
                    }
                }




            }
        }
        #endregion
        private class OtherCriteria
        {

            private string _DK;
            public string DK
            {
                get
                {
                    return _DK;
                }
            }
            private String _maKhoa;
            public String maKhoa
            {
                get
                {
                    return _maKhoa;
                }
            }
            private string _account = "";
            public string account
            {
                get
                {
                    return _account;
                }
            }
            private Boolean _qadmin = false;
            public Boolean Qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public OtherCriteria(String mDK, String mloai, string acount)
            {
                if (mloai == "")
                    mloai = "0";
                _account = acount;
                {
                    _DK = "  EXISTS(SELECT B.MAKHOals FROM ACCOUNT B WHERE DBO.FGIAIMA(ACCOUNT)  ='" + _account;
                    _DK = _DK + "' AND (CHARINDEX( '''' + A.MAKHOa + '''' ,B.MAKHOals,1) <> 0 OR  ALLMAKHOacls = 1  or ALLMAKHOals = 1 )) ";
                };
            }
        }

        private void DataPortal_Fetch(Criteria criteria)
        {
            int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMKhoa(HTC.ShareVariables.pub_bQadmin)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMKhoa item = new DMKhoa(
     i,
     dr.GetString("MaKhoa"),
     dr.GetString("TenKhoa"),
     dr.GetByte("Loai"),
     dr.GetByte("Cap"),
     dr.GetDecimal("Sogiuong"),
     dr.GetString("Machuyenkhoa"),
         dr.GetString("MaMay"),
         dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),
     dr.GetString("idparent"),
     dr.GetString("Tenta"),
     dr.GetString("hoten"),
     false,
       dr.GetString("diadiem"),
        dr.GetString("ghichu"),
         dr.GetBoolean("khonghd"),
          dr.GetString("MaNhom"),
           dr.GetString("TenNhom"),
       dr.GetString("madv"),
       dr.GetString("makhoaql")
                        //dr.GetInt32 ("OrderNumber")

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
            int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMKhoa(criteria.DK, false)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMKhoa item = new DMKhoa(
     i,
     dr.GetString("MaKhoa"),
     dr.GetString("TenKhoa"),
     dr.GetByte("Loai"),
     dr.GetByte("Cap"),
     dr.GetDecimal("Sogiuong"),
     dr.GetString("Machuyenkhoa"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),
     dr.GetString("idparent"),
     dr.GetString("Tenta"),
     dr.GetString("hoten"),
     false,
  dr.GetString("diadiem"),
   dr.GetString("ghichu"),
     dr.GetBoolean("khonghd"),
     dr.GetString("MaNhom"),
       dr.GetString("TenNhom")
       ,
       dr.GetString("madv"),
       dr.GetString("makhoaql")
         );
                    this.Add(item);
                    i += 1;
                }
                IsReadOnly = true;
            }


            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMKhoaCap1ByAccount(criteria.DK, false)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMKhoa item = new DMKhoa(
     i,
     dr.GetString("MaKhoa"),
     dr.GetString("TenKhoa"),
     dr.GetByte("Loai"),
     dr.GetByte("Cap"),
     dr.GetDecimal("Sogiuong"),
     dr.GetString("Machuyenkhoa"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),
     dr.GetString("idparent"),
     dr.GetString("Tenta"),
     dr.GetString("hoten"),
     false,
  dr.GetString("diadiem"),
   dr.GetString("ghichu"),
     dr.GetBoolean("khonghd"),
     dr.GetString("MaNhom"),
       dr.GetString("TenNhom"),
       dr.GetString("madv"),
       dr.GetString("makhoaql")
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
