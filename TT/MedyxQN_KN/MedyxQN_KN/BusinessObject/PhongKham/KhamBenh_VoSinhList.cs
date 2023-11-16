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
    public class KhamBenh_VoSinhList : BusinessListBase<KhamBenh_VoSinhList, KhamBenh_VoSinh>
    {
        #region Business Methods

        public KhamBenh_VoSinh this[string MaDV]
        {
            get
            {
                foreach (KhamBenh_VoSinh obj in this)
                    if (obj.MaDV.Equals(MaDV))
                        return obj;
                return null;
            }
        }

        public KhamBenh_VoSinh NewTo(string masokham, Int32 stt, string idDMDichvu)
        {

            KhamBenh_VoSinh obj = KhamBenh_VoSinh.NewKhamBenh_VoSinh(masokham, stt, idDMDichvu);

            this.Add(obj);
            return obj;

        }
        public KhamBenh_VoSinh NewTo()
        {

            KhamBenh_VoSinh obj = KhamBenh_VoSinh.NewKhamBenh_VoSinh();
            return obj;

        }
        public void NewTo(KhamBenh_VoSinh _KhamBenh_VoSinh)
        {
            if (!Contains(_KhamBenh_VoSinh.MaDV))
            {
                if (this.Items.Count > 0)
                {
                    byte _count = 0;
                    _count = (byte)this.Items.Count;
                    _KhamBenh_VoSinh.STT = ++_count;
                    this.Add(_KhamBenh_VoSinh);
                }
                else
                {
                    _KhamBenh_VoSinh.STT = 1;
                    this.Add(_KhamBenh_VoSinh);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public KhamBenh_VoSinh AssignTo(DMDichVu _DMDichVu)
        {
            if (!Contains(_DMDichVu.MaDV))
            {
                KhamBenh_VoSinh obj = KhamBenh_VoSinh.NewKhamBenh_VoSinh(_DMDichVu.MaDV);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        protected override object AddNewCore()
        {
            KhamBenh_VoSinh item = KhamBenh_VoSinh.NewKhamBenh_VoSinh();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(string MaDV)
        {
            foreach (KhamBenh_VoSinh obj in this)
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
            foreach (KhamBenh_VoSinh obj in this)
                if (obj.MaDV == MaDV)
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaDV)
        {
            foreach (KhamBenh_VoSinh obj in DeletedList)
                if (obj.MaDV == MaDV)
                    return true;
            return false;
        }
        public void UpdatedTo(KhamBenh_VoSinh _KhamBenh_VoSinh)
        {

            _KhamBenh_VoSinh.STT = this.Items[this.IndexOf(_KhamBenh_VoSinh)].STT;
            this.Items[this.IndexOf(_KhamBenh_VoSinh)] = _KhamBenh_VoSinh;
        }
        public KhamBenh_VoSinh GetTo(Byte STT)
        {
            foreach (KhamBenh_VoSinh obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        #endregion

        #region Factory Methods

        internal static KhamBenh_VoSinhList NewKhamBenh_VoSinhList()
        {
            return new KhamBenh_VoSinhList();
        }

        internal static KhamBenh_VoSinhList GetKhamBenh_VoSinhList(SafeDataReader dr)
        {
            return new KhamBenh_VoSinhList(dr);
        }
        internal static KhamBenh_VoSinhList GetKhamBenh_VoSinhList(string MaSoKham, int stt)
        {
            return DataPortal.Fetch<KhamBenh_VoSinhList>(new Criteria(MaSoKham, stt));

        }
        private KhamBenh_VoSinhList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private KhamBenh_VoSinhList(SafeDataReader dr)
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


            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance(). GetAllKhamBenh_VoSinh(crit.MaSoKham, crit.stt)))
            {


                Fetch(dr);


            }

        }
        private void Fetch(SafeDataReader dr)
        {
            RaiseListChangedEvents = false;
            while (dr.Read())
                this.Add(KhamBenh_VoSinh.GetKhamBenh_VoSinh(dr));
            RaiseListChangedEvents = true; 
        }

        internal void Update(KhamBenh_C packet)
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (KhamBenh_VoSinh item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (KhamBenh_VoSinh item in this)
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