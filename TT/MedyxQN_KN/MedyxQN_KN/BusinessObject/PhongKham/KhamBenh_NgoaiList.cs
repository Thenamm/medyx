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
    public class KhamBenh_NgoaiList : BusinessListBase<KhamBenh_NgoaiList, KhamBenh_Ngoai>
    {
        #region Business Methods

        public KhamBenh_Ngoai this[string MaDV]
        {
            get
            {
                foreach (KhamBenh_Ngoai obj in this)
                    if (obj.MaDV.Equals(MaDV))
                        return obj;
                return null;
            }
        }

        public KhamBenh_Ngoai NewTo(string masokham, Int32 stt, string idDMDichvu)
        {

            KhamBenh_Ngoai obj = KhamBenh_Ngoai.NewKhamBenh_Ngoai(masokham, stt, idDMDichvu);

            this.Add(obj);
            return obj;

        }
        public KhamBenh_Ngoai NewTo()
        {

            KhamBenh_Ngoai obj = KhamBenh_Ngoai.NewKhamBenh_Ngoai();
            return obj;

        }
        public void NewTo(KhamBenh_Ngoai _KhamBenh_Ngoai)
        {
            if (!Contains(_KhamBenh_Ngoai.MaDV))
            {
                if (this.Items.Count > 0)
                {
                    byte _count = 0;
                    _count = (byte)this.Items.Count;
                    _KhamBenh_Ngoai.STT = ++_count;
                    this.Add(_KhamBenh_Ngoai);
                }
                else
                {
                    _KhamBenh_Ngoai.STT = 1;
                    this.Add(_KhamBenh_Ngoai);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public KhamBenh_Ngoai AssignTo(DMDichVu _DMDichVu)
        {
            if (!Contains(_DMDichVu.MaDV))
            {
                KhamBenh_Ngoai obj = KhamBenh_Ngoai.NewKhamBenh_Ngoai(_DMDichVu.MaDV);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        protected override object AddNewCore()
        {
            KhamBenh_Ngoai item = KhamBenh_Ngoai.NewKhamBenh_Ngoai();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(string MaDV)
        {
            foreach (KhamBenh_Ngoai obj in this)
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
            foreach (KhamBenh_Ngoai obj in this)
                if (obj.MaDV == MaDV)
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaDV)
        {
            foreach (KhamBenh_Ngoai obj in DeletedList)
                if (obj.MaDV == MaDV)
                    return true;
            return false;
        }
        public void UpdatedTo(KhamBenh_Ngoai _KhamBenh_Ngoai)
        {

            _KhamBenh_Ngoai.STT = this.Items[this.IndexOf(_KhamBenh_Ngoai)].STT;
            this.Items[this.IndexOf(_KhamBenh_Ngoai)] = _KhamBenh_Ngoai;
        }
        public KhamBenh_Ngoai GetTo(Byte STT)
        {
            foreach (KhamBenh_Ngoai obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        #endregion

        #region Factory Methods

        internal static KhamBenh_NgoaiList NewKhamBenh_NgoaiList()
        {
            return new KhamBenh_NgoaiList();
        }

        internal static KhamBenh_NgoaiList GetKhamBenh_NgoaiList(SafeDataReader dr)
        {
            return new KhamBenh_NgoaiList(dr);
        }
        internal static KhamBenh_NgoaiList GetKhamBenh_NgoaiList(string MaSoKham, int stt)
        {
            return DataPortal.Fetch<KhamBenh_NgoaiList>(new Criteria(MaSoKham, stt));

        }
        private KhamBenh_NgoaiList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private KhamBenh_NgoaiList(SafeDataReader dr)
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


            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_Ngoai(crit.MaSoKham, crit.stt)))
            {


                Fetch(dr);


            }

        }
        private void Fetch(SafeDataReader dr)
        {
            RaiseListChangedEvents = false;
            while (dr.Read())
                this.Add(KhamBenh_Ngoai.GetKhamBenh_Ngoai(dr));
            RaiseListChangedEvents = true; 
        }

        internal void Update(KhamBenh_C packet)
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (KhamBenh_Ngoai item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (KhamBenh_Ngoai item in this)
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