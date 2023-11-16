using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;


namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMKTPhauThuatList : BusinessListBase<DMKTPhauThuatList, DMKTPhauThuat>
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
        public static DMKTPhauThuatList GetAllDMKTPhauThuat()
        {
            return DataPortal.Fetch<DMKTPhauThuatList>(new Criteria());
        }
        // tim theo dieu kien ten
        public static DMKTPhauThuatList FindDMKTPhauThuatByTen(string TenPT)
        {
            return DataPortal.Fetch<DMKTPhauThuatList>(new CriteriaOther(2,TenPT));
        }
        public static DMKTPhauThuatList FindDMKTPhauThuatByTenD(string TenPT)
        {
            return DataPortal.Fetch<DMKTPhauThuatList>(new CriteriaOther(4, TenPT));
        }
        public static DMKTPhauThuatList FindDMKTPhauThuatByMa(string MaPT)
        {
            return DataPortal.Fetch<DMKTPhauThuatList>(new CriteriaOther(1,MaPT));
        }
      
        public static DMKTPhauThuatList FindDMKTPhauThuatByMaBA(string Ma)
        {
            return DataPortal.Fetch<DMKTPhauThuatList>(new CriteriaOther(40, Ma));
        }
        public static DMKTPhauThuatList FindDMKTPhauThuatByGoiTen(string TenPT)
        {
            return DataPortal.Fetch<DMKTPhauThuatList>(new CriteriaOther(6, TenPT));
        }
        public static DMKTPhauThuatList FindDMKTPhauThuatByGoiTenD(string TenPT)
        {
            return DataPortal.Fetch<DMKTPhauThuatList>(new CriteriaOther(7, TenPT));
        }
        public static DMKTPhauThuatList FindDMKTPhauThuatByGoiMa(string MaPT)
        {
            return DataPortal.Fetch<DMKTPhauThuatList>(new CriteriaOther(8, MaPT));
        }
      
        public static DMKTPhauThuatList FindDMKTPhauThuatByNhom(string maNhomPT)
        {
            return DataPortal.Fetch<DMKTPhauThuatList>(new CriteriaOther(3, maNhomPT));
        }
        public static DMKTPhauThuatList FindDMKTPhauThuatByMaPT(byte loai, string maPT)
        {
            return DataPortal.Fetch<DMKTPhauThuatList>(new CriteriaFind(1, loai, maPT));
        }
        public static DMKTPhauThuatList FindDMKTPhauThuatByTenPT(byte loai, string TenPT)
        {
            return DataPortal.Fetch<DMKTPhauThuatList>(new CriteriaFind(2, loai, TenPT));
        }
        public static DMKTPhauThuatList FindDMKTPhauThuatByMaTT(byte loai, string maPT)
        {
            return DataPortal.Fetch<DMKTPhauThuatList>(new CriteriaFind(1, loai, maPT));
        }
        public static DMKTPhauThuatList FindDMKTPhauThuatByTenTT(byte loai, string TenPT)
        {
            return DataPortal.Fetch<DMKTPhauThuatList>(new CriteriaFind(2, loai, TenPT));
        }
        public static DMKTPhauThuatList FindDMKTPhauThuatByNhomFilter(string maNhomPT, string dkfilter)
        {
            return DataPortal.Fetch<DMKTPhauThuatList>(new CriteriaFilter(3, maNhomPT, dkfilter));
        }
        public static DMKTPhauThuatList FindDMKTPhauThuatByFilter(string sql, string dkfilter)
        {
            return DataPortal.Fetch<DMKTPhauThuatList>(new CriteriaFilter(1, sql, dkfilter));
        }
      
        public void NewTo(DMKTPhauThuat _DMKTPhauThuat)
        {
            if (this.Count == 0)
                _DMKTPhauThuat.OrderNumber = 1;
            else
            _DMKTPhauThuat.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMKTPhauThuat);
        }
        public void UpdatedTo(DMKTPhauThuat _DMKTPhauThuat)
        {

            _DMKTPhauThuat.OrderNumber = this.Items[this.IndexOf(_DMKTPhauThuat)].OrderNumber;
            this.Items[this.IndexOf(_DMKTPhauThuat)] = _DMKTPhauThuat;
        }
        public void RemoveTo(DMKTPhauThuat _DMKTPhauThuat)
        {
            this.Items.Remove(_DMKTPhauThuat);

        }
        public DMKTPhauThuat Contains(string MaPT)
        {
            foreach (DMKTPhauThuat obj in this)
                if (obj.MaPT == MaPT)
                    return obj;
            return null;
        }
        private DMKTPhauThuatList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        #region Criteria
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
           
        }
        #endregion
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
                if (mIdFind == 40)
                    _DK = " a.mapt  in (select distinct mapt from benhan_KTPhauThuat where maba ='" + mDK + "')";

                else if (mIdFind == 1)
                    _DK = "(MaPT like '" + mDK + "%' OR a.TENTAT LIKE N'" + mDK + "%')";
                else if  (mIdFind == 2) 
                        _DK = "ltrim(rtrim(TenPT)) like N'" + mDK + "%'";
                else if ((mIdFind == 3) && (mDK != "All")  )
                        _DK = "ltrim(rtrim(A.MaNhom)) like N'" + mDK + "'";
                    else if (mIdFind == 4)
                        _DK = "ltrim(rtrim(TenPT)) like N'" + mDK + "'";
                    else  if (mIdFind == 5)
                        _DK = "(MaPT like '" + mDK + "%' OR a.TENTAT LIKE N'" + mDK + "%') and isnull(a.goidichvu,0) = 1  ";
                    else if (mIdFind == 6)
                        _DK = "ltrim(rtrim(TenPT)) like N'" + mDK + "%' and isnull(a.goidichvu,0) = 1 ";
                
                    else if (mIdFind == 7)
                        _DK = "ltrim(rtrim(TenPT)) like N'" + mDK + "' and isnull(a.goidichvu,0) = 1";
            }
        }
        #endregion

        #region CriteriaFind
        [Serializable()]
        private class CriteriaFind
        {
            private Byte _Loai;
            public Byte Loai
            {
                get
                {
                    return _Loai;
                }
            }
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
           
            public CriteriaFind(Byte mIdFind, byte loai, String mDK)
            {
                _Loai = loai;
                _IdFind = mIdFind;
                if ((mIdFind == 1) && (loai == 1))
                    _DK = "A.MaPT like '%" + mDK + "' and A.machungloai in ('00011')";
                if ((mIdFind == 1) && (loai == 2))
                    _DK = "A.MaPT like '%" + mDK + "' and A.machungloai in ('00012')";
                if ((mIdFind == 2) && (loai == 1))
                    _DK = "ltrim(rtrim(TenPT)) like N'" + mDK + "%'" + "and A.machungloai in ('00011')";;
                if ((mIdFind == 2) && (loai == 2))
                    _DK = "ltrim(rtrim(TenPT)) like N'" + mDK + "%'" + "and A.machungloai in ('00012')";
            }
        }
        #endregion
        #region CriteriaFind
        [Serializable()]
        private class CriteriaFilter
        {
            private Byte _Loai;
            public Byte Loai
            {
                get
                {
                    return _Loai;
                }
            }
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
            private string _DKFilter;
            public string DKFilter
            {
                get
                {
                    return _DKFilter;
                }
            }
            public CriteriaFilter(Byte mIdFind, String mDK, String mDKFilter)
            {
               
                _IdFind = mIdFind;
                if ((mIdFind == 3))
                    _DK = "A.Manhom like '%" + mDK + "'";
                else
                    _DK = mDK;
                _DKFilter = mDKFilter;
            }
        }
        #endregion
        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMKTPhauThuat(criteria.qadmin)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMKTPhauThuat item = new DMKTPhauThuat(
     i,
     dr.GetString("MaPT") ,
			                                dr.GetString("TenPT") ,
			                                dr.GetString("MaNHOM") ,
			                                dr.GetString("TenTA") ,
			                                dr.GetString("MaBYTe") ,
			                                dr.GetBoolean("NhapSL"),
			                                dr.GetString("TenTat") ,
			                                dr.GetString("MaLH") ,
			                                dr.GetDecimal("DongiaTT") ,
			                                dr.GetDecimal("DongiaTT1") ,
			                                dr.GetSmartDate("NgayTT1", true) ,
			                                dr.GetString("MaChungloai") ,
			                                dr.GetBoolean("KTCao") ,
			                                dr.GetString("Ghichu") ,
			                                dr.GetString("MaMay") ,
			                                dr.GetSmartDate("NgayHuy", true) ,
			                                dr.GetString("NguoiHuy") ,
			                                dr.GetSmartDate("NgayLap", true) ,
			                                dr.GetString("NguoiLap") ,
			                                dr.GetSmartDate("NgaySD", true) ,
			                                dr.GetString("NguoiSD") ,
			                                dr.GetBoolean("Huy") ,
			                                dr.GetSmartDate("NgaySD1", true) ,
			                                dr.GetString("NguoiSD1") ,
			                                dr.GetBoolean("ADGiaUSD") ,
			                                dr.GetSmartDate("NgayGia", true) ,
			                                dr.GetBoolean("ApdungGoi") ,
			                                dr.GetBoolean("DichVuGui") ,
			                                dr.GetDecimal("HoaHong") ,
			                                dr.GetDecimal("GTHoaHong") ,
			                                dr.GetBoolean("BCThu") ,
			                                dr.GetBoolean("InThu"),
     dr.GetString("TenNhom") ,
     dr.GetString("TenNguoiLap"),
     dr.GetString("TenNguoiSD") ,
     dr.GetString("TenNguoiHuy"),
     dr.GetBoolean("goidichvu") 

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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMKTPhauThuat(criteria.DK,criteria.qadmin)))         
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMKTPhauThuat item = new DMKTPhauThuat(
    i,
     dr.GetString("MaPT"),
     dr.GetString("TenPT"),
     dr.GetString("MaNHOM"),
     dr.GetString("TenTA"),
     dr.GetString("MaBYTe"),
     dr.GetBoolean("NhapSL"),
     dr.GetString("TenTat"),
     dr.GetString("MaLH"),
     dr.GetDecimal("DongiaTT"),
     dr.GetDecimal("DongiaTT1"),
     dr.GetSmartDate("NgayTT1", true),
     dr.GetString("MaChungloai"),
     dr.GetBoolean("KTCao"),
     dr.GetString("Ghichu"),
     dr.GetString("MaMay"),
     dr.GetSmartDate("NgayHuy", true),
     dr.GetString("NguoiHuy"),
     dr.GetSmartDate("NgayLap", true),
     dr.GetString("NguoiLap"),
     dr.GetSmartDate("NgaySD", true),
     dr.GetString("NguoiSD"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD1", true),
     dr.GetString("NguoiSD1"),
     dr.GetBoolean("ADGiaUSD"),
     dr.GetSmartDate("NgayGia", true),
     dr.GetBoolean("ApdungGoi"),
     dr.GetBoolean("DichVuGui"),
     dr.GetDecimal("HoaHong"),
     dr.GetDecimal("GTHoaHong"),
     dr.GetBoolean("BCThu"),
     dr.GetBoolean("InThu"),
     dr.GetString("TenNhom"),
     dr.GetString("TenNguoiLap"),
     dr.GetString("TenNguoiSD"),
     dr.GetString("TenNguoiHuy"),
     dr.GetBoolean("goidichvu")  
     ); 
      this.Add(item);
 i += 1;

                }
                //if (this.Count == 0)
                //{
                //   //MessageBox.Show("Chưa có danh mục phẫu thuật này!","Thong bao",MessageBoxIcon.Information );
                //}
                //IsReadOnly = true;
            }
           
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        private void DataPortal_Fetch(CriteriaFind criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMKTPhauThuat(criteria.DK, false)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMKTPhauThuat item = new DMKTPhauThuat(
    i,
     dr.GetString("MaPT"),
     dr.GetString("TenPT"),
     dr.GetString("MaNHOM"),
     dr.GetString("TenTA"),
     dr.GetString("MaBYTe"),
     dr.GetBoolean("NhapSL"),
     dr.GetString("TenTat"),
     dr.GetString("MaLH"),
     dr.GetDecimal("DongiaTT"),
     dr.GetDecimal("DongiaTT1"),
     dr.GetSmartDate("NgayTT1", true),
     dr.GetString("MaChungloai"),
     dr.GetBoolean("KTCao"),
     dr.GetString("Ghichu"),
     dr.GetString("MaMay"),
     dr.GetSmartDate("NgayHuy", true),
     dr.GetString("NguoiHuy"),
     dr.GetSmartDate("NgayLap", true),
     dr.GetString("NguoiLap"),
     dr.GetSmartDate("NgaySD", true),
     dr.GetString("NguoiSD"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD1", true),
     dr.GetString("NguoiSD1"),
     dr.GetBoolean("ADGiaUSD"),
     dr.GetSmartDate("NgayGia", true),
     dr.GetBoolean("ApdungGoi"),
     dr.GetBoolean("DichVuGui"),
     dr.GetDecimal("HoaHong"),
     dr.GetDecimal("GTHoaHong"),
     dr.GetBoolean("BCThu"),
     dr.GetBoolean("InThu"),
     dr.GetString("TenNhom"),
     dr.GetString("TenNguoiLap"),
     dr.GetString("TenNguoiSD"),
     dr.GetString("TenNguoiHuy"),
     dr.GetBoolean("goidichvu") 
     );
                    this.Add(item);
                    i += 1;

                }
               
            }

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaFilter criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMKTPhauThuatFilter(criteria.DK, criteria.DKFilter, criteria.qadmin)))
            {
                int i = 1;

                //IsReadOnly = false;
                if (dr.Read())
                {
                    _record = dr.GetInt32("record");
                }
                if (dr.NextResult())
                while (dr.Read())
                {
                    DMKTPhauThuat item = new DMKTPhauThuat(
    i,
     dr.GetString("MaPT"),
     dr.GetString("TenPT"),
     dr.GetString("MaNHOM"),
     dr.GetString("TenTA"),
     dr.GetString("MaBYTe"),
     dr.GetBoolean("NhapSL"),
     dr.GetString("TenTat"),
     dr.GetString("MaLH"),
     dr.GetDecimal("DongiaTT"),
     dr.GetDecimal("DongiaTT1"),
     dr.GetSmartDate("NgayTT1", true),
     dr.GetString("MaChungloai"),
     dr.GetBoolean("KTCao"),
     dr.GetString("Ghichu"),
     dr.GetString("MaMay"),
     dr.GetSmartDate("NgayHuy", true),
     dr.GetString("NguoiHuy"),
     dr.GetSmartDate("NgayLap", true),
     dr.GetString("NguoiLap"),
     dr.GetSmartDate("NgaySD", true),
     dr.GetString("NguoiSD"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD1", true),
     dr.GetString("NguoiSD1"),
     dr.GetBoolean("ADGiaUSD"),
     dr.GetSmartDate("NgayGia", true),
     dr.GetBoolean("ApdungGoi"),
     dr.GetBoolean("DichVuGui"),
     dr.GetDecimal("HoaHong"),
     dr.GetDecimal("GTHoaHong"),
     dr.GetBoolean("BCThu"),
     dr.GetBoolean("InThu"),
     dr.GetString("TenNhom"),
     dr.GetString("TenNguoiLap"),
     dr.GetString("TenNguoiSD"),
     dr.GetString("TenNguoiHuy"),
     dr.GetBoolean("goidichvu")
     );
                    this.Add(item);
                    i += 1;

                }
                //if (this.Count == 0)
                //{
                //   //MessageBox.Show("Chưa có danh mục phẫu thuật này!","Thong bao",MessageBoxIcon.Information );
                //}
                //IsReadOnly = true;
            }

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
    }
}
