using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMDichVu_MaHoaList : BusinessListBase<DMDichVu_MaHoaList, DMDichVu_MaHoa>
    {
        #region Factory Methods
        public static DMDichVu_MaHoaList GetAllDMDichVu_MaHoa(String maDV)
        {
            return DataPortal.Fetch<DMDichVu_MaHoaList>(new Criteria(maDV));
        }
        public static DMDichVu_MaHoaList GetAllDMDichVu_MaHoa(String maDV,string maloai)
        {
            return DataPortal.Fetch<DMDichVu_MaHoaList>(new OtherCriteria(maDV,maloai));
        }
        public static DMDichVu_MaHoaList GetAllDMDichVu_MaHoa(String maDV, String maicd, string maloai)
        {
            return DataPortal.Fetch<DMDichVu_MaHoaList>(new CriteriaOther(maDV,maicd, maloai));
        }
        public void NewTo(DMDichVu_MaHoa _DMDichVu_MaHoa)
        {
            if (this.Count == 0)
                _DMDichVu_MaHoa.OrderNumber = 1;
            else 
            _DMDichVu_MaHoa.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMDichVu_MaHoa);
        }
        public void UpdatedTo(DMDichVu_MaHoa _DMDichVu_MaHoa)
        {

            _DMDichVu_MaHoa.OrderNumber = this.Items[this.IndexOf(_DMDichVu_MaHoa)].OrderNumber;
            this.Items[this.IndexOf(_DMDichVu_MaHoa)] = _DMDichVu_MaHoa;
        }
        public void RemoveTo(DMDichVu_MaHoa _DMDichVu_MaHoa)
        {
            this.Items.Remove(_DMDichVu_MaHoa);

        }

        private DMDichVu_MaHoaList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDichVu_MaHoa(criteria.MaDV , criteria.qadmin )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMDichVu_MaHoa item = new DMDichVu_MaHoa(
     i,
     dr.GetString("MaFile") ,
			                                dr.GetString("MaDV") ,
			                                dr.GetString("TenHT") ,
			                                (Byte[])dr.GetValue("FileMau") ,
			                                dr.GetString("KQ") ,
			                                dr.GetString("Ghichu") ,
			                                dr.GetString("MaMay") ,
			                                dr.GetSmartDate("NgaySD", true) ,
			                                dr.GetString("NguoiSD") ,
			                                dr.GetBoolean("Huy"),
     dr.GetString("hoten"),
      dr.GetString("maloai"),
      dr.GetString("tenloai"),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDichVu_MaHoa(criteria.DK, false)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMDichVu_MaHoa item = new DMDichVu_MaHoa(
     i,
     dr.GetString("MaFile"),
     dr.GetString("MaDV"),
     dr.GetString("TenHT"),
     (Byte[])dr.GetValue("FileMau"),
     dr.GetString("KQ"),
     dr.GetString("Ghichu"),
     dr.GetString("MaMay"),
     dr.GetSmartDate("NgaySD", true),
     dr.GetString("NguoiSD"),
     dr.GetBoolean("Huy"),
     dr.GetString("hoten"),
      dr.GetString("maloai"),
      dr.GetString("tenloai"),
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDichVu_MaHoa(criteria.DK, false)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMDichVu_MaHoa item = new DMDichVu_MaHoa(
     i,
     dr.GetString("MaFile"),
     dr.GetString("MaDV"),
     dr.GetString("TenHT"),
     (Byte[])dr.GetValue("FileMau"),
     dr.GetString("KQ"),
     dr.GetString("Ghichu"),
     dr.GetString("MaMay"),
     dr.GetSmartDate("NgaySD", true),
     dr.GetString("NguoiSD"),
     dr.GetBoolean("Huy"),
     dr.GetString("hoten"),
      dr.GetString("maloai"),
      dr.GetString("tenloai"),
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
