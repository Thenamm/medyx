using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
////
using HTC.Business;
using HTC.Business.CategoryList  ;

namespace HTC.Business.TBYT
{
    [Serializable()]
    public class LKPhieuNhap_Cs : BusinessListBase<LKPhieuNhap_Cs, LKPhieuNhap_C>
    {
         #region Business Methods
        public LKPhieuNhap_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public LKPhieuNhap_C this[string MaPN]
        {
            get
            {
                foreach (LKPhieuNhap_C obj in this)
                    if (obj.MaPN.Equals(MaPN))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaPN)
        {
            if (!Contains(MaPN))
            {
                LKPhieuNhap_C obj = LKPhieuNhap_C.NewLKPhieuNhap_C(MaPN);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public LKPhieuNhap_C NewTo()//ham khoi tao doi tuong Phieu nhap
        {

              LKPhieuNhap_C obj = LKPhieuNhap_C.NewLKPhieuNhap_C();
              return obj;
               
        }
        public void NewTo(LKPhieuNhap_C _LKPhieuNhap_C) //moi sua
        {
            if (!Contains(_LKPhieuNhap_C.MaPN))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    _LKPhieuNhap_C.STT = ++_count;
                    this.Add(_LKPhieuNhap_C);
                }
                else
                {
                    _LKPhieuNhap_C.STT = 1;
                    this.Add(_LKPhieuNhap_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public LKPhieuNhap_C AssignTo(DMTBYT _DMTBYT)
        {
            if (!Contains(_DMTBYT.MaTB))
            {
                LKPhieuNhap_C obj = LKPhieuNhap_C.NewLKPhieuNhap_C(_DMTBYT.MaTB);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public LKPhieuNhap_C AssignTo(LKPhieuNhap_C _LKPhieuNhap_C)//add mot hang LKPhieuNhap_C
        {
            if (!Containss(_LKPhieuNhap_C.MaLK, _LKPhieuNhap_C.Huy, _LKPhieuNhap_C.SoLo, _LKPhieuNhap_C.HanSD ))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                  
                    _LKPhieuNhap_C.STT = ++_count;

                    this.Add(_LKPhieuNhap_C);
                }
                else
                {
                    _LKPhieuNhap_C.STT = 1;
                   
                    this.Add(_LKPhieuNhap_C);
                }
            }
           
           return _LKPhieuNhap_C;
        }
        protected override object AddNewCore()
        {
            LKPhieuNhap_C item = LKPhieuNhap_C.NewLKPhieuNhap_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void  RemoveTo(decimal stt) //xoa 1 LKPhieuNhap_C
        //{
           
        //    //foreach (LKPhieuNhap_C obj in this)
        //    //{
        //    //    if (obj.STT == stt)
        //    //    {
        //    //        this.Items.RemoveAt(this.IndexOf(obj));
        //    //        break; 
                   
        //    //    }
        //    //}
        //    //LKPhieuNhap_C obj;
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
        //public void RemoveTo(LKPhieuNhap_C obj) //xoa 1 LKPhieuNhap_C
        //{

        //    Remove(obj); 
                  
                   
        //}
        public void RemoveTo(LKPhieuNhap_C obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public bool Contains(string MaPN)
        {
            foreach (LKPhieuNhap_C obj in this)
                if ((obj.MaPN == MaPN) && (obj.Huy = false))
                    return true;
            return false;
        }
        //public bool Containss(string MaLK)
        //{
        //    foreach (LKPhieuNhap_C obj in this)
        //        if ((obj.MaLK == MaLK) && (obj.Huy = false))
        //            return true;
        //    return false;
        //}
        //public bool Containss(string MaLK)
        //{
        //    foreach (LKPhieuNhap_C obj in this)
        //        if (obj.MaLK == MaLK) 
        //            return true;
        //    return false;
        //}
        public bool Containss(string MaLK, Boolean Huy, string solo, string hansd)
        {
            //foreach (LKPhieuNhap_C obj in this)
            //    if ((obj.MaLK == MaLK) && (obj.Huy == Huy) && (obj.SoLo  == solo) && (obj.HanSD  == hansd))
            //        return true;
            return false;
        }


        public bool ContainsDeleted(string MaPN)
        {
            foreach (LKPhieuNhap_C obj in DeletedList)
                if (obj.MaPN == MaPN)
                    return true;
            return false;
        }
        public void UpdatedTo(LKPhieuNhap_C _LKPhieuNhap_C)
        {

            _LKPhieuNhap_C.STT = this.Items[this.IndexOf(_LKPhieuNhap_C)].STT;
            this.Items[this.IndexOf(_LKPhieuNhap_C)] = _LKPhieuNhap_C;
        }
        public LKPhieuNhap_C GetTo(decimal STT) //
        {
            foreach (LKPhieuNhap_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static LKPhieuNhap_Cs NewLKPhieuNhap_Cs()
        {
            return new LKPhieuNhap_Cs();
        }

        internal static LKPhieuNhap_Cs GetLKPhieuNhap_Cs(SafeDataReader dr)
        {
            return new LKPhieuNhap_Cs(dr);
        }

        private LKPhieuNhap_Cs()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private LKPhieuNhap_Cs(SafeDataReader dr)
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
                
                this.Add(LKPhieuNhap_C.GetLKPhieuNhap_C(dr));/////////
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(LKPhieuNhap packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (LKPhieuNhap_C item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (LKPhieuNhap_C item in this)
            {
                if ((item.IsNew))// && item.MaPN == "")   //MaPN ==""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
   
    }
}
