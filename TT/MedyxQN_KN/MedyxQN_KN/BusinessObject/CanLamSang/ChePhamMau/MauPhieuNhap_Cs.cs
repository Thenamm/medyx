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
    public class MauPhieuNhap_Cs : BusinessListBase<MauPhieuNhap_Cs, MauPhieuNhap_C>
    {
         #region Business Methods

        public MauPhieuNhap_C this[string MaPN]
        {
            get
            {
                foreach (MauPhieuNhap_C obj in this)
                    if (obj.MaPN.Equals(MaPN))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaPN)
        {
            if (!Contains(MaPN))
            {
                MauPhieuNhap_C obj = MauPhieuNhap_C.NewMauPhieuNhap_C(MaPN);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public MauPhieuNhap_C NewTo()//ham khoi tao doi tuong Phieu nhap
        {

              MauPhieuNhap_C obj = MauPhieuNhap_C.NewMauPhieuNhap_C();
              return obj;
               
        }
        public void NewTo(MauPhieuNhap_C _MauPhieuNhap_C) //moi sua
        {
            if (!Contains(_MauPhieuNhap_C.MaPN))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    _MauPhieuNhap_C.STT = ++_count;
                    this.Add(_MauPhieuNhap_C);
                }
                else
                {
                    _MauPhieuNhap_C.STT = 1;
                    this.Add(_MauPhieuNhap_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public MauPhieuNhap_C AssignTo(DMChePhamMau _DMChePhamMau)
        {
            if (!Contains(_DMChePhamMau.MaCPMau))
            {
                MauPhieuNhap_C obj = MauPhieuNhap_C.NewMauPhieuNhap_C(_DMChePhamMau.MaCPMau);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public MauPhieuNhap_C AssignTo(MauPhieuNhap_C _MauPhieuNhap_C)//add mot hang MauPhieuNhap_C
        {
            if (!Containss(_MauPhieuNhap_C.MaCPMau, _MauPhieuNhap_C.Huy, _MauPhieuNhap_C.SoLo, _MauPhieuNhap_C.HanSD ))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                 
                    _MauPhieuNhap_C.STT = ++_count;

                    this.Add(_MauPhieuNhap_C);
                }
                else
                {
                    _MauPhieuNhap_C.STT = 1;
                 
                    this.Add(_MauPhieuNhap_C);
                }
            }
           
           return _MauPhieuNhap_C;
        }
        protected override object AddNewCore()
        {
            MauPhieuNhap_C item = MauPhieuNhap_C.NewMauPhieuNhap_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void  RemoveTo(decimal stt) //xoa 1 MauPhieuNhap_C
        //{
           
        //    //foreach (MauPhieuNhap_C obj in this)
        //    //{
        //    //    if (obj.STT == stt)
        //    //    {
        //    //        this.Items.RemoveAt(this.IndexOf(obj));
        //    //        break; 
                   
        //    //    }
        //    //}
        //    //MauPhieuNhap_C obj;
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
        //public void RemoveTo(MauPhieuNhap_C obj) //xoa 1 MauPhieuNhap_C
        //{

        //    Remove(obj); 
                  
                   
        //}
        public void RemoveTo(MauPhieuNhap_C obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public bool Contains(string MaPN)
        {
            foreach (MauPhieuNhap_C obj in this)
                if ((obj.MaPN == MaPN) && (obj.Huy = false))
                    return true;
            return false;
        }
        //public bool Containss(string MaCPMau)
        //{
        //    foreach (MauPhieuNhap_C obj in this)
        //        if ((obj.MaCPMau == MaCPMau) && (obj.Huy = false))
        //            return true;
        //    return false;
        //}
        //public bool Containss(string MaCPMau)
        //{
        //    foreach (MauPhieuNhap_C obj in this)
        //        if (obj.MaCPMau == MaCPMau) 
        //            return true;
        //    return false;
        //}
        public bool Containss(string MaCPMau, Boolean Huy, string solo, string hansd)
        {
            foreach (MauPhieuNhap_C obj in this)
                if ((obj.MaCPMau == MaCPMau) && (obj.Huy == Huy) && (obj.SoLo  == solo) && (obj.HanSD  == hansd))
                    return true;
            return false;
        }


        public bool ContainsDeleted(string MaPN)
        {
            foreach (MauPhieuNhap_C obj in DeletedList)
                if (obj.MaPN == MaPN)
                    return true;
            return false;
        }
        public void UpdatedTo(MauPhieuNhap_C _MauPhieuNhap_C)
        {

            _MauPhieuNhap_C.STT = this.Items[this.IndexOf(_MauPhieuNhap_C)].STT;
            this.Items[this.IndexOf(_MauPhieuNhap_C)] = _MauPhieuNhap_C;
        }
        public MauPhieuNhap_C GetTo(decimal STT) //
        {
            foreach (MauPhieuNhap_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static MauPhieuNhap_Cs NewMauPhieuNhap_Cs()
        {
            return new MauPhieuNhap_Cs();
        }

        internal static MauPhieuNhap_Cs GetMauPhieuNhap_Cs(SafeDataReader dr)
        {
            return new MauPhieuNhap_Cs(dr);
        }

        private MauPhieuNhap_Cs()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private MauPhieuNhap_Cs(SafeDataReader dr)
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
                
                this.Add(MauPhieuNhap_C.GetMauPhieuNhap_C(dr));/////////
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(MauPhieuNhap packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (MauPhieuNhap_C item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (MauPhieuNhap_C item in this)
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
