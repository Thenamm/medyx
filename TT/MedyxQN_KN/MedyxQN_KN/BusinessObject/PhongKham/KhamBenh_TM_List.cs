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
    public class KhamBenh_TM_List : BusinessListBase<KhamBenh_TM_List, KhamBenh_TM>
    {
        #region Business Methods

        public KhamBenh_TM this[string MaDV]
        {
            get
            {
                foreach (KhamBenh_TM obj in this)
                    if (obj.MaDV.Equals(MaDV))
                        return obj;
                return null;
            }
        }

        public KhamBenh_TM NewTo(string masokham, Int32 stt, string idDMDichvu)
        {

            KhamBenh_TM obj = KhamBenh_TM.NewKhamBenh_TM(masokham, stt, idDMDichvu);

            this.Add(obj);
            return obj;

        }
        public KhamBenh_TM NewTo()
        {

            KhamBenh_TM obj = KhamBenh_TM.NewKhamBenh_TM();
            return obj;

        }
        public void NewTo(KhamBenh_TM _KhamBenh_TM)
        {
            if (!Contains(_KhamBenh_TM.MaDV))
            {
                if (this.Items.Count > 0)
                {
                    byte _count = 0;
                    _count = (byte)this.Items.Count;
                    _KhamBenh_TM.STT = ++_count;
                    this.Add(_KhamBenh_TM);
                }
                else
                {
                    _KhamBenh_TM.STT = 1;
                    this.Add(_KhamBenh_TM);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public KhamBenh_TM AssignTo(DMDichVu _DMDichVu)
        {
            if (!Contains(_DMDichVu.MaDV))
            {
                KhamBenh_TM obj = KhamBenh_TM.NewKhamBenh_TM(_DMDichVu.MaDV);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        protected override object AddNewCore()
        {
            KhamBenh_TM item = KhamBenh_TM.NewKhamBenh_TM();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(string MaDV)
        {
            foreach (KhamBenh_TM obj in this)
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
            foreach (KhamBenh_TM obj in this)
                if (obj.MaDV == MaDV)
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaDV)
        {
            foreach (KhamBenh_TM obj in DeletedList)
                if (obj.MaDV == MaDV)
                    return true;
            return false;
        }
        public void UpdatedTo(KhamBenh_TM _KhamBenh_TM)
        {

            _KhamBenh_TM.STT = this.Items[this.IndexOf(_KhamBenh_TM)].STT;
            this.Items[this.IndexOf(_KhamBenh_TM)] = _KhamBenh_TM;
        }
        public KhamBenh_TM GetTo(Byte STT)
        {
            foreach (KhamBenh_TM obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        #endregion

        #region Factory Methods

        internal static KhamBenh_TM_List NewKhamBenh_TM_List()
        {
            return new KhamBenh_TM_List();
        }

        internal static KhamBenh_TM_List GetKhamBenh_TM_List(SafeDataReader dr)
        {
            return new KhamBenh_TM_List(dr);
        }
        internal static KhamBenh_TM_List GetKhamBenh_TM_List(string MaSoKham, int stt)
        {
            return DataPortal.Fetch<KhamBenh_TM_List>(new Criteria(MaSoKham, stt));

        }
        private KhamBenh_TM_List()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private KhamBenh_TM_List(SafeDataReader dr)
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


            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_TM(crit.MaSoKham, crit.stt)))
            {


                Fetch(dr);


            }

        }
        private void Fetch(SafeDataReader dr)
        {
            RaiseListChangedEvents = false;
            while (dr.Read())
                this.Add(KhamBenh_TM.GetKhamBenh_TM(dr));
            RaiseListChangedEvents = true; 
        }

        internal void Update(KhamBenh_C packet)
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (KhamBenh_TM item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (KhamBenh_TM item in this)
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