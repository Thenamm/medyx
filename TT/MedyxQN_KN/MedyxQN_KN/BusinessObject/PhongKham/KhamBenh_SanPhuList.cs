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
    public class KhamBenh_SanPhuList : BusinessListBase<KhamBenh_SanPhuList, KhamBenh_SanPhu>
    {
        #region Business Methods

        public KhamBenh_SanPhu this[string MaDV]
        {
            get
            {
                foreach (KhamBenh_SanPhu obj in this)
                    if (obj.MaDV.Equals(MaDV))
                        return obj;
                return null;
            }
        }

        public KhamBenh_SanPhu NewTo(string masokham, Int32 stt, string idDMDichvu)
        {

            KhamBenh_SanPhu obj = KhamBenh_SanPhu.NewKhamBenh_SanPhu(masokham, stt, idDMDichvu);

            this.Add(obj);
            return obj;

        }
        public KhamBenh_SanPhu NewTo()
        {

            KhamBenh_SanPhu obj = KhamBenh_SanPhu.NewKhamBenh_SanPhu();
            return obj;

        }
        public void NewTo(KhamBenh_SanPhu _KhamBenh_SanPhu)
        {
            if (!Contains(_KhamBenh_SanPhu.MaDV))
            {
                if (this.Items.Count > 0)
                {
                    byte _count = 0;
                    _count = (byte)this.Items.Count;
                    _KhamBenh_SanPhu.STT = ++_count;
                    this.Add(_KhamBenh_SanPhu);
                }
                else
                {
                    _KhamBenh_SanPhu.STT = 1;
                    this.Add(_KhamBenh_SanPhu);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public KhamBenh_SanPhu AssignTo(DMDichVu _DMDichVu)
        {
            if (!Contains(_DMDichVu.MaDV))
            {
                KhamBenh_SanPhu obj = KhamBenh_SanPhu.NewKhamBenh_SanPhu(_DMDichVu.MaDV);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        protected override object AddNewCore()
        {
            KhamBenh_SanPhu item = KhamBenh_SanPhu.NewKhamBenh_SanPhu();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(string MaDV)
        {
            foreach (KhamBenh_SanPhu obj in this)
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
            foreach (KhamBenh_SanPhu obj in this)
                if (obj.MaDV == MaDV)
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaDV)
        {
            foreach (KhamBenh_SanPhu obj in DeletedList)
                if (obj.MaDV == MaDV)
                    return true;
            return false;
        }
        public void UpdatedTo(KhamBenh_SanPhu _KhamBenh_SanPhu)
        {

            _KhamBenh_SanPhu.STT = this.Items[this.IndexOf(_KhamBenh_SanPhu)].STT;
            this.Items[this.IndexOf(_KhamBenh_SanPhu)] = _KhamBenh_SanPhu;
        }
        public KhamBenh_SanPhu GetTo(Byte STT)
        {
            foreach (KhamBenh_SanPhu obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        #endregion

        #region Factory Methods

        internal static KhamBenh_SanPhuList NewKhamBenh_SanPhuList()
        {
            return new KhamBenh_SanPhuList();
        }

        internal static KhamBenh_SanPhuList GetKhamBenh_SanPhuList(SafeDataReader dr)
        {
            return new KhamBenh_SanPhuList(dr);
        }
        internal static KhamBenh_SanPhuList GetKhamBenh_SanPhuList(string MaSoKham, int stt)
        {
            return DataPortal.Fetch<KhamBenh_SanPhuList>(new Criteria(MaSoKham, stt));

        }
        private KhamBenh_SanPhuList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private KhamBenh_SanPhuList(SafeDataReader dr)
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


            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_SanPhu(crit.MaSoKham, crit.stt)))
            {


                Fetch(dr);


            }

        }
        private void Fetch(SafeDataReader dr)
        {
            RaiseListChangedEvents = false;
            while (dr.Read())
                this.Add(KhamBenh_SanPhu.GetKhamBenh_SanPhu(dr));
            RaiseListChangedEvents = true; 
        }

        internal void Update(KhamBenh_C packet)
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (KhamBenh_SanPhu item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (KhamBenh_SanPhu item in this)
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