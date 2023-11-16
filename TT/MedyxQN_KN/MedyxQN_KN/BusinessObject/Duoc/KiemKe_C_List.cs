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
    public class KiemKe_C_List : BusinessListBase<KiemKe_C_List, KiemKe_C>
    {
        private KiemKe_C obj;
        #region Business Methods
        public KiemKe_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public KiemKe_C this[decimal stt]
        {
            get
            {
                foreach (KiemKe_C obj in this)
                    if (obj.OrderNumber == stt)
                        return obj;

                return null;
            }
        }

        public void NewTo(string MaKK)
        {
            if (!Contains(MaKK))
            {
                KiemKe_C obj = KiemKe_C.NewKiemKe_C(MaKK);
                decimal _count = 0;
                if ((decimal)this.Items.Count >0)
                _count = this[(decimal)this.Items.Count-1].STT;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public KiemKe_C NewTo()
        {
           
              KiemKe_C obj = KiemKe_C.NewKiemKe_C();
              return obj;
               
        }
        public void NewTo(KiemKe_C _KiemKe_C)
        {
            if (!Contains(_KiemKe_C.MaThuoc))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _KiemKe_C.STT = ++_count;
                    this.Add(_KiemKe_C);
                }
                else
                {
                    _KiemKe_C.STT = 1;
                    this.Add(_KiemKe_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public KiemKe_C AssignTo(DMThuoc _DMThuoc)
        {
            if (!Contains(_DMThuoc.MaThuoc))
            {
                KiemKe_C obj = KiemKe_C.NewKiemKe_C(_DMThuoc.MaThuoc);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public KiemKe_C AssignTo(KiemKe_C _KiemKe_C)//add mot hang PhieuNhap_C
        {
            if (!Containss(_KiemKe_C.MaThuoc, _KiemKe_C.Huy))
            {
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    decimal _count1 = 0;
                    
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    if ((decimal)this.Items.Count > 0)
                    {
                        _count1 = this[(decimal)this.Items.Count ].STT;
                        _count = this[(decimal)this.Items.Count ].OrderNumber;
                    }
                    _KiemKe_C.OrderNumber = ++_count;
                    _KiemKe_C.STT = ++_count1;
                    this.Add(_KiemKe_C);
                }
                else
                {
                    _KiemKe_C.OrderNumber = 1;
                    _KiemKe_C.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_KiemKe_C);
                }
            }

            return _KiemKe_C;
        }

        protected override object AddNewCore()
        {
            KiemKe_C item = KiemKe_C.NewKiemKe_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void RemoveTo(string MaKK)
        //{
        //    foreach (KiemKe_C obj in this)
        //    {
        //        if (obj.MaKK.Equals(MaKK))
        //        {
        //            Remove(obj);
        //            break;
        //        }
        //    }
        //}
        //public void RemoveTo(KiemKe_C obj)
        //{
        //    this.Items.Remove(obj);

        //}
       
        public void RemoveTo(KiemKe_C obj) //xoa 1 PhieuNhap_C
        {
            if (obj.IsNew == true)
            {
                this.Items.Remove(obj);
                //obj.SoLuong = 0;
            }
            else
            {
                Remove(obj);
                //obj.SoLuong = 0;
            }
            //this.Items.Remove(obj);
        }

        public bool Contains(string MaKK)
        {
            foreach (KiemKe_C obj in this)
                if ((obj.MaKK == MaKK) && (obj.Huy = false))
                    return true;
            return false;
        }
        public bool Containss(string MaThuoc, Boolean Huy)
        {
            foreach (KiemKe_C obj in this)
                if ((obj.MaThuoc == MaThuoc) && (obj.Huy == Huy))
                    return true;
            return false;
        }
        public KiemKe_C  ContainsMa(string MaThuoc, Boolean Huy)
        {
            foreach (KiemKe_C obj in this)
                if ((obj.MaThuoc == MaThuoc) && (obj.Huy == Huy))
                    return obj;
            return null;
        }


        public bool ContainsDeleted(string MaKK)
        {
            foreach (KiemKe_C obj in DeletedList)
                if (obj.MaKK == MaKK)
                    return true;
            return false;
        }

        public void UpdatedTo(KiemKe_C _KiemKe_C)
        {

            _KiemKe_C.STT = this.Items[this.IndexOf(_KiemKe_C)].STT;
           this.Items[this.IndexOf(_KiemKe_C)] = _KiemKe_C;
        }
        public KiemKe_C GetTo(decimal STT)
        {
            foreach (KiemKe_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static KiemKe_C_List NewKiemKe_C_List()
        {
            return new KiemKe_C_List();
        }

        internal static KiemKe_C_List GetKiemKe_C_List(SafeDataReader dr)
        {
            return new KiemKe_C_List(dr);
        }

        private KiemKe_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private KiemKe_C_List(SafeDataReader dr)
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
                this.Add(KiemKe_C.GetKiemKe_C(dr, i));
                i++;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(KiemKe packet)
        {
            RaiseListChangedEvents = false;
            foreach (KiemKe_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (KiemKe_C item in this)
            {
                if ((item.IsNew))// && packet.MaKK =="")
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(KiemKeDT packet)
        {
            RaiseListChangedEvents = false;
            foreach (KiemKe_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (KiemKe_C item in this)
            {
                if ((item.IsNew)) // && item.MaKK == "")   //MaKK ==""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

       

        #endregion
    }
}