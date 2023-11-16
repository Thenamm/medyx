using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.PhongKham
{
    [Serializable()]
    public class Khambenh_DSListInfo : BusinessListBase<Khambenh_DSListInfo, Khambenh_DSInfo>
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
        public static Khambenh_DSListInfo GetAllKhambenh_DSInfo(DateTime _ngayyc, Byte _loaiphieu, String _dk, DateTime _denngayYC )
        {
            return DataPortal.Fetch<Khambenh_DSListInfo>(new Criteria( _ngayyc,  _loaiphieu,  _dk,   _denngayYC));
        }
        public static Khambenh_DSListInfo GetAllKhambenh_DSFiltersInfo( DateTime _ngayyc, Byte _loaiphieu, String _dk, String _dkfilter, DateTime _denngayYC)
        {
            return DataPortal.Fetch<Khambenh_DSListInfo>(new CriteriaOther( _ngayyc, _loaiphieu, _dk,_dkfilter, _denngayYC));
        }
        public void RemoveTo(int i)
        {
                 
                this.Items.RemoveAt(i);

           
        }
        public void RemoveTo(Khambenh_DSInfo i)
        {

            this.Items.Remove(i);


        }
        private Khambenh_DSListInfo()
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
            private Byte _LoaiKQCN;
            public Byte LoaiKQCN
            {
                get
                {
                    return _LoaiKQCN;
                }
            }
            public string makhoa
            {
                get
                {
                    return _makhoa;
                }
            }


            public Criteria( DateTime ngayYC, Byte loai, string dk, DateTime denngayYC)
            {
                _ngayYC = ngayYC;
                _denngayYC = denngayYC;
                _Loai = loai;
              
                _DK = dk;
               
                
            }
        }

     

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_DSInfo(criteria.qadmin ,  criteria.ngayYC, criteria.Loai, criteria.DK,  criteria.denngayYC    )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    Khambenh_DSInfo item = new Khambenh_DSInfo(
     i,
      dr.GetString("HOTEN"),
		  dr.GetBoolean("GT"),
		  dr.GetString("MABN"),
		  dr.GetString("DIACHI"),
		  dr.GetString("MASOKHAM"),
		  dr.GetString("MADT"),
		  dr.GetString("TENDT"),
      dr.GetByte("tuoi"),
      dr.GetSmartDate ("ngaysinh"),
       dr.GetSmartDate("NGAYDK", true)
       
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
            private Byte _LoaiKQCN;
            public Byte LoaiKQCN
            {
                get
                {
                    return _LoaiKQCN;
                }
            }
            public string makhoa
            {
                get
                {
                    return _makhoa;
                }
            }


            public CriteriaOther(DateTime ngayYC, Byte loai, string dk, string dkFilter,  DateTime denngayYC)
            {
                _ngayYC = ngayYC;
                _denngayYC = denngayYC;
                _Loai = loai;
                _DK = dk;
                _DKFilter = dkFilter;
            }
        }



        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_DSFiltersInfo(criteria.qadmin, criteria.ngayYC, criteria.Loai, criteria.DK, criteria.DKFilter, criteria.denngayYC)))
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
                    Khambenh_DSInfo item = new Khambenh_DSInfo(
     i,
      dr.GetString("HOTEN"),
          dr.GetBoolean("GT"),
          dr.GetString("MABN"),
          dr.GetString("DIACHI"),
          dr.GetString("MASOKHAM"),
          dr.GetString("MADT"),
          dr.GetString("TENDT"),
      dr.GetByte("tuoi"),
      dr.GetSmartDate("ngaysinh"),
       dr.GetSmartDate("NGAYDK", true)
      
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
