using System;
using System.Collections.Generic;
using System.Text;
using Csla;

namespace HTC.Business.Officer
{
    [Serializable()]
    public class RoleListInfo: ReadOnlyBase<RoleListInfo>
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
                if (!_IdRole.Equals(value))
                {
                    _IdRole = value;
                }
            }
        }

        string  _RoleName;
        public string  RoleName
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
                if (!_RoleName.Equals(value))
                {
                    _RoleName = value;
                }
            }
        }

        string _Description;
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
                if (!_Description.Equals(value))
                {
                    _Description = value;
                }
            }
        }

        protected override object GetIdValue()
        {
            return _IdRole;
        }

        #endregion

        #region Constructors

        private RoleListInfo()
        { /* require use of factory methods */ }

        internal RoleListInfo(int id, string name, string description)
        {
            _IdRole = id;
            _RoleName = name;
            _Description = description;
        }

        #endregion
    }
}
