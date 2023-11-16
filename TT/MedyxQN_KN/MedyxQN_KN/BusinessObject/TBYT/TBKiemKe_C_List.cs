using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
////
using HTC.Business;
using HTC.Business.CategoryList;
 using System.Windows.Forms;

namespace HTC.Business.TBYT
{
    [Serializable()]
    public class TBKiemKe_C_List : BusinessListBase<TBKiemKe_C_List, TBKiemKe_C>
    {
        #region State Fields
        public decimal _TongTien = 0;
        //public decimal _TongTTCTT = 0;
        //public decimal _TongBH = 0;
        //public decimal _TongBHCTT = 0;
        #endregion

        #region Business Methods

        public TBKiemKe_C this[string MaKK]
        {
            get
            {
                foreach (TBKiemKe_C obj in this)
                    if (obj.MAKK.Equals(MaKK))
                        return obj;
                return null;
            }
        }
        public TBKiemKe_C this[decimal STT]
        {
            get
            {
                foreach (TBKiemKe_C obj in this)
                    if (obj.OrderNumber.Equals(STT))
                        return obj;
                return null;
            }
        }
        public void NewTo(string MaKK)
        {
            if (!Contains(MaKK))
            {
                TBKiemKe_C obj = TBKiemKe_C.NewTBKiemKe_C(MaKK);
                int _count;
                _count = this.Items.Count;
                obj.OrderNumber = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public TBKiemKe_C NewTo()
        {

            TBKiemKe_C obj = TBKiemKe_C.NewTBKiemKe_C();
            return obj;

        }
        public void NewTo(TBKiemKe_C _TBKiemKe_C)
        {
            if (!Containss(_TBKiemKe_C.MaTBC, _TBKiemKe_C.Huy))
            {
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    _count = this.Items.Count;
                    _TBKiemKe_C.OrderNumber = ++_count;
                    this.Add(_TBKiemKe_C);
                }
                else
                {
                    _TBKiemKe_C.OrderNumber = 1;
                    this.Add(_TBKiemKe_C);
                }
            }
            //else
            //MessageBox.Show("D?ch v? này dã du?c ch?n r?i!");
            //throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public TBKiemKe_C AssignTo(DMTBYT _DMTBYT)
        {
            if (!Contains(_DMTBYT.MaTB))
            {
                TBKiemKe_C obj = TBKiemKe_C.NewTBKiemKe_C(_DMTBYT.MaTB);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public TBKiemKe_C AssignTo(TBKiemKe_C _TBKiemKe_C, TBKiemKe _TBKiemKe)//add mot hang TBPhieuNhap_C
        {
            if (!Containss(_TBKiemKe_C.MaTBC, _TBKiemKe_C.Huy))
            {
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    _count = this.Items.Count;
                    _TBKiemKe_C.OrderNumber = ++_count;

                    this.Add(_TBKiemKe_C);
                    //_TBPhieuNhap.TinhLaiTongTien(); 
                }
                else
                {
                    _TBKiemKe_C.OrderNumber = 1;
                    this.Add(_TBKiemKe_C);
                }
            }

            return _TBKiemKe_C;
        }
        protected override object AddNewCore()
        {
            TBKiemKe_C item = TBKiemKe_C.NewTBKiemKe_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }


        public void RemoveTo(TBKiemKe_C obj) //xoa 1 phieu kk
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
            {

                this.Items.Remove(obj);
                if (DeletedList.Contains(obj) == false)
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
        public bool Contains(string MaKK)
        {
            foreach (TBKiemKe_C obj in this)
                if ((obj.MAKK == MaKK) && (obj.Huy = false))
                    return true;
            return false;
        }

        public bool Containss(string MaTB, Boolean Huy)
        {
            foreach (TBKiemKe_C obj in this)
                if ((obj.MaTBC == MaTB) && (obj.Huy == Huy))
                    return true;
            return false;
        }


        public bool ContainsDeleted(string MaKK)
        {
            foreach (TBKiemKe_C obj in DeletedList)
                if (obj.MAKK == MaKK)
                    return true;
            return false;
        }
        public void UpdatedTo(TBKiemKe_C _TBKiemKe_C)
        {

            _TBKiemKe_C.OrderNumber = this.Items[this.IndexOf(_TBKiemKe_C)].OrderNumber;
            this.Items[this.IndexOf(_TBKiemKe_C)] = _TBKiemKe_C;
        }
        public TBKiemKe_C GetTo(decimal OrderNumber)
        {
            foreach (TBKiemKe_C obj in this)
                if (obj.OrderNumber == OrderNumber)
                    return obj;
            return null;

        }

        public TBKiemKe_C GetTo(String maKK, Int32 STT) //
        {
            foreach (TBKiemKe_C obj in this)
                if ((obj.MAKK== maKK) && (obj.STT == STT))
                    return obj;
            return null;

        }
        #endregion

        #region Factory Methods

        internal static TBKiemKe_C_List NewTBKiemKe_C_List()
        {
            return new TBKiemKe_C_List();
        }

        internal static TBKiemKe_C_List GetTBKiemKe_C_List(SafeDataReader dr)
        {
            return new TBKiemKe_C_List(dr);
        }

        //internal static TBPhieuNhap_C_List GetTBPhieuNhap_C_List(int i, SafeDataReader dr)
        //{
        //    return new TBPhieuNhap_C_List(i, dr);
        //}

        private TBKiemKe_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private TBKiemKe_C_List(SafeDataReader dr)
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
            byte i = 1;
            _TongTien = 0;
            while (dr.Read())
            {
                this.Add(TBKiemKe_C.GetTBKiemKe_C(i, dr));/////////
                i++;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(TBKiemKe packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (TBKiemKe_C item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (TBKiemKe_C item in this)
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
