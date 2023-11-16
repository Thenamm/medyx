using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMThuoc_KeList : BusinessListBase<DMThuoc_KeList, DMThuoc_Ke>
    {
        #region Business Methods
        #region State Fields
        public int _record = 0;

        #endregion
        #region Business Properties and Methods
        public int record
        {
            get
            {

                return _record;
            }

        }
        #endregion
        #endregion
        #region Factory Methods
        public static DMThuoc_KeList GetAllDMThuoc_Ke()
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new Criteria());
        }
        public static DMThuoc_KeList GetAllDMThuoc_KeTM()
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new OtherCriteria(5, ""));
        }
        public static DMThuoc_KeList FindDMThuoc_KeMa(string Ma)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new OtherCriteria(1, Ma));
        }
        public static DMThuoc_KeList FindDMThuoc_KeDK(string DK)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new OtherCriteria(31, DK));
        }
        public static DMThuoc_KeList FindDMThuoc_KeMa43(string Ma)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new OtherCriteria(16, Ma));
        }
        public static DMThuoc_KeList FindDMThuoc_KeMaD(string Ma)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new OtherCriteria(25, Ma));
        }
        public static DMThuoc_KeList FindDMThuoc_KeMa43D(string Ma)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new OtherCriteria(26, Ma));
        }
        public static DMThuoc_KeList FindDMThuoc_KeMa56D(string Ma)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new OtherCriteria(27, Ma));
        }
        public static DMThuoc_KeList FindDMThuoc_KeMaDYD(string Ma)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new OtherCriteria(28, Ma));
        }
        public static DMThuoc_KeList FindDMThuoc_KeMaNVD(string Ma)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new OtherCriteria(29, Ma));
        }
        public static DMThuoc_KeList FindDMThuoc_KeMaTYD(string Ma)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new OtherCriteria(30, Ma));
        }
        public static DMThuoc_KeList FindDMThuoc_KeMaNV(string Ma)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new OtherCriteria(31, Ma));
        }
        public static DMThuoc_KeList FindDMThuoc_KeMa56(string Ma)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new OtherCriteria(17, Ma));
        }
        public static DMThuoc_KeList FindDMThuoc_KeTen(string Ten)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new OtherCriteria(2, Ten));
        }
        public static DMThuoc_KeList FindDMThuoc_KeTenNV(string Ten)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new OtherCriteria(20, Ten));
        }
        public static DMThuoc_KeList FindDMThuoc_KeTen43(string Ten)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new OtherCriteria(18, Ten));
        }
        public static DMThuoc_KeList FindDMThuoc_KeTen56(string Ten)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new OtherCriteria(19, Ten));
        }

        public static DMThuoc_KeList FindDMThuoc_KeTenD(string Ten)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new OtherCriteria(6, Ten));
        }


        public static DMThuoc_KeList FindDMThuoc_KeMaDY(string Ma)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new OtherCriteria(13, Ma));
        }
        public static DMThuoc_KeList FindDMThuoc_KeTenDY(string Ten)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new OtherCriteria(14, Ten));
        }


        public static DMThuoc_KeList FindDMThuoc_KeTenDDY(string Ten)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new OtherCriteria(15, Ten));
        }

        public static DMThuoc_KeList FindDMThuoc_KeTenDu(string Ten)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new OtherCriteria(4, Ten));
        }

        public static DMThuoc_KeList FindDMThuoc_KeByNhomThuoc(string manhom, string mabietduoc)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new FilterCriteria(3, manhom, mabietduoc));
        }
        public static DMThuoc_KeList FindDMThuoc_KeByNhomThuocBD(string manhom, string MaKe)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new FilterCriteria(4, manhom, MaKe));
        }
        public static DMThuoc_KeList FindDMThuoc_KeByNhomThuocBK(string manhom, string MaKe)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new FilterCriteria(5, manhom, MaKe));
        }
        public static DMThuoc_KeList FindDMThuoc_KeMaBD(string Ma)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new CriteriaOther(3, Ma));
        }
        public static DMThuoc_KeList FindDMThuoc_KeTenBD(string Ten)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new CriteriaOther(4, Ten));
        }
        public static DMThuoc_KeList FindDMThuoc_KeMaTY(string Ma)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new OtherCriteria(22, Ma));
        }
        public static DMThuoc_KeList FindDMThuoc_KeTenTY(string Ten)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new OtherCriteria(23, Ten));
        }


        public static DMThuoc_KeList FindDMThuoc_KeTenDTY(string Ten)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new OtherCriteria(24, Ten));
        }
        public static DMThuoc_KeList FindDMThuoc_KeByNhomThuocFilter(string manhom, string dk)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new CriteriaFilter(3, manhom, dk));
        }
        public static DMThuoc_KeList FindDMThuoc_KeByNhomThuocTYFilter(string manhom, string dk)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new CriteriaFilter(1, manhom, dk));
        }
        public static DMThuoc_KeList FindDMThuoc_KeByNhomThuocDYFilter(string manhom, string dk)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new CriteriaFilter(2, manhom, dk));
        }
        public static DMThuoc_KeList FindDMThuoc_KeByFilter(string sql, string dk)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new CriteriaFilter(4, sql, dk));
        }
        public static DMThuoc_KeList FindDMThuoc_KeByTYFilter(string sql, string dk)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new CriteriaFilter(5, sql, dk));
        }
        public static DMThuoc_KeList FindDMThuoc_KeByDYFilter(string sql, string dk)
        {
            return DataPortal.Fetch<DMThuoc_KeList>(new CriteriaFilter(6, sql, dk));
        }
        public void NewTo(DMThuoc_Ke _DMThuoc_Ke)
        {
            if (this.Count == 0)
                _DMThuoc_Ke.OrderNumber = 1;
            else
                _DMThuoc_Ke.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMThuoc_Ke);
        }
        public void UpdatedTo(DMThuoc_Ke _DMThuoc_Ke)
        {

            _DMThuoc_Ke.OrderNumber = this.Items[this.IndexOf(_DMThuoc_Ke)].OrderNumber;
            this.Items[this.IndexOf(_DMThuoc_Ke)] = _DMThuoc_Ke;
        }
        public void RemoveTo(DMThuoc_Ke _DMThuoc_Ke)
        {
            if (_DMThuoc_Ke.IsNew == true)
                Remove(_DMThuoc_Ke);
            else
                this.Items.Remove(_DMThuoc_Ke);

        }
        private DMThuoc_KeList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            //private int _id;
            //public int Id
            //{
            //    get
            //    {
            //        return _id;
            //    }
            //}
            //public Criteria(int mId)
            //{
            //    _id = mId;
            //}
        }
        private class OtherCriteria
        {
            //private int _id;
            //public int Id
            //{
            //    get
            //    {
            //        return _id;
            //    }
            //}
            private Byte _IdFind;
            public Byte IdFind
            {
                get
                {
                    return _IdFind;
                }
            }
            private string _DK;
            public string DK
            {
                get
                {
                    return _DK;
                }
            }
            private Boolean _qadmin = false;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            //public Criteria(Boolean mqadmin)
            //{

            //    _qadmin = mqadmin;
            //}
            public OtherCriteria(Byte mIdFind, String mDK)
            {

                _IdFind = mIdFind;

                if ((mIdFind == 1) || (mIdFind == 16) || (mIdFind == 17) || (mIdFind == 20))

                    _DK = " and (a.MaKe like N'" + mDK + "%' or a.MAql like N'" + mDK + "%')";
                else if ((mIdFind == 31))
                    _DK = _DK + mDK;
                else if ((mIdFind == 25) || (mIdFind == 26) || (mIdFind == 27) || (mIdFind == 28))
                    _DK = " and (a.MaKe = N'" + mDK + "' or a.MAql = N'" + mDK + "')";

                else if ((mIdFind == 2) || (mIdFind == 18) || (mIdFind == 19) || (mIdFind == 21))
                    _DK = " and (ltrim(rtrim(a.Tentm)) like N'" + mDK + "%' or ltrim(rtrim(a.Tentm1)) like N'" + mDK + "%'  or ltrim(rtrim(a.Tentm2)) like N'" + mDK + "%')";
                else if (mIdFind == 4)
                {
                    //   _DK = " and A.TENTM + CASE WHEN ISNULL(a.TENTM1,'') <>'' ";
                    //    _DK = _DK + " THEN '('+ a.TENTM1 +')' ELSE '' END  + CASE WHEN ISNULL(a.TENTM2,'') <>'' ";
                    //    _DK = _DK + "  THEN '('+ a.TENTM2 +')' ELSE ''END + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'')  like N'" + mDK + "%'";
                    _DK = " and A.TENTM + CASE WHEN ISNULL(a.TENTM1,'') <>'' ";
                    _DK = _DK + " THEN '('+ a.TENTM1 +')' ELSE '' END  + CASE WHEN ISNULL(a.TENTM2,'') <>'' ";
                    _DK = _DK + "  THEN '('+ a.TENTM2 +')' ELSE ''END + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'') like N'" + mDK + "%'";
                    //_DK = _DK + " AND ((A.TENTM  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                    //_DK = _DK + " Like N'" + mDK + "%')";
                    //_DK = _DK + " or ( A.TENTM1  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                    //_DK = _DK + " Like N'" + mDK + "%')";
                    //_DK = _DK + " or ( A.TENTM2  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                    //_DK = _DK + " Like N'" + mDK + "%')) ";
                }
                else if (mIdFind == 6)
                    _DK = " and ltrim(rtrim(a.TenTM)) like N'" + mDK + "'";
                else if (mIdFind == 13)
                    _DK = " AND A.MACHUNGLOAI = '00019' and (a.MaKe like N'" + mDK + "%' or a.MAql like N'" + mDK + "%')";
                else if (mIdFind == 28)
                    _DK = " AND A.MACHUNGLOAI = '00019' and (a.MaKe = N'" + mDK + "' or a.MAql = N'" + mDK + "')";
                else if (mIdFind == 14)
                {
                    _DK = " AND A.MACHUNGLOAI = '00019'";
                    _DK = _DK + " AND ((A.TENTM  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                    _DK = _DK + " Like N'" + mDK + "%')";
                    _DK = _DK + " or ( A.TENTM1  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                    _DK = _DK + " Like N'" + mDK + "%')";
                    _DK = _DK + " or ( A.TENTM2  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                    _DK = _DK + " Like N'" + mDK + "%')) ";
                }
                else if (mIdFind == 15)
                {
                    _DK = _DK + " and A.TENTM + CASE WHEN ISNULL(a.TENTM1,'') <>'' ";
                    _DK = _DK + " THEN '('+ a.TENTM1 +')' ELSE '' END  + CASE WHEN ISNULL(a.TENTM2,'') <>'' ";
                    _DK = _DK + "  THEN '('+ a.TENTM2 +')' ELSE ''END + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'') like N'" + mDK + "'";
                }
                else if (mIdFind == 22)
                    _DK = " AND A.MACHUNGLOAI NOT IN ( '00019') and (a.MaKe like N'" + mDK + "%' or a.MAql like N'" + mDK + "%')";
                else if (mIdFind == 30)
                    _DK = " AND A.MACHUNGLOAI NOT IN ( '00019') and (a.MaKe = N'" + mDK + "' or a.MAql = N'" + mDK + "')";
                else if (mIdFind == 23)
                {
                    _DK = " AND A.MACHUNGLOAI NOT IN ( '00019')";
                    _DK = _DK + " AND ((A.TENTM  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                    _DK = _DK + " Like N'" + mDK + "%')";
                    _DK = _DK + " or ( A.TENTM1  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                    _DK = _DK + " Like N'" + mDK + "%')";
                    _DK = _DK + " or ( A.TENTM2  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')  ";
                    _DK = _DK + " Like N'" + mDK + "%')) ";
                    _DK = _DK + " and isnull(a.thuocgoc,0) =0 ";
                }
                else if (mIdFind == 24)
                {
                    _DK = " AND A.MACHUNGLOAI NOT IN ( '00019') ";
                    _DK = _DK + " and A.TENTM + CASE WHEN ISNULL(a.TENTM1,'') <>'' ";
                    _DK = _DK + " THEN '('+ a.TENTM1 +')' ELSE '' END  + CASE WHEN ISNULL(a.TENTM2,'') <>'' ";
                    _DK = _DK + "  THEN '('+ a.TENTM2 +')' ELSE ''END + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') + ' ' + ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'') like N'" + mDK + "'";

                    _DK = _DK + " and isnull(a.thuocgoc,0) =0 ";
                }
                if ((mIdFind == 16) || (mIdFind == 18) || (mIdFind == 26))
                    _DK = _DK + " AND A.THUOCBAN =1 ";
                else if ((mIdFind == 17) || (mIdFind == 19) || (mIdFind == 27))
                    _DK = _DK + " AND A.THUOCBAN2 =1 ";
                if ((mIdFind == 20) || (mIdFind == 21))
                    _DK = _DK + " AND A.THUOCNOIT =1 ";
            }
        }

        // tim kiem theo ten
        #region CriteriaOther
        [Serializable()]
        private class CriteriaOther
        {
            //private int _id;
            //public int Id
            //{
            //    get
            //    {
            //        return _id;
            //    }
            //}
            private Byte _IdFind;
            public Byte IdFind
            {
                get
                {
                    return _IdFind;
                }
            }
            private string _DK;
            public string DK
            {
                get
                {
                    return _DK;
                }
            }
             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            //public Criteria(Boolean mqadmin)
            //{

            //    _qadmin = mqadmin;
            //}
            public CriteriaOther(Byte mIdFind, String mDK)
            {

                _IdFind = mIdFind;
                if (mIdFind == 1)
                    _DK = " and isnull(Thuocgoc,1) = 0 and MaKe like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "and isnull(Thuocgoc,1) = 0 and ltrim(rtrim(TenTM)) like N'" + mDK + "%'";
                else if (mIdFind == 4)
                    _DK = "and isnull(Thuocgoc,1) = 1 and ltrim(rtrim(TenTM)) like N'" + mDK + "%'";
                else if (mIdFind == 3)
                    _DK = "and isnull(Thuocgoc,1) = 1 and MaKe like '%" + mDK + "'";
                else if (mIdFind == 5)
                    _DK = "and isnull(Thuocgoc,1) = 0 and ltrim(rtrim(TenTM)) like N'" + mDK + "'";

            }
        }


        #endregion

        #region FilterCriteria
        [Serializable()]
        private class FilterCriteria
        {
            //private int _id;
            //public int Id
            //{
            //    get
            //    {
            //        return _id;
            //    }
            //}
            private Byte _IdFind;
            public Byte IdFind
            {
                get
                {
                    return _IdFind;
                }
            }
            private string _DK;
            public string DK
            {
                get
                {
                    return _DK;
                }
            }
            private string _MaNhom;
            public string MaNhom
            {
                get
                {
                    return _MaNhom;
                }
            }
            private string _MaBietDuoc;
            public string MaBietDuoc
            {
                get
                {
                    return _MaBietDuoc;
                }
            }
             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }

            public FilterCriteria(Byte mIdFind, string manhom, string mabietduoc)
            {

                _IdFind = mIdFind;
                // _DK = "and thuocgoc = 0";
                if (mIdFind == 3)
                {
                    if ((manhom != "") && (manhom != "All"))

                        _DK = " and a.Manhom like N'%" + manhom + "%'";
                    if (mabietduoc != "")

                        _DK = _DK + "and (a.tengoc like N'%" + mabietduoc + "%')";// or a.MaKe ='" + mabietduoc + "')";
                }
                else if (mIdFind == 5)
                {
                    if ((manhom != "") && (manhom != "All"))

                        _DK = " and a.Manhom like N'%" + manhom + "%'";
                    if (mabietduoc != "")

                        _DK = _DK + "and (a.tengoc like '%" + mabietduoc + "%')";// or a.MaKe ='" + mabietduoc + "')";
                    _DK = " and isnull(a.thuocgoc,0) = 0";
                }
                else
                {
                    if ((manhom != "") && (manhom != "All"))

                        _DK = " and a.Manhom like N'%" + _MaNhom + "%'";
                    //if (mabietduoc != "")

                    //    _DK = _DK + "and a.MaKe like '%" + _MaBietDuoc + "'";
                    if (mabietduoc != "")

                        _DK = _DK + "and (a.tengoc like '%" + mabietduoc + "%')";// or a.MaKe ='" + mabietduoc + "')";
                    //_DK = " and isnull(a.thuocgoc,0) = 1";
                }
                //else if (mIdFind == 2)
                //    _DK = "ltrim(rtrim(TenTM)) like N'" + mDK + "%'";


            }
        }


        #endregion
        #region CriteriaFilter
        [Serializable()]
        private class CriteriaFilter
        {
            //private int _id;
            //public int Id
            //{
            //    get
            //    {
            //        return _id;
            //    }
            //}

            private string _DK;
            public string DK
            {
                get
                {
                    return _DK;
                }
            }
            private string _DKFilter;
            public string DKFilter
            {
                get
                {
                    return _DKFilter;
                }
            }
            private string _MaNhom;
            public string MaNhom
            {
                get
                {
                    return _MaNhom;
                }
            }
            private string _MaBietDuoc;
            public string MaBietDuoc
            {
                get
                {
                    return _MaBietDuoc;
                }
            }
             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }

            public CriteriaFilter(byte IdFind, string manhom, string dk)
            {
                _DK = "";
                if (IdFind == 1)
                {
                    if ((manhom != "") && (manhom != "All"))

                        _DK = " and a.Manhom like N'%" + manhom + "%'";
                    _DK = _DK + " AND A.MACHUNGLOAI NOT IN ( '00019') ";


                }
                else if (IdFind == 2)
                {
                    if ((manhom != "") && (manhom != "All"))

                        _DK = " and a.Manhom like N'%" + manhom + "%'";
                    _DK = _DK + " AND A.MACHUNGLOAI IN ( '00019') ";

                }
                else if (IdFind == 3)
                {
                    if ((manhom != "") && (manhom != "All"))

                        _DK = " and a.Manhom like N'%" + manhom + "%'";
                }
                else if (IdFind == 5)
                {
                   
                        _DK = manhom ;
                    _DK = _DK + " AND A.MACHUNGLOAI NOT IN ( '00019') ";


                }
                else if (IdFind == 6)
                {
                    _DK = manhom;
                    _DK = _DK + " AND A.MACHUNGLOAI IN ( '00019') ";

                }
                else if (IdFind == 4)
                {
                    _DK = manhom;

                       
                }
                _DKFilter = dk;
            }
        }


        #endregion
        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMThuoc_Ke(HTC.ShareVariables.pub_bQadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMThuoc_Ke item = new DMThuoc_Ke(
     i,
     dr.GetString("MaKe"),
                                            dr.GetString("Parent"),
                                            dr.GetString("MaNhom"),
                                            dr.GetString("MaPL"),
                                            dr.GetString("MaChungLoai"),
                                            dr.GetString("TenGoc"),
                                            dr.GetString("TenTC"),
                                            dr.GetString("TenTM"),
                                            dr.GetString("TenTM1"),
                                            dr.GetString("TenTM2"),
                                            dr.GetString("tenTA"),
                                            dr.GetBoolean("ThuocGoc"),
                                            dr.GetDecimal("Ngaydungtoida"),
                                            dr.GetString("MaNSX"),
                                            dr.GetString("HamLuong"),
                                            dr.GetString("MaDVTHL"),
                                            dr.GetDecimal("Nguong"),
                                            dr.GetString("MaDVT"),
                                            dr.GetDecimal("Quydoi"),
     dr.GetString("MaKegoc"),
                                            dr.GetString("MaDVT2"),
                                            dr.GetBoolean("ApDungGoi"),
                                            dr.GetBoolean("Handung"),
                                            dr.GetString("Lieudung"),
                                            dr.GetString("Cachdung"),
                                            dr.GetDecimal("Gianhap"),
                                            dr.GetSmartDate("Ngaynhap", true),
                                            dr.GetDecimal("Gianhap1"),
                                            dr.GetSmartDate("Ngaynhap1", true),
                                            dr.GetDecimal("Gianhap2"),
                                            dr.GetSmartDate("Ngaynhap2", true),
                                            dr.GetDecimal("DonGiaTT"),
                                            dr.GetDecimal("DonGiaTT1"),
                                            dr.GetDecimal("DongiaThuT"),
                                            dr.GetDecimal("DongiaPhauT"),
                                            dr.GetDecimal("DongiaCLS"),
                                            dr.GetDecimal("GiaQuay"),
                                            dr.GetDecimal("GiaQuay1"),
                                            dr.GetString("Khoban"),
                                            dr.GetString("Khophat"),
                                            dr.GetBoolean("ThuocThuT"),
                                            dr.GetBoolean("ThuocPhauT"),
                                            dr.GetBoolean("ThuocCLS"),
                                            dr.GetBoolean("ThuocNoiT"),
                                            dr.GetBoolean("ThuocDuoc"),
                                            dr.GetBoolean("ThuocBan"),
                                            dr.GetBoolean("DuyetNgoaiT"),
                                            dr.GetBoolean("DuyetNoiT"),
                                            dr.GetString("Ghichu"),
                                            dr.GetString("MaMay"),
                                            dr.GetBoolean("Huy"),
                                            dr.GetSmartDate("NgaySD", true),
                                            dr.GetString("NguoiSD"),
                                            dr.GetSmartDate("NgaySD1", true),
                                            dr.GetString("NguoiSD1"),
                                            dr.GetSmartDate("NgayLap", true),
                                            dr.GetString("NguoiLap"),
                                            dr.GetSmartDate("NgayHuy", true),
                                            dr.GetString("NguoiHuy"),
     dr.GetString("malh"),
     dr.GetString("tendvt"),
     dr.GetString("tendvthl"),
     dr.GetString("TenNguoiSD"),
     dr.GetString("TenNguoiLap"),
     dr.GetString("TenNguoiHuy"),
     dr.GetString("TenNSX"),
      dr.GetString("quycach"),
    dr.GetString("matk"),
     dr.GetString("sovisa"),
     dr.GetBoolean("thuocban2"),
     dr.GetBoolean("ThuocHoiChan"),
     dr.GetByte("ThuocTieuHao"),
     dr.GetBoolean("KhongSD"),
     dr.GetDecimal("GiaQuay56"),
     dr.GetDecimal("GiaQuay561"),
     dr.GetString("maql"),
     dr.GetString("matp"),
     dr.GetString("duongdung"),
     dr.GetString("tendvt2"),
     dr.GetDecimal("Gianhap43"),
     dr.GetSmartDate("Ngaynhap43", true),
     dr.GetDecimal("Gianhap56"),
     dr.GetSmartDate("Ngaynhap56", true)
         );

                    this.Add(item);
                    i += 1;
                }
                //IsReadOnly = true;
            }
            // Xem lai doan code duoi
            //ArrayList arrList;
            //arrList = CBO.FillCollection(DataProvider.Instance().GetLocations(criteria.Id), typeof(LocationListInfo));
            //IsReadOnly = false;
            //foreach (LocationListInfo obj in arrList)
            //{
            //    this.Add(obj);
            //}
            //IsReadOnly = true;

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMThuoc_Ke(criteria.DK, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMThuoc_Ke item = new DMThuoc_Ke(
     i,
     dr.GetString("MaKe"),
     dr.GetString("Parent"),
     dr.GetString("MaNhom"),
     dr.GetString("MaPL"),
     dr.GetString("MaChungLoai"),
     dr.GetString("TenGoc"),
     dr.GetString("TenTC"),
     dr.GetString("TenTM"),
     dr.GetString("TenTM1"),
     dr.GetString("TenTM2"),
     dr.GetString("tenTA"),
     dr.GetBoolean("ThuocGoc"),
     dr.GetDecimal("Ngaydungtoida"),
     dr.GetString("MaNSX"),
     dr.GetString("HamLuong"),
     dr.GetString("MaDVTHL"),
     dr.GetDecimal("Nguong"),
     dr.GetString("MaDVT"),
     dr.GetDecimal("Quydoi"),
     dr.GetString("MaKegoc"),
     dr.GetString("MaDVT2"),
     dr.GetBoolean("ApDungGoi"),
     dr.GetBoolean("Handung"),
     dr.GetString("Lieudung"),
     dr.GetString("Cachdung"),
     dr.GetDecimal("Gianhap"),
     dr.GetSmartDate("Ngaynhap", true),
     dr.GetDecimal("Gianhap1"),
     dr.GetSmartDate("Ngaynhap1", true),
     dr.GetDecimal("Gianhap2"),
     dr.GetSmartDate("Ngaynhap2", true),
     dr.GetDecimal("DonGiaTT"),
     dr.GetDecimal("DonGiaTT1"),
     dr.GetDecimal("DongiaThuT"),
     dr.GetDecimal("DongiaPhauT"),
     dr.GetDecimal("DongiaCLS"),
     dr.GetDecimal("GiaQuay"),
     dr.GetDecimal("GiaQuay1"),
     dr.GetString("Khoban"),
     dr.GetString("Khophat"),
     dr.GetBoolean("ThuocThuT"),
     dr.GetBoolean("ThuocPhauT"),
     dr.GetBoolean("ThuocCLS"),
     dr.GetBoolean("ThuocNoiT"),
     dr.GetBoolean("ThuocDuoc"),
     dr.GetBoolean("ThuocBan"),
     dr.GetBoolean("DuyetNgoaiT"),
     dr.GetBoolean("DuyetNoiT"),
     dr.GetString("Ghichu"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", true),
     dr.GetString("NguoiSD"),
     dr.GetSmartDate("NgaySD1", true),
     dr.GetString("NguoiSD1"),
     dr.GetSmartDate("NgayLap", true),
     dr.GetString("NguoiLap"),
     dr.GetSmartDate("NgayHuy", true),
     dr.GetString("NguoiHuy"),
     dr.GetString("malh"),
     dr.GetString("tendvt"),
     dr.GetString("tendvthl"),
     dr.GetString("TenNguoiSD"),
     dr.GetString("TenNguoiLap"),
     dr.GetString("TenNguoiHuy"),
     dr.GetString("TenNSX"),
      dr.GetString("quycach"),
    dr.GetString("matk"),
     dr.GetString("sovisa"),
     dr.GetBoolean("thuocban2"),
     dr.GetBoolean("ThuocHoiChan"),
      dr.GetByte("ThuocTieuHao"),
     dr.GetBoolean("KhongSD"),
     dr.GetDecimal("GiaQuay56"),
     dr.GetDecimal("GiaQuay561"),
     dr.GetString("maql"),
     dr.GetString("matp"),
     dr.GetString("duongdung"),
     dr.GetString("tendvt2"),
     dr.GetDecimal("Gianhap43"),
     dr.GetSmartDate("Ngaynhap43", true),
     dr.GetDecimal("Gianhap56"),
     dr.GetSmartDate("Ngaynhap56", true)


         );

                    this.Add(item);
                    i += 1;
                }
                //IsReadOnly = true;
            }
            // Xem lai doan code duoi
            //ArrayList arrList;
            //arrList = CBO.FillCollection(DataProvider.Instance().GetLocations(criteria.Id), typeof(LocationListInfo));
            //IsReadOnly = false;
            //foreach (LocationListInfo obj in arrList)
            //{
            //    this.Add(obj);
            //}
            //IsReadOnly = true;

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        private void DataPortal_Fetch(FilterCriteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMThuoc_Ke(criteria.DK, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMThuoc_Ke item = new DMThuoc_Ke(
     i,
     dr.GetString("MaKe"),
     dr.GetString("Parent"),
     dr.GetString("MaNhom"),
     dr.GetString("MaPL"),
     dr.GetString("MaChungLoai"),
     dr.GetString("TenGoc"),
     dr.GetString("TenTC"),
     dr.GetString("TenTM"),
     dr.GetString("TenTM1"),
     dr.GetString("TenTM2"),
     dr.GetString("tenTA"),
     dr.GetBoolean("ThuocGoc"),
     dr.GetDecimal("Ngaydungtoida"),
     dr.GetString("MaNSX"),
     dr.GetString("HamLuong"),
     dr.GetString("MaDVTHL"),
     dr.GetDecimal("Nguong"),
     dr.GetString("MaDVT"),
     dr.GetDecimal("Quydoi"),
     dr.GetString("MaKegoc"),
     dr.GetString("MaDVT2"),
     dr.GetBoolean("ApDungGoi"),
     dr.GetBoolean("Handung"),
     dr.GetString("Lieudung"),
     dr.GetString("Cachdung"),
     dr.GetDecimal("Gianhap"),
     dr.GetSmartDate("Ngaynhap", true),
     dr.GetDecimal("Gianhap1"),
     dr.GetSmartDate("Ngaynhap1", true),
     dr.GetDecimal("Gianhap2"),
     dr.GetSmartDate("Ngaynhap2", true),
     dr.GetDecimal("DonGiaTT"),
     dr.GetDecimal("DonGiaTT1"),
     dr.GetDecimal("DongiaThuT"),
     dr.GetDecimal("DongiaPhauT"),
     dr.GetDecimal("DongiaCLS"),
     dr.GetDecimal("GiaQuay"),
     dr.GetDecimal("GiaQuay1"),
     dr.GetString("Khoban"),
     dr.GetString("Khophat"),
     dr.GetBoolean("ThuocThuT"),
     dr.GetBoolean("ThuocPhauT"),
     dr.GetBoolean("ThuocCLS"),
     dr.GetBoolean("ThuocNoiT"),
     dr.GetBoolean("ThuocDuoc"),
     dr.GetBoolean("ThuocBan"),
     dr.GetBoolean("DuyetNgoaiT"),
     dr.GetBoolean("DuyetNoiT"),
     dr.GetString("Ghichu"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", true),
     dr.GetString("NguoiSD"),
     dr.GetSmartDate("NgaySD1", true),
     dr.GetString("NguoiSD1"),
     dr.GetSmartDate("NgayLap", true),
     dr.GetString("NguoiLap"),
     dr.GetSmartDate("NgayHuy", true),
     dr.GetString("NguoiHuy"),
     dr.GetString("malh"),
     dr.GetString("tendvt"),
     dr.GetString("tendvthl"),
     dr.GetString("TenNguoiSD"),
     dr.GetString("TenNguoiLap"),
     dr.GetString("TenNguoiHuy"),
     dr.GetString("TenNSX"),
      dr.GetString("quycach"),
    dr.GetString("matk"),
     dr.GetString("sovisa"),
     dr.GetBoolean("thuocban2"),
     dr.GetBoolean("ThuocHoiChan"),
      dr.GetByte("ThuocTieuHao"),
     dr.GetBoolean("KhongSD"),
     dr.GetDecimal("GiaQuay56"),
     dr.GetDecimal("GiaQuay561"),
     dr.GetString("maql"),
     dr.GetString("matp"),
     dr.GetString("duongdung"),
     dr.GetString("tendvt2"),
     dr.GetDecimal("Gianhap43"),
     dr.GetSmartDate("Ngaynhap43", true),
     dr.GetDecimal("Gianhap56"),
     dr.GetSmartDate("Ngaynhap56", true)


         );

                    this.Add(item);
                    i += 1;
                }
                //IsReadOnly = true;
            }
            // Xem lai doan code duoi
            //ArrayList arrList;
            //arrList = CBO.FillCollection(DataProvider.Instance().GetLocations(criteria.Id), typeof(LocationListInfo));
            //IsReadOnly = false;
            //foreach (LocationListInfo obj in arrList)
            //{
            //    this.Add(obj);
            //}
            //IsReadOnly = true;

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaFilter criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMThuoc_KeFilter(criteria.DK, criteria.DKFilter, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                if (dr.Read())
                {
                    _record = dr.GetInt32("record");
                }
                if (dr.NextResult())
                {
                    while (dr.Read())
                    {
                        DMThuoc_Ke item = new DMThuoc_Ke(
         dr.GetInt32("row"),

         dr.GetString("MaKe"),
         dr.GetString("Parent"),
         dr.GetString("MaNhom"),
         dr.GetString("MaPL"),
         dr.GetString("MaChungLoai"),
         dr.GetString("TenGoc"),
         dr.GetString("TenTC"),
         dr.GetString("TenTM"),
         dr.GetString("TenTM1"),
         dr.GetString("TenTM2"),
         dr.GetString("tenTA"),
         dr.GetBoolean("ThuocGoc"),
         dr.GetDecimal("Ngaydungtoida"),
         dr.GetString("MaNSX"),
         dr.GetString("HamLuong"),
         dr.GetString("MaDVTHL"),
         dr.GetDecimal("Nguong"),
         dr.GetString("MaDVT"),
         dr.GetDecimal("Quydoi"),
         dr.GetString("MaKegoc"),
         dr.GetString("MaDVT2"),
         dr.GetBoolean("ApDungGoi"),
         dr.GetBoolean("Handung"),
         dr.GetString("Lieudung"),
         dr.GetString("Cachdung"),
         dr.GetDecimal("Gianhap"),
         dr.GetSmartDate("Ngaynhap", true),
         dr.GetDecimal("Gianhap1"),
         dr.GetSmartDate("Ngaynhap1", true),
         dr.GetDecimal("Gianhap2"),
         dr.GetSmartDate("Ngaynhap2", true),
         dr.GetDecimal("DonGiaTT"),
         dr.GetDecimal("DonGiaTT1"),
         dr.GetDecimal("DongiaThuT"),
         dr.GetDecimal("DongiaPhauT"),
         dr.GetDecimal("DongiaCLS"),
         dr.GetDecimal("GiaQuay"),
         dr.GetDecimal("GiaQuay1"),
         dr.GetString("Khoban"),
         dr.GetString("Khophat"),
         dr.GetBoolean("ThuocThuT"),
         dr.GetBoolean("ThuocPhauT"),
         dr.GetBoolean("ThuocCLS"),
         dr.GetBoolean("ThuocNoiT"),
         dr.GetBoolean("ThuocDuoc"),
         dr.GetBoolean("ThuocBan"),
         dr.GetBoolean("DuyetNgoaiT"),
         dr.GetBoolean("DuyetNoiT"),
         dr.GetString("Ghichu"),
         dr.GetString("MaMay"),
         dr.GetBoolean("Huy"),
         dr.GetSmartDate("NgaySD", true),
         dr.GetString("NguoiSD"),
         dr.GetSmartDate("NgaySD1", true),
         dr.GetString("NguoiSD1"),
         dr.GetSmartDate("NgayLap", true),
         dr.GetString("NguoiLap"),
         dr.GetSmartDate("NgayHuy", true),
         dr.GetString("NguoiHuy"),
         dr.GetString("malh"),
         dr.GetString("tendvt"),
         dr.GetString("tendvthl"),
         dr.GetString("TenNguoiSD"),
         dr.GetString("TenNguoiLap"),
         dr.GetString("TenNguoiHuy"),
         dr.GetString("TenNSX"),
          dr.GetString("quycach"),
        dr.GetString("matk"),
         dr.GetString("sovisa"),
         dr.GetBoolean("thuocban2"),
         dr.GetBoolean("ThuocHoiChan"),
          dr.GetByte("ThuocTieuHao"),
         dr.GetBoolean("KhongSD"),
         dr.GetDecimal("GiaQuay56"),
         dr.GetDecimal("GiaQuay561"),
         dr.GetString("maql"),
         dr.GetString("matp"),
         dr.GetString("duongdung"),
         dr.GetString("tendvt2"),
         dr.GetDecimal("Gianhap43"),
         dr.GetSmartDate("Ngaynhap43", true),
         dr.GetDecimal("Gianhap56"),
         dr.GetSmartDate("Ngaynhap56", true)



             );

                        this.Add(item);
                        i += 1;
                    }
                }
                //IsReadOnly = true;
            }
           
            // Xem lai doan code duoi
            //ArrayList arrList;
            //arrList = CBO.FillCollection(DataProvider.Instance().GetLocations(criteria.Id), typeof(LocationListInfo));
            //IsReadOnly = false;
            //foreach (LocationListInfo obj in arrList)
            //{
            //    this.Add(obj);
            //}
            //IsReadOnly = true;

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
    }
}
