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
    public class MauPhieuDoiThuoc_C_List : BusinessListBase<MauPhieuDoiThuoc_C_List, MauPhieuDoiThuoc_C>
    {
        #region Business Methods

        public MauPhieuDoiThuoc_C this[string MaDThuoc]
        {
            get
            {
                foreach (MauPhieuDoiThuoc_C obj in this)
                    if (obj.MaDThuoc.Equals(MaDThuoc))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaDThuoc)
        {
            if (!Contains(MaDThuoc))
            {
                MauPhieuDoiThuoc_C obj = MauPhieuDoiThuoc_C.NewMauPhieuDoiThuoc_C(MaDThuoc);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public MauPhieuDoiThuoc_C NewTo()
        {
           
              MauPhieuDoiThuoc_C obj = MauPhieuDoiThuoc_C.NewMauPhieuDoiThuoc_C();
              return obj;
               
        }
        public void NewTo(MauPhieuDoiThuoc_C _MauPhieuDoiThuoc_C)
        {
            if (!Contains(_MauPhieuDoiThuoc_C.MaCPMau))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _MauPhieuDoiThuoc_C.STT = ++_count;
                    this.Add(_MauPhieuDoiThuoc_C);
                }
                else
                {
                    _MauPhieuDoiThuoc_C.STT = 1;
                    this.Add(_MauPhieuDoiThuoc_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public MauPhieuDoiThuoc_C AssignTo(DMChePhamMau _DMChePhamMau)
        {
            if (!Contains(_DMChePhamMau.MaCPMau))
            {
                MauPhieuDoiThuoc_C obj = MauPhieuDoiThuoc_C.NewMauPhieuDoiThuoc_C(_DMChePhamMau.MaCPMau);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public MauPhieuDoiThuoc_C AssignTo(MauPhieuDoiThuoc_C _MauPhieuDoiThuoc_C)//add mot hang PhieuNhap_C
        {
            if (!Containss(_MauPhieuDoiThuoc_C.MaCPMau))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    _MauPhieuDoiThuoc_C.STT = ++_count;
                    this.Add(_MauPhieuDoiThuoc_C);
                }
                else
                {
                    _MauPhieuDoiThuoc_C.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_MauPhieuDoiThuoc_C);
                }
            }

            return _MauPhieuDoiThuoc_C;
        }

        protected override object AddNewCore()
        {
            MauPhieuDoiThuoc_C item = MauPhieuDoiThuoc_C.NewMauPhieuDoiThuoc_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(string MaDThuoc)
        {
            foreach (MauPhieuDoiThuoc_C obj in this)
            {
                if (obj.MaDThuoc.Equals(MaDThuoc))
                {
                    Remove(obj);
                    break;
                }
            }
        }

        public void RemoveTo(MauPhieuDoiThuoc_C obj) //xoa 1 MauPhieuDoiThuoc_C
        {

            Remove(obj);


        }

        public bool Contains(string MaDThuoc)
        {
            foreach (MauPhieuDoiThuoc_C obj in this)
                if ((obj.MaDThuoc == MaDThuoc) && (obj.Huy = false))
                    return true;
            return false;
        }
        public bool Containss(string MaCPMau)
        {
            foreach (MauPhieuDoiThuoc_C obj in this)
                if ((obj.MaDThuoc == MaCPMau) && (obj.Huy = false))
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaDThuoc)
        {
            foreach (MauPhieuDoiThuoc_C obj in DeletedList)
                if (obj.MaDThuoc == MaDThuoc)
                    return true;
            return false;
        }

        public void UpdatedTo(MauPhieuDoiThuoc_C _MauPhieuDoiThuoc_C)
        {

            _MauPhieuDoiThuoc_C.STT = this.Items[this.IndexOf(_MauPhieuDoiThuoc_C)].STT;
           this.Items[this.IndexOf(_MauPhieuDoiThuoc_C)] = _MauPhieuDoiThuoc_C;
        }
        public MauPhieuDoiThuoc_C GetTo(decimal STT)
        {
            foreach (MauPhieuDoiThuoc_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static MauPhieuDoiThuoc_C_List NewMauPhieuDoiThuoc_C_List()
        {
            return new MauPhieuDoiThuoc_C_List();
        }

        internal static MauPhieuDoiThuoc_C_List GetMauPhieuDoiThuoc_C_List(SafeDataReader dr)
        {
            return new MauPhieuDoiThuoc_C_List(dr);
        }

        private MauPhieuDoiThuoc_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private MauPhieuDoiThuoc_C_List(SafeDataReader dr)
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
                this.Add(MauPhieuDoiThuoc_C.GetMauPhieuDoiThuoc_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(MauPhieuDoiThuoc packet)
        {
            RaiseListChangedEvents = false;
            foreach (MauPhieuDoiThuoc_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (MauPhieuDoiThuoc_C item in this)
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