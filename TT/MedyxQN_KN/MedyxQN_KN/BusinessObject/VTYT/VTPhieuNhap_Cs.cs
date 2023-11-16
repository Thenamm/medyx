using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
////
using HTC.Business;
using HTC.Business.CategoryList  ;

namespace HTC.Business.VTYT
{
    [Serializable()]
    public class VTPhieuNhap_Cs : BusinessListBase<VTPhieuNhap_Cs, VTPhieuNhap_C>
    {
         #region Business Methods
        public VTPhieuNhap_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public VTPhieuNhap_C this[string MaPN]
        {
            get
            {
                foreach (VTPhieuNhap_C obj in this)
                    if (obj.MaPN.Equals(MaPN))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaPN)
        {
            if (!Contains(MaPN))
            {
                VTPhieuNhap_C obj = VTPhieuNhap_C.NewVTPhieuNhap_C(MaPN);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VTPhieuNhap_C NewTo()//ham khoi tao doi tuong Phieu nhap
        {

              VTPhieuNhap_C obj = VTPhieuNhap_C.NewVTPhieuNhap_C();
              return obj;
               
        }
        public void NewTo(VTPhieuNhap_C _VTPhieuNhap_C) //moi sua
        {
            if (!Contains(_VTPhieuNhap_C.MaPN))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    _VTPhieuNhap_C.STT = ++_count;
                    this.Add(_VTPhieuNhap_C);
                }
                else
                {
                    _VTPhieuNhap_C.STT = 1;
                    this.Add(_VTPhieuNhap_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VTPhieuNhap_C AssignTo(DMVTYT _DMVTYT)
        {
            if (!Contains(_DMVTYT.MaVT))
            {
                VTPhieuNhap_C obj = VTPhieuNhap_C.NewVTPhieuNhap_C(_DMVTYT.MaVT);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VTPhieuNhap_C AssignTo(VTPhieuNhap_C _VTPhieuNhap_C)//add mot hang VTPhieuNhap_C
        {
            if (!Containss(_VTPhieuNhap_C.MaVT, _VTPhieuNhap_C.Huy, _VTPhieuNhap_C.SoLo, _VTPhieuNhap_C.HanSD ))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                  
                    _VTPhieuNhap_C.STT = ++_count;

                    this.Add(_VTPhieuNhap_C);
                }
                else
                {
                    _VTPhieuNhap_C.STT = 1;
                   
                    this.Add(_VTPhieuNhap_C);
                }
            }
           
           return _VTPhieuNhap_C;
        }
        protected override object AddNewCore()
        {
            VTPhieuNhap_C item = VTPhieuNhap_C.NewVTPhieuNhap_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void  RemoveTo(decimal stt) //xoa 1 VTPhieuNhap_C
        //{
           
        //    //foreach (VTPhieuNhap_C obj in this)
        //    //{
        //    //    if (obj.STT == stt)
        //    //    {
        //    //        this.Items.RemoveAt(this.IndexOf(obj));
        //    //        break; 
                   
        //    //    }
        //    //}
        //    //VTPhieuNhap_C obj;
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
        //public void RemoveTo(VTPhieuNhap_C obj) //xoa 1 VTPhieuNhap_C
        //{

        //    Remove(obj); 
                  
                   
        //}
        public void RemoveTo(VTPhieuNhap_C obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public bool Contains(string MaPN)
        {
            foreach (VTPhieuNhap_C obj in this)
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
            //foreach (VTPhieuNhap_C obj in this)
            //    if ((obj.MaVT == MaVT) && (obj.Huy == Huy) && (obj.SoLo  == solo) && (obj.HanSD  == hansd))
            //        return true;
            return false;
        }


        public bool ContainsDeleted(string MaPN)
        {
            foreach (VTPhieuNhap_C obj in DeletedList)
                if (obj.MaPN == MaPN)
                    return true;
            return false;
        }
        public void UpdatedTo(VTPhieuNhap_C _VTPhieuNhap_C)
        {

            _VTPhieuNhap_C.STT = this.Items[this.IndexOf(_VTPhieuNhap_C)].STT;
            this.Items[this.IndexOf(_VTPhieuNhap_C)] = _VTPhieuNhap_C;
        }
        public VTPhieuNhap_C GetTo(decimal STT) //
        {
            foreach (VTPhieuNhap_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static VTPhieuNhap_Cs NewVTPhieuNhap_Cs()
        {
            return new VTPhieuNhap_Cs();
        }

        internal static VTPhieuNhap_Cs GetVTPhieuNhap_Cs(SafeDataReader dr)
        {
            return new VTPhieuNhap_Cs(dr);
        }

        private VTPhieuNhap_Cs()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private VTPhieuNhap_Cs(SafeDataReader dr)
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
                
                this.Add(VTPhieuNhap_C.GetVTPhieuNhap_C(dr));/////////
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(VTPhieuNhap packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (VTPhieuNhap_C item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (VTPhieuNhap_C item in this)
            {
                if ((item.IsNew))// && item.MaPN == "")   //MaPN ==""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
   
    }
}
