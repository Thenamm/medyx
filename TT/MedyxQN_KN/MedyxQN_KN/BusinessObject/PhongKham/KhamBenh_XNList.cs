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
    public class KhamBenh_XNList : BusinessListBase<KhamBenh_XNList, KhamBenh_XN>
    {
        #region Business Methods

        public KhamBenh_XN this[string MaDV]
        {
            get
            {
                foreach (KhamBenh_XN obj in this)
                    if (obj.MaDV.Equals(MaDV))
                        return obj;
                return null;
            }
        }

        public void NewTo(string MaDV)
        {
            if (!Contains(MaDV))
            {
                KhamBenh_XN obj = KhamBenh_XN.NewKhamBenh_XN(MaDV);
                byte _count = 0;
                _count = (byte)this.Items.Count;
                obj.STT = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public KhamBenh_XN NewTo()
        {
           
              KhamBenh_XN obj = KhamBenh_XN.NewKhamBenh_XN();
              return obj;
               
        }
        public void NewTo(KhamBenh_XN _KhamBenh_XN)
        {
            if (!Contains(_KhamBenh_XN.MaDV))
            {
                if (this.Items.Count > 0)
                {
                    byte _count=0;
                    _count = (byte)this.Items.Count;
                    _KhamBenh_XN.STT = ++_count;
                    this.Add(_KhamBenh_XN);
                }
                else
                {
                    _KhamBenh_XN.STT = 1;
                    this.Add(_KhamBenh_XN);
                }
            }
            //else
               // throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public KhamBenh_XN AssignTo(string bschidinh,string mabenhbd,string mabp,string madv)
        {
            if (true)
            {
                KhamBenh_XN obj = KhamBenh_XN.NewKhamBenh_XN();
                obj.BSChiDinh = bschidinh;
                obj.mabenhbd = mabenhbd ;
                obj.MaBP =mabp;
                obj.MaDV = madv;
                
                this.Add(obj);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public KhamBenh_XN AssignTo(string madv, string masokham, int stt)
        {
            if (true)
            {
                KhamBenh_XN obj = KhamBenh_XN.NewKhamBenh_XN();
               
                obj.MaDV = madv;
                obj.MaSoKham = masokham;
                obj.STT = stt;
                this.Add(obj);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public KhamBenh_XN AssignTo(string madv)
        {
            if (true)
            {
                KhamBenh_XN obj = KhamBenh_XN.NewKhamBenh_XN();
               
                obj.MaDV = madv;
                this.Add(obj);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public KhamBenh_XN AssignTo(DMDichVu _DMDichVu)
        {
            if (!Contains(_DMDichVu.MaDV))
            {
                KhamBenh_XN obj = KhamBenh_XN.NewKhamBenh_XN(_DMDichVu.MaDV);
                return obj;
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        protected override object AddNewCore()
        {
            KhamBenh_XN item = KhamBenh_XN.NewKhamBenh_XN();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(string MaDV)
        {
            foreach (KhamBenh_XN obj in this)
            {
                if (obj.MaDV.Equals(MaDV))
                {
                    Remove(obj);
                    break;
                }
            }
        }
        public KhamBenh_XN Containsfind(int stt)
        {
            foreach (KhamBenh_XN obj in this)
                if (obj.STT == stt)
                    return obj;
            return null;

        }
        public bool Contains(string MaDV)
        {
            foreach (KhamBenh_XN obj in this)
                if (obj.MaDV == MaDV )
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaDV)
        {
            foreach (KhamBenh_XN obj in DeletedList)
                if (obj.MaDV == MaDV)
                    return true;
            return false;
        }
      
        public void UpdatedTo(KhamBenh_XN _KhamBenh_XN)
        {

            _KhamBenh_XN.STT = this.Items[this.IndexOf(_KhamBenh_XN)].STT;
            this.Items[this.IndexOf(_KhamBenh_XN)] = _KhamBenh_XN;
        }
        public KhamBenh_XN GetTo(Byte STT)
        {
            foreach (KhamBenh_XN obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static KhamBenh_XNList NewKhamBenh_XNList()
        {
            return new KhamBenh_XNList();
        }

        internal static KhamBenh_XNList GetKhamBenh_XNList(string MaSoKham  , int stt)
	    {
            return DataPortal.Fetch<KhamBenh_XNList>(new Criteria( MaSoKham  ,  stt));
           
        }

        private KhamBenh_XNList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private KhamBenh_XNList(SafeDataReader dr)
        {
            this.AllowNew = true;
            MarkAsChild();
            Fetch(dr);
        }

        #endregion

        #region Data Access
        #region Criteria

        [Serializable()]
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
            public Criteria(String masokham,  int stt)
            {
                _maSoKham = masokham;

               
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

     
        #endregion
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetKhamBenh(String _maSoKham);
            // public override IDataReader GetKhamBenh(String _maSoKham)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maSoKham));
            // }
       

            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_XN(crit.MaSoKham,crit.stt )))
            {
              
                   
                    Fetch(dr);
                 
                
            }
        
        }
        private void Fetch(SafeDataReader dr)
        {
            RaiseListChangedEvents = false;
            while (dr.Read())
                this.Add(KhamBenh_XN.GetKhamBenh_XN(dr));
            RaiseListChangedEvents = true; 
        }

        internal void Update(KhamBenh_C packet)
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            foreach (KhamBenh_XN item in DeletedList)
                item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (KhamBenh_XN item in this)
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