using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business
{
    [Serializable()]
    public class WorkflowRole: BusinessBase<WorkflowRole>
    {
        #region Business Methods

        int _IdWorkflow;
        public int IdWorkflow
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _IdWorkflow;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                CanWriteProperty(true);
                if (!_IdWorkflow.Equals(value))
                {
                    _IdWorkflow = value;
                    PropertyHasChanged();
                }
            }
        }

        string _WorkflowName = string.Empty;
        public string WorkflowName
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _WorkflowName;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                CanWriteProperty(true);
                if (!_WorkflowName.Equals(value))
                {
                    _WorkflowName = value;
                    PropertyHasChanged();
                }
            }
        }

        string _ClassName = string.Empty;
        public string ClassName
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _ClassName;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                CanWriteProperty(true);
                if (!_ClassName.Equals(value))
                {
                    _ClassName = value;
                    PropertyHasChanged();
                }
            }
        }

        string _AssemblyName = string.Empty;
        public string AssemblyName
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _AssemblyName;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                CanWriteProperty(true);
                if (!_AssemblyName.Equals(value))
                {
                    _AssemblyName = value;
                    PropertyHasChanged();
                }
            }
        }

        string _Description = string.Empty;
        public string Description
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _Description;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                CanWriteProperty(true);
                if (!_Description.Equals(value))
                {
                    _Description = value;
                    PropertyHasChanged();
                }
            }
        }


        protected override object GetIdValue()
        {
            return _IdWorkflow;
        }

        #endregion

        #region Validation Rules

        protected override void AddBusinessRules()
        {
            // TODO: add validation rules
        }

        #endregion

        #region Authorization Rules

        protected override void AddAuthorizationRules()
        {
            // TODO: add authorization rules
        }

        #endregion

        #region Factory Methods

        public static WorkflowRole NewWorkflowRole(int IdWorkflow)
        {
            return new WorkflowRole(HTC.Business.Workflow.GetWorkflow(IdWorkflow));
        }

        public static WorkflowRole GetWorkflowRole(SafeDataReader dr)
        {
            return new WorkflowRole(dr);
        }

        public static bool AllowWorkflow(string className, string workflowName, string assemblyName)
        {
            //int idUser = ((HTC.Security.HTCIdentity)Csla.ApplicationContext.User.Identity).UserID;
            string idUser = ((HTC.Security.HTCIdentity)Csla.ApplicationContext.User.Identity).Name ;// sua tu int sang string 12/12/2008
            // Xoa cache
            Officer.RoleByUserList.InvalidateCache();
            Officer.RoleByUserList roles = Officer.RoleByUserList.GetList(idUser);
            int result = 0;
            for (int i = 0; i < roles.Count; i++)
            {

                using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().CheckRoleForm(roles[i].Key, className, workflowName, assemblyName)))
                {
                    if (dr.Read())
                    {
                        result = dr.GetInt32("Amount");
                    }
                }
                if (result > 0)
                {
                    return true;
                }
            }
            return false;
        }

        private WorkflowRole()
        {
            MarkAsChild();
        }

        #endregion

        #region Data Access

        private WorkflowRole(Workflow wf)
        {
            MarkAsChild();
            _IdWorkflow  = wf.IdWorkflow;
            _WorkflowName = wf.WorkflowName;
            _ClassName = wf.ClassName;
            _AssemblyName = wf.AssemblyName;
            _Description = wf.Description;
        }

        private WorkflowRole(SafeDataReader dr)
        {
            MarkAsChild();
            _IdWorkflow = dr.GetInt32("IdWorkflow");
            _WorkflowName = dr.GetString("WorkflowName");
            _ClassName = dr.GetString("ClassName");
            _AssemblyName = dr.GetString("AssemblyName");
            _Description = dr.GetString("Description");
            MarkOld();
        }

        internal void Insert(Officer.Role role)
        {
            if (IsDirty)
            {
                Assignment.AddWorkflowToRole(role.IdRole, _IdWorkflow);
                MarkOld();
            }
        }

        internal void Update(Officer.Role role)
        {
            if (IsDirty)
            {
                Assignment.AddWorkflowToRole(role.IdRole, _IdWorkflow);
                MarkOld();
            }
        }

        internal void DeleteSelf(Officer.Role role)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;

            Assignment.RemoveWorkflowFromRole(role.IdRole, _IdWorkflow);
            MarkNew();
        }

        #endregion
    }
}
