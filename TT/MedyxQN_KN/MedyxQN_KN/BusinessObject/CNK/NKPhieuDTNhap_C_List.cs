using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

using HTC.Business;
using HTC.Business.CategoryList  ;

namespace HTC.Business.CNK
{
    [Serializable()]
    public class NKPhieuDTNhap_C_List : BusinessListBase<NKPhieuDTNhap_C_List, NKPhieuDTNhap_C>
    {
         #region Business Methods

        public NKPhieuDTNhap_C this[string MaDuTru]
        {
            get
            {
                foreach (NKPhieuDTNhap_C obj in this)
                    if (obj.MaDuTru.Equals(MaDuTru))
                        return obj;
                return null;
            }
        }
        public NKPhieuDTNhap_C this[decimal STT]
        {
            get
            {
                foreach (NKPhieuDTNhap_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public void NewTo(string MaDuTru)
        {
            if (!Contains(MaDuTru))
            {
                NKPhieuDTNhap_C obj = NKPhieuDTNhap_C.NewNKPhieuDTNhap_C(MaDuTru);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public NKPhieuDTNhap_C NewTo()//ham khoi tao doi tuong Phieu nhap
        {

              NKPhieuDTNhap_C obj = NKPhieuDTNhap_C.NewNKPhieuDTNhap_C();
              return obj;
               
        }
        public void NewTo(NKPhieuDTNhap_C _NKPhieuDTNhap_C) //moi sua
        {
            if (!Contains(_NKPhieuDTNhap_C.MaDuTru))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    _NKPhieuDTNhap_C.STT = ++_count;
                    this.Add(_NKPhieuDTNhap_C);
                }
                else
                {
                    _NKPhieuDTNhap_C.STT = 1;
                    this.Add(_NKPhieuDTNhap_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public NKPhieuDTNhap_C AssignTo(DMCNK _DMCNK)
        {
            if (!Contains(_DMCNK.MaVT))
            {
                NKPhieuDTNhap_C obj = NKPhieuDTNhap_C.NewNKPhieuDTNhap_C(_DMCNK.MaVT);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public NKPhieuDTNhap_C AssignTo(NKPhieuDTNhap_C _NKPhieuDTNhap_C)//add mot hang NKPhieuDTNhap_C
        {
            if (!Containss(_NKPhieuDTNhap_C.MaVT, _NKPhieuDTNhap_C.Huy, _NKPhieuDTNhap_C.Handung ))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    
                    _NKPhieuDTNhap_C.STT = ++_count;

                    this.Add(_NKPhieuDTNhap_C);
                }
                else
                {
                    _NKPhieuDTNhap_C.STT = 1;
                   
                    this.Add(_NKPhieuDTNhap_C);
                }
            }
           
           return _NKPhieuDTNhap_C;
        }
        protected override object AddNewCore()
        {
            NKPhieuDTNhap_C item = NKPhieuDTNhap_C.NewNKPhieuDTNhap_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void  RemoveTo(decimal stt) //xoa 1 NKPhieuDTNhap_C
        //{
           
        //    //foreach (NKPhieuDTNhap_C obj in this)
        //    //{
        //    //    if (obj.STT == stt)
        //    //    {
        //    //        this.Items.RemoveAt(this.IndexOf(obj));
        //    //        break; 
                   
        //    //    }
        //    //}
        //    //NKPhieuDTNhap_C obj;
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
        public void RemoveTo(NKPhieuDTNhap_C obj) //xoa 1 NKPhieuDTNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);
                   
        }
        public bool Contains(string MaDuTru)
        {
            foreach (NKPhieuDTNhap_C obj in this)
                if ((obj.MaDuTru == MaDuTru) && (obj.Huy = false))
                    return true;
            return false;
        }
        //public bool Containss(string MaVT)
        //{
        //    foreach (NKPhieuDTNhap_C obj in this)
        //        if ((obj.MaVT == MaVT) && (obj.Huy = false))
        //            return true;
        //    return false;
        //}
        //public bool Containss(string MaVT)
        //{
        //    foreach (NKPhieuDTNhap_C obj in this)
        //        if (obj.MaVT == MaVT) 
        //            return true;
        //    return false;
        //}
        public bool Containss(string MaVT, Boolean Huy,bool hansd)
        {
            foreach (NKPhieuDTNhap_C obj in this)
                if ((obj.MaVT == MaVT) && (obj.Huy == Huy) && (obj.Handung  == hansd))
                    return true;
            return false;
        }


        public bool ContainsDeleted(string MaDuTru)
        {
            foreach (NKPhieuDTNhap_C obj in DeletedList)
                if (obj.MaDuTru == MaDuTru)
                    return true;
            return false;
        }
        public void UpdatedTo(NKPhieuDTNhap_C _NKPhieuDTNhap_C)
        {

            _NKPhieuDTNhap_C.STT = this.Items[this.IndexOf(_NKPhieuDTNhap_C)].STT;
            this.Items[this.IndexOf(_NKPhieuDTNhap_C)] = _NKPhieuDTNhap_C;
        }
        public NKPhieuDTNhap_C GetTo(decimal STT) //
        {
            foreach (NKPhieuDTNhap_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static NKPhieuDTNhap_C_List NewNKPhieuDTNhap_C_List()
        {
            return new NKPhieuDTNhap_C_List();
        }

        internal static NKPhieuDTNhap_C_List GetNKPhieuDTNhap_C_List(SafeDataReader dr)
        {
            return new NKPhieuDTNhap_C_List(dr);
        }

        private NKPhieuDTNhap_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private NKPhieuDTNhap_C_List(SafeDataReader dr)
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
                
                this.Add(NKPhieuDTNhap_C.GetNKPhieuDTNhap_C(dr));/////////
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(NKPhieuDTNhap packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (NKPhieuDTNhap_C item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (NKPhieuDTNhap_C item in this)
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
