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
    public class TBPhieuXuat_C_List : BusinessListBase<TBPhieuXuat_C_List, TBPhieuXuat_C>
    {
        #region State Fields
        public decimal _TongTien = 0;
        //public decimal _TongTTCTT = 0;
        //public decimal _TongBH = 0;
        //public decimal _TongBHCTT = 0;
        #endregion

        #region Business Methods

        public TBPhieuXuat_C this[string MaPX]
        {
            get
            {
                foreach (TBPhieuXuat_C obj in this)
                    if (obj.MaPX.Equals(MaPX))
                        return obj;
                return null;
            }
        }
        public TBPhieuXuat_C this[decimal STT]
        {
            get
            {
                foreach (TBPhieuXuat_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public void NewTo(string MaPX)
        {
            if (!Contains(MaPX))
            {
                TBPhieuXuat_C obj = TBPhieuXuat_C.NewTBPhieuXuat_C(MaPX);
                int _count;
                _count = this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public TBPhieuXuat_C NewTo()
        {

              TBPhieuXuat_C obj = TBPhieuXuat_C.NewTBPhieuXuat_C();
              return obj;
               
        }
        public void NewTo(TBPhieuXuat_C _TBPhieuXuat_C) 
        {
            if (!Containss(_TBPhieuXuat_C.MaTBC, _TBPhieuXuat_C.Huy, _TBPhieuXuat_C.Model, _TBPhieuXuat_C.SerialNo))
            {
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    _count = this.Items.Count;
                    _TBPhieuXuat_C.STT = ++_count;
                    this.Add(_TBPhieuXuat_C);
                }
                else
                {
                    _TBPhieuXuat_C.STT = 1;
                    this.Add(_TBPhieuXuat_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public TBPhieuXuat_C AssignTo(DMTBYT _DMTBYT)
        {
            if (!Contains(_DMTBYT.MaTB))
            {
                TBPhieuXuat_C obj = TBPhieuXuat_C.NewTBPhieuXuat_C(_DMTBYT.MaTB);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public TBPhieuXuat_C AssignTo(TBPhieuXuat_C _TBPhieuXuat_C)//add mot hang TBPhieuXuat_C
        {
            if (!Containss(_TBPhieuXuat_C.MaTBC, _TBPhieuXuat_C.Huy, _TBPhieuXuat_C.Model, _TBPhieuXuat_C.SerialNo))
            {
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    _count = this.Items.Count;
                    _TBPhieuXuat_C.STT = ++_count;
                    this.Add(_TBPhieuXuat_C);
                }
                else
                {
                    _TBPhieuXuat_C.STT = 1;
                    this.Add(_TBPhieuXuat_C);
                }
                return _TBPhieuXuat_C;
            }
           
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public TBPhieuXuat_C AssignToNL(TBPhieuXuat_C _TBPhieuXuat_C)//add mot hang TBPhieuXuat_C
        {
            //if (!Containss(_TBPhieuXuat_C.MaTBC, _TBPhieuXuat_C.Huy, _TBPhieuXuat_C.Model, _TBPhieuXuat_C.SerialNo))
            //{
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    _count = this.Items.Count;
                    _TBPhieuXuat_C.STT = ++_count;
                    this.Add(_TBPhieuXuat_C);
                }
                else
                {
                    _TBPhieuXuat_C.STT = 1;
                    this.Add(_TBPhieuXuat_C);
                }
                return _TBPhieuXuat_C;
            //}

            //else
            //    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        protected override object AddNewCore()
        {
            TBPhieuXuat_C item = TBPhieuXuat_C.NewTBPhieuXuat_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        //public void  RemoveTo(decimal stt) //xoa 1 TBPhieuXuat_C
        //{
           
        //    //foreach (TBPhieuXuat_C obj in this)
        //    //{
        //    //    if (obj.STT == stt)
        //    //    {
        //    //        this.Items.RemoveAt(this.IndexOf(obj));
        //    //        break; 
                   
        //    //    }
        //    //}
        //    //TBPhieuXuat_C obj;
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
        //public void RemoveTo(TBPhieuXuat_C obj) //xoa 1 TBPhieuXuat_C
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

        public void RemoveTo(TBPhieuXuat_C obj) //xoa 1 TBPhieuNhap_KP
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
            {
                Remove(obj);
            }
               

        }
        public bool Contains(string MaPX)
        {
            foreach (TBPhieuXuat_C obj in this)
                if ((obj.MaPX == MaPX) && (obj.Huy = false))
                    return true;
            return false;
        }
        //public bool Containss(string MaThuoc)
        //{
        //    foreach (TBPhieuXuat_C obj in this)
        //        if ((obj.MaThuoc == MaThuoc) && (obj.Huy = false))
        //            return true;
        //    return false;
        //}
        //public bool Containss(string MaThuoc)
        //{
        //    foreach (TBPhieuXuat_C obj in this)
        //        if (obj.MaThuoc == MaThuoc) 
        //            return true;
        //    return false;
        //}
        public bool Containss(string MaTBC, Boolean Huy, string Model , string SerialNo)
        {
            foreach (TBPhieuXuat_C obj in this)
                //if ((obj.MaTBC == MaTBC) && (obj.Huy == Huy) && (Convert.ToDecimal(obj.Soluong) == obj.SLycCu))
                if ((obj.MaTBC == MaTBC) && (obj.Huy == Huy) && (obj.Model == Model) && (obj.SerialNo == SerialNo)  )
                    return true;
            return false;
        }


        public bool ContainsDeleted(string MaPX)
        {
            foreach (TBPhieuXuat_C obj in DeletedList)
                if (obj.MaPX == MaPX)
                    return true;
            return false;
        }
        public void UpdatedTo(TBPhieuXuat_C _TBPhieuXuat_C)
        {

            _TBPhieuXuat_C.STT = this.Items[this.IndexOf(_TBPhieuXuat_C)].STT;
            this.Items[this.IndexOf(_TBPhieuXuat_C)] = _TBPhieuXuat_C;
        }
        public TBPhieuXuat_C GetTo(decimal STT) 
        {
            foreach (TBPhieuXuat_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }

        public TBPhieuXuat_C GetTo(String MaPX, String MaTBC) //
        {
            foreach (TBPhieuXuat_C obj in this)
                if ((obj.MaPX == MaPX) && (obj.MaTBC == MaTBC))
                    return obj;
            //return TBPhieuXuat_C.GetTBPhieuXuat_C(MaPX, MaTBCC);
            return null;

        }
        #endregion


        #region Factory Methods

        internal static TBPhieuXuat_C_List NewTBPhieuXuat_C_List()
        {
            return new TBPhieuXuat_C_List();
        }

        internal static TBPhieuXuat_C_List GetTBPhieuXuat_C_List(SafeDataReader dr)
        {
            return new TBPhieuXuat_C_List(dr);
        }

        //internal static TBPhieuXuat_C_List GetTBPhieuXuat_C_List(int i, SafeDataReader dr)
        //{
        //    return new TBPhieuXuat_C_List(i, dr);
        //}

        private TBPhieuXuat_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private TBPhieuXuat_C_List(SafeDataReader dr)
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
                this.Add(TBPhieuXuat_C.GetTBPhieuXuat_C(i, dr));/////////
                //_TongTien = _TongTien + dr.GetDecimal("DonGia") * dr.GetDecimal("Soluong") * (100 + dr.GetDecimal("vat")) / 100;
                i++;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(TBPhieuXuat packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (TBPhieuXuat_C item in DeletedList)
            {
                item.DeleteSelf(packet);
            }
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (TBPhieuXuat_C item in this)
            {
                if (item.IsNew)       
                    item.Insert(packet);           
                else if ((item.IsNew == false) && (item.IsDirty == true))         
                    item.Update(packet);       
            }
          
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(TBNhapTra packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects

            // add/update any current child objects
            foreach (TBPhieuXuat_C item in this)
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
