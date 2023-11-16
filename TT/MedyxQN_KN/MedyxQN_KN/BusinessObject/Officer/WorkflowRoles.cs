using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business
{
    [Serializable()]
    public class WorkflowRoles:BusinessListBase<WorkflowRoles,WorkflowRole>
    {
        #region Business Methods

        public WorkflowRole this[int idWorkflow]
        {
            get
            {
                foreach (WorkflowRole obj in this)
                    if (obj.IdWorkflow.Equals(idWorkflow))
                        return obj;
                return null;
            }
        }

        public void AssignTo(int IdWorkflow)
        {
            if (!Contains(IdWorkflow))
            {
                WorkflowRole obj = WorkflowRole.NewWorkflowRole(IdWorkflow);
                this.Add(obj);
            }
            //else
            //    throw new InvalidOperationException("Workflow already assigned to project");
        }

        public void Remove(int IdWorkflow)
        {
            foreach (WorkflowRole obj in this)
            {
                if (obj.IdWorkflow.Equals(IdWorkflow))
                {
                    Remove(obj);
                    break;
                }
            }
        }

        public bool Contains(int IdWorkflow)
        {
            foreach (WorkflowRole obj in this)
                if (obj.IdWorkflow == IdWorkflow)
                    return true;
            return false;
        }

        public bool ContainsDeleted(int IdWorkflow)
        {
            foreach (WorkflowRole obj in DeletedList)
                if (obj.IdWorkflow == IdWorkflow)
                    return true;
            return false;
        }

        #endregion

        #region Factory Methods

        internal static WorkflowRoles NewWorkflowRoles()
        {
            return new WorkflowRoles();
        }

        internal static WorkflowRoles GetWorkflowRoles(SafeDataReader dr)
        {
            return new WorkflowRoles(dr);
        }

        private WorkflowRoles()
        {
            MarkAsChild();
        }

        private WorkflowRoles(SafeDataReader dr)
        {
            MarkAsChild();
            Fetch(dr);
        }

        #endregion

        #region Data Access

        private void Fetch(SafeDataReader dr)
        {
            RaiseListChangedEvents = false;
            while (dr.Read())
                this.Add(WorkflowRole.GetWorkflowRole(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(Officer.Role role)
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (WorkflowRole item in DeletedList)
                item.DeleteSelf(role);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (WorkflowRole item in this)
            {
                if (item.IsNew)
                    item.Insert(role);
                else
                    item.Update(role);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
    }
}
