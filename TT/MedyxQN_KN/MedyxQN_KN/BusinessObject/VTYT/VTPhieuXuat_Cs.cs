using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;
////
using HTC.Business.CategoryList;

namespace HTC.Business.VTYT
{
    [Serializable()]
    public class VTPhieuXuat_Cs : BusinessListBase<VTPhieuXuat_Cs, VTPhieuXuat_C>
    {
        #region Business Methods
        public VTPhieuXuat_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public VTPhieuXuat_C this[Decimal STT]
        {
            get
            {
                foreach (VTPhieuXuat_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public void NewTo(string MaPX)
        {
            if (!Contains(MaPX))
            {
                VTPhieuXuat_C obj = VTPhieuXuat_C.NewVTPhieuXuat_C(MaPX);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public VTPhieuXuat_C NewTo()//ham khoi tao doi tuong Phieu nhap
        {

            VTPhieuXuat_C obj = VTPhieuXuat_C.NewVTPhieuXuat_C();
            return obj;

        }

        public void NewTo(VTPhieuXuat_C _VTPhieuXuat_C)
        {
            if (!Contains(_VTPhieuXuat_C.MaPX))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _VTPhieuXuat_C.STT = ++_count;
                    this.Add(_VTPhieuXuat_C);
                }
                else
                {
                    _VTPhieuXuat_C.STT = 1;
                    this.Add(_VTPhieuXuat_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public VTPhieuXuat_C AssignTo(DMVTYT _DMVTYT)
        {
            if (!Contains(_DMVTYT.MaVT))
            {
                VTPhieuXuat_C obj = VTPhieuXuat_C.NewVTPhieuXuat_C(_DMVTYT.MaVT);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public VTPhieuXuat_C AssignTo(VTPhieuXuat_C _VTPhieuXuat_C)//add mot hang PhieuNhap_C
        {
            if (!Containss(_VTPhieuXuat_C.MaVT, _VTPhieuXuat_C.Huy, _VTPhieuXuat_C.SoLo, _VTPhieuXuat_C.HanSD ))
            {  
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    _VTPhieuXuat_C.HanSD = _VTPhieuXuat_C.HanSD;
                    _VTPhieuXuat_C.STT = ++_count;
                    this.Add(_VTPhieuXuat_C);
                }
                else
                {
                    _VTPhieuXuat_C.STT = 1;
                    _VTPhieuXuat_C.HanSD = _VTPhieuXuat_C.HanSD;
                    this.Add(_VTPhieuXuat_C);
                }
                //Add(_PhieuNhap_C);
               
             }
             return _VTPhieuXuat_C;
        }

        protected override object AddNewCore()
        {
            VTPhieuXuat_C item = VTPhieuXuat_C.NewVTPhieuXuat_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(VTPhieuXuat_C obj)
        {
            //foreach (VTPhieuXuat_C obj in this)
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
            foreach (VTPhieuXuat_C obj in this)
                if (obj.STT.Equals(STT))
                {
                    this.Items.Remove(obj);
                    break;
                }
        }
        public bool Contains(string MaPX)
        {
            foreach (VTPhieuXuat_C obj in this)
                if ((obj.MaPX == MaPX) && (obj.Huy = false))
                    return true;
            return false;
        }
        public bool Containss(string MaVT, Boolean Huy, string solo, string hansd)
        {
            //foreach (VTPhieuXuat_C obj in this)
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
        //    foreach (VTPhieuXuat_C  obj in this)
        //        if ((obj.MaVT == MaVT) && (obj.Huy == Huy) && (obj.SoLo == solo) && (obj.HanSD == hansd))
        //            return true;
        //    return false;
        //}

        public bool ContainsDeleted(string MaPX)
        {
            foreach (VTPhieuXuat_C obj in DeletedList)
                if (obj.MaPX == MaPX)
                    return true;
            return false;
        }

        public void UpdatedTo(VTPhieuXuat_C _VTPhieuXuat_C)
        {

            _VTPhieuXuat_C.STT = this.Items[this.IndexOf(_VTPhieuXuat_C)].STT;
           this.Items[this.IndexOf(_VTPhieuXuat_C)] = _VTPhieuXuat_C;
        }

        public VTPhieuXuat_C GetTo(decimal STT)
        {
            foreach (VTPhieuXuat_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }

        #endregion

        #region Factory Methods

        internal static VTPhieuXuat_Cs NewVTPhieuXuat_Cs()
        {
            return new VTPhieuXuat_Cs();
        }

        internal static VTPhieuXuat_Cs GetVTPhieuXuat_Cs(SafeDataReader dr)
        {
            return new VTPhieuXuat_Cs(dr);
        }

        private VTPhieuXuat_Cs()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private VTPhieuXuat_Cs(SafeDataReader dr)
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
                this.Add(VTPhieuXuat_C.GetVTPhieuXuat_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(VTPhieuXuat packet)
        {
            RaiseListChangedEvents = false;
            foreach (VTPhieuXuat_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (VTPhieuXuat_C item in this)
            {
                if ((item.IsNew))// && item.MaPX == "")   //MaPX ==""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(VTPhieuXuatDT packet)
        {
            RaiseListChangedEvents = false;
            foreach (VTPhieuXuat_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (VTPhieuXuat_C item in this)
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