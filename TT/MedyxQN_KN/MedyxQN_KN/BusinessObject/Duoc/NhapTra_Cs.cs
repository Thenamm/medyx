using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;
//
using HTC.Business.CategoryList;

namespace HTC.Business.Duoc
{
    [Serializable()]
    public class NhapTra_Cs : BusinessListBase<NhapTra_Cs, NhapTra_C>
    {
        #region Business Methods
        public NhapTra_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public NhapTra_C this[Decimal STT]
        {
            get
            {
                foreach (NhapTra_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public NhapTra_C this[string MaPNT]
        {
            get
            {
                foreach (NhapTra_C obj in this)
                    if (obj.MaPNT.Equals(MaPNT))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaPNT)
        {
            if (!Contains(MaPNT))
            {
                NhapTra_C obj = NhapTra_C.NewNhapTra_C(MaPNT);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public NhapTra_C NewTo()
        {
           
              NhapTra_C obj = NhapTra_C.NewNhapTra_C();
              return obj;
               
        }
        public void NewTo(NhapTra_C _NhapTra_C)
        {
            if (!Contains(_NhapTra_C.MaThuoc))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _NhapTra_C.STT = ++_count;
                    this.Add(_NhapTra_C);
                }
                else
                {
                    _NhapTra_C.STT = 1;
                    this.Add(_NhapTra_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public NhapTra_C AssignTo(DMThuoc _DMThuoc)
        {
            if (!Contains(_DMThuoc.MaThuoc))
            {
                NhapTra_C obj = NhapTra_C.NewNhapTra_C(_DMThuoc.MaThuoc);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public NhapTra_C AssignTo(NhapTra_C _NhapTra_C)//add mot hang PhieuNhap_C
        {
            if (_NhapTra_C.HanSD == "01/01/0001")
                _NhapTra_C.HanSD = "";
            if (!Containss(_NhapTra_C.MaThuoc, _NhapTra_C.Huy,_NhapTra_C.SoLo,_NhapTra_C.HanSD  ))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    _NhapTra_C.STT = ++_count;
                    this.Add(_NhapTra_C);
                }
                else
                {
                    _NhapTra_C.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_NhapTra_C);
                }
            }

            return _NhapTra_C;
        }

        protected override object AddNewCore()
        {
            NhapTra_C item = NhapTra_C.NewNhapTra_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void RemoveTo(string MaPNT)
        //{
        //    foreach (NhapTra_C obj in this)
        //    {
        //        if (obj.MaPNT.Equals(MaPNT))
        //        {
        //            Remove(obj);
        //            break;
        //        }
        //    }
        //}
        public void RemoveTo(NhapTra_C obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj);
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }

        public bool Contains(string MaPNT)
        {
            foreach (NhapTra_C obj in this)
                if ((obj.MaPNT == MaPNT) && (obj.Huy = false))
                    return true;
            return false;
        }
        public bool Containss(string MaThuoc, Boolean Huy,string solo, string hansd)
        {
            //foreach (NhapTra_C obj in this)
            //    if ((obj.MaThuoc == MaThuoc) && (obj.Huy == Huy) && (obj.SoLo  == solo) && (obj.HanSD  == hansd))
            //        return true;
            return false;
            
        }

        public bool ContainsDeleted(string MaPNT)
        {
            foreach (NhapTra_C obj in DeletedList)
                if (obj.MaPNT == MaPNT)
                    return true;
            return false;
        }

        public void UpdatedTo(NhapTra_C _NhapTra_C)
        {
            //if (!Containss(_NhapTra_C.MaThuoc, _NhapTra_C.Huy))
            //{
                _NhapTra_C.STT = this.Items[this.IndexOf(_NhapTra_C)].STT;
                this.Items[this.IndexOf(_NhapTra_C)] = _NhapTra_C;
            //}
          
        }
        public NhapTra_C GetTo(decimal STT)
        {
            foreach (NhapTra_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static NhapTra_Cs NewNhapTra_Cs()
        {
            return new NhapTra_Cs();
        }

        internal static NhapTra_Cs GetNhapTra_Cs(SafeDataReader dr)
        {
            return new NhapTra_Cs(dr);
        }

        private NhapTra_Cs()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private NhapTra_Cs(SafeDataReader dr)
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
                this.Add(NhapTra_C.GetNhapTra_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(NhapTra packet)
        {
            RaiseListChangedEvents = false;
            foreach (NhapTra_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (NhapTra_C item in this)
            {
                if ((item.IsNew))// && item.MaPNT == "")   //MaPNT ==""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(NhapTraDT packet)
        {
            RaiseListChangedEvents = false;
            foreach (NhapTra_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (NhapTra_C item in this)
            {
                if ((item.IsNew))   //MaPNT ==""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

       

        #endregion
    }
}