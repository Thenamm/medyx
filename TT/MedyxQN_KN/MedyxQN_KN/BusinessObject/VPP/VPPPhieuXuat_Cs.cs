using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;
////
using HTC.Business.CategoryList;

namespace HTC.Business.VPP
{
    [Serializable()]
    public class VPPPhieuXuat_Cs : BusinessListBase<VPPPhieuXuat_Cs, VPPPhieuXuat_C>
    {
        #region Business Methods
        public VPPPhieuXuat_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public VPPPhieuXuat_C this[Decimal STT]
        {
            get
            {
                foreach (VPPPhieuXuat_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public void NewTo(string MaPX)
        {
            if (!Contains(MaPX))
            {
                VPPPhieuXuat_C obj = VPPPhieuXuat_C.NewVPPPhieuXuat_C(MaPX);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public VPPPhieuXuat_C NewTo()//ham khoi tao doi tuong Phieu nhap
        {

            VPPPhieuXuat_C obj = VPPPhieuXuat_C.NewVPPPhieuXuat_C();
            return obj;

        }

        public void NewTo(VPPPhieuXuat_C _VPPPhieuXuat_C)
        {
            if (!Contains(_VPPPhieuXuat_C.MaPX))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _VPPPhieuXuat_C.STT = ++_count;
                    this.Add(_VPPPhieuXuat_C);
                }
                else
                {
                    _VPPPhieuXuat_C.STT = 1;
                    this.Add(_VPPPhieuXuat_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public VPPPhieuXuat_C AssignTo(DMVPP _DMVPP)
        {
            if (!Contains(_DMVPP.MaVT))
            {
                VPPPhieuXuat_C obj = VPPPhieuXuat_C.NewVPPPhieuXuat_C(_DMVPP.MaVT);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public VPPPhieuXuat_C AssignTo(VPPPhieuXuat_C _VPPPhieuXuat_C)//add mot hang PhieuNhap_C
        {
            if (!Containss(_VPPPhieuXuat_C.MaVT, _VPPPhieuXuat_C.Huy, _VPPPhieuXuat_C.SoLo, _VPPPhieuXuat_C.HanSD ))
            {  
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    _VPPPhieuXuat_C.HanSD = _VPPPhieuXuat_C.HanSD;
                    _VPPPhieuXuat_C.STT = ++_count;
                    this.Add(_VPPPhieuXuat_C);
                }
                else
                {
                    _VPPPhieuXuat_C.STT = 1;
                    _VPPPhieuXuat_C.HanSD = _VPPPhieuXuat_C.HanSD;
                    this.Add(_VPPPhieuXuat_C);
                }
                //Add(_PhieuNhap_C);
               
             }
             return _VPPPhieuXuat_C;
        }

        protected override object AddNewCore()
        {
            VPPPhieuXuat_C item = VPPPhieuXuat_C.NewVPPPhieuXuat_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(VPPPhieuXuat_C obj)
        {
            //foreach (VPPPhieuXuat_C obj in this)
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
            foreach (VPPPhieuXuat_C obj in this)
                if (obj.STT.Equals(STT))
                {
                    this.Items.Remove(obj);
                    break;
                }
        }
        public bool Contains(string MaPX)
        {
            foreach (VPPPhieuXuat_C obj in this)
                if ((obj.MaPX == MaPX) && (obj.Huy = false))
                    return true;
            return false;
        }
        public bool Containss(string MaVT, Boolean Huy, string solo, string hansd)
        {
            foreach (VPPPhieuXuat_C obj in this)
                if (hansd != "" || obj.HanSD != "")
                {
                    if ((obj.MaVT == MaVT) && (obj.SoLo == solo) && (Microsoft.VisualBasic.DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Day, DateTime.Parse(hansd), DateTime.Parse(obj.HanSD), Microsoft.VisualBasic.FirstDayOfWeek.System, Microsoft.VisualBasic.FirstWeekOfYear.System) == 0))
                        return true;
                }
                else
                {
                    if ((obj.MaVT == MaVT) && (obj.SoLo == solo) && (Microsoft.VisualBasic.DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Day, DateTime.Parse(hansd), DateTime.Parse(obj.HanSD), Microsoft.VisualBasic.FirstDayOfWeek.System, Microsoft.VisualBasic.FirstWeekOfYear.System) == 0))
                        return true;
                }

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
            foreach (VPPPhieuXuat_C obj in DeletedList)
                if (obj.MaPX == MaPX)
                    return true;
            return false;
        }

        public void UpdatedTo(VPPPhieuXuat_C _VPPPhieuXuat_C)
        {

            _VPPPhieuXuat_C.STT = this.Items[this.IndexOf(_VPPPhieuXuat_C)].STT;
           this.Items[this.IndexOf(_VPPPhieuXuat_C)] = _VPPPhieuXuat_C;
        }

        public VPPPhieuXuat_C GetTo(decimal STT)
        {
            foreach (VPPPhieuXuat_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }

        #endregion

        #region Factory Methods

        internal static VPPPhieuXuat_Cs NewVPPPhieuXuat_Cs()
        {
            return new VPPPhieuXuat_Cs();
        }

        internal static VPPPhieuXuat_Cs GetVPPPhieuXuat_Cs(SafeDataReader dr)
        {
            return new VPPPhieuXuat_Cs(dr);
        }

        private VPPPhieuXuat_Cs()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private VPPPhieuXuat_Cs(SafeDataReader dr)
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
                this.Add(VPPPhieuXuat_C.GetVPPPhieuXuat_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(VPPPhieuXuat packet)
        {
            RaiseListChangedEvents = false;
            foreach (VPPPhieuXuat_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (VPPPhieuXuat_C item in this)
            {
                if ((item.IsNew) )   //MaPX ==""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
    }
}