using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
//
using HTC.Business;
namespace HTC.Business.KHTH
{
    [Serializable()]
    public class BC_ChuyenMonNgay_CList : BusinessListBase<BC_ChuyenMonNgay_CList, BC_ChuyenMonNgay_C>
    {
        #region Business Methods
        public BC_ChuyenMonNgay_C this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public BC_ChuyenMonNgay_C this[string ma]
        {
            get
            {
                foreach (BC_ChuyenMonNgay_C obj in this)
                    if (obj.Ma.Equals(ma))
                        return obj;
                return null;
            }
        }

        public void NewTo(string Makhoa, SmartDate thang, string ma)
        {
            if (!Contains(Makhoa, thang, ma))
            {
                BC_ChuyenMonNgay_C obj = BC_ChuyenMonNgay_C.NewBC_ChuyenMonNgay_C(Makhoa, thang, ma);
                int _count = 0;
                _count = (int)this.Items.Count;
                obj.OrderNumber = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
        public BC_ChuyenMonNgay_C NewTo()//ham khoi tao doi tuong Phieu nhap
        {

            BC_ChuyenMonNgay_C obj = BC_ChuyenMonNgay_C.NewBC_ChuyenMonNgay_C();
            return obj;

        }
        public void NewTo(BC_ChuyenMonNgay_C _BC_ChuyenMonNgay_C) //moi sua
        {
            if (!Contains(_BC_ChuyenMonNgay_C.MaKhoa, SmartDate.Parse(_BC_ChuyenMonNgay_C.Thang), _BC_ChuyenMonNgay_C.Ma))
            {
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    _count = (int)this.Items.Count;
                    _BC_ChuyenMonNgay_C.OrderNumber = ++_count;
                    this.Add(_BC_ChuyenMonNgay_C);
                }
                else
                {
                    _BC_ChuyenMonNgay_C.OrderNumber = 1;
                    this.Add(_BC_ChuyenMonNgay_C);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }


        protected override object AddNewCore()
        {
            BC_ChuyenMonNgay_C item = BC_ChuyenMonNgay_C.NewBC_ChuyenMonNgay_C();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }


        public void RemoveTo(BC_ChuyenMonNgay_C obj) //xoa 1 BC_ChuyenMonNgay_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public bool Contains(string Makhoa, SmartDate thang, string ma)
        {
            foreach (BC_ChuyenMonNgay_C obj in this)
                if ((obj.MaKhoa == Makhoa) && (SmartDate.Parse(obj.Thang) == thang) && (obj.Ma == ma))
                    return true;
            return false;
        }



        public bool ContainsDeleted(string Makhoa, SmartDate thang, string ma)
        {
            foreach (BC_ChuyenMonNgay_C obj in DeletedList)
                if ((obj.MaKhoa == Makhoa) && (SmartDate.Parse(obj.Thang) == thang) && (obj.Ma == ma))
                    return true;
            return false;
        }
        public void UpdatedTo(BC_ChuyenMonNgay_C _BC_ChuyenMonNgay_C)
        {

            _BC_ChuyenMonNgay_C.OrderNumber = this.Items[this.IndexOf(_BC_ChuyenMonNgay_C)].OrderNumber;
            this.Items[this.IndexOf(_BC_ChuyenMonNgay_C)] = _BC_ChuyenMonNgay_C;
        }
        public BC_ChuyenMonNgay_C Int32(decimal OrderNumber) //
        {
            foreach (BC_ChuyenMonNgay_C obj in this)
                if (obj.OrderNumber == OrderNumber)
                    return obj;
            return null;

        }
        #endregion

           #region Factory Methods

        internal static BC_ChuyenMonNgay_CList NewBC_ChuyenMonNgay_CList()
        {
            return new BC_ChuyenMonNgay_CList();
        }

        internal static BC_ChuyenMonNgay_CList GetBC_ChuyenMonNgay_CList(SafeDataReader dr)
        {
            return new BC_ChuyenMonNgay_CList(dr);
        }

        private BC_ChuyenMonNgay_CList()
        {
            this.AllowNew = true;
            MarkAsChild();
        }

        private BC_ChuyenMonNgay_CList(SafeDataReader dr)
        {
            this.AllowNew = true;
            MarkAsChild();
            Fetch(dr);
        }

        #endregion

     
        #region Data Access
        #region Criteria
        [Serializable()]
        private class Criteria
        {

             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private String _makhoa;
            public String makhoa
            {
                get
                {
                    return _makhoa;
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
            private SmartDate _thang;
            public SmartDate thang
            {
                get
                {
                    return _thang;
                }
            }
           
            public Criteria(  String maKhoa,SmartDate  thang, String dKien)
            {
                _qadmin = HTC.ShareVariables.pub_bQadmin;
                _makhoa = maKhoa;
                _dk = dKien;
                _thang = thang;
            }
        }
           #endregion
        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_ChuyenMonNgay_C(  criteria.makhoa,criteria.thang, criteria.dk, criteria.qadmin)))
            {

                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())// phai trung voi trat tu cac truong ben BC_ChuyenMon vao phuong thuc (internal BC_ChuyenMon)
                    {
                   this.Add(BC_ChuyenMonNgay_C.GetBC_ChuyenMonNgay_C(dr,i));
                    i++;
                    }
                
                //IsReadOnly = true;
            }
            // Xem lai doan code duoi
            //ArrayList arrList;
            //arrList = CBO.FillCollection(DataProvider.Instance().GetLocations(criteria.Id), typeof(LocationListInfo));
            //IsReadOnly = false;
            //foreach (LocationListInfo obj in arrList)
            //{
            //    this.Add(obj);
            //}
            //IsReadOnly = true;

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        ////#region OtherCriteria
        ////[Serializable()]
        ////private class OtherCriteria
        ////{

        ////     private Boolean _qadmin = false ;
        ////    public bool qadmin
        ////    {
        ////        get
        ////        {
        ////            return _qadmin;
        ////        }
        ////    }
        ////    private String _makhoa;
        ////    public String makhoa
        ////    {
        ////        get
        ////        {
        ////            return _makhoa;
        ////        }
        ////    }

        ////    private String _dk;
        ////    public String dk
        ////    {
        ////        get
        ////        {
        ////            return _dk;
        ////        }
        ////    }
        ////    private DateTime _tungay;
        ////    public DateTime tungay
        ////    {
        ////        get
        ////        {
        ////            return _tungay;
        ////        }
        ////    }
        ////    private DateTime _denngay;
        ////    public DateTime denngay
        ////    {
        ////        get
        ////        {
        ////            return _denngay;
        ////        }
        ////    }
        ////    public OtherCriteria(DateTime tuNgay, DateTime denNgay, String maKhoa, String dKien)
        ////    {
        ////        _qadmin = HTC.ShareVariables.pub_bQadmin;
        ////        _makhoa = maKhoa;
        ////        _dk = dKien;
        ////        _tungay = tuNgay;
        ////        _denngay = denNgay;
        ////    }
        ////}
        ////    #endregion
        ////private void DataPortal_Fetch(OtherCriteria OtherCriteria)
        ////{
        ////    RaiseListChangedEvents = false;
        ////    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_ChuyenMonNgay_C(OtherCriteria.tungay, OtherCriteria.denngay, OtherCriteria.makhoa, OtherCriteria.dk, OtherCriteria.qadmin)))
        ////    {

        ////        int i = 1;
        ////        //IsReadOnly = false;
        ////             while (dr.Read())// phai trung voi trat tu cac truong ben BC_ChuyenMon vao phuong thuc (internal BC_ChuyenMon)
        ////             {
        ////           this.Add(BC_ChuyenMonNgay_C.GetBC_ChuyenMonNgay_C(dr,i));
        ////            i++;
        ////            }
                   

                
        ////        //IsReadOnly = true;
        ////    }
        ////    // Xem lai doan code duoi
        ////    //ArrayList arrList;
        ////    //arrList = CBO.FillCollection(DataProvider.Instance().GetLocations(OtherCriteria.Id), typeof(LocationListInfo));
        ////    //IsReadOnly = false;
        ////    //foreach (LocationListInfo obj in arrList)
        ////    //{
        ////    //    this.Add(obj);
        ////    //}
        ////    //IsReadOnly = true;

        ////    RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        ////}

        private void Fetch(SafeDataReader dr)
        {
            RaiseListChangedEvents = false;
            int i = 0;
            while (dr.Read())
            {
                i++;
                this.Add(BC_ChuyenMonNgay_C.GetBC_ChuyenMonNgay_C(dr, i));/////////
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
          
            DeletedList.Clear();

            foreach (BC_ChuyenMonNgay_C item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        //public override BC_ChuyenMonNgay_CList Save()
        //{
        //    // see if save is allowed
        //    if (!CanEditObject())
        //        throw new System.Security.SecurityException(
        //          "User not authorized saving");

        //    BC_ChuyenMonNgay_CList result;
        //    result = base.Save();
        //    return result;
        //}
        internal void Update(BC_ChuyenMonNgay packet)///////////
        {
            RaiseListChangedEvents = false;
            // update (thus deleting) any deleted child objects
            //foreach (BC_ChuyenMonNgay_C item in DeletedList)
            //    item.DeleteSelf(packet);
            // now that they are deleted, remove them from memory too
            DeletedList.Clear();

            // add/update any current child objects
            foreach (BC_ChuyenMonNgay_C item in this)
            {
                if ((item.IsNew))
                    item.Insert();
                else
                    item.Update();
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
   
    }
}
