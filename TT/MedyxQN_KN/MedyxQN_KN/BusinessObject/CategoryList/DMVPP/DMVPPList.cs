using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMVPPList : BusinessListBase<DMVPPList, DMVPP>
    {
        #region Factory Methods
        public static DMVPPList GetAllDMVPP()
        {
            return DataPortal.Fetch<DMVPPList>(new Criteria());
        }
        public static DMVPPList FindDMVPPMa(string Ma)
        {
            return DataPortal.Fetch<DMVPPList>(new CriteriaOther(1, Ma));
        }
        public static DMVPPList FindDMVPPTen(string Ten)
        {
            return DataPortal.Fetch<DMVPPList>(new CriteriaOther(2, Ten));
        }
        public static DMVPPList FindDMVPPTenD(string Ten)
        {
            return DataPortal.Fetch<DMVPPList>(new CriteriaOther(4, Ten));

        }
        public static DMVPPList FindDMVPPTenDu(string Ten)
        {
            return DataPortal.Fetch<DMVPPList>(new CriteriaOther(5, Ten));
        }
        public static DMVPPList FindDMVPPTen(string Ten, string dk)
        {
            return DataPortal.Fetch<DMVPPList>(new OtherCriteria(2, Ten,dk));
        }
        public static DMVPPList FindDMVPPTenD(string Ten, string dk)
        {
            return DataPortal.Fetch<DMVPPList>(new OtherCriteria(4, Ten,dk));

        }
        public static DMVPPList FindDMVPPTenDu(string Ten,string dk)
        {
            return DataPortal.Fetch<DMVPPList>(new OtherCriteria(5, Ten,dk));
        }
        public static DMVPPList FindDMVPPByNhomVTYT(string manhom)
        {
            return DataPortal.Fetch<DMVPPList>(new CriteriaOther(3, manhom));
        }
       
        public void NewTo(DMVPP _DMVPP)
        {
            if (this.Count == 0)
                _DMVPP.OrderNumber = 1;
            else
            _DMVPP.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMVPP);
        }
        public void UpdatedTo(DMVPP _DMVPP)
        {

            _DMVPP.OrderNumber = this.Items[this.IndexOf(_DMVPP)].OrderNumber;
            this.Items[this.IndexOf(_DMVPP)] = _DMVPP;
        }
        public void RemoveTo(DMVPP _DMVPP)
        {
            this.Items.Remove(_DMVPP);

        }
        private DMVPPList()
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
                if (mIdFind == 1)
                   _DK = " and (a.MAvt like N'" + mDK + "%' or a.MAql like N'" + mDK + "%')";
                else if (mIdFind == 2)
                    _DK = " and ltrim(rtrim(TenTM)) like N'" + mDK + "%'";
                else if (mIdFind == 4)
                    _DK = " and ltrim(rtrim(TenTM)) like N'" + mDK + "'"; 
                //else if ((mIdFind == 3) && (mDK == string.Empty ))
                else if ((mIdFind == 3) && (mDK != "All"))
                    _DK = " and A.MaNhom like '%" + mDK + "'";
                else if (mIdFind == 5)
                {
                    _DK = " and A.TENTM  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') +' '+ ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')   like N'" + mDK + "%'";
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
                if (mIdFind == 1)
                    _DK = " and (a.MAvt like N'" + ten + "%' or a.MAql like N'" + ten + "%')";
                else if (mIdFind == 2)
                    _DK = " and ltrim(rtrim(TenTM)) like N'" + ten + "%'";
                else if (mIdFind == 4)
                    _DK = " and ltrim(rtrim(TenTM)) like N'" + ten + "'";
                //else if ((mIdFind == 3) && (ten == string.Empty ))
                else if ((mIdFind == 3) && (ten != "All"))
                    _DK = " and A.MaNhom like '%" + ten + "'";
                else if (mIdFind == 5)
                {
                    _DK = " and A.TENTM  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'') +' '+ ISNULL(A.QUYCACH,'') + ' ' + ISNULL(E.TENNSX,'')   like N'" + ten + "%'";
                }
                _DK = _DK + mDK;
            }
        }

        //--exec spDMVPP_FINDS ' and a.mavt like ''%000002'' ',1

        #endregion

        

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMVPP(HTC.ShareVariables.pub_bQadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMVPP item = new DMVPP(
     i,
     dr.GetString("MaVT") ,
			                                dr.GetString("MaNhom") ,
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
     dr.GetDecimal("Quydoi")
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMVPP(criteria.DK,criteria.qadmin    )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMVPP item = new DMVPP(
     i,
    dr.GetString("MaVT"),
     dr.GetString("MaNhom"),
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
     dr.GetDecimal("quydoi")

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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMVPP(criteria.DK, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMVPP item = new DMVPP(
     i,
    dr.GetString("MaVT"),
     dr.GetString("MaNhom"),
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
     dr.GetDecimal("quydoi")

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
