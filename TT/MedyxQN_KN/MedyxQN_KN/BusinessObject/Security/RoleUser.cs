using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.Security
{
    [Serializable()]
    public class RoleUser: BusinessBase<RoleUser>
    {
        #region Business Methods

        int _RoleId;
        public int RoleId
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _RoleId;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                CanWriteProperty(true);
                if (!_RoleId.Equals(value))
                {
                    _RoleId = value;
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
                if (!_RoleName.Equals(value))
                {
                    _RoleName = value;
                    PropertyHasChanged();
                }
            }
        }

        protected override object GetIdValue()
        {
            return _RoleId;
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

        public static RoleUser NewRoleUser(int IdRole)
        {
            return new RoleUser(HTC.Business.Officer.Role.GetRole(IdRole));
        }

        public static RoleUser GetRoleUser(SafeDataReader dr)
        {
            return new RoleUser(dr);
        }

        private RoleUser()
        {
            MarkAsChild();
        }

        #endregion

        #region Data Access

        private RoleUser(Officer.Role  role)
        {
            MarkAsChild();
            _RoleId  = role.IdRole;
            _RoleName = role.RoleName;
        }

        private RoleUser(SafeDataReader dr)
        {
            MarkAsChild();
            _RoleId = dr.GetInt32("IdRole");
            _RoleName = dr.GetString("RoleName");
            MarkOld();
        }

        internal void Insert(User user)
        {
            if (IsDirty)
            {
                Assignment.AddRoleToUser(user.IdUser, _RoleId);
                MarkOld();
            }
        }

        internal void Update(User user)
        {
            if (IsDirty)
            {
                Assignment.AddRoleToUser(user.IdUser, _RoleId);
                MarkOld();
            }
        }

        internal void DeleteSelf(User user)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;

            Assignment.RemoveRoleFromUser(user.IdUser, _RoleId);
            MarkNew();
        }

        #endregion
    }
}
