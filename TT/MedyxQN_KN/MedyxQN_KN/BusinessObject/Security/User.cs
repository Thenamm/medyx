using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.Security
{
    [Serializable()]
    public class User: BusinessBase<User>
    {
        #region Business Methods

        int _IdUser;
        public int IdUser
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _IdUser;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                CanWriteProperty(true);
                if (!_IdUser.Equals(value))
                {
                    _IdUser = value;
                    PropertyHasChanged();
                }
            }
        }

        string _Username = string.Empty ;
        public string Username
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _Username;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                CanWriteProperty(true);
                if (!_Username.Equals(value))
                {
                    _Username = value;
                    PropertyHasChanged();
                }
            }
        }

        string _Password = string.Empty;
        public string Password
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _Password;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                CanWriteProperty(true);
                if (!_Password.Equals(value))
                {
                    _Password = value;
                    PropertyHasChanged();
                }
            }
        }

        int _IdEmployee;
        public int IdEmployee
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _IdEmployee;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                CanWriteProperty(true);
                if (!_IdEmployee.Equals(value))
                {
                    _IdEmployee = value;
                    PropertyHasChanged();
                }
            }
        }

        string _EmployeeName = string.Empty;
        public string EmployeeName
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _EmployeeName;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                CanWriteProperty(true);
                if (!_EmployeeName.Equals(value))
                {
                    _EmployeeName = value;
                    PropertyHasChanged();
                }
            }
        }

        RoleUsers _Roles = RoleUsers.NewRoleUsers();
        public RoleUsers Roles
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _Roles;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                CanWriteProperty(true);
                if (!_Roles.Equals(value))
                {
                    _Roles = value;
                    PropertyHasChanged();
                }
            }
        }

        //WorkingSpaces _WorkingLocations = WorkingSpaces.NewWorkingSpaces();
        //public WorkingSpaces WorkingLocations
        //{
        //    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        //    get
        //    {
        //        return _WorkingLocations;
        //    }
        //}

        public override bool IsValid
        {
            get
            {
                return base.IsValid && _Roles.IsValid;// && _WorkingLocations.IsValid;
            }
        }

        public override bool IsDirty
        {
            get
            {
                return base.IsDirty ||  _Roles.IsDirty;// ||_WorkingLocations.IsDirty
            }
        }
        

        protected override object GetIdValue()
        {
            return _IdUser;
        }

        #endregion

        #region Validation Rules

        protected override void AddBusinessRules()
        {
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "Username");
        }

        #endregion

        #region Authorization Rules

        protected override void AddAuthorizationRules()
        {
            // TODO: add authorization rules
        }

        #endregion

        #region Factory Methods

        public static User NewUser()
        {
            return DataPortal.Create<User>();
        }

        public static User GetUser(int id)
        {
            return DataPortal.Fetch<User>(new Criteria(id));
        }

        public static void DeleteUser(int id)
        {
            DataPortal.Delete(new Criteria(id));
        }

        public void DeleteAllRole()
        {
            DataProvider.Instance().DeleteAllRole(_IdUser);
        }

        public void AssignRole(int IdRole)
        {
            DataProvider.Instance().AssignRole(_IdUser, IdRole);
        }

        private User()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetUser(criteria.Id)))
            {
                if (dr.Read())
                {
                    _IdUser = dr.GetInt32("IdUser");
                    _Username = dr.GetString("UserName");
                    _Password = dr.GetString("Password");
                    _IdEmployee = dr.GetInt32("IdEmployee");
                    _EmployeeName = dr.GetString("EmployeeName");

                    dr.NextResult();
                    _Roles = RoleUsers.GetRoleUsers(dr);
                    dr.NextResult();
                    //_WorkingLocations = WorkingSpaces.GetWorkingSpaces(dr);
                }
            }
        }

        //[Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_Insert()
        {
            _IdUser = DataProvider.Instance().InsertUser(_Username,_Password,_IdEmployee);
            // update child objects
            _Roles.Update(this);
            //_WorkingLocations.Update(this);
        }

        //[Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_Update()
        {
            if (IsDirty)
            {
                DataProvider.Instance().UpdateUser(_IdUser, _Username, _Password, _IdEmployee);
            }
            // update child objects
            _Roles.Update(this);
            //_WorkingLocations.Update(this);
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new Criteria(_IdUser));
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        private void DataPortal_Delete(Criteria criteria)
        {
            DataProvider.Instance().DeleteUser(criteria.Id);
        }

        #endregion
    }
}
