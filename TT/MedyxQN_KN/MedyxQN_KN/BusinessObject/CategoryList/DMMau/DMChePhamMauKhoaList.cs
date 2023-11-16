using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMChePhamMauKhoaList : ReadOnlyListBase<DMChePhamMauKhoaList, DMChePhamMauKhoa>
    {
        #region Factory Methods
        public static DMChePhamMauKhoaList GetAllDMChePhamMauKhoa(String maKhoa, String maDT, byte loai)
        {
            return DataPortal.Fetch<DMChePhamMauKhoaList>(new Criteria(0,maKhoa, maDT, "",loai ));
        }
        public static DMChePhamMauKhoaList FindDMChePhamMauKhoaMa(String maKhoa, String maDT, String Ma, byte loai)
        {
            return DataPortal.Fetch<DMChePhamMauKhoaList>(new Criteria(1, maKhoa, maDT, Ma, loai));
        }
        public static DMChePhamMauKhoaList FindDMChePhamMauKhoaTen(String maKhoa, String maDT, String Ten, byte loai)
        {
            return DataPortal.Fetch<DMChePhamMauKhoaList>(new Criteria(2, maKhoa, maDT, Ten, loai));
        }
        public static DMChePhamMauKhoaList FindDMChePhamMauKhoaGoiMau(String maKhoa, String maDT, byte loai, string magoi)
        {
            return DataPortal.Fetch<DMChePhamMauKhoaList>(new OtherCriteria(11, maKhoa, maDT, magoi, loai));
        }
        private DMChePhamMauKhoaList()
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
                    _dK = " and a.MaCPMau like N'" + mDK + "%'";
                else if (mIdFind == 2)
                {
                    _dK = " AND A.TenCPMau + ' ' + isnull(A.HAMLUONG,'') + ' ' + isnull(P.TENDVT,'') ";
                    _dK = _dK + " Like N'" + mDK + "%'";
                }
            }


        }

        

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMChePhamMauKhoa(criteria.MaKhoa, criteria.MaDT , criteria.DK,criteria.Loai  )))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMChePhamMauKhoa item = DMChePhamMauKhoa.GetDMChePhamMauKhoa(dr, i);
                    //DMChePhamMauKhoa item = new DMChePhamMauKhoa(
                    //                        i,
                    //                        dr.GetString("MaCPMau") ,
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

                _dK = " and BT.MaGoiCPMau ='" + mDK + "'";

            }


        }




        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMChePhamMauKhoaBT(criteria.MaKhoa, criteria.MaDT, criteria.DK, criteria.Loai)))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMChePhamMauKhoa item = DMChePhamMauKhoa.GetDMChePhamMauKhoa(dr, i);
                    //DMChePhamMauKhoa item = newDMChePhamMauKhoa(
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
