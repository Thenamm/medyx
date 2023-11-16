using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.Officer
{
    [Serializable()]
    public class Role: BusinessBase<Role>
    {
        #region Business Methods

        int _IdRole;
        public int IdRole
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _IdRole;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                CanWriteProperty(true);
                if (!_IdRole.Equals(value))
                {
                    _IdRole = value;
                    PropertyHasChanged();
                }
            }
        }

        string _RoleName = string.Empty;
        public string RoleName
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _RoleName;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                CanWriteProperty(true);
                if (value == null)
                    value = value.Trim();
                if (_RoleName.Length == 0 || !_RoleName.Equals(value))
                {
                    value = value.Trim();
                    if (value.Length == 0)
                        value = string.Empty;
                    _RoleName = value;
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

        WorkflowRoles _Workflows = WorkflowRoles.NewWorkflowRoles();
        public WorkflowRoles Workflows
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _Workflows;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                CanWriteProperty(true);
                if (!_Workflows.Equals(value))
                {
                    _Workflows = value;
                    PropertyHasChanged();
                }
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid && _Workflows.IsValid ;
            }
        }

        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _Workflows.IsDirty;
            }
        }

        protected override object GetIdValue()
        {
            return _IdRole;
        }

        #endregion

        #region Validation Rules

        protected override void AddBusinessRules()
        {
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "RoleName");
        }

        #endregion

        #region Authorization Rules

        protected override void AddAuthorizationRules()
        {
            // TODO: add authorization rules
        }

        #endregion

        #region Factory Methods

        public static Role NewRole()
        {
          return DataPortal.Create<Role>();
        }

        public static Role GetRole(int id)
        {
          return DataPortal.Fetch<Role>(new Criteria(id));
        }

        public static void DeleteRole(int id)
        {
          DataPortal.Delete(new Criteria(id));
        }

        public void ClearFormPermission()
        {
            DataProvider.Instance().DeleteAllFormPermission(_IdRole);
        }

        private Role()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            private int mId;
            public int Id
            {
                get
                {
                    return mId;
                }
            }
            public Criteria(int id)
            {
                mId = id;
            }
        }

        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }

        private void DataPortal_Fetch(Criteria criteria)
        {
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetRole(criteria.Id)))
            {
                if (dr.Read())
                {
                    _IdRole = dr.GetInt32("IdRole");
                    _RoleName = dr.GetString("RoleName");
                    _Description = dr.GetString("Description");

                    dr.NextResult();
                    _Workflows = WorkflowRoles.GetWorkflowRoles(dr);
                }
            }
        }

        protected override void DataPortal_Insert()
        {
            _IdRole = DataProvider.Instance().InsertRole(_RoleName, _Description);
            // update child objects
            _Workflows.Update(this);
        }

        protected override void DataPortal_Update()
        {
            if (IsDirty)
                DataProvider.Instance().UpdateRole(_IdRole, _RoleName, _Description);
            _Workflows.Update(this);
        }

        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new Criteria(_IdRole));
        }

        private void DataPortal_Delete(Criteria criteria)
        {
            DataProvider.Instance().DeleteRole(criteria.Id);
        }

        #endregion
    }
}
