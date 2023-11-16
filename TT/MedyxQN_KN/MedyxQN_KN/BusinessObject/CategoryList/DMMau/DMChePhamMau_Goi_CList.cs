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
    public class DMChePhamMau_Goi_CList : BusinessListBase<DMChePhamMau_Goi_CList, DMChePhamMau_Goi_C>
    {
        #region Business Methods

        public DMChePhamMau_Goi_C this[string MaGoiCPMau]
        {
            get
            {
                foreach (DMChePhamMau_Goi_C obj in this)
                    if (obj.MaGoiCPMau.Equals(MaGoiCPMau))
                        return obj;
                return null;
            }
        }
        public DMChePhamMau_Goi_C this[decimal STT]
        {
            get
            {
                foreach (DMChePhamMau_Goi_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public void NewTo(string MaCPMau)
        {
            if (!Contains(MaCPMau))
            {
                DMChePhamMau_Goi_C obj = DMChePhamMau_Goi_C.NewDMChePhamMau_Goi_C(MaCPMau);
                byte _count = 0;
                _count = (byte)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public DMChePhamMau_Goi_C NewTo()//ham khoi tao doi tuong Phieu nhap
        {

              DMChePhamMau_Goi_C obj = DMChePhamMau_Goi_C.NewDMChePhamMau_Goi_C();
              return obj;
               
        }
        public void NewTo(DMChePhamMau_Goi_C _DMChePhamMau_Goi_C) //moi sua
        {
            if (!Contains(_DMChePhamMau_Goi_C.MaGoiCPMau))
            {
                if (this.Items.Count > 0)
                {
                    byte _count = 0;
                    _count = (byte)this.Items.Count;
                    _DMChePhamMau_Goi_C.STT = ++_count;
                    this.Add(_DMChePhamMau_Goi_C);
                }
                else
                {
                    _DMChePhamMau_Goi_C.STT = 1;
                    this.Add(_DMChePhamMau_Goi_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        //public DMChePhamMau_Goi_C AssignTo(DMNhanVien _DMNhanVien)
        //{
        //    if (!Contains(_DMNhanVien.MaNV))
        //    {
        //        DMChePhamMau_Goi_C obj = DMChePhamMau_Goi_C.NewDMChePhamMau_Goi_C(_DMNhanVien.MaNV);
        //        return obj;
        //    }
        //    else
        //        throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        //}
        public DMChePhamMau_Goi_C AssignTo(DMChePhamMau_Goi_C _DMChePhamMau_Goi_C)//add mot hang DMChePhamMau_Goi_C
        {
            if (!Containss(_DMChePhamMau_Goi_C.MaCPMau))
            {
                if (this.Items.Count > 0)
                {

                    byte _count = 0;
                    _count = (byte)this.Items.Count;
                    //_DMChePhamMau_Goi_C.OrderNumber = ++_count;
                    _DMChePhamMau_Goi_C.STT = ++_count;
                    //_DMChePhamMau_Goi_C.MaMay = ,_maMay ,;
                    //_DMChePhamMau_Goi_C.NguoiSD = HTC.ShareVariables.pub_sNguoiSD;
                    this.Add(_DMChePhamMau_Goi_C);
                }
                else
                {
                    //_DMChePhamMau_Goi_C.MaMay = ,_maMay ,;
                    //_DMChePhamMau_Goi_C.NguoiSD = HTC.ShareVariables.pub_sNguoiSD;
                    //_DMChePhamMau_Goi_C.OrderNumber = 1;
                    _DMChePhamMau_Goi_C.STT = 1;
                    this.Add(_DMChePhamMau_Goi_C);
                }
            }
           
           return _DMChePhamMau_Goi_C;
        }
        protected override object AddNewCore()
        {
            DMChePhamMau_Goi_C item = DMChePhamMau_Goi_C.NewDMChePhamMau_Goi_C();
            Add(item);
            return item;
        }

        
        public void RemoveTo(DMChePhamMau_Goi_C obj) //xoa 1 DMChePhamMau_Goi_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);
                   
        }
        public bool Contains(string MaCPMau)
        {
            foreach (DMChePhamMau_Goi_C obj in this)
                if ((obj.MaCPMau == MaCPMau) && (obj.Huy = false))
                    return true;
            return false;
        }

        public bool Containss(string MaCPMau)
        {
            foreach (DMChePhamMau_Goi_C obj in this)
                if ((obj.MaCPMau == MaCPMau) && (obj.Huy == false))
                    return true;
            return false;
        }


        public bool ContainsDeleted(string MaCPMau)
        {
            foreach (DMChePhamMau_Goi_C obj in DeletedList)
                if (obj.MaCPMau == MaCPMau)
                    return true;
            return false;
        }
        public void UpdatedTo(DMChePhamMau_Goi_C _DMChePhamMau_Goi_C)
        {
            _DMChePhamMau_Goi_C.STT = this.Items[this.IndexOf(_DMChePhamMau_Goi_C)].STT;
            this.Items[this.IndexOf(_DMChePhamMau_Goi_C)] = _DMChePhamMau_Goi_C;
        }
        public DMChePhamMau_Goi_C GetTo(decimal STT) //
        {
            foreach (DMChePhamMau_Goi_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static DMChePhamMau_Goi_CList NewDMChePhamMau_Goi_CList()
        {
            return new DMChePhamMau_Goi_CList();
        }

        internal static DMChePhamMau_Goi_CList GetDMChePhamMau_Goi_CList(SafeDataReader dr)
        {
            return new DMChePhamMau_Goi_CList(dr);
        }

        private DMChePhamMau_Goi_CList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private DMChePhamMau_Goi_CList(SafeDataReader dr)
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
                this.Add(DMChePhamMau_Goi_C.GetDMChePhamMau_Goi_C(dr, i));/////////
                i++;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(DMChePhamMau_Goi packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (DMChePhamMau_Goi_C item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (DMChePhamMau_Goi_C item in this)
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
