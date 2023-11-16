using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
////
using HTC.Business.CategoryList;


namespace HTC.Business.PhongKham
{
    [Serializable()]
    public class KhamBenh_VLTLList : BusinessListBase<KhamBenh_VLTLList, KhamBenh_VLTL>
    {
        #region Business Methods

        public KhamBenh_VLTL this[string MaDV]
        {
            get
            {
                foreach (KhamBenh_VLTL obj in this)
                    if (obj.MaDV.Equals(MaDV))
                        return obj;
                return null;
            }
        }

        public KhamBenh_VLTL NewTo(string masokham, Int32 stt, string idDMDichvu)
        {

            KhamBenh_VLTL obj = KhamBenh_VLTL.NewKhamBenh_VLTL(masokham, stt, idDMDichvu);

            this.Add(obj);
            return obj;

        }
        public KhamBenh_VLTL NewTo()
        {

            KhamBenh_VLTL obj = KhamBenh_VLTL.NewKhamBenh_VLTL();
            return obj;

        }
        public void NewTo(KhamBenh_VLTL _KhamBenh_VLTL)
        {
            if (!Contains(_KhamBenh_VLTL.MaDV))
            {
                if (this.Items.Count > 0)
                {
                    byte _count = 0;
                    _count = (byte)this.Items.Count;
                    _KhamBenh_VLTL.STT = ++_count;
                    this.Add(_KhamBenh_VLTL);
                }
                else
                {
                    _KhamBenh_VLTL.STT = 1;
                    this.Add(_KhamBenh_VLTL);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public KhamBenh_VLTL AssignTo(DMDichVu _DMDichVu)
        {
            if (!Contains(_DMDichVu.MaDV))
            {
                KhamBenh_VLTL obj = KhamBenh_VLTL.NewKhamBenh_VLTL(_DMDichVu.MaDV);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        protected override object AddNewCore()
        {
            KhamBenh_VLTL item = KhamBenh_VLTL.NewKhamBenh_VLTL();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(string MaDV)
        {
            foreach (KhamBenh_VLTL obj in this)
            {
                if (obj.MaDV.Equals(MaDV))
                {
                    Remove(obj);
                    break;
                }
            }
        }

        public bool Contains(string MaDV)
        {
            foreach (KhamBenh_VLTL obj in this)
                if (obj.MaDV == MaDV)
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaDV)
        {
            foreach (KhamBenh_VLTL obj in DeletedList)
                if (obj.MaDV == MaDV)
                    return true;
            return false;
        }
        public void UpdatedTo(KhamBenh_VLTL _KhamBenh_VLTL)
        {

            _KhamBenh_VLTL.STT = this.Items[this.IndexOf(_KhamBenh_VLTL)].STT;
            this.Items[this.IndexOf(_KhamBenh_VLTL)] = _KhamBenh_VLTL;
        }
        public KhamBenh_VLTL GetTo(Byte STT)
        {
            foreach (KhamBenh_VLTL obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        #endregion

        #region Factory Methods

        internal static KhamBenh_VLTLList NewKhamBenh_VLTLList()
        {
            return new KhamBenh_VLTLList();
        }

        internal static KhamBenh_VLTLList GetKhamBenh_VLTLList(SafeDataReader dr)
        {
            return new KhamBenh_VLTLList(dr);
        }
        internal static KhamBenh_VLTLList GetKhamBenh_VLTLList(string MaSoKham, int stt)
        {
            return DataPortal.Fetch<KhamBenh_VLTLList>(new Criteria(MaSoKham, stt));

        }
        private KhamBenh_VLTLList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private KhamBenh_VLTLList(SafeDataReader dr)
        {
            this.AllowNew = true;
            MarkAsChild();
            Fetch(dr);
        }

        #endregion

        #region Data Access
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
            private Byte _loai;
            public Byte loai
            {
                get
                {
                    return _loai;
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
            private DateTime _ngayyc;
            public DateTime ngayyc
            {
                get
                {
                    return _ngayyc;
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


            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_VLTL(crit.MaSoKham, crit.stt)))
            {


                Fetch(dr);


            }

        }
        private void Fetch(SafeDataReader dr)
        {
            RaiseListChangedEvents = false;
            while (dr.Read())
                this.Add(KhamBenh_VLTL.GetKhamBenh_VLTL(dr));
            RaiseListChangedEvents = true; 
        }

        internal void Update(KhamBenh_C packet)
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (KhamBenh_VLTL item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (KhamBenh_VLTL item in this)
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