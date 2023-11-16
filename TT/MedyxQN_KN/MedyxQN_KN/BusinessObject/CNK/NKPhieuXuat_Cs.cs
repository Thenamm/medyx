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
    public class NKPhieuXuat_Cs : BusinessListBase<NKPhieuXuat_Cs, NKPhieuXuat_C>
    {
        #region Business Methods

        public NKPhieuXuat_C this[Decimal STT]
        {
            get
            {
                foreach (NKPhieuXuat_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public NKPhieuXuat_C this[int i]
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
                NKPhieuXuat_C obj = NKPhieuXuat_C.NewNKPhieuXuat_C(MaPX);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public NKPhieuXuat_C NewTo()//ham khoi tao doi tuong Phieu nhap
        {

            NKPhieuXuat_C obj = NKPhieuXuat_C.NewNKPhieuXuat_C();
            return obj;

        }

        public void NewTo(NKPhieuXuat_C _NKPhieuXuat_C)
        {
            if (!Contains(_NKPhieuXuat_C.MaPX))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _NKPhieuXuat_C.STT = ++_count;
                    this.Add(_NKPhieuXuat_C);
                }
                else
                {
                    _NKPhieuXuat_C.STT = 1;
                    this.Add(_NKPhieuXuat_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public NKPhieuXuat_C AssignTo(DMCNK _DMCNK)
        {
            if (!Contains(_DMCNK.MaVT))
            {
                NKPhieuXuat_C obj = NKPhieuXuat_C.NewNKPhieuXuat_C(_DMCNK.MaVT);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public NKPhieuXuat_C AssignTo(NKPhieuXuat_C _NKPhieuXuat_C)//add mot hang PhieuNhap_C
        {
            if (!Containss(_NKPhieuXuat_C.MaVT, _NKPhieuXuat_C.Huy, _NKPhieuXuat_C.SoLo, _NKPhieuXuat_C.HanSD ))
            {  
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    _NKPhieuXuat_C.HanSD = _NKPhieuXuat_C.HanSD;
                    _NKPhieuXuat_C.STT = ++_count;
                    this.Add(_NKPhieuXuat_C);
                }
                else
                {
                    _NKPhieuXuat_C.STT = 1;
                    _NKPhieuXuat_C.HanSD = _NKPhieuXuat_C.HanSD;
                    this.Add(_NKPhieuXuat_C);
                }
                //Add(_PhieuNhap_C);
               
             }
             return _NKPhieuXuat_C;
        }

        protected override object AddNewCore()
        {
            NKPhieuXuat_C item = NKPhieuXuat_C.NewNKPhieuXuat_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(NKPhieuXuat_C obj)
        {
            //foreach (NKPhieuXuat_C obj in this)
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
            foreach (NKPhieuXuat_C obj in this)
                if (obj.STT.Equals(STT))
                {
                    this.Items.Remove(obj);
                    break;
                }
        }
        public bool Contains(string MaPX)
        {
            foreach (NKPhieuXuat_C obj in this)
                if ((obj.MaPX == MaPX) && (obj.Huy == false))
                    return true;
            return false;
        }
        public bool Containss(string MaVT, Boolean Huy, string solo, string hansd)
        {
            foreach (NKPhieuXuat_C obj in this)

                if ((obj.MaVT == MaVT) && (obj.Huy == false))
                        return true;
               
              

            return false;
        }
        //public bool Containss(string MaVT, Boolean Huy, string solo, string hansd)
        //{
        //    foreach (NKPhieuXuat_C  obj in this)
        //        if ((obj.MaVT == MaVT) && (obj.Huy == Huy) && (obj.SoLo == solo) && (obj.HanSD == hansd))
        //            return true;
        //    return false;
        //}

        public bool ContainsDeleted(string MaPX)
        {
            foreach (NKPhieuXuat_C obj in DeletedList)
                if (obj.MaPX == MaPX)
                    return true;
            return false;
        }

        public void UpdatedTo(NKPhieuXuat_C _NKPhieuXuat_C)
        {

            _NKPhieuXuat_C.STT = this.Items[this.IndexOf(_NKPhieuXuat_C)].STT;
           this.Items[this.IndexOf(_NKPhieuXuat_C)] = _NKPhieuXuat_C;
        }

        public NKPhieuXuat_C GetTo(decimal STT)
        {
            foreach (NKPhieuXuat_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }

        #endregion

        #region Factory Methods

        internal static NKPhieuXuat_Cs NewNKPhieuXuat_Cs()
        {
            return new NKPhieuXuat_Cs();
        }

        internal static NKPhieuXuat_Cs GetNKPhieuXuat_Cs(SafeDataReader dr)
        {
            return new NKPhieuXuat_Cs(dr);
        }

        private NKPhieuXuat_Cs()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private NKPhieuXuat_Cs(SafeDataReader dr)
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
                this.Add(NKPhieuXuat_C.GetNKPhieuXuat_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(NKPhieuXuat packet)
        {
            RaiseListChangedEvents = false;
            foreach (NKPhieuXuat_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (NKPhieuXuat_C item in this)
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