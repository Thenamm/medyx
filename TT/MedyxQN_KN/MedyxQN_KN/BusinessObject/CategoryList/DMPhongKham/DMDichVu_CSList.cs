using System;
using System.Collections.Generic;
using System.Text;
//1
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMDichVu_CSList : BusinessListBase<DMDichVu_CSList, DMDichVu_CS>
    {
        #region Factory Methods
        public static DMDichVu_CSList GetAllDMDichVu_CS(String maDV)
        {
            return DataPortal.Fetch<DMDichVu_CSList>(new Criteria(maDV));
        }

        public void NewTo(DMDichVu_CS _DMDichVu_CS)
        {
            if (this.Count == 0)
                _DMDichVu_CS.OrderNumber = 1;
            else
            _DMDichVu_CS.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMDichVu_CS);
        }
        public void UpdatedTo(DMDichVu_CS _DMDichVu_CS)
        {

            _DMDichVu_CS.OrderNumber = this.Items[this.IndexOf(_DMDichVu_CS)].OrderNumber;
            this.Items[this.IndexOf(_DMDichVu_CS)] = _DMDichVu_CS;
        }
        public void RemoveTo(DMDichVu_CS _DMDichVu_CS)
        {
            this.Items.Remove(_DMDichVu_CS);

        }

        private DMDichVu_CSList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDichVu_CS(criteria.MaDV , criteria.qadmin )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMDichVu_CS item = new DMDichVu_CS(
     i,
     dr.GetString("MaCS") ,
			                                dr.GetString("MaDV")  ,
			                                dr.GetString("TenCS")  ,
			                                dr.GetString("ChisocaoNam") ,
			                                dr.GetString("ChisocaoNu"),
			                                dr.GetString("ChisothapNu") ,
			                                dr.GetString("ChisothapNam") ,
                                             dr.GetString("Chisoin"),
			                                dr.GetString("Donvi") ,
			                                dr.GetString("Ghichu") ,
			                                dr.GetString("MaMay") ,
			                                dr.GetSmartDate("NgaySD", true) ,
			                                dr.GetString("NguoiSD") ,
			                                dr.GetBoolean("Huy"),
     dr.GetString("hoten"),
                                            dr.GetInt32("STTIn"),
                                            dr.GetString("MaCSBH"),
                                            dr.GetString("TenCSBH")
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDichVu_CS(criteria.DK, false)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    DMDichVu_CS item = new DMDichVu_CS(
     i,
     dr.GetString("MaCS"),
     dr.GetString("MaDV"),
     dr.GetString("TenCS"),
     dr.GetString("ChisocaoNam"),
     dr.GetString("ChisocaoNu"),
     dr.GetString("ChisothapNu"),
     dr.GetString("ChisothapNam"),
      dr.GetString("Chisoin"),
     dr.GetString("Donvi"),
     dr.GetString("Ghichu"),
     dr.GetString("MaMay"),
     dr.GetSmartDate("NgaySD", true),
     dr.GetString("NguoiSD"),
     dr.GetBoolean("Huy"),
     dr.GetString("hoten"),
     dr.GetInt16("sttin"),
                                            dr.GetString("MaCSBH"),
                                            dr.GetString("TenCSBH")
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
