using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;
//
using HTC.Business.CategoryList;

namespace HTC.Business.Duoc
{
    [Serializable()]
    public class PhieuSoChe_Gias : BusinessListBase<PhieuSoChe_Gias, PhieuSoChe_Gia>
    {
        #region Business Methods
        public PhieuSoChe_Gia this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public PhieuSoChe_Gia this[Decimal STT]
        {
            get
            {
                foreach (PhieuSoChe_Gia obj in this)
                    if (obj.STT.Equals(STT))
                        return obj;
                return null;
            }
        }
      
        protected override object AddNewCore()
        {
            PhieuSoChe_Gia item = PhieuSoChe_Gia.NewPhieuSoChe_Gia();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

     
     

        public void UpdatedTo(PhieuSoChe_Gia _PhieuSoChe_Gia)
        {

            _PhieuSoChe_Gia.STT = this.Items[this.IndexOf(_PhieuSoChe_Gia)].STT;
            this.Items[this.IndexOf(_PhieuSoChe_Gia)] = _PhieuSoChe_Gia;
        }

        public PhieuSoChe_Gia GetTo(decimal STT)
        {
            foreach (PhieuSoChe_Gia obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }

        #endregion

        #region Factory Methods
        public static PhieuSoChe_Gias GetAllPhieuSoChe_Gia(String makho, Byte loaiphieu, DateTime tungay, DateTime denngay)
        {
            return DataPortal.Fetch<PhieuSoChe_Gias>(new Criteria(makho, loaiphieu,tungay, denngay, ""));
        }
        internal static PhieuSoChe_Gias NewPhieuSoChe_Gias()
        {
            return new PhieuSoChe_Gias();
        }

        internal static PhieuSoChe_Gias GetPhieuSoChe_Gias(SafeDataReader dr)
        {
            return new PhieuSoChe_Gias(dr);
        }

        private PhieuSoChe_Gias()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private PhieuSoChe_Gias(SafeDataReader dr)
        {
            this.AllowNew = true;
            MarkAsChild();
            Fetch(dr);
        }

        #endregion

        #region Data Access

        private void Fetch(SafeDataReader dr)
        {
            RaiseListChangedEvents = false;
            decimal i=0;
            while (dr.Read())
            {
                i++;
                this.Add(PhieuSoChe_Gia.GetPhieuSoChe_Gia(dr, i));
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        private class Criteria
        {
            private String _MaKho;
            private String _dk;
             private Boolean _qadmin = false ;
            private DateTime _tungay;
            private DateTime _denngay;
            public String MaKho
            {
                get
                {
                    return _MaKho;
                }
            }
            public DateTime tungay
            {
                get
                {
                    return _tungay ;
                }
            }
            public DateTime denngay
            {
                get
                {
                    return _denngay;
                }
            }
            public String dk
            {
                get
                {
                    return _dk;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private Byte _loaiPhieu;
          
            public Byte LoaiPhieu
            {
                get
                {
                    return _loaiPhieu;
                }
            }
            public Criteria(String mMakho, Byte loaiphieu, DateTime mtungay, DateTime mdenngay, String mdk)
            {
                _MaKho = mMakho;
                _dk = mdk;
                _tungay = mtungay;
                _denngay = mdenngay;
                _loaiPhieu = loaiphieu;
            }
        }



        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllPhieuSoche_Gia(criteria.MaKho, "All", criteria.LoaiPhieu, criteria.tungay, criteria.denngay, criteria.dk)))
            {
                decimal stt = 0;
                while (dr.Read())
                {
                    ++stt;
                    this.Add(PhieuSoChe_Gia.GetPhieuSoChe_Gia(dr,stt));
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
    }
}