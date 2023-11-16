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
    public class MauXuatTra_C_List : BusinessListBase<MauXuatTra_C_List, MauXuatTra_C>
    {
        #region Business Methods

        public MauXuatTra_C this[string MaPXT]
        {
            get
            {
                foreach (MauXuatTra_C obj in this)
                    if (obj.MaPXT.Equals(MaPXT))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaPXT)
        {
            if (!Contains(MaPXT))
            {
                MauXuatTra_C obj = MauXuatTra_C.NewMauXuatTra_C(MaPXT);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public MauXuatTra_C NewTo()
        {
           
              MauXuatTra_C obj = MauXuatTra_C.NewMauXuatTra_C();
              return obj;
               
        }
        public void NewTo(MauXuatTra_C _MauXuatTra_C)
        {
            if (!Contains(_MauXuatTra_C.MaCPMau))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _MauXuatTra_C.STT = ++_count;
                    this.Add(_MauXuatTra_C);
                }
                else
                {
                    _MauXuatTra_C.STT = 1;
                    this.Add(_MauXuatTra_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public MauXuatTra_C AssignTo(DMChePhamMau _DMChePhamMau)
        {
            if (!Contains(_DMChePhamMau.MaCPMau))
            {
                MauXuatTra_C obj = MauXuatTra_C.NewMauXuatTra_C(_DMChePhamMau.MaCPMau);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public bool Containss(string MaCPMau, Boolean Huy)
        {
            foreach (MauXuatTra_C obj in this)
                if ((obj.MaCPMau  == MaCPMau) && (obj.Huy == Huy))
                    return true;
            return false;
        }
        public bool Containss(string MaCPMau, Boolean Huy, string solo, string  HanSD)
        {
            foreach (MauXuatTra_C obj in this)
                if (solo !=""&& HanSD !="")
                if ((obj.MaCPMau == MaCPMau) && (obj.Huy == Huy) && (obj.SoLo == solo )&& (obj.HanSD == HanSD  ))
                    return true;
                else if (solo == "" && HanSD == "")
                    if ((obj.MaCPMau == MaCPMau) && (obj.Huy == Huy))
                        return true;
            return false;
        }
        public MauXuatTra_C AssignTo(MauXuatTra_C _MauXuatTra_C)//add mot hang MauXuatTra_C
        {
            if (!Containss(_MauXuatTra_C.MaCPMau, _MauXuatTra_C.Huy, _MauXuatTra_C.SoLo ,_MauXuatTra_C.HanSD  ))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    _MauXuatTra_C.STT = ++_count;
                    this.Add(_MauXuatTra_C);
                }
                else
                {
                    _MauXuatTra_C.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_MauXuatTra_C);
                }
            }
            return _MauXuatTra_C;
        }
        protected override object AddNewCore()
        {
            MauXuatTra_C item = MauXuatTra_C.NewMauXuatTra_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(int _STT)
        {
            foreach (MauXuatTra_C obj in this)
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
            foreach (MauXuatTra_C obj in this)
                if ((obj.MaPXT == MaPXT) && (obj.Huy = false))
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaPXT)
        {
            foreach (MauXuatTra_C obj in DeletedList)
                if (obj.MaPXT == MaPXT)
                    return true;
            return false;
        }

        public void UpdatedTo(MauXuatTra_C _MauXuatTra_C)
        {

            _MauXuatTra_C.STT = this.Items[this.IndexOf(_MauXuatTra_C)].STT;
           this.Items[this.IndexOf(_MauXuatTra_C)] = _MauXuatTra_C;
        }
        public MauXuatTra_C GetTo(decimal STT)
        {
            foreach (MauXuatTra_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static MauXuatTra_C_List NewMauXuatTra_C_List()
        {
            return new MauXuatTra_C_List();
        }

        internal static MauXuatTra_C_List GetMauXuatTra_C_List(SafeDataReader dr)
        {
            return new MauXuatTra_C_List(dr);
        }

        private MauXuatTra_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private MauXuatTra_C_List(SafeDataReader dr)
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
                this.Add(MauXuatTra_C.GetMauXuatTra_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(MauXuatTra packet)
        {
            RaiseListChangedEvents = false;
            foreach (MauXuatTra_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (MauXuatTra_C item in this)
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