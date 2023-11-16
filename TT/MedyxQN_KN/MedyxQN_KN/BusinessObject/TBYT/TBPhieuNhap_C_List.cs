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
    public class TBPhieuNhap_C_List : BusinessListBase<TBPhieuNhap_C_List, TBPhieuNhap_C>
    {
        #region State Fields
        public decimal _TongTien = 0;
        //public decimal _TongTTCTT = 0;
        //public decimal _TongBH = 0;
        //public decimal _TongBHCTT = 0;
        #endregion

         #region Business Methods

        public TBPhieuNhap_C this[string MaPN]
        {
            get
            {
                foreach (TBPhieuNhap_C obj in this)
                    if (obj.MaPN.Equals(MaPN))
                        return obj;
                return null;
            }
        }
        public TBPhieuNhap_C this[decimal STT]
        {
            get
            {
                foreach (TBPhieuNhap_C obj in this)
                    if (obj.OrderNumber.Equals(STT))
                        return obj;
                return null;
            }
        }
        public void NewTo(string MaPN)
        {
            if (!Contains(MaPN))
            {
                TBPhieuNhap_C obj = TBPhieuNhap_C.NewTBPhieuNhap_C(MaPN);
                int _count;
                _count = this.Items.Count;
                obj.OrderNumber = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public TBPhieuNhap_C NewTo()
        {

              TBPhieuNhap_C obj = TBPhieuNhap_C.NewTBPhieuNhap_C();
              return obj;
               
        }
        public void NewTo(TBPhieuNhap_C _TBPhieuNhap_C) 
        {
            if (!Containss(_TBPhieuNhap_C.MaTB,_TBPhieuNhap_C.Model,_TBPhieuNhap_C.SerialNo, _TBPhieuNhap_C.Huy))
            {
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    _count = this.Items.Count;
                    _TBPhieuNhap_C.OrderNumber = ++_count;
                    this.Add(_TBPhieuNhap_C);
                }
                else
                {
                    _TBPhieuNhap_C.OrderNumber = 1;
                    this.Add(_TBPhieuNhap_C);
                }
            }
            //else
               //MessageBox.Show("D?ch v? này dã du?c ch?n r?i!");
               //throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public TBPhieuNhap_C AssignTo(DMTBYT _DMTBYT)
        {
            if (!Contains(_DMTBYT.MaTB))
            {
                TBPhieuNhap_C obj = TBPhieuNhap_C.NewTBPhieuNhap_C(_DMTBYT.MaTB);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public TBPhieuNhap_C AssignTo(TBPhieuNhap_C _TBPhieuNhap_C, TBPhieuNhap _TBPhieuNhap)//add mot hang TBPhieuNhap_C
        {
            if (!Containss(_TBPhieuNhap_C.MaTB,_TBPhieuNhap_C.Model,_TBPhieuNhap_C.SerialNo ,_TBPhieuNhap_C.Huy ))
            {
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    _count = this.Items.Count;
                    _TBPhieuNhap_C.OrderNumber = ++_count;
                   // _TBPhieuNhap_C.ThanhTien = Convert.ToString( _TBPhieuNhap_C.DonGia * _TBPhieuNhap_C.Soluong *(100 + _TBPhieuNhap_C.Vat )/100);
              //_thanhTien = dr.GetDecimal("DonGia") * dr.GetDecimal("Soluong") * (100 + dr.GetDecimal("vat")) / 100;
                    //_TBPhieuNhap.TongTien = _TBPhieuNhap.TongTien + Convert.ToDecimal(_TBPhieuNhap_C.ThanhTien);
                    //Decimal _tt;
                    //_tt = _TBPhieuNhap.TongTien + Convert.ToDecimal(_TBPhieuNhap_C.ThanhTien);
                    //_TBPhieuNhap.BeginEdit();
                    
                    //_TBPhieuNhap.ApplyEdit();
                    //_TBPhieuNhap.CanWriteProperty("TongTien");
                    //_TBPhieuNhap.TongTien = _tt;
                    this.Add(_TBPhieuNhap_C);
                    //_TBPhieuNhap.TinhLaiTongTien(); 
                }
                else
                {
                    _TBPhieuNhap_C.OrderNumber = 1;
                    this.Add(_TBPhieuNhap_C);
                }
            }
           
           return _TBPhieuNhap_C;
        }
        protected override object AddNewCore()
        {
            TBPhieuNhap_C item = TBPhieuNhap_C.NewTBPhieuNhap_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void  RemoveTo(decimal stt) //xoa 1 TBPhieuNhap_C
        //{
           
        //    //foreach (TBPhieuNhap_C obj in this)
        //    //{
        //    //    if (obj.STT == stt)
        //    //    {
        //    //        this.Items.RemoveAt(this.IndexOf(obj));
        //    //        break; 
                   
        //    //    }
        //    //}
        //    //TBPhieuNhap_C obj;
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
        //public void RemoveTo(TBPhieuNhap_C obj) //xoa 1 TBPhieuNhap_C
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

        public void RemoveTo(TBPhieuNhap_C obj) //xoa 1 TBPhieuNhap_KP
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
            {
                //if (obj.TBPhieuNhap_KPs.Count > 0)
                //{
                //    int m = obj.TBPhieuNhap_KPs.Count;
                //    //foreach (TBPhieuNhap_KP objkp in obj.TBPhieuNhap_KPs)
                //    //{
                //    //    obj.TBPhieuNhap_KPs.Removeal
                //    //}
                //    for(int i = 0;i < m ;i ++ )                    
                //    {
                //        obj.TBPhieuNhap_KPs.RemoveAt(i); 
                //    }
                //}
                //while (obj.TBPhieuNhap_KPs.Count > 0)
                //{
                //    obj.TBPhieuNhap_KPs.RemoveAt(0);
                //    //DeletedList.Clear();  
                //    //Csla.BusinessListBase<obj.TBPhieuNhap_KPs>.;
                //    //obj.TBPhieuNhap_KPs.it
                //}
                //bj.TBPhieuNhap_KPs.
                //DeletedList.Clear();  
                //obj.
                this.Items.Remove(obj);
                if (DeletedList.Contains(obj)==false)
                {
                    DeletedList.Add(obj);
                    //DeletedList. 
                }
                else
                {
                    this.Items.Remove(obj);
                    DeletedList.Add(obj);
                    //this.Items.RemoveAt(this.IndexOf(obj));
                }
            }
               

        }
        public bool Contains(string MaPN)
        {
            foreach (TBPhieuNhap_C obj in this)
                if ((obj.MaPN == MaPN) && (obj.Huy = false))
                    return true;
            return false;
        }
        //public bool Containss(string MaThuoc)
        //{
        //    foreach (TBPhieuNhap_C obj in this)
        //        if ((obj.MaThuoc == MaThuoc) && (obj.Huy = false))
        //            return true;
        //    return false;
        //}
        //public bool Containss(string MaThuoc)
        //{
        //    foreach (TBPhieuNhap_C obj in this)
        //        if (obj.MaThuoc == MaThuoc) 
        //            return true;
        //    return false;
        //}
        public bool Containss(string MaTB, string SerialNo, string Model, Boolean Huy)
        {
            foreach (TBPhieuNhap_C obj in this)
                if ((obj.MaTB == MaTB) && (obj.Huy == Huy) && (obj.SerialNo == SerialNo) && (obj.Model == Model))
                    return true;
            return false;
        }


        public bool ContainsDeleted(string MaPN)
        {
            foreach (TBPhieuNhap_C obj in DeletedList)
                if (obj.MaPN == MaPN)
                    return true;
            return false;
        }
        public void UpdatedTo(TBPhieuNhap_C _TBPhieuNhap_C)
        {

            _TBPhieuNhap_C.OrderNumber = this.Items[this.IndexOf(_TBPhieuNhap_C)].OrderNumber;
            this.Items[this.IndexOf(_TBPhieuNhap_C)] = _TBPhieuNhap_C;
        }
        public TBPhieuNhap_C GetTo(decimal OrderNumber) 
        {
            foreach (TBPhieuNhap_C obj in this)
                if (obj.OrderNumber == OrderNumber)
                    return obj;
            return null;

        }

        public TBPhieuNhap_C GetTo(String maPN, String maTBC) //
        {
            foreach (TBPhieuNhap_C obj in this)
                if ((obj.MaPN == maPN) && (obj.MaTBC == maTBC))
                    return obj;
            //return TBPhieuNhap_C.GetTBPhieuNhap_C(maPN, maTBC);
            return null;

        }
        #endregion

        #region Factory Methods

        internal static TBPhieuNhap_C_List NewTBPhieuNhap_C_List()
        {
            return new TBPhieuNhap_C_List();
        }

        internal static TBPhieuNhap_C_List GetTBPhieuNhap_C_List(SafeDataReader dr)
        {
            return new TBPhieuNhap_C_List(dr);
        }

        //internal static TBPhieuNhap_C_List GetTBPhieuNhap_C_List(int i, SafeDataReader dr)
        //{
        //    return new TBPhieuNhap_C_List(i, dr);
        //}

        private TBPhieuNhap_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private TBPhieuNhap_C_List(SafeDataReader dr)
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
            byte i=1;
            _TongTien = 0;
            while (dr.Read())
            {
                this.Add(TBPhieuNhap_C.GetTBPhieuNhap_C(i, dr));/////////
                _TongTien = _TongTien + dr.GetDecimal("DonGia") * dr.GetDecimal("Soluong") * (100 + dr.GetDecimal("vat")) / 100;
                i++;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        //internal void Update(TBPhieuNhap packet)///////////
        //{
        //    RaiseListChangedEvents = false;


        //    // add/update any current child objects
        //    foreach (TBPhieuNhap_C item in this)
        //    {
        //        if (item.IsNew)       
        //            item.Insert(packet);           
        //        else if ((item.IsNew == false) && (item.IsDirty == true))         
        //            item.Update(packet);       
        //    }

        //    // update (thus deleting) any deleted child objects
        //    foreach (TBPhieuNhap_C item in DeletedList)
        //    {
        //        //foreach (TBPhieuNhap_KP itemC in item.TBPhieuNhap_KPs.DeletedListKPS)
        //        //{itemC.DeleteSelf(item);}

        //        TBPhieuNhap_KP itemC;
        //        int m = item.TBPhieuNhap_KPs.DeletedListKPS().Length;
        //        for (int i = 0; i < m; i++)
        //        {
        //            //itemC = item.TBPhieuNhap_KPs.DeletedListKPS[i];
        //        }
        //            item.DeleteSelf(packet);
        //    }
        //    // now that they are deleted, remove them from memory too
        //    DeletedList.Clear();

        //    RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        //}
        internal void Update(TBPhieuNhap packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (TBPhieuNhap_C item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (TBPhieuNhap_C item in this)
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
