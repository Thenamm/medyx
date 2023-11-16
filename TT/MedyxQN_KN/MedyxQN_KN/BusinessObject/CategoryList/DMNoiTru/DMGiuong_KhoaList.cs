using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMGiuong_KhoaList : BusinessListBase<DMGiuong_KhoaList, DMGiuong_Khoa>
    {
        #region Factory Methods
        public static DMGiuong_KhoaList NewList()
        {
            return DataPortal.Fetch<DMGiuong_KhoaList>(new TemCriteria());
        }
        public static DMGiuong_KhoaList GetAllDMGiuong_Khoa(string makhoa)
        {
            return DataPortal.Fetch<DMGiuong_KhoaList>(new Criteria(makhoa));
        }
        // tim theo dieu kien ten
       
        public void NewTo(DMGiuong_Khoa _DMGiuong_Khoa)
        {
            if (this.Count == 0)
                _DMGiuong_Khoa.OrderNumber = 1;
            else
            _DMGiuong_Khoa.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMGiuong_Khoa);
        }
        public void UpdatedTo(DMGiuong_Khoa _DMGiuong_Khoa)
        {

            _DMGiuong_Khoa.OrderNumber = this.Items[this.IndexOf(_DMGiuong_Khoa)].OrderNumber;
            this.Items[this.IndexOf(_DMGiuong_Khoa)] = _DMGiuong_Khoa;
        }
        public void RemoveTo(DMGiuong_Khoa _DMGiuong_Khoa)
        {
            this.Items.Remove(_DMGiuong_Khoa);

        }

        private DMGiuong_KhoaList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class TemCriteria
        {

        };
        private class Criteria
        {
            private Boolean _qadmin = false ;
            private string _makhoa;
            public String makhoa
            {
                get
                {
                    return _makhoa;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public Criteria(string mmakhoa )
            {
                _makhoa = mmakhoa;

            }
        }

        // tim kiem theo ten
     

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMGiuong_Khoa( criteria.qadmin ,criteria.makhoa )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMGiuong_Khoa item = new DMGiuong_Khoa(
     i,
     dr.GetString("sophong") ,
			                                dr.GetString("sogiuong") ,
      
			                                dr.GetString("GhiChu") ,
     dr.GetString("makhoa"),
			                                dr.GetBoolean("tinhtrang") ,
			                                dr.GetString("MaMay") ,
			                                dr.GetBoolean("Huy")  ,
			                                dr.GetSmartDate("NgaySD", true) ,
			                                dr.GetString("NguoiSD") ,
     dr.GetString("hoten")
         );
                    this.Add(item);
                    i += 1;

                }
                //IsReadOnly = true;
            }

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        //private void DataPortal_Fetch(CriteriaOther criteria)
        //{
        //    RaiseListChangedEvents = false;
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMGiuong_Khoa(criteria.DK, false)))
        //    {
        //        int i = 1;
        //        //IsReadOnly = false;
        //        while (dr.Read())
        //        {
        //            DMGiuong_Khoa item = new DMGiuong_Khoa(
        // i,
        //dr.GetString("sophong"),
        // dr.GetString("sogiuong"),
        //  dr.GetString("makhoa")
        // dr.GetString("GhiChu"),
        // dr.GetBoolean("tinhtrang"),
        // dr.GetString("MaMay"),
        // dr.GetBoolean("Huy"),
        // dr.GetSmartDate("NgaySD", true),
        // dr.GetString("NguoiSD"),
        // dr.GetString("hoten")
        // );
        //            this.Add(item);
        //            i += 1;

        //        }
        //        //IsReadOnly = true;
        //    }
           
        //    RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        //}

        #endregion
    }
}
