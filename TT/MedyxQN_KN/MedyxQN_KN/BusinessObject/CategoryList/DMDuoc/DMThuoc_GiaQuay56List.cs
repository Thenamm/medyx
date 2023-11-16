using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMThuoc_GiaQuay56List : BusinessListBase<DMThuoc_GiaQuay56List, DMThuoc_GiaQuay56>
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
        public static DMThuoc_GiaQuay56List NewList()
        {
            return DataPortal.Fetch<DMThuoc_GiaQuay56List>(new TemCriteria());
        }
        public static DMThuoc_GiaQuay56List GetAllDMThuoc_GiaQuay56()
        {
            return DataPortal.Fetch<DMThuoc_GiaQuay56List>(new Criteria());
        }

       
        public static DMThuoc_GiaQuay56List FindDMThuoc_GiaQuay56ByNhomThuoc(string manhom)
        {
            return DataPortal.Fetch<DMThuoc_GiaQuay56List>(new CriteriaOther(1, manhom ));
        }
        public static DMThuoc_GiaQuay56List FindDMThuocByFilter(string sql, string dk)
        {
            return DataPortal.Fetch<DMThuoc_GiaQuay56List>(new CriteriaFilter(4, sql, dk));
        }       
        public void NewTo(DMThuoc_GiaQuay56 _DMThuoc_GiaQuay56)
        {
            //_DMThuoc_GiaQuay56.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            //this.Add(_DMThuoc_GiaQuay56);
            //try
            //{
                if (!Contains(_DMThuoc_GiaQuay56.MaThuoc , _DMThuoc_GiaQuay56.Huy  ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMThuoc_GiaQuay56.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_DMThuoc_GiaQuay56);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMThuoc_GiaQuay56.OrderNumber = ++_count;
                        this.Add(_DMThuoc_GiaQuay56);
                    }
                    else
                    {
                        _DMThuoc_GiaQuay56.OrderNumber = 1;
                        this.Add(_DMThuoc_GiaQuay56);

                    }
                }
            //    else
            //        throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
            //}
            //catch (Exception ex)
            //{
            //    throw new InvalidOperationException(HTC.ShareVariables.VAR_DATA+ex.Message);
            //}
        }
        public void UpdatedTo(DMThuoc_GiaQuay56 _DMThuoc_GiaQuay56)
        {

            _DMThuoc_GiaQuay56.OrderNumber = this.Items[this.IndexOf(_DMThuoc_GiaQuay56)].OrderNumber;
            this.Items[this.IndexOf(_DMThuoc_GiaQuay56)] = _DMThuoc_GiaQuay56;
        }
        public DMThuoc_GiaQuay56 GetTo(decimal STT) //
        {
            foreach (DMThuoc_GiaQuay56 obj in this)
                if (obj.OrderNumber == STT)
                    return obj;
            return null;

        }
        public DMThuoc_GiaQuay56 AssignTo(DMThuoc_GiaQuay56 _DMThuoc_GiaQuay56)//add mot hang PhieuNhap_C
        {
            //if (!Contains(_DMThuoc_GiaQuay56.MaThuoc, _DMThuoc_GiaQuay56.Huy))
            //{
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _DMThuoc_GiaQuay56.OrderNumber = ++_count;
                    this.Add(_DMThuoc_GiaQuay56);
                }
                else
                {
                    _DMThuoc_GiaQuay56.OrderNumber = 1;
                    this.Add(_DMThuoc_GiaQuay56);
                }
            //}
            return _DMThuoc_GiaQuay56;
        }
        public void RemoveTo(DMThuoc_GiaQuay56 _DMThuoc_GiaQuay56)
        {
            this.Items.Remove(_DMThuoc_GiaQuay56);

        }
        public bool Contains(string MaThuoc,bool Huy)
        {
            foreach (DMThuoc_GiaQuay56 obj in this)
                if ((obj.MaThuoc   == MaThuoc  ) && (obj.Huy  == Huy ) )
                    return true;
            return false;
        }
        private DMThuoc_GiaQuay56List()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class TemCriteria
        {

        };
        private void DataPortal_Fetch(TemCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
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
            public OtherCriteria(Byte mIdFind,String mDK)
            {

                _IdFind = mIdFind;

                if (mIdFind == 1)
                    _DK = " and (a.MAthuoc like N'" + mDK + "%' or a.MAql like N'" + mDK + "%')";
                else if (mIdFind == 2)
                    _DK = " and ltrim(rtrim(a.Tentm)) like N'" + mDK + "%' or ltrim(rtrim(a.Tentm1)) like N'" + mDK + "%'  or ltrim(rtrim(a.Tentm2)) like N'" + mDK + "%'";
                else if (mIdFind == 4)
                {
                   _DK = " and A.TENTM + CASE WHEN ISNULL(TENTM1,'') <>'' ";
                    _DK = _DK + " THEN '('+ TENTM1 +')' ELSE '' END  + CASE WHEN ISNULL(TENTM2,'') <>'' ";
                    _DK = _DK + "  THEN '('+ TENTM2 +')' ELSE ''END + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') +' '+ ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')   like N'" + mDK + "%'";
                }
                _DK = _DK + " and isnull(a.thuocgoc,0) =0 ";
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
               
                    _DK = " and isnull(Thuocgoc,1) = 0 and mant like '%" + mDK + "'";
               
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

                        _DK = " and a.Manhom like '%" + manhom + "'";
                    if (mabietduoc != "")

                        _DK = _DK + "and (a.parent like '%" + mabietduoc + "' or a.mathuoc ='" + mabietduoc + "')";
                }
                else
                {
                    if ((manhom != "") && (manhom != "All"))

                        _DK = " and a.Manhom like '%" + _MaNhom + "'";
                    if (mabietduoc != "")

                        _DK = _DK + "and a.mathuoc like '%" + _MaBietDuoc + "'";
                    _DK = " and isnull(a.thuocgoc,0) = 1";
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

            private Boolean _qadmin = false;
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

                    _DK = manhom;
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMThuoc_GiaQuay56(HTC.ShareVariables.pub_bQadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMThuoc_GiaQuay56 item = new DMThuoc_GiaQuay56(
     i,
     dr.GetString("MaThuoc") ,
			                                dr.GetString("Parent") ,
			                                dr.GetString("MaNhom") ,
			                                dr.GetString("MaPL") ,
			                                dr.GetString("MaChungLoai") ,
			                                dr.GetString("TenGoc") ,
			                                dr.GetString("TenTC") ,
			                                dr.GetString("TenTM"),
			                                dr.GetString("TenTM1"),
			                                dr.GetString("TenTM2") ,
			                                dr.GetString("tenTA") ,
			                                dr.GetBoolean("ThuocGoc") ,
			                                dr.GetDecimal("Ngaydungtoida") ,
			                                dr.GetString("MaNSX") ,
			                                dr.GetString("HamLuong") ,
			                                dr.GetString("MaDVTHL") ,
			                                dr.GetDecimal("Nguong") ,
			                                dr.GetString("MaDVT") ,
			                                dr.GetDecimal("Quydoi") ,
     dr.GetString("MaThuocgoc"),
			                                dr.GetString("MaDVT2") ,
			                                dr.GetBoolean("ApDungGoi") ,
			                                dr.GetBoolean("Handung") ,
			                                dr.GetString("Lieudung"),
			                                dr.GetString("Cachdung") ,
			                                dr.GetDecimal("Gianhap") ,
			                                dr.GetSmartDate("Ngaynhap", true) ,
			                                dr.GetDecimal("Gianhap1") ,
			                                dr.GetSmartDate("Ngaynhap1", true) ,
			                                dr.GetDecimal("Gianhap2") ,
			                                dr.GetSmartDate("Ngaynhap2", true) ,
			                                dr.GetDecimal("DonGiaTT") ,
			                                dr.GetDecimal("DonGiaTT1"),
			                                dr.GetDecimal("DongiaThuT") ,
			                                dr.GetDecimal("DongiaPhauT") ,
			                                dr.GetDecimal("DongiaCLS") ,
			                                dr.GetDecimal("GiaQuay56") ,
			                                dr.GetDecimal("GiaQuay561"),
			                                dr.GetString("Khoban"),
			                                dr.GetString("Khophat") ,
			                                dr.GetBoolean("ThuocThuT") ,
			                                dr.GetBoolean("ThuocPhauT") ,
			                                dr.GetBoolean("ThuocCLS") ,
			                                dr.GetBoolean("ThuocNoiT") ,
			                                dr.GetBoolean("ThuocDuoc") ,
			                                dr.GetBoolean("ThuocBan") ,
			                                dr.GetBoolean("DuyetNgoaiT") ,
			                                dr.GetBoolean("DuyetNoiT") ,
			                                dr.GetString("Ghichu") ,
			                                dr.GetString("MaMay") ,
			                                dr.GetBoolean("Huy") ,
			                                dr.GetSmartDate("NgaySD", true) ,
			                                dr.GetString("NguoiSD") ,
			                                dr.GetSmartDate("NgaySD1", true) ,
			                                dr.GetString("NguoiSD1") ,
			                                dr.GetSmartDate("NgayLap", true) ,
			                                dr.GetString("NguoiLap") ,
			                                dr.GetSmartDate("NgayHuy", true) ,
			                                dr.GetString("NguoiHuy") ,
     dr.GetString("malh"),
     dr.GetString("tendvt"),
     dr.GetString("tendvthl"),
     dr.GetString("tenNguoiquay")
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMThuoc_GiaQuay56(criteria.DK,criteria.qadmin    )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMThuoc_GiaQuay56 item = new DMThuoc_GiaQuay56(
     i,
     dr.GetString("MaThuoc"),
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
     dr.GetString("MaThuocgoc"),
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
     dr.GetDecimal("GiaQuay56"),
     dr.GetDecimal("GiaQuay561"),
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
     dr.GetString("tenNguoiquay")  

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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMThuoc_GiaQuay56(criteria.DK, false)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMThuoc_GiaQuay56 item = new DMThuoc_GiaQuay56(
     i,
     dr.GetString("MaThuoc"),
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
     dr.GetString("MaThuocgoc"),
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
     dr.GetDecimal("GiaQuay56"),
     dr.GetDecimal("GiaQuay561"),
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
     dr.GetString("tenNguoiquay") 

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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMThuocFilter(criteria.DK, criteria.DKFilter, criteria.qadmin)))
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
                         DMThuoc_GiaQuay56 item = new DMThuoc_GiaQuay56(
          i,
          dr.GetString("MaThuoc"),
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
          dr.GetString("MaThuocgoc"),
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
          dr.GetDecimal("GiaQuay56"),
          dr.GetDecimal("GiaQuay561"),
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
          dr.GetString("tenNguoiquay")

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

        #region Authorization Rules

        public static bool CanAddObject()
        {
            return true;
        }

        public static bool CanGetObject()
        {
            return true;
        }

        public static bool CanDeleteObject()
        {
            return true;
        }

        public static bool CanEditObject()
        {
            return true;
        }

        #endregion
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMThuoc_GiaQuay56 item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMThuoc_GiaQuay56 item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMThuoc_GiaQuay56List Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMThuoc_GiaQuay56List result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
