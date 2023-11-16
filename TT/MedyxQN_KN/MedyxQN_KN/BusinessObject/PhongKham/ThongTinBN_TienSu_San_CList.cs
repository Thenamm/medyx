using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;
////
using HTC.Business.CategoryList;

namespace HTC.Business.PhongKham
{
    [Serializable()]
    public class ThongTinBN_TienSu_San_CList : BusinessListBase<ThongTinBN_TienSu_San_CList, ThongTinBN_TienSu_San_C>
    {
        #region Business Methods

        public ThongTinBN_TienSu_San_C this[Decimal STT]
        {
            get
            {
                foreach (ThongTinBN_TienSu_San_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public ThongTinBN_TienSu_San_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        //public void NewTo()
        //{
            
        //        ThongTinBN_TienSu_San_C obj = ThongTinBN_TienSu_San_C.NewThongTinBN_TienSu_San_C();
        //        int _count = 0;
        //        _count = this.Items.Count;
        //        obj.STT = ++_count;
        //        this.Add(obj);
           
        //}

        public ThongTinBN_TienSu_San_C NewTo()
        {

            ThongTinBN_TienSu_San_C obj = ThongTinBN_TienSu_San_C.NewThongTinBN_TienSu_San_C();
            return obj;

        }

        public void NewTo(ThongTinBN_TienSu_San_C _ThongTinBN_TienSu_San_C)
        {
           
                if (this.Items.Count > 0)
                {
                    int _count=0;
                    _count = this.Items.Count;
                    _ThongTinBN_TienSu_San_C.STT = ++_count;
                    this.Add(_ThongTinBN_TienSu_San_C);
                }
                else
                {
                    _ThongTinBN_TienSu_San_C.STT = 1;
                    this.Add(_ThongTinBN_TienSu_San_C);
                }
           
        }

        public ThongTinBN_TienSu_San_C AssignTo()
        {
            
                ThongTinBN_TienSu_San_C obj = ThongTinBN_TienSu_San_C.NewThongTinBN_TienSu_San_C();
                return obj;
          
        }

        public ThongTinBN_TienSu_San_C AssignTo(ThongTinBN_TienSu_San_C _ThongTinBN_TienSu_San_C)//add mot hang PhieuNhap_C
        {
           
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    _count = this.Items.Count;
                   // _ThongTinBN_TienSu_San_C.HanSD = _ThongTinBN_TienSu_San_C.HanSD;
                    _ThongTinBN_TienSu_San_C.STT = ++_count;
                    this.Add(_ThongTinBN_TienSu_San_C);
                }
                else
                {
                    _ThongTinBN_TienSu_San_C.STT = 1;
                    //_ThongTinBN_TienSu_San_C.HanSD = _ThongTinBN_TienSu_San_C.HanSD;
                    this.Add(_ThongTinBN_TienSu_San_C);
                }
                //Add(_PhieuNhap_C);
               
            
             return _ThongTinBN_TienSu_San_C;
        }

        protected override object AddNewCore()
        {
            ThongTinBN_TienSu_San_C item = ThongTinBN_TienSu_San_C.NewThongTinBN_TienSu_San_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(ThongTinBN_TienSu_San_C obj)
        {
            //foreach (ThongTinBN_TienSu_San_C obj in this)
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
            foreach (ThongTinBN_TienSu_San_C obj in this)
                if (obj.STT.Equals(STT))
                {
                    this.Items.Remove(obj);
                    break;
                }
        }
        //public bool Contains(string MaBA)
        //{
        //    foreach (ThongTinBN_TienSu_San_C obj in this)
        //        if ((obj.MaBN == MaBA) && (obj.Huy = false))
        //            return true;
        //    return false;
        //}
        
        

        //public bool ContainsDeleted(string MaBA, int stt,int sttkhoa)
        //{
        //    foreach (ThongTinBN_TienSu_San_C obj in DeletedList)
        //        if ((obj.MaBA == MaBA) && (obj.STT == stt) && (obj.STTKhoa == sttkhoa)  )
        //            return true;
        //    return false;
        //}

        public void UpdatedTo(ThongTinBN_TienSu_San_C _ThongTinBN_TienSu_San_C)
        {

            _ThongTinBN_TienSu_San_C.STT = this.Items[this.IndexOf(_ThongTinBN_TienSu_San_C)].STT;
           this.Items[this.IndexOf(_ThongTinBN_TienSu_San_C)] = _ThongTinBN_TienSu_San_C;
        }

        public ThongTinBN_TienSu_San_C GetTo(decimal STT)
        {
            foreach (ThongTinBN_TienSu_San_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }

        #endregion

        #region Factory Methods

        internal static ThongTinBN_TienSu_San_CList NewThongTinBN_TienSu_San_CList()
        {
            return new ThongTinBN_TienSu_San_CList();
        }

        internal static ThongTinBN_TienSu_San_CList GetThongTinBN_TienSu_San_CList(SafeDataReader dr)
        {
            return new ThongTinBN_TienSu_San_CList(dr);
        }

        private ThongTinBN_TienSu_San_CList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private ThongTinBN_TienSu_San_CList(SafeDataReader dr)
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
                this.Add(ThongTinBN_TienSu_San_C.GetThongTinBN_TienSu_San_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(ThongTinBN_TienSu_San packet)
        {
            RaiseListChangedEvents = false;
            foreach (ThongTinBN_TienSu_San_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (ThongTinBN_TienSu_San_C item in this)
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