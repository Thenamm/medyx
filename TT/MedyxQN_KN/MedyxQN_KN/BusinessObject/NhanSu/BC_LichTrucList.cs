using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
//
using HTC.Business;
namespace HTC.Business.NhanSu
{
    [Serializable()]
    public class BC_LichTrucList : BusinessListBase<BC_LichTrucList, BC_LichTruc>
    {
       

        #region Factory Methods
        public BC_LichTruc this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        public BC_LichTruc this[string Makhoa, SmartDate thang, string ma]
        {
            get
            {
                foreach (BC_LichTruc obj in this)
                    if (obj.MaKhoa.Equals(Makhoa) && obj.MaNV.Equals(ma) && obj.Thang.Equals(thang))
                        return obj;
                return null;
            }
        }

        public void NewTo(string Makhoa, SmartDate thang, string ma)
        {
            if (!Contains(Makhoa, thang, ma))
            {
                BC_LichTruc obj = BC_LichTruc.NewBC_LichTruc(Makhoa, thang, ma);
                int _count = 0;
                _count = (int)this.Items.Count;
                obj.OrderNumber = ++_count;
                this.Add(obj);
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }
       
        public void NewTo(BC_LichTruc _BC_LichTruc) //moi sua
        {
            if (!Contains(_BC_LichTruc.MaKhoa, SmartDate.Parse(_BC_LichTruc.Thang), _BC_LichTruc.MaNV))
            {
                if (this.Items.Count > 0)
                {
                    int _count = 0;
                    _count = (int)this.Items.Count;
                    _BC_LichTruc.OrderNumber = ++_count;
                    this.Add(_BC_LichTruc);
                }
                else
                {
                    _BC_LichTruc.OrderNumber = 1;
                    this.Add(_BC_LichTruc);
                }
            }
            else
                throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        }

        public static BC_LichTrucList GetAllBC_LichTruc(DateTime tuthang, DateTime denthang, string Makhoa, String dk)
        {
            return DataPortal.Fetch<BC_LichTrucList>(new Criteria(Makhoa, SmartDate.Parse(tuthang.ToString()), SmartDate.Parse(denthang.ToString()), dk));
        }
       

        public void RemoveTo(BC_LichTruc obj) //xoa 1 BC_LichTruc
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public bool Contains(string Makhoa, SmartDate thang, string ma)
        {
            foreach (BC_LichTruc obj in this)
                if ((obj.MaKhoa == Makhoa) && (SmartDate.Parse(obj.Thang) == thang) && (obj.MaNV== ma))
                    return true;
            return false;
        }



        public bool ContainsDeleted(string Makhoa, SmartDate thang, string ma)
        {
            foreach (BC_LichTruc obj in DeletedList)
                if ((obj.MaKhoa == Makhoa) && (SmartDate.Parse(obj.Thang) == thang) && (obj.MaNV == ma))
                    return true;
            return false;
        }
        public void UpdatedTo(BC_LichTruc _BC_LichTruc)
        {

            _BC_LichTruc.OrderNumber = this.Items[this.IndexOf(_BC_LichTruc)].OrderNumber;
            this.Items[this.IndexOf(_BC_LichTruc)] = _BC_LichTruc;
        }
        public BC_LichTruc GetTo(Int32 OrderNumber) //
        {
            foreach (BC_LichTruc obj in this)
                if (obj.OrderNumber == OrderNumber)
                    return obj;
            return null;

        }
       
        private BC_LichTrucList()
        {
            this.AllowNew = true;
        }
        protected override object AddNewCore()
        {
            BC_LichTruc item = BC_LichTruc.NewBC_LichTruc();
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
            private SmartDate _tuthang;
            public SmartDate tuthang
            {
                get
                {
                    return _tuthang;
                }
            }
            private SmartDate _denthang;
            public SmartDate denthang
            {
                get
                {
                    return _denthang;
                }
            }
            public Criteria(String maKhoa, SmartDate tuthang, SmartDate denthang, String dKien)
            {
                _qadmin = HTC.ShareVariables.pub_bQadmin;
                _makhoa = maKhoa;
                _dk = dKien;
                _tuthang = tuthang;
                _denthang = denthang;
            }
        }
           #endregion
        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_LichTruc(criteria.tuthang, criteria.denthang, criteria.makhoa, criteria.dk, criteria.qadmin)))
            {

                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())// phai trung voi trat tu cac truong ben BC_ChuyenMon vao phuong thuc (internal BC_ChuyenMon)
                    {
                   this.Add(BC_LichTruc.GetBC_LichTruc(dr,i));
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
        ////    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_LichTruc(OtherCriteria.tungay, OtherCriteria.denngay, OtherCriteria.makhoa, OtherCriteria.dk, OtherCriteria.qadmin)))
        ////    {

        ////        int i = 1;
        ////        //IsReadOnly = false;
        ////             while (dr.Read())// phai trung voi trat tu cac truong ben BC_ChuyenMon vao phuong thuc (internal BC_ChuyenMon)
        ////             {
        ////           this.Add(BC_LichTruc.GetBC_LichTruc(dr,i));
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
                this.Add(BC_LichTruc.GetBC_LichTruc(dr, i));/////////
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
          
            DeletedList.Clear();

            foreach (BC_LichTruc item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BC_LichTrucList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            BC_LichTrucList result;
            result = base.Save();
            return result;
        }

        #endregion
   
    }
}
