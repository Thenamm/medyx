using System;
using System.Collections.Generic;
using System.Text;
using Csla;

namespace HTC.Business.Security
{
    [Serializable()]
    public class UserInfo:ReadOnlyBase<UserInfo>
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
                if (!_IdUser.Equals(value))
                {
                    _IdUser = value;
                }
            }
        }

        string _Username = string.Empty;
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
                if (!_Username.Equals(value))
                {
                    _Username = value;
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
                if (!_EmployeeName.Equals(value))
                {
                    _EmployeeName = value;
                }
            }
        }

        protected override object GetIdValue()
        {
            return _IdUser;
        }

        #endregion

        #region Authorization Rules

        protected override void AddAuthorizationRules()
        {
            // TODO: add authorization rules
        }

        #endregion
    }
}
