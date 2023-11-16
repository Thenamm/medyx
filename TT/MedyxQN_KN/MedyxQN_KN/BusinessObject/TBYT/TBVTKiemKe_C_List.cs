using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;
////
using HTC.Business.CategoryList;

namespace HTC.Business.TBYT
{
    [Serializable()]
    public class TBVTKiemKe_C_List : BusinessListBase<TBVTKiemKe_C_List, TBVTKiemKe_C>
    {
        #region Business Methods

        public TBVTKiemKe_C this[decimal stt]
        {
            get
            {
                foreach (TBVTKiemKe_C obj in this)
                    if (obj.OrderNumber == stt)
                        return obj;

                return null;
            }
        }

        public void NewTo(string MaKK)
        {
            if (!Contains(MaKK))
            {
                TBVTKiemKe_C obj = TBVTKiemKe_C.NewTBVTKiemKe_C(MaKK);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public TBVTKiemKe_C NewTo()
        {

            TBVTKiemKe_C obj = TBVTKiemKe_C.NewTBVTKiemKe_C();
            return obj;

        }
        public void NewTo(TBVTKiemKe_C _TBVTKiemKe_C)
        {
            if (!Contains(_TBVTKiemKe_C.MaVT))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    _TBVTKiemKe_C.STT = ++_count;
                    this.Add(_TBVTKiemKe_C);
                }
                else
                {
                    _TBVTKiemKe_C.STT = 1;
                    this.Add(_TBVTKiemKe_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public TBVTKiemKe_C AssignTo(DMTBVTYT _DMTBVTYT)
        {
            if (!Contains(_DMTBVTYT.MaVT))
            {
                TBVTKiemKe_C obj = TBVTKiemKe_C.NewTBVTKiemKe_C(_DMTBVTYT.MaVT);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public TBVTKiemKe_C AssignTo(TBVTKiemKe_C _TBVTKiemKe_C)//add mot hang PhieuNhap_C
        {
            if (!Containss(_TBVTKiemKe_C.MaVT, _TBVTKiemKe_C.Huy))
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
                    _TBVTKiemKe_C.OrderNumber = ++_count;
                    _TBVTKiemKe_C.STT = ++_count1;
                    this.Add(_TBVTKiemKe_C);
                }
                else
                {
                    _TBVTKiemKe_C.OrderNumber = 1;
                    _TBVTKiemKe_C.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_TBVTKiemKe_C);
                }
            }

            return _TBVTKiemKe_C;
        }

        protected override object AddNewCore()
        {
            TBVTKiemKe_C item = TBVTKiemKe_C.NewTBVTKiemKe_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void RemoveTo(string MaKK)
        //{
        //    foreach (TBVTKiemKe_C obj in this)
        //    {
        //        if (obj.MaKK.Equals(MaKK))
        //        {
        //            Remove(obj);
        //            break;
        //        }
        //    }
        //}
        //public void RemoveTo(TBVTKiemKe_C obj)
        //{
        //    this.Items.Remove(obj);

        //}

        public void RemoveTo(TBVTKiemKe_C obj) //xoa 1 PhieuNhap_C
        {
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);
            //this.Items.Remove(obj);
        }

        public bool Contains(string MaKK)
        {
            foreach (TBVTKiemKe_C obj in this)
                if ((obj.MaKK == MaKK) && (obj.Huy = false))
                    return true;
            return false;
        }
        public bool Containss(string MaVT, Boolean Huy)
        {
            foreach (TBVTKiemKe_C obj in this)
                if ((obj.MaVT == MaVT) && (obj.Huy == Huy))
                    return true;
            return false;
        }
        public TBVTKiemKe_C ContainsMa(string MaVT, Boolean Huy)
        {
            foreach (TBVTKiemKe_C obj in this)
                if ((obj.MaVT == MaVT) && (obj.Huy == Huy))
                    return obj;
            return null;
        }


        public bool ContainsDeleted(string MaKK)
        {
            foreach (TBVTKiemKe_C obj in DeletedList)
                if (obj.MaKK == MaKK)
                    return true;
            return false;
        }

        public void UpdatedTo(TBVTKiemKe_C _TBVTKiemKe_C)
        {

            _TBVTKiemKe_C.STT = this.Items[this.IndexOf(_TBVTKiemKe_C)].STT;
            this.Items[this.IndexOf(_TBVTKiemKe_C)] = _TBVTKiemKe_C;
        }
        public TBVTKiemKe_C GetTo(decimal STT)
        {
            foreach (TBVTKiemKe_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        #endregion

        #region Factory Methods

        internal static TBVTKiemKe_C_List NewTBVTKiemKe_C_List()
        {
            return new TBVTKiemKe_C_List();
        }

        internal static TBVTKiemKe_C_List GetTBVTKiemKe_C_List(SafeDataReader dr)
        {
            return new TBVTKiemKe_C_List(dr);
        }

        private TBVTKiemKe_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private TBVTKiemKe_C_List(SafeDataReader dr)
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
                this.Add(TBVTKiemKe_C.GetTBVTKiemKe_C(dr, i));
                i++;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(TBVTKiemKe packet)
        {
            RaiseListChangedEvents = false;
            foreach (TBVTKiemKe_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (TBVTKiemKe_C item in this)
            {
                if (item.IsNew == true )//&& item.MaKK == "")
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }




        #endregion
    }
}