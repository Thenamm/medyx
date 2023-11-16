using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;
////
using HTC.Business.CategoryList;

namespace HTC.Business.TBYT
{
    [Serializable()]
    public class LKPhieuXuat_Cs : BusinessListBase<LKPhieuXuat_Cs, LKPhieuXuat_C>
    {
        #region Business Methods
        public LKPhieuXuat_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public LKPhieuXuat_C this[Decimal STT]
        {
            get
            {
                foreach (LKPhieuXuat_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public void NewTo(string MaPX)
        {
            if (!Contains(MaPX))
            {
                LKPhieuXuat_C obj = LKPhieuXuat_C.NewLKPhieuXuat_C(MaPX);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public LKPhieuXuat_C NewTo()//ham khoi tao doi tuong Phieu nhap
        {

            LKPhieuXuat_C obj = LKPhieuXuat_C.NewLKPhieuXuat_C();
            return obj;

        }

        public void NewTo(LKPhieuXuat_C _LKPhieuXuat_C)
        {
            if (!Contains(_LKPhieuXuat_C.MaPX))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _LKPhieuXuat_C.STT = ++_count;
                    this.Add(_LKPhieuXuat_C);
                }
                else
                {
                    _LKPhieuXuat_C.STT = 1;
                    this.Add(_LKPhieuXuat_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public LKPhieuXuat_C AssignTo(DMVTYT _DMVTYT)
        {
            if (!Contains(_DMVTYT.MaVT))
            {
                LKPhieuXuat_C obj = LKPhieuXuat_C.NewLKPhieuXuat_C(_DMVTYT.MaVT);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public LKPhieuXuat_C AssignTo(LKPhieuXuat_C _LKPhieuXuat_C)//add mot hang PhieuNhap_C
        {
            if (!Containss(_LKPhieuXuat_C.MaLK, _LKPhieuXuat_C.Huy, _LKPhieuXuat_C.SoLo, _LKPhieuXuat_C.HanSD ))
            {  
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    _LKPhieuXuat_C.HanSD = _LKPhieuXuat_C.HanSD;
                    _LKPhieuXuat_C.STT = ++_count;
                    this.Add(_LKPhieuXuat_C);
                }
                else
                {
                    _LKPhieuXuat_C.STT = 1;
                    _LKPhieuXuat_C.HanSD = _LKPhieuXuat_C.HanSD;
                    this.Add(_LKPhieuXuat_C);
                }
                //Add(_PhieuNhap_C);
               
             }
             return _LKPhieuXuat_C;
        }

        protected override object AddNewCore()
        {
            LKPhieuXuat_C item = LKPhieuXuat_C.NewLKPhieuXuat_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(LKPhieuXuat_C obj)
        {
            //foreach (LKPhieuXuat_C obj in this)
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
            foreach (LKPhieuXuat_C obj in this)
                if (obj.STT.Equals(STT))
                {
                    this.Items.Remove(obj);
                    break;
                }
        }
        public bool Contains(string MaPX)
        {
            foreach (LKPhieuXuat_C obj in this)
                if ((obj.MaPX == MaPX) && (obj.Huy = false))
                    return true;
            return false;
        }
        public bool Containss(string MaVT, Boolean Huy, string solo, string hansd)
        {
            //foreach (LKPhieuXuat_C obj in this)
            //    if (hansd != "" || obj.HanSD != "")
            //    {
            //        if ((obj.MaVT == MaVT) && (obj.SoLo == solo) && (Microsoft.VisualBasic.DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Day, DateTime.Parse(hansd), DateTime.Parse(obj.HanSD), Microsoft.VisualBasic.FirstDayOfWeek.System, Microsoft.VisualBasic.FirstWeekOfYear.System) == 0))
            //            return true;
            //    }
            //    else
            //    {
            //        if ((obj.MaVT == MaVT) && (obj.SoLo == solo) && (Microsoft.VisualBasic.DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Day, DateTime.Parse(hansd), DateTime.Parse(obj.HanSD), Microsoft.VisualBasic.FirstDayOfWeek.System, Microsoft.VisualBasic.FirstWeekOfYear.System) == 0))
            //            return true;
            //    }

            return false;
           
        }
        //public bool Containss(string MaVT, Boolean Huy, string solo, string hansd)
        //{
        //    foreach (LKPhieuXuat_C  obj in this)
        //        if ((obj.MaVT == MaVT) && (obj.Huy == Huy) && (obj.SoLo == solo) && (obj.HanSD == hansd))
        //            return true;
        //    return false;
        //}

        public bool ContainsDeleted(string MaPX)
        {
            foreach (LKPhieuXuat_C obj in DeletedList)
                if (obj.MaPX == MaPX)
                    return true;
            return false;
        }

        public void UpdatedTo(LKPhieuXuat_C _LKPhieuXuat_C)
        {

            _LKPhieuXuat_C.STT = this.Items[this.IndexOf(_LKPhieuXuat_C)].STT;
           this.Items[this.IndexOf(_LKPhieuXuat_C)] = _LKPhieuXuat_C;
        }

        public LKPhieuXuat_C GetTo(decimal STT)
        {
            foreach (LKPhieuXuat_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }

        #endregion

        #region Factory Methods

        internal static LKPhieuXuat_Cs NewLKPhieuXuat_Cs()
        {
            return new LKPhieuXuat_Cs();
        }

        internal static LKPhieuXuat_Cs GetLKPhieuXuat_Cs(SafeDataReader dr)
        {
            return new LKPhieuXuat_Cs(dr);
        }

        private LKPhieuXuat_Cs()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private LKPhieuXuat_Cs(SafeDataReader dr)
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
                this.Add(LKPhieuXuat_C.GetLKPhieuXuat_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(LKPhieuXuat packet)
        {
            RaiseListChangedEvents = false;
            foreach (LKPhieuXuat_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (LKPhieuXuat_C item in this)
            {
                if ((item.IsNew))// && item.MaPX == "")   //MaPX ==""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(LKPhieuXuatDT packet)
        {
            RaiseListChangedEvents = false;
            foreach (LKPhieuXuat_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (LKPhieuXuat_C item in this)
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