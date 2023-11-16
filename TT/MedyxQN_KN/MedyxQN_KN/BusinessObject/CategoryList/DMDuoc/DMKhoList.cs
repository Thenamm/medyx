using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMKhoList : BusinessListBase<DMKhoList, DMKho>
    {
        #region Factory Methods
        public static DMKhoList GetAllDMKho(Byte loai)
        {
            return DataPortal.Fetch<DMKhoList>(new Criteria(loai) );
        }
        public static DMKhoList GetAllDMKho()
        {
            return DataPortal.Fetch<DMKhoList>(new Criteria(0));
        }

        public void NewTo(DMKho _DMKho)
        {
            if (this.Count == 0)
                _DMKho.OrderNumber = 1;
            else
                _DMKho.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMKho);
        }
        public void UpdatedTo(DMKho _DMKho)
        {

            _DMKho.OrderNumber = this.Items[this.IndexOf(_DMKho)].OrderNumber;
            this.Items[this.IndexOf(_DMKho)] = _DMKho;
        }
        public void RemoveTo(DMKho _DMKho)
        {
            this.Items.Remove(_DMKho);

        }

        public static DMKhoList FindDMKhoByMa(String ma,Byte loai)
        {
            return DataPortal.Fetch<DMKhoList>(new CriteriaOther(1, ma,loai));
        }

        public static DMKhoList FindDMKhoByTen(String ten,Byte loai)
        {
            return DataPortal.Fetch<DMKhoList>(new CriteriaOther(2,ten,loai));  
        }

        public static DMKhoList GetListFind( Byte loai)
        {
            return DataPortal.Fetch<DMKhoList>(new CriteriaOther(3, "", loai));
        }
        private DMKhoList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            private Byte _Loai;
             private Boolean _qadmin = false ;
            public Byte Loai
            {
                get
                {
                    return _Loai;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public Criteria(Byte mLoai)
            {
                _Loai = mLoai;

            }
        }
        #region CriteriaOther

        [Serializable()]
        private class CriteriaOther
        {

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
            private string _account = "";
            public string account
            {
                get
                {
                    return _account;
                }
            }
            public CriteriaOther(Byte mIdFind, String mDK,byte loai)
            {

                _IdFind = mIdFind;

                _DK = " loai = '" + loai + "' and EXISTS(SELECT B.MAKHO FROM ACCOUNT B WHERE DBO.FGIAIMA(B.ACCOUNT)  ='" + _account;
                    _DK = _DK + "' AND (CHARINDEX( A.MAKHO  ,B.MAKHO,1) <> 0 OR  ALLMAKHO = 1 )) ";
                    if (mIdFind == 1)
                        _DK = _DK + " AND MaKho like '%" + mDK + "'";
                    else if (mIdFind == 2)
                        _DK = _DK + " AND ltrim(rtrim(TenKho)) like N'" + mDK + "%'";

            }
        }
        #endregion
     
        private void DataPortal_Fetch(Criteria criteria)
        {
            int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMKho(criteria.Loai, criteria.qadmin  )))
            {
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMKho item = new DMKho(
     i,
     dr.GetString("MaKho"), 
     dr.GetString ("TenKho"),
     dr.GetByte("Loai"),
     dr.GetBoolean("Kieukho"),
     dr.GetBoolean("Khoban"),
     dr.GetString("Ghichu"),
		 dr.GetString ("MaMay"),
		 dr.GetBoolean ("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD") ,
     false,
     dr.GetString("hoten")
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
            int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMKho(criteria.DK)))
            {
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMKho item = new DMKho(
     i,
     dr.GetString("MaKho"),
     dr.GetString("TenKho"),
     dr.GetByte("Loai"),
     dr.GetBoolean("Kieukho"),
     dr.GetBoolean("Khoban"),
     dr.GetString("Ghichu"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD") ,

     false,
      dr.GetString("hoten") 
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
