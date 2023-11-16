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
    public class VTNhapTra_Cs : BusinessListBase<VTNhapTra_Cs, VTNhapTra_C>
    {
        #region Business Methods
        public VTNhapTra_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public VTNhapTra_C this[Decimal STT]
        {
            get
            {
                foreach (VTNhapTra_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public VTNhapTra_C this[string MaPNT]
        {
            get
            {
                foreach (VTNhapTra_C obj in this)
                    if (obj.MaPNT.Equals(MaPNT))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaPNT)
        {
            if (!Contains(MaPNT))
            {
                VTNhapTra_C obj = VTNhapTra_C.NewVTNhapTra_C(MaPNT);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VTNhapTra_C NewTo()
        {
           
              VTNhapTra_C obj = VTNhapTra_C.NewVTNhapTra_C();
              return obj;
               
        }
        public void NewTo(VTNhapTra_C _VTNhapTra_C)
        {
            if (!Contains(_VTNhapTra_C.MaVT))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _VTNhapTra_C.STT = ++_count;
                    this.Add(_VTNhapTra_C);
                }
                else
                {
                    _VTNhapTra_C.STT = 1;
                    this.Add(_VTNhapTra_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VTNhapTra_C AssignTo(DMVTYT _DMVTYT)
        {
            if (!Contains(_DMVTYT.MaVT))
            {
                VTNhapTra_C obj = VTNhapTra_C.NewVTNhapTra_C(_DMVTYT.MaVT);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VTNhapTra_C AssignTo(VTNhapTra_C _VTNhapTra_C)//add mot hang PhieuNhap_C
        {
            if (_VTNhapTra_C.HanSD == "01/01/0001")
                _VTNhapTra_C.HanSD = "";
            if (!Containss(_VTNhapTra_C.MaVT, _VTNhapTra_C.Huy,_VTNhapTra_C.SoLo ,_VTNhapTra_C.HanSD ))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    _VTNhapTra_C.STT = ++_count;
                    this.Add(_VTNhapTra_C);
                }
                else
                {
                    _VTNhapTra_C.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_VTNhapTra_C);
                }
            }

            return _VTNhapTra_C;
        }

        protected override object AddNewCore()
        {
            VTNhapTra_C item = VTNhapTra_C.NewVTNhapTra_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void RemoveTo(string MaPNT)
        //{
        //    foreach (VTNhapTra_C obj in this)
        //    {
        //        if (obj.MaPNT.Equals(MaPNT))
        //        {
        //            Remove(obj);
        //            break;
        //        }
        //    }
        //}
        //public void RemoveTo(VTNhapTra_C obj) //xoa 1 PhieuNhap_C
        //{

        //    Remove(obj);


        //}
        public void RemoveTo(VTNhapTra_C obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj);
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }

        public bool Contains(string MaPNT)
        {
            foreach (VTNhapTra_C obj in this)
                if ((obj.MaPNT == MaPNT) && (obj.Huy = false))
                    return true;
            return false;
        }
        public bool Containss(string MaVT, Boolean Huy,string solo, string hansd)
        {
            //foreach (VTNhapTra_C obj in this)
            //    if ((obj.MaVT == MaVT) && (obj.Huy == Huy) && (obj.SoLo  == solo) && (obj.HanSD  == hansd))
            //        return true;
            return false;
            
        }

        public bool ContainsDeleted(string MaPNT)
        {
            foreach (VTNhapTra_C obj in DeletedList)
                if (obj.MaPNT == MaPNT)
                    return true;
            return false;
        }

        public void UpdatedTo(VTNhapTra_C _VTNhapTra_C)
        {
            //if (!Containss(_VTNhapTra_C.MaVT, _VTNhapTra_C.Huy))
            //{
                _VTNhapTra_C.STT = this.Items[this.IndexOf(_VTNhapTra_C)].STT;
                this.Items[this.IndexOf(_VTNhapTra_C)] = _VTNhapTra_C;
            //}
          
        }
        public VTNhapTra_C GetTo(decimal STT)
        {
            foreach (VTNhapTra_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static VTNhapTra_Cs NewVTNhapTra_Cs()
        {
            return new VTNhapTra_Cs();
        }

        internal static VTNhapTra_Cs GetVTNhapTra_Cs(SafeDataReader dr)
        {
            return new VTNhapTra_Cs(dr);
        }

        private VTNhapTra_Cs()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private VTNhapTra_Cs(SafeDataReader dr)
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
                this.Add(VTNhapTra_C.GetVTNhapTra_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(VTNhapTra packet)
        {
            RaiseListChangedEvents = false;
            foreach (VTNhapTra_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (VTNhapTra_C item in this)
            {
                if ((item.IsNew))// && item.MaPNT == "")   //MaPNT ==""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        

       

        #endregion
    }
}