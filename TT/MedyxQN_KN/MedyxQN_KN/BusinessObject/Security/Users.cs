using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using Csla;
using Csla.Data;


namespace HTC.Business.Security
{
    [Serializable()]
    public class Users:ReadOnlyListBase<Users, UserInfo>
    {
        #region Factory Methods

        public static Users GetUsers()
        {
          return DataPortal.Fetch<Users>(new Criteria());
        }

        private Users()
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
            ArrayList arrList;
            //arrList = CBO.FillCollection(DataProvider.Instance().GetUsers(), typeof(UserInfo));
            IsReadOnly = false;
            //foreach (UserInfo obj in arrList)
            //{
            //    this.Add(obj);
            //}
            IsReadOnly = true;
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
    }
}
