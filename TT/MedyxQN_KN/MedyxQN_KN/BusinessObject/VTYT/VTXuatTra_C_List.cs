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
    public class VTXuatTra_C_List : BusinessListBase<VTXuatTra_C_List, VTXuatTra_C>
    {
        #region Business Methods
        public VTXuatTra_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public VTXuatTra_C this[string MaPXT]
        {
            get
            {
                foreach (VTXuatTra_C obj in this)
                    if (obj.MaPXT.Equals(MaPXT))
                        return obj;
                return null;
            }
        }
        public VTXuatTra_C this[decimal STT]
        {
            get
            {
                foreach (VTXuatTra_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaPXT)
        {
            if (!Contains(MaPXT))
            {
                VTXuatTra_C obj = VTXuatTra_C.NewVTXuatTra_C(MaPXT);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VTXuatTra_C NewTo()
        {
           
              VTXuatTra_C obj = VTXuatTra_C.NewVTXuatTra_C();
              return obj;
               
        }
        public void NewTo(VTXuatTra_C _VTXuatTra_C)
        {
            if (!Contains(_VTXuatTra_C.MaVT))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _VTXuatTra_C.STT = ++_count;
                    this.Add(_VTXuatTra_C);
                }
                else
                {
                    _VTXuatTra_C.STT = 1;
                    this.Add(_VTXuatTra_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VTXuatTra_C AssignTo(DMVTYT _DMVTYT)
        {
            if (!Contains(_DMVTYT.MaVT))
            {
                VTXuatTra_C obj = VTXuatTra_C.NewVTXuatTra_C(_DMVTYT.MaVT);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public bool Containss(string MaVT, Boolean Huy)
        {
            foreach (VTXuatTra_C obj in this)
                if ((obj.MaVT  == MaVT) && (obj.Huy == Huy))
                    return true;
            return false;
        }
        public bool Containss(string MaVT, Boolean Huy, string solo, string  HanSD)
        {
            //foreach (VTXuatTra_C obj in this)
            //    if (solo !=""&& HanSD !="")
            //    if ((obj.MaVT == MaVT) && (obj.Huy == Huy) && (obj.SoLo == solo )&& (obj.HanSD == HanSD  ))
            //        return true;
            //    else if (solo == "" && HanSD == "")
            //        if ((obj.MaVT == MaVT) && (obj.Huy == Huy))
            //            return true;
            return false;
          
        }
        public VTXuatTra_C AssignTo(VTXuatTra_C _VTXuatTra_C)//add mot hang VTXuatTra_C
        {
            if (!Containss(_VTXuatTra_C.MaVT, _VTXuatTra_C.Huy, _VTXuatTra_C.SoLo ,_VTXuatTra_C.HanSD  ))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    _VTXuatTra_C.STT = ++_count;
                    this.Add(_VTXuatTra_C);
                }
                else
                {
                    _VTXuatTra_C.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_VTXuatTra_C);
                }
            }
            return _VTXuatTra_C;
        }
        protected override object AddNewCore()
        {
            VTXuatTra_C item = VTXuatTra_C.NewVTXuatTra_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(int _STT)
        {
            foreach (VTXuatTra_C obj in this)
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
            foreach (VTXuatTra_C obj in this)
                if ((obj.MaPXT == MaPXT) && (obj.Huy = false))
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaPXT)
        {
            foreach (VTXuatTra_C obj in DeletedList)
                if (obj.MaPXT == MaPXT)
                    return true;
            return false;
        }

        public void UpdatedTo(VTXuatTra_C _VTXuatTra_C)
        {

            _VTXuatTra_C.STT = this.Items[this.IndexOf(_VTXuatTra_C)].STT;
           this.Items[this.IndexOf(_VTXuatTra_C)] = _VTXuatTra_C;
        }
       
        public VTXuatTra_C GetTo(decimal STT)
        {
            foreach (VTXuatTra_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static VTXuatTra_C_List NewVTXuatTra_C_List()
        {
            return new VTXuatTra_C_List();
        }

        internal static VTXuatTra_C_List GetVTXuatTra_C_List(SafeDataReader dr)
        {
            return new VTXuatTra_C_List(dr);
        }

        private VTXuatTra_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private VTXuatTra_C_List(SafeDataReader dr)
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
                this.Add(VTXuatTra_C.GetVTXuatTra_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(VTXuatTra packet)
        {
            RaiseListChangedEvents = false;
            foreach (VTXuatTra_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (VTXuatTra_C item in this)
            {
                if ((item.IsNew))// && item.MaPXT == "")   //MaPXT ==""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        

      

        #endregion
    }
}