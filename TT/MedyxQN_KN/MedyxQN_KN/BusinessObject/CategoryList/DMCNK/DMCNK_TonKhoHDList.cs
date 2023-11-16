using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMCNK_TonKhoHDList : ReadOnlyListBase<DMCNK_TonKhoHDList, DMCNK_TonKhoHD>
    {
        #region Business Methods

        #region State Fields
        public  byte _loai=0;
        #endregion
        #endregion
        #region Factory Methods

        public static DMCNK_TonKhoHDList GetAllDMCNKTonKho(String maKho, DateTime thang)
        {
            return DataPortal.Fetch<DMCNK_TonKhoHDList>(new Criteria(0, maKho, thang, "", ""));
        }
        public static DMCNK_TonKhoHDList FindDMCNKTonKhoMa(String maKho, DateTime thang, String Ma)
        {
         
            return DataPortal.Fetch<DMCNK_TonKhoHDList>(new Criteria(1, maKho, thang, Ma, ""));
        }
       
        public static DMCNK_TonKhoHDList FindDMCNKTonKhoTen(String maKho, DateTime thang, String Ten)
        {
            return DataPortal.Fetch<DMCNK_TonKhoHDList>(new Criteria(2, maKho, thang, Ten, ""));
        }
       
        public static DMCNK_TonKhoHDList FindDMCNKTonKhoTenD(String maKho, DateTime thang, String Ten)
        {
            return DataPortal.Fetch<DMCNK_TonKhoHDList>(new Criteria(3, maKho, thang, Ten, ""));
        }
        public static DMCNK_TonKhoHDList GetAllDMCNKTonKho(String maKho, DateTime thang, string MaKhoa)
        {
            return DataPortal.Fetch<DMCNK_TonKhoHDList>(new Criteria(0, maKho, thang, "", MaKhoa));
        }
        public static DMCNK_TonKhoHDList FindDMCNKTonKhoMa(String maKho, DateTime thang, String Ma, string MaKhoa)
        {
            return DataPortal.Fetch<DMCNK_TonKhoHDList>(new Criteria(1, maKho, thang, Ma, MaKhoa));
        }
        public static DMCNK_TonKhoHDList FindDMCNKTonKhoMaLoai(String maKho, DateTime thang, String Ma, string MaKhoa)
        {
           if ((MaKhoa == "05") || (MaKhoa == "03"))
                return DataPortal.Fetch<DMCNK_TonKhoHDList>(new Criteria(4, maKho, thang, Ma, HTC.ShareVariables.pub_sMakhoa ));
            else if (MaKhoa == "07")
                return DataPortal.Fetch<DMCNK_TonKhoHDList>(new Criteria(5, maKho, thang, Ma, HTC.ShareVariables.pub_sMakhoa));

            return DataPortal.Fetch<DMCNK_TonKhoHDList>(new Criteria(6, maKho, thang, Ma, HTC.ShareVariables.pub_sMakhoa));
           
        }
        public static DMCNK_TonKhoHDList FindDMCNKTonKhoMaLoaiVT(String maKho, DateTime thang, String Ma, string MaKhoa)
        {
            return DataPortal.Fetch<DMCNK_TonKhoHDList>(new Criteria(5, maKho, thang, Ma, MaKhoa));
        }
        public static DMCNK_TonKhoHDList FindDMCNKTonKhoMaLoaiHC(String maKho, DateTime thang, String Ma, string MaKhoa)
        {
            return DataPortal.Fetch<DMCNK_TonKhoHDList>(new Criteria(6, maKho, thang, Ma, MaKhoa));
        }
        public static DMCNK_TonKhoHDList FindDMCNKTonKhoTenLoai(String maKho, DateTime thang, String Ten, string MaKhoa)
        {
            
            if ((MaKhoa == "05") || (MaKhoa == "03"))
                return DataPortal.Fetch<DMCNK_TonKhoHDList>(new Criteria(7, maKho, thang, Ten, HTC.ShareVariables.pub_sMakhoa));
            else if (MaKhoa == "07")
                return DataPortal.Fetch<DMCNK_TonKhoHDList>(new Criteria(8, maKho, thang, Ten, HTC.ShareVariables.pub_sMakhoa));

            return DataPortal.Fetch<DMCNK_TonKhoHDList>(new Criteria(9, maKho, thang, Ten, HTC.ShareVariables.pub_sMakhoa));
        }
        public static DMCNK_TonKhoHDList FindDMCNKTonKhoTenLoaiThuoc(String maKho, DateTime thang, String Ten, string MaKhoa)
        {
            return DataPortal.Fetch<DMCNK_TonKhoHDList>(new Criteria(7, maKho, thang, Ten, MaKhoa));
        }
        public static DMCNK_TonKhoHDList FindDMCNKTonKhoTenLoaiHC(String maKho, DateTime thang, String Ten, string MaKhoa)
        {
            return DataPortal.Fetch<DMCNK_TonKhoHDList>(new Criteria(9, maKho, thang, Ten, MaKhoa));
        }
        public static DMCNK_TonKhoHDList FindDMCNKTonKhoTenD(String maKho, DateTime thang, String Ten, string MaKhoa)
        {
            return DataPortal.Fetch<DMCNK_TonKhoHDList>(new Criteria(3, maKho, thang, Ten, MaKhoa));
        }
        public static DMCNK_TonKhoHDList FindDMCNKTonKhoTen(String maKho, DateTime thang, String Ten, string MaKhoa)
        {
            return DataPortal.Fetch<DMCNK_TonKhoHDList>(new Criteria(2, maKho, thang, Ten, MaKhoa));
        }
        private DMCNK_TonKhoHDList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        protected class Criteria
        {
            private String _maKho;
            public String MaKho
            {
                get
                {
                    return _maKho;
                }
            }

            private DateTime _thang;
            public DateTime thang
            {
                get
                {
                    return _thang ;
                }
            }
          
            private String _dK;
            public String DK
            {
                get
                {
                    return _dK;
                }
            }
            private String _MaKhoa;
            public String MaKhoa
            {
                get
                {
                    return _MaKhoa;
                }
            }
            public Criteria(Byte mIdFind, String maKho, DateTime thang, String mDK, string MaKhoa)
            {
                _maKho = maKho;
                _thang = thang;
                _MaKhoa = MaKhoa;
               
                if (mIdFind == 1)
                   _dK = " and (a.MAvt like N'" + mDK + "%' or a.MAql like N'" + mDK + "%')";
                else if (mIdFind == 2)
                {
                    _dK = " and A.TENTM + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDV,'') like N'" + mDK + "%'";
                }
                else if (mIdFind == 3)
                {
                    _dK = " and A.TENTM  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDV,'') like N'" + mDK + "'";
                }
                else if (mIdFind == 4) 
                {
                    _dK = " AND A.MACHUNGLOAI ='00001' and (a.MAvt like N'" + mDK + "%' or a.MAql like N'" + mDK + "%')";
                }
                else if (mIdFind == 5)
                {
                    _dK = " AND A.MACHUNGLOAI ='00002' and (a.MAvt like N'" + mDK + "%' or a.MAql like N'" + mDK + "%')";
                }
                else if (mIdFind == 6)
                {
                    _dK = " AND A.MACHUNGLOAI ='00003' and (a.MAvt like N'" + mDK + "%' or a.MAql like N'" + mDK + "%')";
                }
                else if (mIdFind == 7)
                {
                    _dK = " and  A.MACHUNGLOAI ='00001'  A.TENTM + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDV,'') like N'" + mDK + "%'";
                }
                else if (mIdFind == 8)
                {
                    _dK = " and  A.MACHUNGLOAI ='00002'  A.TENTM + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDV,'') like N'" + mDK + "%'";
                }
                else if (mIdFind == 9)
                {
                    _dK = " AND A.MACHUNGLOAI ='00003'  A.TENTM + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDV,'') like N'" + mDK + "%'";
                }
            }


        }



        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMCNKTonKhoHD(criteria.MaKho , criteria.thang, criteria.DK,criteria.MaKhoa   )))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMCNK_TonKhoHD item = new DMCNK_TonKhoHD(
     i,
     dr.GetString("MaVT"),
     dr.GetString("TenTM"),
     dr.GetString("TenDVT"),
     dr.GetDecimal("TonCK"),
     dr.GetDecimal("TonCKDT"),
     dr.GetString("TenTA"),
     dr.GetBoolean("Handung"),
     dr.GetString("TenNSX"),
     dr.GetString("MaQL"),
     dr.GetDecimal("DonGiatt"),
     dr.GetDecimal("gianhap"),
     //dr.GetString("Tengoc"),
     dr.GetString("MaKhoa"),
     dr.GetDecimal("nguong")
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
