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
    public class NKXuatTra_C_List : BusinessListBase<NKXuatTra_C_List, NKXuatTra_C>
    {
        #region Business Methods

        public NKXuatTra_C this[string MaPXT]
        {
            get
            {
                foreach (NKXuatTra_C obj in this)
                    if (obj.MaPXT.Equals(MaPXT))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaPXT)
        {
            if (!Contains(MaPXT))
            {
                NKXuatTra_C obj = NKXuatTra_C.NewNKXuatTra_C(MaPXT);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public NKXuatTra_C NewTo()
        {
           
              NKXuatTra_C obj = NKXuatTra_C.NewNKXuatTra_C();
              return obj;
               
        }
        public void NewTo(NKXuatTra_C _NKXuatTra_C)
        {
            if (!Contains(_NKXuatTra_C.MaVT))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _NKXuatTra_C.STT = ++_count;
                    this.Add(_NKXuatTra_C);
                }
                else
                {
                    _NKXuatTra_C.STT = 1;
                    this.Add(_NKXuatTra_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public NKXuatTra_C AssignTo(DMCNK _DMCNK)
        {
            if (!Contains(_DMCNK.MaVT))
            {
                NKXuatTra_C obj = NKXuatTra_C.NewNKXuatTra_C(_DMCNK.MaVT);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public bool Containss(string MaVT, Boolean Huy)
        {
            foreach (NKXuatTra_C obj in this)
                if ((obj.MaVT  == MaVT) && (obj.Huy == Huy))
                    return true;
            return false;
        }
        public bool Containss(string MaVT, Boolean Huy, string solo, string  HanSD)
        {
            foreach (NKXuatTra_C obj in this)
                if (solo !=""&& HanSD !="")
                if ((obj.MaVT == MaVT) && (obj.Huy == Huy) && (obj.SoLo == solo )&& (obj.HanSD == HanSD  ))
                    return true;
                else if (solo == "" && HanSD == "")
                    if ((obj.MaVT == MaVT) && (obj.Huy == Huy))
                        return true;
            return false;
        }
        public NKXuatTra_C AssignTo(NKXuatTra_C _NKXuatTra_C)//add mot hang NKXuatTra_C
        {
            if (!Containss(_NKXuatTra_C.MaVT, _NKXuatTra_C.Huy, _NKXuatTra_C.SoLo ,_NKXuatTra_C.HanSD  ))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    _NKXuatTra_C.STT = ++_count;
                    this.Add(_NKXuatTra_C);
                }
                else
                {
                    _NKXuatTra_C.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_NKXuatTra_C);
                }
            }
            return _NKXuatTra_C;
        }
        protected override object AddNewCore()
        {
            NKXuatTra_C item = NKXuatTra_C.NewNKXuatTra_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(int _STT)
        {
            foreach (NKXuatTra_C obj in this)
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
            foreach (NKXuatTra_C obj in this)
                if ((obj.MaPXT == MaPXT) && (obj.Huy = false))
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaPXT)
        {
            foreach (NKXuatTra_C obj in DeletedList)
                if (obj.MaPXT == MaPXT)
                    return true;
            return false;
        }

        public void UpdatedTo(NKXuatTra_C _NKXuatTra_C)
        {

            _NKXuatTra_C.STT = this.Items[this.IndexOf(_NKXuatTra_C)].STT;
           this.Items[this.IndexOf(_NKXuatTra_C)] = _NKXuatTra_C;
        }
        public NKXuatTra_C GetTo(decimal STT)
        {
            foreach (NKXuatTra_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static NKXuatTra_C_List NewNKXuatTra_C_List()
        {
            return new NKXuatTra_C_List();
        }

        internal static NKXuatTra_C_List GetNKXuatTra_C_List(SafeDataReader dr)
        {
            return new NKXuatTra_C_List(dr);
        }

        private NKXuatTra_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private NKXuatTra_C_List(SafeDataReader dr)
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
                this.Add(NKXuatTra_C.GetNKXuatTra_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(NKXuatTra packet)
        {
            RaiseListChangedEvents = false;
            foreach (NKXuatTra_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (NKXuatTra_C item in this)
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