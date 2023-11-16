using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
//
using HTC.Business;
using HTC.Business.CategoryList  ;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class PhacDoDT_Cs : BusinessListBase<PhacDoDT_Cs, PhacDoDT_C>
    {
         #region Business Methods
        public PhacDoDT_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public PhacDoDT_C this[string MaPD]
        {
            get
            {
                foreach (PhacDoDT_C obj in this)
                    if (obj.MaPD.Equals(MaPD))
                        return obj;
                return null;
            }
        }
        public PhacDoDT_C this[decimal STT]
        {
            get
            {
                foreach (PhacDoDT_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
       
        public void NewTo(string MaPD)
        {
            if (!Contains(MaPD))
            {
                PhacDoDT_C obj = PhacDoDT_C.NewPhacDoDT_C(MaPD);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public PhacDoDT_C NewTo()//ham khoi tao doi tuong Phieu nhap
        {

              PhacDoDT_C obj = PhacDoDT_C.NewPhacDoDT_C();
              return obj;
               
        }
        public void NewTo(PhacDoDT_C _PhacDoDT_C) //moi sua
        {
            if (!Contains(_PhacDoDT_C.MaPD))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    _PhacDoDT_C.STT = ++_count;
                    this.Add(_PhacDoDT_C);
                }
                else
                {
                    _PhacDoDT_C.STT = 1;
                    this.Add(_PhacDoDT_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public PhacDoDT_C AssignTo(DMThuoc _DMThuoc)
        {
            if (!Contains(_DMThuoc.MaThuoc))
            {
                PhacDoDT_C obj = PhacDoDT_C.NewPhacDoDT_C(_DMThuoc.MaThuoc);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public PhacDoDT_C AssignTo(PhacDoDT_C _PhacDoDT_C)//add mot hang PhacDoDT_C
        {
            if (!Containss(_PhacDoDT_C.MaThuoc, _PhacDoDT_C.Huy ))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                 
                    _PhacDoDT_C.STT = ++_count;

                    this.Add(_PhacDoDT_C);
                }
                else
                {
                    _PhacDoDT_C.STT = 1;
                   
                    this.Add(_PhacDoDT_C);
                }
            }
           
           return _PhacDoDT_C;
        }
        protected override object AddNewCore()
        {
            PhacDoDT_C item = PhacDoDT_C.NewPhacDoDT_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void  RemoveTo(decimal stt) //xoa 1 PhacDoDT_C
        //{
           
        //    //foreach (PhacDoDT_C obj in this)
        //    //{
        //    //    if (obj.STT == stt)
        //    //    {
        //    //        this.Items.RemoveAt(this.IndexOf(obj));
        //    //        break; 
                   
        //    //    }
        //    //}
        //    //PhacDoDT_C obj;
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
        public void RemoveTo(PhacDoDT_C obj) //xoa 1 PhacDoDT_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);
                   
        }
        public bool Contains(string MaPD)
        {
            foreach (PhacDoDT_C obj in this)
                if ((obj.MaPD == MaPD) && (obj.Huy = false))
                    return true;
            return false;
        }
        //public bool Containss(string MaThuoc)
        //{
        //    foreach (PhacDoDT_C obj in this)
        //        if ((obj.MaThuoc == MaThuoc) && (obj.Huy = false))
        //            return true;
        //    return false;
        //}
        //public bool Containss(string MaThuoc)
        //{
        //    foreach (PhacDoDT_C obj in this)
        //        if (obj.MaThuoc == MaThuoc) 
        //            return true;
        //    return false;
        //}
        public bool Containss(string MaThuoc, Boolean Huy)
        {
            foreach (PhacDoDT_C obj in this)
                if ((obj.MaThuoc == MaThuoc) && (obj.Huy == Huy))
                    return true;
            return false;
            
        }


        public bool ContainsDeleted(string MaPD)
        {
            foreach (PhacDoDT_C obj in DeletedList)
                if (obj.MaPD == MaPD)
                    return true;
            return false;
        }
        public void UpdatedTo(PhacDoDT_C _PhacDoDT_C)
        {

            _PhacDoDT_C.STT = this.Items[this.IndexOf(_PhacDoDT_C)].STT;
            this.Items[this.IndexOf(_PhacDoDT_C)] = _PhacDoDT_C;
        }
        public PhacDoDT_C GetTo(decimal STT) //
        {
            foreach (PhacDoDT_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static PhacDoDT_Cs NewPhacDoDT_Cs()
        {
            return new PhacDoDT_Cs();
        }

        internal static PhacDoDT_Cs GetPhacDoDT_Cs(SafeDataReader dr)
        {
            return new PhacDoDT_Cs(dr);
        }

        private PhacDoDT_Cs()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private PhacDoDT_Cs(SafeDataReader dr)
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
                
                this.Add(PhacDoDT_C.GetPhacDoDT_C(dr));/////////
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(PhacDoDT packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (PhacDoDT_C item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (PhacDoDT_C item in this)
            {
                if ((item.IsNew))// && item.MaPD ==""  )   //MaPD  == ""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
    
        #endregion
   
    }
}
