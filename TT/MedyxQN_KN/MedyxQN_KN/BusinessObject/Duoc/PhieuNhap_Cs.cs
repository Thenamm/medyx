using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
////
using HTC.Business.CategoryList;
//using System.Windows.Forms;

namespace HTC.Business.Duoc
{
    [Serializable()]
    public class PhieuNhap_Cs : BusinessListBase<PhieuNhap_Cs, PhieuNhap_C>
    {

        #region Business Methods
      
       
        public PhieuNhap_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
       
          public PhieuNhap_C this[string MaPN]
        {
            get
            {
                foreach (PhieuNhap_C obj in this)
                    if (obj.MaPN.Equals(MaPN))
                        return obj;
                return null;
            }
        }
        public PhieuNhap_C this[decimal STT]
        {
            get
            {
                foreach (PhieuNhap_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        //public void  RemoveTo(decimal stt) //xoa 1 PhieuNhap_C
        //{

        //    //foreach (PhieuNhap_C obj in this)
        //    //{
        //    //    if (obj.STT == stt)
        //    //    {
        //    //        this.Items.RemoveAt(this.IndexOf(obj));
        //    //        break; 

        //    //    }
        //    //}
        //    //PhieuNhap_C obj;
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
        public void RemoveTo(PhieuNhap_C obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public void NewTo(string MaPN)
        {
            if (!Contains(MaPN))
            {
                PhieuNhap_C obj = PhieuNhap_C.NewPhieuNhap_C(MaPN);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public PhieuNhap_C NewTo()//ham khoi tao doi tuong Phieu nhap
        {

              PhieuNhap_C obj = PhieuNhap_C.NewPhieuNhap_C();
              return obj;
               
        }
       
      
        public void NewTo(PhieuNhap_C _PhieuNhap_C)
        {
            //if (!Contains(_PhieuNhap_C.Mathuoc))
            //{
            //    if (this.Items.Count > 0)
            //    {
            //        byte _count=0;
            //        _count = (byte)this.Items.Count;
            //        _PhieuNhap_C.STT = ++_count;

            if (this.Items.Count == 0)
                _PhieuNhap_C.STT = 1;
            else
                _PhieuNhap_C.STT = this.Items[this.Items.Count - 1].STT + 1;
            this.Add(_PhieuNhap_C);
            //    }
            //    else
            //    {
            //        _PhieuNhap_C.STT = 1;
            //        this.Add(_PhieuNhap_C);
            //    }
            //}
            //else
            //    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public PhieuNhap_C AssignTo(DMThuoc _DMThuoc)
        {
            if (!Contains(_DMThuoc.MaThuoc))
            {
                PhieuNhap_C obj = PhieuNhap_C.NewPhieuNhap_C(_DMThuoc.MaThuoc);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public PhieuNhap_C AssignTo(PhieuNhap_C _PhieuNhap_C)//add mot hang PhieuNhap_C
        {
          
            if (!Containss(_PhieuNhap_C.MaThuoc, _PhieuNhap_C.Huy, _PhieuNhap_C.SoLo, _PhieuNhap_C.HanSD ))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                 
                    _PhieuNhap_C.STT = ++_count;

                   Add(_PhieuNhap_C);
                }
                else
                {
                    _PhieuNhap_C.STT = 1;
                   
                    Add(_PhieuNhap_C);
                }
            }
           
           return _PhieuNhap_C;
        }
        protected override object AddNewCore()
        {
            PhieuNhap_C item = PhieuNhap_C.NewPhieuNhap_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            MarkAsChild();
            Add(item);
            return item;
        }

       public bool Contains(string MaPN)
        {
            foreach (PhieuNhap_C obj in this)
                if ((obj.MaPN == MaPN) && (obj.Huy = false))
                    return true;
            return false;
        }
        //public bool Containss(string MaThuoc)
        //{
        //    foreach (PhieuNhap_C obj in this)
        //        if ((obj.MaThuoc == MaThuoc) && (obj.Huy = false))
        //            return true;
        //    return false;
        //}
        //public bool Containss(string MaThuoc)
        //{
        //    foreach (PhieuNhap_C obj in this)
        //        if (obj.MaThuoc == MaThuoc) 
        //            return true;
        //    return false;
        //}
        public bool Containss(string MaThuoc, Boolean Huy,string solo, string hansd)
        {
            //foreach (PhieuNhap_C obj in this)
            //    if ((obj.MaThuoc == MaThuoc) && (obj.Huy == Huy) && (obj.SoLo  == solo) && (obj.HanSD  == hansd))
            //        return true;
            return false;
            
        }


        public bool ContainsDeleted(string MaPN)
        {
            foreach (PhieuNhap_C obj in DeletedList)
                if (obj.MaPN == MaPN)
                    return true;
            return false;
        }
        public void UpdatedTo(PhieuNhap_C _PhieuNhap_C)
        {
            PhieuNhap_C _kb = this.Items[this.IndexOf(_PhieuNhap_C)];
            _PhieuNhap_C.STT = _kb.STT;
            this.Items[this.IndexOf(_PhieuNhap_C)] = _PhieuNhap_C;

        }
        public PhieuNhap_C GetTo(decimal  STT)
        {
            foreach (PhieuNhap_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        #endregion

       

        #region Factory Methods

        internal static PhieuNhap_Cs NewPhieuNhap_Cs()
        {
            return new PhieuNhap_Cs();
        }

        internal static PhieuNhap_Cs GetPhieuNhap_Cs(SafeDataReader dr)
        {
            return new PhieuNhap_Cs(dr);
        }

        private PhieuNhap_Cs()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private PhieuNhap_Cs(SafeDataReader dr)
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

                this.Add(PhieuNhap_C.GetPhieuNhap_C(dr));/////////
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(PhieuNhap packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (PhieuNhap_C item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (PhieuNhap_C item in this)
            {
                if ((item.IsNew))// && item.MaPN ==""  )   //MaPN  == ""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(PhieuNhapDT packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (PhieuNhap_C item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (PhieuNhap_C item in this)
            {
                if ((item.IsNew))   //MaPN  == ""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
    }
}