using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMCNKList : BusinessListBase<DMCNKList, DMCNK>
    {
        #region Factory Methods
        public static DMCNKList GetAllDMCNK()
        {
            return DataPortal.Fetch<DMCNKList>(new Criteria());
        }
        public static DMCNKList FindDMCNKMa(string Ma)
        {
            return DataPortal.Fetch<DMCNKList>(new CriteriaOther(1, Ma));
        }
        public static DMCNKList FindDMCNKDK(string DK)
        {
            return DataPortal.Fetch<DMCNKList>(new CriteriaOther(7, DK));
        }
        public static DMCNKList FindDMCNKMaLoai(string Ma,string makho)
        {
            if ((makho =="03" ) || (makho =="05"))
            return DataPortal.Fetch<DMCNKList>(new CriteriaOther(6, " AND A.MACHUNGLOAI ='00001' and (a.MAvt like N'" + Ma + "%' or a.MAql like N'" + Ma + "%')"));
           
               
                 else if (makho =="09" )
            return DataPortal.Fetch<DMCNKList>(new CriteriaOther(6, " AND A.MACHUNGLOAI ='00003' and (a.MAvt like N'" + Ma + "%' or a.MAql like N'" + Ma + "%')"));
           
                      else if (makho =="07" )
            return DataPortal.Fetch<DMCNKList>(new CriteriaOther(6, " AND A.MACHUNGLOAI ='00002' and (a.MAvt like N'" + Ma + "%' or a.MAql like N'" + Ma + "%')"));
        return DataPortal.Fetch<DMCNKList>(new CriteriaOther(6, " AND A.MACHUNGLOAI ='00004' and (a.MAvt like N'" + Ma + "%' or a.MAql like N'" + Ma + "%')"));
           


        }
        public static DMCNKList FindDMCNKTen(string Ten)
        {
            return DataPortal.Fetch<DMCNKList>(new CriteriaOther(2, Ten));
        }
        public static DMCNKList FindDMCNKTenLoai(string Ten,string makho)
        {
              if ((makho =="03" ) || (makho =="05"))
                         return DataPortal.Fetch<DMCNKList>(new CriteriaOther(6, " and  A.MACHUNGLOAI ='00001'  A.TENTM + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDV,'') like N'" + Ten + "%'"));
          
           else if (makho =="09" )
                         return DataPortal.Fetch<DMCNKList>(new CriteriaOther(6, " and  A.MACHUNGLOAI ='00003'  A.TENTM + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDV,'') like N'" + Ten + "%'"));
          
                else if (makho =="07" )
                         return DataPortal.Fetch<DMCNKList>(new CriteriaOther(6, " and  A.MACHUNGLOAI ='00002'  A.TENTM + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDV,'') like N'" + Ten + "%'"));
                  return DataPortal.Fetch<DMCNKList>(new CriteriaOther(6, " and  A.MACHUNGLOAI ='00004' and A.TENTM + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDV,'') like N'" + Ten + "%'"));
          
        }
          public static DMCNKList FindDMCNKTenLoaiD(string Ten,string makho)
        {
              if ((makho =="03" ) || (makho =="05"))
                  return DataPortal.Fetch<DMCNKList>(new CriteriaOther(6, " and  A.MACHUNGLOAI ='00001' and  A.TENTM + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDV,'') like N'" + Ten + "'"));
          
           else if (makho =="09" )
                         return DataPortal.Fetch<DMCNKList>(new CriteriaOther(6, " and  A.MACHUNGLOAI ='00003' and A.TENTM + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDV,'') like N'" + Ten + "'"));
          
                else if (makho =="07" )
                         return DataPortal.Fetch<DMCNKList>(new CriteriaOther(6, " and  A.MACHUNGLOAI ='00002' and  A.TENTM + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDV,'') like N'" + Ten + "'"));
                    return DataPortal.Fetch<DMCNKList>(new CriteriaOther(6, " and  A.MACHUNGLOAI ='00004' and A.TENTM + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDV,'') like N'" + Ten + "'"));
        
        }
        public static DMCNKList FindDMCNKTenD(string Ten)
        {
            return DataPortal.Fetch<DMCNKList>(new CriteriaOther(4, Ten));

        }
        public static DMCNKList FindDMCNKTenDu(string Ten)
        {
            return DataPortal.Fetch<DMCNKList>(new CriteriaOther(5, Ten));
        }
        public static DMCNKList FindDMCNKByNhomCNK(string manhom)
        {
            return DataPortal.Fetch<DMCNKList>(new CriteriaOther(3, manhom));
        }
       
        public void NewTo(DMCNK _DMCNK)
        {
            if (this.Count == 0)
                _DMCNK.OrderNumber = 1;
            else
            _DMCNK.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMCNK);
        }
        public void UpdatedTo(DMCNK _DMCNK)
        {

            _DMCNK.OrderNumber = this.Items[this.IndexOf(_DMCNK)].OrderNumber;
            this.Items[this.IndexOf(_DMCNK)] = _DMCNK;
        }
        public void RemoveTo(DMCNK _DMCNK)
        {
            this.Items.Remove(_DMCNK);

        }
        private DMCNKList()
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
                    _DK = " and A.TENTM  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDV,'')  like N'" + mDK + "%'";
                }
                 else if (mIdFind == 6)
                {
                    _DK = mDK;
                }
                else if (mIdFind == 7)
                {
                    _DK = mDK;
                }
                
            }
        }

        //--exec spDMCNK_FINDS ' and a.mavt like ''%000002'' ',1

        #endregion

        

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMCNK(HTC.ShareVariables.pub_bQadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMCNK item = new DMCNK(
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
     dr.GetString("TENDVTTHL"),
     dr.GetString("TenNguoiSD"),
     dr.GetString("TenNguoiLap"),
     dr.GetString("TenNguoiHuy"),
     dr.GetString("TenNSX"),
     dr.GetBoolean("KhongSD"),
     dr.GetString("maql"),
     dr.GetString("QuyCach")

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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMCNK(criteria.DK,criteria.qadmin    )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMCNK item = new DMCNK(
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
     dr.GetString("TENDVTTHL"),
     dr.GetString("TenNguoiSD"),
     dr.GetString("TenNguoiLap"),
     dr.GetString("TenNguoiHuy"),
     dr.GetString("TenNSX"),
     dr.GetBoolean("KhongSD"),
     dr.GetString("maql"),
     dr.GetString("QuyCach")

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
