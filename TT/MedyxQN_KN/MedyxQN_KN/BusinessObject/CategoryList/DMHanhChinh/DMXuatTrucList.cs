using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMXuatTrucList : BusinessListBase<DMXuatTrucList, DMXuatTruc>
    {
        #region Factory Methods
        public static DMXuatTrucList GetAllDMXuatTruc(string MaKhoa)
        {
            return DataPortal.Fetch<DMXuatTrucList>(new Criteria(MaKhoa));
        }
        public static DMXuatTrucList FindDMXuatTruc(string MaMay, string NguoiSD, string MaKhoa, string MaCD)
        {
            return DataPortal.Fetch<DMXuatTrucList>(new CriteriaOther(MaMay, NguoiSD, MaKhoa, MaCD));
        }
        public void NewTo(DMXuatTruc _DMXuatTruc)
        {
            if (this.Count == 0)
                _DMXuatTruc.OrderNumber = 1;
            else
                _DMXuatTruc.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMXuatTruc);
        }
        public void UpdatedTo(DMXuatTruc _DMXuatTruc)
        {

            _DMXuatTruc.OrderNumber = this.Items[this.IndexOf(_DMXuatTruc)].OrderNumber;
            this.Items[this.IndexOf(_DMXuatTruc)] = _DMXuatTruc;
        }
        public void RemoveTo(DMXuatTruc _DMXuatTruc)
        {
            this.Items.Remove(_DMXuatTruc);

        }

        private DMXuatTrucList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            private string _MaKhoa;
            public string MaKhoa
            {
                get
                {
                    return _MaKhoa;
                }
            }
            public Criteria(string MaKhoa)
            {
                _MaKhoa = MaKhoa;
            }
        }

        #region CriteriaOther

        [Serializable()]
        private class CriteriaOther
        {

            private String _MaKhoa;
            public String MaKhoa
            {
                get
                {
                    return _MaKhoa;
                }
            }
            private String _MaCD;
            public String MaCD
            {
                get
                {
                    return _MaCD;
                }
            }
            private String _maMay;
            public String MaMay
            {
                get
                {
                    return _maMay;
                }
            }

            private String _NguoiSD;
            public String NguoiSD
            {
                get
                {
                    return _NguoiSD;
                }
            }
            public CriteriaOther(String Mamay, String Nguoisd, String MaKhoa, String MaCD)
            {
                _MaKhoa = MaKhoa;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _MaCD = MaCD;
            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMXuatTruc(criteria.MaKhoa)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMXuatTruc item = new DMXuatTruc(
     i,
     dr.GetString("MaKhoa"),
     dr.GetString("MaCD"),
     dr.GetInt32("XuatTruc"),
	 dr.GetString ("MaMay"),
	 dr.GetBoolean ("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD") ,
     dr.GetString("GhiChu") ,
     dr.GetString("HoTen"),
     dr.GetString("TenKhoa"),
     dr.GetString("TenCD") 
         );
                    this.Add(item);
                    i += 1;

                }
            }
          

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMXuatTruc(criteria.MaKhoa,criteria.MaCD)))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMXuatTruc item = new DMXuatTruc(
     i,
     dr.GetString("MaKhoa"),
     dr.GetString("MaCD"),
     dr.GetInt32("XuatTruc"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),
     dr.GetString("GhiChu"),
     dr.GetString("HoTen"),
     dr.GetString("TenKhoa"),
     dr.GetString("TenCD")

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
