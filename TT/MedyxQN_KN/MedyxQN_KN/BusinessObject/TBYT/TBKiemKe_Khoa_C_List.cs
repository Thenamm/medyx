using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
////
using HTC.Business;
using HTC.Business.CategoryList  ;
 using System.Windows.Forms;

namespace HTC.Business.TBYT
{
    [Serializable()]
    public class TBKiemKe_Khoa_C_List : BusinessListBase<TBKiemKe_Khoa_C_List, TBKiemKe_Khoa_C>
    {
        #region State Fields
        public decimal _TongTien = 0;
        //public decimal _TongTTCTT = 0;
        //public decimal _TongBH = 0;
        //public decimal _TongBHCTT = 0;
        #endregion

        #region Business Methods

        public TBKiemKe_Khoa_C this[string MaKK]
        {
            get
            {
                foreach (TBKiemKe_Khoa_C obj in this)
                    if (obj.MAKK.Equals(MaKK))
                        return obj;
                return null;
            }
        }
        public TBKiemKe_Khoa_C this[decimal STT]
        {
            get
            {
                foreach (TBKiemKe_Khoa_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public void NewTo(string MaKK)
        {
            if (!Contains(MaKK))
            {
                TBKiemKe_Khoa_C obj = TBKiemKe_Khoa_C.NewTBKiemKe_Khoa_C(MaKK);
                int _count;
                _count = this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public TBKiemKe_Khoa_C NewTo()
        {

              TBKiemKe_Khoa_C obj = TBKiemKe_Khoa_C.NewTBKiemKe_Khoa_C();
              return obj;
               
        }
        public void NewTo(TBKiemKe_Khoa_C _TBKiemKe_Khoa_C) 
        {
            if (!Containss(_TBKiemKe_Khoa_C.MaTBC, _TBKiemKe_Khoa_C.SerialNo, _TBKiemKe_Khoa_C.Model, _TBKiemKe_Khoa_C.Huy))
            {
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    _count = this.Items.Count;
                    _TBKiemKe_Khoa_C.STT = ++_count;
                    this.Add(_TBKiemKe_Khoa_C);
                }
                else
                {
                    _TBKiemKe_Khoa_C.STT = 1;
                    this.Add(_TBKiemKe_Khoa_C);
                }
            }
            //else
               //MessageBox.Show("D?ch v? này dã du?c ch?n r?i!");
               //throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public TBKiemKe_Khoa_C AssignTo(DMTBYT _DMTBYT)
        {
            if (!Contains(_DMTBYT.MaTB))
            {
                TBKiemKe_Khoa_C obj = TBKiemKe_Khoa_C.NewTBKiemKe_Khoa_C(_DMTBYT.MaTB);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public TBKiemKe_Khoa_C AssignTo(TBKiemKe_Khoa_C _TBKiemKe_Khoa_C)//add mot hang TBKiemKe_Khoa_C
        {
            if (!Containss(_TBKiemKe_Khoa_C.MaTBC, _TBKiemKe_Khoa_C.SerialNo, _TBKiemKe_Khoa_C.Model, _TBKiemKe_Khoa_C.Huy))
            {
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    _count = this.Items.Count;
                    _TBKiemKe_Khoa_C.STT = ++_count;
                   // _TBKiemKe_Khoa_C.ThanhTien = Convert.ToString( _TBKiemKe_Khoa_C.DonGia * _TBKiemKe_Khoa_C.Soluong *(100 + _TBKiemKe_Khoa_C.Vat )/100);
              //_thanhTien = dr.GetDecimal("DonGia") * dr.GetDecimal("Soluong") * (100 + dr.GetDecimal("vat")) / 100;
                    //_TBPhieuNhap.TongTien = _TBPhieuNhap.TongTien + Convert.ToDecimal(_TBKiemKe_Khoa_C.ThanhTien);
                    //Decimal _tt;
                    //_tt = _TBPhieuNhap.TongTien + Convert.ToDecimal(_TBKiemKe_Khoa_C.ThanhTien);
                    //_TBPhieuNhap.BeginEdit();
                    
                    //_TBPhieuNhap.ApplyEdit();
                    //_TBPhieuNhap.CanWriteProperty("TongTien");
                    //_TBPhieuNhap.TongTien = _tt;
                    this.Add(_TBKiemKe_Khoa_C);
                   // _TBPhieuNhap.TinhLaiTongTien(); 
                }
                else
                {
                    _TBKiemKe_Khoa_C.STT = 1;
                    this.Add(_TBKiemKe_Khoa_C);
                }
            }
           
           return _TBKiemKe_Khoa_C;
        }
        protected override object AddNewCore()
        {
            TBKiemKe_Khoa_C item = TBKiemKe_Khoa_C.NewTBKiemKe_Khoa_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void  RemoveTo(decimal stt) //xoa 1 TBKiemKe_Khoa_C
        //{
           
        //    //foreach (TBKiemKe_Khoa_C obj in this)
        //    //{
        //    //    if (obj.STT == stt)
        //    //    {
        //    //        this.Items.RemoveAt(this.IndexOf(obj));
        //    //        break; 
                   
        //    //    }
        //    //}
        //    //TBKiemKe_Khoa_C obj;
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
        //public void RemoveTo(TBKiemKe_Khoa_C obj) //xoa 1 TBKiemKe_Khoa_C
        //{

        //    //Remove(obj); 
        //    if (obj.IsNew == true)
        //        this.Items.Remove(obj);

        //    else
        //    {
        //        if (obj.IsDirty == false)
        //        {

        //            Remove(obj);
        //        }
        //        else
        //        {
        //            this.Items.Remove(obj);
        //        }
        //    }                
        //}

        public void RemoveTo(TBKiemKe_Khoa_C obj) //xoa 1 TBPhieuNhap_KP
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
            {
                Remove(obj);
            }
               

        }
        public bool Contains(string MaKK)
        {
            foreach (TBKiemKe_Khoa_C obj in this)
                if ((obj.MAKK == MaKK) && (obj.Huy = false))
                    return true;
            return false;
        }
        //public bool Containss(string MaThuoc)
        //{
        //    foreach (TBKiemKe_Khoa_C obj in this)
        //        if ((obj.MaThuoc == MaThuoc) && (obj.Huy = false))
        //            return true;
        //    return false;
        //}
        //public bool Containss(string MaThuoc)
        //{
        //    foreach (TBKiemKe_Khoa_C obj in this)
        //        if (obj.MaThuoc == MaThuoc) 
        //            return true;
        //    return false;
        //}
        public bool Containss(string MaTBC, Boolean Huy)
        {
            foreach (TBKiemKe_Khoa_C obj in this)
                if ((obj.MaTBC == MaTBC) && (obj.Huy == Huy))
                    return true;
            return false;
        }

        public bool Containss(string MaTBC, string serialNo, string model, Boolean Huy)
        {
            foreach (TBKiemKe_Khoa_C obj in this)
                if ((obj.MaTBC == MaTBC) && (obj.Huy == Huy) && (obj.SerialNo == serialNo) && (obj.Model == model))
                    return true;
            return false;
        }
        public bool ContainsDeleted(string MaKK)
        {
            foreach (TBKiemKe_Khoa_C obj in DeletedList)
                if (obj.MAKK == MaKK)
                    return true;
            return false;
        }
        public void UpdatedTo(TBKiemKe_Khoa_C _TBKiemKe_Khoa_C)
        {

            _TBKiemKe_Khoa_C.STT = this.Items[this.IndexOf(_TBKiemKe_Khoa_C)].STT;
            this.Items[this.IndexOf(_TBKiemKe_Khoa_C)] = _TBKiemKe_Khoa_C;
        }
        public TBKiemKe_Khoa_C GetTo(decimal STT) 
        {
            foreach (TBKiemKe_Khoa_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }

        public TBKiemKe_Khoa_C GetTo(String MaKK, String MaTBC) //
        {
            foreach (TBKiemKe_Khoa_C obj in this)
                if ((obj.MAKK == MaKK) && (obj.MaTBC == MaTBC))
                    return obj;
            //return TBKiemKe_Khoa_C.GetTBKiemKe_Khoa_C(MaKK, MaTBCC);
            return null;

        }
        #endregion

        #region Factory Methods

        internal static TBKiemKe_Khoa_C_List NewTBKiemKe_Khoa_C_List()
        {
            return new TBKiemKe_Khoa_C_List();
        }

        internal static TBKiemKe_Khoa_C_List GetTBKiemKe_Khoa_C_List(SafeDataReader dr)
        {
            return new TBKiemKe_Khoa_C_List(dr);
        }

        //internal static TBKiemKe_Khoa_C_List GetTBKiemKe_Khoa_C_List(int i, SafeDataReader dr)
        //{
        //    return new TBKiemKe_Khoa_C_List(i, dr);
        //}

        private TBKiemKe_Khoa_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private TBKiemKe_Khoa_C_List(SafeDataReader dr)
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
            int i=1;
            _TongTien = 0;
            while (dr.Read())
            {
                this.Add(TBKiemKe_Khoa_C.GetTBKiemKe_Khoa_C(i, dr));/////////
                //_TongTien = _TongTien + dr.GetDecimal("DonGia") * dr.GetDecimal("Soluong") * (100 + dr.GetDecimal("vat")) / 100;
                i++;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(TBKiemKe_Khoa packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (TBKiemKe_Khoa_C item in DeletedList)
            {
                item.DeleteSelf(packet);
            }
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (TBKiemKe_Khoa_C item in this)
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
