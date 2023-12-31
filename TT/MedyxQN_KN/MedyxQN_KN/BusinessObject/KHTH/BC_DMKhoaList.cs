using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.KHTH
{
    [Serializable()]
    public class BC_DMKhoaList : ReadOnlyListBase<BC_DMKhoaList, BC_DMKhoa>
    {
        #region Factory Methods
        public static BC_DMKhoaList GetAllBC_DMKhoa()
        {
            return DataPortal.Fetch<BC_DMKhoaList>(new Criteria());
        }
        public static BC_DMKhoaList FindBC_DMKhoaByMa(String ma)
        {
            return DataPortal.Fetch<BC_DMKhoaList>(new CriteriaOther(1, ma));
        }
        public static BC_DMKhoaList BC_DMKhoaCap1s()
        {
            return DataPortal.Fetch<BC_DMKhoaList>(new CriteriaOther(3, ""));
        }
        public static BC_DMKhoaList FindBC_DMKhoaByTen(String ten)
        {
            return DataPortal.Fetch<BC_DMKhoaList>(new CriteriaOther(2, ten));
        }
        private BC_DMKhoaList()
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
             private Boolean _qadmin = false ;
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
            public CriteriaOther(Byte mIdFind, String mDK)
            {

                _IdFind = mIdFind;
                _DK = " ISNULL(a.HUY,0) = 0";
                if (mIdFind == 3)
                    _DK = _DK + " AND a.cap = 1  ";
                else
                {
                    _DK = "  AND EXISTS(SELECT B.MAKHOals FROM ACCOUNT B WHERE DBO.FGIAIMA(ACCOUNT)  ='" + _account;
                    _DK = _DK + "' AND (CHARINDEX(''+ A.MAKHOa + '',B.MAKHOals,1) <> 0 OR  ALLMAKHOacls = 1  or ALLMAKHOals = 1 )) ";
                    if (mIdFind == 1)
                        _DK = _DK + " AND MAKHOA like '%" + mDK + "'";
                    else if (mIdFind == 2)
                        _DK = _DK + "AND ltrim(rtrim(TENKHOA)) like N'" + mDK + "%'";
                }
                  


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_DMKhoa(HTC.ShareVariables.pub_bQadmin )))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    BC_DMKhoa item = new BC_DMKhoa(
     i,
     dr.GetString("MaKhoa"), 
     dr.GetString ("TenKhoa"),
     dr.GetByte("Loai"),
     dr.GetByte("Cap"),
     dr.GetDecimal("Sogiuong"),
     dr.GetString("Machuyenkhoa"),
		 dr.GetString ("MaMay"),
		 dr.GetBoolean ("Huy"),
     dr.GetSmartDate("NgaySD",false),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindBC_DMKhoa(criteria.DK, false)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    BC_DMKhoa item = new BC_DMKhoa(
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
