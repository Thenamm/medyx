using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMChePhamMauList : BusinessListBase<DMChePhamMauList, DMChePhamMau>
    {
        #region Factory Methods
        public static DMChePhamMauList GetAllDMChePhamMau()
        {
            return DataPortal.Fetch<DMChePhamMauList>(new Criteria());
        }
        public static DMChePhamMauList FindDMChePhamMauMa(string Ma)
        {
            return DataPortal.Fetch<DMChePhamMauList>(new CriteriaOther(1, Ma));
        }
        public static DMChePhamMauList FindDMChePhamMauTen(string Ten)
        {
            return DataPortal.Fetch<DMChePhamMauList>(new CriteriaOther(2, Ten));
        }
        public static DMChePhamMauList FindDMChePhamMauTenD(string Ten)
        {
            return DataPortal.Fetch<DMChePhamMauList>(new CriteriaOther(3, Ten));
        }
        public static DMChePhamMauList FindDMChePhamMauTenDu(string Ten)
        {
            return DataPortal.Fetch<DMChePhamMauList>(new CriteriaOther(5, Ten));
        }
        public void NewTo(DMChePhamMau _DMChePhamMau)
        {
            if (this.Count == 0)
                _DMChePhamMau.OrderNumber = 1;
            else
            _DMChePhamMau.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMChePhamMau);
        }
        public void UpdatedTo(DMChePhamMau _DMChePhamMau)
        {

            _DMChePhamMau.OrderNumber = this.Items[this.IndexOf(_DMChePhamMau)].OrderNumber;
            this.Items[this.IndexOf(_DMChePhamMau)] = _DMChePhamMau;
        }
        public void RemoveTo(DMChePhamMau _DMChePhamMau)
        {
            this.Items.Remove(_DMChePhamMau);

        }

        private DMChePhamMauList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            //private Byte _Loai;
            private Boolean _qadmin = false ;
            //public Byte Loai
            //{
            //    get
            //    {
            //        return _Loai;
            //    }
            //}
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            //public Criteria(Byte mLoai)
            //{
            //    _Loai = mLoai;
                
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
            //public Criteria(Boolean mqadmin)
            //{

            //    _qadmin = mqadmin;
            //}
            public CriteriaOther(Byte mIdFind, String mDK)
            {

                _IdFind = mIdFind;
                if (mIdFind == 1)
                    _DK = " and a.MaCPMau like N'" + mDK + "%'";
                else if (mIdFind == 2)
                    _DK = " and ltrim(rtrim(a.TenCPMau)) like N'" + mDK + "%'";
                else if (mIdFind == 3)
                    _DK = " and ltrim(rtrim(a.TenCPMau)) like N'" + mDK + "'";
                else if (mIdFind == 5)
                {
                    _DK = " and A.TenCPMau  + ' ' + ISNULL(A.HAMLUONG,'') + ' ' + ISNULL(P.TENDVT,'')  like N'" + mDK + "%'";
                }

            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMChePhamMau(criteria.qadmin )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMChePhamMau item = new DMChePhamMau(
     i,
     dr.GetString("MaCPMau") ,
			                                dr.GetString("TenCPMau") ,
			                                dr.GetString("TenTA") ,
			                                dr.GetString("Ghichu") ,
			                                dr.GetString("MaNhom") ,
			                                dr.GetString("Hamluong") ,
			                                dr.GetDecimal("Nguong") ,
			                                dr.GetString("MaDVT") ,
      dr.GetString("TenDVT"),
       dr.GetString("MaDVTHL"),
      dr.GetString("TenDVTHL"),
     dr.GetDecimal("DongiaTT") ,
     dr.GetDecimal("DongiaTT1") ,
     dr.GetBoolean("ApdungGoi") ,
			                                dr.GetDecimal("Gianhap") ,
			                                dr.GetDecimal("Gianhap1") ,
			                                dr.GetDecimal("Gianhap2") ,
			                                dr.GetSmartDate("Ngaynhap", true) ,
			                                dr.GetSmartDate("Ngaynhap1", true) ,
			                                dr.GetSmartDate("Ngaynhap2", true) ,
			                                dr.GetString("Makho") ,
			                                dr.GetBoolean("Huy") ,
     dr.GetString("MaMay") ,
			                                dr.GetSmartDate("NgaySD",false ),
			                                dr.GetSmartDate("NgaySD1",false),
			                                dr.GetString("NguoiSD") ,
     dr.GetString("NguoiSD1"),
     dr.GetString("HoTen"),
     dr.GetString("TenKho"),
     dr.GetBoolean("Handung"),
     dr.GetString("machungloai"),
     dr.GetString("malh"),
      dr.GetString("mabyte"),
       dr.GetString("quyetdinh"),
       dr.GetString("tencpmaubh"),
      dr.GetString("mabh"), dr.GetString("matduong"),
       dr.GetString("quyetdinhbh"),
       dr.GetString("tenbyte")
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMChePhamMau(criteria.DK, false)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMChePhamMau item = new DMChePhamMau(
     i,
     dr.GetString("MaCPMau"),
     dr.GetString("TenCPMau"),
     dr.GetString("TenTA"),
     dr.GetString("Ghichu"),
     dr.GetString("MaNhom"),
     dr.GetString("Hamluong"),
     dr.GetDecimal("Nguong"),
     dr.GetString("MaDVT"),
      dr.GetString("TenDVT"),
      dr.GetString("MaDVTHL"),
      dr.GetString("TenDVTHL"),
     dr.GetDecimal("DongiaTT"),
     dr.GetDecimal("DongiaTT1"),
     dr.GetBoolean("ApdungGoi"),
     dr.GetDecimal("Gianhap"),
     dr.GetDecimal("Gianhap1"),
     dr.GetDecimal("Gianhap2"),
     dr.GetSmartDate("Ngaynhap", true),
     dr.GetSmartDate("Ngaynhap1", true),
     dr.GetSmartDate("Ngaynhap2", true),
     dr.GetString("Makho"),
     dr.GetBoolean("Huy"),
     dr.GetString("MaMay"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetSmartDate("NgaySD1", false),
     dr.GetString("NguoiSD"),
     dr.GetString("NguoiSD1"),
     dr.GetString("HoTen"),
     dr.GetString("TenKho"),
     dr.GetBoolean("Handung"),
     dr.GetString("machungloai"),
     dr.GetString("malh"),
      dr.GetString("mabyte"),
       dr.GetString("quyetdinh"),
       dr.GetString("tencpmaubh"),
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

        #endregion
    }
}
