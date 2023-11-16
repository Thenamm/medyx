using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.PhongKham
{
    [Serializable()]
    public class KhamBenh_XQ_GetsListInfo : BusinessListBase<KhamBenh_XQ_GetsListInfo, KhamBenh_XQ_GetsInfo>
    {
        #region Business Methods
        #region State Fields
        public int _record = 0;

        #endregion
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
        #region Factory Methods
        public static KhamBenh_XQ_GetsListInfo GetAllKhamBenh_XQ_GetsInfo( Byte _NoiTTCN, DateTime _ngayyc, Byte _loaiphieu, String _dk,string _makhoa, DateTime _denngayYC )
        {
            return DataPortal.Fetch<KhamBenh_XQ_GetsListInfo>(new Criteria(_NoiTTCN,  _ngayyc,  _loaiphieu,  _dk, _makhoa,  _denngayYC));
        }
        public static KhamBenh_XQ_GetsListInfo GetAllKhamBenh_XQ_GetFiltersInfo(Byte _NoiTTCN, DateTime _ngayyc, Byte _loaiphieu, String _dk, String _dkfilter, string _makhoa, DateTime _denngayYC)
        {
            return DataPortal.Fetch<KhamBenh_XQ_GetsListInfo>(new CriteriaOther(_NoiTTCN, _ngayyc, _loaiphieu, _dk,_dkfilter, _makhoa, _denngayYC));
        }
        public void RemoveTo(int i)
        {
                 
                this.Items.RemoveAt(i);

           
        }
        public void RemoveTo(KhamBenh_XQ_GetsInfo i)
        {

            this.Items.Remove(i);


        }
        private KhamBenh_XQ_GetsListInfo()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
           
            private string _makhoa ;
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
            private DateTime _ngayYC;
            public DateTime ngayYC
            {
                get
                {
                    return _ngayYC;
                }
            }
            private DateTime _denngayYC;
            public DateTime denngayYC
            {
                get
                {
                    return _denngayYC;
                }
            }
            private Byte _Loai;
            public Byte Loai
            {
                get
                {
                    return _Loai;
                }
            }
            private Int32 _stt;
            public Int32 stt
            {
                get
                {
                    return _stt;
                }
            }
            private Byte _NoiTTCN;
            public Byte NoiTTCN
            {
                get
                {
                    return _NoiTTCN;
                }
            }
            public string makhoa
            {
                get
                {
                    return _makhoa;
                }
            }


            public Criteria(Byte NoiTTCN, DateTime ngayYC, Byte loai, string dk, string makhoa, DateTime denngayYC)
            {
                _ngayYC = ngayYC;
                _denngayYC = denngayYC;
                _Loai = loai;
              
                _DK = dk;
                _NoiTTCN = NoiTTCN;
               
                _makhoa = makhoa;
                
            }
        }

     

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_XQ_GETsInfo(criteria.qadmin , criteria.NoiTTCN  ,  criteria.ngayYC, criteria.Loai, criteria.DK, criteria.makhoa, criteria.denngayYC    )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    KhamBenh_XQ_GetsInfo item = new KhamBenh_XQ_GetsInfo(
     i,
      dr.GetString("HOTEN"),
		  dr.GetBoolean("GT"),
		  dr.GetString("MABN"),
		  dr.GetString("DIACHI"),
		  dr.GetString("MASOKHAM"),
		  dr.GetString("MaDV"),
		  dr.GetString("TENDV"),
		  dr.GetInt32("STT"),
		  dr.GetString("MADT"),
		  dr.GetString("TENDT"),
      dr.GetByte("tuoi"),
      dr.GetSmartDate ("ngaysinh"),
       dr.GetSmartDate("NGAYDK", true),
         dr.GetString("NoiTT"),
      dr.GetString("makhoa"),
      dr.GetString("tenkhoa"),
         dr.GetInt32("sttkhoa"),
         dr.GetByte("bn")
         );
                    this.Add(item);
                    i += 1;

                }
                dr.Close(); dr.Dispose();   //IsReadOnly = true;
            }
           
            //IsReadOnly = true;

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        private class CriteriaOther
        {

            private string _makhoa;
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
            private DateTime _ngayYC;
            public DateTime ngayYC
            {
                get
                {
                    return _ngayYC;
                }
            }
            private DateTime _denngayYC;
            public DateTime denngayYC
            {
                get
                {
                    return _denngayYC;
                }
            }
            private Byte _Loai;
            public Byte Loai
            {
                get
                {
                    return _Loai;
                }
            }
            private Int32 _stt;
            public Int32 stt
            {
                get
                {
                    return _stt;
                }
            }
            private Byte _NoiTTCN;
            public Byte NoiTTCN
            {
                get
                {
                    return _NoiTTCN;
                }
            }
            public string makhoa
            {
                get
                {
                    return _makhoa;
                }
            }


            public CriteriaOther(Byte NoiTTCN, DateTime ngayYC, Byte loai, string dk, string dkFilter, string makhoa, DateTime denngayYC)
            {
                _ngayYC = ngayYC;
                _denngayYC = denngayYC;
                _Loai = loai;
                _DK = dk;
                _DKFilter = dkFilter;
                _NoiTTCN = NoiTTCN;

                _makhoa = makhoa;

            }
        }



        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_XQ_GETFiltersInfo(criteria.qadmin, criteria.NoiTTCN, criteria.ngayYC, criteria.Loai, criteria.DK, criteria.DKFilter, criteria.makhoa, criteria.denngayYC)))
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
                    KhamBenh_XQ_GetsInfo item = new KhamBenh_XQ_GetsInfo(
     i,
      dr.GetString("HOTEN"),
          dr.GetBoolean("GT"),
          dr.GetString("MABN"),
          dr.GetString("DIACHI"),
          dr.GetString("MASOKHAM"),
          dr.GetString("MaDV"),
          dr.GetString("TENDV"),
          dr.GetInt32("STT"),
          dr.GetString("MADT"),
          dr.GetString("TENDT"),
         
      dr.GetByte("tuoi"),
      dr.GetSmartDate("ngaysinh"),
       dr.GetSmartDate("NGAYDK", true),
         dr.GetString("NoiTT"),
      dr.GetString("makhoa"),
      dr.GetString("tenkhoa"),
         dr.GetInt32("sttkhoa"),
         dr.GetByte("bn")
         );
                    this.Add(item);
                    i += 1;

                }
                dr.Close(); dr.Dispose();   //IsReadOnly = true;
            }

            //IsReadOnly = true;

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
       
        #endregion
    }
}
