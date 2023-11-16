using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.Duoc
{
    [Serializable()]
    public class Khambenh_ThuocSD_BN_getsListInfo : ReadOnlyListBase<Khambenh_ThuocSD_BN_getsListInfo, Khambenh_ThuocSD_BN_getsInfo>
    {
        #region Factory Methods
        public static Khambenh_ThuocSD_BN_getsListInfo NewTo()
        {
            return DataPortal.Fetch<Khambenh_ThuocSD_BN_getsListInfo>(new CriteriaNew());
        }
        public static Khambenh_ThuocSD_BN_getsListInfo GetAllKhambenh_ThuocSD_BN_gets(DateTime TuNgay, DateTime DenNgay ,Boolean Duyet, Boolean Phat, String  MaDT, String MaKho, String MAKHOA, Boolean dadung, String dk)
        {
            return DataPortal.Fetch<Khambenh_ThuocSD_BN_getsListInfo>(new Criteria(TuNgay,DenNgay , Duyet , Phat , MaDT , MaKho , MAKHOA ,dadung,dk ));
        }
        public static Khambenh_ThuocSD_BN_getsListInfo GetAllKhambenh_ThuocSD_BN_List(DateTime TuNgay, DateTime DenNgay, Boolean Duyet, Boolean Phat, String MaDT, String MaKho, String MAKHOA, Boolean dadung, String dk)
        // LAY DANH SACH BENHNHAN
        {
            return DataPortal.Fetch<Khambenh_ThuocSD_BN_getsListInfo>(new OtherCriteria(TuNgay, DenNgay, Duyet, Phat, MaDT, MaKho, MAKHOA, dadung, dk));
        }

        public static Khambenh_ThuocSD_BN_getsListInfo GetAllKhambenh_ThuocSD_BNNOITRU_List(DateTime TuNgay, DateTime DenNgay, Boolean Duyet, Boolean Phat, String MaDT, String MaKho, String MAKHOA, Boolean dadung)
        // LAY DANH SACH BENHNHAN
        {
            return DataPortal.Fetch<Khambenh_ThuocSD_BN_getsListInfo>(new Criteria(TuNgay, DenNgay, Duyet, Phat, MaDT, MaKho, MAKHOA, dadung, "3"));
        }

        public static Khambenh_ThuocSD_BN_getsListInfo GetAllKhambenh_ThuocSD_BNNOITRU_gets(DateTime TuNgay, DateTime DenNgay, Boolean Duyet, Boolean Phat, String MaDT, String MaKho, String MAKHOA, Boolean dadung)
        // KHOA DUYET
        {
            return DataPortal.Fetch<Khambenh_ThuocSD_BN_getsListInfo>(new Criteria(TuNgay, DenNgay, Duyet, Phat, MaDT, MaKho, MAKHOA, dadung, "2"));
        }
        //public static Khambenh_ThuocSD_BN_getsListInfo GetAllKhambenh_ThuocSD_BYMASOKHAM(DateTime TuNgay, DateTime DenNgay, Boolean Duyet, Boolean Phat, String MaDT, String MaKho, String MAKHOA, Boolean dadung,String DK,Boolean NOIDUYET)
        //// load thuoc theo masokham
        //{
        //    return DataPortal.Fetch<Khambenh_ThuocSD_BN_getsListInfo>(new Criteria(TuNgay, DenNgay, Duyet, Phat, MaDT, MaKho, MAKHOA, dadung, "2"));
        //}
        public void AssignTo(Khambenh_ThuocSD_BN_getsInfo _Khambenh_ThuocSD_BN_getsInfo)
        {

            _Khambenh_ThuocSD_BN_getsInfo.OrderNumber = this.Items.Count + 1;
            this.Items.Add(_Khambenh_ThuocSD_BN_getsInfo);
        }
        private Khambenh_ThuocSD_BN_getsListInfo()
        {  /* Require use of factory methods */ }

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

        #region CriteriaNew
        [Serializable()]
        private class CriteriaNew
        {

        }
        private void DataPortal_Fetch(CriteriaNew criteria)
        {


            
        }
        #endregion
        #region OtherCriteria
        [Serializable()]
        private class OtherCriteria
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
          
            public OtherCriteria(DateTime mTuNgay, DateTime mDenNgay, Boolean mDuyet, Boolean mPhat, String mMaDT, String mMaKho, String mMAKHOA, Boolean dadung, String mdk)
            {
                _TuNgay = mTuNgay;
                _DenNgay = mDenNgay;
                _Duyet = mDuyet;
                _Phat = mPhat;
                _MaDT = mMaDT;
                _MaKho = mMaKho;
                _MAKHOA = mMAKHOA;
                _dadung = dadung;
                _dk = mdk;
                
            }
        }

        #endregion

       

       private void DataPortal_Fetch(Criteria criteria)
        {
            int i = 1;
            
            RaiseListChangedEvents = false;
           
            if (criteria.dk == "2")// NOITRU DUYET
           {
               using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhambenh_ThuocSD_BNNOITRU_gets(criteria.TuNgay, criteria.DenNgay, criteria.Duyet, criteria.Phat, criteria.MaDT, criteria.MaKho, criteria.MAKHOA, criteria.Dadung, criteria.dk)))
               {
                   IsReadOnly = false;
                   while (dr.Read())
                   {
                       Khambenh_ThuocSD_BN_getsInfo item = new Khambenh_ThuocSD_BN_getsInfo(
             i,
             dr.GetString("HOTEN"),
             dr.GetBoolean("GT"),
             dr.GetString("MABN"),
             dr.GetString("DIACHI"),
             dr.GetString("MASOKHAM"),
             dr.GetInt32("STT"),
             dr.GetInt32("STTKhoa"),
             dr.GetString("MADT"),
             dr.GetString("TENDT"),
             dr.GetSmartDate("NGAYDK", true),
             dr.GetString("TENTM"),
             dr.GetString("TENDVT"),
             dr.GetByte("TUOI"),
             dr.GetSmartDate("NGAYSINH", true),
             dr.GetString("MATHUOC"),
             dr.GetBoolean("DUYET"),
             dr.GetBoolean("Phat"),
             dr.GetDecimal("DongiaTT"),
             dr.GetDecimal("Slmua"),
             0,
             dr.GetSmartDate("NgaykhamCuoi"),
             dr.GetString("BSKham"),
             dr.GetString("Tenbenh")
            , dr.GetSmartDate("TUNGAY", true),
             dr.GetSmartDate("DENNGAY", true),
             dr.GetDecimal("TONGKE"),
             dr.GetBoolean("KHOAD"),
             dr.GetSmartDate("NGAYKD", true),
             dr.GetString("NGUOIKD")
             , dr.GetDecimal("Quydoi")
             , dr.GetInt32("STT")
             , dr.GetDecimal("OrderNgay"),
             dr.GetInt32("Thuoctieuhao"),
             0,
             dr.GetString("kt")
         );
                       this.Add(item);
                       i += 1;
                   }
                   IsReadOnly = true;
               }
           }
           else if (criteria.dk == "3")// DSBN NOITRU DUYET
           {
               using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhambenh_ThuocSD_BNNOITRU_List(criteria.TuNgay, criteria.DenNgay, criteria.Duyet, criteria.Phat, criteria.MaDT, criteria.MaKho, criteria.MAKHOA, criteria.Dadung)))
               {
                   IsReadOnly = false;
                   while (dr.Read())
                   {
                       
                       Khambenh_ThuocSD_BN_getsInfo item = new Khambenh_ThuocSD_BN_getsInfo(
                i,
             dr.GetString("HOTEN"),
             dr.GetBoolean("GT"),
             dr.GetString("MABN"),
             dr.GetString("DIACHI"),
             dr.GetString("MASOKHAM"),
             dr.GetInt32("STT"),
             dr.GetInt32("STTKhoa"),
             dr.GetString("MADT"),
             dr.GetString("TENDT"),
             dr.GetSmartDate("NGAYDK", true),
             dr.GetString("TENTM"),
             dr.GetString("TENDVT"),
             dr.GetByte("TUOI"),
             dr.GetSmartDate("NGAYSINH", true),
             dr.GetString("MATHUOC"),
             dr.GetBoolean("DUYET"),
             dr.GetBoolean("Phat"),
             dr.GetDecimal("DongiaTT"),
             dr.GetDecimal("Slmua"),
             0,
             dr.GetSmartDate("NgaykhamCuoi"),
             dr.GetString("BSKham"),
             dr.GetString("Tenbenh")
            , dr.GetSmartDate("TUNGAY", true),
             dr.GetSmartDate("DENNGAY", true),
             dr.GetDecimal("TONGKE"),
             dr.GetBoolean("KHOAD"),
             dr.GetSmartDate("NGAYKD", true),
             dr.GetString("NGUOIKD")
            ,dr.GetDecimal ("Quydoi")
            , dr.GetInt32("STT")
             , dr.GetDecimal("OrderNgay"),
             dr.GetInt32("Thuoctieuhao"),
             0,
             dr.GetString("kt")
            );
                       this.Add(item);
                       i += 1;
                   }
                   IsReadOnly = true;
               }
           }
           else
           {
               using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhambenh_ThuocSD_BN_gets(criteria.TuNgay, criteria.DenNgay, criteria.Duyet, criteria.Phat, criteria.MaDT, criteria.MaKho, criteria.MAKHOA, criteria.Dadung, criteria.dk)))

               //  using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhambenh_ThuocSD_BN_List(criteria.TuNgay, criteria.DenNgay, criteria.Duyet, criteria.Phat, criteria.MaDT, criteria.MaKho, criteria.MAKHOA, criteria.Dadung)))
               {
                   IsReadOnly = false;
                    i = 1;
                 
                   //IsReadOnly = false;
               int j = 1;
                string bn = "";
                //IsReadOnly = false;
                while (dr.Read())
                {
                    
                    if (bn == "")
                        bn = dr.GetString ("MABN");
                    else if (bn != dr.GetString("MABN"))
                    {
                        bn = dr.GetString("MABN");
                        j += 1;
                    }
                
                     
                       Khambenh_ThuocSD_BN_getsInfo item = new Khambenh_ThuocSD_BN_getsInfo(
                i,
                dr.GetString("HOTEN"),
                dr.GetBoolean("GT"),
                dr.GetString("MABN"),
                dr.GetString("DIACHI"),
                dr.GetString("MASOKHAM"),
                dr.GetInt32("STT"),
                dr.GetInt32("STTKhoa"),
                dr.GetString("MADT"),
                dr.GetString("TENDT"),
                dr.GetSmartDate("NGAYDK", true),
                dr.GetString("TENTM"),
                dr.GetString("TENDVT"),
                dr.GetByte("TUOI"),
                dr.GetSmartDate("NGAYSINH", true),
                dr.GetString("MATHUOC"),
                dr.GetBoolean("DUYET"),
                dr.GetBoolean("Phat"),
                dr.GetDecimal("DongiaTT"),
                dr.GetDecimal("Slmua"),
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
               , dr.GetDecimal ("Quydoi")
               , dr.GetInt32("STT")
                , dr.GetDecimal("OrderNgay"),
                dr.GetInt32("Thuoctieuhao"),
                j,
             dr.GetString("kt")
            );
                       this.Add(item);
                       i += 1;
                   }
                   IsReadOnly = true;
               }
           }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhambenh_ThuocSD_BN_List(criteria.TuNgay, criteria.DenNgay, criteria.Duyet, criteria.Phat, criteria.MaDT, criteria.MaKho, criteria.MAKHOA, criteria.Dadung, criteria.dk )))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    Khambenh_ThuocSD_BN_getsInfo item = new Khambenh_ThuocSD_BN_getsInfo(
                i,
                dr.GetString("HOTEN"),
                dr.GetBoolean("GT"),
                dr.GetString("MABN"),
                dr.GetString("DIACHI"),
                dr.GetString("MASOKHAM"),
                dr.GetInt32("STT"),
                dr.GetInt32("STTKhoa"),
                dr.GetString("MADT"),
                dr.GetString("TENDT"),
                dr.GetSmartDate("NGAYDK", true),
                dr.GetString("TENTM"),
                dr.GetString("TENDVT"),
                dr.GetByte("TUOI"),
                dr.GetSmartDate("NGAYSINH", true),
                dr.GetString("MATHUOC"),
                dr.GetBoolean("DUYET"),
                dr.GetBoolean("Phat"),
                dr.GetDecimal("DongiaTT"),
                dr.GetDecimal("Slmua"),
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
                , 1
                , dr.GetInt32("STT")
                , dr.GetDecimal("OrderNgay"),
                dr.GetInt32("Thuoctieuhao"),
                0,
             dr.GetString("kt")
            );

                    this.Add(item);
                    i += 1;
                }
                //IsReadOnly = true;
            }


            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
      
       
        #endregion
    }
}
