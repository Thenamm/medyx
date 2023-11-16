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
    public class HCPhieuXuat_Cs : BusinessListBase<HCPhieuXuat_Cs, HCPhieuXuat_C>
    {
        #region Business Methods
        public HCPhieuXuat_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public HCPhieuXuat_C this[Decimal STT]
        {
            get
            {
                foreach (HCPhieuXuat_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        
        public void NewTo(string MaPX)
        {
            if (!Contains(MaPX))
            {
                HCPhieuXuat_C obj = HCPhieuXuat_C.NewHCPhieuXuat_C(MaPX);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public HCPhieuXuat_C NewTo()//ham khoi tao doi tuong Phieu nhap
        {

            HCPhieuXuat_C obj = HCPhieuXuat_C.NewHCPhieuXuat_C();
            return obj;

        }

        public void NewTo(HCPhieuXuat_C _HCPhieuXuat_C)
        {
            if (!Contains(_HCPhieuXuat_C.MaPX))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _HCPhieuXuat_C.STT = ++_count;
                    this.Add(_HCPhieuXuat_C);
                }
                else
                {
                    _HCPhieuXuat_C.STT = 1;
                    this.Add(_HCPhieuXuat_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public HCPhieuXuat_C AssignTo(DMHoaChat _DMHoaChat)
        {
            if (!Contains(_DMHoaChat.MaHC))
            {
                HCPhieuXuat_C obj = HCPhieuXuat_C.NewHCPhieuXuat_C(_DMHoaChat.MaHC);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public HCPhieuXuat_C AssignTo(HCPhieuXuat_C _HCPhieuXuat_C)//add mot hang PhieuNhap_C
        {
            if (!Containss(_HCPhieuXuat_C.MaHC, _HCPhieuXuat_C.Huy, _HCPhieuXuat_C.SoLo, _HCPhieuXuat_C.HanSD ))
            {  
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    _HCPhieuXuat_C.HanSD = _HCPhieuXuat_C.HanSD;
                    _HCPhieuXuat_C.STT = ++_count;
                    this.Add(_HCPhieuXuat_C);
                }
                else
                {
                    _HCPhieuXuat_C.STT = 1;
                    _HCPhieuXuat_C.HanSD = _HCPhieuXuat_C.HanSD;
                    this.Add(_HCPhieuXuat_C);
                }
                //Add(_PhieuNhap_C);
               
             }
             return _HCPhieuXuat_C;
        }

        protected override object AddNewCore()
        {
            HCPhieuXuat_C item = HCPhieuXuat_C.NewHCPhieuXuat_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(HCPhieuXuat_C obj)
        {
            //foreach (HCPhieuXuat_C obj in this)
            //{
            //    if (obj.MaPX.Equals(MaPX))
            //    {
            //        Remove(obj);
            //        break;
            //    }
            //}
            if (obj.IsNew == true)
                this.Items.Remove(obj);
            else Remove(obj);
            
        }
        public void RemoveTo(decimal  STT)
        {
            foreach (HCPhieuXuat_C obj in this)
                if (obj.STT.Equals(STT))
                {
                    this.Items.Remove(obj);
                    break;
                }
        }
        public bool Contains(string MaPX)
        {
            foreach (HCPhieuXuat_C obj in this)
                if ((obj.MaPX == MaPX) && (obj.Huy = false))
                    return true;
            return false;
        }
        public bool Containss(string MaHC, Boolean Huy, string solo, string hansd)
        {
            //foreach (HCPhieuXuat_C obj in this)
            //    if (hansd != "" || obj.HanSD != "")
            //    {
            //        if ((obj.MaHC == MaHC) && (obj.SoLo == solo) && (Microsoft.VisualBasic.DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Day, DateTime.Parse(hansd), DateTime.Parse(obj.HanSD), Microsoft.VisualBasic.FirstDayOfWeek.System, Microsoft.VisualBasic.FirstWeekOfYear.System) == 0))
            //            return true;
            //    }
            //    else
            //    {
            //        if ((obj.MaHC == MaHC) && (obj.SoLo == solo) && (Microsoft.VisualBasic.DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Day, DateTime.Parse(hansd), DateTime.Parse(obj.HanSD), Microsoft.VisualBasic.FirstDayOfWeek.System, Microsoft.VisualBasic.FirstWeekOfYear.System) == 0))
            //            return true;
            //    }

            return false;
        }
        //public bool Containss(string MaHC, Boolean Huy, string solo, string hansd)
        //{
        //    foreach (HCPhieuXuat_C  obj in this)
        //        if (obj.MaHC == MaHC)
        //            return true;
        //    return false;
        //}

        public bool ContainsDeleted(string MaPX)
        {
            foreach (HCPhieuXuat_C obj in DeletedList)
                if (obj.MaPX == MaPX)
                    return true;
            return false;
        }

        public void UpdatedTo(HCPhieuXuat_C _HCPhieuXuat_C)
        {

            _HCPhieuXuat_C.STT = this.Items[this.IndexOf(_HCPhieuXuat_C)].STT;
           this.Items[this.IndexOf(_HCPhieuXuat_C)] = _HCPhieuXuat_C;
        }

        public HCPhieuXuat_C GetTo(decimal STT)
        {
            foreach (HCPhieuXuat_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }

        #endregion

        #region Factory Methods

        internal static HCPhieuXuat_Cs NewHCPhieuXuat_Cs()
        {
            return new HCPhieuXuat_Cs();
        }

        internal static HCPhieuXuat_Cs GetHCPhieuXuat_Cs(SafeDataReader dr)
        {
            return new HCPhieuXuat_Cs(dr);
        }

        private HCPhieuXuat_Cs()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private HCPhieuXuat_Cs(SafeDataReader dr)
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
                this.Add(HCPhieuXuat_C.GetHCPhieuXuat_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(HCPhieuXuat packet)
        {
            RaiseListChangedEvents = false;
            foreach (HCPhieuXuat_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (HCPhieuXuat_C item in this)
            {
                if ((item.IsNew))// && item.MaPX == "")   //MaPX ==""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
    }
}