using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMGiayPhep_ATBXList : BusinessListBase<DMGiayPhep_ATBXList, DMGiayPhep_ATBX>
    {
        #region Factory Methods
        public static DMGiayPhep_ATBXList FindDMGiayPhep_ATBX(string dk)
        {
            return DataPortal.Fetch<DMGiayPhep_ATBXList>(new CriteriaOther( dk));
        }
        public static DMGiayPhep_ATBXList GetAllDMGiayPhep_ATBX()
        {
            return DataPortal.Fetch<DMGiayPhep_ATBXList>();
        }
        public static DMGiayPhep_ATBXList SearchDMGiayPhep_ATBX(DateTime tungay, DateTime denngay, string matb, string noicap)
        {
            return DataPortal.Fetch<DMGiayPhep_ATBXList>(new Criteria(tungay, denngay, matb, noicap));
        }
        public static DMGiayPhep_ATBXList SearchByMaTB_DMGiayPhep_ATBX(string matb)
        {
            return DataPortal.Fetch<DMGiayPhep_ATBXList>(new CriteriaTB(matb));
        }
        public void NewTo(DMGiayPhep_ATBX _DMGiayPhep_ATBX)
        {
            if (this.Count == 0)
                _DMGiayPhep_ATBX.OrderNumber = 1;
            else
                _DMGiayPhep_ATBX.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMGiayPhep_ATBX);
        }
        public void UpdatedTo(DMGiayPhep_ATBX _DMGiayPhep_ATBX)
        {
            _DMGiayPhep_ATBX.OrderNumber = this.Items[this.IndexOf(_DMGiayPhep_ATBX)].OrderNumber;
            this.Items[this.IndexOf(_DMGiayPhep_ATBX)] = _DMGiayPhep_ATBX;
        }
        public void RemoveTo(DMGiayPhep_ATBX _DMGiayPhep_ATBX)
        {
            this.Items.Remove(_DMGiayPhep_ATBX);
        }

        private DMGiayPhep_ATBXList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access
        #region CriteriaOther

        [Serializable()]
        private class Criteria
        {
            private DateTime _tuNgay;
            public DateTime TuNgay
            {
                get
                {
                    return _tuNgay;
                }
            }
            private DateTime _denNgay;
            public DateTime DenNgay
            {
                get
                {
                    return _denNgay;
                }
            }
            private string _maTB;
            public string MaTB
            {
                get
                {
                    return _maTB;
                }
            }
            private string _NoiCap;
            public string NoiCap
            {
                get
                {
                    return _NoiCap;
                }
            }
            public Criteria(DateTime tungay, DateTime denngay, string matb, string noicap)
            {
                _tuNgay = tungay;
                _denNgay = denngay;
                _maTB = matb;
                _NoiCap = noicap;
            }
        }
        [Serializable()]
        private class CriteriaTB
        {
            private string _maTB;
            public string MaTB
            {
                get
                {
                    return _maTB;
                }
            }
            public CriteriaTB( string matb)
            {
                _maTB = matb;
            }
        }
        #endregion
        #region CriteriaOther

        [Serializable()]
        private class CriteriaOther
        {
            private string _dk;
            public string DK
            {
                get
                {
                    return _dk;
                }
            }
            public CriteriaOther(string dk)
            {
                _dk = dk;
            }
        }
        #endregion
        private void DataPortal_Fetch(CriteriaOther c)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMGiayPhepATBX(c.DK)))
            {
                int i = 1;
                while (dr.Read())
                {
                    DMGiayPhep_ATBX item = new DMGiayPhep_ATBX(
                    dr.GetString("MaGP"),
                    dr.GetString("MaTB"),
                    dr.GetSmartDate("NgayCap", false),
                    dr.GetSmartDate("NgayHetHan", false),
                    dr.GetString("NoiCap"),
                    dr.GetString("GhiChu"),
                    dr.GetString("SoGP"),
                    dr.GetBoolean("Huy"),
                    dr.GetString("MaMay"),
                    dr.GetSmartDate("NgaySD", false),
                    dr.GetString("NguoiSD"),
                    dr.GetString("TenTB"),
                    dr.GetString("HoTen"),
                    i
         );
                    this.Add(item);
                    i += 1;

                }
            }
           
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch()
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMGiayPhepATBX()))
            {
                int i = 1;
                while (dr.Read())
                {
                    DMGiayPhep_ATBX item = new DMGiayPhep_ATBX(
                    dr.GetString("MaGP"),
                    dr.GetString("MaTB"),
                    dr.GetSmartDate("NgayCap", false),
                    dr.GetSmartDate("NgayHetHan", false),
                    dr.GetString("NoiCap"),
                    dr.GetString("GhiChu"),
                    dr.GetString("SoGP"),
                    dr.GetBoolean("Huy"),
                    dr.GetString("MaMay"),
                    dr.GetSmartDate("NgaySD", false),
                    dr.GetString("NguoiSD"),
                    dr.GetString("TenTB"),
                    dr.GetString("HoTen"),
                    i
         );
                    this.Add(item);
                    i += 1;

                }
            }

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(Criteria c)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().SearchDMGiayPhepATBX(c.TuNgay,c.DenNgay,c.MaTB,c.NoiCap)))
            {
                int i = 1;
                while (dr.Read())
                {
                    DMGiayPhep_ATBX item = new DMGiayPhep_ATBX(
                    dr.GetString("MaGP"),
                    dr.GetString("MaTB"),
                    dr.GetSmartDate("NgayCap", false),
                    dr.GetSmartDate("NgayHetHan", false),
                    dr.GetString("NoiCap"),
                    dr.GetString("GhiChu"),
                    dr.GetString("SoGP"),
                    dr.GetBoolean("Huy"),
                    dr.GetString("MaMay"),
                    dr.GetSmartDate("NgaySD", false),
                    dr.GetString("NguoiSD"),
                    dr.GetString("TenTB"),
                    dr.GetString("HoTen"),
                    i
         );
                    this.Add(item);
                    i += 1;

                }
            }

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaTB c)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().SearchByMaTBDMGiayPhepATBX(c.MaTB)))
            {
                int i = 1;
                while (dr.Read())
                {
                    DMGiayPhep_ATBX item = new DMGiayPhep_ATBX(
                    dr.GetString("MaGP"),
                    dr.GetString("MaTB"),
                    dr.GetSmartDate("NgayCap", false),
                    dr.GetSmartDate("NgayHetHan", false),
                    dr.GetString("NoiCap"),
                    dr.GetString("GhiChu"),
                    dr.GetString("SoGP"),
                    dr.GetBoolean("Huy"),
                    dr.GetString("MaMay"),
                    dr.GetSmartDate("NgaySD", false),
                    dr.GetString("NguoiSD"),
                    dr.GetString("TenTB"),
                    dr.GetString("HoTen"),
                    i
         );
                    this.Add(item);
                    i += 1;

                }
            }

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        #endregion
    }
}
