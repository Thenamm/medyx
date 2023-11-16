using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

using HTC.Business;
using HTC.Business.CategoryList;

namespace HTC.Business.HoaChat
{
    [Serializable()]
    public class HCPhieuCheBien_Cs : BusinessListBase<HCPhieuCheBien_Cs, HCPhieuCheBien_C>
    {
        #region Business Methods
        public HCPhieuCheBien_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public HCPhieuCheBien_C this[string MaCB]
        {
            get
            {
                foreach (HCPhieuCheBien_C obj in this)
                    if (obj.MaCB.Equals(MaCB))
                        return obj;
                return null;
            }
        }
        public HCPhieuCheBien_C this[decimal STT]
        {
            get
            {
                foreach (HCPhieuCheBien_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaCB)
        {
            if (!Contains(MaCB))
            {
                HCPhieuCheBien_C obj = HCPhieuCheBien_C.NewHCPhieuCheBien_C(MaCB);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public HCPhieuCheBien_C NewTo()//ham khoi tao doi tuong Phieu nhap
        {

            HCPhieuCheBien_C obj = HCPhieuCheBien_C.NewHCPhieuCheBien_C();
            return obj;

        }
        public void NewTo(HCPhieuCheBien_C _HCPhieuCheBien_C) //moi sua
        {
            if (!Contains(_HCPhieuCheBien_C.maHC))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    _HCPhieuCheBien_C.STT = ++_count;
                    this.Add(_HCPhieuCheBien_C);
                }
                else
                {
                    _HCPhieuCheBien_C.STT = 1;
                    this.Add(_HCPhieuCheBien_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public HCPhieuCheBien_C AssignTo()
        {
            //if (!Contains(_DMThuoc.maHC))
            //{
                HCPhieuCheBien_C obj = HCPhieuCheBien_C.NewHCPhieuCheBien_C();
                return obj;
            //}
            //else
            //    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public HCPhieuCheBien_C AssignTo(HCPhieuCheBien_C _HCPhieuCheBien_C)//add mot hang HCPhieuCheBien_C
        {
            if (!Containss(_HCPhieuCheBien_C.maHC , _HCPhieuCheBien_C.Huy))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;

                    _HCPhieuCheBien_C.STT = ++_count;

                    this.Add(_HCPhieuCheBien_C);
                }
                else
                {
                    _HCPhieuCheBien_C.STT = 1;

                    this.Add(_HCPhieuCheBien_C);
                }
            }

            return _HCPhieuCheBien_C;
        }
        protected override object AddNewCore()
        {
            HCPhieuCheBien_C item = HCPhieuCheBien_C.NewHCPhieuCheBien_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void  RemoveTo(decimal stt) //xoa 1 HCPhieuCheBien_C
        //{

        //    //foreach (HCPhieuCheBien_C obj in this)
        //    //{
        //    //    if (obj.STT == stt)
        //    //    {
        //    //        this.Items.RemoveAt(this.IndexOf(obj));
        //    //        break; 

        //    //    }
        //    //}
        //    //HCPhieuCheBien_C obj;
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
        public void RemoveTo(HCPhieuCheBien_C obj) //xoa 1 HCPhieuCheBien_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public bool Contains(string maHC)
        {
            foreach (HCPhieuCheBien_C obj in this)
                if ((obj.maHC == maHC) && (obj.Huy = false))
                    return true;
            return false;
        }
        //public bool Containss(string maHC)
        //{
        //    foreach (HCPhieuCheBien_C obj in this)
        //        if ((obj.maHC == maHC) && (obj.Huy = false))
        //            return true;
        //    return false;
        //}
        //public bool Containss(string maHC)
        //{
        //    foreach (HCPhieuCheBien_C obj in this)
        //        if (obj.maHC == maHC) 
        //            return true;
        //    return false;
        //}
        public bool Containss(string maHC,  Boolean Huy)
        {
            foreach (HCPhieuCheBien_C obj in this)
                if ((obj.maHC  == maHC )  && (obj.Huy == Huy))
                    return true;
            return false;
        }


        public bool ContainsDeleted(string MaCB)
        {
            foreach (HCPhieuCheBien_C obj in DeletedList)
                if (obj.MaCB == MaCB)
                    return true;
            return false;
        }
        public void UpdatedTo(HCPhieuCheBien_C _HCPhieuCheBien_C)
        {

            _HCPhieuCheBien_C.STT = this.Items[this.IndexOf(_HCPhieuCheBien_C)].STT;
            this.Items[this.IndexOf(_HCPhieuCheBien_C)] = _HCPhieuCheBien_C;
        }
        public HCPhieuCheBien_C GetTo(decimal STT) //
        {
            foreach (HCPhieuCheBien_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        #endregion

        #region Factory Methods

        internal static HCPhieuCheBien_Cs NewHCPhieuCheBien_Cs()
        {
            return new HCPhieuCheBien_Cs();
        }

        internal static HCPhieuCheBien_Cs GetHCPhieuCheBien_Cs(SafeDataReader dr)
        {
            return new HCPhieuCheBien_Cs(dr);
        }

        private HCPhieuCheBien_Cs()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private HCPhieuCheBien_Cs(SafeDataReader dr)
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

                this.Add(HCPhieuCheBien_C.GetHCPhieuCheBien_C(dr));/////////
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

     
        internal void Update(HCPhieuCheBien packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (HCPhieuCheBien_C item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (HCPhieuCheBien_C item in this)
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
