using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.Duoc
{
    [Serializable()]
    public class Khambenh_ThuocSD_TON_getsListInfo : ReadOnlyListBase<Khambenh_ThuocSD_TON_getsListInfo, Khambenh_ThuocSD_TON_getsInfo>
    {
        #region Business Methods
  
        public Khambenh_ThuocSD_TON_getsInfo this[int  i]
        {
            get
            {
               return this.Items[i]; 
            }
        }
        public Khambenh_ThuocSD_TON_getsInfo Contains(string MaThuoc)
        {
            foreach (Khambenh_ThuocSD_TON_getsInfo obj in this)
                if ((obj.MATHUOC == MaThuoc) )
                    return obj ;
            return null;
        }
        public void UpdatedTo(Khambenh_ThuocSD_TON_getsInfo _Khambenh_ThuocSD_TON_getsInfo)
        {

            _Khambenh_ThuocSD_TON_getsInfo.OrderNumber  = this.Items[this.IndexOf(_Khambenh_ThuocSD_TON_getsInfo)].OrderNumber ;
            this.Items[this.IndexOf(_Khambenh_ThuocSD_TON_getsInfo)] = _Khambenh_ThuocSD_TON_getsInfo;
        }
        public void AssignTo(Khambenh_ThuocSD_TON_getsInfo _Khambenh_ThuocSD_TON_getsInfo)
        {

            _Khambenh_ThuocSD_TON_getsInfo.OrderNumber = this.Items.Count +1;
            this.Items.Add(_Khambenh_ThuocSD_TON_getsInfo);
        }
   
       

       
        #endregion

        #region Factory Methods
        public static Khambenh_ThuocSD_TON_getsListInfo GetAllKhambenh_ThuocSD_TON_gets(DateTime TuNgay, DateTime DenNgay ,Boolean Duyet, Boolean Phat, String  MaDT, String MaKho, String MAKHOA, Boolean dadung, String dk)
        {
            return DataPortal.Fetch<Khambenh_ThuocSD_TON_getsListInfo>(new Criteria(TuNgay,DenNgay , Duyet , Phat , MaDT , MaKho , MAKHOA ,dadung,dk ));
        }
        public static Khambenh_ThuocSD_TON_getsListInfo GetAllKhambenh_ThuocSD_TONNOITRU_gets(DateTime TuNgay, DateTime DenNgay, Boolean Duyet, Boolean Phat, String MaDT, String MaKho, String MAKHOA, Boolean dadung, String dk)
        {
            return DataPortal.Fetch<Khambenh_ThuocSD_TON_getsListInfo>(new Criteria(TuNgay, DenNgay, Duyet, Phat, MaDT, MaKho, MAKHOA, dadung, "1"));
        }

        private Khambenh_ThuocSD_TON_getsListInfo()
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
                Boolean _dadung;
	            Boolean _Phat ;
	            String  _MaDT ;
	            String _MaKho ;
	            String _MAKHOA ;
                String _dk;
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
            public bool Dadung
            {
                get
                {
                    return _dadung;
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
            public Criteria(DateTime mTuNgay, DateTime mDenNgay, Boolean mDuyet, Boolean mPhat, String mMaDT, String mMaKho, String mMAKHOA,Boolean dadung, String mdk)
            {
                         _TuNgay = mTuNgay ;
                         _DenNgay = mDenNgay ;
                         _Duyet = mDuyet ;
                         _Phat = mPhat ;
                         _MaDT = mMaDT ;
                         _MaKho = mMaKho ;
                         _MAKHOA = mMAKHOA ;
                         _dadung = dadung;
                         _dk = mdk ;
            }
        }

        #endregion

       

        private void DataPortal_Fetch(Criteria criteria)
        {
            int i = 1;
            RaiseListChangedEvents = false;
            if (criteria.dk != "1")
            {
                using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhambenh_ThuocSD_TON_gets(criteria.TuNgay, criteria.DenNgay, criteria.Duyet, criteria.Phat, criteria.MaDT, criteria.MaKho, criteria.MAKHOA, criteria.Dadung, criteria.dk)))
                {
                    IsReadOnly = false;
                    while (dr.Read())
                    {
                        Khambenh_ThuocSD_TON_getsInfo item = new Khambenh_ThuocSD_TON_getsInfo(
                 i,
                 dr.GetString("MATHUOC"),
                 dr.GetString("TENTM"),
                 dr.GetString("TENDVT"),
                 dr.GetDecimal("TONCK"),
                 dr.GetDecimal("TONCKDT"),
                 dr.GetString("TENTA"),
                 dr.GetString("TENGOC"),
                 dr.GetBoolean("HANDUNG"),
                 dr.GetString("TENNSX"),
                 dr.GetDecimal("DONGIATT"),
                 dr.GetDecimal("GIANHAP"),
                 dr.GetDecimal("SLDUYET"),
                 dr.GetDecimal("SLPHAT"),
                 false,
                 false,
                  dr.GetDecimal("sodu"),
                   dr.GetDecimal("quydoi")
                   ,dr.GetInt32("Thuoctieuhao")
             );
                        this.Add(item);
                        i += 1;
                    }
                    IsReadOnly = true;
                }
            }
            else
            {
                using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhambenh_ThuocSD_TONNOITRU_gets(criteria.TuNgay, criteria.DenNgay, criteria.Duyet, criteria.Phat, criteria.MaDT, criteria.MaKho, criteria.MAKHOA, criteria.Dadung, criteria.dk)))
                {
                    IsReadOnly = false;
                    while (dr.Read())
                    {
                        Khambenh_ThuocSD_TON_getsInfo item = new Khambenh_ThuocSD_TON_getsInfo(
                 i,
                 dr.GetString("MATHUOC"),
                 dr.GetString("TENTM"),
                 dr.GetString("TENDVT"),
                 dr.GetDecimal("TONCK"),
                 dr.GetDecimal("TONCKDT"),
                 dr.GetString("TENTA"),
                 dr.GetString("TENGOC"),
                 dr.GetBoolean("HANDUNG"),
                 dr.GetString("TENNSX"),
                 dr.GetDecimal("DONGIATT"),
                 dr.GetDecimal("GIANHAP"),
                 dr.GetDecimal("SLDUYET"),
                 dr.GetDecimal("SLPHAT"),
                 false,
                 false,
                  dr.GetDecimal("sodu"),
                   dr.GetDecimal("quydoi")
                  , dr.GetInt32("Thuoctieuhao")

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
