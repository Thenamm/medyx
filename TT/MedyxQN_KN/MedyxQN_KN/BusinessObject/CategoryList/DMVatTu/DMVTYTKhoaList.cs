using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMVTYTKhoaList : ReadOnlyListBase<DMVTYTKhoaList, DMVTYTKhoa>
    {
        #region Factory Methods
        public static DMVTYTKhoaList GetAllDMVTYTKhoa(String maKhoa, String maDT, byte loai)
        {
            return DataPortal.Fetch<DMVTYTKhoaList>(new Criteria(0,maKhoa, maDT, "",loai ));
        }
        public static DMVTYTKhoaList GetAllDMVTYTKhoaG(String maKhoa, String maDT, byte loai)
        {
            return DataPortal.Fetch<DMVTYTKhoaList>(new CriteriaOther(10, maKhoa, maDT, "", loai));
        }
        public static DMVTYTKhoaList GetAllDMVTYTKhoaPT(String maKhoa, String maDT, byte loai)
        {
            return DataPortal.Fetch<DMVTYTKhoaList>(new Criteria(10, maKhoa, maDT, "", loai));
        }
        public static DMVTYTKhoaList GetAllDMVTYTKhoaTT(String maKhoa, String maDT, byte loai)
        {
            return DataPortal.Fetch<DMVTYTKhoaList>(new Criteria(12, maKhoa, maDT, "", loai));
        }
        public static DMVTYTKhoaList GetAllDMVTYTKhoaHC(String maKhoa, String maDT, byte loai)
        {
            return DataPortal.Fetch<DMVTYTKhoaList>(new Criteria(11, maKhoa, maDT, "", loai));
        }
        public static DMVTYTKhoaList FindDMVTYTKhoaMa(String maKhoa, String maDT, String Ma, byte loai)
        {
            return DataPortal.Fetch<DMVTYTKhoaList>(new Criteria(1, maKhoa, maDT, Ma, loai));
        }
        public static DMVTYTKhoaList FindDMVTYTKhoaTen(String maKhoa, String maDT, String Ten, byte loai)
        {
            return DataPortal.Fetch<DMVTYTKhoaList>(new Criteria(2, maKhoa, maDT, Ten, loai));
        }
        public static DMVTYTKhoaList FindDMVTYTKhoaTenD(String maKhoa, String maDT, String Ten, byte loai)
        {
            return DataPortal.Fetch<DMVTYTKhoaList>(new Criteria(3, maKhoa, maDT, Ten, loai));
        }
        public static DMVTYTKhoaList FindDMVTYTKhoaGoiVT(String maKhoa, String maDT, byte loai, string magoi)
        {
            return DataPortal.Fetch<DMVTYTKhoaList>(new OtherCriteria(11, maKhoa, maDT, magoi, loai));
        }
        private DMVTYTKhoaList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        protected class Criteria
        {
            private String _maKhoa;
            public String MaKhoa
            {
                get
                {
                    return _maKhoa;
                }
            }
            private Byte _Loai;
            public Byte Loai
            {
                get
                {
                    return _Loai;
                }
            }
            private String _maDT;
            public String MaDT
            {
                get
                {
                    return _maDT;
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
            public Criteria(Byte mIdFind, String maKhoa, String maDT, String mDK,   byte Loai)
            {
                _maKhoa = maKhoa;
                _maDT = maDT;
                _Loai = Loai;
                if (mIdFind == 1)
                    _dK = " and (a.MAvt like N'" + mDK + "%' or a.MAql like N'" + mDK + "%')";
                else if (mIdFind == 10)
                    _dK = "AND ISNULL(VTPHAUT,0) = 1 ";
                else if (mIdFind == 12)
                    _dK = "AND ISNULL(VTThuT,0) = 1 ";

                else if (mIdFind == 2)
                {
                    _dK = " AND A.TENTM + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                    _dK = _dK + " Like N'" + mDK + "%'";
                }
                else if (mIdFind == 3)
                {
                    _dK = " AND A.TENTM + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                    _dK = _dK + " Like N'" + mDK + "'";
                }
            }


        }

        

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMVTYTKhoa(criteria.MaKhoa, criteria.MaDT , criteria.DK,criteria.Loai  )))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMVTYTKhoa item = DMVTYTKhoa.GetDMVTYTKhoa(dr, i);
                    //DMVTYTKhoa item = new DMVTYTKhoa(
                    //                        i,
                    //                        dr.GetString("MaVT") ,
                    //                        dr.GetString("TenTM") ,
                    //                        dr.GetString("TenDVT") ,
                    //                        dr.GetInt32("TonCK") ,
                    //                        dr.GetInt32("TonCKDT") ,
                    //                        dr.GetString("TenTA") ,
                    //                        dr.GetString("Tengoc") ,
                    //                        dr.GetInt32("NgaydungToida") ,
                    //                        dr.GetBoolean("HanDung") ,
                    //                        dr.GetString("TenNSX") ,
                    //                        dr.GetBoolean("ApdungGoi") ,
                    //                        dr.GetBoolean("DTBH") ,
                    //                        dr.GetBoolean("ADChenhLech") ,
                    //                        dr.GetDecimal("DonGiatt") ,
                    //                        dr.GetDecimal("DonGiaBH") ,
                    //                        dr.GetDecimal("GiaChenhLech"),
                    //                        dr.GetBoolean("ThuocThuT") ,
                    //                        dr.GetBoolean("ThuocphauT") ,
                    //                        dr.GetBoolean("ThuocCLS"),
                    //                        dr.GetBoolean("adphongmo")
                    //                            );
                    this.Add(item);
                    i += 1;
                }
                IsReadOnly = true;
            }            
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        protected class CriteriaOther
        {
            private String _maKhoa;
            public String MaKhoa
            {
                get
                {
                    return _maKhoa;
                }
            }
            private Byte _Loai;
            public Byte Loai
            {
                get
                {
                    return _Loai;
                }
            }
            private String _maDT;
            public String MaDT
            {
                get
                {
                    return _maDT;
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
            public CriteriaOther(Byte mIdFind, String maKhoa, String maDT, String mDK, byte Loai)
            {
                _maKhoa = maKhoa;
                _maDT = maDT;
                _Loai = Loai;
                if (mIdFind == 1)
                    _dK = " and (a.MAvt like N'" + mDK + "%' or a.MAql like N'" + mDK + "%')";
                
                else if (mIdFind == 2)
                {
                    _dK = " AND A.TENTM + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                    _dK = _dK + " Like N'" + mDK + "%'";
                }
                else if (mIdFind == 3)
                {
                    _dK = " AND A.TENTM + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                    _dK = _dK + " Like N'" + mDK + "'";
                }
            }


        }



        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMVTYTKhoaG(criteria.MaKhoa, criteria.MaDT, criteria.DK, criteria.Loai)))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMVTYTKhoa item = DMVTYTKhoa.GetDMVTYTKhoa(dr, i);
                    //DMVTYTKhoa item = new DMVTYTKhoa(
                    //                        i,
                    //                        dr.GetString("MaVT") ,
                    //                        dr.GetString("TenTM") ,
                    //                        dr.GetString("TenDVT") ,
                    //                        dr.GetInt32("TonCK") ,
                    //                        dr.GetInt32("TonCKDT") ,
                    //                        dr.GetString("TenTA") ,
                    //                        dr.GetString("Tengoc") ,
                    //                        dr.GetInt32("NgaydungToida") ,
                    //                        dr.GetBoolean("HanDung") ,
                    //                        dr.GetString("TenNSX") ,
                    //                        dr.GetBoolean("ApdungGoi") ,
                    //                        dr.GetBoolean("DTBH") ,
                    //                        dr.GetBoolean("ADChenhLech") ,
                    //                        dr.GetDecimal("DonGiatt") ,
                    //                        dr.GetDecimal("DonGiaBH") ,
                    //                        dr.GetDecimal("GiaChenhLech"),
                    //                        dr.GetBoolean("ThuocThuT") ,
                    //                        dr.GetBoolean("ThuocphauT") ,
                    //                        dr.GetBoolean("ThuocCLS"),
                    //                        dr.GetBoolean("adphongmo")
                    //                            );
                    this.Add(item);
                    i += 1;
                }
                IsReadOnly = true;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        protected class OtherCriteria
        {
            private String _maKhoa;
            public String MaKhoa
            {
                get
                {
                    return _maKhoa;
                }
            }
            private Byte _Loai;
            public Byte Loai
            {
                get
                {
                    return _Loai;
                }
            }
            private String _maDT;
            public String MaDT
            {
                get
                {
                    return _maDT;
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
            public OtherCriteria(Byte mIdFind, String maKhoa, String maDT, String mDK, byte Loai)
            {
                _maKhoa = maKhoa;
                _maDT = maDT;
                _Loai = Loai;

                _dK = " and BT.magoivt ='" + mDK + "'";

            }


        }




        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMVTYTKhoaBT(criteria.MaKhoa, criteria.MaDT, criteria.DK, criteria.Loai)))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMVTYTKhoa item = DMVTYTKhoa.GetDMVTYTKhoa(dr, i);
                  
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
