using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.TBYT
{
    [Serializable()]
    public class LKNhapTra_C_TonBN_getsListInfo : ReadOnlyListBase<LKNhapTra_C_TonBN_getsListInfo, LKNhapTra_C_TonBN_getsInfo>
    {
        #region Business Methods
  
        public LKNhapTra_C_TonBN_getsInfo this[int  i]
        {
            get
            {
               return this.Items[i]; 
            }
        }
        public LKNhapTra_C_TonBN_getsInfo Contains(string MaLK)
        {
            foreach (LKNhapTra_C_TonBN_getsInfo obj in this)
                if ((obj.MaLK == MaLK) )
                    return obj ;
            return null;
        }
        public void UpdatedTo(LKNhapTra_C_TonBN_getsInfo _LKNhapTra_C_TonBN_getsInfo)
        {

            _LKNhapTra_C_TonBN_getsInfo.OrderNumber  = this.Items[this.IndexOf(_LKNhapTra_C_TonBN_getsInfo)].OrderNumber ;
            this.Items[this.IndexOf(_LKNhapTra_C_TonBN_getsInfo)] = _LKNhapTra_C_TonBN_getsInfo;
        }
   
       

       
        #endregion

        #region Factory Methods
        public static LKNhapTra_C_TonBN_getsListInfo GetAllLKNhapTra_C_TonBN_gets(String MaKho, String MAKHOA, Byte Loai, String dk)
        {
            return DataPortal.Fetch<LKNhapTra_C_TonBN_getsListInfo>(new Criteria( MaKho , MAKHOA ,Loai,dk ));
        }

        private LKNhapTra_C_TonBN_getsListInfo()
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
               Byte _Loai;
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
            public Byte Loai
            {
                get
                {
                    return _Loai;
                }
            }
            public Criteria(  String mMaKho, String mMAKHOA,  Byte mLoai, String mdk)
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllLKNhapTra_C_TonBN_gets(  criteria.MaKho, criteria.MAKHOA, criteria.Loai ,  criteria.dk)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    LKNhapTra_C_TonBN_getsInfo item = new LKNhapTra_C_TonBN_getsInfo(
             i, 
             dr.GetString("MaLK") ,
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
