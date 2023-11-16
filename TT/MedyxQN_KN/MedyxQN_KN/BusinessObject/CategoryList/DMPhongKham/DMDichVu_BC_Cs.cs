using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
//

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMDichVu_BC_Cs : BusinessListBase<DMDichVu_BC_Cs, DMDichVu_BC_C>
    {
        #region Business Methods

        public DMDichVu_BC_C this[string MaDV]
        {
            get
            {
                foreach (DMDichVu_BC_C obj in this)
                    if (obj.MaDV.Equals(MaDV))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaDV)
        {
            if (!Contains(MaDV))
            {
                DMDichVu_BC_C obj = DMDichVu_BC_C.NewDMDichVu_BC_C(MaDV);
                byte _count = 0;
                _count = (byte)this.Items.Count;
                obj.OrderNumber = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public DMDichVu_BC_C NewTo()
        {

            DMDichVu_BC_C obj = DMDichVu_BC_C.NewDMDichVu_BC_C();
            return obj;

        }
        public void NewTo(DMDichVu_BC_C DMDichVu_BC_C)
        {
            if (!Contains(DMDichVu_BC_C.MaDV))
            {
                if (this.Items.Count > 0)
                {
                    byte _count = 0;
                    _count = (byte)this.Items.Count;
                    DMDichVu_BC_C.OrderNumber = ++_count;
                    this.Add(DMDichVu_BC_C);
                }
                else
                {
                    DMDichVu_BC_C.OrderNumber = 1;
                    this.Add(DMDichVu_BC_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        //public void AssignTo(string idMaterial)
        //{
        //    if (!Contains(idMaterial))
        //    {
        //        DMDichVu_BC_C obj = DMDichVu_BC_C.NewDMDichVu_BC_C(idMaterial);
        //        this.Add(obj);
        //    }
        //    else
        //        throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        //}

        //public void AssignTo(DMDichVu_BC_C _Material)
        //{
        //    if (!Contains(_Material.MaDV ))
        //    {
        //        this.Add(_Material);
        //    }
        //    else
        //        throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        //}
        public DMDichVu_BC_C AssignTo(DMDichVu _DMDichVu)
        {
            if (!Contains(_DMDichVu.MaDV))
            {
                DMDichVu_BC_C obj = DMDichVu_BC_C.NewDMDichVu_BC_C(_DMDichVu.MaDV);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        protected override object AddNewCore()
        {
            DMDichVu_BC_C item = DMDichVu_BC_C.NewDMDichVu_BC_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void Remove(string maDV)
        {
            foreach (DMDichVu_BC_C obj in this)
            {
                if (obj.MaDV.Equals(maDV))
                {
                    Remove(obj);
                    break;
                }
            }
        }

        public bool Contains(string maDV)
        {
            foreach (DMDichVu_BC_C obj in this)
                if ((obj.MaDV == maDV) && (obj.Huy == false) )
                    return true;
            return false;
        }

        public bool ContainsDeleted(string maDV)
        {
            foreach (DMDichVu_BC_C obj in DeletedList)
                if (obj.MaDV == maDV)
                    return true;
            return false;
        }
        public void UpdatedTo(DMDichVu_BC_C _DMDichVu_BC_C)
        {

            _DMDichVu_BC_C.OrderNumber = this.Items[this.IndexOf(_DMDichVu_BC_C)].OrderNumber;
            this.Items[this.IndexOf(_DMDichVu_BC_C)] = _DMDichVu_BC_C;
        }
        public DMDichVu_BC_C GetTo(Byte STT)
        {
            foreach (DMDichVu_BC_C obj in this)
                if (obj.OrderNumber == STT)
                    return obj;
            return null;

        }
        #endregion

        #region Factory Methods

        internal static DMDichVu_BC_Cs NewDMDichVu_BC_Cs()
        {
            return new DMDichVu_BC_Cs();
        }

        internal static DMDichVu_BC_Cs GetDMDichVu_BC_Cs(SafeDataReader dr)
        {
            return new DMDichVu_BC_Cs(dr);
        }

        private DMDichVu_BC_Cs()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private DMDichVu_BC_Cs(SafeDataReader dr)
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
                this.Add(DMDichVu_BC_C.GetDMDichVu_BC_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(DMDichVu_BC packet)
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (DMDichVu_BC_C item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (DMDichVu_BC_C item in this)
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