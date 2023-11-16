using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.Duoc
{
    [Serializable()]
    public class Benhan_NhapTra_BN_getsListInfo : ReadOnlyListBase<Benhan_NhapTra_BN_getsListInfo, Benhan_NhapTra_BN_getsInfo>
    {
     
        #region Factory Methods
        public static Benhan_NhapTra_BN_getsListInfo BenhAnNhapTra_BN_gets(DateTime TuNgay, String MaKho, String MaDT, String MAKHOA, Boolean TRA, String dk)
        {
            return DataPortal.Fetch<Benhan_NhapTra_BN_getsListInfo>(new Criteria(TuNgay,MaKho ,MaDT, MAKHOA ,TRA,dk ));
        }

        private Benhan_NhapTra_BN_getsListInfo()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access
        #region Criteria
        [Serializable()]
        private class Criteria
        {
            DateTime _TuNgay;
	            String _MaKho ;
                String _MaDT;
	            String _MAKHOA ;
                 Boolean _TRA;
                String _dk;
            public DateTime TuNgay
            {
                get
                {
                    return _TuNgay;
                }
            }
            public string MaKho
            {
                get
                {
                    return _MaKho;
                }
            }
            public string MaDT
            {
                get
                {
                    return _MaDT;
                }
            }
            public string MAKHOA
            {
                get
                {
                    return _MAKHOA;
                }
            }
            public bool TRA
            {
                get
                {
                    return _TRA;
                }
            }
            public string dk
            {
                get
                {
                    return _dk;
                }
            }
            public Criteria(DateTime mTuNgay, String mMaKho, String mMaDT, String mMAKHOA, Boolean MTRA, String mdk)
            {

                         _TuNgay = mTuNgay;
                         _MaKho = mMaKho ;
                         _MaDT = mMaDT;
                         _MAKHOA = mMAKHOA ;
                         _TRA = MTRA; 
                          _dk = mdk ;
            }
        }

        #endregion

       

        private void DataPortal_Fetch(Criteria criteria)
        {
            int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().BenhAnNhapTra_BN_gets(criteria.TuNgay, criteria.MaKho, criteria.MaDT, criteria.MAKHOA, criteria.TRA, criteria.dk)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    Benhan_NhapTra_BN_getsInfo item = new Benhan_NhapTra_BN_getsInfo(
             i,                                
             dr.GetString("MATHUOC") ,
			 dr.GetString("TENTM") ,
			 dr.GetString("TENDVT") ,
			 dr.GetDecimal("SLTRA") ,0,			
			 dr.GetString("HOTEN"),
             dr.GetBoolean("TRA"),
             dr.GetString ("mASOKHAM") ,
             dr.GetString("mABN") ,
             dr.GetBoolean("gt"),
             dr.GetInt32("Sttkhoa"),
             dr.GetInt32("Stt")
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
