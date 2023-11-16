using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;


namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMGiuongList : BusinessListBase<DMGiuongList, DMGiuong>
    {
         
        #region Factory Methods
        public static DMGiuongList GetAllDMGiuong(Boolean qadmin)
        {
            return DataPortal.Fetch<DMGiuongList>(new Criteria(qadmin));
        }
        // tim theo dieu kien ten
        public static DMGiuongList FindDMGiuongByTen(string TenGiuong, Boolean qadmin)
        {
            return DataPortal.Fetch<DMGiuongList>(new CriteriaOther(2,TenGiuong,qadmin));
        }
        public static DMGiuongList FindDMGiuongByTenD(string TenGiuong, Boolean qadmin)
        {
            return DataPortal.Fetch<DMGiuongList>(new CriteriaOther(4, TenGiuong, qadmin));
        }
        public static DMGiuongList FindDMGiuongByMa(string MaGiuong, Boolean qadmin)
        {
            return DataPortal.Fetch<DMGiuongList>(new CriteriaOther(1, MaGiuong, qadmin));
        }
        public static DMGiuongList FindDMGiuongByNhomDV(string MaNhom, Boolean qadmin)
        {
            return DataPortal.Fetch<DMGiuongList>(new CriteriaOther(3, MaNhom, qadmin));
        }
        public void NewTo(DMGiuong _DMGiuong)
        {
            if (this.Count == 0)
                _DMGiuong.OrderNumber = 1;
            else
            _DMGiuong.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMGiuong);
        }
        public void UpdatedTo(DMGiuong _DMGiuong)
        {

            _DMGiuong.OrderNumber = this.Items[this.IndexOf(_DMGiuong)].OrderNumber;
            this.Items[this.IndexOf(_DMGiuong)] = _DMGiuong;
        }
        public void RemoveTo(DMGiuong _DMGiuong)
        {

            //if (_DMGiuong.IsNew == true)
                this.Items.Remove(_DMGiuong);

            //else
            //    Remove(_DMGiuong);
        }
        public DMGiuong Contains(string MaGiuong)
        {
            foreach (DMGiuong obj in this)
                if (obj.MaGiuong == MaGiuong)
                    return obj;
            return null;
        }
        private DMGiuongList()
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
            public Criteria(Boolean mqadmin)
            {

                _qadmin = mqadmin;
            }
           
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
            public CriteriaOther(Byte mIdFind, String mDK, Boolean qadmin)
            {

                _IdFind = mIdFind;
                if (mIdFind == 1)
                    _DK = "(MaGiuong like '" + mDK + "%' OR a.TENTAT LIKE N'" + mDK + "%')";
                else if  (mIdFind == 2) 
                        _DK = "ltrim(rtrim(TenGiuong)) like N'" + mDK + "%'";
                else if ((mIdFind == 3) && (mDK != "All")  )
                        _DK = "ltrim(rtrim(A.MaNhom)) like N'" + mDK + "'";
                    else if (mIdFind == 4)
                        _DK = "ltrim(rtrim(TenGiuong)) like N'" + mDK + "'";
                _qadmin = qadmin;
            }
        }
        #endregion
        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMGiuong(criteria.qadmin)))
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMGiuong item = new DMGiuong(
 i,
 dr.GetString("MaGiuong") ,
			                            dr.GetString("TenGiuong") ,
			                            dr.GetString("MaNHOM") ,
			                            dr.GetString("TenTA") ,
			                            dr.GetString("TenTat") ,
			                            dr.GetDecimal("DongiaTT") ,
			                            dr.GetDecimal("DongiaTT1") ,
			                            dr.GetSmartDate("NgayTT1", true) ,
			                            dr.GetString("Ghichu") ,
			                            dr.GetString("MaMay") ,
			                            dr.GetSmartDate("NgayHuy", true) ,
			                            dr.GetString("NguoiHuy") ,
			                            dr.GetSmartDate("NgayLap", true) ,
			                            dr.GetString("NguoiLap"),
			                            dr.GetSmartDate("NgaySD", true),
			                            dr.GetString("NguoiSD") ,
			                            dr.GetBoolean("Huy") ,
			                            dr.GetSmartDate("NgaySD1", true) ,
			                            dr.GetString("NguoiSD1") ,
			                            dr.GetBoolean("ADGiaUSD") ,
			                            dr.GetSmartDate("NgayGia", true) ,
			                            dr.GetBoolean("ApdungGoi") ,
			                            dr.GetDecimal("BHTra") ,
			                            dr.GetDecimal("GTHoaHong") ,
			                            dr.GetBoolean("BCThu") ,
			                            dr.GetBoolean("InThu") ,
 dr.GetString("TenNhom") ,
 dr.GetString("TenNguoiLap") ,
 dr.GetString("TenNguoiSD") ,
 dr.GetString("TenNguoiHuy") ,

      dr.GetString("mabyte"),
       dr.GetString("quyetdinh"), dr.GetString("TenGiuongBH"),
      dr.GetString("mabh"), dr.GetString("matduong"),
       dr.GetString("quyetdinhbh"),
       dr.GetString("tenbyte")
     
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMGiuong(criteria.DK,criteria.qadmin)))         
            {
                int i = 1;

                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMGiuong item = new DMGiuong(
    i,
 dr.GetString("MaGiuong"),
 dr.GetString("TenGiuong"),
 dr.GetString("MaNHOM"),
 dr.GetString("TenTA"),
 dr.GetString("TenTat"),
 dr.GetDecimal("DongiaTT"),
 dr.GetDecimal("DongiaTT1"),
 dr.GetSmartDate("NgayTT1", true),
 dr.GetString("Ghichu"),
 dr.GetString("MaMay"),
 dr.GetSmartDate("NgayHuy", true),
 dr.GetString("NguoiHuy"),
 dr.GetSmartDate("NgayLap", true),
 dr.GetString("NguoiLap"),
 dr.GetSmartDate("NgaySD", true),
 dr.GetString("NguoiSD"),
 dr.GetBoolean("Huy"),
 dr.GetSmartDate("NgaySD1", true),
 dr.GetString("NguoiSD1"),
 dr.GetBoolean("ADGiaUSD"),
 dr.GetSmartDate("NgayGia", true),
 dr.GetBoolean("ApdungGoi"),
 dr.GetDecimal("BHTra"),
 dr.GetDecimal("GTHoaHong"),
 dr.GetBoolean("BCThu"),
 dr.GetBoolean("InThu"),
 dr.GetString("TenNhom"),
 dr.GetString("TenNguoiLap"),
 dr.GetString("TenNguoiSD"),
 dr.GetString("TenNguoiHuy"),
      dr.GetString("mabyte"),
       dr.GetString("quyetdinh"),
 dr.GetString("TenGiuongBH"),
      dr.GetString("mabh"), dr.GetString("matduong"),
       dr.GetString("quyetdinhbh"),
       dr.GetString("tenbyte")
     ); 
      this.Add(item);
 i += 1;

                }
                if (this.Count == 0)
                {
                        
                   //MessageBox.Show("Không có danh mục giường này!" );
                }
                //IsReadOnly = true;
            }
           
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        #endregion
    }
}
