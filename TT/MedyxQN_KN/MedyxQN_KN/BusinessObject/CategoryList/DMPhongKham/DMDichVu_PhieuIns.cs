using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;


namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMDichVu_PhieuIns : BusinessListBase<DMDichVu_PhieuIns, DMDichVu_PhieuIn>
    {
        #region Factory Methods
        public static DMDichVu_PhieuIns GetAllDMDichVu_PhieuIn()
        {

            return DataPortal.Fetch<DMDichVu_PhieuIns>(new Criteria());
           
                return DataPortal.Fetch<DMDichVu_PhieuIns>(new Criteria() );           
        }
        public void NewTo(DMDichVu_PhieuIn _DMDichVu_PhieuIn)
        {
            _DMDichVu_PhieuIn.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMDichVu_PhieuIn);
        }
        public void UpdatedTo(DMDichVu_PhieuIn _DMDichVu_PhieuIn)
        {

            _DMDichVu_PhieuIn.OrderNumber = this.Items[this.IndexOf(_DMDichVu_PhieuIn)].OrderNumber;
            this.Items[this.IndexOf(_DMDichVu_PhieuIn)] = _DMDichVu_PhieuIn;
        }
        public void RemoveTo(DMDichVu_PhieuIn _DMDichVu_PhieuIn)
        {
            this.Items.Remove(_DMDichVu_PhieuIn);

        }
        private DMDichVu_PhieuIns()
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
                    _DK = "MaPhieu like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenPhieu)) like N'" + mDK + "%'";


            }
        }
        #endregion
        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDichVu_PhieuIn(criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    
                    DMDichVu_PhieuIn item = new DMDichVu_PhieuIn(
     i,
     dr.GetString("MaPhieu") ,
     dr.GetString("TenPhieu") ,
     dr.GetString("Ghichu") ,
     dr.GetString("MaMay") ,
     dr.GetBoolean("Huy") ,
     dr.GetSmartDate("NgayHuy",false ) ,
     dr.GetString("NguoiHuy") ,
     dr.GetSmartDate("NgayLap",false) ,
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDichVu_PhieuIn(criteria.DK, false)))
               
                   
                        {
                        int i = 1;
                        //IsReadOnly = false;
                        while (dr.Read())
                        {

                            DMDichVu_PhieuIn item = new DMDichVu_PhieuIn(
             i,
             dr.GetString("MaPhieu"),
             dr.GetString("TenPhieu"),
             dr.GetString("Ghichu"),
             dr.GetString("MaMay"),
             dr.GetBoolean("Huy"),
             dr.GetSmartDate("NgayHuy", false),
             dr.GetString("NguoiHuy"),
             dr.GetSmartDate("NgayLap", false),
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
