using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMThuocKhoaList : ReadOnlyListBase<DMThuocKhoaList, DMThuocKhoa>
    {
        #region Factory Methods
        public static DMThuocKhoaList GetAllDMThuocKhoa(String maKhoa, String maDT, byte loai)
        {
            return DataPortal.Fetch<DMThuocKhoaList>(new Criteria(0,maKhoa, maDT, "",loai ));
        }
        public static DMThuocKhoaList FindDMThuocKhoaG(String maKhoa, String maDT, byte loai)
        {
            return DataPortal.Fetch<DMThuocKhoaList>(new CriteriaOther(10, maKhoa, maDT, "", loai));
        }

        public static DMThuocKhoaList FindDMThuocKhoaBThuoc(String maKhoa, String maDT, byte loai,string mabthuoc)
        {
            return DataPortal.Fetch<DMThuocKhoaList>(new OtherCriteria(11, maKhoa, maDT, mabthuoc, loai));
        }
        public static DMThuocKhoaList FindDMThuocKhoaPT(String maKhoa, String maDT, byte loai)
        {
            return DataPortal.Fetch<DMThuocKhoaList>(new CriteriaOther(10, maKhoa, maDT, "", loai));
        }
        public static DMThuocKhoaList FindDMThuocKhoaTT(String maKhoa, String maDT, byte loai)
        {
            return DataPortal.Fetch<DMThuocKhoaList>(new CriteriaOther(12, maKhoa, maDT, "", loai));
        }
        public static DMThuocKhoaList FindDMThuocKhoaHC(String maKhoa, String maDT, byte loai)
        {
            return DataPortal.Fetch<DMThuocKhoaList>(new Criteria(11, maKhoa, maDT, "", loai));
        }
        public static DMThuocKhoaList FindDMThuocKhoaMa(String maKhoa, String maDT, String Ma, byte loai)
        {
            return DataPortal.Fetch<DMThuocKhoaList>(new Criteria(1, maKhoa, maDT, Ma, loai));
        }
        public static DMThuocKhoaList FindDMThuocKhoaMaSoKhamDY(String maKhoa, String maDT, String Ma, byte loai)
        {
            return DataPortal.Fetch<DMThuocKhoaList>(new OtCriteria(13, maKhoa, maDT, Ma, loai));
        }
        public static DMThuocKhoaList FindDMThuocKhoaMaSoKhamDY(String maKhoa, String maDT, String Ma, byte loai,string dk)
        {
            return DataPortal.Fetch<DMThuocKhoaList>(new OtCriteria(15, maKhoa, maDT, Ma+dk, loai));
        }
        public static DMThuocKhoaList FindDMThuocKhoaMaSoKhamTY(String maKhoa, String maDT, String Ma, byte loai)
        {
            return DataPortal.Fetch<DMThuocKhoaList>(new OtCriteria(14, maKhoa, maDT, Ma, loai));
        }
        public static DMThuocKhoaList FindDMThuocKhoaTen(String maKhoa, String maDT, String Ten, byte loai)
        {
            return DataPortal.Fetch<DMThuocKhoaList>(new Criteria(2, maKhoa, maDT, Ten, loai));
        }
        public static DMThuocKhoaList FindDMThuocKhoaTenD(String maKhoa, String maDT, String Ten, byte loai)
        {
            return DataPortal.Fetch<DMThuocKhoaList>(new Criteria(3, maKhoa, maDT, Ten, loai));
        }
        public static DMThuocKhoaList FindDMThuocKhoaMaTY(String maKhoa, String maDT, String Ma, byte loai)
        {
            return DataPortal.Fetch<DMThuocKhoaList>(new Criteria(4, maKhoa, maDT, Ma, loai));
        }
        public static DMThuocKhoaList FindDMThuocKhoaMaTYD(String maKhoa, String maDT, String Ma, byte loai)
        {
            return DataPortal.Fetch<DMThuocKhoaList>(new Criteria(14, maKhoa, maDT, Ma, loai));
        }
        public static DMThuocKhoaList FindDMThuocKhoaTenTY(String maKhoa, String maDT, String Ten, byte loai)
        {
            return DataPortal.Fetch<DMThuocKhoaList>(new Criteria(5, maKhoa, maDT, Ten, loai));
        }
        public static DMThuocKhoaList FindDMThuocKhoaTenDTY(String maKhoa, String maDT, String Ten, byte loai)
        {
            return DataPortal.Fetch<DMThuocKhoaList>(new Criteria(6, maKhoa, maDT, Ten, loai));
        }
        public static DMThuocKhoaList FindDMThuocKhoaMaDY(String maKhoa, String maDT, String Ma, byte loai)
        {
            return DataPortal.Fetch<DMThuocKhoaList>(new Criteria(7, maKhoa, maDT, Ma, loai));
        }
        public static DMThuocKhoaList FindDMThuocKhoaMaDYD(String maKhoa, String maDT, String Ma, byte loai)
        {
            return DataPortal.Fetch<DMThuocKhoaList>(new Criteria(15, maKhoa, maDT, Ma, loai));
        }
        public static DMThuocKhoaList FindDMThuocKhoaTenDY(String maKhoa, String maDT, String Ten, byte loai)
        {
            return DataPortal.Fetch<DMThuocKhoaList>(new Criteria(8, maKhoa, maDT, Ten, loai));
        }
        public static DMThuocKhoaList FindDMThuocKhoaTenDDY(String maKhoa, String maDT, String Ten, byte loai)
        {
            return DataPortal.Fetch<DMThuocKhoaList>(new Criteria(9, maKhoa, maDT, Ten, loai));
        }
        private DMThuocKhoaList()
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
                if ((mIdFind == 1)||(mIdFind == 4)||(mIdFind == 7))
                    _dK = " and (a.MAthuoc like N'" + mDK + "%' or a.MAql like N'" + mDK + "%')";
                if ((mIdFind == 14) || (mIdFind == 15) )
                    _dK = " and (a.MAthuoc like N'" + mDK + "' or a.MAql like N'" + mDK + "')";
               
                if ((mIdFind == 10))
                    _dK = " and  isnull(a.thuocphaut,0) =1";
                else if ((mIdFind == 12))
                    _dK = " and  isnull(a.thuocthut,0) =1";
                else if ((mIdFind == 13))
                    _dK = " and  isnull(a.mathuoc,'') in (select b.mathuoc from khambenh_thuocsd_dy a inner join khambenh_thuocsd_dyc b on a.masokham = b.masokham and a.stt = b.stt where a.huy =0 and a.slmua <> 0 and  b.stt=1 and b.masokham ='" + mDK + "')";
                else if ((mIdFind == 14))
                    _dK = " and  isnull(a.mathuoc,'') in (select a.mathuoc from khambenh_thuocsd a where huy =0 and slmua <> 0 and masokham ='" + mDK + "')";
                else if ((mIdFind == 11))
                    _dK = " and  isnull(a.thuochoichan,0) =1";
                else if ((mIdFind == 2)||(mIdFind == 5)||(mIdFind == 8))
                {
                    _dK = " AND ((A.TENTM  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                    _dK = _dK + " Like N'" + mDK + "%')";
                    _dK = _dK + " or ( A.TENTM1  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                    _dK = _dK + " Like N'" + mDK + "%')";
                    _dK = _dK + " or ( A.TENTM2  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                    _dK = _dK + " Like N'" + mDK + "%')) ";
                }
                else if ((mIdFind == 3)||(mIdFind == 6)||(mIdFind == 9))
                {
                    _dK = " AND A.TENTM + CASE WHEN ISNULL(TENTM1,'') <>'' THEN '('+ TENTM1 +')' else '' END";
                    _dK = _dK + " + CASE WHEN ISNULL(TENTM2,'') <>'' THEN '('+ TENTM2 +')' else '' END + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                    _dK = _dK + " Like N'" + mDK + "'";
                }
                if ((mIdFind == 4) || (mIdFind == 14) || (mIdFind == 5) || (mIdFind == 6))
                        _dK = _dK + " and a.machungloai NOT in ('00019')";
                    else if ((mIdFind == 7) || (mIdFind == 15) || (mIdFind == 8) || (mIdFind == 9))
                        _dK = _dK + " and a.machungloai in ('00019')";
                    
            }
          

        }

        

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMThuocKhoa(criteria.MaKhoa, criteria.MaDT , criteria.DK,criteria.Loai  )))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMThuocKhoa item = DMThuocKhoa.GetDMThuocKhoa(dr, i);
                    //DMThuocKhoa item = new DMThuocKhoa(
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

        protected class OtCriteria
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
            public OtCriteria(Byte mIdFind, String maKhoa, String maDT, String mDK, byte Loai)
            {
                _maKhoa = maKhoa;
                _maDT = maDT;
                _Loai = Loai;
                if ((mIdFind == 1) || (mIdFind == 4) || (mIdFind == 7))
                    _dK = " and (a.MAthuoc like N'" + mDK + "%' or a.MAql like N'" + mDK + "%')";
                if ((mIdFind == 10))
                    _dK = " and  isnull(a.thuocphaut,0) =1";
                else if ((mIdFind == 12))
                    _dK = " and  isnull(a.thuocthut,0) =1";
                else if ((mIdFind == 13))
                    _dK = " and  isnull(A.machungloai,'') in ('00019') and aa.huy =0 and aAA.huy =0 and (aaa.slmua - isnull(aaa.sltra,0))<> 0 and  aaa.stt= (select top 1 stt from khambenh_thuocsd_dy b where b.masokham = aaa.masokham and b.huy =0) and AAA.masokham ='" + mDK + "'";
                else if ((mIdFind == 15))
                    _dK = " and  isnull(A.machungloai,'') in ('00019') and aa.huy =0 and aAA.huy =0 and (aaa.slmua - isnull(aaa.sltra,0))<> 0 and  aaa.stt=" + mDK.Substring(mDK.Length - 1, 1) + " and AAA.masokham ='" + mDK.Substring(0, mDK.Length - 1) + "'";
                else if ((mIdFind == 14))
                    _dK = " and  isnull(A.machungloai,'') not in ('00019') and aAA.huy =0  and aAA.slmua <> 0 and AAA.masokham ='" + mDK + "'";
                else if ((mIdFind == 11))
                    _dK = " and  isnull(a.thuochoichan,0) =1";
                else if ((mIdFind == 2) || (mIdFind == 5) || (mIdFind == 8))
                {
                    _dK = " AND A.TENTM + CASE WHEN ISNULL(TENTM1,'') <>'' THEN '('+ TENTM1 +')' else '' END";
                    _dK = _dK + " + CASE WHEN ISNULL(TENTM2,'') <>'' THEN '('+ TENTM2 +')' else '' END + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                    _dK = _dK + " Like N'" + mDK + "%'";
                }
                else if ((mIdFind == 3) || (mIdFind == 6) || (mIdFind == 9))
                {
                    _dK = " AND A.TENTM + CASE WHEN ISNULL(TENTM1,'') <>'' THEN '('+ TENTM1 +')' else '' END";
                    _dK = _dK + " + CASE WHEN ISNULL(TENTM2,'') <>'' THEN '('+ TENTM2 +')' else '' END + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                    _dK = _dK + " Like N'" + mDK + "'";
                }
                if ((mIdFind == 4) || (mIdFind == 5) || (mIdFind == 6))
                    _dK = _dK + " and a.machungloai NOT in ('00019')";
                else if ((mIdFind == 7) || (mIdFind == 8) || (mIdFind == 9))
                    _dK = _dK + " and a.machungloai in ('00019')";
                
            }


        }



        private void DataPortal_Fetch(OtCriteria OtCriteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMThuocKhoaMaSoKham(OtCriteria.MaKhoa, OtCriteria.MaDT, OtCriteria.DK, OtCriteria.Loai)))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMThuocKhoa item = DMThuocKhoa.GetDMThuocKhoa(dr, i);
                    //DMThuocKhoa item = new DMThuocKhoa(
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
                if ((mIdFind == 1) || (mIdFind == 4) || (mIdFind == 7))
                    _dK = " and (a.MAthuoc like N'" + mDK + "%' or a.MAql like N'" + mDK + "%')";
                else if ((mIdFind == 2) || (mIdFind == 5) || (mIdFind == 8))
                {
                    _dK = " AND A.TENTM + CASE WHEN ISNULL(TENTM1,'') <>'' THEN '('+ TENTM1 +')' else '' END";
                    _dK = _dK + " + CASE WHEN ISNULL(TENTM2,'') <>'' THEN '('+ TENTM2 +')' else '' END + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                    _dK = _dK + " Like N'" + mDK + "%'";
                }
                else if ((mIdFind == 3) || (mIdFind == 6) || (mIdFind == 9))
                {
                    _dK = " AND A.TENTM + CASE WHEN ISNULL(TENTM1,'') <>'' THEN '('+ TENTM1 +')' else '' END";
                    _dK = _dK + " + CASE WHEN ISNULL(TENTM2,'') <>'' THEN '('+ TENTM2 +')' else '' END + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                    _dK = _dK + " Like N'" + mDK + "'";
                }
                if ((mIdFind == 4) || (mIdFind == 5) || (mIdFind == 6))
                    _dK = _dK + " and a.machungloai NOT in ('00019')";
                else if ((mIdFind == 7) || (mIdFind == 8) || (mIdFind == 9))
                    _dK = _dK + " and a.machungloai in ('00019')";

            }


        }



        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMThuocKhoaG(criteria.MaKhoa, criteria.MaDT, criteria.DK, criteria.Loai)))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMThuocKhoa item = DMThuocKhoa.GetDMThuocKhoa(dr, i);
                    //DMThuocKhoa item = new DMThuocKhoa(
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

                _dK = " and BT.mabthuoc ='" + mDK + "'";

            }


        }



    
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMThuocKhoaBT(criteria.MaKhoa, criteria.MaDT, criteria.DK, criteria.Loai)))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMThuocKhoa item = DMThuocKhoa.GetDMThuocKhoa(dr, i);
                    //DMThuocKhoa item = new DMThuocKhoa(
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
