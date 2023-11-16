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
    public class NKNhapTra_Cs : BusinessListBase<NKNhapTra_Cs, NKNhapTra_C>
    {
        #region Business Methods
        public NKNhapTra_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public NKNhapTra_C this[Decimal STT]
        {
            get
            {
                foreach (NKNhapTra_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public NKNhapTra_C this[string MaPNT]
        {
            get
            {
                foreach (NKNhapTra_C obj in this)
                    if (obj.MaPNT.Equals(MaPNT))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaPNT)
        {
            if (!Contains(MaPNT))
            {
                NKNhapTra_C obj = NKNhapTra_C.NewNKNhapTra_C(MaPNT);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public NKNhapTra_C NewTo()
        {
           
              NKNhapTra_C obj = NKNhapTra_C.NewNKNhapTra_C();
              return obj;
               
        }
        public void NewTo(NKNhapTra_C _NKNhapTra_C)
        {
            if (!Contains(_NKNhapTra_C.MaVT))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _NKNhapTra_C.STT = ++_count;
                    this.Add(_NKNhapTra_C);
                }
                else
                {
                    _NKNhapTra_C.STT = 1;
                    this.Add(_NKNhapTra_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public NKNhapTra_C AssignTo(DMCNK _DMCNK)
        {
            if (!Contains(_DMCNK.MaVT))
            {
                NKNhapTra_C obj = NKNhapTra_C.NewNKNhapTra_C(_DMCNK.MaVT);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public NKNhapTra_C AssignTo(NKNhapTra_C _NKNhapTra_C)//add mot hang PhieuNhap_C
        {
            if (!Containss(_NKNhapTra_C.MaVT, _NKNhapTra_C.Huy,_NKNhapTra_C.SoLo ,_NKNhapTra_C.HanSD ))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    _NKNhapTra_C.STT = ++_count;
                    this.Add(_NKNhapTra_C);
                }
                else
                {
                    _NKNhapTra_C.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_NKNhapTra_C);
                }
            }

            return _NKNhapTra_C;
        }

        protected override object AddNewCore()
        {
            NKNhapTra_C item = NKNhapTra_C.NewNKNhapTra_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void RemoveTo(string MaPNT)
        //{
        //    foreach (NKNhapTra_C obj in this)
        //    {
        //        if (obj.MaPNT.Equals(MaPNT))
        //        {
        //            Remove(obj);
        //            break;
        //        }
        //    }
        //}
        //public void RemoveTo(NKNhapTra_C obj) //xoa 1 PhieuNhap_C
        //{

        //    Remove(obj);


        //}
        public void RemoveTo(NKNhapTra_C obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj);
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }

        public bool Contains(string MaPNT)
        {
            foreach (NKNhapTra_C obj in this)
                if ((obj.MaPNT == MaPNT) && (obj.Huy = false))
                    return true;
            return false;
        }
        public bool Containss(string MaVT, Boolean Huy,string solo, string hansd)
        {
            foreach (NKNhapTra_C obj in this)
                if ((obj.MaVT == MaVT) && (obj.Huy == Huy) && (obj.SoLo  == solo) && (obj.HanSD  == hansd))
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaPNT)
        {
            foreach (NKNhapTra_C obj in DeletedList)
                if (obj.MaPNT == MaPNT)
                    return true;
            return false;
        }

        public void UpdatedTo(NKNhapTra_C _NKNhapTra_C)
        {
            //if (!Containss(_NKNhapTra_C.MaVT, _NKNhapTra_C.Huy))
            //{
                _NKNhapTra_C.STT = this.Items[this.IndexOf(_NKNhapTra_C)].STT;
                this.Items[this.IndexOf(_NKNhapTra_C)] = _NKNhapTra_C;
            //}
          
        }
        public NKNhapTra_C GetTo(decimal STT)
        {
            foreach (NKNhapTra_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static NKNhapTra_Cs NewNKNhapTra_Cs()
        {
            return new NKNhapTra_Cs();
        }

        internal static NKNhapTra_Cs GetNKNhapTra_Cs(SafeDataReader dr)
        {
            return new NKNhapTra_Cs(dr);
        }

        private NKNhapTra_Cs()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private NKNhapTra_Cs(SafeDataReader dr)
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
                this.Add(NKNhapTra_C.GetNKNhapTra_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(NKNhapTra packet)
        {
            RaiseListChangedEvents = false;
            foreach (NKNhapTra_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (NKNhapTra_C item in this)
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