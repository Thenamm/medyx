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
    public class KhamBenh_MatList : BusinessListBase<KhamBenh_MatList, KhamBenh_Mat>
    {
        #region Business Methods

        public KhamBenh_Mat this[string MaDV]
        {
            get
            {
                foreach (KhamBenh_Mat obj in this)
                    if (obj.MaDV.Equals(MaDV))
                        return obj;
                return null;
            }
        }

        public KhamBenh_Mat NewTo(string masokham, Int32 stt, string idDMDichvu)
        {

            KhamBenh_Mat obj = KhamBenh_Mat.NewKhamBenh_Mat(masokham, stt, idDMDichvu);

            this.Add(obj);
            return obj;

        }
        public KhamBenh_Mat NewTo()
        {

            KhamBenh_Mat obj = KhamBenh_Mat.NewKhamBenh_Mat();
            return obj;

        }
        public void NewTo(KhamBenh_Mat _KhamBenh_Mat)
        {
            if (!Contains(_KhamBenh_Mat.MaDV))
            {
                if (this.Items.Count > 0)
                {
                    byte _count = 0;
                    _count = (byte)this.Items.Count;
                    _KhamBenh_Mat.STT = ++_count;
                    this.Add(_KhamBenh_Mat);
                }
                else
                {
                    _KhamBenh_Mat.STT = 1;
                    this.Add(_KhamBenh_Mat);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public KhamBenh_Mat AssignTo(DMDichVu _DMDichVu)
        {
            if (!Contains(_DMDichVu.MaDV))
            {
                KhamBenh_Mat obj = KhamBenh_Mat.NewKhamBenh_Mat(_DMDichVu.MaDV);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        protected override object AddNewCore()
        {
            KhamBenh_Mat item = KhamBenh_Mat.NewKhamBenh_Mat();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(string MaDV)
        {
            foreach (KhamBenh_Mat obj in this)
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
            foreach (KhamBenh_Mat obj in this)
                if (obj.MaDV == MaDV)
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaDV)
        {
            foreach (KhamBenh_Mat obj in DeletedList)
                if (obj.MaDV == MaDV)
                    return true;
            return false;
        }
        public void UpdatedTo(KhamBenh_Mat _KhamBenh_Mat)
        {

            _KhamBenh_Mat.STT = this.Items[this.IndexOf(_KhamBenh_Mat)].STT;
            this.Items[this.IndexOf(_KhamBenh_Mat)] = _KhamBenh_Mat;
        }
        public KhamBenh_Mat GetTo(Byte STT)
        {
            foreach (KhamBenh_Mat obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        #endregion

        #region Factory Methods

        internal static KhamBenh_MatList NewKhamBenh_MatList()
        {
            return new KhamBenh_MatList();
        }

        internal static KhamBenh_MatList GetKhamBenh_MatList(SafeDataReader dr)
        {
            return new KhamBenh_MatList(dr);
        }
        internal static KhamBenh_MatList GetKhamBenh_MatList(string MaSoKham, int stt)
        {
            return DataPortal.Fetch<KhamBenh_MatList>(new Criteria(MaSoKham, stt));

        }
        private KhamBenh_MatList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private KhamBenh_MatList(SafeDataReader dr)
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


            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_Mat(crit.MaSoKham, crit.stt)))
            {


                Fetch(dr);


            }

        }
        private void Fetch(SafeDataReader dr)
        {
            RaiseListChangedEvents = false;
            while (dr.Read())
                this.Add(KhamBenh_Mat.GetKhamBenh_Mat(dr));
            RaiseListChangedEvents = true; 
        }

        internal void Update(KhamBenh_C packet)
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (KhamBenh_Mat item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (KhamBenh_Mat item in this)
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