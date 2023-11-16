using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
//
using HTC.Business;
using HTC.Business.CategoryList  ;

namespace HTC.Business.HoaChat
{
    [Serializable()]
    public class HCPhieuDTNhap_C_List : BusinessListBase<HCPhieuDTNhap_C_List, HCPhieuDTNhap_C>
    {
         #region Business Methods
        public HCPhieuDTNhap_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public HCPhieuDTNhap_C this[string MaDuTru]
        {
            get
            {
                foreach (HCPhieuDTNhap_C obj in this)
                    if (obj.MaDuTru.Equals(MaDuTru))
                        return obj;
                return null;
            }
        }
        public HCPhieuDTNhap_C this[decimal STT]
        {
            get
            {
                foreach (HCPhieuDTNhap_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public void NewTo(string MaDuTru)
        {
            if (!Contains(MaDuTru))
            {
                HCPhieuDTNhap_C obj = HCPhieuDTNhap_C.NewHCPhieuDTNhap_C(MaDuTru);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public HCPhieuDTNhap_C NewTo()//ham khoi tao doi tuong Phieu nhap
        {

              HCPhieuDTNhap_C obj = HCPhieuDTNhap_C.NewHCPhieuDTNhap_C();
              return obj;
               
        }
        public void NewTo(HCPhieuDTNhap_C _HCPhieuDTNhap_C) //moi sua
        {
            if (!Contains(_HCPhieuDTNhap_C.MaDuTru))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    _HCPhieuDTNhap_C.STT = ++_count;
                    this.Add(_HCPhieuDTNhap_C);
                }
                else
                {
                    _HCPhieuDTNhap_C.STT = 1;
                    this.Add(_HCPhieuDTNhap_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public HCPhieuDTNhap_C AssignTo(DMHoaChat _DMHoaChat)
        {
            if (!Contains(_DMHoaChat.MaHC))
            {
                HCPhieuDTNhap_C obj = HCPhieuDTNhap_C.NewHCPhieuDTNhap_C(_DMHoaChat.MaHC);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public HCPhieuDTNhap_C AssignTo(HCPhieuDTNhap_C _HCPhieuDTNhap_C)//add mot hang HCPhieuDTNhap_C
        {
            if (!Containss(_HCPhieuDTNhap_C.MaHC, _HCPhieuDTNhap_C.Huy, _HCPhieuDTNhap_C.Handung ))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    
                    _HCPhieuDTNhap_C.STT = ++_count;

                    this.Add(_HCPhieuDTNhap_C);
                }
                else
                {
                    _HCPhieuDTNhap_C.STT = 1;
                   
                    this.Add(_HCPhieuDTNhap_C);
                }
            }
           
           return _HCPhieuDTNhap_C;
        }
        protected override object AddNewCore()
        {
            HCPhieuDTNhap_C item = HCPhieuDTNhap_C.NewHCPhieuDTNhap_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void  RemoveTo(decimal stt) //xoa 1 HCPhieuDTNhap_C
        //{
           
        //    //foreach (HCPhieuDTNhap_C obj in this)
        //    //{
        //    //    if (obj.STT == stt)
        //    //    {
        //    //        this.Items.RemoveAt(this.IndexOf(obj));
        //    //        break; 
                   
        //    //    }
        //    //}
        //    //HCPhieuDTNhap_C obj;
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
        public void RemoveTo(HCPhieuDTNhap_C obj) //xoa 1 HCPhieuDTNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);
                   
        }
        public bool Contains(string MaDuTru)
        {
            foreach (HCPhieuDTNhap_C obj in this)
                if ((obj.MaDuTru == MaDuTru) && (obj.Huy = false))
                    return true;
            return false;
        }
        //public bool Containss(string MaHC)
        //{
        //    foreach (HCPhieuDTNhap_C obj in this)
        //        if ((obj.MaHC == MaHC) && (obj.Huy = false))
        //            return true;
        //    return false;
        //}
        //public bool Containss(string MaHC)
        //{
        //    foreach (HCPhieuDTNhap_C obj in this)
        //        if (obj.MaHC == MaHC) 
        //            return true;
        //    return false;
        //}
        public bool Containss(string MaHC, Boolean Huy,bool hansd)
        {
            foreach (HCPhieuDTNhap_C obj in this)
                if ((obj.MaHC == MaHC) && (obj.Huy == Huy) && (obj.Handung  == hansd))
                    return true;
            return false;
        }


        public bool ContainsDeleted(string MaDuTru)
        {
            foreach (HCPhieuDTNhap_C obj in DeletedList)
                if (obj.MaDuTru == MaDuTru)
                    return true;
            return false;
        }
        public void UpdatedTo(HCPhieuDTNhap_C _HCPhieuDTNhap_C)
        {

            _HCPhieuDTNhap_C.STT = this.Items[this.IndexOf(_HCPhieuDTNhap_C)].STT;
            this.Items[this.IndexOf(_HCPhieuDTNhap_C)] = _HCPhieuDTNhap_C;
        }
        public HCPhieuDTNhap_C GetTo(decimal STT) //
        {
            foreach (HCPhieuDTNhap_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static HCPhieuDTNhap_C_List NewHCPhieuDTNhap_C_List()
        {
            return new HCPhieuDTNhap_C_List();
        }

        internal static HCPhieuDTNhap_C_List GetHCPhieuDTNhap_C_List(SafeDataReader dr)
        {
            return new HCPhieuDTNhap_C_List(dr);
        }

        private HCPhieuDTNhap_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private HCPhieuDTNhap_C_List(SafeDataReader dr)
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
                
                this.Add(HCPhieuDTNhap_C.GetHCPhieuDTNhap_C(dr));/////////
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(HCPhieuDTNhap packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (HCPhieuDTNhap_C item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (HCPhieuDTNhap_C item in this)
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
