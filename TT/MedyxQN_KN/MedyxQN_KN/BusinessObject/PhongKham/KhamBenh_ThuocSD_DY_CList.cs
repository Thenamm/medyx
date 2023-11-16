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
    public class KhamBenh_ThuocSD_DY_CList : BusinessListBase<KhamBenh_ThuocSD_DY_CList, KhamBenh_ThuocSD_DY_C>
    {
        #region Business Methods

        public KhamBenh_ThuocSD_DY_C this[Decimal STT]
        {
            get
            {
                foreach (KhamBenh_ThuocSD_DY_C obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
        public KhamBenh_ThuocSD_DY_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public void NewTo(string MaSoKham)
        {
            if (!Contains(MaSoKham))
            {
                KhamBenh_ThuocSD_DY_C obj = KhamBenh_ThuocSD_DY_C.NewKhamBenh_ThuocSD_DY_C(MaSoKham);
                int _count = 0;
                _count = this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public KhamBenh_ThuocSD_DY_C NewTo()
        {

            KhamBenh_ThuocSD_DY_C obj = KhamBenh_ThuocSD_DY_C.NewKhamBenh_ThuocSD_DY_C();
            return obj;

        }

        public void NewTo(KhamBenh_ThuocSD_DY_C _KhamBenh_ThuocSD_DY_C)
        {
           
            if (!Containss(_KhamBenh_ThuocSD_DY_C.Mathuoc  , _KhamBenh_ThuocSD_DY_C.Huy ))
            {
                if (this.Items.Count > 0)
                {
                    int _count=0;
                    _count = this.Items.Count;
                    _KhamBenh_ThuocSD_DY_C.STTThuoc = ++_count;
                    this.Add(_KhamBenh_ThuocSD_DY_C);
                }
                else
                {
                    _KhamBenh_ThuocSD_DY_C.STTThuoc = 1;
                    this.Add(_KhamBenh_ThuocSD_DY_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public KhamBenh_ThuocSD_DY_C AssignTo(DMThuoc _DMThuoc)
        {
            if (!Contains(_DMThuoc.MaThuoc))
            {
                KhamBenh_ThuocSD_DY_C obj = KhamBenh_ThuocSD_DY_C.NewKhamBenh_ThuocSD_DY_C(_DMThuoc.MaThuoc);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public KhamBenh_ThuocSD_DY_C AssignTo(KhamBenh_ThuocSD_DY_C _KhamBenh_ThuocSD_DY_C)//add mot hang PhieuNhap_C
        {
            if (!Containss(_KhamBenh_ThuocSD_DY_C.Mathuoc , _KhamBenh_ThuocSD_DY_C.Huy))
            {  
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    _count = this.Items.Count;
                   // _KhamBenh_ThuocSD_DY_C.HanSD = _KhamBenh_ThuocSD_DY_C.HanSD;
                    _KhamBenh_ThuocSD_DY_C.STTThuoc = this.Items[this.Count-1].STTThuoc+1  ;
                    _KhamBenh_ThuocSD_DY_C.OrderNumber = ++_count;
                    this.Add(_KhamBenh_ThuocSD_DY_C);
                }
                else
                {
                    _KhamBenh_ThuocSD_DY_C.STTThuoc = 1;
                    _KhamBenh_ThuocSD_DY_C.OrderNumber = 1;
                    //_KhamBenh_ThuocSD_DY_C.HanSD = _KhamBenh_ThuocSD_DY_C.HanSD;
                    this.Add(_KhamBenh_ThuocSD_DY_C);
                }
                //Add(_PhieuNhap_C);
                return _KhamBenh_ThuocSD_DY_C;
             }
             
             else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        protected override object AddNewCore()
        {
            KhamBenh_ThuocSD_DY_C item = KhamBenh_ThuocSD_DY_C.NewKhamBenh_ThuocSD_DY_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(KhamBenh_ThuocSD_DY_C obj)
        {
            //foreach (KhamBenh_ThuocSD_DY_C obj in this)
            //{
            //    if (obj.MaSoKham.Equals(MaSoKham))
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
            foreach (KhamBenh_ThuocSD_DY_C obj in this)
                if (obj.STT.Equals(STT))
                {
                    this.Items.Remove(obj);
                    break;
                }
        }
        public bool Contains(string MaSoKham)
        {
            foreach (KhamBenh_ThuocSD_DY_C obj in this)
                if ((obj.MaSoKham == MaSoKham) && (obj.Huy == false))
                    return true;
            return false;
        }
        public bool Containss(string MaThuoc, Boolean Huy)
        {
            foreach (KhamBenh_ThuocSD_DY_C  obj in this)
                if ((obj.Mathuoc == MaThuoc) && (obj.Huy == false))
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaSoKham, int stt)
        {
            foreach (KhamBenh_ThuocSD_DY_C obj in DeletedList)
                if ((obj.MaSoKham == MaSoKham) && (obj.STT == stt)   )
                    return true;
            return false;
        }

        public void UpdatedTo(KhamBenh_ThuocSD_DY_C _KhamBenh_ThuocSD_DY_C)
        {

            _KhamBenh_ThuocSD_DY_C.STT = this.Items[this.IndexOf(_KhamBenh_ThuocSD_DY_C)].STT;
           this.Items[this.IndexOf(_KhamBenh_ThuocSD_DY_C)] = _KhamBenh_ThuocSD_DY_C;
        }

        public KhamBenh_ThuocSD_DY_C GetTo(decimal STTThuoc)
        {
            foreach (KhamBenh_ThuocSD_DY_C obj in this)
                if (obj.STTThuoc == STTThuoc)
                    return obj;
            return null;
                
        }

        #endregion

        #region Factory Methods

        internal static KhamBenh_ThuocSD_DY_CList NewKhamBenh_ThuocSD_DY_CList()
        {
            return new KhamBenh_ThuocSD_DY_CList();
        }

        internal static KhamBenh_ThuocSD_DY_CList GetKhamBenh_ThuocSD_DY_CList(SafeDataReader dr)
        {
            return new KhamBenh_ThuocSD_DY_CList(dr);
        }
        internal static KhamBenh_ThuocSD_DY_CList GetKhamBenh_ThuocSD_DY_CList(string MaSoKham, int stt)
        {
            return DataPortal.Fetch<KhamBenh_ThuocSD_DY_CList>(new Criteria(MaSoKham, stt));

        }
        private KhamBenh_ThuocSD_DY_CList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private KhamBenh_ThuocSD_DY_CList(SafeDataReader dr)
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
            int i = 1;
            KhamBenh_ThuocSD_DY_C _KhamBenh_ThuocSD_DY_C;
            while (dr.Read())
            {
                _KhamBenh_ThuocSD_DY_C = KhamBenh_ThuocSD_DY_C.GetKhamBenh_ThuocSD_DY_C(dr);
                _KhamBenh_ThuocSD_DY_C.OrderNumber = i;
                this.Add(_KhamBenh_ThuocSD_DY_C);
                i++;
            }
            RaiseListChangedEvents = true; 
        }

        internal void Update(KhamBenh_ThuocSD_DY packet)
        {
            RaiseListChangedEvents = false;
            foreach (KhamBenh_ThuocSD_DY_C item in DeletedList)
                item.DeleteSelf(packet);
            DeletedList.Clear();
            foreach (KhamBenh_ThuocSD_DY_C item in this)
            {
                if (item.IsNew )
                    item.Insert(packet);
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update(packet);
            }
            RaiseListChangedEvents = true; 
        }

        protected class Criteria
        {
            private String _maSoKham;
            public String MaSoKham
            {
                get
                {
                    return _maSoKham;
                }
            }
          
            private int _stt;
            public int stt
            {
                get
                {
                    return _stt;
                }
            }
           
            private String _dk;
            public String dk
            {
                get
                {
                    return _dk;
                }
            }
            public Criteria(String MaSoKham, int stt)
            {
                _maSoKham = MaSoKham;
                _stt = stt;

            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maSoKham.Equals(c._maSoKham))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maSoKham.ToString()).GetHashCode();
            }
        }
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetKhamBenh(String _maSoKham);
            // public override IDataReader GetKhamBenh(String _maSoKham)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maSoKham));
            // }


            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_ThuocSD_DY_C (crit.MaSoKham, crit.stt,"",HTC.ShareVariables.pub_bQadmin)))
            {


                Fetch(dr);


            }

        }
      
        #endregion
    }
}