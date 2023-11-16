using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.Duoc
{
    [Serializable()]
    public class NhapTra_C_TonBN_getsListInfo : ReadOnlyListBase<NhapTra_C_TonBN_getsListInfo, NhapTra_C_TonBN_getsInfo>
    {
        #region Business Methods
  
        public NhapTra_C_TonBN_getsInfo this[int  i]
        {
            get
            {
               return this.Items[i]; 
            }
        }
        public NhapTra_C_TonBN_getsInfo Contains(string MaThuoc)
        {
            foreach (NhapTra_C_TonBN_getsInfo obj in this)
                if ((obj.MATHUOC == MaThuoc) )
                    return obj ;
            return null;
        }
        public void UpdatedTo(NhapTra_C_TonBN_getsInfo _NhapTra_C_TonBN_getsInfo)
        {

            _NhapTra_C_TonBN_getsInfo.OrderNumber  = this.Items[this.IndexOf(_NhapTra_C_TonBN_getsInfo)].OrderNumber ;
            this.Items[this.IndexOf(_NhapTra_C_TonBN_getsInfo)] = _NhapTra_C_TonBN_getsInfo;
        }
   
       

       
        #endregion

        #region Factory Methods
        public static NhapTra_C_TonBN_getsListInfo GetAllNhapTra_C_TonBN_gets(  String MaKho, String MAKHOA, String dk)
        {
            return DataPortal.Fetch<NhapTra_C_TonBN_getsListInfo>(new Criteria( MaKho , MAKHOA ,dk ));
        }

        private NhapTra_C_TonBN_getsListInfo()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access
        #region Criteria
        [Serializable()]
        private class Criteria
        {
               
	            String _MaKho ;
	            String _MAKHOA ;
                String _dk;
          
            public string MaKho
            {
                get
                {
                    return _MaKho;
                }
            }
            public string MAKHOA
            {
                get
                {
                    return _MAKHOA;
                }
            }
            public string dk
            {
                get
                {
                    return _dk;
                }
            }
            public Criteria(  String mMaKho, String mMAKHOA, String mdk)
            {
                      
                      
                         _MaKho = mMaKho ;
                         _MAKHOA = mMAKHOA ;
                        
                         _dk = mdk ;
            }
        }

        #endregion

       

        private void DataPortal_Fetch(Criteria criteria)
        {
            int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllNhapTra_C_TonBN_gets(  criteria.MaKho, criteria.MAKHOA,   criteria.dk)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    NhapTra_C_TonBN_getsInfo item = new NhapTra_C_TonBN_getsInfo(
             i, 
             dr.GetString("MATHUOC") ,
			 dr.GetString("TENTM") ,
			 dr.GetString("TENDVT") ,
			 dr.GetDecimal("TONCK") ,
			
			 dr.GetString("MAQL")
    
         );
                    this.Add(item);
                    i += 1;
                }
                IsReadOnly = true;
            }          
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        
        #endregion
    }
}
