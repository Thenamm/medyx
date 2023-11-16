using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMTheBHList : ReadOnlyListBase<DMTheBHList, DMTheBH>
    {
        #region Factory Methods
        public static DMTheBHList GetAllDMTheBH()
        {
            return DataPortal.Fetch<DMTheBHList>(new Criteria());
        }
        public static DMTheBHList FindDMTheBHByMaThe(string MaThe)
        {
            return DataPortal.Fetch<DMTheBHList>(new CriteriaOther(1, MaThe));
        }
        private DMTheBHList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            //private int _id;
            //public int Id
            //{
            //    get
            //    {
            //        return _id;
            //    }
            //}
            //public Criteria(int mId)
            //{
            //    _id = mId;
            //}
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
            public CriteriaOther(Byte mIdFind, String mDK)
            {

                _IdFind = mIdFind;
                if (mIdFind == 1)
                    _DK = "A.mathebh = '" + mDK + "'";
                //else if (mIdFind == 2)
                //    _DK = "ltrim(rtrim(TenTheBH)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMTheBH(HTC.ShareVariables.pub_bQadmin    )))
            {
                int i = 1;

                IsReadOnly = false;
                while (dr.Read())
                {
                    DMTheBH item = new DMTheBH(
     i,
     dr.GetString("MaTheBH") ,
			                                dr.GetString("TenTheBH") ,
			                                dr.GetString("Doituong") ,
			                                dr.GetInt32("Miengiam") ,
			                                dr.GetInt32("Loaithe") ,
     dr.GetByte("DTThe"),
			                                dr.GetString("MaDT") ,
			                                dr.GetSmartDate("NgaySD", true) ,
			                                dr.GetString("NguoiSD") ,
			                                dr.GetBoolean("Huy") ,
			                                dr.GetString("MaMay") ,
     dr.GetString("HoTen") ,
     dr.GetString("TenDT")
    
         );
                    this.Add(item);
                    i += 1;

                }
                IsReadOnly = true;
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMTheBH(criteria.DK, criteria.qadmin)))
            {
                int i = 1;

                IsReadOnly = false;
                while (dr.Read())
                {
                    DMTheBH item = new DMTheBH(
     i,
     dr.GetString("MaTheBH"),
     dr.GetString("TenTheBH"),
     dr.GetString("Doituong"),
     dr.GetInt32("Miengiam"),
     dr.GetInt32("Loaithe"),
     dr.GetByte("DTThe"),
     dr.GetString("MaDT"),
     dr.GetSmartDate("NgaySD", true),
     dr.GetString("NguoiSD"),
     dr.GetBoolean("Huy"),
     dr.GetString("MaMay"),
     dr.GetString("HoTen"),
     dr.GetString("TenDT")

         );
                    this.Add(item);
                    i += 1;

                }
                IsReadOnly = true;
            }
            

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        #endregion
    }
}
