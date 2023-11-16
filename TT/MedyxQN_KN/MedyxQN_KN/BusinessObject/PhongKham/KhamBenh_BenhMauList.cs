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
    public class KhamBenh_BenhMauList : BusinessListBase<KhamBenh_BenhMauList, KhamBenh_BenhMau>
    {
        #region Business Methods

        public KhamBenh_BenhMau this[string MaDV]
        {
            get
            {
                foreach (KhamBenh_BenhMau obj in this)
                    if (obj.MaDV.Equals(MaDV))
                        return obj;
                return null;
            }
        }

        public KhamBenh_BenhMau NewTo(string masokham, Int32 stt, string idDMDichvu)
        {

            KhamBenh_BenhMau obj = KhamBenh_BenhMau.NewKhamBenh_BenhMau(masokham, stt, idDMDichvu);

            this.Add(obj);
            return obj;

        }
        public KhamBenh_BenhMau NewTo()
        {

            KhamBenh_BenhMau obj = KhamBenh_BenhMau.NewKhamBenh_BenhMau();
            return obj;

        }
        public void NewTo(KhamBenh_BenhMau _KhamBenh_BenhMau)
        {
            if (!Contains(_KhamBenh_BenhMau.MaDV))
            {
                if (this.Items.Count > 0)
                {
                    byte _count = 0;
                    _count = (byte)this.Items.Count;
                    _KhamBenh_BenhMau.STT = ++_count;
                    this.Add(_KhamBenh_BenhMau);
                }
                else
                {
                    _KhamBenh_BenhMau.STT = 1;
                    this.Add(_KhamBenh_BenhMau);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public KhamBenh_BenhMau AssignTo(DMDichVu _DMDichVu)
        {
            if (!Contains(_DMDichVu.MaDV))
            {
                KhamBenh_BenhMau obj = KhamBenh_BenhMau.NewKhamBenh_BenhMau(_DMDichVu.MaDV);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        protected override object AddNewCore()
        {
            KhamBenh_BenhMau item = KhamBenh_BenhMau.NewKhamBenh_BenhMau();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(string MaDV)
        {
            foreach (KhamBenh_BenhMau obj in this)
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
            foreach (KhamBenh_BenhMau obj in this)
                if (obj.MaDV == MaDV)
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaDV)
        {
            foreach (KhamBenh_BenhMau obj in DeletedList)
                if (obj.MaDV == MaDV)
                    return true;
            return false;
        }
        public void UpdatedTo(KhamBenh_BenhMau _KhamBenh_BenhMau)
        {

            _KhamBenh_BenhMau.STT = this.Items[this.IndexOf(_KhamBenh_BenhMau)].STT;
            this.Items[this.IndexOf(_KhamBenh_BenhMau)] = _KhamBenh_BenhMau;
        }
        public KhamBenh_BenhMau GetTo(Byte STT)
        {
            foreach (KhamBenh_BenhMau obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        #endregion

        #region Factory Methods

        internal static KhamBenh_BenhMauList NewKhamBenh_BenhMauList()
        {
            return new KhamBenh_BenhMauList();
        }

        internal static KhamBenh_BenhMauList GetKhamBenh_BenhMauList(SafeDataReader dr)
        {
            return new KhamBenh_BenhMauList(dr);
        }
        internal static KhamBenh_BenhMauList GetKhamBenh_BenhMauList(string MaSoKham, int stt)
        {
            return DataPortal.Fetch<KhamBenh_BenhMauList>(new Criteria(MaSoKham, stt));

        }
        private KhamBenh_BenhMauList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private KhamBenh_BenhMauList(SafeDataReader dr)
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


            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_BenhMau(crit.MaSoKham, crit.stt)))
            {


                Fetch(dr);


            }

        }
        private void Fetch(SafeDataReader dr)
        {
            RaiseListChangedEvents = false;
            while (dr.Read())
                this.Add(KhamBenh_BenhMau.GetKhamBenh_BenhMau(dr));
            RaiseListChangedEvents = true; 
        }

        internal void Update(KhamBenh_C packet)
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (KhamBenh_BenhMau item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (KhamBenh_BenhMau item in this)
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