using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMHoaChatList : BusinessListBase<DMHoaChatList, DMHoaChat>
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
        public static DMHoaChatList GetAllDMHoaChat()
        {
            return DataPortal.Fetch<DMHoaChatList>(new Criteria());
        }
        public static DMHoaChatList FindDMHoaChatMa(string Ma)
        {
            return DataPortal.Fetch<DMHoaChatList>(new CriteriaOther(1, Ma));
        }
        public static DMHoaChatList FindDMHoaChatTen(string Ten)
        {
            return DataPortal.Fetch<DMHoaChatList>(new CriteriaOther(2, Ten));
        }
        public static DMHoaChatList FindDMHoaChatTenD(string Ten)
        {
            return DataPortal.Fetch<DMHoaChatList>(new CriteriaOther(4, Ten));
        }
        public static DMHoaChatList FindDMHoaChatTenDu(string Ten)
        {
            return DataPortal.Fetch<DMHoaChatList>(new CriteriaOther(5, Ten));
        }
        public static DMHoaChatList FindDMHoaChatByNhomHC(string manhom)
        {
            return DataPortal.Fetch<DMHoaChatList>(new CriteriaOther(3, manhom));
        }
        // hoa chat vat tu va hoa chat vat tu
        public static DMHoaChatList GetAllDMHoaChat(byte loai)
        {
            return DataPortal.Fetch<DMHoaChatList>(new CriteriaOther((byte)(loai + 100), ""));
        }
        public static DMHoaChatList FindDMHoaChatMa(string Ma, byte loai)
        {
            return DataPortal.Fetch<DMHoaChatList>(new CriteriaOther((byte)(1 + loai), Ma));
        }
        public static DMHoaChatList FindDMHoaChatTen(string Ten, byte loai)
        {
            return DataPortal.Fetch<DMHoaChatList>(new CriteriaOther((byte)(2 + loai), Ten));
        }
        public static DMHoaChatList FindDMHoaChatTenD(string Ten, byte loai)
        {
            return DataPortal.Fetch<DMHoaChatList>(new CriteriaOther((byte)(4 + loai), Ten));
        
        }
        public static DMHoaChatList FindDMHoaChatByNhomHC(string manhom, byte loai)
        {
            return DataPortal.Fetch<DMHoaChatList>(new CriteriaOther((byte)(3 + loai), manhom));
        }
        public static DMHoaChatList FindDMHoaChatTenDu(string Ten, byte loai)
        {
            return DataPortal.Fetch<DMHoaChatList>(new CriteriaOther((byte)(5 + loai), Ten));
        }
        public static DMHoaChatList FindDMHoaChatbyFilter(string sql, string dkfilter, byte loai, Boolean qadmin)
        {
            return DataPortal.Fetch<DMHoaChatList>(new CriteriaFilter((byte)( loai), sql, dkfilter,qadmin));
        }
        public static DMHoaChatList FindDMHoaChatByNhomHCFilter(string manhom, string dkfilter, byte loai, Boolean qadmin)
        {
            return DataPortal.Fetch<DMHoaChatList>(new CriteriaFilter((byte)(loai), manhom, dkfilter, qadmin));
        }
        public void NewTo(DMHoaChat _DMHoaChat)
        {
            if (this.Count == 0)
                _DMHoaChat.OrderNumber = 1;
            else
            _DMHoaChat.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMHoaChat);
        }
        public void UpdatedTo(DMHoaChat _DMHoaChat)
        {

            _DMHoaChat.OrderNumber = this.Items[this.IndexOf(_DMHoaChat)].OrderNumber;
            this.Items[this.IndexOf(_DMHoaChat)] = _DMHoaChat;
        }
        public void RemoveTo(DMHoaChat _DMHoaChat)
        {
            this.Items.Remove(_DMHoaChat);

        }
        private DMHoaChatList()
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
                 //}
                //if (mIdFind == 1)
                //    _DK = " and a.MaHC like N'" + mDK + "%'";
                //else if (mIdFind == 2)
                //    _DK = " and ltrim(rtrim(a.TenTM)) like N'" + mDK + "%'";
                //else if ((mIdFind == 3) && (mDK != "All"))
                //    _DK = " and A.MaNhom like '%" + mDK + "'";
                //else if (mIdFind == 4)
                //    _DK = " and ltrim(rtrim(a.TenTM)) like N'" + mDK + "'";
                //else if (mIdFind == 5)
                //{
                //    _DK = " and A.TENTM  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') +' '+ ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')   like N'" + mDK + "%'";
                //}
                if (mIdFind >= 100)
                    _DK = " a.loai = " + (mIdFind-100).ToString() ;
                else if ((mIdFind == 4) || (mIdFind == 17))
                    _DK =  " and a.loai =" + (mIdFind - 1).ToString() + " and a.MaHC like N'" + mDK + "%'";
                else if ((mIdFind == 5) || (mIdFind == 18))
                    _DK =  " and a.loai =" + (mIdFind - 2).ToString() + " and ltrim(rtrim(a.TenTM)) like N'" + mDK + "%'";
                else if (((mIdFind == 6) || (mIdFind == 19)) && (mDK != "All"))
                    _DK = " and a.loai =" + (mIdFind - 3).ToString() + " and A.MaNhom like '%" + mDK + "'";
                else if (((mIdFind == 6) || (mIdFind == 19)) )
                    _DK = " and a.loai =" + (mIdFind - 3).ToString();
                else if ((mIdFind == 7) || (mIdFind == 20))
                    _DK =  " and a.loai =" + (mIdFind - 4).ToString() + " and ltrim(rtrim(a.TenTM)) like N'" + mDK + "'";
                else if ((mIdFind == 8) || (mIdFind == 21))
                {
                    _DK =  " and a.loai =" + (mIdFind - 5).ToString() + " and A.TENTM  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') +' '+ ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')   like N'" + mDK + "%'";
                }
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
             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }

            public CriteriaFilter(Byte mIdFind, String mDK, String mdkFilter, Boolean qadmin)
            {

                _IdFind = mIdFind;
                _DK = "";
                //}
                //if (mIdFind == 1)
                //    _DK = " and a.MaHC like N'" + mDK + "%'";
                //else if (mIdFind == 2)
                //    _DK = " and ltrim(rtrim(a.TenTM)) like N'" + mDK + "%'";
                //else if ((mIdFind == 3) && (mDK != "All"))
                //    _DK = " and A.MaNhom like '%" + mDK + "'";
                //else if (mIdFind == 4)
                //    _DK = " and ltrim(rtrim(a.TenTM)) like N'" + mDK + "'";
                //else if (mIdFind == 5)
                //{
                //    _DK = " and A.TENTM  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') +' '+ ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')   like N'" + mDK + "%'";
                //}
                if (mIdFind >= 100)
                    _DK = " and a.loai = " + (mIdFind - 100).ToString();
                else
                    _DK = " and  a.loai = " + mIdFind.ToString();
                _DK = _DK + mDK;
                _DKFilter = mdkFilter;
                _qadmin = qadmin;
            }
        }


        #endregion
        

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMHoaChat(HTC.ShareVariables.pub_bQadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMHoaChat item = new DMHoaChat(
                                            i,
                                            dr.GetString("MaHC") ,
			                                dr.GetString("MaNhom") ,
			                                dr.GetString("MaChungLoai") ,
			                                dr.GetString("TenTM") ,
			                                dr.GetString("tenTA") ,
			                                dr.GetString("MaNSX"),
			                                dr.GetString("HamLuong") ,
			                                dr.GetString("MaDVTHL") ,
			                                dr.GetDecimal("Nguong") ,
			                                dr.GetString("MaDVT") ,
			                                dr.GetDecimal("Quydoi") ,
			                                dr.GetString("MaHCgoc") ,
                                            dr.GetString("MaDVTGoc"),
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
			                                dr.GetString("Khoban"),
			                                dr.GetString("Khophat") ,
			                                dr.GetBoolean("HCThuT") ,
			                                dr.GetBoolean("HCPhauT") ,
			                                dr.GetBoolean("HCCLS") ,
			                                dr.GetBoolean("HCDuoc") ,
			                                dr.GetBoolean("HCBan") ,
			                                dr.GetBoolean("DuyetNgoaiT"),
			                                dr.GetBoolean("DuyetNoiT") ,
			                                dr.GetString("Ghichu") ,
			                                dr.GetString("MaMay") ,
			                                dr.GetBoolean("Huy"),
			                                dr.GetSmartDate("NgaySD", true) ,
			                                dr.GetString("NguoiSD") ,
			                                dr.GetSmartDate("NgaySD1", true) ,
			                                dr.GetString("NguoiSD1") ,
			                                dr.GetSmartDate("NgayLap", true) ,
			                                dr.GetString("NguoiLap") ,
			                                dr.GetSmartDate("NgayHuy", true) ,
			                                dr.GetString("NguoiHuy") ,
			                                dr.GetBoolean("HCNoiT") ,
                                            dr.GetString("MaLH"),
                                            dr.GetString("tendvt"),
                                            dr.GetString("tendvthl")  ,
                                            dr.GetString("TenNguoiSD"),
                                            dr.GetString("TenNguoiLap"),
                                            dr.GetString("TenNguoiHuy"),
                                            dr.GetString("TenNSX"),
                                             dr.GetString("quycach"),
                                            dr.GetBoolean("KhongSD"),
                                            dr.GetByte("sothanghd"),
      dr.GetString("mabyte"),
       dr.GetString("quyetdinh"),
       dr.GetString("tentmbh"),
      dr.GetString("mabh"), dr.GetString("matduong"),
       dr.GetString("quyetdinhbh"),
       dr.GetString("tenbyte"),
       dr.GetString("maql")
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMHoaChat(criteria.DK,criteria.qadmin    )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMHoaChat item = new DMHoaChat(
                                            i,
                                            dr.GetString("MaHC"),
                                            dr.GetString("MaNhom"),
                                            dr.GetString("MaChungLoai"),
                                            dr.GetString("TenTM"),
                                            dr.GetString("tenTA"),
                                            dr.GetString("MaNSX"),
                                            dr.GetString("HamLuong"),
                                            dr.GetString("MaDVTHL"),
                                            dr.GetDecimal("Nguong"),
                                            dr.GetString("MaDVT"),
                                            dr.GetDecimal("Quydoi"),
                                            dr.GetString("MaHCgoc"),
                                            dr.GetString("MaDVTGoc"),
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
                                            dr.GetBoolean("HCThuT"),
                                            dr.GetBoolean("HCPhauT"),
                                            dr.GetBoolean("HCCLS"),
                                            dr.GetBoolean("HCDuoc"),
                                            dr.GetBoolean("HCBan"),
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
                                            dr.GetBoolean("HCNoiT"),
                                            dr.GetString("MaLH"),
                                            dr.GetString("tendvt"),
                                            dr.GetString("tendvthl") ,
                                            dr.GetString("TenNguoiSD"),
                                            dr.GetString("TenNguoiLap"),
                                            dr.GetString("TenNguoiHuy"),
                                            dr.GetString("TenNSX"),
                                             dr.GetString("maqg"),
                                            dr.GetBoolean("KhongSD"),
                                            dr.GetByte("sothanghd"),
      dr.GetString("mabyte"),
       dr.GetString("quyetdinh"),
       dr.GetString("tentmbh"),
      dr.GetString("mabh"), dr.GetString("matduong"),
       dr.GetString("quyetdinhbh"),
       dr.GetString("tenbyte"),
       dr.GetString("maql")
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMHoaChatFilter(criteria.DK, criteria.DKFilter, criteria.qadmin)))
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
                    DMHoaChat item = new DMHoaChat(
                                            i,
                                            dr.GetString("MaHC"),
                                            dr.GetString("MaNhom"),
                                            dr.GetString("MaChungLoai"),
                                            dr.GetString("TenTM"),
                                            dr.GetString("tenTA"),
                                            dr.GetString("MaNSX"),
                                            dr.GetString("HamLuong"),
                                            dr.GetString("MaDVTHL"),
                                            dr.GetDecimal("Nguong"),
                                            dr.GetString("MaDVT"),
                                            dr.GetDecimal("Quydoi"),
                                            dr.GetString("MaHCgoc"),
                                            dr.GetString("MaDVTGoc"),
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
                                            dr.GetBoolean("HCThuT"),
                                            dr.GetBoolean("HCPhauT"),
                                            dr.GetBoolean("HCCLS"),
                                            dr.GetBoolean("HCDuoc"),
                                            dr.GetBoolean("HCBan"),
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
                                            dr.GetBoolean("HCNoiT"),
                                            dr.GetString("MaLH"),
                                            dr.GetString("tendvt"),
                                            dr.GetString("tendvthl"),
                                            dr.GetString("TenNguoiSD"),
                                            dr.GetString("TenNguoiLap"),
                                            dr.GetString("TenNguoiHuy"),
                                            dr.GetString("TenNSX"),
                                             dr.GetString("maqg"),
                                            dr.GetBoolean("KhongSD"),
                                            dr.GetByte("sothanghd"),
      dr.GetString("mabyte"),
       dr.GetString("quyetdinh"),
       dr.GetString("tentmbh"),
      dr.GetString("mabh"), dr.GetString("matduong"),
       dr.GetString("quyetdinhbh"),
       dr.GetString("tenbyte"),
       dr.GetString("maql")
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
