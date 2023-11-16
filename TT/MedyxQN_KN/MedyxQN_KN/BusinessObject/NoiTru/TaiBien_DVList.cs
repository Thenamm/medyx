using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
////
using HTC.Business;
using HTC.Business.CategoryList  ;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class TaiBien_DVList : BusinessListBase<TaiBien_DVList, TaiBien_DV>
    {
         #region Business Methods

        public TaiBien_DV this[string MaTB]
        {
            get
            {
                foreach (TaiBien_DV obj in this)
                    if (obj.MaTB.Equals(MaTB))
                        return obj;
                return null;
            }
        }
        public TaiBien_DV this[decimal STT]
        {
            get
            {
                foreach (TaiBien_DV obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public void NewTo(string MaTB)
        {
            if (!Contains(MaTB))
            {
                TaiBien_DV obj = TaiBien_DV.NewTaiBien_DV(MaTB);
                byte _count = 0;
                _count = (byte)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public TaiBien_DV NewTo()//ham khoi tao doi tuong Phieu nhap
        {

              TaiBien_DV obj = TaiBien_DV.NewTaiBien_DV();
              return obj;
               
        }
        public void NewTo(TaiBien_DV _TaiBien_DV) //moi sua
        {
            if (!Contains(_TaiBien_DV.MaTB))
            {
                if (this.Items.Count > 0)
                {
                    byte _count = 0;
                    _count = (byte)this.Items.Count;
                    _TaiBien_DV.STT = ++_count;
                    this.Add(_TaiBien_DV);
                }
                else
                {
                    _TaiBien_DV.STT = 1;
                    this.Add(_TaiBien_DV);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        //public TaiBien_DV AssignTo(DMNhanVien _DMNhanVien)
        //{
        //    if (!Contains(_DMNhanVien.MaNV))
        //    {
        //        TaiBien_DV obj = TaiBien_DV.NewTaiBien_DV(_DMNhanVien.MaNV);
        //        return obj;
        //    }
        //    else
        //        throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        //}
        public TaiBien_DV AssignTo(TaiBien_DV _TaiBien_DV)//add mot hang TaiBien_DV
        {
            if (!Containss(_TaiBien_DV.MaDV))
            {
                if (this.Items.Count > 0)
                {
                   // _TaiBien_DV.TenCD = HTC.Business.CategoryList.DMChucDanh.GetDMChucDanh(_TaiBien_DV.MaCD).TenCD;
                    //_TaiBien_DV.TenCV = HTC.Business.CategoryList.DMChucVu.GetDMChucVu(_TaiBien_DV.MaCv).TenCD;

                    //_TaiBien_DV.MaMay = ,_maMay ,;
                    ////Convert.ToDateTime(_TaiBien_DV.NgaySD) = System.DateTime.Now;
                    //_TaiBien_DV.NguoiSD = HTC.ShareVariables.pub_sNguoiSD;
                    byte _count = 0;
                    _count = (byte)this.Items.Count;
                    _TaiBien_DV.STT = ++_count;

                    this.Add(_TaiBien_DV);
                }
                else
                {
                //    _TaiBien_DV.TenCD = HTC.Business.CategoryList.DMChucDanh.GetDMChucDanh(_TaiBien_DV.MaCD).TenCD;
                //    //_TaiBien_DV.TenCV = HTC.Business.CategoryList.DMVaitro.GetDMChucVu(_TaiBien_DV.MaCv).TenCD;

                //    _TaiBien_DV.MaMay = ,_maMay ,;
                ////    //Convert.ToDateTime(_TaiBien_DV.NgaySD) = System.DateTime.Now;
                //    _TaiBien_DV.NguoiSD = HTC.ShareVariables.pub_sNguoiSD;

                    _TaiBien_DV.STT = 1;
                    this.Add(_TaiBien_DV);
                }
            }
           
           return _TaiBien_DV;
        }
        protected override object AddNewCore()
        {
            TaiBien_DV item = TaiBien_DV.NewTaiBien_DV();
            Add(item);
            return item;
        }

        
        public void RemoveTo(TaiBien_DV obj) //xoa 1 TaiBien_DV
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);
                   
        }
        public bool Contains(string MaTB)
        {
            foreach (TaiBien_DV obj in this)
                if ((obj.MaTB == MaTB) && (obj.Huy = false))
                    return true;
            return false;
        }
       
        public bool Containss(string MaDV)
        {
            foreach (TaiBien_DV obj in this)
                if ((obj.MaDV == MaDV) && (obj.Huy == false))
                    return true;
            return false;
        }


        public bool ContainsDeleted(string MaTB)
        {
            foreach (TaiBien_DV obj in DeletedList)
                if (obj.MaTB == MaTB)
                    return true;
            return false;
        }
        public void UpdatedTo(TaiBien_DV _TaiBien_DV)
        {
            //_TaiBien_DV.HoTen = HTC.Business.CategoryList.DMNhanVien.GetDMNhanVien(_TaiBien_DV.MaNV).HoTen;     
            //_TaiBien_DV.STT = this.Items[this.IndexOf(_TaiBien_DV)].STT;
            this.Items[this.IndexOf(_TaiBien_DV)] = _TaiBien_DV;
        }
        public TaiBien_DV GetTo(decimal STT) //
        {
            foreach (TaiBien_DV obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static TaiBien_DVList NewTaiBien_DVList()
        {
            return new TaiBien_DVList();
        }

        internal static TaiBien_DVList GetTaiBien_DVList(SafeDataReader dr)
        {
            return new TaiBien_DVList(dr);
        }

        private TaiBien_DVList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private TaiBien_DVList(SafeDataReader dr)
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
            {
                this.Add(TaiBien_DV.GetTaiBien_DV(dr));/////////
                
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(TaiBien  packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (TaiBien_DV item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (TaiBien_DV item in this)
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
