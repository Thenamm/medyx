using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.Officer
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable()]
    public class RoleForms:BusinessListBase<RoleForms, RoleForm>
    {
        #region Business Methods
        /// <summary>
        /// Xóa một item trong list.
        /// </summary>
        /// <param name="id"></param>
        public void Remove(int id)
        {
            foreach (RoleForm item in this)
            {
                if (item.IdForm == id)
                {
                    Remove(item);
                    break;
                }
            }
        }

        public RoleForm GetRoleFormById(int id)
        {
            foreach (RoleForm item in this)
                if (item.IdForm == id)
                    return item;
            return null;
        }

        protected override object AddNewCore()
        {
            RoleForm item = RoleForm.NewRoleForm();
            Add(item);
            return item;
        }

        #endregion

        #region Authorization Rules

        public static bool CanAddObject()
        {
            return true;
        }

        public static bool CanGetObject()
        {
            return true;
        }

        public static bool CanDeleteObject()
        {
            return true;
        }

        public static bool CanEditObject()
        {
            return true;
        }

        #endregion

        #region Factory Methods

        public static RoleForms GetRoleForms()
        {
            return DataPortal.Fetch<RoleForms>(new Criteria(0));
        }

        public static RoleForms GetRoleForms(int IdRole)
        {
            return DataPortal.Fetch<RoleForms>(new Criteria(IdRole));
        }

        private RoleForms()
        {
            this.AllowNew = true;
        }

        #endregion

        #region Data Access
        [Serializable()]
        private class Criteria
        { 
            private int _IdRole;
            public int IdRole
            {
                get
                {
                    return _IdRole;
                }
            }
            public Criteria(int _id)
            {
                _IdRole = _id;
            }
        }

        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetRoleForms(criteria.IdRole)))
            {
                while (dr.Read())
                {
                    this.Add(RoleForm.GetRoleForm(dr));
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (RoleForm item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (RoleForm item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override RoleForms Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save countries");

            RoleForms result;
            result = base.Save();
            return result;
        }

        #endregion
    }
}
