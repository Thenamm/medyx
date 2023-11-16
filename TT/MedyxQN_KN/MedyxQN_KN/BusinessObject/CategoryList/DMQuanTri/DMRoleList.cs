using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using HTC.Business;////
using Csla.Data;
 //using System.Windows.Forms;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMRoleList : BusinessListBase<DMRoleList, DMRole>
    {
        #region Factory Methods
        public static DMRoleList GetAllDMRole(Boolean _qadmin)
        {
            return DataPortal.Fetch<DMRoleList>(new Criteria(_qadmin));
        }
        public static DMRoleList FindDMRoleByMaRole(String maRole)
        {
            return DataPortal.Fetch<DMRoleList>(new CriteriaOther(1, maRole));
        }
        public static DMRoleList FindDMRoleByTenRole(String TenRole)
        {
            return DataPortal.Fetch<DMRoleList>(new CriteriaOther(2, TenRole));
        }
        public static DMRoleList FindDMRoleByTenRoleD(String TenRole)
        {
            return DataPortal.Fetch<DMRoleList>(new CriteriaOther(3, TenRole));
        }
        public void NewTo(DMRole _DMRole)
        {
            if (this.Count == 0)
                _DMRole.OrderNumber = 1;
            else
            _DMRole.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_DMRole);
        }
        public void UpdatedTo(DMRole _DMRole)
        {

            _DMRole.OrderNumber = this.Items[this.IndexOf(_DMRole)].OrderNumber;
            this.Items[this.IndexOf(_DMRole)] = _DMRole;
        }
        public void RemoveTo(DMRole _DMRole)
        {
            this.Items.Remove(_DMRole);

        }
        private DMRoleList()
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
            private String _makho;


            public Criteria(Boolean qadmin)
            {
                _qadmin = qadmin;

            }
        }

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
                    _DK = "A.MaRole like '" + mDK + "%'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(A.TenRole)) like N'" + mDK + "%'";
                else if (mIdFind ==3)
                    _DK = "ltrim(rtrim(A.TenRole)) = N'" + mDK + "'";


            }
        }
        #endregion

        #endregion



        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMRole(criteria.qadmin)))
            {

                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())// phai trung voi trat tu cac truong ben DMRole vao phuong thuc (internal DMRole)
                {
                    try
                    {
                        DMRole item = new DMRole(
     i,
     dr.GetString("MaRole"),
     dr.GetString("TenRole"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD", true),
     dr.GetString("NguoiSD"),
     dr.GetString("HoTen")
  );

                        this.Add(item);
                        i += 1;
                    }
                    catch (Exception ex)
                    {
                       //MessageBox.Show(ex.ToString());
                    }

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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMRole(criteria.DK, false)))
            {
                // IsReadOnly = false;
                while (dr.Read())
                {
                    DMRole item = new DMRole(
    i,
    dr.GetString("MaRole"),
    dr.GetString("TenRole"),
    dr.GetString("MaMay"),
    dr.GetBoolean("Huy"),
    dr.GetSmartDate("NgaySD", true),
    dr.GetString("NguoiSD"),
    dr.GetString("HoTen")
                   );

                    this.Add(item);
                    i += 1;
                }
                // IsReadOnly = true;
            }


            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion

    }
}
