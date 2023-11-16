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
    public class HoiChan_TVList : BusinessListBase<HoiChan_TVList, HoiChan_TV>
    {
         #region Business Methods

        public HoiChan_TV this[string MaHC]
        {
            get
            {
                foreach (HoiChan_TV obj in this)
                    if (obj.MaHC.Equals(MaHC))
                        return obj;
                return null;
            }
        }
        public HoiChan_TV this[decimal STT]
        {
            get
            {
                foreach (HoiChan_TV obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public HoiChan_TV this[int i]
        {
            get
            {
                return this.Items[i];
            }
        }
        public void NewTo(string MaHC)
        {
            if (!Contains(MaHC))
            {
                HoiChan_TV obj = HoiChan_TV.NewHoiChan_TV(MaHC);
                byte _count = 0;
                _count = (byte)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public HoiChan_TV NewTo()//ham khoi tao doi tuong Phieu nhap
        {

              HoiChan_TV obj = HoiChan_TV.NewHoiChan_TV();
              return obj;
               
        }
        public void NewTo(HoiChan_TV _HoiChan_TV) //moi sua
        {
            if (!Contains(_HoiChan_TV.MaHC))
            {
                if (this.Items.Count > 0)
                {
                    byte _count = 0;
                    _count = (byte)this.Items.Count;
                    _HoiChan_TV.STT = ++_count;
                    this.Add(_HoiChan_TV);
                }
                else
                {
                    _HoiChan_TV.STT = 1;
                    this.Add(_HoiChan_TV);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        //public HoiChan_TV AssignTo(DMNhanVien _DMNhanVien)
        //{
        //    if (!Contains(_DMNhanVien.MaNV))
        //    {
        //        HoiChan_TV obj = HoiChan_TV.NewHoiChan_TV(_DMNhanVien.MaNV);
        //        return obj;
        //    }
        //    else
        //        throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        //}
        public HoiChan_TV AssignTo(HoiChan_TV _HoiChan_TV)//add mot hang HoiChan_TV
        {
            if (!Containss(_HoiChan_TV.MaNV))
            {
                //if (this.Items.Count > 0)
                //{
                    _HoiChan_TV.TenCD = HTC.Business.CategoryList.DMChucDanh.GetDMChucDanh(_HoiChan_TV.MaCD).TenCD;
                    //_HoiChan_TV.TenCV = HTC.Business.CategoryList.DMChucVu.GetDMChucVu(_HoiChan_TV.MaCv).TenCD;

                    //_HoiChan_TV.MaMay = ,_maMay ,;
                    ////Convert.ToDateTime(_HoiChan_TV.NgaySD) = System.DateTime.Now;
                    //_HoiChan_TV.NguoiSD = HTC.ShareVariables.pub_sNguoiSD;
                    //byte _count = 0;
                    //_count = (byte)this.Items.Count;
                    //_HoiChan_TV.STT = ++_count;

                    this.Add(_HoiChan_TV);
                //}
                //else
                //{
                //    _HoiChan_TV.TenCD = HTC.Business.CategoryList.DMChucDanh.GetDMChucDanh(_HoiChan_TV.MaCD).TenCD;
                //    //_HoiChan_TV.TenCV = HTC.Business.CategoryList.DMVaitro.GetDMChucVu(_HoiChan_TV.MaCv).TenCD;

                //    _HoiChan_TV.MaMay = ,_maMay ,;
                //    //Convert.ToDateTime(_HoiChan_TV.NgaySD) = System.DateTime.Now;
                //    _HoiChan_TV.NguoiSD = HTC.ShareVariables.pub_sNguoiSD;

                //    _HoiChan_TV.STT = 1;
                //    this.Add(_HoiChan_TV);
                //}
            }
           
           return _HoiChan_TV;
        }
        protected override object AddNewCore()
        {
            HoiChan_TV item = HoiChan_TV.NewHoiChan_TV();
            Add(item);
            return item;
        }

        
        public void RemoveTo(HoiChan_TV obj) //xoa 1 HoiChan_TV
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);
                   
        }
        public bool Contains(string MaHC)
        {
            foreach (HoiChan_TV obj in this)
                if ((obj.MaHC == MaHC) && (obj.Huy = false))
                    return true;
            return false;
        }
       
        public bool Containss(string MaNV)
        {
            foreach (HoiChan_TV obj in this)
                if ((obj.MaNV == MaNV) && (obj.Huy == false))
                    return true;
            return false;
        }


        public bool ContainsDeleted(string MaHC)
        {
            foreach (HoiChan_TV obj in DeletedList)
                if (obj.MaHC == MaHC)
                    return true;
            return false;
        }
        public void UpdatedTo(HoiChan_TV _HoiChan_TV)
        {
            _HoiChan_TV.HoTen = HTC.Business.CategoryList.DMNhanVien.GetDMNhanVien(_HoiChan_TV.MaNV).HoTen;     
            _HoiChan_TV.STT = this.Items[this.IndexOf(_HoiChan_TV)].STT;
            this.Items[this.IndexOf(_HoiChan_TV)] = _HoiChan_TV;
        }
        public HoiChan_TV GetTo(decimal STT) //
        {
            foreach (HoiChan_TV obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static HoiChan_TVList NewHoiChan_TVList()
        {
            return new HoiChan_TVList();
        }

        internal static HoiChan_TVList GetHoiChan_TVList(SafeDataReader dr)
        {
            return new HoiChan_TVList(dr);
        }

        private HoiChan_TVList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private HoiChan_TVList(SafeDataReader dr)
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
                
                this.Add(HoiChan_TV.GetHoiChan_TV(dr));/////////
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(HoiChan packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (HoiChan_TV item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (HoiChan_TV item in this)
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
