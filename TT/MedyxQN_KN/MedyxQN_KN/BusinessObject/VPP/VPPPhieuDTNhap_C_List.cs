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
    public class VPPPhieuDTNhap_C_List : BusinessListBase<VPPPhieuDTNhap_C_List, VPPPhieuDTNhap_C>
    {
         #region Business Methods
        public VPPPhieuDTNhap_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public VPPPhieuDTNhap_C this[string MaDuTru]
        {
            get
            {
                foreach (VPPPhieuDTNhap_C obj in this)
                    if (obj.MaDuTru.Equals(MaDuTru))
                        return obj;
                return null;
            }
        }
        public VPPPhieuDTNhap_C this[decimal STT]
        {
            get
            {
                foreach (VPPPhieuDTNhap_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public void NewTo(string MaDuTru)
        {
            if (!Contains(MaDuTru))
            {
                VPPPhieuDTNhap_C obj = VPPPhieuDTNhap_C.NewVPPPhieuDTNhap_C(MaDuTru);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VPPPhieuDTNhap_C NewTo()//ham khoi tao doi tuong Phieu nhap
        {

              VPPPhieuDTNhap_C obj = VPPPhieuDTNhap_C.NewVPPPhieuDTNhap_C();
              return obj;
               
        }
        public void NewTo(VPPPhieuDTNhap_C _VPPPhieuDTNhap_C) //moi sua
        {
            if (!Contains(_VPPPhieuDTNhap_C.MaDuTru))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    _VPPPhieuDTNhap_C.STT = ++_count;
                    this.Add(_VPPPhieuDTNhap_C);
                }
                else
                {
                    _VPPPhieuDTNhap_C.STT = 1;
                    this.Add(_VPPPhieuDTNhap_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VPPPhieuDTNhap_C AssignTo(DMVPP _DMVPP)
        {
            if (!Contains(_DMVPP.MaVT))
            {
                VPPPhieuDTNhap_C obj = VPPPhieuDTNhap_C.NewVPPPhieuDTNhap_C(_DMVPP.MaVT);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VPPPhieuDTNhap_C AssignTo(VPPPhieuDTNhap_C _VPPPhieuDTNhap_C)//add mot hang VPPPhieuDTNhap_C
        {
            if (!Containss(_VPPPhieuDTNhap_C.MaVT, _VPPPhieuDTNhap_C.Huy, _VPPPhieuDTNhap_C.Handung ))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    
                    _VPPPhieuDTNhap_C.STT = ++_count;

                    this.Add(_VPPPhieuDTNhap_C);
                }
                else
                {
                    _VPPPhieuDTNhap_C.STT = 1;
                   
                    this.Add(_VPPPhieuDTNhap_C);
                }
            }
           
           return _VPPPhieuDTNhap_C;
        }
        protected override object AddNewCore()
        {
            VPPPhieuDTNhap_C item = VPPPhieuDTNhap_C.NewVPPPhieuDTNhap_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void  RemoveTo(decimal stt) //xoa 1 VPPPhieuDTNhap_C
        //{
           
        //    //foreach (VPPPhieuDTNhap_C obj in this)
        //    //{
        //    //    if (obj.STT == stt)
        //    //    {
        //    //        this.Items.RemoveAt(this.IndexOf(obj));
        //    //        break; 
                   
        //    //    }
        //    //}
        //    //VPPPhieuDTNhap_C obj;
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
        public void RemoveTo(VPPPhieuDTNhap_C obj) //xoa 1 VPPPhieuDTNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);
                   
        }
        public bool Contains(string MaDuTru)
        {
            foreach (VPPPhieuDTNhap_C obj in this)
                if ((obj.MaDuTru == MaDuTru) && (obj.Huy = false))
                    return true;
            return false;
        }
        //public bool Containss(string MaVPP)
        //{
        //    foreach (VPPPhieuDTNhap_C obj in this)
        //        if ((obj.MaVPP == MaVPP) && (obj.Huy = false))
        //            return true;
        //    return false;
        //}
        //public bool Containss(string MaVPP)
        //{
        //    foreach (VPPPhieuDTNhap_C obj in this)
        //        if (obj.MaVPP == MaVPP) 
        //            return true;
        //    return false;
        //}
        public bool Containss(string MaVPP, Boolean Huy,bool hansd)
        {
            foreach (VPPPhieuDTNhap_C obj in this)
                if ((obj.MaVT == MaVPP) && (obj.Huy == Huy) && (obj.Handung  == hansd))
                    return true;
            return false;
        }


        public bool ContainsDeleted(string MaDuTru)
        {
            foreach (VPPPhieuDTNhap_C obj in DeletedList)
                if (obj.MaDuTru == MaDuTru)
                    return true;
            return false;
        }
        public void UpdatedTo(VPPPhieuDTNhap_C _VPPPhieuDTNhap_C)
        {

            _VPPPhieuDTNhap_C.STT = this.Items[this.IndexOf(_VPPPhieuDTNhap_C)].STT;
            this.Items[this.IndexOf(_VPPPhieuDTNhap_C)] = _VPPPhieuDTNhap_C;
        }
        public VPPPhieuDTNhap_C GetTo(decimal STT) //
        {
            foreach (VPPPhieuDTNhap_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static VPPPhieuDTNhap_C_List NewVPPPhieuDTNhap_C_List()
        {
            return new VPPPhieuDTNhap_C_List();
        }

        internal static VPPPhieuDTNhap_C_List GetVPPPhieuDTNhap_C_List(SafeDataReader dr)
        {
            return new VPPPhieuDTNhap_C_List(dr);
        }

        private VPPPhieuDTNhap_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private VPPPhieuDTNhap_C_List(SafeDataReader dr)
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
                
                this.Add(VPPPhieuDTNhap_C.GetVPPPhieuDTNhap_C(dr));/////////
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(VPPPhieuDTNhap packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (VPPPhieuDTNhap_C item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (VPPPhieuDTNhap_C item in this)
            {
                if ((item.IsNew) )   //MaDuTru ==""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
   
    }
}
