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
    public class KhamBenh_VoSinhNuList : BusinessListBase<KhamBenh_VoSinhNuList, KhamBenh_VoSinhNu>
    {
        #region Business Methods

        public KhamBenh_VoSinhNu this[string MaDV]
        {
            get
            {
                foreach (KhamBenh_VoSinhNu obj in this)
                    if (obj.MaDV.Equals(MaDV))
                        return obj;
                return null;
            }
        }

        public KhamBenh_VoSinhNu NewTo(string masokham, Int32 stt, string idDMDichvu)
        {

            KhamBenh_VoSinhNu obj = KhamBenh_VoSinhNu.NewKhamBenh_VoSinhNu(masokham, stt, idDMDichvu);

            this.Add(obj);
            return obj;

        }
        public KhamBenh_VoSinhNu NewTo()
        {

            KhamBenh_VoSinhNu obj = KhamBenh_VoSinhNu.NewKhamBenh_VoSinhNu();
            return obj;

        }
        public void NewTo(KhamBenh_VoSinhNu _KhamBenh_VoSinhNu)
        {
            if (!Contains(_KhamBenh_VoSinhNu.MaDV))
            {
                if (this.Items.Count > 0)
                {
                    byte _count = 0;
                    _count = (byte)this.Items.Count;
                    _KhamBenh_VoSinhNu.STT = ++_count;
                    this.Add(_KhamBenh_VoSinhNu);
                }
                else
                {
                    _KhamBenh_VoSinhNu.STT = 1;
                    this.Add(_KhamBenh_VoSinhNu);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public KhamBenh_VoSinhNu AssignTo(DMDichVu _DMDichVu)
        {
            if (!Contains(_DMDichVu.MaDV))
            {
                KhamBenh_VoSinhNu obj = KhamBenh_VoSinhNu.NewKhamBenh_VoSinhNu(_DMDichVu.MaDV);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        protected override object AddNewCore()
        {
            KhamBenh_VoSinhNu item = KhamBenh_VoSinhNu.NewKhamBenh_VoSinhNu();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(string MaDV)
        {
            foreach (KhamBenh_VoSinhNu obj in this)
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
            foreach (KhamBenh_VoSinhNu obj in this)
                if (obj.MaDV == MaDV)
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaDV)
        {
            foreach (KhamBenh_VoSinhNu obj in DeletedList)
                if (obj.MaDV == MaDV)
                    return true;
            return false;
        }
        public void UpdatedTo(KhamBenh_VoSinhNu _KhamBenh_VoSinhNu)
        {

            _KhamBenh_VoSinhNu.STT = this.Items[this.IndexOf(_KhamBenh_VoSinhNu)].STT;
            this.Items[this.IndexOf(_KhamBenh_VoSinhNu)] = _KhamBenh_VoSinhNu;
        }
        public KhamBenh_VoSinhNu GetTo(Byte STT)
        {
            foreach (KhamBenh_VoSinhNu obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        #endregion

        #region Factory Methods

        internal static KhamBenh_VoSinhNuList NewKhamBenh_VoSinhNuList()
        {
            return new KhamBenh_VoSinhNuList();
        }

        internal static KhamBenh_VoSinhNuList GetKhamBenh_VoSinhNuList(SafeDataReader dr)
        {
            return new KhamBenh_VoSinhNuList(dr);
        }
        internal static KhamBenh_VoSinhNuList GetKhamBenh_VoSinhNuList(string MaSoKham, int stt)
        {
            return DataPortal.Fetch<KhamBenh_VoSinhNuList>(new Criteria(MaSoKham, stt));

        }
        private KhamBenh_VoSinhNuList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private KhamBenh_VoSinhNuList(SafeDataReader dr)
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


            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance(). GetAllKhamBenh_VoSinhNu(crit.MaSoKham, crit.stt)))
            {


                Fetch(dr);


            }

        }
        private void Fetch(SafeDataReader dr)
        {
            RaiseListChangedEvents = false;
            while (dr.Read())
                this.Add(KhamBenh_VoSinhNu.GetKhamBenh_VoSinhNu(dr));
            RaiseListChangedEvents = true; 
        }

        internal void Update(KhamBenh_C packet)
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (KhamBenh_VoSinhNu item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (KhamBenh_VoSinhNu item in this)
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