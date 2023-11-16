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
    public class NKKiemKe_C_List : BusinessListBase<NKKiemKe_C_List, NKKiemKe_C>
    {
        #region Business Methods

        public NKKiemKe_C this[decimal stt]
        {
            get
            {
                foreach (NKKiemKe_C obj in this)
                    if (obj.OrderNumber == stt)
                        return obj;

                return null;
            }
        }

        public void NewTo(string MaKK)
        {
            if (!Contains(MaKK))
            {
                NKKiemKe_C obj = NKKiemKe_C.NewNKKiemKe_C(MaKK);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public NKKiemKe_C NewTo()
        {
           
              NKKiemKe_C obj = NKKiemKe_C.NewNKKiemKe_C();
              return obj;
               
        }
        public void NewTo(NKKiemKe_C _NKKiemKe_C)
        {
            if (!Contains(_NKKiemKe_C.MaVT))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _NKKiemKe_C.STT = ++_count;
                    this.Add(_NKKiemKe_C);
                }
                else
                {
                    _NKKiemKe_C.STT = 1;
                    this.Add(_NKKiemKe_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public NKKiemKe_C AssignTo(DMCNK _DMCNK)
        {
            if (!Contains(_DMCNK.MaVT))
            {
                NKKiemKe_C obj = NKKiemKe_C.NewNKKiemKe_C(_DMCNK.MaVT);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public NKKiemKe_C AssignTo(NKKiemKe_C _NKKiemKe_C)//add mot hang PhieuNhap_C
        {
            if (!Containss(_NKKiemKe_C.MaVT, _NKKiemKe_C.Huy))
            {
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    decimal _count1 = 0;
                   
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    if ((decimal)this.Items.Count > 0)
                    {
                        _count1 = this[(decimal)this.Items.Count].STT;
                        _count = this[(decimal)this.Items.Count].OrderNumber;
                    }
                    _NKKiemKe_C.OrderNumber = ++_count;
                    _NKKiemKe_C.STT = ++_count1;
                    this.Add(_NKKiemKe_C);
                }
                else
                {
                    _NKKiemKe_C.OrderNumber = 1;
                    _NKKiemKe_C.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_NKKiemKe_C);
                }
            }

            return _NKKiemKe_C;
        }

        protected override object AddNewCore()
        {
            NKKiemKe_C item = NKKiemKe_C.NewNKKiemKe_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void RemoveTo(string MaKK)
        //{
        //    foreach (NKKiemKe_C obj in this)
        //    {
        //        if (obj.MaKK.Equals(MaKK))
        //        {
        //            Remove(obj);
        //            break;
        //        }
        //    }
        //}
        //public void RemoveTo(NKKiemKe_C obj)
        //{
        //    this.Items.Remove(obj);

        //}
       
        public void RemoveTo(NKKiemKe_C obj) //xoa 1 PhieuNhap_C
        {
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);
            //this.Items.Remove(obj);
        }

        public bool Contains(string MaKK)
        {
            foreach (NKKiemKe_C obj in this)
                if ((obj.MaKK == MaKK) && (obj.Huy = false))
                    return true;
            return false;
        }
        public bool Containss(string MaVT, Boolean Huy)
        {
            foreach (NKKiemKe_C obj in this)
                if ((obj.MaVT == MaVT) && (obj.Huy == Huy))
                    return true;
            return false;
        }
        public NKKiemKe_C Containsss(string MaVT, Boolean Huy)
        {
            foreach (NKKiemKe_C obj in this)
                if ((obj.MaVT == MaVT) && (obj.Huy == Huy))
                    return obj;
            return null;
        }


        public bool ContainsDeleted(string MaKK)
        {
            foreach (NKKiemKe_C obj in DeletedList)
                if (obj.MaKK == MaKK)
                    return true;
            return false;
        }

        public void UpdatedTo(NKKiemKe_C _NKKiemKe_C)
        {

            _NKKiemKe_C.STT = this.Items[this.IndexOf(_NKKiemKe_C)].STT;
           this.Items[this.IndexOf(_NKKiemKe_C)] = _NKKiemKe_C;
        }
        public NKKiemKe_C GetTo(decimal STT)
        {
            foreach (NKKiemKe_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static NKKiemKe_C_List NewNKKiemKe_C_List()
        {
            return new NKKiemKe_C_List();
        }

        internal static NKKiemKe_C_List GetNKKiemKe_C_List(SafeDataReader dr)
        {
            return new NKKiemKe_C_List(dr);
        }

        private NKKiemKe_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private NKKiemKe_C_List(SafeDataReader dr)
        {
            this.AllowNew = true;
            MarkAsChild();
            Fetch(dr);
        }

        #endregion

        #region Data Access

        private void Fetch(SafeDataReader dr)
        {
            int i = 1;
            RaiseListChangedEvents = false;
            while (dr.Read())
            {
                this.Add(NKKiemKe_C.GetNKKiemKe_C(dr,i));
                i++;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(NKKiemKe packet)
        {
            RaiseListChangedEvents = false;
            foreach (NKKiemKe_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (NKKiemKe_C item in this)
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