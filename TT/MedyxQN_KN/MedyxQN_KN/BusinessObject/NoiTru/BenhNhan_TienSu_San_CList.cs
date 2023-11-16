using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;
////
using HTC.Business.CategoryList;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhNhan_TienSu_San_CList : BusinessListBase<BenhNhan_TienSu_San_CList, BenhNhan_TienSu_San_C>
    {
        #region Business Methods

        public BenhNhan_TienSu_San_C this[Decimal STT]
        {
            get
            {
                foreach (BenhNhan_TienSu_San_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public BenhNhan_TienSu_San_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        //public void NewTo()
        //{
            
        //        BenhNhan_TienSu_San_C obj = BenhNhan_TienSu_San_C.NewBenhNhan_TienSu_San_C();
        //        int _count = 0;
        //        _count = this.Items.Count;
        //        obj.STT = ++_count;
        //        this.Add(obj);
           
        //}

        public BenhNhan_TienSu_San_C NewTo()
        {

            BenhNhan_TienSu_San_C obj = BenhNhan_TienSu_San_C.NewBenhNhan_TienSu_San_C();
            return obj;

        }

        public void NewTo(BenhNhan_TienSu_San_C _BenhNhan_TienSu_San_C)
        {
           
                if (this.Items.Count > 0)
                {
                    int _count=0;
                    _count = this.Items.Count;
                    _BenhNhan_TienSu_San_C.STT = ++_count;
                    this.Add(_BenhNhan_TienSu_San_C);
                }
                else
                {
                    _BenhNhan_TienSu_San_C.STT = 1;
                    this.Add(_BenhNhan_TienSu_San_C);
                }
           
        }

        public BenhNhan_TienSu_San_C AssignTo()
        {
            
                BenhNhan_TienSu_San_C obj = BenhNhan_TienSu_San_C.NewBenhNhan_TienSu_San_C();
                return obj;
          
        }

        public BenhNhan_TienSu_San_C AssignTo(BenhNhan_TienSu_San_C _BenhNhan_TienSu_San_C)//add mot hang PhieuNhap_C
        {
           
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    _count = this.Items.Count;
                   // _BenhNhan_TienSu_San_C.HanSD = _BenhNhan_TienSu_San_C.HanSD;
                    _BenhNhan_TienSu_San_C.STT = ++_count;
                    this.Add(_BenhNhan_TienSu_San_C);
                }
                else
                {
                    _BenhNhan_TienSu_San_C.STT = 1;
                    //_BenhNhan_TienSu_San_C.HanSD = _BenhNhan_TienSu_San_C.HanSD;
                    this.Add(_BenhNhan_TienSu_San_C);
                }
                //Add(_PhieuNhap_C);
               
            
             return _BenhNhan_TienSu_San_C;
        }

        protected override object AddNewCore()
        {
            BenhNhan_TienSu_San_C item = BenhNhan_TienSu_San_C.NewBenhNhan_TienSu_San_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(BenhNhan_TienSu_San_C obj)
        {
            //foreach (BenhNhan_TienSu_San_C obj in this)
            //{
            //    if (obj.MaBA.Equals(MaBA))
            //    {
            //        Remove(obj);
            //        break;
            //    }
            //}
            if (obj.IsNew==true) 
                this.Items.Remove(obj);
            else Remove(obj );
        }
        public void RemoveTo(decimal  STT)
        {
            foreach (BenhNhan_TienSu_San_C obj in this)
                if (obj.STT.Equals(STT))
                {
                    this.Items.Remove(obj);
                    break;
                }
        }
        //public bool Contains(string MaBA)
        //{
        //    foreach (BenhNhan_TienSu_San_C obj in this)
        //        if ((obj.MaBN == MaBA) && (obj.Huy = false))
        //            return true;
        //    return false;
        //}
        
        

        //public bool ContainsDeleted(string MaBA, int stt,int sttkhoa)
        //{
        //    foreach (BenhNhan_TienSu_San_C obj in DeletedList)
        //        if ((obj.MaBA == MaBA) && (obj.STT == stt) && (obj.STTKhoa == sttkhoa)  )
        //            return true;
        //    return false;
        //}

        public void UpdatedTo(BenhNhan_TienSu_San_C _BenhNhan_TienSu_San_C)
        {

            _BenhNhan_TienSu_San_C.STT = this.Items[this.IndexOf(_BenhNhan_TienSu_San_C)].STT;
           this.Items[this.IndexOf(_BenhNhan_TienSu_San_C)] = _BenhNhan_TienSu_San_C;
        }

        public BenhNhan_TienSu_San_C GetTo(decimal STT)
        {
            foreach (BenhNhan_TienSu_San_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }

        #endregion

        #region Factory Methods

        internal static BenhNhan_TienSu_San_CList NewBenhNhan_TienSu_San_CList()
        {
            return new BenhNhan_TienSu_San_CList();
        }

        internal static BenhNhan_TienSu_San_CList GetBenhNhan_TienSu_San_CList(SafeDataReader dr)
        {
            return new BenhNhan_TienSu_San_CList(dr);
        }

        private BenhNhan_TienSu_San_CList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private BenhNhan_TienSu_San_CList(SafeDataReader dr)
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
                this.Add(BenhNhan_TienSu_San_C.GetBenhNhan_TienSu_San_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(BenhNhan_TienSu_San packet)
        {
            RaiseListChangedEvents = false;
            foreach (BenhNhan_TienSu_San_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (BenhNhan_TienSu_San_C item in this)
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