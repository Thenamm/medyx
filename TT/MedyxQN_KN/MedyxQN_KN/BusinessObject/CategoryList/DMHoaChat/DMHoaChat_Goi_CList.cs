using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
//
using HTC.Business;
using HTC.Business.CategoryList  ;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMHoaChat_Goi_CList : BusinessListBase<DMHoaChat_Goi_CList, DMHoaChat_Goi_C>
    {
        #region Business Methods

        public DMHoaChat_Goi_C this[string MaGoiHC]
        {
            get
            {
                foreach (DMHoaChat_Goi_C obj in this)
                    if (obj.MaGoiHC.Equals(MaGoiHC))
                        return obj;
                return null;
            }
        }
        public DMHoaChat_Goi_C this[decimal STT]
        {
            get
            {
                foreach (DMHoaChat_Goi_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public void NewTo(string MaHC)
        {
            if (!Contains(MaHC))
            {
                DMHoaChat_Goi_C obj = DMHoaChat_Goi_C.NewDMHoaChat_Goi_C(MaHC);
                byte _count = 0;
                _count = (byte)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public DMHoaChat_Goi_C NewTo()//ham khoi tao doi tuong Phieu nhap
        {

              DMHoaChat_Goi_C obj = DMHoaChat_Goi_C.NewDMHoaChat_Goi_C();
              return obj;
               
        }
        public void NewTo(DMHoaChat_Goi_C _DMHoaChat_Goi_C) //moi sua
        {
            if (!Contains(_DMHoaChat_Goi_C.MaGoiHC))
            {
                if (this.Items.Count > 0)
                {
                    byte _count = 0;
                    _count = (byte)this.Items.Count;
                    _DMHoaChat_Goi_C.STT = ++_count;
                    this.Add(_DMHoaChat_Goi_C);
                }
                else
                {
                    _DMHoaChat_Goi_C.STT = 1;
                    this.Add(_DMHoaChat_Goi_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        //public DMHoaChat_Goi_C AssignTo(DMNhanVien _DMNhanVien)
        //{
        //    if (!Contains(_DMNhanVien.MaNV))
        //    {
        //        DMHoaChat_Goi_C obj = DMHoaChat_Goi_C.NewDMHoaChat_Goi_C(_DMNhanVien.MaNV);
        //        return obj;
        //    }
        //    else
        //        throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        //}
        public DMHoaChat_Goi_C AssignTo(DMHoaChat_Goi_C _DMHoaChat_Goi_C)//add mot hang DMHoaChat_Goi_C
        {
            if (!Containss(_DMHoaChat_Goi_C.MaHC))
            {
                if (this.Items.Count > 0)
                {

                    byte _count = 0;
                    _count = (byte)this.Items.Count;
                    //_DMHoaChat_Goi_C.OrderNumber = ++_count;
                    _DMHoaChat_Goi_C.STT = ++_count;
                    //_DMHoaChat_Goi_C.MaMay = ,_maMay ,;
                    //_DMHoaChat_Goi_C.NguoiSD = HTC.ShareVariables.pub_sNguoiSD;
                    this.Add(_DMHoaChat_Goi_C);
                }
                else
                {
                    //_DMHoaChat_Goi_C.MaMay = ,_maMay ,;
                    //_DMHoaChat_Goi_C.NguoiSD = HTC.ShareVariables.pub_sNguoiSD;
                    //_DMHoaChat_Goi_C.OrderNumber = 1;
                    _DMHoaChat_Goi_C.STT = 1;
                    this.Add(_DMHoaChat_Goi_C);
                }
            }
           
           return _DMHoaChat_Goi_C;
        }
        protected override object AddNewCore()
        {
            DMHoaChat_Goi_C item = DMHoaChat_Goi_C.NewDMHoaChat_Goi_C();
            Add(item);
            return item;
        }

        
        public void RemoveTo(DMHoaChat_Goi_C obj) //xoa 1 DMHoaChat_Goi_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);
                   
        }
        public bool Contains(string MaHC)
        {
            foreach (DMHoaChat_Goi_C obj in this)
                if ((obj.MaHC == MaHC) && (obj.Huy = false))
                    return true;
            return false;
        }

        public bool Containss(string MaHC)
        {
            foreach (DMHoaChat_Goi_C obj in this)
                if ((obj.MaHC == MaHC) && (obj.Huy == false))
                    return true;
            return false;
        }


        public bool ContainsDeleted(string MaHC)
        {
            foreach (DMHoaChat_Goi_C obj in DeletedList)
                if (obj.MaHC == MaHC)
                    return true;
            return false;
        }
        public void UpdatedTo(DMHoaChat_Goi_C _DMHoaChat_Goi_C)
        {
            _DMHoaChat_Goi_C.STT = this.Items[this.IndexOf(_DMHoaChat_Goi_C)].STT;
            this.Items[this.IndexOf(_DMHoaChat_Goi_C)] = _DMHoaChat_Goi_C;
        }
        public DMHoaChat_Goi_C GetTo(decimal STT) //
        {
            foreach (DMHoaChat_Goi_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static DMHoaChat_Goi_CList NewDMHoaChat_Goi_CList()
        {
            return new DMHoaChat_Goi_CList();
        }

        internal static DMHoaChat_Goi_CList GetDMHoaChat_Goi_CList(SafeDataReader dr)
        {
            return new DMHoaChat_Goi_CList(dr);
        }

        private DMHoaChat_Goi_CList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private DMHoaChat_Goi_CList(SafeDataReader dr)
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
                this.Add(DMHoaChat_Goi_C.GetDMHoaChat_Goi_C(dr, i));/////////
                i++;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(DMHoaChat_Goi packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (DMHoaChat_Goi_C item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (DMHoaChat_Goi_C item in this)
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
