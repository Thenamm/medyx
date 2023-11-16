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
    public class VTPhieuDTNhap_C_List : BusinessListBase<VTPhieuDTNhap_C_List, VTPhieuDTNhap_C>
    {
         #region Business Methods
        public VTPhieuDTNhap_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public VTPhieuDTNhap_C this[string MaDuTru]
        {
            get
            {
                foreach (VTPhieuDTNhap_C obj in this)
                    if (obj.MaDuTru.Equals(MaDuTru))
                        return obj;
                return null;
            }
        }
        public VTPhieuDTNhap_C this[decimal STT]
        {
            get
            {
                foreach (VTPhieuDTNhap_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public void NewTo(string MaDuTru)
        {
            if (!Contains(MaDuTru))
            {
                VTPhieuDTNhap_C obj = VTPhieuDTNhap_C.NewVTPhieuDTNhap_C(MaDuTru);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VTPhieuDTNhap_C NewTo()//ham khoi tao doi tuong Phieu nhap
        {

              VTPhieuDTNhap_C obj = VTPhieuDTNhap_C.NewVTPhieuDTNhap_C();
              return obj;
               
        }
        public void NewTo(VTPhieuDTNhap_C _VTPhieuDTNhap_C) //moi sua
        {
            if (!Contains(_VTPhieuDTNhap_C.MaDuTru))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    _VTPhieuDTNhap_C.STT = ++_count;
                    this.Add(_VTPhieuDTNhap_C);
                }
                else
                {
                    _VTPhieuDTNhap_C.STT = 1;
                    this.Add(_VTPhieuDTNhap_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VTPhieuDTNhap_C AssignTo(DMVTYT _DMVTYT)
        {
            if (!Contains(_DMVTYT.MaVT))
            {
                VTPhieuDTNhap_C obj = VTPhieuDTNhap_C.NewVTPhieuDTNhap_C(_DMVTYT.MaVT);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VTPhieuDTNhap_C AssignTo(VTPhieuDTNhap_C _VTPhieuDTNhap_C)//add mot hang VTPhieuDTNhap_C
        {
            if (!Containss(_VTPhieuDTNhap_C.MaVT, _VTPhieuDTNhap_C.Huy, _VTPhieuDTNhap_C.Handung ))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    
                    _VTPhieuDTNhap_C.STT = ++_count;

                    this.Add(_VTPhieuDTNhap_C);
                }
                else
                {
                    _VTPhieuDTNhap_C.STT = 1;
                   
                    this.Add(_VTPhieuDTNhap_C);
                }
            }
           
           return _VTPhieuDTNhap_C;
        }
        protected override object AddNewCore()
        {
            VTPhieuDTNhap_C item = VTPhieuDTNhap_C.NewVTPhieuDTNhap_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void  RemoveTo(decimal stt) //xoa 1 VTPhieuDTNhap_C
        //{
           
        //    //foreach (VTPhieuDTNhap_C obj in this)
        //    //{
        //    //    if (obj.STT == stt)
        //    //    {
        //    //        this.Items.RemoveAt(this.IndexOf(obj));
        //    //        break; 
                   
        //    //    }
        //    //}
        //    //VTPhieuDTNhap_C obj;
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
        public void RemoveTo(VTPhieuDTNhap_C obj) //xoa 1 VTPhieuDTNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);
                   
        }
        public bool Contains(string MaDuTru)
        {
            foreach (VTPhieuDTNhap_C obj in this)
                if ((obj.MaDuTru == MaDuTru) && (obj.Huy = false))
                    return true;
            return false;
        }
        //public bool Containss(string MaVT)
        //{
        //    foreach (VTPhieuDTNhap_C obj in this)
        //        if ((obj.MaVT == MaVT) && (obj.Huy = false))
        //            return true;
        //    return false;
        //}
        //public bool Containss(string MaVT)
        //{
        //    foreach (VTPhieuDTNhap_C obj in this)
        //        if (obj.MaVT == MaVT) 
        //            return true;
        //    return false;
        //}
        public bool Containss(string MaVT, Boolean Huy,bool hansd)
        {
            foreach (VTPhieuDTNhap_C obj in this)
                if ((obj.MaVT == MaVT) && (obj.Huy == Huy) && (obj.Handung  == hansd))
                    return true;
            return false;
        }


        public bool ContainsDeleted(string MaDuTru)
        {
            foreach (VTPhieuDTNhap_C obj in DeletedList)
                if (obj.MaDuTru == MaDuTru)
                    return true;
            return false;
        }
        public void UpdatedTo(VTPhieuDTNhap_C _VTPhieuDTNhap_C)
        {

            _VTPhieuDTNhap_C.STT = this.Items[this.IndexOf(_VTPhieuDTNhap_C)].STT;
            this.Items[this.IndexOf(_VTPhieuDTNhap_C)] = _VTPhieuDTNhap_C;
        }
        public VTPhieuDTNhap_C GetTo(decimal STT) //
        {
            foreach (VTPhieuDTNhap_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static VTPhieuDTNhap_C_List NewVTPhieuDTNhap_C_List()
        {
            return new VTPhieuDTNhap_C_List();
        }

        internal static VTPhieuDTNhap_C_List GetVTPhieuDTNhap_C_List(SafeDataReader dr)
        {
            return new VTPhieuDTNhap_C_List(dr);
        }

        private VTPhieuDTNhap_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private VTPhieuDTNhap_C_List(SafeDataReader dr)
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
                
                this.Add(VTPhieuDTNhap_C.GetVTPhieuDTNhap_C(dr));/////////
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(VTPhieuDTNhap packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (VTPhieuDTNhap_C item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (VTPhieuDTNhap_C item in this)
            {
                if ((item.IsNew))// && item.MaDuTru == "")   //MaDuTru ==""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
   
    }
}
