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
    public class BenhAn_PhauThuat_TVList : BusinessListBase<BenhAn_PhauThuat_TVList, BenhAn_PhauThuat_TV>
    {
        #region Business Methods

        public BenhAn_PhauThuat_TV this[Decimal STT]
        {
            get
            {
                foreach (BenhAn_PhauThuat_TV obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public BenhAn_PhauThuat_TV this[int i]
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
                BenhAn_PhauThuat_TV obj = BenhAn_PhauThuat_TV.NewBenhAn_PhauThuat_TV(MaBA);
                int _count = 0;
                _count = this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public BenhAn_PhauThuat_TV NewTo()
        {

            BenhAn_PhauThuat_TV obj = BenhAn_PhauThuat_TV.NewBenhAn_PhauThuat_TV();
            return obj;

        }

        public void NewTo(BenhAn_PhauThuat_TV _BenhAn_PhauThuat_TV)
        {
           
            if (!Containss(_BenhAn_PhauThuat_TV.MaNV  , _BenhAn_PhauThuat_TV.Huy ))
            {
                if (this.Items.Count > 0)
                {
                    int _count=0;
                    _count = this.Items.Count;
                    _BenhAn_PhauThuat_TV.STTTV = ++_count;
                    this.Add(_BenhAn_PhauThuat_TV);
                }
                else
                {
                    _BenhAn_PhauThuat_TV.STTTV = 1;
                    this.Add(_BenhAn_PhauThuat_TV);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public BenhAn_PhauThuat_TV AssignTo(DMNhanVien _DMNhanVien)
        {
            if (!Contains(_DMNhanVien.MaNV))
            {
                BenhAn_PhauThuat_TV obj = BenhAn_PhauThuat_TV.NewBenhAn_PhauThuat_TV(_DMNhanVien.MaNV);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public BenhAn_PhauThuat_TV AssignTo(BenhAn_PhauThuat_TV _BenhAn_PhauThuat_TV)//add mot hang PhieuNhap_C
        {
            if (!Containss(_BenhAn_PhauThuat_TV.MaNV , _BenhAn_PhauThuat_TV.Huy))
            {  
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    _count = this.Items.Count;
                   // _BenhAn_PhauThuat_TV.HanSD = _BenhAn_PhauThuat_TV.HanSD;
                    _BenhAn_PhauThuat_TV.STTTV = ++_count;
                    this.Add(_BenhAn_PhauThuat_TV);
                }
                else
                {
                    _BenhAn_PhauThuat_TV.STTTV = 1;
                    //_BenhAn_PhauThuat_TV.HanSD = _BenhAn_PhauThuat_TV.HanSD;
                    this.Add(_BenhAn_PhauThuat_TV);
                }
                //Add(_PhieuNhap_C);
               
             }
             return _BenhAn_PhauThuat_TV;
        }

        protected override object AddNewCore()
        {
            BenhAn_PhauThuat_TV item = BenhAn_PhauThuat_TV.NewBenhAn_PhauThuat_TV();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(BenhAn_PhauThuat_TV obj)
        {
            //foreach (BenhAn_PhauThuat_TV obj in this)
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
            foreach (BenhAn_PhauThuat_TV obj in this)
                if (obj.STT.Equals(STT))
                {
                    this.Items.Remove(obj);
                    break;
                }
        }
        public bool Contains(string MaBA)
        {
            foreach (BenhAn_PhauThuat_TV obj in this)
                if ((obj.MaBA == MaBA) && (obj.Huy == false))
                    return true;
            return false;
        }
        public bool Containss(string MaNV, Boolean Huy)
        {
            foreach (BenhAn_PhauThuat_TV  obj in this)
                if ((obj.MaNV == MaNV) && (obj.Huy == false))
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaBA, int stt,int sttkhoa)
        {
            foreach (BenhAn_PhauThuat_TV obj in DeletedList)
                if ((obj.MaBA == MaBA) && (obj.STT == stt) && (obj.STTKhoa == sttkhoa)  )
                    return true;
            return false;
        }

        public void UpdatedTo(BenhAn_PhauThuat_TV _BenhAn_PhauThuat_TV)
        {

            _BenhAn_PhauThuat_TV.STT = this.Items[this.IndexOf(_BenhAn_PhauThuat_TV)].STT;
           this.Items[this.IndexOf(_BenhAn_PhauThuat_TV)] = _BenhAn_PhauThuat_TV;
        }

        public BenhAn_PhauThuat_TV GetTo(decimal STTTV)
        {
            foreach (BenhAn_PhauThuat_TV obj in this)
                if (obj.STTTV == STTTV)
                    return obj;
            return null;
                
        }

        #endregion

        #region Factory Methods

        internal static BenhAn_PhauThuat_TVList NewBenhAn_PhauThuat_TVList()
        {
            return new BenhAn_PhauThuat_TVList();
        }

        internal static BenhAn_PhauThuat_TVList GetBenhAn_PhauThuat_TVList(SafeDataReader dr)
        {
            return new BenhAn_PhauThuat_TVList(dr);
        }

        private BenhAn_PhauThuat_TVList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private BenhAn_PhauThuat_TVList(SafeDataReader dr)
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
                this.Add(BenhAn_PhauThuat_TV.GetBenhAn_PhauThuat_TV(dr));
           
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(BenhAn_PhauThuat packet)
        {
            RaiseListChangedEvents = false;
            foreach (BenhAn_PhauThuat_TV item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (BenhAn_PhauThuat_TV item in this)
            {
                if (item.IsNew==true) // &&item.MaBA =="" )
                    item.Insert(packet);
                else
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
    }
}