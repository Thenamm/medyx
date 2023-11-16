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
    public class PhieuKiemNghiem_Cs : BusinessListBase<PhieuKiemNghiem_Cs, PhieuKiemNghiem_C>
    {
        #region Business Methods
        public PhieuKiemNghiem_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public PhieuKiemNghiem_C this[string MaKN]
        {
            get
            {
                foreach (PhieuKiemNghiem_C obj in this)
                    if (obj.MaKN.Equals(MaKN))
                        return obj;
                return null;
            }
        }
        public PhieuKiemNghiem_C this[decimal STT]
        {
            get
            {
                foreach (PhieuKiemNghiem_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }

      
        public PhieuKiemNghiem_C NewTo()//ham khoi tao doi tuong Phieu nhap
        {

            PhieuKiemNghiem_C obj = PhieuKiemNghiem_C.NewPhieuKiemNghiem_C();
            return obj;

        }
        public void NewTo(PhieuKiemNghiem_C _PhieuKiemNghiem_C) //moi sua
        {
            if (!Containss(_PhieuKiemNghiem_C.MaKN, _PhieuKiemNghiem_C.MaKQ))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    _PhieuKiemNghiem_C.STT = ++_count;
                    this.Add(_PhieuKiemNghiem_C);
                }
                else
                {
                    _PhieuKiemNghiem_C.STT = 1;
                    this.Add(_PhieuKiemNghiem_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public PhieuKiemNghiem_C AssignTo()
        {
            //if (!Contains(_DMThuoc.maDG))
            //{
                PhieuKiemNghiem_C obj = PhieuKiemNghiem_C.NewPhieuKiemNghiem_C();
                return obj;
            //}
            //else
            //    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public PhieuKiemNghiem_C AssignTo(PhieuKiemNghiem_C _PhieuKiemNghiem_C)//add mot hang PhieuKiemNghiem_C
        {
            if (!Containss(_PhieuKiemNghiem_C.MaDG, _PhieuKiemNghiem_C.MaKQ))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;

                    _PhieuKiemNghiem_C.STT = ++_count;

                    this.Add(_PhieuKiemNghiem_C);
                }
                else
                {
                    _PhieuKiemNghiem_C.STT = 1;

                    this.Add(_PhieuKiemNghiem_C);
                }
            }

            return _PhieuKiemNghiem_C;
        }
        protected override object AddNewCore()
        {
            PhieuKiemNghiem_C item = PhieuKiemNghiem_C.NewPhieuKiemNghiem_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void  RemoveTo(decimal stt) //xoa 1 PhieuKiemNghiem_C
        //{

        //    //foreach (PhieuKiemNghiem_C obj in this)
        //    //{
        //    //    if (obj.STT == stt)
        //    //    {
        //    //        this.Items.RemoveAt(this.IndexOf(obj));
        //    //        break; 

        //    //    }
        //    //}
        //    //PhieuKiemNghiem_C obj;
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
        public void RemoveTo(PhieuKiemNghiem_C obj) //xoa 1 PhieuKiemNghiem_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public bool Containss(string MaDG,string MaKQ)
        {
            foreach (PhieuKiemNghiem_C obj in this)
                if ((obj.MaDG == MaDG) && (obj.MaKQ == MaKQ) && (obj.Huy = false))
                    return true;
            return false;
        }
     
      


        public bool ContainsDeleted(string MaKN)
        {
            foreach (PhieuKiemNghiem_C obj in DeletedList)
                if (obj.MaKN == MaKN)
                    return true;
            return false;
        }
        public void UpdatedTo(PhieuKiemNghiem_C _PhieuKiemNghiem_C)
        {

            _PhieuKiemNghiem_C.STT = this.Items[this.IndexOf(_PhieuKiemNghiem_C)].STT;
            this.Items[this.IndexOf(_PhieuKiemNghiem_C)] = _PhieuKiemNghiem_C;
        }
        public PhieuKiemNghiem_C GetTo(decimal STT) //
        {
            foreach (PhieuKiemNghiem_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        #endregion

        #region Factory Methods

        internal static PhieuKiemNghiem_Cs NewPhieuKiemNghiem_Cs()
        {
            return new PhieuKiemNghiem_Cs();
        }

        internal static PhieuKiemNghiem_Cs GetPhieuKiemNghiem_Cs(SafeDataReader dr)
        {
            return new PhieuKiemNghiem_Cs(dr);
        }

        private PhieuKiemNghiem_Cs()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private PhieuKiemNghiem_Cs(SafeDataReader dr)
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

                this.Add(PhieuKiemNghiem_C.GetPhieuKiemNghiem_C(dr));/////////
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

     
        internal void Update(PhieuKiemNghiem packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (PhieuKiemNghiem_C item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (PhieuKiemNghiem_C item in this)
            {
                if ((item.IsNew))// && item.MaKN == "")   //MaKN  == ""))
                    item.Insert(packet);
                else if (item.IsDirty==true)
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion

    }
}
