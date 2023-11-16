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
    public class HCPhieuNhap_Cs : BusinessListBase<HCPhieuNhap_Cs, HCPhieuNhap_C>
    {
         #region Business Methods
        public HCPhieuNhap_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public HCPhieuNhap_C this[string MaPN]
        {
            get
            {
                foreach (HCPhieuNhap_C obj in this)
                    if (obj.MaPN.Equals(MaPN))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaPN)
        {
            if (!Contains(MaPN))
            {
                HCPhieuNhap_C obj = HCPhieuNhap_C.NewHCPhieuNhap_C(MaPN);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public HCPhieuNhap_C NewTo()//ham khoi tao doi tuong Phieu nhap
        {

              HCPhieuNhap_C obj = HCPhieuNhap_C.NewHCPhieuNhap_C();
              return obj;
               
        }
        public void NewTo(HCPhieuNhap_C _HCPhieuNhap_C) //moi sua
        {
            if (!Contains(_HCPhieuNhap_C.MaPN))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    _HCPhieuNhap_C.STT = ++_count;
                    this.Add(_HCPhieuNhap_C);
                }
                else
                {
                    _HCPhieuNhap_C.STT = 1;
                    this.Add(_HCPhieuNhap_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public HCPhieuNhap_C AssignTo(DMHoaChat _DMHoaChat)
        {
            if (!Contains(_DMHoaChat.MaHC))
            {
                HCPhieuNhap_C obj = HCPhieuNhap_C.NewHCPhieuNhap_C(_DMHoaChat.MaHC);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public HCPhieuNhap_C AssignTo(HCPhieuNhap_C _HCPhieuNhap_C)//add mot hang HCPhieuNhap_C
        {
            if (!Containss(_HCPhieuNhap_C.MaHC, _HCPhieuNhap_C.Huy, _HCPhieuNhap_C.SoLo, _HCPhieuNhap_C.HanSD))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                  
                    _HCPhieuNhap_C.STT = ++_count;

                    this.Add(_HCPhieuNhap_C);
                }
                else
                {
                    _HCPhieuNhap_C.STT = 1;
                 
                    this.Add(_HCPhieuNhap_C);
                }
            }
           
           return _HCPhieuNhap_C;
        }
        protected override object AddNewCore()
        {
            HCPhieuNhap_C item = HCPhieuNhap_C.NewHCPhieuNhap_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void  RemoveTo(decimal stt) //xoa 1 HCPhieuNhap_C
        //{
           
        //    //foreach (HCPhieuNhap_C obj in this)
        //    //{
        //    //    if (obj.STT == stt)
        //    //    {
        //    //        this.Items.RemoveAt(this.IndexOf(obj));
        //    //        break; 
                   
        //    //    }
        //    //}
        //    //HCPhieuNhap_C obj;
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
        //public void RemoveTo(HCPhieuNhap_C obj) //xoa 1 HCPhieuNhap_C
        //{

        //    Remove(obj); 
                  
                   
        //}
        public void RemoveTo(HCPhieuNhap_C obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public bool Contains(string MaPN)
        {
            foreach (HCPhieuNhap_C obj in this)
                if ((obj.MaPN == MaPN) && (obj.Huy = false))
                    return true;
            return false;
        }
        //public bool Containss(string MaHC)
        //{
        //    foreach (HCPhieuNhap_C obj in this)
        //        if ((obj.MaHC == MaHC) && (obj.Huy = false))
        //            return true;
        //    return false;
        //}
        //public bool Containss(string MaHC)
        //{
        //    foreach (HCPhieuNhap_C obj in this)
        //        if (obj.MaHC == MaHC) 
        //            return true;
        //    return false;
        //}
        public bool Containss(string MaHC, Boolean Huy,string solo, string hansd)
        {
            //foreach (HCPhieuNhap_C obj in this)
            //    if ((obj.MaHC == MaHC) && (obj.Huy == Huy) && (obj.SoLo  == solo) && (obj.HanSD   == hansd))
            //        return true;
            return false;
        }


        public bool ContainsDeleted(string MaPN)
        {
            foreach (HCPhieuNhap_C obj in DeletedList)
                if (obj.MaPN == MaPN)
                    return true;
            return false;
        }
        public void UpdatedTo(HCPhieuNhap_C _HCPhieuNhap_C)
        {

            _HCPhieuNhap_C.STT = this.Items[this.IndexOf(_HCPhieuNhap_C)].STT;
            this.Items[this.IndexOf(_HCPhieuNhap_C)] = _HCPhieuNhap_C;
        }
        public HCPhieuNhap_C GetTo(decimal STT) //
        {
            foreach (HCPhieuNhap_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static HCPhieuNhap_Cs NewHCPhieuNhap_Cs()
        {
            return new HCPhieuNhap_Cs();
        }

        internal static HCPhieuNhap_Cs GetHCPhieuNhap_Cs(SafeDataReader dr)
        {
            return new HCPhieuNhap_Cs(dr);
        }

        private HCPhieuNhap_Cs()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private HCPhieuNhap_Cs(SafeDataReader dr)
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
                
                this.Add(HCPhieuNhap_C.GetHCPhieuNhap_C(dr));/////////
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(HCPhieuNhap packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (HCPhieuNhap_C item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (HCPhieuNhap_C item in this)
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
