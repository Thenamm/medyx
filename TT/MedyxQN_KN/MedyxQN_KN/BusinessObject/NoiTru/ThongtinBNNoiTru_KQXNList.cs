using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class ThongtinBNNoiTru_KQXNList : BusinessListBase<ThongtinBNNoiTru_KQXNList, ThongtinBNNoiTru_KQXN >
    {
        #region Factory Methods
        public static ThongtinBNNoiTru_KQXNList GetAllThongtinBNNoiTru_KQXN(Boolean Qadmin,string MaSoKham, byte DaTT, byte Loai,string DK   )
        {
            return DataPortal.Fetch<ThongtinBNNoiTru_KQXNList>(new Criteria(Qadmin , MaSoKham, DaTT, Loai ,DK ));
        }
        
        
        private ThongtinBNNoiTru_KQXNList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            private string _MaSoKham ;
            private Byte _Loai;
            private Byte _DaTT;
            private DateTime _NgayYC;
            private string _DK;
            private Boolean _qadmin = false ;
            public string MaSoKham
            {
                get
                {
                    return _MaSoKham;
                }
            }
            public Byte Loai
            {
                get
                {
                    return _Loai;
                }
            }

            public DateTime NgayYC
            {
                get
                {
                    return _NgayYC;
                }
            }
            public Byte DaTT
            {
                get
                {
                    return _DaTT;
                }
            }

            public string DK
            {
                get
                {
                    return _DK;
                }
            }

            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }

            public Criteria(Boolean mQAdmin,  string mMaSoKham,byte mDaTT, byte mLoai,string mDK )
            {
                _qadmin = mQAdmin;  
                _MaSoKham = mMaSoKham;
                _DaTT = mDaTT;
                _Loai = mLoai;
                _DK = mDK;
            }
        }

     

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllThongtinBNNoiTru_KQXN(criteria.qadmin, criteria.MaSoKham ,criteria.DaTT,criteria.Loai ,criteria.DK )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    ThongtinBNNoiTru_KQXN item = new ThongtinBNNoiTru_KQXN(
     i,
    dr.GetString("DATT") ,
			                               dr.GetString("Ten") ,
			                               dr.GetInt32("Dongia") ,
			                               dr.GetInt32("SL"),
			                               dr.GetDecimal("CK"),
			                               dr.GetDecimal("TT") ,
			                               dr.GetString("MAKHOA") ,
			                               dr.GetString("TENKHOA") ,
			                               dr.GetInt32("MABS"),
			                               dr.GetString("TENBS") ,
			                               dr.GetString("TENXN") ,
			                               dr.GetString("KetQua"),
			                               dr.GetDecimal("STTDV") ,
			                               dr.GetString("MA") ,
			                               dr.GetInt32("LOAI") ,
			                               dr.GetString("MASOKHAM"),
			                               dr.GetString("TENDT") ,
			                               dr.GetInt32("DONGIABH") ,
			                               dr.GetByte("TINHTIEN") ,
			                               dr.GetByte("THUTHUAT") 
         );
                    this.Add(item);
                    i += 1;

                }
                dr.Close(); dr.Dispose();  //IsReadOnly = true;
               // dr.Close();
               
            }
           
            //IsReadOnly = true;
           
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        

        #endregion
    }
}
