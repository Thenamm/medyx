using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.HoaChat
{
    [Serializable()]
    public class HCNhapTra_C_TonBN_getsListInfo : ReadOnlyListBase<HCNhapTra_C_TonBN_getsListInfo, HCNhapTra_C_TonBN_getsInfo>
    {
        #region Business Methods
  
        public HCNhapTra_C_TonBN_getsInfo this[int  i]
        {
            get
            {
               return this.Items[i]; 
            }
        }
        public HCNhapTra_C_TonBN_getsInfo Contains(string MaHC)
        {
            foreach (HCNhapTra_C_TonBN_getsInfo obj in this)
                if ((obj.MaHC == MaHC) )
                    return obj ;
            return null;
        }
        public void UpdatedTo(HCNhapTra_C_TonBN_getsInfo _HCNhapTra_C_TonBN_getsInfo)
        {

            _HCNhapTra_C_TonBN_getsInfo.OrderNumber  = this.Items[this.IndexOf(_HCNhapTra_C_TonBN_getsInfo)].OrderNumber ;
            this.Items[this.IndexOf(_HCNhapTra_C_TonBN_getsInfo)] = _HCNhapTra_C_TonBN_getsInfo;
        }
   
       

       
        #endregion

        #region Factory Methods
        public static HCNhapTra_C_TonBN_getsListInfo GetAllHCNhapTra_C_TonBN_gets(String MaKho, String MAKHOA, Byte Loai, String dk)
        {
            return DataPortal.Fetch<HCNhapTra_C_TonBN_getsListInfo>(new Criteria( MaKho , MAKHOA ,Loai ,dk ));
        }

        private HCNhapTra_C_TonBN_getsListInfo()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access
        #region Criteria
        [Serializable()]
        private class Criteria
        {
               
	            String _MaKho ;
	            String _MAKHOA ;
                Byte _Loai;
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
            public Byte Loai
            {
                get
                {
                    return _Loai;
                }
            }
            public string dk
            {
                get
                {
                    return _dk;
                }
            }
            public Criteria(String mMaKho, String mMAKHOA, Byte mLoai, String mdk)
            {
                      
                      
                         _MaKho = mMaKho ;
                         _MAKHOA = mMAKHOA ;
                         _Loai = mLoai;
                         _dk = mdk ;
            }
        }

        #endregion

       

        private void DataPortal_Fetch(Criteria criteria)
        {
            int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllHCNhapTra_C_TonBN_gets(criteria.MaKho, criteria.MAKHOA, criteria.Loai, criteria.dk)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    HCNhapTra_C_TonBN_getsInfo item = new HCNhapTra_C_TonBN_getsInfo(
             i, 
             dr.GetString("MaHC") ,
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
