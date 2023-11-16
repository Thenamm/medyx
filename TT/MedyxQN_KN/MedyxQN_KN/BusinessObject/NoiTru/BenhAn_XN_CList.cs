using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;
////
using HTC.Business.CategoryList;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhAn_XN_CList : BusinessListBase<BenhAn_XN_CList, BenhAn_XN_C>
    {
        #region Business Methods

        public BenhAn_XN_C this[Decimal STT]
        {
            get
            {
                foreach (BenhAn_XN_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public BenhAn_XN_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public void NewTo(string MaBA)
        {
            if (!Contains(MaBA))
            {
                BenhAn_XN_C obj = BenhAn_XN_C.NewBenhAn_XN_C(MaBA);
                int _count = 0;
                _count = this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public BenhAn_XN_C NewTo()
        {

            BenhAn_XN_C obj = BenhAn_XN_C.NewBenhAn_XN_C();
            return obj;

        }

        public void NewTo(BenhAn_XN_C _BenhAn_XN_C)
        {
            if (!Containss(_BenhAn_XN_C.MaDV  , _BenhAn_XN_C.Huy ))
            {
                if (this.Items.Count > 0)
                {
                    int _count=0;
                    _count = this.Items.Count;
                    _BenhAn_XN_C.STTCS = ++_count;
                    this.Add(_BenhAn_XN_C);
                }
                else
                {
                    _BenhAn_XN_C.STTCS = 1;
                    this.Add(_BenhAn_XN_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public BenhAn_XN_C AssignTo(DMDichVu _DMDichVu)
        {
            if (!Contains(_DMDichVu.MaDV))
            {
                BenhAn_XN_C obj = BenhAn_XN_C.NewBenhAn_XN_C(_DMDichVu.MaDV);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public BenhAn_XN_C AssignTo(BenhAn_XN_C _BenhAn_XN_C)//add mot hang PhieuNhap_C
        {
            if (!Containss(_BenhAn_XN_C.MaDV , _BenhAn_XN_C.Huy))
            {  
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    _count = this.Items.Count;
                   // _BenhAn_XN_C.HanSD = _BenhAn_XN_C.HanSD;
                    _BenhAn_XN_C.STTCS = ++_count;
                    this.Add(_BenhAn_XN_C);
                }
                else
                {
                    _BenhAn_XN_C.STTCS = 1;
                    //_BenhAn_XN_C.HanSD = _BenhAn_XN_C.HanSD;
                    this.Add(_BenhAn_XN_C);
                }
                //Add(_PhieuNhap_C);
               
             }
             return _BenhAn_XN_C;
        }

        protected override object AddNewCore()
        {
            BenhAn_XN_C item = BenhAn_XN_C.NewBenhAn_XN_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(BenhAn_XN_C obj)
        {
            //foreach (BenhAn_XN_C obj in this)
            //{
            //    if (obj.MaBA.Equals(MaBA))
            //    {
            //        Remove(obj);
            //        break;
            //    }
            //}
            if (obj.IsNew==true) 
                this.Items.Remove(obj);
            else Remove(obj );
        }
        public void RemoveTo(decimal  STT)
        {
            foreach (BenhAn_XN_C obj in this)
                if (obj.STT.Equals(STT))
                {
                    this.Items.Remove(obj);
                    break;
                }
        }
        public bool Contains(string MaBA)
        {
            foreach (BenhAn_XN_C obj in this)
                if ((obj.MaBA == MaBA) && (obj.Huy = false))
                    return true;
            return false;
        }
        public BenhAn_XN_C Containss(string MaCS)
        {
            foreach (BenhAn_XN_C obj in this)
                if ((obj.MaCS == MaCS) )
                    return obj;
            return null;
        }
        public bool Containss(string MaDV, Boolean Huy)
        {
            foreach (BenhAn_XN_C  obj in this)
                if ((obj.MaDV == MaDV) && (obj.Huy = false))
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaBA, int stt,int sttkhoa)
        {
            foreach (BenhAn_XN_C obj in DeletedList)
                if ((obj.MaBA == MaBA) && (obj.STT == stt) && (obj.STTKhoa == sttkhoa)  )
                    return true;
            return false;
        }

        public void UpdatedTo(BenhAn_XN_C _BenhAn_XN_C)
        {

            _BenhAn_XN_C.STT = this.Items[this.IndexOf(_BenhAn_XN_C)].STT;
           this.Items[this.IndexOf(_BenhAn_XN_C)] = _BenhAn_XN_C;
        }

        public BenhAn_XN_C GetTo(decimal STTCS)
        {
            foreach (BenhAn_XN_C obj in this)
                if (obj.STTCS == STTCS)
                    return obj;
            return null;
                
        }

        #endregion

        #region Factory Methods

        internal static BenhAn_XN_CList NewBenhAn_XN_CList()
        {
            return new BenhAn_XN_CList();
        }

        internal static BenhAn_XN_CList GetBenhAn_XN_CList(SafeDataReader dr)
        {
            return new BenhAn_XN_CList(dr);
        }

        private BenhAn_XN_CList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private BenhAn_XN_CList(SafeDataReader dr)
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
                this.Add(BenhAn_XN_C.GetBenhAn_XN_C(dr));
            RaiseListChangedEvents = true; 
        }

        internal void Update(BenhAn_XN packet)
        {
            RaiseListChangedEvents = false;
            foreach (BenhAn_XN_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (BenhAn_XN_C item in this)
            {
                if (item.IsNew)
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; 
        }

        #endregion
    }
}