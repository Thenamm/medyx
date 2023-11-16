using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
//
using HTC.Business;
using HTC.Business.CategoryList  ;

namespace HTC.Business.CanLamSang
{
    [Serializable()]
    public class MauPhieuDTNhap_C_List : BusinessListBase<MauPhieuDTNhap_C_List, MauPhieuDTNhap_C>
    {
         #region Business Methods

        public MauPhieuDTNhap_C this[string MaDuTru]
        {
            get
            {
                foreach (MauPhieuDTNhap_C obj in this)
                    if (obj.MaDuTru.Equals(MaDuTru))
                        return obj;
                return null;
            }
        }
        public MauPhieuDTNhap_C this[decimal STT]
        {
            get
            {
                foreach (MauPhieuDTNhap_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public void NewTo(string MaDuTru)
        {
            if (!Contains(MaDuTru))
            {
                MauPhieuDTNhap_C obj = MauPhieuDTNhap_C.NewMauPhieuDTNhap_C(MaDuTru);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public MauPhieuDTNhap_C NewTo()//ham khoi tao doi tuong Phieu nhap
        {

              MauPhieuDTNhap_C obj = MauPhieuDTNhap_C.NewMauPhieuDTNhap_C();
              return obj;
               
        }
        public void NewTo(MauPhieuDTNhap_C _MauPhieuDTNhap_C) //moi sua
        {
            if (!Contains(_MauPhieuDTNhap_C.MaDuTru))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    _MauPhieuDTNhap_C.STT = ++_count;
                    this.Add(_MauPhieuDTNhap_C);
                }
                else
                {
                    _MauPhieuDTNhap_C.STT = 1;
                    this.Add(_MauPhieuDTNhap_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public MauPhieuDTNhap_C AssignTo(DMChePhamMau _DMChePhamMau)
        {
            if (!Contains(_DMChePhamMau.MaCPMau))
            {
                MauPhieuDTNhap_C obj = MauPhieuDTNhap_C.NewMauPhieuDTNhap_C(_DMChePhamMau.MaCPMau);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public MauPhieuDTNhap_C AssignTo(MauPhieuDTNhap_C _MauPhieuDTNhap_C)//add mot hang MauPhieuDTNhap_C
        {
            if (!Containss(_MauPhieuDTNhap_C.MaCPMau, _MauPhieuDTNhap_C.Huy, _MauPhieuDTNhap_C.Handung ))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    
                    _MauPhieuDTNhap_C.STT = ++_count;

                    this.Add(_MauPhieuDTNhap_C);
                }
                else
                {
                    _MauPhieuDTNhap_C.STT = 1;
                   
                    this.Add(_MauPhieuDTNhap_C);
                }
            }
           
           return _MauPhieuDTNhap_C;
        }
        protected override object AddNewCore()
        {
            MauPhieuDTNhap_C item = MauPhieuDTNhap_C.NewMauPhieuDTNhap_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void  RemoveTo(decimal stt) //xoa 1 MauPhieuDTNhap_C
        //{
           
        //    //foreach (MauPhieuDTNhap_C obj in this)
        //    //{
        //    //    if (obj.STT == stt)
        //    //    {
        //    //        this.Items.RemoveAt(this.IndexOf(obj));
        //    //        break; 
                   
        //    //    }
        //    //}
        //    //MauPhieuDTNhap_C obj;
        //    for(int i = 0;i < this.Items.Count ;i ++ )
        //    {
        //       // obj = this.Items[i];
        //        if (this.Items[i].STT == stt)
        //        {
        //            this.Items.RemoveAt(i);
        //            break;

        //        }
        //    }
        //}
        public void RemoveTo(MauPhieuDTNhap_C obj) //xoa 1 MauPhieuDTNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);
                   
        }
        public bool Contains(string MaDuTru)
        {
            foreach (MauPhieuDTNhap_C obj in this)
                if ((obj.MaDuTru == MaDuTru) && (obj.Huy = false))
                    return true;
            return false;
        }
        //public bool Containss(string MaCPMau)
        //{
        //    foreach (MauPhieuDTNhap_C obj in this)
        //        if ((obj.MaCPMau == MaCPMau) && (obj.Huy = false))
        //            return true;
        //    return false;
        //}
        //public bool Containss(string MaCPMau)
        //{
        //    foreach (MauPhieuDTNhap_C obj in this)
        //        if (obj.MaCPMau == MaCPMau) 
        //            return true;
        //    return false;
        //}
        public bool Containss(string MaCPMau, Boolean Huy,bool hansd)
        {
            foreach (MauPhieuDTNhap_C obj in this)
                if ((obj.MaCPMau == MaCPMau) && (obj.Huy == Huy) && (obj.Handung  == hansd))
                    return true;
            return false;
        }


        public bool ContainsDeleted(string MaDuTru)
        {
            foreach (MauPhieuDTNhap_C obj in DeletedList)
                if (obj.MaDuTru == MaDuTru)
                    return true;
            return false;
        }
        public void UpdatedTo(MauPhieuDTNhap_C _MauPhieuDTNhap_C)
        {

            _MauPhieuDTNhap_C.STT = this.Items[this.IndexOf(_MauPhieuDTNhap_C)].STT;
            this.Items[this.IndexOf(_MauPhieuDTNhap_C)] = _MauPhieuDTNhap_C;
        }
        public MauPhieuDTNhap_C GetTo(decimal STT) //
        {
            foreach (MauPhieuDTNhap_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static MauPhieuDTNhap_C_List NewMauPhieuDTNhap_C_List()
        {
            return new MauPhieuDTNhap_C_List();
        }

        internal static MauPhieuDTNhap_C_List GetMauPhieuDTNhap_C_List(SafeDataReader dr)
        {
            return new MauPhieuDTNhap_C_List(dr);
        }

        private MauPhieuDTNhap_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private MauPhieuDTNhap_C_List(SafeDataReader dr)
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
                
                this.Add(MauPhieuDTNhap_C.GetMauPhieuDTNhap_C(dr));/////////
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(MauPhieuDTNhap packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (MauPhieuDTNhap_C item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (MauPhieuDTNhap_C item in this)
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
