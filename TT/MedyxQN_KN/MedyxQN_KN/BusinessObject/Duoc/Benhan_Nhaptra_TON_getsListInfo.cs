using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.Duoc
{
    [Serializable()]
    public class Benhan_Nhaptra_TON_getsListInfo : ReadOnlyListBase<Benhan_Nhaptra_TON_getsListInfo, Benhan_Nhaptra_TON_getsInfo>
    {
        #region Business Methods

        public Benhan_Nhaptra_TON_getsInfo this[int i]
        {
            get
            {
                return this.Items[i];
            }
        }
        public Benhan_Nhaptra_TON_getsInfo Contains(string MaThuoc)
        {
            foreach (Benhan_Nhaptra_TON_getsInfo obj in this)
                if ((obj.MATHUOC == MaThuoc))
                    return obj;
            return null;
        }


        #endregion

        #region Factory Methods
        public static Benhan_Nhaptra_TON_getsListInfo Benhan_Thuoctra_List(DateTime TuNgay, String MaKho, String MaDT, String MAKHOA, Boolean tra, String dk)
        {
            return DataPortal.Fetch<Benhan_Nhaptra_TON_getsListInfo>(new Criteria(TuNgay,MaKho, MaDT,MAKHOA,tra, dk));
        }


        private Benhan_Nhaptra_TON_getsListInfo()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access
        #region Criteria
        [Serializable()]
        private class Criteria
        {
            DateTime _TuNgay;
            String _MaKho;
            String _MaDT;
            String _MAKHOA;
            Boolean _tra;
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
            public bool tra
            {
                get
                {
                    return _tra;
                }
            }
            public string dk
            {
                get
                {
                    return _dk;
                }
            }
            public Criteria(DateTime mTuNgay, String mMaKho, String mMaDT, String mMAKHOA, Boolean tra, String mdk)
            {

                _TuNgay = mTuNgay;
                _MaKho = mMaKho;
                _MaDT = mMaDT;
                _MAKHOA = mMAKHOA;
                _tra = tra;
                _dk = mdk;
            }
        }

        #endregion
       

        private void DataPortal_Fetch(Criteria criteria)
        {
            int i = 1;
            RaiseListChangedEvents = false;
           
            {
                using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().Benhan_Thuoctra_List(criteria.TuNgay , criteria.MaKho, criteria.MaDT, criteria.MAKHOA, criteria.tra, criteria.dk)))
                {
                    IsReadOnly = false;
                    while (dr.Read())
                    {
                        Benhan_Nhaptra_TON_getsInfo item = new Benhan_Nhaptra_TON_getsInfo(
                 i,                  
                 dr.GetString("MATHUOC"),
                 dr.GetString("TENTM"),
                 dr.GetString("TENDVT"),
                 dr.GetDecimal("SLTRA"),
                 dr.GetDecimal("DONGIA"),                 
                 dr.GetDecimal("SLDUYET"),
                 dr.GetBoolean("tra")               
                 

             );
                        this.Add(item);
                        i += 1;
                    }
                    IsReadOnly = true;
                }
            }
          
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        
        #endregion
    }
}
