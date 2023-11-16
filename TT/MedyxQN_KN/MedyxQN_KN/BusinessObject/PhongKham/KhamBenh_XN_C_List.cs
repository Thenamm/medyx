using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
////
using HTC.Business.CategoryList;


namespace HTC.Business.PhongKham
{
    [Serializable()]
    public class KhamBenh_XN_C_List : BusinessListBase<KhamBenh_XN_C_List, KhamBenh_XN_C>
    {
        #region Business Methods

        public KhamBenh_XN_C this[string MaDV]
        {
            get
            {
                foreach (KhamBenh_XN_C obj in this)
                    if (obj.MaDV.Equals(MaDV))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaDV)
        {
            if (!Contains(MaDV))
            {
                KhamBenh_XN_C obj = KhamBenh_XN_C.NewKhamBenh_XN_C(MaDV);
                byte _count = 0;
                _count = (byte)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public KhamBenh_XN_C NewTo()
        {
           
              KhamBenh_XN_C obj = KhamBenh_XN_C.NewKhamBenh_XN_C();
              return obj;
               
        }
        public void NewTo(KhamBenh_XN_C _KhamBenh_XN_C)
        {
            if (!Contains(_KhamBenh_XN_C.MaDV))
            {
                if (this.Items.Count > 0)
                {
                    byte _count=0;
                    _count = (byte)this.Items.Count;
                    _KhamBenh_XN_C.STT = ++_count;
                    this.Add(_KhamBenh_XN_C);
                }
                else
                {
                    _KhamBenh_XN_C.STT = 1;
                    this.Add(_KhamBenh_XN_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public KhamBenh_XN_C AssignTo(DMDichVu _DMDichVu)
        {
            if (!Contains(_DMDichVu.MaDV))
            {
                KhamBenh_XN_C obj = KhamBenh_XN_C.NewKhamBenh_XN_C(_DMDichVu.MaDV);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        protected override object AddNewCore()
        {
            KhamBenh_XN_C item = KhamBenh_XN_C.NewKhamBenh_XN_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }
        public KhamBenh_XN_C Contains(int stt)
        {
            foreach (KhamBenh_XN_C obj in this)
                if (obj.STTCS  == stt)
                    return obj;
            return null;

        }
        public void RemoveTo(string MaDV)
        {
            foreach (KhamBenh_XN_C obj in this)
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
            foreach (KhamBenh_XN_C obj in this)
                if (obj.MaDV == MaDV )
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaDV)
        {
            foreach (KhamBenh_XN_C obj in DeletedList)
                if (obj.MaDV == MaDV)
                    return true;
            return false;
        }
        public void UpdatedTo(KhamBenh_XN_C _KhamBenh_XN_C)
        {

            _KhamBenh_XN_C.STT = this.Items[this.IndexOf(_KhamBenh_XN_C)].STT;
            this.Items[this.IndexOf(_KhamBenh_XN_C)] = _KhamBenh_XN_C;
        }
        public KhamBenh_XN_C GetTo(Byte STT)
        {
            foreach (KhamBenh_XN_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static KhamBenh_XN_C_List NewKhamBenh_XN_C_List()
        {
            return new KhamBenh_XN_C_List();
        }

        internal static KhamBenh_XN_C_List GetKhamBenh_XN_C_List(SafeDataReader dr)
        {
            return new KhamBenh_XN_C_List(dr);
        }

        private KhamBenh_XN_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private KhamBenh_XN_C_List(SafeDataReader dr)
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
                this.Add(KhamBenh_XN_C.GetKhamBenh_XN_C(dr));
            RaiseListChangedEvents = true; 
        }

        internal void Update(KhamBenh_XN packet)
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (KhamBenh_XN_C item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (KhamBenh_XN_C item in this)
            {
                if (item.IsNew)
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; 
        }

        #endregion
    }
}