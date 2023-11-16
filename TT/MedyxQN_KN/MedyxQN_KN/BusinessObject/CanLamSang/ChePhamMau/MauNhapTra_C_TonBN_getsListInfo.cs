using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CanLamSang
{
    [Serializable()]
    public class MauNhapTra_C_TonBN_getsListInfo : ReadOnlyListBase<MauNhapTra_C_TonBN_getsListInfo, MauNhapTra_C_TonBN_getsInfo>
    {
        #region Business Methods
  
        public MauNhapTra_C_TonBN_getsInfo this[int  i]
        {
            get
            {
               return this.Items[i]; 
            }
        }
        public MauNhapTra_C_TonBN_getsInfo Contains(string MaCPMau)
        {
            foreach (MauNhapTra_C_TonBN_getsInfo obj in this)
                if ((obj.MACPMau == MaCPMau) )
                    return obj ;
            return null;
        }
        public void UpdatedTo(MauNhapTra_C_TonBN_getsInfo _MauNhapTra_C_TonBN_getsInfo)
        {

            _MauNhapTra_C_TonBN_getsInfo.OrderNumber  = this.Items[this.IndexOf(_MauNhapTra_C_TonBN_getsInfo)].OrderNumber ;
            this.Items[this.IndexOf(_MauNhapTra_C_TonBN_getsInfo)] = _MauNhapTra_C_TonBN_getsInfo;
        }
   
       

       
        #endregion

        #region Factory Methods
        public static MauNhapTra_C_TonBN_getsListInfo GetAllMauNhapTra_C_TonBN_gets(  String MaKho, String MAKHOA, String dk)
        {
            return DataPortal.Fetch<MauNhapTra_C_TonBN_getsListInfo>(new Criteria( MaKho , MAKHOA ,dk ));
        }

        private MauNhapTra_C_TonBN_getsListInfo()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllMauNhapTra_C_TonBN_gets(  criteria.MaKho, criteria.MAKHOA,   criteria.dk)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    MauNhapTra_C_TonBN_getsInfo item = new MauNhapTra_C_TonBN_getsInfo(
             i,
             dr.GetString("MACPMau"),
             dr.GetString("TENTM"),
             dr.GetString("TENDVT"),
             dr.GetDecimal("TONCK"),

             dr.GetString("MAQL"),

             dr.GetString("solo"),

             dr.GetSmartDate("handung", true)

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
