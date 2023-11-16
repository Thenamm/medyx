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
    public class BC_ChuyenMonPTList : BusinessListBase<BC_ChuyenMonPTList, BC_ChuyenMonPT>
    {
       

        #region Factory Methods
        public BC_ChuyenMonPT this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public BC_ChuyenMonPT this[string Makhoa, SmartDate thang, string ma]
        {
            get
            {
                foreach (BC_ChuyenMonPT obj in this)
                    if (obj.MaKhoa.Equals(Makhoa) && obj.Ma.Equals(ma) && obj.Thang.Equals(thang))
                        return obj;
                return null;
            }
        }

        public void NewTo(string Makhoa, SmartDate thang, string ma)
        {
            if (!Contains(Makhoa, thang, ma))
            {
                BC_ChuyenMonPT obj = BC_ChuyenMonPT.NewBC_ChuyenMonPT(Makhoa, thang, ma);
                int _count = 0;
                _count = (int)this.Items.Count;
                obj.OrderNumber = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
       
        public void NewTo(BC_ChuyenMonPT _BC_ChuyenMonPT) //moi sua
        {
            if (!Contains(_BC_ChuyenMonPT.MaKhoa, SmartDate.Parse(_BC_ChuyenMonPT.Thang), _BC_ChuyenMonPT.Ma))
            {
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    _count = (int)this.Items.Count;
                    _BC_ChuyenMonPT.OrderNumber = ++_count;
                    this.Add(_BC_ChuyenMonPT);
                }
                else
                {
                    _BC_ChuyenMonPT.OrderNumber = 1;
                    this.Add(_BC_ChuyenMonPT);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public static BC_ChuyenMonPTList GetAllBC_ChuyenMonPT(string Makhoa, DateTime thang, String dk)
        {
            return DataPortal.Fetch<BC_ChuyenMonPTList>(new Criteria(Makhoa, SmartDate.Parse(thang.ToString()), dk));
        }
       

        public void RemoveTo(BC_ChuyenMonPT obj) //xoa 1 BC_ChuyenMonPT
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public bool Contains(string Makhoa, SmartDate thang, string ma)
        {
            foreach (BC_ChuyenMonPT obj in this)
                if ((obj.MaKhoa == Makhoa) && (SmartDate.Parse(obj.Thang) == thang) && (obj.Ma == ma))
                    return true;
            return false;
        }



        public bool ContainsDeleted(string Makhoa, SmartDate thang, string ma)
        {
            foreach (BC_ChuyenMonPT obj in DeletedList)
                if ((obj.MaKhoa == Makhoa) && (SmartDate.Parse(obj.Thang) == thang) && (obj.Ma == ma))
                    return true;
            return false;
        }
        public void UpdatedTo(BC_ChuyenMonPT _BC_ChuyenMonPT)
        {

            _BC_ChuyenMonPT.OrderNumber = this.Items[this.IndexOf(_BC_ChuyenMonPT)].OrderNumber;
            this.Items[this.IndexOf(_BC_ChuyenMonPT)] = _BC_ChuyenMonPT;
        }
        public BC_ChuyenMonPT GetTo(Int32 OrderNumber) //
        {
            foreach (BC_ChuyenMonPT obj in this)
                if (obj.OrderNumber == OrderNumber)
                    return obj;
            return null;

        }
       
        private BC_ChuyenMonPTList()
        {
            this.AllowNew = true;
        }
        protected override object AddNewCore()
        {
            BC_ChuyenMonPT item = BC_ChuyenMonPT.NewBC_ChuyenMonPT();
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_ChuyenMonPT(  criteria.makhoa,criteria.thang, criteria.dk, criteria.qadmin)))
            {

                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())// phai trung voi trat tu cac truong ben BC_ChuyenMon vao phuong thuc (internal BC_ChuyenMon)
                    {
                   this.Add(BC_ChuyenMonPT.GetBC_ChuyenMonPT(dr,i));
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
        ////    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_ChuyenMonPT(OtherCriteria.tungay, OtherCriteria.denngay, OtherCriteria.makhoa, OtherCriteria.dk, OtherCriteria.qadmin)))
        ////    {

        ////        int i = 1;
        ////        //IsReadOnly = false;
        ////             while (dr.Read())// phai trung voi trat tu cac truong ben BC_ChuyenMon vao phuong thuc (internal BC_ChuyenMon)
        ////             {
        ////           this.Add(BC_ChuyenMonPT.GetBC_ChuyenMonPT(dr,i));
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
                this.Add(BC_ChuyenMonPT.GetBC_ChuyenMonPT(dr, i));/////////
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
          
            DeletedList.Clear();

            foreach (BC_ChuyenMonPT item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BC_ChuyenMonPTList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            BC_ChuyenMonPTList result;
            result = base.Save();
            return result;
        }

        #endregion
   
    }
}
