using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class TaiBienList : BusinessListBase<TaiBienList, TaiBien>
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
        public static TaiBienList GetAllTaiBien(Boolean qadmin, string maKhoa, DateTime Tungay, DateTime Denngay,byte loai, string dk)
        {
            return DataPortal.Fetch<TaiBienList>(new Criteria(qadmin, maKhoa, Tungay, Denngay,loai , dk));
        }
        public static TaiBienList GetAllTaiBienFilter(Boolean qadmin, string maKhoa, DateTime Tungay, DateTime Denngay, byte loai, string dk, string dkfilter)
        {
            return DataPortal.Fetch<TaiBienList>(new CriteriaFilter(qadmin, maKhoa, Tungay, Denngay, loai, dk, dkfilter));
        }
        public void NewTo(TaiBien _TaiBien)
        {
            if (this.Count == 0)
                _TaiBien.OrderNumber = 1;
            else
            _TaiBien.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_TaiBien);
        }
        public void UpdatedTo(TaiBien _TaiBien)
        {

            _TaiBien.OrderNumber = this.Items[this.IndexOf(_TaiBien)].OrderNumber;
            this.Items[this.IndexOf(_TaiBien)] = _TaiBien;
        }
        public void RemoveTo(TaiBien _TaiBien)
        {
            this.Items.Remove(_TaiBien);

        }
        public TaiBien GetTaiBienBySTT(decimal stt)
        {
            foreach (TaiBien item in this)
                if ((item.OrderNumber == stt))
                    return item;
            return null;
        }
        private TaiBienList()
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
            private byte _loai;
            public byte loai
            {
                get
                {
                    return _loai;
                }
            }
            public Criteria(Boolean qadmin, string makhoa, DateTime tungay, DateTime denngay,byte loai, string dk)
            {
                _Tungay = tungay;
                _Denngay = denngay ;
                _qadmin = qadmin  ;
                _maKhoa = makhoa ;
                _DK = dk;
                _loai = loai;
                
            }
        }


        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllTaiBien(criteria.qadmin, criteria.maKhoa, criteria.Tungay, criteria.Denngay,criteria.loai, criteria.DK)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    TaiBien item = new TaiBien(
         i,
         dr.GetString("MaTB") ,
         dr.GetString("MaBN"),
			 dr.GetString("MaBA_HT") ,
			 dr.GetSmartDate("NgayTaiBien", true) ,
			 dr.GetSmartDate("NgayThucHien", true) ,
			 dr.GetString("MaKhoa") ,
			 dr.GetString("MaTaiBien") ,
			 dr.GetString("MaKQTaiBien") ,
			 dr.GetString("Ghichu") ,
			 dr.GetByte("Loai") ,
			 dr.GetString("MaMay") ,
			 dr.GetBoolean("Huy") ,
			 dr.GetSmartDate("NgaySD", true) ,
			 dr.GetString("NguoiSD") ,
			 dr.GetSmartDate("NgayLap", true) ,
			 dr.GetString("NguoiLap"),
			 dr.GetSmartDate("NgayHuy", true) ,
			 dr.GetString("NguoiHuy") ,
         dr.GetString("TenTaiBien"),
         dr.GetString("TenKhoa") ,         
         dr.GetString("TenKQTaiBien") ,           
         dr.GetString("tenNguoiLap") ,
         dr.GetString("tenNguoiSD") ,
         dr.GetString("tenNguoiHuy") ,
         dr.GetString("TenDT") ,
         dr.GetString("MaDT") , 
         dr.GetString("Hoten") ,
			 dr.GetByte("Tuoi") ,
         dr.GetSmartDate("NgaySinh", true) ,
         dr.GetString("DiaChi") ,
			 dr.GetBoolean("GT") 
         );
                    this.Add(item);
                    i += 1;

                }
                dr.Close(); dr.Dispose(); //IsReadOnly = true;
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
            private byte _loai;
            public byte loai
            {
                get
                {
                    return _loai;
                }
            }
            public CriteriaFilter(Boolean qadmin, string makhoa, DateTime tungay, DateTime denngay, byte loai, string dk, string dkFilter)
            {
                _Tungay = tungay;
                _Denngay = denngay;
                _qadmin = qadmin;
                _maKhoa = makhoa;
                _DK = dk;
                _loai = loai;
                _DKFilter = dkFilter;
            }
        }


        private void DataPortal_Fetch(CriteriaFilter criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllTaiBien(criteria.qadmin, criteria.maKhoa, criteria.Tungay, criteria.Denngay, criteria.loai, criteria.DK, criteria.DKFilter)))
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
                    TaiBien item = new TaiBien(
         i,
         dr.GetString("MaTB"),
         dr.GetString("MaBN"),
             dr.GetString("MaBA_HT"),
             dr.GetSmartDate("NgayTaiBien", true),
             dr.GetSmartDate("NgayThucHien", true),
             dr.GetString("MaKhoa"),
             dr.GetString("MaTaiBien"),
             dr.GetString("MaKQTaiBien"),
             dr.GetString("Ghichu"),
             dr.GetByte("Loai"),
             dr.GetString("MaMay"),
             dr.GetBoolean("Huy"),
             dr.GetSmartDate("NgaySD", true),
             dr.GetString("NguoiSD"),
             dr.GetSmartDate("NgayLap", true),
             dr.GetString("NguoiLap"),
             dr.GetSmartDate("NgayHuy", true),
             dr.GetString("NguoiHuy"),
         dr.GetString("TenTaiBien"),
         dr.GetString("TenKhoa"),
         dr.GetString("TenKQTaiBien"),
         dr.GetString("tenNguoiLap"),
         dr.GetString("tenNguoiSD"),
         dr.GetString("tenNguoiHuy"),
         dr.GetString("TenDT"),
         dr.GetString("MaDT"),
         dr.GetString("Hoten"),
             dr.GetByte("Tuoi"),
         dr.GetSmartDate("NgaySinh", true),
         dr.GetString("DiaChi"),
             dr.GetBoolean("GT")
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
