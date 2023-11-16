using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMNhanVienList : ReadOnlyListBase<DMNhanVienList, DMNhanVien>
    {
        #region Business Methods
        #region State Fields
        public int _record = 0;

        #endregion
        #region Business Properties and Methods
        public int record
        {
            get
            {

                return _record;
            }

        }
        #endregion
        #endregion
        #region Factory Methods
        public static DMNhanVienList GetAllDMNhanVien()
        {
            return DataPortal.Fetch<DMNhanVienList>(new Criteria());
        }
        public static DMNhanVienList FindDMNhanVienByFilter(String dk,string dkfilter)
        {
            return DataPortal.Fetch<DMNhanVienList>(new CriteriaFilter(dk, dkfilter));
        }
      
        public static DMNhanVienList FindDMNhanVienByMaKhoa(String makhoa)
        {
            return DataPortal.Fetch<DMNhanVienList>(new CriteriaOther(3, makhoa));
        }
        public static DMNhanVienList FindDMNhanVienByMaKhoaBS(String makhoa)
        {
            return DataPortal.Fetch<DMNhanVienList>(new CriteriaOther(8, makhoa));
        }
        public static DMNhanVienList FindDMNhanVienByMa(String ma)
        {
            return DataPortal.Fetch<DMNhanVienList>(new CriteriaOther(1, ma));
        }
        public static DMNhanVienList FindDMNhanVienByTen(String ten)
        {
            return DataPortal.Fetch<DMNhanVienList>(new CriteriaOther(2, ten));
        }
        public static DMNhanVienList FindDMNhanVienByTenD(String ten)
        {
            return DataPortal.Fetch<DMNhanVienList>(new CriteriaOther(6, ten));
        }
        public static DMNhanVienList FindDMNhanVienByMaBS(String ma)
        {
            return DataPortal.Fetch<DMNhanVienList>(new CriteriaOther(4, ma));
        }
        public static DMNhanVienList FindDMNhanVienByTenBS(String ten)
        {
            return DataPortal.Fetch<DMNhanVienList>(new CriteriaOther(5, ten));
        }
        public static DMNhanVienList FindDMNhanVienByTenBSD(String ten)
        {
            return DataPortal.Fetch<DMNhanVienList>(new CriteriaOther(7, ten));
        }
        private DMNhanVienList()
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
                    _DK = "(A.MaNV like '%" + mDK + "' or a.tentat ='" + mDK +"')";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(A.HoTen)) like N'" + mDK + "%'";
                if (mIdFind == 4)
                    _DK = "(A.MaNV like '%" + mDK + "' or a.tentat ='" + mDK + "') and (isnull(a.machungchihanhnghe,'') <>'' or isnull(a.NGUOIGIAMHO,'') <>'')";
                else if (mIdFind == 5)
                    _DK = "ltrim(rtrim(A.HoTen)) like N'" + mDK + "%' and (isnull(a.machungchihanhnghe,'') <>'' or isnull(a.NGUOIGIAMHO,'') <>'')";
                else if (mIdFind == 6)
                    _DK = "ltrim(rtrim(A.HoTen)) like N'" + mDK + "'";
                else if (mIdFind == 7)
                    _DK = "ltrim(rtrim(A.HoTen)) like N'" + mDK + "%'";
                else if ((mIdFind == 3) && (mDK !="All" ))
                  //  _DK = "  EXISTS(SELECT c.MAKHOals FROM ACCOUNT c WHERE  (CHARINDEX( '" + mDK + "' ,c.MAKHOals,1) <> 0  ) and c.manv = a.manv ) "; //OR  ALLMAKHOacls = 1  or ALLMAKHOals = 1
                    _DK = "ltrim(rtrim(A.makhoa)) like N'" + mDK + "%'";
                  else if ((mIdFind == 8) && (mDK !="All" ))
                  //  _DK = "  EXISTS(SELECT c.MAKHOals FROM ACCOUNT c WHERE  (CHARINDEX( '" + mDK + "' ,c.MAKHOals,1) <> 0  ) and c.manv = a.manv ) "; //OR  ALLMAKHOacls = 1  or ALLMAKHOals = 1
                    _DK = "ltrim(rtrim(A.makhoa)) like N'" + mDK + "%' and (isnull(a.machungchihanhnghe,'') <>'' or isnull(a.NGUOIGIAMHO,'') <>'')";
            }
        }
        #endregion
        #region CriteriaOther
        [Serializable()]
        private class CriteriaFilter
        {
            //private int _id;
            //public int Id
            //{
            //    get
            //    {
            //        return _id;
            //    }
            //}
            private string _DKFilter;
            public string DKFilter
            {
                get
                {
                    return _DKFilter;
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
            public CriteriaFilter(String mDK, String mDKFilter )
            {

                _DKFilter = mDKFilter;
                _DK = mDK;

            }
        }
        #endregion
        private void DataPortal_Fetch(Criteria criteria)
        {
            int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMNhanVien(criteria.qadmin  )))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMNhanVien item = new DMNhanVien(
     i,
     dr.GetString("MaNV"), 
			                                dr.GetString("HoTen") ,
			                                dr.GetString("MaChucVu") ,
                                             dr.GetString("MaLoaiHD"),
			                                dr.GetString("MaChuyenMon") ,
			                                dr.GetString("MaKhoa") ,
			                                dr.GetString("MaMay"), 
			                                dr.GetBoolean("Huy"),
     dr.GetBoolean("khongsd"),
			                                dr.GetSmartDate("NgaySD",false), 
			                                dr.GetString("NguoiSD"),
     dr.GetString("TenNguoiSD"),
     dr.GetString("TenKhoa"),
     dr.GetString("TENCHUYENMON"),
     dr.GetString("TenCV"),
     dr.GetString("MACD"),
     dr.GetString("TENCD"),
     dr.GetString("TENtat"),
     dr.GetString("ghichu"),
      dr.GetString("DienThoai"),
     dr.GetString("MaChungChiHanhNghe"),
     dr.GetString("NguoiGiamHo"),
     
      dr.GetString("TenNguoiGiamHo"),
        dr.GetString("TenLoaiHD"),
     dr.GetString("DienThoaiKhoa"),
     dr.GetString("chuky")
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMNhanVien(criteria.DK, false)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMNhanVien item = new DMNhanVien(
     i,
     dr.GetString("MaNV"),
     dr.GetString("HoTen"),
     dr.GetString("MaChucVu"),
      dr.GetString("MaLoaiHD"),
     dr.GetString("MaChuyenMon"),
     dr.GetString("MaKhoa"),
     dr.GetString("MaMay"),
     dr.GetBoolean("khongsd"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),
     dr.GetString("TenNguoiSD"),
     dr.GetString("TenKhoa"),
     dr.GetString("TENCHUYENMON"),
     dr.GetString("TenCV"),
     dr.GetString("MACD"),
     dr.GetString("TENCD"),
     dr.GetString("TENtat"),
     dr.GetString("ghichu"),
      dr.GetString("DienThoai"),
      dr.GetString("MaChungChiHanhNghe"),
     dr.GetString("NguoiGiamHo"),

      dr.GetString("TenNguoiGiamHo"),
        dr.GetString("TenLoaiHD"),
     dr.GetString("DienThoaiKhoa"),
     dr.GetString("chuky")
      );
                    this.Add(item);
                    i += 1;
                }
                IsReadOnly = true;
            }
            

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaFilter criteria)
        {
            int i = 1;
            RaiseListChangedEvents = false;

            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMNhanVienFilter(criteria.DK, criteria.DKFilter,false  )))
            {
                IsReadOnly = false;
                if (dr.Read())
                {
                    _record = dr.GetInt32("record");
                }
                if (dr.NextResult())
                while (dr.Read())
                {
                    DMNhanVien item = new DMNhanVien(
     i,
     dr.GetString("MaNV"),
     dr.GetString("HoTen"),
     dr.GetString("MaChucVu"),
      dr.GetString("MaLoaiHD"),
     dr.GetString("MaChuyenMon"),
     dr.GetString("MaKhoa"),
     dr.GetString("MaMay"),
     dr.GetBoolean("khongsd"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),
     dr.GetString("TenNguoiSD"),
     dr.GetString("TenKhoa"),
     dr.GetString("TENCHUYENMON"),
     dr.GetString("TenCV"),
     dr.GetString("MACD"),
     dr.GetString("TENCD"),
     dr.GetString("TENtat"),
     dr.GetString("ghichu"),
      dr.GetString("DienThoai"),
      dr.GetString("MaChungChiHanhNghe"),
     dr.GetString("NguoiGiamHo"),

      dr.GetString("TenNguoiGiamHo"),
        dr.GetString("TenLoaiHD"),
     dr.GetString("DienThoaiKhoa"),
     dr.GetString("chuky")
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
