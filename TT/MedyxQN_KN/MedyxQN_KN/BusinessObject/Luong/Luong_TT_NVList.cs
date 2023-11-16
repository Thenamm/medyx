using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
////
using HTC.Business;
using HTC.Business.CategoryList  ;

namespace HTC.Business.Luong
{
    [Serializable()]
    public class Luong_TT_NVList : BusinessListBase<Luong_TT_NVList, Luong_TT_NV>
    {
         #region Business Methods

        public Luong_TT_NV this[string MaNV]
        {
            get
            {
                foreach (Luong_TT_NV obj in this)
                    if (obj.MaNV.Equals(MaNV))
                        return obj;
                return null;
            }
        }
       
        public void NewTo(string MaNV)
        {
            if (!Contains(MaNV))
            {
                Luong_TT_NV obj = Luong_TT_NV.NewLuong_TT_NV(MaNV);
                int _count = 0;
                _count = this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public Luong_TT_NV NewTo()//ham khoi tao doi tuong Phieu nhap
        {

              Luong_TT_NV obj = Luong_TT_NV.NewLuong_TT_NV();
              return obj;
               
        }
        public void NewTo(Luong_TT_NV _Luong_TT_NV) //moi sua
        {
            if (!Contains(_Luong_TT_NV.MaNV))
            {
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    _count = this.Items.Count;
                    _Luong_TT_NV.STT = ++_count;
                    this.Add(_Luong_TT_NV);
                }
                else
                {
                    _Luong_TT_NV.STT = 1;
                    this.Add(_Luong_TT_NV);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public Luong_TT_NV AssignTo(DMNhanVien _DMNhanVien)
        {
            if (!Contains(_DMNhanVien.MaNV))
            {
                Luong_TT_NV obj = Luong_TT_NV.NewLuong_TT_NV(_DMNhanVien.MaNV);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public Luong_TT_NV AssignTo(Luong_TT_NV _Luong_TT_NV)//add mot hang Luong_TT_NV
        {
            if (!Contains(_Luong_TT_NV.MaNV))
            {
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    _count = this.Items.Count;
                    _Luong_TT_NV.STT = ++_count;

                    this.Add(_Luong_TT_NV);
                }
                else
                {
                    _Luong_TT_NV.STT = 1;
                    this.Add(_Luong_TT_NV);
                }
            }
           
           return _Luong_TT_NV;
        }
        protected override object AddNewCore()
        {
            Luong_TT_NV item = Luong_TT_NV.NewLuong_TT_NV();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void  RemoveTo(decimal stt) //xoa 1 Luong_TT_NV
        //{
           
        //    //foreach (Luong_TT_NV obj in this)
        //    //{
        //    //    if (obj.STT == stt)
        //    //    {
        //    //        this.Items.RemoveAt(this.IndexOf(obj));
        //    //        break; 
                   
        //    //    }
        //    //}
        //    //Luong_TT_NV obj;
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
        public void RemoveTo(Luong_TT_NV obj) //xoa 1 Luong_TT_NV
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);
                   
        }
        public bool Contains(string MaNV)
        {
            foreach (Luong_TT_NV obj in this)
                if (obj.MaNV == MaNV) 
                    return true;
            return false;
        }
        //public bool Containss(string MaThuoc)
        //{
        //    foreach (Luong_TT_NV obj in this)
        //        if ((obj.MaThuoc == MaThuoc) && (obj.Huy = false))
        //            return true;
        //    return false;
        //}
        //public bool Containss(string MaThuoc)
        //{
        //    foreach (Luong_TT_NV obj in this)
        //        if (obj.MaThuoc == MaThuoc) 
        //            return true;
        //    return false;
        //}
        


        public bool ContainsDeleted(string MaNV)
        {
            foreach (Luong_TT_NV obj in DeletedList)
                if (obj.MaNV == MaNV)
                    return true;
            return false;
        }
        public void UpdatedTo(Luong_TT_NV _Luong_TT_NV)
        {

            _Luong_TT_NV.STT = this.Items[this.IndexOf(_Luong_TT_NV)].STT;
            this.Items[this.IndexOf(_Luong_TT_NV)] = _Luong_TT_NV;
        }
        public Luong_TT_NV GetTo(decimal STT) //
        {
            foreach (Luong_TT_NV obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static Luong_TT_NVList NewLuong_TT_NVList()
        {
            return new Luong_TT_NVList();
        }

        internal static Luong_TT_NVList GetLuong_TT_NVList(SafeDataReader dr)
        {
            return new Luong_TT_NVList(dr);
        }

        private Luong_TT_NVList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private Luong_TT_NVList(SafeDataReader dr)
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

                this.Add(Luong_TT_NV.GetLuong_TT_NV(dr, i));
                i++;
            }
            /////////
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(Luong_TT packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (Luong_TT_NV item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (Luong_TT_NV item in this)
            {
                if (item.IsNew)
                    item.Insert(packet);
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
   
    }
}
