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
    public class VPPNhapTra_Cs : BusinessListBase<VPPNhapTra_Cs, VPPNhapTra_C>
    {
        #region Business Methods
        public VPPNhapTra_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public VPPNhapTra_C this[Decimal STT]
        {
            get
            {
                foreach (VPPNhapTra_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public VPPNhapTra_C this[string MaPNT]
        {
            get
            {
                foreach (VPPNhapTra_C obj in this)
                    if (obj.MaPNT.Equals(MaPNT))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaPNT)
        {
            if (!Contains(MaPNT))
            {
                VPPNhapTra_C obj = VPPNhapTra_C.NewVPPNhapTra_C(MaPNT);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VPPNhapTra_C NewTo()
        {
           
              VPPNhapTra_C obj = VPPNhapTra_C.NewVPPNhapTra_C();
              return obj;
               
        }
        public void NewTo(VPPNhapTra_C _VPPNhapTra_C)
        {
            if (!Contains(_VPPNhapTra_C.MaVT))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _VPPNhapTra_C.STT = ++_count;
                    this.Add(_VPPNhapTra_C);
                }
                else
                {
                    _VPPNhapTra_C.STT = 1;
                    this.Add(_VPPNhapTra_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VPPNhapTra_C AssignTo(DMVPP _DMVPP)
        {
            if (!Contains(_DMVPP.MaVT))
            {
                VPPNhapTra_C obj = VPPNhapTra_C.NewVPPNhapTra_C(_DMVPP.MaVT);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VPPNhapTra_C AssignTo(VPPNhapTra_C _VPPNhapTra_C)//add mot hang PhieuNhap_C
        {
            if (_VPPNhapTra_C.HanSD == "01/01/0001")
                _VPPNhapTra_C.HanSD = "";
            if (!Containss(_VPPNhapTra_C.MaVT, _VPPNhapTra_C.Huy,_VPPNhapTra_C.SoLo ,_VPPNhapTra_C.HanSD ))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    _VPPNhapTra_C.STT = ++_count;
                    this.Add(_VPPNhapTra_C);
                }
                else
                {
                    _VPPNhapTra_C.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_VPPNhapTra_C);
                }
            }

            return _VPPNhapTra_C;
        }

        protected override object AddNewCore()
        {
            VPPNhapTra_C item = VPPNhapTra_C.NewVPPNhapTra_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void RemoveTo(string MaPNT)
        //{
        //    foreach (VPPNhapTra_C obj in this)
        //    {
        //        if (obj.MaPNT.Equals(MaPNT))
        //        {
        //            Remove(obj);
        //            break;
        //        }
        //    }
        //}
        //public void RemoveTo(VPPNhapTra_C obj) //xoa 1 PhieuNhap_C
        //{

        //    Remove(obj);


        //}
        public void RemoveTo(VPPNhapTra_C obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj);
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }

        public bool Contains(string MaPNT)
        {
            foreach (VPPNhapTra_C obj in this)
                if ((obj.MaPNT == MaPNT) && (obj.Huy = false))
                    return true;
            return false;
        }
        public bool Containss(string MaVPP, Boolean Huy,string solo, string hansd)
        {
            foreach (VPPNhapTra_C obj in this)
                if ((obj.MaVT  == MaVPP) && (obj.Huy == Huy) && (obj.SoLo  == solo) && (obj.HanSD  == hansd))
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaPNT)
        {
            foreach (VPPNhapTra_C obj in DeletedList)
                if (obj.MaPNT == MaPNT)
                    return true;
            return false;
        }

        public void UpdatedTo(VPPNhapTra_C _VPPNhapTra_C)
        {
            //if (!Containss(_VPPNhapTra_C.MaVPP, _VPPNhapTra_C.Huy))
            //{
                _VPPNhapTra_C.STT = this.Items[this.IndexOf(_VPPNhapTra_C)].STT;
                this.Items[this.IndexOf(_VPPNhapTra_C)] = _VPPNhapTra_C;
            //}
          
        }
        public VPPNhapTra_C GetTo(decimal STT)
        {
            foreach (VPPNhapTra_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static VPPNhapTra_Cs NewVPPNhapTra_Cs()
        {
            return new VPPNhapTra_Cs();
        }

        internal static VPPNhapTra_Cs GetVPPNhapTra_Cs(SafeDataReader dr)
        {
            return new VPPNhapTra_Cs(dr);
        }

        private VPPNhapTra_Cs()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private VPPNhapTra_Cs(SafeDataReader dr)
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
                this.Add(VPPNhapTra_C.GetVPPNhapTra_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(VPPNhapTra packet)
        {
            RaiseListChangedEvents = false;
            foreach (VPPNhapTra_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (VPPNhapTra_C item in this)
            {
                if ((item.IsNew) )   //MaPNT ==""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        

       

        #endregion
    }
}