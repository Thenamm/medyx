using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

using HTC.Business;
using HTC.Business.CategoryList;

namespace HTC.Business.Duoc
{
    [Serializable()]
    public class PhieuCheBien_Cs : BusinessListBase<PhieuCheBien_Cs, PhieuCheBien_C>
    {
        #region Business Methods
        public PhieuCheBien_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public PhieuCheBien_C this[string MaCB]
        {
            get
            {
                foreach (PhieuCheBien_C obj in this)
                    if (obj.MaCB.Equals(MaCB))
                        return obj;
                return null;
            }
        }
        public PhieuCheBien_C this[decimal STT]
        {
            get
            {
                foreach (PhieuCheBien_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaCB)
        {
            if (!Contains(MaCB))
            {
                PhieuCheBien_C obj = PhieuCheBien_C.NewPhieuCheBien_C(MaCB);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public PhieuCheBien_C NewTo()//ham khoi tao doi tuong Phieu nhap
        {

            PhieuCheBien_C obj = PhieuCheBien_C.NewPhieuCheBien_C();
            return obj;

        }
        public void NewTo(PhieuCheBien_C _PhieuCheBien_C) //moi sua
        {
            if (!Contains(_PhieuCheBien_C.maThuoc))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    _PhieuCheBien_C.STT = ++_count;
                    this.Add(_PhieuCheBien_C);
                }
                else
                {
                    _PhieuCheBien_C.STT = 1;
                    this.Add(_PhieuCheBien_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public PhieuCheBien_C AssignTo()
        {
            //if (!Contains(_DMThuoc.MaThuoc))
            //{
                PhieuCheBien_C obj = PhieuCheBien_C.NewPhieuCheBien_C();
                return obj;
            //}
            //else
            //    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public PhieuCheBien_C AssignTo(PhieuCheBien_C _PhieuCheBien_C)//add mot hang PhieuCheBien_C
        {
            //if (!Containss(_PhieuCheBien_C.maThuoc , _PhieuCheBien_C.Huy))
            //{
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;

                    _PhieuCheBien_C.STT = ++_count;

                    this.Add(_PhieuCheBien_C);
                }
                else
                {
                    _PhieuCheBien_C.STT = 1;

                    this.Add(_PhieuCheBien_C);
                }
            //}

            return _PhieuCheBien_C;
        }
        protected override object AddNewCore()
        {
            PhieuCheBien_C item = PhieuCheBien_C.NewPhieuCheBien_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void  RemoveTo(decimal stt) //xoa 1 PhieuCheBien_C
        //{

        //    //foreach (PhieuCheBien_C obj in this)
        //    //{
        //    //    if (obj.STT == stt)
        //    //    {
        //    //        this.Items.RemoveAt(this.IndexOf(obj));
        //    //        break; 

        //    //    }
        //    //}
        //    //PhieuCheBien_C obj;
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
        public void RemoveTo(PhieuCheBien_C obj) //xoa 1 PhieuCheBien_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public bool Contains(string MaThuoc)
        {
            foreach (PhieuCheBien_C obj in this)
                if ((obj.maThuoc == MaThuoc) && (obj.Huy = false))
                    return true;
            return false;
        }
        //public bool Containss(string MaThuoc)
        //{
        //    foreach (PhieuCheBien_C obj in this)
        //        if ((obj.MaThuoc == MaThuoc) && (obj.Huy = false))
        //            return true;
        //    return false;
        //}
        //public bool Containss(string MaThuoc)
        //{
        //    foreach (PhieuCheBien_C obj in this)
        //        if (obj.MaThuoc == MaThuoc) 
        //            return true;
        //    return false;
        //}
        public bool Containss(string mathuoc,  Boolean Huy)
        {
            foreach (PhieuCheBien_C obj in this)
                if ((obj.maThuoc  == mathuoc )  && (obj.Huy == Huy))
                    return true;
            return false;
        }


        public bool ContainsDeleted(string MaCB)
        {
            foreach (PhieuCheBien_C obj in DeletedList)
                if (obj.MaCB == MaCB)
                    return true;
            return false;
        }
        public void UpdatedTo(PhieuCheBien_C _PhieuCheBien_C)
        {

            _PhieuCheBien_C.STT = this.Items[this.IndexOf(_PhieuCheBien_C)].STT;
            this.Items[this.IndexOf(_PhieuCheBien_C)] = _PhieuCheBien_C;
        }
        public PhieuCheBien_C GetTo(decimal STT) //
        {
            foreach (PhieuCheBien_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        #endregion

        #region Factory Methods

        internal static PhieuCheBien_Cs NewPhieuCheBien_Cs()
        {
            return new PhieuCheBien_Cs();
        }

        internal static PhieuCheBien_Cs GetPhieuCheBien_Cs(SafeDataReader dr)
        {
            return new PhieuCheBien_Cs(dr);
        }

        private PhieuCheBien_Cs()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private PhieuCheBien_Cs(SafeDataReader dr)
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

                this.Add(PhieuCheBien_C.GetPhieuCheBien_C(dr));/////////
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

     
        internal void Update(PhieuCheBien packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (PhieuCheBien_C item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (PhieuCheBien_C item in this)
            {
                if ((item.IsNew))// && item.MaCB == "")   //MaCB  == ""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion

    }
}
