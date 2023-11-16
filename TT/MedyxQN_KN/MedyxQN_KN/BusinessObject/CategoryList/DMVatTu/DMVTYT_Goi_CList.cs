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
    public class DMVTYT_Goi_CList : BusinessListBase<DMVTYT_Goi_CList, DMVTYT_Goi_C>
    {
        #region Business Methods

        public DMVTYT_Goi_C this[string MaGoiVT]
        {
            get
            {
                foreach (DMVTYT_Goi_C obj in this)
                    if (obj.MaGoiVT.Equals(MaGoiVT))
                        return obj;
                return null;
            }
        }
        public DMVTYT_Goi_C this[decimal STT]
        {
            get
            {
                foreach (DMVTYT_Goi_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public void NewTo(string MaVT)
        {
            if (!Contains(MaVT))
            {
                DMVTYT_Goi_C obj = DMVTYT_Goi_C.NewDMVTYT_Goi_C(MaVT);
                byte _count = 0;
                _count = (byte)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public DMVTYT_Goi_C NewTo()//ham khoi tao doi tuong Phieu nhap
        {

              DMVTYT_Goi_C obj = DMVTYT_Goi_C.NewDMVTYT_Goi_C();
              return obj;
               
        }
        public void NewTo(DMVTYT_Goi_C _DMVTYT_Goi_C) //moi sua
        {
            if (!Contains(_DMVTYT_Goi_C.MaGoiVT))
            {
                if (this.Items.Count > 0)
                {
                    byte _count = 0;
                    _count = (byte)this.Items.Count;
                    _DMVTYT_Goi_C.STT = ++_count;
                    this.Add(_DMVTYT_Goi_C);
                }
                else
                {
                    _DMVTYT_Goi_C.STT = 1;
                    this.Add(_DMVTYT_Goi_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        //public DMVTYT_Goi_C AssignTo(DMNhanVien _DMNhanVien)
        //{
        //    if (!Contains(_DMNhanVien.MaNV))
        //    {
        //        DMVTYT_Goi_C obj = DMVTYT_Goi_C.NewDMVTYT_Goi_C(_DMNhanVien.MaNV);
        //        return obj;
        //    }
        //    else
        //        throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        //}
        public DMVTYT_Goi_C AssignTo(DMVTYT_Goi_C _DMVTYT_Goi_C)//add mot hang DMVTYT_Goi_C
        {
            if (!Containss(_DMVTYT_Goi_C.MaVT))
            {
                if (this.Items.Count > 0)
                {

                    byte _count = 0;
                    _count = (byte)this.Items.Count;
                    //_DMVTYT_Goi_C.OrderNumber = ++_count;
                    _DMVTYT_Goi_C.STT = ++_count;
                    //_DMVTYT_Goi_C.MaMay = ,_maMay ,;
                    //_DMVTYT_Goi_C.NguoiSD = HTC.ShareVariables.pub_sNguoiSD;
                    this.Add(_DMVTYT_Goi_C);
                }
                else
                {
                    //_DMVTYT_Goi_C.MaMay = ,_maMay ,;
                    //_DMVTYT_Goi_C.NguoiSD = HTC.ShareVariables.pub_sNguoiSD;
                    //_DMVTYT_Goi_C.OrderNumber = 1;
                    _DMVTYT_Goi_C.STT = 1;
                    this.Add(_DMVTYT_Goi_C);
                }
            }
           
           return _DMVTYT_Goi_C;
        }
        protected override object AddNewCore()
        {
            DMVTYT_Goi_C item = DMVTYT_Goi_C.NewDMVTYT_Goi_C();
            Add(item);
            return item;
        }

        
        public void RemoveTo(DMVTYT_Goi_C obj) //xoa 1 DMVTYT_Goi_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);
                   
        }
        public bool Contains(string MaVT)
        {
            foreach (DMVTYT_Goi_C obj in this)
                if ((obj.MaVT == MaVT) && (obj.Huy = false))
                    return true;
            return false;
        }

        public bool Containss(string MaVT)
        {
            foreach (DMVTYT_Goi_C obj in this)
                if ((obj.MaVT == MaVT) && (obj.Huy == false))
                    return true;
            return false;
        }


        public bool ContainsDeleted(string MaVT)
        {
            foreach (DMVTYT_Goi_C obj in DeletedList)
                if (obj.MaVT == MaVT)
                    return true;
            return false;
        }
        public void UpdatedTo(DMVTYT_Goi_C _DMVTYT_Goi_C)
        {
            _DMVTYT_Goi_C.STT = this.Items[this.IndexOf(_DMVTYT_Goi_C)].STT;
            this.Items[this.IndexOf(_DMVTYT_Goi_C)] = _DMVTYT_Goi_C;
        }
        public DMVTYT_Goi_C GetTo(decimal STT) //
        {
            foreach (DMVTYT_Goi_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static DMVTYT_Goi_CList NewDMVTYT_Goi_CList()
        {
            return new DMVTYT_Goi_CList();
        }

        internal static DMVTYT_Goi_CList GetDMVTYT_Goi_CList(SafeDataReader dr)
        {
            return new DMVTYT_Goi_CList(dr);
        }

        private DMVTYT_Goi_CList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private DMVTYT_Goi_CList(SafeDataReader dr)
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
                this.Add(DMVTYT_Goi_C.GetDMVTYT_Goi_C(dr, i));/////////
                i++;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(DMVTYT_Goi packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (DMVTYT_Goi_C item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (DMVTYT_Goi_C item in this)
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
