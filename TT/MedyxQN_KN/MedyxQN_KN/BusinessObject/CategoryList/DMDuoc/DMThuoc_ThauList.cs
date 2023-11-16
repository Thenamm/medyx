using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
//
 
namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMThuoc_ThauList : BusinessListBase<DMThuoc_ThauList, DMThuoc_Thau>
    {
        #region Factory Methods
        ////public static DMThuoc_ThauList GetAllDMThuoc_Thau(String makho, String makhoa)
        ////{
        ////    return DataPortal.Fetch<DMThuoc_ThauList>(new Criteria(makho, makhoa ));
        ////}
        // tim theo dieu kien ten
        //public static DMThuoc_ThauList FindDMThuoc_ThauByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<DMThuoc_ThauList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static DMThuoc_ThauList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<DMThuoc_ThauList>(new CriteriaOther(1, MaChungLoai));
        //}
        public static DMThuoc_ThauList GetAllDMThuoc_Thau(string mancc,string namthau,  String dk)
        {
            return DataPortal.Fetch<DMThuoc_ThauList>(new Criteria(true,  mancc,namthau, dk));
        }
        public static DMThuoc_ThauList GetDMThuoc_Thau_TOTALBYMAHC(Decimal NgayPnhap, string mancc, string maHC)
        {
            return DataPortal.Fetch<DMThuoc_ThauList>(new CriteriaOther(NgayPnhap, mancc, maHC));
        }
        public DMThuoc_Thau NewTo()
        {
            DMThuoc_Thau obj = DMThuoc_Thau.NewDMThuoc_Thau();
            return obj;
        }
        public void   NewTo(DMThuoc_Thau _DMThuoc_Thau)
        {
           
            try
            {
                if (!Contains(_DMThuoc_Thau.MaThuoc, _DMThuoc_Thau.MaNCC,_DMThuoc_Thau.NamThau  ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMThuoc_Thau.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_DMThuoc_Thau);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMThuoc_Thau.OrderNumber = ++_count;
                        this.Add(_DMThuoc_Thau);
                    }
                    else
                    {
                        _DMThuoc_Thau.OrderNumber = 1;
                        this.Add(_DMThuoc_Thau);

                    }
                }
                else
                    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(HTC.ShareVariables.VAR_DATA+ex.Message);
            }
        }
        public void UpdatedTo(DMThuoc_Thau _DMThuoc_Thau)
        {

            _DMThuoc_Thau.OrderNumber = this.Items[this.IndexOf(_DMThuoc_Thau)].OrderNumber;
            this.Items[this.IndexOf(_DMThuoc_Thau)] = _DMThuoc_Thau;
        }
        public void RemoveTo(DMThuoc_Thau _DMThuoc_Thau)

        {

            if (_DMThuoc_Thau.IsNew == true)
               
              this.Items.Remove(_DMThuoc_Thau);
            else
               Remove(_DMThuoc_Thau);

        }
        public DMThuoc_Thau  AssignTo(DMThuoc_Thau  _DMThuoc_Thau)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                Byte _count = 0;
                _count = (Byte)this.Items.Count;
                // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                _DMThuoc_Thau.OrderNumber = ++_count;
                this.Add(_DMThuoc_Thau);
            }
            else
            {
                _DMThuoc_Thau.OrderNumber = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_DMThuoc_Thau);
            }
            //Add(_PhieuNhap_C);
            return _DMThuoc_Thau;
        }

        //public void Remove(int id)
        //{
        //    foreach (DMThuoc_Thau item in this)
        //    {
        //        if (item.IdCountry == id)
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}

        public bool Contains(string MaThuoc, string MaNCC, string NamThau)
        {
            foreach (DMThuoc_Thau obj in this)
                if ((obj.MaThuoc == MaThuoc) && (obj.MaNCC == MaNCC) && (obj.NamThau == NamThau))
                    return true;
            return false;
        }

        //public DMThuoc_Thau GetDMThuoc_ThauById(string makho, decimal stt, string makhoa)
        //{
        //    foreach (DMThuoc_Thau item in this)
        //        if ((item.Makho == makho) && (item.STT == stt) && (item.Makhoa == makhoa))
        //            return item;
        //    return null;
        //}
        //public void Remove(string makho, int stt,string makhoa)
        //{
        //    foreach (DMThuoc_Thau  item in this)
        //    {
        //        if ((item.Makho == makho  ) && (item.STT == stt)&&(item .Makhoa==makhoa  ))
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}
        public DMThuoc_Thau GetTo(decimal STT) //
        {
            foreach (DMThuoc_Thau obj in this)
                if (obj.OrderNumber == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            DMThuoc_Thau item = DMThuoc_Thau.NewDMThuoc_Thau();
            Add(item);
            return item;
        }

       
      

        private DMThuoc_ThauList()
        {  /* Require use of factory methods */
            this.AllowNew = true;
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
            private Byte _loai = 0;
            public Byte loai
            {
                get
                {
                    return _loai;
                }

            }
            private string _dK = "";
            public string DK
            {
                get
                {
                    return _dK;
                }
            }

            private String _maNCC;
            public String MaNCC
            {
                get
                {
                    return _maNCC;
                }

            }
            private String _namThau;
            public String NamThau
            {
                get
                {
                    return _namThau;
                }

            }
            public Criteria(Boolean qAdmin, string mancc, string namthau, string dK)
            {
                //_qadmin = qAdmin;
                _dK = dK;
              
                _maNCC = mancc;
                _namThau = namthau;

            }
        }
        //private class OtherCriteria
        //{

        //    private String _maThuoc;
        //    public String MaThuoc
        //    {
        //        get
        //        {
        //            return _maThuoc;
        //        }
            
        //    }
        //    private String _maNCC;
        //    public String MaNCC
        //    {
        //        get
        //        {
        //            return _maNCC;
        //        }

        //    }
        //    private String _namThau;
        //    public String NamThau
        //    {
        //        get
        //        {
        //            return _namThau;
        //        }

        //    }
        //    private String _dK;
        //    public String DK
        //    {
        //        get
        //        {
        //            return _dK;
        //        }
        //    }
        //    public OtherCriteria(String MaThuoc,String MaNCC, String NamThau, String DK)
        //    {
        //        _maThuoc = MaThuoc;
        //        _maNCC = MaNCC;
        //        _namThau = NamThau;
        //        _dK = DK;

        //    }
        //}

        //private void DataPortal_Fetch(OtherCriteria OtherCriteria)
        //{
        //    this.RaiseListChangedEvents = false;
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMThuoc_Thau(OtherCriteria.MaThuoc , OtherCriteria.MaNCC ,OtherCriteria.NamThau ,OtherCriteria.DK )))
        //    {
        //        while (dr.Read())
        //        {
        //            this.Add(DMThuoc_Thau.GetDMThuoc_Thau(dr));
        //        }
        //    }
        //    this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        //}
        private class CriteriaOther
        {

             private Boolean _qadmin = false ;
            private string _maThuoc;
            public string maThuoc
            {
                get
                {
                    return _maThuoc;
                }
            }
            public Decimal _NgayPnhap;
            public Decimal NgayPnhap
            {
                get
                {
                    return _NgayPnhap;
                }
            }
            private String _maNCC;
            public String MaNCC
            {
                get
                {
                    return _maNCC;
                }

            }
            public CriteriaOther(Decimal NgayPnhap,string mancc, string maThuoc)
            {
                _NgayPnhap = NgayPnhap;
                _maThuoc = maThuoc;
                _maNCC = mancc;
            }
        }


        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMThuoc_Thau_TOTALBYMATHUOC(criteria.NgayPnhap,criteria.MaNCC ,  criteria.maThuoc)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(DMThuoc_Thau.GetDMThuoc_Thau(dr, i));
                    i += 1;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMThuoc_Thau(criteria.qadmin,criteria.MaNCC,criteria.NamThau ,criteria .DK  )))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(DMThuoc_Thau.GetDMThuoc_Thau(dr, i));
                    i += 1;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
          
            foreach (DMThuoc_Thau item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMThuoc_Thau item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMThuoc_ThauList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMThuoc_ThauList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
