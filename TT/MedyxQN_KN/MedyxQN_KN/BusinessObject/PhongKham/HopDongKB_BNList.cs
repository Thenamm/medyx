using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;
//

 //using System.Windows.Forms;

namespace HTC.Business.PhongKham
{
    [Serializable()]
    public class HopDongKB_BNList : BusinessListBase<HopDongKB_BNList, HopDongKB_BN>
    {
        #region Business Methods
        public HopDongKB_BN this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public HopDongKB_BN this[string MaHD]
        {
            get
            {
                foreach (HopDongKB_BN obj in this)
                    if (obj.MaHD.Equals(MaHD))
                        return obj;
                return null;
            }
        }

       
        public HopDongKB_BN NewTo()
            {
           
              HopDongKB_BN obj = HopDongKB_BN.NewHopDongKB_BN();
              return obj;
               
        }
      
    
        public HopDongKB_BN AssignTo(HopDongKB_BN _HopDongKB_BN)//add mot hang PhieuNhap_C
        {
            
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    int _count1 = 0;
                    _count = (int)this.Items.Count;
                    _count1 = (int)this.Items.Count;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    _HopDongKB_BN.OrderNumber = ++_count;
                    _HopDongKB_BN.STT = ++_count1;
                    _HopDongKB_BN.MaHD = this.Items[0].MaHD;
                    this.Add(_HopDongKB_BN);
                }
                else
                {
                    _HopDongKB_BN.OrderNumber = 1;
                    _HopDongKB_BN.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_HopDongKB_BN);
                }
            
            return _HopDongKB_BN;
        }

        protected override object AddNewCore()
        {
            HopDongKB_BN item = HopDongKB_BN.NewHopDongKB_BN();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

    
        public void RemoveTo(Decimal stt, string MaHD)
        {
            foreach (HopDongKB_BN obj in this)
            {
                if (obj.MaHD.Equals(MaHD) && obj.STT == stt)
                {
                   //this.Items.Remove(obj);
                    Remove(obj);
                    break;
                }
            }
        }
        
        //public void Remove(string madv, int stt)
        //{
        //    foreach (DMDichVu_VT item in this)
        //    {
        //        if ((item.MaDV == madv) && (item.STT == stt))
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}
        public void RemoveTo(HopDongKB_BN obj) //xoa 1 PhieuNhap_C
        {
            if (obj.IsNew == true)
               this.Items.Remove(obj);
            
            else
                Remove(obj);
            //this.Items.Remove(obj);
        }

        public bool Contains(string MaHD)
        {
            foreach (HopDongKB_BN obj in this)
                if (obj.MaHD == MaHD )
                    return true;
            return false;
        }
        
        public bool ContainsDeleted(string MaHD)
        {
            foreach (HopDongKB_BN obj in DeletedList)
                if (obj.MaHD == MaHD)
                    return true;
            return false;
        }

        public void UpdatedTo(HopDongKB_BN _HopDongKB_BN)
        {

            _HopDongKB_BN.STT = this.Items[this.IndexOf(_HopDongKB_BN)].STT;
           this.Items[this.IndexOf(_HopDongKB_BN)] = _HopDongKB_BN;
        }
        public HopDongKB_BN GetTo(decimal STT)
        {
            foreach (HopDongKB_BN obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        public HopDongKB_BN GetTo(decimal STT, String MaHD)
        {
            foreach (HopDongKB_BN obj in this)
                if ((obj.STT == STT) && (obj.MaHD == MaHD))
                    return obj;
            return null;

        }
        #endregion

        #region Factory Methods

        internal static HopDongKB_BNList NewHopDongKB_BNList()
        {
            return new HopDongKB_BNList();
        }

        internal static HopDongKB_BNList GetHopDongKB_BNList(SafeDataReader dr)
        {
            return new HopDongKB_BNList(dr);
        }

        private HopDongKB_BNList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private HopDongKB_BNList(SafeDataReader dr)
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
                this.Add(HopDongKB_BN.GetHopDongKB_BN(dr, i));
                i++;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(HopDongKB packet)
        {
            RaiseListChangedEvents = false;
            foreach (HopDongKB_BN item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (HopDongKB_BN item in this)
            {
                if ((item.IsNew) )
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        
       

        #endregion
    }
}
