using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhAn_KhoaList : BusinessListBase<BenhAn_KhoaList, BenhAn_Khoa>
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
        public static BenhAn_KhoaList GetAllBenhAn_Khoa(string maKhoa, DateTime Tungay, DateTime Denngay, Byte loaikqkhoa, string madt, string dk)
        {
            return DataPortal.Fetch<BenhAn_KhoaList>(new Criteria(maKhoa, Tungay, Denngay, loaikqkhoa, madt, dk));
        }
        public static BenhAn_KhoaList GetAllBenhAn_KhoaByKhoaHT(string maKhoa, DateTime Tungay, DateTime Denngay, Byte loaikqkhoa, string madt, string dk)
        {
            return DataPortal.Fetch<BenhAn_KhoaList>(new OtherCriteria(maKhoa, Tungay, Denngay, loaikqkhoa, madt, dk));
        }
        public static BenhAn_KhoaList GetAllBenhAn_KhoaFilter(string maKhoa, DateTime Tungay, DateTime Denngay, Byte loaikqkhoa, string madt, string dk, string dkfilter)
        {
            return DataPortal.Fetch<BenhAn_KhoaList>(new CriteriaFilter(maKhoa, Tungay, Denngay, loaikqkhoa, madt, dk, dkfilter));
        }

        public static BenhAn_KhoaList GetAllBenhAn_KhoaByMaBA(string maBA)
        {
            return DataPortal.Fetch<BenhAn_KhoaList>(new FilterCriteria(maBA ));
        }

        public void NewTo(BenhAn_Khoa _BenhAn_Khoa)
        {
            if (this.Count == 0)
                _BenhAn_Khoa.OrderNumber = 1;
            else
                _BenhAn_Khoa.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BenhAn_Khoa);
        }
        public static BenhAn_KhoaList NewTo()
        {
            return DataPortal.Fetch<BenhAn_KhoaList>(new TemCriteria());
        }
        public void UpdatedTo(BenhAn_Khoa _BenhAn_Khoa)
        {

            _BenhAn_Khoa.OrderNumber = this.Items[this.IndexOf(_BenhAn_Khoa)].OrderNumber;
            this.Items[this.IndexOf(_BenhAn_Khoa)] = _BenhAn_Khoa;
        }
        public void RemoveTo(BenhAn_Khoa _BenhAn_Khoa)
        {
            this.Items.Remove(_BenhAn_Khoa);

        }

        private BenhAn_KhoaList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class TemCriteria
        {

        };
        private void DataPortal_Fetch(TemCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private class Criteria
        {
             private Boolean _qadmin = false ;
            private String _maKhoa;
            public String maKhoa
            {
                get
                {
                    return _maKhoa;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private String _DK;
            public String DK
            {
                get
                {
                    return _DK;
                }
            }
            private String _MaDT;
            public String MaDT
            {
                get
                {
                    return _MaDT;
                }
            }
            private DateTime _Tungay;
            public DateTime Tungay
            {
                get
                {
                    return _Tungay;
                }
            }
            private DateTime _Denngay;
            public DateTime Denngay
            {
                get
                {
                    return _Denngay;
                }
            }
            private Byte _LoaiKQKhoa;
            public Byte LoaiKQKhoa
            {
                get
                {
                    return _LoaiKQKhoa;
                }
            }
            public Criteria(string maKhoa, DateTime tungay, DateTime Denngay, Byte LoaiKQKhoa, string madt, string dk)
            {
                _Tungay = tungay;
                _Denngay = Denngay;
                _LoaiKQKhoa = LoaiKQKhoa;
                _maKhoa = maKhoa;
                _DK = dk;
                _MaDT = madt;


            }
        }

        private class OtherCriteria
        {
             private Boolean _qadmin = false ;
            private String _maKhoa;
            public String maKhoa
            {
                get
                {
                    return _maKhoa;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private String _DK;
            public String DK
            {
                get
                {
                    return _DK;
                }
            }
            private String _MaDT;
            public String MaDT
            {
                get
                {
                    return _MaDT;
                }
            }
            private DateTime _Tungay;
            public DateTime Tungay
            {
                get
                {
                    return _Tungay;
                }
            }
            private DateTime _Denngay;
            public DateTime Denngay
            {
                get
                {
                    return _Denngay;
                }
            }
            private Byte _LoaiKQKhoa;
            public Byte LoaiKQKhoa
            {
                get
                {
                    return _LoaiKQKhoa;
                }
            }
            public OtherCriteria(string maKhoa, DateTime tungay, DateTime Denngay, Byte LoaiKQKhoa, string madt, string dk)
            {
                _Tungay = tungay;
                _Denngay = Denngay;
                _LoaiKQKhoa = LoaiKQKhoa;
                _maKhoa = maKhoa;
                if (_maKhoa != "All")
                    _DK = "and p.makhoa_ht = '" + _maKhoa + "'";
                _DK = _DK + dk;
                _MaDT = madt;


            }
        }


        private class FilterCriteria
        {
             private Boolean _qadmin = false ;
            private String _maBA;
            public String maBA
            {
                get
                {
                    return _maBA;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private String _DK;
            public String DK
            {
                get
                {
                    return _DK;
                }
            }


            public FilterCriteria(string maBA)
            {

                _maBA = maBA;


            }
        }
        private class CriteriaFilter
        {
             private Boolean _qadmin = false ;
            private String _maKhoa;
            public String maKhoa
            {
                get
                {
                    return _maKhoa;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private String _DK;
            public String DK
            {
                get
                {
                    return _DK;
                }
            }
            private String _DKFilter;
            public String DKFilter
            {
                get
                {
                    return _DKFilter;
                }
            }
            private String _MaDT;
            public String MaDT
            {
                get
                {
                    return _MaDT;
                }
            }
            private DateTime _Tungay;
            public DateTime Tungay
            {
                get
                {
                    return _Tungay;
                }
            }
            private DateTime _Denngay;
            public DateTime Denngay
            {
                get
                {
                    return _Denngay;
                }
            }
            private Byte _LoaiKQKhoa;
            public Byte LoaiKQKhoa
            {
                get
                {
                    return _LoaiKQKhoa;
                }
            }
            public CriteriaFilter(string maKhoa, DateTime tungay, DateTime Denngay, Byte LoaiKQKhoa, string madt, string dk, string dkfilter)
            {
                _Tungay = tungay;
                _Denngay = Denngay;
                _LoaiKQKhoa = LoaiKQKhoa;
                _maKhoa = maKhoa;

                _DK = _DK + dk;
                _MaDT = madt;
                _DKFilter = dkfilter;

            }
        }

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_Khoa(criteria.maKhoa, criteria.Tungay, criteria.Denngay, criteria.LoaiKQKhoa, criteria.MaDT, criteria.DK, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_Khoa item = new BenhAn_Khoa(
         i,
         dr.GetString("MaBA"),
             dr.GetInt32("STTKhoa"),
         dr.GetString("MaKhoa"),
             dr.GetString("MaBN"),
             dr.GetSmartDate("NgayVKhoa", true),
             dr.GetString("MaBenh"),
             dr.GetString("MaBenhKem"),
             dr.GetString("MaTienLuong"),
             dr.GetString("BSDieuTri"),
             dr.GetString("Yta"),
             dr.GetString("SoPhong"),
             dr.GetString("SoGiuong"),
             dr.GetSmartDate("NgayKT", true),
             dr.GetString("MaMay"),
             dr.GetBoolean("GoiDichVu"),
      dr.GetSmartDate("ngayduyet", true),
            dr.GetSmartDate("ngayhuongbh", true),
             dr.GetSmartDate("NgayHuy", true),
             dr.GetString("NguoiHuy"),
             dr.GetString("LyDoHuy"),
             dr.GetSmartDate("NgayLap", true),
             dr.GetString("NguoiLap"),
             dr.GetSmartDate("NgaySD", true),
             dr.GetString("NguoiSD"),
             dr.GetSmartDate("NgaySD1", true),
             dr.GetString("NguoiSD1"),
             dr.GetByte("RaKhoa"),
         dr.GetString("ghichu"),
         dr.GetString("maicd"),
         dr.GetString("tenbenh"),
         dr.GetString("maicdkem"),
         dr.GetString("tenbenhkem"),
         dr.GetString("TenDT"),
         dr.GetString("MaDT"),
         dr.GetString("Hoten"),
         dr.GetByte("Tuoi"),
         dr.GetSmartDate("NgaySinh", true),
         dr.GetString("DiaChi"),
         dr.GetBoolean("GT"),
         dr.GetString("tenNguoiLap"),
         dr.GetString("tenNguoiSD"),
         dr.GetString("tenNguoiHuy"),
         dr.GetString("tenBSChidinh"),
         dr.GetString("tenYTa"),
                          dr.GetDecimal("TongTien"),
              dr.GetDecimal("TongTienbh"),
               dr.GetDecimal("TongTienbntra"),
                dr.GetDecimal("tongtamthu"),
                 dr.GetSmartDate("NgayQT", true),
                   dr.GetString("NguoiQT"),
         dr.GetString("tenKhoa"),
         dr.GetString("MALOAIBA"),
         dr.GetString("MaBAQL"),
         dr.GetSmartDate("giatridn", true),
           dr.GetString("kethuoc"),
          dr.GetString("sothe"),
           dr.GetSmartDate("GiaTriTN", true),
           dr.GetString("mabv"),
            dr.GetString("tenbv"),

             dr.GetString("mabhxh"),
         dr.GetSmartDate("NgayVVTT", true),
          dr.GetString("NoiTT"),
           dr.GetBoolean("ravien"),
          dr.GetString("maloaibn")
         );

                    this.Add(item);
                    i += 1;

                }
                //IsReadOnly = true;
                dr.Close(); dr.Dispose();
            }


            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_KhoaByKhoaHT(criteria.maKhoa, criteria.Tungay, criteria.Denngay, criteria.LoaiKQKhoa, criteria.MaDT, criteria.DK, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_Khoa item = new BenhAn_Khoa(
         i,
           dr.GetString("MaBA"),
         dr.GetInt32("STTKhoa"),
         dr.GetString("MaKhoa"),
         dr.GetString("MaBN"),
         dr.GetSmartDate("NgayVKhoa", true),
         dr.GetString("MaBenh"),
         dr.GetString("MaBenhKem"),
         dr.GetString("MaTienLuong"),
         dr.GetString("BSDieuTri"),
         dr.GetString("Yta"),
         dr.GetString("SoPhong"),
         dr.GetString("SoGiuong"),
         dr.GetSmartDate("NgayKT", true),
         dr.GetString("MaMay"),
          dr.GetBoolean("GoiDichVu"),
      dr.GetSmartDate("ngayduyet", true),
            dr.GetSmartDate("ngayhuongbh", true),
         dr.GetSmartDate("NgayHuy", true),
         dr.GetString("NguoiHuy"),
         dr.GetString("LyDoHuy"),
         dr.GetSmartDate("NgayLap", true),
         dr.GetString("NguoiLap"),
         dr.GetSmartDate("NgaySD", true),
         dr.GetString("NguoiSD"),
         dr.GetSmartDate("NgaySD1", true),
         dr.GetString("NguoiSD1"),
         dr.GetByte("RaKhoa"),
         dr.GetString("ghichu"),
         dr.GetString("maicd"),
         dr.GetString("tenbenh"),
         dr.GetString("maicdkem"),
         dr.GetString("tenbenhkem"),
         dr.GetString("TenDT"),
         dr.GetString("MaDT"),
         dr.GetString("Hoten"),
         dr.GetByte("Tuoi"),
         dr.GetSmartDate("NgaySinh", true),
         dr.GetString("DiaChi"),
         dr.GetBoolean("GT"),
         dr.GetString("tenNguoiLap"),
         dr.GetString("tenNguoiSD"),
         dr.GetString("tenNguoiHuy"),
         dr.GetString("tenBSChidinh"),
         dr.GetString("tenYTa"),
                          dr.GetDecimal("TongTien"),
              dr.GetDecimal("TongTienbh"),
               dr.GetDecimal("TongTienbntra"),
                dr.GetDecimal("tongtamthu"),
                 dr.GetSmartDate("NgayQT", true),
                   dr.GetString("NguoiQT"),
         dr.GetString("tenKhoa"),
         dr.GetString("MALOAIBA"),
           dr.GetString("MaBAQL"),
         dr.GetSmartDate("giatridn", true),
          dr.GetString("kethuoc"),
          dr.GetString("sothe"),
           dr.GetSmartDate("GiaTriTN", true),
           dr.GetString("mabv"),
            dr.GetString("tenbv"),

             dr.GetString("mabhxh"),
         dr.GetSmartDate("NgayVVTT", true),

             dr.GetString("NoiTT"),
           dr.GetBoolean("ravien"),
          dr.GetString("maloaibn")
         );

                    this.Add(item);
                    i += 1;

                }
                dr.Close(); dr.Dispose();   //IsReadOnly = true;
            }


            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        private void DataPortal_Fetch(FilterCriteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_KhoaByMaBA(criteria.maBA, criteria.DK, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_Khoa item = new BenhAn_Khoa(
i,
 dr.GetString("MaBA"),
dr.GetInt32("STTKhoa"),
dr.GetString("MaKhoa"),
dr.GetString("MaBN"),
dr.GetSmartDate("NgayVKhoa", true),
dr.GetString("MaBenh"),
dr.GetString("MaBenhKem"),
dr.GetString("MaTienLuong"),
dr.GetString("BSDieuTri"),
dr.GetString("Yta"),
dr.GetString("SoPhong"),
dr.GetString("SoGiuong"),
dr.GetSmartDate("NgayKT", true),
dr.GetString("MaMay"),
   dr.GetBoolean("GoiDichVu"),
      dr.GetSmartDate("ngayduyet", true),
            dr.GetSmartDate("ngayhuongbh", true),
           
dr.GetSmartDate("NgayHuy", true),
dr.GetString("NguoiHuy"),
dr.GetString("LyDoHuy"),
dr.GetSmartDate("NgayLap", true),
dr.GetString("NguoiLap"),
dr.GetSmartDate("NgaySD", true),
dr.GetString("NguoiSD"),
dr.GetSmartDate("NgaySD1", true),
dr.GetString("NguoiSD1"),
dr.GetByte("RaKhoa"),
dr.GetString("ghichu"),
dr.GetString("maicd"),
dr.GetString("tenbenh"),
dr.GetString("maicdkem"),
dr.GetString("tenbenhkem"),
dr.GetString("TenDT"),
dr.GetString("MaDT"),
dr.GetString("Hoten"),
dr.GetByte("Tuoi"),
dr.GetSmartDate("NgaySinh", true),
dr.GetString("DiaChi"),
dr.GetBoolean("GT"),
dr.GetString("tenNguoiLap"),
dr.GetString("tenNguoiSD"),
dr.GetString("tenNguoiHuy"),
dr.GetString("tenBSChidinh"),
dr.GetString("tenYTa"),
                         dr.GetDecimal("TongTien"),
              dr.GetDecimal("TongTienbh"),
               dr.GetDecimal("TongTienbntra"),
                dr.GetDecimal("tongtamthu"),
                 dr.GetSmartDate("NgayQT", true),
                   dr.GetString("NguoiQT"),
dr.GetString("tenKhoa"),
dr.GetString("MALOAIBA"),
 dr.GetString("MaBAQL"),
dr.GetSmartDate("giatridn", true),
dr.GetString("kethuoc"),
dr.GetString("sothe"),
 dr.GetSmartDate("GiaTriTN", true),
 dr.GetString("mabv"),
  dr.GetString("tenbv"),

   dr.GetString("mabhxh"),
dr.GetSmartDate("NgayVVTT", true),

   dr.GetString("NoiTT"),
           dr.GetBoolean("ravien"),
          dr.GetString("maloaibn")
);

                    this.Add(item);
                    i += 1;

                }
                dr.Close(); dr.Dispose();   //IsReadOnly = true;
            }


            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaFilter criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_KhoaFilter(criteria.maKhoa, criteria.Tungay, criteria.Denngay, criteria.LoaiKQKhoa, criteria.MaDT, criteria.DK, criteria.qadmin, criteria.DKFilter)))
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
                        BenhAn_Khoa item = new BenhAn_Khoa(
             i,
             dr.GetString("MaBA"),
             dr.GetInt32("STTKhoa"),
             dr.GetString("MaKhoa"),
             dr.GetString("MaBN"),
             dr.GetSmartDate("NgayVKhoa", true),

            dr.GetString("SoPhong"),
             dr.GetString("SoGiuong"),
             dr.GetSmartDate("NgayKT", true),
             dr.GetString("MaMay"),
              dr.GetBoolean("GoiDichVu"),
               dr.GetSmartDate("ngayduyet", true),
            dr.GetSmartDate("ngayhuongbh", true),
           
             dr.GetSmartDate("NgaySD", true),
             dr.GetString("NguoiSD"),

             dr.GetString("TenDT"),
             dr.GetString("MaDT"),
              dr.GetByte("RaKhoa"),
             dr.GetString("Hoten"),
             dr.GetByte("Tuoi"),
             dr.GetSmartDate("NgaySinh", true),
             dr.GetString("DiaChi"),
             dr.GetBoolean("GT"),
             dr.GetDecimal ("TongTien"),
              dr.GetDecimal("TongTienbh"),
               dr.GetDecimal("TongTienbntra"),
                dr.GetDecimal("tongtamthu"),
                 dr.GetSmartDate("NgayQT", true),
                   dr.GetString("NguoiQT"),
             dr.GetString("tenKhoa"),
             dr.GetString("MALOAIBA"),
               dr.GetString("MaBAQL"),
              dr.GetString("kethuoc"),
              dr.GetString("sothe"),
             dr.GetSmartDate("NgayVVTT", true),

                 dr.GetString("NoiTT"),
           dr.GetBoolean("ravien"),
          dr.GetString("maloaibn")
             );

                        this.Add(item);
                        i += 1;

                    }
                //IsReadOnly = true;
                dr.Close(); dr.Dispose();
            }


            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
    }
}
