using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMDichVu_BCs : BusinessListBase<DMDichVu_BCs, DMDichVu_BC>
    {
        #region Factory Methods
        public static DMDichVu_BCs GetAllDMDichVu_BC()
        {
            return DataPortal.Fetch<DMDichVu_BCs>(new Criteria());
        }
        public void NewTo(DMDichVu_BC _DMDichVu_BC)
        {
            _DMDichVu_BC.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMDichVu_BC);
        }
        public void UpdatedTo(DMDichVu_BC _DMDichVu_BC)
        {

            _DMDichVu_BC.OrderNumber = this.Items[this.IndexOf(_DMDichVu_BC)].OrderNumber;
            this.Items[this.IndexOf(_DMDichVu_BC)] = _DMDichVu_BC;
        }
        public void RemoveTo(DMDichVu_BC _DMDichVu_BC)
        {
            this.Items.Remove(_DMDichVu_BC);

        }
        private DMDichVu_BCs()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access
        #region Criteria
        [Serializable()]
        private class Criteria
        {

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
                if (mIdFind == 1)
                    _DK = "MaBC like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenBC)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDichVu_BC(criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMDichVu_BC item = new DMDichVu_BC(
     i,
     dr.GetString("MaBC") ,
     dr.GetString("TenBC") ,
     dr.GetByte("Loai"), 
     dr.GetString("Ghichu") ,
     dr.GetString("MaMay") ,
     dr.GetBoolean("Huy") ,
     dr.GetSmartDate("NgayHuy") ,
     dr.GetString("NguoiHuy") ,
     dr.GetSmartDate("NgayLap") ,
     dr.GetString("NguoiLap") ,
     dr.GetSmartDate("NgaySD",false) ,
     dr.GetString("NguoiSD"),
     dr.GetString("TenNguoiLap"),
     dr.GetString("TenNguoiSD"),
     dr.GetString("TenNguoiHuy")
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDichVu_BC(criteria.DK, false)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMDichVu_BC item = new DMDichVu_BC(
     i,
     dr.GetString("MaBC"),
     dr.GetString("TenBC"),
     dr.GetByte("Loai"),
     dr.GetString("Ghichu"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgayHuy"),
     dr.GetString("NguoiHuy"),
     dr.GetSmartDate("NgayLap"),
     dr.GetString("NguoiLap"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),
     dr.GetString("TenNguoiLap"),
     dr.GetString("TenNguoiSD"),
     dr.GetString("TenNguoiHuy")
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
