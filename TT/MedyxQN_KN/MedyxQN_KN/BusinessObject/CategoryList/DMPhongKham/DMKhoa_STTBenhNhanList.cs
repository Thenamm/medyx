using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMKhoa_STTBenhNhanList : ReadOnlyListBase<DMKhoa_STTBenhNhanList, DMKhoa_STTBenhNhan>
    {
        #region Factory Methods
        public static DMKhoa_STTBenhNhanList GetAllDMKhoa_STTBenhNhan(String maDV, SmartDate ngayDK )
        {
            return DataPortal.Fetch<DMKhoa_STTBenhNhanList>(new Criteria(maDV, ngayDK ));
        }

        private DMKhoa_STTBenhNhanList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        protected class Criteria
        {
            private String _maDV;
            public String MaDV
            {
                get
                {
                    return _maDV;
                }
            }
       
            private SmartDate _ngayDK;
            public SmartDate NgayDK
            {
                get
                {
                    return _ngayDK;
                }
            }
            public Criteria(String maDV, SmartDate ngayDK)
            {
                _maDV = maDV;
                _ngayDK = ngayDK;
            }  
        }
        

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMKhoa_STTBenhNhan(criteria.MaDV, criteria.NgayDK)))
            {               
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMKhoa_STTBenhNhan item = new DMKhoa_STTBenhNhan(
     dr.GetInt32("STTBN"),
     dr.GetString("MaKhoa"), 
     dr.GetString("TenKhoa")     		 
         );
                    this.Add(item);
                }
                IsReadOnly = true;
            }            
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        

        #endregion
    }
}
