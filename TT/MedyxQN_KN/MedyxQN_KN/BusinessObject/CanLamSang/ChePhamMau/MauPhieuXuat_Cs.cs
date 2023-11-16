using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;
//
using HTC.Business.CategoryList;

namespace HTC.Business.CanLamSang
{
    [Serializable()]
    public class MauPhieuXuat_Cs : BusinessListBase<MauPhieuXuat_Cs, MauPhieuXuat_C>
    {
        #region Business Methods

        public MauPhieuXuat_C this[Decimal STT]
        {
            get
            {
                foreach (MauPhieuXuat_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public MauPhieuXuat_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public void NewTo(string MaPX)
        {
            if (!Contains(MaPX))
            {
                MauPhieuXuat_C obj = MauPhieuXuat_C.NewMauPhieuXuat_C(MaPX);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public MauPhieuXuat_C NewTo()//ham khoi tao doi tuong Phieu nhap
        {

            MauPhieuXuat_C obj = MauPhieuXuat_C.NewMauPhieuXuat_C();
            return obj;

        }

        public void NewTo(MauPhieuXuat_C _MauPhieuXuat_C)
        {
            if (!Contains(_MauPhieuXuat_C.MaPX))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _MauPhieuXuat_C.STT = ++_count;
                    this.Add(_MauPhieuXuat_C);
                }
                else
                {
                    _MauPhieuXuat_C.STT = 1;
                    this.Add(_MauPhieuXuat_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public MauPhieuXuat_C AssignTo(DMChePhamMau _DMChePhamMau)
        {
            if (!Contains(_DMChePhamMau.MaCPMau))
            {
                MauPhieuXuat_C obj = MauPhieuXuat_C.NewMauPhieuXuat_C(_DMChePhamMau.MaCPMau);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public MauPhieuXuat_C AssignTo(MauPhieuXuat_C _MauPhieuXuat_C)//add mot hang PhieuNhap_C
        {
            if (!Containss(_MauPhieuXuat_C.MaCPMau, _MauPhieuXuat_C.Huy, _MauPhieuXuat_C.SoLo, _MauPhieuXuat_C.HanSD ))
            {  
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    _MauPhieuXuat_C.HanSD = _MauPhieuXuat_C.HanSD;
                    _MauPhieuXuat_C.STT = ++_count;
                    this.Add(_MauPhieuXuat_C);
                }
                else
                {
                    _MauPhieuXuat_C.STT = 1;
                    _MauPhieuXuat_C.HanSD = _MauPhieuXuat_C.HanSD;
                    this.Add(_MauPhieuXuat_C);
                }
                //Add(_PhieuNhap_C);
               
             }
             return _MauPhieuXuat_C;
        }

        protected override object AddNewCore()
        {
            MauPhieuXuat_C item = MauPhieuXuat_C.NewMauPhieuXuat_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(MauPhieuXuat_C obj)
        {
            //foreach (MauPhieuXuat_C obj in this)
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
            foreach (MauPhieuXuat_C obj in this)
                if (obj.STT.Equals(STT))
                {
                    this.Items.Remove(obj);
                    break;
                }
        }
        public bool Contains(string MaPX)
        {
            foreach (MauPhieuXuat_C obj in this)
                if ((obj.MaPX == MaPX) && (obj.Huy = false))
                    return true;
            return false;
        }
        public bool Containss(string MaCPMau, Boolean Huy, string solo, string hansd)
        {
            foreach (MauPhieuXuat_C obj in this)
                if (hansd != "" || obj.HanSD != "")
                {
                    if ((obj.MaCPMau == MaCPMau) && (obj.SoLo == solo) && (Microsoft.VisualBasic.DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Day, DateTime.Parse(hansd), DateTime.Parse(obj.HanSD), Microsoft.VisualBasic.FirstDayOfWeek.System, Microsoft.VisualBasic.FirstWeekOfYear.System) == 0))
                        return true;
                }
                else
                {
                    if ((obj.MaCPMau == MaCPMau) && (obj.SoLo == solo) && (Microsoft.VisualBasic.DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Day, DateTime.Parse(hansd), DateTime.Parse(obj.HanSD), Microsoft.VisualBasic.FirstDayOfWeek.System, Microsoft.VisualBasic.FirstWeekOfYear.System) == 0))
                        return true;
                }

            return false;
        }
        //public bool Containss(string MaCPMau, Boolean Huy, string solo, string hansd)
        //{
        //    foreach (MauPhieuXuat_C  obj in this)
        //        if ((obj.MaCPMau == MaCPMau) && (obj.Huy == Huy) && (obj.SoLo  == solo) && (obj.HanSD  == hansd))
        //            return true;
        //    return false;
        //}

        public bool ContainsDeleted(string MaPX)
        {
            foreach (MauPhieuXuat_C obj in DeletedList)
                if (obj.MaPX == MaPX)
                    return true;
            return false;
        }

        public void UpdatedTo(MauPhieuXuat_C _MauPhieuXuat_C)
        {

            _MauPhieuXuat_C.STT = this.Items[this.IndexOf(_MauPhieuXuat_C)].STT;
           this.Items[this.IndexOf(_MauPhieuXuat_C)] = _MauPhieuXuat_C;
        }

        public MauPhieuXuat_C GetTo(decimal STT)
        {
            foreach (MauPhieuXuat_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }

        #endregion

        #region Factory Methods

        internal static MauPhieuXuat_Cs NewMauPhieuXuat_Cs()
        {
            return new MauPhieuXuat_Cs();
        }

        internal static MauPhieuXuat_Cs GetMauPhieuXuat_Cs(SafeDataReader dr)
        {
            return new MauPhieuXuat_Cs(dr);
        }

        private MauPhieuXuat_Cs()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private MauPhieuXuat_Cs(SafeDataReader dr)
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
                this.Add(MauPhieuXuat_C.GetMauPhieuXuat_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(MauPhieuXuat packet)
        {
            RaiseListChangedEvents = false;
            foreach (MauPhieuXuat_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (MauPhieuXuat_C item in this)
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