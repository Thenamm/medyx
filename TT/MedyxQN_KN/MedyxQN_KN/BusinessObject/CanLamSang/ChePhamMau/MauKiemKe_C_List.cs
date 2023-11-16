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
    public class MauKiemKe_C_List : BusinessListBase<MauKiemKe_C_List, MauKiemKe_C>
    {
        #region Business Methods

        public MauKiemKe_C this[decimal stt]
        {
            get
            {
                foreach (MauKiemKe_C obj in this)
                    if (obj.OrderNumber == stt)
                        return obj;

                return null;
            }
        }

        public void NewTo(string MaKK)
        {
            if (!Contains(MaKK))
            {
                MauKiemKe_C obj = MauKiemKe_C.NewMauKiemKe_C(MaKK);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public MauKiemKe_C NewTo()
        {
           
              MauKiemKe_C obj = MauKiemKe_C.NewMauKiemKe_C();
              return obj;
               
        }
        public void NewTo(MauKiemKe_C _MauKiemKe_C)
        {
            if (!Contains(_MauKiemKe_C.MaCPMau))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _MauKiemKe_C.STT = ++_count;
                    this.Add(_MauKiemKe_C);
                }
                else
                {
                    _MauKiemKe_C.STT = 1;
                    this.Add(_MauKiemKe_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public MauKiemKe_C AssignTo(DMChePhamMau _DMChePhamMau)
        {
            if (!Contains(_DMChePhamMau.MaCPMau))
            {
                MauKiemKe_C obj = MauKiemKe_C.NewMauKiemKe_C(_DMChePhamMau.MaCPMau);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public MauKiemKe_C AssignTo(MauKiemKe_C _MauKiemKe_C)//add mot hang PhieuNhap_C
        {
            if (!Containss(_MauKiemKe_C.MaCPMau, _MauKiemKe_C.Huy))
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
                    _MauKiemKe_C.OrderNumber = ++_count;
                    _MauKiemKe_C.STT = ++_count1;
                    this.Add(_MauKiemKe_C);
                }
                else
                {
                    _MauKiemKe_C.OrderNumber = 1;
                    _MauKiemKe_C.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_MauKiemKe_C);
                }
            }

            return _MauKiemKe_C;
        }

        protected override object AddNewCore()
        {
            MauKiemKe_C item = MauKiemKe_C.NewMauKiemKe_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void RemoveTo(string MaKK)
        //{
        //    foreach (MauKiemKe_C obj in this)
        //    {
        //        if (obj.MaKK.Equals(MaKK))
        //        {
        //            Remove(obj);
        //            break;
        //        }
        //    }
        //}
        //public void RemoveTo(MauKiemKe_C obj)
        //{
        //    this.Items.Remove(obj);

        //}
       
        public void RemoveTo(MauKiemKe_C obj) //xoa 1 PhieuNhap_C
        {
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);
            //this.Items.Remove(obj);
        }

        public bool Contains(string MaKK)
        {
            foreach (MauKiemKe_C obj in this)
                if ((obj.MaKK == MaKK) && (obj.Huy = false))
                    return true;
            return false;
        }
        public bool Containss(string MaCPMau, Boolean Huy)
        {
            foreach (MauKiemKe_C obj in this)
                if ((obj.MaCPMau == MaCPMau) && (obj.Huy == Huy))
                    return true;
            return false;
        }
        


        public bool ContainsDeleted(string MaKK)
        {
            foreach (MauKiemKe_C obj in DeletedList)
                if (obj.MaKK == MaKK)
                    return true;
            return false;
        }

        public void UpdatedTo(MauKiemKe_C _MauKiemKe_C)
        {

            _MauKiemKe_C.STT = this.Items[this.IndexOf(_MauKiemKe_C)].STT;
           this.Items[this.IndexOf(_MauKiemKe_C)] = _MauKiemKe_C;
        }
        public MauKiemKe_C GetTo(decimal STT)
        {
            foreach (MauKiemKe_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static MauKiemKe_C_List NewMauKiemKe_C_List()
        {
            return new MauKiemKe_C_List();
        }

        internal static MauKiemKe_C_List GetMauKiemKe_C_List(SafeDataReader dr)
        {
            return new MauKiemKe_C_List(dr);
        }

        private MauKiemKe_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private MauKiemKe_C_List(SafeDataReader dr)
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
                this.Add(MauKiemKe_C.GetMauKiemKe_C(dr,i));
                i++;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(MauKiemKe packet)
        {
            RaiseListChangedEvents = false;
            foreach (MauKiemKe_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (MauKiemKe_C item in this)
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