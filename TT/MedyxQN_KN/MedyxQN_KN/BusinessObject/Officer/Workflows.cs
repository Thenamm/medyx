using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business
{
    [Serializable()]
    public class Workflows: BusinessListBase<Workflows, Workflow>
    {
        #region Factory Methods
        public static Workflows GetWorkflows()
        {
            return DataPortal.Fetch<Workflows>(new Criteria());
        }

        private Workflows()
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
            //arrList = CBO.FillCollection(DataProvider.Instance().GetWorkflows(), typeof(Workflow));
            //foreach (Workflow obj in arrList)
            //{
            //    this.Add(obj);
            //}
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
    }
}
