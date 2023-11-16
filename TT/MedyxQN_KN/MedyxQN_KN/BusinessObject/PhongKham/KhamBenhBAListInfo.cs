using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.PhongKham
{
    [Serializable()]
    public class KhamBenhBAListInfo : ReadOnlyListBase<KhamBenhBAListInfo, KhamBenhBAInfo>
    {
        #region Factory Methods
        public static KhamBenhBAListInfo GetKhamBenhBAListInfo(DateTime tungayYC, DateTime denngayYC, byte loai, string dk, string makhoa, string madt, byte loaikq)
        {
            return DataPortal.Fetch<KhamBenhBAListInfo>(new Criteria(tungayYC, denngayYC, loai, dk, makhoa, madt,loaikq));
            
        }
        public void RemoveTo(KhamBenhBAInfo i)
        {

            this.Items.Remove(i);


        }
        private KhamBenhBAListInfo()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
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
            private DateTime  _tungayYC;
            public DateTime tungayYC
            {
                get
                {
                    return _tungayYC;
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

            private byte _loai;
            public byte loai
            {
                get
                {
                    return _loai;
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
            private string _dk;
            public string dk
            {
                get
                {
                    return _dk;
                }
            }

            private string _makhoa;
            public string makhoa
            {
                get
                {
                    return _makhoa;
                }
            }

            private string _madt;
            public string madt
            {
                get
                {
                    return _madt;
                }
            }

            public Criteria(DateTime mtungayYC, DateTime mdenngayYC, byte mloai, string mdk, string mMakhoa, string mMadt, byte loaikq)
            {
                _tungayYC = mtungayYC;
                _denngayYC = mdenngayYC;
                _loai = mloai;
                _dk = mdk;
                _makhoa = mMakhoa;
                _madt = mMadt;
                _loaikq = loaikq;
            }
        }

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKhamBenhBAListInfo(criteria.qadmin, criteria.tungayYC, criteria.denngayYC, criteria.loai, criteria.dk, criteria.makhoa, criteria.madt, criteria.loaikq)))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    KhamBenhBAInfo item = new KhamBenhBAInfo(
                        
         i,
         dr.GetString("HOTEN") ,
         dr.GetBoolean("GT") ,
         dr.GetString("MABN") ,
         dr.GetString("DIACHI") ,
         dr.GetString("MASOKHAM") ,
         dr.GetInt32("STT") ,
         dr.GetString("MADT") ,
         dr.GetString("TENDT") ,
         dr.GetString("MAKHOAVV"),
         dr.GetString("TENKHOAVV"),
         dr.GetSmartDate("NGAYVV", true) ,
         dr.GetSmartDate("NGAYVKHOA", true),
         dr.GetSmartDate("NGAYRAVIEN", true) ,
         dr.GetSmartDate("NGAYLAP", true) ,
         dr.GetString("NGUOILAP") ,
         dr.GetString("NGUOISD") ,
         dr.GetSmartDate("NGAYSD", true) ,
         dr.GetSmartDate("NGAYHUY", true) ,
         dr.GetString("NGUOIHUY") ,
         dr.GetString("TENNGUOILAP") ,
         dr.GetString("TENNGUOISD") ,
         dr.GetString("TENNGUOIHUY"),
         dr.GetString("maba"),
         dr.GetByte("loaikq"),
         dr.GetString("mabaql"),
         dr.GetString("sothe") 
         );
                    this.Add(item);
                    i += 1;
                }
                dr.Close(); dr.Dispose(); IsReadOnly = true;
                    
            }
           

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
    }
}
