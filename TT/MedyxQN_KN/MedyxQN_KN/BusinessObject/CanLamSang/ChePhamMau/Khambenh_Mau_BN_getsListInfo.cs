using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CanLamSang
{
    [Serializable()]
    public class Khambenh_Mau_BN_getsListInfo : BusinessListBase<Khambenh_Mau_BN_getsListInfo, Khambenh_Mau_BN_getsInfo>
    {
        #region Factory Methods
        public static Khambenh_Mau_BN_getsListInfo GetAllKhambenh_Mau_BN_gets(DateTime TuNgay, DateTime DenNgay ,Boolean Duyet, Boolean Phat, String  MaDT, String MaKho, String MAKHOA, Boolean dadung, String dk)
        {
            return DataPortal.Fetch<Khambenh_Mau_BN_getsListInfo>(new Criteria(TuNgay,DenNgay , Duyet , Phat , MaDT , MaKho , MAKHOA ,dadung,dk ));
        }
        public static Khambenh_Mau_BN_getsListInfo GetAllKhambenh_Mau_CT_gets(DateTime TuNgay, DateTime DenNgay, Boolean Duyet, Boolean Phat, String MaDT, String MaKho, String MAKHOA, Boolean dadung, String dk)
        {
            return DataPortal.Fetch<Khambenh_Mau_BN_getsListInfo>(new CriteriaOther(TuNgay, DenNgay, Duyet, Phat, MaDT, MaKho, MAKHOA, dadung, dk));
        }
        public static Khambenh_Mau_BN_getsListInfo NewKhambenh_Mau_BN_getsListInfo()
        {
            return new Khambenh_Mau_BN_getsListInfo();

        }
        public void RemoveTo(Khambenh_Mau_BN_getsInfo obj)
        {
            this.Items.Remove(obj);

        }
        private Khambenh_Mau_BN_getsListInfo()
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
                         _dk = mdk ;
                         _dadung = dadung;
            }
        }
        private class CriteriaOther
        {
            DateTime _TuNgay;
            DateTime _DenNgay;
            Boolean _Duyet;
            Boolean _Phat;
            String _MaDT;
            String _MaKho;
            String _MAKHOA;
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

            public CriteriaOther(DateTime mTuNgay, DateTime mDenNgay, Boolean mDuyet, Boolean mPhat, String mMaDT, String mMaKho, String mMAKHOA, Boolean dadung, String mdk)
            {
                _TuNgay = mTuNgay;
                _DenNgay = mDenNgay;
                _Duyet = mDuyet;
                _Phat = mPhat;
                _MaDT = mMaDT;
                _MaKho = mMaKho;
                _MAKHOA = mMAKHOA;
                _dk = mdk;
                _dadung = dadung;
            }
        }

        #endregion

        #region Authorization

        public static bool CanGetObject()
        {
            return true;
        }

        public static bool CanDeleteObject()
        {
            return true;
        }

        public static bool CanAddObject()
        {
            return true;
        }

        public static bool CanEditObject()
        {
            return true;
        }

        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhambenh_Mau_BN_gets(criteria.TuNgay, criteria.DenNgay, criteria.Duyet, criteria.Phat, criteria.MaDT, criteria.MaKho, criteria.MAKHOA, criteria.Dadung,criteria.dk)))
            {
               
                while (dr.Read())
                {
                    Khambenh_Mau_BN_getsInfo item = new Khambenh_Mau_BN_getsInfo(
             i, 
             dr.GetString("HOTEN") ,
			 dr.GetBoolean("GT") ,
			 dr.GetString("MABN") ,
			 dr.GetString("DIACHI") ,
              dr.GetString("MABA"),
			// dr.GetString("MASOKHAM") ,
			 dr.GetInt32("STT") ,
              dr.GetInt32("STTKhoa"),
			 dr.GetString("MADT") ,
			 dr.GetString("TENDT") ,
			 dr.GetSmartDate("NGAYDK", true) ,
              dr.GetSmartDate("TuNgay", true),
			 dr.GetString("TENTM") ,
			 dr.GetString("TENDVT") ,
			 dr.GetByte("TUOI") ,
			 dr.GetSmartDate("NGAYSINH", true) ,
			 dr.GetString("MaCPMau") ,
             dr.GetBoolean("DUYET"),
			 dr.GetBoolean("Phat") ,
			 dr.GetDecimal("DongiaTT"),
             dr.GetDecimal("Slmua"),
             0,
             dr.GetString("solo") ,
             dr.GetString("handung"),
             dr.GetString("nhommau"),
             dr.GetString("TenNhom"),
             dr.GetString("SoGiuong"),
             dr.GetString("SoPhong"),
             dr.GetString("ABOBN"),
             dr.GetString("ABOMau"),
             dr.GetString("RhDBN"),
             dr.GetString("HoaHopcheo1"),
             dr.GetString("HoaHopcheo2"),
             dr.GetString("HoaHoptieucau"),
             dr.GetString("Coombs"),
             dr.GetString("RhD"),
             dr.GetString("BSChiDinh")
			   
         );
                    this.Add(item);
                    i += 1;
                }
               
            }
           

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhambenh_Mau_CT_gets(criteria.TuNgay, criteria.DenNgay, criteria.Duyet, criteria.Phat, criteria.MaDT, criteria.MaKho, criteria.MAKHOA, criteria.Dadung, criteria.dk)))
            {

                while (dr.Read())
                {
                    Khambenh_Mau_BN_getsInfo item = new Khambenh_Mau_BN_getsInfo(
             i,
             dr.GetString("HOTEN"),
             dr.GetBoolean("GT"),
             dr.GetString("MABN"),
             dr.GetString("DIACHI"),
              dr.GetString("MABA"),
                        // dr.GetString("MASOKHAM") ,
             dr.GetInt32("STT"),
              dr.GetInt32("STTKhoa"),
             dr.GetString("MADT"),
             dr.GetString("TENDT"),
             dr.GetSmartDate("NGAYDK", true),
              dr.GetSmartDate("TuNgay", true),
             dr.GetString("TENTM"),
             dr.GetString("TENDVT"),
             dr.GetByte("TUOI"),
             dr.GetSmartDate("NGAYSINH", true),
             dr.GetString("MaCPMau"),
             dr.GetBoolean("DUYET"),
             dr.GetBoolean("Phat"),
             dr.GetDecimal("DongiaTT"),
             dr.GetDecimal("Slmua"),
             0,
             dr.GetString("solo"),
             dr.GetString("handung"),
             dr.GetString("nhommau"),
             dr.GetString("TenNhom"),
             dr.GetString("SoGiuong"),
             dr.GetString("SoPhong"),
             dr.GetString("ABOBN"),
             dr.GetString("ABOMau"),
             dr.GetString("RhDBN"),
             dr.GetString("HoaHopcheo1"),
             dr.GetString("HoaHopcheo2"),
             dr.GetString("HoaHoptieucau"),
             dr.GetString("Coombs"),
             dr.GetString("RhD"),
              dr.GetString("BSChiDinh")
         );
                    this.Add(item);
                    i += 1;
                }

            }


            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
 
        #endregion
    }
}
