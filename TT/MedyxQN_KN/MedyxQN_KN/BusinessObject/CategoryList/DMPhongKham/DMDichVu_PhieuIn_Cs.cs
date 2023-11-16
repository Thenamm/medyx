using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
//

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMDichVu_PhieuIn_Cs : BusinessListBase<DMDichVu_PhieuIn_Cs, DMDichVu_PhieuIn_C>
    {
        #region Business Methods

        public DMDichVu_PhieuIn_C this[string MaDV]
        {
            get
            {
                foreach (DMDichVu_PhieuIn_C obj in this)
                    if (obj.MaDV.Equals(MaDV))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaDV)
        {
            if (!Contains(MaDV))
            {
                DMDichVu_PhieuIn_C obj = DMDichVu_PhieuIn_C.NewDMDichVu_PhieuIn_C(MaDV);
                byte _count = 0;
                _count = (byte)this.Items.Count;
                obj.OrderNumber = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public DMDichVu_PhieuIn_C NewTo()
        {
           
              DMDichVu_PhieuIn_C obj = DMDichVu_PhieuIn_C.NewDMDichVu_PhieuIn_C();
              return obj;
               
        }
        public void NewTo(DMDichVu_PhieuIn_C _DMDichVu_PhieuIn_C)
        {
            if (!Contains(_DMDichVu_PhieuIn_C.MaDV))
            {
                if (this.Items.Count > 0)
                {
                    byte _count=0;
                    _count = (byte)this.Items.Count;
                    _DMDichVu_PhieuIn_C.OrderNumber = ++_count;
                    this.Add(_DMDichVu_PhieuIn_C);
                }
                else
                {
                    _DMDichVu_PhieuIn_C.OrderNumber = 1;
                    this.Add(_DMDichVu_PhieuIn_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public DMDichVu_PhieuIn_C AssignTo(DMDichVu _DMDichVu)
        {
            if (!Contains(_DMDichVu.MaDV))
            {
                DMDichVu_PhieuIn_C obj = DMDichVu_PhieuIn_C.NewDMDichVu_PhieuIn_C(_DMDichVu.MaDV);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        protected override object AddNewCore()
        {
            DMDichVu_PhieuIn_C item = DMDichVu_PhieuIn_C.NewDMDichVu_PhieuIn_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(string MaDV)
        {
            foreach (DMDichVu_PhieuIn_C obj in this)
            {
                if (obj.MaDV.Equals(MaDV))
                {
                    Remove(obj);
                    break;
                }
            }
        }

        public bool Contains(string MaDV)
        {
            foreach (DMDichVu_PhieuIn_C obj in this)
                if ((obj.MaDV == MaDV) && (obj.Huy == false))
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaDV)
        {
            foreach (DMDichVu_PhieuIn_C obj in DeletedList)
                if (obj.MaDV == MaDV)
                    return true;
            return false;
        }
        public void UpdatedTo(DMDichVu_PhieuIn_C _DMDichVu_PhieuIn_C)
        {

            _DMDichVu_PhieuIn_C.OrderNumber = this.Items[this.IndexOf(_DMDichVu_PhieuIn_C)].OrderNumber;
            this.Items[this.IndexOf(_DMDichVu_PhieuIn_C)] = _DMDichVu_PhieuIn_C;
        }
        public DMDichVu_PhieuIn_C GetTo(Byte STT)
        {
            foreach (DMDichVu_PhieuIn_C obj in this)
                if (obj.OrderNumber == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static DMDichVu_PhieuIn_Cs NewDMDichVu_PhieuIn_Cs()
        {
            return new DMDichVu_PhieuIn_Cs();
        }

        internal static DMDichVu_PhieuIn_Cs GetDMDichVu_PhieuIn_Cs(SafeDataReader dr)
        {
            return new DMDichVu_PhieuIn_Cs(dr);
        }

        private DMDichVu_PhieuIn_Cs()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private DMDichVu_PhieuIn_Cs(SafeDataReader dr)
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
                this.Add(DMDichVu_PhieuIn_C.GetDMDichVu_PhieuIn_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(DMDichVu_PhieuIn packet)
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (DMDichVu_PhieuIn_C item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (DMDichVu_PhieuIn_C item in this)
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