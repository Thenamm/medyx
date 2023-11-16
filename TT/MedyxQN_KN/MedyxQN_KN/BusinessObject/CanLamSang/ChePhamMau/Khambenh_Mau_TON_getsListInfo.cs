using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CanLamSang
{
    [Serializable()]
    public class Khambenh_Mau_TON_getsListInfo : ReadOnlyListBase<Khambenh_Mau_TON_getsListInfo, Khambenh_Mau_TON_getsInfo>
    {
        #region Business Methods
  
        public Khambenh_Mau_TON_getsInfo this[int  i]
        {
            get
            {
               return this.Items[i]; 
            }
        }
        public Khambenh_Mau_TON_getsInfo Contains(string MaCPMau)
        {
            foreach (Khambenh_Mau_TON_getsInfo obj in this)
                if ((obj.MaCPMau == MaCPMau) )
                    return obj ;
            return null;
        }
        public void UpdatedTo(Khambenh_Mau_TON_getsInfo _Khambenh_Mau_TON_getsInfo)
        {

            _Khambenh_Mau_TON_getsInfo.OrderNumber  = this.Items[this.IndexOf(_Khambenh_Mau_TON_getsInfo)].OrderNumber ;
            this.Items[this.IndexOf(_Khambenh_Mau_TON_getsInfo)] = _Khambenh_Mau_TON_getsInfo;
        }
   
       

       
        #endregion

        #region Factory Methods
        public static Khambenh_Mau_TON_getsListInfo GetAllKhambenh_Mau_TON_gets(DateTime TuNgay, DateTime DenNgay ,Boolean Duyet, Boolean Phat, String  MaDT, String MaKho, String MAKHOA, Boolean dadung, String dk)
        {
            return DataPortal.Fetch<Khambenh_Mau_TON_getsListInfo>(new Criteria(TuNgay,DenNgay , Duyet , Phat , MaDT , MaKho , MAKHOA ,dadung,dk ));
        }

        private Khambenh_Mau_TON_getsListInfo()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access
        #region Criteria
        [Serializable()]
        private class Criteria
        {
                DateTime    _TuNgay ;
	            DateTime _DenNgay ;
	            Boolean _Duyet ;
	            Boolean _Phat ;
	            String  _MaDT ;
	            String _MaKho ;
	            String _MAKHOA ;
                String _dk;
            Boolean _dadung;
            public DateTime TuNgay
            {
                get
                {
                    return _TuNgay;
                }
            }
            public DateTime DenNgay
            {
                get
                {
                    return _DenNgay;
                }
            }
            public bool Duyet
            {
                get
                {
                    return _Duyet;
                }
            }
            public bool Phat
            {
                get
                {
                    return _Phat;
                }
            }
            public string MaDT
            {
                get
                {
                    return _MaDT;
                }
            }
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
            public bool Dadung
            {
                get
                {
                    return _dadung;
                }
            }
            public Criteria(DateTime mTuNgay, DateTime mDenNgay, Boolean mDuyet, Boolean mPhat, String mMaDT, String mMaKho, String mMAKHOA, Boolean dadung,String mdk)
            {
                         _TuNgay = mTuNgay ;
                         _DenNgay = mDenNgay ;
                         _Duyet = mDuyet ;
                         _Phat = mPhat ;
                         _MaDT = mMaDT ;
                         _MaKho = mMaKho ;
                         _MAKHOA = mMAKHOA ;
                         _dk = mdk ;
                         _dadung = dadung;
            }
        }

        #endregion

       

        private void DataPortal_Fetch(Criteria criteria)
        {
            int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhambenh_Mau_TON_gets(criteria.TuNgay, criteria.DenNgay, criteria.Duyet, criteria.Phat, criteria.MaDT, criteria.MaKho, criteria.MAKHOA, criteria.Dadung,criteria.dk)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    Khambenh_Mau_TON_getsInfo item = new Khambenh_Mau_TON_getsInfo(
             i, 
             dr.GetString("MaCPMau") ,
			 dr.GetString("TENTM") ,
			 dr.GetString("TENDVT") ,
			 dr.GetDecimal("TONCK") ,
			 dr.GetDecimal("TONCKDT") ,
			 dr.GetString("TENTA"),
			// dr.GetString("TENGOC") ,
			 dr.GetBoolean("HANDUNG") ,
			// dr.GetString("TENNSX") ,
			 dr.GetDecimal("DONGIATT") ,
			 //dr.GetDecimal("ngayphat") ,
             dr.GetDecimal("GIANHAP"),
			 dr.GetDecimal("SLDUYET") ,
			 dr.GetDecimal("SLPHAT"),
             false,
             false
    
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
