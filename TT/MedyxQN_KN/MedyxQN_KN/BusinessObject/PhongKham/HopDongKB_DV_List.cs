using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;
//


namespace HTC.Business.PhongKham
{
    [Serializable()]
    public class HopDongKB_DV_List : BusinessListBase<HopDongKB_DV_List, HopDongKB_DV>
    {
        private HopDongKB_DV obj;
        #region Business Methods

        public HopDongKB_DV this[int OrderNumber]
        {
            get
            {
                foreach (HopDongKB_DV obj in this)
                    if (obj.OrderNumber == OrderNumber)
                        return obj;

                return null;
            }
        }

        //public void NewTo(string MaHD)
        //{
        //    if (!Contains(MaHD))
        //    {
        //        HopDongKB_DV obj = HopDongKB_DV.NewHopDongKB_DV(MaHD);
        //        int _count = 0;
        //        if ((decimal)this.Items.Count >0)
        //        //_count = this[(decimal)this.Items.Count-1].STT;
        //            _count = this.Items.Count - 1 ;
        //        obj.STT = ++_count;
        //        this.Add(obj);
        //    }
        //    else
        //        throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        //}

     
        public HopDongKB_DV NewTo()
        {
           
              HopDongKB_DV obj = HopDongKB_DV.NewHopDongKB_DV();
              return obj;
               
        }
        public void NewTo(HopDongKB_DV _HopDongKB_DV)
        {
            if (!Contains(_HopDongKB_DV.MaDV))
            {
                if (this.Items.Count > 0)
                {
                    int _count=0;
                    _count = (int)this.Items.Count;
                    _HopDongKB_DV.STT = ++_count;
                    this.Add(_HopDongKB_DV);
                }
                else
                {
                    _HopDongKB_DV.STT = 1;
                    this.Add(_HopDongKB_DV);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
       
        public HopDongKB_DV AssignTo(HopDongKB_DV _HopDongKB_DV)//add mot hang PhieuNhap_C
        {
            if (!Containss(_HopDongKB_DV.MaDV, _HopDongKB_DV.Huy,_HopDongKB_DV.LoaiDV  ))
            {
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    int _count1 = 0;
                    
                   
                    if ((int)this.Items.Count > 0)
                    {
                        _count1 = this[(int)this.Items.Count ].STT;
                        _count = this[(int)this.Items.Count ].OrderNumber;
                    }
                    _HopDongKB_DV.OrderNumber = ++_count;
                    _HopDongKB_DV.STT = ++_count1;
                    this.Add(_HopDongKB_DV);
                }
                else
                {
                    _HopDongKB_DV.OrderNumber = 1;
                    _HopDongKB_DV.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_HopDongKB_DV);
                }
            }

            return _HopDongKB_DV;
        }

        protected override object AddNewCore()
        {
            HopDongKB_DV item = HopDongKB_DV.NewHopDongKB_DV();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }


        //}
       
        public void RemoveTo(HopDongKB_DV obj) //xoa 1 PhieuNhap_C
        {
            if (obj.IsNew == true)
            {
                this.Items.Remove(obj);
                //obj.SoLuong = 0;
            }
            else
            {
                Remove(obj);
                
            }
            
        }

        public bool Contains(string MaHD)
        {
            foreach (HopDongKB_DV obj in this)
                if ((obj.MaHD == MaHD) && (obj.Huy = false))
                    return true;
            return false;
        }
        public bool Containss(string MaDV, Boolean Huy,byte _loaidv)
        {
            foreach (HopDongKB_DV obj in this)
                if ((obj.MaDV == MaDV) && (obj.Huy == Huy)&&obj.LoaiDV ==_loaidv  )
                    return true;
            return false;
        }
        public HopDongKB_DV ContainsMa(string MaDV, Boolean Huy, byte _loaidv)
        {
            foreach (HopDongKB_DV obj in this)
                if ((obj.MaDV == MaDV) && (obj.Huy == Huy) && obj.LoaiDV == _loaidv)
                    return obj;
            return null;
        }


        public bool ContainsDeleted(string MaHD)
        {
            foreach (HopDongKB_DV obj in DeletedList)
                if (obj.MaHD == MaHD)
                    return true;
            return false;
        }

        public void UpdatedTo(HopDongKB_DV _HopDongKB_DV)
        {

            _HopDongKB_DV.STT = this.Items[this.IndexOf(_HopDongKB_DV)].STT;
           this.Items[this.IndexOf(_HopDongKB_DV)] = _HopDongKB_DV;
        }
        public HopDongKB_DV GetTo(decimal STT)
        {
            foreach (HopDongKB_DV obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static HopDongKB_DV_List NewHopDongKB_DV_List()
        {
            return new HopDongKB_DV_List();
        }

        internal static HopDongKB_DV_List GetHopDongKB_DV_List(SafeDataReader dr)
        {
            return new HopDongKB_DV_List(dr);
        }

        private HopDongKB_DV_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private HopDongKB_DV_List(SafeDataReader dr)
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
                this.Add(HopDongKB_DV.GetHopDongKB_DV(dr, i));
                i++;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(HopDongKB packet)
        {
            RaiseListChangedEvents = false;
            foreach (HopDongKB_DV item in DeletedList)
                if (item .LoaiDV !=3)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (HopDongKB_DV item in this)
            {
                if (item.LoaiDV != 3)
                {
                    if ((item.IsNew))// && packet.MaHD =="")
                        item.Insert(packet);
                    else
                        item.Update(packet);
                }
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        
       

        #endregion
    }
}