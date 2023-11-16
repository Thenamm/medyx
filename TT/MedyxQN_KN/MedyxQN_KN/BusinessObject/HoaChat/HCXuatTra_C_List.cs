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
    public class HCXuatTra_C_List : BusinessListBase<HCXuatTra_C_List, HCXuatTra_C>
    {
        #region Business Methods
        public HCXuatTra_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public HCXuatTra_C this[string MaPXT]
        {
            get
            {
                foreach (HCXuatTra_C obj in this)
                    if (obj.MaPXT.Equals(MaPXT))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaPXT)
        {
            if (!Contains(MaPXT))
            {
                HCXuatTra_C obj = HCXuatTra_C.NewHCXuatTra_C(MaPXT);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public HCXuatTra_C NewTo()
        {
           
              HCXuatTra_C obj = HCXuatTra_C.NewHCXuatTra_C();
              return obj;
               
        }
        public void NewTo(HCXuatTra_C _HCXuatTra_C)
        {
            if (!Contains(_HCXuatTra_C.maHC))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _HCXuatTra_C.STT = ++_count;
                    this.Add(_HCXuatTra_C);
                }
                else
                {
                    _HCXuatTra_C.STT = 1;
                    this.Add(_HCXuatTra_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public HCXuatTra_C AssignTo(DMHoaChat _DMHoaChat)
        {
            if (!Contains(_DMHoaChat.MaHC))
            {
                HCXuatTra_C obj = HCXuatTra_C.NewHCXuatTra_C(_DMHoaChat.MaHC);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public bool Containss(string maHC, Boolean Huy)
        {
            foreach (HCXuatTra_C obj in this)
                if ((obj.maHC  == maHC) && (obj.Huy == Huy))
                    return true;
            return false;
        }
        public bool Containss(string maHC, Boolean Huy, string solo, string  HanSD)
        {
            //foreach (HCXuatTra_C obj in this)
            //    if (solo !=""&& HanSD !="")
            //    if ((obj.maHC == maHC) && (obj.Huy == Huy) && (obj.SoLo == solo )&& (obj.HanSD == HanSD  ))
            //        return true;
            //    else if (solo == "" && HanSD == "")
            //        if ((obj.maHC == maHC) && (obj.Huy == Huy))
            //            return true;
            return false;
        }
        public HCXuatTra_C AssignTo(HCXuatTra_C _HCXuatTra_C)//add mot hang HCXuatTra_C
        {
            if (!Containss(_HCXuatTra_C.maHC, _HCXuatTra_C.Huy, _HCXuatTra_C.SoLo ,_HCXuatTra_C.HanSD  ))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    _HCXuatTra_C.STT = ++_count;
                    this.Add(_HCXuatTra_C);
                }
                else
                {
                    _HCXuatTra_C.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_HCXuatTra_C);
                }
            }
            return _HCXuatTra_C;
        }
        protected override object AddNewCore()
        {
            HCXuatTra_C item = HCXuatTra_C.NewHCXuatTra_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(int _STT)
        {
            foreach (HCXuatTra_C obj in this)
            {
                if (obj.STT.Equals(_STT))
                {
                    Remove(obj);
                    break;
                }
            }
        }

        public bool Contains(string MaPXT)
        {
            foreach (HCXuatTra_C obj in this)
                if ((obj.MaPXT == MaPXT) && (obj.Huy = false))
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaPXT)
        {
            foreach (HCXuatTra_C obj in DeletedList)
                if (obj.MaPXT == MaPXT)
                    return true;
            return false;
        }

        public void UpdatedTo(HCXuatTra_C _HCXuatTra_C)
        {

            _HCXuatTra_C.STT = this.Items[this.IndexOf(_HCXuatTra_C)].STT;
           this.Items[this.IndexOf(_HCXuatTra_C)] = _HCXuatTra_C;
        }
        public HCXuatTra_C GetTo(decimal STT)
        {
            foreach (HCXuatTra_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static HCXuatTra_C_List NewHCXuatTra_C_List()
        {
            return new HCXuatTra_C_List();
        }

        internal static HCXuatTra_C_List GetHCXuatTra_C_List(SafeDataReader dr)
        {
            return new HCXuatTra_C_List(dr);
        }

        private HCXuatTra_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private HCXuatTra_C_List(SafeDataReader dr)
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
                this.Add(HCXuatTra_C.GetHCXuatTra_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(HCXuatTra packet)
        {
            RaiseListChangedEvents = false;
            foreach (HCXuatTra_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (HCXuatTra_C item in this)
            {
                if ((item.IsNew))// && item.MaPXT == "")   //MaPXT ==""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        

      

        #endregion
    }
}