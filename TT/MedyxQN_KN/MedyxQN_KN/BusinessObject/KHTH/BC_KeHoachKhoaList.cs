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
    public class BC_KeHoachKhoaList : BusinessListBase<BC_KeHoachKhoaList, BC_KeHoachKhoa>
    {
       

        #region Factory Methods
        public BC_KeHoachKhoa this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public BC_KeHoachKhoa this[String nam, string makhoa]
        {
            get
            {
                foreach (BC_KeHoachKhoa obj in this)
                    if ( obj.MaKhoa.Equals(makhoa) && obj.Nam.Equals(nam))
                        return obj;
                return null;
            }
        }

        public void NewTo(String nam, string makhoa)
        {
            if (!Contains(nam, makhoa))
            {
                BC_KeHoachKhoa obj = BC_KeHoachKhoa.NewBC_KeHoachKhoa(nam, makhoa);
                int _count = 0;
                _count = (int)this.Items.Count;
                obj.OrderNumber = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
       
        public void NewTo(BC_KeHoachKhoa _BC_KeHoachKhoa) //moi sua
        {
            if (!Contains(_BC_KeHoachKhoa.Nam , _BC_KeHoachKhoa.MaKhoa))
            {
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    _count = (int)this.Items.Count;
                    _BC_KeHoachKhoa.OrderNumber = ++_count;
                    this.Add(_BC_KeHoachKhoa);
                }
                else
                {
                    _BC_KeHoachKhoa.OrderNumber = 1;
                    this.Add(_BC_KeHoachKhoa);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public static BC_KeHoachKhoaList GetAllBC_KeHoachKhoa( string nam, String dk)
        {
            return DataPortal.Fetch<BC_KeHoachKhoaList>(new Criteria( nam, dk));
        }
       

        public void RemoveTo(BC_KeHoachKhoa obj) //xoa 1 BC_KeHoachKhoa
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public bool Contains( String nam, string makhoa)
        {
            foreach (BC_KeHoachKhoa obj in this)
                if ((obj.Nam == nam) && (obj.MaKhoa == makhoa))
                    return true;
            return false;
        }



        public bool ContainsDeleted(String nam, string makhoa)
        {
            foreach (BC_KeHoachKhoa obj in DeletedList)
                if ((obj.Nam == nam) && (obj.MaKhoa == makhoa))
                    return true;
            return false;
        }
        public void UpdatedTo(BC_KeHoachKhoa _BC_KeHoachKhoa)
        {

            _BC_KeHoachKhoa.OrderNumber = this.Items[this.IndexOf(_BC_KeHoachKhoa)].OrderNumber;
            this.Items[this.IndexOf(_BC_KeHoachKhoa)] = _BC_KeHoachKhoa;
        }
        public BC_KeHoachKhoa GetTo(decimal OrderNumber) //
        {
            foreach (BC_KeHoachKhoa obj in this)
                if (obj.OrderNumber == OrderNumber)
                    return obj;
            return null;

        }
       
        private BC_KeHoachKhoaList()
        {
            this.AllowNew = true;
        }
        protected override object AddNewCore()
        {
            BC_KeHoachKhoa item = BC_KeHoachKhoa.NewBC_KeHoachKhoa();
            //item.IdProducer_Product = MaterialList.DefaultMaterial();
            Add(item);
            return item;
        }

     

        #endregion
        #region Authorization Rules

        public static bool CanAddObject()
        {
            return true;
        }

        public static bool CanGetObject()
        {
            return true;
        }

        public static bool CanDeleteObject()
        {
            return true;
        }

        public static bool CanEditObject()
        {
            return true;
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
          

            private String _dk;
            public String dk
            {
                get
                {
                    return _dk;
                }
            }
            private String _nam;
            public String nam
            {
                get
                {
                    return _nam;
                }
            }
           
            public Criteria(  String nam, String dKien)
            {
                _qadmin = HTC.ShareVariables.pub_bQadmin;
               
                _dk = dKien;
                _nam = nam;
            }
        }
           #endregion
        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_KeHoachKhoa( criteria.nam, criteria.dk, criteria.qadmin)))
            {

                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())// phai trung voi trat tu cac truong ben BC_ChuyenMon vao phuong thuc (internal BC_ChuyenMon)
                    {
                   this.Add(BC_KeHoachKhoa.GetBC_KeHoachKhoa(dr,i));
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
        ////    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_KeHoachKhoa(OtherCriteria.tungay, OtherCriteria.denngay, OtherCriteria.makhoa, OtherCriteria.dk, OtherCriteria.qadmin)))
        ////    {

        ////        int i = 1;
        ////        //IsReadOnly = false;
        ////             while (dr.Read())// phai trung voi trat tu cac truong ben BC_ChuyenMon vao phuong thuc (internal BC_ChuyenMon)
        ////             {
        ////           this.Add(BC_KeHoachKhoa.GetBC_KeHoachKhoa(dr,i));
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
                this.Add(BC_KeHoachKhoa.GetBC_KeHoachKhoa(dr, i));/////////
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
          
            DeletedList.Clear();

            foreach (BC_KeHoachKhoa item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BC_KeHoachKhoaList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            BC_KeHoachKhoaList result;
            result = base.Save();
            return result;
        }

        #endregion
   
    }
}
