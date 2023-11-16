using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
////
using HTC.Business.CategoryList;


namespace HTC.Business.Officer
{
    [Serializable()]
    public class RolesList : BusinessListBase<RolesList, Roles>
    {
        #region Business Methods

        public Roles this[string MaRole]
        {
            get
            {
                foreach (Roles obj in this)
                    if (obj.MaRole.Equals(MaRole))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaRole)
        {
            if (!Contains(MaRole))
            {
                Roles obj = Roles.NewRoles(MaRole);
               
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public Roles NewTo()
        {
           
              Roles obj = Roles.NewRoles();
              return obj;
               
        }
        public void NewTo(Roles _Roles)
        {
            if (!Contains(_Roles.MaRole))
            {
                if (this.Items.Count > 0)
                {
                   
                    this.Add(_Roles);
                }
                else
                {
                    this.Add(_Roles);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public Roles AssignTo(DMRole _DMRole)
        {
            if (!Contains(_DMRole.MaRole))
            {
                Roles obj = Roles.NewRoles(_DMRole.MaRole);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public Roles AssignTo(Roles _Roles)
        {
            //if (!Contains(_Roles.MaRole))
            //{
                this.Add(_Roles);
            //}
            //else
            //    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
                return _Roles;
        }
       
        protected override object AddNewCore()
        {
            Roles item = Roles.NewRoles();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(string MaRole)
        {
            foreach (Roles obj in this)
            {
                if (obj.MaRole.Equals(MaRole))
                {
                    Remove(obj);
                    break;
                }
            }
        }

        public bool Contains(string MaRole)
        {
            foreach (Roles obj in this)
                if (obj.MaRole == MaRole )
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaRole)
        {
            foreach (Roles obj in DeletedList)
                if (obj.MaRole == MaRole)
                    return true;
            return false;
        }
        public void UpdatedTo(Roles _Roles)
        {

            this.Items[this.IndexOf(_Roles)] = _Roles;
        }
        //public Roles GetTo(Byte STT)
        //{
        //    foreach (Roles obj in this)
        //        if (obj.STT == STT)
        //            return obj;
        //    return null;
                
        //}
        #endregion

        #region Factory Methods

        internal static RolesList NewRolesList()
        {
            return new RolesList();
        }

        internal static RolesList GetRolesList(SafeDataReader dr)
        {
            return new RolesList(dr);
        }

        private RolesList()
        {
            this.AllowNew = true;
            MarkAsChild();

        }
        private RolesList(SafeDataReader dr)
        {
            this.AllowNew = true;
            MarkAsChild();
            Fetch(dr);
        }

        #endregion

        #region Data Access

        private void Fetch(SafeDataReader dr)
        {
            RaiseListChangedEvents = false;
            while (dr.Read())
                this.Add(Roles.GetRoles(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(Account packet)
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (Roles item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (Roles item in this)
            {
                if (item.IsNew)
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion

        }
    }
