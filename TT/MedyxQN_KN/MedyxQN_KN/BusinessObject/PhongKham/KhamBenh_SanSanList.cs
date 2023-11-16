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
    public class KhamBenh_SanSanList : BusinessListBase<KhamBenh_SanSanList, KhamBenh_SanSan>
    {
        #region Business Methods

        public KhamBenh_SanSan this[string MaDV]
        {
            get
            {
                foreach (KhamBenh_SanSan obj in this)
                    if (obj.MaDV.Equals(MaDV))
                        return obj;
                return null;
            }
        }

        public KhamBenh_SanSan NewTo(string masokham, Int32 stt, string idDMDichvu)
        {

            KhamBenh_SanSan obj = KhamBenh_SanSan.NewKhamBenh_SanSan(masokham, stt, idDMDichvu);

            this.Add(obj);
            return obj;

        }
        public KhamBenh_SanSan NewTo()
        {

            KhamBenh_SanSan obj = KhamBenh_SanSan.NewKhamBenh_SanSan();
            return obj;

        }
        public void NewTo(KhamBenh_SanSan _KhamBenh_San)
        {
            if (!Contains(_KhamBenh_San.MaDV))
            {
                if (this.Items.Count > 0)
                {
                    byte _count = 0;
                    _count = (byte)this.Items.Count;
                    _KhamBenh_San.STT = ++_count;
                    this.Add(_KhamBenh_San);
                }
                else
                {
                    _KhamBenh_San.STT = 1;
                    this.Add(_KhamBenh_San);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public KhamBenh_SanSan AssignTo(DMDichVu _DMDichVu)
        {
            if (!Contains(_DMDichVu.MaDV))
            {
                KhamBenh_SanSan obj = KhamBenh_SanSan.NewKhamBenh_SanSan(_DMDichVu.MaDV);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        protected override object AddNewCore()
        {
            KhamBenh_SanSan item = KhamBenh_SanSan.NewKhamBenh_SanSan();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(string MaDV)
        {
            foreach (KhamBenh_SanSan obj in this)
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
            foreach (KhamBenh_SanSan obj in this)
                if (obj.MaDV == MaDV)
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaDV)
        {
            foreach (KhamBenh_SanSan obj in DeletedList)
                if (obj.MaDV == MaDV)
                    return true;
            return false;
        }
        public void UpdatedTo(KhamBenh_SanSan _KhamBenh_San)
        {

            _KhamBenh_San.STT = this.Items[this.IndexOf(_KhamBenh_San)].STT;
            this.Items[this.IndexOf(_KhamBenh_San)] = _KhamBenh_San;
        }
        public KhamBenh_SanSan GetTo(Byte STT)
        {
            foreach (KhamBenh_SanSan obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        #endregion

        #region Factory Methods

        internal static KhamBenh_SanSanList NewKhamBenh_SanSanList()
        {
            return new KhamBenh_SanSanList();
        }

        internal static KhamBenh_SanSanList GetKhamBenh_SanSanList(SafeDataReader dr)
        {
            return new KhamBenh_SanSanList(dr);
        }
        internal static KhamBenh_SanSanList GetKhamBenh_SanSanList(string MaSoKham, int stt)
        {
            return DataPortal.Fetch<KhamBenh_SanSanList>(new Criteria(MaSoKham, stt));

        }
        private KhamBenh_SanSanList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private KhamBenh_SanSanList(SafeDataReader dr)
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


            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_SanSan(crit.MaSoKham, crit.stt)))
            {


                Fetch(dr);


            }

        }
        private void Fetch(SafeDataReader dr)
        {
            RaiseListChangedEvents = false;
            while (dr.Read())
                this.Add(KhamBenh_SanSan.GetKhamBenh_SanSan(dr));
            RaiseListChangedEvents = true; 
        }

        internal void Update(KhamBenh_C packet)
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (KhamBenh_SanSan item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (KhamBenh_SanSan item in this)
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