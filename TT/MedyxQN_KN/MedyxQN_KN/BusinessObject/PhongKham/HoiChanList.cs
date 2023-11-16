using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.PhongKham
{
    [Serializable()]
     
    public class HoiChanList : BusinessListBase<HoiChanList, HoiChan>
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
        public static HoiChanList GetAllHoiChan(Boolean qadmin, string maKhoa, DateTime Tungay, DateTime Denngay, string dk)
        {
            return DataPortal.Fetch<HoiChanList>(new Criteria(qadmin, maKhoa, Tungay, Denngay, dk));
        }
        public static HoiChanList GetAllHoiChanFilter(Boolean qadmin, string maKhoa, DateTime Tungay, DateTime Denngay, string dk, string dkfilter)
        {
            return DataPortal.Fetch<HoiChanList>(new CriteriaFilter(qadmin, maKhoa, Tungay, Denngay, dk, dkfilter));
        }
        public void NewTo(HoiChan _HoiChan)
        {
            if (this.Count == 0)
                _HoiChan.OrderNumber = 1;
            else
            _HoiChan.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_HoiChan);
        }
        public void UpdatedTo(HoiChan _HoiChan)
        {

            _HoiChan.OrderNumber = this.Items[this.IndexOf(_HoiChan)].OrderNumber;
            this.Items[this.IndexOf(_HoiChan)] = _HoiChan;
        }
        public void RemoveTo(HoiChan _HoiChan)
        {
            this.Items.Remove(_HoiChan);

        }

        private HoiChanList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
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

            public Criteria(Boolean qadmin, string makhoa, DateTime tungay, DateTime denngay, string dk)
            {
                _Tungay = tungay;
                _Denngay = denngay ;
                _qadmin = qadmin  ;
                _maKhoa = makhoa ;
                _DK = dk;
                
                
            }
        }


        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllHoiChan(criteria.qadmin, criteria.maKhoa, criteria.Tungay, criteria.Denngay, criteria.DK)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    HoiChan item = new HoiChan(
         i,
         dr.GetString("MaHC") ,
			 dr.GetString("MaBA") ,
			 dr.GetString("MaBN") ,
			 dr.GetString("Hoten") ,
			 dr.GetByte("Tuoi"),
			 dr.GetBoolean("GT") ,
			 dr.GetSmartDate("NgaySinh", true) ,
			 dr.GetString("MaKhoa") ,
			 dr.GetString("MaHTHoiChan") ,
			 dr.GetString("MaLDHoiChan") ,
			 dr.GetSmartDate("NgayHC", true) ,
			 dr.GetString("DiaDiem") ,
			 dr.GetString("YeuCauHC") ,
			 dr.GetString("Tinhtrang") ,
			 dr.GetString("TomTat") ,
			 dr.GetString("MaBenhID") ,
			 dr.GetString("NguyenNhan") ,
			 dr.GetString("PhuongPhap") ,
			 dr.GetString("ChamSoc") ,
			 dr.GetString("KetLuan") ,
			 dr.GetBoolean("Huy") ,
			 dr.GetSmartDate("NgaySD", true) ,
			 dr.GetString("NguoiSD") ,
			 dr.GetString("MaMay") ,
			 dr.GetString("Nguoihuy") ,
			 dr.GetSmartDate("Ngayhuy", true) ,
			 dr.GetString("NguoiLap") ,
			 dr.GetSmartDate("NgayLap", true),
         dr.GetString("tenLDHoiChan") ,
         dr.GetString("tenKhoa") ,
         dr.GetString("tenHTHoiChan") ,
         dr.GetString("tenNguoiLap") ,
         dr.GetString("tenNguoiSD") ,
         dr.GetString("tenNguoiHuy") ,
         dr.GetString("maICD") ,
         dr.GetString("tenBenh") ,
         dr.GetSmartDate("NgayKham", true),
         dr.GetString("tenDT") ,
         dr.GetString("MaDT"),
			 dr.GetString("MaBenhIDkhoa") ,
           dr.GetString("maICDkhoa") ,
         dr.GetString("tenBenhkhoa"),
         dr.GetSmartDate("ngaygiovv", true),
         dr.GetString("MaKhoaVV"),
         dr.GetString("tenbacsiyeucau"),
         dr.GetString("mabsyc")
         );
                    this.Add(item);
                    i += 1;

                }
                //IsReadOnly = true;
            }
           

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
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

            public CriteriaFilter(Boolean qadmin, string makhoa, DateTime tungay, DateTime denngay, string dk, string dkFilter)
            {
                _Tungay = tungay;
                _Denngay = denngay;
                _qadmin = qadmin;
                _maKhoa = makhoa;
                _DK = dk;
                _DKFilter = dkFilter;

            }
        }


        private void DataPortal_Fetch(CriteriaFilter criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllHoiChan(criteria.qadmin, criteria.maKhoa, criteria.Tungay, criteria.Denngay, criteria.DK, criteria.DKFilter)))
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
                    HoiChan item = new HoiChan(
         i,
         dr.GetString("MaHC"),
             dr.GetString("MaBA"),
             dr.GetString("MaBN"),
             dr.GetString("Hoten"),
             dr.GetByte("Tuoi"),
             dr.GetBoolean("GT"),
             dr.GetSmartDate("NgaySinh", true),
             dr.GetString("MaKhoa"),
             dr.GetString("MaHTHoiChan"),
             dr.GetString("MaLDHoiChan"),
             dr.GetSmartDate("NgayHC", true),
             dr.GetString("DiaDiem"),
             dr.GetString("YeuCauHC"),
             dr.GetString("Tinhtrang"),
             dr.GetString("TomTat"),
             dr.GetString("MaBenhID"),
             dr.GetString("NguyenNhan"),
             dr.GetString("PhuongPhap"),
             dr.GetString("ChamSoc"),
             dr.GetString("KetLuan"),
             dr.GetBoolean("Huy"),
             dr.GetSmartDate("NgaySD", true),
             dr.GetString("NguoiSD"),
             dr.GetString("MaMay"),
             dr.GetString("Nguoihuy"),
             dr.GetSmartDate("Ngayhuy", true),
             dr.GetString("NguoiLap"),
             dr.GetSmartDate("NgayLap", true),
         dr.GetString("tenLDHoiChan"),
         dr.GetString("tenKhoa"),
         dr.GetString("tenHTHoiChan"),
         dr.GetString("tenNguoiLap"),
         dr.GetString("tenNguoiSD"),
         dr.GetString("tenNguoiHuy"),
         dr.GetString("maICD"),
         dr.GetString("tenBenh"),
         dr.GetSmartDate("NgayKham", true),
         dr.GetString("tenDT"),
         dr.GetString("MaDT"),
             dr.GetString("MaBenhIDkhoa"),
           dr.GetString("maICDkhoa"),
         dr.GetString("tenBenhkhoa"),
         dr.GetSmartDate("ngaygiovv", true),
         dr.GetString("MaKhoaVV"),
         dr.GetString("tenbacsiyeucau"),
         dr.GetString("mabsyc")
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
