using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMDichVu_PhieuHenList : BusinessListBase<DMDichVu_PhieuHenList, DMDichVu_PhieuHen>
    {
        #region Factory Methods
        public static DMDichVu_PhieuHenList GetAllDMDichVu_PhieuHen(String maDV)
        {
            return DataPortal.Fetch<DMDichVu_PhieuHenList>(new Criteria(maDV));
        }
        public static DMDichVu_PhieuHenList GetAllDMDichVu_PhieuHen(String maDV,string maloai)
        {
            return DataPortal.Fetch<DMDichVu_PhieuHenList>(new OtherCriteria(maDV,maloai));
        }
        public static DMDichVu_PhieuHenList GetAllDMDichVu_PhieuHen(String maDV, String maicd, string maloai)
        {
            return DataPortal.Fetch<DMDichVu_PhieuHenList>(new CriteriaOther(maDV,maicd, maloai));
        }
        public void NewTo(DMDichVu_PhieuHen _DMDichVu_PhieuHen)
        {
            if (this.Count == 0)
                _DMDichVu_PhieuHen.OrderNumber = 1;
            else 
            _DMDichVu_PhieuHen.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMDichVu_PhieuHen);
        }
        public void UpdatedTo(DMDichVu_PhieuHen _DMDichVu_PhieuHen)
        {

            _DMDichVu_PhieuHen.OrderNumber = this.Items[this.IndexOf(_DMDichVu_PhieuHen)].OrderNumber;
            this.Items[this.IndexOf(_DMDichVu_PhieuHen)] = _DMDichVu_PhieuHen;
        }
        public void RemoveTo(DMDichVu_PhieuHen _DMDichVu_PhieuHen)
        {
            this.Items.Remove(_DMDichVu_PhieuHen);

        }

        private DMDichVu_PhieuHenList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            private String _MaDV;
            private Boolean _qadmin = false ;
            public String MaDV
            {
                get
                {
                    return _MaDV;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public Criteria(String mMaDV)
            {
                _MaDV = mMaDV;
                
            }
        }
        private class OtherCriteria
        {
            private String _MaDV;
             private Boolean _qadmin = false ;
            private String _MaLoai;
            public String MaDV
            {
                get
                {
                    return _MaDV;
                }
            }
            public String MaLoai
            {
                get
                {
                    return _MaLoai;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
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
            public OtherCriteria(String mMaDV,string mmaloai)
            {
                _MaDV = mMaDV;
                _MaLoai = mmaloai;
                 _DK = "  and d.malh in (select malh from dmdichvu aa where ltrim(rtrim(aa.madv)) like N'" + mMaDV + "%') ";
                _DK = _DK + " and ltrim(rtrim(a.maloai)) like N'" + mmaloai + "%'";

            }
        }
        // tim kiem theo ten
        #region CriteriaOther
         private class CriteriaOther
        {
          private String _MaDV;
           private Boolean _qadmin = false ;
          private String _MaLoai;
          private String _Maicd;
            public String MaDV
            {
                get
                {
                    return _MaDV;
                }
            }
            public String MaLoai
            {
                get
                {
                    return _MaLoai;
                }
            }
          public String Maicd
            {
                get
                {
                    return _Maicd;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
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
            public CriteriaOther(String mMaDV,string mmaicd,string mmaloai)
            {
                _MaDV = mMaDV;
                _MaLoai = mmaloai;
                _DK = "  and d.malh in (select malh from dmdichvu aa where ltrim(rtrim(aa.madv)) like N'" + mMaDV + "%') ";
                _DK = _DK + " and ltrim(rtrim(a.maloai)) like N'" + mmaloai + "%' and a.ghichu =N'" + mmaicd + "'";

            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDichVu_PhieuHen(criteria.MaDV , criteria.qadmin )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMDichVu_PhieuHen item = new DMDichVu_PhieuHen(
     i,
     dr.GetString("MaPH") ,
			                                dr.GetString("MaDV") ,
			                                dr.GetString("TenHT") ,
			                                dr.GetString("KQ") ,
			                                dr.GetString("Ghichu") ,
			                                dr.GetString("MaMay") ,
			                                dr.GetSmartDate("NgaySD", true) ,
			                                dr.GetString("NguoiSD") ,
			                                dr.GetBoolean("Huy"),
     dr.GetString("hoten"),
     
      dr.GetString("NoiDungKQ")
         );
                    this.Add(item);
                    i += 1;

                }
                //IsReadOnly = true;
            }
            // Xem lai doan code duoi
            //ArrayList arrList;
            //arrList = CBO.FillCollection(DataProvider.Instance().GetLocations(criteria.Id), typeof(LocationListInfo));
            //IsReadOnly = false;
            //foreach (LocationListInfo obj in arrList)
            //{
            //    this.Add(obj);
            //}
            //IsReadOnly = true;

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDichVu_PhieuHen(criteria.DK, false)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMDichVu_PhieuHen item = new DMDichVu_PhieuHen(
     i,
     dr.GetString("MaPH"),
     dr.GetString("MaDV"),
     dr.GetString("TenHT"),
     dr.GetString("KQ"),
     dr.GetString("Ghichu"),
     dr.GetString("MaMay"),
     dr.GetSmartDate("NgaySD", true),
     dr.GetString("NguoiSD"),
     dr.GetBoolean("Huy"),
     dr.GetString("hoten"),
     
      dr.GetString("NoiDungKQ")
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDichVu_PhieuHen(criteria.DK, false)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMDichVu_PhieuHen item = new DMDichVu_PhieuHen(
     i,
     dr.GetString("MaPH"),
     dr.GetString("MaDV"),
     dr.GetString("TenHT"),
   
     dr.GetString("KQ"),
     dr.GetString("Ghichu"),
     dr.GetString("MaMay"),
     dr.GetSmartDate("NgaySD", true),
     dr.GetString("NguoiSD"),
     dr.GetBoolean("Huy"),
     dr.GetString("hoten"),
  
      dr.GetString("NoiDungKQ")
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
