using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;


namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMDichVuList : BusinessListBase<DMDichVuList, DMDichVu>
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
        public static DMDichVuList GetAllDMDichVu()
        {
            return DataPortal.Fetch<DMDichVuList>(new Criteria());
        }
        // tim theo dieu kien ten
        public static DMDichVuList FindDMDichVuByTen(string TenDV)
        {
            return DataPortal.Fetch<DMDichVuList>(new CriteriaOther(2,TenDV));
        }
        public static DMDichVuList FindDMDichVuByTenD(string TenDV)
        {
            return DataPortal.Fetch<DMDichVuList>(new CriteriaOther(4, TenDV));
        }
        public static DMDichVuList FindDMDichVuByMa(string MaDV)
        {
            return DataPortal.Fetch<DMDichVuList>(new CriteriaOther(1,MaDV));
        }
        public static DMDichVuList FindDMDichVuByMaBA(string Ma)
        {
            return DataPortal.Fetch<DMDichVuList>(new CriteriaOther(40, Ma));
        }
        public static DMDichVuList FindDMDichVuByNhomDV(string maNhomDV)
        {
            return DataPortal.Fetch<DMDichVuList>(new CriteriaOther(3, maNhomDV));
        }
        public static DMDichVuList FindDMDichVuLyLieu(string masokham)
        {
            return DataPortal.Fetch<DMDichVuList>(new CriteriaOther(5, masokham));
        }
        public static DMDichVuList FindDMDichVuByNhomDVFilter(string maNhomDV,string dkfilter,Boolean qadmin)
        {
            return DataPortal.Fetch<DMDichVuList>(new CriteriaFilter(3, maNhomDV, dkfilter,qadmin));
        }
        public static DMDichVuList FindDMDichVuByFilter(string sql, string dkfilter, Boolean qadmin)
        {
            return DataPortal.Fetch<DMDichVuList>(new CriteriaFilter(6, sql, dkfilter, qadmin));
        }
        public void NewTo(DMDichVu _DMDichVu)
        {
            if (this.Count == 0)
                _DMDichVu.OrderNumber = 1;
            else
            _DMDichVu.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMDichVu);
        }
        public void UpdatedTo(DMDichVu _DMDichVu)
        {

            _DMDichVu.OrderNumber = this.Items[this.IndexOf(_DMDichVu)].OrderNumber;
            this.Items[this.IndexOf(_DMDichVu)] = _DMDichVu;
        }
        public void RemoveTo(DMDichVu _DMDichVu)
        {
            this.Items.Remove(_DMDichVu);

        }
        public DMDichVu Contains(string MaDV)
        {
            foreach (DMDichVu obj in this)
                if (obj.MaDV == MaDV)
                    return obj;
            return null;
        }
        private DMDichVuList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        #region Criteria
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
           
        }
        #endregion
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
               if (mIdFind == 40)
                    _DK = "  a.madv  in (select distinct madv from benhan_c where maba ='"+ mDK +"')";

                else if (mIdFind == 1)
                    _DK = "(MADV like N'%" + mDK + "%'  OR b.TENTAT LIKE N'" + mDK + "%')";
                else if  (mIdFind == 2) 
                        _DK = "ltrim(rtrim(TenDV)) like N'" + mDK + "%'";
                else if ((mIdFind == 3) && (mDK != "All")  )
                        _DK = "ltrim(rtrim(A.MaNhomDV)) like N'" + mDK + "%'";
                else if (mIdFind == 4)
                        _DK = "ltrim(rtrim(TenDV)) like N'" + mDK + "'";
                 else if (mIdFind == 5)
                        _DK = " (MADV in (select madv from khambenh_c where masokham = N'" + mDK.ToString ().Substring(0,16) + "' and makhoa = = N'" + mDK.ToString ().Substring(16,mDK .Length -16) + "')) ";

            }
        }
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
            //public Criteria(Boolean mqadmin)
            //{

            //    _qadmin = mqadmin;
            //}
            public CriteriaFilter(Byte mIdFind, String mDK, String mDKFilter,Boolean qadmin)
            {

                _IdFind = mIdFind;
                if (mIdFind == 1)
                    _DK = "and (MADV like N'%" + mDK + "%'  OR b.TENTAT LIKE N'" + mDK + "%')";
                else if (mIdFind == 2)
                    _DK = " andltrim(rtrim(TenDV)) like N'" + mDK + "%'";
                else if ((mIdFind == 3) && (mDK != "All"))
                    _DK = "and ltrim(rtrim(A.MaNhomDV)) like N'" + mDK + "%'";
                else if (mIdFind == 4)
                    _DK = " andltrim(rtrim(TenDV)) like N'" + mDK + "'";
                else if (mIdFind == 5)
                    _DK = " and (MADV in (select madv from khambenh_c where masokham = N'" + mDK.ToString().Substring(0, 16) + "' and makhoa = = N'" + mDK.ToString().Substring(16, mDK.Length - 16) + "')) ";
                else if (mIdFind == 6)
                    _DK =  mDK ;
                _DKFilter = mDKFilter;
                _qadmin = qadmin;
            }
        }
        #endregion
        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDichVu(criteria.qadmin)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMDichVu item = new DMDichVu(
     i,
     dr.GetString("MaDV"),
			                                dr.GetString("MaNhomDV"),
			                                dr.GetString("TenDV"),
     dr.GetString("TenTA"),
                                            dr.GetString("MaBYTe"),
     
       dr.GetString("quyetdinh"),
       dr.GetString("tendvbh"),

     dr.GetBoolean("NhapSL"),
			                                dr.GetString("TenTat"),
     dr.GetString("SoTban") ,
     dr.GetString("MaLH"),
			                                dr.GetDecimal("DongiaTT"),
			                                dr.GetDecimal("DongiaTT1"),
			                                dr.GetSmartDate("NgayTT1"),
			                                dr.GetString("Makhoa"),
      dr.GetString("Makhoa087"),
       dr.GetString("MakhoaNG"),
       dr.GetString("MakhoaLM"),
      dr.GetString("MakhoaLM087"),
       dr.GetString("MakhoaLMNG"),
			                                dr.GetString("MaBS"),
			                                dr.GetString("Machuyenkhoa"),
     dr.GetString("Machungloai"),
			                                dr.GetByte("Loai"),
     dr.GetByte("NoiThucHien"),
     dr.GetString("MaCQ") ,
     dr.GetString("MaBenhPham") ,
     dr.GetBoolean("KTCao"),
			                                dr.GetString("ChisocaoNu"),
			                                dr.GetString("ChisocaoNam"),
			                                dr.GetString("ChisothapNu"),
			                                dr.GetString("ChisothapNam"),
			                                dr.GetString("Donvi"),
     dr.GetBoolean("ApdungGoi"),
     dr.GetBoolean("DichVuGui"),
			                                dr.GetByte("LoaiKQ"),
			                                dr.GetString("FormSudung"),
                                             dr.GetString("FormSudung087"),
     dr.GetDecimal("Hoahong"),
     dr.GetDecimal("GTHoahong"),
			                                dr.GetBoolean("TToanSau"),
			                                dr.GetBoolean("TToanNgay"),
			                                dr.GetBoolean("BCThu"),
			                                dr.GetBoolean("InThu"),
			                                dr.GetString("Ghichu"),
			                                dr.GetString("MaMay"),
			                                dr.GetSmartDate("NgayHuy"),
			                                dr.GetString("NguoiHuy"),
			                                dr.GetSmartDate("NgayLap"),
			                                dr.GetString("NguoiLap"),
			                                dr.GetSmartDate("NgaySD",false),
			                                dr.GetString("NguoiSD"),
     dr.GetSmartDate("NgaySD1", false),
     dr.GetString("NguoiSD1"),
     dr.GetBoolean("Huy"),
     dr.GetBoolean("LayMauTT"),
     dr.GetBoolean("apdungpk"),
     dr.GetBoolean("apdungnt"),
     dr.GetBoolean("apdungnk"),
     dr.GetBoolean("apdungsuagia"),
     dr.GetString("maloaitt"),
      dr.GetString("mabh"), dr.GetString("matduong"),
       dr.GetString("quyetdinhbh"),
       dr.GetString("tenbyte"),
       dr.GetString("MAKHTH"),
                                            dr.GetString("MaCSBH"),
                                            dr.GetString("TenCSBH"),
                                            dr.GetString("MaMayXNBH")                   
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

            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDichVu(criteria.DK,criteria.qadmin)))         
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMDichVu item = new DMDichVu(
    i,
     dr.GetString("MaDV"),
     dr.GetString("MaNhomDV"),
     dr.GetString("TenDV"),
     dr.GetString("TenTA"),
     dr.GetString("MaBYTe"),
      dr.GetString("quyetdinh"),
       dr.GetString("tendvbh"),
     dr.GetBoolean("NhapSL"),
     dr.GetString("TenTat"),
     dr.GetString("SoTban"),
     dr.GetString("MaLH"),
     dr.GetDecimal("DongiaTT"),
     dr.GetDecimal("DongiaTT1"),
     dr.GetSmartDate("NgayTT1"),
     dr.GetString("Makhoa"),
      dr.GetString("Makhoa087"),
       dr.GetString("MakhoaNG"),
        dr.GetString("MakhoaLM"),
      dr.GetString("MakhoaLM087"),
       dr.GetString("MakhoaLMNG"),
     dr.GetString("MaBS"),
     dr.GetString("Machuyenkhoa"),
     dr.GetString("Machungloai"),
     dr.GetByte("Loai"),
     dr.GetByte("NoiThucHien"),
     dr.GetString("MaCQ"),
     dr.GetString("MaBenhPham"),
     dr.GetBoolean("KTCao"),
     dr.GetString("ChisocaoNu"),
     dr.GetString("ChisocaoNam"),
     dr.GetString("ChisothapNu"),
     dr.GetString("ChisothapNam"),
     dr.GetString("Donvi"),
     dr.GetBoolean("ApdungGoi"),
     dr.GetBoolean("DichVuGui"),
     dr.GetByte("LoaiKQ"),
     dr.GetString("FormSudung"),
      dr.GetString("FormSudung087"),
     dr.GetDecimal("Hoahong"),
     dr.GetDecimal("GTHoahong"),
     dr.GetBoolean("TToanSau"),
     dr.GetBoolean("TToanNgay"),
     dr.GetBoolean("BCThu"),
     dr.GetBoolean("InThu"),
     dr.GetString("Ghichu"),
     dr.GetString("MaMay"),
     dr.GetSmartDate("NgayHuy"),
     dr.GetString("NguoiHuy"),
     dr.GetSmartDate("NgayLap"),
     dr.GetString("NguoiLap"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),
     dr.GetSmartDate("NgaySD1", false),
     dr.GetString("NguoiSD1"),
     dr.GetBoolean("Huy"),
     dr.GetBoolean("LayMauTT"),
     dr.GetBoolean("apdungpk"),
     dr.GetBoolean("apdungnt"),
     dr.GetBoolean("apdungnk"),
     dr.GetBoolean("apdungsuagia"),
     dr.GetString("maloaitt"),
      dr.GetString("mabh"), dr.GetString("matduong"),
       dr.GetString("quyetdinhbh"),
       dr.GetString("tenbyte"),
       dr.GetString("MAKHTH"),
                                            dr.GetString("MaCSBH"),
                                            dr.GetString("TenCSBH"),
                                            dr.GetString("MaMayXNBH")
     ); 
      Add(item);
 i += 1;

                }
                //if (this.Count == 0)
                //{
                //   //MessageBox.Show("Không tồn tại dịch vụ này, bạn hãy chọn dịch vụ khác!","Thong bao",MessageBoxIcon.Information );
                //}
                //IsReadOnly = true;
            }
           
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaFilter criteria)
        {
            RaiseListChangedEvents = false;

            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDichVuFilter(criteria.DK, criteria.DKFilter, criteria.qadmin)))
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
                    DMDichVu item = new DMDichVu(
    i,
     dr.GetString("MaDV"),
     dr.GetString("MaNhomDV"),
     dr.GetString("TenDV"),
     dr.GetString("TenTA"),
    
      dr.GetString("mabyte"),
       dr.GetString("quyetdinh"),
       dr.GetString("tendvbh"),
     dr.GetBoolean("NhapSL"),
     dr.GetString("TenTat"),
     dr.GetString("SoTban"),
     dr.GetString("MaLH"),
     dr.GetDecimal("DongiaTT"),
     dr.GetDecimal("DongiaTT1"),
     dr.GetSmartDate("NgayTT1"),
     dr.GetString("Makhoa"),
      dr.GetString("Makhoa087"),
       dr.GetString("MakhoaNG"),
        dr.GetString("MakhoaLM"),
      dr.GetString("MakhoaLM087"),
       dr.GetString("MakhoaLMNG"),
     dr.GetString("MaBS"),
     dr.GetString("Machuyenkhoa"),
     dr.GetString("Machungloai"),
     dr.GetByte("Loai"),
     dr.GetByte("NoiThucHien"),
     dr.GetString("MaCQ"),
     dr.GetString("MaBenhPham"),
     dr.GetBoolean("KTCao"),
     dr.GetString("ChisocaoNu"),
     dr.GetString("ChisocaoNam"),
     dr.GetString("ChisothapNu"),
     dr.GetString("ChisothapNam"),
     dr.GetString("Donvi"),
     dr.GetBoolean("ApdungGoi"),
     dr.GetBoolean("DichVuGui"),
     dr.GetByte("LoaiKQ"),
     dr.GetString("FormSudung"),
      dr.GetString("FormSudung087"),
     dr.GetDecimal("Hoahong"),
     dr.GetDecimal("GTHoahong"),
     dr.GetBoolean("TToanSau"),
     dr.GetBoolean("TToanNgay"),
     dr.GetBoolean("BCThu"),
     dr.GetBoolean("InThu"),
     dr.GetString("Ghichu"),
     dr.GetString("MaMay"),
     dr.GetSmartDate("NgayHuy"),
     dr.GetString("NguoiHuy"),
     dr.GetSmartDate("NgayLap"),
     dr.GetString("NguoiLap"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),
     dr.GetSmartDate("NgaySD1", false),
     dr.GetString("NguoiSD1"),
     dr.GetBoolean("Huy"),
     dr.GetBoolean("LayMauTT"),
     dr.GetBoolean("apdungpk"),
     dr.GetBoolean("apdungnt"),
     dr.GetBoolean("apdungnk"),
     dr.GetBoolean("apdungsuagia"),
     dr.GetString("maloaitt"),
      dr.GetString("mabh"), dr.GetString("matduong"),
       dr.GetString("quyetdinhbh"),
       dr.GetString("tenbyte"),
       dr.GetString("MAKHTH"),
                                            dr.GetString("MaCSBH"),
                                            dr.GetString("TenCSBH"),
                                            dr.GetString("MaMayXNBH")
     );
                    Add(item);
                    i += 1;

                }
                //if (this.Count == 0)
                //{
                //   //MessageBox.Show("Không tồn tại dịch vụ này, bạn hãy chọn dịch vụ khác!","Thong bao",MessageBoxIcon.Information );
                //}
                //IsReadOnly = true;
            }

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        #endregion
    }
}
