using System;
using System.Collections.Generic;
using System.Text;
//1
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMDichVu_CS_KQList : BusinessListBase<DMDichVu_CS_KQList, DMDichVu_CS_KQ>
    {
        #region Factory Methods
        public static DMDichVu_CS_KQList GetAllDMDichVu_CS_KQ(String maCS)
        {
            return DataPortal.Fetch<DMDichVu_CS_KQList>(new Criteria(maCS));
        }

        public void NewTo(DMDichVu_CS_KQ _DMDichVu_CS_KQ)
        {
            if (this.Count == 0)
                _DMDichVu_CS_KQ.OrderNumber = 1;
            else
            _DMDichVu_CS_KQ.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMDichVu_CS_KQ);
        }
        public void UpdatedTo(DMDichVu_CS_KQ _DMDichVu_CS_KQ)
        {

            _DMDichVu_CS_KQ.OrderNumber = this.Items[this.IndexOf(_DMDichVu_CS_KQ)].OrderNumber;
            this.Items[this.IndexOf(_DMDichVu_CS_KQ)] = _DMDichVu_CS_KQ;
        }
        public void RemoveTo(DMDichVu_CS_KQ _DMDichVu_CS_KQ)
        {
            this.Items.Remove(_DMDichVu_CS_KQ);

        }

        private DMDichVu_CS_KQList()
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
            private String _MaCS;
            private Boolean _qadmin = false ;
            public String MaCS
            {
                get
                {
                    return _MaCS;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public Criteria(String mMaCS)
            {
                _MaCS = mMaCS;
                
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
                    _DK = "MaFile like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenHT)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDichVu_CS_KQ(criteria.MaCS , criteria.qadmin )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMDichVu_CS_KQ item = new DMDichVu_CS_KQ(
     i,
     dr.GetString("MaKQ") ,
			                                dr.GetString("MaCS")  ,
                                             dr.GetString("MaKQ"),
                                            dr.GetString("MaCS"),
			                                dr.GetString("TenKQ")  ,
			                             
			                                dr.GetString("Ghichu") ,
			                                dr.GetString("MaMay") ,
			                                dr.GetSmartDate("NgaySD", true) ,
			                                dr.GetString("NguoiSD") ,
			                                dr.GetBoolean("Huy"),
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
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDichVu_CS_KQ(criteria.DK, false)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMDichVu_CS_KQ item = new DMDichVu_CS_KQ(
     i,
     dr.GetString("MaKQ"),
     dr.GetString("MaCS"),
       dr.GetString("MaKQ"),
                                            dr.GetString("MaCS"),
     dr.GetString("TenKQ"),
   
     dr.GetString("Ghichu"),
     dr.GetString("MaMay"),
     dr.GetSmartDate("NgaySD", true),
     dr.GetString("NguoiSD"),
     dr.GetBoolean("Huy"),
     dr.GetString("hoten") 
         );
                    this.Add(item);
                    i += 1;

                }
                //IsReadOnly = true;
            }
           
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        public override DMDichVu_CS_KQList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMDichVu_CS_KQList result;
            result = base.Save();
            return result;
        }
        #endregion

    }
}
