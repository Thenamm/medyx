using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.Officer
{
    [Serializable()]
    public class RoleList:ReadOnlyListBase<RoleList, RoleListInfo>
    {
        #region Factory Methods
        public static RoleList GetRoleList()
        {
            return DataPortal.Fetch<RoleList>(new Criteria());
        }

        private RoleList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
        }

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetRoleList()))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    RoleListInfo item = new RoleListInfo(
         dr.GetInt32("IdRole"),
         dr.GetString("RoleName"),
         dr.GetString("Description"));
                    this.Add(item);
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

        #endregion
    }
}
