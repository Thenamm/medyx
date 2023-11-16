using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;
////
using HTC.Business.CategoryList;

namespace HTC.Business.PhongKham
{
    [Serializable()]
    public class SoChamCong_TVList : BusinessListBase<SoChamCong_TVList, SoChamCong_TV>
    {
        #region Business Methods

        public SoChamCong_TV this[Decimal STT]
        {
            get
            {
                foreach (SoChamCong_TV obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public SoChamCong_TV this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public void NewTo(string MaSCC)
        {
            if (!Contains(MaSCC))
            {
                SoChamCong_TV obj = SoChamCong_TV.NewSoChamCong_TV(MaSCC);
                int _count = 0;
                _count = this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public SoChamCong_TV NewTo()
        {

            SoChamCong_TV obj = SoChamCong_TV.NewSoChamCong_TV();
            return obj;

        }

        public void NewTo(SoChamCong_TV _SoChamCong_TV)
        {
           
            if (!Containss(_SoChamCong_TV.MaNV  , _SoChamCong_TV.Huy ))
            {
                if (this.Items.Count > 0)
                {
                    int _count=0;
                    _count = this.Items.Count;
                    _SoChamCong_TV.STT = ++_count;
                    this.Add(_SoChamCong_TV);
                }
                else
                {
                    _SoChamCong_TV.STT = 1;
                    this.Add(_SoChamCong_TV);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        //public SoChamCong_TV AssignTo(DMNhanVien _DMNhanVien)
        //{
        //    if (!Contains(_DMNhanVien.MaNV))
        //    {
        //        SoChamCong_TV obj = SoChamCong_TV.NewSoChamCong_TV(_DMNhanVien.MaNV);
        //        return obj;
        //    }
        //    else
        //        throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        //}

        public SoChamCong_TV AssignTo(SoChamCong_TV _SoChamCong_TV)//add mot hang PhieuNhap_C
        {
            if (!Containss(_SoChamCong_TV.MaNV , _SoChamCong_TV.Huy))
            {  
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    _count = this.Items.Count;
                   // _SoChamCong_TV.HanSD = _SoChamCong_TV.HanSD;
                    _SoChamCong_TV.STT = ++_count;
                    this.Add(_SoChamCong_TV);
                }
                else
                {
                    _SoChamCong_TV.STT = 1;
                    //_SoChamCong_TV.HanSD = _SoChamCong_TV.HanSD;
                    this.Add(_SoChamCong_TV);
                }
                //Add(_PhieuNhap_C);
               
             }
             return _SoChamCong_TV;
        }

        protected override object AddNewCore()
        {
            SoChamCong_TV item = SoChamCong_TV.NewSoChamCong_TV();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(SoChamCong_TV obj)
        {
            //foreach (SoChamCong_TV obj in this)
            //{
            //    if (obj.MaSCC.Equals(MaSCC))
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
            foreach (SoChamCong_TV obj in this)
                if (obj.STT.Equals(STT))
                {
                    this.Items.Remove(obj);
                    break;
                }
        }
        public bool Contains(string MaSCC)
        {
            foreach (SoChamCong_TV obj in this)
                if ((obj.MaSCC == MaSCC) && (obj.Huy == false))
                    return true;
            return false;
        }
        public bool Containss(string MaNV, Boolean Huy)
        {
            foreach (SoChamCong_TV  obj in this)
                if ((obj.MaNV == MaNV) && (obj.Huy == false))
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaSCC, int stt)
        {
            foreach (SoChamCong_TV obj in DeletedList)
                if ((obj.MaSCC == MaSCC) && (obj.STT == stt)   )
                    return true;
            return false;
        }

        public void UpdatedTo(SoChamCong_TV _SoChamCong_TV)
        {

            _SoChamCong_TV.STT = this.Items[this.IndexOf(_SoChamCong_TV)].STT;
           this.Items[this.IndexOf(_SoChamCong_TV)] = _SoChamCong_TV;
        }

        public SoChamCong_TV GetTo(decimal STT)
        {
            foreach (SoChamCong_TV obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }

        #endregion

        #region Factory Methods

        internal static SoChamCong_TVList NewSoChamCong_TVList()
        {
            return new SoChamCong_TVList();
        }

        internal static SoChamCong_TVList GetSoChamCong_TVList(SafeDataReader dr)
        {
            return new SoChamCong_TVList(dr);
        }

        private SoChamCong_TVList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private SoChamCong_TVList(SafeDataReader dr)
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
                this.Add(SoChamCong_TV.GetSoChamCong_TV(dr));
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        internal void Update(SoChamCong  packet)
        {
            RaiseListChangedEvents = false;
            foreach (SoChamCong_TV item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (SoChamCong_TV item in this)
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