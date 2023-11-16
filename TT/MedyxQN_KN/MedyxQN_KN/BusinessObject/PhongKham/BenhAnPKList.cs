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
    public class BenhAnPKList : BusinessListBase<BenhAnPKList, BenhAnPK>
    {
        #region Business Methods

        public BenhAnPK this[string MaBA]
        {
            get
            {
                foreach (BenhAnPK obj in this)
                    if (obj.MaBA.Equals(MaBA))
                        return obj;
                return null;
            }
        }

       
        public BenhAnPK NewTo()
        {
           
              BenhAnPK obj = BenhAnPK.NewBenhAnPK();
              return obj;
               
        }
       
        protected override object AddNewCore()
        {
            BenhAnPK item = BenhAnPK.NewBenhAnPK();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

        public void RemoveTo(string MaBA)
        {
            foreach (BenhAnPK obj in this)
            {
                if (obj.MaBA.Equals(MaBA))
                {
                    Remove(obj);
                    break;
                }
            }
        }

        public bool Contains(string MaBA)
        {
            foreach (BenhAnPK obj in this)
                if (obj.MaBA == MaBA)
                    return true;
            return false;
        }

        public bool ContainsDeleted(string MaBA)
        {
            foreach (BenhAnPK obj in DeletedList)
                if (obj.MaBA == MaBA)
                    return true;
            return false;
        }
        public void UpdatedTo(BenhAnPK _BenhAnPK)
        {

            _BenhAnPK.STT = this.Items[this.IndexOf(_BenhAnPK)].STT;
            this.Items[this.IndexOf(_BenhAnPK)] = _BenhAnPK;
        }
        public BenhAnPK GetTo(Byte STT)
        {
            foreach (BenhAnPK obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;
                
        }
        #endregion

        #region Factory Methods

        internal static BenhAnPKList NewBenhAnPKList()
        {
            return new BenhAnPKList();
        }

        internal static BenhAnPKList GetBenhAnPKList(SafeDataReader dr)
        {
            return new BenhAnPKList(dr);
        }
        public static BenhAnPKList GetBenhAnPKList(string MaBA)
        {
            return DataPortal.Fetch<BenhAnPKList>(new Criteria(MaBA ));

        }
        private BenhAnPKList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private BenhAnPKList(SafeDataReader dr)
        {
            this.AllowNew = true;
            MarkAsChild();
            Fetch(dr);
        }

        #endregion

        #region Data Access
        protected class Criteria
        {
            private String _MaBA;
            public String MaBA
            {
                get
                {
                    return _MaBA;
                }
            }
          
           
         
            public Criteria(String MaBA)
            {
                _MaBA = " and mabaql = '" + MaBA + "' ";

               
               

            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_MaBA.Equals(c._MaBA))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _MaBA.ToString()).GetHashCode();
            }
        }
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetKhamBenh(String _MaBA);
            // public override IDataReader GetKhamBenh(String _MaBA)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaBA));
            // }


            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAnPK (crit.MaBA)))
            {
               

                    Fetch(dr);

                    dr.Close(); dr.Dispose();
            }

        }
        private void Fetch(SafeDataReader dr)
        {
            RaiseListChangedEvents = false;
          
            while (dr.Read())
            this.Add(BenhAnPK.GetBenhAnPK(dr));
            dr.Close(); dr.Dispose();
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

    

        #endregion
    }
}