using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.Duoc
{
    [Serializable()]
   
    public class ThuocSD_GETsMABNListInfo : ReadOnlyListBase<ThuocSD_GETsMABNListInfo, ThuocSD_GETsMABNInfo>
    {
        #region Factory Methods
        public static ThuocSD_GETsMABNListInfo ThuocSD_ListBYBN(string MABN, string dk)
        {
            return DataPortal.Fetch<ThuocSD_GETsMABNListInfo>(new Criteria(MABN, dk));
        }


        private ThuocSD_GETsMABNListInfo()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            private string _MaBN;          
            private string _DK;
            private Boolean _qadmin = false ;
            public string MaBN
            {
                get
                {
                    return _MaBN;
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

            public Criteria(string mMaBN,  string mDK)
            {              
                _MaBN = mMaBN;
              //  _NgayYC = mNgayYC;
                _DK = mDK;                
            }
        }

     

        private void DataPortal_Fetch(Criteria criteria)
        { int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().ThuocSD_ListBYBN(criteria.MaBN,  criteria.DK)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                              
                    ThuocSD_GETsMABNInfo item = new ThuocSD_GETsMABNInfo(
     i,
  dr.GetString("maBN") ,
  dr.GetString("MASOKHAM") ,
  dr.GetSmartDate("NGAYDK",true),
  dr.GetString("TENTM") ,
  dr.GetString("TENDVT"),  
  dr.GetString("MATHUOC") ,           
  dr.GetDecimal("SLMua") ,  
 dr.GetDecimal("SLThang")
         );
                    this.Add(item);
                    i += 1;

                }
               IsReadOnly = true;
               // dr.Close();
               
            }
           
            //IsReadOnly = true;
           
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        

        #endregion
    }
}
