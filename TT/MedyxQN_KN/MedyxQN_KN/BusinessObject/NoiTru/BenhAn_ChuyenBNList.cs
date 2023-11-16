using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhAn_ChuyenBNList : BusinessListBase<BenhAn_ChuyenBNList, BenhAn_ChuyenBN>
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

        public static BenhAn_ChuyenBNList GetAllBenhAn_ChuyenBNFilter(DateTime Tungay, DateTime Denngay, Byte loaikqkhoa, string madt, string dk, string dkfilter)
        {
            return DataPortal.Fetch<BenhAn_ChuyenBNList>(new CriteriaFilter(Tungay, Denngay, loaikqkhoa, madt, dk, dkfilter));
        }

        public void NewTo(BenhAn_ChuyenBN _BenhAn_ChuyenBN)
        {
            if (this.Count == 0)
                _BenhAn_ChuyenBN.OrderNumber = 1;
            else
                _BenhAn_ChuyenBN.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BenhAn_ChuyenBN);
        }
        public static BenhAn_ChuyenBNList NewTo()
        {
            return DataPortal.Fetch<BenhAn_ChuyenBNList>(new TemCriteria());
        }
        public void UpdatedTo(BenhAn_ChuyenBN _BenhAn_ChuyenBN)
        {

            _BenhAn_ChuyenBN.OrderNumber = this.Items[this.IndexOf(_BenhAn_ChuyenBN)].OrderNumber;
            this.Items[this.IndexOf(_BenhAn_ChuyenBN)] = _BenhAn_ChuyenBN;
        }
        public void RemoveTo(BenhAn_ChuyenBN _BenhAn_ChuyenBN)
        {
            this.Items.Remove(_BenhAn_ChuyenBN);

        }

        private BenhAn_ChuyenBNList()
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
            public Criteria(DateTime tungay, DateTime Denngay, Byte LoaiKQKhoa, string madt, string dk)
            {
                _Tungay = tungay;
                _Denngay = Denngay;
                _LoaiKQKhoa = LoaiKQKhoa;
                _DK = dk;
                _MaDT = madt;


            }
        }

        private class CriteriaFilter
        {
             private Boolean _qadmin = false ;
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
            public CriteriaFilter( DateTime tungay, DateTime Denngay, Byte LoaiKQKhoa, string madt, string dk, string dkfilter)
            {
                _Tungay = tungay;
                _Denngay = Denngay;
                _LoaiKQKhoa = LoaiKQKhoa;
                _DK = _DK + dk;
                _MaDT = madt;
                _DKFilter = dkfilter;

            }
        }

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_ChuyenBN(criteria.Tungay, criteria.Denngay, criteria.LoaiKQKhoa, criteria.MaDT, criteria.DK, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_ChuyenBN item = new BenhAn_ChuyenBN(
         i,
         dr.GetString("MaBA"),
         dr.GetString("MABAGoc"),
             dr.GetString("MaBN"),
             dr.GetSmartDate("NgayChuyen", true),
              dr.GetSmartDate("NgayVV", true),
               dr.GetSmartDate("NgayKT", true),
             dr.GetString("NoiTT"),
             dr.GetSmartDate("NgayNhan", true),
             dr.GetString("MaMay"),
      dr.GetSmartDate("NgayNhanHS", true),
            dr.GetSmartDate("NgayChuyenHS", true),
             dr.GetSmartDate("NgayLap", true),
             dr.GetString("NguoiLap"),
             dr.GetSmartDate("NgaySD", true),
             dr.GetString("NguoiSD"),
             dr.GetByte("lanNhan"),
         dr.GetString("ghichu"),
         dr.GetString("TenDT"),
         dr.GetString("MaDT"),
         dr.GetString("Hoten"),
         dr.GetByte("Tuoi"),
         dr.GetSmartDate("NgaySinh", true),
         dr.GetString("DiaChi"),
         dr.GetBoolean("GT"),
                          dr.GetDecimal("TongTien"),
              dr.GetDecimal("TongTienbh"),
               dr.GetDecimal("TongTienbntra"),
                dr.GetDecimal("tongtamthu"),
                 dr.GetSmartDate("NgayQT", true),
                   dr.GetString("NguoiTT"),
         dr.GetString("MaBAQL"),
        
          dr.GetString("sothe")
          
         );

                    this.Add(item);
                    i += 1;

                }
                //IsReadOnly = true;
                dr.Close(); dr.Dispose();
            }


            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

       
        private void DataPortal_Fetch(CriteriaFilter criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_ChuyenBNFilter(criteria.Tungay, criteria.Denngay, criteria.LoaiKQKhoa, criteria.MaDT, criteria.DK, criteria.qadmin, criteria.DKFilter)))
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
                        BenhAn_ChuyenBN item = new BenhAn_ChuyenBN(
             i,
             dr.GetString("MaBA"),
          
         dr.GetString("MABAGoc"),
             dr.GetString("MaBN"),
             dr.GetSmartDate("NgayChuyen", true),
               dr.GetSmartDate("NgayVV", true),
               dr.GetSmartDate("NgayKT", true),
             dr.GetString("NoiTT"),
             dr.GetSmartDate("NgayNhan", true),
             dr.GetString("MaMay"),
      dr.GetSmartDate("NgayNhanHS", true),
            dr.GetSmartDate("NgayChuyenHS", true),
             dr.GetSmartDate("NgayLap", true),
             dr.GetString("NguoiLap"),
             dr.GetSmartDate("NgaySD", true),
             dr.GetString("NguoiSD"),
             dr.GetByte("lanNhan"),
         dr.GetString("ghichu"),
         dr.GetString("TenDT"),
         dr.GetString("MaDT"),
         dr.GetString("Hoten"),
         dr.GetByte("Tuoi"),
         dr.GetSmartDate("NgaySinh", true),
         dr.GetString("DiaChi"),
         dr.GetBoolean("GT"),
                          dr.GetDecimal("TongTien"),
              dr.GetDecimal("TongTienbh"),
               dr.GetDecimal("TongTienbntra"),
                dr.GetDecimal("tongtamthu"),
                 dr.GetSmartDate("NgayQT", true),
                   dr.GetString("NguoiTT"),
         dr.GetString("MaBAQL"),
        
          dr.GetString("sothe")         
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
