using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.VTYT
{
    [Serializable()]
    public class VTNhapTra_C_TonBN_getsListInfo : ReadOnlyListBase<VTNhapTra_C_TonBN_getsListInfo, VTNhapTra_C_TonBN_getsInfo>
    {
        #region Business Methods
  
        public VTNhapTra_C_TonBN_getsInfo this[int  i]
        {
            get
            {
               return this.Items[i]; 
            }
        }
        public VTNhapTra_C_TonBN_getsInfo Contains(string MaVT)
        {
            foreach (VTNhapTra_C_TonBN_getsInfo obj in this)
                if ((obj.MaVT == MaVT) )
                    return obj ;
            return null;
        }
        public void UpdatedTo(VTNhapTra_C_TonBN_getsInfo _VTNhapTra_C_TonBN_getsInfo)
        {

            _VTNhapTra_C_TonBN_getsInfo.OrderNumber  = this.Items[this.IndexOf(_VTNhapTra_C_TonBN_getsInfo)].OrderNumber ;
            this.Items[this.IndexOf(_VTNhapTra_C_TonBN_getsInfo)] = _VTNhapTra_C_TonBN_getsInfo;
        }
   
       

       
        #endregion

        #region Factory Methods
        public static VTNhapTra_C_TonBN_getsListInfo GetAllVTNhapTra_C_TonBN_gets(String MaKho, String MAKHOA, Byte Loai, String dk)
        {
            return DataPortal.Fetch<VTNhapTra_C_TonBN_getsListInfo>(new Criteria( MaKho , MAKHOA ,Loai,dk ));
        }

        private VTNhapTra_C_TonBN_getsListInfo()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllVTNhapTra_C_TonBN_gets(  criteria.MaKho, criteria.MAKHOA, criteria.Loai ,  criteria.dk)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    VTNhapTra_C_TonBN_getsInfo item = new VTNhapTra_C_TonBN_getsInfo(
             i, 
             dr.GetString("MaVT") ,
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
