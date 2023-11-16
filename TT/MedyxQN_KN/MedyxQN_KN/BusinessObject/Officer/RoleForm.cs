using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.Officer
{
    [Serializable()]
    public class RoleForm: BusinessBase<RoleForm>
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

        int _IdForm;
        public int IdForm
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _IdForm;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                CanWriteProperty(true);
                if (!_IdForm.Equals(value))
                {
                    _IdForm = value;
                    PropertyHasChanged();
                }
            }
        }

        string _FormName = string.Empty;
        public string FormName
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _FormName;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                CanWriteProperty(true);
                if (!_FormName.Equals(value))
                {
                    _FormName = value;
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

        bool _CanRead;
        public bool CanRead
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _CanRead;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                CanWriteProperty(true);
                if (!_CanRead.Equals(value))
                {
                    _CanRead = value;
                    PropertyHasChanged();
                }
            }
        }

        bool _CanDelete;
        public bool CanDelete
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _CanDelete;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                CanWriteProperty(true);
                if (!_CanDelete.Equals(value))
                {
                    _CanDelete = value;
                    PropertyHasChanged();
                }
            }
        }

        bool _CanUpdate;
        public bool CanUpdate
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _CanUpdate;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                CanWriteProperty(true);
                if (!_CanUpdate.Equals(value))
                {
                    _CanUpdate = value;
                    PropertyHasChanged();
                }
            }
        }

        bool _CanCreate;
        public bool CanCreate
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _CanCreate;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                CanWriteProperty(true);
                if (!_CanCreate.Equals(value))
                {
                    _CanCreate = value;
                    PropertyHasChanged();
                }
            }
        }

        protected override object GetIdValue()
        {
            return _IdForm;
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

        public static bool CanAddObject()
        {
            /// TODO: viết chi tiết quyền thêm mới Object vào đây.
            return true;
        }

        public static bool CanDeleteObject()
        {
            // TODO: viết chi tiết quyền xóa một đối tượng.
            return true;
        }

        #endregion

        #region Factory Methods

        public static RoleForm NewRoleForm()
        {
            return new RoleForm();
        }

        public static RoleForm GetRoleForm(SafeDataReader dr)
        {
            return new RoleForm(dr);
        }

        public static RoleForm GetRoleForm(int roleId, string formName)
        {
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetPermission(roleId, formName)))
            {
                if (dr.Read())
                {
                    return new RoleForm(dr);
                }
            }
            return null;
        }

        public void SaveData()
        {
            this.Update();
        }

        public RoleForm()
        {
            MarkAsChild();
        }


        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            private int mIdRole;
            private int mIdForm;

            public int IdRole
            {
                get
                {
                    return mIdRole;
                }
            }
            public int IdForm
            {
                get
                {
                    return mIdForm;
                }
            }
            public Criteria(int idRole, int idForm)
            {
                mIdRole = idRole;
                mIdForm = idForm;
            }
        }

        private RoleForm(SafeDataReader dr)
        {
            MarkAsChild();
            _IdForm = dr.GetInt32("IdForm");
            _IdRole = dr.GetInt32("IdRole");
            _FormName = dr.GetString("FormName");
            _Description = dr.GetString("Description");
            _CanCreate = System.Convert.ToBoolean(dr.GetByte("Insert"));
            _CanDelete = System.Convert.ToBoolean(dr.GetByte("Delete"));
            _CanRead = System.Convert.ToBoolean(dr.GetByte("Read"));
            _CanUpdate = System.Convert.ToBoolean(dr.GetByte("Modify"));
            MarkOld();
        }

        internal void Insert()
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;
            DataProvider.Instance().InsertRoleForm(_IdRole, _IdForm, _CanCreate, _CanRead, _CanUpdate, _CanDelete);
            MarkOld();
        }

        internal void Update()
        {
            // if we're not dirty then don't update the database.
            if (!this.IsDirty)
                return;

            DataProvider.Instance().UpdateRoleForm(_IdRole, _IdForm, _CanCreate, _CanRead, _CanUpdate, _CanDelete);
            MarkOld();
        }

        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            DataPortal_Delete(new Criteria(_IdRole, _IdForm));
            MarkNew();
        }

        private void DataPortal_Delete(Criteria criteria)
        {
            DataProvider.Instance().DeleteRoleForm(criteria.IdRole, criteria.IdForm);
        }

        #endregion
    }
}
