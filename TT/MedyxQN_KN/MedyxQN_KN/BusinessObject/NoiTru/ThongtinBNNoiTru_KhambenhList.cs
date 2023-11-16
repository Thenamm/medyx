using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class ThongtinBNNoiTru_KhamBenhListInfo : BusinessListBase<ThongtinBNNoiTru_KhamBenhListInfo, ThongtinBNNoiTru_KhamBenh >
    {
        #region Factory Methods
        public static ThongtinBNNoiTru_KhamBenhListInfo GetAllThongtinBNNoiTru_KhamBenh(string MABN  )
        {
            return DataPortal.Fetch<ThongtinBNNoiTru_KhamBenhListInfo>(new Criteria(MABN));
        }
        
        
        private ThongtinBNNoiTru_KhamBenhListInfo()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            private string _MaBN;
            private Byte _Loai;
            private DateTime _NgayYC;
            private string _DK;
            private Boolean _qadmin = false ;
            public string MaBN
            {
                get
                {
                    return _MaBN;
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

            public Criteria(string mMaBN)
            {
                _MaBN = mMaBN;
                
            }
        }

     

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllThongtinBNNoiTru_KhamBenh(criteria.MaBN)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    ThongtinBNNoiTru_KhamBenh item = new ThongtinBNNoiTru_KhamBenh(
     i,
     dr.GetString("MaSoKham") ,
     dr.GetSmartDate("NgayDK"), 
     dr.GetString("TuoiThai"), 
     dr.GetString("CTCVB"),
     dr.GetString("NgoiThai"),
      dr.GetString("TimThai"),
      dr.GetString("dauhieubatthuong"),
      dr.GetString("xutri"),
      dr.GetString("mach"),
      dr.GetString("apHuyet"),
      dr.GetString("nhietDo"),
      dr.GetString("nhipTho"),
      dr.GetString("canNang"),
      dr.GetString("chandoan"),
      dr.GetString("tienluong"),
      dr.GetString("huongdt"),
      dr.GetString("chieucaotc")  
         );
                    this.Add(item);
                    i += 1;

                }
                //IsReadOnly = true;
               // dr.Close();
               
            }
           
            //IsReadOnly = true;
           
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        

        #endregion
    }
}
