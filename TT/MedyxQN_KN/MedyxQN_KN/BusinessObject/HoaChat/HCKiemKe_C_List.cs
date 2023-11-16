using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;
//
using HTC.Business.CategoryList;

namespace HTC.Business.HoaChat
{
    [Serializable()]
    public class HCKiemKe_C_List : BusinessListBase<HCKiemKe_C_List, HCKiemKe_C>
    {
        #region Business Methods
        public HCKiemKe_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public HCKiemKe_C this[decimal stt]
        {
            get
            {
                foreach (HCKiemKe_C obj in this)
                    if (obj.OrderNumber == stt)
                        return obj;

                return null;
            }
        }

        public void NewTo(string MaKK)
        {
            if (!Contains(MaKK))
            {
                HCKiemKe_C obj = HCKiemKe_C.NewHCKiemKe_C(MaKK);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public HCKiemKe_C NewTo()
        {
           
              HCKiemKe_C obj = HCKiemKe_C.NewHCKiemKe_C();
              return obj;
               
        }
        public void NewTo(HCKiemKe_C _HCKiemKe_C)
        {
            if (!Contains(_HCKiemKe_C.MaHC))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _HCKiemKe_C.STT = ++_count;
                    this.Add(_HCKiemKe_C);
                }
                else
                {
                    _HCKiemKe_C.STT = 1;
                    this.Add(_HCKiemKe_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public HCKiemKe_C AssignTo(DMHoaChat _DMHoaChat)
        {
            if (!Contains(_DMHoaChat.MaHC))
            {
                HCKiemKe_C obj = HCKiemKe_C.NewHCKiemKe_C(_DMHoaChat.MaHC);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public HCKiemKe_C AssignTo(HCKiemKe_C _HCKiemKe_C)//add mot hang PhieuNhap_C
        {
            if (!Containss(_HCKiemKe_C.MaHC, _HCKiemKe_C.Huy))
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
                    _HCKiemKe_C.OrderNumber = ++_count;
                    _HCKiemKe_C.STT = ++_count1;
                    this.Add(_HCKiemKe_C);
                }
                else
                {
                    _HCKiemKe_C.OrderNumber = 1;
                    _HCKiemKe_C.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_HCKiemKe_C);
                }
            }

            return _HCKiemKe_C;
        }

        protected override object AddNewCore()
        {
            HCKiemKe_C item = HCKiemKe_C.NewHCKiemKe_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void RemoveTo(string MaKK)
        //{
        //    foreach (HCKiemKe_C obj in this)
        //    {
        //        if (obj.MaKK.Equals(MaKK))
        //        {
        //            Remove(obj);
        //            break;
        //        }
        //    }
        //}
        //public void RemoveTo(HCKiemKe_C obj)
        //{
        //    this.Items.Remove(obj);

        //}
       
        public void RemoveTo(HCKiemKe_C obj) //xoa 1 PhieuNhap_C
        {
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);
            //this.Items.Remove(obj);
        }

        public bool Contains(string MaKK)
        {
            foreach (HCKiemKe_C obj in this)
                if ((obj.MaKK == MaKK) && (obj.Huy = false))
                    return true;
            return false;
        }
        public bool Containss(string MaHC, Boolean Huy)
        {
            foreach (HCKiemKe_C obj in this)
                if ((obj.MaHC == MaHC) && (obj.Huy == Huy))
                    return true;
            return false;
        }
        public HCKiemKe_C ContainsMa(string MaHC, Boolean Huy)
        {
            foreach (HCKiemKe_C obj in this)
                if ((obj.MaHC == MaHC) && (obj.Huy == Huy))
                    return obj;
            return null;
        }


        public bool ContainsDeleted(string MaKK)
        {
            foreach (HCKiemKe_C obj in DeletedList)
                if (obj.MaKK == MaKK)
                    return true;
            return false;
        }

        public void UpdatedTo(HCKiemKe_C _HCKiemKe_C)
        {

            _HCKiemKe_C.STT = this.Items[this.IndexOf(_HCKiemKe_C)].STT;
           this.Items[this.IndexOf(_HCKiemKe_C)] = _HCKiemKe_C;
        }
        public HCKiemKe_C GetTo(decimal STT)
        {
            foreach (HCKiemKe_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static HCKiemKe_C_List NewHCKiemKe_C_List()
        {
            return new HCKiemKe_C_List();
        }

        internal static HCKiemKe_C_List GetHCKiemKe_C_List(SafeDataReader dr)
        {
            return new HCKiemKe_C_List(dr);
        }

        private HCKiemKe_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private HCKiemKe_C_List(SafeDataReader dr)
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
                this.Add(HCKiemKe_C.GetHCKiemKe_C(dr, i));
                i++;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(HCKiemKe packet)
        {
            RaiseListChangedEvents = false;
            foreach (HCKiemKe_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (HCKiemKe_C item in this)
            {
                if ((item.IsNew)) // && item.MaKK == "")   //MaKK ==""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        

       

        #endregion
    }
}