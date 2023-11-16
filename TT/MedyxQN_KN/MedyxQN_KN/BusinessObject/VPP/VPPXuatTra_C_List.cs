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
    public class VPPXuatTra_C_List : BusinessListBase<VPPXuatTra_C_List, VPPXuatTra_C>
    {
        #region Business Methods
        public VPPXuatTra_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public VPPXuatTra_C this[string MaPXT]
        {
            get
            {
                foreach (VPPXuatTra_C obj in this)
                    if (obj.MaPXT.Equals(MaPXT))
                        return obj;
                return null;
            }
        }
        public VPPXuatTra_C this[decimal STT]
        {
            get
            {
                foreach (VPPXuatTra_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaPXT)
        {
            if (!Contains(MaPXT))
            {
                VPPXuatTra_C obj = VPPXuatTra_C.NewVPPXuatTra_C(MaPXT);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VPPXuatTra_C NewTo()
        {
           
              VPPXuatTra_C obj = VPPXuatTra_C.NewVPPXuatTra_C();
              return obj;
               
        }
        public void NewTo(VPPXuatTra_C _VPPXuatTra_C)
        {
            if (!Contains(_VPPXuatTra_C.MaVT))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _VPPXuatTra_C.STT = ++_count;
                    this.Add(_VPPXuatTra_C);
                }
                else
                {
                    _VPPXuatTra_C.STT = 1;
                    this.Add(_VPPXuatTra_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VPPXuatTra_C AssignTo(DMVPP _DMVPP)
        {
            if (!Contains(_DMVPP.MaVT))
            {
                VPPXuatTra_C obj = VPPXuatTra_C.NewVPPXuatTra_C(_DMVPP.MaVT);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public bool Containss(string MaVT, Boolean Huy)
        {
            foreach (VPPXuatTra_C obj in this)
                if ((obj.MaVT  == MaVT) && (obj.Huy == Huy))
                    return true;
            return false;
        }
        public bool Containss(string MaVT, Boolean Huy, string solo, string  HanSD)
        {
            foreach (VPPXuatTra_C obj in this)
                if (solo !=""&& HanSD !="")
                if ((obj.MaVT == MaVT) && (obj.Huy == Huy) && (obj.SoLo == solo )&& (obj.HanSD == HanSD  ))
                    return true;
                else if (solo == "" && HanSD == "")
                    if ((obj.MaVT == MaVT) && (obj.Huy == Huy))
                        return true;
            return false;
        }
        public VPPXuatTra_C AssignTo(VPPXuatTra_C _VPPXuatTra_C)//add mot hang VPPXuatTra_C
        {
            if (!Containss(_VPPXuatTra_C.MaVT, _VPPXuatTra_C.Huy, _VPPXuatTra_C.SoLo ,_VPPXuatTra_C.HanSD  ))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    _VPPXuatTra_C.STT = ++_count;
                    this.Add(_VPPXuatTra_C);
                }
                else
                {
                    _VPPXuatTra_C.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_VPPXuatTra_C);
                }
            }
            return _VPPXuatTra_C;
        }
        protected override object AddNewCore()
        {
            VPPXuatTra_C item = VPPXuatTra_C.NewVPPXuatTra_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(int _STT)
        {
            foreach (VPPXuatTra_C obj in this)
            {
                if (obj.STT.Equals(_STT))
                {
                    Remove(obj);
                    break;
                }
            }
        }

        public bool Contains(string MaPXT)
        {
            foreach (VPPXuatTra_C obj in this)
                if ((obj.MaPXT == MaPXT) && (obj.Huy = false))
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaPXT)
        {
            foreach (VPPXuatTra_C obj in DeletedList)
                if (obj.MaPXT == MaPXT)
                    return true;
            return false;
        }

        public void UpdatedTo(VPPXuatTra_C _VPPXuatTra_C)
        {

            _VPPXuatTra_C.STT = this.Items[this.IndexOf(_VPPXuatTra_C)].STT;
           this.Items[this.IndexOf(_VPPXuatTra_C)] = _VPPXuatTra_C;
        }
       
        public VPPXuatTra_C GetTo(decimal STT)
        {
            foreach (VPPXuatTra_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static VPPXuatTra_C_List NewVPPXuatTra_C_List()
        {
            return new VPPXuatTra_C_List();
        }

        internal static VPPXuatTra_C_List GetVPPXuatTra_C_List(SafeDataReader dr)
        {
            return new VPPXuatTra_C_List(dr);
        }

        private VPPXuatTra_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private VPPXuatTra_C_List(SafeDataReader dr)
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
                this.Add(VPPXuatTra_C.GetVPPXuatTra_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(VPPXuatTra packet)
        {
            RaiseListChangedEvents = false;
            foreach (VPPXuatTra_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (VPPXuatTra_C item in this)
            {
                if ((item.IsNew) )   //MaPXT ==""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        

      

        #endregion
    }
}