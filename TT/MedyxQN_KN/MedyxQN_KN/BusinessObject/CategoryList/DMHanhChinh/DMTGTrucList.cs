using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMTGTrucList : BusinessListBase<DMTGTrucList, DMTGTruc>
    {
        #region Factory Methods
        public static DMTGTrucList GetAllDMTGTruc()
        {
            return DataPortal.Fetch<DMTGTrucList>(new Criteria());
        }
        public void NewTo(DMTGTruc _DMTGTruc)
        {
            if (this.Count == 0)
                _DMTGTruc.OrderNumber = 1;
            else
                _DMTGTruc.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMTGTruc);
        }
        public void UpdatedTo(DMTGTruc _DMTGTruc)
        {

            _DMTGTruc.OrderNumber = this.Items[this.IndexOf(_DMTGTruc)].OrderNumber;
            this.Items[this.IndexOf(_DMTGTruc)] = _DMTGTruc;
        }
        public void RemoveTo(DMTGTruc _DMTGTruc)
        {
            this.Items.Remove(_DMTGTruc);

        }

        private DMTGTrucList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            public Criteria()
            {
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMTGTruc()))
            {
                int i = 1;

                while (dr.Read())
                {
                    DMTGTruc item = new DMTGTruc(
     i,
     dr.GetString("MaTGTruc"),
     dr.GetString("TenTGTruc"),
     dr.GetString ("MaMay"),
	 dr.GetBoolean ("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD") ,
     dr.GetString("GhiChu") ,
     dr.GetString("HoTen")
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
