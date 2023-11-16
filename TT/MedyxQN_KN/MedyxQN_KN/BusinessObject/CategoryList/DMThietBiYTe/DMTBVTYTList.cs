using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMTBVTYTList : BusinessListBase<DMTBVTYTList, DMTBVTYT>
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
        #region Business Methods

        #region State Fields
         #region Factory Methods
       private byte _loai=1;
         #endregion
        #endregion
        public static DMTBVTYTList GetAllDMTBVTYT()
        {
            return DataPortal.Fetch<DMTBVTYTList>(new Criteria());
        }
        public static DMTBVTYTList FindDMTBVTYTMa(string Ma)
        {
            return DataPortal.Fetch<DMTBVTYTList>(new CriteriaOther(1, Ma));
        }
        public static DMTBVTYTList FindDMTBVTYTTen(string Ten)
        {
            return DataPortal.Fetch<DMTBVTYTList>(new CriteriaOther(2, Ten));
        }
        public static DMTBVTYTList FindDMTBVTYTTenD(string Ten)
        {
            return DataPortal.Fetch<DMTBVTYTList>(new CriteriaOther(4, Ten));

        }
        public static DMTBVTYTList FindDMTBVTYTTenDu(string Ten)
        {
            return DataPortal.Fetch<DMTBVTYTList>(new CriteriaOther(5, Ten));
        }
        public static DMTBVTYTList FindDMTBVTYTTen(string Ten, string dk)
        {
            return DataPortal.Fetch<DMTBVTYTList>(new OtherCriteria(2, Ten,dk));
        }
        public static DMTBVTYTList FindDMTBVTYTTenD(string Ten, string dk)
        {
            return DataPortal.Fetch<DMTBVTYTList>(new OtherCriteria(4, Ten,dk));

        }
        public static DMTBVTYTList FindDMTBVTYTTenDu(string Ten,string dk)
        {
            return DataPortal.Fetch<DMTBVTYTList>(new OtherCriteria(5, Ten,dk));
        }

        public static DMTBVTYTList FindDMTBVTYTByNhomVTYT(string manhom)
        {
            return DataPortal.Fetch<DMTBVTYTList>(new CriteriaOther(3, manhom));
        }
       //loai vat tu va vat tu hanh chinh
        public static DMTBVTYTList GetAllDMTBVTYT( byte loai)
        {

            return DataPortal.Fetch<DMTBVTYTList>(new CriteriaOther((byte)(loai+100),""));
        }
        public static DMTBVTYTList FindDMTBVTYTMa(string Ma,byte loai)
        {
            return DataPortal.Fetch<DMTBVTYTList>(new CriteriaOther((byte)(1+loai), Ma));
        }
        public static DMTBVTYTList FindDMTBVTYTTen(string Ten, byte loai)
        {
            return DataPortal.Fetch<DMTBVTYTList>(new CriteriaOther((byte)(2+loai), Ten));

        }
        public static DMTBVTYTList FindDMTBVTYTByNhomVTYT(string manhom, byte loai)
        {
            return DataPortal.Fetch<DMTBVTYTList>(new CriteriaOther((byte)(3 + loai), manhom));
        }
        public static DMTBVTYTList FindDMTBVTYTTenD(string Ten, byte loai)
        {
            return DataPortal.Fetch<DMTBVTYTList>(new CriteriaOther((byte)(4+loai), Ten));

        }

        public static DMTBVTYTList FindDMTBVTYTTenDu(string Ten, byte loai)
        {
            return DataPortal.Fetch<DMTBVTYTList>(new CriteriaOther((byte)(5 + loai), Ten));
        }
        public static DMTBVTYTList FindDMTBVTYTbyFilter(string sql, string dkfilter, byte loai)
        {
            return DataPortal.Fetch<DMTBVTYTList>(new CriteriaFilter((byte)( loai), sql, dkfilter));
        }
        public static DMTBVTYTList FindDMTBVTYTByNhomVTFilter(string manhom, string dkfilter, byte loai)
        {
            return DataPortal.Fetch<DMTBVTYTList>(new CriteriaFilter((byte)( loai), manhom, dkfilter));
        }
        public void NewTo(DMTBVTYT _DMTBVTYT)
        {
            if (this.Count == 0)
                _DMTBVTYT.OrderNumber = 1;
            else
            _DMTBVTYT.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMTBVTYT);
        }
        public void UpdatedTo(DMTBVTYT _DMTBVTYT)
        {

            _DMTBVTYT.OrderNumber = this.Items[this.IndexOf(_DMTBVTYT)].OrderNumber;
            this.Items[this.IndexOf(_DMTBVTYT)] = _DMTBVTYT;
        }
        public void RemoveTo(DMTBVTYT _DMTBVTYT)
        {
            this.Items.Remove(_DMTBVTYT);

        }
        private DMTBVTYTList()
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
           
            public CriteriaOther(Byte mIdFind, String mDK)
            {

                _IdFind = mIdFind;
                _DK = "";
                //if (mIdFind == 1)
                //    _DK = " and (a.MAvt like N'" + mDK + "%' or a.MAql like N'" + mDK + "%')";
                //else if (mIdFind == 2)
                //    _DK = " and ltrim(rtrim(TenTM)) like N'" + mDK + "%'";
                //else if (mIdFind == 4)
                //    _DK = " and ltrim(rtrim(TenTM)) like N'" + mDK + "'";
                ////else if ((mIdFind == 3) && (mDK == string.Empty ))
                //else if ((mIdFind == 3) && (mDK != "All"))
                //    _DK = " and A.MaNhom like '%" + mDK + "'";
                //else if (mIdFind == 5)
                //{
                //    _DK = " and A.TENTM  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') +' '+ ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')   like N'" + mDK + "%'";
                //}
                if (mIdFind >= 100)
                    _DK = " a.loai = " + (mIdFind-100).ToString() ;
                else if ((mIdFind == 3) || (mIdFind ==16))
                   _DK = " and (a.MaNhom like N'" + mDK + "%' or a.MAql like N'" + mDK + "%')";
               else if ((mIdFind == 4) || (mIdFind == 17))
                    _DK = " and a.loai ="+ (mIdFind-2).ToString () + "   and ltrim(rtrim(TenTM)) like N'" + mDK + "%'";
              
                //else if ((mIdFind == 3) && (mDK == string.Empty ))
                else if (((mIdFind == 5) || (mIdFind == 18)) && (mDK != "All"))
                    _DK = " and a.loai =" + (mIdFind - 3).ToString() + " and A.MaNhom like '%" + mDK + "'";
                else if (((mIdFind == 5) || (mIdFind == 18)))
                    _DK = " and a.loai =" + (mIdFind - 3).ToString() ;

                else if ((mIdFind == 6) || (mIdFind == 19))
                    _DK = " and a.loai =" + (mIdFind - 4).ToString() + "  and ltrim(rtrim(TenTM)) like N'" + mDK + "'"; 
                else if ((mIdFind == 7) || (mIdFind == 20))
                {
                    _DK = " and a.loai ="+ (mIdFind-5).ToString () + "  and A.TENTM  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') +' '+ ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')   like N'" + mDK + "%'";
                }
                else if(mIdFind == 74)
                {
                    _DK =  mDK;
                }
                
            }
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
            private string _ten;
            public string ten
            {
                get
                {
                    return _ten;
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

            public OtherCriteria(Byte mIdFind,String ten, String mDK)
            {

                _IdFind = mIdFind;
                _DK = "";
                //if (mIdFind == 1)
                //    _DK = " and (a.MAvt like N'" + ten + "%' or a.MAql like N'" + ten + "%')";
                //else if (mIdFind == 2)
                //    _DK = " and ltrim(rtrim(TenTM)) like N'" + ten + "%'";
                //else if (mIdFind == 4)
                //    _DK = " and ltrim(rtrim(TenTM)) like N'" + ten + "'";
                ////else if ((mIdFind == 3) && (ten == string.Empty ))
                //else if ((mIdFind == 3) && (ten != "All"))
                //    _DK = " and A.MaNhom like '%" + ten + "'";
                //else if (mIdFind == 5)
                //{
                //    _DK = " and A.TENTM  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') +' '+ ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')   like N'" + ten + "%'";
                //}
                if (mIdFind >= 100)
                    _DK = " a.loai = " + (mIdFind - 100).ToString();
                else if ((mIdFind == 3) || (mIdFind == 16))
                    _DK = " and a.loai =" + (mIdFind - 1).ToString() + " and (a.MAvt like N'" + ten + "%' or a.MAql like N'" + ten + "%')";
                else if ((mIdFind == 4) || (mIdFind == 17))
                    _DK = " and a.loai =" + (mIdFind - 2).ToString() + "   and ltrim(rtrim(TenTM)) like N'" + ten + "%'";

                //else if ((mIdFind == 3) && (ten == string.Empty ))
                else if (((mIdFind == 5) || (mIdFind == 18)) && (ten != "All"))
                    _DK = " and a.loai =" + (mIdFind - 3).ToString() + " and A.MaNhom like '%" + ten + "'";
                else if ((mIdFind == 6) || (mIdFind == 19))
                    _DK = " and a.loai =" + (mIdFind - 4).ToString() + "  and ltrim(rtrim(TenTM)) like N'" + ten + "'";
                else if ((mIdFind == 7) || (mIdFind == 20))
                {
                    _DK = " and a.loai =" + (mIdFind - 5).ToString() + "  and A.TENTM  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') +' '+ ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')   like N'" + ten + "%'";
                }
                _DK = _DK + mDK;
            }
        }

        //--exec spDMTBVTYT_FINDS ' and a.mavt like ''%000002'' ',1

        #endregion

        #region CriteriaOther
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
            private string _DKFilter;
            public string DKFilter
            {
                get
                {
                    return _DKFilter;
                }
            }
            private string _ten;
            public string ten
            {
                get
                {
                    return _ten;
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

            public CriteriaFilter(Byte mIdFind, String mDK, String mDKFilter)
            {

                _IdFind = mIdFind;
                _DK = "";
                //if (mIdFind == 1)
                //    _DK = " and (a.MAvt like N'" + mDK + "%' or a.MAql like N'" + mDK + "%')";
                //else if (mIdFind == 2)
                //    _DK = " and ltrim(rtrim(TenTM)) like N'" + mDK + "%'";
                //else if (mIdFind == 4)
                //    _DK = " and ltrim(rtrim(TenTM)) like N'" + mDK + "'";
                ////else if ((mIdFind == 3) && (mDK == string.Empty ))
                //else if ((mIdFind == 3) && (mDK != "All"))
                //    _DK = " and A.MaNhom like '%" + mDK + "'";
                //else if (mIdFind == 5)
                //{
                //    _DK = " and A.TENTM  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') +' '+ ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')   like N'" + mDK + "%'";
                //}
                if (mIdFind >= 100)
                    _DK = " and a.loai = " + (mIdFind - 100).ToString();
                else
                     _DK = " and a.loai = " + mIdFind.ToString();
                _DK = _DK + mDK;
                _DKFilter = mDKFilter;
            }
        }

        //--exec spDMTBVTYT_FINDS ' and a.mavt like ''%000002'' ',1

        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMTBVTYT(HTC.ShareVariables.pub_bQadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMTBVTYT item = new DMTBVTYT(
     i,
     dr.GetString("MaVT") ,
			                                dr.GetString("MaNhom") ,
                                            dr.GetString("TenNhom"),
			                                dr.GetString("MaChungLoai") ,
			                                dr.GetString("TenTM") ,
			                                dr.GetString("tenTA") ,
			                                dr.GetString("MaNSX") ,
			                                dr.GetDecimal("Nguong") ,
			                                dr.GetString("MaDVT") ,
			                                dr.GetBoolean("ApDungGoi") ,
			                                dr.GetBoolean("Handung") ,
			                                dr.GetDecimal("Gianhap") ,
			                                dr.GetSmartDate("Ngaynhap", true) ,
			                                dr.GetDecimal("Gianhap1") ,
			                                dr.GetSmartDate("Ngaynhap1", true) ,
			                                dr.GetDecimal("Gianhap2") ,
			                                dr.GetSmartDate("Ngaynhap2", true) ,
			                                dr.GetDecimal("DonGiaTT") ,
			                                dr.GetDecimal("DonGiaTT1") ,
			                                dr.GetDecimal("DongiaThuT") ,
			                                dr.GetDecimal("DongiaPhauT") ,
			                                dr.GetDecimal("DongiaCLS") ,
			                                dr.GetDecimal("GiaQuay") ,
			                                dr.GetDecimal("GiaQuay1") ,
			                                dr.GetString("Khoban") ,
			                                dr.GetString("Khophat") ,
			                                dr.GetBoolean("VTThuT") ,
			                                dr.GetBoolean("VTPhauT") ,
			                                dr.GetBoolean("VTCLS") ,
			                                dr.GetBoolean("VTDuoc") ,
			                                dr.GetBoolean("VTBan") ,
			                                dr.GetBoolean("DuyetNgoaiT") ,
			                                dr.GetBoolean("DuyetNoiT") ,
			                                dr.GetString("Ghichu") ,
			                                dr.GetString("MaMay"),
			                                dr.GetBoolean("Huy") ,
			                                dr.GetSmartDate("NgaySD", true) ,
			                                dr.GetString("NguoiSD") ,
			                                dr.GetSmartDate("NgaySD1", true) ,
			                                dr.GetString("NguoiSD1") ,
			                                dr.GetSmartDate("NgayLap", true) ,
			                                dr.GetString("NguoiLap") ,
			                                dr.GetSmartDate("NgayHuy", true) ,
			                                dr.GetString("NguoiHuy") ,
			                                dr.GetBoolean("VTNoiT") ,
			                                dr.GetString("MaLH"),
     dr.GetString("tendvt") ,
     dr.GetString("HamLuong") ,
			                                dr.GetString("MaDVTHL") ,
     dr.GetString("tendvthl")  ,
     dr.GetString("TenNguoiSD"),
     dr.GetString("TenNguoiLap"),
     dr.GetString("TenNguoiHuy"),
     dr.GetString("TenNSX"),
     dr.GetBoolean("KhongSD"),
     dr.GetString("maql"),
     dr.GetString("quycach"),

     dr.GetString("madvt2"),
     dr.GetDecimal("Quydoi"),
     dr.GetString("TenDVT2")
         );
                   
                    this.Add(item);
                    i += 1;
                }
                //IsReadOnly = true;
            }
            
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMTBVTYT(criteria.DK,criteria.qadmin    )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMTBVTYT item = new DMTBVTYT(
     i,
    dr.GetString("MaVT"),
     dr.GetString("MaNhom"),
     dr.GetString("TenNhom"),
     dr.GetString("MaChungLoai"),
     dr.GetString("TenTM"),
     dr.GetString("tenTA"),
     dr.GetString("MaNSX"),
     dr.GetDecimal("Nguong"),
     dr.GetString("MaDVT"),
     dr.GetBoolean("ApDungGoi"),
     dr.GetBoolean("Handung"),
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
     dr.GetBoolean("VTThuT"),
     dr.GetBoolean("VTPhauT"),
     dr.GetBoolean("VTCLS"),
     dr.GetBoolean("VTDuoc"),
     dr.GetBoolean("VTBan"),
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
     dr.GetBoolean("VTNoiT"),
     dr.GetString("MaLH"), 
     dr.GetString("tendvt"),
     dr.GetString("HamLuong"),
     dr.GetString("MaDVTHL"),
     dr.GetString("TENDVThl"),
     dr.GetString("TenNguoiSD"),
     dr.GetString("TenNguoiLap"),
     dr.GetString("TenNguoiHuy"),
     dr.GetString("TenNSX"),
     dr.GetBoolean("KhongSD"),
     dr.GetString("maql"),
     dr.GetString("quycach"),
     dr.GetString("madvt2"),
     dr.GetDecimal("quydoi"),
     dr.GetString("TenDVT2")

         );

                    this.Add(item);
                    i += 1;
                }
                //IsReadOnly = true;
            }
           

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMTBVTYT(criteria.DK, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMTBVTYT item = new DMTBVTYT(
     i,
    dr.GetString("MaVT"),
     dr.GetString("MaNhom"),
     dr.GetString("TenNhom"),
     dr.GetString("MaChungLoai"),
     dr.GetString("TenTM"),
     dr.GetString("tenTA"),
     dr.GetString("MaNSX"),
     dr.GetDecimal("Nguong"),
     dr.GetString("MaDVT"),
     dr.GetBoolean("ApDungGoi"),
     dr.GetBoolean("Handung"),
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
     dr.GetBoolean("VTThuT"),
     dr.GetBoolean("VTPhauT"),
     dr.GetBoolean("VTCLS"),
     dr.GetBoolean("VTDuoc"),
     dr.GetBoolean("VTBan"),
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
     dr.GetBoolean("VTNoiT"),
     dr.GetString("MaLH"),
     dr.GetString("tendvt"),
     dr.GetString("HamLuong"),
     dr.GetString("MaDVTHL"),
     dr.GetString("TENDVThl"),
     dr.GetString("TenNguoiSD"),
     dr.GetString("TenNguoiLap"),
     dr.GetString("TenNguoiHuy"),
     dr.GetString("TenNSX"),
     dr.GetBoolean("KhongSD"),
     dr.GetString("maql"),
     dr.GetString("quycach"),
     dr.GetString("madvt2"),
     dr.GetDecimal("quydoi"),
     dr.GetString("TenDVT2")

         );

                    this.Add(item);
                    i += 1;
                }
                //IsReadOnly = true;
            }


            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        private void DataPortal_Fetch(CriteriaFilter criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMTBVTYTFilter(criteria.DK, criteria.DKFilter, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                if (dr.Read())
                {
                    _record = dr.GetInt32("record");
                }
                if (dr.NextResult())
                while (dr.Read())
                {
                    DMTBVTYT item = new DMTBVTYT(
     i,
    dr.GetString("MaVT"),
     dr.GetString("MaNhom"),
     dr.GetString("TenNhom"),
     dr.GetString("MaChungLoai"),
     dr.GetString("TenTM"),
     dr.GetString("tenTA"),
     dr.GetString("MaNSX"),
     dr.GetDecimal("Nguong"),
     dr.GetString("MaDVT"),
     dr.GetBoolean("ApDungGoi"),
     dr.GetBoolean("Handung"),
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
     dr.GetBoolean("VTThuT"),
     dr.GetBoolean("VTPhauT"),
     dr.GetBoolean("VTCLS"),
     dr.GetBoolean("VTDuoc"),
     dr.GetBoolean("VTBan"),
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
     dr.GetBoolean("VTNoiT"),
     dr.GetString("MaLH"),
     dr.GetString("tendvt"),
     dr.GetString("HamLuong"),
     dr.GetString("MaDVTHL"),
     dr.GetString("TENDVThl"),
     dr.GetString("TenNguoiSD"),
     dr.GetString("TenNguoiLap"),
     dr.GetString("TenNguoiHuy"),
     dr.GetString("TenNSX"),
     dr.GetBoolean("KhongSD"),
     dr.GetString("maql"),
     dr.GetString("quycach"),
     dr.GetString("madvt2"),
     dr.GetDecimal("quydoi"),
     dr.GetString("TenDVT2")

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
