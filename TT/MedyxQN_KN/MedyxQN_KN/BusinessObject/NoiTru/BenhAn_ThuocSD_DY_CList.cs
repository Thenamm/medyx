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
    public class BenhAn_ThuocSD_DY_CList : BusinessListBase<BenhAn_ThuocSD_DY_CList, BenhAn_ThuocSD_DY_C>
    {
        #region Business Methods

        public BenhAn_ThuocSD_DY_C this[Decimal STT]
        {
            get
            {
                foreach (BenhAn_ThuocSD_DY_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public BenhAn_ThuocSD_DY_C this[int i]
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
                BenhAn_ThuocSD_DY_C obj = BenhAn_ThuocSD_DY_C.NewBenhAn_ThuocSD_DY_C(MaBA);
                int _count = 0;
                _count = this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public BenhAn_ThuocSD_DY_C NewTo()
        {

            BenhAn_ThuocSD_DY_C obj = BenhAn_ThuocSD_DY_C.NewBenhAn_ThuocSD_DY_C();
            return obj;

        }

        public void NewTo(BenhAn_ThuocSD_DY_C _BenhAn_ThuocSD_DY_C)
        {
           
            if (!Containss(_BenhAn_ThuocSD_DY_C.Mathuoc  , _BenhAn_ThuocSD_DY_C.Huy ))
            {
                if (this.Items.Count > 0)
                {
                    int _count=0;
                    _count = this.Items.Count;
                    _BenhAn_ThuocSD_DY_C.STTThuoc = ++_count;
                    this.Add(_BenhAn_ThuocSD_DY_C);
                }
                else
                {
                    _BenhAn_ThuocSD_DY_C.STTThuoc = 1;
                    this.Add(_BenhAn_ThuocSD_DY_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public BenhAn_ThuocSD_DY_C AssignTo(DMThuoc _DMThuoc)
        {
            if (!Contains(_DMThuoc.MaThuoc))
            {
                BenhAn_ThuocSD_DY_C obj = BenhAn_ThuocSD_DY_C.NewBenhAn_ThuocSD_DY_C(_DMThuoc.MaThuoc);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public BenhAn_ThuocSD_DY_C AssignTo(BenhAn_ThuocSD_DY_C _BenhAn_ThuocSD_DY_C)//add mot hang PhieuNhap_C
        {
            if (!Containss(_BenhAn_ThuocSD_DY_C.Mathuoc , _BenhAn_ThuocSD_DY_C.Huy))
            {  
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    _count = this.Items.Count;
                   // _BenhAn_ThuocSD_DY_C.HanSD = _BenhAn_ThuocSD_DY_C.HanSD;
                    _BenhAn_ThuocSD_DY_C.STTThuoc = ++_count;
                    this.Add(_BenhAn_ThuocSD_DY_C);
                }
                else
                {
                    _BenhAn_ThuocSD_DY_C.STTThuoc = 1;
                    //_BenhAn_ThuocSD_DY_C.HanSD = _BenhAn_ThuocSD_DY_C.HanSD;
                    this.Add(_BenhAn_ThuocSD_DY_C);
                }
                //Add(_PhieuNhap_C);
                return _BenhAn_ThuocSD_DY_C;
             }
             
             else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        protected override object AddNewCore()
        {
            BenhAn_ThuocSD_DY_C item = BenhAn_ThuocSD_DY_C.NewBenhAn_ThuocSD_DY_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(BenhAn_ThuocSD_DY_C obj)
        {
            //foreach (BenhAn_ThuocSD_DY_C obj in this)
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
            foreach (BenhAn_ThuocSD_DY_C obj in this)
                if (obj.STT.Equals(STT))
                {
                    this.Items.Remove(obj);
                    break;
                }
        }
        public bool Contains(string MaBA)
        {
            foreach (BenhAn_ThuocSD_DY_C obj in this)
                if ((obj.MaBA == MaBA) && (obj.Huy == false))
                    return true;
            return false;
        }
        public bool Containss(string MaThuoc, Boolean Huy)
        {
            foreach (BenhAn_ThuocSD_DY_C  obj in this)
                if ((obj.Mathuoc == MaThuoc) && (obj.Huy == false))
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaBA, int stt,int sttkhoa)
        {
            foreach (BenhAn_ThuocSD_DY_C obj in DeletedList)
                if ((obj.MaBA == MaBA) && (obj.STT == stt) && (obj.STTKhoa == sttkhoa)  )
                    return true;
            return false;
        }

        public void UpdatedTo(BenhAn_ThuocSD_DY_C _BenhAn_ThuocSD_DY_C)
        {

            _BenhAn_ThuocSD_DY_C.STT = this.Items[this.IndexOf(_BenhAn_ThuocSD_DY_C)].STT;
           this.Items[this.IndexOf(_BenhAn_ThuocSD_DY_C)] = _BenhAn_ThuocSD_DY_C;
        }

        public BenhAn_ThuocSD_DY_C GetTo(decimal STTThuoc)
        {
            foreach (BenhAn_ThuocSD_DY_C obj in this)
                if (obj.STTThuoc == STTThuoc)
                    return obj;
            return null;
                
        }

        #endregion

        #region Factory Methods

        internal static BenhAn_ThuocSD_DY_CList NewBenhAn_ThuocSD_DY_CList()
        {
            return new BenhAn_ThuocSD_DY_CList();
        }

        internal static BenhAn_ThuocSD_DY_CList GetBenhAn_ThuocSD_DY_CList(SafeDataReader dr)
        {
            return new BenhAn_ThuocSD_DY_CList(dr);
        }

        private BenhAn_ThuocSD_DY_CList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private BenhAn_ThuocSD_DY_CList(SafeDataReader dr)
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
                this.Add(BenhAn_ThuocSD_DY_C.GetBenhAn_ThuocSD_DY_C(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(BenhAn_ThuocSD_DY packet)
        {
            RaiseListChangedEvents = false;
            foreach (BenhAn_ThuocSD_DY_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (BenhAn_ThuocSD_DY_C item in this)
            {
                if (item.IsNew) // &&itemMaBA !="")
                    item.Insert(packet);
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
    }
}