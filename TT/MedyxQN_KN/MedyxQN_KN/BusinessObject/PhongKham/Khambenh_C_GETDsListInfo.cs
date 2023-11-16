using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.PhongKham
{
    [Serializable()]
    public class KhamBenh_C_GetDsListInfo : BusinessListBase<KhamBenh_C_GetDsListInfo, KhamBenh_C_GetDsInfo>
    {
        #region Factory Methods
        public static KhamBenh_C_GetDsListInfo GetAllKhamBenh_C_GetDsInfo( Byte _LoaiKQCN, DateTime _ngayyc, Byte _loaiphieu, String _dk,string _makhoa, DateTime _denngayYC )
        {
            return DataPortal.Fetch<KhamBenh_C_GetDsListInfo>(new Criteria(_LoaiKQCN,  _ngayyc,  _loaiphieu,  _dk, _makhoa,  _denngayYC));
        }
        
        
        private KhamBenh_C_GetDsListInfo()
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


            public Criteria(Byte LoaiKQCN, DateTime ngayYC, Byte loai, string dk, string makhoa, DateTime denngayYC)
            {
                _ngayYC = ngayYC;
                _denngayYC = denngayYC;
                _Loai = loai;
              
                _DK = dk;
                _LoaiKQCN = LoaiKQCN;
               
                _makhoa = makhoa;
                
            }
        }

     

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_C_GetDsInfo(criteria.qadmin , criteria.LoaiKQCN  ,  criteria.ngayYC, criteria.Loai, criteria.DK, criteria.makhoa, criteria.denngayYC    )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    KhamBenh_C_GetDsInfo item = new KhamBenh_C_GetDsInfo(
     i,
      dr.GetString("HOTEN"),
		  dr.GetBoolean("GT"),
		  dr.GetString("MABN"),
		  dr.GetString("DIACHI"),
		  dr.GetString("MASOKHAM"),                                
		  dr.GetString("MADT"),
		  dr.GetString("TENDT"),
		  dr.GetInt32("SOTT"),
		  dr.GetByte("TRANGTHAI"),
		  dr.GetSmartDate("NGAYYC", true),
		  dr.GetByte("tuoi"),
      dr.GetSmartDate ("ngaysinh"),
       dr.GetSmartDate("NGAYDK", true)
         );
                    this.Add(item);
                    i += 1;

                }
                dr.Close(); dr.Dispose();  //IsReadOnly = true;
            }
           
            //IsReadOnly = true;

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        

        #endregion
    }
}
