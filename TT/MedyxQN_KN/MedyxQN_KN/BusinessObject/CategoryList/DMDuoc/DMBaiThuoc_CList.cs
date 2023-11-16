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
    public class DMBaiThuoc_CList : BusinessListBase<DMBaiThuoc_CList, DMBaiThuoc_C>
    {
        #region Business Methods

        public DMBaiThuoc_C this[string MaBThuoc]
        {
            get
            {
                foreach (DMBaiThuoc_C obj in this)
                    if (obj.MaBThuoc.Equals(MaBThuoc))
                        return obj;
                return null;
            }
        }
        public DMBaiThuoc_C this[decimal STT]
        {
            get
            {
                foreach (DMBaiThuoc_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public void NewTo(string MaThuoc)
        {
            if (!Contains(MaThuoc))
            {
                DMBaiThuoc_C obj = DMBaiThuoc_C.NewDMBaiThuoc_C(MaThuoc);
                byte _count = 0;
                _count = (byte)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public DMBaiThuoc_C NewTo()//ham khoi tao doi tuong Phieu nhap
        {

              DMBaiThuoc_C obj = DMBaiThuoc_C.NewDMBaiThuoc_C();
              return obj;
               
        }
        public void NewTo(DMBaiThuoc_C _DMBaiThuoc_C) //moi sua
        {
            if (!Contains(_DMBaiThuoc_C.MaBThuoc))
            {
                if (this.Items.Count > 0)
                {
                    byte _count = 0;
                    _count = (byte)this.Items.Count;
                    _DMBaiThuoc_C.STT = ++_count;
                    this.Add(_DMBaiThuoc_C);
                }
                else
                {
                    _DMBaiThuoc_C.STT = 1;
                    this.Add(_DMBaiThuoc_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        //public DMBaiThuoc_C AssignTo(DMNhanVien _DMNhanVien)
        //{
        //    if (!Contains(_DMNhanVien.MaNV))
        //    {
        //        DMBaiThuoc_C obj = DMBaiThuoc_C.NewDMBaiThuoc_C(_DMNhanVien.MaNV);
        //        return obj;
        //    }
        //    else
        //        throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        //}
        public DMBaiThuoc_C AssignTo(DMBaiThuoc_C _DMBaiThuoc_C)//add mot hang DMBaiThuoc_C
        {
            if (!Containss(_DMBaiThuoc_C.MaThuoc))
            {
                if (this.Items.Count > 0)
                {

                    byte _count = 0;
                    _count = (byte)this.Items.Count;
                    //_DMBaiThuoc_C.OrderNumber = ++_count;
                    _DMBaiThuoc_C.STT = ++_count;
                   // _DMBaiThuoc_C.MaMay = ,_maMay ,;
                   // _DMBaiThuoc_C.NguoiSD = HTC.ShareVariables.pub_sNguoiSD;
                    this.Add(_DMBaiThuoc_C);
                }
                else
                {
                  //  _DMBaiThuoc_C.MaMay = ,_maMay ,;
                    //_DMBaiThuoc_C.NguoiSD = HTC.ShareVariables.pub_sNguoiSD;
                    //_DMBaiThuoc_C.OrderNumber = 1;
                    _DMBaiThuoc_C.STT = 1;
                    this.Add(_DMBaiThuoc_C);
                }
            }
           
           return _DMBaiThuoc_C;
        }
        protected override object AddNewCore()
        {
            DMBaiThuoc_C item = DMBaiThuoc_C.NewDMBaiThuoc_C();
            Add(item);
            return item;
        }

        
        public void RemoveTo(DMBaiThuoc_C obj) //xoa 1 DMBaiThuoc_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);
                   
        }
        public bool Contains(string MaThuoc)
        {
            foreach (DMBaiThuoc_C obj in this)
                if ((obj.MaThuoc == MaThuoc) && (obj.Huy = false))
                    return true;
            return false;
        }

        public bool Containss(string MaThuoc)
        {
            foreach (DMBaiThuoc_C obj in this)
                if ((obj.MaThuoc == MaThuoc) && (obj.Huy == false))
                    return true;
            return false;
        }


        public bool ContainsDeleted(string MaThuoc)
        {
            foreach (DMBaiThuoc_C obj in DeletedList)
                if (obj.MaThuoc == MaThuoc)
                    return true;
            return false;
        }
        public void UpdatedTo(DMBaiThuoc_C _DMBaiThuoc_C)
        {
            _DMBaiThuoc_C.STT = this.Items[this.IndexOf(_DMBaiThuoc_C)].STT;
            this.Items[this.IndexOf(_DMBaiThuoc_C)] = _DMBaiThuoc_C;
        }
        public DMBaiThuoc_C GetTo(decimal STT) //
        {
            foreach (DMBaiThuoc_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static DMBaiThuoc_CList NewDMBaiThuoc_CList()
        {
            return new DMBaiThuoc_CList();
        }

        internal static DMBaiThuoc_CList GetDMBaiThuoc_CList(SafeDataReader dr)
        {
            return new DMBaiThuoc_CList(dr);
        }

        private DMBaiThuoc_CList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private DMBaiThuoc_CList(SafeDataReader dr)
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
                this.Add(DMBaiThuoc_C.GetDMBaiThuoc_C(dr, i));/////////
                i++;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(DMBaiThuoc packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (DMBaiThuoc_C item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (DMBaiThuoc_C item in this)
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
