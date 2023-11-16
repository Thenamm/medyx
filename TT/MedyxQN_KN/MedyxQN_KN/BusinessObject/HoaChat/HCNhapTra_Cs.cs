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
    public class HCNhapTra_Cs : BusinessListBase<HCNhapTra_Cs, HCNhapTra_C>
    {
        #region Business Methods
        public HCNhapTra_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public HCNhapTra_C this[Decimal STT]
        {
            get
            {
                foreach (HCNhapTra_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public HCNhapTra_C this[string MaPNT]
        {
            get
            {
                foreach (HCNhapTra_C obj in this)
                    if (obj.MaPNT.Equals(MaPNT))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaPNT)
        {
            if (!Contains(MaPNT))
            {
                HCNhapTra_C obj = HCNhapTra_C.NewHCNhapTra_C(MaPNT);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public HCNhapTra_C NewTo()
        {
           
              HCNhapTra_C obj = HCNhapTra_C.NewHCNhapTra_C();
              return obj;
               
        }
        public void NewTo(HCNhapTra_C _HCNhapTra_C)
        {
            if (!Contains(_HCNhapTra_C.MaHC))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _HCNhapTra_C.STT = ++_count;
                    this.Add(_HCNhapTra_C);
                }
                else
                {
                    _HCNhapTra_C.STT = 1;
                    this.Add(_HCNhapTra_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public HCNhapTra_C AssignTo(DMHoaChat _DMHoaChat)
        {
            if (!Contains(_DMHoaChat.MaHC))
            {
                HCNhapTra_C obj = HCNhapTra_C.NewHCNhapTra_C(_DMHoaChat.MaHC);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public HCNhapTra_C AssignTo(HCNhapTra_C _HCNhapTra_C)//add mot hang PhieuNhap_C
        {
            if (_HCNhapTra_C.HanSD == "01/01/0001")
                _HCNhapTra_C.HanSD = "";
            if (!Containss(_HCNhapTra_C.MaHC, _HCNhapTra_C.Huy, _HCNhapTra_C.SoLo, _HCNhapTra_C.HanSD ))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    _HCNhapTra_C.STT = ++_count;
                    this.Add(_HCNhapTra_C);
                }
                else
                {
                    _HCNhapTra_C.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_HCNhapTra_C);
                }
            }

            return _HCNhapTra_C;
        }

        protected override object AddNewCore()
        {
            HCNhapTra_C item = HCNhapTra_C.NewHCNhapTra_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void RemoveTo(string MaPNT)
        //{
        //    foreach (HCNhapTra_C obj in this)
        //    {
        //        if (obj.MaPNT.Equals(MaPNT))
        //        {
        //            Remove(obj);
        //            break;
        //        }
        //    }
        //}
        //public void RemoveTo(HCNhapTra_C obj) //xoa 1 PhieuNhap_C
        //{

        //    Remove(obj);


        //}
        public void RemoveTo(HCNhapTra_C obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj);
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }

        public bool Contains(string MaPNT)
        {
            foreach (HCNhapTra_C obj in this)
                if ((obj.MaPNT == MaPNT) && (obj.Huy = false))
                    return true;
            return false;
        }
        public bool Containss(string MaHC, Boolean Huy, string solo, string hansd)
        {
            //foreach (HCNhapTra_C obj in this)
            //    if ((obj.MaHC == MaHC) && (obj.Huy == Huy) && (obj.SoLo  == solo) && (obj.HanSD  == hansd))
            //        return true;
            return false;
        }

        public bool ContainsDeleted(string MaPNT)
        {
            foreach (HCNhapTra_C obj in DeletedList)
                if (obj.MaPNT == MaPNT)
                    return true;
            return false;
        }

        public void UpdatedTo(HCNhapTra_C _HCNhapTra_C)
        {
            //if (!Containss(_HCNhapTra_C.MaHC, _HCNhapTra_C.Huy))
            //{
                _HCNhapTra_C.STT = this.Items[this.IndexOf(_HCNhapTra_C)].STT;
                this.Items[this.IndexOf(_HCNhapTra_C)] = _HCNhapTra_C;
            //}
          
        }
        public HCNhapTra_C GetTo(decimal STT)
        {
            foreach (HCNhapTra_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static HCNhapTra_Cs NewHCNhapTra_Cs()
        {
            return new HCNhapTra_Cs();
        }

        internal static HCNhapTra_Cs GetHCNhapTra_Cs(SafeDataReader dr)
        {
            return new HCNhapTra_Cs(dr);
        }

        private HCNhapTra_Cs()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private HCNhapTra_Cs(SafeDataReader dr)
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
                this.Add(HCNhapTra_C.GetHCNhapTra_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(HCNhapTra packet)
        {
            RaiseListChangedEvents = false;
            foreach (HCNhapTra_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (HCNhapTra_C item in this)
            {
                if (item.IsNew)// && item.MaPNT == "")
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        

       

        #endregion
    }
}