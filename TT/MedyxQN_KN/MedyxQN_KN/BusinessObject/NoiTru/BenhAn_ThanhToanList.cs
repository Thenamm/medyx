using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhAn_ThanhToanList : BusinessListBase<BenhAn_ThanhToanList, BenhAn_ThanhToan>
    {
        #region Factory Methods
        public static BenhAn_ThanhToanList NewList()
        {
            return DataPortal.Fetch<BenhAn_ThanhToanList>(new TemCriteria());
        }
        public static BenhAn_ThanhToanList GetAllBenhAn_ThanhToanByMaBA(string maBA, byte loaikq = 0 )
        {
            return DataPortal.Fetch<BenhAn_ThanhToanList>(new FilterCriteria(maBA ,loaikq ));
        }
        public static BenhAn_ThanhToanList GetAllBenhAn_ThanhToanByMaBA(string maBA)
        {
            return DataPortal.Fetch<BenhAn_ThanhToanList>(new FilterCriteria(maBA, 0));
        }
        public void NewTo(BenhAn_ThanhToan _BenhAn_ThanhToan)
        {
            if (this.Count == 0)
                _BenhAn_ThanhToan.OrderNumber = 1;
            else
            _BenhAn_ThanhToan.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
        _BenhAn_ThanhToan.DaTT = _BenhAn_ThanhToan.OrderNumber;
            this.Add(_BenhAn_ThanhToan);
        }
        public void UpdatedTo(BenhAn_ThanhToan _BenhAn_ThanhToan)
        {

            _BenhAn_ThanhToan.OrderNumber = this.Items[this.IndexOf(_BenhAn_ThanhToan)].OrderNumber;
            this.Items[this.IndexOf(_BenhAn_ThanhToan)] = _BenhAn_ThanhToan;
        }
        public void RemoveTo(BenhAn_ThanhToan _BenhAn_ThanhToan)
        {
            this.Items.Remove(_BenhAn_ThanhToan);

        }

        private BenhAn_ThanhToanList()
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
                _Tungay = tungay ;
                _Denngay = Denngay;
                _LoaiKQKhoa = LoaiKQKhoa ;
                _maKhoa  = maKhoa;
                _DK = dk ;
                _MaDT = madt;
                
                
            }
        }
        [Serializable()]
        private class TemCriteria
        {

        };
        private void DataPortal_Fetch(TemCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
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
            public OtherCriteria(string maKhoa, DateTime tungay, DateTime Denngay, Byte LoaiKQKhoa, string madt)
            {
                _Tungay = tungay;
                _Denngay = Denngay;
                _LoaiKQKhoa = LoaiKQKhoa;
                _maKhoa = maKhoa;
                _DK = "and p.makhoa_ht = '" + _maKhoa + "'";
                _MaDT = madt;


            }
        }

        [Serializable()]
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
            private byte _loaikq;
            public byte loaikq
            {
                get
                {
                    return _loaikq;
                }
            }

            public FilterCriteria(string maBA, byte loaikq = 0)
            {

                _maBA = maBA;
                _loaikq = loaikq;

            }
        }

      
        private void DataPortal_Fetch(FilterCriteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_ThanhToan(criteria.maBA, criteria.DK, criteria.qadmin,criteria .loaikq )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_ThanhToan item = new BenhAn_ThanhToan(
         i,
         dr.GetString("MaBA"),
         dr.GetInt32("DaTT"),
       
         dr.GetSmartDate("DenNgay", true),
         dr.GetString("MaMay"),
         dr.GetBoolean("Huy"),
         dr.GetSmartDate("NgayHuy", true),
         dr.GetString("NguoiHuy"),
     
         dr.GetSmartDate("NgayLap", true),
         dr.GetString("NguoiLap"),
         dr.GetSmartDate("NgaySD", true),
         dr.GetString("NguoiSD"),
         dr.GetSmartDate("NgaySD1", true),
         dr.GetString("NguoiSD1"),
    
         dr.GetString("TenDT"),
         dr.GetString("MaDT"),
       dr.GetSmartDate("TuNgay", true),
       dr.GetSmartDate("ngayqt", true),
       dr.GetSmartDate("ngayqttt", true),
         dr.GetString("nguoiqt"),
           dr.GetString("nguoiqttt"),
             dr.GetBoolean("daqt")
         );
                    this.Add(item);
                    i += 1;

                }
                dr.Close(); dr.Dispose(); //IsReadOnly = true;
            }


            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
    }
}
