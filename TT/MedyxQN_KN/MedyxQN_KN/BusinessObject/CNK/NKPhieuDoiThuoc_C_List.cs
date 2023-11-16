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
    public class NKPhieuDoiThuoc_C_List : BusinessListBase<NKPhieuDoiThuoc_C_List, NKPhieuDoiThuoc_C>
    {
        #region Business Methods

        public NKPhieuDoiThuoc_C this[string MaDThuoc]
        {
            get
            {
                foreach (NKPhieuDoiThuoc_C obj in this)
                    if (obj.MaDThuoc.Equals(MaDThuoc))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaDThuoc)
        {
            if (!Contains(MaDThuoc))
            {
                NKPhieuDoiThuoc_C obj = NKPhieuDoiThuoc_C.NewNKPhieuDoiThuoc_C(MaDThuoc);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public NKPhieuDoiThuoc_C NewTo()
        {
           
              NKPhieuDoiThuoc_C obj = NKPhieuDoiThuoc_C.NewNKPhieuDoiThuoc_C();
              return obj;
               
        }
        public void NewTo(NKPhieuDoiThuoc_C _NKPhieuDoiThuoc_C)
        {
            if (!Contains(_NKPhieuDoiThuoc_C.MaVT))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _NKPhieuDoiThuoc_C.STT = ++_count;
                    this.Add(_NKPhieuDoiThuoc_C);
                }
                else
                {
                    _NKPhieuDoiThuoc_C.STT = 1;
                    this.Add(_NKPhieuDoiThuoc_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public NKPhieuDoiThuoc_C AssignTo(DMCNK _DMCNK)
        {
            if (!Contains(_DMCNK.MaVT))
            {
                NKPhieuDoiThuoc_C obj = NKPhieuDoiThuoc_C.NewNKPhieuDoiThuoc_C(_DMCNK.MaVT);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public NKPhieuDoiThuoc_C AssignTo(NKPhieuDoiThuoc_C _NKPhieuDoiThuoc_C)//add mot hang PhieuNhap_C
        {
            if (!Containss(_NKPhieuDoiThuoc_C.MaVT))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    _NKPhieuDoiThuoc_C.STT = ++_count;
                    this.Add(_NKPhieuDoiThuoc_C);
                }
                else
                {
                    _NKPhieuDoiThuoc_C.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_NKPhieuDoiThuoc_C);
                }
            }

            return _NKPhieuDoiThuoc_C;
        }

        protected override object AddNewCore()
        {
            NKPhieuDoiThuoc_C item = NKPhieuDoiThuoc_C.NewNKPhieuDoiThuoc_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(string MaDThuoc)
        {
            foreach (NKPhieuDoiThuoc_C obj in this)
            {
                if (obj.MaDThuoc.Equals(MaDThuoc))
                {
                    Remove(obj);
                    break;
                }
            }
        }

        public void RemoveTo(NKPhieuDoiThuoc_C obj) //xoa 1 NKPhieuDoiThuoc_C
        {

            Remove(obj);


        }

        public bool Contains(string MaDThuoc)
        {
            foreach (NKPhieuDoiThuoc_C obj in this)
                if ((obj.MaDThuoc == MaDThuoc) && (obj.Huy = false))
                    return true;
            return false;
        }
        public bool Containss(string MaVT)
        {
            foreach (NKPhieuDoiThuoc_C obj in this)
                if ((obj.MaDThuoc == MaVT) && (obj.Huy = false))
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaDThuoc)
        {
            foreach (NKPhieuDoiThuoc_C obj in DeletedList)
                if (obj.MaDThuoc == MaDThuoc)
                    return true;
            return false;
        }

        public void UpdatedTo(NKPhieuDoiThuoc_C _NKPhieuDoiThuoc_C)
        {

            _NKPhieuDoiThuoc_C.STT = this.Items[this.IndexOf(_NKPhieuDoiThuoc_C)].STT;
           this.Items[this.IndexOf(_NKPhieuDoiThuoc_C)] = _NKPhieuDoiThuoc_C;
        }
        public NKPhieuDoiThuoc_C GetTo(decimal STT)
        {
            foreach (NKPhieuDoiThuoc_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static NKPhieuDoiThuoc_C_List NewNKPhieuDoiThuoc_C_List()
        {
            return new NKPhieuDoiThuoc_C_List();
        }

        internal static NKPhieuDoiThuoc_C_List GetNKPhieuDoiThuoc_C_List(SafeDataReader dr)
        {
            return new NKPhieuDoiThuoc_C_List(dr);
        }

        private NKPhieuDoiThuoc_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private NKPhieuDoiThuoc_C_List(SafeDataReader dr)
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
                this.Add(NKPhieuDoiThuoc_C.GetNKPhieuDoiThuoc_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(NKPhieuDoiThuoc packet)
        {
            RaiseListChangedEvents = false;
            foreach (NKPhieuDoiThuoc_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (NKPhieuDoiThuoc_C item in this)
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