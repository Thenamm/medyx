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
    public class KhamBenh_DYList : BusinessListBase<KhamBenh_DYList, KhamBenh_DY>
    {
        #region Business Methods

        public KhamBenh_DY this[string MaDV]
        {
            get
            {
                foreach (KhamBenh_DY obj in this)
                    if (obj.MaDV.Equals(MaDV))
                        return obj;
                return null;
            }
        }

        public KhamBenh_DY NewTo(string masokham, Int32 stt, string idDMDichvu)
        {

            KhamBenh_DY obj = KhamBenh_DY.NewKhamBenh_DY(masokham, stt, idDMDichvu);

            this.Add(obj);
            return obj;

        }
        public KhamBenh_DY NewTo()
        {

            KhamBenh_DY obj = KhamBenh_DY.NewKhamBenh_DY();
            return obj;

        }
        public void NewTo(KhamBenh_DY _KhamBenh_DY)
        {
            if (!Contains(_KhamBenh_DY.MaDV))
            {
                if (this.Items.Count > 0)
                {
                    byte _count = 0;
                    _count = (byte)this.Items.Count;
                    _KhamBenh_DY.STT = ++_count;
                    this.Add(_KhamBenh_DY);
                }
                else
                {
                    _KhamBenh_DY.STT = 1;
                    this.Add(_KhamBenh_DY);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public KhamBenh_DY AssignTo(DMDichVu _DMDichVu)
        {
            if (!Contains(_DMDichVu.MaDV))
            {
                KhamBenh_DY obj = KhamBenh_DY.NewKhamBenh_DY(_DMDichVu.MaDV);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        protected override object AddNewCore()
        {
            KhamBenh_DY item = KhamBenh_DY.NewKhamBenh_DY();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(string MaDV)
        {
            foreach (KhamBenh_DY obj in this)
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
            foreach (KhamBenh_DY obj in this)
                if (obj.MaDV == MaDV)
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaDV)
        {
            foreach (KhamBenh_DY obj in DeletedList)
                if (obj.MaDV == MaDV)
                    return true;
            return false;
        }
        public void UpdatedTo(KhamBenh_DY _KhamBenh_DY)
        {

            _KhamBenh_DY.STT = this.Items[this.IndexOf(_KhamBenh_DY)].STT;
            this.Items[this.IndexOf(_KhamBenh_DY)] = _KhamBenh_DY;
        }
        public KhamBenh_DY GetTo(Byte STT)
        {
            foreach (KhamBenh_DY obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        #endregion

        #region Factory Methods

        internal static KhamBenh_DYList NewKhamBenh_DYList()
        {
            return new KhamBenh_DYList();
        }

        internal static KhamBenh_DYList GetKhamBenh_DYList(SafeDataReader dr)
        {
            return new KhamBenh_DYList(dr);
        }
        internal static KhamBenh_DYList GetKhamBenh_DYList(string MaSoKham, int stt)
        {
            return DataPortal.Fetch<KhamBenh_DYList>(new Criteria(MaSoKham, stt));

        }
        private KhamBenh_DYList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private KhamBenh_DYList(SafeDataReader dr)
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


            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance(). GetAllKhamBenh_DY(crit.MaSoKham, crit.stt)))
            {


                Fetch(dr);


            }

        }
        private void Fetch(SafeDataReader dr)
        {
            RaiseListChangedEvents = false;
            while (dr.Read())
                this.Add(KhamBenh_DY.GetKhamBenh_DY(dr));
            RaiseListChangedEvents = true; 
        }

        internal void Update(KhamBenh_C packet)
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (KhamBenh_DY item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (KhamBenh_DY item in this)
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