using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;
//
using HTC.Business.CategoryList;

namespace HTC.Business.Duoc
{
    [Serializable()]
    public class XuatTra_C_List : BusinessListBase<XuatTra_C_List, XuatTra_C>
    {
        #region Business Methods
        public XuatTra_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public XuatTra_C this[string MaPXT]
        {
            get
            {
                foreach (XuatTra_C obj in this)
                    if (obj.MaPXT.Equals(MaPXT))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaPXT)
        {
            if (!Contains(MaPXT))
            {
                XuatTra_C obj = XuatTra_C.NewXuatTra_C(MaPXT);
                decimal _count = 0;
                _count = (decimal)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public XuatTra_C NewTo()
        {
           
              XuatTra_C obj = XuatTra_C.NewXuatTra_C();
              return obj;
               
        }
        public void NewTo(XuatTra_C _XuatTra_C)
        {
            if (!Contains(_XuatTra_C.Mathuoc))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count=0;
                    _count = (decimal)this.Items.Count;
                    _XuatTra_C.STT = ++_count;
                    this.Add(_XuatTra_C);
                }
                else
                {
                    _XuatTra_C.STT = 1;
                    this.Add(_XuatTra_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public XuatTra_C AssignTo(DMThuoc _DMThuoc)
        {
            if (!Contains(_DMThuoc.MaThuoc))
            {
                XuatTra_C obj = XuatTra_C.NewXuatTra_C(_DMThuoc.MaThuoc);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public bool Containss(string MaThuoc, Boolean Huy)
        {
            //foreach (XuatTra_C obj in this)
            //    if ((obj.Mathuoc  == MaThuoc) && (obj.Huy == Huy))
            //        return true;
            return false;
        }
        public bool Containss(string MaThuoc, Boolean Huy, string solo, string  HanSD)
        {
            //foreach (XuatTra_C obj in this)
            //    if (solo !=""&& HanSD !="")
            //    if ((obj.Mathuoc == MaThuoc) && (obj.Huy == Huy) && (obj.SoLo == solo )&& (obj.HanSD == HanSD  ))
            //        return true;
            //    else if (solo == "" && HanSD == "")
            //        if ((obj.Mathuoc == MaThuoc) && (obj.Huy == Huy))
            //            return true;
            return false;
           
        }
        public XuatTra_C AssignTo(XuatTra_C _XuatTra_C)//add mot hang XuatTra_C
        {
            if (!Containss(_XuatTra_C.Mathuoc, _XuatTra_C.Huy, _XuatTra_C.SoLo ,_XuatTra_C.HanSD  ))
            {
                if (this.Items.Count > 0)
                {
                    decimal _count = 0;
                    _count = (decimal)this.Items.Count;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    _XuatTra_C.STT = ++_count;
                    this.Add(_XuatTra_C);
                }
                else
                {
                    _XuatTra_C.STT = 1;
                    //_PhieuNhap_C.HanSDD = _PhieuNhap_C.HanSD;
                    this.Add(_XuatTra_C);
                }
            }
            return _XuatTra_C;
        }
        protected override object AddNewCore()
        {
            XuatTra_C item = XuatTra_C.NewXuatTra_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(int _stt)
        {
            foreach (XuatTra_C obj in this)
            {
                if (obj.STT.Equals(_stt))
                {
                    Remove(obj);
                    break;
                }
            }
        }

        public bool Contains(string MaPXT)
        {
            foreach (XuatTra_C obj in this)
                if ((obj.MaPXT == MaPXT) && (obj.Huy = false))
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaPXT)
        {
            foreach (XuatTra_C obj in DeletedList)
                if (obj.MaPXT == MaPXT)
                    return true;
            return false;
        }

        public void UpdatedTo(XuatTra_C _XuatTra_C)
        {

            _XuatTra_C.STT = this.Items[this.IndexOf(_XuatTra_C)].STT;
           this.Items[this.IndexOf(_XuatTra_C)] = _XuatTra_C;
        }
        public XuatTra_C GetTo(decimal STT)
        {
            foreach (XuatTra_C obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static XuatTra_C_List NewXuatTra_C_List()
        {
            return new XuatTra_C_List();
        }

        internal static XuatTra_C_List GetXuatTra_C_List(SafeDataReader dr)
        {
            return new XuatTra_C_List(dr);
        }

        private XuatTra_C_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private XuatTra_C_List(SafeDataReader dr)
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
                this.Add(XuatTra_C.GetXuatTra_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        internal void Update(XuatTra packet)
        {
            RaiseListChangedEvents = false;
            foreach (XuatTra_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (XuatTra_C item in this)
            {
                if ((item.IsNew))// && item.MaPXT == "")   //MaPXT ==""))
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        

      

        #endregion
    }
}