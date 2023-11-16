using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;

using HTC.Business.CategoryList;

namespace HTC.Business.CNK
{
    [Serializable()]
    public class NKPhieuNhap_Cs : BusinessListBase<NKPhieuNhap_Cs, NKPhieuNhap_C>
    {
        #region Business Methods

        public NKPhieuNhap_C this[Decimal STT]
        {
            get
            {
                foreach (NKPhieuNhap_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }


        }
        public NKPhieuNhap_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public void NewTo(string MaPN)
        {
            if (!Contains(MaPN))
            {
                NKPhieuNhap_C obj = NKPhieuNhap_C.NewNKPhieuNhap_C(MaPN);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public NKPhieuNhap_C NewTo()//ham khoi tao doi tuong Phieu nhap
        {

            NKPhieuNhap_C obj = NKPhieuNhap_C.NewNKPhieuNhap_C();
            return obj;

        }

        public void NewTo(NKPhieuNhap_C _NKPhieuNhap_C)
        {
            if (!Contains(_NKPhieuNhap_C.MaPN))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _NKPhieuNhap_C.STT = ++_count;
                    this.Add(_NKPhieuNhap_C);
                }
                else
                {
                    _NKPhieuNhap_C.STT = 1;
                    this.Add(_NKPhieuNhap_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public NKPhieuNhap_C AssignTo(DMCNK _DMCNK)
        {
            if (!Contains(_DMCNK.MaVT))
            {
                NKPhieuNhap_C obj = NKPhieuNhap_C.NewNKPhieuNhap_C(_DMCNK.MaVT);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public NKPhieuNhap_C AssignTo(NKPhieuNhap_C _NKPhieuNhap_C)//add mot hang PhieuNhap_C
        {
            if (!Contains2(_NKPhieuNhap_C.MaVT, _NKPhieuNhap_C.Huy))
            {  
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    _NKPhieuNhap_C.HanSD = _NKPhieuNhap_C.HanSD;
                    _NKPhieuNhap_C.STT = ++_count;
                    this.Add(_NKPhieuNhap_C);
                }
                else
                {
                    _NKPhieuNhap_C.STT = 1;
                    _NKPhieuNhap_C.HanSD = _NKPhieuNhap_C.HanSD;
                    this.Add(_NKPhieuNhap_C);
                }
                //Add(_PhieuNhap_C);
               
             }
             return _NKPhieuNhap_C;
        }

        protected override object AddNewCore()
        {
            NKPhieuNhap_C item = NKPhieuNhap_C.NewNKPhieuNhap_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(NKPhieuNhap_C obj)
        {
            //foreach (NKPhieuNhap_C obj in this)
            //{
            //    if (obj.MaPN.Equals(MaPN))
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
            foreach (NKPhieuNhap_C obj in this)
                if (obj.STT.Equals(STT))
                {
                    this.Items.Remove(obj);
                    break;
                }
        }
        public bool Contains(string MaPN)
        {
            foreach (NKPhieuNhap_C obj in this)
                if ((obj.MaPN == MaPN) && (obj.Huy = false))
                    return true;
            return false;
        }
        public bool Contains2(string MaVT, Boolean Huy)
        {
            foreach (NKPhieuNhap_C obj in this)
                if (obj.MaVT.Equals(MaVT) && obj.Huy == false)
                    return true;
            return false;
        }
        public bool Containss(string MaVT, Boolean Huy, string solo, string hansd)
        {
            foreach (NKPhieuNhap_C obj in this)
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
        //    foreach (NKPhieuNhap_C  obj in this)
        //        if ((obj.MaVT == MaVT) && (obj.Huy == Huy) && (obj.SoLo == solo) && (obj.HanSD == hansd))
        //            return true;
        //    return false;
        //}

        public bool ContainsDeleted(string MaPN)
        {
            foreach (NKPhieuNhap_C obj in DeletedList)
                if (obj.MaPN == MaPN)
                    return true;
            return false;
        }

        public void UpdatedTo(NKPhieuNhap_C _NKPhieuNhap_C)
        {

            _NKPhieuNhap_C.STT = this.Items[this.IndexOf(_NKPhieuNhap_C)].STT;
           this.Items[this.IndexOf(_NKPhieuNhap_C)] = _NKPhieuNhap_C;
        }

        public NKPhieuNhap_C GetTo(decimal STT)
        {
            foreach (NKPhieuNhap_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }

        #endregion

        #region Factory Methods

        internal static NKPhieuNhap_Cs NewNKPhieuNhap_Cs()
        {
            return new NKPhieuNhap_Cs();
        }

        internal static NKPhieuNhap_Cs GetNKPhieuNhap_Cs(SafeDataReader dr)
        {
            return new NKPhieuNhap_Cs(dr);
        }

        private NKPhieuNhap_Cs()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private NKPhieuNhap_Cs(SafeDataReader dr)
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
                this.Add(NKPhieuNhap_C.GetNKPhieuNhap_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(NKPhieuNhap packet)
        {
            RaiseListChangedEvents = false;
            foreach (NKPhieuNhap_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (NKPhieuNhap_C item in this)
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