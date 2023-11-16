using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
////
using HTC.Business;
using HTC.Business.CategoryList  ;

namespace HTC.Business.PhongKham
{
    [Serializable()]
    public class KhamBenh_CSTN_TVList : BusinessListBase<KhamBenh_CSTN_TVList, KhamBenh_CSTN_TV>
    {
         #region Business Methods

        public KhamBenh_CSTN_TV this[string MaSoKham]
        {
            get
            {
                foreach (KhamBenh_CSTN_TV obj in this)
                    if (obj.MaSoKham.Equals(MaSoKham))
                        return obj;
                return null;
            }
        }
        public KhamBenh_CSTN_TV this[decimal STT]
        {
            get
            {
                foreach (KhamBenh_CSTN_TV obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public KhamBenh_CSTN_TV this[int i]
        {
            get
            {
                return this.Items[i];
            }
        }
        public void NewTo(string MaSoKham)
        {
            if (!Contains(MaSoKham))
            {
                KhamBenh_CSTN_TV obj = KhamBenh_CSTN_TV.NewKhamBenh_CSTN_TV(MaSoKham);
                byte _count = 0;
                _count = (byte)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public KhamBenh_CSTN_TV NewTo()//ham khoi tao doi tuong Phieu nhap
        {

              KhamBenh_CSTN_TV obj = KhamBenh_CSTN_TV.NewKhamBenh_CSTN_TV();
              return obj;
               
        }
        public void NewTo(KhamBenh_CSTN_TV _KhamBenh_CSTN_TV) //moi sua
        {
            if (!Contains(_KhamBenh_CSTN_TV.MaSoKham))
            {
                if (this.Items.Count > 0)
                {
                    byte _count = 0;
                    _count = (byte)this.Items.Count;
                    _KhamBenh_CSTN_TV.STT = ++_count;
                    this.Add(_KhamBenh_CSTN_TV);
                }
                else
                {
                    _KhamBenh_CSTN_TV.STT = 1;
                    this.Add(_KhamBenh_CSTN_TV);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        //public KhamBenh_CSTN_TV AssignTo(DMNhanVien _DMNhanVien)
        //{
        //    if (!Contains(_DMNhanVien.MaNV))
        //    {
        //        KhamBenh_CSTN_TV obj = KhamBenh_CSTN_TV.NewKhamBenh_CSTN_TV(_DMNhanVien.MaNV);
        //        return obj;
        //    }
        //    else
        //        throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        //}
        public KhamBenh_CSTN_TV AssignTo(KhamBenh_CSTN_TV _KhamBenh_CSTN_TV)//add mot hang KhamBenh_CSTN_TV
        {
            if (!Containss(_KhamBenh_CSTN_TV.MaNV))
            {
                //if (this.Items.Count > 0)
                //{
                    _KhamBenh_CSTN_TV.TenCD = HTC.Business.CategoryList.DMChucDanh.GetDMChucDanh(_KhamBenh_CSTN_TV.MaCD).TenCD;
                    //_KhamBenh_CSTN_TV.TenCV = HTC.Business.CategoryList.DMChucVu.GetDMChucVu(_KhamBenh_CSTN_TV.MaCv).TenCD;

                    //_KhamBenh_CSTN_TV.MaMay = ,_maMay ,;
                    ////Convert.ToDateTime(_KhamBenh_CSTN_TV.NgaySD) = System.DateTime.Now;
                    //_KhamBenh_CSTN_TV.NguoiSD = HTC.ShareVariables.pub_sNguoiSD;
                    //byte _count = 0;
                    //_count = (byte)this.Items.Count;
                    //_KhamBenh_CSTN_TV.STT = ++_count;

                    this.Add(_KhamBenh_CSTN_TV);
                //}
                //else
                //{
                //    _KhamBenh_CSTN_TV.TenCD = HTC.Business.CategoryList.DMChucDanh.GetDMChucDanh(_KhamBenh_CSTN_TV.MaCD).TenCD;
                //    //_KhamBenh_CSTN_TV.TenCV = HTC.Business.CategoryList.DMVaitro.GetDMChucVu(_KhamBenh_CSTN_TV.MaCv).TenCD;

                //    _KhamBenh_CSTN_TV.MaMay = ,_maMay ,;
                //    //Convert.ToDateTime(_KhamBenh_CSTN_TV.NgaySD) = System.DateTime.Now;
                //    _KhamBenh_CSTN_TV.NguoiSD = HTC.ShareVariables.pub_sNguoiSD;

                //    _KhamBenh_CSTN_TV.STT = 1;
                //    this.Add(_KhamBenh_CSTN_TV);
                //}
            }
           
           return _KhamBenh_CSTN_TV;
        }
        protected override object AddNewCore()
        {
            KhamBenh_CSTN_TV item = KhamBenh_CSTN_TV.NewKhamBenh_CSTN_TV();
            Add(item);
            return item;
        }

        
        public void RemoveTo(KhamBenh_CSTN_TV obj) //xoa 1 KhamBenh_CSTN_TV
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);
                   
        }
        public bool Contains(string MaSoKham)
        {
            foreach (KhamBenh_CSTN_TV obj in this)
                if ((obj.MaSoKham == MaSoKham) && (obj.Huy = false))
                    return true;
            return false;
        }
       
        public bool Containss(string MaNV)
        {
            foreach (KhamBenh_CSTN_TV obj in this)
                if ((obj.MaNV == MaNV) && (obj.Huy == false))
                    return true;
            return false;
        }


        public bool ContainsDeleted(string MaSoKham)
        {
            foreach (KhamBenh_CSTN_TV obj in DeletedList)
                if (obj.MaSoKham == MaSoKham)
                    return true;
            return false;
        }
        public void UpdatedTo(KhamBenh_CSTN_TV _KhamBenh_CSTN_TV)
        {
            _KhamBenh_CSTN_TV.HoTen = HTC.Business.CategoryList.DMNhanVien.GetDMNhanVien(_KhamBenh_CSTN_TV.MaNV).HoTen;     
            _KhamBenh_CSTN_TV.STT = this.Items[this.IndexOf(_KhamBenh_CSTN_TV)].STT;
            this.Items[this.IndexOf(_KhamBenh_CSTN_TV)] = _KhamBenh_CSTN_TV;
        }
        public KhamBenh_CSTN_TV GetTo(decimal STT) //
        {
            foreach (KhamBenh_CSTN_TV obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static KhamBenh_CSTN_TVList NewKhamBenh_CSTN_TVList()
        {
            return new KhamBenh_CSTN_TVList();
        }

        internal static KhamBenh_CSTN_TVList GetKhamBenh_CSTN_TVList(SafeDataReader dr)
        {
            return new KhamBenh_CSTN_TVList(dr);
        }

        private KhamBenh_CSTN_TVList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private KhamBenh_CSTN_TVList(SafeDataReader dr)
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
                
                this.Add(KhamBenh_CSTN_TV.GetKhamBenh_CSTN_TV(dr));/////////
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(KhamBenh_CSTN packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (KhamBenh_CSTN_TV item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (KhamBenh_CSTN_TV item in this)
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
