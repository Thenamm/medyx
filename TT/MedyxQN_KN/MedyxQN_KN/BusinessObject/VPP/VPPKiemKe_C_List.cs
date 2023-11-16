using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;
////
using HTC.Business.CategoryList;

namespace HTC.Business.VPP
{
    [Serializable()]
    public class VPPKiemKe_C_List : BusinessListBase<VPPKiemKe_C_List, VPPKiemKe_C>
    {
        #region Business Methods
        public VPPKiemKe_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public VPPKiemKe_C this[decimal stt]
        {
            get
            {
                foreach (VPPKiemKe_C obj in this)
                    if (obj.OrderNumber == stt)
                        return obj;

                return null;
            }
        }

        public void NewTo(string MaKK)
        {
            if (!Contains(MaKK))
            {
                VPPKiemKe_C obj = VPPKiemKe_C.NewVPPKiemKe_C (MaKK);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VPPKiemKe_C NewTo()
        {
           
              VPPKiemKe_C obj = VPPKiemKe_C.NewVPPKiemKe_C();
              return obj;
               
        }
        public void NewTo(VPPKiemKe_C _VPPKiemKe_C)
        {
            if (!Contains(_VPPKiemKe_C.MaVT))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _VPPKiemKe_C.STT = ++_count;
                    this.Add(_VPPKiemKe_C);
                }
                else
                {
                    _VPPKiemKe_C.STT = 1;
                    this.Add(_VPPKiemKe_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VPPKiemKe_C AssignTo(DMVPP _DMVPP)
        {
            if (!Contains(_DMVPP.MaVT))
            {
                VPPKiemKe_C obj = VPPKiemKe_C.NewVPPKiemKe_C(_DMVPP.MaVT);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VPPKiemKe_C AssignTo(VPPKiemKe_C _VPPKiemKe_C)//add mot hang PhieuNhap_C
        {
            if (!Containss(_VPPKiemKe_C.MaVT, _VPPKiemKe_C.Huy))
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
                    _VPPKiemKe_C.OrderNumber = ++_count;
                    _VPPKiemKe_C.STT = ++_count1;
                    this.Add(_VPPKiemKe_C);
                }
                else
                {
                    _VPPKiemKe_C.OrderNumber = 1;
                    _VPPKiemKe_C.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_VPPKiemKe_C);
                }
            }

            return _VPPKiemKe_C;
        }

        protected override object AddNewCore()
        {
            VPPKiemKe_C item = VPPKiemKe_C.NewVPPKiemKe_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

       
        public void RemoveTo(VPPKiemKe_C obj) //xoa 1 PhieuNhap_C
        {
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);
            //this.Items.Remove(obj);
        }

        public bool Contains(string MaKK)
        {
            foreach (VPPKiemKe_C obj in this)
                if ((obj.MaKK == MaKK) && (obj.Huy = false))
                    return true;
            return false;
        }
        public bool Containss(string MaVT, Boolean Huy)
        {
            foreach (VPPKiemKe_C obj in this)
                if ((obj.MaVT == MaVT) && (obj.Huy == Huy))
                    return true;
            return false;
        }
        


        public bool ContainsDeleted(string MaKK)
        {
            foreach (VPPKiemKe_C obj in DeletedList)
                if (obj.MaKK == MaKK)
                    return true;
            return false;
        }

        public void UpdatedTo(VPPKiemKe_C _VPPKiemKe_C)
        {

            _VPPKiemKe_C.STT = this.Items[this.IndexOf(_VPPKiemKe_C)].STT;
           this.Items[this.IndexOf(_VPPKiemKe_C)] = _VPPKiemKe_C;
        }
        public VPPKiemKe_C GetTo(decimal STT)
        {
            foreach (VPPKiemKe_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static VPPKiemKe_C_List NewVPPKiemKe_C_List()
        {
            return new VPPKiemKe_C_List();
        }

        internal static VPPKiemKe_C_List GetVPPKiemKe_C_List(SafeDataReader dr)
        {
            return new VPPKiemKe_C_List(dr);
        }

        private VPPKiemKe_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private VPPKiemKe_C_List(SafeDataReader dr)
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
                this.Add(VPPKiemKe_C.GetVPPKiemKe_C(dr, i));
                i++;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(VPPKiemKe packet)
        {
            RaiseListChangedEvents = false;
            foreach (VPPKiemKe_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (VPPKiemKe_C item in this)
            {
                if ((item.IsNew) )   //MaKK ==""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        

       

        #endregion
    }
}