using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.Duoc
{
    [Serializable()]
    public class Khambenh_ThuocSD_DY_BN_getsListInfo : ReadOnlyListBase<Khambenh_ThuocSD_DY_BN_getsListInfo, Khambenh_ThuocSD_DY_BN_getsInfo>
    {
        #region Factory Methods
        public static Khambenh_ThuocSD_DY_BN_getsListInfo GetAllKhambenh_ThuocSD_DY_BN_gets(DateTime TuNgay, DateTime DenNgay ,Boolean Duyet, Boolean Phat, String  MaDT, String MaKho, String MAKHOA, Boolean dadung, String dk)
        {
            return DataPortal.Fetch<Khambenh_ThuocSD_DY_BN_getsListInfo>(new Criteria(TuNgay,DenNgay , Duyet , Phat , MaDT , MaKho , MAKHOA ,dadung,dk ));
        }
        public static Khambenh_ThuocSD_DY_BN_getsListInfo GetAllKhambenh_ThuocSD_DY_BNNOITRU_gets(DateTime TuNgay, DateTime DenNgay, Boolean Duyet, Boolean Phat, String MaDT, String MaKho, String MAKHOA, Boolean dadung, String dk)
        {
            return DataPortal.Fetch<Khambenh_ThuocSD_DY_BN_getsListInfo>(new Criteria(TuNgay, DenNgay, Duyet, Phat, MaDT, MaKho, MAKHOA, dadung, "1"));
        }
        private Khambenh_ThuocSD_DY_BN_getsListInfo()
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
                using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhambenh_ThuocSD_DY_BN_gets(criteria.TuNgay, criteria.DenNgay, criteria.Duyet, criteria.Phat, criteria.MaDT, criteria.MaKho, criteria.MAKHOA, criteria.Dadung, criteria.dk)))
                {
                    IsReadOnly = false;
                    while (dr.Read())
                    {
                        Khambenh_ThuocSD_DY_BN_getsInfo item = new Khambenh_ThuocSD_DY_BN_getsInfo(
                 i,
                 dr.GetString("HOTEN"),
                 dr.GetBoolean("GT"),
                 dr.GetString("MABN"),
                 dr.GetString("DIACHI"),
                 dr.GetString("MASOKHAM"),
                 dr.GetInt32("STT"),
                 dr.GetString("MADT"),
                 dr.GetString("TENDT"),
                 dr.GetSmartDate("NGAYDK", true),
                 dr.GetDecimal("SLMUA"),
                 dr.GetString("SOGIUONG"),
                 dr.GetByte("TUOI"),
                 dr.GetSmartDate("NGAYSINH", true),
                 dr.GetBoolean("DUYET"),
                 dr.GetBoolean("PHAT"),
                 dr.GetInt32("STTKHOA"),
                 0,
                 dr.GetSmartDate("NgaykhamCuoi"),
                 dr.GetString("BSKham"),
                 dr.GetString("Tenbenh"),
                 dr.GetSmartDate("TUNGAY", true),
                 dr.GetSmartDate("DENNGAY", true),
                 dr.GetDecimal("TONGKE"),
                 dr.GetBoolean("KHOAD"),
                 dr.GetSmartDate("NGAYKD", true),
                 dr.GetString("NGUOIKD")

             );
                        this.Add(item);
                        i += 1;
                    }
                    IsReadOnly = true;
                }
            }
            else
            {
                using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhambenh_ThuocSD_DY_BNNOITRU_gets(criteria.TuNgay, criteria.DenNgay, criteria.Duyet, criteria.Phat, criteria.MaDT, criteria.MaKho, criteria.MAKHOA, criteria.Dadung, criteria.dk)))
                {
                    IsReadOnly = false;
                    while (dr.Read())
                    {
                        Khambenh_ThuocSD_DY_BN_getsInfo item = new Khambenh_ThuocSD_DY_BN_getsInfo(
                 i,
                 dr.GetString("HOTEN"),
                 dr.GetBoolean("GT"),
                 dr.GetString("MABN"),
                 dr.GetString("DIACHI"),
                 dr.GetString("MASOKHAM"),
                 dr.GetInt32("STT"),
                 dr.GetString("MADT"),
                 dr.GetString("TENDT"),
                 dr.GetSmartDate("NGAYDK", true),
                 dr.GetDecimal("SLMUA"),
                 dr.GetString("SOGIUONG"),
                 dr.GetByte("TUOI"),
                 dr.GetSmartDate("NGAYSINH", true),
                 dr.GetBoolean("DUYET"),
                 dr.GetBoolean("PHAT"),
                 dr.GetInt32("STTKHOA"),
                 0,
                 dr.GetSmartDate("NgaykhamCuoi"),
                 dr.GetString("BSKham"),
                 dr.GetString("Tenbenh"),
             dr.GetSmartDate("TUNGAY", true),
             dr.GetSmartDate("DENNGAY", true),
             dr.GetDecimal("TONGKE"),
             dr.GetBoolean("KHOAD"),
             dr.GetSmartDate("NGAYKD", true),
             dr.GetString("NGUOIKD")
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
