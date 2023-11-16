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
    public class VTPhieuDoiThuoc_C_List : BusinessListBase<VTPhieuDoiThuoc_C_List, VTPhieuDoiThuoc_C>
    {
        #region Business Methods
        public VTPhieuDoiThuoc_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public VTPhieuDoiThuoc_C this[string MaDThuoc]
        {
            get
            {
                foreach (VTPhieuDoiThuoc_C obj in this)
                    if (obj.MaDThuoc.Equals(MaDThuoc))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaDThuoc)
        {
            if (!Contains(MaDThuoc))
            {
                VTPhieuDoiThuoc_C obj = VTPhieuDoiThuoc_C.NewVTPhieuDoiThuoc_C(MaDThuoc);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VTPhieuDoiThuoc_C NewTo()
        {
           
              VTPhieuDoiThuoc_C obj = VTPhieuDoiThuoc_C.NewVTPhieuDoiThuoc_C();
              return obj;
               
        }
        public void NewTo(VTPhieuDoiThuoc_C _VTPhieuDoiThuoc_C)
        {
            if (!Contains(_VTPhieuDoiThuoc_C.MaVT))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _VTPhieuDoiThuoc_C.STT = ++_count;
                    this.Add(_VTPhieuDoiThuoc_C);
                }
                else
                {
                    _VTPhieuDoiThuoc_C.STT = 1;
                    this.Add(_VTPhieuDoiThuoc_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VTPhieuDoiThuoc_C AssignTo(DMVTYT _DMVTYT)
        {
            if (!Contains(_DMVTYT.MaVT))
            {
                VTPhieuDoiThuoc_C obj = VTPhieuDoiThuoc_C.NewVTPhieuDoiThuoc_C(_DMVTYT.MaVT);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public VTPhieuDoiThuoc_C AssignTo(VTPhieuDoiThuoc_C _VTPhieuDoiThuoc_C)//add mot hang PhieuNhap_C
        {
            if (!Containss(_VTPhieuDoiThuoc_C.MaVT))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    _VTPhieuDoiThuoc_C.STT = ++_count;
                    this.Add(_VTPhieuDoiThuoc_C);
                }
                else
                {
                    _VTPhieuDoiThuoc_C.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_VTPhieuDoiThuoc_C);
                }
            }

            return _VTPhieuDoiThuoc_C;
        }

        protected override object AddNewCore()
        {
            VTPhieuDoiThuoc_C item = VTPhieuDoiThuoc_C.NewVTPhieuDoiThuoc_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(string MaDThuoc)
        {
            foreach (VTPhieuDoiThuoc_C obj in this)
            {
                if (obj.MaDThuoc.Equals(MaDThuoc))
                {
                    Remove(obj);
                    break;
                }
            }
        }

        public void RemoveTo(VTPhieuDoiThuoc_C obj) //xoa 1 VTPhieuDoiThuoc_C
        {

            Remove(obj);


        }

        public bool Contains(string MaDThuoc)
        {
            foreach (VTPhieuDoiThuoc_C obj in this)
                if ((obj.MaDThuoc == MaDThuoc) && (obj.Huy = false))
                    return true;
            return false;
        }
        public bool Containss(string MaVT)
        {
            foreach (VTPhieuDoiThuoc_C obj in this)
                if ((obj.MaDThuoc == MaVT) && (obj.Huy = false))
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaDThuoc)
        {
            foreach (VTPhieuDoiThuoc_C obj in DeletedList)
                if (obj.MaDThuoc == MaDThuoc)
                    return true;
            return false;
        }

        public void UpdatedTo(VTPhieuDoiThuoc_C _VTPhieuDoiThuoc_C)
        {

            _VTPhieuDoiThuoc_C.STT = this.Items[this.IndexOf(_VTPhieuDoiThuoc_C)].STT;
           this.Items[this.IndexOf(_VTPhieuDoiThuoc_C)] = _VTPhieuDoiThuoc_C;
        }
        public VTPhieuDoiThuoc_C GetTo(decimal STT)
        {
            foreach (VTPhieuDoiThuoc_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static VTPhieuDoiThuoc_C_List NewVTPhieuDoiThuoc_C_List()
        {
            return new VTPhieuDoiThuoc_C_List();
        }

        internal static VTPhieuDoiThuoc_C_List GetVTPhieuDoiThuoc_C_List(SafeDataReader dr)
        {
            return new VTPhieuDoiThuoc_C_List(dr);
        }

        private VTPhieuDoiThuoc_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private VTPhieuDoiThuoc_C_List(SafeDataReader dr)
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
                this.Add(VTPhieuDoiThuoc_C.GetVTPhieuDoiThuoc_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(VTPhieuDoiThuoc packet)
        {
            RaiseListChangedEvents = false;
            foreach (VTPhieuDoiThuoc_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (VTPhieuDoiThuoc_C item in this)
            {
                if ((item.IsNew) )   //MaDThuoc ==""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        

       

        #endregion
    }
}