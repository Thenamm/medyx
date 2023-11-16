using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
////

namespace HTC.Business.Security
{
    [Serializable()]
    public class RoleUsers: BusinessListBase<RoleUsers, RoleUser>
    {
        #region Business Methods

        public RoleUser this[int roleId]
        {
            get
            {
                foreach (RoleUser obj in this)
                    if (obj.RoleId.Equals(roleId))
                        return obj;
                return null;
            }
        }

        public void AssignTo(int roleId)
        {
            if (!Contains(roleId))
            {
                RoleUser obj = RoleUser.NewRoleUser(roleId);
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public void Remove(int roleId)
        {
            foreach (RoleUser obj in this)
            {
                if (obj.RoleId.Equals(roleId))
                {
                    Remove(obj);
                    break;
                }
            }
        }

        public bool Contains(int roleId)
        {
            foreach (RoleUser obj in this)
                if (obj.RoleId == roleId)
                    return true;
            return false;
        }

        public bool ContainsDeleted(int roleId)
        {
            foreach (RoleUser obj in DeletedList)
                if (obj.RoleId == roleId)
                    return true;
            return false;
        }

        #endregion

        #region Factory Methods

        internal static RoleUsers NewRoleUsers()
        {
            return new RoleUsers();
        }

        internal static RoleUsers GetRoleUsers(SafeDataReader dr)
        {
            return new RoleUsers(dr);
        }

        private RoleUsers()
        {
            MarkAsChild();
        }

        private RoleUsers(SafeDataReader dr)
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
                this.Add(RoleUser.GetRoleUser(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(User user)
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (RoleUser item in DeletedList)
                item.DeleteSelf(user);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (RoleUser item in this)
            {
                if (item.IsNew)
                    item.Insert(user);
                else
                    item.Update(user);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
    }
}
