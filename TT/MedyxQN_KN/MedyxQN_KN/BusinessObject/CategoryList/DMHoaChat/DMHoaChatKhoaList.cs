using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMHoaChatKhoaList : ReadOnlyListBase<DMHoaChatKhoaList, DMHoaChatKhoa>
    {
        #region Factory Methods
        public static DMHoaChatKhoaList GetAllDMHoaChatKhoa(String maKhoa, String maDT, byte loai)
        {
            return DataPortal.Fetch<DMHoaChatKhoaList>(new Criteria(0,maKhoa, maDT, "",loai ));
        }
        public static DMHoaChatKhoaList GetAllDMHoaChatKhoaPT(String maKhoa, String maDT, byte loai)
        {
            return DataPortal.Fetch<DMHoaChatKhoaList>(new Criteria(10, maKhoa, maDT, "", loai));
        }
        public static DMHoaChatKhoaList FindDMHoaChatKhoaMa(String maKhoa, String maDT, String Ma, byte loai)
        {
            return DataPortal.Fetch<DMHoaChatKhoaList>(new Criteria(1, maKhoa, maDT, Ma, loai));
        }
        public static DMHoaChatKhoaList FindDMHoaChatKhoaTen(String maKhoa, String maDT, String Ten, byte loai)
        {
            return DataPortal.Fetch<DMHoaChatKhoaList>(new Criteria(2, maKhoa, maDT, Ten, loai));
        }
        public static DMHoaChatKhoaList FindDMHoaChatKhoaGoiHC(String maKhoa, String maDT, byte loai, string magoi)
        {
            return DataPortal.Fetch<DMHoaChatKhoaList>(new OtherCriteria(11, maKhoa, maDT, magoi, loai));
        }
        private DMHoaChatKhoaList()
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
                    _dK = " and a.MaHC like N'" + mDK + "%'";
                else if (mIdFind == 10)
                    _dK = "AND ISNULL(HCPHAUT,0) = 1 ";
                else if (mIdFind == 2)
                {
                    _dK = " AND A.TENTM + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                    _dK = _dK + " Like N'" + mDK + "%'";
                }
            }


        }

        

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMHoaChatKhoa(criteria.MaKhoa, criteria.MaDT , criteria.DK,criteria.Loai  )))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMHoaChatKhoa item = DMHoaChatKhoa.GetDMHoaChatKhoa(dr, i);
                    //DMHoaChatKhoa item = new DMHoaChatKhoa(
                    //                        i,
                    //                        dr.GetString("MaHC") ,
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

                _dK = " and BT.magoihc ='" + mDK + "'";

            }


        }




        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMHoaChatKhoaBT(criteria.MaKhoa, criteria.MaDT, criteria.DK, criteria.Loai)))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                   DMHoaChatKhoa item =DMHoaChatKhoa.GetDMHoaChatKhoa(dr, i);
                    //DMHoaChatKhoa item = newDMHoaChatKhoa(
                    //                        i,
                    //                        dr.GetString("MaThuoc") ,
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
        #endregion

    }
}
