using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;
//
using HTC.Business.CategoryList;

namespace HTC.Business.Duoc
{
    [Serializable()]
    public class PhieuDoiThuoc_C_List : BusinessListBase<PhieuDoiThuoc_C_List, PhieuDoiThuoc_C>
    {
        #region Business Methods
        public PhieuDoiThuoc_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public PhieuDoiThuoc_C this[string MaDThuoc]
        {
            get
            {
                foreach (PhieuDoiThuoc_C obj in this)
                    if (obj.MaDThuoc.Equals(MaDThuoc))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaDThuoc)
        {
            if (!Contains(MaDThuoc))
            {
                PhieuDoiThuoc_C obj = PhieuDoiThuoc_C.NewPhieuDoiThuoc_C(MaDThuoc);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public PhieuDoiThuoc_C NewTo()
        {
           
              PhieuDoiThuoc_C obj = PhieuDoiThuoc_C.NewPhieuDoiThuoc_C();
              return obj;
               
        }
        public void NewTo(PhieuDoiThuoc_C _PhieuDoiThuoc_C)
        {
            if (!Contains(_PhieuDoiThuoc_C.Mathuoc))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _PhieuDoiThuoc_C.STT = ++_count;
                    this.Add(_PhieuDoiThuoc_C);
                }
                else
                {
                    _PhieuDoiThuoc_C.STT = 1;
                    this.Add(_PhieuDoiThuoc_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public PhieuDoiThuoc_C AssignTo(DMThuoc _DMThuoc)
        {
            if (!Contains(_DMThuoc.MaThuoc))
            {
                PhieuDoiThuoc_C obj = PhieuDoiThuoc_C.NewPhieuDoiThuoc_C(_DMThuoc.MaThuoc);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public PhieuDoiThuoc_C AssignTo(PhieuDoiThuoc_C _PhieuDoiThuoc_C)//add mot hang PhieuNhap_C
        {
            if (!Containss(_PhieuDoiThuoc_C.Mathuoc))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    _PhieuDoiThuoc_C.STT = ++_count;
                    this.Add(_PhieuDoiThuoc_C);
                }
                else
                {
                    _PhieuDoiThuoc_C.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_PhieuDoiThuoc_C);
                }
            }

            return _PhieuDoiThuoc_C;
        }

        protected override object AddNewCore()
        {
            PhieuDoiThuoc_C item = PhieuDoiThuoc_C.NewPhieuDoiThuoc_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(string MaDThuoc)
        {
            foreach (PhieuDoiThuoc_C obj in this)
            {
                if (obj.MaDThuoc.Equals(MaDThuoc))
                {
                    Remove(obj);
                    break;
                }
            }
        }

        public void RemoveTo(PhieuDoiThuoc_C obj) //xoa 1 PhieuDoiThuoc_C
        {

            Remove(obj);


        }

        public bool Contains(string MaDThuoc)
        {
            foreach (PhieuDoiThuoc_C obj in this)
                if ((obj.MaDThuoc == MaDThuoc) && (obj.Huy = false))
                    return true;
            return false;
        }
        public bool Containss(string MaThuoc)
        {
            foreach (PhieuDoiThuoc_C obj in this)
                if ((obj.MaDThuoc == MaThuoc) && (obj.Huy = false))
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaDThuoc)
        {
            foreach (PhieuDoiThuoc_C obj in DeletedList)
                if (obj.MaDThuoc == MaDThuoc)
                    return true;
            return false;
        }

        public void UpdatedTo(PhieuDoiThuoc_C _PhieuDoiThuoc_C)
        {

            _PhieuDoiThuoc_C.STT = this.Items[this.IndexOf(_PhieuDoiThuoc_C)].STT;
           this.Items[this.IndexOf(_PhieuDoiThuoc_C)] = _PhieuDoiThuoc_C;
        }
        public PhieuDoiThuoc_C GetTo(decimal STT)
        {
            foreach (PhieuDoiThuoc_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static PhieuDoiThuoc_C_List NewPhieuDoiThuoc_C_List()
        {
            return new PhieuDoiThuoc_C_List();
        }

        internal static PhieuDoiThuoc_C_List GetPhieuDoiThuoc_C_List(SafeDataReader dr)
        {
            return new PhieuDoiThuoc_C_List(dr);
        }

        private PhieuDoiThuoc_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private PhieuDoiThuoc_C_List(SafeDataReader dr)
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
                this.Add(PhieuDoiThuoc_C.GetPhieuDoiThuoc_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(PhieuDoiThuoc packet)
        {
            RaiseListChangedEvents = false;
            foreach (PhieuDoiThuoc_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (PhieuDoiThuoc_C item in this)
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