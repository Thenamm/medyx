using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;
//
using HTC.Business.CategoryList;

namespace HTC.Business.HoaChat
{
    [Serializable()]
    public class HCPhieuDoiThuoc_C_List : BusinessListBase<HCPhieuDoiThuoc_C_List, HCPhieuDoiThuoc_C>
    {
        #region Business Methods
        public HCPhieuDoiThuoc_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public HCPhieuDoiThuoc_C this[string MaDThuoc]
        {
            get
            {
                foreach (HCPhieuDoiThuoc_C obj in this)
                    if (obj.MaDThuoc.Equals(MaDThuoc))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaDThuoc)
        {
            if (!Contains(MaDThuoc))
            {
                HCPhieuDoiThuoc_C obj = HCPhieuDoiThuoc_C.NewHCPhieuDoiThuoc_C(MaDThuoc);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public HCPhieuDoiThuoc_C NewTo()
        {
           
              HCPhieuDoiThuoc_C obj = HCPhieuDoiThuoc_C.NewHCPhieuDoiThuoc_C();
              return obj;
               
        }
        public void NewTo(HCPhieuDoiThuoc_C _HCPhieuDoiThuoc_C)
        {
            if (!Contains(_HCPhieuDoiThuoc_C.MaHC))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _HCPhieuDoiThuoc_C.STT = ++_count;
                    this.Add(_HCPhieuDoiThuoc_C);
                }
                else
                {
                    _HCPhieuDoiThuoc_C.STT = 1;
                    this.Add(_HCPhieuDoiThuoc_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public HCPhieuDoiThuoc_C AssignTo(DMHoaChat _DMHoaChat)
        {
            if (!Contains(_DMHoaChat.MaHC))
            {
                HCPhieuDoiThuoc_C obj = HCPhieuDoiThuoc_C.NewHCPhieuDoiThuoc_C(_DMHoaChat.MaHC);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public HCPhieuDoiThuoc_C AssignTo(HCPhieuDoiThuoc_C _HCPhieuDoiThuoc_C)//add mot hang PhieuNhap_C
        {
            if (!Containss(_HCPhieuDoiThuoc_C.MaHC))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    _HCPhieuDoiThuoc_C.STT = ++_count;
                    this.Add(_HCPhieuDoiThuoc_C);
                }
                else
                {
                    _HCPhieuDoiThuoc_C.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_HCPhieuDoiThuoc_C);
                }
            }

            return _HCPhieuDoiThuoc_C;
        }

        protected override object AddNewCore()
        {
            HCPhieuDoiThuoc_C item = HCPhieuDoiThuoc_C.NewHCPhieuDoiThuoc_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(string MaDThuoc)
        {
            foreach (HCPhieuDoiThuoc_C obj in this)
            {
                if (obj.MaDThuoc.Equals(MaDThuoc))
                {
                    Remove(obj);
                    break;
                }
            }
        }

        public void RemoveTo(HCPhieuDoiThuoc_C obj) //xoa 1 HCPhieuDoiThuoc_C
        {

            Remove(obj);


        }

        public bool Contains(string MaDThuoc)
        {
            foreach (HCPhieuDoiThuoc_C obj in this)
                if ((obj.MaDThuoc == MaDThuoc) && (obj.Huy = false))
                    return true;
            return false;
        }
        public bool Containss(string MaHC)
        {
            foreach (HCPhieuDoiThuoc_C obj in this)
                if ((obj.MaDThuoc == MaHC) && (obj.Huy = false))
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaDThuoc)
        {
            foreach (HCPhieuDoiThuoc_C obj in DeletedList)
                if (obj.MaDThuoc == MaDThuoc)
                    return true;
            return false;
        }

        public void UpdatedTo(HCPhieuDoiThuoc_C _HCPhieuDoiThuoc_C)
        {

            _HCPhieuDoiThuoc_C.STT = this.Items[this.IndexOf(_HCPhieuDoiThuoc_C)].STT;
           this.Items[this.IndexOf(_HCPhieuDoiThuoc_C)] = _HCPhieuDoiThuoc_C;
        }
        public HCPhieuDoiThuoc_C GetTo(decimal STT)
        {
            foreach (HCPhieuDoiThuoc_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static HCPhieuDoiThuoc_C_List NewHCPhieuDoiThuoc_C_List()
        {
            return new HCPhieuDoiThuoc_C_List();
        }

        internal static HCPhieuDoiThuoc_C_List GetHCPhieuDoiThuoc_C_List(SafeDataReader dr)
        {
            return new HCPhieuDoiThuoc_C_List(dr);
        }

        private HCPhieuDoiThuoc_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private HCPhieuDoiThuoc_C_List(SafeDataReader dr)
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
                this.Add(HCPhieuDoiThuoc_C.GetHCPhieuDoiThuoc_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(HCPhieuDoiThuoc packet)
        {
            RaiseListChangedEvents = false;
            foreach (HCPhieuDoiThuoc_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (HCPhieuDoiThuoc_C item in this)
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