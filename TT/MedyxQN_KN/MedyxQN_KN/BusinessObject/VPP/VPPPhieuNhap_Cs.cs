using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
////
using HTC.Business;
using HTC.Business.CategoryList  ;

namespace HTC.Business.VPP
{
    [Serializable()]
    public class VPPPhieuNhap_Cs : BusinessListBase<VPPPhieuNhap_Cs, VPPPhieuNhap_C>
    {
         #region Business Methods
        public VPPPhieuNhap_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public VPPPhieuNhap_C this[string MaPN]
        {
            get
            {
                foreach (VPPPhieuNhap_C obj in this)
                    if (obj.MaPN.Equals(MaPN))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaPN)
        {
            if (!Contains(MaPN))
            {
                VPPPhieuNhap_C obj = VPPPhieuNhap_C.NewVPPPhieuNhap_C(MaPN);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VPPPhieuNhap_C NewTo()//ham khoi tao doi tuong Phieu nhap
        {

              VPPPhieuNhap_C obj = VPPPhieuNhap_C.NewVPPPhieuNhap_C();
              return obj;
               
        }
        public void NewTo(VPPPhieuNhap_C _VPPPhieuNhap_C) //moi sua
        {
            if (!Contains(_VPPPhieuNhap_C.MaPN))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    _VPPPhieuNhap_C.STT = ++_count;
                    this.Add(_VPPPhieuNhap_C);
                }
                else
                {
                    _VPPPhieuNhap_C.STT = 1;
                    this.Add(_VPPPhieuNhap_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VPPPhieuNhap_C AssignTo(DMVPP _DMVPP)
        {
            if (!Contains(_DMVPP.MaVT))
            {
                VPPPhieuNhap_C obj = VPPPhieuNhap_C.NewVPPPhieuNhap_C(_DMVPP.MaVT);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VPPPhieuNhap_C AssignTo(VPPPhieuNhap_C _VPPPhieuNhap_C)//add mot hang VPPPhieuNhap_C
        {
            if (!Containss(_VPPPhieuNhap_C.MaVT, _VPPPhieuNhap_C.Huy, _VPPPhieuNhap_C.SoLo, _VPPPhieuNhap_C.HanSD ))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                  
                    _VPPPhieuNhap_C.STT = ++_count;

                    this.Add(_VPPPhieuNhap_C);
                }
                else
                {
                    _VPPPhieuNhap_C.STT = 1;
                   
                    this.Add(_VPPPhieuNhap_C);
                }
            }
           
           return _VPPPhieuNhap_C;
        }
        protected override object AddNewCore()
        {
            VPPPhieuNhap_C item = VPPPhieuNhap_C.NewVPPPhieuNhap_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void  RemoveTo(decimal stt) //xoa 1 VPPPhieuNhap_C
        //{
           
        //    //foreach (VPPPhieuNhap_C obj in this)
        //    //{
        //    //    if (obj.STT == stt)
        //    //    {
        //    //        this.Items.RemoveAt(this.IndexOf(obj));
        //    //        break; 
                   
        //    //    }
        //    //}
        //    //VPPPhieuNhap_C obj;
        //    for(int i = 0;i < this.Items.Count ;i ++ )
        //    {
        //       // obj = this.Items[i];
        //        if (this.Items[i].STT == stt)
        //        {
        //            this.Items.RemoveAt(i);
        //            break;

        //        }
        //    }
        //}
        //public void RemoveTo(VPPPhieuNhap_C obj) //xoa 1 VPPPhieuNhap_C
        //{

        //    Remove(obj); 
                  
                   
        //}
        public void RemoveTo(VPPPhieuNhap_C obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public bool Contains(string MaPN)
        {
            foreach (VPPPhieuNhap_C obj in this)
                if ((obj.MaPN == MaPN) && (obj.Huy = false))
                    return true;
            return false;
        }
        //public bool Containss(string MaVT)
        //{
        //    foreach (VTPhieuNhap_C obj in this)
        //        if ((obj.MaVT == MaVT) && (obj.Huy = false))
        //            return true;
        //    return false;
        //}
        //public bool Containss(string MaVT)
        //{
        //    foreach (VTPhieuNhap_C obj in this)
        //        if (obj.MaVT == MaVT) 
        //            return true;
        //    return false;
        //}
        public bool Containss(string MaVT, Boolean Huy, string solo, string hansd)
        {
            foreach (VPPPhieuNhap_C obj in this)
                if ((obj.MaVT == MaVT) && (obj.Huy == Huy) && (obj.SoLo  == solo) && (obj.HanSD  == hansd))
                    return true;
            return false;
        }


        public bool ContainsDeleted(string MaPN)
        {
            foreach (VPPPhieuNhap_C obj in DeletedList)
                if (obj.MaPN == MaPN)
                    return true;
            return false;
        }
        public void UpdatedTo(VPPPhieuNhap_C _VPPPhieuNhap_C)
        {

            _VPPPhieuNhap_C.STT = this.Items[this.IndexOf(_VPPPhieuNhap_C)].STT;
            this.Items[this.IndexOf(_VPPPhieuNhap_C)] = _VPPPhieuNhap_C;
        }
        public VPPPhieuNhap_C GetTo(decimal STT) //
        {
            foreach (VPPPhieuNhap_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static VPPPhieuNhap_Cs NewVPPPhieuNhap_Cs()
        {
            return new VPPPhieuNhap_Cs();
        }

        internal static VPPPhieuNhap_Cs GetVPPPhieuNhap_Cs(SafeDataReader dr)
        {
            return new VPPPhieuNhap_Cs(dr);
        }

        private VPPPhieuNhap_Cs()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private VPPPhieuNhap_Cs(SafeDataReader dr)
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
                
                this.Add(VPPPhieuNhap_C.GetVPPPhieuNhap_C(dr));/////////
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(VPPPhieuNhap packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (VPPPhieuNhap_C item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (VPPPhieuNhap_C item in this)
            {
                if ((item.IsNew) )   //MaPN ==""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
   
    }
}
