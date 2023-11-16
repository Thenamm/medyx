using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
//
using HTC.Business;
using HTC.Business.CategoryList  ;

namespace HTC.Business.Duoc
{
    [Serializable()]
    public class PhieuDTNhap_C_List : BusinessListBase<PhieuDTNhap_C_List, PhieuDTNhap_C>
    {
         #region Business Methods
        public PhieuDTNhap_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public PhieuDTNhap_C this[string MaDuTru]
        {
            get
            {
                foreach (PhieuDTNhap_C obj in this)
                    if (obj.MaDuTru.Equals(MaDuTru))
                        return obj;
                return null;
            }
        }
        public PhieuDTNhap_C this[decimal STT]
        {
            get
            {
                foreach (PhieuDTNhap_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public void NewTo(string MaDuTru)
        {
            if (!Contains(MaDuTru))
            {
                PhieuDTNhap_C obj = PhieuDTNhap_C.NewPhieuDTNhap_C(MaDuTru);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public PhieuDTNhap_C NewTo()//ham khoi tao doi tuong Phieu nhap
        {

              PhieuDTNhap_C obj = PhieuDTNhap_C.NewPhieuDTNhap_C();
              return obj;
               
        }
        public void NewTo(PhieuDTNhap_C _PhieuDTNhap_C) //moi sua
        {
            if (!Contains(_PhieuDTNhap_C.MaDuTru))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    _PhieuDTNhap_C.STT = ++_count;
                    this.Add(_PhieuDTNhap_C);
                }
                else
                {
                    _PhieuDTNhap_C.STT = 1;
                    this.Add(_PhieuDTNhap_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public PhieuDTNhap_C AssignTo(DMThuoc _DMThuoc)
        {
            if (!Contains(_DMThuoc.MaThuoc))
            {
                PhieuDTNhap_C obj = PhieuDTNhap_C.NewPhieuDTNhap_C(_DMThuoc.MaThuoc);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public PhieuDTNhap_C AssignTo(PhieuDTNhap_C _PhieuDTNhap_C)//add mot hang PhieuDTNhap_C
        {
            if (!Containss(_PhieuDTNhap_C.Mathuoc, _PhieuDTNhap_C.Huy, _PhieuDTNhap_C.Handung ))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    
                    _PhieuDTNhap_C.STT = ++_count;

                    this.Add(_PhieuDTNhap_C);
                }
                else
                {
                    _PhieuDTNhap_C.STT = 1;
                   
                    this.Add(_PhieuDTNhap_C);
                }
            }
           
           return _PhieuDTNhap_C;
        }
        protected override object AddNewCore()
        {
            PhieuDTNhap_C item = PhieuDTNhap_C.NewPhieuDTNhap_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void  RemoveTo(decimal stt) //xoa 1 PhieuDTNhap_C
        //{
           
        //    //foreach (PhieuDTNhap_C obj in this)
        //    //{
        //    //    if (obj.STT == stt)
        //    //    {
        //    //        this.Items.RemoveAt(this.IndexOf(obj));
        //    //        break; 
                   
        //    //    }
        //    //}
        //    //PhieuDTNhap_C obj;
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
        public void RemoveTo(PhieuDTNhap_C obj) //xoa 1 PhieuDTNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);
                   
        }
        public bool Contains(string MaDuTru)
        {
            foreach (PhieuDTNhap_C obj in this)
                if ((obj.MaDuTru == MaDuTru) && (obj.Huy = false))
                    return true;
            return false;
        }
        //public bool Containss(string MaThuoc)
        //{
        //    foreach (PhieuDTNhap_C obj in this)
        //        if ((obj.MaThuoc == MaThuoc) && (obj.Huy = false))
        //            return true;
        //    return false;
        //}
        //public bool Containss(string MaThuoc)
        //{
        //    foreach (PhieuDTNhap_C obj in this)
        //        if (obj.MaThuoc == MaThuoc) 
        //            return true;
        //    return false;
        //}
        public bool Containss(string MaThuoc, Boolean Huy,bool hansd)
        {
            foreach (PhieuDTNhap_C obj in this)
                if ((obj.Mathuoc == MaThuoc) && (obj.Huy == Huy) && (obj.Handung  == hansd))
                    return true;
            return false;
        }


        public bool ContainsDeleted(string MaDuTru)
        {
            foreach (PhieuDTNhap_C obj in DeletedList)
                if (obj.MaDuTru == MaDuTru)
                    return true;
            return false;
        }
        public void UpdatedTo(PhieuDTNhap_C _PhieuDTNhap_C)
        {

            _PhieuDTNhap_C.STT = this.Items[this.IndexOf(_PhieuDTNhap_C)].STT;
            this.Items[this.IndexOf(_PhieuDTNhap_C)] = _PhieuDTNhap_C;
        }
        public PhieuDTNhap_C GetTo(decimal STT) //
        {
            foreach (PhieuDTNhap_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static PhieuDTNhap_C_List NewPhieuDTNhap_C_List()
        {
            return new PhieuDTNhap_C_List();
        }

        internal static PhieuDTNhap_C_List GetPhieuDTNhap_C_List(SafeDataReader dr)
        {
            return new PhieuDTNhap_C_List(dr);
        }

        private PhieuDTNhap_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private PhieuDTNhap_C_List(SafeDataReader dr)
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
                
                this.Add(PhieuDTNhap_C.GetPhieuDTNhap_C(dr));/////////
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(PhieuDTNhap packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (PhieuDTNhap_C item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (PhieuDTNhap_C item in this)
            {
                if ((item.IsNew))// && item.MaDuTru == "")   //MaDuTru ==""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
   
    }
}
