using System;
using System.Collections.Generic;
using System.Text;
//1
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMDanhGia_CS_KQList : BusinessListBase<DMDanhGia_CS_KQList, DMDanhGia_CS_KQ>
    {
        #region Factory Methods
        public static DMDanhGia_CS_KQList GetAllDMDanhGia_CS_KQ(String maCS)
        {
            return DataPortal.Fetch<DMDanhGia_CS_KQList>(new Criteria(maCS));
        }

        public void NewTo(DMDanhGia_CS_KQ _DMDanhGia_CS_KQ)
        {
            if (this.Count == 0)
                _DMDanhGia_CS_KQ.OrderNumber = 1;
            else
                _DMDanhGia_CS_KQ.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMDanhGia_CS_KQ);
        }
        public void UpdatedTo(DMDanhGia_CS_KQ _DMDanhGia_CS_KQ)
        {

            _DMDanhGia_CS_KQ.OrderNumber = this.Items[this.IndexOf(_DMDanhGia_CS_KQ)].OrderNumber;
            this.Items[this.IndexOf(_DMDanhGia_CS_KQ)] = _DMDanhGia_CS_KQ;
        }
        public void RemoveTo(DMDanhGia_CS_KQ _DMDanhGia_CS_KQ)
        {
            this.Items.Remove(_DMDanhGia_CS_KQ);

        }

        private DMDanhGia_CS_KQList()
        {  /* Require use of factory methods */ }

        #endregion
        #region Authorization Rules

        public static bool CanAddObject()
        {
            return true;
        }

        public static bool CanGetObject()
        {
            return true;
        }

        public static bool CanDeleteObject()
        {
            return true;
        }

        public static bool CanEditObject()
        {
            return true;
        }

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
                    _DK = "MaCS like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenCS)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDanhGia_CS_KQ(criteria.MaDV, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMDanhGia_CS_KQ item = new DMDanhGia_CS_KQ(
     i,
     dr.GetString("MaThuoc"),
                                            dr.GetString("MaCS"),
                                            dr.GetString("TenTM"),
                                            dr.GetString("TenDVT"),
                                             dr.GetString("YeuCauTT"),
                                              dr.GetString("YeuCau"),
                                               dr.GetDecimal("GHTu"),
                                                dr.GetDecimal("GHDen"),
                                            dr.GetString("Ghichu"),
                                            dr.GetString("MaMay"),
                                            dr.GetSmartDate("NgaySD", true),
                                            dr.GetString("NguoiSD"),
                                            dr.GetBoolean("Huy"),
     dr.GetString("hoten"),
       dr.GetString("MaDG"),
         dr.GetString("TenDG"),
         dr.GetString("TenCS"),
                                               dr.GetDecimal("DonGiaTT")
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDanhGia_CS_KQ(criteria.DK, false)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMDanhGia_CS_KQ item = new DMDanhGia_CS_KQ(
     i,
     dr.GetString("MaThuoc"),
                                            dr.GetString("MaCS"),
                                            dr.GetString("TenTM"),
                                            dr.GetString("TenDVT"),
                                             dr.GetString("YeuCauTT"),
                                              dr.GetString("YeuCau"),
                                               dr.GetDecimal("GHTu"),
                                                dr.GetDecimal("GHDen"),
     dr.GetString("Ghichu"),
     dr.GetString("MaMay"),
     dr.GetSmartDate("NgaySD", true),
     dr.GetString("NguoiSD"),
     dr.GetBoolean("Huy"),
     dr.GetString("hoten"),
       dr.GetString("MaDG"),
         dr.GetString("TenDG"),
         dr.GetString("TenCS"),
                                               dr.GetDecimal("DonGiaTT")
         );
                    this.Add(item);
                    i += 1;

                }
                //IsReadOnly = true;
            }

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMDanhGia_CS_KQ item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMDanhGia_CS_KQ item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMDanhGia_CS_KQList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMDanhGia_CS_KQList result;
            result = base.Save();
            return result;
        }
        #endregion
    }
}
