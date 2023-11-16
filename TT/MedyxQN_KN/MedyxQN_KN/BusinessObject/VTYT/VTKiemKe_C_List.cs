using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;
////
using HTC.Business.CategoryList;

namespace HTC.Business.VTYT
{
    [Serializable()]
    public class VTKiemKe_C_List : BusinessListBase<VTKiemKe_C_List, VTKiemKe_C>
    {
        #region Business Methods

        public VTKiemKe_C this[decimal stt]
        {
            get
            {
                foreach (VTKiemKe_C obj in this)
                    if (obj.OrderNumber == stt)
                        return obj;

                return null;
            }
        }

        public void NewTo(string MaKK)
        {
            if (!Contains(MaKK))
            {
                VTKiemKe_C obj = VTKiemKe_C.NewVTKiemKe_C(MaKK);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VTKiemKe_C NewTo()
        {

            VTKiemKe_C obj = VTKiemKe_C.NewVTKiemKe_C();
            return obj;

        }
        public void NewTo(VTKiemKe_C _VTKiemKe_C)
        {
            if (!Contains(_VTKiemKe_C.MaVT))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    _VTKiemKe_C.STT = ++_count;
                    this.Add(_VTKiemKe_C);
                }
                else
                {
                    _VTKiemKe_C.STT = 1;
                    this.Add(_VTKiemKe_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VTKiemKe_C AssignTo(DMVTYT _DMVTYT)
        {
            if (!Contains(_DMVTYT.MaVT))
            {
                VTKiemKe_C obj = VTKiemKe_C.NewVTKiemKe_C(_DMVTYT.MaVT);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VTKiemKe_C AssignTo(VTKiemKe_C _VTKiemKe_C)//add mot hang PhieuNhap_C
        {
            if (!Containss(_VTKiemKe_C.MaVT, _VTKiemKe_C.Huy))
            {
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    decimal _count1 = 0;

                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    if ((decimal)this.Items.Count > 0)
                    {
                        _count1 = this[(decimal)this.Items.Count].STT;
                        _count = this[(decimal)this.Items.Count].OrderNumber;
                    }
                    _VTKiemKe_C.OrderNumber = ++_count;
                    _VTKiemKe_C.STT = ++_count1;
                    this.Add(_VTKiemKe_C);
                }
                else
                {
                    _VTKiemKe_C.OrderNumber = 1;
                    _VTKiemKe_C.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_VTKiemKe_C);
                }
            }

            return _VTKiemKe_C;
        }

        protected override object AddNewCore()
        {
            VTKiemKe_C item = VTKiemKe_C.NewVTKiemKe_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void RemoveTo(string MaKK)
        //{
        //    foreach (VTKiemKe_C obj in this)
        //    {
        //        if (obj.MaKK.Equals(MaKK))
        //        {
        //            Remove(obj);
        //            break;
        //        }
        //    }
        //}
        //public void RemoveTo(VTKiemKe_C obj)
        //{
        //    this.Items.Remove(obj);

        //}

        public void RemoveTo(VTKiemKe_C obj) //xoa 1 PhieuNhap_C
        {
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);
            //this.Items.Remove(obj);
        }

        public bool Contains(string MaKK)
        {
            foreach (VTKiemKe_C obj in this)
                if ((obj.MaKK == MaKK) && (obj.Huy = false))
                    return true;
            return false;
        }
        public bool Containss(string MaVT, Boolean Huy)
        {
            foreach (VTKiemKe_C obj in this)
                if ((obj.MaVT == MaVT) && (obj.Huy == Huy))
                    return true;
            return false;
        }
        public VTKiemKe_C ContainsMa(string MaVT, Boolean Huy)
        {
            foreach (VTKiemKe_C obj in this)
                if ((obj.MaVT == MaVT) && (obj.Huy == Huy))
                    return obj;
            return null;
        }


        public bool ContainsDeleted(string MaKK)
        {
            foreach (VTKiemKe_C obj in DeletedList)
                if (obj.MaKK == MaKK)
                    return true;
            return false;
        }

        public void UpdatedTo(VTKiemKe_C _VTKiemKe_C)
        {

            _VTKiemKe_C.STT = this.Items[this.IndexOf(_VTKiemKe_C)].STT;
            this.Items[this.IndexOf(_VTKiemKe_C)] = _VTKiemKe_C;
        }
        public VTKiemKe_C GetTo(decimal STT)
        {
            foreach (VTKiemKe_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        #endregion

        #region Factory Methods

        internal static VTKiemKe_C_List NewVTKiemKe_C_List()
        {
            return new VTKiemKe_C_List();
        }

        internal static VTKiemKe_C_List GetVTKiemKe_C_List(SafeDataReader dr)
        {
            return new VTKiemKe_C_List(dr);
        }

        private VTKiemKe_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private VTKiemKe_C_List(SafeDataReader dr)
        {
            this.AllowNew = true;
            MarkAsChild();
            Fetch(dr);
        }

        #endregion

        #region Data Access

        private void Fetch(SafeDataReader dr)
        {
            int i = 1;
            RaiseListChangedEvents = false;
            while (dr.Read())
            {
                this.Add(VTKiemKe_C.GetVTKiemKe_C(dr, i));
                i++;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(VTKiemKe packet)
        {
            RaiseListChangedEvents = false;
            foreach (VTKiemKe_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (VTKiemKe_C item in this)
            {
                if (item.IsNew == true )//&& item.MaKK == "")
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }




        #endregion
    }
}